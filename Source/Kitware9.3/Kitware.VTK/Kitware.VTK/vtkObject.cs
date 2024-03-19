using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkObject
	/// </summary>
	/// <remarks>
	///    abstract base class for most VTK objects
	///
	/// vtkObject is the base class for most objects in the visualization
	/// toolkit. vtkObject provides methods for tracking modification time,
	/// debugging, printing, and event callbacks. Most objects created
	/// within the VTK framework should be a subclass of vtkObject or one
	/// of its children.  The few exceptions tend to be very small helper
	/// classes that usually never get instantiated or situations where
	/// multiple inheritance gets in the way.  vtkObject also performs
	/// reference counting: objects that are reference counted exist as
	/// long as another object uses them. Once the last reference to a
	/// reference counted object is removed, the object will spontaneously
	/// destruct.
	///
	/// @warning
	/// Note: in VTK objects should always be created with the New() method
	/// and deleted with the Delete() method. VTK objects cannot be
	/// allocated off the stack (i.e., automatic objects) because the
	/// constructor is a protected method.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCommand vtkTimeStamp
	/// </seealso>
	// Token: 0x02000004 RID: 4
	public class vtkObject : vtkObjectBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600002B RID: 43 RVA: 0x00002456 File Offset: 0x00000656
		static vtkObject()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkObject.MRClassNameKey, Type.GetType("Kitware.VTK.vtkObject"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600002C RID: 44 RVA: 0x0000247E File Offset: 0x0000067E
		public vtkObject(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600002D RID: 45
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkObject_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create an object with Debug turned off, modified time initialized
		/// to zero, and reference counting on.
		/// </summary>
		// Token: 0x0600002E RID: 46 RVA: 0x0000248C File Offset: 0x0000068C
		public new static vtkObject New()
		{
			vtkObject result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkObject.vtkObject_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create an object with Debug turned off, modified time initialized
		/// to zero, and reference counting on.
		/// </summary>
		// Token: 0x0600002F RID: 47 RVA: 0x000024E0 File Offset: 0x000006E0
		public vtkObject() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkObject.vtkObject_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000030 RID: 48 RVA: 0x00002524 File Offset: 0x00000724
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000031 RID: 49
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkObject_AddObserver_01(HandleRef pThis, uint arg0, HandleRef arg1, float priority);

		/// <summary>
		/// Allow people to add/remove/invoke observers (callbacks) to any VTK
		/// object.  This is an implementation of the subject/observer design
		/// pattern. An observer is added by specifying an event to respond to
		/// and a vtkCommand to execute. It returns an unsigned long tag which
		/// can be used later to remove the event or retrieve the command.
		/// When events are invoked, the observers are called in the order they
		/// were added. If a priority value is specified, then the higher
		/// priority commands are called first. A command may set an abort
		/// flag to stop processing of the event. (See vtkCommand.h for more
		/// information.)
		/// </summary>
		// Token: 0x06000032 RID: 50 RVA: 0x00002530 File Offset: 0x00000730
		public uint AddObserver(uint arg0, vtkCommand arg1, float priority)
		{
			return vtkObject.vtkObject_AddObserver_01(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), priority);
		}

		// Token: 0x06000033 RID: 51
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkObject_AddObserver_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0, HandleRef arg1, float priority);

		/// <summary>
		/// Allow people to add/remove/invoke observers (callbacks) to any VTK
		/// object.  This is an implementation of the subject/observer design
		/// pattern. An observer is added by specifying an event to respond to
		/// and a vtkCommand to execute. It returns an unsigned long tag which
		/// can be used later to remove the event or retrieve the command.
		/// When events are invoked, the observers are called in the order they
		/// were added. If a priority value is specified, then the higher
		/// priority commands are called first. A command may set an abort
		/// flag to stop processing of the event. (See vtkCommand.h for more
		/// information.)
		/// </summary>
		// Token: 0x06000034 RID: 52 RVA: 0x00002568 File Offset: 0x00000768
		public uint AddObserver(string arg0, vtkCommand arg1, float priority)
		{
			return vtkObject.vtkObject_AddObserver_02(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), priority);
		}

		// Token: 0x06000035 RID: 53
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObject_BreakOnError_03();

		/// <summary>
		/// This method is called when vtkErrorMacro executes. It allows
		/// the debugger to break on error.
		/// </summary>
		// Token: 0x06000036 RID: 54 RVA: 0x0000259E File Offset: 0x0000079E
		public static void BreakOnError()
		{
			vtkObject.vtkObject_BreakOnError_03();
		}

		// Token: 0x06000037 RID: 55
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObject_DebugOff_04(HandleRef pThis);

		/// <summary>
		/// Turn debugging output off.
		/// </summary>
		// Token: 0x06000038 RID: 56 RVA: 0x000025A7 File Offset: 0x000007A7
		public virtual void DebugOff()
		{
			vtkObject.vtkObject_DebugOff_04(base.GetCppThis());
		}

		// Token: 0x06000039 RID: 57
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObject_DebugOn_05(HandleRef pThis);

		/// <summary>
		/// Turn debugging output on.
		/// </summary>
		// Token: 0x0600003A RID: 58 RVA: 0x000025B6 File Offset: 0x000007B6
		public virtual void DebugOn()
		{
			vtkObject.vtkObject_DebugOn_05(base.GetCppThis());
		}

		// Token: 0x0600003B RID: 59
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkObject_GetCommand_06(HandleRef pThis, uint tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Allow people to add/remove/invoke observers (callbacks) to any VTK
		/// object.  This is an implementation of the subject/observer design
		/// pattern. An observer is added by specifying an event to respond to
		/// and a vtkCommand to execute. It returns an unsigned long tag which
		/// can be used later to remove the event or retrieve the command.
		/// When events are invoked, the observers are called in the order they
		/// were added. If a priority value is specified, then the higher
		/// priority commands are called first. A command may set an abort
		/// flag to stop processing of the event. (See vtkCommand.h for more
		/// information.)
		/// </summary>
		// Token: 0x0600003C RID: 60 RVA: 0x000025C8 File Offset: 0x000007C8
		public vtkCommand GetCommand(uint tag)
		{
			vtkCommand vtkCommand = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkObject.vtkObject_GetCommand_06(base.GetCppThis(), tag, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCommand = (vtkCommand)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCommand.Register(null);
				}
			}
			return vtkCommand;
		}

		// Token: 0x0600003D RID: 61
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkObject_GetDebug_07(HandleRef pThis);

		/// <summary>
		/// Get the value of the debug flag.
		/// </summary>
		// Token: 0x0600003E RID: 62 RVA: 0x00002638 File Offset: 0x00000838
		public bool GetDebug()
		{
			return vtkObject.vtkObject_GetDebug_07(base.GetCppThis()) != 0;
		}

		// Token: 0x0600003F RID: 63
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkObject_GetGlobalWarningDisplay_08();

		/// <summary>
		/// This is a global flag that controls whether any debug, warning
		/// or error messages are displayed.
		/// </summary>
		// Token: 0x06000040 RID: 64 RVA: 0x00002660 File Offset: 0x00000860
		public static int GetGlobalWarningDisplay()
		{
			return vtkObject.vtkObject_GetGlobalWarningDisplay_08();
		}

		// Token: 0x06000041 RID: 65
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkObject_GetMTime_09(HandleRef pThis);

		/// <summary>
		/// Return this object's modified time.
		/// </summary>
		// Token: 0x06000042 RID: 66 RVA: 0x0000267C File Offset: 0x0000087C
		public virtual ulong GetMTime()
		{
			return vtkObject.vtkObject_GetMTime_09(base.GetCppThis());
		}

		// Token: 0x06000043 RID: 67
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkObject_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000044 RID: 68 RVA: 0x0000269C File Offset: 0x0000089C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkObject.vtkObject_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x06000045 RID: 69
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkObject_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000046 RID: 70 RVA: 0x000026BC File Offset: 0x000008BC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkObject.vtkObject_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x06000047 RID: 71
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkObject_GetObjectDescription_12(HandleRef pThis);

		/// <summary>
		/// The object description printed in messages and PrintSelf
		/// output. To be used only for reporting purposes.
		/// </summary>
		// Token: 0x06000048 RID: 72 RVA: 0x000026D8 File Offset: 0x000008D8
		public override string GetObjectDescription()
		{
			return vtkObject.vtkObject_GetObjectDescription_12(base.GetCppThis());
		}

		// Token: 0x06000049 RID: 73
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkObject_GetObjectName_13(HandleRef pThis);

		/// <summary>
		/// Set/get the name of this object for reporting purposes. The name appears in
		/// warning and debug messages and in the Print output. Setting the object name
		/// does not change the MTime and does not invoke a ModifiedEvent. Derived
		/// classes implementing copying methods are expected not to copy the ObjectName.
		/// </summary>
		// Token: 0x0600004A RID: 74 RVA: 0x000026F8 File Offset: 0x000008F8
		public virtual string GetObjectName()
		{
			return vtkObject.vtkObject_GetObjectName_13(base.GetCppThis());
		}

		// Token: 0x0600004B RID: 75
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObject_GlobalWarningDisplayOff_14();

		/// <summary>
		/// This is a global flag that controls whether any debug, warning
		/// or error messages are displayed.
		/// </summary>
		// Token: 0x0600004C RID: 76 RVA: 0x00002717 File Offset: 0x00000917
		public static void GlobalWarningDisplayOff()
		{
			vtkObject.vtkObject_GlobalWarningDisplayOff_14();
		}

		// Token: 0x0600004D RID: 77
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObject_GlobalWarningDisplayOn_15();

		/// <summary>
		/// This is a global flag that controls whether any debug, warning
		/// or error messages are displayed.
		/// </summary>
		// Token: 0x0600004E RID: 78 RVA: 0x00002720 File Offset: 0x00000920
		public static void GlobalWarningDisplayOn()
		{
			vtkObject.vtkObject_GlobalWarningDisplayOn_15();
		}

		// Token: 0x0600004F RID: 79
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkObject_HasObserver_16(HandleRef pThis, uint arg0, HandleRef arg1);

		/// <summary>
		/// Allow people to add/remove/invoke observers (callbacks) to any VTK
		/// object.  This is an implementation of the subject/observer design
		/// pattern. An observer is added by specifying an event to respond to
		/// and a vtkCommand to execute. It returns an unsigned long tag which
		/// can be used later to remove the event or retrieve the command.
		/// When events are invoked, the observers are called in the order they
		/// were added. If a priority value is specified, then the higher
		/// priority commands are called first. A command may set an abort
		/// flag to stop processing of the event. (See vtkCommand.h for more
		/// information.)
		/// </summary>
		// Token: 0x06000050 RID: 80 RVA: 0x0000272C File Offset: 0x0000092C
		public int HasObserver(uint arg0, vtkCommand arg1)
		{
			return vtkObject.vtkObject_HasObserver_16(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06000051 RID: 81
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkObject_HasObserver_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0, HandleRef arg1);

		/// <summary>
		/// Allow people to add/remove/invoke observers (callbacks) to any VTK
		/// object.  This is an implementation of the subject/observer design
		/// pattern. An observer is added by specifying an event to respond to
		/// and a vtkCommand to execute. It returns an unsigned long tag which
		/// can be used later to remove the event or retrieve the command.
		/// When events are invoked, the observers are called in the order they
		/// were added. If a priority value is specified, then the higher
		/// priority commands are called first. A command may set an abort
		/// flag to stop processing of the event. (See vtkCommand.h for more
		/// information.)
		/// </summary>
		// Token: 0x06000052 RID: 82 RVA: 0x00002764 File Offset: 0x00000964
		public int HasObserver(string arg0, vtkCommand arg1)
		{
			return vtkObject.vtkObject_HasObserver_17(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06000053 RID: 83
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkObject_HasObserver_18(HandleRef pThis, uint arg0);

		/// <summary>
		/// Allow people to add/remove/invoke observers (callbacks) to any VTK
		/// object.  This is an implementation of the subject/observer design
		/// pattern. An observer is added by specifying an event to respond to
		/// and a vtkCommand to execute. It returns an unsigned long tag which
		/// can be used later to remove the event or retrieve the command.
		/// When events are invoked, the observers are called in the order they
		/// were added. If a priority value is specified, then the higher
		/// priority commands are called first. A command may set an abort
		/// flag to stop processing of the event. (See vtkCommand.h for more
		/// information.)
		/// </summary>
		// Token: 0x06000054 RID: 84 RVA: 0x0000279C File Offset: 0x0000099C
		public int HasObserver(uint arg0)
		{
			return vtkObject.vtkObject_HasObserver_18(base.GetCppThis(), arg0);
		}

		// Token: 0x06000055 RID: 85
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkObject_HasObserver_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Allow people to add/remove/invoke observers (callbacks) to any VTK
		/// object.  This is an implementation of the subject/observer design
		/// pattern. An observer is added by specifying an event to respond to
		/// and a vtkCommand to execute. It returns an unsigned long tag which
		/// can be used later to remove the event or retrieve the command.
		/// When events are invoked, the observers are called in the order they
		/// were added. If a priority value is specified, then the higher
		/// priority commands are called first. A command may set an abort
		/// flag to stop processing of the event. (See vtkCommand.h for more
		/// information.)
		/// </summary>
		// Token: 0x06000056 RID: 86 RVA: 0x000027BC File Offset: 0x000009BC
		public int HasObserver(string arg0)
		{
			return vtkObject.vtkObject_HasObserver_19(base.GetCppThis(), arg0);
		}

		// Token: 0x06000057 RID: 87
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkObject_InvokeEvent_20(HandleRef pThis, uint arg0, IntPtr callData);

		/// <summary>
		/// This method invokes an event and return whether the event was
		/// aborted or not. If the event was aborted, the return value is 1,
		/// otherwise it is 0.
		/// </summary>
		// Token: 0x06000058 RID: 88 RVA: 0x000027DC File Offset: 0x000009DC
		public int InvokeEvent(uint arg0, IntPtr callData)
		{
			return vtkObject.vtkObject_InvokeEvent_20(base.GetCppThis(), arg0, callData);
		}

		// Token: 0x06000059 RID: 89
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkObject_InvokeEvent_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0, IntPtr callData);

		/// <summary>
		/// This method invokes an event and return whether the event was
		/// aborted or not. If the event was aborted, the return value is 1,
		/// otherwise it is 0.
		/// </summary>
		// Token: 0x0600005A RID: 90 RVA: 0x00002800 File Offset: 0x00000A00
		public int InvokeEvent(string arg0, IntPtr callData)
		{
			return vtkObject.vtkObject_InvokeEvent_21(base.GetCppThis(), arg0, callData);
		}

		// Token: 0x0600005B RID: 91
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkObject_InvokeEvent_22(HandleRef pThis, uint arg0);

		/// <summary>
		/// This method invokes an event and return whether the event was
		/// aborted or not. If the event was aborted, the return value is 1,
		/// otherwise it is 0.
		/// </summary>
		// Token: 0x0600005C RID: 92 RVA: 0x00002824 File Offset: 0x00000A24
		public int InvokeEvent(uint arg0)
		{
			return vtkObject.vtkObject_InvokeEvent_22(base.GetCppThis(), arg0);
		}

		// Token: 0x0600005D RID: 93
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkObject_InvokeEvent_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// This method invokes an event and return whether the event was
		/// aborted or not. If the event was aborted, the return value is 1,
		/// otherwise it is 0.
		/// </summary>
		// Token: 0x0600005E RID: 94 RVA: 0x00002844 File Offset: 0x00000A44
		public int InvokeEvent(string arg0)
		{
			return vtkObject.vtkObject_InvokeEvent_23(base.GetCppThis(), arg0);
		}

		// Token: 0x0600005F RID: 95
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkObject_IsA_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000060 RID: 96 RVA: 0x00002864 File Offset: 0x00000A64
		public override int IsA(string type)
		{
			return vtkObject.vtkObject_IsA_24(base.GetCppThis(), type);
		}

		// Token: 0x06000061 RID: 97
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkObject_IsTypeOf_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000062 RID: 98 RVA: 0x00002884 File Offset: 0x00000A84
		public new static int IsTypeOf(string type)
		{
			return vtkObject.vtkObject_IsTypeOf_25(type);
		}

		// Token: 0x06000063 RID: 99
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObject_Modified_26(HandleRef pThis);

		/// <summary>
		/// Update the modification time for this object. Many filters rely on
		/// the modification time to determine if they need to recompute their
		/// data. The modification time is a unique monotonically increasing
		/// unsigned long integer.
		/// </summary>
		// Token: 0x06000064 RID: 100 RVA: 0x0000289E File Offset: 0x00000A9E
		public virtual void Modified()
		{
			vtkObject.vtkObject_Modified_26(base.GetCppThis());
		}

		// Token: 0x06000065 RID: 101
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkObject_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000066 RID: 102 RVA: 0x000028B0 File Offset: 0x00000AB0
		public vtkObject NewInstance()
		{
			vtkObject result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkObject.vtkObject_NewInstance_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000067 RID: 103
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObject_RemoveAllObservers_29(HandleRef pThis);

		/// <summary>
		/// Allow people to add/remove/invoke observers (callbacks) to any VTK
		/// object.  This is an implementation of the subject/observer design
		/// pattern. An observer is added by specifying an event to respond to
		/// and a vtkCommand to execute. It returns an unsigned long tag which
		/// can be used later to remove the event or retrieve the command.
		/// When events are invoked, the observers are called in the order they
		/// were added. If a priority value is specified, then the higher
		/// priority commands are called first. A command may set an abort
		/// flag to stop processing of the event. (See vtkCommand.h for more
		/// information.)
		/// </summary>
		// Token: 0x06000068 RID: 104 RVA: 0x0000290A File Offset: 0x00000B0A
		public void RemoveAllObservers()
		{
			vtkObject.vtkObject_RemoveAllObservers_29(base.GetCppThis());
		}

		// Token: 0x06000069 RID: 105
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObject_RemoveObserver_30(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Allow people to add/remove/invoke observers (callbacks) to any VTK
		/// object.  This is an implementation of the subject/observer design
		/// pattern. An observer is added by specifying an event to respond to
		/// and a vtkCommand to execute. It returns an unsigned long tag which
		/// can be used later to remove the event or retrieve the command.
		/// When events are invoked, the observers are called in the order they
		/// were added. If a priority value is specified, then the higher
		/// priority commands are called first. A command may set an abort
		/// flag to stop processing of the event. (See vtkCommand.h for more
		/// information.)
		/// </summary>
		// Token: 0x0600006A RID: 106 RVA: 0x0000291C File Offset: 0x00000B1C
		public void RemoveObserver(vtkCommand arg0)
		{
			vtkObject.vtkObject_RemoveObserver_30(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600006B RID: 107
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObject_RemoveObserver_31(HandleRef pThis, uint tag);

		/// <summary>
		/// Allow people to add/remove/invoke observers (callbacks) to any VTK
		/// object.  This is an implementation of the subject/observer design
		/// pattern. An observer is added by specifying an event to respond to
		/// and a vtkCommand to execute. It returns an unsigned long tag which
		/// can be used later to remove the event or retrieve the command.
		/// When events are invoked, the observers are called in the order they
		/// were added. If a priority value is specified, then the higher
		/// priority commands are called first. A command may set an abort
		/// flag to stop processing of the event. (See vtkCommand.h for more
		/// information.)
		/// </summary>
		// Token: 0x0600006C RID: 108 RVA: 0x0000294B File Offset: 0x00000B4B
		public void RemoveObserver(uint tag)
		{
			vtkObject.vtkObject_RemoveObserver_31(base.GetCppThis(), tag);
		}

		// Token: 0x0600006D RID: 109
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObject_RemoveObservers_32(HandleRef pThis, uint arg0, HandleRef arg1);

		/// <summary>
		/// Allow people to add/remove/invoke observers (callbacks) to any VTK
		/// object.  This is an implementation of the subject/observer design
		/// pattern. An observer is added by specifying an event to respond to
		/// and a vtkCommand to execute. It returns an unsigned long tag which
		/// can be used later to remove the event or retrieve the command.
		/// When events are invoked, the observers are called in the order they
		/// were added. If a priority value is specified, then the higher
		/// priority commands are called first. A command may set an abort
		/// flag to stop processing of the event. (See vtkCommand.h for more
		/// information.)
		/// </summary>
		// Token: 0x0600006E RID: 110 RVA: 0x0000295C File Offset: 0x00000B5C
		public void RemoveObservers(uint arg0, vtkCommand arg1)
		{
			vtkObject.vtkObject_RemoveObservers_32(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0600006F RID: 111
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObject_RemoveObservers_33(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0, HandleRef arg1);

		/// <summary>
		/// Allow people to add/remove/invoke observers (callbacks) to any VTK
		/// object.  This is an implementation of the subject/observer design
		/// pattern. An observer is added by specifying an event to respond to
		/// and a vtkCommand to execute. It returns an unsigned long tag which
		/// can be used later to remove the event or retrieve the command.
		/// When events are invoked, the observers are called in the order they
		/// were added. If a priority value is specified, then the higher
		/// priority commands are called first. A command may set an abort
		/// flag to stop processing of the event. (See vtkCommand.h for more
		/// information.)
		/// </summary>
		// Token: 0x06000070 RID: 112 RVA: 0x0000298C File Offset: 0x00000B8C
		public void RemoveObservers(string arg0, vtkCommand arg1)
		{
			vtkObject.vtkObject_RemoveObservers_33(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06000071 RID: 113
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObject_RemoveObservers_34(HandleRef pThis, uint arg0);

		/// <summary>
		/// Allow people to add/remove/invoke observers (callbacks) to any VTK
		/// object.  This is an implementation of the subject/observer design
		/// pattern. An observer is added by specifying an event to respond to
		/// and a vtkCommand to execute. It returns an unsigned long tag which
		/// can be used later to remove the event or retrieve the command.
		/// When events are invoked, the observers are called in the order they
		/// were added. If a priority value is specified, then the higher
		/// priority commands are called first. A command may set an abort
		/// flag to stop processing of the event. (See vtkCommand.h for more
		/// information.)
		/// </summary>
		// Token: 0x06000072 RID: 114 RVA: 0x000029BC File Offset: 0x00000BBC
		public void RemoveObservers(uint arg0)
		{
			vtkObject.vtkObject_RemoveObservers_34(base.GetCppThis(), arg0);
		}

		// Token: 0x06000073 RID: 115
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObject_RemoveObservers_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Allow people to add/remove/invoke observers (callbacks) to any VTK
		/// object.  This is an implementation of the subject/observer design
		/// pattern. An observer is added by specifying an event to respond to
		/// and a vtkCommand to execute. It returns an unsigned long tag which
		/// can be used later to remove the event or retrieve the command.
		/// When events are invoked, the observers are called in the order they
		/// were added. If a priority value is specified, then the higher
		/// priority commands are called first. A command may set an abort
		/// flag to stop processing of the event. (See vtkCommand.h for more
		/// information.)
		/// </summary>
		// Token: 0x06000074 RID: 116 RVA: 0x000029CC File Offset: 0x00000BCC
		public void RemoveObservers(string arg0)
		{
			vtkObject.vtkObject_RemoveObservers_35(base.GetCppThis(), arg0);
		}

		// Token: 0x06000075 RID: 117
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkObject_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000076 RID: 118 RVA: 0x000029DC File Offset: 0x00000BDC
		public static vtkObject SafeDownCast(vtkObjectBase o)
		{
			vtkObject vtkObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkObject.vtkObject_SafeDownCast_36((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkObject = (vtkObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkObject.Register(null);
				}
			}
			return vtkObject;
		}

		// Token: 0x06000077 RID: 119
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObject_SetDebug_37(HandleRef pThis, byte debugFlag);

		/// <summary>
		/// Set the value of the debug flag. A true value turns debugging on.
		/// </summary>
		// Token: 0x06000078 RID: 120 RVA: 0x00002A5B File Offset: 0x00000C5B
		public void SetDebug(bool debugFlag)
		{
			vtkObject.vtkObject_SetDebug_37(base.GetCppThis(), debugFlag ? (byte)1 : (byte)0);
		}

		// Token: 0x06000079 RID: 121
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObject_SetGlobalWarningDisplay_38(int val);

		/// <summary>
		/// This is a global flag that controls whether any debug, warning
		/// or error messages are displayed.
		/// </summary>
		// Token: 0x0600007A RID: 122 RVA: 0x00002A73 File Offset: 0x00000C73
		public static void SetGlobalWarningDisplay(int val)
		{
			vtkObject.vtkObject_SetGlobalWarningDisplay_38(val);
		}

		// Token: 0x0600007B RID: 123
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObject_SetObjectName_39(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string objectName);

		/// <summary>
		/// Set/get the name of this object for reporting purposes. The name appears in
		/// warning and debug messages and in the Print output. Setting the object name
		/// does not change the MTime and does not invoke a ModifiedEvent. Derived
		/// classes implementing copying methods are expected not to copy the ObjectName.
		/// </summary>
		// Token: 0x0600007C RID: 124 RVA: 0x00002A7D File Offset: 0x00000C7D
		public virtual void SetObjectName(string objectName)
		{
			vtkObject.vtkObject_SetObjectName_39(base.GetCppThis(), objectName);
		}

		// Token: 0x0600007D RID: 125
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		private static extern string vtkObject_Print(HandleRef pThis);

		/// <summary>
		/// Returns the result of calling vtkObject::Print as a C# string.
		/// </summary>
		// Token: 0x0600007E RID: 126 RVA: 0x00002A90 File Offset: 0x00000C90
		public override string ToString()
		{
			return vtkObject.vtkObject_Print(base.GetCppThis());
		}

		/// <summary>
		/// The AbortCheckEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.AbortCheckEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600007F RID: 127 RVA: 0x00002AB0 File Offset: 0x00000CB0
		// (remove) Token: 0x06000080 RID: 128 RVA: 0x00002AFC File Offset: 0x00000CFC
		public event vtkObject.vtkObjectEventHandler AbortCheckEvt
		{
			add
			{
				if (null == this.AbortCheckEvtRelay)
				{
					this.AbortCheckEvtRelay = new vtkObjectEventRelay(this, 10U);
				}
				if (null != this.AbortCheckEvtRelay)
				{
					this.AbortCheckEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.AbortCheckEvtRelay)
				{
					this.AbortCheckEvtRelay.RemoveHandler(value);
					if (!this.AbortCheckEvtRelay.HasHandlers())
					{
						this.AbortCheckEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The ActiveCameraEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.ActiveCameraEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000081 RID: 129 RVA: 0x00002B40 File Offset: 0x00000D40
		// (remove) Token: 0x06000082 RID: 130 RVA: 0x00002B8C File Offset: 0x00000D8C
		public event vtkObject.vtkObjectEventHandler ActiveCameraEvt
		{
			add
			{
				if (null == this.ActiveCameraEvtRelay)
				{
					this.ActiveCameraEvtRelay = new vtkObjectEventRelay(this, 29U);
				}
				if (null != this.ActiveCameraEvtRelay)
				{
					this.ActiveCameraEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.ActiveCameraEvtRelay)
				{
					this.ActiveCameraEvtRelay.RemoveHandler(value);
					if (!this.ActiveCameraEvtRelay.HasHandlers())
					{
						this.ActiveCameraEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The AnimationCueTickEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.AnimationCueTickEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000083 RID: 131 RVA: 0x00002BD0 File Offset: 0x00000DD0
		// (remove) Token: 0x06000084 RID: 132 RVA: 0x00002C1C File Offset: 0x00000E1C
		public event vtkObject.vtkObjectEventHandler AnimationCueTickEvt
		{
			add
			{
				if (null == this.AnimationCueTickEvtRelay)
				{
					this.AnimationCueTickEvtRelay = new vtkObjectEventRelay(this, 59U);
				}
				if (null != this.AnimationCueTickEvtRelay)
				{
					this.AnimationCueTickEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.AnimationCueTickEvtRelay)
				{
					this.AnimationCueTickEvtRelay.RemoveHandler(value);
					if (!this.AnimationCueTickEvtRelay.HasHandlers())
					{
						this.AnimationCueTickEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The AnnotationChangedEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.AnnotationChangedEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000085 RID: 133 RVA: 0x00002C60 File Offset: 0x00000E60
		// (remove) Token: 0x06000086 RID: 134 RVA: 0x00002CAC File Offset: 0x00000EAC
		public event vtkObject.vtkObjectEventHandler AnnotationChangedEvt
		{
			add
			{
				if (null == this.AnnotationChangedEvtRelay)
				{
					this.AnnotationChangedEvtRelay = new vtkObjectEventRelay(this, 78U);
				}
				if (null != this.AnnotationChangedEvtRelay)
				{
					this.AnnotationChangedEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.AnnotationChangedEvtRelay)
				{
					this.AnnotationChangedEvtRelay.RemoveHandler(value);
					if (!this.AnnotationChangedEvtRelay.HasHandlers())
					{
						this.AnnotationChangedEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The AnyEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.AnyEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000087 RID: 135 RVA: 0x00002CF0 File Offset: 0x00000EF0
		// (remove) Token: 0x06000088 RID: 136 RVA: 0x00002D3C File Offset: 0x00000F3C
		public event vtkObject.vtkObjectEventHandler AnyEvt
		{
			add
			{
				if (null == this.AnyEvtRelay)
				{
					this.AnyEvtRelay = new vtkObjectEventRelay(this, 1U);
				}
				if (null != this.AnyEvtRelay)
				{
					this.AnyEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.AnyEvtRelay)
				{
					this.AnyEvtRelay.RemoveHandler(value);
					if (!this.AnyEvtRelay.HasHandlers())
					{
						this.AnyEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The Button3DEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.Button3DEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000089 RID: 137 RVA: 0x00002D80 File Offset: 0x00000F80
		// (remove) Token: 0x0600008A RID: 138 RVA: 0x00002DCC File Offset: 0x00000FCC
		public event vtkObject.vtkObjectEventHandler Button3DEvt
		{
			add
			{
				if (null == this.Button3DEvtRelay)
				{
					this.Button3DEvtRelay = new vtkObjectEventRelay(this, 122U);
				}
				if (null != this.Button3DEvtRelay)
				{
					this.Button3DEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.Button3DEvtRelay)
				{
					this.Button3DEvtRelay.RemoveHandler(value);
					if (!this.Button3DEvtRelay.HasHandlers())
					{
						this.Button3DEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The CharEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.CharEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600008B RID: 139 RVA: 0x00002E10 File Offset: 0x00001010
		// (remove) Token: 0x0600008C RID: 140 RVA: 0x00002E5C File Offset: 0x0000105C
		public event vtkObject.vtkObjectEventHandler CharEvt
		{
			add
			{
				if (null == this.CharEvtRelay)
				{
					this.CharEvtRelay = new vtkObjectEventRelay(this, 22U);
				}
				if (null != this.CharEvtRelay)
				{
					this.CharEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.CharEvtRelay)
				{
					this.CharEvtRelay.RemoveHandler(value);
					if (!this.CharEvtRelay.HasHandlers())
					{
						this.CharEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The Clip3DEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.Clip3DEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600008D RID: 141 RVA: 0x00002EA0 File Offset: 0x000010A0
		// (remove) Token: 0x0600008E RID: 142 RVA: 0x00002EF0 File Offset: 0x000010F0
		public event vtkObject.vtkObjectEventHandler Clip3DEvt
		{
			add
			{
				if (null == this.Clip3DEvtRelay)
				{
					this.Clip3DEvtRelay = new vtkObjectEventRelay(this, 132U);
				}
				if (null != this.Clip3DEvtRelay)
				{
					this.Clip3DEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.Clip3DEvtRelay)
				{
					this.Clip3DEvtRelay.RemoveHandler(value);
					if (!this.Clip3DEvtRelay.HasHandlers())
					{
						this.Clip3DEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The ComputeVisiblePropBoundsEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.ComputeVisiblePropBoundsEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600008F RID: 143 RVA: 0x00002F34 File Offset: 0x00001134
		// (remove) Token: 0x06000090 RID: 144 RVA: 0x00002F80 File Offset: 0x00001180
		public event vtkObject.vtkObjectEventHandler ComputeVisiblePropBoundsEvt
		{
			add
			{
				if (null == this.ComputeVisiblePropBoundsEvtRelay)
				{
					this.ComputeVisiblePropBoundsEvtRelay = new vtkObjectEventRelay(this, 84U);
				}
				if (null != this.ComputeVisiblePropBoundsEvtRelay)
				{
					this.ComputeVisiblePropBoundsEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.ComputeVisiblePropBoundsEvtRelay)
				{
					this.ComputeVisiblePropBoundsEvtRelay.RemoveHandler(value);
					if (!this.ComputeVisiblePropBoundsEvtRelay.HasHandlers())
					{
						this.ComputeVisiblePropBoundsEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The ConfigureEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.ConfigureEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000091 RID: 145 RVA: 0x00002FC4 File Offset: 0x000011C4
		// (remove) Token: 0x06000092 RID: 146 RVA: 0x00003010 File Offset: 0x00001210
		public event vtkObject.vtkObjectEventHandler ConfigureEvt
		{
			add
			{
				if (null == this.ConfigureEvtRelay)
				{
					this.ConfigureEvtRelay = new vtkObjectEventRelay(this, 24U);
				}
				if (null != this.ConfigureEvtRelay)
				{
					this.ConfigureEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.ConfigureEvtRelay)
				{
					this.ConfigureEvtRelay.RemoveHandler(value);
					if (!this.ConfigureEvtRelay.HasHandlers())
					{
						this.ConfigureEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The ConnectionClosedEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.ConnectionClosedEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000093 RID: 147 RVA: 0x00003054 File Offset: 0x00001254
		// (remove) Token: 0x06000094 RID: 148 RVA: 0x000030A0 File Offset: 0x000012A0
		public event vtkObject.vtkObjectEventHandler ConnectionClosedEvt
		{
			add
			{
				if (null == this.ConnectionClosedEvtRelay)
				{
					this.ConnectionClosedEvtRelay = new vtkObjectEventRelay(this, 71U);
				}
				if (null != this.ConnectionClosedEvtRelay)
				{
					this.ConnectionClosedEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.ConnectionClosedEvtRelay)
				{
					this.ConnectionClosedEvtRelay.RemoveHandler(value);
					if (!this.ConnectionClosedEvtRelay.HasHandlers())
					{
						this.ConnectionClosedEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The ConnectionCreatedEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.ConnectionCreatedEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000095 RID: 149 RVA: 0x000030E4 File Offset: 0x000012E4
		// (remove) Token: 0x06000096 RID: 150 RVA: 0x00003130 File Offset: 0x00001330
		public event vtkObject.vtkObjectEventHandler ConnectionCreatedEvt
		{
			add
			{
				if (null == this.ConnectionCreatedEvtRelay)
				{
					this.ConnectionCreatedEvtRelay = new vtkObjectEventRelay(this, 70U);
				}
				if (null != this.ConnectionCreatedEvtRelay)
				{
					this.ConnectionCreatedEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.ConnectionCreatedEvtRelay)
				{
					this.ConnectionCreatedEvtRelay.RemoveHandler(value);
					if (!this.ConnectionCreatedEvtRelay.HasHandlers())
					{
						this.ConnectionCreatedEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The CreateCameraEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.CreateCameraEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000097 RID: 151 RVA: 0x00003174 File Offset: 0x00001374
		// (remove) Token: 0x06000098 RID: 152 RVA: 0x000031C0 File Offset: 0x000013C0
		public event vtkObject.vtkObjectEventHandler CreateCameraEvt
		{
			add
			{
				if (null == this.CreateCameraEvtRelay)
				{
					this.CreateCameraEvtRelay = new vtkObjectEventRelay(this, 30U);
				}
				if (null != this.CreateCameraEvtRelay)
				{
					this.CreateCameraEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.CreateCameraEvtRelay)
				{
					this.CreateCameraEvtRelay.RemoveHandler(value);
					if (!this.CreateCameraEvtRelay.HasHandlers())
					{
						this.CreateCameraEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The CreateTimerEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.CreateTimerEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000099 RID: 153 RVA: 0x00003204 File Offset: 0x00001404
		// (remove) Token: 0x0600009A RID: 154 RVA: 0x00003250 File Offset: 0x00001450
		public event vtkObject.vtkObjectEventHandler CreateTimerEvt
		{
			add
			{
				if (null == this.CreateTimerEvtRelay)
				{
					this.CreateTimerEvtRelay = new vtkObjectEventRelay(this, 48U);
				}
				if (null != this.CreateTimerEvtRelay)
				{
					this.CreateTimerEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.CreateTimerEvtRelay)
				{
					this.CreateTimerEvtRelay.RemoveHandler(value);
					if (!this.CreateTimerEvtRelay.HasHandlers())
					{
						this.CreateTimerEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The CurrentChangedEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.CurrentChangedEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400000F RID: 15
		// (add) Token: 0x0600009B RID: 155 RVA: 0x00003294 File Offset: 0x00001494
		// (remove) Token: 0x0600009C RID: 156 RVA: 0x000032E0 File Offset: 0x000014E0
		public event vtkObject.vtkObjectEventHandler CurrentChangedEvt
		{
			add
			{
				if (null == this.CurrentChangedEvtRelay)
				{
					this.CurrentChangedEvtRelay = new vtkObjectEventRelay(this, 83U);
				}
				if (null != this.CurrentChangedEvtRelay)
				{
					this.CurrentChangedEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.CurrentChangedEvtRelay)
				{
					this.CurrentChangedEvtRelay.RemoveHandler(value);
					if (!this.CurrentChangedEvtRelay.HasHandlers())
					{
						this.CurrentChangedEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The CursorChangedEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.CursorChangedEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000010 RID: 16
		// (add) Token: 0x0600009D RID: 157 RVA: 0x00003324 File Offset: 0x00001524
		// (remove) Token: 0x0600009E RID: 158 RVA: 0x00003370 File Offset: 0x00001570
		public event vtkObject.vtkObjectEventHandler CursorChangedEvt
		{
			add
			{
				if (null == this.CursorChangedEvtRelay)
				{
					this.CursorChangedEvtRelay = new vtkObjectEventRelay(this, 53U);
				}
				if (null != this.CursorChangedEvtRelay)
				{
					this.CursorChangedEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.CursorChangedEvtRelay)
				{
					this.CursorChangedEvtRelay.RemoveHandler(value);
					if (!this.CursorChangedEvtRelay.HasHandlers())
					{
						this.CursorChangedEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The DeleteEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.DeleteEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000011 RID: 17
		// (add) Token: 0x0600009F RID: 159 RVA: 0x000033B4 File Offset: 0x000015B4
		// (remove) Token: 0x060000A0 RID: 160 RVA: 0x00003400 File Offset: 0x00001600
		public event vtkObject.vtkObjectEventHandler DeleteEvt
		{
			add
			{
				if (null == this.DeleteEvtRelay)
				{
					this.DeleteEvtRelay = new vtkObjectEventRelay(this, 2U);
				}
				if (null != this.DeleteEvtRelay)
				{
					this.DeleteEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.DeleteEvtRelay)
				{
					this.DeleteEvtRelay.RemoveHandler(value);
					if (!this.DeleteEvtRelay.HasHandlers())
					{
						this.DeleteEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The DeletePointEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.DeletePointEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060000A1 RID: 161 RVA: 0x00003444 File Offset: 0x00001644
		// (remove) Token: 0x060000A2 RID: 162 RVA: 0x00003490 File Offset: 0x00001690
		public event vtkObject.vtkObjectEventHandler DeletePointEvt
		{
			add
			{
				if (null == this.DeletePointEvtRelay)
				{
					this.DeletePointEvtRelay = new vtkObjectEventRelay(this, 51U);
				}
				if (null != this.DeletePointEvtRelay)
				{
					this.DeletePointEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.DeletePointEvtRelay)
				{
					this.DeletePointEvtRelay.RemoveHandler(value);
					if (!this.DeletePointEvtRelay.HasHandlers())
					{
						this.DeletePointEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The DestroyTimerEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.DestroyTimerEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060000A3 RID: 163 RVA: 0x000034D4 File Offset: 0x000016D4
		// (remove) Token: 0x060000A4 RID: 164 RVA: 0x00003520 File Offset: 0x00001720
		public event vtkObject.vtkObjectEventHandler DestroyTimerEvt
		{
			add
			{
				if (null == this.DestroyTimerEvtRelay)
				{
					this.DestroyTimerEvtRelay = new vtkObjectEventRelay(this, 49U);
				}
				if (null != this.DestroyTimerEvtRelay)
				{
					this.DestroyTimerEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.DestroyTimerEvtRelay)
				{
					this.DestroyTimerEvtRelay.RemoveHandler(value);
					if (!this.DestroyTimerEvtRelay.HasHandlers())
					{
						this.DestroyTimerEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The DisableEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.DisableEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000014 RID: 20
		// (add) Token: 0x060000A5 RID: 165 RVA: 0x00003564 File Offset: 0x00001764
		// (remove) Token: 0x060000A6 RID: 166 RVA: 0x000035B0 File Offset: 0x000017B0
		public event vtkObject.vtkObjectEventHandler DisableEvt
		{
			add
			{
				if (null == this.DisableEvtRelay)
				{
					this.DisableEvtRelay = new vtkObjectEventRelay(this, 47U);
				}
				if (null != this.DisableEvtRelay)
				{
					this.DisableEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.DisableEvtRelay)
				{
					this.DisableEvtRelay.RemoveHandler(value);
					if (!this.DisableEvtRelay.HasHandlers())
					{
						this.DisableEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The DomainModifiedEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.DomainModifiedEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000015 RID: 21
		// (add) Token: 0x060000A7 RID: 167 RVA: 0x000035F4 File Offset: 0x000017F4
		// (remove) Token: 0x060000A8 RID: 168 RVA: 0x00003640 File Offset: 0x00001840
		public event vtkObject.vtkObjectEventHandler DomainModifiedEvt
		{
			add
			{
				if (null == this.DomainModifiedEvtRelay)
				{
					this.DomainModifiedEvtRelay = new vtkObjectEventRelay(this, 72U);
				}
				if (null != this.DomainModifiedEvtRelay)
				{
					this.DomainModifiedEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.DomainModifiedEvtRelay)
				{
					this.DomainModifiedEvtRelay.RemoveHandler(value);
					if (!this.DomainModifiedEvtRelay.HasHandlers())
					{
						this.DomainModifiedEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The DropFilesEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.DropFilesEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000016 RID: 22
		// (add) Token: 0x060000A9 RID: 169 RVA: 0x00003684 File Offset: 0x00001884
		// (remove) Token: 0x060000AA RID: 170 RVA: 0x000036D0 File Offset: 0x000018D0
		public event vtkObject.vtkObjectEventHandler DropFilesEvt
		{
			add
			{
				if (null == this.DropFilesEvtRelay)
				{
					this.DropFilesEvtRelay = new vtkObjectEventRelay(this, 42U);
				}
				if (null != this.DropFilesEvtRelay)
				{
					this.DropFilesEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.DropFilesEvtRelay)
				{
					this.DropFilesEvtRelay.RemoveHandler(value);
					if (!this.DropFilesEvtRelay.HasHandlers())
					{
						this.DropFilesEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The EnableEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.EnableEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000017 RID: 23
		// (add) Token: 0x060000AB RID: 171 RVA: 0x00003714 File Offset: 0x00001914
		// (remove) Token: 0x060000AC RID: 172 RVA: 0x00003760 File Offset: 0x00001960
		public event vtkObject.vtkObjectEventHandler EnableEvt
		{
			add
			{
				if (null == this.EnableEvtRelay)
				{
					this.EnableEvtRelay = new vtkObjectEventRelay(this, 46U);
				}
				if (null != this.EnableEvtRelay)
				{
					this.EnableEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.EnableEvtRelay)
				{
					this.EnableEvtRelay.RemoveHandler(value);
					if (!this.EnableEvtRelay.HasHandlers())
					{
						this.EnableEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The EndEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.EndEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000018 RID: 24
		// (add) Token: 0x060000AD RID: 173 RVA: 0x000037A4 File Offset: 0x000019A4
		// (remove) Token: 0x060000AE RID: 174 RVA: 0x000037F0 File Offset: 0x000019F0
		public event vtkObject.vtkObjectEventHandler EndEvt
		{
			add
			{
				if (null == this.EndEvtRelay)
				{
					this.EndEvtRelay = new vtkObjectEventRelay(this, 4U);
				}
				if (null != this.EndEvtRelay)
				{
					this.EndEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.EndEvtRelay)
				{
					this.EndEvtRelay.RemoveHandler(value);
					if (!this.EndEvtRelay.HasHandlers())
					{
						this.EndEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The EndAnimationCueEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.EndAnimationCueEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000019 RID: 25
		// (add) Token: 0x060000AF RID: 175 RVA: 0x00003834 File Offset: 0x00001A34
		// (remove) Token: 0x060000B0 RID: 176 RVA: 0x00003880 File Offset: 0x00001A80
		public event vtkObject.vtkObjectEventHandler EndAnimationCueEvt
		{
			add
			{
				if (null == this.EndAnimationCueEvtRelay)
				{
					this.EndAnimationCueEvtRelay = new vtkObjectEventRelay(this, 60U);
				}
				if (null != this.EndAnimationCueEvtRelay)
				{
					this.EndAnimationCueEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.EndAnimationCueEvtRelay)
				{
					this.EndAnimationCueEvtRelay.RemoveHandler(value);
					if (!this.EndAnimationCueEvtRelay.HasHandlers())
					{
						this.EndAnimationCueEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The EndInteractionEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.EndInteractionEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400001A RID: 26
		// (add) Token: 0x060000B1 RID: 177 RVA: 0x000038C4 File Offset: 0x00001AC4
		// (remove) Token: 0x060000B2 RID: 178 RVA: 0x00003910 File Offset: 0x00001B10
		public event vtkObject.vtkObjectEventHandler EndInteractionEvt
		{
			add
			{
				if (null == this.EndInteractionEvtRelay)
				{
					this.EndInteractionEvtRelay = new vtkObjectEventRelay(this, 45U);
				}
				if (null != this.EndInteractionEvtRelay)
				{
					this.EndInteractionEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.EndInteractionEvtRelay)
				{
					this.EndInteractionEvtRelay.RemoveHandler(value);
					if (!this.EndInteractionEvtRelay.HasHandlers())
					{
						this.EndInteractionEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The EndPanEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.EndPanEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400001B RID: 27
		// (add) Token: 0x060000B3 RID: 179 RVA: 0x00003954 File Offset: 0x00001B54
		// (remove) Token: 0x060000B4 RID: 180 RVA: 0x000039A0 File Offset: 0x00001BA0
		public event vtkObject.vtkObjectEventHandler EndPanEvt
		{
			add
			{
				if (null == this.EndPanEvtRelay)
				{
					this.EndPanEvtRelay = new vtkObjectEventRelay(this, 114U);
				}
				if (null != this.EndPanEvtRelay)
				{
					this.EndPanEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.EndPanEvtRelay)
				{
					this.EndPanEvtRelay.RemoveHandler(value);
					if (!this.EndPanEvtRelay.HasHandlers())
					{
						this.EndPanEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The EndPickEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.EndPickEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400001C RID: 28
		// (add) Token: 0x060000B5 RID: 181 RVA: 0x000039E4 File Offset: 0x00001BE4
		// (remove) Token: 0x060000B6 RID: 182 RVA: 0x00003A30 File Offset: 0x00001C30
		public event vtkObject.vtkObjectEventHandler EndPickEvt
		{
			add
			{
				if (null == this.EndPickEvtRelay)
				{
					this.EndPickEvtRelay = new vtkObjectEventRelay(this, 9U);
				}
				if (null != this.EndPickEvtRelay)
				{
					this.EndPickEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.EndPickEvtRelay)
				{
					this.EndPickEvtRelay.RemoveHandler(value);
					if (!this.EndPickEvtRelay.HasHandlers())
					{
						this.EndPickEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The EndPinchEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.EndPinchEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400001D RID: 29
		// (add) Token: 0x060000B7 RID: 183 RVA: 0x00003A74 File Offset: 0x00001C74
		// (remove) Token: 0x060000B8 RID: 184 RVA: 0x00003AC0 File Offset: 0x00001CC0
		public event vtkObject.vtkObjectEventHandler EndPinchEvt
		{
			add
			{
				if (null == this.EndPinchEvtRelay)
				{
					this.EndPinchEvtRelay = new vtkObjectEventRelay(this, 108U);
				}
				if (null != this.EndPinchEvtRelay)
				{
					this.EndPinchEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.EndPinchEvtRelay)
				{
					this.EndPinchEvtRelay.RemoveHandler(value);
					if (!this.EndPinchEvtRelay.HasHandlers())
					{
						this.EndPinchEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The EndRotateEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.EndRotateEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400001E RID: 30
		// (add) Token: 0x060000B9 RID: 185 RVA: 0x00003B04 File Offset: 0x00001D04
		// (remove) Token: 0x060000BA RID: 186 RVA: 0x00003B50 File Offset: 0x00001D50
		public event vtkObject.vtkObjectEventHandler EndRotateEvt
		{
			add
			{
				if (null == this.EndRotateEvtRelay)
				{
					this.EndRotateEvtRelay = new vtkObjectEventRelay(this, 111U);
				}
				if (null != this.EndRotateEvtRelay)
				{
					this.EndRotateEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.EndRotateEvtRelay)
				{
					this.EndRotateEvtRelay.RemoveHandler(value);
					if (!this.EndRotateEvtRelay.HasHandlers())
					{
						this.EndRotateEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The EndSwipeEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.EndSwipeEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400001F RID: 31
		// (add) Token: 0x060000BB RID: 187 RVA: 0x00003B94 File Offset: 0x00001D94
		// (remove) Token: 0x060000BC RID: 188 RVA: 0x00003BE0 File Offset: 0x00001DE0
		public event vtkObject.vtkObjectEventHandler EndSwipeEvt
		{
			add
			{
				if (null == this.EndSwipeEvtRelay)
				{
					this.EndSwipeEvtRelay = new vtkObjectEventRelay(this, 105U);
				}
				if (null != this.EndSwipeEvtRelay)
				{
					this.EndSwipeEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.EndSwipeEvtRelay)
				{
					this.EndSwipeEvtRelay.RemoveHandler(value);
					if (!this.EndSwipeEvtRelay.HasHandlers())
					{
						this.EndSwipeEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The EndWindowLevelEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.EndWindowLevelEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000020 RID: 32
		// (add) Token: 0x060000BD RID: 189 RVA: 0x00003C24 File Offset: 0x00001E24
		// (remove) Token: 0x060000BE RID: 190 RVA: 0x00003C70 File Offset: 0x00001E70
		public event vtkObject.vtkObjectEventHandler EndWindowLevelEvt
		{
			add
			{
				if (null == this.EndWindowLevelEvtRelay)
				{
					this.EndWindowLevelEvtRelay = new vtkObjectEventRelay(this, 36U);
				}
				if (null != this.EndWindowLevelEvtRelay)
				{
					this.EndWindowLevelEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.EndWindowLevelEvtRelay)
				{
					this.EndWindowLevelEvtRelay.RemoveHandler(value);
					if (!this.EndWindowLevelEvtRelay.HasHandlers())
					{
						this.EndWindowLevelEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The EnterEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.EnterEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000021 RID: 33
		// (add) Token: 0x060000BF RID: 191 RVA: 0x00003CB4 File Offset: 0x00001EB4
		// (remove) Token: 0x060000C0 RID: 192 RVA: 0x00003D00 File Offset: 0x00001F00
		public event vtkObject.vtkObjectEventHandler EnterEvt
		{
			add
			{
				if (null == this.EnterEvtRelay)
				{
					this.EnterEvtRelay = new vtkObjectEventRelay(this, 18U);
				}
				if (null != this.EnterEvtRelay)
				{
					this.EnterEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.EnterEvtRelay)
				{
					this.EnterEvtRelay.RemoveHandler(value);
					if (!this.EnterEvtRelay.HasHandlers())
					{
						this.EnterEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The ErrorEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.ErrorEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000022 RID: 34
		// (add) Token: 0x060000C1 RID: 193 RVA: 0x00003D44 File Offset: 0x00001F44
		// (remove) Token: 0x060000C2 RID: 194 RVA: 0x00003D90 File Offset: 0x00001F90
		public event vtkObject.vtkObjectEventHandler ErrorEvt
		{
			add
			{
				if (null == this.ErrorEvtRelay)
				{
					this.ErrorEvtRelay = new vtkObjectEventRelay(this, 39U);
				}
				if (null != this.ErrorEvtRelay)
				{
					this.ErrorEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.ErrorEvtRelay)
				{
					this.ErrorEvtRelay.RemoveHandler(value);
					if (!this.ErrorEvtRelay.HasHandlers())
					{
						this.ErrorEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The ExecuteInformationEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.ExecuteInformationEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000023 RID: 35
		// (add) Token: 0x060000C3 RID: 195 RVA: 0x00003DD4 File Offset: 0x00001FD4
		// (remove) Token: 0x060000C4 RID: 196 RVA: 0x00003E20 File Offset: 0x00002020
		public event vtkObject.vtkObjectEventHandler ExecuteInformationEvt
		{
			add
			{
				if (null == this.ExecuteInformationEvtRelay)
				{
					this.ExecuteInformationEvtRelay = new vtkObjectEventRelay(this, 54U);
				}
				if (null != this.ExecuteInformationEvtRelay)
				{
					this.ExecuteInformationEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.ExecuteInformationEvtRelay)
				{
					this.ExecuteInformationEvtRelay.RemoveHandler(value);
					if (!this.ExecuteInformationEvtRelay.HasHandlers())
					{
						this.ExecuteInformationEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The ExitEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.ExitEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000024 RID: 36
		// (add) Token: 0x060000C5 RID: 197 RVA: 0x00003E64 File Offset: 0x00002064
		// (remove) Token: 0x060000C6 RID: 198 RVA: 0x00003EB0 File Offset: 0x000020B0
		public event vtkObject.vtkObjectEventHandler ExitEvt
		{
			add
			{
				if (null == this.ExitEvtRelay)
				{
					this.ExitEvtRelay = new vtkObjectEventRelay(this, 11U);
				}
				if (null != this.ExitEvtRelay)
				{
					this.ExitEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.ExitEvtRelay)
				{
					this.ExitEvtRelay.RemoveHandler(value);
					if (!this.ExitEvtRelay.HasHandlers())
					{
						this.ExitEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The ExposeEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.ExposeEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000025 RID: 37
		// (add) Token: 0x060000C7 RID: 199 RVA: 0x00003EF4 File Offset: 0x000020F4
		// (remove) Token: 0x060000C8 RID: 200 RVA: 0x00003F40 File Offset: 0x00002140
		public event vtkObject.vtkObjectEventHandler ExposeEvt
		{
			add
			{
				if (null == this.ExposeEvtRelay)
				{
					this.ExposeEvtRelay = new vtkObjectEventRelay(this, 23U);
				}
				if (null != this.ExposeEvtRelay)
				{
					this.ExposeEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.ExposeEvtRelay)
				{
					this.ExposeEvtRelay.RemoveHandler(value);
					if (!this.ExposeEvtRelay.HasHandlers())
					{
						this.ExposeEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The FifthButtonPressEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.FifthButtonPressEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000026 RID: 38
		// (add) Token: 0x060000C9 RID: 201 RVA: 0x00003F84 File Offset: 0x00002184
		// (remove) Token: 0x060000CA RID: 202 RVA: 0x00003FD0 File Offset: 0x000021D0
		public event vtkObject.vtkObjectEventHandler FifthButtonPressEvt
		{
			add
			{
				if (null == this.FifthButtonPressEvtRelay)
				{
					this.FifthButtonPressEvtRelay = new vtkObjectEventRelay(this, 119U);
				}
				if (null != this.FifthButtonPressEvtRelay)
				{
					this.FifthButtonPressEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.FifthButtonPressEvtRelay)
				{
					this.FifthButtonPressEvtRelay.RemoveHandler(value);
					if (!this.FifthButtonPressEvtRelay.HasHandlers())
					{
						this.FifthButtonPressEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The FifthButtonReleaseEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.FifthButtonReleaseEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000027 RID: 39
		// (add) Token: 0x060000CB RID: 203 RVA: 0x00004014 File Offset: 0x00002214
		// (remove) Token: 0x060000CC RID: 204 RVA: 0x00004060 File Offset: 0x00002260
		public event vtkObject.vtkObjectEventHandler FifthButtonReleaseEvt
		{
			add
			{
				if (null == this.FifthButtonReleaseEvtRelay)
				{
					this.FifthButtonReleaseEvtRelay = new vtkObjectEventRelay(this, 120U);
				}
				if (null != this.FifthButtonReleaseEvtRelay)
				{
					this.FifthButtonReleaseEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.FifthButtonReleaseEvtRelay)
				{
					this.FifthButtonReleaseEvtRelay.RemoveHandler(value);
					if (!this.FifthButtonReleaseEvtRelay.HasHandlers())
					{
						this.FifthButtonReleaseEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The FourthButtonPressEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.FourthButtonPressEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000028 RID: 40
		// (add) Token: 0x060000CD RID: 205 RVA: 0x000040A4 File Offset: 0x000022A4
		// (remove) Token: 0x060000CE RID: 206 RVA: 0x000040F0 File Offset: 0x000022F0
		public event vtkObject.vtkObjectEventHandler FourthButtonPressEvt
		{
			add
			{
				if (null == this.FourthButtonPressEvtRelay)
				{
					this.FourthButtonPressEvtRelay = new vtkObjectEventRelay(this, 117U);
				}
				if (null != this.FourthButtonPressEvtRelay)
				{
					this.FourthButtonPressEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.FourthButtonPressEvtRelay)
				{
					this.FourthButtonPressEvtRelay.RemoveHandler(value);
					if (!this.FourthButtonPressEvtRelay.HasHandlers())
					{
						this.FourthButtonPressEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The FourthButtonReleaseEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.FourthButtonReleaseEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000029 RID: 41
		// (add) Token: 0x060000CF RID: 207 RVA: 0x00004134 File Offset: 0x00002334
		// (remove) Token: 0x060000D0 RID: 208 RVA: 0x00004180 File Offset: 0x00002380
		public event vtkObject.vtkObjectEventHandler FourthButtonReleaseEvt
		{
			add
			{
				if (null == this.FourthButtonReleaseEvtRelay)
				{
					this.FourthButtonReleaseEvtRelay = new vtkObjectEventRelay(this, 118U);
				}
				if (null != this.FourthButtonReleaseEvtRelay)
				{
					this.FourthButtonReleaseEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.FourthButtonReleaseEvtRelay)
				{
					this.FourthButtonReleaseEvtRelay.RemoveHandler(value);
					if (!this.FourthButtonReleaseEvtRelay.HasHandlers())
					{
						this.FourthButtonReleaseEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The HighlightEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.HighlightEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400002A RID: 42
		// (add) Token: 0x060000D1 RID: 209 RVA: 0x000041C4 File Offset: 0x000023C4
		// (remove) Token: 0x060000D2 RID: 210 RVA: 0x00004210 File Offset: 0x00002410
		public event vtkObject.vtkObjectEventHandler HighlightEvt
		{
			add
			{
				if (null == this.HighlightEvtRelay)
				{
					this.HighlightEvtRelay = new vtkObjectEventRelay(this, 95U);
				}
				if (null != this.HighlightEvtRelay)
				{
					this.HighlightEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.HighlightEvtRelay)
				{
					this.HighlightEvtRelay.RemoveHandler(value);
					if (!this.HighlightEvtRelay.HasHandlers())
					{
						this.HighlightEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The HoverEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.HoverEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400002B RID: 43
		// (add) Token: 0x060000D3 RID: 211 RVA: 0x00004254 File Offset: 0x00002454
		// (remove) Token: 0x060000D4 RID: 212 RVA: 0x000042A0 File Offset: 0x000024A0
		public event vtkObject.vtkObjectEventHandler HoverEvt
		{
			add
			{
				if (null == this.HoverEvtRelay)
				{
					this.HoverEvtRelay = new vtkObjectEventRelay(this, 88U);
				}
				if (null != this.HoverEvtRelay)
				{
					this.HoverEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.HoverEvtRelay)
				{
					this.HoverEvtRelay.RemoveHandler(value);
					if (!this.HoverEvtRelay.HasHandlers())
					{
						this.HoverEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The InteractionEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.InteractionEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400002C RID: 44
		// (add) Token: 0x060000D5 RID: 213 RVA: 0x000042E4 File Offset: 0x000024E4
		// (remove) Token: 0x060000D6 RID: 214 RVA: 0x00004330 File Offset: 0x00002530
		public event vtkObject.vtkObjectEventHandler InteractionEvt
		{
			add
			{
				if (null == this.InteractionEvtRelay)
				{
					this.InteractionEvtRelay = new vtkObjectEventRelay(this, 44U);
				}
				if (null != this.InteractionEvtRelay)
				{
					this.InteractionEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.InteractionEvtRelay)
				{
					this.InteractionEvtRelay.RemoveHandler(value);
					if (!this.InteractionEvtRelay.HasHandlers())
					{
						this.InteractionEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The KeyPressEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.KeyPressEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400002D RID: 45
		// (add) Token: 0x060000D7 RID: 215 RVA: 0x00004374 File Offset: 0x00002574
		// (remove) Token: 0x060000D8 RID: 216 RVA: 0x000043C0 File Offset: 0x000025C0
		public event vtkObject.vtkObjectEventHandler KeyPressEvt
		{
			add
			{
				if (null == this.KeyPressEvtRelay)
				{
					this.KeyPressEvtRelay = new vtkObjectEventRelay(this, 20U);
				}
				if (null != this.KeyPressEvtRelay)
				{
					this.KeyPressEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.KeyPressEvtRelay)
				{
					this.KeyPressEvtRelay.RemoveHandler(value);
					if (!this.KeyPressEvtRelay.HasHandlers())
					{
						this.KeyPressEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The KeyReleaseEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.KeyReleaseEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400002E RID: 46
		// (add) Token: 0x060000D9 RID: 217 RVA: 0x00004404 File Offset: 0x00002604
		// (remove) Token: 0x060000DA RID: 218 RVA: 0x00004450 File Offset: 0x00002650
		public event vtkObject.vtkObjectEventHandler KeyReleaseEvt
		{
			add
			{
				if (null == this.KeyReleaseEvtRelay)
				{
					this.KeyReleaseEvtRelay = new vtkObjectEventRelay(this, 21U);
				}
				if (null != this.KeyReleaseEvtRelay)
				{
					this.KeyReleaseEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.KeyReleaseEvtRelay)
				{
					this.KeyReleaseEvtRelay.RemoveHandler(value);
					if (!this.KeyReleaseEvtRelay.HasHandlers())
					{
						this.KeyReleaseEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The LeaveEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.LeaveEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400002F RID: 47
		// (add) Token: 0x060000DB RID: 219 RVA: 0x00004494 File Offset: 0x00002694
		// (remove) Token: 0x060000DC RID: 220 RVA: 0x000044E0 File Offset: 0x000026E0
		public event vtkObject.vtkObjectEventHandler LeaveEvt
		{
			add
			{
				if (null == this.LeaveEvtRelay)
				{
					this.LeaveEvtRelay = new vtkObjectEventRelay(this, 19U);
				}
				if (null != this.LeaveEvtRelay)
				{
					this.LeaveEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.LeaveEvtRelay)
				{
					this.LeaveEvtRelay.RemoveHandler(value);
					if (!this.LeaveEvtRelay.HasHandlers())
					{
						this.LeaveEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The LeftButtonDoubleClickEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.LeftButtonDoubleClickEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000030 RID: 48
		// (add) Token: 0x060000DD RID: 221 RVA: 0x00004524 File Offset: 0x00002724
		// (remove) Token: 0x060000DE RID: 222 RVA: 0x00004570 File Offset: 0x00002770
		public event vtkObject.vtkObjectEventHandler LeftButtonDoubleClickEvt
		{
			add
			{
				if (null == this.LeftButtonDoubleClickEvtRelay)
				{
					this.LeftButtonDoubleClickEvtRelay = new vtkObjectEventRelay(this, 124U);
				}
				if (null != this.LeftButtonDoubleClickEvtRelay)
				{
					this.LeftButtonDoubleClickEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.LeftButtonDoubleClickEvtRelay)
				{
					this.LeftButtonDoubleClickEvtRelay.RemoveHandler(value);
					if (!this.LeftButtonDoubleClickEvtRelay.HasHandlers())
					{
						this.LeftButtonDoubleClickEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The LeftButtonPressEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.LeftButtonPressEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000031 RID: 49
		// (add) Token: 0x060000DF RID: 223 RVA: 0x000045B4 File Offset: 0x000027B4
		// (remove) Token: 0x060000E0 RID: 224 RVA: 0x00004600 File Offset: 0x00002800
		public event vtkObject.vtkObjectEventHandler LeftButtonPressEvt
		{
			add
			{
				if (null == this.LeftButtonPressEvtRelay)
				{
					this.LeftButtonPressEvtRelay = new vtkObjectEventRelay(this, 12U);
				}
				if (null != this.LeftButtonPressEvtRelay)
				{
					this.LeftButtonPressEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.LeftButtonPressEvtRelay)
				{
					this.LeftButtonPressEvtRelay.RemoveHandler(value);
					if (!this.LeftButtonPressEvtRelay.HasHandlers())
					{
						this.LeftButtonPressEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The LeftButtonReleaseEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.LeftButtonReleaseEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000032 RID: 50
		// (add) Token: 0x060000E1 RID: 225 RVA: 0x00004644 File Offset: 0x00002844
		// (remove) Token: 0x060000E2 RID: 226 RVA: 0x00004690 File Offset: 0x00002890
		public event vtkObject.vtkObjectEventHandler LeftButtonReleaseEvt
		{
			add
			{
				if (null == this.LeftButtonReleaseEvtRelay)
				{
					this.LeftButtonReleaseEvtRelay = new vtkObjectEventRelay(this, 13U);
				}
				if (null != this.LeftButtonReleaseEvtRelay)
				{
					this.LeftButtonReleaseEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.LeftButtonReleaseEvtRelay)
				{
					this.LeftButtonReleaseEvtRelay.RemoveHandler(value);
					if (!this.LeftButtonReleaseEvtRelay.HasHandlers())
					{
						this.LeftButtonReleaseEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The LoadStateEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.LoadStateEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000033 RID: 51
		// (add) Token: 0x060000E3 RID: 227 RVA: 0x000046D4 File Offset: 0x000028D4
		// (remove) Token: 0x060000E4 RID: 228 RVA: 0x00004720 File Offset: 0x00002920
		public event vtkObject.vtkObjectEventHandler LoadStateEvt
		{
			add
			{
				if (null == this.LoadStateEvtRelay)
				{
					this.LoadStateEvtRelay = new vtkObjectEventRelay(this, 89U);
				}
				if (null != this.LoadStateEvtRelay)
				{
					this.LoadStateEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.LoadStateEvtRelay)
				{
					this.LoadStateEvtRelay.RemoveHandler(value);
					if (!this.LoadStateEvtRelay.HasHandlers())
					{
						this.LoadStateEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The LongTapEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.LongTapEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000034 RID: 52
		// (add) Token: 0x060000E5 RID: 229 RVA: 0x00004764 File Offset: 0x00002964
		// (remove) Token: 0x060000E6 RID: 230 RVA: 0x000047B0 File Offset: 0x000029B0
		public event vtkObject.vtkObjectEventHandler LongTapEvt
		{
			add
			{
				if (null == this.LongTapEvtRelay)
				{
					this.LongTapEvtRelay = new vtkObjectEventRelay(this, 116U);
				}
				if (null != this.LongTapEvtRelay)
				{
					this.LongTapEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.LongTapEvtRelay)
				{
					this.LongTapEvtRelay.RemoveHandler(value);
					if (!this.LongTapEvtRelay.HasHandlers())
					{
						this.LongTapEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The Menu3DEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.Menu3DEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000035 RID: 53
		// (add) Token: 0x060000E7 RID: 231 RVA: 0x000047F4 File Offset: 0x000029F4
		// (remove) Token: 0x060000E8 RID: 232 RVA: 0x00004844 File Offset: 0x00002A44
		public event vtkObject.vtkObjectEventHandler Menu3DEvt
		{
			add
			{
				if (null == this.Menu3DEvtRelay)
				{
					this.Menu3DEvtRelay = new vtkObjectEventRelay(this, 130U);
				}
				if (null != this.Menu3DEvtRelay)
				{
					this.Menu3DEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.Menu3DEvtRelay)
				{
					this.Menu3DEvtRelay.RemoveHandler(value);
					if (!this.Menu3DEvtRelay.HasHandlers())
					{
						this.Menu3DEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The MessageEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.MessageEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000036 RID: 54
		// (add) Token: 0x060000E9 RID: 233 RVA: 0x00004888 File Offset: 0x00002A88
		// (remove) Token: 0x060000EA RID: 234 RVA: 0x000048D4 File Offset: 0x00002AD4
		public event vtkObject.vtkObjectEventHandler MessageEvt
		{
			add
			{
				if (null == this.MessageEvtRelay)
				{
					this.MessageEvtRelay = new vtkObjectEventRelay(this, 102U);
				}
				if (null != this.MessageEvtRelay)
				{
					this.MessageEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.MessageEvtRelay)
				{
					this.MessageEvtRelay.RemoveHandler(value);
					if (!this.MessageEvtRelay.HasHandlers())
					{
						this.MessageEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The MiddleButtonDoubleClickEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.MiddleButtonDoubleClickEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000037 RID: 55
		// (add) Token: 0x060000EB RID: 235 RVA: 0x00004918 File Offset: 0x00002B18
		// (remove) Token: 0x060000EC RID: 236 RVA: 0x00004964 File Offset: 0x00002B64
		public event vtkObject.vtkObjectEventHandler MiddleButtonDoubleClickEvt
		{
			add
			{
				if (null == this.MiddleButtonDoubleClickEvtRelay)
				{
					this.MiddleButtonDoubleClickEvtRelay = new vtkObjectEventRelay(this, 125U);
				}
				if (null != this.MiddleButtonDoubleClickEvtRelay)
				{
					this.MiddleButtonDoubleClickEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.MiddleButtonDoubleClickEvtRelay)
				{
					this.MiddleButtonDoubleClickEvtRelay.RemoveHandler(value);
					if (!this.MiddleButtonDoubleClickEvtRelay.HasHandlers())
					{
						this.MiddleButtonDoubleClickEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The MiddleButtonPressEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.MiddleButtonPressEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000038 RID: 56
		// (add) Token: 0x060000ED RID: 237 RVA: 0x000049A8 File Offset: 0x00002BA8
		// (remove) Token: 0x060000EE RID: 238 RVA: 0x000049F4 File Offset: 0x00002BF4
		public event vtkObject.vtkObjectEventHandler MiddleButtonPressEvt
		{
			add
			{
				if (null == this.MiddleButtonPressEvtRelay)
				{
					this.MiddleButtonPressEvtRelay = new vtkObjectEventRelay(this, 14U);
				}
				if (null != this.MiddleButtonPressEvtRelay)
				{
					this.MiddleButtonPressEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.MiddleButtonPressEvtRelay)
				{
					this.MiddleButtonPressEvtRelay.RemoveHandler(value);
					if (!this.MiddleButtonPressEvtRelay.HasHandlers())
					{
						this.MiddleButtonPressEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The MiddleButtonReleaseEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.MiddleButtonReleaseEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000039 RID: 57
		// (add) Token: 0x060000EF RID: 239 RVA: 0x00004A38 File Offset: 0x00002C38
		// (remove) Token: 0x060000F0 RID: 240 RVA: 0x00004A84 File Offset: 0x00002C84
		public event vtkObject.vtkObjectEventHandler MiddleButtonReleaseEvt
		{
			add
			{
				if (null == this.MiddleButtonReleaseEvtRelay)
				{
					this.MiddleButtonReleaseEvtRelay = new vtkObjectEventRelay(this, 15U);
				}
				if (null != this.MiddleButtonReleaseEvtRelay)
				{
					this.MiddleButtonReleaseEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.MiddleButtonReleaseEvtRelay)
				{
					this.MiddleButtonReleaseEvtRelay.RemoveHandler(value);
					if (!this.MiddleButtonReleaseEvtRelay.HasHandlers())
					{
						this.MiddleButtonReleaseEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The ModifiedEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.ModifiedEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400003A RID: 58
		// (add) Token: 0x060000F1 RID: 241 RVA: 0x00004AC8 File Offset: 0x00002CC8
		// (remove) Token: 0x060000F2 RID: 242 RVA: 0x00004B14 File Offset: 0x00002D14
		public event vtkObject.vtkObjectEventHandler ModifiedEvt
		{
			add
			{
				if (null == this.ModifiedEvtRelay)
				{
					this.ModifiedEvtRelay = new vtkObjectEventRelay(this, 33U);
				}
				if (null != this.ModifiedEvtRelay)
				{
					this.ModifiedEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.ModifiedEvtRelay)
				{
					this.ModifiedEvtRelay.RemoveHandler(value);
					if (!this.ModifiedEvtRelay.HasHandlers())
					{
						this.ModifiedEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The MouseMoveEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.MouseMoveEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400003B RID: 59
		// (add) Token: 0x060000F3 RID: 243 RVA: 0x00004B58 File Offset: 0x00002D58
		// (remove) Token: 0x060000F4 RID: 244 RVA: 0x00004BA4 File Offset: 0x00002DA4
		public event vtkObject.vtkObjectEventHandler MouseMoveEvt
		{
			add
			{
				if (null == this.MouseMoveEvtRelay)
				{
					this.MouseMoveEvtRelay = new vtkObjectEventRelay(this, 26U);
				}
				if (null != this.MouseMoveEvtRelay)
				{
					this.MouseMoveEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.MouseMoveEvtRelay)
				{
					this.MouseMoveEvtRelay.RemoveHandler(value);
					if (!this.MouseMoveEvtRelay.HasHandlers())
					{
						this.MouseMoveEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The MouseWheelBackwardEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.MouseWheelBackwardEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400003C RID: 60
		// (add) Token: 0x060000F5 RID: 245 RVA: 0x00004BE8 File Offset: 0x00002DE8
		// (remove) Token: 0x060000F6 RID: 246 RVA: 0x00004C34 File Offset: 0x00002E34
		public event vtkObject.vtkObjectEventHandler MouseWheelBackwardEvt
		{
			add
			{
				if (null == this.MouseWheelBackwardEvtRelay)
				{
					this.MouseWheelBackwardEvtRelay = new vtkObjectEventRelay(this, 28U);
				}
				if (null != this.MouseWheelBackwardEvtRelay)
				{
					this.MouseWheelBackwardEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.MouseWheelBackwardEvtRelay)
				{
					this.MouseWheelBackwardEvtRelay.RemoveHandler(value);
					if (!this.MouseWheelBackwardEvtRelay.HasHandlers())
					{
						this.MouseWheelBackwardEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The MouseWheelForwardEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.MouseWheelForwardEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400003D RID: 61
		// (add) Token: 0x060000F7 RID: 247 RVA: 0x00004C78 File Offset: 0x00002E78
		// (remove) Token: 0x060000F8 RID: 248 RVA: 0x00004CC4 File Offset: 0x00002EC4
		public event vtkObject.vtkObjectEventHandler MouseWheelForwardEvt
		{
			add
			{
				if (null == this.MouseWheelForwardEvtRelay)
				{
					this.MouseWheelForwardEvtRelay = new vtkObjectEventRelay(this, 27U);
				}
				if (null != this.MouseWheelForwardEvtRelay)
				{
					this.MouseWheelForwardEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.MouseWheelForwardEvtRelay)
				{
					this.MouseWheelForwardEvtRelay.RemoveHandler(value);
					if (!this.MouseWheelForwardEvtRelay.HasHandlers())
					{
						this.MouseWheelForwardEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The MouseWheelLeftEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.MouseWheelLeftEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400003E RID: 62
		// (add) Token: 0x060000F9 RID: 249 RVA: 0x00004D08 File Offset: 0x00002F08
		// (remove) Token: 0x060000FA RID: 250 RVA: 0x00004D54 File Offset: 0x00002F54
		public event vtkObject.vtkObjectEventHandler MouseWheelLeftEvt
		{
			add
			{
				if (null == this.MouseWheelLeftEvtRelay)
				{
					this.MouseWheelLeftEvtRelay = new vtkObjectEventRelay(this, 127U);
				}
				if (null != this.MouseWheelLeftEvtRelay)
				{
					this.MouseWheelLeftEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.MouseWheelLeftEvtRelay)
				{
					this.MouseWheelLeftEvtRelay.RemoveHandler(value);
					if (!this.MouseWheelLeftEvtRelay.HasHandlers())
					{
						this.MouseWheelLeftEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The MouseWheelRightEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.MouseWheelRightEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400003F RID: 63
		// (add) Token: 0x060000FB RID: 251 RVA: 0x00004D98 File Offset: 0x00002F98
		// (remove) Token: 0x060000FC RID: 252 RVA: 0x00004DE8 File Offset: 0x00002FE8
		public event vtkObject.vtkObjectEventHandler MouseWheelRightEvt
		{
			add
			{
				if (null == this.MouseWheelRightEvtRelay)
				{
					this.MouseWheelRightEvtRelay = new vtkObjectEventRelay(this, 128U);
				}
				if (null != this.MouseWheelRightEvtRelay)
				{
					this.MouseWheelRightEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.MouseWheelRightEvtRelay)
				{
					this.MouseWheelRightEvtRelay.RemoveHandler(value);
					if (!this.MouseWheelRightEvtRelay.HasHandlers())
					{
						this.MouseWheelRightEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The Move3DEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.Move3DEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000040 RID: 64
		// (add) Token: 0x060000FD RID: 253 RVA: 0x00004E2C File Offset: 0x0000302C
		// (remove) Token: 0x060000FE RID: 254 RVA: 0x00004E78 File Offset: 0x00003078
		public event vtkObject.vtkObjectEventHandler Move3DEvt
		{
			add
			{
				if (null == this.Move3DEvtRelay)
				{
					this.Move3DEvtRelay = new vtkObjectEventRelay(this, 121U);
				}
				if (null != this.Move3DEvtRelay)
				{
					this.Move3DEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.Move3DEvtRelay)
				{
					this.Move3DEvtRelay.RemoveHandler(value);
					if (!this.Move3DEvtRelay.HasHandlers())
					{
						this.Move3DEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The NextPose3DEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.NextPose3DEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000041 RID: 65
		// (add) Token: 0x060000FF RID: 255 RVA: 0x00004EBC File Offset: 0x000030BC
		// (remove) Token: 0x06000100 RID: 256 RVA: 0x00004F0C File Offset: 0x0000310C
		public event vtkObject.vtkObjectEventHandler NextPose3DEvt
		{
			add
			{
				if (null == this.NextPose3DEvtRelay)
				{
					this.NextPose3DEvtRelay = new vtkObjectEventRelay(this, 131U);
				}
				if (null != this.NextPose3DEvtRelay)
				{
					this.NextPose3DEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.NextPose3DEvtRelay)
				{
					this.NextPose3DEvtRelay.RemoveHandler(value);
					if (!this.NextPose3DEvtRelay.HasHandlers())
					{
						this.NextPose3DEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The NoEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.NoEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000042 RID: 66
		// (add) Token: 0x06000101 RID: 257 RVA: 0x00004F50 File Offset: 0x00003150
		// (remove) Token: 0x06000102 RID: 258 RVA: 0x00004F9C File Offset: 0x0000319C
		public event vtkObject.vtkObjectEventHandler NoEvt
		{
			add
			{
				if (null == this.NoEvtRelay)
				{
					this.NoEvtRelay = new vtkObjectEventRelay(this, 0U);
				}
				if (null != this.NoEvtRelay)
				{
					this.NoEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.NoEvtRelay)
				{
					this.NoEvtRelay.RemoveHandler(value);
					if (!this.NoEvtRelay.HasHandlers())
					{
						this.NoEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The PanEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.PanEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000043 RID: 67
		// (add) Token: 0x06000103 RID: 259 RVA: 0x00004FE0 File Offset: 0x000031E0
		// (remove) Token: 0x06000104 RID: 260 RVA: 0x0000502C File Offset: 0x0000322C
		public event vtkObject.vtkObjectEventHandler PanEvt
		{
			add
			{
				if (null == this.PanEvtRelay)
				{
					this.PanEvtRelay = new vtkObjectEventRelay(this, 113U);
				}
				if (null != this.PanEvtRelay)
				{
					this.PanEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.PanEvtRelay)
				{
					this.PanEvtRelay.RemoveHandler(value);
					if (!this.PanEvtRelay.HasHandlers())
					{
						this.PanEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The PickEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.PickEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000044 RID: 68
		// (add) Token: 0x06000105 RID: 261 RVA: 0x00005070 File Offset: 0x00003270
		// (remove) Token: 0x06000106 RID: 262 RVA: 0x000050BC File Offset: 0x000032BC
		public event vtkObject.vtkObjectEventHandler PickEvt
		{
			add
			{
				if (null == this.PickEvtRelay)
				{
					this.PickEvtRelay = new vtkObjectEventRelay(this, 7U);
				}
				if (null != this.PickEvtRelay)
				{
					this.PickEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.PickEvtRelay)
				{
					this.PickEvtRelay.RemoveHandler(value);
					if (!this.PickEvtRelay.HasHandlers())
					{
						this.PickEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The Pick3DEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.Pick3DEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000045 RID: 69
		// (add) Token: 0x06000107 RID: 263 RVA: 0x00005100 File Offset: 0x00003300
		// (remove) Token: 0x06000108 RID: 264 RVA: 0x00005150 File Offset: 0x00003350
		public event vtkObject.vtkObjectEventHandler Pick3DEvt
		{
			add
			{
				if (null == this.Pick3DEvtRelay)
				{
					this.Pick3DEvtRelay = new vtkObjectEventRelay(this, 134U);
				}
				if (null != this.Pick3DEvtRelay)
				{
					this.Pick3DEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.Pick3DEvtRelay)
				{
					this.Pick3DEvtRelay.RemoveHandler(value);
					if (!this.Pick3DEvtRelay.HasHandlers())
					{
						this.Pick3DEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The PinchEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.PinchEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000046 RID: 70
		// (add) Token: 0x06000109 RID: 265 RVA: 0x00005194 File Offset: 0x00003394
		// (remove) Token: 0x0600010A RID: 266 RVA: 0x000051E0 File Offset: 0x000033E0
		public event vtkObject.vtkObjectEventHandler PinchEvt
		{
			add
			{
				if (null == this.PinchEvtRelay)
				{
					this.PinchEvtRelay = new vtkObjectEventRelay(this, 107U);
				}
				if (null != this.PinchEvtRelay)
				{
					this.PinchEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.PinchEvtRelay)
				{
					this.PinchEvtRelay.RemoveHandler(value);
					if (!this.PinchEvtRelay.HasHandlers())
					{
						this.PinchEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The PlacePointEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.PlacePointEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000047 RID: 71
		// (add) Token: 0x0600010B RID: 267 RVA: 0x00005224 File Offset: 0x00003424
		// (remove) Token: 0x0600010C RID: 268 RVA: 0x00005270 File Offset: 0x00003470
		public event vtkObject.vtkObjectEventHandler PlacePointEvt
		{
			add
			{
				if (null == this.PlacePointEvtRelay)
				{
					this.PlacePointEvtRelay = new vtkObjectEventRelay(this, 50U);
				}
				if (null != this.PlacePointEvtRelay)
				{
					this.PlacePointEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.PlacePointEvtRelay)
				{
					this.PlacePointEvtRelay.RemoveHandler(value);
					if (!this.PlacePointEvtRelay.HasHandlers())
					{
						this.PlacePointEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The PlaceWidgetEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.PlaceWidgetEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000048 RID: 72
		// (add) Token: 0x0600010D RID: 269 RVA: 0x000052B4 File Offset: 0x000034B4
		// (remove) Token: 0x0600010E RID: 270 RVA: 0x00005300 File Offset: 0x00003500
		public event vtkObject.vtkObjectEventHandler PlaceWidgetEvt
		{
			add
			{
				if (null == this.PlaceWidgetEvtRelay)
				{
					this.PlaceWidgetEvtRelay = new vtkObjectEventRelay(this, 52U);
				}
				if (null != this.PlaceWidgetEvtRelay)
				{
					this.PlaceWidgetEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.PlaceWidgetEvtRelay)
				{
					this.PlaceWidgetEvtRelay.RemoveHandler(value);
					if (!this.PlaceWidgetEvtRelay.HasHandlers())
					{
						this.PlaceWidgetEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The PositionProp3DEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.PositionProp3DEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000049 RID: 73
		// (add) Token: 0x0600010F RID: 271 RVA: 0x00005344 File Offset: 0x00003544
		// (remove) Token: 0x06000110 RID: 272 RVA: 0x00005394 File Offset: 0x00003594
		public event vtkObject.vtkObjectEventHandler PositionProp3DEvt
		{
			add
			{
				if (null == this.PositionProp3DEvtRelay)
				{
					this.PositionProp3DEvtRelay = new vtkObjectEventRelay(this, 133U);
				}
				if (null != this.PositionProp3DEvtRelay)
				{
					this.PositionProp3DEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.PositionProp3DEvtRelay)
				{
					this.PositionProp3DEvtRelay.RemoveHandler(value);
					if (!this.PositionProp3DEvtRelay.HasHandlers())
					{
						this.PositionProp3DEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The ProgressEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.ProgressEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400004A RID: 74
		// (add) Token: 0x06000111 RID: 273 RVA: 0x000053D8 File Offset: 0x000035D8
		// (remove) Token: 0x06000112 RID: 274 RVA: 0x00005424 File Offset: 0x00003624
		public event vtkObject.vtkObjectEventHandler ProgressEvt
		{
			add
			{
				if (null == this.ProgressEvtRelay)
				{
					this.ProgressEvtRelay = new vtkObjectEventRelay(this, 6U);
				}
				if (null != this.ProgressEvtRelay)
				{
					this.ProgressEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.ProgressEvtRelay)
				{
					this.ProgressEvtRelay.RemoveHandler(value);
					if (!this.ProgressEvtRelay.HasHandlers())
					{
						this.ProgressEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The PropertyModifiedEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.PropertyModifiedEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400004B RID: 75
		// (add) Token: 0x06000113 RID: 275 RVA: 0x00005468 File Offset: 0x00003668
		// (remove) Token: 0x06000114 RID: 276 RVA: 0x000054B4 File Offset: 0x000036B4
		public event vtkObject.vtkObjectEventHandler PropertyModifiedEvt
		{
			add
			{
				if (null == this.PropertyModifiedEvtRelay)
				{
					this.PropertyModifiedEvtRelay = new vtkObjectEventRelay(this, 73U);
				}
				if (null != this.PropertyModifiedEvtRelay)
				{
					this.PropertyModifiedEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.PropertyModifiedEvtRelay)
				{
					this.PropertyModifiedEvtRelay.RemoveHandler(value);
					if (!this.PropertyModifiedEvtRelay.HasHandlers())
					{
						this.PropertyModifiedEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The RegisterEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.RegisterEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400004C RID: 76
		// (add) Token: 0x06000115 RID: 277 RVA: 0x000054F8 File Offset: 0x000036F8
		// (remove) Token: 0x06000116 RID: 278 RVA: 0x00005544 File Offset: 0x00003744
		public event vtkObject.vtkObjectEventHandler RegisterEvt
		{
			add
			{
				if (null == this.RegisterEvtRelay)
				{
					this.RegisterEvtRelay = new vtkObjectEventRelay(this, 75U);
				}
				if (null != this.RegisterEvtRelay)
				{
					this.RegisterEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.RegisterEvtRelay)
				{
					this.RegisterEvtRelay.RemoveHandler(value);
					if (!this.RegisterEvtRelay.HasHandlers())
					{
						this.RegisterEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The RenderEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.RenderEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400004D RID: 77
		// (add) Token: 0x06000117 RID: 279 RVA: 0x00005588 File Offset: 0x00003788
		// (remove) Token: 0x06000118 RID: 280 RVA: 0x000055D4 File Offset: 0x000037D4
		public event vtkObject.vtkObjectEventHandler RenderEvt
		{
			add
			{
				if (null == this.RenderEvtRelay)
				{
					this.RenderEvtRelay = new vtkObjectEventRelay(this, 5U);
				}
				if (null != this.RenderEvtRelay)
				{
					this.RenderEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.RenderEvtRelay)
				{
					this.RenderEvtRelay.RemoveHandler(value);
					if (!this.RenderEvtRelay.HasHandlers())
					{
						this.RenderEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The RenderWindowMessageEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.RenderWindowMessageEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400004E RID: 78
		// (add) Token: 0x06000119 RID: 281 RVA: 0x00005618 File Offset: 0x00003818
		// (remove) Token: 0x0600011A RID: 282 RVA: 0x00005664 File Offset: 0x00003864
		public event vtkObject.vtkObjectEventHandler RenderWindowMessageEvt
		{
			add
			{
				if (null == this.RenderWindowMessageEvtRelay)
				{
					this.RenderWindowMessageEvtRelay = new vtkObjectEventRelay(this, 55U);
				}
				if (null != this.RenderWindowMessageEvtRelay)
				{
					this.RenderWindowMessageEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.RenderWindowMessageEvtRelay)
				{
					this.RenderWindowMessageEvtRelay.RemoveHandler(value);
					if (!this.RenderWindowMessageEvtRelay.HasHandlers())
					{
						this.RenderWindowMessageEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The ResetCameraEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.ResetCameraEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400004F RID: 79
		// (add) Token: 0x0600011B RID: 283 RVA: 0x000056A8 File Offset: 0x000038A8
		// (remove) Token: 0x0600011C RID: 284 RVA: 0x000056F4 File Offset: 0x000038F4
		public event vtkObject.vtkObjectEventHandler ResetCameraEvt
		{
			add
			{
				if (null == this.ResetCameraEvtRelay)
				{
					this.ResetCameraEvtRelay = new vtkObjectEventRelay(this, 31U);
				}
				if (null != this.ResetCameraEvtRelay)
				{
					this.ResetCameraEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.ResetCameraEvtRelay)
				{
					this.ResetCameraEvtRelay.RemoveHandler(value);
					if (!this.ResetCameraEvtRelay.HasHandlers())
					{
						this.ResetCameraEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The ResetCameraClippingRangeEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.ResetCameraClippingRangeEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000050 RID: 80
		// (add) Token: 0x0600011D RID: 285 RVA: 0x00005738 File Offset: 0x00003938
		// (remove) Token: 0x0600011E RID: 286 RVA: 0x00005784 File Offset: 0x00003984
		public event vtkObject.vtkObjectEventHandler ResetCameraClippingRangeEvt
		{
			add
			{
				if (null == this.ResetCameraClippingRangeEvtRelay)
				{
					this.ResetCameraClippingRangeEvtRelay = new vtkObjectEventRelay(this, 32U);
				}
				if (null != this.ResetCameraClippingRangeEvtRelay)
				{
					this.ResetCameraClippingRangeEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.ResetCameraClippingRangeEvtRelay)
				{
					this.ResetCameraClippingRangeEvtRelay.RemoveHandler(value);
					if (!this.ResetCameraClippingRangeEvtRelay.HasHandlers())
					{
						this.ResetCameraClippingRangeEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The ResetWindowLevelEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.ResetWindowLevelEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000051 RID: 81
		// (add) Token: 0x0600011F RID: 287 RVA: 0x000057C8 File Offset: 0x000039C8
		// (remove) Token: 0x06000120 RID: 288 RVA: 0x00005814 File Offset: 0x00003A14
		public event vtkObject.vtkObjectEventHandler ResetWindowLevelEvt
		{
			add
			{
				if (null == this.ResetWindowLevelEvtRelay)
				{
					this.ResetWindowLevelEvtRelay = new vtkObjectEventRelay(this, 37U);
				}
				if (null != this.ResetWindowLevelEvtRelay)
				{
					this.ResetWindowLevelEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.ResetWindowLevelEvtRelay)
				{
					this.ResetWindowLevelEvtRelay.RemoveHandler(value);
					if (!this.ResetWindowLevelEvtRelay.HasHandlers())
					{
						this.ResetWindowLevelEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The ResliceAxesChangedEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.ResliceAxesChangedEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000052 RID: 82
		// (add) Token: 0x06000121 RID: 289 RVA: 0x00005858 File Offset: 0x00003A58
		// (remove) Token: 0x06000122 RID: 290 RVA: 0x000058A4 File Offset: 0x00003AA4
		public event vtkObject.vtkObjectEventHandler ResliceAxesChangedEvt
		{
			add
			{
				if (null == this.ResliceAxesChangedEvtRelay)
				{
					this.ResliceAxesChangedEvtRelay = new vtkObjectEventRelay(this, 58U);
				}
				if (null != this.ResliceAxesChangedEvtRelay)
				{
					this.ResliceAxesChangedEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.ResliceAxesChangedEvtRelay)
				{
					this.ResliceAxesChangedEvtRelay.RemoveHandler(value);
					if (!this.ResliceAxesChangedEvtRelay.HasHandlers())
					{
						this.ResliceAxesChangedEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The RightButtonDoubleClickEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.RightButtonDoubleClickEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000053 RID: 83
		// (add) Token: 0x06000123 RID: 291 RVA: 0x000058E8 File Offset: 0x00003AE8
		// (remove) Token: 0x06000124 RID: 292 RVA: 0x00005934 File Offset: 0x00003B34
		public event vtkObject.vtkObjectEventHandler RightButtonDoubleClickEvt
		{
			add
			{
				if (null == this.RightButtonDoubleClickEvtRelay)
				{
					this.RightButtonDoubleClickEvtRelay = new vtkObjectEventRelay(this, 126U);
				}
				if (null != this.RightButtonDoubleClickEvtRelay)
				{
					this.RightButtonDoubleClickEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.RightButtonDoubleClickEvtRelay)
				{
					this.RightButtonDoubleClickEvtRelay.RemoveHandler(value);
					if (!this.RightButtonDoubleClickEvtRelay.HasHandlers())
					{
						this.RightButtonDoubleClickEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The RightButtonPressEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.RightButtonPressEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000054 RID: 84
		// (add) Token: 0x06000125 RID: 293 RVA: 0x00005978 File Offset: 0x00003B78
		// (remove) Token: 0x06000126 RID: 294 RVA: 0x000059C4 File Offset: 0x00003BC4
		public event vtkObject.vtkObjectEventHandler RightButtonPressEvt
		{
			add
			{
				if (null == this.RightButtonPressEvtRelay)
				{
					this.RightButtonPressEvtRelay = new vtkObjectEventRelay(this, 16U);
				}
				if (null != this.RightButtonPressEvtRelay)
				{
					this.RightButtonPressEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.RightButtonPressEvtRelay)
				{
					this.RightButtonPressEvtRelay.RemoveHandler(value);
					if (!this.RightButtonPressEvtRelay.HasHandlers())
					{
						this.RightButtonPressEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The RightButtonReleaseEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.RightButtonReleaseEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000055 RID: 85
		// (add) Token: 0x06000127 RID: 295 RVA: 0x00005A08 File Offset: 0x00003C08
		// (remove) Token: 0x06000128 RID: 296 RVA: 0x00005A54 File Offset: 0x00003C54
		public event vtkObject.vtkObjectEventHandler RightButtonReleaseEvt
		{
			add
			{
				if (null == this.RightButtonReleaseEvtRelay)
				{
					this.RightButtonReleaseEvtRelay = new vtkObjectEventRelay(this, 17U);
				}
				if (null != this.RightButtonReleaseEvtRelay)
				{
					this.RightButtonReleaseEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.RightButtonReleaseEvtRelay)
				{
					this.RightButtonReleaseEvtRelay.RemoveHandler(value);
					if (!this.RightButtonReleaseEvtRelay.HasHandlers())
					{
						this.RightButtonReleaseEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The RotateEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.RotateEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000056 RID: 86
		// (add) Token: 0x06000129 RID: 297 RVA: 0x00005A98 File Offset: 0x00003C98
		// (remove) Token: 0x0600012A RID: 298 RVA: 0x00005AE4 File Offset: 0x00003CE4
		public event vtkObject.vtkObjectEventHandler RotateEvt
		{
			add
			{
				if (null == this.RotateEvtRelay)
				{
					this.RotateEvtRelay = new vtkObjectEventRelay(this, 110U);
				}
				if (null != this.RotateEvtRelay)
				{
					this.RotateEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.RotateEvtRelay)
				{
					this.RotateEvtRelay.RemoveHandler(value);
					if (!this.RotateEvtRelay.HasHandlers())
					{
						this.RotateEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The SaveStateEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.SaveStateEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000057 RID: 87
		// (add) Token: 0x0600012B RID: 299 RVA: 0x00005B28 File Offset: 0x00003D28
		// (remove) Token: 0x0600012C RID: 300 RVA: 0x00005B74 File Offset: 0x00003D74
		public event vtkObject.vtkObjectEventHandler SaveStateEvt
		{
			add
			{
				if (null == this.SaveStateEvtRelay)
				{
					this.SaveStateEvtRelay = new vtkObjectEventRelay(this, 90U);
				}
				if (null != this.SaveStateEvtRelay)
				{
					this.SaveStateEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.SaveStateEvtRelay)
				{
					this.SaveStateEvtRelay.RemoveHandler(value);
					if (!this.SaveStateEvtRelay.HasHandlers())
					{
						this.SaveStateEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The Select3DEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.Select3DEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000058 RID: 88
		// (add) Token: 0x0600012D RID: 301 RVA: 0x00005BB8 File Offset: 0x00003DB8
		// (remove) Token: 0x0600012E RID: 302 RVA: 0x00005C08 File Offset: 0x00003E08
		public event vtkObject.vtkObjectEventHandler Select3DEvt
		{
			add
			{
				if (null == this.Select3DEvtRelay)
				{
					this.Select3DEvtRelay = new vtkObjectEventRelay(this, 135U);
				}
				if (null != this.Select3DEvtRelay)
				{
					this.Select3DEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.Select3DEvtRelay)
				{
					this.Select3DEvtRelay.RemoveHandler(value);
					if (!this.Select3DEvtRelay.HasHandlers())
					{
						this.Select3DEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The SelectionChangedEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.SelectionChangedEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000059 RID: 89
		// (add) Token: 0x0600012F RID: 303 RVA: 0x00005C4C File Offset: 0x00003E4C
		// (remove) Token: 0x06000130 RID: 304 RVA: 0x00005C98 File Offset: 0x00003E98
		public event vtkObject.vtkObjectEventHandler SelectionChangedEvt
		{
			add
			{
				if (null == this.SelectionChangedEvtRelay)
				{
					this.SelectionChangedEvtRelay = new vtkObjectEventRelay(this, 79U);
				}
				if (null != this.SelectionChangedEvtRelay)
				{
					this.SelectionChangedEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.SelectionChangedEvtRelay)
				{
					this.SelectionChangedEvtRelay.RemoveHandler(value);
					if (!this.SelectionChangedEvtRelay.HasHandlers())
					{
						this.SelectionChangedEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The SetOutputEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.SetOutputEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400005A RID: 90
		// (add) Token: 0x06000131 RID: 305 RVA: 0x00005CDC File Offset: 0x00003EDC
		// (remove) Token: 0x06000132 RID: 306 RVA: 0x00005D28 File Offset: 0x00003F28
		public event vtkObject.vtkObjectEventHandler SetOutputEvt
		{
			add
			{
				if (null == this.SetOutputEvtRelay)
				{
					this.SetOutputEvtRelay = new vtkObjectEventRelay(this, 38U);
				}
				if (null != this.SetOutputEvtRelay)
				{
					this.SetOutputEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.SetOutputEvtRelay)
				{
					this.SetOutputEvtRelay.RemoveHandler(value);
					if (!this.SetOutputEvtRelay.HasHandlers())
					{
						this.SetOutputEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The StartEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.StartEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400005B RID: 91
		// (add) Token: 0x06000133 RID: 307 RVA: 0x00005D6C File Offset: 0x00003F6C
		// (remove) Token: 0x06000134 RID: 308 RVA: 0x00005DB8 File Offset: 0x00003FB8
		public event vtkObject.vtkObjectEventHandler StartEvt
		{
			add
			{
				if (null == this.StartEvtRelay)
				{
					this.StartEvtRelay = new vtkObjectEventRelay(this, 3U);
				}
				if (null != this.StartEvtRelay)
				{
					this.StartEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.StartEvtRelay)
				{
					this.StartEvtRelay.RemoveHandler(value);
					if (!this.StartEvtRelay.HasHandlers())
					{
						this.StartEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The StartAnimationCueEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.StartAnimationCueEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400005C RID: 92
		// (add) Token: 0x06000135 RID: 309 RVA: 0x00005DFC File Offset: 0x00003FFC
		// (remove) Token: 0x06000136 RID: 310 RVA: 0x00005E48 File Offset: 0x00004048
		public event vtkObject.vtkObjectEventHandler StartAnimationCueEvt
		{
			add
			{
				if (null == this.StartAnimationCueEvtRelay)
				{
					this.StartAnimationCueEvtRelay = new vtkObjectEventRelay(this, 57U);
				}
				if (null != this.StartAnimationCueEvtRelay)
				{
					this.StartAnimationCueEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.StartAnimationCueEvtRelay)
				{
					this.StartAnimationCueEvtRelay.RemoveHandler(value);
					if (!this.StartAnimationCueEvtRelay.HasHandlers())
					{
						this.StartAnimationCueEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The StartInteractionEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.StartInteractionEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400005D RID: 93
		// (add) Token: 0x06000137 RID: 311 RVA: 0x00005E8C File Offset: 0x0000408C
		// (remove) Token: 0x06000138 RID: 312 RVA: 0x00005ED8 File Offset: 0x000040D8
		public event vtkObject.vtkObjectEventHandler StartInteractionEvt
		{
			add
			{
				if (null == this.StartInteractionEvtRelay)
				{
					this.StartInteractionEvtRelay = new vtkObjectEventRelay(this, 41U);
				}
				if (null != this.StartInteractionEvtRelay)
				{
					this.StartInteractionEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.StartInteractionEvtRelay)
				{
					this.StartInteractionEvtRelay.RemoveHandler(value);
					if (!this.StartInteractionEvtRelay.HasHandlers())
					{
						this.StartInteractionEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The StartPanEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.StartPanEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400005E RID: 94
		// (add) Token: 0x06000139 RID: 313 RVA: 0x00005F1C File Offset: 0x0000411C
		// (remove) Token: 0x0600013A RID: 314 RVA: 0x00005F68 File Offset: 0x00004168
		public event vtkObject.vtkObjectEventHandler StartPanEvt
		{
			add
			{
				if (null == this.StartPanEvtRelay)
				{
					this.StartPanEvtRelay = new vtkObjectEventRelay(this, 112U);
				}
				if (null != this.StartPanEvtRelay)
				{
					this.StartPanEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.StartPanEvtRelay)
				{
					this.StartPanEvtRelay.RemoveHandler(value);
					if (!this.StartPanEvtRelay.HasHandlers())
					{
						this.StartPanEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The StartPickEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.StartPickEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400005F RID: 95
		// (add) Token: 0x0600013B RID: 315 RVA: 0x00005FAC File Offset: 0x000041AC
		// (remove) Token: 0x0600013C RID: 316 RVA: 0x00005FF8 File Offset: 0x000041F8
		public event vtkObject.vtkObjectEventHandler StartPickEvt
		{
			add
			{
				if (null == this.StartPickEvtRelay)
				{
					this.StartPickEvtRelay = new vtkObjectEventRelay(this, 8U);
				}
				if (null != this.StartPickEvtRelay)
				{
					this.StartPickEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.StartPickEvtRelay)
				{
					this.StartPickEvtRelay.RemoveHandler(value);
					if (!this.StartPickEvtRelay.HasHandlers())
					{
						this.StartPickEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The StartPinchEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.StartPinchEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000060 RID: 96
		// (add) Token: 0x0600013D RID: 317 RVA: 0x0000603C File Offset: 0x0000423C
		// (remove) Token: 0x0600013E RID: 318 RVA: 0x00006088 File Offset: 0x00004288
		public event vtkObject.vtkObjectEventHandler StartPinchEvt
		{
			add
			{
				if (null == this.StartPinchEvtRelay)
				{
					this.StartPinchEvtRelay = new vtkObjectEventRelay(this, 106U);
				}
				if (null != this.StartPinchEvtRelay)
				{
					this.StartPinchEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.StartPinchEvtRelay)
				{
					this.StartPinchEvtRelay.RemoveHandler(value);
					if (!this.StartPinchEvtRelay.HasHandlers())
					{
						this.StartPinchEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The StartRotateEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.StartRotateEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000061 RID: 97
		// (add) Token: 0x0600013F RID: 319 RVA: 0x000060CC File Offset: 0x000042CC
		// (remove) Token: 0x06000140 RID: 320 RVA: 0x00006118 File Offset: 0x00004318
		public event vtkObject.vtkObjectEventHandler StartRotateEvt
		{
			add
			{
				if (null == this.StartRotateEvtRelay)
				{
					this.StartRotateEvtRelay = new vtkObjectEventRelay(this, 109U);
				}
				if (null != this.StartRotateEvtRelay)
				{
					this.StartRotateEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.StartRotateEvtRelay)
				{
					this.StartRotateEvtRelay.RemoveHandler(value);
					if (!this.StartRotateEvtRelay.HasHandlers())
					{
						this.StartRotateEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The StartSwipeEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.StartSwipeEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000062 RID: 98
		// (add) Token: 0x06000141 RID: 321 RVA: 0x0000615C File Offset: 0x0000435C
		// (remove) Token: 0x06000142 RID: 322 RVA: 0x000061A8 File Offset: 0x000043A8
		public event vtkObject.vtkObjectEventHandler StartSwipeEvt
		{
			add
			{
				if (null == this.StartSwipeEvtRelay)
				{
					this.StartSwipeEvtRelay = new vtkObjectEventRelay(this, 103U);
				}
				if (null != this.StartSwipeEvtRelay)
				{
					this.StartSwipeEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.StartSwipeEvtRelay)
				{
					this.StartSwipeEvtRelay.RemoveHandler(value);
					if (!this.StartSwipeEvtRelay.HasHandlers())
					{
						this.StartSwipeEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The StartWindowLevelEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.StartWindowLevelEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000063 RID: 99
		// (add) Token: 0x06000143 RID: 323 RVA: 0x000061EC File Offset: 0x000043EC
		// (remove) Token: 0x06000144 RID: 324 RVA: 0x00006238 File Offset: 0x00004438
		public event vtkObject.vtkObjectEventHandler StartWindowLevelEvt
		{
			add
			{
				if (null == this.StartWindowLevelEvtRelay)
				{
					this.StartWindowLevelEvtRelay = new vtkObjectEventRelay(this, 35U);
				}
				if (null != this.StartWindowLevelEvtRelay)
				{
					this.StartWindowLevelEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.StartWindowLevelEvtRelay)
				{
					this.StartWindowLevelEvtRelay.RemoveHandler(value);
					if (!this.StartWindowLevelEvtRelay.HasHandlers())
					{
						this.StartWindowLevelEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The StateChangedEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.StateChangedEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000064 RID: 100
		// (add) Token: 0x06000145 RID: 325 RVA: 0x0000627C File Offset: 0x0000447C
		// (remove) Token: 0x06000146 RID: 326 RVA: 0x000062C8 File Offset: 0x000044C8
		public event vtkObject.vtkObjectEventHandler StateChangedEvt
		{
			add
			{
				if (null == this.StateChangedEvtRelay)
				{
					this.StateChangedEvtRelay = new vtkObjectEventRelay(this, 91U);
				}
				if (null != this.StateChangedEvtRelay)
				{
					this.StateChangedEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.StateChangedEvtRelay)
				{
					this.StateChangedEvtRelay.RemoveHandler(value);
					if (!this.StateChangedEvtRelay.HasHandlers())
					{
						this.StateChangedEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The SwipeEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.SwipeEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000065 RID: 101
		// (add) Token: 0x06000147 RID: 327 RVA: 0x0000630C File Offset: 0x0000450C
		// (remove) Token: 0x06000148 RID: 328 RVA: 0x00006358 File Offset: 0x00004558
		public event vtkObject.vtkObjectEventHandler SwipeEvt
		{
			add
			{
				if (null == this.SwipeEvtRelay)
				{
					this.SwipeEvtRelay = new vtkObjectEventRelay(this, 104U);
				}
				if (null != this.SwipeEvtRelay)
				{
					this.SwipeEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.SwipeEvtRelay)
				{
					this.SwipeEvtRelay.RemoveHandler(value);
					if (!this.SwipeEvtRelay.HasHandlers())
					{
						this.SwipeEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The TapEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.TapEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000066 RID: 102
		// (add) Token: 0x06000149 RID: 329 RVA: 0x0000639C File Offset: 0x0000459C
		// (remove) Token: 0x0600014A RID: 330 RVA: 0x000063E8 File Offset: 0x000045E8
		public event vtkObject.vtkObjectEventHandler TapEvt
		{
			add
			{
				if (null == this.TapEvtRelay)
				{
					this.TapEvtRelay = new vtkObjectEventRelay(this, 115U);
				}
				if (null != this.TapEvtRelay)
				{
					this.TapEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.TapEvtRelay)
				{
					this.TapEvtRelay.RemoveHandler(value);
					if (!this.TapEvtRelay.HasHandlers())
					{
						this.TapEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The TDxButtonPressEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.TDxButtonPressEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000067 RID: 103
		// (add) Token: 0x0600014B RID: 331 RVA: 0x0000642C File Offset: 0x0000462C
		// (remove) Token: 0x0600014C RID: 332 RVA: 0x00006478 File Offset: 0x00004678
		public event vtkObject.vtkObjectEventHandler TDxButtonPressEvt
		{
			add
			{
				if (null == this.TDxButtonPressEvtRelay)
				{
					this.TDxButtonPressEvtRelay = new vtkObjectEventRelay(this, 86U);
				}
				if (null != this.TDxButtonPressEvtRelay)
				{
					this.TDxButtonPressEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.TDxButtonPressEvtRelay)
				{
					this.TDxButtonPressEvtRelay.RemoveHandler(value);
					if (!this.TDxButtonPressEvtRelay.HasHandlers())
					{
						this.TDxButtonPressEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The TDxButtonReleaseEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.TDxButtonReleaseEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000068 RID: 104
		// (add) Token: 0x0600014D RID: 333 RVA: 0x000064BC File Offset: 0x000046BC
		// (remove) Token: 0x0600014E RID: 334 RVA: 0x00006508 File Offset: 0x00004708
		public event vtkObject.vtkObjectEventHandler TDxButtonReleaseEvt
		{
			add
			{
				if (null == this.TDxButtonReleaseEvtRelay)
				{
					this.TDxButtonReleaseEvtRelay = new vtkObjectEventRelay(this, 87U);
				}
				if (null != this.TDxButtonReleaseEvtRelay)
				{
					this.TDxButtonReleaseEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.TDxButtonReleaseEvtRelay)
				{
					this.TDxButtonReleaseEvtRelay.RemoveHandler(value);
					if (!this.TDxButtonReleaseEvtRelay.HasHandlers())
					{
						this.TDxButtonReleaseEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The TDxMotionEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.TDxMotionEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000069 RID: 105
		// (add) Token: 0x0600014F RID: 335 RVA: 0x0000654C File Offset: 0x0000474C
		// (remove) Token: 0x06000150 RID: 336 RVA: 0x00006598 File Offset: 0x00004798
		public event vtkObject.vtkObjectEventHandler TDxMotionEvt
		{
			add
			{
				if (null == this.TDxMotionEvtRelay)
				{
					this.TDxMotionEvtRelay = new vtkObjectEventRelay(this, 85U);
				}
				if (null != this.TDxMotionEvtRelay)
				{
					this.TDxMotionEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.TDxMotionEvtRelay)
				{
					this.TDxMotionEvtRelay.RemoveHandler(value);
					if (!this.TDxMotionEvtRelay.HasHandlers())
					{
						this.TDxMotionEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The TextEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.TextEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400006A RID: 106
		// (add) Token: 0x06000151 RID: 337 RVA: 0x000065DC File Offset: 0x000047DC
		// (remove) Token: 0x06000152 RID: 338 RVA: 0x00006628 File Offset: 0x00004828
		public event vtkObject.vtkObjectEventHandler TextEvt
		{
			add
			{
				if (null == this.TextEvtRelay)
				{
					this.TextEvtRelay = new vtkObjectEventRelay(this, 123U);
				}
				if (null != this.TextEvtRelay)
				{
					this.TextEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.TextEvtRelay)
				{
					this.TextEvtRelay.RemoveHandler(value);
					if (!this.TextEvtRelay.HasHandlers())
					{
						this.TextEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The TimerEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.TimerEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400006B RID: 107
		// (add) Token: 0x06000153 RID: 339 RVA: 0x0000666C File Offset: 0x0000486C
		// (remove) Token: 0x06000154 RID: 340 RVA: 0x000066B8 File Offset: 0x000048B8
		public event vtkObject.vtkObjectEventHandler TimerEvt
		{
			add
			{
				if (null == this.TimerEvtRelay)
				{
					this.TimerEvtRelay = new vtkObjectEventRelay(this, 25U);
				}
				if (null != this.TimerEvtRelay)
				{
					this.TimerEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.TimerEvtRelay)
				{
					this.TimerEvtRelay.RemoveHandler(value);
					if (!this.TimerEvtRelay.HasHandlers())
					{
						this.TimerEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The UncheckedPropertyModifiedEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.UncheckedPropertyModifiedEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400006C RID: 108
		// (add) Token: 0x06000155 RID: 341 RVA: 0x000066FC File Offset: 0x000048FC
		// (remove) Token: 0x06000156 RID: 342 RVA: 0x00006748 File Offset: 0x00004948
		public event vtkObject.vtkObjectEventHandler UncheckedPropertyModifiedEvt
		{
			add
			{
				if (null == this.UncheckedPropertyModifiedEvtRelay)
				{
					this.UncheckedPropertyModifiedEvtRelay = new vtkObjectEventRelay(this, 100U);
				}
				if (null != this.UncheckedPropertyModifiedEvtRelay)
				{
					this.UncheckedPropertyModifiedEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.UncheckedPropertyModifiedEvtRelay)
				{
					this.UncheckedPropertyModifiedEvtRelay.RemoveHandler(value);
					if (!this.UncheckedPropertyModifiedEvtRelay.HasHandlers())
					{
						this.UncheckedPropertyModifiedEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The UnRegisterEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.UnRegisterEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400006D RID: 109
		// (add) Token: 0x06000157 RID: 343 RVA: 0x0000678C File Offset: 0x0000498C
		// (remove) Token: 0x06000158 RID: 344 RVA: 0x000067D8 File Offset: 0x000049D8
		public event vtkObject.vtkObjectEventHandler UnRegisterEvt
		{
			add
			{
				if (null == this.UnRegisterEvtRelay)
				{
					this.UnRegisterEvtRelay = new vtkObjectEventRelay(this, 76U);
				}
				if (null != this.UnRegisterEvtRelay)
				{
					this.UnRegisterEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.UnRegisterEvtRelay)
				{
					this.UnRegisterEvtRelay.RemoveHandler(value);
					if (!this.UnRegisterEvtRelay.HasHandlers())
					{
						this.UnRegisterEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The UpdateEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.UpdateEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400006E RID: 110
		// (add) Token: 0x06000159 RID: 345 RVA: 0x0000681C File Offset: 0x00004A1C
		// (remove) Token: 0x0600015A RID: 346 RVA: 0x00006868 File Offset: 0x00004A68
		public event vtkObject.vtkObjectEventHandler UpdateEvt
		{
			add
			{
				if (null == this.UpdateEvtRelay)
				{
					this.UpdateEvtRelay = new vtkObjectEventRelay(this, 74U);
				}
				if (null != this.UpdateEvtRelay)
				{
					this.UpdateEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.UpdateEvtRelay)
				{
					this.UpdateEvtRelay.RemoveHandler(value);
					if (!this.UpdateEvtRelay.HasHandlers())
					{
						this.UpdateEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The UpdateDataEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.UpdateDataEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400006F RID: 111
		// (add) Token: 0x0600015B RID: 347 RVA: 0x000068AC File Offset: 0x00004AAC
		// (remove) Token: 0x0600015C RID: 348 RVA: 0x000068F8 File Offset: 0x00004AF8
		public event vtkObject.vtkObjectEventHandler UpdateDataEvt
		{
			add
			{
				if (null == this.UpdateDataEvtRelay)
				{
					this.UpdateDataEvtRelay = new vtkObjectEventRelay(this, 82U);
				}
				if (null != this.UpdateDataEvtRelay)
				{
					this.UpdateDataEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.UpdateDataEvtRelay)
				{
					this.UpdateDataEvtRelay.RemoveHandler(value);
					if (!this.UpdateDataEvtRelay.HasHandlers())
					{
						this.UpdateDataEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The UpdateDropLocationEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.UpdateDropLocationEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000070 RID: 112
		// (add) Token: 0x0600015D RID: 349 RVA: 0x0000693C File Offset: 0x00004B3C
		// (remove) Token: 0x0600015E RID: 350 RVA: 0x00006988 File Offset: 0x00004B88
		public event vtkObject.vtkObjectEventHandler UpdateDropLocationEvt
		{
			add
			{
				if (null == this.UpdateDropLocationEvtRelay)
				{
					this.UpdateDropLocationEvtRelay = new vtkObjectEventRelay(this, 43U);
				}
				if (null != this.UpdateDropLocationEvtRelay)
				{
					this.UpdateDropLocationEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.UpdateDropLocationEvtRelay)
				{
					this.UpdateDropLocationEvtRelay.RemoveHandler(value);
					if (!this.UpdateDropLocationEvtRelay.HasHandlers())
					{
						this.UpdateDropLocationEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The UpdateInformationEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.UpdateInformationEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000071 RID: 113
		// (add) Token: 0x0600015F RID: 351 RVA: 0x000069CC File Offset: 0x00004BCC
		// (remove) Token: 0x06000160 RID: 352 RVA: 0x00006A18 File Offset: 0x00004C18
		public event vtkObject.vtkObjectEventHandler UpdateInformationEvt
		{
			add
			{
				if (null == this.UpdateInformationEvtRelay)
				{
					this.UpdateInformationEvtRelay = new vtkObjectEventRelay(this, 77U);
				}
				if (null != this.UpdateInformationEvtRelay)
				{
					this.UpdateInformationEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.UpdateInformationEvtRelay)
				{
					this.UpdateInformationEvtRelay.RemoveHandler(value);
					if (!this.UpdateInformationEvtRelay.HasHandlers())
					{
						this.UpdateInformationEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The UpdatePropertyEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.UpdatePropertyEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000072 RID: 114
		// (add) Token: 0x06000161 RID: 353 RVA: 0x00006A5C File Offset: 0x00004C5C
		// (remove) Token: 0x06000162 RID: 354 RVA: 0x00006AA8 File Offset: 0x00004CA8
		public event vtkObject.vtkObjectEventHandler UpdatePropertyEvt
		{
			add
			{
				if (null == this.UpdatePropertyEvtRelay)
				{
					this.UpdatePropertyEvtRelay = new vtkObjectEventRelay(this, 80U);
				}
				if (null != this.UpdatePropertyEvtRelay)
				{
					this.UpdatePropertyEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.UpdatePropertyEvtRelay)
				{
					this.UpdatePropertyEvtRelay.RemoveHandler(value);
					if (!this.UpdatePropertyEvtRelay.HasHandlers())
					{
						this.UpdatePropertyEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The UpdateShaderEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.UpdateShaderEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000073 RID: 115
		// (add) Token: 0x06000163 RID: 355 RVA: 0x00006AEC File Offset: 0x00004CEC
		// (remove) Token: 0x06000164 RID: 356 RVA: 0x00006B38 File Offset: 0x00004D38
		public event vtkObject.vtkObjectEventHandler UpdateShaderEvt
		{
			add
			{
				if (null == this.UpdateShaderEvtRelay)
				{
					this.UpdateShaderEvtRelay = new vtkObjectEventRelay(this, 101U);
				}
				if (null != this.UpdateShaderEvtRelay)
				{
					this.UpdateShaderEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.UpdateShaderEvtRelay)
				{
					this.UpdateShaderEvtRelay.RemoveHandler(value);
					if (!this.UpdateShaderEvtRelay.HasHandlers())
					{
						this.UpdateShaderEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The UserEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.UserEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000074 RID: 116
		// (add) Token: 0x06000165 RID: 357 RVA: 0x00006B7C File Offset: 0x00004D7C
		// (remove) Token: 0x06000166 RID: 358 RVA: 0x00006BCC File Offset: 0x00004DCC
		public event vtkObject.vtkObjectEventHandler UserEvt
		{
			add
			{
				if (null == this.UserEvtRelay)
				{
					this.UserEvtRelay = new vtkObjectEventRelay(this, 1000U);
				}
				if (null != this.UserEvtRelay)
				{
					this.UserEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.UserEvtRelay)
				{
					this.UserEvtRelay.RemoveHandler(value);
					if (!this.UserEvtRelay.HasHandlers())
					{
						this.UserEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The ViewerMovement3DEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.ViewerMovement3DEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000075 RID: 117
		// (add) Token: 0x06000167 RID: 359 RVA: 0x00006C10 File Offset: 0x00004E10
		// (remove) Token: 0x06000168 RID: 360 RVA: 0x00006C60 File Offset: 0x00004E60
		public event vtkObject.vtkObjectEventHandler ViewerMovement3DEvt
		{
			add
			{
				if (null == this.ViewerMovement3DEvtRelay)
				{
					this.ViewerMovement3DEvtRelay = new vtkObjectEventRelay(this, 129U);
				}
				if (null != this.ViewerMovement3DEvtRelay)
				{
					this.ViewerMovement3DEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.ViewerMovement3DEvtRelay)
				{
					this.ViewerMovement3DEvtRelay.RemoveHandler(value);
					if (!this.ViewerMovement3DEvtRelay.HasHandlers())
					{
						this.ViewerMovement3DEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The ViewProgressEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.ViewProgressEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000076 RID: 118
		// (add) Token: 0x06000169 RID: 361 RVA: 0x00006CA4 File Offset: 0x00004EA4
		// (remove) Token: 0x0600016A RID: 362 RVA: 0x00006CF0 File Offset: 0x00004EF0
		public event vtkObject.vtkObjectEventHandler ViewProgressEvt
		{
			add
			{
				if (null == this.ViewProgressEvtRelay)
				{
					this.ViewProgressEvtRelay = new vtkObjectEventRelay(this, 81U);
				}
				if (null != this.ViewProgressEvtRelay)
				{
					this.ViewProgressEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.ViewProgressEvtRelay)
				{
					this.ViewProgressEvtRelay.RemoveHandler(value);
					if (!this.ViewProgressEvtRelay.HasHandlers())
					{
						this.ViewProgressEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The VolumeMapperComputeGradientsEndEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.VolumeMapperComputeGradientsEndEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000077 RID: 119
		// (add) Token: 0x0600016B RID: 363 RVA: 0x00006D34 File Offset: 0x00004F34
		// (remove) Token: 0x0600016C RID: 364 RVA: 0x00006D80 File Offset: 0x00004F80
		public event vtkObject.vtkObjectEventHandler VolumeMapperComputeGradientsEndEvt
		{
			add
			{
				if (null == this.VolumeMapperComputeGradientsEndEvtRelay)
				{
					this.VolumeMapperComputeGradientsEndEvtRelay = new vtkObjectEventRelay(this, 64U);
				}
				if (null != this.VolumeMapperComputeGradientsEndEvtRelay)
				{
					this.VolumeMapperComputeGradientsEndEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.VolumeMapperComputeGradientsEndEvtRelay)
				{
					this.VolumeMapperComputeGradientsEndEvtRelay.RemoveHandler(value);
					if (!this.VolumeMapperComputeGradientsEndEvtRelay.HasHandlers())
					{
						this.VolumeMapperComputeGradientsEndEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The VolumeMapperComputeGradientsProgressEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.VolumeMapperComputeGradientsProgressEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000078 RID: 120
		// (add) Token: 0x0600016D RID: 365 RVA: 0x00006DC4 File Offset: 0x00004FC4
		// (remove) Token: 0x0600016E RID: 366 RVA: 0x00006E10 File Offset: 0x00005010
		public event vtkObject.vtkObjectEventHandler VolumeMapperComputeGradientsProgressEvt
		{
			add
			{
				if (null == this.VolumeMapperComputeGradientsProgressEvtRelay)
				{
					this.VolumeMapperComputeGradientsProgressEvtRelay = new vtkObjectEventRelay(this, 65U);
				}
				if (null != this.VolumeMapperComputeGradientsProgressEvtRelay)
				{
					this.VolumeMapperComputeGradientsProgressEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.VolumeMapperComputeGradientsProgressEvtRelay)
				{
					this.VolumeMapperComputeGradientsProgressEvtRelay.RemoveHandler(value);
					if (!this.VolumeMapperComputeGradientsProgressEvtRelay.HasHandlers())
					{
						this.VolumeMapperComputeGradientsProgressEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The VolumeMapperComputeGradientsStartEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.VolumeMapperComputeGradientsStartEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000079 RID: 121
		// (add) Token: 0x0600016F RID: 367 RVA: 0x00006E54 File Offset: 0x00005054
		// (remove) Token: 0x06000170 RID: 368 RVA: 0x00006EA0 File Offset: 0x000050A0
		public event vtkObject.vtkObjectEventHandler VolumeMapperComputeGradientsStartEvt
		{
			add
			{
				if (null == this.VolumeMapperComputeGradientsStartEvtRelay)
				{
					this.VolumeMapperComputeGradientsStartEvtRelay = new vtkObjectEventRelay(this, 66U);
				}
				if (null != this.VolumeMapperComputeGradientsStartEvtRelay)
				{
					this.VolumeMapperComputeGradientsStartEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.VolumeMapperComputeGradientsStartEvtRelay)
				{
					this.VolumeMapperComputeGradientsStartEvtRelay.RemoveHandler(value);
					if (!this.VolumeMapperComputeGradientsStartEvtRelay.HasHandlers())
					{
						this.VolumeMapperComputeGradientsStartEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The VolumeMapperRenderEndEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.VolumeMapperRenderEndEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400007A RID: 122
		// (add) Token: 0x06000171 RID: 369 RVA: 0x00006EE4 File Offset: 0x000050E4
		// (remove) Token: 0x06000172 RID: 370 RVA: 0x00006F30 File Offset: 0x00005130
		public event vtkObject.vtkObjectEventHandler VolumeMapperRenderEndEvt
		{
			add
			{
				if (null == this.VolumeMapperRenderEndEvtRelay)
				{
					this.VolumeMapperRenderEndEvtRelay = new vtkObjectEventRelay(this, 61U);
				}
				if (null != this.VolumeMapperRenderEndEvtRelay)
				{
					this.VolumeMapperRenderEndEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.VolumeMapperRenderEndEvtRelay)
				{
					this.VolumeMapperRenderEndEvtRelay.RemoveHandler(value);
					if (!this.VolumeMapperRenderEndEvtRelay.HasHandlers())
					{
						this.VolumeMapperRenderEndEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The VolumeMapperRenderProgressEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.VolumeMapperRenderProgressEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400007B RID: 123
		// (add) Token: 0x06000173 RID: 371 RVA: 0x00006F74 File Offset: 0x00005174
		// (remove) Token: 0x06000174 RID: 372 RVA: 0x00006FC0 File Offset: 0x000051C0
		public event vtkObject.vtkObjectEventHandler VolumeMapperRenderProgressEvt
		{
			add
			{
				if (null == this.VolumeMapperRenderProgressEvtRelay)
				{
					this.VolumeMapperRenderProgressEvtRelay = new vtkObjectEventRelay(this, 62U);
				}
				if (null != this.VolumeMapperRenderProgressEvtRelay)
				{
					this.VolumeMapperRenderProgressEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.VolumeMapperRenderProgressEvtRelay)
				{
					this.VolumeMapperRenderProgressEvtRelay.RemoveHandler(value);
					if (!this.VolumeMapperRenderProgressEvtRelay.HasHandlers())
					{
						this.VolumeMapperRenderProgressEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The VolumeMapperRenderStartEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.VolumeMapperRenderStartEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400007C RID: 124
		// (add) Token: 0x06000175 RID: 373 RVA: 0x00007004 File Offset: 0x00005204
		// (remove) Token: 0x06000176 RID: 374 RVA: 0x00007050 File Offset: 0x00005250
		public event vtkObject.vtkObjectEventHandler VolumeMapperRenderStartEvt
		{
			add
			{
				if (null == this.VolumeMapperRenderStartEvtRelay)
				{
					this.VolumeMapperRenderStartEvtRelay = new vtkObjectEventRelay(this, 63U);
				}
				if (null != this.VolumeMapperRenderStartEvtRelay)
				{
					this.VolumeMapperRenderStartEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.VolumeMapperRenderStartEvtRelay)
				{
					this.VolumeMapperRenderStartEvtRelay.RemoveHandler(value);
					if (!this.VolumeMapperRenderStartEvtRelay.HasHandlers())
					{
						this.VolumeMapperRenderStartEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The WarningEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.WarningEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400007D RID: 125
		// (add) Token: 0x06000177 RID: 375 RVA: 0x00007094 File Offset: 0x00005294
		// (remove) Token: 0x06000178 RID: 376 RVA: 0x000070E0 File Offset: 0x000052E0
		public event vtkObject.vtkObjectEventHandler WarningEvt
		{
			add
			{
				if (null == this.WarningEvtRelay)
				{
					this.WarningEvtRelay = new vtkObjectEventRelay(this, 40U);
				}
				if (null != this.WarningEvtRelay)
				{
					this.WarningEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.WarningEvtRelay)
				{
					this.WarningEvtRelay.RemoveHandler(value);
					if (!this.WarningEvtRelay.HasHandlers())
					{
						this.WarningEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The WidgetActivateEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.WidgetActivateEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400007E RID: 126
		// (add) Token: 0x06000179 RID: 377 RVA: 0x00007124 File Offset: 0x00005324
		// (remove) Token: 0x0600017A RID: 378 RVA: 0x00007170 File Offset: 0x00005370
		public event vtkObject.vtkObjectEventHandler WidgetActivateEvt
		{
			add
			{
				if (null == this.WidgetActivateEvtRelay)
				{
					this.WidgetActivateEvtRelay = new vtkObjectEventRelay(this, 69U);
				}
				if (null != this.WidgetActivateEvtRelay)
				{
					this.WidgetActivateEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.WidgetActivateEvtRelay)
				{
					this.WidgetActivateEvtRelay.RemoveHandler(value);
					if (!this.WidgetActivateEvtRelay.HasHandlers())
					{
						this.WidgetActivateEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The WidgetModifiedEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.WidgetModifiedEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x1400007F RID: 127
		// (add) Token: 0x0600017B RID: 379 RVA: 0x000071B4 File Offset: 0x000053B4
		// (remove) Token: 0x0600017C RID: 380 RVA: 0x00007200 File Offset: 0x00005400
		public event vtkObject.vtkObjectEventHandler WidgetModifiedEvt
		{
			add
			{
				if (null == this.WidgetModifiedEvtRelay)
				{
					this.WidgetModifiedEvtRelay = new vtkObjectEventRelay(this, 67U);
				}
				if (null != this.WidgetModifiedEvtRelay)
				{
					this.WidgetModifiedEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.WidgetModifiedEvtRelay)
				{
					this.WidgetModifiedEvtRelay.RemoveHandler(value);
					if (!this.WidgetModifiedEvtRelay.HasHandlers())
					{
						this.WidgetModifiedEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The WidgetValueChangedEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.WidgetValueChangedEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000080 RID: 128
		// (add) Token: 0x0600017D RID: 381 RVA: 0x00007244 File Offset: 0x00005444
		// (remove) Token: 0x0600017E RID: 382 RVA: 0x00007290 File Offset: 0x00005490
		public event vtkObject.vtkObjectEventHandler WidgetValueChangedEvt
		{
			add
			{
				if (null == this.WidgetValueChangedEvtRelay)
				{
					this.WidgetValueChangedEvtRelay = new vtkObjectEventRelay(this, 68U);
				}
				if (null != this.WidgetValueChangedEvtRelay)
				{
					this.WidgetValueChangedEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.WidgetValueChangedEvtRelay)
				{
					this.WidgetValueChangedEvtRelay.RemoveHandler(value);
					if (!this.WidgetValueChangedEvtRelay.HasHandlers())
					{
						this.WidgetValueChangedEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The WindowFrameEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.WindowFrameEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000081 RID: 129
		// (add) Token: 0x0600017F RID: 383 RVA: 0x000072D4 File Offset: 0x000054D4
		// (remove) Token: 0x06000180 RID: 384 RVA: 0x00007320 File Offset: 0x00005520
		public event vtkObject.vtkObjectEventHandler WindowFrameEvt
		{
			add
			{
				if (null == this.WindowFrameEvtRelay)
				{
					this.WindowFrameEvtRelay = new vtkObjectEventRelay(this, 94U);
				}
				if (null != this.WindowFrameEvtRelay)
				{
					this.WindowFrameEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.WindowFrameEvtRelay)
				{
					this.WindowFrameEvtRelay.RemoveHandler(value);
					if (!this.WindowFrameEvtRelay.HasHandlers())
					{
						this.WindowFrameEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The WindowIsCurrentEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.WindowIsCurrentEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000082 RID: 130
		// (add) Token: 0x06000181 RID: 385 RVA: 0x00007364 File Offset: 0x00005564
		// (remove) Token: 0x06000182 RID: 386 RVA: 0x000073B0 File Offset: 0x000055B0
		public event vtkObject.vtkObjectEventHandler WindowIsCurrentEvt
		{
			add
			{
				if (null == this.WindowIsCurrentEvtRelay)
				{
					this.WindowIsCurrentEvtRelay = new vtkObjectEventRelay(this, 93U);
				}
				if (null != this.WindowIsCurrentEvtRelay)
				{
					this.WindowIsCurrentEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.WindowIsCurrentEvtRelay)
				{
					this.WindowIsCurrentEvtRelay.RemoveHandler(value);
					if (!this.WindowIsCurrentEvtRelay.HasHandlers())
					{
						this.WindowIsCurrentEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The WindowIsDirectEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.WindowIsDirectEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000083 RID: 131
		// (add) Token: 0x06000183 RID: 387 RVA: 0x000073F4 File Offset: 0x000055F4
		// (remove) Token: 0x06000184 RID: 388 RVA: 0x00007440 File Offset: 0x00005640
		public event vtkObject.vtkObjectEventHandler WindowIsDirectEvt
		{
			add
			{
				if (null == this.WindowIsDirectEvtRelay)
				{
					this.WindowIsDirectEvtRelay = new vtkObjectEventRelay(this, 97U);
				}
				if (null != this.WindowIsDirectEvtRelay)
				{
					this.WindowIsDirectEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.WindowIsDirectEvtRelay)
				{
					this.WindowIsDirectEvtRelay.RemoveHandler(value);
					if (!this.WindowIsDirectEvtRelay.HasHandlers())
					{
						this.WindowIsDirectEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The WindowLevelEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.WindowLevelEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000084 RID: 132
		// (add) Token: 0x06000185 RID: 389 RVA: 0x00007484 File Offset: 0x00005684
		// (remove) Token: 0x06000186 RID: 390 RVA: 0x000074D0 File Offset: 0x000056D0
		public event vtkObject.vtkObjectEventHandler WindowLevelEvt
		{
			add
			{
				if (null == this.WindowLevelEvtRelay)
				{
					this.WindowLevelEvtRelay = new vtkObjectEventRelay(this, 34U);
				}
				if (null != this.WindowLevelEvtRelay)
				{
					this.WindowLevelEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.WindowLevelEvtRelay)
				{
					this.WindowLevelEvtRelay.RemoveHandler(value);
					if (!this.WindowLevelEvtRelay.HasHandlers())
					{
						this.WindowLevelEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The WindowMakeCurrentEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.WindowMakeCurrentEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000085 RID: 133
		// (add) Token: 0x06000187 RID: 391 RVA: 0x00007514 File Offset: 0x00005714
		// (remove) Token: 0x06000188 RID: 392 RVA: 0x00007560 File Offset: 0x00005760
		public event vtkObject.vtkObjectEventHandler WindowMakeCurrentEvt
		{
			add
			{
				if (null == this.WindowMakeCurrentEvtRelay)
				{
					this.WindowMakeCurrentEvtRelay = new vtkObjectEventRelay(this, 92U);
				}
				if (null != this.WindowMakeCurrentEvtRelay)
				{
					this.WindowMakeCurrentEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.WindowMakeCurrentEvtRelay)
				{
					this.WindowMakeCurrentEvtRelay.RemoveHandler(value);
					if (!this.WindowMakeCurrentEvtRelay.HasHandlers())
					{
						this.WindowMakeCurrentEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The WindowResizeEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.WindowResizeEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000086 RID: 134
		// (add) Token: 0x06000189 RID: 393 RVA: 0x000075A4 File Offset: 0x000057A4
		// (remove) Token: 0x0600018A RID: 394 RVA: 0x000075F0 File Offset: 0x000057F0
		public event vtkObject.vtkObjectEventHandler WindowResizeEvt
		{
			add
			{
				if (null == this.WindowResizeEvtRelay)
				{
					this.WindowResizeEvtRelay = new vtkObjectEventRelay(this, 99U);
				}
				if (null != this.WindowResizeEvtRelay)
				{
					this.WindowResizeEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.WindowResizeEvtRelay)
				{
					this.WindowResizeEvtRelay.RemoveHandler(value);
					if (!this.WindowResizeEvtRelay.HasHandlers())
					{
						this.WindowResizeEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The WindowStereoTypeChangedEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.WindowStereoTypeChangedEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000087 RID: 135
		// (add) Token: 0x0600018B RID: 395 RVA: 0x00007634 File Offset: 0x00005834
		// (remove) Token: 0x0600018C RID: 396 RVA: 0x00007680 File Offset: 0x00005880
		public event vtkObject.vtkObjectEventHandler WindowStereoTypeChangedEvt
		{
			add
			{
				if (null == this.WindowStereoTypeChangedEvtRelay)
				{
					this.WindowStereoTypeChangedEvtRelay = new vtkObjectEventRelay(this, 98U);
				}
				if (null != this.WindowStereoTypeChangedEvtRelay)
				{
					this.WindowStereoTypeChangedEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.WindowStereoTypeChangedEvtRelay)
				{
					this.WindowStereoTypeChangedEvtRelay.RemoveHandler(value);
					if (!this.WindowStereoTypeChangedEvtRelay.HasHandlers())
					{
						this.WindowStereoTypeChangedEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The WindowSupportsOpenGLEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.WindowSupportsOpenGLEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000088 RID: 136
		// (add) Token: 0x0600018D RID: 397 RVA: 0x000076C4 File Offset: 0x000058C4
		// (remove) Token: 0x0600018E RID: 398 RVA: 0x00007710 File Offset: 0x00005910
		public event vtkObject.vtkObjectEventHandler WindowSupportsOpenGLEvt
		{
			add
			{
				if (null == this.WindowSupportsOpenGLEvtRelay)
				{
					this.WindowSupportsOpenGLEvtRelay = new vtkObjectEventRelay(this, 96U);
				}
				if (null != this.WindowSupportsOpenGLEvtRelay)
				{
					this.WindowSupportsOpenGLEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.WindowSupportsOpenGLEvtRelay)
				{
					this.WindowSupportsOpenGLEvtRelay.RemoveHandler(value);
					if (!this.WindowSupportsOpenGLEvtRelay.HasHandlers())
					{
						this.WindowSupportsOpenGLEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// The WrongTagEvt event is invoked when the sender's InvokeEvent method
		/// is called with vtkCommand.EventIds.WrongTagEvent
		/// as the eventId parameter.
		/// </summary>
		// Token: 0x14000089 RID: 137
		// (add) Token: 0x0600018F RID: 399 RVA: 0x00007754 File Offset: 0x00005954
		// (remove) Token: 0x06000190 RID: 400 RVA: 0x000077A0 File Offset: 0x000059A0
		public event vtkObject.vtkObjectEventHandler WrongTagEvt
		{
			add
			{
				if (null == this.WrongTagEvtRelay)
				{
					this.WrongTagEvtRelay = new vtkObjectEventRelay(this, 56U);
				}
				if (null != this.WrongTagEvtRelay)
				{
					this.WrongTagEvtRelay.AddHandler(value);
				}
			}
			remove
			{
				if (null != this.WrongTagEvtRelay)
				{
					this.WrongTagEvtRelay.RemoveHandler(value);
					if (!this.WrongTagEvtRelay.HasHandlers())
					{
						this.WrongTagEvtRelay = null;
					}
				}
			}
		}

		/// <summary>
		/// Call RemoveAllHandlers on each non-null vtkObjectEventRelay.
		/// TODO: This method needs to get called by the generated Dispose.
		/// Make that happen...
		/// </summary>
		// Token: 0x06000191 RID: 401 RVA: 0x000077E4 File Offset: 0x000059E4
		public void RemoveAllHandlersForAllEvents()
		{
			if (null != this.AbortCheckEvtRelay)
			{
				this.AbortCheckEvtRelay.RemoveAllHandlers();
				this.AbortCheckEvtRelay = null;
			}
			if (null != this.ActiveCameraEvtRelay)
			{
				this.ActiveCameraEvtRelay.RemoveAllHandlers();
				this.ActiveCameraEvtRelay = null;
			}
			if (null != this.AnimationCueTickEvtRelay)
			{
				this.AnimationCueTickEvtRelay.RemoveAllHandlers();
				this.AnimationCueTickEvtRelay = null;
			}
			if (null != this.AnnotationChangedEvtRelay)
			{
				this.AnnotationChangedEvtRelay.RemoveAllHandlers();
				this.AnnotationChangedEvtRelay = null;
			}
			if (null != this.AnyEvtRelay)
			{
				this.AnyEvtRelay.RemoveAllHandlers();
				this.AnyEvtRelay = null;
			}
			if (null != this.Button3DEvtRelay)
			{
				this.Button3DEvtRelay.RemoveAllHandlers();
				this.Button3DEvtRelay = null;
			}
			if (null != this.CharEvtRelay)
			{
				this.CharEvtRelay.RemoveAllHandlers();
				this.CharEvtRelay = null;
			}
			if (null != this.Clip3DEvtRelay)
			{
				this.Clip3DEvtRelay.RemoveAllHandlers();
				this.Clip3DEvtRelay = null;
			}
			if (null != this.ComputeVisiblePropBoundsEvtRelay)
			{
				this.ComputeVisiblePropBoundsEvtRelay.RemoveAllHandlers();
				this.ComputeVisiblePropBoundsEvtRelay = null;
			}
			if (null != this.ConfigureEvtRelay)
			{
				this.ConfigureEvtRelay.RemoveAllHandlers();
				this.ConfigureEvtRelay = null;
			}
			if (null != this.ConnectionClosedEvtRelay)
			{
				this.ConnectionClosedEvtRelay.RemoveAllHandlers();
				this.ConnectionClosedEvtRelay = null;
			}
			if (null != this.ConnectionCreatedEvtRelay)
			{
				this.ConnectionCreatedEvtRelay.RemoveAllHandlers();
				this.ConnectionCreatedEvtRelay = null;
			}
			if (null != this.CreateCameraEvtRelay)
			{
				this.CreateCameraEvtRelay.RemoveAllHandlers();
				this.CreateCameraEvtRelay = null;
			}
			if (null != this.CreateTimerEvtRelay)
			{
				this.CreateTimerEvtRelay.RemoveAllHandlers();
				this.CreateTimerEvtRelay = null;
			}
			if (null != this.CurrentChangedEvtRelay)
			{
				this.CurrentChangedEvtRelay.RemoveAllHandlers();
				this.CurrentChangedEvtRelay = null;
			}
			if (null != this.CursorChangedEvtRelay)
			{
				this.CursorChangedEvtRelay.RemoveAllHandlers();
				this.CursorChangedEvtRelay = null;
			}
			if (null != this.DeleteEvtRelay)
			{
				this.DeleteEvtRelay.RemoveAllHandlers();
				this.DeleteEvtRelay = null;
			}
			if (null != this.DeletePointEvtRelay)
			{
				this.DeletePointEvtRelay.RemoveAllHandlers();
				this.DeletePointEvtRelay = null;
			}
			if (null != this.DestroyTimerEvtRelay)
			{
				this.DestroyTimerEvtRelay.RemoveAllHandlers();
				this.DestroyTimerEvtRelay = null;
			}
			if (null != this.DisableEvtRelay)
			{
				this.DisableEvtRelay.RemoveAllHandlers();
				this.DisableEvtRelay = null;
			}
			if (null != this.DomainModifiedEvtRelay)
			{
				this.DomainModifiedEvtRelay.RemoveAllHandlers();
				this.DomainModifiedEvtRelay = null;
			}
			if (null != this.DropFilesEvtRelay)
			{
				this.DropFilesEvtRelay.RemoveAllHandlers();
				this.DropFilesEvtRelay = null;
			}
			if (null != this.EnableEvtRelay)
			{
				this.EnableEvtRelay.RemoveAllHandlers();
				this.EnableEvtRelay = null;
			}
			if (null != this.EndEvtRelay)
			{
				this.EndEvtRelay.RemoveAllHandlers();
				this.EndEvtRelay = null;
			}
			if (null != this.EndAnimationCueEvtRelay)
			{
				this.EndAnimationCueEvtRelay.RemoveAllHandlers();
				this.EndAnimationCueEvtRelay = null;
			}
			if (null != this.EndInteractionEvtRelay)
			{
				this.EndInteractionEvtRelay.RemoveAllHandlers();
				this.EndInteractionEvtRelay = null;
			}
			if (null != this.EndPanEvtRelay)
			{
				this.EndPanEvtRelay.RemoveAllHandlers();
				this.EndPanEvtRelay = null;
			}
			if (null != this.EndPickEvtRelay)
			{
				this.EndPickEvtRelay.RemoveAllHandlers();
				this.EndPickEvtRelay = null;
			}
			if (null != this.EndPinchEvtRelay)
			{
				this.EndPinchEvtRelay.RemoveAllHandlers();
				this.EndPinchEvtRelay = null;
			}
			if (null != this.EndRotateEvtRelay)
			{
				this.EndRotateEvtRelay.RemoveAllHandlers();
				this.EndRotateEvtRelay = null;
			}
			if (null != this.EndSwipeEvtRelay)
			{
				this.EndSwipeEvtRelay.RemoveAllHandlers();
				this.EndSwipeEvtRelay = null;
			}
			if (null != this.EndWindowLevelEvtRelay)
			{
				this.EndWindowLevelEvtRelay.RemoveAllHandlers();
				this.EndWindowLevelEvtRelay = null;
			}
			if (null != this.EnterEvtRelay)
			{
				this.EnterEvtRelay.RemoveAllHandlers();
				this.EnterEvtRelay = null;
			}
			if (null != this.ErrorEvtRelay)
			{
				this.ErrorEvtRelay.RemoveAllHandlers();
				this.ErrorEvtRelay = null;
			}
			if (null != this.ExecuteInformationEvtRelay)
			{
				this.ExecuteInformationEvtRelay.RemoveAllHandlers();
				this.ExecuteInformationEvtRelay = null;
			}
			if (null != this.ExitEvtRelay)
			{
				this.ExitEvtRelay.RemoveAllHandlers();
				this.ExitEvtRelay = null;
			}
			if (null != this.ExposeEvtRelay)
			{
				this.ExposeEvtRelay.RemoveAllHandlers();
				this.ExposeEvtRelay = null;
			}
			if (null != this.FifthButtonPressEvtRelay)
			{
				this.FifthButtonPressEvtRelay.RemoveAllHandlers();
				this.FifthButtonPressEvtRelay = null;
			}
			if (null != this.FifthButtonReleaseEvtRelay)
			{
				this.FifthButtonReleaseEvtRelay.RemoveAllHandlers();
				this.FifthButtonReleaseEvtRelay = null;
			}
			if (null != this.FourthButtonPressEvtRelay)
			{
				this.FourthButtonPressEvtRelay.RemoveAllHandlers();
				this.FourthButtonPressEvtRelay = null;
			}
			if (null != this.FourthButtonReleaseEvtRelay)
			{
				this.FourthButtonReleaseEvtRelay.RemoveAllHandlers();
				this.FourthButtonReleaseEvtRelay = null;
			}
			if (null != this.HighlightEvtRelay)
			{
				this.HighlightEvtRelay.RemoveAllHandlers();
				this.HighlightEvtRelay = null;
			}
			if (null != this.HoverEvtRelay)
			{
				this.HoverEvtRelay.RemoveAllHandlers();
				this.HoverEvtRelay = null;
			}
			if (null != this.InteractionEvtRelay)
			{
				this.InteractionEvtRelay.RemoveAllHandlers();
				this.InteractionEvtRelay = null;
			}
			if (null != this.KeyPressEvtRelay)
			{
				this.KeyPressEvtRelay.RemoveAllHandlers();
				this.KeyPressEvtRelay = null;
			}
			if (null != this.KeyReleaseEvtRelay)
			{
				this.KeyReleaseEvtRelay.RemoveAllHandlers();
				this.KeyReleaseEvtRelay = null;
			}
			if (null != this.LeaveEvtRelay)
			{
				this.LeaveEvtRelay.RemoveAllHandlers();
				this.LeaveEvtRelay = null;
			}
			if (null != this.LeftButtonDoubleClickEvtRelay)
			{
				this.LeftButtonDoubleClickEvtRelay.RemoveAllHandlers();
				this.LeftButtonDoubleClickEvtRelay = null;
			}
			if (null != this.LeftButtonPressEvtRelay)
			{
				this.LeftButtonPressEvtRelay.RemoveAllHandlers();
				this.LeftButtonPressEvtRelay = null;
			}
			if (null != this.LeftButtonReleaseEvtRelay)
			{
				this.LeftButtonReleaseEvtRelay.RemoveAllHandlers();
				this.LeftButtonReleaseEvtRelay = null;
			}
			if (null != this.LoadStateEvtRelay)
			{
				this.LoadStateEvtRelay.RemoveAllHandlers();
				this.LoadStateEvtRelay = null;
			}
			if (null != this.LongTapEvtRelay)
			{
				this.LongTapEvtRelay.RemoveAllHandlers();
				this.LongTapEvtRelay = null;
			}
			if (null != this.Menu3DEvtRelay)
			{
				this.Menu3DEvtRelay.RemoveAllHandlers();
				this.Menu3DEvtRelay = null;
			}
			if (null != this.MessageEvtRelay)
			{
				this.MessageEvtRelay.RemoveAllHandlers();
				this.MessageEvtRelay = null;
			}
			if (null != this.MiddleButtonDoubleClickEvtRelay)
			{
				this.MiddleButtonDoubleClickEvtRelay.RemoveAllHandlers();
				this.MiddleButtonDoubleClickEvtRelay = null;
			}
			if (null != this.MiddleButtonPressEvtRelay)
			{
				this.MiddleButtonPressEvtRelay.RemoveAllHandlers();
				this.MiddleButtonPressEvtRelay = null;
			}
			if (null != this.MiddleButtonReleaseEvtRelay)
			{
				this.MiddleButtonReleaseEvtRelay.RemoveAllHandlers();
				this.MiddleButtonReleaseEvtRelay = null;
			}
			if (null != this.ModifiedEvtRelay)
			{
				this.ModifiedEvtRelay.RemoveAllHandlers();
				this.ModifiedEvtRelay = null;
			}
			if (null != this.MouseMoveEvtRelay)
			{
				this.MouseMoveEvtRelay.RemoveAllHandlers();
				this.MouseMoveEvtRelay = null;
			}
			if (null != this.MouseWheelBackwardEvtRelay)
			{
				this.MouseWheelBackwardEvtRelay.RemoveAllHandlers();
				this.MouseWheelBackwardEvtRelay = null;
			}
			if (null != this.MouseWheelForwardEvtRelay)
			{
				this.MouseWheelForwardEvtRelay.RemoveAllHandlers();
				this.MouseWheelForwardEvtRelay = null;
			}
			if (null != this.MouseWheelLeftEvtRelay)
			{
				this.MouseWheelLeftEvtRelay.RemoveAllHandlers();
				this.MouseWheelLeftEvtRelay = null;
			}
			if (null != this.MouseWheelRightEvtRelay)
			{
				this.MouseWheelRightEvtRelay.RemoveAllHandlers();
				this.MouseWheelRightEvtRelay = null;
			}
			if (null != this.Move3DEvtRelay)
			{
				this.Move3DEvtRelay.RemoveAllHandlers();
				this.Move3DEvtRelay = null;
			}
			if (null != this.NextPose3DEvtRelay)
			{
				this.NextPose3DEvtRelay.RemoveAllHandlers();
				this.NextPose3DEvtRelay = null;
			}
			if (null != this.NoEvtRelay)
			{
				this.NoEvtRelay.RemoveAllHandlers();
				this.NoEvtRelay = null;
			}
			if (null != this.PanEvtRelay)
			{
				this.PanEvtRelay.RemoveAllHandlers();
				this.PanEvtRelay = null;
			}
			if (null != this.PickEvtRelay)
			{
				this.PickEvtRelay.RemoveAllHandlers();
				this.PickEvtRelay = null;
			}
			if (null != this.Pick3DEvtRelay)
			{
				this.Pick3DEvtRelay.RemoveAllHandlers();
				this.Pick3DEvtRelay = null;
			}
			if (null != this.PinchEvtRelay)
			{
				this.PinchEvtRelay.RemoveAllHandlers();
				this.PinchEvtRelay = null;
			}
			if (null != this.PlacePointEvtRelay)
			{
				this.PlacePointEvtRelay.RemoveAllHandlers();
				this.PlacePointEvtRelay = null;
			}
			if (null != this.PlaceWidgetEvtRelay)
			{
				this.PlaceWidgetEvtRelay.RemoveAllHandlers();
				this.PlaceWidgetEvtRelay = null;
			}
			if (null != this.PositionProp3DEvtRelay)
			{
				this.PositionProp3DEvtRelay.RemoveAllHandlers();
				this.PositionProp3DEvtRelay = null;
			}
			if (null != this.ProgressEvtRelay)
			{
				this.ProgressEvtRelay.RemoveAllHandlers();
				this.ProgressEvtRelay = null;
			}
			if (null != this.PropertyModifiedEvtRelay)
			{
				this.PropertyModifiedEvtRelay.RemoveAllHandlers();
				this.PropertyModifiedEvtRelay = null;
			}
			if (null != this.RegisterEvtRelay)
			{
				this.RegisterEvtRelay.RemoveAllHandlers();
				this.RegisterEvtRelay = null;
			}
			if (null != this.RenderEvtRelay)
			{
				this.RenderEvtRelay.RemoveAllHandlers();
				this.RenderEvtRelay = null;
			}
			if (null != this.RenderWindowMessageEvtRelay)
			{
				this.RenderWindowMessageEvtRelay.RemoveAllHandlers();
				this.RenderWindowMessageEvtRelay = null;
			}
			if (null != this.ResetCameraEvtRelay)
			{
				this.ResetCameraEvtRelay.RemoveAllHandlers();
				this.ResetCameraEvtRelay = null;
			}
			if (null != this.ResetCameraClippingRangeEvtRelay)
			{
				this.ResetCameraClippingRangeEvtRelay.RemoveAllHandlers();
				this.ResetCameraClippingRangeEvtRelay = null;
			}
			if (null != this.ResetWindowLevelEvtRelay)
			{
				this.ResetWindowLevelEvtRelay.RemoveAllHandlers();
				this.ResetWindowLevelEvtRelay = null;
			}
			if (null != this.ResliceAxesChangedEvtRelay)
			{
				this.ResliceAxesChangedEvtRelay.RemoveAllHandlers();
				this.ResliceAxesChangedEvtRelay = null;
			}
			if (null != this.RightButtonDoubleClickEvtRelay)
			{
				this.RightButtonDoubleClickEvtRelay.RemoveAllHandlers();
				this.RightButtonDoubleClickEvtRelay = null;
			}
			if (null != this.RightButtonPressEvtRelay)
			{
				this.RightButtonPressEvtRelay.RemoveAllHandlers();
				this.RightButtonPressEvtRelay = null;
			}
			if (null != this.RightButtonReleaseEvtRelay)
			{
				this.RightButtonReleaseEvtRelay.RemoveAllHandlers();
				this.RightButtonReleaseEvtRelay = null;
			}
			if (null != this.RotateEvtRelay)
			{
				this.RotateEvtRelay.RemoveAllHandlers();
				this.RotateEvtRelay = null;
			}
			if (null != this.SaveStateEvtRelay)
			{
				this.SaveStateEvtRelay.RemoveAllHandlers();
				this.SaveStateEvtRelay = null;
			}
			if (null != this.Select3DEvtRelay)
			{
				this.Select3DEvtRelay.RemoveAllHandlers();
				this.Select3DEvtRelay = null;
			}
			if (null != this.SelectionChangedEvtRelay)
			{
				this.SelectionChangedEvtRelay.RemoveAllHandlers();
				this.SelectionChangedEvtRelay = null;
			}
			if (null != this.SetOutputEvtRelay)
			{
				this.SetOutputEvtRelay.RemoveAllHandlers();
				this.SetOutputEvtRelay = null;
			}
			if (null != this.StartEvtRelay)
			{
				this.StartEvtRelay.RemoveAllHandlers();
				this.StartEvtRelay = null;
			}
			if (null != this.StartAnimationCueEvtRelay)
			{
				this.StartAnimationCueEvtRelay.RemoveAllHandlers();
				this.StartAnimationCueEvtRelay = null;
			}
			if (null != this.StartInteractionEvtRelay)
			{
				this.StartInteractionEvtRelay.RemoveAllHandlers();
				this.StartInteractionEvtRelay = null;
			}
			if (null != this.StartPanEvtRelay)
			{
				this.StartPanEvtRelay.RemoveAllHandlers();
				this.StartPanEvtRelay = null;
			}
			if (null != this.StartPickEvtRelay)
			{
				this.StartPickEvtRelay.RemoveAllHandlers();
				this.StartPickEvtRelay = null;
			}
			if (null != this.StartPinchEvtRelay)
			{
				this.StartPinchEvtRelay.RemoveAllHandlers();
				this.StartPinchEvtRelay = null;
			}
			if (null != this.StartRotateEvtRelay)
			{
				this.StartRotateEvtRelay.RemoveAllHandlers();
				this.StartRotateEvtRelay = null;
			}
			if (null != this.StartSwipeEvtRelay)
			{
				this.StartSwipeEvtRelay.RemoveAllHandlers();
				this.StartSwipeEvtRelay = null;
			}
			if (null != this.StartWindowLevelEvtRelay)
			{
				this.StartWindowLevelEvtRelay.RemoveAllHandlers();
				this.StartWindowLevelEvtRelay = null;
			}
			if (null != this.StateChangedEvtRelay)
			{
				this.StateChangedEvtRelay.RemoveAllHandlers();
				this.StateChangedEvtRelay = null;
			}
			if (null != this.SwipeEvtRelay)
			{
				this.SwipeEvtRelay.RemoveAllHandlers();
				this.SwipeEvtRelay = null;
			}
			if (null != this.TapEvtRelay)
			{
				this.TapEvtRelay.RemoveAllHandlers();
				this.TapEvtRelay = null;
			}
			if (null != this.TDxButtonPressEvtRelay)
			{
				this.TDxButtonPressEvtRelay.RemoveAllHandlers();
				this.TDxButtonPressEvtRelay = null;
			}
			if (null != this.TDxButtonReleaseEvtRelay)
			{
				this.TDxButtonReleaseEvtRelay.RemoveAllHandlers();
				this.TDxButtonReleaseEvtRelay = null;
			}
			if (null != this.TDxMotionEvtRelay)
			{
				this.TDxMotionEvtRelay.RemoveAllHandlers();
				this.TDxMotionEvtRelay = null;
			}
			if (null != this.TextEvtRelay)
			{
				this.TextEvtRelay.RemoveAllHandlers();
				this.TextEvtRelay = null;
			}
			if (null != this.TimerEvtRelay)
			{
				this.TimerEvtRelay.RemoveAllHandlers();
				this.TimerEvtRelay = null;
			}
			if (null != this.UncheckedPropertyModifiedEvtRelay)
			{
				this.UncheckedPropertyModifiedEvtRelay.RemoveAllHandlers();
				this.UncheckedPropertyModifiedEvtRelay = null;
			}
			if (null != this.UnRegisterEvtRelay)
			{
				this.UnRegisterEvtRelay.RemoveAllHandlers();
				this.UnRegisterEvtRelay = null;
			}
			if (null != this.UpdateEvtRelay)
			{
				this.UpdateEvtRelay.RemoveAllHandlers();
				this.UpdateEvtRelay = null;
			}
			if (null != this.UpdateDataEvtRelay)
			{
				this.UpdateDataEvtRelay.RemoveAllHandlers();
				this.UpdateDataEvtRelay = null;
			}
			if (null != this.UpdateDropLocationEvtRelay)
			{
				this.UpdateDropLocationEvtRelay.RemoveAllHandlers();
				this.UpdateDropLocationEvtRelay = null;
			}
			if (null != this.UpdateInformationEvtRelay)
			{
				this.UpdateInformationEvtRelay.RemoveAllHandlers();
				this.UpdateInformationEvtRelay = null;
			}
			if (null != this.UpdatePropertyEvtRelay)
			{
				this.UpdatePropertyEvtRelay.RemoveAllHandlers();
				this.UpdatePropertyEvtRelay = null;
			}
			if (null != this.UpdateShaderEvtRelay)
			{
				this.UpdateShaderEvtRelay.RemoveAllHandlers();
				this.UpdateShaderEvtRelay = null;
			}
			if (null != this.UserEvtRelay)
			{
				this.UserEvtRelay.RemoveAllHandlers();
				this.UserEvtRelay = null;
			}
			if (null != this.ViewerMovement3DEvtRelay)
			{
				this.ViewerMovement3DEvtRelay.RemoveAllHandlers();
				this.ViewerMovement3DEvtRelay = null;
			}
			if (null != this.ViewProgressEvtRelay)
			{
				this.ViewProgressEvtRelay.RemoveAllHandlers();
				this.ViewProgressEvtRelay = null;
			}
			if (null != this.VolumeMapperComputeGradientsEndEvtRelay)
			{
				this.VolumeMapperComputeGradientsEndEvtRelay.RemoveAllHandlers();
				this.VolumeMapperComputeGradientsEndEvtRelay = null;
			}
			if (null != this.VolumeMapperComputeGradientsProgressEvtRelay)
			{
				this.VolumeMapperComputeGradientsProgressEvtRelay.RemoveAllHandlers();
				this.VolumeMapperComputeGradientsProgressEvtRelay = null;
			}
			if (null != this.VolumeMapperComputeGradientsStartEvtRelay)
			{
				this.VolumeMapperComputeGradientsStartEvtRelay.RemoveAllHandlers();
				this.VolumeMapperComputeGradientsStartEvtRelay = null;
			}
			if (null != this.VolumeMapperRenderEndEvtRelay)
			{
				this.VolumeMapperRenderEndEvtRelay.RemoveAllHandlers();
				this.VolumeMapperRenderEndEvtRelay = null;
			}
			if (null != this.VolumeMapperRenderProgressEvtRelay)
			{
				this.VolumeMapperRenderProgressEvtRelay.RemoveAllHandlers();
				this.VolumeMapperRenderProgressEvtRelay = null;
			}
			if (null != this.VolumeMapperRenderStartEvtRelay)
			{
				this.VolumeMapperRenderStartEvtRelay.RemoveAllHandlers();
				this.VolumeMapperRenderStartEvtRelay = null;
			}
			if (null != this.WarningEvtRelay)
			{
				this.WarningEvtRelay.RemoveAllHandlers();
				this.WarningEvtRelay = null;
			}
			if (null != this.WidgetActivateEvtRelay)
			{
				this.WidgetActivateEvtRelay.RemoveAllHandlers();
				this.WidgetActivateEvtRelay = null;
			}
			if (null != this.WidgetModifiedEvtRelay)
			{
				this.WidgetModifiedEvtRelay.RemoveAllHandlers();
				this.WidgetModifiedEvtRelay = null;
			}
			if (null != this.WidgetValueChangedEvtRelay)
			{
				this.WidgetValueChangedEvtRelay.RemoveAllHandlers();
				this.WidgetValueChangedEvtRelay = null;
			}
			if (null != this.WindowFrameEvtRelay)
			{
				this.WindowFrameEvtRelay.RemoveAllHandlers();
				this.WindowFrameEvtRelay = null;
			}
			if (null != this.WindowIsCurrentEvtRelay)
			{
				this.WindowIsCurrentEvtRelay.RemoveAllHandlers();
				this.WindowIsCurrentEvtRelay = null;
			}
			if (null != this.WindowIsDirectEvtRelay)
			{
				this.WindowIsDirectEvtRelay.RemoveAllHandlers();
				this.WindowIsDirectEvtRelay = null;
			}
			if (null != this.WindowLevelEvtRelay)
			{
				this.WindowLevelEvtRelay.RemoveAllHandlers();
				this.WindowLevelEvtRelay = null;
			}
			if (null != this.WindowMakeCurrentEvtRelay)
			{
				this.WindowMakeCurrentEvtRelay.RemoveAllHandlers();
				this.WindowMakeCurrentEvtRelay = null;
			}
			if (null != this.WindowResizeEvtRelay)
			{
				this.WindowResizeEvtRelay.RemoveAllHandlers();
				this.WindowResizeEvtRelay = null;
			}
			if (null != this.WindowStereoTypeChangedEvtRelay)
			{
				this.WindowStereoTypeChangedEvtRelay.RemoveAllHandlers();
				this.WindowStereoTypeChangedEvtRelay = null;
			}
			if (null != this.WindowSupportsOpenGLEvtRelay)
			{
				this.WindowSupportsOpenGLEvtRelay.RemoveAllHandlers();
				this.WindowSupportsOpenGLEvtRelay = null;
			}
			if (null != this.WrongTagEvtRelay)
			{
				this.WrongTagEvtRelay.RemoveAllHandlers();
				this.WrongTagEvtRelay = null;
			}
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400007C RID: 124
		public new const string MRFullTypeName = "Kitware.VTK.vtkObject";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400007D RID: 125
		public new static readonly string MRClassNameKey = "class vtkObject";

		// Token: 0x0400007E RID: 126
		private vtkObjectEventRelay AbortCheckEvtRelay;

		// Token: 0x0400007F RID: 127
		private vtkObjectEventRelay ActiveCameraEvtRelay;

		// Token: 0x04000080 RID: 128
		private vtkObjectEventRelay AnimationCueTickEvtRelay;

		// Token: 0x04000081 RID: 129
		private vtkObjectEventRelay AnnotationChangedEvtRelay;

		// Token: 0x04000082 RID: 130
		private vtkObjectEventRelay AnyEvtRelay;

		// Token: 0x04000083 RID: 131
		private vtkObjectEventRelay Button3DEvtRelay;

		// Token: 0x04000084 RID: 132
		private vtkObjectEventRelay CharEvtRelay;

		// Token: 0x04000085 RID: 133
		private vtkObjectEventRelay Clip3DEvtRelay;

		// Token: 0x04000086 RID: 134
		private vtkObjectEventRelay ComputeVisiblePropBoundsEvtRelay;

		// Token: 0x04000087 RID: 135
		private vtkObjectEventRelay ConfigureEvtRelay;

		// Token: 0x04000088 RID: 136
		private vtkObjectEventRelay ConnectionClosedEvtRelay;

		// Token: 0x04000089 RID: 137
		private vtkObjectEventRelay ConnectionCreatedEvtRelay;

		// Token: 0x0400008A RID: 138
		private vtkObjectEventRelay CreateCameraEvtRelay;

		// Token: 0x0400008B RID: 139
		private vtkObjectEventRelay CreateTimerEvtRelay;

		// Token: 0x0400008C RID: 140
		private vtkObjectEventRelay CurrentChangedEvtRelay;

		// Token: 0x0400008D RID: 141
		private vtkObjectEventRelay CursorChangedEvtRelay;

		// Token: 0x0400008E RID: 142
		private vtkObjectEventRelay DeleteEvtRelay;

		// Token: 0x0400008F RID: 143
		private vtkObjectEventRelay DeletePointEvtRelay;

		// Token: 0x04000090 RID: 144
		private vtkObjectEventRelay DestroyTimerEvtRelay;

		// Token: 0x04000091 RID: 145
		private vtkObjectEventRelay DisableEvtRelay;

		// Token: 0x04000092 RID: 146
		private vtkObjectEventRelay DomainModifiedEvtRelay;

		// Token: 0x04000093 RID: 147
		private vtkObjectEventRelay DropFilesEvtRelay;

		// Token: 0x04000094 RID: 148
		private vtkObjectEventRelay EnableEvtRelay;

		// Token: 0x04000095 RID: 149
		private vtkObjectEventRelay EndEvtRelay;

		// Token: 0x04000096 RID: 150
		private vtkObjectEventRelay EndAnimationCueEvtRelay;

		// Token: 0x04000097 RID: 151
		private vtkObjectEventRelay EndInteractionEvtRelay;

		// Token: 0x04000098 RID: 152
		private vtkObjectEventRelay EndPanEvtRelay;

		// Token: 0x04000099 RID: 153
		private vtkObjectEventRelay EndPickEvtRelay;

		// Token: 0x0400009A RID: 154
		private vtkObjectEventRelay EndPinchEvtRelay;

		// Token: 0x0400009B RID: 155
		private vtkObjectEventRelay EndRotateEvtRelay;

		// Token: 0x0400009C RID: 156
		private vtkObjectEventRelay EndSwipeEvtRelay;

		// Token: 0x0400009D RID: 157
		private vtkObjectEventRelay EndWindowLevelEvtRelay;

		// Token: 0x0400009E RID: 158
		private vtkObjectEventRelay EnterEvtRelay;

		// Token: 0x0400009F RID: 159
		private vtkObjectEventRelay ErrorEvtRelay;

		// Token: 0x040000A0 RID: 160
		private vtkObjectEventRelay ExecuteInformationEvtRelay;

		// Token: 0x040000A1 RID: 161
		private vtkObjectEventRelay ExitEvtRelay;

		// Token: 0x040000A2 RID: 162
		private vtkObjectEventRelay ExposeEvtRelay;

		// Token: 0x040000A3 RID: 163
		private vtkObjectEventRelay FifthButtonPressEvtRelay;

		// Token: 0x040000A4 RID: 164
		private vtkObjectEventRelay FifthButtonReleaseEvtRelay;

		// Token: 0x040000A5 RID: 165
		private vtkObjectEventRelay FourthButtonPressEvtRelay;

		// Token: 0x040000A6 RID: 166
		private vtkObjectEventRelay FourthButtonReleaseEvtRelay;

		// Token: 0x040000A7 RID: 167
		private vtkObjectEventRelay HighlightEvtRelay;

		// Token: 0x040000A8 RID: 168
		private vtkObjectEventRelay HoverEvtRelay;

		// Token: 0x040000A9 RID: 169
		private vtkObjectEventRelay InteractionEvtRelay;

		// Token: 0x040000AA RID: 170
		private vtkObjectEventRelay KeyPressEvtRelay;

		// Token: 0x040000AB RID: 171
		private vtkObjectEventRelay KeyReleaseEvtRelay;

		// Token: 0x040000AC RID: 172
		private vtkObjectEventRelay LeaveEvtRelay;

		// Token: 0x040000AD RID: 173
		private vtkObjectEventRelay LeftButtonDoubleClickEvtRelay;

		// Token: 0x040000AE RID: 174
		private vtkObjectEventRelay LeftButtonPressEvtRelay;

		// Token: 0x040000AF RID: 175
		private vtkObjectEventRelay LeftButtonReleaseEvtRelay;

		// Token: 0x040000B0 RID: 176
		private vtkObjectEventRelay LoadStateEvtRelay;

		// Token: 0x040000B1 RID: 177
		private vtkObjectEventRelay LongTapEvtRelay;

		// Token: 0x040000B2 RID: 178
		private vtkObjectEventRelay Menu3DEvtRelay;

		// Token: 0x040000B3 RID: 179
		private vtkObjectEventRelay MessageEvtRelay;

		// Token: 0x040000B4 RID: 180
		private vtkObjectEventRelay MiddleButtonDoubleClickEvtRelay;

		// Token: 0x040000B5 RID: 181
		private vtkObjectEventRelay MiddleButtonPressEvtRelay;

		// Token: 0x040000B6 RID: 182
		private vtkObjectEventRelay MiddleButtonReleaseEvtRelay;

		// Token: 0x040000B7 RID: 183
		private vtkObjectEventRelay ModifiedEvtRelay;

		// Token: 0x040000B8 RID: 184
		private vtkObjectEventRelay MouseMoveEvtRelay;

		// Token: 0x040000B9 RID: 185
		private vtkObjectEventRelay MouseWheelBackwardEvtRelay;

		// Token: 0x040000BA RID: 186
		private vtkObjectEventRelay MouseWheelForwardEvtRelay;

		// Token: 0x040000BB RID: 187
		private vtkObjectEventRelay MouseWheelLeftEvtRelay;

		// Token: 0x040000BC RID: 188
		private vtkObjectEventRelay MouseWheelRightEvtRelay;

		// Token: 0x040000BD RID: 189
		private vtkObjectEventRelay Move3DEvtRelay;

		// Token: 0x040000BE RID: 190
		private vtkObjectEventRelay NextPose3DEvtRelay;

		// Token: 0x040000BF RID: 191
		private vtkObjectEventRelay NoEvtRelay;

		// Token: 0x040000C0 RID: 192
		private vtkObjectEventRelay PanEvtRelay;

		// Token: 0x040000C1 RID: 193
		private vtkObjectEventRelay PickEvtRelay;

		// Token: 0x040000C2 RID: 194
		private vtkObjectEventRelay Pick3DEvtRelay;

		// Token: 0x040000C3 RID: 195
		private vtkObjectEventRelay PinchEvtRelay;

		// Token: 0x040000C4 RID: 196
		private vtkObjectEventRelay PlacePointEvtRelay;

		// Token: 0x040000C5 RID: 197
		private vtkObjectEventRelay PlaceWidgetEvtRelay;

		// Token: 0x040000C6 RID: 198
		private vtkObjectEventRelay PositionProp3DEvtRelay;

		// Token: 0x040000C7 RID: 199
		private vtkObjectEventRelay ProgressEvtRelay;

		// Token: 0x040000C8 RID: 200
		private vtkObjectEventRelay PropertyModifiedEvtRelay;

		// Token: 0x040000C9 RID: 201
		private vtkObjectEventRelay RegisterEvtRelay;

		// Token: 0x040000CA RID: 202
		private vtkObjectEventRelay RenderEvtRelay;

		// Token: 0x040000CB RID: 203
		private vtkObjectEventRelay RenderWindowMessageEvtRelay;

		// Token: 0x040000CC RID: 204
		private vtkObjectEventRelay ResetCameraEvtRelay;

		// Token: 0x040000CD RID: 205
		private vtkObjectEventRelay ResetCameraClippingRangeEvtRelay;

		// Token: 0x040000CE RID: 206
		private vtkObjectEventRelay ResetWindowLevelEvtRelay;

		// Token: 0x040000CF RID: 207
		private vtkObjectEventRelay ResliceAxesChangedEvtRelay;

		// Token: 0x040000D0 RID: 208
		private vtkObjectEventRelay RightButtonDoubleClickEvtRelay;

		// Token: 0x040000D1 RID: 209
		private vtkObjectEventRelay RightButtonPressEvtRelay;

		// Token: 0x040000D2 RID: 210
		private vtkObjectEventRelay RightButtonReleaseEvtRelay;

		// Token: 0x040000D3 RID: 211
		private vtkObjectEventRelay RotateEvtRelay;

		// Token: 0x040000D4 RID: 212
		private vtkObjectEventRelay SaveStateEvtRelay;

		// Token: 0x040000D5 RID: 213
		private vtkObjectEventRelay Select3DEvtRelay;

		// Token: 0x040000D6 RID: 214
		private vtkObjectEventRelay SelectionChangedEvtRelay;

		// Token: 0x040000D7 RID: 215
		private vtkObjectEventRelay SetOutputEvtRelay;

		// Token: 0x040000D8 RID: 216
		private vtkObjectEventRelay StartEvtRelay;

		// Token: 0x040000D9 RID: 217
		private vtkObjectEventRelay StartAnimationCueEvtRelay;

		// Token: 0x040000DA RID: 218
		private vtkObjectEventRelay StartInteractionEvtRelay;

		// Token: 0x040000DB RID: 219
		private vtkObjectEventRelay StartPanEvtRelay;

		// Token: 0x040000DC RID: 220
		private vtkObjectEventRelay StartPickEvtRelay;

		// Token: 0x040000DD RID: 221
		private vtkObjectEventRelay StartPinchEvtRelay;

		// Token: 0x040000DE RID: 222
		private vtkObjectEventRelay StartRotateEvtRelay;

		// Token: 0x040000DF RID: 223
		private vtkObjectEventRelay StartSwipeEvtRelay;

		// Token: 0x040000E0 RID: 224
		private vtkObjectEventRelay StartWindowLevelEvtRelay;

		// Token: 0x040000E1 RID: 225
		private vtkObjectEventRelay StateChangedEvtRelay;

		// Token: 0x040000E2 RID: 226
		private vtkObjectEventRelay SwipeEvtRelay;

		// Token: 0x040000E3 RID: 227
		private vtkObjectEventRelay TapEvtRelay;

		// Token: 0x040000E4 RID: 228
		private vtkObjectEventRelay TDxButtonPressEvtRelay;

		// Token: 0x040000E5 RID: 229
		private vtkObjectEventRelay TDxButtonReleaseEvtRelay;

		// Token: 0x040000E6 RID: 230
		private vtkObjectEventRelay TDxMotionEvtRelay;

		// Token: 0x040000E7 RID: 231
		private vtkObjectEventRelay TextEvtRelay;

		// Token: 0x040000E8 RID: 232
		private vtkObjectEventRelay TimerEvtRelay;

		// Token: 0x040000E9 RID: 233
		private vtkObjectEventRelay UncheckedPropertyModifiedEvtRelay;

		// Token: 0x040000EA RID: 234
		private vtkObjectEventRelay UnRegisterEvtRelay;

		// Token: 0x040000EB RID: 235
		private vtkObjectEventRelay UpdateEvtRelay;

		// Token: 0x040000EC RID: 236
		private vtkObjectEventRelay UpdateDataEvtRelay;

		// Token: 0x040000ED RID: 237
		private vtkObjectEventRelay UpdateDropLocationEvtRelay;

		// Token: 0x040000EE RID: 238
		private vtkObjectEventRelay UpdateInformationEvtRelay;

		// Token: 0x040000EF RID: 239
		private vtkObjectEventRelay UpdatePropertyEvtRelay;

		// Token: 0x040000F0 RID: 240
		private vtkObjectEventRelay UpdateShaderEvtRelay;

		// Token: 0x040000F1 RID: 241
		private vtkObjectEventRelay UserEvtRelay;

		// Token: 0x040000F2 RID: 242
		private vtkObjectEventRelay ViewerMovement3DEvtRelay;

		// Token: 0x040000F3 RID: 243
		private vtkObjectEventRelay ViewProgressEvtRelay;

		// Token: 0x040000F4 RID: 244
		private vtkObjectEventRelay VolumeMapperComputeGradientsEndEvtRelay;

		// Token: 0x040000F5 RID: 245
		private vtkObjectEventRelay VolumeMapperComputeGradientsProgressEvtRelay;

		// Token: 0x040000F6 RID: 246
		private vtkObjectEventRelay VolumeMapperComputeGradientsStartEvtRelay;

		// Token: 0x040000F7 RID: 247
		private vtkObjectEventRelay VolumeMapperRenderEndEvtRelay;

		// Token: 0x040000F8 RID: 248
		private vtkObjectEventRelay VolumeMapperRenderProgressEvtRelay;

		// Token: 0x040000F9 RID: 249
		private vtkObjectEventRelay VolumeMapperRenderStartEvtRelay;

		// Token: 0x040000FA RID: 250
		private vtkObjectEventRelay WarningEvtRelay;

		// Token: 0x040000FB RID: 251
		private vtkObjectEventRelay WidgetActivateEvtRelay;

		// Token: 0x040000FC RID: 252
		private vtkObjectEventRelay WidgetModifiedEvtRelay;

		// Token: 0x040000FD RID: 253
		private vtkObjectEventRelay WidgetValueChangedEvtRelay;

		// Token: 0x040000FE RID: 254
		private vtkObjectEventRelay WindowFrameEvtRelay;

		// Token: 0x040000FF RID: 255
		private vtkObjectEventRelay WindowIsCurrentEvtRelay;

		// Token: 0x04000100 RID: 256
		private vtkObjectEventRelay WindowIsDirectEvtRelay;

		// Token: 0x04000101 RID: 257
		private vtkObjectEventRelay WindowLevelEvtRelay;

		// Token: 0x04000102 RID: 258
		private vtkObjectEventRelay WindowMakeCurrentEvtRelay;

		// Token: 0x04000103 RID: 259
		private vtkObjectEventRelay WindowResizeEvtRelay;

		// Token: 0x04000104 RID: 260
		private vtkObjectEventRelay WindowStereoTypeChangedEvtRelay;

		// Token: 0x04000105 RID: 261
		private vtkObjectEventRelay WindowSupportsOpenGLEvtRelay;

		// Token: 0x04000106 RID: 262
		private vtkObjectEventRelay WrongTagEvtRelay;

		/// <summary>
		/// Generic signature for all vtkObject events.
		/// </summary>
		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x06000193 RID: 403
		public delegate void vtkObjectEventHandler(vtkObject sender, vtkObjectEventArgs e);
	}
}
