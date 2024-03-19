using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellTypes
	/// </summary>
	/// <remarks>
	///    object provides direct access to cells in vtkCellArray and type information
	///
	/// This class is a supplemental object to vtkCellArray to allow random access
	/// into cells as well as representing cell type information.  The "location"
	/// field is the location in the vtkCellArray list in terms of an integer
	/// offset.  An integer offset was used instead of a pointer for easy storage
	/// and inter-process communication. The type information is defined in the
	/// file vtkCellType.h.
	///
	/// @warning
	/// Sometimes this class is used to pass type information independent of the
	/// random access (i.e., location) information. For example, see
	/// vtkDataSet::GetCellTypes(). If you use the class in this way, you can use
	/// a location value of -1.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCellArray vtkCellLinks
	/// </seealso>
	// Token: 0x02000A2C RID: 2604
	public class vtkCellTypes : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B1F2 RID: 111090 RVA: 0x0025DE07 File Offset: 0x0025C007
		static vtkCellTypes()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellTypes.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellTypes"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B1F3 RID: 111091 RVA: 0x0025DE2F File Offset: 0x0025C02F
		public vtkCellTypes(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B1F4 RID: 111092
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellTypes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B1F5 RID: 111093 RVA: 0x0025DE40 File Offset: 0x0025C040
		public new static vtkCellTypes New()
		{
			vtkCellTypes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellTypes.vtkCellTypes_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellTypes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B1F6 RID: 111094 RVA: 0x0025DE94 File Offset: 0x0025C094
		public vtkCellTypes() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellTypes.vtkCellTypes_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B1F7 RID: 111095 RVA: 0x0025DED8 File Offset: 0x0025C0D8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B1F8 RID: 111096
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellTypes_Allocate_01(HandleRef pThis, long sz, long ext);

		/// <summary>
		/// Allocate memory for this array. Delete old storage only if necessary.
		/// </summary>
		// Token: 0x0601B1F9 RID: 111097 RVA: 0x0025DEE4 File Offset: 0x0025C0E4
		public int Allocate(long sz, long ext)
		{
			return vtkCellTypes.vtkCellTypes_Allocate_01(base.GetCppThis(), sz, ext);
		}

		// Token: 0x0601B1FA RID: 111098
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellTypes_DeepCopy_02(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Standard DeepCopy method.  Since this object contains no reference
		/// to other objects, there is no ShallowCopy.
		/// </summary>
		// Token: 0x0601B1FB RID: 111099 RVA: 0x0025DF08 File Offset: 0x0025C108
		public void DeepCopy(vtkCellTypes src)
		{
			vtkCellTypes.vtkCellTypes_DeepCopy_02(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0601B1FC RID: 111100
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellTypes_DeleteCell_03(HandleRef pThis, long cellId);

		/// <summary>
		/// Delete cell by setting to nullptr cell type.
		/// </summary>
		// Token: 0x0601B1FD RID: 111101 RVA: 0x0025DF37 File Offset: 0x0025C137
		public void DeleteCell(long cellId)
		{
			vtkCellTypes.vtkCellTypes_DeleteCell_03(base.GetCppThis(), cellId);
		}

		// Token: 0x0601B1FE RID: 111102
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkCellTypes_GetActualMemorySize_04(HandleRef pThis);

		/// <summary>
		/// Return the memory in kibibytes (1024 bytes) consumed by this cell type array.
		/// Used to support streaming and reading/writing data. The value
		/// returned is guaranteed to be greater than or equal to the memory
		/// required to actually represent the data represented by this object.
		/// The information returned is valid only after the pipeline has
		/// been updated.
		/// </summary>
		// Token: 0x0601B1FF RID: 111103 RVA: 0x0025DF48 File Offset: 0x0025C148
		public uint GetActualMemorySize()
		{
			return vtkCellTypes.vtkCellTypes_GetActualMemorySize_04(base.GetCppThis());
		}

		// Token: 0x0601B200 RID: 111104
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellTypes_GetCellLocationsArray_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Methods for obtaining the arrays representing types and locations.
		/// </summary>
		// Token: 0x0601B201 RID: 111105 RVA: 0x0025DF68 File Offset: 0x0025C168
		public vtkIdTypeArray GetCellLocationsArray()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellTypes.vtkCellTypes_GetCellLocationsArray_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601B202 RID: 111106
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellTypes_GetCellType_06(HandleRef pThis, long cellId);

		/// <summary>
		/// Return the type of cell.
		/// </summary>
		// Token: 0x0601B203 RID: 111107 RVA: 0x0025DFD8 File Offset: 0x0025C1D8
		public byte GetCellType(long cellId)
		{
			return vtkCellTypes.vtkCellTypes_GetCellType_06(base.GetCppThis(), cellId);
		}

		// Token: 0x0601B204 RID: 111108
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellTypes_GetCellTypesArray_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Methods for obtaining the arrays representing types and locations.
		/// </summary>
		// Token: 0x0601B205 RID: 111109 RVA: 0x0025DFF8 File Offset: 0x0025C1F8
		public vtkUnsignedCharArray GetCellTypesArray()
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellTypes.vtkCellTypes_GetCellTypesArray_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601B206 RID: 111110
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellTypes_GetClassNameFromTypeId_08(int typeId);

		/// <summary>
		/// Given an int (as defined in vtkCellType.h) identifier for a class
		/// return it's classname.
		/// </summary>
		// Token: 0x0601B207 RID: 111111 RVA: 0x0025E068 File Offset: 0x0025C268
		public static string GetClassNameFromTypeId(int typeId)
		{
			string s = Marshal.PtrToStringAnsi(vtkCellTypes.vtkCellTypes_GetClassNameFromTypeId_08(typeId));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601B208 RID: 111112
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellTypes_GetDimension_09(byte type);

		/// <summary>
		/// Get the dimension of a cell.
		/// </summary>
		// Token: 0x0601B209 RID: 111113 RVA: 0x0025E0A0 File Offset: 0x0025C2A0
		public static int GetDimension(byte type)
		{
			return vtkCellTypes.vtkCellTypes_GetDimension_09(type);
		}

		// Token: 0x0601B20A RID: 111114
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellTypes_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B20B RID: 111115 RVA: 0x0025E0BC File Offset: 0x0025C2BC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellTypes.vtkCellTypes_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x0601B20C RID: 111116
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellTypes_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B20D RID: 111117 RVA: 0x0025E0DC File Offset: 0x0025C2DC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellTypes.vtkCellTypes_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x0601B20E RID: 111118
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellTypes_GetNumberOfTypes_12(HandleRef pThis);

		/// <summary>
		/// Return the number of types in the list.
		/// </summary>
		// Token: 0x0601B20F RID: 111119 RVA: 0x0025E0F8 File Offset: 0x0025C2F8
		public long GetNumberOfTypes()
		{
			return vtkCellTypes.vtkCellTypes_GetNumberOfTypes_12(base.GetCppThis());
		}

		// Token: 0x0601B210 RID: 111120
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellTypes_GetTypeIdFromClassName_13([MarshalAs(UnmanagedType.LPUTF8Str)] string classname);

		/// <summary>
		/// Given a data object classname, return it's int identified (as
		/// defined in vtkCellType.h)
		/// </summary>
		// Token: 0x0601B211 RID: 111121 RVA: 0x0025E118 File Offset: 0x0025C318
		public static int GetTypeIdFromClassName(string classname)
		{
			return vtkCellTypes.vtkCellTypes_GetTypeIdFromClassName_13(classname);
		}

		// Token: 0x0601B212 RID: 111122
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellTypes_InsertCell_14(HandleRef pThis, long id, byte type, long loc);

		/// <summary>
		/// Add a cell at specified id.
		/// </summary>
		// Token: 0x0601B213 RID: 111123 RVA: 0x0025E132 File Offset: 0x0025C332
		public void InsertCell(long id, byte type, long loc)
		{
			vtkCellTypes.vtkCellTypes_InsertCell_14(base.GetCppThis(), id, type, loc);
		}

		// Token: 0x0601B214 RID: 111124
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellTypes_InsertNextCell_15(HandleRef pThis, byte type, long loc);

		/// <summary>
		/// Add a cell to the object in the next available slot.
		/// </summary>
		// Token: 0x0601B215 RID: 111125 RVA: 0x0025E144 File Offset: 0x0025C344
		public long InsertNextCell(byte type, long loc)
		{
			return vtkCellTypes.vtkCellTypes_InsertNextCell_15(base.GetCppThis(), type, loc);
		}

		// Token: 0x0601B216 RID: 111126
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellTypes_InsertNextType_16(HandleRef pThis, byte type);

		/// <summary>
		/// Add the type specified to the end of the list. Range checking is performed.
		/// </summary>
		// Token: 0x0601B217 RID: 111127 RVA: 0x0025E168 File Offset: 0x0025C368
		public long InsertNextType(byte type)
		{
			return vtkCellTypes.vtkCellTypes_InsertNextType_16(base.GetCppThis(), type);
		}

		// Token: 0x0601B218 RID: 111128
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellTypes_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B219 RID: 111129 RVA: 0x0025E188 File Offset: 0x0025C388
		public override int IsA(string type)
		{
			return vtkCellTypes.vtkCellTypes_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x0601B21A RID: 111130
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellTypes_IsLinear_18(byte type);

		/// <summary>
		/// This convenience method is a fast check to determine if a cell type
		/// represents a linear or nonlinear cell.  This is generally much more
		/// efficient than getting the appropriate vtkCell and checking its IsLinear
		/// method.
		/// </summary>
		// Token: 0x0601B21B RID: 111131 RVA: 0x0025E1A8 File Offset: 0x0025C3A8
		public static int IsLinear(byte type)
		{
			return vtkCellTypes.vtkCellTypes_IsLinear_18(type);
		}

		// Token: 0x0601B21C RID: 111132
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellTypes_IsType_19(HandleRef pThis, byte type);

		/// <summary>
		/// Return 1 if type specified is contained in list; 0 otherwise.
		/// </summary>
		// Token: 0x0601B21D RID: 111133 RVA: 0x0025E1C4 File Offset: 0x0025C3C4
		public int IsType(byte type)
		{
			return vtkCellTypes.vtkCellTypes_IsType_19(base.GetCppThis(), type);
		}

		// Token: 0x0601B21E RID: 111134
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellTypes_IsTypeOf_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B21F RID: 111135 RVA: 0x0025E1E4 File Offset: 0x0025C3E4
		public new static int IsTypeOf(string type)
		{
			return vtkCellTypes.vtkCellTypes_IsTypeOf_20(type);
		}

		// Token: 0x0601B220 RID: 111136
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellTypes_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B221 RID: 111137 RVA: 0x0025E200 File Offset: 0x0025C400
		public new vtkCellTypes NewInstance()
		{
			vtkCellTypes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellTypes.vtkCellTypes_NewInstance_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellTypes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B222 RID: 111138
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellTypes_Reset_23(HandleRef pThis);

		/// <summary>
		/// Initialize object without releasing memory.
		/// </summary>
		// Token: 0x0601B223 RID: 111139 RVA: 0x0025E25A File Offset: 0x0025C45A
		public void Reset()
		{
			vtkCellTypes.vtkCellTypes_Reset_23(base.GetCppThis());
		}

		// Token: 0x0601B224 RID: 111140
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellTypes_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B225 RID: 111141 RVA: 0x0025E26C File Offset: 0x0025C46C
		public new static vtkCellTypes SafeDownCast(vtkObjectBase o)
		{
			vtkCellTypes vtkCellTypes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellTypes.vtkCellTypes_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellTypes = (vtkCellTypes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellTypes.Register(null);
				}
			}
			return vtkCellTypes;
		}

		// Token: 0x0601B226 RID: 111142
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellTypes_SetCellTypes_25(HandleRef pThis, long ncells, HandleRef cellTypes);

		/// <summary>
		/// Specify a group of cell types.
		/// </summary>
		// Token: 0x0601B227 RID: 111143 RVA: 0x0025E2EC File Offset: 0x0025C4EC
		public void SetCellTypes(long ncells, vtkUnsignedCharArray cellTypes)
		{
			vtkCellTypes.vtkCellTypes_SetCellTypes_25(base.GetCppThis(), ncells, (cellTypes == null) ? default(HandleRef) : cellTypes.GetCppThis());
		}

		// Token: 0x0601B228 RID: 111144
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellTypes_Squeeze_26(HandleRef pThis);

		/// <summary>
		/// Reclaim any extra memory.
		/// </summary>
		// Token: 0x0601B229 RID: 111145 RVA: 0x0025E31C File Offset: 0x0025C51C
		public void Squeeze()
		{
			vtkCellTypes.vtkCellTypes_Squeeze_26(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D4B RID: 7499
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellTypes";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D4C RID: 7500
		public new static readonly string MRClassNameKey = "class vtkCellTypes";
	}
}
