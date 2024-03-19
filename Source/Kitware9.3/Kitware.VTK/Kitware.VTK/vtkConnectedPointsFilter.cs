using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkConnectedPointsFilter
	/// </summary>
	/// <remarks>
	///    extract / segment points based on geometric connectivity
	///
	/// vtkConnectedPointsFilter is a filter that extracts and/or segments points
	/// from a point cloud based on geometric distance measures (e.g., proximity,
	/// normal alignments, etc.) and optional measures such as scalar range. The
	/// default operation is to segment the points into "connected" regions where
	/// the connection is determined by an appropriate distance measure. Each
	/// region is given a region id. Optionally, the filter can output the largest
	/// connected region of points; a particular region (via id specification);
	/// those regions that are seeded using a list of input point ids; or the
	/// region of points closest to a specified position.
	///
	/// The key parameter of this filter is the radius defining a sphere around
	/// each point which defines a local neighborhood: any other points in the
	/// local neighborhood are assumed connected to the point. Note that the
	/// radius is defined in absolute terms.
	///
	/// Other parameters are used to further qualify what it means to be a
	/// neighboring point. For example, scalar range and/or point normals can be
	/// used to further constrain the neighborhood. Also the extraction mode
	/// defines how the filter operates. By default, all regions are extracted but
	/// it is possible to extract particular regions; the region closest to a seed
	/// point; seeded regions; or the largest region found while processing. By
	/// default, all regions are extracted.
	///
	/// On output, all points are labeled with a region number. However note that
	/// the number of input and output points may not be the same: if not
	/// extracting all regions then the output size may be less than the input
	/// size.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPolyDataConnectivityFilter vtkConnectivityFilter
	/// </seealso>
	// Token: 0x02000434 RID: 1076
	public class vtkConnectedPointsFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C944 RID: 51524 RVA: 0x00118508 File Offset: 0x00116708
		static vtkConnectedPointsFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkConnectedPointsFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkConnectedPointsFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C945 RID: 51525 RVA: 0x00118530 File Offset: 0x00116730
		public vtkConnectedPointsFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C946 RID: 51526
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConnectedPointsFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with default extraction mode to extract the largest region.
		/// </summary>
		// Token: 0x0600C947 RID: 51527 RVA: 0x00118540 File Offset: 0x00116740
		public new static vtkConnectedPointsFilter New()
		{
			vtkConnectedPointsFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConnectedPointsFilter.vtkConnectedPointsFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConnectedPointsFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with default extraction mode to extract the largest region.
		/// </summary>
		// Token: 0x0600C948 RID: 51528 RVA: 0x00118594 File Offset: 0x00116794
		public vtkConnectedPointsFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkConnectedPointsFilter.vtkConnectedPointsFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C949 RID: 51529 RVA: 0x001185D8 File Offset: 0x001167D8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C94A RID: 51530
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectedPointsFilter_AddSeed_01(HandleRef pThis, long id);

		/// <summary>
		/// Add a non-negative point seed id. Note: ids are 0-offset.
		/// </summary>
		// Token: 0x0600C94B RID: 51531 RVA: 0x001185E3 File Offset: 0x001167E3
		public void AddSeed(long id)
		{
			vtkConnectedPointsFilter.vtkConnectedPointsFilter_AddSeed_01(base.GetCppThis(), id);
		}

		// Token: 0x0600C94C RID: 51532
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectedPointsFilter_AddSpecifiedRegion_02(HandleRef pThis, long id);

		/// <summary>
		/// Add a non-negative region id to extract. Note: ids are 0-offset.
		/// </summary>
		// Token: 0x0600C94D RID: 51533 RVA: 0x001185F3 File Offset: 0x001167F3
		public void AddSpecifiedRegion(long id)
		{
			vtkConnectedPointsFilter.vtkConnectedPointsFilter_AddSpecifiedRegion_02(base.GetCppThis(), id);
		}

		// Token: 0x0600C94E RID: 51534
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectedPointsFilter_AlignedNormalsOff_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off connectivity based on point normal consistency. If on, and
		/// point normals are defined, points are connected only if they satisfy
		/// other criterion (e.g., geometric proximity, scalar connectivity, etc.)
		/// AND the angle between normals is no greater than NormalAngle;
		/// </summary>
		// Token: 0x0600C94F RID: 51535 RVA: 0x00118603 File Offset: 0x00116803
		public virtual void AlignedNormalsOff()
		{
			vtkConnectedPointsFilter.vtkConnectedPointsFilter_AlignedNormalsOff_03(base.GetCppThis());
		}

		// Token: 0x0600C950 RID: 51536
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectedPointsFilter_AlignedNormalsOn_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off connectivity based on point normal consistency. If on, and
		/// point normals are defined, points are connected only if they satisfy
		/// other criterion (e.g., geometric proximity, scalar connectivity, etc.)
		/// AND the angle between normals is no greater than NormalAngle;
		/// </summary>
		// Token: 0x0600C951 RID: 51537 RVA: 0x00118612 File Offset: 0x00116812
		public virtual void AlignedNormalsOn()
		{
			vtkConnectedPointsFilter.vtkConnectedPointsFilter_AlignedNormalsOn_04(base.GetCppThis());
		}

		// Token: 0x0600C952 RID: 51538
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectedPointsFilter_DeleteSeed_05(HandleRef pThis, long id);

		/// <summary>
		/// Delete a point seed id. Note: ids are 0-offset.
		/// </summary>
		// Token: 0x0600C953 RID: 51539 RVA: 0x00118621 File Offset: 0x00116821
		public void DeleteSeed(long id)
		{
			vtkConnectedPointsFilter.vtkConnectedPointsFilter_DeleteSeed_05(base.GetCppThis(), id);
		}

		// Token: 0x0600C954 RID: 51540
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectedPointsFilter_DeleteSpecifiedRegion_06(HandleRef pThis, long id);

		/// <summary>
		/// Delete a region id to extract. Note: ids are 0-offset.
		/// </summary>
		// Token: 0x0600C955 RID: 51541 RVA: 0x00118631 File Offset: 0x00116831
		public void DeleteSpecifiedRegion(long id)
		{
			vtkConnectedPointsFilter.vtkConnectedPointsFilter_DeleteSpecifiedRegion_06(base.GetCppThis(), id);
		}

		// Token: 0x0600C956 RID: 51542
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConnectedPointsFilter_GetAlignedNormals_07(HandleRef pThis);

		/// <summary>
		/// Turn on/off connectivity based on point normal consistency. If on, and
		/// point normals are defined, points are connected only if they satisfy
		/// other criterion (e.g., geometric proximity, scalar connectivity, etc.)
		/// AND the angle between normals is no greater than NormalAngle;
		/// </summary>
		// Token: 0x0600C957 RID: 51543 RVA: 0x00118644 File Offset: 0x00116844
		public virtual int GetAlignedNormals()
		{
			return vtkConnectedPointsFilter.vtkConnectedPointsFilter_GetAlignedNormals_07(base.GetCppThis());
		}

		// Token: 0x0600C958 RID: 51544
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConnectedPointsFilter_GetClosestPoint_08(HandleRef pThis);

		/// <summary>
		/// Use to specify x-y-z point coordinates when extracting the region
		/// closest to a specified point.
		/// </summary>
		// Token: 0x0600C959 RID: 51545 RVA: 0x00118664 File Offset: 0x00116864
		public virtual double[] GetClosestPoint()
		{
			IntPtr intPtr = vtkConnectedPointsFilter.vtkConnectedPointsFilter_GetClosestPoint_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600C95A RID: 51546
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectedPointsFilter_GetClosestPoint_09(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Use to specify x-y-z point coordinates when extracting the region
		/// closest to a specified point.
		/// </summary>
		// Token: 0x0600C95B RID: 51547 RVA: 0x001186AC File Offset: 0x001168AC
		public virtual void GetClosestPoint(IntPtr data)
		{
			vtkConnectedPointsFilter.vtkConnectedPointsFilter_GetClosestPoint_09(base.GetCppThis(), data);
		}

		// Token: 0x0600C95C RID: 51548
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConnectedPointsFilter_GetExtractionMode_10(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected regions.
		/// </summary>
		// Token: 0x0600C95D RID: 51549 RVA: 0x001186BC File Offset: 0x001168BC
		public virtual int GetExtractionMode()
		{
			return vtkConnectedPointsFilter.vtkConnectedPointsFilter_GetExtractionMode_10(base.GetCppThis());
		}

		// Token: 0x0600C95E RID: 51550
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConnectedPointsFilter_GetExtractionModeAsString_11(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected regions.
		/// </summary>
		// Token: 0x0600C95F RID: 51551 RVA: 0x001186DC File Offset: 0x001168DC
		public string GetExtractionModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkConnectedPointsFilter.vtkConnectedPointsFilter_GetExtractionModeAsString_11(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600C960 RID: 51552
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConnectedPointsFilter_GetExtractionModeMaxValue_12(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected regions.
		/// </summary>
		// Token: 0x0600C961 RID: 51553 RVA: 0x00118718 File Offset: 0x00116918
		public virtual int GetExtractionModeMaxValue()
		{
			return vtkConnectedPointsFilter.vtkConnectedPointsFilter_GetExtractionModeMaxValue_12(base.GetCppThis());
		}

		// Token: 0x0600C962 RID: 51554
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConnectedPointsFilter_GetExtractionModeMinValue_13(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected regions.
		/// </summary>
		// Token: 0x0600C963 RID: 51555 RVA: 0x00118738 File Offset: 0x00116938
		public virtual int GetExtractionModeMinValue()
		{
			return vtkConnectedPointsFilter.vtkConnectedPointsFilter_GetExtractionModeMinValue_13(base.GetCppThis());
		}

		// Token: 0x0600C964 RID: 51556
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConnectedPointsFilter_GetLocator_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a point locator. By default a vtkStaticPointLocator is
		/// used. The locator performs efficient searches to locate points
		/// around a sample point.
		/// </summary>
		// Token: 0x0600C965 RID: 51557 RVA: 0x00118758 File Offset: 0x00116958
		public virtual vtkAbstractPointLocator GetLocator()
		{
			vtkAbstractPointLocator vtkAbstractPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConnectedPointsFilter.vtkConnectedPointsFilter_GetLocator_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractPointLocator = (vtkAbstractPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractPointLocator.Register(null);
				}
			}
			return vtkAbstractPointLocator;
		}

		// Token: 0x0600C966 RID: 51558
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkConnectedPointsFilter_GetNormalAngle_15(HandleRef pThis);

		/// <summary>
		/// Specify a threshold for normal angles. If AlignedNormalsOn is set, then
		/// points are connected if the angle between their normals is within this
		/// angle threshold (expressed in degrees).
		/// </summary>
		// Token: 0x0600C967 RID: 51559 RVA: 0x001187C8 File Offset: 0x001169C8
		public virtual double GetNormalAngle()
		{
			return vtkConnectedPointsFilter.vtkConnectedPointsFilter_GetNormalAngle_15(base.GetCppThis());
		}

		// Token: 0x0600C968 RID: 51560
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkConnectedPointsFilter_GetNormalAngleMaxValue_16(HandleRef pThis);

		/// <summary>
		/// Specify a threshold for normal angles. If AlignedNormalsOn is set, then
		/// points are connected if the angle between their normals is within this
		/// angle threshold (expressed in degrees).
		/// </summary>
		// Token: 0x0600C969 RID: 51561 RVA: 0x001187E8 File Offset: 0x001169E8
		public virtual double GetNormalAngleMaxValue()
		{
			return vtkConnectedPointsFilter.vtkConnectedPointsFilter_GetNormalAngleMaxValue_16(base.GetCppThis());
		}

		// Token: 0x0600C96A RID: 51562
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkConnectedPointsFilter_GetNormalAngleMinValue_17(HandleRef pThis);

		/// <summary>
		/// Specify a threshold for normal angles. If AlignedNormalsOn is set, then
		/// points are connected if the angle between their normals is within this
		/// angle threshold (expressed in degrees).
		/// </summary>
		// Token: 0x0600C96B RID: 51563 RVA: 0x00118808 File Offset: 0x00116A08
		public virtual double GetNormalAngleMinValue()
		{
			return vtkConnectedPointsFilter.vtkConnectedPointsFilter_GetNormalAngleMinValue_17(base.GetCppThis());
		}

		// Token: 0x0600C96C RID: 51564
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConnectedPointsFilter_GetNumberOfExtractedRegions_18(HandleRef pThis);

		/// <summary>
		/// Obtain the number of connected regions. The return value is valid only
		/// after the filter has executed.
		/// </summary>
		// Token: 0x0600C96D RID: 51565 RVA: 0x00118828 File Offset: 0x00116A28
		public int GetNumberOfExtractedRegions()
		{
			return vtkConnectedPointsFilter.vtkConnectedPointsFilter_GetNumberOfExtractedRegions_18(base.GetCppThis());
		}

		// Token: 0x0600C96E RID: 51566
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkConnectedPointsFilter_GetNumberOfGenerationsFromBase_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C96F RID: 51567 RVA: 0x00118848 File Offset: 0x00116A48
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkConnectedPointsFilter.vtkConnectedPointsFilter_GetNumberOfGenerationsFromBase_19(base.GetCppThis(), type);
		}

		// Token: 0x0600C970 RID: 51568
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkConnectedPointsFilter_GetNumberOfGenerationsFromBaseType_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C971 RID: 51569 RVA: 0x00118868 File Offset: 0x00116A68
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkConnectedPointsFilter.vtkConnectedPointsFilter_GetNumberOfGenerationsFromBaseType_20(type);
		}

		// Token: 0x0600C972 RID: 51570
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkConnectedPointsFilter_GetRadius_21(HandleRef pThis);

		/// <summary>
		/// Set / get the radius variable specifying a local sphere used to define
		/// local point neighborhood.
		/// </summary>
		// Token: 0x0600C973 RID: 51571 RVA: 0x00118884 File Offset: 0x00116A84
		public virtual double GetRadius()
		{
			return vtkConnectedPointsFilter.vtkConnectedPointsFilter_GetRadius_21(base.GetCppThis());
		}

		// Token: 0x0600C974 RID: 51572
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkConnectedPointsFilter_GetRadiusMaxValue_22(HandleRef pThis);

		/// <summary>
		/// Set / get the radius variable specifying a local sphere used to define
		/// local point neighborhood.
		/// </summary>
		// Token: 0x0600C975 RID: 51573 RVA: 0x001188A4 File Offset: 0x00116AA4
		public virtual double GetRadiusMaxValue()
		{
			return vtkConnectedPointsFilter.vtkConnectedPointsFilter_GetRadiusMaxValue_22(base.GetCppThis());
		}

		// Token: 0x0600C976 RID: 51574
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkConnectedPointsFilter_GetRadiusMinValue_23(HandleRef pThis);

		/// <summary>
		/// Set / get the radius variable specifying a local sphere used to define
		/// local point neighborhood.
		/// </summary>
		// Token: 0x0600C977 RID: 51575 RVA: 0x001188C4 File Offset: 0x00116AC4
		public virtual double GetRadiusMinValue()
		{
			return vtkConnectedPointsFilter.vtkConnectedPointsFilter_GetRadiusMinValue_23(base.GetCppThis());
		}

		// Token: 0x0600C978 RID: 51576
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConnectedPointsFilter_GetScalarConnectivity_24(HandleRef pThis);

		/// <summary>
		/// Turn on/off connectivity based on scalar value. If on, points are
		/// connected only if they satisfy the various geometric criterion AND one
		/// of the points scalar values falls in the scalar range specified.
		/// </summary>
		// Token: 0x0600C979 RID: 51577 RVA: 0x001188E4 File Offset: 0x00116AE4
		public virtual int GetScalarConnectivity()
		{
			return vtkConnectedPointsFilter.vtkConnectedPointsFilter_GetScalarConnectivity_24(base.GetCppThis());
		}

		// Token: 0x0600C97A RID: 51578
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConnectedPointsFilter_GetScalarRange_25(HandleRef pThis);

		/// <summary>
		/// Set the scalar range to use to extract points based on scalar connectivity.
		/// </summary>
		// Token: 0x0600C97B RID: 51579 RVA: 0x00118904 File Offset: 0x00116B04
		public virtual double[] GetScalarRange()
		{
			IntPtr intPtr = vtkConnectedPointsFilter.vtkConnectedPointsFilter_GetScalarRange_25(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600C97C RID: 51580
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectedPointsFilter_GetScalarRange_26(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Set the scalar range to use to extract points based on scalar connectivity.
		/// </summary>
		// Token: 0x0600C97D RID: 51581 RVA: 0x0011894C File Offset: 0x00116B4C
		public virtual void GetScalarRange(ref double _arg1, ref double _arg2)
		{
			vtkConnectedPointsFilter.vtkConnectedPointsFilter_GetScalarRange_26(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600C97E RID: 51582
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectedPointsFilter_GetScalarRange_27(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the scalar range to use to extract points based on scalar connectivity.
		/// </summary>
		// Token: 0x0600C97F RID: 51583 RVA: 0x0011895D File Offset: 0x00116B5D
		public virtual void GetScalarRange(IntPtr _arg)
		{
			vtkConnectedPointsFilter.vtkConnectedPointsFilter_GetScalarRange_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C980 RID: 51584
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectedPointsFilter_InitializeSeedList_28(HandleRef pThis);

		/// <summary>
		/// Initialize list of point ids ids used to seed regions.
		/// </summary>
		// Token: 0x0600C981 RID: 51585 RVA: 0x0011896D File Offset: 0x00116B6D
		public void InitializeSeedList()
		{
			vtkConnectedPointsFilter.vtkConnectedPointsFilter_InitializeSeedList_28(base.GetCppThis());
		}

		// Token: 0x0600C982 RID: 51586
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectedPointsFilter_InitializeSpecifiedRegionList_29(HandleRef pThis);

		/// <summary>
		/// Initialize list of region ids to extract.
		/// </summary>
		// Token: 0x0600C983 RID: 51587 RVA: 0x0011897C File Offset: 0x00116B7C
		public void InitializeSpecifiedRegionList()
		{
			vtkConnectedPointsFilter.vtkConnectedPointsFilter_InitializeSpecifiedRegionList_29(base.GetCppThis());
		}

		// Token: 0x0600C984 RID: 51588
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConnectedPointsFilter_IsA_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C985 RID: 51589 RVA: 0x0011898C File Offset: 0x00116B8C
		public override int IsA(string type)
		{
			return vtkConnectedPointsFilter.vtkConnectedPointsFilter_IsA_30(base.GetCppThis(), type);
		}

		// Token: 0x0600C986 RID: 51590
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConnectedPointsFilter_IsTypeOf_31([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C987 RID: 51591 RVA: 0x001189AC File Offset: 0x00116BAC
		public new static int IsTypeOf(string type)
		{
			return vtkConnectedPointsFilter.vtkConnectedPointsFilter_IsTypeOf_31(type);
		}

		// Token: 0x0600C988 RID: 51592
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConnectedPointsFilter_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C989 RID: 51593 RVA: 0x001189C8 File Offset: 0x00116BC8
		public new vtkConnectedPointsFilter NewInstance()
		{
			vtkConnectedPointsFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConnectedPointsFilter.vtkConnectedPointsFilter_NewInstance_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConnectedPointsFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C98A RID: 51594
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConnectedPointsFilter_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C98B RID: 51595 RVA: 0x00118A24 File Offset: 0x00116C24
		public new static vtkConnectedPointsFilter SafeDownCast(vtkObjectBase o)
		{
			vtkConnectedPointsFilter vtkConnectedPointsFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConnectedPointsFilter.vtkConnectedPointsFilter_SafeDownCast_34((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkConnectedPointsFilter = (vtkConnectedPointsFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkConnectedPointsFilter.Register(null);
				}
			}
			return vtkConnectedPointsFilter;
		}

		// Token: 0x0600C98C RID: 51596
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectedPointsFilter_ScalarConnectivityOff_35(HandleRef pThis);

		/// <summary>
		/// Turn on/off connectivity based on scalar value. If on, points are
		/// connected only if they satisfy the various geometric criterion AND one
		/// of the points scalar values falls in the scalar range specified.
		/// </summary>
		// Token: 0x0600C98D RID: 51597 RVA: 0x00118AA3 File Offset: 0x00116CA3
		public virtual void ScalarConnectivityOff()
		{
			vtkConnectedPointsFilter.vtkConnectedPointsFilter_ScalarConnectivityOff_35(base.GetCppThis());
		}

		// Token: 0x0600C98E RID: 51598
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectedPointsFilter_ScalarConnectivityOn_36(HandleRef pThis);

		/// <summary>
		/// Turn on/off connectivity based on scalar value. If on, points are
		/// connected only if they satisfy the various geometric criterion AND one
		/// of the points scalar values falls in the scalar range specified.
		/// </summary>
		// Token: 0x0600C98F RID: 51599 RVA: 0x00118AB2 File Offset: 0x00116CB2
		public virtual void ScalarConnectivityOn()
		{
			vtkConnectedPointsFilter.vtkConnectedPointsFilter_ScalarConnectivityOn_36(base.GetCppThis());
		}

		// Token: 0x0600C990 RID: 51600
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectedPointsFilter_SetAlignedNormals_37(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off connectivity based on point normal consistency. If on, and
		/// point normals are defined, points are connected only if they satisfy
		/// other criterion (e.g., geometric proximity, scalar connectivity, etc.)
		/// AND the angle between normals is no greater than NormalAngle;
		/// </summary>
		// Token: 0x0600C991 RID: 51601 RVA: 0x00118AC1 File Offset: 0x00116CC1
		public virtual void SetAlignedNormals(int _arg)
		{
			vtkConnectedPointsFilter.vtkConnectedPointsFilter_SetAlignedNormals_37(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C992 RID: 51602
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectedPointsFilter_SetClosestPoint_38(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Use to specify x-y-z point coordinates when extracting the region
		/// closest to a specified point.
		/// </summary>
		// Token: 0x0600C993 RID: 51603 RVA: 0x00118AD1 File Offset: 0x00116CD1
		public virtual void SetClosestPoint(double _arg1, double _arg2, double _arg3)
		{
			vtkConnectedPointsFilter.vtkConnectedPointsFilter_SetClosestPoint_38(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600C994 RID: 51604
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectedPointsFilter_SetClosestPoint_39(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Use to specify x-y-z point coordinates when extracting the region
		/// closest to a specified point.
		/// </summary>
		// Token: 0x0600C995 RID: 51605 RVA: 0x00118AE3 File Offset: 0x00116CE3
		public virtual void SetClosestPoint(IntPtr _arg)
		{
			vtkConnectedPointsFilter.vtkConnectedPointsFilter_SetClosestPoint_39(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C996 RID: 51606
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectedPointsFilter_SetExtractionMode_40(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the extraction of connected regions.
		/// </summary>
		// Token: 0x0600C997 RID: 51607 RVA: 0x00118AF3 File Offset: 0x00116CF3
		public virtual void SetExtractionMode(int _arg)
		{
			vtkConnectedPointsFilter.vtkConnectedPointsFilter_SetExtractionMode_40(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C998 RID: 51608
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectedPointsFilter_SetExtractionModeToAllRegions_41(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected regions.
		/// </summary>
		// Token: 0x0600C999 RID: 51609 RVA: 0x00118B03 File Offset: 0x00116D03
		public void SetExtractionModeToAllRegions()
		{
			vtkConnectedPointsFilter.vtkConnectedPointsFilter_SetExtractionModeToAllRegions_41(base.GetCppThis());
		}

		// Token: 0x0600C99A RID: 51610
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectedPointsFilter_SetExtractionModeToClosestPointRegion_42(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected regions.
		/// </summary>
		// Token: 0x0600C99B RID: 51611 RVA: 0x00118B12 File Offset: 0x00116D12
		public void SetExtractionModeToClosestPointRegion()
		{
			vtkConnectedPointsFilter.vtkConnectedPointsFilter_SetExtractionModeToClosestPointRegion_42(base.GetCppThis());
		}

		// Token: 0x0600C99C RID: 51612
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectedPointsFilter_SetExtractionModeToLargestRegion_43(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected regions.
		/// </summary>
		// Token: 0x0600C99D RID: 51613 RVA: 0x00118B21 File Offset: 0x00116D21
		public void SetExtractionModeToLargestRegion()
		{
			vtkConnectedPointsFilter.vtkConnectedPointsFilter_SetExtractionModeToLargestRegion_43(base.GetCppThis());
		}

		// Token: 0x0600C99E RID: 51614
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectedPointsFilter_SetExtractionModeToPointSeededRegions_44(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected regions.
		/// </summary>
		// Token: 0x0600C99F RID: 51615 RVA: 0x00118B30 File Offset: 0x00116D30
		public void SetExtractionModeToPointSeededRegions()
		{
			vtkConnectedPointsFilter.vtkConnectedPointsFilter_SetExtractionModeToPointSeededRegions_44(base.GetCppThis());
		}

		// Token: 0x0600C9A0 RID: 51616
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectedPointsFilter_SetExtractionModeToSpecifiedRegions_45(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected regions.
		/// </summary>
		// Token: 0x0600C9A1 RID: 51617 RVA: 0x00118B3F File Offset: 0x00116D3F
		public void SetExtractionModeToSpecifiedRegions()
		{
			vtkConnectedPointsFilter.vtkConnectedPointsFilter_SetExtractionModeToSpecifiedRegions_45(base.GetCppThis());
		}

		// Token: 0x0600C9A2 RID: 51618
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectedPointsFilter_SetLocator_46(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Specify a point locator. By default a vtkStaticPointLocator is
		/// used. The locator performs efficient searches to locate points
		/// around a sample point.
		/// </summary>
		// Token: 0x0600C9A3 RID: 51619 RVA: 0x00118B50 File Offset: 0x00116D50
		public void SetLocator(vtkAbstractPointLocator locator)
		{
			vtkConnectedPointsFilter.vtkConnectedPointsFilter_SetLocator_46(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0600C9A4 RID: 51620
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectedPointsFilter_SetNormalAngle_47(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify a threshold for normal angles. If AlignedNormalsOn is set, then
		/// points are connected if the angle between their normals is within this
		/// angle threshold (expressed in degrees).
		/// </summary>
		// Token: 0x0600C9A5 RID: 51621 RVA: 0x00118B7F File Offset: 0x00116D7F
		public virtual void SetNormalAngle(double _arg)
		{
			vtkConnectedPointsFilter.vtkConnectedPointsFilter_SetNormalAngle_47(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C9A6 RID: 51622
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectedPointsFilter_SetRadius_48(HandleRef pThis, double _arg);

		/// <summary>
		/// Set / get the radius variable specifying a local sphere used to define
		/// local point neighborhood.
		/// </summary>
		// Token: 0x0600C9A7 RID: 51623 RVA: 0x00118B8F File Offset: 0x00116D8F
		public virtual void SetRadius(double _arg)
		{
			vtkConnectedPointsFilter.vtkConnectedPointsFilter_SetRadius_48(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C9A8 RID: 51624
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectedPointsFilter_SetScalarConnectivity_49(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off connectivity based on scalar value. If on, points are
		/// connected only if they satisfy the various geometric criterion AND one
		/// of the points scalar values falls in the scalar range specified.
		/// </summary>
		// Token: 0x0600C9A9 RID: 51625 RVA: 0x00118B9F File Offset: 0x00116D9F
		public virtual void SetScalarConnectivity(int _arg)
		{
			vtkConnectedPointsFilter.vtkConnectedPointsFilter_SetScalarConnectivity_49(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C9AA RID: 51626
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectedPointsFilter_SetScalarRange_50(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Set the scalar range to use to extract points based on scalar connectivity.
		/// </summary>
		// Token: 0x0600C9AB RID: 51627 RVA: 0x00118BAF File Offset: 0x00116DAF
		public virtual void SetScalarRange(double _arg1, double _arg2)
		{
			vtkConnectedPointsFilter.vtkConnectedPointsFilter_SetScalarRange_50(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600C9AC RID: 51628
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConnectedPointsFilter_SetScalarRange_51(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the scalar range to use to extract points based on scalar connectivity.
		/// </summary>
		// Token: 0x0600C9AD RID: 51629 RVA: 0x00118BC0 File Offset: 0x00116DC0
		public void SetScalarRange(IntPtr _arg)
		{
			vtkConnectedPointsFilter.vtkConnectedPointsFilter_SetScalarRange_51(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EF1 RID: 3825
		public new const string MRFullTypeName = "Kitware.VTK.vtkConnectedPointsFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EF2 RID: 3826
		public new static readonly string MRClassNameKey = "class vtkConnectedPointsFilter";
	}
}
