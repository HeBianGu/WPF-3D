using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTimerLog
	/// </summary>
	/// <remarks>
	///    Timer support and logging
	///
	/// vtkTimerLog contains walltime and cputime measurements associated
	/// with a given event.  These results can be later analyzed when
	/// "dumping out" the table.
	///
	/// In addition, vtkTimerLog allows the user to simply get the current
	/// time, and to start/stop a simple timer separate from the timing
	/// table logging.
	/// </remarks>
	// Token: 0x02000AFD RID: 2813
	public class vtkTimerLog : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D8DB RID: 121051 RVA: 0x0029C000 File Offset: 0x0029A200
		static vtkTimerLog()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTimerLog.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTimerLog"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D8DC RID: 121052 RVA: 0x0029C028 File Offset: 0x0029A228
		public vtkTimerLog(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D8DD RID: 121053
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTimerLog_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D8DE RID: 121054 RVA: 0x0029C038 File Offset: 0x0029A238
		public new static vtkTimerLog New()
		{
			vtkTimerLog result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTimerLog.vtkTimerLog_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTimerLog)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D8DF RID: 121055 RVA: 0x0029C08C File Offset: 0x0029A28C
		public vtkTimerLog() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTimerLog.vtkTimerLog_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D8E0 RID: 121056 RVA: 0x0029C0D0 File Offset: 0x0029A2D0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D8E1 RID: 121057
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTimerLog_CleanupLog_01();

		/// <summary>
		/// Remove timer log.
		/// </summary>
		// Token: 0x0601D8E2 RID: 121058 RVA: 0x0029C0DB File Offset: 0x0029A2DB
		public static void CleanupLog()
		{
			vtkTimerLog.vtkTimerLog_CleanupLog_01();
		}

		// Token: 0x0601D8E3 RID: 121059
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTimerLog_DumpLog_02([MarshalAs(UnmanagedType.LPUTF8Str)] string filename);

		/// <summary>
		/// Write the timing table out to a file.  Calculate some helpful
		/// statistics (deltas and percentages) in the process.
		/// </summary>
		// Token: 0x0601D8E4 RID: 121060 RVA: 0x0029C0E4 File Offset: 0x0029A2E4
		public static void DumpLog(string filename)
		{
			vtkTimerLog.vtkTimerLog_DumpLog_02(filename);
		}

		// Token: 0x0601D8E5 RID: 121061
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTimerLog_FormatAndMarkEvent_03([MarshalAs(UnmanagedType.LPUTF8Str)] string format);

		/// <summary>
		/// Record a timing event.  The event is represented by a formatted
		/// string.  The internal buffer is 4096 bytes and will truncate anything longer.
		/// </summary>
		// Token: 0x0601D8E6 RID: 121062 RVA: 0x0029C0EE File Offset: 0x0029A2EE
		public static void FormatAndMarkEvent(string format)
		{
			vtkTimerLog.vtkTimerLog_FormatAndMarkEvent_03(format);
		}

		// Token: 0x0601D8E7 RID: 121063
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTimerLog_GetCPUTime_04();

		/// <summary>
		/// Returns the CPU time for this process
		/// On Win32 platforms this actually returns wall time.
		/// </summary>
		// Token: 0x0601D8E8 RID: 121064 RVA: 0x0029C0F8 File Offset: 0x0029A2F8
		public static double GetCPUTime()
		{
			return vtkTimerLog.vtkTimerLog_GetCPUTime_04();
		}

		// Token: 0x0601D8E9 RID: 121065
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTimerLog_GetElapsedTime_05(HandleRef pThis);

		/// <summary>
		/// Returns the difference between StartTime and EndTime as
		/// a doubleing point value indicating the elapsed time in seconds.
		/// </summary>
		// Token: 0x0601D8EA RID: 121066 RVA: 0x0029C114 File Offset: 0x0029A314
		public double GetElapsedTime()
		{
			return vtkTimerLog.vtkTimerLog_GetElapsedTime_05(base.GetCppThis());
		}

		// Token: 0x0601D8EB RID: 121067
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTimerLog_GetEventIndent_06(int i);

		/// <summary>
		/// Programmatic access to events.  Indexed from 0 to num-1.
		/// </summary>
		// Token: 0x0601D8EC RID: 121068 RVA: 0x0029C134 File Offset: 0x0029A334
		public static int GetEventIndent(int i)
		{
			return vtkTimerLog.vtkTimerLog_GetEventIndent_06(i);
		}

		// Token: 0x0601D8ED RID: 121069
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTimerLog_GetEventString_07(int i);

		/// <summary>
		/// Programmatic access to events.  Indexed from 0 to num-1.
		/// </summary>
		// Token: 0x0601D8EE RID: 121070 RVA: 0x0029C150 File Offset: 0x0029A350
		public static string GetEventString(int i)
		{
			string s = Marshal.PtrToStringAnsi(vtkTimerLog.vtkTimerLog_GetEventString_07(i));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601D8EF RID: 121071
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTimerLog_GetEventWallTime_08(int i);

		/// <summary>
		/// Programmatic access to events.  Indexed from 0 to num-1.
		/// </summary>
		// Token: 0x0601D8F0 RID: 121072 RVA: 0x0029C188 File Offset: 0x0029A388
		public static double GetEventWallTime(int i)
		{
			return vtkTimerLog.vtkTimerLog_GetEventWallTime_08(i);
		}

		// Token: 0x0601D8F1 RID: 121073
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTimerLog_GetLogging_09();

		/// <summary>
		/// This flag will turn logging of events off or on.
		/// By default, logging is on.
		/// </summary>
		// Token: 0x0601D8F2 RID: 121074 RVA: 0x0029C1A4 File Offset: 0x0029A3A4
		public static int GetLogging()
		{
			return vtkTimerLog.vtkTimerLog_GetLogging_09();
		}

		// Token: 0x0601D8F3 RID: 121075
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTimerLog_GetMaxEntries_10();

		/// <summary>
		/// Set/Get the maximum number of entries allowed in the timer log
		/// </summary>
		// Token: 0x0601D8F4 RID: 121076 RVA: 0x0029C1C0 File Offset: 0x0029A3C0
		public static int GetMaxEntries()
		{
			return vtkTimerLog.vtkTimerLog_GetMaxEntries_10();
		}

		// Token: 0x0601D8F5 RID: 121077
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTimerLog_GetNumberOfEvents_11();

		/// <summary>
		/// Programmatic access to events.  Indexed from 0 to num-1.
		/// </summary>
		// Token: 0x0601D8F6 RID: 121078 RVA: 0x0029C1DC File Offset: 0x0029A3DC
		public static int GetNumberOfEvents()
		{
			return vtkTimerLog.vtkTimerLog_GetNumberOfEvents_11();
		}

		// Token: 0x0601D8F7 RID: 121079
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTimerLog_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D8F8 RID: 121080 RVA: 0x0029C1F8 File Offset: 0x0029A3F8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTimerLog.vtkTimerLog_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x0601D8F9 RID: 121081
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTimerLog_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D8FA RID: 121082 RVA: 0x0029C218 File Offset: 0x0029A418
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTimerLog.vtkTimerLog_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x0601D8FB RID: 121083
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTimerLog_GetUniversalTime_14();

		/// <summary>
		/// Returns the elapsed number of seconds since 00:00:00 Coordinated Universal
		/// Time (UTC), Thursday, 1 January 1970. This is also called Unix Time.
		/// </summary>
		// Token: 0x0601D8FC RID: 121084 RVA: 0x0029C234 File Offset: 0x0029A434
		public static double GetUniversalTime()
		{
			return vtkTimerLog.vtkTimerLog_GetUniversalTime_14();
		}

		// Token: 0x0601D8FD RID: 121085
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTimerLog_InsertTimedEvent_15([MarshalAs(UnmanagedType.LPUTF8Str)] string EventString, double time, int cpuTicks);

		/// <summary>
		/// Insert an event with a known wall time value (in seconds)
		/// and cpuTicks.
		/// </summary>
		// Token: 0x0601D8FE RID: 121086 RVA: 0x0029C24D File Offset: 0x0029A44D
		public static void InsertTimedEvent(string EventString, double time, int cpuTicks)
		{
			vtkTimerLog.vtkTimerLog_InsertTimedEvent_15(EventString, time, cpuTicks);
		}

		// Token: 0x0601D8FF RID: 121087
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTimerLog_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D900 RID: 121088 RVA: 0x0029C25C File Offset: 0x0029A45C
		public override int IsA(string type)
		{
			return vtkTimerLog.vtkTimerLog_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x0601D901 RID: 121089
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTimerLog_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D902 RID: 121090 RVA: 0x0029C27C File Offset: 0x0029A47C
		public new static int IsTypeOf(string type)
		{
			return vtkTimerLog.vtkTimerLog_IsTypeOf_17(type);
		}

		// Token: 0x0601D903 RID: 121091
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTimerLog_LoggingOff_18();

		/// <summary>
		/// This flag will turn logging of events off or on.
		/// By default, logging is on.
		/// </summary>
		// Token: 0x0601D904 RID: 121092 RVA: 0x0029C296 File Offset: 0x0029A496
		public static void LoggingOff()
		{
			vtkTimerLog.vtkTimerLog_LoggingOff_18();
		}

		// Token: 0x0601D905 RID: 121093
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTimerLog_LoggingOn_19();

		/// <summary>
		/// This flag will turn logging of events off or on.
		/// By default, logging is on.
		/// </summary>
		// Token: 0x0601D906 RID: 121094 RVA: 0x0029C29F File Offset: 0x0029A49F
		public static void LoggingOn()
		{
			vtkTimerLog.vtkTimerLog_LoggingOn_19();
		}

		// Token: 0x0601D907 RID: 121095
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTimerLog_MarkEndEvent_20([MarshalAs(UnmanagedType.LPUTF8Str)] string EventString);

		/// <summary>
		/// I want to time events, so I am creating this interface to
		/// mark events that have a start and an end.  These events can be,
		/// nested. The standard Dumplog ignores the indents.
		/// </summary>
		// Token: 0x0601D908 RID: 121096 RVA: 0x0029C2A8 File Offset: 0x0029A4A8
		public static void MarkEndEvent(string EventString)
		{
			vtkTimerLog.vtkTimerLog_MarkEndEvent_20(EventString);
		}

		// Token: 0x0601D909 RID: 121097
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTimerLog_MarkEvent_21([MarshalAs(UnmanagedType.LPUTF8Str)] string EventString);

		/// <summary>
		/// Record a timing event and capture wall time and cpu ticks.
		/// </summary>
		// Token: 0x0601D90A RID: 121098 RVA: 0x0029C2B2 File Offset: 0x0029A4B2
		public static void MarkEvent(string EventString)
		{
			vtkTimerLog.vtkTimerLog_MarkEvent_21(EventString);
		}

		// Token: 0x0601D90B RID: 121099
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTimerLog_MarkStartEvent_22([MarshalAs(UnmanagedType.LPUTF8Str)] string EventString);

		/// <summary>
		/// I want to time events, so I am creating this interface to
		/// mark events that have a start and an end.  These events can be,
		/// nested. The standard Dumplog ignores the indents.
		/// </summary>
		// Token: 0x0601D90C RID: 121100 RVA: 0x0029C2BC File Offset: 0x0029A4BC
		public static void MarkStartEvent(string EventString)
		{
			vtkTimerLog.vtkTimerLog_MarkStartEvent_22(EventString);
		}

		// Token: 0x0601D90D RID: 121101
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTimerLog_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D90E RID: 121102 RVA: 0x0029C2C8 File Offset: 0x0029A4C8
		public new vtkTimerLog NewInstance()
		{
			vtkTimerLog result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTimerLog.vtkTimerLog_NewInstance_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTimerLog)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D90F RID: 121103
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTimerLog_ResetLog_25();

		/// <summary>
		/// Clear the timing table.  walltime and cputime will also be set
		/// to zero when the first new event is recorded.
		/// </summary>
		// Token: 0x0601D910 RID: 121104 RVA: 0x0029C322 File Offset: 0x0029A522
		public static void ResetLog()
		{
			vtkTimerLog.vtkTimerLog_ResetLog_25();
		}

		// Token: 0x0601D911 RID: 121105
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTimerLog_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D912 RID: 121106 RVA: 0x0029C32C File Offset: 0x0029A52C
		public new static vtkTimerLog SafeDownCast(vtkObjectBase o)
		{
			vtkTimerLog vtkTimerLog = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTimerLog.vtkTimerLog_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTimerLog = (vtkTimerLog)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTimerLog.Register(null);
				}
			}
			return vtkTimerLog;
		}

		// Token: 0x0601D913 RID: 121107
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTimerLog_SetLogging_27(int v);

		/// <summary>
		/// This flag will turn logging of events off or on.
		/// By default, logging is on.
		/// </summary>
		// Token: 0x0601D914 RID: 121108 RVA: 0x0029C3AB File Offset: 0x0029A5AB
		public static void SetLogging(int v)
		{
			vtkTimerLog.vtkTimerLog_SetLogging_27(v);
		}

		// Token: 0x0601D915 RID: 121109
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTimerLog_SetMaxEntries_28(int a);

		/// <summary>
		/// Set/Get the maximum number of entries allowed in the timer log
		/// </summary>
		// Token: 0x0601D916 RID: 121110 RVA: 0x0029C3B5 File Offset: 0x0029A5B5
		public static void SetMaxEntries(int a)
		{
			vtkTimerLog.vtkTimerLog_SetMaxEntries_28(a);
		}

		// Token: 0x0601D917 RID: 121111
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTimerLog_StartTimer_29(HandleRef pThis);

		/// <summary>
		/// Set the StartTime to the current time. Used with GetElapsedTime().
		/// </summary>
		// Token: 0x0601D918 RID: 121112 RVA: 0x0029C3BF File Offset: 0x0029A5BF
		public void StartTimer()
		{
			vtkTimerLog.vtkTimerLog_StartTimer_29(base.GetCppThis());
		}

		// Token: 0x0601D919 RID: 121113
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTimerLog_StopTimer_30(HandleRef pThis);

		/// <summary>
		/// Sets EndTime to the current time. Used with GetElapsedTime().
		/// </summary>
		// Token: 0x0601D91A RID: 121114 RVA: 0x0029C3CE File Offset: 0x0029A5CE
		public void StopTimer()
		{
			vtkTimerLog.vtkTimerLog_StopTimer_30(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F21 RID: 7969
		public new const string MRFullTypeName = "Kitware.VTK.vtkTimerLog";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F22 RID: 7970
		public new static readonly string MRClassNameKey = "class vtkTimerLog";
	}
}
