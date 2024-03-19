﻿using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOrientationMarkerWidget
	/// </summary>
	/// <remarks>
	///    2D widget for manipulating a marker prop
	///
	/// This class provides support for interactively manipulating the position,
	/// size, and apparent orientation of a prop that represents an orientation
	/// marker.  This class works by adding its internal renderer to an external
	/// "parent" renderer on a different layer.  The input orientation marker is
	/// rendered as an overlay on the parent renderer and, thus, appears superposed
	/// over all props in the parent's scene.  The camera view of the orientation
	/// the marker is made to match that of the parent's by means of an observer
	/// mechanism, giving the illusion that the orientation of the marker reflects
	/// that of the prop(s) in the parent's scene.
	///
	/// The widget listens to left mouse button and mouse movement events. It will
	/// change the cursor shape based on its location. If the cursor is over the
	/// overlay renderer, it will change the cursor shape to a SIZEALL shape
	/// or to a resize corner shape (e.g., SIZENW) if the cursor is near a corner.
	/// If the left mouse button is pressed and held down while moving, the overlay
	/// renderer, and hence, the orientation marker, is resized or moved.  I the case
	/// of a resize operation, releasing the left mouse button causes the widget
	/// to enforce its renderer to be square.  The diagonally opposite corner to the
	/// one moved is repositioned such that all edges of the renderer have the same
	/// length: the minimum.
	///
	/// To use this object, there are two key steps: 1) invoke SetInteractor() with
	/// the argument of the method a vtkRenderWindowInteractor, and 2) invoke
	/// SetOrientationMarker with an instance of vtkProp (see caveats below).
	/// Specifically, vtkAxesActor and vtkAnnotatedCubeActor are two classes
	/// designed to work with this class.  A composite orientation marker can be
	/// generated by adding instances of vtkAxesActor and vtkAnnotatedCubeActor to a
	/// vtkPropAssembly, which can then be set as the input orientation marker.
	/// The widget can be also be set up in a non-interactive fashion by setting
	/// Ineractive to Off and sizing/placing the overlay renderer in its parent
	/// renderer by calling the widget's SetViewport method.
	///
	/// @par Thanks:
	/// This class was based originally on Paraview's vtkPVAxesWidget.
	///
	/// @warning
	/// The input orientation marker prop should calculate its bounds as though they
	/// are symmetric about it's origin.  This must currently be done to correctly
	/// implement the camera synchronization between the ivar renderer and the
	/// renderer associated with the set interactor.  Importantly, the InteractorStyle
	/// associated with the interactor must be of the type vtkInteractorStyle*Camera.
	/// Where desirable, the parent renderer should be set by the SetDefaultRenderer
	/// method.  The parent renderer's number of layers is modified to 2 where
	/// required.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkInteractorObserver vtkXYPlotWidget vtkScalarBarWidget vtkAxesActor
	/// vtkAnnotatedCubeActor
	/// </seealso>
	// Token: 0x02000341 RID: 833
	public class vtkOrientationMarkerWidget : vtkInteractorObserver
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009759 RID: 38745 RVA: 0x000D65B1 File Offset: 0x000D47B1
		static vtkOrientationMarkerWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOrientationMarkerWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOrientationMarkerWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600975A RID: 38746 RVA: 0x000D65D9 File Offset: 0x000D47D9
		public vtkOrientationMarkerWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600975B RID: 38747
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientationMarkerWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600975C RID: 38748 RVA: 0x000D65E8 File Offset: 0x000D47E8
		public new static vtkOrientationMarkerWidget New()
		{
			vtkOrientationMarkerWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOrientationMarkerWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600975D RID: 38749 RVA: 0x000D663C File Offset: 0x000D483C
		public vtkOrientationMarkerWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600975E RID: 38750 RVA: 0x000D6680 File Offset: 0x000D4880
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600975F RID: 38751
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationMarkerWidget_EndInteraction_01(HandleRef pThis);

		/// <summary>
		/// Ends any in progress interaction and resets border visibility
		/// </summary>
		// Token: 0x06009760 RID: 38752 RVA: 0x000D668B File Offset: 0x000D488B
		public virtual void EndInteraction()
		{
			vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_EndInteraction_01(base.GetCppThis());
		}

		// Token: 0x06009761 RID: 38753
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationMarkerWidget_ExecuteCameraUpdateEvent_02(HandleRef pThis, HandleRef o, uint arg1, IntPtr calldata);

		/// <summary>
		/// Callback to keep the camera for the orientation marker up to date with the
		/// camera in the parent renderer.
		/// </summary>
		// Token: 0x06009762 RID: 38754 RVA: 0x000D669C File Offset: 0x000D489C
		public void ExecuteCameraUpdateEvent(vtkObject o, uint arg1, IntPtr calldata)
		{
			vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_ExecuteCameraUpdateEvent_02(base.GetCppThis(), (o == null) ? default(HandleRef) : o.GetCppThis(), arg1, calldata);
		}

		// Token: 0x06009763 RID: 38755
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientationMarkerWidget_GetInteractive_03(HandleRef pThis);

		/// <summary>
		/// Set/get whether to allow this widget to be interactively moved/scaled.
		/// Default is On.
		/// </summary>
		// Token: 0x06009764 RID: 38756 RVA: 0x000D66D0 File Offset: 0x000D48D0
		public virtual int GetInteractive()
		{
			return vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_GetInteractive_03(base.GetCppThis());
		}

		// Token: 0x06009765 RID: 38757
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientationMarkerWidget_GetMaxDimensionSize_04(HandleRef pThis);

		/// <summary>
		/// Returns the maximum dimension (width and height) size limit in pixels for the widget.
		/// </summary>
		// Token: 0x06009766 RID: 38758 RVA: 0x000D66F0 File Offset: 0x000D48F0
		public virtual int GetMaxDimensionSize()
		{
			return vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_GetMaxDimensionSize_04(base.GetCppThis());
		}

		// Token: 0x06009767 RID: 38759
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientationMarkerWidget_GetMinDimensionSize_05(HandleRef pThis);

		/// <summary>
		/// Returns the minimum dimension (width and height) size limit in pixels for the widget.
		/// </summary>
		// Token: 0x06009768 RID: 38760 RVA: 0x000D6710 File Offset: 0x000D4910
		public virtual int GetMinDimensionSize()
		{
			return vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_GetMinDimensionSize_05(base.GetCppThis());
		}

		// Token: 0x06009769 RID: 38761
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrientationMarkerWidget_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600976A RID: 38762 RVA: 0x000D6730 File Offset: 0x000D4930
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0600976B RID: 38763
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrientationMarkerWidget_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600976C RID: 38764 RVA: 0x000D6750 File Offset: 0x000D4950
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0600976D RID: 38765
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientationMarkerWidget_GetOrientationMarker_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the orientation marker to be displayed in this widget.
		/// </summary>
		// Token: 0x0600976E RID: 38766 RVA: 0x000D676C File Offset: 0x000D496C
		public virtual vtkProp GetOrientationMarker()
		{
			vtkProp vtkProp = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_GetOrientationMarker_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600976F RID: 38767
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientationMarkerWidget_GetOutlineColor_09(HandleRef pThis);

		/// <summary>
		/// Set/get the color of the outline of this widget.  The outline is visible
		/// when (in interactive mode) the cursor is over this widget.
		/// Default is white (1,1,1).
		/// </summary>
		// Token: 0x06009770 RID: 38768 RVA: 0x000D67DC File Offset: 0x000D49DC
		public IntPtr GetOutlineColor()
		{
			return vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_GetOutlineColor_09(base.GetCppThis());
		}

		// Token: 0x06009771 RID: 38769
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientationMarkerWidget_GetShouldConstrainSize_10(HandleRef pThis);

		/// <summary>
		/// Set/get whether the widget should constrain the size to be within the min and max limits.
		/// Default is off (unconstrained).
		/// </summary>
		// Token: 0x06009772 RID: 38770 RVA: 0x000D67FC File Offset: 0x000D49FC
		public virtual int GetShouldConstrainSize()
		{
			return vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_GetShouldConstrainSize_10(base.GetCppThis());
		}

		// Token: 0x06009773 RID: 38771
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientationMarkerWidget_GetTolerance_11(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels)
		/// in which the cursor is considered to be on the widget, or on a
		/// widget feature (e.g., a corner point or edge).
		/// </summary>
		// Token: 0x06009774 RID: 38772 RVA: 0x000D681C File Offset: 0x000D4A1C
		public virtual int GetTolerance()
		{
			return vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_GetTolerance_11(base.GetCppThis());
		}

		// Token: 0x06009775 RID: 38773
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientationMarkerWidget_GetToleranceMaxValue_12(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels)
		/// in which the cursor is considered to be on the widget, or on a
		/// widget feature (e.g., a corner point or edge).
		/// </summary>
		// Token: 0x06009776 RID: 38774 RVA: 0x000D683C File Offset: 0x000D4A3C
		public virtual int GetToleranceMaxValue()
		{
			return vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_GetToleranceMaxValue_12(base.GetCppThis());
		}

		// Token: 0x06009777 RID: 38775
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientationMarkerWidget_GetToleranceMinValue_13(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels)
		/// in which the cursor is considered to be on the widget, or on a
		/// widget feature (e.g., a corner point or edge).
		/// </summary>
		// Token: 0x06009778 RID: 38776 RVA: 0x000D685C File Offset: 0x000D4A5C
		public virtual int GetToleranceMinValue()
		{
			return vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_GetToleranceMinValue_13(base.GetCppThis());
		}

		// Token: 0x06009779 RID: 38777
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientationMarkerWidget_GetViewport_14(HandleRef pThis);

		/// <summary>
		/// Set/get the viewport to position/size this widget.
		/// Coordinates are expressed as (xmin,ymin,xmax,ymax), where each
		/// coordinate is 0 &lt;= coordinate &lt;= 1.0.
		/// Default is bottom left corner (0,0,0.2,0.2).
		/// Note that this viewport is scaled with respect to the viewport of the
		/// current renderer i.e. if the viewport of the current renderer is
		/// (0.5, 0.5, 0.75, 0.75) and Viewport is set to (0, 0, 1, 1), the orientation
		/// marker will be confined to a viewport of (0.5, 0.5, 0.75, 0.75) in the
		/// render window.
		/// \sa SetCurrentRenderer()
		/// </summary>
		// Token: 0x0600977A RID: 38778 RVA: 0x000D687C File Offset: 0x000D4A7C
		public virtual double[] GetViewport()
		{
			IntPtr intPtr = vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_GetViewport_14(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600977B RID: 38779
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationMarkerWidget_GetViewport_15(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		/// <summary>
		/// Set/get the viewport to position/size this widget.
		/// Coordinates are expressed as (xmin,ymin,xmax,ymax), where each
		/// coordinate is 0 &lt;= coordinate &lt;= 1.0.
		/// Default is bottom left corner (0,0,0.2,0.2).
		/// Note that this viewport is scaled with respect to the viewport of the
		/// current renderer i.e. if the viewport of the current renderer is
		/// (0.5, 0.5, 0.75, 0.75) and Viewport is set to (0, 0, 1, 1), the orientation
		/// marker will be confined to a viewport of (0.5, 0.5, 0.75, 0.75) in the
		/// render window.
		/// \sa SetCurrentRenderer()
		/// </summary>
		// Token: 0x0600977C RID: 38780 RVA: 0x000D68C4 File Offset: 0x000D4AC4
		public virtual void GetViewport(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_GetViewport_15(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x0600977D RID: 38781
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationMarkerWidget_GetViewport_16(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the viewport to position/size this widget.
		/// Coordinates are expressed as (xmin,ymin,xmax,ymax), where each
		/// coordinate is 0 &lt;= coordinate &lt;= 1.0.
		/// Default is bottom left corner (0,0,0.2,0.2).
		/// Note that this viewport is scaled with respect to the viewport of the
		/// current renderer i.e. if the viewport of the current renderer is
		/// (0.5, 0.5, 0.75, 0.75) and Viewport is set to (0, 0, 1, 1), the orientation
		/// marker will be confined to a viewport of (0.5, 0.5, 0.75, 0.75) in the
		/// render window.
		/// \sa SetCurrentRenderer()
		/// </summary>
		// Token: 0x0600977E RID: 38782 RVA: 0x000D68D8 File Offset: 0x000D4AD8
		public virtual void GetViewport(IntPtr _arg)
		{
			vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_GetViewport_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0600977F RID: 38783
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOrientationMarkerWidget_GetZoom_17(HandleRef pThis);

		/// <summary>
		/// The zoom factor to modify the size of the marker within the widget.
		/// Default is 1.0.
		/// </summary>
		// Token: 0x06009780 RID: 38784 RVA: 0x000D68E8 File Offset: 0x000D4AE8
		public virtual double GetZoom()
		{
			return vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_GetZoom_17(base.GetCppThis());
		}

		// Token: 0x06009781 RID: 38785
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOrientationMarkerWidget_GetZoomMaxValue_18(HandleRef pThis);

		/// <summary>
		/// The zoom factor to modify the size of the marker within the widget.
		/// Default is 1.0.
		/// </summary>
		// Token: 0x06009782 RID: 38786 RVA: 0x000D6908 File Offset: 0x000D4B08
		public virtual double GetZoomMaxValue()
		{
			return vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_GetZoomMaxValue_18(base.GetCppThis());
		}

		// Token: 0x06009783 RID: 38787
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOrientationMarkerWidget_GetZoomMinValue_19(HandleRef pThis);

		/// <summary>
		/// The zoom factor to modify the size of the marker within the widget.
		/// Default is 1.0.
		/// </summary>
		// Token: 0x06009784 RID: 38788 RVA: 0x000D6928 File Offset: 0x000D4B28
		public virtual double GetZoomMinValue()
		{
			return vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_GetZoomMinValue_19(base.GetCppThis());
		}

		// Token: 0x06009785 RID: 38789
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationMarkerWidget_InteractiveOff_20(HandleRef pThis);

		/// <summary>
		/// Set/get whether to allow this widget to be interactively moved/scaled.
		/// Default is On.
		/// </summary>
		// Token: 0x06009786 RID: 38790 RVA: 0x000D6947 File Offset: 0x000D4B47
		public virtual void InteractiveOff()
		{
			vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_InteractiveOff_20(base.GetCppThis());
		}

		// Token: 0x06009787 RID: 38791
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationMarkerWidget_InteractiveOn_21(HandleRef pThis);

		/// <summary>
		/// Set/get whether to allow this widget to be interactively moved/scaled.
		/// Default is On.
		/// </summary>
		// Token: 0x06009788 RID: 38792 RVA: 0x000D6956 File Offset: 0x000D4B56
		public virtual void InteractiveOn()
		{
			vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_InteractiveOn_21(base.GetCppThis());
		}

		// Token: 0x06009789 RID: 38793
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientationMarkerWidget_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600978A RID: 38794 RVA: 0x000D6968 File Offset: 0x000D4B68
		public override int IsA(string type)
		{
			return vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x0600978B RID: 38795
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientationMarkerWidget_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600978C RID: 38796 RVA: 0x000D6988 File Offset: 0x000D4B88
		public new static int IsTypeOf(string type)
		{
			return vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_IsTypeOf_23(type);
		}

		// Token: 0x0600978D RID: 38797
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationMarkerWidget_Modified_24(HandleRef pThis);

		/// <summary>
		/// Need to reimplement this-&gt;Modified() because of the
		/// vtkSetVector4Macro/vtkGetVector4Macro use
		/// </summary>
		// Token: 0x0600978E RID: 38798 RVA: 0x000D69A2 File Offset: 0x000D4BA2
		public override void Modified()
		{
			vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_Modified_24(base.GetCppThis());
		}

		// Token: 0x0600978F RID: 38799
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientationMarkerWidget_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009790 RID: 38800 RVA: 0x000D69B4 File Offset: 0x000D4BB4
		public new vtkOrientationMarkerWidget NewInstance()
		{
			vtkOrientationMarkerWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOrientationMarkerWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009791 RID: 38801
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientationMarkerWidget_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009792 RID: 38802 RVA: 0x000D6A10 File Offset: 0x000D4C10
		public new static vtkOrientationMarkerWidget SafeDownCast(vtkObjectBase o)
		{
			vtkOrientationMarkerWidget vtkOrientationMarkerWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOrientationMarkerWidget = (vtkOrientationMarkerWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOrientationMarkerWidget.Register(null);
				}
			}
			return vtkOrientationMarkerWidget;
		}

		// Token: 0x06009793 RID: 38803
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationMarkerWidget_SetEnabled_28(HandleRef pThis, int arg0);

		/// <summary>
		/// Enable/disable the widget. Default is 0 (disabled).
		/// </summary>
		// Token: 0x06009794 RID: 38804 RVA: 0x000D6A8F File Offset: 0x000D4C8F
		public override void SetEnabled(int arg0)
		{
			vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_SetEnabled_28(base.GetCppThis(), arg0);
		}

		// Token: 0x06009795 RID: 38805
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationMarkerWidget_SetInteractive_29(HandleRef pThis, int interact);

		/// <summary>
		/// Set/get whether to allow this widget to be interactively moved/scaled.
		/// Default is On.
		/// </summary>
		// Token: 0x06009796 RID: 38806 RVA: 0x000D6A9F File Offset: 0x000D4C9F
		public void SetInteractive(int interact)
		{
			vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_SetInteractive_29(base.GetCppThis(), interact);
		}

		// Token: 0x06009797 RID: 38807
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationMarkerWidget_SetOrientationMarker_30(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Set/get the orientation marker to be displayed in this widget.
		/// </summary>
		// Token: 0x06009798 RID: 38808 RVA: 0x000D6AB0 File Offset: 0x000D4CB0
		public virtual void SetOrientationMarker(vtkProp prop)
		{
			vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_SetOrientationMarker_30(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x06009799 RID: 38809
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationMarkerWidget_SetOutlineColor_31(HandleRef pThis, double r, double g, double b);

		/// <summary>
		/// Set/get the color of the outline of this widget.  The outline is visible
		/// when (in interactive mode) the cursor is over this widget.
		/// Default is white (1,1,1).
		/// </summary>
		// Token: 0x0600979A RID: 38810 RVA: 0x000D6ADF File Offset: 0x000D4CDF
		public void SetOutlineColor(double r, double g, double b)
		{
			vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_SetOutlineColor_31(base.GetCppThis(), r, g, b);
		}

		// Token: 0x0600979B RID: 38811
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationMarkerWidget_SetShouldConstrainSize_32(HandleRef pThis, int shouldConstrainSize);

		/// <summary>
		/// Set/get whether the widget should constrain the size to be within the min and max limits.
		/// Default is off (unconstrained).
		/// </summary>
		// Token: 0x0600979C RID: 38812 RVA: 0x000D6AF1 File Offset: 0x000D4CF1
		public void SetShouldConstrainSize(int shouldConstrainSize)
		{
			vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_SetShouldConstrainSize_32(base.GetCppThis(), shouldConstrainSize);
		}

		// Token: 0x0600979D RID: 38813
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOrientationMarkerWidget_SetSizeConstraintDimensionSizes_33(HandleRef pThis, int minDimensionSize, int maxDimensionSize);

		/// <summary>
		/// Sets the minimum and maximum dimension (width and height) size limits for the widget.
		/// Validates the sizes are within tolerances before setting; ignoring otherwise.
		/// Default is 20, 500.
		/// Returns whether the sizes are valid and correctly set (true), or invalid (false).
		/// </summary>
		// Token: 0x0600979E RID: 38814 RVA: 0x000D6B04 File Offset: 0x000D4D04
		public bool SetSizeConstraintDimensionSizes(int minDimensionSize, int maxDimensionSize)
		{
			return vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_SetSizeConstraintDimensionSizes_33(base.GetCppThis(), minDimensionSize, maxDimensionSize) != 0;
		}

		// Token: 0x0600979F RID: 38815
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationMarkerWidget_SetTolerance_34(HandleRef pThis, int _arg);

		/// <summary>
		/// The tolerance representing the distance to the widget (in pixels)
		/// in which the cursor is considered to be on the widget, or on a
		/// widget feature (e.g., a corner point or edge).
		/// </summary>
		// Token: 0x060097A0 RID: 38816 RVA: 0x000D6B2C File Offset: 0x000D4D2C
		public virtual void SetTolerance(int _arg)
		{
			vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_SetTolerance_34(base.GetCppThis(), _arg);
		}

		// Token: 0x060097A1 RID: 38817
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationMarkerWidget_SetViewport_35(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		/// <summary>
		/// Set/get the viewport to position/size this widget.
		/// Coordinates are expressed as (xmin,ymin,xmax,ymax), where each
		/// coordinate is 0 &lt;= coordinate &lt;= 1.0.
		/// Default is bottom left corner (0,0,0.2,0.2).
		/// Note that this viewport is scaled with respect to the viewport of the
		/// current renderer i.e. if the viewport of the current renderer is
		/// (0.5, 0.5, 0.75, 0.75) and Viewport is set to (0, 0, 1, 1), the orientation
		/// marker will be confined to a viewport of (0.5, 0.5, 0.75, 0.75) in the
		/// render window.
		/// \sa SetCurrentRenderer()
		/// </summary>
		// Token: 0x060097A2 RID: 38818 RVA: 0x000D6B3C File Offset: 0x000D4D3C
		public virtual void SetViewport(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_SetViewport_35(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x060097A3 RID: 38819
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationMarkerWidget_SetViewport_36(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the viewport to position/size this widget.
		/// Coordinates are expressed as (xmin,ymin,xmax,ymax), where each
		/// coordinate is 0 &lt;= coordinate &lt;= 1.0.
		/// Default is bottom left corner (0,0,0.2,0.2).
		/// Note that this viewport is scaled with respect to the viewport of the
		/// current renderer i.e. if the viewport of the current renderer is
		/// (0.5, 0.5, 0.75, 0.75) and Viewport is set to (0, 0, 1, 1), the orientation
		/// marker will be confined to a viewport of (0.5, 0.5, 0.75, 0.75) in the
		/// render window.
		/// \sa SetCurrentRenderer()
		/// </summary>
		// Token: 0x060097A4 RID: 38820 RVA: 0x000D6B50 File Offset: 0x000D4D50
		public virtual void SetViewport(IntPtr _arg)
		{
			vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_SetViewport_36(base.GetCppThis(), _arg);
		}

		// Token: 0x060097A5 RID: 38821
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationMarkerWidget_SetZoom_37(HandleRef pThis, double _arg);

		/// <summary>
		/// The zoom factor to modify the size of the marker within the widget.
		/// Default is 1.0.
		/// </summary>
		// Token: 0x060097A6 RID: 38822 RVA: 0x000D6B60 File Offset: 0x000D4D60
		public virtual void SetZoom(double _arg)
		{
			vtkOrientationMarkerWidget.vtkOrientationMarkerWidget_SetZoom_37(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C5F RID: 3167
		public new const string MRFullTypeName = "Kitware.VTK.vtkOrientationMarkerWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C60 RID: 3168
		public new static readonly string MRClassNameKey = "class vtkOrientationMarkerWidget";
	}
}
