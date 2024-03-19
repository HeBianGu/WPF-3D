using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImplicitSum
	/// </summary>
	/// <remarks>
	///    implicit sum of other implicit functions
	///
	/// vtkImplicitSum produces a linear combination of other implicit functions.
	/// The contribution of each function is weighted by a scalar coefficient.
	/// The NormalizeByWeight option normalizes the output so that the
	/// scalar weights add up to 1. Note that this function gives accurate
	/// sums and gradients only if the input functions are linear.
	/// </remarks>
	// Token: 0x02000A6B RID: 2667
	public class vtkImplicitSum : vtkImplicitFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601BEB5 RID: 114357 RVA: 0x00271C6D File Offset: 0x0026FE6D
		static vtkImplicitSum()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitSum.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitSum"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601BEB6 RID: 114358 RVA: 0x00271C95 File Offset: 0x0026FE95
		public vtkImplicitSum(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601BEB7 RID: 114359
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitSum_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BEB8 RID: 114360 RVA: 0x00271CA4 File Offset: 0x0026FEA4
		public new static vtkImplicitSum New()
		{
			vtkImplicitSum result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitSum.vtkImplicitSum_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitSum)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BEB9 RID: 114361 RVA: 0x00271CF8 File Offset: 0x0026FEF8
		public vtkImplicitSum() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImplicitSum.vtkImplicitSum_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601BEBA RID: 114362 RVA: 0x00271D3C File Offset: 0x0026FF3C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601BEBB RID: 114363
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitSum_AddFunction_01(HandleRef pThis, HandleRef arg0, double weight);

		/// <summary>
		/// Add another implicit function to the list of functions, along with a
		/// weighting factor.
		/// </summary>
		// Token: 0x0601BEBC RID: 114364 RVA: 0x00271D48 File Offset: 0x0026FF48
		public void AddFunction(vtkImplicitFunction arg0, double weight)
		{
			vtkImplicitSum.vtkImplicitSum_AddFunction_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), weight);
		}

		// Token: 0x0601BEBD RID: 114365
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitSum_AddFunction_02(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Add another implicit function to the list of functions, weighting it by
		/// a factor of 1.
		/// </summary>
		// Token: 0x0601BEBE RID: 114366 RVA: 0x00271D78 File Offset: 0x0026FF78
		public void AddFunction(vtkImplicitFunction arg0)
		{
			vtkImplicitSum.vtkImplicitSum_AddFunction_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601BEBF RID: 114367
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitSum_EvaluateFunction_03(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Evaluate implicit function using current functions and weights.
		/// </summary>
		// Token: 0x0601BEC0 RID: 114368 RVA: 0x00271DA8 File Offset: 0x0026FFA8
		public override double EvaluateFunction(IntPtr x)
		{
			return vtkImplicitSum.vtkImplicitSum_EvaluateFunction_03(base.GetCppThis(), x);
		}

		// Token: 0x0601BEC1 RID: 114369
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitSum_EvaluateGradient_04(HandleRef pThis, IntPtr x, IntPtr g);

		/// <summary>
		/// Evaluate gradient of the weighted sum of functions.  Input functions
		/// should be linear.
		/// </summary>
		// Token: 0x0601BEC2 RID: 114370 RVA: 0x00271DC8 File Offset: 0x0026FFC8
		public override void EvaluateGradient(IntPtr x, IntPtr g)
		{
			vtkImplicitSum.vtkImplicitSum_EvaluateGradient_04(base.GetCppThis(), x, g);
		}

		// Token: 0x0601BEC3 RID: 114371
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkImplicitSum_GetMTime_05(HandleRef pThis);

		/// <summary>
		/// Override modified time retrieval because of object dependencies.
		/// </summary>
		// Token: 0x0601BEC4 RID: 114372 RVA: 0x00271DDC File Offset: 0x0026FFDC
		public override ulong GetMTime()
		{
			return vtkImplicitSum.vtkImplicitSum_GetMTime_05(base.GetCppThis());
		}

		// Token: 0x0601BEC5 RID: 114373
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitSum_GetNormalizeByWeight_06(HandleRef pThis);

		/// <summary>
		/// When calculating the function and gradient values of the
		/// composite function, setting NormalizeByWeight on will divide the
		/// final result by the total weight of the component functions.
		/// This process does not otherwise normalize the gradient vector.
		/// By default, NormalizeByWeight is off.
		/// </summary>
		// Token: 0x0601BEC6 RID: 114374 RVA: 0x00271DFC File Offset: 0x0026FFFC
		public virtual int GetNormalizeByWeight()
		{
			return vtkImplicitSum.vtkImplicitSum_GetNormalizeByWeight_06(base.GetCppThis());
		}

		// Token: 0x0601BEC7 RID: 114375
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitSum_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BEC8 RID: 114376 RVA: 0x00271E1C File Offset: 0x0027001C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImplicitSum.vtkImplicitSum_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601BEC9 RID: 114377
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitSum_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BECA RID: 114378 RVA: 0x00271E3C File Offset: 0x0027003C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImplicitSum.vtkImplicitSum_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0601BECB RID: 114379
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitSum_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BECC RID: 114380 RVA: 0x00271E58 File Offset: 0x00270058
		public override int IsA(string type)
		{
			return vtkImplicitSum.vtkImplicitSum_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0601BECD RID: 114381
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitSum_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BECE RID: 114382 RVA: 0x00271E78 File Offset: 0x00270078
		public new static int IsTypeOf(string type)
		{
			return vtkImplicitSum.vtkImplicitSum_IsTypeOf_10(type);
		}

		// Token: 0x0601BECF RID: 114383
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitSum_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BED0 RID: 114384 RVA: 0x00271E94 File Offset: 0x00270094
		public new vtkImplicitSum NewInstance()
		{
			vtkImplicitSum result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitSum.vtkImplicitSum_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitSum)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601BED1 RID: 114385
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitSum_NormalizeByWeightOff_13(HandleRef pThis);

		/// <summary>
		/// When calculating the function and gradient values of the
		/// composite function, setting NormalizeByWeight on will divide the
		/// final result by the total weight of the component functions.
		/// This process does not otherwise normalize the gradient vector.
		/// By default, NormalizeByWeight is off.
		/// </summary>
		// Token: 0x0601BED2 RID: 114386 RVA: 0x00271EEE File Offset: 0x002700EE
		public virtual void NormalizeByWeightOff()
		{
			vtkImplicitSum.vtkImplicitSum_NormalizeByWeightOff_13(base.GetCppThis());
		}

		// Token: 0x0601BED3 RID: 114387
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitSum_NormalizeByWeightOn_14(HandleRef pThis);

		/// <summary>
		/// When calculating the function and gradient values of the
		/// composite function, setting NormalizeByWeight on will divide the
		/// final result by the total weight of the component functions.
		/// This process does not otherwise normalize the gradient vector.
		/// By default, NormalizeByWeight is off.
		/// </summary>
		// Token: 0x0601BED4 RID: 114388 RVA: 0x00271EFD File Offset: 0x002700FD
		public virtual void NormalizeByWeightOn()
		{
			vtkImplicitSum.vtkImplicitSum_NormalizeByWeightOn_14(base.GetCppThis());
		}

		// Token: 0x0601BED5 RID: 114389
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitSum_RemoveAllFunctions_15(HandleRef pThis);

		/// <summary>
		/// Remove all functions from the list.
		/// </summary>
		// Token: 0x0601BED6 RID: 114390 RVA: 0x00271F0C File Offset: 0x0027010C
		public void RemoveAllFunctions()
		{
			vtkImplicitSum.vtkImplicitSum_RemoveAllFunctions_15(base.GetCppThis());
		}

		// Token: 0x0601BED7 RID: 114391
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitSum_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BED8 RID: 114392 RVA: 0x00271F1C File Offset: 0x0027011C
		public new static vtkImplicitSum SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitSum vtkImplicitSum = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitSum.vtkImplicitSum_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitSum = (vtkImplicitSum)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitSum.Register(null);
				}
			}
			return vtkImplicitSum;
		}

		// Token: 0x0601BED9 RID: 114393
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitSum_SetFunctionWeight_17(HandleRef pThis, HandleRef f, double weight);

		/// <summary>
		/// Set the weight (coefficient) of the given function to be weight.
		/// </summary>
		// Token: 0x0601BEDA RID: 114394 RVA: 0x00271F9C File Offset: 0x0027019C
		public void SetFunctionWeight(vtkImplicitFunction f, double weight)
		{
			vtkImplicitSum.vtkImplicitSum_SetFunctionWeight_17(base.GetCppThis(), (f == null) ? default(HandleRef) : f.GetCppThis(), weight);
		}

		// Token: 0x0601BEDB RID: 114395
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitSum_SetNormalizeByWeight_18(HandleRef pThis, int _arg);

		/// <summary>
		/// When calculating the function and gradient values of the
		/// composite function, setting NormalizeByWeight on will divide the
		/// final result by the total weight of the component functions.
		/// This process does not otherwise normalize the gradient vector.
		/// By default, NormalizeByWeight is off.
		/// </summary>
		// Token: 0x0601BEDC RID: 114396 RVA: 0x00271FCC File Offset: 0x002701CC
		public virtual void SetNormalizeByWeight(int _arg)
		{
			vtkImplicitSum.vtkImplicitSum_SetNormalizeByWeight_18(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DCD RID: 7629
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitSum";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DCE RID: 7630
		public new static readonly string MRClassNameKey = "class vtkImplicitSum";
	}
}
