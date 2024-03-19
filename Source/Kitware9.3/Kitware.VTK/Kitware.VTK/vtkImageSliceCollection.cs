using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageSliceCollection
	/// </summary>
	/// <remarks>
	///    a sorted list of image slice objects
	///
	/// vtkImageSliceCollection is a vtkPropCollection that maintains
	/// a list of vtkImageSlice objects that are sorted by LayerNumber.
	/// This allows the images to be rendered in the correct order.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageSlice vtkImageAssembly
	/// </seealso>
	// Token: 0x02000113 RID: 275
	public class vtkImageSliceCollection : vtkPropCollection
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003818 RID: 14360 RVA: 0x00051DE7 File Offset: 0x0004FFE7
		static vtkImageSliceCollection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageSliceCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageSliceCollection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003819 RID: 14361 RVA: 0x00051E0F File Offset: 0x0005000F
		public vtkImageSliceCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600381A RID: 14362
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSliceCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600381B RID: 14363 RVA: 0x00051E20 File Offset: 0x00050020
		public new static vtkImageSliceCollection New()
		{
			vtkImageSliceCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSliceCollection.vtkImageSliceCollection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSliceCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600381C RID: 14364 RVA: 0x00051E74 File Offset: 0x00050074
		public vtkImageSliceCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageSliceCollection.vtkImageSliceCollection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600381D RID: 14365 RVA: 0x00051EB8 File Offset: 0x000500B8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600381E RID: 14366
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSliceCollection_AddItem_01(HandleRef pThis, HandleRef a);

		/// <summary>
		/// Add an image to the list.  The new image is inserted in the list
		/// according to its layer number.
		/// </summary>
		// Token: 0x0600381F RID: 14367 RVA: 0x00051EC4 File Offset: 0x000500C4
		public void AddItem(vtkImageSlice a)
		{
			vtkImageSliceCollection.vtkImageSliceCollection_AddItem_01(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		// Token: 0x06003820 RID: 14368
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSliceCollection_GetNextImage_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard Collection methods.  You must call InitTraversal
		/// before calling GetNextImage.  If possible, you should use the
		/// GetNextImage method that takes a collection iterator instead.
		/// </summary>
		// Token: 0x06003821 RID: 14369 RVA: 0x00051EF4 File Offset: 0x000500F4
		public vtkImageSlice GetNextImage()
		{
			vtkImageSlice vtkImageSlice = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSliceCollection.vtkImageSliceCollection_GetNextImage_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageSlice = (vtkImageSlice)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageSlice.Register(null);
				}
			}
			return vtkImageSlice;
		}

		// Token: 0x06003822 RID: 14370
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSliceCollection_GetNextItem_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Access routine provided for compatibility with previous
		/// versions of VTK.  Please use the GetNextImage() variant
		/// where possible.
		/// </summary>
		// Token: 0x06003823 RID: 14371 RVA: 0x00051F64 File Offset: 0x00050164
		public vtkImageSlice GetNextItem()
		{
			vtkImageSlice vtkImageSlice = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSliceCollection.vtkImageSliceCollection_GetNextItem_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageSlice = (vtkImageSlice)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageSlice.Register(null);
				}
			}
			return vtkImageSlice;
		}

		// Token: 0x06003824 RID: 14372
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageSliceCollection_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003825 RID: 14373 RVA: 0x00051FD4 File Offset: 0x000501D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageSliceCollection.vtkImageSliceCollection_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06003826 RID: 14374
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageSliceCollection_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003827 RID: 14375 RVA: 0x00051FF4 File Offset: 0x000501F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageSliceCollection.vtkImageSliceCollection_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06003828 RID: 14376
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSliceCollection_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003829 RID: 14377 RVA: 0x00052010 File Offset: 0x00050210
		public override int IsA(string type)
		{
			return vtkImageSliceCollection.vtkImageSliceCollection_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600382A RID: 14378
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSliceCollection_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600382B RID: 14379 RVA: 0x00052030 File Offset: 0x00050230
		public new static int IsTypeOf(string type)
		{
			return vtkImageSliceCollection.vtkImageSliceCollection_IsTypeOf_07(type);
		}

		// Token: 0x0600382C RID: 14380
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSliceCollection_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600382D RID: 14381 RVA: 0x0005204C File Offset: 0x0005024C
		public new vtkImageSliceCollection NewInstance()
		{
			vtkImageSliceCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSliceCollection.vtkImageSliceCollection_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSliceCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600382E RID: 14382
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSliceCollection_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600382F RID: 14383 RVA: 0x000520A8 File Offset: 0x000502A8
		public new static vtkImageSliceCollection SafeDownCast(vtkObjectBase o)
		{
			vtkImageSliceCollection vtkImageSliceCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSliceCollection.vtkImageSliceCollection_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageSliceCollection = (vtkImageSliceCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageSliceCollection.Register(null);
				}
			}
			return vtkImageSliceCollection;
		}

		// Token: 0x06003830 RID: 14384
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSliceCollection_Sort_11(HandleRef pThis);

		/// <summary>
		/// Sorts the vtkImageSliceCollection by layer number.  Smaller layer
		/// numbers are first. Layer numbers can be any integer value. Items
		/// with the same layer number will be kept in the same relative order
		/// as before the sort.
		/// </summary>
		// Token: 0x06003831 RID: 14385 RVA: 0x00052127 File Offset: 0x00050327
		public void Sort()
		{
			vtkImageSliceCollection.vtkImageSliceCollection_Sort_11(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400065E RID: 1630
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageSliceCollection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400065F RID: 1631
		public new static readonly string MRClassNameKey = "class vtkImageSliceCollection";
	}
}
