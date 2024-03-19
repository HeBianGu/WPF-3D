using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkArray
	/// </summary>
	/// <remarks>
	///    Abstract interface for N-dimensional arrays.
	///
	///
	/// vtkArray is the root of a hierarchy of arrays that can be used to
	/// store data with any number of dimensions.  It provides an abstract
	/// interface for retrieving and setting array attributes that are
	/// independent of the type of values stored in the array - such as the
	/// number of dimensions, extents along each dimension, and number of
	/// values stored in the array.
	///
	/// To get and set array values, the vtkTypedArray template class derives
	/// from vtkArray and provides type-specific methods for retrieval and
	/// update.
	///
	/// Two concrete derivatives of vtkTypedArray are provided at the moment:
	/// vtkDenseArray and vtkSparseArray, which provide dense and sparse
	/// storage for arbitrary-dimension data, respectively.  Toolkit users
	/// can create their own concrete derivatives that implement alternative
	/// storage strategies, such as compressed-sparse-row, etc.  You could
	/// also create an array that provided read-only access to 'virtual' data,
	/// such as an array that returned a Fibonacci sequence, etc.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTypedArray, vtkDenseArray, vtkSparseArray
	///
	/// @par Thanks:
	/// Developed by Timothy M. Shead (tsheadndia.gov) at  Sandia National
	/// Laboratories.
	/// </seealso>
	// Token: 0x02000B3E RID: 2878
	public abstract class vtkArray : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E1B2 RID: 123314 RVA: 0x002A960F File Offset: 0x002A780F
		static vtkArray()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkArray"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E1B3 RID: 123315 RVA: 0x002A9637 File Offset: 0x002A7837
		public vtkArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E1B4 RID: 123316 RVA: 0x002A9645 File Offset: 0x002A7845
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E1B5 RID: 123317
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArray_CreateArray_01(int StorageType, int ValueType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a new array where StorageType is one of vtkArray::DENSE
		/// or vtkArray::SPARSE, and ValueType is one of VTK_CHAR,
		/// VTK_UNSIGNED_CHAR, VTK_SHORT, VTK_UNSIGNED_SHORT,  VTK_INT,
		/// VTK_UNSIGNED_INT, VTK_LONG, VTK_UNSIGNED_LONG, VTK_DOUBLE,
		/// VTK_ID_TYPE, or VTK_STRING.  The caller is responsible for the
		/// lifetime of the returned object.
		/// </summary>
		// Token: 0x0601E1B6 RID: 123318 RVA: 0x002A9650 File Offset: 0x002A7850
		public static vtkArray CreateArray(int StorageType, int ValueType)
		{
			vtkArray vtkArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArray.vtkArray_CreateArray_01(StorageType, ValueType, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArray = (vtkArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArray.Register(null);
				}
			}
			return vtkArray;
		}

		// Token: 0x0601E1B7 RID: 123319
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArray_DeepCopy_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns a new array that is a deep copy of this array.
		/// </summary>
		// Token: 0x0601E1B8 RID: 123320 RVA: 0x002A96BC File Offset: 0x002A78BC
		public virtual vtkArray DeepCopy()
		{
			vtkArray vtkArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArray.vtkArray_DeepCopy_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArray = (vtkArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArray.Register(null);
				}
			}
			return vtkArray;
		}

		// Token: 0x0601E1B9 RID: 123321
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkArray_GetDimensionLabel_03(HandleRef pThis, long i);

		/// <summary>
		/// Returns the label for the i-th array dimension.
		/// </summary>
		// Token: 0x0601E1BA RID: 123322 RVA: 0x002A972C File Offset: 0x002A792C
		public string GetDimensionLabel(long i)
		{
			return vtkArray.vtkArray_GetDimensionLabel_03(base.GetCppThis(), i);
		}

		// Token: 0x0601E1BB RID: 123323
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArray_GetDimensions_04(HandleRef pThis);

		/// <summary>
		/// Returns the number of dimensions stored in the array.  Note that
		/// this is the same as calling GetExtents().GetDimensions().
		/// </summary>
		// Token: 0x0601E1BC RID: 123324 RVA: 0x002A974C File Offset: 0x002A794C
		public long GetDimensions()
		{
			return vtkArray.vtkArray_GetDimensions_04(base.GetCppThis());
		}

		// Token: 0x0601E1BD RID: 123325
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkArray_GetName_05(HandleRef pThis);

		/// <summary>
		/// Returns the array name.
		/// </summary>
		// Token: 0x0601E1BE RID: 123326 RVA: 0x002A976C File Offset: 0x002A796C
		public string GetName()
		{
			return vtkArray.vtkArray_GetName_05(base.GetCppThis());
		}

		// Token: 0x0601E1BF RID: 123327
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkArray_GetNonNullSize_06(HandleRef pThis);

		/// <summary>
		/// Returns the number of non-null values stored in the array.  Note
		/// that this value will equal GetSize() for dense arrays, and will be
		/// less-than-or-equal to GetSize() for sparse arrays.
		/// </summary>
		// Token: 0x0601E1C0 RID: 123328 RVA: 0x002A978C File Offset: 0x002A798C
		public virtual ulong GetNonNullSize()
		{
			return vtkArray.vtkArray_GetNonNullSize_06(base.GetCppThis());
		}

		// Token: 0x0601E1C1 RID: 123329
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArray_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E1C2 RID: 123330 RVA: 0x002A97AC File Offset: 0x002A79AC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkArray.vtkArray_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601E1C3 RID: 123331
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArray_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E1C4 RID: 123332 RVA: 0x002A97CC File Offset: 0x002A79CC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkArray.vtkArray_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0601E1C5 RID: 123333
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkArray_GetSize_09(HandleRef pThis);

		/// <summary>
		/// Returns the number of values stored in the array.  Note that this is
		/// the same as calling GetExtents().GetSize(), and represents the
		/// maximum number of values that could ever be stored using the current
		/// extents.  This is equal to the number of values stored in a dense
		/// array, but may be larger than the number of values stored in a
		/// sparse array.
		/// </summary>
		// Token: 0x0601E1C6 RID: 123334 RVA: 0x002A97E8 File Offset: 0x002A79E8
		public ulong GetSize()
		{
			return vtkArray.vtkArray_GetSize_09(base.GetCppThis());
		}

		// Token: 0x0601E1C7 RID: 123335
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArray_GetVariantValue_10(HandleRef pThis, long i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the value stored in the array at the given coordinates.
		/// Note that the number of dimensions in the supplied coordinates must
		/// match the number of dimensions in the array.
		/// </summary>
		// Token: 0x0601E1C8 RID: 123336 RVA: 0x002A9808 File Offset: 0x002A7A08
		public vtkVariant GetVariantValue(long i)
		{
			vtkVariant result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArray.vtkArray_GetVariantValue_10(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E1C9 RID: 123337
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArray_GetVariantValue_11(HandleRef pThis, long i, long j, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the value stored in the array at the given coordinates.
		/// Note that the number of dimensions in the supplied coordinates must
		/// match the number of dimensions in the array.
		/// </summary>
		// Token: 0x0601E1CA RID: 123338 RVA: 0x002A9864 File Offset: 0x002A7A64
		public vtkVariant GetVariantValue(long i, long j)
		{
			vtkVariant result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArray.vtkArray_GetVariantValue_11(base.GetCppThis(), i, j, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E1CB RID: 123339
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArray_GetVariantValue_12(HandleRef pThis, long i, long j, long k, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the value stored in the array at the given coordinates.
		/// Note that the number of dimensions in the supplied coordinates must
		/// match the number of dimensions in the array.
		/// </summary>
		// Token: 0x0601E1CC RID: 123340 RVA: 0x002A98C0 File Offset: 0x002A7AC0
		public vtkVariant GetVariantValue(long i, long j, long k)
		{
			vtkVariant result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArray.vtkArray_GetVariantValue_12(base.GetCppThis(), i, j, k, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E1CD RID: 123341
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArray_GetVariantValueN_13(HandleRef pThis, ulong n, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the n-th value stored in the array, where n is in the
		/// range [0, GetNonNullSize()).  This is useful for efficiently
		/// visiting every value in the array.  Note that the order in which
		/// values are visited is undefined, but is guaranteed to match the
		/// order used by vtkArray::GetCoordinatesN().
		/// </summary>
		// Token: 0x0601E1CE RID: 123342 RVA: 0x002A9920 File Offset: 0x002A7B20
		public virtual vtkVariant GetVariantValueN(ulong n)
		{
			vtkVariant result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArray.vtkArray_GetVariantValueN_13(base.GetCppThis(), n, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E1CF RID: 123343
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArray_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E1D0 RID: 123344 RVA: 0x002A997C File Offset: 0x002A7B7C
		public override int IsA(string type)
		{
			return vtkArray.vtkArray_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x0601E1D1 RID: 123345
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkArray_IsDense_15(HandleRef pThis);

		/// <summary>
		/// Returns true iff the underlying array storage is "dense", i.e. that
		/// GetSize() and GetNonNullSize() will always return the same value.
		/// If not, the array is "sparse".
		/// </summary>
		// Token: 0x0601E1D2 RID: 123346 RVA: 0x002A999C File Offset: 0x002A7B9C
		public virtual bool IsDense()
		{
			return vtkArray.vtkArray_IsDense_15(base.GetCppThis()) != 0;
		}

		// Token: 0x0601E1D3 RID: 123347
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArray_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E1D4 RID: 123348 RVA: 0x002A99C4 File Offset: 0x002A7BC4
		public new static int IsTypeOf(string type)
		{
			return vtkArray.vtkArray_IsTypeOf_16(type);
		}

		// Token: 0x0601E1D5 RID: 123349
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArray_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E1D6 RID: 123350 RVA: 0x002A99E0 File Offset: 0x002A7BE0
		public new vtkArray NewInstance()
		{
			vtkArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArray.vtkArray_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E1D7 RID: 123351
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArray_Resize_18(HandleRef pThis, long i);

		/// <summary>
		/// Resizes the array to the given extents (number of dimensions and
		/// size of each dimension).  Note that concrete implementations of
		/// vtkArray may place constraints on the extents that they will
		/// store, so you cannot assume that GetExtents() will always return
		/// the same value passed to Resize().
		///
		/// The contents of the array are undefined after calling Resize() - you
		/// should initialize its contents accordingly.  In particular,
		/// dimension-labels will be undefined, dense array values will be
		/// undefined, and sparse arrays will be empty.
		/// </summary>
		// Token: 0x0601E1D8 RID: 123352 RVA: 0x002A9A3A File Offset: 0x002A7C3A
		public void Resize(long i)
		{
			vtkArray.vtkArray_Resize_18(base.GetCppThis(), i);
		}

		// Token: 0x0601E1D9 RID: 123353
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArray_Resize_19(HandleRef pThis, long i, long j);

		/// <summary>
		/// Resizes the array to the given extents (number of dimensions and
		/// size of each dimension).  Note that concrete implementations of
		/// vtkArray may place constraints on the extents that they will
		/// store, so you cannot assume that GetExtents() will always return
		/// the same value passed to Resize().
		///
		/// The contents of the array are undefined after calling Resize() - you
		/// should initialize its contents accordingly.  In particular,
		/// dimension-labels will be undefined, dense array values will be
		/// undefined, and sparse arrays will be empty.
		/// </summary>
		// Token: 0x0601E1DA RID: 123354 RVA: 0x002A9A4A File Offset: 0x002A7C4A
		public void Resize(long i, long j)
		{
			vtkArray.vtkArray_Resize_19(base.GetCppThis(), i, j);
		}

		// Token: 0x0601E1DB RID: 123355
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArray_Resize_20(HandleRef pThis, long i, long j, long k);

		/// <summary>
		/// Resizes the array to the given extents (number of dimensions and
		/// size of each dimension).  Note that concrete implementations of
		/// vtkArray may place constraints on the extents that they will
		/// store, so you cannot assume that GetExtents() will always return
		/// the same value passed to Resize().
		///
		/// The contents of the array are undefined after calling Resize() - you
		/// should initialize its contents accordingly.  In particular,
		/// dimension-labels will be undefined, dense array values will be
		/// undefined, and sparse arrays will be empty.
		/// </summary>
		// Token: 0x0601E1DC RID: 123356 RVA: 0x002A9A5B File Offset: 0x002A7C5B
		public void Resize(long i, long j, long k)
		{
			vtkArray.vtkArray_Resize_20(base.GetCppThis(), i, j, k);
		}

		// Token: 0x0601E1DD RID: 123357
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArray_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E1DE RID: 123358 RVA: 0x002A9A70 File Offset: 0x002A7C70
		public new static vtkArray SafeDownCast(vtkObjectBase o)
		{
			vtkArray vtkArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArray.vtkArray_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArray = (vtkArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArray.Register(null);
				}
			}
			return vtkArray;
		}

		// Token: 0x0601E1DF RID: 123359
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArray_SetDimensionLabel_22(HandleRef pThis, long i, [MarshalAs(UnmanagedType.LPUTF8Str)] string label);

		/// <summary>
		/// Sets the label for the i-th array dimension.
		/// </summary>
		// Token: 0x0601E1E0 RID: 123360 RVA: 0x002A9AEF File Offset: 0x002A7CEF
		public void SetDimensionLabel(long i, string label)
		{
			vtkArray.vtkArray_SetDimensionLabel_22(base.GetCppThis(), i, label);
		}

		// Token: 0x0601E1E1 RID: 123361
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArray_SetName_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Sets the array name.
		/// </summary>
		// Token: 0x0601E1E2 RID: 123362 RVA: 0x002A9B00 File Offset: 0x002A7D00
		public void SetName(string name)
		{
			vtkArray.vtkArray_SetName_23(base.GetCppThis(), name);
		}

		// Token: 0x0601E1E3 RID: 123363
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArray_SetVariantValue_24(HandleRef pThis, long i, HandleRef value);

		/// <summary>
		/// Overwrites the value stored in the array at the given coordinates.
		/// Note that the number of dimensions in the supplied coordinates must
		/// match the number of dimensions in the array.
		/// </summary>
		// Token: 0x0601E1E4 RID: 123364 RVA: 0x002A9B10 File Offset: 0x002A7D10
		public void SetVariantValue(long i, vtkVariant value)
		{
			vtkArray.vtkArray_SetVariantValue_24(base.GetCppThis(), i, (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E1E5 RID: 123365
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArray_SetVariantValue_25(HandleRef pThis, long i, long j, HandleRef value);

		/// <summary>
		/// Overwrites the value stored in the array at the given coordinates.
		/// Note that the number of dimensions in the supplied coordinates must
		/// match the number of dimensions in the array.
		/// </summary>
		// Token: 0x0601E1E6 RID: 123366 RVA: 0x002A9B40 File Offset: 0x002A7D40
		public void SetVariantValue(long i, long j, vtkVariant value)
		{
			vtkArray.vtkArray_SetVariantValue_25(base.GetCppThis(), i, j, (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E1E7 RID: 123367
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArray_SetVariantValue_26(HandleRef pThis, long i, long j, long k, HandleRef value);

		/// <summary>
		/// Overwrites the value stored in the array at the given coordinates.
		/// Note that the number of dimensions in the supplied coordinates must
		/// match the number of dimensions in the array.
		/// </summary>
		// Token: 0x0601E1E8 RID: 123368 RVA: 0x002A9B74 File Offset: 0x002A7D74
		public void SetVariantValue(long i, long j, long k, vtkVariant value)
		{
			vtkArray.vtkArray_SetVariantValue_26(base.GetCppThis(), i, j, k, (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E1E9 RID: 123369
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArray_SetVariantValueN_27(HandleRef pThis, ulong n, HandleRef value);

		/// <summary>
		/// Overwrites the n-th value stored in the array, where n is in the
		/// range [0, GetNonNullSize()).  This is useful for efficiently
		/// visiting every value in the array.  Note that the order in which
		/// values are visited is undefined, but is guaranteed to match the
		/// order used by vtkArray::GetCoordinatesN().
		/// </summary>
		// Token: 0x0601E1EA RID: 123370 RVA: 0x002A9BA8 File Offset: 0x002A7DA8
		public virtual void SetVariantValueN(ulong n, vtkVariant value)
		{
			vtkArray.vtkArray_SetVariantValueN_27(base.GetCppThis(), n, (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FCB RID: 8139
		public new const string MRFullTypeName = "Kitware.VTK.vtkArray";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FCC RID: 8140
		public new static readonly string MRClassNameKey = "class vtkArray";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000B3F RID: 2879
		public enum DENSE_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04001FCE RID: 8142
			DENSE,
			/// <summary>enum member</summary>
			// Token: 0x04001FCF RID: 8143
			SPARSE
		}
	}
}
