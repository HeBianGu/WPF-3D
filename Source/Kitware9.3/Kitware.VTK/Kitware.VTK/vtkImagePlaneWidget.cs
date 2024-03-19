using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImagePlaneWidget
	/// </summary>
	/// <remarks>
	///    3D widget for reslicing image data
	///
	/// This 3D widget defines a plane that can be interactively placed in an
	/// image volume. A nice feature of the object is that the
	/// vtkImagePlaneWidget, like any 3D widget, will work with the current
	/// interactor style. That is, if vtkImagePlaneWidget does not handle an
	/// event, then all other registered observers (including the interactor
	/// style) have an opportunity to process the event. Otherwise, the
	/// vtkImagePlaneWidget will terminate the processing of the event that it
	/// handles.
	///
	/// The core functionality of the widget is provided by a vtkImageReslice
	/// object which passes its output onto a texture mapping pipeline for fast
	/// slicing through volumetric data. See the key methods: GenerateTexturePlane()
	/// and UpdatePlane() for implementation details.
	///
	/// To use this object, just invoke SetInteractor() with the argument of the
	/// method a vtkRenderWindowInteractor.  You may also wish to invoke
	/// "PlaceWidget()" to initially position the widget. If the "i" key (for
	/// "interactor") is pressed, the vtkImagePlaneWidget will appear. (See
	/// superclass documentation for information about changing this behavior.)
	///
	/// Selecting the widget with the middle mouse button with and without holding
	/// the shift or control keys enables complex reslicing capablilites.
	/// To facilitate use, a set of 'margins' (left, right, top, bottom) are shown as
	/// a set of plane-axes aligned lines, the properties of which can be changed
	/// as a group.
	/// Without keyboard modifiers: selecting in the middle of the margins
	/// enables translation of the plane along its normal. Selecting one of the
	/// corners within the margins enables spinning around the plane's normal at its
	/// center.  Selecting within a margin allows rotating about the center of the
	/// plane around an axis aligned with the margin (i.e., selecting left margin
	/// enables rotating around the plane's local y-prime axis).
	/// With control key modifier: margin selection enables edge translation (i.e., a
	/// constrained form of scaling). Selecting within the margins enables
	/// translation of the entire plane.
	/// With shift key modifier: uniform plane scaling is enabled.  Moving the mouse
	/// up enlarges the plane while downward movement shrinks it.
	///
	/// Window-level is achieved by using the right mouse button.  Window-level
	/// values can be reset by shift + 'r' or control + 'r' while regular reset
	/// camera is maintained with 'r' or 'R'.
	/// The left mouse button can be used to query the underlying image data
	/// with a snap-to cross-hair cursor.  Currently, the nearest point in the input
	/// image data to the mouse cursor generates the cross-hairs.  With oblique
	/// slicing, this behaviour may appear unsatisfactory. Text display of
	/// window-level and image coordinates/data values are provided by a text
	/// actor/mapper pair.
	///
	/// Events that occur outside of the widget (i.e., no part of the widget is
	/// picked) are propagated to any other registered obsevers (such as the
	/// interaction style). Turn off the widget by pressing the "i" key again
	/// (or invoke the Off() method). To support interactive manipulation of
	/// objects, this class invokes the events StartInteractionEvent,
	/// InteractionEvent, and EndInteractionEvent as well as StartWindowLevelEvent,
	/// WindowLevelEvent, EndWindowLevelEvent and ResetWindowLevelEvent.
	///
	/// The vtkImagePlaneWidget has several methods that can be used in
	/// conjunction with other VTK objects. The GetPolyData() method can be used
	/// to get the polygonal representation of the plane and can be used as input
	/// for other VTK objects. Typical usage of the widget is to make use of the
	/// StartInteractionEvent, InteractionEvent, and EndInteractionEvent
	/// events. The InteractionEvent is called on mouse motion; the other two
	/// events are called on button down and button up (either left or right
	/// button).
	///
	/// Some additional features of this class include the ability to control the
	/// properties of the widget. You can set the properties of: the selected and
	/// unselected representations of the plane's outline; the text actor via its
	/// vtkTextProperty; the cross-hair cursor. In addition there are methods to
	/// constrain the plane so that it is aligned along the x-y-z axes.  Finally,
	/// one can specify the degree of interpolation (vtkImageReslice): nearest
	/// neighbour, linear, and cubic.
	///
	/// A simpler version of this widget is the combination of
	/// vtkImplicitPlaneWidget2 combined with the representation
	/// vtkImplicitImageRepresentation.
	///
	/// @par Thanks:
	/// Thanks to Dean Inglis for developing and contributing this class.
	/// Based on the Python SlicePlaneFactory from Atamai, Inc.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtk3DWidget vtkBoxWidget vtkLineWidget  vtkPlaneWidget vtkPointWidget
	/// vtkPolyDataSourceWidget vtkSphereWidget vtkImplicitPlaneWidget
	/// vtkImplicitPlaneWidget2 vtkImplicitImageRepresentation
	/// </seealso>
	// Token: 0x02000326 RID: 806
	public class vtkImagePlaneWidget : vtkPolyDataSourceWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009009 RID: 36873 RVA: 0x000CD29A File Offset: 0x000CB49A
		static vtkImagePlaneWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImagePlaneWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImagePlaneWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600900A RID: 36874 RVA: 0x000CD2C2 File Offset: 0x000CB4C2
		public vtkImagePlaneWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600900B RID: 36875
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePlaneWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600900C RID: 36876 RVA: 0x000CD2D0 File Offset: 0x000CB4D0
		public new static vtkImagePlaneWidget New()
		{
			vtkImagePlaneWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImagePlaneWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600900D RID: 36877 RVA: 0x000CD324 File Offset: 0x000CB524
		public vtkImagePlaneWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImagePlaneWidget.vtkImagePlaneWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600900E RID: 36878 RVA: 0x000CD368 File Offset: 0x000CB568
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600900F RID: 36879
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_DisplayTextOff_01(HandleRef pThis);

		/// <summary>
		/// Enable/disable text display of window-level, image coordinates and
		/// scalar values in a render window.
		/// </summary>
		// Token: 0x06009010 RID: 36880 RVA: 0x000CD373 File Offset: 0x000CB573
		public virtual void DisplayTextOff()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_DisplayTextOff_01(base.GetCppThis());
		}

		// Token: 0x06009011 RID: 36881
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_DisplayTextOn_02(HandleRef pThis);

		/// <summary>
		/// Enable/disable text display of window-level, image coordinates and
		/// scalar values in a render window.
		/// </summary>
		// Token: 0x06009012 RID: 36882 RVA: 0x000CD382 File Offset: 0x000CB582
		public virtual void DisplayTextOn()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_DisplayTextOn_02(base.GetCppThis());
		}

		// Token: 0x06009013 RID: 36883
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePlaneWidget_GetCenter_03(HandleRef pThis);

		/// <summary>
		/// Get the center of the plane.
		/// </summary>
		// Token: 0x06009014 RID: 36884 RVA: 0x000CD394 File Offset: 0x000CB594
		public double[] GetCenter()
		{
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetCenter_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009015 RID: 36885
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_GetCenter_04(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// Get the center of the plane.
		/// </summary>
		// Token: 0x06009016 RID: 36886 RVA: 0x000CD3DC File Offset: 0x000CB5DC
		public void GetCenter(IntPtr xyz)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_GetCenter_04(base.GetCppThis(), xyz);
		}

		// Token: 0x06009017 RID: 36887
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePlaneWidget_GetColorMap_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Convenience method to get the vtkImageMapToColors filter used by this
		/// widget.  The user can properly render other transparent actors in a
		/// scene by calling the filter's SetOutputFormatToRGB and
		/// PassAlphaToOutputOff.
		/// </summary>
		// Token: 0x06009018 RID: 36888 RVA: 0x000CD3EC File Offset: 0x000CB5EC
		public virtual vtkImageMapToColors GetColorMap()
		{
			vtkImageMapToColors vtkImageMapToColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetColorMap_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMapToColors = (vtkImageMapToColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMapToColors.Register(null);
				}
			}
			return vtkImageMapToColors;
		}

		// Token: 0x06009019 RID: 36889
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePlaneWidget_GetCurrentCursorPosition_06(HandleRef pThis);

		/// <summary>
		/// Get the current cursor position.  To be used in conjunction with
		/// GetCursorDataStatus.
		/// </summary>
		// Token: 0x0600901A RID: 36890 RVA: 0x000CD45C File Offset: 0x000CB65C
		public virtual double[] GetCurrentCursorPosition()
		{
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetCurrentCursorPosition_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600901B RID: 36891
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_GetCurrentCursorPosition_07(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Get the current cursor position.  To be used in conjunction with
		/// GetCursorDataStatus.
		/// </summary>
		// Token: 0x0600901C RID: 36892 RVA: 0x000CD4A4 File Offset: 0x000CB6A4
		public virtual void GetCurrentCursorPosition(IntPtr data)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_GetCurrentCursorPosition_07(base.GetCppThis(), data);
		}

		// Token: 0x0600901D RID: 36893
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImagePlaneWidget_GetCurrentImageValue_08(HandleRef pThis);

		/// <summary>
		/// Get the current image value at the current cursor position.  To
		/// be used in conjunction with GetCursorDataStatus.  The value is
		/// VTK_DOUBLE_MAX when the data is invalid.
		/// </summary>
		// Token: 0x0600901E RID: 36894 RVA: 0x000CD4B4 File Offset: 0x000CB6B4
		public virtual double GetCurrentImageValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetCurrentImageValue_08(base.GetCppThis());
		}

		// Token: 0x0600901F RID: 36895
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_GetCursorData_09(HandleRef pThis, IntPtr xyzv);

		/// <summary>
		/// Get the image coordinate position and voxel value.  Currently only
		/// supports single component image data.
		/// </summary>
		// Token: 0x06009020 RID: 36896 RVA: 0x000CD4D4 File Offset: 0x000CB6D4
		public int GetCursorData(IntPtr xyzv)
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetCursorData_09(base.GetCppThis(), xyzv);
		}

		// Token: 0x06009021 RID: 36897
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_GetCursorDataStatus_10(HandleRef pThis);

		/// <summary>
		/// Get the status of the cursor data.  If this returns 1 the
		/// CurrentCursorPosition and CurrentImageValue will have current
		/// data.  If it returns 0, these values are invalid.
		/// </summary>
		// Token: 0x06009022 RID: 36898 RVA: 0x000CD4F4 File Offset: 0x000CB6F4
		public int GetCursorDataStatus()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetCursorDataStatus_10(base.GetCppThis());
		}

		// Token: 0x06009023 RID: 36899
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePlaneWidget_GetCursorProperty_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the properties of the cross-hair cursor.
		/// </summary>
		// Token: 0x06009024 RID: 36900 RVA: 0x000CD514 File Offset: 0x000CB714
		public virtual vtkProperty GetCursorProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetCursorProperty_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x06009025 RID: 36901
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_GetDisplayText_12(HandleRef pThis);

		/// <summary>
		/// Enable/disable text display of window-level, image coordinates and
		/// scalar values in a render window.
		/// </summary>
		// Token: 0x06009026 RID: 36902 RVA: 0x000CD584 File Offset: 0x000CB784
		public virtual int GetDisplayText()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetDisplayText_12(base.GetCppThis());
		}

		// Token: 0x06009027 RID: 36903
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_GetInteraction_13(HandleRef pThis);

		/// <summary>
		/// Enable/disable mouse interaction so the widget remains on display.
		/// </summary>
		// Token: 0x06009028 RID: 36904 RVA: 0x000CD5A4 File Offset: 0x000CB7A4
		public virtual int GetInteraction()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetInteraction_13(base.GetCppThis());
		}

		// Token: 0x06009029 RID: 36905
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_GetLeftButtonAction_14(HandleRef pThis);

		/// <summary>
		/// Set action associated to buttons.
		/// </summary>
		// Token: 0x0600902A RID: 36906 RVA: 0x000CD5C4 File Offset: 0x000CB7C4
		public virtual int GetLeftButtonAction()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetLeftButtonAction_14(base.GetCppThis());
		}

		// Token: 0x0600902B RID: 36907
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_GetLeftButtonActionMaxValue_15(HandleRef pThis);

		/// <summary>
		/// Set action associated to buttons.
		/// </summary>
		// Token: 0x0600902C RID: 36908 RVA: 0x000CD5E4 File Offset: 0x000CB7E4
		public virtual int GetLeftButtonActionMaxValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetLeftButtonActionMaxValue_15(base.GetCppThis());
		}

		// Token: 0x0600902D RID: 36909
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_GetLeftButtonActionMinValue_16(HandleRef pThis);

		/// <summary>
		/// Set action associated to buttons.
		/// </summary>
		// Token: 0x0600902E RID: 36910 RVA: 0x000CD604 File Offset: 0x000CB804
		public virtual int GetLeftButtonActionMinValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetLeftButtonActionMinValue_16(base.GetCppThis());
		}

		// Token: 0x0600902F RID: 36911
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_GetLeftButtonAutoModifier_17(HandleRef pThis);

		/// <summary>
		/// Set the auto-modifiers associated to buttons.
		/// This allows users to bind some buttons to actions that are usually
		/// triggered by a key modifier. For example, if you do not need cursoring,
		/// you can bind the left button action to VTK_SLICE_MOTION_ACTION (see above)
		/// and the left button auto modifier to VTK_CONTROL_MODIFIER: you end up with
		/// the left button controlling panning without pressing a key.
		/// </summary>
		// Token: 0x06009030 RID: 36912 RVA: 0x000CD624 File Offset: 0x000CB824
		public virtual int GetLeftButtonAutoModifier()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetLeftButtonAutoModifier_17(base.GetCppThis());
		}

		// Token: 0x06009031 RID: 36913
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_GetLeftButtonAutoModifierMaxValue_18(HandleRef pThis);

		/// <summary>
		/// Set the auto-modifiers associated to buttons.
		/// This allows users to bind some buttons to actions that are usually
		/// triggered by a key modifier. For example, if you do not need cursoring,
		/// you can bind the left button action to VTK_SLICE_MOTION_ACTION (see above)
		/// and the left button auto modifier to VTK_CONTROL_MODIFIER: you end up with
		/// the left button controlling panning without pressing a key.
		/// </summary>
		// Token: 0x06009032 RID: 36914 RVA: 0x000CD644 File Offset: 0x000CB844
		public virtual int GetLeftButtonAutoModifierMaxValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetLeftButtonAutoModifierMaxValue_18(base.GetCppThis());
		}

		// Token: 0x06009033 RID: 36915
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_GetLeftButtonAutoModifierMinValue_19(HandleRef pThis);

		/// <summary>
		/// Set the auto-modifiers associated to buttons.
		/// This allows users to bind some buttons to actions that are usually
		/// triggered by a key modifier. For example, if you do not need cursoring,
		/// you can bind the left button action to VTK_SLICE_MOTION_ACTION (see above)
		/// and the left button auto modifier to VTK_CONTROL_MODIFIER: you end up with
		/// the left button controlling panning without pressing a key.
		/// </summary>
		// Token: 0x06009034 RID: 36916 RVA: 0x000CD664 File Offset: 0x000CB864
		public virtual int GetLeftButtonAutoModifierMinValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetLeftButtonAutoModifierMinValue_19(base.GetCppThis());
		}

		// Token: 0x06009035 RID: 36917
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImagePlaneWidget_GetLevel_20(HandleRef pThis);

		/// <summary>
		/// Set/Get the current window and level values.  SetWindowLevel should
		/// only be called after SetInput.  If a shared lookup table is being used,
		/// a callback is required to update the window level values without having
		/// to update the lookup table again.
		/// </summary>
		// Token: 0x06009036 RID: 36918 RVA: 0x000CD684 File Offset: 0x000CB884
		public double GetLevel()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetLevel_20(base.GetCppThis());
		}

		// Token: 0x06009037 RID: 36919
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePlaneWidget_GetLookupTable_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the internal lookuptable (lut) to one defined by the user, or,
		/// alternatively, to the lut of another vtkImgePlaneWidget.  In this way,
		/// a set of three orthogonal planes can share the same lut so that
		/// window-levelling is performed uniformly among planes.  The default
		/// internal lut can be re- set/allocated by setting to 0 (nullptr).
		/// </summary>
		// Token: 0x06009038 RID: 36920 RVA: 0x000CD6A4 File Offset: 0x000CB8A4
		public virtual vtkLookupTable GetLookupTable()
		{
			vtkLookupTable vtkLookupTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetLookupTable_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLookupTable = (vtkLookupTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLookupTable.Register(null);
				}
			}
			return vtkLookupTable;
		}

		// Token: 0x06009039 RID: 36921
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePlaneWidget_GetMarginProperty_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the properties of the margins.
		/// </summary>
		// Token: 0x0600903A RID: 36922 RVA: 0x000CD714 File Offset: 0x000CB914
		public virtual vtkProperty GetMarginProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetMarginProperty_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600903B RID: 36923
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImagePlaneWidget_GetMarginSizeX_23(HandleRef pThis);

		/// <summary>
		/// Set the size of the margins based on a percentage of the
		/// plane's width and height, limited between 0 and 50%.
		/// </summary>
		// Token: 0x0600903C RID: 36924 RVA: 0x000CD784 File Offset: 0x000CB984
		public virtual double GetMarginSizeX()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetMarginSizeX_23(base.GetCppThis());
		}

		// Token: 0x0600903D RID: 36925
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImagePlaneWidget_GetMarginSizeXMaxValue_24(HandleRef pThis);

		/// <summary>
		/// Set the size of the margins based on a percentage of the
		/// plane's width and height, limited between 0 and 50%.
		/// </summary>
		// Token: 0x0600903E RID: 36926 RVA: 0x000CD7A4 File Offset: 0x000CB9A4
		public virtual double GetMarginSizeXMaxValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetMarginSizeXMaxValue_24(base.GetCppThis());
		}

		// Token: 0x0600903F RID: 36927
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImagePlaneWidget_GetMarginSizeXMinValue_25(HandleRef pThis);

		/// <summary>
		/// Set the size of the margins based on a percentage of the
		/// plane's width and height, limited between 0 and 50%.
		/// </summary>
		// Token: 0x06009040 RID: 36928 RVA: 0x000CD7C4 File Offset: 0x000CB9C4
		public virtual double GetMarginSizeXMinValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetMarginSizeXMinValue_25(base.GetCppThis());
		}

		// Token: 0x06009041 RID: 36929
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImagePlaneWidget_GetMarginSizeY_26(HandleRef pThis);

		/// <summary>
		/// Set the size of the margins based on a percentage of the
		/// plane's width and height, limited between 0 and 50%.
		/// </summary>
		// Token: 0x06009042 RID: 36930 RVA: 0x000CD7E4 File Offset: 0x000CB9E4
		public virtual double GetMarginSizeY()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetMarginSizeY_26(base.GetCppThis());
		}

		// Token: 0x06009043 RID: 36931
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImagePlaneWidget_GetMarginSizeYMaxValue_27(HandleRef pThis);

		/// <summary>
		/// Set the size of the margins based on a percentage of the
		/// plane's width and height, limited between 0 and 50%.
		/// </summary>
		// Token: 0x06009044 RID: 36932 RVA: 0x000CD804 File Offset: 0x000CBA04
		public virtual double GetMarginSizeYMaxValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetMarginSizeYMaxValue_27(base.GetCppThis());
		}

		// Token: 0x06009045 RID: 36933
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImagePlaneWidget_GetMarginSizeYMinValue_28(HandleRef pThis);

		/// <summary>
		/// Set the size of the margins based on a percentage of the
		/// plane's width and height, limited between 0 and 50%.
		/// </summary>
		// Token: 0x06009046 RID: 36934 RVA: 0x000CD824 File Offset: 0x000CBA24
		public virtual double GetMarginSizeYMinValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetMarginSizeYMinValue_28(base.GetCppThis());
		}

		// Token: 0x06009047 RID: 36935
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_GetMiddleButtonAction_29(HandleRef pThis);

		/// <summary>
		/// Set action associated to buttons.
		/// </summary>
		// Token: 0x06009048 RID: 36936 RVA: 0x000CD844 File Offset: 0x000CBA44
		public virtual int GetMiddleButtonAction()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetMiddleButtonAction_29(base.GetCppThis());
		}

		// Token: 0x06009049 RID: 36937
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_GetMiddleButtonActionMaxValue_30(HandleRef pThis);

		/// <summary>
		/// Set action associated to buttons.
		/// </summary>
		// Token: 0x0600904A RID: 36938 RVA: 0x000CD864 File Offset: 0x000CBA64
		public virtual int GetMiddleButtonActionMaxValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetMiddleButtonActionMaxValue_30(base.GetCppThis());
		}

		// Token: 0x0600904B RID: 36939
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_GetMiddleButtonActionMinValue_31(HandleRef pThis);

		/// <summary>
		/// Set action associated to buttons.
		/// </summary>
		// Token: 0x0600904C RID: 36940 RVA: 0x000CD884 File Offset: 0x000CBA84
		public virtual int GetMiddleButtonActionMinValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetMiddleButtonActionMinValue_31(base.GetCppThis());
		}

		// Token: 0x0600904D RID: 36941
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_GetMiddleButtonAutoModifier_32(HandleRef pThis);

		/// <summary>
		/// Set the auto-modifiers associated to buttons.
		/// This allows users to bind some buttons to actions that are usually
		/// triggered by a key modifier. For example, if you do not need cursoring,
		/// you can bind the left button action to VTK_SLICE_MOTION_ACTION (see above)
		/// and the left button auto modifier to VTK_CONTROL_MODIFIER: you end up with
		/// the left button controlling panning without pressing a key.
		/// </summary>
		// Token: 0x0600904E RID: 36942 RVA: 0x000CD8A4 File Offset: 0x000CBAA4
		public virtual int GetMiddleButtonAutoModifier()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetMiddleButtonAutoModifier_32(base.GetCppThis());
		}

		// Token: 0x0600904F RID: 36943
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_GetMiddleButtonAutoModifierMaxValue_33(HandleRef pThis);

		/// <summary>
		/// Set the auto-modifiers associated to buttons.
		/// This allows users to bind some buttons to actions that are usually
		/// triggered by a key modifier. For example, if you do not need cursoring,
		/// you can bind the left button action to VTK_SLICE_MOTION_ACTION (see above)
		/// and the left button auto modifier to VTK_CONTROL_MODIFIER: you end up with
		/// the left button controlling panning without pressing a key.
		/// </summary>
		// Token: 0x06009050 RID: 36944 RVA: 0x000CD8C4 File Offset: 0x000CBAC4
		public virtual int GetMiddleButtonAutoModifierMaxValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetMiddleButtonAutoModifierMaxValue_33(base.GetCppThis());
		}

		// Token: 0x06009051 RID: 36945
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_GetMiddleButtonAutoModifierMinValue_34(HandleRef pThis);

		/// <summary>
		/// Set the auto-modifiers associated to buttons.
		/// This allows users to bind some buttons to actions that are usually
		/// triggered by a key modifier. For example, if you do not need cursoring,
		/// you can bind the left button action to VTK_SLICE_MOTION_ACTION (see above)
		/// and the left button auto modifier to VTK_CONTROL_MODIFIER: you end up with
		/// the left button controlling panning without pressing a key.
		/// </summary>
		// Token: 0x06009052 RID: 36946 RVA: 0x000CD8E4 File Offset: 0x000CBAE4
		public virtual int GetMiddleButtonAutoModifierMinValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetMiddleButtonAutoModifierMinValue_34(base.GetCppThis());
		}

		// Token: 0x06009053 RID: 36947
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePlaneWidget_GetNormal_35(HandleRef pThis);

		/// <summary>
		/// Get the normal to the plane.
		/// </summary>
		// Token: 0x06009054 RID: 36948 RVA: 0x000CD904 File Offset: 0x000CBB04
		public double[] GetNormal()
		{
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetNormal_35(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009055 RID: 36949
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_GetNormal_36(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// Get the normal to the plane.
		/// </summary>
		// Token: 0x06009056 RID: 36950 RVA: 0x000CD94C File Offset: 0x000CBB4C
		public void GetNormal(IntPtr xyz)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_GetNormal_36(base.GetCppThis(), xyz);
		}

		// Token: 0x06009057 RID: 36951
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImagePlaneWidget_GetNumberOfGenerationsFromBase_37(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009058 RID: 36952 RVA: 0x000CD95C File Offset: 0x000CBB5C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetNumberOfGenerationsFromBase_37(base.GetCppThis(), type);
		}

		// Token: 0x06009059 RID: 36953
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImagePlaneWidget_GetNumberOfGenerationsFromBaseType_38([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600905A RID: 36954 RVA: 0x000CD97C File Offset: 0x000CBB7C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetNumberOfGenerationsFromBaseType_38(type);
		}

		// Token: 0x0600905B RID: 36955
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePlaneWidget_GetOrigin_39(HandleRef pThis);

		/// <summary>
		/// Set/Get the origin of the plane.
		/// </summary>
		// Token: 0x0600905C RID: 36956 RVA: 0x000CD998 File Offset: 0x000CBB98
		public double[] GetOrigin()
		{
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetOrigin_39(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600905D RID: 36957
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_GetOrigin_40(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// Set/Get the origin of the plane.
		/// </summary>
		// Token: 0x0600905E RID: 36958 RVA: 0x000CD9E0 File Offset: 0x000CBBE0
		public void GetOrigin(IntPtr xyz)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_GetOrigin_40(base.GetCppThis(), xyz);
		}

		// Token: 0x0600905F RID: 36959
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_GetPlaneOrientation_41(HandleRef pThis);

		/// <summary>
		/// Convenience method sets the plane orientation normal to the
		/// x, y, or z axes.  Default is XAxes (0).
		/// </summary>
		// Token: 0x06009060 RID: 36960 RVA: 0x000CD9F0 File Offset: 0x000CBBF0
		public virtual int GetPlaneOrientation()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetPlaneOrientation_41(base.GetCppThis());
		}

		// Token: 0x06009061 RID: 36961
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePlaneWidget_GetPlaneProperty_42(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the plane's outline properties. The properties of the plane's
		/// outline when selected and unselected can be manipulated.
		/// </summary>
		// Token: 0x06009062 RID: 36962 RVA: 0x000CDA10 File Offset: 0x000CBC10
		public virtual vtkProperty GetPlaneProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetPlaneProperty_42(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x06009063 RID: 36963
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePlaneWidget_GetPoint1_43(HandleRef pThis);

		/// <summary>
		/// Set/Get the position of the point defining the first axis of the plane.
		/// </summary>
		// Token: 0x06009064 RID: 36964 RVA: 0x000CDA80 File Offset: 0x000CBC80
		public double[] GetPoint1()
		{
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetPoint1_43(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009065 RID: 36965
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_GetPoint1_44(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// Set/Get the position of the point defining the first axis of the plane.
		/// </summary>
		// Token: 0x06009066 RID: 36966 RVA: 0x000CDAC8 File Offset: 0x000CBCC8
		public void GetPoint1(IntPtr xyz)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_GetPoint1_44(base.GetCppThis(), xyz);
		}

		// Token: 0x06009067 RID: 36967
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePlaneWidget_GetPoint2_45(HandleRef pThis);

		/// <summary>
		/// Set/Get the position of the point defining the second axis of the plane.
		/// </summary>
		// Token: 0x06009068 RID: 36968 RVA: 0x000CDAD8 File Offset: 0x000CBCD8
		public double[] GetPoint2()
		{
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetPoint2_45(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009069 RID: 36969
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_GetPoint2_46(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// Set/Get the position of the point defining the second axis of the plane.
		/// </summary>
		// Token: 0x0600906A RID: 36970 RVA: 0x000CDB20 File Offset: 0x000CBD20
		public void GetPoint2(IntPtr xyz)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_GetPoint2_46(base.GetCppThis(), xyz);
		}

		// Token: 0x0600906B RID: 36971
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_GetPolyData_47(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Grab the polydata (including points) that defines the plane.  The
		/// polydata consists of (res+1)*(res+1) points, and res*res quadrilateral
		/// polygons, where res is the resolution of the plane. These point values
		/// are guaranteed to be up-to-date when either the InteractionEvent or
		/// EndInteraction events are invoked. The user provides the vtkPolyData and
		/// the points and polygons are added to it.
		/// </summary>
		// Token: 0x0600906C RID: 36972 RVA: 0x000CDB30 File Offset: 0x000CBD30
		public void GetPolyData(vtkPolyData pd)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_GetPolyData_47(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0600906D RID: 36973
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePlaneWidget_GetPolyDataAlgorithm_48(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Satisfies superclass API.  This returns a pointer to the underlying
		/// vtkPolyData.  Make changes to this before calling the initial PlaceWidget()
		/// to have the initial placement follow suit.  Or, make changes after the
		/// widget has been initialised and call UpdatePlacement() to realise.
		/// </summary>
		// Token: 0x0600906E RID: 36974 RVA: 0x000CDB60 File Offset: 0x000CBD60
		public override vtkPolyDataAlgorithm GetPolyDataAlgorithm()
		{
			vtkPolyDataAlgorithm vtkPolyDataAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetPolyDataAlgorithm_48(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataAlgorithm = (vtkPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataAlgorithm.Register(null);
				}
			}
			return vtkPolyDataAlgorithm;
		}

		// Token: 0x0600906F RID: 36975
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePlaneWidget_GetReslice_49(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the current reslice class and reslice axes
		/// </summary>
		// Token: 0x06009070 RID: 36976 RVA: 0x000CDBD0 File Offset: 0x000CBDD0
		public virtual vtkImageReslice GetReslice()
		{
			vtkImageReslice vtkImageReslice = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetReslice_49(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageReslice = (vtkImageReslice)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageReslice.Register(null);
				}
			}
			return vtkImageReslice;
		}

		// Token: 0x06009071 RID: 36977
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePlaneWidget_GetResliceAxes_50(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the current reslice class and reslice axes
		/// </summary>
		// Token: 0x06009072 RID: 36978 RVA: 0x000CDC40 File Offset: 0x000CBE40
		public virtual vtkMatrix4x4 GetResliceAxes()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetResliceAxes_50(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x06009073 RID: 36979
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_GetResliceInterpolate_51(HandleRef pThis);

		/// <summary>
		/// Set the interpolation to use when texturing the plane.
		/// </summary>
		// Token: 0x06009074 RID: 36980 RVA: 0x000CDCB0 File Offset: 0x000CBEB0
		public virtual int GetResliceInterpolate()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetResliceInterpolate_51(base.GetCppThis());
		}

		// Token: 0x06009075 RID: 36981
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePlaneWidget_GetResliceOutput_52(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Convenience method to get the vtkImageReslice output.
		/// </summary>
		// Token: 0x06009076 RID: 36982 RVA: 0x000CDCD0 File Offset: 0x000CBED0
		public vtkImageData GetResliceOutput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetResliceOutput_52(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009077 RID: 36983
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_GetRestrictPlaneToVolume_53(HandleRef pThis);

		/// <summary>
		/// Make sure that the plane remains within the volume.
		/// Default is On.
		/// </summary>
		// Token: 0x06009078 RID: 36984 RVA: 0x000CDD40 File Offset: 0x000CBF40
		public virtual int GetRestrictPlaneToVolume()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetRestrictPlaneToVolume_53(base.GetCppThis());
		}

		// Token: 0x06009079 RID: 36985
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_GetRightButtonAction_54(HandleRef pThis);

		/// <summary>
		/// Set action associated to buttons.
		/// </summary>
		// Token: 0x0600907A RID: 36986 RVA: 0x000CDD60 File Offset: 0x000CBF60
		public virtual int GetRightButtonAction()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetRightButtonAction_54(base.GetCppThis());
		}

		// Token: 0x0600907B RID: 36987
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_GetRightButtonActionMaxValue_55(HandleRef pThis);

		/// <summary>
		/// Set action associated to buttons.
		/// </summary>
		// Token: 0x0600907C RID: 36988 RVA: 0x000CDD80 File Offset: 0x000CBF80
		public virtual int GetRightButtonActionMaxValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetRightButtonActionMaxValue_55(base.GetCppThis());
		}

		// Token: 0x0600907D RID: 36989
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_GetRightButtonActionMinValue_56(HandleRef pThis);

		/// <summary>
		/// Set action associated to buttons.
		/// </summary>
		// Token: 0x0600907E RID: 36990 RVA: 0x000CDDA0 File Offset: 0x000CBFA0
		public virtual int GetRightButtonActionMinValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetRightButtonActionMinValue_56(base.GetCppThis());
		}

		// Token: 0x0600907F RID: 36991
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_GetRightButtonAutoModifier_57(HandleRef pThis);

		/// <summary>
		/// Set the auto-modifiers associated to buttons.
		/// This allows users to bind some buttons to actions that are usually
		/// triggered by a key modifier. For example, if you do not need cursoring,
		/// you can bind the left button action to VTK_SLICE_MOTION_ACTION (see above)
		/// and the left button auto modifier to VTK_CONTROL_MODIFIER: you end up with
		/// the left button controlling panning without pressing a key.
		/// </summary>
		// Token: 0x06009080 RID: 36992 RVA: 0x000CDDC0 File Offset: 0x000CBFC0
		public virtual int GetRightButtonAutoModifier()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetRightButtonAutoModifier_57(base.GetCppThis());
		}

		// Token: 0x06009081 RID: 36993
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_GetRightButtonAutoModifierMaxValue_58(HandleRef pThis);

		/// <summary>
		/// Set the auto-modifiers associated to buttons.
		/// This allows users to bind some buttons to actions that are usually
		/// triggered by a key modifier. For example, if you do not need cursoring,
		/// you can bind the left button action to VTK_SLICE_MOTION_ACTION (see above)
		/// and the left button auto modifier to VTK_CONTROL_MODIFIER: you end up with
		/// the left button controlling panning without pressing a key.
		/// </summary>
		// Token: 0x06009082 RID: 36994 RVA: 0x000CDDE0 File Offset: 0x000CBFE0
		public virtual int GetRightButtonAutoModifierMaxValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetRightButtonAutoModifierMaxValue_58(base.GetCppThis());
		}

		// Token: 0x06009083 RID: 36995
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_GetRightButtonAutoModifierMinValue_59(HandleRef pThis);

		/// <summary>
		/// Set the auto-modifiers associated to buttons.
		/// This allows users to bind some buttons to actions that are usually
		/// triggered by a key modifier. For example, if you do not need cursoring,
		/// you can bind the left button action to VTK_SLICE_MOTION_ACTION (see above)
		/// and the left button auto modifier to VTK_CONTROL_MODIFIER: you end up with
		/// the left button controlling panning without pressing a key.
		/// </summary>
		// Token: 0x06009084 RID: 36996 RVA: 0x000CDE00 File Offset: 0x000CC000
		public virtual int GetRightButtonAutoModifierMinValue()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetRightButtonAutoModifierMinValue_59(base.GetCppThis());
		}

		// Token: 0x06009085 RID: 36997
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePlaneWidget_GetSelectedPlaneProperty_60(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the plane's outline properties. The properties of the plane's
		/// outline when selected and unselected can be manipulated.
		/// </summary>
		// Token: 0x06009086 RID: 36998 RVA: 0x000CDE20 File Offset: 0x000CC020
		public virtual vtkProperty GetSelectedPlaneProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetSelectedPlaneProperty_60(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x06009087 RID: 36999
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_GetSliceIndex_61(HandleRef pThis);

		/// <summary>
		/// Get the slice position in terms of the data extent.
		/// </summary>
		// Token: 0x06009088 RID: 37000 RVA: 0x000CDE90 File Offset: 0x000CC090
		public int GetSliceIndex()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetSliceIndex_61(base.GetCppThis());
		}

		// Token: 0x06009089 RID: 37001
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImagePlaneWidget_GetSlicePosition_62(HandleRef pThis);

		/// <summary>
		/// Get the position of the slice along its normal.
		/// </summary>
		// Token: 0x0600908A RID: 37002 RVA: 0x000CDEB0 File Offset: 0x000CC0B0
		public double GetSlicePosition()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetSlicePosition_62(base.GetCppThis());
		}

		// Token: 0x0600908B RID: 37003
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePlaneWidget_GetTextProperty_63(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the text property for the image data and window-level annotation.
		/// </summary>
		// Token: 0x0600908C RID: 37004 RVA: 0x000CDED0 File Offset: 0x000CC0D0
		public vtkTextProperty GetTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetTextProperty_63(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x0600908D RID: 37005
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePlaneWidget_GetTexture_64(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Convenience method to get the texture used by this widget.  This can be
		/// used in external slice viewers.
		/// </summary>
		// Token: 0x0600908E RID: 37006 RVA: 0x000CDF40 File Offset: 0x000CC140
		public vtkTexture GetTexture()
		{
			vtkTexture vtkTexture = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetTexture_64(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTexture = (vtkTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTexture.Register(null);
				}
			}
			return vtkTexture;
		}

		// Token: 0x0600908F RID: 37007
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_GetTextureInterpolate_65(HandleRef pThis);

		/// <summary>
		/// Specify whether to interpolate the texture or not. When off, the
		/// reslice interpolation is nearest neighbour regardless of how the
		/// interpolation is set through the API. Set before setting the
		/// vtkImageData input. Default is On.
		/// </summary>
		// Token: 0x06009090 RID: 37008 RVA: 0x000CDFB0 File Offset: 0x000CC1B0
		public virtual int GetTextureInterpolate()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetTextureInterpolate_65(base.GetCppThis());
		}

		// Token: 0x06009091 RID: 37009
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePlaneWidget_GetTexturePlaneProperty_66(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the property for the resliced image.
		/// </summary>
		// Token: 0x06009092 RID: 37010 RVA: 0x000CDFD0 File Offset: 0x000CC1D0
		public virtual vtkProperty GetTexturePlaneProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_GetTexturePlaneProperty_66(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x06009093 RID: 37011
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_GetTextureVisibility_67(HandleRef pThis);

		/// <summary>
		/// Control the visibility of the actual texture mapped reformatted plane.
		/// in some cases you may only want the plane outline for example.
		/// </summary>
		// Token: 0x06009094 RID: 37012 RVA: 0x000CE040 File Offset: 0x000CC240
		public virtual int GetTextureVisibility()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetTextureVisibility_67(base.GetCppThis());
		}

		// Token: 0x06009095 RID: 37013
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_GetUseContinuousCursor_68(HandleRef pThis);

		/// <summary>
		/// Choose between voxel centered or continuous cursor probing.  With voxel
		/// centered probing, the cursor snaps to the nearest voxel and the reported
		/// cursor coordinates are extent based.  With continuous probing, voxel data
		/// is interpolated using vtkDataSetAttributes' InterpolatePoint method and
		/// the reported coordinates are 3D spatial continuous.
		/// </summary>
		// Token: 0x06009096 RID: 37014 RVA: 0x000CE060 File Offset: 0x000CC260
		public virtual int GetUseContinuousCursor()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetUseContinuousCursor_68(base.GetCppThis());
		}

		// Token: 0x06009097 RID: 37015
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_GetUserControlledLookupTable_69(HandleRef pThis);

		/// <summary>
		/// Let the user control the lookup table. NOTE: apply this method BEFORE
		/// applying the SetLookupTable method.
		/// Default is Off.
		/// </summary>
		// Token: 0x06009098 RID: 37016 RVA: 0x000CE080 File Offset: 0x000CC280
		public virtual int GetUserControlledLookupTable()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetUserControlledLookupTable_69(base.GetCppThis());
		}

		// Token: 0x06009099 RID: 37017
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_GetVector1_70(HandleRef pThis, IntPtr v1);

		/// <summary>
		/// Get the vector from the plane origin to point1.
		/// </summary>
		// Token: 0x0600909A RID: 37018 RVA: 0x000CE09F File Offset: 0x000CC29F
		public void GetVector1(IntPtr v1)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_GetVector1_70(base.GetCppThis(), v1);
		}

		// Token: 0x0600909B RID: 37019
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_GetVector2_71(HandleRef pThis, IntPtr v2);

		/// <summary>
		/// Get the vector from the plane origin to point2.
		/// </summary>
		// Token: 0x0600909C RID: 37020 RVA: 0x000CE0AF File Offset: 0x000CC2AF
		public void GetVector2(IntPtr v2)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_GetVector2_71(base.GetCppThis(), v2);
		}

		// Token: 0x0600909D RID: 37021
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImagePlaneWidget_GetWindow_72(HandleRef pThis);

		/// <summary>
		/// Set/Get the current window and level values.  SetWindowLevel should
		/// only be called after SetInput.  If a shared lookup table is being used,
		/// a callback is required to update the window level values without having
		/// to update the lookup table again.
		/// </summary>
		// Token: 0x0600909E RID: 37022 RVA: 0x000CE0C0 File Offset: 0x000CC2C0
		public double GetWindow()
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_GetWindow_72(base.GetCppThis());
		}

		// Token: 0x0600909F RID: 37023
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_GetWindowLevel_73(HandleRef pThis, IntPtr wl);

		/// <summary>
		/// Set/Get the current window and level values.  SetWindowLevel should
		/// only be called after SetInput.  If a shared lookup table is being used,
		/// a callback is required to update the window level values without having
		/// to update the lookup table again.
		/// </summary>
		// Token: 0x060090A0 RID: 37024 RVA: 0x000CE0DF File Offset: 0x000CC2DF
		public void GetWindowLevel(IntPtr wl)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_GetWindowLevel_73(base.GetCppThis(), wl);
		}

		// Token: 0x060090A1 RID: 37025
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_InteractionOff_74(HandleRef pThis);

		/// <summary>
		/// Enable/disable mouse interaction so the widget remains on display.
		/// </summary>
		// Token: 0x060090A2 RID: 37026 RVA: 0x000CE0EF File Offset: 0x000CC2EF
		public virtual void InteractionOff()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_InteractionOff_74(base.GetCppThis());
		}

		// Token: 0x060090A3 RID: 37027
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_InteractionOn_75(HandleRef pThis);

		/// <summary>
		/// Enable/disable mouse interaction so the widget remains on display.
		/// </summary>
		// Token: 0x060090A4 RID: 37028 RVA: 0x000CE0FE File Offset: 0x000CC2FE
		public virtual void InteractionOn()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_InteractionOn_75(base.GetCppThis());
		}

		// Token: 0x060090A5 RID: 37029
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_IsA_76(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x060090A6 RID: 37030 RVA: 0x000CE110 File Offset: 0x000CC310
		public override int IsA(string type)
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_IsA_76(base.GetCppThis(), type);
		}

		// Token: 0x060090A7 RID: 37031
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePlaneWidget_IsTypeOf_77([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x060090A8 RID: 37032 RVA: 0x000CE130 File Offset: 0x000CC330
		public new static int IsTypeOf(string type)
		{
			return vtkImagePlaneWidget.vtkImagePlaneWidget_IsTypeOf_77(type);
		}

		// Token: 0x060090A9 RID: 37033
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePlaneWidget_NewInstance_79(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x060090AA RID: 37034 RVA: 0x000CE14C File Offset: 0x000CC34C
		public new vtkImagePlaneWidget NewInstance()
		{
			vtkImagePlaneWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_NewInstance_79(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImagePlaneWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060090AB RID: 37035
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_PlaceWidget_80(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x060090AC RID: 37036 RVA: 0x000CE1A6 File Offset: 0x000CC3A6
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_PlaceWidget_80(base.GetCppThis(), bounds);
		}

		// Token: 0x060090AD RID: 37037
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_PlaceWidget_81(HandleRef pThis);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x060090AE RID: 37038 RVA: 0x000CE1B6 File Offset: 0x000CC3B6
		public override void PlaceWidget()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_PlaceWidget_81(base.GetCppThis());
		}

		// Token: 0x060090AF RID: 37039
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_PlaceWidget_82(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x060090B0 RID: 37040 RVA: 0x000CE1C5 File Offset: 0x000CC3C5
		public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_PlaceWidget_82(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		// Token: 0x060090B1 RID: 37041
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_RestrictPlaneToVolumeOff_83(HandleRef pThis);

		/// <summary>
		/// Make sure that the plane remains within the volume.
		/// Default is On.
		/// </summary>
		// Token: 0x060090B2 RID: 37042 RVA: 0x000CE1DD File Offset: 0x000CC3DD
		public virtual void RestrictPlaneToVolumeOff()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_RestrictPlaneToVolumeOff_83(base.GetCppThis());
		}

		// Token: 0x060090B3 RID: 37043
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_RestrictPlaneToVolumeOn_84(HandleRef pThis);

		/// <summary>
		/// Make sure that the plane remains within the volume.
		/// Default is On.
		/// </summary>
		// Token: 0x060090B4 RID: 37044 RVA: 0x000CE1EC File Offset: 0x000CC3EC
		public virtual void RestrictPlaneToVolumeOn()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_RestrictPlaneToVolumeOn_84(base.GetCppThis());
		}

		// Token: 0x060090B5 RID: 37045
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePlaneWidget_SafeDownCast_85(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x060090B6 RID: 37046 RVA: 0x000CE1FC File Offset: 0x000CC3FC
		public new static vtkImagePlaneWidget SafeDownCast(vtkObjectBase o)
		{
			vtkImagePlaneWidget vtkImagePlaneWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImagePlaneWidget.vtkImagePlaneWidget_SafeDownCast_85((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImagePlaneWidget = (vtkImagePlaneWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImagePlaneWidget.Register(null);
				}
			}
			return vtkImagePlaneWidget;
		}

		// Token: 0x060090B7 RID: 37047
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetColorMap_86(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Convenience method to get the vtkImageMapToColors filter used by this
		/// widget.  The user can properly render other transparent actors in a
		/// scene by calling the filter's SetOutputFormatToRGB and
		/// PassAlphaToOutputOff.
		/// </summary>
		// Token: 0x060090B8 RID: 37048 RVA: 0x000CE27C File Offset: 0x000CC47C
		public virtual void SetColorMap(vtkImageMapToColors arg0)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetColorMap_86(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060090B9 RID: 37049
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetCursorProperty_87(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the properties of the cross-hair cursor.
		/// </summary>
		// Token: 0x060090BA RID: 37050 RVA: 0x000CE2AC File Offset: 0x000CC4AC
		public virtual void SetCursorProperty(vtkProperty arg0)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetCursorProperty_87(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060090BB RID: 37051
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetDisplayText_88(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/disable text display of window-level, image coordinates and
		/// scalar values in a render window.
		/// </summary>
		// Token: 0x060090BC RID: 37052 RVA: 0x000CE2DB File Offset: 0x000CC4DB
		public virtual void SetDisplayText(int _arg)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetDisplayText_88(base.GetCppThis(), _arg);
		}

		// Token: 0x060090BD RID: 37053
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetEnabled_89(HandleRef pThis, int arg0);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x060090BE RID: 37054 RVA: 0x000CE2EB File Offset: 0x000CC4EB
		public override void SetEnabled(int arg0)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetEnabled_89(base.GetCppThis(), arg0);
		}

		// Token: 0x060090BF RID: 37055
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetInputConnection_90(HandleRef pThis, HandleRef aout);

		/// <summary>
		/// Set the vtkImageData* input for the vtkImageReslice.
		/// </summary>
		// Token: 0x060090C0 RID: 37056 RVA: 0x000CE2FC File Offset: 0x000CC4FC
		public override void SetInputConnection(vtkAlgorithmOutput aout)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetInputConnection_90(base.GetCppThis(), (aout == null) ? default(HandleRef) : aout.GetCppThis());
		}

		// Token: 0x060090C1 RID: 37057
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetInteraction_91(HandleRef pThis, int interact);

		/// <summary>
		/// Enable/disable mouse interaction so the widget remains on display.
		/// </summary>
		// Token: 0x060090C2 RID: 37058 RVA: 0x000CE32B File Offset: 0x000CC52B
		public void SetInteraction(int interact)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetInteraction_91(base.GetCppThis(), interact);
		}

		// Token: 0x060090C3 RID: 37059
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetLeftButtonAction_92(HandleRef pThis, int _arg);

		/// <summary>
		/// Set action associated to buttons.
		/// </summary>
		// Token: 0x060090C4 RID: 37060 RVA: 0x000CE33B File Offset: 0x000CC53B
		public virtual void SetLeftButtonAction(int _arg)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetLeftButtonAction_92(base.GetCppThis(), _arg);
		}

		// Token: 0x060090C5 RID: 37061
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetLeftButtonAutoModifier_93(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the auto-modifiers associated to buttons.
		/// This allows users to bind some buttons to actions that are usually
		/// triggered by a key modifier. For example, if you do not need cursoring,
		/// you can bind the left button action to VTK_SLICE_MOTION_ACTION (see above)
		/// and the left button auto modifier to VTK_CONTROL_MODIFIER: you end up with
		/// the left button controlling panning without pressing a key.
		/// </summary>
		// Token: 0x060090C6 RID: 37062 RVA: 0x000CE34B File Offset: 0x000CC54B
		public virtual void SetLeftButtonAutoModifier(int _arg)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetLeftButtonAutoModifier_93(base.GetCppThis(), _arg);
		}

		// Token: 0x060090C7 RID: 37063
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetLookupTable_94(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the internal lookuptable (lut) to one defined by the user, or,
		/// alternatively, to the lut of another vtkImgePlaneWidget.  In this way,
		/// a set of three orthogonal planes can share the same lut so that
		/// window-levelling is performed uniformly among planes.  The default
		/// internal lut can be re- set/allocated by setting to 0 (nullptr).
		/// </summary>
		// Token: 0x060090C8 RID: 37064 RVA: 0x000CE35C File Offset: 0x000CC55C
		public virtual void SetLookupTable(vtkLookupTable arg0)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetLookupTable_94(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060090C9 RID: 37065
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetMarginProperty_95(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the properties of the margins.
		/// </summary>
		// Token: 0x060090CA RID: 37066 RVA: 0x000CE38C File Offset: 0x000CC58C
		public virtual void SetMarginProperty(vtkProperty arg0)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetMarginProperty_95(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060090CB RID: 37067
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetMarginSizeX_96(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the size of the margins based on a percentage of the
		/// plane's width and height, limited between 0 and 50%.
		/// </summary>
		// Token: 0x060090CC RID: 37068 RVA: 0x000CE3BB File Offset: 0x000CC5BB
		public virtual void SetMarginSizeX(double _arg)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetMarginSizeX_96(base.GetCppThis(), _arg);
		}

		// Token: 0x060090CD RID: 37069
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetMarginSizeY_97(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the size of the margins based on a percentage of the
		/// plane's width and height, limited between 0 and 50%.
		/// </summary>
		// Token: 0x060090CE RID: 37070 RVA: 0x000CE3CB File Offset: 0x000CC5CB
		public virtual void SetMarginSizeY(double _arg)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetMarginSizeY_97(base.GetCppThis(), _arg);
		}

		// Token: 0x060090CF RID: 37071
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetMiddleButtonAction_98(HandleRef pThis, int _arg);

		/// <summary>
		/// Set action associated to buttons.
		/// </summary>
		// Token: 0x060090D0 RID: 37072 RVA: 0x000CE3DB File Offset: 0x000CC5DB
		public virtual void SetMiddleButtonAction(int _arg)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetMiddleButtonAction_98(base.GetCppThis(), _arg);
		}

		// Token: 0x060090D1 RID: 37073
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetMiddleButtonAutoModifier_99(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the auto-modifiers associated to buttons.
		/// This allows users to bind some buttons to actions that are usually
		/// triggered by a key modifier. For example, if you do not need cursoring,
		/// you can bind the left button action to VTK_SLICE_MOTION_ACTION (see above)
		/// and the left button auto modifier to VTK_CONTROL_MODIFIER: you end up with
		/// the left button controlling panning without pressing a key.
		/// </summary>
		// Token: 0x060090D2 RID: 37074 RVA: 0x000CE3EB File Offset: 0x000CC5EB
		public virtual void SetMiddleButtonAutoModifier(int _arg)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetMiddleButtonAutoModifier_99(base.GetCppThis(), _arg);
		}

		// Token: 0x060090D3 RID: 37075
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetOrigin_100(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set/Get the origin of the plane.
		/// </summary>
		// Token: 0x060090D4 RID: 37076 RVA: 0x000CE3FB File Offset: 0x000CC5FB
		public void SetOrigin(double x, double y, double z)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetOrigin_100(base.GetCppThis(), x, y, z);
		}

		// Token: 0x060090D5 RID: 37077
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetOrigin_101(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// Set/Get the origin of the plane.
		/// </summary>
		// Token: 0x060090D6 RID: 37078 RVA: 0x000CE40D File Offset: 0x000CC60D
		public void SetOrigin(IntPtr xyz)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetOrigin_101(base.GetCppThis(), xyz);
		}

		// Token: 0x060090D7 RID: 37079
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetPicker_102(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the internal picker to one defined by the user.  In this way,
		/// a set of three orthogonal planes can share the same picker so that
		/// picking is performed correctly.  The default internal picker can be
		/// re-set/allocated by setting to 0 (nullptr).
		/// </summary>
		// Token: 0x060090D8 RID: 37080 RVA: 0x000CE420 File Offset: 0x000CC620
		public void SetPicker(vtkAbstractPropPicker arg0)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetPicker_102(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060090D9 RID: 37081
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetPlaneOrientation_103(HandleRef pThis, int arg0);

		/// <summary>
		/// Convenience method sets the plane orientation normal to the
		/// x, y, or z axes.  Default is XAxes (0).
		/// </summary>
		// Token: 0x060090DA RID: 37082 RVA: 0x000CE44F File Offset: 0x000CC64F
		public void SetPlaneOrientation(int arg0)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetPlaneOrientation_103(base.GetCppThis(), arg0);
		}

		// Token: 0x060090DB RID: 37083
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetPlaneOrientationToXAxes_104(HandleRef pThis);

		/// <summary>
		/// Convenience method sets the plane orientation normal to the
		/// x, y, or z axes.  Default is XAxes (0).
		/// </summary>
		// Token: 0x060090DC RID: 37084 RVA: 0x000CE45F File Offset: 0x000CC65F
		public void SetPlaneOrientationToXAxes()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetPlaneOrientationToXAxes_104(base.GetCppThis());
		}

		// Token: 0x060090DD RID: 37085
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetPlaneOrientationToYAxes_105(HandleRef pThis);

		/// <summary>
		/// Convenience method sets the plane orientation normal to the
		/// x, y, or z axes.  Default is XAxes (0).
		/// </summary>
		// Token: 0x060090DE RID: 37086 RVA: 0x000CE46E File Offset: 0x000CC66E
		public void SetPlaneOrientationToYAxes()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetPlaneOrientationToYAxes_105(base.GetCppThis());
		}

		// Token: 0x060090DF RID: 37087
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetPlaneOrientationToZAxes_106(HandleRef pThis);

		/// <summary>
		/// Convenience method sets the plane orientation normal to the
		/// x, y, or z axes.  Default is XAxes (0).
		/// </summary>
		// Token: 0x060090E0 RID: 37088 RVA: 0x000CE47D File Offset: 0x000CC67D
		public void SetPlaneOrientationToZAxes()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetPlaneOrientationToZAxes_106(base.GetCppThis());
		}

		// Token: 0x060090E1 RID: 37089
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetPlaneProperty_107(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the plane's outline properties. The properties of the plane's
		/// outline when selected and unselected can be manipulated.
		/// </summary>
		// Token: 0x060090E2 RID: 37090 RVA: 0x000CE48C File Offset: 0x000CC68C
		public virtual void SetPlaneProperty(vtkProperty arg0)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetPlaneProperty_107(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060090E3 RID: 37091
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetPoint1_108(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set/Get the position of the point defining the first axis of the plane.
		/// </summary>
		// Token: 0x060090E4 RID: 37092 RVA: 0x000CE4BB File Offset: 0x000CC6BB
		public void SetPoint1(double x, double y, double z)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetPoint1_108(base.GetCppThis(), x, y, z);
		}

		// Token: 0x060090E5 RID: 37093
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetPoint1_109(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// Set/Get the position of the point defining the first axis of the plane.
		/// </summary>
		// Token: 0x060090E6 RID: 37094 RVA: 0x000CE4CD File Offset: 0x000CC6CD
		public void SetPoint1(IntPtr xyz)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetPoint1_109(base.GetCppThis(), xyz);
		}

		// Token: 0x060090E7 RID: 37095
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetPoint2_110(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set/Get the position of the point defining the second axis of the plane.
		/// </summary>
		// Token: 0x060090E8 RID: 37096 RVA: 0x000CE4DD File Offset: 0x000CC6DD
		public void SetPoint2(double x, double y, double z)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetPoint2_110(base.GetCppThis(), x, y, z);
		}

		// Token: 0x060090E9 RID: 37097
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetPoint2_111(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// Set/Get the position of the point defining the second axis of the plane.
		/// </summary>
		// Token: 0x060090EA RID: 37098 RVA: 0x000CE4EF File Offset: 0x000CC6EF
		public void SetPoint2(IntPtr xyz)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetPoint2_111(base.GetCppThis(), xyz);
		}

		// Token: 0x060090EB RID: 37099
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetResliceInterpolate_112(HandleRef pThis, int arg0);

		/// <summary>
		/// Set the interpolation to use when texturing the plane.
		/// </summary>
		// Token: 0x060090EC RID: 37100 RVA: 0x000CE4FF File Offset: 0x000CC6FF
		public void SetResliceInterpolate(int arg0)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetResliceInterpolate_112(base.GetCppThis(), arg0);
		}

		// Token: 0x060090ED RID: 37101
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetResliceInterpolateToCubic_113(HandleRef pThis);

		/// <summary>
		/// Set the interpolation to use when texturing the plane.
		/// </summary>
		// Token: 0x060090EE RID: 37102 RVA: 0x000CE50F File Offset: 0x000CC70F
		public void SetResliceInterpolateToCubic()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetResliceInterpolateToCubic_113(base.GetCppThis());
		}

		// Token: 0x060090EF RID: 37103
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetResliceInterpolateToLinear_114(HandleRef pThis);

		/// <summary>
		/// Set the interpolation to use when texturing the plane.
		/// </summary>
		// Token: 0x060090F0 RID: 37104 RVA: 0x000CE51E File Offset: 0x000CC71E
		public void SetResliceInterpolateToLinear()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetResliceInterpolateToLinear_114(base.GetCppThis());
		}

		// Token: 0x060090F1 RID: 37105
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetResliceInterpolateToNearestNeighbour_115(HandleRef pThis);

		/// <summary>
		/// Set the interpolation to use when texturing the plane.
		/// </summary>
		// Token: 0x060090F2 RID: 37106 RVA: 0x000CE52D File Offset: 0x000CC72D
		public void SetResliceInterpolateToNearestNeighbour()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetResliceInterpolateToNearestNeighbour_115(base.GetCppThis());
		}

		// Token: 0x060090F3 RID: 37107
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetRestrictPlaneToVolume_116(HandleRef pThis, int _arg);

		/// <summary>
		/// Make sure that the plane remains within the volume.
		/// Default is On.
		/// </summary>
		// Token: 0x060090F4 RID: 37108 RVA: 0x000CE53C File Offset: 0x000CC73C
		public virtual void SetRestrictPlaneToVolume(int _arg)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetRestrictPlaneToVolume_116(base.GetCppThis(), _arg);
		}

		// Token: 0x060090F5 RID: 37109
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetRightButtonAction_117(HandleRef pThis, int _arg);

		/// <summary>
		/// Set action associated to buttons.
		/// </summary>
		// Token: 0x060090F6 RID: 37110 RVA: 0x000CE54C File Offset: 0x000CC74C
		public virtual void SetRightButtonAction(int _arg)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetRightButtonAction_117(base.GetCppThis(), _arg);
		}

		// Token: 0x060090F7 RID: 37111
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetRightButtonAutoModifier_118(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the auto-modifiers associated to buttons.
		/// This allows users to bind some buttons to actions that are usually
		/// triggered by a key modifier. For example, if you do not need cursoring,
		/// you can bind the left button action to VTK_SLICE_MOTION_ACTION (see above)
		/// and the left button auto modifier to VTK_CONTROL_MODIFIER: you end up with
		/// the left button controlling panning without pressing a key.
		/// </summary>
		// Token: 0x060090F8 RID: 37112 RVA: 0x000CE55C File Offset: 0x000CC75C
		public virtual void SetRightButtonAutoModifier(int _arg)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetRightButtonAutoModifier_118(base.GetCppThis(), _arg);
		}

		// Token: 0x060090F9 RID: 37113
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetSelectedPlaneProperty_119(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the plane's outline properties. The properties of the plane's
		/// outline when selected and unselected can be manipulated.
		/// </summary>
		// Token: 0x060090FA RID: 37114 RVA: 0x000CE56C File Offset: 0x000CC76C
		public virtual void SetSelectedPlaneProperty(vtkProperty arg0)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetSelectedPlaneProperty_119(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060090FB RID: 37115
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetSliceIndex_120(HandleRef pThis, int index);

		/// <summary>
		/// Set the slice position in terms of the data extent.
		/// </summary>
		// Token: 0x060090FC RID: 37116 RVA: 0x000CE59B File Offset: 0x000CC79B
		public void SetSliceIndex(int index)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetSliceIndex_120(base.GetCppThis(), index);
		}

		// Token: 0x060090FD RID: 37117
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetSlicePosition_121(HandleRef pThis, double position);

		/// <summary>
		/// Set the position of the slice along its normal.
		/// </summary>
		// Token: 0x060090FE RID: 37118 RVA: 0x000CE5AB File Offset: 0x000CC7AB
		public void SetSlicePosition(double position)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetSlicePosition_121(base.GetCppThis(), position);
		}

		// Token: 0x060090FF RID: 37119
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetTextProperty_122(HandleRef pThis, HandleRef tprop);

		/// <summary>
		/// Set/Get the text property for the image data and window-level annotation.
		/// </summary>
		// Token: 0x06009100 RID: 37120 RVA: 0x000CE5BC File Offset: 0x000CC7BC
		public void SetTextProperty(vtkTextProperty tprop)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetTextProperty_122(base.GetCppThis(), (tprop == null) ? default(HandleRef) : tprop.GetCppThis());
		}

		// Token: 0x06009101 RID: 37121
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetTextureInterpolate_123(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether to interpolate the texture or not. When off, the
		/// reslice interpolation is nearest neighbour regardless of how the
		/// interpolation is set through the API. Set before setting the
		/// vtkImageData input. Default is On.
		/// </summary>
		// Token: 0x06009102 RID: 37122 RVA: 0x000CE5EB File Offset: 0x000CC7EB
		public virtual void SetTextureInterpolate(int _arg)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetTextureInterpolate_123(base.GetCppThis(), _arg);
		}

		// Token: 0x06009103 RID: 37123
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetTexturePlaneProperty_124(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the property for the resliced image.
		/// </summary>
		// Token: 0x06009104 RID: 37124 RVA: 0x000CE5FC File Offset: 0x000CC7FC
		public virtual void SetTexturePlaneProperty(vtkProperty arg0)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetTexturePlaneProperty_124(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009105 RID: 37125
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetTextureVisibility_125(HandleRef pThis, int arg0);

		/// <summary>
		/// Control the visibility of the actual texture mapped reformatted plane.
		/// in some cases you may only want the plane outline for example.
		/// </summary>
		// Token: 0x06009106 RID: 37126 RVA: 0x000CE62B File Offset: 0x000CC82B
		public virtual void SetTextureVisibility(int arg0)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetTextureVisibility_125(base.GetCppThis(), arg0);
		}

		// Token: 0x06009107 RID: 37127
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetUseContinuousCursor_126(HandleRef pThis, int _arg);

		/// <summary>
		/// Choose between voxel centered or continuous cursor probing.  With voxel
		/// centered probing, the cursor snaps to the nearest voxel and the reported
		/// cursor coordinates are extent based.  With continuous probing, voxel data
		/// is interpolated using vtkDataSetAttributes' InterpolatePoint method and
		/// the reported coordinates are 3D spatial continuous.
		/// </summary>
		// Token: 0x06009108 RID: 37128 RVA: 0x000CE63B File Offset: 0x000CC83B
		public virtual void SetUseContinuousCursor(int _arg)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetUseContinuousCursor_126(base.GetCppThis(), _arg);
		}

		// Token: 0x06009109 RID: 37129
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetUserControlledLookupTable_127(HandleRef pThis, int _arg);

		/// <summary>
		/// Let the user control the lookup table. NOTE: apply this method BEFORE
		/// applying the SetLookupTable method.
		/// Default is Off.
		/// </summary>
		// Token: 0x0600910A RID: 37130 RVA: 0x000CE64B File Offset: 0x000CC84B
		public virtual void SetUserControlledLookupTable(int _arg)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetUserControlledLookupTable_127(base.GetCppThis(), _arg);
		}

		// Token: 0x0600910B RID: 37131
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_SetWindowLevel_128(HandleRef pThis, double window, double level, int copy);

		/// <summary>
		/// Set/Get the current window and level values.  SetWindowLevel should
		/// only be called after SetInput.  If a shared lookup table is being used,
		/// a callback is required to update the window level values without having
		/// to update the lookup table again.
		/// </summary>
		// Token: 0x0600910C RID: 37132 RVA: 0x000CE65B File Offset: 0x000CC85B
		public void SetWindowLevel(double window, double level, int copy)
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_SetWindowLevel_128(base.GetCppThis(), window, level, copy);
		}

		// Token: 0x0600910D RID: 37133
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_TextureInterpolateOff_129(HandleRef pThis);

		/// <summary>
		/// Specify whether to interpolate the texture or not. When off, the
		/// reslice interpolation is nearest neighbour regardless of how the
		/// interpolation is set through the API. Set before setting the
		/// vtkImageData input. Default is On.
		/// </summary>
		// Token: 0x0600910E RID: 37134 RVA: 0x000CE66D File Offset: 0x000CC86D
		public virtual void TextureInterpolateOff()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_TextureInterpolateOff_129(base.GetCppThis());
		}

		// Token: 0x0600910F RID: 37135
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_TextureInterpolateOn_130(HandleRef pThis);

		/// <summary>
		/// Specify whether to interpolate the texture or not. When off, the
		/// reslice interpolation is nearest neighbour regardless of how the
		/// interpolation is set through the API. Set before setting the
		/// vtkImageData input. Default is On.
		/// </summary>
		// Token: 0x06009110 RID: 37136 RVA: 0x000CE67C File Offset: 0x000CC87C
		public virtual void TextureInterpolateOn()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_TextureInterpolateOn_130(base.GetCppThis());
		}

		// Token: 0x06009111 RID: 37137
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_TextureVisibilityOff_131(HandleRef pThis);

		/// <summary>
		/// Control the visibility of the actual texture mapped reformatted plane.
		/// in some cases you may only want the plane outline for example.
		/// </summary>
		// Token: 0x06009112 RID: 37138 RVA: 0x000CE68B File Offset: 0x000CC88B
		public virtual void TextureVisibilityOff()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_TextureVisibilityOff_131(base.GetCppThis());
		}

		// Token: 0x06009113 RID: 37139
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_TextureVisibilityOn_132(HandleRef pThis);

		/// <summary>
		/// Control the visibility of the actual texture mapped reformatted plane.
		/// in some cases you may only want the plane outline for example.
		/// </summary>
		// Token: 0x06009114 RID: 37140 RVA: 0x000CE69A File Offset: 0x000CC89A
		public virtual void TextureVisibilityOn()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_TextureVisibilityOn_132(base.GetCppThis());
		}

		// Token: 0x06009115 RID: 37141
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_UpdatePlacement_133(HandleRef pThis);

		/// <summary>
		/// Satisfies superclass API.  This will change the state of the widget to
		/// match changes that have been made to the underlying vtkPolyDataSource
		/// </summary>
		// Token: 0x06009116 RID: 37142 RVA: 0x000CE6A9 File Offset: 0x000CC8A9
		public override void UpdatePlacement()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_UpdatePlacement_133(base.GetCppThis());
		}

		// Token: 0x06009117 RID: 37143
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_UseContinuousCursorOff_134(HandleRef pThis);

		/// <summary>
		/// Choose between voxel centered or continuous cursor probing.  With voxel
		/// centered probing, the cursor snaps to the nearest voxel and the reported
		/// cursor coordinates are extent based.  With continuous probing, voxel data
		/// is interpolated using vtkDataSetAttributes' InterpolatePoint method and
		/// the reported coordinates are 3D spatial continuous.
		/// </summary>
		// Token: 0x06009118 RID: 37144 RVA: 0x000CE6B8 File Offset: 0x000CC8B8
		public virtual void UseContinuousCursorOff()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_UseContinuousCursorOff_134(base.GetCppThis());
		}

		// Token: 0x06009119 RID: 37145
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_UseContinuousCursorOn_135(HandleRef pThis);

		/// <summary>
		/// Choose between voxel centered or continuous cursor probing.  With voxel
		/// centered probing, the cursor snaps to the nearest voxel and the reported
		/// cursor coordinates are extent based.  With continuous probing, voxel data
		/// is interpolated using vtkDataSetAttributes' InterpolatePoint method and
		/// the reported coordinates are 3D spatial continuous.
		/// </summary>
		// Token: 0x0600911A RID: 37146 RVA: 0x000CE6C7 File Offset: 0x000CC8C7
		public virtual void UseContinuousCursorOn()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_UseContinuousCursorOn_135(base.GetCppThis());
		}

		// Token: 0x0600911B RID: 37147
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_UserControlledLookupTableOff_136(HandleRef pThis);

		/// <summary>
		/// Let the user control the lookup table. NOTE: apply this method BEFORE
		/// applying the SetLookupTable method.
		/// Default is Off.
		/// </summary>
		// Token: 0x0600911C RID: 37148 RVA: 0x000CE6D6 File Offset: 0x000CC8D6
		public virtual void UserControlledLookupTableOff()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_UserControlledLookupTableOff_136(base.GetCppThis());
		}

		// Token: 0x0600911D RID: 37149
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePlaneWidget_UserControlledLookupTableOn_137(HandleRef pThis);

		/// <summary>
		/// Let the user control the lookup table. NOTE: apply this method BEFORE
		/// applying the SetLookupTable method.
		/// Default is Off.
		/// </summary>
		// Token: 0x0600911E RID: 37150 RVA: 0x000CE6E5 File Offset: 0x000CC8E5
		public virtual void UserControlledLookupTableOn()
		{
			vtkImagePlaneWidget.vtkImagePlaneWidget_UserControlledLookupTableOn_137(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C0A RID: 3082
		public new const string MRFullTypeName = "Kitware.VTK.vtkImagePlaneWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C0B RID: 3083
		public new static readonly string MRClassNameKey = "class vtkImagePlaneWidget";

		/// <summary>
		/// Set action associated to buttons.
		/// </summary>
		// Token: 0x02000327 RID: 807
		public enum VTK_CURSOR_ACTION_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000C0D RID: 3085
			VTK_CURSOR_ACTION,
			/// <summary>enum member</summary>
			// Token: 0x04000C0E RID: 3086
			VTK_SLICE_MOTION_ACTION,
			/// <summary>enum member</summary>
			// Token: 0x04000C0F RID: 3087
			VTK_WINDOW_LEVEL_ACTION
		}

		/// <summary>
		/// Set the auto-modifiers associated to buttons.
		/// This allows users to bind some buttons to actions that are usually
		/// triggered by a key modifier. For example, if you do not need cursoring,
		/// you can bind the left button action to VTK_SLICE_MOTION_ACTION (see above)
		/// and the left button auto modifier to VTK_CONTROL_MODIFIER: you end up with
		/// the left button controlling panning without pressing a key.
		/// </summary>
		// Token: 0x02000328 RID: 808
		public enum VTK_CONTROL_MODIFIER_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000C11 RID: 3089
			VTK_CONTROL_MODIFIER = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000C12 RID: 3090
			VTK_NO_MODIFIER = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000C13 RID: 3091
			VTK_SHIFT_MODIFIER
		}
	}
}
