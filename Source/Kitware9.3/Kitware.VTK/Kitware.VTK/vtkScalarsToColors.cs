using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkScalarsToColors
	/// </summary>
	/// <remarks>
	///    Superclass for mapping scalar values to colors
	///
	/// vtkScalarsToColors is a general-purpose base class for objects that
	/// convert scalars to colors. This include vtkLookupTable classes and
	/// color transfer functions.  By itself, this class will simply rescale
	/// the scalars.
	///
	/// The scalar-to-color mapping can be augmented with an additional
	/// uniform alpha blend. This is used, for example, to blend a vtkActor's
	/// opacity with the lookup table values.
	///
	/// Specific scalar values may be annotated with text strings that will
	/// be included in color legends using \a SetAnnotations, \a SetAnnotation,
	/// \a GetNumberOfAnnotatedValues, \a GetAnnotatedValue, \a GetAnnotation,
	/// \a RemoveAnnotation, and \a ResetAnnotations.
	///
	/// This class also has a method for indicating that the set of
	/// annotated values form a categorical color map; by setting \a
	/// IndexedLookup to true, you indicate that the annotated values are
	/// the only valid values for which entries in the color table should
	/// be returned. In this mode, subclasses should then assign colors to
	/// annotated values by taking the modulus of an annotated value's
	/// index in the list of annotations with the number of colors in the
	/// table.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkLookupTable vtkColorTransferFunction
	/// </seealso>
	// Token: 0x0200003C RID: 60
	public class vtkScalarsToColors : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000A4C RID: 2636 RVA: 0x00015EFF File Offset: 0x000140FF
		static vtkScalarsToColors()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkScalarsToColors.MRClassNameKey, Type.GetType("Kitware.VTK.vtkScalarsToColors"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000A4D RID: 2637 RVA: 0x00015F27 File Offset: 0x00014127
		public vtkScalarsToColors(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06000A4E RID: 2638
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarsToColors_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000A4F RID: 2639 RVA: 0x00015F38 File Offset: 0x00014138
		public new static vtkScalarsToColors New()
		{
			vtkScalarsToColors result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarsToColors.vtkScalarsToColors_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000A50 RID: 2640 RVA: 0x00015F8C File Offset: 0x0001418C
		public vtkScalarsToColors() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkScalarsToColors.vtkScalarsToColors_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000A51 RID: 2641 RVA: 0x00015FD0 File Offset: 0x000141D0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000A52 RID: 2642
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColors_Build_01(HandleRef pThis);

		/// <summary>
		/// Perform any processing required (if any) before processing
		/// scalars. Default implementation does nothing.
		/// </summary>
		// Token: 0x06000A53 RID: 2643 RVA: 0x00015FDB File Offset: 0x000141DB
		public virtual void Build()
		{
			vtkScalarsToColors.vtkScalarsToColors_Build_01(base.GetCppThis());
		}

		// Token: 0x06000A54 RID: 2644
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkScalarsToColors_ColorToUChar_02(double t);

		/// <summary>
		/// Specializations of vtkScalarsToColors::ColorToUChar
		/// Converts from a color in a floating point type in range 0.0-1.0 to a uchar
		/// in range 0-255.
		/// </summary>
		// Token: 0x06000A55 RID: 2645 RVA: 0x00015FEC File Offset: 0x000141EC
		public static byte ColorToUChar(double t)
		{
			return vtkScalarsToColors.vtkScalarsToColors_ColorToUChar_02(t);
		}

		// Token: 0x06000A56 RID: 2646
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkScalarsToColors_ColorToUChar_03(float t);

		/// <summary>
		/// Specializations of vtkScalarsToColors::ColorToUChar
		/// Converts from a color in a floating point type in range 0.0-1.0 to a uchar
		/// in range 0-255.
		/// </summary>
		// Token: 0x06000A57 RID: 2647 RVA: 0x00016008 File Offset: 0x00014208
		public static byte ColorToUChar(float t)
		{
			return vtkScalarsToColors.vtkScalarsToColors_ColorToUChar_03(t);
		}

		// Token: 0x06000A58 RID: 2648
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColors_DeepCopy_04(HandleRef pThis, HandleRef o);

		/// <summary>
		/// Copy the contents from another object.
		/// </summary>
		// Token: 0x06000A59 RID: 2649 RVA: 0x00016024 File Offset: 0x00014224
		public virtual void DeepCopy(vtkScalarsToColors o)
		{
			vtkScalarsToColors.vtkScalarsToColors_DeepCopy_04(base.GetCppThis(), (o == null) ? default(HandleRef) : o.GetCppThis());
		}

		// Token: 0x06000A5A RID: 2650
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkScalarsToColors_GetAlpha_05(HandleRef pThis);

		/// <summary>
		/// Specify an additional opacity (alpha) value to blend with. Values
		/// != 1 modify the resulting color consistent with the requested
		/// form of the output. This is typically used by an actor in order to
		/// blend its opacity. Value is clamped between 0 and 1.
		/// </summary>
		// Token: 0x06000A5B RID: 2651 RVA: 0x00016054 File Offset: 0x00014254
		public virtual double GetAlpha()
		{
			return vtkScalarsToColors.vtkScalarsToColors_GetAlpha_05(base.GetCppThis());
		}

		// Token: 0x06000A5C RID: 2652
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarsToColors_GetAnnotatedValue_06(HandleRef pThis, long idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the annotated value at a particular index in the list of annotations.
		/// If there are no annotations, or \p idx is out-of-range, returns a default/invalid vtkVariant.
		/// </summary>
		// Token: 0x06000A5D RID: 2653 RVA: 0x00016074 File Offset: 0x00014274
		public vtkVariant GetAnnotatedValue(long idx)
		{
			vtkVariant result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarsToColors.vtkScalarsToColors_GetAnnotatedValue_06(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000A5E RID: 2654
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScalarsToColors_GetAnnotatedValueIndex_07(HandleRef pThis, HandleRef val);

		/// <summary>
		/// Return the index of the given value in the list of annotated values (or -1 if not present).
		/// </summary>
		// Token: 0x06000A5F RID: 2655 RVA: 0x000160D0 File Offset: 0x000142D0
		public long GetAnnotatedValueIndex(vtkVariant val)
		{
			return vtkScalarsToColors.vtkScalarsToColors_GetAnnotatedValueIndex_07(base.GetCppThis(), (val == null) ? default(HandleRef) : val.GetCppThis());
		}

		// Token: 0x06000A60 RID: 2656
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScalarsToColors_GetAnnotatedValueIndexInternal_08(HandleRef pThis, HandleRef val);

		/// <summary>
		/// Look up an index into the array of annotations given a
		/// value. Does no pointer checks. Returns -1 when \p val not
		/// present.
		/// </summary>
		// Token: 0x06000A61 RID: 2657 RVA: 0x00016104 File Offset: 0x00014304
		public long GetAnnotatedValueIndexInternal(vtkVariant val)
		{
			return vtkScalarsToColors.vtkScalarsToColors_GetAnnotatedValueIndexInternal_08(base.GetCppThis(), (val == null) ? default(HandleRef) : val.GetCppThis());
		}

		// Token: 0x06000A62 RID: 2658
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarsToColors_GetAnnotatedValues_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set a list of discrete values, either
		/// as a categorical set of values (when IndexedLookup is true) or
		/// as a set of annotations to add to a scalar array (when IndexedLookup is false).
		/// The two arrays must both either be nullptr or of the same length or
		/// the call will be ignored.
		///
		/// Note that these arrays are deep copied rather than being used directly
		/// in order to support the use case where edits are made. If the
		/// \a values and \a annotations arrays were held by this class then each
		/// call to map scalar values to colors would require us to check the MTime
		/// of the arrays.
		/// </summary>
		// Token: 0x06000A63 RID: 2659 RVA: 0x00016138 File Offset: 0x00014338
		public virtual vtkAbstractArray GetAnnotatedValues()
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarsToColors.vtkScalarsToColors_GetAnnotatedValues_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractArray = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractArray.Register(null);
				}
			}
			return vtkAbstractArray;
		}

		// Token: 0x06000A64 RID: 2660
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkScalarsToColors_GetAnnotation_10(HandleRef pThis, long idx);

		/// <summary>
		/// Return the annotation at a particular index in the list of annotations.
		/// If there are no annotations, or \p idx is out-of-range, returns an empty string.
		/// </summary>
		// Token: 0x06000A65 RID: 2661 RVA: 0x000161A8 File Offset: 0x000143A8
		public string GetAnnotation(long idx)
		{
			return vtkScalarsToColors.vtkScalarsToColors_GetAnnotation_10(base.GetCppThis(), idx);
		}

		// Token: 0x06000A66 RID: 2662
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColors_GetAnnotationColor_11(HandleRef pThis, HandleRef val, IntPtr rgba);

		/// <summary>
		/// Obtain the color associated with a particular annotated value (or NanColor if unmatched).
		/// </summary>
		// Token: 0x06000A67 RID: 2663 RVA: 0x000161C8 File Offset: 0x000143C8
		public virtual void GetAnnotationColor(vtkVariant val, IntPtr rgba)
		{
			vtkScalarsToColors.vtkScalarsToColors_GetAnnotationColor_11(base.GetCppThis(), (val == null) ? default(HandleRef) : val.GetCppThis(), rgba);
		}

		// Token: 0x06000A68 RID: 2664
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarsToColors_GetAnnotations_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set a list of discrete values, either
		/// as a categorical set of values (when IndexedLookup is true) or
		/// as a set of annotations to add to a scalar array (when IndexedLookup is false).
		/// The two arrays must both either be nullptr or of the same length or
		/// the call will be ignored.
		///
		/// Note that these arrays are deep copied rather than being used directly
		/// in order to support the use case where edits are made. If the
		/// \a values and \a annotations arrays were held by this class then each
		/// call to map scalar values to colors would require us to check the MTime
		/// of the arrays.
		/// </summary>
		// Token: 0x06000A69 RID: 2665 RVA: 0x000161F8 File Offset: 0x000143F8
		public virtual vtkStringArray GetAnnotations()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarsToColors.vtkScalarsToColors_GetAnnotations_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		// Token: 0x06000A6A RID: 2666
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColors_GetColor_13(HandleRef pThis, double v, IntPtr rgb);

		/// <summary>
		/// Map one value through the lookup table and store the color as
		/// an RGB array of doubles between 0 and 1 in the \a rgb argument.
		/// </summary>
		// Token: 0x06000A6B RID: 2667 RVA: 0x00016267 File Offset: 0x00014467
		public virtual void GetColor(double v, IntPtr rgb)
		{
			vtkScalarsToColors.vtkScalarsToColors_GetColor_13(base.GetCppThis(), v, rgb);
		}

		// Token: 0x06000A6C RID: 2668
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarsToColors_GetColor_14(HandleRef pThis, double v);

		/// <summary>
		/// Map one value through the lookup table and return the color as
		/// an RGB array of doubles between 0 and 1.
		/// </summary>
		// Token: 0x06000A6D RID: 2669 RVA: 0x00016278 File Offset: 0x00014478
		public double[] GetColor(double v)
		{
			IntPtr intPtr = vtkScalarsToColors.vtkScalarsToColors_GetColor_14(base.GetCppThis(), v);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06000A6E RID: 2670
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColors_GetIndexedColor_15(HandleRef pThis, long i, IntPtr rgba);

		/// <summary>
		/// Get the "indexed color" assigned to an index.
		///
		/// The index is used in \a IndexedLookup mode to assign colors to annotations (in the order
		/// the annotations were set).
		/// Subclasses must implement this and interpret how to treat the index.
		/// vtkLookupTable simply returns GetTableValue(\a index % \a this-&gt;GetNumberOfTableValues()).
		/// vtkColorTransferFunction returns the color associated with node \a index % \a this-&gt;GetSize().
		///
		/// Note that implementations *must* set the opacity (alpha) component of the color, even if they
		/// do not provide opacity values in their colormaps. In that case, alpha = 1.0 should be used.
		/// </summary>
		// Token: 0x06000A6F RID: 2671 RVA: 0x000162C1 File Offset: 0x000144C1
		public virtual void GetIndexedColor(long i, IntPtr rgba)
		{
			vtkScalarsToColors.vtkScalarsToColors_GetIndexedColor_15(base.GetCppThis(), i, rgba);
		}

		// Token: 0x06000A70 RID: 2672
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarsToColors_GetIndexedLookup_16(HandleRef pThis);

		/// <summary>
		/// Set/get whether the lookup table is for categorical or ordinal data.
		/// The default is ordinal data; values not present in the lookup table
		/// will be assigned an interpolated color.
		///
		/// When categorical data is present, only values in the lookup table will be
		/// considered valid; all other values will be assigned \a NanColor.
		/// </summary>
		// Token: 0x06000A71 RID: 2673 RVA: 0x000162D4 File Offset: 0x000144D4
		public virtual int GetIndexedLookup()
		{
			return vtkScalarsToColors.vtkScalarsToColors_GetIndexedLookup_16(base.GetCppThis());
		}

		// Token: 0x06000A72 RID: 2674
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkScalarsToColors_GetLuminance_17(HandleRef pThis, double x);

		/// <summary>
		/// Map one value through the lookup table and return the luminance
		/// 0.3*red + 0.59*green + 0.11*blue as a double between 0 and 1.
		/// Returns the luminance value for the specified scalar value.
		/// </summary>
		// Token: 0x06000A73 RID: 2675 RVA: 0x000162F4 File Offset: 0x000144F4
		public double GetLuminance(double x)
		{
			return vtkScalarsToColors.vtkScalarsToColors_GetLuminance_17(base.GetCppThis(), x);
		}

		// Token: 0x06000A74 RID: 2676
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScalarsToColors_GetNumberOfAnnotatedValues_18(HandleRef pThis);

		/// <summary>
		/// Return the annotated value at a particular index in the list of annotations.
		/// </summary>
		// Token: 0x06000A75 RID: 2677 RVA: 0x00016314 File Offset: 0x00014514
		public long GetNumberOfAnnotatedValues()
		{
			return vtkScalarsToColors.vtkScalarsToColors_GetNumberOfAnnotatedValues_18(base.GetCppThis());
		}

		// Token: 0x06000A76 RID: 2678
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScalarsToColors_GetNumberOfAvailableColors_19(HandleRef pThis);

		/// <summary>
		/// Get the number of available colors for mapping to.
		/// </summary>
		// Token: 0x06000A77 RID: 2679 RVA: 0x00016334 File Offset: 0x00014534
		public virtual long GetNumberOfAvailableColors()
		{
			return vtkScalarsToColors.vtkScalarsToColors_GetNumberOfAvailableColors_19(base.GetCppThis());
		}

		// Token: 0x06000A78 RID: 2680
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScalarsToColors_GetNumberOfGenerationsFromBase_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000A79 RID: 2681 RVA: 0x00016354 File Offset: 0x00014554
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkScalarsToColors.vtkScalarsToColors_GetNumberOfGenerationsFromBase_20(base.GetCppThis(), type);
		}

		// Token: 0x06000A7A RID: 2682
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScalarsToColors_GetNumberOfGenerationsFromBaseType_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000A7B RID: 2683 RVA: 0x00016374 File Offset: 0x00014574
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkScalarsToColors.vtkScalarsToColors_GetNumberOfGenerationsFromBaseType_21(type);
		}

		// Token: 0x06000A7C RID: 2684
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkScalarsToColors_GetOpacity_22(HandleRef pThis, double v);

		/// <summary>
		/// Map one value through the lookup table and return the alpha value
		/// (the opacity) as a double between 0 and 1. This implementation
		/// always returns 1.
		/// </summary>
		// Token: 0x06000A7D RID: 2685 RVA: 0x00016390 File Offset: 0x00014590
		public virtual double GetOpacity(double v)
		{
			return vtkScalarsToColors.vtkScalarsToColors_GetOpacity_22(base.GetCppThis(), v);
		}

		// Token: 0x06000A7E RID: 2686
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarsToColors_GetRange_23(HandleRef pThis);

		/// <summary>
		/// Sets/Gets the range of scalars that will be mapped.
		/// </summary>
		// Token: 0x06000A7F RID: 2687 RVA: 0x000163B0 File Offset: 0x000145B0
		public virtual double[] GetRange()
		{
			IntPtr intPtr = vtkScalarsToColors.vtkScalarsToColors_GetRange_23(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06000A80 RID: 2688
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarsToColors_GetVectorComponent_24(HandleRef pThis);

		/// <summary>
		/// If the mapper does not select which component of a vector
		/// to map to colors, you can specify it here.
		/// </summary>
		// Token: 0x06000A81 RID: 2689 RVA: 0x000163F8 File Offset: 0x000145F8
		public virtual int GetVectorComponent()
		{
			return vtkScalarsToColors.vtkScalarsToColors_GetVectorComponent_24(base.GetCppThis());
		}

		// Token: 0x06000A82 RID: 2690
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarsToColors_GetVectorMode_25(HandleRef pThis);

		/// <summary>
		/// Change mode that maps vectors by magnitude vs. component.
		/// If the mode is "RGBColors", then the vectors components are
		/// scaled to the range and passed directly as the colors.
		/// </summary>
		// Token: 0x06000A83 RID: 2691 RVA: 0x00016418 File Offset: 0x00014618
		public virtual int GetVectorMode()
		{
			return vtkScalarsToColors.vtkScalarsToColors_GetVectorMode_25(base.GetCppThis());
		}

		// Token: 0x06000A84 RID: 2692
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarsToColors_GetVectorSize_26(HandleRef pThis);

		/// <summary>
		/// When mapping vectors, consider only the number of components selected
		/// by VectorSize to be part of the vector, and ignore any other
		/// components.  Set to -1 to map all components.  If this is not set
		/// to -1, then you can use SetVectorComponent to set which scalar
		/// component will be the first component in the vector to be mapped.
		/// </summary>
		// Token: 0x06000A85 RID: 2693 RVA: 0x00016438 File Offset: 0x00014638
		public virtual int GetVectorSize()
		{
			return vtkScalarsToColors.vtkScalarsToColors_GetVectorSize_26(base.GetCppThis());
		}

		// Token: 0x06000A86 RID: 2694
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColors_IndexedLookupOff_27(HandleRef pThis);

		/// <summary>
		/// Set/get whether the lookup table is for categorical or ordinal data.
		/// The default is ordinal data; values not present in the lookup table
		/// will be assigned an interpolated color.
		///
		/// When categorical data is present, only values in the lookup table will be
		/// considered valid; all other values will be assigned \a NanColor.
		/// </summary>
		// Token: 0x06000A87 RID: 2695 RVA: 0x00016457 File Offset: 0x00014657
		public virtual void IndexedLookupOff()
		{
			vtkScalarsToColors.vtkScalarsToColors_IndexedLookupOff_27(base.GetCppThis());
		}

		// Token: 0x06000A88 RID: 2696
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColors_IndexedLookupOn_28(HandleRef pThis);

		/// <summary>
		/// Set/get whether the lookup table is for categorical or ordinal data.
		/// The default is ordinal data; values not present in the lookup table
		/// will be assigned an interpolated color.
		///
		/// When categorical data is present, only values in the lookup table will be
		/// considered valid; all other values will be assigned \a NanColor.
		/// </summary>
		// Token: 0x06000A89 RID: 2697 RVA: 0x00016466 File Offset: 0x00014666
		public virtual void IndexedLookupOn()
		{
			vtkScalarsToColors.vtkScalarsToColors_IndexedLookupOn_28(base.GetCppThis());
		}

		// Token: 0x06000A8A RID: 2698
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarsToColors_IsA_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000A8B RID: 2699 RVA: 0x00016478 File Offset: 0x00014678
		public override int IsA(string type)
		{
			return vtkScalarsToColors.vtkScalarsToColors_IsA_29(base.GetCppThis(), type);
		}

		// Token: 0x06000A8C RID: 2700
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarsToColors_IsOpaque_30(HandleRef pThis);

		/// <summary>
		/// Return true if all of the values defining the mapping have an opacity
		/// equal to 1. Default implementation returns true. The more complex
		/// signature will yield more accurate results.
		/// </summary>
		// Token: 0x06000A8D RID: 2701 RVA: 0x00016498 File Offset: 0x00014698
		public virtual int IsOpaque()
		{
			return vtkScalarsToColors.vtkScalarsToColors_IsOpaque_30(base.GetCppThis());
		}

		// Token: 0x06000A8E RID: 2702
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarsToColors_IsOpaque_31(HandleRef pThis, HandleRef scalars, int colorMode, int component);

		/// <summary>
		/// Return true if all of the values defining the mapping have an opacity
		/// equal to 1. Default implementation returns true. The more complex
		/// signature will yield more accurate results.
		/// </summary>
		// Token: 0x06000A8F RID: 2703 RVA: 0x000164B8 File Offset: 0x000146B8
		public virtual int IsOpaque(vtkAbstractArray scalars, int colorMode, int component)
		{
			return vtkScalarsToColors.vtkScalarsToColors_IsOpaque_31(base.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis(), colorMode, component);
		}

		// Token: 0x06000A90 RID: 2704
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarsToColors_IsOpaque_32(HandleRef pThis, HandleRef scalars, int colorMode, int component, HandleRef ghosts, byte ghostsToSkip);

		/// <summary>
		/// Return true if all of the values defining the mapping have an opacity
		/// equal to 1. Default implementation returns true. The more complex
		/// signature will yield more accurate results.
		/// </summary>
		// Token: 0x06000A91 RID: 2705 RVA: 0x000164F0 File Offset: 0x000146F0
		public virtual int IsOpaque(vtkAbstractArray scalars, int colorMode, int component, vtkUnsignedCharArray ghosts, byte ghostsToSkip)
		{
			return vtkScalarsToColors.vtkScalarsToColors_IsOpaque_32(base.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis(), colorMode, component, (ghosts == null) ? default(HandleRef) : ghosts.GetCppThis(), ghostsToSkip);
		}

		// Token: 0x06000A92 RID: 2706
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarsToColors_IsTypeOf_33([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000A93 RID: 2707 RVA: 0x00016540 File Offset: 0x00014740
		public new static int IsTypeOf(string type)
		{
			return vtkScalarsToColors.vtkScalarsToColors_IsTypeOf_33(type);
		}

		// Token: 0x06000A94 RID: 2708
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarsToColors_MapScalars_34(HandleRef pThis, HandleRef scalars, int colorMode, int component, int outputFormat, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Internal methods that map a data array into an unsigned char array.
		/// The output format can be set to VTK_RGBA (4 components),
		/// VTK_RGB (3 components), VTK_LUMINANCE (1 component, greyscale),
		/// or VTK_LUMINANCE_ALPHA (2 components).
		/// If not supplied, the output format defaults to RGBA.
		/// The color mode determines the behavior of mapping.
		/// If VTK_COLOR_MODE_DEFAULT is set, then unsigned char data arrays are
		/// treated as colors (and converted to RGBA if necessary);
		/// If VTK_COLOR_MODE_DIRECT_SCALARS is set, then all arrays are treated as
		/// colors (integer types are clamped in the range 0-255, floating point
		/// arrays are clamped in the range 0.0-1.0. Note 'char' does not have enough
		/// values to represent a color so mapping this type is considered an error);
		/// otherwise, the data is mapped through this instance of ScalarsToColors.
		/// The component argument is used for data arrays with more than one
		/// component; it indicates which component to use to do the blending.
		/// When the component argument is -1, then the this object uses its own
		/// selected technique to change a vector into a scalar to map.
		/// </summary>
		// Token: 0x06000A95 RID: 2709 RVA: 0x0001655C File Offset: 0x0001475C
		public virtual vtkUnsignedCharArray MapScalars(vtkDataArray scalars, int colorMode, int component, int outputFormat)
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarsToColors.vtkScalarsToColors_MapScalars_34(base.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis(), colorMode, component, outputFormat, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06000A96 RID: 2710
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarsToColors_MapScalars_35(HandleRef pThis, HandleRef scalars, int colorMode, int component, int outputFormat, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Internal methods that map a data array into an unsigned char array.
		/// The output format can be set to VTK_RGBA (4 components),
		/// VTK_RGB (3 components), VTK_LUMINANCE (1 component, greyscale),
		/// or VTK_LUMINANCE_ALPHA (2 components).
		/// If not supplied, the output format defaults to RGBA.
		/// The color mode determines the behavior of mapping.
		/// If VTK_COLOR_MODE_DEFAULT is set, then unsigned char data arrays are
		/// treated as colors (and converted to RGBA if necessary);
		/// If VTK_COLOR_MODE_DIRECT_SCALARS is set, then all arrays are treated as
		/// colors (integer types are clamped in the range 0-255, floating point
		/// arrays are clamped in the range 0.0-1.0. Note 'char' does not have enough
		/// values to represent a color so mapping this type is considered an error);
		/// otherwise, the data is mapped through this instance of ScalarsToColors.
		/// The component argument is used for data arrays with more than one
		/// component; it indicates which component to use to do the blending.
		/// When the component argument is -1, then the this object uses its own
		/// selected technique to change a vector into a scalar to map.
		/// </summary>
		// Token: 0x06000A97 RID: 2711 RVA: 0x000165E8 File Offset: 0x000147E8
		public virtual vtkUnsignedCharArray MapScalars(vtkAbstractArray scalars, int colorMode, int component, int outputFormat)
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarsToColors.vtkScalarsToColors_MapScalars_35(base.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis(), colorMode, component, outputFormat, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06000A98 RID: 2712
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColors_MapScalarsThroughTable_36(HandleRef pThis, HandleRef scalars, IntPtr output, int outputFormat);

		/// <summary>
		/// Map a set of scalars through the lookup table in a single operation.
		/// This method ignores the VectorMode and the VectorComponent.
		/// The output format can be set to VTK_RGBA (4 components),
		/// VTK_RGB (3 components), VTK_LUMINANCE (1 component, greyscale),
		/// or VTK_LUMINANCE_ALPHA (2 components)
		/// If not supplied, the output format defaults to RGBA.
		/// </summary>
		// Token: 0x06000A99 RID: 2713 RVA: 0x00016674 File Offset: 0x00014874
		public void MapScalarsThroughTable(vtkDataArray scalars, IntPtr output, int outputFormat)
		{
			vtkScalarsToColors.vtkScalarsToColors_MapScalarsThroughTable_36(base.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis(), output, outputFormat);
		}

		// Token: 0x06000A9A RID: 2714
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColors_MapScalarsThroughTable_37(HandleRef pThis, HandleRef scalars, IntPtr output);

		/// <summary>
		/// Map a set of scalars through the lookup table in a single operation.
		/// This method ignores the VectorMode and the VectorComponent.
		/// The output format can be set to VTK_RGBA (4 components),
		/// VTK_RGB (3 components), VTK_LUMINANCE (1 component, greyscale),
		/// or VTK_LUMINANCE_ALPHA (2 components)
		/// If not supplied, the output format defaults to RGBA.
		/// </summary>
		// Token: 0x06000A9B RID: 2715 RVA: 0x000166A8 File Offset: 0x000148A8
		public void MapScalarsThroughTable(vtkDataArray scalars, IntPtr output)
		{
			vtkScalarsToColors.vtkScalarsToColors_MapScalarsThroughTable_37(base.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis(), output);
		}

		// Token: 0x06000A9C RID: 2716
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColors_MapScalarsThroughTable_38(HandleRef pThis, IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat);

		/// <summary>
		/// Map a set of scalars through the lookup table in a single operation.
		/// This method ignores the VectorMode and the VectorComponent.
		/// The output format can be set to VTK_RGBA (4 components),
		/// VTK_RGB (3 components), VTK_LUMINANCE (1 component, greyscale),
		/// or VTK_LUMINANCE_ALPHA (2 components)
		/// If not supplied, the output format defaults to RGBA.
		/// </summary>
		// Token: 0x06000A9D RID: 2717 RVA: 0x000166D8 File Offset: 0x000148D8
		public void MapScalarsThroughTable(IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
		{
			vtkScalarsToColors.vtkScalarsToColors_MapScalarsThroughTable_38(base.GetCppThis(), input, output, inputDataType, numberOfValues, inputIncrement, outputFormat);
		}

		// Token: 0x06000A9E RID: 2718
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColors_MapScalarsThroughTable2_39(HandleRef pThis, IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat);

		/// <summary>
		/// An internal method typically not used in applications.  This should
		/// be a protected function, but it must be kept public for backwards
		/// compatibility.  Never call this method directly.
		/// </summary>
		// Token: 0x06000A9F RID: 2719 RVA: 0x000166F0 File Offset: 0x000148F0
		public virtual void MapScalarsThroughTable2(IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
		{
			vtkScalarsToColors.vtkScalarsToColors_MapScalarsThroughTable2_39(base.GetCppThis(), input, output, inputDataType, numberOfValues, inputIncrement, outputFormat);
		}

		// Token: 0x06000AA0 RID: 2720
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarsToColors_MapValue_40(HandleRef pThis, double v);

		/// <summary>
		/// Map one value through the lookup table and return a color defined
		/// as an RGBA unsigned char tuple (4 bytes).
		/// </summary>
		// Token: 0x06000AA1 RID: 2721 RVA: 0x00016708 File Offset: 0x00014908
		public virtual IntPtr MapValue(double v)
		{
			return vtkScalarsToColors.vtkScalarsToColors_MapValue_40(base.GetCppThis(), v);
		}

		// Token: 0x06000AA2 RID: 2722
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColors_MapVectorsThroughTable_41(HandleRef pThis, IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat, int vectorComponent, int vectorSize);

		/// <summary>
		/// Map vectors through the lookup table.  Unlike MapScalarsThroughTable,
		/// this method will use the VectorMode to decide how to map vectors.
		/// The output format can be set to VTK_RGBA (4 components),
		/// VTK_RGB (3 components), VTK_LUMINANCE (1 component, greyscale),
		/// or VTK_LUMINANCE_ALPHA (2 components)
		/// </summary>
		// Token: 0x06000AA3 RID: 2723 RVA: 0x00016728 File Offset: 0x00014928
		public void MapVectorsThroughTable(IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat, int vectorComponent, int vectorSize)
		{
			vtkScalarsToColors.vtkScalarsToColors_MapVectorsThroughTable_41(base.GetCppThis(), input, output, inputDataType, numberOfValues, inputIncrement, outputFormat, vectorComponent, vectorSize);
		}

		// Token: 0x06000AA4 RID: 2724
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColors_MapVectorsThroughTable_42(HandleRef pThis, IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat);

		/// <summary>
		/// Map vectors through the lookup table.  Unlike MapScalarsThroughTable,
		/// this method will use the VectorMode to decide how to map vectors.
		/// The output format can be set to VTK_RGBA (4 components),
		/// VTK_RGB (3 components), VTK_LUMINANCE (1 component, greyscale),
		/// or VTK_LUMINANCE_ALPHA (2 components)
		/// </summary>
		// Token: 0x06000AA5 RID: 2725 RVA: 0x0001674F File Offset: 0x0001494F
		public void MapVectorsThroughTable(IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
		{
			vtkScalarsToColors.vtkScalarsToColors_MapVectorsThroughTable_42(base.GetCppThis(), input, output, inputDataType, numberOfValues, inputIncrement, outputFormat);
		}

		// Token: 0x06000AA6 RID: 2726
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarsToColors_NewInstance_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000AA7 RID: 2727 RVA: 0x00016768 File Offset: 0x00014968
		public new vtkScalarsToColors NewInstance()
		{
			vtkScalarsToColors result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarsToColors.vtkScalarsToColors_NewInstance_44(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000AA8 RID: 2728
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkScalarsToColors_RemoveAnnotation_45(HandleRef pThis, HandleRef value);

		/// <summary>
		/// Remove an existing entry from the list of annotated values.
		///
		/// Returns true when the entry was actually removed (i.e., it existed before the call).
		/// Otherwise, returns false.
		/// </summary>
		// Token: 0x06000AA9 RID: 2729 RVA: 0x000167C4 File Offset: 0x000149C4
		public virtual bool RemoveAnnotation(vtkVariant value)
		{
			return vtkScalarsToColors.vtkScalarsToColors_RemoveAnnotation_45(base.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis()) != 0;
		}

		// Token: 0x06000AAA RID: 2730
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColors_ResetAnnotations_46(HandleRef pThis);

		/// <summary>
		/// Remove all existing values and their annotations.
		/// </summary>
		// Token: 0x06000AAB RID: 2731 RVA: 0x000167FF File Offset: 0x000149FF
		public virtual void ResetAnnotations()
		{
			vtkScalarsToColors.vtkScalarsToColors_ResetAnnotations_46(base.GetCppThis());
		}

		// Token: 0x06000AAC RID: 2732
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkScalarsToColors_SafeDownCast_47(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000AAD RID: 2733 RVA: 0x00016810 File Offset: 0x00014A10
		public new static vtkScalarsToColors SafeDownCast(vtkObjectBase o)
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkScalarsToColors.vtkScalarsToColors_SafeDownCast_47((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06000AAE RID: 2734
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColors_SetAlpha_48(HandleRef pThis, double alpha);

		/// <summary>
		/// Specify an additional opacity (alpha) value to blend with. Values
		/// != 1 modify the resulting color consistent with the requested
		/// form of the output. This is typically used by an actor in order to
		/// blend its opacity. Value is clamped between 0 and 1.
		/// </summary>
		// Token: 0x06000AAF RID: 2735 RVA: 0x0001688F File Offset: 0x00014A8F
		public virtual void SetAlpha(double alpha)
		{
			vtkScalarsToColors.vtkScalarsToColors_SetAlpha_48(base.GetCppThis(), alpha);
		}

		// Token: 0x06000AB0 RID: 2736
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScalarsToColors_SetAnnotation_49(HandleRef pThis, HandleRef value, [MarshalAs(UnmanagedType.LPUTF8Str)] string annotation);

		/// <summary>
		/// Add a new entry (or change an existing entry) to the list of annotated values.
		/// Returns the index of \a value in the list of annotations.
		/// </summary>
		// Token: 0x06000AB1 RID: 2737 RVA: 0x000168A0 File Offset: 0x00014AA0
		public virtual long SetAnnotation(vtkVariant value, string annotation)
		{
			return vtkScalarsToColors.vtkScalarsToColors_SetAnnotation_49(base.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis(), annotation);
		}

		// Token: 0x06000AB2 RID: 2738
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkScalarsToColors_SetAnnotation_50(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string value, [MarshalAs(UnmanagedType.LPUTF8Str)] string annotation);

		/// <summary>
		/// This variant of \a SetAnnotation accepts the value as a string so
		/// ParaView can treat annotations as string vector arrays.
		/// </summary>
		// Token: 0x06000AB3 RID: 2739 RVA: 0x000168D8 File Offset: 0x00014AD8
		public virtual long SetAnnotation(string value, string annotation)
		{
			return vtkScalarsToColors.vtkScalarsToColors_SetAnnotation_50(base.GetCppThis(), value, annotation);
		}

		// Token: 0x06000AB4 RID: 2740
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColors_SetAnnotations_51(HandleRef pThis, HandleRef values, HandleRef annotations);

		/// <summary>
		/// Set a list of discrete values, either
		/// as a categorical set of values (when IndexedLookup is true) or
		/// as a set of annotations to add to a scalar array (when IndexedLookup is false).
		/// The two arrays must both either be nullptr or of the same length or
		/// the call will be ignored.
		///
		/// Note that these arrays are deep copied rather than being used directly
		/// in order to support the use case where edits are made. If the
		/// \a values and \a annotations arrays were held by this class then each
		/// call to map scalar values to colors would require us to check the MTime
		/// of the arrays.
		/// </summary>
		// Token: 0x06000AB5 RID: 2741 RVA: 0x000168FC File Offset: 0x00014AFC
		public virtual void SetAnnotations(vtkAbstractArray values, vtkStringArray annotations)
		{
			vtkScalarsToColors.vtkScalarsToColors_SetAnnotations_51(base.GetCppThis(), (values == null) ? default(HandleRef) : values.GetCppThis(), (annotations == null) ? default(HandleRef) : annotations.GetCppThis());
		}

		// Token: 0x06000AB6 RID: 2742
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColors_SetIndexedLookup_52(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get whether the lookup table is for categorical or ordinal data.
		/// The default is ordinal data; values not present in the lookup table
		/// will be assigned an interpolated color.
		///
		/// When categorical data is present, only values in the lookup table will be
		/// considered valid; all other values will be assigned \a NanColor.
		/// </summary>
		// Token: 0x06000AB7 RID: 2743 RVA: 0x00016940 File Offset: 0x00014B40
		public virtual void SetIndexedLookup(int _arg)
		{
			vtkScalarsToColors.vtkScalarsToColors_SetIndexedLookup_52(base.GetCppThis(), _arg);
		}

		// Token: 0x06000AB8 RID: 2744
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColors_SetRange_53(HandleRef pThis, double min, double max);

		/// <summary>
		/// Sets/Gets the range of scalars that will be mapped.
		/// </summary>
		// Token: 0x06000AB9 RID: 2745 RVA: 0x00016950 File Offset: 0x00014B50
		public virtual void SetRange(double min, double max)
		{
			vtkScalarsToColors.vtkScalarsToColors_SetRange_53(base.GetCppThis(), min, max);
		}

		// Token: 0x06000ABA RID: 2746
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColors_SetRange_54(HandleRef pThis, IntPtr rng);

		/// <summary>
		/// Sets/Gets the range of scalars that will be mapped.
		/// </summary>
		// Token: 0x06000ABB RID: 2747 RVA: 0x00016961 File Offset: 0x00014B61
		public virtual void SetRange(IntPtr rng)
		{
			vtkScalarsToColors.vtkScalarsToColors_SetRange_54(base.GetCppThis(), rng);
		}

		// Token: 0x06000ABC RID: 2748
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColors_SetVectorComponent_55(HandleRef pThis, int _arg);

		/// <summary>
		/// If the mapper does not select which component of a vector
		/// to map to colors, you can specify it here.
		/// </summary>
		// Token: 0x06000ABD RID: 2749 RVA: 0x00016971 File Offset: 0x00014B71
		public virtual void SetVectorComponent(int _arg)
		{
			vtkScalarsToColors.vtkScalarsToColors_SetVectorComponent_55(base.GetCppThis(), _arg);
		}

		// Token: 0x06000ABE RID: 2750
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColors_SetVectorMode_56(HandleRef pThis, int _arg);

		/// <summary>
		/// Change mode that maps vectors by magnitude vs. component.
		/// If the mode is "RGBColors", then the vectors components are
		/// scaled to the range and passed directly as the colors.
		/// </summary>
		// Token: 0x06000ABF RID: 2751 RVA: 0x00016981 File Offset: 0x00014B81
		public virtual void SetVectorMode(int _arg)
		{
			vtkScalarsToColors.vtkScalarsToColors_SetVectorMode_56(base.GetCppThis(), _arg);
		}

		// Token: 0x06000AC0 RID: 2752
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColors_SetVectorModeToComponent_57(HandleRef pThis);

		/// <summary>
		/// Change mode that maps vectors by magnitude vs. component.
		/// If the mode is "RGBColors", then the vectors components are
		/// scaled to the range and passed directly as the colors.
		/// </summary>
		// Token: 0x06000AC1 RID: 2753 RVA: 0x00016991 File Offset: 0x00014B91
		public void SetVectorModeToComponent()
		{
			vtkScalarsToColors.vtkScalarsToColors_SetVectorModeToComponent_57(base.GetCppThis());
		}

		// Token: 0x06000AC2 RID: 2754
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColors_SetVectorModeToMagnitude_58(HandleRef pThis);

		/// <summary>
		/// Change mode that maps vectors by magnitude vs. component.
		/// If the mode is "RGBColors", then the vectors components are
		/// scaled to the range and passed directly as the colors.
		/// </summary>
		// Token: 0x06000AC3 RID: 2755 RVA: 0x000169A0 File Offset: 0x00014BA0
		public void SetVectorModeToMagnitude()
		{
			vtkScalarsToColors.vtkScalarsToColors_SetVectorModeToMagnitude_58(base.GetCppThis());
		}

		// Token: 0x06000AC4 RID: 2756
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColors_SetVectorModeToRGBColors_59(HandleRef pThis);

		/// <summary>
		/// Change mode that maps vectors by magnitude vs. component.
		/// If the mode is "RGBColors", then the vectors components are
		/// scaled to the range and passed directly as the colors.
		/// </summary>
		// Token: 0x06000AC5 RID: 2757 RVA: 0x000169AF File Offset: 0x00014BAF
		public void SetVectorModeToRGBColors()
		{
			vtkScalarsToColors.vtkScalarsToColors_SetVectorModeToRGBColors_59(base.GetCppThis());
		}

		// Token: 0x06000AC6 RID: 2758
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkScalarsToColors_SetVectorSize_60(HandleRef pThis, int _arg);

		/// <summary>
		/// When mapping vectors, consider only the number of components selected
		/// by VectorSize to be part of the vector, and ignore any other
		/// components.  Set to -1 to map all components.  If this is not set
		/// to -1, then you can use SetVectorComponent to set which scalar
		/// component will be the first component in the vector to be mapped.
		/// </summary>
		// Token: 0x06000AC7 RID: 2759 RVA: 0x000169BE File Offset: 0x00014BBE
		public virtual void SetVectorSize(int _arg)
		{
			vtkScalarsToColors.vtkScalarsToColors_SetVectorSize_60(base.GetCppThis(), _arg);
		}

		// Token: 0x06000AC8 RID: 2760
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkScalarsToColors_UsingLogScale_61(HandleRef pThis);

		/// <summary>
		/// This should return 1 if the subclass is using log scale for mapping scalars
		/// to colors. Default implementation always returns 0.
		/// </summary>
		// Token: 0x06000AC9 RID: 2761 RVA: 0x000169D0 File Offset: 0x00014BD0
		public virtual int UsingLogScale()
		{
			return vtkScalarsToColors.vtkScalarsToColors_UsingLogScale_61(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040003A7 RID: 935
		public new const string MRFullTypeName = "Kitware.VTK.vtkScalarsToColors";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040003A8 RID: 936
		public new static readonly string MRClassNameKey = "class vtkScalarsToColors";

		/// <summary>
		/// Change mode that maps vectors by magnitude vs. component.
		/// If the mode is "RGBColors", then the vectors components are
		/// scaled to the range and passed directly as the colors.
		/// </summary>
		// Token: 0x0200003D RID: 61
		public enum VectorModes
		{
			/// <summary>enum member</summary>
			// Token: 0x040003AA RID: 938
			COMPONENT = 1,
			/// <summary>enum member</summary>
			// Token: 0x040003AB RID: 939
			MAGNITUDE = 0,
			/// <summary>enum member</summary>
			// Token: 0x040003AC RID: 940
			RGBCOLORS = 2
		}
	}
}
