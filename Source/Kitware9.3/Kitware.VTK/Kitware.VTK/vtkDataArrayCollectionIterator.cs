using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataArrayCollectionIterator
	/// </summary>
	/// <remarks>
	///    iterator through a vtkDataArrayCollection.
	///
	/// vtkDataArrayCollectionIterator provides an implementation of
	/// vtkCollectionIterator which allows the items to be retrieved with
	/// the proper subclass pointer type for vtkDataArrayCollection.
	/// </remarks>
	// Token: 0x02000B4D RID: 2893
	public class vtkDataArrayCollectionIterator : vtkCollectionIterator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E38E RID: 123790 RVA: 0x002AC137 File Offset: 0x002AA337
		static vtkDataArrayCollectionIterator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataArrayCollectionIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataArrayCollectionIterator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E38F RID: 123791 RVA: 0x002AC15F File Offset: 0x002AA35F
		public vtkDataArrayCollectionIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E390 RID: 123792
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArrayCollectionIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E391 RID: 123793 RVA: 0x002AC170 File Offset: 0x002AA370
		public new static vtkDataArrayCollectionIterator New()
		{
			vtkDataArrayCollectionIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataArrayCollectionIterator.vtkDataArrayCollectionIterator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataArrayCollectionIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E392 RID: 123794 RVA: 0x002AC1C4 File Offset: 0x002AA3C4
		public vtkDataArrayCollectionIterator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataArrayCollectionIterator.vtkDataArrayCollectionIterator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E393 RID: 123795 RVA: 0x002AC208 File Offset: 0x002AA408
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E394 RID: 123796
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArrayCollectionIterator_GetDataArray_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the item at the current iterator position.  Valid only when
		/// IsDoneWithTraversal() returns 1.
		/// </summary>
		// Token: 0x0601E395 RID: 123797 RVA: 0x002AC214 File Offset: 0x002AA414
		public vtkDataArray GetDataArray()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataArrayCollectionIterator.vtkDataArrayCollectionIterator_GetDataArray_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601E396 RID: 123798
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataArrayCollectionIterator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E397 RID: 123799 RVA: 0x002AC284 File Offset: 0x002AA484
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataArrayCollectionIterator.vtkDataArrayCollectionIterator_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601E398 RID: 123800
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataArrayCollectionIterator_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E399 RID: 123801 RVA: 0x002AC2A4 File Offset: 0x002AA4A4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataArrayCollectionIterator.vtkDataArrayCollectionIterator_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601E39A RID: 123802
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataArrayCollectionIterator_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E39B RID: 123803 RVA: 0x002AC2C0 File Offset: 0x002AA4C0
		public override int IsA(string type)
		{
			return vtkDataArrayCollectionIterator.vtkDataArrayCollectionIterator_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601E39C RID: 123804
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataArrayCollectionIterator_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E39D RID: 123805 RVA: 0x002AC2E0 File Offset: 0x002AA4E0
		public new static int IsTypeOf(string type)
		{
			return vtkDataArrayCollectionIterator.vtkDataArrayCollectionIterator_IsTypeOf_05(type);
		}

		// Token: 0x0601E39E RID: 123806
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArrayCollectionIterator_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E39F RID: 123807 RVA: 0x002AC2FC File Offset: 0x002AA4FC
		public new vtkDataArrayCollectionIterator NewInstance()
		{
			vtkDataArrayCollectionIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataArrayCollectionIterator.vtkDataArrayCollectionIterator_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataArrayCollectionIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E3A0 RID: 123808
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArrayCollectionIterator_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E3A1 RID: 123809 RVA: 0x002AC358 File Offset: 0x002AA558
		public new static vtkDataArrayCollectionIterator SafeDownCast(vtkObjectBase o)
		{
			vtkDataArrayCollectionIterator vtkDataArrayCollectionIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataArrayCollectionIterator.vtkDataArrayCollectionIterator_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArrayCollectionIterator = (vtkDataArrayCollectionIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArrayCollectionIterator.Register(null);
				}
			}
			return vtkDataArrayCollectionIterator;
		}

		// Token: 0x0601E3A2 RID: 123810
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArrayCollectionIterator_SetCollection_09(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the collection over which to iterate.
		/// </summary>
		// Token: 0x0601E3A3 RID: 123811 RVA: 0x002AC3D8 File Offset: 0x002AA5D8
		public override void SetCollection(vtkCollection arg0)
		{
			vtkDataArrayCollectionIterator.vtkDataArrayCollectionIterator_SetCollection_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601E3A4 RID: 123812
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArrayCollectionIterator_SetCollection_10(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the collection over which to iterate.
		/// </summary>
		// Token: 0x0601E3A5 RID: 123813 RVA: 0x002AC408 File Offset: 0x002AA608
		public void SetCollection(vtkDataArrayCollection arg0)
		{
			vtkDataArrayCollectionIterator.vtkDataArrayCollectionIterator_SetCollection_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04002076 RID: 8310
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataArrayCollectionIterator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04002077 RID: 8311
		public new static readonly string MRClassNameKey = "class vtkDataArrayCollectionIterator";
	}
}
