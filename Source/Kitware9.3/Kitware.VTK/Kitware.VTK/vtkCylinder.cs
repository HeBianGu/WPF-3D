using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCylinder
	/// </summary>
	/// <remarks>
	///    implicit function for a cylinder
	///
	/// vtkCylinder computes the implicit function and function gradient
	/// for a cylinder using F(r)=r^2-Radius^2. vtkCylinder is a concrete
	/// implementation of vtkImplicitFunction. By default the Cylinder is
	/// centered at the origin and the axis of rotation is along the
	/// y-axis. You can redefine the center and axis of rotation by setting
	/// the Center and Axis data members. (Note that it is also possible to
	/// use the superclass' vtkImplicitFunction transformation matrix if
	/// necessary to reposition by using FunctionValue() and
	/// FunctionGradient().)
	///
	/// @warning
	/// The cylinder is infinite in extent. To truncate the cylinder in
	/// modeling operations use the vtkImplicitBoolean in combination with
	/// clipping planes.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCylinderSource
	/// </seealso>
	// Token: 0x02000A35 RID: 2613
	public class vtkCylinder : vtkImplicitFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B3A2 RID: 111522 RVA: 0x00260A9D File Offset: 0x0025EC9D
		static vtkCylinder()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCylinder.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCylinder"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B3A3 RID: 111523 RVA: 0x00260AC5 File Offset: 0x0025ECC5
		public vtkCylinder(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B3A4 RID: 111524
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCylinder_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct cylinder radius of 0.5; centered at origin with axis
		/// along y coordinate axis.
		/// </summary>
		// Token: 0x0601B3A5 RID: 111525 RVA: 0x00260AD4 File Offset: 0x0025ECD4
		public new static vtkCylinder New()
		{
			vtkCylinder result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCylinder.vtkCylinder_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCylinder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct cylinder radius of 0.5; centered at origin with axis
		/// along y coordinate axis.
		/// </summary>
		// Token: 0x0601B3A6 RID: 111526 RVA: 0x00260B28 File Offset: 0x0025ED28
		public vtkCylinder() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCylinder.vtkCylinder_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B3A7 RID: 111527 RVA: 0x00260B6C File Offset: 0x0025ED6C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B3A8 RID: 111528
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCylinder_EvaluateFunction_01(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Evaluate cylinder equation F(r) = r^2 - Radius^2.
		/// </summary>
		// Token: 0x0601B3A9 RID: 111529 RVA: 0x00260B78 File Offset: 0x0025ED78
		public override double EvaluateFunction(IntPtr x)
		{
			return vtkCylinder.vtkCylinder_EvaluateFunction_01(base.GetCppThis(), x);
		}

		// Token: 0x0601B3AA RID: 111530
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCylinder_EvaluateGradient_02(HandleRef pThis, IntPtr x, IntPtr g);

		/// <summary>
		/// Evaluate cylinder function gradient.
		/// </summary>
		// Token: 0x0601B3AB RID: 111531 RVA: 0x00260B98 File Offset: 0x0025ED98
		public override void EvaluateGradient(IntPtr x, IntPtr g)
		{
			vtkCylinder.vtkCylinder_EvaluateGradient_02(base.GetCppThis(), x, g);
		}

		// Token: 0x0601B3AC RID: 111532
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCylinder_GetAxis_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the axis of the cylinder. If the axis is not specified as
		/// a unit vector, it will be normalized. If zero-length axis vector
		/// is used as input to this method, it will be ignored.
		/// </summary>
		// Token: 0x0601B3AD RID: 111533 RVA: 0x00260BAC File Offset: 0x0025EDAC
		public virtual double[] GetAxis()
		{
			IntPtr intPtr = vtkCylinder.vtkCylinder_GetAxis_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601B3AE RID: 111534
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCylinder_GetAxis_04(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the axis of the cylinder. If the axis is not specified as
		/// a unit vector, it will be normalized. If zero-length axis vector
		/// is used as input to this method, it will be ignored.
		/// </summary>
		// Token: 0x0601B3AF RID: 111535 RVA: 0x00260BF4 File Offset: 0x0025EDF4
		public virtual void GetAxis(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCylinder.vtkCylinder_GetAxis_04(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0601B3B0 RID: 111536
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCylinder_GetAxis_05(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the axis of the cylinder. If the axis is not specified as
		/// a unit vector, it will be normalized. If zero-length axis vector
		/// is used as input to this method, it will be ignored.
		/// </summary>
		// Token: 0x0601B3B1 RID: 111537 RVA: 0x00260C06 File Offset: 0x0025EE06
		public virtual void GetAxis(IntPtr _arg)
		{
			vtkCylinder.vtkCylinder_GetAxis_05(base.GetCppThis(), _arg);
		}

		// Token: 0x0601B3B2 RID: 111538
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCylinder_GetCenter_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the cylinder center.
		/// </summary>
		// Token: 0x0601B3B3 RID: 111539 RVA: 0x00260C18 File Offset: 0x0025EE18
		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkCylinder.vtkCylinder_GetCenter_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601B3B4 RID: 111540
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCylinder_GetCenter_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the cylinder center.
		/// </summary>
		// Token: 0x0601B3B5 RID: 111541 RVA: 0x00260C60 File Offset: 0x0025EE60
		public virtual void GetCenter(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCylinder.vtkCylinder_GetCenter_07(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0601B3B6 RID: 111542
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCylinder_GetCenter_08(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the cylinder center.
		/// </summary>
		// Token: 0x0601B3B7 RID: 111543 RVA: 0x00260C72 File Offset: 0x0025EE72
		public virtual void GetCenter(IntPtr _arg)
		{
			vtkCylinder.vtkCylinder_GetCenter_08(base.GetCppThis(), _arg);
		}

		// Token: 0x0601B3B8 RID: 111544
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCylinder_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B3B9 RID: 111545 RVA: 0x00260C84 File Offset: 0x0025EE84
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCylinder.vtkCylinder_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x0601B3BA RID: 111546
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCylinder_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B3BB RID: 111547 RVA: 0x00260CA4 File Offset: 0x0025EEA4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCylinder.vtkCylinder_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x0601B3BC RID: 111548
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCylinder_GetRadius_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the cylinder radius.
		/// </summary>
		// Token: 0x0601B3BD RID: 111549 RVA: 0x00260CC0 File Offset: 0x0025EEC0
		public virtual double GetRadius()
		{
			return vtkCylinder.vtkCylinder_GetRadius_11(base.GetCppThis());
		}

		// Token: 0x0601B3BE RID: 111550
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCylinder_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B3BF RID: 111551 RVA: 0x00260CE0 File Offset: 0x0025EEE0
		public override int IsA(string type)
		{
			return vtkCylinder.vtkCylinder_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0601B3C0 RID: 111552
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCylinder_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B3C1 RID: 111553 RVA: 0x00260D00 File Offset: 0x0025EF00
		public new static int IsTypeOf(string type)
		{
			return vtkCylinder.vtkCylinder_IsTypeOf_13(type);
		}

		// Token: 0x0601B3C2 RID: 111554
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCylinder_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B3C3 RID: 111555 RVA: 0x00260D1C File Offset: 0x0025EF1C
		public new vtkCylinder NewInstance()
		{
			vtkCylinder result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCylinder.vtkCylinder_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCylinder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B3C4 RID: 111556
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCylinder_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B3C5 RID: 111557 RVA: 0x00260D78 File Offset: 0x0025EF78
		public new static vtkCylinder SafeDownCast(vtkObjectBase o)
		{
			vtkCylinder vtkCylinder = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCylinder.vtkCylinder_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCylinder = (vtkCylinder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCylinder.Register(null);
				}
			}
			return vtkCylinder;
		}

		// Token: 0x0601B3C6 RID: 111558
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCylinder_SetAxis_17(HandleRef pThis, double ax, double ay, double az);

		/// <summary>
		/// Set/Get the axis of the cylinder. If the axis is not specified as
		/// a unit vector, it will be normalized. If zero-length axis vector
		/// is used as input to this method, it will be ignored.
		/// </summary>
		// Token: 0x0601B3C7 RID: 111559 RVA: 0x00260DF7 File Offset: 0x0025EFF7
		public void SetAxis(double ax, double ay, double az)
		{
			vtkCylinder.vtkCylinder_SetAxis_17(base.GetCppThis(), ax, ay, az);
		}

		// Token: 0x0601B3C8 RID: 111560
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCylinder_SetAxis_18(HandleRef pThis, IntPtr a);

		/// <summary>
		/// Set/Get the axis of the cylinder. If the axis is not specified as
		/// a unit vector, it will be normalized. If zero-length axis vector
		/// is used as input to this method, it will be ignored.
		/// </summary>
		// Token: 0x0601B3C9 RID: 111561 RVA: 0x00260E09 File Offset: 0x0025F009
		public void SetAxis(IntPtr a)
		{
			vtkCylinder.vtkCylinder_SetAxis_18(base.GetCppThis(), a);
		}

		// Token: 0x0601B3CA RID: 111562
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCylinder_SetCenter_19(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the cylinder center.
		/// </summary>
		// Token: 0x0601B3CB RID: 111563 RVA: 0x00260E19 File Offset: 0x0025F019
		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkCylinder.vtkCylinder_SetCenter_19(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601B3CC RID: 111564
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCylinder_SetCenter_20(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the cylinder center.
		/// </summary>
		// Token: 0x0601B3CD RID: 111565 RVA: 0x00260E2B File Offset: 0x0025F02B
		public virtual void SetCenter(IntPtr _arg)
		{
			vtkCylinder.vtkCylinder_SetCenter_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0601B3CE RID: 111566
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCylinder_SetRadius_21(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the cylinder radius.
		/// </summary>
		// Token: 0x0601B3CF RID: 111567 RVA: 0x00260E3B File Offset: 0x0025F03B
		public virtual void SetRadius(double _arg)
		{
			vtkCylinder.vtkCylinder_SetRadius_21(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D5D RID: 7517
		public new const string MRFullTypeName = "Kitware.VTK.vtkCylinder";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D5E RID: 7518
		public new static readonly string MRClassNameKey = "class vtkCylinder";
	}
}
