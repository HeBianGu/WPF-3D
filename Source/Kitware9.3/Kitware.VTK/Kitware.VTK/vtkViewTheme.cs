using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkViewTheme
	/// </summary>
	/// <remarks>
	///    Sets theme colors for a graphical view.
	///
	///
	/// This may be set on any subclass of vtkView.  The view class will attempt
	/// to use the values set in the theme to customize the view.  Views will not
	/// generally use every aspect of the theme.
	/// NOTICE: This class will be deprecated in favor of a more robust
	/// solution based on style sheets.  Do not become overly-dependent on the
	/// functionality of themes.
	/// </remarks>
	// Token: 0x020002A8 RID: 680
	public class vtkViewTheme : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007A3A RID: 31290 RVA: 0x000B04C7 File Offset: 0x000AE6C7
		static vtkViewTheme()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkViewTheme.MRClassNameKey, Type.GetType("Kitware.VTK.vtkViewTheme"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007A3B RID: 31291 RVA: 0x000B04EF File Offset: 0x000AE6EF
		public vtkViewTheme(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007A3C RID: 31292
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewTheme_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007A3D RID: 31293 RVA: 0x000B0500 File Offset: 0x000AE700
		public new static vtkViewTheme New()
		{
			vtkViewTheme result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkViewTheme)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007A3E RID: 31294 RVA: 0x000B0554 File Offset: 0x000AE754
		public vtkViewTheme() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkViewTheme.vtkViewTheme_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007A3F RID: 31295 RVA: 0x000B0598 File Offset: 0x000AE798
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007A40 RID: 31296
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewTheme_CreateMellowTheme_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Convenience methods for creating some default view themes.
		/// The return reference is reference-counted, so you will have to call
		/// Delete() on the reference when you are finished with it.
		/// </summary>
		// Token: 0x06007A41 RID: 31297 RVA: 0x000B05A4 File Offset: 0x000AE7A4
		public static vtkViewTheme CreateMellowTheme()
		{
			vtkViewTheme vtkViewTheme = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_CreateMellowTheme_01(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkViewTheme = (vtkViewTheme)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkViewTheme.Register(null);
				}
			}
			return vtkViewTheme;
		}

		// Token: 0x06007A42 RID: 31298
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewTheme_CreateNeonTheme_02(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Convenience methods for creating some default view themes.
		/// The return reference is reference-counted, so you will have to call
		/// Delete() on the reference when you are finished with it.
		/// </summary>
		// Token: 0x06007A43 RID: 31299 RVA: 0x000B0610 File Offset: 0x000AE810
		public static vtkViewTheme CreateNeonTheme()
		{
			vtkViewTheme vtkViewTheme = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_CreateNeonTheme_02(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkViewTheme = (vtkViewTheme)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkViewTheme.Register(null);
				}
			}
			return vtkViewTheme;
		}

		// Token: 0x06007A44 RID: 31300
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewTheme_CreateOceanTheme_03(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Convenience methods for creating some default view themes.
		/// The return reference is reference-counted, so you will have to call
		/// Delete() on the reference when you are finished with it.
		/// </summary>
		// Token: 0x06007A45 RID: 31301 RVA: 0x000B067C File Offset: 0x000AE87C
		public static vtkViewTheme CreateOceanTheme()
		{
			vtkViewTheme vtkViewTheme = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_CreateOceanTheme_03(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkViewTheme = (vtkViewTheme)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkViewTheme.Register(null);
				}
			}
			return vtkViewTheme;
		}

		// Token: 0x06007A46 RID: 31302
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewTheme_GetBackgroundColor_04(HandleRef pThis);

		/// <summary>
		/// The view background color.
		/// </summary>
		// Token: 0x06007A47 RID: 31303 RVA: 0x000B06E8 File Offset: 0x000AE8E8
		public virtual double[] GetBackgroundColor()
		{
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_GetBackgroundColor_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06007A48 RID: 31304
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetBackgroundColor_05(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// The view background color.
		/// </summary>
		// Token: 0x06007A49 RID: 31305 RVA: 0x000B0730 File Offset: 0x000AE930
		public virtual void GetBackgroundColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkViewTheme.vtkViewTheme_GetBackgroundColor_05(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06007A4A RID: 31306
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetBackgroundColor_06(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The view background color.
		/// </summary>
		// Token: 0x06007A4B RID: 31307 RVA: 0x000B0742 File Offset: 0x000AE942
		public virtual void GetBackgroundColor(IntPtr _arg)
		{
			vtkViewTheme.vtkViewTheme_GetBackgroundColor_06(base.GetCppThis(), _arg);
		}

		// Token: 0x06007A4C RID: 31308
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewTheme_GetBackgroundColor2_07(HandleRef pThis);

		/// <summary>
		/// The second background color (for gradients).
		/// </summary>
		// Token: 0x06007A4D RID: 31309 RVA: 0x000B0754 File Offset: 0x000AE954
		public virtual double[] GetBackgroundColor2()
		{
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_GetBackgroundColor2_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06007A4E RID: 31310
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetBackgroundColor2_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// The second background color (for gradients).
		/// </summary>
		// Token: 0x06007A4F RID: 31311 RVA: 0x000B079C File Offset: 0x000AE99C
		public virtual void GetBackgroundColor2(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkViewTheme.vtkViewTheme_GetBackgroundColor2_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06007A50 RID: 31312
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetBackgroundColor2_09(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The second background color (for gradients).
		/// </summary>
		// Token: 0x06007A51 RID: 31313 RVA: 0x000B07AE File Offset: 0x000AE9AE
		public virtual void GetBackgroundColor2(IntPtr _arg)
		{
			vtkViewTheme.vtkViewTheme_GetBackgroundColor2_09(base.GetCppThis(), _arg);
		}

		// Token: 0x06007A52 RID: 31314
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewTheme_GetCellAlphaRange_10(HandleRef pThis);

		/// <summary>
		/// The ranges to use in the cell lookup table.
		/// You may also do this by accessing the cell lookup table directly
		/// with GetCellLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007A53 RID: 31315 RVA: 0x000B07C0 File Offset: 0x000AE9C0
		public virtual IntPtr GetCellAlphaRange()
		{
			return vtkViewTheme.vtkViewTheme_GetCellAlphaRange_10(base.GetCppThis());
		}

		// Token: 0x06007A54 RID: 31316
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetCellAlphaRange_11(HandleRef pThis, ref double mn, ref double mx);

		/// <summary>
		/// The ranges to use in the cell lookup table.
		/// You may also do this by accessing the cell lookup table directly
		/// with GetCellLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007A55 RID: 31317 RVA: 0x000B07DF File Offset: 0x000AE9DF
		public virtual void GetCellAlphaRange(ref double mn, ref double mx)
		{
			vtkViewTheme.vtkViewTheme_GetCellAlphaRange_11(base.GetCppThis(), ref mn, ref mx);
		}

		// Token: 0x06007A56 RID: 31318
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetCellAlphaRange_12(HandleRef pThis, IntPtr rng);

		/// <summary>
		/// The ranges to use in the cell lookup table.
		/// You may also do this by accessing the cell lookup table directly
		/// with GetCellLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007A57 RID: 31319 RVA: 0x000B07F0 File Offset: 0x000AE9F0
		public virtual void GetCellAlphaRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_GetCellAlphaRange_12(base.GetCppThis(), rng);
		}

		// Token: 0x06007A58 RID: 31320
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewTheme_GetCellColor_13(HandleRef pThis);

		/// <summary>
		/// The color and opacity of cells or edges when not mapped through
		/// a lookup table.
		/// </summary>
		// Token: 0x06007A59 RID: 31321 RVA: 0x000B0800 File Offset: 0x000AEA00
		public virtual double[] GetCellColor()
		{
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_GetCellColor_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06007A5A RID: 31322
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetCellColor_14(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// The color and opacity of cells or edges when not mapped through
		/// a lookup table.
		/// </summary>
		// Token: 0x06007A5B RID: 31323 RVA: 0x000B0848 File Offset: 0x000AEA48
		public virtual void GetCellColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkViewTheme.vtkViewTheme_GetCellColor_14(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06007A5C RID: 31324
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetCellColor_15(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The color and opacity of cells or edges when not mapped through
		/// a lookup table.
		/// </summary>
		// Token: 0x06007A5D RID: 31325 RVA: 0x000B085A File Offset: 0x000AEA5A
		public virtual void GetCellColor(IntPtr _arg)
		{
			vtkViewTheme.vtkViewTheme_GetCellColor_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06007A5E RID: 31326
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewTheme_GetCellHueRange_16(HandleRef pThis);

		/// <summary>
		/// The ranges to use in the cell lookup table.
		/// You may also do this by accessing the cell lookup table directly
		/// with GetCellLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007A5F RID: 31327 RVA: 0x000B086C File Offset: 0x000AEA6C
		public virtual IntPtr GetCellHueRange()
		{
			return vtkViewTheme.vtkViewTheme_GetCellHueRange_16(base.GetCppThis());
		}

		// Token: 0x06007A60 RID: 31328
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetCellHueRange_17(HandleRef pThis, ref double mn, ref double mx);

		/// <summary>
		/// The ranges to use in the cell lookup table.
		/// You may also do this by accessing the cell lookup table directly
		/// with GetCellLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007A61 RID: 31329 RVA: 0x000B088B File Offset: 0x000AEA8B
		public virtual void GetCellHueRange(ref double mn, ref double mx)
		{
			vtkViewTheme.vtkViewTheme_GetCellHueRange_17(base.GetCppThis(), ref mn, ref mx);
		}

		// Token: 0x06007A62 RID: 31330
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetCellHueRange_18(HandleRef pThis, IntPtr rng);

		/// <summary>
		/// The ranges to use in the cell lookup table.
		/// You may also do this by accessing the cell lookup table directly
		/// with GetCellLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007A63 RID: 31331 RVA: 0x000B089C File Offset: 0x000AEA9C
		public virtual void GetCellHueRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_GetCellHueRange_18(base.GetCppThis(), rng);
		}

		// Token: 0x06007A64 RID: 31332
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewTheme_GetCellLookupTable_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the cell lookup table.
		/// </summary>
		// Token: 0x06007A65 RID: 31333 RVA: 0x000B08AC File Offset: 0x000AEAAC
		public virtual vtkScalarsToColors GetCellLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_GetCellLookupTable_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06007A66 RID: 31334
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkViewTheme_GetCellOpacity_20(HandleRef pThis);

		/// <summary>
		/// The color and opacity of cells or edges when not mapped through
		/// a lookup table.
		/// </summary>
		// Token: 0x06007A67 RID: 31335 RVA: 0x000B091C File Offset: 0x000AEB1C
		public virtual double GetCellOpacity()
		{
			return vtkViewTheme.vtkViewTheme_GetCellOpacity_20(base.GetCppThis());
		}

		// Token: 0x06007A68 RID: 31336
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewTheme_GetCellSaturationRange_21(HandleRef pThis);

		/// <summary>
		/// The ranges to use in the cell lookup table.
		/// You may also do this by accessing the cell lookup table directly
		/// with GetCellLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007A69 RID: 31337 RVA: 0x000B093C File Offset: 0x000AEB3C
		public virtual IntPtr GetCellSaturationRange()
		{
			return vtkViewTheme.vtkViewTheme_GetCellSaturationRange_21(base.GetCppThis());
		}

		// Token: 0x06007A6A RID: 31338
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetCellSaturationRange_22(HandleRef pThis, ref double mn, ref double mx);

		/// <summary>
		/// The ranges to use in the cell lookup table.
		/// You may also do this by accessing the cell lookup table directly
		/// with GetCellLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007A6B RID: 31339 RVA: 0x000B095B File Offset: 0x000AEB5B
		public virtual void GetCellSaturationRange(ref double mn, ref double mx)
		{
			vtkViewTheme.vtkViewTheme_GetCellSaturationRange_22(base.GetCppThis(), ref mn, ref mx);
		}

		// Token: 0x06007A6C RID: 31340
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetCellSaturationRange_23(HandleRef pThis, IntPtr rng);

		/// <summary>
		/// The ranges to use in the cell lookup table.
		/// You may also do this by accessing the cell lookup table directly
		/// with GetCellLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007A6D RID: 31341 RVA: 0x000B096C File Offset: 0x000AEB6C
		public virtual void GetCellSaturationRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_GetCellSaturationRange_23(base.GetCppThis(), rng);
		}

		// Token: 0x06007A6E RID: 31342
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewTheme_GetCellTextProperty_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The text property to use for labeling edges/cells.
		/// </summary>
		// Token: 0x06007A6F RID: 31343 RVA: 0x000B097C File Offset: 0x000AEB7C
		public virtual vtkTextProperty GetCellTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_GetCellTextProperty_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06007A70 RID: 31344
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewTheme_GetCellValueRange_25(HandleRef pThis);

		/// <summary>
		/// The ranges to use in the cell lookup table.
		/// You may also do this by accessing the cell lookup table directly
		/// with GetCellLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007A71 RID: 31345 RVA: 0x000B09EC File Offset: 0x000AEBEC
		public virtual IntPtr GetCellValueRange()
		{
			return vtkViewTheme.vtkViewTheme_GetCellValueRange_25(base.GetCppThis());
		}

		// Token: 0x06007A72 RID: 31346
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetCellValueRange_26(HandleRef pThis, ref double mn, ref double mx);

		/// <summary>
		/// The ranges to use in the cell lookup table.
		/// You may also do this by accessing the cell lookup table directly
		/// with GetCellLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007A73 RID: 31347 RVA: 0x000B0A0B File Offset: 0x000AEC0B
		public virtual void GetCellValueRange(ref double mn, ref double mx)
		{
			vtkViewTheme.vtkViewTheme_GetCellValueRange_26(base.GetCppThis(), ref mn, ref mx);
		}

		// Token: 0x06007A74 RID: 31348
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetCellValueRange_27(HandleRef pThis, IntPtr rng);

		/// <summary>
		/// The ranges to use in the cell lookup table.
		/// You may also do this by accessing the cell lookup table directly
		/// with GetCellLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007A75 RID: 31349 RVA: 0x000B0A1C File Offset: 0x000AEC1C
		public virtual void GetCellValueRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_GetCellValueRange_27(base.GetCppThis(), rng);
		}

		// Token: 0x06007A76 RID: 31350
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewTheme_GetEdgeLabelColor_28(HandleRef pThis);

		/// <summary>
		/// The color to use for labeling graph edges.
		/// This is deprecated. Use GetCellTextProperty()-&gt;SetColor() instead.
		/// </summary>
		// Token: 0x06007A77 RID: 31351 RVA: 0x000B0A2C File Offset: 0x000AEC2C
		public virtual IntPtr GetEdgeLabelColor()
		{
			return vtkViewTheme.vtkViewTheme_GetEdgeLabelColor_28(base.GetCppThis());
		}

		// Token: 0x06007A78 RID: 31352
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetEdgeLabelColor_29(HandleRef pThis, ref double r, ref double g, ref double b);

		/// <summary>
		/// The color to use for labeling graph edges.
		/// This is deprecated. Use GetCellTextProperty()-&gt;SetColor() instead.
		/// </summary>
		// Token: 0x06007A79 RID: 31353 RVA: 0x000B0A4B File Offset: 0x000AEC4B
		public virtual void GetEdgeLabelColor(ref double r, ref double g, ref double b)
		{
			vtkViewTheme.vtkViewTheme_GetEdgeLabelColor_29(base.GetCppThis(), ref r, ref g, ref b);
		}

		// Token: 0x06007A7A RID: 31354
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetEdgeLabelColor_30(HandleRef pThis, IntPtr c);

		/// <summary>
		/// The color to use for labeling graph edges.
		/// This is deprecated. Use GetCellTextProperty()-&gt;SetColor() instead.
		/// </summary>
		// Token: 0x06007A7B RID: 31355 RVA: 0x000B0A5D File Offset: 0x000AEC5D
		public virtual void GetEdgeLabelColor(IntPtr c)
		{
			vtkViewTheme.vtkViewTheme_GetEdgeLabelColor_30(base.GetCppThis(), c);
		}

		// Token: 0x06007A7C RID: 31356
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkViewTheme_GetLineWidth_31(HandleRef pThis);

		/// <summary>
		/// The width of lines or edges
		/// </summary>
		// Token: 0x06007A7D RID: 31357 RVA: 0x000B0A70 File Offset: 0x000AEC70
		public virtual double GetLineWidth()
		{
			return vtkViewTheme.vtkViewTheme_GetLineWidth_31(base.GetCppThis());
		}

		// Token: 0x06007A7E RID: 31358
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkViewTheme_GetNumberOfGenerationsFromBase_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007A7F RID: 31359 RVA: 0x000B0A90 File Offset: 0x000AEC90
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkViewTheme.vtkViewTheme_GetNumberOfGenerationsFromBase_32(base.GetCppThis(), type);
		}

		// Token: 0x06007A80 RID: 31360
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkViewTheme_GetNumberOfGenerationsFromBaseType_33([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007A81 RID: 31361 RVA: 0x000B0AB0 File Offset: 0x000AECB0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkViewTheme.vtkViewTheme_GetNumberOfGenerationsFromBaseType_33(type);
		}

		// Token: 0x06007A82 RID: 31362
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewTheme_GetOutlineColor_34(HandleRef pThis);

		/// <summary>
		/// The color of any outlines in the view.
		/// </summary>
		// Token: 0x06007A83 RID: 31363 RVA: 0x000B0ACC File Offset: 0x000AECCC
		public virtual double[] GetOutlineColor()
		{
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_GetOutlineColor_34(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06007A84 RID: 31364
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetOutlineColor_35(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// The color of any outlines in the view.
		/// </summary>
		// Token: 0x06007A85 RID: 31365 RVA: 0x000B0B14 File Offset: 0x000AED14
		public virtual void GetOutlineColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkViewTheme.vtkViewTheme_GetOutlineColor_35(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06007A86 RID: 31366
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetOutlineColor_36(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The color of any outlines in the view.
		/// </summary>
		// Token: 0x06007A87 RID: 31367 RVA: 0x000B0B26 File Offset: 0x000AED26
		public virtual void GetOutlineColor(IntPtr _arg)
		{
			vtkViewTheme.vtkViewTheme_GetOutlineColor_36(base.GetCppThis(), _arg);
		}

		// Token: 0x06007A88 RID: 31368
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewTheme_GetPointAlphaRange_37(HandleRef pThis);

		/// <summary>
		/// The ranges to use in the point lookup table.
		/// You may also do this by accessing the point lookup table directly
		/// with GetPointLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007A89 RID: 31369 RVA: 0x000B0B38 File Offset: 0x000AED38
		public virtual IntPtr GetPointAlphaRange()
		{
			return vtkViewTheme.vtkViewTheme_GetPointAlphaRange_37(base.GetCppThis());
		}

		// Token: 0x06007A8A RID: 31370
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetPointAlphaRange_38(HandleRef pThis, ref double mn, ref double mx);

		/// <summary>
		/// The ranges to use in the point lookup table.
		/// You may also do this by accessing the point lookup table directly
		/// with GetPointLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007A8B RID: 31371 RVA: 0x000B0B57 File Offset: 0x000AED57
		public virtual void GetPointAlphaRange(ref double mn, ref double mx)
		{
			vtkViewTheme.vtkViewTheme_GetPointAlphaRange_38(base.GetCppThis(), ref mn, ref mx);
		}

		// Token: 0x06007A8C RID: 31372
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetPointAlphaRange_39(HandleRef pThis, IntPtr rng);

		/// <summary>
		/// The ranges to use in the point lookup table.
		/// You may also do this by accessing the point lookup table directly
		/// with GetPointLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007A8D RID: 31373 RVA: 0x000B0B68 File Offset: 0x000AED68
		public virtual void GetPointAlphaRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_GetPointAlphaRange_39(base.GetCppThis(), rng);
		}

		// Token: 0x06007A8E RID: 31374
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewTheme_GetPointColor_40(HandleRef pThis);

		/// <summary>
		/// The color and opacity of points or vertices when not mapped through
		/// a lookup table.
		/// </summary>
		// Token: 0x06007A8F RID: 31375 RVA: 0x000B0B78 File Offset: 0x000AED78
		public virtual double[] GetPointColor()
		{
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_GetPointColor_40(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06007A90 RID: 31376
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetPointColor_41(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// The color and opacity of points or vertices when not mapped through
		/// a lookup table.
		/// </summary>
		// Token: 0x06007A91 RID: 31377 RVA: 0x000B0BC0 File Offset: 0x000AEDC0
		public virtual void GetPointColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkViewTheme.vtkViewTheme_GetPointColor_41(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06007A92 RID: 31378
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetPointColor_42(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The color and opacity of points or vertices when not mapped through
		/// a lookup table.
		/// </summary>
		// Token: 0x06007A93 RID: 31379 RVA: 0x000B0BD2 File Offset: 0x000AEDD2
		public virtual void GetPointColor(IntPtr _arg)
		{
			vtkViewTheme.vtkViewTheme_GetPointColor_42(base.GetCppThis(), _arg);
		}

		// Token: 0x06007A94 RID: 31380
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewTheme_GetPointHueRange_43(HandleRef pThis);

		/// <summary>
		/// The ranges to use in the point lookup table.
		/// You may also do this by accessing the point lookup table directly
		/// with GetPointLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007A95 RID: 31381 RVA: 0x000B0BE4 File Offset: 0x000AEDE4
		public virtual IntPtr GetPointHueRange()
		{
			return vtkViewTheme.vtkViewTheme_GetPointHueRange_43(base.GetCppThis());
		}

		// Token: 0x06007A96 RID: 31382
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetPointHueRange_44(HandleRef pThis, ref double mn, ref double mx);

		/// <summary>
		/// The ranges to use in the point lookup table.
		/// You may also do this by accessing the point lookup table directly
		/// with GetPointLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007A97 RID: 31383 RVA: 0x000B0C03 File Offset: 0x000AEE03
		public virtual void GetPointHueRange(ref double mn, ref double mx)
		{
			vtkViewTheme.vtkViewTheme_GetPointHueRange_44(base.GetCppThis(), ref mn, ref mx);
		}

		// Token: 0x06007A98 RID: 31384
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetPointHueRange_45(HandleRef pThis, IntPtr rng);

		/// <summary>
		/// The ranges to use in the point lookup table.
		/// You may also do this by accessing the point lookup table directly
		/// with GetPointLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007A99 RID: 31385 RVA: 0x000B0C14 File Offset: 0x000AEE14
		public virtual void GetPointHueRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_GetPointHueRange_45(base.GetCppThis(), rng);
		}

		// Token: 0x06007A9A RID: 31386
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewTheme_GetPointLookupTable_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the point lookup table.
		/// </summary>
		// Token: 0x06007A9B RID: 31387 RVA: 0x000B0C24 File Offset: 0x000AEE24
		public virtual vtkScalarsToColors GetPointLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_GetPointLookupTable_46(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06007A9C RID: 31388
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkViewTheme_GetPointOpacity_47(HandleRef pThis);

		/// <summary>
		/// The color and opacity of points or vertices when not mapped through
		/// a lookup table.
		/// </summary>
		// Token: 0x06007A9D RID: 31389 RVA: 0x000B0C94 File Offset: 0x000AEE94
		public virtual double GetPointOpacity()
		{
			return vtkViewTheme.vtkViewTheme_GetPointOpacity_47(base.GetCppThis());
		}

		// Token: 0x06007A9E RID: 31390
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewTheme_GetPointSaturationRange_48(HandleRef pThis);

		/// <summary>
		/// The ranges to use in the point lookup table.
		/// You may also do this by accessing the point lookup table directly
		/// with GetPointLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007A9F RID: 31391 RVA: 0x000B0CB4 File Offset: 0x000AEEB4
		public virtual IntPtr GetPointSaturationRange()
		{
			return vtkViewTheme.vtkViewTheme_GetPointSaturationRange_48(base.GetCppThis());
		}

		// Token: 0x06007AA0 RID: 31392
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetPointSaturationRange_49(HandleRef pThis, ref double mn, ref double mx);

		/// <summary>
		/// The ranges to use in the point lookup table.
		/// You may also do this by accessing the point lookup table directly
		/// with GetPointLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007AA1 RID: 31393 RVA: 0x000B0CD3 File Offset: 0x000AEED3
		public virtual void GetPointSaturationRange(ref double mn, ref double mx)
		{
			vtkViewTheme.vtkViewTheme_GetPointSaturationRange_49(base.GetCppThis(), ref mn, ref mx);
		}

		// Token: 0x06007AA2 RID: 31394
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetPointSaturationRange_50(HandleRef pThis, IntPtr rng);

		/// <summary>
		/// The ranges to use in the point lookup table.
		/// You may also do this by accessing the point lookup table directly
		/// with GetPointLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007AA3 RID: 31395 RVA: 0x000B0CE4 File Offset: 0x000AEEE4
		public virtual void GetPointSaturationRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_GetPointSaturationRange_50(base.GetCppThis(), rng);
		}

		// Token: 0x06007AA4 RID: 31396
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkViewTheme_GetPointSize_51(HandleRef pThis);

		/// <summary>
		/// The size of points or vertices
		/// </summary>
		// Token: 0x06007AA5 RID: 31397 RVA: 0x000B0CF4 File Offset: 0x000AEEF4
		public virtual double GetPointSize()
		{
			return vtkViewTheme.vtkViewTheme_GetPointSize_51(base.GetCppThis());
		}

		// Token: 0x06007AA6 RID: 31398
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewTheme_GetPointTextProperty_52(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The text property to use for labeling points/vertices.
		/// </summary>
		// Token: 0x06007AA7 RID: 31399 RVA: 0x000B0D14 File Offset: 0x000AEF14
		public virtual vtkTextProperty GetPointTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_GetPointTextProperty_52(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06007AA8 RID: 31400
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewTheme_GetPointValueRange_53(HandleRef pThis);

		/// <summary>
		/// The ranges to use in the point lookup table.
		/// You may also do this by accessing the point lookup table directly
		/// with GetPointLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007AA9 RID: 31401 RVA: 0x000B0D84 File Offset: 0x000AEF84
		public virtual IntPtr GetPointValueRange()
		{
			return vtkViewTheme.vtkViewTheme_GetPointValueRange_53(base.GetCppThis());
		}

		// Token: 0x06007AAA RID: 31402
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetPointValueRange_54(HandleRef pThis, ref double mn, ref double mx);

		/// <summary>
		/// The ranges to use in the point lookup table.
		/// You may also do this by accessing the point lookup table directly
		/// with GetPointLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007AAB RID: 31403 RVA: 0x000B0DA3 File Offset: 0x000AEFA3
		public virtual void GetPointValueRange(ref double mn, ref double mx)
		{
			vtkViewTheme.vtkViewTheme_GetPointValueRange_54(base.GetCppThis(), ref mn, ref mx);
		}

		// Token: 0x06007AAC RID: 31404
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetPointValueRange_55(HandleRef pThis, IntPtr rng);

		/// <summary>
		/// The ranges to use in the point lookup table.
		/// You may also do this by accessing the point lookup table directly
		/// with GetPointLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007AAD RID: 31405 RVA: 0x000B0DB4 File Offset: 0x000AEFB4
		public virtual void GetPointValueRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_GetPointValueRange_55(base.GetCppThis(), rng);
		}

		// Token: 0x06007AAE RID: 31406
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkViewTheme_GetScaleCellLookupTable_56(HandleRef pThis);

		/// <summary>
		/// Whether to scale the lookup table to fit the range of the data.
		/// </summary>
		// Token: 0x06007AAF RID: 31407 RVA: 0x000B0DC4 File Offset: 0x000AEFC4
		public virtual bool GetScaleCellLookupTable()
		{
			return vtkViewTheme.vtkViewTheme_GetScaleCellLookupTable_56(base.GetCppThis()) != 0;
		}

		// Token: 0x06007AB0 RID: 31408
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkViewTheme_GetScalePointLookupTable_57(HandleRef pThis);

		/// <summary>
		/// Whether to scale the lookup table to fit the range of the data.
		/// </summary>
		// Token: 0x06007AB1 RID: 31409 RVA: 0x000B0DEC File Offset: 0x000AEFEC
		public virtual bool GetScalePointLookupTable()
		{
			return vtkViewTheme.vtkViewTheme_GetScalePointLookupTable_57(base.GetCppThis()) != 0;
		}

		// Token: 0x06007AB2 RID: 31410
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewTheme_GetSelectedCellColor_58(HandleRef pThis);

		/// <summary>
		/// The color of selected cells or edges.
		/// </summary>
		// Token: 0x06007AB3 RID: 31411 RVA: 0x000B0E14 File Offset: 0x000AF014
		public virtual double[] GetSelectedCellColor()
		{
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_GetSelectedCellColor_58(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06007AB4 RID: 31412
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetSelectedCellColor_59(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// The color of selected cells or edges.
		/// </summary>
		// Token: 0x06007AB5 RID: 31413 RVA: 0x000B0E5C File Offset: 0x000AF05C
		public virtual void GetSelectedCellColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkViewTheme.vtkViewTheme_GetSelectedCellColor_59(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06007AB6 RID: 31414
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetSelectedCellColor_60(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The color of selected cells or edges.
		/// </summary>
		// Token: 0x06007AB7 RID: 31415 RVA: 0x000B0E6E File Offset: 0x000AF06E
		public virtual void GetSelectedCellColor(IntPtr _arg)
		{
			vtkViewTheme.vtkViewTheme_GetSelectedCellColor_60(base.GetCppThis(), _arg);
		}

		// Token: 0x06007AB8 RID: 31416
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkViewTheme_GetSelectedCellOpacity_61(HandleRef pThis);

		/// <summary>
		/// The color of selected cells or edges.
		/// </summary>
		// Token: 0x06007AB9 RID: 31417 RVA: 0x000B0E80 File Offset: 0x000AF080
		public virtual double GetSelectedCellOpacity()
		{
			return vtkViewTheme.vtkViewTheme_GetSelectedCellOpacity_61(base.GetCppThis());
		}

		// Token: 0x06007ABA RID: 31418
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetSelectedPointColor_62(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// The color of selected points or vertices.
		/// </summary>
		// Token: 0x06007ABB RID: 31419 RVA: 0x000B0E9F File Offset: 0x000AF09F
		public virtual void GetSelectedPointColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkViewTheme.vtkViewTheme_GetSelectedPointColor_62(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06007ABC RID: 31420
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetSelectedPointColor_63(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The color of selected points or vertices.
		/// </summary>
		// Token: 0x06007ABD RID: 31421 RVA: 0x000B0EB1 File Offset: 0x000AF0B1
		public virtual void GetSelectedPointColor(IntPtr _arg)
		{
			vtkViewTheme.vtkViewTheme_GetSelectedPointColor_63(base.GetCppThis(), _arg);
		}

		// Token: 0x06007ABE RID: 31422
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewTheme_GetSelectedPointColor_64(HandleRef pThis);

		/// <summary>
		/// The color of selected points or vertices.
		/// </summary>
		// Token: 0x06007ABF RID: 31423 RVA: 0x000B0EC4 File Offset: 0x000AF0C4
		public virtual double[] GetSelectedPointColor()
		{
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_GetSelectedPointColor_64(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06007AC0 RID: 31424
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkViewTheme_GetSelectedPointOpacity_65(HandleRef pThis);

		/// <summary>
		/// The color of selected points or vertices.
		/// </summary>
		// Token: 0x06007AC1 RID: 31425 RVA: 0x000B0F0C File Offset: 0x000AF10C
		public virtual double GetSelectedPointOpacity()
		{
			return vtkViewTheme.vtkViewTheme_GetSelectedPointOpacity_65(base.GetCppThis());
		}

		// Token: 0x06007AC2 RID: 31426
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewTheme_GetVertexLabelColor_66(HandleRef pThis);

		/// <summary>
		/// The color to use for labeling graph vertices.
		/// This is deprecated. Use GetPointTextProperty()-&gt;SetColor() instead.
		/// </summary>
		// Token: 0x06007AC3 RID: 31427 RVA: 0x000B0F2C File Offset: 0x000AF12C
		public virtual IntPtr GetVertexLabelColor()
		{
			return vtkViewTheme.vtkViewTheme_GetVertexLabelColor_66(base.GetCppThis());
		}

		// Token: 0x06007AC4 RID: 31428
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetVertexLabelColor_67(HandleRef pThis, ref double r, ref double g, ref double b);

		/// <summary>
		/// The color to use for labeling graph vertices.
		/// This is deprecated. Use GetPointTextProperty()-&gt;SetColor() instead.
		/// </summary>
		// Token: 0x06007AC5 RID: 31429 RVA: 0x000B0F4B File Offset: 0x000AF14B
		public virtual void GetVertexLabelColor(ref double r, ref double g, ref double b)
		{
			vtkViewTheme.vtkViewTheme_GetVertexLabelColor_67(base.GetCppThis(), ref r, ref g, ref b);
		}

		// Token: 0x06007AC6 RID: 31430
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_GetVertexLabelColor_68(HandleRef pThis, IntPtr c);

		/// <summary>
		/// The color to use for labeling graph vertices.
		/// This is deprecated. Use GetPointTextProperty()-&gt;SetColor() instead.
		/// </summary>
		// Token: 0x06007AC7 RID: 31431 RVA: 0x000B0F5D File Offset: 0x000AF15D
		public virtual void GetVertexLabelColor(IntPtr c)
		{
			vtkViewTheme.vtkViewTheme_GetVertexLabelColor_68(base.GetCppThis(), c);
		}

		// Token: 0x06007AC8 RID: 31432
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkViewTheme_IsA_69(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007AC9 RID: 31433 RVA: 0x000B0F70 File Offset: 0x000AF170
		public override int IsA(string type)
		{
			return vtkViewTheme.vtkViewTheme_IsA_69(base.GetCppThis(), type);
		}

		// Token: 0x06007ACA RID: 31434
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkViewTheme_IsTypeOf_70([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007ACB RID: 31435 RVA: 0x000B0F90 File Offset: 0x000AF190
		public new static int IsTypeOf(string type)
		{
			return vtkViewTheme.vtkViewTheme_IsTypeOf_70(type);
		}

		// Token: 0x06007ACC RID: 31436
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkViewTheme_LookupMatchesCellTheme_71(HandleRef pThis, HandleRef s2c);

		/// <summary>
		/// Whether a given lookup table matches the point or cell theme of this
		/// theme.
		/// </summary>
		// Token: 0x06007ACD RID: 31437 RVA: 0x000B0FAC File Offset: 0x000AF1AC
		public bool LookupMatchesCellTheme(vtkScalarsToColors s2c)
		{
			return vtkViewTheme.vtkViewTheme_LookupMatchesCellTheme_71(base.GetCppThis(), (s2c == null) ? default(HandleRef) : s2c.GetCppThis()) != 0;
		}

		// Token: 0x06007ACE RID: 31438
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkViewTheme_LookupMatchesPointTheme_72(HandleRef pThis, HandleRef s2c);

		/// <summary>
		/// Whether a given lookup table matches the point or cell theme of this
		/// theme.
		/// </summary>
		// Token: 0x06007ACF RID: 31439 RVA: 0x000B0FE8 File Offset: 0x000AF1E8
		public bool LookupMatchesPointTheme(vtkScalarsToColors s2c)
		{
			return vtkViewTheme.vtkViewTheme_LookupMatchesPointTheme_72(base.GetCppThis(), (s2c == null) ? default(HandleRef) : s2c.GetCppThis()) != 0;
		}

		// Token: 0x06007AD0 RID: 31440
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewTheme_NewInstance_74(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007AD1 RID: 31441 RVA: 0x000B1024 File Offset: 0x000AF224
		public new vtkViewTheme NewInstance()
		{
			vtkViewTheme result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_NewInstance_74(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkViewTheme)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007AD2 RID: 31442
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewTheme_SafeDownCast_75(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007AD3 RID: 31443 RVA: 0x000B1080 File Offset: 0x000AF280
		public new static vtkViewTheme SafeDownCast(vtkObjectBase o)
		{
			vtkViewTheme vtkViewTheme = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewTheme.vtkViewTheme_SafeDownCast_75((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkViewTheme = (vtkViewTheme)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkViewTheme.Register(null);
				}
			}
			return vtkViewTheme;
		}

		// Token: 0x06007AD4 RID: 31444
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_ScaleCellLookupTableOff_76(HandleRef pThis);

		/// <summary>
		/// Whether to scale the lookup table to fit the range of the data.
		/// </summary>
		// Token: 0x06007AD5 RID: 31445 RVA: 0x000B10FF File Offset: 0x000AF2FF
		public virtual void ScaleCellLookupTableOff()
		{
			vtkViewTheme.vtkViewTheme_ScaleCellLookupTableOff_76(base.GetCppThis());
		}

		// Token: 0x06007AD6 RID: 31446
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_ScaleCellLookupTableOn_77(HandleRef pThis);

		/// <summary>
		/// Whether to scale the lookup table to fit the range of the data.
		/// </summary>
		// Token: 0x06007AD7 RID: 31447 RVA: 0x000B110E File Offset: 0x000AF30E
		public virtual void ScaleCellLookupTableOn()
		{
			vtkViewTheme.vtkViewTheme_ScaleCellLookupTableOn_77(base.GetCppThis());
		}

		// Token: 0x06007AD8 RID: 31448
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_ScalePointLookupTableOff_78(HandleRef pThis);

		/// <summary>
		/// Whether to scale the lookup table to fit the range of the data.
		/// </summary>
		// Token: 0x06007AD9 RID: 31449 RVA: 0x000B111D File Offset: 0x000AF31D
		public virtual void ScalePointLookupTableOff()
		{
			vtkViewTheme.vtkViewTheme_ScalePointLookupTableOff_78(base.GetCppThis());
		}

		// Token: 0x06007ADA RID: 31450
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_ScalePointLookupTableOn_79(HandleRef pThis);

		/// <summary>
		/// Whether to scale the lookup table to fit the range of the data.
		/// </summary>
		// Token: 0x06007ADB RID: 31451 RVA: 0x000B112C File Offset: 0x000AF32C
		public virtual void ScalePointLookupTableOn()
		{
			vtkViewTheme.vtkViewTheme_ScalePointLookupTableOn_79(base.GetCppThis());
		}

		// Token: 0x06007ADC RID: 31452
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetBackgroundColor_80(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// The view background color.
		/// </summary>
		// Token: 0x06007ADD RID: 31453 RVA: 0x000B113B File Offset: 0x000AF33B
		public virtual void SetBackgroundColor(double _arg1, double _arg2, double _arg3)
		{
			vtkViewTheme.vtkViewTheme_SetBackgroundColor_80(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06007ADE RID: 31454
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetBackgroundColor_81(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The view background color.
		/// </summary>
		// Token: 0x06007ADF RID: 31455 RVA: 0x000B114D File Offset: 0x000AF34D
		public virtual void SetBackgroundColor(IntPtr _arg)
		{
			vtkViewTheme.vtkViewTheme_SetBackgroundColor_81(base.GetCppThis(), _arg);
		}

		// Token: 0x06007AE0 RID: 31456
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetBackgroundColor2_82(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// The second background color (for gradients).
		/// </summary>
		// Token: 0x06007AE1 RID: 31457 RVA: 0x000B115D File Offset: 0x000AF35D
		public virtual void SetBackgroundColor2(double _arg1, double _arg2, double _arg3)
		{
			vtkViewTheme.vtkViewTheme_SetBackgroundColor2_82(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06007AE2 RID: 31458
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetBackgroundColor2_83(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The second background color (for gradients).
		/// </summary>
		// Token: 0x06007AE3 RID: 31459 RVA: 0x000B116F File Offset: 0x000AF36F
		public virtual void SetBackgroundColor2(IntPtr _arg)
		{
			vtkViewTheme.vtkViewTheme_SetBackgroundColor2_83(base.GetCppThis(), _arg);
		}

		// Token: 0x06007AE4 RID: 31460
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetCellAlphaRange_84(HandleRef pThis, double mn, double mx);

		/// <summary>
		/// The ranges to use in the cell lookup table.
		/// You may also do this by accessing the cell lookup table directly
		/// with GetCellLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007AE5 RID: 31461 RVA: 0x000B117F File Offset: 0x000AF37F
		public virtual void SetCellAlphaRange(double mn, double mx)
		{
			vtkViewTheme.vtkViewTheme_SetCellAlphaRange_84(base.GetCppThis(), mn, mx);
		}

		// Token: 0x06007AE6 RID: 31462
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetCellAlphaRange_85(HandleRef pThis, IntPtr rng);

		/// <summary>
		/// The ranges to use in the cell lookup table.
		/// You may also do this by accessing the cell lookup table directly
		/// with GetCellLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007AE7 RID: 31463 RVA: 0x000B1190 File Offset: 0x000AF390
		public virtual void SetCellAlphaRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_SetCellAlphaRange_85(base.GetCppThis(), rng);
		}

		// Token: 0x06007AE8 RID: 31464
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetCellColor_86(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// The color and opacity of cells or edges when not mapped through
		/// a lookup table.
		/// </summary>
		// Token: 0x06007AE9 RID: 31465 RVA: 0x000B11A0 File Offset: 0x000AF3A0
		public virtual void SetCellColor(double _arg1, double _arg2, double _arg3)
		{
			vtkViewTheme.vtkViewTheme_SetCellColor_86(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06007AEA RID: 31466
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetCellColor_87(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The color and opacity of cells or edges when not mapped through
		/// a lookup table.
		/// </summary>
		// Token: 0x06007AEB RID: 31467 RVA: 0x000B11B2 File Offset: 0x000AF3B2
		public virtual void SetCellColor(IntPtr _arg)
		{
			vtkViewTheme.vtkViewTheme_SetCellColor_87(base.GetCppThis(), _arg);
		}

		// Token: 0x06007AEC RID: 31468
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetCellHueRange_88(HandleRef pThis, double mn, double mx);

		/// <summary>
		/// The ranges to use in the cell lookup table.
		/// You may also do this by accessing the cell lookup table directly
		/// with GetCellLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007AED RID: 31469 RVA: 0x000B11C2 File Offset: 0x000AF3C2
		public virtual void SetCellHueRange(double mn, double mx)
		{
			vtkViewTheme.vtkViewTheme_SetCellHueRange_88(base.GetCppThis(), mn, mx);
		}

		// Token: 0x06007AEE RID: 31470
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetCellHueRange_89(HandleRef pThis, IntPtr rng);

		/// <summary>
		/// The ranges to use in the cell lookup table.
		/// You may also do this by accessing the cell lookup table directly
		/// with GetCellLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007AEF RID: 31471 RVA: 0x000B11D3 File Offset: 0x000AF3D3
		public virtual void SetCellHueRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_SetCellHueRange_89(base.GetCppThis(), rng);
		}

		// Token: 0x06007AF0 RID: 31472
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetCellLookupTable_90(HandleRef pThis, HandleRef lut);

		/// <summary>
		/// Set/Get the cell lookup table.
		/// </summary>
		// Token: 0x06007AF1 RID: 31473 RVA: 0x000B11E4 File Offset: 0x000AF3E4
		public virtual void SetCellLookupTable(vtkScalarsToColors lut)
		{
			vtkViewTheme.vtkViewTheme_SetCellLookupTable_90(base.GetCppThis(), (lut == null) ? default(HandleRef) : lut.GetCppThis());
		}

		// Token: 0x06007AF2 RID: 31474
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetCellOpacity_91(HandleRef pThis, double _arg);

		/// <summary>
		/// The color and opacity of cells or edges when not mapped through
		/// a lookup table.
		/// </summary>
		// Token: 0x06007AF3 RID: 31475 RVA: 0x000B1213 File Offset: 0x000AF413
		public virtual void SetCellOpacity(double _arg)
		{
			vtkViewTheme.vtkViewTheme_SetCellOpacity_91(base.GetCppThis(), _arg);
		}

		// Token: 0x06007AF4 RID: 31476
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetCellSaturationRange_92(HandleRef pThis, double mn, double mx);

		/// <summary>
		/// The ranges to use in the cell lookup table.
		/// You may also do this by accessing the cell lookup table directly
		/// with GetCellLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007AF5 RID: 31477 RVA: 0x000B1223 File Offset: 0x000AF423
		public virtual void SetCellSaturationRange(double mn, double mx)
		{
			vtkViewTheme.vtkViewTheme_SetCellSaturationRange_92(base.GetCppThis(), mn, mx);
		}

		// Token: 0x06007AF6 RID: 31478
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetCellSaturationRange_93(HandleRef pThis, IntPtr rng);

		/// <summary>
		/// The ranges to use in the cell lookup table.
		/// You may also do this by accessing the cell lookup table directly
		/// with GetCellLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007AF7 RID: 31479 RVA: 0x000B1234 File Offset: 0x000AF434
		public virtual void SetCellSaturationRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_SetCellSaturationRange_93(base.GetCppThis(), rng);
		}

		// Token: 0x06007AF8 RID: 31480
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetCellTextProperty_94(HandleRef pThis, HandleRef tprop);

		/// <summary>
		/// The text property to use for labeling edges/cells.
		/// </summary>
		// Token: 0x06007AF9 RID: 31481 RVA: 0x000B1244 File Offset: 0x000AF444
		public virtual void SetCellTextProperty(vtkTextProperty tprop)
		{
			vtkViewTheme.vtkViewTheme_SetCellTextProperty_94(base.GetCppThis(), (tprop == null) ? default(HandleRef) : tprop.GetCppThis());
		}

		// Token: 0x06007AFA RID: 31482
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetCellValueRange_95(HandleRef pThis, double mn, double mx);

		/// <summary>
		/// The ranges to use in the cell lookup table.
		/// You may also do this by accessing the cell lookup table directly
		/// with GetCellLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007AFB RID: 31483 RVA: 0x000B1273 File Offset: 0x000AF473
		public virtual void SetCellValueRange(double mn, double mx)
		{
			vtkViewTheme.vtkViewTheme_SetCellValueRange_95(base.GetCppThis(), mn, mx);
		}

		// Token: 0x06007AFC RID: 31484
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetCellValueRange_96(HandleRef pThis, IntPtr rng);

		/// <summary>
		/// The ranges to use in the cell lookup table.
		/// You may also do this by accessing the cell lookup table directly
		/// with GetCellLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007AFD RID: 31485 RVA: 0x000B1284 File Offset: 0x000AF484
		public virtual void SetCellValueRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_SetCellValueRange_96(base.GetCppThis(), rng);
		}

		// Token: 0x06007AFE RID: 31486
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetEdgeLabelColor_97(HandleRef pThis, double r, double g, double b);

		/// <summary>
		/// The color to use for labeling graph edges.
		/// This is deprecated. Use GetCellTextProperty()-&gt;SetColor() instead.
		/// </summary>
		// Token: 0x06007AFF RID: 31487 RVA: 0x000B1294 File Offset: 0x000AF494
		public virtual void SetEdgeLabelColor(double r, double g, double b)
		{
			vtkViewTheme.vtkViewTheme_SetEdgeLabelColor_97(base.GetCppThis(), r, g, b);
		}

		// Token: 0x06007B00 RID: 31488
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetEdgeLabelColor_98(HandleRef pThis, IntPtr c);

		/// <summary>
		/// The color to use for labeling graph edges.
		/// This is deprecated. Use GetCellTextProperty()-&gt;SetColor() instead.
		/// </summary>
		// Token: 0x06007B01 RID: 31489 RVA: 0x000B12A6 File Offset: 0x000AF4A6
		public virtual void SetEdgeLabelColor(IntPtr c)
		{
			vtkViewTheme.vtkViewTheme_SetEdgeLabelColor_98(base.GetCppThis(), c);
		}

		// Token: 0x06007B02 RID: 31490
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetLineWidth_99(HandleRef pThis, double _arg);

		/// <summary>
		/// The width of lines or edges
		/// </summary>
		// Token: 0x06007B03 RID: 31491 RVA: 0x000B12B6 File Offset: 0x000AF4B6
		public virtual void SetLineWidth(double _arg)
		{
			vtkViewTheme.vtkViewTheme_SetLineWidth_99(base.GetCppThis(), _arg);
		}

		// Token: 0x06007B04 RID: 31492
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetOutlineColor_100(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// The color of any outlines in the view.
		/// </summary>
		// Token: 0x06007B05 RID: 31493 RVA: 0x000B12C6 File Offset: 0x000AF4C6
		public virtual void SetOutlineColor(double _arg1, double _arg2, double _arg3)
		{
			vtkViewTheme.vtkViewTheme_SetOutlineColor_100(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06007B06 RID: 31494
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetOutlineColor_101(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The color of any outlines in the view.
		/// </summary>
		// Token: 0x06007B07 RID: 31495 RVA: 0x000B12D8 File Offset: 0x000AF4D8
		public virtual void SetOutlineColor(IntPtr _arg)
		{
			vtkViewTheme.vtkViewTheme_SetOutlineColor_101(base.GetCppThis(), _arg);
		}

		// Token: 0x06007B08 RID: 31496
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetPointAlphaRange_102(HandleRef pThis, double mn, double mx);

		/// <summary>
		/// The ranges to use in the point lookup table.
		/// You may also do this by accessing the point lookup table directly
		/// with GetPointLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007B09 RID: 31497 RVA: 0x000B12E8 File Offset: 0x000AF4E8
		public virtual void SetPointAlphaRange(double mn, double mx)
		{
			vtkViewTheme.vtkViewTheme_SetPointAlphaRange_102(base.GetCppThis(), mn, mx);
		}

		// Token: 0x06007B0A RID: 31498
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetPointAlphaRange_103(HandleRef pThis, IntPtr rng);

		/// <summary>
		/// The ranges to use in the point lookup table.
		/// You may also do this by accessing the point lookup table directly
		/// with GetPointLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007B0B RID: 31499 RVA: 0x000B12F9 File Offset: 0x000AF4F9
		public virtual void SetPointAlphaRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_SetPointAlphaRange_103(base.GetCppThis(), rng);
		}

		// Token: 0x06007B0C RID: 31500
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetPointColor_104(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// The color and opacity of points or vertices when not mapped through
		/// a lookup table.
		/// </summary>
		// Token: 0x06007B0D RID: 31501 RVA: 0x000B1309 File Offset: 0x000AF509
		public virtual void SetPointColor(double _arg1, double _arg2, double _arg3)
		{
			vtkViewTheme.vtkViewTheme_SetPointColor_104(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06007B0E RID: 31502
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetPointColor_105(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The color and opacity of points or vertices when not mapped through
		/// a lookup table.
		/// </summary>
		// Token: 0x06007B0F RID: 31503 RVA: 0x000B131B File Offset: 0x000AF51B
		public virtual void SetPointColor(IntPtr _arg)
		{
			vtkViewTheme.vtkViewTheme_SetPointColor_105(base.GetCppThis(), _arg);
		}

		// Token: 0x06007B10 RID: 31504
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetPointHueRange_106(HandleRef pThis, double mn, double mx);

		/// <summary>
		/// The ranges to use in the point lookup table.
		/// You may also do this by accessing the point lookup table directly
		/// with GetPointLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007B11 RID: 31505 RVA: 0x000B132B File Offset: 0x000AF52B
		public virtual void SetPointHueRange(double mn, double mx)
		{
			vtkViewTheme.vtkViewTheme_SetPointHueRange_106(base.GetCppThis(), mn, mx);
		}

		// Token: 0x06007B12 RID: 31506
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetPointHueRange_107(HandleRef pThis, IntPtr rng);

		/// <summary>
		/// The ranges to use in the point lookup table.
		/// You may also do this by accessing the point lookup table directly
		/// with GetPointLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007B13 RID: 31507 RVA: 0x000B133C File Offset: 0x000AF53C
		public virtual void SetPointHueRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_SetPointHueRange_107(base.GetCppThis(), rng);
		}

		// Token: 0x06007B14 RID: 31508
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetPointLookupTable_108(HandleRef pThis, HandleRef lut);

		/// <summary>
		/// Set/Get the point lookup table.
		/// </summary>
		// Token: 0x06007B15 RID: 31509 RVA: 0x000B134C File Offset: 0x000AF54C
		public virtual void SetPointLookupTable(vtkScalarsToColors lut)
		{
			vtkViewTheme.vtkViewTheme_SetPointLookupTable_108(base.GetCppThis(), (lut == null) ? default(HandleRef) : lut.GetCppThis());
		}

		// Token: 0x06007B16 RID: 31510
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetPointOpacity_109(HandleRef pThis, double _arg);

		/// <summary>
		/// The color and opacity of points or vertices when not mapped through
		/// a lookup table.
		/// </summary>
		// Token: 0x06007B17 RID: 31511 RVA: 0x000B137B File Offset: 0x000AF57B
		public virtual void SetPointOpacity(double _arg)
		{
			vtkViewTheme.vtkViewTheme_SetPointOpacity_109(base.GetCppThis(), _arg);
		}

		// Token: 0x06007B18 RID: 31512
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetPointSaturationRange_110(HandleRef pThis, double mn, double mx);

		/// <summary>
		/// The ranges to use in the point lookup table.
		/// You may also do this by accessing the point lookup table directly
		/// with GetPointLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007B19 RID: 31513 RVA: 0x000B138B File Offset: 0x000AF58B
		public virtual void SetPointSaturationRange(double mn, double mx)
		{
			vtkViewTheme.vtkViewTheme_SetPointSaturationRange_110(base.GetCppThis(), mn, mx);
		}

		// Token: 0x06007B1A RID: 31514
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetPointSaturationRange_111(HandleRef pThis, IntPtr rng);

		/// <summary>
		/// The ranges to use in the point lookup table.
		/// You may also do this by accessing the point lookup table directly
		/// with GetPointLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007B1B RID: 31515 RVA: 0x000B139C File Offset: 0x000AF59C
		public virtual void SetPointSaturationRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_SetPointSaturationRange_111(base.GetCppThis(), rng);
		}

		// Token: 0x06007B1C RID: 31516
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetPointSize_112(HandleRef pThis, double _arg);

		/// <summary>
		/// The size of points or vertices
		/// </summary>
		// Token: 0x06007B1D RID: 31517 RVA: 0x000B13AC File Offset: 0x000AF5AC
		public virtual void SetPointSize(double _arg)
		{
			vtkViewTheme.vtkViewTheme_SetPointSize_112(base.GetCppThis(), _arg);
		}

		// Token: 0x06007B1E RID: 31518
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetPointTextProperty_113(HandleRef pThis, HandleRef tprop);

		/// <summary>
		/// The text property to use for labeling points/vertices.
		/// </summary>
		// Token: 0x06007B1F RID: 31519 RVA: 0x000B13BC File Offset: 0x000AF5BC
		public virtual void SetPointTextProperty(vtkTextProperty tprop)
		{
			vtkViewTheme.vtkViewTheme_SetPointTextProperty_113(base.GetCppThis(), (tprop == null) ? default(HandleRef) : tprop.GetCppThis());
		}

		// Token: 0x06007B20 RID: 31520
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetPointValueRange_114(HandleRef pThis, double mn, double mx);

		/// <summary>
		/// The ranges to use in the point lookup table.
		/// You may also do this by accessing the point lookup table directly
		/// with GetPointLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007B21 RID: 31521 RVA: 0x000B13EB File Offset: 0x000AF5EB
		public virtual void SetPointValueRange(double mn, double mx)
		{
			vtkViewTheme.vtkViewTheme_SetPointValueRange_114(base.GetCppThis(), mn, mx);
		}

		// Token: 0x06007B22 RID: 31522
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetPointValueRange_115(HandleRef pThis, IntPtr rng);

		/// <summary>
		/// The ranges to use in the point lookup table.
		/// You may also do this by accessing the point lookup table directly
		/// with GetPointLookupTable() and calling these methods.
		/// </summary>
		// Token: 0x06007B23 RID: 31523 RVA: 0x000B13FC File Offset: 0x000AF5FC
		public virtual void SetPointValueRange(IntPtr rng)
		{
			vtkViewTheme.vtkViewTheme_SetPointValueRange_115(base.GetCppThis(), rng);
		}

		// Token: 0x06007B24 RID: 31524
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetScaleCellLookupTable_116(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether to scale the lookup table to fit the range of the data.
		/// </summary>
		// Token: 0x06007B25 RID: 31525 RVA: 0x000B140C File Offset: 0x000AF60C
		public virtual void SetScaleCellLookupTable(bool _arg)
		{
			vtkViewTheme.vtkViewTheme_SetScaleCellLookupTable_116(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06007B26 RID: 31526
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetScalePointLookupTable_117(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether to scale the lookup table to fit the range of the data.
		/// </summary>
		// Token: 0x06007B27 RID: 31527 RVA: 0x000B1424 File Offset: 0x000AF624
		public virtual void SetScalePointLookupTable(bool _arg)
		{
			vtkViewTheme.vtkViewTheme_SetScalePointLookupTable_117(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06007B28 RID: 31528
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetSelectedCellColor_118(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// The color of selected cells or edges.
		/// </summary>
		// Token: 0x06007B29 RID: 31529 RVA: 0x000B143C File Offset: 0x000AF63C
		public virtual void SetSelectedCellColor(double _arg1, double _arg2, double _arg3)
		{
			vtkViewTheme.vtkViewTheme_SetSelectedCellColor_118(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06007B2A RID: 31530
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetSelectedCellColor_119(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The color of selected cells or edges.
		/// </summary>
		// Token: 0x06007B2B RID: 31531 RVA: 0x000B144E File Offset: 0x000AF64E
		public virtual void SetSelectedCellColor(IntPtr _arg)
		{
			vtkViewTheme.vtkViewTheme_SetSelectedCellColor_119(base.GetCppThis(), _arg);
		}

		// Token: 0x06007B2C RID: 31532
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetSelectedCellOpacity_120(HandleRef pThis, double _arg);

		/// <summary>
		/// The color of selected cells or edges.
		/// </summary>
		// Token: 0x06007B2D RID: 31533 RVA: 0x000B145E File Offset: 0x000AF65E
		public virtual void SetSelectedCellOpacity(double _arg)
		{
			vtkViewTheme.vtkViewTheme_SetSelectedCellOpacity_120(base.GetCppThis(), _arg);
		}

		// Token: 0x06007B2E RID: 31534
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetSelectedPointColor_121(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// The color of selected points or vertices.
		/// </summary>
		// Token: 0x06007B2F RID: 31535 RVA: 0x000B146E File Offset: 0x000AF66E
		public virtual void SetSelectedPointColor(double _arg1, double _arg2, double _arg3)
		{
			vtkViewTheme.vtkViewTheme_SetSelectedPointColor_121(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06007B30 RID: 31536
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetSelectedPointColor_122(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The color of selected points or vertices.
		/// </summary>
		// Token: 0x06007B31 RID: 31537 RVA: 0x000B1480 File Offset: 0x000AF680
		public virtual void SetSelectedPointColor(IntPtr _arg)
		{
			vtkViewTheme.vtkViewTheme_SetSelectedPointColor_122(base.GetCppThis(), _arg);
		}

		// Token: 0x06007B32 RID: 31538
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetSelectedPointOpacity_123(HandleRef pThis, double _arg);

		/// <summary>
		/// The color of selected points or vertices.
		/// </summary>
		// Token: 0x06007B33 RID: 31539 RVA: 0x000B1490 File Offset: 0x000AF690
		public virtual void SetSelectedPointOpacity(double _arg)
		{
			vtkViewTheme.vtkViewTheme_SetSelectedPointOpacity_123(base.GetCppThis(), _arg);
		}

		// Token: 0x06007B34 RID: 31540
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetVertexLabelColor_124(HandleRef pThis, double r, double g, double b);

		/// <summary>
		/// The color to use for labeling graph vertices.
		/// This is deprecated. Use GetPointTextProperty()-&gt;SetColor() instead.
		/// </summary>
		// Token: 0x06007B35 RID: 31541 RVA: 0x000B14A0 File Offset: 0x000AF6A0
		public virtual void SetVertexLabelColor(double r, double g, double b)
		{
			vtkViewTheme.vtkViewTheme_SetVertexLabelColor_124(base.GetCppThis(), r, g, b);
		}

		// Token: 0x06007B36 RID: 31542
		[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewTheme_SetVertexLabelColor_125(HandleRef pThis, IntPtr c);

		/// <summary>
		/// The color to use for labeling graph vertices.
		/// This is deprecated. Use GetPointTextProperty()-&gt;SetColor() instead.
		/// </summary>
		// Token: 0x06007B37 RID: 31543 RVA: 0x000B14B2 File Offset: 0x000AF6B2
		public virtual void SetVertexLabelColor(IntPtr c)
		{
			vtkViewTheme.vtkViewTheme_SetVertexLabelColor_125(base.GetCppThis(), c);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A60 RID: 2656
		public new const string MRFullTypeName = "Kitware.VTK.vtkViewTheme";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A61 RID: 2657
		public new static readonly string MRClassNameKey = "class vtkViewTheme";
	}
}
