using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDummyController
	/// </summary>
	/// <remarks>
	///    Dummy controller for single process applications
	///
	/// This is a dummy controller which can be used by applications which always
	/// require a controller but are also compile on systems without threads
	/// or mpi.
	/// </remarks>
	/// <seealso>
	///
	/// vtkMultiProcessController
	/// </seealso>
	// Token: 0x020006F6 RID: 1782
	public class vtkDummyController : vtkMultiProcessController
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012C73 RID: 76915 RVA: 0x001A6C2F File Offset: 0x001A4E2F
		static vtkDummyController()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDummyController.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDummyController"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012C74 RID: 76916 RVA: 0x001A6C57 File Offset: 0x001A4E57
		public vtkDummyController(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012C75 RID: 76917
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDummyController_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012C76 RID: 76918 RVA: 0x001A6C68 File Offset: 0x001A4E68
		public new static vtkDummyController New()
		{
			vtkDummyController result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDummyController.vtkDummyController_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDummyController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012C77 RID: 76919 RVA: 0x001A6CBC File Offset: 0x001A4EBC
		public vtkDummyController() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDummyController.vtkDummyController_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012C78 RID: 76920 RVA: 0x001A6D00 File Offset: 0x001A4F00
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012C79 RID: 76921
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDummyController_CreateOutputWindow_01(HandleRef pThis);

		/// <summary>
		/// Does nothing.
		/// </summary>
		// Token: 0x06012C7A RID: 76922 RVA: 0x001A6D0B File Offset: 0x001A4F0B
		public override void CreateOutputWindow()
		{
			vtkDummyController.vtkDummyController_CreateOutputWindow_01(base.GetCppThis());
		}

		// Token: 0x06012C7B RID: 76923
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDummyController_Finalize_02(HandleRef pThis);

		/// <summary>
		/// This method is for setting up the processes.
		/// </summary>
		// Token: 0x06012C7C RID: 76924 RVA: 0x001A6D1A File Offset: 0x001A4F1A
		public override void FinalizeWrapper()
		{
			vtkDummyController.vtkDummyController_Finalize_02(base.GetCppThis());
		}

		// Token: 0x06012C7D RID: 76925
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDummyController_Finalize_03(HandleRef pThis, int arg0);

		/// <summary>
		/// This method is for setting up the processes.
		/// </summary>
		// Token: 0x06012C7E RID: 76926 RVA: 0x001A6D29 File Offset: 0x001A4F29
		public override void FinalizeWrapper(int arg0)
		{
			vtkDummyController.vtkDummyController_Finalize_03(base.GetCppThis(), arg0);
		}

		// Token: 0x06012C7F RID: 76927
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDummyController_GetLocalProcessId_04(HandleRef pThis);

		/// <summary>
		/// This method always returns 0.
		/// </summary>
		// Token: 0x06012C80 RID: 76928 RVA: 0x001A6D3C File Offset: 0x001A4F3C
		public new int GetLocalProcessId()
		{
			return vtkDummyController.vtkDummyController_GetLocalProcessId_04(base.GetCppThis());
		}

		// Token: 0x06012C81 RID: 76929
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDummyController_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012C82 RID: 76930 RVA: 0x001A6D5C File Offset: 0x001A4F5C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDummyController.vtkDummyController_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06012C83 RID: 76931
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDummyController_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012C84 RID: 76932 RVA: 0x001A6D7C File Offset: 0x001A4F7C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDummyController.vtkDummyController_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06012C85 RID: 76933
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDummyController_GetRMICommunicator_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// If you don't need any special functionality from the controller, you
		/// can swap out the dummy communicator for another one.
		/// </summary>
		// Token: 0x06012C86 RID: 76934 RVA: 0x001A6D98 File Offset: 0x001A4F98
		public virtual vtkCommunicator GetRMICommunicator()
		{
			vtkCommunicator vtkCommunicator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDummyController.vtkDummyController_GetRMICommunicator_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012C87 RID: 76935
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDummyController_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012C88 RID: 76936 RVA: 0x001A6E08 File Offset: 0x001A5008
		public override int IsA(string type)
		{
			return vtkDummyController.vtkDummyController_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06012C89 RID: 76937
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDummyController_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012C8A RID: 76938 RVA: 0x001A6E28 File Offset: 0x001A5028
		public new static int IsTypeOf(string type)
		{
			return vtkDummyController.vtkDummyController_IsTypeOf_09(type);
		}

		// Token: 0x06012C8B RID: 76939
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDummyController_MultipleMethodExecute_10(HandleRef pThis);

		/// <summary>
		/// Directly calls multiple method 0.
		/// </summary>
		// Token: 0x06012C8C RID: 76940 RVA: 0x001A6E42 File Offset: 0x001A5042
		public override void MultipleMethodExecute()
		{
			vtkDummyController.vtkDummyController_MultipleMethodExecute_10(base.GetCppThis());
		}

		// Token: 0x06012C8D RID: 76941
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDummyController_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012C8E RID: 76942 RVA: 0x001A6E54 File Offset: 0x001A5054
		public new vtkDummyController NewInstance()
		{
			vtkDummyController result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDummyController.vtkDummyController_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDummyController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012C8F RID: 76943
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDummyController_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012C90 RID: 76944 RVA: 0x001A6EB0 File Offset: 0x001A50B0
		public new static vtkDummyController SafeDownCast(vtkObjectBase o)
		{
			vtkDummyController vtkDummyController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDummyController.vtkDummyController_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDummyController = (vtkDummyController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDummyController.Register(null);
				}
			}
			return vtkDummyController;
		}

		// Token: 0x06012C91 RID: 76945
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDummyController_SetCommunicator_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// If you don't need any special functionality from the controller, you
		/// can swap out the dummy communicator for another one.
		/// </summary>
		// Token: 0x06012C92 RID: 76946 RVA: 0x001A6F30 File Offset: 0x001A5130
		public virtual void SetCommunicator(vtkCommunicator arg0)
		{
			vtkDummyController.vtkDummyController_SetCommunicator_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06012C93 RID: 76947
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDummyController_SetRMICommunicator_15(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// If you don't need any special functionality from the controller, you
		/// can swap out the dummy communicator for another one.
		/// </summary>
		// Token: 0x06012C94 RID: 76948 RVA: 0x001A6F60 File Offset: 0x001A5160
		public virtual void SetRMICommunicator(vtkCommunicator arg0)
		{
			vtkDummyController.vtkDummyController_SetRMICommunicator_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06012C95 RID: 76949
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDummyController_SingleMethodExecute_16(HandleRef pThis);

		/// <summary>
		/// Directly calls the single method.
		/// </summary>
		// Token: 0x06012C96 RID: 76950 RVA: 0x001A6F8F File Offset: 0x001A518F
		public override void SingleMethodExecute()
		{
			vtkDummyController.vtkDummyController_SingleMethodExecute_16(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015B3 RID: 5555
		public new const string MRFullTypeName = "Kitware.VTK.vtkDummyController";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015B4 RID: 5556
		public new static readonly string MRClassNameKey = "class vtkDummyController";
	}
}
