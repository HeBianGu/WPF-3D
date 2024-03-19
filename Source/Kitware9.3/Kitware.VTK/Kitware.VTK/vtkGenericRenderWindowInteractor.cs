using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGenericRenderWindowInteractor
	/// </summary>
	/// <remarks>
	///    platform-independent programmable render window interactor.
	///
	///
	/// vtkGenericRenderWindowInteractor provides a way to translate native
	/// mouse and keyboard events into vtk Events.   By calling the methods on
	/// this class, vtk events will be invoked.   This will allow scripting
	/// languages to use vtkInteractorStyles and 3D widgets.
	/// </remarks>
	// Token: 0x020005FB RID: 1531
	public class vtkGenericRenderWindowInteractor : vtkRenderWindowInteractor
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060109DB RID: 68059 RVA: 0x0017307A File Offset: 0x0017127A
		static vtkGenericRenderWindowInteractor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericRenderWindowInteractor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericRenderWindowInteractor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060109DC RID: 68060 RVA: 0x001730A2 File Offset: 0x001712A2
		public vtkGenericRenderWindowInteractor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060109DD RID: 68061
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericRenderWindowInteractor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060109DE RID: 68062 RVA: 0x001730B0 File Offset: 0x001712B0
		public new static vtkGenericRenderWindowInteractor New()
		{
			vtkGenericRenderWindowInteractor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericRenderWindowInteractor.vtkGenericRenderWindowInteractor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060109DF RID: 68063 RVA: 0x00173104 File Offset: 0x00171304
		public vtkGenericRenderWindowInteractor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGenericRenderWindowInteractor.vtkGenericRenderWindowInteractor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060109E0 RID: 68064 RVA: 0x00173148 File Offset: 0x00171348
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060109E1 RID: 68065
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericRenderWindowInteractor_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060109E2 RID: 68066 RVA: 0x00173154 File Offset: 0x00171354
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGenericRenderWindowInteractor.vtkGenericRenderWindowInteractor_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060109E3 RID: 68067
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericRenderWindowInteractor_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060109E4 RID: 68068 RVA: 0x00173174 File Offset: 0x00171374
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGenericRenderWindowInteractor.vtkGenericRenderWindowInteractor_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060109E5 RID: 68069
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericRenderWindowInteractor_GetTimerEventResetsTimer_03(HandleRef pThis);

		/// <summary>
		/// Flag that indicates whether the TimerEvent method should call ResetTimer
		/// to simulate repeating timers with an endless stream of one shot timers.
		/// By default this flag is on and all repeating timers are implemented as a
		/// stream of sequential one shot timers. If the observer of
		/// CreateTimerEvent actually creates a "natively repeating" timer, setting
		/// this flag to off will prevent (perhaps many many) unnecessary calls to
		/// ResetTimer. Having the flag on by default means that "natively one
		/// shot" timers can be either one shot or repeating timers with no
		/// additional work. Also, "natively repeating" timers still work with the
		/// default setting, but with potentially many create and destroy calls.
		/// </summary>
		// Token: 0x060109E6 RID: 68070 RVA: 0x00173190 File Offset: 0x00171390
		public virtual int GetTimerEventResetsTimer()
		{
			return vtkGenericRenderWindowInteractor.vtkGenericRenderWindowInteractor_GetTimerEventResetsTimer_03(base.GetCppThis());
		}

		// Token: 0x060109E7 RID: 68071
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericRenderWindowInteractor_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060109E8 RID: 68072 RVA: 0x001731B0 File Offset: 0x001713B0
		public override int IsA(string type)
		{
			return vtkGenericRenderWindowInteractor.vtkGenericRenderWindowInteractor_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060109E9 RID: 68073
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericRenderWindowInteractor_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060109EA RID: 68074 RVA: 0x001731D0 File Offset: 0x001713D0
		public new static int IsTypeOf(string type)
		{
			return vtkGenericRenderWindowInteractor.vtkGenericRenderWindowInteractor_IsTypeOf_05(type);
		}

		// Token: 0x060109EB RID: 68075
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericRenderWindowInteractor_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060109EC RID: 68076 RVA: 0x001731EC File Offset: 0x001713EC
		public new vtkGenericRenderWindowInteractor NewInstance()
		{
			vtkGenericRenderWindowInteractor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericRenderWindowInteractor.vtkGenericRenderWindowInteractor_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060109ED RID: 68077
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericRenderWindowInteractor_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060109EE RID: 68078 RVA: 0x00173248 File Offset: 0x00171448
		public new static vtkGenericRenderWindowInteractor SafeDownCast(vtkObjectBase o)
		{
			vtkGenericRenderWindowInteractor vtkGenericRenderWindowInteractor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericRenderWindowInteractor.vtkGenericRenderWindowInteractor_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericRenderWindowInteractor = (vtkGenericRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericRenderWindowInteractor.Register(null);
				}
			}
			return vtkGenericRenderWindowInteractor;
		}

		// Token: 0x060109EF RID: 68079
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericRenderWindowInteractor_SetTimerEventResetsTimer_09(HandleRef pThis, int _arg);

		/// <summary>
		/// Flag that indicates whether the TimerEvent method should call ResetTimer
		/// to simulate repeating timers with an endless stream of one shot timers.
		/// By default this flag is on and all repeating timers are implemented as a
		/// stream of sequential one shot timers. If the observer of
		/// CreateTimerEvent actually creates a "natively repeating" timer, setting
		/// this flag to off will prevent (perhaps many many) unnecessary calls to
		/// ResetTimer. Having the flag on by default means that "natively one
		/// shot" timers can be either one shot or repeating timers with no
		/// additional work. Also, "natively repeating" timers still work with the
		/// default setting, but with potentially many create and destroy calls.
		/// </summary>
		// Token: 0x060109F0 RID: 68080 RVA: 0x001732C7 File Offset: 0x001714C7
		public virtual void SetTimerEventResetsTimer(int _arg)
		{
			vtkGenericRenderWindowInteractor.vtkGenericRenderWindowInteractor_SetTimerEventResetsTimer_09(base.GetCppThis(), _arg);
		}

		// Token: 0x060109F1 RID: 68081
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericRenderWindowInteractor_TimerEvent_10(HandleRef pThis);

		/// <summary>
		/// Fire TimerEvent. SetEventInformation should be called just prior
		/// to calling any of these methods. These methods will Invoke the
		/// corresponding vtk event.
		/// </summary>
		// Token: 0x060109F2 RID: 68082 RVA: 0x001732D7 File Offset: 0x001714D7
		public virtual void TimerEvent()
		{
			vtkGenericRenderWindowInteractor.vtkGenericRenderWindowInteractor_TimerEvent_10(base.GetCppThis());
		}

		// Token: 0x060109F3 RID: 68083
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericRenderWindowInteractor_TimerEventResetsTimerOff_11(HandleRef pThis);

		/// <summary>
		/// Flag that indicates whether the TimerEvent method should call ResetTimer
		/// to simulate repeating timers with an endless stream of one shot timers.
		/// By default this flag is on and all repeating timers are implemented as a
		/// stream of sequential one shot timers. If the observer of
		/// CreateTimerEvent actually creates a "natively repeating" timer, setting
		/// this flag to off will prevent (perhaps many many) unnecessary calls to
		/// ResetTimer. Having the flag on by default means that "natively one
		/// shot" timers can be either one shot or repeating timers with no
		/// additional work. Also, "natively repeating" timers still work with the
		/// default setting, but with potentially many create and destroy calls.
		/// </summary>
		// Token: 0x060109F4 RID: 68084 RVA: 0x001732E6 File Offset: 0x001714E6
		public virtual void TimerEventResetsTimerOff()
		{
			vtkGenericRenderWindowInteractor.vtkGenericRenderWindowInteractor_TimerEventResetsTimerOff_11(base.GetCppThis());
		}

		// Token: 0x060109F5 RID: 68085
		[DllImport("Kitware.VTK.RenderingUI.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericRenderWindowInteractor_TimerEventResetsTimerOn_12(HandleRef pThis);

		/// <summary>
		/// Flag that indicates whether the TimerEvent method should call ResetTimer
		/// to simulate repeating timers with an endless stream of one shot timers.
		/// By default this flag is on and all repeating timers are implemented as a
		/// stream of sequential one shot timers. If the observer of
		/// CreateTimerEvent actually creates a "natively repeating" timer, setting
		/// this flag to off will prevent (perhaps many many) unnecessary calls to
		/// ResetTimer. Having the flag on by default means that "natively one
		/// shot" timers can be either one shot or repeating timers with no
		/// additional work. Also, "natively repeating" timers still work with the
		/// default setting, but with potentially many create and destroy calls.
		/// </summary>
		// Token: 0x060109F6 RID: 68086 RVA: 0x001732F5 File Offset: 0x001714F5
		public virtual void TimerEventResetsTimerOn()
		{
			vtkGenericRenderWindowInteractor.vtkGenericRenderWindowInteractor_TimerEventResetsTimerOn_12(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400134C RID: 4940
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericRenderWindowInteractor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400134D RID: 4941
		public new static readonly string MRClassNameKey = "class vtkGenericRenderWindowInteractor";
	}
}
