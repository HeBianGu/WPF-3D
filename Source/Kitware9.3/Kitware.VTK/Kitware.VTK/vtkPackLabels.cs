using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPackLabels
	/// </summary>
	/// <remarks>
	///    renumber segmentation labels into contiguous runs of (potentially) smaller type
	///
	/// vtkPackLabels is a filter that renumbers a set of segmentation labels into
	/// a contiguous sequence of label values. The input segmentation labels are
	/// represented by a scalar array of arbitrary type, and the labels may be
	/// non-contiguous (i.e., there may be "gaps" in the labels used to annotate
	/// structured in the segmentation). After execution, the output of this
	/// filter consists of (by default) an output of the same dataset type as the
	/// input; however the labels are renumbered so that they are contiguous
	/// (starting with value==0, [0,NumberOfLabels)). After filter execution, an
	/// array of labels present in the input can be retrieved (named
	/// "PackedLabels"), listed in ascending order, this is useful in various
	/// filters such as discrete isocontouring filters which require
	/// iso/label-values (e.g., vtkSurfaceNets3D).
	///
	/// Note that this filter mostly works on input dataset types of vtkImageData
	/// (segmentation maps are commonly used in medical computing). However,
	/// because this filter operates on scalar point or cell data independent of
	/// dataset type, it has been generalized to work on any dataset type.
	///
	/// The filter also converts the input data from one type to another. By
	/// default, the output labels are of an unsigned integral type large enough
	/// to represent the N packed label values. It is also possible to explicitly
	/// specify the type of the output annotation/label image. This conversion
	/// capability often reduces the size of the output image, and can be used is
	/// useful when an algorithm performs better, or requires, a certain type of
	/// input data. Note however, that manual specification can be dangerous:
	/// trying to pack a large number of labels into a manually specified reduced
	/// precision label values may result in setting some label values to the
	/// BackgroundValue.
	///
	/// Finally, in advanced usage, it is possible to control how sorting of the
	/// output labels is performed. By default, the labels are assorted based on
	/// their associated input label values (SortByLabelValue). However, it is
	/// possible to arrange the labels based on their frequency of use
	/// (SortByLabelCount). Sorting is useful for gathering data statistics, or to
	/// extract and display the segmented objects that are the "largest" in the
	/// dataset.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSurfaceNets3D vtkSurfaceNets2D vtkDiscreteFlyingEdges3D
	/// vtkDiscreteMarchingCubes
	/// </seealso>
	// Token: 0x02000983 RID: 2435
	public class vtkPackLabels : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060195A7 RID: 103847 RVA: 0x00235519 File Offset: 0x00233719
		static vtkPackLabels()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPackLabels.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPackLabels"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060195A8 RID: 103848 RVA: 0x00235541 File Offset: 0x00233741
		public vtkPackLabels(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060195A9 RID: 103849
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPackLabels_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing an object.
		/// </summary>
		// Token: 0x060195AA RID: 103850 RVA: 0x00235550 File Offset: 0x00233750
		public new static vtkPackLabels New()
		{
			vtkPackLabels result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPackLabels.vtkPackLabels_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPackLabels)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing an object.
		/// </summary>
		// Token: 0x060195AB RID: 103851 RVA: 0x002355A4 File Offset: 0x002337A4
		public vtkPackLabels() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPackLabels.vtkPackLabels_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060195AC RID: 103852 RVA: 0x002355E8 File Offset: 0x002337E8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060195AD RID: 103853
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkPackLabels_GetBackgroundValue_01(HandleRef pThis);

		/// <summary>
		/// Specify a background label value. This value is used when the ith label is
		/// i &gt;= N where N is the number of labels that the OutputScalarType can represent.
		/// So for example, when trying to pack 500 labels into an unsigned char output scalar
		/// type, all i labels i&gt;=256 would be set to this background value. By default the
		/// BackgroundValue == 0.
		/// </summary>
		// Token: 0x060195AE RID: 103854 RVA: 0x002355F4 File Offset: 0x002337F4
		public virtual uint GetBackgroundValue()
		{
			return vtkPackLabels.vtkPackLabels_GetBackgroundValue_01(base.GetCppThis());
		}

		// Token: 0x060195AF RID: 103855
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPackLabels_GetLabels_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the number of and list of labels found in the input label map.
		/// The methods return a vtkDataArray with the same data type as the input
		/// scalar type. By default, the labels are sorted in ascending order based
		/// on the input data (label) values (i.e., SortByLabelValue). However, if
		/// SortByLabelCount is specified, then the labels are sorted in descending
		/// order based on their frequency of occurrence (i.e., their counts).
		/// </summary>
		// Token: 0x060195B0 RID: 103856 RVA: 0x00235614 File Offset: 0x00233814
		public vtkDataArray GetLabels()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPackLabels.vtkPackLabels_GetLabels_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		// Token: 0x060195B1 RID: 103857
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPackLabels_GetLabelsCount_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the frequency of occurrence (i.e., the count) of each label
		/// returned in the LabelsArray. The methods returns a vtkIdTypeArray that is
		/// implicitly ordered consistent with the LabelsArray (i.e., LabelsCount[i]
		/// gives the frequency count for LabelsArray[i]). Note that if
		/// SortByLabelCount is set, then the labels array and labels count are
		/// sorted in descending order based on the frequency of occurrence of
		/// labels. If SortByLabelValue is set, then the labels array and label
		/// counts are sorted in ascending order based on input label values. Also
		/// note that the size of the LabelsCount array is identical to the size
		/// of the LabelsCount array.
		/// </summary>
		// Token: 0x060195B2 RID: 103858 RVA: 0x00235684 File Offset: 0x00233884
		public vtkIdTypeArray GetLabelsCount()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPackLabels.vtkPackLabels_GetLabelsCount_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		// Token: 0x060195B3 RID: 103859
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPackLabels_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing an object.
		/// </summary>
		// Token: 0x060195B4 RID: 103860 RVA: 0x002356F4 File Offset: 0x002338F4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPackLabels.vtkPackLabels_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060195B5 RID: 103861
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPackLabels_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing an object.
		/// </summary>
		// Token: 0x060195B6 RID: 103862 RVA: 0x00235714 File Offset: 0x00233914
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPackLabels.vtkPackLabels_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060195B7 RID: 103863
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPackLabels_GetNumberOfLabels_06(HandleRef pThis);

		/// <summary>
		/// Return the number of and list of labels found in the input label map.
		/// The methods return a vtkDataArray with the same data type as the input
		/// scalar type. By default, the labels are sorted in ascending order based
		/// on the input data (label) values (i.e., SortByLabelValue). However, if
		/// SortByLabelCount is specified, then the labels are sorted in descending
		/// order based on their frequency of occurrence (i.e., their counts).
		/// </summary>
		// Token: 0x060195B8 RID: 103864 RVA: 0x00235730 File Offset: 0x00233930
		public long GetNumberOfLabels()
		{
			return vtkPackLabels.vtkPackLabels_GetNumberOfLabels_06(base.GetCppThis());
		}

		// Token: 0x060195B9 RID: 103865
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPackLabels_GetOutputScalarType_07(HandleRef pThis);

		/// <summary>
		/// Specify the data type of the output image. The choice for output type is
		/// an unsigned integral type. Note that DEFAULT_TYPE value indicates that
		/// the output data type will be of a type large enough to represent the N
		/// labels present in the input (this is on by default). Explicit
		/// specification of the output type can cause labels in the input scalars
		/// to be replaced with the BackgroundValue in the output scalars. This
		/// occurs when trying to represent N labels in a data type that cannot
		/// represent all N values (e.g., trying to pack 500 labels unto an unsigned
		/// char packed label map).
		/// </summary>
		// Token: 0x060195BA RID: 103866 RVA: 0x00235750 File Offset: 0x00233950
		public virtual int GetOutputScalarType()
		{
			return vtkPackLabels.vtkPackLabels_GetOutputScalarType_07(base.GetCppThis());
		}

		// Token: 0x060195BB RID: 103867
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPackLabels_GetPassCellData_08(HandleRef pThis);

		/// <summary>
		/// Indicate whether to pass point data, cell data, and/or field data
		/// through to the output. This can be useful to limit the data being
		/// processed down a pipeline, including writing output files. By default,
		/// point data and cell data is passed from input to output.
		/// </summary>
		// Token: 0x060195BC RID: 103868 RVA: 0x00235770 File Offset: 0x00233970
		public virtual bool GetPassCellData()
		{
			return vtkPackLabels.vtkPackLabels_GetPassCellData_08(base.GetCppThis()) != 0;
		}

		// Token: 0x060195BD RID: 103869
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPackLabels_GetPassFieldData_09(HandleRef pThis);

		/// <summary>
		/// Indicate whether to pass point data, cell data, and/or field data
		/// through to the output. This can be useful to limit the data being
		/// processed down a pipeline, including writing output files. By default,
		/// point data and cell data is passed from input to output.
		/// </summary>
		// Token: 0x060195BE RID: 103870 RVA: 0x00235798 File Offset: 0x00233998
		public virtual bool GetPassFieldData()
		{
			return vtkPackLabels.vtkPackLabels_GetPassFieldData_09(base.GetCppThis()) != 0;
		}

		// Token: 0x060195BF RID: 103871
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPackLabels_GetPassPointData_10(HandleRef pThis);

		/// <summary>
		/// Indicate whether to pass point data, cell data, and/or field data
		/// through to the output. This can be useful to limit the data being
		/// processed down a pipeline, including writing output files. By default,
		/// point data and cell data is passed from input to output.
		/// </summary>
		// Token: 0x060195C0 RID: 103872 RVA: 0x002357C0 File Offset: 0x002339C0
		public virtual bool GetPassPointData()
		{
			return vtkPackLabels.vtkPackLabels_GetPassPointData_10(base.GetCppThis()) != 0;
		}

		// Token: 0x060195C1 RID: 103873
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPackLabels_GetSortBy_11(HandleRef pThis);

		/// <summary>
		/// Indicate whether to sort the output labels by their input scalars label
		/// value (SortByLabelValue), or to sort by the frequency of occurrence of
		/// the label values(SortByLabelCount). By default, sorting is performed by
		/// label value.  Note that typically the background label has the highest
		/// frequency of occurrence, with a label value == 0 (but this is not a
		/// guarantee).
		/// </summary>
		// Token: 0x060195C2 RID: 103874 RVA: 0x002357E8 File Offset: 0x002339E8
		public virtual int GetSortBy()
		{
			return vtkPackLabels.vtkPackLabels_GetSortBy_11(base.GetCppThis());
		}

		// Token: 0x060195C3 RID: 103875
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPackLabels_GetSortByMaxValue_12(HandleRef pThis);

		/// <summary>
		/// Indicate whether to sort the output labels by their input scalars label
		/// value (SortByLabelValue), or to sort by the frequency of occurrence of
		/// the label values(SortByLabelCount). By default, sorting is performed by
		/// label value.  Note that typically the background label has the highest
		/// frequency of occurrence, with a label value == 0 (but this is not a
		/// guarantee).
		/// </summary>
		// Token: 0x060195C4 RID: 103876 RVA: 0x00235808 File Offset: 0x00233A08
		public virtual int GetSortByMaxValue()
		{
			return vtkPackLabels.vtkPackLabels_GetSortByMaxValue_12(base.GetCppThis());
		}

		// Token: 0x060195C5 RID: 103877
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPackLabels_GetSortByMinValue_13(HandleRef pThis);

		/// <summary>
		/// Indicate whether to sort the output labels by their input scalars label
		/// value (SortByLabelValue), or to sort by the frequency of occurrence of
		/// the label values(SortByLabelCount). By default, sorting is performed by
		/// label value.  Note that typically the background label has the highest
		/// frequency of occurrence, with a label value == 0 (but this is not a
		/// guarantee).
		/// </summary>
		// Token: 0x060195C6 RID: 103878 RVA: 0x00235828 File Offset: 0x00233A28
		public virtual int GetSortByMinValue()
		{
			return vtkPackLabels.vtkPackLabels_GetSortByMinValue_13(base.GetCppThis());
		}

		// Token: 0x060195C7 RID: 103879
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPackLabels_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing an object.
		/// </summary>
		// Token: 0x060195C8 RID: 103880 RVA: 0x00235848 File Offset: 0x00233A48
		public override int IsA(string type)
		{
			return vtkPackLabels.vtkPackLabels_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x060195C9 RID: 103881
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPackLabels_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing an object.
		/// </summary>
		// Token: 0x060195CA RID: 103882 RVA: 0x00235868 File Offset: 0x00233A68
		public new static int IsTypeOf(string type)
		{
			return vtkPackLabels.vtkPackLabels_IsTypeOf_15(type);
		}

		// Token: 0x060195CB RID: 103883
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPackLabels_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing an object.
		/// </summary>
		// Token: 0x060195CC RID: 103884 RVA: 0x00235884 File Offset: 0x00233A84
		public new vtkPackLabels NewInstance()
		{
			vtkPackLabels result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPackLabels.vtkPackLabels_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPackLabels)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060195CD RID: 103885
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPackLabels_PassCellDataOff_18(HandleRef pThis);

		/// <summary>
		/// Indicate whether to pass point data, cell data, and/or field data
		/// through to the output. This can be useful to limit the data being
		/// processed down a pipeline, including writing output files. By default,
		/// point data and cell data is passed from input to output.
		/// </summary>
		// Token: 0x060195CE RID: 103886 RVA: 0x002358DE File Offset: 0x00233ADE
		public virtual void PassCellDataOff()
		{
			vtkPackLabels.vtkPackLabels_PassCellDataOff_18(base.GetCppThis());
		}

		// Token: 0x060195CF RID: 103887
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPackLabels_PassCellDataOn_19(HandleRef pThis);

		/// <summary>
		/// Indicate whether to pass point data, cell data, and/or field data
		/// through to the output. This can be useful to limit the data being
		/// processed down a pipeline, including writing output files. By default,
		/// point data and cell data is passed from input to output.
		/// </summary>
		// Token: 0x060195D0 RID: 103888 RVA: 0x002358ED File Offset: 0x00233AED
		public virtual void PassCellDataOn()
		{
			vtkPackLabels.vtkPackLabels_PassCellDataOn_19(base.GetCppThis());
		}

		// Token: 0x060195D1 RID: 103889
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPackLabels_PassFieldDataOff_20(HandleRef pThis);

		/// <summary>
		/// Indicate whether to pass point data, cell data, and/or field data
		/// through to the output. This can be useful to limit the data being
		/// processed down a pipeline, including writing output files. By default,
		/// point data and cell data is passed from input to output.
		/// </summary>
		// Token: 0x060195D2 RID: 103890 RVA: 0x002358FC File Offset: 0x00233AFC
		public virtual void PassFieldDataOff()
		{
			vtkPackLabels.vtkPackLabels_PassFieldDataOff_20(base.GetCppThis());
		}

		// Token: 0x060195D3 RID: 103891
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPackLabels_PassFieldDataOn_21(HandleRef pThis);

		/// <summary>
		/// Indicate whether to pass point data, cell data, and/or field data
		/// through to the output. This can be useful to limit the data being
		/// processed down a pipeline, including writing output files. By default,
		/// point data and cell data is passed from input to output.
		/// </summary>
		// Token: 0x060195D4 RID: 103892 RVA: 0x0023590B File Offset: 0x00233B0B
		public virtual void PassFieldDataOn()
		{
			vtkPackLabels.vtkPackLabels_PassFieldDataOn_21(base.GetCppThis());
		}

		// Token: 0x060195D5 RID: 103893
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPackLabels_PassPointDataOff_22(HandleRef pThis);

		/// <summary>
		/// Indicate whether to pass point data, cell data, and/or field data
		/// through to the output. This can be useful to limit the data being
		/// processed down a pipeline, including writing output files. By default,
		/// point data and cell data is passed from input to output.
		/// </summary>
		// Token: 0x060195D6 RID: 103894 RVA: 0x0023591A File Offset: 0x00233B1A
		public virtual void PassPointDataOff()
		{
			vtkPackLabels.vtkPackLabels_PassPointDataOff_22(base.GetCppThis());
		}

		// Token: 0x060195D7 RID: 103895
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPackLabels_PassPointDataOn_23(HandleRef pThis);

		/// <summary>
		/// Indicate whether to pass point data, cell data, and/or field data
		/// through to the output. This can be useful to limit the data being
		/// processed down a pipeline, including writing output files. By default,
		/// point data and cell data is passed from input to output.
		/// </summary>
		// Token: 0x060195D8 RID: 103896 RVA: 0x00235929 File Offset: 0x00233B29
		public virtual void PassPointDataOn()
		{
			vtkPackLabels.vtkPackLabels_PassPointDataOn_23(base.GetCppThis());
		}

		// Token: 0x060195D9 RID: 103897
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPackLabels_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing an object.
		/// </summary>
		// Token: 0x060195DA RID: 103898 RVA: 0x00235938 File Offset: 0x00233B38
		public new static vtkPackLabels SafeDownCast(vtkObjectBase o)
		{
			vtkPackLabels vtkPackLabels = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPackLabels.vtkPackLabels_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPackLabels = (vtkPackLabels)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPackLabels.Register(null);
				}
			}
			return vtkPackLabels;
		}

		// Token: 0x060195DB RID: 103899
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPackLabels_SetBackgroundValue_25(HandleRef pThis, uint _arg);

		/// <summary>
		/// Specify a background label value. This value is used when the ith label is
		/// i &gt;= N where N is the number of labels that the OutputScalarType can represent.
		/// So for example, when trying to pack 500 labels into an unsigned char output scalar
		/// type, all i labels i&gt;=256 would be set to this background value. By default the
		/// BackgroundValue == 0.
		/// </summary>
		// Token: 0x060195DC RID: 103900 RVA: 0x002359B7 File Offset: 0x00233BB7
		public virtual void SetBackgroundValue(uint _arg)
		{
			vtkPackLabels.vtkPackLabels_SetBackgroundValue_25(base.GetCppThis(), _arg);
		}

		// Token: 0x060195DD RID: 103901
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPackLabels_SetOutputScalarType_26(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the data type of the output image. The choice for output type is
		/// an unsigned integral type. Note that DEFAULT_TYPE value indicates that
		/// the output data type will be of a type large enough to represent the N
		/// labels present in the input (this is on by default). Explicit
		/// specification of the output type can cause labels in the input scalars
		/// to be replaced with the BackgroundValue in the output scalars. This
		/// occurs when trying to represent N labels in a data type that cannot
		/// represent all N values (e.g., trying to pack 500 labels unto an unsigned
		/// char packed label map).
		/// </summary>
		// Token: 0x060195DE RID: 103902 RVA: 0x002359C7 File Offset: 0x00233BC7
		public virtual void SetOutputScalarType(int _arg)
		{
			vtkPackLabels.vtkPackLabels_SetOutputScalarType_26(base.GetCppThis(), _arg);
		}

		// Token: 0x060195DF RID: 103903
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPackLabels_SetOutputScalarTypeToDefault_27(HandleRef pThis);

		/// <summary>
		/// Specify the data type of the output image. The choice for output type is
		/// an unsigned integral type. Note that DEFAULT_TYPE value indicates that
		/// the output data type will be of a type large enough to represent the N
		/// labels present in the input (this is on by default). Explicit
		/// specification of the output type can cause labels in the input scalars
		/// to be replaced with the BackgroundValue in the output scalars. This
		/// occurs when trying to represent N labels in a data type that cannot
		/// represent all N values (e.g., trying to pack 500 labels unto an unsigned
		/// char packed label map).
		/// </summary>
		// Token: 0x060195E0 RID: 103904 RVA: 0x002359D7 File Offset: 0x00233BD7
		public void SetOutputScalarTypeToDefault()
		{
			vtkPackLabels.vtkPackLabels_SetOutputScalarTypeToDefault_27(base.GetCppThis());
		}

		// Token: 0x060195E1 RID: 103905
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPackLabels_SetOutputScalarTypeToUnsignedChar_28(HandleRef pThis);

		/// <summary>
		/// Specify the data type of the output image. The choice for output type is
		/// an unsigned integral type. Note that DEFAULT_TYPE value indicates that
		/// the output data type will be of a type large enough to represent the N
		/// labels present in the input (this is on by default). Explicit
		/// specification of the output type can cause labels in the input scalars
		/// to be replaced with the BackgroundValue in the output scalars. This
		/// occurs when trying to represent N labels in a data type that cannot
		/// represent all N values (e.g., trying to pack 500 labels unto an unsigned
		/// char packed label map).
		/// </summary>
		// Token: 0x060195E2 RID: 103906 RVA: 0x002359E6 File Offset: 0x00233BE6
		public void SetOutputScalarTypeToUnsignedChar()
		{
			vtkPackLabels.vtkPackLabels_SetOutputScalarTypeToUnsignedChar_28(base.GetCppThis());
		}

		// Token: 0x060195E3 RID: 103907
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPackLabels_SetOutputScalarTypeToUnsignedInt_29(HandleRef pThis);

		/// <summary>
		/// Specify the data type of the output image. The choice for output type is
		/// an unsigned integral type. Note that DEFAULT_TYPE value indicates that
		/// the output data type will be of a type large enough to represent the N
		/// labels present in the input (this is on by default). Explicit
		/// specification of the output type can cause labels in the input scalars
		/// to be replaced with the BackgroundValue in the output scalars. This
		/// occurs when trying to represent N labels in a data type that cannot
		/// represent all N values (e.g., trying to pack 500 labels unto an unsigned
		/// char packed label map).
		/// </summary>
		// Token: 0x060195E4 RID: 103908 RVA: 0x002359F5 File Offset: 0x00233BF5
		public void SetOutputScalarTypeToUnsignedInt()
		{
			vtkPackLabels.vtkPackLabels_SetOutputScalarTypeToUnsignedInt_29(base.GetCppThis());
		}

		// Token: 0x060195E5 RID: 103909
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPackLabels_SetOutputScalarTypeToUnsignedLong_30(HandleRef pThis);

		/// <summary>
		/// Specify the data type of the output image. The choice for output type is
		/// an unsigned integral type. Note that DEFAULT_TYPE value indicates that
		/// the output data type will be of a type large enough to represent the N
		/// labels present in the input (this is on by default). Explicit
		/// specification of the output type can cause labels in the input scalars
		/// to be replaced with the BackgroundValue in the output scalars. This
		/// occurs when trying to represent N labels in a data type that cannot
		/// represent all N values (e.g., trying to pack 500 labels unto an unsigned
		/// char packed label map).
		/// </summary>
		// Token: 0x060195E6 RID: 103910 RVA: 0x00235A04 File Offset: 0x00233C04
		public void SetOutputScalarTypeToUnsignedLong()
		{
			vtkPackLabels.vtkPackLabels_SetOutputScalarTypeToUnsignedLong_30(base.GetCppThis());
		}

		// Token: 0x060195E7 RID: 103911
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPackLabels_SetOutputScalarTypeToUnsignedShort_31(HandleRef pThis);

		/// <summary>
		/// Specify the data type of the output image. The choice for output type is
		/// an unsigned integral type. Note that DEFAULT_TYPE value indicates that
		/// the output data type will be of a type large enough to represent the N
		/// labels present in the input (this is on by default). Explicit
		/// specification of the output type can cause labels in the input scalars
		/// to be replaced with the BackgroundValue in the output scalars. This
		/// occurs when trying to represent N labels in a data type that cannot
		/// represent all N values (e.g., trying to pack 500 labels unto an unsigned
		/// char packed label map).
		/// </summary>
		// Token: 0x060195E8 RID: 103912 RVA: 0x00235A13 File Offset: 0x00233C13
		public void SetOutputScalarTypeToUnsignedShort()
		{
			vtkPackLabels.vtkPackLabels_SetOutputScalarTypeToUnsignedShort_31(base.GetCppThis());
		}

		// Token: 0x060195E9 RID: 103913
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPackLabels_SetPassCellData_32(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether to pass point data, cell data, and/or field data
		/// through to the output. This can be useful to limit the data being
		/// processed down a pipeline, including writing output files. By default,
		/// point data and cell data is passed from input to output.
		/// </summary>
		// Token: 0x060195EA RID: 103914 RVA: 0x00235A22 File Offset: 0x00233C22
		public virtual void SetPassCellData(bool _arg)
		{
			vtkPackLabels.vtkPackLabels_SetPassCellData_32(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060195EB RID: 103915
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPackLabels_SetPassFieldData_33(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether to pass point data, cell data, and/or field data
		/// through to the output. This can be useful to limit the data being
		/// processed down a pipeline, including writing output files. By default,
		/// point data and cell data is passed from input to output.
		/// </summary>
		// Token: 0x060195EC RID: 103916 RVA: 0x00235A3A File Offset: 0x00233C3A
		public virtual void SetPassFieldData(bool _arg)
		{
			vtkPackLabels.vtkPackLabels_SetPassFieldData_33(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060195ED RID: 103917
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPackLabels_SetPassPointData_34(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether to pass point data, cell data, and/or field data
		/// through to the output. This can be useful to limit the data being
		/// processed down a pipeline, including writing output files. By default,
		/// point data and cell data is passed from input to output.
		/// </summary>
		// Token: 0x060195EE RID: 103918 RVA: 0x00235A52 File Offset: 0x00233C52
		public virtual void SetPassPointData(bool _arg)
		{
			vtkPackLabels.vtkPackLabels_SetPassPointData_34(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060195EF RID: 103919
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPackLabels_SetSortBy_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate whether to sort the output labels by their input scalars label
		/// value (SortByLabelValue), or to sort by the frequency of occurrence of
		/// the label values(SortByLabelCount). By default, sorting is performed by
		/// label value.  Note that typically the background label has the highest
		/// frequency of occurrence, with a label value == 0 (but this is not a
		/// guarantee).
		/// </summary>
		// Token: 0x060195F0 RID: 103920 RVA: 0x00235A6A File Offset: 0x00233C6A
		public virtual void SetSortBy(int _arg)
		{
			vtkPackLabels.vtkPackLabels_SetSortBy_35(base.GetCppThis(), _arg);
		}

		// Token: 0x060195F1 RID: 103921
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPackLabels_SortByLabelCount_36(HandleRef pThis);

		/// <summary>
		/// Indicate whether to sort the output labels by their input scalars label
		/// value (SortByLabelValue), or to sort by the frequency of occurrence of
		/// the label values(SortByLabelCount). By default, sorting is performed by
		/// label value.  Note that typically the background label has the highest
		/// frequency of occurrence, with a label value == 0 (but this is not a
		/// guarantee).
		/// </summary>
		// Token: 0x060195F2 RID: 103922 RVA: 0x00235A7A File Offset: 0x00233C7A
		public void SortByLabelCount()
		{
			vtkPackLabels.vtkPackLabels_SortByLabelCount_36(base.GetCppThis());
		}

		// Token: 0x060195F3 RID: 103923
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPackLabels_SortByLabelValue_37(HandleRef pThis);

		/// <summary>
		/// Indicate whether to sort the output labels by their input scalars label
		/// value (SortByLabelValue), or to sort by the frequency of occurrence of
		/// the label values(SortByLabelCount). By default, sorting is performed by
		/// label value.  Note that typically the background label has the highest
		/// frequency of occurrence, with a label value == 0 (but this is not a
		/// guarantee).
		/// </summary>
		// Token: 0x060195F4 RID: 103924 RVA: 0x00235A89 File Offset: 0x00233C89
		public void SortByLabelValue()
		{
			vtkPackLabels.vtkPackLabels_SortByLabelValue_37(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BC4 RID: 7108
		public new const string MRFullTypeName = "Kitware.VTK.vtkPackLabels";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BC5 RID: 7109
		public new static readonly string MRClassNameKey = "class vtkPackLabels";

		/// <summary>
		/// Specify the data type of the output image. The choice for output type is
		/// an unsigned integral type. Note that DEFAULT_TYPE value indicates that
		/// the output data type will be of a type large enough to represent the N
		/// labels present in the input (this is on by default). Explicit
		/// specification of the output type can cause labels in the input scalars
		/// to be replaced with the BackgroundValue in the output scalars. This
		/// occurs when trying to represent N labels in a data type that cannot
		/// represent all N values (e.g., trying to pack 500 labels unto an unsigned
		/// char packed label map).
		/// </summary>
		// Token: 0x02000984 RID: 2436
		public enum DefaultScalarType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001BC7 RID: 7111
			VTK_DEFAULT_TYPE = -1
		}

		/// <summary>
		/// Flags to control how sorting of the labels is performed.
		/// </summary>
		// Token: 0x02000985 RID: 2437
		public enum SortBy
		{
			/// <summary>enum member</summary>
			// Token: 0x04001BC9 RID: 7113
			SORT_BY_LABEL_COUNT = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001BCA RID: 7114
			SORT_BY_LABEL_VALUE = 0
		}
	}
}
