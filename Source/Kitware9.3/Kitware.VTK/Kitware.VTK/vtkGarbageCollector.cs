using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGarbageCollector
	/// </summary>
	/// <remarks>
	///    Detect and break reference loops
	///
	/// vtkGarbageCollector is used by VTK classes that may be involved in
	/// reference counting loops (such as Algorithm &lt;-&gt; Executive).  It
	/// detects strongly connected components of the reference graph that
	/// have been leaked deletes them.  The garbage collector uses the
	/// ReportReferences method to search the reference graph and construct
	/// a net reference count for each connected component.  If the net
	/// reference count is zero the entire set of objects is deleted.
	/// Deleting each component may leak other components, which are then
	/// collected recursively.
	///
	/// To enable garbage collection for a class, add these members:
	///
	/// <code>
	///
	///  public:
	///   bool UsesGarbageCollector() const override { return true; }
	///
	///  protected:
	///
	///   void ReportReferences(vtkGarbageCollector* collector) override
	///   {
	///     // Report references held by this object that may be in a loop.
	///     this-&gt;Superclass::ReportReferences(collector);
	///     vtkGarbageCollectorReport(collector, this-&gt;OtherObject, "Other Object");
	///   }
	/// </code>
	///
	/// The implementations should be in the .cxx file in practice.
	/// It is important that the reference be reported using the real
	/// pointer or smart pointer instance that holds the reference.  When
	/// collecting the garbage collector will actually set this pointer to
	/// nullptr.  The destructor of the class should be written to deal with
	/// this.  It is also expected that an invariant is maintained for any
	/// reference that is reported.  The variable holding the reference
	/// must always either be nullptr or refer to a fully constructed valid
	/// object.  Therefore code like "this-&gt;Object-&gt;UnRegister(this)" must
	/// be avoided if "this-&gt;Object" is a reported reference because it
	/// is possible that the object is deleted before UnRegister returns
	/// but then "this-&gt;Object" will be left as a dangling pointer.  Instead
	/// use code like
	///
	/// <code>
	///   vtkObjectBase* obj = this-&gt;Object;
	///   this-&gt;Object = 0;
	///   obj-&gt;UnRegister(this);
	/// </code>
	///
	/// so that the reported reference maintains the invariant.
	///
	/// If subclassing from a class that already supports garbage
	/// collection, one need only provide the ReportReferences method.
	/// </remarks>
	// Token: 0x02000B54 RID: 2900
	public class vtkGarbageCollector : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E480 RID: 124032 RVA: 0x002AD643 File Offset: 0x002AB843
		static vtkGarbageCollector()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGarbageCollector.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGarbageCollector"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E481 RID: 124033 RVA: 0x002AD66B File Offset: 0x002AB86B
		public vtkGarbageCollector(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E482 RID: 124034
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGarbageCollector_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E483 RID: 124035 RVA: 0x002AD67C File Offset: 0x002AB87C
		public new static vtkGarbageCollector New()
		{
			vtkGarbageCollector result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGarbageCollector.vtkGarbageCollector_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGarbageCollector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E484 RID: 124036 RVA: 0x002AD6D0 File Offset: 0x002AB8D0
		public vtkGarbageCollector() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGarbageCollector.vtkGarbageCollector_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E485 RID: 124037 RVA: 0x002AD714 File Offset: 0x002AB914
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E486 RID: 124038
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGarbageCollector_Collect_01();

		/// <summary>
		/// Collect immediately using any objects whose collection was
		/// previously deferred as a root for the reference graph walk.
		/// Strongly connected components in the reference graph are
		/// identified.  Those with a net reference count of zero are
		/// deleted.  When a component is deleted it may remove references to
		/// other components that are not part of the same reference loop but
		/// are held by objects in the original component.  These removed
		/// references are handled as any other and their corresponding
		/// checks may be deferred.  This method keeps collecting until no
		/// deferred collection checks remain.
		/// </summary>
		// Token: 0x0601E487 RID: 124039 RVA: 0x002AD71F File Offset: 0x002AB91F
		public static void Collect()
		{
			vtkGarbageCollector.vtkGarbageCollector_Collect_01();
		}

		// Token: 0x0601E488 RID: 124040
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGarbageCollector_Collect_02(HandleRef root);

		/// <summary>
		/// Collect immediately using the given object as the root for a
		/// reference graph walk.  Strongly connected components in the
		/// reference graph are identified.  Those with a net reference count
		/// of zero are deleted.  When a component is deleted it may remove
		/// references to other components that are not part of the same
		/// reference loop but are held by objects in the original component.
		/// These removed references are handled as any other and their
		/// corresponding checks may be deferred.  This method does continue
		/// collecting in this case.
		/// </summary>
		// Token: 0x0601E489 RID: 124041 RVA: 0x002AD728 File Offset: 0x002AB928
		public static void Collect(vtkObjectBase root)
		{
			vtkGarbageCollector.vtkGarbageCollector_Collect_02((root == null) ? default(HandleRef) : root.GetCppThis());
		}

		// Token: 0x0601E48A RID: 124042
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGarbageCollector_DeferredCollectionPop_03();

		/// <summary>
		/// Push/Pop whether to do deferred collection.  Whenever the total
		/// number of pushes exceeds the total number of pops collection will
		/// be deferred.  Code can call the Collect method directly to force
		/// collection.
		/// </summary>
		// Token: 0x0601E48B RID: 124043 RVA: 0x002AD751 File Offset: 0x002AB951
		public static void DeferredCollectionPop()
		{
			vtkGarbageCollector.vtkGarbageCollector_DeferredCollectionPop_03();
		}

		// Token: 0x0601E48C RID: 124044
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGarbageCollector_DeferredCollectionPush_04();

		/// <summary>
		/// Push/Pop whether to do deferred collection.  Whenever the total
		/// number of pushes exceeds the total number of pops collection will
		/// be deferred.  Code can call the Collect method directly to force
		/// collection.
		/// </summary>
		// Token: 0x0601E48D RID: 124045 RVA: 0x002AD75A File Offset: 0x002AB95A
		public static void DeferredCollectionPush()
		{
			vtkGarbageCollector.vtkGarbageCollector_DeferredCollectionPush_04();
		}

		// Token: 0x0601E48E RID: 124046
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGarbageCollector_GetGlobalDebugFlag_05();

		/// <summary>
		/// Set/Get global garbage collection debugging flag.  When set to true,
		/// all garbage collection checks will produce debugging information.
		/// </summary>
		// Token: 0x0601E48F RID: 124047 RVA: 0x002AD764 File Offset: 0x002AB964
		public static bool GetGlobalDebugFlag()
		{
			return vtkGarbageCollector.vtkGarbageCollector_GetGlobalDebugFlag_05() != 0;
		}

		// Token: 0x0601E490 RID: 124048
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGarbageCollector_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E491 RID: 124049 RVA: 0x002AD784 File Offset: 0x002AB984
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGarbageCollector.vtkGarbageCollector_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0601E492 RID: 124050
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGarbageCollector_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E493 RID: 124051 RVA: 0x002AD7A4 File Offset: 0x002AB9A4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGarbageCollector.vtkGarbageCollector_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0601E494 RID: 124052
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGarbageCollector_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E495 RID: 124053 RVA: 0x002AD7C0 File Offset: 0x002AB9C0
		public override int IsA(string type)
		{
			return vtkGarbageCollector.vtkGarbageCollector_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0601E496 RID: 124054
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGarbageCollector_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E497 RID: 124055 RVA: 0x002AD7E0 File Offset: 0x002AB9E0
		public new static int IsTypeOf(string type)
		{
			return vtkGarbageCollector.vtkGarbageCollector_IsTypeOf_09(type);
		}

		// Token: 0x0601E498 RID: 124056
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGarbageCollector_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E499 RID: 124057 RVA: 0x002AD7FC File Offset: 0x002AB9FC
		public new vtkGarbageCollector NewInstance()
		{
			vtkGarbageCollector result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGarbageCollector.vtkGarbageCollector_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGarbageCollector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E49A RID: 124058
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGarbageCollector_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E49B RID: 124059 RVA: 0x002AD858 File Offset: 0x002ABA58
		public new static vtkGarbageCollector SafeDownCast(vtkObjectBase o)
		{
			vtkGarbageCollector vtkGarbageCollector = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGarbageCollector.vtkGarbageCollector_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGarbageCollector = (vtkGarbageCollector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGarbageCollector.Register(null);
				}
			}
			return vtkGarbageCollector;
		}

		// Token: 0x0601E49C RID: 124060
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGarbageCollector_SetGlobalDebugFlag_13(byte flag);

		/// <summary>
		/// Set/Get global garbage collection debugging flag.  When set to true,
		/// all garbage collection checks will produce debugging information.
		/// </summary>
		// Token: 0x0601E49D RID: 124061 RVA: 0x002AD8D7 File Offset: 0x002ABAD7
		public static void SetGlobalDebugFlag(bool flag)
		{
			vtkGarbageCollector.vtkGarbageCollector_SetGlobalDebugFlag_13(flag ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04002087 RID: 8327
		public new const string MRFullTypeName = "Kitware.VTK.vtkGarbageCollector";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04002088 RID: 8328
		public new static readonly string MRClassNameKey = "class vtkGarbageCollector";
	}
}
