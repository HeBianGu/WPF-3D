using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTensorWidget
	/// </summary>
	/// <remarks>
	///    3D widget for manipulating a tensor glyph
	///
	/// This 3D widget interacts with a vtkTensorRepresentation class (i.e., it
	/// handles the events that drive its corresponding representation). The
	/// widget is assumed to operate on a single 3x3 real, symmetric tensor
	/// located at a specified position. The tensor implicitly defines three
	/// orthogonal eigenvectors which indicate the orientation and relative
	/// scaling of the widget's representation.
	///
	/// The widget has the appearance of an oriented box with seven handles: one
	/// at the center of the box, and six located at the center of each face. The
	/// box can be translated by selecting its center handle; rotated by selecting
	/// and rotating one of the box faces around the box center; and scaled (in a
	/// particular direction) by selecting the face handles (located on each face)
	/// and moving the faces in/out in the direction of the face normal. Uniform
	/// scaling is also possible by (default) using the right mouse button (unless
	/// the binding has been redefined).
	///
	/// To use this widget, you generally pair it with a
	/// vtkTensorRepresentation (or a subclass). Various options are
	/// available in the representation for controlling the widgets' size and
	/// position; how the widget appears; and how the widget functions.
	///
	/// @par Event Bindings:
	/// By default, the widget responds to the following VTK events (i.e., it
	/// watches the vtkRenderWindowInteractor for these events):
	/// &lt;pre&gt;
	/// If one of the seven handles are selected:
	///   LeftButtonPressEvent - select the appropriate handle
	///   LeftButtonReleaseEvent - release the currently selected handle
	///   MouseMoveEvent - move the handle
	/// If one of the faces is selected:
	///   LeftButtonPressEvent - select a box face
	///   LeftButtonReleaseEvent - release the box face
	///   MouseMoveEvent - rotate the box
	/// In all the cases, independent of what is picked, the widget responds to the
	/// following VTK events:
	///   MiddleButtonPressEvent - translate the widget
	///   MiddleButtonReleaseEvent - release the widget
	///   RightButtonPressEvent - scale the widget's representation
	///   RightButtonReleaseEvent - stop scaling the widget
	///   MouseMoveEvent - scale (if right button) or move (if middle button) the widget
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// Note that the event bindings described above can be changed using this
	/// class's vtkWidgetEventTranslator. This class translates VTK events
	/// into the vtkTensorWidget's widget events:
	/// &lt;pre&gt;
	///   vtkWidgetEvent::Select -- some part of the widget has been selected
	///   vtkWidgetEvent::EndSelect -- the selection process has completed
	///   vtkWidgetEvent::Scale -- some part of the widget has been selected
	///   vtkWidgetEvent::EndScale -- the selection process has completed
	///   vtkWidgetEvent::Translate -- some part of the widget has been selected
	///   vtkWidgetEvent::EndTranslate -- the selection process has completed
	///   vtkWidgetEvent::Move -- a request for motion has been invoked
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// In turn, when these widget events are processed, the vtkTensorWidget
	/// invokes the following VTK events on itself (which observers can listen for):
	/// &lt;pre&gt;
	///   vtkCommand::StartInteractionEvent (on vtkWidgetEvent::Select)
	///   vtkCommand::EndInteractionEvent (on vtkWidgetEvent::EndSelect)
	///   vtkCommand::InteractionEvent (on vtkWidgetEvent::Move)
	/// &lt;/pre&gt;
	///
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTensorRepresentation vtkBoxWidget2
	/// </seealso>
	// Token: 0x02000383 RID: 899
	public class vtkTensorWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A3E3 RID: 41955 RVA: 0x000E845B File Offset: 0x000E665B
		static vtkTensorWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTensorWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTensorWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A3E4 RID: 41956 RVA: 0x000E8483 File Offset: 0x000E6683
		public vtkTensorWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A3E5 RID: 41957
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTensorWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0600A3E6 RID: 41958 RVA: 0x000E8494 File Offset: 0x000E6694
		public new static vtkTensorWidget New()
		{
			vtkTensorWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTensorWidget.vtkTensorWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTensorWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0600A3E7 RID: 41959 RVA: 0x000E84E8 File Offset: 0x000E66E8
		public vtkTensorWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTensorWidget.vtkTensorWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A3E8 RID: 41960 RVA: 0x000E852C File Offset: 0x000E672C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A3E9 RID: 41961
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set. By default,
		/// this is an instance of the vtkTensorRepresentation class.
		/// </summary>
		// Token: 0x0600A3EA RID: 41962 RVA: 0x000E8537 File Offset: 0x000E6737
		public override void CreateDefaultRepresentation()
		{
			vtkTensorWidget.vtkTensorWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x0600A3EB RID: 41963
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorWidget_GetMoveFacesEnabled_02(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be
		/// enabled and disabled. Scaling refers to scaling of the whole widget at
		/// once, (default is through right mouse button) while face movement refers
		/// to scaling of the widget one face (axis) at a time (default through
		/// grabbing one of the representation spherical handles).
		/// </summary>
		// Token: 0x0600A3EC RID: 41964 RVA: 0x000E8548 File Offset: 0x000E6748
		public virtual int GetMoveFacesEnabled()
		{
			return vtkTensorWidget.vtkTensorWidget_GetMoveFacesEnabled_02(base.GetCppThis());
		}

		// Token: 0x0600A3ED RID: 41965
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTensorWidget_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0600A3EE RID: 41966 RVA: 0x000E8568 File Offset: 0x000E6768
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTensorWidget.vtkTensorWidget_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600A3EF RID: 41967
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTensorWidget_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0600A3F0 RID: 41968 RVA: 0x000E8588 File Offset: 0x000E6788
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTensorWidget.vtkTensorWidget_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600A3F1 RID: 41969
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorWidget_GetRotationEnabled_05(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be
		/// enabled and disabled. Scaling refers to scaling of the whole widget at
		/// once, (default is through right mouse button) while face movement refers
		/// to scaling of the widget one face (axis) at a time (default through
		/// grabbing one of the representation spherical handles).
		/// </summary>
		// Token: 0x0600A3F2 RID: 41970 RVA: 0x000E85A4 File Offset: 0x000E67A4
		public virtual int GetRotationEnabled()
		{
			return vtkTensorWidget.vtkTensorWidget_GetRotationEnabled_05(base.GetCppThis());
		}

		// Token: 0x0600A3F3 RID: 41971
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorWidget_GetScalingEnabled_06(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be
		/// enabled and disabled. Scaling refers to scaling of the whole widget at
		/// once, (default is through right mouse button) while face movement refers
		/// to scaling of the widget one face (axis) at a time (default through
		/// grabbing one of the representation spherical handles).
		/// </summary>
		// Token: 0x0600A3F4 RID: 41972 RVA: 0x000E85C4 File Offset: 0x000E67C4
		public virtual int GetScalingEnabled()
		{
			return vtkTensorWidget.vtkTensorWidget_GetScalingEnabled_06(base.GetCppThis());
		}

		// Token: 0x0600A3F5 RID: 41973
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorWidget_GetTranslationEnabled_07(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be
		/// enabled and disabled. Scaling refers to scaling of the whole widget at
		/// once, (default is through right mouse button) while face movement refers
		/// to scaling of the widget one face (axis) at a time (default through
		/// grabbing one of the representation spherical handles).
		/// </summary>
		// Token: 0x0600A3F6 RID: 41974 RVA: 0x000E85E4 File Offset: 0x000E67E4
		public virtual int GetTranslationEnabled()
		{
			return vtkTensorWidget.vtkTensorWidget_GetTranslationEnabled_07(base.GetCppThis());
		}

		// Token: 0x0600A3F7 RID: 41975
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorWidget_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0600A3F8 RID: 41976 RVA: 0x000E8604 File Offset: 0x000E6804
		public override int IsA(string type)
		{
			return vtkTensorWidget.vtkTensorWidget_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0600A3F9 RID: 41977
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTensorWidget_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0600A3FA RID: 41978 RVA: 0x000E8624 File Offset: 0x000E6824
		public new static int IsTypeOf(string type)
		{
			return vtkTensorWidget.vtkTensorWidget_IsTypeOf_09(type);
		}

		// Token: 0x0600A3FB RID: 41979
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorWidget_MoveFacesEnabledOff_10(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be
		/// enabled and disabled. Scaling refers to scaling of the whole widget at
		/// once, (default is through right mouse button) while face movement refers
		/// to scaling of the widget one face (axis) at a time (default through
		/// grabbing one of the representation spherical handles).
		/// </summary>
		// Token: 0x0600A3FC RID: 41980 RVA: 0x000E863E File Offset: 0x000E683E
		public virtual void MoveFacesEnabledOff()
		{
			vtkTensorWidget.vtkTensorWidget_MoveFacesEnabledOff_10(base.GetCppThis());
		}

		// Token: 0x0600A3FD RID: 41981
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorWidget_MoveFacesEnabledOn_11(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be
		/// enabled and disabled. Scaling refers to scaling of the whole widget at
		/// once, (default is through right mouse button) while face movement refers
		/// to scaling of the widget one face (axis) at a time (default through
		/// grabbing one of the representation spherical handles).
		/// </summary>
		// Token: 0x0600A3FE RID: 41982 RVA: 0x000E864D File Offset: 0x000E684D
		public virtual void MoveFacesEnabledOn()
		{
			vtkTensorWidget.vtkTensorWidget_MoveFacesEnabledOn_11(base.GetCppThis());
		}

		// Token: 0x0600A3FF RID: 41983
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTensorWidget_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0600A400 RID: 41984 RVA: 0x000E865C File Offset: 0x000E685C
		public new vtkTensorWidget NewInstance()
		{
			vtkTensorWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTensorWidget.vtkTensorWidget_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTensorWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A401 RID: 41985
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorWidget_RotationEnabledOff_14(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be
		/// enabled and disabled. Scaling refers to scaling of the whole widget at
		/// once, (default is through right mouse button) while face movement refers
		/// to scaling of the widget one face (axis) at a time (default through
		/// grabbing one of the representation spherical handles).
		/// </summary>
		// Token: 0x0600A402 RID: 41986 RVA: 0x000E86B6 File Offset: 0x000E68B6
		public virtual void RotationEnabledOff()
		{
			vtkTensorWidget.vtkTensorWidget_RotationEnabledOff_14(base.GetCppThis());
		}

		// Token: 0x0600A403 RID: 41987
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorWidget_RotationEnabledOn_15(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be
		/// enabled and disabled. Scaling refers to scaling of the whole widget at
		/// once, (default is through right mouse button) while face movement refers
		/// to scaling of the widget one face (axis) at a time (default through
		/// grabbing one of the representation spherical handles).
		/// </summary>
		// Token: 0x0600A404 RID: 41988 RVA: 0x000E86C5 File Offset: 0x000E68C5
		public virtual void RotationEnabledOn()
		{
			vtkTensorWidget.vtkTensorWidget_RotationEnabledOn_15(base.GetCppThis());
		}

		// Token: 0x0600A405 RID: 41989
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTensorWidget_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0600A406 RID: 41990 RVA: 0x000E86D4 File Offset: 0x000E68D4
		public new static vtkTensorWidget SafeDownCast(vtkObjectBase o)
		{
			vtkTensorWidget vtkTensorWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTensorWidget.vtkTensorWidget_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTensorWidget = (vtkTensorWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTensorWidget.Register(null);
				}
			}
			return vtkTensorWidget;
		}

		// Token: 0x0600A407 RID: 41991
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorWidget_ScalingEnabledOff_17(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be
		/// enabled and disabled. Scaling refers to scaling of the whole widget at
		/// once, (default is through right mouse button) while face movement refers
		/// to scaling of the widget one face (axis) at a time (default through
		/// grabbing one of the representation spherical handles).
		/// </summary>
		// Token: 0x0600A408 RID: 41992 RVA: 0x000E8753 File Offset: 0x000E6953
		public virtual void ScalingEnabledOff()
		{
			vtkTensorWidget.vtkTensorWidget_ScalingEnabledOff_17(base.GetCppThis());
		}

		// Token: 0x0600A409 RID: 41993
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorWidget_ScalingEnabledOn_18(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be
		/// enabled and disabled. Scaling refers to scaling of the whole widget at
		/// once, (default is through right mouse button) while face movement refers
		/// to scaling of the widget one face (axis) at a time (default through
		/// grabbing one of the representation spherical handles).
		/// </summary>
		// Token: 0x0600A40A RID: 41994 RVA: 0x000E8762 File Offset: 0x000E6962
		public virtual void ScalingEnabledOn()
		{
			vtkTensorWidget.vtkTensorWidget_ScalingEnabledOn_18(base.GetCppThis());
		}

		// Token: 0x0600A40B RID: 41995
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorWidget_SetEnabled_19(HandleRef pThis, int enabling);

		/// <summary>
		/// Override superclasses' SetEnabled() method because the line
		/// widget must enable its internal handle widgets.
		/// </summary>
		// Token: 0x0600A40C RID: 41996 RVA: 0x000E8771 File Offset: 0x000E6971
		public override void SetEnabled(int enabling)
		{
			vtkTensorWidget.vtkTensorWidget_SetEnabled_19(base.GetCppThis(), enabling);
		}

		// Token: 0x0600A40D RID: 41997
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorWidget_SetMoveFacesEnabled_20(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be
		/// enabled and disabled. Scaling refers to scaling of the whole widget at
		/// once, (default is through right mouse button) while face movement refers
		/// to scaling of the widget one face (axis) at a time (default through
		/// grabbing one of the representation spherical handles).
		/// </summary>
		// Token: 0x0600A40E RID: 41998 RVA: 0x000E8781 File Offset: 0x000E6981
		public virtual void SetMoveFacesEnabled(int _arg)
		{
			vtkTensorWidget.vtkTensorWidget_SetMoveFacesEnabled_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A40F RID: 41999
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorWidget_SetRepresentation_21(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x0600A410 RID: 42000 RVA: 0x000E8794 File Offset: 0x000E6994
		public void SetRepresentation(vtkTensorRepresentation r)
		{
			vtkTensorWidget.vtkTensorWidget_SetRepresentation_21(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		// Token: 0x0600A411 RID: 42001
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorWidget_SetRotationEnabled_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be
		/// enabled and disabled. Scaling refers to scaling of the whole widget at
		/// once, (default is through right mouse button) while face movement refers
		/// to scaling of the widget one face (axis) at a time (default through
		/// grabbing one of the representation spherical handles).
		/// </summary>
		// Token: 0x0600A412 RID: 42002 RVA: 0x000E87C3 File Offset: 0x000E69C3
		public virtual void SetRotationEnabled(int _arg)
		{
			vtkTensorWidget.vtkTensorWidget_SetRotationEnabled_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A413 RID: 42003
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorWidget_SetScalingEnabled_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be
		/// enabled and disabled. Scaling refers to scaling of the whole widget at
		/// once, (default is through right mouse button) while face movement refers
		/// to scaling of the widget one face (axis) at a time (default through
		/// grabbing one of the representation spherical handles).
		/// </summary>
		// Token: 0x0600A414 RID: 42004 RVA: 0x000E87D3 File Offset: 0x000E69D3
		public virtual void SetScalingEnabled(int _arg)
		{
			vtkTensorWidget.vtkTensorWidget_SetScalingEnabled_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A415 RID: 42005
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorWidget_SetTranslationEnabled_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be
		/// enabled and disabled. Scaling refers to scaling of the whole widget at
		/// once, (default is through right mouse button) while face movement refers
		/// to scaling of the widget one face (axis) at a time (default through
		/// grabbing one of the representation spherical handles).
		/// </summary>
		// Token: 0x0600A416 RID: 42006 RVA: 0x000E87E3 File Offset: 0x000E69E3
		public virtual void SetTranslationEnabled(int _arg)
		{
			vtkTensorWidget.vtkTensorWidget_SetTranslationEnabled_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A417 RID: 42007
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorWidget_TranslationEnabledOff_25(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be
		/// enabled and disabled. Scaling refers to scaling of the whole widget at
		/// once, (default is through right mouse button) while face movement refers
		/// to scaling of the widget one face (axis) at a time (default through
		/// grabbing one of the representation spherical handles).
		/// </summary>
		// Token: 0x0600A418 RID: 42008 RVA: 0x000E87F3 File Offset: 0x000E69F3
		public virtual void TranslationEnabledOff()
		{
			vtkTensorWidget.vtkTensorWidget_TranslationEnabledOff_25(base.GetCppThis());
		}

		// Token: 0x0600A419 RID: 42009
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTensorWidget_TranslationEnabledOn_26(HandleRef pThis);

		/// <summary>
		/// Control the behavior of the widget (i.e., how it processes
		/// events). Translation, rotation, scaling and face movement can all be
		/// enabled and disabled. Scaling refers to scaling of the whole widget at
		/// once, (default is through right mouse button) while face movement refers
		/// to scaling of the widget one face (axis) at a time (default through
		/// grabbing one of the representation spherical handles).
		/// </summary>
		// Token: 0x0600A41A RID: 42010 RVA: 0x000E8802 File Offset: 0x000E6A02
		public virtual void TranslationEnabledOn()
		{
			vtkTensorWidget.vtkTensorWidget_TranslationEnabledOn_26(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D1D RID: 3357
		public new const string MRFullTypeName = "Kitware.VTK.vtkTensorWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D1E RID: 3358
		public new static readonly string MRClassNameKey = "class vtkTensorWidget";
	}
}
