using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkWidgetCallbackMapper
	/// </summary>
	/// <remarks>
	///    map widget events into callbacks
	///
	/// vtkWidgetCallbackMapper maps widget events (defined in vtkWidgetEvent.h)
	/// into static class methods, and provides facilities to invoke the methods.
	/// This class is templated and meant to be used as an internal helper class
	/// by the widget classes. The class works in combination with the class
	/// vtkWidgetEventTranslator, which translates VTK events into widget events.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkWidgetEvent vtkWidgetEventTranslator
	/// </seealso>
	// Token: 0x0200038A RID: 906
	public class vtkWidgetCallbackMapper : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A551 RID: 42321 RVA: 0x000EA803 File Offset: 0x000E8A03
		static vtkWidgetCallbackMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWidgetCallbackMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWidgetCallbackMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A552 RID: 42322 RVA: 0x000EA82B File Offset: 0x000E8A2B
		public vtkWidgetCallbackMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A553 RID: 42323
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWidgetCallbackMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x0600A554 RID: 42324 RVA: 0x000EA83C File Offset: 0x000E8A3C
		public new static vtkWidgetCallbackMapper New()
		{
			vtkWidgetCallbackMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWidgetCallbackMapper.vtkWidgetCallbackMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWidgetCallbackMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x0600A555 RID: 42325 RVA: 0x000EA890 File Offset: 0x000E8A90
		public vtkWidgetCallbackMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkWidgetCallbackMapper.vtkWidgetCallbackMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A556 RID: 42326 RVA: 0x000EA8D4 File Offset: 0x000E8AD4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A557 RID: 42327
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWidgetCallbackMapper_GetEventTranslator_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the vtkWidgetEventTranslator to coordinate with.
		/// </summary>
		// Token: 0x0600A558 RID: 42328 RVA: 0x000EA8E0 File Offset: 0x000E8AE0
		public virtual vtkWidgetEventTranslator GetEventTranslator()
		{
			vtkWidgetEventTranslator vtkWidgetEventTranslator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWidgetCallbackMapper.vtkWidgetCallbackMapper_GetEventTranslator_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWidgetEventTranslator = (vtkWidgetEventTranslator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWidgetEventTranslator.Register(null);
				}
			}
			return vtkWidgetEventTranslator;
		}

		// Token: 0x0600A559 RID: 42329
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWidgetCallbackMapper_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x0600A55A RID: 42330 RVA: 0x000EA950 File Offset: 0x000E8B50
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkWidgetCallbackMapper.vtkWidgetCallbackMapper_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600A55B RID: 42331
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWidgetCallbackMapper_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x0600A55C RID: 42332 RVA: 0x000EA970 File Offset: 0x000E8B70
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkWidgetCallbackMapper.vtkWidgetCallbackMapper_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600A55D RID: 42333
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetCallbackMapper_InvokeCallback_04(HandleRef pThis, uint widgetEvent);

		/// <summary>
		/// This method invokes the callback given a widget event. A non-zero value
		/// is returned if the listed event is registered.
		/// </summary>
		// Token: 0x0600A55E RID: 42334 RVA: 0x000EA98A File Offset: 0x000E8B8A
		public void InvokeCallback(uint widgetEvent)
		{
			vtkWidgetCallbackMapper.vtkWidgetCallbackMapper_InvokeCallback_04(base.GetCppThis(), widgetEvent);
		}

		// Token: 0x0600A55F RID: 42335
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWidgetCallbackMapper_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x0600A560 RID: 42336 RVA: 0x000EA99C File Offset: 0x000E8B9C
		public override int IsA(string type)
		{
			return vtkWidgetCallbackMapper.vtkWidgetCallbackMapper_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600A561 RID: 42337
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWidgetCallbackMapper_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x0600A562 RID: 42338 RVA: 0x000EA9BC File Offset: 0x000E8BBC
		public new static int IsTypeOf(string type)
		{
			return vtkWidgetCallbackMapper.vtkWidgetCallbackMapper_IsTypeOf_06(type);
		}

		// Token: 0x0600A563 RID: 42339
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWidgetCallbackMapper_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x0600A564 RID: 42340 RVA: 0x000EA9D8 File Offset: 0x000E8BD8
		public new vtkWidgetCallbackMapper NewInstance()
		{
			vtkWidgetCallbackMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWidgetCallbackMapper.vtkWidgetCallbackMapper_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWidgetCallbackMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A565 RID: 42341
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWidgetCallbackMapper_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x0600A566 RID: 42342 RVA: 0x000EAA34 File Offset: 0x000E8C34
		public new static vtkWidgetCallbackMapper SafeDownCast(vtkObjectBase o)
		{
			vtkWidgetCallbackMapper vtkWidgetCallbackMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWidgetCallbackMapper.vtkWidgetCallbackMapper_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWidgetCallbackMapper = (vtkWidgetCallbackMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWidgetCallbackMapper.Register(null);
				}
			}
			return vtkWidgetCallbackMapper;
		}

		// Token: 0x0600A567 RID: 42343
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetCallbackMapper_SetCallbackMethod_10(HandleRef pThis, uint VTKEvent, uint widgetEvent, HandleRef w, vtkWidgetCallbackMapper.CallbackType f);

		/// <summary>
		/// This class works with the class vtkWidgetEventTranslator to set up the
		/// initial coorespondence between VTK events, widget events, and callbacks.
		/// Different flavors of the SetCallbackMethod() are available depending on
		/// what sort of modifiers are to be associated with a particular event.
		/// Typically the widgets should use this method to set up their event
		/// callbacks. If modifiers are not provided (i.e., the VTKEvent is a
		/// unsigned long eventId) then modifiers are ignored. Otherwise, a vtkEvent
		/// instance is used to fully quality the events.
		/// </summary>
		// Token: 0x0600A568 RID: 42344 RVA: 0x000EAAB4 File Offset: 0x000E8CB4
		public void SetCallbackMethod(uint VTKEvent, uint widgetEvent, vtkAbstractWidget w, vtkWidgetCallbackMapper.CallbackType f)
		{
			vtkWidgetCallbackMapper.vtkWidgetCallbackMapper_SetCallbackMethod_10(base.GetCppThis(), VTKEvent, widgetEvent, (w == null) ? default(HandleRef) : w.GetCppThis(), f);
		}

		// Token: 0x0600A569 RID: 42345
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetCallbackMapper_SetCallbackMethod_11(HandleRef pThis, uint VTKEvent, int modifiers, sbyte keyCode, int repeatCount, [MarshalAs(UnmanagedType.LPUTF8Str)] string keySym, uint widgetEvent, HandleRef w, vtkWidgetCallbackMapper.CallbackType f);

		/// <summary>
		/// This class works with the class vtkWidgetEventTranslator to set up the
		/// initial coorespondence between VTK events, widget events, and callbacks.
		/// Different flavors of the SetCallbackMethod() are available depending on
		/// what sort of modifiers are to be associated with a particular event.
		/// Typically the widgets should use this method to set up their event
		/// callbacks. If modifiers are not provided (i.e., the VTKEvent is a
		/// unsigned long eventId) then modifiers are ignored. Otherwise, a vtkEvent
		/// instance is used to fully quality the events.
		/// </summary>
		// Token: 0x0600A56A RID: 42346 RVA: 0x000EAAE8 File Offset: 0x000E8CE8
		public void SetCallbackMethod(uint VTKEvent, int modifiers, sbyte keyCode, int repeatCount, string keySym, uint widgetEvent, vtkAbstractWidget w, vtkWidgetCallbackMapper.CallbackType f)
		{
			vtkWidgetCallbackMapper.vtkWidgetCallbackMapper_SetCallbackMethod_11(base.GetCppThis(), VTKEvent, modifiers, keyCode, repeatCount, keySym, widgetEvent, (w == null) ? default(HandleRef) : w.GetCppThis(), f);
		}

		// Token: 0x0600A56B RID: 42347
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetCallbackMapper_SetCallbackMethod_12(HandleRef pThis, uint VTKEvent, HandleRef ed, uint widgetEvent, HandleRef w, vtkWidgetCallbackMapper.CallbackType f);

		/// <summary>
		/// This class works with the class vtkWidgetEventTranslator to set up the
		/// initial coorespondence between VTK events, widget events, and callbacks.
		/// Different flavors of the SetCallbackMethod() are available depending on
		/// what sort of modifiers are to be associated with a particular event.
		/// Typically the widgets should use this method to set up their event
		/// callbacks. If modifiers are not provided (i.e., the VTKEvent is a
		/// unsigned long eventId) then modifiers are ignored. Otherwise, a vtkEvent
		/// instance is used to fully quality the events.
		/// </summary>
		// Token: 0x0600A56C RID: 42348 RVA: 0x000EAB24 File Offset: 0x000E8D24
		public void SetCallbackMethod(uint VTKEvent, vtkEventData ed, uint widgetEvent, vtkAbstractWidget w, vtkWidgetCallbackMapper.CallbackType f)
		{
			vtkWidgetCallbackMapper.vtkWidgetCallbackMapper_SetCallbackMethod_12(base.GetCppThis(), VTKEvent, (ed == null) ? default(HandleRef) : ed.GetCppThis(), widgetEvent, (w == null) ? default(HandleRef) : w.GetCppThis(), f);
		}

		// Token: 0x0600A56D RID: 42349
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetCallbackMapper_SetEventTranslator_13(HandleRef pThis, HandleRef t);

		/// <summary>
		/// Specify the vtkWidgetEventTranslator to coordinate with.
		/// </summary>
		// Token: 0x0600A56E RID: 42350 RVA: 0x000EAB70 File Offset: 0x000E8D70
		public void SetEventTranslator(vtkWidgetEventTranslator t)
		{
			vtkWidgetCallbackMapper.vtkWidgetCallbackMapper_SetEventTranslator_13(base.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D2B RID: 3371
		public new const string MRFullTypeName = "Kitware.VTK.vtkWidgetCallbackMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D2C RID: 3372
		public new static readonly string MRClassNameKey = "class vtkWidgetCallbackMapper";

		/// <summary>
		/// Convenient typedef for working with callbacks.
		/// </summary>
		// Token: 0x0200038B RID: 907
		// (Invoke) Token: 0x0600A570 RID: 42352
		public delegate void CallbackType(IntPtr arg0);
	}
}
