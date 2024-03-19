using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCardinalSpline
	/// </summary>
	/// <remarks>
	///    computes an interpolating spline using a
	/// a Cardinal basis.
	///
	///
	/// vtkCardinalSpline is a concrete implementation of vtkSpline using a
	/// Cardinal basis.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSpline vtkKochanekSpline
	/// </seealso>
	// Token: 0x0200091B RID: 2331
	public class vtkCardinalSpline : vtkSpline
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018275 RID: 98933 RVA: 0x0021CCBD File Offset: 0x0021AEBD
		static vtkCardinalSpline()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCardinalSpline.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCardinalSpline"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018276 RID: 98934 RVA: 0x0021CCE5 File Offset: 0x0021AEE5
		public vtkCardinalSpline(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018277 RID: 98935
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCardinalSpline_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018278 RID: 98936 RVA: 0x0021CCF4 File Offset: 0x0021AEF4
		public new static vtkCardinalSpline New()
		{
			vtkCardinalSpline result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCardinalSpline.vtkCardinalSpline_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCardinalSpline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018279 RID: 98937 RVA: 0x0021CD48 File Offset: 0x0021AF48
		public vtkCardinalSpline() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCardinalSpline.vtkCardinalSpline_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601827A RID: 98938 RVA: 0x0021CD8C File Offset: 0x0021AF8C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601827B RID: 98939
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCardinalSpline_Compute_01(HandleRef pThis);

		/// <summary>
		/// Compute Cardinal Splines for each dependent variable
		/// </summary>
		// Token: 0x0601827C RID: 98940 RVA: 0x0021CD97 File Offset: 0x0021AF97
		public override void Compute()
		{
			vtkCardinalSpline.vtkCardinalSpline_Compute_01(base.GetCppThis());
		}

		// Token: 0x0601827D RID: 98941
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCardinalSpline_DeepCopy_02(HandleRef pThis, HandleRef s);

		/// <summary>
		/// Deep copy of cardinal spline data.
		/// </summary>
		// Token: 0x0601827E RID: 98942 RVA: 0x0021CDA8 File Offset: 0x0021AFA8
		public override void DeepCopy(vtkSpline s)
		{
			vtkCardinalSpline.vtkCardinalSpline_DeepCopy_02(base.GetCppThis(), (s == null) ? default(HandleRef) : s.GetCppThis());
		}

		// Token: 0x0601827F RID: 98943
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCardinalSpline_Evaluate_03(HandleRef pThis, double t);

		/// <summary>
		/// Evaluate a 1D cardinal spline.
		/// </summary>
		// Token: 0x06018280 RID: 98944 RVA: 0x0021CDD8 File Offset: 0x0021AFD8
		public override double Evaluate(double t)
		{
			return vtkCardinalSpline.vtkCardinalSpline_Evaluate_03(base.GetCppThis(), t);
		}

		// Token: 0x06018281 RID: 98945
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCardinalSpline_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018282 RID: 98946 RVA: 0x0021CDF8 File Offset: 0x0021AFF8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCardinalSpline.vtkCardinalSpline_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06018283 RID: 98947
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCardinalSpline_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018284 RID: 98948 RVA: 0x0021CE18 File Offset: 0x0021B018
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCardinalSpline.vtkCardinalSpline_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06018285 RID: 98949
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCardinalSpline_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018286 RID: 98950 RVA: 0x0021CE34 File Offset: 0x0021B034
		public override int IsA(string type)
		{
			return vtkCardinalSpline.vtkCardinalSpline_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06018287 RID: 98951
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCardinalSpline_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018288 RID: 98952 RVA: 0x0021CE54 File Offset: 0x0021B054
		public new static int IsTypeOf(string type)
		{
			return vtkCardinalSpline.vtkCardinalSpline_IsTypeOf_07(type);
		}

		// Token: 0x06018289 RID: 98953
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCardinalSpline_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601828A RID: 98954 RVA: 0x0021CE70 File Offset: 0x0021B070
		public new vtkCardinalSpline NewInstance()
		{
			vtkCardinalSpline result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCardinalSpline.vtkCardinalSpline_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCardinalSpline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601828B RID: 98955
		[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCardinalSpline_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601828C RID: 98956 RVA: 0x0021CECC File Offset: 0x0021B0CC
		public new static vtkCardinalSpline SafeDownCast(vtkObjectBase o)
		{
			vtkCardinalSpline vtkCardinalSpline = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCardinalSpline.vtkCardinalSpline_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCardinalSpline = (vtkCardinalSpline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCardinalSpline.Register(null);
				}
			}
			return vtkCardinalSpline;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AE0 RID: 6880
		public new const string MRFullTypeName = "Kitware.VTK.vtkCardinalSpline";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AE1 RID: 6881
		public new static readonly string MRClassNameKey = "class vtkCardinalSpline";
	}
}
