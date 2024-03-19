using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkIdListCollection
	/// </summary>
	/// <remarks>
	///    maintain an ordered list of IdList objects
	///
	/// vtkIdListCollection is an object that creates and manipulates lists of
	/// IdLists. See also vtkCollection and subclasses.
	/// </remarks>
	// Token: 0x02000B56 RID: 2902
	public class vtkIdListCollection : vtkCollection
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E4E2 RID: 124130 RVA: 0x002ADDC7 File Offset: 0x002ABFC7
		static vtkIdListCollection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkIdListCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkIdListCollection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E4E3 RID: 124131 RVA: 0x002ADDEF File Offset: 0x002ABFEF
		public vtkIdListCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E4E4 RID: 124132
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIdListCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E4E5 RID: 124133 RVA: 0x002ADE00 File Offset: 0x002AC000
		public new static vtkIdListCollection New()
		{
			vtkIdListCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIdListCollection.vtkIdListCollection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIdListCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E4E6 RID: 124134 RVA: 0x002ADE54 File Offset: 0x002AC054
		public vtkIdListCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkIdListCollection.vtkIdListCollection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E4E7 RID: 124135 RVA: 0x002ADE98 File Offset: 0x002AC098
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E4E8 RID: 124136
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIdListCollection_AddItem_01(HandleRef pThis, HandleRef ds);

		/// <summary>
		/// Add an IdList to the bottom of the list.
		/// </summary>
		// Token: 0x0601E4E9 RID: 124137 RVA: 0x002ADEA4 File Offset: 0x002AC0A4
		public void AddItem(vtkIdList ds)
		{
			vtkIdListCollection.vtkIdListCollection_AddItem_01(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		// Token: 0x0601E4EA RID: 124138
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIdListCollection_GetItem_02(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the ith IdList in the list.
		/// </summary>
		// Token: 0x0601E4EB RID: 124139 RVA: 0x002ADED4 File Offset: 0x002AC0D4
		public vtkIdList GetItem(int i)
		{
			vtkIdList vtkIdList = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIdListCollection.vtkIdListCollection_GetItem_02(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdList = (vtkIdList)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdList.Register(null);
				}
			}
			return vtkIdList;
		}

		// Token: 0x0601E4EC RID: 124140
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIdListCollection_GetNextItem_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the next IdList in the list.
		/// </summary>
		// Token: 0x0601E4ED RID: 124141 RVA: 0x002ADF44 File Offset: 0x002AC144
		public vtkIdList GetNextItem()
		{
			vtkIdList vtkIdList = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIdListCollection.vtkIdListCollection_GetNextItem_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdList = (vtkIdList)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdList.Register(null);
				}
			}
			return vtkIdList;
		}

		// Token: 0x0601E4EE RID: 124142
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIdListCollection_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E4EF RID: 124143 RVA: 0x002ADFB4 File Offset: 0x002AC1B4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkIdListCollection.vtkIdListCollection_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601E4F0 RID: 124144
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIdListCollection_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E4F1 RID: 124145 RVA: 0x002ADFD4 File Offset: 0x002AC1D4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkIdListCollection.vtkIdListCollection_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601E4F2 RID: 124146
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIdListCollection_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E4F3 RID: 124147 RVA: 0x002ADFF0 File Offset: 0x002AC1F0
		public override int IsA(string type)
		{
			return vtkIdListCollection.vtkIdListCollection_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601E4F4 RID: 124148
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIdListCollection_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E4F5 RID: 124149 RVA: 0x002AE010 File Offset: 0x002AC210
		public new static int IsTypeOf(string type)
		{
			return vtkIdListCollection.vtkIdListCollection_IsTypeOf_07(type);
		}

		// Token: 0x0601E4F6 RID: 124150
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIdListCollection_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E4F7 RID: 124151 RVA: 0x002AE02C File Offset: 0x002AC22C
		public new vtkIdListCollection NewInstance()
		{
			vtkIdListCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIdListCollection.vtkIdListCollection_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIdListCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E4F8 RID: 124152
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIdListCollection_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E4F9 RID: 124153 RVA: 0x002AE088 File Offset: 0x002AC288
		public new static vtkIdListCollection SafeDownCast(vtkObjectBase o)
		{
			vtkIdListCollection vtkIdListCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIdListCollection.vtkIdListCollection_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdListCollection = (vtkIdListCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdListCollection.Register(null);
				}
			}
			return vtkIdListCollection;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400208B RID: 8331
		public new const string MRFullTypeName = "Kitware.VTK.vtkIdListCollection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400208C RID: 8332
		public new static readonly string MRClassNameKey = "class vtkIdListCollection";
	}
}
