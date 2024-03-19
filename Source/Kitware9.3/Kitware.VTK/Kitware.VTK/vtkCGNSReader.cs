using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCGNSReader
	///
	/// vtkCGNSReader creates a multi-block dataset and reads unstructured grids
	/// and structured meshes from binary files stored in CGNS file format,
	/// with data stored at the nodes, cells or faces.
	///
	/// vtkCGNSReader is inspired by the VisIt CGNS reader originally written by
	/// B. Whitlock. vtkCGNSReader relies on the low level CGNS API to load data sets
	/// and reduce memory footprint.
	/// </summary>
	// Token: 0x020001E3 RID: 483
	public class vtkCGNSReader : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005BDC RID: 23516 RVA: 0x0008548F File Offset: 0x0008368F
		static vtkCGNSReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCGNSReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCGNSReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005BDD RID: 23517 RVA: 0x000854B7 File Offset: 0x000836B7
		public vtkCGNSReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005BDE RID: 23518
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCGNSReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005BDF RID: 23519 RVA: 0x000854C8 File Offset: 0x000836C8
		public new static vtkCGNSReader New()
		{
			vtkCGNSReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCGNSReader.vtkCGNSReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCGNSReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005BE0 RID: 23520 RVA: 0x0008551C File Offset: 0x0008371C
		public vtkCGNSReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCGNSReader.vtkCGNSReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005BE1 RID: 23521 RVA: 0x00085560 File Offset: 0x00083760
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005BE2 RID: 23522
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_Broadcast_01(HandleRef pThis, HandleRef ctrl);

		/// <summary>
		/// Sends metadata (that read from the input file, not settings modified
		/// through this API) from the rank 0 node to all other processes in a job.
		/// </summary>
		// Token: 0x06005BE3 RID: 23523 RVA: 0x0008556C File Offset: 0x0008376C
		public void Broadcast(vtkMultiProcessController ctrl)
		{
			vtkCGNSReader.vtkCGNSReader_Broadcast_01(base.GetCppThis(), (ctrl == null) ? default(HandleRef) : ctrl.GetCppThis());
		}

		// Token: 0x06005BE4 RID: 23524
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_CacheConnectivityOff_02(HandleRef pThis);

		/// <summary>
		/// This reader can cache the mesh connectivities if they are time invariant.
		/// They will be stored with a unique reference to their /base/zoneName
		/// and not be read in the file when doing unsteady analysis.
		/// Default is false.
		/// </summary>
		// Token: 0x06005BE5 RID: 23525 RVA: 0x0008559B File Offset: 0x0008379B
		public virtual void CacheConnectivityOff()
		{
			vtkCGNSReader.vtkCGNSReader_CacheConnectivityOff_02(base.GetCppThis());
		}

		// Token: 0x06005BE6 RID: 23526
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_CacheConnectivityOn_03(HandleRef pThis);

		/// <summary>
		/// This reader can cache the mesh connectivities if they are time invariant.
		/// They will be stored with a unique reference to their /base/zoneName
		/// and not be read in the file when doing unsteady analysis.
		/// Default is false.
		/// </summary>
		// Token: 0x06005BE7 RID: 23527 RVA: 0x000855AA File Offset: 0x000837AA
		public virtual void CacheConnectivityOn()
		{
			vtkCGNSReader.vtkCGNSReader_CacheConnectivityOn_03(base.GetCppThis());
		}

		// Token: 0x06005BE8 RID: 23528
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_CacheMeshOff_04(HandleRef pThis);

		/// <summary>
		/// This reader can cache the mesh points if they are time invariant.
		/// They will be stored with a unique reference to their /base/zoneName
		/// and not be read in the file when doing unsteady analysis.
		/// Default is false.
		/// </summary>
		// Token: 0x06005BE9 RID: 23529 RVA: 0x000855B9 File Offset: 0x000837B9
		public virtual void CacheMeshOff()
		{
			vtkCGNSReader.vtkCGNSReader_CacheMeshOff_04(base.GetCppThis());
		}

		// Token: 0x06005BEA RID: 23530
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_CacheMeshOn_05(HandleRef pThis);

		/// <summary>
		/// This reader can cache the mesh points if they are time invariant.
		/// They will be stored with a unique reference to their /base/zoneName
		/// and not be read in the file when doing unsteady analysis.
		/// Default is false.
		/// </summary>
		// Token: 0x06005BEB RID: 23531 RVA: 0x000855C8 File Offset: 0x000837C8
		public virtual void CacheMeshOn()
		{
			vtkCGNSReader.vtkCGNSReader_CacheMeshOn_05(base.GetCppThis());
		}

		// Token: 0x06005BEC RID: 23532
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCGNSReader_CanReadFile_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string filename);

		/// <summary>
		/// Is the given file name a CGNS file?
		/// </summary>
		// Token: 0x06005BED RID: 23533 RVA: 0x000855D8 File Offset: 0x000837D8
		public int CanReadFile(string filename)
		{
			return vtkCGNSReader.vtkCGNSReader_CanReadFile_06(base.GetCppThis(), filename);
		}

		// Token: 0x06005BEE RID: 23534
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_CreateEachSolutionAsBlockOff_07(HandleRef pThis);

		/// <summary>
		/// This option is provided for debugging and should not be used for production
		/// runs as the output data produced may not be correct. When set to true, the
		/// reader will simply read each solution (`FlowSolution_t`) node encountered in
		/// a zone and create a separate block under the block corresponding to the
		/// zone in the output.
		/// Default is 0 (false).
		/// </summary>
		// Token: 0x06005BEF RID: 23535 RVA: 0x000855F8 File Offset: 0x000837F8
		public virtual void CreateEachSolutionAsBlockOff()
		{
			vtkCGNSReader.vtkCGNSReader_CreateEachSolutionAsBlockOff_07(base.GetCppThis());
		}

		// Token: 0x06005BF0 RID: 23536
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_CreateEachSolutionAsBlockOn_08(HandleRef pThis);

		/// <summary>
		/// This option is provided for debugging and should not be used for production
		/// runs as the output data produced may not be correct. When set to true, the
		/// reader will simply read each solution (`FlowSolution_t`) node encountered in
		/// a zone and create a separate block under the block corresponding to the
		/// zone in the output.
		/// Default is 0 (false).
		/// </summary>
		// Token: 0x06005BF1 RID: 23537 RVA: 0x00085607 File Offset: 0x00083807
		public virtual void CreateEachSolutionAsBlockOn()
		{
			vtkCGNSReader.vtkCGNSReader_CreateEachSolutionAsBlockOn_08(base.GetCppThis());
		}

		// Token: 0x06005BF2 RID: 23538
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_DisableAllBases_09(HandleRef pThis);

		/// <summary>
		/// API to select bases to read. These calls simply forward to the
		/// vtkDataArraySelection instance obtained from `GetBaseSelection()`.
		///
		/// By default, 0-th base is enabled and all others are disabled.
		/// </summary>
		// Token: 0x06005BF3 RID: 23539 RVA: 0x00085616 File Offset: 0x00083816
		public void DisableAllBases()
		{
			vtkCGNSReader.vtkCGNSReader_DisableAllBases_09(base.GetCppThis());
		}

		// Token: 0x06005BF4 RID: 23540
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_DisableAllCellArrays_10(HandleRef pThis);

		/// <summary>
		/// API to get information of cell arrays and enable/disable loading of
		/// particular arrays.
		/// </summary>
		// Token: 0x06005BF5 RID: 23541 RVA: 0x00085625 File Offset: 0x00083825
		public void DisableAllCellArrays()
		{
			vtkCGNSReader.vtkCGNSReader_DisableAllCellArrays_10(base.GetCppThis());
		}

		// Token: 0x06005BF6 RID: 23542
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_DisableAllFaceArrays_11(HandleRef pThis);

		/// <summary>
		/// API to get information of face arrays and enable/disable loading of
		/// particular arrays.
		/// </summary>
		// Token: 0x06005BF7 RID: 23543 RVA: 0x00085634 File Offset: 0x00083834
		public void DisableAllFaceArrays()
		{
			vtkCGNSReader.vtkCGNSReader_DisableAllFaceArrays_11(base.GetCppThis());
		}

		// Token: 0x06005BF8 RID: 23544
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_DisableAllFamilies_12(HandleRef pThis);

		/// <summary>
		/// API to select families to read. These calls simply forward to the
		/// vtkDataArraySelection instance obtained from `GetFamilySelection()`.
		/// </summary>
		// Token: 0x06005BF9 RID: 23545 RVA: 0x00085643 File Offset: 0x00083843
		public void DisableAllFamilies()
		{
			vtkCGNSReader.vtkCGNSReader_DisableAllFamilies_12(base.GetCppThis());
		}

		// Token: 0x06005BFA RID: 23546
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_DisableAllPointArrays_13(HandleRef pThis);

		/// <summary>
		/// API to get information of point arrays and enable/disable loading of
		/// particular arrays.
		/// </summary>
		// Token: 0x06005BFB RID: 23547 RVA: 0x00085652 File Offset: 0x00083852
		public void DisableAllPointArrays()
		{
			vtkCGNSReader.vtkCGNSReader_DisableAllPointArrays_13(base.GetCppThis());
		}

		// Token: 0x06005BFC RID: 23548
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_DistributeBlocksOff_14(HandleRef pThis);

		/// <summary>
		/// This reader can support piece requests by distributing each block in each
		/// zone across ranks (default). To make the reader disregard piece request and
		/// read all blocks in the zone, set this to false (default is true).
		/// </summary>
		// Token: 0x06005BFD RID: 23549 RVA: 0x00085661 File Offset: 0x00083861
		public virtual void DistributeBlocksOff()
		{
			vtkCGNSReader.vtkCGNSReader_DistributeBlocksOff_14(base.GetCppThis());
		}

		// Token: 0x06005BFE RID: 23550
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_DistributeBlocksOn_15(HandleRef pThis);

		/// <summary>
		/// This reader can support piece requests by distributing each block in each
		/// zone across ranks (default). To make the reader disregard piece request and
		/// read all blocks in the zone, set this to false (default is true).
		/// </summary>
		// Token: 0x06005BFF RID: 23551 RVA: 0x00085670 File Offset: 0x00083870
		public virtual void DistributeBlocksOn()
		{
			vtkCGNSReader.vtkCGNSReader_DistributeBlocksOn_15(base.GetCppThis());
		}

		// Token: 0x06005C00 RID: 23552
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_DoublePrecisionMeshOff_16(HandleRef pThis);

		/// <summary>
		/// Enable/disable double precision when reading the mesh.
		/// Defaults to 1 (true).
		/// </summary>
		// Token: 0x06005C01 RID: 23553 RVA: 0x0008567F File Offset: 0x0008387F
		public virtual void DoublePrecisionMeshOff()
		{
			vtkCGNSReader.vtkCGNSReader_DoublePrecisionMeshOff_16(base.GetCppThis());
		}

		// Token: 0x06005C02 RID: 23554
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_DoublePrecisionMeshOn_17(HandleRef pThis);

		/// <summary>
		/// Enable/disable double precision when reading the mesh.
		/// Defaults to 1 (true).
		/// </summary>
		// Token: 0x06005C03 RID: 23555 RVA: 0x0008568E File Offset: 0x0008388E
		public virtual void DoublePrecisionMeshOn()
		{
			vtkCGNSReader.vtkCGNSReader_DoublePrecisionMeshOn_17(base.GetCppThis());
		}

		// Token: 0x06005C04 RID: 23556
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_EnableAllBases_18(HandleRef pThis);

		/// <summary>
		/// API to select bases to read. These calls simply forward to the
		/// vtkDataArraySelection instance obtained from `GetBaseSelection()`.
		///
		/// By default, 0-th base is enabled and all others are disabled.
		/// </summary>
		// Token: 0x06005C05 RID: 23557 RVA: 0x0008569D File Offset: 0x0008389D
		public void EnableAllBases()
		{
			vtkCGNSReader.vtkCGNSReader_EnableAllBases_18(base.GetCppThis());
		}

		// Token: 0x06005C06 RID: 23558
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_EnableAllCellArrays_19(HandleRef pThis);

		/// <summary>
		/// API to get information of cell arrays and enable/disable loading of
		/// particular arrays.
		/// </summary>
		// Token: 0x06005C07 RID: 23559 RVA: 0x000856AC File Offset: 0x000838AC
		public void EnableAllCellArrays()
		{
			vtkCGNSReader.vtkCGNSReader_EnableAllCellArrays_19(base.GetCppThis());
		}

		// Token: 0x06005C08 RID: 23560
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_EnableAllFaceArrays_20(HandleRef pThis);

		/// <summary>
		/// API to get information of face arrays and enable/disable loading of
		/// particular arrays.
		/// </summary>
		// Token: 0x06005C09 RID: 23561 RVA: 0x000856BB File Offset: 0x000838BB
		public void EnableAllFaceArrays()
		{
			vtkCGNSReader.vtkCGNSReader_EnableAllFaceArrays_20(base.GetCppThis());
		}

		// Token: 0x06005C0A RID: 23562
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_EnableAllFamilies_21(HandleRef pThis);

		/// <summary>
		/// API to select families to read. These calls simply forward to the
		/// vtkDataArraySelection instance obtained from `GetFamilySelection()`.
		/// </summary>
		// Token: 0x06005C0B RID: 23563 RVA: 0x000856CA File Offset: 0x000838CA
		public void EnableAllFamilies()
		{
			vtkCGNSReader.vtkCGNSReader_EnableAllFamilies_21(base.GetCppThis());
		}

		// Token: 0x06005C0C RID: 23564
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_EnableAllPointArrays_22(HandleRef pThis);

		/// <summary>
		/// API to get information of point arrays and enable/disable loading of
		/// particular arrays.
		/// </summary>
		// Token: 0x06005C0D RID: 23565 RVA: 0x000856D9 File Offset: 0x000838D9
		public void EnableAllPointArrays()
		{
			vtkCGNSReader.vtkCGNSReader_EnableAllPointArrays_22(base.GetCppThis());
		}

		// Token: 0x06005C0E RID: 23566
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCGNSReader_FAMILY_23(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Key used to put a family name in the meta-data associated with a node
		/// </summary>
		// Token: 0x06005C0F RID: 23567 RVA: 0x000856E8 File Offset: 0x000838E8
		public static vtkInformationStringKey FAMILY()
		{
			vtkInformationStringKey vtkInformationStringKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCGNSReader.vtkCGNSReader_FAMILY_23(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationStringKey = (vtkInformationStringKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationStringKey.Register(null);
				}
			}
			return vtkInformationStringKey;
		}

		// Token: 0x06005C10 RID: 23568
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCGNSReader_GetBaseArrayName_24(HandleRef pThis, int index);

		/// <summary>
		/// API to select bases to read. These calls simply forward to the
		/// vtkDataArraySelection instance obtained from `GetBaseSelection()`.
		///
		/// By default, 0-th base is enabled and all others are disabled.
		/// </summary>
		// Token: 0x06005C11 RID: 23569 RVA: 0x00085754 File Offset: 0x00083954
		public string GetBaseArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkCGNSReader.vtkCGNSReader_GetBaseArrayName_24(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005C12 RID: 23570
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCGNSReader_GetBaseArrayStatus_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// API to select bases to read. These calls simply forward to the
		/// vtkDataArraySelection instance obtained from `GetBaseSelection()`.
		///
		/// By default, 0-th base is enabled and all others are disabled.
		/// </summary>
		// Token: 0x06005C13 RID: 23571 RVA: 0x00085790 File Offset: 0x00083990
		public int GetBaseArrayStatus(string name)
		{
			return vtkCGNSReader.vtkCGNSReader_GetBaseArrayStatus_25(base.GetCppThis(), name);
		}

		// Token: 0x06005C14 RID: 23572
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCGNSReader_GetBaseSelection_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns access to the base selection object.
		/// </summary>
		// Token: 0x06005C15 RID: 23573 RVA: 0x000857B0 File Offset: 0x000839B0
		public vtkDataArraySelection GetBaseSelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCGNSReader.vtkCGNSReader_GetBaseSelection_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x06005C16 RID: 23574
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCGNSReader_GetCacheConnectivity_27(HandleRef pThis);

		/// <summary>
		/// This reader can cache the mesh connectivities if they are time invariant.
		/// They will be stored with a unique reference to their /base/zoneName
		/// and not be read in the file when doing unsteady analysis.
		/// Default is false.
		/// </summary>
		// Token: 0x06005C17 RID: 23575 RVA: 0x00085820 File Offset: 0x00083A20
		public virtual bool GetCacheConnectivity()
		{
			return vtkCGNSReader.vtkCGNSReader_GetCacheConnectivity_27(base.GetCppThis()) != 0;
		}

		// Token: 0x06005C18 RID: 23576
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCGNSReader_GetCacheMesh_28(HandleRef pThis);

		/// <summary>
		/// This reader can cache the mesh points if they are time invariant.
		/// They will be stored with a unique reference to their /base/zoneName
		/// and not be read in the file when doing unsteady analysis.
		/// Default is false.
		/// </summary>
		// Token: 0x06005C19 RID: 23577 RVA: 0x00085848 File Offset: 0x00083A48
		public virtual bool GetCacheMesh()
		{
			return vtkCGNSReader.vtkCGNSReader_GetCacheMesh_28(base.GetCppThis()) != 0;
		}

		// Token: 0x06005C1A RID: 23578
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCGNSReader_GetCellArrayName_29(HandleRef pThis, int index);

		/// <summary>
		/// API to get information of cell arrays and enable/disable loading of
		/// particular arrays.
		/// </summary>
		// Token: 0x06005C1B RID: 23579 RVA: 0x00085870 File Offset: 0x00083A70
		public string GetCellArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkCGNSReader.vtkCGNSReader_GetCellArrayName_29(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005C1C RID: 23580
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCGNSReader_GetCellArrayStatus_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// API to get information of cell arrays and enable/disable loading of
		/// particular arrays.
		/// </summary>
		// Token: 0x06005C1D RID: 23581 RVA: 0x000858AC File Offset: 0x00083AAC
		public int GetCellArrayStatus(string name)
		{
			return vtkCGNSReader.vtkCGNSReader_GetCellArrayStatus_30(base.GetCppThis(), name);
		}

		// Token: 0x06005C1E RID: 23582
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCGNSReader_GetCellDataArraySelection_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return selection of cell arrays.
		/// </summary>
		// Token: 0x06005C1F RID: 23583 RVA: 0x000858CC File Offset: 0x00083ACC
		public virtual vtkDataArraySelection GetCellDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCGNSReader.vtkCGNSReader_GetCellDataArraySelection_31(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x06005C20 RID: 23584
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCGNSReader_GetController_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the communication object used to relay a list of files
		/// from the rank 0 process to all others. This is the only interprocess
		/// communication required by vtkCGNSReader.
		/// </summary>
		// Token: 0x06005C21 RID: 23585 RVA: 0x0008593C File Offset: 0x00083B3C
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCGNSReader.vtkCGNSReader_GetController_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		// Token: 0x06005C22 RID: 23586
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCGNSReader_GetCreateEachSolutionAsBlock_33(HandleRef pThis);

		/// <summary>
		/// This option is provided for debugging and should not be used for production
		/// runs as the output data produced may not be correct. When set to true, the
		/// reader will simply read each solution (`FlowSolution_t`) node encountered in
		/// a zone and create a separate block under the block corresponding to the
		/// zone in the output.
		/// Default is 0 (false).
		/// </summary>
		// Token: 0x06005C23 RID: 23587 RVA: 0x000859AC File Offset: 0x00083BAC
		public virtual int GetCreateEachSolutionAsBlock()
		{
			return vtkCGNSReader.vtkCGNSReader_GetCreateEachSolutionAsBlock_33(base.GetCppThis());
		}

		// Token: 0x06005C24 RID: 23588
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCGNSReader_GetDataLocation_34(HandleRef pThis);

		/// <summary>
		/// Set/get the location of the data arrays to read. Possible values for the data location are:
		/// - CELL_DATA - Read CellCenter data arrays from the CGNS file. Construct 3D meshes with 3D cells
		/// (e.g. a cube is defined as 1 cell).
		/// - FACE_DATA - Read FaceCenter data arrays from the CGNS file. Construct 3D meshes with 2D
		/// cells/faces (e.g. a cube is defined as 6 quad cells). Element connectivity must be defined with
		/// element type NGON_n.
		///
		/// Default is CELL_DATA.
		/// </summary>
		// Token: 0x06005C25 RID: 23589 RVA: 0x000859CC File Offset: 0x00083BCC
		public virtual int GetDataLocation()
		{
			return vtkCGNSReader.vtkCGNSReader_GetDataLocation_34(base.GetCppThis());
		}

		// Token: 0x06005C26 RID: 23590
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCGNSReader_GetDataLocationMaxValue_35(HandleRef pThis);

		/// <summary>
		/// Set/get the location of the data arrays to read. Possible values for the data location are:
		/// - CELL_DATA - Read CellCenter data arrays from the CGNS file. Construct 3D meshes with 3D cells
		/// (e.g. a cube is defined as 1 cell).
		/// - FACE_DATA - Read FaceCenter data arrays from the CGNS file. Construct 3D meshes with 2D
		/// cells/faces (e.g. a cube is defined as 6 quad cells). Element connectivity must be defined with
		/// element type NGON_n.
		///
		/// Default is CELL_DATA.
		/// </summary>
		// Token: 0x06005C27 RID: 23591 RVA: 0x000859EC File Offset: 0x00083BEC
		public virtual int GetDataLocationMaxValue()
		{
			return vtkCGNSReader.vtkCGNSReader_GetDataLocationMaxValue_35(base.GetCppThis());
		}

		// Token: 0x06005C28 RID: 23592
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCGNSReader_GetDataLocationMinValue_36(HandleRef pThis);

		/// <summary>
		/// Set/get the location of the data arrays to read. Possible values for the data location are:
		/// - CELL_DATA - Read CellCenter data arrays from the CGNS file. Construct 3D meshes with 3D cells
		/// (e.g. a cube is defined as 1 cell).
		/// - FACE_DATA - Read FaceCenter data arrays from the CGNS file. Construct 3D meshes with 2D
		/// cells/faces (e.g. a cube is defined as 6 quad cells). Element connectivity must be defined with
		/// element type NGON_n.
		///
		/// Default is CELL_DATA.
		/// </summary>
		// Token: 0x06005C29 RID: 23593 RVA: 0x00085A0C File Offset: 0x00083C0C
		public virtual int GetDataLocationMinValue()
		{
			return vtkCGNSReader.vtkCGNSReader_GetDataLocationMinValue_36(base.GetCppThis());
		}

		// Token: 0x06005C2A RID: 23594
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCGNSReader_GetDistributeBlocks_37(HandleRef pThis);

		/// <summary>
		/// This reader can support piece requests by distributing each block in each
		/// zone across ranks (default). To make the reader disregard piece request and
		/// read all blocks in the zone, set this to false (default is true).
		/// </summary>
		// Token: 0x06005C2B RID: 23595 RVA: 0x00085A2C File Offset: 0x00083C2C
		public virtual bool GetDistributeBlocks()
		{
			return vtkCGNSReader.vtkCGNSReader_GetDistributeBlocks_37(base.GetCppThis()) != 0;
		}

		// Token: 0x06005C2C RID: 23596
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCGNSReader_GetDoublePrecisionMesh_38(HandleRef pThis);

		/// <summary>
		/// Enable/disable double precision when reading the mesh.
		/// Defaults to 1 (true).
		/// </summary>
		// Token: 0x06005C2D RID: 23597 RVA: 0x00085A54 File Offset: 0x00083C54
		public virtual int GetDoublePrecisionMesh()
		{
			return vtkCGNSReader.vtkCGNSReader_GetDoublePrecisionMesh_38(base.GetCppThis());
		}

		// Token: 0x06005C2E RID: 23598
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCGNSReader_GetFaceArrayName_39(HandleRef pThis, int index);

		/// <summary>
		/// API to get information of face arrays and enable/disable loading of
		/// particular arrays.
		/// </summary>
		// Token: 0x06005C2F RID: 23599 RVA: 0x00085A74 File Offset: 0x00083C74
		public string GetFaceArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkCGNSReader.vtkCGNSReader_GetFaceArrayName_39(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005C30 RID: 23600
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCGNSReader_GetFaceArrayStatus_40(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// API to get information of face arrays and enable/disable loading of
		/// particular arrays.
		/// </summary>
		// Token: 0x06005C31 RID: 23601 RVA: 0x00085AB0 File Offset: 0x00083CB0
		public int GetFaceArrayStatus(string name)
		{
			return vtkCGNSReader.vtkCGNSReader_GetFaceArrayStatus_40(base.GetCppThis(), name);
		}

		// Token: 0x06005C32 RID: 23602
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCGNSReader_GetFaceDataArraySelection_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return selection of face arrays.
		/// </summary>
		// Token: 0x06005C33 RID: 23603 RVA: 0x00085AD0 File Offset: 0x00083CD0
		public virtual vtkDataArraySelection GetFaceDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCGNSReader.vtkCGNSReader_GetFaceDataArraySelection_41(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x06005C34 RID: 23604
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCGNSReader_GetFamilyArrayName_42(HandleRef pThis, int index);

		/// <summary>
		/// API to select families to read. These calls simply forward to the
		/// vtkDataArraySelection instance obtained from `GetFamilySelection()`.
		/// </summary>
		// Token: 0x06005C35 RID: 23605 RVA: 0x00085B40 File Offset: 0x00083D40
		public string GetFamilyArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkCGNSReader.vtkCGNSReader_GetFamilyArrayName_42(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005C36 RID: 23606
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCGNSReader_GetFamilyArrayStatus_43(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// API to select families to read. These calls simply forward to the
		/// vtkDataArraySelection instance obtained from `GetFamilySelection()`.
		/// </summary>
		// Token: 0x06005C37 RID: 23607 RVA: 0x00085B7C File Offset: 0x00083D7C
		public int GetFamilyArrayStatus(string name)
		{
			return vtkCGNSReader.vtkCGNSReader_GetFamilyArrayStatus_43(base.GetCppThis(), name);
		}

		// Token: 0x06005C38 RID: 23608
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCGNSReader_GetFamilySelection_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns access to the family selection object.
		/// </summary>
		// Token: 0x06005C39 RID: 23609 RVA: 0x00085B9C File Offset: 0x00083D9C
		public vtkDataArraySelection GetFamilySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCGNSReader.vtkCGNSReader_GetFamilySelection_44(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x06005C3A RID: 23610
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCGNSReader_GetFileName_45(HandleRef pThis);

		/// <summary>
		/// Specify file name of CGNS datafile to read
		/// </summary>
		// Token: 0x06005C3B RID: 23611 RVA: 0x00085C0C File Offset: 0x00083E0C
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkCGNSReader.vtkCGNSReader_GetFileName_45(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005C3C RID: 23612
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCGNSReader_GetIgnoreFlowSolutionPointers_46(HandleRef pThis);

		/// <summary>
		/// When set to true (default is false), the reader will simply
		/// ignore `FlowSolutionPointers` since they are either incomplete or invalid
		/// and instead will rely on FlowSolution_t nodes being labelled as
		/// "...AtStep&lt;tsindex&gt;" to locate solution nodes for a specific timestep.
		/// Note, tsindex starts with 1 (not zero).
		///
		/// When set to false, the reader will still try to confirm that at least one
		/// valid FlowSolution_t node is referred to in FlowSolutionPointers nodes for the
		/// current timestep. If none is found, then the reader will print out a
		/// warning and act as if IgnoreFlowSolutionPointers was set to true. To avoid
		/// this warning, one should set IgnoreFlowSolutionPointers to true.
		/// </summary>
		// Token: 0x06005C3D RID: 23613 RVA: 0x00085C48 File Offset: 0x00083E48
		public virtual bool GetIgnoreFlowSolutionPointers()
		{
			return vtkCGNSReader.vtkCGNSReader_GetIgnoreFlowSolutionPointers_46(base.GetCppThis()) != 0;
		}

		// Token: 0x06005C3E RID: 23614
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCGNSReader_GetLoadBndPatch_47(HandleRef pThis);

		/// <summary>
		/// Enable/disable loading of boundary condition patches.
		/// Defaults to false.
		/// </summary>
		// Token: 0x06005C3F RID: 23615 RVA: 0x00085C70 File Offset: 0x00083E70
		public virtual bool GetLoadBndPatch()
		{
			return vtkCGNSReader.vtkCGNSReader_GetLoadBndPatch_47(base.GetCppThis()) != 0;
		}

		// Token: 0x06005C40 RID: 23616
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCGNSReader_GetLoadMesh_48(HandleRef pThis);

		/// <summary>
		/// Enable/disable loading of zone mesh. Defaults to true. It may be turned off
		/// to load only boundary patches (when LoadBndPatch if ON), for example.
		/// </summary>
		// Token: 0x06005C41 RID: 23617 RVA: 0x00085C98 File Offset: 0x00083E98
		public virtual bool GetLoadMesh()
		{
			return vtkCGNSReader.vtkCGNSReader_GetLoadMesh_48(base.GetCppThis()) != 0;
		}

		// Token: 0x06005C42 RID: 23618
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCGNSReader_GetNumberOfBaseArrays_49(HandleRef pThis);

		/// <summary>
		/// API to select bases to read. These calls simply forward to the
		/// vtkDataArraySelection instance obtained from `GetBaseSelection()`.
		///
		/// By default, 0-th base is enabled and all others are disabled.
		/// </summary>
		// Token: 0x06005C43 RID: 23619 RVA: 0x00085CC0 File Offset: 0x00083EC0
		public int GetNumberOfBaseArrays()
		{
			return vtkCGNSReader.vtkCGNSReader_GetNumberOfBaseArrays_49(base.GetCppThis());
		}

		// Token: 0x06005C44 RID: 23620
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCGNSReader_GetNumberOfCellArrays_50(HandleRef pThis);

		/// <summary>
		/// API to get information of cell arrays and enable/disable loading of
		/// particular arrays.
		/// </summary>
		// Token: 0x06005C45 RID: 23621 RVA: 0x00085CE0 File Offset: 0x00083EE0
		public int GetNumberOfCellArrays()
		{
			return vtkCGNSReader.vtkCGNSReader_GetNumberOfCellArrays_50(base.GetCppThis());
		}

		// Token: 0x06005C46 RID: 23622
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCGNSReader_GetNumberOfFaceArrays_51(HandleRef pThis);

		/// <summary>
		/// API to get information of face arrays and enable/disable loading of
		/// particular arrays.
		/// </summary>
		// Token: 0x06005C47 RID: 23623 RVA: 0x00085D00 File Offset: 0x00083F00
		public int GetNumberOfFaceArrays()
		{
			return vtkCGNSReader.vtkCGNSReader_GetNumberOfFaceArrays_51(base.GetCppThis());
		}

		// Token: 0x06005C48 RID: 23624
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCGNSReader_GetNumberOfFamilyArrays_52(HandleRef pThis);

		/// <summary>
		/// API to select families to read. These calls simply forward to the
		/// vtkDataArraySelection instance obtained from `GetFamilySelection()`.
		/// </summary>
		// Token: 0x06005C49 RID: 23625 RVA: 0x00085D20 File Offset: 0x00083F20
		public int GetNumberOfFamilyArrays()
		{
			return vtkCGNSReader.vtkCGNSReader_GetNumberOfFamilyArrays_52(base.GetCppThis());
		}

		// Token: 0x06005C4A RID: 23626
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCGNSReader_GetNumberOfGenerationsFromBase_53(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005C4B RID: 23627 RVA: 0x00085D40 File Offset: 0x00083F40
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCGNSReader.vtkCGNSReader_GetNumberOfGenerationsFromBase_53(base.GetCppThis(), type);
		}

		// Token: 0x06005C4C RID: 23628
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCGNSReader_GetNumberOfGenerationsFromBaseType_54([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005C4D RID: 23629 RVA: 0x00085D60 File Offset: 0x00083F60
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCGNSReader.vtkCGNSReader_GetNumberOfGenerationsFromBaseType_54(type);
		}

		// Token: 0x06005C4E RID: 23630
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCGNSReader_GetNumberOfPointArrays_55(HandleRef pThis);

		/// <summary>
		/// API to get information of point arrays and enable/disable loading of
		/// particular arrays.
		/// </summary>
		// Token: 0x06005C4F RID: 23631 RVA: 0x00085D7C File Offset: 0x00083F7C
		public int GetNumberOfPointArrays()
		{
			return vtkCGNSReader.vtkCGNSReader_GetNumberOfPointArrays_55(base.GetCppThis());
		}

		// Token: 0x06005C50 RID: 23632
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCGNSReader_GetPointArrayName_56(HandleRef pThis, int index);

		/// <summary>
		/// API to get information of point arrays and enable/disable loading of
		/// particular arrays.
		/// </summary>
		// Token: 0x06005C51 RID: 23633 RVA: 0x00085D9C File Offset: 0x00083F9C
		public string GetPointArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkCGNSReader.vtkCGNSReader_GetPointArrayName_56(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005C52 RID: 23634
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCGNSReader_GetPointArrayStatus_57(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// API to get information of point arrays and enable/disable loading of
		/// particular arrays.
		/// </summary>
		// Token: 0x06005C53 RID: 23635 RVA: 0x00085DD8 File Offset: 0x00083FD8
		public int GetPointArrayStatus(string name)
		{
			return vtkCGNSReader.vtkCGNSReader_GetPointArrayStatus_57(base.GetCppThis(), name);
		}

		// Token: 0x06005C54 RID: 23636
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCGNSReader_GetPointDataArraySelection_58(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return selection of point arrays.
		/// </summary>
		// Token: 0x06005C55 RID: 23637 RVA: 0x00085DF8 File Offset: 0x00083FF8
		public virtual vtkDataArraySelection GetPointDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCGNSReader.vtkCGNSReader_GetPointDataArraySelection_58(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x06005C56 RID: 23638
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCGNSReader_GetUnsteadySolutionStartTimestep_59(HandleRef pThis);

		/// <summary>
		/// Set/get the index of the first timestep when reading unsteady solutions.
		/// Only used when "UseUnsteadyPattern" is true.
		/// Default is 0.
		/// </summary>
		// Token: 0x06005C57 RID: 23639 RVA: 0x00085E68 File Offset: 0x00084068
		public virtual int GetUnsteadySolutionStartTimestep()
		{
			return vtkCGNSReader.vtkCGNSReader_GetUnsteadySolutionStartTimestep_59(base.GetCppThis());
		}

		// Token: 0x06005C58 RID: 23640
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCGNSReader_GetUse3DVector_60(HandleRef pThis);

		/// <summary>
		/// Enable/disable adding an empty physical dimension to vectors in case of 2D solutions.
		/// Default is true.
		/// </summary>
		// Token: 0x06005C59 RID: 23641 RVA: 0x00085E88 File Offset: 0x00084088
		public virtual bool GetUse3DVector()
		{
			return vtkCGNSReader.vtkCGNSReader_GetUse3DVector_60(base.GetCppThis()) != 0;
		}

		// Token: 0x06005C5A RID: 23642
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCGNSReader_GetUseUnsteadyPattern_61(HandleRef pThis);

		/// <summary>
		/// When set to true (default is false), the reader will try
		/// to determine to determine FlowSolution_t nodes to read with pattern matching.
		/// This can be useful for unsteady solutions when `FlowSolutionPointers` are not
		/// reliable.
		/// </summary>
		// Token: 0x06005C5B RID: 23643 RVA: 0x00085EB0 File Offset: 0x000840B0
		public virtual bool GetUseUnsteadyPattern()
		{
			return vtkCGNSReader.vtkCGNSReader_GetUseUnsteadyPattern_61(base.GetCppThis()) != 0;
		}

		// Token: 0x06005C5C RID: 23644
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_IgnoreFlowSolutionPointersOff_62(HandleRef pThis);

		/// <summary>
		/// When set to true (default is false), the reader will simply
		/// ignore `FlowSolutionPointers` since they are either incomplete or invalid
		/// and instead will rely on FlowSolution_t nodes being labelled as
		/// "...AtStep&lt;tsindex&gt;" to locate solution nodes for a specific timestep.
		/// Note, tsindex starts with 1 (not zero).
		///
		/// When set to false, the reader will still try to confirm that at least one
		/// valid FlowSolution_t node is referred to in FlowSolutionPointers nodes for the
		/// current timestep. If none is found, then the reader will print out a
		/// warning and act as if IgnoreFlowSolutionPointers was set to true. To avoid
		/// this warning, one should set IgnoreFlowSolutionPointers to true.
		/// </summary>
		// Token: 0x06005C5D RID: 23645 RVA: 0x00085ED6 File Offset: 0x000840D6
		public virtual void IgnoreFlowSolutionPointersOff()
		{
			vtkCGNSReader.vtkCGNSReader_IgnoreFlowSolutionPointersOff_62(base.GetCppThis());
		}

		// Token: 0x06005C5E RID: 23646
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_IgnoreFlowSolutionPointersOn_63(HandleRef pThis);

		/// <summary>
		/// When set to true (default is false), the reader will simply
		/// ignore `FlowSolutionPointers` since they are either incomplete or invalid
		/// and instead will rely on FlowSolution_t nodes being labelled as
		/// "...AtStep&lt;tsindex&gt;" to locate solution nodes for a specific timestep.
		/// Note, tsindex starts with 1 (not zero).
		///
		/// When set to false, the reader will still try to confirm that at least one
		/// valid FlowSolution_t node is referred to in FlowSolutionPointers nodes for the
		/// current timestep. If none is found, then the reader will print out a
		/// warning and act as if IgnoreFlowSolutionPointers was set to true. To avoid
		/// this warning, one should set IgnoreFlowSolutionPointers to true.
		/// </summary>
		// Token: 0x06005C5F RID: 23647 RVA: 0x00085EE5 File Offset: 0x000840E5
		public virtual void IgnoreFlowSolutionPointersOn()
		{
			vtkCGNSReader.vtkCGNSReader_IgnoreFlowSolutionPointersOn_63(base.GetCppThis());
		}

		// Token: 0x06005C60 RID: 23648
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCGNSReader_IsA_64(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005C61 RID: 23649 RVA: 0x00085EF4 File Offset: 0x000840F4
		public override int IsA(string type)
		{
			return vtkCGNSReader.vtkCGNSReader_IsA_64(base.GetCppThis(), type);
		}

		// Token: 0x06005C62 RID: 23650
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCGNSReader_IsTypeOf_65([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005C63 RID: 23651 RVA: 0x00085F14 File Offset: 0x00084114
		public new static int IsTypeOf(string type)
		{
			return vtkCGNSReader.vtkCGNSReader_IsTypeOf_65(type);
		}

		// Token: 0x06005C64 RID: 23652
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_LoadBndPatchOff_66(HandleRef pThis);

		/// <summary>
		/// Enable/disable loading of boundary condition patches.
		/// Defaults to false.
		/// </summary>
		// Token: 0x06005C65 RID: 23653 RVA: 0x00085F2E File Offset: 0x0008412E
		public virtual void LoadBndPatchOff()
		{
			vtkCGNSReader.vtkCGNSReader_LoadBndPatchOff_66(base.GetCppThis());
		}

		// Token: 0x06005C66 RID: 23654
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_LoadBndPatchOn_67(HandleRef pThis);

		/// <summary>
		/// Enable/disable loading of boundary condition patches.
		/// Defaults to false.
		/// </summary>
		// Token: 0x06005C67 RID: 23655 RVA: 0x00085F3D File Offset: 0x0008413D
		public virtual void LoadBndPatchOn()
		{
			vtkCGNSReader.vtkCGNSReader_LoadBndPatchOn_67(base.GetCppThis());
		}

		// Token: 0x06005C68 RID: 23656
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_LoadMeshOff_68(HandleRef pThis);

		/// <summary>
		/// Enable/disable loading of zone mesh. Defaults to true. It may be turned off
		/// to load only boundary patches (when LoadBndPatch if ON), for example.
		/// </summary>
		// Token: 0x06005C69 RID: 23657 RVA: 0x00085F4C File Offset: 0x0008414C
		public virtual void LoadMeshOff()
		{
			vtkCGNSReader.vtkCGNSReader_LoadMeshOff_68(base.GetCppThis());
		}

		// Token: 0x06005C6A RID: 23658
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_LoadMeshOn_69(HandleRef pThis);

		/// <summary>
		/// Enable/disable loading of zone mesh. Defaults to true. It may be turned off
		/// to load only boundary patches (when LoadBndPatch if ON), for example.
		/// </summary>
		// Token: 0x06005C6B RID: 23659 RVA: 0x00085F5B File Offset: 0x0008415B
		public virtual void LoadMeshOn()
		{
			vtkCGNSReader.vtkCGNSReader_LoadMeshOn_69(base.GetCppThis());
		}

		// Token: 0x06005C6C RID: 23660
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCGNSReader_NewInstance_71(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005C6D RID: 23661 RVA: 0x00085F6C File Offset: 0x0008416C
		public new vtkCGNSReader NewInstance()
		{
			vtkCGNSReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCGNSReader.vtkCGNSReader_NewInstance_71(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCGNSReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005C6E RID: 23662
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCGNSReader_SafeDownCast_72(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005C6F RID: 23663 RVA: 0x00085FC8 File Offset: 0x000841C8
		public new static vtkCGNSReader SafeDownCast(vtkObjectBase o)
		{
			vtkCGNSReader vtkCGNSReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCGNSReader.vtkCGNSReader_SafeDownCast_72((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCGNSReader = (vtkCGNSReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCGNSReader.Register(null);
				}
			}
			return vtkCGNSReader;
		}

		// Token: 0x06005C70 RID: 23664
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_SetBaseArrayStatus_73(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// API to select bases to read. These calls simply forward to the
		/// vtkDataArraySelection instance obtained from `GetBaseSelection()`.
		///
		/// By default, 0-th base is enabled and all others are disabled.
		/// </summary>
		// Token: 0x06005C71 RID: 23665 RVA: 0x00086047 File Offset: 0x00084247
		public void SetBaseArrayStatus(string name, int status)
		{
			vtkCGNSReader.vtkCGNSReader_SetBaseArrayStatus_73(base.GetCppThis(), name, status);
		}

		// Token: 0x06005C72 RID: 23666
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_SetCacheConnectivity_74(HandleRef pThis, byte enable);

		/// <summary>
		/// This reader can cache the mesh connectivities if they are time invariant.
		/// They will be stored with a unique reference to their /base/zoneName
		/// and not be read in the file when doing unsteady analysis.
		/// Default is false.
		/// </summary>
		// Token: 0x06005C73 RID: 23667 RVA: 0x00086058 File Offset: 0x00084258
		public void SetCacheConnectivity(bool enable)
		{
			vtkCGNSReader.vtkCGNSReader_SetCacheConnectivity_74(base.GetCppThis(), enable ? (byte)1 : (byte)0);
		}

		// Token: 0x06005C74 RID: 23668
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_SetCacheMesh_75(HandleRef pThis, byte enable);

		/// <summary>
		/// This reader can cache the mesh points if they are time invariant.
		/// They will be stored with a unique reference to their /base/zoneName
		/// and not be read in the file when doing unsteady analysis.
		/// Default is false.
		/// </summary>
		// Token: 0x06005C75 RID: 23669 RVA: 0x00086070 File Offset: 0x00084270
		public void SetCacheMesh(bool enable)
		{
			vtkCGNSReader.vtkCGNSReader_SetCacheMesh_75(base.GetCppThis(), enable ? (byte)1 : (byte)0);
		}

		// Token: 0x06005C76 RID: 23670
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_SetCellArrayStatus_76(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// API to get information of cell arrays and enable/disable loading of
		/// particular arrays.
		/// </summary>
		// Token: 0x06005C77 RID: 23671 RVA: 0x00086088 File Offset: 0x00084288
		public void SetCellArrayStatus(string name, int status)
		{
			vtkCGNSReader.vtkCGNSReader_SetCellArrayStatus_76(base.GetCppThis(), name, status);
		}

		// Token: 0x06005C78 RID: 23672
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_SetController_77(HandleRef pThis, HandleRef c);

		/// <summary>
		/// Set/get the communication object used to relay a list of files
		/// from the rank 0 process to all others. This is the only interprocess
		/// communication required by vtkCGNSReader.
		/// </summary>
		// Token: 0x06005C79 RID: 23673 RVA: 0x0008609C File Offset: 0x0008429C
		public void SetController(vtkMultiProcessController c)
		{
			vtkCGNSReader.vtkCGNSReader_SetController_77(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		// Token: 0x06005C7A RID: 23674
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_SetCreateEachSolutionAsBlock_78(HandleRef pThis, int _arg);

		/// <summary>
		/// This option is provided for debugging and should not be used for production
		/// runs as the output data produced may not be correct. When set to true, the
		/// reader will simply read each solution (`FlowSolution_t`) node encountered in
		/// a zone and create a separate block under the block corresponding to the
		/// zone in the output.
		/// Default is 0 (false).
		/// </summary>
		// Token: 0x06005C7B RID: 23675 RVA: 0x000860CB File Offset: 0x000842CB
		public virtual void SetCreateEachSolutionAsBlock(int _arg)
		{
			vtkCGNSReader.vtkCGNSReader_SetCreateEachSolutionAsBlock_78(base.GetCppThis(), _arg);
		}

		// Token: 0x06005C7C RID: 23676
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_SetDataLocation_79(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the location of the data arrays to read. Possible values for the data location are:
		/// - CELL_DATA - Read CellCenter data arrays from the CGNS file. Construct 3D meshes with 3D cells
		/// (e.g. a cube is defined as 1 cell).
		/// - FACE_DATA - Read FaceCenter data arrays from the CGNS file. Construct 3D meshes with 2D
		/// cells/faces (e.g. a cube is defined as 6 quad cells). Element connectivity must be defined with
		/// element type NGON_n.
		///
		/// Default is CELL_DATA.
		/// </summary>
		// Token: 0x06005C7D RID: 23677 RVA: 0x000860DB File Offset: 0x000842DB
		public virtual void SetDataLocation(int _arg)
		{
			vtkCGNSReader.vtkCGNSReader_SetDataLocation_79(base.GetCppThis(), _arg);
		}

		// Token: 0x06005C7E RID: 23678
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_SetDistributeBlocks_80(HandleRef pThis, byte _arg);

		/// <summary>
		/// This reader can support piece requests by distributing each block in each
		/// zone across ranks (default). To make the reader disregard piece request and
		/// read all blocks in the zone, set this to false (default is true).
		/// </summary>
		// Token: 0x06005C7F RID: 23679 RVA: 0x000860EB File Offset: 0x000842EB
		public virtual void SetDistributeBlocks(bool _arg)
		{
			vtkCGNSReader.vtkCGNSReader_SetDistributeBlocks_80(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005C80 RID: 23680
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_SetDoublePrecisionMesh_81(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/disable double precision when reading the mesh.
		/// Defaults to 1 (true).
		/// </summary>
		// Token: 0x06005C81 RID: 23681 RVA: 0x00086103 File Offset: 0x00084303
		public virtual void SetDoublePrecisionMesh(int _arg)
		{
			vtkCGNSReader.vtkCGNSReader_SetDoublePrecisionMesh_81(base.GetCppThis(), _arg);
		}

		// Token: 0x06005C82 RID: 23682
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_SetFaceArrayStatus_82(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// API to get information of face arrays and enable/disable loading of
		/// particular arrays.
		/// </summary>
		// Token: 0x06005C83 RID: 23683 RVA: 0x00086113 File Offset: 0x00084313
		public void SetFaceArrayStatus(string name, int status)
		{
			vtkCGNSReader.vtkCGNSReader_SetFaceArrayStatus_82(base.GetCppThis(), name, status);
		}

		// Token: 0x06005C84 RID: 23684
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_SetFamilyArrayStatus_83(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// API to select families to read. These calls simply forward to the
		/// vtkDataArraySelection instance obtained from `GetFamilySelection()`.
		/// </summary>
		// Token: 0x06005C85 RID: 23685 RVA: 0x00086124 File Offset: 0x00084324
		public void SetFamilyArrayStatus(string name, int status)
		{
			vtkCGNSReader.vtkCGNSReader_SetFamilyArrayStatus_83(base.GetCppThis(), name, status);
		}

		// Token: 0x06005C86 RID: 23686
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_SetFileName_84(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg);

		/// <summary>
		/// Specify file name of CGNS datafile to read
		/// </summary>
		// Token: 0x06005C87 RID: 23687 RVA: 0x00086135 File Offset: 0x00084335
		public virtual void SetFileName(string arg)
		{
			vtkCGNSReader.vtkCGNSReader_SetFileName_84(base.GetCppThis(), arg);
		}

		// Token: 0x06005C88 RID: 23688
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_SetIgnoreFlowSolutionPointers_85(HandleRef pThis, byte _arg);

		/// <summary>
		/// When set to true (default is false), the reader will simply
		/// ignore `FlowSolutionPointers` since they are either incomplete or invalid
		/// and instead will rely on FlowSolution_t nodes being labelled as
		/// "...AtStep&lt;tsindex&gt;" to locate solution nodes for a specific timestep.
		/// Note, tsindex starts with 1 (not zero).
		///
		/// When set to false, the reader will still try to confirm that at least one
		/// valid FlowSolution_t node is referred to in FlowSolutionPointers nodes for the
		/// current timestep. If none is found, then the reader will print out a
		/// warning and act as if IgnoreFlowSolutionPointers was set to true. To avoid
		/// this warning, one should set IgnoreFlowSolutionPointers to true.
		/// </summary>
		// Token: 0x06005C89 RID: 23689 RVA: 0x00086145 File Offset: 0x00084345
		public virtual void SetIgnoreFlowSolutionPointers(bool _arg)
		{
			vtkCGNSReader.vtkCGNSReader_SetIgnoreFlowSolutionPointers_85(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005C8A RID: 23690
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_SetLoadBndPatch_86(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable/disable loading of boundary condition patches.
		/// Defaults to false.
		/// </summary>
		// Token: 0x06005C8B RID: 23691 RVA: 0x0008615D File Offset: 0x0008435D
		public virtual void SetLoadBndPatch(bool _arg)
		{
			vtkCGNSReader.vtkCGNSReader_SetLoadBndPatch_86(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005C8C RID: 23692
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_SetLoadMesh_87(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable/disable loading of zone mesh. Defaults to true. It may be turned off
		/// to load only boundary patches (when LoadBndPatch if ON), for example.
		/// </summary>
		// Token: 0x06005C8D RID: 23693 RVA: 0x00086175 File Offset: 0x00084375
		public virtual void SetLoadMesh(bool _arg)
		{
			vtkCGNSReader.vtkCGNSReader_SetLoadMesh_87(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005C8E RID: 23694
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_SetPointArrayStatus_88(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// API to get information of point arrays and enable/disable loading of
		/// particular arrays.
		/// </summary>
		// Token: 0x06005C8F RID: 23695 RVA: 0x0008618D File Offset: 0x0008438D
		public void SetPointArrayStatus(string name, int status)
		{
			vtkCGNSReader.vtkCGNSReader_SetPointArrayStatus_88(base.GetCppThis(), name, status);
		}

		// Token: 0x06005C90 RID: 23696
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_SetUnsteadySolutionStartTimestep_89(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the index of the first timestep when reading unsteady solutions.
		/// Only used when "UseUnsteadyPattern" is true.
		/// Default is 0.
		/// </summary>
		// Token: 0x06005C91 RID: 23697 RVA: 0x0008619E File Offset: 0x0008439E
		public virtual void SetUnsteadySolutionStartTimestep(int _arg)
		{
			vtkCGNSReader.vtkCGNSReader_SetUnsteadySolutionStartTimestep_89(base.GetCppThis(), _arg);
		}

		// Token: 0x06005C92 RID: 23698
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_SetUse3DVector_90(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable/disable adding an empty physical dimension to vectors in case of 2D solutions.
		/// Default is true.
		/// </summary>
		// Token: 0x06005C93 RID: 23699 RVA: 0x000861AE File Offset: 0x000843AE
		public virtual void SetUse3DVector(bool _arg)
		{
			vtkCGNSReader.vtkCGNSReader_SetUse3DVector_90(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005C94 RID: 23700
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_SetUseUnsteadyPattern_91(HandleRef pThis, byte _arg);

		/// <summary>
		/// When set to true (default is false), the reader will try
		/// to determine to determine FlowSolution_t nodes to read with pattern matching.
		/// This can be useful for unsteady solutions when `FlowSolutionPointers` are not
		/// reliable.
		/// </summary>
		// Token: 0x06005C95 RID: 23701 RVA: 0x000861C6 File Offset: 0x000843C6
		public virtual void SetUseUnsteadyPattern(bool _arg)
		{
			vtkCGNSReader.vtkCGNSReader_SetUseUnsteadyPattern_91(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005C96 RID: 23702
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_Use3DVectorOff_92(HandleRef pThis);

		/// <summary>
		/// Enable/disable adding an empty physical dimension to vectors in case of 2D solutions.
		/// Default is true.
		/// </summary>
		// Token: 0x06005C97 RID: 23703 RVA: 0x000861DE File Offset: 0x000843DE
		public virtual void Use3DVectorOff()
		{
			vtkCGNSReader.vtkCGNSReader_Use3DVectorOff_92(base.GetCppThis());
		}

		// Token: 0x06005C98 RID: 23704
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_Use3DVectorOn_93(HandleRef pThis);

		/// <summary>
		/// Enable/disable adding an empty physical dimension to vectors in case of 2D solutions.
		/// Default is true.
		/// </summary>
		// Token: 0x06005C99 RID: 23705 RVA: 0x000861ED File Offset: 0x000843ED
		public virtual void Use3DVectorOn()
		{
			vtkCGNSReader.vtkCGNSReader_Use3DVectorOn_93(base.GetCppThis());
		}

		// Token: 0x06005C9A RID: 23706
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_UseUnsteadyPatternOff_94(HandleRef pThis);

		/// <summary>
		/// When set to true (default is false), the reader will try
		/// to determine to determine FlowSolution_t nodes to read with pattern matching.
		/// This can be useful for unsteady solutions when `FlowSolutionPointers` are not
		/// reliable.
		/// </summary>
		// Token: 0x06005C9B RID: 23707 RVA: 0x000861FC File Offset: 0x000843FC
		public virtual void UseUnsteadyPatternOff()
		{
			vtkCGNSReader.vtkCGNSReader_UseUnsteadyPatternOff_94(base.GetCppThis());
		}

		// Token: 0x06005C9C RID: 23708
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCGNSReader_UseUnsteadyPatternOn_95(HandleRef pThis);

		/// <summary>
		/// When set to true (default is false), the reader will try
		/// to determine to determine FlowSolution_t nodes to read with pattern matching.
		/// This can be useful for unsteady solutions when `FlowSolutionPointers` are not
		/// reliable.
		/// </summary>
		// Token: 0x06005C9D RID: 23709 RVA: 0x0008620B File Offset: 0x0008440B
		public virtual void UseUnsteadyPatternOn()
		{
			vtkCGNSReader.vtkCGNSReader_UseUnsteadyPatternOn_95(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400088F RID: 2191
		public new const string MRFullTypeName = "Kitware.VTK.vtkCGNSReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000890 RID: 2192
		public new static readonly string MRClassNameKey = "class vtkCGNSReader";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x020001E4 RID: 484
		public enum DataArrayLocation
		{
			/// <summary>enum member</summary>
			// Token: 0x04000892 RID: 2194
			CELL_DATA,
			/// <summary>enum member</summary>
			// Token: 0x04000893 RID: 2195
			FACE_DATA
		}
	}
}
