using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInteractorStyleRubberBand2D
	/// </summary>
	/// <remarks>
	///    A rubber band interactor for a 2D view
	///
	///
	/// vtkInteractorStyleRubberBand2D manages interaction in a 2D view.
	/// Camera rotation is not allowed with this interactor style.
	/// Zooming affects the camera's parallel scale only, and assumes
	/// that the camera is in parallel projection mode.
	/// The style also allows draws a rubber band using the left button.
	/// All camera changes invoke StartInteractionEvent when the button
	/// is pressed, InteractionEvent when the mouse (or wheel) is moved,
	/// and EndInteractionEvent when the button is released.  The bindings
	/// are as follows:
	/// Left mouse - Select (invokes a SelectionChangedEvent).
	/// Right mouse - Zoom.
	/// Middle mouse - Pan.
	/// Scroll wheel - Zoom.
	/// </remarks>
	// Token: 0x02000071 RID: 113
	public class vtkInteractorStyleRubberBand2D : vtkInteractorStyle
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060014F0 RID: 5360 RVA: 0x00023A4B File Offset: 0x00021C4B
		static vtkInteractorStyleRubberBand2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleRubberBand2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleRubberBand2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060014F1 RID: 5361 RVA: 0x00023A73 File Offset: 0x00021C73
		public vtkInteractorStyleRubberBand2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060014F2 RID: 5362
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleRubberBand2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060014F3 RID: 5363 RVA: 0x00023A84 File Offset: 0x00021C84
		public new static vtkInteractorStyleRubberBand2D New()
		{
			vtkInteractorStyleRubberBand2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleRubberBand2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060014F4 RID: 5364 RVA: 0x00023AD8 File Offset: 0x00021CD8
		public vtkInteractorStyleRubberBand2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060014F5 RID: 5365 RVA: 0x00023B1C File Offset: 0x00021D1C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060014F6 RID: 5366
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleRubberBand2D_GetEndPosition_01(HandleRef pThis);

		/// <summary>
		/// Access to the start and end positions (display coordinates) of the rubber
		/// band pick area. This is a convenience method for the wrapped languages
		/// since the event callData is lost when using those wrappings.
		/// </summary>
		// Token: 0x060014F7 RID: 5367 RVA: 0x00023B28 File Offset: 0x00021D28
		public virtual int[] GetEndPosition()
		{
			IntPtr intPtr = vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_GetEndPosition_01(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060014F8 RID: 5368
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand2D_GetEndPosition_02(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Access to the start and end positions (display coordinates) of the rubber
		/// band pick area. This is a convenience method for the wrapped languages
		/// since the event callData is lost when using those wrappings.
		/// </summary>
		// Token: 0x060014F9 RID: 5369 RVA: 0x00023B70 File Offset: 0x00021D70
		public virtual void GetEndPosition(ref int _arg1, ref int _arg2)
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_GetEndPosition_02(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x060014FA RID: 5370
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand2D_GetEndPosition_03(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Access to the start and end positions (display coordinates) of the rubber
		/// band pick area. This is a convenience method for the wrapped languages
		/// since the event callData is lost when using those wrappings.
		/// </summary>
		// Token: 0x060014FB RID: 5371 RVA: 0x00023B81 File Offset: 0x00021D81
		public virtual void GetEndPosition(IntPtr _arg)
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_GetEndPosition_03(base.GetCppThis(), _arg);
		}

		// Token: 0x060014FC RID: 5372
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleRubberBand2D_GetInteraction_04(HandleRef pThis);

		/// <summary>
		/// Current interaction state
		/// </summary>
		// Token: 0x060014FD RID: 5373 RVA: 0x00023B94 File Offset: 0x00021D94
		public virtual int GetInteraction()
		{
			return vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_GetInteraction_04(base.GetCppThis());
		}

		// Token: 0x060014FE RID: 5374
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleRubberBand2D_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060014FF RID: 5375 RVA: 0x00023BB4 File Offset: 0x00021DB4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06001500 RID: 5376
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleRubberBand2D_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001501 RID: 5377 RVA: 0x00023BD4 File Offset: 0x00021DD4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06001502 RID: 5378
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkInteractorStyleRubberBand2D_GetRenderOnMouseMove_07(HandleRef pThis);

		/// <summary>
		/// Whether to invoke a render when the mouse moves.
		/// </summary>
		// Token: 0x06001503 RID: 5379 RVA: 0x00023BF0 File Offset: 0x00021DF0
		public virtual bool GetRenderOnMouseMove()
		{
			return vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_GetRenderOnMouseMove_07(base.GetCppThis()) != 0;
		}

		// Token: 0x06001504 RID: 5380
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleRubberBand2D_GetStartPosition_08(HandleRef pThis);

		/// <summary>
		/// Access to the start and end positions (display coordinates) of the rubber
		/// band pick area. This is a convenience method for the wrapped languages
		/// since the event callData is lost when using those wrappings.
		/// </summary>
		// Token: 0x06001505 RID: 5381 RVA: 0x00023C18 File Offset: 0x00021E18
		public virtual int[] GetStartPosition()
		{
			IntPtr intPtr = vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_GetStartPosition_08(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06001506 RID: 5382
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand2D_GetStartPosition_09(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Access to the start and end positions (display coordinates) of the rubber
		/// band pick area. This is a convenience method for the wrapped languages
		/// since the event callData is lost when using those wrappings.
		/// </summary>
		// Token: 0x06001507 RID: 5383 RVA: 0x00023C60 File Offset: 0x00021E60
		public virtual void GetStartPosition(ref int _arg1, ref int _arg2)
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_GetStartPosition_09(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06001508 RID: 5384
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand2D_GetStartPosition_10(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Access to the start and end positions (display coordinates) of the rubber
		/// band pick area. This is a convenience method for the wrapped languages
		/// since the event callData is lost when using those wrappings.
		/// </summary>
		// Token: 0x06001509 RID: 5385 RVA: 0x00023C71 File Offset: 0x00021E71
		public virtual void GetStartPosition(IntPtr _arg)
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_GetStartPosition_10(base.GetCppThis(), _arg);
		}

		// Token: 0x0600150A RID: 5386
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleRubberBand2D_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600150B RID: 5387 RVA: 0x00023C84 File Offset: 0x00021E84
		public override int IsA(string type)
		{
			return vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0600150C RID: 5388
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleRubberBand2D_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600150D RID: 5389 RVA: 0x00023CA4 File Offset: 0x00021EA4
		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_IsTypeOf_12(type);
		}

		// Token: 0x0600150E RID: 5390
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleRubberBand2D_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600150F RID: 5391 RVA: 0x00023CC0 File Offset: 0x00021EC0
		public new vtkInteractorStyleRubberBand2D NewInstance()
		{
			vtkInteractorStyleRubberBand2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleRubberBand2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001510 RID: 5392
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand2D_OnLeftButtonDown_15(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001511 RID: 5393 RVA: 0x00023D1A File Offset: 0x00021F1A
		public override void OnLeftButtonDown()
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_OnLeftButtonDown_15(base.GetCppThis());
		}

		// Token: 0x06001512 RID: 5394
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand2D_OnLeftButtonUp_16(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001513 RID: 5395 RVA: 0x00023D29 File Offset: 0x00021F29
		public override void OnLeftButtonUp()
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_OnLeftButtonUp_16(base.GetCppThis());
		}

		// Token: 0x06001514 RID: 5396
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand2D_OnMiddleButtonDown_17(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001515 RID: 5397 RVA: 0x00023D38 File Offset: 0x00021F38
		public override void OnMiddleButtonDown()
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_OnMiddleButtonDown_17(base.GetCppThis());
		}

		// Token: 0x06001516 RID: 5398
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand2D_OnMiddleButtonUp_18(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001517 RID: 5399 RVA: 0x00023D47 File Offset: 0x00021F47
		public override void OnMiddleButtonUp()
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_OnMiddleButtonUp_18(base.GetCppThis());
		}

		// Token: 0x06001518 RID: 5400
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand2D_OnMouseMove_19(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001519 RID: 5401 RVA: 0x00023D56 File Offset: 0x00021F56
		public override void OnMouseMove()
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_OnMouseMove_19(base.GetCppThis());
		}

		// Token: 0x0600151A RID: 5402
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand2D_OnMouseWheelBackward_20(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600151B RID: 5403 RVA: 0x00023D65 File Offset: 0x00021F65
		public override void OnMouseWheelBackward()
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_OnMouseWheelBackward_20(base.GetCppThis());
		}

		// Token: 0x0600151C RID: 5404
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand2D_OnMouseWheelForward_21(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600151D RID: 5405 RVA: 0x00023D74 File Offset: 0x00021F74
		public override void OnMouseWheelForward()
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_OnMouseWheelForward_21(base.GetCppThis());
		}

		// Token: 0x0600151E RID: 5406
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand2D_OnRightButtonDown_22(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600151F RID: 5407 RVA: 0x00023D83 File Offset: 0x00021F83
		public override void OnRightButtonDown()
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_OnRightButtonDown_22(base.GetCppThis());
		}

		// Token: 0x06001520 RID: 5408
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand2D_OnRightButtonUp_23(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001521 RID: 5409 RVA: 0x00023D92 File Offset: 0x00021F92
		public override void OnRightButtonUp()
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_OnRightButtonUp_23(base.GetCppThis());
		}

		// Token: 0x06001522 RID: 5410
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand2D_RenderOnMouseMoveOff_24(HandleRef pThis);

		/// <summary>
		/// Whether to invoke a render when the mouse moves.
		/// </summary>
		// Token: 0x06001523 RID: 5411 RVA: 0x00023DA1 File Offset: 0x00021FA1
		public virtual void RenderOnMouseMoveOff()
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_RenderOnMouseMoveOff_24(base.GetCppThis());
		}

		// Token: 0x06001524 RID: 5412
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand2D_RenderOnMouseMoveOn_25(HandleRef pThis);

		/// <summary>
		/// Whether to invoke a render when the mouse moves.
		/// </summary>
		// Token: 0x06001525 RID: 5413 RVA: 0x00023DB0 File Offset: 0x00021FB0
		public virtual void RenderOnMouseMoveOn()
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_RenderOnMouseMoveOn_25(base.GetCppThis());
		}

		// Token: 0x06001526 RID: 5414
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleRubberBand2D_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001527 RID: 5415 RVA: 0x00023DC0 File Offset: 0x00021FC0
		public new static vtkInteractorStyleRubberBand2D SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleRubberBand2D vtkInteractorStyleRubberBand2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleRubberBand2D = (vtkInteractorStyleRubberBand2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleRubberBand2D.Register(null);
				}
			}
			return vtkInteractorStyleRubberBand2D;
		}

		// Token: 0x06001528 RID: 5416
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand2D_SetRenderOnMouseMove_27(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether to invoke a render when the mouse moves.
		/// </summary>
		// Token: 0x06001529 RID: 5417 RVA: 0x00023E3F File Offset: 0x0002203F
		public virtual void SetRenderOnMouseMove(bool _arg)
		{
			vtkInteractorStyleRubberBand2D.vtkInteractorStyleRubberBand2D_SetRenderOnMouseMove_27(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000470 RID: 1136
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleRubberBand2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000471 RID: 1137
		public new static readonly string MRClassNameKey = "class vtkInteractorStyleRubberBand2D";

		/// <summary>
		/// Selection types
		/// </summary>
		// Token: 0x02000072 RID: 114
		public enum SELECT_NORMAL_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000473 RID: 1139
			SELECT_NORMAL,
			/// <summary>enum member</summary>
			// Token: 0x04000474 RID: 1140
			SELECT_UNION
		}

		/// <summary>
		/// Current interaction state
		/// </summary>
		// Token: 0x02000073 RID: 115
		public enum NONE_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000476 RID: 1142
			NONE,
			/// <summary>enum member</summary>
			// Token: 0x04000477 RID: 1143
			PANNING,
			/// <summary>enum member</summary>
			// Token: 0x04000478 RID: 1144
			SELECTING = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000479 RID: 1145
			ZOOMING = 2
		}
	}
}
