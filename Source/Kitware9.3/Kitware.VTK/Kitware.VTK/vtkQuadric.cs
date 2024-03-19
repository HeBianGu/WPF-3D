using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkQuadric
	/// </summary>
	/// <remarks>
	///    evaluate implicit quadric function
	///
	/// vtkQuadric evaluates the quadric function F(x,y,z) = a0*x^2 + a1*y^2 +
	/// a2*z^2 + a3*x*y + a4*y*z + a5*x*z + a6*x + a7*y + a8*z + a9. vtkQuadric is
	/// a concrete implementation of vtkImplicitFunction.
	/// </remarks>
	// Token: 0x02000AB6 RID: 2742
	public class vtkQuadric : vtkImplicitFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601CDAC RID: 118188 RVA: 0x0028A2D8 File Offset: 0x002884D8
		static vtkQuadric()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkQuadric.MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadric"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601CDAD RID: 118189 RVA: 0x0028A300 File Offset: 0x00288500
		public vtkQuadric(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601CDAE RID: 118190
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadric_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct quadric with all coefficients = 1.
		/// </summary>
		// Token: 0x0601CDAF RID: 118191 RVA: 0x0028A310 File Offset: 0x00288510
		public new static vtkQuadric New()
		{
			vtkQuadric result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadric.vtkQuadric_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct quadric with all coefficients = 1.
		/// </summary>
		// Token: 0x0601CDB0 RID: 118192 RVA: 0x0028A364 File Offset: 0x00288564
		public vtkQuadric() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkQuadric.vtkQuadric_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601CDB1 RID: 118193 RVA: 0x0028A3A8 File Offset: 0x002885A8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601CDB2 RID: 118194
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkQuadric_EvaluateFunction_01(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Evaluate quadric equation.
		/// </summary>
		// Token: 0x0601CDB3 RID: 118195 RVA: 0x0028A3B4 File Offset: 0x002885B4
		public override double EvaluateFunction(IntPtr x)
		{
			return vtkQuadric.vtkQuadric_EvaluateFunction_01(base.GetCppThis(), x);
		}

		// Token: 0x0601CDB4 RID: 118196
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadric_EvaluateGradient_02(HandleRef pThis, IntPtr x, IntPtr g);

		/// <summary>
		/// Evaluate the gradient to the quadric equation.
		/// </summary>
		// Token: 0x0601CDB5 RID: 118197 RVA: 0x0028A3D4 File Offset: 0x002885D4
		public override void EvaluateGradient(IntPtr x, IntPtr g)
		{
			vtkQuadric.vtkQuadric_EvaluateGradient_02(base.GetCppThis(), x, g);
		}

		// Token: 0x0601CDB6 RID: 118198
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadric_GetCoefficients_03(HandleRef pThis);

		/// <summary>
		/// Set / get the 10 coefficients of the quadric equation.
		/// </summary>
		// Token: 0x0601CDB7 RID: 118199 RVA: 0x0028A3E8 File Offset: 0x002885E8
		public virtual double[] GetCoefficients()
		{
			IntPtr intPtr = vtkQuadric.vtkQuadric_GetCoefficients_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[0];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601CDB8 RID: 118200
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadric_GetCoefficients_04(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set / get the 10 coefficients of the quadric equation.
		/// </summary>
		// Token: 0x0601CDB9 RID: 118201 RVA: 0x0028A430 File Offset: 0x00288630
		public virtual void GetCoefficients(IntPtr data)
		{
			vtkQuadric.vtkQuadric_GetCoefficients_04(base.GetCppThis(), data);
		}

		// Token: 0x0601CDBA RID: 118202
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadric_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CDBB RID: 118203 RVA: 0x0028A440 File Offset: 0x00288640
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkQuadric.vtkQuadric_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601CDBC RID: 118204
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadric_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CDBD RID: 118205 RVA: 0x0028A460 File Offset: 0x00288660
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkQuadric.vtkQuadric_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601CDBE RID: 118206
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadric_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CDBF RID: 118207 RVA: 0x0028A47C File Offset: 0x0028867C
		public override int IsA(string type)
		{
			return vtkQuadric.vtkQuadric_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601CDC0 RID: 118208
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadric_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CDC1 RID: 118209 RVA: 0x0028A49C File Offset: 0x0028869C
		public new static int IsTypeOf(string type)
		{
			return vtkQuadric.vtkQuadric_IsTypeOf_08(type);
		}

		// Token: 0x0601CDC2 RID: 118210
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadric_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CDC3 RID: 118211 RVA: 0x0028A4B8 File Offset: 0x002886B8
		public new vtkQuadric NewInstance()
		{
			vtkQuadric result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadric.vtkQuadric_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601CDC4 RID: 118212
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadric_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CDC5 RID: 118213 RVA: 0x0028A514 File Offset: 0x00288714
		public new static vtkQuadric SafeDownCast(vtkObjectBase o)
		{
			vtkQuadric vtkQuadric = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadric.vtkQuadric_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuadric = (vtkQuadric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuadric.Register(null);
				}
			}
			return vtkQuadric;
		}

		// Token: 0x0601CDC6 RID: 118214
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadric_SetCoefficients_12(HandleRef pThis, IntPtr a);

		/// <summary>
		/// Set / get the 10 coefficients of the quadric equation.
		/// </summary>
		// Token: 0x0601CDC7 RID: 118215 RVA: 0x0028A593 File Offset: 0x00288793
		public void SetCoefficients(IntPtr a)
		{
			vtkQuadric.vtkQuadric_SetCoefficients_12(base.GetCppThis(), a);
		}

		// Token: 0x0601CDC8 RID: 118216
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadric_SetCoefficients_13(HandleRef pThis, double a0, double a1, double a2, double a3, double a4, double a5, double a6, double a7, double a8, double a9);

		/// <summary>
		/// Set / get the 10 coefficients of the quadric equation.
		/// </summary>
		// Token: 0x0601CDC9 RID: 118217 RVA: 0x0028A5A4 File Offset: 0x002887A4
		public void SetCoefficients(double a0, double a1, double a2, double a3, double a4, double a5, double a6, double a7, double a8, double a9)
		{
			vtkQuadric.vtkQuadric_SetCoefficients_13(base.GetCppThis(), a0, a1, a2, a3, a4, a5, a6, a7, a8, a9);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E75 RID: 7797
		public new const string MRFullTypeName = "Kitware.VTK.vtkQuadric";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E76 RID: 7798
		public new static readonly string MRClassNameKey = "class vtkQuadric";
	}
}
