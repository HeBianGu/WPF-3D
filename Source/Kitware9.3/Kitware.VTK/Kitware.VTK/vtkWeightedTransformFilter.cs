using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkWeightedTransformFilter
	/// </summary>
	/// <remarks>
	///    transform based on per-point or per-cell weighting functions.
	///
	///
	/// vtkWeightedTransformFilter is a filter that can be used to "skin"
	/// structures and to create new and complex shapes.  Unlike a
	/// traditional transform filter (which has one transform for a data
	/// set) or an assembly (which has one transform per part or group of
	/// parts), a weighted transform produces the weighted sum of
	/// transforms on a per-point or per-cell basis.
	///
	/// Each point or cell in the filter's input has an attached DataArray
	/// that contains tuples of weighting functions, one per point or cell.
	/// The filter also has a set of fixed transforms.  When the filter
	/// executes, each input point/cell is transformed by each of the
	/// transforms.  These results are weighted by the point/cell's
	/// weighting factors to produce final output data.
	///
	/// Linear transforms are performance-optimized.  Using arbitrary
	/// transforms will work, but performance may suffer.
	///
	/// As an example of the utility of weighted transforms, here's how
	/// this filter can be used for "skinning."  Skinning is the process of
	/// putting a mesh cover over an underlying structure, like skin over
	/// bone.  Joints are difficult to skin because deformation is hard to
	/// do.  Visualize skin over an elbow joint.  Part of the skin moves
	/// with one bone, part of the skin moves with the other bone, and the
	/// skin in the middle moves a little with each.
	///
	/// Weighted filtering can be used for a simple and efficient kind of
	/// skinning.  Begin with a cylindrical mesh.  Create a FloatArray with
	/// two components per tuple, and one tuple for each point in the mesh.
	/// Assign transform weights that linear interpolate the distance along
	/// the cylinder (one component is the distance along the cylinder, the
	/// other is one minus that distance).  Set the filter up to use two
	/// transforms, the two used to transform the two bones.  Now, when the
	/// transforms change, the mesh will deform so as to, hopefully,
	/// continue to cover the bones.
	///
	/// vtkWeightedTransformFilter is also useful for creating "strange and
	/// complex" shapes using pinching, bending, and blending.
	///
	/// @warning
	/// Weighted combination of normals and vectors are probably not appropriate
	/// in many cases.  Surface normals are treated somewhat specially, but
	/// in many cases you may need to regenerate the surface normals.
	///
	/// @warning
	/// Cell data can only be transformed if all transforms are linear.
	///
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAbstractTransform vtkLinearTransform vtkTransformPolyDataFilter vtkActor
	/// </seealso>
	// Token: 0x0200061F RID: 1567
	public class vtkWeightedTransformFilter : vtkPointSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601101E RID: 69662 RVA: 0x0017AFC3 File Offset: 0x001791C3
		static vtkWeightedTransformFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWeightedTransformFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWeightedTransformFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601101F RID: 69663 RVA: 0x0017AFEB File Offset: 0x001791EB
		public vtkWeightedTransformFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011020 RID: 69664
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWeightedTransformFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011021 RID: 69665 RVA: 0x0017AFFC File Offset: 0x001791FC
		public new static vtkWeightedTransformFilter New()
		{
			vtkWeightedTransformFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWeightedTransformFilter.vtkWeightedTransformFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWeightedTransformFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011022 RID: 69666 RVA: 0x0017B050 File Offset: 0x00179250
		public vtkWeightedTransformFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkWeightedTransformFilter.vtkWeightedTransformFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011023 RID: 69667 RVA: 0x0017B094 File Offset: 0x00179294
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011024 RID: 69668
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWeightedTransformFilter_AddInputValuesOff_01(HandleRef pThis);

		/// <summary>
		/// If AddInputValues is true, the output values of this filter will be
		/// offset from the input values.  The effect is exactly equivalent to
		/// having an identity transform of weight 1 added into each output point.
		/// </summary>
		// Token: 0x06011025 RID: 69669 RVA: 0x0017B09F File Offset: 0x0017929F
		public virtual void AddInputValuesOff()
		{
			vtkWeightedTransformFilter.vtkWeightedTransformFilter_AddInputValuesOff_01(base.GetCppThis());
		}

		// Token: 0x06011026 RID: 69670
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWeightedTransformFilter_AddInputValuesOn_02(HandleRef pThis);

		/// <summary>
		/// If AddInputValues is true, the output values of this filter will be
		/// offset from the input values.  The effect is exactly equivalent to
		/// having an identity transform of weight 1 added into each output point.
		/// </summary>
		// Token: 0x06011027 RID: 69671 RVA: 0x0017B0AE File Offset: 0x001792AE
		public virtual void AddInputValuesOn()
		{
			vtkWeightedTransformFilter.vtkWeightedTransformFilter_AddInputValuesOn_02(base.GetCppThis());
		}

		// Token: 0x06011028 RID: 69672
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWeightedTransformFilter_GetAddInputValues_03(HandleRef pThis);

		/// <summary>
		/// If AddInputValues is true, the output values of this filter will be
		/// offset from the input values.  The effect is exactly equivalent to
		/// having an identity transform of weight 1 added into each output point.
		/// </summary>
		// Token: 0x06011029 RID: 69673 RVA: 0x0017B0C0 File Offset: 0x001792C0
		public virtual int GetAddInputValues()
		{
			return vtkWeightedTransformFilter.vtkWeightedTransformFilter_GetAddInputValues_03(base.GetCppThis());
		}

		// Token: 0x0601102A RID: 69674
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWeightedTransformFilter_GetCellDataTransformIndexArray_04(HandleRef pThis);

		/// <summary>
		/// The CellDataTransformIndexArray is like a TransformIndexArray,
		/// except for cell data.  The array must have type UnsignedShort.
		/// </summary>
		// Token: 0x0601102B RID: 69675 RVA: 0x0017B0E0 File Offset: 0x001792E0
		public virtual string GetCellDataTransformIndexArray()
		{
			string s = Marshal.PtrToStringAnsi(vtkWeightedTransformFilter.vtkWeightedTransformFilter_GetCellDataTransformIndexArray_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601102C RID: 69676
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWeightedTransformFilter_GetCellDataWeightArray_05(HandleRef pThis);

		/// <summary>
		/// The CellDataWeightArray is analogous to the WeightArray, except
		/// for CellData.  The array is searched for first in the CellData
		/// FieldData, then in the input's FieldData.  The data array must have
		/// a tuple for each cell.  This array is used to transform only normals
		/// and vectors.
		/// </summary>
		// Token: 0x0601102D RID: 69677 RVA: 0x0017B11C File Offset: 0x0017931C
		public virtual string GetCellDataWeightArray()
		{
			string s = Marshal.PtrToStringAnsi(vtkWeightedTransformFilter.vtkWeightedTransformFilter_GetCellDataWeightArray_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601102E RID: 69678
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkWeightedTransformFilter_GetMTime_06(HandleRef pThis);

		/// <summary>
		/// Return the MTime also considering the filter's transforms.
		/// </summary>
		// Token: 0x0601102F RID: 69679 RVA: 0x0017B158 File Offset: 0x00179358
		public override ulong GetMTime()
		{
			return vtkWeightedTransformFilter.vtkWeightedTransformFilter_GetMTime_06(base.GetCppThis());
		}

		// Token: 0x06011030 RID: 69680
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWeightedTransformFilter_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011031 RID: 69681 RVA: 0x0017B178 File Offset: 0x00179378
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkWeightedTransformFilter.vtkWeightedTransformFilter_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06011032 RID: 69682
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWeightedTransformFilter_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011033 RID: 69683 RVA: 0x0017B198 File Offset: 0x00179398
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkWeightedTransformFilter.vtkWeightedTransformFilter_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06011034 RID: 69684
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWeightedTransformFilter_GetNumberOfTransforms_09(HandleRef pThis);

		/// <summary>
		/// Set the number of transforms for the filter.  References to non-existent
		/// filter numbers in the data array is equivalent to a weight of zero
		/// (i.e., no contribution of that filter or weight).  The maximum number of
		/// transforms is limited to 65536 if transform index arrays are used.
		/// </summary>
		// Token: 0x06011035 RID: 69685 RVA: 0x0017B1B4 File Offset: 0x001793B4
		public virtual int GetNumberOfTransforms()
		{
			return vtkWeightedTransformFilter.vtkWeightedTransformFilter_GetNumberOfTransforms_09(base.GetCppThis());
		}

		// Token: 0x06011036 RID: 69686
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWeightedTransformFilter_GetTransform_10(HandleRef pThis, int num, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set or Get one of the filter's transforms. The transform number must
		/// be less than the number of transforms allocated for the object.  Setting
		/// a transform slot to nullptr is equivalent to assigning an overriding weight
		/// of zero to that filter slot.
		/// </summary>
		// Token: 0x06011037 RID: 69687 RVA: 0x0017B1D4 File Offset: 0x001793D4
		public virtual vtkAbstractTransform GetTransform(int num)
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWeightedTransformFilter.vtkWeightedTransformFilter_GetTransform_10(base.GetCppThis(), num, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractTransform = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractTransform.Register(null);
				}
			}
			return vtkAbstractTransform;
		}

		// Token: 0x06011038 RID: 69688
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWeightedTransformFilter_GetTransformIndexArray_11(HandleRef pThis);

		/// <summary>
		/// TransformIndexArray is the string name of the DataArray in the input's
		/// FieldData that holds the indices for the transforms for each point.
		/// These indices are used to select which transforms each weight of
		/// the DataArray refers.  If the TransformIndexArray is not specified,
		/// the weights of each point are assumed to map directly to a transform.
		/// This DataArray must be of type UnsignedShort, which effectively
		/// limits the number of transforms to 65536 if a transform index
		/// array is used.
		///
		/// The filter will first look for the array in the input's PointData
		/// FieldData.  If the array isn't there, the filter looks in the
		/// input's FieldData.  The TransformIndexArray can have tuples of any
		/// length, but must have a tuple for every point in the input data set.
		/// This array transforms points, normals, and vectors.
		/// </summary>
		// Token: 0x06011039 RID: 69689 RVA: 0x0017B244 File Offset: 0x00179444
		public virtual string GetTransformIndexArray()
		{
			string s = Marshal.PtrToStringAnsi(vtkWeightedTransformFilter.vtkWeightedTransformFilter_GetTransformIndexArray_11(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601103A RID: 69690
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWeightedTransformFilter_GetWeightArray_12(HandleRef pThis);

		/// <summary>
		/// WeightArray is the string name of the DataArray in the input's
		/// FieldData that holds the weighting coefficients for each point.
		/// The filter will first look for the array in the input's PointData
		/// FieldData.  If the array isn't there, the filter looks in the
		/// input's FieldData.  The WeightArray can have tuples of any length,
		/// but must have a tuple for every point in the input data set.
		/// This array transforms points, normals, and vectors.
		/// </summary>
		// Token: 0x0601103B RID: 69691 RVA: 0x0017B280 File Offset: 0x00179480
		public virtual string GetWeightArray()
		{
			string s = Marshal.PtrToStringAnsi(vtkWeightedTransformFilter.vtkWeightedTransformFilter_GetWeightArray_12(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601103C RID: 69692
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWeightedTransformFilter_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601103D RID: 69693 RVA: 0x0017B2BC File Offset: 0x001794BC
		public override int IsA(string type)
		{
			return vtkWeightedTransformFilter.vtkWeightedTransformFilter_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x0601103E RID: 69694
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWeightedTransformFilter_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601103F RID: 69695 RVA: 0x0017B2DC File Offset: 0x001794DC
		public new static int IsTypeOf(string type)
		{
			return vtkWeightedTransformFilter.vtkWeightedTransformFilter_IsTypeOf_14(type);
		}

		// Token: 0x06011040 RID: 69696
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWeightedTransformFilter_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011041 RID: 69697 RVA: 0x0017B2F8 File Offset: 0x001794F8
		public new vtkWeightedTransformFilter NewInstance()
		{
			vtkWeightedTransformFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWeightedTransformFilter.vtkWeightedTransformFilter_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWeightedTransformFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011042 RID: 69698
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWeightedTransformFilter_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011043 RID: 69699 RVA: 0x0017B354 File Offset: 0x00179554
		public new static vtkWeightedTransformFilter SafeDownCast(vtkObjectBase o)
		{
			vtkWeightedTransformFilter vtkWeightedTransformFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWeightedTransformFilter.vtkWeightedTransformFilter_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWeightedTransformFilter = (vtkWeightedTransformFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWeightedTransformFilter.Register(null);
				}
			}
			return vtkWeightedTransformFilter;
		}

		// Token: 0x06011044 RID: 69700
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWeightedTransformFilter_SetAddInputValues_18(HandleRef pThis, int _arg);

		/// <summary>
		/// If AddInputValues is true, the output values of this filter will be
		/// offset from the input values.  The effect is exactly equivalent to
		/// having an identity transform of weight 1 added into each output point.
		/// </summary>
		// Token: 0x06011045 RID: 69701 RVA: 0x0017B3D3 File Offset: 0x001795D3
		public virtual void SetAddInputValues(int _arg)
		{
			vtkWeightedTransformFilter.vtkWeightedTransformFilter_SetAddInputValues_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06011046 RID: 69702
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWeightedTransformFilter_SetCellDataTransformIndexArray_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The CellDataTransformIndexArray is like a TransformIndexArray,
		/// except for cell data.  The array must have type UnsignedShort.
		/// </summary>
		// Token: 0x06011047 RID: 69703 RVA: 0x0017B3E3 File Offset: 0x001795E3
		public virtual void SetCellDataTransformIndexArray(string _arg)
		{
			vtkWeightedTransformFilter.vtkWeightedTransformFilter_SetCellDataTransformIndexArray_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06011048 RID: 69704
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWeightedTransformFilter_SetCellDataWeightArray_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The CellDataWeightArray is analogous to the WeightArray, except
		/// for CellData.  The array is searched for first in the CellData
		/// FieldData, then in the input's FieldData.  The data array must have
		/// a tuple for each cell.  This array is used to transform only normals
		/// and vectors.
		/// </summary>
		// Token: 0x06011049 RID: 69705 RVA: 0x0017B3F3 File Offset: 0x001795F3
		public virtual void SetCellDataWeightArray(string _arg)
		{
			vtkWeightedTransformFilter.vtkWeightedTransformFilter_SetCellDataWeightArray_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0601104A RID: 69706
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWeightedTransformFilter_SetNumberOfTransforms_21(HandleRef pThis, int num);

		/// <summary>
		/// Set the number of transforms for the filter.  References to non-existent
		/// filter numbers in the data array is equivalent to a weight of zero
		/// (i.e., no contribution of that filter or weight).  The maximum number of
		/// transforms is limited to 65536 if transform index arrays are used.
		/// </summary>
		// Token: 0x0601104B RID: 69707 RVA: 0x0017B403 File Offset: 0x00179603
		public virtual void SetNumberOfTransforms(int num)
		{
			vtkWeightedTransformFilter.vtkWeightedTransformFilter_SetNumberOfTransforms_21(base.GetCppThis(), num);
		}

		// Token: 0x0601104C RID: 69708
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWeightedTransformFilter_SetTransform_22(HandleRef pThis, HandleRef transform, int num);

		/// <summary>
		/// Set or Get one of the filter's transforms. The transform number must
		/// be less than the number of transforms allocated for the object.  Setting
		/// a transform slot to nullptr is equivalent to assigning an overriding weight
		/// of zero to that filter slot.
		/// </summary>
		// Token: 0x0601104D RID: 69709 RVA: 0x0017B414 File Offset: 0x00179614
		public virtual void SetTransform(vtkAbstractTransform transform, int num)
		{
			vtkWeightedTransformFilter.vtkWeightedTransformFilter_SetTransform_22(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis(), num);
		}

		// Token: 0x0601104E RID: 69710
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWeightedTransformFilter_SetTransformIndexArray_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// TransformIndexArray is the string name of the DataArray in the input's
		/// FieldData that holds the indices for the transforms for each point.
		/// These indices are used to select which transforms each weight of
		/// the DataArray refers.  If the TransformIndexArray is not specified,
		/// the weights of each point are assumed to map directly to a transform.
		/// This DataArray must be of type UnsignedShort, which effectively
		/// limits the number of transforms to 65536 if a transform index
		/// array is used.
		///
		/// The filter will first look for the array in the input's PointData
		/// FieldData.  If the array isn't there, the filter looks in the
		/// input's FieldData.  The TransformIndexArray can have tuples of any
		/// length, but must have a tuple for every point in the input data set.
		/// This array transforms points, normals, and vectors.
		/// </summary>
		// Token: 0x0601104F RID: 69711 RVA: 0x0017B444 File Offset: 0x00179644
		public virtual void SetTransformIndexArray(string _arg)
		{
			vtkWeightedTransformFilter.vtkWeightedTransformFilter_SetTransformIndexArray_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06011050 RID: 69712
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWeightedTransformFilter_SetWeightArray_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// WeightArray is the string name of the DataArray in the input's
		/// FieldData that holds the weighting coefficients for each point.
		/// The filter will first look for the array in the input's PointData
		/// FieldData.  If the array isn't there, the filter looks in the
		/// input's FieldData.  The WeightArray can have tuples of any length,
		/// but must have a tuple for every point in the input data set.
		/// This array transforms points, normals, and vectors.
		/// </summary>
		// Token: 0x06011051 RID: 69713 RVA: 0x0017B454 File Offset: 0x00179654
		public virtual void SetWeightArray(string _arg)
		{
			vtkWeightedTransformFilter.vtkWeightedTransformFilter_SetWeightArray_24(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013A2 RID: 5026
		public new const string MRFullTypeName = "Kitware.VTK.vtkWeightedTransformFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013A3 RID: 5027
		public new static readonly string MRClassNameKey = "class vtkWeightedTransformFilter";
	}
}
