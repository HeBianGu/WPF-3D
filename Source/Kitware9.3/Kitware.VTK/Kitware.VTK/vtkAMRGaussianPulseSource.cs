using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAMRGaussianPulseSource
	///
	///
	///  A source that generates sample AMR data with gaussian pulse field. The user
	///  can control the refinement ratio as well as the pulse attributes such as
	///  the pulse origin, length and amplitude.
	///
	/// </summary>
	/// <seealso>
	///
	///  vtkOverlappingAMR
	/// </seealso>
	// Token: 0x020004E9 RID: 1257
	public class vtkAMRGaussianPulseSource : vtkOverlappingAMRAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E327 RID: 58151 RVA: 0x0013C4E3 File Offset: 0x0013A6E3
		static vtkAMRGaussianPulseSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAMRGaussianPulseSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAMRGaussianPulseSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E328 RID: 58152 RVA: 0x0013C50B File Offset: 0x0013A70B
		public vtkAMRGaussianPulseSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E329 RID: 58153
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRGaussianPulseSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E32A RID: 58154 RVA: 0x0013C51C File Offset: 0x0013A71C
		public new static vtkAMRGaussianPulseSource New()
		{
			vtkAMRGaussianPulseSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRGaussianPulseSource.vtkAMRGaussianPulseSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMRGaussianPulseSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E32B RID: 58155 RVA: 0x0013C570 File Offset: 0x0013A770
		public vtkAMRGaussianPulseSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAMRGaussianPulseSource.vtkAMRGaussianPulseSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E32C RID: 58156 RVA: 0x0013C5B4 File Offset: 0x0013A7B4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E32D RID: 58157
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMRGaussianPulseSource_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E32E RID: 58158 RVA: 0x0013C5C0 File Offset: 0x0013A7C0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAMRGaussianPulseSource.vtkAMRGaussianPulseSource_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600E32F RID: 58159
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMRGaussianPulseSource_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E330 RID: 58160 RVA: 0x0013C5E0 File Offset: 0x0013A7E0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAMRGaussianPulseSource.vtkAMRGaussianPulseSource_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600E331 RID: 58161
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAMRGaussianPulseSource_GetPulseAmplitude_03(HandleRef pThis);

		/// <summary>
		/// Set &amp; Get macro for the pulse amplitude
		/// </summary>
		// Token: 0x0600E332 RID: 58162 RVA: 0x0013C5FC File Offset: 0x0013A7FC
		public virtual double GetPulseAmplitude()
		{
			return vtkAMRGaussianPulseSource.vtkAMRGaussianPulseSource_GetPulseAmplitude_03(base.GetCppThis());
		}

		// Token: 0x0600E333 RID: 58163
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRGaussianPulseSource_GetPulseOrigin_04(HandleRef pThis);

		/// <summary>
		/// Set &amp; Get macro for the pulse origin
		/// </summary>
		// Token: 0x0600E334 RID: 58164 RVA: 0x0013C61C File Offset: 0x0013A81C
		public virtual double[] GetPulseOrigin()
		{
			IntPtr intPtr = vtkAMRGaussianPulseSource.vtkAMRGaussianPulseSource_GetPulseOrigin_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600E335 RID: 58165
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRGaussianPulseSource_GetPulseOrigin_05(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set &amp; Get macro for the pulse origin
		/// </summary>
		// Token: 0x0600E336 RID: 58166 RVA: 0x0013C664 File Offset: 0x0013A864
		public virtual void GetPulseOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkAMRGaussianPulseSource.vtkAMRGaussianPulseSource_GetPulseOrigin_05(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600E337 RID: 58167
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRGaussianPulseSource_GetPulseOrigin_06(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set &amp; Get macro for the pulse origin
		/// </summary>
		// Token: 0x0600E338 RID: 58168 RVA: 0x0013C676 File Offset: 0x0013A876
		public virtual void GetPulseOrigin(IntPtr _arg)
		{
			vtkAMRGaussianPulseSource.vtkAMRGaussianPulseSource_GetPulseOrigin_06(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E339 RID: 58169
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRGaussianPulseSource_GetPulseWidth_07(HandleRef pThis);

		/// <summary>
		/// Set &amp; Get macro for the pulse width
		/// </summary>
		// Token: 0x0600E33A RID: 58170 RVA: 0x0013C688 File Offset: 0x0013A888
		public virtual double[] GetPulseWidth()
		{
			IntPtr intPtr = vtkAMRGaussianPulseSource.vtkAMRGaussianPulseSource_GetPulseWidth_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600E33B RID: 58171
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRGaussianPulseSource_GetPulseWidth_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set &amp; Get macro for the pulse width
		/// </summary>
		// Token: 0x0600E33C RID: 58172 RVA: 0x0013C6D0 File Offset: 0x0013A8D0
		public virtual void GetPulseWidth(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkAMRGaussianPulseSource.vtkAMRGaussianPulseSource_GetPulseWidth_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600E33D RID: 58173
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRGaussianPulseSource_GetPulseWidth_09(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set &amp; Get macro for the pulse width
		/// </summary>
		// Token: 0x0600E33E RID: 58174 RVA: 0x0013C6E2 File Offset: 0x0013A8E2
		public virtual void GetPulseWidth(IntPtr _arg)
		{
			vtkAMRGaussianPulseSource.vtkAMRGaussianPulseSource_GetPulseWidth_09(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E33F RID: 58175
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRGaussianPulseSource_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E340 RID: 58176 RVA: 0x0013C6F4 File Offset: 0x0013A8F4
		public override int IsA(string type)
		{
			return vtkAMRGaussianPulseSource.vtkAMRGaussianPulseSource_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0600E341 RID: 58177
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRGaussianPulseSource_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E342 RID: 58178 RVA: 0x0013C714 File Offset: 0x0013A914
		public new static int IsTypeOf(string type)
		{
			return vtkAMRGaussianPulseSource.vtkAMRGaussianPulseSource_IsTypeOf_11(type);
		}

		// Token: 0x0600E343 RID: 58179
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRGaussianPulseSource_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E344 RID: 58180 RVA: 0x0013C730 File Offset: 0x0013A930
		public new vtkAMRGaussianPulseSource NewInstance()
		{
			vtkAMRGaussianPulseSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRGaussianPulseSource.vtkAMRGaussianPulseSource_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMRGaussianPulseSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E345 RID: 58181
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRGaussianPulseSource_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E346 RID: 58182 RVA: 0x0013C78C File Offset: 0x0013A98C
		public new static vtkAMRGaussianPulseSource SafeDownCast(vtkObjectBase o)
		{
			vtkAMRGaussianPulseSource vtkAMRGaussianPulseSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRGaussianPulseSource.vtkAMRGaussianPulseSource_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAMRGaussianPulseSource = (vtkAMRGaussianPulseSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAMRGaussianPulseSource.Register(null);
				}
			}
			return vtkAMRGaussianPulseSource;
		}

		// Token: 0x0600E347 RID: 58183
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRGaussianPulseSource_SetDimension_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Sets the dimension of the AMR dataset to generate
		/// </summary>
		// Token: 0x0600E348 RID: 58184 RVA: 0x0013C80B File Offset: 0x0013AA0B
		public virtual void SetDimension(int _arg)
		{
			vtkAMRGaussianPulseSource.vtkAMRGaussianPulseSource_SetDimension_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E349 RID: 58185
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRGaussianPulseSource_SetNumberOfLevels_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Sets the number of levels to generate
		/// </summary>
		// Token: 0x0600E34A RID: 58186 RVA: 0x0013C81B File Offset: 0x0013AA1B
		public virtual void SetNumberOfLevels(int _arg)
		{
			vtkAMRGaussianPulseSource.vtkAMRGaussianPulseSource_SetNumberOfLevels_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E34B RID: 58187
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRGaussianPulseSource_SetPulseAmplitude_17(HandleRef pThis, double _arg);

		/// <summary>
		/// Set &amp; Get macro for the pulse amplitude
		/// </summary>
		// Token: 0x0600E34C RID: 58188 RVA: 0x0013C82B File Offset: 0x0013AA2B
		public virtual void SetPulseAmplitude(double _arg)
		{
			vtkAMRGaussianPulseSource.vtkAMRGaussianPulseSource_SetPulseAmplitude_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E34D RID: 58189
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRGaussianPulseSource_SetPulseOrigin_18(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set &amp; Get macro for the pulse origin
		/// </summary>
		// Token: 0x0600E34E RID: 58190 RVA: 0x0013C83B File Offset: 0x0013AA3B
		public virtual void SetPulseOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkAMRGaussianPulseSource.vtkAMRGaussianPulseSource_SetPulseOrigin_18(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600E34F RID: 58191
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRGaussianPulseSource_SetPulseOrigin_19(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set &amp; Get macro for the pulse origin
		/// </summary>
		// Token: 0x0600E350 RID: 58192 RVA: 0x0013C84D File Offset: 0x0013AA4D
		public virtual void SetPulseOrigin(IntPtr _arg)
		{
			vtkAMRGaussianPulseSource.vtkAMRGaussianPulseSource_SetPulseOrigin_19(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E351 RID: 58193
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRGaussianPulseSource_SetPulseWidth_20(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set &amp; Get macro for the pulse width
		/// </summary>
		// Token: 0x0600E352 RID: 58194 RVA: 0x0013C85D File Offset: 0x0013AA5D
		public virtual void SetPulseWidth(double _arg1, double _arg2, double _arg3)
		{
			vtkAMRGaussianPulseSource.vtkAMRGaussianPulseSource_SetPulseWidth_20(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600E353 RID: 58195
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRGaussianPulseSource_SetPulseWidth_21(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set &amp; Get macro for the pulse width
		/// </summary>
		// Token: 0x0600E354 RID: 58196 RVA: 0x0013C86F File Offset: 0x0013AA6F
		public virtual void SetPulseWidth(IntPtr _arg)
		{
			vtkAMRGaussianPulseSource.vtkAMRGaussianPulseSource_SetPulseWidth_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E355 RID: 58197
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRGaussianPulseSource_SetRefinementRatio_22(HandleRef pThis, int r);

		/// <summary>
		/// Set the refinement ratio
		/// </summary>
		// Token: 0x0600E356 RID: 58198 RVA: 0x0013C87F File Offset: 0x0013AA7F
		public void SetRefinementRatio(int r)
		{
			vtkAMRGaussianPulseSource.vtkAMRGaussianPulseSource_SetRefinementRatio_22(base.GetCppThis(), r);
		}

		// Token: 0x0600E357 RID: 58199
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRGaussianPulseSource_SetRootSpacing_23(HandleRef pThis, double h0);

		/// <summary>
		/// Set the root spacing
		/// </summary>
		// Token: 0x0600E358 RID: 58200 RVA: 0x0013C88F File Offset: 0x0013AA8F
		public void SetRootSpacing(double h0)
		{
			vtkAMRGaussianPulseSource.vtkAMRGaussianPulseSource_SetRootSpacing_23(base.GetCppThis(), h0);
		}

		// Token: 0x0600E359 RID: 58201
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRGaussianPulseSource_SetXPulseOrigin_24(HandleRef pThis, double f);

		/// <summary>
		/// Set &amp; Get macro for the pulse origin
		/// </summary>
		// Token: 0x0600E35A RID: 58202 RVA: 0x0013C89F File Offset: 0x0013AA9F
		public void SetXPulseOrigin(double f)
		{
			vtkAMRGaussianPulseSource.vtkAMRGaussianPulseSource_SetXPulseOrigin_24(base.GetCppThis(), f);
		}

		// Token: 0x0600E35B RID: 58203
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRGaussianPulseSource_SetXPulseWidth_25(HandleRef pThis, double f);

		/// <summary>
		/// Set &amp; Get macro for the pulse width
		/// </summary>
		// Token: 0x0600E35C RID: 58204 RVA: 0x0013C8AF File Offset: 0x0013AAAF
		public void SetXPulseWidth(double f)
		{
			vtkAMRGaussianPulseSource.vtkAMRGaussianPulseSource_SetXPulseWidth_25(base.GetCppThis(), f);
		}

		// Token: 0x0600E35D RID: 58205
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRGaussianPulseSource_SetYPulseOrigin_26(HandleRef pThis, double f);

		/// <summary>
		/// Set &amp; Get macro for the pulse origin
		/// </summary>
		// Token: 0x0600E35E RID: 58206 RVA: 0x0013C8BF File Offset: 0x0013AABF
		public void SetYPulseOrigin(double f)
		{
			vtkAMRGaussianPulseSource.vtkAMRGaussianPulseSource_SetYPulseOrigin_26(base.GetCppThis(), f);
		}

		// Token: 0x0600E35F RID: 58207
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRGaussianPulseSource_SetYPulseWidth_27(HandleRef pThis, double f);

		/// <summary>
		/// Set &amp; Get macro for the pulse width
		/// </summary>
		// Token: 0x0600E360 RID: 58208 RVA: 0x0013C8CF File Offset: 0x0013AACF
		public void SetYPulseWidth(double f)
		{
			vtkAMRGaussianPulseSource.vtkAMRGaussianPulseSource_SetYPulseWidth_27(base.GetCppThis(), f);
		}

		// Token: 0x0600E361 RID: 58209
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRGaussianPulseSource_SetZPulseOrigin_28(HandleRef pThis, double f);

		/// <summary>
		/// Set &amp; Get macro for the pulse origin
		/// </summary>
		// Token: 0x0600E362 RID: 58210 RVA: 0x0013C8DF File Offset: 0x0013AADF
		public void SetZPulseOrigin(double f)
		{
			vtkAMRGaussianPulseSource.vtkAMRGaussianPulseSource_SetZPulseOrigin_28(base.GetCppThis(), f);
		}

		// Token: 0x0600E363 RID: 58211
		[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRGaussianPulseSource_SetZPulseWidth_29(HandleRef pThis, double f);

		/// <summary>
		/// Set &amp; Get macro for the pulse width
		/// </summary>
		// Token: 0x0600E364 RID: 58212 RVA: 0x0013C8EF File Offset: 0x0013AAEF
		public void SetZPulseWidth(double f)
		{
			vtkAMRGaussianPulseSource.vtkAMRGaussianPulseSource_SetZPulseWidth_29(base.GetCppThis(), f);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010B5 RID: 4277
		public new const string MRFullTypeName = "Kitware.VTK.vtkAMRGaussianPulseSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010B6 RID: 4278
		public new static readonly string MRClassNameKey = "class vtkAMRGaussianPulseSource";
	}
}
