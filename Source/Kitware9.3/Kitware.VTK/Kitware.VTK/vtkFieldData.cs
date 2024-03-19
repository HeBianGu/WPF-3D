using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFieldData
	/// </summary>
	/// <remarks>
	///    represent and manipulate fields of data
	///
	/// vtkFieldData represents and manipulates fields of data. The model of a field
	/// is a m x n matrix of data values, where m is the number of tuples, and n
	/// is the number of components. (A tuple is a row of n components in the
	/// matrix.) The field is assumed to be composed of a set of one or more data
	/// arrays, where the data in the arrays are of different types (e.g., int,
	/// double, char, etc.), and there may be variable numbers of components in
	/// each array. Note that each data array is assumed to be "m" in length
	/// (i.e., number of tuples), which typically corresponds to the number of
	/// points or cells in a dataset. Also, each data array must have a
	/// character-string name. (This is used to manipulate data.)
	///
	/// There are two ways of manipulating and interfacing to fields. You can do
	/// it generically by manipulating components/tuples via a double-type data
	/// exchange, or you can do it by grabbing the arrays and manipulating them
	/// directly. The former is simpler but performs type conversion, which is bad
	/// if your data has non-castable types like (void) pointers, or you lose
	/// information as a result of the cast. The more efficient method means
	/// managing each array in the field.  Using this method you can create
	/// faster, more efficient algorithms that do not lose information.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAbstractArray vtkDataSetAttributes vtkPointData vtkCellData
	/// </seealso>
	// Token: 0x02000A16 RID: 2582
	public class vtkFieldData : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601AE64 RID: 110180 RVA: 0x00257D7B File Offset: 0x00255F7B
		static vtkFieldData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFieldData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFieldData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601AE65 RID: 110181 RVA: 0x00257DA3 File Offset: 0x00255FA3
		public vtkFieldData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601AE66 RID: 110182
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFieldData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AE67 RID: 110183 RVA: 0x00257DB4 File Offset: 0x00255FB4
		public new static vtkFieldData New()
		{
			vtkFieldData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFieldData.vtkFieldData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFieldData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AE68 RID: 110184 RVA: 0x00257E08 File Offset: 0x00256008
		public vtkFieldData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFieldData.vtkFieldData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601AE69 RID: 110185 RVA: 0x00257E4C File Offset: 0x0025604C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601AE6A RID: 110186
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldData_AddArray_01(HandleRef pThis, HandleRef array);

		/// <summary>
		/// Add an array to the array list. If an array with the same name
		/// already exists - then the added array will replace it.
		/// Return the index of the added array. If the given array is nullptr,
		/// does nothing and returns -1.
		/// </summary>
		// Token: 0x0601AE6B RID: 110187 RVA: 0x00257E58 File Offset: 0x00256058
		public int AddArray(vtkAbstractArray array)
		{
			return vtkFieldData.vtkFieldData_AddArray_01(base.GetCppThis(), (array == null) ? default(HandleRef) : array.GetCppThis());
		}

		// Token: 0x0601AE6C RID: 110188
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldData_Allocate_02(HandleRef pThis, long sz, long ext);

		/// <summary>
		/// Allocate data for each array.
		/// Note that ext is no longer used.
		/// </summary>
		// Token: 0x0601AE6D RID: 110189 RVA: 0x00257E8C File Offset: 0x0025608C
		public int Allocate(long sz, long ext)
		{
			return vtkFieldData.vtkFieldData_Allocate_02(base.GetCppThis(), sz, ext);
		}

		// Token: 0x0601AE6E RID: 110190
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldData_AllocateArrays_03(HandleRef pThis, int num);

		/// <summary>
		/// AllocateArrays actually sets the number of
		/// vtkAbstractArray pointers in the vtkFieldData object, not the
		/// number of used pointers (arrays). Adding more arrays will
		/// cause the object to dynamically adjust the number of pointers
		/// if it needs to extend. Although AllocateArrays can
		/// be used if the number of arrays which will be added is
		/// known, it can be omitted with a small computation cost.
		/// </summary>
		// Token: 0x0601AE6F RID: 110191 RVA: 0x00257EAD File Offset: 0x002560AD
		public void AllocateArrays(int num)
		{
			vtkFieldData.vtkFieldData_AllocateArrays_03(base.GetCppThis(), num);
		}

		// Token: 0x0601AE70 RID: 110192
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldData_CopyAllOff_04(HandleRef pThis, int unused);

		/// <summary>
		/// Turn off copying of all data.
		/// During the copying/passing, the following rules are followed for each
		/// array:
		/// 1. If the copy flag for an array is set (on or off), it is applied.
		/// This overrides rule 2.
		/// 2. If CopyAllOn is set, copy the array.
		/// If CopyAllOff is set, do not copy the array.
		/// </summary>
		// Token: 0x0601AE71 RID: 110193 RVA: 0x00257EBD File Offset: 0x002560BD
		public virtual void CopyAllOff(int unused)
		{
			vtkFieldData.vtkFieldData_CopyAllOff_04(base.GetCppThis(), unused);
		}

		// Token: 0x0601AE72 RID: 110194
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldData_CopyAllOn_05(HandleRef pThis, int unused);

		/// <summary>
		/// Turn on copying of all data.
		/// During the copying/passing, the following rules are followed for each
		/// array:
		/// 1. If the copy flag for an array is set (on or off), it is applied.
		/// This overrides rule 2.
		/// 2. If CopyAllOn is set, copy the array.
		/// If CopyAllOff is set, do not copy the array.
		/// </summary>
		// Token: 0x0601AE73 RID: 110195 RVA: 0x00257ECD File Offset: 0x002560CD
		public virtual void CopyAllOn(int unused)
		{
			vtkFieldData.vtkFieldData_CopyAllOn_05(base.GetCppThis(), unused);
		}

		// Token: 0x0601AE74 RID: 110196
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldData_CopyFieldOff_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Turn on/off the copying of the field specified by name.
		/// During the copying/passing, the following rules are followed for each
		/// array:
		/// 1. If the copy flag for an array is set (on or off), it is applied.
		/// This overrides rule 2.
		/// 2. If CopyAllOn is set, copy the array.
		/// If CopyAllOff is set, do not copy the array.
		/// </summary>
		// Token: 0x0601AE75 RID: 110197 RVA: 0x00257EDD File Offset: 0x002560DD
		public void CopyFieldOff(string name)
		{
			vtkFieldData.vtkFieldData_CopyFieldOff_06(base.GetCppThis(), name);
		}

		// Token: 0x0601AE76 RID: 110198
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldData_CopyFieldOn_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Turn on/off the copying of the field specified by name.
		/// During the copying/passing, the following rules are followed for each
		/// array:
		/// 1. If the copy flag for an array is set (on or off), it is applied.
		/// This overrides rule 2.
		/// 2. If CopyAllOn is set, copy the array.
		/// If CopyAllOff is set, do not copy the array.
		/// </summary>
		// Token: 0x0601AE77 RID: 110199 RVA: 0x00257EED File Offset: 0x002560ED
		public void CopyFieldOn(string name)
		{
			vtkFieldData.vtkFieldData_CopyFieldOn_07(base.GetCppThis(), name);
		}

		// Token: 0x0601AE78 RID: 110200
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldData_CopyStructure_08(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Copy data array structure from a given field.  The same arrays
		/// will exist with the same types, but will contain nothing in the
		/// copy.
		/// </summary>
		// Token: 0x0601AE79 RID: 110201 RVA: 0x00257F00 File Offset: 0x00256100
		public void CopyStructure(vtkFieldData arg0)
		{
			vtkFieldData.vtkFieldData_CopyStructure_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601AE7A RID: 110202
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldData_DeepCopy_09(HandleRef pThis, HandleRef da);

		/// <summary>
		/// Copy a field by creating new data arrays (i.e., duplicate storage).
		/// </summary>
		// Token: 0x0601AE7B RID: 110203 RVA: 0x00257F30 File Offset: 0x00256130
		public virtual void DeepCopy(vtkFieldData da)
		{
			vtkFieldData.vtkFieldData_DeepCopy_09(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		// Token: 0x0601AE7C RID: 110204
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFieldData_ExtendedNew_10(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AE7D RID: 110205 RVA: 0x00257F60 File Offset: 0x00256160
		public static vtkFieldData ExtendedNew()
		{
			vtkFieldData vtkFieldData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFieldData.vtkFieldData_ExtendedNew_10(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFieldData = (vtkFieldData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFieldData.Register(null);
				}
			}
			return vtkFieldData;
		}

		// Token: 0x0601AE7E RID: 110206
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFieldData_GetAbstractArray_11(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the ith array in the field. Unlike GetArray(), this method returns
		/// a vtkAbstractArray and can be used to access any array type. A nullptr is
		/// returned only if the index i is out of range.
		/// </summary>
		// Token: 0x0601AE7F RID: 110207 RVA: 0x00257FCC File Offset: 0x002561CC
		public vtkAbstractArray GetAbstractArray(int i)
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFieldData.vtkFieldData_GetAbstractArray_11(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AE80 RID: 110208
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFieldData_GetAbstractArray_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, ref int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the array with the name given. Returns nullptr if array not found.
		/// Unlike GetArray(), this method returns a vtkAbstractArray and can be used
		/// to access any array type. Also returns index of array if found, -1
		/// otherwise.
		/// </summary>
		// Token: 0x0601AE81 RID: 110209 RVA: 0x0025803C File Offset: 0x0025623C
		public vtkAbstractArray GetAbstractArray(string arrayName, ref int index)
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFieldData.vtkFieldData_GetAbstractArray_12(base.GetCppThis(), arrayName, ref index, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AE82 RID: 110210
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFieldData_GetAbstractArray_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the array with the name given. Returns nullptr if array not found.
		/// Unlike GetArray(), this method returns a vtkAbstractArray and can be used
		/// to access any array type.
		/// </summary>
		// Token: 0x0601AE83 RID: 110211 RVA: 0x002580B0 File Offset: 0x002562B0
		public vtkAbstractArray GetAbstractArray(string arrayName)
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFieldData.vtkFieldData_GetAbstractArray_13(base.GetCppThis(), arrayName, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AE84 RID: 110212
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkFieldData_GetActualMemorySize_14(HandleRef pThis);

		/// <summary>
		/// Return the memory in kibibytes (1024 bytes) consumed by this field data. Used to
		/// support streaming and reading/writing data. The value returned is
		/// guaranteed to be greater than or equal to the memory required to
		/// actually represent the data represented by this object.
		/// </summary>
		// Token: 0x0601AE85 RID: 110213 RVA: 0x00258120 File Offset: 0x00256320
		public virtual uint GetActualMemorySize()
		{
			return vtkFieldData.vtkFieldData_GetActualMemorySize_14(base.GetCppThis());
		}

		// Token: 0x0601AE86 RID: 110214
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFieldData_GetArray_15(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Not recommended for use. Use GetAbstractArray(int i) instead.
		///
		/// Return the ith array in the field. A nullptr is returned if the
		/// index i is out of range, or if the array at the given
		/// index is not a vtkDataArray. To access vtkStringArray,
		/// or vtkVariantArray, use GetAbstractArray(int i).
		/// </summary>
		// Token: 0x0601AE87 RID: 110215 RVA: 0x00258140 File Offset: 0x00256340
		public vtkDataArray GetArray(int i)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFieldData.vtkFieldData_GetArray_15(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AE88 RID: 110216
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFieldData_GetArray_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, ref int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Not recommended for use. Use
		/// GetAbstractArray(const char *arrayName, int &amp;index) instead.
		///
		/// Return the array with the name given. Returns nullptr if array not found.
		/// A nullptr is also returned if the array with the given name is not a
		/// vtkDataArray. To access vtkStringArray, or
		/// vtkVariantArray, use GetAbstractArray(const char* arrayName, int &amp;index).
		/// Also returns the index of the array if found, -1 otherwise.
		/// </summary>
		// Token: 0x0601AE89 RID: 110217 RVA: 0x002581B0 File Offset: 0x002563B0
		public vtkDataArray GetArray(string arrayName, ref int index)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFieldData.vtkFieldData_GetArray_16(base.GetCppThis(), arrayName, ref index, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AE8A RID: 110218
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFieldData_GetArray_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Not recommended for use. Use GetAbstractArray(const char *arrayName)
		/// instead.
		///
		/// Return the array with the name given. Returns nullptr if array not found.
		/// A nullptr is also returned if the array with the given name is not a
		/// vtkDataArray. To access vtkStringArray, or
		/// vtkVariantArray, use GetAbstractArray(const char *arrayName).
		/// </summary>
		// Token: 0x0601AE8B RID: 110219 RVA: 0x00258224 File Offset: 0x00256424
		public vtkDataArray GetArray(string arrayName)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFieldData.vtkFieldData_GetArray_17(base.GetCppThis(), arrayName, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AE8C RID: 110220
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldData_GetArrayContainingComponent_18(HandleRef pThis, int i, ref int arrayComp);

		/// <summary>
		/// Return the array containing the ith component of the field. The
		/// return value is an integer number n 0&lt;=n&lt;this-&gt;NumberOfArrays. Also,
		/// an integer value is returned indicating the component in the array
		/// is returned. Method returns -1 if specified component is not
		/// in the field.
		/// </summary>
		// Token: 0x0601AE8D RID: 110221 RVA: 0x00258294 File Offset: 0x00256494
		public int GetArrayContainingComponent(int i, ref int arrayComp)
		{
			return vtkFieldData.vtkFieldData_GetArrayContainingComponent_18(base.GetCppThis(), i, ref arrayComp);
		}

		// Token: 0x0601AE8E RID: 110222
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFieldData_GetArrayName_19(HandleRef pThis, int i);

		/// <summary>
		/// Get the name of ith array.
		/// Note that this is equivalent to:
		/// GetAbstractArray(i)-&gt;GetName() if ith array pointer is not nullptr
		/// </summary>
		// Token: 0x0601AE8F RID: 110223 RVA: 0x002582B8 File Offset: 0x002564B8
		public string GetArrayName(int i)
		{
			string s = Marshal.PtrToStringAnsi(vtkFieldData.vtkFieldData_GetArrayName_19(base.GetCppThis(), i));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601AE90 RID: 110224
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldData_GetField_20(HandleRef pThis, HandleRef ptId, HandleRef f);

		/// <summary>
		/// Get a field from a list of ids. Supplied field f should have same
		/// types and number of data arrays as this one (i.e., like
		/// CopyStructure() creates).  This method should not be used if the
		/// instance is from a subclass of vtkFieldData (vtkPointData or
		/// vtkCellData).  This is because in those cases, the attribute data
		/// is stored with the other fields and will cause the method to
		/// behave in an unexpected way.
		/// </summary>
		// Token: 0x0601AE91 RID: 110225 RVA: 0x002582F4 File Offset: 0x002564F4
		public void GetField(vtkIdList ptId, vtkFieldData f)
		{
			vtkFieldData.vtkFieldData_GetField_20(base.GetCppThis(), (ptId == null) ? default(HandleRef) : ptId.GetCppThis(), (f == null) ? default(HandleRef) : f.GetCppThis());
		}

		// Token: 0x0601AE92 RID: 110226
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFieldData_GetFiniteRange_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr range, int comp);

		/// <summary>
		/// Computes the range of the input data array (specified through its `name` or the `index`
		/// in this field data). If the targeted array is not polymorphic
		/// with a `vtkDataArray`, or if no array match the input `name` or `index`, or
		/// if `comp` is out of bounds, then the returned range is `[NaN, NaN]`.
		///
		/// The computed range is cached to avoid recomputing it. The range is recomputed
		/// if the held array has been modified, if `GhostsToSkip` has been changed, or if
		/// the ghost array has been changed / modified.
		///
		/// If a ghost array is present in the field data, then the binary mask `GhostsToSkip`
		/// is used to skip values associated with a ghost that intersects this mask.
		///
		/// `comp` targets which component of the array the range is to be computed on.
		/// Setting it to -1 results in computing the range of the magnitude of the array.
		///
		/// The `Finite` version of this method skips infinite values in the array in addition
		/// to ghosts matching with `GhostsToSkip`.
		/// </summary>
		// Token: 0x0601AE93 RID: 110227 RVA: 0x00258338 File Offset: 0x00256538
		public bool GetFiniteRange(string name, IntPtr range, int comp)
		{
			return vtkFieldData.vtkFieldData_GetFiniteRange_21(base.GetCppThis(), name, range, comp) != 0;
		}

		// Token: 0x0601AE94 RID: 110228
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFieldData_GetFiniteRange_22(HandleRef pThis, int index, IntPtr range, int comp);

		/// <summary>
		/// Computes the range of the input data array (specified through its `name` or the `index`
		/// in this field data). If the targeted array is not polymorphic
		/// with a `vtkDataArray`, or if no array match the input `name` or `index`, or
		/// if `comp` is out of bounds, then the returned range is `[NaN, NaN]`.
		///
		/// The computed range is cached to avoid recomputing it. The range is recomputed
		/// if the held array has been modified, if `GhostsToSkip` has been changed, or if
		/// the ghost array has been changed / modified.
		///
		/// If a ghost array is present in the field data, then the binary mask `GhostsToSkip`
		/// is used to skip values associated with a ghost that intersects this mask.
		///
		/// `comp` targets which component of the array the range is to be computed on.
		/// Setting it to -1 results in computing the range of the magnitude of the array.
		///
		/// The `Finite` version of this method skips infinite values in the array in addition
		/// to ghosts matching with `GhostsToSkip`.
		/// </summary>
		// Token: 0x0601AE95 RID: 110229 RVA: 0x00258364 File Offset: 0x00256564
		public bool GetFiniteRange(int index, IntPtr range, int comp)
		{
			return vtkFieldData.vtkFieldData_GetFiniteRange_22(base.GetCppThis(), index, range, comp) != 0;
		}

		// Token: 0x0601AE96 RID: 110230
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFieldData_GetGhostArray_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the ghost array, if present in this field data. If no ghost array is set,
		/// returns `nullptr`. A ghost array is a `vtkUnsignedCharArray` called `vtkGhostType`.
		/// See `vtkDataSetAttributes` for more context on ghost types.
		///
		/// @sa
		/// vtkDataSetAttributes
		/// </summary>
		// Token: 0x0601AE97 RID: 110231 RVA: 0x00258390 File Offset: 0x00256590
		public virtual vtkUnsignedCharArray GetGhostArray()
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFieldData.vtkFieldData_GetGhostArray_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601AE98 RID: 110232
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFieldData_GetGhostsToSkip_24(HandleRef pThis);

		/// <summary>
		/// Set / Get the binary mask filtering out certain types of ghosts when calling `GetRange`.
		/// By default, it is set to 0xff for pure `vtkFieldData`. In `vtkCellData`, it is set to
		/// `HIDDENCELL` and in `vtkPointData`, it is set to `HIDDENPOINT` by default.
		/// See `vtkDataSetAttributes` for more context on ghost types definitions.
		///
		/// @sa
		/// vtkDataSetAttributes
		/// vtkPointData
		/// vtkCellData
		/// </summary>
		// Token: 0x0601AE99 RID: 110233 RVA: 0x00258400 File Offset: 0x00256600
		public virtual byte GetGhostsToSkip()
		{
			return vtkFieldData.vtkFieldData_GetGhostsToSkip_24(base.GetCppThis());
		}

		// Token: 0x0601AE9A RID: 110234
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkFieldData_GetMTime_25(HandleRef pThis);

		/// <summary>
		/// Check object's components for modified times.
		/// </summary>
		// Token: 0x0601AE9B RID: 110235 RVA: 0x00258420 File Offset: 0x00256620
		public override ulong GetMTime()
		{
			return vtkFieldData.vtkFieldData_GetMTime_25(base.GetCppThis());
		}

		// Token: 0x0601AE9C RID: 110236
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldData_GetNumberOfArrays_26(HandleRef pThis);

		/// <summary>
		/// Get the number of arrays of data available.
		/// This does not include nullptr array pointers therefore after
		/// fd-&gt;AllocateArray(n); nArrays = GetNumberOfArrays();
		/// nArrays is not necessarily equal to n.
		/// </summary>
		// Token: 0x0601AE9D RID: 110237 RVA: 0x00258440 File Offset: 0x00256640
		public int GetNumberOfArrays()
		{
			return vtkFieldData.vtkFieldData_GetNumberOfArrays_26(base.GetCppThis());
		}

		// Token: 0x0601AE9E RID: 110238
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldData_GetNumberOfComponents_27(HandleRef pThis);

		/// <summary>
		/// Get the number of components in the field. This is determined by adding
		/// up the components in each non-nullptr array.
		/// This method should not be used if the instance is from a
		/// subclass of vtkFieldData (vtkPointData or vtkCellData).
		/// This is because in those cases, the attribute data is
		/// stored with the other fields and will cause the method
		/// to behave in an unexpected way.
		/// </summary>
		// Token: 0x0601AE9F RID: 110239 RVA: 0x00258460 File Offset: 0x00256660
		public int GetNumberOfComponents()
		{
			return vtkFieldData.vtkFieldData_GetNumberOfComponents_27(base.GetCppThis());
		}

		// Token: 0x0601AEA0 RID: 110240
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFieldData_GetNumberOfGenerationsFromBase_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AEA1 RID: 110241 RVA: 0x00258480 File Offset: 0x00256680
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFieldData.vtkFieldData_GetNumberOfGenerationsFromBase_28(base.GetCppThis(), type);
		}

		// Token: 0x0601AEA2 RID: 110242
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFieldData_GetNumberOfGenerationsFromBaseType_29([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AEA3 RID: 110243 RVA: 0x002584A0 File Offset: 0x002566A0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFieldData.vtkFieldData_GetNumberOfGenerationsFromBaseType_29(type);
		}

		// Token: 0x0601AEA4 RID: 110244
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFieldData_GetNumberOfTuples_30(HandleRef pThis);

		/// <summary>
		/// Get the number of tuples in the field. Note: some fields have arrays with
		/// different numbers of tuples; this method returns the number of tuples in
		/// the first array. Mixed-length arrays may have to be treated specially.
		/// This method should not be used if the instance is from a
		/// subclass of vtkFieldData (vtkPointData or vtkCellData).
		/// This is because in those cases, the attribute data is
		/// stored with the other fields and will cause the method
		/// to behave in an unexpected way.
		/// </summary>
		// Token: 0x0601AEA5 RID: 110245 RVA: 0x002584BC File Offset: 0x002566BC
		public long GetNumberOfTuples()
		{
			return vtkFieldData.vtkFieldData_GetNumberOfTuples_30(base.GetCppThis());
		}

		// Token: 0x0601AEA6 RID: 110246
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFieldData_GetRange_31(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, IntPtr range, int comp);

		/// <summary>
		/// Computes the range of the input data array (specified through its `name` or the `index`
		/// in this field data). If the targeted array is not polymorphic
		/// with a `vtkDataArray`, or if no array match the input `name` or `index`, or
		/// if `comp` is out of bounds, then the returned range is `[NaN, NaN]`.
		///
		/// The computed range is cached to avoid recomputing it. The range is recomputed
		/// if the held array has been modified, if `GhostsToSkip` has been changed, or if
		/// the ghost array has been changed / modified.
		///
		/// If a ghost array is present in the field data, then the binary mask `GhostsToSkip`
		/// is used to skip values associated with a ghost that intersects this mask.
		///
		/// `comp` targets which component of the array the range is to be computed on.
		/// Setting it to -1 results in computing the range of the magnitude of the array.
		///
		/// The `Finite` version of this method skips infinite values in the array in addition
		/// to ghosts matching with `GhostsToSkip`.
		/// </summary>
		// Token: 0x0601AEA7 RID: 110247 RVA: 0x002584DC File Offset: 0x002566DC
		public bool GetRange(string name, IntPtr range, int comp)
		{
			return vtkFieldData.vtkFieldData_GetRange_31(base.GetCppThis(), name, range, comp) != 0;
		}

		// Token: 0x0601AEA8 RID: 110248
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFieldData_GetRange_32(HandleRef pThis, int index, IntPtr range, int comp);

		/// <summary>
		/// Computes the range of the input data array (specified through its `name` or the `index`
		/// in this field data). If the targeted array is not polymorphic
		/// with a `vtkDataArray`, or if no array match the input `name` or `index`, or
		/// if `comp` is out of bounds, then the returned range is `[NaN, NaN]`.
		///
		/// The computed range is cached to avoid recomputing it. The range is recomputed
		/// if the held array has been modified, if `GhostsToSkip` has been changed, or if
		/// the ghost array has been changed / modified.
		///
		/// If a ghost array is present in the field data, then the binary mask `GhostsToSkip`
		/// is used to skip values associated with a ghost that intersects this mask.
		///
		/// `comp` targets which component of the array the range is to be computed on.
		/// Setting it to -1 results in computing the range of the magnitude of the array.
		///
		/// The `Finite` version of this method skips infinite values in the array in addition
		/// to ghosts matching with `GhostsToSkip`.
		/// </summary>
		// Token: 0x0601AEA9 RID: 110249 RVA: 0x00258508 File Offset: 0x00256708
		public bool GetRange(int index, IntPtr range, int comp)
		{
			return vtkFieldData.vtkFieldData_GetRange_32(base.GetCppThis(), index, range, comp) != 0;
		}

		// Token: 0x0601AEAA RID: 110250
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFieldData_HasAnyGhostBitSet_33(HandleRef pThis, int bitFlag);

		/// <summary>
		/// Helper function that tests if any of the values in ghost array has been set.
		/// The test performed is (value &amp; bitFlag).
		/// </summary>
		// Token: 0x0601AEAB RID: 110251 RVA: 0x00258534 File Offset: 0x00256734
		public bool HasAnyGhostBitSet(int bitFlag)
		{
			return vtkFieldData.vtkFieldData_HasAnyGhostBitSet_33(base.GetCppThis(), bitFlag) != 0;
		}

		// Token: 0x0601AEAC RID: 110252
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldData_HasArray_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Return 1 if an array with the given name could be found. 0 otherwise.
		/// </summary>
		// Token: 0x0601AEAD RID: 110253 RVA: 0x0025855C File Offset: 0x0025675C
		public int HasArray(string name)
		{
			return vtkFieldData.vtkFieldData_HasArray_34(base.GetCppThis(), name);
		}

		// Token: 0x0601AEAE RID: 110254
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldData_Initialize_35(HandleRef pThis);

		/// <summary>
		/// Release all data but do not delete object.
		/// Also, clear the copy flags.
		/// </summary>
		// Token: 0x0601AEAF RID: 110255 RVA: 0x0025857C File Offset: 0x0025677C
		public virtual void Initialize()
		{
			vtkFieldData.vtkFieldData_Initialize_35(base.GetCppThis());
		}

		// Token: 0x0601AEB0 RID: 110256
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFieldData_InsertNextTuple_36(HandleRef pThis, long j, HandleRef source);

		/// <summary>
		/// Insert the jth tuple in source field data at the end of the
		/// tuple matrix. Range checking is performed and memory is allocated
		/// as necessary.
		/// </summary>
		// Token: 0x0601AEB1 RID: 110257 RVA: 0x0025858C File Offset: 0x0025678C
		public long InsertNextTuple(long j, vtkFieldData source)
		{
			return vtkFieldData.vtkFieldData_InsertNextTuple_36(base.GetCppThis(), j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601AEB2 RID: 110258
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldData_InsertTuple_37(HandleRef pThis, long i, long j, HandleRef source);

		/// <summary>
		/// Insert the jth tuple in source field data at the ith location.
		/// Range checking is performed and memory allocates as necessary.
		/// </summary>
		// Token: 0x0601AEB3 RID: 110259 RVA: 0x002585C4 File Offset: 0x002567C4
		public void InsertTuple(long i, long j, vtkFieldData source)
		{
			vtkFieldData.vtkFieldData_InsertTuple_37(base.GetCppThis(), i, j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601AEB4 RID: 110260
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldData_IsA_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AEB5 RID: 110261 RVA: 0x002585F8 File Offset: 0x002567F8
		public override int IsA(string type)
		{
			return vtkFieldData.vtkFieldData_IsA_38(base.GetCppThis(), type);
		}

		// Token: 0x0601AEB6 RID: 110262
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldData_IsTypeOf_39([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AEB7 RID: 110263 RVA: 0x00258618 File Offset: 0x00256818
		public new static int IsTypeOf(string type)
		{
			return vtkFieldData.vtkFieldData_IsTypeOf_39(type);
		}

		// Token: 0x0601AEB8 RID: 110264
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFieldData_NewInstance_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AEB9 RID: 110265 RVA: 0x00258634 File Offset: 0x00256834
		public new vtkFieldData NewInstance()
		{
			vtkFieldData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFieldData.vtkFieldData_NewInstance_41(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFieldData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601AEBA RID: 110266
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldData_NullData_42(HandleRef pThis, long id);

		/// <summary>
		/// Sets every vtkDataArray at index id to a null tuple.
		/// </summary>
		// Token: 0x0601AEBB RID: 110267 RVA: 0x0025868E File Offset: 0x0025688E
		public void NullData(long id)
		{
			vtkFieldData.vtkFieldData_NullData_42(base.GetCppThis(), id);
		}

		// Token: 0x0601AEBC RID: 110268
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldData_PassData_43(HandleRef pThis, HandleRef fd);

		/// <summary>
		/// Pass entire arrays of input data through to output. Obey the "copy"
		/// flags.
		/// </summary>
		// Token: 0x0601AEBD RID: 110269 RVA: 0x002586A0 File Offset: 0x002568A0
		public virtual void PassData(vtkFieldData fd)
		{
			vtkFieldData.vtkFieldData_PassData_43(base.GetCppThis(), (fd == null) ? default(HandleRef) : fd.GetCppThis());
		}

		// Token: 0x0601AEBE RID: 110270
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldData_RemoveArray_44(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Remove an array (with the given name) from the list of arrays.
		/// </summary>
		// Token: 0x0601AEBF RID: 110271 RVA: 0x002586CF File Offset: 0x002568CF
		public virtual void RemoveArray(string name)
		{
			vtkFieldData.vtkFieldData_RemoveArray_44(base.GetCppThis(), name);
		}

		// Token: 0x0601AEC0 RID: 110272
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldData_RemoveArray_45(HandleRef pThis, int index);

		/// <summary>
		/// Remove an array (with the given index) from the list of arrays.
		/// </summary>
		// Token: 0x0601AEC1 RID: 110273 RVA: 0x002586DF File Offset: 0x002568DF
		public virtual void RemoveArray(int index)
		{
			vtkFieldData.vtkFieldData_RemoveArray_45(base.GetCppThis(), index);
		}

		// Token: 0x0601AEC2 RID: 110274
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldData_Reset_46(HandleRef pThis);

		/// <summary>
		/// Resets each data array in the field (Reset() does not release memory but
		/// it makes the arrays look like they are empty.)
		/// </summary>
		// Token: 0x0601AEC3 RID: 110275 RVA: 0x002586EF File Offset: 0x002568EF
		public void Reset()
		{
			vtkFieldData.vtkFieldData_Reset_46(base.GetCppThis());
		}

		// Token: 0x0601AEC4 RID: 110276
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFieldData_SafeDownCast_47(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AEC5 RID: 110277 RVA: 0x00258700 File Offset: 0x00256900
		public new static vtkFieldData SafeDownCast(vtkObjectBase o)
		{
			vtkFieldData vtkFieldData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFieldData.vtkFieldData_SafeDownCast_47((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFieldData = (vtkFieldData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFieldData.Register(null);
				}
			}
			return vtkFieldData;
		}

		// Token: 0x0601AEC6 RID: 110278
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldData_SetGhostsToSkip_48(HandleRef pThis, byte arg0);

		/// <summary>
		/// Set / Get the binary mask filtering out certain types of ghosts when calling `GetRange`.
		/// By default, it is set to 0xff for pure `vtkFieldData`. In `vtkCellData`, it is set to
		/// `HIDDENCELL` and in `vtkPointData`, it is set to `HIDDENPOINT` by default.
		/// See `vtkDataSetAttributes` for more context on ghost types definitions.
		///
		/// @sa
		/// vtkDataSetAttributes
		/// vtkPointData
		/// vtkCellData
		/// </summary>
		// Token: 0x0601AEC7 RID: 110279 RVA: 0x0025877F File Offset: 0x0025697F
		public virtual void SetGhostsToSkip(byte arg0)
		{
			vtkFieldData.vtkFieldData_SetGhostsToSkip_48(base.GetCppThis(), arg0);
		}

		// Token: 0x0601AEC8 RID: 110280
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldData_SetNumberOfTuples_49(HandleRef pThis, long number);

		/// <summary>
		/// Set the number of tuples for each data array in the field.
		/// This method should not be used if the instance is from a
		/// subclass of vtkFieldData (vtkPointData or vtkCellData).
		/// This is because in those cases, the attribute data is
		/// stored with the other fields and will cause the method
		/// to behave in an unexpected way.
		/// </summary>
		// Token: 0x0601AEC9 RID: 110281 RVA: 0x0025878F File Offset: 0x0025698F
		public void SetNumberOfTuples(long number)
		{
			vtkFieldData.vtkFieldData_SetNumberOfTuples_49(base.GetCppThis(), number);
		}

		// Token: 0x0601AECA RID: 110282
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldData_SetTuple_50(HandleRef pThis, long i, long j, HandleRef source);

		/// <summary>
		/// Set the jth tuple in source field data at the ith location.
		/// Set operations mean that no range checking is performed, so
		/// they're faster.
		/// </summary>
		// Token: 0x0601AECB RID: 110283 RVA: 0x002587A0 File Offset: 0x002569A0
		public void SetTuple(long i, long j, vtkFieldData source)
		{
			vtkFieldData.vtkFieldData_SetTuple_50(base.GetCppThis(), i, j, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601AECC RID: 110284
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldData_ShallowCopy_51(HandleRef pThis, HandleRef da);

		/// <summary>
		/// Copy a field by reference counting the data arrays.
		/// </summary>
		// Token: 0x0601AECD RID: 110285 RVA: 0x002587D4 File Offset: 0x002569D4
		public virtual void ShallowCopy(vtkFieldData da)
		{
			vtkFieldData.vtkFieldData_ShallowCopy_51(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		// Token: 0x0601AECE RID: 110286
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldData_Squeeze_52(HandleRef pThis);

		/// <summary>
		/// Squeezes each data array in the field (Squeeze() reclaims unused memory.)
		/// </summary>
		// Token: 0x0601AECF RID: 110287 RVA: 0x00258803 File Offset: 0x00256A03
		public void Squeeze()
		{
			vtkFieldData.vtkFieldData_Squeeze_52(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D04 RID: 7428
		public new const string MRFullTypeName = "Kitware.VTK.vtkFieldData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D05 RID: 7429
		public new static readonly string MRClassNameKey = "class vtkFieldData";
	}
}
