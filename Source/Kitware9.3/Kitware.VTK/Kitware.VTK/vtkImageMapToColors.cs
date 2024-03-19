using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageMapToColors
	/// </summary>
	/// <remarks>
	///    map the input image through a lookup table
	///
	/// The vtkImageMapToColors filter will take an input image of any valid
	/// scalar type, and map the first component of the image through a
	/// lookup table.  The result is an image of type VTK_UNSIGNED_CHAR.
	/// If the lookup table is not set, or is set to nullptr, then the input
	/// data will be passed through if it is already of type VTK_UNSIGNED_CHAR.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkLookupTable vtkScalarsToColors
	/// </seealso>
	// Token: 0x020003F0 RID: 1008
	public class vtkImageMapToColors : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C0E3 RID: 49379 RVA: 0x0010CAF7 File Offset: 0x0010ACF7
		static vtkImageMapToColors()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageMapToColors.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMapToColors"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C0E4 RID: 49380 RVA: 0x0010CB1F File Offset: 0x0010AD1F
		public vtkImageMapToColors(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C0E5 RID: 49381
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMapToColors_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C0E6 RID: 49382 RVA: 0x0010CB30 File Offset: 0x0010AD30
		public new static vtkImageMapToColors New()
		{
			vtkImageMapToColors result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMapToColors.vtkImageMapToColors_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMapToColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C0E7 RID: 49383 RVA: 0x0010CB84 File Offset: 0x0010AD84
		public vtkImageMapToColors() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageMapToColors.vtkImageMapToColors_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C0E8 RID: 49384 RVA: 0x0010CBC8 File Offset: 0x0010ADC8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C0E9 RID: 49385
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMapToColors_GetActiveComponent_01(HandleRef pThis);

		/// <summary>
		/// Set the component to map for multi-component images (default: 0)
		/// </summary>
		// Token: 0x0600C0EA RID: 49386 RVA: 0x0010CBD4 File Offset: 0x0010ADD4
		public virtual int GetActiveComponent()
		{
			return vtkImageMapToColors.vtkImageMapToColors_GetActiveComponent_01(base.GetCppThis());
		}

		// Token: 0x0600C0EB RID: 49387
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMapToColors_GetLookupTable_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the lookup table.
		/// </summary>
		// Token: 0x0600C0EC RID: 49388 RVA: 0x0010CBF4 File Offset: 0x0010ADF4
		public virtual vtkScalarsToColors GetLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMapToColors.vtkImageMapToColors_GetLookupTable_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToColors = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToColors.Register(null);
				}
			}
			return vtkScalarsToColors;
		}

		// Token: 0x0600C0ED RID: 49389
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkImageMapToColors_GetMTime_03(HandleRef pThis);

		/// <summary>
		/// We need to check the modified time of the lookup table too.
		/// </summary>
		// Token: 0x0600C0EE RID: 49390 RVA: 0x0010CC64 File Offset: 0x0010AE64
		public override ulong GetMTime()
		{
			return vtkImageMapToColors.vtkImageMapToColors_GetMTime_03(base.GetCppThis());
		}

		// Token: 0x0600C0EF RID: 49391
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMapToColors_GetNaNColor_04(HandleRef pThis);

		/// <summary>
		/// Set/Get Color that should be used in case of UnMatching
		/// data.
		/// </summary>
		// Token: 0x0600C0F0 RID: 49392 RVA: 0x0010CC84 File Offset: 0x0010AE84
		public virtual byte[] GetNaNColor()
		{
			IntPtr intPtr = vtkImageMapToColors.vtkImageMapToColors_GetNaNColor_04(base.GetCppThis());
			byte[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new byte[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600C0F1 RID: 49393
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapToColors_GetNaNColor_05(HandleRef pThis, ref byte _arg1, ref byte _arg2, ref byte _arg3, ref byte _arg4);

		/// <summary>
		/// Set/Get Color that should be used in case of UnMatching
		/// data.
		/// </summary>
		// Token: 0x0600C0F2 RID: 49394 RVA: 0x0010CCCC File Offset: 0x0010AECC
		public virtual void GetNaNColor(ref byte _arg1, ref byte _arg2, ref byte _arg3, ref byte _arg4)
		{
			vtkImageMapToColors.vtkImageMapToColors_GetNaNColor_05(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x0600C0F3 RID: 49395
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapToColors_GetNaNColor_06(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get Color that should be used in case of UnMatching
		/// data.
		/// </summary>
		// Token: 0x0600C0F4 RID: 49396 RVA: 0x0010CCE0 File Offset: 0x0010AEE0
		public virtual void GetNaNColor(IntPtr _arg)
		{
			vtkImageMapToColors.vtkImageMapToColors_GetNaNColor_06(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C0F5 RID: 49397
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageMapToColors_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C0F6 RID: 49398 RVA: 0x0010CCF0 File Offset: 0x0010AEF0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageMapToColors.vtkImageMapToColors_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0600C0F7 RID: 49399
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageMapToColors_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C0F8 RID: 49400 RVA: 0x0010CD10 File Offset: 0x0010AF10
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageMapToColors.vtkImageMapToColors_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0600C0F9 RID: 49401
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMapToColors_GetOutputFormat_09(HandleRef pThis);

		/// <summary>
		/// Set the output format, the default is RGBA.
		/// </summary>
		// Token: 0x0600C0FA RID: 49402 RVA: 0x0010CD2C File Offset: 0x0010AF2C
		public virtual int GetOutputFormat()
		{
			return vtkImageMapToColors.vtkImageMapToColors_GetOutputFormat_09(base.GetCppThis());
		}

		// Token: 0x0600C0FB RID: 49403
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMapToColors_GetPassAlphaToOutput_10(HandleRef pThis);

		/// <summary>
		/// Use the alpha component of the input when computing the alpha component
		/// of the output (useful when converting monochrome+alpha data to RGBA)
		/// </summary>
		// Token: 0x0600C0FC RID: 49404 RVA: 0x0010CD4C File Offset: 0x0010AF4C
		public virtual int GetPassAlphaToOutput()
		{
			return vtkImageMapToColors.vtkImageMapToColors_GetPassAlphaToOutput_10(base.GetCppThis());
		}

		// Token: 0x0600C0FD RID: 49405
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMapToColors_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C0FE RID: 49406 RVA: 0x0010CD6C File Offset: 0x0010AF6C
		public override int IsA(string type)
		{
			return vtkImageMapToColors.vtkImageMapToColors_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0600C0FF RID: 49407
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMapToColors_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C100 RID: 49408 RVA: 0x0010CD8C File Offset: 0x0010AF8C
		public new static int IsTypeOf(string type)
		{
			return vtkImageMapToColors.vtkImageMapToColors_IsTypeOf_12(type);
		}

		// Token: 0x0600C101 RID: 49409
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMapToColors_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C102 RID: 49410 RVA: 0x0010CDA8 File Offset: 0x0010AFA8
		public new vtkImageMapToColors NewInstance()
		{
			vtkImageMapToColors result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMapToColors.vtkImageMapToColors_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMapToColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C103 RID: 49411
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapToColors_PassAlphaToOutputOff_15(HandleRef pThis);

		/// <summary>
		/// Use the alpha component of the input when computing the alpha component
		/// of the output (useful when converting monochrome+alpha data to RGBA)
		/// </summary>
		// Token: 0x0600C104 RID: 49412 RVA: 0x0010CE02 File Offset: 0x0010B002
		public virtual void PassAlphaToOutputOff()
		{
			vtkImageMapToColors.vtkImageMapToColors_PassAlphaToOutputOff_15(base.GetCppThis());
		}

		// Token: 0x0600C105 RID: 49413
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapToColors_PassAlphaToOutputOn_16(HandleRef pThis);

		/// <summary>
		/// Use the alpha component of the input when computing the alpha component
		/// of the output (useful when converting monochrome+alpha data to RGBA)
		/// </summary>
		// Token: 0x0600C106 RID: 49414 RVA: 0x0010CE11 File Offset: 0x0010B011
		public virtual void PassAlphaToOutputOn()
		{
			vtkImageMapToColors.vtkImageMapToColors_PassAlphaToOutputOn_16(base.GetCppThis());
		}

		// Token: 0x0600C107 RID: 49415
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMapToColors_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C108 RID: 49416 RVA: 0x0010CE20 File Offset: 0x0010B020
		public new static vtkImageMapToColors SafeDownCast(vtkObjectBase o)
		{
			vtkImageMapToColors vtkImageMapToColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMapToColors.vtkImageMapToColors_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMapToColors = (vtkImageMapToColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMapToColors.Register(null);
				}
			}
			return vtkImageMapToColors;
		}

		// Token: 0x0600C109 RID: 49417
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapToColors_SetActiveComponent_18(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the component to map for multi-component images (default: 0)
		/// </summary>
		// Token: 0x0600C10A RID: 49418 RVA: 0x0010CE9F File Offset: 0x0010B09F
		public virtual void SetActiveComponent(int _arg)
		{
			vtkImageMapToColors.vtkImageMapToColors_SetActiveComponent_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C10B RID: 49419
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapToColors_SetLookupTable_19(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the lookup table.
		/// </summary>
		// Token: 0x0600C10C RID: 49420 RVA: 0x0010CEB0 File Offset: 0x0010B0B0
		public virtual void SetLookupTable(vtkScalarsToColors arg0)
		{
			vtkImageMapToColors.vtkImageMapToColors_SetLookupTable_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600C10D RID: 49421
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapToColors_SetNaNColor_20(HandleRef pThis, byte _arg1, byte _arg2, byte _arg3, byte _arg4);

		/// <summary>
		/// Set/Get Color that should be used in case of UnMatching
		/// data.
		/// </summary>
		// Token: 0x0600C10E RID: 49422 RVA: 0x0010CEDF File Offset: 0x0010B0DF
		public virtual void SetNaNColor(byte _arg1, byte _arg2, byte _arg3, byte _arg4)
		{
			vtkImageMapToColors.vtkImageMapToColors_SetNaNColor_20(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x0600C10F RID: 49423
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapToColors_SetNaNColor_21(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get Color that should be used in case of UnMatching
		/// data.
		/// </summary>
		// Token: 0x0600C110 RID: 49424 RVA: 0x0010CEF3 File Offset: 0x0010B0F3
		public virtual void SetNaNColor(IntPtr _arg)
		{
			vtkImageMapToColors.vtkImageMapToColors_SetNaNColor_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C111 RID: 49425
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapToColors_SetOutputFormat_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the output format, the default is RGBA.
		/// </summary>
		// Token: 0x0600C112 RID: 49426 RVA: 0x0010CF03 File Offset: 0x0010B103
		public virtual void SetOutputFormat(int _arg)
		{
			vtkImageMapToColors.vtkImageMapToColors_SetOutputFormat_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C113 RID: 49427
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapToColors_SetOutputFormatToLuminance_23(HandleRef pThis);

		/// <summary>
		/// Set the output format, the default is RGBA.
		/// </summary>
		// Token: 0x0600C114 RID: 49428 RVA: 0x0010CF13 File Offset: 0x0010B113
		public void SetOutputFormatToLuminance()
		{
			vtkImageMapToColors.vtkImageMapToColors_SetOutputFormatToLuminance_23(base.GetCppThis());
		}

		// Token: 0x0600C115 RID: 49429
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapToColors_SetOutputFormatToLuminanceAlpha_24(HandleRef pThis);

		/// <summary>
		/// Set the output format, the default is RGBA.
		/// </summary>
		// Token: 0x0600C116 RID: 49430 RVA: 0x0010CF22 File Offset: 0x0010B122
		public void SetOutputFormatToLuminanceAlpha()
		{
			vtkImageMapToColors.vtkImageMapToColors_SetOutputFormatToLuminanceAlpha_24(base.GetCppThis());
		}

		// Token: 0x0600C117 RID: 49431
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapToColors_SetOutputFormatToRGB_25(HandleRef pThis);

		/// <summary>
		/// Set the output format, the default is RGBA.
		/// </summary>
		// Token: 0x0600C118 RID: 49432 RVA: 0x0010CF31 File Offset: 0x0010B131
		public void SetOutputFormatToRGB()
		{
			vtkImageMapToColors.vtkImageMapToColors_SetOutputFormatToRGB_25(base.GetCppThis());
		}

		// Token: 0x0600C119 RID: 49433
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapToColors_SetOutputFormatToRGBA_26(HandleRef pThis);

		/// <summary>
		/// Set the output format, the default is RGBA.
		/// </summary>
		// Token: 0x0600C11A RID: 49434 RVA: 0x0010CF40 File Offset: 0x0010B140
		public void SetOutputFormatToRGBA()
		{
			vtkImageMapToColors.vtkImageMapToColors_SetOutputFormatToRGBA_26(base.GetCppThis());
		}

		// Token: 0x0600C11B RID: 49435
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapToColors_SetPassAlphaToOutput_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Use the alpha component of the input when computing the alpha component
		/// of the output (useful when converting monochrome+alpha data to RGBA)
		/// </summary>
		// Token: 0x0600C11C RID: 49436 RVA: 0x0010CF4F File Offset: 0x0010B14F
		public virtual void SetPassAlphaToOutput(int _arg)
		{
			vtkImageMapToColors.vtkImageMapToColors_SetPassAlphaToOutput_27(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E4D RID: 3661
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageMapToColors";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E4E RID: 3662
		public new static readonly string MRClassNameKey = "class vtkImageMapToColors";
	}
}
