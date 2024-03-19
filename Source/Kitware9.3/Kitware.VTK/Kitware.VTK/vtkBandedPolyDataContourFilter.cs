using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBandedPolyDataContourFilter
	/// </summary>
	/// <remarks>
	///    generate filled contours for vtkPolyData
	///
	/// vtkBandedPolyDataContourFilter is a filter that takes as input vtkPolyData
	/// and produces as output filled contours (also represented as vtkPolyData).
	/// Filled contours are bands of cells that all have the same cell scalar
	/// value, and can therefore be colored the same. The method is also referred
	/// to as filled contour generation.
	///
	/// To use this filter you must specify one or more contour values.  You can
	/// either use the method SetValue() to specify each contour value, or use
	/// GenerateValues() to generate a series of evenly spaced contours.  Each
	/// contour value divides (or clips) the data into two pieces, values below
	/// the contour value, and values above it. The scalar values of each
	/// band correspond to the specified contour value.  Note that if the first and
	/// last contour values are not the minimum/maximum contour range, then two
	/// extra contour values are added corresponding to the minimum and maximum
	/// range values. These extra contour bands can be prevented from being output
	/// by turning clipping on.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkClipDataSet vtkClipPolyData vtkClipVolume vtkContourFilter
	///
	/// </seealso>
	// Token: 0x02000547 RID: 1351
	public class vtkBandedPolyDataContourFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F09D RID: 61597 RVA: 0x0014F4EF File Offset: 0x0014D6EF
		static vtkBandedPolyDataContourFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBandedPolyDataContourFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBandedPolyDataContourFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F09E RID: 61598 RVA: 0x0014F517 File Offset: 0x0014D717
		public vtkBandedPolyDataContourFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F09F RID: 61599
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBandedPolyDataContourFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with no contours defined.
		/// </summary>
		// Token: 0x0600F0A0 RID: 61600 RVA: 0x0014F528 File Offset: 0x0014D728
		public new static vtkBandedPolyDataContourFilter New()
		{
			vtkBandedPolyDataContourFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBandedPolyDataContourFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with no contours defined.
		/// </summary>
		// Token: 0x0600F0A1 RID: 61601 RVA: 0x0014F57C File Offset: 0x0014D77C
		public vtkBandedPolyDataContourFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F0A2 RID: 61602 RVA: 0x0014F5C0 File Offset: 0x0014D7C0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F0A3 RID: 61603
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBandedPolyDataContourFilter_ClippingOff_01(HandleRef pThis);

		/// <summary>
		/// Indicate whether to clip outside the range specified by the user.
		/// (The range is contour value[0] to contour value[numContours-1].)
		/// Clipping means all cells outside of the range specified are not
		/// sent to the output.
		/// </summary>
		// Token: 0x0600F0A4 RID: 61604 RVA: 0x0014F5CB File Offset: 0x0014D7CB
		public virtual void ClippingOff()
		{
			vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_ClippingOff_01(base.GetCppThis());
		}

		// Token: 0x0600F0A5 RID: 61605
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBandedPolyDataContourFilter_ClippingOn_02(HandleRef pThis);

		/// <summary>
		/// Indicate whether to clip outside the range specified by the user.
		/// (The range is contour value[0] to contour value[numContours-1].)
		/// Clipping means all cells outside of the range specified are not
		/// sent to the output.
		/// </summary>
		// Token: 0x0600F0A6 RID: 61606 RVA: 0x0014F5DA File Offset: 0x0014D7DA
		public virtual void ClippingOn()
		{
			vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_ClippingOn_02(base.GetCppThis());
		}

		// Token: 0x0600F0A7 RID: 61607
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBandedPolyDataContourFilter_GenerateContourEdgesOff_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off a flag to control whether contour edges are generated.
		/// Contour edges are the edges between bands. If enabled, they are
		/// generated from polygons/triangle strips and placed into the second
		/// output (the ContourEdgesOutput).
		/// </summary>
		// Token: 0x0600F0A8 RID: 61608 RVA: 0x0014F5E9 File Offset: 0x0014D7E9
		public virtual void GenerateContourEdgesOff()
		{
			vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GenerateContourEdgesOff_03(base.GetCppThis());
		}

		// Token: 0x0600F0A9 RID: 61609
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBandedPolyDataContourFilter_GenerateContourEdgesOn_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off a flag to control whether contour edges are generated.
		/// Contour edges are the edges between bands. If enabled, they are
		/// generated from polygons/triangle strips and placed into the second
		/// output (the ContourEdgesOutput).
		/// </summary>
		// Token: 0x0600F0AA RID: 61610 RVA: 0x0014F5F8 File Offset: 0x0014D7F8
		public virtual void GenerateContourEdgesOn()
		{
			vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GenerateContourEdgesOn_04(base.GetCppThis());
		}

		// Token: 0x0600F0AB RID: 61611
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBandedPolyDataContourFilter_GenerateValues_05(HandleRef pThis, int numContours, IntPtr range);

		/// <summary>
		/// Methods to set / get contour values. A single value at a time can be
		/// set with SetValue(). Multiple contour values can be set with
		/// GenerateValues(). Note that GenerateValues() generates n values
		/// inclusive of the start and end range values.
		/// </summary>
		// Token: 0x0600F0AC RID: 61612 RVA: 0x0014F607 File Offset: 0x0014D807
		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GenerateValues_05(base.GetCppThis(), numContours, range);
		}

		// Token: 0x0600F0AD RID: 61613
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBandedPolyDataContourFilter_GenerateValues_06(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		/// <summary>
		/// Methods to set / get contour values. A single value at a time can be
		/// set with SetValue(). Multiple contour values can be set with
		/// GenerateValues(). Note that GenerateValues() generates n values
		/// inclusive of the start and end range values.
		/// </summary>
		// Token: 0x0600F0AE RID: 61614 RVA: 0x0014F618 File Offset: 0x0014D818
		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GenerateValues_06(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		// Token: 0x0600F0AF RID: 61615
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBandedPolyDataContourFilter_GetClipTolerance_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the clip tolerance. Warning: setting this too large will
		/// certainly cause numerical issues. Change from the default value
		/// of FLT_EPSILON at your own risk. The actual internal clip tolerance
		/// is computed by multiplying ClipTolerance by the scalar range.
		/// </summary>
		// Token: 0x0600F0B0 RID: 61616 RVA: 0x0014F62C File Offset: 0x0014D82C
		public virtual double GetClipTolerance()
		{
			return vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GetClipTolerance_07(base.GetCppThis());
		}

		// Token: 0x0600F0B1 RID: 61617
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBandedPolyDataContourFilter_GetClipping_08(HandleRef pThis);

		/// <summary>
		/// Indicate whether to clip outside the range specified by the user.
		/// (The range is contour value[0] to contour value[numContours-1].)
		/// Clipping means all cells outside of the range specified are not
		/// sent to the output.
		/// </summary>
		// Token: 0x0600F0B2 RID: 61618 RVA: 0x0014F64C File Offset: 0x0014D84C
		public virtual int GetClipping()
		{
			return vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GetClipping_08(base.GetCppThis());
		}

		// Token: 0x0600F0B3 RID: 61619
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBandedPolyDataContourFilter_GetComponent_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the component to use of an input scalars array with more than one
		/// component. Default is 0.
		/// </summary>
		// Token: 0x0600F0B4 RID: 61620 RVA: 0x0014F66C File Offset: 0x0014D86C
		public virtual int GetComponent()
		{
			return vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GetComponent_09(base.GetCppThis());
		}

		// Token: 0x0600F0B5 RID: 61621
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBandedPolyDataContourFilter_GetContourEdgesOutput_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the second output which contains the edges dividing the contour
		/// bands. This output is empty unless GenerateContourEdges is enabled.
		/// </summary>
		// Token: 0x0600F0B6 RID: 61622 RVA: 0x0014F68C File Offset: 0x0014D88C
		public vtkPolyData GetContourEdgesOutput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GetContourEdgesOutput_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x0600F0B7 RID: 61623
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBandedPolyDataContourFilter_GetGenerateContourEdges_11(HandleRef pThis);

		/// <summary>
		/// Turn on/off a flag to control whether contour edges are generated.
		/// Contour edges are the edges between bands. If enabled, they are
		/// generated from polygons/triangle strips and placed into the second
		/// output (the ContourEdgesOutput).
		/// </summary>
		// Token: 0x0600F0B8 RID: 61624 RVA: 0x0014F6FC File Offset: 0x0014D8FC
		public virtual int GetGenerateContourEdges()
		{
			return vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GetGenerateContourEdges_11(base.GetCppThis());
		}

		// Token: 0x0600F0B9 RID: 61625
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkBandedPolyDataContourFilter_GetMTime_12(HandleRef pThis);

		/// <summary>
		/// Overload GetMTime because we delegate to vtkContourValues so its
		/// modified time must be taken into account.
		/// </summary>
		// Token: 0x0600F0BA RID: 61626 RVA: 0x0014F71C File Offset: 0x0014D91C
		public override ulong GetMTime()
		{
			return vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GetMTime_12(base.GetCppThis());
		}

		// Token: 0x0600F0BB RID: 61627
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBandedPolyDataContourFilter_GetNumberOfContours_13(HandleRef pThis);

		/// <summary>
		/// Methods to set / get contour values. A single value at a time can be
		/// set with SetValue(). Multiple contour values can be set with
		/// GenerateValues(). Note that GenerateValues() generates n values
		/// inclusive of the start and end range values.
		/// </summary>
		// Token: 0x0600F0BC RID: 61628 RVA: 0x0014F73C File Offset: 0x0014D93C
		public long GetNumberOfContours()
		{
			return vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GetNumberOfContours_13(base.GetCppThis());
		}

		// Token: 0x0600F0BD RID: 61629
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBandedPolyDataContourFilter_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F0BE RID: 61630 RVA: 0x0014F75C File Offset: 0x0014D95C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x0600F0BF RID: 61631
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBandedPolyDataContourFilter_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F0C0 RID: 61632 RVA: 0x0014F77C File Offset: 0x0014D97C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x0600F0C1 RID: 61633
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBandedPolyDataContourFilter_GetScalarMode_16(HandleRef pThis);

		/// <summary>
		/// Control whether the cell scalars are output as an integer index or
		/// a scalar value. If an index, the index refers to the bands produced
		/// by the clipping range. If a value, then a scalar value which is a
		/// value between clip values is used.
		/// </summary>
		// Token: 0x0600F0C2 RID: 61634 RVA: 0x0014F798 File Offset: 0x0014D998
		public virtual int GetScalarMode()
		{
			return vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GetScalarMode_16(base.GetCppThis());
		}

		// Token: 0x0600F0C3 RID: 61635
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBandedPolyDataContourFilter_GetScalarModeMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Control whether the cell scalars are output as an integer index or
		/// a scalar value. If an index, the index refers to the bands produced
		/// by the clipping range. If a value, then a scalar value which is a
		/// value between clip values is used.
		/// </summary>
		// Token: 0x0600F0C4 RID: 61636 RVA: 0x0014F7B8 File Offset: 0x0014D9B8
		public virtual int GetScalarModeMaxValue()
		{
			return vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GetScalarModeMaxValue_17(base.GetCppThis());
		}

		// Token: 0x0600F0C5 RID: 61637
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBandedPolyDataContourFilter_GetScalarModeMinValue_18(HandleRef pThis);

		/// <summary>
		/// Control whether the cell scalars are output as an integer index or
		/// a scalar value. If an index, the index refers to the bands produced
		/// by the clipping range. If a value, then a scalar value which is a
		/// value between clip values is used.
		/// </summary>
		// Token: 0x0600F0C6 RID: 61638 RVA: 0x0014F7D8 File Offset: 0x0014D9D8
		public virtual int GetScalarModeMinValue()
		{
			return vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GetScalarModeMinValue_18(base.GetCppThis());
		}

		// Token: 0x0600F0C7 RID: 61639
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBandedPolyDataContourFilter_GetValue_19(HandleRef pThis, int i);

		/// <summary>
		/// Methods to set / get contour values. A single value at a time can be
		/// set with SetValue(). Multiple contour values can be set with
		/// GenerateValues(). Note that GenerateValues() generates n values
		/// inclusive of the start and end range values.
		/// </summary>
		// Token: 0x0600F0C8 RID: 61640 RVA: 0x0014F7F8 File Offset: 0x0014D9F8
		public double GetValue(int i)
		{
			return vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GetValue_19(base.GetCppThis(), i);
		}

		// Token: 0x0600F0C9 RID: 61641
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBandedPolyDataContourFilter_GetValues_20(HandleRef pThis);

		/// <summary>
		/// Methods to set / get contour values. A single value at a time can be
		/// set with SetValue(). Multiple contour values can be set with
		/// GenerateValues(). Note that GenerateValues() generates n values
		/// inclusive of the start and end range values.
		/// </summary>
		// Token: 0x0600F0CA RID: 61642 RVA: 0x0014F818 File Offset: 0x0014DA18
		public IntPtr GetValues()
		{
			return vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GetValues_20(base.GetCppThis());
		}

		// Token: 0x0600F0CB RID: 61643
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBandedPolyDataContourFilter_GetValues_21(HandleRef pThis, IntPtr contourValues);

		/// <summary>
		/// Methods to set / get contour values. A single value at a time can be
		/// set with SetValue(). Multiple contour values can be set with
		/// GenerateValues(). Note that GenerateValues() generates n values
		/// inclusive of the start and end range values.
		/// </summary>
		// Token: 0x0600F0CC RID: 61644 RVA: 0x0014F837 File Offset: 0x0014DA37
		public void GetValues(IntPtr contourValues)
		{
			vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_GetValues_21(base.GetCppThis(), contourValues);
		}

		// Token: 0x0600F0CD RID: 61645
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBandedPolyDataContourFilter_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F0CE RID: 61646 RVA: 0x0014F848 File Offset: 0x0014DA48
		public override int IsA(string type)
		{
			return vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x0600F0CF RID: 61647
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBandedPolyDataContourFilter_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F0D0 RID: 61648 RVA: 0x0014F868 File Offset: 0x0014DA68
		public new static int IsTypeOf(string type)
		{
			return vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_IsTypeOf_23(type);
		}

		// Token: 0x0600F0D1 RID: 61649
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBandedPolyDataContourFilter_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F0D2 RID: 61650 RVA: 0x0014F884 File Offset: 0x0014DA84
		public new vtkBandedPolyDataContourFilter NewInstance()
		{
			vtkBandedPolyDataContourFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBandedPolyDataContourFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F0D3 RID: 61651
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBandedPolyDataContourFilter_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F0D4 RID: 61652 RVA: 0x0014F8E0 File Offset: 0x0014DAE0
		public new static vtkBandedPolyDataContourFilter SafeDownCast(vtkObjectBase o)
		{
			vtkBandedPolyDataContourFilter vtkBandedPolyDataContourFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBandedPolyDataContourFilter = (vtkBandedPolyDataContourFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBandedPolyDataContourFilter.Register(null);
				}
			}
			return vtkBandedPolyDataContourFilter;
		}

		// Token: 0x0600F0D5 RID: 61653
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBandedPolyDataContourFilter_SetClipTolerance_27(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the clip tolerance. Warning: setting this too large will
		/// certainly cause numerical issues. Change from the default value
		/// of FLT_EPSILON at your own risk. The actual internal clip tolerance
		/// is computed by multiplying ClipTolerance by the scalar range.
		/// </summary>
		// Token: 0x0600F0D6 RID: 61654 RVA: 0x0014F95F File Offset: 0x0014DB5F
		public virtual void SetClipTolerance(double _arg)
		{
			vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_SetClipTolerance_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F0D7 RID: 61655
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBandedPolyDataContourFilter_SetClipping_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate whether to clip outside the range specified by the user.
		/// (The range is contour value[0] to contour value[numContours-1].)
		/// Clipping means all cells outside of the range specified are not
		/// sent to the output.
		/// </summary>
		// Token: 0x0600F0D8 RID: 61656 RVA: 0x0014F96F File Offset: 0x0014DB6F
		public virtual void SetClipping(int _arg)
		{
			vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_SetClipping_28(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F0D9 RID: 61657
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBandedPolyDataContourFilter_SetComponent_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the component to use of an input scalars array with more than one
		/// component. Default is 0.
		/// </summary>
		// Token: 0x0600F0DA RID: 61658 RVA: 0x0014F97F File Offset: 0x0014DB7F
		public virtual void SetComponent(int _arg)
		{
			vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_SetComponent_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F0DB RID: 61659
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBandedPolyDataContourFilter_SetGenerateContourEdges_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off a flag to control whether contour edges are generated.
		/// Contour edges are the edges between bands. If enabled, they are
		/// generated from polygons/triangle strips and placed into the second
		/// output (the ContourEdgesOutput).
		/// </summary>
		// Token: 0x0600F0DC RID: 61660 RVA: 0x0014F98F File Offset: 0x0014DB8F
		public virtual void SetGenerateContourEdges(int _arg)
		{
			vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_SetGenerateContourEdges_30(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F0DD RID: 61661
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBandedPolyDataContourFilter_SetNumberOfContours_31(HandleRef pThis, int number);

		/// <summary>
		/// Methods to set / get contour values. A single value at a time can be
		/// set with SetValue(). Multiple contour values can be set with
		/// GenerateValues(). Note that GenerateValues() generates n values
		/// inclusive of the start and end range values.
		/// </summary>
		// Token: 0x0600F0DE RID: 61662 RVA: 0x0014F99F File Offset: 0x0014DB9F
		public void SetNumberOfContours(int number)
		{
			vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_SetNumberOfContours_31(base.GetCppThis(), number);
		}

		// Token: 0x0600F0DF RID: 61663
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBandedPolyDataContourFilter_SetScalarMode_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Control whether the cell scalars are output as an integer index or
		/// a scalar value. If an index, the index refers to the bands produced
		/// by the clipping range. If a value, then a scalar value which is a
		/// value between clip values is used.
		/// </summary>
		// Token: 0x0600F0E0 RID: 61664 RVA: 0x0014F9AF File Offset: 0x0014DBAF
		public virtual void SetScalarMode(int _arg)
		{
			vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_SetScalarMode_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F0E1 RID: 61665
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBandedPolyDataContourFilter_SetScalarModeToIndex_33(HandleRef pThis);

		/// <summary>
		/// Control whether the cell scalars are output as an integer index or
		/// a scalar value. If an index, the index refers to the bands produced
		/// by the clipping range. If a value, then a scalar value which is a
		/// value between clip values is used.
		/// </summary>
		// Token: 0x0600F0E2 RID: 61666 RVA: 0x0014F9BF File Offset: 0x0014DBBF
		public void SetScalarModeToIndex()
		{
			vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_SetScalarModeToIndex_33(base.GetCppThis());
		}

		// Token: 0x0600F0E3 RID: 61667
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBandedPolyDataContourFilter_SetScalarModeToValue_34(HandleRef pThis);

		/// <summary>
		/// Control whether the cell scalars are output as an integer index or
		/// a scalar value. If an index, the index refers to the bands produced
		/// by the clipping range. If a value, then a scalar value which is a
		/// value between clip values is used.
		/// </summary>
		// Token: 0x0600F0E4 RID: 61668 RVA: 0x0014F9CE File Offset: 0x0014DBCE
		public void SetScalarModeToValue()
		{
			vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_SetScalarModeToValue_34(base.GetCppThis());
		}

		// Token: 0x0600F0E5 RID: 61669
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBandedPolyDataContourFilter_SetValue_35(HandleRef pThis, int i, double value);

		/// <summary>
		/// Methods to set / get contour values. A single value at a time can be
		/// set with SetValue(). Multiple contour values can be set with
		/// GenerateValues(). Note that GenerateValues() generates n values
		/// inclusive of the start and end range values.
		/// </summary>
		// Token: 0x0600F0E6 RID: 61670 RVA: 0x0014F9DD File Offset: 0x0014DBDD
		public void SetValue(int i, double value)
		{
			vtkBandedPolyDataContourFilter.vtkBandedPolyDataContourFilter_SetValue_35(base.GetCppThis(), i, value);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001186 RID: 4486
		public new const string MRFullTypeName = "Kitware.VTK.vtkBandedPolyDataContourFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001187 RID: 4487
		public new static readonly string MRClassNameKey = "class vtkBandedPolyDataContourFilter";
	}
}
