using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMultiProcessController
	/// </summary>
	/// <remarks>
	///    Multiprocessing communication superclass
	///
	/// vtkMultiProcessController is used to control multiple processes
	/// in a distributed computing environment. It has
	/// methods for executing single/multiple method(s) on multiple processors,
	/// triggering registered callbacks (Remote Methods) (AddRMI(), TriggerRMI())
	/// and communication. Please note that the communication is done using
	/// the communicator which is accessible to the user. Therefore it is
	/// possible to get the communicator with GetCommunicator() and use
	/// it to send and receive data. This is the encouraged communication method.
	/// The internal (RMI) communications are done using a second internal
	/// communicator (called RMICommunicator).
	///
	/// There are two modes for RMI communication: (1) Send/Receive mode and
	/// (2) Broadcast (collective) mode. The Send/Receive mode arranges processes
	/// in a binary tree using post-order traversal and propagates the RMI trigger
	/// starting from the root (rank 0) to the children. It is commonly employed to
	/// communicate between client/server over TCP. Although, the Send/Receive mode
	/// can be employed transparently over TCP or MPI, it is not optimal for
	/// triggering the RMIs on the satellite ranks. The Broadcast mode provides a
	/// more desirable alternative, namely, it uses MPI_Broadcast for communication,
	/// which is the nominal way of achieving this in an MPI context. The underlying
	/// communication mode used for triggering RMIs is controlled by the
	/// "BroadcastTriggerRMI" variable. Note, that mixing between the two modes
	/// for RMI communication is not correct behavior. All processes within the
	/// vtkMultiProcessController must use the same mode for triggering RMI.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkMPIController
	/// vtkCommunicator vtkMPICommunicator
	/// </seealso>
	// Token: 0x020006F2 RID: 1778
	public abstract class vtkMultiProcessController : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012BBE RID: 76734 RVA: 0x001A5C4A File Offset: 0x001A3E4A
		static vtkMultiProcessController()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMultiProcessController.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiProcessController"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012BBF RID: 76735 RVA: 0x001A5C72 File Offset: 0x001A3E72
		public vtkMultiProcessController(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012BC0 RID: 76736 RVA: 0x001A5C80 File Offset: 0x001A3E80
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012BC1 RID: 76737
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_AllGather_01(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length);

		/// <summary>
		/// Same as gather except that the result ends up on all processes.
		/// </summary>
		// Token: 0x06012BC2 RID: 76738 RVA: 0x001A5C8C File Offset: 0x001A3E8C
		public int AllGather(IntPtr sendBuffer, IntPtr recvBuffer, long length)
		{
			return vtkMultiProcessController.vtkMultiProcessController_AllGather_01(base.GetCppThis(), sendBuffer, recvBuffer, length);
		}

		// Token: 0x06012BC3 RID: 76739
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_AllGather_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string sendBuffer, [MarshalAs(UnmanagedType.LPUTF8Str)] string recvBuffer, long length);

		/// <summary>
		/// Same as gather except that the result ends up on all processes.
		/// </summary>
		// Token: 0x06012BC4 RID: 76740 RVA: 0x001A5CB0 File Offset: 0x001A3EB0
		public int AllGather(string sendBuffer, string recvBuffer, long length)
		{
			return vtkMultiProcessController.vtkMultiProcessController_AllGather_02(base.GetCppThis(), sendBuffer, recvBuffer, length);
		}

		// Token: 0x06012BC5 RID: 76741
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_AllGather_03(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer);

		/// <summary>
		/// Same as gather except that the result ends up on all processes.
		/// </summary>
		// Token: 0x06012BC6 RID: 76742 RVA: 0x001A5CD4 File Offset: 0x001A3ED4
		public int AllGather(vtkDataArray sendBuffer, vtkDataArray recvBuffer)
		{
			return vtkMultiProcessController.vtkMultiProcessController_AllGather_03(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis());
		}

		// Token: 0x06012BC7 RID: 76743
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_AllGatherV_04(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets);

		/// <summary>
		/// Same as GatherV except that the result is placed in all processes.
		/// </summary>
		// Token: 0x06012BC8 RID: 76744 RVA: 0x001A5D20 File Offset: 0x001A3F20
		public int AllGatherV(IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets)
		{
			return vtkMultiProcessController.vtkMultiProcessController_AllGatherV_04(base.GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets);
		}

		// Token: 0x06012BC9 RID: 76745
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_AllGatherV_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string sendBuffer, [MarshalAs(UnmanagedType.LPUTF8Str)] string recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets);

		/// <summary>
		/// Same as GatherV except that the result is placed in all processes.
		/// </summary>
		// Token: 0x06012BCA RID: 76746 RVA: 0x001A5D48 File Offset: 0x001A3F48
		public int AllGatherV(string sendBuffer, string recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets)
		{
			return vtkMultiProcessController.vtkMultiProcessController_AllGatherV_05(base.GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets);
		}

		// Token: 0x06012BCB RID: 76747
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_AllGatherV_06(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, IntPtr recvLengths, IntPtr offsets);

		/// <summary>
		/// Same as GatherV except that the result is placed in all processes.
		/// </summary>
		// Token: 0x06012BCC RID: 76748 RVA: 0x001A5D70 File Offset: 0x001A3F70
		public int AllGatherV(vtkDataArray sendBuffer, vtkDataArray recvBuffer, IntPtr recvLengths, IntPtr offsets)
		{
			return vtkMultiProcessController.vtkMultiProcessController_AllGatherV_06(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis(), recvLengths, offsets);
		}

		// Token: 0x06012BCD RID: 76749
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_AllGatherV_07(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer);

		/// <summary>
		/// This special form of AllGatherV will automatically determine \c recvLengths
		/// and \c offsets to tightly pack the data in the \c recvBuffer in process
		/// order.  It will also resize \c recvBuffer in order to accommodate the
		/// incoming data (unlike the other GatherV variants).
		/// </summary>
		// Token: 0x06012BCE RID: 76750 RVA: 0x001A5DBC File Offset: 0x001A3FBC
		public int AllGatherV(vtkDataArray sendBuffer, vtkDataArray recvBuffer)
		{
			return vtkMultiProcessController.vtkMultiProcessController_AllGatherV_07(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis());
		}

		// Token: 0x06012BCF RID: 76751
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_AllReduce_08(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int operation);

		/// <summary>
		/// Same as Reduce except that the result is placed in all of the processes.
		/// </summary>
		// Token: 0x06012BD0 RID: 76752 RVA: 0x001A5E08 File Offset: 0x001A4008
		public int AllReduce(IntPtr sendBuffer, IntPtr recvBuffer, long length, int operation)
		{
			return vtkMultiProcessController.vtkMultiProcessController_AllReduce_08(base.GetCppThis(), sendBuffer, recvBuffer, length, operation);
		}

		// Token: 0x06012BD1 RID: 76753
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_AllReduce_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string sendBuffer, [MarshalAs(UnmanagedType.LPUTF8Str)] string recvBuffer, long length, int operation);

		/// <summary>
		/// Same as Reduce except that the result is placed in all of the processes.
		/// </summary>
		// Token: 0x06012BD2 RID: 76754 RVA: 0x001A5E2C File Offset: 0x001A402C
		public int AllReduce(string sendBuffer, string recvBuffer, long length, int operation)
		{
			return vtkMultiProcessController.vtkMultiProcessController_AllReduce_09(base.GetCppThis(), sendBuffer, recvBuffer, length, operation);
		}

		// Token: 0x06012BD3 RID: 76755
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_AllReduce_10(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int operation);

		/// <summary>
		/// Same as Reduce except that the result is placed in all of the processes.
		/// </summary>
		// Token: 0x06012BD4 RID: 76756 RVA: 0x001A5E50 File Offset: 0x001A4050
		public int AllReduce(vtkDataArray sendBuffer, vtkDataArray recvBuffer, int operation)
		{
			return vtkMultiProcessController.vtkMultiProcessController_AllReduce_10(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis(), operation);
		}

		// Token: 0x06012BD5 RID: 76757
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_AllReduce_11(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer);

		/// <summary>
		/// Convenience methods to reduce vtkDataArraySelection.
		/// </summary>
		// Token: 0x06012BD6 RID: 76758 RVA: 0x001A5E9C File Offset: 0x001A409C
		public int AllReduce(vtkDataArraySelection sendBuffer, vtkDataArraySelection recvBuffer)
		{
			return vtkMultiProcessController.vtkMultiProcessController_AllReduce_11(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis());
		}

		// Token: 0x06012BD7 RID: 76759
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiProcessController_Barrier_12(HandleRef pThis);

		/// <summary>
		/// This method can be used to synchronize processes.
		/// </summary>
		// Token: 0x06012BD8 RID: 76760 RVA: 0x001A5EE5 File Offset: 0x001A40E5
		public void Barrier()
		{
			vtkMultiProcessController.vtkMultiProcessController_Barrier_12(base.GetCppThis());
		}

		// Token: 0x06012BD9 RID: 76761
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_Broadcast_13(HandleRef pThis, IntPtr data, long length, int srcProcessId);

		/// <summary>
		/// Broadcast sends the array in the process with id \c srcProcessId to all of
		/// the other processes.  All processes must call these method with the same
		/// arguments in order for it to complete.
		/// </summary>
		// Token: 0x06012BDA RID: 76762 RVA: 0x001A5EF4 File Offset: 0x001A40F4
		public int Broadcast(IntPtr data, long length, int srcProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Broadcast_13(base.GetCppThis(), data, length, srcProcessId);
		}

		// Token: 0x06012BDB RID: 76763
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_Broadcast_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string data, long length, int srcProcessId);

		/// <summary>
		/// Broadcast sends the array in the process with id \c srcProcessId to all of
		/// the other processes.  All processes must call these method with the same
		/// arguments in order for it to complete.
		/// </summary>
		// Token: 0x06012BDC RID: 76764 RVA: 0x001A5F18 File Offset: 0x001A4118
		public int Broadcast(string data, long length, int srcProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Broadcast_14(base.GetCppThis(), data, length, srcProcessId);
		}

		// Token: 0x06012BDD RID: 76765
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_Broadcast_15(HandleRef pThis, HandleRef data, int srcProcessId);

		/// <summary>
		/// Broadcast sends the array in the process with id \c srcProcessId to all of
		/// the other processes.  All processes must call these method with the same
		/// arguments in order for it to complete.
		/// </summary>
		// Token: 0x06012BDE RID: 76766 RVA: 0x001A5F3C File Offset: 0x001A413C
		public int Broadcast(vtkDataObject data, int srcProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Broadcast_15(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), srcProcessId);
		}

		// Token: 0x06012BDF RID: 76767
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_Broadcast_16(HandleRef pThis, HandleRef data, int srcProcessId);

		/// <summary>
		/// Broadcast sends the array in the process with id \c srcProcessId to all of
		/// the other processes.  All processes must call these method with the same
		/// arguments in order for it to complete.
		/// </summary>
		// Token: 0x06012BE0 RID: 76768 RVA: 0x001A5F74 File Offset: 0x001A4174
		public int Broadcast(vtkDataArray data, int srcProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Broadcast_16(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), srcProcessId);
		}

		// Token: 0x06012BE1 RID: 76769
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_BroadcastProcessRMIs_17(HandleRef pThis, int reportErrors, int dont_loop);

		/// <summary>
		/// Calling this method gives control to the controller to start
		/// processing RMIs. Possible return values are:
		/// RMI_NO_ERROR,
		/// RMI_TAG_ERROR : rmi tag could not be received,
		/// RMI_ARG_ERROR : rmi arg could not be received.
		/// If reportErrors is false, no vtkErrorMacro is called.
		/// ProcessRMIs() calls ProcessRMIs(int) with reportErrors = 0.
		/// If dont_loop is 1, this call just process one RMI message
		/// and exits.
		/// </summary>
		// Token: 0x06012BE2 RID: 76770 RVA: 0x001A5FAC File Offset: 0x001A41AC
		public int BroadcastProcessRMIs(int reportErrors, int dont_loop)
		{
			return vtkMultiProcessController.vtkMultiProcessController_BroadcastProcessRMIs_17(base.GetCppThis(), reportErrors, dont_loop);
		}

		// Token: 0x06012BE3 RID: 76771
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiProcessController_BroadcastTriggerRMIOff_18(HandleRef pThis);

		/// <summary>
		/// Setting this flag to 1 will cause the TriggerRMIOnAllChildren to use
		/// a collective broadcast operation to communicate the RMI tag to the
		/// satellites.
		/// </summary>
		// Token: 0x06012BE4 RID: 76772 RVA: 0x001A5FCD File Offset: 0x001A41CD
		public virtual void BroadcastTriggerRMIOff()
		{
			vtkMultiProcessController.vtkMultiProcessController_BroadcastTriggerRMIOff_18(base.GetCppThis());
		}

		// Token: 0x06012BE5 RID: 76773
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiProcessController_BroadcastTriggerRMIOn_19(HandleRef pThis);

		/// <summary>
		/// Setting this flag to 1 will cause the TriggerRMIOnAllChildren to use
		/// a collective broadcast operation to communicate the RMI tag to the
		/// satellites.
		/// </summary>
		// Token: 0x06012BE6 RID: 76774 RVA: 0x001A5FDC File Offset: 0x001A41DC
		public virtual void BroadcastTriggerRMIOn()
		{
			vtkMultiProcessController.vtkMultiProcessController_BroadcastTriggerRMIOn_19(base.GetCppThis());
		}

		// Token: 0x06012BE7 RID: 76775
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiProcessController_BroadcastTriggerRMIOnAllChildren_20(HandleRef pThis, IntPtr arg, int argLength, int tag);

		/// <summary>
		/// This is a convenicence method to trigger an RMI call on all the "children"
		/// of the current node. The children of the current node can be determined by
		/// drawing a binary tree starting at node 0 and then assigned nodes ids
		/// incrementally in a breadth-first fashion from left to right. This is
		/// designed to be used when trigger an RMI call on all satellites from the
		/// root node.
		/// </summary>
		// Token: 0x06012BE8 RID: 76776 RVA: 0x001A5FEB File Offset: 0x001A41EB
		public void BroadcastTriggerRMIOnAllChildren(IntPtr arg, int argLength, int tag)
		{
			vtkMultiProcessController.vtkMultiProcessController_BroadcastTriggerRMIOnAllChildren_20(base.GetCppThis(), arg, argLength, tag);
		}

		// Token: 0x06012BE9 RID: 76777
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMultiProcessController_CanProbe_21(HandleRef pThis);

		/// <summary>
		/// Check if this controller implements a probe operation
		/// </summary>
		// Token: 0x06012BEA RID: 76778 RVA: 0x001A6000 File Offset: 0x001A4200
		public virtual bool CanProbe()
		{
			return vtkMultiProcessController.vtkMultiProcessController_CanProbe_21(base.GetCppThis()) != 0;
		}

		// Token: 0x06012BEB RID: 76779
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiProcessController_CreateOutputWindow_22(HandleRef pThis);

		/// <summary>
		/// This method can be used to tell the controller to create
		/// a special output window in which all messages are preceded
		/// by the process id.
		/// </summary>
		// Token: 0x06012BEC RID: 76780 RVA: 0x001A6026 File Offset: 0x001A4226
		public virtual void CreateOutputWindow()
		{
			vtkMultiProcessController.vtkMultiProcessController_CreateOutputWindow_22(base.GetCppThis());
		}

		// Token: 0x06012BED RID: 76781
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiProcessController_CreateSubController_23(HandleRef pThis, HandleRef group, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a new controller with the processes specified by the given group.
		/// The new controller will already be initialized for you.  You are
		/// responsible for deleting the controller once you are done.  It is invalid
		/// to pass this method a group with a different communicator than is used by
		/// this controller.  This operation is collective across all processes
		/// defined in the group.  It is undefined what will happen if the group is not
		/// the same on all processes.  This method must be called by all processes in
		/// the controller regardless of whether they are in the group.  nullptr is
		/// returned on all process not in the group.
		/// </summary>
		// Token: 0x06012BEE RID: 76782 RVA: 0x001A6038 File Offset: 0x001A4238
		public virtual vtkMultiProcessController CreateSubController(vtkProcessGroup group)
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiProcessController.vtkMultiProcessController_CreateSubController_23(base.GetCppThis(), (group == null) ? default(HandleRef) : group.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		// Token: 0x06012BEF RID: 76783
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiProcessController_Finalize_24(HandleRef pThis);

		/// <summary>
		/// This method is for cleaning up.
		/// If a subclass needs to clean up process communication (i.e. MPI)
		/// it would over ride this method.
		/// </summary>
		// Token: 0x06012BF0 RID: 76784 RVA: 0x001A60BD File Offset: 0x001A42BD
		public virtual void FinalizeWrapper()
		{
			vtkMultiProcessController.vtkMultiProcessController_Finalize_24(base.GetCppThis());
		}

		// Token: 0x06012BF1 RID: 76785
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiProcessController_Finalize_25(HandleRef pThis, int finalizedExternally);

		/// <summary>
		/// This method is for cleaning up.
		/// If a subclass needs to clean up process communication (i.e. MPI)
		/// it would over ride this method.  Provided for finalization outside vtk.
		/// </summary>
		// Token: 0x06012BF2 RID: 76786 RVA: 0x001A60CC File Offset: 0x001A42CC
		public virtual void FinalizeWrapper(int finalizedExternally)
		{
			vtkMultiProcessController.vtkMultiProcessController_Finalize_25(base.GetCppThis(), finalizedExternally);
		}

		// Token: 0x06012BF3 RID: 76787
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_Gather_26(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int destProcessId);

		/// <summary>
		/// Gather collects arrays in the process with id \c destProcessId.  Each
		/// process (including the destination) sends the contents of its send buffer
		/// to the destination process.  The destination process receives the
		/// messages and stores them in rank order.  The \c length argument
		/// (which must be the same on all processes) is the length of the
		/// sendBuffers.  The \c recvBuffer (on the destination process) must be of
		/// length length*numProcesses.  Gather is the inverse operation of Scatter.
		/// </summary>
		// Token: 0x06012BF4 RID: 76788 RVA: 0x001A60DC File Offset: 0x001A42DC
		public int Gather(IntPtr sendBuffer, IntPtr recvBuffer, long length, int destProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Gather_26(base.GetCppThis(), sendBuffer, recvBuffer, length, destProcessId);
		}

		// Token: 0x06012BF5 RID: 76789
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_Gather_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string sendBuffer, [MarshalAs(UnmanagedType.LPUTF8Str)] string recvBuffer, long length, int destProcessId);

		/// <summary>
		/// Gather collects arrays in the process with id \c destProcessId.  Each
		/// process (including the destination) sends the contents of its send buffer
		/// to the destination process.  The destination process receives the
		/// messages and stores them in rank order.  The \c length argument
		/// (which must be the same on all processes) is the length of the
		/// sendBuffers.  The \c recvBuffer (on the destination process) must be of
		/// length length*numProcesses.  Gather is the inverse operation of Scatter.
		/// </summary>
		// Token: 0x06012BF6 RID: 76790 RVA: 0x001A6100 File Offset: 0x001A4300
		public int Gather(string sendBuffer, string recvBuffer, long length, int destProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Gather_27(base.GetCppThis(), sendBuffer, recvBuffer, length, destProcessId);
		}

		// Token: 0x06012BF7 RID: 76791
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_Gather_28(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int destProcessId);

		/// <summary>
		/// Gather collects arrays in the process with id \c destProcessId.  Each
		/// process (including the destination) sends the contents of its send buffer
		/// to the destination process.  The destination process receives the
		/// messages and stores them in rank order.  The \c length argument
		/// (which must be the same on all processes) is the length of the
		/// sendBuffers.  The \c recvBuffer (on the destination process) must be of
		/// length length*numProcesses.  Gather is the inverse operation of Scatter.
		/// </summary>
		// Token: 0x06012BF8 RID: 76792 RVA: 0x001A6124 File Offset: 0x001A4324
		public int Gather(vtkDataArray sendBuffer, vtkDataArray recvBuffer, int destProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Gather_28(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis(), destProcessId);
		}

		// Token: 0x06012BF9 RID: 76793
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_GatherV_29(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int destProcessId);

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
		// Token: 0x06012BFA RID: 76794 RVA: 0x001A6170 File Offset: 0x001A4370
		public int GatherV(IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int destProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_GatherV_29(base.GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets, destProcessId);
		}

		// Token: 0x06012BFB RID: 76795
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_GatherV_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string sendBuffer, [MarshalAs(UnmanagedType.LPUTF8Str)] string recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int destProcessId);

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
		// Token: 0x06012BFC RID: 76796 RVA: 0x001A6198 File Offset: 0x001A4398
		public int GatherV(string sendBuffer, string recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int destProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_GatherV_30(base.GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets, destProcessId);
		}

		// Token: 0x06012BFD RID: 76797
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_GatherV_31(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, IntPtr recvLengths, IntPtr offsets, int destProcessId);

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
		// Token: 0x06012BFE RID: 76798 RVA: 0x001A61C0 File Offset: 0x001A43C0
		public int GatherV(vtkDataArray sendBuffer, vtkDataArray recvBuffer, IntPtr recvLengths, IntPtr offsets, int destProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_GatherV_31(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis(), recvLengths, offsets, destProcessId);
		}

		// Token: 0x06012BFF RID: 76799
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_GatherV_32(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, HandleRef recvLengths, HandleRef offsets, int destProcessId);

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
		// Token: 0x06012C00 RID: 76800 RVA: 0x001A6210 File Offset: 0x001A4410
		public int GatherV(vtkDataArray sendBuffer, vtkDataArray recvBuffer, vtkIdTypeArray recvLengths, vtkIdTypeArray offsets, int destProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_GatherV_32(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis(), (recvLengths == null) ? default(HandleRef) : recvLengths.GetCppThis(), (offsets == null) ? default(HandleRef) : offsets.GetCppThis(), destProcessId);
		}

		// Token: 0x06012C01 RID: 76801
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_GatherV_33(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int destProcessId);

		/// <summary>
		/// This special form of GatherV will automatically determine \c recvLengths
		/// and \c offsets to tightly pack the data in the \c recvBuffer in process
		/// order.  It will also resize \c recvBuffer in order to accommodate the
		/// incoming data (unlike the other GatherV variants).
		/// </summary>
		// Token: 0x06012C02 RID: 76802 RVA: 0x001A6288 File Offset: 0x001A4488
		public int GatherV(vtkDataArray sendBuffer, vtkDataArray recvBuffer, int destProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_GatherV_33(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis(), destProcessId);
		}

		// Token: 0x06012C03 RID: 76803
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_GetBreakFlag_34(HandleRef pThis);

		/// <summary>
		/// Setting this flag to 1 will cause the ProcessRMIs loop to return.
		/// This also causes vtkUpStreamPorts to return from
		/// their WaitForUpdate loops.
		/// </summary>
		// Token: 0x06012C04 RID: 76804 RVA: 0x001A62D4 File Offset: 0x001A44D4
		public virtual int GetBreakFlag()
		{
			return vtkMultiProcessController.vtkMultiProcessController_GetBreakFlag_34(base.GetCppThis());
		}

		// Token: 0x06012C05 RID: 76805
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_GetBreakRMITag_35();

		/// <summary>
		/// Accessor to some default tags.
		/// </summary>
		// Token: 0x06012C06 RID: 76806 RVA: 0x001A62F4 File Offset: 0x001A44F4
		public static int GetBreakRMITag()
		{
			return vtkMultiProcessController.vtkMultiProcessController_GetBreakRMITag_35();
		}

		// Token: 0x06012C07 RID: 76807
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMultiProcessController_GetBroadcastTriggerRMI_36(HandleRef pThis);

		/// <summary>
		/// Setting this flag to 1 will cause the TriggerRMIOnAllChildren to use
		/// a collective broadcast operation to communicate the RMI tag to the
		/// satellites.
		/// </summary>
		// Token: 0x06012C08 RID: 76808 RVA: 0x001A6310 File Offset: 0x001A4510
		public virtual bool GetBroadcastTriggerRMI()
		{
			return vtkMultiProcessController.vtkMultiProcessController_GetBroadcastTriggerRMI_36(base.GetCppThis()) != 0;
		}

		// Token: 0x06012C09 RID: 76809
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiProcessController_GetCommunicator_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the communicator associated with this controller.
		/// A default communicator is created in constructor.
		/// </summary>
		// Token: 0x06012C0A RID: 76810 RVA: 0x001A6338 File Offset: 0x001A4538
		public virtual vtkCommunicator GetCommunicator()
		{
			vtkCommunicator vtkCommunicator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiProcessController.vtkMultiProcessController_GetCommunicator_37(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012C0B RID: 76811
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiProcessController_GetCount_38(HandleRef pThis);

		/// <summary>
		/// Returns the number of words received by the most recent Receive().
		/// Note that this is not the number of bytes received, but the number of items
		/// of the data-type received by the most recent Receive() eg. if
		/// Receive(int*,..) was used, then this returns the number of ints received;
		/// if Receive(double*,..) was used, then this returns the number of doubles
		/// received etc. The return value is valid only after a successful Receive().
		/// </summary>
		// Token: 0x06012C0C RID: 76812 RVA: 0x001A63A8 File Offset: 0x001A45A8
		public long GetCount()
		{
			return vtkMultiProcessController.vtkMultiProcessController_GetCount_38(base.GetCppThis());
		}

		// Token: 0x06012C0D RID: 76813
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiProcessController_GetGlobalController_39(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This convenience method returns the controller associated with the
		/// local process.  It returns nullptr until the processes are spawned.
		/// It is better if you hang on to the controller passed as an argument to the
		/// SingleMethod or MultipleMethod functions.
		/// </summary>
		// Token: 0x06012C0E RID: 76814 RVA: 0x001A63C8 File Offset: 0x001A45C8
		public static vtkMultiProcessController GetGlobalController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiProcessController.vtkMultiProcessController_GetGlobalController_39(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		// Token: 0x06012C0F RID: 76815
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_GetLocalProcessId_40(HandleRef pThis);

		/// <summary>
		/// Tells you which process [0, NumProcess) you are in.
		/// </summary>
		// Token: 0x06012C10 RID: 76816 RVA: 0x001A6434 File Offset: 0x001A4634
		public int GetLocalProcessId()
		{
			return vtkMultiProcessController.vtkMultiProcessController_GetLocalProcessId_40(base.GetCppThis());
		}

		// Token: 0x06012C11 RID: 76817
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiProcessController_GetNumberOfGenerationsFromBase_41(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012C12 RID: 76818 RVA: 0x001A6454 File Offset: 0x001A4654
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMultiProcessController.vtkMultiProcessController_GetNumberOfGenerationsFromBase_41(base.GetCppThis(), type);
		}

		// Token: 0x06012C13 RID: 76819
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMultiProcessController_GetNumberOfGenerationsFromBaseType_42([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012C14 RID: 76820 RVA: 0x001A6474 File Offset: 0x001A4674
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMultiProcessController.vtkMultiProcessController_GetNumberOfGenerationsFromBaseType_42(type);
		}

		// Token: 0x06012C15 RID: 76821
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_GetNumberOfProcesses_43(HandleRef pThis);

		/// <summary>
		/// Set the number of processes you will be using.  This defaults
		/// to the maximum number available.  If you set this to a value
		/// higher than the default, you will get an error.
		/// </summary>
		// Token: 0x06012C16 RID: 76822 RVA: 0x001A6490 File Offset: 0x001A4690
		public int GetNumberOfProcesses()
		{
			return vtkMultiProcessController.vtkMultiProcessController_GetNumberOfProcesses_43(base.GetCppThis());
		}

		// Token: 0x06012C17 RID: 76823
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_GetRMIArgTag_44();

		/// <summary>
		/// Accessor to some default tags.
		/// </summary>
		// Token: 0x06012C18 RID: 76824 RVA: 0x001A64B0 File Offset: 0x001A46B0
		public static int GetRMIArgTag()
		{
			return vtkMultiProcessController.vtkMultiProcessController_GetRMIArgTag_44();
		}

		// Token: 0x06012C19 RID: 76825
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_GetRMITag_45();

		/// <summary>
		/// Accessor to some default tags.
		/// </summary>
		// Token: 0x06012C1A RID: 76826 RVA: 0x001A64CC File Offset: 0x001A46CC
		public static int GetRMITag()
		{
			return vtkMultiProcessController.vtkMultiProcessController_GetRMITag_45();
		}

		// Token: 0x06012C1B RID: 76827
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_IsA_46(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012C1C RID: 76828 RVA: 0x001A64E8 File Offset: 0x001A46E8
		public override int IsA(string type)
		{
			return vtkMultiProcessController.vtkMultiProcessController_IsA_46(base.GetCppThis(), type);
		}

		// Token: 0x06012C1D RID: 76829
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_IsTypeOf_47([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012C1E RID: 76830 RVA: 0x001A6508 File Offset: 0x001A4708
		public new static int IsTypeOf(string type)
		{
			return vtkMultiProcessController.vtkMultiProcessController_IsTypeOf_47(type);
		}

		// Token: 0x06012C1F RID: 76831
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiProcessController_MultipleMethodExecute_48(HandleRef pThis);

		/// <summary>
		/// Execute the MultipleMethods (as define by calling SetMultipleMethod
		/// for each of the required this-&gt;NumberOfProcesses methods) using
		/// this-&gt;NumberOfProcesses processes.
		/// </summary>
		// Token: 0x06012C20 RID: 76832 RVA: 0x001A6522 File Offset: 0x001A4722
		public virtual void MultipleMethodExecute()
		{
			vtkMultiProcessController.vtkMultiProcessController_MultipleMethodExecute_48(base.GetCppThis());
		}

		// Token: 0x06012C21 RID: 76833
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiProcessController_NewInstance_49(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012C22 RID: 76834 RVA: 0x001A6534 File Offset: 0x001A4734
		public new vtkMultiProcessController NewInstance()
		{
			vtkMultiProcessController result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiProcessController.vtkMultiProcessController_NewInstance_49(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012C23 RID: 76835
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiProcessController_PartitionController_50(HandleRef pThis, int localColor, int localKey, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Partitions this controller based on a coloring.  That is, each process
		/// passes in a color.  All processes with the same color are grouped into the
		/// same partition.  The processes are ordered by their self-assigned key.
		/// Lower keys have lower process ids.  Ties are broken by the current process
		/// ids.  (For example, if all the keys are 0, then the resulting processes
		/// will be ordered in the same way.)  This method returns a new controller to
		/// each process that represents the local partition.  This is basically the
		/// same operation as MPI_Comm_split.
		/// </summary>
		// Token: 0x06012C24 RID: 76836 RVA: 0x001A6590 File Offset: 0x001A4790
		public virtual vtkMultiProcessController PartitionController(int localColor, int localKey)
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiProcessController.vtkMultiProcessController_PartitionController_50(base.GetCppThis(), localColor, localKey, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		// Token: 0x06012C25 RID: 76837
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_Probe_51(HandleRef pThis, int source, int tag, IntPtr actualSource);

		/// <summary>
		/// Blocking test for checking for a message tagged with tag from source process (if
		/// source == ANY_SOURCE check for any message). Rank in actualSource is rank sending
		/// a message.
		///
		/// Check if implemented in the current communicator using the CanProbe method before
		/// using.
		///
		/// Returns 1 on success and 0 on failure.
		/// </summary>
		// Token: 0x06012C26 RID: 76838 RVA: 0x001A6604 File Offset: 0x001A4804
		public virtual int Probe(int source, int tag, IntPtr actualSource)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Probe_51(base.GetCppThis(), source, tag, actualSource);
		}

		// Token: 0x06012C27 RID: 76839
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_ProcessRMIs_52(HandleRef pThis, int reportErrors, int dont_loop);

		/// <summary>
		/// Calling this method gives control to the controller to start
		/// processing RMIs. Possible return values are:
		/// RMI_NO_ERROR,
		/// RMI_TAG_ERROR : rmi tag could not be received,
		/// RMI_ARG_ERROR : rmi arg could not be received.
		/// If reportErrors is false, no vtkErrorMacro is called.
		/// ProcessRMIs() calls ProcessRMIs(int) with reportErrors = 0.
		/// If dont_loop is 1, this call just process one RMI message
		/// and exits.
		/// </summary>
		// Token: 0x06012C28 RID: 76840 RVA: 0x001A6628 File Offset: 0x001A4828
		public int ProcessRMIs(int reportErrors, int dont_loop)
		{
			return vtkMultiProcessController.vtkMultiProcessController_ProcessRMIs_52(base.GetCppThis(), reportErrors, dont_loop);
		}

		// Token: 0x06012C29 RID: 76841
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_ProcessRMIs_53(HandleRef pThis);

		/// <summary>
		/// Calling this method gives control to the controller to start
		/// processing RMIs. Possible return values are:
		/// RMI_NO_ERROR,
		/// RMI_TAG_ERROR : rmi tag could not be received,
		/// RMI_ARG_ERROR : rmi arg could not be received.
		/// If reportErrors is false, no vtkErrorMacro is called.
		/// ProcessRMIs() calls ProcessRMIs(int) with reportErrors = 0.
		/// If dont_loop is 1, this call just process one RMI message
		/// and exits.
		/// </summary>
		// Token: 0x06012C2A RID: 76842 RVA: 0x001A664C File Offset: 0x001A484C
		public int ProcessRMIs()
		{
			return vtkMultiProcessController.vtkMultiProcessController_ProcessRMIs_53(base.GetCppThis());
		}

		// Token: 0x06012C2B RID: 76843
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_Receive_54(HandleRef pThis, HandleRef data, int remoteId, int tag);

		/// <summary>
		/// This method receives data from a corresponding send. It blocks
		/// until the receive is finished.  It calls methods in "data"
		/// to communicate the sending data. In the overrloads that take in a \c
		/// maxlength argument, this length is the maximum length of the message to
		/// receive. If the maxlength is less than the length of the message sent by
		/// the sender, an error will be flagged. Once a message is received, use the
		/// GetCount() method to determine the actual size of the data received.
		/// </summary>
		// Token: 0x06012C2C RID: 76844 RVA: 0x001A666C File Offset: 0x001A486C
		public int Receive(vtkDataArray data, int remoteId, int tag)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Receive_54(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), remoteId, tag);
		}

		// Token: 0x06012C2D RID: 76845
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_Receive_55(HandleRef pThis, IntPtr data, long maxlength, int remoteProcessId, int tag);

		/// <summary>
		/// This method receives data from a corresponding send. It blocks
		/// until the receive is finished.  It calls methods in "data"
		/// to communicate the sending data. In the overrloads that take in a \c
		/// maxlength argument, this length is the maximum length of the message to
		/// receive. If the maxlength is less than the length of the message sent by
		/// the sender, an error will be flagged. Once a message is received, use the
		/// GetCount() method to determine the actual size of the data received.
		/// </summary>
		// Token: 0x06012C2E RID: 76846 RVA: 0x001A66A4 File Offset: 0x001A48A4
		public int Receive(IntPtr data, long maxlength, int remoteProcessId, int tag)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Receive_55(base.GetCppThis(), data, maxlength, remoteProcessId, tag);
		}

		// Token: 0x06012C2F RID: 76847
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_Receive_56(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string data, long maxlength, int remoteProcessId, int tag);

		/// <summary>
		/// This method receives data from a corresponding send. It blocks
		/// until the receive is finished.  It calls methods in "data"
		/// to communicate the sending data. In the overrloads that take in a \c
		/// maxlength argument, this length is the maximum length of the message to
		/// receive. If the maxlength is less than the length of the message sent by
		/// the sender, an error will be flagged. Once a message is received, use the
		/// GetCount() method to determine the actual size of the data received.
		/// </summary>
		// Token: 0x06012C30 RID: 76848 RVA: 0x001A66C8 File Offset: 0x001A48C8
		public int Receive(string data, long maxlength, int remoteProcessId, int tag)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Receive_56(base.GetCppThis(), data, maxlength, remoteProcessId, tag);
		}

		// Token: 0x06012C31 RID: 76849
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_Receive_57(HandleRef pThis, HandleRef data, int remoteId, int tag);

		/// <summary>
		/// This method receives data from a corresponding send. It blocks
		/// until the receive is finished.  It calls methods in "data"
		/// to communicate the sending data. In the overrloads that take in a \c
		/// maxlength argument, this length is the maximum length of the message to
		/// receive. If the maxlength is less than the length of the message sent by
		/// the sender, an error will be flagged. Once a message is received, use the
		/// GetCount() method to determine the actual size of the data received.
		/// </summary>
		// Token: 0x06012C32 RID: 76850 RVA: 0x001A66EC File Offset: 0x001A48EC
		public int Receive(vtkDataObject data, int remoteId, int tag)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Receive_57(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), remoteId, tag);
		}

		// Token: 0x06012C33 RID: 76851
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiProcessController_ReceiveDataObject_58(HandleRef pThis, int remoteId, int tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Receive a stream from the other processes.
		/// </summary>
		// Token: 0x06012C34 RID: 76852 RVA: 0x001A6724 File Offset: 0x001A4924
		public vtkDataObject ReceiveDataObject(int remoteId, int tag)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiProcessController.vtkMultiProcessController_ReceiveDataObject_58(base.GetCppThis(), remoteId, tag, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012C35 RID: 76853
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_Reduce_59(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int operation, int destProcessId);

		/// <summary>
		/// Reduce an array to the given destination process.  This version of Reduce
		/// takes an identifier defined in the
		/// vtkCommunicator::StandardOperations enum to define the operation.
		/// </summary>
		// Token: 0x06012C36 RID: 76854 RVA: 0x001A6798 File Offset: 0x001A4998
		public int Reduce(IntPtr sendBuffer, IntPtr recvBuffer, long length, int operation, int destProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Reduce_59(base.GetCppThis(), sendBuffer, recvBuffer, length, operation, destProcessId);
		}

		// Token: 0x06012C37 RID: 76855
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_Reduce_60(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string sendBuffer, [MarshalAs(UnmanagedType.LPUTF8Str)] string recvBuffer, long length, int operation, int destProcessId);

		/// <summary>
		/// Reduce an array to the given destination process.  This version of Reduce
		/// takes an identifier defined in the
		/// vtkCommunicator::StandardOperations enum to define the operation.
		/// </summary>
		// Token: 0x06012C38 RID: 76856 RVA: 0x001A67C0 File Offset: 0x001A49C0
		public int Reduce(string sendBuffer, string recvBuffer, long length, int operation, int destProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Reduce_60(base.GetCppThis(), sendBuffer, recvBuffer, length, operation, destProcessId);
		}

		// Token: 0x06012C39 RID: 76857
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_Reduce_61(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int operation, int destProcessId);

		/// <summary>
		/// Reduce an array to the given destination process.  This version of Reduce
		/// takes an identifier defined in the
		/// vtkCommunicator::StandardOperations enum to define the operation.
		/// </summary>
		// Token: 0x06012C3A RID: 76858 RVA: 0x001A67E8 File Offset: 0x001A49E8
		public int Reduce(vtkDataArray sendBuffer, vtkDataArray recvBuffer, int operation, int destProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Reduce_61(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis(), operation, destProcessId);
		}

		// Token: 0x06012C3B RID: 76859
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_Reduce_62(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int destProcessId);

		/// <summary>
		/// Convenience methods to reduce vtkDataArraySelection.
		/// </summary>
		// Token: 0x06012C3C RID: 76860 RVA: 0x001A6834 File Offset: 0x001A4A34
		public int Reduce(vtkDataArraySelection sendBuffer, vtkDataArraySelection recvBuffer, int destProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Reduce_62(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis(), destProcessId);
		}

		// Token: 0x06012C3D RID: 76861
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiProcessController_RemoveAllRMICallbacks_63(HandleRef pThis, int tag);

		/// <summary>
		/// These methods are a part of the newer API to add multiple rmi callbacks.
		/// When the RMI is triggered, all the callbacks are called
		/// Removes all callbacks for the tag.
		/// </summary>
		// Token: 0x06012C3E RID: 76862 RVA: 0x001A687E File Offset: 0x001A4A7E
		public virtual void RemoveAllRMICallbacks(int tag)
		{
			vtkMultiProcessController.vtkMultiProcessController_RemoveAllRMICallbacks_63(base.GetCppThis(), tag);
		}

		// Token: 0x06012C3F RID: 76863
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_RemoveFirstRMI_64(HandleRef pThis, int tag);

		/// <summary>
		/// Remove the first RMI matching the tag.
		/// </summary>
		// Token: 0x06012C40 RID: 76864 RVA: 0x001A6890 File Offset: 0x001A4A90
		public virtual int RemoveFirstRMI(int tag)
		{
			return vtkMultiProcessController.vtkMultiProcessController_RemoveFirstRMI_64(base.GetCppThis(), tag);
		}

		// Token: 0x06012C41 RID: 76865
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_RemoveRMI_65(HandleRef pThis, uint id);

		/// <summary>
		/// Remove the RMI matching the id. The id is the same id returned by
		/// AddRMI().
		/// </summary>
		// Token: 0x06012C42 RID: 76866 RVA: 0x001A68B0 File Offset: 0x001A4AB0
		public virtual int RemoveRMI(uint id)
		{
			return vtkMultiProcessController.vtkMultiProcessController_RemoveRMI_65(base.GetCppThis(), id);
		}

		// Token: 0x06012C43 RID: 76867
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMultiProcessController_RemoveRMICallback_66(HandleRef pThis, uint id);

		/// <summary>
		/// Remove a callback. Returns true is the remove was successful.
		/// </summary>
		// Token: 0x06012C44 RID: 76868 RVA: 0x001A68D0 File Offset: 0x001A4AD0
		public virtual bool RemoveRMICallback(uint id)
		{
			return vtkMultiProcessController.vtkMultiProcessController_RemoveRMICallback_66(base.GetCppThis(), id) != 0;
		}

		// Token: 0x06012C45 RID: 76869
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMultiProcessController_SafeDownCast_67(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012C46 RID: 76870 RVA: 0x001A68F8 File Offset: 0x001A4AF8
		public new static vtkMultiProcessController SafeDownCast(vtkObjectBase o)
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMultiProcessController.vtkMultiProcessController_SafeDownCast_67((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		// Token: 0x06012C47 RID: 76871
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_Scatter_68(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int srcProcessId);

		/// <summary>
		/// Scatter takes an array in the process with id \c srcProcessId and
		/// distributes it.  Each process (including the source) receives a portion of
		/// the send buffer.  Process 0 receives the first \c length values, process 1
		/// receives the second \c length values, and so on.  Scatter is the inverse
		/// operation of Gather.
		/// </summary>
		// Token: 0x06012C48 RID: 76872 RVA: 0x001A6978 File Offset: 0x001A4B78
		public int Scatter(IntPtr sendBuffer, IntPtr recvBuffer, long length, int srcProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Scatter_68(base.GetCppThis(), sendBuffer, recvBuffer, length, srcProcessId);
		}

		// Token: 0x06012C49 RID: 76873
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_Scatter_69(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string sendBuffer, [MarshalAs(UnmanagedType.LPUTF8Str)] string recvBuffer, long length, int srcProcessId);

		/// <summary>
		/// Scatter takes an array in the process with id \c srcProcessId and
		/// distributes it.  Each process (including the source) receives a portion of
		/// the send buffer.  Process 0 receives the first \c length values, process 1
		/// receives the second \c length values, and so on.  Scatter is the inverse
		/// operation of Gather.
		/// </summary>
		// Token: 0x06012C4A RID: 76874 RVA: 0x001A699C File Offset: 0x001A4B9C
		public int Scatter(string sendBuffer, string recvBuffer, long length, int srcProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Scatter_69(base.GetCppThis(), sendBuffer, recvBuffer, length, srcProcessId);
		}

		// Token: 0x06012C4B RID: 76875
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_Scatter_70(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int srcProcessId);

		/// <summary>
		/// Scatter takes an array in the process with id \c srcProcessId and
		/// distributes it.  Each process (including the source) receives a portion of
		/// the send buffer.  Process 0 receives the first \c length values, process 1
		/// receives the second \c length values, and so on.  Scatter is the inverse
		/// operation of Gather.
		/// </summary>
		// Token: 0x06012C4C RID: 76876 RVA: 0x001A69C0 File Offset: 0x001A4BC0
		public int Scatter(vtkDataArray sendBuffer, vtkDataArray recvBuffer, int srcProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Scatter_70(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis(), srcProcessId);
		}

		// Token: 0x06012C4D RID: 76877
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_ScatterV_71(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int srcProcessId);

		/// <summary>
		/// ScatterV is the vector variant of Scatter.  It extends the functionality of
		/// Scatter by allowing a varying count of data to each process.
		/// ScatterV takes an array in the process with id \c srcProcessId and
		/// distributes it.  Each process (including the source) receives a portion of
		/// the send buffer defined by the \c sendLengths and \c offsets arrays.
		/// </summary>
		// Token: 0x06012C4E RID: 76878 RVA: 0x001A6A0C File Offset: 0x001A4C0C
		public int ScatterV(IntPtr sendBuffer, IntPtr recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int srcProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_ScatterV_71(base.GetCppThis(), sendBuffer, recvBuffer, sendLengths, offsets, recvLength, srcProcessId);
		}

		// Token: 0x06012C4F RID: 76879
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_ScatterV_72(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string sendBuffer, [MarshalAs(UnmanagedType.LPUTF8Str)] string recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int srcProcessId);

		/// <summary>
		/// ScatterV is the vector variant of Scatter.  It extends the functionality of
		/// Scatter by allowing a varying count of data to each process.
		/// ScatterV takes an array in the process with id \c srcProcessId and
		/// distributes it.  Each process (including the source) receives a portion of
		/// the send buffer defined by the \c sendLengths and \c offsets arrays.
		/// </summary>
		// Token: 0x06012C50 RID: 76880 RVA: 0x001A6A34 File Offset: 0x001A4C34
		public int ScatterV(string sendBuffer, string recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int srcProcessId)
		{
			return vtkMultiProcessController.vtkMultiProcessController_ScatterV_72(base.GetCppThis(), sendBuffer, recvBuffer, sendLengths, offsets, recvLength, srcProcessId);
		}

		// Token: 0x06012C51 RID: 76881
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_Send_73(HandleRef pThis, IntPtr data, long length, int remoteProcessId, int tag);

		/// <summary>
		/// This method sends data to another process.  Tag eliminates ambiguity
		/// when multiple sends or receives exist in the same process.
		/// It is recommended to use custom tag number over 100.
		/// vtkMultiProcessController has reserved tags between 1 and 4.
		/// vtkCommunicator has reserved tags between 10 and 16.
		/// </summary>
		// Token: 0x06012C52 RID: 76882 RVA: 0x001A6A5C File Offset: 0x001A4C5C
		public int Send(IntPtr data, long length, int remoteProcessId, int tag)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Send_73(base.GetCppThis(), data, length, remoteProcessId, tag);
		}

		// Token: 0x06012C53 RID: 76883
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_Send_74(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string data, long length, int remoteProcessId, int tag);

		/// <summary>
		/// This method sends data to another process.  Tag eliminates ambiguity
		/// when multiple sends or receives exist in the same process.
		/// It is recommended to use custom tag number over 100.
		/// vtkMultiProcessController has reserved tags between 1 and 4.
		/// vtkCommunicator has reserved tags between 10 and 16.
		/// </summary>
		// Token: 0x06012C54 RID: 76884 RVA: 0x001A6A80 File Offset: 0x001A4C80
		public int Send(string data, long length, int remoteProcessId, int tag)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Send_74(base.GetCppThis(), data, length, remoteProcessId, tag);
		}

		// Token: 0x06012C55 RID: 76885
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_Send_75(HandleRef pThis, HandleRef data, int remoteId, int tag);

		/// <summary>
		/// This method sends data to another process.  Tag eliminates ambiguity
		/// when multiple sends or receives exist in the same process.
		/// It is recommended to use custom tag number over 100.
		/// vtkMultiProcessController has reserved tags between 1 and 4.
		/// vtkCommunicator has reserved tags between 10 and 16.
		/// </summary>
		// Token: 0x06012C56 RID: 76886 RVA: 0x001A6AA4 File Offset: 0x001A4CA4
		public int Send(vtkDataObject data, int remoteId, int tag)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Send_75(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), remoteId, tag);
		}

		// Token: 0x06012C57 RID: 76887
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMultiProcessController_Send_76(HandleRef pThis, HandleRef data, int remoteId, int tag);

		/// <summary>
		/// This method sends data to another process.  Tag eliminates ambiguity
		/// when multiple sends or receives exist in the same process.
		/// It is recommended to use custom tag number over 100.
		/// vtkMultiProcessController has reserved tags between 1 and 4.
		/// vtkCommunicator has reserved tags between 10 and 16.
		/// </summary>
		// Token: 0x06012C58 RID: 76888 RVA: 0x001A6ADC File Offset: 0x001A4CDC
		public int Send(vtkDataArray data, int remoteId, int tag)
		{
			return vtkMultiProcessController.vtkMultiProcessController_Send_76(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), remoteId, tag);
		}

		// Token: 0x06012C59 RID: 76889
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiProcessController_SetBreakFlag_77(HandleRef pThis, int _arg);

		/// <summary>
		/// Setting this flag to 1 will cause the ProcessRMIs loop to return.
		/// This also causes vtkUpStreamPorts to return from
		/// their WaitForUpdate loops.
		/// </summary>
		// Token: 0x06012C5A RID: 76890 RVA: 0x001A6B12 File Offset: 0x001A4D12
		public virtual void SetBreakFlag(int _arg)
		{
			vtkMultiProcessController.vtkMultiProcessController_SetBreakFlag_77(base.GetCppThis(), _arg);
		}

		// Token: 0x06012C5B RID: 76891
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiProcessController_SetBroadcastTriggerRMI_78(HandleRef pThis, byte _arg);

		/// <summary>
		/// Setting this flag to 1 will cause the TriggerRMIOnAllChildren to use
		/// a collective broadcast operation to communicate the RMI tag to the
		/// satellites.
		/// </summary>
		// Token: 0x06012C5C RID: 76892 RVA: 0x001A6B22 File Offset: 0x001A4D22
		public virtual void SetBroadcastTriggerRMI(bool _arg)
		{
			vtkMultiProcessController.vtkMultiProcessController_SetBroadcastTriggerRMI_78(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06012C5D RID: 76893
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiProcessController_SetGlobalController_79(HandleRef controller);

		/// <summary>
		/// This method can be used to synchronize processes.
		/// </summary>
		// Token: 0x06012C5E RID: 76894 RVA: 0x001A6B3C File Offset: 0x001A4D3C
		public static void SetGlobalController(vtkMultiProcessController controller)
		{
			vtkMultiProcessController.vtkMultiProcessController_SetGlobalController_79((controller == null) ? default(HandleRef) : controller.GetCppThis());
		}

		// Token: 0x06012C5F RID: 76895
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiProcessController_SetNumberOfProcesses_80(HandleRef pThis, int num);

		/// <summary>
		/// Set the number of processes you will be using.  This defaults
		/// to the maximum number available.  If you set this to a value
		/// higher than the default, you will get an error.
		/// </summary>
		// Token: 0x06012C60 RID: 76896 RVA: 0x001A6B65 File Offset: 0x001A4D65
		public void SetNumberOfProcesses(int num)
		{
			vtkMultiProcessController.vtkMultiProcessController_SetNumberOfProcesses_80(base.GetCppThis(), num);
		}

		// Token: 0x06012C61 RID: 76897
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiProcessController_SetSingleProcessObject_81(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Object-oriented flavor of SetSingleMethod(). Instead of passing
		/// some function pointer and user data, a vtkProcess object is passed
		/// where the method to execute is Execute() and the data the object itself.
		/// </summary>
		// Token: 0x06012C62 RID: 76898 RVA: 0x001A6B78 File Offset: 0x001A4D78
		public void SetSingleProcessObject(vtkProcess p)
		{
			vtkMultiProcessController.vtkMultiProcessController_SetSingleProcessObject_81(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x06012C63 RID: 76899
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiProcessController_SingleMethodExecute_82(HandleRef pThis);

		/// <summary>
		/// Execute the SingleMethod (as define by SetSingleMethod) using
		/// this-&gt;NumberOfProcesses processes.  This will only return when
		/// all the processes finish executing their methods.
		/// </summary>
		// Token: 0x06012C64 RID: 76900 RVA: 0x001A6BA7 File Offset: 0x001A4DA7
		public virtual void SingleMethodExecute()
		{
			vtkMultiProcessController.vtkMultiProcessController_SingleMethodExecute_82(base.GetCppThis());
		}

		// Token: 0x06012C65 RID: 76901
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiProcessController_TriggerBreakRMIs_83(HandleRef pThis);

		/// <summary>
		/// A convenience method.  Called on process 0 to break "ProcessRMIs" loop
		/// on all other processes.
		/// </summary>
		// Token: 0x06012C66 RID: 76902 RVA: 0x001A6BB6 File Offset: 0x001A4DB6
		public void TriggerBreakRMIs()
		{
			vtkMultiProcessController.vtkMultiProcessController_TriggerBreakRMIs_83(base.GetCppThis());
		}

		// Token: 0x06012C67 RID: 76903
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiProcessController_TriggerRMI_84(HandleRef pThis, int remoteProcessId, IntPtr arg, int argLength, int tag);

		/// <summary>
		/// A method to trigger a method invocation in another process.
		/// </summary>
		// Token: 0x06012C68 RID: 76904 RVA: 0x001A6BC5 File Offset: 0x001A4DC5
		public void TriggerRMI(int remoteProcessId, IntPtr arg, int argLength, int tag)
		{
			vtkMultiProcessController.vtkMultiProcessController_TriggerRMI_84(base.GetCppThis(), remoteProcessId, arg, argLength, tag);
		}

		// Token: 0x06012C69 RID: 76905
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiProcessController_TriggerRMI_85(HandleRef pThis, int remoteProcessId, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg, int tag);

		/// <summary>
		/// Convenience method when the arg is a string.
		/// </summary>
		// Token: 0x06012C6A RID: 76906 RVA: 0x001A6BD9 File Offset: 0x001A4DD9
		public void TriggerRMI(int remoteProcessId, string arg, int tag)
		{
			vtkMultiProcessController.vtkMultiProcessController_TriggerRMI_85(base.GetCppThis(), remoteProcessId, arg, tag);
		}

		// Token: 0x06012C6B RID: 76907
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiProcessController_TriggerRMI_86(HandleRef pThis, int remoteProcessId, int tag);

		/// <summary>
		/// Convenience method when there is no argument.
		/// </summary>
		// Token: 0x06012C6C RID: 76908 RVA: 0x001A6BEB File Offset: 0x001A4DEB
		public void TriggerRMI(int remoteProcessId, int tag)
		{
			vtkMultiProcessController.vtkMultiProcessController_TriggerRMI_86(base.GetCppThis(), remoteProcessId, tag);
		}

		// Token: 0x06012C6D RID: 76909
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiProcessController_TriggerRMIOnAllChildren_87(HandleRef pThis, IntPtr arg, int argLength, int tag);

		/// <summary>
		/// This is a convenicence method to trigger an RMI call on all the "children"
		/// of the current node. The children of the current node can be determined by
		/// drawing a binary tree starting at node 0 and then assigned nodes ids
		/// incrementally in a breadth-first fashion from left to right. This is
		/// designed to be used when trigger an RMI call on all satellites from the
		/// root node.
		/// </summary>
		// Token: 0x06012C6E RID: 76910 RVA: 0x001A6BFC File Offset: 0x001A4DFC
		public void TriggerRMIOnAllChildren(IntPtr arg, int argLength, int tag)
		{
			vtkMultiProcessController.vtkMultiProcessController_TriggerRMIOnAllChildren_87(base.GetCppThis(), arg, argLength, tag);
		}

		// Token: 0x06012C6F RID: 76911
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiProcessController_TriggerRMIOnAllChildren_88(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg, int tag);

		/// <summary>
		/// This is a convenicence method to trigger an RMI call on all the "children"
		/// of the current node. The children of the current node can be determined by
		/// drawing a binary tree starting at node 0 and then assigned nodes ids
		/// incrementally in a breadth-first fashion from left to right. This is
		/// designed to be used when trigger an RMI call on all satellites from the
		/// root node.
		/// </summary>
		// Token: 0x06012C70 RID: 76912 RVA: 0x001A6C0E File Offset: 0x001A4E0E
		public void TriggerRMIOnAllChildren(string arg, int tag)
		{
			vtkMultiProcessController.vtkMultiProcessController_TriggerRMIOnAllChildren_88(base.GetCppThis(), arg, tag);
		}

		// Token: 0x06012C71 RID: 76913
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMultiProcessController_TriggerRMIOnAllChildren_89(HandleRef pThis, int tag);

		/// <summary>
		/// This is a convenicence method to trigger an RMI call on all the "children"
		/// of the current node. The children of the current node can be determined by
		/// drawing a binary tree starting at node 0 and then assigned nodes ids
		/// incrementally in a breadth-first fashion from left to right. This is
		/// designed to be used when trigger an RMI call on all satellites from the
		/// root node.
		/// </summary>
		// Token: 0x06012C72 RID: 76914 RVA: 0x001A6C1F File Offset: 0x001A4E1F
		public void TriggerRMIOnAllChildren(int tag)
		{
			vtkMultiProcessController.vtkMultiProcessController_TriggerRMIOnAllChildren_89(base.GetCppThis(), tag);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015A5 RID: 5541
		public new const string MRFullTypeName = "Kitware.VTK.vtkMultiProcessController";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015A6 RID: 5542
		public new static readonly string MRClassNameKey = "class vtkMultiProcessController";

		/// <summary>
		/// Accessor to some default tags.
		/// </summary>
		// Token: 0x020006F3 RID: 1779
		public enum Consts
		{
			/// <summary>enum member</summary>
			// Token: 0x040015A8 RID: 5544
			ANY_SOURCE = -1,
			/// <summary>enum member</summary>
			// Token: 0x040015A9 RID: 5545
			INVALID_SOURCE = -2
		}

		/// <summary>
		/// Accessor to some default tags.
		/// </summary>
		// Token: 0x020006F4 RID: 1780
		public enum Errors
		{
			/// <summary>enum member</summary>
			// Token: 0x040015AB RID: 5547
			RMI_ARG_ERROR = 2,
			/// <summary>enum member</summary>
			// Token: 0x040015AC RID: 5548
			RMI_NO_ERROR = 0,
			/// <summary>enum member</summary>
			// Token: 0x040015AD RID: 5549
			RMI_TAG_ERROR
		}

		/// <summary>
		/// Accessor to some default tags.
		/// </summary>
		// Token: 0x020006F5 RID: 1781
		public enum Tags
		{
			/// <summary>enum member</summary>
			// Token: 0x040015AF RID: 5551
			BREAK_RMI_TAG = 3,
			/// <summary>enum member</summary>
			// Token: 0x040015B0 RID: 5552
			RMI_ARG_TAG = 2,
			/// <summary>enum member</summary>
			// Token: 0x040015B1 RID: 5553
			RMI_TAG = 1,
			/// <summary>enum member</summary>
			// Token: 0x040015B2 RID: 5554
			XML_WRITER_DATA_INFO = 4
		}
	}
}
