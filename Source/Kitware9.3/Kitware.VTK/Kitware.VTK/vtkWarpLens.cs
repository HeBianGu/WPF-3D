using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkWarpLens
	/// </summary>
	/// <remarks>
	///    deform geometry by applying lens distortion
	///
	/// vtkWarpLens is a filter that modifies point coordinates by moving
	/// in accord with a lens distortion model.
	/// </remarks>
	// Token: 0x020008F9 RID: 2297
	public class vtkWarpLens : vtkPointSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017B73 RID: 97139 RVA: 0x00214235 File Offset: 0x00212435
		static vtkWarpLens()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWarpLens.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWarpLens"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017B74 RID: 97140 RVA: 0x0021425D File Offset: 0x0021245D
		public vtkWarpLens(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017B75 RID: 97141
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWarpLens_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B76 RID: 97142 RVA: 0x0021426C File Offset: 0x0021246C
		public new static vtkWarpLens New()
		{
			vtkWarpLens result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWarpLens.vtkWarpLens_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWarpLens)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B77 RID: 97143 RVA: 0x002142C0 File Offset: 0x002124C0
		public vtkWarpLens() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkWarpLens.vtkWarpLens_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017B78 RID: 97144 RVA: 0x00214304 File Offset: 0x00212504
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017B79 RID: 97145
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWarpLens_FillInputPortInformation_01(HandleRef pThis, int port, HandleRef info);

		/// <summary>
		/// Specify the image width / height in pixels
		/// </summary>
		// Token: 0x06017B7A RID: 97146 RVA: 0x00214310 File Offset: 0x00212510
		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkWarpLens.vtkWarpLens_FillInputPortInformation_01(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x06017B7B RID: 97147
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWarpLens_GetCenter_02(HandleRef pThis);

		/// <summary>
		/// Specify the center of radial distortion in pixels.
		/// This is obsoleted by newer instance variables.
		/// </summary>
		// Token: 0x06017B7C RID: 97148 RVA: 0x00214348 File Offset: 0x00212548
		public double[] GetCenter()
		{
			IntPtr intPtr = vtkWarpLens.vtkWarpLens_GetCenter_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06017B7D RID: 97149
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkWarpLens_GetFormatHeight_03(HandleRef pThis);

		/// <summary>
		/// Specify the imager format width / height in mm
		/// </summary>
		// Token: 0x06017B7E RID: 97150 RVA: 0x00214390 File Offset: 0x00212590
		public virtual double GetFormatHeight()
		{
			return vtkWarpLens.vtkWarpLens_GetFormatHeight_03(base.GetCppThis());
		}

		// Token: 0x06017B7F RID: 97151
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkWarpLens_GetFormatWidth_04(HandleRef pThis);

		/// <summary>
		/// Specify the imager format width / height in mm
		/// </summary>
		// Token: 0x06017B80 RID: 97152 RVA: 0x002143B0 File Offset: 0x002125B0
		public virtual double GetFormatWidth()
		{
			return vtkWarpLens.vtkWarpLens_GetFormatWidth_04(base.GetCppThis());
		}

		// Token: 0x06017B81 RID: 97153
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWarpLens_GetImageHeight_05(HandleRef pThis);

		/// <summary>
		/// Specify the image width / height in pixels
		/// </summary>
		// Token: 0x06017B82 RID: 97154 RVA: 0x002143D0 File Offset: 0x002125D0
		public virtual int GetImageHeight()
		{
			return vtkWarpLens.vtkWarpLens_GetImageHeight_05(base.GetCppThis());
		}

		// Token: 0x06017B83 RID: 97155
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWarpLens_GetImageWidth_06(HandleRef pThis);

		/// <summary>
		/// Specify the image width / height in pixels
		/// </summary>
		// Token: 0x06017B84 RID: 97156 RVA: 0x002143F0 File Offset: 0x002125F0
		public virtual int GetImageWidth()
		{
			return vtkWarpLens.vtkWarpLens_GetImageWidth_06(base.GetCppThis());
		}

		// Token: 0x06017B85 RID: 97157
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkWarpLens_GetK1_07(HandleRef pThis);

		/// <summary>
		/// Specify the symmetric radial distortion parameters for the lens
		/// </summary>
		// Token: 0x06017B86 RID: 97158 RVA: 0x00214410 File Offset: 0x00212610
		public virtual double GetK1()
		{
			return vtkWarpLens.vtkWarpLens_GetK1_07(base.GetCppThis());
		}

		// Token: 0x06017B87 RID: 97159
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkWarpLens_GetK2_08(HandleRef pThis);

		/// <summary>
		/// Specify the symmetric radial distortion parameters for the lens
		/// </summary>
		// Token: 0x06017B88 RID: 97160 RVA: 0x00214430 File Offset: 0x00212630
		public virtual double GetK2()
		{
			return vtkWarpLens.vtkWarpLens_GetK2_08(base.GetCppThis());
		}

		// Token: 0x06017B89 RID: 97161
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkWarpLens_GetKappa_09(HandleRef pThis);

		/// <summary>
		/// Specify second order symmetric radial lens distortion parameter.
		/// This is obsoleted by newer instance variables.
		/// </summary>
		// Token: 0x06017B8A RID: 97162 RVA: 0x00214450 File Offset: 0x00212650
		public double GetKappa()
		{
			return vtkWarpLens.vtkWarpLens_GetKappa_09(base.GetCppThis());
		}

		// Token: 0x06017B8B RID: 97163
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWarpLens_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B8C RID: 97164 RVA: 0x00214470 File Offset: 0x00212670
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkWarpLens.vtkWarpLens_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x06017B8D RID: 97165
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWarpLens_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B8E RID: 97166 RVA: 0x00214490 File Offset: 0x00212690
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkWarpLens.vtkWarpLens_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x06017B8F RID: 97167
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkWarpLens_GetP1_12(HandleRef pThis);

		/// <summary>
		/// Specify the decentering distortion parameters for the lens
		/// </summary>
		// Token: 0x06017B90 RID: 97168 RVA: 0x002144AC File Offset: 0x002126AC
		public virtual double GetP1()
		{
			return vtkWarpLens.vtkWarpLens_GetP1_12(base.GetCppThis());
		}

		// Token: 0x06017B91 RID: 97169
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkWarpLens_GetP2_13(HandleRef pThis);

		/// <summary>
		/// Specify the decentering distortion parameters for the lens
		/// </summary>
		// Token: 0x06017B92 RID: 97170 RVA: 0x002144CC File Offset: 0x002126CC
		public virtual double GetP2()
		{
			return vtkWarpLens.vtkWarpLens_GetP2_13(base.GetCppThis());
		}

		// Token: 0x06017B93 RID: 97171
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWarpLens_GetPrincipalPoint_14(HandleRef pThis);

		/// <summary>
		/// Specify the calibrated principal point of the camera/lens
		/// </summary>
		// Token: 0x06017B94 RID: 97172 RVA: 0x002144EC File Offset: 0x002126EC
		public virtual double[] GetPrincipalPoint()
		{
			IntPtr intPtr = vtkWarpLens.vtkWarpLens_GetPrincipalPoint_14(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06017B95 RID: 97173
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpLens_GetPrincipalPoint_15(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the calibrated principal point of the camera/lens
		/// </summary>
		// Token: 0x06017B96 RID: 97174 RVA: 0x00214534 File Offset: 0x00212734
		public virtual void GetPrincipalPoint(IntPtr data)
		{
			vtkWarpLens.vtkWarpLens_GetPrincipalPoint_15(base.GetCppThis(), data);
		}

		// Token: 0x06017B97 RID: 97175
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWarpLens_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B98 RID: 97176 RVA: 0x00214544 File Offset: 0x00212744
		public override int IsA(string type)
		{
			return vtkWarpLens.vtkWarpLens_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x06017B99 RID: 97177
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWarpLens_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B9A RID: 97178 RVA: 0x00214564 File Offset: 0x00212764
		public new static int IsTypeOf(string type)
		{
			return vtkWarpLens.vtkWarpLens_IsTypeOf_17(type);
		}

		// Token: 0x06017B9B RID: 97179
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWarpLens_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B9C RID: 97180 RVA: 0x00214580 File Offset: 0x00212780
		public new vtkWarpLens NewInstance()
		{
			vtkWarpLens result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWarpLens.vtkWarpLens_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWarpLens)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017B9D RID: 97181
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWarpLens_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B9E RID: 97182 RVA: 0x002145DC File Offset: 0x002127DC
		public new static vtkWarpLens SafeDownCast(vtkObjectBase o)
		{
			vtkWarpLens vtkWarpLens = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWarpLens.vtkWarpLens_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWarpLens = (vtkWarpLens)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWarpLens.Register(null);
				}
			}
			return vtkWarpLens;
		}

		// Token: 0x06017B9F RID: 97183
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpLens_SetCenter_21(HandleRef pThis, double centerX, double centerY);

		/// <summary>
		/// Specify the center of radial distortion in pixels.
		/// This is obsoleted by newer instance variables.
		/// </summary>
		// Token: 0x06017BA0 RID: 97184 RVA: 0x0021465B File Offset: 0x0021285B
		public void SetCenter(double centerX, double centerY)
		{
			vtkWarpLens.vtkWarpLens_SetCenter_21(base.GetCppThis(), centerX, centerY);
		}

		// Token: 0x06017BA1 RID: 97185
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpLens_SetFormatHeight_22(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the imager format width / height in mm
		/// </summary>
		// Token: 0x06017BA2 RID: 97186 RVA: 0x0021466C File Offset: 0x0021286C
		public virtual void SetFormatHeight(double _arg)
		{
			vtkWarpLens.vtkWarpLens_SetFormatHeight_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06017BA3 RID: 97187
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpLens_SetFormatWidth_23(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the imager format width / height in mm
		/// </summary>
		// Token: 0x06017BA4 RID: 97188 RVA: 0x0021467C File Offset: 0x0021287C
		public virtual void SetFormatWidth(double _arg)
		{
			vtkWarpLens.vtkWarpLens_SetFormatWidth_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06017BA5 RID: 97189
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpLens_SetImageHeight_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the image width / height in pixels
		/// </summary>
		// Token: 0x06017BA6 RID: 97190 RVA: 0x0021468C File Offset: 0x0021288C
		public virtual void SetImageHeight(int _arg)
		{
			vtkWarpLens.vtkWarpLens_SetImageHeight_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06017BA7 RID: 97191
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpLens_SetImageWidth_25(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the image width / height in pixels
		/// </summary>
		// Token: 0x06017BA8 RID: 97192 RVA: 0x0021469C File Offset: 0x0021289C
		public virtual void SetImageWidth(int _arg)
		{
			vtkWarpLens.vtkWarpLens_SetImageWidth_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06017BA9 RID: 97193
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpLens_SetK1_26(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the symmetric radial distortion parameters for the lens
		/// </summary>
		// Token: 0x06017BAA RID: 97194 RVA: 0x002146AC File Offset: 0x002128AC
		public virtual void SetK1(double _arg)
		{
			vtkWarpLens.vtkWarpLens_SetK1_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06017BAB RID: 97195
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpLens_SetK2_27(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the symmetric radial distortion parameters for the lens
		/// </summary>
		// Token: 0x06017BAC RID: 97196 RVA: 0x002146BC File Offset: 0x002128BC
		public virtual void SetK2(double _arg)
		{
			vtkWarpLens.vtkWarpLens_SetK2_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06017BAD RID: 97197
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpLens_SetKappa_28(HandleRef pThis, double kappa);

		/// <summary>
		/// Specify second order symmetric radial lens distortion parameter.
		/// This is obsoleted by newer instance variables.
		/// </summary>
		// Token: 0x06017BAE RID: 97198 RVA: 0x002146CC File Offset: 0x002128CC
		public void SetKappa(double kappa)
		{
			vtkWarpLens.vtkWarpLens_SetKappa_28(base.GetCppThis(), kappa);
		}

		// Token: 0x06017BAF RID: 97199
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpLens_SetP1_29(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the decentering distortion parameters for the lens
		/// </summary>
		// Token: 0x06017BB0 RID: 97200 RVA: 0x002146DC File Offset: 0x002128DC
		public virtual void SetP1(double _arg)
		{
			vtkWarpLens.vtkWarpLens_SetP1_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06017BB1 RID: 97201
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpLens_SetP2_30(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the decentering distortion parameters for the lens
		/// </summary>
		// Token: 0x06017BB2 RID: 97202 RVA: 0x002146EC File Offset: 0x002128EC
		public virtual void SetP2(double _arg)
		{
			vtkWarpLens.vtkWarpLens_SetP2_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06017BB3 RID: 97203
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpLens_SetPrincipalPoint_31(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Specify the calibrated principal point of the camera/lens
		/// </summary>
		// Token: 0x06017BB4 RID: 97204 RVA: 0x002146FC File Offset: 0x002128FC
		public virtual void SetPrincipalPoint(double _arg1, double _arg2)
		{
			vtkWarpLens.vtkWarpLens_SetPrincipalPoint_31(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06017BB5 RID: 97205
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpLens_SetPrincipalPoint_32(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the calibrated principal point of the camera/lens
		/// </summary>
		// Token: 0x06017BB6 RID: 97206 RVA: 0x0021470D File Offset: 0x0021290D
		public void SetPrincipalPoint(IntPtr _arg)
		{
			vtkWarpLens.vtkWarpLens_SetPrincipalPoint_32(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A71 RID: 6769
		public new const string MRFullTypeName = "Kitware.VTK.vtkWarpLens";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A72 RID: 6770
		public new static readonly string MRClassNameKey = "class vtkWarpLens";
	}
}
