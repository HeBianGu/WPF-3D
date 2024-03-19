using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkWidgetEvent
	/// </summary>
	/// <remarks>
	///    define widget events
	///
	/// vtkWidgetEvent defines widget events. These events are processed by
	/// subclasses of vtkInteractorObserver.
	/// </remarks>
	// Token: 0x0200038C RID: 908
	public class vtkWidgetEvent : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A573 RID: 42355 RVA: 0x000EAB9F File Offset: 0x000E8D9F
		static vtkWidgetEvent()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWidgetEvent.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWidgetEvent"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A574 RID: 42356 RVA: 0x000EABC7 File Offset: 0x000E8DC7
		public vtkWidgetEvent(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A575 RID: 42357
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWidgetEvent_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The object factory constructor.
		/// </summary>
		// Token: 0x0600A576 RID: 42358 RVA: 0x000EABD8 File Offset: 0x000E8DD8
		public new static vtkWidgetEvent New()
		{
			vtkWidgetEvent result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWidgetEvent.vtkWidgetEvent_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWidgetEvent)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// The object factory constructor.
		/// </summary>
		// Token: 0x0600A577 RID: 42359 RVA: 0x000EAC2C File Offset: 0x000E8E2C
		public vtkWidgetEvent() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkWidgetEvent.vtkWidgetEvent_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A578 RID: 42360 RVA: 0x000EAC70 File Offset: 0x000E8E70
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A579 RID: 42361
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkWidgetEvent_GetEventIdFromString_01([MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// Convenience methods for translating between event names and event ids.
		/// </summary>
		// Token: 0x0600A57A RID: 42362 RVA: 0x000EAC7C File Offset: 0x000E8E7C
		public static uint GetEventIdFromString(string arg0)
		{
			return vtkWidgetEvent.vtkWidgetEvent_GetEventIdFromString_01(arg0);
		}

		// Token: 0x0600A57B RID: 42363
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWidgetEvent_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x0600A57C RID: 42364 RVA: 0x000EAC98 File Offset: 0x000E8E98
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkWidgetEvent.vtkWidgetEvent_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600A57D RID: 42365
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWidgetEvent_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x0600A57E RID: 42366 RVA: 0x000EACB8 File Offset: 0x000E8EB8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkWidgetEvent.vtkWidgetEvent_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600A57F RID: 42367
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWidgetEvent_GetStringFromEventId_04(uint arg0);

		/// <summary>
		/// Convenience methods for translating between event names and event ids.
		/// </summary>
		// Token: 0x0600A580 RID: 42368 RVA: 0x000EACD4 File Offset: 0x000E8ED4
		public static string GetStringFromEventId(uint arg0)
		{
			string s = Marshal.PtrToStringAnsi(vtkWidgetEvent.vtkWidgetEvent_GetStringFromEventId_04(arg0));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600A581 RID: 42369
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWidgetEvent_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x0600A582 RID: 42370 RVA: 0x000EAD0C File Offset: 0x000E8F0C
		public override int IsA(string type)
		{
			return vtkWidgetEvent.vtkWidgetEvent_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600A583 RID: 42371
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWidgetEvent_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x0600A584 RID: 42372 RVA: 0x000EAD2C File Offset: 0x000E8F2C
		public new static int IsTypeOf(string type)
		{
			return vtkWidgetEvent.vtkWidgetEvent_IsTypeOf_06(type);
		}

		// Token: 0x0600A585 RID: 42373
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWidgetEvent_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x0600A586 RID: 42374 RVA: 0x000EAD48 File Offset: 0x000E8F48
		public new vtkWidgetEvent NewInstance()
		{
			vtkWidgetEvent result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWidgetEvent.vtkWidgetEvent_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWidgetEvent)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A587 RID: 42375
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWidgetEvent_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x0600A588 RID: 42376 RVA: 0x000EADA4 File Offset: 0x000E8FA4
		public new static vtkWidgetEvent SafeDownCast(vtkObjectBase o)
		{
			vtkWidgetEvent vtkWidgetEvent = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWidgetEvent.vtkWidgetEvent_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWidgetEvent = (vtkWidgetEvent)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWidgetEvent.Register(null);
				}
			}
			return vtkWidgetEvent;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D2D RID: 3373
		public new const string MRFullTypeName = "Kitware.VTK.vtkWidgetEvent";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D2E RID: 3374
		public new static readonly string MRClassNameKey = "class vtkWidgetEvent";

		/// <summary>
		/// All the widget events are defined here.
		/// </summary>
		// Token: 0x0200038D RID: 909
		public enum WidgetEventIds
		{
			/// <summary>enum member</summary>
			// Token: 0x04000D30 RID: 3376
			AddFinalPoint = 15,
			/// <summary>enum member</summary>
			// Token: 0x04000D31 RID: 3377
			AddFinalPoint3D = 31,
			/// <summary>enum member</summary>
			// Token: 0x04000D32 RID: 3378
			AddPoint = 14,
			/// <summary>enum member</summary>
			// Token: 0x04000D33 RID: 3379
			AddPoint3D = 30,
			/// <summary>enum member</summary>
			// Token: 0x04000D34 RID: 3380
			Completed = 16,
			/// <summary>enum member</summary>
			// Token: 0x04000D35 RID: 3381
			Delete = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000D36 RID: 3382
			Down = 24,
			/// <summary>enum member</summary>
			// Token: 0x04000D37 RID: 3383
			EndResize = 9,
			/// <summary>enum member</summary>
			// Token: 0x04000D38 RID: 3384
			EndRotate = 11,
			/// <summary>enum member</summary>
			// Token: 0x04000D39 RID: 3385
			EndScale = 7,
			/// <summary>enum member</summary>
			// Token: 0x04000D3A RID: 3386
			EndSelect = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000D3B RID: 3387
			EndSelect3D = 28,
			/// <summary>enum member</summary>
			// Token: 0x04000D3C RID: 3388
			EndTranslate = 5,
			/// <summary>enum member</summary>
			// Token: 0x04000D3D RID: 3389
			HoverLeave = 32,
			/// <summary>enum member</summary>
			// Token: 0x04000D3E RID: 3390
			Left = 25,
			/// <summary>enum member</summary>
			// Token: 0x04000D3F RID: 3391
			ModifyEvent = 21,
			/// <summary>enum member</summary>
			// Token: 0x04000D40 RID: 3392
			Move = 12,
			/// <summary>enum member</summary>
			// Token: 0x04000D41 RID: 3393
			Move3D = 29,
			/// <summary>enum member</summary>
			// Token: 0x04000D42 RID: 3394
			NoEvent = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000D43 RID: 3395
			PickDirectionPoint = 19,
			/// <summary>enum member</summary>
			// Token: 0x04000D44 RID: 3396
			PickNormal = 18,
			/// <summary>enum member</summary>
			// Token: 0x04000D45 RID: 3397
			PickPoint = 17,
			/// <summary>enum member</summary>
			// Token: 0x04000D46 RID: 3398
			Reset = 22,
			/// <summary>enum member</summary>
			// Token: 0x04000D47 RID: 3399
			Resize = 8,
			/// <summary>enum member</summary>
			// Token: 0x04000D48 RID: 3400
			Right = 26,
			/// <summary>enum member</summary>
			// Token: 0x04000D49 RID: 3401
			Rotate = 10,
			/// <summary>enum member</summary>
			// Token: 0x04000D4A RID: 3402
			Scale = 6,
			/// <summary>enum member</summary>
			// Token: 0x04000D4B RID: 3403
			Select = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000D4C RID: 3404
			Select3D = 27,
			/// <summary>enum member</summary>
			// Token: 0x04000D4D RID: 3405
			SizeHandles = 13,
			/// <summary>enum member</summary>
			// Token: 0x04000D4E RID: 3406
			TimedOut = 20,
			/// <summary>enum member</summary>
			// Token: 0x04000D4F RID: 3407
			Translate = 4,
			/// <summary>enum member</summary>
			// Token: 0x04000D50 RID: 3408
			Up = 23
		}
	}
}
