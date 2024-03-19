using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImplicitHalo
	/// </summary>
	/// <remarks>
	///    implicit function for an halo
	///
	/// vtkImplicitHalo evaluates to 1.0 for each position in the sphere of a
	/// given center and radius Radius*(1-FadeOut). It evaluates to 0.0 for each
	/// position out the sphere of a given Center and radius Radius. It fades out
	/// linearly from 1.0 to 0.0 for points in a radius from Radius*(1-FadeOut) to
	/// Radius.
	/// vtkImplicitHalo is a concrete implementation of vtkImplicitFunction.
	/// It is useful as an input to
	/// vtkSampleFunction to generate an 2D image of an halo. It is used this way by
	/// vtkShadowMapPass.
	/// @warning
	/// It does not implement the gradient.
	/// </remarks>
	// Token: 0x02000A69 RID: 2665
	public class vtkImplicitHalo : vtkImplicitFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601BE61 RID: 114273 RVA: 0x0027152F File Offset: 0x0026F72F
		static vtkImplicitHalo()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitHalo.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitHalo"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601BE62 RID: 114274 RVA: 0x00271557 File Offset: 0x0026F757
		public vtkImplicitHalo(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601BE63 RID: 114275
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitHalo_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Center=(0.0,0.0,0.0), Radius=1.0, FadeOut=0.01
		/// </summary>
		// Token: 0x0601BE64 RID: 114276 RVA: 0x00271568 File Offset: 0x0026F768
		public new static vtkImplicitHalo New()
		{
			vtkImplicitHalo result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitHalo.vtkImplicitHalo_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitHalo)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Center=(0.0,0.0,0.0), Radius=1.0, FadeOut=0.01
		/// </summary>
		// Token: 0x0601BE65 RID: 114277 RVA: 0x002715BC File Offset: 0x0026F7BC
		public vtkImplicitHalo() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImplicitHalo.vtkImplicitHalo_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601BE66 RID: 114278 RVA: 0x00271600 File Offset: 0x0026F800
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601BE67 RID: 114279
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitHalo_EvaluateFunction_01(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Evaluate the equation.
		/// </summary>
		// Token: 0x0601BE68 RID: 114280 RVA: 0x0027160C File Offset: 0x0026F80C
		public override double EvaluateFunction(IntPtr x)
		{
			return vtkImplicitHalo.vtkImplicitHalo_EvaluateFunction_01(base.GetCppThis(), x);
		}

		// Token: 0x0601BE69 RID: 114281
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitHalo_EvaluateGradient_02(HandleRef pThis, IntPtr x, IntPtr g);

		/// <summary>
		/// Evaluate normal. Not implemented.
		/// </summary>
		// Token: 0x0601BE6A RID: 114282 RVA: 0x0027162C File Offset: 0x0026F82C
		public override void EvaluateGradient(IntPtr x, IntPtr g)
		{
			vtkImplicitHalo.vtkImplicitHalo_EvaluateGradient_02(base.GetCppThis(), x, g);
		}

		// Token: 0x0601BE6B RID: 114283
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitHalo_GetCenter_03(HandleRef pThis);

		/// <summary>
		/// Center of the sphere.
		/// </summary>
		// Token: 0x0601BE6C RID: 114284 RVA: 0x00271640 File Offset: 0x0026F840
		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkImplicitHalo.vtkImplicitHalo_GetCenter_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601BE6D RID: 114285
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitHalo_GetCenter_04(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Center of the sphere.
		/// </summary>
		// Token: 0x0601BE6E RID: 114286 RVA: 0x00271688 File Offset: 0x0026F888
		public virtual void GetCenter(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImplicitHalo.vtkImplicitHalo_GetCenter_04(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0601BE6F RID: 114287
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitHalo_GetCenter_05(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Center of the sphere.
		/// </summary>
		// Token: 0x0601BE70 RID: 114288 RVA: 0x0027169A File Offset: 0x0026F89A
		public virtual void GetCenter(IntPtr _arg)
		{
			vtkImplicitHalo.vtkImplicitHalo_GetCenter_05(base.GetCppThis(), _arg);
		}

		// Token: 0x0601BE71 RID: 114289
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitHalo_GetFadeOut_06(HandleRef pThis);

		/// <summary>
		/// FadeOut ratio. Valid values are between 0.0 and 1.0.
		/// </summary>
		// Token: 0x0601BE72 RID: 114290 RVA: 0x002716AC File Offset: 0x0026F8AC
		public virtual double GetFadeOut()
		{
			return vtkImplicitHalo.vtkImplicitHalo_GetFadeOut_06(base.GetCppThis());
		}

		// Token: 0x0601BE73 RID: 114291
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitHalo_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Center=(0.0,0.0,0.0), Radius=1.0, FadeOut=0.01
		/// </summary>
		// Token: 0x0601BE74 RID: 114292 RVA: 0x002716CC File Offset: 0x0026F8CC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImplicitHalo.vtkImplicitHalo_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601BE75 RID: 114293
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitHalo_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Center=(0.0,0.0,0.0), Radius=1.0, FadeOut=0.01
		/// </summary>
		// Token: 0x0601BE76 RID: 114294 RVA: 0x002716EC File Offset: 0x0026F8EC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImplicitHalo.vtkImplicitHalo_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0601BE77 RID: 114295
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitHalo_GetRadius_09(HandleRef pThis);

		/// <summary>
		/// Radius of the sphere.
		/// </summary>
		// Token: 0x0601BE78 RID: 114296 RVA: 0x00271708 File Offset: 0x0026F908
		public virtual double GetRadius()
		{
			return vtkImplicitHalo.vtkImplicitHalo_GetRadius_09(base.GetCppThis());
		}

		// Token: 0x0601BE79 RID: 114297
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitHalo_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Center=(0.0,0.0,0.0), Radius=1.0, FadeOut=0.01
		/// </summary>
		// Token: 0x0601BE7A RID: 114298 RVA: 0x00271728 File Offset: 0x0026F928
		public override int IsA(string type)
		{
			return vtkImplicitHalo.vtkImplicitHalo_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0601BE7B RID: 114299
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitHalo_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Center=(0.0,0.0,0.0), Radius=1.0, FadeOut=0.01
		/// </summary>
		// Token: 0x0601BE7C RID: 114300 RVA: 0x00271748 File Offset: 0x0026F948
		public new static int IsTypeOf(string type)
		{
			return vtkImplicitHalo.vtkImplicitHalo_IsTypeOf_11(type);
		}

		// Token: 0x0601BE7D RID: 114301
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitHalo_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Center=(0.0,0.0,0.0), Radius=1.0, FadeOut=0.01
		/// </summary>
		// Token: 0x0601BE7E RID: 114302 RVA: 0x00271764 File Offset: 0x0026F964
		public new vtkImplicitHalo NewInstance()
		{
			vtkImplicitHalo result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitHalo.vtkImplicitHalo_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitHalo)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601BE7F RID: 114303
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitHalo_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Center=(0.0,0.0,0.0), Radius=1.0, FadeOut=0.01
		/// </summary>
		// Token: 0x0601BE80 RID: 114304 RVA: 0x002717C0 File Offset: 0x0026F9C0
		public new static vtkImplicitHalo SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitHalo vtkImplicitHalo = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitHalo.vtkImplicitHalo_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitHalo = (vtkImplicitHalo)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitHalo.Register(null);
				}
			}
			return vtkImplicitHalo;
		}

		// Token: 0x0601BE81 RID: 114305
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitHalo_SetCenter_15(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Center of the sphere.
		/// </summary>
		// Token: 0x0601BE82 RID: 114306 RVA: 0x0027183F File Offset: 0x0026FA3F
		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkImplicitHalo.vtkImplicitHalo_SetCenter_15(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601BE83 RID: 114307
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitHalo_SetCenter_16(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Center of the sphere.
		/// </summary>
		// Token: 0x0601BE84 RID: 114308 RVA: 0x00271851 File Offset: 0x0026FA51
		public virtual void SetCenter(IntPtr _arg)
		{
			vtkImplicitHalo.vtkImplicitHalo_SetCenter_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0601BE85 RID: 114309
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitHalo_SetFadeOut_17(HandleRef pThis, double _arg);

		/// <summary>
		/// FadeOut ratio. Valid values are between 0.0 and 1.0.
		/// </summary>
		// Token: 0x0601BE86 RID: 114310 RVA: 0x00271861 File Offset: 0x0026FA61
		public virtual void SetFadeOut(double _arg)
		{
			vtkImplicitHalo.vtkImplicitHalo_SetFadeOut_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0601BE87 RID: 114311
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitHalo_SetRadius_18(HandleRef pThis, double _arg);

		/// <summary>
		/// Radius of the sphere.
		/// </summary>
		// Token: 0x0601BE88 RID: 114312 RVA: 0x00271871 File Offset: 0x0026FA71
		public virtual void SetRadius(double _arg)
		{
			vtkImplicitHalo.vtkImplicitHalo_SetRadius_18(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DC9 RID: 7625
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitHalo";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DCA RID: 7626
		public new static readonly string MRClassNameKey = "class vtkImplicitHalo";
	}
}
