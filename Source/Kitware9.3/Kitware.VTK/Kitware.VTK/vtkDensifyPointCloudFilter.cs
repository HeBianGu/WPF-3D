using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDensifyPointCloudFilter
	/// </summary>
	/// <remarks>
	///    add points to a point cloud to make it denser
	///
	/// vtkDensifyPointCloudFilter adds new points to an input point cloud. The
	/// new points are created in such a way that all points in any local
	/// neighborhood are within a target distance of one another. Optionally,
	/// attribute data can be interpolated from the input point cloud as well.
	///
	/// A high-level overview of the algorithm is as follows. For each input
	/// point, the distance to all points in its neighborhood is computed. If any
	/// of its neighbors is further than the target distance, the edge connecting
	/// the point and its neighbor is bisected and a new point is inserted at the
	/// bisection point (optionally the attribute data is interpolated as well). A
	/// single pass is completed once all the input points are visited. Then the
	/// process repeats to the limit of the maximum number of iterations.
	///
	/// @warning
	/// This class can generate a lot of points very quickly. The maximum number
	/// of iterations is by default set to =1.0 for this reason. Increase the
	/// number of iterations very carefully. Also the MaximumNumberOfPoints
	/// data member can be set to limit the explosion of points. It is also
	/// recommended that a N closest neighborhood is used.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkVoxelGridFilter vtkEuclideanClusterExtraction vtkBoundedPointSource
	/// </seealso>
	// Token: 0x02000437 RID: 1079
	public class vtkDensifyPointCloudFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C9C4 RID: 51652 RVA: 0x00118E2F File Offset: 0x0011702F
		static vtkDensifyPointCloudFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDensifyPointCloudFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDensifyPointCloudFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C9C5 RID: 51653 RVA: 0x00118E57 File Offset: 0x00117057
		public vtkDensifyPointCloudFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C9C6 RID: 51654
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDensifyPointCloudFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600C9C7 RID: 51655 RVA: 0x00118E68 File Offset: 0x00117068
		public new static vtkDensifyPointCloudFilter New()
		{
			vtkDensifyPointCloudFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDensifyPointCloudFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600C9C8 RID: 51656 RVA: 0x00118EBC File Offset: 0x001170BC
		public vtkDensifyPointCloudFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C9C9 RID: 51657 RVA: 0x00118F00 File Offset: 0x00117100
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C9CA RID: 51658
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDensifyPointCloudFilter_GetInterpolateAttributeData_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off the interpolation of attribute data from the input point
		/// cloud to new, added points.
		/// </summary>
		// Token: 0x0600C9CB RID: 51659 RVA: 0x00118F0C File Offset: 0x0011710C
		public virtual bool GetInterpolateAttributeData()
		{
			return vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_GetInterpolateAttributeData_01(base.GetCppThis()) != 0;
		}

		// Token: 0x0600C9CC RID: 51660
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDensifyPointCloudFilter_GetMaximumNumberOfIterations_02(HandleRef pThis);

		/// <summary>
		/// The maximum number of iterations to run. By default the maximum is
		/// one.
		/// </summary>
		// Token: 0x0600C9CD RID: 51661 RVA: 0x00118F34 File Offset: 0x00117134
		public virtual int GetMaximumNumberOfIterations()
		{
			return vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_GetMaximumNumberOfIterations_02(base.GetCppThis());
		}

		// Token: 0x0600C9CE RID: 51662
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDensifyPointCloudFilter_GetMaximumNumberOfIterationsMaxValue_03(HandleRef pThis);

		/// <summary>
		/// The maximum number of iterations to run. By default the maximum is
		/// one.
		/// </summary>
		// Token: 0x0600C9CF RID: 51663 RVA: 0x00118F54 File Offset: 0x00117154
		public virtual int GetMaximumNumberOfIterationsMaxValue()
		{
			return vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_GetMaximumNumberOfIterationsMaxValue_03(base.GetCppThis());
		}

		// Token: 0x0600C9D0 RID: 51664
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDensifyPointCloudFilter_GetMaximumNumberOfIterationsMinValue_04(HandleRef pThis);

		/// <summary>
		/// The maximum number of iterations to run. By default the maximum is
		/// one.
		/// </summary>
		// Token: 0x0600C9D1 RID: 51665 RVA: 0x00118F74 File Offset: 0x00117174
		public virtual int GetMaximumNumberOfIterationsMinValue()
		{
			return vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_GetMaximumNumberOfIterationsMinValue_04(base.GetCppThis());
		}

		// Token: 0x0600C9D2 RID: 51666
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDensifyPointCloudFilter_GetMaximumNumberOfPoints_05(HandleRef pThis);

		/// <summary>
		/// Set a limit on the maximum number of points that can be created. This
		/// data member serves as a crude barrier to explosive point creation; it does
		/// not guarantee that precisely these many points will be created. Once this
		/// limit is hit, it may result in premature termination of the
		/// algorithm. Consider it a pressure relief valve.
		/// </summary>
		// Token: 0x0600C9D3 RID: 51667 RVA: 0x00118F94 File Offset: 0x00117194
		public virtual long GetMaximumNumberOfPoints()
		{
			return vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_GetMaximumNumberOfPoints_05(base.GetCppThis());
		}

		// Token: 0x0600C9D4 RID: 51668
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDensifyPointCloudFilter_GetMaximumNumberOfPointsMaxValue_06(HandleRef pThis);

		/// <summary>
		/// Set a limit on the maximum number of points that can be created. This
		/// data member serves as a crude barrier to explosive point creation; it does
		/// not guarantee that precisely these many points will be created. Once this
		/// limit is hit, it may result in premature termination of the
		/// algorithm. Consider it a pressure relief valve.
		/// </summary>
		// Token: 0x0600C9D5 RID: 51669 RVA: 0x00118FB4 File Offset: 0x001171B4
		public virtual long GetMaximumNumberOfPointsMaxValue()
		{
			return vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_GetMaximumNumberOfPointsMaxValue_06(base.GetCppThis());
		}

		// Token: 0x0600C9D6 RID: 51670
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDensifyPointCloudFilter_GetMaximumNumberOfPointsMinValue_07(HandleRef pThis);

		/// <summary>
		/// Set a limit on the maximum number of points that can be created. This
		/// data member serves as a crude barrier to explosive point creation; it does
		/// not guarantee that precisely these many points will be created. Once this
		/// limit is hit, it may result in premature termination of the
		/// algorithm. Consider it a pressure relief valve.
		/// </summary>
		// Token: 0x0600C9D7 RID: 51671 RVA: 0x00118FD4 File Offset: 0x001171D4
		public virtual long GetMaximumNumberOfPointsMinValue()
		{
			return vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_GetMaximumNumberOfPointsMinValue_07(base.GetCppThis());
		}

		// Token: 0x0600C9D8 RID: 51672
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDensifyPointCloudFilter_GetNeighborhoodType_08(HandleRef pThis);

		/// <summary>
		/// Specify how the local point neighborhood is defined. By default an N
		/// closest neighborhood is used. This tends to avoid explosive point
		/// creation.
		/// </summary>
		// Token: 0x0600C9D9 RID: 51673 RVA: 0x00118FF4 File Offset: 0x001171F4
		public virtual int GetNeighborhoodType()
		{
			return vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_GetNeighborhoodType_08(base.GetCppThis());
		}

		// Token: 0x0600C9DA RID: 51674
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDensifyPointCloudFilter_GetNumberOfClosestPoints_09(HandleRef pThis);

		/// <summary>
		/// Define a local neighborhood in terms of the N closest points. By default
		/// the number of the closest points is =6. This data member is relevant
		/// only if the neighborhood type is N_CLOSEST.
		/// </summary>
		// Token: 0x0600C9DB RID: 51675 RVA: 0x00119014 File Offset: 0x00117214
		public virtual int GetNumberOfClosestPoints()
		{
			return vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_GetNumberOfClosestPoints_09(base.GetCppThis());
		}

		// Token: 0x0600C9DC RID: 51676
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDensifyPointCloudFilter_GetNumberOfClosestPointsMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Define a local neighborhood in terms of the N closest points. By default
		/// the number of the closest points is =6. This data member is relevant
		/// only if the neighborhood type is N_CLOSEST.
		/// </summary>
		// Token: 0x0600C9DD RID: 51677 RVA: 0x00119034 File Offset: 0x00117234
		public virtual int GetNumberOfClosestPointsMaxValue()
		{
			return vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_GetNumberOfClosestPointsMaxValue_10(base.GetCppThis());
		}

		// Token: 0x0600C9DE RID: 51678
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDensifyPointCloudFilter_GetNumberOfClosestPointsMinValue_11(HandleRef pThis);

		/// <summary>
		/// Define a local neighborhood in terms of the N closest points. By default
		/// the number of the closest points is =6. This data member is relevant
		/// only if the neighborhood type is N_CLOSEST.
		/// </summary>
		// Token: 0x0600C9DF RID: 51679 RVA: 0x00119054 File Offset: 0x00117254
		public virtual int GetNumberOfClosestPointsMinValue()
		{
			return vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_GetNumberOfClosestPointsMinValue_11(base.GetCppThis());
		}

		// Token: 0x0600C9E0 RID: 51680
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDensifyPointCloudFilter_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600C9E1 RID: 51681 RVA: 0x00119074 File Offset: 0x00117274
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x0600C9E2 RID: 51682
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDensifyPointCloudFilter_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600C9E3 RID: 51683 RVA: 0x00119094 File Offset: 0x00117294
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x0600C9E4 RID: 51684
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDensifyPointCloudFilter_GetRadius_14(HandleRef pThis);

		/// <summary>
		/// Define a local neighborhood for each point in terms of a local
		/// radius. By default, the radius is 1.0. This data member is relevant only
		/// if the neighborhood type is RADIUS.
		/// </summary>
		// Token: 0x0600C9E5 RID: 51685 RVA: 0x001190B0 File Offset: 0x001172B0
		public virtual double GetRadius()
		{
			return vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_GetRadius_14(base.GetCppThis());
		}

		// Token: 0x0600C9E6 RID: 51686
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDensifyPointCloudFilter_GetRadiusMaxValue_15(HandleRef pThis);

		/// <summary>
		/// Define a local neighborhood for each point in terms of a local
		/// radius. By default, the radius is 1.0. This data member is relevant only
		/// if the neighborhood type is RADIUS.
		/// </summary>
		// Token: 0x0600C9E7 RID: 51687 RVA: 0x001190D0 File Offset: 0x001172D0
		public virtual double GetRadiusMaxValue()
		{
			return vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_GetRadiusMaxValue_15(base.GetCppThis());
		}

		// Token: 0x0600C9E8 RID: 51688
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDensifyPointCloudFilter_GetRadiusMinValue_16(HandleRef pThis);

		/// <summary>
		/// Define a local neighborhood for each point in terms of a local
		/// radius. By default, the radius is 1.0. This data member is relevant only
		/// if the neighborhood type is RADIUS.
		/// </summary>
		// Token: 0x0600C9E9 RID: 51689 RVA: 0x001190F0 File Offset: 0x001172F0
		public virtual double GetRadiusMinValue()
		{
			return vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_GetRadiusMinValue_16(base.GetCppThis());
		}

		// Token: 0x0600C9EA RID: 51690
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDensifyPointCloudFilter_GetTargetDistance_17(HandleRef pThis);

		/// <summary>
		/// Set / get the target point distance. Points will be created in an
		/// iterative fashion until all points in their local neighborhood are the
		/// target distance apart or less. Note that the process may terminate early
		/// due to the limit on the maximum number of iterations. By default the target
		/// distance is set to 0.5. Note that the TargetDistance should be less than
		/// the Radius or nothing will change on output.
		/// </summary>
		// Token: 0x0600C9EB RID: 51691 RVA: 0x00119110 File Offset: 0x00117310
		public virtual double GetTargetDistance()
		{
			return vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_GetTargetDistance_17(base.GetCppThis());
		}

		// Token: 0x0600C9EC RID: 51692
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDensifyPointCloudFilter_GetTargetDistanceMaxValue_18(HandleRef pThis);

		/// <summary>
		/// Set / get the target point distance. Points will be created in an
		/// iterative fashion until all points in their local neighborhood are the
		/// target distance apart or less. Note that the process may terminate early
		/// due to the limit on the maximum number of iterations. By default the target
		/// distance is set to 0.5. Note that the TargetDistance should be less than
		/// the Radius or nothing will change on output.
		/// </summary>
		// Token: 0x0600C9ED RID: 51693 RVA: 0x00119130 File Offset: 0x00117330
		public virtual double GetTargetDistanceMaxValue()
		{
			return vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_GetTargetDistanceMaxValue_18(base.GetCppThis());
		}

		// Token: 0x0600C9EE RID: 51694
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDensifyPointCloudFilter_GetTargetDistanceMinValue_19(HandleRef pThis);

		/// <summary>
		/// Set / get the target point distance. Points will be created in an
		/// iterative fashion until all points in their local neighborhood are the
		/// target distance apart or less. Note that the process may terminate early
		/// due to the limit on the maximum number of iterations. By default the target
		/// distance is set to 0.5. Note that the TargetDistance should be less than
		/// the Radius or nothing will change on output.
		/// </summary>
		// Token: 0x0600C9EF RID: 51695 RVA: 0x00119150 File Offset: 0x00117350
		public virtual double GetTargetDistanceMinValue()
		{
			return vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_GetTargetDistanceMinValue_19(base.GetCppThis());
		}

		// Token: 0x0600C9F0 RID: 51696
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDensifyPointCloudFilter_InterpolateAttributeDataOff_20(HandleRef pThis);

		/// <summary>
		/// Turn on/off the interpolation of attribute data from the input point
		/// cloud to new, added points.
		/// </summary>
		// Token: 0x0600C9F1 RID: 51697 RVA: 0x0011916F File Offset: 0x0011736F
		public virtual void InterpolateAttributeDataOff()
		{
			vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_InterpolateAttributeDataOff_20(base.GetCppThis());
		}

		// Token: 0x0600C9F2 RID: 51698
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDensifyPointCloudFilter_InterpolateAttributeDataOn_21(HandleRef pThis);

		/// <summary>
		/// Turn on/off the interpolation of attribute data from the input point
		/// cloud to new, added points.
		/// </summary>
		// Token: 0x0600C9F3 RID: 51699 RVA: 0x0011917E File Offset: 0x0011737E
		public virtual void InterpolateAttributeDataOn()
		{
			vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_InterpolateAttributeDataOn_21(base.GetCppThis());
		}

		// Token: 0x0600C9F4 RID: 51700
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDensifyPointCloudFilter_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600C9F5 RID: 51701 RVA: 0x00119190 File Offset: 0x00117390
		public override int IsA(string type)
		{
			return vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x0600C9F6 RID: 51702
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDensifyPointCloudFilter_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600C9F7 RID: 51703 RVA: 0x001191B0 File Offset: 0x001173B0
		public new static int IsTypeOf(string type)
		{
			return vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_IsTypeOf_23(type);
		}

		// Token: 0x0600C9F8 RID: 51704
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDensifyPointCloudFilter_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600C9F9 RID: 51705 RVA: 0x001191CC File Offset: 0x001173CC
		public new vtkDensifyPointCloudFilter NewInstance()
		{
			vtkDensifyPointCloudFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDensifyPointCloudFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C9FA RID: 51706
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDensifyPointCloudFilter_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600C9FB RID: 51707 RVA: 0x00119228 File Offset: 0x00117428
		public new static vtkDensifyPointCloudFilter SafeDownCast(vtkObjectBase o)
		{
			vtkDensifyPointCloudFilter vtkDensifyPointCloudFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDensifyPointCloudFilter = (vtkDensifyPointCloudFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDensifyPointCloudFilter.Register(null);
				}
			}
			return vtkDensifyPointCloudFilter;
		}

		// Token: 0x0600C9FC RID: 51708
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDensifyPointCloudFilter_SetInterpolateAttributeData_27(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off the interpolation of attribute data from the input point
		/// cloud to new, added points.
		/// </summary>
		// Token: 0x0600C9FD RID: 51709 RVA: 0x001192A7 File Offset: 0x001174A7
		public virtual void SetInterpolateAttributeData(bool _arg)
		{
			vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_SetInterpolateAttributeData_27(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600C9FE RID: 51710
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDensifyPointCloudFilter_SetMaximumNumberOfIterations_28(HandleRef pThis, int _arg);

		/// <summary>
		/// The maximum number of iterations to run. By default the maximum is
		/// one.
		/// </summary>
		// Token: 0x0600C9FF RID: 51711 RVA: 0x001192BF File Offset: 0x001174BF
		public virtual void SetMaximumNumberOfIterations(int _arg)
		{
			vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_SetMaximumNumberOfIterations_28(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CA00 RID: 51712
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDensifyPointCloudFilter_SetMaximumNumberOfPoints_29(HandleRef pThis, long _arg);

		/// <summary>
		/// Set a limit on the maximum number of points that can be created. This
		/// data member serves as a crude barrier to explosive point creation; it does
		/// not guarantee that precisely these many points will be created. Once this
		/// limit is hit, it may result in premature termination of the
		/// algorithm. Consider it a pressure relief valve.
		/// </summary>
		// Token: 0x0600CA01 RID: 51713 RVA: 0x001192CF File Offset: 0x001174CF
		public virtual void SetMaximumNumberOfPoints(long _arg)
		{
			vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_SetMaximumNumberOfPoints_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CA02 RID: 51714
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDensifyPointCloudFilter_SetNeighborhoodType_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify how the local point neighborhood is defined. By default an N
		/// closest neighborhood is used. This tends to avoid explosive point
		/// creation.
		/// </summary>
		// Token: 0x0600CA03 RID: 51715 RVA: 0x001192DF File Offset: 0x001174DF
		public virtual void SetNeighborhoodType(int _arg)
		{
			vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_SetNeighborhoodType_30(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CA04 RID: 51716
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDensifyPointCloudFilter_SetNeighborhoodTypeToNClosest_31(HandleRef pThis);

		/// <summary>
		/// Specify how the local point neighborhood is defined. By default an N
		/// closest neighborhood is used. This tends to avoid explosive point
		/// creation.
		/// </summary>
		// Token: 0x0600CA05 RID: 51717 RVA: 0x001192EF File Offset: 0x001174EF
		public void SetNeighborhoodTypeToNClosest()
		{
			vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_SetNeighborhoodTypeToNClosest_31(base.GetCppThis());
		}

		// Token: 0x0600CA06 RID: 51718
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDensifyPointCloudFilter_SetNeighborhoodTypeToRadius_32(HandleRef pThis);

		/// <summary>
		/// Specify how the local point neighborhood is defined. By default an N
		/// closest neighborhood is used. This tends to avoid explosive point
		/// creation.
		/// </summary>
		// Token: 0x0600CA07 RID: 51719 RVA: 0x001192FE File Offset: 0x001174FE
		public void SetNeighborhoodTypeToRadius()
		{
			vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_SetNeighborhoodTypeToRadius_32(base.GetCppThis());
		}

		// Token: 0x0600CA08 RID: 51720
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDensifyPointCloudFilter_SetNumberOfClosestPoints_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Define a local neighborhood in terms of the N closest points. By default
		/// the number of the closest points is =6. This data member is relevant
		/// only if the neighborhood type is N_CLOSEST.
		/// </summary>
		// Token: 0x0600CA09 RID: 51721 RVA: 0x0011930D File Offset: 0x0011750D
		public virtual void SetNumberOfClosestPoints(int _arg)
		{
			vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_SetNumberOfClosestPoints_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CA0A RID: 51722
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDensifyPointCloudFilter_SetRadius_34(HandleRef pThis, double _arg);

		/// <summary>
		/// Define a local neighborhood for each point in terms of a local
		/// radius. By default, the radius is 1.0. This data member is relevant only
		/// if the neighborhood type is RADIUS.
		/// </summary>
		// Token: 0x0600CA0B RID: 51723 RVA: 0x0011931D File Offset: 0x0011751D
		public virtual void SetRadius(double _arg)
		{
			vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_SetRadius_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CA0C RID: 51724
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDensifyPointCloudFilter_SetTargetDistance_35(HandleRef pThis, double _arg);

		/// <summary>
		/// Set / get the target point distance. Points will be created in an
		/// iterative fashion until all points in their local neighborhood are the
		/// target distance apart or less. Note that the process may terminate early
		/// due to the limit on the maximum number of iterations. By default the target
		/// distance is set to 0.5. Note that the TargetDistance should be less than
		/// the Radius or nothing will change on output.
		/// </summary>
		// Token: 0x0600CA0D RID: 51725 RVA: 0x0011932D File Offset: 0x0011752D
		public virtual void SetTargetDistance(double _arg)
		{
			vtkDensifyPointCloudFilter.vtkDensifyPointCloudFilter_SetTargetDistance_35(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EF9 RID: 3833
		public new const string MRFullTypeName = "Kitware.VTK.vtkDensifyPointCloudFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EFA RID: 3834
		public new static readonly string MRClassNameKey = "class vtkDensifyPointCloudFilter";

		/// <summary>
		/// This enum is used to specify how the local point neighborhood is
		/// defined.  A radius-based neighborhood in one where all points inside a
		/// specified radius is part of the neighborhood. A N closest neighborhood is
		/// one in which the N closest points are part of the neighborhood. (Note that
		/// in some cases, if points are precisely the same distance apart, the N closest
		/// may not return all points within an expected radius.)
		/// </summary>
		// Token: 0x02000438 RID: 1080
		public enum NeighborhoodType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000EFC RID: 3836
			N_CLOSEST = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000EFD RID: 3837
			RADIUS = 0
		}
	}
}
