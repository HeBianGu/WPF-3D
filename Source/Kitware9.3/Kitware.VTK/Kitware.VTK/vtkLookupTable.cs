using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLookupTable
	/// </summary>
	/// <remarks>
	///    map scalar values into colors via a lookup table
	///
	/// vtkLookupTable is an object that is used by mapper objects to map scalar
	/// values into RGBA (red-green-blue-alpha) color specification,
	/// or RGBA into scalar values. The color table can be created by direct
	/// insertion of color values, or by specifying a hue, saturation, value, and
	/// alpha range and generating a table.
	///
	/// A special color for NaN values in the data can be specified via
	/// SetNanColor(). In addition, a color for data values below the
	/// lookup table range minimum can be specified with
	/// SetBelowRangeColor(), and that color will be used for values below
	/// the range minimum when UseBelowRangeColor is on.  Likewise, a color
	/// for data values above the lookup table range maximum can be
	/// specified with SetAboveRangeColor(), and it is used when
	/// UseAboveRangeColor is on.
	///
	/// This class behaves differently depending on how \a IndexedLookup is set.
	/// When true, vtkLookupTable enters a mode for representing categorical color maps.
	/// By setting \a IndexedLookup to true, you indicate that the annotated
	/// values are the only valid values for which entries in the color table
	/// should be returned. The colors in the lookup \a Table are assigned
	/// to annotated values by taking the modulus of their index in the list
	/// of annotations. \a IndexedLookup changes the behavior of \a GetIndex,
	/// which in turn changes the way \a MapScalarsThroughTable2 behaves;
	/// when \a IndexedLookup is true, \a MapScalarsThroughTable2 will search for
	/// scalar values in \a AnnotatedValues and use the resulting index to
	/// determine the color. If a scalar value is not present in \a AnnotatedValues,
	/// then \a NanColor will be used.
	///
	/// @warning
	/// You need to explicitly call Build() when constructing the LUT by hand.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkLogLookupTable vtkWindowLevelLookupTable
	/// </seealso>
	// Token: 0x0200003E RID: 62
	public class vtkLookupTable : vtkScalarsToColors
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000ACA RID: 2762 RVA: 0x000169EF File Offset: 0x00014BEF
		static vtkLookupTable()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLookupTable.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLookupTable"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000ACB RID: 2763 RVA: 0x00016A17 File Offset: 0x00014C17
		public vtkLookupTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06000ACC RID: 2764
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLookupTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with range=[0,1]; and hsv ranges set up for rainbow color table
		/// (from red to blue).
		/// </summary>
		// Token: 0x06000ACD RID: 2765 RVA: 0x00016A28 File Offset: 0x00014C28
		public new static vtkLookupTable New()
		{
			vtkLookupTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLookupTable.vtkLookupTable_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLookupTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with range=[0,1]; and hsv ranges set up for rainbow color table
		/// (from red to blue).
		/// </summary>
		// Token: 0x06000ACE RID: 2766 RVA: 0x00016A7C File Offset: 0x00014C7C
		public vtkLookupTable() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLookupTable.vtkLookupTable_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000ACF RID: 2767 RVA: 0x00016AC0 File Offset: 0x00014CC0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000AD0 RID: 2768
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLookupTable_Allocate_01(HandleRef pThis, int sz, int ext);

		/// <summary>
		/// Allocate a color table of specified size.
		/// Note that ext is no longer used.
		/// </summary>
		// Token: 0x06000AD1 RID: 2769 RVA: 0x00016ACC File Offset: 0x00014CCC
		public int Allocate(int sz, int ext)
		{
			return vtkLookupTable.vtkLookupTable_Allocate_01(base.GetCppThis(), sz, ext);
		}

		// Token: 0x06000AD2 RID: 2770
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLookupTable_ApplyLogScale_02(double v, IntPtr range, IntPtr log_range);

		/// <summary>
		/// Apply log to value, with appropriate constraints.
		/// </summary>
		// Token: 0x06000AD3 RID: 2771 RVA: 0x00016AF0 File Offset: 0x00014CF0
		public static double ApplyLogScale(double v, IntPtr range, IntPtr log_range)
		{
			return vtkLookupTable.vtkLookupTable_ApplyLogScale_02(v, range, log_range);
		}

		// Token: 0x06000AD4 RID: 2772
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_Build_03(HandleRef pThis);

		/// <summary>
		/// Generate lookup table from hue, saturation, value, alpha min/max values.
		/// Table is built from linear ramp of each value.
		/// </summary>
		// Token: 0x06000AD5 RID: 2773 RVA: 0x00016B0C File Offset: 0x00014D0C
		public override void Build()
		{
			vtkLookupTable.vtkLookupTable_Build_03(base.GetCppThis());
		}

		// Token: 0x06000AD6 RID: 2774
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_BuildSpecialColors_04(HandleRef pThis);

		/// <summary>
		/// Copies the "special" colors into the given table.
		/// </summary>
		// Token: 0x06000AD7 RID: 2775 RVA: 0x00016B1B File Offset: 0x00014D1B
		public void BuildSpecialColors()
		{
			vtkLookupTable.vtkLookupTable_BuildSpecialColors_04(base.GetCppThis());
		}

		// Token: 0x06000AD8 RID: 2776
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_DeepCopy_05(HandleRef pThis, HandleRef obj);

		/// <summary>
		/// Copy the contents from another LookupTable.
		/// </summary>
		// Token: 0x06000AD9 RID: 2777 RVA: 0x00016B2C File Offset: 0x00014D2C
		public override void DeepCopy(vtkScalarsToColors obj)
		{
			vtkLookupTable.vtkLookupTable_DeepCopy_05(base.GetCppThis(), (obj == null) ? default(HandleRef) : obj.GetCppThis());
		}

		// Token: 0x06000ADA RID: 2778
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_ForceBuild_06(HandleRef pThis);

		/// <summary>
		/// Force the lookup table to regenerate from hue, saturation, value,
		/// and alpha min/max values.  Table is built from a linear ramp of
		/// each value.  ForceBuild() is useful if a lookup table has been
		/// defined manually (using SetTableValue) and then an application
		/// decides to rebuild the lookup table using the implicit process.
		/// </summary>
		// Token: 0x06000ADB RID: 2779 RVA: 0x00016B5B File Offset: 0x00014D5B
		public virtual void ForceBuild()
		{
			vtkLookupTable.vtkLookupTable_ForceBuild_06(base.GetCppThis());
		}

		// Token: 0x06000ADC RID: 2780
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLookupTable_GetAboveRangeColor_07(HandleRef pThis);

		/// <summary>
		/// Set the color to use when a value above the range is
		/// encountered. This is an RGBA 4-tuple of doubles in the range [0, 1].
		/// </summary>
		// Token: 0x06000ADD RID: 2781 RVA: 0x00016B6C File Offset: 0x00014D6C
		public virtual double[] GetAboveRangeColor()
		{
			IntPtr intPtr = vtkLookupTable.vtkLookupTable_GetAboveRangeColor_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06000ADE RID: 2782
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_GetAboveRangeColor_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		/// <summary>
		/// Set the color to use when a value above the range is
		/// encountered. This is an RGBA 4-tuple of doubles in the range [0, 1].
		/// </summary>
		// Token: 0x06000ADF RID: 2783 RVA: 0x00016BB4 File Offset: 0x00014DB4
		public virtual void GetAboveRangeColor(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkLookupTable.vtkLookupTable_GetAboveRangeColor_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x06000AE0 RID: 2784
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_GetAboveRangeColor_09(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the color to use when a value above the range is
		/// encountered. This is an RGBA 4-tuple of doubles in the range [0, 1].
		/// </summary>
		// Token: 0x06000AE1 RID: 2785 RVA: 0x00016BC8 File Offset: 0x00014DC8
		public virtual void GetAboveRangeColor(IntPtr _arg)
		{
			vtkLookupTable.vtkLookupTable_GetAboveRangeColor_09(base.GetCppThis(), _arg);
		}

		// Token: 0x06000AE2 RID: 2786
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLookupTable_GetAlphaRange_10(HandleRef pThis);

		/// <summary>
		/// Set the range in alpha (using automatic generation). Alpha ranges from
		/// [0,1].
		/// </summary>
		// Token: 0x06000AE3 RID: 2787 RVA: 0x00016BD8 File Offset: 0x00014DD8
		public virtual double[] GetAlphaRange()
		{
			IntPtr intPtr = vtkLookupTable.vtkLookupTable_GetAlphaRange_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06000AE4 RID: 2788
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_GetAlphaRange_11(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Set the range in alpha (using automatic generation). Alpha ranges from
		/// [0,1].
		/// </summary>
		// Token: 0x06000AE5 RID: 2789 RVA: 0x00016C20 File Offset: 0x00014E20
		public virtual void GetAlphaRange(ref double _arg1, ref double _arg2)
		{
			vtkLookupTable.vtkLookupTable_GetAlphaRange_11(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06000AE6 RID: 2790
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_GetAlphaRange_12(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the range in alpha (using automatic generation). Alpha ranges from
		/// [0,1].
		/// </summary>
		// Token: 0x06000AE7 RID: 2791 RVA: 0x00016C31 File Offset: 0x00014E31
		public virtual void GetAlphaRange(IntPtr _arg)
		{
			vtkLookupTable.vtkLookupTable_GetAlphaRange_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06000AE8 RID: 2792
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLookupTable_GetBelowRangeColor_13(HandleRef pThis);

		/// <summary>
		/// Set the color to use when a value below the range is
		/// encountered. This is an RGBA 4-tuple of doubles in the range [0, 1].
		/// </summary>
		// Token: 0x06000AE9 RID: 2793 RVA: 0x00016C44 File Offset: 0x00014E44
		public virtual double[] GetBelowRangeColor()
		{
			IntPtr intPtr = vtkLookupTable.vtkLookupTable_GetBelowRangeColor_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06000AEA RID: 2794
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_GetBelowRangeColor_14(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		/// <summary>
		/// Set the color to use when a value below the range is
		/// encountered. This is an RGBA 4-tuple of doubles in the range [0, 1].
		/// </summary>
		// Token: 0x06000AEB RID: 2795 RVA: 0x00016C8C File Offset: 0x00014E8C
		public virtual void GetBelowRangeColor(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkLookupTable.vtkLookupTable_GetBelowRangeColor_14(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x06000AEC RID: 2796
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_GetBelowRangeColor_15(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the color to use when a value below the range is
		/// encountered. This is an RGBA 4-tuple of doubles in the range [0, 1].
		/// </summary>
		// Token: 0x06000AED RID: 2797 RVA: 0x00016CA0 File Offset: 0x00014EA0
		public virtual void GetBelowRangeColor(IntPtr _arg)
		{
			vtkLookupTable.vtkLookupTable_GetBelowRangeColor_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06000AEE RID: 2798
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_GetColor_16(HandleRef pThis, double v, IntPtr rgb);

		/// <summary>
		/// Map one value through the lookup table and return the color as
		/// an RGB[3] array of doubles between 0 and 1. Note lack of alpha.
		/// </summary>
		// Token: 0x06000AEF RID: 2799 RVA: 0x00016CB0 File Offset: 0x00014EB0
		public override void GetColor(double v, IntPtr rgb)
		{
			vtkLookupTable.vtkLookupTable_GetColor_16(base.GetCppThis(), v, rgb);
		}

		// Token: 0x06000AF0 RID: 2800
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_GetColorAsUnsignedChars_17(IntPtr colorIn, IntPtr colorOut);

		/// <summary>
		/// Given an RGBA[4] color in the [0,1] range, convert it to RGBA[4] in the [0,255] range.
		/// </summary>
		// Token: 0x06000AF1 RID: 2801 RVA: 0x00016CC1 File Offset: 0x00014EC1
		public static void GetColorAsUnsignedChars(IntPtr colorIn, IntPtr colorOut)
		{
			vtkLookupTable.vtkLookupTable_GetColorAsUnsignedChars_17(colorIn, colorOut);
		}

		// Token: 0x06000AF2 RID: 2802
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLookupTable_GetHueRange_18(HandleRef pThis);

		/// <summary>
		/// Set the range in hue (using automatic generation). Hue ranges
		/// between [0,1].
		/// </summary>
		// Token: 0x06000AF3 RID: 2803 RVA: 0x00016CCC File Offset: 0x00014ECC
		public virtual double[] GetHueRange()
		{
			IntPtr intPtr = vtkLookupTable.vtkLookupTable_GetHueRange_18(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06000AF4 RID: 2804
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_GetHueRange_19(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Set the range in hue (using automatic generation). Hue ranges
		/// between [0,1].
		/// </summary>
		// Token: 0x06000AF5 RID: 2805 RVA: 0x00016D14 File Offset: 0x00014F14
		public virtual void GetHueRange(ref double _arg1, ref double _arg2)
		{
			vtkLookupTable.vtkLookupTable_GetHueRange_19(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06000AF6 RID: 2806
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_GetHueRange_20(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the range in hue (using automatic generation). Hue ranges
		/// between [0,1].
		/// </summary>
		// Token: 0x06000AF7 RID: 2807 RVA: 0x00016D25 File Offset: 0x00014F25
		public virtual void GetHueRange(IntPtr _arg)
		{
			vtkLookupTable.vtkLookupTable_GetHueRange_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06000AF8 RID: 2808
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLookupTable_GetIndex_21(HandleRef pThis, double v);

		/// <summary>
		/// Return the table index associated with a particular value.
		/// Returns -1 if \a v is NaN.
		///
		/// Do not use this function when \a IndexedLookup is true:
		/// in that case, the set of values \a v may take on is exactly the integers
		/// from 0 to \a GetNumberOfTableValues() - 1;
		/// and \a v serves directly as an index into \a TableValues.
		/// </summary>
		// Token: 0x06000AF9 RID: 2809 RVA: 0x00016D38 File Offset: 0x00014F38
		public virtual long GetIndex(double v)
		{
			return vtkLookupTable.vtkLookupTable_GetIndex_21(base.GetCppThis(), v);
		}

		// Token: 0x06000AFA RID: 2810
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_GetIndexedColor_22(HandleRef pThis, long idx, IntPtr rgba);

		/// <summary>
		/// Return a color given an integer index.
		///
		/// This is used to assign colors to annotations (given an offset into the
		/// list of annotations).
		/// If the table is empty or \a idx &lt; 0, then NanColor is returned.
		/// </summary>
		// Token: 0x06000AFB RID: 2811 RVA: 0x00016D58 File Offset: 0x00014F58
		public override void GetIndexedColor(long idx, IntPtr rgba)
		{
			vtkLookupTable.vtkLookupTable_GetIndexedColor_22(base.GetCppThis(), idx, rgba);
		}

		// Token: 0x06000AFC RID: 2812
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_GetLogRange_23(IntPtr range, IntPtr log_range);

		/// <summary>
		/// Returns the log of \c range in \c log_range.
		/// There is a little more to this than simply taking the log10 of the
		/// two range values: we do conversion of negative ranges to positive
		/// ranges, and conversion of zero to a 'very small number'.
		/// </summary>
		// Token: 0x06000AFD RID: 2813 RVA: 0x00016D69 File Offset: 0x00014F69
		public static void GetLogRange(IntPtr range, IntPtr log_range)
		{
			vtkLookupTable.vtkLookupTable_GetLogRange_23(range, log_range);
		}

		// Token: 0x06000AFE RID: 2814
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLookupTable_GetNanColor_24(HandleRef pThis);

		/// <summary>
		/// Set the color to use when a NaN (not a number) is encountered.  This is an
		/// RGBA 4-tuple of doubles in the range [0,1].
		/// </summary>
		// Token: 0x06000AFF RID: 2815 RVA: 0x00016D74 File Offset: 0x00014F74
		public virtual double[] GetNanColor()
		{
			IntPtr intPtr = vtkLookupTable.vtkLookupTable_GetNanColor_24(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06000B00 RID: 2816
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_GetNanColor_25(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		/// <summary>
		/// Set the color to use when a NaN (not a number) is encountered.  This is an
		/// RGBA 4-tuple of doubles in the range [0,1].
		/// </summary>
		// Token: 0x06000B01 RID: 2817 RVA: 0x00016DBC File Offset: 0x00014FBC
		public virtual void GetNanColor(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkLookupTable.vtkLookupTable_GetNanColor_25(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x06000B02 RID: 2818
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_GetNanColor_26(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the color to use when a NaN (not a number) is encountered.  This is an
		/// RGBA 4-tuple of doubles in the range [0,1].
		/// </summary>
		// Token: 0x06000B03 RID: 2819 RVA: 0x00016DD0 File Offset: 0x00014FD0
		public virtual void GetNanColor(IntPtr _arg)
		{
			vtkLookupTable.vtkLookupTable_GetNanColor_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06000B04 RID: 2820
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLookupTable_GetNanColorAsUnsignedChars_27(HandleRef pThis);

		/// <summary>
		/// Return the \a NanColor as a pointer to 4 unsigned chars. This
		/// will overwrite any data returned by previous calls to MapValue.
		/// </summary>
		// Token: 0x06000B05 RID: 2821 RVA: 0x00016DE0 File Offset: 0x00014FE0
		public IntPtr GetNanColorAsUnsignedChars()
		{
			return vtkLookupTable.vtkLookupTable_GetNanColorAsUnsignedChars_27(base.GetCppThis());
		}

		// Token: 0x06000B06 RID: 2822
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLookupTable_GetNumberOfAvailableColors_28(HandleRef pThis);

		/// <summary>
		/// Get the number of available colors for mapping to.
		/// </summary>
		// Token: 0x06000B07 RID: 2823 RVA: 0x00016E00 File Offset: 0x00015000
		public override long GetNumberOfAvailableColors()
		{
			return vtkLookupTable.vtkLookupTable_GetNumberOfAvailableColors_28(base.GetCppThis());
		}

		// Token: 0x06000B08 RID: 2824
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLookupTable_GetNumberOfColors_29(HandleRef pThis);

		/// <summary>
		/// Set the number of colors in the lookup table.  Use
		/// SetNumberOfTableValues() instead, it can be used both before and
		/// after the table has been built whereas SetNumberOfColors() has no
		/// effect after the table has been built.
		/// </summary>
		// Token: 0x06000B09 RID: 2825 RVA: 0x00016E20 File Offset: 0x00015020
		public virtual long GetNumberOfColors()
		{
			return vtkLookupTable.vtkLookupTable_GetNumberOfColors_29(base.GetCppThis());
		}

		// Token: 0x06000B0A RID: 2826
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLookupTable_GetNumberOfColorsMaxValue_30(HandleRef pThis);

		/// <summary>
		/// Set the number of colors in the lookup table.  Use
		/// SetNumberOfTableValues() instead, it can be used both before and
		/// after the table has been built whereas SetNumberOfColors() has no
		/// effect after the table has been built.
		/// </summary>
		// Token: 0x06000B0B RID: 2827 RVA: 0x00016E40 File Offset: 0x00015040
		public virtual long GetNumberOfColorsMaxValue()
		{
			return vtkLookupTable.vtkLookupTable_GetNumberOfColorsMaxValue_30(base.GetCppThis());
		}

		// Token: 0x06000B0C RID: 2828
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLookupTable_GetNumberOfColorsMinValue_31(HandleRef pThis);

		/// <summary>
		/// Set the number of colors in the lookup table.  Use
		/// SetNumberOfTableValues() instead, it can be used both before and
		/// after the table has been built whereas SetNumberOfColors() has no
		/// effect after the table has been built.
		/// </summary>
		// Token: 0x06000B0D RID: 2829 RVA: 0x00016E60 File Offset: 0x00015060
		public virtual long GetNumberOfColorsMinValue()
		{
			return vtkLookupTable.vtkLookupTable_GetNumberOfColorsMinValue_31(base.GetCppThis());
		}

		// Token: 0x06000B0E RID: 2830
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLookupTable_GetNumberOfGenerationsFromBase_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct with range=[0,1]; and hsv ranges set up for rainbow color table
		/// (from red to blue).
		/// </summary>
		// Token: 0x06000B0F RID: 2831 RVA: 0x00016E80 File Offset: 0x00015080
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLookupTable.vtkLookupTable_GetNumberOfGenerationsFromBase_32(base.GetCppThis(), type);
		}

		// Token: 0x06000B10 RID: 2832
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLookupTable_GetNumberOfGenerationsFromBaseType_33([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct with range=[0,1]; and hsv ranges set up for rainbow color table
		/// (from red to blue).
		/// </summary>
		// Token: 0x06000B11 RID: 2833 RVA: 0x00016EA0 File Offset: 0x000150A0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLookupTable.vtkLookupTable_GetNumberOfGenerationsFromBaseType_33(type);
		}

		// Token: 0x06000B12 RID: 2834
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLookupTable_GetNumberOfTableValues_34(HandleRef pThis);

		/// <summary>
		/// Specify the number of values (i.e., colors) in the lookup table.
		/// </summary>
		// Token: 0x06000B13 RID: 2835 RVA: 0x00016EBC File Offset: 0x000150BC
		public long GetNumberOfTableValues()
		{
			return vtkLookupTable.vtkLookupTable_GetNumberOfTableValues_34(base.GetCppThis());
		}

		// Token: 0x06000B14 RID: 2836
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLookupTable_GetOpacity_35(HandleRef pThis, double v);

		/// <summary>
		/// Map one value through the lookup table and return the alpha value
		/// (the opacity) as a double between 0 and 1.
		/// </summary>
		// Token: 0x06000B15 RID: 2837 RVA: 0x00016EDC File Offset: 0x000150DC
		public override double GetOpacity(double v)
		{
			return vtkLookupTable.vtkLookupTable_GetOpacity_35(base.GetCppThis(), v);
		}

		// Token: 0x06000B16 RID: 2838
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLookupTable_GetPointer_36(HandleRef pThis, long id);

		/// <summary>
		/// Get pointer to color table data. Format is array of unsigned char
		/// R-G-B-A...R-G-B-A.
		/// </summary>
		// Token: 0x06000B17 RID: 2839 RVA: 0x00016EFC File Offset: 0x000150FC
		public IntPtr GetPointer(long id)
		{
			return vtkLookupTable.vtkLookupTable_GetPointer_36(base.GetCppThis(), id);
		}

		// Token: 0x06000B18 RID: 2840
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLookupTable_GetRamp_37(HandleRef pThis);

		/// <summary>
		/// Set the shape of the table ramp to either S-curve, linear, or sqrt.
		/// The default is S-curve, which tails off gradually at either end.
		///
		/// The equation used for the S-curve is y = (sin((x - 1/2)*pi) + 1)/2,
		/// For an S-curve greyscale ramp, you should set NumberOfTableValues
		/// to 402 (which is 256*pi/2) to provide room for the tails of the ramp.
		///
		/// The equation for the linear ramp is simply y = x.
		///
		/// The equation for the SQRT is y = sqrt(x).
		/// </summary>
		// Token: 0x06000B19 RID: 2841 RVA: 0x00016F1C File Offset: 0x0001511C
		public virtual int GetRamp()
		{
			return vtkLookupTable.vtkLookupTable_GetRamp_37(base.GetCppThis());
		}

		// Token: 0x06000B1A RID: 2842
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLookupTable_GetRange_38(HandleRef pThis);

		/// <summary>
		/// Sets/Gets the range of scalars which will be mapped.  This is a duplicate
		/// of Get/SetTableRange.
		/// </summary>
		// Token: 0x06000B1B RID: 2843 RVA: 0x00016F3C File Offset: 0x0001513C
		public override double[] GetRange()
		{
			IntPtr intPtr = vtkLookupTable.vtkLookupTable_GetRange_38(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06000B1C RID: 2844
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLookupTable_GetSaturationRange_39(HandleRef pThis);

		/// <summary>
		/// Set the range in saturation (using automatic generation). Saturation
		/// ranges between [0,1].
		/// </summary>
		// Token: 0x06000B1D RID: 2845 RVA: 0x00016F84 File Offset: 0x00015184
		public virtual double[] GetSaturationRange()
		{
			IntPtr intPtr = vtkLookupTable.vtkLookupTable_GetSaturationRange_39(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06000B1E RID: 2846
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_GetSaturationRange_40(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Set the range in saturation (using automatic generation). Saturation
		/// ranges between [0,1].
		/// </summary>
		// Token: 0x06000B1F RID: 2847 RVA: 0x00016FCC File Offset: 0x000151CC
		public virtual void GetSaturationRange(ref double _arg1, ref double _arg2)
		{
			vtkLookupTable.vtkLookupTable_GetSaturationRange_40(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06000B20 RID: 2848
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_GetSaturationRange_41(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the range in saturation (using automatic generation). Saturation
		/// ranges between [0,1].
		/// </summary>
		// Token: 0x06000B21 RID: 2849 RVA: 0x00016FDD File Offset: 0x000151DD
		public virtual void GetSaturationRange(IntPtr _arg)
		{
			vtkLookupTable.vtkLookupTable_GetSaturationRange_41(base.GetCppThis(), _arg);
		}

		// Token: 0x06000B22 RID: 2850
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLookupTable_GetScale_42(HandleRef pThis);

		/// <summary>
		/// Set the type of scale to use, linear or logarithmic.  The default
		/// is linear.  If the scale is logarithmic, then the TableRange must not
		/// cross the value zero.
		/// </summary>
		// Token: 0x06000B23 RID: 2851 RVA: 0x00016FF0 File Offset: 0x000151F0
		public virtual int GetScale()
		{
			return vtkLookupTable.vtkLookupTable_GetScale_42(base.GetCppThis());
		}

		// Token: 0x06000B24 RID: 2852
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLookupTable_GetTable_43(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the internal table array that is used to map the scalars
		/// to colors.  The table array is an unsigned char array with 4
		/// components representing RGBA.
		/// </summary>
		// Token: 0x06000B25 RID: 2853 RVA: 0x00017010 File Offset: 0x00015210
		public virtual vtkUnsignedCharArray GetTable()
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLookupTable.vtkLookupTable_GetTable_43(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		// Token: 0x06000B26 RID: 2854
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLookupTable_GetTableRange_44(HandleRef pThis);

		/// <summary>
		/// Set/Get the minimum/maximum scalar values for scalar mapping. Scalar
		/// values less than minimum range value are clamped to minimum range value.
		/// Scalar values greater than maximum range value are clamped to maximum
		/// range value.
		///
		/// The \a TableRange values are only used when \a IndexedLookup is false.
		/// </summary>
		// Token: 0x06000B27 RID: 2855 RVA: 0x00017080 File Offset: 0x00015280
		public virtual double[] GetTableRange()
		{
			IntPtr intPtr = vtkLookupTable.vtkLookupTable_GetTableRange_44(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06000B28 RID: 2856
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_GetTableRange_45(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the minimum/maximum scalar values for scalar mapping. Scalar
		/// values less than minimum range value are clamped to minimum range value.
		/// Scalar values greater than maximum range value are clamped to maximum
		/// range value.
		///
		/// The \a TableRange values are only used when \a IndexedLookup is false.
		/// </summary>
		// Token: 0x06000B29 RID: 2857 RVA: 0x000170C8 File Offset: 0x000152C8
		public virtual void GetTableRange(IntPtr data)
		{
			vtkLookupTable.vtkLookupTable_GetTableRange_45(base.GetCppThis(), data);
		}

		// Token: 0x06000B2A RID: 2858
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLookupTable_GetTableValue_46(HandleRef pThis, long indx);

		/// <summary>
		/// Return an RGBA color value for the given index into the lookup table. Color
		/// components are expressed as [0,1] double values.
		/// </summary>
		// Token: 0x06000B2B RID: 2859 RVA: 0x000170D8 File Offset: 0x000152D8
		public double[] GetTableValue(long indx)
		{
			IntPtr intPtr = vtkLookupTable.vtkLookupTable_GetTableValue_46(base.GetCppThis(), indx);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06000B2C RID: 2860
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_GetTableValue_47(HandleRef pThis, long indx, IntPtr rgba);

		/// <summary>
		/// Return an RGBA color value for the given index into the lookup table. Color
		/// components are expressed as [0,1] double values.
		/// </summary>
		// Token: 0x06000B2D RID: 2861 RVA: 0x00017121 File Offset: 0x00015321
		public void GetTableValue(long indx, IntPtr rgba)
		{
			vtkLookupTable.vtkLookupTable_GetTableValue_47(base.GetCppThis(), indx, rgba);
		}

		// Token: 0x06000B2E RID: 2862
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLookupTable_GetUseAboveRangeColor_48(HandleRef pThis);

		/// <summary>
		/// Set whether the above range color should be used.
		/// </summary>
		// Token: 0x06000B2F RID: 2863 RVA: 0x00017134 File Offset: 0x00015334
		public virtual int GetUseAboveRangeColor()
		{
			return vtkLookupTable.vtkLookupTable_GetUseAboveRangeColor_48(base.GetCppThis());
		}

		// Token: 0x06000B30 RID: 2864
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLookupTable_GetUseBelowRangeColor_49(HandleRef pThis);

		/// <summary>
		/// Set whether the below range color should be used.
		/// </summary>
		// Token: 0x06000B31 RID: 2865 RVA: 0x00017154 File Offset: 0x00015354
		public virtual int GetUseBelowRangeColor()
		{
			return vtkLookupTable.vtkLookupTable_GetUseBelowRangeColor_49(base.GetCppThis());
		}

		// Token: 0x06000B32 RID: 2866
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLookupTable_GetValueRange_50(HandleRef pThis);

		/// <summary>
		/// Set the range in value (using automatic generation). Value ranges
		/// between [0,1].
		/// </summary>
		// Token: 0x06000B33 RID: 2867 RVA: 0x00017174 File Offset: 0x00015374
		public virtual double[] GetValueRange()
		{
			IntPtr intPtr = vtkLookupTable.vtkLookupTable_GetValueRange_50(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06000B34 RID: 2868
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_GetValueRange_51(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Set the range in value (using automatic generation). Value ranges
		/// between [0,1].
		/// </summary>
		// Token: 0x06000B35 RID: 2869 RVA: 0x000171BC File Offset: 0x000153BC
		public virtual void GetValueRange(ref double _arg1, ref double _arg2)
		{
			vtkLookupTable.vtkLookupTable_GetValueRange_51(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06000B36 RID: 2870
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_GetValueRange_52(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the range in value (using automatic generation). Value ranges
		/// between [0,1].
		/// </summary>
		// Token: 0x06000B37 RID: 2871 RVA: 0x000171CD File Offset: 0x000153CD
		public virtual void GetValueRange(IntPtr _arg)
		{
			vtkLookupTable.vtkLookupTable_GetValueRange_52(base.GetCppThis(), _arg);
		}

		// Token: 0x06000B38 RID: 2872
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLookupTable_IsA_53(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct with range=[0,1]; and hsv ranges set up for rainbow color table
		/// (from red to blue).
		/// </summary>
		// Token: 0x06000B39 RID: 2873 RVA: 0x000171E0 File Offset: 0x000153E0
		public override int IsA(string type)
		{
			return vtkLookupTable.vtkLookupTable_IsA_53(base.GetCppThis(), type);
		}

		// Token: 0x06000B3A RID: 2874
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLookupTable_IsOpaque_54(HandleRef pThis);

		/// <summary>
		/// Return true if all of the values defining the mapping have an opacity
		/// equal to 1.
		/// </summary>
		// Token: 0x06000B3B RID: 2875 RVA: 0x00017200 File Offset: 0x00015400
		public override int IsOpaque()
		{
			return vtkLookupTable.vtkLookupTable_IsOpaque_54(base.GetCppThis());
		}

		// Token: 0x06000B3C RID: 2876
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLookupTable_IsOpaque_55(HandleRef pThis, HandleRef scalars, int colorMode, int component);

		/// <summary>
		/// Return true if all of the values defining the mapping have an opacity
		/// equal to 1.
		/// </summary>
		// Token: 0x06000B3D RID: 2877 RVA: 0x00017220 File Offset: 0x00015420
		public override int IsOpaque(vtkAbstractArray scalars, int colorMode, int component)
		{
			return vtkLookupTable.vtkLookupTable_IsOpaque_55(base.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis(), colorMode, component);
		}

		// Token: 0x06000B3E RID: 2878
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLookupTable_IsOpaque_56(HandleRef pThis, HandleRef scalars, int colorMode, int component, HandleRef ghosts, byte ghostsToSkip);

		/// <summary>
		/// Return true if all of the values defining the mapping have an opacity
		/// equal to 1.
		/// </summary>
		// Token: 0x06000B3F RID: 2879 RVA: 0x00017258 File Offset: 0x00015458
		public override int IsOpaque(vtkAbstractArray scalars, int colorMode, int component, vtkUnsignedCharArray ghosts, byte ghostsToSkip)
		{
			return vtkLookupTable.vtkLookupTable_IsOpaque_56(base.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis(), colorMode, component, (ghosts == null) ? default(HandleRef) : ghosts.GetCppThis(), ghostsToSkip);
		}

		// Token: 0x06000B40 RID: 2880
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLookupTable_IsTypeOf_57([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct with range=[0,1]; and hsv ranges set up for rainbow color table
		/// (from red to blue).
		/// </summary>
		// Token: 0x06000B41 RID: 2881 RVA: 0x000172A8 File Offset: 0x000154A8
		public new static int IsTypeOf(string type)
		{
			return vtkLookupTable.vtkLookupTable_IsTypeOf_57(type);
		}

		// Token: 0x06000B42 RID: 2882
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_MapScalarsThroughTable2_58(HandleRef pThis, IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat);

		/// <summary>
		/// Map a set of scalars through the lookup table.
		///
		/// This member function is thread safe.
		/// </summary>
		// Token: 0x06000B43 RID: 2883 RVA: 0x000172C2 File Offset: 0x000154C2
		public override void MapScalarsThroughTable2(IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
		{
			vtkLookupTable.vtkLookupTable_MapScalarsThroughTable2_58(base.GetCppThis(), input, output, inputDataType, numberOfValues, inputIncrement, outputFormat);
		}

		// Token: 0x06000B44 RID: 2884
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLookupTable_MapValue_59(HandleRef pThis, double v);

		/// <summary>
		/// Map one value through the lookup table, returning an RBGA[4] color.
		/// </summary>
		// Token: 0x06000B45 RID: 2885 RVA: 0x000172DC File Offset: 0x000154DC
		public override IntPtr MapValue(double v)
		{
			return vtkLookupTable.vtkLookupTable_MapValue_59(base.GetCppThis(), v);
		}

		// Token: 0x06000B46 RID: 2886
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLookupTable_NewInstance_61(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with range=[0,1]; and hsv ranges set up for rainbow color table
		/// (from red to blue).
		/// </summary>
		// Token: 0x06000B47 RID: 2887 RVA: 0x000172FC File Offset: 0x000154FC
		public new vtkLookupTable NewInstance()
		{
			vtkLookupTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLookupTable.vtkLookupTable_NewInstance_61(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLookupTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000B48 RID: 2888
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLookupTable_SafeDownCast_62(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with range=[0,1]; and hsv ranges set up for rainbow color table
		/// (from red to blue).
		/// </summary>
		// Token: 0x06000B49 RID: 2889 RVA: 0x00017358 File Offset: 0x00015558
		public new static vtkLookupTable SafeDownCast(vtkObjectBase o)
		{
			vtkLookupTable vtkLookupTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLookupTable.vtkLookupTable_SafeDownCast_62((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06000B4A RID: 2890
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetAboveRangeColor_63(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		/// <summary>
		/// Set the color to use when a value above the range is
		/// encountered. This is an RGBA 4-tuple of doubles in the range [0, 1].
		/// </summary>
		// Token: 0x06000B4B RID: 2891 RVA: 0x000173D7 File Offset: 0x000155D7
		public virtual void SetAboveRangeColor(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkLookupTable.vtkLookupTable_SetAboveRangeColor_63(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x06000B4C RID: 2892
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetAboveRangeColor_64(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the color to use when a value above the range is
		/// encountered. This is an RGBA 4-tuple of doubles in the range [0, 1].
		/// </summary>
		// Token: 0x06000B4D RID: 2893 RVA: 0x000173EB File Offset: 0x000155EB
		public virtual void SetAboveRangeColor(IntPtr _arg)
		{
			vtkLookupTable.vtkLookupTable_SetAboveRangeColor_64(base.GetCppThis(), _arg);
		}

		// Token: 0x06000B4E RID: 2894
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetAlphaRange_65(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Set the range in alpha (using automatic generation). Alpha ranges from
		/// [0,1].
		/// </summary>
		// Token: 0x06000B4F RID: 2895 RVA: 0x000173FB File Offset: 0x000155FB
		public virtual void SetAlphaRange(double _arg1, double _arg2)
		{
			vtkLookupTable.vtkLookupTable_SetAlphaRange_65(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06000B50 RID: 2896
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetAlphaRange_66(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the range in alpha (using automatic generation). Alpha ranges from
		/// [0,1].
		/// </summary>
		// Token: 0x06000B51 RID: 2897 RVA: 0x0001740C File Offset: 0x0001560C
		public void SetAlphaRange(IntPtr _arg)
		{
			vtkLookupTable.vtkLookupTable_SetAlphaRange_66(base.GetCppThis(), _arg);
		}

		// Token: 0x06000B52 RID: 2898
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetBelowRangeColor_67(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		/// <summary>
		/// Set the color to use when a value below the range is
		/// encountered. This is an RGBA 4-tuple of doubles in the range [0, 1].
		/// </summary>
		// Token: 0x06000B53 RID: 2899 RVA: 0x0001741C File Offset: 0x0001561C
		public virtual void SetBelowRangeColor(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkLookupTable.vtkLookupTable_SetBelowRangeColor_67(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x06000B54 RID: 2900
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetBelowRangeColor_68(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the color to use when a value below the range is
		/// encountered. This is an RGBA 4-tuple of doubles in the range [0, 1].
		/// </summary>
		// Token: 0x06000B55 RID: 2901 RVA: 0x00017430 File Offset: 0x00015630
		public virtual void SetBelowRangeColor(IntPtr _arg)
		{
			vtkLookupTable.vtkLookupTable_SetBelowRangeColor_68(base.GetCppThis(), _arg);
		}

		// Token: 0x06000B56 RID: 2902
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetHueRange_69(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Set the range in hue (using automatic generation). Hue ranges
		/// between [0,1].
		/// </summary>
		// Token: 0x06000B57 RID: 2903 RVA: 0x00017440 File Offset: 0x00015640
		public virtual void SetHueRange(double _arg1, double _arg2)
		{
			vtkLookupTable.vtkLookupTable_SetHueRange_69(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06000B58 RID: 2904
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetHueRange_70(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the range in hue (using automatic generation). Hue ranges
		/// between [0,1].
		/// </summary>
		// Token: 0x06000B59 RID: 2905 RVA: 0x00017451 File Offset: 0x00015651
		public void SetHueRange(IntPtr _arg)
		{
			vtkLookupTable.vtkLookupTable_SetHueRange_70(base.GetCppThis(), _arg);
		}

		// Token: 0x06000B5A RID: 2906
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetNanColor_71(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		/// <summary>
		/// Set the color to use when a NaN (not a number) is encountered.  This is an
		/// RGBA 4-tuple of doubles in the range [0,1].
		/// </summary>
		// Token: 0x06000B5B RID: 2907 RVA: 0x00017461 File Offset: 0x00015661
		public virtual void SetNanColor(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkLookupTable.vtkLookupTable_SetNanColor_71(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x06000B5C RID: 2908
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetNanColor_72(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the color to use when a NaN (not a number) is encountered.  This is an
		/// RGBA 4-tuple of doubles in the range [0,1].
		/// </summary>
		// Token: 0x06000B5D RID: 2909 RVA: 0x00017475 File Offset: 0x00015675
		public virtual void SetNanColor(IntPtr _arg)
		{
			vtkLookupTable.vtkLookupTable_SetNanColor_72(base.GetCppThis(), _arg);
		}

		// Token: 0x06000B5E RID: 2910
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetNumberOfColors_73(HandleRef pThis, long _arg);

		/// <summary>
		/// Set the number of colors in the lookup table.  Use
		/// SetNumberOfTableValues() instead, it can be used both before and
		/// after the table has been built whereas SetNumberOfColors() has no
		/// effect after the table has been built.
		/// </summary>
		// Token: 0x06000B5F RID: 2911 RVA: 0x00017485 File Offset: 0x00015685
		public virtual void SetNumberOfColors(long _arg)
		{
			vtkLookupTable.vtkLookupTable_SetNumberOfColors_73(base.GetCppThis(), _arg);
		}

		// Token: 0x06000B60 RID: 2912
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetNumberOfTableValues_74(HandleRef pThis, long number);

		/// <summary>
		/// Specify the number of values (i.e., colors) in the lookup table.
		/// </summary>
		// Token: 0x06000B61 RID: 2913 RVA: 0x00017495 File Offset: 0x00015695
		public void SetNumberOfTableValues(long number)
		{
			vtkLookupTable.vtkLookupTable_SetNumberOfTableValues_74(base.GetCppThis(), number);
		}

		// Token: 0x06000B62 RID: 2914
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetRamp_75(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the shape of the table ramp to either S-curve, linear, or sqrt.
		/// The default is S-curve, which tails off gradually at either end.
		///
		/// The equation used for the S-curve is y = (sin((x - 1/2)*pi) + 1)/2,
		/// For an S-curve greyscale ramp, you should set NumberOfTableValues
		/// to 402 (which is 256*pi/2) to provide room for the tails of the ramp.
		///
		/// The equation for the linear ramp is simply y = x.
		///
		/// The equation for the SQRT is y = sqrt(x).
		/// </summary>
		// Token: 0x06000B63 RID: 2915 RVA: 0x000174A5 File Offset: 0x000156A5
		public virtual void SetRamp(int _arg)
		{
			vtkLookupTable.vtkLookupTable_SetRamp_75(base.GetCppThis(), _arg);
		}

		// Token: 0x06000B64 RID: 2916
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetRampToLinear_76(HandleRef pThis);

		/// <summary>
		/// Set the shape of the table ramp to either S-curve, linear, or sqrt.
		/// The default is S-curve, which tails off gradually at either end.
		///
		/// The equation used for the S-curve is y = (sin((x - 1/2)*pi) + 1)/2,
		/// For an S-curve greyscale ramp, you should set NumberOfTableValues
		/// to 402 (which is 256*pi/2) to provide room for the tails of the ramp.
		///
		/// The equation for the linear ramp is simply y = x.
		///
		/// The equation for the SQRT is y = sqrt(x).
		/// </summary>
		// Token: 0x06000B65 RID: 2917 RVA: 0x000174B5 File Offset: 0x000156B5
		public void SetRampToLinear()
		{
			vtkLookupTable.vtkLookupTable_SetRampToLinear_76(base.GetCppThis());
		}

		// Token: 0x06000B66 RID: 2918
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetRampToSCurve_77(HandleRef pThis);

		/// <summary>
		/// Set the shape of the table ramp to either S-curve, linear, or sqrt.
		/// The default is S-curve, which tails off gradually at either end.
		///
		/// The equation used for the S-curve is y = (sin((x - 1/2)*pi) + 1)/2,
		/// For an S-curve greyscale ramp, you should set NumberOfTableValues
		/// to 402 (which is 256*pi/2) to provide room for the tails of the ramp.
		///
		/// The equation for the linear ramp is simply y = x.
		///
		/// The equation for the SQRT is y = sqrt(x).
		/// </summary>
		// Token: 0x06000B67 RID: 2919 RVA: 0x000174C4 File Offset: 0x000156C4
		public void SetRampToSCurve()
		{
			vtkLookupTable.vtkLookupTable_SetRampToSCurve_77(base.GetCppThis());
		}

		// Token: 0x06000B68 RID: 2920
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetRampToSQRT_78(HandleRef pThis);

		/// <summary>
		/// Set the shape of the table ramp to either S-curve, linear, or sqrt.
		/// The default is S-curve, which tails off gradually at either end.
		///
		/// The equation used for the S-curve is y = (sin((x - 1/2)*pi) + 1)/2,
		/// For an S-curve greyscale ramp, you should set NumberOfTableValues
		/// to 402 (which is 256*pi/2) to provide room for the tails of the ramp.
		///
		/// The equation for the linear ramp is simply y = x.
		///
		/// The equation for the SQRT is y = sqrt(x).
		/// </summary>
		// Token: 0x06000B69 RID: 2921 RVA: 0x000174D3 File Offset: 0x000156D3
		public void SetRampToSQRT()
		{
			vtkLookupTable.vtkLookupTable_SetRampToSQRT_78(base.GetCppThis());
		}

		// Token: 0x06000B6A RID: 2922
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetRange_79(HandleRef pThis, double min, double max);

		/// <summary>
		/// Sets/Gets the range of scalars which will be mapped.  This is a duplicate
		/// of Get/SetTableRange.
		/// </summary>
		// Token: 0x06000B6B RID: 2923 RVA: 0x000174E2 File Offset: 0x000156E2
		public override void SetRange(double min, double max)
		{
			vtkLookupTable.vtkLookupTable_SetRange_79(base.GetCppThis(), min, max);
		}

		// Token: 0x06000B6C RID: 2924
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetRange_80(HandleRef pThis, IntPtr rng);

		/// <summary>
		/// Sets/Gets the range of scalars which will be mapped.  This is a duplicate
		/// of Get/SetTableRange.
		/// </summary>
		// Token: 0x06000B6D RID: 2925 RVA: 0x000174F3 File Offset: 0x000156F3
		public override void SetRange(IntPtr rng)
		{
			vtkLookupTable.vtkLookupTable_SetRange_80(base.GetCppThis(), rng);
		}

		// Token: 0x06000B6E RID: 2926
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetSaturationRange_81(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Set the range in saturation (using automatic generation). Saturation
		/// ranges between [0,1].
		/// </summary>
		// Token: 0x06000B6F RID: 2927 RVA: 0x00017503 File Offset: 0x00015703
		public virtual void SetSaturationRange(double _arg1, double _arg2)
		{
			vtkLookupTable.vtkLookupTable_SetSaturationRange_81(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06000B70 RID: 2928
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetSaturationRange_82(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the range in saturation (using automatic generation). Saturation
		/// ranges between [0,1].
		/// </summary>
		// Token: 0x06000B71 RID: 2929 RVA: 0x00017514 File Offset: 0x00015714
		public void SetSaturationRange(IntPtr _arg)
		{
			vtkLookupTable.vtkLookupTable_SetSaturationRange_82(base.GetCppThis(), _arg);
		}

		// Token: 0x06000B72 RID: 2930
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetScale_83(HandleRef pThis, int scale);

		/// <summary>
		/// Set the type of scale to use, linear or logarithmic.  The default
		/// is linear.  If the scale is logarithmic, then the TableRange must not
		/// cross the value zero.
		/// </summary>
		// Token: 0x06000B73 RID: 2931 RVA: 0x00017524 File Offset: 0x00015724
		public void SetScale(int scale)
		{
			vtkLookupTable.vtkLookupTable_SetScale_83(base.GetCppThis(), scale);
		}

		// Token: 0x06000B74 RID: 2932
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetScaleToLinear_84(HandleRef pThis);

		/// <summary>
		/// Set the type of scale to use, linear or logarithmic.  The default
		/// is linear.  If the scale is logarithmic, then the TableRange must not
		/// cross the value zero.
		/// </summary>
		// Token: 0x06000B75 RID: 2933 RVA: 0x00017534 File Offset: 0x00015734
		public void SetScaleToLinear()
		{
			vtkLookupTable.vtkLookupTable_SetScaleToLinear_84(base.GetCppThis());
		}

		// Token: 0x06000B76 RID: 2934
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetScaleToLog10_85(HandleRef pThis);

		/// <summary>
		/// Set the type of scale to use, linear or logarithmic.  The default
		/// is linear.  If the scale is logarithmic, then the TableRange must not
		/// cross the value zero.
		/// </summary>
		// Token: 0x06000B77 RID: 2935 RVA: 0x00017543 File Offset: 0x00015743
		public void SetScaleToLog10()
		{
			vtkLookupTable.vtkLookupTable_SetScaleToLog10_85(base.GetCppThis());
		}

		// Token: 0x06000B78 RID: 2936
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetTable_86(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the internal table array that is used to map the scalars
		/// to colors.  The table array is an unsigned char array with 4
		/// components representing RGBA.
		/// </summary>
		// Token: 0x06000B79 RID: 2937 RVA: 0x00017554 File Offset: 0x00015754
		public void SetTable(vtkUnsignedCharArray arg0)
		{
			vtkLookupTable.vtkLookupTable_SetTable_86(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06000B7A RID: 2938
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetTableRange_87(HandleRef pThis, IntPtr r);

		/// <summary>
		/// Set/Get the minimum/maximum scalar values for scalar mapping. Scalar
		/// values less than minimum range value are clamped to minimum range value.
		/// Scalar values greater than maximum range value are clamped to maximum
		/// range value.
		///
		/// The \a TableRange values are only used when \a IndexedLookup is false.
		/// </summary>
		// Token: 0x06000B7B RID: 2939 RVA: 0x00017583 File Offset: 0x00015783
		public virtual void SetTableRange(IntPtr r)
		{
			vtkLookupTable.vtkLookupTable_SetTableRange_87(base.GetCppThis(), r);
		}

		// Token: 0x06000B7C RID: 2940
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetTableRange_88(HandleRef pThis, double min, double max);

		/// <summary>
		/// Set/Get the minimum/maximum scalar values for scalar mapping. Scalar
		/// values less than minimum range value are clamped to minimum range value.
		/// Scalar values greater than maximum range value are clamped to maximum
		/// range value.
		///
		/// The \a TableRange values are only used when \a IndexedLookup is false.
		/// </summary>
		// Token: 0x06000B7D RID: 2941 RVA: 0x00017593 File Offset: 0x00015793
		public virtual void SetTableRange(double min, double max)
		{
			vtkLookupTable.vtkLookupTable_SetTableRange_88(base.GetCppThis(), min, max);
		}

		// Token: 0x06000B7E RID: 2942
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetTableValue_89(HandleRef pThis, long indx, IntPtr rgba);

		/// <summary>
		/// Directly load color into lookup table. Use [0,1] double values for color
		/// component specification. Make sure that you've either used the
		/// Build() method or used SetNumberOfTableValues() prior to using this
		/// method.
		/// </summary>
		// Token: 0x06000B7F RID: 2943 RVA: 0x000175A4 File Offset: 0x000157A4
		public virtual void SetTableValue(long indx, IntPtr rgba)
		{
			vtkLookupTable.vtkLookupTable_SetTableValue_89(base.GetCppThis(), indx, rgba);
		}

		// Token: 0x06000B80 RID: 2944
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetTableValue_90(HandleRef pThis, long indx, double r, double g, double b, double a);

		/// <summary>
		/// Directly load color into lookup table. Use [0,1] double values for color
		/// component specification. Alpha defaults to 1 if unspecified.
		/// </summary>
		// Token: 0x06000B81 RID: 2945 RVA: 0x000175B5 File Offset: 0x000157B5
		public virtual void SetTableValue(long indx, double r, double g, double b, double a)
		{
			vtkLookupTable.vtkLookupTable_SetTableValue_90(base.GetCppThis(), indx, r, g, b, a);
		}

		// Token: 0x06000B82 RID: 2946
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetUseAboveRangeColor_91(HandleRef pThis, int _arg);

		/// <summary>
		/// Set whether the above range color should be used.
		/// </summary>
		// Token: 0x06000B83 RID: 2947 RVA: 0x000175CB File Offset: 0x000157CB
		public virtual void SetUseAboveRangeColor(int _arg)
		{
			vtkLookupTable.vtkLookupTable_SetUseAboveRangeColor_91(base.GetCppThis(), _arg);
		}

		// Token: 0x06000B84 RID: 2948
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetUseBelowRangeColor_92(HandleRef pThis, int _arg);

		/// <summary>
		/// Set whether the below range color should be used.
		/// </summary>
		// Token: 0x06000B85 RID: 2949 RVA: 0x000175DB File Offset: 0x000157DB
		public virtual void SetUseBelowRangeColor(int _arg)
		{
			vtkLookupTable.vtkLookupTable_SetUseBelowRangeColor_92(base.GetCppThis(), _arg);
		}

		// Token: 0x06000B86 RID: 2950
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetValueRange_93(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Set the range in value (using automatic generation). Value ranges
		/// between [0,1].
		/// </summary>
		// Token: 0x06000B87 RID: 2951 RVA: 0x000175EB File Offset: 0x000157EB
		public virtual void SetValueRange(double _arg1, double _arg2)
		{
			vtkLookupTable.vtkLookupTable_SetValueRange_93(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06000B88 RID: 2952
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_SetValueRange_94(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the range in value (using automatic generation). Value ranges
		/// between [0,1].
		/// </summary>
		// Token: 0x06000B89 RID: 2953 RVA: 0x000175FC File Offset: 0x000157FC
		public void SetValueRange(IntPtr _arg)
		{
			vtkLookupTable.vtkLookupTable_SetValueRange_94(base.GetCppThis(), _arg);
		}

		// Token: 0x06000B8A RID: 2954
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_UseAboveRangeColorOff_95(HandleRef pThis);

		/// <summary>
		/// Set whether the above range color should be used.
		/// </summary>
		// Token: 0x06000B8B RID: 2955 RVA: 0x0001760C File Offset: 0x0001580C
		public virtual void UseAboveRangeColorOff()
		{
			vtkLookupTable.vtkLookupTable_UseAboveRangeColorOff_95(base.GetCppThis());
		}

		// Token: 0x06000B8C RID: 2956
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_UseAboveRangeColorOn_96(HandleRef pThis);

		/// <summary>
		/// Set whether the above range color should be used.
		/// </summary>
		// Token: 0x06000B8D RID: 2957 RVA: 0x0001761B File Offset: 0x0001581B
		public virtual void UseAboveRangeColorOn()
		{
			vtkLookupTable.vtkLookupTable_UseAboveRangeColorOn_96(base.GetCppThis());
		}

		// Token: 0x06000B8E RID: 2958
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_UseBelowRangeColorOff_97(HandleRef pThis);

		/// <summary>
		/// Set whether the below range color should be used.
		/// </summary>
		// Token: 0x06000B8F RID: 2959 RVA: 0x0001762A File Offset: 0x0001582A
		public virtual void UseBelowRangeColorOff()
		{
			vtkLookupTable.vtkLookupTable_UseBelowRangeColorOff_97(base.GetCppThis());
		}

		// Token: 0x06000B90 RID: 2960
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTable_UseBelowRangeColorOn_98(HandleRef pThis);

		/// <summary>
		/// Set whether the below range color should be used.
		/// </summary>
		// Token: 0x06000B91 RID: 2961 RVA: 0x00017639 File Offset: 0x00015839
		public virtual void UseBelowRangeColorOn()
		{
			vtkLookupTable.vtkLookupTable_UseBelowRangeColorOn_98(base.GetCppThis());
		}

		// Token: 0x06000B92 RID: 2962
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLookupTable_UsingLogScale_99(HandleRef pThis);

		/// <summary>
		/// This should return 1 if the subclass is using log scale for mapping scalars
		/// to colors. Returns 1 is scale == VTK_SCALE_LOG10.
		/// </summary>
		// Token: 0x06000B93 RID: 2963 RVA: 0x00017648 File Offset: 0x00015848
		public override int UsingLogScale()
		{
			return vtkLookupTable.vtkLookupTable_UsingLogScale_99(base.GetCppThis());
		}

		// Token: 0x06000B94 RID: 2964
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLookupTable_WritePointer_100(HandleRef pThis, long id, int number);

		/// <summary>
		/// Get pointer to data. Useful for direct writes into object. MaxId is bumped
		/// by number (and memory allocated if necessary). Id is the location you
		/// wish to write into; number is the number of rgba values to write.
		///
		/// \warning If you modify the table data via the pointer returned by this
		/// member function, you must call vtkLookupTable::BuildSpecialColors()
		/// afterwards to ensure that the special colors (below/above range and NaN
		/// value) are up-to-date.
		/// </summary>
		// Token: 0x06000B95 RID: 2965 RVA: 0x00017668 File Offset: 0x00015868
		public IntPtr WritePointer(long id, int number)
		{
			return vtkLookupTable.vtkLookupTable_WritePointer_100(base.GetCppThis(), id, number);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040003AD RID: 941
		public new const string MRFullTypeName = "Kitware.VTK.vtkLookupTable";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040003AE RID: 942
		public new static readonly string MRClassNameKey = "class vtkLookupTable";
	}
}
