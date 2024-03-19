using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkActor2DCollection
	/// </summary>
	/// <remarks>
	///     a list of 2D actors
	///
	/// vtkActor2DCollection is a subclass of vtkCollection.  vtkActor2DCollection
	/// maintains a collection of vtkActor2D objects that is sorted by layer
	/// number, with lower layer numbers at the start of the list.  This allows
	/// the vtkActor2D objects to be rendered in the correct order.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkActor2D vtkCollection
	/// </seealso>
	// Token: 0x020007C6 RID: 1990
	public class vtkActor2DCollection : vtkPropCollection
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060145DC RID: 83420 RVA: 0x001CCF0C File Offset: 0x001CB10C
		static vtkActor2DCollection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkActor2DCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkActor2DCollection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060145DD RID: 83421 RVA: 0x001CCF34 File Offset: 0x001CB134
		public vtkActor2DCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060145DE RID: 83422
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActor2DCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Destructor for the vtkActor2DCollection class. This removes all
		/// objects from the collection.
		/// </summary>
		// Token: 0x060145DF RID: 83423 RVA: 0x001CCF44 File Offset: 0x001CB144
		public new static vtkActor2DCollection New()
		{
			vtkActor2DCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActor2DCollection.vtkActor2DCollection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkActor2DCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Destructor for the vtkActor2DCollection class. This removes all
		/// objects from the collection.
		/// </summary>
		// Token: 0x060145E0 RID: 83424 RVA: 0x001CCF98 File Offset: 0x001CB198
		public vtkActor2DCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkActor2DCollection.vtkActor2DCollection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060145E1 RID: 83425 RVA: 0x001CCFDC File Offset: 0x001CB1DC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060145E2 RID: 83426
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor2DCollection_AddItem_01(HandleRef pThis, HandleRef a);

		/// <summary>
		/// Add an actor to the list.  The new actor is inserted in the list
		/// according to it's layer number.
		/// </summary>
		// Token: 0x060145E3 RID: 83427 RVA: 0x001CCFE8 File Offset: 0x001CB1E8
		public void AddItem(vtkActor2D a)
		{
			vtkActor2DCollection.vtkActor2DCollection_AddItem_01(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		// Token: 0x060145E4 RID: 83428
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActor2DCollection_GetLastActor2D_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard Collection methods
		/// </summary>
		// Token: 0x060145E5 RID: 83429 RVA: 0x001CD018 File Offset: 0x001CB218
		public vtkActor2D GetLastActor2D()
		{
			vtkActor2D vtkActor2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActor2DCollection.vtkActor2DCollection_GetLastActor2D_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor2D = (vtkActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor2D.Register(null);
				}
			}
			return vtkActor2D;
		}

		// Token: 0x060145E6 RID: 83430
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActor2DCollection_GetLastItem_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Access routines that are provided for compatibility with previous
		/// version of VTK.  Please use the GetNextActor2D(), GetLastActor2D()
		/// variants where possible.
		/// </summary>
		// Token: 0x060145E7 RID: 83431 RVA: 0x001CD088 File Offset: 0x001CB288
		public vtkActor2D GetLastItem()
		{
			vtkActor2D vtkActor2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActor2DCollection.vtkActor2DCollection_GetLastItem_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor2D = (vtkActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor2D.Register(null);
				}
			}
			return vtkActor2D;
		}

		// Token: 0x060145E8 RID: 83432
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActor2DCollection_GetNextActor2D_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard Collection methods
		/// </summary>
		// Token: 0x060145E9 RID: 83433 RVA: 0x001CD0F8 File Offset: 0x001CB2F8
		public vtkActor2D GetNextActor2D()
		{
			vtkActor2D vtkActor2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActor2DCollection.vtkActor2DCollection_GetNextActor2D_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor2D = (vtkActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor2D.Register(null);
				}
			}
			return vtkActor2D;
		}

		// Token: 0x060145EA RID: 83434
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActor2DCollection_GetNextItem_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Access routines that are provided for compatibility with previous
		/// version of VTK.  Please use the GetNextActor2D(), GetLastActor2D()
		/// variants where possible.
		/// </summary>
		// Token: 0x060145EB RID: 83435 RVA: 0x001CD168 File Offset: 0x001CB368
		public vtkActor2D GetNextItem()
		{
			vtkActor2D vtkActor2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActor2DCollection.vtkActor2DCollection_GetNextItem_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor2D = (vtkActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor2D.Register(null);
				}
			}
			return vtkActor2D;
		}

		// Token: 0x060145EC RID: 83436
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkActor2DCollection_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Destructor for the vtkActor2DCollection class. This removes all
		/// objects from the collection.
		/// </summary>
		// Token: 0x060145ED RID: 83437 RVA: 0x001CD1D8 File Offset: 0x001CB3D8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkActor2DCollection.vtkActor2DCollection_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x060145EE RID: 83438
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkActor2DCollection_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Destructor for the vtkActor2DCollection class. This removes all
		/// objects from the collection.
		/// </summary>
		// Token: 0x060145EF RID: 83439 RVA: 0x001CD1F8 File Offset: 0x001CB3F8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkActor2DCollection.vtkActor2DCollection_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x060145F0 RID: 83440
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkActor2DCollection_IndexOfFirstOccurence_08(HandleRef pThis, HandleRef a);

		/// <summary>
		/// Standard Collection methods
		/// </summary>
		// Token: 0x060145F1 RID: 83441 RVA: 0x001CD214 File Offset: 0x001CB414
		public int IndexOfFirstOccurence(vtkActor2D a)
		{
			return vtkActor2DCollection.vtkActor2DCollection_IndexOfFirstOccurence_08(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		// Token: 0x060145F2 RID: 83442
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkActor2DCollection_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Destructor for the vtkActor2DCollection class. This removes all
		/// objects from the collection.
		/// </summary>
		// Token: 0x060145F3 RID: 83443 RVA: 0x001CD248 File Offset: 0x001CB448
		public override int IsA(string type)
		{
			return vtkActor2DCollection.vtkActor2DCollection_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x060145F4 RID: 83444
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkActor2DCollection_IsItemPresent_10(HandleRef pThis, HandleRef a);

		/// <summary>
		/// Standard Collection methods
		/// </summary>
		// Token: 0x060145F5 RID: 83445 RVA: 0x001CD268 File Offset: 0x001CB468
		public int IsItemPresent(vtkActor2D a)
		{
			return vtkActor2DCollection.vtkActor2DCollection_IsItemPresent_10(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		// Token: 0x060145F6 RID: 83446
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkActor2DCollection_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Destructor for the vtkActor2DCollection class. This removes all
		/// objects from the collection.
		/// </summary>
		// Token: 0x060145F7 RID: 83447 RVA: 0x001CD29C File Offset: 0x001CB49C
		public new static int IsTypeOf(string type)
		{
			return vtkActor2DCollection.vtkActor2DCollection_IsTypeOf_11(type);
		}

		// Token: 0x060145F8 RID: 83448
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActor2DCollection_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Destructor for the vtkActor2DCollection class. This removes all
		/// objects from the collection.
		/// </summary>
		// Token: 0x060145F9 RID: 83449 RVA: 0x001CD2B8 File Offset: 0x001CB4B8
		public new vtkActor2DCollection NewInstance()
		{
			vtkActor2DCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActor2DCollection.vtkActor2DCollection_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkActor2DCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060145FA RID: 83450
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor2DCollection_RenderOverlay_14(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Sort and then render the collection of 2D actors.
		/// </summary>
		// Token: 0x060145FB RID: 83451 RVA: 0x001CD314 File Offset: 0x001CB514
		public void RenderOverlay(vtkViewport viewport)
		{
			vtkActor2DCollection.vtkActor2DCollection_RenderOverlay_14(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x060145FC RID: 83452
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActor2DCollection_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Destructor for the vtkActor2DCollection class. This removes all
		/// objects from the collection.
		/// </summary>
		// Token: 0x060145FD RID: 83453 RVA: 0x001CD344 File Offset: 0x001CB544
		public new static vtkActor2DCollection SafeDownCast(vtkObjectBase o)
		{
			vtkActor2DCollection vtkActor2DCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActor2DCollection.vtkActor2DCollection_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor2DCollection = (vtkActor2DCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor2DCollection.Register(null);
				}
			}
			return vtkActor2DCollection;
		}

		// Token: 0x060145FE RID: 83454
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActor2DCollection_Sort_16(HandleRef pThis);

		/// <summary>
		/// Sorts the vtkActor2DCollection by layer number.  Smaller layer
		/// numbers are first.  Layer numbers can be any integer value.
		/// </summary>
		// Token: 0x060145FF RID: 83455 RVA: 0x001CD3C3 File Offset: 0x001CB5C3
		public void Sort()
		{
			vtkActor2DCollection.vtkActor2DCollection_Sort_16(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017AA RID: 6058
		public new const string MRFullTypeName = "Kitware.VTK.vtkActor2DCollection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017AB RID: 6059
		public new static readonly string MRClassNameKey = "class vtkActor2DCollection";
	}
}
