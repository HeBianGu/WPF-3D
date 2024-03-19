using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageHSIToRGB
	/// </summary>
	/// <remarks>
	///    Converts HSI components to RGB.
	///
	/// For each pixel with hue, saturation and intensity components this filter
	/// outputs the color coded as red, green, blue.  Output type must be the same
	/// as input type.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageRGBToHSI
	/// </seealso>
	// Token: 0x020003ED RID: 1005
	public class vtkImageHSIToRGB : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C0A5 RID: 49317 RVA: 0x0010C40A File Offset: 0x0010A60A
		static vtkImageHSIToRGB()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageHSIToRGB.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageHSIToRGB"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C0A6 RID: 49318 RVA: 0x0010C432 File Offset: 0x0010A632
		public vtkImageHSIToRGB(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C0A7 RID: 49319
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageHSIToRGB_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C0A8 RID: 49320 RVA: 0x0010C440 File Offset: 0x0010A640
		public new static vtkImageHSIToRGB New()
		{
			vtkImageHSIToRGB result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageHSIToRGB.vtkImageHSIToRGB_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageHSIToRGB)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C0A9 RID: 49321 RVA: 0x0010C494 File Offset: 0x0010A694
		public vtkImageHSIToRGB() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageHSIToRGB.vtkImageHSIToRGB_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C0AA RID: 49322 RVA: 0x0010C4D8 File Offset: 0x0010A6D8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C0AB RID: 49323
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageHSIToRGB_GetMaximum_01(HandleRef pThis);

		/// <summary>
		/// Hue is an angle. Maximum specifies when it maps back to 0.
		/// HueMaximum defaults to 255 instead of 2PI, because unsigned char
		/// is expected as input.
		/// Maximum also specifies the maximum of the Saturation, and R, G, B.
		/// </summary>
		// Token: 0x0600C0AC RID: 49324 RVA: 0x0010C4E4 File Offset: 0x0010A6E4
		public virtual double GetMaximum()
		{
			return vtkImageHSIToRGB.vtkImageHSIToRGB_GetMaximum_01(base.GetCppThis());
		}

		// Token: 0x0600C0AD RID: 49325
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageHSIToRGB_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C0AE RID: 49326 RVA: 0x0010C504 File Offset: 0x0010A704
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageHSIToRGB.vtkImageHSIToRGB_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600C0AF RID: 49327
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageHSIToRGB_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C0B0 RID: 49328 RVA: 0x0010C524 File Offset: 0x0010A724
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageHSIToRGB.vtkImageHSIToRGB_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600C0B1 RID: 49329
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageHSIToRGB_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C0B2 RID: 49330 RVA: 0x0010C540 File Offset: 0x0010A740
		public override int IsA(string type)
		{
			return vtkImageHSIToRGB.vtkImageHSIToRGB_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600C0B3 RID: 49331
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageHSIToRGB_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C0B4 RID: 49332 RVA: 0x0010C560 File Offset: 0x0010A760
		public new static int IsTypeOf(string type)
		{
			return vtkImageHSIToRGB.vtkImageHSIToRGB_IsTypeOf_05(type);
		}

		// Token: 0x0600C0B5 RID: 49333
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageHSIToRGB_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C0B6 RID: 49334 RVA: 0x0010C57C File Offset: 0x0010A77C
		public new vtkImageHSIToRGB NewInstance()
		{
			vtkImageHSIToRGB result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageHSIToRGB.vtkImageHSIToRGB_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageHSIToRGB)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C0B7 RID: 49335
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageHSIToRGB_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C0B8 RID: 49336 RVA: 0x0010C5D8 File Offset: 0x0010A7D8
		public new static vtkImageHSIToRGB SafeDownCast(vtkObjectBase o)
		{
			vtkImageHSIToRGB vtkImageHSIToRGB = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageHSIToRGB.vtkImageHSIToRGB_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageHSIToRGB = (vtkImageHSIToRGB)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageHSIToRGB.Register(null);
				}
			}
			return vtkImageHSIToRGB;
		}

		// Token: 0x0600C0B9 RID: 49337
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageHSIToRGB_SetMaximum_09(HandleRef pThis, double _arg);

		/// <summary>
		/// Hue is an angle. Maximum specifies when it maps back to 0.
		/// HueMaximum defaults to 255 instead of 2PI, because unsigned char
		/// is expected as input.
		/// Maximum also specifies the maximum of the Saturation, and R, G, B.
		/// </summary>
		// Token: 0x0600C0BA RID: 49338 RVA: 0x0010C657 File Offset: 0x0010A857
		public virtual void SetMaximum(double _arg)
		{
			vtkImageHSIToRGB.vtkImageHSIToRGB_SetMaximum_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E47 RID: 3655
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageHSIToRGB";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E48 RID: 3656
		public new static readonly string MRClassNameKey = "class vtkImageHSIToRGB";
	}
}
