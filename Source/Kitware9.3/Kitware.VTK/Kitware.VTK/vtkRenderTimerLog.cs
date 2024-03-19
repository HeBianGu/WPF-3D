using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRenderTimerLog
	/// </summary>
	/// <remarks>
	///    Asynchronously measures GPU execution times for a series of events.
	///
	/// This class measures the time it takes for events to occur on the GPU by
	/// posting timing events into the rendering command stream. This can be used
	/// to compute the time spent doing work on the GPU without stalling the
	/// CPU.
	///
	/// To aid asynchronous usage, this class uses the concepts "Event" and "Frame",
	/// where a Frame is a logical collection of Events. The timer log can manage
	/// multiple Frames at a time:
	/// - The current Frame, where new Events are created.
	/// - Pending Frames, for which all Events have been marked, but the results are
	///   not available (the timer requests are still waiting to be processed by the
	///   graphics device).
	/// - Ready Frames, which have been completed by the graphics device and may be
	///   retrieved.
	///
	/// Call MarkFrame() to begin a new Frame. This pushes the current Frame to the
	/// collection of pending Frames, and creates a new one to store future Events.
	///
	/// Call MarkStartEvent() and MarkEndEvent() to mark the beginning and end of
	/// an Event. These Events may be nested, but all child Events must have their
	/// end marked before the parent Event ends.
	///
	/// Use FrameReady() and PopFirstReadyFrame() to check for completed Frames and
	/// retrieve results.
	///
	/// This is currently only implemented for the OpenGL2 backend. The IsSupported()
	/// method can be used to detect if there is a valid implementation available.
	/// </remarks>
	// Token: 0x020005C4 RID: 1476
	public class vtkRenderTimerLog : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601023E RID: 66110 RVA: 0x00167B1E File Offset: 0x00165D1E
		static vtkRenderTimerLog()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRenderTimerLog.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderTimerLog"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601023F RID: 66111 RVA: 0x00167B46 File Offset: 0x00165D46
		public vtkRenderTimerLog(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010240 RID: 66112
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderTimerLog_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// RAII struct for logging events. Such events start when
		/// vtkRenderTimerLog::StartScopedEvent(name) is called, and end when the
		/// returned object is destroyed, or ScopedEventLogger::Stop() is called.
		/// </summary>
		// Token: 0x06010241 RID: 66113 RVA: 0x00167B54 File Offset: 0x00165D54
		public new static vtkRenderTimerLog New()
		{
			vtkRenderTimerLog result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderTimerLog.vtkRenderTimerLog_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderTimerLog)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// RAII struct for logging events. Such events start when
		/// vtkRenderTimerLog::StartScopedEvent(name) is called, and end when the
		/// returned object is destroyed, or ScopedEventLogger::Stop() is called.
		/// </summary>
		// Token: 0x06010242 RID: 66114 RVA: 0x00167BA8 File Offset: 0x00165DA8
		public vtkRenderTimerLog() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRenderTimerLog.vtkRenderTimerLog_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010243 RID: 66115 RVA: 0x00167BEC File Offset: 0x00165DEC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010244 RID: 66116
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderTimerLog_FrameReady_01(HandleRef pThis);

		/// <summary>
		/// Returns true if there are any frames ready with complete timing info.
		/// </summary>
		// Token: 0x06010245 RID: 66117 RVA: 0x00167BF8 File Offset: 0x00165DF8
		public virtual bool FrameReady()
		{
			return vtkRenderTimerLog.vtkRenderTimerLog_FrameReady_01(base.GetCppThis()) != 0;
		}

		// Token: 0x06010246 RID: 66118
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkRenderTimerLog_GetFrameLimit_02(HandleRef pThis);

		/// <summary>
		/// If there are more than FrameLimit frames pending/ready, drop the old ones
		/// until we are under this limit. Prevents things from backing up.
		/// Default is 32. Set to 0 to disable. @{
		/// </summary>
		// Token: 0x06010247 RID: 66119 RVA: 0x00167C20 File Offset: 0x00165E20
		public virtual uint GetFrameLimit()
		{
			return vtkRenderTimerLog.vtkRenderTimerLog_GetFrameLimit_02(base.GetCppThis());
		}

		// Token: 0x06010248 RID: 66120
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderTimerLog_GetLoggingEnabled_03(HandleRef pThis);

		/// <summary>
		/// If false, no events are recorded. Default is false. @{ 
		/// </summary>
		// Token: 0x06010249 RID: 66121 RVA: 0x00167C40 File Offset: 0x00165E40
		public virtual bool GetLoggingEnabled()
		{
			return vtkRenderTimerLog.vtkRenderTimerLog_GetLoggingEnabled_03(base.GetCppThis()) != 0;
		}

		// Token: 0x0601024A RID: 66122
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderTimerLog_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// RAII struct for logging events. Such events start when
		/// vtkRenderTimerLog::StartScopedEvent(name) is called, and end when the
		/// returned object is destroyed, or ScopedEventLogger::Stop() is called.
		/// </summary>
		// Token: 0x0601024B RID: 66123 RVA: 0x00167C68 File Offset: 0x00165E68
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRenderTimerLog.vtkRenderTimerLog_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601024C RID: 66124
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderTimerLog_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// RAII struct for logging events. Such events start when
		/// vtkRenderTimerLog::StartScopedEvent(name) is called, and end when the
		/// returned object is destroyed, or ScopedEventLogger::Stop() is called.
		/// </summary>
		// Token: 0x0601024D RID: 66125 RVA: 0x00167C88 File Offset: 0x00165E88
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRenderTimerLog.vtkRenderTimerLog_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601024E RID: 66126
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderTimerLog_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// RAII struct for logging events. Such events start when
		/// vtkRenderTimerLog::StartScopedEvent(name) is called, and end when the
		/// returned object is destroyed, or ScopedEventLogger::Stop() is called.
		/// </summary>
		// Token: 0x0601024F RID: 66127 RVA: 0x00167CA4 File Offset: 0x00165EA4
		public override int IsA(string type)
		{
			return vtkRenderTimerLog.vtkRenderTimerLog_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06010250 RID: 66128
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderTimerLog_IsSupported_07(HandleRef pThis);

		/// <summary>
		/// Returns true if stream timings are implemented for the current graphics
		/// backend.
		/// </summary>
		// Token: 0x06010251 RID: 66129 RVA: 0x00167CC4 File Offset: 0x00165EC4
		public virtual bool IsSupported()
		{
			return vtkRenderTimerLog.vtkRenderTimerLog_IsSupported_07(base.GetCppThis()) != 0;
		}

		// Token: 0x06010252 RID: 66130
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderTimerLog_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// RAII struct for logging events. Such events start when
		/// vtkRenderTimerLog::StartScopedEvent(name) is called, and end when the
		/// returned object is destroyed, or ScopedEventLogger::Stop() is called.
		/// </summary>
		// Token: 0x06010253 RID: 66131 RVA: 0x00167CEC File Offset: 0x00165EEC
		public new static int IsTypeOf(string type)
		{
			return vtkRenderTimerLog.vtkRenderTimerLog_IsTypeOf_08(type);
		}

		// Token: 0x06010254 RID: 66132
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderTimerLog_LoggingEnabledOff_09(HandleRef pThis);

		/// <summary>
		/// If false, no events are recorded. Default is false. @{ 
		/// </summary>
		// Token: 0x06010255 RID: 66133 RVA: 0x00167D06 File Offset: 0x00165F06
		public virtual void LoggingEnabledOff()
		{
			vtkRenderTimerLog.vtkRenderTimerLog_LoggingEnabledOff_09(base.GetCppThis());
		}

		// Token: 0x06010256 RID: 66134
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderTimerLog_LoggingEnabledOn_10(HandleRef pThis);

		/// <summary>
		/// If false, no events are recorded. Default is false. @{ 
		/// </summary>
		// Token: 0x06010257 RID: 66135 RVA: 0x00167D15 File Offset: 0x00165F15
		public virtual void LoggingEnabledOn()
		{
			vtkRenderTimerLog.vtkRenderTimerLog_LoggingEnabledOn_10(base.GetCppThis());
		}

		// Token: 0x06010258 RID: 66136
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderTimerLog_MarkEndEvent_11(HandleRef pThis);

		/// <summary>
		/// Mark the beginning or end of an event. @{
		/// </summary>
		// Token: 0x06010259 RID: 66137 RVA: 0x00167D24 File Offset: 0x00165F24
		public virtual void MarkEndEvent()
		{
			vtkRenderTimerLog.vtkRenderTimerLog_MarkEndEvent_11(base.GetCppThis());
		}

		// Token: 0x0601025A RID: 66138
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderTimerLog_MarkFrame_12(HandleRef pThis);

		/// <summary>
		/// Call to mark the start of a new frame, or the end of an old one. Does
		/// nothing if no events have been recorded in the current frame.
		/// </summary>
		// Token: 0x0601025B RID: 66139 RVA: 0x00167D33 File Offset: 0x00165F33
		public virtual void MarkFrame()
		{
			vtkRenderTimerLog.vtkRenderTimerLog_MarkFrame_12(base.GetCppThis());
		}

		// Token: 0x0601025C RID: 66140
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderTimerLog_MarkStartEvent_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Mark the beginning or end of an event. @{
		/// </summary>
		// Token: 0x0601025D RID: 66141 RVA: 0x00167D42 File Offset: 0x00165F42
		public virtual void MarkStartEvent(string name)
		{
			vtkRenderTimerLog.vtkRenderTimerLog_MarkStartEvent_13(base.GetCppThis(), name);
		}

		// Token: 0x0601025E RID: 66142
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderTimerLog_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// RAII struct for logging events. Such events start when
		/// vtkRenderTimerLog::StartScopedEvent(name) is called, and end when the
		/// returned object is destroyed, or ScopedEventLogger::Stop() is called.
		/// </summary>
		// Token: 0x0601025F RID: 66143 RVA: 0x00167D54 File Offset: 0x00165F54
		public new vtkRenderTimerLog NewInstance()
		{
			vtkRenderTimerLog result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderTimerLog.vtkRenderTimerLog_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderTimerLog)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010260 RID: 66144
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderTimerLog_ReleaseGraphicsResources_16(HandleRef pThis);

		/// <summary>
		/// Releases any resources allocated on the graphics device.
		/// </summary>
		// Token: 0x06010261 RID: 66145 RVA: 0x00167DAE File Offset: 0x00165FAE
		public virtual void ReleaseGraphicsResources()
		{
			vtkRenderTimerLog.vtkRenderTimerLog_ReleaseGraphicsResources_16(base.GetCppThis());
		}

		// Token: 0x06010262 RID: 66146
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderTimerLog_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// RAII struct for logging events. Such events start when
		/// vtkRenderTimerLog::StartScopedEvent(name) is called, and end when the
		/// returned object is destroyed, or ScopedEventLogger::Stop() is called.
		/// </summary>
		// Token: 0x06010263 RID: 66147 RVA: 0x00167DC0 File Offset: 0x00165FC0
		public new static vtkRenderTimerLog SafeDownCast(vtkObjectBase o)
		{
			vtkRenderTimerLog vtkRenderTimerLog = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderTimerLog.vtkRenderTimerLog_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderTimerLog = (vtkRenderTimerLog)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderTimerLog.Register(null);
				}
			}
			return vtkRenderTimerLog;
		}

		// Token: 0x06010264 RID: 66148
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderTimerLog_SetFrameLimit_18(HandleRef pThis, uint _arg);

		/// <summary>
		/// If there are more than FrameLimit frames pending/ready, drop the old ones
		/// until we are under this limit. Prevents things from backing up.
		/// Default is 32. Set to 0 to disable. @{
		/// </summary>
		// Token: 0x06010265 RID: 66149 RVA: 0x00167E3F File Offset: 0x0016603F
		public virtual void SetFrameLimit(uint _arg)
		{
			vtkRenderTimerLog.vtkRenderTimerLog_SetFrameLimit_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06010266 RID: 66150
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderTimerLog_SetLoggingEnabled_19(HandleRef pThis, byte _arg);

		/// <summary>
		/// If false, no events are recorded. Default is false. @{ 
		/// </summary>
		// Token: 0x06010267 RID: 66151 RVA: 0x00167E4F File Offset: 0x0016604F
		public virtual void SetLoggingEnabled(bool _arg)
		{
			vtkRenderTimerLog.vtkRenderTimerLog_SetLoggingEnabled_19(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012CA RID: 4810
		public new const string MRFullTypeName = "Kitware.VTK.vtkRenderTimerLog";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012CB RID: 4811
		public new static readonly string MRClassNameKey = "class vtkRenderTimerLog";
	}
}
