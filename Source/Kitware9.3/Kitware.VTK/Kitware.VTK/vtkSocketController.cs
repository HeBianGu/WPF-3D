using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSocketController
	/// </summary>
	/// <remarks>
	///    Process communication using Sockets
	///
	/// This is a concrete implementation of vtkMultiProcessController.
	/// It supports one-to-one communication using sockets. Note that
	/// process 0 will always correspond to self and process 1 to the
	/// remote process. This class is best used with ports.
	///
	/// @bug
	/// Note that because process 0 will always correspond to self, this class breaks
	/// assumptions usually implied when using ad-hoc polymorphism.  That is, the
	/// vtkSocketController will behave differently than other subclasses of
	/// vtkMultiProcessController.  If you upcast vtkSocketController to
	/// vtkMultiProcessController and send it to a method that does not know that the
	/// object is actually a vtkSocketController, the object may not behave as
	/// intended.  For example, if that oblivious class chose to identify a "root"
	/// based on the local process id, then both sides of the controller will think
	/// they are the root (and that will probably lead to deadlock).  If you plan to
	/// upcast to vtkMultiProcessController, you should probably use the
	/// CreateCompliantController instead.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkMultiProcessController vtkSocketCommunicator vtkInputPort vtkOutputPort
	/// </seealso>
	// Token: 0x020006FD RID: 1789
	public class vtkSocketController : vtkMultiProcessController
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012D96 RID: 77206 RVA: 0x001A8731 File Offset: 0x001A6931
		static vtkSocketController()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSocketController.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSocketController"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012D97 RID: 77207 RVA: 0x001A8759 File Offset: 0x001A6959
		public vtkSocketController(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012D98 RID: 77208
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSocketController_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012D99 RID: 77209 RVA: 0x001A8768 File Offset: 0x001A6968
		public new static vtkSocketController New()
		{
			vtkSocketController result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSocketController.vtkSocketController_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSocketController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012D9A RID: 77210 RVA: 0x001A87BC File Offset: 0x001A69BC
		public vtkSocketController() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSocketController.vtkSocketController_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012D9B RID: 77211 RVA: 0x001A8800 File Offset: 0x001A6A00
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012D9C RID: 77212
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSocketController_CloseConnection_01(HandleRef pThis);

		/// <summary>
		/// Close a connection, forwarded
		/// to the communicator
		/// </summary>
		// Token: 0x06012D9D RID: 77213 RVA: 0x001A880B File Offset: 0x001A6A0B
		public virtual void CloseConnection()
		{
			vtkSocketController.vtkSocketController_CloseConnection_01(base.GetCppThis());
		}

		// Token: 0x06012D9E RID: 77214
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketController_ConnectTo_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string hostName, int port);

		/// <summary>
		/// Open a connection to a give machine, forwarded
		/// to the communicator
		/// </summary>
		// Token: 0x06012D9F RID: 77215 RVA: 0x001A881C File Offset: 0x001A6A1C
		public virtual int ConnectTo(string hostName, int port)
		{
			return vtkSocketController.vtkSocketController_ConnectTo_02(base.GetCppThis(), hostName, port);
		}

		// Token: 0x06012DA0 RID: 77216
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSocketController_CreateCompliantController_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// FOOLISH MORTALS!  Thou hast forsaken the sacred laws of ad-hoc polymorphism
		/// when thou broke a critical assumption of the superclass (namely, each
		/// process has thine own id).  The time frame to fix thy error has passed.
		/// Too much code has come to rely on this abhorrent behavior.  Instead, we
		/// offer this gift: a method for creating an equivalent communicator with
		/// correct process id semantics.  The calling code is responsible for
		/// deleting this controller.
		/// </summary>
		// Token: 0x06012DA1 RID: 77217 RVA: 0x001A8840 File Offset: 0x001A6A40
		public vtkMultiProcessController CreateCompliantController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSocketController.vtkSocketController_CreateCompliantController_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012DA2 RID: 77218
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSocketController_CreateOutputWindow_04(HandleRef pThis);

		/// <summary>
		/// Does not apply to sockets. Does nothing.
		/// </summary>
		// Token: 0x06012DA3 RID: 77219 RVA: 0x001A88AF File Offset: 0x001A6AAF
		public override void CreateOutputWindow()
		{
			vtkSocketController.vtkSocketController_CreateOutputWindow_04(base.GetCppThis());
		}

		// Token: 0x06012DA4 RID: 77220
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSocketController_Finalize_05(HandleRef pThis);

		/// <summary>
		/// Does not apply to sockets. Does nothing.
		/// </summary>
		// Token: 0x06012DA5 RID: 77221 RVA: 0x001A88BE File Offset: 0x001A6ABE
		public override void FinalizeWrapper()
		{
			vtkSocketController.vtkSocketController_Finalize_05(base.GetCppThis());
		}

		// Token: 0x06012DA6 RID: 77222
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSocketController_Finalize_06(HandleRef pThis, int arg0);

		/// <summary>
		/// Does not apply to sockets. Does nothing.
		/// </summary>
		// Token: 0x06012DA7 RID: 77223 RVA: 0x001A88CD File Offset: 0x001A6ACD
		public override void FinalizeWrapper(int arg0)
		{
			vtkSocketController.vtkSocketController_Finalize_06(base.GetCppThis(), arg0);
		}

		// Token: 0x06012DA8 RID: 77224
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSocketController_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012DA9 RID: 77225 RVA: 0x001A88E0 File Offset: 0x001A6AE0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSocketController.vtkSocketController_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06012DAA RID: 77226
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSocketController_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012DAB RID: 77227 RVA: 0x001A8900 File Offset: 0x001A6B00
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSocketController.vtkSocketController_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06012DAC RID: 77228
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketController_GetSwapBytesInReceivedData_09(HandleRef pThis);

		/// <summary>
		/// Open a connection to a give machine, forwarded
		/// to the communicator
		/// </summary>
		// Token: 0x06012DAD RID: 77229 RVA: 0x001A891C File Offset: 0x001A6B1C
		public int GetSwapBytesInReceivedData()
		{
			return vtkSocketController.vtkSocketController_GetSwapBytesInReceivedData_09(base.GetCppThis());
		}

		// Token: 0x06012DAE RID: 77230
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSocketController_Initialize_10(HandleRef pThis);

		/// <summary>
		/// This method is for initialiazing sockets.
		/// One of these is REQUIRED for Windows.
		/// </summary>
		// Token: 0x06012DAF RID: 77231 RVA: 0x001A893B File Offset: 0x001A6B3B
		public virtual void Initialize()
		{
			vtkSocketController.vtkSocketController_Initialize_10(base.GetCppThis());
		}

		// Token: 0x06012DB0 RID: 77232
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketController_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012DB1 RID: 77233 RVA: 0x001A894C File Offset: 0x001A6B4C
		public override int IsA(string type)
		{
			return vtkSocketController.vtkSocketController_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x06012DB2 RID: 77234
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketController_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012DB3 RID: 77235 RVA: 0x001A896C File Offset: 0x001A6B6C
		public new static int IsTypeOf(string type)
		{
			return vtkSocketController.vtkSocketController_IsTypeOf_12(type);
		}

		// Token: 0x06012DB4 RID: 77236
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSocketController_MultipleMethodExecute_13(HandleRef pThis);

		/// <summary>
		/// Does not apply to sockets.  Does nothing.
		/// </summary>
		// Token: 0x06012DB5 RID: 77237 RVA: 0x001A8986 File Offset: 0x001A6B86
		public override void MultipleMethodExecute()
		{
			vtkSocketController.vtkSocketController_MultipleMethodExecute_13(base.GetCppThis());
		}

		// Token: 0x06012DB6 RID: 77238
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSocketController_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012DB7 RID: 77239 RVA: 0x001A8998 File Offset: 0x001A6B98
		public new vtkSocketController NewInstance()
		{
			vtkSocketController result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSocketController.vtkSocketController_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSocketController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012DB8 RID: 77240
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSocketController_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012DB9 RID: 77241 RVA: 0x001A89F4 File Offset: 0x001A6BF4
		public new static vtkSocketController SafeDownCast(vtkObjectBase o)
		{
			vtkSocketController vtkSocketController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSocketController.vtkSocketController_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSocketController = (vtkSocketController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSocketController.Register(null);
				}
			}
			return vtkSocketController;
		}

		// Token: 0x06012DBA RID: 77242
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSocketController_SetCommunicator_17(HandleRef pThis, HandleRef comm);

		/// <summary>
		/// Set the communicator used in normal and rmi communications.
		/// </summary>
		// Token: 0x06012DBB RID: 77243 RVA: 0x001A8A74 File Offset: 0x001A6C74
		public void SetCommunicator(vtkSocketCommunicator comm)
		{
			vtkSocketController.vtkSocketController_SetCommunicator_17(base.GetCppThis(), (comm == null) ? default(HandleRef) : comm.GetCppThis());
		}

		// Token: 0x06012DBC RID: 77244
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSocketController_SingleMethodExecute_18(HandleRef pThis);

		/// <summary>
		/// Does not apply to sockets. Does nothing.
		/// </summary>
		// Token: 0x06012DBD RID: 77245 RVA: 0x001A8AA3 File Offset: 0x001A6CA3
		public override void SingleMethodExecute()
		{
			vtkSocketController.vtkSocketController_SingleMethodExecute_18(base.GetCppThis());
		}

		// Token: 0x06012DBE RID: 77246
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocketController_WaitForConnection_19(HandleRef pThis, int port);

		/// <summary>
		/// Wait for connection on a given port, forwarded
		/// to the communicator
		/// </summary>
		// Token: 0x06012DBF RID: 77247 RVA: 0x001A8AB4 File Offset: 0x001A6CB4
		public virtual int WaitForConnection(int port)
		{
			return vtkSocketController.vtkSocketController_WaitForConnection_19(base.GetCppThis(), port);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015C1 RID: 5569
		public new const string MRFullTypeName = "Kitware.VTK.vtkSocketController";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015C2 RID: 5570
		public new static readonly string MRClassNameKey = "class vtkSocketController";

		/// <summary>
		/// FOOLISH MORTALS!  Thou hast forsaken the sacred laws of ad-hoc polymorphism
		/// when thou broke a critical assumption of the superclass (namely, each
		/// process has thine own id).  The time frame to fix thy error has passed.
		/// Too much code has come to rely on this abhorrent behavior.  Instead, we
		/// offer this gift: a method for creating an equivalent communicator with
		/// correct process id semantics.  The calling code is responsible for
		/// deleting this controller.
		/// </summary>
		// Token: 0x020006FE RID: 1790
		public new enum Consts
		{
			/// <summary>enum member</summary>
			// Token: 0x040015C4 RID: 5572
			ENDIAN_TAG = 1010580540,
			/// <summary>enum member</summary>
			// Token: 0x040015C5 RID: 5573
			HASH_TAG = 1061109567,
			/// <summary>enum member</summary>
			// Token: 0x040015C6 RID: 5574
			IDTYPESIZE_TAG = 1027423549,
			/// <summary>enum member</summary>
			// Token: 0x040015C7 RID: 5575
			VERSION_TAG = 1044266558
		}
	}
}
