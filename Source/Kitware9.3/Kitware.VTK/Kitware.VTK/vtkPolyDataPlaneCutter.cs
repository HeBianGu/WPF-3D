using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyDataPlaneCutter
	/// </summary>
	/// <remarks>
	///    threaded (high-performance) cutting of a vtkPolyData with a plane
	///
	/// vtkPolyDataPlaneCutter cuts an input vtkPolyData with a plane to produce
	/// an output vtkPolyData. (Here cutting means slicing through the polydata to
	/// generates lines of intersection.) The input vtkPolyData must consist of
	/// convex polygons - vertices, lines, and triangle strips are ignored. (Note:
	/// use vtkTriangleFilter to triangulate non-convex input polygons if
	/// necessary. If the input cells are non-convex, then the cutting operation
	/// will likely produce erroneous results.)
	///
	/// The main difference between this filter and other cutting filters is that
	/// vtkPolyDataPlaneCutter is tuned for performance on vtkPolyData with convex
	/// polygonal cells.
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
	/// vtkPlaneCutter vtkCutter vtkPolyDataPlaneClipper
	/// </seealso>
	// Token: 0x0200098C RID: 2444
	public class vtkPolyDataPlaneCutter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060197C7 RID: 104391 RVA: 0x0023797F File Offset: 0x00235B7F
		static vtkPolyDataPlaneCutter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataPlaneCutter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataPlaneCutter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060197C8 RID: 104392 RVA: 0x002379A7 File Offset: 0x00235BA7
		public vtkPolyDataPlaneCutter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060197C9 RID: 104393
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataPlaneCutter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard construction, type, and print methods.
		/// </summary>
		// Token: 0x060197CA RID: 104394 RVA: 0x002379B8 File Offset: 0x00235BB8
		public new static vtkPolyDataPlaneCutter New()
		{
			vtkPolyDataPlaneCutter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataPlaneCutter.vtkPolyDataPlaneCutter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataPlaneCutter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard construction, type, and print methods.
		/// </summary>
		// Token: 0x060197CB RID: 104395 RVA: 0x00237A0C File Offset: 0x00235C0C
		public vtkPolyDataPlaneCutter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolyDataPlaneCutter.vtkPolyDataPlaneCutter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060197CC RID: 104396 RVA: 0x00237A50 File Offset: 0x00235C50
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060197CD RID: 104397
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolyDataPlaneCutter_CanFullyProcessDataObject_01(HandleRef arg0);

		/// <summary>
		/// This helper method can be used to determine the if the input vtkPolyData
		/// contains convex polygonal cells, and therefore is suitable for
		/// processing by this filter. (The name of the method is consistent with
		/// other filters that perform similar operations.) This method returns true
		/// when the input contains only polygons (i.e., no verts, lines, or
		/// triangle strips); and each polygon is convex. It returns false
		/// otherwise.
		/// </summary>
		// Token: 0x060197CE RID: 104398 RVA: 0x00237A5C File Offset: 0x00235C5C
		public static bool CanFullyProcessDataObject(vtkDataObject arg0)
		{
			return vtkPolyDataPlaneCutter.vtkPolyDataPlaneCutter_CanFullyProcessDataObject_01((arg0 == null) ? default(HandleRef) : arg0.GetCppThis()) != 0;
		}

		// Token: 0x060197CF RID: 104399
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPlaneCutter_ComputeNormalsOff_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. The normal generated is simply the
		/// cut plane normal. The normals are associated with the output points. By
		/// default the computation of normals is disabled.
		/// </summary>
		// Token: 0x060197D0 RID: 104400 RVA: 0x00237A91 File Offset: 0x00235C91
		public virtual void ComputeNormalsOff()
		{
			vtkPolyDataPlaneCutter.vtkPolyDataPlaneCutter_ComputeNormalsOff_02(base.GetCppThis());
		}

		// Token: 0x060197D1 RID: 104401
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPlaneCutter_ComputeNormalsOn_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. The normal generated is simply the
		/// cut plane normal. The normals are associated with the output points. By
		/// default the computation of normals is disabled.
		/// </summary>
		// Token: 0x060197D2 RID: 104402 RVA: 0x00237AA0 File Offset: 0x00235CA0
		public virtual void ComputeNormalsOn()
		{
			vtkPolyDataPlaneCutter.vtkPolyDataPlaneCutter_ComputeNormalsOn_03(base.GetCppThis());
		}

		// Token: 0x060197D3 RID: 104403
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkPolyDataPlaneCutter_GetBatchSize_04(HandleRef pThis);

		/// <summary>
		/// Specify the number of input cells in a batch, where a batch defines
		/// a subset of the input cells operated on during threaded
		/// execution. Generally this is only used for debugging or performance
		/// studies (since batch size affects the thread workload). By default,
		/// the batch size is 10,000 cells.
		/// </summary>
		// Token: 0x060197D4 RID: 104404 RVA: 0x00237AB0 File Offset: 0x00235CB0
		public virtual uint GetBatchSize()
		{
			return vtkPolyDataPlaneCutter.vtkPolyDataPlaneCutter_GetBatchSize_04(base.GetCppThis());
		}

		// Token: 0x060197D5 RID: 104405
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkPolyDataPlaneCutter_GetBatchSizeMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Specify the number of input cells in a batch, where a batch defines
		/// a subset of the input cells operated on during threaded
		/// execution. Generally this is only used for debugging or performance
		/// studies (since batch size affects the thread workload). By default,
		/// the batch size is 10,000 cells.
		/// </summary>
		// Token: 0x060197D6 RID: 104406 RVA: 0x00237AD0 File Offset: 0x00235CD0
		public virtual uint GetBatchSizeMaxValue()
		{
			return vtkPolyDataPlaneCutter.vtkPolyDataPlaneCutter_GetBatchSizeMaxValue_05(base.GetCppThis());
		}

		// Token: 0x060197D7 RID: 104407
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkPolyDataPlaneCutter_GetBatchSizeMinValue_06(HandleRef pThis);

		/// <summary>
		/// Specify the number of input cells in a batch, where a batch defines
		/// a subset of the input cells operated on during threaded
		/// execution. Generally this is only used for debugging or performance
		/// studies (since batch size affects the thread workload). By default,
		/// the batch size is 10,000 cells.
		/// </summary>
		// Token: 0x060197D8 RID: 104408 RVA: 0x00237AF0 File Offset: 0x00235CF0
		public virtual uint GetBatchSizeMinValue()
		{
			return vtkPolyDataPlaneCutter.vtkPolyDataPlaneCutter_GetBatchSizeMinValue_06(base.GetCppThis());
		}

		// Token: 0x060197D9 RID: 104409
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolyDataPlaneCutter_GetComputeNormals_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. The normal generated is simply the
		/// cut plane normal. The normals are associated with the output points. By
		/// default the computation of normals is disabled.
		/// </summary>
		// Token: 0x060197DA RID: 104410 RVA: 0x00237B10 File Offset: 0x00235D10
		public virtual bool GetComputeNormals()
		{
			return vtkPolyDataPlaneCutter.vtkPolyDataPlaneCutter_GetComputeNormals_07(base.GetCppThis()) != 0;
		}

		// Token: 0x060197DB RID: 104411
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolyDataPlaneCutter_GetInterpolateAttributes_08(HandleRef pThis);

		/// <summary>
		/// Indicate whether to interpolate attribute data. By default this is
		/// enabled. Note that both cell data and point data is interpolated and
		/// output.
		/// </summary>
		// Token: 0x060197DC RID: 104412 RVA: 0x00237B38 File Offset: 0x00235D38
		public virtual bool GetInterpolateAttributes()
		{
			return vtkPolyDataPlaneCutter.vtkPolyDataPlaneCutter_GetInterpolateAttributes_08(base.GetCppThis()) != 0;
		}

		// Token: 0x060197DD RID: 104413
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkPolyDataPlaneCutter_GetMTime_09(HandleRef pThis);

		/// <summary>
		/// The modified time depends on the delegated cutting plane.
		/// </summary>
		// Token: 0x060197DE RID: 104414 RVA: 0x00237B60 File Offset: 0x00235D60
		public override ulong GetMTime()
		{
			return vtkPolyDataPlaneCutter.vtkPolyDataPlaneCutter_GetMTime_09(base.GetCppThis());
		}

		// Token: 0x060197DF RID: 104415
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataPlaneCutter_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard construction, type, and print methods.
		/// </summary>
		// Token: 0x060197E0 RID: 104416 RVA: 0x00237B80 File Offset: 0x00235D80
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolyDataPlaneCutter.vtkPolyDataPlaneCutter_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x060197E1 RID: 104417
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataPlaneCutter_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard construction, type, and print methods.
		/// </summary>
		// Token: 0x060197E2 RID: 104418 RVA: 0x00237BA0 File Offset: 0x00235DA0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolyDataPlaneCutter.vtkPolyDataPlaneCutter_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x060197E3 RID: 104419
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataPlaneCutter_GetOutputPointsPrecision_12(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points type. See the
		/// documentation for the vtkAlgorithm::DesiredOutputPrecision enum for an
		/// explanation of the available precision settings. OutputPointsPrecision
		/// is DEFAULT_PRECISION by default.
		/// </summary>
		// Token: 0x060197E4 RID: 104420 RVA: 0x00237BBC File Offset: 0x00235DBC
		public virtual int GetOutputPointsPrecision()
		{
			return vtkPolyDataPlaneCutter.vtkPolyDataPlaneCutter_GetOutputPointsPrecision_12(base.GetCppThis());
		}

		// Token: 0x060197E5 RID: 104421
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataPlaneCutter_GetPlane_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the plane (an implicit function) to perform the cutting. The
		/// definition of the plane used to perform the cutting (i.e., its origin
		/// and normal) is controlled via this instance of vtkPlane.
		/// </summary>
		// Token: 0x060197E6 RID: 104422 RVA: 0x00237BDC File Offset: 0x00235DDC
		public virtual vtkPlane GetPlane()
		{
			vtkPlane vtkPlane = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataPlaneCutter.vtkPolyDataPlaneCutter_GetPlane_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060197E7 RID: 104423
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPlaneCutter_InterpolateAttributesOff_14(HandleRef pThis);

		/// <summary>
		/// Indicate whether to interpolate attribute data. By default this is
		/// enabled. Note that both cell data and point data is interpolated and
		/// output.
		/// </summary>
		// Token: 0x060197E8 RID: 104424 RVA: 0x00237C4B File Offset: 0x00235E4B
		public virtual void InterpolateAttributesOff()
		{
			vtkPolyDataPlaneCutter.vtkPolyDataPlaneCutter_InterpolateAttributesOff_14(base.GetCppThis());
		}

		// Token: 0x060197E9 RID: 104425
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPlaneCutter_InterpolateAttributesOn_15(HandleRef pThis);

		/// <summary>
		/// Indicate whether to interpolate attribute data. By default this is
		/// enabled. Note that both cell data and point data is interpolated and
		/// output.
		/// </summary>
		// Token: 0x060197EA RID: 104426 RVA: 0x00237C5A File Offset: 0x00235E5A
		public virtual void InterpolateAttributesOn()
		{
			vtkPolyDataPlaneCutter.vtkPolyDataPlaneCutter_InterpolateAttributesOn_15(base.GetCppThis());
		}

		// Token: 0x060197EB RID: 104427
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataPlaneCutter_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard construction, type, and print methods.
		/// </summary>
		// Token: 0x060197EC RID: 104428 RVA: 0x00237C6C File Offset: 0x00235E6C
		public override int IsA(string type)
		{
			return vtkPolyDataPlaneCutter.vtkPolyDataPlaneCutter_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x060197ED RID: 104429
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataPlaneCutter_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard construction, type, and print methods.
		/// </summary>
		// Token: 0x060197EE RID: 104430 RVA: 0x00237C8C File Offset: 0x00235E8C
		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataPlaneCutter.vtkPolyDataPlaneCutter_IsTypeOf_17(type);
		}

		// Token: 0x060197EF RID: 104431
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataPlaneCutter_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard construction, type, and print methods.
		/// </summary>
		// Token: 0x060197F0 RID: 104432 RVA: 0x00237CA8 File Offset: 0x00235EA8
		public new vtkPolyDataPlaneCutter NewInstance()
		{
			vtkPolyDataPlaneCutter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataPlaneCutter.vtkPolyDataPlaneCutter_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataPlaneCutter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060197F1 RID: 104433
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataPlaneCutter_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard construction, type, and print methods.
		/// </summary>
		// Token: 0x060197F2 RID: 104434 RVA: 0x00237D04 File Offset: 0x00235F04
		public new static vtkPolyDataPlaneCutter SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataPlaneCutter vtkPolyDataPlaneCutter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataPlaneCutter.vtkPolyDataPlaneCutter_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataPlaneCutter = (vtkPolyDataPlaneCutter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataPlaneCutter.Register(null);
				}
			}
			return vtkPolyDataPlaneCutter;
		}

		// Token: 0x060197F3 RID: 104435
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPlaneCutter_SetBatchSize_21(HandleRef pThis, uint _arg);

		/// <summary>
		/// Specify the number of input cells in a batch, where a batch defines
		/// a subset of the input cells operated on during threaded
		/// execution. Generally this is only used for debugging or performance
		/// studies (since batch size affects the thread workload). By default,
		/// the batch size is 10,000 cells.
		/// </summary>
		// Token: 0x060197F4 RID: 104436 RVA: 0x00237D83 File Offset: 0x00235F83
		public virtual void SetBatchSize(uint _arg)
		{
			vtkPolyDataPlaneCutter.vtkPolyDataPlaneCutter_SetBatchSize_21(base.GetCppThis(), _arg);
		}

		// Token: 0x060197F5 RID: 104437
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPlaneCutter_SetComputeNormals_22(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get the computation of normals. The normal generated is simply the
		/// cut plane normal. The normals are associated with the output points. By
		/// default the computation of normals is disabled.
		/// </summary>
		// Token: 0x060197F6 RID: 104438 RVA: 0x00237D93 File Offset: 0x00235F93
		public virtual void SetComputeNormals(bool _arg)
		{
			vtkPolyDataPlaneCutter.vtkPolyDataPlaneCutter_SetComputeNormals_22(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060197F7 RID: 104439
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPlaneCutter_SetInterpolateAttributes_23(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether to interpolate attribute data. By default this is
		/// enabled. Note that both cell data and point data is interpolated and
		/// output.
		/// </summary>
		// Token: 0x060197F8 RID: 104440 RVA: 0x00237DAB File Offset: 0x00235FAB
		public virtual void SetInterpolateAttributes(bool _arg)
		{
			vtkPolyDataPlaneCutter.vtkPolyDataPlaneCutter_SetInterpolateAttributes_23(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060197F9 RID: 104441
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPlaneCutter_SetOutputPointsPrecision_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points type. See the
		/// documentation for the vtkAlgorithm::DesiredOutputPrecision enum for an
		/// explanation of the available precision settings. OutputPointsPrecision
		/// is DEFAULT_PRECISION by default.
		/// </summary>
		// Token: 0x060197FA RID: 104442 RVA: 0x00237DC3 File Offset: 0x00235FC3
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkPolyDataPlaneCutter.vtkPolyDataPlaneCutter_SetOutputPointsPrecision_24(base.GetCppThis(), _arg);
		}

		// Token: 0x060197FB RID: 104443
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPlaneCutter_SetPlane_25(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the plane (an implicit function) to perform the cutting. The
		/// definition of the plane used to perform the cutting (i.e., its origin
		/// and normal) is controlled via this instance of vtkPlane.
		/// </summary>
		// Token: 0x060197FC RID: 104444 RVA: 0x00237DD4 File Offset: 0x00235FD4
		public void SetPlane(vtkPlane arg0)
		{
			vtkPolyDataPlaneCutter.vtkPolyDataPlaneCutter_SetPlane_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BD9 RID: 7129
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataPlaneCutter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BDA RID: 7130
		public new static readonly string MRClassNameKey = "class vtkPolyDataPlaneCutter";
	}
}
