using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenFOAMReader
	/// </summary>
	/// <remarks>
	///    reads a dataset in OpenFOAM format
	///
	/// vtkOpenFOAMReader creates a multiblock dataset. It reads mesh
	/// information and time dependent data.  The polyMesh folders contain
	/// mesh information. The time folders contain transient data for the
	/// cells. Each folder can contain any number of data files.
	///
	/// @par Thanks:
	/// </remarks>
	/// <seealso>
	/// Thanks to Terry Jordan (terry.jordan.netl.doe.gov) of SAIC
	/// at the National Energy Technology Laboratory who originally
	/// developed this class.
	///
	/// Takuya Oshima of Niigata University, Japan (oshima@eng.niigata-u.ac.jp)
	/// provided the major bulk of improvements (rewrite) that made the reader
	/// truly functional and included the following features:
	/// Token-based FoamFile format lexer/parser,
	/// performance/stability/compatibility enhancements, gzipped file
	/// support, lagrangian field support, variable timestep support,
	/// builtin cell-to-point filter, pointField support, polyhedron
	/// decomposition support, multiregion support, parallelization support for
	/// decomposed cases in conjunction with vtkPOpenFOAMReader etc.
	///
	/// Philippose Rajan (sarith@rocketmail.com) added
	/// GUI-based selection of mesh regions and fields available in the case,
	/// minor bug fixes, strict memory allocation checks,
	///
	/// Mark Olesen (OpenCFD Ltd.) www.openfoam.com
	/// has provided various bugfixes, improvements, cleanup
	/// </seealso>
	// Token: 0x02000162 RID: 354
	public class vtkOpenFOAMReader : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004330 RID: 17200 RVA: 0x000627EF File Offset: 0x000609EF
		static vtkOpenFOAMReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenFOAMReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenFOAMReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004331 RID: 17201 RVA: 0x00062817 File Offset: 0x00060A17
		public vtkOpenFOAMReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004332 RID: 17202
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenFOAMReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004333 RID: 17203 RVA: 0x00062828 File Offset: 0x00060A28
		public new static vtkOpenFOAMReader New()
		{
			vtkOpenFOAMReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenFOAMReader.vtkOpenFOAMReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenFOAMReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004334 RID: 17204 RVA: 0x0006287C File Offset: 0x00060A7C
		public vtkOpenFOAMReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenFOAMReader.vtkOpenFOAMReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004335 RID: 17205 RVA: 0x000628C0 File Offset: 0x00060AC0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004336 RID: 17206
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_AddDimensionsToArrayNamesOff_01(HandleRef pThis);

		/// <summary>
		/// Add dimensions to array names
		/// </summary>
		// Token: 0x06004337 RID: 17207 RVA: 0x000628CB File Offset: 0x00060ACB
		public virtual void AddDimensionsToArrayNamesOff()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_AddDimensionsToArrayNamesOff_01(base.GetCppThis());
		}

		// Token: 0x06004338 RID: 17208
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_AddDimensionsToArrayNamesOn_02(HandleRef pThis);

		/// <summary>
		/// Add dimensions to array names
		/// </summary>
		// Token: 0x06004339 RID: 17209 RVA: 0x000628DA File Offset: 0x00060ADA
		public virtual void AddDimensionsToArrayNamesOn()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_AddDimensionsToArrayNamesOn_02(base.GetCppThis());
		}

		// Token: 0x0600433A RID: 17210
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_CacheMeshOff_03(HandleRef pThis);

		/// <summary>
		/// Set/Get whether mesh is to be cached.
		/// </summary>
		// Token: 0x0600433B RID: 17211 RVA: 0x000628E9 File Offset: 0x00060AE9
		public virtual void CacheMeshOff()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_CacheMeshOff_03(base.GetCppThis());
		}

		// Token: 0x0600433C RID: 17212
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_CacheMeshOn_04(HandleRef pThis);

		/// <summary>
		/// Set/Get whether mesh is to be cached.
		/// </summary>
		// Token: 0x0600433D RID: 17213 RVA: 0x000628F8 File Offset: 0x00060AF8
		public virtual void CacheMeshOn()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_CacheMeshOn_04(base.GetCppThis());
		}

		// Token: 0x0600433E RID: 17214
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenFOAMReader_CanReadFile_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Determine if the file can be read with this reader.
		/// </summary>
		// Token: 0x0600433F RID: 17215 RVA: 0x00062908 File Offset: 0x00060B08
		public int CanReadFile(string arg0)
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_CanReadFile_05(base.GetCppThis(), arg0);
		}

		// Token: 0x06004340 RID: 17216
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_CopyDataToCellZonesOff_06(HandleRef pThis);

		/// <summary>
		/// If true, data of the internal mesh are copied to the cell zones.
		/// Default is false.
		/// </summary>
		// Token: 0x06004341 RID: 17217 RVA: 0x00062928 File Offset: 0x00060B28
		public virtual void CopyDataToCellZonesOff()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_CopyDataToCellZonesOff_06(base.GetCppThis());
		}

		// Token: 0x06004342 RID: 17218
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_CopyDataToCellZonesOn_07(HandleRef pThis);

		/// <summary>
		/// If true, data of the internal mesh are copied to the cell zones.
		/// Default is false.
		/// </summary>
		// Token: 0x06004343 RID: 17219 RVA: 0x00062937 File Offset: 0x00060B37
		public virtual void CopyDataToCellZonesOn()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_CopyDataToCellZonesOn_07(base.GetCppThis());
		}

		// Token: 0x06004344 RID: 17220
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_CreateCellToPointOff_08(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to create cell-to-point translated data for cell-type data
		/// </summary>
		// Token: 0x06004345 RID: 17221 RVA: 0x00062946 File Offset: 0x00060B46
		public virtual void CreateCellToPointOff()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_CreateCellToPointOff_08(base.GetCppThis());
		}

		// Token: 0x06004346 RID: 17222
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_CreateCellToPointOn_09(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to create cell-to-point translated data for cell-type data
		/// </summary>
		// Token: 0x06004347 RID: 17223 RVA: 0x00062955 File Offset: 0x00060B55
		public virtual void CreateCellToPointOn()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_CreateCellToPointOn_09(base.GetCppThis());
		}

		// Token: 0x06004348 RID: 17224
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_DecomposePolyhedraOff_10(HandleRef pThis);

		/// <summary>
		/// Set/Get whether polyhedra are to be decomposed.
		/// </summary>
		// Token: 0x06004349 RID: 17225 RVA: 0x00062964 File Offset: 0x00060B64
		public virtual void DecomposePolyhedraOff()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_DecomposePolyhedraOff_10(base.GetCppThis());
		}

		// Token: 0x0600434A RID: 17226
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_DecomposePolyhedraOn_11(HandleRef pThis);

		/// <summary>
		/// Set/Get whether polyhedra are to be decomposed.
		/// </summary>
		// Token: 0x0600434B RID: 17227 RVA: 0x00062973 File Offset: 0x00060B73
		public virtual void DecomposePolyhedraOn()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_DecomposePolyhedraOn_11(base.GetCppThis());
		}

		// Token: 0x0600434C RID: 17228
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_DisableAllCellArrays_12(HandleRef pThis);

		/// <summary>
		/// Turn on/off all cell arrays.
		/// </summary>
		// Token: 0x0600434D RID: 17229 RVA: 0x00062982 File Offset: 0x00060B82
		public void DisableAllCellArrays()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_DisableAllCellArrays_12(base.GetCppThis());
		}

		// Token: 0x0600434E RID: 17230
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_DisableAllLagrangianArrays_13(HandleRef pThis);

		/// <summary>
		/// Turn on/off all Lagrangian arrays.
		/// </summary>
		// Token: 0x0600434F RID: 17231 RVA: 0x00062991 File Offset: 0x00060B91
		public void DisableAllLagrangianArrays()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_DisableAllLagrangianArrays_13(base.GetCppThis());
		}

		// Token: 0x06004350 RID: 17232
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_DisableAllPatchArrays_14(HandleRef pThis);

		/// <summary>
		/// Turn on/off all Patches including the Internal Mesh.
		/// </summary>
		// Token: 0x06004351 RID: 17233 RVA: 0x000629A0 File Offset: 0x00060BA0
		public void DisableAllPatchArrays()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_DisableAllPatchArrays_14(base.GetCppThis());
		}

		// Token: 0x06004352 RID: 17234
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_DisableAllPointArrays_15(HandleRef pThis);

		/// <summary>
		/// Turn on/off all point arrays.
		/// </summary>
		// Token: 0x06004353 RID: 17235 RVA: 0x000629AF File Offset: 0x00060BAF
		public void DisableAllPointArrays()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_DisableAllPointArrays_15(base.GetCppThis());
		}

		// Token: 0x06004354 RID: 17236
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_EnableAllCellArrays_16(HandleRef pThis);

		/// <summary>
		/// Turn on/off all cell arrays.
		/// </summary>
		// Token: 0x06004355 RID: 17237 RVA: 0x000629BE File Offset: 0x00060BBE
		public void EnableAllCellArrays()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_EnableAllCellArrays_16(base.GetCppThis());
		}

		// Token: 0x06004356 RID: 17238
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_EnableAllLagrangianArrays_17(HandleRef pThis);

		/// <summary>
		/// Turn on/off all Lagrangian arrays.
		/// </summary>
		// Token: 0x06004357 RID: 17239 RVA: 0x000629CD File Offset: 0x00060BCD
		public void EnableAllLagrangianArrays()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_EnableAllLagrangianArrays_17(base.GetCppThis());
		}

		// Token: 0x06004358 RID: 17240
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_EnableAllPatchArrays_18(HandleRef pThis);

		/// <summary>
		/// Turn on/off all Patches including the Internal Mesh.
		/// </summary>
		// Token: 0x06004359 RID: 17241 RVA: 0x000629DC File Offset: 0x00060BDC
		public void EnableAllPatchArrays()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_EnableAllPatchArrays_18(base.GetCppThis());
		}

		// Token: 0x0600435A RID: 17242
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_EnableAllPointArrays_19(HandleRef pThis);

		/// <summary>
		/// Turn on/off all point arrays.
		/// </summary>
		// Token: 0x0600435B RID: 17243 RVA: 0x000629EB File Offset: 0x00060BEB
		public void EnableAllPointArrays()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_EnableAllPointArrays_19(base.GetCppThis());
		}

		// Token: 0x0600435C RID: 17244
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenFOAMReader_GetAddDimensionsToArrayNames_20(HandleRef pThis);

		/// <summary>
		/// Add dimensions to array names
		/// </summary>
		// Token: 0x0600435D RID: 17245 RVA: 0x000629FC File Offset: 0x00060BFC
		public virtual int GetAddDimensionsToArrayNames()
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetAddDimensionsToArrayNames_20(base.GetCppThis());
		}

		// Token: 0x0600435E RID: 17246
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenFOAMReader_GetCacheMesh_21(HandleRef pThis);

		/// <summary>
		/// Set/Get whether mesh is to be cached.
		/// </summary>
		// Token: 0x0600435F RID: 17247 RVA: 0x00062A1C File Offset: 0x00060C1C
		public virtual int GetCacheMesh()
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetCacheMesh_21(base.GetCppThis());
		}

		// Token: 0x06004360 RID: 17248
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenFOAMReader_GetCellArrayName_22(HandleRef pThis, int index);

		/// <summary>
		/// Get the name of the cell array with the given index in
		/// the input.
		/// </summary>
		// Token: 0x06004361 RID: 17249 RVA: 0x00062A3C File Offset: 0x00060C3C
		public string GetCellArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkOpenFOAMReader.vtkOpenFOAMReader_GetCellArrayName_22(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004362 RID: 17250
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenFOAMReader_GetCellArrayStatus_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get/Set whether the cell array with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x06004363 RID: 17251 RVA: 0x00062A78 File Offset: 0x00060C78
		public int GetCellArrayStatus(string name)
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetCellArrayStatus_23(base.GetCppThis(), name);
		}

		// Token: 0x06004364 RID: 17252
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenFOAMReader_GetCopyDataToCellZones_24(HandleRef pThis);

		/// <summary>
		/// If true, data of the internal mesh are copied to the cell zones.
		/// Default is false.
		/// </summary>
		// Token: 0x06004365 RID: 17253 RVA: 0x00062A98 File Offset: 0x00060C98
		public virtual bool GetCopyDataToCellZones()
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetCopyDataToCellZones_24(base.GetCppThis()) != 0;
		}

		// Token: 0x06004366 RID: 17254
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenFOAMReader_GetCreateCellToPoint_25(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to create cell-to-point translated data for cell-type data
		/// </summary>
		// Token: 0x06004367 RID: 17255 RVA: 0x00062AC0 File Offset: 0x00060CC0
		public virtual int GetCreateCellToPoint()
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetCreateCellToPoint_25(base.GetCppThis());
		}

		// Token: 0x06004368 RID: 17256
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenFOAMReader_GetDecomposePolyhedra_26(HandleRef pThis);

		/// <summary>
		/// Set/Get whether polyhedra are to be decomposed.
		/// </summary>
		// Token: 0x06004369 RID: 17257 RVA: 0x00062AE0 File Offset: 0x00060CE0
		public virtual int GetDecomposePolyhedra()
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetDecomposePolyhedra_26(base.GetCppThis());
		}

		// Token: 0x0600436A RID: 17258
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenFOAMReader_GetFileName_27(HandleRef pThis);

		/// <summary>
		/// Set/Get the filename.
		/// </summary>
		// Token: 0x0600436B RID: 17259 RVA: 0x00062B00 File Offset: 0x00060D00
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkOpenFOAMReader.vtkOpenFOAMReader_GetFileName_27(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600436C RID: 17260
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenFOAMReader_GetLagrangianArrayName_28(HandleRef pThis, int index);

		/// <summary>
		/// Get the name of the Lagrangian array with the given index in
		/// the input.
		/// </summary>
		// Token: 0x0600436D RID: 17261 RVA: 0x00062B3C File Offset: 0x00060D3C
		public string GetLagrangianArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkOpenFOAMReader.vtkOpenFOAMReader_GetLagrangianArrayName_28(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600436E RID: 17262
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenFOAMReader_GetLagrangianArrayStatus_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get/Set whether the Lagrangian array with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x0600436F RID: 17263 RVA: 0x00062B78 File Offset: 0x00060D78
		public int GetLagrangianArrayStatus(string name)
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetLagrangianArrayStatus_29(base.GetCppThis(), name);
		}

		// Token: 0x06004370 RID: 17264
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenFOAMReader_GetListTimeStepsByControlDict_30(HandleRef pThis);

		/// <summary>
		/// Determine if time directories are to be listed according to controlDict
		/// </summary>
		// Token: 0x06004371 RID: 17265 RVA: 0x00062B98 File Offset: 0x00060D98
		public virtual int GetListTimeStepsByControlDict()
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetListTimeStepsByControlDict_30(base.GetCppThis());
		}

		// Token: 0x06004372 RID: 17266
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenFOAMReader_GetNumberOfCellArrays_31(HandleRef pThis);

		/// <summary>
		/// Get the number of cell arrays available in the input.
		/// </summary>
		// Token: 0x06004373 RID: 17267 RVA: 0x00062BB8 File Offset: 0x00060DB8
		public int GetNumberOfCellArrays()
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetNumberOfCellArrays_31(base.GetCppThis());
		}

		// Token: 0x06004374 RID: 17268
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenFOAMReader_GetNumberOfGenerationsFromBase_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004375 RID: 17269 RVA: 0x00062BD8 File Offset: 0x00060DD8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetNumberOfGenerationsFromBase_32(base.GetCppThis(), type);
		}

		// Token: 0x06004376 RID: 17270
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenFOAMReader_GetNumberOfGenerationsFromBaseType_33([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004377 RID: 17271 RVA: 0x00062BF8 File Offset: 0x00060DF8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetNumberOfGenerationsFromBaseType_33(type);
		}

		// Token: 0x06004378 RID: 17272
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenFOAMReader_GetNumberOfLagrangianArrays_34(HandleRef pThis);

		/// <summary>
		/// Get the number of Lagrangian arrays available in the input.
		/// </summary>
		// Token: 0x06004379 RID: 17273 RVA: 0x00062C14 File Offset: 0x00060E14
		public int GetNumberOfLagrangianArrays()
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetNumberOfLagrangianArrays_34(base.GetCppThis());
		}

		// Token: 0x0600437A RID: 17274
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenFOAMReader_GetNumberOfPatchArrays_35(HandleRef pThis);

		/// <summary>
		/// Get the number of Patches (including Internal Mesh) available in the input.
		/// </summary>
		// Token: 0x0600437B RID: 17275 RVA: 0x00062C34 File Offset: 0x00060E34
		public int GetNumberOfPatchArrays()
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetNumberOfPatchArrays_35(base.GetCppThis());
		}

		// Token: 0x0600437C RID: 17276
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenFOAMReader_GetNumberOfPointArrays_36(HandleRef pThis);

		/// <summary>
		/// Get the number of point arrays available in the input.
		/// </summary>
		// Token: 0x0600437D RID: 17277 RVA: 0x00062C54 File Offset: 0x00060E54
		public int GetNumberOfPointArrays()
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetNumberOfPointArrays_36(base.GetCppThis());
		}

		// Token: 0x0600437E RID: 17278
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenFOAMReader_GetPatchArrayName_37(HandleRef pThis, int index);

		/// <summary>
		/// Get the name of the Patch with the given index in
		/// the input.
		/// </summary>
		// Token: 0x0600437F RID: 17279 RVA: 0x00062C74 File Offset: 0x00060E74
		public string GetPatchArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkOpenFOAMReader.vtkOpenFOAMReader_GetPatchArrayName_37(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004380 RID: 17280
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenFOAMReader_GetPatchArrayStatus_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get/Set whether the Patch with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x06004381 RID: 17281 RVA: 0x00062CB0 File Offset: 0x00060EB0
		public int GetPatchArrayStatus(string name)
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetPatchArrayStatus_38(base.GetCppThis(), name);
		}

		// Token: 0x06004382 RID: 17282
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenFOAMReader_GetPointArrayName_39(HandleRef pThis, int index);

		/// <summary>
		/// Get the name of the point array with the given index in
		/// the input.
		/// </summary>
		// Token: 0x06004383 RID: 17283 RVA: 0x00062CD0 File Offset: 0x00060ED0
		public string GetPointArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkOpenFOAMReader.vtkOpenFOAMReader_GetPointArrayName_39(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004384 RID: 17284
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenFOAMReader_GetPointArrayStatus_40(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get/Set whether the point array with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x06004385 RID: 17285 RVA: 0x00062D0C File Offset: 0x00060F0C
		public int GetPointArrayStatus(string name)
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetPointArrayStatus_40(base.GetCppThis(), name);
		}

		// Token: 0x06004386 RID: 17286
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenFOAMReader_GetPositionsIsIn13Format_41(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the lagrangian/positions have additional data or not.
		/// For historical reasons, PositionsIsIn13Format is used to denote that
		/// the positions only have x,y,z value and the cell of the enclosing cell.
		/// In OpenFOAM 1.4-2.4, positions included facei and stepFraction information.
		/// </summary>
		// Token: 0x06004387 RID: 17287 RVA: 0x00062D2C File Offset: 0x00060F2C
		public virtual int GetPositionsIsIn13Format()
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetPositionsIsIn13Format_41(base.GetCppThis());
		}

		// Token: 0x06004388 RID: 17288
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenFOAMReader_GetReadZones_42(HandleRef pThis);

		/// <summary>
		/// Set/Get whether zones will be read.
		/// </summary>
		// Token: 0x06004389 RID: 17289 RVA: 0x00062D4C File Offset: 0x00060F4C
		public virtual int GetReadZones()
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetReadZones_42(base.GetCppThis());
		}

		// Token: 0x0600438A RID: 17290
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenFOAMReader_GetSizeAverageCellToPoint_43(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to weigh cell to point averaging by size of cells (only meaningful when
		/// CreateCellToPoint is true)
		///
		/// @sa
		/// CreateCellToPoint
		/// </summary>
		// Token: 0x0600438B RID: 17291 RVA: 0x00062D6C File Offset: 0x00060F6C
		public virtual int GetSizeAverageCellToPoint()
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetSizeAverageCellToPoint_43(base.GetCppThis());
		}

		// Token: 0x0600438C RID: 17292
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenFOAMReader_GetSkipZeroTime_44(HandleRef pThis);

		/// <summary>
		/// Ignore 0/ time directory, which is normally missing Lagrangian fields
		/// and may have many dictionary functionality that we cannot easily handle.
		/// </summary>
		// Token: 0x0600438D RID: 17293 RVA: 0x00062D8C File Offset: 0x00060F8C
		public virtual bool GetSkipZeroTime()
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetSkipZeroTime_44(base.GetCppThis()) != 0;
		}

		// Token: 0x0600438E RID: 17294
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenFOAMReader_GetTimeNames_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// If true, floats are expected to be 64-bit, rather than 32. Note that
		/// vtkFloatArrays may still be used in the output if this is true. This flag
		/// is only used to ensure that binary data is correctly parsed.
		/// </summary>
		// Token: 0x0600438F RID: 17295 RVA: 0x00062DB4 File Offset: 0x00060FB4
		public vtkStringArray GetTimeNames()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenFOAMReader.vtkOpenFOAMReader_GetTimeNames_45(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		// Token: 0x06004390 RID: 17296
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOpenFOAMReader_GetTimeValue_46(HandleRef pThis);

		/// <summary>
		/// If true, floats are expected to be 64-bit, rather than 32. Note that
		/// vtkFloatArrays may still be used in the output if this is true. This flag
		/// is only used to ensure that binary data is correctly parsed.
		/// </summary>
		// Token: 0x06004391 RID: 17297 RVA: 0x00062E24 File Offset: 0x00061024
		public double GetTimeValue()
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetTimeValue_46(base.GetCppThis());
		}

		// Token: 0x06004392 RID: 17298
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenFOAMReader_GetTimeValues_47(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// If true, floats are expected to be 64-bit, rather than 32. Note that
		/// vtkFloatArrays may still be used in the output if this is true. This flag
		/// is only used to ensure that binary data is correctly parsed.
		/// </summary>
		// Token: 0x06004393 RID: 17299 RVA: 0x00062E44 File Offset: 0x00061044
		public vtkDoubleArray GetTimeValues()
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenFOAMReader.vtkOpenFOAMReader_GetTimeValues_47(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDoubleArray = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDoubleArray.Register(null);
				}
			}
			return vtkDoubleArray;
		}

		// Token: 0x06004394 RID: 17300
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenFOAMReader_GetUse64BitFloats_48(HandleRef pThis);

		/// <summary>
		/// If true, floats are expected to be 64-bit, rather than 32. Note that
		/// vtkFloatArrays may still be used in the output if this is true. This flag
		/// is only used to ensure that binary data is correctly parsed.
		/// </summary>
		// Token: 0x06004395 RID: 17301 RVA: 0x00062EB4 File Offset: 0x000610B4
		public virtual bool GetUse64BitFloats()
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetUse64BitFloats_48(base.GetCppThis()) != 0;
		}

		// Token: 0x06004396 RID: 17302
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenFOAMReader_GetUse64BitLabels_49(HandleRef pThis);

		/// <summary>
		/// If true, labels are expected to be 64-bit, rather than 32.
		/// </summary>
		// Token: 0x06004397 RID: 17303 RVA: 0x00062EDC File Offset: 0x000610DC
		public virtual bool GetUse64BitLabels()
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_GetUse64BitLabels_49(base.GetCppThis()) != 0;
		}

		// Token: 0x06004398 RID: 17304
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenFOAMReader_IsA_50(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004399 RID: 17305 RVA: 0x00062F04 File Offset: 0x00061104
		public override int IsA(string type)
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_IsA_50(base.GetCppThis(), type);
		}

		// Token: 0x0600439A RID: 17306
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenFOAMReader_IsTypeOf_51([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600439B RID: 17307 RVA: 0x00062F24 File Offset: 0x00061124
		public new static int IsTypeOf(string type)
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_IsTypeOf_51(type);
		}

		// Token: 0x0600439C RID: 17308
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_ListTimeStepsByControlDictOff_52(HandleRef pThis);

		/// <summary>
		/// Determine if time directories are to be listed according to controlDict
		/// </summary>
		// Token: 0x0600439D RID: 17309 RVA: 0x00062F3E File Offset: 0x0006113E
		public virtual void ListTimeStepsByControlDictOff()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_ListTimeStepsByControlDictOff_52(base.GetCppThis());
		}

		// Token: 0x0600439E RID: 17310
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_ListTimeStepsByControlDictOn_53(HandleRef pThis);

		/// <summary>
		/// Determine if time directories are to be listed according to controlDict
		/// </summary>
		// Token: 0x0600439F RID: 17311 RVA: 0x00062F4D File Offset: 0x0006114D
		public virtual void ListTimeStepsByControlDictOn()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_ListTimeStepsByControlDictOn_53(base.GetCppThis());
		}

		// Token: 0x060043A0 RID: 17312
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenFOAMReader_MakeInformationVector_54(HandleRef pThis, HandleRef arg0, [MarshalAs(UnmanagedType.LPUTF8Str)] string procDirName, HandleRef timeNames, HandleRef timeValues);

		/// <summary>
		/// If true, floats are expected to be 64-bit, rather than 32. Note that
		/// vtkFloatArrays may still be used in the output if this is true. This flag
		/// is only used to ensure that binary data is correctly parsed.
		/// </summary>
		// Token: 0x060043A1 RID: 17313 RVA: 0x00062F5C File Offset: 0x0006115C
		public int MakeInformationVector(vtkInformationVector arg0, string procDirName, vtkStringArray timeNames, vtkDoubleArray timeValues)
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_MakeInformationVector_54(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), procDirName, (timeNames == null) ? default(HandleRef) : timeNames.GetCppThis(), (timeValues == null) ? default(HandleRef) : timeValues.GetCppThis());
		}

		// Token: 0x060043A2 RID: 17314
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenFOAMReader_MakeMetaDataAtTimeStep_55(HandleRef pThis, byte arg0);

		/// <summary>
		/// If true, floats are expected to be 64-bit, rather than 32. Note that
		/// vtkFloatArrays may still be used in the output if this is true. This flag
		/// is only used to ensure that binary data is correctly parsed.
		/// </summary>
		// Token: 0x060043A3 RID: 17315 RVA: 0x00062FC0 File Offset: 0x000611C0
		public int MakeMetaDataAtTimeStep(bool arg0)
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_MakeMetaDataAtTimeStep_55(base.GetCppThis(), arg0 ? (byte)1 : (byte)0);
		}

		// Token: 0x060043A4 RID: 17316
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenFOAMReader_NewInstance_57(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060043A5 RID: 17317 RVA: 0x00062FE8 File Offset: 0x000611E8
		public new vtkOpenFOAMReader NewInstance()
		{
			vtkOpenFOAMReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenFOAMReader.vtkOpenFOAMReader_NewInstance_57(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenFOAMReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060043A6 RID: 17318
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_PositionsIsIn13FormatOff_58(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the lagrangian/positions have additional data or not.
		/// For historical reasons, PositionsIsIn13Format is used to denote that
		/// the positions only have x,y,z value and the cell of the enclosing cell.
		/// In OpenFOAM 1.4-2.4, positions included facei and stepFraction information.
		/// </summary>
		// Token: 0x060043A7 RID: 17319 RVA: 0x00063042 File Offset: 0x00061242
		public virtual void PositionsIsIn13FormatOff()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_PositionsIsIn13FormatOff_58(base.GetCppThis());
		}

		// Token: 0x060043A8 RID: 17320
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_PositionsIsIn13FormatOn_59(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the lagrangian/positions have additional data or not.
		/// For historical reasons, PositionsIsIn13Format is used to denote that
		/// the positions only have x,y,z value and the cell of the enclosing cell.
		/// In OpenFOAM 1.4-2.4, positions included facei and stepFraction information.
		/// </summary>
		// Token: 0x060043A9 RID: 17321 RVA: 0x00063051 File Offset: 0x00061251
		public virtual void PositionsIsIn13FormatOn()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_PositionsIsIn13FormatOn_59(base.GetCppThis());
		}

		// Token: 0x060043AA RID: 17322
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_ReadZonesOff_60(HandleRef pThis);

		/// <summary>
		/// Set/Get whether zones will be read.
		/// </summary>
		// Token: 0x060043AB RID: 17323 RVA: 0x00063060 File Offset: 0x00061260
		public virtual void ReadZonesOff()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_ReadZonesOff_60(base.GetCppThis());
		}

		// Token: 0x060043AC RID: 17324
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_ReadZonesOn_61(HandleRef pThis);

		/// <summary>
		/// Set/Get whether zones will be read.
		/// </summary>
		// Token: 0x060043AD RID: 17325 RVA: 0x0006306F File Offset: 0x0006126F
		public virtual void ReadZonesOn()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_ReadZonesOn_61(base.GetCppThis());
		}

		// Token: 0x060043AE RID: 17326
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenFOAMReader_SafeDownCast_62(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060043AF RID: 17327 RVA: 0x00063080 File Offset: 0x00061280
		public new static vtkOpenFOAMReader SafeDownCast(vtkObjectBase o)
		{
			vtkOpenFOAMReader vtkOpenFOAMReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenFOAMReader.vtkOpenFOAMReader_SafeDownCast_62((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenFOAMReader = (vtkOpenFOAMReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenFOAMReader.Register(null);
				}
			}
			return vtkOpenFOAMReader;
		}

		// Token: 0x060043B0 RID: 17328
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_SetAddDimensionsToArrayNames_63(HandleRef pThis, int _arg);

		/// <summary>
		/// Add dimensions to array names
		/// </summary>
		// Token: 0x060043B1 RID: 17329 RVA: 0x000630FF File Offset: 0x000612FF
		public virtual void SetAddDimensionsToArrayNames(int _arg)
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetAddDimensionsToArrayNames_63(base.GetCppThis(), _arg);
		}

		// Token: 0x060043B2 RID: 17330
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_SetCacheMesh_64(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get whether mesh is to be cached.
		/// </summary>
		// Token: 0x060043B3 RID: 17331 RVA: 0x0006310F File Offset: 0x0006130F
		public virtual void SetCacheMesh(int _arg)
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetCacheMesh_64(base.GetCppThis(), _arg);
		}

		// Token: 0x060043B4 RID: 17332
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_SetCellArrayStatus_65(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// Get/Set whether the cell array with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x060043B5 RID: 17333 RVA: 0x0006311F File Offset: 0x0006131F
		public void SetCellArrayStatus(string name, int status)
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetCellArrayStatus_65(base.GetCppThis(), name, status);
		}

		// Token: 0x060043B6 RID: 17334
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_SetCopyDataToCellZones_66(HandleRef pThis, byte _arg);

		/// <summary>
		/// If true, data of the internal mesh are copied to the cell zones.
		/// Default is false.
		/// </summary>
		// Token: 0x060043B7 RID: 17335 RVA: 0x00063130 File Offset: 0x00061330
		public virtual void SetCopyDataToCellZones(bool _arg)
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetCopyDataToCellZones_66(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060043B8 RID: 17336
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_SetCreateCellToPoint_67(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get whether to create cell-to-point translated data for cell-type data
		/// </summary>
		// Token: 0x060043B9 RID: 17337 RVA: 0x00063148 File Offset: 0x00061348
		public virtual void SetCreateCellToPoint(int _arg)
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetCreateCellToPoint_67(base.GetCppThis(), _arg);
		}

		// Token: 0x060043BA RID: 17338
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_SetDecomposePolyhedra_68(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get whether polyhedra are to be decomposed.
		/// </summary>
		// Token: 0x060043BB RID: 17339 RVA: 0x00063158 File Offset: 0x00061358
		public virtual void SetDecomposePolyhedra(int _arg)
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetDecomposePolyhedra_68(base.GetCppThis(), _arg);
		}

		// Token: 0x060043BC RID: 17340
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_SetFileName_69(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the filename.
		/// </summary>
		// Token: 0x060043BD RID: 17341 RVA: 0x00063168 File Offset: 0x00061368
		public virtual void SetFileName(string _arg)
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetFileName_69(base.GetCppThis(), _arg);
		}

		// Token: 0x060043BE RID: 17342
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_SetLagrangianArrayStatus_70(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// Get/Set whether the Lagrangian array with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x060043BF RID: 17343 RVA: 0x00063178 File Offset: 0x00061378
		public void SetLagrangianArrayStatus(string name, int status)
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetLagrangianArrayStatus_70(base.GetCppThis(), name, status);
		}

		// Token: 0x060043C0 RID: 17344
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_SetListTimeStepsByControlDict_71(HandleRef pThis, int _arg);

		/// <summary>
		/// Determine if time directories are to be listed according to controlDict
		/// </summary>
		// Token: 0x060043C1 RID: 17345 RVA: 0x00063189 File Offset: 0x00061389
		public virtual void SetListTimeStepsByControlDict(int _arg)
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetListTimeStepsByControlDict_71(base.GetCppThis(), _arg);
		}

		// Token: 0x060043C2 RID: 17346
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_SetParent_72(HandleRef pThis, HandleRef parent);

		/// <summary>
		/// If true, floats are expected to be 64-bit, rather than 32. Note that
		/// vtkFloatArrays may still be used in the output if this is true. This flag
		/// is only used to ensure that binary data is correctly parsed.
		/// </summary>
		// Token: 0x060043C3 RID: 17347 RVA: 0x0006319C File Offset: 0x0006139C
		public void SetParent(vtkOpenFOAMReader parent)
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetParent_72(base.GetCppThis(), (parent == null) ? default(HandleRef) : parent.GetCppThis());
		}

		// Token: 0x060043C4 RID: 17348
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_SetPatchArrayStatus_73(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// Get/Set whether the Patch with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x060043C5 RID: 17349 RVA: 0x000631CB File Offset: 0x000613CB
		public void SetPatchArrayStatus(string name, int status)
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetPatchArrayStatus_73(base.GetCppThis(), name, status);
		}

		// Token: 0x060043C6 RID: 17350
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_SetPointArrayStatus_74(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// Get/Set whether the point array with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x060043C7 RID: 17351 RVA: 0x000631DC File Offset: 0x000613DC
		public void SetPointArrayStatus(string name, int status)
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetPointArrayStatus_74(base.GetCppThis(), name, status);
		}

		// Token: 0x060043C8 RID: 17352
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_SetPositionsIsIn13Format_75(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get whether the lagrangian/positions have additional data or not.
		/// For historical reasons, PositionsIsIn13Format is used to denote that
		/// the positions only have x,y,z value and the cell of the enclosing cell.
		/// In OpenFOAM 1.4-2.4, positions included facei and stepFraction information.
		/// </summary>
		// Token: 0x060043C9 RID: 17353 RVA: 0x000631ED File Offset: 0x000613ED
		public virtual void SetPositionsIsIn13Format(int _arg)
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetPositionsIsIn13Format_75(base.GetCppThis(), _arg);
		}

		// Token: 0x060043CA RID: 17354
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_SetReadZones_76(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get whether zones will be read.
		/// </summary>
		// Token: 0x060043CB RID: 17355 RVA: 0x000631FD File Offset: 0x000613FD
		public virtual void SetReadZones(int _arg)
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetReadZones_76(base.GetCppThis(), _arg);
		}

		// Token: 0x060043CC RID: 17356
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_SetRefresh_77(HandleRef pThis);

		/// <summary>
		/// If true, floats are expected to be 64-bit, rather than 32. Note that
		/// vtkFloatArrays may still be used in the output if this is true. This flag
		/// is only used to ensure that binary data is correctly parsed.
		/// </summary>
		// Token: 0x060043CD RID: 17357 RVA: 0x0006320D File Offset: 0x0006140D
		public void SetRefresh()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetRefresh_77(base.GetCppThis());
		}

		// Token: 0x060043CE RID: 17358
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_SetSizeAverageCellToPoint_78(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get whether to weigh cell to point averaging by size of cells (only meaningful when
		/// CreateCellToPoint is true)
		///
		/// @sa
		/// CreateCellToPoint
		/// </summary>
		// Token: 0x060043CF RID: 17359 RVA: 0x0006321C File Offset: 0x0006141C
		public virtual void SetSizeAverageCellToPoint(int _arg)
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetSizeAverageCellToPoint_78(base.GetCppThis(), _arg);
		}

		// Token: 0x060043D0 RID: 17360
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_SetSkipZeroTime_79(HandleRef pThis, byte _arg);

		/// <summary>
		/// Ignore 0/ time directory, which is normally missing Lagrangian fields
		/// and may have many dictionary functionality that we cannot easily handle.
		/// </summary>
		// Token: 0x060043D1 RID: 17361 RVA: 0x0006322C File Offset: 0x0006142C
		public virtual void SetSkipZeroTime(bool _arg)
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetSkipZeroTime_79(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060043D2 RID: 17362
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenFOAMReader_SetTimeValue_80(HandleRef pThis, double arg0);

		/// <summary>
		/// If true, floats are expected to be 64-bit, rather than 32. Note that
		/// vtkFloatArrays may still be used in the output if this is true. This flag
		/// is only used to ensure that binary data is correctly parsed.
		/// </summary>
		// Token: 0x060043D3 RID: 17363 RVA: 0x00063244 File Offset: 0x00061444
		public bool SetTimeValue(double arg0)
		{
			return vtkOpenFOAMReader.vtkOpenFOAMReader_SetTimeValue_80(base.GetCppThis(), arg0) != 0;
		}

		// Token: 0x060043D4 RID: 17364
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_SetUse64BitFloats_81(HandleRef pThis, byte val);

		/// <summary>
		/// If true, floats are expected to be 64-bit, rather than 32. Note that
		/// vtkFloatArrays may still be used in the output if this is true. This flag
		/// is only used to ensure that binary data is correctly parsed.
		/// </summary>
		// Token: 0x060043D5 RID: 17365 RVA: 0x0006326B File Offset: 0x0006146B
		public virtual void SetUse64BitFloats(bool val)
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetUse64BitFloats_81(base.GetCppThis(), val ? (byte)1 : (byte)0);
		}

		// Token: 0x060043D6 RID: 17366
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_SetUse64BitLabels_82(HandleRef pThis, byte val);

		/// <summary>
		/// If true, labels are expected to be 64-bit, rather than 32.
		/// </summary>
		// Token: 0x060043D7 RID: 17367 RVA: 0x00063283 File Offset: 0x00061483
		public virtual void SetUse64BitLabels(bool val)
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SetUse64BitLabels_82(base.GetCppThis(), val ? (byte)1 : (byte)0);
		}

		// Token: 0x060043D8 RID: 17368
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_SizeAverageCellToPointOff_83(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to weigh cell to point averaging by size of cells (only meaningful when
		/// CreateCellToPoint is true)
		///
		/// @sa
		/// CreateCellToPoint
		/// </summary>
		// Token: 0x060043D9 RID: 17369 RVA: 0x0006329B File Offset: 0x0006149B
		public virtual void SizeAverageCellToPointOff()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SizeAverageCellToPointOff_83(base.GetCppThis());
		}

		// Token: 0x060043DA RID: 17370
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_SizeAverageCellToPointOn_84(HandleRef pThis);

		/// <summary>
		/// Set/Get whether to weigh cell to point averaging by size of cells (only meaningful when
		/// CreateCellToPoint is true)
		///
		/// @sa
		/// CreateCellToPoint
		/// </summary>
		// Token: 0x060043DB RID: 17371 RVA: 0x000632AA File Offset: 0x000614AA
		public virtual void SizeAverageCellToPointOn()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SizeAverageCellToPointOn_84(base.GetCppThis());
		}

		// Token: 0x060043DC RID: 17372
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_SkipZeroTimeOff_85(HandleRef pThis);

		/// <summary>
		/// Ignore 0/ time directory, which is normally missing Lagrangian fields
		/// and may have many dictionary functionality that we cannot easily handle.
		/// </summary>
		// Token: 0x060043DD RID: 17373 RVA: 0x000632B9 File Offset: 0x000614B9
		public virtual void SkipZeroTimeOff()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SkipZeroTimeOff_85(base.GetCppThis());
		}

		// Token: 0x060043DE RID: 17374
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_SkipZeroTimeOn_86(HandleRef pThis);

		/// <summary>
		/// Ignore 0/ time directory, which is normally missing Lagrangian fields
		/// and may have many dictionary functionality that we cannot easily handle.
		/// </summary>
		// Token: 0x060043DF RID: 17375 RVA: 0x000632C8 File Offset: 0x000614C8
		public virtual void SkipZeroTimeOn()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_SkipZeroTimeOn_86(base.GetCppThis());
		}

		// Token: 0x060043E0 RID: 17376
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_Use64BitFloatsOff_87(HandleRef pThis);

		/// <summary>
		/// If true, floats are expected to be 64-bit, rather than 32. Note that
		/// vtkFloatArrays may still be used in the output if this is true. This flag
		/// is only used to ensure that binary data is correctly parsed.
		/// </summary>
		// Token: 0x060043E1 RID: 17377 RVA: 0x000632D7 File Offset: 0x000614D7
		public virtual void Use64BitFloatsOff()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_Use64BitFloatsOff_87(base.GetCppThis());
		}

		// Token: 0x060043E2 RID: 17378
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_Use64BitFloatsOn_88(HandleRef pThis);

		/// <summary>
		/// If true, floats are expected to be 64-bit, rather than 32. Note that
		/// vtkFloatArrays may still be used in the output if this is true. This flag
		/// is only used to ensure that binary data is correctly parsed.
		/// </summary>
		// Token: 0x060043E3 RID: 17379 RVA: 0x000632E6 File Offset: 0x000614E6
		public virtual void Use64BitFloatsOn()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_Use64BitFloatsOn_88(base.GetCppThis());
		}

		// Token: 0x060043E4 RID: 17380
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_Use64BitLabelsOff_89(HandleRef pThis);

		/// <summary>
		/// If true, labels are expected to be 64-bit, rather than 32.
		/// </summary>
		// Token: 0x060043E5 RID: 17381 RVA: 0x000632F5 File Offset: 0x000614F5
		public virtual void Use64BitLabelsOff()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_Use64BitLabelsOff_89(base.GetCppThis());
		}

		// Token: 0x060043E6 RID: 17382
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenFOAMReader_Use64BitLabelsOn_90(HandleRef pThis);

		/// <summary>
		/// If true, labels are expected to be 64-bit, rather than 32.
		/// </summary>
		// Token: 0x060043E7 RID: 17383 RVA: 0x00063304 File Offset: 0x00061504
		public virtual void Use64BitLabelsOn()
		{
			vtkOpenFOAMReader.vtkOpenFOAMReader_Use64BitLabelsOn_90(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400070A RID: 1802
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenFOAMReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400070B RID: 1803
		public new static readonly string MRClassNameKey = "class vtkOpenFOAMReader";
	}
}
