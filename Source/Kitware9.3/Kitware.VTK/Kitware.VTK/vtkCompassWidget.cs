using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCompassWidget
	/// </summary>
	/// <remarks>
	///    widget to set distance, tilt and heading
	///
	/// The vtkCompassWidget is used to adjust distance, tilt and heading parameters in an
	/// application. It uses vtkCompassRepresentation as its representation.
	///
	/// To customize the widget override the CreateDefaultRepresentation method and set the
	/// representation to your own subclass of vtkCompassRepresentation. Ranges for distance and tilt can
	/// be set in vtkCompassRepresentation.
	///
	/// @par Event Bindings:
	/// By default, the widget responds to the following VTK events (i.e., it
	/// watches the vtkRenderWindowInteractor for these events):
	/// &lt;pre&gt;
	/// If the slider bead is selected:
	///   LeftButtonPressEvent - select slider
	///   LeftButtonReleaseEvent - release slider
	///   MouseMoveEvent - move slider
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// Note that the event bindings described above can be changed using this
	/// class's vtkWidgetEventTranslator. This class translates VTK events
	/// into the vtkCompassWidget's widget events:
	/// &lt;pre&gt;
	///   vtkWidgetEvent::Select -- some part of the widget has been selected
	///   vtkWidgetEvent::EndSelect -- the selection process has completed
	///   vtkWidgetEvent::Move -- a request for slider motion has been invoked
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// In turn, when these widget events are processed, the vtkCompassWidget
	/// invokes the following VTK events on itself (which observers can listen for):
	/// &lt;pre&gt;
	///   vtkCommand::StartInteractionEvent (on vtkWidgetEvent::Select)
	///   vtkCommand::EndInteractionEvent (on vtkWidgetEvent::EndSelect)
	///   vtkCommand::InteractionEvent (on vtkWidgetEvent::Move)
	///   vtkCommand::WidgetValueChangedEvent (when widget values have changed)
	/// &lt;/pre&gt;
	///
	/// </remarks>
	// Token: 0x020002FC RID: 764
	public class vtkCompassWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008891 RID: 34961 RVA: 0x000C322B File Offset: 0x000C142B
		static vtkCompassWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompassWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompassWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008892 RID: 34962 RVA: 0x000C3253 File Offset: 0x000C1453
		public vtkCompassWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008893 RID: 34963
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompassWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06008894 RID: 34964 RVA: 0x000C3264 File Offset: 0x000C1464
		public new static vtkCompassWidget New()
		{
			vtkCompassWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompassWidget.vtkCompassWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompassWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06008895 RID: 34965 RVA: 0x000C32B8 File Offset: 0x000C14B8
		public vtkCompassWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCompassWidget.vtkCompassWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008896 RID: 34966 RVA: 0x000C32FC File Offset: 0x000C14FC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008897 RID: 34967
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompassWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x06008898 RID: 34968 RVA: 0x000C3307 File Offset: 0x000C1507
		public override void CreateDefaultRepresentation()
		{
			vtkCompassWidget.vtkCompassWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06008899 RID: 34969
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCompassWidget_GetDistance_02(HandleRef pThis);

		/// <summary>
		/// Get/set the value for this widget.
		/// </summary>
		// Token: 0x0600889A RID: 34970 RVA: 0x000C3318 File Offset: 0x000C1518
		public double GetDistance()
		{
			return vtkCompassWidget.vtkCompassWidget_GetDistance_02(base.GetCppThis());
		}

		// Token: 0x0600889B RID: 34971
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCompassWidget_GetDistanceSpeed_03(HandleRef pThis);

		/// <summary>
		/// Get/set the distance speed in distance per second. This is the speed with which the distance
		/// changes when the top/bottom distance slider button is clicked. Default is 1.0/s.
		/// </summary>
		// Token: 0x0600889C RID: 34972 RVA: 0x000C3338 File Offset: 0x000C1538
		public virtual double GetDistanceSpeed()
		{
			return vtkCompassWidget.vtkCompassWidget_GetDistanceSpeed_03(base.GetCppThis());
		}

		// Token: 0x0600889D RID: 34973
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCompassWidget_GetHeading_04(HandleRef pThis);

		/// <summary>
		/// Get/set the value for this widget.
		/// </summary>
		// Token: 0x0600889E RID: 34974 RVA: 0x000C3358 File Offset: 0x000C1558
		public double GetHeading()
		{
			return vtkCompassWidget.vtkCompassWidget_GetHeading_04(base.GetCppThis());
		}

		// Token: 0x0600889F RID: 34975
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompassWidget_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x060088A0 RID: 34976 RVA: 0x000C3378 File Offset: 0x000C1578
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCompassWidget.vtkCompassWidget_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x060088A1 RID: 34977
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompassWidget_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x060088A2 RID: 34978 RVA: 0x000C3398 File Offset: 0x000C1598
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCompassWidget.vtkCompassWidget_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x060088A3 RID: 34979
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCompassWidget_GetTilt_07(HandleRef pThis);

		/// <summary>
		/// Get/set the value for this widget.
		/// </summary>
		// Token: 0x060088A4 RID: 34980 RVA: 0x000C33B4 File Offset: 0x000C15B4
		public double GetTilt()
		{
			return vtkCompassWidget.vtkCompassWidget_GetTilt_07(base.GetCppThis());
		}

		// Token: 0x060088A5 RID: 34981
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCompassWidget_GetTiltSpeed_08(HandleRef pThis);

		/// <summary>
		/// Get/set the tilt speed in degrees per second. This is the speed with which the tilt
		/// changes when the top/bottom tilt slider button is clicked. Default is 30.0 degrees/s.
		/// </summary>
		// Token: 0x060088A6 RID: 34982 RVA: 0x000C33D4 File Offset: 0x000C15D4
		public virtual double GetTiltSpeed()
		{
			return vtkCompassWidget.vtkCompassWidget_GetTiltSpeed_08(base.GetCppThis());
		}

		// Token: 0x060088A7 RID: 34983
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompassWidget_GetTimerDuration_09(HandleRef pThis);

		/// <summary>
		/// Get/set the timer interval in milliseconds. The timer interval determines the update frequency
		/// for slider mouse interactions. Default is 50 ms.
		/// </summary>
		// Token: 0x060088A8 RID: 34984 RVA: 0x000C33F4 File Offset: 0x000C15F4
		public virtual int GetTimerDuration()
		{
			return vtkCompassWidget.vtkCompassWidget_GetTimerDuration_09(base.GetCppThis());
		}

		// Token: 0x060088A9 RID: 34985
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompassWidget_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x060088AA RID: 34986 RVA: 0x000C3414 File Offset: 0x000C1614
		public override int IsA(string type)
		{
			return vtkCompassWidget.vtkCompassWidget_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x060088AB RID: 34987
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompassWidget_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x060088AC RID: 34988 RVA: 0x000C3434 File Offset: 0x000C1634
		public new static int IsTypeOf(string type)
		{
			return vtkCompassWidget.vtkCompassWidget_IsTypeOf_11(type);
		}

		// Token: 0x060088AD RID: 34989
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompassWidget_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x060088AE RID: 34990 RVA: 0x000C3450 File Offset: 0x000C1650
		public new vtkCompassWidget NewInstance()
		{
			vtkCompassWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompassWidget.vtkCompassWidget_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompassWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060088AF RID: 34991
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompassWidget_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x060088B0 RID: 34992 RVA: 0x000C34AC File Offset: 0x000C16AC
		public new static vtkCompassWidget SafeDownCast(vtkObjectBase o)
		{
			vtkCompassWidget vtkCompassWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompassWidget.vtkCompassWidget_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompassWidget = (vtkCompassWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompassWidget.Register(null);
				}
			}
			return vtkCompassWidget;
		}

		// Token: 0x060088B1 RID: 34993
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompassWidget_SetDistance_15(HandleRef pThis, double distance);

		/// <summary>
		/// Get/set the value for this widget.
		/// </summary>
		// Token: 0x060088B2 RID: 34994 RVA: 0x000C352B File Offset: 0x000C172B
		public void SetDistance(double distance)
		{
			vtkCompassWidget.vtkCompassWidget_SetDistance_15(base.GetCppThis(), distance);
		}

		// Token: 0x060088B3 RID: 34995
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompassWidget_SetDistanceSpeed_16(HandleRef pThis, double _arg);

		/// <summary>
		/// Get/set the distance speed in distance per second. This is the speed with which the distance
		/// changes when the top/bottom distance slider button is clicked. Default is 1.0/s.
		/// </summary>
		// Token: 0x060088B4 RID: 34996 RVA: 0x000C353B File Offset: 0x000C173B
		public virtual void SetDistanceSpeed(double _arg)
		{
			vtkCompassWidget.vtkCompassWidget_SetDistanceSpeed_16(base.GetCppThis(), _arg);
		}

		// Token: 0x060088B5 RID: 34997
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompassWidget_SetHeading_17(HandleRef pThis, double v);

		/// <summary>
		/// Get/set the value for this widget.
		/// </summary>
		// Token: 0x060088B6 RID: 34998 RVA: 0x000C354B File Offset: 0x000C174B
		public void SetHeading(double v)
		{
			vtkCompassWidget.vtkCompassWidget_SetHeading_17(base.GetCppThis(), v);
		}

		// Token: 0x060088B7 RID: 34999
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompassWidget_SetRepresentation_18(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x060088B8 RID: 35000 RVA: 0x000C355C File Offset: 0x000C175C
		public void SetRepresentation(vtkCompassRepresentation r)
		{
			vtkCompassWidget.vtkCompassWidget_SetRepresentation_18(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		// Token: 0x060088B9 RID: 35001
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompassWidget_SetTilt_19(HandleRef pThis, double tilt);

		/// <summary>
		/// Get/set the value for this widget.
		/// </summary>
		// Token: 0x060088BA RID: 35002 RVA: 0x000C358B File Offset: 0x000C178B
		public void SetTilt(double tilt)
		{
			vtkCompassWidget.vtkCompassWidget_SetTilt_19(base.GetCppThis(), tilt);
		}

		// Token: 0x060088BB RID: 35003
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompassWidget_SetTiltSpeed_20(HandleRef pThis, double _arg);

		/// <summary>
		/// Get/set the tilt speed in degrees per second. This is the speed with which the tilt
		/// changes when the top/bottom tilt slider button is clicked. Default is 30.0 degrees/s.
		/// </summary>
		// Token: 0x060088BC RID: 35004 RVA: 0x000C359B File Offset: 0x000C179B
		public virtual void SetTiltSpeed(double _arg)
		{
			vtkCompassWidget.vtkCompassWidget_SetTiltSpeed_20(base.GetCppThis(), _arg);
		}

		// Token: 0x060088BD RID: 35005
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompassWidget_SetTimerDuration_21(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/set the timer interval in milliseconds. The timer interval determines the update frequency
		/// for slider mouse interactions. Default is 50 ms.
		/// </summary>
		// Token: 0x060088BE RID: 35006 RVA: 0x000C35AB File Offset: 0x000C17AB
		public virtual void SetTimerDuration(int _arg)
		{
			vtkCompassWidget.vtkCompassWidget_SetTimerDuration_21(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B8C RID: 2956
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompassWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B8D RID: 2957
		public new static readonly string MRClassNameKey = "class vtkCompassWidget";
	}
}
