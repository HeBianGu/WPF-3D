using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRearrangeFields
	/// </summary>
	/// <remarks>
	///    Move/copy fields between field data, point data and cell data
	///
	/// vtkRearrangeFields is used to copy/move fields (vtkDataArrays) between
	/// data object's field data, point data and cell data. To specify which
	/// fields are copied/moved, the user adds operations. There are two types
	/// of operations: 1. the type which copies/moves an attribute's data
	/// (i.e. the field will be copied but will not be an attribute in the
	/// target), 2. the type which copies/moves fields by name. For example:
	/// @verbatim
	/// rf-&gt;AddOperation(vtkRearrangeFields::COPY, "foo",
	///                  vtkRearrangeFields::DATA_OBJECT,
	///                  vtkRearrangeFields::POINT_DATA);
	/// @endverbatim
	/// adds an operation which copies a field (data array) called foo from
	/// the data object's field data to point data.
	/// The same can be done using Python and Java bindings by passing
	/// strings as arguments.
	/// @verbatim
	/// Operation types: COPY, MOVE
	/// AttributeTypes: SCALARS, VECTORS, NORMALS, TCOORDS, TENSORS
	/// Field data locations: DATA_OBJECT, POINT_DATA, CELL_DATA
	/// @endverbatim
	///
	/// @warning
	/// When using Java, Python or Visual Basic bindings, the array name
	/// can not be one of the  AttributeTypes when calling AddOperation() which
	/// takes strings as arguments. The wrapped command will
	/// always assume the string corresponds to an attribute type when
	/// the argument is one of the AttributeTypes. In this situation,
	/// use the AddOperation() which takes enums.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkFieldData vtkDataSet vtkDataObjectToDataSetFilter
	/// vtkDataSetAttributes vtkDataArray vtkAssignAttribute
	/// vtkSplitField vtkMergeFields
	/// </seealso>
	// Token: 0x02000991 RID: 2449
	public class vtkRearrangeFields : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601993F RID: 104767 RVA: 0x0023923F File Offset: 0x0023743F
		static vtkRearrangeFields()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRearrangeFields.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRearrangeFields"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019940 RID: 104768 RVA: 0x00239267 File Offset: 0x00237467
		public vtkRearrangeFields(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019941 RID: 104769
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRearrangeFields_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a new vtkRearrangeFields with an empty operation list.
		/// </summary>
		// Token: 0x06019942 RID: 104770 RVA: 0x00239278 File Offset: 0x00237478
		public new static vtkRearrangeFields New()
		{
			vtkRearrangeFields result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRearrangeFields.vtkRearrangeFields_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRearrangeFields)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create a new vtkRearrangeFields with an empty operation list.
		/// </summary>
		// Token: 0x06019943 RID: 104771 RVA: 0x002392CC File Offset: 0x002374CC
		public vtkRearrangeFields() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRearrangeFields.vtkRearrangeFields_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019944 RID: 104772 RVA: 0x00239310 File Offset: 0x00237510
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019945 RID: 104773
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRearrangeFields_AddOperation_01(HandleRef pThis, int operationType, int attributeType, int fromFieldLoc, int toFieldLoc);

		/// <summary>
		/// Add an operation which copies an attribute's field (data array) from
		/// one field data to another. Returns an operation id which can later
		/// be used to remove the operation.
		/// </summary>
		// Token: 0x06019946 RID: 104774 RVA: 0x0023931C File Offset: 0x0023751C
		public int AddOperation(int operationType, int attributeType, int fromFieldLoc, int toFieldLoc)
		{
			return vtkRearrangeFields.vtkRearrangeFields_AddOperation_01(base.GetCppThis(), operationType, attributeType, fromFieldLoc, toFieldLoc);
		}

		// Token: 0x06019947 RID: 104775
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRearrangeFields_AddOperation_02(HandleRef pThis, int operationType, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int fromFieldLoc, int toFieldLoc);

		/// <summary>
		/// Add an operation which copies a field (data array) from one field
		/// data to another. Returns an operation id which can later
		/// be used to remove the operation.
		/// </summary>
		// Token: 0x06019948 RID: 104776 RVA: 0x00239340 File Offset: 0x00237540
		public int AddOperation(int operationType, string name, int fromFieldLoc, int toFieldLoc)
		{
			return vtkRearrangeFields.vtkRearrangeFields_AddOperation_02(base.GetCppThis(), operationType, name, fromFieldLoc, toFieldLoc);
		}

		// Token: 0x06019949 RID: 104777
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRearrangeFields_AddOperation_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string operationType, [MarshalAs(UnmanagedType.LPUTF8Str)] string attributeType, [MarshalAs(UnmanagedType.LPUTF8Str)] string fromFieldLoc, [MarshalAs(UnmanagedType.LPUTF8Str)] string toFieldLoc);

		/// <summary>
		/// Helper method used by other language bindings. Allows the caller to
		/// specify arguments as strings instead of enums.Returns an operation id
		/// which can later be used to remove the operation.
		/// </summary>
		// Token: 0x0601994A RID: 104778 RVA: 0x00239364 File Offset: 0x00237564
		public int AddOperation(string operationType, string attributeType, string fromFieldLoc, string toFieldLoc)
		{
			return vtkRearrangeFields.vtkRearrangeFields_AddOperation_03(base.GetCppThis(), operationType, attributeType, fromFieldLoc, toFieldLoc);
		}

		// Token: 0x0601994B RID: 104779
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRearrangeFields_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601994C RID: 104780 RVA: 0x00239388 File Offset: 0x00237588
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRearrangeFields.vtkRearrangeFields_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601994D RID: 104781
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRearrangeFields_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601994E RID: 104782 RVA: 0x002393A8 File Offset: 0x002375A8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRearrangeFields.vtkRearrangeFields_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601994F RID: 104783
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRearrangeFields_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019950 RID: 104784 RVA: 0x002393C4 File Offset: 0x002375C4
		public override int IsA(string type)
		{
			return vtkRearrangeFields.vtkRearrangeFields_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06019951 RID: 104785
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRearrangeFields_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019952 RID: 104786 RVA: 0x002393E4 File Offset: 0x002375E4
		public new static int IsTypeOf(string type)
		{
			return vtkRearrangeFields.vtkRearrangeFields_IsTypeOf_07(type);
		}

		// Token: 0x06019953 RID: 104787
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRearrangeFields_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019954 RID: 104788 RVA: 0x00239400 File Offset: 0x00237600
		public new vtkRearrangeFields NewInstance()
		{
			vtkRearrangeFields result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRearrangeFields.vtkRearrangeFields_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRearrangeFields)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019955 RID: 104789
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRearrangeFields_RemoveAllOperations_10(HandleRef pThis);

		/// <summary>
		/// Remove all operations.
		/// </summary>
		// Token: 0x06019956 RID: 104790 RVA: 0x0023945A File Offset: 0x0023765A
		public void RemoveAllOperations()
		{
			vtkRearrangeFields.vtkRearrangeFields_RemoveAllOperations_10(base.GetCppThis());
		}

		// Token: 0x06019957 RID: 104791
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRearrangeFields_RemoveOperation_11(HandleRef pThis, int operationId);

		/// <summary>
		/// Remove an operation with the given id.
		/// </summary>
		// Token: 0x06019958 RID: 104792 RVA: 0x0023946C File Offset: 0x0023766C
		public int RemoveOperation(int operationId)
		{
			return vtkRearrangeFields.vtkRearrangeFields_RemoveOperation_11(base.GetCppThis(), operationId);
		}

		// Token: 0x06019959 RID: 104793
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRearrangeFields_RemoveOperation_12(HandleRef pThis, int operationType, int attributeType, int fromFieldLoc, int toFieldLoc);

		/// <summary>
		/// Remove an operation with the given signature. See AddOperation
		/// for details.
		/// </summary>
		// Token: 0x0601995A RID: 104794 RVA: 0x0023948C File Offset: 0x0023768C
		public int RemoveOperation(int operationType, int attributeType, int fromFieldLoc, int toFieldLoc)
		{
			return vtkRearrangeFields.vtkRearrangeFields_RemoveOperation_12(base.GetCppThis(), operationType, attributeType, fromFieldLoc, toFieldLoc);
		}

		// Token: 0x0601995B RID: 104795
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRearrangeFields_RemoveOperation_13(HandleRef pThis, int operationType, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int fromFieldLoc, int toFieldLoc);

		/// <summary>
		/// Remove an operation with the given signature. See AddOperation
		/// for details.
		/// </summary>
		// Token: 0x0601995C RID: 104796 RVA: 0x002394B0 File Offset: 0x002376B0
		public int RemoveOperation(int operationType, string name, int fromFieldLoc, int toFieldLoc)
		{
			return vtkRearrangeFields.vtkRearrangeFields_RemoveOperation_13(base.GetCppThis(), operationType, name, fromFieldLoc, toFieldLoc);
		}

		// Token: 0x0601995D RID: 104797
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRearrangeFields_RemoveOperation_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string operationType, [MarshalAs(UnmanagedType.LPUTF8Str)] string attributeType, [MarshalAs(UnmanagedType.LPUTF8Str)] string fromFieldLoc, [MarshalAs(UnmanagedType.LPUTF8Str)] string toFieldLoc);

		/// <summary>
		/// Remove an operation with the given signature. See AddOperation
		/// for details.
		/// </summary>
		// Token: 0x0601995E RID: 104798 RVA: 0x002394D4 File Offset: 0x002376D4
		public int RemoveOperation(string operationType, string attributeType, string fromFieldLoc, string toFieldLoc)
		{
			return vtkRearrangeFields.vtkRearrangeFields_RemoveOperation_14(base.GetCppThis(), operationType, attributeType, fromFieldLoc, toFieldLoc);
		}

		// Token: 0x0601995F RID: 104799
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRearrangeFields_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019960 RID: 104800 RVA: 0x002394F8 File Offset: 0x002376F8
		public new static vtkRearrangeFields SafeDownCast(vtkObjectBase o)
		{
			vtkRearrangeFields vtkRearrangeFields = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRearrangeFields.vtkRearrangeFields_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRearrangeFields = (vtkRearrangeFields)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRearrangeFields.Register(null);
				}
			}
			return vtkRearrangeFields;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BE3 RID: 7139
		public new const string MRFullTypeName = "Kitware.VTK.vtkRearrangeFields";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BE4 RID: 7140
		public new static readonly string MRClassNameKey = "class vtkRearrangeFields";

		/// <summary>
		/// Create a new vtkRearrangeFields with an empty operation list.
		/// </summary>
		// Token: 0x02000992 RID: 2450
		public enum FieldLocation
		{
			/// <summary>enum member</summary>
			// Token: 0x04001BE6 RID: 7142
			CELL_DATA = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001BE7 RID: 7143
			DATA_OBJECT = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001BE8 RID: 7144
			POINT_DATA
		}

		/// <summary>
		/// Remove all operations.
		/// </summary>
		// Token: 0x02000993 RID: 2451
		public enum FieldType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001BEA RID: 7146
			ATTRIBUTE = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001BEB RID: 7147
			NAME = 0
		}

		/// <summary>
		/// Create a new vtkRearrangeFields with an empty operation list.
		/// </summary>
		// Token: 0x02000994 RID: 2452
		public enum OperationType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001BED RID: 7149
			COPY,
			/// <summary>enum member</summary>
			// Token: 0x04001BEE RID: 7150
			MOVE
		}
	}
}
