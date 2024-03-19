using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSocketCommunicator
	/// </summary>
	/// <remarks>
	///    Process communication using Sockets
	///
	/// This is a concrete implementation of vtkCommunicator which supports
	/// interprocess communication using BSD style sockets.
	/// It supports byte swapping for the communication of machines
	/// with different endianness.
	///
	/// @warning
	/// Communication between 32 bit and 64 bit systems is not fully
	/// supported. If a type does not have the same length on both
	/// systems, this communicator can not be used to transfer data
	/// of that type.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCommunicator vtkSocketController
	/// </seealso>
	// Token: 0x020006FC RID: 1788
	public class vtkSocketCommunicator : vtkCommunicator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012D38 RID: 77112 RVA: 0x001A7FEB File Offset: 0x001A61EB
		static vtkSocketCommunicator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSocketCommunicator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSocketCommunicator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012D39 RID: 77113 RVA: 0x001A8013 File Offset: 0x001A6213
		public vtkSocketCommunicator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012D3A RID: 77114
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSocketCommunicator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012D3B RID: 77115 RVA: 0x001A8024 File Offset: 0x001A6224
		public new static vtkSocketCommunicator New()
		{
			vtkSocketCommunicator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSocketCommunicator.vtkSocketCommunicator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSocketCommunicator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012D3C RID: 77116 RVA: 0x001A8078 File Offset: 0x001A6278
		public vtkSocketCommunicator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSocketCommunicator.vtkSocketCommunicator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012D3D RID: 77117 RVA: 0x001A80BC File Offset: 0x001A62BC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012D3E RID: 77118
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCommunicator_AllGatherVVoidArray_01(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int type);

		/// <summary>
		/// This class foolishly breaks the conventions of the superclass, so the
		/// default implementations of these methods do not work.  These just give
		/// errors instead.
		/// </summary>
		// Token: 0x06012D3F RID: 77119 RVA: 0x001A80C8 File Offset: 0x001A62C8
		public override int AllGatherVVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int type)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_AllGatherVVoidArray_01(base.GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets, type);
		}

		// Token: 0x06012D40 RID: 77120
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCommunicator_AllGatherVoidArray_02(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int type);

		/// <summary>
		/// This class foolishly breaks the conventions of the superclass, so the
		/// default implementations of these methods do not work.  These just give
		/// errors instead.
		/// </summary>
		// Token: 0x06012D41 RID: 77121 RVA: 0x001A80F0 File Offset: 0x001A62F0
		public override int AllGatherVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long length, int type)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_AllGatherVoidArray_02(base.GetCppThis(), sendBuffer, recvBuffer, length, type);
		}

		// Token: 0x06012D42 RID: 77122
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCommunicator_AllReduceVoidArray_03(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int operation);

		/// <summary>
		/// This class foolishly breaks the conventions of the superclass, so the
		/// default implementations of these methods do not work.  These just give
		/// errors instead.
		/// </summary>
		// Token: 0x06012D43 RID: 77123 RVA: 0x001A8114 File Offset: 0x001A6314
		public override int AllReduceVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int operation)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_AllReduceVoidArray_03(base.GetCppThis(), sendBuffer, recvBuffer, length, type, operation);
		}

		// Token: 0x06012D44 RID: 77124
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSocketCommunicator_Barrier_04(HandleRef pThis);

		/// <summary>
		/// This class foolishly breaks the conventions of the superclass, so this
		/// overload fixes the method.
		/// </summary>
		// Token: 0x06012D45 RID: 77125 RVA: 0x001A813A File Offset: 0x001A633A
		public override void Barrier()
		{
			vtkSocketCommunicator.vtkSocketCommunicator_Barrier_04(base.GetCppThis());
		}

		// Token: 0x06012D46 RID: 77126
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCommunicator_BroadcastVoidArray_05(HandleRef pThis, IntPtr data, long length, int type, int srcProcessId);

		/// <summary>
		/// This class foolishly breaks the conventions of the superclass, so the
		/// default implementations of these methods do not work.  These just give
		/// errors instead.
		/// </summary>
		// Token: 0x06012D47 RID: 77127 RVA: 0x001A814C File Offset: 0x001A634C
		public override int BroadcastVoidArray(IntPtr data, long length, int type, int srcProcessId)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_BroadcastVoidArray_05(base.GetCppThis(), data, length, type, srcProcessId);
		}

		// Token: 0x06012D48 RID: 77128
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSocketCommunicator_BufferCurrentMessage_06(HandleRef pThis);

		/// <summary>
		/// This flag is cleared before vtkCommand::WrongTagEvent is fired when ever a
		/// message with mismatched tag is received. If the handler wants the message
		/// to be buffered for later use, it should set this flag to true. In which
		/// case the vtkSocketCommunicator will buffer the message and it will be
		/// automatically processed the next time one does a ReceiveTagged() with a
		/// matching tag.
		/// </summary>
		// Token: 0x06012D49 RID: 77129 RVA: 0x001A8170 File Offset: 0x001A6370
		public void BufferCurrentMessage()
		{
			vtkSocketCommunicator.vtkSocketCommunicator_BufferCurrentMessage_06(base.GetCppThis());
		}

		// Token: 0x06012D4A RID: 77130
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCommunicator_ClientSideHandshake_07(HandleRef pThis);

		/// <summary>
		/// Performs ClientSide handshake.
		/// One should preferably use Handshake() which calls ServerSideHandshake or
		/// ClientSideHandshake as required.
		/// </summary>
		// Token: 0x06012D4B RID: 77131 RVA: 0x001A8180 File Offset: 0x001A6380
		public int ClientSideHandshake()
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_ClientSideHandshake_07(base.GetCppThis());
		}

		// Token: 0x06012D4C RID: 77132
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSocketCommunicator_CloseConnection_08(HandleRef pThis);

		/// <summary>
		/// Close a connection.
		/// </summary>
		// Token: 0x06012D4D RID: 77133 RVA: 0x001A819F File Offset: 0x001A639F
		public virtual void CloseConnection()
		{
			vtkSocketCommunicator.vtkSocketCommunicator_CloseConnection_08(base.GetCppThis());
		}

		// Token: 0x06012D4E RID: 77134
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCommunicator_ConnectTo_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string hostName, int port);

		/// <summary>
		/// Open a connection to host.
		/// </summary>
		// Token: 0x06012D4F RID: 77135 RVA: 0x001A81B0 File Offset: 0x001A63B0
		public virtual int ConnectTo(string hostName, int port)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_ConnectTo_09(base.GetCppThis(), hostName, port);
		}

		// Token: 0x06012D50 RID: 77136
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCommunicator_GatherVVoidArray_10(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int type, int destProcessId);

		/// <summary>
		/// This class foolishly breaks the conventions of the superclass, so the
		/// default implementations of these methods do not work.  These just give
		/// errors instead.
		/// </summary>
		// Token: 0x06012D51 RID: 77137 RVA: 0x001A81D4 File Offset: 0x001A63D4
		public override int GatherVVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int type, int destProcessId)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_GatherVVoidArray_10(base.GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets, type, destProcessId);
		}

		// Token: 0x06012D52 RID: 77138
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCommunicator_GatherVoidArray_11(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int destProcessId);

		/// <summary>
		/// This class foolishly breaks the conventions of the superclass, so the
		/// default implementations of these methods do not work.  These just give
		/// errors instead.
		/// </summary>
		// Token: 0x06012D53 RID: 77139 RVA: 0x001A8200 File Offset: 0x001A6400
		public override int GatherVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int destProcessId)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_GatherVoidArray_11(base.GetCppThis(), sendBuffer, recvBuffer, length, type, destProcessId);
		}

		// Token: 0x06012D54 RID: 77140
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCommunicator_GetIsConnected_12(HandleRef pThis);

		/// <summary>
		/// Is the communicator connected?.
		/// </summary>
		// Token: 0x06012D55 RID: 77141 RVA: 0x001A8228 File Offset: 0x001A6428
		public int GetIsConnected()
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_GetIsConnected_12(base.GetCppThis());
		}

		// Token: 0x06012D56 RID: 77142
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCommunicator_GetIsServer_13(HandleRef pThis);

		/// <summary>
		/// Returns true if this side of the socket is the server.  The result
		/// is invalid if the socket is not connected.
		/// </summary>
		// Token: 0x06012D57 RID: 77143 RVA: 0x001A8248 File Offset: 0x001A6448
		public virtual int GetIsServer()
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_GetIsServer_13(base.GetCppThis());
		}

		// Token: 0x06012D58 RID: 77144
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSocketCommunicator_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012D59 RID: 77145 RVA: 0x001A8268 File Offset: 0x001A6468
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x06012D5A RID: 77146
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSocketCommunicator_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012D5B RID: 77147 RVA: 0x001A8288 File Offset: 0x001A6488
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x06012D5C RID: 77148
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCommunicator_GetPerformHandshake_16(HandleRef pThis);

		/// <summary>
		/// Set or get the PerformHandshake ivar. If it is on, the communicator
		/// will try to perform a handshake when connected.
		/// It is on by default.
		/// </summary>
		// Token: 0x06012D5D RID: 77149 RVA: 0x001A82A4 File Offset: 0x001A64A4
		public virtual int GetPerformHandshake()
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_GetPerformHandshake_16(base.GetCppThis());
		}

		// Token: 0x06012D5E RID: 77150
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCommunicator_GetPerformHandshakeMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Set or get the PerformHandshake ivar. If it is on, the communicator
		/// will try to perform a handshake when connected.
		/// It is on by default.
		/// </summary>
		// Token: 0x06012D5F RID: 77151 RVA: 0x001A82C4 File Offset: 0x001A64C4
		public virtual int GetPerformHandshakeMaxValue()
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_GetPerformHandshakeMaxValue_17(base.GetCppThis());
		}

		// Token: 0x06012D60 RID: 77152
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCommunicator_GetPerformHandshakeMinValue_18(HandleRef pThis);

		/// <summary>
		/// Set or get the PerformHandshake ivar. If it is on, the communicator
		/// will try to perform a handshake when connected.
		/// It is on by default.
		/// </summary>
		// Token: 0x06012D61 RID: 77153 RVA: 0x001A82E4 File Offset: 0x001A64E4
		public virtual int GetPerformHandshakeMinValue()
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_GetPerformHandshakeMinValue_18(base.GetCppThis());
		}

		// Token: 0x06012D62 RID: 77154
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCommunicator_GetReportErrors_19(HandleRef pThis);

		/// <summary>
		/// If ReportErrors if false, all vtkErrorMacros are suppressed.
		/// </summary>
		// Token: 0x06012D63 RID: 77155 RVA: 0x001A8304 File Offset: 0x001A6504
		public virtual int GetReportErrors()
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_GetReportErrors_19(base.GetCppThis());
		}

		// Token: 0x06012D64 RID: 77156
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSocketCommunicator_GetSocket_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the actual socket used for communication.
		/// </summary>
		// Token: 0x06012D65 RID: 77157 RVA: 0x001A8324 File Offset: 0x001A6524
		public virtual vtkClientSocket GetSocket()
		{
			vtkClientSocket vtkClientSocket = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSocketCommunicator.vtkSocketCommunicator_GetSocket_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkClientSocket = (vtkClientSocket)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkClientSocket.Register(null);
				}
			}
			return vtkClientSocket;
		}

		// Token: 0x06012D66 RID: 77158
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCommunicator_GetSwapBytesInReceivedData_21(HandleRef pThis);

		/// <summary>
		/// Returns 1 if bytes must be swapped in received ints, floats, etc
		/// </summary>
		// Token: 0x06012D67 RID: 77159 RVA: 0x001A8394 File Offset: 0x001A6594
		public virtual int GetSwapBytesInReceivedData()
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_GetSwapBytesInReceivedData_21(base.GetCppThis());
		}

		// Token: 0x06012D68 RID: 77160
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCommunicator_GetVersion_22();

		/// <summary>
		/// Uniquely identifies the version of this class.  If the versions match,
		/// then the socket communicators should be compatible.
		/// </summary>
		// Token: 0x06012D69 RID: 77161 RVA: 0x001A83B4 File Offset: 0x001A65B4
		public static int GetVersion()
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_GetVersion_22();
		}

		// Token: 0x06012D6A RID: 77162
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCommunicator_Handshake_23(HandleRef pThis);

		/// <summary>
		/// Performs handshake. This uses vtkClientSocket::ConnectingSide to decide
		/// whether to perform ServerSideHandshake or ClientSideHandshake.
		/// </summary>
		// Token: 0x06012D6B RID: 77163 RVA: 0x001A83D0 File Offset: 0x001A65D0
		public int Handshake()
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_Handshake_23(base.GetCppThis());
		}

		// Token: 0x06012D6C RID: 77164
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSocketCommunicator_HasBufferredMessages_24(HandleRef pThis);

		/// <summary>
		/// Returns true if there are any messages in the receive buffer.
		/// </summary>
		// Token: 0x06012D6D RID: 77165 RVA: 0x001A83F0 File Offset: 0x001A65F0
		public bool HasBufferredMessages()
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_HasBufferredMessages_24(base.GetCppThis()) != 0;
		}

		// Token: 0x06012D6E RID: 77166
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCommunicator_IsA_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012D6F RID: 77167 RVA: 0x001A8418 File Offset: 0x001A6618
		public override int IsA(string type)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_IsA_25(base.GetCppThis(), type);
		}

		// Token: 0x06012D70 RID: 77168
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCommunicator_IsTypeOf_26([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012D71 RID: 77169 RVA: 0x001A8438 File Offset: 0x001A6638
		public new static int IsTypeOf(string type)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_IsTypeOf_26(type);
		}

		// Token: 0x06012D72 RID: 77170
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCommunicator_LogToFile_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Log messages to the given file.  The file is truncated unless the
		/// second argument is non-zero (default is to truncate).  If the
		/// file name is empty or nullptr, logging is disabled.  Returns 0 if
		/// the file failed to open, and 1 otherwise.
		/// </summary>
		// Token: 0x06012D73 RID: 77171 RVA: 0x001A8454 File Offset: 0x001A6654
		public virtual int LogToFile(string name)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_LogToFile_27(base.GetCppThis(), name);
		}

		// Token: 0x06012D74 RID: 77172
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCommunicator_LogToFile_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int append);

		/// <summary>
		/// Log messages to the given file.  The file is truncated unless the
		/// second argument is non-zero (default is to truncate).  If the
		/// file name is empty or nullptr, logging is disabled.  Returns 0 if
		/// the file failed to open, and 1 otherwise.
		/// </summary>
		// Token: 0x06012D75 RID: 77173 RVA: 0x001A8474 File Offset: 0x001A6674
		public virtual int LogToFile(string name, int append)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_LogToFile_28(base.GetCppThis(), name, append);
		}

		// Token: 0x06012D76 RID: 77174
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSocketCommunicator_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012D77 RID: 77175 RVA: 0x001A8498 File Offset: 0x001A6698
		public new vtkSocketCommunicator NewInstance()
		{
			vtkSocketCommunicator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSocketCommunicator.vtkSocketCommunicator_NewInstance_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSocketCommunicator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012D78 RID: 77176
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSocketCommunicator_PerformHandshakeOff_31(HandleRef pThis);

		/// <summary>
		/// Set or get the PerformHandshake ivar. If it is on, the communicator
		/// will try to perform a handshake when connected.
		/// It is on by default.
		/// </summary>
		// Token: 0x06012D79 RID: 77177 RVA: 0x001A84F2 File Offset: 0x001A66F2
		public virtual void PerformHandshakeOff()
		{
			vtkSocketCommunicator.vtkSocketCommunicator_PerformHandshakeOff_31(base.GetCppThis());
		}

		// Token: 0x06012D7A RID: 77178
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSocketCommunicator_PerformHandshakeOn_32(HandleRef pThis);

		/// <summary>
		/// Set or get the PerformHandshake ivar. If it is on, the communicator
		/// will try to perform a handshake when connected.
		/// It is on by default.
		/// </summary>
		// Token: 0x06012D7B RID: 77179 RVA: 0x001A8501 File Offset: 0x001A6701
		public virtual void PerformHandshakeOn()
		{
			vtkSocketCommunicator.vtkSocketCommunicator_PerformHandshakeOn_32(base.GetCppThis());
		}

		// Token: 0x06012D7C RID: 77180
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCommunicator_ReceiveVoidArray_33(HandleRef pThis, IntPtr data, long length, int type, int remoteHandle, int tag);

		/// <summary>
		/// Performs the actual communication.  You will usually use the convenience
		/// Send functions defined in the superclass.
		/// </summary>
		// Token: 0x06012D7D RID: 77181 RVA: 0x001A8510 File Offset: 0x001A6710
		public override int ReceiveVoidArray(IntPtr data, long length, int type, int remoteHandle, int tag)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_ReceiveVoidArray_33(base.GetCppThis(), data, length, type, remoteHandle, tag);
		}

		// Token: 0x06012D7E RID: 77182
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCommunicator_ReduceVoidArray_34(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int operation, int destProcessId);

		/// <summary>
		/// This class foolishly breaks the conventions of the superclass, so the
		/// default implementations of these methods do not work.  These just give
		/// errors instead.
		/// </summary>
		// Token: 0x06012D7F RID: 77183 RVA: 0x001A8538 File Offset: 0x001A6738
		public override int ReduceVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int operation, int destProcessId)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_ReduceVoidArray_34(base.GetCppThis(), sendBuffer, recvBuffer, length, type, operation, destProcessId);
		}

		// Token: 0x06012D80 RID: 77184
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSocketCommunicator_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012D81 RID: 77185 RVA: 0x001A8560 File Offset: 0x001A6760
		public new static vtkSocketCommunicator SafeDownCast(vtkObjectBase o)
		{
			vtkSocketCommunicator vtkSocketCommunicator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSocketCommunicator.vtkSocketCommunicator_SafeDownCast_35((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSocketCommunicator = (vtkSocketCommunicator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSocketCommunicator.Register(null);
				}
			}
			return vtkSocketCommunicator;
		}

		// Token: 0x06012D82 RID: 77186
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCommunicator_ScatterVVoidArray_36(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int type, int srcProcessId);

		/// <summary>
		/// This class foolishly breaks the conventions of the superclass, so the
		/// default implementations of these methods do not work.  These just give
		/// errors instead.
		/// </summary>
		// Token: 0x06012D83 RID: 77187 RVA: 0x001A85E0 File Offset: 0x001A67E0
		public override int ScatterVVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int type, int srcProcessId)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_ScatterVVoidArray_36(base.GetCppThis(), sendBuffer, recvBuffer, sendLengths, offsets, recvLength, type, srcProcessId);
		}

		// Token: 0x06012D84 RID: 77188
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCommunicator_ScatterVoidArray_37(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int srcProcessId);

		/// <summary>
		/// This class foolishly breaks the conventions of the superclass, so the
		/// default implementations of these methods do not work.  These just give
		/// errors instead.
		/// </summary>
		// Token: 0x06012D85 RID: 77189 RVA: 0x001A860C File Offset: 0x001A680C
		public override int ScatterVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int srcProcessId)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_ScatterVoidArray_37(base.GetCppThis(), sendBuffer, recvBuffer, length, type, srcProcessId);
		}

		// Token: 0x06012D86 RID: 77190
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCommunicator_SendVoidArray_38(HandleRef pThis, IntPtr data, long length, int type, int remoteHandle, int tag);

		/// <summary>
		/// Performs the actual communication.  You will usually use the convenience
		/// Send functions defined in the superclass.
		/// </summary>
		// Token: 0x06012D87 RID: 77191 RVA: 0x001A8634 File Offset: 0x001A6834
		public override int SendVoidArray(IntPtr data, long length, int type, int remoteHandle, int tag)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_SendVoidArray_38(base.GetCppThis(), data, length, type, remoteHandle, tag);
		}

		// Token: 0x06012D88 RID: 77192
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCommunicator_ServerSideHandshake_39(HandleRef pThis);

		/// <summary>
		/// Performs ServerSide handshake.
		/// One should preferably use Handshake() which calls ServerSideHandshake or
		/// ClientSideHandshake as required.
		/// </summary>
		// Token: 0x06012D89 RID: 77193 RVA: 0x001A865C File Offset: 0x001A685C
		public int ServerSideHandshake()
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_ServerSideHandshake_39(base.GetCppThis());
		}

		// Token: 0x06012D8A RID: 77194
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSocketCommunicator_SetNumberOfProcesses_40(HandleRef pThis, int num);

		/// <summary>
		/// Set the number of processes you will be using.
		/// </summary>
		// Token: 0x06012D8B RID: 77195 RVA: 0x001A867B File Offset: 0x001A687B
		public override void SetNumberOfProcesses(int num)
		{
			vtkSocketCommunicator.vtkSocketCommunicator_SetNumberOfProcesses_40(base.GetCppThis(), num);
		}

		// Token: 0x06012D8C RID: 77196
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSocketCommunicator_SetPerformHandshake_41(HandleRef pThis, int _arg);

		/// <summary>
		/// Set or get the PerformHandshake ivar. If it is on, the communicator
		/// will try to perform a handshake when connected.
		/// It is on by default.
		/// </summary>
		// Token: 0x06012D8D RID: 77197 RVA: 0x001A868B File Offset: 0x001A688B
		public virtual void SetPerformHandshake(int _arg)
		{
			vtkSocketCommunicator.vtkSocketCommunicator_SetPerformHandshake_41(base.GetCppThis(), _arg);
		}

		// Token: 0x06012D8E RID: 77198
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSocketCommunicator_SetReportErrors_42(HandleRef pThis, int _arg);

		/// <summary>
		/// If ReportErrors if false, all vtkErrorMacros are suppressed.
		/// </summary>
		// Token: 0x06012D8F RID: 77199 RVA: 0x001A869B File Offset: 0x001A689B
		public virtual void SetReportErrors(int _arg)
		{
			vtkSocketCommunicator.vtkSocketCommunicator_SetReportErrors_42(base.GetCppThis(), _arg);
		}

		// Token: 0x06012D90 RID: 77200
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSocketCommunicator_SetSocket_43(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set the actual socket used for communication.
		/// </summary>
		// Token: 0x06012D91 RID: 77201 RVA: 0x001A86AC File Offset: 0x001A68AC
		public void SetSocket(vtkClientSocket arg0)
		{
			vtkSocketCommunicator.vtkSocketCommunicator_SetSocket_43(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06012D92 RID: 77202
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCommunicator_WaitForConnection_44(HandleRef pThis, int port);

		/// <summary>
		/// Wait for connection on a given port.
		/// These methods return 1 on success, 0 on error.
		/// </summary>
		// Token: 0x06012D93 RID: 77203 RVA: 0x001A86DC File Offset: 0x001A68DC
		public virtual int WaitForConnection(int port)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_WaitForConnection_44(base.GetCppThis(), port);
		}

		// Token: 0x06012D94 RID: 77204
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketCommunicator_WaitForConnection_45(HandleRef pThis, HandleRef socket, uint msec);

		/// <summary>
		/// Wait for connection on a given port.
		/// These methods return 1 on success, 0 on error.
		/// </summary>
		// Token: 0x06012D95 RID: 77205 RVA: 0x001A86FC File Offset: 0x001A68FC
		public virtual int WaitForConnection(vtkServerSocket socket, uint msec)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_WaitForConnection_45(base.GetCppThis(), (socket == null) ? default(HandleRef) : socket.GetCppThis(), msec);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015BF RID: 5567
		public new const string MRFullTypeName = "Kitware.VTK.vtkSocketCommunicator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015C0 RID: 5568
		public new static readonly string MRClassNameKey = "class vtkSocketCommunicator";
	}
}
