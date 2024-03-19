using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkKochanekSpline
	/// </summary>
	/// <remarks>
	///    computes an interpolating spline using a Kochanek basis.
	///
	/// Implements the Kochanek interpolating spline described in: Kochanek, D.,
	/// Bartels, R., "Interpolating Splines with Local Tension, Continuity, and
	/// Bias Control," Computer Graphics, vol. 18, no. 3, pp. 33-41, July 1984.
	/// These splines give the user more control over the shape of the curve than
	/// the cardinal splines implemented in vtkCardinalSpline. Three parameters
	/// can be specified. All have a range from -1 to 1.
	///
	/// Tension controls how sharply the curve bends at an input point. A
	/// value of -1 produces more slack in the curve. A value of 1 tightens
	/// the curve.
	///
	/// Continuity controls the continuity of the first derivative at input
	/// points.
	///
	/// Bias controls the direction of the curve at it passes through an input
	/// point. A value of -1 undershoots the point while a value of 1
	/// overshoots the point.
	///
	/// These three parameters give the user broad control over the shape of
	/// the interpolating spline. The original Kochanek paper describes the
	/// effects nicely and is recommended reading.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSpline vtkCardinalSpline
	/// </seealso>
	// Token: 0x0200091C RID: 2332
	public class vtkKochanekSpline : vtkSpline
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601828D RID: 98957 RVA: 0x0021CF4B File Offset: 0x0021B14B
		static vtkKochanekSpline()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkKochanekSpline.MRClassNameKey, Type.GetType("Kitware.VTK.vtkKochanekSpline"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601828E RID: 98958 RVA: 0x0021CF73 File Offset: 0x0021B173
		public vtkKochanekSpline(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601828F RID: 98959
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKochanekSpline_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a KochanekSpline with the following defaults: DefaultBias = 0,
		/// DefaultTension = 0, DefaultContinuity = 0.
		/// </summary>
		// Token: 0x06018290 RID: 98960 RVA: 0x0021CF84 File Offset: 0x0021B184
		public new static vtkKochanekSpline New()
		{
			vtkKochanekSpline result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKochanekSpline.vtkKochanekSpline_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKochanekSpline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a KochanekSpline with the following defaults: DefaultBias = 0,
		/// DefaultTension = 0, DefaultContinuity = 0.
		/// </summary>
		// Token: 0x06018291 RID: 98961 RVA: 0x0021CFD8 File Offset: 0x0021B1D8
		public vtkKochanekSpline() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkKochanekSpline.vtkKochanekSpline_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018292 RID: 98962 RVA: 0x0021D01C File Offset: 0x0021B21C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018293 RID: 98963
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKochanekSpline_Compute_01(HandleRef pThis);

		/// <summary>
		/// Compute Kochanek Spline coefficients.
		/// </summary>
		// Token: 0x06018294 RID: 98964 RVA: 0x0021D027 File Offset: 0x0021B227
		public override void Compute()
		{
			vtkKochanekSpline.vtkKochanekSpline_Compute_01(base.GetCppThis());
		}

		// Token: 0x06018295 RID: 98965
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKochanekSpline_DeepCopy_02(HandleRef pThis, HandleRef s);

		/// <summary>
		/// Deep copy of cardinal spline data.
		/// </summary>
		// Token: 0x06018296 RID: 98966 RVA: 0x0021D038 File Offset: 0x0021B238
		public override void DeepCopy(vtkSpline s)
		{
			vtkKochanekSpline.vtkKochanekSpline_DeepCopy_02(base.GetCppThis(), (s == null) ? default(HandleRef) : s.GetCppThis());
		}

		// Token: 0x06018297 RID: 98967
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkKochanekSpline_Evaluate_03(HandleRef pThis, double t);

		/// <summary>
		/// Evaluate a 1D Kochanek spline.
		/// </summary>
		// Token: 0x06018298 RID: 98968 RVA: 0x0021D068 File Offset: 0x0021B268
		public override double Evaluate(double t)
		{
			return vtkKochanekSpline.vtkKochanekSpline_Evaluate_03(base.GetCppThis(), t);
		}

		// Token: 0x06018299 RID: 98969
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkKochanekSpline_GetDefaultBias_04(HandleRef pThis);

		/// <summary>
		/// Set the bias for all points. Default is 0.
		/// </summary>
		// Token: 0x0601829A RID: 98970 RVA: 0x0021D088 File Offset: 0x0021B288
		public virtual double GetDefaultBias()
		{
			return vtkKochanekSpline.vtkKochanekSpline_GetDefaultBias_04(base.GetCppThis());
		}

		// Token: 0x0601829B RID: 98971
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkKochanekSpline_GetDefaultContinuity_05(HandleRef pThis);

		/// <summary>
		/// Set the continuity for all points. Default is 0.
		/// </summary>
		// Token: 0x0601829C RID: 98972 RVA: 0x0021D0A8 File Offset: 0x0021B2A8
		public virtual double GetDefaultContinuity()
		{
			return vtkKochanekSpline.vtkKochanekSpline_GetDefaultContinuity_05(base.GetCppThis());
		}

		// Token: 0x0601829D RID: 98973
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkKochanekSpline_GetDefaultTension_06(HandleRef pThis);

		/// <summary>
		/// Set the tension for all points. Default is 0.
		/// </summary>
		// Token: 0x0601829E RID: 98974 RVA: 0x0021D0C8 File Offset: 0x0021B2C8
		public virtual double GetDefaultTension()
		{
			return vtkKochanekSpline.vtkKochanekSpline_GetDefaultTension_06(base.GetCppThis());
		}

		// Token: 0x0601829F RID: 98975
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKochanekSpline_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060182A0 RID: 98976 RVA: 0x0021D0E8 File Offset: 0x0021B2E8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkKochanekSpline.vtkKochanekSpline_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x060182A1 RID: 98977
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKochanekSpline_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060182A2 RID: 98978 RVA: 0x0021D108 File Offset: 0x0021B308
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkKochanekSpline.vtkKochanekSpline_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x060182A3 RID: 98979
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKochanekSpline_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060182A4 RID: 98980 RVA: 0x0021D124 File Offset: 0x0021B324
		public override int IsA(string type)
		{
			return vtkKochanekSpline.vtkKochanekSpline_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x060182A5 RID: 98981
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKochanekSpline_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060182A6 RID: 98982 RVA: 0x0021D144 File Offset: 0x0021B344
		public new static int IsTypeOf(string type)
		{
			return vtkKochanekSpline.vtkKochanekSpline_IsTypeOf_10(type);
		}

		// Token: 0x060182A7 RID: 98983
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKochanekSpline_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060182A8 RID: 98984 RVA: 0x0021D160 File Offset: 0x0021B360
		public new vtkKochanekSpline NewInstance()
		{
			vtkKochanekSpline result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKochanekSpline.vtkKochanekSpline_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKochanekSpline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060182A9 RID: 98985
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKochanekSpline_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060182AA RID: 98986 RVA: 0x0021D1BC File Offset: 0x0021B3BC
		public new static vtkKochanekSpline SafeDownCast(vtkObjectBase o)
		{
			vtkKochanekSpline vtkKochanekSpline = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKochanekSpline.vtkKochanekSpline_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKochanekSpline = (vtkKochanekSpline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKochanekSpline.Register(null);
				}
			}
			return vtkKochanekSpline;
		}

		// Token: 0x060182AB RID: 98987
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKochanekSpline_SetDefaultBias_14(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the bias for all points. Default is 0.
		/// </summary>
		// Token: 0x060182AC RID: 98988 RVA: 0x0021D23B File Offset: 0x0021B43B
		public virtual void SetDefaultBias(double _arg)
		{
			vtkKochanekSpline.vtkKochanekSpline_SetDefaultBias_14(base.GetCppThis(), _arg);
		}

		// Token: 0x060182AD RID: 98989
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKochanekSpline_SetDefaultContinuity_15(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the continuity for all points. Default is 0.
		/// </summary>
		// Token: 0x060182AE RID: 98990 RVA: 0x0021D24B File Offset: 0x0021B44B
		public virtual void SetDefaultContinuity(double _arg)
		{
			vtkKochanekSpline.vtkKochanekSpline_SetDefaultContinuity_15(base.GetCppThis(), _arg);
		}

		// Token: 0x060182AF RID: 98991
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKochanekSpline_SetDefaultTension_16(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the tension for all points. Default is 0.
		/// </summary>
		// Token: 0x060182B0 RID: 98992 RVA: 0x0021D25B File Offset: 0x0021B45B
		public virtual void SetDefaultTension(double _arg)
		{
			vtkKochanekSpline.vtkKochanekSpline_SetDefaultTension_16(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AE2 RID: 6882
		public new const string MRFullTypeName = "Kitware.VTK.vtkKochanekSpline";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AE3 RID: 6883
		public new static readonly string MRClassNameKey = "class vtkKochanekSpline";
	}
}
