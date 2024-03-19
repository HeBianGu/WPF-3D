using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStringArray
	/// </summary>
	/// <remarks>
	///    a vtkAbstractArray subclass for strings
	///
	/// Points and cells may sometimes have associated data that are stored
	/// as strings, e.g. labels for information visualization projects.
	/// This class provides a clean way to store and access those strings.
	/// @par Thanks:
	/// </remarks>
	/// <seealso>
	/// Andy Wilson (atwilsondia.gov) wrote this class.
	/// </seealso>
	// Token: 0x02000B7D RID: 2941
	public class vtkStringArray : vtkAbstractArray
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601EB17 RID: 125719 RVA: 0x002B86EF File Offset: 0x002B68EF
		static vtkStringArray()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStringArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStringArray"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601EB18 RID: 125720 RVA: 0x002B8717 File Offset: 0x002B6917
		public vtkStringArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601EB19 RID: 125721
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStringArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EB1A RID: 125722 RVA: 0x002B8728 File Offset: 0x002B6928
		public new static vtkStringArray New()
		{
			vtkStringArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStringArray.vtkStringArray_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EB1B RID: 125723 RVA: 0x002B877C File Offset: 0x002B697C
		public vtkStringArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStringArray.vtkStringArray_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601EB1C RID: 125724 RVA: 0x002B87C0 File Offset: 0x002B69C0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601EB1D RID: 125725
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStringArray_Allocate_01(HandleRef pThis, long sz, long ext);

		/// <summary>
		/// Allocate memory for this array. Delete old storage only if necessary.
		/// Note that ext is no longer used.
		/// </summary>
		// Token: 0x0601EB1E RID: 125726 RVA: 0x002B87CC File Offset: 0x002B69CC
		public override int Allocate(long sz, long ext)
		{
			return vtkStringArray.vtkStringArray_Allocate_01(base.GetCppThis(), sz, ext);
		}

		// Token: 0x0601EB1F RID: 125727
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringArray_ClearLookup_02(HandleRef pThis);

		/// <summary>
		/// Delete the associated fast lookup data structure on this array,
		/// if it exists.  The lookup will be rebuilt on the next call to a lookup
		/// function.
		/// </summary>
		// Token: 0x0601EB20 RID: 125728 RVA: 0x002B87ED File Offset: 0x002B69ED
		public override void ClearLookup()
		{
			vtkStringArray.vtkStringArray_ClearLookup_02(base.GetCppThis());
		}

		// Token: 0x0601EB21 RID: 125729
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringArray_DataChanged_03(HandleRef pThis);

		/// <summary>
		/// Tell the array explicitly that the data has changed.
		/// This is only necessary to call when you modify the array contents
		/// without using the array's API (i.e. you retrieve a pointer to the
		/// data and modify the array contents).  You need to call this so that
		/// the fast lookup will know to rebuild itself.  Otherwise, the lookup
		/// functions will give incorrect results.
		/// </summary>
		// Token: 0x0601EB22 RID: 125730 RVA: 0x002B87FC File Offset: 0x002B69FC
		public override void DataChanged()
		{
			vtkStringArray.vtkStringArray_DataChanged_03(base.GetCppThis());
		}

		// Token: 0x0601EB23 RID: 125731
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringArray_DataElementChanged_04(HandleRef pThis, long id);

		/// <summary>
		/// Tell the array explicitly that a single data element has
		/// changed. Like DataChanged(), then is only necessary when you
		/// modify the array contents without using the array's API.
		/// </summary>
		// Token: 0x0601EB24 RID: 125732 RVA: 0x002B880B File Offset: 0x002B6A0B
		public virtual void DataElementChanged(long id)
		{
			vtkStringArray.vtkStringArray_DataElementChanged_04(base.GetCppThis(), id);
		}

		// Token: 0x0601EB25 RID: 125733
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringArray_DeepCopy_05(HandleRef pThis, HandleRef aa);

		/// <summary>
		/// Deep copy of another string array.  Will complain and change nothing
		/// if the array passed in is not a vtkStringArray.
		/// </summary>
		// Token: 0x0601EB26 RID: 125734 RVA: 0x002B881C File Offset: 0x002B6A1C
		public override void DeepCopy(vtkAbstractArray aa)
		{
			vtkStringArray.vtkStringArray_DeepCopy_05(base.GetCppThis(), (aa == null) ? default(HandleRef) : aa.GetCppThis());
		}

		// Token: 0x0601EB27 RID: 125735
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStringArray_ExtendedNew_06(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EB28 RID: 125736 RVA: 0x002B884C File Offset: 0x002B6A4C
		public static vtkStringArray ExtendedNew()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStringArray.vtkStringArray_ExtendedNew_06(ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601EB29 RID: 125737
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkStringArray_GetActualMemorySize_07(HandleRef pThis);

		/// <summary>
		/// Return the memory in kibibytes (1024 bytes) consumed by this data array. Used to
		/// support streaming and reading/writing data. The value returned is
		/// guaranteed to be greater than or equal to the memory required to
		/// actually represent the data represented by this object. The
		/// information returned is valid only after the pipeline has
		/// been updated.
		///
		/// This function takes into account the size of the contents of the
		/// strings as well as the string containers themselves.
		/// </summary>
		// Token: 0x0601EB2A RID: 125738 RVA: 0x002B88B8 File Offset: 0x002B6AB8
		public override uint GetActualMemorySize()
		{
			return vtkStringArray.vtkStringArray_GetActualMemorySize_07(base.GetCppThis());
		}

		// Token: 0x0601EB2B RID: 125739
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStringArray_GetDataSize_08(HandleRef pThis);

		/// <summary>
		/// Returns the size of the data in DataTypeSize units. Thus, the number of bytes
		/// for the data can be computed by GetDataSize() * GetDataTypeSize().
		/// The size computation includes the string termination character for each string.
		/// </summary>
		// Token: 0x0601EB2C RID: 125740 RVA: 0x002B88D8 File Offset: 0x002B6AD8
		public override long GetDataSize()
		{
			return vtkStringArray.vtkStringArray_GetDataSize_08(base.GetCppThis());
		}

		// Token: 0x0601EB2D RID: 125741
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStringArray_GetDataType_09(HandleRef pThis);

		/// <summary>
		/// Get the data type.
		/// </summary>
		// Token: 0x0601EB2E RID: 125742 RVA: 0x002B88F8 File Offset: 0x002B6AF8
		public override int GetDataType()
		{
			return vtkStringArray.vtkStringArray_GetDataType_09(base.GetCppThis());
		}

		// Token: 0x0601EB2F RID: 125743
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStringArray_GetDataTypeSize_10(HandleRef pThis);

		/// <summary>
		/// Return the size of the data type.  WARNING: This may not mean
		/// what you expect with strings.  It will return
		/// sizeof(std::string) and not take into account the data
		/// included in any particular string.
		/// </summary>
		// Token: 0x0601EB30 RID: 125744 RVA: 0x002B8918 File Offset: 0x002B6B18
		public override int GetDataTypeSize()
		{
			return vtkStringArray.vtkStringArray_GetDataTypeSize_10(base.GetCppThis());
		}

		// Token: 0x0601EB31 RID: 125745
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStringArray_GetElementComponentSize_11(HandleRef pThis);

		/// <summary>
		/// Return the number of values in the array.
		/// </summary>
		// Token: 0x0601EB32 RID: 125746 RVA: 0x002B8938 File Offset: 0x002B6B38
		public override int GetElementComponentSize()
		{
			return vtkStringArray.vtkStringArray_GetElementComponentSize_11(base.GetCppThis());
		}

		// Token: 0x0601EB33 RID: 125747
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStringArray_GetNumberOfElementComponents_12(HandleRef pThis);

		/// <summary>
		/// Return the number of values in the array.
		/// </summary>
		// Token: 0x0601EB34 RID: 125748 RVA: 0x002B8958 File Offset: 0x002B6B58
		public int GetNumberOfElementComponents()
		{
			return vtkStringArray.vtkStringArray_GetNumberOfElementComponents_12(base.GetCppThis());
		}

		// Token: 0x0601EB35 RID: 125749
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStringArray_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EB36 RID: 125750 RVA: 0x002B8978 File Offset: 0x002B6B78
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStringArray.vtkStringArray_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x0601EB37 RID: 125751
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStringArray_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EB38 RID: 125752 RVA: 0x002B8998 File Offset: 0x002B6B98
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStringArray.vtkStringArray_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x0601EB39 RID: 125753
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStringArray_GetNumberOfValues_15(HandleRef pThis);

		/// <summary>
		/// Return the number of values in the array.
		/// </summary>
		// Token: 0x0601EB3A RID: 125754 RVA: 0x002B89B4 File Offset: 0x002B6BB4
		public new long GetNumberOfValues()
		{
			return vtkStringArray.vtkStringArray_GetNumberOfValues_15(base.GetCppThis());
		}

		// Token: 0x0601EB3B RID: 125755
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStringArray_GetPointer_16(HandleRef pThis, long id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the address of a particular data index. Performs no checks
		/// to verify that the memory has been allocated etc.
		/// </summary>
		// Token: 0x0601EB3C RID: 125756 RVA: 0x002B89D4 File Offset: 0x002B6BD4
		public string GetPointer(long id)
		{
			string result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStringArray.vtkStringArray_GetPointer_16(base.GetCppThis(), id, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (string)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, false, out flag);
			}
			return result;
		}

		// Token: 0x0601EB3D RID: 125757
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringArray_GetTuples_17(HandleRef pThis, HandleRef ptIds, HandleRef output);

		/// <summary>
		/// Given a list of indices, return an array of values.  You must
		/// ensure that the output array has been previously allocated with
		/// enough space to hold the data and that the types match
		/// sufficiently to allow conversion (if necessary).
		/// </summary>
		// Token: 0x0601EB3E RID: 125758 RVA: 0x002B8A30 File Offset: 0x002B6C30
		public override void GetTuples(vtkIdList ptIds, vtkAbstractArray output)
		{
			vtkStringArray.vtkStringArray_GetTuples_17(base.GetCppThis(), (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x0601EB3F RID: 125759
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringArray_GetTuples_18(HandleRef pThis, long p1, long p2, HandleRef output);

		/// <summary>
		/// Get the values for the range of indices specified (i.e.,
		/// p1-&gt;p2 inclusive). You must ensure that the output array has been
		/// previously allocated with enough space to hold the data and that
		/// the type of the output array is compatible with the type of this
		/// array.
		/// </summary>
		// Token: 0x0601EB40 RID: 125760 RVA: 0x002B8A74 File Offset: 0x002B6C74
		public override void GetTuples(long p1, long p2, vtkAbstractArray output)
		{
			vtkStringArray.vtkStringArray_GetTuples_18(base.GetCppThis(), p1, p2, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x0601EB41 RID: 125761
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkStringArray_GetValue_19(HandleRef pThis, long id);

		/// <summary>
		/// Read-access of string at a particular index.
		/// </summary>
		// Token: 0x0601EB42 RID: 125762 RVA: 0x002B8AA8 File Offset: 0x002B6CA8
		public string GetValue(long id)
		{
			return vtkStringArray.vtkStringArray_GetValue_19(base.GetCppThis(), id);
		}

		// Token: 0x0601EB43 RID: 125763
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStringArray_GetVoidPointer_20(HandleRef pThis, long id);

		/// <summary>
		/// Get the address of a particular data index. Performs no checks
		/// to verify that the memory has been allocated etc.
		/// </summary>
		// Token: 0x0601EB44 RID: 125764 RVA: 0x002B8AC8 File Offset: 0x002B6CC8
		public override IntPtr GetVoidPointer(long id)
		{
			return vtkStringArray.vtkStringArray_GetVoidPointer_20(base.GetCppThis(), id);
		}

		// Token: 0x0601EB45 RID: 125765
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringArray_Initialize_21(HandleRef pThis);

		/// <summary>
		/// Release storage and reset array to initial state.
		/// </summary>
		// Token: 0x0601EB46 RID: 125766 RVA: 0x002B8AE8 File Offset: 0x002B6CE8
		public override void Initialize()
		{
			vtkStringArray.vtkStringArray_Initialize_21(base.GetCppThis());
		}

		// Token: 0x0601EB47 RID: 125767
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStringArray_InsertNextTuple_22(HandleRef pThis, long j, HandleRef source);

		/// <summary>
		/// Insert the jth tuple in the source array, at the end in this array.
		/// Note that memory allocation is performed as necessary to hold the data.
		/// Returns the location at which the data was inserted.
		/// </summary>
		// Token: 0x0601EB48 RID: 125768 RVA: 0x002B8AF8 File Offset: 0x002B6CF8
		public override long InsertNextTuple(long j, vtkAbstractArray source)
		{
			return vtkStringArray.vtkStringArray_InsertNextTuple_22(base.GetCppThis(), j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601EB49 RID: 125769
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStringArray_InsertNextValue_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string f);

		/// <summary>
		/// Insert data at the end of the array. Return its location in the array.
		/// </summary>
		// Token: 0x0601EB4A RID: 125770 RVA: 0x002B8B30 File Offset: 0x002B6D30
		public long InsertNextValue(string f)
		{
			return vtkStringArray.vtkStringArray_InsertNextValue_23(base.GetCppThis(), f);
		}

		// Token: 0x0601EB4B RID: 125771
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringArray_InsertTuple_24(HandleRef pThis, long i, long j, HandleRef source);

		/// <summary>
		/// Insert the jth tuple in the source array, at ith location in this array.
		/// Note that memory allocation is performed as necessary to hold the data.
		/// </summary>
		// Token: 0x0601EB4C RID: 125772 RVA: 0x002B8B50 File Offset: 0x002B6D50
		public override void InsertTuple(long i, long j, vtkAbstractArray source)
		{
			vtkStringArray.vtkStringArray_InsertTuple_24(base.GetCppThis(), i, j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601EB4D RID: 125773
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringArray_InsertTuples_25(HandleRef pThis, HandleRef dstIds, HandleRef srcIds, HandleRef source);

		/// <summary>
		/// Copy the tuples indexed in srcIds from the source array to the tuple
		/// locations indexed by dstIds in this array.
		/// Note that memory allocation is performed as necessary to hold the data.
		/// </summary>
		// Token: 0x0601EB4E RID: 125774 RVA: 0x002B8B84 File Offset: 0x002B6D84
		public override void InsertTuples(vtkIdList dstIds, vtkIdList srcIds, vtkAbstractArray source)
		{
			vtkStringArray.vtkStringArray_InsertTuples_25(base.GetCppThis(), (dstIds == null) ? default(HandleRef) : dstIds.GetCppThis(), (srcIds == null) ? default(HandleRef) : srcIds.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601EB4F RID: 125775
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringArray_InsertTuples_26(HandleRef pThis, long dstStart, long n, long srcStart, HandleRef source);

		/// <summary>
		/// Copy n consecutive tuples starting at srcStart from the source array to
		/// this array, starting at the dstStart location.
		/// Note that memory allocation is performed as necessary to hold the data.
		/// </summary>
		// Token: 0x0601EB50 RID: 125776 RVA: 0x002B8BE0 File Offset: 0x002B6DE0
		public override void InsertTuples(long dstStart, long n, long srcStart, vtkAbstractArray source)
		{
			vtkStringArray.vtkStringArray_InsertTuples_26(base.GetCppThis(), dstStart, n, srcStart, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601EB51 RID: 125777
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringArray_InsertTuplesStartingAt_27(HandleRef pThis, long dstStart, HandleRef srcIds, HandleRef source);

		/// <summary>
		/// Copy the tuples indexed in srcIds from the source array to the tuple
		/// locations indexed by dstIds in this array.
		/// Note that memory allocation is performed as necessary to hold the data.
		/// </summary>
		// Token: 0x0601EB52 RID: 125778 RVA: 0x002B8C14 File Offset: 0x002B6E14
		public override void InsertTuplesStartingAt(long dstStart, vtkIdList srcIds, vtkAbstractArray source)
		{
			vtkStringArray.vtkStringArray_InsertTuplesStartingAt_27(base.GetCppThis(), dstStart, (srcIds == null) ? default(HandleRef) : srcIds.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601EB53 RID: 125779
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringArray_InsertValue_28(HandleRef pThis, long id, [MarshalAs(UnmanagedType.LPUTF8Str)] string f);

		/// <summary>
		/// Insert data at a specified position in the array.
		/// </summary>
		// Token: 0x0601EB54 RID: 125780 RVA: 0x002B8C59 File Offset: 0x002B6E59
		public void InsertValue(long id, string f)
		{
			vtkStringArray.vtkStringArray_InsertValue_28(base.GetCppThis(), id, f);
		}

		// Token: 0x0601EB55 RID: 125781
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringArray_InsertVariantValue_29(HandleRef pThis, long idx, HandleRef value);

		/// <summary>
		/// Safely set a value in the array form a variant.
		/// Safely insert a value into the array from a variant.
		/// </summary>
		// Token: 0x0601EB56 RID: 125782 RVA: 0x002B8C6C File Offset: 0x002B6E6C
		public override void InsertVariantValue(long idx, vtkVariant value)
		{
			vtkStringArray.vtkStringArray_InsertVariantValue_29(base.GetCppThis(), idx, (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601EB57 RID: 125783
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringArray_InterpolateTuple_30(HandleRef pThis, long i, HandleRef ptIndices, HandleRef source, IntPtr weights);

		/// <summary>
		/// Set the ith tuple in this array as the interpolated tuple value,
		/// given the ptIndices in the source array and associated
		/// interpolation weights.
		/// This method assumes that the two arrays are of the same type
		/// and structure.
		/// </summary>
		// Token: 0x0601EB58 RID: 125784 RVA: 0x002B8C9C File Offset: 0x002B6E9C
		public override void InterpolateTuple(long i, vtkIdList ptIndices, vtkAbstractArray source, IntPtr weights)
		{
			vtkStringArray.vtkStringArray_InterpolateTuple_30(base.GetCppThis(), i, (ptIndices == null) ? default(HandleRef) : ptIndices.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis(), weights);
		}

		// Token: 0x0601EB59 RID: 125785
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringArray_InterpolateTuple_31(HandleRef pThis, long i, long id1, HandleRef source1, long id2, HandleRef source2, double t);

		/// <summary>
		/// Insert the ith tuple in this array as interpolated from the two values,
		/// p1 and p2, and an interpolation factor, t.
		/// The interpolation factor ranges from (0,1),
		/// with t=0 located at p1. This method assumes that the three arrays are of
		/// the same type. p1 is value at index id1 in source1, while, p2 is
		/// value at index id2 in source2.
		/// </summary>
		// Token: 0x0601EB5A RID: 125786 RVA: 0x002B8CE4 File Offset: 0x002B6EE4
		public override void InterpolateTuple(long i, long id1, vtkAbstractArray source1, long id2, vtkAbstractArray source2, double t)
		{
			vtkStringArray.vtkStringArray_InterpolateTuple_31(base.GetCppThis(), i, id1, (source1 == null) ? default(HandleRef) : source1.GetCppThis(), id2, (source2 == null) ? default(HandleRef) : source2.GetCppThis(), t);
		}

		// Token: 0x0601EB5B RID: 125787
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStringArray_IsA_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EB5C RID: 125788 RVA: 0x002B8D30 File Offset: 0x002B6F30
		public override int IsA(string type)
		{
			return vtkStringArray.vtkStringArray_IsA_32(base.GetCppThis(), type);
		}

		// Token: 0x0601EB5D RID: 125789
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStringArray_IsNumeric_33(HandleRef pThis);

		/// <summary>
		/// Get the data type.
		/// </summary>
		// Token: 0x0601EB5E RID: 125790 RVA: 0x002B8D50 File Offset: 0x002B6F50
		public override int IsNumeric()
		{
			return vtkStringArray.vtkStringArray_IsNumeric_33(base.GetCppThis());
		}

		// Token: 0x0601EB5F RID: 125791
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStringArray_IsTypeOf_34([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EB60 RID: 125792 RVA: 0x002B8D70 File Offset: 0x002B6F70
		public new static int IsTypeOf(string type)
		{
			return vtkStringArray.vtkStringArray_IsTypeOf_34(type);
		}

		// Token: 0x0601EB61 RID: 125793
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStringArray_LookupValue_35(HandleRef pThis, HandleRef value);

		/// <summary>
		/// Return the indices where a specific value appears.
		/// </summary>
		// Token: 0x0601EB62 RID: 125794 RVA: 0x002B8D8C File Offset: 0x002B6F8C
		public override long LookupValue(vtkVariant value)
		{
			return vtkStringArray.vtkStringArray_LookupValue_35(base.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601EB63 RID: 125795
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringArray_LookupValue_36(HandleRef pThis, HandleRef value, HandleRef ids);

		/// <summary>
		/// Return the indices where a specific value appears.
		/// </summary>
		// Token: 0x0601EB64 RID: 125796 RVA: 0x002B8DC0 File Offset: 0x002B6FC0
		public override void LookupValue(vtkVariant value, vtkIdList ids)
		{
			vtkStringArray.vtkStringArray_LookupValue_36(base.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis(), (ids == null) ? default(HandleRef) : ids.GetCppThis());
		}

		// Token: 0x0601EB65 RID: 125797
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStringArray_LookupValue_37(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string value);

		/// <summary>
		/// Return the indices where a specific value appears.
		/// </summary>
		// Token: 0x0601EB66 RID: 125798 RVA: 0x002B8E04 File Offset: 0x002B7004
		public long LookupValue(string value)
		{
			return vtkStringArray.vtkStringArray_LookupValue_37(base.GetCppThis(), value);
		}

		// Token: 0x0601EB67 RID: 125799
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringArray_LookupValue_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string value, HandleRef ids);

		/// <summary>
		/// Return the indices where a specific value appears.
		/// </summary>
		// Token: 0x0601EB68 RID: 125800 RVA: 0x002B8E24 File Offset: 0x002B7024
		public void LookupValue(string value, vtkIdList ids)
		{
			vtkStringArray.vtkStringArray_LookupValue_38(base.GetCppThis(), value, (ids == null) ? default(HandleRef) : ids.GetCppThis());
		}

		// Token: 0x0601EB69 RID: 125801
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStringArray_NewInstance_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EB6A RID: 125802 RVA: 0x002B8E54 File Offset: 0x002B7054
		public new vtkStringArray NewInstance()
		{
			vtkStringArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStringArray.vtkStringArray_NewInstance_40(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601EB6B RID: 125803
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStringArray_NewIterator_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns a vtkArrayIteratorTemplate&lt;vtkStdString&gt;.
		/// </summary>
		// Token: 0x0601EB6C RID: 125804 RVA: 0x002B8EB0 File Offset: 0x002B70B0
		public override vtkArrayIterator NewIterator()
		{
			vtkArrayIterator vtkArrayIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStringArray.vtkStringArray_NewIterator_41(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601EB6D RID: 125805
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStringArray_Resize_42(HandleRef pThis, long numTuples);

		/// <summary>
		/// Resize the array while conserving the data.
		/// </summary>
		// Token: 0x0601EB6E RID: 125806 RVA: 0x002B8F20 File Offset: 0x002B7120
		public override int Resize(long numTuples)
		{
			return vtkStringArray.vtkStringArray_Resize_42(base.GetCppThis(), numTuples);
		}

		// Token: 0x0601EB6F RID: 125807
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStringArray_SafeDownCast_43(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EB70 RID: 125808 RVA: 0x002B8F40 File Offset: 0x002B7140
		public new static vtkStringArray SafeDownCast(vtkObjectBase o)
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStringArray.vtkStringArray_SafeDownCast_43((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601EB71 RID: 125809
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringArray_SetArray_44(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string array, long size, int save, int deleteMethod);

		/// <summary>
		/// This method lets the user specify data to be held by the array.  The
		/// array argument is a pointer to the data.  size is the size of
		/// the array supplied by the user.  Set save to 1 to keep the class
		/// from deleting the array when it cleans up or reallocates memory.
		/// The class uses the actual array provided; it does not copy the data
		/// from the supplied array. If save is 0, then this class is free to delete
		/// the array when it cleans up or reallocates using the provided free function
		/// If the delete method is VTK_DATA_ARRAY_USER_DEFINED
		/// a custom free function can be assigned to be called using SetArrayFreeFunction,
		/// if no custom function is assigned we will default to delete[].
		/// </summary>
		// Token: 0x0601EB72 RID: 125810 RVA: 0x002B8FBF File Offset: 0x002B71BF
		public void SetArray(string array, long size, int save, int deleteMethod)
		{
			vtkStringArray.vtkStringArray_SetArray_44(base.GetCppThis(), array, size, save, deleteMethod);
		}

		// Token: 0x0601EB73 RID: 125811
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringArray_SetNumberOfTuples_45(HandleRef pThis, long number);

		/// <summary>
		/// Set the number of tuples (a component group) in the array. Note that
		/// this may allocate space depending on the number of components.
		/// </summary>
		// Token: 0x0601EB74 RID: 125812 RVA: 0x002B8FD3 File Offset: 0x002B71D3
		public override void SetNumberOfTuples(long number)
		{
			vtkStringArray.vtkStringArray_SetNumberOfTuples_45(base.GetCppThis(), number);
		}

		// Token: 0x0601EB75 RID: 125813
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringArray_SetTuple_46(HandleRef pThis, long i, long j, HandleRef source);

		/// <summary>
		/// Set the tuple at the ith location using the jth tuple in the source array.
		/// This method assumes that the two arrays have the same type
		/// and structure. Note that range checking and memory allocation is not
		/// performed; use in conjunction with SetNumberOfTuples() to allocate space.
		/// </summary>
		// Token: 0x0601EB76 RID: 125814 RVA: 0x002B8FE4 File Offset: 0x002B71E4
		public override void SetTuple(long i, long j, vtkAbstractArray source)
		{
			vtkStringArray.vtkStringArray_SetTuple_46(base.GetCppThis(), i, j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601EB77 RID: 125815
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringArray_SetValue_47(HandleRef pThis, long id, [MarshalAs(UnmanagedType.LPUTF8Str)] string value);

		/// <summary>
		/// Set the data at a particular index. Does not do range checking. Make sure
		/// you use the method SetNumberOfValues() before inserting data.
		/// </summary>
		// Token: 0x0601EB78 RID: 125816 RVA: 0x002B9015 File Offset: 0x002B7215
		public void SetValue(long id, string value)
		{
			vtkStringArray.vtkStringArray_SetValue_47(base.GetCppThis(), id, value);
		}

		// Token: 0x0601EB79 RID: 125817
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringArray_SetVariantValue_48(HandleRef pThis, long idx, HandleRef value);

		/// <summary>
		/// Set a value in the array form a variant.
		/// Insert a value into the array from a variant.
		/// </summary>
		// Token: 0x0601EB7A RID: 125818 RVA: 0x002B9028 File Offset: 0x002B7228
		public override void SetVariantValue(long idx, vtkVariant value)
		{
			vtkStringArray.vtkStringArray_SetVariantValue_48(base.GetCppThis(), idx, (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601EB7B RID: 125819
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringArray_SetVoidArray_49(HandleRef pThis, IntPtr array, long size, int save);

		/// <summary>
		/// This method lets the user specify data to be held by the array.  The
		/// array argument is a pointer to the data.  size is the size of
		/// the array supplied by the user.  Set save to 1 to keep the class
		/// from deleting the array when it cleans up or reallocates memory.
		/// The class uses the actual array provided; it does not copy the data
		/// from the supplied array. If save is 0, then this class is free to delete
		/// the array when it cleans up or reallocates using the provided free function
		/// If the delete method is VTK_DATA_ARRAY_USER_DEFINED
		/// a custom free function can be assigned to be called using SetArrayFreeFunction,
		/// if no custom function is assigned we will default to delete[].
		/// </summary>
		// Token: 0x0601EB7C RID: 125820 RVA: 0x002B9058 File Offset: 0x002B7258
		public override void SetVoidArray(IntPtr array, long size, int save)
		{
			vtkStringArray.vtkStringArray_SetVoidArray_49(base.GetCppThis(), array, size, save);
		}

		// Token: 0x0601EB7D RID: 125821
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringArray_SetVoidArray_50(HandleRef pThis, IntPtr array, long size, int save, int deleteMethod);

		/// <summary>
		/// This method lets the user specify data to be held by the array.  The
		/// array argument is a pointer to the data.  size is the size of
		/// the array supplied by the user.  Set save to 1 to keep the class
		/// from deleting the array when it cleans up or reallocates memory.
		/// The class uses the actual array provided; it does not copy the data
		/// from the supplied array. If save is 0, then this class is free to delete
		/// the array when it cleans up or reallocates using the provided free function
		/// If the delete method is VTK_DATA_ARRAY_USER_DEFINED
		/// a custom free function can be assigned to be called using SetArrayFreeFunction,
		/// if no custom function is assigned we will default to delete[].
		/// </summary>
		// Token: 0x0601EB7E RID: 125822 RVA: 0x002B906A File Offset: 0x002B726A
		public override void SetVoidArray(IntPtr array, long size, int save, int deleteMethod)
		{
			vtkStringArray.vtkStringArray_SetVoidArray_50(base.GetCppThis(), array, size, save, deleteMethod);
		}

		// Token: 0x0601EB7F RID: 125823
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringArray_Squeeze_51(HandleRef pThis);

		/// <summary>
		/// Free any unnecessary memory.
		/// Resize object to just fit data requirement. Reclaims extra memory.
		/// </summary>
		// Token: 0x0601EB80 RID: 125824 RVA: 0x002B907E File Offset: 0x002B727E
		public override void Squeeze()
		{
			vtkStringArray.vtkStringArray_Squeeze_51(base.GetCppThis());
		}

		// Token: 0x0601EB81 RID: 125825
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStringArray_WritePointer_52(HandleRef pThis, long id, long number, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the address of a particular data index. Make sure data is allocated
		/// for the number of items requested. Set MaxId according to the number of
		/// data values requested.
		/// </summary>
		// Token: 0x0601EB82 RID: 125826 RVA: 0x002B9090 File Offset: 0x002B7290
		public string WritePointer(long id, long number)
		{
			string result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStringArray.vtkStringArray_WritePointer_52(base.GetCppThis(), id, number, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (string)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, false, out flag);
			}
			return result;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020DE RID: 8414
		public new const string MRFullTypeName = "Kitware.VTK.vtkStringArray";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020DF RID: 8415
		public new static readonly string MRClassNameKey = "class vtkStringArray";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000B7E RID: 2942
		public new enum DeleteMethod
		{
			/// <summary>enum member</summary>
			// Token: 0x040020E1 RID: 8417
			VTK_DATA_ARRAY_ALIGNED_FREE = 2,
			/// <summary>enum member</summary>
			// Token: 0x040020E2 RID: 8418
			VTK_DATA_ARRAY_DELETE = 1,
			/// <summary>enum member</summary>
			// Token: 0x040020E3 RID: 8419
			VTK_DATA_ARRAY_FREE = 0,
			/// <summary>enum member</summary>
			// Token: 0x040020E4 RID: 8420
			VTK_DATA_ARRAY_USER_DEFINED = 3
		}
	}
}
