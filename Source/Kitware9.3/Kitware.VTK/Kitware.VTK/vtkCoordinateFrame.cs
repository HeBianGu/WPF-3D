using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCoordinateFrame
	/// </summary>
	/// <remarks>
	///    implicit function for a right-handed coordinate system
	///
	/// vtkCoordinateFrame computes an implicit function and function gradient
	/// for a set of 3 orthogonal planes.
	///
	/// The function evaluates to a combination of quartic spherical harmonic
	/// basis functions:
	/// \f$\sqrt(\frac{7}{12})*Y_{4,0} + \sqrt(\frac{5}{12})*Y_{4,4}\f$
	/// that – when evaluated on a unit sphere centered at the coordinate frame's
	/// origin – form a 6-lobed function with a maximum along each of the
	/// 6 axes (3 positive, 3 negative).
	/// This function is frequently used in frame-field design.
	///
	/// See the paper "On Smooth Frame Field Design" by Nicolas Ray and
	/// Dmitry Sokolov (2016, hal-01245657,
	/// https://hal.inria.fr/hal-01245657/file/framefield.pdf ) for more
	/// information.
	/// </remarks>
	// Token: 0x02000A33 RID: 2611
	public class vtkCoordinateFrame : vtkImplicitFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B328 RID: 111400 RVA: 0x0025FF49 File Offset: 0x0025E149
		static vtkCoordinateFrame()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCoordinateFrame.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCoordinateFrame"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B329 RID: 111401 RVA: 0x0025FF71 File Offset: 0x0025E171
		public vtkCoordinateFrame(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B32A RID: 111402
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrame_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601B32B RID: 111403 RVA: 0x0025FF80 File Offset: 0x0025E180
		public new static vtkCoordinateFrame New()
		{
			vtkCoordinateFrame result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinateFrame.vtkCoordinateFrame_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCoordinateFrame)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601B32C RID: 111404 RVA: 0x0025FFD4 File Offset: 0x0025E1D4
		public vtkCoordinateFrame() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCoordinateFrame.vtkCoordinateFrame_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B32D RID: 111405 RVA: 0x00260018 File Offset: 0x0025E218
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B32E RID: 111406
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCoordinateFrame_EvaluateFunction_01(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Evaluate plane equations. Return largest value (i.e., an intersection
		/// operation between all planes).
		/// </summary>
		// Token: 0x0601B32F RID: 111407 RVA: 0x00260024 File Offset: 0x0025E224
		public override double EvaluateFunction(IntPtr x)
		{
			return vtkCoordinateFrame.vtkCoordinateFrame_EvaluateFunction_01(base.GetCppThis(), x);
		}

		// Token: 0x0601B330 RID: 111408
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrame_EvaluateGradient_02(HandleRef pThis, IntPtr x, IntPtr n);

		/// <summary>
		/// Evaluate coordinate frame gradient.
		///
		/// \a n is the output gradient evaluated at point \a x.
		/// </summary>
		// Token: 0x0601B331 RID: 111409 RVA: 0x00260044 File Offset: 0x0025E244
		public override void EvaluateGradient(IntPtr x, IntPtr n)
		{
			vtkCoordinateFrame.vtkCoordinateFrame_EvaluateGradient_02(base.GetCppThis(), x, n);
		}

		// Token: 0x0601B332 RID: 111410
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCoordinateFrame_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601B333 RID: 111411 RVA: 0x00260058 File Offset: 0x0025E258
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCoordinateFrame.vtkCoordinateFrame_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601B334 RID: 111412
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCoordinateFrame_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601B335 RID: 111413 RVA: 0x00260078 File Offset: 0x0025E278
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCoordinateFrame.vtkCoordinateFrame_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601B336 RID: 111414
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrame_GetOrigin_05(HandleRef pThis);

		/// <summary>
		/// Specify the point through which all 3 planes pass.
		/// </summary>
		// Token: 0x0601B337 RID: 111415 RVA: 0x00260094 File Offset: 0x0025E294
		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkCoordinateFrame.vtkCoordinateFrame_GetOrigin_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601B338 RID: 111416
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrame_GetOrigin_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Specify the point through which all 3 planes pass.
		/// </summary>
		// Token: 0x0601B339 RID: 111417 RVA: 0x002600DC File Offset: 0x0025E2DC
		public virtual void GetOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCoordinateFrame.vtkCoordinateFrame_GetOrigin_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0601B33A RID: 111418
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrame_GetOrigin_07(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the point through which all 3 planes pass.
		/// </summary>
		// Token: 0x0601B33B RID: 111419 RVA: 0x002600EE File Offset: 0x0025E2EE
		public virtual void GetOrigin(IntPtr _arg)
		{
			vtkCoordinateFrame.vtkCoordinateFrame_GetOrigin_07(base.GetCppThis(), _arg);
		}

		// Token: 0x0601B33C RID: 111420
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrame_GetXAxis_08(HandleRef pThis);

		/// <summary>
		/// Specify a list of unit-length normal vectors for each plane.
		/// </summary>
		// Token: 0x0601B33D RID: 111421 RVA: 0x00260100 File Offset: 0x0025E300
		public virtual double[] GetXAxis()
		{
			IntPtr intPtr = vtkCoordinateFrame.vtkCoordinateFrame_GetXAxis_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601B33E RID: 111422
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrame_GetXAxis_09(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Specify a list of unit-length normal vectors for each plane.
		/// </summary>
		// Token: 0x0601B33F RID: 111423 RVA: 0x00260148 File Offset: 0x0025E348
		public virtual void GetXAxis(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCoordinateFrame.vtkCoordinateFrame_GetXAxis_09(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0601B340 RID: 111424
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrame_GetXAxis_10(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify a list of unit-length normal vectors for each plane.
		/// </summary>
		// Token: 0x0601B341 RID: 111425 RVA: 0x0026015A File Offset: 0x0025E35A
		public virtual void GetXAxis(IntPtr _arg)
		{
			vtkCoordinateFrame.vtkCoordinateFrame_GetXAxis_10(base.GetCppThis(), _arg);
		}

		// Token: 0x0601B342 RID: 111426
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrame_GetYAxis_11(HandleRef pThis);

		/// <summary>
		/// Specify a list of unit-length normal vectors for each plane.
		/// </summary>
		// Token: 0x0601B343 RID: 111427 RVA: 0x0026016C File Offset: 0x0025E36C
		public virtual double[] GetYAxis()
		{
			IntPtr intPtr = vtkCoordinateFrame.vtkCoordinateFrame_GetYAxis_11(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601B344 RID: 111428
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrame_GetYAxis_12(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Specify a list of unit-length normal vectors for each plane.
		/// </summary>
		// Token: 0x0601B345 RID: 111429 RVA: 0x002601B4 File Offset: 0x0025E3B4
		public virtual void GetYAxis(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCoordinateFrame.vtkCoordinateFrame_GetYAxis_12(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0601B346 RID: 111430
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrame_GetYAxis_13(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify a list of unit-length normal vectors for each plane.
		/// </summary>
		// Token: 0x0601B347 RID: 111431 RVA: 0x002601C6 File Offset: 0x0025E3C6
		public virtual void GetYAxis(IntPtr _arg)
		{
			vtkCoordinateFrame.vtkCoordinateFrame_GetYAxis_13(base.GetCppThis(), _arg);
		}

		// Token: 0x0601B348 RID: 111432
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrame_GetZAxis_14(HandleRef pThis);

		/// <summary>
		/// Specify a list of unit-length normal vectors for each plane.
		/// </summary>
		// Token: 0x0601B349 RID: 111433 RVA: 0x002601D8 File Offset: 0x0025E3D8
		public virtual double[] GetZAxis()
		{
			IntPtr intPtr = vtkCoordinateFrame.vtkCoordinateFrame_GetZAxis_14(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601B34A RID: 111434
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrame_GetZAxis_15(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Specify a list of unit-length normal vectors for each plane.
		/// </summary>
		// Token: 0x0601B34B RID: 111435 RVA: 0x00260220 File Offset: 0x0025E420
		public virtual void GetZAxis(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCoordinateFrame.vtkCoordinateFrame_GetZAxis_15(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0601B34C RID: 111436
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrame_GetZAxis_16(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify a list of unit-length normal vectors for each plane.
		/// </summary>
		// Token: 0x0601B34D RID: 111437 RVA: 0x00260232 File Offset: 0x0025E432
		public virtual void GetZAxis(IntPtr _arg)
		{
			vtkCoordinateFrame.vtkCoordinateFrame_GetZAxis_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0601B34E RID: 111438
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCoordinateFrame_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601B34F RID: 111439 RVA: 0x00260244 File Offset: 0x0025E444
		public override int IsA(string type)
		{
			return vtkCoordinateFrame.vtkCoordinateFrame_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x0601B350 RID: 111440
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCoordinateFrame_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601B351 RID: 111441 RVA: 0x00260264 File Offset: 0x0025E464
		public new static int IsTypeOf(string type)
		{
			return vtkCoordinateFrame.vtkCoordinateFrame_IsTypeOf_18(type);
		}

		// Token: 0x0601B352 RID: 111442
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrame_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601B353 RID: 111443 RVA: 0x00260280 File Offset: 0x0025E480
		public new vtkCoordinateFrame NewInstance()
		{
			vtkCoordinateFrame result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinateFrame.vtkCoordinateFrame_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCoordinateFrame)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B354 RID: 111444
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrame_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601B355 RID: 111445 RVA: 0x002602DC File Offset: 0x0025E4DC
		public new static vtkCoordinateFrame SafeDownCast(vtkObjectBase o)
		{
			vtkCoordinateFrame vtkCoordinateFrame = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinateFrame.vtkCoordinateFrame_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoordinateFrame = (vtkCoordinateFrame)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoordinateFrame.Register(null);
				}
			}
			return vtkCoordinateFrame;
		}

		// Token: 0x0601B356 RID: 111446
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrame_SetOrigin_22(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Specify the point through which all 3 planes pass.
		/// </summary>
		// Token: 0x0601B357 RID: 111447 RVA: 0x0026035B File Offset: 0x0025E55B
		public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkCoordinateFrame.vtkCoordinateFrame_SetOrigin_22(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601B358 RID: 111448
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrame_SetOrigin_23(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the point through which all 3 planes pass.
		/// </summary>
		// Token: 0x0601B359 RID: 111449 RVA: 0x0026036D File Offset: 0x0025E56D
		public virtual void SetOrigin(IntPtr _arg)
		{
			vtkCoordinateFrame.vtkCoordinateFrame_SetOrigin_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0601B35A RID: 111450
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrame_SetXAxis_24(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Specify a list of unit-length normal vectors for each plane.
		/// </summary>
		// Token: 0x0601B35B RID: 111451 RVA: 0x0026037D File Offset: 0x0025E57D
		public virtual void SetXAxis(double _arg1, double _arg2, double _arg3)
		{
			vtkCoordinateFrame.vtkCoordinateFrame_SetXAxis_24(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601B35C RID: 111452
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrame_SetXAxis_25(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify a list of unit-length normal vectors for each plane.
		/// </summary>
		// Token: 0x0601B35D RID: 111453 RVA: 0x0026038F File Offset: 0x0025E58F
		public virtual void SetXAxis(IntPtr _arg)
		{
			vtkCoordinateFrame.vtkCoordinateFrame_SetXAxis_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0601B35E RID: 111454
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrame_SetYAxis_26(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Specify a list of unit-length normal vectors for each plane.
		/// </summary>
		// Token: 0x0601B35F RID: 111455 RVA: 0x0026039F File Offset: 0x0025E59F
		public virtual void SetYAxis(double _arg1, double _arg2, double _arg3)
		{
			vtkCoordinateFrame.vtkCoordinateFrame_SetYAxis_26(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601B360 RID: 111456
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrame_SetYAxis_27(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify a list of unit-length normal vectors for each plane.
		/// </summary>
		// Token: 0x0601B361 RID: 111457 RVA: 0x002603B1 File Offset: 0x0025E5B1
		public virtual void SetYAxis(IntPtr _arg)
		{
			vtkCoordinateFrame.vtkCoordinateFrame_SetYAxis_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0601B362 RID: 111458
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrame_SetZAxis_28(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Specify a list of unit-length normal vectors for each plane.
		/// </summary>
		// Token: 0x0601B363 RID: 111459 RVA: 0x002603C1 File Offset: 0x0025E5C1
		public virtual void SetZAxis(double _arg1, double _arg2, double _arg3)
		{
			vtkCoordinateFrame.vtkCoordinateFrame_SetZAxis_28(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601B364 RID: 111460
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrame_SetZAxis_29(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify a list of unit-length normal vectors for each plane.
		/// </summary>
		// Token: 0x0601B365 RID: 111461 RVA: 0x002603D3 File Offset: 0x0025E5D3
		public virtual void SetZAxis(IntPtr _arg)
		{
			vtkCoordinateFrame.vtkCoordinateFrame_SetZAxis_29(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D59 RID: 7513
		public new const string MRFullTypeName = "Kitware.VTK.vtkCoordinateFrame";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D5A RID: 7514
		public new static readonly string MRClassNameKey = "class vtkCoordinateFrame";
	}
}
