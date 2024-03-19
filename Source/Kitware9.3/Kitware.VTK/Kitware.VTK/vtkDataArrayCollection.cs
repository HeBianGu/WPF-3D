using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataArrayCollection
	/// </summary>
	/// <remarks>
	///    maintain an ordered list of dataarray objects
	///
	/// vtkDataArrayCollection is an object that creates and manipulates lists of
	/// datasets. See also vtkCollection and subclasses.
	/// </remarks>
	// Token: 0x02000B4C RID: 2892
	public class vtkDataArrayCollection : vtkCollection
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E376 RID: 123766 RVA: 0x002ABDF7 File Offset: 0x002A9FF7
		static vtkDataArrayCollection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataArrayCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataArrayCollection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E377 RID: 123767 RVA: 0x002ABE1F File Offset: 0x002AA01F
		public vtkDataArrayCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E378 RID: 123768
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArrayCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E379 RID: 123769 RVA: 0x002ABE30 File Offset: 0x002AA030
		public new static vtkDataArrayCollection New()
		{
			vtkDataArrayCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataArrayCollection.vtkDataArrayCollection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataArrayCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E37A RID: 123770 RVA: 0x002ABE84 File Offset: 0x002AA084
		public vtkDataArrayCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataArrayCollection.vtkDataArrayCollection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E37B RID: 123771 RVA: 0x002ABEC8 File Offset: 0x002AA0C8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E37C RID: 123772
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArrayCollection_AddItem_01(HandleRef pThis, HandleRef ds);

		/// <summary>
		/// Add a dataarray to the bottom of the list.
		/// </summary>
		// Token: 0x0601E37D RID: 123773 RVA: 0x002ABED4 File Offset: 0x002AA0D4
		public void AddItem(vtkDataArray ds)
		{
			vtkDataArrayCollection.vtkDataArrayCollection_AddItem_01(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		// Token: 0x0601E37E RID: 123774
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArrayCollection_GetItem_02(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the ith dataarray in the list.
		/// </summary>
		// Token: 0x0601E37F RID: 123775 RVA: 0x002ABF04 File Offset: 0x002AA104
		public vtkDataArray GetItem(int i)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataArrayCollection.vtkDataArrayCollection_GetItem_02(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601E380 RID: 123776
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArrayCollection_GetNextItem_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the next dataarray in the list.
		/// </summary>
		// Token: 0x0601E381 RID: 123777 RVA: 0x002ABF74 File Offset: 0x002AA174
		public vtkDataArray GetNextItem()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataArrayCollection.vtkDataArrayCollection_GetNextItem_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601E382 RID: 123778
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataArrayCollection_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E383 RID: 123779 RVA: 0x002ABFE4 File Offset: 0x002AA1E4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataArrayCollection.vtkDataArrayCollection_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601E384 RID: 123780
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataArrayCollection_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E385 RID: 123781 RVA: 0x002AC004 File Offset: 0x002AA204
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataArrayCollection.vtkDataArrayCollection_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601E386 RID: 123782
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataArrayCollection_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E387 RID: 123783 RVA: 0x002AC020 File Offset: 0x002AA220
		public override int IsA(string type)
		{
			return vtkDataArrayCollection.vtkDataArrayCollection_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601E388 RID: 123784
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataArrayCollection_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E389 RID: 123785 RVA: 0x002AC040 File Offset: 0x002AA240
		public new static int IsTypeOf(string type)
		{
			return vtkDataArrayCollection.vtkDataArrayCollection_IsTypeOf_07(type);
		}

		// Token: 0x0601E38A RID: 123786
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArrayCollection_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E38B RID: 123787 RVA: 0x002AC05C File Offset: 0x002AA25C
		public new vtkDataArrayCollection NewInstance()
		{
			vtkDataArrayCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataArrayCollection.vtkDataArrayCollection_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataArrayCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E38C RID: 123788
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArrayCollection_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E38D RID: 123789 RVA: 0x002AC0B8 File Offset: 0x002AA2B8
		public new static vtkDataArrayCollection SafeDownCast(vtkObjectBase o)
		{
			vtkDataArrayCollection vtkDataArrayCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataArrayCollection.vtkDataArrayCollection_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArrayCollection = (vtkDataArrayCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArrayCollection.Register(null);
				}
			}
			return vtkDataArrayCollection;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04002074 RID: 8308
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataArrayCollection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04002075 RID: 8309
		public new static readonly string MRClassNameKey = "class vtkDataArrayCollection";
	}
}
