using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAbstractArray
	/// </summary>
	/// <remarks>
	///    Abstract superclass for all arrays
	///
	///
	///
	/// vtkAbstractArray is an abstract superclass for data array objects.
	/// This class defines an API that all subclasses must support.  The
	/// data type must be assignable and copy-constructible, but no other
	/// assumptions about its type are made.  Most of the subclasses of
	/// this array deal with numeric data either as scalars or tuples of
	/// scalars.  A program can use the IsNumeric() method to check whether
	/// an instance of vtkAbstractArray contains numbers.  It is also
	/// possible to test for this by attempting to SafeDownCast an array to
	/// an instance of vtkDataArray, although this assumes that all numeric
	/// arrays will always be descended from vtkDataArray.
	///
	/// &lt;p&gt;
	///
	/// Every array has a character-string name. The naming of the array
	/// occurs automatically when it is instantiated, but you are free to
	/// change this name using the SetName() method.  (The array name is
	/// used for data manipulation.)
	///
	/// This class (and subclasses) use two forms of addressing elements:
	/// - Value Indexing: The index of an element assuming an array-of-structs
	///   memory layout.
	/// - Tuple/Component Indexing: Explicitly specify the tuple and component
	///   indices.
	///
	/// It is also worth pointing out that the behavior of the "Insert*" methods
	/// of classes in this hierarchy may not behave as expected. They work exactly
	/// as the corresponding "Set*" methods, except that memory allocation will
	/// be performed if acting on a value past the end of the array. If the data
	/// already exists, "inserting" will overwrite existing values, rather than shift
	/// the array contents and insert the new data at the specified location.
	///
	/// If code is modifying contents of an existing array, it is
	/// required that one calls `vtkAbstractArray::Modified()` explicitly
	/// after the modifications to the contents are completed.
	/// APIs like `SetTuple` etc. don't call `Modified` to avoid performance hits.
	/// Unless `Modified` is called, various cached entities, like array range,
	/// map created for `LookupValue` may become obsolete and yield incorrect results.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDataArray vtkStringArray vtkCellArray
	/// </seealso>
	// Token: 0x02000B24 RID: 2852
	public abstract class vtkAbstractArray : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601DE76 RID: 122486 RVA: 0x002A390F File Offset: 0x002A1B0F
		static vtkAbstractArray()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractArray"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601DE77 RID: 122487 RVA: 0x002A3937 File Offset: 0x002A1B37
		public vtkAbstractArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601DE78 RID: 122488 RVA: 0x002A3945 File Offset: 0x002A1B45
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601DE79 RID: 122489
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractArray_Allocate_01(HandleRef pThis, long numValues, long ext);

		/// <summary>
		/// Allocate memory for this array. Delete old storage only if necessary.
		/// Note that ext is no longer used.
		/// This method will reset MaxId to -1 and resize the array capacity such that
		/// this-&gt;Size &gt;= numValues.
		/// If numValues is 0, all memory will be freed.
		/// Return 1 on success, 0 on failure.
		/// </summary>
		// Token: 0x0601DE7A RID: 122490 RVA: 0x002A3950 File Offset: 0x002A1B50
		public virtual int Allocate(long numValues, long ext)
		{
			return vtkAbstractArray.vtkAbstractArray_Allocate_01(base.GetCppThis(), numValues, ext);
		}

		// Token: 0x0601DE7B RID: 122491
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractArray_ClearLookup_02(HandleRef pThis);

		/// <summary>
		/// Delete the associated fast lookup data structure on this array,
		/// if it exists.  The lookup will be rebuilt on the next call to a lookup
		/// function.
		/// </summary>
		// Token: 0x0601DE7C RID: 122492 RVA: 0x002A3971 File Offset: 0x002A1B71
		public virtual void ClearLookup()
		{
			vtkAbstractArray.vtkAbstractArray_ClearLookup_02(base.GetCppThis());
		}

		// Token: 0x0601DE7D RID: 122493
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractArray_CopyComponentNames_03(HandleRef pThis, HandleRef da);

		/// <summary>
		/// Copies the component names from the inputted array to the current array
		/// make sure that the current array has the same number of components as the input array
		/// </summary>
		// Token: 0x0601DE7E RID: 122494 RVA: 0x002A3980 File Offset: 0x002A1B80
		public int CopyComponentNames(vtkAbstractArray da)
		{
			return vtkAbstractArray.vtkAbstractArray_CopyComponentNames_03(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		// Token: 0x0601DE7F RID: 122495
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractArray_CopyInformation_04(HandleRef pThis, HandleRef infoFrom, int deep);

		/// <summary>
		/// Copy information instance. Arrays use information objects
		/// in a variety of ways. It is important to have flexibility in
		/// this regard because certain keys should not be copied, while
		/// others must be.
		///
		/// NOTE: Subclasses must always call their superclass's CopyInformation
		/// method, so that all classes in the hierarchy get a chance to remove
		/// keys they do not wish to be copied. The subclass will not need to
		/// explicitly copy the keys as it's handled here.
		/// </summary>
		// Token: 0x0601DE80 RID: 122496 RVA: 0x002A39B4 File Offset: 0x002A1BB4
		public virtual int CopyInformation(vtkInformation infoFrom, int deep)
		{
			return vtkAbstractArray.vtkAbstractArray_CopyInformation_04(base.GetCppThis(), (infoFrom == null) ? default(HandleRef) : infoFrom.GetCppThis(), deep);
		}

		// Token: 0x0601DE81 RID: 122497
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractArray_CreateArray_05(int dataType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates an array for dataType where dataType is one of
		/// VTK_BIT, VTK_CHAR, VTK_UNSIGNED_CHAR, VTK_SHORT,
		/// VTK_UNSIGNED_SHORT, VTK_INT, VTK_UNSIGNED_INT, VTK_LONG,
		/// VTK_UNSIGNED_LONG, VTK_FLOAT, VTK_DOUBLE, VTK_ID_TYPE,
		/// VTK_STRING.
		/// Note that the data array returned has to be deleted by the
		/// user.
		/// </summary>
		// Token: 0x0601DE82 RID: 122498 RVA: 0x002A39EC File Offset: 0x002A1BEC
		public static vtkAbstractArray CreateArray(int dataType)
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractArray.vtkAbstractArray_CreateArray_05(dataType, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractArray = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractArray.Register(null);
				}
			}
			return vtkAbstractArray;
		}

		// Token: 0x0601DE83 RID: 122499
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractArray_DISCRETE_VALUES_06(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// A key used to hold discrete values taken on either by the tuples of the
		/// array (when present in this-&gt;GetInformation()) or individual components
		/// (when present in one entry of the PER_COMPONENT() information vector).
		/// </summary>
		// Token: 0x0601DE84 RID: 122500 RVA: 0x002A3A58 File Offset: 0x002A1C58
		public static vtkInformationVariantVectorKey DISCRETE_VALUES()
		{
			vtkInformationVariantVectorKey vtkInformationVariantVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractArray.vtkAbstractArray_DISCRETE_VALUES_06(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationVariantVectorKey = (vtkInformationVariantVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationVariantVectorKey.Register(null);
				}
			}
			return vtkInformationVariantVectorKey;
		}

		// Token: 0x0601DE85 RID: 122501
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractArray_DISCRETE_VALUE_SAMPLE_PARAMETERS_07(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// A key used to hold conditions under which cached discrete values were generated;
		/// the value is a 2-vector of doubles.
		/// The first entry corresponds to the maximum uncertainty that prominent values
		/// exist but have not been detected. The second entry corresponds to the smallest
		/// relative frequency a value is allowed to have and still appear on the list.
		/// </summary>
		// Token: 0x0601DE86 RID: 122502 RVA: 0x002A3AC4 File Offset: 0x002A1CC4
		public static vtkInformationDoubleVectorKey DISCRETE_VALUE_SAMPLE_PARAMETERS()
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractArray.vtkAbstractArray_DISCRETE_VALUE_SAMPLE_PARAMETERS_07(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleVectorKey = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleVectorKey.Register(null);
				}
			}
			return vtkInformationDoubleVectorKey;
		}

		// Token: 0x0601DE87 RID: 122503
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractArray_DataChanged_08(HandleRef pThis);

		/// <summary>
		/// Tell the array explicitly that the data has changed.
		/// This is only necessary to call when you modify the array contents
		/// without using the array's API (i.e. you retrieve a pointer to the
		/// data and modify the array contents).  You need to call this so that
		/// the fast lookup will know to rebuild itself.  Otherwise, the lookup
		/// functions will give incorrect results.
		/// </summary>
		// Token: 0x0601DE88 RID: 122504 RVA: 0x002A3B2D File Offset: 0x002A1D2D
		public virtual void DataChanged()
		{
			vtkAbstractArray.vtkAbstractArray_DataChanged_08(base.GetCppThis());
		}

		// Token: 0x0601DE89 RID: 122505
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractArray_DeepCopy_09(HandleRef pThis, HandleRef da);

		/// <summary>
		/// Deep copy of data. Implementation left to subclasses, which
		/// should support as many type conversions as possible given the
		/// data type.
		///
		/// Subclasses should call vtkAbstractArray::DeepCopy() so that the
		/// information object (if one exists) is copied from \a da.
		/// </summary>
		// Token: 0x0601DE8A RID: 122506 RVA: 0x002A3B3C File Offset: 0x002A1D3C
		public virtual void DeepCopy(vtkAbstractArray da)
		{
			vtkAbstractArray.vtkAbstractArray_DeepCopy_09(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		// Token: 0x0601DE8B RID: 122507
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractArray_ExportToVoidPointer_10(HandleRef pThis, IntPtr out_ptr);

		/// <summary>
		/// This method copies the array data to the void pointer specified
		/// by the user.  It is up to the user to allocate enough memory for
		/// the void pointer.
		/// </summary>
		// Token: 0x0601DE8C RID: 122508 RVA: 0x002A3B6B File Offset: 0x002A1D6B
		public virtual void ExportToVoidPointer(IntPtr out_ptr)
		{
			vtkAbstractArray.vtkAbstractArray_ExportToVoidPointer_10(base.GetCppThis(), out_ptr);
		}

		// Token: 0x0601DE8D RID: 122509
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractArray_GUI_HIDE_11(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This key is a hint to end user interface that this array
		/// is internal and should not be shown to the end user.
		/// </summary>
		// Token: 0x0601DE8E RID: 122510 RVA: 0x002A3B7C File Offset: 0x002A1D7C
		public static vtkInformationIntegerKey GUI_HIDE()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractArray.vtkAbstractArray_GUI_HIDE_11(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x0601DE8F RID: 122511
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkAbstractArray_GetActualMemorySize_12(HandleRef pThis);

		/// <summary>
		/// Return the memory in kibibytes (1024 bytes) consumed by this data array. Used to
		/// support streaming and reading/writing data. The value returned is
		/// guaranteed to be greater than or equal to the memory required to
		/// actually represent the data represented by this object. The
		/// information returned is valid only after the pipeline has
		/// been updated.
		/// </summary>
		// Token: 0x0601DE90 RID: 122512 RVA: 0x002A3BE8 File Offset: 0x002A1DE8
		public virtual uint GetActualMemorySize()
		{
			return vtkAbstractArray.vtkAbstractArray_GetActualMemorySize_12(base.GetCppThis());
		}

		// Token: 0x0601DE91 RID: 122513
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractArray_GetArrayType_13(HandleRef pThis);

		/// <summary>
		/// Method for type-checking in FastDownCast implementations. See also
		/// vtkArrayDownCast.
		/// </summary>
		// Token: 0x0601DE92 RID: 122514 RVA: 0x002A3C08 File Offset: 0x002A1E08
		public virtual int GetArrayType()
		{
			return vtkAbstractArray.vtkAbstractArray_GetArrayType_13(base.GetCppThis());
		}

		// Token: 0x0601DE93 RID: 122515
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractArray_GetArrayTypeAsString_14(HandleRef pThis);

		/// <summary>
		/// Get the name for the array type as string
		/// </summary>
		// Token: 0x0601DE94 RID: 122516 RVA: 0x002A3C28 File Offset: 0x002A1E28
		public string GetArrayTypeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkAbstractArray.vtkAbstractArray_GetArrayTypeAsString_14(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601DE95 RID: 122517
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractArray_GetComponentName_15(HandleRef pThis, long component);

		/// <summary>
		/// Get the component name for a given component.
		/// Note: will return the actual string that is stored
		/// </summary>
		// Token: 0x0601DE96 RID: 122518 RVA: 0x002A3C64 File Offset: 0x002A1E64
		public string GetComponentName(long component)
		{
			string s = Marshal.PtrToStringAnsi(vtkAbstractArray.vtkAbstractArray_GetComponentName_15(base.GetCppThis(), component));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601DE97 RID: 122519
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractArray_GetDataSize_16(HandleRef pThis);

		/// <summary>
		/// Returns the size of the data in DataTypeSize units. Thus, the
		/// number of bytes for the data can be computed by GetDataSize() *
		/// GetDataTypeSize(). Non-contiguous or variable- size arrays need
		/// to override this method.
		/// </summary>
		// Token: 0x0601DE98 RID: 122520 RVA: 0x002A3CA0 File Offset: 0x002A1EA0
		public virtual long GetDataSize()
		{
			return vtkAbstractArray.vtkAbstractArray_GetDataSize_16(base.GetCppThis());
		}

		// Token: 0x0601DE99 RID: 122521
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractArray_GetDataType_17(HandleRef pThis);

		/// <summary>
		/// Return the underlying data type. An integer indicating data type is
		/// returned as specified in vtkType.h.
		/// </summary>
		// Token: 0x0601DE9A RID: 122522 RVA: 0x002A3CC0 File Offset: 0x002A1EC0
		public virtual int GetDataType()
		{
			return vtkAbstractArray.vtkAbstractArray_GetDataType_17(base.GetCppThis());
		}

		// Token: 0x0601DE9B RID: 122523
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractArray_GetDataTypeAsString_18(HandleRef pThis);

		/// <summary>
		/// Get the name of a data type as a string.
		/// </summary>
		// Token: 0x0601DE9C RID: 122524 RVA: 0x002A3CE0 File Offset: 0x002A1EE0
		public virtual string GetDataTypeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkAbstractArray.vtkAbstractArray_GetDataTypeAsString_18(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601DE9D RID: 122525
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractArray_GetDataTypeSize_19(HandleRef pThis);

		/// <summary>
		/// Return the size of the underlying data type.  For a bit, 0 is
		/// returned.  For string 0 is returned. Arrays with variable length
		/// components return 0.
		/// </summary>
		// Token: 0x0601DE9E RID: 122526 RVA: 0x002A3D1C File Offset: 0x002A1F1C
		public virtual int GetDataTypeSize()
		{
			return vtkAbstractArray.vtkAbstractArray_GetDataTypeSize_19(base.GetCppThis());
		}

		// Token: 0x0601DE9F RID: 122527
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractArray_GetDataTypeSize_20(int type);

		/// <summary>
		/// Return the size of the underlying data type.  For a bit, 0 is
		/// returned.  For string 0 is returned. Arrays with variable length
		/// components return 0.
		/// </summary>
		// Token: 0x0601DEA0 RID: 122528 RVA: 0x002A3D3C File Offset: 0x002A1F3C
		public static int GetDataTypeSize(int type)
		{
			return vtkAbstractArray.vtkAbstractArray_GetDataTypeSize_20(type);
		}

		// Token: 0x0601DEA1 RID: 122529
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractArray_GetElementComponentSize_21(HandleRef pThis);

		/// <summary>
		/// Return the size, in bytes, of the lowest-level element of an
		/// array.  For vtkDataArray and subclasses this is the size of the
		/// data type.  For vtkStringArray, this is
		/// sizeof(vtkStdString::value_type), which winds up being
		/// sizeof(char).
		/// </summary>
		// Token: 0x0601DEA2 RID: 122530 RVA: 0x002A3D58 File Offset: 0x002A1F58
		public virtual int GetElementComponentSize()
		{
			return vtkAbstractArray.vtkAbstractArray_GetElementComponentSize_21(base.GetCppThis());
		}

		// Token: 0x0601DEA3 RID: 122531
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractArray_GetInformation_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get an information object that can be used to annotate the array.
		/// This will always return an instance of vtkInformation, if one is
		/// not currently associated with the array it will be created.
		/// </summary>
		// Token: 0x0601DEA4 RID: 122532 RVA: 0x002A3D78 File Offset: 0x002A1F78
		public vtkInformation GetInformation()
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractArray.vtkAbstractArray_GetInformation_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		// Token: 0x0601DEA5 RID: 122533
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkAbstractArray_GetMaxDiscreteValues_23(HandleRef pThis);

		/// <summary>
		/// Get/Set the maximum number of prominent values this array may contain
		/// before it is considered continuous.  Default value is 32.
		/// </summary>
		// Token: 0x0601DEA6 RID: 122534 RVA: 0x002A3DE8 File Offset: 0x002A1FE8
		public virtual uint GetMaxDiscreteValues()
		{
			return vtkAbstractArray.vtkAbstractArray_GetMaxDiscreteValues_23(base.GetCppThis());
		}

		// Token: 0x0601DEA7 RID: 122535
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractArray_GetMaxId_24(HandleRef pThis);

		/// <summary>
		/// What is the maximum id currently in the array.
		/// </summary>
		// Token: 0x0601DEA8 RID: 122536 RVA: 0x002A3E08 File Offset: 0x002A2008
		public long GetMaxId()
		{
			return vtkAbstractArray.vtkAbstractArray_GetMaxId_24(base.GetCppThis());
		}

		// Token: 0x0601DEA9 RID: 122537
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractArray_GetName_25(HandleRef pThis);

		/// <summary>
		/// Set/get array's name
		/// </summary>
		// Token: 0x0601DEAA RID: 122538 RVA: 0x002A3E28 File Offset: 0x002A2028
		public virtual string GetName()
		{
			string s = Marshal.PtrToStringAnsi(vtkAbstractArray.vtkAbstractArray_GetName_25(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601DEAB RID: 122539
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractArray_GetNumberOfComponents_26(HandleRef pThis);

		/// <summary>
		/// Set/Get the dimension (n) of the components. Must be &gt;= 1. Make sure that
		/// this is set before allocation.
		/// </summary>
		// Token: 0x0601DEAC RID: 122540 RVA: 0x002A3E64 File Offset: 0x002A2064
		public int GetNumberOfComponents()
		{
			return vtkAbstractArray.vtkAbstractArray_GetNumberOfComponents_26(base.GetCppThis());
		}

		// Token: 0x0601DEAD RID: 122541
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractArray_GetNumberOfComponentsMaxValue_27(HandleRef pThis);

		/// <summary>
		/// Set/Get the dimension (n) of the components. Must be &gt;= 1. Make sure that
		/// this is set before allocation.
		/// </summary>
		// Token: 0x0601DEAE RID: 122542 RVA: 0x002A3E84 File Offset: 0x002A2084
		public virtual int GetNumberOfComponentsMaxValue()
		{
			return vtkAbstractArray.vtkAbstractArray_GetNumberOfComponentsMaxValue_27(base.GetCppThis());
		}

		// Token: 0x0601DEAF RID: 122543
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractArray_GetNumberOfComponentsMinValue_28(HandleRef pThis);

		/// <summary>
		/// Set/Get the dimension (n) of the components. Must be &gt;= 1. Make sure that
		/// this is set before allocation.
		/// </summary>
		// Token: 0x0601DEB0 RID: 122544 RVA: 0x002A3EA4 File Offset: 0x002A20A4
		public virtual int GetNumberOfComponentsMinValue()
		{
			return vtkAbstractArray.vtkAbstractArray_GetNumberOfComponentsMinValue_28(base.GetCppThis());
		}

		// Token: 0x0601DEB1 RID: 122545
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractArray_GetNumberOfGenerationsFromBase_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DEB2 RID: 122546 RVA: 0x002A3EC4 File Offset: 0x002A20C4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAbstractArray.vtkAbstractArray_GetNumberOfGenerationsFromBase_29(base.GetCppThis(), type);
		}

		// Token: 0x0601DEB3 RID: 122547
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractArray_GetNumberOfGenerationsFromBaseType_30([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DEB4 RID: 122548 RVA: 0x002A3EE4 File Offset: 0x002A20E4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAbstractArray.vtkAbstractArray_GetNumberOfGenerationsFromBaseType_30(type);
		}

		// Token: 0x0601DEB5 RID: 122549
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractArray_GetNumberOfTuples_31(HandleRef pThis);

		/// <summary>
		/// Get the number of complete tuples (a component group) in the array.
		/// </summary>
		// Token: 0x0601DEB6 RID: 122550 RVA: 0x002A3F00 File Offset: 0x002A2100
		public long GetNumberOfTuples()
		{
			return vtkAbstractArray.vtkAbstractArray_GetNumberOfTuples_31(base.GetCppThis());
		}

		// Token: 0x0601DEB7 RID: 122551
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractArray_GetNumberOfValues_32(HandleRef pThis);

		/// <summary>
		/// Get the total number of values in the array. This is typically equivalent
		/// to (numTuples * numComponents). The exception is during incremental array
		/// construction for subclasses that support component insertion, which may
		/// result in an incomplete trailing tuple.
		/// </summary>
		// Token: 0x0601DEB8 RID: 122552 RVA: 0x002A3F20 File Offset: 0x002A2120
		public long GetNumberOfValues()
		{
			return vtkAbstractArray.vtkAbstractArray_GetNumberOfValues_32(base.GetCppThis());
		}

		// Token: 0x0601DEB9 RID: 122553
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractArray_GetProminentComponentValues_33(HandleRef pThis, int comp, HandleRef values, double uncertainty, double minimumProminence);

		/// <summary>
		/// Populate the given vtkVariantArray with a set of distinct values taken on
		/// by the requested component (or, when passed -1, by the tuples as a whole).
		/// If the set of prominent values has more than 32 entries, then the array
		/// is assumed to be continuous in nature and no values are returned.
		///
		/// This method takes 2 parameters: \a uncertainty and \a minimumProminence.
		/// Note that this set of returned values may not be complete if
		/// \a uncertainty and \a minimumProminence are both larger than 0.0;
		/// in order to perform interactively, a subsample of the array is
		/// used to determine the set of values.
		///
		/// The first parameter (\a uncertainty, U) is the maximum acceptable
		/// probability that a prominent value will not be detected.
		/// Setting this to 0 will cause every value in the array to be examined.
		///
		/// The second parameter (\a minimumProminence, P) specifies the smallest
		/// relative frequency (in [0,1]) with which a value in the array may
		/// occur and still be considered prominent. Setting this to 0
		/// will force every value in the array to be traversed.
		/// Using numbers close to 0 for this parameter quickly causes
		/// the number of samples required to obtain the given uncertainty to
		/// subsume the entire array, as rare occurrences require frequent
		/// sampling to detect.
		///
		/// For an array with T tuples and given uncertainty U and mininumum
		/// prominence P, we sample N values, with N = f(T; P, U).
		/// We want f to be sublinear in T in order to interactively handle large
		/// arrays; in practice, we can make f independent of T:
		/// \f$ N &gt;= \frac{5}{P}\mathrm{ln}\left(\frac{1}{PU}\right) \f$,
		/// but note that small values of P are costly to achieve.
		/// The default parameters will locate prominent values that occur at least
		/// 1 out of every 1000 samples with a confidence of 0.999999 (= 1 - 1e6).
		/// Thanks to Seshadri Comandur (Sandia National Laboratories) for the
		/// bounds on the number of samples.
		///
		/// The first time this is called, the array is examined and unique values
		/// are stored in the vtkInformation object associated with the array.
		/// The list of unique values will be updated on subsequent calls only if
		/// the array's MTime is newer than the associated vtkInformation object or
		/// if better sampling (lower \a uncertainty or \a minimumProminence) is
		/// requested.
		/// The DISCRETE_VALUE_SAMPLE_PARAMETERS() information key is used to
		/// store the numbers which produced any current set of prominent values.
		///
		/// Also, note that every value encountered is reported and counts toward
		/// the maximum of 32 distinct values, regardless of the value's frequency.
		/// This is required for an efficient implementation.
		/// Use the vtkOrderStatistics filter if you wish to threshold the set of
		/// distinct values to eliminate "unprominent" (infrequently-occurring)
		/// values.
		/// </summary>
		// Token: 0x0601DEBA RID: 122554 RVA: 0x002A3F40 File Offset: 0x002A2140
		public virtual void GetProminentComponentValues(int comp, vtkVariantArray values, double uncertainty, double minimumProminence)
		{
			vtkAbstractArray.vtkAbstractArray_GetProminentComponentValues_33(base.GetCppThis(), comp, (values == null) ? default(HandleRef) : values.GetCppThis(), uncertainty, minimumProminence);
		}

		// Token: 0x0601DEBB RID: 122555
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractArray_GetSize_34(HandleRef pThis);

		/// <summary>
		/// Return the size of the data.
		/// </summary>
		// Token: 0x0601DEBC RID: 122556 RVA: 0x002A3F74 File Offset: 0x002A2174
		public long GetSize()
		{
			return vtkAbstractArray.vtkAbstractArray_GetSize_34(base.GetCppThis());
		}

		// Token: 0x0601DEBD RID: 122557
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractArray_GetTuples_35(HandleRef pThis, HandleRef tupleIds, HandleRef output);

		/// <summary>
		/// Given a list of tuple ids, return an array of tuples.
		/// You must ensure that the output array has been previously
		/// allocated with enough space to hold the data.
		/// </summary>
		// Token: 0x0601DEBE RID: 122558 RVA: 0x002A3F94 File Offset: 0x002A2194
		public virtual void GetTuples(vtkIdList tupleIds, vtkAbstractArray output)
		{
			vtkAbstractArray.vtkAbstractArray_GetTuples_35(base.GetCppThis(), (tupleIds == null) ? default(HandleRef) : tupleIds.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x0601DEBF RID: 122559
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractArray_GetTuples_36(HandleRef pThis, long p1, long p2, HandleRef output);

		/// <summary>
		/// Get the tuples for the range of tuple ids specified
		/// (i.e., p1-&gt;p2 inclusive). You must ensure that the output array has
		/// been previously allocated with enough space to hold the data.
		/// </summary>
		// Token: 0x0601DEC0 RID: 122560 RVA: 0x002A3FD8 File Offset: 0x002A21D8
		public virtual void GetTuples(long p1, long p2, vtkAbstractArray output)
		{
			vtkAbstractArray.vtkAbstractArray_GetTuples_36(base.GetCppThis(), p1, p2, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x0601DEC1 RID: 122561
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractArray_GetVariantValue_37(HandleRef pThis, long valueIdx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve value from the array as a variant.
		/// </summary>
		// Token: 0x0601DEC2 RID: 122562 RVA: 0x002A400C File Offset: 0x002A220C
		public virtual vtkVariant GetVariantValue(long valueIdx)
		{
			vtkVariant result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractArray.vtkAbstractArray_GetVariantValue_37(base.GetCppThis(), valueIdx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DEC3 RID: 122563
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractArray_GetVoidPointer_38(HandleRef pThis, long valueIdx);

		/// <summary>
		/// Return a void pointer. For image pipeline interface and other
		/// special pointer manipulation.
		/// Use of this method is discouraged, as newer arrays require a deep-copy of
		/// the array data in order to return a suitable pointer. See vtkArrayDispatch
		/// for a safer alternative for fast data access.
		/// </summary>
		// Token: 0x0601DEC4 RID: 122564 RVA: 0x002A4068 File Offset: 0x002A2268
		public virtual IntPtr GetVoidPointer(long valueIdx)
		{
			return vtkAbstractArray.vtkAbstractArray_GetVoidPointer_38(base.GetCppThis(), valueIdx);
		}

		// Token: 0x0601DEC5 RID: 122565
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAbstractArray_HasAComponentName_39(HandleRef pThis);

		/// <summary>
		/// Returns if any component has had a name assigned
		/// </summary>
		// Token: 0x0601DEC6 RID: 122566 RVA: 0x002A4088 File Offset: 0x002A2288
		public bool HasAComponentName()
		{
			return vtkAbstractArray.vtkAbstractArray_HasAComponentName_39(base.GetCppThis()) != 0;
		}

		// Token: 0x0601DEC7 RID: 122567
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAbstractArray_HasInformation_40(HandleRef pThis);

		/// <summary>
		/// Inquire if this array has an instance of vtkInformation
		/// already associated with it.
		/// </summary>
		// Token: 0x0601DEC8 RID: 122568 RVA: 0x002A40B0 File Offset: 0x002A22B0
		public bool HasInformation()
		{
			return vtkAbstractArray.vtkAbstractArray_HasInformation_40(base.GetCppThis()) != 0;
		}

		// Token: 0x0601DEC9 RID: 122569
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAbstractArray_HasStandardMemoryLayout_41(HandleRef pThis);

		/// <summary>
		/// Returns true if this array uses the standard memory layout defined in the
		/// VTK user guide, e.g. a contiguous array:
		/// {t1c1, t1c2, t1c3, ... t1cM, t2c1, ... tNcM}
		/// where t1c2 is the second component of the first tuple.
		/// </summary>
		// Token: 0x0601DECA RID: 122570 RVA: 0x002A40D8 File Offset: 0x002A22D8
		public virtual bool HasStandardMemoryLayout()
		{
			return vtkAbstractArray.vtkAbstractArray_HasStandardMemoryLayout_41(base.GetCppThis()) != 0;
		}

		// Token: 0x0601DECB RID: 122571
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractArray_Initialize_42(HandleRef pThis);

		/// <summary>
		/// Release storage and reset array to initial state.
		/// </summary>
		// Token: 0x0601DECC RID: 122572 RVA: 0x002A40FE File Offset: 0x002A22FE
		public virtual void Initialize()
		{
			vtkAbstractArray.vtkAbstractArray_Initialize_42(base.GetCppThis());
		}

		// Token: 0x0601DECD RID: 122573
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractArray_InsertNextTuple_43(HandleRef pThis, long srcTupleIdx, HandleRef source);

		/// <summary>
		/// Insert the tuple from srcTupleIdx in the source array at the end of this
		/// array. Note that memory allocation is performed as necessary to hold the
		/// data. Returns the tuple index at which the data was inserted.
		/// </summary>
		// Token: 0x0601DECE RID: 122574 RVA: 0x002A4110 File Offset: 0x002A2310
		public virtual long InsertNextTuple(long srcTupleIdx, vtkAbstractArray source)
		{
			return vtkAbstractArray.vtkAbstractArray_InsertNextTuple_43(base.GetCppThis(), srcTupleIdx, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601DECF RID: 122575
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractArray_InsertTuple_44(HandleRef pThis, long dstTupleIdx, long srcTupleIdx, HandleRef source);

		/// <summary>
		/// Insert the tuple at srcTupleIdx in the source array into this array at
		/// dstTupleIdx.
		/// Note that memory allocation is performed as necessary to hold the data.
		/// </summary>
		// Token: 0x0601DED0 RID: 122576 RVA: 0x002A4148 File Offset: 0x002A2348
		public virtual void InsertTuple(long dstTupleIdx, long srcTupleIdx, vtkAbstractArray source)
		{
			vtkAbstractArray.vtkAbstractArray_InsertTuple_44(base.GetCppThis(), dstTupleIdx, srcTupleIdx, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601DED1 RID: 122577
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractArray_InsertTuples_45(HandleRef pThis, HandleRef dstIds, HandleRef srcIds, HandleRef source);

		/// <summary>
		/// Copy the tuples indexed in srcIds from the source array to the tuple
		/// locations indexed by dstIds in this array.
		/// Note that memory allocation is performed as necessary to hold the data.
		/// </summary>
		// Token: 0x0601DED2 RID: 122578 RVA: 0x002A417C File Offset: 0x002A237C
		public virtual void InsertTuples(vtkIdList dstIds, vtkIdList srcIds, vtkAbstractArray source)
		{
			vtkAbstractArray.vtkAbstractArray_InsertTuples_45(base.GetCppThis(), (dstIds == null) ? default(HandleRef) : dstIds.GetCppThis(), (srcIds == null) ? default(HandleRef) : srcIds.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601DED3 RID: 122579
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractArray_InsertTuples_46(HandleRef pThis, long dstStart, long n, long srcStart, HandleRef source);

		/// <summary>
		/// Copy n consecutive tuples starting at srcStart from the source array to
		/// this array, starting at the dstStart location.
		/// Note that memory allocation is performed as necessary to hold the data.
		/// </summary>
		// Token: 0x0601DED4 RID: 122580 RVA: 0x002A41D8 File Offset: 0x002A23D8
		public virtual void InsertTuples(long dstStart, long n, long srcStart, vtkAbstractArray source)
		{
			vtkAbstractArray.vtkAbstractArray_InsertTuples_46(base.GetCppThis(), dstStart, n, srcStart, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601DED5 RID: 122581
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractArray_InsertTuplesStartingAt_47(HandleRef pThis, long dstStart, HandleRef srcIds, HandleRef source);

		/// <summary>
		/// Copy the tuples indexed in srcIds from the source array to the tuple
		/// locations starting at index dstStart.
		/// Note that memory allocation is performed as necessary to hold the data.
		/// </summary>
		// Token: 0x0601DED6 RID: 122582 RVA: 0x002A420C File Offset: 0x002A240C
		public virtual void InsertTuplesStartingAt(long dstStart, vtkIdList srcIds, vtkAbstractArray source)
		{
			vtkAbstractArray.vtkAbstractArray_InsertTuplesStartingAt_47(base.GetCppThis(), dstStart, (srcIds == null) ? default(HandleRef) : srcIds.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601DED7 RID: 122583
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractArray_InsertVariantValue_48(HandleRef pThis, long valueIdx, HandleRef value);

		/// <summary>
		/// Insert a value into the array from a variant.  This method does
		/// bounds checking.
		/// </summary>
		// Token: 0x0601DED8 RID: 122584 RVA: 0x002A4254 File Offset: 0x002A2454
		public virtual void InsertVariantValue(long valueIdx, vtkVariant value)
		{
			vtkAbstractArray.vtkAbstractArray_InsertVariantValue_48(base.GetCppThis(), valueIdx, (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601DED9 RID: 122585
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractArray_InterpolateTuple_49(HandleRef pThis, long dstTupleIdx, HandleRef ptIndices, HandleRef source, IntPtr weights);

		/// <summary>
		/// Set the tuple at dstTupleIdx in this array to the interpolated tuple value,
		/// given the ptIndices in the source array and associated interpolation
		/// weights.
		/// This method assumes that the two arrays are of the same type
		/// and structure.
		/// </summary>
		// Token: 0x0601DEDA RID: 122586 RVA: 0x002A4284 File Offset: 0x002A2484
		public virtual void InterpolateTuple(long dstTupleIdx, vtkIdList ptIndices, vtkAbstractArray source, IntPtr weights)
		{
			vtkAbstractArray.vtkAbstractArray_InterpolateTuple_49(base.GetCppThis(), dstTupleIdx, (ptIndices == null) ? default(HandleRef) : ptIndices.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis(), weights);
		}

		// Token: 0x0601DEDB RID: 122587
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractArray_InterpolateTuple_50(HandleRef pThis, long dstTupleIdx, long srcTupleIdx1, HandleRef source1, long srcTupleIdx2, HandleRef source2, double t);

		/// <summary>
		/// Insert the tuple at dstTupleIdx in this array to the tuple interpolated
		/// from the two tuple indices, srcTupleIdx1 and srcTupleIdx2, and an
		/// interpolation factor, t. The interpolation factor ranges from (0,1),
		/// with t=0 located at the tuple described by srcTupleIdx1. This method
		/// assumes that the three arrays are of the same type, srcTupleIdx1 is an
		/// index to array source1, and srcTupleIdx2 is an index to array source2.
		/// </summary>
		// Token: 0x0601DEDC RID: 122588 RVA: 0x002A42CC File Offset: 0x002A24CC
		public virtual void InterpolateTuple(long dstTupleIdx, long srcTupleIdx1, vtkAbstractArray source1, long srcTupleIdx2, vtkAbstractArray source2, double t)
		{
			vtkAbstractArray.vtkAbstractArray_InterpolateTuple_50(base.GetCppThis(), dstTupleIdx, srcTupleIdx1, (source1 == null) ? default(HandleRef) : source1.GetCppThis(), srcTupleIdx2, (source2 == null) ? default(HandleRef) : source2.GetCppThis(), t);
		}

		// Token: 0x0601DEDD RID: 122589
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractArray_IsA_51(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DEDE RID: 122590 RVA: 0x002A4318 File Offset: 0x002A2518
		public override int IsA(string type)
		{
			return vtkAbstractArray.vtkAbstractArray_IsA_51(base.GetCppThis(), type);
		}

		// Token: 0x0601DEDF RID: 122591
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAbstractArray_IsIntegral_52(HandleRef pThis);

		/// <summary>
		/// This method will return true if and only if an array contains integer-valued data.
		/// </summary>
		// Token: 0x0601DEE0 RID: 122592 RVA: 0x002A4338 File Offset: 0x002A2538
		public virtual bool IsIntegral()
		{
			return vtkAbstractArray.vtkAbstractArray_IsIntegral_52(base.GetCppThis()) != 0;
		}

		// Token: 0x0601DEE1 RID: 122593
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractArray_IsNumeric_53(HandleRef pThis);

		/// <summary>
		/// This method is here to make backward compatibility easier.  It
		/// must return true if and only if an array contains numeric data.
		/// </summary>
		// Token: 0x0601DEE2 RID: 122594 RVA: 0x002A4360 File Offset: 0x002A2560
		public virtual int IsNumeric()
		{
			return vtkAbstractArray.vtkAbstractArray_IsNumeric_53(base.GetCppThis());
		}

		// Token: 0x0601DEE3 RID: 122595
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractArray_IsTypeOf_54([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DEE4 RID: 122596 RVA: 0x002A4380 File Offset: 0x002A2580
		public new static int IsTypeOf(string type)
		{
			return vtkAbstractArray.vtkAbstractArray_IsTypeOf_54(type);
		}

		// Token: 0x0601DEE5 RID: 122597
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractArray_LookupValue_55(HandleRef pThis, HandleRef value);

		/// <summary>
		/// Return the value indices where a specific value appears.
		///
		/// @warning Make sure that the lookup structure is not outdated. Calls
		/// to `Modified` should be done appropriately so the array knows
		/// when to update its lookup structure.
		/// </summary>
		// Token: 0x0601DEE6 RID: 122598 RVA: 0x002A439C File Offset: 0x002A259C
		public virtual long LookupValue(vtkVariant value)
		{
			return vtkAbstractArray.vtkAbstractArray_LookupValue_55(base.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601DEE7 RID: 122599
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractArray_LookupValue_56(HandleRef pThis, HandleRef value, HandleRef valueIds);

		/// <summary>
		/// Return the value indices where a specific value appears.
		///
		/// @warning Make sure that the lookup structure is not outdated. Calls
		/// to `Modified` should be done appropriately so the array knows
		/// when to update its lookup structure.
		/// </summary>
		// Token: 0x0601DEE8 RID: 122600 RVA: 0x002A43D0 File Offset: 0x002A25D0
		public virtual void LookupValue(vtkVariant value, vtkIdList valueIds)
		{
			vtkAbstractArray.vtkAbstractArray_LookupValue_56(base.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis(), (valueIds == null) ? default(HandleRef) : valueIds.GetCppThis());
		}

		// Token: 0x0601DEE9 RID: 122601
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractArray_Modified_57(HandleRef pThis);

		/// <summary>
		/// Removes out-of-date PER_COMPONENT() and PER_FINITE_COMPONENT() values.
		/// </summary>
		// Token: 0x0601DEEA RID: 122602 RVA: 0x002A4414 File Offset: 0x002A2614
		public override void Modified()
		{
			vtkAbstractArray.vtkAbstractArray_Modified_57(base.GetCppThis());
		}

		// Token: 0x0601DEEB RID: 122603
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractArray_NewInstance_58(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DEEC RID: 122604 RVA: 0x002A4424 File Offset: 0x002A2624
		public new vtkAbstractArray NewInstance()
		{
			vtkAbstractArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractArray.vtkAbstractArray_NewInstance_58(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DEED RID: 122605
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractArray_NewIterator_59(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Subclasses must override this method and provide the right kind
		/// of templated vtkArrayIteratorTemplate.
		/// </summary>
		// Token: 0x0601DEEE RID: 122606 RVA: 0x002A4480 File Offset: 0x002A2680
		public virtual vtkArrayIterator NewIterator()
		{
			vtkArrayIterator vtkArrayIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractArray.vtkAbstractArray_NewIterator_59(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601DEEF RID: 122607
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractArray_PER_COMPONENT_60(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This key is used to hold a vector of COMPONENT_VALUES (and, for
		/// vtkDataArray subclasses, COMPONENT_RANGE) keys -- one
		/// for each component of the array.  You may add additional per-component
		/// key-value pairs to information objects in this vector. However if you
		/// do so, you must be sure to either (1) set COMPONENT_VALUES to
		/// an invalid variant and set COMPONENT_RANGE to
		/// {VTK_DOUBLE_MAX, VTK_DOUBLE_MIN} or (2) call ComputeUniqueValues(component)
		/// and ComputeRange(component) &lt;b&gt;before&lt;/b&gt; modifying the information object.
		/// Otherwise it is possible for modifications to the array to take place
		/// without the bounds on the component being updated.
		/// </summary>
		// Token: 0x0601DEF0 RID: 122608 RVA: 0x002A44F0 File Offset: 0x002A26F0
		public static vtkInformationInformationVectorKey PER_COMPONENT()
		{
			vtkInformationInformationVectorKey vtkInformationInformationVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractArray.vtkAbstractArray_PER_COMPONENT_60(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationInformationVectorKey = (vtkInformationInformationVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationInformationVectorKey.Register(null);
				}
			}
			return vtkInformationInformationVectorKey;
		}

		// Token: 0x0601DEF1 RID: 122609
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractArray_PER_FINITE_COMPONENT_61(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This key is used to hold a vector of COMPONENT_VALUES (and, for
		/// vtkDataArray subclasses, COMPONENT_RANGE) keys -- one
		/// for each component of the array.  You may add additional per-component
		/// key-value pairs to information objects in this vector. However if you
		/// do so, you must be sure to either (1) set COMPONENT_VALUES to
		/// an invalid variant and set COMPONENT_RANGE to
		/// {VTK_DOUBLE_MAX, VTK_DOUBLE_MIN} or (2) call ComputeUniqueValues(component)
		/// and ComputeFiniteRange(component) &lt;b&gt;before&lt;/b&gt; modifying the information object.
		/// Otherwise it is possible for modifications to the array to take place
		/// without the bounds on the component being updated.
		/// </summary>
		// Token: 0x0601DEF2 RID: 122610 RVA: 0x002A455C File Offset: 0x002A275C
		public static vtkInformationInformationVectorKey PER_FINITE_COMPONENT()
		{
			vtkInformationInformationVectorKey vtkInformationInformationVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractArray.vtkAbstractArray_PER_FINITE_COMPONENT_61(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationInformationVectorKey = (vtkInformationInformationVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationInformationVectorKey.Register(null);
				}
			}
			return vtkInformationInformationVectorKey;
		}

		// Token: 0x0601DEF3 RID: 122611
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractArray_Reset_62(HandleRef pThis);

		/// <summary>
		/// Reset to an empty state, without freeing any memory.
		/// </summary>
		// Token: 0x0601DEF4 RID: 122612 RVA: 0x002A45C5 File Offset: 0x002A27C5
		public void Reset()
		{
			vtkAbstractArray.vtkAbstractArray_Reset_62(base.GetCppThis());
		}

		// Token: 0x0601DEF5 RID: 122613
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractArray_Resize_63(HandleRef pThis, long numTuples);

		/// <summary>
		/// Resize the array to the requested number of tuples and preserve data.
		/// Increasing the array size may allocate extra memory beyond what was
		/// requested. MaxId will not be modified when increasing array size.
		/// Decreasing the array size will trim memory to the requested size and
		/// may update MaxId if the valid id range is truncated.
		/// Requesting an array size of 0 will free all memory.
		/// Returns 1 if resizing succeeded and 0 otherwise.
		/// </summary>
		// Token: 0x0601DEF6 RID: 122614 RVA: 0x002A45D4 File Offset: 0x002A27D4
		public virtual int Resize(long numTuples)
		{
			return vtkAbstractArray.vtkAbstractArray_Resize_63(base.GetCppThis(), numTuples);
		}

		// Token: 0x0601DEF7 RID: 122615
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractArray_SafeDownCast_64(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DEF8 RID: 122616 RVA: 0x002A45F4 File Offset: 0x002A27F4
		public new static vtkAbstractArray SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractArray.vtkAbstractArray_SafeDownCast_64((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractArray = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractArray.Register(null);
				}
			}
			return vtkAbstractArray;
		}

		// Token: 0x0601DEF9 RID: 122617
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractArray_SetComponentName_65(HandleRef pThis, long component, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set the name for a component. `component` must be &gt;= 0.
		/// </summary>
		// Token: 0x0601DEFA RID: 122618 RVA: 0x002A4673 File Offset: 0x002A2873
		public void SetComponentName(long component, string name)
		{
			vtkAbstractArray.vtkAbstractArray_SetComponentName_65(base.GetCppThis(), component, name);
		}

		// Token: 0x0601DEFB RID: 122619
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractArray_SetMaxDiscreteValues_66(HandleRef pThis, uint _arg);

		/// <summary>
		/// Get/Set the maximum number of prominent values this array may contain
		/// before it is considered continuous.  Default value is 32.
		/// </summary>
		// Token: 0x0601DEFC RID: 122620 RVA: 0x002A4684 File Offset: 0x002A2884
		public virtual void SetMaxDiscreteValues(uint _arg)
		{
			vtkAbstractArray.vtkAbstractArray_SetMaxDiscreteValues_66(base.GetCppThis(), _arg);
		}

		// Token: 0x0601DEFD RID: 122621
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractArray_SetName_67(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/get array's name
		/// </summary>
		// Token: 0x0601DEFE RID: 122622 RVA: 0x002A4694 File Offset: 0x002A2894
		public virtual void SetName(string _arg)
		{
			vtkAbstractArray.vtkAbstractArray_SetName_67(base.GetCppThis(), _arg);
		}

		// Token: 0x0601DEFF RID: 122623
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractArray_SetNumberOfComponents_68(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the dimension (n) of the components. Must be &gt;= 1. Make sure that
		/// this is set before allocation.
		/// </summary>
		// Token: 0x0601DF00 RID: 122624 RVA: 0x002A46A4 File Offset: 0x002A28A4
		public virtual void SetNumberOfComponents(int _arg)
		{
			vtkAbstractArray.vtkAbstractArray_SetNumberOfComponents_68(base.GetCppThis(), _arg);
		}

		// Token: 0x0601DF01 RID: 122625
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractArray_SetNumberOfTuples_69(HandleRef pThis, long numTuples);

		/// <summary>
		/// Set the number of tuples (a component group) in the array. Note that
		/// this may allocate space depending on the number of components.
		/// Also note that if allocation is performed no copy is performed so
		/// existing data will be lost (if data conservation is sought, one may
		/// use the Resize method instead).
		/// </summary>
		// Token: 0x0601DF02 RID: 122626 RVA: 0x002A46B4 File Offset: 0x002A28B4
		public virtual void SetNumberOfTuples(long numTuples)
		{
			vtkAbstractArray.vtkAbstractArray_SetNumberOfTuples_69(base.GetCppThis(), numTuples);
		}

		// Token: 0x0601DF03 RID: 122627
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAbstractArray_SetNumberOfValues_70(HandleRef pThis, long numValues);

		/// <summary>
		/// Specify the number of values (tuples * components) for this object to
		/// hold. Does an allocation as well as setting the MaxId ivar. Used in
		/// conjunction with SetValue() method for fast insertion. Preserves existing
		/// data and returns true if allocation succeeds, or false otherwise.
		/// </summary>
		// Token: 0x0601DF04 RID: 122628 RVA: 0x002A46C4 File Offset: 0x002A28C4
		public virtual bool SetNumberOfValues(long numValues)
		{
			return vtkAbstractArray.vtkAbstractArray_SetNumberOfValues_70(base.GetCppThis(), numValues) != 0;
		}

		// Token: 0x0601DF05 RID: 122629
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractArray_SetTuple_71(HandleRef pThis, long dstTupleIdx, long srcTupleIdx, HandleRef source);

		/// <summary>
		/// Set the tuple at dstTupleIdx in this array to the tuple at srcTupleIdx in
		/// the source array. This method assumes that the two arrays have the same
		/// type and structure. Note that range checking and memory allocation is not
		/// performed; use in conjunction with SetNumberOfTuples() to allocate space.
		/// </summary>
		// Token: 0x0601DF06 RID: 122630 RVA: 0x002A46EC File Offset: 0x002A28EC
		public virtual void SetTuple(long dstTupleIdx, long srcTupleIdx, vtkAbstractArray source)
		{
			vtkAbstractArray.vtkAbstractArray_SetTuple_71(base.GetCppThis(), dstTupleIdx, srcTupleIdx, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601DF07 RID: 122631
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractArray_SetVariantValue_72(HandleRef pThis, long valueIdx, HandleRef value);

		/// <summary>
		/// Set a value in the array from a variant.  This method does NOT do
		/// bounds checking.
		/// </summary>
		// Token: 0x0601DF08 RID: 122632 RVA: 0x002A4720 File Offset: 0x002A2920
		public virtual void SetVariantValue(long valueIdx, vtkVariant value)
		{
			vtkAbstractArray.vtkAbstractArray_SetVariantValue_72(base.GetCppThis(), valueIdx, (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601DF09 RID: 122633
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractArray_SetVoidArray_73(HandleRef pThis, IntPtr arg0, long arg1, int arg2);

		/// <summary>
		/// This method lets the user specify data to be held by the array.  The
		/// array argument is a pointer to the data.  size is the size of the array
		/// supplied by the user.  Set save to 1 to keep the class from deleting the
		/// array when it cleans up or reallocates memory.  The class uses the
		/// actual array provided; it does not copy the data from the supplied
		/// array. If specified, the delete method determines how the data array
		/// will be deallocated. If the delete method is VTK_DATA_ARRAY_FREE, free()
		/// will be used. If the delete method is VTK_DATA_ARRAY_DELETE, delete[]
		/// will be used. If the delete method is VTK_DATA_ARRAY_ALIGNED_FREE
		/// _aligned_free() will be used on windows, while free() will be used
		/// everywhere else. If the delete method is VTK_DATA_ARRAY_USER_DEFINED
		/// a custom free function can be assigned to be called using SetArrayFreeFunction,
		/// if no custom function is assigned we will default to free().
		/// The default is FREE.
		/// (Note not all subclasses can support deleteMethod.)
		/// </summary>
		// Token: 0x0601DF0A RID: 122634 RVA: 0x002A4750 File Offset: 0x002A2950
		public virtual void SetVoidArray(IntPtr arg0, long arg1, int arg2)
		{
			vtkAbstractArray.vtkAbstractArray_SetVoidArray_73(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x0601DF0B RID: 122635
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractArray_SetVoidArray_74(HandleRef pThis, IntPtr array, long size, int save, int arg3);

		/// <summary>
		/// This method lets the user specify data to be held by the array.  The
		/// array argument is a pointer to the data.  size is the size of the array
		/// supplied by the user.  Set save to 1 to keep the class from deleting the
		/// array when it cleans up or reallocates memory.  The class uses the
		/// actual array provided; it does not copy the data from the supplied
		/// array. If specified, the delete method determines how the data array
		/// will be deallocated. If the delete method is VTK_DATA_ARRAY_FREE, free()
		/// will be used. If the delete method is VTK_DATA_ARRAY_DELETE, delete[]
		/// will be used. If the delete method is VTK_DATA_ARRAY_ALIGNED_FREE
		/// _aligned_free() will be used on windows, while free() will be used
		/// everywhere else. If the delete method is VTK_DATA_ARRAY_USER_DEFINED
		/// a custom free function can be assigned to be called using SetArrayFreeFunction,
		/// if no custom function is assigned we will default to free().
		/// The default is FREE.
		/// (Note not all subclasses can support deleteMethod.)
		/// </summary>
		// Token: 0x0601DF0C RID: 122636 RVA: 0x002A4762 File Offset: 0x002A2962
		public virtual void SetVoidArray(IntPtr array, long size, int save, int arg3)
		{
			vtkAbstractArray.vtkAbstractArray_SetVoidArray_74(base.GetCppThis(), array, size, save, arg3);
		}

		// Token: 0x0601DF0D RID: 122637
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractArray_Squeeze_75(HandleRef pThis);

		/// <summary>
		/// Free any unnecessary memory.
		/// Description:
		/// Resize object to just fit data requirement. Reclaims extra memory.
		/// </summary>
		// Token: 0x0601DF0E RID: 122638 RVA: 0x002A4776 File Offset: 0x002A2976
		public virtual void Squeeze()
		{
			vtkAbstractArray.vtkAbstractArray_Squeeze_75(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F8C RID: 8076
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractArray";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F8D RID: 8077
		public new static readonly string MRClassNameKey = "class vtkAbstractArray";

		/// <summary>
		/// A key used to hold conditions under which cached discrete values were generated;
		/// the value is a 2-vector of doubles.
		/// The first entry corresponds to the maximum uncertainty that prominent values
		/// exist but have not been detected. The second entry corresponds to the smallest
		/// relative frequency a value is allowed to have and still appear on the list.
		/// </summary>
		// Token: 0x02000B25 RID: 2853
		public enum MAX_DISCRETE_VALUES_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04001F8F RID: 8079
			MAX_DISCRETE_VALUES = 32
		}

		/// <summary>
		/// Get/Set the maximum number of prominent values this array may contain
		/// before it is considered continuous.  Default value is 32.
		/// </summary>
		// Token: 0x02000B26 RID: 2854
		public enum AbstractArray_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04001F91 RID: 8081
			AbstractArray,
			/// <summary>enum member</summary>
			// Token: 0x04001F92 RID: 8082
			AoSDataArrayTemplate = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001F93 RID: 8083
			DataArray = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001F94 RID: 8084
			DataArrayTemplate,
			/// <summary>enum member</summary>
			// Token: 0x04001F95 RID: 8085
			ImplicitArray = 7,
			/// <summary>enum member</summary>
			// Token: 0x04001F96 RID: 8086
			MappedDataArray = 5,
			/// <summary>enum member</summary>
			// Token: 0x04001F97 RID: 8087
			ScaleSoADataArrayTemplate,
			/// <summary>enum member</summary>
			// Token: 0x04001F98 RID: 8088
			SoADataArrayTemplate = 3,
			/// <summary>enum member</summary>
			// Token: 0x04001F99 RID: 8089
			TypedDataArray
		}

		/// <summary>
		/// What is the maximum id currently in the array.
		/// </summary>
		// Token: 0x02000B27 RID: 2855
		public enum DeleteMethod
		{
			/// <summary>enum member</summary>
			// Token: 0x04001F9B RID: 8091
			VTK_DATA_ARRAY_ALIGNED_FREE = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001F9C RID: 8092
			VTK_DATA_ARRAY_DELETE = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001F9D RID: 8093
			VTK_DATA_ARRAY_FREE = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001F9E RID: 8094
			VTK_DATA_ARRAY_USER_DEFINED = 3
		}
	}
}
