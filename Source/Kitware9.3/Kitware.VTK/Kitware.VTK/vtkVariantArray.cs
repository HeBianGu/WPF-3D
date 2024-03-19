using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVariantArray
	/// </summary>
	/// <remarks>
	///    An array holding vtkVariants.
	///
	///
	///
	/// @par Thanks:
	/// Thanks to Patricia Crossno, Ken Moreland, Andrew Wilson and Brian Wylie from
	/// Sandia National Laboratories for their help in developing this class.
	/// </remarks>
	// Token: 0x02000B86 RID: 2950
	public class vtkVariantArray : vtkAbstractArray
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601EC69 RID: 126057 RVA: 0x002BA4A1 File Offset: 0x002B86A1
		static vtkVariantArray()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVariantArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVariantArray"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601EC6A RID: 126058 RVA: 0x002BA4C9 File Offset: 0x002B86C9
		public vtkVariantArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601EC6B RID: 126059
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVariantArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EC6C RID: 126060 RVA: 0x002BA4D8 File Offset: 0x002B86D8
		public new static vtkVariantArray New()
		{
			vtkVariantArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVariantArray.vtkVariantArray_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVariantArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EC6D RID: 126061 RVA: 0x002BA52C File Offset: 0x002B872C
		public vtkVariantArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVariantArray.vtkVariantArray_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601EC6E RID: 126062 RVA: 0x002BA570 File Offset: 0x002B8770
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601EC6F RID: 126063
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVariantArray_Allocate_01(HandleRef pThis, long sz, long ext);

		/// <summary>
		/// Allocate memory for this array. Delete old storage only if necessary.
		/// Note that ext is no longer used.
		/// </summary>
		// Token: 0x0601EC70 RID: 126064 RVA: 0x002BA57C File Offset: 0x002B877C
		public override int Allocate(long sz, long ext)
		{
			return vtkVariantArray.vtkVariantArray_Allocate_01(base.GetCppThis(), sz, ext);
		}

		// Token: 0x0601EC71 RID: 126065
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVariantArray_ClearLookup_02(HandleRef pThis);

		/// <summary>
		/// Delete the associated fast lookup data structure on this array,
		/// if it exists.  The lookup will be rebuilt on the next call to a lookup
		/// function.
		/// </summary>
		// Token: 0x0601EC72 RID: 126066 RVA: 0x002BA59D File Offset: 0x002B879D
		public override void ClearLookup()
		{
			vtkVariantArray.vtkVariantArray_ClearLookup_02(base.GetCppThis());
		}

		// Token: 0x0601EC73 RID: 126067
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVariantArray_DataChanged_03(HandleRef pThis);

		/// <summary>
		/// Tell the array explicitly that the data has changed.
		/// This is only necessary to call when you modify the array contents
		/// without using the array's API (i.e. you retrieve a pointer to the
		/// data and modify the array contents).  You need to call this so that
		/// the fast lookup will know to rebuild itself.  Otherwise, the lookup
		/// functions will give incorrect results.
		/// </summary>
		// Token: 0x0601EC74 RID: 126068 RVA: 0x002BA5AC File Offset: 0x002B87AC
		public override void DataChanged()
		{
			vtkVariantArray.vtkVariantArray_DataChanged_03(base.GetCppThis());
		}

		// Token: 0x0601EC75 RID: 126069
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVariantArray_DataElementChanged_04(HandleRef pThis, long id);

		/// <summary>
		/// Tell the array explicitly that a single data element has
		/// changed. Like DataChanged(), then is only necessary when you
		/// modify the array contents without using the array's API.
		/// </summary>
		// Token: 0x0601EC76 RID: 126070 RVA: 0x002BA5BB File Offset: 0x002B87BB
		public virtual void DataElementChanged(long id)
		{
			vtkVariantArray.vtkVariantArray_DataElementChanged_04(base.GetCppThis(), id);
		}

		// Token: 0x0601EC77 RID: 126071
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVariantArray_DeepCopy_05(HandleRef pThis, HandleRef da);

		/// <summary>
		/// Deep copy of data. Implementation left to subclasses, which
		/// should support as many type conversions as possible given the
		/// data type.
		/// </summary>
		// Token: 0x0601EC78 RID: 126072 RVA: 0x002BA5CC File Offset: 0x002B87CC
		public override void DeepCopy(vtkAbstractArray da)
		{
			vtkVariantArray.vtkVariantArray_DeepCopy_05(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		// Token: 0x0601EC79 RID: 126073
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVariantArray_ExtendedNew_06(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EC7A RID: 126074 RVA: 0x002BA5FC File Offset: 0x002B87FC
		public static vtkVariantArray ExtendedNew()
		{
			vtkVariantArray vtkVariantArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVariantArray.vtkVariantArray_ExtendedNew_06(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVariantArray = (vtkVariantArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVariantArray.Register(null);
				}
			}
			return vtkVariantArray;
		}

		// Token: 0x0601EC7B RID: 126075
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkVariantArray_GetActualMemorySize_07(HandleRef pThis);

		/// <summary>
		/// Return the memory in kibibytes (1024 bytes) consumed by this data array. Used to
		/// support streaming and reading/writing data. The value returned is
		/// guaranteed to be greater than or equal to the memory required to
		/// actually represent the data represented by this object. The
		/// information returned is valid only after the pipeline has
		/// been updated.
		/// </summary>
		// Token: 0x0601EC7C RID: 126076 RVA: 0x002BA668 File Offset: 0x002B8868
		public override uint GetActualMemorySize()
		{
			return vtkVariantArray.vtkVariantArray_GetActualMemorySize_07(base.GetCppThis());
		}

		// Token: 0x0601EC7D RID: 126077
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVariantArray_GetDataType_08(HandleRef pThis);

		/// <summary>
		/// Return the underlying data type. An integer indicating data type is
		/// returned as specified in vtkSetGet.h.
		/// </summary>
		// Token: 0x0601EC7E RID: 126078 RVA: 0x002BA688 File Offset: 0x002B8888
		public override int GetDataType()
		{
			return vtkVariantArray.vtkVariantArray_GetDataType_08(base.GetCppThis());
		}

		// Token: 0x0601EC7F RID: 126079
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVariantArray_GetDataTypeSize_09(HandleRef pThis);

		/// <summary>
		/// Return the size of the underlying data type.  For a bit, 1 is
		/// returned.  For string 0 is returned. Arrays with variable length
		/// components return 0.
		/// </summary>
		// Token: 0x0601EC80 RID: 126080 RVA: 0x002BA6A8 File Offset: 0x002B88A8
		public override int GetDataTypeSize()
		{
			return vtkVariantArray.vtkVariantArray_GetDataTypeSize_09(base.GetCppThis());
		}

		// Token: 0x0601EC81 RID: 126081
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVariantArray_GetElementComponentSize_10(HandleRef pThis);

		/// <summary>
		/// Return the size, in bytes, of the lowest-level element of an
		/// array.  For vtkDataArray and subclasses this is the size of the
		/// data type.  For vtkStringArray, this is
		/// sizeof(vtkStdString::value_type), which winds up being
		/// sizeof(char).
		/// </summary>
		// Token: 0x0601EC82 RID: 126082 RVA: 0x002BA6C8 File Offset: 0x002B88C8
		public override int GetElementComponentSize()
		{
			return vtkVariantArray.vtkVariantArray_GetElementComponentSize_10(base.GetCppThis());
		}

		// Token: 0x0601EC83 RID: 126083
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVariantArray_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EC84 RID: 126084 RVA: 0x002BA6E8 File Offset: 0x002B88E8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVariantArray.vtkVariantArray_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x0601EC85 RID: 126085
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVariantArray_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EC86 RID: 126086 RVA: 0x002BA708 File Offset: 0x002B8908
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVariantArray.vtkVariantArray_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x0601EC87 RID: 126087
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVariantArray_GetNumberOfValues_13(HandleRef pThis);

		/// <summary>
		/// Return the number of values in the array.
		/// </summary>
		// Token: 0x0601EC88 RID: 126088 RVA: 0x002BA724 File Offset: 0x002B8924
		public new long GetNumberOfValues()
		{
			return vtkVariantArray.vtkVariantArray_GetNumberOfValues_13(base.GetCppThis());
		}

		// Token: 0x0601EC89 RID: 126089
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVariantArray_GetPointer_14(HandleRef pThis, long id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return a pointer to the location in the internal array at the specified index.
		/// </summary>
		// Token: 0x0601EC8A RID: 126090 RVA: 0x002BA744 File Offset: 0x002B8944
		public vtkVariant GetPointer(long id)
		{
			vtkVariant result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVariantArray.vtkVariantArray_GetPointer_14(base.GetCppThis(), id, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, false, out flag);
			}
			return result;
		}

		// Token: 0x0601EC8B RID: 126091
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVariantArray_GetValue_15(HandleRef pThis, long id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the data at a particular index.
		/// </summary>
		// Token: 0x0601EC8C RID: 126092 RVA: 0x002BA7A0 File Offset: 0x002B89A0
		public vtkVariant GetValue(long id)
		{
			vtkVariant result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVariantArray.vtkVariantArray_GetValue_15(base.GetCppThis(), id, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601EC8D RID: 126093
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVariantArray_GetVoidPointer_16(HandleRef pThis, long id);

		/// <summary>
		/// Return a void pointer. For image pipeline interface and other
		/// special pointer manipulation.
		/// </summary>
		// Token: 0x0601EC8E RID: 126094 RVA: 0x002BA7FC File Offset: 0x002B89FC
		public override IntPtr GetVoidPointer(long id)
		{
			return vtkVariantArray.vtkVariantArray_GetVoidPointer_16(base.GetCppThis(), id);
		}

		// Token: 0x0601EC8F RID: 126095
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVariantArray_Initialize_17(HandleRef pThis);

		/// <summary>
		/// Release storage and reset array to initial state.
		/// </summary>
		// Token: 0x0601EC90 RID: 126096 RVA: 0x002BA81C File Offset: 0x002B8A1C
		public override void Initialize()
		{
			vtkVariantArray.vtkVariantArray_Initialize_17(base.GetCppThis());
		}

		// Token: 0x0601EC91 RID: 126097
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVariantArray_InsertNextTuple_18(HandleRef pThis, long j, HandleRef source);

		/// <summary>
		/// Insert the jth tuple in the source array, at the end in this array.
		/// Note that memory allocation is performed as necessary to hold the data.
		/// Returns the location at which the data was inserted.
		/// </summary>
		// Token: 0x0601EC92 RID: 126098 RVA: 0x002BA82C File Offset: 0x002B8A2C
		public override long InsertNextTuple(long j, vtkAbstractArray source)
		{
			return vtkVariantArray.vtkVariantArray_InsertNextTuple_18(base.GetCppThis(), j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601EC93 RID: 126099
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVariantArray_InsertNextValue_19(HandleRef pThis, HandleRef value);

		/// <summary>
		/// Expand the array by one and set the value at that location.
		/// Return the array index of the inserted value.
		/// </summary>
		// Token: 0x0601EC94 RID: 126100 RVA: 0x002BA864 File Offset: 0x002B8A64
		public long InsertNextValue(vtkVariant value)
		{
			return vtkVariantArray.vtkVariantArray_InsertNextValue_19(base.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601EC95 RID: 126101
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVariantArray_InsertTuple_20(HandleRef pThis, long i, long j, HandleRef source);

		/// <summary>
		/// Insert the jth tuple in the source array, at ith location in this array.
		/// Note that memory allocation is performed as necessary to hold the data.
		/// </summary>
		// Token: 0x0601EC96 RID: 126102 RVA: 0x002BA898 File Offset: 0x002B8A98
		public override void InsertTuple(long i, long j, vtkAbstractArray source)
		{
			vtkVariantArray.vtkVariantArray_InsertTuple_20(base.GetCppThis(), i, j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601EC97 RID: 126103
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVariantArray_InsertTuples_21(HandleRef pThis, HandleRef dstIds, HandleRef srcIds, HandleRef source);

		/// <summary>
		/// Copy the tuples indexed in srcIds from the source array to the tuple
		/// locations indexed by dstIds in this array.
		/// Note that memory allocation is performed as necessary to hold the data.
		/// </summary>
		// Token: 0x0601EC98 RID: 126104 RVA: 0x002BA8CC File Offset: 0x002B8ACC
		public override void InsertTuples(vtkIdList dstIds, vtkIdList srcIds, vtkAbstractArray source)
		{
			vtkVariantArray.vtkVariantArray_InsertTuples_21(base.GetCppThis(), (dstIds == null) ? default(HandleRef) : dstIds.GetCppThis(), (srcIds == null) ? default(HandleRef) : srcIds.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601EC99 RID: 126105
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVariantArray_InsertTuples_22(HandleRef pThis, long dstStart, long n, long srcStart, HandleRef source);

		/// <summary>
		/// Copy n consecutive tuples starting at srcStart from the source array to
		/// this array, starting at the dstStart location.
		/// Note that memory allocation is performed as necessary to hold the data.
		/// </summary>
		// Token: 0x0601EC9A RID: 126106 RVA: 0x002BA928 File Offset: 0x002B8B28
		public override void InsertTuples(long dstStart, long n, long srcStart, vtkAbstractArray source)
		{
			vtkVariantArray.vtkVariantArray_InsertTuples_22(base.GetCppThis(), dstStart, n, srcStart, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601EC9B RID: 126107
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVariantArray_InsertTuplesStartingAt_23(HandleRef pThis, long dstStart, HandleRef srcIds, HandleRef source);

		/// <summary>
		/// Copy the tuples indexed in srcIds from the source array to the tuple
		/// locations indexed by dstIds in this array.
		/// Note that memory allocation is performed as necessary to hold the data.
		/// </summary>
		// Token: 0x0601EC9C RID: 126108 RVA: 0x002BA95C File Offset: 0x002B8B5C
		public override void InsertTuplesStartingAt(long dstStart, vtkIdList srcIds, vtkAbstractArray source)
		{
			vtkVariantArray.vtkVariantArray_InsertTuplesStartingAt_23(base.GetCppThis(), dstStart, (srcIds == null) ? default(HandleRef) : srcIds.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601EC9D RID: 126109
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVariantArray_InsertValue_24(HandleRef pThis, long id, HandleRef value);

		/// <summary>
		/// If id &lt; GetNumberOfValues(), overwrite the array at that index.
		/// If id &gt;= GetNumberOfValues(), expand the array size to id+1
		/// and set the final value to the specified value.
		/// </summary>
		// Token: 0x0601EC9E RID: 126110 RVA: 0x002BA9A4 File Offset: 0x002B8BA4
		public void InsertValue(long id, vtkVariant value)
		{
			vtkVariantArray.vtkVariantArray_InsertValue_24(base.GetCppThis(), id, (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601EC9F RID: 126111
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVariantArray_InsertVariantValue_25(HandleRef pThis, long idx, HandleRef value);

		/// <summary>
		/// Safely insert a value into the array from a variant.
		/// </summary>
		// Token: 0x0601ECA0 RID: 126112 RVA: 0x002BA9D4 File Offset: 0x002B8BD4
		public override void InsertVariantValue(long idx, vtkVariant value)
		{
			vtkVariantArray.vtkVariantArray_InsertVariantValue_25(base.GetCppThis(), idx, (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601ECA1 RID: 126113
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVariantArray_InterpolateTuple_26(HandleRef pThis, long i, HandleRef ptIndices, HandleRef source, IntPtr weights);

		/// <summary>
		/// Set the ith tuple in this array as the interpolated tuple value,
		/// given the ptIndices in the source array and associated
		/// interpolation weights.
		/// This method assumes that the two arrays are of the same type
		/// and structure.
		/// </summary>
		// Token: 0x0601ECA2 RID: 126114 RVA: 0x002BAA04 File Offset: 0x002B8C04
		public override void InterpolateTuple(long i, vtkIdList ptIndices, vtkAbstractArray source, IntPtr weights)
		{
			vtkVariantArray.vtkVariantArray_InterpolateTuple_26(base.GetCppThis(), i, (ptIndices == null) ? default(HandleRef) : ptIndices.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis(), weights);
		}

		// Token: 0x0601ECA3 RID: 126115
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVariantArray_InterpolateTuple_27(HandleRef pThis, long i, long id1, HandleRef source1, long id2, HandleRef source2, double t);

		/// <summary>
		/// Insert the ith tuple in this array as interpolated from the two values,
		/// p1 and p2, and an interpolation factor, t.
		/// The interpolation factor ranges from (0,1),
		/// with t=0 located at p1. This method assumes that the three arrays are of
		/// the same type. p1 is value at index id1 in source1, while, p2 is
		/// value at index id2 in source2.
		/// </summary>
		// Token: 0x0601ECA4 RID: 126116 RVA: 0x002BAA4C File Offset: 0x002B8C4C
		public override void InterpolateTuple(long i, long id1, vtkAbstractArray source1, long id2, vtkAbstractArray source2, double t)
		{
			vtkVariantArray.vtkVariantArray_InterpolateTuple_27(base.GetCppThis(), i, id1, (source1 == null) ? default(HandleRef) : source1.GetCppThis(), id2, (source2 == null) ? default(HandleRef) : source2.GetCppThis(), t);
		}

		// Token: 0x0601ECA5 RID: 126117
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVariantArray_IsA_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ECA6 RID: 126118 RVA: 0x002BAA98 File Offset: 0x002B8C98
		public override int IsA(string type)
		{
			return vtkVariantArray.vtkVariantArray_IsA_28(base.GetCppThis(), type);
		}

		// Token: 0x0601ECA7 RID: 126119
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVariantArray_IsNumeric_29(HandleRef pThis);

		/// <summary>
		/// Since each item can be of a different type, we say that a variant array is not numeric.
		/// </summary>
		// Token: 0x0601ECA8 RID: 126120 RVA: 0x002BAAB8 File Offset: 0x002B8CB8
		public override int IsNumeric()
		{
			return vtkVariantArray.vtkVariantArray_IsNumeric_29(base.GetCppThis());
		}

		// Token: 0x0601ECA9 RID: 126121
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVariantArray_IsTypeOf_30([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ECAA RID: 126122 RVA: 0x002BAAD8 File Offset: 0x002B8CD8
		public new static int IsTypeOf(string type)
		{
			return vtkVariantArray.vtkVariantArray_IsTypeOf_30(type);
		}

		// Token: 0x0601ECAB RID: 126123
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVariantArray_LookupValue_31(HandleRef pThis, HandleRef value);

		/// <summary>
		/// Return the indices where a specific value appears.
		/// </summary>
		// Token: 0x0601ECAC RID: 126124 RVA: 0x002BAAF4 File Offset: 0x002B8CF4
		public override long LookupValue(vtkVariant value)
		{
			return vtkVariantArray.vtkVariantArray_LookupValue_31(base.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601ECAD RID: 126125
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVariantArray_LookupValue_32(HandleRef pThis, HandleRef value, HandleRef ids);

		/// <summary>
		/// Return the indices where a specific value appears.
		/// </summary>
		// Token: 0x0601ECAE RID: 126126 RVA: 0x002BAB28 File Offset: 0x002B8D28
		public override void LookupValue(vtkVariant value, vtkIdList ids)
		{
			vtkVariantArray.vtkVariantArray_LookupValue_32(base.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis(), (ids == null) ? default(HandleRef) : ids.GetCppThis());
		}

		// Token: 0x0601ECAF RID: 126127
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVariantArray_NewInstance_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ECB0 RID: 126128 RVA: 0x002BAB6C File Offset: 0x002B8D6C
		public new vtkVariantArray NewInstance()
		{
			vtkVariantArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVariantArray.vtkVariantArray_NewInstance_34(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVariantArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601ECB1 RID: 126129
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVariantArray_NewIterator_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Subclasses must override this method and provide the right
		/// kind of templated vtkArrayIteratorTemplate.
		/// </summary>
		// Token: 0x0601ECB2 RID: 126130 RVA: 0x002BABC8 File Offset: 0x002B8DC8
		public override vtkArrayIterator NewIterator()
		{
			vtkArrayIterator vtkArrayIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVariantArray.vtkVariantArray_NewIterator_35(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArrayIterator = (vtkArrayIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArrayIterator.Register(null);
				}
			}
			return vtkArrayIterator;
		}

		// Token: 0x0601ECB3 RID: 126131
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVariantArray_Resize_36(HandleRef pThis, long numTuples);

		/// <summary>
		/// Resize the array while conserving the data.  Returns 1 if
		/// resizing succeeded and 0 otherwise.
		/// </summary>
		// Token: 0x0601ECB4 RID: 126132 RVA: 0x002BAC38 File Offset: 0x002B8E38
		public override int Resize(long numTuples)
		{
			return vtkVariantArray.vtkVariantArray_Resize_36(base.GetCppThis(), numTuples);
		}

		// Token: 0x0601ECB5 RID: 126133
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVariantArray_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ECB6 RID: 126134 RVA: 0x002BAC58 File Offset: 0x002B8E58
		public new static vtkVariantArray SafeDownCast(vtkObjectBase o)
		{
			vtkVariantArray vtkVariantArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVariantArray.vtkVariantArray_SafeDownCast_37((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVariantArray = (vtkVariantArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVariantArray.Register(null);
				}
			}
			return vtkVariantArray;
		}

		// Token: 0x0601ECB7 RID: 126135
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVariantArray_SetArray_38(HandleRef pThis, HandleRef arr, long size, int save, int deleteMethod);

		/// <summary>
		/// Set the internal array used by this object.
		/// </summary>
		// Token: 0x0601ECB8 RID: 126136 RVA: 0x002BACD8 File Offset: 0x002B8ED8
		public void SetArray(vtkVariant arr, long size, int save, int deleteMethod)
		{
			vtkVariantArray.vtkVariantArray_SetArray_38(base.GetCppThis(), (arr == null) ? default(HandleRef) : arr.GetCppThis(), size, save, deleteMethod);
		}

		// Token: 0x0601ECB9 RID: 126137
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVariantArray_SetNumberOfTuples_39(HandleRef pThis, long number);

		/// <summary>
		/// Set the number of tuples (a component group) in the array. Note that
		/// this may allocate space depending on the number of components.
		/// </summary>
		// Token: 0x0601ECBA RID: 126138 RVA: 0x002BAD0B File Offset: 0x002B8F0B
		public override void SetNumberOfTuples(long number)
		{
			vtkVariantArray.vtkVariantArray_SetNumberOfTuples_39(base.GetCppThis(), number);
		}

		// Token: 0x0601ECBB RID: 126139
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVariantArray_SetTuple_40(HandleRef pThis, long i, long j, HandleRef source);

		/// <summary>
		/// Set the tuple at the ith location using the jth tuple in the source array.
		/// This method assumes that the two arrays have the same type
		/// and structure. Note that range checking and memory allocation is not
		/// performed; use in conjunction with SetNumberOfTuples() to allocate space.
		/// </summary>
		// Token: 0x0601ECBC RID: 126140 RVA: 0x002BAD1C File Offset: 0x002B8F1C
		public override void SetTuple(long i, long j, vtkAbstractArray source)
		{
			vtkVariantArray.vtkVariantArray_SetTuple_40(base.GetCppThis(), i, j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601ECBD RID: 126141
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVariantArray_SetValue_41(HandleRef pThis, long id, HandleRef value);

		/// <summary>
		/// Set the data at a particular index. Does not do range checking. Make sure
		/// you use the method SetNumberOfValues() before inserting data.
		/// </summary>
		// Token: 0x0601ECBE RID: 126142 RVA: 0x002BAD50 File Offset: 0x002B8F50
		public void SetValue(long id, vtkVariant value)
		{
			vtkVariantArray.vtkVariantArray_SetValue_41(base.GetCppThis(), id, (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601ECBF RID: 126143
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVariantArray_SetVariantValue_42(HandleRef pThis, long idx, HandleRef value);

		/// <summary>
		/// Insert a value into the array from a variant.
		/// </summary>
		// Token: 0x0601ECC0 RID: 126144 RVA: 0x002BAD80 File Offset: 0x002B8F80
		public override void SetVariantValue(long idx, vtkVariant value)
		{
			vtkVariantArray.vtkVariantArray_SetVariantValue_42(base.GetCppThis(), idx, (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601ECC1 RID: 126145
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVariantArray_SetVoidArray_43(HandleRef pThis, IntPtr arr, long size, int save);

		/// <summary>
		/// This method lets the user specify data to be held by the array.  The
		/// array argument is a pointer to the data.  size is the size of
		/// the array supplied by the user.  Set save to 1 to keep the class
		/// from deleting the array when it cleans up or reallocates memory.
		/// The class uses the actual array provided; it does not copy the data
		/// from the supplied array.
		/// </summary>
		// Token: 0x0601ECC2 RID: 126146 RVA: 0x002BADB0 File Offset: 0x002B8FB0
		public override void SetVoidArray(IntPtr arr, long size, int save)
		{
			vtkVariantArray.vtkVariantArray_SetVoidArray_43(base.GetCppThis(), arr, size, save);
		}

		// Token: 0x0601ECC3 RID: 126147
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVariantArray_SetVoidArray_44(HandleRef pThis, IntPtr arr, long size, int save, int deleteM);

		/// <summary>
		/// This method lets the user specify data to be held by the array.  The
		/// array argument is a pointer to the data.  size is the size of
		/// the array supplied by the user.  Set save to 1 to keep the class
		/// from deleting the array when it cleans up or reallocates memory.
		/// The class uses the actual array provided; it does not copy the data
		/// from the supplied array.
		/// </summary>
		// Token: 0x0601ECC4 RID: 126148 RVA: 0x002BADC2 File Offset: 0x002B8FC2
		public override void SetVoidArray(IntPtr arr, long size, int save, int deleteM)
		{
			vtkVariantArray.vtkVariantArray_SetVoidArray_44(base.GetCppThis(), arr, size, save, deleteM);
		}

		// Token: 0x0601ECC5 RID: 126149
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVariantArray_Squeeze_45(HandleRef pThis);

		/// <summary>
		/// Free any unnecessary memory.
		/// Description:
		/// Resize object to just fit data requirement. Reclaims extra memory.
		/// </summary>
		// Token: 0x0601ECC6 RID: 126150 RVA: 0x002BADD6 File Offset: 0x002B8FD6
		public override void Squeeze()
		{
			vtkVariantArray.vtkVariantArray_Squeeze_45(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020F9 RID: 8441
		public new const string MRFullTypeName = "Kitware.VTK.vtkVariantArray";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020FA RID: 8442
		public new static readonly string MRClassNameKey = "class vtkVariantArray";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000B87 RID: 2951
		public new enum DeleteMethod
		{
			/// <summary>enum member</summary>
			// Token: 0x040020FC RID: 8444
			VTK_DATA_ARRAY_ALIGNED_FREE = 2,
			/// <summary>enum member</summary>
			// Token: 0x040020FD RID: 8445
			VTK_DATA_ARRAY_DELETE = 1,
			/// <summary>enum member</summary>
			// Token: 0x040020FE RID: 8446
			VTK_DATA_ARRAY_FREE = 0,
			/// <summary>enum member</summary>
			// Token: 0x040020FF RID: 8447
			VTK_DATA_ARRAY_USER_DEFINED = 3
		}
	}
}
