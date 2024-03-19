using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkWidgetEventTranslator
	/// </summary>
	/// <remarks>
	///    map VTK events into widget events
	///
	/// vtkWidgetEventTranslator maps VTK events (defined on vtkCommand) into
	/// widget events (defined in vtkWidgetEvent.h). This class is typically used
	/// in combination with vtkWidgetCallbackMapper, which is responsible for
	/// translating widget events into method callbacks, and then invoking the
	/// callbacks.
	///
	/// This class can be used to define different mappings of VTK events into
	/// the widget events. Thus widgets can be reconfigured to use different
	/// event bindings.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkWidgetEvent vtkCommand vtkInteractorObserver
	/// </seealso>
	// Token: 0x0200038E RID: 910
	public class vtkWidgetEventTranslator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A589 RID: 42377 RVA: 0x000EAE23 File Offset: 0x000E9023
		static vtkWidgetEventTranslator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWidgetEventTranslator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWidgetEventTranslator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A58A RID: 42378 RVA: 0x000EAE4B File Offset: 0x000E904B
		public vtkWidgetEventTranslator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A58B RID: 42379
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWidgetEventTranslator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600A58C RID: 42380 RVA: 0x000EAE5C File Offset: 0x000E905C
		public new static vtkWidgetEventTranslator New()
		{
			vtkWidgetEventTranslator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWidgetEventTranslator.vtkWidgetEventTranslator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWidgetEventTranslator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600A58D RID: 42381 RVA: 0x000EAEB0 File Offset: 0x000E90B0
		public vtkWidgetEventTranslator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkWidgetEventTranslator.vtkWidgetEventTranslator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A58E RID: 42382 RVA: 0x000EAEF4 File Offset: 0x000E90F4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A58F RID: 42383
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetEventTranslator_ClearEvents_01(HandleRef pThis);

		/// <summary>
		/// Clear all events from the translator (i.e., no events will be
		/// translated).
		/// </summary>
		// Token: 0x0600A590 RID: 42384 RVA: 0x000EAEFF File Offset: 0x000E90FF
		public void ClearEvents()
		{
			vtkWidgetEventTranslator.vtkWidgetEventTranslator_ClearEvents_01(base.GetCppThis());
		}

		// Token: 0x0600A591 RID: 42385
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWidgetEventTranslator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x0600A592 RID: 42386 RVA: 0x000EAF10 File Offset: 0x000E9110
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkWidgetEventTranslator.vtkWidgetEventTranslator_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600A593 RID: 42387
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWidgetEventTranslator_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x0600A594 RID: 42388 RVA: 0x000EAF30 File Offset: 0x000E9130
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkWidgetEventTranslator.vtkWidgetEventTranslator_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600A595 RID: 42389
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkWidgetEventTranslator_GetTranslation_04(HandleRef pThis, uint VTKEvent);

		/// <summary>
		/// Translate a VTK event into a widget event. If no event mapping is found,
		/// then the methods return vtkWidgetEvent::NoEvent or a nullptr string.
		/// </summary>
		// Token: 0x0600A596 RID: 42390 RVA: 0x000EAF4C File Offset: 0x000E914C
		public uint GetTranslation(uint VTKEvent)
		{
			return vtkWidgetEventTranslator.vtkWidgetEventTranslator_GetTranslation_04(base.GetCppThis(), VTKEvent);
		}

		// Token: 0x0600A597 RID: 42391
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWidgetEventTranslator_GetTranslation_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string VTKEvent);

		/// <summary>
		/// Translate a VTK event into a widget event. If no event mapping is found,
		/// then the methods return vtkWidgetEvent::NoEvent or a nullptr string.
		/// </summary>
		// Token: 0x0600A598 RID: 42392 RVA: 0x000EAF6C File Offset: 0x000E916C
		public string GetTranslation(string VTKEvent)
		{
			string s = Marshal.PtrToStringAnsi(vtkWidgetEventTranslator.vtkWidgetEventTranslator_GetTranslation_05(base.GetCppThis(), VTKEvent));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600A599 RID: 42393
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkWidgetEventTranslator_GetTranslation_06(HandleRef pThis, uint VTKEvent, int modifier, sbyte keyCode, int repeatCount, [MarshalAs(UnmanagedType.LPUTF8Str)] string keySym);

		/// <summary>
		/// Translate a VTK event into a widget event. If no event mapping is found,
		/// then the methods return vtkWidgetEvent::NoEvent or a nullptr string.
		/// </summary>
		// Token: 0x0600A59A RID: 42394 RVA: 0x000EAFA8 File Offset: 0x000E91A8
		public uint GetTranslation(uint VTKEvent, int modifier, sbyte keyCode, int repeatCount, string keySym)
		{
			return vtkWidgetEventTranslator.vtkWidgetEventTranslator_GetTranslation_06(base.GetCppThis(), VTKEvent, modifier, keyCode, repeatCount, keySym);
		}

		// Token: 0x0600A59B RID: 42395
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkWidgetEventTranslator_GetTranslation_07(HandleRef pThis, uint VTKEvent, HandleRef edata);

		/// <summary>
		/// Translate a VTK event into a widget event. If no event mapping is found,
		/// then the methods return vtkWidgetEvent::NoEvent or a nullptr string.
		/// </summary>
		// Token: 0x0600A59C RID: 42396 RVA: 0x000EAFD0 File Offset: 0x000E91D0
		public uint GetTranslation(uint VTKEvent, vtkEventData edata)
		{
			return vtkWidgetEventTranslator.vtkWidgetEventTranslator_GetTranslation_07(base.GetCppThis(), VTKEvent, (edata == null) ? default(HandleRef) : edata.GetCppThis());
		}

		// Token: 0x0600A59D RID: 42397
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkWidgetEventTranslator_GetTranslation_08(HandleRef pThis, HandleRef VTKEvent);

		/// <summary>
		/// Translate a VTK event into a widget event. If no event mapping is found,
		/// then the methods return vtkWidgetEvent::NoEvent or a nullptr string.
		/// </summary>
		// Token: 0x0600A59E RID: 42398 RVA: 0x000EB008 File Offset: 0x000E9208
		public uint GetTranslation(vtkEvent VTKEvent)
		{
			return vtkWidgetEventTranslator.vtkWidgetEventTranslator_GetTranslation_08(base.GetCppThis(), (VTKEvent == null) ? default(HandleRef) : VTKEvent.GetCppThis());
		}

		// Token: 0x0600A59F RID: 42399
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWidgetEventTranslator_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x0600A5A0 RID: 42400 RVA: 0x000EB03C File Offset: 0x000E923C
		public override int IsA(string type)
		{
			return vtkWidgetEventTranslator.vtkWidgetEventTranslator_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0600A5A1 RID: 42401
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWidgetEventTranslator_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x0600A5A2 RID: 42402 RVA: 0x000EB05C File Offset: 0x000E925C
		public new static int IsTypeOf(string type)
		{
			return vtkWidgetEventTranslator.vtkWidgetEventTranslator_IsTypeOf_10(type);
		}

		// Token: 0x0600A5A3 RID: 42403
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWidgetEventTranslator_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x0600A5A4 RID: 42404 RVA: 0x000EB078 File Offset: 0x000E9278
		public new vtkWidgetEventTranslator NewInstance()
		{
			vtkWidgetEventTranslator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWidgetEventTranslator.vtkWidgetEventTranslator_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWidgetEventTranslator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A5A5 RID: 42405
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWidgetEventTranslator_RemoveTranslation_13(HandleRef pThis, uint VTKEvent, int modifier, sbyte keyCode, int repeatCount, [MarshalAs(UnmanagedType.LPUTF8Str)] string keySym);

		/// <summary>
		/// Remove translations for a binding.
		/// Returns the number of translations removed.
		/// </summary>
		// Token: 0x0600A5A6 RID: 42406 RVA: 0x000EB0D4 File Offset: 0x000E92D4
		public int RemoveTranslation(uint VTKEvent, int modifier, sbyte keyCode, int repeatCount, string keySym)
		{
			return vtkWidgetEventTranslator.vtkWidgetEventTranslator_RemoveTranslation_13(base.GetCppThis(), VTKEvent, modifier, keyCode, repeatCount, keySym);
		}

		// Token: 0x0600A5A7 RID: 42407
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWidgetEventTranslator_RemoveTranslation_14(HandleRef pThis, HandleRef e);

		/// <summary>
		/// Remove translations for a binding.
		/// Returns the number of translations removed.
		/// </summary>
		// Token: 0x0600A5A8 RID: 42408 RVA: 0x000EB0FC File Offset: 0x000E92FC
		public int RemoveTranslation(vtkEvent e)
		{
			return vtkWidgetEventTranslator.vtkWidgetEventTranslator_RemoveTranslation_14(base.GetCppThis(), (e == null) ? default(HandleRef) : e.GetCppThis());
		}

		// Token: 0x0600A5A9 RID: 42409
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWidgetEventTranslator_RemoveTranslation_15(HandleRef pThis, HandleRef e);

		/// <summary>
		/// Remove translations for a binding.
		/// Returns the number of translations removed.
		/// </summary>
		// Token: 0x0600A5AA RID: 42410 RVA: 0x000EB130 File Offset: 0x000E9330
		public int RemoveTranslation(vtkEventData e)
		{
			return vtkWidgetEventTranslator.vtkWidgetEventTranslator_RemoveTranslation_15(base.GetCppThis(), (e == null) ? default(HandleRef) : e.GetCppThis());
		}

		// Token: 0x0600A5AB RID: 42411
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWidgetEventTranslator_RemoveTranslation_16(HandleRef pThis, uint VTKEvent);

		/// <summary>
		/// Remove translations for a binding.
		/// Returns the number of translations removed.
		/// </summary>
		// Token: 0x0600A5AC RID: 42412 RVA: 0x000EB164 File Offset: 0x000E9364
		public int RemoveTranslation(uint VTKEvent)
		{
			return vtkWidgetEventTranslator.vtkWidgetEventTranslator_RemoveTranslation_16(base.GetCppThis(), VTKEvent);
		}

		// Token: 0x0600A5AD RID: 42413
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWidgetEventTranslator_RemoveTranslation_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string VTKEvent);

		/// <summary>
		/// Remove translations for a binding.
		/// Returns the number of translations removed.
		/// </summary>
		// Token: 0x0600A5AE RID: 42414 RVA: 0x000EB184 File Offset: 0x000E9384
		public int RemoveTranslation(string VTKEvent)
		{
			return vtkWidgetEventTranslator.vtkWidgetEventTranslator_RemoveTranslation_17(base.GetCppThis(), VTKEvent);
		}

		// Token: 0x0600A5AF RID: 42415
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWidgetEventTranslator_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x0600A5B0 RID: 42416 RVA: 0x000EB1A4 File Offset: 0x000E93A4
		public new static vtkWidgetEventTranslator SafeDownCast(vtkObjectBase o)
		{
			vtkWidgetEventTranslator vtkWidgetEventTranslator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWidgetEventTranslator.vtkWidgetEventTranslator_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600A5B1 RID: 42417
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetEventTranslator_SetTranslation_19(HandleRef pThis, uint VTKEvent, uint widgetEvent);

		/// <summary>
		/// Use these methods to create the translation from a VTK event to a widget
		/// event. Specifying vtkWidgetEvent::NoEvent or an empty
		/// string for the (toEvent) erases the mapping for the event.
		/// </summary>
		// Token: 0x0600A5B2 RID: 42418 RVA: 0x000EB223 File Offset: 0x000E9423
		public void SetTranslation(uint VTKEvent, uint widgetEvent)
		{
			vtkWidgetEventTranslator.vtkWidgetEventTranslator_SetTranslation_19(base.GetCppThis(), VTKEvent, widgetEvent);
		}

		// Token: 0x0600A5B3 RID: 42419
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetEventTranslator_SetTranslation_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string VTKEvent, [MarshalAs(UnmanagedType.LPUTF8Str)] string widgetEvent);

		/// <summary>
		/// Use these methods to create the translation from a VTK event to a widget
		/// event. Specifying vtkWidgetEvent::NoEvent or an empty
		/// string for the (toEvent) erases the mapping for the event.
		/// </summary>
		// Token: 0x0600A5B4 RID: 42420 RVA: 0x000EB234 File Offset: 0x000E9434
		public void SetTranslation(string VTKEvent, string widgetEvent)
		{
			vtkWidgetEventTranslator.vtkWidgetEventTranslator_SetTranslation_20(base.GetCppThis(), VTKEvent, widgetEvent);
		}

		// Token: 0x0600A5B5 RID: 42421
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetEventTranslator_SetTranslation_21(HandleRef pThis, uint VTKEvent, int modifier, sbyte keyCode, int repeatCount, [MarshalAs(UnmanagedType.LPUTF8Str)] string keySym, uint widgetEvent);

		/// <summary>
		/// Use these methods to create the translation from a VTK event to a widget
		/// event. Specifying vtkWidgetEvent::NoEvent or an empty
		/// string for the (toEvent) erases the mapping for the event.
		/// </summary>
		// Token: 0x0600A5B6 RID: 42422 RVA: 0x000EB245 File Offset: 0x000E9445
		public void SetTranslation(uint VTKEvent, int modifier, sbyte keyCode, int repeatCount, string keySym, uint widgetEvent)
		{
			vtkWidgetEventTranslator.vtkWidgetEventTranslator_SetTranslation_21(base.GetCppThis(), VTKEvent, modifier, keyCode, repeatCount, keySym, widgetEvent);
		}

		// Token: 0x0600A5B7 RID: 42423
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetEventTranslator_SetTranslation_22(HandleRef pThis, HandleRef VTKevent, uint widgetEvent);

		/// <summary>
		/// Use these methods to create the translation from a VTK event to a widget
		/// event. Specifying vtkWidgetEvent::NoEvent or an empty
		/// string for the (toEvent) erases the mapping for the event.
		/// </summary>
		// Token: 0x0600A5B8 RID: 42424 RVA: 0x000EB260 File Offset: 0x000E9460
		public void SetTranslation(vtkEvent VTKevent, uint widgetEvent)
		{
			vtkWidgetEventTranslator.vtkWidgetEventTranslator_SetTranslation_22(base.GetCppThis(), (VTKevent == null) ? default(HandleRef) : VTKevent.GetCppThis(), widgetEvent);
		}

		// Token: 0x0600A5B9 RID: 42425
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetEventTranslator_SetTranslation_23(HandleRef pThis, uint VTKEvent, HandleRef edata, uint widgetEvent);

		/// <summary>
		/// Use these methods to create the translation from a VTK event to a widget
		/// event. Specifying vtkWidgetEvent::NoEvent or an empty
		/// string for the (toEvent) erases the mapping for the event.
		/// </summary>
		// Token: 0x0600A5BA RID: 42426 RVA: 0x000EB290 File Offset: 0x000E9490
		public void SetTranslation(uint VTKEvent, vtkEventData edata, uint widgetEvent)
		{
			vtkWidgetEventTranslator.vtkWidgetEventTranslator_SetTranslation_23(base.GetCppThis(), VTKEvent, (edata == null) ? default(HandleRef) : edata.GetCppThis(), widgetEvent);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D51 RID: 3409
		public new const string MRFullTypeName = "Kitware.VTK.vtkWidgetEventTranslator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D52 RID: 3410
		public new static readonly string MRClassNameKey = "class vtkWidgetEventTranslator";
	}
}
