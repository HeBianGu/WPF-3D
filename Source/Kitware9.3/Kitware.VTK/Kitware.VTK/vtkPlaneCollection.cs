using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPlaneCollection
	/// </summary>
	/// <remarks>
	///    maintain a list of planes
	///
	/// vtkPlaneCollection is an object that creates and manipulates
	/// lists of objects of type vtkPlane.
	/// </remarks>
	/// <seealso>
	///
	/// vtkCollection
	/// </seealso>
	// Token: 0x02000A98 RID: 2712
	public class vtkPlaneCollection : vtkCollection
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C74B RID: 116555 RVA: 0x0027F5CF File Offset: 0x0027D7CF
		static vtkPlaneCollection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlaneCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlaneCollection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C74C RID: 116556 RVA: 0x0027F5F7 File Offset: 0x0027D7F7
		public vtkPlaneCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C74D RID: 116557
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaneCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C74E RID: 116558 RVA: 0x0027F608 File Offset: 0x0027D808
		public new static vtkPlaneCollection New()
		{
			vtkPlaneCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlaneCollection.vtkPlaneCollection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlaneCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C74F RID: 116559 RVA: 0x0027F65C File Offset: 0x0027D85C
		public vtkPlaneCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPlaneCollection.vtkPlaneCollection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C750 RID: 116560 RVA: 0x0027F6A0 File Offset: 0x0027D8A0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C751 RID: 116561
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPlaneCollection_AddItem_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Add a plane to the list.
		/// </summary>
		// Token: 0x0601C752 RID: 116562 RVA: 0x0027F6AC File Offset: 0x0027D8AC
		public void AddItem(vtkPlane arg0)
		{
			vtkPlaneCollection.vtkPlaneCollection_AddItem_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601C753 RID: 116563
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaneCollection_GetItem_02(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the ith plane in the list.
		/// </summary>
		// Token: 0x0601C754 RID: 116564 RVA: 0x0027F6DC File Offset: 0x0027D8DC
		public vtkPlane GetItem(int i)
		{
			vtkPlane vtkPlane = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlaneCollection.vtkPlaneCollection_GetItem_02(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlane = (vtkPlane)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlane.Register(null);
				}
			}
			return vtkPlane;
		}

		// Token: 0x0601C755 RID: 116565
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaneCollection_GetNextItem_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the next plane in the list.
		/// </summary>
		// Token: 0x0601C756 RID: 116566 RVA: 0x0027F74C File Offset: 0x0027D94C
		public vtkPlane GetNextItem()
		{
			vtkPlane vtkPlane = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlaneCollection.vtkPlaneCollection_GetNextItem_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlane = (vtkPlane)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlane.Register(null);
				}
			}
			return vtkPlane;
		}

		// Token: 0x0601C757 RID: 116567
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlaneCollection_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C758 RID: 116568 RVA: 0x0027F7BC File Offset: 0x0027D9BC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPlaneCollection.vtkPlaneCollection_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601C759 RID: 116569
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPlaneCollection_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C75A RID: 116570 RVA: 0x0027F7DC File Offset: 0x0027D9DC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPlaneCollection.vtkPlaneCollection_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601C75B RID: 116571
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlaneCollection_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C75C RID: 116572 RVA: 0x0027F7F8 File Offset: 0x0027D9F8
		public override int IsA(string type)
		{
			return vtkPlaneCollection.vtkPlaneCollection_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601C75D RID: 116573
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPlaneCollection_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C75E RID: 116574 RVA: 0x0027F818 File Offset: 0x0027DA18
		public new static int IsTypeOf(string type)
		{
			return vtkPlaneCollection.vtkPlaneCollection_IsTypeOf_07(type);
		}

		// Token: 0x0601C75F RID: 116575
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaneCollection_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C760 RID: 116576 RVA: 0x0027F834 File Offset: 0x0027DA34
		public new vtkPlaneCollection NewInstance()
		{
			vtkPlaneCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlaneCollection.vtkPlaneCollection_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlaneCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C761 RID: 116577
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPlaneCollection_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C762 RID: 116578 RVA: 0x0027F890 File Offset: 0x0027DA90
		public new static vtkPlaneCollection SafeDownCast(vtkObjectBase o)
		{
			vtkPlaneCollection vtkPlaneCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPlaneCollection.vtkPlaneCollection_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlaneCollection = (vtkPlaneCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlaneCollection.Register(null);
				}
			}
			return vtkPlaneCollection;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E31 RID: 7729
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlaneCollection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E32 RID: 7730
		public new static readonly string MRClassNameKey = "class vtkPlaneCollection";
	}
}
