using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTextPropertyCollection
	/// </summary>
	/// <remarks>
	///    an ordered list of vtkTextProperty objects.
	///
	/// vtkTextPropertyCollection represents and provides methods to manipulate a
	/// list of TextProperty objects. The list is ordered and
	/// duplicate entries are not prevented.
	/// </remarks>
	/// <seealso>
	///
	/// vtkTextProperty vtkCollection
	/// </seealso>
	// Token: 0x0200081B RID: 2075
	public class vtkTextPropertyCollection : vtkCollection
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015613 RID: 87571 RVA: 0x001E429D File Offset: 0x001E249D
		static vtkTextPropertyCollection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTextPropertyCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextPropertyCollection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015614 RID: 87572 RVA: 0x001E42C5 File Offset: 0x001E24C5
		public vtkTextPropertyCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015615 RID: 87573
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextPropertyCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015616 RID: 87574 RVA: 0x001E42D4 File Offset: 0x001E24D4
		public new static vtkTextPropertyCollection New()
		{
			vtkTextPropertyCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextPropertyCollection.vtkTextPropertyCollection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextPropertyCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015617 RID: 87575 RVA: 0x001E4328 File Offset: 0x001E2528
		public vtkTextPropertyCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTextPropertyCollection.vtkTextPropertyCollection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015618 RID: 87576 RVA: 0x001E436C File Offset: 0x001E256C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015619 RID: 87577
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextPropertyCollection_AddItem_01(HandleRef pThis, HandleRef a);

		/// <summary>
		/// Add a vtkTextProperty to the bottom of the list.
		/// </summary>
		// Token: 0x0601561A RID: 87578 RVA: 0x001E4378 File Offset: 0x001E2578
		public void AddItem(vtkTextProperty a)
		{
			vtkTextPropertyCollection.vtkTextPropertyCollection_AddItem_01(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		// Token: 0x0601561B RID: 87579
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextPropertyCollection_GetItem_02(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the vtkTextProperty at the specified index.
		/// </summary>
		// Token: 0x0601561C RID: 87580 RVA: 0x001E43A8 File Offset: 0x001E25A8
		public vtkTextProperty GetItem(int idx)
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextPropertyCollection.vtkTextPropertyCollection_GetItem_02(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x0601561D RID: 87581
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextPropertyCollection_GetLastItem_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the last TextProperty in the list.
		/// </summary>
		// Token: 0x0601561E RID: 87582 RVA: 0x001E4418 File Offset: 0x001E2618
		public vtkTextProperty GetLastItem()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextPropertyCollection.vtkTextPropertyCollection_GetLastItem_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x0601561F RID: 87583
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextPropertyCollection_GetNextItem_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the next vtkTextProperty in the list.
		/// </summary>
		// Token: 0x06015620 RID: 87584 RVA: 0x001E4488 File Offset: 0x001E2688
		public vtkTextProperty GetNextItem()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextPropertyCollection.vtkTextPropertyCollection_GetNextItem_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x06015621 RID: 87585
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTextPropertyCollection_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015622 RID: 87586 RVA: 0x001E44F8 File Offset: 0x001E26F8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTextPropertyCollection.vtkTextPropertyCollection_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06015623 RID: 87587
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTextPropertyCollection_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015624 RID: 87588 RVA: 0x001E4518 File Offset: 0x001E2718
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTextPropertyCollection.vtkTextPropertyCollection_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06015625 RID: 87589
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextPropertyCollection_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015626 RID: 87590 RVA: 0x001E4534 File Offset: 0x001E2734
		public override int IsA(string type)
		{
			return vtkTextPropertyCollection.vtkTextPropertyCollection_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06015627 RID: 87591
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextPropertyCollection_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015628 RID: 87592 RVA: 0x001E4554 File Offset: 0x001E2754
		public new static int IsTypeOf(string type)
		{
			return vtkTextPropertyCollection.vtkTextPropertyCollection_IsTypeOf_08(type);
		}

		// Token: 0x06015629 RID: 87593
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextPropertyCollection_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601562A RID: 87594 RVA: 0x001E4570 File Offset: 0x001E2770
		public new vtkTextPropertyCollection NewInstance()
		{
			vtkTextPropertyCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextPropertyCollection.vtkTextPropertyCollection_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextPropertyCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601562B RID: 87595
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextPropertyCollection_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601562C RID: 87596 RVA: 0x001E45CC File Offset: 0x001E27CC
		public new static vtkTextPropertyCollection SafeDownCast(vtkObjectBase o)
		{
			vtkTextPropertyCollection vtkTextPropertyCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextPropertyCollection.vtkTextPropertyCollection_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextPropertyCollection = (vtkTextPropertyCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextPropertyCollection.Register(null);
				}
			}
			return vtkTextPropertyCollection;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400187E RID: 6270
		public new const string MRFullTypeName = "Kitware.VTK.vtkTextPropertyCollection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400187F RID: 6271
		public new static readonly string MRClassNameKey = "class vtkTextPropertyCollection";
	}
}
