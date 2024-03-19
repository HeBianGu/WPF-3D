using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageHSVToRGB
	/// </summary>
	/// <remarks>
	///    Converts HSV components to RGB.
	///
	/// For each pixel with hue, saturation and value components this filter
	/// outputs the color coded as red, green, blue.  Output type must be the same
	/// as input type.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageRGBToHSV
	/// </seealso>
	// Token: 0x020003EE RID: 1006
	public class vtkImageHSVToRGB : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C0BB RID: 49339 RVA: 0x0010C667 File Offset: 0x0010A867
		static vtkImageHSVToRGB()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageHSVToRGB.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageHSVToRGB"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C0BC RID: 49340 RVA: 0x0010C68F File Offset: 0x0010A88F
		public vtkImageHSVToRGB(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C0BD RID: 49341
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageHSVToRGB_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C0BE RID: 49342 RVA: 0x0010C6A0 File Offset: 0x0010A8A0
		public new static vtkImageHSVToRGB New()
		{
			vtkImageHSVToRGB result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageHSVToRGB.vtkImageHSVToRGB_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageHSVToRGB)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C0BF RID: 49343 RVA: 0x0010C6F4 File Offset: 0x0010A8F4
		public vtkImageHSVToRGB() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageHSVToRGB.vtkImageHSVToRGB_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C0C0 RID: 49344 RVA: 0x0010C738 File Offset: 0x0010A938
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C0C1 RID: 49345
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageHSVToRGB_GetMaximum_01(HandleRef pThis);

		/// <summary>
		/// Hue is an angle. Maximum specifies when it maps back to 0.
		/// HueMaximum defaults to 255 instead of 2PI, because unsigned char
		/// is expected as input.
		/// Maximum also specifies the maximum of the Saturation, and R, G, B.
		/// </summary>
		// Token: 0x0600C0C2 RID: 49346 RVA: 0x0010C744 File Offset: 0x0010A944
		public virtual double GetMaximum()
		{
			return vtkImageHSVToRGB.vtkImageHSVToRGB_GetMaximum_01(base.GetCppThis());
		}

		// Token: 0x0600C0C3 RID: 49347
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageHSVToRGB_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C0C4 RID: 49348 RVA: 0x0010C764 File Offset: 0x0010A964
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageHSVToRGB.vtkImageHSVToRGB_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600C0C5 RID: 49349
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageHSVToRGB_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C0C6 RID: 49350 RVA: 0x0010C784 File Offset: 0x0010A984
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageHSVToRGB.vtkImageHSVToRGB_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600C0C7 RID: 49351
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageHSVToRGB_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C0C8 RID: 49352 RVA: 0x0010C7A0 File Offset: 0x0010A9A0
		public override int IsA(string type)
		{
			return vtkImageHSVToRGB.vtkImageHSVToRGB_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600C0C9 RID: 49353
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageHSVToRGB_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C0CA RID: 49354 RVA: 0x0010C7C0 File Offset: 0x0010A9C0
		public new static int IsTypeOf(string type)
		{
			return vtkImageHSVToRGB.vtkImageHSVToRGB_IsTypeOf_05(type);
		}

		// Token: 0x0600C0CB RID: 49355
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageHSVToRGB_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C0CC RID: 49356 RVA: 0x0010C7DC File Offset: 0x0010A9DC
		public new vtkImageHSVToRGB NewInstance()
		{
			vtkImageHSVToRGB result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageHSVToRGB.vtkImageHSVToRGB_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageHSVToRGB)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C0CD RID: 49357
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageHSVToRGB_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C0CE RID: 49358 RVA: 0x0010C838 File Offset: 0x0010AA38
		public new static vtkImageHSVToRGB SafeDownCast(vtkObjectBase o)
		{
			vtkImageHSVToRGB vtkImageHSVToRGB = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageHSVToRGB.vtkImageHSVToRGB_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageHSVToRGB = (vtkImageHSVToRGB)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageHSVToRGB.Register(null);
				}
			}
			return vtkImageHSVToRGB;
		}

		// Token: 0x0600C0CF RID: 49359
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHSVToRGB_SetMaximum_09(HandleRef pThis, double _arg);

		/// <summary>
		/// Hue is an angle. Maximum specifies when it maps back to 0.
		/// HueMaximum defaults to 255 instead of 2PI, because unsigned char
		/// is expected as input.
		/// Maximum also specifies the maximum of the Saturation, and R, G, B.
		/// </summary>
		// Token: 0x0600C0D0 RID: 49360 RVA: 0x0010C8B7 File Offset: 0x0010AAB7
		public virtual void SetMaximum(double _arg)
		{
			vtkImageHSVToRGB.vtkImageHSVToRGB_SetMaximum_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E49 RID: 3657
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageHSVToRGB";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E4A RID: 3658
		public new static readonly string MRClassNameKey = "class vtkImageHSVToRGB";
	}
}
