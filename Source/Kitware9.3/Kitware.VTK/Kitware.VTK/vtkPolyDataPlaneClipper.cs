using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyDataPlaneClipper
	/// </summary>
	/// <remarks>
	///    clip a vtkPolyData with a plane and optionally cap it
	///
	/// vtkPolyDataPlaneClipper clips an input vtkPolyData with a plane to produce
	/// an output vtkPolyData. (Here clipping means extracting cells, or portions
	/// of cells, that are on one side of a specified plane.) The input
	/// vtkPolyData must consist of convex polygons forming one or more manifold
	/// shells (use vtkTriangleFilter to triangulate the input if necessary. Note
	/// that if the input cells are non-convex, then the clipping operation will
	/// likely produce erroneous results.)
	///
	/// An optional, second vtkPolyData output may also be generated if either
	/// ClippingLoops or Capping is enabled. The clipping loops are a set of lines
	/// representing the curve(s) of intersection between the plane and the one or
	/// more shells of the input vtkPolyData. If Capping is enabled, then the
	/// clipping loops are tessellated to produce a "cap" across the clipped
	/// output. The capping option is only available if the input consists of one
	/// or more manifold shells. If not, the loop generation will fail and no
	/// cap(s) will be generated.
	///
	/// @warning
	/// The method CanFullyProcessDataObject() is available to see whether the
	/// input data can be successfully processed by this filter. Use this method
	/// sparingly because it can be slow.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkClipPolyData vtkClipClosedSurface vtkPolyDataPlaneCutter vtkPlaneCutter
	/// vtkTriangleFilter vtkCutter
	/// </seealso>
	// Token: 0x0200098B RID: 2443
	public class vtkPolyDataPlaneClipper : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019787 RID: 104327 RVA: 0x0023742F File Offset: 0x0023562F
		static vtkPolyDataPlaneClipper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataPlaneClipper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataPlaneClipper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019788 RID: 104328 RVA: 0x00237457 File Offset: 0x00235657
		public vtkPolyDataPlaneClipper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019789 RID: 104329
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataPlaneClipper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard construction, type, and print methods.
		/// </summary>
		// Token: 0x0601978A RID: 104330 RVA: 0x00237468 File Offset: 0x00235668
		public new static vtkPolyDataPlaneClipper New()
		{
			vtkPolyDataPlaneClipper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataPlaneClipper.vtkPolyDataPlaneClipper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataPlaneClipper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard construction, type, and print methods.
		/// </summary>
		// Token: 0x0601978B RID: 104331 RVA: 0x002374BC File Offset: 0x002356BC
		public vtkPolyDataPlaneClipper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolyDataPlaneClipper.vtkPolyDataPlaneClipper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601978C RID: 104332 RVA: 0x00237500 File Offset: 0x00235700
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601978D RID: 104333
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolyDataPlaneClipper_CanFullyProcessDataObject_01(HandleRef arg0);

		/// <summary>
		/// This helper method can be used to determine the if the input vtkPolyData
		/// contains convex polygonal cells, and therefore is suitable for
		/// processing by this filter. (The name of the method is consistent with
		/// other filters that perform similar operations.) This method returns true
		/// when the input contains only polygons (i.e., no verts, lines, or
		/// triangle strips); and each polygon is convex. It returns false
		/// otherwise.
		/// </summary>
		// Token: 0x0601978E RID: 104334 RVA: 0x0023750C File Offset: 0x0023570C
		public static bool CanFullyProcessDataObject(vtkDataObject arg0)
		{
			return vtkPolyDataPlaneClipper.vtkPolyDataPlaneClipper_CanFullyProcessDataObject_01((arg0 == null) ? default(HandleRef) : arg0.GetCppThis()) != 0;
		}

		// Token: 0x0601978F RID: 104335
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPlaneClipper_CappingOff_02(HandleRef pThis);

		/// <summary>
		/// Specify whether to cap the clipped output vtkPolyData. If enabled, a
		/// second vtkPolyData output will be produced that contains the capping
		/// polygons (in vtkPolyData:Polys). Note that the capping operation assumes
		/// that the input to this filter is a manifold shell. If not, no output
		/// will be generated. Note that point data or cell data is not produced on
		/// this second output (because the results of interpolation across the
		/// cap(s) are generally nonsensical).
		/// </summary>
		// Token: 0x06019790 RID: 104336 RVA: 0x00237541 File Offset: 0x00235741
		public virtual void CappingOff()
		{
			vtkPolyDataPlaneClipper.vtkPolyDataPlaneClipper_CappingOff_02(base.GetCppThis());
		}

		// Token: 0x06019791 RID: 104337
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPlaneClipper_CappingOn_03(HandleRef pThis);

		/// <summary>
		/// Specify whether to cap the clipped output vtkPolyData. If enabled, a
		/// second vtkPolyData output will be produced that contains the capping
		/// polygons (in vtkPolyData:Polys). Note that the capping operation assumes
		/// that the input to this filter is a manifold shell. If not, no output
		/// will be generated. Note that point data or cell data is not produced on
		/// this second output (because the results of interpolation across the
		/// cap(s) are generally nonsensical).
		/// </summary>
		// Token: 0x06019792 RID: 104338 RVA: 0x00237550 File Offset: 0x00235750
		public virtual void CappingOn()
		{
			vtkPolyDataPlaneClipper.vtkPolyDataPlaneClipper_CappingOn_03(base.GetCppThis());
		}

		// Token: 0x06019793 RID: 104339
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPlaneClipper_ClippingLoopsOff_04(HandleRef pThis);

		/// <summary>
		/// Specify whether to generate clipping loops, i.e., the intersection of
		/// the plane with the input polydata. The generation of clipping loops will
		/// function correctly even if the input vtkPolyData consists of non-closed
		/// shells; however if the shells are not closed, the loops will not be
		/// either. If enabled, a second vtkPolyData output will be produced that
		/// contains the clipping loops (in vtkPolyData::Lines)
		/// </summary>
		// Token: 0x06019794 RID: 104340 RVA: 0x0023755F File Offset: 0x0023575F
		public virtual void ClippingLoopsOff()
		{
			vtkPolyDataPlaneClipper.vtkPolyDataPlaneClipper_ClippingLoopsOff_04(base.GetCppThis());
		}

		// Token: 0x06019795 RID: 104341
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPlaneClipper_ClippingLoopsOn_05(HandleRef pThis);

		/// <summary>
		/// Specify whether to generate clipping loops, i.e., the intersection of
		/// the plane with the input polydata. The generation of clipping loops will
		/// function correctly even if the input vtkPolyData consists of non-closed
		/// shells; however if the shells are not closed, the loops will not be
		/// either. If enabled, a second vtkPolyData output will be produced that
		/// contains the clipping loops (in vtkPolyData::Lines)
		/// </summary>
		// Token: 0x06019796 RID: 104342 RVA: 0x0023756E File Offset: 0x0023576E
		public virtual void ClippingLoopsOn()
		{
			vtkPolyDataPlaneClipper.vtkPolyDataPlaneClipper_ClippingLoopsOn_05(base.GetCppThis());
		}

		// Token: 0x06019797 RID: 104343
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkPolyDataPlaneClipper_GetBatchSize_06(HandleRef pThis);

		/// <summary>
		/// Specify the number of input triangles in a batch, where a batch defines
		/// a subset of the input triangles operated on during threaded
		/// execution. Generally this is only used for debugging or performance
		/// studies (since batch size affects the thread workload).
		/// </summary>
		// Token: 0x06019798 RID: 104344 RVA: 0x00237580 File Offset: 0x00235780
		public virtual uint GetBatchSize()
		{
			return vtkPolyDataPlaneClipper.vtkPolyDataPlaneClipper_GetBatchSize_06(base.GetCppThis());
		}

		// Token: 0x06019799 RID: 104345
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkPolyDataPlaneClipper_GetBatchSizeMaxValue_07(HandleRef pThis);

		/// <summary>
		/// Specify the number of input triangles in a batch, where a batch defines
		/// a subset of the input triangles operated on during threaded
		/// execution. Generally this is only used for debugging or performance
		/// studies (since batch size affects the thread workload).
		/// </summary>
		// Token: 0x0601979A RID: 104346 RVA: 0x002375A0 File Offset: 0x002357A0
		public virtual uint GetBatchSizeMaxValue()
		{
			return vtkPolyDataPlaneClipper.vtkPolyDataPlaneClipper_GetBatchSizeMaxValue_07(base.GetCppThis());
		}

		// Token: 0x0601979B RID: 104347
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkPolyDataPlaneClipper_GetBatchSizeMinValue_08(HandleRef pThis);

		/// <summary>
		/// Specify the number of input triangles in a batch, where a batch defines
		/// a subset of the input triangles operated on during threaded
		/// execution. Generally this is only used for debugging or performance
		/// studies (since batch size affects the thread workload).
		/// </summary>
		// Token: 0x0601979C RID: 104348 RVA: 0x002375C0 File Offset: 0x002357C0
		public virtual uint GetBatchSizeMinValue()
		{
			return vtkPolyDataPlaneClipper.vtkPolyDataPlaneClipper_GetBatchSizeMinValue_08(base.GetCppThis());
		}

		// Token: 0x0601979D RID: 104349
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataPlaneClipper_GetCap_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output dataset representing the clipping loops and capping
		/// polygons.  This output is empty if both ClippingLoops and Capping is
		/// off. Otherwise, if there is an intersection with the clipping plane,
		/// then polyline loops are available from the vtkPolyData::Lines, and the
		/// capping polygons are available from the vtkPolyData::Polys data arrays.
		/// </summary>
		// Token: 0x0601979E RID: 104350 RVA: 0x002375E0 File Offset: 0x002357E0
		public vtkPolyData GetCap()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataPlaneClipper.vtkPolyDataPlaneClipper_GetCap_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x0601979F RID: 104351
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolyDataPlaneClipper_GetCapping_10(HandleRef pThis);

		/// <summary>
		/// Specify whether to cap the clipped output vtkPolyData. If enabled, a
		/// second vtkPolyData output will be produced that contains the capping
		/// polygons (in vtkPolyData:Polys). Note that the capping operation assumes
		/// that the input to this filter is a manifold shell. If not, no output
		/// will be generated. Note that point data or cell data is not produced on
		/// this second output (because the results of interpolation across the
		/// cap(s) are generally nonsensical).
		/// </summary>
		// Token: 0x060197A0 RID: 104352 RVA: 0x00237650 File Offset: 0x00235850
		public virtual bool GetCapping()
		{
			return vtkPolyDataPlaneClipper.vtkPolyDataPlaneClipper_GetCapping_10(base.GetCppThis()) != 0;
		}

		// Token: 0x060197A1 RID: 104353
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolyDataPlaneClipper_GetClippingLoops_11(HandleRef pThis);

		/// <summary>
		/// Specify whether to generate clipping loops, i.e., the intersection of
		/// the plane with the input polydata. The generation of clipping loops will
		/// function correctly even if the input vtkPolyData consists of non-closed
		/// shells; however if the shells are not closed, the loops will not be
		/// either. If enabled, a second vtkPolyData output will be produced that
		/// contains the clipping loops (in vtkPolyData::Lines)
		/// </summary>
		// Token: 0x060197A2 RID: 104354 RVA: 0x00237678 File Offset: 0x00235878
		public virtual bool GetClippingLoops()
		{
			return vtkPolyDataPlaneClipper.vtkPolyDataPlaneClipper_GetClippingLoops_11(base.GetCppThis()) != 0;
		}

		// Token: 0x060197A3 RID: 104355
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkPolyDataPlaneClipper_GetMTime_12(HandleRef pThis);

		/// <summary>
		/// The modified time depends on the delegated clipping plane.
		/// </summary>
		// Token: 0x060197A4 RID: 104356 RVA: 0x002376A0 File Offset: 0x002358A0
		public override ulong GetMTime()
		{
			return vtkPolyDataPlaneClipper.vtkPolyDataPlaneClipper_GetMTime_12(base.GetCppThis());
		}

		// Token: 0x060197A5 RID: 104357
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataPlaneClipper_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard construction, type, and print methods.
		/// </summary>
		// Token: 0x060197A6 RID: 104358 RVA: 0x002376C0 File Offset: 0x002358C0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolyDataPlaneClipper.vtkPolyDataPlaneClipper_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x060197A7 RID: 104359
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataPlaneClipper_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard construction, type, and print methods.
		/// </summary>
		// Token: 0x060197A8 RID: 104360 RVA: 0x002376E0 File Offset: 0x002358E0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolyDataPlaneClipper.vtkPolyDataPlaneClipper_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x060197A9 RID: 104361
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataPlaneClipper_GetOutputPointsPrecision_15(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points type. See the
		/// documentation for the vtkAlgorithm::DesiredOutputPrecision enum for an
		/// explanation of the available precision settings. OutputPointsPrecision
		/// is DEFAULT_PRECISION by default.
		/// </summary>
		// Token: 0x060197AA RID: 104362 RVA: 0x002376FC File Offset: 0x002358FC
		public virtual int GetOutputPointsPrecision()
		{
			return vtkPolyDataPlaneClipper.vtkPolyDataPlaneClipper_GetOutputPointsPrecision_15(base.GetCppThis());
		}

		// Token: 0x060197AB RID: 104363
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolyDataPlaneClipper_GetPassCapPointData_16(HandleRef pThis);

		/// <summary>
		/// Specify whether to pass point data through to the second (Cap) output.
		/// By default this is disabled. This feature is useful in certain situations
		/// when trying to combine the cap with clipped polydata.
		/// </summary>
		// Token: 0x060197AC RID: 104364 RVA: 0x0023771C File Offset: 0x0023591C
		public virtual bool GetPassCapPointData()
		{
			return vtkPolyDataPlaneClipper.vtkPolyDataPlaneClipper_GetPassCapPointData_16(base.GetCppThis()) != 0;
		}

		// Token: 0x060197AD RID: 104365
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataPlaneClipper_GetPlane_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the plane (an implicit function) to perform the clipping. The
		/// definition of the plane used to perform the clipping (i.e., its origin
		/// and normal) is controlled via this instance of vtkPlane.
		/// </summary>
		// Token: 0x060197AE RID: 104366 RVA: 0x00237744 File Offset: 0x00235944
		public virtual vtkPlane GetPlane()
		{
			vtkPlane vtkPlane = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataPlaneClipper.vtkPolyDataPlaneClipper_GetPlane_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlane = (vtkPlane)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlane.Register(null);
				}
			}
			return vtkPlane;
		}

		// Token: 0x060197AF RID: 104367
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataPlaneClipper_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard construction, type, and print methods.
		/// </summary>
		// Token: 0x060197B0 RID: 104368 RVA: 0x002377B4 File Offset: 0x002359B4
		public override int IsA(string type)
		{
			return vtkPolyDataPlaneClipper.vtkPolyDataPlaneClipper_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x060197B1 RID: 104369
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataPlaneClipper_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard construction, type, and print methods.
		/// </summary>
		// Token: 0x060197B2 RID: 104370 RVA: 0x002377D4 File Offset: 0x002359D4
		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataPlaneClipper.vtkPolyDataPlaneClipper_IsTypeOf_19(type);
		}

		// Token: 0x060197B3 RID: 104371
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataPlaneClipper_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard construction, type, and print methods.
		/// </summary>
		// Token: 0x060197B4 RID: 104372 RVA: 0x002377F0 File Offset: 0x002359F0
		public new vtkPolyDataPlaneClipper NewInstance()
		{
			vtkPolyDataPlaneClipper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataPlaneClipper.vtkPolyDataPlaneClipper_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataPlaneClipper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060197B5 RID: 104373
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPlaneClipper_PassCapPointDataOff_22(HandleRef pThis);

		/// <summary>
		/// Specify whether to pass point data through to the second (Cap) output.
		/// By default this is disabled. This feature is useful in certain situations
		/// when trying to combine the cap with clipped polydata.
		/// </summary>
		// Token: 0x060197B6 RID: 104374 RVA: 0x0023784A File Offset: 0x00235A4A
		public virtual void PassCapPointDataOff()
		{
			vtkPolyDataPlaneClipper.vtkPolyDataPlaneClipper_PassCapPointDataOff_22(base.GetCppThis());
		}

		// Token: 0x060197B7 RID: 104375
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPlaneClipper_PassCapPointDataOn_23(HandleRef pThis);

		/// <summary>
		/// Specify whether to pass point data through to the second (Cap) output.
		/// By default this is disabled. This feature is useful in certain situations
		/// when trying to combine the cap with clipped polydata.
		/// </summary>
		// Token: 0x060197B8 RID: 104376 RVA: 0x00237859 File Offset: 0x00235A59
		public virtual void PassCapPointDataOn()
		{
			vtkPolyDataPlaneClipper.vtkPolyDataPlaneClipper_PassCapPointDataOn_23(base.GetCppThis());
		}

		// Token: 0x060197B9 RID: 104377
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataPlaneClipper_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard construction, type, and print methods.
		/// </summary>
		// Token: 0x060197BA RID: 104378 RVA: 0x00237868 File Offset: 0x00235A68
		public new static vtkPolyDataPlaneClipper SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataPlaneClipper vtkPolyDataPlaneClipper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataPlaneClipper.vtkPolyDataPlaneClipper_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataPlaneClipper = (vtkPolyDataPlaneClipper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataPlaneClipper.Register(null);
				}
			}
			return vtkPolyDataPlaneClipper;
		}

		// Token: 0x060197BB RID: 104379
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPlaneClipper_SetBatchSize_25(HandleRef pThis, uint _arg);

		/// <summary>
		/// Specify the number of input triangles in a batch, where a batch defines
		/// a subset of the input triangles operated on during threaded
		/// execution. Generally this is only used for debugging or performance
		/// studies (since batch size affects the thread workload).
		/// </summary>
		// Token: 0x060197BC RID: 104380 RVA: 0x002378E7 File Offset: 0x00235AE7
		public virtual void SetBatchSize(uint _arg)
		{
			vtkPolyDataPlaneClipper.vtkPolyDataPlaneClipper_SetBatchSize_25(base.GetCppThis(), _arg);
		}

		// Token: 0x060197BD RID: 104381
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPlaneClipper_SetCapping_26(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify whether to cap the clipped output vtkPolyData. If enabled, a
		/// second vtkPolyData output will be produced that contains the capping
		/// polygons (in vtkPolyData:Polys). Note that the capping operation assumes
		/// that the input to this filter is a manifold shell. If not, no output
		/// will be generated. Note that point data or cell data is not produced on
		/// this second output (because the results of interpolation across the
		/// cap(s) are generally nonsensical).
		/// </summary>
		// Token: 0x060197BE RID: 104382 RVA: 0x002378F7 File Offset: 0x00235AF7
		public virtual void SetCapping(bool _arg)
		{
			vtkPolyDataPlaneClipper.vtkPolyDataPlaneClipper_SetCapping_26(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060197BF RID: 104383
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPlaneClipper_SetClippingLoops_27(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify whether to generate clipping loops, i.e., the intersection of
		/// the plane with the input polydata. The generation of clipping loops will
		/// function correctly even if the input vtkPolyData consists of non-closed
		/// shells; however if the shells are not closed, the loops will not be
		/// either. If enabled, a second vtkPolyData output will be produced that
		/// contains the clipping loops (in vtkPolyData::Lines)
		/// </summary>
		// Token: 0x060197C0 RID: 104384 RVA: 0x0023790F File Offset: 0x00235B0F
		public virtual void SetClippingLoops(bool _arg)
		{
			vtkPolyDataPlaneClipper.vtkPolyDataPlaneClipper_SetClippingLoops_27(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060197C1 RID: 104385
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPlaneClipper_SetOutputPointsPrecision_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points type. See the
		/// documentation for the vtkAlgorithm::DesiredOutputPrecision enum for an
		/// explanation of the available precision settings. OutputPointsPrecision
		/// is DEFAULT_PRECISION by default.
		/// </summary>
		// Token: 0x060197C2 RID: 104386 RVA: 0x00237927 File Offset: 0x00235B27
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkPolyDataPlaneClipper.vtkPolyDataPlaneClipper_SetOutputPointsPrecision_28(base.GetCppThis(), _arg);
		}

		// Token: 0x060197C3 RID: 104387
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPlaneClipper_SetPassCapPointData_29(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify whether to pass point data through to the second (Cap) output.
		/// By default this is disabled. This feature is useful in certain situations
		/// when trying to combine the cap with clipped polydata.
		/// </summary>
		// Token: 0x060197C4 RID: 104388 RVA: 0x00237937 File Offset: 0x00235B37
		public virtual void SetPassCapPointData(bool _arg)
		{
			vtkPolyDataPlaneClipper.vtkPolyDataPlaneClipper_SetPassCapPointData_29(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060197C5 RID: 104389
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPlaneClipper_SetPlane_30(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the plane (an implicit function) to perform the clipping. The
		/// definition of the plane used to perform the clipping (i.e., its origin
		/// and normal) is controlled via this instance of vtkPlane.
		/// </summary>
		// Token: 0x060197C6 RID: 104390 RVA: 0x00237950 File Offset: 0x00235B50
		public void SetPlane(vtkPlane arg0)
		{
			vtkPolyDataPlaneClipper.vtkPolyDataPlaneClipper_SetPlane_30(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BD7 RID: 7127
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataPlaneClipper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BD8 RID: 7128
		public new static readonly string MRClassNameKey = "class vtkPolyDataPlaneClipper";
	}
}
