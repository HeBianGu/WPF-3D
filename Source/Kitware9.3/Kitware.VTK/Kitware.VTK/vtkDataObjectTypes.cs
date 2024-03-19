using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataObject
	/// </summary>
	/// <remarks>
	///    helper class to get VTK data object types as string and instantiate them
	///
	/// vtkDataObjectTypes is a helper class that supports conversion between
	/// integer types defined in vtkType.h and string names as well as creation
	/// of data objects from either integer or string types. This class has
	/// to be updated every time a new data type is added to VTK.
	/// </remarks>
	/// <seealso>
	///
	/// vtkDataObject
	/// </seealso>
	// Token: 0x02000A3C RID: 2620
	public class vtkDataObjectTypes : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B4C3 RID: 111811 RVA: 0x00262707 File Offset: 0x00260907
		static vtkDataObjectTypes()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataObjectTypes.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataObjectTypes"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B4C4 RID: 111812 RVA: 0x0026272F File Offset: 0x0026092F
		public vtkDataObjectTypes(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B4C5 RID: 111813
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectTypes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B4C6 RID: 111814 RVA: 0x00262740 File Offset: 0x00260940
		public new static vtkDataObjectTypes New()
		{
			vtkDataObjectTypes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectTypes.vtkDataObjectTypes_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObjectTypes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B4C7 RID: 111815 RVA: 0x00262794 File Offset: 0x00260994
		public vtkDataObjectTypes() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataObjectTypes.vtkDataObjectTypes_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B4C8 RID: 111816 RVA: 0x002627D8 File Offset: 0x002609D8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B4C9 RID: 111817
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectTypes_GetClassNameFromTypeId_01(int typeId);

		/// <summary>
		/// Given an int (as defined in vtkType.h) identifier for a class
		/// return it's classname.
		/// </summary>
		// Token: 0x0601B4CA RID: 111818 RVA: 0x002627E4 File Offset: 0x002609E4
		public static string GetClassNameFromTypeId(int typeId)
		{
			string s = Marshal.PtrToStringAnsi(vtkDataObjectTypes.vtkDataObjectTypes_GetClassNameFromTypeId_01(typeId));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601B4CB RID: 111819
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectTypes_GetCommonBaseTypeId_02(int typeA, int typeB);

		/// <summary>
		/// Given two data types, returns the closest common data type.
		/// If both data types ids are valid, at worse, this will return
		/// `VTK_DATA_OBJECT`. If one of the types is invalid (or unknown),
		/// simply returns the valid (or known) type. If both are invalid, returns -1.
		/// </summary>
		// Token: 0x0601B4CC RID: 111820 RVA: 0x0026281C File Offset: 0x00260A1C
		public static int GetCommonBaseTypeId(int typeA, int typeB)
		{
			return vtkDataObjectTypes.vtkDataObjectTypes_GetCommonBaseTypeId_02(typeA, typeB);
		}

		// Token: 0x0601B4CD RID: 111821
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataObjectTypes_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B4CE RID: 111822 RVA: 0x00262838 File Offset: 0x00260A38
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataObjectTypes.vtkDataObjectTypes_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601B4CF RID: 111823
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataObjectTypes_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B4D0 RID: 111824 RVA: 0x00262858 File Offset: 0x00260A58
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataObjectTypes.vtkDataObjectTypes_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601B4D1 RID: 111825
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectTypes_GetTypeIdFromClassName_05([MarshalAs(UnmanagedType.LPUTF8Str)] string classname);

		/// <summary>
		/// Given a data object classname, return it's int identified (as
		/// defined in vtkType.h)
		/// </summary>
		// Token: 0x0601B4D2 RID: 111826 RVA: 0x00262874 File Offset: 0x00260A74
		public static int GetTypeIdFromClassName(string classname)
		{
			return vtkDataObjectTypes.vtkDataObjectTypes_GetTypeIdFromClassName_05(classname);
		}

		// Token: 0x0601B4D3 RID: 111827
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectTypes_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B4D4 RID: 111828 RVA: 0x00262890 File Offset: 0x00260A90
		public override int IsA(string type)
		{
			return vtkDataObjectTypes.vtkDataObjectTypes_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601B4D5 RID: 111829
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectTypes_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B4D6 RID: 111830 RVA: 0x002628B0 File Offset: 0x00260AB0
		public new static int IsTypeOf(string type)
		{
			return vtkDataObjectTypes.vtkDataObjectTypes_IsTypeOf_07(type);
		}

		// Token: 0x0601B4D7 RID: 111831
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectTypes_NewDataObject_09([MarshalAs(UnmanagedType.LPUTF8Str)] string classname, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create (New) and return a data object of the given classname.
		/// </summary>
		// Token: 0x0601B4D8 RID: 111832 RVA: 0x002628CC File Offset: 0x00260ACC
		public static vtkDataObject NewDataObject(string classname)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectTypes.vtkDataObjectTypes_NewDataObject_09(classname, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x0601B4D9 RID: 111833
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectTypes_NewDataObject_10(int typeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create (New) and return a data object of the given type id.
		/// </summary>
		// Token: 0x0601B4DA RID: 111834 RVA: 0x00262938 File Offset: 0x00260B38
		public static vtkDataObject NewDataObject(int typeId)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectTypes.vtkDataObjectTypes_NewDataObject_10(typeId, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x0601B4DB RID: 111835
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectTypes_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B4DC RID: 111836 RVA: 0x002629A4 File Offset: 0x00260BA4
		public new vtkDataObjectTypes NewInstance()
		{
			vtkDataObjectTypes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectTypes.vtkDataObjectTypes_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObjectTypes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B4DD RID: 111837
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectTypes_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B4DE RID: 111838 RVA: 0x00262A00 File Offset: 0x00260C00
		public new static vtkDataObjectTypes SafeDownCast(vtkObjectBase o)
		{
			vtkDataObjectTypes vtkDataObjectTypes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectTypes.vtkDataObjectTypes_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObjectTypes = (vtkDataObjectTypes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObjectTypes.Register(null);
				}
			}
			return vtkDataObjectTypes;
		}

		// Token: 0x0601B4DF RID: 111839
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataObjectTypes_TypeIdIsA_13(int typeId, int targetTypeId);

		/// <summary>
		/// Create (New) and return a data object of the given type id.
		/// </summary>
		// Token: 0x0601B4E0 RID: 111840 RVA: 0x00262A80 File Offset: 0x00260C80
		public static bool TypeIdIsA(int typeId, int targetTypeId)
		{
			return vtkDataObjectTypes.vtkDataObjectTypes_TypeIdIsA_13(typeId, targetTypeId) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D6C RID: 7532
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataObjectTypes";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D6D RID: 7533
		public new static readonly string MRClassNameKey = "class vtkDataObjectTypes";
	}
}
