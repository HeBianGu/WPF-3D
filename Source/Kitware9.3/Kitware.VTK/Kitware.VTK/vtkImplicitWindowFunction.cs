using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImplicitWindowFunction
	/// </summary>
	/// <remarks>
	///    implicit function maps another implicit function to lie within a specified range
	///
	/// vtkImplicitWindowFunction is used to modify the output of another
	/// implicit function to lie within a specified "window", or function
	/// range. This can be used to add "thickness" to cutting or clipping
	/// functions.
	///
	/// This class works as follows. First, it evaluates the function value of the
	/// user-specified implicit function. Then, based on the window range specified,
	/// it maps the function value into the window values specified.
	///
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImplicitFunction
	/// </seealso>
	// Token: 0x02000A6D RID: 2669
	public class vtkImplicitWindowFunction : vtkImplicitFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601BF07 RID: 114439 RVA: 0x002723BF File Offset: 0x002705BF
		static vtkImplicitWindowFunction()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitWindowFunction.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitWindowFunction"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601BF08 RID: 114440 RVA: 0x002723E7 File Offset: 0x002705E7
		public vtkImplicitWindowFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601BF09 RID: 114441
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitWindowFunction_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with window range (0,1) and window values (0,1).
		/// </summary>
		// Token: 0x0601BF0A RID: 114442 RVA: 0x002723F8 File Offset: 0x002705F8
		public new static vtkImplicitWindowFunction New()
		{
			vtkImplicitWindowFunction result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitWindowFunction.vtkImplicitWindowFunction_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitWindowFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with window range (0,1) and window values (0,1).
		/// </summary>
		// Token: 0x0601BF0B RID: 114443 RVA: 0x0027244C File Offset: 0x0027064C
		public vtkImplicitWindowFunction() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImplicitWindowFunction.vtkImplicitWindowFunction_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601BF0C RID: 114444 RVA: 0x00272490 File Offset: 0x00270690
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601BF0D RID: 114445
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitWindowFunction_EvaluateFunction_01(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Evaluate window function.
		/// </summary>
		// Token: 0x0601BF0E RID: 114446 RVA: 0x0027249C File Offset: 0x0027069C
		public override double EvaluateFunction(IntPtr x)
		{
			return vtkImplicitWindowFunction.vtkImplicitWindowFunction_EvaluateFunction_01(base.GetCppThis(), x);
		}

		// Token: 0x0601BF0F RID: 114447
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitWindowFunction_EvaluateGradient_02(HandleRef pThis, IntPtr x, IntPtr n);

		/// <summary>
		/// Evaluate window function gradient. Just return implicit function gradient.
		/// </summary>
		// Token: 0x0601BF10 RID: 114448 RVA: 0x002724BC File Offset: 0x002706BC
		public override void EvaluateGradient(IntPtr x, IntPtr n)
		{
			vtkImplicitWindowFunction.vtkImplicitWindowFunction_EvaluateGradient_02(base.GetCppThis(), x, n);
		}

		// Token: 0x0601BF11 RID: 114449
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitWindowFunction_GetImplicitFunction_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify an implicit function to operate on.
		/// </summary>
		// Token: 0x0601BF12 RID: 114450 RVA: 0x002724D0 File Offset: 0x002706D0
		public virtual vtkImplicitFunction GetImplicitFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitWindowFunction.vtkImplicitWindowFunction_GetImplicitFunction_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunction = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunction.Register(null);
				}
			}
			return vtkImplicitFunction;
		}

		// Token: 0x0601BF13 RID: 114451
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkImplicitWindowFunction_GetMTime_04(HandleRef pThis);

		/// <summary>
		/// Override modified time retrieval because of object dependencies.
		/// </summary>
		// Token: 0x0601BF14 RID: 114452 RVA: 0x00272540 File Offset: 0x00270740
		public override ulong GetMTime()
		{
			return vtkImplicitWindowFunction.vtkImplicitWindowFunction_GetMTime_04(base.GetCppThis());
		}

		// Token: 0x0601BF15 RID: 114453
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitWindowFunction_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BF16 RID: 114454 RVA: 0x00272560 File Offset: 0x00270760
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImplicitWindowFunction.vtkImplicitWindowFunction_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601BF17 RID: 114455
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitWindowFunction_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BF18 RID: 114456 RVA: 0x00272580 File Offset: 0x00270780
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImplicitWindowFunction.vtkImplicitWindowFunction_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601BF19 RID: 114457
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitWindowFunction_GetWindowRange_07(HandleRef pThis);

		/// <summary>
		/// Specify the range of function values which are considered to lie within
		/// the window. WindowRange[0] is assumed to be less than WindowRange[1].
		/// </summary>
		// Token: 0x0601BF1A RID: 114458 RVA: 0x0027259C File Offset: 0x0027079C
		public virtual double[] GetWindowRange()
		{
			IntPtr intPtr = vtkImplicitWindowFunction.vtkImplicitWindowFunction_GetWindowRange_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601BF1B RID: 114459
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitWindowFunction_GetWindowRange_08(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the range of function values which are considered to lie within
		/// the window. WindowRange[0] is assumed to be less than WindowRange[1].
		/// </summary>
		// Token: 0x0601BF1C RID: 114460 RVA: 0x002725E4 File Offset: 0x002707E4
		public virtual void GetWindowRange(IntPtr data)
		{
			vtkImplicitWindowFunction.vtkImplicitWindowFunction_GetWindowRange_08(base.GetCppThis(), data);
		}

		// Token: 0x0601BF1D RID: 114461
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitWindowFunction_GetWindowValues_09(HandleRef pThis);

		/// <summary>
		/// Specify the range of output values that the window range is mapped
		/// into. This is effectively a scaling and shifting of the original
		/// function values.
		/// </summary>
		// Token: 0x0601BF1E RID: 114462 RVA: 0x002725F4 File Offset: 0x002707F4
		public virtual double[] GetWindowValues()
		{
			IntPtr intPtr = vtkImplicitWindowFunction.vtkImplicitWindowFunction_GetWindowValues_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601BF1F RID: 114463
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitWindowFunction_GetWindowValues_10(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the range of output values that the window range is mapped
		/// into. This is effectively a scaling and shifting of the original
		/// function values.
		/// </summary>
		// Token: 0x0601BF20 RID: 114464 RVA: 0x0027263C File Offset: 0x0027083C
		public virtual void GetWindowValues(IntPtr data)
		{
			vtkImplicitWindowFunction.vtkImplicitWindowFunction_GetWindowValues_10(base.GetCppThis(), data);
		}

		// Token: 0x0601BF21 RID: 114465
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitWindowFunction_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BF22 RID: 114466 RVA: 0x0027264C File Offset: 0x0027084C
		public override int IsA(string type)
		{
			return vtkImplicitWindowFunction.vtkImplicitWindowFunction_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0601BF23 RID: 114467
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitWindowFunction_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BF24 RID: 114468 RVA: 0x0027266C File Offset: 0x0027086C
		public new static int IsTypeOf(string type)
		{
			return vtkImplicitWindowFunction.vtkImplicitWindowFunction_IsTypeOf_12(type);
		}

		// Token: 0x0601BF25 RID: 114469
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitWindowFunction_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BF26 RID: 114470 RVA: 0x00272688 File Offset: 0x00270888
		public new vtkImplicitWindowFunction NewInstance()
		{
			vtkImplicitWindowFunction result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitWindowFunction.vtkImplicitWindowFunction_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitWindowFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601BF27 RID: 114471
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitWindowFunction_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BF28 RID: 114472 RVA: 0x002726E4 File Offset: 0x002708E4
		public new static vtkImplicitWindowFunction SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitWindowFunction vtkImplicitWindowFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitWindowFunction.vtkImplicitWindowFunction_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitWindowFunction = (vtkImplicitWindowFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitWindowFunction.Register(null);
				}
			}
			return vtkImplicitWindowFunction;
		}

		// Token: 0x0601BF29 RID: 114473
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitWindowFunction_SetImplicitFunction_16(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify an implicit function to operate on.
		/// </summary>
		// Token: 0x0601BF2A RID: 114474 RVA: 0x00272764 File Offset: 0x00270964
		public virtual void SetImplicitFunction(vtkImplicitFunction arg0)
		{
			vtkImplicitWindowFunction.vtkImplicitWindowFunction_SetImplicitFunction_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601BF2B RID: 114475
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitWindowFunction_SetWindowRange_17(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Specify the range of function values which are considered to lie within
		/// the window. WindowRange[0] is assumed to be less than WindowRange[1].
		/// </summary>
		// Token: 0x0601BF2C RID: 114476 RVA: 0x00272793 File Offset: 0x00270993
		public virtual void SetWindowRange(double _arg1, double _arg2)
		{
			vtkImplicitWindowFunction.vtkImplicitWindowFunction_SetWindowRange_17(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0601BF2D RID: 114477
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitWindowFunction_SetWindowRange_18(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the range of function values which are considered to lie within
		/// the window. WindowRange[0] is assumed to be less than WindowRange[1].
		/// </summary>
		// Token: 0x0601BF2E RID: 114478 RVA: 0x002727A4 File Offset: 0x002709A4
		public void SetWindowRange(IntPtr _arg)
		{
			vtkImplicitWindowFunction.vtkImplicitWindowFunction_SetWindowRange_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0601BF2F RID: 114479
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitWindowFunction_SetWindowValues_19(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Specify the range of output values that the window range is mapped
		/// into. This is effectively a scaling and shifting of the original
		/// function values.
		/// </summary>
		// Token: 0x0601BF30 RID: 114480 RVA: 0x002727B4 File Offset: 0x002709B4
		public virtual void SetWindowValues(double _arg1, double _arg2)
		{
			vtkImplicitWindowFunction.vtkImplicitWindowFunction_SetWindowValues_19(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0601BF31 RID: 114481
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitWindowFunction_SetWindowValues_20(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the range of output values that the window range is mapped
		/// into. This is effectively a scaling and shifting of the original
		/// function values.
		/// </summary>
		// Token: 0x0601BF32 RID: 114482 RVA: 0x002727C5 File Offset: 0x002709C5
		public void SetWindowValues(IntPtr _arg)
		{
			vtkImplicitWindowFunction.vtkImplicitWindowFunction_SetWindowValues_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0601BF33 RID: 114483
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImplicitWindowFunction_UsesGarbageCollector_21(HandleRef pThis);

		/// <summary>
		/// Participate in garbage collection.
		/// </summary>
		// Token: 0x0601BF34 RID: 114484 RVA: 0x002727D8 File Offset: 0x002709D8
		public override bool UsesGarbageCollector()
		{
			return vtkImplicitWindowFunction.vtkImplicitWindowFunction_UsesGarbageCollector_21(base.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DD1 RID: 7633
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitWindowFunction";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DD2 RID: 7634
		public new static readonly string MRClassNameKey = "class vtkImplicitWindowFunction";
	}
}
