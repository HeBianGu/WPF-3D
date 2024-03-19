using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAttributeSmoothingFilter
	/// </summary>
	/// <remarks>
	///    smooth mesh point attribute data using distance weighted Laplacian kernel
	///
	/// vtkAttributeSmoothingFilter is a filter that smooths point attribute data
	/// using a Laplacian smoothing approach. The effect is to "relax" or "smooth"
	/// the attributes, reducing high frequency information. Note that this filter
	/// operates on all dataset types.
	///
	/// A central concept of this filter is the point smoothing stencil. A
	/// smoothing stencil for a point p(i) is the list of points p(j) which
	/// connect to p(i) via an edge. To smooth the attributes of point p(i),
	/// p(i)'s attribute data a(i) are iteratively averaged using the distance
	/// weighted average of the attributes of a(j) (the weights w[j] sum to
	/// 1). This averaging process is repeated until the maximum number of
	/// iterations is reached.
	///
	/// The relaxation factor R is also important as the smoothing process
	/// proceeds in an iterative fashion. The a(i+1) attributes are determined
	/// from the a(i) attributes as follows:
	/// ```
	/// a(i+1) = (1-R)*a(i) + R*sum(w(j)*a(j))
	/// ```
	///
	/// Convergence occurs faster for larger relaxation factors. Typically a small
	/// number of iterations is required for large relaxation factors, and in
	/// cases where only points adjacent to the boundary are being smoothed, a
	/// single iteration with R=1 may be adequate (i.e., just a distance weighted
	/// average is computed).
	///
	/// To control what regions in the dataset have their attributes smoothed, it
	/// is possible to specify which points (and their attributes) are allowed to
	/// be smoothed (and therefore also those that are constrained). Typically
	/// point data attributes may be constrained on the boundary, or only point
	/// attributes directly connected (i.e., adjacent) to the boundary may be
	/// allowed to change (this supports smooth transition of attributes from the
	/// boundary into the interior of the mesh). Note that the meaning of a
	/// boundary point (versus interior point) changes depending on the input
	/// dataset type. For vtkPolyData, boundary *edges* are used to identify
	/// boundary points; for all other dataset types, points used by a boundary
	/// *face* are considered boundary points. It is also possible to explicitly
	/// specify which points are smoothed, and those that are constrained, by
	/// specifying a smooth mask associated with each input point.
	///
	/// To control which point data attributes are to be smoothed, specify in
	/// ExcludedArrays which arrays should not be smoothed--these data arrays are
	/// simply passed through to the output of the filter.
	///
	/// @warning
	/// Certain data attributes cannot be correctly interpolated using this
	/// filter.  For example, surface normals are expected to be |n|=1; after
	/// attribute smoothing this constraint is likely to be violated. Other
	/// vectors and tensors may suffer from similar issues. In such a situation,
	/// specify ExcludedArrays which will not be smoothed (and simply passed
	/// through to the output of the filter).
	///
	/// @warning
	/// Currently the distance weighting function is based on averaging, 1/r, or
	/// 1/(r**2) weights (user selectable), where r is the distance between the
	/// point to be smoothed and an edge connected neighbor (defined by the
	/// smoothing stencil). The weights are normalized so that sum(w(i))==1. When
	/// smoothing based on averaging, the weights are simply 1/n, where n is the
	/// number of connected points in the stencil.
	///
	/// @warning
	/// The smoothing process reduces high frequency information in the data
	/// attributes. With excessive smoothing (large numbers of iterations, and/or
	/// a large relaxation factor) important details may be lost, and the
	/// attributes will move towards an "average" value.
	///
	/// @warning
	/// While this filter will process any dataset type, if the input data is a 3D
	/// image volume, it's likely much faster to use an image-based algorithm to
	/// perform data smoothing.
	///
	/// @warning
	/// To determine boundary points in vtkPolyData, edges used by only one cell
	/// are considered boundary (and hence the associated points defining the
	/// edge). To determine boundary points for all other dataset types, a
	/// vtkMarkBoundaryFilter is used to extract the boundary faces - this can be
	/// time consuming for large data.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkConstrainedSmoothingFilter vtkWindowedSincPolyDataFilter
	/// vtkSmoothPolyDataFilter vtkExtractEdges vtkMarkBoundaryFilter
	/// </seealso>
	// Token: 0x02000904 RID: 2308
	public class vtkAttributeSmoothingFilter : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017F1E RID: 98078 RVA: 0x00218273 File Offset: 0x00216473
		static vtkAttributeSmoothingFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAttributeSmoothingFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAttributeSmoothingFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017F1F RID: 98079 RVA: 0x0021829B File Offset: 0x0021649B
		public vtkAttributeSmoothingFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017F20 RID: 98080
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAttributeSmoothingFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, to obtain type information, and
		/// print the state of a class instance.
		/// </summary>
		// Token: 0x06017F21 RID: 98081 RVA: 0x002182AC File Offset: 0x002164AC
		public new static vtkAttributeSmoothingFilter New()
		{
			vtkAttributeSmoothingFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAttributeSmoothingFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, to obtain type information, and
		/// print the state of a class instance.
		/// </summary>
		// Token: 0x06017F22 RID: 98082 RVA: 0x00218300 File Offset: 0x00216500
		public vtkAttributeSmoothingFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017F23 RID: 98083 RVA: 0x00218344 File Offset: 0x00216544
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017F24 RID: 98084
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeSmoothingFilter_AddExcludedArray_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string excludedArray);

		/// <summary>
		/// Adds an array to the list of arrays which are to be excluded from the
		/// interpolation process. Any specified arrays are simply passed through
		/// to the filter output.
		/// </summary>
		// Token: 0x06017F25 RID: 98085 RVA: 0x0021834F File Offset: 0x0021654F
		public void AddExcludedArray(string excludedArray)
		{
			vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_AddExcludedArray_01(base.GetCppThis(), excludedArray);
		}

		// Token: 0x06017F26 RID: 98086
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeSmoothingFilter_ClearExcludedArrays_02(HandleRef pThis);

		/// <summary>
		/// Clears the contents of excluded array list.
		/// </summary>
		// Token: 0x06017F27 RID: 98087 RVA: 0x0021835F File Offset: 0x0021655F
		public void ClearExcludedArrays()
		{
			vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_ClearExcludedArrays_02(base.GetCppThis());
		}

		// Token: 0x06017F28 RID: 98088
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAttributeSmoothingFilter_GetExcludedArray_03(HandleRef pThis, int i);

		/// <summary>
		/// Return the name of the ith excluded array.
		/// </summary>
		// Token: 0x06017F29 RID: 98089 RVA: 0x00218370 File Offset: 0x00216570
		public string GetExcludedArray(int i)
		{
			string s = Marshal.PtrToStringAnsi(vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_GetExcludedArray_03(base.GetCppThis(), i));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06017F2A RID: 98090
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributeSmoothingFilter_GetNumberOfExcludedArrays_04(HandleRef pThis);

		/// <summary>
		/// Return the number of excluded arrays.
		/// </summary>
		// Token: 0x06017F2B RID: 98091 RVA: 0x002183AC File Offset: 0x002165AC
		public int GetNumberOfExcludedArrays()
		{
			return vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_GetNumberOfExcludedArrays_04(base.GetCppThis());
		}

		// Token: 0x06017F2C RID: 98092
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAttributeSmoothingFilter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, to obtain type information, and
		/// print the state of a class instance.
		/// </summary>
		// Token: 0x06017F2D RID: 98093 RVA: 0x002183CC File Offset: 0x002165CC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06017F2E RID: 98094
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAttributeSmoothingFilter_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, to obtain type information, and
		/// print the state of a class instance.
		/// </summary>
		// Token: 0x06017F2F RID: 98095 RVA: 0x002183EC File Offset: 0x002165EC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06017F30 RID: 98096
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributeSmoothingFilter_GetNumberOfIterations_07(HandleRef pThis);

		/// <summary>
		/// Specify the maximum number of iterations for smoothing.  The default
		/// value is 5.
		/// </summary>
		// Token: 0x06017F31 RID: 98097 RVA: 0x00218408 File Offset: 0x00216608
		public virtual int GetNumberOfIterations()
		{
			return vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_GetNumberOfIterations_07(base.GetCppThis());
		}

		// Token: 0x06017F32 RID: 98098
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributeSmoothingFilter_GetNumberOfIterationsMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Specify the maximum number of iterations for smoothing.  The default
		/// value is 5.
		/// </summary>
		// Token: 0x06017F33 RID: 98099 RVA: 0x00218428 File Offset: 0x00216628
		public virtual int GetNumberOfIterationsMaxValue()
		{
			return vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_GetNumberOfIterationsMaxValue_08(base.GetCppThis());
		}

		// Token: 0x06017F34 RID: 98100
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributeSmoothingFilter_GetNumberOfIterationsMinValue_09(HandleRef pThis);

		/// <summary>
		/// Specify the maximum number of iterations for smoothing.  The default
		/// value is 5.
		/// </summary>
		// Token: 0x06017F35 RID: 98101 RVA: 0x00218448 File Offset: 0x00216648
		public virtual int GetNumberOfIterationsMinValue()
		{
			return vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_GetNumberOfIterationsMinValue_09(base.GetCppThis());
		}

		// Token: 0x06017F36 RID: 98102
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAttributeSmoothingFilter_GetRelaxationFactor_10(HandleRef pThis);

		/// <summary>
		/// Specify the relaxation factor for smoothing. As in all iterative
		/// methods, the stability of the process is sensitive to this parameter. In
		/// general, small relaxation factors and large numbers of iterations are
		/// more stable than larger relaxation factors and smaller numbers of
		/// iterations. The default value is 0.10.
		/// </summary>
		// Token: 0x06017F37 RID: 98103 RVA: 0x00218468 File Offset: 0x00216668
		public virtual double GetRelaxationFactor()
		{
			return vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_GetRelaxationFactor_10(base.GetCppThis());
		}

		// Token: 0x06017F38 RID: 98104
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAttributeSmoothingFilter_GetRelaxationFactorMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Specify the relaxation factor for smoothing. As in all iterative
		/// methods, the stability of the process is sensitive to this parameter. In
		/// general, small relaxation factors and large numbers of iterations are
		/// more stable than larger relaxation factors and smaller numbers of
		/// iterations. The default value is 0.10.
		/// </summary>
		// Token: 0x06017F39 RID: 98105 RVA: 0x00218488 File Offset: 0x00216688
		public virtual double GetRelaxationFactorMaxValue()
		{
			return vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_GetRelaxationFactorMaxValue_11(base.GetCppThis());
		}

		// Token: 0x06017F3A RID: 98106
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAttributeSmoothingFilter_GetRelaxationFactorMinValue_12(HandleRef pThis);

		/// <summary>
		/// Specify the relaxation factor for smoothing. As in all iterative
		/// methods, the stability of the process is sensitive to this parameter. In
		/// general, small relaxation factors and large numbers of iterations are
		/// more stable than larger relaxation factors and smaller numbers of
		/// iterations. The default value is 0.10.
		/// </summary>
		// Token: 0x06017F3B RID: 98107 RVA: 0x002184A8 File Offset: 0x002166A8
		public virtual double GetRelaxationFactorMinValue()
		{
			return vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_GetRelaxationFactorMinValue_12(base.GetCppThis());
		}

		// Token: 0x06017F3C RID: 98108
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAttributeSmoothingFilter_GetSmoothingMask_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the smoothing mask to use (which takes effect only when a
		/// SMOOTHING_MASK smoothing strategy is specified). The smoothing mask is a
		/// vtkUnsignedCharArray with a value ==1 at all points whose attributes are
		/// to be smoothed.  The size of the data array must match the number of
		/// input points. If there is a mismatch between the size of the smoothing
		/// mask, and the number of input points, then an ALL_POINTS smoothing
		/// strategy is used.
		/// </summary>
		// Token: 0x06017F3D RID: 98109 RVA: 0x002184C8 File Offset: 0x002166C8
		public virtual vtkUnsignedCharArray GetSmoothingMask()
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_GetSmoothingMask_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06017F3E RID: 98110
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributeSmoothingFilter_GetSmoothingStrategy_14(HandleRef pThis);

		/// <summary>
		/// Indicate how to constrain smoothing of the attribute data. By default,
		/// all point data attributes are smoothed (ALL_POINTS). If ALL_BUT_BOUNDARY
		/// is selected, then all point attribute data except those on the boundary
		/// of the mesh are smoothed.  If ADJACENT_TO_BOUNDARY is selected, then
		/// only point data connected to a boundary point are smoothed, but boundary
		/// and interior points are not. (ALL_BUT_BOUNDARY and ADJACENT_TO_BOUNDARY
		/// are useful for transitioning from fixed boundary conditions to interior
		/// data.) If desired, it is possible to explicitly specify a smoothing mask
		/// controlling which points are smoothed and not smoothed. The default
		/// constraint strategy is ALL_POINTS.
		/// </summary>
		// Token: 0x06017F3F RID: 98111 RVA: 0x00218538 File Offset: 0x00216738
		public virtual int GetSmoothingStrategy()
		{
			return vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_GetSmoothingStrategy_14(base.GetCppThis());
		}

		// Token: 0x06017F40 RID: 98112
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributeSmoothingFilter_GetSmoothingStrategyMaxValue_15(HandleRef pThis);

		/// <summary>
		/// Indicate how to constrain smoothing of the attribute data. By default,
		/// all point data attributes are smoothed (ALL_POINTS). If ALL_BUT_BOUNDARY
		/// is selected, then all point attribute data except those on the boundary
		/// of the mesh are smoothed.  If ADJACENT_TO_BOUNDARY is selected, then
		/// only point data connected to a boundary point are smoothed, but boundary
		/// and interior points are not. (ALL_BUT_BOUNDARY and ADJACENT_TO_BOUNDARY
		/// are useful for transitioning from fixed boundary conditions to interior
		/// data.) If desired, it is possible to explicitly specify a smoothing mask
		/// controlling which points are smoothed and not smoothed. The default
		/// constraint strategy is ALL_POINTS.
		/// </summary>
		// Token: 0x06017F41 RID: 98113 RVA: 0x00218558 File Offset: 0x00216758
		public virtual int GetSmoothingStrategyMaxValue()
		{
			return vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_GetSmoothingStrategyMaxValue_15(base.GetCppThis());
		}

		// Token: 0x06017F42 RID: 98114
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributeSmoothingFilter_GetSmoothingStrategyMinValue_16(HandleRef pThis);

		/// <summary>
		/// Indicate how to constrain smoothing of the attribute data. By default,
		/// all point data attributes are smoothed (ALL_POINTS). If ALL_BUT_BOUNDARY
		/// is selected, then all point attribute data except those on the boundary
		/// of the mesh are smoothed.  If ADJACENT_TO_BOUNDARY is selected, then
		/// only point data connected to a boundary point are smoothed, but boundary
		/// and interior points are not. (ALL_BUT_BOUNDARY and ADJACENT_TO_BOUNDARY
		/// are useful for transitioning from fixed boundary conditions to interior
		/// data.) If desired, it is possible to explicitly specify a smoothing mask
		/// controlling which points are smoothed and not smoothed. The default
		/// constraint strategy is ALL_POINTS.
		/// </summary>
		// Token: 0x06017F43 RID: 98115 RVA: 0x00218578 File Offset: 0x00216778
		public virtual int GetSmoothingStrategyMinValue()
		{
			return vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_GetSmoothingStrategyMinValue_16(base.GetCppThis());
		}

		// Token: 0x06017F44 RID: 98116
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributeSmoothingFilter_GetWeightsType_17(HandleRef pThis);

		/// <summary>
		/// Indicate how to compute weights, using 1) a simple average of all
		/// connected points in the stencil; 2) a distance-weighted (i.e., 1/r)
		/// approach; or 3) distance**2-weighted (i.e., 1/(r**2) interpolation
		/// weights). The default constraint strategy is distance**2-weighted (i.e.,
		/// DISTANCE2).
		/// </summary>
		// Token: 0x06017F45 RID: 98117 RVA: 0x00218598 File Offset: 0x00216798
		public virtual int GetWeightsType()
		{
			return vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_GetWeightsType_17(base.GetCppThis());
		}

		// Token: 0x06017F46 RID: 98118
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributeSmoothingFilter_GetWeightsTypeMaxValue_18(HandleRef pThis);

		/// <summary>
		/// Indicate how to compute weights, using 1) a simple average of all
		/// connected points in the stencil; 2) a distance-weighted (i.e., 1/r)
		/// approach; or 3) distance**2-weighted (i.e., 1/(r**2) interpolation
		/// weights). The default constraint strategy is distance**2-weighted (i.e.,
		/// DISTANCE2).
		/// </summary>
		// Token: 0x06017F47 RID: 98119 RVA: 0x002185B8 File Offset: 0x002167B8
		public virtual int GetWeightsTypeMaxValue()
		{
			return vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_GetWeightsTypeMaxValue_18(base.GetCppThis());
		}

		// Token: 0x06017F48 RID: 98120
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributeSmoothingFilter_GetWeightsTypeMinValue_19(HandleRef pThis);

		/// <summary>
		/// Indicate how to compute weights, using 1) a simple average of all
		/// connected points in the stencil; 2) a distance-weighted (i.e., 1/r)
		/// approach; or 3) distance**2-weighted (i.e., 1/(r**2) interpolation
		/// weights). The default constraint strategy is distance**2-weighted (i.e.,
		/// DISTANCE2).
		/// </summary>
		// Token: 0x06017F49 RID: 98121 RVA: 0x002185D8 File Offset: 0x002167D8
		public virtual int GetWeightsTypeMinValue()
		{
			return vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_GetWeightsTypeMinValue_19(base.GetCppThis());
		}

		// Token: 0x06017F4A RID: 98122
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributeSmoothingFilter_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, to obtain type information, and
		/// print the state of a class instance.
		/// </summary>
		// Token: 0x06017F4B RID: 98123 RVA: 0x002185F8 File Offset: 0x002167F8
		public override int IsA(string type)
		{
			return vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x06017F4C RID: 98124
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAttributeSmoothingFilter_IsTypeOf_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, to obtain type information, and
		/// print the state of a class instance.
		/// </summary>
		// Token: 0x06017F4D RID: 98125 RVA: 0x00218618 File Offset: 0x00216818
		public new static int IsTypeOf(string type)
		{
			return vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_IsTypeOf_21(type);
		}

		// Token: 0x06017F4E RID: 98126
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAttributeSmoothingFilter_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, to obtain type information, and
		/// print the state of a class instance.
		/// </summary>
		// Token: 0x06017F4F RID: 98127 RVA: 0x00218634 File Offset: 0x00216834
		public new vtkAttributeSmoothingFilter NewInstance()
		{
			vtkAttributeSmoothingFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_NewInstance_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAttributeSmoothingFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017F50 RID: 98128
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAttributeSmoothingFilter_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, to obtain type information, and
		/// print the state of a class instance.
		/// </summary>
		// Token: 0x06017F51 RID: 98129 RVA: 0x00218690 File Offset: 0x00216890
		public new static vtkAttributeSmoothingFilter SafeDownCast(vtkObjectBase o)
		{
			vtkAttributeSmoothingFilter vtkAttributeSmoothingFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAttributeSmoothingFilter = (vtkAttributeSmoothingFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAttributeSmoothingFilter.Register(null);
				}
			}
			return vtkAttributeSmoothingFilter;
		}

		// Token: 0x06017F52 RID: 98130
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeSmoothingFilter_SetNumberOfIterations_25(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the maximum number of iterations for smoothing.  The default
		/// value is 5.
		/// </summary>
		// Token: 0x06017F53 RID: 98131 RVA: 0x0021870F File Offset: 0x0021690F
		public virtual void SetNumberOfIterations(int _arg)
		{
			vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_SetNumberOfIterations_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06017F54 RID: 98132
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeSmoothingFilter_SetRelaxationFactor_26(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the relaxation factor for smoothing. As in all iterative
		/// methods, the stability of the process is sensitive to this parameter. In
		/// general, small relaxation factors and large numbers of iterations are
		/// more stable than larger relaxation factors and smaller numbers of
		/// iterations. The default value is 0.10.
		/// </summary>
		// Token: 0x06017F55 RID: 98133 RVA: 0x0021871F File Offset: 0x0021691F
		public virtual void SetRelaxationFactor(double _arg)
		{
			vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_SetRelaxationFactor_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06017F56 RID: 98134
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeSmoothingFilter_SetSmoothingMask_27(HandleRef pThis, HandleRef _arg);

		/// <summary>
		/// Specify the smoothing mask to use (which takes effect only when a
		/// SMOOTHING_MASK smoothing strategy is specified). The smoothing mask is a
		/// vtkUnsignedCharArray with a value ==1 at all points whose attributes are
		/// to be smoothed.  The size of the data array must match the number of
		/// input points. If there is a mismatch between the size of the smoothing
		/// mask, and the number of input points, then an ALL_POINTS smoothing
		/// strategy is used.
		/// </summary>
		// Token: 0x06017F57 RID: 98135 RVA: 0x00218730 File Offset: 0x00216930
		public virtual void SetSmoothingMask(vtkUnsignedCharArray _arg)
		{
			vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_SetSmoothingMask_27(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		// Token: 0x06017F58 RID: 98136
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeSmoothingFilter_SetSmoothingStrategy_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate how to constrain smoothing of the attribute data. By default,
		/// all point data attributes are smoothed (ALL_POINTS). If ALL_BUT_BOUNDARY
		/// is selected, then all point attribute data except those on the boundary
		/// of the mesh are smoothed.  If ADJACENT_TO_BOUNDARY is selected, then
		/// only point data connected to a boundary point are smoothed, but boundary
		/// and interior points are not. (ALL_BUT_BOUNDARY and ADJACENT_TO_BOUNDARY
		/// are useful for transitioning from fixed boundary conditions to interior
		/// data.) If desired, it is possible to explicitly specify a smoothing mask
		/// controlling which points are smoothed and not smoothed. The default
		/// constraint strategy is ALL_POINTS.
		/// </summary>
		// Token: 0x06017F59 RID: 98137 RVA: 0x0021875F File Offset: 0x0021695F
		public virtual void SetSmoothingStrategy(int _arg)
		{
			vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_SetSmoothingStrategy_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06017F5A RID: 98138
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeSmoothingFilter_SetSmoothingStrategyToAdjacentToBoundary_29(HandleRef pThis);

		/// <summary>
		/// Indicate how to constrain smoothing of the attribute data. By default,
		/// all point data attributes are smoothed (ALL_POINTS). If ALL_BUT_BOUNDARY
		/// is selected, then all point attribute data except those on the boundary
		/// of the mesh are smoothed.  If ADJACENT_TO_BOUNDARY is selected, then
		/// only point data connected to a boundary point are smoothed, but boundary
		/// and interior points are not. (ALL_BUT_BOUNDARY and ADJACENT_TO_BOUNDARY
		/// are useful for transitioning from fixed boundary conditions to interior
		/// data.) If desired, it is possible to explicitly specify a smoothing mask
		/// controlling which points are smoothed and not smoothed. The default
		/// constraint strategy is ALL_POINTS.
		/// </summary>
		// Token: 0x06017F5B RID: 98139 RVA: 0x0021876F File Offset: 0x0021696F
		public void SetSmoothingStrategyToAdjacentToBoundary()
		{
			vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_SetSmoothingStrategyToAdjacentToBoundary_29(base.GetCppThis());
		}

		// Token: 0x06017F5C RID: 98140
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeSmoothingFilter_SetSmoothingStrategyToAllButBoundary_30(HandleRef pThis);

		/// <summary>
		/// Indicate how to constrain smoothing of the attribute data. By default,
		/// all point data attributes are smoothed (ALL_POINTS). If ALL_BUT_BOUNDARY
		/// is selected, then all point attribute data except those on the boundary
		/// of the mesh are smoothed.  If ADJACENT_TO_BOUNDARY is selected, then
		/// only point data connected to a boundary point are smoothed, but boundary
		/// and interior points are not. (ALL_BUT_BOUNDARY and ADJACENT_TO_BOUNDARY
		/// are useful for transitioning from fixed boundary conditions to interior
		/// data.) If desired, it is possible to explicitly specify a smoothing mask
		/// controlling which points are smoothed and not smoothed. The default
		/// constraint strategy is ALL_POINTS.
		/// </summary>
		// Token: 0x06017F5D RID: 98141 RVA: 0x0021877E File Offset: 0x0021697E
		public void SetSmoothingStrategyToAllButBoundary()
		{
			vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_SetSmoothingStrategyToAllButBoundary_30(base.GetCppThis());
		}

		// Token: 0x06017F5E RID: 98142
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeSmoothingFilter_SetSmoothingStrategyToAllPoints_31(HandleRef pThis);

		/// <summary>
		/// Indicate how to constrain smoothing of the attribute data. By default,
		/// all point data attributes are smoothed (ALL_POINTS). If ALL_BUT_BOUNDARY
		/// is selected, then all point attribute data except those on the boundary
		/// of the mesh are smoothed.  If ADJACENT_TO_BOUNDARY is selected, then
		/// only point data connected to a boundary point are smoothed, but boundary
		/// and interior points are not. (ALL_BUT_BOUNDARY and ADJACENT_TO_BOUNDARY
		/// are useful for transitioning from fixed boundary conditions to interior
		/// data.) If desired, it is possible to explicitly specify a smoothing mask
		/// controlling which points are smoothed and not smoothed. The default
		/// constraint strategy is ALL_POINTS.
		/// </summary>
		// Token: 0x06017F5F RID: 98143 RVA: 0x0021878D File Offset: 0x0021698D
		public void SetSmoothingStrategyToAllPoints()
		{
			vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_SetSmoothingStrategyToAllPoints_31(base.GetCppThis());
		}

		// Token: 0x06017F60 RID: 98144
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeSmoothingFilter_SetSmoothingStrategyToSmoothingMask_32(HandleRef pThis);

		/// <summary>
		/// Indicate how to constrain smoothing of the attribute data. By default,
		/// all point data attributes are smoothed (ALL_POINTS). If ALL_BUT_BOUNDARY
		/// is selected, then all point attribute data except those on the boundary
		/// of the mesh are smoothed.  If ADJACENT_TO_BOUNDARY is selected, then
		/// only point data connected to a boundary point are smoothed, but boundary
		/// and interior points are not. (ALL_BUT_BOUNDARY and ADJACENT_TO_BOUNDARY
		/// are useful for transitioning from fixed boundary conditions to interior
		/// data.) If desired, it is possible to explicitly specify a smoothing mask
		/// controlling which points are smoothed and not smoothed. The default
		/// constraint strategy is ALL_POINTS.
		/// </summary>
		// Token: 0x06017F61 RID: 98145 RVA: 0x0021879C File Offset: 0x0021699C
		public void SetSmoothingStrategyToSmoothingMask()
		{
			vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_SetSmoothingStrategyToSmoothingMask_32(base.GetCppThis());
		}

		// Token: 0x06017F62 RID: 98146
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeSmoothingFilter_SetWeightsType_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate how to compute weights, using 1) a simple average of all
		/// connected points in the stencil; 2) a distance-weighted (i.e., 1/r)
		/// approach; or 3) distance**2-weighted (i.e., 1/(r**2) interpolation
		/// weights). The default constraint strategy is distance**2-weighted (i.e.,
		/// DISTANCE2).
		/// </summary>
		// Token: 0x06017F63 RID: 98147 RVA: 0x002187AB File Offset: 0x002169AB
		public virtual void SetWeightsType(int _arg)
		{
			vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_SetWeightsType_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06017F64 RID: 98148
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeSmoothingFilter_SetWeightsTypeToAverage_34(HandleRef pThis);

		/// <summary>
		/// Indicate how to compute weights, using 1) a simple average of all
		/// connected points in the stencil; 2) a distance-weighted (i.e., 1/r)
		/// approach; or 3) distance**2-weighted (i.e., 1/(r**2) interpolation
		/// weights). The default constraint strategy is distance**2-weighted (i.e.,
		/// DISTANCE2).
		/// </summary>
		// Token: 0x06017F65 RID: 98149 RVA: 0x002187BB File Offset: 0x002169BB
		public void SetWeightsTypeToAverage()
		{
			vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_SetWeightsTypeToAverage_34(base.GetCppThis());
		}

		// Token: 0x06017F66 RID: 98150
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeSmoothingFilter_SetWeightsTypeToDistance_35(HandleRef pThis);

		/// <summary>
		/// Indicate how to compute weights, using 1) a simple average of all
		/// connected points in the stencil; 2) a distance-weighted (i.e., 1/r)
		/// approach; or 3) distance**2-weighted (i.e., 1/(r**2) interpolation
		/// weights). The default constraint strategy is distance**2-weighted (i.e.,
		/// DISTANCE2).
		/// </summary>
		// Token: 0x06017F67 RID: 98151 RVA: 0x002187CA File Offset: 0x002169CA
		public void SetWeightsTypeToDistance()
		{
			vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_SetWeightsTypeToDistance_35(base.GetCppThis());
		}

		// Token: 0x06017F68 RID: 98152
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAttributeSmoothingFilter_SetWeightsTypeToDistance2_36(HandleRef pThis);

		/// <summary>
		/// Indicate how to compute weights, using 1) a simple average of all
		/// connected points in the stencil; 2) a distance-weighted (i.e., 1/r)
		/// approach; or 3) distance**2-weighted (i.e., 1/(r**2) interpolation
		/// weights). The default constraint strategy is distance**2-weighted (i.e.,
		/// DISTANCE2).
		/// </summary>
		// Token: 0x06017F69 RID: 98153 RVA: 0x002187D9 File Offset: 0x002169D9
		public void SetWeightsTypeToDistance2()
		{
			vtkAttributeSmoothingFilter.vtkAttributeSmoothingFilter_SetWeightsTypeToDistance2_36(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AAD RID: 6829
		public new const string MRFullTypeName = "Kitware.VTK.vtkAttributeSmoothingFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AAE RID: 6830
		public new static readonly string MRClassNameKey = "class vtkAttributeSmoothingFilter";

		/// <summary>
		/// Specify the smoothing mask to use (which takes effect only when a
		/// SMOOTHING_MASK smoothing strategy is specified). The smoothing mask is a
		/// vtkUnsignedCharArray with a value ==1 at all points whose attributes are
		/// to be smoothed.  The size of the data array must match the number of
		/// input points. If there is a mismatch between the size of the smoothing
		/// mask, and the number of input points, then an ALL_POINTS smoothing
		/// strategy is used.
		/// </summary>
		// Token: 0x02000905 RID: 2309
		public enum InterpolationWeightsType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001AB0 RID: 6832
			AVERAGE,
			/// <summary>enum member</summary>
			// Token: 0x04001AB1 RID: 6833
			DISTANCE,
			/// <summary>enum member</summary>
			// Token: 0x04001AB2 RID: 6834
			DISTANCE2
		}

		/// <summary>
		/// Specify the relaxation factor for smoothing. As in all iterative
		/// methods, the stability of the process is sensitive to this parameter. In
		/// general, small relaxation factors and large numbers of iterations are
		/// more stable than larger relaxation factors and smaller numbers of
		/// iterations. The default value is 0.10.
		/// </summary>
		// Token: 0x02000906 RID: 2310
		public enum SmoothingStrategyType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001AB4 RID: 6836
			ADJACENT_TO_BOUNDARY = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001AB5 RID: 6837
			ALL_BUT_BOUNDARY = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001AB6 RID: 6838
			ALL_POINTS = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001AB7 RID: 6839
			SMOOTHING_MASK = 3
		}
	}
}
