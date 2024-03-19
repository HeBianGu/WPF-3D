using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCameraOrientationWidget
	/// </summary>
	/// <remarks>
	///    A widget to manipulate vtkCameraOrientationWidget.
	///
	///
	/// This 3D widget creates and manages its own vtkCameraOrientationRepresentation.
	/// To use this widget, make sure you call SetParentRenderer() and enable the widget.
	/// The jump-to-axis-viewpoint feature is animated over 20 frames. See SetAnimatorTotalFrames()
	/// Turn off animation with AnimateOff()
	///
	/// @par Event Bindings:
	/// By default, the widget responds to the following VTK events (i.e., it
	/// watches the vtkRenderWindowInteractor for these events):
	/// &lt;pre&gt;
	/// LeftButtonPressEvent - select the appropriate handle
	/// LeftButtonReleaseEvent - release the currently selected handle
	/// If one of the six handles are selected:
	///   MouseMoveEvent - rotate (if left button) , else set hover representation for nearest handle.
	/// &lt;/pre&gt;
	/// These input events are not forwarded to any other observers. This widget
	/// eats up mouse events. (AbortFlagOn).
	///
	/// @par Event Bindings:
	/// Note that the event bindings described above can be changed using this
	/// class's vtkWidgetEventTranslator, which translates VTK events
	/// into the vtkCameraOrientationWidget's widget events:
	/// &lt;pre&gt;
	///   vtkWidgetEvent::Select -- some part of the widget has been selected
	///   vtkWidgetEvent::EndSelect -- the selection process has completed
	///   vtkWidgetEvent::Move -- a request for motion has been invoked
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// This class, and the affiliated vtkCameraOrientationRepresentation,
	/// are second generation VTK widgets.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCameraOrientationRepresentation
	/// </seealso>
	// Token: 0x020002E4 RID: 740
	public class vtkCameraOrientationWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008507 RID: 34055 RVA: 0x000BDE47 File Offset: 0x000BC047
		static vtkCameraOrientationWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCameraOrientationWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCameraOrientationWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008508 RID: 34056 RVA: 0x000BDE6F File Offset: 0x000BC06F
		public vtkCameraOrientationWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008509 RID: 34057
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraOrientationWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600850A RID: 34058 RVA: 0x000BDE80 File Offset: 0x000BC080
		public new static vtkCameraOrientationWidget New()
		{
			vtkCameraOrientationWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraOrientationWidget.vtkCameraOrientationWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCameraOrientationWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600850B RID: 34059 RVA: 0x000BDED4 File Offset: 0x000BC0D4
		public vtkCameraOrientationWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCameraOrientationWidget.vtkCameraOrientationWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600850C RID: 34060 RVA: 0x000BDF18 File Offset: 0x000BC118
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600850D RID: 34061
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationWidget_AnimateOff_01(HandleRef pThis);

		/// <summary>
		/// Enable jump-to-axis-view animation.
		/// See AnimatorTotalFrames.
		/// </summary>
		// Token: 0x0600850E RID: 34062 RVA: 0x000BDF23 File Offset: 0x000BC123
		public virtual void AnimateOff()
		{
			vtkCameraOrientationWidget.vtkCameraOrientationWidget_AnimateOff_01(base.GetCppThis());
		}

		// Token: 0x0600850F RID: 34063
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationWidget_AnimateOn_02(HandleRef pThis);

		/// <summary>
		/// Enable jump-to-axis-view animation.
		/// See AnimatorTotalFrames.
		/// </summary>
		// Token: 0x06008510 RID: 34064 RVA: 0x000BDF32 File Offset: 0x000BC132
		public virtual void AnimateOn()
		{
			vtkCameraOrientationWidget.vtkCameraOrientationWidget_AnimateOn_02(base.GetCppThis());
		}

		// Token: 0x06008511 RID: 34065
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationWidget_CreateDefaultRepresentation_03(HandleRef pThis);

		/// <summary>
		/// Create a vtkCameraOrientationRepresentation.
		/// </summary>
		// Token: 0x06008512 RID: 34066 RVA: 0x000BDF41 File Offset: 0x000BC141
		public override void CreateDefaultRepresentation()
		{
			vtkCameraOrientationWidget.vtkCameraOrientationWidget_CreateDefaultRepresentation_03(base.GetCppThis());
		}

		// Token: 0x06008513 RID: 34067
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCameraOrientationWidget_GetAnimate_04(HandleRef pThis);

		/// <summary>
		/// Enable jump-to-axis-view animation.
		/// See AnimatorTotalFrames.
		/// </summary>
		// Token: 0x06008514 RID: 34068 RVA: 0x000BDF50 File Offset: 0x000BC150
		public virtual bool GetAnimate()
		{
			return vtkCameraOrientationWidget.vtkCameraOrientationWidget_GetAnimate_04(base.GetCppThis()) != 0;
		}

		// Token: 0x06008515 RID: 34069
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraOrientationWidget_GetAnimatorTotalFrames_05(HandleRef pThis);

		/// <summary>
		/// Length of animation. (in frames)
		/// </summary>
		// Token: 0x06008516 RID: 34070 RVA: 0x000BDF78 File Offset: 0x000BC178
		public virtual int GetAnimatorTotalFrames()
		{
			return vtkCameraOrientationWidget.vtkCameraOrientationWidget_GetAnimatorTotalFrames_05(base.GetCppThis());
		}

		// Token: 0x06008517 RID: 34071
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraOrientationWidget_GetAnimatorTotalFramesMaxValue_06(HandleRef pThis);

		/// <summary>
		/// Length of animation. (in frames)
		/// </summary>
		// Token: 0x06008518 RID: 34072 RVA: 0x000BDF98 File Offset: 0x000BC198
		public virtual int GetAnimatorTotalFramesMaxValue()
		{
			return vtkCameraOrientationWidget.vtkCameraOrientationWidget_GetAnimatorTotalFramesMaxValue_06(base.GetCppThis());
		}

		// Token: 0x06008519 RID: 34073
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraOrientationWidget_GetAnimatorTotalFramesMinValue_07(HandleRef pThis);

		/// <summary>
		/// Length of animation. (in frames)
		/// </summary>
		// Token: 0x0600851A RID: 34074 RVA: 0x000BDFB8 File Offset: 0x000BC1B8
		public virtual int GetAnimatorTotalFramesMinValue()
		{
			return vtkCameraOrientationWidget.vtkCameraOrientationWidget_GetAnimatorTotalFramesMinValue_07(base.GetCppThis());
		}

		// Token: 0x0600851B RID: 34075
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCameraOrientationWidget_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600851C RID: 34076 RVA: 0x000BDFD8 File Offset: 0x000BC1D8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCameraOrientationWidget.vtkCameraOrientationWidget_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0600851D RID: 34077
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCameraOrientationWidget_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600851E RID: 34078 RVA: 0x000BDFF8 File Offset: 0x000BC1F8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCameraOrientationWidget.vtkCameraOrientationWidget_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0600851F RID: 34079
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraOrientationWidget_GetParentRenderer_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This widget shows and manipulates the orientation of
		/// the parent renderer's active camera.
		///
		/// Note: The renderer must be part of a render window for
		/// the widget to appear.
		/// </summary>
		// Token: 0x06008520 RID: 34080 RVA: 0x000BE014 File Offset: 0x000BC214
		public vtkRenderer GetParentRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraOrientationWidget.vtkCameraOrientationWidget_GetParentRenderer_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		// Token: 0x06008521 RID: 34081
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraOrientationWidget_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008522 RID: 34082 RVA: 0x000BE084 File Offset: 0x000BC284
		public override int IsA(string type)
		{
			return vtkCameraOrientationWidget.vtkCameraOrientationWidget_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x06008523 RID: 34083
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraOrientationWidget_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008524 RID: 34084 RVA: 0x000BE0A4 File Offset: 0x000BC2A4
		public new static int IsTypeOf(string type)
		{
			return vtkCameraOrientationWidget.vtkCameraOrientationWidget_IsTypeOf_12(type);
		}

		// Token: 0x06008525 RID: 34085
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraOrientationWidget_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008526 RID: 34086 RVA: 0x000BE0C0 File Offset: 0x000BC2C0
		public new vtkCameraOrientationWidget NewInstance()
		{
			vtkCameraOrientationWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraOrientationWidget.vtkCameraOrientationWidget_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCameraOrientationWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008527 RID: 34087
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraOrientationWidget_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008528 RID: 34088 RVA: 0x000BE11C File Offset: 0x000BC31C
		public new static vtkCameraOrientationWidget SafeDownCast(vtkObjectBase o)
		{
			vtkCameraOrientationWidget vtkCameraOrientationWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraOrientationWidget.vtkCameraOrientationWidget_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCameraOrientationWidget = (vtkCameraOrientationWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCameraOrientationWidget.Register(null);
				}
			}
			return vtkCameraOrientationWidget;
		}

		// Token: 0x06008529 RID: 34089
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationWidget_SetAnimate_16(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable jump-to-axis-view animation.
		/// See AnimatorTotalFrames.
		/// </summary>
		// Token: 0x0600852A RID: 34090 RVA: 0x000BE19B File Offset: 0x000BC39B
		public virtual void SetAnimate(bool _arg)
		{
			vtkCameraOrientationWidget.vtkCameraOrientationWidget_SetAnimate_16(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600852B RID: 34091
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationWidget_SetAnimatorTotalFrames_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Length of animation. (in frames)
		/// </summary>
		// Token: 0x0600852C RID: 34092 RVA: 0x000BE1B3 File Offset: 0x000BC3B3
		public virtual void SetAnimatorTotalFrames(int _arg)
		{
			vtkCameraOrientationWidget.vtkCameraOrientationWidget_SetAnimatorTotalFrames_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0600852D RID: 34093
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationWidget_SetParentRenderer_18(HandleRef pThis, HandleRef renderer);

		/// <summary>
		/// This widget shows and manipulates the orientation of
		/// the parent renderer's active camera.
		///
		/// Note: The renderer must be part of a render window for
		/// the widget to appear.
		/// </summary>
		// Token: 0x0600852E RID: 34094 RVA: 0x000BE1C4 File Offset: 0x000BC3C4
		public void SetParentRenderer(vtkRenderer renderer)
		{
			vtkCameraOrientationWidget.vtkCameraOrientationWidget_SetParentRenderer_18(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		// Token: 0x0600852F RID: 34095
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationWidget_SquareResize_19(HandleRef pThis);

		/// <summary>
		/// Fits the widget's renderer to a square viewport.
		/// </summary>
		// Token: 0x06008530 RID: 34096 RVA: 0x000BE1F3 File Offset: 0x000BC3F3
		public void SquareResize()
		{
			vtkCameraOrientationWidget.vtkCameraOrientationWidget_SquareResize_19(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B44 RID: 2884
		public new const string MRFullTypeName = "Kitware.VTK.vtkCameraOrientationWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B45 RID: 2885
		public new static readonly string MRClassNameKey = "class vtkCameraOrientationWidget";
	}
}
