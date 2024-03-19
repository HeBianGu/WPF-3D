using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProcess
	/// </summary>
	/// <remarks>
	///    a process that can be launched by a vtkMultiProcessController
	///
	/// vtkProcess is an abstract class representing a process that can be launched
	/// by a vtkMultiProcessController. Concrete classes just have to implement
	/// Execute() method and make sure it set the proper value in ReturnValue.
	///
	/// @par Example:
	///  class MyProcess: public vtkProcess
	///  ...
	///  vtkMultiProcessController *c;
	///  MyProcess *p=new MyProcess::New();
	///  p-&gt;SetArgs(argc,argv); // some parameters specific to the process
	///  p-&gt;SetX(10.0); // ...
	///  c-&gt;SetSingleProcess(p);
	///  c-&gt;SingleMethodExecute();
	///  int returnValue=p-&gt;GetReturnValue();
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkMultiProcessController
	/// </seealso>
	// Token: 0x020006F9 RID: 1785
	public abstract class vtkProcess : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012CD3 RID: 77011 RVA: 0x001A7607 File Offset: 0x001A5807
		static vtkProcess()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProcess.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProcess"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012CD4 RID: 77012 RVA: 0x001A762F File Offset: 0x001A582F
		public vtkProcess(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012CD5 RID: 77013 RVA: 0x001A763D File Offset: 0x001A583D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012CD6 RID: 77014
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProcess_Execute_01(HandleRef pThis);

		/// <summary>
		/// Entry point of the process.
		/// This method is expected to update ReturnValue.
		/// </summary>
		// Token: 0x06012CD7 RID: 77015 RVA: 0x001A7648 File Offset: 0x001A5848
		public virtual void Execute()
		{
			vtkProcess.vtkProcess_Execute_01(base.GetCppThis());
		}

		// Token: 0x06012CD8 RID: 77016
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProcess_GetController_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Give access to the controller that launched the process.
		/// Initial value is nullptr.
		/// </summary>
		// Token: 0x06012CD9 RID: 77017 RVA: 0x001A7658 File Offset: 0x001A5858
		public vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProcess.vtkProcess_GetController_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012CDA RID: 77018
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProcess_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012CDB RID: 77019 RVA: 0x001A76C8 File Offset: 0x001A58C8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProcess.vtkProcess_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06012CDC RID: 77020
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProcess_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012CDD RID: 77021 RVA: 0x001A76E8 File Offset: 0x001A58E8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProcess.vtkProcess_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06012CDE RID: 77022
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProcess_GetReturnValue_05(HandleRef pThis);

		/// <summary>
		/// Value set at the end of a call to Execute.
		/// </summary>
		// Token: 0x06012CDF RID: 77023 RVA: 0x001A7704 File Offset: 0x001A5904
		public int GetReturnValue()
		{
			return vtkProcess.vtkProcess_GetReturnValue_05(base.GetCppThis());
		}

		// Token: 0x06012CE0 RID: 77024
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProcess_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012CE1 RID: 77025 RVA: 0x001A7724 File Offset: 0x001A5924
		public override int IsA(string type)
		{
			return vtkProcess.vtkProcess_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06012CE2 RID: 77026
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProcess_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012CE3 RID: 77027 RVA: 0x001A7744 File Offset: 0x001A5944
		public new static int IsTypeOf(string type)
		{
			return vtkProcess.vtkProcess_IsTypeOf_07(type);
		}

		// Token: 0x06012CE4 RID: 77028
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProcess_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012CE5 RID: 77029 RVA: 0x001A7760 File Offset: 0x001A5960
		public new vtkProcess NewInstance()
		{
			vtkProcess result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProcess.vtkProcess_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProcess)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012CE6 RID: 77030
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProcess_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012CE7 RID: 77031 RVA: 0x001A77BC File Offset: 0x001A59BC
		public new static vtkProcess SafeDownCast(vtkObjectBase o)
		{
			vtkProcess vtkProcess = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProcess.vtkProcess_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProcess = (vtkProcess)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProcess.Register(null);
				}
			}
			return vtkProcess;
		}

		// Token: 0x06012CE8 RID: 77032
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProcess_SetController_10(HandleRef pThis, HandleRef aController);

		/// <summary>
		/// This method should not be called directly but set by the controller
		/// itself.
		/// </summary>
		// Token: 0x06012CE9 RID: 77033 RVA: 0x001A783C File Offset: 0x001A5A3C
		public void SetController(vtkMultiProcessController aController)
		{
			vtkProcess.vtkProcess_SetController_10(base.GetCppThis(), (aController == null) ? default(HandleRef) : aController.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015B9 RID: 5561
		public new const string MRFullTypeName = "Kitware.VTK.vtkProcess";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015BA RID: 5562
		public new static readonly string MRClassNameKey = "class vtkProcess";
	}
}
