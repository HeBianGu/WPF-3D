using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCommunicator
	/// </summary>
	/// <remarks>
	///    Used to send/receive messages in a multiprocess environment.
	///
	/// This is an abstract class which contains functionality for sending
	/// and receiving inter-process messages. It contains methods for marshaling
	/// an object into a string (currently used by the MPI communicator but
	/// not the shared memory communicator).
	///
	/// @warning
	/// Communication between systems with different vtkIdTypes is not
	/// supported. All machines have to have the same vtkIdType.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkMPICommunicator
	/// </seealso>
	// Token: 0x020006EE RID: 1774
	public abstract class vtkCommunicator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012B1D RID: 76573 RVA: 0x001A4CC5 File Offset: 0x001A2EC5
		static vtkCommunicator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCommunicator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCommunicator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012B1E RID: 76574 RVA: 0x001A4CED File Offset: 0x001A2EED
		public vtkCommunicator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012B1F RID: 76575 RVA: 0x001A4CFB File Offset: 0x001A2EFB
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012B20 RID: 76576
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_AllGather_01(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length);

		/// <summary>
		/// Same as gather except that the result ends up on all processes.
		/// </summary>
		// Token: 0x06012B21 RID: 76577 RVA: 0x001A4D08 File Offset: 0x001A2F08
		public int AllGather(IntPtr sendBuffer, IntPtr recvBuffer, long length)
		{
			return vtkCommunicator.vtkCommunicator_AllGather_01(base.GetCppThis(), sendBuffer, recvBuffer, length);
		}

		// Token: 0x06012B22 RID: 76578
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_AllGather_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string sendBuffer, [MarshalAs(UnmanagedType.LPUTF8Str)] string recvBuffer, long length);

		/// <summary>
		/// Same as gather except that the result ends up on all processes.
		/// </summary>
		// Token: 0x06012B23 RID: 76579 RVA: 0x001A4D2C File Offset: 0x001A2F2C
		public int AllGather(string sendBuffer, string recvBuffer, long length)
		{
			return vtkCommunicator.vtkCommunicator_AllGather_02(base.GetCppThis(), sendBuffer, recvBuffer, length);
		}

		// Token: 0x06012B24 RID: 76580
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_AllGather_03(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer);

		/// <summary>
		/// Same as gather except that the result ends up on all processes.
		/// </summary>
		// Token: 0x06012B25 RID: 76581 RVA: 0x001A4D50 File Offset: 0x001A2F50
		public int AllGather(vtkDataArray sendBuffer, vtkDataArray recvBuffer)
		{
			return vtkCommunicator.vtkCommunicator_AllGather_03(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis());
		}

		// Token: 0x06012B26 RID: 76582
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_AllGatherV_04(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets);

		/// <summary>
		/// Same as GatherV except that the result is placed in all processes.
		/// </summary>
		// Token: 0x06012B27 RID: 76583 RVA: 0x001A4D9C File Offset: 0x001A2F9C
		public int AllGatherV(IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets)
		{
			return vtkCommunicator.vtkCommunicator_AllGatherV_04(base.GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets);
		}

		// Token: 0x06012B28 RID: 76584
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_AllGatherV_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string sendBuffer, [MarshalAs(UnmanagedType.LPUTF8Str)] string recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets);

		/// <summary>
		/// Same as GatherV except that the result is placed in all processes.
		/// </summary>
		// Token: 0x06012B29 RID: 76585 RVA: 0x001A4DC4 File Offset: 0x001A2FC4
		public int AllGatherV(string sendBuffer, string recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets)
		{
			return vtkCommunicator.vtkCommunicator_AllGatherV_05(base.GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets);
		}

		// Token: 0x06012B2A RID: 76586
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_AllGatherV_06(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, IntPtr recvLengths, IntPtr offsets);

		/// <summary>
		/// Same as GatherV except that the result is placed in all processes.
		/// </summary>
		// Token: 0x06012B2B RID: 76587 RVA: 0x001A4DEC File Offset: 0x001A2FEC
		public int AllGatherV(vtkDataArray sendBuffer, vtkDataArray recvBuffer, IntPtr recvLengths, IntPtr offsets)
		{
			return vtkCommunicator.vtkCommunicator_AllGatherV_06(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis(), recvLengths, offsets);
		}

		// Token: 0x06012B2C RID: 76588
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_AllGatherV_07(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer);

		/// <summary>
		/// Same as GatherV except that the result is placed in all processes.
		/// </summary>
		// Token: 0x06012B2D RID: 76589 RVA: 0x001A4E38 File Offset: 0x001A3038
		public int AllGatherV(vtkDataArray sendBuffer, vtkDataArray recvBuffer)
		{
			return vtkCommunicator.vtkCommunicator_AllGatherV_07(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis());
		}

		// Token: 0x06012B2E RID: 76590
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_AllGatherVVoidArray_08(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int type);

		/// <summary>
		/// Subclasses should reimplement these if they have a more efficient
		/// implementation.
		/// </summary>
		// Token: 0x06012B2F RID: 76591 RVA: 0x001A4E84 File Offset: 0x001A3084
		public virtual int AllGatherVVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int type)
		{
			return vtkCommunicator.vtkCommunicator_AllGatherVVoidArray_08(base.GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets, type);
		}

		// Token: 0x06012B30 RID: 76592
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_AllGatherVoidArray_09(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int type);

		/// <summary>
		/// Subclasses should reimplement these if they have a more efficient
		/// implementation.
		/// </summary>
		// Token: 0x06012B31 RID: 76593 RVA: 0x001A4EAC File Offset: 0x001A30AC
		public virtual int AllGatherVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long length, int type)
		{
			return vtkCommunicator.vtkCommunicator_AllGatherVoidArray_09(base.GetCppThis(), sendBuffer, recvBuffer, length, type);
		}

		// Token: 0x06012B32 RID: 76594
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_AllReduce_10(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int operation);

		/// <summary>
		/// Same as Reduce except that the result is placed in all of the processes.
		/// </summary>
		// Token: 0x06012B33 RID: 76595 RVA: 0x001A4ED0 File Offset: 0x001A30D0
		public int AllReduce(IntPtr sendBuffer, IntPtr recvBuffer, long length, int operation)
		{
			return vtkCommunicator.vtkCommunicator_AllReduce_10(base.GetCppThis(), sendBuffer, recvBuffer, length, operation);
		}

		// Token: 0x06012B34 RID: 76596
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_AllReduce_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string sendBuffer, [MarshalAs(UnmanagedType.LPUTF8Str)] string recvBuffer, long length, int operation);

		/// <summary>
		/// Same as Reduce except that the result is placed in all of the processes.
		/// </summary>
		// Token: 0x06012B35 RID: 76597 RVA: 0x001A4EF4 File Offset: 0x001A30F4
		public int AllReduce(string sendBuffer, string recvBuffer, long length, int operation)
		{
			return vtkCommunicator.vtkCommunicator_AllReduce_11(base.GetCppThis(), sendBuffer, recvBuffer, length, operation);
		}

		// Token: 0x06012B36 RID: 76598
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_AllReduce_12(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int operation);

		/// <summary>
		/// Same as Reduce except that the result is placed in all of the processes.
		/// </summary>
		// Token: 0x06012B37 RID: 76599 RVA: 0x001A4F18 File Offset: 0x001A3118
		public int AllReduce(vtkDataArray sendBuffer, vtkDataArray recvBuffer, int operation)
		{
			return vtkCommunicator.vtkCommunicator_AllReduce_12(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis(), operation);
		}

		// Token: 0x06012B38 RID: 76600
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_AllReduceVoidArray_13(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int operation);

		/// <summary>
		/// Subclasses should reimplement these if they have a more efficient
		/// implementation.
		/// </summary>
		// Token: 0x06012B39 RID: 76601 RVA: 0x001A4F64 File Offset: 0x001A3164
		public virtual int AllReduceVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int operation)
		{
			return vtkCommunicator.vtkCommunicator_AllReduceVoidArray_13(base.GetCppThis(), sendBuffer, recvBuffer, length, type, operation);
		}

		// Token: 0x06012B3A RID: 76602
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCommunicator_Barrier_14(HandleRef pThis);

		/// <summary>
		/// Will block the processes until all other processes reach the Barrier
		/// function.
		/// </summary>
		// Token: 0x06012B3B RID: 76603 RVA: 0x001A4F8A File Offset: 0x001A318A
		public virtual void Barrier()
		{
			vtkCommunicator.vtkCommunicator_Barrier_14(base.GetCppThis());
		}

		// Token: 0x06012B3C RID: 76604
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_Broadcast_15(HandleRef pThis, IntPtr data, long length, int srcProcessId);

		/// <summary>
		/// Broadcast sends the array in the process with id \c srcProcessId to all of
		/// the other processes.  All processes must call these method with the same
		/// arguments in order for it to complete.
		/// </summary>
		// Token: 0x06012B3D RID: 76605 RVA: 0x001A4F9C File Offset: 0x001A319C
		public int Broadcast(IntPtr data, long length, int srcProcessId)
		{
			return vtkCommunicator.vtkCommunicator_Broadcast_15(base.GetCppThis(), data, length, srcProcessId);
		}

		// Token: 0x06012B3E RID: 76606
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_Broadcast_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string data, long length, int srcProcessId);

		/// <summary>
		/// Broadcast sends the array in the process with id \c srcProcessId to all of
		/// the other processes.  All processes must call these method with the same
		/// arguments in order for it to complete.
		/// </summary>
		// Token: 0x06012B3F RID: 76607 RVA: 0x001A4FC0 File Offset: 0x001A31C0
		public int Broadcast(string data, long length, int srcProcessId)
		{
			return vtkCommunicator.vtkCommunicator_Broadcast_16(base.GetCppThis(), data, length, srcProcessId);
		}

		// Token: 0x06012B40 RID: 76608
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_Broadcast_17(HandleRef pThis, HandleRef data, int srcProcessId);

		/// <summary>
		/// Broadcast sends the array in the process with id \c srcProcessId to all of
		/// the other processes.  All processes must call these method with the same
		/// arguments in order for it to complete.
		/// </summary>
		// Token: 0x06012B41 RID: 76609 RVA: 0x001A4FE4 File Offset: 0x001A31E4
		public int Broadcast(vtkDataObject data, int srcProcessId)
		{
			return vtkCommunicator.vtkCommunicator_Broadcast_17(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), srcProcessId);
		}

		// Token: 0x06012B42 RID: 76610
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_Broadcast_18(HandleRef pThis, HandleRef data, int srcProcessId);

		/// <summary>
		/// Broadcast sends the array in the process with id \c srcProcessId to all of
		/// the other processes.  All processes must call these method with the same
		/// arguments in order for it to complete.
		/// </summary>
		// Token: 0x06012B43 RID: 76611 RVA: 0x001A501C File Offset: 0x001A321C
		public int Broadcast(vtkDataArray data, int srcProcessId)
		{
			return vtkCommunicator.vtkCommunicator_Broadcast_18(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), srcProcessId);
		}

		// Token: 0x06012B44 RID: 76612
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_BroadcastVoidArray_19(HandleRef pThis, IntPtr data, long length, int type, int srcProcessId);

		/// <summary>
		/// Subclasses should reimplement these if they have a more efficient
		/// implementation.
		/// </summary>
		// Token: 0x06012B45 RID: 76613 RVA: 0x001A5054 File Offset: 0x001A3254
		public virtual int BroadcastVoidArray(IntPtr data, long length, int type, int srcProcessId)
		{
			return vtkCommunicator.vtkCommunicator_BroadcastVoidArray_19(base.GetCppThis(), data, length, type, srcProcessId);
		}

		// Token: 0x06012B46 RID: 76614
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCommunicator_CanProbe_20(HandleRef pThis);

		/// <summary>
		/// Check if this communicator implements a probe operation
		///
		/// This method is implemented for the probing operation for now so as to not have to implement it
		/// for all the subclasses of vtkCommunicator. In the future, one could imagine making the Probe
		/// method a pure virtual method and having it implemented everywhere so as to no longer need the
		/// CanProbe method.
		/// </summary>
		// Token: 0x06012B47 RID: 76615 RVA: 0x001A5078 File Offset: 0x001A3278
		public virtual bool CanProbe()
		{
			return vtkCommunicator.vtkCommunicator_CanProbe_20(base.GetCppThis()) != 0;
		}

		// Token: 0x06012B48 RID: 76616
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_Gather_21(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int destProcessId);

		/// <summary>
		/// Gather collects arrays in the process with id \c destProcessId.  Each
		/// process (including the destination) sends the contents of its send buffer
		/// to the destination process.  The destination process receives the
		/// messages and stores them in rank order.  The \c length argument
		/// (which must be the same on all processes) is the length of the
		/// sendBuffers.  The \c recvBuffer (on the destination process) must be of
		/// length length*numProcesses.  Gather is the inverse operation of Scatter.
		/// </summary>
		// Token: 0x06012B49 RID: 76617 RVA: 0x001A50A0 File Offset: 0x001A32A0
		public int Gather(IntPtr sendBuffer, IntPtr recvBuffer, long length, int destProcessId)
		{
			return vtkCommunicator.vtkCommunicator_Gather_21(base.GetCppThis(), sendBuffer, recvBuffer, length, destProcessId);
		}

		// Token: 0x06012B4A RID: 76618
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_Gather_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string sendBuffer, [MarshalAs(UnmanagedType.LPUTF8Str)] string recvBuffer, long length, int destProcessId);

		/// <summary>
		/// Gather collects arrays in the process with id \c destProcessId.  Each
		/// process (including the destination) sends the contents of its send buffer
		/// to the destination process.  The destination process receives the
		/// messages and stores them in rank order.  The \c length argument
		/// (which must be the same on all processes) is the length of the
		/// sendBuffers.  The \c recvBuffer (on the destination process) must be of
		/// length length*numProcesses.  Gather is the inverse operation of Scatter.
		/// </summary>
		// Token: 0x06012B4B RID: 76619 RVA: 0x001A50C4 File Offset: 0x001A32C4
		public int Gather(string sendBuffer, string recvBuffer, long length, int destProcessId)
		{
			return vtkCommunicator.vtkCommunicator_Gather_22(base.GetCppThis(), sendBuffer, recvBuffer, length, destProcessId);
		}

		// Token: 0x06012B4C RID: 76620
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_Gather_23(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int destProcessId);

		/// <summary>
		/// Gather collects arrays in the process with id \c destProcessId.  Each
		/// process (including the destination) sends the contents of its send buffer
		/// to the destination process.  The destination process receives the
		/// messages and stores them in rank order.  The \c length argument
		/// (which must be the same on all processes) is the length of the
		/// sendBuffers.  The \c recvBuffer (on the destination process) must be of
		/// length length*numProcesses.  Gather is the inverse operation of Scatter.
		/// </summary>
		// Token: 0x06012B4D RID: 76621 RVA: 0x001A50E8 File Offset: 0x001A32E8
		public int Gather(vtkDataArray sendBuffer, vtkDataArray recvBuffer, int destProcessId)
		{
			return vtkCommunicator.vtkCommunicator_Gather_23(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis(), destProcessId);
		}

		// Token: 0x06012B4E RID: 76622
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_GatherV_24(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int destProcessId);

		/// <summary>
		/// GatherV is the vector variant of Gather.  It extends the functionality of
		/// Gather by allowing a varying count of data from each process.
		/// GatherV collects arrays in the process with id \c destProcessId.  Each
		/// process (including the destination) sends the contents of its send buffer
		/// to the destination process.  The destination process receives the
		/// messages and stores them in rank order.  The \c sendLength argument
		/// defines how much the local process sends to \c destProcessId and
		/// \c recvLengths is an array containing the amount \c destProcessId
		/// receives from each process, in rank order.
		/// </summary>
		// Token: 0x06012B4F RID: 76623 RVA: 0x001A5134 File Offset: 0x001A3334
		public int GatherV(IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int destProcessId)
		{
			return vtkCommunicator.vtkCommunicator_GatherV_24(base.GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets, destProcessId);
		}

		// Token: 0x06012B50 RID: 76624
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_GatherV_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string sendBuffer, [MarshalAs(UnmanagedType.LPUTF8Str)] string recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int destProcessId);

		/// <summary>
		/// GatherV is the vector variant of Gather.  It extends the functionality of
		/// Gather by allowing a varying count of data from each process.
		/// GatherV collects arrays in the process with id \c destProcessId.  Each
		/// process (including the destination) sends the contents of its send buffer
		/// to the destination process.  The destination process receives the
		/// messages and stores them in rank order.  The \c sendLength argument
		/// defines how much the local process sends to \c destProcessId and
		/// \c recvLengths is an array containing the amount \c destProcessId
		/// receives from each process, in rank order.
		/// </summary>
		// Token: 0x06012B51 RID: 76625 RVA: 0x001A515C File Offset: 0x001A335C
		public int GatherV(string sendBuffer, string recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int destProcessId)
		{
			return vtkCommunicator.vtkCommunicator_GatherV_25(base.GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets, destProcessId);
		}

		// Token: 0x06012B52 RID: 76626
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_GatherV_26(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, IntPtr recvLengths, IntPtr offsets, int destProcessId);

		/// <summary>
		/// For the first GatherV variant, \c recvLengths and \c offsets known on
		/// \c destProcessId and are passed in as parameters
		/// For the second GatherV variant, \c recvLengths and \c offsets are not known
		/// on \c destProcessId.  The \c recvLengths is set using a gather operation
		/// and \c offsets is computed from \c recvLengths. recvLengths has
		/// \c NumberOfProcesses elements and \c offsets has NumberOfProcesses + 1 elements.
		/// The third variant is the same as the second variant but it does not expose
		/// \c recvLength and \c offsets
		/// </summary>
		// Token: 0x06012B53 RID: 76627 RVA: 0x001A5184 File Offset: 0x001A3384
		public int GatherV(vtkDataArray sendBuffer, vtkDataArray recvBuffer, IntPtr recvLengths, IntPtr offsets, int destProcessId)
		{
			return vtkCommunicator.vtkCommunicator_GatherV_26(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis(), recvLengths, offsets, destProcessId);
		}

		// Token: 0x06012B54 RID: 76628
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_GatherV_27(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, HandleRef recvLengths, HandleRef offsets, int destProcessId);

		/// <summary>
		/// For the first GatherV variant, \c recvLengths and \c offsets known on
		/// \c destProcessId and are passed in as parameters
		/// For the second GatherV variant, \c recvLengths and \c offsets are not known
		/// on \c destProcessId.  The \c recvLengths is set using a gather operation
		/// and \c offsets is computed from \c recvLengths. recvLengths has
		/// \c NumberOfProcesses elements and \c offsets has NumberOfProcesses + 1 elements.
		/// The third variant is the same as the second variant but it does not expose
		/// \c recvLength and \c offsets
		/// </summary>
		// Token: 0x06012B55 RID: 76629 RVA: 0x001A51D4 File Offset: 0x001A33D4
		public int GatherV(vtkDataArray sendBuffer, vtkDataArray recvBuffer, vtkIdTypeArray recvLengths, vtkIdTypeArray offsets, int destProcessId)
		{
			return vtkCommunicator.vtkCommunicator_GatherV_27(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis(), (recvLengths == null) ? default(HandleRef) : recvLengths.GetCppThis(), (offsets == null) ? default(HandleRef) : offsets.GetCppThis(), destProcessId);
		}

		// Token: 0x06012B56 RID: 76630
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_GatherV_28(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int destProcessId);

		/// <summary>
		/// For the first GatherV variant, \c recvLengths and \c offsets known on
		/// \c destProcessId and are passed in as parameters
		/// For the second GatherV variant, \c recvLengths and \c offsets are not known
		/// on \c destProcessId.  The \c recvLengths is set using a gather operation
		/// and \c offsets is computed from \c recvLengths. recvLengths has
		/// \c NumberOfProcesses elements and \c offsets has NumberOfProcesses + 1 elements.
		/// The third variant is the same as the second variant but it does not expose
		/// \c recvLength and \c offsets
		/// </summary>
		// Token: 0x06012B57 RID: 76631 RVA: 0x001A524C File Offset: 0x001A344C
		public int GatherV(vtkDataArray sendBuffer, vtkDataArray recvBuffer, int destProcessId)
		{
			return vtkCommunicator.vtkCommunicator_GatherV_28(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis(), destProcessId);
		}

		// Token: 0x06012B58 RID: 76632
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_GatherVVoidArray_29(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int type, int destProcessId);

		/// <summary>
		/// Subclasses should reimplement these if they have a more efficient
		/// implementation.
		/// </summary>
		// Token: 0x06012B59 RID: 76633 RVA: 0x001A5298 File Offset: 0x001A3498
		public virtual int GatherVVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int type, int destProcessId)
		{
			return vtkCommunicator.vtkCommunicator_GatherVVoidArray_29(base.GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets, type, destProcessId);
		}

		// Token: 0x06012B5A RID: 76634
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_GatherVoidArray_30(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int destProcessId);

		/// <summary>
		/// Subclasses should reimplement these if they have a more efficient
		/// implementation.
		/// </summary>
		// Token: 0x06012B5B RID: 76635 RVA: 0x001A52C4 File Offset: 0x001A34C4
		public virtual int GatherVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int destProcessId)
		{
			return vtkCommunicator.vtkCommunicator_GatherVoidArray_30(base.GetCppThis(), sendBuffer, recvBuffer, length, type, destProcessId);
		}

		// Token: 0x06012B5C RID: 76636
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCommunicator_GetCount_31(HandleRef pThis);

		/// <summary>
		/// Returns the number of words received by the most recent Receive().
		/// Note that this is not the number of bytes received, but the number of items
		/// of the data-type received by the most recent Receive() eg. if
		/// Receive(int*,..) was used, then this returns the number of ints received;
		/// if Receive(double*,..) was used, then this returns the number of doubles
		/// received etc. The return value is valid only after a successful Receive().
		/// </summary>
		// Token: 0x06012B5D RID: 76637 RVA: 0x001A52EC File Offset: 0x001A34EC
		public virtual long GetCount()
		{
			return vtkCommunicator.vtkCommunicator_GetCount_31(base.GetCppThis());
		}

		// Token: 0x06012B5E RID: 76638
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_GetLeftChildProcessor_32(int pid);

		/// <summary>
		/// Some helper functions when dealing with heap tree - based
		/// algorithms - we don't need a function for getting the right
		/// processor since it is 1 + theLeftProcessor
		/// </summary>
		// Token: 0x06012B5F RID: 76639 RVA: 0x001A530C File Offset: 0x001A350C
		public static int GetLeftChildProcessor(int pid)
		{
			return vtkCommunicator.vtkCommunicator_GetLeftChildProcessor_32(pid);
		}

		// Token: 0x06012B60 RID: 76640
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_GetLocalProcessId_33(HandleRef pThis);

		/// <summary>
		/// Tells you which process [0, NumProcess) you are in.
		/// </summary>
		// Token: 0x06012B61 RID: 76641 RVA: 0x001A5328 File Offset: 0x001A3528
		public virtual int GetLocalProcessId()
		{
			return vtkCommunicator.vtkCommunicator_GetLocalProcessId_33(base.GetCppThis());
		}

		// Token: 0x06012B62 RID: 76642
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCommunicator_GetNumberOfGenerationsFromBase_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012B63 RID: 76643 RVA: 0x001A5348 File Offset: 0x001A3548
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCommunicator.vtkCommunicator_GetNumberOfGenerationsFromBase_34(base.GetCppThis(), type);
		}

		// Token: 0x06012B64 RID: 76644
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCommunicator_GetNumberOfGenerationsFromBaseType_35([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012B65 RID: 76645 RVA: 0x001A5368 File Offset: 0x001A3568
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCommunicator.vtkCommunicator_GetNumberOfGenerationsFromBaseType_35(type);
		}

		// Token: 0x06012B66 RID: 76646
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_GetNumberOfProcesses_36(HandleRef pThis);

		/// <summary>
		/// Set the number of processes you will be using.  This defaults
		/// to the maximum number available.  If you set this to a value
		/// higher than the default, you will get an error.
		/// </summary>
		// Token: 0x06012B67 RID: 76647 RVA: 0x001A5384 File Offset: 0x001A3584
		public virtual int GetNumberOfProcesses()
		{
			return vtkCommunicator.vtkCommunicator_GetNumberOfProcesses_36(base.GetCppThis());
		}

		// Token: 0x06012B68 RID: 76648
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_GetParentProcessor_37(int pid);

		/// <summary>
		/// Some helper functions when dealing with heap tree - based
		/// algorithms - we don't need a function for getting the right
		/// processor since it is 1 + theLeftProcessor
		/// </summary>
		// Token: 0x06012B69 RID: 76649 RVA: 0x001A53A4 File Offset: 0x001A35A4
		public static int GetParentProcessor(int pid)
		{
			return vtkCommunicator.vtkCommunicator_GetParentProcessor_37(pid);
		}

		// Token: 0x06012B6A RID: 76650
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_IsA_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012B6B RID: 76651 RVA: 0x001A53C0 File Offset: 0x001A35C0
		public override int IsA(string type)
		{
			return vtkCommunicator.vtkCommunicator_IsA_38(base.GetCppThis(), type);
		}

		// Token: 0x06012B6C RID: 76652
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_IsTypeOf_39([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012B6D RID: 76653 RVA: 0x001A53E0 File Offset: 0x001A35E0
		public new static int IsTypeOf(string type)
		{
			return vtkCommunicator.vtkCommunicator_IsTypeOf_39(type);
		}

		// Token: 0x06012B6E RID: 76654
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_MarshalDataObject_40(HandleRef arg0, HandleRef buffer);

		/// <summary>
		/// Convert a data object into a string that can be transmitted and vice versa.
		/// Returns 1 for success and 0 for failure.
		/// WARNING: This will only work for types that have a vtkDataWriter class.
		/// </summary>
		// Token: 0x06012B6F RID: 76655 RVA: 0x001A53FC File Offset: 0x001A35FC
		public static int MarshalDataObject(vtkDataObject arg0, vtkCharArray buffer)
		{
			return vtkCommunicator.vtkCommunicator_MarshalDataObject_40((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (buffer == null) ? default(HandleRef) : buffer.GetCppThis());
		}

		// Token: 0x06012B70 RID: 76656
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCommunicator_NewInstance_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012B71 RID: 76657 RVA: 0x001A5440 File Offset: 0x001A3640
		public new vtkCommunicator NewInstance()
		{
			vtkCommunicator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCommunicator.vtkCommunicator_NewInstance_41(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCommunicator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012B72 RID: 76658
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_Probe_42(HandleRef pThis, int arg0, int arg1, IntPtr arg2);

		/// <summary>
		/// Blocking test for checking for a message tagged with tag from source process (if
		/// source == ANY_SOURCE check for any message). Rank in actualSource is rank sending
		/// a message.
		///
		/// Check if implemented in this communicator using the CanProbe method before using.
		///
		/// Returns 1 on success and 0 on failure.
		/// </summary>
		// Token: 0x06012B73 RID: 76659 RVA: 0x001A549C File Offset: 0x001A369C
		public virtual int Probe(int arg0, int arg1, IntPtr arg2)
		{
			return vtkCommunicator.vtkCommunicator_Probe_42(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x06012B74 RID: 76660
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_Receive_43(HandleRef pThis, HandleRef data, int remoteHandle, int tag);

		/// <summary>
		/// This method receives a data object from a corresponding send. It blocks
		/// until the receive is finished.
		/// </summary>
		// Token: 0x06012B75 RID: 76661 RVA: 0x001A54C0 File Offset: 0x001A36C0
		public int Receive(vtkDataObject data, int remoteHandle, int tag)
		{
			return vtkCommunicator.vtkCommunicator_Receive_43(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), remoteHandle, tag);
		}

		// Token: 0x06012B76 RID: 76662
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_Receive_44(HandleRef pThis, HandleRef data, int remoteHandle, int tag);

		/// <summary>
		/// This method receives a data array from a corresponding send. It blocks
		/// until the receive is finished.
		/// </summary>
		// Token: 0x06012B77 RID: 76663 RVA: 0x001A54F8 File Offset: 0x001A36F8
		public int Receive(vtkDataArray data, int remoteHandle, int tag)
		{
			return vtkCommunicator.vtkCommunicator_Receive_44(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), remoteHandle, tag);
		}

		// Token: 0x06012B78 RID: 76664
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_Receive_45(HandleRef pThis, IntPtr data, long maxlength, int remoteHandle, int tag);

		/// <summary>
		/// Convenience methods for receiving data arrays.
		/// </summary>
		// Token: 0x06012B79 RID: 76665 RVA: 0x001A5530 File Offset: 0x001A3730
		public int Receive(IntPtr data, long maxlength, int remoteHandle, int tag)
		{
			return vtkCommunicator.vtkCommunicator_Receive_45(base.GetCppThis(), data, maxlength, remoteHandle, tag);
		}

		// Token: 0x06012B7A RID: 76666
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_Receive_46(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string data, long maxlength, int remoteHandle, int tag);

		/// <summary>
		/// Convenience methods for receiving data arrays.
		/// </summary>
		// Token: 0x06012B7B RID: 76667 RVA: 0x001A5554 File Offset: 0x001A3754
		public int Receive(string data, long maxlength, int remoteHandle, int tag)
		{
			return vtkCommunicator.vtkCommunicator_Receive_46(base.GetCppThis(), data, maxlength, remoteHandle, tag);
		}

		// Token: 0x06012B7C RID: 76668
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCommunicator_ReceiveDataObject_47(HandleRef pThis, int remoteHandle, int tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The caller does not have to know the data type before this call is made.
		/// It returns the newly created object.
		/// </summary>
		// Token: 0x06012B7D RID: 76669 RVA: 0x001A5578 File Offset: 0x001A3778
		public vtkDataObject ReceiveDataObject(int remoteHandle, int tag)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCommunicator.vtkCommunicator_ReceiveDataObject_47(base.GetCppThis(), remoteHandle, tag, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x06012B7E RID: 76670
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_ReceiveVoidArray_48(HandleRef pThis, IntPtr data, long maxlength, int type, int remoteHandle, int tag);

		/// <summary>
		/// Subclasses have to supply this method to receive various arrays of data.
		/// The \c type arg is one of the VTK type constants recognized by the
		/// vtkTemplateMacro (VTK_FLOAT, VTK_INT, etc.).  \c maxlength is measured
		/// in number of values (as opposed to number of bytes) and is the maxmum
		/// length of the data to receive.  If the maxlength is less than the length
		/// of the message sent by the sender, an error will be flagged. Once a
		/// message is received, use the GetCount() method to determine the actual
		/// size of the data received.
		/// </summary>
		// Token: 0x06012B7F RID: 76671 RVA: 0x001A55EC File Offset: 0x001A37EC
		public virtual int ReceiveVoidArray(IntPtr data, long maxlength, int type, int remoteHandle, int tag)
		{
			return vtkCommunicator.vtkCommunicator_ReceiveVoidArray_48(base.GetCppThis(), data, maxlength, type, remoteHandle, tag);
		}

		// Token: 0x06012B80 RID: 76672
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_Reduce_49(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int operation, int destProcessId);

		/// <summary>
		/// Reduce an array to the given destination process.  This version of Reduce
		/// takes an identifier defined in the
		/// vtkCommunicator::StandardOperations enum to define the operation.
		/// </summary>
		// Token: 0x06012B81 RID: 76673 RVA: 0x001A5614 File Offset: 0x001A3814
		public int Reduce(IntPtr sendBuffer, IntPtr recvBuffer, long length, int operation, int destProcessId)
		{
			return vtkCommunicator.vtkCommunicator_Reduce_49(base.GetCppThis(), sendBuffer, recvBuffer, length, operation, destProcessId);
		}

		// Token: 0x06012B82 RID: 76674
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_Reduce_50(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string sendBuffer, [MarshalAs(UnmanagedType.LPUTF8Str)] string recvBuffer, long length, int operation, int destProcessId);

		/// <summary>
		/// Reduce an array to the given destination process.  This version of Reduce
		/// takes an identifier defined in the
		/// vtkCommunicator::StandardOperations enum to define the operation.
		/// </summary>
		// Token: 0x06012B83 RID: 76675 RVA: 0x001A563C File Offset: 0x001A383C
		public int Reduce(string sendBuffer, string recvBuffer, long length, int operation, int destProcessId)
		{
			return vtkCommunicator.vtkCommunicator_Reduce_50(base.GetCppThis(), sendBuffer, recvBuffer, length, operation, destProcessId);
		}

		// Token: 0x06012B84 RID: 76676
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_Reduce_51(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int operation, int destProcessId);

		/// <summary>
		/// Reduce an array to the given destination process.  This version of Reduce
		/// takes an identifier defined in the
		/// vtkCommunicator::StandardOperations enum to define the operation.
		/// </summary>
		// Token: 0x06012B85 RID: 76677 RVA: 0x001A5664 File Offset: 0x001A3864
		public int Reduce(vtkDataArray sendBuffer, vtkDataArray recvBuffer, int operation, int destProcessId)
		{
			return vtkCommunicator.vtkCommunicator_Reduce_51(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis(), operation, destProcessId);
		}

		// Token: 0x06012B86 RID: 76678
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_ReduceVoidArray_52(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int operation, int destProcessId);

		/// <summary>
		/// Subclasses should reimplement these if they have a more efficient
		/// implementation.
		/// </summary>
		// Token: 0x06012B87 RID: 76679 RVA: 0x001A56B0 File Offset: 0x001A38B0
		public virtual int ReduceVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int operation, int destProcessId)
		{
			return vtkCommunicator.vtkCommunicator_ReduceVoidArray_52(base.GetCppThis(), sendBuffer, recvBuffer, length, type, operation, destProcessId);
		}

		// Token: 0x06012B88 RID: 76680
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCommunicator_SafeDownCast_53(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012B89 RID: 76681 RVA: 0x001A56D8 File Offset: 0x001A38D8
		public new static vtkCommunicator SafeDownCast(vtkObjectBase o)
		{
			vtkCommunicator vtkCommunicator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCommunicator.vtkCommunicator_SafeDownCast_53((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCommunicator = (vtkCommunicator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCommunicator.Register(null);
				}
			}
			return vtkCommunicator;
		}

		// Token: 0x06012B8A RID: 76682
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_Scatter_54(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int srcProcessId);

		/// <summary>
		/// Scatter takes an array in the process with id \c srcProcessId and
		/// distributes it.  Each process (including the source) receives a portion of
		/// the send buffer.  Process 0 receives the first \c length values, process 1
		/// receives the second \c length values, and so on.  Scatter is the inverse
		/// operation of Gather.
		/// </summary>
		// Token: 0x06012B8B RID: 76683 RVA: 0x001A5758 File Offset: 0x001A3958
		public int Scatter(IntPtr sendBuffer, IntPtr recvBuffer, long length, int srcProcessId)
		{
			return vtkCommunicator.vtkCommunicator_Scatter_54(base.GetCppThis(), sendBuffer, recvBuffer, length, srcProcessId);
		}

		// Token: 0x06012B8C RID: 76684
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_Scatter_55(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string sendBuffer, [MarshalAs(UnmanagedType.LPUTF8Str)] string recvBuffer, long length, int srcProcessId);

		/// <summary>
		/// Scatter takes an array in the process with id \c srcProcessId and
		/// distributes it.  Each process (including the source) receives a portion of
		/// the send buffer.  Process 0 receives the first \c length values, process 1
		/// receives the second \c length values, and so on.  Scatter is the inverse
		/// operation of Gather.
		/// </summary>
		// Token: 0x06012B8D RID: 76685 RVA: 0x001A577C File Offset: 0x001A397C
		public int Scatter(string sendBuffer, string recvBuffer, long length, int srcProcessId)
		{
			return vtkCommunicator.vtkCommunicator_Scatter_55(base.GetCppThis(), sendBuffer, recvBuffer, length, srcProcessId);
		}

		// Token: 0x06012B8E RID: 76686
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_Scatter_56(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int srcProcessId);

		/// <summary>
		/// Scatter takes an array in the process with id \c srcProcessId and
		/// distributes it.  Each process (including the source) receives a portion of
		/// the send buffer.  Process 0 receives the first \c length values, process 1
		/// receives the second \c length values, and so on.  Scatter is the inverse
		/// operation of Gather.
		/// </summary>
		// Token: 0x06012B8F RID: 76687 RVA: 0x001A57A0 File Offset: 0x001A39A0
		public int Scatter(vtkDataArray sendBuffer, vtkDataArray recvBuffer, int srcProcessId)
		{
			return vtkCommunicator.vtkCommunicator_Scatter_56(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis(), srcProcessId);
		}

		// Token: 0x06012B90 RID: 76688
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_ScatterV_57(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int srcProcessId);

		/// <summary>
		/// ScatterV is the vector variant of Scatter.  It extends the functionality of
		/// Scatter by allowing a varying count of data to each process.
		/// ScatterV takes an array in the process with id \c srcProcessId and
		/// distributes it.  Each process (including the source) receives a portion of
		/// the send buffer defined by the \c sendLengths and \c offsets arrays.
		/// </summary>
		// Token: 0x06012B91 RID: 76689 RVA: 0x001A57EC File Offset: 0x001A39EC
		public int ScatterV(IntPtr sendBuffer, IntPtr recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int srcProcessId)
		{
			return vtkCommunicator.vtkCommunicator_ScatterV_57(base.GetCppThis(), sendBuffer, recvBuffer, sendLengths, offsets, recvLength, srcProcessId);
		}

		// Token: 0x06012B92 RID: 76690
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_ScatterV_58(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string sendBuffer, [MarshalAs(UnmanagedType.LPUTF8Str)] string recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int srcProcessId);

		/// <summary>
		/// ScatterV is the vector variant of Scatter.  It extends the functionality of
		/// Scatter by allowing a varying count of data to each process.
		/// ScatterV takes an array in the process with id \c srcProcessId and
		/// distributes it.  Each process (including the source) receives a portion of
		/// the send buffer defined by the \c sendLengths and \c offsets arrays.
		/// </summary>
		// Token: 0x06012B93 RID: 76691 RVA: 0x001A5814 File Offset: 0x001A3A14
		public int ScatterV(string sendBuffer, string recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int srcProcessId)
		{
			return vtkCommunicator.vtkCommunicator_ScatterV_58(base.GetCppThis(), sendBuffer, recvBuffer, sendLengths, offsets, recvLength, srcProcessId);
		}

		// Token: 0x06012B94 RID: 76692
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_ScatterVVoidArray_59(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int type, int srcProcessId);

		/// <summary>
		/// Subclasses should reimplement these if they have a more efficient
		/// implementation.
		/// </summary>
		// Token: 0x06012B95 RID: 76693 RVA: 0x001A583C File Offset: 0x001A3A3C
		public virtual int ScatterVVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int type, int srcProcessId)
		{
			return vtkCommunicator.vtkCommunicator_ScatterVVoidArray_59(base.GetCppThis(), sendBuffer, recvBuffer, sendLengths, offsets, recvLength, type, srcProcessId);
		}

		// Token: 0x06012B96 RID: 76694
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_ScatterVoidArray_60(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int srcProcessId);

		/// <summary>
		/// Subclasses should reimplement these if they have a more efficient
		/// implementation.
		/// </summary>
		// Token: 0x06012B97 RID: 76695 RVA: 0x001A5868 File Offset: 0x001A3A68
		public virtual int ScatterVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int srcProcessId)
		{
			return vtkCommunicator.vtkCommunicator_ScatterVoidArray_60(base.GetCppThis(), sendBuffer, recvBuffer, length, type, srcProcessId);
		}

		// Token: 0x06012B98 RID: 76696
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_Send_61(HandleRef pThis, HandleRef data, int remoteHandle, int tag);

		/// <summary>
		/// This method sends a data object to a destination.
		/// Tag eliminates ambiguity
		/// and is used to match sends to receives.
		/// </summary>
		// Token: 0x06012B99 RID: 76697 RVA: 0x001A5890 File Offset: 0x001A3A90
		public int Send(vtkDataObject data, int remoteHandle, int tag)
		{
			return vtkCommunicator.vtkCommunicator_Send_61(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), remoteHandle, tag);
		}

		// Token: 0x06012B9A RID: 76698
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_Send_62(HandleRef pThis, HandleRef data, int remoteHandle, int tag);

		/// <summary>
		/// This method sends a data array to a destination.
		/// Tag eliminates ambiguity
		/// and is used to match sends to receives.
		/// </summary>
		// Token: 0x06012B9B RID: 76699 RVA: 0x001A58C8 File Offset: 0x001A3AC8
		public int Send(vtkDataArray data, int remoteHandle, int tag)
		{
			return vtkCommunicator.vtkCommunicator_Send_62(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), remoteHandle, tag);
		}

		// Token: 0x06012B9C RID: 76700
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_Send_63(HandleRef pThis, IntPtr data, long length, int remoteHandle, int tag);

		/// <summary>
		/// Convenience methods for sending data arrays.
		/// </summary>
		// Token: 0x06012B9D RID: 76701 RVA: 0x001A5900 File Offset: 0x001A3B00
		public int Send(IntPtr data, long length, int remoteHandle, int tag)
		{
			return vtkCommunicator.vtkCommunicator_Send_63(base.GetCppThis(), data, length, remoteHandle, tag);
		}

		// Token: 0x06012B9E RID: 76702
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_Send_64(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string data, long length, int remoteHandle, int tag);

		/// <summary>
		/// Convenience methods for sending data arrays.
		/// </summary>
		// Token: 0x06012B9F RID: 76703 RVA: 0x001A5924 File Offset: 0x001A3B24
		public int Send(string data, long length, int remoteHandle, int tag)
		{
			return vtkCommunicator.vtkCommunicator_Send_64(base.GetCppThis(), data, length, remoteHandle, tag);
		}

		// Token: 0x06012BA0 RID: 76704
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_SendVoidArray_65(HandleRef pThis, IntPtr data, long length, int type, int remoteHandle, int tag);

		/// <summary>
		/// Subclasses have to supply this method to send various arrays of data.
		/// The \c type arg is one of the VTK type constants recognized by the
		/// vtkTemplateMacro (VTK_FLOAT, VTK_INT, etc.).  \c length is measured
		/// in number of values (as opposed to number of bytes).
		/// </summary>
		// Token: 0x06012BA1 RID: 76705 RVA: 0x001A5948 File Offset: 0x001A3B48
		public virtual int SendVoidArray(IntPtr data, long length, int type, int remoteHandle, int tag)
		{
			return vtkCommunicator.vtkCommunicator_SendVoidArray_65(base.GetCppThis(), data, length, type, remoteHandle, tag);
		}

		// Token: 0x06012BA2 RID: 76706
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCommunicator_SetNumberOfProcesses_66(HandleRef pThis, int num);

		/// <summary>
		/// Set the number of processes you will be using.  This defaults
		/// to the maximum number available.  If you set this to a value
		/// higher than the default, you will get an error.
		/// </summary>
		// Token: 0x06012BA3 RID: 76707 RVA: 0x001A596E File Offset: 0x001A3B6E
		public virtual void SetNumberOfProcesses(int num)
		{
			vtkCommunicator.vtkCommunicator_SetNumberOfProcesses_66(base.GetCppThis(), num);
		}

		// Token: 0x06012BA4 RID: 76708
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCommunicator_SetUseCopy_67(int useCopy);

		/// <summary>
		/// Blocking test for checking for a message tagged with tag from source process (if
		/// source == ANY_SOURCE check for any message). Rank in actualSource is rank sending
		/// a message.
		///
		/// Check if implemented in this communicator using the CanProbe method before using.
		///
		/// Returns 1 on success and 0 on failure.
		/// </summary>
		// Token: 0x06012BA5 RID: 76709 RVA: 0x001A597E File Offset: 0x001A3B7E
		public static void SetUseCopy(int useCopy)
		{
			vtkCommunicator.vtkCommunicator_SetUseCopy_67(useCopy);
		}

		// Token: 0x06012BA6 RID: 76710
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCommunicator_UnMarshalDataObject_68(HandleRef buffer, HandleRef arg1);

		/// <summary>
		/// Convert a data object into a string that can be transmitted and vice versa.
		/// Returns 1 for success and 0 for failure.
		/// WARNING: This will only work for types that have a vtkDataWriter class.
		/// </summary>
		// Token: 0x06012BA7 RID: 76711 RVA: 0x001A5988 File Offset: 0x001A3B88
		public static int UnMarshalDataObject(vtkCharArray buffer, vtkDataObject arg1)
		{
			return vtkCommunicator.vtkCommunicator_UnMarshalDataObject_68((buffer == null) ? default(HandleRef) : buffer.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400158E RID: 5518
		public new const string MRFullTypeName = "Kitware.VTK.vtkCommunicator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400158F RID: 5519
		public new static readonly string MRClassNameKey = "class vtkCommunicator";

		/// <summary>
		/// Tells you which process [0, NumProcess) you are in.
		/// </summary>
		// Token: 0x020006EF RID: 1775
		public enum StandardOperations
		{
			/// <summary>enum member</summary>
			// Token: 0x04001591 RID: 5521
			BITWISE_AND_OP = 5,
			/// <summary>enum member</summary>
			// Token: 0x04001592 RID: 5522
			BITWISE_OR_OP = 7,
			/// <summary>enum member</summary>
			// Token: 0x04001593 RID: 5523
			BITWISE_XOR_OP = 9,
			/// <summary>enum member</summary>
			// Token: 0x04001594 RID: 5524
			LOGICAL_AND_OP = 4,
			/// <summary>enum member</summary>
			// Token: 0x04001595 RID: 5525
			LOGICAL_OR_OP = 6,
			/// <summary>enum member</summary>
			// Token: 0x04001596 RID: 5526
			LOGICAL_XOR_OP = 8,
			/// <summary>enum member</summary>
			// Token: 0x04001597 RID: 5527
			MAX_OP = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001598 RID: 5528
			MIN_OP,
			/// <summary>enum member</summary>
			// Token: 0x04001599 RID: 5529
			PRODUCT_OP = 3,
			/// <summary>enum member</summary>
			// Token: 0x0400159A RID: 5530
			SUM_OP = 2
		}

		/// <summary>
		/// Tells you which process [0, NumProcess) you are in.
		/// </summary>
		// Token: 0x020006F0 RID: 1776
		public enum Tags
		{
			/// <summary>enum member</summary>
			// Token: 0x0400159C RID: 5532
			BARRIER_TAG = 16,
			/// <summary>enum member</summary>
			// Token: 0x0400159D RID: 5533
			BROADCAST_TAG = 10,
			/// <summary>enum member</summary>
			// Token: 0x0400159E RID: 5534
			GATHERV_TAG = 12,
			/// <summary>enum member</summary>
			// Token: 0x0400159F RID: 5535
			GATHER_TAG = 11,
			/// <summary>enum member</summary>
			// Token: 0x040015A0 RID: 5536
			REDUCE_TAG = 15,
			/// <summary>enum member</summary>
			// Token: 0x040015A1 RID: 5537
			SCATTERV_TAG = 14,
			/// <summary>enum member</summary>
			// Token: 0x040015A2 RID: 5538
			SCATTER_TAG = 13
		}
	}
}
