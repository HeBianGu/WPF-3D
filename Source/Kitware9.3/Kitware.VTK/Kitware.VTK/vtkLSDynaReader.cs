using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLSDynaReader
	/// </summary>
	/// <remarks>
	///    Read LS-Dyna databases (d3plot)
	///
	/// This filter reads LS-Dyna databases.
	///
	/// The Set/GetFileName() routines are actually wrappers around the
	/// Set/GetDatabaseDirectory() members; the actual filename you choose is
	/// irrelevant -- only the directory name is used.  This is done in order to
	/// accommodate ParaView.
	///
	/// Note that this reader produces 7 output meshes.
	/// These meshes are required as several attributes are defined on subsets
	/// of the mesh.  Below is a list of meshes in the order they are output and
	/// an explanation of which attributes are unique to each mesh:
	/// - solid (3D) elements: number of integration points are different than 2D
	/// - thick shell elements: number of integration points are different than
	/// planar 2D
	/// - shell (2D) elements: number of integration points are different than 3D
	/// - rigid surfaces: can't have deflection, only velocity, accel, etc.
	/// - road surfaces: have only a "segment ID" (serves as material ID) and a
	/// velocity.
	/// - beam elements: have Frenet (TNB) frame and cross-section attributes
	/// (shape and size)
	/// - spherical particle hydrodynamics (SPH) elements: have a radius of
	/// influence, internal energy, etc.
	/// Because each mesh has its own cell attributes, the vtkLSDynaReader has a
	/// rather large API.  Instead of a single set of routines to query and set
	/// cell array names and status, one exists for each possible output mesh.
	/// Also, GetNumberOfCells() will return the sum of all the cells in all 7
	/// meshes.  If you want the number of cells in a specific mesh, there are
	/// separate routines for each mesh type.
	///
	///
	/// @attention
	/// LSDyna files contain 3 different types of sections: control, data, and
	/// state.  Control sections contain constants that describe the type of
	/// simulation data in a file or group of files.  Data sections contain
	/// simulation information that is invariant across individual time steps
	/// (but can vary when a mesh adaptation occurs).  This information includes
	/// material, connectivity, and undeformed geometry.  Finally, state data is
	/// information that varies with each time step.  Unless a mesh adaptation
	/// occurs, there will be a single control and data section, and they will
	/// be located at the start of the database (the first file).
	///
	/// @attention
	/// In their infinite wisdom, LSDyna developers decided to split simulation
	/// data into multiple files, each no larger than some predetermined limit.
	/// Each file can contain one section, a partial section (if it would not
	/// fit into a single file), or multiple sections. Files are padded with
	/// zeros so that their lengths will be multiples of 512*512.  The size of
	/// each section is determined by constants in the control and data
	/// sections, which means that these must be parsed carefully in order to
	/// correctly locate desired information.  Unfortunately, the constants are
	/// not terribly well-documented and in some cases the documentation is in
	/// error.
	///
	/// @par "Open Issues":
	/// The LS-Dyna file format document leaves a good bit open to
	/// interpretation.  In addition to the "documentation vs. files in the
	/// wild" issues there are also implementation problems.
	///
	/// @par "Open Issues":
	/// - Where exactly may breaks to a new file occur in the pre-state
	/// information? At each section?
	/// - Will state data sections (node/cell data, element deletion, sph data,
	/// rigid body motion) be moved to the beginning of a new file if their data
	/// will be too large for a given file, or are all the sections
	/// counted together as a single state (makes more sense for keeping time
	/// word at start of every file).
	///  The questions above arise because the docs (p. 3) state "There are 3
	/// sections in this database." but then call many smaller pieces of data
	/// "sections". Should they be subsections? The docs are quiet about whether
	/// the second section (of 3) is ever split across multiple files and, if
	/// so, whether it is done at (sub)section boundaries when possible or just
	/// wherever it needs to occur.
	/// - How many components does Eddy Viscosity have? It's shown as 7 bits in
	/// NCFDV1 which makes no sense at all.
	/// - Why is NARBS larger than 10+NUMNP+NEL8+NEL2+NEL4+NELT (which is the
	/// value specified by the documentation)?
	/// Obviously, NARBS is definitive, but what are the extra numbers at the end?
	/// - Is there a difference between rigid body elements NUMRBE and rigid road
	/// surfaces? It appears that the nodes and connectivity of the road surface
	/// are given separately (p.13) while on p.7 the Material
	///   Type Data subsection says that shells in a rigid body will just have a
	/// certain material ID but be interspersed among deformable shell elements.
	/// - Word 37 of the control section serves two possible purposes... it can
	/// mean NMSPH or EDLOPT.
	///   I assume that different versions of the code use that word differently.
	/// How do we know the difference?
	/// - It's unclear how much state isn't stored when a shell element is marked
	/// as rigid. Specifically, is element deletion data stored for rigid shells?
	/// Page 21 of the spec is mute on this.
	/// - The loop to read cell User IDs won't work if Rigid Body and Shell
	/// elements are interleaved (which I now believe they are).
	///
	/// @par "Open Issues":
	/// On the VTK side of things:
	/// - Berk has nudged me towards multiblock outputs but hasn't committed to
	/// exactly how things can be made efficient for a parallel version of the
	/// reader.
	/// - This reader will eventually need to respond to a second output port for
	/// "small spatial, large temporal" queries.
	/// - The reader doesn't handle crack files (d3crck)
	/// - The reader doesn't handle interface force files (no default name)
	/// - The reader doesn't handle time history (abbreviated output) files (d3thdt)
	/// - The reader doesn't handle dynamic relaxation files (d3drfl)
	/// - The reader doesn't handle reduced parts (state for a subset of parts) files (d3part)
	/// - The reader doesn't handle mode shape files (d3eigv)
	/// - The reader doesn't handle equilibrium iteration files (d3iter)
	/// - The reader doesn't handle extra time data files (d3xtf)
	/// - The reader doesn't handle printer files (d3hsp)
	/// - The reader doesn't handle modal neutral files (d3mnf)
	/// - The reader doesn't handle packed connectivity.
	/// - The reader doesn't handle adapted element parent lists (but the 2002 specification says LSDyna
	/// doesn't implement it).
	/// - All the sample datasets have MATTYP = 0. Need something to test MATTYP = 1.
	/// - I have no test datasets with rigid body and/or road surfaces, so the
	/// implementation is half-baked.
	/// - It's unclear how some of the data should be presented. Although blindly
	/// tacking the numbers into a large chuck of cell data is better than nothing,
	/// some attributes (e.g., forces &amp; moments) lend themselves to more elaborate
	/// presentation. Also, shell and thick shell elements have stresses that
	/// belong to a particular side of an element or have a finite thickness that
	/// could be rendered.
	///   Finally, beam elements have cross sections that could be rendered.
	/// Some of these operations require numerical processing of the results and
	/// so we shouldn't eliminate the ability to get at the raw simulation data.
	/// Perhaps a filter could be applied to "fancify" the geometry.
	///
	/// </remarks>
	// Token: 0x02000181 RID: 385
	public class vtkLSDynaReader : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600495C RID: 18780 RVA: 0x0006B3C6 File Offset: 0x000695C6
		static vtkLSDynaReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLSDynaReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLSDynaReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600495D RID: 18781 RVA: 0x0006B3EE File Offset: 0x000695EE
		public vtkLSDynaReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600495E RID: 18782
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLSDynaReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600495F RID: 18783 RVA: 0x0006B3FC File Offset: 0x000695FC
		public new static vtkLSDynaReader New()
		{
			vtkLSDynaReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLSDynaReader.vtkLSDynaReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLSDynaReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004960 RID: 18784 RVA: 0x0006B450 File Offset: 0x00069650
		public vtkLSDynaReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLSDynaReader.vtkLSDynaReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004961 RID: 18785 RVA: 0x0006B494 File Offset: 0x00069694
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004962 RID: 18786
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// Determine if the file can be read with this reader.
		/// </summary>
		// Token: 0x06004963 RID: 18787 RVA: 0x0006B4A0 File Offset: 0x000696A0
		public virtual int CanReadFile(string fname)
		{
			return vtkLSDynaReader.vtkLSDynaReader_CanReadFile_01(base.GetCppThis(), fname);
		}

		// Token: 0x06004964 RID: 18788
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_DebugDump_02(HandleRef pThis);

		/// <summary>
		/// A routine to call Dump() from within a lame debugger that won't
		/// properly pass a C++ iostream object like cout.
		/// </summary>
		// Token: 0x06004965 RID: 18789 RVA: 0x0006B4C0 File Offset: 0x000696C0
		public void DebugDump()
		{
			vtkLSDynaReader.vtkLSDynaReader_DebugDump_02(base.GetCppThis());
		}

		// Token: 0x06004966 RID: 18790
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_DeformedMeshOff_03(HandleRef pThis);

		/// <summary>
		/// Should deflected coordinates be used, or should the mesh remain
		/// undeflected?  By default, this is true but its value is ignored if the
		/// nodal "Deflected Coordinates" array is not set to be loaded.
		/// </summary>
		// Token: 0x06004967 RID: 18791 RVA: 0x0006B4CF File Offset: 0x000696CF
		public virtual void DeformedMeshOff()
		{
			vtkLSDynaReader.vtkLSDynaReader_DeformedMeshOff_03(base.GetCppThis());
		}

		// Token: 0x06004968 RID: 18792
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_DeformedMeshOn_04(HandleRef pThis);

		/// <summary>
		/// Should deflected coordinates be used, or should the mesh remain
		/// undeflected?  By default, this is true but its value is ignored if the
		/// nodal "Deflected Coordinates" array is not set to be loaded.
		/// </summary>
		// Token: 0x06004969 RID: 18793 RVA: 0x0006B4DE File Offset: 0x000696DE
		public virtual void DeformedMeshOn()
		{
			vtkLSDynaReader.vtkLSDynaReader_DeformedMeshOn_04(base.GetCppThis());
		}

		// Token: 0x0600496A RID: 18794
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_DeletedCellsAsGhostArrayOff_05(HandleRef pThis);

		/// <summary>
		/// Instead of removing the cells that are dead, hide them by setting
		/// the array as the ghost levels arrays
		/// </summary>
		// Token: 0x0600496B RID: 18795 RVA: 0x0006B4ED File Offset: 0x000696ED
		public virtual void DeletedCellsAsGhostArrayOff()
		{
			vtkLSDynaReader.vtkLSDynaReader_DeletedCellsAsGhostArrayOff_05(base.GetCppThis());
		}

		// Token: 0x0600496C RID: 18796
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_DeletedCellsAsGhostArrayOn_06(HandleRef pThis);

		/// <summary>
		/// Instead of removing the cells that are dead, hide them by setting
		/// the array as the ghost levels arrays
		/// </summary>
		// Token: 0x0600496D RID: 18797 RVA: 0x0006B4FC File Offset: 0x000696FC
		public virtual void DeletedCellsAsGhostArrayOn()
		{
			vtkLSDynaReader.vtkLSDynaReader_DeletedCellsAsGhostArrayOn_06(base.GetCppThis());
		}

		// Token: 0x0600496E RID: 18798
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLSDynaReader_GetBeamArrayName_07(HandleRef pThis, int arg0);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x0600496F RID: 18799 RVA: 0x0006B50C File Offset: 0x0006970C
		public string GetBeamArrayName(int arg0)
		{
			string s = Marshal.PtrToStringAnsi(vtkLSDynaReader.vtkLSDynaReader_GetBeamArrayName_07(base.GetCppThis(), arg0));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004970 RID: 18800
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetBeamArrayStatus_08(HandleRef pThis, int arr);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x06004971 RID: 18801 RVA: 0x0006B548 File Offset: 0x00069748
		public int GetBeamArrayStatus(int arr)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetBeamArrayStatus_08(base.GetCppThis(), arr);
		}

		// Token: 0x06004972 RID: 18802
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetBeamArrayStatus_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrName);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x06004973 RID: 18803 RVA: 0x0006B568 File Offset: 0x00069768
		public int GetBeamArrayStatus(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetBeamArrayStatus_09(base.GetCppThis(), arrName);
		}

		// Token: 0x06004974 RID: 18804
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLSDynaReader_GetCellArrayName_10(HandleRef pThis, int cellType, int arr);

		/// <summary>
		/// Routines that allow the status of a cell variable to be adjusted or
		/// queried independent of the output mesh.  The \a cellType parameter
		/// should be one of: LS_POINT, LS_BEAM, LS_SHELL, LS_THICK_SHELL,
		/// LS_SOLID, LS_RIGID_BODY, or LS_ROAD_SURFACE
		/// </summary>
		// Token: 0x06004975 RID: 18805 RVA: 0x0006B588 File Offset: 0x00069788
		public string GetCellArrayName(int cellType, int arr)
		{
			string s = Marshal.PtrToStringAnsi(vtkLSDynaReader.vtkLSDynaReader_GetCellArrayName_10(base.GetCppThis(), cellType, arr));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004976 RID: 18806
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetCellArrayStatus_11(HandleRef pThis, int cellType, int arr);

		/// <summary>
		/// Routines that allow the status of a cell variable to be adjusted or
		/// queried independent of the output mesh.  The \a cellType parameter
		/// should be one of: LS_POINT, LS_BEAM, LS_SHELL, LS_THICK_SHELL,
		/// LS_SOLID, LS_RIGID_BODY, or LS_ROAD_SURFACE
		/// </summary>
		// Token: 0x06004977 RID: 18807 RVA: 0x0006B5C4 File Offset: 0x000697C4
		public int GetCellArrayStatus(int cellType, int arr)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetCellArrayStatus_11(base.GetCppThis(), cellType, arr);
		}

		// Token: 0x06004978 RID: 18808
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetCellArrayStatus_12(HandleRef pThis, int cellType, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrName);

		/// <summary>
		/// Routines that allow the status of a cell variable to be adjusted or
		/// queried independent of the output mesh.  The \a cellType parameter
		/// should be one of: LS_POINT, LS_BEAM, LS_SHELL, LS_THICK_SHELL,
		/// LS_SOLID, LS_RIGID_BODY, or LS_ROAD_SURFACE
		/// </summary>
		// Token: 0x06004979 RID: 18809 RVA: 0x0006B5E8 File Offset: 0x000697E8
		public int GetCellArrayStatus(int cellType, string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetCellArrayStatus_12(base.GetCppThis(), cellType, arrName);
		}

		// Token: 0x0600497A RID: 18810
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkLSDynaReader_GetDatabaseDirectory_13(HandleRef pThis);

		/// <summary>
		/// Get/Set the directory containing the LS-Dyna database and determine
		/// whether it is valid.
		/// </summary>
		// Token: 0x0600497B RID: 18811 RVA: 0x0006B60C File Offset: 0x0006980C
		public string GetDatabaseDirectory()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetDatabaseDirectory_13(base.GetCppThis());
		}

		// Token: 0x0600497C RID: 18812
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetDeformedMesh_14(HandleRef pThis);

		/// <summary>
		/// Should deflected coordinates be used, or should the mesh remain
		/// undeflected?  By default, this is true but its value is ignored if the
		/// nodal "Deflected Coordinates" array is not set to be loaded.
		/// </summary>
		// Token: 0x0600497D RID: 18813 RVA: 0x0006B62C File Offset: 0x0006982C
		public virtual int GetDeformedMesh()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetDeformedMesh_14(base.GetCppThis());
		}

		// Token: 0x0600497E RID: 18814
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetDeletedCellsAsGhostArray_15(HandleRef pThis);

		/// <summary>
		/// Instead of removing the cells that are dead, hide them by setting
		/// the array as the ghost levels arrays
		/// </summary>
		// Token: 0x0600497F RID: 18815 RVA: 0x0006B64C File Offset: 0x0006984C
		public virtual int GetDeletedCellsAsGhostArray()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetDeletedCellsAsGhostArray_15(base.GetCppThis());
		}

		// Token: 0x06004980 RID: 18816
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetDimensionality_16(HandleRef pThis);

		/// <summary>
		/// Retrieve the dimension of points in the database. This should return 2
		/// or 3.  Do not call this function before setting the database directory
		/// and calling UpdateInformation().
		/// </summary>
		// Token: 0x06004981 RID: 18817 RVA: 0x0006B66C File Offset: 0x0006986C
		public int GetDimensionality()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetDimensionality_16(base.GetCppThis());
		}

		// Token: 0x06004982 RID: 18818
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkLSDynaReader_GetFileName_17(HandleRef pThis);

		/// <summary>
		/// Get/Set the filename. The Set/GetFileName() routines are actually
		/// wrappers around the Set/GetDatabaseDirectory() members; the actual
		/// filename you choose is irrelevant -- only the directory name is used.
		/// This is done in order to accommodate ParaView.
		/// </summary>
		// Token: 0x06004983 RID: 18819 RVA: 0x0006B68C File Offset: 0x0006988C
		public string GetFileName()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetFileName_17(base.GetCppThis());
		}

		// Token: 0x06004984 RID: 18820
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLSDynaReader_GetInputDeck_18(HandleRef pThis);

		/// <summary>
		/// The name of the input deck corresponding to the current database.
		/// This is used to determine the part names associated with each material ID.
		/// This file may be in two formats: a valid LSDyna input deck or a
		/// short XML summary.
		/// If the file begins with "&lt;?xml" then the summary format is used.
		/// Otherwise, the keyword format is used and a summary file will be
		/// created if write permissions exist in the directory containing
		/// the keyword file. The newly created summary will have ".k" or ".key"
		/// stripped from the end of the keyword filename and ".lsdyna" appended.
		/// </summary>
		// Token: 0x06004985 RID: 18821 RVA: 0x0006B6AC File Offset: 0x000698AC
		public virtual string GetInputDeck()
		{
			string s = Marshal.PtrToStringAnsi(vtkLSDynaReader.vtkLSDynaReader_GetInputDeck_18(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004986 RID: 18822
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetNumberOfBeamArrays_19(HandleRef pThis);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x06004987 RID: 18823 RVA: 0x0006B6E8 File Offset: 0x000698E8
		public int GetNumberOfBeamArrays()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfBeamArrays_19(base.GetCppThis());
		}

		// Token: 0x06004988 RID: 18824
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLSDynaReader_GetNumberOfBeamCells_20(HandleRef pThis);

		/// <summary>
		/// Retrieve the number of cells of a given type in the database.
		/// Do not call this function before setting the database directory and calling
		/// UpdateInformation().
		/// </summary>
		// Token: 0x06004989 RID: 18825 RVA: 0x0006B708 File Offset: 0x00069908
		public long GetNumberOfBeamCells()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfBeamCells_20(base.GetCppThis());
		}

		// Token: 0x0600498A RID: 18826
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetNumberOfCellArrays_21(HandleRef pThis, int cellType);

		/// <summary>
		/// Routines that allow the status of a cell variable to be adjusted or
		/// queried independent of the output mesh.  The \a cellType parameter
		/// should be one of: LS_POINT, LS_BEAM, LS_SHELL, LS_THICK_SHELL,
		/// LS_SOLID, LS_RIGID_BODY, or LS_ROAD_SURFACE
		/// </summary>
		// Token: 0x0600498B RID: 18827 RVA: 0x0006B728 File Offset: 0x00069928
		public int GetNumberOfCellArrays(int cellType)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfCellArrays_21(base.GetCppThis(), cellType);
		}

		// Token: 0x0600498C RID: 18828
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLSDynaReader_GetNumberOfCells_22(HandleRef pThis);

		/// <summary>
		/// Retrieve the number of cells of a given type in the database.  Do not
		/// call this function before setting the database directory and calling
		/// UpdateInformation().
		///
		/// Note that GetNumberOfCells() returns the sum of
		/// GetNumberOfContinuumCells() and GetNumberOfParticleCells().
		/// </summary>
		// Token: 0x0600498D RID: 18829 RVA: 0x0006B748 File Offset: 0x00069948
		public long GetNumberOfCells()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfCells_22(base.GetCppThis());
		}

		// Token: 0x0600498E RID: 18830
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInBeamArray_23(HandleRef pThis, int a);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x0600498F RID: 18831 RVA: 0x0006B768 File Offset: 0x00069968
		public int GetNumberOfComponentsInBeamArray(int a)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInBeamArray_23(base.GetCppThis(), a);
		}

		// Token: 0x06004990 RID: 18832
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInBeamArray_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrName);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x06004991 RID: 18833 RVA: 0x0006B788 File Offset: 0x00069988
		public int GetNumberOfComponentsInBeamArray(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInBeamArray_24(base.GetCppThis(), arrName);
		}

		// Token: 0x06004992 RID: 18834
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInCellArray_25(HandleRef pThis, int cellType, int arr);

		/// <summary>
		/// Routines that allow the status of a cell variable to be adjusted or
		/// queried independent of the output mesh.  The \a cellType parameter
		/// should be one of: LS_POINT, LS_BEAM, LS_SHELL, LS_THICK_SHELL,
		/// LS_SOLID, LS_RIGID_BODY, or LS_ROAD_SURFACE
		/// </summary>
		// Token: 0x06004993 RID: 18835 RVA: 0x0006B7A8 File Offset: 0x000699A8
		public int GetNumberOfComponentsInCellArray(int cellType, int arr)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInCellArray_25(base.GetCppThis(), cellType, arr);
		}

		// Token: 0x06004994 RID: 18836
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInCellArray_26(HandleRef pThis, int cellType, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrName);

		/// <summary>
		/// Routines that allow the status of a cell variable to be adjusted or
		/// queried independent of the output mesh.  The \a cellType parameter
		/// should be one of: LS_POINT, LS_BEAM, LS_SHELL, LS_THICK_SHELL,
		/// LS_SOLID, LS_RIGID_BODY, or LS_ROAD_SURFACE
		/// </summary>
		// Token: 0x06004995 RID: 18837 RVA: 0x0006B7CC File Offset: 0x000699CC
		public int GetNumberOfComponentsInCellArray(int cellType, string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInCellArray_26(base.GetCppThis(), cellType, arrName);
		}

		// Token: 0x06004996 RID: 18838
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInParticleArray_27(HandleRef pThis, int a);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x06004997 RID: 18839 RVA: 0x0006B7F0 File Offset: 0x000699F0
		public int GetNumberOfComponentsInParticleArray(int a)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInParticleArray_27(base.GetCppThis(), a);
		}

		// Token: 0x06004998 RID: 18840
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInParticleArray_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrName);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x06004999 RID: 18841 RVA: 0x0006B810 File Offset: 0x00069A10
		public int GetNumberOfComponentsInParticleArray(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInParticleArray_28(base.GetCppThis(), arrName);
		}

		// Token: 0x0600499A RID: 18842
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInPointArray_29(HandleRef pThis, int arr);

		/// <summary>
		/// These methods allow you to load only selected subsets of the nodal
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x0600499B RID: 18843 RVA: 0x0006B830 File Offset: 0x00069A30
		public int GetNumberOfComponentsInPointArray(int arr)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInPointArray_29(base.GetCppThis(), arr);
		}

		// Token: 0x0600499C RID: 18844
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInPointArray_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrName);

		/// <summary>
		/// These methods allow you to load only selected subsets of the nodal
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x0600499D RID: 18845 RVA: 0x0006B850 File Offset: 0x00069A50
		public int GetNumberOfComponentsInPointArray(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInPointArray_30(base.GetCppThis(), arrName);
		}

		// Token: 0x0600499E RID: 18846
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInRigidBodyArray_31(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrName);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x0600499F RID: 18847 RVA: 0x0006B870 File Offset: 0x00069A70
		public int GetNumberOfComponentsInRigidBodyArray(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInRigidBodyArray_31(base.GetCppThis(), arrName);
		}

		// Token: 0x060049A0 RID: 18848
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInRigidBodyArray_32(HandleRef pThis, int a);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049A1 RID: 18849 RVA: 0x0006B890 File Offset: 0x00069A90
		public int GetNumberOfComponentsInRigidBodyArray(int a)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInRigidBodyArray_32(base.GetCppThis(), a);
		}

		// Token: 0x060049A2 RID: 18850
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInRoadSurfaceArray_33(HandleRef pThis, int a);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049A3 RID: 18851 RVA: 0x0006B8B0 File Offset: 0x00069AB0
		public int GetNumberOfComponentsInRoadSurfaceArray(int a)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInRoadSurfaceArray_33(base.GetCppThis(), a);
		}

		// Token: 0x060049A4 RID: 18852
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInRoadSurfaceArray_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrName);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049A5 RID: 18853 RVA: 0x0006B8D0 File Offset: 0x00069AD0
		public int GetNumberOfComponentsInRoadSurfaceArray(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInRoadSurfaceArray_34(base.GetCppThis(), arrName);
		}

		// Token: 0x060049A6 RID: 18854
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInShellArray_35(HandleRef pThis, int a);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049A7 RID: 18855 RVA: 0x0006B8F0 File Offset: 0x00069AF0
		public int GetNumberOfComponentsInShellArray(int a)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInShellArray_35(base.GetCppThis(), a);
		}

		// Token: 0x060049A8 RID: 18856
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInShellArray_36(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrName);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049A9 RID: 18857 RVA: 0x0006B910 File Offset: 0x00069B10
		public int GetNumberOfComponentsInShellArray(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInShellArray_36(base.GetCppThis(), arrName);
		}

		// Token: 0x060049AA RID: 18858
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInSolidArray_37(HandleRef pThis, int a);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049AB RID: 18859 RVA: 0x0006B930 File Offset: 0x00069B30
		public int GetNumberOfComponentsInSolidArray(int a)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInSolidArray_37(base.GetCppThis(), a);
		}

		// Token: 0x060049AC RID: 18860
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInSolidArray_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrName);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049AD RID: 18861 RVA: 0x0006B950 File Offset: 0x00069B50
		public int GetNumberOfComponentsInSolidArray(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInSolidArray_38(base.GetCppThis(), arrName);
		}

		// Token: 0x060049AE RID: 18862
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInThickShellArray_39(HandleRef pThis, int a);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049AF RID: 18863 RVA: 0x0006B970 File Offset: 0x00069B70
		public int GetNumberOfComponentsInThickShellArray(int a)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInThickShellArray_39(base.GetCppThis(), a);
		}

		// Token: 0x060049B0 RID: 18864
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetNumberOfComponentsInThickShellArray_40(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrName);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049B1 RID: 18865 RVA: 0x0006B990 File Offset: 0x00069B90
		public int GetNumberOfComponentsInThickShellArray(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfComponentsInThickShellArray_40(base.GetCppThis(), arrName);
		}

		// Token: 0x060049B2 RID: 18866
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLSDynaReader_GetNumberOfContinuumCells_41(HandleRef pThis);

		/// <summary>
		/// Retrieve the number of cells of a given type in the database.  Do not
		/// call this function before setting the database directory and calling
		/// UpdateInformation().
		///
		/// Note that GetNumberOfContinuumCells() returns the sum of
		/// GetNumberOfSolidCells(), GetNumberOfThickShellCells(),
		/// GetNumberOfShellCells(), GetNumberOfRigidBodyCells(),
		/// GetNumberOfRoadSurfaceCells(), and GetNumberOfBeamCells().
		/// </summary>
		// Token: 0x060049B3 RID: 18867 RVA: 0x0006B9B0 File Offset: 0x00069BB0
		public long GetNumberOfContinuumCells()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfContinuumCells_41(base.GetCppThis());
		}

		// Token: 0x060049B4 RID: 18868
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLSDynaReader_GetNumberOfGenerationsFromBase_42(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060049B5 RID: 18869 RVA: 0x0006B9D0 File Offset: 0x00069BD0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfGenerationsFromBase_42(base.GetCppThis(), type);
		}

		// Token: 0x060049B6 RID: 18870
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLSDynaReader_GetNumberOfGenerationsFromBaseType_43([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060049B7 RID: 18871 RVA: 0x0006B9F0 File Offset: 0x00069BF0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfGenerationsFromBaseType_43(type);
		}

		// Token: 0x060049B8 RID: 18872
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLSDynaReader_GetNumberOfNodes_44(HandleRef pThis);

		/// <summary>
		/// Retrieve the number of points in the database.  Do not call this
		/// function before setting the database directory and calling
		/// UpdateInformation().
		/// </summary>
		// Token: 0x060049B9 RID: 18873 RVA: 0x0006BA0C File Offset: 0x00069C0C
		public long GetNumberOfNodes()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfNodes_44(base.GetCppThis());
		}

		// Token: 0x060049BA RID: 18874
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetNumberOfPartArrays_45(HandleRef pThis);

		/// <summary>
		/// These methods allow you to load only selected parts of the input.
		/// If InputDeck points to a valid keyword file (or summary), then part
		/// names will be taken from that file.
		/// Otherwise, when arbitrary material numbering is used, parts will be named
		/// "PartXXX (MatlYYY)" where XXX is an increasing sequential number and YYY
		/// is the respective material ID. If no input deck is specified and arbitrary
		/// arbitrary material numbering is not used, parts will be named
		/// "PartXXX" where XXX is a sequential material ID.
		/// </summary>
		// Token: 0x060049BB RID: 18875 RVA: 0x0006BA2C File Offset: 0x00069C2C
		public int GetNumberOfPartArrays()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfPartArrays_45(base.GetCppThis());
		}

		// Token: 0x060049BC RID: 18876
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetNumberOfParticleArrays_46(HandleRef pThis);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049BD RID: 18877 RVA: 0x0006BA4C File Offset: 0x00069C4C
		public int GetNumberOfParticleArrays()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfParticleArrays_46(base.GetCppThis());
		}

		// Token: 0x060049BE RID: 18878
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLSDynaReader_GetNumberOfParticleCells_47(HandleRef pThis);

		/// <summary>
		/// Retrieve the number of cells of a given type in the database.  Do not
		/// call this function before setting the database directory and calling
		/// UpdateInformation().
		/// </summary>
		// Token: 0x060049BF RID: 18879 RVA: 0x0006BA6C File Offset: 0x00069C6C
		public long GetNumberOfParticleCells()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfParticleCells_47(base.GetCppThis());
		}

		// Token: 0x060049C0 RID: 18880
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetNumberOfPointArrays_48(HandleRef pThis);

		/// <summary>
		/// These methods allow you to load only selected subsets of the nodal
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049C1 RID: 18881 RVA: 0x0006BA8C File Offset: 0x00069C8C
		public int GetNumberOfPointArrays()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfPointArrays_48(base.GetCppThis());
		}

		// Token: 0x060049C2 RID: 18882
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetNumberOfRigidBodyArrays_49(HandleRef pThis);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049C3 RID: 18883 RVA: 0x0006BAAC File Offset: 0x00069CAC
		public int GetNumberOfRigidBodyArrays()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfRigidBodyArrays_49(base.GetCppThis());
		}

		// Token: 0x060049C4 RID: 18884
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLSDynaReader_GetNumberOfRigidBodyCells_50(HandleRef pThis);

		/// <summary>
		/// Retrieve the number of cells of a given type in the database.  Do not
		/// call this function before setting the database directory and calling
		/// UpdateInformation().
		/// </summary>
		// Token: 0x060049C5 RID: 18885 RVA: 0x0006BACC File Offset: 0x00069CCC
		public long GetNumberOfRigidBodyCells()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfRigidBodyCells_50(base.GetCppThis());
		}

		// Token: 0x060049C6 RID: 18886
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetNumberOfRoadSurfaceArrays_51(HandleRef pThis);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049C7 RID: 18887 RVA: 0x0006BAEC File Offset: 0x00069CEC
		public int GetNumberOfRoadSurfaceArrays()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfRoadSurfaceArrays_51(base.GetCppThis());
		}

		// Token: 0x060049C8 RID: 18888
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLSDynaReader_GetNumberOfRoadSurfaceCells_52(HandleRef pThis);

		/// <summary>
		/// Retrieve the number of cells of a given type in the database.  Do not
		/// call this function before setting the database directory and calling
		/// UpdateInformation().
		/// </summary>
		// Token: 0x060049C9 RID: 18889 RVA: 0x0006BB0C File Offset: 0x00069D0C
		public long GetNumberOfRoadSurfaceCells()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfRoadSurfaceCells_52(base.GetCppThis());
		}

		// Token: 0x060049CA RID: 18890
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetNumberOfShellArrays_53(HandleRef pThis);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049CB RID: 18891 RVA: 0x0006BB2C File Offset: 0x00069D2C
		public int GetNumberOfShellArrays()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfShellArrays_53(base.GetCppThis());
		}

		// Token: 0x060049CC RID: 18892
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLSDynaReader_GetNumberOfShellCells_54(HandleRef pThis);

		/// <summary>
		/// Retrieve the number of cells of a given type in the database.  Do not
		/// call this function before setting the database directory and calling
		/// UpdateInformation().
		/// </summary>
		// Token: 0x060049CD RID: 18893 RVA: 0x0006BB4C File Offset: 0x00069D4C
		public long GetNumberOfShellCells()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfShellCells_54(base.GetCppThis());
		}

		// Token: 0x060049CE RID: 18894
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetNumberOfSolidArrays_55(HandleRef pThis);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049CF RID: 18895 RVA: 0x0006BB6C File Offset: 0x00069D6C
		public int GetNumberOfSolidArrays()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfSolidArrays_55(base.GetCppThis());
		}

		// Token: 0x060049D0 RID: 18896
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLSDynaReader_GetNumberOfSolidCells_56(HandleRef pThis);

		/// <summary>
		/// Retrieve the number of cells of a given type in the database.  Do not
		/// call this function before setting the database directory and calling
		/// UpdateInformation().
		/// </summary>
		// Token: 0x060049D1 RID: 18897 RVA: 0x0006BB8C File Offset: 0x00069D8C
		public long GetNumberOfSolidCells()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfSolidCells_56(base.GetCppThis());
		}

		// Token: 0x060049D2 RID: 18898
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetNumberOfThickShellArrays_57(HandleRef pThis);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049D3 RID: 18899 RVA: 0x0006BBAC File Offset: 0x00069DAC
		public int GetNumberOfThickShellArrays()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfThickShellArrays_57(base.GetCppThis());
		}

		// Token: 0x060049D4 RID: 18900
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLSDynaReader_GetNumberOfThickShellCells_58(HandleRef pThis);

		/// <summary>
		/// Retrieve the number of cells of a given type in the database.  Do not
		/// call this function before setting the database directory and calling
		/// UpdateInformation().
		/// </summary>
		// Token: 0x060049D5 RID: 18901 RVA: 0x0006BBCC File Offset: 0x00069DCC
		public long GetNumberOfThickShellCells()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfThickShellCells_58(base.GetCppThis());
		}

		// Token: 0x060049D6 RID: 18902
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLSDynaReader_GetNumberOfTimeSteps_59(HandleRef pThis);

		/// <summary>
		/// Retrieve information about the time extents of the LS-Dyna database.
		/// Do not call these functions before setting the database directory and
		/// calling UpdateInformation().
		/// </summary>
		// Token: 0x060049D7 RID: 18903 RVA: 0x0006BBEC File Offset: 0x00069DEC
		public long GetNumberOfTimeSteps()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetNumberOfTimeSteps_59(base.GetCppThis());
		}

		// Token: 0x060049D8 RID: 18904
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLSDynaReader_GetPartArrayName_60(HandleRef pThis, int arg0);

		/// <summary>
		/// These methods allow you to load only selected parts of the input.
		/// If InputDeck points to a valid keyword file (or summary), then part
		/// names will be taken from that file.
		/// Otherwise, when arbitrary material numbering is used, parts will be named
		/// "PartXXX (MatlYYY)" where XXX is an increasing sequential number and YYY
		/// is the respective material ID. If no input deck is specified and arbitrary
		/// arbitrary material numbering is not used, parts will be named
		/// "PartXXX" where XXX is a sequential material ID.
		/// </summary>
		// Token: 0x060049D9 RID: 18905 RVA: 0x0006BC0C File Offset: 0x00069E0C
		public string GetPartArrayName(int arg0)
		{
			string s = Marshal.PtrToStringAnsi(vtkLSDynaReader.vtkLSDynaReader_GetPartArrayName_60(base.GetCppThis(), arg0));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060049DA RID: 18906
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetPartArrayStatus_61(HandleRef pThis, int arr);

		/// <summary>
		/// These methods allow you to load only selected parts of the input.
		/// If InputDeck points to a valid keyword file (or summary), then part
		/// names will be taken from that file.
		/// Otherwise, when arbitrary material numbering is used, parts will be named
		/// "PartXXX (MatlYYY)" where XXX is an increasing sequential number and YYY
		/// is the respective material ID. If no input deck is specified and arbitrary
		/// arbitrary material numbering is not used, parts will be named
		/// "PartXXX" where XXX is a sequential material ID.
		/// </summary>
		// Token: 0x060049DB RID: 18907 RVA: 0x0006BC48 File Offset: 0x00069E48
		public int GetPartArrayStatus(int arr)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetPartArrayStatus_61(base.GetCppThis(), arr);
		}

		// Token: 0x060049DC RID: 18908
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetPartArrayStatus_62(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string partName);

		/// <summary>
		/// These methods allow you to load only selected parts of the input.
		/// If InputDeck points to a valid keyword file (or summary), then part
		/// names will be taken from that file.
		/// Otherwise, when arbitrary material numbering is used, parts will be named
		/// "PartXXX (MatlYYY)" where XXX is an increasing sequential number and YYY
		/// is the respective material ID. If no input deck is specified and arbitrary
		/// arbitrary material numbering is not used, parts will be named
		/// "PartXXX" where XXX is a sequential material ID.
		/// </summary>
		// Token: 0x060049DD RID: 18909 RVA: 0x0006BC68 File Offset: 0x00069E68
		public int GetPartArrayStatus(string partName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetPartArrayStatus_62(base.GetCppThis(), partName);
		}

		// Token: 0x060049DE RID: 18910
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLSDynaReader_GetParticleArrayName_63(HandleRef pThis, int arg0);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049DF RID: 18911 RVA: 0x0006BC88 File Offset: 0x00069E88
		public string GetParticleArrayName(int arg0)
		{
			string s = Marshal.PtrToStringAnsi(vtkLSDynaReader.vtkLSDynaReader_GetParticleArrayName_63(base.GetCppThis(), arg0));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060049E0 RID: 18912
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetParticleArrayStatus_64(HandleRef pThis, int arr);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049E1 RID: 18913 RVA: 0x0006BCC4 File Offset: 0x00069EC4
		public int GetParticleArrayStatus(int arr)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetParticleArrayStatus_64(base.GetCppThis(), arr);
		}

		// Token: 0x060049E2 RID: 18914
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetParticleArrayStatus_65(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrName);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049E3 RID: 18915 RVA: 0x0006BCE4 File Offset: 0x00069EE4
		public int GetParticleArrayStatus(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetParticleArrayStatus_65(base.GetCppThis(), arrName);
		}

		// Token: 0x060049E4 RID: 18916
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLSDynaReader_GetPointArrayName_66(HandleRef pThis, int arg0);

		/// <summary>
		/// These methods allow you to load only selected subsets of the nodal
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049E5 RID: 18917 RVA: 0x0006BD04 File Offset: 0x00069F04
		public string GetPointArrayName(int arg0)
		{
			string s = Marshal.PtrToStringAnsi(vtkLSDynaReader.vtkLSDynaReader_GetPointArrayName_66(base.GetCppThis(), arg0));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060049E6 RID: 18918
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetPointArrayStatus_67(HandleRef pThis, int arr);

		/// <summary>
		/// These methods allow you to load only selected subsets of the nodal
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049E7 RID: 18919 RVA: 0x0006BD40 File Offset: 0x00069F40
		public int GetPointArrayStatus(int arr)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetPointArrayStatus_67(base.GetCppThis(), arr);
		}

		// Token: 0x060049E8 RID: 18920
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetPointArrayStatus_68(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrName);

		/// <summary>
		/// These methods allow you to load only selected subsets of the nodal
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049E9 RID: 18921 RVA: 0x0006BD60 File Offset: 0x00069F60
		public int GetPointArrayStatus(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetPointArrayStatus_68(base.GetCppThis(), arrName);
		}

		// Token: 0x060049EA RID: 18922
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetRemoveDeletedCells_69(HandleRef pThis);

		/// <summary>
		/// Should dead cells be removed from the mesh?  Cells are marked dead by
		/// setting the corresponding entry in the &lt;b&gt;cell&lt;/b&gt; array "Death" to 0.
		/// Cells that are not dead have the corresponding entry in the cell array
		/// "Death" set to their material ID.  By default, this is true but its
		/// value is ignored if the cell "Death" array is not set to be loaded.
		/// It is also ignored if the database's element deletion option is set to
		/// denote &lt;b&gt;points&lt;/b&gt; (not cells) as deleted; in that case, "Death"
		/// will appear to be a point array.
		/// </summary>
		// Token: 0x060049EB RID: 18923 RVA: 0x0006BD80 File Offset: 0x00069F80
		public virtual int GetRemoveDeletedCells()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetRemoveDeletedCells_69(base.GetCppThis());
		}

		// Token: 0x060049EC RID: 18924
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLSDynaReader_GetRigidBodyArrayName_70(HandleRef pThis, int arg0);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049ED RID: 18925 RVA: 0x0006BDA0 File Offset: 0x00069FA0
		public string GetRigidBodyArrayName(int arg0)
		{
			string s = Marshal.PtrToStringAnsi(vtkLSDynaReader.vtkLSDynaReader_GetRigidBodyArrayName_70(base.GetCppThis(), arg0));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060049EE RID: 18926
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetRigidBodyArrayStatus_71(HandleRef pThis, int arr);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049EF RID: 18927 RVA: 0x0006BDDC File Offset: 0x00069FDC
		public int GetRigidBodyArrayStatus(int arr)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetRigidBodyArrayStatus_71(base.GetCppThis(), arr);
		}

		// Token: 0x060049F0 RID: 18928
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetRigidBodyArrayStatus_72(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrName);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049F1 RID: 18929 RVA: 0x0006BDFC File Offset: 0x00069FFC
		public int GetRigidBodyArrayStatus(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetRigidBodyArrayStatus_72(base.GetCppThis(), arrName);
		}

		// Token: 0x060049F2 RID: 18930
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLSDynaReader_GetRoadSurfaceArrayName_73(HandleRef pThis, int arg0);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049F3 RID: 18931 RVA: 0x0006BE1C File Offset: 0x0006A01C
		public string GetRoadSurfaceArrayName(int arg0)
		{
			string s = Marshal.PtrToStringAnsi(vtkLSDynaReader.vtkLSDynaReader_GetRoadSurfaceArrayName_73(base.GetCppThis(), arg0));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060049F4 RID: 18932
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetRoadSurfaceArrayStatus_74(HandleRef pThis, int arr);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049F5 RID: 18933 RVA: 0x0006BE58 File Offset: 0x0006A058
		public int GetRoadSurfaceArrayStatus(int arr)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetRoadSurfaceArrayStatus_74(base.GetCppThis(), arr);
		}

		// Token: 0x060049F6 RID: 18934
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetRoadSurfaceArrayStatus_75(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrName);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049F7 RID: 18935 RVA: 0x0006BE78 File Offset: 0x0006A078
		public int GetRoadSurfaceArrayStatus(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetRoadSurfaceArrayStatus_75(base.GetCppThis(), arrName);
		}

		// Token: 0x060049F8 RID: 18936
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLSDynaReader_GetShellArrayName_76(HandleRef pThis, int arg0);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049F9 RID: 18937 RVA: 0x0006BE98 File Offset: 0x0006A098
		public string GetShellArrayName(int arg0)
		{
			string s = Marshal.PtrToStringAnsi(vtkLSDynaReader.vtkLSDynaReader_GetShellArrayName_76(base.GetCppThis(), arg0));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060049FA RID: 18938
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetShellArrayStatus_77(HandleRef pThis, int arr);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049FB RID: 18939 RVA: 0x0006BED4 File Offset: 0x0006A0D4
		public int GetShellArrayStatus(int arr)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetShellArrayStatus_77(base.GetCppThis(), arr);
		}

		// Token: 0x060049FC RID: 18940
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetShellArrayStatus_78(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrName);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049FD RID: 18941 RVA: 0x0006BEF4 File Offset: 0x0006A0F4
		public int GetShellArrayStatus(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetShellArrayStatus_78(base.GetCppThis(), arrName);
		}

		// Token: 0x060049FE RID: 18942
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLSDynaReader_GetSolidArrayName_79(HandleRef pThis, int arg0);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x060049FF RID: 18943 RVA: 0x0006BF14 File Offset: 0x0006A114
		public string GetSolidArrayName(int arg0)
		{
			string s = Marshal.PtrToStringAnsi(vtkLSDynaReader.vtkLSDynaReader_GetSolidArrayName_79(base.GetCppThis(), arg0));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004A00 RID: 18944
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetSolidArrayStatus_80(HandleRef pThis, int arr);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x06004A01 RID: 18945 RVA: 0x0006BF50 File Offset: 0x0006A150
		public int GetSolidArrayStatus(int arr)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetSolidArrayStatus_80(base.GetCppThis(), arr);
		}

		// Token: 0x06004A02 RID: 18946
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetSolidArrayStatus_81(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrName);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x06004A03 RID: 18947 RVA: 0x0006BF70 File Offset: 0x0006A170
		public int GetSolidArrayStatus(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetSolidArrayStatus_81(base.GetCppThis(), arrName);
		}

		// Token: 0x06004A04 RID: 18948
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLSDynaReader_GetThickShellArrayName_82(HandleRef pThis, int arg0);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x06004A05 RID: 18949 RVA: 0x0006BF90 File Offset: 0x0006A190
		public string GetThickShellArrayName(int arg0)
		{
			string s = Marshal.PtrToStringAnsi(vtkLSDynaReader.vtkLSDynaReader_GetThickShellArrayName_82(base.GetCppThis(), arg0));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004A06 RID: 18950
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetThickShellArrayStatus_83(HandleRef pThis, int arr);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x06004A07 RID: 18951 RVA: 0x0006BFCC File Offset: 0x0006A1CC
		public int GetThickShellArrayStatus(int arr)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetThickShellArrayStatus_83(base.GetCppThis(), arr);
		}

		// Token: 0x06004A08 RID: 18952
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_GetThickShellArrayStatus_84(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrName);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x06004A09 RID: 18953 RVA: 0x0006BFEC File Offset: 0x0006A1EC
		public int GetThickShellArrayStatus(string arrName)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetThickShellArrayStatus_84(base.GetCppThis(), arrName);
		}

		// Token: 0x06004A0A RID: 18954
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLSDynaReader_GetTimeStep_85(HandleRef pThis);

		/// <summary>
		/// Retrieve information about the time extents of the LS-Dyna database.
		/// Do not call these functions before setting the database directory and
		/// calling UpdateInformation().
		/// </summary>
		// Token: 0x06004A0B RID: 18955 RVA: 0x0006C00C File Offset: 0x0006A20C
		public long GetTimeStep()
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetTimeStep_85(base.GetCppThis());
		}

		// Token: 0x06004A0C RID: 18956
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLSDynaReader_GetTimeStepRange_86(HandleRef pThis);

		/// <summary>
		/// Retrieve information about the time extents of the LS-Dyna database.
		/// Do not call these functions before setting the database directory and
		/// calling UpdateInformation().
		/// </summary>
		// Token: 0x06004A0D RID: 18957 RVA: 0x0006C02C File Offset: 0x0006A22C
		public virtual int[] GetTimeStepRange()
		{
			IntPtr intPtr = vtkLSDynaReader.vtkLSDynaReader_GetTimeStepRange_86(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06004A0E RID: 18958
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_GetTimeStepRange_87(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Retrieve information about the time extents of the LS-Dyna database.
		/// Do not call these functions before setting the database directory and
		/// calling UpdateInformation().
		/// </summary>
		// Token: 0x06004A0F RID: 18959 RVA: 0x0006C074 File Offset: 0x0006A274
		public virtual void GetTimeStepRange(ref int _arg1, ref int _arg2)
		{
			vtkLSDynaReader.vtkLSDynaReader_GetTimeStepRange_87(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06004A10 RID: 18960
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_GetTimeStepRange_88(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Retrieve information about the time extents of the LS-Dyna database.
		/// Do not call these functions before setting the database directory and
		/// calling UpdateInformation().
		/// </summary>
		// Token: 0x06004A11 RID: 18961 RVA: 0x0006C085 File Offset: 0x0006A285
		public virtual void GetTimeStepRange(IntPtr _arg)
		{
			vtkLSDynaReader.vtkLSDynaReader_GetTimeStepRange_88(base.GetCppThis(), _arg);
		}

		// Token: 0x06004A12 RID: 18962
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLSDynaReader_GetTimeValue_89(HandleRef pThis, long arg0);

		/// <summary>
		/// Retrieve information about the time extents of the LS-Dyna database.
		/// Do not call these functions before setting the database directory and
		/// calling UpdateInformation().
		/// </summary>
		// Token: 0x06004A13 RID: 18963 RVA: 0x0006C098 File Offset: 0x0006A298
		public double GetTimeValue(long arg0)
		{
			return vtkLSDynaReader.vtkLSDynaReader_GetTimeValue_89(base.GetCppThis(), arg0);
		}

		// Token: 0x06004A14 RID: 18964
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLSDynaReader_GetTitle_90(HandleRef pThis);

		/// <summary>
		/// The title of the database is a 40 or 80 character text description
		/// stored at the front of a d3plot file.  Do not call this function
		/// before setting the database directory and calling UpdateInformation().
		/// </summary>
		// Token: 0x06004A15 RID: 18965 RVA: 0x0006C0B8 File Offset: 0x0006A2B8
		public string GetTitle()
		{
			string s = Marshal.PtrToStringAnsi(vtkLSDynaReader.vtkLSDynaReader_GetTitle_90(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004A16 RID: 18966
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_IsA_91(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004A17 RID: 18967 RVA: 0x0006C0F4 File Offset: 0x0006A2F4
		public override int IsA(string type)
		{
			return vtkLSDynaReader.vtkLSDynaReader_IsA_91(base.GetCppThis(), type);
		}

		// Token: 0x06004A18 RID: 18968
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_IsDatabaseValid_92(HandleRef pThis);

		/// <summary>
		/// Get/Set the directory containing the LS-Dyna database and determine
		/// whether it is valid.
		/// </summary>
		// Token: 0x06004A19 RID: 18969 RVA: 0x0006C114 File Offset: 0x0006A314
		public int IsDatabaseValid()
		{
			return vtkLSDynaReader.vtkLSDynaReader_IsDatabaseValid_92(base.GetCppThis());
		}

		// Token: 0x06004A1A RID: 18970
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLSDynaReader_IsTypeOf_93([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004A1B RID: 18971 RVA: 0x0006C134 File Offset: 0x0006A334
		public new static int IsTypeOf(string type)
		{
			return vtkLSDynaReader.vtkLSDynaReader_IsTypeOf_93(type);
		}

		// Token: 0x06004A1C RID: 18972
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLSDynaReader_NewInstance_95(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004A1D RID: 18973 RVA: 0x0006C150 File Offset: 0x0006A350
		public new vtkLSDynaReader NewInstance()
		{
			vtkLSDynaReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLSDynaReader.vtkLSDynaReader_NewInstance_95(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLSDynaReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004A1E RID: 18974
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_RemoveDeletedCellsOff_96(HandleRef pThis);

		/// <summary>
		/// Should dead cells be removed from the mesh?  Cells are marked dead by
		/// setting the corresponding entry in the &lt;b&gt;cell&lt;/b&gt; array "Death" to 0.
		/// Cells that are not dead have the corresponding entry in the cell array
		/// "Death" set to their material ID.  By default, this is true but its
		/// value is ignored if the cell "Death" array is not set to be loaded.
		/// It is also ignored if the database's element deletion option is set to
		/// denote &lt;b&gt;points&lt;/b&gt; (not cells) as deleted; in that case, "Death"
		/// will appear to be a point array.
		/// </summary>
		// Token: 0x06004A1F RID: 18975 RVA: 0x0006C1AA File Offset: 0x0006A3AA
		public virtual void RemoveDeletedCellsOff()
		{
			vtkLSDynaReader.vtkLSDynaReader_RemoveDeletedCellsOff_96(base.GetCppThis());
		}

		// Token: 0x06004A20 RID: 18976
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_RemoveDeletedCellsOn_97(HandleRef pThis);

		/// <summary>
		/// Should dead cells be removed from the mesh?  Cells are marked dead by
		/// setting the corresponding entry in the &lt;b&gt;cell&lt;/b&gt; array "Death" to 0.
		/// Cells that are not dead have the corresponding entry in the cell array
		/// "Death" set to their material ID.  By default, this is true but its
		/// value is ignored if the cell "Death" array is not set to be loaded.
		/// It is also ignored if the database's element deletion option is set to
		/// denote &lt;b&gt;points&lt;/b&gt; (not cells) as deleted; in that case, "Death"
		/// will appear to be a point array.
		/// </summary>
		// Token: 0x06004A21 RID: 18977 RVA: 0x0006C1B9 File Offset: 0x0006A3B9
		public virtual void RemoveDeletedCellsOn()
		{
			vtkLSDynaReader.vtkLSDynaReader_RemoveDeletedCellsOn_97(base.GetCppThis());
		}

		// Token: 0x06004A22 RID: 18978
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLSDynaReader_SafeDownCast_98(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004A23 RID: 18979 RVA: 0x0006C1C8 File Offset: 0x0006A3C8
		public new static vtkLSDynaReader SafeDownCast(vtkObjectBase o)
		{
			vtkLSDynaReader vtkLSDynaReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLSDynaReader.vtkLSDynaReader_SafeDownCast_98((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLSDynaReader = (vtkLSDynaReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLSDynaReader.Register(null);
				}
			}
			return vtkLSDynaReader;
		}

		// Token: 0x06004A24 RID: 18980
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_SetBeamArrayStatus_99(HandleRef pThis, int arr, int status);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x06004A25 RID: 18981 RVA: 0x0006C247 File Offset: 0x0006A447
		public virtual void SetBeamArrayStatus(int arr, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetBeamArrayStatus_99(base.GetCppThis(), arr, status);
		}

		// Token: 0x06004A26 RID: 18982
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_SetBeamArrayStatus_100(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrName, int status);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x06004A27 RID: 18983 RVA: 0x0006C258 File Offset: 0x0006A458
		public virtual void SetBeamArrayStatus(string arrName, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetBeamArrayStatus_100(base.GetCppThis(), arrName, status);
		}

		// Token: 0x06004A28 RID: 18984
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_SetCellArrayStatus_101(HandleRef pThis, int cellType, int arr, int status);

		/// <summary>
		/// Routines that allow the status of a cell variable to be adjusted or
		/// queried independent of the output mesh.  The \a cellType parameter
		/// should be one of: LS_POINT, LS_BEAM, LS_SHELL, LS_THICK_SHELL,
		/// LS_SOLID, LS_RIGID_BODY, or LS_ROAD_SURFACE
		/// </summary>
		// Token: 0x06004A29 RID: 18985 RVA: 0x0006C269 File Offset: 0x0006A469
		public virtual void SetCellArrayStatus(int cellType, int arr, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetCellArrayStatus_101(base.GetCppThis(), cellType, arr, status);
		}

		// Token: 0x06004A2A RID: 18986
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_SetCellArrayStatus_102(HandleRef pThis, int cellType, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrName, int status);

		/// <summary>
		/// Routines that allow the status of a cell variable to be adjusted or
		/// queried independent of the output mesh.  The \a cellType parameter
		/// should be one of: LS_POINT, LS_BEAM, LS_SHELL, LS_THICK_SHELL,
		/// LS_SOLID, LS_RIGID_BODY, or LS_ROAD_SURFACE
		/// </summary>
		// Token: 0x06004A2B RID: 18987 RVA: 0x0006C27B File Offset: 0x0006A47B
		public virtual void SetCellArrayStatus(int cellType, string arrName, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetCellArrayStatus_102(base.GetCppThis(), cellType, arrName, status);
		}

		// Token: 0x06004A2C RID: 18988
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_SetDatabaseDirectory_103(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Get/Set the directory containing the LS-Dyna database and determine
		/// whether it is valid.
		/// </summary>
		// Token: 0x06004A2D RID: 18989 RVA: 0x0006C28D File Offset: 0x0006A48D
		public virtual void SetDatabaseDirectory(string arg0)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetDatabaseDirectory_103(base.GetCppThis(), arg0);
		}

		// Token: 0x06004A2E RID: 18990
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_SetDeformedMesh_104(HandleRef pThis, int arg0);

		/// <summary>
		/// Should deflected coordinates be used, or should the mesh remain
		/// undeflected?  By default, this is true but its value is ignored if the
		/// nodal "Deflected Coordinates" array is not set to be loaded.
		/// </summary>
		// Token: 0x06004A2F RID: 18991 RVA: 0x0006C29D File Offset: 0x0006A49D
		public void SetDeformedMesh(int arg0)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetDeformedMesh_104(base.GetCppThis(), arg0);
		}

		// Token: 0x06004A30 RID: 18992
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_SetDeletedCellsAsGhostArray_105(HandleRef pThis, int _arg);

		/// <summary>
		/// Instead of removing the cells that are dead, hide them by setting
		/// the array as the ghost levels arrays
		/// </summary>
		// Token: 0x06004A31 RID: 18993 RVA: 0x0006C2AD File Offset: 0x0006A4AD
		public virtual void SetDeletedCellsAsGhostArray(int _arg)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetDeletedCellsAsGhostArray_105(base.GetCppThis(), _arg);
		}

		// Token: 0x06004A32 RID: 18994
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_SetFileName_106(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Get/Set the filename. The Set/GetFileName() routines are actually
		/// wrappers around the Set/GetDatabaseDirectory() members; the actual
		/// filename you choose is irrelevant -- only the directory name is used.
		/// This is done in order to accommodate ParaView.
		/// </summary>
		// Token: 0x06004A33 RID: 18995 RVA: 0x0006C2BD File Offset: 0x0006A4BD
		public virtual void SetFileName(string arg0)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetFileName_106(base.GetCppThis(), arg0);
		}

		// Token: 0x06004A34 RID: 18996
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_SetInputDeck_107(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The name of the input deck corresponding to the current database.
		/// This is used to determine the part names associated with each material ID.
		/// This file may be in two formats: a valid LSDyna input deck or a
		/// short XML summary.
		/// If the file begins with "&lt;?xml" then the summary format is used.
		/// Otherwise, the keyword format is used and a summary file will be
		/// created if write permissions exist in the directory containing
		/// the keyword file. The newly created summary will have ".k" or ".key"
		/// stripped from the end of the keyword filename and ".lsdyna" appended.
		/// </summary>
		// Token: 0x06004A35 RID: 18997 RVA: 0x0006C2CD File Offset: 0x0006A4CD
		public virtual void SetInputDeck(string _arg)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetInputDeck_107(base.GetCppThis(), _arg);
		}

		// Token: 0x06004A36 RID: 18998
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_SetPartArrayStatus_108(HandleRef pThis, int arr, int status);

		/// <summary>
		/// These methods allow you to load only selected parts of the input.
		/// If InputDeck points to a valid keyword file (or summary), then part
		/// names will be taken from that file.
		/// Otherwise, when arbitrary material numbering is used, parts will be named
		/// "PartXXX (MatlYYY)" where XXX is an increasing sequential number and YYY
		/// is the respective material ID. If no input deck is specified and arbitrary
		/// arbitrary material numbering is not used, parts will be named
		/// "PartXXX" where XXX is a sequential material ID.
		/// </summary>
		// Token: 0x06004A37 RID: 18999 RVA: 0x0006C2DD File Offset: 0x0006A4DD
		public virtual void SetPartArrayStatus(int arr, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetPartArrayStatus_108(base.GetCppThis(), arr, status);
		}

		// Token: 0x06004A38 RID: 19000
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_SetPartArrayStatus_109(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string partName, int status);

		/// <summary>
		/// These methods allow you to load only selected parts of the input.
		/// If InputDeck points to a valid keyword file (or summary), then part
		/// names will be taken from that file.
		/// Otherwise, when arbitrary material numbering is used, parts will be named
		/// "PartXXX (MatlYYY)" where XXX is an increasing sequential number and YYY
		/// is the respective material ID. If no input deck is specified and arbitrary
		/// arbitrary material numbering is not used, parts will be named
		/// "PartXXX" where XXX is a sequential material ID.
		/// </summary>
		// Token: 0x06004A39 RID: 19001 RVA: 0x0006C2EE File Offset: 0x0006A4EE
		public virtual void SetPartArrayStatus(string partName, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetPartArrayStatus_109(base.GetCppThis(), partName, status);
		}

		// Token: 0x06004A3A RID: 19002
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_SetParticleArrayStatus_110(HandleRef pThis, int arr, int status);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x06004A3B RID: 19003 RVA: 0x0006C2FF File Offset: 0x0006A4FF
		public virtual void SetParticleArrayStatus(int arr, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetParticleArrayStatus_110(base.GetCppThis(), arr, status);
		}

		// Token: 0x06004A3C RID: 19004
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_SetParticleArrayStatus_111(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrName, int status);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x06004A3D RID: 19005 RVA: 0x0006C310 File Offset: 0x0006A510
		public virtual void SetParticleArrayStatus(string arrName, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetParticleArrayStatus_111(base.GetCppThis(), arrName, status);
		}

		// Token: 0x06004A3E RID: 19006
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_SetPointArrayStatus_112(HandleRef pThis, int arr, int status);

		/// <summary>
		/// These methods allow you to load only selected subsets of the nodal
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x06004A3F RID: 19007 RVA: 0x0006C321 File Offset: 0x0006A521
		public virtual void SetPointArrayStatus(int arr, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetPointArrayStatus_112(base.GetCppThis(), arr, status);
		}

		// Token: 0x06004A40 RID: 19008
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_SetPointArrayStatus_113(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrName, int status);

		/// <summary>
		/// These methods allow you to load only selected subsets of the nodal
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x06004A41 RID: 19009 RVA: 0x0006C332 File Offset: 0x0006A532
		public virtual void SetPointArrayStatus(string arrName, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetPointArrayStatus_113(base.GetCppThis(), arrName, status);
		}

		// Token: 0x06004A42 RID: 19010
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_SetRemoveDeletedCells_114(HandleRef pThis, int _arg);

		/// <summary>
		/// Should dead cells be removed from the mesh?  Cells are marked dead by
		/// setting the corresponding entry in the &lt;b&gt;cell&lt;/b&gt; array "Death" to 0.
		/// Cells that are not dead have the corresponding entry in the cell array
		/// "Death" set to their material ID.  By default, this is true but its
		/// value is ignored if the cell "Death" array is not set to be loaded.
		/// It is also ignored if the database's element deletion option is set to
		/// denote &lt;b&gt;points&lt;/b&gt; (not cells) as deleted; in that case, "Death"
		/// will appear to be a point array.
		/// </summary>
		// Token: 0x06004A43 RID: 19011 RVA: 0x0006C343 File Offset: 0x0006A543
		public virtual void SetRemoveDeletedCells(int _arg)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetRemoveDeletedCells_114(base.GetCppThis(), _arg);
		}

		// Token: 0x06004A44 RID: 19012
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_SetRigidBodyArrayStatus_115(HandleRef pThis, int arr, int status);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x06004A45 RID: 19013 RVA: 0x0006C353 File Offset: 0x0006A553
		public virtual void SetRigidBodyArrayStatus(int arr, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetRigidBodyArrayStatus_115(base.GetCppThis(), arr, status);
		}

		// Token: 0x06004A46 RID: 19014
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_SetRigidBodyArrayStatus_116(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrName, int status);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x06004A47 RID: 19015 RVA: 0x0006C364 File Offset: 0x0006A564
		public virtual void SetRigidBodyArrayStatus(string arrName, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetRigidBodyArrayStatus_116(base.GetCppThis(), arrName, status);
		}

		// Token: 0x06004A48 RID: 19016
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_SetRoadSurfaceArrayStatus_117(HandleRef pThis, int arr, int status);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x06004A49 RID: 19017 RVA: 0x0006C375 File Offset: 0x0006A575
		public virtual void SetRoadSurfaceArrayStatus(int arr, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetRoadSurfaceArrayStatus_117(base.GetCppThis(), arr, status);
		}

		// Token: 0x06004A4A RID: 19018
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_SetRoadSurfaceArrayStatus_118(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrName, int status);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x06004A4B RID: 19019 RVA: 0x0006C386 File Offset: 0x0006A586
		public virtual void SetRoadSurfaceArrayStatus(string arrName, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetRoadSurfaceArrayStatus_118(base.GetCppThis(), arrName, status);
		}

		// Token: 0x06004A4C RID: 19020
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_SetShellArrayStatus_119(HandleRef pThis, int arr, int status);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x06004A4D RID: 19021 RVA: 0x0006C397 File Offset: 0x0006A597
		public virtual void SetShellArrayStatus(int arr, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetShellArrayStatus_119(base.GetCppThis(), arr, status);
		}

		// Token: 0x06004A4E RID: 19022
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_SetShellArrayStatus_120(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrName, int status);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x06004A4F RID: 19023 RVA: 0x0006C3A8 File Offset: 0x0006A5A8
		public virtual void SetShellArrayStatus(string arrName, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetShellArrayStatus_120(base.GetCppThis(), arrName, status);
		}

		// Token: 0x06004A50 RID: 19024
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_SetSolidArrayStatus_121(HandleRef pThis, int arr, int status);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x06004A51 RID: 19025 RVA: 0x0006C3B9 File Offset: 0x0006A5B9
		public virtual void SetSolidArrayStatus(int arr, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetSolidArrayStatus_121(base.GetCppThis(), arr, status);
		}

		// Token: 0x06004A52 RID: 19026
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_SetSolidArrayStatus_122(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrName, int status);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x06004A53 RID: 19027 RVA: 0x0006C3CA File Offset: 0x0006A5CA
		public virtual void SetSolidArrayStatus(string arrName, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetSolidArrayStatus_122(base.GetCppThis(), arrName, status);
		}

		// Token: 0x06004A54 RID: 19028
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_SetThickShellArrayStatus_123(HandleRef pThis, int arr, int status);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x06004A55 RID: 19029 RVA: 0x0006C3DB File Offset: 0x0006A5DB
		public virtual void SetThickShellArrayStatus(int arr, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetThickShellArrayStatus_123(base.GetCppThis(), arr, status);
		}

		// Token: 0x06004A56 RID: 19030
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_SetThickShellArrayStatus_124(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrName, int status);

		/// <summary>
		/// These methods allow you to load only selected subsets of the cell
		/// variables defined over the mesh.
		/// </summary>
		// Token: 0x06004A57 RID: 19031 RVA: 0x0006C3EC File Offset: 0x0006A5EC
		public virtual void SetThickShellArrayStatus(string arrName, int status)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetThickShellArrayStatus_124(base.GetCppThis(), arrName, status);
		}

		// Token: 0x06004A58 RID: 19032
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_SetTimeStep_125(HandleRef pThis, long arg0);

		/// <summary>
		/// Retrieve information about the time extents of the LS-Dyna database.
		/// Do not call these functions before setting the database directory and
		/// calling UpdateInformation().
		/// </summary>
		// Token: 0x06004A59 RID: 19033 RVA: 0x0006C3FD File Offset: 0x0006A5FD
		public virtual void SetTimeStep(long arg0)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetTimeStep_125(base.GetCppThis(), arg0);
		}

		// Token: 0x06004A5A RID: 19034
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_SetTimeStepRange_126(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Retrieve information about the time extents of the LS-Dyna database.
		/// Do not call these functions before setting the database directory and
		/// calling UpdateInformation().
		/// </summary>
		// Token: 0x06004A5B RID: 19035 RVA: 0x0006C40D File Offset: 0x0006A60D
		public virtual void SetTimeStepRange(int _arg1, int _arg2)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetTimeStepRange_126(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06004A5C RID: 19036
		[DllImport("Kitware.VTK.IOLSDyna.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLSDynaReader_SetTimeStepRange_127(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Retrieve information about the time extents of the LS-Dyna database.
		/// Do not call these functions before setting the database directory and
		/// calling UpdateInformation().
		/// </summary>
		// Token: 0x06004A5D RID: 19037 RVA: 0x0006C41E File Offset: 0x0006A61E
		public void SetTimeStepRange(IntPtr _arg)
		{
			vtkLSDynaReader.vtkLSDynaReader_SetTimeStepRange_127(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000753 RID: 1875
		public new const string MRFullTypeName = "Kitware.VTK.vtkLSDynaReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000754 RID: 1876
		public new static readonly string MRClassNameKey = "class vtkLSDynaReader";
	}
}
