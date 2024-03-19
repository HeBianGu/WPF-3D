using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkContourWidget
	/// </summary>
	/// <remarks>
	///    create a contour with a set of points
	///
	/// The vtkContourWidget is used to select a set of points, and draw lines
	/// between these points. The contour may be opened or closed, depending on
	/// how the last point is added. The widget handles all processing of widget
	/// events (that are triggered by VTK events). The vtkContourRepresentation is
	/// responsible for all placement of the points, calculation of the lines, and
	/// contour manipulation. This is done through two main helper classes:
	/// vtkPointPlacer and vtkContourLineInterpolator. The representation is also
	/// responsible for drawing the points and lines.
	///
	/// @par Event Bindings:
	/// By default, the widget responds to the following VTK events (i.e., it
	/// watches the vtkRenderWindowInteractor for these events):
	/// &lt;pre&gt;
	///   LeftButtonPressEvent - triggers a Select event
	///   RightButtonPressEvent - triggers a AddFinalPoint event
	///   MouseMoveEvent - triggers a Move event
	///   LeftButtonReleaseEvent - triggers an EndSelect event
	///   Delete key event - triggers a Delete event
	///   Shift + Delete key event - triggers a Reset event
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// Note that the event bindings described above can be changed using this
	/// class's vtkWidgetEventTranslator. This class translates VTK events
	/// into the vtkContourWidget's widget events:
	/// &lt;pre&gt;
	///   vtkWidgetEvent::Select
	///        widget state is:
	///            Start or
	///            Define: If we already have at least 2 nodes, test
	///                 whether the current (X,Y) location is near an existing
	///                 node. If so, close the contour and change to Manipulate
	///                 state. Otherwise, attempt to add a node at this (X,Y)
	///                 location.
	///            Manipulate: If this (X,Y) location activates a node, then
	///                 set the current operation to Translate. Otherwise, if
	///                 this location is near the contour, attempt to add a
	///                 new node on the contour at this (X,Y) location.
	///
	/// @par Event Bindings:
	///   vtkWidgetEvent::AddFinalPoint
	///        widget state is:
	///            Start: Do nothing.
	///            Define: If we already have at least 2 nodes, test
	///                 whether the current (X,Y) location is near an existing
	///                 node. If so, close the contour and change to Manipulate
	///                 state. Otherwise, attempt to add a node at this (X,Y)
	///                 location. If we do, then leave the contour open and
	///                 change to Manipulate state.
	///            Manipulate: Do nothing.
	///
	/// @par Event Bindings:
	///   vtkWidgetEvent::Move
	///        widget state is:
	///            Start or
	///            Define: Do nothing.
	///            Manipulate: If our operation is Translate, then invoke
	///                  WidgetInteraction() on the representation. If our
	///                  operation is Inactive, then just attempt to activate
	///                  a node at this (X,Y) location.
	///
	/// @par Event Bindings:
	///   vtkWidgetEvent::EndSelect
	///        widget state is:
	///            Start or
	///            Define: Do nothing.
	///            Manipulate: If our operation is not Inactive, set it to
	///                  Inactive.
	///
	/// @par Event Bindings:
	///   vtkWidgetEvent::Delete
	///        widget state is:
	///            Start: Do nothing.
	///            Define: Remove the last point on the contour.
	///            Manipulate: Attempt to activate a node at (X,Y). If
	///                   we do activate a node, delete it. If we now
	///                   have less than 3 nodes, go back to Define state.
	///
	/// @par Event Bindings:
	///   vtkWidgetEvent::Reset
	///        widget state is:
	///            Start: Do nothing.
	///            Define: Remove all points and line segments of the contour.
	///                 Essentially calls Initialize(nullptr)
	///            Manipulate: Do nothing.
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// This widget invokes the following VTK events on itself (which observers
	/// can listen for):
	/// &lt;pre&gt;
	///   vtkCommand::StartInteractionEvent (beginning to interact)
	///   vtkCommand::EndInteractionEvent (completing interaction)
	///   vtkCommand::InteractionEvent (moving after selecting something)
	///   vtkCommand::PlacePointEvent (after point is positioned;
	///                                call data includes handle id (0,1))
	///   vtkCommand::WidgetValueChangedEvent (Invoked when the contour is closed
	///                                        for the first time. )
	/// &lt;/pre&gt;
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkHandleWidget
	/// </seealso>
	// Token: 0x02000303 RID: 771
	public class vtkContourWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060089E7 RID: 35303 RVA: 0x000C4DC3 File Offset: 0x000C2FC3
		static vtkContourWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContourWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContourWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060089E8 RID: 35304 RVA: 0x000C4DEB File Offset: 0x000C2FEB
		public vtkContourWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060089E9 RID: 35305
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x060089EA RID: 35306 RVA: 0x000C4DFC File Offset: 0x000C2FFC
		public new static vtkContourWidget New()
		{
			vtkContourWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContourWidget.vtkContourWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContourWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x060089EB RID: 35307 RVA: 0x000C4E50 File Offset: 0x000C3050
		public vtkContourWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkContourWidget.vtkContourWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060089EC RID: 35308 RVA: 0x000C4E94 File Offset: 0x000C3094
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060089ED RID: 35309
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourWidget_AllowNodePickingOff_01(HandleRef pThis);

		/// <summary>
		/// Set / Get the AllowNodePicking value. This ivar indicates whether the nodes
		/// and points between nodes can be picked/un-picked by Ctrl+Click on the node.
		/// </summary>
		// Token: 0x060089EE RID: 35310 RVA: 0x000C4E9F File Offset: 0x000C309F
		public virtual void AllowNodePickingOff()
		{
			vtkContourWidget.vtkContourWidget_AllowNodePickingOff_01(base.GetCppThis());
		}

		// Token: 0x060089EF RID: 35311
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourWidget_AllowNodePickingOn_02(HandleRef pThis);

		/// <summary>
		/// Set / Get the AllowNodePicking value. This ivar indicates whether the nodes
		/// and points between nodes can be picked/un-picked by Ctrl+Click on the node.
		/// </summary>
		// Token: 0x060089F0 RID: 35312 RVA: 0x000C4EAE File Offset: 0x000C30AE
		public virtual void AllowNodePickingOn()
		{
			vtkContourWidget.vtkContourWidget_AllowNodePickingOn_02(base.GetCppThis());
		}

		// Token: 0x060089F1 RID: 35313
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourWidget_CloseLoop_03(HandleRef pThis);

		/// <summary>
		/// Convenient method to close the contour loop.
		/// </summary>
		// Token: 0x060089F2 RID: 35314 RVA: 0x000C4EBD File Offset: 0x000C30BD
		public void CloseLoop()
		{
			vtkContourWidget.vtkContourWidget_CloseLoop_03(base.GetCppThis());
		}

		// Token: 0x060089F3 RID: 35315
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourWidget_ContinuousDrawOff_04(HandleRef pThis);

		/// <summary>
		/// Define a contour by continuously drawing with the mouse cursor.
		/// Press and hold the left mouse button down to continuously draw.
		/// Releasing the left mouse button switches into a snap drawing mode.
		/// Terminate the contour by pressing the right mouse button.  If you
		/// do not want to see the nodes as they are added to the contour, set the
		/// opacity to 0 of the representation's property.  If you do not want to
		/// see the last active node as it is being added, set the opacity to 0
		/// of the representation's active property.
		/// </summary>
		// Token: 0x060089F4 RID: 35316 RVA: 0x000C4ECC File Offset: 0x000C30CC
		public virtual void ContinuousDrawOff()
		{
			vtkContourWidget.vtkContourWidget_ContinuousDrawOff_04(base.GetCppThis());
		}

		// Token: 0x060089F5 RID: 35317
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourWidget_ContinuousDrawOn_05(HandleRef pThis);

		/// <summary>
		/// Define a contour by continuously drawing with the mouse cursor.
		/// Press and hold the left mouse button down to continuously draw.
		/// Releasing the left mouse button switches into a snap drawing mode.
		/// Terminate the contour by pressing the right mouse button.  If you
		/// do not want to see the nodes as they are added to the contour, set the
		/// opacity to 0 of the representation's property.  If you do not want to
		/// see the last active node as it is being added, set the opacity to 0
		/// of the representation's active property.
		/// </summary>
		// Token: 0x060089F6 RID: 35318 RVA: 0x000C4EDB File Offset: 0x000C30DB
		public virtual void ContinuousDrawOn()
		{
			vtkContourWidget.vtkContourWidget_ContinuousDrawOn_05(base.GetCppThis());
		}

		// Token: 0x060089F7 RID: 35319
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourWidget_CreateDefaultRepresentation_06(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x060089F8 RID: 35320 RVA: 0x000C4EEA File Offset: 0x000C30EA
		public override void CreateDefaultRepresentation()
		{
			vtkContourWidget.vtkContourWidget_CreateDefaultRepresentation_06(base.GetCppThis());
		}

		// Token: 0x060089F9 RID: 35321
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourWidget_FollowCursorOff_07(HandleRef pThis);

		/// <summary>
		/// Follow the cursor ? If this is ON, during definition, the last node of the
		/// contour will automatically follow the cursor, without waiting for the
		/// point to be dropped. This may be useful for some interpolators, such as the
		/// live-wire interpolator to see the shape of the contour that will be placed
		/// as you move the mouse cursor.
		/// </summary>
		// Token: 0x060089FA RID: 35322 RVA: 0x000C4EF9 File Offset: 0x000C30F9
		public virtual void FollowCursorOff()
		{
			vtkContourWidget.vtkContourWidget_FollowCursorOff_07(base.GetCppThis());
		}

		// Token: 0x060089FB RID: 35323
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourWidget_FollowCursorOn_08(HandleRef pThis);

		/// <summary>
		/// Follow the cursor ? If this is ON, during definition, the last node of the
		/// contour will automatically follow the cursor, without waiting for the
		/// point to be dropped. This may be useful for some interpolators, such as the
		/// live-wire interpolator to see the shape of the contour that will be placed
		/// as you move the mouse cursor.
		/// </summary>
		// Token: 0x060089FC RID: 35324 RVA: 0x000C4F08 File Offset: 0x000C3108
		public virtual void FollowCursorOn()
		{
			vtkContourWidget.vtkContourWidget_FollowCursorOn_08(base.GetCppThis());
		}

		// Token: 0x060089FD RID: 35325
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourWidget_GetAllowNodePicking_09(HandleRef pThis);

		/// <summary>
		/// Set / Get the AllowNodePicking value. This ivar indicates whether the nodes
		/// and points between nodes can be picked/un-picked by Ctrl+Click on the node.
		/// </summary>
		// Token: 0x060089FE RID: 35326 RVA: 0x000C4F18 File Offset: 0x000C3118
		public virtual int GetAllowNodePicking()
		{
			return vtkContourWidget.vtkContourWidget_GetAllowNodePicking_09(base.GetCppThis());
		}

		// Token: 0x060089FF RID: 35327
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourWidget_GetContinuousDraw_10(HandleRef pThis);

		/// <summary>
		/// Define a contour by continuously drawing with the mouse cursor.
		/// Press and hold the left mouse button down to continuously draw.
		/// Releasing the left mouse button switches into a snap drawing mode.
		/// Terminate the contour by pressing the right mouse button.  If you
		/// do not want to see the nodes as they are added to the contour, set the
		/// opacity to 0 of the representation's property.  If you do not want to
		/// see the last active node as it is being added, set the opacity to 0
		/// of the representation's active property.
		/// </summary>
		// Token: 0x06008A00 RID: 35328 RVA: 0x000C4F38 File Offset: 0x000C3138
		public virtual int GetContinuousDraw()
		{
			return vtkContourWidget.vtkContourWidget_GetContinuousDraw_10(base.GetCppThis());
		}

		// Token: 0x06008A01 RID: 35329
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourWidget_GetContourRepresentation_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the representation as a vtkContourRepresentation.
		/// </summary>
		// Token: 0x06008A02 RID: 35330 RVA: 0x000C4F58 File Offset: 0x000C3158
		public vtkContourRepresentation GetContourRepresentation()
		{
			vtkContourRepresentation vtkContourRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContourWidget.vtkContourWidget_GetContourRepresentation_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContourRepresentation = (vtkContourRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContourRepresentation.Register(null);
				}
			}
			return vtkContourRepresentation;
		}

		// Token: 0x06008A03 RID: 35331
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourWidget_GetFollowCursor_12(HandleRef pThis);

		/// <summary>
		/// Follow the cursor ? If this is ON, during definition, the last node of the
		/// contour will automatically follow the cursor, without waiting for the
		/// point to be dropped. This may be useful for some interpolators, such as the
		/// live-wire interpolator to see the shape of the contour that will be placed
		/// as you move the mouse cursor.
		/// </summary>
		// Token: 0x06008A04 RID: 35332 RVA: 0x000C4FC8 File Offset: 0x000C31C8
		public virtual int GetFollowCursor()
		{
			return vtkContourWidget.vtkContourWidget_GetFollowCursor_12(base.GetCppThis());
		}

		// Token: 0x06008A05 RID: 35333
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContourWidget_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x06008A06 RID: 35334 RVA: 0x000C4FE8 File Offset: 0x000C31E8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkContourWidget.vtkContourWidget_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x06008A07 RID: 35335
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContourWidget_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x06008A08 RID: 35336 RVA: 0x000C5008 File Offset: 0x000C3208
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkContourWidget.vtkContourWidget_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x06008A09 RID: 35337
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourWidget_GetWidgetState_15(HandleRef pThis);

		/// <summary>
		/// Convenient method to determine the state of the method
		/// </summary>
		// Token: 0x06008A0A RID: 35338 RVA: 0x000C5024 File Offset: 0x000C3224
		public virtual int GetWidgetState()
		{
			return vtkContourWidget.vtkContourWidget_GetWidgetState_15(base.GetCppThis());
		}

		// Token: 0x06008A0B RID: 35339
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourWidget_Initialize_16(HandleRef pThis, HandleRef poly, int state, HandleRef idList);

		/// <summary>
		/// Initialize the contour widget from a user supplied set of points. The
		/// state of the widget decides if you are still defining the widget, or
		/// if you've finished defining (added the last point) are manipulating
		/// it. Note that if the polydata supplied is closed, the state will be
		/// set to manipulate.
		/// State: Define = 0, Manipulate = 1.
		/// </summary>
		// Token: 0x06008A0C RID: 35340 RVA: 0x000C5044 File Offset: 0x000C3244
		public virtual void Initialize(vtkPolyData poly, int state, vtkIdList idList)
		{
			vtkContourWidget.vtkContourWidget_Initialize_16(base.GetCppThis(), (poly == null) ? default(HandleRef) : poly.GetCppThis(), state, (idList == null) ? default(HandleRef) : idList.GetCppThis());
		}

		// Token: 0x06008A0D RID: 35341
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourWidget_Initialize_17(HandleRef pThis);

		/// <summary>
		/// Initialize the contour widget from a user supplied set of points. The
		/// state of the widget decides if you are still defining the widget, or
		/// if you've finished defining (added the last point) are manipulating
		/// it. Note that if the polydata supplied is closed, the state will be
		/// set to manipulate.
		/// State: Define = 0, Manipulate = 1.
		/// </summary>
		// Token: 0x06008A0E RID: 35342 RVA: 0x000C5089 File Offset: 0x000C3289
		public virtual void Initialize()
		{
			vtkContourWidget.vtkContourWidget_Initialize_17(base.GetCppThis());
		}

		// Token: 0x06008A0F RID: 35343
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourWidget_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x06008A10 RID: 35344 RVA: 0x000C5098 File Offset: 0x000C3298
		public override int IsA(string type)
		{
			return vtkContourWidget.vtkContourWidget_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x06008A11 RID: 35345
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourWidget_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x06008A12 RID: 35346 RVA: 0x000C50B8 File Offset: 0x000C32B8
		public new static int IsTypeOf(string type)
		{
			return vtkContourWidget.vtkContourWidget_IsTypeOf_19(type);
		}

		// Token: 0x06008A13 RID: 35347
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourWidget_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x06008A14 RID: 35348 RVA: 0x000C50D4 File Offset: 0x000C32D4
		public new vtkContourWidget NewInstance()
		{
			vtkContourWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContourWidget.vtkContourWidget_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContourWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008A15 RID: 35349
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourWidget_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x06008A16 RID: 35350 RVA: 0x000C5130 File Offset: 0x000C3330
		public new static vtkContourWidget SafeDownCast(vtkObjectBase o)
		{
			vtkContourWidget vtkContourWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContourWidget.vtkContourWidget_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContourWidget = (vtkContourWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContourWidget.Register(null);
				}
			}
			return vtkContourWidget;
		}

		// Token: 0x06008A17 RID: 35351
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourWidget_SetAllowNodePicking_23(HandleRef pThis, int arg0);

		/// <summary>
		/// Set / Get the AllowNodePicking value. This ivar indicates whether the nodes
		/// and points between nodes can be picked/un-picked by Ctrl+Click on the node.
		/// </summary>
		// Token: 0x06008A18 RID: 35352 RVA: 0x000C51AF File Offset: 0x000C33AF
		public void SetAllowNodePicking(int arg0)
		{
			vtkContourWidget.vtkContourWidget_SetAllowNodePicking_23(base.GetCppThis(), arg0);
		}

		// Token: 0x06008A19 RID: 35353
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourWidget_SetContinuousDraw_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Define a contour by continuously drawing with the mouse cursor.
		/// Press and hold the left mouse button down to continuously draw.
		/// Releasing the left mouse button switches into a snap drawing mode.
		/// Terminate the contour by pressing the right mouse button.  If you
		/// do not want to see the nodes as they are added to the contour, set the
		/// opacity to 0 of the representation's property.  If you do not want to
		/// see the last active node as it is being added, set the opacity to 0
		/// of the representation's active property.
		/// </summary>
		// Token: 0x06008A1A RID: 35354 RVA: 0x000C51BF File Offset: 0x000C33BF
		public virtual void SetContinuousDraw(int _arg)
		{
			vtkContourWidget.vtkContourWidget_SetContinuousDraw_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06008A1B RID: 35355
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourWidget_SetEnabled_25(HandleRef pThis, int arg0);

		/// <summary>
		/// The method for activating and deactivating this widget. This method
		/// must be overridden because it is a composite widget and does more than
		/// its superclasses' vtkAbstractWidget::SetEnabled() method.
		/// </summary>
		// Token: 0x06008A1C RID: 35356 RVA: 0x000C51CF File Offset: 0x000C33CF
		public override void SetEnabled(int arg0)
		{
			vtkContourWidget.vtkContourWidget_SetEnabled_25(base.GetCppThis(), arg0);
		}

		// Token: 0x06008A1D RID: 35357
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourWidget_SetFollowCursor_26(HandleRef pThis, int _arg);

		/// <summary>
		/// Follow the cursor ? If this is ON, during definition, the last node of the
		/// contour will automatically follow the cursor, without waiting for the
		/// point to be dropped. This may be useful for some interpolators, such as the
		/// live-wire interpolator to see the shape of the contour that will be placed
		/// as you move the mouse cursor.
		/// </summary>
		// Token: 0x06008A1E RID: 35358 RVA: 0x000C51DF File Offset: 0x000C33DF
		public virtual void SetFollowCursor(int _arg)
		{
			vtkContourWidget.vtkContourWidget_SetFollowCursor_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06008A1F RID: 35359
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourWidget_SetRepresentation_27(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x06008A20 RID: 35360 RVA: 0x000C51F0 File Offset: 0x000C33F0
		public void SetRepresentation(vtkContourRepresentation r)
		{
			vtkContourWidget.vtkContourWidget_SetRepresentation_27(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		// Token: 0x06008A21 RID: 35361
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourWidget_SetWidgetState_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Convenient method to change what state the widget is in.
		/// </summary>
		// Token: 0x06008A22 RID: 35362 RVA: 0x000C521F File Offset: 0x000C341F
		public virtual void SetWidgetState(int _arg)
		{
			vtkContourWidget.vtkContourWidget_SetWidgetState_28(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BA1 RID: 2977
		public new const string MRFullTypeName = "Kitware.VTK.vtkContourWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BA2 RID: 2978
		public new static readonly string MRClassNameKey = "class vtkContourWidget";

		/// <summary>
		/// Initialize the contour widget from a user supplied set of points. The
		/// state of the widget decides if you are still defining the widget, or
		/// if you've finished defining (added the last point) are manipulating
		/// it. Note that if the polydata supplied is closed, the state will be
		/// set to manipulate.
		/// State: Define = 0, Manipulate = 1.
		/// </summary>
		// Token: 0x02000304 RID: 772
		public enum Define_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000BA4 RID: 2980
			Define = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000BA5 RID: 2981
			Manipulate,
			/// <summary>enum member</summary>
			// Token: 0x04000BA6 RID: 2982
			Start = 0
		}
	}
}
