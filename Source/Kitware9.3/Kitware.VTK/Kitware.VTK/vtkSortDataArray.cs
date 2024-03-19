using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSortDataArray
	/// </summary>
	/// <remarks>
	///    provides several methods for sorting VTK arrays.
	///
	///
	/// vtkSortDataArray is used to sort data, based on its value, or with an
	/// associated key, into either ascending or descending order. This is useful
	/// for operations like selection, or analysis, when evaluating and processing
	/// data. A variety of sorting functions are provided, treating both arrays
	/// (i.e., vtkAbstractArray) and id lists (vtkIdList). Note that complex arrays
	/// like variants and string arrays are also handled.
	///
	/// Additional functionality is provided to generate data ordering, without
	/// necessarily shuffling the data into a final, sorted position. Hence, the
	/// sorting process is organized into three steps because of the complexity of
	/// dealing with multiple types and multiple component data arrays. The first
	/// step involves creating and initializing a sorted index array, and then
	/// (second step) sorting this array to produce a map indicating the sorting
	/// order.  In other words, the sorting index array is a permutation which can
	/// be applied to other, associated data to shuffle it (third step) into an
	/// order consistent with the sorting operation. Note that the generation of
	/// the sorted index array is useful unto itself (even without the final
	/// shuffling of data) because it generates an ordered list (from the data
	/// values of any component in any array). So for example, it is possible to
	/// find the top N cells with the largest scalar value simply by generating
	/// the sorting index array from the call scalar values.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly on
	/// multi-core machines.
	///
	/// @warning
	/// The sort methods below are static, hence the sorting methods can be
	/// used without instantiating the class. All methods are thread safe.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSortFieldData
	/// </seealso>
	// Token: 0x02000AC1 RID: 2753
	public class vtkSortDataArray : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601CF9C RID: 118684 RVA: 0x0028DAA7 File Offset: 0x0028BCA7
		static vtkSortDataArray()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSortDataArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSortDataArray"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601CF9D RID: 118685 RVA: 0x0028DACF File Offset: 0x0028BCCF
		public vtkSortDataArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601CF9E RID: 118686
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSortDataArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods for instantiating, managing type, and printing
		/// information about this class.
		/// </summary>
		// Token: 0x0601CF9F RID: 118687 RVA: 0x0028DAE0 File Offset: 0x0028BCE0
		public new static vtkSortDataArray New()
		{
			vtkSortDataArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSortDataArray.vtkSortDataArray_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSortDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard VTK methods for instantiating, managing type, and printing
		/// information about this class.
		/// </summary>
		// Token: 0x0601CFA0 RID: 118688 RVA: 0x0028DB34 File Offset: 0x0028BD34
		public vtkSortDataArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSortDataArray.vtkSortDataArray_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601CFA1 RID: 118689 RVA: 0x0028DB78 File Offset: 0x0028BD78
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601CFA2 RID: 118690
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSortDataArray_GenerateSortIndices_01(int dataType, IntPtr dataIn, long numKeys, int numComp, int k, IntPtr idx);

		/// <summary>
		/// The following are general functions which can be used to produce an
		/// ordering, and/or sort various types of VTK arrays. Don't use these
		/// methods unless you really know what you are doing. The basic idea is
		/// that an initial set of indices (InitializeSortIndices() that refer to
		/// the data contained in a vtkAbstractArray or vtkIdList) are sorted
		/// (GenerateSortIndices() based on the data values in the array). The
		/// result of the sort is the creation of a permutation array (the sort
		/// array idx) that indicates where the data tuples originated (e.g., after
		/// the sort, idx[0] indicates where in the array the tuple was originally
		/// located prior to sorting.) This sorted index array can be used to
		/// shuffle various types of VTK arrays (the types supported correspond to
		/// the various arrays which are subclasses of vtkDataArrayTemplate, use
		/// ShuffleArray() or for vtkIdList, use ShuffleIdList()). Also, the sort
		/// array, being an vtkIdType* (i.e., id list), can also be used to identify
		/// points or cells in sorted order (based on the data in the originating
		/// dataIn array). Note that sorting is always performed in ascending order,
		/// and the sorted index array reflects this; however the shuffling of data
		/// can be specified as either ascending (dir=0) or descending (dir=1)
		/// order. The user is responsible for taking ownership of the sort indices
		/// (i.e., free the idx array).
		/// </summary>
		// Token: 0x0601CFA3 RID: 118691 RVA: 0x0028DB83 File Offset: 0x0028BD83
		public static void GenerateSortIndices(int dataType, IntPtr dataIn, long numKeys, int numComp, int k, IntPtr idx)
		{
			vtkSortDataArray.vtkSortDataArray_GenerateSortIndices_01(dataType, dataIn, numKeys, numComp, k, idx);
		}

		// Token: 0x0601CFA4 RID: 118692
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSortDataArray_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods for instantiating, managing type, and printing
		/// information about this class.
		/// </summary>
		// Token: 0x0601CFA5 RID: 118693 RVA: 0x0028DB94 File Offset: 0x0028BD94
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSortDataArray.vtkSortDataArray_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601CFA6 RID: 118694
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSortDataArray_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods for instantiating, managing type, and printing
		/// information about this class.
		/// </summary>
		// Token: 0x0601CFA7 RID: 118695 RVA: 0x0028DBB4 File Offset: 0x0028BDB4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSortDataArray.vtkSortDataArray_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601CFA8 RID: 118696
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSortDataArray_InitializeSortIndices_04(long numKeys);

		/// <summary>
		/// The following are general functions which can be used to produce an
		/// ordering, and/or sort various types of VTK arrays. Don't use these
		/// methods unless you really know what you are doing. The basic idea is
		/// that an initial set of indices (InitializeSortIndices() that refer to
		/// the data contained in a vtkAbstractArray or vtkIdList) are sorted
		/// (GenerateSortIndices() based on the data values in the array). The
		/// result of the sort is the creation of a permutation array (the sort
		/// array idx) that indicates where the data tuples originated (e.g., after
		/// the sort, idx[0] indicates where in the array the tuple was originally
		/// located prior to sorting.) This sorted index array can be used to
		/// shuffle various types of VTK arrays (the types supported correspond to
		/// the various arrays which are subclasses of vtkDataArrayTemplate, use
		/// ShuffleArray() or for vtkIdList, use ShuffleIdList()). Also, the sort
		/// array, being an vtkIdType* (i.e., id list), can also be used to identify
		/// points or cells in sorted order (based on the data in the originating
		/// dataIn array). Note that sorting is always performed in ascending order,
		/// and the sorted index array reflects this; however the shuffling of data
		/// can be specified as either ascending (dir=0) or descending (dir=1)
		/// order. The user is responsible for taking ownership of the sort indices
		/// (i.e., free the idx array).
		/// </summary>
		// Token: 0x0601CFA9 RID: 118697 RVA: 0x0028DBD0 File Offset: 0x0028BDD0
		public static IntPtr InitializeSortIndices(long numKeys)
		{
			return vtkSortDataArray.vtkSortDataArray_InitializeSortIndices_04(numKeys);
		}

		// Token: 0x0601CFAA RID: 118698
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSortDataArray_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods for instantiating, managing type, and printing
		/// information about this class.
		/// </summary>
		// Token: 0x0601CFAB RID: 118699 RVA: 0x0028DBEC File Offset: 0x0028BDEC
		public override int IsA(string type)
		{
			return vtkSortDataArray.vtkSortDataArray_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601CFAC RID: 118700
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSortDataArray_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods for instantiating, managing type, and printing
		/// information about this class.
		/// </summary>
		// Token: 0x0601CFAD RID: 118701 RVA: 0x0028DC0C File Offset: 0x0028BE0C
		public new static int IsTypeOf(string type)
		{
			return vtkSortDataArray.vtkSortDataArray_IsTypeOf_06(type);
		}

		// Token: 0x0601CFAE RID: 118702
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSortDataArray_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods for instantiating, managing type, and printing
		/// information about this class.
		/// </summary>
		// Token: 0x0601CFAF RID: 118703 RVA: 0x0028DC28 File Offset: 0x0028BE28
		public new vtkSortDataArray NewInstance()
		{
			vtkSortDataArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSortDataArray.vtkSortDataArray_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSortDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601CFB0 RID: 118704
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSortDataArray_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods for instantiating, managing type, and printing
		/// information about this class.
		/// </summary>
		// Token: 0x0601CFB1 RID: 118705 RVA: 0x0028DC84 File Offset: 0x0028BE84
		public new static vtkSortDataArray SafeDownCast(vtkObjectBase o)
		{
			vtkSortDataArray vtkSortDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSortDataArray.vtkSortDataArray_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSortDataArray = (vtkSortDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSortDataArray.Register(null);
				}
			}
			return vtkSortDataArray;
		}

		// Token: 0x0601CFB2 RID: 118706
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSortDataArray_ShuffleArray_10(IntPtr idx, int dataType, long numKeys, int numComp, HandleRef arr, IntPtr dataIn, int dir);

		/// <summary>
		/// The following are general functions which can be used to produce an
		/// ordering, and/or sort various types of VTK arrays. Don't use these
		/// methods unless you really know what you are doing. The basic idea is
		/// that an initial set of indices (InitializeSortIndices() that refer to
		/// the data contained in a vtkAbstractArray or vtkIdList) are sorted
		/// (GenerateSortIndices() based on the data values in the array). The
		/// result of the sort is the creation of a permutation array (the sort
		/// array idx) that indicates where the data tuples originated (e.g., after
		/// the sort, idx[0] indicates where in the array the tuple was originally
		/// located prior to sorting.) This sorted index array can be used to
		/// shuffle various types of VTK arrays (the types supported correspond to
		/// the various arrays which are subclasses of vtkDataArrayTemplate, use
		/// ShuffleArray() or for vtkIdList, use ShuffleIdList()). Also, the sort
		/// array, being an vtkIdType* (i.e., id list), can also be used to identify
		/// points or cells in sorted order (based on the data in the originating
		/// dataIn array). Note that sorting is always performed in ascending order,
		/// and the sorted index array reflects this; however the shuffling of data
		/// can be specified as either ascending (dir=0) or descending (dir=1)
		/// order. The user is responsible for taking ownership of the sort indices
		/// (i.e., free the idx array).
		/// </summary>
		// Token: 0x0601CFB3 RID: 118707 RVA: 0x0028DD04 File Offset: 0x0028BF04
		public static void ShuffleArray(IntPtr idx, int dataType, long numKeys, int numComp, vtkAbstractArray arr, IntPtr dataIn, int dir)
		{
			vtkSortDataArray.vtkSortDataArray_ShuffleArray_10(idx, dataType, numKeys, numComp, (arr == null) ? default(HandleRef) : arr.GetCppThis(), dataIn, dir);
		}

		// Token: 0x0601CFB4 RID: 118708
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSortDataArray_ShuffleIdList_11(IntPtr idx, long sze, HandleRef arrayIn, IntPtr dataIn, int dir);

		/// <summary>
		/// The following are general functions which can be used to produce an
		/// ordering, and/or sort various types of VTK arrays. Don't use these
		/// methods unless you really know what you are doing. The basic idea is
		/// that an initial set of indices (InitializeSortIndices() that refer to
		/// the data contained in a vtkAbstractArray or vtkIdList) are sorted
		/// (GenerateSortIndices() based on the data values in the array). The
		/// result of the sort is the creation of a permutation array (the sort
		/// array idx) that indicates where the data tuples originated (e.g., after
		/// the sort, idx[0] indicates where in the array the tuple was originally
		/// located prior to sorting.) This sorted index array can be used to
		/// shuffle various types of VTK arrays (the types supported correspond to
		/// the various arrays which are subclasses of vtkDataArrayTemplate, use
		/// ShuffleArray() or for vtkIdList, use ShuffleIdList()). Also, the sort
		/// array, being an vtkIdType* (i.e., id list), can also be used to identify
		/// points or cells in sorted order (based on the data in the originating
		/// dataIn array). Note that sorting is always performed in ascending order,
		/// and the sorted index array reflects this; however the shuffling of data
		/// can be specified as either ascending (dir=0) or descending (dir=1)
		/// order. The user is responsible for taking ownership of the sort indices
		/// (i.e., free the idx array).
		/// </summary>
		// Token: 0x0601CFB5 RID: 118709 RVA: 0x0028DD38 File Offset: 0x0028BF38
		public static void ShuffleIdList(IntPtr idx, long sze, vtkIdList arrayIn, IntPtr dataIn, int dir)
		{
			vtkSortDataArray.vtkSortDataArray_ShuffleIdList_11(idx, sze, (arrayIn == null) ? default(HandleRef) : arrayIn.GetCppThis(), dataIn, dir);
		}

		// Token: 0x0601CFB6 RID: 118710
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSortDataArray_Sort_12(HandleRef keys);

		/// <summary>
		/// Sorts the given array in ascending order. For this method, the keys must
		/// be single-component tuples.
		/// </summary>
		// Token: 0x0601CFB7 RID: 118711 RVA: 0x0028DD68 File Offset: 0x0028BF68
		public static void Sort(vtkIdList keys)
		{
			vtkSortDataArray.vtkSortDataArray_Sort_12((keys == null) ? default(HandleRef) : keys.GetCppThis());
		}

		// Token: 0x0601CFB8 RID: 118712
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSortDataArray_Sort_13(HandleRef keys);

		/// <summary>
		/// Sorts the given array in ascending order. For this method, the keys must
		/// be single-component tuples.
		/// </summary>
		// Token: 0x0601CFB9 RID: 118713 RVA: 0x0028DD94 File Offset: 0x0028BF94
		public static void Sort(vtkAbstractArray keys)
		{
			vtkSortDataArray.vtkSortDataArray_Sort_13((keys == null) ? default(HandleRef) : keys.GetCppThis());
		}

		// Token: 0x0601CFBA RID: 118714
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSortDataArray_Sort_14(HandleRef keys, int dir);

		/// <summary>
		/// Sorts the given array in either ascending (dir=0) or descending (dir!=0)
		/// order. For this method, the keys must be single-component tuples.
		/// </summary>
		// Token: 0x0601CFBB RID: 118715 RVA: 0x0028DDC0 File Offset: 0x0028BFC0
		public static void Sort(vtkIdList keys, int dir)
		{
			vtkSortDataArray.vtkSortDataArray_Sort_14((keys == null) ? default(HandleRef) : keys.GetCppThis(), dir);
		}

		// Token: 0x0601CFBC RID: 118716
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSortDataArray_Sort_15(HandleRef keys, int dir);

		/// <summary>
		/// Sorts the given array in either ascending (dir=0) or descending (dir!=0)
		/// order. For this method, the keys must be single-component tuples.
		/// </summary>
		// Token: 0x0601CFBD RID: 118717 RVA: 0x0028DDEC File Offset: 0x0028BFEC
		public static void Sort(vtkAbstractArray keys, int dir)
		{
			vtkSortDataArray.vtkSortDataArray_Sort_15((keys == null) ? default(HandleRef) : keys.GetCppThis(), dir);
		}

		// Token: 0x0601CFBE RID: 118718
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSortDataArray_Sort_16(HandleRef keys, HandleRef values);

		/// <summary>
		/// Sorts the given key/value pairs based on the keys (the keys are expected
		/// to be 1-tuples, values may have number of components &gt;= 1).
		/// Obviously, the two arrays must be of equal size. Sorts in ascending
		/// order.
		/// </summary>
		// Token: 0x0601CFBF RID: 118719 RVA: 0x0028DE18 File Offset: 0x0028C018
		public static void Sort(vtkAbstractArray keys, vtkAbstractArray values)
		{
			vtkSortDataArray.vtkSortDataArray_Sort_16((keys == null) ? default(HandleRef) : keys.GetCppThis(), (values == null) ? default(HandleRef) : values.GetCppThis());
		}

		// Token: 0x0601CFC0 RID: 118720
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSortDataArray_Sort_17(HandleRef keys, HandleRef values);

		/// <summary>
		/// Sorts the given key/value pairs based on the keys (the keys are expected
		/// to be 1-tuples, values may have number of components &gt;= 1).
		/// Obviously, the two arrays must be of equal size. Sorts in ascending
		/// order.
		/// </summary>
		// Token: 0x0601CFC1 RID: 118721 RVA: 0x0028DE58 File Offset: 0x0028C058
		public static void Sort(vtkAbstractArray keys, vtkIdList values)
		{
			vtkSortDataArray.vtkSortDataArray_Sort_17((keys == null) ? default(HandleRef) : keys.GetCppThis(), (values == null) ? default(HandleRef) : values.GetCppThis());
		}

		// Token: 0x0601CFC2 RID: 118722
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSortDataArray_Sort_18(HandleRef keys, HandleRef values, int dir);

		/// <summary>
		/// Sorts the given key/value pairs based on the keys (the keys are expected
		/// to be 1-tuples, values may have number of components &gt;= 1).
		/// Obviously, the two arrays must be of equal size. Sorts in either
		/// ascending (dir=0) or descending (dir=1) order.
		/// </summary>
		// Token: 0x0601CFC3 RID: 118723 RVA: 0x0028DE98 File Offset: 0x0028C098
		public static void Sort(vtkAbstractArray keys, vtkAbstractArray values, int dir)
		{
			vtkSortDataArray.vtkSortDataArray_Sort_18((keys == null) ? default(HandleRef) : keys.GetCppThis(), (values == null) ? default(HandleRef) : values.GetCppThis(), dir);
		}

		// Token: 0x0601CFC4 RID: 118724
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSortDataArray_Sort_19(HandleRef keys, HandleRef values, int dir);

		/// <summary>
		/// Sorts the given key/value pairs based on the keys (the keys are expected
		/// to be 1-tuples, values may have number of components &gt;= 1).
		/// Obviously, the two arrays must be of equal size. Sorts in either
		/// ascending (dir=0) or descending (dir=1) order.
		/// </summary>
		// Token: 0x0601CFC5 RID: 118725 RVA: 0x0028DED8 File Offset: 0x0028C0D8
		public static void Sort(vtkAbstractArray keys, vtkIdList values, int dir)
		{
			vtkSortDataArray.vtkSortDataArray_Sort_19((keys == null) ? default(HandleRef) : keys.GetCppThis(), (values == null) ? default(HandleRef) : values.GetCppThis(), dir);
		}

		// Token: 0x0601CFC6 RID: 118726
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSortDataArray_SortArrayByComponent_20(HandleRef arr, int k);

		/// <summary>
		/// Sorts the given data array using the specified component as a key.
		/// Think of the array as a 2-D grid with each tuple representing a row.
		/// Tuples are swapped until the \a k-th column of the grid is
		/// monotonically increasing. Where two tuples have the same value for
		/// the \a k-th component, their order in the final result is unspecified.
		/// </summary>
		// Token: 0x0601CFC7 RID: 118727 RVA: 0x0028DF18 File Offset: 0x0028C118
		public static void SortArrayByComponent(vtkAbstractArray arr, int k)
		{
			vtkSortDataArray.vtkSortDataArray_SortArrayByComponent_20((arr == null) ? default(HandleRef) : arr.GetCppThis(), k);
		}

		// Token: 0x0601CFC8 RID: 118728
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSortDataArray_SortArrayByComponent_21(HandleRef arr, int k, int dir);

		/// <summary>
		/// Sorts the given data array using the specified component as a key.
		/// Think of the array as a 2-D grid with each tuple representing a row.
		/// Tuples are swapped until the \a k-th column of the grid is ascending
		/// (dir=0) or descending (dir=1). Where two tuples have the same value for
		/// the \a k-th component, their order in the final result is unspecified.
		/// </summary>
		// Token: 0x0601CFC9 RID: 118729 RVA: 0x0028DF44 File Offset: 0x0028C144
		public static void SortArrayByComponent(vtkAbstractArray arr, int k, int dir)
		{
			vtkSortDataArray.vtkSortDataArray_SortArrayByComponent_21((arr == null) ? default(HandleRef) : arr.GetCppThis(), k, dir);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E9E RID: 7838
		public new const string MRFullTypeName = "Kitware.VTK.vtkSortDataArray";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E9F RID: 7839
		public new static readonly string MRClassNameKey = "class vtkSortDataArray";
	}
}
