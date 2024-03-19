using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSCurveSpline
	/// </summary>
	/// <remarks>
	///    computes an interpolating spline using a
	/// a SCurve basis.
	///
	///
	/// vtkSCurveSpline is a concrete implementation of vtkSpline using a
	/// SCurve basis.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSpline vtkKochanekSpline
	/// </seealso>
	// Token: 0x02000086 RID: 134
	public class vtkSCurveSpline : vtkSpline
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06001A4F RID: 6735 RVA: 0x00029F90 File Offset: 0x00028190
		static vtkSCurveSpline()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSCurveSpline.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSCurveSpline"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06001A50 RID: 6736 RVA: 0x00029FB8 File Offset: 0x000281B8
		public vtkSCurveSpline(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06001A51 RID: 6737
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSCurveSpline_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001A52 RID: 6738 RVA: 0x00029FC8 File Offset: 0x000281C8
		public new static vtkSCurveSpline New()
		{
			vtkSCurveSpline result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSCurveSpline.vtkSCurveSpline_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSCurveSpline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001A53 RID: 6739 RVA: 0x0002A01C File Offset: 0x0002821C
		public vtkSCurveSpline() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSCurveSpline.vtkSCurveSpline_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06001A54 RID: 6740 RVA: 0x0002A060 File Offset: 0x00028260
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06001A55 RID: 6741
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSCurveSpline_Compute_01(HandleRef pThis);

		/// <summary>
		/// Compute SCurve Splines for each dependent variable
		/// </summary>
		// Token: 0x06001A56 RID: 6742 RVA: 0x0002A06B File Offset: 0x0002826B
		public override void Compute()
		{
			vtkSCurveSpline.vtkSCurveSpline_Compute_01(base.GetCppThis());
		}

		// Token: 0x06001A57 RID: 6743
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSCurveSpline_DeepCopy_02(HandleRef pThis, HandleRef s);

		/// <summary>
		/// Deep copy of SCurve spline data.
		/// </summary>
		// Token: 0x06001A58 RID: 6744 RVA: 0x0002A07C File Offset: 0x0002827C
		public override void DeepCopy(vtkSpline s)
		{
			vtkSCurveSpline.vtkSCurveSpline_DeepCopy_02(base.GetCppThis(), (s == null) ? default(HandleRef) : s.GetCppThis());
		}

		// Token: 0x06001A59 RID: 6745
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSCurveSpline_Evaluate_03(HandleRef pThis, double t);

		/// <summary>
		/// Evaluate a 1D SCurve spline.
		/// </summary>
		// Token: 0x06001A5A RID: 6746 RVA: 0x0002A0AC File Offset: 0x000282AC
		public override double Evaluate(double t)
		{
			return vtkSCurveSpline.vtkSCurveSpline_Evaluate_03(base.GetCppThis(), t);
		}

		// Token: 0x06001A5B RID: 6747
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSCurveSpline_GetNodeWeight_04(HandleRef pThis);

		/// <summary>
		/// Deep copy of SCurve spline data.
		/// </summary>
		// Token: 0x06001A5C RID: 6748 RVA: 0x0002A0CC File Offset: 0x000282CC
		public virtual double GetNodeWeight()
		{
			return vtkSCurveSpline.vtkSCurveSpline_GetNodeWeight_04(base.GetCppThis());
		}

		// Token: 0x06001A5D RID: 6749
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSCurveSpline_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001A5E RID: 6750 RVA: 0x0002A0EC File Offset: 0x000282EC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSCurveSpline.vtkSCurveSpline_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06001A5F RID: 6751
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSCurveSpline_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001A60 RID: 6752 RVA: 0x0002A10C File Offset: 0x0002830C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSCurveSpline.vtkSCurveSpline_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06001A61 RID: 6753
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSCurveSpline_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001A62 RID: 6754 RVA: 0x0002A128 File Offset: 0x00028328
		public override int IsA(string type)
		{
			return vtkSCurveSpline.vtkSCurveSpline_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06001A63 RID: 6755
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSCurveSpline_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001A64 RID: 6756 RVA: 0x0002A148 File Offset: 0x00028348
		public new static int IsTypeOf(string type)
		{
			return vtkSCurveSpline.vtkSCurveSpline_IsTypeOf_08(type);
		}

		// Token: 0x06001A65 RID: 6757
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSCurveSpline_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001A66 RID: 6758 RVA: 0x0002A164 File Offset: 0x00028364
		public new vtkSCurveSpline NewInstance()
		{
			vtkSCurveSpline result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSCurveSpline.vtkSCurveSpline_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSCurveSpline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001A67 RID: 6759
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSCurveSpline_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001A68 RID: 6760 RVA: 0x0002A1C0 File Offset: 0x000283C0
		public new static vtkSCurveSpline SafeDownCast(vtkObjectBase o)
		{
			vtkSCurveSpline vtkSCurveSpline = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSCurveSpline.vtkSCurveSpline_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSCurveSpline = (vtkSCurveSpline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSCurveSpline.Register(null);
				}
			}
			return vtkSCurveSpline;
		}

		// Token: 0x06001A69 RID: 6761
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSCurveSpline_SetNodeWeight_12(HandleRef pThis, double _arg);

		/// <summary>
		/// Deep copy of SCurve spline data.
		/// </summary>
		// Token: 0x06001A6A RID: 6762 RVA: 0x0002A23F File Offset: 0x0002843F
		public virtual void SetNodeWeight(double _arg)
		{
			vtkSCurveSpline.vtkSCurveSpline_SetNodeWeight_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040004AA RID: 1194
		public new const string MRFullTypeName = "Kitware.VTK.vtkSCurveSpline";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040004AB RID: 1195
		public new static readonly string MRClassNameKey = "class vtkSCurveSpline";
	}
}
