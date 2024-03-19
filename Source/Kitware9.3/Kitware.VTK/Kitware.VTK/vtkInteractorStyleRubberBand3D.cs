using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInteractorStyleRubberBand3D
	/// </summary>
	/// <remarks>
	///    A rubber band interactor for a 3D view
	///
	///
	/// vtkInteractorStyleRubberBand3D manages interaction in a 3D view.
	/// The style also allows draws a rubber band using the left button.
	/// All camera changes invoke StartInteractionEvent when the button
	/// is pressed, InteractionEvent when the mouse (or wheel) is moved,
	/// and EndInteractionEvent when the button is released.  The bindings
	/// are as follows:
	/// Left mouse - Select (invokes a SelectionChangedEvent).
	/// Right mouse - Rotate.
	/// Shift + right mouse - Zoom.
	/// Middle mouse - Pan.
	/// Scroll wheel - Zoom.
	/// </remarks>
	// Token: 0x020003FD RID: 1021
	public class vtkInteractorStyleRubberBand3D : vtkInteractorStyleTrackballCamera
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C2D3 RID: 49875 RVA: 0x0010F293 File Offset: 0x0010D493
		static vtkInteractorStyleRubberBand3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleRubberBand3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleRubberBand3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C2D4 RID: 49876 RVA: 0x0010F2BB File Offset: 0x0010D4BB
		public vtkInteractorStyleRubberBand3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C2D5 RID: 49877
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleRubberBand3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C2D6 RID: 49878 RVA: 0x0010F2CC File Offset: 0x0010D4CC
		public new static vtkInteractorStyleRubberBand3D New()
		{
			vtkInteractorStyleRubberBand3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleRubberBand3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C2D7 RID: 49879 RVA: 0x0010F320 File Offset: 0x0010D520
		public vtkInteractorStyleRubberBand3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C2D8 RID: 49880 RVA: 0x0010F364 File Offset: 0x0010D564
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C2D9 RID: 49881
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleRubberBand3D_GetEndPosition_01(HandleRef pThis);

		/// <summary>
		/// Access to the start and end positions (display coordinates) of the rubber
		/// band pick area. This is a convenience method for the wrapped languages
		/// since the event callData is lost when using those wrappings.
		/// </summary>
		// Token: 0x0600C2DA RID: 49882 RVA: 0x0010F370 File Offset: 0x0010D570
		public virtual int[] GetEndPosition()
		{
			IntPtr intPtr = vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_GetEndPosition_01(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600C2DB RID: 49883
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand3D_GetEndPosition_02(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Access to the start and end positions (display coordinates) of the rubber
		/// band pick area. This is a convenience method for the wrapped languages
		/// since the event callData is lost when using those wrappings.
		/// </summary>
		// Token: 0x0600C2DC RID: 49884 RVA: 0x0010F3B8 File Offset: 0x0010D5B8
		public virtual void GetEndPosition(ref int _arg1, ref int _arg2)
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_GetEndPosition_02(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600C2DD RID: 49885
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand3D_GetEndPosition_03(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Access to the start and end positions (display coordinates) of the rubber
		/// band pick area. This is a convenience method for the wrapped languages
		/// since the event callData is lost when using those wrappings.
		/// </summary>
		// Token: 0x0600C2DE RID: 49886 RVA: 0x0010F3C9 File Offset: 0x0010D5C9
		public virtual void GetEndPosition(IntPtr _arg)
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_GetEndPosition_03(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C2DF RID: 49887
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleRubberBand3D_GetInteraction_04(HandleRef pThis);

		/// <summary>
		/// Current interaction state
		/// </summary>
		// Token: 0x0600C2E0 RID: 49888 RVA: 0x0010F3DC File Offset: 0x0010D5DC
		public virtual int GetInteraction()
		{
			return vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_GetInteraction_04(base.GetCppThis());
		}

		// Token: 0x0600C2E1 RID: 49889
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleRubberBand3D_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C2E2 RID: 49890 RVA: 0x0010F3FC File Offset: 0x0010D5FC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600C2E3 RID: 49891
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleRubberBand3D_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C2E4 RID: 49892 RVA: 0x0010F41C File Offset: 0x0010D61C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600C2E5 RID: 49893
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkInteractorStyleRubberBand3D_GetRenderOnMouseMove_07(HandleRef pThis);

		/// <summary>
		/// Whether to invoke a render when the mouse moves.
		/// </summary>
		// Token: 0x0600C2E6 RID: 49894 RVA: 0x0010F438 File Offset: 0x0010D638
		public virtual bool GetRenderOnMouseMove()
		{
			return vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_GetRenderOnMouseMove_07(base.GetCppThis()) != 0;
		}

		// Token: 0x0600C2E7 RID: 49895
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleRubberBand3D_GetStartPosition_08(HandleRef pThis);

		/// <summary>
		/// Access to the start and end positions (display coordinates) of the rubber
		/// band pick area. This is a convenience method for the wrapped languages
		/// since the event callData is lost when using those wrappings.
		/// </summary>
		// Token: 0x0600C2E8 RID: 49896 RVA: 0x0010F460 File Offset: 0x0010D660
		public virtual int[] GetStartPosition()
		{
			IntPtr intPtr = vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_GetStartPosition_08(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600C2E9 RID: 49897
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand3D_GetStartPosition_09(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Access to the start and end positions (display coordinates) of the rubber
		/// band pick area. This is a convenience method for the wrapped languages
		/// since the event callData is lost when using those wrappings.
		/// </summary>
		// Token: 0x0600C2EA RID: 49898 RVA: 0x0010F4A8 File Offset: 0x0010D6A8
		public virtual void GetStartPosition(ref int _arg1, ref int _arg2)
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_GetStartPosition_09(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600C2EB RID: 49899
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand3D_GetStartPosition_10(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Access to the start and end positions (display coordinates) of the rubber
		/// band pick area. This is a convenience method for the wrapped languages
		/// since the event callData is lost when using those wrappings.
		/// </summary>
		// Token: 0x0600C2EC RID: 49900 RVA: 0x0010F4B9 File Offset: 0x0010D6B9
		public virtual void GetStartPosition(IntPtr _arg)
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_GetStartPosition_10(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C2ED RID: 49901
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleRubberBand3D_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C2EE RID: 49902 RVA: 0x0010F4CC File Offset: 0x0010D6CC
		public override int IsA(string type)
		{
			return vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0600C2EF RID: 49903
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleRubberBand3D_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C2F0 RID: 49904 RVA: 0x0010F4EC File Offset: 0x0010D6EC
		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_IsTypeOf_12(type);
		}

		// Token: 0x0600C2F1 RID: 49905
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleRubberBand3D_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C2F2 RID: 49906 RVA: 0x0010F508 File Offset: 0x0010D708
		public new vtkInteractorStyleRubberBand3D NewInstance()
		{
			vtkInteractorStyleRubberBand3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleRubberBand3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C2F3 RID: 49907
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand3D_OnLeftButtonDown_15(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C2F4 RID: 49908 RVA: 0x0010F562 File Offset: 0x0010D762
		public override void OnLeftButtonDown()
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_OnLeftButtonDown_15(base.GetCppThis());
		}

		// Token: 0x0600C2F5 RID: 49909
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand3D_OnLeftButtonUp_16(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C2F6 RID: 49910 RVA: 0x0010F571 File Offset: 0x0010D771
		public override void OnLeftButtonUp()
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_OnLeftButtonUp_16(base.GetCppThis());
		}

		// Token: 0x0600C2F7 RID: 49911
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand3D_OnMiddleButtonDown_17(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C2F8 RID: 49912 RVA: 0x0010F580 File Offset: 0x0010D780
		public override void OnMiddleButtonDown()
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_OnMiddleButtonDown_17(base.GetCppThis());
		}

		// Token: 0x0600C2F9 RID: 49913
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand3D_OnMiddleButtonUp_18(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C2FA RID: 49914 RVA: 0x0010F58F File Offset: 0x0010D78F
		public override void OnMiddleButtonUp()
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_OnMiddleButtonUp_18(base.GetCppThis());
		}

		// Token: 0x0600C2FB RID: 49915
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand3D_OnMouseMove_19(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C2FC RID: 49916 RVA: 0x0010F59E File Offset: 0x0010D79E
		public override void OnMouseMove()
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_OnMouseMove_19(base.GetCppThis());
		}

		// Token: 0x0600C2FD RID: 49917
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand3D_OnMouseWheelBackward_20(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C2FE RID: 49918 RVA: 0x0010F5AD File Offset: 0x0010D7AD
		public override void OnMouseWheelBackward()
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_OnMouseWheelBackward_20(base.GetCppThis());
		}

		// Token: 0x0600C2FF RID: 49919
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand3D_OnMouseWheelForward_21(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C300 RID: 49920 RVA: 0x0010F5BC File Offset: 0x0010D7BC
		public override void OnMouseWheelForward()
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_OnMouseWheelForward_21(base.GetCppThis());
		}

		// Token: 0x0600C301 RID: 49921
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand3D_OnRightButtonDown_22(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C302 RID: 49922 RVA: 0x0010F5CB File Offset: 0x0010D7CB
		public override void OnRightButtonDown()
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_OnRightButtonDown_22(base.GetCppThis());
		}

		// Token: 0x0600C303 RID: 49923
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand3D_OnRightButtonUp_23(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C304 RID: 49924 RVA: 0x0010F5DA File Offset: 0x0010D7DA
		public override void OnRightButtonUp()
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_OnRightButtonUp_23(base.GetCppThis());
		}

		// Token: 0x0600C305 RID: 49925
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand3D_RenderOnMouseMoveOff_24(HandleRef pThis);

		/// <summary>
		/// Whether to invoke a render when the mouse moves.
		/// </summary>
		// Token: 0x0600C306 RID: 49926 RVA: 0x0010F5E9 File Offset: 0x0010D7E9
		public virtual void RenderOnMouseMoveOff()
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_RenderOnMouseMoveOff_24(base.GetCppThis());
		}

		// Token: 0x0600C307 RID: 49927
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand3D_RenderOnMouseMoveOn_25(HandleRef pThis);

		/// <summary>
		/// Whether to invoke a render when the mouse moves.
		/// </summary>
		// Token: 0x0600C308 RID: 49928 RVA: 0x0010F5F8 File Offset: 0x0010D7F8
		public virtual void RenderOnMouseMoveOn()
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_RenderOnMouseMoveOn_25(base.GetCppThis());
		}

		// Token: 0x0600C309 RID: 49929
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleRubberBand3D_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C30A RID: 49930 RVA: 0x0010F608 File Offset: 0x0010D808
		public new static vtkInteractorStyleRubberBand3D SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleRubberBand3D vtkInteractorStyleRubberBand3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleRubberBand3D = (vtkInteractorStyleRubberBand3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleRubberBand3D.Register(null);
				}
			}
			return vtkInteractorStyleRubberBand3D;
		}

		// Token: 0x0600C30B RID: 49931
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleRubberBand3D_SetRenderOnMouseMove_27(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether to invoke a render when the mouse moves.
		/// </summary>
		// Token: 0x0600C30C RID: 49932 RVA: 0x0010F687 File Offset: 0x0010D887
		public virtual void SetRenderOnMouseMove(bool _arg)
		{
			vtkInteractorStyleRubberBand3D.vtkInteractorStyleRubberBand3D_SetRenderOnMouseMove_27(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E67 RID: 3687
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleRubberBand3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E68 RID: 3688
		public new static readonly string MRClassNameKey = "class vtkInteractorStyleRubberBand3D";

		/// <summary>
		/// Selection types
		/// </summary>
		// Token: 0x020003FE RID: 1022
		public enum SELECT_NORMAL_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000E6A RID: 3690
			SELECT_NORMAL,
			/// <summary>enum member</summary>
			// Token: 0x04000E6B RID: 3691
			SELECT_UNION
		}

		/// <summary>
		/// Current interaction state
		/// </summary>
		// Token: 0x020003FF RID: 1023
		public enum NONE_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000E6D RID: 3693
			NONE,
			/// <summary>enum member</summary>
			// Token: 0x04000E6E RID: 3694
			PANNING,
			/// <summary>enum member</summary>
			// Token: 0x04000E6F RID: 3695
			ROTATING = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000E70 RID: 3696
			SELECTING,
			/// <summary>enum member</summary>
			// Token: 0x04000E71 RID: 3697
			ZOOMING = 2
		}
	}
}
