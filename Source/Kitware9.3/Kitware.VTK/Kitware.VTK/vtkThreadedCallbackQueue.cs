using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkThreadedCallbackQueue
	/// </summary>
	/// <remarks>
	///  simple threaded callback queue
	///
	/// This callback queue executes pushed functions and functors on threads whose
	/// purpose is to execute those functions.
	/// By default, one thread is created by this class, so it is advised to set `NumberOfThreads`.
	/// Upon destruction of an instance of this callback queue, remaining unexecuted threads are
	/// executed.
	///
	/// When a task is pushed, a `vtkSharedFuture` is returned. This instance can be used to get the
	/// returned value when the task is finished, and provides functionalities to synchronize the main
	/// thread with the status of its associated task.
	///
	/// All public methods of this class are thread safe.
	/// </remarks>
	// Token: 0x02000702 RID: 1794
	public class vtkThreadedCallbackQueue : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012E04 RID: 77316 RVA: 0x001A91BD File Offset: 0x001A73BD
		static vtkThreadedCallbackQueue()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkThreadedCallbackQueue.MRClassNameKey, Type.GetType("Kitware.VTK.vtkThreadedCallbackQueue"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012E05 RID: 77317 RVA: 0x001A91E5 File Offset: 0x001A73E5
		public vtkThreadedCallbackQueue(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012E06 RID: 77318
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThreadedCallbackQueue_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This class wraps the returned value and gives access to it.
		/// </summary>
		// Token: 0x06012E07 RID: 77319 RVA: 0x001A91F4 File Offset: 0x001A73F4
		public new static vtkThreadedCallbackQueue New()
		{
			vtkThreadedCallbackQueue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThreadedCallbackQueue.vtkThreadedCallbackQueue_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThreadedCallbackQueue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// This class wraps the returned value and gives access to it.
		/// </summary>
		// Token: 0x06012E08 RID: 77320 RVA: 0x001A9248 File Offset: 0x001A7448
		public vtkThreadedCallbackQueue() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkThreadedCallbackQueue.vtkThreadedCallbackQueue_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012E09 RID: 77321 RVA: 0x001A928C File Offset: 0x001A748C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012E0A RID: 77322
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkThreadedCallbackQueue_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// This class wraps the returned value and gives access to it.
		/// </summary>
		// Token: 0x06012E0B RID: 77323 RVA: 0x001A9298 File Offset: 0x001A7498
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkThreadedCallbackQueue.vtkThreadedCallbackQueue_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06012E0C RID: 77324
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkThreadedCallbackQueue_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// This class wraps the returned value and gives access to it.
		/// </summary>
		// Token: 0x06012E0D RID: 77325 RVA: 0x001A92B8 File Offset: 0x001A74B8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkThreadedCallbackQueue.vtkThreadedCallbackQueue_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06012E0E RID: 77326
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThreadedCallbackQueue_GetNumberOfThreads_03(HandleRef pThis);

		/// <summary>
		/// Returns the number of allocated threads. Note that this method doesn't give any information on
		/// whether threads are running or not.
		///
		/// @note `SetNumberOfThreads(int)` runs in the background. So the number of threads of this queue
		/// might change asynchronously as those commands are executed.
		/// </summary>
		// Token: 0x06012E0F RID: 77327 RVA: 0x001A92D4 File Offset: 0x001A74D4
		public int GetNumberOfThreads()
		{
			return vtkThreadedCallbackQueue.vtkThreadedCallbackQueue_GetNumberOfThreads_03(base.GetCppThis());
		}

		// Token: 0x06012E10 RID: 77328
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThreadedCallbackQueue_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// This class wraps the returned value and gives access to it.
		/// </summary>
		// Token: 0x06012E11 RID: 77329 RVA: 0x001A92F4 File Offset: 0x001A74F4
		public override int IsA(string type)
		{
			return vtkThreadedCallbackQueue.vtkThreadedCallbackQueue_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06012E12 RID: 77330
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThreadedCallbackQueue_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// This class wraps the returned value and gives access to it.
		/// </summary>
		// Token: 0x06012E13 RID: 77331 RVA: 0x001A9314 File Offset: 0x001A7514
		public new static int IsTypeOf(string type)
		{
			return vtkThreadedCallbackQueue.vtkThreadedCallbackQueue_IsTypeOf_05(type);
		}

		// Token: 0x06012E14 RID: 77332
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThreadedCallbackQueue_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This class wraps the returned value and gives access to it.
		/// </summary>
		// Token: 0x06012E15 RID: 77333 RVA: 0x001A9330 File Offset: 0x001A7530
		public new vtkThreadedCallbackQueue NewInstance()
		{
			vtkThreadedCallbackQueue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThreadedCallbackQueue.vtkThreadedCallbackQueue_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThreadedCallbackQueue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012E16 RID: 77334
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThreadedCallbackQueue_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This class wraps the returned value and gives access to it.
		/// </summary>
		// Token: 0x06012E17 RID: 77335 RVA: 0x001A938C File Offset: 0x001A758C
		public new static vtkThreadedCallbackQueue SafeDownCast(vtkObjectBase o)
		{
			vtkThreadedCallbackQueue vtkThreadedCallbackQueue = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThreadedCallbackQueue.vtkThreadedCallbackQueue_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkThreadedCallbackQueue = (vtkThreadedCallbackQueue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkThreadedCallbackQueue.Register(null);
				}
			}
			return vtkThreadedCallbackQueue;
		}

		// Token: 0x06012E18 RID: 77336
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreadedCallbackQueue_SetNumberOfThreads_09(HandleRef pThis, int numberOfThreads);

		/// <summary>
		/// Sets the number of threads. The running state of the queue is not impacted by this method.
		///
		/// This method is executed by the `Controller` on a different thread, so this method may terminate
		/// before the threads were allocated. Nevertheless, this method is thread-safe. Other calls to
		/// `SetNumberOfThreads()` will be queued by the `Controller`,
		/// which executes all received command serially in the background.
		/// </summary>
		// Token: 0x06012E19 RID: 77337 RVA: 0x001A940B File Offset: 0x001A760B
		public void SetNumberOfThreads(int numberOfThreads)
		{
			vtkThreadedCallbackQueue.vtkThreadedCallbackQueue_SetNumberOfThreads_09(base.GetCppThis(), numberOfThreads);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015D0 RID: 5584
		public new const string MRFullTypeName = "Kitware.VTK.vtkThreadedCallbackQueue";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015D1 RID: 5585
		public new static readonly string MRClassNameKey = "class vtkThreadedCallbackQueue";
	}
}
