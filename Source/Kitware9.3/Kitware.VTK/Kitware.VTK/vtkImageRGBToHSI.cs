using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageRGBToHSI
	/// </summary>
	/// <remarks>
	///    Converts RGB components to HSI.
	///
	/// For each pixel with red, blue, and green components this
	/// filter output the color coded as hue, saturation and intensity.
	/// Output type must be the same as input type.
	/// </remarks>
	// Token: 0x020003F4 RID: 1012
	public class vtkImageRGBToHSI : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C185 RID: 49541 RVA: 0x0010D8CB File Offset: 0x0010BACB
		static vtkImageRGBToHSI()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageRGBToHSI.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageRGBToHSI"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C186 RID: 49542 RVA: 0x0010D8F3 File Offset: 0x0010BAF3
		public vtkImageRGBToHSI(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C187 RID: 49543
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageRGBToHSI_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C188 RID: 49544 RVA: 0x0010D904 File Offset: 0x0010BB04
		public new static vtkImageRGBToHSI New()
		{
			vtkImageRGBToHSI result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageRGBToHSI.vtkImageRGBToHSI_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageRGBToHSI)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C189 RID: 49545 RVA: 0x0010D958 File Offset: 0x0010BB58
		public vtkImageRGBToHSI() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageRGBToHSI.vtkImageRGBToHSI_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C18A RID: 49546 RVA: 0x0010D99C File Offset: 0x0010BB9C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C18B RID: 49547
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageRGBToHSI_GetMaximum_01(HandleRef pThis);

		/// <summary>
		/// Hue is an angle. Maximum specifies when it maps back to 0.  HueMaximum
		/// defaults to 255 instead of 2PI, because unsigned char is expected as
		/// input.  Maximum also specifies the maximum of the Saturation.
		/// </summary>
		// Token: 0x0600C18C RID: 49548 RVA: 0x0010D9A8 File Offset: 0x0010BBA8
		public virtual double GetMaximum()
		{
			return vtkImageRGBToHSI.vtkImageRGBToHSI_GetMaximum_01(base.GetCppThis());
		}

		// Token: 0x0600C18D RID: 49549
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageRGBToHSI_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C18E RID: 49550 RVA: 0x0010D9C8 File Offset: 0x0010BBC8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageRGBToHSI.vtkImageRGBToHSI_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600C18F RID: 49551
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageRGBToHSI_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C190 RID: 49552 RVA: 0x0010D9E8 File Offset: 0x0010BBE8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageRGBToHSI.vtkImageRGBToHSI_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600C191 RID: 49553
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageRGBToHSI_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C192 RID: 49554 RVA: 0x0010DA04 File Offset: 0x0010BC04
		public override int IsA(string type)
		{
			return vtkImageRGBToHSI.vtkImageRGBToHSI_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600C193 RID: 49555
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageRGBToHSI_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C194 RID: 49556 RVA: 0x0010DA24 File Offset: 0x0010BC24
		public new static int IsTypeOf(string type)
		{
			return vtkImageRGBToHSI.vtkImageRGBToHSI_IsTypeOf_05(type);
		}

		// Token: 0x0600C195 RID: 49557
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageRGBToHSI_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C196 RID: 49558 RVA: 0x0010DA40 File Offset: 0x0010BC40
		public new vtkImageRGBToHSI NewInstance()
		{
			vtkImageRGBToHSI result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageRGBToHSI.vtkImageRGBToHSI_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageRGBToHSI)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C197 RID: 49559
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageRGBToHSI_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C198 RID: 49560 RVA: 0x0010DA9C File Offset: 0x0010BC9C
		public new static vtkImageRGBToHSI SafeDownCast(vtkObjectBase o)
		{
			vtkImageRGBToHSI vtkImageRGBToHSI = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageRGBToHSI.vtkImageRGBToHSI_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageRGBToHSI = (vtkImageRGBToHSI)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageRGBToHSI.Register(null);
				}
			}
			return vtkImageRGBToHSI;
		}

		// Token: 0x0600C199 RID: 49561
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageRGBToHSI_SetMaximum_09(HandleRef pThis, double _arg);

		/// <summary>
		/// Hue is an angle. Maximum specifies when it maps back to 0.  HueMaximum
		/// defaults to 255 instead of 2PI, because unsigned char is expected as
		/// input.  Maximum also specifies the maximum of the Saturation.
		/// </summary>
		// Token: 0x0600C19A RID: 49562 RVA: 0x0010DB1B File Offset: 0x0010BD1B
		public virtual void SetMaximum(double _arg)
		{
			vtkImageRGBToHSI.vtkImageRGBToHSI_SetMaximum_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E55 RID: 3669
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageRGBToHSI";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E56 RID: 3670
		public new static readonly string MRClassNameKey = "class vtkImageRGBToHSI";
	}
}
