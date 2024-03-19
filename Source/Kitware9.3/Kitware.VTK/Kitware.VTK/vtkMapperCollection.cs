using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMapperCollection
	/// </summary>
	/// <remarks>
	///    an ordered list of mappers
	///
	/// vtkMapperCollection represents and provides methods to manipulate a list of
	/// mappers (i.e., vtkMapper and subclasses). The list is ordered and duplicate
	/// entries are not prevented.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkMapper vtkCollection
	/// </seealso>
	// Token: 0x020007F5 RID: 2037
	public class vtkMapperCollection : vtkCollection
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014EEE RID: 85742 RVA: 0x001D9B1B File Offset: 0x001D7D1B
		static vtkMapperCollection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMapperCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMapperCollection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014EEF RID: 85743 RVA: 0x001D9B43 File Offset: 0x001D7D43
		public vtkMapperCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014EF0 RID: 85744
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapperCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014EF1 RID: 85745 RVA: 0x001D9B54 File Offset: 0x001D7D54
		public new static vtkMapperCollection New()
		{
			vtkMapperCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMapperCollection.vtkMapperCollection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMapperCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014EF2 RID: 85746 RVA: 0x001D9BA8 File Offset: 0x001D7DA8
		public vtkMapperCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMapperCollection.vtkMapperCollection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014EF3 RID: 85747 RVA: 0x001D9BEC File Offset: 0x001D7DEC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014EF4 RID: 85748
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMapperCollection_AddItem_01(HandleRef pThis, HandleRef a);

		/// <summary>
		/// Add an mapper to the bottom of the list.
		/// </summary>
		// Token: 0x06014EF5 RID: 85749 RVA: 0x001D9BF8 File Offset: 0x001D7DF8
		public void AddItem(vtkMapper a)
		{
			vtkMapperCollection.vtkMapperCollection_AddItem_01(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		// Token: 0x06014EF6 RID: 85750
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapperCollection_GetLastItem_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the last mapper in the list.
		/// </summary>
		// Token: 0x06014EF7 RID: 85751 RVA: 0x001D9C28 File Offset: 0x001D7E28
		public vtkMapper GetLastItem()
		{
			vtkMapper vtkMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMapperCollection.vtkMapperCollection_GetLastItem_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMapper = (vtkMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMapper.Register(null);
				}
			}
			return vtkMapper;
		}

		// Token: 0x06014EF8 RID: 85752
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapperCollection_GetNextItem_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the next mapper in the list.
		/// </summary>
		// Token: 0x06014EF9 RID: 85753 RVA: 0x001D9C98 File Offset: 0x001D7E98
		public vtkMapper GetNextItem()
		{
			vtkMapper vtkMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMapperCollection.vtkMapperCollection_GetNextItem_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMapper = (vtkMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMapper.Register(null);
				}
			}
			return vtkMapper;
		}

		// Token: 0x06014EFA RID: 85754
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMapperCollection_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014EFB RID: 85755 RVA: 0x001D9D08 File Offset: 0x001D7F08
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMapperCollection.vtkMapperCollection_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06014EFC RID: 85756
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMapperCollection_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014EFD RID: 85757 RVA: 0x001D9D28 File Offset: 0x001D7F28
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMapperCollection.vtkMapperCollection_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06014EFE RID: 85758
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMapperCollection_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014EFF RID: 85759 RVA: 0x001D9D44 File Offset: 0x001D7F44
		public override int IsA(string type)
		{
			return vtkMapperCollection.vtkMapperCollection_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06014F00 RID: 85760
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMapperCollection_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014F01 RID: 85761 RVA: 0x001D9D64 File Offset: 0x001D7F64
		public new static int IsTypeOf(string type)
		{
			return vtkMapperCollection.vtkMapperCollection_IsTypeOf_07(type);
		}

		// Token: 0x06014F02 RID: 85762
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapperCollection_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014F03 RID: 85763 RVA: 0x001D9D80 File Offset: 0x001D7F80
		public new vtkMapperCollection NewInstance()
		{
			vtkMapperCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMapperCollection.vtkMapperCollection_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMapperCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014F04 RID: 85764
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMapperCollection_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014F05 RID: 85765 RVA: 0x001D9DDC File Offset: 0x001D7FDC
		public new static vtkMapperCollection SafeDownCast(vtkObjectBase o)
		{
			vtkMapperCollection vtkMapperCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMapperCollection.vtkMapperCollection_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMapperCollection = (vtkMapperCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMapperCollection.Register(null);
				}
			}
			return vtkMapperCollection;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400182E RID: 6190
		public new const string MRFullTypeName = "Kitware.VTK.vtkMapperCollection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400182F RID: 6191
		public new static readonly string MRClassNameKey = "class vtkMapperCollection";
	}
}
