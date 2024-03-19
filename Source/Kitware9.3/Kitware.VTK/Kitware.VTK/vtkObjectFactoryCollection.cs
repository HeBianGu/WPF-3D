using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkObjectFactoryCollection
	/// </summary>
	/// <remarks>
	///    maintain a list of object factories
	///
	/// vtkObjectFactoryCollection is an object that creates and manipulates
	/// ordered lists of objects of type vtkObjectFactory.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCollection vtkObjectFactory
	/// </seealso>
	// Token: 0x02000B76 RID: 2934
	public class vtkObjectFactoryCollection : vtkCollection
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E9F5 RID: 125429 RVA: 0x002B6C4B File Offset: 0x002B4E4B
		static vtkObjectFactoryCollection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkObjectFactoryCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkObjectFactoryCollection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E9F6 RID: 125430 RVA: 0x002B6C73 File Offset: 0x002B4E73
		public vtkObjectFactoryCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E9F7 RID: 125431
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkObjectFactoryCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E9F8 RID: 125432 RVA: 0x002B6C84 File Offset: 0x002B4E84
		public new static vtkObjectFactoryCollection New()
		{
			vtkObjectFactoryCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkObjectFactoryCollection.vtkObjectFactoryCollection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkObjectFactoryCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E9F9 RID: 125433 RVA: 0x002B6CD8 File Offset: 0x002B4ED8
		public vtkObjectFactoryCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkObjectFactoryCollection.vtkObjectFactoryCollection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E9FA RID: 125434 RVA: 0x002B6D1C File Offset: 0x002B4F1C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E9FB RID: 125435
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObjectFactoryCollection_AddItem_01(HandleRef pThis, HandleRef t);

		/// <summary>
		/// Add an ObjectFactory the bottom of the list.
		/// </summary>
		// Token: 0x0601E9FC RID: 125436 RVA: 0x002B6D28 File Offset: 0x002B4F28
		public void AddItem(vtkObjectFactory t)
		{
			vtkObjectFactoryCollection.vtkObjectFactoryCollection_AddItem_01(base.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis());
		}

		// Token: 0x0601E9FD RID: 125437
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkObjectFactoryCollection_GetNextItem_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the next ObjectFactory in the list. Return nullptr when the end of the
		/// list is reached.
		/// </summary>
		// Token: 0x0601E9FE RID: 125438 RVA: 0x002B6D58 File Offset: 0x002B4F58
		public vtkObjectFactory GetNextItem()
		{
			vtkObjectFactory vtkObjectFactory = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkObjectFactoryCollection.vtkObjectFactoryCollection_GetNextItem_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkObjectFactory = (vtkObjectFactory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkObjectFactory.Register(null);
				}
			}
			return vtkObjectFactory;
		}

		// Token: 0x0601E9FF RID: 125439
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkObjectFactoryCollection_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EA00 RID: 125440 RVA: 0x002B6DC8 File Offset: 0x002B4FC8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkObjectFactoryCollection.vtkObjectFactoryCollection_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601EA01 RID: 125441
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkObjectFactoryCollection_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EA02 RID: 125442 RVA: 0x002B6DE8 File Offset: 0x002B4FE8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkObjectFactoryCollection.vtkObjectFactoryCollection_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601EA03 RID: 125443
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkObjectFactoryCollection_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EA04 RID: 125444 RVA: 0x002B6E04 File Offset: 0x002B5004
		public override int IsA(string type)
		{
			return vtkObjectFactoryCollection.vtkObjectFactoryCollection_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601EA05 RID: 125445
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkObjectFactoryCollection_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EA06 RID: 125446 RVA: 0x002B6E24 File Offset: 0x002B5024
		public new static int IsTypeOf(string type)
		{
			return vtkObjectFactoryCollection.vtkObjectFactoryCollection_IsTypeOf_06(type);
		}

		// Token: 0x0601EA07 RID: 125447
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkObjectFactoryCollection_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EA08 RID: 125448 RVA: 0x002B6E40 File Offset: 0x002B5040
		public new vtkObjectFactoryCollection NewInstance()
		{
			vtkObjectFactoryCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkObjectFactoryCollection.vtkObjectFactoryCollection_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkObjectFactoryCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601EA09 RID: 125449
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkObjectFactoryCollection_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EA0A RID: 125450 RVA: 0x002B6E9C File Offset: 0x002B509C
		public new static vtkObjectFactoryCollection SafeDownCast(vtkObjectBase o)
		{
			vtkObjectFactoryCollection vtkObjectFactoryCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkObjectFactoryCollection.vtkObjectFactoryCollection_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkObjectFactoryCollection = (vtkObjectFactoryCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkObjectFactoryCollection.Register(null);
				}
			}
			return vtkObjectFactoryCollection;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020D0 RID: 8400
		public new const string MRFullTypeName = "Kitware.VTK.vtkObjectFactoryCollection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020D1 RID: 8401
		public new static readonly string MRClassNameKey = "class vtkObjectFactoryCollection";
	}
}
