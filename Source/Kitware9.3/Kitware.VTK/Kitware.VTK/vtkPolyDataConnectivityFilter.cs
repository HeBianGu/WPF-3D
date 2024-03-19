using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyDataConnectivityFilter
	/// </summary>
	/// <remarks>
	///    extract polygonal data based on geometric connectivity
	///
	/// vtkPolyDataConnectivityFilter is a filter that extracts cells that
	/// share common points and/or satisfy a scalar threshold
	/// criterion. (Such a group of cells is called a region.) The filter
	/// works in one of six ways: 1) extract the largest (most points) connected region
	/// in the dataset; 2) extract specified region numbers; 3) extract all
	/// regions sharing specified point ids; 4) extract all regions sharing
	/// specified cell ids; 5) extract the region closest to the specified
	/// point; or 6) extract all regions (used to color regions).
	///
	/// This filter is specialized for polygonal data. This means it runs a bit
	/// faster and is easier to construct visualization networks that process
	/// polygonal data.
	///
	/// The behavior of vtkPolyDataConnectivityFilter can be modified by turning
	/// on the boolean ivar ScalarConnectivity. If this flag is on, the
	/// connectivity algorithm is modified so that cells are considered connected
	/// only if 1) they are geometrically connected (share a point) and 2) the
	/// scalar values of the cell's points falls in the scalar range specified.
	/// If ScalarConnectivity and FullScalarConnectivity is ON, all the cell's
	/// points must lie in the scalar range specified for the cell to qualify as
	/// being connected. If FullScalarConnectivity is OFF, any one of the cell's
	/// points may lie in the user specified scalar range for the cell to qualify
	/// as being connected.
	///
	/// This use of ScalarConnectivity is particularly useful for selecting cells
	/// for later processing.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkConnectivityFilter
	/// </seealso>
	// Token: 0x02000988 RID: 2440
	public class vtkPolyDataConnectivityFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019675 RID: 104053 RVA: 0x002363A3 File Offset: 0x002345A3
		static vtkPolyDataConnectivityFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataConnectivityFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataConnectivityFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019676 RID: 104054 RVA: 0x002363CB File Offset: 0x002345CB
		public vtkPolyDataConnectivityFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019677 RID: 104055
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataConnectivityFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with default extraction mode to extract largest regions.
		/// </summary>
		// Token: 0x06019678 RID: 104056 RVA: 0x002363DC File Offset: 0x002345DC
		public new static vtkPolyDataConnectivityFilter New()
		{
			vtkPolyDataConnectivityFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataConnectivityFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with default extraction mode to extract largest regions.
		/// </summary>
		// Token: 0x06019679 RID: 104057 RVA: 0x00236430 File Offset: 0x00234630
		public vtkPolyDataConnectivityFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601967A RID: 104058 RVA: 0x00236474 File Offset: 0x00234674
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601967B RID: 104059
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_AddSeed_01(HandleRef pThis, int id);

		/// <summary>
		/// Add a seed id (point or cell id). Note: ids are 0-offset.
		/// </summary>
		// Token: 0x0601967C RID: 104060 RVA: 0x0023647F File Offset: 0x0023467F
		public void AddSeed(int id)
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_AddSeed_01(base.GetCppThis(), id);
		}

		// Token: 0x0601967D RID: 104061
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_AddSpecifiedRegion_02(HandleRef pThis, int id);

		/// <summary>
		/// Add a region id to extract. Note: ids are 0-offset.
		/// </summary>
		// Token: 0x0601967E RID: 104062 RVA: 0x0023648F File Offset: 0x0023468F
		public void AddSpecifiedRegion(int id)
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_AddSpecifiedRegion_02(base.GetCppThis(), id);
		}

		// Token: 0x0601967F RID: 104063
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_ColorRegionsOff_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off the coloring of connected regions.
		/// </summary>
		// Token: 0x06019680 RID: 104064 RVA: 0x0023649F File Offset: 0x0023469F
		public virtual void ColorRegionsOff()
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_ColorRegionsOff_03(base.GetCppThis());
		}

		// Token: 0x06019681 RID: 104065
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_ColorRegionsOn_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off the coloring of connected regions.
		/// </summary>
		// Token: 0x06019682 RID: 104066 RVA: 0x002364AE File Offset: 0x002346AE
		public virtual void ColorRegionsOn()
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_ColorRegionsOn_04(base.GetCppThis());
		}

		// Token: 0x06019683 RID: 104067
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_DeleteSeed_05(HandleRef pThis, int id);

		/// <summary>
		/// Delete a seed id (point or cell id). Note: ids are 0-offset.
		/// </summary>
		// Token: 0x06019684 RID: 104068 RVA: 0x002364BD File Offset: 0x002346BD
		public void DeleteSeed(int id)
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_DeleteSeed_05(base.GetCppThis(), id);
		}

		// Token: 0x06019685 RID: 104069
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_DeleteSpecifiedRegion_06(HandleRef pThis, int id);

		/// <summary>
		/// Delete a region id to extract. Note: ids are 0-offset.
		/// </summary>
		// Token: 0x06019686 RID: 104070 RVA: 0x002364CD File Offset: 0x002346CD
		public void DeleteSpecifiedRegion(int id)
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_DeleteSpecifiedRegion_06(base.GetCppThis(), id);
		}

		// Token: 0x06019687 RID: 104071
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_FullScalarConnectivityOff_07(HandleRef pThis);

		/// <summary>
		/// Turn on/off the use of Fully connected scalar connectivity. This is off
		/// by default. The flag is used only if ScalarConnectivity is on. If
		/// FullScalarConnectivity is ON, all the cell's points must lie in the
		/// scalar range specified for the cell to qualify as being connected. If
		/// FullScalarConnectivity is OFF, any one of the cell's points may lie in
		/// the user specified scalar range for the cell to qualify as being
		/// connected.
		/// </summary>
		// Token: 0x06019688 RID: 104072 RVA: 0x002364DD File Offset: 0x002346DD
		public virtual void FullScalarConnectivityOff()
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_FullScalarConnectivityOff_07(base.GetCppThis());
		}

		// Token: 0x06019689 RID: 104073
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_FullScalarConnectivityOn_08(HandleRef pThis);

		/// <summary>
		/// Turn on/off the use of Fully connected scalar connectivity. This is off
		/// by default. The flag is used only if ScalarConnectivity is on. If
		/// FullScalarConnectivity is ON, all the cell's points must lie in the
		/// scalar range specified for the cell to qualify as being connected. If
		/// FullScalarConnectivity is OFF, any one of the cell's points may lie in
		/// the user specified scalar range for the cell to qualify as being
		/// connected.
		/// </summary>
		// Token: 0x0601968A RID: 104074 RVA: 0x002364EC File Offset: 0x002346EC
		public virtual void FullScalarConnectivityOn()
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_FullScalarConnectivityOn_08(base.GetCppThis());
		}

		// Token: 0x0601968B RID: 104075
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataConnectivityFilter_GetClosestPoint_09(HandleRef pThis);

		/// <summary>
		/// Use to specify x-y-z point coordinates when extracting the region
		/// closest to a specified point.
		/// </summary>
		// Token: 0x0601968C RID: 104076 RVA: 0x002364FC File Offset: 0x002346FC
		public virtual double[] GetClosestPoint()
		{
			IntPtr intPtr = vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_GetClosestPoint_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601968D RID: 104077
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_GetClosestPoint_10(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Use to specify x-y-z point coordinates when extracting the region
		/// closest to a specified point.
		/// </summary>
		// Token: 0x0601968E RID: 104078 RVA: 0x00236544 File Offset: 0x00234744
		public virtual void GetClosestPoint(IntPtr data)
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_GetClosestPoint_10(base.GetCppThis(), data);
		}

		// Token: 0x0601968F RID: 104079
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataConnectivityFilter_GetColorRegions_11(HandleRef pThis);

		/// <summary>
		/// Turn on/off the coloring of connected regions.
		/// </summary>
		// Token: 0x06019690 RID: 104080 RVA: 0x00236554 File Offset: 0x00234754
		public virtual int GetColorRegions()
		{
			return vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_GetColorRegions_11(base.GetCppThis());
		}

		// Token: 0x06019691 RID: 104081
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataConnectivityFilter_GetExtractionMode_12(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x06019692 RID: 104082 RVA: 0x00236574 File Offset: 0x00234774
		public virtual int GetExtractionMode()
		{
			return vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_GetExtractionMode_12(base.GetCppThis());
		}

		// Token: 0x06019693 RID: 104083
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataConnectivityFilter_GetExtractionModeAsString_13(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x06019694 RID: 104084 RVA: 0x00236594 File Offset: 0x00234794
		public string GetExtractionModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_GetExtractionModeAsString_13(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06019695 RID: 104085
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataConnectivityFilter_GetExtractionModeMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x06019696 RID: 104086 RVA: 0x002365D0 File Offset: 0x002347D0
		public virtual int GetExtractionModeMaxValue()
		{
			return vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_GetExtractionModeMaxValue_14(base.GetCppThis());
		}

		// Token: 0x06019697 RID: 104087
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataConnectivityFilter_GetExtractionModeMinValue_15(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x06019698 RID: 104088 RVA: 0x002365F0 File Offset: 0x002347F0
		public virtual int GetExtractionModeMinValue()
		{
			return vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_GetExtractionModeMinValue_15(base.GetCppThis());
		}

		// Token: 0x06019699 RID: 104089
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataConnectivityFilter_GetFullScalarConnectivity_16(HandleRef pThis);

		/// <summary>
		/// Turn on/off the use of Fully connected scalar connectivity. This is off
		/// by default. The flag is used only if ScalarConnectivity is on. If
		/// FullScalarConnectivity is ON, all the cell's points must lie in the
		/// scalar range specified for the cell to qualify as being connected. If
		/// FullScalarConnectivity is OFF, any one of the cell's points may lie in
		/// the user specified scalar range for the cell to qualify as being
		/// connected.
		/// </summary>
		// Token: 0x0601969A RID: 104090 RVA: 0x00236610 File Offset: 0x00234810
		public virtual int GetFullScalarConnectivity()
		{
			return vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_GetFullScalarConnectivity_16(base.GetCppThis());
		}

		// Token: 0x0601969B RID: 104091
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataConnectivityFilter_GetMarkVisitedPointIds_17(HandleRef pThis);

		/// <summary>
		/// Specify whether to record input point ids that appear in the output connected
		/// components. It may be useful to extract the visited point ids for use by a
		/// downstream filter. Default is OFF.
		/// </summary>
		// Token: 0x0601969C RID: 104092 RVA: 0x00236630 File Offset: 0x00234830
		public virtual int GetMarkVisitedPointIds()
		{
			return vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_GetMarkVisitedPointIds_17(base.GetCppThis());
		}

		// Token: 0x0601969D RID: 104093
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataConnectivityFilter_GetNumberOfExtractedRegions_18(HandleRef pThis);

		/// <summary>
		/// Obtain the number of connected regions.
		/// </summary>
		// Token: 0x0601969E RID: 104094 RVA: 0x00236650 File Offset: 0x00234850
		public int GetNumberOfExtractedRegions()
		{
			return vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_GetNumberOfExtractedRegions_18(base.GetCppThis());
		}

		// Token: 0x0601969F RID: 104095
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataConnectivityFilter_GetNumberOfGenerationsFromBase_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060196A0 RID: 104096 RVA: 0x00236670 File Offset: 0x00234870
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_GetNumberOfGenerationsFromBase_19(base.GetCppThis(), type);
		}

		// Token: 0x060196A1 RID: 104097
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataConnectivityFilter_GetNumberOfGenerationsFromBaseType_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060196A2 RID: 104098 RVA: 0x00236690 File Offset: 0x00234890
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_GetNumberOfGenerationsFromBaseType_20(type);
		}

		// Token: 0x060196A3 RID: 104099
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataConnectivityFilter_GetOutputPointsPrecision_21(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x060196A4 RID: 104100 RVA: 0x002366AC File Offset: 0x002348AC
		public virtual int GetOutputPointsPrecision()
		{
			return vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_GetOutputPointsPrecision_21(base.GetCppThis());
		}

		// Token: 0x060196A5 RID: 104101
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataConnectivityFilter_GetRegionSizes_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Obtain the array containing the region sizes of the extracted
		/// regions
		/// </summary>
		// Token: 0x060196A6 RID: 104102 RVA: 0x002366CC File Offset: 0x002348CC
		public virtual vtkIdTypeArray GetRegionSizes()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_GetRegionSizes_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		// Token: 0x060196A7 RID: 104103
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataConnectivityFilter_GetScalarConnectivity_23(HandleRef pThis);

		/// <summary>
		/// Turn on/off connectivity based on scalar value. If on, cells are connected
		/// only if they share points AND one of the cells scalar values falls in the
		/// scalar range specified.
		/// </summary>
		// Token: 0x060196A8 RID: 104104 RVA: 0x0023673C File Offset: 0x0023493C
		public virtual int GetScalarConnectivity()
		{
			return vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_GetScalarConnectivity_23(base.GetCppThis());
		}

		// Token: 0x060196A9 RID: 104105
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataConnectivityFilter_GetScalarRange_24(HandleRef pThis);

		/// <summary>
		/// Set the scalar range to use to extract cells based on scalar connectivity.
		/// </summary>
		// Token: 0x060196AA RID: 104106 RVA: 0x0023675C File Offset: 0x0023495C
		public virtual double[] GetScalarRange()
		{
			IntPtr intPtr = vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_GetScalarRange_24(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060196AB RID: 104107
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_GetScalarRange_25(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Set the scalar range to use to extract cells based on scalar connectivity.
		/// </summary>
		// Token: 0x060196AC RID: 104108 RVA: 0x002367A4 File Offset: 0x002349A4
		public virtual void GetScalarRange(ref double _arg1, ref double _arg2)
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_GetScalarRange_25(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x060196AD RID: 104109
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_GetScalarRange_26(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the scalar range to use to extract cells based on scalar connectivity.
		/// </summary>
		// Token: 0x060196AE RID: 104110 RVA: 0x002367B5 File Offset: 0x002349B5
		public virtual void GetScalarRange(IntPtr _arg)
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_GetScalarRange_26(base.GetCppThis(), _arg);
		}

		// Token: 0x060196AF RID: 104111
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataConnectivityFilter_GetVisitedPointIds_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input point ids that appear in the output connected components. This is
		/// non-empty only if MarkVisitedPointIds has been set.
		/// </summary>
		// Token: 0x060196B0 RID: 104112 RVA: 0x002367C8 File Offset: 0x002349C8
		public virtual vtkIdList GetVisitedPointIds()
		{
			vtkIdList vtkIdList = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_GetVisitedPointIds_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdList = (vtkIdList)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdList.Register(null);
				}
			}
			return vtkIdList;
		}

		// Token: 0x060196B1 RID: 104113
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_InitializeSeedList_28(HandleRef pThis);

		/// <summary>
		/// Initialize list of point ids/cell ids used to seed regions.
		/// </summary>
		// Token: 0x060196B2 RID: 104114 RVA: 0x00236837 File Offset: 0x00234A37
		public void InitializeSeedList()
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_InitializeSeedList_28(base.GetCppThis());
		}

		// Token: 0x060196B3 RID: 104115
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_InitializeSpecifiedRegionList_29(HandleRef pThis);

		/// <summary>
		/// Initialize list of region ids to extract.
		/// </summary>
		// Token: 0x060196B4 RID: 104116 RVA: 0x00236846 File Offset: 0x00234A46
		public void InitializeSpecifiedRegionList()
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_InitializeSpecifiedRegionList_29(base.GetCppThis());
		}

		// Token: 0x060196B5 RID: 104117
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataConnectivityFilter_IsA_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060196B6 RID: 104118 RVA: 0x00236858 File Offset: 0x00234A58
		public override int IsA(string type)
		{
			return vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_IsA_30(base.GetCppThis(), type);
		}

		// Token: 0x060196B7 RID: 104119
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataConnectivityFilter_IsTypeOf_31([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060196B8 RID: 104120 RVA: 0x00236878 File Offset: 0x00234A78
		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_IsTypeOf_31(type);
		}

		// Token: 0x060196B9 RID: 104121
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_MarkVisitedPointIdsOff_32(HandleRef pThis);

		/// <summary>
		/// Specify whether to record input point ids that appear in the output connected
		/// components. It may be useful to extract the visited point ids for use by a
		/// downstream filter. Default is OFF.
		/// </summary>
		// Token: 0x060196BA RID: 104122 RVA: 0x00236892 File Offset: 0x00234A92
		public virtual void MarkVisitedPointIdsOff()
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_MarkVisitedPointIdsOff_32(base.GetCppThis());
		}

		// Token: 0x060196BB RID: 104123
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_MarkVisitedPointIdsOn_33(HandleRef pThis);

		/// <summary>
		/// Specify whether to record input point ids that appear in the output connected
		/// components. It may be useful to extract the visited point ids for use by a
		/// downstream filter. Default is OFF.
		/// </summary>
		// Token: 0x060196BC RID: 104124 RVA: 0x002368A1 File Offset: 0x00234AA1
		public virtual void MarkVisitedPointIdsOn()
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_MarkVisitedPointIdsOn_33(base.GetCppThis());
		}

		// Token: 0x060196BD RID: 104125
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataConnectivityFilter_NewInstance_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060196BE RID: 104126 RVA: 0x002368B0 File Offset: 0x00234AB0
		public new vtkPolyDataConnectivityFilter NewInstance()
		{
			vtkPolyDataConnectivityFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_NewInstance_35(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataConnectivityFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060196BF RID: 104127
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataConnectivityFilter_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060196C0 RID: 104128 RVA: 0x0023690C File Offset: 0x00234B0C
		public new static vtkPolyDataConnectivityFilter SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataConnectivityFilter vtkPolyDataConnectivityFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_SafeDownCast_36((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataConnectivityFilter = (vtkPolyDataConnectivityFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataConnectivityFilter.Register(null);
				}
			}
			return vtkPolyDataConnectivityFilter;
		}

		// Token: 0x060196C1 RID: 104129
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_ScalarConnectivityOff_37(HandleRef pThis);

		/// <summary>
		/// Turn on/off connectivity based on scalar value. If on, cells are connected
		/// only if they share points AND one of the cells scalar values falls in the
		/// scalar range specified.
		/// </summary>
		// Token: 0x060196C2 RID: 104130 RVA: 0x0023698B File Offset: 0x00234B8B
		public virtual void ScalarConnectivityOff()
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_ScalarConnectivityOff_37(base.GetCppThis());
		}

		// Token: 0x060196C3 RID: 104131
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_ScalarConnectivityOn_38(HandleRef pThis);

		/// <summary>
		/// Turn on/off connectivity based on scalar value. If on, cells are connected
		/// only if they share points AND one of the cells scalar values falls in the
		/// scalar range specified.
		/// </summary>
		// Token: 0x060196C4 RID: 104132 RVA: 0x0023699A File Offset: 0x00234B9A
		public virtual void ScalarConnectivityOn()
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_ScalarConnectivityOn_38(base.GetCppThis());
		}

		// Token: 0x060196C5 RID: 104133
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_SetClosestPoint_39(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Use to specify x-y-z point coordinates when extracting the region
		/// closest to a specified point.
		/// </summary>
		// Token: 0x060196C6 RID: 104134 RVA: 0x002369A9 File Offset: 0x00234BA9
		public virtual void SetClosestPoint(double _arg1, double _arg2, double _arg3)
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_SetClosestPoint_39(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060196C7 RID: 104135
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_SetClosestPoint_40(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Use to specify x-y-z point coordinates when extracting the region
		/// closest to a specified point.
		/// </summary>
		// Token: 0x060196C8 RID: 104136 RVA: 0x002369BB File Offset: 0x00234BBB
		public virtual void SetClosestPoint(IntPtr _arg)
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_SetClosestPoint_40(base.GetCppThis(), _arg);
		}

		// Token: 0x060196C9 RID: 104137
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_SetColorRegions_41(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the coloring of connected regions.
		/// </summary>
		// Token: 0x060196CA RID: 104138 RVA: 0x002369CB File Offset: 0x00234BCB
		public virtual void SetColorRegions(int _arg)
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_SetColorRegions_41(base.GetCppThis(), _arg);
		}

		// Token: 0x060196CB RID: 104139
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_SetExtractionMode_42(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x060196CC RID: 104140 RVA: 0x002369DB File Offset: 0x00234BDB
		public virtual void SetExtractionMode(int _arg)
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_SetExtractionMode_42(base.GetCppThis(), _arg);
		}

		// Token: 0x060196CD RID: 104141
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_SetExtractionModeToAllRegions_43(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x060196CE RID: 104142 RVA: 0x002369EB File Offset: 0x00234BEB
		public void SetExtractionModeToAllRegions()
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_SetExtractionModeToAllRegions_43(base.GetCppThis());
		}

		// Token: 0x060196CF RID: 104143
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_SetExtractionModeToCellSeededRegions_44(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x060196D0 RID: 104144 RVA: 0x002369FA File Offset: 0x00234BFA
		public void SetExtractionModeToCellSeededRegions()
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_SetExtractionModeToCellSeededRegions_44(base.GetCppThis());
		}

		// Token: 0x060196D1 RID: 104145
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_SetExtractionModeToClosestPointRegion_45(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x060196D2 RID: 104146 RVA: 0x00236A09 File Offset: 0x00234C09
		public void SetExtractionModeToClosestPointRegion()
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_SetExtractionModeToClosestPointRegion_45(base.GetCppThis());
		}

		// Token: 0x060196D3 RID: 104147
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_SetExtractionModeToLargestRegion_46(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x060196D4 RID: 104148 RVA: 0x00236A18 File Offset: 0x00234C18
		public void SetExtractionModeToLargestRegion()
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_SetExtractionModeToLargestRegion_46(base.GetCppThis());
		}

		// Token: 0x060196D5 RID: 104149
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_SetExtractionModeToPointSeededRegions_47(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x060196D6 RID: 104150 RVA: 0x00236A27 File Offset: 0x00234C27
		public void SetExtractionModeToPointSeededRegions()
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_SetExtractionModeToPointSeededRegions_47(base.GetCppThis());
		}

		// Token: 0x060196D7 RID: 104151
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_SetExtractionModeToSpecifiedRegions_48(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x060196D8 RID: 104152 RVA: 0x00236A36 File Offset: 0x00234C36
		public void SetExtractionModeToSpecifiedRegions()
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_SetExtractionModeToSpecifiedRegions_48(base.GetCppThis());
		}

		// Token: 0x060196D9 RID: 104153
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_SetFullScalarConnectivity_49(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the use of Fully connected scalar connectivity. This is off
		/// by default. The flag is used only if ScalarConnectivity is on. If
		/// FullScalarConnectivity is ON, all the cell's points must lie in the
		/// scalar range specified for the cell to qualify as being connected. If
		/// FullScalarConnectivity is OFF, any one of the cell's points may lie in
		/// the user specified scalar range for the cell to qualify as being
		/// connected.
		/// </summary>
		// Token: 0x060196DA RID: 104154 RVA: 0x00236A45 File Offset: 0x00234C45
		public virtual void SetFullScalarConnectivity(int _arg)
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_SetFullScalarConnectivity_49(base.GetCppThis(), _arg);
		}

		// Token: 0x060196DB RID: 104155
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_SetMarkVisitedPointIds_50(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether to record input point ids that appear in the output connected
		/// components. It may be useful to extract the visited point ids for use by a
		/// downstream filter. Default is OFF.
		/// </summary>
		// Token: 0x060196DC RID: 104156 RVA: 0x00236A55 File Offset: 0x00234C55
		public virtual void SetMarkVisitedPointIds(int _arg)
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_SetMarkVisitedPointIds_50(base.GetCppThis(), _arg);
		}

		// Token: 0x060196DD RID: 104157
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_SetOutputPointsPrecision_51(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x060196DE RID: 104158 RVA: 0x00236A65 File Offset: 0x00234C65
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_SetOutputPointsPrecision_51(base.GetCppThis(), _arg);
		}

		// Token: 0x060196DF RID: 104159
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_SetScalarConnectivity_52(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off connectivity based on scalar value. If on, cells are connected
		/// only if they share points AND one of the cells scalar values falls in the
		/// scalar range specified.
		/// </summary>
		// Token: 0x060196E0 RID: 104160 RVA: 0x00236A75 File Offset: 0x00234C75
		public virtual void SetScalarConnectivity(int _arg)
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_SetScalarConnectivity_52(base.GetCppThis(), _arg);
		}

		// Token: 0x060196E1 RID: 104161
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_SetScalarRange_53(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Set the scalar range to use to extract cells based on scalar connectivity.
		/// </summary>
		// Token: 0x060196E2 RID: 104162 RVA: 0x00236A85 File Offset: 0x00234C85
		public virtual void SetScalarRange(double _arg1, double _arg2)
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_SetScalarRange_53(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x060196E3 RID: 104163
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataConnectivityFilter_SetScalarRange_54(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the scalar range to use to extract cells based on scalar connectivity.
		/// </summary>
		// Token: 0x060196E4 RID: 104164 RVA: 0x00236A96 File Offset: 0x00234C96
		public void SetScalarRange(IntPtr _arg)
		{
			vtkPolyDataConnectivityFilter.vtkPolyDataConnectivityFilter_SetScalarRange_54(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BCF RID: 7119
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataConnectivityFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BD0 RID: 7120
		public new static readonly string MRClassNameKey = "class vtkPolyDataConnectivityFilter";
	}
}
