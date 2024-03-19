using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageRGBToYIQ
	/// </summary>
	/// <remarks>
	///    Converts YIQ components to RGB.
	///
	/// For each pixel with Y, I, and Q components this
	/// filter output the color coded as RGB.
	/// Output type must be the same as input type. Only signed types should be
	/// used because the YIQ color space uses negative numbers.
	/// </remarks>
	// Token: 0x020003F7 RID: 1015
	public class vtkImageYIQToRGB : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C1C7 RID: 49607 RVA: 0x0010DFEB File Offset: 0x0010C1EB
		static vtkImageYIQToRGB()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageYIQToRGB.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageYIQToRGB"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C1C8 RID: 49608 RVA: 0x0010E013 File Offset: 0x0010C213
		public vtkImageYIQToRGB(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C1C9 RID: 49609
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageYIQToRGB_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1CA RID: 49610 RVA: 0x0010E024 File Offset: 0x0010C224
		public new static vtkImageYIQToRGB New()
		{
			vtkImageYIQToRGB result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageYIQToRGB.vtkImageYIQToRGB_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageYIQToRGB)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1CB RID: 49611 RVA: 0x0010E078 File Offset: 0x0010C278
		public vtkImageYIQToRGB() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageYIQToRGB.vtkImageYIQToRGB_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C1CC RID: 49612 RVA: 0x0010E0BC File Offset: 0x0010C2BC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C1CD RID: 49613
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageYIQToRGB_GetMaximum_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1CE RID: 49614 RVA: 0x0010E0C8 File Offset: 0x0010C2C8
		public virtual double GetMaximum()
		{
			return vtkImageYIQToRGB.vtkImageYIQToRGB_GetMaximum_01(base.GetCppThis());
		}

		// Token: 0x0600C1CF RID: 49615
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageYIQToRGB_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1D0 RID: 49616 RVA: 0x0010E0E8 File Offset: 0x0010C2E8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageYIQToRGB.vtkImageYIQToRGB_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600C1D1 RID: 49617
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageYIQToRGB_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1D2 RID: 49618 RVA: 0x0010E108 File Offset: 0x0010C308
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageYIQToRGB.vtkImageYIQToRGB_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600C1D3 RID: 49619
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageYIQToRGB_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1D4 RID: 49620 RVA: 0x0010E124 File Offset: 0x0010C324
		public override int IsA(string type)
		{
			return vtkImageYIQToRGB.vtkImageYIQToRGB_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600C1D5 RID: 49621
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageYIQToRGB_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1D6 RID: 49622 RVA: 0x0010E144 File Offset: 0x0010C344
		public new static int IsTypeOf(string type)
		{
			return vtkImageYIQToRGB.vtkImageYIQToRGB_IsTypeOf_05(type);
		}

		// Token: 0x0600C1D7 RID: 49623
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageYIQToRGB_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1D8 RID: 49624 RVA: 0x0010E160 File Offset: 0x0010C360
		public new vtkImageYIQToRGB NewInstance()
		{
			vtkImageYIQToRGB result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageYIQToRGB.vtkImageYIQToRGB_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageYIQToRGB)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C1D9 RID: 49625
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageYIQToRGB_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1DA RID: 49626 RVA: 0x0010E1BC File Offset: 0x0010C3BC
		public new static vtkImageYIQToRGB SafeDownCast(vtkObjectBase o)
		{
			vtkImageYIQToRGB vtkImageYIQToRGB = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageYIQToRGB.vtkImageYIQToRGB_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageYIQToRGB = (vtkImageYIQToRGB)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageYIQToRGB.Register(null);
				}
			}
			return vtkImageYIQToRGB;
		}

		// Token: 0x0600C1DB RID: 49627
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageYIQToRGB_SetMaximum_09(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C1DC RID: 49628 RVA: 0x0010E23B File Offset: 0x0010C43B
		public virtual void SetMaximum(double _arg)
		{
			vtkImageYIQToRGB.vtkImageYIQToRGB_SetMaximum_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E5B RID: 3675
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageYIQToRGB";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E5C RID: 3676
		public new static readonly string MRClassNameKey = "class vtkImageYIQToRGB";
	}
}
