using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBalloonWidget
	/// </summary>
	/// <remarks>
	///    popup text balloons above instance of vtkProp when hovering occurs
	///
	/// The vtkBalloonWidget is used to popup text and/or an image when the mouse
	/// hovers over an instance of vtkProp. The widget keeps track of
	/// (vtkProp,vtkBalloon) pairs (where the internal vtkBalloon class is defined
	/// by a pair of vtkStdString and vtkImageData), and when the mouse stops
	/// moving for a user-specified period of time over the vtkProp, then the
	/// vtkBalloon is drawn nearby the vtkProp. Note that an instance of
	/// vtkBalloonRepresentation is used to draw the balloon.
	///
	/// To use this widget, specify an instance of vtkBalloonWidget and a
	/// representation (e.g., vtkBalloonRepresentation). Then list all instances
	/// of vtkProp, a text string, and/or an instance of vtkImageData to be
	/// associated with each vtkProp. (Note that you can specify both text and an
	/// image, or just one or the other.) You may also wish to specify the hover
	/// delay (i.e., set in the superclass vtkHoverWidget).
	///
	/// @par Event Bindings:
	/// By default, the widget observes the following VTK events (i.e., it
	/// watches the vtkRenderWindowInteractor for these events):
	/// &lt;pre&gt;
	///   MouseMoveEvent - occurs when mouse is moved in render window.
	///   TimerEvent - occurs when the time between events (e.g., mouse move)
	///                is greater than TimerDuration.
	///   KeyPressEvent - when the "Enter" key is pressed after the balloon appears,
	///                   a callback is activated (e.g., WidgetActivateEvent).
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// Note that the event bindings described above can be changed using this
	/// class's vtkWidgetEventTranslator. This class translates VTK events
	/// into the vtkBalloonWidget's widget events:
	/// &lt;pre&gt;
	///   vtkWidgetEvent::Move -- start the timer
	///   vtkWidgetEvent::TimedOut -- when hovering occurs,
	///   vtkWidgetEvent::SelectAction -- activate any callbacks associated
	///                                   with the balloon.
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// This widget invokes the following VTK events on itself (which observers
	/// can listen for):
	/// &lt;pre&gt;
	///   vtkCommand::TimerEvent (when hovering is determined to occur)
	///   vtkCommand::EndInteractionEvent (after a hover has occurred and the
	///                                    mouse begins moving again).
	///   vtkCommand::WidgetActivateEvent (when the balloon is selected with a
	///                                    keypress).
	/// &lt;/pre&gt;
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAbstractWidget
	/// </seealso>
	// Token: 0x020002C4 RID: 708
	public class vtkBalloonWidget : vtkHoverWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007F9F RID: 32671 RVA: 0x000B70F7 File Offset: 0x000B52F7
		static vtkBalloonWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBalloonWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBalloonWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007FA0 RID: 32672 RVA: 0x000B711F File Offset: 0x000B531F
		public vtkBalloonWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007FA1 RID: 32673
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBalloonWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06007FA2 RID: 32674 RVA: 0x000B7130 File Offset: 0x000B5330
		public new static vtkBalloonWidget New()
		{
			vtkBalloonWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBalloonWidget.vtkBalloonWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBalloonWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06007FA3 RID: 32675 RVA: 0x000B7184 File Offset: 0x000B5384
		public vtkBalloonWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBalloonWidget.vtkBalloonWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007FA4 RID: 32676 RVA: 0x000B71C8 File Offset: 0x000B53C8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007FA5 RID: 32677
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonWidget_AddBalloon_01(HandleRef pThis, HandleRef prop, [MarshalAs(UnmanagedType.LPUTF8Str)] string str, HandleRef img);

		/// <summary>
		/// Add and remove text and/or an image to be associated with a vtkProp. You
		/// may add one or both of them.
		/// </summary>
		// Token: 0x06007FA6 RID: 32678 RVA: 0x000B71D4 File Offset: 0x000B53D4
		public void AddBalloon(vtkProp prop, string str, vtkImageData img)
		{
			vtkBalloonWidget.vtkBalloonWidget_AddBalloon_01(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis(), str, (img == null) ? default(HandleRef) : img.GetCppThis());
		}

		// Token: 0x06007FA7 RID: 32679
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonWidget_AddBalloon_02(HandleRef pThis, HandleRef prop, [MarshalAs(UnmanagedType.LPUTF8Str)] string str);

		/// <summary>
		/// Add and remove text and/or an image to be associated with a vtkProp. You
		/// may add one or both of them.
		/// </summary>
		// Token: 0x06007FA8 RID: 32680 RVA: 0x000B721C File Offset: 0x000B541C
		public void AddBalloon(vtkProp prop, string str)
		{
			vtkBalloonWidget.vtkBalloonWidget_AddBalloon_02(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis(), str);
		}

		// Token: 0x06007FA9 RID: 32681
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonWidget_CreateDefaultRepresentation_03(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x06007FAA RID: 32682 RVA: 0x000B724C File Offset: 0x000B544C
		public override void CreateDefaultRepresentation()
		{
			vtkBalloonWidget.vtkBalloonWidget_CreateDefaultRepresentation_03(base.GetCppThis());
		}

		// Token: 0x06007FAB RID: 32683
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBalloonWidget_GetBalloonImage_04(HandleRef pThis, HandleRef prop, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Methods to retrieve the information associated with each vtkProp (i.e.,
		/// the information that makes up each balloon). A nullptr will be returned if
		/// the vtkProp does not exist, or if a string or image have not been
		/// associated with the specified vtkProp.
		/// </summary>
		// Token: 0x06007FAC RID: 32684 RVA: 0x000B725C File Offset: 0x000B545C
		public vtkImageData GetBalloonImage(vtkProp prop)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBalloonWidget.vtkBalloonWidget_GetBalloonImage_04(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x06007FAD RID: 32685
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBalloonWidget_GetBalloonRepresentation_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the representation as a vtkBalloonRepresentation.
		/// </summary>
		// Token: 0x06007FAE RID: 32686 RVA: 0x000B72E4 File Offset: 0x000B54E4
		public vtkBalloonRepresentation GetBalloonRepresentation()
		{
			vtkBalloonRepresentation vtkBalloonRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBalloonWidget.vtkBalloonWidget_GetBalloonRepresentation_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBalloonRepresentation = (vtkBalloonRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBalloonRepresentation.Register(null);
				}
			}
			return vtkBalloonRepresentation;
		}

		// Token: 0x06007FAF RID: 32687
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBalloonWidget_GetBalloonString_06(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Methods to retrieve the information associated with each vtkProp (i.e.,
		/// the information that makes up each balloon). A nullptr will be returned if
		/// the vtkProp does not exist, or if a string or image have not been
		/// associated with the specified vtkProp.
		/// </summary>
		// Token: 0x06007FB0 RID: 32688 RVA: 0x000B7354 File Offset: 0x000B5554
		public string GetBalloonString(vtkProp prop)
		{
			string s = Marshal.PtrToStringAnsi(vtkBalloonWidget.vtkBalloonWidget_GetBalloonString_06(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007FB1 RID: 32689
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBalloonWidget_GetCurrentProp_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the current vtkProp that is being hovered over. Note that the
		/// value may be nullptr (if hovering over nothing or the mouse is moving).
		/// </summary>
		// Token: 0x06007FB2 RID: 32690 RVA: 0x000B73A4 File Offset: 0x000B55A4
		public virtual vtkProp GetCurrentProp()
		{
			vtkProp vtkProp = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBalloonWidget.vtkBalloonWidget_GetCurrentProp_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp = (vtkProp)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp.Register(null);
				}
			}
			return vtkProp;
		}

		// Token: 0x06007FB3 RID: 32691
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBalloonWidget_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x06007FB4 RID: 32692 RVA: 0x000B7414 File Offset: 0x000B5614
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBalloonWidget.vtkBalloonWidget_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x06007FB5 RID: 32693
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBalloonWidget_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x06007FB6 RID: 32694 RVA: 0x000B7434 File Offset: 0x000B5634
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBalloonWidget.vtkBalloonWidget_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x06007FB7 RID: 32695
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBalloonWidget_GetPicker_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the object used to perform pick operations. Since the
		/// vtkBalloonWidget operates on vtkProps, the picker must be a subclass of
		/// vtkAbstractPropPicker. (Note: if not specified, an instance of
		/// vtkPropPicker is used.)
		/// </summary>
		// Token: 0x06007FB8 RID: 32696 RVA: 0x000B7450 File Offset: 0x000B5650
		public virtual vtkAbstractPropPicker GetPicker()
		{
			vtkAbstractPropPicker vtkAbstractPropPicker = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBalloonWidget.vtkBalloonWidget_GetPicker_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractPropPicker = (vtkAbstractPropPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractPropPicker.Register(null);
				}
			}
			return vtkAbstractPropPicker;
		}

		// Token: 0x06007FB9 RID: 32697
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBalloonWidget_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x06007FBA RID: 32698 RVA: 0x000B74C0 File Offset: 0x000B56C0
		public override int IsA(string type)
		{
			return vtkBalloonWidget.vtkBalloonWidget_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x06007FBB RID: 32699
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBalloonWidget_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x06007FBC RID: 32700 RVA: 0x000B74E0 File Offset: 0x000B56E0
		public new static int IsTypeOf(string type)
		{
			return vtkBalloonWidget.vtkBalloonWidget_IsTypeOf_12(type);
		}

		// Token: 0x06007FBD RID: 32701
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBalloonWidget_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x06007FBE RID: 32702 RVA: 0x000B74FC File Offset: 0x000B56FC
		public new vtkBalloonWidget NewInstance()
		{
			vtkBalloonWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBalloonWidget.vtkBalloonWidget_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBalloonWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007FBF RID: 32703
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonWidget_RegisterPickers_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the object used to perform pick operations. Since the
		/// vtkBalloonWidget operates on vtkProps, the picker must be a subclass of
		/// vtkAbstractPropPicker. (Note: if not specified, an instance of
		/// vtkPropPicker is used.)
		/// </summary>
		// Token: 0x06007FC0 RID: 32704 RVA: 0x000B7556 File Offset: 0x000B5756
		public virtual void RegisterPickers()
		{
			vtkBalloonWidget.vtkBalloonWidget_RegisterPickers_15(base.GetCppThis());
		}

		// Token: 0x06007FC1 RID: 32705
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonWidget_RemoveBalloon_16(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Add and remove text and/or an image to be associated with a vtkProp. You
		/// may add one or both of them.
		/// </summary>
		// Token: 0x06007FC2 RID: 32706 RVA: 0x000B7568 File Offset: 0x000B5768
		public void RemoveBalloon(vtkProp prop)
		{
			vtkBalloonWidget.vtkBalloonWidget_RemoveBalloon_16(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x06007FC3 RID: 32707
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBalloonWidget_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x06007FC4 RID: 32708 RVA: 0x000B7598 File Offset: 0x000B5798
		public new static vtkBalloonWidget SafeDownCast(vtkObjectBase o)
		{
			vtkBalloonWidget vtkBalloonWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBalloonWidget.vtkBalloonWidget_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBalloonWidget = (vtkBalloonWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBalloonWidget.Register(null);
				}
			}
			return vtkBalloonWidget;
		}

		// Token: 0x06007FC5 RID: 32709
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonWidget_SetEnabled_18(HandleRef pThis, int arg0);

		/// <summary>
		/// The method for activating and deactivating this widget. This method
		/// must be overridden because it performs special timer-related operations.
		/// </summary>
		// Token: 0x06007FC6 RID: 32710 RVA: 0x000B7617 File Offset: 0x000B5817
		public override void SetEnabled(int arg0)
		{
			vtkBalloonWidget.vtkBalloonWidget_SetEnabled_18(base.GetCppThis(), arg0);
		}

		// Token: 0x06007FC7 RID: 32711
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonWidget_SetPicker_19(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the object used to perform pick operations. Since the
		/// vtkBalloonWidget operates on vtkProps, the picker must be a subclass of
		/// vtkAbstractPropPicker. (Note: if not specified, an instance of
		/// vtkPropPicker is used.)
		/// </summary>
		// Token: 0x06007FC8 RID: 32712 RVA: 0x000B7628 File Offset: 0x000B5828
		public void SetPicker(vtkAbstractPropPicker arg0)
		{
			vtkBalloonWidget.vtkBalloonWidget_SetPicker_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06007FC9 RID: 32713
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonWidget_SetRepresentation_20(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x06007FCA RID: 32714 RVA: 0x000B7658 File Offset: 0x000B5858
		public void SetRepresentation(vtkBalloonRepresentation r)
		{
			vtkBalloonWidget.vtkBalloonWidget_SetRepresentation_20(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		// Token: 0x06007FCB RID: 32715
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonWidget_UpdateBalloonImage_21(HandleRef pThis, HandleRef prop, HandleRef image);

		/// <summary>
		/// Update the balloon string or image. If the specified prop does not exist,
		/// then nothing is added not changed.
		/// </summary>
		// Token: 0x06007FCC RID: 32716 RVA: 0x000B7688 File Offset: 0x000B5888
		public void UpdateBalloonImage(vtkProp prop, vtkImageData image)
		{
			vtkBalloonWidget.vtkBalloonWidget_UpdateBalloonImage_21(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis());
		}

		// Token: 0x06007FCD RID: 32717
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBalloonWidget_UpdateBalloonString_22(HandleRef pThis, HandleRef prop, [MarshalAs(UnmanagedType.LPUTF8Str)] string str);

		/// <summary>
		/// Update the balloon string or image. If the specified prop does not exist,
		/// then nothing is added not changed.
		/// </summary>
		// Token: 0x06007FCE RID: 32718 RVA: 0x000B76CC File Offset: 0x000B58CC
		public void UpdateBalloonString(vtkProp prop, string str)
		{
			vtkBalloonWidget.vtkBalloonWidget_UpdateBalloonString_22(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis(), str);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000ACA RID: 2762
		public new const string MRFullTypeName = "Kitware.VTK.vtkBalloonWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000ACB RID: 2763
		public new static readonly string MRClassNameKey = "class vtkBalloonWidget";
	}
}
