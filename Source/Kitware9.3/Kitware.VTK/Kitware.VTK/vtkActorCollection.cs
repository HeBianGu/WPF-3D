using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkActorCollection
	/// </summary>
	/// <remarks>
	///    an ordered list of actors
	///
	/// vtkActorCollection represents and provides methods to manipulate a list of
	/// actors (i.e., vtkActor and subclasses). The list is ordered and duplicate
	/// entries are not prevented.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkActor vtkCollection
	/// </seealso>
	// Token: 0x020007C7 RID: 1991
	public class vtkActorCollection : vtkPropCollection
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014600 RID: 83456 RVA: 0x001CD3D2 File Offset: 0x001CB5D2
		static vtkActorCollection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkActorCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkActorCollection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014601 RID: 83457 RVA: 0x001CD3FA File Offset: 0x001CB5FA
		public vtkActorCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014602 RID: 83458
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActorCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014603 RID: 83459 RVA: 0x001CD408 File Offset: 0x001CB608
		public new static vtkActorCollection New()
		{
			vtkActorCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActorCollection.vtkActorCollection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkActorCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014604 RID: 83460 RVA: 0x001CD45C File Offset: 0x001CB65C
		public vtkActorCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkActorCollection.vtkActorCollection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014605 RID: 83461 RVA: 0x001CD4A0 File Offset: 0x001CB6A0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014606 RID: 83462
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActorCollection_AddItem_01(HandleRef pThis, HandleRef a);

		/// <summary>
		/// Add an actor to the bottom of the list.
		/// </summary>
		// Token: 0x06014607 RID: 83463 RVA: 0x001CD4AC File Offset: 0x001CB6AC
		public void AddItem(vtkActor a)
		{
			vtkActorCollection.vtkActorCollection_AddItem_01(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		// Token: 0x06014608 RID: 83464
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkActorCollection_ApplyProperties_02(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Apply properties to all actors in this collection.
		/// </summary>
		// Token: 0x06014609 RID: 83465 RVA: 0x001CD4DC File Offset: 0x001CB6DC
		public void ApplyProperties(vtkProperty p)
		{
			vtkActorCollection.vtkActorCollection_ApplyProperties_02(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0601460A RID: 83466
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActorCollection_GetLastActor_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the last actor in the list.
		/// </summary>
		// Token: 0x0601460B RID: 83467 RVA: 0x001CD50C File Offset: 0x001CB70C
		public vtkActor GetLastActor()
		{
			vtkActor vtkActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActorCollection.vtkActorCollection_GetLastActor_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor = (vtkActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor.Register(null);
				}
			}
			return vtkActor;
		}

		// Token: 0x0601460C RID: 83468
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActorCollection_GetLastItem_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Access routines that are provided for compatibility with previous
		/// version of VTK.  Please use the GetNextActor(), GetLastActor() variants
		/// where possible.
		/// </summary>
		// Token: 0x0601460D RID: 83469 RVA: 0x001CD57C File Offset: 0x001CB77C
		public vtkActor GetLastItem()
		{
			vtkActor vtkActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActorCollection.vtkActorCollection_GetLastItem_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor = (vtkActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor.Register(null);
				}
			}
			return vtkActor;
		}

		// Token: 0x0601460E RID: 83470
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActorCollection_GetNextActor_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the next actor in the list.
		/// </summary>
		// Token: 0x0601460F RID: 83471 RVA: 0x001CD5EC File Offset: 0x001CB7EC
		public vtkActor GetNextActor()
		{
			vtkActor vtkActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActorCollection.vtkActorCollection_GetNextActor_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor = (vtkActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor.Register(null);
				}
			}
			return vtkActor;
		}

		// Token: 0x06014610 RID: 83472
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActorCollection_GetNextItem_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Access routines that are provided for compatibility with previous
		/// version of VTK.  Please use the GetNextActor(), GetLastActor() variants
		/// where possible.
		/// </summary>
		// Token: 0x06014611 RID: 83473 RVA: 0x001CD65C File Offset: 0x001CB85C
		public vtkActor GetNextItem()
		{
			vtkActor vtkActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActorCollection.vtkActorCollection_GetNextItem_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor = (vtkActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor.Register(null);
				}
			}
			return vtkActor;
		}

		// Token: 0x06014612 RID: 83474
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkActorCollection_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014613 RID: 83475 RVA: 0x001CD6CC File Offset: 0x001CB8CC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkActorCollection.vtkActorCollection_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06014614 RID: 83476
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkActorCollection_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014615 RID: 83477 RVA: 0x001CD6EC File Offset: 0x001CB8EC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkActorCollection.vtkActorCollection_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06014616 RID: 83478
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkActorCollection_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014617 RID: 83479 RVA: 0x001CD708 File Offset: 0x001CB908
		public override int IsA(string type)
		{
			return vtkActorCollection.vtkActorCollection_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06014618 RID: 83480
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkActorCollection_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014619 RID: 83481 RVA: 0x001CD728 File Offset: 0x001CB928
		public new static int IsTypeOf(string type)
		{
			return vtkActorCollection.vtkActorCollection_IsTypeOf_10(type);
		}

		// Token: 0x0601461A RID: 83482
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActorCollection_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601461B RID: 83483 RVA: 0x001CD744 File Offset: 0x001CB944
		public new vtkActorCollection NewInstance()
		{
			vtkActorCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActorCollection.vtkActorCollection_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkActorCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601461C RID: 83484
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkActorCollection_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601461D RID: 83485 RVA: 0x001CD7A0 File Offset: 0x001CB9A0
		public new static vtkActorCollection SafeDownCast(vtkObjectBase o)
		{
			vtkActorCollection vtkActorCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkActorCollection.vtkActorCollection_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActorCollection = (vtkActorCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActorCollection.Register(null);
				}
			}
			return vtkActorCollection;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017AC RID: 6060
		public new const string MRFullTypeName = "Kitware.VTK.vtkActorCollection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017AD RID: 6061
		public new static readonly string MRClassNameKey = "class vtkActorCollection";
	}
}
