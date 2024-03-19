using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkConnectivityFilter
	/// </summary>
	/// <remarks>
	///    extract data based on geometric connectivity
	///
	/// vtkConnectivityFilter is a filter that extracts cells that share common
	/// points and/or meet other connectivity criterion. (Cells that share
	/// vertices and meet other connectivity criterion such as scalar range are
	/// known as a region.)  The filter works in one of six ways: 1) extract the
	/// largest connected region in the dataset; 2) extract specified region
	/// numbers; 3) extract all regions sharing specified point ids; 4) extract
	/// all regions sharing specified cell ids; 5) extract the region closest to
	/// the specified point; or 6) extract all regions (used to color the data by
	/// region).
	///
	/// vtkConnectivityFilter is generalized to handle any type of input dataset.
	/// If the input to this filter is a vtkPolyData, the output will be a vtkPolyData.
	/// For all other input types, it generates output data of type vtkUnstructuredGrid.
	/// Note that the only Get*Output() methods that will return a non-null pointer
	/// are GetUnstructuredGridOutput() and GetPolyDataOutput() when the output of the
	/// filter is a vtkUnstructuredGrid or vtkPolyData, respectively.
	///
	/// The behavior of vtkConnectivityFilter can be modified by turning on the
	/// boolean ivar ScalarConnectivity. If this flag is on, the connectivity
	/// algorithm is modified so that cells are considered connected only if 1)
	/// they are geometrically connected (share a point) and 2) the scalar values
	/// of one of the cell's points falls in the scalar range specified. This use
	/// of ScalarConnectivity is particularly useful for volume datasets: it can
	/// be used as a simple "connected segmentation" algorithm. For example, by
	/// using a seed voxel (i.e., cell) on a known anatomical structure,
	/// connectivity will pull out all voxels "containing" the anatomical
	/// structure. These voxels can then be contoured or processed by other
	/// visualization filters.
	///
	/// If the extraction mode is set to all regions and ColorRegions is enabled,
	/// The RegionIds are assigned to each region by the order in which the region
	/// was processed and has no other significance with respect to the size of
	/// or number of cells.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPolyDataConnectivityFilter
	/// </seealso>
	// Token: 0x0200094C RID: 2380
	public class vtkConnectivityFilter : vtkPointSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018ACE RID: 101070 RVA: 0x002279B7 File Offset: 0x00225BB7
		static vtkConnectivityFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkConnectivityFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkConnectivityFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018ACF RID: 101071 RVA: 0x002279DF File Offset: 0x00225BDF
		public vtkConnectivityFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018AD0 RID: 101072
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConnectivityFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with default extraction mode to extract largest regions.
		/// </summary>
		// Token: 0x06018AD1 RID: 101073 RVA: 0x002279F0 File Offset: 0x00225BF0
		public new static vtkConnectivityFilter New()
		{
			vtkConnectivityFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConnectivityFilter.vtkConnectivityFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConnectivityFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with default extraction mode to extract largest regions.
		/// </summary>
		// Token: 0x06018AD2 RID: 101074 RVA: 0x00227A44 File Offset: 0x00225C44
		public vtkConnectivityFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkConnectivityFilter.vtkConnectivityFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018AD3 RID: 101075 RVA: 0x00227A88 File Offset: 0x00225C88
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018AD4 RID: 101076
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectivityFilter_AddSeed_01(HandleRef pThis, long id);

		/// <summary>
		/// Add a seed id (point or cell id). Note: ids are 0-offset.
		/// </summary>
		// Token: 0x06018AD5 RID: 101077 RVA: 0x00227A93 File Offset: 0x00225C93
		public void AddSeed(long id)
		{
			vtkConnectivityFilter.vtkConnectivityFilter_AddSeed_01(base.GetCppThis(), id);
		}

		// Token: 0x06018AD6 RID: 101078
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectivityFilter_AddSpecifiedRegion_02(HandleRef pThis, int id);

		/// <summary>
		/// Add a region id to extract. Note: ids are 0-offset.
		/// </summary>
		// Token: 0x06018AD7 RID: 101079 RVA: 0x00227AA3 File Offset: 0x00225CA3
		public void AddSpecifiedRegion(int id)
		{
			vtkConnectivityFilter.vtkConnectivityFilter_AddSpecifiedRegion_02(base.GetCppThis(), id);
		}

		// Token: 0x06018AD8 RID: 101080
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectivityFilter_ColorRegionsOff_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off the coloring of connected regions.
		/// </summary>
		// Token: 0x06018AD9 RID: 101081 RVA: 0x00227AB3 File Offset: 0x00225CB3
		public virtual void ColorRegionsOff()
		{
			vtkConnectivityFilter.vtkConnectivityFilter_ColorRegionsOff_03(base.GetCppThis());
		}

		// Token: 0x06018ADA RID: 101082
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectivityFilter_ColorRegionsOn_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off the coloring of connected regions.
		/// </summary>
		// Token: 0x06018ADB RID: 101083 RVA: 0x00227AC2 File Offset: 0x00225CC2
		public virtual void ColorRegionsOn()
		{
			vtkConnectivityFilter.vtkConnectivityFilter_ColorRegionsOn_04(base.GetCppThis());
		}

		// Token: 0x06018ADC RID: 101084
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectivityFilter_DeleteSeed_05(HandleRef pThis, long id);

		/// <summary>
		/// Delete a seed id (point or cell id). Note: ids are 0-offset.
		/// </summary>
		// Token: 0x06018ADD RID: 101085 RVA: 0x00227AD1 File Offset: 0x00225CD1
		public void DeleteSeed(long id)
		{
			vtkConnectivityFilter.vtkConnectivityFilter_DeleteSeed_05(base.GetCppThis(), id);
		}

		// Token: 0x06018ADE RID: 101086
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectivityFilter_DeleteSpecifiedRegion_06(HandleRef pThis, int id);

		/// <summary>
		/// Delete a region id to extract. Note: ids are 0-offset.
		/// </summary>
		// Token: 0x06018ADF RID: 101087 RVA: 0x00227AE1 File Offset: 0x00225CE1
		public void DeleteSpecifiedRegion(int id)
		{
			vtkConnectivityFilter.vtkConnectivityFilter_DeleteSpecifiedRegion_06(base.GetCppThis(), id);
		}

		// Token: 0x06018AE0 RID: 101088
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConnectivityFilter_GetClosestPoint_07(HandleRef pThis);

		/// <summary>
		/// Use to specify x-y-z point coordinates when extracting the region
		/// closest to a specified point.
		/// </summary>
		// Token: 0x06018AE1 RID: 101089 RVA: 0x00227AF4 File Offset: 0x00225CF4
		public virtual double[] GetClosestPoint()
		{
			IntPtr intPtr = vtkConnectivityFilter.vtkConnectivityFilter_GetClosestPoint_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06018AE2 RID: 101090
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectivityFilter_GetClosestPoint_08(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Use to specify x-y-z point coordinates when extracting the region
		/// closest to a specified point.
		/// </summary>
		// Token: 0x06018AE3 RID: 101091 RVA: 0x00227B3C File Offset: 0x00225D3C
		public virtual void GetClosestPoint(IntPtr data)
		{
			vtkConnectivityFilter.vtkConnectivityFilter_GetClosestPoint_08(base.GetCppThis(), data);
		}

		// Token: 0x06018AE4 RID: 101092
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConnectivityFilter_GetColorRegions_09(HandleRef pThis);

		/// <summary>
		/// Turn on/off the coloring of connected regions.
		/// </summary>
		// Token: 0x06018AE5 RID: 101093 RVA: 0x00227B4C File Offset: 0x00225D4C
		public virtual int GetColorRegions()
		{
			return vtkConnectivityFilter.vtkConnectivityFilter_GetColorRegions_09(base.GetCppThis());
		}

		// Token: 0x06018AE6 RID: 101094
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConnectivityFilter_GetExtractionMode_10(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x06018AE7 RID: 101095 RVA: 0x00227B6C File Offset: 0x00225D6C
		public virtual int GetExtractionMode()
		{
			return vtkConnectivityFilter.vtkConnectivityFilter_GetExtractionMode_10(base.GetCppThis());
		}

		// Token: 0x06018AE8 RID: 101096
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConnectivityFilter_GetExtractionModeAsString_11(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x06018AE9 RID: 101097 RVA: 0x00227B8C File Offset: 0x00225D8C
		public string GetExtractionModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkConnectivityFilter.vtkConnectivityFilter_GetExtractionModeAsString_11(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06018AEA RID: 101098
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConnectivityFilter_GetExtractionModeMaxValue_12(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x06018AEB RID: 101099 RVA: 0x00227BC8 File Offset: 0x00225DC8
		public virtual int GetExtractionModeMaxValue()
		{
			return vtkConnectivityFilter.vtkConnectivityFilter_GetExtractionModeMaxValue_12(base.GetCppThis());
		}

		// Token: 0x06018AEC RID: 101100
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConnectivityFilter_GetExtractionModeMinValue_13(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x06018AED RID: 101101 RVA: 0x00227BE8 File Offset: 0x00225DE8
		public virtual int GetExtractionModeMinValue()
		{
			return vtkConnectivityFilter.vtkConnectivityFilter_GetExtractionModeMinValue_13(base.GetCppThis());
		}

		// Token: 0x06018AEE RID: 101102
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConnectivityFilter_GetNumberOfExtractedRegions_14(HandleRef pThis);

		/// <summary>
		/// Obtain the number of connected regions.
		/// </summary>
		// Token: 0x06018AEF RID: 101103 RVA: 0x00227C08 File Offset: 0x00225E08
		public int GetNumberOfExtractedRegions()
		{
			return vtkConnectivityFilter.vtkConnectivityFilter_GetNumberOfExtractedRegions_14(base.GetCppThis());
		}

		// Token: 0x06018AF0 RID: 101104
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkConnectivityFilter_GetNumberOfGenerationsFromBase_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018AF1 RID: 101105 RVA: 0x00227C28 File Offset: 0x00225E28
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkConnectivityFilter.vtkConnectivityFilter_GetNumberOfGenerationsFromBase_15(base.GetCppThis(), type);
		}

		// Token: 0x06018AF2 RID: 101106
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkConnectivityFilter_GetNumberOfGenerationsFromBaseType_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018AF3 RID: 101107 RVA: 0x00227C48 File Offset: 0x00225E48
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkConnectivityFilter.vtkConnectivityFilter_GetNumberOfGenerationsFromBaseType_16(type);
		}

		// Token: 0x06018AF4 RID: 101108
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConnectivityFilter_GetOutputPointsPrecision_17(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06018AF5 RID: 101109 RVA: 0x00227C64 File Offset: 0x00225E64
		public virtual int GetOutputPointsPrecision()
		{
			return vtkConnectivityFilter.vtkConnectivityFilter_GetOutputPointsPrecision_17(base.GetCppThis());
		}

		// Token: 0x06018AF6 RID: 101110
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConnectivityFilter_GetRegionIdAssignmentMode_18(HandleRef pThis);

		/// <summary>
		/// Set/get mode controlling how RegionIds are assigned.
		/// </summary>
		// Token: 0x06018AF7 RID: 101111 RVA: 0x00227C84 File Offset: 0x00225E84
		public virtual int GetRegionIdAssignmentMode()
		{
			return vtkConnectivityFilter.vtkConnectivityFilter_GetRegionIdAssignmentMode_18(base.GetCppThis());
		}

		// Token: 0x06018AF8 RID: 101112
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConnectivityFilter_GetScalarConnectivity_19(HandleRef pThis);

		/// <summary>
		/// Turn on/off connectivity based on scalar value. If on, cells are connected
		/// only if they share points AND one of the cells scalar values falls in the
		/// scalar range specified.
		/// </summary>
		// Token: 0x06018AF9 RID: 101113 RVA: 0x00227CA4 File Offset: 0x00225EA4
		public virtual int GetScalarConnectivity()
		{
			return vtkConnectivityFilter.vtkConnectivityFilter_GetScalarConnectivity_19(base.GetCppThis());
		}

		// Token: 0x06018AFA RID: 101114
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConnectivityFilter_GetScalarRange_20(HandleRef pThis);

		/// <summary>
		/// Set the scalar range to use to extract cells based on scalar connectivity.
		/// </summary>
		// Token: 0x06018AFB RID: 101115 RVA: 0x00227CC4 File Offset: 0x00225EC4
		public virtual double[] GetScalarRange()
		{
			IntPtr intPtr = vtkConnectivityFilter.vtkConnectivityFilter_GetScalarRange_20(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06018AFC RID: 101116
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectivityFilter_GetScalarRange_21(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Set the scalar range to use to extract cells based on scalar connectivity.
		/// </summary>
		// Token: 0x06018AFD RID: 101117 RVA: 0x00227D0C File Offset: 0x00225F0C
		public virtual void GetScalarRange(ref double _arg1, ref double _arg2)
		{
			vtkConnectivityFilter.vtkConnectivityFilter_GetScalarRange_21(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06018AFE RID: 101118
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectivityFilter_GetScalarRange_22(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the scalar range to use to extract cells based on scalar connectivity.
		/// </summary>
		// Token: 0x06018AFF RID: 101119 RVA: 0x00227D1D File Offset: 0x00225F1D
		public virtual void GetScalarRange(IntPtr _arg)
		{
			vtkConnectivityFilter.vtkConnectivityFilter_GetScalarRange_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06018B00 RID: 101120
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectivityFilter_InitializeSeedList_23(HandleRef pThis);

		/// <summary>
		/// Initialize list of point ids/cell ids used to seed regions.
		/// </summary>
		// Token: 0x06018B01 RID: 101121 RVA: 0x00227D2D File Offset: 0x00225F2D
		public void InitializeSeedList()
		{
			vtkConnectivityFilter.vtkConnectivityFilter_InitializeSeedList_23(base.GetCppThis());
		}

		// Token: 0x06018B02 RID: 101122
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectivityFilter_InitializeSpecifiedRegionList_24(HandleRef pThis);

		/// <summary>
		/// Initialize list of region ids to extract.
		/// </summary>
		// Token: 0x06018B03 RID: 101123 RVA: 0x00227D3C File Offset: 0x00225F3C
		public void InitializeSpecifiedRegionList()
		{
			vtkConnectivityFilter.vtkConnectivityFilter_InitializeSpecifiedRegionList_24(base.GetCppThis());
		}

		// Token: 0x06018B04 RID: 101124
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConnectivityFilter_IsA_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018B05 RID: 101125 RVA: 0x00227D4C File Offset: 0x00225F4C
		public override int IsA(string type)
		{
			return vtkConnectivityFilter.vtkConnectivityFilter_IsA_25(base.GetCppThis(), type);
		}

		// Token: 0x06018B06 RID: 101126
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConnectivityFilter_IsTypeOf_26([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018B07 RID: 101127 RVA: 0x00227D6C File Offset: 0x00225F6C
		public new static int IsTypeOf(string type)
		{
			return vtkConnectivityFilter.vtkConnectivityFilter_IsTypeOf_26(type);
		}

		// Token: 0x06018B08 RID: 101128
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConnectivityFilter_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018B09 RID: 101129 RVA: 0x00227D88 File Offset: 0x00225F88
		public new vtkConnectivityFilter NewInstance()
		{
			vtkConnectivityFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConnectivityFilter.vtkConnectivityFilter_NewInstance_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConnectivityFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018B0A RID: 101130
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConnectivityFilter_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018B0B RID: 101131 RVA: 0x00227DE4 File Offset: 0x00225FE4
		public new static vtkConnectivityFilter SafeDownCast(vtkObjectBase o)
		{
			vtkConnectivityFilter vtkConnectivityFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConnectivityFilter.vtkConnectivityFilter_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkConnectivityFilter = (vtkConnectivityFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkConnectivityFilter.Register(null);
				}
			}
			return vtkConnectivityFilter;
		}

		// Token: 0x06018B0C RID: 101132
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectivityFilter_ScalarConnectivityOff_30(HandleRef pThis);

		/// <summary>
		/// Turn on/off connectivity based on scalar value. If on, cells are connected
		/// only if they share points AND one of the cells scalar values falls in the
		/// scalar range specified.
		/// </summary>
		// Token: 0x06018B0D RID: 101133 RVA: 0x00227E63 File Offset: 0x00226063
		public virtual void ScalarConnectivityOff()
		{
			vtkConnectivityFilter.vtkConnectivityFilter_ScalarConnectivityOff_30(base.GetCppThis());
		}

		// Token: 0x06018B0E RID: 101134
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectivityFilter_ScalarConnectivityOn_31(HandleRef pThis);

		/// <summary>
		/// Turn on/off connectivity based on scalar value. If on, cells are connected
		/// only if they share points AND one of the cells scalar values falls in the
		/// scalar range specified.
		/// </summary>
		// Token: 0x06018B0F RID: 101135 RVA: 0x00227E72 File Offset: 0x00226072
		public virtual void ScalarConnectivityOn()
		{
			vtkConnectivityFilter.vtkConnectivityFilter_ScalarConnectivityOn_31(base.GetCppThis());
		}

		// Token: 0x06018B10 RID: 101136
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectivityFilter_SetClosestPoint_32(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Use to specify x-y-z point coordinates when extracting the region
		/// closest to a specified point.
		/// </summary>
		// Token: 0x06018B11 RID: 101137 RVA: 0x00227E81 File Offset: 0x00226081
		public virtual void SetClosestPoint(double _arg1, double _arg2, double _arg3)
		{
			vtkConnectivityFilter.vtkConnectivityFilter_SetClosestPoint_32(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06018B12 RID: 101138
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectivityFilter_SetClosestPoint_33(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Use to specify x-y-z point coordinates when extracting the region
		/// closest to a specified point.
		/// </summary>
		// Token: 0x06018B13 RID: 101139 RVA: 0x00227E93 File Offset: 0x00226093
		public virtual void SetClosestPoint(IntPtr _arg)
		{
			vtkConnectivityFilter.vtkConnectivityFilter_SetClosestPoint_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06018B14 RID: 101140
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectivityFilter_SetColorRegions_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the coloring of connected regions.
		/// </summary>
		// Token: 0x06018B15 RID: 101141 RVA: 0x00227EA3 File Offset: 0x002260A3
		public virtual void SetColorRegions(int _arg)
		{
			vtkConnectivityFilter.vtkConnectivityFilter_SetColorRegions_34(base.GetCppThis(), _arg);
		}

		// Token: 0x06018B16 RID: 101142
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectivityFilter_SetExtractionMode_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x06018B17 RID: 101143 RVA: 0x00227EB3 File Offset: 0x002260B3
		public virtual void SetExtractionMode(int _arg)
		{
			vtkConnectivityFilter.vtkConnectivityFilter_SetExtractionMode_35(base.GetCppThis(), _arg);
		}

		// Token: 0x06018B18 RID: 101144
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectivityFilter_SetExtractionModeToAllRegions_36(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x06018B19 RID: 101145 RVA: 0x00227EC3 File Offset: 0x002260C3
		public void SetExtractionModeToAllRegions()
		{
			vtkConnectivityFilter.vtkConnectivityFilter_SetExtractionModeToAllRegions_36(base.GetCppThis());
		}

		// Token: 0x06018B1A RID: 101146
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectivityFilter_SetExtractionModeToCellSeededRegions_37(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x06018B1B RID: 101147 RVA: 0x00227ED2 File Offset: 0x002260D2
		public void SetExtractionModeToCellSeededRegions()
		{
			vtkConnectivityFilter.vtkConnectivityFilter_SetExtractionModeToCellSeededRegions_37(base.GetCppThis());
		}

		// Token: 0x06018B1C RID: 101148
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectivityFilter_SetExtractionModeToClosestPointRegion_38(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x06018B1D RID: 101149 RVA: 0x00227EE1 File Offset: 0x002260E1
		public void SetExtractionModeToClosestPointRegion()
		{
			vtkConnectivityFilter.vtkConnectivityFilter_SetExtractionModeToClosestPointRegion_38(base.GetCppThis());
		}

		// Token: 0x06018B1E RID: 101150
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectivityFilter_SetExtractionModeToLargestRegion_39(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x06018B1F RID: 101151 RVA: 0x00227EF0 File Offset: 0x002260F0
		public void SetExtractionModeToLargestRegion()
		{
			vtkConnectivityFilter.vtkConnectivityFilter_SetExtractionModeToLargestRegion_39(base.GetCppThis());
		}

		// Token: 0x06018B20 RID: 101152
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectivityFilter_SetExtractionModeToPointSeededRegions_40(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x06018B21 RID: 101153 RVA: 0x00227EFF File Offset: 0x002260FF
		public void SetExtractionModeToPointSeededRegions()
		{
			vtkConnectivityFilter.vtkConnectivityFilter_SetExtractionModeToPointSeededRegions_40(base.GetCppThis());
		}

		// Token: 0x06018B22 RID: 101154
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectivityFilter_SetExtractionModeToSpecifiedRegions_41(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x06018B23 RID: 101155 RVA: 0x00227F0E File Offset: 0x0022610E
		public void SetExtractionModeToSpecifiedRegions()
		{
			vtkConnectivityFilter.vtkConnectivityFilter_SetExtractionModeToSpecifiedRegions_41(base.GetCppThis());
		}

		// Token: 0x06018B24 RID: 101156
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectivityFilter_SetOutputPointsPrecision_42(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06018B25 RID: 101157 RVA: 0x00227F1D File Offset: 0x0022611D
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkConnectivityFilter.vtkConnectivityFilter_SetOutputPointsPrecision_42(base.GetCppThis(), _arg);
		}

		// Token: 0x06018B26 RID: 101158
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectivityFilter_SetRegionIdAssignmentMode_43(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get mode controlling how RegionIds are assigned.
		/// </summary>
		// Token: 0x06018B27 RID: 101159 RVA: 0x00227F2D File Offset: 0x0022612D
		public virtual void SetRegionIdAssignmentMode(int _arg)
		{
			vtkConnectivityFilter.vtkConnectivityFilter_SetRegionIdAssignmentMode_43(base.GetCppThis(), _arg);
		}

		// Token: 0x06018B28 RID: 101160
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectivityFilter_SetScalarConnectivity_44(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off connectivity based on scalar value. If on, cells are connected
		/// only if they share points AND one of the cells scalar values falls in the
		/// scalar range specified.
		/// </summary>
		// Token: 0x06018B29 RID: 101161 RVA: 0x00227F3D File Offset: 0x0022613D
		public virtual void SetScalarConnectivity(int _arg)
		{
			vtkConnectivityFilter.vtkConnectivityFilter_SetScalarConnectivity_44(base.GetCppThis(), _arg);
		}

		// Token: 0x06018B2A RID: 101162
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectivityFilter_SetScalarRange_45(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Set the scalar range to use to extract cells based on scalar connectivity.
		/// </summary>
		// Token: 0x06018B2B RID: 101163 RVA: 0x00227F4D File Offset: 0x0022614D
		public virtual void SetScalarRange(double _arg1, double _arg2)
		{
			vtkConnectivityFilter.vtkConnectivityFilter_SetScalarRange_45(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06018B2C RID: 101164
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectivityFilter_SetScalarRange_46(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the scalar range to use to extract cells based on scalar connectivity.
		/// </summary>
		// Token: 0x06018B2D RID: 101165 RVA: 0x00227F5E File Offset: 0x0022615E
		public void SetScalarRange(IntPtr _arg)
		{
			vtkConnectivityFilter.vtkConnectivityFilter_SetScalarRange_46(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B4C RID: 6988
		public new const string MRFullTypeName = "Kitware.VTK.vtkConnectivityFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B4D RID: 6989
		public new static readonly string MRClassNameKey = "class vtkConnectivityFilter";

		/// <summary>
		/// Enumeration of the various ways to assign RegionIds when
		/// the ColorRegions option is on.
		/// </summary>
		// Token: 0x0200094D RID: 2381
		public enum RegionIdAssignment
		{
			/// <summary>enum member</summary>
			// Token: 0x04001B4F RID: 6991
			CELL_COUNT_ASCENDING = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001B50 RID: 6992
			CELL_COUNT_DESCENDING = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001B51 RID: 6993
			UNSPECIFIED = 0
		}
	}
}
