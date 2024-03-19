using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDepthSortPolyData
	/// </summary>
	/// <remarks>
	///    sort poly data along camera view direction
	///
	/// vtkDepthSortPolyData rearranges the order of cells so that certain
	/// rendering operations (e.g., transparency or Painter's algorithms)
	/// generate correct results. To use this filter you must specify the
	/// direction vector along which to sort the cells. You can do this by
	/// specifying a camera and/or prop to define a view direction; or
	/// explicitly set a view direction.
	///
	/// @warning
	/// The sort operation will not work well for long, thin primitives, or cells
	/// that intersect, overlap, or interpenetrate each other.
	/// </remarks>
	// Token: 0x02000603 RID: 1539
	public class vtkDepthSortPolyData : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010B86 RID: 68486 RVA: 0x0017522F File Offset: 0x0017342F
		static vtkDepthSortPolyData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDepthSortPolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDepthSortPolyData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010B87 RID: 68487 RVA: 0x00175257 File Offset: 0x00173457
		public vtkDepthSortPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010B88 RID: 68488
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDepthSortPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object.
		/// </summary>
		// Token: 0x06010B89 RID: 68489 RVA: 0x00175268 File Offset: 0x00173468
		public new static vtkDepthSortPolyData New()
		{
			vtkDepthSortPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDepthSortPolyData.vtkDepthSortPolyData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDepthSortPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate object.
		/// </summary>
		// Token: 0x06010B8A RID: 68490 RVA: 0x001752BC File Offset: 0x001734BC
		public vtkDepthSortPolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDepthSortPolyData.vtkDepthSortPolyData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010B8B RID: 68491 RVA: 0x00175300 File Offset: 0x00173500
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010B8C RID: 68492
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDepthSortPolyData_GetCamera_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a camera that is used to define a view direction along which
		/// the cells are sorted. This ivar only has effect if the direction is set
		/// to front-to-back or back-to-front, and a camera is specified.
		/// </summary>
		// Token: 0x06010B8D RID: 68493 RVA: 0x0017530C File Offset: 0x0017350C
		public virtual vtkCamera GetCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDepthSortPolyData.vtkDepthSortPolyData_GetCamera_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCamera = (vtkCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCamera.Register(null);
				}
			}
			return vtkCamera;
		}

		// Token: 0x06010B8E RID: 68494
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDepthSortPolyData_GetDepthSortMode_02(HandleRef pThis);

		/// <summary>
		/// Specify the point to use when sorting. The fastest is to just
		/// take the first cell point. Other options are to take the bounding
		/// box center or the parametric center of the cell. By default, the
		/// first cell point is used.
		/// </summary>
		// Token: 0x06010B8F RID: 68495 RVA: 0x0017537C File Offset: 0x0017357C
		public virtual int GetDepthSortMode()
		{
			return vtkDepthSortPolyData.vtkDepthSortPolyData_GetDepthSortMode_02(base.GetCppThis());
		}

		// Token: 0x06010B90 RID: 68496
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDepthSortPolyData_GetDirection_03(HandleRef pThis);

		/// <summary>
		/// Specify the sort method for the polygonal primitives. By default, the
		/// poly data is sorted from back to front.
		/// </summary>
		// Token: 0x06010B91 RID: 68497 RVA: 0x0017539C File Offset: 0x0017359C
		public virtual int GetDirection()
		{
			return vtkDepthSortPolyData.vtkDepthSortPolyData_GetDirection_03(base.GetCppThis());
		}

		// Token: 0x06010B92 RID: 68498
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkDepthSortPolyData_GetMTime_04(HandleRef pThis);

		/// <summary>
		/// Return MTime also considering the dependent objects: the camera
		/// and/or the prop3D.
		/// </summary>
		// Token: 0x06010B93 RID: 68499 RVA: 0x001753BC File Offset: 0x001735BC
		public override ulong GetMTime()
		{
			return vtkDepthSortPolyData.vtkDepthSortPolyData_GetMTime_04(base.GetCppThis());
		}

		// Token: 0x06010B94 RID: 68500
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDepthSortPolyData_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate object.
		/// </summary>
		// Token: 0x06010B95 RID: 68501 RVA: 0x001753DC File Offset: 0x001735DC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDepthSortPolyData.vtkDepthSortPolyData_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06010B96 RID: 68502
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDepthSortPolyData_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate object.
		/// </summary>
		// Token: 0x06010B97 RID: 68503 RVA: 0x001753FC File Offset: 0x001735FC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDepthSortPolyData.vtkDepthSortPolyData_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06010B98 RID: 68504
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDepthSortPolyData_GetOrigin_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the sort origin. This ivar only has effect if the sort
		/// direction is set to SetDirectionToSpecifiedVector(). The sort occurs
		/// in the direction of the vector, with this point specifying the
		/// origin.
		/// </summary>
		// Token: 0x06010B99 RID: 68505 RVA: 0x00175418 File Offset: 0x00173618
		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkDepthSortPolyData.vtkDepthSortPolyData_GetOrigin_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06010B9A RID: 68506
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthSortPolyData_GetOrigin_08(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the sort origin. This ivar only has effect if the sort
		/// direction is set to SetDirectionToSpecifiedVector(). The sort occurs
		/// in the direction of the vector, with this point specifying the
		/// origin.
		/// </summary>
		// Token: 0x06010B9B RID: 68507 RVA: 0x00175460 File Offset: 0x00173660
		public virtual void GetOrigin(IntPtr data)
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_GetOrigin_08(base.GetCppThis(), data);
		}

		// Token: 0x06010B9C RID: 68508
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDepthSortPolyData_GetProp3D_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a transformation matrix (via the vtkProp3D::GetMatrix() method)
		/// that is used to include the effects of transformation. This ivar only
		/// has effect if the direction is set to front-to-back or back-to-front,
		/// and a camera is specified. Specifying the vtkProp3D is optional.
		/// </summary>
		// Token: 0x06010B9D RID: 68509 RVA: 0x00175470 File Offset: 0x00173670
		public vtkProp3D GetProp3D()
		{
			vtkProp3D vtkProp3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDepthSortPolyData.vtkDepthSortPolyData_GetProp3D_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp3D = (vtkProp3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp3D.Register(null);
				}
			}
			return vtkProp3D;
		}

		// Token: 0x06010B9E RID: 68510
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDepthSortPolyData_GetSortScalars_10(HandleRef pThis);

		/// <summary>
		/// Set/Get a flag that controls the generation of scalar values
		/// corresponding to the sort order. If enabled, the output of this
		/// filter will include scalar values that range from 0 to (ncells-1),
		/// where 0 is closest to the sort direction.
		/// </summary>
		// Token: 0x06010B9F RID: 68511 RVA: 0x001754E0 File Offset: 0x001736E0
		public virtual int GetSortScalars()
		{
			return vtkDepthSortPolyData.vtkDepthSortPolyData_GetSortScalars_10(base.GetCppThis());
		}

		// Token: 0x06010BA0 RID: 68512
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDepthSortPolyData_GetVector_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the sort direction. This ivar only has effect if the sort
		/// direction is set to SetDirectionToSpecifiedVector(). The sort occurs
		/// in the direction of the vector.
		/// </summary>
		// Token: 0x06010BA1 RID: 68513 RVA: 0x00175500 File Offset: 0x00173700
		public virtual double[] GetVector()
		{
			IntPtr intPtr = vtkDepthSortPolyData.vtkDepthSortPolyData_GetVector_11(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06010BA2 RID: 68514
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthSortPolyData_GetVector_12(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the sort direction. This ivar only has effect if the sort
		/// direction is set to SetDirectionToSpecifiedVector(). The sort occurs
		/// in the direction of the vector.
		/// </summary>
		// Token: 0x06010BA3 RID: 68515 RVA: 0x00175548 File Offset: 0x00173748
		public virtual void GetVector(IntPtr data)
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_GetVector_12(base.GetCppThis(), data);
		}

		// Token: 0x06010BA4 RID: 68516
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDepthSortPolyData_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate object.
		/// </summary>
		// Token: 0x06010BA5 RID: 68517 RVA: 0x00175558 File Offset: 0x00173758
		public override int IsA(string type)
		{
			return vtkDepthSortPolyData.vtkDepthSortPolyData_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x06010BA6 RID: 68518
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDepthSortPolyData_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate object.
		/// </summary>
		// Token: 0x06010BA7 RID: 68519 RVA: 0x00175578 File Offset: 0x00173778
		public new static int IsTypeOf(string type)
		{
			return vtkDepthSortPolyData.vtkDepthSortPolyData_IsTypeOf_14(type);
		}

		// Token: 0x06010BA8 RID: 68520
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDepthSortPolyData_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object.
		/// </summary>
		// Token: 0x06010BA9 RID: 68521 RVA: 0x00175594 File Offset: 0x00173794
		public new vtkDepthSortPolyData NewInstance()
		{
			vtkDepthSortPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDepthSortPolyData.vtkDepthSortPolyData_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDepthSortPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010BAA RID: 68522
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDepthSortPolyData_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object.
		/// </summary>
		// Token: 0x06010BAB RID: 68523 RVA: 0x001755F0 File Offset: 0x001737F0
		public new static vtkDepthSortPolyData SafeDownCast(vtkObjectBase o)
		{
			vtkDepthSortPolyData vtkDepthSortPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDepthSortPolyData.vtkDepthSortPolyData_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDepthSortPolyData = (vtkDepthSortPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDepthSortPolyData.Register(null);
				}
			}
			return vtkDepthSortPolyData;
		}

		// Token: 0x06010BAC RID: 68524
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthSortPolyData_SetCamera_18(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify a camera that is used to define a view direction along which
		/// the cells are sorted. This ivar only has effect if the direction is set
		/// to front-to-back or back-to-front, and a camera is specified.
		/// </summary>
		// Token: 0x06010BAD RID: 68525 RVA: 0x00175670 File Offset: 0x00173870
		public virtual void SetCamera(vtkCamera arg0)
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SetCamera_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06010BAE RID: 68526
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthSortPolyData_SetDepthSortMode_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the point to use when sorting. The fastest is to just
		/// take the first cell point. Other options are to take the bounding
		/// box center or the parametric center of the cell. By default, the
		/// first cell point is used.
		/// </summary>
		// Token: 0x06010BAF RID: 68527 RVA: 0x0017569F File Offset: 0x0017389F
		public virtual void SetDepthSortMode(int _arg)
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SetDepthSortMode_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06010BB0 RID: 68528
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthSortPolyData_SetDepthSortModeToBoundsCenter_20(HandleRef pThis);

		/// <summary>
		/// Specify the point to use when sorting. The fastest is to just
		/// take the first cell point. Other options are to take the bounding
		/// box center or the parametric center of the cell. By default, the
		/// first cell point is used.
		/// </summary>
		// Token: 0x06010BB1 RID: 68529 RVA: 0x001756AF File Offset: 0x001738AF
		public void SetDepthSortModeToBoundsCenter()
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SetDepthSortModeToBoundsCenter_20(base.GetCppThis());
		}

		// Token: 0x06010BB2 RID: 68530
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthSortPolyData_SetDepthSortModeToFirstPoint_21(HandleRef pThis);

		/// <summary>
		/// Specify the point to use when sorting. The fastest is to just
		/// take the first cell point. Other options are to take the bounding
		/// box center or the parametric center of the cell. By default, the
		/// first cell point is used.
		/// </summary>
		// Token: 0x06010BB3 RID: 68531 RVA: 0x001756BE File Offset: 0x001738BE
		public void SetDepthSortModeToFirstPoint()
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SetDepthSortModeToFirstPoint_21(base.GetCppThis());
		}

		// Token: 0x06010BB4 RID: 68532
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthSortPolyData_SetDepthSortModeToParametricCenter_22(HandleRef pThis);

		/// <summary>
		/// Specify the point to use when sorting. The fastest is to just
		/// take the first cell point. Other options are to take the bounding
		/// box center or the parametric center of the cell. By default, the
		/// first cell point is used.
		/// </summary>
		// Token: 0x06010BB5 RID: 68533 RVA: 0x001756CD File Offset: 0x001738CD
		public void SetDepthSortModeToParametricCenter()
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SetDepthSortModeToParametricCenter_22(base.GetCppThis());
		}

		// Token: 0x06010BB6 RID: 68534
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthSortPolyData_SetDirection_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the sort method for the polygonal primitives. By default, the
		/// poly data is sorted from back to front.
		/// </summary>
		// Token: 0x06010BB7 RID: 68535 RVA: 0x001756DC File Offset: 0x001738DC
		public virtual void SetDirection(int _arg)
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SetDirection_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06010BB8 RID: 68536
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthSortPolyData_SetDirectionToBackToFront_24(HandleRef pThis);

		/// <summary>
		/// Specify the sort method for the polygonal primitives. By default, the
		/// poly data is sorted from back to front.
		/// </summary>
		// Token: 0x06010BB9 RID: 68537 RVA: 0x001756EC File Offset: 0x001738EC
		public void SetDirectionToBackToFront()
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SetDirectionToBackToFront_24(base.GetCppThis());
		}

		// Token: 0x06010BBA RID: 68538
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthSortPolyData_SetDirectionToFrontToBack_25(HandleRef pThis);

		/// <summary>
		/// Specify the sort method for the polygonal primitives. By default, the
		/// poly data is sorted from back to front.
		/// </summary>
		// Token: 0x06010BBB RID: 68539 RVA: 0x001756FB File Offset: 0x001738FB
		public void SetDirectionToFrontToBack()
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SetDirectionToFrontToBack_25(base.GetCppThis());
		}

		// Token: 0x06010BBC RID: 68540
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthSortPolyData_SetDirectionToSpecifiedVector_26(HandleRef pThis);

		/// <summary>
		/// Specify the sort method for the polygonal primitives. By default, the
		/// poly data is sorted from back to front.
		/// </summary>
		// Token: 0x06010BBD RID: 68541 RVA: 0x0017570A File Offset: 0x0017390A
		public void SetDirectionToSpecifiedVector()
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SetDirectionToSpecifiedVector_26(base.GetCppThis());
		}

		// Token: 0x06010BBE RID: 68542
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthSortPolyData_SetOrigin_27(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the sort origin. This ivar only has effect if the sort
		/// direction is set to SetDirectionToSpecifiedVector(). The sort occurs
		/// in the direction of the vector, with this point specifying the
		/// origin.
		/// </summary>
		// Token: 0x06010BBF RID: 68543 RVA: 0x00175719 File Offset: 0x00173919
		public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SetOrigin_27(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06010BC0 RID: 68544
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthSortPolyData_SetOrigin_28(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the sort origin. This ivar only has effect if the sort
		/// direction is set to SetDirectionToSpecifiedVector(). The sort occurs
		/// in the direction of the vector, with this point specifying the
		/// origin.
		/// </summary>
		// Token: 0x06010BC1 RID: 68545 RVA: 0x0017572B File Offset: 0x0017392B
		public virtual void SetOrigin(IntPtr _arg)
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SetOrigin_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06010BC2 RID: 68546
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthSortPolyData_SetProp3D_29(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify a transformation matrix (via the vtkProp3D::GetMatrix() method)
		/// that is used to include the effects of transformation. This ivar only
		/// has effect if the direction is set to front-to-back or back-to-front,
		/// and a camera is specified. Specifying the vtkProp3D is optional.
		/// </summary>
		// Token: 0x06010BC3 RID: 68547 RVA: 0x0017573C File Offset: 0x0017393C
		public void SetProp3D(vtkProp3D arg0)
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SetProp3D_29(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06010BC4 RID: 68548
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthSortPolyData_SetSortScalars_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get a flag that controls the generation of scalar values
		/// corresponding to the sort order. If enabled, the output of this
		/// filter will include scalar values that range from 0 to (ncells-1),
		/// where 0 is closest to the sort direction.
		/// </summary>
		// Token: 0x06010BC5 RID: 68549 RVA: 0x0017576B File Offset: 0x0017396B
		public virtual void SetSortScalars(int _arg)
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SetSortScalars_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06010BC6 RID: 68550
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthSortPolyData_SetVector_31(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the sort direction. This ivar only has effect if the sort
		/// direction is set to SetDirectionToSpecifiedVector(). The sort occurs
		/// in the direction of the vector.
		/// </summary>
		// Token: 0x06010BC7 RID: 68551 RVA: 0x0017577B File Offset: 0x0017397B
		public virtual void SetVector(double _arg1, double _arg2, double _arg3)
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SetVector_31(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06010BC8 RID: 68552
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthSortPolyData_SetVector_32(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the sort direction. This ivar only has effect if the sort
		/// direction is set to SetDirectionToSpecifiedVector(). The sort occurs
		/// in the direction of the vector.
		/// </summary>
		// Token: 0x06010BC9 RID: 68553 RVA: 0x0017578D File Offset: 0x0017398D
		public virtual void SetVector(IntPtr _arg)
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SetVector_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06010BCA RID: 68554
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthSortPolyData_SortScalarsOff_33(HandleRef pThis);

		/// <summary>
		/// Set/Get a flag that controls the generation of scalar values
		/// corresponding to the sort order. If enabled, the output of this
		/// filter will include scalar values that range from 0 to (ncells-1),
		/// where 0 is closest to the sort direction.
		/// </summary>
		// Token: 0x06010BCB RID: 68555 RVA: 0x0017579D File Offset: 0x0017399D
		public virtual void SortScalarsOff()
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SortScalarsOff_33(base.GetCppThis());
		}

		// Token: 0x06010BCC RID: 68556
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDepthSortPolyData_SortScalarsOn_34(HandleRef pThis);

		/// <summary>
		/// Set/Get a flag that controls the generation of scalar values
		/// corresponding to the sort order. If enabled, the output of this
		/// filter will include scalar values that range from 0 to (ncells-1),
		/// where 0 is closest to the sort direction.
		/// </summary>
		// Token: 0x06010BCD RID: 68557 RVA: 0x001757AC File Offset: 0x001739AC
		public virtual void SortScalarsOn()
		{
			vtkDepthSortPolyData.vtkDepthSortPolyData_SortScalarsOn_34(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400135C RID: 4956
		public new const string MRFullTypeName = "Kitware.VTK.vtkDepthSortPolyData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400135D RID: 4957
		public new static readonly string MRClassNameKey = "class vtkDepthSortPolyData";

		/// <summary>
		/// Instantiate object.
		/// </summary>
		// Token: 0x02000604 RID: 1540
		public enum Directions
		{
			/// <summary>enum member</summary>
			// Token: 0x0400135F RID: 4959
			VTK_DIRECTION_BACK_TO_FRONT,
			/// <summary>enum member</summary>
			// Token: 0x04001360 RID: 4960
			VTK_DIRECTION_FRONT_TO_BACK,
			/// <summary>enum member</summary>
			// Token: 0x04001361 RID: 4961
			VTK_DIRECTION_SPECIFIED_VECTOR
		}

		/// <summary>
		/// Specify the sort method for the polygonal primitives. By default, the
		/// poly data is sorted from back to front.
		/// </summary>
		// Token: 0x02000605 RID: 1541
		public enum SortMode
		{
			/// <summary>enum member</summary>
			// Token: 0x04001363 RID: 4963
			VTK_SORT_BOUNDS_CENTER = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001364 RID: 4964
			VTK_SORT_FIRST_POINT = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001365 RID: 4965
			VTK_SORT_PARAMETRIC_CENTER = 2
		}
	}
}
