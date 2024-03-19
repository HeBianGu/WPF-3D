using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkColorSeries
	/// </summary>
	/// <remarks>
	///    stores a list of colors.
	///
	///
	/// The vtkColorSeries stores palettes of colors. There are several default
	/// palettes (or schemes) available and functions to control several aspects
	/// of what colors are returned. In essence a color scheme is set and then
	/// the number of colors and individual color values may be requested.
	///
	/// For a web page showcasing the default palettes, see:
	/// &lt;a
	/// href="https://htmlpreview.github.io/?https://github.com/Kitware/vtk-examples/blob/gh-pages/VTKColorSeriesPatches.html"&gt;VTKColorSeriesPatches&lt;/a&gt;;
	/// &lt;a
	/// href="https://kitware.github.io/vtk-examples/site/Python/Visualization/ColorSeriesPatches/"&gt;ColorSeriesPatches&lt;/a&gt;
	/// was used to generate this table.
	///
	/// It is also possible to add schemes beyond the default palettes.
	/// Whenever \a SetColorScheme is called with a string for which no palette
	/// already exists, a new, empty palette is created.
	/// You may then use \a SetNumberOfColors and \a SetColor to populate the
	/// palette.
	/// You may not extend default palettes by calling functions that alter
	/// a scheme; if called while a predefined palette is in use, they
	/// will create a new non-default scheme and populate it with the current
	/// palette before continuing.
	///
	/// The "Brewer" palettes are courtesy of
	/// Cynthia A. Brewer (Dept. of Geography, Pennsylvania State University)
	/// and under the Apache License. See the source code for details.
	/// </remarks>
	// Token: 0x0200008C RID: 140
	public class vtkColorSeries : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06001B41 RID: 6977 RVA: 0x0002B64F File Offset: 0x0002984F
		static vtkColorSeries()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkColorSeries.MRClassNameKey, Type.GetType("Kitware.VTK.vtkColorSeries"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06001B42 RID: 6978 RVA: 0x0002B677 File Offset: 0x00029877
		public vtkColorSeries(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06001B43 RID: 6979
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColorSeries_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a new vtkColorSeries with the SPECTRUM color scheme.
		/// </summary>
		// Token: 0x06001B44 RID: 6980 RVA: 0x0002B688 File Offset: 0x00029888
		public new static vtkColorSeries New()
		{
			vtkColorSeries result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkColorSeries.vtkColorSeries_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColorSeries)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create a new vtkColorSeries with the SPECTRUM color scheme.
		/// </summary>
		// Token: 0x06001B45 RID: 6981 RVA: 0x0002B6DC File Offset: 0x000298DC
		public vtkColorSeries() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkColorSeries.vtkColorSeries_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06001B46 RID: 6982 RVA: 0x0002B720 File Offset: 0x00029920
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06001B47 RID: 6983
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorSeries_AddColor_01(HandleRef pThis, HandleRef color);

		/// <summary>
		/// Adds the color to the end of the list.
		/// </summary>
		// Token: 0x06001B48 RID: 6984 RVA: 0x0002B72C File Offset: 0x0002992C
		public virtual void AddColor(vtkColor3ub color)
		{
			vtkColorSeries.vtkColorSeries_AddColor_01(base.GetCppThis(), (color == null) ? default(HandleRef) : color.GetCppThis());
		}

		// Token: 0x06001B49 RID: 6985
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorSeries_BuildLookupTable_02(HandleRef pThis, HandleRef lkup, int lutIndexing);

		/// <summary>
		/// Populate a lookup table with all the colors in the current scheme.
		///
		/// The default behavior is to return categorical data. Set lutIndexing
		/// to ORDINAL to return ordinal data. Any other value for lutIndexing
		/// is treated as CATEGORICAL.
		/// </summary>
		// Token: 0x06001B4A RID: 6986 RVA: 0x0002B75C File Offset: 0x0002995C
		public void BuildLookupTable(vtkLookupTable lkup, int lutIndexing)
		{
			vtkColorSeries.vtkColorSeries_BuildLookupTable_02(base.GetCppThis(), (lkup == null) ? default(HandleRef) : lkup.GetCppThis(), lutIndexing);
		}

		// Token: 0x06001B4B RID: 6987
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorSeries_ClearColors_03(HandleRef pThis);

		/// <summary>
		/// Clears the list of colors.
		/// </summary>
		// Token: 0x06001B4C RID: 6988 RVA: 0x0002B78C File Offset: 0x0002998C
		public virtual void ClearColors()
		{
			vtkColorSeries.vtkColorSeries_ClearColors_03(base.GetCppThis());
		}

		// Token: 0x06001B4D RID: 6989
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColorSeries_CreateLookupTable_04(HandleRef pThis, int lutIndexing, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a new lookup table with all the colors in the current scheme.
		///
		/// The caller is responsible for deleting the table after use.
		///
		/// The default behavior is to return categorical data. Set lutIndexing
		/// to ORDINAL to return ordinal data. Any other value for lutIndexing
		/// is treated as CATEGORICAL.
		/// </summary>
		// Token: 0x06001B4E RID: 6990 RVA: 0x0002B79C File Offset: 0x0002999C
		public vtkLookupTable CreateLookupTable(int lutIndexing)
		{
			vtkLookupTable vtkLookupTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkColorSeries.vtkColorSeries_CreateLookupTable_04(base.GetCppThis(), lutIndexing, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLookupTable = (vtkLookupTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLookupTable.Register(null);
				}
			}
			return vtkLookupTable;
		}

		// Token: 0x06001B4F RID: 6991
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorSeries_DeepCopy_05(HandleRef pThis, HandleRef chartColors);

		/// <summary>
		/// Make a deep copy of the supplied object.
		/// </summary>
		// Token: 0x06001B50 RID: 6992 RVA: 0x0002B80C File Offset: 0x00029A0C
		public virtual void DeepCopy(vtkColorSeries chartColors)
		{
			vtkColorSeries.vtkColorSeries_DeepCopy_05(base.GetCppThis(), (chartColors == null) ? default(HandleRef) : chartColors.GetCppThis());
		}

		// Token: 0x06001B51 RID: 6993
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColorSeries_GetColor_06(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the color at the specified index. If the index is out of range then
		/// black will be returned.
		/// </summary>
		// Token: 0x06001B52 RID: 6994 RVA: 0x0002B83C File Offset: 0x00029A3C
		public vtkColor3ub GetColor(int index)
		{
			vtkColor3ub result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkColorSeries.vtkColorSeries_GetColor_06(base.GetCppThis(), index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColor3ub)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001B53 RID: 6995
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColorSeries_GetColorRepeating_07(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the color at the specified index. If the index is out of range then
		/// the call wraps around, i.e. uses the mod operator.
		/// </summary>
		// Token: 0x06001B54 RID: 6996 RVA: 0x0002B898 File Offset: 0x00029A98
		public vtkColor3ub GetColorRepeating(int index)
		{
			vtkColor3ub result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkColorSeries.vtkColorSeries_GetColorRepeating_07(base.GetCppThis(), index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColor3ub)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001B55 RID: 6997
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorSeries_GetColorScheme_08(HandleRef pThis);

		/// <summary>
		/// Return the ID of the color scheme currently in use.
		/// </summary>
		// Token: 0x06001B56 RID: 6998 RVA: 0x0002B8F4 File Offset: 0x00029AF4
		public virtual int GetColorScheme()
		{
			return vtkColorSeries.vtkColorSeries_GetColorScheme_08(base.GetCppThis());
		}

		// Token: 0x06001B57 RID: 6999
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkColorSeries_GetColorSchemeName_09(HandleRef pThis);

		/// <summary>
		/// Get the color scheme that is currently being used.
		/// </summary>
		// Token: 0x06001B58 RID: 7000 RVA: 0x0002B914 File Offset: 0x00029B14
		public virtual string GetColorSchemeName()
		{
			return vtkColorSeries.vtkColorSeries_GetColorSchemeName_09(base.GetCppThis());
		}

		// Token: 0x06001B59 RID: 7001
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorSeries_GetNumberOfColorSchemes_10(HandleRef pThis);

		/// <summary>
		/// Return the number of schemes currently defined.
		/// </summary>
		// Token: 0x06001B5A RID: 7002 RVA: 0x0002B934 File Offset: 0x00029B34
		public int GetNumberOfColorSchemes()
		{
			return vtkColorSeries.vtkColorSeries_GetNumberOfColorSchemes_10(base.GetCppThis());
		}

		// Token: 0x06001B5B RID: 7003
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorSeries_GetNumberOfColors_11(HandleRef pThis);

		/// <summary>
		/// Get the number of colors available in the current color scheme.
		/// </summary>
		// Token: 0x06001B5C RID: 7004 RVA: 0x0002B954 File Offset: 0x00029B54
		public virtual int GetNumberOfColors()
		{
			return vtkColorSeries.vtkColorSeries_GetNumberOfColors_11(base.GetCppThis());
		}

		// Token: 0x06001B5D RID: 7005
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkColorSeries_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001B5E RID: 7006 RVA: 0x0002B974 File Offset: 0x00029B74
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkColorSeries.vtkColorSeries_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x06001B5F RID: 7007
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkColorSeries_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001B60 RID: 7008 RVA: 0x0002B994 File Offset: 0x00029B94
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkColorSeries.vtkColorSeries_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x06001B61 RID: 7009
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorSeries_InsertColor_14(HandleRef pThis, int index, HandleRef color);

		/// <summary>
		/// Inserts the color at the specified index in the list.
		/// </summary>
		// Token: 0x06001B62 RID: 7010 RVA: 0x0002B9B0 File Offset: 0x00029BB0
		public virtual void InsertColor(int index, vtkColor3ub color)
		{
			vtkColorSeries.vtkColorSeries_InsertColor_14(base.GetCppThis(), index, (color == null) ? default(HandleRef) : color.GetCppThis());
		}

		// Token: 0x06001B63 RID: 7011
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorSeries_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001B64 RID: 7012 RVA: 0x0002B9E0 File Offset: 0x00029BE0
		public override int IsA(string type)
		{
			return vtkColorSeries.vtkColorSeries_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x06001B65 RID: 7013
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorSeries_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001B66 RID: 7014 RVA: 0x0002BA00 File Offset: 0x00029C00
		public new static int IsTypeOf(string type)
		{
			return vtkColorSeries.vtkColorSeries_IsTypeOf_16(type);
		}

		// Token: 0x06001B67 RID: 7015
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColorSeries_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001B68 RID: 7016 RVA: 0x0002BA1C File Offset: 0x00029C1C
		public new vtkColorSeries NewInstance()
		{
			vtkColorSeries result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkColorSeries.vtkColorSeries_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColorSeries)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001B69 RID: 7017
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorSeries_RemoveColor_19(HandleRef pThis, int index);

		/// <summary>
		/// Removes the color at the specified index in the list.
		/// </summary>
		// Token: 0x06001B6A RID: 7018 RVA: 0x0002BA76 File Offset: 0x00029C76
		public virtual void RemoveColor(int index)
		{
			vtkColorSeries.vtkColorSeries_RemoveColor_19(base.GetCppThis(), index);
		}

		// Token: 0x06001B6B RID: 7019
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkColorSeries_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001B6C RID: 7020 RVA: 0x0002BA88 File Offset: 0x00029C88
		public new static vtkColorSeries SafeDownCast(vtkObjectBase o)
		{
			vtkColorSeries vtkColorSeries = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkColorSeries.vtkColorSeries_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkColorSeries = (vtkColorSeries)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkColorSeries.Register(null);
				}
			}
			return vtkColorSeries;
		}

		// Token: 0x06001B6D RID: 7021
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorSeries_SetColor_21(HandleRef pThis, int index, HandleRef color);

		/// <summary>
		/// Set the color at the specified index. Does nothing if the index is out of
		/// range.
		/// </summary>
		// Token: 0x06001B6E RID: 7022 RVA: 0x0002BB08 File Offset: 0x00029D08
		public virtual void SetColor(int index, vtkColor3ub color)
		{
			vtkColorSeries.vtkColorSeries_SetColor_21(base.GetCppThis(), index, (color == null) ? default(HandleRef) : color.GetCppThis());
		}

		// Token: 0x06001B6F RID: 7023
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorSeries_SetColorScheme_22(HandleRef pThis, int scheme);

		/// <summary>
		/// Set the color scheme that should be used.
		/// The variant of this function that takes an integer should pass a
		/// number from those in the enum, or a value returned by the string variant.
		/// The variant that accepts a string returns the integer index
		/// of the resulting palette (whether it already existed or is newly-created).
		/// </summary>
		// Token: 0x06001B70 RID: 7024 RVA: 0x0002BB38 File Offset: 0x00029D38
		public virtual void SetColorScheme(int scheme)
		{
			vtkColorSeries.vtkColorSeries_SetColorScheme_22(base.GetCppThis(), scheme);
		}

		// Token: 0x06001B71 RID: 7025
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkColorSeries_SetColorSchemeByName_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string schemeName);

		/// <summary>
		/// Set the color scheme that should be used.
		/// The variant of this function that takes an integer should pass a
		/// number from those in the enum, or a value returned by the string variant.
		/// The variant that accepts a string returns the integer index
		/// of the resulting palette (whether it already existed or is newly-created).
		/// </summary>
		// Token: 0x06001B72 RID: 7026 RVA: 0x0002BB48 File Offset: 0x00029D48
		public virtual int SetColorSchemeByName(string schemeName)
		{
			return vtkColorSeries.vtkColorSeries_SetColorSchemeByName_23(base.GetCppThis(), schemeName);
		}

		// Token: 0x06001B73 RID: 7027
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorSeries_SetColorSchemeName_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set the name of the current color scheme
		/// </summary>
		// Token: 0x06001B74 RID: 7028 RVA: 0x0002BB68 File Offset: 0x00029D68
		public virtual void SetColorSchemeName(string name)
		{
			vtkColorSeries.vtkColorSeries_SetColorSchemeName_24(base.GetCppThis(), name);
		}

		// Token: 0x06001B75 RID: 7029
		[DllImport("Kitware.VTK.CommonColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkColorSeries_SetNumberOfColors_25(HandleRef pThis, int numColors);

		/// <summary>
		/// Set the number of colors to be stored in a non-default color scheme.
		/// Calling this function on a predefined color scheme will cause the scheme
		/// to be duplicated to a new custom scheme.
		/// </summary>
		// Token: 0x06001B76 RID: 7030 RVA: 0x0002BB78 File Offset: 0x00029D78
		public virtual void SetNumberOfColors(int numColors)
		{
			vtkColorSeries.vtkColorSeries_SetNumberOfColors_25(base.GetCppThis(), numColors);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040004B6 RID: 1206
		public new const string MRFullTypeName = "Kitware.VTK.vtkColorSeries";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040004B7 RID: 1207
		public new static readonly string MRClassNameKey = "class vtkColorSeries";

		/// <summary>
		/// Enum of the available color schemes
		/// </summary>
		// Token: 0x0200008D RID: 141
		public enum ColorSchemes
		{
			/// <summary>enum member</summary>
			// Token: 0x040004B9 RID: 1209
			BLUES = 3,
			/// <summary>enum member</summary>
			// Token: 0x040004BA RID: 1210
			BREWER_DIVERGING_BROWN_BLUE_GREEN_10 = 25,
			/// <summary>enum member</summary>
			// Token: 0x040004BB RID: 1211
			BREWER_DIVERGING_BROWN_BLUE_GREEN_11 = 24,
			/// <summary>enum member</summary>
			// Token: 0x040004BC RID: 1212
			BREWER_DIVERGING_BROWN_BLUE_GREEN_3 = 32,
			/// <summary>enum member</summary>
			// Token: 0x040004BD RID: 1213
			BREWER_DIVERGING_BROWN_BLUE_GREEN_4 = 31,
			/// <summary>enum member</summary>
			// Token: 0x040004BE RID: 1214
			BREWER_DIVERGING_BROWN_BLUE_GREEN_5 = 30,
			/// <summary>enum member</summary>
			// Token: 0x040004BF RID: 1215
			BREWER_DIVERGING_BROWN_BLUE_GREEN_6 = 29,
			/// <summary>enum member</summary>
			// Token: 0x040004C0 RID: 1216
			BREWER_DIVERGING_BROWN_BLUE_GREEN_7 = 28,
			/// <summary>enum member</summary>
			// Token: 0x040004C1 RID: 1217
			BREWER_DIVERGING_BROWN_BLUE_GREEN_8 = 27,
			/// <summary>enum member</summary>
			// Token: 0x040004C2 RID: 1218
			BREWER_DIVERGING_BROWN_BLUE_GREEN_9 = 26,
			/// <summary>enum member</summary>
			// Token: 0x040004C3 RID: 1219
			BREWER_DIVERGING_PURPLE_ORANGE_10 = 7,
			/// <summary>enum member</summary>
			// Token: 0x040004C4 RID: 1220
			BREWER_DIVERGING_PURPLE_ORANGE_11 = 6,
			/// <summary>enum member</summary>
			// Token: 0x040004C5 RID: 1221
			BREWER_DIVERGING_PURPLE_ORANGE_3 = 14,
			/// <summary>enum member</summary>
			// Token: 0x040004C6 RID: 1222
			BREWER_DIVERGING_PURPLE_ORANGE_4 = 13,
			/// <summary>enum member</summary>
			// Token: 0x040004C7 RID: 1223
			BREWER_DIVERGING_PURPLE_ORANGE_5 = 12,
			/// <summary>enum member</summary>
			// Token: 0x040004C8 RID: 1224
			BREWER_DIVERGING_PURPLE_ORANGE_6 = 11,
			/// <summary>enum member</summary>
			// Token: 0x040004C9 RID: 1225
			BREWER_DIVERGING_PURPLE_ORANGE_7 = 10,
			/// <summary>enum member</summary>
			// Token: 0x040004CA RID: 1226
			BREWER_DIVERGING_PURPLE_ORANGE_8 = 9,
			/// <summary>enum member</summary>
			// Token: 0x040004CB RID: 1227
			BREWER_DIVERGING_PURPLE_ORANGE_9 = 8,
			/// <summary>enum member</summary>
			// Token: 0x040004CC RID: 1228
			BREWER_DIVERGING_SPECTRAL_10 = 16,
			/// <summary>enum member</summary>
			// Token: 0x040004CD RID: 1229
			BREWER_DIVERGING_SPECTRAL_11 = 15,
			/// <summary>enum member</summary>
			// Token: 0x040004CE RID: 1230
			BREWER_DIVERGING_SPECTRAL_3 = 23,
			/// <summary>enum member</summary>
			// Token: 0x040004CF RID: 1231
			BREWER_DIVERGING_SPECTRAL_4 = 22,
			/// <summary>enum member</summary>
			// Token: 0x040004D0 RID: 1232
			BREWER_DIVERGING_SPECTRAL_5 = 21,
			/// <summary>enum member</summary>
			// Token: 0x040004D1 RID: 1233
			BREWER_DIVERGING_SPECTRAL_6 = 20,
			/// <summary>enum member</summary>
			// Token: 0x040004D2 RID: 1234
			BREWER_DIVERGING_SPECTRAL_7 = 19,
			/// <summary>enum member</summary>
			// Token: 0x040004D3 RID: 1235
			BREWER_DIVERGING_SPECTRAL_8 = 18,
			/// <summary>enum member</summary>
			// Token: 0x040004D4 RID: 1236
			BREWER_DIVERGING_SPECTRAL_9 = 17,
			/// <summary>enum member</summary>
			// Token: 0x040004D5 RID: 1237
			BREWER_QUALITATIVE_ACCENT = 54,
			/// <summary>enum member</summary>
			// Token: 0x040004D6 RID: 1238
			BREWER_QUALITATIVE_DARK2,
			/// <summary>enum member</summary>
			// Token: 0x040004D7 RID: 1239
			BREWER_QUALITATIVE_PAIRED = 60,
			/// <summary>enum member</summary>
			// Token: 0x040004D8 RID: 1240
			BREWER_QUALITATIVE_PASTEL1 = 58,
			/// <summary>enum member</summary>
			// Token: 0x040004D9 RID: 1241
			BREWER_QUALITATIVE_PASTEL2 = 57,
			/// <summary>enum member</summary>
			// Token: 0x040004DA RID: 1242
			BREWER_QUALITATIVE_SET1 = 59,
			/// <summary>enum member</summary>
			// Token: 0x040004DB RID: 1243
			BREWER_QUALITATIVE_SET2 = 56,
			/// <summary>enum member</summary>
			// Token: 0x040004DC RID: 1244
			BREWER_QUALITATIVE_SET3 = 61,
			/// <summary>enum member</summary>
			// Token: 0x040004DD RID: 1245
			BREWER_SEQUENTIAL_BLUE_GREEN_3 = 39,
			/// <summary>enum member</summary>
			// Token: 0x040004DE RID: 1246
			BREWER_SEQUENTIAL_BLUE_GREEN_4 = 38,
			/// <summary>enum member</summary>
			// Token: 0x040004DF RID: 1247
			BREWER_SEQUENTIAL_BLUE_GREEN_5 = 37,
			/// <summary>enum member</summary>
			// Token: 0x040004E0 RID: 1248
			BREWER_SEQUENTIAL_BLUE_GREEN_6 = 36,
			/// <summary>enum member</summary>
			// Token: 0x040004E1 RID: 1249
			BREWER_SEQUENTIAL_BLUE_GREEN_7 = 35,
			/// <summary>enum member</summary>
			// Token: 0x040004E2 RID: 1250
			BREWER_SEQUENTIAL_BLUE_GREEN_8 = 34,
			/// <summary>enum member</summary>
			// Token: 0x040004E3 RID: 1251
			BREWER_SEQUENTIAL_BLUE_GREEN_9 = 33,
			/// <summary>enum member</summary>
			// Token: 0x040004E4 RID: 1252
			BREWER_SEQUENTIAL_BLUE_PURPLE_3 = 53,
			/// <summary>enum member</summary>
			// Token: 0x040004E5 RID: 1253
			BREWER_SEQUENTIAL_BLUE_PURPLE_4 = 52,
			/// <summary>enum member</summary>
			// Token: 0x040004E6 RID: 1254
			BREWER_SEQUENTIAL_BLUE_PURPLE_5 = 51,
			/// <summary>enum member</summary>
			// Token: 0x040004E7 RID: 1255
			BREWER_SEQUENTIAL_BLUE_PURPLE_6 = 50,
			/// <summary>enum member</summary>
			// Token: 0x040004E8 RID: 1256
			BREWER_SEQUENTIAL_BLUE_PURPLE_7 = 49,
			/// <summary>enum member</summary>
			// Token: 0x040004E9 RID: 1257
			BREWER_SEQUENTIAL_BLUE_PURPLE_8 = 48,
			/// <summary>enum member</summary>
			// Token: 0x040004EA RID: 1258
			BREWER_SEQUENTIAL_BLUE_PURPLE_9 = 47,
			/// <summary>enum member</summary>
			// Token: 0x040004EB RID: 1259
			BREWER_SEQUENTIAL_YELLOW_ORANGE_BROWN_3 = 46,
			/// <summary>enum member</summary>
			// Token: 0x040004EC RID: 1260
			BREWER_SEQUENTIAL_YELLOW_ORANGE_BROWN_4 = 45,
			/// <summary>enum member</summary>
			// Token: 0x040004ED RID: 1261
			BREWER_SEQUENTIAL_YELLOW_ORANGE_BROWN_5 = 44,
			/// <summary>enum member</summary>
			// Token: 0x040004EE RID: 1262
			BREWER_SEQUENTIAL_YELLOW_ORANGE_BROWN_6 = 43,
			/// <summary>enum member</summary>
			// Token: 0x040004EF RID: 1263
			BREWER_SEQUENTIAL_YELLOW_ORANGE_BROWN_7 = 42,
			/// <summary>enum member</summary>
			// Token: 0x040004F0 RID: 1264
			BREWER_SEQUENTIAL_YELLOW_ORANGE_BROWN_8 = 41,
			/// <summary>enum member</summary>
			// Token: 0x040004F1 RID: 1265
			BREWER_SEQUENTIAL_YELLOW_ORANGE_BROWN_9 = 40,
			/// <summary>enum member</summary>
			// Token: 0x040004F2 RID: 1266
			CITRUS = 5,
			/// <summary>enum member</summary>
			// Token: 0x040004F3 RID: 1267
			COOL = 2,
			/// <summary>enum member</summary>
			// Token: 0x040004F4 RID: 1268
			CUSTOM = 62,
			/// <summary>enum member</summary>
			// Token: 0x040004F5 RID: 1269
			SPECTRUM = 0,
			/// <summary>enum member</summary>
			// Token: 0x040004F6 RID: 1270
			WARM,
			/// <summary>enum member</summary>
			// Token: 0x040004F7 RID: 1271
			WILD_FLOWER = 4
		}

		/// <summary>
		/// An enum defining how lookup tables should be used: either as a
		/// list of discrete colors to choose from (categorical), or as an
		/// ordered list of color set - points to interpolate among (ordinal).
		/// </summary>
		// Token: 0x0200008E RID: 142
		public enum LUTMode
		{
			/// <summary>enum member</summary>
			// Token: 0x040004F9 RID: 1273
			CATEGORICAL = 1,
			/// <summary>enum member</summary>
			// Token: 0x040004FA RID: 1274
			ORDINAL = 0
		}
	}
}
