using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPriorityQueue
	/// </summary>
	/// <remarks>
	///    a list of ids arranged in priority order
	///
	/// vtkPriorityQueue is a general object for creating and manipulating lists
	/// of object ids (e.g., point or cell ids). Object ids are sorted according
	/// to a user-specified priority, where entries at the top of the queue have
	/// the smallest values.
	///
	/// This implementation provides a feature beyond the usual ability to insert
	/// and retrieve (or pop) values from the queue. It is also possible to
	/// pop any item in the queue given its id number. This allows you to delete
	/// entries in the queue which can useful for reinserting an item into the
	/// queue.
	///
	/// @warning
	/// This implementation is a variation of the priority queue described in
	/// "Data Structures &amp; Algorithms" by Aho, Hopcroft, Ullman. It creates
	/// a balanced, partially ordered binary tree implemented as an ordered
	/// array. This avoids the overhead associated with parent/child pointers,
	/// and frequent memory allocation and deallocation.
	/// </remarks>
	// Token: 0x02000B7A RID: 2938
	public class vtkPriorityQueue : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601EAA3 RID: 125603 RVA: 0x002B7C4A File Offset: 0x002B5E4A
		static vtkPriorityQueue()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPriorityQueue.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPriorityQueue"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601EAA4 RID: 125604 RVA: 0x002B7C72 File Offset: 0x002B5E72
		public vtkPriorityQueue(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601EAA5 RID: 125605
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPriorityQueue_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate priority queue with default size and extension size of 1000.
		/// </summary>
		// Token: 0x0601EAA6 RID: 125606 RVA: 0x002B7C80 File Offset: 0x002B5E80
		public new static vtkPriorityQueue New()
		{
			vtkPriorityQueue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPriorityQueue.vtkPriorityQueue_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPriorityQueue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate priority queue with default size and extension size of 1000.
		/// </summary>
		// Token: 0x0601EAA7 RID: 125607 RVA: 0x002B7CD4 File Offset: 0x002B5ED4
		public vtkPriorityQueue() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPriorityQueue.vtkPriorityQueue_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601EAA8 RID: 125608 RVA: 0x002B7D18 File Offset: 0x002B5F18
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601EAA9 RID: 125609
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPriorityQueue_Allocate_01(HandleRef pThis, long sz, long ext);

		/// <summary>
		/// Allocate initial space for priority queue.
		/// </summary>
		// Token: 0x0601EAAA RID: 125610 RVA: 0x002B7D23 File Offset: 0x002B5F23
		public void Allocate(long sz, long ext)
		{
			vtkPriorityQueue.vtkPriorityQueue_Allocate_01(base.GetCppThis(), sz, ext);
		}

		// Token: 0x0601EAAB RID: 125611
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPriorityQueue_DeleteId_02(HandleRef pThis, long id);

		/// <summary>
		/// Delete entry in queue with specified id. Returns priority value
		/// associated with that id; or VTK_DOUBLE_MAX if not in queue.
		/// </summary>
		// Token: 0x0601EAAC RID: 125612 RVA: 0x002B7D34 File Offset: 0x002B5F34
		public double DeleteId(long id)
		{
			return vtkPriorityQueue.vtkPriorityQueue_DeleteId_02(base.GetCppThis(), id);
		}

		// Token: 0x0601EAAD RID: 125613
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPriorityQueue_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate priority queue with default size and extension size of 1000.
		/// </summary>
		// Token: 0x0601EAAE RID: 125614 RVA: 0x002B7D54 File Offset: 0x002B5F54
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPriorityQueue.vtkPriorityQueue_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601EAAF RID: 125615
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPriorityQueue_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate priority queue with default size and extension size of 1000.
		/// </summary>
		// Token: 0x0601EAB0 RID: 125616 RVA: 0x002B7D74 File Offset: 0x002B5F74
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPriorityQueue.vtkPriorityQueue_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601EAB1 RID: 125617
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPriorityQueue_GetNumberOfItems_05(HandleRef pThis);

		/// <summary>
		/// Return the number of items in this queue.
		/// </summary>
		// Token: 0x0601EAB2 RID: 125618 RVA: 0x002B7D90 File Offset: 0x002B5F90
		public long GetNumberOfItems()
		{
			return vtkPriorityQueue.vtkPriorityQueue_GetNumberOfItems_05(base.GetCppThis());
		}

		// Token: 0x0601EAB3 RID: 125619
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPriorityQueue_GetPriority_06(HandleRef pThis, long id);

		/// <summary>
		/// Get the priority of an entry in the queue with specified id. Returns
		/// priority value of that id or VTK_DOUBLE_MAX if not in queue.
		/// </summary>
		// Token: 0x0601EAB4 RID: 125620 RVA: 0x002B7DB0 File Offset: 0x002B5FB0
		public double GetPriority(long id)
		{
			return vtkPriorityQueue.vtkPriorityQueue_GetPriority_06(base.GetCppThis(), id);
		}

		// Token: 0x0601EAB5 RID: 125621
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPriorityQueue_Insert_07(HandleRef pThis, double priority, long id);

		/// <summary>
		/// Insert id with priority specified. The id is generally an
		/// index like a point id or cell id.
		/// </summary>
		// Token: 0x0601EAB6 RID: 125622 RVA: 0x002B7DD0 File Offset: 0x002B5FD0
		public void Insert(double priority, long id)
		{
			vtkPriorityQueue.vtkPriorityQueue_Insert_07(base.GetCppThis(), priority, id);
		}

		// Token: 0x0601EAB7 RID: 125623
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPriorityQueue_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate priority queue with default size and extension size of 1000.
		/// </summary>
		// Token: 0x0601EAB8 RID: 125624 RVA: 0x002B7DE4 File Offset: 0x002B5FE4
		public override int IsA(string type)
		{
			return vtkPriorityQueue.vtkPriorityQueue_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0601EAB9 RID: 125625
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPriorityQueue_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate priority queue with default size and extension size of 1000.
		/// </summary>
		// Token: 0x0601EABA RID: 125626 RVA: 0x002B7E04 File Offset: 0x002B6004
		public new static int IsTypeOf(string type)
		{
			return vtkPriorityQueue.vtkPriorityQueue_IsTypeOf_09(type);
		}

		// Token: 0x0601EABB RID: 125627
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPriorityQueue_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate priority queue with default size and extension size of 1000.
		/// </summary>
		// Token: 0x0601EABC RID: 125628 RVA: 0x002B7E20 File Offset: 0x002B6020
		public new vtkPriorityQueue NewInstance()
		{
			vtkPriorityQueue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPriorityQueue.vtkPriorityQueue_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPriorityQueue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601EABD RID: 125629
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPriorityQueue_Peek_12(HandleRef pThis, long location, ref double priority);

		/// <summary>
		/// Peek into the queue without actually removing anything. Returns the
		/// id and the priority.
		/// </summary>
		// Token: 0x0601EABE RID: 125630 RVA: 0x002B7E7C File Offset: 0x002B607C
		public long Peek(long location, ref double priority)
		{
			return vtkPriorityQueue.vtkPriorityQueue_Peek_12(base.GetCppThis(), location, ref priority);
		}

		// Token: 0x0601EABF RID: 125631
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPriorityQueue_Peek_13(HandleRef pThis, long location);

		/// <summary>
		/// Peek into the queue without actually removing anything. Returns the
		/// id.
		/// </summary>
		// Token: 0x0601EAC0 RID: 125632 RVA: 0x002B7EA0 File Offset: 0x002B60A0
		public long Peek(long location)
		{
			return vtkPriorityQueue.vtkPriorityQueue_Peek_13(base.GetCppThis(), location);
		}

		// Token: 0x0601EAC1 RID: 125633
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPriorityQueue_Pop_14(HandleRef pThis, long location, ref double priority);

		/// <summary>
		/// Removes item at specified location from tree; then reorders and
		/// balances tree. The location == 0 is the root of the tree. If queue
		/// is exhausted, then a value &lt; 0 is returned. (Note: the location
		/// is not the same as deleting an id; id is mapped to location.)
		/// </summary>
		// Token: 0x0601EAC2 RID: 125634 RVA: 0x002B7EC0 File Offset: 0x002B60C0
		public long Pop(long location, ref double priority)
		{
			return vtkPriorityQueue.vtkPriorityQueue_Pop_14(base.GetCppThis(), location, ref priority);
		}

		// Token: 0x0601EAC3 RID: 125635
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPriorityQueue_Pop_15(HandleRef pThis, long location);

		/// <summary>
		/// Same as above but simplified for easier wrapping into interpreted
		/// languages.
		/// </summary>
		// Token: 0x0601EAC4 RID: 125636 RVA: 0x002B7EE4 File Offset: 0x002B60E4
		public long Pop(long location)
		{
			return vtkPriorityQueue.vtkPriorityQueue_Pop_15(base.GetCppThis(), location);
		}

		// Token: 0x0601EAC5 RID: 125637
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPriorityQueue_Reset_16(HandleRef pThis);

		/// <summary>
		/// Empty the queue but without releasing memory. This avoids the
		/// overhead of memory allocation/deletion.
		/// </summary>
		// Token: 0x0601EAC6 RID: 125638 RVA: 0x002B7F04 File Offset: 0x002B6104
		public void Reset()
		{
			vtkPriorityQueue.vtkPriorityQueue_Reset_16(base.GetCppThis());
		}

		// Token: 0x0601EAC7 RID: 125639
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPriorityQueue_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate priority queue with default size and extension size of 1000.
		/// </summary>
		// Token: 0x0601EAC8 RID: 125640 RVA: 0x002B7F14 File Offset: 0x002B6114
		public new static vtkPriorityQueue SafeDownCast(vtkObjectBase o)
		{
			vtkPriorityQueue vtkPriorityQueue = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPriorityQueue.vtkPriorityQueue_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPriorityQueue = (vtkPriorityQueue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPriorityQueue.Register(null);
				}
			}
			return vtkPriorityQueue;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020D8 RID: 8408
		public new const string MRFullTypeName = "Kitware.VTK.vtkPriorityQueue";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020D9 RID: 8409
		public new static readonly string MRClassNameKey = "class vtkPriorityQueue";
	}
}
