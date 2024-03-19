using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBrokenLineWidget
	/// </summary>
	/// <remarks>
	///    3D widget for manipulating a broken line
	///
	/// This 3D widget defines a broken line that can be interactively placed in a
	/// scene. The broken line has handles, the number of which can be changed, plus it
	/// can be picked on the broken line itself to translate or rotate it in the scene.
	/// A nice feature of the object is that the vtkBrokenLineWidget, like any 3D
	/// widget, will work with the current interactor style. That is, if
	/// vtkBrokenLineWidget does not handle an event, then all other registered
	/// observers (including the interactor style) have an opportunity to process
	/// the event. Otherwise, the vtkBrokenLineWidget will terminate the processing of
	/// the event that it handles.
	///
	/// To use this object, just invoke SetInteractor() with the argument of the
	/// method a vtkRenderWindowInteractor.  You may also wish to invoke
	/// "PlaceWidget()" to initially position the widget. The interactor will act
	/// normally until the "i" key (for "interactor") is pressed, at which point the
	/// vtkBrokenLineWidget will appear. (See superclass documentation for information
	/// about changing this behavior.) Events that occur outside of the widget
	/// (i.e., no part of the widget is picked) are propagated to any other
	/// registered obsevers (such as the interaction style).  Turn off the widget
	/// by pressing the "i" key again (or invoke the Off() method).
	///
	/// The button actions and key modifiers are as follows for controlling the
	/// widget:
	/// 1) left button down on and drag one of the spherical handles to change the
	/// shape of the broken line: the handles act as "control points".
	/// 2) left button or middle button down on a line segment forming the broken line
	/// allows uniform translation of the widget.
	/// 3) ctrl + middle button down on the widget enables spinning of the widget
	/// about its center.
	/// 4) right button down on the widget enables scaling of the widget. By moving
	/// the mouse "up" the render window the broken line will be made bigger; by moving
	/// "down" the render window the widget will be made smaller.
	/// 5) ctrl key + right button down on any handle will erase it providing there
	/// will be two or more points remaining to form a broken line.
	/// 6) shift key + right button down on any line segment will insert a handle
	/// onto the broken line at the cursor position.
	///
	/// The vtkBrokenLineWidget has several methods that can be used in conjunction with
	/// other VTK objects. The GetPolyData() method can be used to get the
	/// polygonal representation and can be used for things like seeding
	/// streamlines or probing other data sets. Typical usage of the widget is to
	/// make use of the StartInteractionEvent, InteractionEvent, and
	/// EndInteractionEvent events. The InteractionEvent is called on mouse motion;
	/// the other two events are called on button down and button up (either left or
	/// right button).
	///
	/// Some additional features of this class include the ability to control the
	/// properties of the widget. You can set the properties of the selected and
	/// unselected representations of the broken line. For example, you can set the
	/// property for the handles and broken line. In addition there are methods to
	/// constrain the broken line so that it is aligned with a plane.  Note that a simple
	/// ruler widget can be derived by setting the resolution to 1, the number of
	/// handles to 2, and calling the GetSummedLength method!
	///
	/// @par Thanks:
	/// This class was written by Philippe Pebay, Kitware SAS 2012
	/// This work was supported by CEA/DIF - Commissariat a l'Energie Atomique,
	/// Centre DAM Ile-De-France, BP12, F-91297 Arpajon, France.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtk3DWidget vtkBoxWidget vtkLineWidget vtkPointWidget vtkSphereWidget
	/// vtkImagePlaneWidget vtkImplicitPlaneWidget vtkPlaneWidget
	/// </seealso>
	// Token: 0x020002DA RID: 730
	public class vtkBrokenLineWidget : vtk3DWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008395 RID: 33685 RVA: 0x000BC141 File Offset: 0x000BA341
		static vtkBrokenLineWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBrokenLineWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBrokenLineWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008396 RID: 33686 RVA: 0x000BC169 File Offset: 0x000BA369
		public vtkBrokenLineWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008397 RID: 33687
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBrokenLineWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06008398 RID: 33688 RVA: 0x000BC178 File Offset: 0x000BA378
		public new static vtkBrokenLineWidget New()
		{
			vtkBrokenLineWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBrokenLineWidget.vtkBrokenLineWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBrokenLineWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06008399 RID: 33689 RVA: 0x000BC1CC File Offset: 0x000BA3CC
		public vtkBrokenLineWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBrokenLineWidget.vtkBrokenLineWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600839A RID: 33690 RVA: 0x000BC210 File Offset: 0x000BA410
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600839B RID: 33691
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrokenLineWidget_GetHandlePosition_01(HandleRef pThis, int handle, IntPtr xyz);

		/// <summary>
		/// Set/Get the position of the broken line handles. Call GetNumberOfHandles
		/// to determine the valid range of handle indices.
		/// </summary>
		// Token: 0x0600839C RID: 33692 RVA: 0x000BC21B File Offset: 0x000BA41B
		public void GetHandlePosition(int handle, IntPtr xyz)
		{
			vtkBrokenLineWidget.vtkBrokenLineWidget_GetHandlePosition_01(base.GetCppThis(), handle, xyz);
		}

		// Token: 0x0600839D RID: 33693
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBrokenLineWidget_GetHandlePosition_02(HandleRef pThis, int handle);

		/// <summary>
		/// Set/Get the position of the broken line handles. Call GetNumberOfHandles
		/// to determine the valid range of handle indices.
		/// </summary>
		// Token: 0x0600839E RID: 33694 RVA: 0x000BC22C File Offset: 0x000BA42C
		public IntPtr GetHandlePosition(int handle)
		{
			return vtkBrokenLineWidget.vtkBrokenLineWidget_GetHandlePosition_02(base.GetCppThis(), handle);
		}

		// Token: 0x0600839F RID: 33695
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBrokenLineWidget_GetHandleProperty_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the handle properties (the spheres are the handles). The
		/// properties of the handles when selected and unselected can be manipulated.
		/// </summary>
		// Token: 0x060083A0 RID: 33696 RVA: 0x000BC24C File Offset: 0x000BA44C
		public virtual vtkProperty GetHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBrokenLineWidget.vtkBrokenLineWidget_GetHandleProperty_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060083A1 RID: 33697
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBrokenLineWidget_GetHandleSizeFactor_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the size factor to be applied to the handle radii.
		/// Default: 1.
		/// </summary>
		// Token: 0x060083A2 RID: 33698 RVA: 0x000BC2BC File Offset: 0x000BA4BC
		public virtual double GetHandleSizeFactor()
		{
			return vtkBrokenLineWidget.vtkBrokenLineWidget_GetHandleSizeFactor_04(base.GetCppThis());
		}

		// Token: 0x060083A3 RID: 33699
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBrokenLineWidget_GetHandleSizeFactorMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the size factor to be applied to the handle radii.
		/// Default: 1.
		/// </summary>
		// Token: 0x060083A4 RID: 33700 RVA: 0x000BC2DC File Offset: 0x000BA4DC
		public virtual double GetHandleSizeFactorMaxValue()
		{
			return vtkBrokenLineWidget.vtkBrokenLineWidget_GetHandleSizeFactorMaxValue_05(base.GetCppThis());
		}

		// Token: 0x060083A5 RID: 33701
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBrokenLineWidget_GetHandleSizeFactorMinValue_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the size factor to be applied to the handle radii.
		/// Default: 1.
		/// </summary>
		// Token: 0x060083A6 RID: 33702 RVA: 0x000BC2FC File Offset: 0x000BA4FC
		public virtual double GetHandleSizeFactorMinValue()
		{
			return vtkBrokenLineWidget.vtkBrokenLineWidget_GetHandleSizeFactorMinValue_06(base.GetCppThis());
		}

		// Token: 0x060083A7 RID: 33703
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBrokenLineWidget_GetLineProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the line properties. The properties of the line when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x060083A8 RID: 33704 RVA: 0x000BC31C File Offset: 0x000BA51C
		public virtual vtkProperty GetLineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBrokenLineWidget.vtkBrokenLineWidget_GetLineProperty_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060083A9 RID: 33705
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBrokenLineWidget_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x060083AA RID: 33706 RVA: 0x000BC38C File Offset: 0x000BA58C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBrokenLineWidget.vtkBrokenLineWidget_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x060083AB RID: 33707
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBrokenLineWidget_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x060083AC RID: 33708 RVA: 0x000BC3AC File Offset: 0x000BA5AC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBrokenLineWidget.vtkBrokenLineWidget_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x060083AD RID: 33709
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBrokenLineWidget_GetNumberOfHandles_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of handles for this widget.
		/// </summary>
		// Token: 0x060083AE RID: 33710 RVA: 0x000BC3C8 File Offset: 0x000BA5C8
		public virtual int GetNumberOfHandles()
		{
			return vtkBrokenLineWidget.vtkBrokenLineWidget_GetNumberOfHandles_10(base.GetCppThis());
		}

		// Token: 0x060083AF RID: 33711
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrokenLineWidget_GetPolyData_11(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Grab the polydata (including points) that defines the broken line.  The
		/// polydata consists of points and line segments numbering nHandles
		/// and nHandles - 1, respectively. Points are guaranteed to be up-to-date when
		/// either the InteractionEvent or EndInteraction events are invoked. The
		/// user provides the vtkPolyData and the points and polyline are added to it.
		/// </summary>
		// Token: 0x060083B0 RID: 33712 RVA: 0x000BC3E8 File Offset: 0x000BA5E8
		public void GetPolyData(vtkPolyData pd)
		{
			vtkBrokenLineWidget.vtkBrokenLineWidget_GetPolyData_11(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x060083B1 RID: 33713
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBrokenLineWidget_GetProcessEvents_12(HandleRef pThis);

		/// <summary>
		/// Turn on / off event processing for this widget. If off, the widget will
		/// not respond to user interaction
		/// </summary>
		// Token: 0x060083B2 RID: 33714 RVA: 0x000BC418 File Offset: 0x000BA618
		public virtual int GetProcessEvents()
		{
			return vtkBrokenLineWidget.vtkBrokenLineWidget_GetProcessEvents_12(base.GetCppThis());
		}

		// Token: 0x060083B3 RID: 33715
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBrokenLineWidget_GetProcessEventsMaxValue_13(HandleRef pThis);

		/// <summary>
		/// Turn on / off event processing for this widget. If off, the widget will
		/// not respond to user interaction
		/// </summary>
		// Token: 0x060083B4 RID: 33716 RVA: 0x000BC438 File Offset: 0x000BA638
		public virtual int GetProcessEventsMaxValue()
		{
			return vtkBrokenLineWidget.vtkBrokenLineWidget_GetProcessEventsMaxValue_13(base.GetCppThis());
		}

		// Token: 0x060083B5 RID: 33717
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBrokenLineWidget_GetProcessEventsMinValue_14(HandleRef pThis);

		/// <summary>
		/// Turn on / off event processing for this widget. If off, the widget will
		/// not respond to user interaction
		/// </summary>
		// Token: 0x060083B6 RID: 33718 RVA: 0x000BC458 File Offset: 0x000BA658
		public virtual int GetProcessEventsMinValue()
		{
			return vtkBrokenLineWidget.vtkBrokenLineWidget_GetProcessEventsMinValue_14(base.GetCppThis());
		}

		// Token: 0x060083B7 RID: 33719
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBrokenLineWidget_GetProjectToPlane_15(HandleRef pThis);

		/// <summary>
		/// Force the broken line widget to be projected onto one of the orthogonal planes.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the broken line to the plane if it is originally
		/// not aligned.  The normal in SetProjectionNormal is 0,1,2 for YZ,XZ,XY
		/// planes respectively and 3 for arbitrary oblique planes when the widget
		/// is tied to a vtkPlaneSource.
		/// </summary>
		// Token: 0x060083B8 RID: 33720 RVA: 0x000BC478 File Offset: 0x000BA678
		public virtual int GetProjectToPlane()
		{
			return vtkBrokenLineWidget.vtkBrokenLineWidget_GetProjectToPlane_15(base.GetCppThis());
		}

		// Token: 0x060083B9 RID: 33721
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBrokenLineWidget_GetProjectionNormal_16(HandleRef pThis);

		/// <summary>
		/// Set up a reference to a vtkPlaneSource that could be from another widget
		/// object, e.g. a vtkPolyDataSourceWidget.
		/// </summary>
		// Token: 0x060083BA RID: 33722 RVA: 0x000BC498 File Offset: 0x000BA698
		public virtual int GetProjectionNormal()
		{
			return vtkBrokenLineWidget.vtkBrokenLineWidget_GetProjectionNormal_16(base.GetCppThis());
		}

		// Token: 0x060083BB RID: 33723
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBrokenLineWidget_GetProjectionNormalMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Set up a reference to a vtkPlaneSource that could be from another widget
		/// object, e.g. a vtkPolyDataSourceWidget.
		/// </summary>
		// Token: 0x060083BC RID: 33724 RVA: 0x000BC4B8 File Offset: 0x000BA6B8
		public virtual int GetProjectionNormalMaxValue()
		{
			return vtkBrokenLineWidget.vtkBrokenLineWidget_GetProjectionNormalMaxValue_17(base.GetCppThis());
		}

		// Token: 0x060083BD RID: 33725
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBrokenLineWidget_GetProjectionNormalMinValue_18(HandleRef pThis);

		/// <summary>
		/// Set up a reference to a vtkPlaneSource that could be from another widget
		/// object, e.g. a vtkPolyDataSourceWidget.
		/// </summary>
		// Token: 0x060083BE RID: 33726 RVA: 0x000BC4D8 File Offset: 0x000BA6D8
		public virtual int GetProjectionNormalMinValue()
		{
			return vtkBrokenLineWidget.vtkBrokenLineWidget_GetProjectionNormalMinValue_18(base.GetCppThis());
		}

		// Token: 0x060083BF RID: 33727
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBrokenLineWidget_GetProjectionPosition_19(HandleRef pThis);

		/// <summary>
		/// Set the position of broken line handles and points in terms of a plane's
		/// position. i.e., if ProjectionNormal is 0, all of the x-coordinate
		/// values of the points are set to position. Any value can be passed (and is
		/// ignored) to update the broken line points when Projection normal is set to 3
		/// for arbitrary plane orientations.
		/// </summary>
		// Token: 0x060083C0 RID: 33728 RVA: 0x000BC4F8 File Offset: 0x000BA6F8
		public virtual double GetProjectionPosition()
		{
			return vtkBrokenLineWidget.vtkBrokenLineWidget_GetProjectionPosition_19(base.GetCppThis());
		}

		// Token: 0x060083C1 RID: 33729
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBrokenLineWidget_GetSelectedHandleProperty_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the handle properties (the spheres are the handles). The
		/// properties of the handles when selected and unselected can be manipulated.
		/// </summary>
		// Token: 0x060083C2 RID: 33730 RVA: 0x000BC518 File Offset: 0x000BA718
		public virtual vtkProperty GetSelectedHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBrokenLineWidget.vtkBrokenLineWidget_GetSelectedHandleProperty_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060083C3 RID: 33731
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBrokenLineWidget_GetSelectedLineProperty_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the line properties. The properties of the line when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x060083C4 RID: 33732 RVA: 0x000BC588 File Offset: 0x000BA788
		public virtual vtkProperty GetSelectedLineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBrokenLineWidget.vtkBrokenLineWidget_GetSelectedLineProperty_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060083C5 RID: 33733
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBrokenLineWidget_GetSummedLength_22(HandleRef pThis);

		/// <summary>
		/// Get the summed lengths of the individual straight line segments.
		/// </summary>
		// Token: 0x060083C6 RID: 33734 RVA: 0x000BC5F8 File Offset: 0x000BA7F8
		public double GetSummedLength()
		{
			return vtkBrokenLineWidget.vtkBrokenLineWidget_GetSummedLength_22(base.GetCppThis());
		}

		// Token: 0x060083C7 RID: 33735
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrokenLineWidget_InitializeHandles_23(HandleRef pThis, HandleRef points);

		/// <summary>
		/// Convenience method to allocate and set the handles from a vtkPoints
		/// instance.
		/// </summary>
		// Token: 0x060083C8 RID: 33736 RVA: 0x000BC618 File Offset: 0x000BA818
		public void InitializeHandles(vtkPoints points)
		{
			vtkBrokenLineWidget.vtkBrokenLineWidget_InitializeHandles_23(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		// Token: 0x060083C9 RID: 33737
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBrokenLineWidget_IsA_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x060083CA RID: 33738 RVA: 0x000BC648 File Offset: 0x000BA848
		public override int IsA(string type)
		{
			return vtkBrokenLineWidget.vtkBrokenLineWidget_IsA_24(base.GetCppThis(), type);
		}

		// Token: 0x060083CB RID: 33739
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBrokenLineWidget_IsTypeOf_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x060083CC RID: 33740 RVA: 0x000BC668 File Offset: 0x000BA868
		public new static int IsTypeOf(string type)
		{
			return vtkBrokenLineWidget.vtkBrokenLineWidget_IsTypeOf_25(type);
		}

		// Token: 0x060083CD RID: 33741
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBrokenLineWidget_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x060083CE RID: 33742 RVA: 0x000BC684 File Offset: 0x000BA884
		public new vtkBrokenLineWidget NewInstance()
		{
			vtkBrokenLineWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBrokenLineWidget.vtkBrokenLineWidget_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBrokenLineWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060083CF RID: 33743
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrokenLineWidget_PlaceWidget_28(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x060083D0 RID: 33744 RVA: 0x000BC6DE File Offset: 0x000BA8DE
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkBrokenLineWidget.vtkBrokenLineWidget_PlaceWidget_28(base.GetCppThis(), bounds);
		}

		// Token: 0x060083D1 RID: 33745
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrokenLineWidget_PlaceWidget_29(HandleRef pThis);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x060083D2 RID: 33746 RVA: 0x000BC6EE File Offset: 0x000BA8EE
		public override void PlaceWidget()
		{
			vtkBrokenLineWidget.vtkBrokenLineWidget_PlaceWidget_29(base.GetCppThis());
		}

		// Token: 0x060083D3 RID: 33747
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrokenLineWidget_PlaceWidget_30(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x060083D4 RID: 33748 RVA: 0x000BC6FD File Offset: 0x000BA8FD
		public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkBrokenLineWidget.vtkBrokenLineWidget_PlaceWidget_30(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		// Token: 0x060083D5 RID: 33749
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrokenLineWidget_ProcessEventsOff_31(HandleRef pThis);

		/// <summary>
		/// Turn on / off event processing for this widget. If off, the widget will
		/// not respond to user interaction
		/// </summary>
		// Token: 0x060083D6 RID: 33750 RVA: 0x000BC715 File Offset: 0x000BA915
		public virtual void ProcessEventsOff()
		{
			vtkBrokenLineWidget.vtkBrokenLineWidget_ProcessEventsOff_31(base.GetCppThis());
		}

		// Token: 0x060083D7 RID: 33751
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrokenLineWidget_ProcessEventsOn_32(HandleRef pThis);

		/// <summary>
		/// Turn on / off event processing for this widget. If off, the widget will
		/// not respond to user interaction
		/// </summary>
		// Token: 0x060083D8 RID: 33752 RVA: 0x000BC724 File Offset: 0x000BA924
		public virtual void ProcessEventsOn()
		{
			vtkBrokenLineWidget.vtkBrokenLineWidget_ProcessEventsOn_32(base.GetCppThis());
		}

		// Token: 0x060083D9 RID: 33753
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrokenLineWidget_ProjectToPlaneOff_33(HandleRef pThis);

		/// <summary>
		/// Force the broken line widget to be projected onto one of the orthogonal planes.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the broken line to the plane if it is originally
		/// not aligned.  The normal in SetProjectionNormal is 0,1,2 for YZ,XZ,XY
		/// planes respectively and 3 for arbitrary oblique planes when the widget
		/// is tied to a vtkPlaneSource.
		/// </summary>
		// Token: 0x060083DA RID: 33754 RVA: 0x000BC733 File Offset: 0x000BA933
		public virtual void ProjectToPlaneOff()
		{
			vtkBrokenLineWidget.vtkBrokenLineWidget_ProjectToPlaneOff_33(base.GetCppThis());
		}

		// Token: 0x060083DB RID: 33755
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrokenLineWidget_ProjectToPlaneOn_34(HandleRef pThis);

		/// <summary>
		/// Force the broken line widget to be projected onto one of the orthogonal planes.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the broken line to the plane if it is originally
		/// not aligned.  The normal in SetProjectionNormal is 0,1,2 for YZ,XZ,XY
		/// planes respectively and 3 for arbitrary oblique planes when the widget
		/// is tied to a vtkPlaneSource.
		/// </summary>
		// Token: 0x060083DC RID: 33756 RVA: 0x000BC742 File Offset: 0x000BA942
		public virtual void ProjectToPlaneOn()
		{
			vtkBrokenLineWidget.vtkBrokenLineWidget_ProjectToPlaneOn_34(base.GetCppThis());
		}

		// Token: 0x060083DD RID: 33757
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBrokenLineWidget_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x060083DE RID: 33758 RVA: 0x000BC754 File Offset: 0x000BA954
		public new static vtkBrokenLineWidget SafeDownCast(vtkObjectBase o)
		{
			vtkBrokenLineWidget vtkBrokenLineWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBrokenLineWidget.vtkBrokenLineWidget_SafeDownCast_35((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBrokenLineWidget = (vtkBrokenLineWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBrokenLineWidget.Register(null);
				}
			}
			return vtkBrokenLineWidget;
		}

		// Token: 0x060083DF RID: 33759
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrokenLineWidget_SetEnabled_36(HandleRef pThis, int arg0);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x060083E0 RID: 33760 RVA: 0x000BC7D3 File Offset: 0x000BA9D3
		public override void SetEnabled(int arg0)
		{
			vtkBrokenLineWidget.vtkBrokenLineWidget_SetEnabled_36(base.GetCppThis(), arg0);
		}

		// Token: 0x060083E1 RID: 33761
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrokenLineWidget_SetHandlePosition_37(HandleRef pThis, int handle, double x, double y, double z);

		/// <summary>
		/// Set/Get the position of the broken line handles. Call GetNumberOfHandles
		/// to determine the valid range of handle indices.
		/// </summary>
		// Token: 0x060083E2 RID: 33762 RVA: 0x000BC7E3 File Offset: 0x000BA9E3
		public void SetHandlePosition(int handle, double x, double y, double z)
		{
			vtkBrokenLineWidget.vtkBrokenLineWidget_SetHandlePosition_37(base.GetCppThis(), handle, x, y, z);
		}

		// Token: 0x060083E3 RID: 33763
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrokenLineWidget_SetHandlePosition_38(HandleRef pThis, int handle, IntPtr xyz);

		/// <summary>
		/// Set/Get the position of the broken line handles. Call GetNumberOfHandles
		/// to determine the valid range of handle indices.
		/// </summary>
		// Token: 0x060083E4 RID: 33764 RVA: 0x000BC7F7 File Offset: 0x000BA9F7
		public void SetHandlePosition(int handle, IntPtr xyz)
		{
			vtkBrokenLineWidget.vtkBrokenLineWidget_SetHandlePosition_38(base.GetCppThis(), handle, xyz);
		}

		// Token: 0x060083E5 RID: 33765
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrokenLineWidget_SetHandleProperty_39(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the handle properties (the spheres are the handles). The
		/// properties of the handles when selected and unselected can be manipulated.
		/// </summary>
		// Token: 0x060083E6 RID: 33766 RVA: 0x000BC808 File Offset: 0x000BAA08
		public virtual void SetHandleProperty(vtkProperty arg0)
		{
			vtkBrokenLineWidget.vtkBrokenLineWidget_SetHandleProperty_39(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060083E7 RID: 33767
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrokenLineWidget_SetHandleSizeFactor_40(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the size factor to be applied to the handle radii.
		/// Default: 1.
		/// </summary>
		// Token: 0x060083E8 RID: 33768 RVA: 0x000BC837 File Offset: 0x000BAA37
		public virtual void SetHandleSizeFactor(double _arg)
		{
			vtkBrokenLineWidget.vtkBrokenLineWidget_SetHandleSizeFactor_40(base.GetCppThis(), _arg);
		}

		// Token: 0x060083E9 RID: 33769
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrokenLineWidget_SetLineProperty_41(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the line properties. The properties of the line when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x060083EA RID: 33770 RVA: 0x000BC848 File Offset: 0x000BAA48
		public virtual void SetLineProperty(vtkProperty arg0)
		{
			vtkBrokenLineWidget.vtkBrokenLineWidget_SetLineProperty_41(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060083EB RID: 33771
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrokenLineWidget_SetNumberOfHandles_42(HandleRef pThis, int npts);

		/// <summary>
		/// Set/Get the number of handles for this widget.
		/// </summary>
		// Token: 0x060083EC RID: 33772 RVA: 0x000BC877 File Offset: 0x000BAA77
		public virtual void SetNumberOfHandles(int npts)
		{
			vtkBrokenLineWidget.vtkBrokenLineWidget_SetNumberOfHandles_42(base.GetCppThis(), npts);
		}

		// Token: 0x060083ED RID: 33773
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrokenLineWidget_SetPlaneSource_43(HandleRef pThis, HandleRef plane);

		/// <summary>
		/// Set up a reference to a vtkPlaneSource that could be from another widget
		/// object, e.g. a vtkPolyDataSourceWidget.
		/// </summary>
		// Token: 0x060083EE RID: 33774 RVA: 0x000BC888 File Offset: 0x000BAA88
		public void SetPlaneSource(vtkPlaneSource plane)
		{
			vtkBrokenLineWidget.vtkBrokenLineWidget_SetPlaneSource_43(base.GetCppThis(), (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		// Token: 0x060083EF RID: 33775
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrokenLineWidget_SetProcessEvents_44(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on / off event processing for this widget. If off, the widget will
		/// not respond to user interaction
		/// </summary>
		// Token: 0x060083F0 RID: 33776 RVA: 0x000BC8B7 File Offset: 0x000BAAB7
		public virtual void SetProcessEvents(int _arg)
		{
			vtkBrokenLineWidget.vtkBrokenLineWidget_SetProcessEvents_44(base.GetCppThis(), _arg);
		}

		// Token: 0x060083F1 RID: 33777
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrokenLineWidget_SetProjectToPlane_45(HandleRef pThis, int _arg);

		/// <summary>
		/// Force the broken line widget to be projected onto one of the orthogonal planes.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the broken line to the plane if it is originally
		/// not aligned.  The normal in SetProjectionNormal is 0,1,2 for YZ,XZ,XY
		/// planes respectively and 3 for arbitrary oblique planes when the widget
		/// is tied to a vtkPlaneSource.
		/// </summary>
		// Token: 0x060083F2 RID: 33778 RVA: 0x000BC8C7 File Offset: 0x000BAAC7
		public virtual void SetProjectToPlane(int _arg)
		{
			vtkBrokenLineWidget.vtkBrokenLineWidget_SetProjectToPlane_45(base.GetCppThis(), _arg);
		}

		// Token: 0x060083F3 RID: 33779
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrokenLineWidget_SetProjectionNormal_46(HandleRef pThis, int _arg);

		/// <summary>
		/// Set up a reference to a vtkPlaneSource that could be from another widget
		/// object, e.g. a vtkPolyDataSourceWidget.
		/// </summary>
		// Token: 0x060083F4 RID: 33780 RVA: 0x000BC8D7 File Offset: 0x000BAAD7
		public virtual void SetProjectionNormal(int _arg)
		{
			vtkBrokenLineWidget.vtkBrokenLineWidget_SetProjectionNormal_46(base.GetCppThis(), _arg);
		}

		// Token: 0x060083F5 RID: 33781
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrokenLineWidget_SetProjectionNormalToOblique_47(HandleRef pThis);

		/// <summary>
		/// Set up a reference to a vtkPlaneSource that could be from another widget
		/// object, e.g. a vtkPolyDataSourceWidget.
		/// </summary>
		// Token: 0x060083F6 RID: 33782 RVA: 0x000BC8E7 File Offset: 0x000BAAE7
		public void SetProjectionNormalToOblique()
		{
			vtkBrokenLineWidget.vtkBrokenLineWidget_SetProjectionNormalToOblique_47(base.GetCppThis());
		}

		// Token: 0x060083F7 RID: 33783
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrokenLineWidget_SetProjectionNormalToXAxes_48(HandleRef pThis);

		/// <summary>
		/// Set up a reference to a vtkPlaneSource that could be from another widget
		/// object, e.g. a vtkPolyDataSourceWidget.
		/// </summary>
		// Token: 0x060083F8 RID: 33784 RVA: 0x000BC8F6 File Offset: 0x000BAAF6
		public void SetProjectionNormalToXAxes()
		{
			vtkBrokenLineWidget.vtkBrokenLineWidget_SetProjectionNormalToXAxes_48(base.GetCppThis());
		}

		// Token: 0x060083F9 RID: 33785
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrokenLineWidget_SetProjectionNormalToYAxes_49(HandleRef pThis);

		/// <summary>
		/// Set up a reference to a vtkPlaneSource that could be from another widget
		/// object, e.g. a vtkPolyDataSourceWidget.
		/// </summary>
		// Token: 0x060083FA RID: 33786 RVA: 0x000BC905 File Offset: 0x000BAB05
		public void SetProjectionNormalToYAxes()
		{
			vtkBrokenLineWidget.vtkBrokenLineWidget_SetProjectionNormalToYAxes_49(base.GetCppThis());
		}

		// Token: 0x060083FB RID: 33787
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrokenLineWidget_SetProjectionNormalToZAxes_50(HandleRef pThis);

		/// <summary>
		/// Set up a reference to a vtkPlaneSource that could be from another widget
		/// object, e.g. a vtkPolyDataSourceWidget.
		/// </summary>
		// Token: 0x060083FC RID: 33788 RVA: 0x000BC914 File Offset: 0x000BAB14
		public void SetProjectionNormalToZAxes()
		{
			vtkBrokenLineWidget.vtkBrokenLineWidget_SetProjectionNormalToZAxes_50(base.GetCppThis());
		}

		// Token: 0x060083FD RID: 33789
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrokenLineWidget_SetProjectionPosition_51(HandleRef pThis, double position);

		/// <summary>
		/// Set the position of broken line handles and points in terms of a plane's
		/// position. i.e., if ProjectionNormal is 0, all of the x-coordinate
		/// values of the points are set to position. Any value can be passed (and is
		/// ignored) to update the broken line points when Projection normal is set to 3
		/// for arbitrary plane orientations.
		/// </summary>
		// Token: 0x060083FE RID: 33790 RVA: 0x000BC923 File Offset: 0x000BAB23
		public void SetProjectionPosition(double position)
		{
			vtkBrokenLineWidget.vtkBrokenLineWidget_SetProjectionPosition_51(base.GetCppThis(), position);
		}

		// Token: 0x060083FF RID: 33791
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrokenLineWidget_SetSelectedHandleProperty_52(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the handle properties (the spheres are the handles). The
		/// properties of the handles when selected and unselected can be manipulated.
		/// </summary>
		// Token: 0x06008400 RID: 33792 RVA: 0x000BC934 File Offset: 0x000BAB34
		public virtual void SetSelectedHandleProperty(vtkProperty arg0)
		{
			vtkBrokenLineWidget.vtkBrokenLineWidget_SetSelectedHandleProperty_52(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008401 RID: 33793
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBrokenLineWidget_SetSelectedLineProperty_53(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the line properties. The properties of the line when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06008402 RID: 33794 RVA: 0x000BC964 File Offset: 0x000BAB64
		public virtual void SetSelectedLineProperty(vtkProperty arg0)
		{
			vtkBrokenLineWidget.vtkBrokenLineWidget_SetSelectedLineProperty_53(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B27 RID: 2855
		public new const string MRFullTypeName = "Kitware.VTK.vtkBrokenLineWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B28 RID: 2856
		public new static readonly string MRClassNameKey = "class vtkBrokenLineWidget";
	}
}
