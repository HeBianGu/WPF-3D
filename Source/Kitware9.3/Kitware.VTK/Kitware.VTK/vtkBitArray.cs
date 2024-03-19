using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBitArray
	/// </summary>
	/// <remarks>
	///    dynamic, self-adjusting array of bits
	///
	/// vtkBitArray is an array of bits (0/1 data value). The array is packed
	/// so that each byte stores eight bits. vtkBitArray provides methods
	/// for insertion and retrieval of bits, and will automatically resize
	/// itself to hold new data.
	///
	/// &gt; WARNING
	/// &gt; This class is not thread-safe during write access
	/// </remarks>
	// Token: 0x02000B41 RID: 2881
	public class vtkBitArray : vtkDataArray
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E1FE RID: 123390 RVA: 0x002A9DBF File Offset: 0x002A7FBF
		static vtkBitArray()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBitArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBitArray"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E1FF RID: 123391 RVA: 0x002A9DE7 File Offset: 0x002A7FE7
		public vtkBitArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E200 RID: 123392
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBitArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E201 RID: 123393 RVA: 0x002A9DF8 File Offset: 0x002A7FF8
		public new static vtkBitArray New()
		{
			vtkBitArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBitArray.vtkBitArray_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBitArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E202 RID: 123394 RVA: 0x002A9E4C File Offset: 0x002A804C
		public vtkBitArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBitArray.vtkBitArray_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E203 RID: 123395 RVA: 0x002A9E90 File Offset: 0x002A8090
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E204 RID: 123396
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBitArray_Allocate_01(HandleRef pThis, long sz, long ext);

		/// <summary>
		/// Allocate memory for this array. Delete old storage only if necessary.
		/// Note that ext is no longer used.
		/// </summary>
		// Token: 0x0601E205 RID: 123397 RVA: 0x002A9E9C File Offset: 0x002A809C
		public override int Allocate(long sz, long ext)
		{
			return vtkBitArray.vtkBitArray_Allocate_01(base.GetCppThis(), sz, ext);
		}

		// Token: 0x0601E206 RID: 123398
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBitArray_ClearLookup_02(HandleRef pThis);

		/// <summary>
		/// Delete the associated fast lookup data structure on this array,
		/// if it exists.  The lookup will be rebuilt on the next call to a lookup
		/// function.
		/// </summary>
		// Token: 0x0601E207 RID: 123399 RVA: 0x002A9EBD File Offset: 0x002A80BD
		public override void ClearLookup()
		{
			vtkBitArray.vtkBitArray_ClearLookup_02(base.GetCppThis());
		}

		// Token: 0x0601E208 RID: 123400
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBitArray_DataChanged_03(HandleRef pThis);

		/// <summary>
		/// Tell the array explicitly that the data has changed.
		/// This is only necessary to call when you modify the array contents
		/// without using the array's API (i.e. you retrieve a pointer to the
		/// data and modify the array contents).  You need to call this so that
		/// the fast lookup will know to rebuild itself.  Otherwise, the lookup
		/// functions will give incorrect results.
		/// </summary>
		// Token: 0x0601E209 RID: 123401 RVA: 0x002A9ECC File Offset: 0x002A80CC
		public override void DataChanged()
		{
			vtkBitArray.vtkBitArray_DataChanged_03(base.GetCppThis());
		}

		// Token: 0x0601E20A RID: 123402
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBitArray_DeepCopy_04(HandleRef pThis, HandleRef da);

		/// <summary>
		/// Deep copy of another bit array.
		/// </summary>
		// Token: 0x0601E20B RID: 123403 RVA: 0x002A9EDC File Offset: 0x002A80DC
		public override void DeepCopy(vtkDataArray da)
		{
			vtkBitArray.vtkBitArray_DeepCopy_04(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		// Token: 0x0601E20C RID: 123404
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBitArray_DeepCopy_05(HandleRef pThis, HandleRef aa);

		/// <summary>
		/// Deep copy of another bit array.
		/// </summary>
		// Token: 0x0601E20D RID: 123405 RVA: 0x002A9F0C File Offset: 0x002A810C
		public override void DeepCopy(vtkAbstractArray aa)
		{
			vtkBitArray.vtkBitArray_DeepCopy_05(base.GetCppThis(), (aa == null) ? default(HandleRef) : aa.GetCppThis());
		}

		// Token: 0x0601E20E RID: 123406
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBitArray_GetDataType_06(HandleRef pThis);

		/// <summary>
		/// Release storage and reset array to initial state.
		/// </summary>
		// Token: 0x0601E20F RID: 123407 RVA: 0x002A9F3C File Offset: 0x002A813C
		public override int GetDataType()
		{
			return vtkBitArray.vtkBitArray_GetDataType_06(base.GetCppThis());
		}

		// Token: 0x0601E210 RID: 123408
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBitArray_GetDataTypeSize_07(HandleRef pThis);

		/// <summary>
		/// Release storage and reset array to initial state.
		/// </summary>
		// Token: 0x0601E211 RID: 123409 RVA: 0x002A9F5C File Offset: 0x002A815C
		public override int GetDataTypeSize()
		{
			return vtkBitArray.vtkBitArray_GetDataTypeSize_07(base.GetCppThis());
		}

		// Token: 0x0601E212 RID: 123410
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBitArray_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E213 RID: 123411 RVA: 0x002A9F7C File Offset: 0x002A817C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBitArray.vtkBitArray_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0601E214 RID: 123412
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBitArray_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E215 RID: 123413 RVA: 0x002A9F9C File Offset: 0x002A819C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBitArray.vtkBitArray_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0601E216 RID: 123414
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBitArray_GetPointer_10(HandleRef pThis, long id);

		/// <summary>
		/// Direct manipulation of the underlying data.
		/// </summary>
		// Token: 0x0601E217 RID: 123415 RVA: 0x002A9FB8 File Offset: 0x002A81B8
		public IntPtr GetPointer(long id)
		{
			return vtkBitArray.vtkBitArray_GetPointer_10(base.GetCppThis(), id);
		}

		// Token: 0x0601E218 RID: 123416
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBitArray_GetTuple_11(HandleRef pThis, long i);

		/// <summary>
		/// Get a pointer to a tuple at the ith location. This is a dangerous method
		/// (it is not thread safe since a pointer is returned).
		/// </summary>
		// Token: 0x0601E219 RID: 123417 RVA: 0x002A9FD8 File Offset: 0x002A81D8
		public override IntPtr GetTuple(long i)
		{
			return vtkBitArray.vtkBitArray_GetTuple_11(base.GetCppThis(), i);
		}

		// Token: 0x0601E21A RID: 123418
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBitArray_GetTuple_12(HandleRef pThis, long i, IntPtr tuple);

		/// <summary>
		/// Copy the tuple value into a user-provided array.
		/// </summary>
		// Token: 0x0601E21B RID: 123419 RVA: 0x002A9FF8 File Offset: 0x002A81F8
		public override void GetTuple(long i, IntPtr tuple)
		{
			vtkBitArray.vtkBitArray_GetTuple_12(base.GetCppThis(), i, tuple);
		}

		// Token: 0x0601E21C RID: 123420
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBitArray_GetValue_13(HandleRef pThis, long id);

		/// <summary>
		/// Get the data at a particular index.
		/// </summary>
		// Token: 0x0601E21D RID: 123421 RVA: 0x002AA00C File Offset: 0x002A820C
		public int GetValue(long id)
		{
			return vtkBitArray.vtkBitArray_GetValue_13(base.GetCppThis(), id);
		}

		// Token: 0x0601E21E RID: 123422
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBitArray_GetVoidPointer_14(HandleRef pThis, long id);

		/// <summary>
		/// Get the address of a particular data index. Make sure data is allocated
		/// for the number of items requested. Set MaxId according to the number of
		/// data values requested.
		/// </summary>
		// Token: 0x0601E21F RID: 123423 RVA: 0x002AA02C File Offset: 0x002A822C
		public override IntPtr GetVoidPointer(long id)
		{
			return vtkBitArray.vtkBitArray_GetVoidPointer_14(base.GetCppThis(), id);
		}

		// Token: 0x0601E220 RID: 123424
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBitArray_Initialize_15(HandleRef pThis);

		/// <summary>
		/// Release storage and reset array to initial state.
		/// </summary>
		// Token: 0x0601E221 RID: 123425 RVA: 0x002AA04C File Offset: 0x002A824C
		public override void Initialize()
		{
			vtkBitArray.vtkBitArray_Initialize_15(base.GetCppThis());
		}

		// Token: 0x0601E222 RID: 123426
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBitArray_InsertComponent_16(HandleRef pThis, long i, int j, double c);

		/// <summary>
		/// Insert the data component at ith tuple and jth component location.
		/// Note that memory allocation is performed as necessary to hold the data.
		///
		/// NOT THREAD-SAFE
		/// </summary>
		// Token: 0x0601E223 RID: 123427 RVA: 0x002AA05B File Offset: 0x002A825B
		public override void InsertComponent(long i, int j, double c)
		{
			vtkBitArray.vtkBitArray_InsertComponent_16(base.GetCppThis(), i, j, c);
		}

		// Token: 0x0601E224 RID: 123428
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBitArray_InsertNextTuple_17(HandleRef pThis, long j, HandleRef source);

		/// <summary>
		/// Insert the jth tuple in the source array, at the end in this array.
		/// Note that memory allocation is performed as necessary to hold the data.
		/// Returns the location at which the data was inserted.
		///
		/// NOT THREAD-SAFE
		/// </summary>
		// Token: 0x0601E225 RID: 123429 RVA: 0x002AA070 File Offset: 0x002A8270
		public override long InsertNextTuple(long j, vtkAbstractArray source)
		{
			return vtkBitArray.vtkBitArray_InsertNextTuple_17(base.GetCppThis(), j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601E226 RID: 123430
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBitArray_InsertNextTuple_18(HandleRef pThis, IntPtr tuple);

		/// <summary>
		/// Insert (memory allocation performed) the tuple onto the end of the array.
		///
		/// NOT THREAD-SAFE
		/// </summary>
		// Token: 0x0601E227 RID: 123431 RVA: 0x002AA0A8 File Offset: 0x002A82A8
		public override long InsertNextTuple(IntPtr tuple)
		{
			return vtkBitArray.vtkBitArray_InsertNextTuple_18(base.GetCppThis(), tuple);
		}

		// Token: 0x0601E228 RID: 123432
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBitArray_InsertNextValue_19(HandleRef pThis, int i);

		/// <summary>
		/// Inserts values from a variant and checks to ensure there is enough memory
		///
		/// NOT THREAD-SAFE
		/// </summary>
		// Token: 0x0601E229 RID: 123433 RVA: 0x002AA0C8 File Offset: 0x002A82C8
		public long InsertNextValue(int i)
		{
			return vtkBitArray.vtkBitArray_InsertNextValue_19(base.GetCppThis(), i);
		}

		// Token: 0x0601E22A RID: 123434
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBitArray_InsertTuple_20(HandleRef pThis, long i, long j, HandleRef source);

		/// <summary>
		/// Insert the jth tuple in the source array, at ith location in this array.
		/// Note that memory allocation is performed as necessary to hold the data.
		///
		/// NOT THREAD-SAFE
		/// </summary>
		// Token: 0x0601E22B RID: 123435 RVA: 0x002AA0E8 File Offset: 0x002A82E8
		public override void InsertTuple(long i, long j, vtkAbstractArray source)
		{
			vtkBitArray.vtkBitArray_InsertTuple_20(base.GetCppThis(), i, j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601E22C RID: 123436
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBitArray_InsertTuple_21(HandleRef pThis, long i, IntPtr tuple);

		/// <summary>
		/// Insert (memory allocation performed) the tuple into the ith location
		/// in the array.
		///
		/// NOT THREAD-SAFE
		/// </summary>
		// Token: 0x0601E22D RID: 123437 RVA: 0x002AA119 File Offset: 0x002A8319
		public override void InsertTuple(long i, IntPtr tuple)
		{
			vtkBitArray.vtkBitArray_InsertTuple_21(base.GetCppThis(), i, tuple);
		}

		// Token: 0x0601E22E RID: 123438
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBitArray_InsertTuples_22(HandleRef pThis, HandleRef dstIds, HandleRef srcIds, HandleRef source);

		/// <summary>
		/// Copy the tuples indexed in srcIds from the source array to the tuple
		/// locations indexed by dstIds in this array.
		/// Note that memory allocation is performed as necessary to hold the data.
		///
		/// NOT THREAD-SAFE
		/// </summary>
		// Token: 0x0601E22F RID: 123439 RVA: 0x002AA12C File Offset: 0x002A832C
		public override void InsertTuples(vtkIdList dstIds, vtkIdList srcIds, vtkAbstractArray source)
		{
			vtkBitArray.vtkBitArray_InsertTuples_22(base.GetCppThis(), (dstIds == null) ? default(HandleRef) : dstIds.GetCppThis(), (srcIds == null) ? default(HandleRef) : srcIds.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601E230 RID: 123440
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBitArray_InsertTuples_23(HandleRef pThis, long dstStart, long n, long srcStart, HandleRef source);

		/// <summary>
		/// Copy n consecutive tuples starting at srcStart from the source array to
		/// this array, starting at the dstStart location.
		/// Note that memory allocation is performed as necessary to hold the data.
		///
		/// NOT THREAD-SAFE
		/// </summary>
		// Token: 0x0601E231 RID: 123441 RVA: 0x002AA188 File Offset: 0x002A8388
		public override void InsertTuples(long dstStart, long n, long srcStart, vtkAbstractArray source)
		{
			vtkBitArray.vtkBitArray_InsertTuples_23(base.GetCppThis(), dstStart, n, srcStart, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601E232 RID: 123442
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBitArray_InsertTuplesStartingAt_24(HandleRef pThis, long dstStart, HandleRef srcIds, HandleRef source);

		/// <summary>
		/// Copy the tuples indexed in srcIds from the source array to the tuple
		/// locations starting at index dstStart.
		/// Note that memory allocation is performed as necessary to hold the data.
		///
		/// NOT THREAD-SAFE
		/// </summary>
		// Token: 0x0601E233 RID: 123443 RVA: 0x002AA1BC File Offset: 0x002A83BC
		public override void InsertTuplesStartingAt(long dstStart, vtkIdList srcIds, vtkAbstractArray source)
		{
			vtkBitArray.vtkBitArray_InsertTuplesStartingAt_24(base.GetCppThis(), dstStart, (srcIds == null) ? default(HandleRef) : srcIds.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601E234 RID: 123444
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBitArray_InsertValue_25(HandleRef pThis, long id, int i);

		/// <summary>
		/// Inserts values and checks to make sure there is enough memory
		///
		/// NOT THREAD-SAFE
		/// </summary>
		// Token: 0x0601E235 RID: 123445 RVA: 0x002AA201 File Offset: 0x002A8401
		public void InsertValue(long id, int i)
		{
			vtkBitArray.vtkBitArray_InsertValue_25(base.GetCppThis(), id, i);
		}

		// Token: 0x0601E236 RID: 123446
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBitArray_InsertVariantValue_26(HandleRef pThis, long idx, HandleRef value);

		/// <summary>
		/// Inserts values from a variant and checks to ensure there is enough memory
		///
		/// NOT THREAD-SAFE
		/// </summary>
		// Token: 0x0601E237 RID: 123447 RVA: 0x002AA214 File Offset: 0x002A8414
		public override void InsertVariantValue(long idx, vtkVariant value)
		{
			vtkBitArray.vtkBitArray_InsertVariantValue_26(base.GetCppThis(), idx, (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E238 RID: 123448
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBitArray_IsA_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E239 RID: 123449 RVA: 0x002AA244 File Offset: 0x002A8444
		public override int IsA(string type)
		{
			return vtkBitArray.vtkBitArray_IsA_27(base.GetCppThis(), type);
		}

		// Token: 0x0601E23A RID: 123450
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBitArray_IsTypeOf_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E23B RID: 123451 RVA: 0x002AA264 File Offset: 0x002A8464
		public new static int IsTypeOf(string type)
		{
			return vtkBitArray.vtkBitArray_IsTypeOf_28(type);
		}

		// Token: 0x0601E23C RID: 123452
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBitArray_LookupValue_29(HandleRef pThis, HandleRef value);

		/// <summary>
		/// Return the indices where a specific value appears.
		/// </summary>
		// Token: 0x0601E23D RID: 123453 RVA: 0x002AA280 File Offset: 0x002A8480
		public override long LookupValue(vtkVariant value)
		{
			return vtkBitArray.vtkBitArray_LookupValue_29(base.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E23E RID: 123454
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBitArray_LookupValue_30(HandleRef pThis, HandleRef value, HandleRef ids);

		/// <summary>
		/// Return the indices where a specific value appears.
		/// </summary>
		// Token: 0x0601E23F RID: 123455 RVA: 0x002AA2B4 File Offset: 0x002A84B4
		public override void LookupValue(vtkVariant value, vtkIdList ids)
		{
			vtkBitArray.vtkBitArray_LookupValue_30(base.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis(), (ids == null) ? default(HandleRef) : ids.GetCppThis());
		}

		// Token: 0x0601E240 RID: 123456
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBitArray_LookupValue_31(HandleRef pThis, int value);

		/// <summary>
		/// Return the indices where a specific value appears.
		/// </summary>
		// Token: 0x0601E241 RID: 123457 RVA: 0x002AA2F8 File Offset: 0x002A84F8
		public long LookupValue(int value)
		{
			return vtkBitArray.vtkBitArray_LookupValue_31(base.GetCppThis(), value);
		}

		// Token: 0x0601E242 RID: 123458
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBitArray_LookupValue_32(HandleRef pThis, int value, HandleRef ids);

		/// <summary>
		/// Return the indices where a specific value appears.
		/// </summary>
		// Token: 0x0601E243 RID: 123459 RVA: 0x002AA318 File Offset: 0x002A8518
		public void LookupValue(int value, vtkIdList ids)
		{
			vtkBitArray.vtkBitArray_LookupValue_32(base.GetCppThis(), value, (ids == null) ? default(HandleRef) : ids.GetCppThis());
		}

		// Token: 0x0601E244 RID: 123460
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBitArray_NewInstance_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E245 RID: 123461 RVA: 0x002AA348 File Offset: 0x002A8548
		public new vtkBitArray NewInstance()
		{
			vtkBitArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBitArray.vtkBitArray_NewInstance_34(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBitArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E246 RID: 123462
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBitArray_NewIterator_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns a new vtkBitArrayIterator instance.
		/// </summary>
		// Token: 0x0601E247 RID: 123463 RVA: 0x002AA3A4 File Offset: 0x002A85A4
		public override vtkArrayIterator NewIterator()
		{
			vtkArrayIterator vtkArrayIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBitArray.vtkBitArray_NewIterator_35(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601E248 RID: 123464
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBitArray_RemoveFirstTuple_36(HandleRef pThis);

		/// <summary>
		/// These methods remove tuples from the data array. They shift data and
		/// resize array, so the data array is still valid after this operation. Note,
		/// this operation is fairly slow.
		///
		/// NOT THREAD-SAFE
		/// </summary>
		// Token: 0x0601E249 RID: 123465 RVA: 0x002AA413 File Offset: 0x002A8613
		public override void RemoveFirstTuple()
		{
			vtkBitArray.vtkBitArray_RemoveFirstTuple_36(base.GetCppThis());
		}

		// Token: 0x0601E24A RID: 123466
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBitArray_RemoveLastTuple_37(HandleRef pThis);

		/// <summary>
		/// These methods remove tuples from the data array. They shift data and
		/// resize array, so the data array is still valid after this operation. Note,
		/// this operation is fairly slow.
		///
		/// NOT THREAD-SAFE
		/// </summary>
		// Token: 0x0601E24B RID: 123467 RVA: 0x002AA422 File Offset: 0x002A8622
		public override void RemoveLastTuple()
		{
			vtkBitArray.vtkBitArray_RemoveLastTuple_37(base.GetCppThis());
		}

		// Token: 0x0601E24C RID: 123468
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBitArray_RemoveTuple_38(HandleRef pThis, long id);

		/// <summary>
		/// These methods remove tuples from the data array. They shift data and
		/// resize array, so the data array is still valid after this operation. Note,
		/// this operation is fairly slow.
		///
		/// NOT THREAD-SAFE
		/// </summary>
		// Token: 0x0601E24D RID: 123469 RVA: 0x002AA431 File Offset: 0x002A8631
		public override void RemoveTuple(long id)
		{
			vtkBitArray.vtkBitArray_RemoveTuple_38(base.GetCppThis(), id);
		}

		// Token: 0x0601E24E RID: 123470
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBitArray_Resize_39(HandleRef pThis, long numTuples);

		/// <summary>
		/// Resize the array while conserving the data.
		/// </summary>
		// Token: 0x0601E24F RID: 123471 RVA: 0x002AA444 File Offset: 0x002A8644
		public override int Resize(long numTuples)
		{
			return vtkBitArray.vtkBitArray_Resize_39(base.GetCppThis(), numTuples);
		}

		// Token: 0x0601E250 RID: 123472
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBitArray_SafeDownCast_40(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E251 RID: 123473 RVA: 0x002AA464 File Offset: 0x002A8664
		public new static vtkBitArray SafeDownCast(vtkObjectBase o)
		{
			vtkBitArray vtkBitArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBitArray.vtkBitArray_SafeDownCast_40((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBitArray = (vtkBitArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBitArray.Register(null);
				}
			}
			return vtkBitArray;
		}

		// Token: 0x0601E252 RID: 123474
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBitArray_SetArray_41(HandleRef pThis, IntPtr array, long size, int save, int deleteMethod);

		/// <summary>
		/// This method lets the user specify data to be held by the array.  The
		/// array argument is a pointer to the data.  size is the size of
		/// the array supplied by the user.  Set save to 1 to keep the class
		/// from deleting the array when it cleans up or reallocates memory.
		/// The class uses the actual array provided; it does not copy the data
		/// from the supplied array.
		/// If the delete method is VTK_DATA_ARRAY_USER_DEFINED
		/// a custom free function can be assigned to be called using SetArrayFreeFunction,
		/// if no custom function is assigned we will default to delete[].
		/// </summary>
		// Token: 0x0601E253 RID: 123475 RVA: 0x002AA4E3 File Offset: 0x002A86E3
		public void SetArray(IntPtr array, long size, int save, int deleteMethod)
		{
			vtkBitArray.vtkBitArray_SetArray_41(base.GetCppThis(), array, size, save, deleteMethod);
		}

		// Token: 0x0601E254 RID: 123476
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBitArray_SetComponent_42(HandleRef pThis, long i, int j, double c);

		/// <summary>
		/// Set the data component at the ith tuple and jth component location.
		/// Note that i is less then NumberOfTuples and j is less then
		/// NumberOfComponents. Make sure enough memory has been allocated (use
		/// SetNumberOfTuples() and  SetNumberOfComponents()).
		///
		/// NOT THREAD-SAFE
		/// </summary>
		// Token: 0x0601E255 RID: 123477 RVA: 0x002AA4F7 File Offset: 0x002A86F7
		public override void SetComponent(long i, int j, double c)
		{
			vtkBitArray.vtkBitArray_SetComponent_42(base.GetCppThis(), i, j, c);
		}

		// Token: 0x0601E256 RID: 123478
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBitArray_SetNumberOfTuples_43(HandleRef pThis, long number);

		/// <summary>
		/// Set the number of n-tuples in the array.
		/// </summary>
		// Token: 0x0601E257 RID: 123479 RVA: 0x002AA509 File Offset: 0x002A8709
		public override void SetNumberOfTuples(long number)
		{
			vtkBitArray.vtkBitArray_SetNumberOfTuples_43(base.GetCppThis(), number);
		}

		// Token: 0x0601E258 RID: 123480
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkBitArray_SetNumberOfValues_44(HandleRef pThis, long number);

		/// <summary>
		/// In addition to setting the number of values, this method also sets the
		/// unused bits of the last byte of the array.
		/// </summary>
		// Token: 0x0601E259 RID: 123481 RVA: 0x002AA51C File Offset: 0x002A871C
		public override bool SetNumberOfValues(long number)
		{
			return vtkBitArray.vtkBitArray_SetNumberOfValues_44(base.GetCppThis(), number) != 0;
		}

		// Token: 0x0601E25A RID: 123482
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBitArray_SetTuple_45(HandleRef pThis, long i, long j, HandleRef source);

		/// <summary>
		/// Set the tuple at the ith location using the jth tuple in the source array.
		/// This method assumes that the two arrays have the same type
		/// and structure. Note that range checking and memory allocation is not
		/// performed; use in conjunction with SetNumberOfTuples() to allocate space.
		///
		/// NOT THREAD-SAFE
		/// </summary>
		// Token: 0x0601E25B RID: 123483 RVA: 0x002AA544 File Offset: 0x002A8744
		public override void SetTuple(long i, long j, vtkAbstractArray source)
		{
			vtkBitArray.vtkBitArray_SetTuple_45(base.GetCppThis(), i, j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601E25C RID: 123484
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBitArray_SetTuple_46(HandleRef pThis, long i, IntPtr tuple);

		/// <summary>
		/// Set the tuple value at the ith location in the array.
		///
		/// NOT THREAD-SAFE
		/// </summary>
		// Token: 0x0601E25D RID: 123485 RVA: 0x002AA575 File Offset: 0x002A8775
		public override void SetTuple(long i, IntPtr tuple)
		{
			vtkBitArray.vtkBitArray_SetTuple_46(base.GetCppThis(), i, tuple);
		}

		// Token: 0x0601E25E RID: 123486
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBitArray_SetValue_47(HandleRef pThis, long id, int value);

		/// <summary>
		/// Set the data at a particular index. Does not do range checking. Make sure
		/// you use the method SetNumberOfValues() before inserting data.
		///
		/// NOT THREAD-SAFE
		/// </summary>
		// Token: 0x0601E25F RID: 123487 RVA: 0x002AA586 File Offset: 0x002A8786
		public void SetValue(long id, int value)
		{
			vtkBitArray.vtkBitArray_SetValue_47(base.GetCppThis(), id, value);
		}

		// Token: 0x0601E260 RID: 123488
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBitArray_SetVariantValue_48(HandleRef pThis, long idx, HandleRef value);

		/// <summary>
		/// Set a value in the array from a variant.
		///
		/// NOT THREAD-SAFE
		/// </summary>
		// Token: 0x0601E261 RID: 123489 RVA: 0x002AA598 File Offset: 0x002A8798
		public override void SetVariantValue(long idx, vtkVariant value)
		{
			vtkBitArray.vtkBitArray_SetVariantValue_48(base.GetCppThis(), idx, (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E262 RID: 123490
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBitArray_SetVoidArray_49(HandleRef pThis, IntPtr array, long size, int save);

		/// <summary>
		/// This method lets the user specify data to be held by the array.  The
		/// array argument is a pointer to the data.  size is the size of
		/// the array supplied by the user.  Set save to 1 to keep the class
		/// from deleting the array when it cleans up or reallocates memory.
		/// The class uses the actual array provided; it does not copy the data
		/// from the supplied array.
		/// If the delete method is VTK_DATA_ARRAY_USER_DEFINED
		/// a custom free function can be assigned to be called using SetArrayFreeFunction,
		/// if no custom function is assigned we will default to delete[].
		/// </summary>
		// Token: 0x0601E263 RID: 123491 RVA: 0x002AA5C8 File Offset: 0x002A87C8
		public override void SetVoidArray(IntPtr array, long size, int save)
		{
			vtkBitArray.vtkBitArray_SetVoidArray_49(base.GetCppThis(), array, size, save);
		}

		// Token: 0x0601E264 RID: 123492
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBitArray_SetVoidArray_50(HandleRef pThis, IntPtr array, long size, int save, int deleteMethod);

		/// <summary>
		/// This method lets the user specify data to be held by the array.  The
		/// array argument is a pointer to the data.  size is the size of
		/// the array supplied by the user.  Set save to 1 to keep the class
		/// from deleting the array when it cleans up or reallocates memory.
		/// The class uses the actual array provided; it does not copy the data
		/// from the supplied array.
		/// If the delete method is VTK_DATA_ARRAY_USER_DEFINED
		/// a custom free function can be assigned to be called using SetArrayFreeFunction,
		/// if no custom function is assigned we will default to delete[].
		/// </summary>
		// Token: 0x0601E265 RID: 123493 RVA: 0x002AA5DA File Offset: 0x002A87DA
		public override void SetVoidArray(IntPtr array, long size, int save, int deleteMethod)
		{
			vtkBitArray.vtkBitArray_SetVoidArray_50(base.GetCppThis(), array, size, save, deleteMethod);
		}

		// Token: 0x0601E266 RID: 123494
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBitArray_Squeeze_51(HandleRef pThis);

		/// <summary>
		/// Free any unneeded memory.
		/// </summary>
		// Token: 0x0601E267 RID: 123495 RVA: 0x002AA5EE File Offset: 0x002A87EE
		public override void Squeeze()
		{
			vtkBitArray.vtkBitArray_Squeeze_51(base.GetCppThis());
		}

		// Token: 0x0601E268 RID: 123496
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBitArray_WritePointer_52(HandleRef pThis, long id, long number);

		/// <summary>
		/// Get the address of a particular data index. Make sure data is allocated
		/// for the number of items requested. Set MaxId according to the number of
		/// data values requested.
		/// </summary>
		// Token: 0x0601E269 RID: 123497 RVA: 0x002AA600 File Offset: 0x002A8800
		public IntPtr WritePointer(long id, long number)
		{
			return vtkBitArray.vtkBitArray_WritePointer_52(base.GetCppThis(), id, number);
		}

		// Token: 0x0601E26A RID: 123498
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBitArray_WriteVoidPointer_53(HandleRef pThis, long id, long number);

		/// <summary>
		/// Get the address of a particular data index. Make sure data is allocated
		/// for the number of items requested. Set MaxId according to the number of
		/// data values requested.
		/// </summary>
		// Token: 0x0601E26B RID: 123499 RVA: 0x002AA624 File Offset: 0x002A8824
		public override IntPtr WriteVoidPointer(long id, long number)
		{
			return vtkBitArray.vtkBitArray_WriteVoidPointer_53(base.GetCppThis(), id, number);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FD2 RID: 8146
		public new const string MRFullTypeName = "Kitware.VTK.vtkBitArray";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FD3 RID: 8147
		public new static readonly string MRClassNameKey = "class vtkBitArray";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000B42 RID: 2882
		public new enum DeleteMethod
		{
			/// <summary>enum member</summary>
			// Token: 0x04001FD5 RID: 8149
			VTK_DATA_ARRAY_ALIGNED_FREE = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001FD6 RID: 8150
			VTK_DATA_ARRAY_DELETE = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001FD7 RID: 8151
			VTK_DATA_ARRAY_FREE = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001FD8 RID: 8152
			VTK_DATA_ARRAY_USER_DEFINED = 3
		}
	}
}
