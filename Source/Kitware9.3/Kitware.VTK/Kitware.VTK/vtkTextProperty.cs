using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTextProperty
	/// </summary>
	/// <remarks>
	///    represent text properties.
	///
	/// vtkTextProperty is an object that represents text properties.
	/// The primary properties that can be set are color, opacity, font size,
	/// font family horizontal and vertical justification, bold/italic/shadow
	/// styles.
	/// </remarks>
	/// <seealso>
	///
	/// vtkTextMapper vtkTextActor vtkLegendBoxActor vtkCaptionActor2D
	/// </seealso>
	// Token: 0x0200081A RID: 2074
	public class vtkTextProperty : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601552D RID: 87341 RVA: 0x001E35A3 File Offset: 0x001E17A3
		static vtkTextProperty()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTextProperty.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextProperty"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601552E RID: 87342 RVA: 0x001E35CB File Offset: 0x001E17CB
		public vtkTextProperty(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601552F RID: 87343
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextProperty_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a new text property with font size 12, bold off, italic off,
		/// and Arial font.
		/// </summary>
		// Token: 0x06015530 RID: 87344 RVA: 0x001E35DC File Offset: 0x001E17DC
		public new static vtkTextProperty New()
		{
			vtkTextProperty result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextProperty.vtkTextProperty_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a new text property with font size 12, bold off, italic off,
		/// and Arial font.
		/// </summary>
		// Token: 0x06015531 RID: 87345 RVA: 0x001E3630 File Offset: 0x001E1830
		public vtkTextProperty() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTextProperty.vtkTextProperty_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015532 RID: 87346 RVA: 0x001E3674 File Offset: 0x001E1874
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015533 RID: 87347
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_BoldOff_01(HandleRef pThis);

		/// <summary>
		/// Enable/disable text bolding.
		/// </summary>
		// Token: 0x06015534 RID: 87348 RVA: 0x001E367F File Offset: 0x001E187F
		public virtual void BoldOff()
		{
			vtkTextProperty.vtkTextProperty_BoldOff_01(base.GetCppThis());
		}

		// Token: 0x06015535 RID: 87349
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_BoldOn_02(HandleRef pThis);

		/// <summary>
		/// Enable/disable text bolding.
		/// </summary>
		// Token: 0x06015536 RID: 87350 RVA: 0x001E368E File Offset: 0x001E188E
		public virtual void BoldOn()
		{
			vtkTextProperty.vtkTextProperty_BoldOn_02(base.GetCppThis());
		}

		// Token: 0x06015537 RID: 87351
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_FrameOff_03(HandleRef pThis);

		/// <summary>
		/// Enable/disable text frame.
		/// </summary>
		// Token: 0x06015538 RID: 87352 RVA: 0x001E369D File Offset: 0x001E189D
		public virtual void FrameOff()
		{
			vtkTextProperty.vtkTextProperty_FrameOff_03(base.GetCppThis());
		}

		// Token: 0x06015539 RID: 87353
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_FrameOn_04(HandleRef pThis);

		/// <summary>
		/// Enable/disable text frame.
		/// </summary>
		// Token: 0x0601553A RID: 87354 RVA: 0x001E36AC File Offset: 0x001E18AC
		public virtual void FrameOn()
		{
			vtkTextProperty.vtkTextProperty_FrameOn_04(base.GetCppThis());
		}

		// Token: 0x0601553B RID: 87355
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextProperty_GetBackgroundColor_05(HandleRef pThis);

		/// <summary>
		/// The background color.
		/// </summary>
		// Token: 0x0601553C RID: 87356 RVA: 0x001E36BC File Offset: 0x001E18BC
		public virtual double[] GetBackgroundColor()
		{
			IntPtr intPtr = vtkTextProperty.vtkTextProperty_GetBackgroundColor_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601553D RID: 87357
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_GetBackgroundColor_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// The background color.
		/// </summary>
		// Token: 0x0601553E RID: 87358 RVA: 0x001E3704 File Offset: 0x001E1904
		public virtual void GetBackgroundColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkTextProperty.vtkTextProperty_GetBackgroundColor_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0601553F RID: 87359
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_GetBackgroundColor_07(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The background color.
		/// </summary>
		// Token: 0x06015540 RID: 87360 RVA: 0x001E3716 File Offset: 0x001E1916
		public virtual void GetBackgroundColor(IntPtr _arg)
		{
			vtkTextProperty.vtkTextProperty_GetBackgroundColor_07(base.GetCppThis(), _arg);
		}

		// Token: 0x06015541 RID: 87361
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTextProperty_GetBackgroundOpacity_08(HandleRef pThis);

		/// <summary>
		/// The background opacity. 1.0 is totally opaque and 0.0 is completely
		/// transparent.
		/// </summary>
		// Token: 0x06015542 RID: 87362 RVA: 0x001E3728 File Offset: 0x001E1928
		public virtual double GetBackgroundOpacity()
		{
			return vtkTextProperty.vtkTextProperty_GetBackgroundOpacity_08(base.GetCppThis());
		}

		// Token: 0x06015543 RID: 87363
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTextProperty_GetBackgroundOpacityMaxValue_09(HandleRef pThis);

		/// <summary>
		/// The background opacity. 1.0 is totally opaque and 0.0 is completely
		/// transparent.
		/// </summary>
		// Token: 0x06015544 RID: 87364 RVA: 0x001E3748 File Offset: 0x001E1948
		public virtual double GetBackgroundOpacityMaxValue()
		{
			return vtkTextProperty.vtkTextProperty_GetBackgroundOpacityMaxValue_09(base.GetCppThis());
		}

		// Token: 0x06015545 RID: 87365
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTextProperty_GetBackgroundOpacityMinValue_10(HandleRef pThis);

		/// <summary>
		/// The background opacity. 1.0 is totally opaque and 0.0 is completely
		/// transparent.
		/// </summary>
		// Token: 0x06015546 RID: 87366 RVA: 0x001E3768 File Offset: 0x001E1968
		public virtual double GetBackgroundOpacityMinValue()
		{
			return vtkTextProperty.vtkTextProperty_GetBackgroundOpacityMinValue_10(base.GetCppThis());
		}

		// Token: 0x06015547 RID: 87367
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_GetBackgroundRGBA_11(HandleRef pThis, IntPtr rgba);

		/// <summary>
		/// Convenience method to get the background color and the opacity at once
		/// </summary>
		// Token: 0x06015548 RID: 87368 RVA: 0x001E3787 File Offset: 0x001E1987
		public void GetBackgroundRGBA(IntPtr rgba)
		{
			vtkTextProperty.vtkTextProperty_GetBackgroundRGBA_11(base.GetCppThis(), rgba);
		}

		// Token: 0x06015549 RID: 87369
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_GetBackgroundRGBA_12(HandleRef pThis, ref double r, ref double g, ref double b, ref double a);

		/// <summary>
		/// Convenience method to get the background color and the opacity at once
		/// </summary>
		// Token: 0x0601554A RID: 87370 RVA: 0x001E3797 File Offset: 0x001E1997
		public void GetBackgroundRGBA(ref double r, ref double g, ref double b, ref double a)
		{
			vtkTextProperty.vtkTextProperty_GetBackgroundRGBA_12(base.GetCppThis(), ref r, ref g, ref b, ref a);
		}

		// Token: 0x0601554B RID: 87371
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextProperty_GetBold_13(HandleRef pThis);

		/// <summary>
		/// Enable/disable text bolding.
		/// </summary>
		// Token: 0x0601554C RID: 87372 RVA: 0x001E37AC File Offset: 0x001E19AC
		public virtual int GetBold()
		{
			return vtkTextProperty.vtkTextProperty_GetBold_13(base.GetCppThis());
		}

		// Token: 0x0601554D RID: 87373
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTextProperty_GetCellOffset_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the horizontal offset between cells.
		/// Only used by MatplotlibMathTextUtilities
		/// </summary>
		// Token: 0x0601554E RID: 87374 RVA: 0x001E37CC File Offset: 0x001E19CC
		public virtual double GetCellOffset()
		{
			return vtkTextProperty.vtkTextProperty_GetCellOffset_14(base.GetCppThis());
		}

		// Token: 0x0601554F RID: 87375
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextProperty_GetColor_15(HandleRef pThis);

		/// <summary>
		/// Set the color of the text.
		/// </summary>
		// Token: 0x06015550 RID: 87376 RVA: 0x001E37EC File Offset: 0x001E19EC
		public virtual double[] GetColor()
		{
			IntPtr intPtr = vtkTextProperty.vtkTextProperty_GetColor_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06015551 RID: 87377
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_GetColor_16(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set the color of the text.
		/// </summary>
		// Token: 0x06015552 RID: 87378 RVA: 0x001E3834 File Offset: 0x001E1A34
		public virtual void GetColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkTextProperty.vtkTextProperty_GetColor_16(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06015553 RID: 87379
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_GetColor_17(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the color of the text.
		/// </summary>
		// Token: 0x06015554 RID: 87380 RVA: 0x001E3846 File Offset: 0x001E1A46
		public virtual void GetColor(IntPtr _arg)
		{
			vtkTextProperty.vtkTextProperty_GetColor_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06015555 RID: 87381
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextProperty_GetFontFamily_18(HandleRef pThis);

		/// <summary>
		/// Set/Get the font family. Supports legacy three font family system.
		/// If the symbolic constant VTK_FONT_FILE is returned by GetFontFamily(), the
		/// string returned by GetFontFile() must be an absolute filepath
		/// to a local FreeType compatible font.
		/// </summary>
		// Token: 0x06015556 RID: 87382 RVA: 0x001E3858 File Offset: 0x001E1A58
		public int GetFontFamily()
		{
			return vtkTextProperty.vtkTextProperty_GetFontFamily_18(base.GetCppThis());
		}

		// Token: 0x06015557 RID: 87383
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextProperty_GetFontFamilyAsString_19(HandleRef pThis);

		/// <summary>
		/// Set/Get the font family. Supports legacy three font family system.
		/// If the symbolic constant VTK_FONT_FILE is returned by GetFontFamily(), the
		/// string returned by GetFontFile() must be an absolute filepath
		/// to a local FreeType compatible font.
		/// </summary>
		// Token: 0x06015558 RID: 87384 RVA: 0x001E3878 File Offset: 0x001E1A78
		public virtual string GetFontFamilyAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkTextProperty.vtkTextProperty_GetFontFamilyAsString_19(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06015559 RID: 87385
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextProperty_GetFontFamilyAsString_20(int f);

		/// <summary>
		/// Set/Get the font family. Supports legacy three font family system.
		/// If the symbolic constant VTK_FONT_FILE is returned by GetFontFamily(), the
		/// string returned by GetFontFile() must be an absolute filepath
		/// to a local FreeType compatible font.
		/// </summary>
		// Token: 0x0601555A RID: 87386 RVA: 0x001E38B4 File Offset: 0x001E1AB4
		public static string GetFontFamilyAsString(int f)
		{
			string s = Marshal.PtrToStringAnsi(vtkTextProperty.vtkTextProperty_GetFontFamilyAsString_20(f));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601555B RID: 87387
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextProperty_GetFontFamilyFromString_21([MarshalAs(UnmanagedType.LPUTF8Str)] string f);

		/// <summary>
		/// Set/Get the font family. Supports legacy three font family system.
		/// If the symbolic constant VTK_FONT_FILE is returned by GetFontFamily(), the
		/// string returned by GetFontFile() must be an absolute filepath
		/// to a local FreeType compatible font.
		/// </summary>
		// Token: 0x0601555C RID: 87388 RVA: 0x001E38EC File Offset: 0x001E1AEC
		public static int GetFontFamilyFromString(string f)
		{
			return vtkTextProperty.vtkTextProperty_GetFontFamilyFromString_21(f);
		}

		// Token: 0x0601555D RID: 87389
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextProperty_GetFontFamilyMinValue_22(HandleRef pThis);

		/// <summary>
		/// Set/Get the font family. Supports legacy three font family system.
		/// If the symbolic constant VTK_FONT_FILE is returned by GetFontFamily(), the
		/// string returned by GetFontFile() must be an absolute filepath
		/// to a local FreeType compatible font.
		/// </summary>
		// Token: 0x0601555E RID: 87390 RVA: 0x001E3908 File Offset: 0x001E1B08
		public int GetFontFamilyMinValue()
		{
			return vtkTextProperty.vtkTextProperty_GetFontFamilyMinValue_22(base.GetCppThis());
		}

		// Token: 0x0601555F RID: 87391
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextProperty_GetFontFile_23(HandleRef pThis);

		/// <summary>
		/// The absolute filepath to a local file containing a freetype-readable font
		/// if GetFontFamily() return VTK_FONT_FILE. The result is undefined for other
		/// values of GetFontFamily().
		/// </summary>
		// Token: 0x06015560 RID: 87392 RVA: 0x001E3928 File Offset: 0x001E1B28
		public virtual string GetFontFile()
		{
			string s = Marshal.PtrToStringAnsi(vtkTextProperty.vtkTextProperty_GetFontFile_23(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06015561 RID: 87393
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextProperty_GetFontSize_24(HandleRef pThis);

		/// <summary>
		/// Set/Get the font size (in points).
		/// </summary>
		// Token: 0x06015562 RID: 87394 RVA: 0x001E3964 File Offset: 0x001E1B64
		public virtual int GetFontSize()
		{
			return vtkTextProperty.vtkTextProperty_GetFontSize_24(base.GetCppThis());
		}

		// Token: 0x06015563 RID: 87395
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextProperty_GetFontSizeMaxValue_25(HandleRef pThis);

		/// <summary>
		/// Set/Get the font size (in points).
		/// </summary>
		// Token: 0x06015564 RID: 87396 RVA: 0x001E3984 File Offset: 0x001E1B84
		public virtual int GetFontSizeMaxValue()
		{
			return vtkTextProperty.vtkTextProperty_GetFontSizeMaxValue_25(base.GetCppThis());
		}

		// Token: 0x06015565 RID: 87397
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextProperty_GetFontSizeMinValue_26(HandleRef pThis);

		/// <summary>
		/// Set/Get the font size (in points).
		/// </summary>
		// Token: 0x06015566 RID: 87398 RVA: 0x001E39A4 File Offset: 0x001E1BA4
		public virtual int GetFontSizeMinValue()
		{
			return vtkTextProperty.vtkTextProperty_GetFontSizeMinValue_26(base.GetCppThis());
		}

		// Token: 0x06015567 RID: 87399
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextProperty_GetFrame_27(HandleRef pThis);

		/// <summary>
		/// Enable/disable text frame.
		/// </summary>
		// Token: 0x06015568 RID: 87400 RVA: 0x001E39C4 File Offset: 0x001E1BC4
		public virtual int GetFrame()
		{
			return vtkTextProperty.vtkTextProperty_GetFrame_27(base.GetCppThis());
		}

		// Token: 0x06015569 RID: 87401
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextProperty_GetFrameColor_28(HandleRef pThis);

		/// <summary>
		/// The frame color.
		/// </summary>
		// Token: 0x0601556A RID: 87402 RVA: 0x001E39E4 File Offset: 0x001E1BE4
		public virtual double[] GetFrameColor()
		{
			IntPtr intPtr = vtkTextProperty.vtkTextProperty_GetFrameColor_28(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601556B RID: 87403
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_GetFrameColor_29(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// The frame color.
		/// </summary>
		// Token: 0x0601556C RID: 87404 RVA: 0x001E3A2C File Offset: 0x001E1C2C
		public virtual void GetFrameColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkTextProperty.vtkTextProperty_GetFrameColor_29(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0601556D RID: 87405
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_GetFrameColor_30(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The frame color.
		/// </summary>
		// Token: 0x0601556E RID: 87406 RVA: 0x001E3A3E File Offset: 0x001E1C3E
		public virtual void GetFrameColor(IntPtr _arg)
		{
			vtkTextProperty.vtkTextProperty_GetFrameColor_30(base.GetCppThis(), _arg);
		}

		// Token: 0x0601556F RID: 87407
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextProperty_GetFrameWidth_31(HandleRef pThis);

		/// <summary>
		/// Set/Get the width of the frame. The width is expressed in pixels.
		/// The default is 1 pixel.
		/// </summary>
		// Token: 0x06015570 RID: 87408 RVA: 0x001E3A50 File Offset: 0x001E1C50
		public virtual int GetFrameWidth()
		{
			return vtkTextProperty.vtkTextProperty_GetFrameWidth_31(base.GetCppThis());
		}

		// Token: 0x06015571 RID: 87409
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextProperty_GetFrameWidthMaxValue_32(HandleRef pThis);

		/// <summary>
		/// Set/Get the width of the frame. The width is expressed in pixels.
		/// The default is 1 pixel.
		/// </summary>
		// Token: 0x06015572 RID: 87410 RVA: 0x001E3A70 File Offset: 0x001E1C70
		public virtual int GetFrameWidthMaxValue()
		{
			return vtkTextProperty.vtkTextProperty_GetFrameWidthMaxValue_32(base.GetCppThis());
		}

		// Token: 0x06015573 RID: 87411
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextProperty_GetFrameWidthMinValue_33(HandleRef pThis);

		/// <summary>
		/// Set/Get the width of the frame. The width is expressed in pixels.
		/// The default is 1 pixel.
		/// </summary>
		// Token: 0x06015574 RID: 87412 RVA: 0x001E3A90 File Offset: 0x001E1C90
		public virtual int GetFrameWidthMinValue()
		{
			return vtkTextProperty.vtkTextProperty_GetFrameWidthMinValue_33(base.GetCppThis());
		}

		// Token: 0x06015575 RID: 87413
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextProperty_GetInteriorLinesColor_34(HandleRef pThis);

		/// <summary>
		/// Set the color of the interior lines between cells.
		/// Default is black (0.0, 0.0, 0.0).
		/// </summary>
		// Token: 0x06015576 RID: 87414 RVA: 0x001E3AB0 File Offset: 0x001E1CB0
		public virtual double[] GetInteriorLinesColor()
		{
			IntPtr intPtr = vtkTextProperty.vtkTextProperty_GetInteriorLinesColor_34(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06015577 RID: 87415
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_GetInteriorLinesColor_35(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set the color of the interior lines between cells.
		/// Default is black (0.0, 0.0, 0.0).
		/// </summary>
		// Token: 0x06015578 RID: 87416 RVA: 0x001E3AF8 File Offset: 0x001E1CF8
		public virtual void GetInteriorLinesColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkTextProperty.vtkTextProperty_GetInteriorLinesColor_35(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06015579 RID: 87417
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_GetInteriorLinesColor_36(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the color of the interior lines between cells.
		/// Default is black (0.0, 0.0, 0.0).
		/// </summary>
		// Token: 0x0601557A RID: 87418 RVA: 0x001E3B0A File Offset: 0x001E1D0A
		public virtual void GetInteriorLinesColor(IntPtr _arg)
		{
			vtkTextProperty.vtkTextProperty_GetInteriorLinesColor_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0601557B RID: 87419
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTextProperty_GetInteriorLinesVisibility_37(HandleRef pThis);

		/// <summary>
		/// Set/Get the visibility of the interior lines between cells.
		/// Default is false.
		/// </summary>
		// Token: 0x0601557C RID: 87420 RVA: 0x001E3B1C File Offset: 0x001E1D1C
		public virtual bool GetInteriorLinesVisibility()
		{
			return vtkTextProperty.vtkTextProperty_GetInteriorLinesVisibility_37(base.GetCppThis()) != 0;
		}

		// Token: 0x0601557D RID: 87421
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextProperty_GetInteriorLinesWidth_38(HandleRef pThis);

		/// <summary>
		/// Set the width (in pixels) of the interior lines between cells.
		/// Default is 1.
		/// </summary>
		// Token: 0x0601557E RID: 87422 RVA: 0x001E3B44 File Offset: 0x001E1D44
		public virtual int GetInteriorLinesWidth()
		{
			return vtkTextProperty.vtkTextProperty_GetInteriorLinesWidth_38(base.GetCppThis());
		}

		// Token: 0x0601557F RID: 87423
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextProperty_GetItalic_39(HandleRef pThis);

		/// <summary>
		/// Enable/disable text italic.
		/// </summary>
		// Token: 0x06015580 RID: 87424 RVA: 0x001E3B64 File Offset: 0x001E1D64
		public virtual int GetItalic()
		{
			return vtkTextProperty.vtkTextProperty_GetItalic_39(base.GetCppThis());
		}

		// Token: 0x06015581 RID: 87425
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextProperty_GetJustification_40(HandleRef pThis);

		/// <summary>
		/// Set/Get the horizontal justification to left (default), centered,
		/// or right.
		/// </summary>
		// Token: 0x06015582 RID: 87426 RVA: 0x001E3B84 File Offset: 0x001E1D84
		public virtual int GetJustification()
		{
			return vtkTextProperty.vtkTextProperty_GetJustification_40(base.GetCppThis());
		}

		// Token: 0x06015583 RID: 87427
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextProperty_GetJustificationAsString_41(HandleRef pThis);

		/// <summary>
		/// Set/Get the horizontal justification to left (default), centered,
		/// or right.
		/// </summary>
		// Token: 0x06015584 RID: 87428 RVA: 0x001E3BA4 File Offset: 0x001E1DA4
		public string GetJustificationAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkTextProperty.vtkTextProperty_GetJustificationAsString_41(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06015585 RID: 87429
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextProperty_GetJustificationMaxValue_42(HandleRef pThis);

		/// <summary>
		/// Set/Get the horizontal justification to left (default), centered,
		/// or right.
		/// </summary>
		// Token: 0x06015586 RID: 87430 RVA: 0x001E3BE0 File Offset: 0x001E1DE0
		public virtual int GetJustificationMaxValue()
		{
			return vtkTextProperty.vtkTextProperty_GetJustificationMaxValue_42(base.GetCppThis());
		}

		// Token: 0x06015587 RID: 87431
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextProperty_GetJustificationMinValue_43(HandleRef pThis);

		/// <summary>
		/// Set/Get the horizontal justification to left (default), centered,
		/// or right.
		/// </summary>
		// Token: 0x06015588 RID: 87432 RVA: 0x001E3C00 File Offset: 0x001E1E00
		public virtual int GetJustificationMinValue()
		{
			return vtkTextProperty.vtkTextProperty_GetJustificationMinValue_43(base.GetCppThis());
		}

		// Token: 0x06015589 RID: 87433
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTextProperty_GetLineOffset_44(HandleRef pThis);

		/// <summary>
		/// Set/Get the vertical offset (measured in pixels).
		/// </summary>
		// Token: 0x0601558A RID: 87434 RVA: 0x001E3C20 File Offset: 0x001E1E20
		public virtual double GetLineOffset()
		{
			return vtkTextProperty.vtkTextProperty_GetLineOffset_44(base.GetCppThis());
		}

		// Token: 0x0601558B RID: 87435
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTextProperty_GetLineSpacing_45(HandleRef pThis);

		/// <summary>
		/// Set/Get the (extra) spacing between lines,
		/// expressed as a text height multiplication factor.
		/// </summary>
		// Token: 0x0601558C RID: 87436 RVA: 0x001E3C40 File Offset: 0x001E1E40
		public virtual double GetLineSpacing()
		{
			return vtkTextProperty.vtkTextProperty_GetLineSpacing_45(base.GetCppThis());
		}

		// Token: 0x0601558D RID: 87437
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTextProperty_GetNumberOfGenerationsFromBase_46(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601558E RID: 87438 RVA: 0x001E3C60 File Offset: 0x001E1E60
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTextProperty.vtkTextProperty_GetNumberOfGenerationsFromBase_46(base.GetCppThis(), type);
		}

		// Token: 0x0601558F RID: 87439
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTextProperty_GetNumberOfGenerationsFromBaseType_47([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015590 RID: 87440 RVA: 0x001E3C80 File Offset: 0x001E1E80
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTextProperty.vtkTextProperty_GetNumberOfGenerationsFromBaseType_47(type);
		}

		// Token: 0x06015591 RID: 87441
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTextProperty_GetOpacity_48(HandleRef pThis);

		/// <summary>
		/// Set/Get the text's opacity. 1.0 is totally opaque and 0.0 is completely
		/// transparent.
		/// </summary>
		// Token: 0x06015592 RID: 87442 RVA: 0x001E3C9C File Offset: 0x001E1E9C
		public virtual double GetOpacity()
		{
			return vtkTextProperty.vtkTextProperty_GetOpacity_48(base.GetCppThis());
		}

		// Token: 0x06015593 RID: 87443
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTextProperty_GetOpacityMaxValue_49(HandleRef pThis);

		/// <summary>
		/// Set/Get the text's opacity. 1.0 is totally opaque and 0.0 is completely
		/// transparent.
		/// </summary>
		// Token: 0x06015594 RID: 87444 RVA: 0x001E3CBC File Offset: 0x001E1EBC
		public virtual double GetOpacityMaxValue()
		{
			return vtkTextProperty.vtkTextProperty_GetOpacityMaxValue_49(base.GetCppThis());
		}

		// Token: 0x06015595 RID: 87445
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTextProperty_GetOpacityMinValue_50(HandleRef pThis);

		/// <summary>
		/// Set/Get the text's opacity. 1.0 is totally opaque and 0.0 is completely
		/// transparent.
		/// </summary>
		// Token: 0x06015596 RID: 87446 RVA: 0x001E3CDC File Offset: 0x001E1EDC
		public virtual double GetOpacityMinValue()
		{
			return vtkTextProperty.vtkTextProperty_GetOpacityMinValue_50(base.GetCppThis());
		}

		// Token: 0x06015597 RID: 87447
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTextProperty_GetOrientation_51(HandleRef pThis);

		/// <summary>
		/// Set/Get the text's orientation (in degrees).
		/// </summary>
		// Token: 0x06015598 RID: 87448 RVA: 0x001E3CFC File Offset: 0x001E1EFC
		public virtual double GetOrientation()
		{
			return vtkTextProperty.vtkTextProperty_GetOrientation_51(base.GetCppThis());
		}

		// Token: 0x06015599 RID: 87449
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextProperty_GetShadow_52(HandleRef pThis);

		/// <summary>
		/// Enable/disable text shadow.
		/// </summary>
		// Token: 0x0601559A RID: 87450 RVA: 0x001E3D1C File Offset: 0x001E1F1C
		public virtual int GetShadow()
		{
			return vtkTextProperty.vtkTextProperty_GetShadow_52(base.GetCppThis());
		}

		// Token: 0x0601559B RID: 87451
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_GetShadowColor_53(HandleRef pThis, IntPtr color);

		/// <summary>
		/// Get the shadow color. It is computed from the Color ivar
		/// </summary>
		// Token: 0x0601559C RID: 87452 RVA: 0x001E3D3B File Offset: 0x001E1F3B
		public void GetShadowColor(IntPtr color)
		{
			vtkTextProperty.vtkTextProperty_GetShadowColor_53(base.GetCppThis(), color);
		}

		// Token: 0x0601559D RID: 87453
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextProperty_GetShadowOffset_54(HandleRef pThis);

		/// <summary>
		/// Set/Get the shadow offset, i.e. the distance from the text to
		/// its shadow, in the same unit as FontSize.
		/// </summary>
		// Token: 0x0601559E RID: 87454 RVA: 0x001E3D4C File Offset: 0x001E1F4C
		public virtual int[] GetShadowOffset()
		{
			IntPtr intPtr = vtkTextProperty.vtkTextProperty_GetShadowOffset_54(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601559F RID: 87455
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_GetShadowOffset_55(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the shadow offset, i.e. the distance from the text to
		/// its shadow, in the same unit as FontSize.
		/// </summary>
		// Token: 0x060155A0 RID: 87456 RVA: 0x001E3D94 File Offset: 0x001E1F94
		public virtual void GetShadowOffset(IntPtr data)
		{
			vtkTextProperty.vtkTextProperty_GetShadowOffset_55(base.GetCppThis(), data);
		}

		// Token: 0x060155A1 RID: 87457
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextProperty_GetUseTightBoundingBox_56(HandleRef pThis);

		/// <summary>
		/// If this property is on, text is aligned to drawn pixels not to font metrix.
		/// If the text does not include descents, the bounding box will not extend below
		/// the baseline. This option can be used to get centered labels. It does not
		/// work well if the string changes as the string position will move around.
		/// </summary>
		// Token: 0x060155A2 RID: 87458 RVA: 0x001E3DA4 File Offset: 0x001E1FA4
		public virtual int GetUseTightBoundingBox()
		{
			return vtkTextProperty.vtkTextProperty_GetUseTightBoundingBox_56(base.GetCppThis());
		}

		// Token: 0x060155A3 RID: 87459
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextProperty_GetVerticalJustification_57(HandleRef pThis);

		/// <summary>
		/// Set/Get the vertical justification to bottom (default), middle,
		/// or top.
		/// </summary>
		// Token: 0x060155A4 RID: 87460 RVA: 0x001E3DC4 File Offset: 0x001E1FC4
		public virtual int GetVerticalJustification()
		{
			return vtkTextProperty.vtkTextProperty_GetVerticalJustification_57(base.GetCppThis());
		}

		// Token: 0x060155A5 RID: 87461
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextProperty_GetVerticalJustificationAsString_58(HandleRef pThis);

		/// <summary>
		/// Set/Get the vertical justification to bottom (default), middle,
		/// or top.
		/// </summary>
		// Token: 0x060155A6 RID: 87462 RVA: 0x001E3DE4 File Offset: 0x001E1FE4
		public string GetVerticalJustificationAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkTextProperty.vtkTextProperty_GetVerticalJustificationAsString_58(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060155A7 RID: 87463
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextProperty_GetVerticalJustificationMaxValue_59(HandleRef pThis);

		/// <summary>
		/// Set/Get the vertical justification to bottom (default), middle,
		/// or top.
		/// </summary>
		// Token: 0x060155A8 RID: 87464 RVA: 0x001E3E20 File Offset: 0x001E2020
		public virtual int GetVerticalJustificationMaxValue()
		{
			return vtkTextProperty.vtkTextProperty_GetVerticalJustificationMaxValue_59(base.GetCppThis());
		}

		// Token: 0x060155A9 RID: 87465
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextProperty_GetVerticalJustificationMinValue_60(HandleRef pThis);

		/// <summary>
		/// Set/Get the vertical justification to bottom (default), middle,
		/// or top.
		/// </summary>
		// Token: 0x060155AA RID: 87466 RVA: 0x001E3E40 File Offset: 0x001E2040
		public virtual int GetVerticalJustificationMinValue()
		{
			return vtkTextProperty.vtkTextProperty_GetVerticalJustificationMinValue_60(base.GetCppThis());
		}

		// Token: 0x060155AB RID: 87467
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextProperty_IsA_61(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060155AC RID: 87468 RVA: 0x001E3E60 File Offset: 0x001E2060
		public override int IsA(string type)
		{
			return vtkTextProperty.vtkTextProperty_IsA_61(base.GetCppThis(), type);
		}

		// Token: 0x060155AD RID: 87469
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextProperty_IsTypeOf_62([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060155AE RID: 87470 RVA: 0x001E3E80 File Offset: 0x001E2080
		public new static int IsTypeOf(string type)
		{
			return vtkTextProperty.vtkTextProperty_IsTypeOf_62(type);
		}

		// Token: 0x060155AF RID: 87471
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_ItalicOff_63(HandleRef pThis);

		/// <summary>
		/// Enable/disable text italic.
		/// </summary>
		// Token: 0x060155B0 RID: 87472 RVA: 0x001E3E9A File Offset: 0x001E209A
		public virtual void ItalicOff()
		{
			vtkTextProperty.vtkTextProperty_ItalicOff_63(base.GetCppThis());
		}

		// Token: 0x060155B1 RID: 87473
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_ItalicOn_64(HandleRef pThis);

		/// <summary>
		/// Enable/disable text italic.
		/// </summary>
		// Token: 0x060155B2 RID: 87474 RVA: 0x001E3EA9 File Offset: 0x001E20A9
		public virtual void ItalicOn()
		{
			vtkTextProperty.vtkTextProperty_ItalicOn_64(base.GetCppThis());
		}

		// Token: 0x060155B3 RID: 87475
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextProperty_NewInstance_66(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060155B4 RID: 87476 RVA: 0x001E3EB8 File Offset: 0x001E20B8
		public new vtkTextProperty NewInstance()
		{
			vtkTextProperty result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextProperty.vtkTextProperty_NewInstance_66(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060155B5 RID: 87477
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextProperty_SafeDownCast_67(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060155B6 RID: 87478 RVA: 0x001E3F14 File Offset: 0x001E2114
		public new static vtkTextProperty SafeDownCast(vtkObjectBase o)
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextProperty.vtkTextProperty_SafeDownCast_67((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x060155B7 RID: 87479
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetBackgroundColor_68(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// The background color.
		/// </summary>
		// Token: 0x060155B8 RID: 87480 RVA: 0x001E3F93 File Offset: 0x001E2193
		public virtual void SetBackgroundColor(double _arg1, double _arg2, double _arg3)
		{
			vtkTextProperty.vtkTextProperty_SetBackgroundColor_68(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060155B9 RID: 87481
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetBackgroundColor_69(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The background color.
		/// </summary>
		// Token: 0x060155BA RID: 87482 RVA: 0x001E3FA5 File Offset: 0x001E21A5
		public virtual void SetBackgroundColor(IntPtr _arg)
		{
			vtkTextProperty.vtkTextProperty_SetBackgroundColor_69(base.GetCppThis(), _arg);
		}

		// Token: 0x060155BB RID: 87483
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetBackgroundOpacity_70(HandleRef pThis, double _arg);

		/// <summary>
		/// The background opacity. 1.0 is totally opaque and 0.0 is completely
		/// transparent.
		/// </summary>
		// Token: 0x060155BC RID: 87484 RVA: 0x001E3FB5 File Offset: 0x001E21B5
		public virtual void SetBackgroundOpacity(double _arg)
		{
			vtkTextProperty.vtkTextProperty_SetBackgroundOpacity_70(base.GetCppThis(), _arg);
		}

		// Token: 0x060155BD RID: 87485
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetBackgroundRGBA_71(HandleRef pThis, IntPtr rgba);

		/// <summary>
		/// Convenience method to set the background color and the opacity at once
		/// </summary>
		// Token: 0x060155BE RID: 87486 RVA: 0x001E3FC5 File Offset: 0x001E21C5
		public void SetBackgroundRGBA(IntPtr rgba)
		{
			vtkTextProperty.vtkTextProperty_SetBackgroundRGBA_71(base.GetCppThis(), rgba);
		}

		// Token: 0x060155BF RID: 87487
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetBackgroundRGBA_72(HandleRef pThis, double r, double g, double b, double a);

		/// <summary>
		/// Convenience method to set the background color and the opacity at once
		/// </summary>
		// Token: 0x060155C0 RID: 87488 RVA: 0x001E3FD5 File Offset: 0x001E21D5
		public void SetBackgroundRGBA(double r, double g, double b, double a)
		{
			vtkTextProperty.vtkTextProperty_SetBackgroundRGBA_72(base.GetCppThis(), r, g, b, a);
		}

		// Token: 0x060155C1 RID: 87489
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetBold_73(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/disable text bolding.
		/// </summary>
		// Token: 0x060155C2 RID: 87490 RVA: 0x001E3FE9 File Offset: 0x001E21E9
		public virtual void SetBold(int _arg)
		{
			vtkTextProperty.vtkTextProperty_SetBold_73(base.GetCppThis(), _arg);
		}

		// Token: 0x060155C3 RID: 87491
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetCellOffset_74(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the horizontal offset between cells.
		/// Only used by MatplotlibMathTextUtilities
		/// </summary>
		// Token: 0x060155C4 RID: 87492 RVA: 0x001E3FF9 File Offset: 0x001E21F9
		public virtual void SetCellOffset(double _arg)
		{
			vtkTextProperty.vtkTextProperty_SetCellOffset_74(base.GetCppThis(), _arg);
		}

		// Token: 0x060155C5 RID: 87493
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetColor_75(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the color of the text.
		/// </summary>
		// Token: 0x060155C6 RID: 87494 RVA: 0x001E4009 File Offset: 0x001E2209
		public virtual void SetColor(double _arg1, double _arg2, double _arg3)
		{
			vtkTextProperty.vtkTextProperty_SetColor_75(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060155C7 RID: 87495
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetColor_76(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the color of the text.
		/// </summary>
		// Token: 0x060155C8 RID: 87496 RVA: 0x001E401B File Offset: 0x001E221B
		public virtual void SetColor(IntPtr _arg)
		{
			vtkTextProperty.vtkTextProperty_SetColor_76(base.GetCppThis(), _arg);
		}

		// Token: 0x060155C9 RID: 87497
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetFontFamily_77(HandleRef pThis, int t);

		/// <summary>
		/// Set/Get the font family. Supports legacy three font family system.
		/// If the symbolic constant VTK_FONT_FILE is returned by GetFontFamily(), the
		/// string returned by GetFontFile() must be an absolute filepath
		/// to a local FreeType compatible font.
		/// </summary>
		// Token: 0x060155CA RID: 87498 RVA: 0x001E402B File Offset: 0x001E222B
		public void SetFontFamily(int t)
		{
			vtkTextProperty.vtkTextProperty_SetFontFamily_77(base.GetCppThis(), t);
		}

		// Token: 0x060155CB RID: 87499
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetFontFamilyAsString_78(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the font family. Supports legacy three font family system.
		/// If the symbolic constant VTK_FONT_FILE is returned by GetFontFamily(), the
		/// string returned by GetFontFile() must be an absolute filepath
		/// to a local FreeType compatible font.
		/// </summary>
		// Token: 0x060155CC RID: 87500 RVA: 0x001E403B File Offset: 0x001E223B
		public virtual void SetFontFamilyAsString(string _arg)
		{
			vtkTextProperty.vtkTextProperty_SetFontFamilyAsString_78(base.GetCppThis(), _arg);
		}

		// Token: 0x060155CD RID: 87501
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetFontFamilyToArial_79(HandleRef pThis);

		/// <summary>
		/// Set/Get the font family. Supports legacy three font family system.
		/// If the symbolic constant VTK_FONT_FILE is returned by GetFontFamily(), the
		/// string returned by GetFontFile() must be an absolute filepath
		/// to a local FreeType compatible font.
		/// </summary>
		// Token: 0x060155CE RID: 87502 RVA: 0x001E404B File Offset: 0x001E224B
		public void SetFontFamilyToArial()
		{
			vtkTextProperty.vtkTextProperty_SetFontFamilyToArial_79(base.GetCppThis());
		}

		// Token: 0x060155CF RID: 87503
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetFontFamilyToCourier_80(HandleRef pThis);

		/// <summary>
		/// Set/Get the font family. Supports legacy three font family system.
		/// If the symbolic constant VTK_FONT_FILE is returned by GetFontFamily(), the
		/// string returned by GetFontFile() must be an absolute filepath
		/// to a local FreeType compatible font.
		/// </summary>
		// Token: 0x060155D0 RID: 87504 RVA: 0x001E405A File Offset: 0x001E225A
		public void SetFontFamilyToCourier()
		{
			vtkTextProperty.vtkTextProperty_SetFontFamilyToCourier_80(base.GetCppThis());
		}

		// Token: 0x060155D1 RID: 87505
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetFontFamilyToTimes_81(HandleRef pThis);

		/// <summary>
		/// Set/Get the font family. Supports legacy three font family system.
		/// If the symbolic constant VTK_FONT_FILE is returned by GetFontFamily(), the
		/// string returned by GetFontFile() must be an absolute filepath
		/// to a local FreeType compatible font.
		/// </summary>
		// Token: 0x060155D2 RID: 87506 RVA: 0x001E4069 File Offset: 0x001E2269
		public void SetFontFamilyToTimes()
		{
			vtkTextProperty.vtkTextProperty_SetFontFamilyToTimes_81(base.GetCppThis());
		}

		// Token: 0x060155D3 RID: 87507
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetFontFile_82(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The absolute filepath to a local file containing a freetype-readable font
		/// if GetFontFamily() return VTK_FONT_FILE. The result is undefined for other
		/// values of GetFontFamily().
		/// </summary>
		// Token: 0x060155D4 RID: 87508 RVA: 0x001E4078 File Offset: 0x001E2278
		public virtual void SetFontFile(string _arg)
		{
			vtkTextProperty.vtkTextProperty_SetFontFile_82(base.GetCppThis(), _arg);
		}

		// Token: 0x060155D5 RID: 87509
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetFontSize_83(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the font size (in points).
		/// </summary>
		// Token: 0x060155D6 RID: 87510 RVA: 0x001E4088 File Offset: 0x001E2288
		public virtual void SetFontSize(int _arg)
		{
			vtkTextProperty.vtkTextProperty_SetFontSize_83(base.GetCppThis(), _arg);
		}

		// Token: 0x060155D7 RID: 87511
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetFrame_84(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/disable text frame.
		/// </summary>
		// Token: 0x060155D8 RID: 87512 RVA: 0x001E4098 File Offset: 0x001E2298
		public virtual void SetFrame(int _arg)
		{
			vtkTextProperty.vtkTextProperty_SetFrame_84(base.GetCppThis(), _arg);
		}

		// Token: 0x060155D9 RID: 87513
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetFrameColor_85(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// The frame color.
		/// </summary>
		// Token: 0x060155DA RID: 87514 RVA: 0x001E40A8 File Offset: 0x001E22A8
		public virtual void SetFrameColor(double _arg1, double _arg2, double _arg3)
		{
			vtkTextProperty.vtkTextProperty_SetFrameColor_85(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060155DB RID: 87515
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetFrameColor_86(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The frame color.
		/// </summary>
		// Token: 0x060155DC RID: 87516 RVA: 0x001E40BA File Offset: 0x001E22BA
		public virtual void SetFrameColor(IntPtr _arg)
		{
			vtkTextProperty.vtkTextProperty_SetFrameColor_86(base.GetCppThis(), _arg);
		}

		// Token: 0x060155DD RID: 87517
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetFrameWidth_87(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the width of the frame. The width is expressed in pixels.
		/// The default is 1 pixel.
		/// </summary>
		// Token: 0x060155DE RID: 87518 RVA: 0x001E40CA File Offset: 0x001E22CA
		public virtual void SetFrameWidth(int _arg)
		{
			vtkTextProperty.vtkTextProperty_SetFrameWidth_87(base.GetCppThis(), _arg);
		}

		// Token: 0x060155DF RID: 87519
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetInteriorLinesColor_88(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the color of the interior lines between cells.
		/// Default is black (0.0, 0.0, 0.0).
		/// </summary>
		// Token: 0x060155E0 RID: 87520 RVA: 0x001E40DA File Offset: 0x001E22DA
		public virtual void SetInteriorLinesColor(double _arg1, double _arg2, double _arg3)
		{
			vtkTextProperty.vtkTextProperty_SetInteriorLinesColor_88(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060155E1 RID: 87521
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetInteriorLinesColor_89(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the color of the interior lines between cells.
		/// Default is black (0.0, 0.0, 0.0).
		/// </summary>
		// Token: 0x060155E2 RID: 87522 RVA: 0x001E40EC File Offset: 0x001E22EC
		public virtual void SetInteriorLinesColor(IntPtr _arg)
		{
			vtkTextProperty.vtkTextProperty_SetInteriorLinesColor_89(base.GetCppThis(), _arg);
		}

		// Token: 0x060155E3 RID: 87523
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetInteriorLinesVisibility_90(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get the visibility of the interior lines between cells.
		/// Default is false.
		/// </summary>
		// Token: 0x060155E4 RID: 87524 RVA: 0x001E40FC File Offset: 0x001E22FC
		public virtual void SetInteriorLinesVisibility(bool _arg)
		{
			vtkTextProperty.vtkTextProperty_SetInteriorLinesVisibility_90(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060155E5 RID: 87525
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetInteriorLinesWidth_91(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the width (in pixels) of the interior lines between cells.
		/// Default is 1.
		/// </summary>
		// Token: 0x060155E6 RID: 87526 RVA: 0x001E4114 File Offset: 0x001E2314
		public virtual void SetInteriorLinesWidth(int _arg)
		{
			vtkTextProperty.vtkTextProperty_SetInteriorLinesWidth_91(base.GetCppThis(), _arg);
		}

		// Token: 0x060155E7 RID: 87527
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetItalic_92(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/disable text italic.
		/// </summary>
		// Token: 0x060155E8 RID: 87528 RVA: 0x001E4124 File Offset: 0x001E2324
		public virtual void SetItalic(int _arg)
		{
			vtkTextProperty.vtkTextProperty_SetItalic_92(base.GetCppThis(), _arg);
		}

		// Token: 0x060155E9 RID: 87529
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetJustification_93(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the horizontal justification to left (default), centered,
		/// or right.
		/// </summary>
		// Token: 0x060155EA RID: 87530 RVA: 0x001E4134 File Offset: 0x001E2334
		public virtual void SetJustification(int _arg)
		{
			vtkTextProperty.vtkTextProperty_SetJustification_93(base.GetCppThis(), _arg);
		}

		// Token: 0x060155EB RID: 87531
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetJustificationToCentered_94(HandleRef pThis);

		/// <summary>
		/// Set/Get the horizontal justification to left (default), centered,
		/// or right.
		/// </summary>
		// Token: 0x060155EC RID: 87532 RVA: 0x001E4144 File Offset: 0x001E2344
		public void SetJustificationToCentered()
		{
			vtkTextProperty.vtkTextProperty_SetJustificationToCentered_94(base.GetCppThis());
		}

		// Token: 0x060155ED RID: 87533
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetJustificationToLeft_95(HandleRef pThis);

		/// <summary>
		/// Set/Get the horizontal justification to left (default), centered,
		/// or right.
		/// </summary>
		// Token: 0x060155EE RID: 87534 RVA: 0x001E4153 File Offset: 0x001E2353
		public void SetJustificationToLeft()
		{
			vtkTextProperty.vtkTextProperty_SetJustificationToLeft_95(base.GetCppThis());
		}

		// Token: 0x060155EF RID: 87535
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetJustificationToRight_96(HandleRef pThis);

		/// <summary>
		/// Set/Get the horizontal justification to left (default), centered,
		/// or right.
		/// </summary>
		// Token: 0x060155F0 RID: 87536 RVA: 0x001E4162 File Offset: 0x001E2362
		public void SetJustificationToRight()
		{
			vtkTextProperty.vtkTextProperty_SetJustificationToRight_96(base.GetCppThis());
		}

		// Token: 0x060155F1 RID: 87537
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetLineOffset_97(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the vertical offset (measured in pixels).
		/// </summary>
		// Token: 0x060155F2 RID: 87538 RVA: 0x001E4171 File Offset: 0x001E2371
		public virtual void SetLineOffset(double _arg)
		{
			vtkTextProperty.vtkTextProperty_SetLineOffset_97(base.GetCppThis(), _arg);
		}

		// Token: 0x060155F3 RID: 87539
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetLineSpacing_98(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the (extra) spacing between lines,
		/// expressed as a text height multiplication factor.
		/// </summary>
		// Token: 0x060155F4 RID: 87540 RVA: 0x001E4181 File Offset: 0x001E2381
		public virtual void SetLineSpacing(double _arg)
		{
			vtkTextProperty.vtkTextProperty_SetLineSpacing_98(base.GetCppThis(), _arg);
		}

		// Token: 0x060155F5 RID: 87541
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetOpacity_99(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the text's opacity. 1.0 is totally opaque and 0.0 is completely
		/// transparent.
		/// </summary>
		// Token: 0x060155F6 RID: 87542 RVA: 0x001E4191 File Offset: 0x001E2391
		public virtual void SetOpacity(double _arg)
		{
			vtkTextProperty.vtkTextProperty_SetOpacity_99(base.GetCppThis(), _arg);
		}

		// Token: 0x060155F7 RID: 87543
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetOrientation_100(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the text's orientation (in degrees).
		/// </summary>
		// Token: 0x060155F8 RID: 87544 RVA: 0x001E41A1 File Offset: 0x001E23A1
		public virtual void SetOrientation(double _arg)
		{
			vtkTextProperty.vtkTextProperty_SetOrientation_100(base.GetCppThis(), _arg);
		}

		// Token: 0x060155F9 RID: 87545
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetShadow_101(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/disable text shadow.
		/// </summary>
		// Token: 0x060155FA RID: 87546 RVA: 0x001E41B1 File Offset: 0x001E23B1
		public virtual void SetShadow(int _arg)
		{
			vtkTextProperty.vtkTextProperty_SetShadow_101(base.GetCppThis(), _arg);
		}

		// Token: 0x060155FB RID: 87547
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetShadowOffset_102(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Set/Get the shadow offset, i.e. the distance from the text to
		/// its shadow, in the same unit as FontSize.
		/// </summary>
		// Token: 0x060155FC RID: 87548 RVA: 0x001E41C1 File Offset: 0x001E23C1
		public virtual void SetShadowOffset(int _arg1, int _arg2)
		{
			vtkTextProperty.vtkTextProperty_SetShadowOffset_102(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x060155FD RID: 87549
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetShadowOffset_103(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the shadow offset, i.e. the distance from the text to
		/// its shadow, in the same unit as FontSize.
		/// </summary>
		// Token: 0x060155FE RID: 87550 RVA: 0x001E41D2 File Offset: 0x001E23D2
		public void SetShadowOffset(IntPtr _arg)
		{
			vtkTextProperty.vtkTextProperty_SetShadowOffset_103(base.GetCppThis(), _arg);
		}

		// Token: 0x060155FF RID: 87551
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetUseTightBoundingBox_104(HandleRef pThis, int _arg);

		/// <summary>
		/// If this property is on, text is aligned to drawn pixels not to font metrix.
		/// If the text does not include descents, the bounding box will not extend below
		/// the baseline. This option can be used to get centered labels. It does not
		/// work well if the string changes as the string position will move around.
		/// </summary>
		// Token: 0x06015600 RID: 87552 RVA: 0x001E41E2 File Offset: 0x001E23E2
		public virtual void SetUseTightBoundingBox(int _arg)
		{
			vtkTextProperty.vtkTextProperty_SetUseTightBoundingBox_104(base.GetCppThis(), _arg);
		}

		// Token: 0x06015601 RID: 87553
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetVerticalJustification_105(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the vertical justification to bottom (default), middle,
		/// or top.
		/// </summary>
		// Token: 0x06015602 RID: 87554 RVA: 0x001E41F2 File Offset: 0x001E23F2
		public virtual void SetVerticalJustification(int _arg)
		{
			vtkTextProperty.vtkTextProperty_SetVerticalJustification_105(base.GetCppThis(), _arg);
		}

		// Token: 0x06015603 RID: 87555
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetVerticalJustificationToBottom_106(HandleRef pThis);

		/// <summary>
		/// Set/Get the vertical justification to bottom (default), middle,
		/// or top.
		/// </summary>
		// Token: 0x06015604 RID: 87556 RVA: 0x001E4202 File Offset: 0x001E2402
		public void SetVerticalJustificationToBottom()
		{
			vtkTextProperty.vtkTextProperty_SetVerticalJustificationToBottom_106(base.GetCppThis());
		}

		// Token: 0x06015605 RID: 87557
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetVerticalJustificationToCentered_107(HandleRef pThis);

		/// <summary>
		/// Set/Get the vertical justification to bottom (default), middle,
		/// or top.
		/// </summary>
		// Token: 0x06015606 RID: 87558 RVA: 0x001E4211 File Offset: 0x001E2411
		public void SetVerticalJustificationToCentered()
		{
			vtkTextProperty.vtkTextProperty_SetVerticalJustificationToCentered_107(base.GetCppThis());
		}

		// Token: 0x06015607 RID: 87559
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_SetVerticalJustificationToTop_108(HandleRef pThis);

		/// <summary>
		/// Set/Get the vertical justification to bottom (default), middle,
		/// or top.
		/// </summary>
		// Token: 0x06015608 RID: 87560 RVA: 0x001E4220 File Offset: 0x001E2420
		public void SetVerticalJustificationToTop()
		{
			vtkTextProperty.vtkTextProperty_SetVerticalJustificationToTop_108(base.GetCppThis());
		}

		// Token: 0x06015609 RID: 87561
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_ShadowOff_109(HandleRef pThis);

		/// <summary>
		/// Enable/disable text shadow.
		/// </summary>
		// Token: 0x0601560A RID: 87562 RVA: 0x001E422F File Offset: 0x001E242F
		public virtual void ShadowOff()
		{
			vtkTextProperty.vtkTextProperty_ShadowOff_109(base.GetCppThis());
		}

		// Token: 0x0601560B RID: 87563
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_ShadowOn_110(HandleRef pThis);

		/// <summary>
		/// Enable/disable text shadow.
		/// </summary>
		// Token: 0x0601560C RID: 87564 RVA: 0x001E423E File Offset: 0x001E243E
		public virtual void ShadowOn()
		{
			vtkTextProperty.vtkTextProperty_ShadowOn_110(base.GetCppThis());
		}

		// Token: 0x0601560D RID: 87565
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_ShallowCopy_111(HandleRef pThis, HandleRef tprop);

		/// <summary>
		/// Shallow copy of a text property.
		/// </summary>
		// Token: 0x0601560E RID: 87566 RVA: 0x001E4250 File Offset: 0x001E2450
		public void ShallowCopy(vtkTextProperty tprop)
		{
			vtkTextProperty.vtkTextProperty_ShallowCopy_111(base.GetCppThis(), (tprop == null) ? default(HandleRef) : tprop.GetCppThis());
		}

		// Token: 0x0601560F RID: 87567
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_UseTightBoundingBoxOff_112(HandleRef pThis);

		/// <summary>
		/// If this property is on, text is aligned to drawn pixels not to font metrix.
		/// If the text does not include descents, the bounding box will not extend below
		/// the baseline. This option can be used to get centered labels. It does not
		/// work well if the string changes as the string position will move around.
		/// </summary>
		// Token: 0x06015610 RID: 87568 RVA: 0x001E427F File Offset: 0x001E247F
		public virtual void UseTightBoundingBoxOff()
		{
			vtkTextProperty.vtkTextProperty_UseTightBoundingBoxOff_112(base.GetCppThis());
		}

		// Token: 0x06015611 RID: 87569
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextProperty_UseTightBoundingBoxOn_113(HandleRef pThis);

		/// <summary>
		/// If this property is on, text is aligned to drawn pixels not to font metrix.
		/// If the text does not include descents, the bounding box will not extend below
		/// the baseline. This option can be used to get centered labels. It does not
		/// work well if the string changes as the string position will move around.
		/// </summary>
		// Token: 0x06015612 RID: 87570 RVA: 0x001E428E File Offset: 0x001E248E
		public virtual void UseTightBoundingBoxOn()
		{
			vtkTextProperty.vtkTextProperty_UseTightBoundingBoxOn_113(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400187C RID: 6268
		public new const string MRFullTypeName = "Kitware.VTK.vtkTextProperty";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400187D RID: 6269
		public new static readonly string MRClassNameKey = "class vtkTextProperty";
	}
}
