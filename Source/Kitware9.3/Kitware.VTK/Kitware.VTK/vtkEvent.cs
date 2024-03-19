using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkEvent
	/// </summary>
	/// <remarks>
	///    a complete specification of a VTK event including all modifiers
	///
	/// vtkEvent is a class that fully describes a VTK event. It is used by the
	/// widgets to help specify the mapping between VTK events and widget events.
	/// </remarks>
	// Token: 0x02000315 RID: 789
	public class vtkEvent : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008DBD RID: 36285 RVA: 0x000CA16B File Offset: 0x000C836B
		static vtkEvent()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEvent.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEvent"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008DBE RID: 36286 RVA: 0x000CA193 File Offset: 0x000C8393
		public vtkEvent(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008DBF RID: 36287
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEvent_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The object factory constructor.
		/// </summary>
		// Token: 0x06008DC0 RID: 36288 RVA: 0x000CA1A4 File Offset: 0x000C83A4
		public new static vtkEvent New()
		{
			vtkEvent result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEvent.vtkEvent_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEvent)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// The object factory constructor.
		/// </summary>
		// Token: 0x06008DC1 RID: 36289 RVA: 0x000CA1F8 File Offset: 0x000C83F8
		public vtkEvent() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkEvent.vtkEvent_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008DC2 RID: 36290 RVA: 0x000CA23C File Offset: 0x000C843C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008DC3 RID: 36291
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkEvent_GetEventId_01(HandleRef pThis);

		/// <summary>
		/// Set the modifier for the event.
		/// </summary>
		// Token: 0x06008DC4 RID: 36292 RVA: 0x000CA248 File Offset: 0x000C8448
		public virtual uint GetEventId()
		{
			return vtkEvent.vtkEvent_GetEventId_01(base.GetCppThis());
		}

		// Token: 0x06008DC5 RID: 36293
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern sbyte vtkEvent_GetKeyCode_02(HandleRef pThis);

		/// <summary>
		/// Set the KeyCode for the event.
		/// </summary>
		// Token: 0x06008DC6 RID: 36294 RVA: 0x000CA268 File Offset: 0x000C8468
		public virtual sbyte GetKeyCode()
		{
			return vtkEvent.vtkEvent_GetKeyCode_02(base.GetCppThis());
		}

		// Token: 0x06008DC7 RID: 36295
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEvent_GetKeySym_03(HandleRef pThis);

		/// <summary>
		/// Set the complex key symbol (compound key strokes) for the event.
		/// </summary>
		// Token: 0x06008DC8 RID: 36296 RVA: 0x000CA288 File Offset: 0x000C8488
		public virtual string GetKeySym()
		{
			string s = Marshal.PtrToStringAnsi(vtkEvent.vtkEvent_GetKeySym_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06008DC9 RID: 36297
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEvent_GetModifier_04(HandleRef pThis);

		/// <summary>
		/// Set the modifier for the event.
		/// </summary>
		// Token: 0x06008DCA RID: 36298 RVA: 0x000CA2C4 File Offset: 0x000C84C4
		public virtual int GetModifier()
		{
			return vtkEvent.vtkEvent_GetModifier_04(base.GetCppThis());
		}

		// Token: 0x06008DCB RID: 36299
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEvent_GetModifier_05(HandleRef arg0);

		/// <summary>
		/// Convenience method computes the event modifier from an interactor.
		/// </summary>
		// Token: 0x06008DCC RID: 36300 RVA: 0x000CA2E4 File Offset: 0x000C84E4
		public static int GetModifier(vtkRenderWindowInteractor arg0)
		{
			return vtkEvent.vtkEvent_GetModifier_05((arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008DCD RID: 36301
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEvent_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x06008DCE RID: 36302 RVA: 0x000CA314 File Offset: 0x000C8514
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEvent.vtkEvent_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06008DCF RID: 36303
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEvent_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x06008DD0 RID: 36304 RVA: 0x000CA334 File Offset: 0x000C8534
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEvent.vtkEvent_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06008DD1 RID: 36305
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEvent_GetRepeatCount_08(HandleRef pThis);

		/// <summary>
		/// Set the repease count for the event.
		/// </summary>
		// Token: 0x06008DD2 RID: 36306 RVA: 0x000CA350 File Offset: 0x000C8550
		public virtual int GetRepeatCount()
		{
			return vtkEvent.vtkEvent_GetRepeatCount_08(base.GetCppThis());
		}

		// Token: 0x06008DD3 RID: 36307
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEvent_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x06008DD4 RID: 36308 RVA: 0x000CA370 File Offset: 0x000C8570
		public override int IsA(string type)
		{
			return vtkEvent.vtkEvent_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06008DD5 RID: 36309
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEvent_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x06008DD6 RID: 36310 RVA: 0x000CA390 File Offset: 0x000C8590
		public new static int IsTypeOf(string type)
		{
			return vtkEvent.vtkEvent_IsTypeOf_10(type);
		}

		// Token: 0x06008DD7 RID: 36311
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEvent_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x06008DD8 RID: 36312 RVA: 0x000CA3AC File Offset: 0x000C85AC
		public new vtkEvent NewInstance()
		{
			vtkEvent result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEvent.vtkEvent_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEvent)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008DD9 RID: 36313
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEvent_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x06008DDA RID: 36314 RVA: 0x000CA408 File Offset: 0x000C8608
		public new static vtkEvent SafeDownCast(vtkObjectBase o)
		{
			vtkEvent vtkEvent = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEvent.vtkEvent_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEvent = (vtkEvent)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEvent.Register(null);
				}
			}
			return vtkEvent;
		}

		// Token: 0x06008DDB RID: 36315
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEvent_SetEventId_14(HandleRef pThis, uint _arg);

		/// <summary>
		/// Set the modifier for the event.
		/// </summary>
		// Token: 0x06008DDC RID: 36316 RVA: 0x000CA487 File Offset: 0x000C8687
		public virtual void SetEventId(uint _arg)
		{
			vtkEvent.vtkEvent_SetEventId_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06008DDD RID: 36317
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEvent_SetKeyCode_15(HandleRef pThis, sbyte _arg);

		/// <summary>
		/// Set the KeyCode for the event.
		/// </summary>
		// Token: 0x06008DDE RID: 36318 RVA: 0x000CA497 File Offset: 0x000C8697
		public virtual void SetKeyCode(sbyte _arg)
		{
			vtkEvent.vtkEvent_SetKeyCode_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06008DDF RID: 36319
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEvent_SetKeySym_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the complex key symbol (compound key strokes) for the event.
		/// </summary>
		// Token: 0x06008DE0 RID: 36320 RVA: 0x000CA4A7 File Offset: 0x000C86A7
		public virtual void SetKeySym(string _arg)
		{
			vtkEvent.vtkEvent_SetKeySym_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06008DE1 RID: 36321
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEvent_SetModifier_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the modifier for the event.
		/// </summary>
		// Token: 0x06008DE2 RID: 36322 RVA: 0x000CA4B7 File Offset: 0x000C86B7
		public virtual void SetModifier(int _arg)
		{
			vtkEvent.vtkEvent_SetModifier_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06008DE3 RID: 36323
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEvent_SetRepeatCount_18(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the repease count for the event.
		/// </summary>
		// Token: 0x06008DE4 RID: 36324 RVA: 0x000CA4C7 File Offset: 0x000C86C7
		public virtual void SetRepeatCount(int _arg)
		{
			vtkEvent.vtkEvent_SetRepeatCount_18(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BDA RID: 3034
		public new const string MRFullTypeName = "Kitware.VTK.vtkEvent";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BDB RID: 3035
		public new static readonly string MRClassNameKey = "class vtkEvent";

		/// <summary>
		/// Ways to specify modifiers to VTK events. These can be logical OR'd to
		/// produce combinations of modifiers.
		/// </summary>
		// Token: 0x02000316 RID: 790
		public enum EventModifiers
		{
			/// <summary>enum member</summary>
			// Token: 0x04000BDD RID: 3037
			AltModifier = 4,
			/// <summary>enum member</summary>
			// Token: 0x04000BDE RID: 3038
			AnyModifier = -1,
			/// <summary>enum member</summary>
			// Token: 0x04000BDF RID: 3039
			ControlModifier = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000BE0 RID: 3040
			NoModifier = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000BE1 RID: 3041
			ShiftModifier
		}
	}
}
