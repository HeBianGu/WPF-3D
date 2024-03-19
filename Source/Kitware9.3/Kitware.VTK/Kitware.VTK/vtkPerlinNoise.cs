using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPerlinNoise
	/// </summary>
	/// <remarks>
	///    an implicit function that implements Perlin noise
	///
	/// vtkPerlinNoise computes a Perlin noise field as an implicit function.
	/// vtkPerlinNoise is a concrete implementation of vtkImplicitFunction.
	/// Perlin noise, originally described by Ken Perlin, is a non-periodic and
	/// continuous noise function useful for modeling real-world objects.
	///
	/// The amplitude and frequency of the noise pattern are adjustable.  This
	/// implementation of Perlin noise is derived closely from Greg Ward's version
	/// in Graphics Gems II.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImplicitFunction
	/// </seealso>
	// Token: 0x02000A92 RID: 2706
	public class vtkPerlinNoise : vtkImplicitFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C5E0 RID: 116192 RVA: 0x0027DA8D File Offset: 0x0027BC8D
		static vtkPerlinNoise()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPerlinNoise.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPerlinNoise"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C5E1 RID: 116193 RVA: 0x0027DAB5 File Offset: 0x0027BCB5
		public vtkPerlinNoise(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C5E2 RID: 116194
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPerlinNoise_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x0601C5E3 RID: 116195 RVA: 0x0027DAC4 File Offset: 0x0027BCC4
		public new static vtkPerlinNoise New()
		{
			vtkPerlinNoise result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPerlinNoise.vtkPerlinNoise_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPerlinNoise)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x0601C5E4 RID: 116196 RVA: 0x0027DB18 File Offset: 0x0027BD18
		public vtkPerlinNoise() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPerlinNoise.vtkPerlinNoise_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C5E5 RID: 116197 RVA: 0x0027DB5C File Offset: 0x0027BD5C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C5E6 RID: 116198
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPerlinNoise_EvaluateFunction_01(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Evaluate PerlinNoise function.
		/// </summary>
		// Token: 0x0601C5E7 RID: 116199 RVA: 0x0027DB68 File Offset: 0x0027BD68
		public override double EvaluateFunction(IntPtr x)
		{
			return vtkPerlinNoise.vtkPerlinNoise_EvaluateFunction_01(base.GetCppThis(), x);
		}

		// Token: 0x0601C5E8 RID: 116200
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerlinNoise_EvaluateGradient_02(HandleRef pThis, IntPtr x, IntPtr n);

		/// <summary>
		/// Evaluate PerlinNoise gradient.  Currently, the method returns a 0
		/// gradient.
		/// </summary>
		// Token: 0x0601C5E9 RID: 116201 RVA: 0x0027DB88 File Offset: 0x0027BD88
		public override void EvaluateGradient(IntPtr x, IntPtr n)
		{
			vtkPerlinNoise.vtkPerlinNoise_EvaluateGradient_02(base.GetCppThis(), x, n);
		}

		// Token: 0x0601C5EA RID: 116202
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPerlinNoise_GetAmplitude_03(HandleRef pThis);

		/// <summary>
		/// Set/get the amplitude of the noise function. Amplitude can be negative.
		/// The noise function varies randomly between -|Amplitude| and |Amplitude|.
		/// Therefore the range of values is 2*|Amplitude| large.
		/// The initial amplitude is 1.
		/// </summary>
		// Token: 0x0601C5EB RID: 116203 RVA: 0x0027DB9C File Offset: 0x0027BD9C
		public virtual double GetAmplitude()
		{
			return vtkPerlinNoise.vtkPerlinNoise_GetAmplitude_03(base.GetCppThis());
		}

		// Token: 0x0601C5EC RID: 116204
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPerlinNoise_GetFrequency_04(HandleRef pThis);

		/// <summary>
		/// Set/get the frequency, or physical scale,  of the noise function
		/// (higher is finer scale).  The frequency can be adjusted per axis, or
		/// the same for all axes.
		/// </summary>
		// Token: 0x0601C5ED RID: 116205 RVA: 0x0027DBBC File Offset: 0x0027BDBC
		public virtual double[] GetFrequency()
		{
			IntPtr intPtr = vtkPerlinNoise.vtkPerlinNoise_GetFrequency_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601C5EE RID: 116206
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerlinNoise_GetFrequency_05(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/get the frequency, or physical scale,  of the noise function
		/// (higher is finer scale).  The frequency can be adjusted per axis, or
		/// the same for all axes.
		/// </summary>
		// Token: 0x0601C5EF RID: 116207 RVA: 0x0027DC04 File Offset: 0x0027BE04
		public virtual void GetFrequency(IntPtr data)
		{
			vtkPerlinNoise.vtkPerlinNoise_GetFrequency_05(base.GetCppThis(), data);
		}

		// Token: 0x0601C5F0 RID: 116208
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPerlinNoise_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C5F1 RID: 116209 RVA: 0x0027DC14 File Offset: 0x0027BE14
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPerlinNoise.vtkPerlinNoise_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0601C5F2 RID: 116210
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPerlinNoise_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C5F3 RID: 116211 RVA: 0x0027DC34 File Offset: 0x0027BE34
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPerlinNoise.vtkPerlinNoise_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0601C5F4 RID: 116212
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPerlinNoise_GetPhase_08(HandleRef pThis);

		/// <summary>
		/// Set/get the phase of the noise function.  This parameter can be used to
		/// shift the noise function within space (perhaps to avoid a beat with a
		/// noise pattern at another scale).  Phase tends to repeat about every
		/// unit, so a phase of 0.5 is a half-cycle shift.
		/// </summary>
		// Token: 0x0601C5F5 RID: 116213 RVA: 0x0027DC50 File Offset: 0x0027BE50
		public virtual double[] GetPhase()
		{
			IntPtr intPtr = vtkPerlinNoise.vtkPerlinNoise_GetPhase_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601C5F6 RID: 116214
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerlinNoise_GetPhase_09(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/get the phase of the noise function.  This parameter can be used to
		/// shift the noise function within space (perhaps to avoid a beat with a
		/// noise pattern at another scale).  Phase tends to repeat about every
		/// unit, so a phase of 0.5 is a half-cycle shift.
		/// </summary>
		// Token: 0x0601C5F7 RID: 116215 RVA: 0x0027DC98 File Offset: 0x0027BE98
		public virtual void GetPhase(IntPtr data)
		{
			vtkPerlinNoise.vtkPerlinNoise_GetPhase_09(base.GetCppThis(), data);
		}

		// Token: 0x0601C5F8 RID: 116216
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPerlinNoise_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C5F9 RID: 116217 RVA: 0x0027DCA8 File Offset: 0x0027BEA8
		public override int IsA(string type)
		{
			return vtkPerlinNoise.vtkPerlinNoise_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0601C5FA RID: 116218
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPerlinNoise_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C5FB RID: 116219 RVA: 0x0027DCC8 File Offset: 0x0027BEC8
		public new static int IsTypeOf(string type)
		{
			return vtkPerlinNoise.vtkPerlinNoise_IsTypeOf_11(type);
		}

		// Token: 0x0601C5FC RID: 116220
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPerlinNoise_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C5FD RID: 116221 RVA: 0x0027DCE4 File Offset: 0x0027BEE4
		public new vtkPerlinNoise NewInstance()
		{
			vtkPerlinNoise result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPerlinNoise.vtkPerlinNoise_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPerlinNoise)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C5FE RID: 116222
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPerlinNoise_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C5FF RID: 116223 RVA: 0x0027DD40 File Offset: 0x0027BF40
		public new static vtkPerlinNoise SafeDownCast(vtkObjectBase o)
		{
			vtkPerlinNoise vtkPerlinNoise = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPerlinNoise.vtkPerlinNoise_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPerlinNoise = (vtkPerlinNoise)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPerlinNoise.Register(null);
				}
			}
			return vtkPerlinNoise;
		}

		// Token: 0x0601C600 RID: 116224
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerlinNoise_SetAmplitude_15(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/get the amplitude of the noise function. Amplitude can be negative.
		/// The noise function varies randomly between -|Amplitude| and |Amplitude|.
		/// Therefore the range of values is 2*|Amplitude| large.
		/// The initial amplitude is 1.
		/// </summary>
		// Token: 0x0601C601 RID: 116225 RVA: 0x0027DDBF File Offset: 0x0027BFBF
		public virtual void SetAmplitude(double _arg)
		{
			vtkPerlinNoise.vtkPerlinNoise_SetAmplitude_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0601C602 RID: 116226
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerlinNoise_SetFrequency_16(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/get the frequency, or physical scale,  of the noise function
		/// (higher is finer scale).  The frequency can be adjusted per axis, or
		/// the same for all axes.
		/// </summary>
		// Token: 0x0601C603 RID: 116227 RVA: 0x0027DDCF File Offset: 0x0027BFCF
		public virtual void SetFrequency(double _arg1, double _arg2, double _arg3)
		{
			vtkPerlinNoise.vtkPerlinNoise_SetFrequency_16(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601C604 RID: 116228
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerlinNoise_SetFrequency_17(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the frequency, or physical scale,  of the noise function
		/// (higher is finer scale).  The frequency can be adjusted per axis, or
		/// the same for all axes.
		/// </summary>
		// Token: 0x0601C605 RID: 116229 RVA: 0x0027DDE1 File Offset: 0x0027BFE1
		public virtual void SetFrequency(IntPtr _arg)
		{
			vtkPerlinNoise.vtkPerlinNoise_SetFrequency_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0601C606 RID: 116230
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerlinNoise_SetPhase_18(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/get the phase of the noise function.  This parameter can be used to
		/// shift the noise function within space (perhaps to avoid a beat with a
		/// noise pattern at another scale).  Phase tends to repeat about every
		/// unit, so a phase of 0.5 is a half-cycle shift.
		/// </summary>
		// Token: 0x0601C607 RID: 116231 RVA: 0x0027DDF1 File Offset: 0x0027BFF1
		public virtual void SetPhase(double _arg1, double _arg2, double _arg3)
		{
			vtkPerlinNoise.vtkPerlinNoise_SetPhase_18(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601C608 RID: 116232
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPerlinNoise_SetPhase_19(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the phase of the noise function.  This parameter can be used to
		/// shift the noise function within space (perhaps to avoid a beat with a
		/// noise pattern at another scale).  Phase tends to repeat about every
		/// unit, so a phase of 0.5 is a half-cycle shift.
		/// </summary>
		// Token: 0x0601C609 RID: 116233 RVA: 0x0027DE03 File Offset: 0x0027C003
		public virtual void SetPhase(IntPtr _arg)
		{
			vtkPerlinNoise.vtkPerlinNoise_SetPhase_19(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E23 RID: 7715
		public new const string MRFullTypeName = "Kitware.VTK.vtkPerlinNoise";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E24 RID: 7716
		public new static readonly string MRClassNameKey = "class vtkPerlinNoise";
	}
}
