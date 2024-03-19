using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkNamedColors
	/// </summary>
	/// <remarks>
	///    A class holding colors and their names.
	///
	/// For a web page showcasing VTK Named Colors and their RGB values, see:
	/// &lt;a
	/// href="https://htmlpreview.github.io/?https://github.com/Kitware/vtk-examples/blob/gh-pages/VTKNamedColorPatches.html"&gt;VTKNamedColorPatches&lt;/a&gt;;
	/// &lt;a
	/// href="https://kitware.github.io/vtk-examples/site/Python/Visualization/NamedColorPatches/"&gt;NamedColorPatches&lt;/a&gt;
	/// was used to generate this table.
	///
	/// Color names are case insensitive and are stored as lower-case names
	/// along with a 4-element array whose elements are red, green, blue and alpha,
	/// in that order, corresponding to the RGBA value of the color.
	///
	/// It is assumed that if the RGBA values are unsigned char then each element
	/// lies in the range 0...255 and if the RGBA values are double then each
	/// element lies in the range 0...1.
	///
	/// The colors and names are those in &lt;a href="https://en.wikipedia.org/wiki/Web_colors"&gt;Web
	/// colors&lt;/a&gt; that are derived from the CSS3 specification: &lt;a
	/// href="https://www.w3.org/TR/css-color-3/"&gt;CSS Color Module Level 3&lt;/a&gt; In this table
	/// common synonyms such as cyan/aqua and magenta/fuchsia are also included.
	///
	/// Also included in this class are names and colors taken from
	/// &lt;em&gt;Wrapping/Python/vtkmodules/util/colors.py&lt;/em&gt; that were originally taken from
	/// &lt;em&gt;Wrapping/Tcl/vtktesting/colors.tcl&lt;/em&gt; (no longer in the VTK source files - deleted
	/// 06-Dec-2017).
	///
	/// Web colors and names in &lt;a href="https://en.wikipedia.org/wiki/Web_colors"&gt;Web colors&lt;/a&gt; take
	/// precedence over those in &lt;em&gt;colors.py&lt;/em&gt;. One consequence of this
	/// is that while &lt;em&gt;colors.py&lt;/em&gt; specifies green as equivalent to
	/// (0,255,0), the web color standard defines it as (0,128,0).
	///
	/// The \a SetColor methods will overwrite existing colors if the name of the
	/// color being set matches an existing color. Note that ColorExists() can be
	/// used to test for existence of the color being set.
	///
	/// In the case of the \a GetColor methods returning doubles, alternative versions,
	/// identified by the letters RGB in the names, are provided.
	/// These get functions return just the red, green and blue components of
	/// a color.
	///
	/// The class also provides methods for defining a color through an HTML color
	/// string. The following formats are supported:
	///
	/// - \#RGB                 (3-digit hexadecimal number, where #4F2 is a shortcut for #44FF22)
	/// - \#RRGGBB              (6-digit hexadecimal number)
	/// - rgb(r, g, b)          (where r, g, b are in 0..255 or percentage values)
	/// - rgba(r, g, b, a)      (where r, g, b, are in 0..255 or percentage values, a is in 0.0..1.0)
	/// - a CSS3 color name     (e.g. "steelblue")
	/// </remarks>
	// Token: 0x0200008F RID: 143
	public class vtkNamedColors : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06001B77 RID: 7031 RVA: 0x0002BB88 File Offset: 0x00029D88
		static vtkNamedColors()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkNamedColors.MRClassNameKey, Type.GetType("Kitware.VTK.vtkNamedColors"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06001B78 RID: 7032 RVA: 0x0002BBB0 File Offset: 0x00029DB0
		public vtkNamedColors(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06001B79 RID: 7033
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNamedColors_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a new vtkNamedColors object.
		/// </summary>
		// Token: 0x06001B7A RID: 7034 RVA: 0x0002BBC0 File Offset: 0x00029DC0
		public new static vtkNamedColors New()
		{
			vtkNamedColors result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNamedColors.vtkNamedColors_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNamedColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create a new vtkNamedColors object.
		/// </summary>
		// Token: 0x06001B7B RID: 7035 RVA: 0x0002BC14 File Offset: 0x00029E14
		public vtkNamedColors() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkNamedColors.vtkNamedColors_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06001B7C RID: 7036 RVA: 0x0002BC58 File Offset: 0x00029E58
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06001B7D RID: 7037
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkNamedColors_ColorExists_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return true if the color exists.
		/// </summary>
		// Token: 0x06001B7E RID: 7038 RVA: 0x0002BC64 File Offset: 0x00029E64
		public bool ColorExists(string name)
		{
			return vtkNamedColors.vtkNamedColors_ColorExists_01(base.GetCppThis(), name) != 0;
		}

		// Token: 0x06001B7F RID: 7039
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNamedColors_GetColor_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref byte r, ref byte g, ref byte b, ref byte a);

		/// <summary>
		/// Get the color by name.
		/// The name is treated as being case-insensitive.
		/// The color is returned as four unsigned char variables:
		/// red, green, blue, alpha. The range of each element is 0...255.
		/// The color black is returned if the color is not found.
		/// </summary>
		// Token: 0x06001B80 RID: 7040 RVA: 0x0002BC8B File Offset: 0x00029E8B
		public void GetColor(string name, ref byte r, ref byte g, ref byte b, ref byte a)
		{
			vtkNamedColors.vtkNamedColors_GetColor_02(base.GetCppThis(), name, ref r, ref g, ref b, ref a);
		}

		// Token: 0x06001B81 RID: 7041
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNamedColors_GetColor_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr rgba);

		/// <summary>
		/// Get the color by name.
		/// The name is treated as being case-insensitive.
		/// The color is returned as an unsigned char array:
		/// [red, green, blue, alpha]. The range of each element is 0...255.
		/// The color black is returned if the color is not found.
		/// </summary>
		// Token: 0x06001B82 RID: 7042 RVA: 0x0002BCA1 File Offset: 0x00029EA1
		public void GetColor(string name, IntPtr rgba)
		{
			vtkNamedColors.vtkNamedColors_GetColor_03(base.GetCppThis(), name, rgba);
		}

		// Token: 0x06001B83 RID: 7043
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNamedColors_GetColor_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, HandleRef rgba);

		/// <summary>
		/// Get the color by name.
		/// The name is treated as being case-insensitive.
		/// The color is returned as a vtkColor4ub class.
		/// The color black is returned if the color is not found.
		/// </summary>
		// Token: 0x06001B84 RID: 7044 RVA: 0x0002BCB4 File Offset: 0x00029EB4
		public void GetColor(string name, vtkColor4ub rgba)
		{
			vtkNamedColors.vtkNamedColors_GetColor_04(base.GetCppThis(), name, (rgba == null) ? default(HandleRef) : rgba.GetCppThis());
		}

		// Token: 0x06001B85 RID: 7045
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNamedColors_GetColor_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref double r, ref double g, ref double b, ref double a);

		/// <summary>
		/// Get the color by name.
		/// The name is treated as being case-insensitive.
		/// The color is returned as four double variables:
		/// red, green, blue, alpha. The range of each element is 0...1.
		/// The color black is returned if the color is not found.
		/// </summary>
		// Token: 0x06001B86 RID: 7046 RVA: 0x0002BCE4 File Offset: 0x00029EE4
		public void GetColor(string name, ref double r, ref double g, ref double b, ref double a)
		{
			vtkNamedColors.vtkNamedColors_GetColor_05(base.GetCppThis(), name, ref r, ref g, ref b, ref a);
		}

		// Token: 0x06001B87 RID: 7047
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNamedColors_GetColor_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, HandleRef rgba);

		/// <summary>
		/// Get the color by name.
		/// The name is treated as being case-insensitive.
		/// The color is returned as a vtkColor4d class.
		/// The color black is returned if the color is not found.
		/// </summary>
		// Token: 0x06001B88 RID: 7048 RVA: 0x0002BCFC File Offset: 0x00029EFC
		public void GetColor(string name, vtkColor4d rgba)
		{
			vtkNamedColors.vtkNamedColors_GetColor_06(base.GetCppThis(), name, (rgba == null) ? default(HandleRef) : rgba.GetCppThis());
		}

		// Token: 0x06001B89 RID: 7049
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNamedColors_GetColor_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref double r, ref double g, ref double b);

		/// <summary>
		/// Get the color by name.
		/// The name is treated as being case-insensitive.
		/// The color is returned as three double variables:
		/// red, green, blue. The range of each element is 0...1.
		/// The color black is returned if the color is not found.
		/// </summary>
		// Token: 0x06001B8A RID: 7050 RVA: 0x0002BD2C File Offset: 0x00029F2C
		public void GetColor(string name, ref double r, ref double g, ref double b)
		{
			vtkNamedColors.vtkNamedColors_GetColor_07(base.GetCppThis(), name, ref r, ref g, ref b);
		}

		// Token: 0x06001B8B RID: 7051
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNamedColors_GetColor_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, HandleRef rgb);

		/// <summary>
		/// Get the color by name.
		/// The name is treated as being case-insensitive.
		/// The color is returned as a vtkColor3ub class.
		/// The color black is returned if the color is not found.
		/// </summary>
		// Token: 0x06001B8C RID: 7052 RVA: 0x0002BD40 File Offset: 0x00029F40
		public void GetColor(string name, vtkColor3ub rgb)
		{
			vtkNamedColors.vtkNamedColors_GetColor_08(base.GetCppThis(), name, (rgb == null) ? default(HandleRef) : rgb.GetCppThis());
		}

		// Token: 0x06001B8D RID: 7053
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNamedColors_GetColor_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, HandleRef rgb);

		/// <summary>
		/// Get the color by name.
		/// The name is treated as being case-insensitive.
		/// The color is returned as a vtkColor3d class.
		/// The color black is returned if the color is not found.
		/// </summary>
		// Token: 0x06001B8E RID: 7054 RVA: 0x0002BD70 File Offset: 0x00029F70
		public void GetColor(string name, vtkColor3d rgb)
		{
			vtkNamedColors.vtkNamedColors_GetColor_09(base.GetCppThis(), name, (rgb == null) ? default(HandleRef) : rgb.GetCppThis());
		}

		// Token: 0x06001B8F RID: 7055
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNamedColors_GetColor3d_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the color by name.
		/// The name is treated as being case-insensitive.
		/// The color is returned as a vtkColor3d class.
		/// The color black is returned if the color is not found.
		/// </summary>
		// Token: 0x06001B90 RID: 7056 RVA: 0x0002BDA0 File Offset: 0x00029FA0
		public vtkColor3d GetColor3d(string name)
		{
			vtkColor3d result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNamedColors.vtkNamedColors_GetColor3d_10(base.GetCppThis(), name, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColor3d)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001B91 RID: 7057
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNamedColors_GetColor3ub_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the color by name.
		/// The name is treated as being case-insensitive.
		/// The color is returned as a vtkColor3ub class.
		/// The color black is returned if the color is not found.
		/// </summary>
		// Token: 0x06001B92 RID: 7058 RVA: 0x0002BDFC File Offset: 0x00029FFC
		public vtkColor3ub GetColor3ub(string name)
		{
			vtkColor3ub result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNamedColors.vtkNamedColors_GetColor3ub_11(base.GetCppThis(), name, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColor3ub)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001B93 RID: 7059
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNamedColors_GetColor4d_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the color by name.
		/// The name is treated as being case-insensitive.
		/// The color is returned as a vtkColor4d class.
		/// The color black is returned if the color is not found.
		/// </summary>
		// Token: 0x06001B94 RID: 7060 RVA: 0x0002BE58 File Offset: 0x0002A058
		public vtkColor4d GetColor4d(string name)
		{
			vtkColor4d result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNamedColors.vtkNamedColors_GetColor4d_12(base.GetCppThis(), name, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColor4d)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001B95 RID: 7061
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNamedColors_GetColor4ub_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the color by name.
		/// The name is treated as being case-insensitive.
		/// The color is returned as a vtkColor4ub class.
		/// The color black is returned if the color is not found.
		/// </summary>
		// Token: 0x06001B96 RID: 7062 RVA: 0x0002BEB4 File Offset: 0x0002A0B4
		public vtkColor4ub GetColor4ub(string name)
		{
			vtkColor4ub result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNamedColors.vtkNamedColors_GetColor4ub_13(base.GetCppThis(), name, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColor4ub)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001B97 RID: 7063
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkNamedColors_GetColorNames_14(HandleRef pThis);

		/// <summary>
		/// Return a string of color names with each name
		/// delimited by a line feed.
		/// This is easily parsed by the user into whatever
		/// data structure they require.
		/// Examples for parsing are provided in:
		/// TestNamedColors.cxx and TestNamedColorsIntegration.py
		/// </summary>
		// Token: 0x06001B98 RID: 7064 RVA: 0x0002BF10 File Offset: 0x0002A110
		public string GetColorNames()
		{
			return vtkNamedColors.vtkNamedColors_GetColorNames_14(base.GetCppThis());
		}

		// Token: 0x06001B99 RID: 7065
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNamedColors_GetColorNames_15(HandleRef pThis, HandleRef colorNames);

		/// <summary>
		/// Return a string array of color names.
		/// </summary>
		// Token: 0x06001B9A RID: 7066 RVA: 0x0002BF30 File Offset: 0x0002A130
		public void GetColorNames(vtkStringArray colorNames)
		{
			vtkNamedColors.vtkNamedColors_GetColorNames_15(base.GetCppThis(), (colorNames == null) ? default(HandleRef) : colorNames.GetCppThis());
		}

		// Token: 0x06001B9B RID: 7067
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNamedColors_GetColorRGB_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr rgb);

		/// <summary>
		/// Get the color by name.
		/// The name is treated as being case-insensitive.
		/// The color is returned as a double array:
		/// [red, green, blue]. The range of each element is 0...1.
		/// The color black is returned if the color is not found.
		/// </summary>
		// Token: 0x06001B9C RID: 7068 RVA: 0x0002BF5F File Offset: 0x0002A15F
		public void GetColorRGB(string name, IntPtr rgb)
		{
			vtkNamedColors.vtkNamedColors_GetColorRGB_16(base.GetCppThis(), name, rgb);
		}

		// Token: 0x06001B9D RID: 7069
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNamedColors_GetNumberOfColors_17(HandleRef pThis);

		/// <summary>
		/// Get the number of colors.
		/// </summary>
		// Token: 0x06001B9E RID: 7070 RVA: 0x0002BF70 File Offset: 0x0002A170
		public int GetNumberOfColors()
		{
			return vtkNamedColors.vtkNamedColors_GetNumberOfColors_17(base.GetCppThis());
		}

		// Token: 0x06001B9F RID: 7071
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNamedColors_GetNumberOfGenerationsFromBase_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001BA0 RID: 7072 RVA: 0x0002BF90 File Offset: 0x0002A190
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkNamedColors.vtkNamedColors_GetNumberOfGenerationsFromBase_18(base.GetCppThis(), type);
		}

		// Token: 0x06001BA1 RID: 7073
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNamedColors_GetNumberOfGenerationsFromBaseType_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001BA2 RID: 7074 RVA: 0x0002BFB0 File Offset: 0x0002A1B0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkNamedColors.vtkNamedColors_GetNumberOfGenerationsFromBaseType_19(type);
		}

		// Token: 0x06001BA3 RID: 7075
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkNamedColors_GetSynonyms_20(HandleRef pThis);

		/// <summary>
		/// Return a string of synonyms such as
		/// cyan/aqua and magenta/fuchsia.
		/// The string is formatted such that a single line feed delimits
		/// each color in the synonym and a double line feed delimits each
		/// synonym.
		/// Warning this could take a long time for very large color maps.
		/// This is easily parsed by the user into whatever
		/// data structure they require.
		/// </summary>
		// Token: 0x06001BA4 RID: 7076 RVA: 0x0002BFCC File Offset: 0x0002A1CC
		public string GetSynonyms()
		{
			return vtkNamedColors.vtkNamedColors_GetSynonyms_20(base.GetCppThis());
		}

		// Token: 0x06001BA5 RID: 7077
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNamedColors_HTMLColorToRGB_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string colorString, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return a vtkColor3ub instance from an HTML color string in any of
		/// the following formats:
		/// - \#RGB
		/// - \#RRGGBB
		/// - rgb(r, g, b)
		/// - rgba(r, g, b, a)
		/// - a CSS3 color name, e.g. "steelblue"
		/// If the string argument defines a color using one of the above formats
		/// the method returns the successfully parsed color else returns the color
		/// black.
		/// </summary>
		// Token: 0x06001BA6 RID: 7078 RVA: 0x0002BFEC File Offset: 0x0002A1EC
		public vtkColor3ub HTMLColorToRGB(string colorString)
		{
			vtkColor3ub result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNamedColors.vtkNamedColors_HTMLColorToRGB_21(base.GetCppThis(), colorString, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColor3ub)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001BA7 RID: 7079
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNamedColors_HTMLColorToRGBA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string colorString, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return a vtkColor4ub instance from an HTML color string in any of
		/// the following formats:
		/// - \#RGB
		/// - \#RRGGBB
		/// - rgb(r, g, b)
		/// - rgba(r, g, b, a)
		/// - a CSS3 color name, e.g. "steelblue"
		/// If the string argument defines a color using one of the above formats
		/// the method returns the successfully parsed color else returns a color
		/// equal to `rgba(0, 0, 0, 0)`.
		/// </summary>
		// Token: 0x06001BA8 RID: 7080 RVA: 0x0002C048 File Offset: 0x0002A248
		public vtkColor4ub HTMLColorToRGBA(string colorString)
		{
			vtkColor4ub result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNamedColors.vtkNamedColors_HTMLColorToRGBA_22(base.GetCppThis(), colorString, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColor4ub)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001BA9 RID: 7081
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNamedColors_IsA_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001BAA RID: 7082 RVA: 0x0002C0A4 File Offset: 0x0002A2A4
		public override int IsA(string type)
		{
			return vtkNamedColors.vtkNamedColors_IsA_23(base.GetCppThis(), type);
		}

		// Token: 0x06001BAB RID: 7083
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNamedColors_IsTypeOf_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001BAC RID: 7084 RVA: 0x0002C0C4 File Offset: 0x0002A2C4
		public new static int IsTypeOf(string type)
		{
			return vtkNamedColors.vtkNamedColors_IsTypeOf_24(type);
		}

		// Token: 0x06001BAD RID: 7085
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNamedColors_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001BAE RID: 7086 RVA: 0x0002C0E0 File Offset: 0x0002A2E0
		public new vtkNamedColors NewInstance()
		{
			vtkNamedColors result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNamedColors.vtkNamedColors_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNamedColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001BAF RID: 7087
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkNamedColors_RGBAToHTMLColor_27(HandleRef pThis, HandleRef rgba);

		/// <summary>
		/// Given a vtkColor4ub instance as input color return a valid HTML color
		/// string in the `rgba(r, g, b, a)` format.
		/// </summary>
		// Token: 0x06001BB0 RID: 7088 RVA: 0x0002C13C File Offset: 0x0002A33C
		public string RGBAToHTMLColor(vtkColor4ub rgba)
		{
			return vtkNamedColors.vtkNamedColors_RGBAToHTMLColor_27(base.GetCppThis(), (rgba == null) ? default(HandleRef) : rgba.GetCppThis());
		}

		// Token: 0x06001BB1 RID: 7089
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkNamedColors_RGBToHTMLColor_28(HandleRef pThis, HandleRef rgb);

		/// <summary>
		/// Given a vtkColor3ub instance as input color return a valid HTML color
		/// string in the `#RRGGBB` format.
		/// </summary>
		// Token: 0x06001BB2 RID: 7090 RVA: 0x0002C170 File Offset: 0x0002A370
		public string RGBToHTMLColor(vtkColor3ub rgb)
		{
			return vtkNamedColors.vtkNamedColors_RGBToHTMLColor_28(base.GetCppThis(), (rgb == null) ? default(HandleRef) : rgb.GetCppThis());
		}

		// Token: 0x06001BB3 RID: 7091
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNamedColors_RemoveColor_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Remove the color by name.
		/// The name is treated as being case-insensitive.
		/// Examples for parsing are provided in:
		/// TestNamedColors.cxx and TestNamedColorsIntegration.py
		/// </summary>
		// Token: 0x06001BB4 RID: 7092 RVA: 0x0002C1A4 File Offset: 0x0002A3A4
		public void RemoveColor(string name)
		{
			vtkNamedColors.vtkNamedColors_RemoveColor_29(base.GetCppThis(), name);
		}

		// Token: 0x06001BB5 RID: 7093
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNamedColors_ResetColors_30(HandleRef pThis);

		/// <summary>
		/// Reset the colors in the color map to the original colors.
		/// Any colors inserted by the user will be lost.
		/// </summary>
		// Token: 0x06001BB6 RID: 7094 RVA: 0x0002C1B4 File Offset: 0x0002A3B4
		public void ResetColors()
		{
			vtkNamedColors.vtkNamedColors_ResetColors_30(base.GetCppThis());
		}

		// Token: 0x06001BB7 RID: 7095
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNamedColors_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001BB8 RID: 7096 RVA: 0x0002C1C4 File Offset: 0x0002A3C4
		public new static vtkNamedColors SafeDownCast(vtkObjectBase o)
		{
			vtkNamedColors vtkNamedColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNamedColors.vtkNamedColors_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNamedColors = (vtkNamedColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNamedColors.Register(null);
				}
			}
			return vtkNamedColors;
		}

		// Token: 0x06001BB9 RID: 7097
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNamedColors_SetColor_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref byte r, ref byte g, ref byte b, ref byte a);

		/// <summary>
		/// Set the color by name.
		/// The name is treated as being case-insensitive.
		/// The range of each color is 0...255.
		/// No color is set if the name is empty.
		/// </summary>
		// Token: 0x06001BBA RID: 7098 RVA: 0x0002C243 File Offset: 0x0002A443
		public virtual void SetColor(string name, ref byte r, ref byte g, ref byte b, ref byte a)
		{
			vtkNamedColors.vtkNamedColors_SetColor_32(base.GetCppThis(), name, ref r, ref g, ref b, ref a);
		}

		// Token: 0x06001BBB RID: 7099
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNamedColors_SetColor_33(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref double r, ref double g, ref double b, ref double a);

		/// <summary>
		/// Set the color by name.
		/// The name is treated as being case-insensitive.
		/// The range of each color is 0...1.
		/// No color is set if the name is empty.
		/// </summary>
		// Token: 0x06001BBC RID: 7100 RVA: 0x0002C259 File Offset: 0x0002A459
		public virtual void SetColor(string name, ref double r, ref double g, ref double b, ref double a)
		{
			vtkNamedColors.vtkNamedColors_SetColor_33(base.GetCppThis(), name, ref r, ref g, ref b, ref a);
		}

		// Token: 0x06001BBD RID: 7101
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNamedColors_SetColor_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr rgba);

		/// <summary>
		/// Set the color by name.
		/// The name is treated as being case-insensitive.
		/// The color is an unsigned char array:
		/// [red, green, blue, alpha]. The range of each element is 0...255.
		/// The user must ensure that the color array size is 4.
		/// No color is set if the name is empty.
		/// </summary>
		// Token: 0x06001BBE RID: 7102 RVA: 0x0002C26F File Offset: 0x0002A46F
		public virtual void SetColor(string name, IntPtr rgba)
		{
			vtkNamedColors.vtkNamedColors_SetColor_34(base.GetCppThis(), name, rgba);
		}

		// Token: 0x06001BBF RID: 7103
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNamedColors_SetColor_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, HandleRef rgba);

		/// <summary>
		/// Set the color by name.
		/// The name is treated as being case-insensitive.
		/// The color is a vtkColor4ub class.
		/// No color is set if the name is empty.
		/// </summary>
		// Token: 0x06001BC0 RID: 7104 RVA: 0x0002C280 File Offset: 0x0002A480
		public virtual void SetColor(string name, vtkColor4ub rgba)
		{
			vtkNamedColors.vtkNamedColors_SetColor_35(base.GetCppThis(), name, (rgba == null) ? default(HandleRef) : rgba.GetCppThis());
		}

		// Token: 0x06001BC1 RID: 7105
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNamedColors_SetColor_36(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, HandleRef rgb);

		/// <summary>
		/// Set the color by name.
		/// The name is treated as being case-insensitive.
		/// The color is a vtkColor3ub class.
		/// No color is set if the name is empty.
		/// </summary>
		// Token: 0x06001BC2 RID: 7106 RVA: 0x0002C2B0 File Offset: 0x0002A4B0
		public virtual void SetColor(string name, vtkColor3ub rgb)
		{
			vtkNamedColors.vtkNamedColors_SetColor_36(base.GetCppThis(), name, (rgb == null) ? default(HandleRef) : rgb.GetCppThis());
		}

		// Token: 0x06001BC3 RID: 7107
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNamedColors_SetColor_37(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, HandleRef rgba);

		/// <summary>
		/// Set the color by name.
		/// The name is treated as being case-insensitive.
		/// The color is a vtkColor4d class.
		/// No color is set if the name is empty.
		/// </summary>
		// Token: 0x06001BC4 RID: 7108 RVA: 0x0002C2E0 File Offset: 0x0002A4E0
		public virtual void SetColor(string name, vtkColor4d rgba)
		{
			vtkNamedColors.vtkNamedColors_SetColor_37(base.GetCppThis(), name, (rgba == null) ? default(HandleRef) : rgba.GetCppThis());
		}

		// Token: 0x06001BC5 RID: 7109
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNamedColors_SetColor_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, HandleRef rgb);

		/// <summary>
		/// Set the color by name.
		/// The name is treated as being case-insensitive.
		/// The color is a vtkColor3d class.
		/// No color is set if the name is empty.
		/// </summary>
		// Token: 0x06001BC6 RID: 7110 RVA: 0x0002C310 File Offset: 0x0002A510
		public virtual void SetColor(string name, vtkColor3d rgb)
		{
			vtkNamedColors.vtkNamedColors_SetColor_38(base.GetCppThis(), name, (rgb == null) ? default(HandleRef) : rgb.GetCppThis());
		}

		// Token: 0x06001BC7 RID: 7111
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNamedColors_SetColor_39(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string htmlString);

		/// <summary>
		/// Set the color by name.
		/// The name is treated as being case-insensitive.
		/// The color must be a valid HTML color string.
		/// No color is set if the name is empty or if `htmlString` is not a valid
		/// HTML color string.
		/// </summary>
		// Token: 0x06001BC8 RID: 7112 RVA: 0x0002C340 File Offset: 0x0002A540
		public void SetColor(string name, string htmlString)
		{
			vtkNamedColors.vtkNamedColors_SetColor_39(base.GetCppThis(), name, htmlString);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040004FB RID: 1275
		public new const string MRFullTypeName = "Kitware.VTK.vtkNamedColors";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040004FC RID: 1276
		public new static readonly string MRClassNameKey = "class vtkNamedColors";
	}
}
