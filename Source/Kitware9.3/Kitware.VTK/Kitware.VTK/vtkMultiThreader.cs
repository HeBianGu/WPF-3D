using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMultiThreader
	/// </summary>
	/// <remarks>
	///    A class for performing multithreaded execution
	///
	/// vtkMultithreader is a class that provides support for multithreaded
	/// execution using pthreads on POSIX systems, or Win32 threads on
	/// Windows.  This class can be used to execute a single
	/// method on multiple threads, or to specify a method per thread.
	/// </remarks>
	// Token: 0x02000B71 RID: 2929
	public class vtkMultiThreader : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E9A4 RID: 125348 RVA: 0x002B6487 File Offset: 0x002B4687
		static vtkMultiThreader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMultiThreader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiThreader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E9A5 RID: 125349 RVA: 0x002B64AF File Offset: 0x002B46AF
		public vtkMultiThreader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E9A6 RID: 125350
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiThreader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E9A7 RID: 125351 RVA: 0x002B64C0 File Offset: 0x002B46C0
		public new static vtkMultiThreader New()
		{
			vtkMultiThreader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiThreader.vtkMultiThreader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiThreader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E9A8 RID: 125352 RVA: 0x002B6514 File Offset: 0x002B4714
		public vtkMultiThreader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMultiThreader.vtkMultiThreader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E9A9 RID: 125353 RVA: 0x002B6558 File Offset: 0x002B4758
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E9AA RID: 125354
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkMultiThreader_GetCurrentThreadID_01();

		/// <summary>
		/// Get the thread identifier of the calling thread.
		/// </summary>
		// Token: 0x0601E9AB RID: 125355 RVA: 0x002B6564 File Offset: 0x002B4764
		public static uint GetCurrentThreadID()
		{
			return vtkMultiThreader.vtkMultiThreader_GetCurrentThreadID_01();
		}

		// Token: 0x0601E9AC RID: 125356
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiThreader_GetGlobalDefaultNumberOfThreads_02();

		/// <summary>
		/// Set/Get the value which is used to initialize the NumberOfThreads
		/// in the constructor.  Initially this default is set to the number of
		/// processors or VTK_MAX_THREADS (which ever is less).
		/// </summary>
		// Token: 0x0601E9AD RID: 125357 RVA: 0x002B6580 File Offset: 0x002B4780
		public static int GetGlobalDefaultNumberOfThreads()
		{
			return vtkMultiThreader.vtkMultiThreader_GetGlobalDefaultNumberOfThreads_02();
		}

		// Token: 0x0601E9AE RID: 125358
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiThreader_GetGlobalMaximumNumberOfThreads_03();

		/// <summary>
		/// Set/Get the maximum number of threads to use when multithreading.
		/// This limits and overrides any other settings for multithreading.
		/// A value of zero indicates no limit.
		/// </summary>
		// Token: 0x0601E9AF RID: 125359 RVA: 0x002B659C File Offset: 0x002B479C
		public static int GetGlobalMaximumNumberOfThreads()
		{
			return vtkMultiThreader.vtkMultiThreader_GetGlobalMaximumNumberOfThreads_03();
		}

		// Token: 0x0601E9B0 RID: 125360
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiThreader_GetGlobalStaticMaximumNumberOfThreads_04();

		/// <summary>
		/// Set/Get the maximum number of threads VTK was allocated to support.
		/// </summary>
		// Token: 0x0601E9B1 RID: 125361 RVA: 0x002B65B8 File Offset: 0x002B47B8
		public static int GetGlobalStaticMaximumNumberOfThreads()
		{
			return vtkMultiThreader.vtkMultiThreader_GetGlobalStaticMaximumNumberOfThreads_04();
		}

		// Token: 0x0601E9B2 RID: 125362
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiThreader_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E9B3 RID: 125363 RVA: 0x002B65D4 File Offset: 0x002B47D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMultiThreader.vtkMultiThreader_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601E9B4 RID: 125364
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiThreader_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E9B5 RID: 125365 RVA: 0x002B65F4 File Offset: 0x002B47F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMultiThreader.vtkMultiThreader_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601E9B6 RID: 125366
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiThreader_GetNumberOfThreads_07(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of threads to create. It will be clamped to the range
		/// 1 - VTK_MAX_THREADS, so the caller of this method should check that the
		/// requested number of threads was accepted.
		/// </summary>
		// Token: 0x0601E9B7 RID: 125367 RVA: 0x002B6610 File Offset: 0x002B4810
		public virtual int GetNumberOfThreads()
		{
			return vtkMultiThreader.vtkMultiThreader_GetNumberOfThreads_07(base.GetCppThis());
		}

		// Token: 0x0601E9B8 RID: 125368
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiThreader_GetNumberOfThreadsMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of threads to create. It will be clamped to the range
		/// 1 - VTK_MAX_THREADS, so the caller of this method should check that the
		/// requested number of threads was accepted.
		/// </summary>
		// Token: 0x0601E9B9 RID: 125369 RVA: 0x002B6630 File Offset: 0x002B4830
		public virtual int GetNumberOfThreadsMaxValue()
		{
			return vtkMultiThreader.vtkMultiThreader_GetNumberOfThreadsMaxValue_08(base.GetCppThis());
		}

		// Token: 0x0601E9BA RID: 125370
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiThreader_GetNumberOfThreadsMinValue_09(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of threads to create. It will be clamped to the range
		/// 1 - VTK_MAX_THREADS, so the caller of this method should check that the
		/// requested number of threads was accepted.
		/// </summary>
		// Token: 0x0601E9BB RID: 125371 RVA: 0x002B6650 File Offset: 0x002B4850
		public virtual int GetNumberOfThreadsMinValue()
		{
			return vtkMultiThreader.vtkMultiThreader_GetNumberOfThreadsMinValue_09(base.GetCppThis());
		}

		// Token: 0x0601E9BC RID: 125372
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiThreader_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E9BD RID: 125373 RVA: 0x002B6670 File Offset: 0x002B4870
		public override int IsA(string type)
		{
			return vtkMultiThreader.vtkMultiThreader_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0601E9BE RID: 125374
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiThreader_IsThreadActive_11(HandleRef pThis, int threadId);

		/// <summary>
		/// Determine if a thread is still active
		/// </summary>
		// Token: 0x0601E9BF RID: 125375 RVA: 0x002B6690 File Offset: 0x002B4890
		public int IsThreadActive(int threadId)
		{
			return vtkMultiThreader.vtkMultiThreader_IsThreadActive_11(base.GetCppThis(), threadId);
		}

		// Token: 0x0601E9C0 RID: 125376
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiThreader_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E9C1 RID: 125377 RVA: 0x002B66B0 File Offset: 0x002B48B0
		public new static int IsTypeOf(string type)
		{
			return vtkMultiThreader.vtkMultiThreader_IsTypeOf_12(type);
		}

		// Token: 0x0601E9C2 RID: 125378
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiThreader_MultipleMethodExecute_13(HandleRef pThis);

		/// <summary>
		/// Execute the MultipleMethods (as define by calling SetMultipleMethod
		/// for each of the required this-&gt;NumberOfThreads methods) using
		/// this-&gt;NumberOfThreads threads.
		/// </summary>
		// Token: 0x0601E9C3 RID: 125379 RVA: 0x002B66CA File Offset: 0x002B48CA
		public void MultipleMethodExecute()
		{
			vtkMultiThreader.vtkMultiThreader_MultipleMethodExecute_13(base.GetCppThis());
		}

		// Token: 0x0601E9C4 RID: 125380
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiThreader_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E9C5 RID: 125381 RVA: 0x002B66DC File Offset: 0x002B48DC
		public new vtkMultiThreader NewInstance()
		{
			vtkMultiThreader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiThreader.vtkMultiThreader_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiThreader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E9C6 RID: 125382
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiThreader_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E9C7 RID: 125383 RVA: 0x002B6738 File Offset: 0x002B4938
		public new static vtkMultiThreader SafeDownCast(vtkObjectBase o)
		{
			vtkMultiThreader vtkMultiThreader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiThreader.vtkMultiThreader_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiThreader = (vtkMultiThreader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiThreader.Register(null);
				}
			}
			return vtkMultiThreader;
		}

		// Token: 0x0601E9C8 RID: 125384
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiThreader_SetGlobalDefaultNumberOfThreads_17(int val);

		/// <summary>
		/// Set/Get the value which is used to initialize the NumberOfThreads
		/// in the constructor.  Initially this default is set to the number of
		/// processors or VTK_MAX_THREADS (which ever is less).
		/// </summary>
		// Token: 0x0601E9C9 RID: 125385 RVA: 0x002B67B7 File Offset: 0x002B49B7
		public static void SetGlobalDefaultNumberOfThreads(int val)
		{
			vtkMultiThreader.vtkMultiThreader_SetGlobalDefaultNumberOfThreads_17(val);
		}

		// Token: 0x0601E9CA RID: 125386
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiThreader_SetGlobalMaximumNumberOfThreads_18(int val);

		/// <summary>
		/// Set/Get the maximum number of threads to use when multithreading.
		/// This limits and overrides any other settings for multithreading.
		/// A value of zero indicates no limit.
		/// </summary>
		// Token: 0x0601E9CB RID: 125387 RVA: 0x002B67C1 File Offset: 0x002B49C1
		public static void SetGlobalMaximumNumberOfThreads(int val)
		{
			vtkMultiThreader.vtkMultiThreader_SetGlobalMaximumNumberOfThreads_18(val);
		}

		// Token: 0x0601E9CC RID: 125388
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiThreader_SetNumberOfThreads_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the number of threads to create. It will be clamped to the range
		/// 1 - VTK_MAX_THREADS, so the caller of this method should check that the
		/// requested number of threads was accepted.
		/// </summary>
		// Token: 0x0601E9CD RID: 125389 RVA: 0x002B67CB File Offset: 0x002B49CB
		public virtual void SetNumberOfThreads(int _arg)
		{
			vtkMultiThreader.vtkMultiThreader_SetNumberOfThreads_19(base.GetCppThis(), _arg);
		}

		// Token: 0x0601E9CE RID: 125390
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiThreader_SingleMethodExecute_20(HandleRef pThis);

		/// <summary>
		/// Execute the SingleMethod (as define by SetSingleMethod) using
		/// this-&gt;NumberOfThreads threads.
		/// </summary>
		// Token: 0x0601E9CF RID: 125391 RVA: 0x002B67DB File Offset: 0x002B49DB
		public void SingleMethodExecute()
		{
			vtkMultiThreader.vtkMultiThreader_SingleMethodExecute_20(base.GetCppThis());
		}

		// Token: 0x0601E9D0 RID: 125392
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiThreader_TerminateThread_21(HandleRef pThis, int threadId);

		/// <summary>
		/// Terminate the thread that was created with a SpawnThreadExecute()
		/// </summary>
		// Token: 0x0601E9D1 RID: 125393 RVA: 0x002B67EA File Offset: 0x002B49EA
		public void TerminateThread(int threadId)
		{
			vtkMultiThreader.vtkMultiThreader_TerminateThread_21(base.GetCppThis(), threadId);
		}

		// Token: 0x0601E9D2 RID: 125394
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiThreader_ThreadsEqual_22(uint t1, uint t2);

		/// <summary>
		/// Check whether two thread identifiers refer to the same thread.
		/// </summary>
		// Token: 0x0601E9D3 RID: 125395 RVA: 0x002B67FC File Offset: 0x002B49FC
		public static int ThreadsEqual(uint t1, uint t2)
		{
			return vtkMultiThreader.vtkMultiThreader_ThreadsEqual_22(t1, t2);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020C3 RID: 8387
		public new const string MRFullTypeName = "Kitware.VTK.vtkMultiThreader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020C4 RID: 8388
		public new static readonly string MRClassNameKey = "class vtkMultiThreader";
	}
}
