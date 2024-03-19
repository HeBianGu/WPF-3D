using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPropCollection
	/// </summary>
	/// <remarks>
	///    an ordered list of Props
	///
	/// vtkPropCollection represents and provides methods to manipulate a list of
	/// Props (i.e., vtkProp and subclasses). The list is ordered and duplicate
	/// entries are not prevented.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkProp vtkCollection
	/// </seealso>
	// Token: 0x02000112 RID: 274
	public class vtkPropCollection : vtkCollection
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060037FE RID: 14334 RVA: 0x00051A8A File Offset: 0x0004FC8A
		static vtkPropCollection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPropCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPropCollection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060037FF RID: 14335 RVA: 0x00051AB2 File Offset: 0x0004FCB2
		public vtkPropCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003800 RID: 14336
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPropCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003801 RID: 14337 RVA: 0x00051AC0 File Offset: 0x0004FCC0
		public new static vtkPropCollection New()
		{
			vtkPropCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPropCollection.vtkPropCollection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPropCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003802 RID: 14338 RVA: 0x00051B14 File Offset: 0x0004FD14
		public vtkPropCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPropCollection.vtkPropCollection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003803 RID: 14339 RVA: 0x00051B58 File Offset: 0x0004FD58
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003804 RID: 14340
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPropCollection_AddItem_01(HandleRef pThis, HandleRef a);

		/// <summary>
		/// Add a Prop to the bottom of the list.
		/// </summary>
		// Token: 0x06003805 RID: 14341 RVA: 0x00051B64 File Offset: 0x0004FD64
		public void AddItem(vtkProp a)
		{
			vtkPropCollection.vtkPropCollection_AddItem_01(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		// Token: 0x06003806 RID: 14342
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPropCollection_GetLastProp_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the last Prop in the list.
		/// </summary>
		// Token: 0x06003807 RID: 14343 RVA: 0x00051B94 File Offset: 0x0004FD94
		public vtkProp GetLastProp()
		{
			vtkProp vtkProp = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPropCollection.vtkPropCollection_GetLastProp_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp = (vtkProp)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp.Register(null);
				}
			}
			return vtkProp;
		}

		// Token: 0x06003808 RID: 14344
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPropCollection_GetNextProp_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the next Prop in the list.
		/// </summary>
		// Token: 0x06003809 RID: 14345 RVA: 0x00051C04 File Offset: 0x0004FE04
		public vtkProp GetNextProp()
		{
			vtkProp vtkProp = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPropCollection.vtkPropCollection_GetNextProp_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp = (vtkProp)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp.Register(null);
				}
			}
			return vtkProp;
		}

		// Token: 0x0600380A RID: 14346
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPropCollection_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600380B RID: 14347 RVA: 0x00051C74 File Offset: 0x0004FE74
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPropCollection.vtkPropCollection_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600380C RID: 14348
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPropCollection_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600380D RID: 14349 RVA: 0x00051C94 File Offset: 0x0004FE94
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPropCollection.vtkPropCollection_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600380E RID: 14350
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPropCollection_GetNumberOfPaths_06(HandleRef pThis);

		/// <summary>
		/// Get the number of paths contained in this list. (Recall that a
		/// vtkProp can consist of multiple parts.) Used in picking and other
		/// activities to get the parts of composite entities like vtkAssembly
		/// or vtkPropAssembly.
		/// </summary>
		// Token: 0x0600380F RID: 14351 RVA: 0x00051CB0 File Offset: 0x0004FEB0
		public int GetNumberOfPaths()
		{
			return vtkPropCollection.vtkPropCollection_GetNumberOfPaths_06(base.GetCppThis());
		}

		// Token: 0x06003810 RID: 14352
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPropCollection_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003811 RID: 14353 RVA: 0x00051CD0 File Offset: 0x0004FED0
		public override int IsA(string type)
		{
			return vtkPropCollection.vtkPropCollection_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06003812 RID: 14354
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPropCollection_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003813 RID: 14355 RVA: 0x00051CF0 File Offset: 0x0004FEF0
		public new static int IsTypeOf(string type)
		{
			return vtkPropCollection.vtkPropCollection_IsTypeOf_08(type);
		}

		// Token: 0x06003814 RID: 14356
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPropCollection_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003815 RID: 14357 RVA: 0x00051D0C File Offset: 0x0004FF0C
		public new vtkPropCollection NewInstance()
		{
			vtkPropCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPropCollection.vtkPropCollection_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPropCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003816 RID: 14358
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPropCollection_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003817 RID: 14359 RVA: 0x00051D68 File Offset: 0x0004FF68
		public new static vtkPropCollection SafeDownCast(vtkObjectBase o)
		{
			vtkPropCollection vtkPropCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPropCollection.vtkPropCollection_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPropCollection = (vtkPropCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPropCollection.Register(null);
				}
			}
			return vtkPropCollection;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400065C RID: 1628
		public new const string MRFullTypeName = "Kitware.VTK.vtkPropCollection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400065D RID: 1629
		public new static readonly string MRClassNameKey = "class vtkPropCollection";
	}
}
