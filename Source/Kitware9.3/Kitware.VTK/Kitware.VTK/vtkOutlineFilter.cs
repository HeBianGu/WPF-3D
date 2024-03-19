using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOutlineFilter
	/// </summary>
	/// <remarks>
	///    create wireframe outline for an arbitrary data set or composite dataset
	///
	/// vtkOutlineFilter is a filter that generates a wireframe outline of any
	/// dataset or composite dataset. An outline consists of the twelve edges of
	/// the dataset bounding box. An option exists for generating faces instead of
	/// a wireframe outline.
	///
	/// @warning
	/// When an input composite dataset is provided, options exist for producing
	/// different styles of outline(s). Also, if the composite dataset has
	/// non-geometric members (like tables) the result is unpredictable.
	///
	/// @warning
	/// Specialized versions of the outline filter are also available. For example
	/// see vtkStructuredGridOutlineFilter, vtkRectilinearGridOutlineFilter, and
	/// vtkImageDataOutlineFilter.
	/// </remarks>
	// Token: 0x02000563 RID: 1379
	public class vtkOutlineFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F41A RID: 62490 RVA: 0x0015403B File Offset: 0x0015223B
		static vtkOutlineFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOutlineFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOutlineFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F41B RID: 62491 RVA: 0x00154063 File Offset: 0x00152263
		public vtkOutlineFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F41C RID: 62492
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOutlineFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation. type information, and printing.
		/// </summary>
		// Token: 0x0600F41D RID: 62493 RVA: 0x00154074 File Offset: 0x00152274
		public new static vtkOutlineFilter New()
		{
			vtkOutlineFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOutlineFilter.vtkOutlineFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOutlineFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation. type information, and printing.
		/// </summary>
		// Token: 0x0600F41E RID: 62494 RVA: 0x001540C8 File Offset: 0x001522C8
		public vtkOutlineFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOutlineFilter.vtkOutlineFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F41F RID: 62495 RVA: 0x0015410C File Offset: 0x0015230C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F420 RID: 62496
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutlineFilter_AddIndex_01(HandleRef pThis, uint index);

		/// <summary>
		/// If the composite style is set to SpecifiedIndex, then one or more flat
		/// indices can be specified, and bounding boxes will be drawn around those
		/// pieces of the composite dataset. (Recall that the flat index is a
		/// non-negative integer, with root index=0, increasing in perorder
		/// (depth-first) traversal order.
		/// </summary>
		// Token: 0x0600F421 RID: 62497 RVA: 0x00154117 File Offset: 0x00152317
		public void AddIndex(uint index)
		{
			vtkOutlineFilter.vtkOutlineFilter_AddIndex_01(base.GetCppThis(), index);
		}

		// Token: 0x0600F422 RID: 62498
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutlineFilter_GenerateFacesOff_02(HandleRef pThis);

		/// <summary>
		/// Generate solid faces for the box. This is off by default.
		/// </summary>
		// Token: 0x0600F423 RID: 62499 RVA: 0x00154127 File Offset: 0x00152327
		public virtual void GenerateFacesOff()
		{
			vtkOutlineFilter.vtkOutlineFilter_GenerateFacesOff_02(base.GetCppThis());
		}

		// Token: 0x0600F424 RID: 62500
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutlineFilter_GenerateFacesOn_03(HandleRef pThis);

		/// <summary>
		/// Generate solid faces for the box. This is off by default.
		/// </summary>
		// Token: 0x0600F425 RID: 62501 RVA: 0x00154136 File Offset: 0x00152336
		public virtual void GenerateFacesOn()
		{
			vtkOutlineFilter.vtkOutlineFilter_GenerateFacesOn_03(base.GetCppThis());
		}

		// Token: 0x0600F426 RID: 62502
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOutlineFilter_GetCompositeStyle_04(HandleRef pThis);

		/// <summary>
		/// Specify a style for creating bounding boxes around input composite
		/// datasets. (If the filter input is a vtkDataSet type these options have
		/// no effect.) There are four choices: 1) place a bounding box around the
		/// root of the vtkCompositeDataSet (i.e., all of the data); 2) place
		/// separate bounding boxes around each vtkDataSet leaf of the composite
		/// dataset; 3) place a bounding box around the root and all dataset leaves;
		/// and 4) place a bounding box around each (flat) index of the composite
		/// dataset. The default behavior is both root and leafs.
		/// </summary>
		// Token: 0x0600F427 RID: 62503 RVA: 0x00154148 File Offset: 0x00152348
		public virtual int GetCompositeStyle()
		{
			return vtkOutlineFilter.vtkOutlineFilter_GetCompositeStyle_04(base.GetCppThis());
		}

		// Token: 0x0600F428 RID: 62504
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOutlineFilter_GetGenerateFaces_05(HandleRef pThis);

		/// <summary>
		/// Generate solid faces for the box. This is off by default.
		/// </summary>
		// Token: 0x0600F429 RID: 62505 RVA: 0x00154168 File Offset: 0x00152368
		public virtual int GetGenerateFaces()
		{
			return vtkOutlineFilter.vtkOutlineFilter_GetGenerateFaces_05(base.GetCppThis());
		}

		// Token: 0x0600F42A RID: 62506
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOutlineFilter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation. type information, and printing.
		/// </summary>
		// Token: 0x0600F42B RID: 62507 RVA: 0x00154188 File Offset: 0x00152388
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOutlineFilter.vtkOutlineFilter_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0600F42C RID: 62508
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOutlineFilter_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation. type information, and printing.
		/// </summary>
		// Token: 0x0600F42D RID: 62509 RVA: 0x001541A8 File Offset: 0x001523A8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOutlineFilter.vtkOutlineFilter_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0600F42E RID: 62510
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOutlineFilter_GetOutputPointsPrecision_08(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x0600F42F RID: 62511 RVA: 0x001541C4 File Offset: 0x001523C4
		public virtual int GetOutputPointsPrecision()
		{
			return vtkOutlineFilter.vtkOutlineFilter_GetOutputPointsPrecision_08(base.GetCppThis());
		}

		// Token: 0x0600F430 RID: 62512
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOutlineFilter_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation. type information, and printing.
		/// </summary>
		// Token: 0x0600F431 RID: 62513 RVA: 0x001541E4 File Offset: 0x001523E4
		public override int IsA(string type)
		{
			return vtkOutlineFilter.vtkOutlineFilter_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0600F432 RID: 62514
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOutlineFilter_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation. type information, and printing.
		/// </summary>
		// Token: 0x0600F433 RID: 62515 RVA: 0x00154204 File Offset: 0x00152404
		public new static int IsTypeOf(string type)
		{
			return vtkOutlineFilter.vtkOutlineFilter_IsTypeOf_10(type);
		}

		// Token: 0x0600F434 RID: 62516
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOutlineFilter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation. type information, and printing.
		/// </summary>
		// Token: 0x0600F435 RID: 62517 RVA: 0x00154220 File Offset: 0x00152420
		public new vtkOutlineFilter NewInstance()
		{
			vtkOutlineFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOutlineFilter.vtkOutlineFilter_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOutlineFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F436 RID: 62518
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutlineFilter_RemoveAllIndices_13(HandleRef pThis);

		/// <summary>
		/// If the composite style is set to SpecifiedIndex, then one or more flat
		/// indices can be specified, and bounding boxes will be drawn around those
		/// pieces of the composite dataset. (Recall that the flat index is a
		/// non-negative integer, with root index=0, increasing in perorder
		/// (depth-first) traversal order.
		/// </summary>
		// Token: 0x0600F437 RID: 62519 RVA: 0x0015427A File Offset: 0x0015247A
		public void RemoveAllIndices()
		{
			vtkOutlineFilter.vtkOutlineFilter_RemoveAllIndices_13(base.GetCppThis());
		}

		// Token: 0x0600F438 RID: 62520
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutlineFilter_RemoveIndex_14(HandleRef pThis, uint index);

		/// <summary>
		/// If the composite style is set to SpecifiedIndex, then one or more flat
		/// indices can be specified, and bounding boxes will be drawn around those
		/// pieces of the composite dataset. (Recall that the flat index is a
		/// non-negative integer, with root index=0, increasing in perorder
		/// (depth-first) traversal order.
		/// </summary>
		// Token: 0x0600F439 RID: 62521 RVA: 0x00154289 File Offset: 0x00152489
		public void RemoveIndex(uint index)
		{
			vtkOutlineFilter.vtkOutlineFilter_RemoveIndex_14(base.GetCppThis(), index);
		}

		// Token: 0x0600F43A RID: 62522
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOutlineFilter_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation. type information, and printing.
		/// </summary>
		// Token: 0x0600F43B RID: 62523 RVA: 0x0015429C File Offset: 0x0015249C
		public new static vtkOutlineFilter SafeDownCast(vtkObjectBase o)
		{
			vtkOutlineFilter vtkOutlineFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOutlineFilter.vtkOutlineFilter_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOutlineFilter = (vtkOutlineFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOutlineFilter.Register(null);
				}
			}
			return vtkOutlineFilter;
		}

		// Token: 0x0600F43C RID: 62524
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutlineFilter_SetCompositeStyle_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify a style for creating bounding boxes around input composite
		/// datasets. (If the filter input is a vtkDataSet type these options have
		/// no effect.) There are four choices: 1) place a bounding box around the
		/// root of the vtkCompositeDataSet (i.e., all of the data); 2) place
		/// separate bounding boxes around each vtkDataSet leaf of the composite
		/// dataset; 3) place a bounding box around the root and all dataset leaves;
		/// and 4) place a bounding box around each (flat) index of the composite
		/// dataset. The default behavior is both root and leafs.
		/// </summary>
		// Token: 0x0600F43D RID: 62525 RVA: 0x0015431B File Offset: 0x0015251B
		public virtual void SetCompositeStyle(int _arg)
		{
			vtkOutlineFilter.vtkOutlineFilter_SetCompositeStyle_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F43E RID: 62526
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutlineFilter_SetCompositeStyleToLeafs_17(HandleRef pThis);

		/// <summary>
		/// Specify a style for creating bounding boxes around input composite
		/// datasets. (If the filter input is a vtkDataSet type these options have
		/// no effect.) There are four choices: 1) place a bounding box around the
		/// root of the vtkCompositeDataSet (i.e., all of the data); 2) place
		/// separate bounding boxes around each vtkDataSet leaf of the composite
		/// dataset; 3) place a bounding box around the root and all dataset leaves;
		/// and 4) place a bounding box around each (flat) index of the composite
		/// dataset. The default behavior is both root and leafs.
		/// </summary>
		// Token: 0x0600F43F RID: 62527 RVA: 0x0015432B File Offset: 0x0015252B
		public void SetCompositeStyleToLeafs()
		{
			vtkOutlineFilter.vtkOutlineFilter_SetCompositeStyleToLeafs_17(base.GetCppThis());
		}

		// Token: 0x0600F440 RID: 62528
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutlineFilter_SetCompositeStyleToRoot_18(HandleRef pThis);

		/// <summary>
		/// Specify a style for creating bounding boxes around input composite
		/// datasets. (If the filter input is a vtkDataSet type these options have
		/// no effect.) There are four choices: 1) place a bounding box around the
		/// root of the vtkCompositeDataSet (i.e., all of the data); 2) place
		/// separate bounding boxes around each vtkDataSet leaf of the composite
		/// dataset; 3) place a bounding box around the root and all dataset leaves;
		/// and 4) place a bounding box around each (flat) index of the composite
		/// dataset. The default behavior is both root and leafs.
		/// </summary>
		// Token: 0x0600F441 RID: 62529 RVA: 0x0015433A File Offset: 0x0015253A
		public void SetCompositeStyleToRoot()
		{
			vtkOutlineFilter.vtkOutlineFilter_SetCompositeStyleToRoot_18(base.GetCppThis());
		}

		// Token: 0x0600F442 RID: 62530
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutlineFilter_SetCompositeStyleToRootAndLeafs_19(HandleRef pThis);

		/// <summary>
		/// Specify a style for creating bounding boxes around input composite
		/// datasets. (If the filter input is a vtkDataSet type these options have
		/// no effect.) There are four choices: 1) place a bounding box around the
		/// root of the vtkCompositeDataSet (i.e., all of the data); 2) place
		/// separate bounding boxes around each vtkDataSet leaf of the composite
		/// dataset; 3) place a bounding box around the root and all dataset leaves;
		/// and 4) place a bounding box around each (flat) index of the composite
		/// dataset. The default behavior is both root and leafs.
		/// </summary>
		// Token: 0x0600F443 RID: 62531 RVA: 0x00154349 File Offset: 0x00152549
		public void SetCompositeStyleToRootAndLeafs()
		{
			vtkOutlineFilter.vtkOutlineFilter_SetCompositeStyleToRootAndLeafs_19(base.GetCppThis());
		}

		// Token: 0x0600F444 RID: 62532
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutlineFilter_SetCompositeStyleToSpecifiedIndex_20(HandleRef pThis);

		/// <summary>
		/// Specify a style for creating bounding boxes around input composite
		/// datasets. (If the filter input is a vtkDataSet type these options have
		/// no effect.) There are four choices: 1) place a bounding box around the
		/// root of the vtkCompositeDataSet (i.e., all of the data); 2) place
		/// separate bounding boxes around each vtkDataSet leaf of the composite
		/// dataset; 3) place a bounding box around the root and all dataset leaves;
		/// and 4) place a bounding box around each (flat) index of the composite
		/// dataset. The default behavior is both root and leafs.
		/// </summary>
		// Token: 0x0600F445 RID: 62533 RVA: 0x00154358 File Offset: 0x00152558
		public void SetCompositeStyleToSpecifiedIndex()
		{
			vtkOutlineFilter.vtkOutlineFilter_SetCompositeStyleToSpecifiedIndex_20(base.GetCppThis());
		}

		// Token: 0x0600F446 RID: 62534
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutlineFilter_SetGenerateFaces_21(HandleRef pThis, int _arg);

		/// <summary>
		/// Generate solid faces for the box. This is off by default.
		/// </summary>
		// Token: 0x0600F447 RID: 62535 RVA: 0x00154367 File Offset: 0x00152567
		public virtual void SetGenerateFaces(int _arg)
		{
			vtkOutlineFilter.vtkOutlineFilter_SetGenerateFaces_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F448 RID: 62536
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutlineFilter_SetOutputPointsPrecision_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
		/// </summary>
		// Token: 0x0600F449 RID: 62537 RVA: 0x00154377 File Offset: 0x00152577
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkOutlineFilter.vtkOutlineFilter_SetOutputPointsPrecision_22(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011D1 RID: 4561
		public new const string MRFullTypeName = "Kitware.VTK.vtkOutlineFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011D2 RID: 4562
		public new static readonly string MRClassNameKey = "class vtkOutlineFilter";

		/// <summary>
		/// Generate solid faces for the box. This is off by default.
		/// </summary>
		// Token: 0x02000564 RID: 1380
		public enum CompositeOutlineStyle
		{
			/// <summary>enum member</summary>
			// Token: 0x040011D4 RID: 4564
			LEAF_DATASETS = 1,
			/// <summary>enum member</summary>
			// Token: 0x040011D5 RID: 4565
			ROOT_AND_LEAFS,
			/// <summary>enum member</summary>
			// Token: 0x040011D6 RID: 4566
			ROOT_LEVEL = 0,
			/// <summary>enum member</summary>
			// Token: 0x040011D7 RID: 4567
			SPECIFIED_INDEX = 3
		}
	}
}
