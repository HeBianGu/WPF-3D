using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSuperquadric
	/// </summary>
	/// <remarks>
	///    implicit function for a Superquadric
	///
	/// vtkSuperquadric computes the implicit function and function gradient
	/// for a superquadric. vtkSuperquadric is a concrete implementation of
	/// vtkImplicitFunction.  The superquadric is centered at Center and axes
	/// of rotation is along the y-axis. (Use the superclass'
	/// vtkImplicitFunction transformation matrix if necessary to reposition.)
	/// Roundness parameters (PhiRoundness and ThetaRoundness) control
	/// the shape of the superquadric.  The Toroidal boolean controls whether
	/// a toroidal superquadric is produced.  If so, the Thickness parameter
	/// controls the thickness of the toroid:  0 is the thinnest allowable
	/// toroid, and 1 has a minimum sized hole.  The Scale parameters allow
	/// the superquadric to be scaled in x, y, and z (normal vectors are correctly
	/// generated in any case).  The Size parameter controls size of the
	/// superquadric.
	///
	/// This code is based on "Rigid physically based superquadrics", A. H. Barr,
	/// in "Graphics Gems III", David Kirk, ed., Academic Press, 1992.
	///
	/// @warning
	/// The Size and Thickness parameters control coefficients of superquadric
	/// generation, and may do not exactly describe the size of the superquadric.
	///
	/// </remarks>
	// Token: 0x02000AD1 RID: 2769
	public class vtkSuperquadric : vtkImplicitFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D259 RID: 119385 RVA: 0x0029182B File Offset: 0x0028FA2B
		static vtkSuperquadric()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSuperquadric.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSuperquadric"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D25A RID: 119386 RVA: 0x00291853 File Offset: 0x0028FA53
		public vtkSuperquadric(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D25B RID: 119387
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSuperquadric_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with superquadric radius of 0.5, toroidal off, center at 0.0,
		/// scale (1,1,1), size 0.5, phi roundness 1.0, and theta roundness 0.0.
		/// </summary>
		// Token: 0x0601D25C RID: 119388 RVA: 0x00291864 File Offset: 0x0028FA64
		public new static vtkSuperquadric New()
		{
			vtkSuperquadric result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSuperquadric.vtkSuperquadric_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSuperquadric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with superquadric radius of 0.5, toroidal off, center at 0.0,
		/// scale (1,1,1), size 0.5, phi roundness 1.0, and theta roundness 0.0.
		/// </summary>
		// Token: 0x0601D25D RID: 119389 RVA: 0x002918B8 File Offset: 0x0028FAB8
		public vtkSuperquadric() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSuperquadric.vtkSuperquadric_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D25E RID: 119390 RVA: 0x002918FC File Offset: 0x0028FAFC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D25F RID: 119391
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSuperquadric_EvaluateFunction_01(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Construct with superquadric radius of 0.5, toroidal off, center at 0.0,
		/// scale (1,1,1), size 0.5, phi roundness 1.0, and theta roundness 0.0.
		/// </summary>
		// Token: 0x0601D260 RID: 119392 RVA: 0x00291908 File Offset: 0x0028FB08
		public override double EvaluateFunction(IntPtr x)
		{
			return vtkSuperquadric.vtkSuperquadric_EvaluateFunction_01(base.GetCppThis(), x);
		}

		// Token: 0x0601D261 RID: 119393
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadric_EvaluateGradient_02(HandleRef pThis, IntPtr x, IntPtr g);

		/// <summary>
		/// Construct with superquadric radius of 0.5, toroidal off, center at 0.0,
		/// scale (1,1,1), size 0.5, phi roundness 1.0, and theta roundness 0.0.
		/// </summary>
		// Token: 0x0601D262 RID: 119394 RVA: 0x00291928 File Offset: 0x0028FB28
		public override void EvaluateGradient(IntPtr x, IntPtr g)
		{
			vtkSuperquadric.vtkSuperquadric_EvaluateGradient_02(base.GetCppThis(), x, g);
		}

		// Token: 0x0601D263 RID: 119395
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSuperquadric_GetCenter_03(HandleRef pThis);

		/// <summary>
		/// Set the center of the superquadric. Default is 0,0,0.
		/// </summary>
		// Token: 0x0601D264 RID: 119396 RVA: 0x0029193C File Offset: 0x0028FB3C
		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkSuperquadric.vtkSuperquadric_GetCenter_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601D265 RID: 119397
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadric_GetCenter_04(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the center of the superquadric. Default is 0,0,0.
		/// </summary>
		// Token: 0x0601D266 RID: 119398 RVA: 0x00291984 File Offset: 0x0028FB84
		public virtual void GetCenter(IntPtr data)
		{
			vtkSuperquadric.vtkSuperquadric_GetCenter_04(base.GetCppThis(), data);
		}

		// Token: 0x0601D267 RID: 119399
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSuperquadric_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct with superquadric radius of 0.5, toroidal off, center at 0.0,
		/// scale (1,1,1), size 0.5, phi roundness 1.0, and theta roundness 0.0.
		/// </summary>
		// Token: 0x0601D268 RID: 119400 RVA: 0x00291994 File Offset: 0x0028FB94
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSuperquadric.vtkSuperquadric_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601D269 RID: 119401
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSuperquadric_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct with superquadric radius of 0.5, toroidal off, center at 0.0,
		/// scale (1,1,1), size 0.5, phi roundness 1.0, and theta roundness 0.0.
		/// </summary>
		// Token: 0x0601D26A RID: 119402 RVA: 0x002919B4 File Offset: 0x0028FBB4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSuperquadric.vtkSuperquadric_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601D26B RID: 119403
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSuperquadric_GetPhiRoundness_07(HandleRef pThis);

		/// <summary>
		/// Set/Get Superquadric north/south roundness.
		/// Values range from 0 (rectangular) to 1 (circular) to higher orders.
		/// </summary>
		// Token: 0x0601D26C RID: 119404 RVA: 0x002919D0 File Offset: 0x0028FBD0
		public virtual double GetPhiRoundness()
		{
			return vtkSuperquadric.vtkSuperquadric_GetPhiRoundness_07(base.GetCppThis());
		}

		// Token: 0x0601D26D RID: 119405
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSuperquadric_GetScale_08(HandleRef pThis);

		/// <summary>
		/// Set the scale factors of the superquadric. Default is 1,1,1.
		/// </summary>
		// Token: 0x0601D26E RID: 119406 RVA: 0x002919F0 File Offset: 0x0028FBF0
		public virtual double[] GetScale()
		{
			IntPtr intPtr = vtkSuperquadric.vtkSuperquadric_GetScale_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601D26F RID: 119407
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadric_GetScale_09(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the scale factors of the superquadric. Default is 1,1,1.
		/// </summary>
		// Token: 0x0601D270 RID: 119408 RVA: 0x00291A38 File Offset: 0x0028FC38
		public virtual void GetScale(IntPtr data)
		{
			vtkSuperquadric.vtkSuperquadric_GetScale_09(base.GetCppThis(), data);
		}

		// Token: 0x0601D271 RID: 119409
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSuperquadric_GetSize_10(HandleRef pThis);

		/// <summary>
		/// Set/Get Superquadric isotropic size.
		/// </summary>
		// Token: 0x0601D272 RID: 119410 RVA: 0x00291A48 File Offset: 0x0028FC48
		public virtual double GetSize()
		{
			return vtkSuperquadric.vtkSuperquadric_GetSize_10(base.GetCppThis());
		}

		// Token: 0x0601D273 RID: 119411
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSuperquadric_GetThetaRoundness_11(HandleRef pThis);

		/// <summary>
		/// Set/Get Superquadric east/west roundness.
		/// Values range from 0 (rectangular) to 1 (circular) to higher orders.
		/// </summary>
		// Token: 0x0601D274 RID: 119412 RVA: 0x00291A68 File Offset: 0x0028FC68
		public virtual double GetThetaRoundness()
		{
			return vtkSuperquadric.vtkSuperquadric_GetThetaRoundness_11(base.GetCppThis());
		}

		// Token: 0x0601D275 RID: 119413
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSuperquadric_GetThickness_12(HandleRef pThis);

		/// <summary>
		/// Set/Get Superquadric ring thickness (toroids only).
		/// Changing thickness maintains the outside diameter of the toroid.
		/// </summary>
		// Token: 0x0601D276 RID: 119414 RVA: 0x00291A88 File Offset: 0x0028FC88
		public virtual double GetThickness()
		{
			return vtkSuperquadric.vtkSuperquadric_GetThickness_12(base.GetCppThis());
		}

		// Token: 0x0601D277 RID: 119415
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSuperquadric_GetThicknessMaxValue_13(HandleRef pThis);

		/// <summary>
		/// Set/Get Superquadric ring thickness (toroids only).
		/// Changing thickness maintains the outside diameter of the toroid.
		/// </summary>
		// Token: 0x0601D278 RID: 119416 RVA: 0x00291AA8 File Offset: 0x0028FCA8
		public virtual double GetThicknessMaxValue()
		{
			return vtkSuperquadric.vtkSuperquadric_GetThicknessMaxValue_13(base.GetCppThis());
		}

		// Token: 0x0601D279 RID: 119417
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSuperquadric_GetThicknessMinValue_14(HandleRef pThis);

		/// <summary>
		/// Set/Get Superquadric ring thickness (toroids only).
		/// Changing thickness maintains the outside diameter of the toroid.
		/// </summary>
		// Token: 0x0601D27A RID: 119418 RVA: 0x00291AC8 File Offset: 0x0028FCC8
		public virtual double GetThicknessMinValue()
		{
			return vtkSuperquadric.vtkSuperquadric_GetThicknessMinValue_14(base.GetCppThis());
		}

		// Token: 0x0601D27B RID: 119419
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSuperquadric_GetToroidal_15(HandleRef pThis);

		/// <summary>
		/// Set/Get whether or not the superquadric is toroidal (1) or ellipsoidal (0).
		/// </summary>
		// Token: 0x0601D27C RID: 119420 RVA: 0x00291AE8 File Offset: 0x0028FCE8
		public virtual int GetToroidal()
		{
			return vtkSuperquadric.vtkSuperquadric_GetToroidal_15(base.GetCppThis());
		}

		// Token: 0x0601D27D RID: 119421
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSuperquadric_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct with superquadric radius of 0.5, toroidal off, center at 0.0,
		/// scale (1,1,1), size 0.5, phi roundness 1.0, and theta roundness 0.0.
		/// </summary>
		// Token: 0x0601D27E RID: 119422 RVA: 0x00291B08 File Offset: 0x0028FD08
		public override int IsA(string type)
		{
			return vtkSuperquadric.vtkSuperquadric_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x0601D27F RID: 119423
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSuperquadric_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct with superquadric radius of 0.5, toroidal off, center at 0.0,
		/// scale (1,1,1), size 0.5, phi roundness 1.0, and theta roundness 0.0.
		/// </summary>
		// Token: 0x0601D280 RID: 119424 RVA: 0x00291B28 File Offset: 0x0028FD28
		public new static int IsTypeOf(string type)
		{
			return vtkSuperquadric.vtkSuperquadric_IsTypeOf_17(type);
		}

		// Token: 0x0601D281 RID: 119425
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSuperquadric_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with superquadric radius of 0.5, toroidal off, center at 0.0,
		/// scale (1,1,1), size 0.5, phi roundness 1.0, and theta roundness 0.0.
		/// </summary>
		// Token: 0x0601D282 RID: 119426 RVA: 0x00291B44 File Offset: 0x0028FD44
		public new vtkSuperquadric NewInstance()
		{
			vtkSuperquadric result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSuperquadric.vtkSuperquadric_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSuperquadric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D283 RID: 119427
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSuperquadric_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with superquadric radius of 0.5, toroidal off, center at 0.0,
		/// scale (1,1,1), size 0.5, phi roundness 1.0, and theta roundness 0.0.
		/// </summary>
		// Token: 0x0601D284 RID: 119428 RVA: 0x00291BA0 File Offset: 0x0028FDA0
		public new static vtkSuperquadric SafeDownCast(vtkObjectBase o)
		{
			vtkSuperquadric vtkSuperquadric = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSuperquadric.vtkSuperquadric_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSuperquadric = (vtkSuperquadric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSuperquadric.Register(null);
				}
			}
			return vtkSuperquadric;
		}

		// Token: 0x0601D285 RID: 119429
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadric_SetCenter_21(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the center of the superquadric. Default is 0,0,0.
		/// </summary>
		// Token: 0x0601D286 RID: 119430 RVA: 0x00291C1F File Offset: 0x0028FE1F
		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkSuperquadric.vtkSuperquadric_SetCenter_21(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601D287 RID: 119431
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadric_SetCenter_22(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the center of the superquadric. Default is 0,0,0.
		/// </summary>
		// Token: 0x0601D288 RID: 119432 RVA: 0x00291C31 File Offset: 0x0028FE31
		public virtual void SetCenter(IntPtr _arg)
		{
			vtkSuperquadric.vtkSuperquadric_SetCenter_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0601D289 RID: 119433
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadric_SetPhiRoundness_23(HandleRef pThis, double e);

		/// <summary>
		/// Set/Get Superquadric north/south roundness.
		/// Values range from 0 (rectangular) to 1 (circular) to higher orders.
		/// </summary>
		// Token: 0x0601D28A RID: 119434 RVA: 0x00291C41 File Offset: 0x0028FE41
		public void SetPhiRoundness(double e)
		{
			vtkSuperquadric.vtkSuperquadric_SetPhiRoundness_23(base.GetCppThis(), e);
		}

		// Token: 0x0601D28B RID: 119435
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadric_SetScale_24(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the scale factors of the superquadric. Default is 1,1,1.
		/// </summary>
		// Token: 0x0601D28C RID: 119436 RVA: 0x00291C51 File Offset: 0x0028FE51
		public virtual void SetScale(double _arg1, double _arg2, double _arg3)
		{
			vtkSuperquadric.vtkSuperquadric_SetScale_24(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601D28D RID: 119437
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadric_SetScale_25(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the scale factors of the superquadric. Default is 1,1,1.
		/// </summary>
		// Token: 0x0601D28E RID: 119438 RVA: 0x00291C63 File Offset: 0x0028FE63
		public virtual void SetScale(IntPtr _arg)
		{
			vtkSuperquadric.vtkSuperquadric_SetScale_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0601D28F RID: 119439
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadric_SetSize_26(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get Superquadric isotropic size.
		/// </summary>
		// Token: 0x0601D290 RID: 119440 RVA: 0x00291C73 File Offset: 0x0028FE73
		public virtual void SetSize(double _arg)
		{
			vtkSuperquadric.vtkSuperquadric_SetSize_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0601D291 RID: 119441
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadric_SetThetaRoundness_27(HandleRef pThis, double e);

		/// <summary>
		/// Set/Get Superquadric east/west roundness.
		/// Values range from 0 (rectangular) to 1 (circular) to higher orders.
		/// </summary>
		// Token: 0x0601D292 RID: 119442 RVA: 0x00291C83 File Offset: 0x0028FE83
		public void SetThetaRoundness(double e)
		{
			vtkSuperquadric.vtkSuperquadric_SetThetaRoundness_27(base.GetCppThis(), e);
		}

		// Token: 0x0601D293 RID: 119443
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadric_SetThickness_28(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get Superquadric ring thickness (toroids only).
		/// Changing thickness maintains the outside diameter of the toroid.
		/// </summary>
		// Token: 0x0601D294 RID: 119444 RVA: 0x00291C93 File Offset: 0x0028FE93
		public virtual void SetThickness(double _arg)
		{
			vtkSuperquadric.vtkSuperquadric_SetThickness_28(base.GetCppThis(), _arg);
		}

		// Token: 0x0601D295 RID: 119445
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadric_SetToroidal_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get whether or not the superquadric is toroidal (1) or ellipsoidal (0).
		/// </summary>
		// Token: 0x0601D296 RID: 119446 RVA: 0x00291CA3 File Offset: 0x0028FEA3
		public virtual void SetToroidal(int _arg)
		{
			vtkSuperquadric.vtkSuperquadric_SetToroidal_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0601D297 RID: 119447
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadric_ToroidalOff_30(HandleRef pThis);

		/// <summary>
		/// Set/Get whether or not the superquadric is toroidal (1) or ellipsoidal (0).
		/// </summary>
		// Token: 0x0601D298 RID: 119448 RVA: 0x00291CB3 File Offset: 0x0028FEB3
		public virtual void ToroidalOff()
		{
			vtkSuperquadric.vtkSuperquadric_ToroidalOff_30(base.GetCppThis());
		}

		// Token: 0x0601D299 RID: 119449
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSuperquadric_ToroidalOn_31(HandleRef pThis);

		/// <summary>
		/// Set/Get whether or not the superquadric is toroidal (1) or ellipsoidal (0).
		/// </summary>
		// Token: 0x0601D29A RID: 119450 RVA: 0x00291CC2 File Offset: 0x0028FEC2
		public virtual void ToroidalOn()
		{
			vtkSuperquadric.vtkSuperquadric_ToroidalOn_31(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EC8 RID: 7880
		public new const string MRFullTypeName = "Kitware.VTK.vtkSuperquadric";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EC9 RID: 7881
		public new static readonly string MRClassNameKey = "class vtkSuperquadric";
	}
}
