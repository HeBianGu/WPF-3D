using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLineWidget
	/// </summary>
	/// <remarks>
	///    3D widget for manipulating a line
	///
	/// This 3D widget defines a line that can be interactively placed in a
	/// scene. The line has two handles (at its endpoints), plus the line can be
	/// picked to translate it in the scene.  A nice feature of the object is that
	/// the vtkLineWidget, like any 3D widget, will work with the current
	/// interactor style and any other widgets present in the scene. That is, if
	/// vtkLineWidget does not handle an event, then all other registered
	/// observers (including the interactor style) have an opportunity to process
	/// the event. Otherwise, the vtkLineWidget will terminate the processing of
	/// the event that it handles.
	///
	/// To use this object, just invoke SetInteractor() with the argument of the
	/// method a vtkRenderWindowInteractor.  You may also wish to invoke
	/// "PlaceWidget()" to initially position the widget. The interactor will act
	/// normally until the "i" key (for "interactor") is pressed, at which point
	/// the vtkLineWidget will appear. (See superclass documentation for
	/// information about changing this behavior.) By grabbing one of the two end
	/// point handles (use the left mouse button), the line can be oriented and
	/// stretched (the other end point remains fixed). By grabbing the line
	/// itself, or using the middle mouse button, the entire line can be
	/// translated.  Scaling (about the center of the line) is achieved by using
	/// the right mouse button. By moving the mouse "up" the render window the
	/// line will be made bigger; by moving "down" the render window the widget
	/// will be made smaller. Turn off the widget by pressing the "i" key again
	/// (or invoke the Off() method). (Note: picking the line or either one of the
	/// two end point handles causes a vtkPointWidget to appear.  This widget has
	/// the ability to constrain motion to an axis by pressing the "shift" key
	/// while moving the mouse.)
	///
	/// The vtkLineWidget has several methods that can be used in conjunction with
	/// other VTK objects. The Set/GetResolution() methods control the number of
	/// subdivisions of the line; the GetPolyData() method can be used to get the
	/// polygonal representation and can be used for things like seeding
	/// streamlines. Typical usage of the widget is to make use of the
	/// StartInteractionEvent, InteractionEvent, and EndInteractionEvent
	/// events. The InteractionEvent is called on mouse motion; the other two
	/// events are called on button down and button up (either left or right
	/// button).
	///
	/// Some additional features of this class include the ability to control the
	/// properties of the widget. You can set the properties of the selected and
	/// unselected representations of the line. For example, you can set the
	/// property for the handles and line. In addition there are methods to
	/// constrain the line so that it is aligned along the x-y-z axes.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtk3DWidget vtkBoxWidget vtkPlaneWidget
	/// </seealso>
	// Token: 0x02000339 RID: 825
	public class vtkLineWidget : vtk3DWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060095BD RID: 38333 RVA: 0x000D412B File Offset: 0x000D232B
		static vtkLineWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLineWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLineWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060095BE RID: 38334 RVA: 0x000D4153 File Offset: 0x000D2353
		public vtkLineWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060095BF RID: 38335
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x060095C0 RID: 38336 RVA: 0x000D4164 File Offset: 0x000D2364
		public new static vtkLineWidget New()
		{
			vtkLineWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLineWidget.vtkLineWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLineWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x060095C1 RID: 38337 RVA: 0x000D41B8 File Offset: 0x000D23B8
		public vtkLineWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLineWidget.vtkLineWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060095C2 RID: 38338 RVA: 0x000D41FC File Offset: 0x000D23FC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060095C3 RID: 38339
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineWidget_ClampToBoundsOff_01(HandleRef pThis);

		/// <summary>
		/// Enable/disable clamping of the point end points to the bounding box
		/// of the data. The bounding box is defined from the last PlaceWidget()
		/// invocation, and includes the effect of the PlaceFactor which is used
		/// to gram/shrink the bounding box.
		/// </summary>
		// Token: 0x060095C4 RID: 38340 RVA: 0x000D4207 File Offset: 0x000D2407
		public virtual void ClampToBoundsOff()
		{
			vtkLineWidget.vtkLineWidget_ClampToBoundsOff_01(base.GetCppThis());
		}

		// Token: 0x060095C5 RID: 38341
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineWidget_ClampToBoundsOn_02(HandleRef pThis);

		/// <summary>
		/// Enable/disable clamping of the point end points to the bounding box
		/// of the data. The bounding box is defined from the last PlaceWidget()
		/// invocation, and includes the effect of the PlaceFactor which is used
		/// to gram/shrink the bounding box.
		/// </summary>
		// Token: 0x060095C6 RID: 38342 RVA: 0x000D4216 File Offset: 0x000D2416
		public virtual void ClampToBoundsOn()
		{
			vtkLineWidget.vtkLineWidget_ClampToBoundsOn_02(base.GetCppThis());
		}

		// Token: 0x060095C7 RID: 38343
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLineWidget_GetAlign_03(HandleRef pThis);

		/// <summary>
		/// Force the line widget to be aligned with one of the x-y-z axes.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the line to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x060095C8 RID: 38344 RVA: 0x000D4228 File Offset: 0x000D2428
		public virtual int GetAlign()
		{
			return vtkLineWidget.vtkLineWidget_GetAlign_03(base.GetCppThis());
		}

		// Token: 0x060095C9 RID: 38345
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLineWidget_GetAlignMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Force the line widget to be aligned with one of the x-y-z axes.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the line to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x060095CA RID: 38346 RVA: 0x000D4248 File Offset: 0x000D2448
		public virtual int GetAlignMaxValue()
		{
			return vtkLineWidget.vtkLineWidget_GetAlignMaxValue_04(base.GetCppThis());
		}

		// Token: 0x060095CB RID: 38347
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLineWidget_GetAlignMinValue_05(HandleRef pThis);

		/// <summary>
		/// Force the line widget to be aligned with one of the x-y-z axes.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the line to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x060095CC RID: 38348 RVA: 0x000D4268 File Offset: 0x000D2468
		public virtual int GetAlignMinValue()
		{
			return vtkLineWidget.vtkLineWidget_GetAlignMinValue_05(base.GetCppThis());
		}

		// Token: 0x060095CD RID: 38349
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLineWidget_GetClampToBounds_06(HandleRef pThis);

		/// <summary>
		/// Enable/disable clamping of the point end points to the bounding box
		/// of the data. The bounding box is defined from the last PlaceWidget()
		/// invocation, and includes the effect of the PlaceFactor which is used
		/// to gram/shrink the bounding box.
		/// </summary>
		// Token: 0x060095CE RID: 38350 RVA: 0x000D4288 File Offset: 0x000D2488
		public virtual int GetClampToBounds()
		{
			return vtkLineWidget.vtkLineWidget_GetClampToBounds_06(base.GetCppThis());
		}

		// Token: 0x060095CF RID: 38351
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineWidget_GetHandleProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the handle properties (the little balls are the handles). The
		/// properties of the handles when selected and normal can be
		/// manipulated.
		/// </summary>
		// Token: 0x060095D0 RID: 38352 RVA: 0x000D42A8 File Offset: 0x000D24A8
		public virtual vtkProperty GetHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLineWidget.vtkLineWidget_GetHandleProperty_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060095D1 RID: 38353
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineWidget_GetLineProperty_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the line properties. The properties of the line when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x060095D2 RID: 38354 RVA: 0x000D4318 File Offset: 0x000D2518
		public virtual vtkProperty GetLineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLineWidget.vtkLineWidget_GetLineProperty_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060095D3 RID: 38355
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLineWidget_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x060095D4 RID: 38356 RVA: 0x000D4388 File Offset: 0x000D2588
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLineWidget.vtkLineWidget_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x060095D5 RID: 38357
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLineWidget_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x060095D6 RID: 38358 RVA: 0x000D43A8 File Offset: 0x000D25A8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLineWidget.vtkLineWidget_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x060095D7 RID: 38359
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineWidget_GetPoint1_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the position of first end point.
		/// </summary>
		// Token: 0x060095D8 RID: 38360 RVA: 0x000D43C4 File Offset: 0x000D25C4
		public double[] GetPoint1()
		{
			IntPtr intPtr = vtkLineWidget.vtkLineWidget_GetPoint1_11(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060095D9 RID: 38361
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineWidget_GetPoint1_12(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// Set/Get the position of first end point.
		/// </summary>
		// Token: 0x060095DA RID: 38362 RVA: 0x000D440C File Offset: 0x000D260C
		public void GetPoint1(IntPtr xyz)
		{
			vtkLineWidget.vtkLineWidget_GetPoint1_12(base.GetCppThis(), xyz);
		}

		// Token: 0x060095DB RID: 38363
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineWidget_GetPoint2_13(HandleRef pThis);

		/// <summary>
		/// Set position of other end point.
		/// </summary>
		// Token: 0x060095DC RID: 38364 RVA: 0x000D441C File Offset: 0x000D261C
		public double[] GetPoint2()
		{
			IntPtr intPtr = vtkLineWidget.vtkLineWidget_GetPoint2_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060095DD RID: 38365
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineWidget_GetPoint2_14(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// Set position of other end point.
		/// </summary>
		// Token: 0x060095DE RID: 38366 RVA: 0x000D4464 File Offset: 0x000D2664
		public void GetPoint2(IntPtr xyz)
		{
			vtkLineWidget.vtkLineWidget_GetPoint2_14(base.GetCppThis(), xyz);
		}

		// Token: 0x060095DF RID: 38367
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineWidget_GetPolyData_15(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Grab the polydata (including points) that defines the line.  The
		/// polydata consists of n+1 points, where n is the resolution of the
		/// line. These point values are guaranteed to be up-to-date when either the
		/// InteractionEvent or EndInteraction events are invoked. The user provides
		/// the vtkPolyData and the points and polyline are added to it.
		/// </summary>
		// Token: 0x060095E0 RID: 38368 RVA: 0x000D4474 File Offset: 0x000D2674
		public void GetPolyData(vtkPolyData pd)
		{
			vtkLineWidget.vtkLineWidget_GetPolyData_15(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x060095E1 RID: 38369
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLineWidget_GetResolution_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the resolution (number of subdivisions) of the line.
		/// </summary>
		// Token: 0x060095E2 RID: 38370 RVA: 0x000D44A4 File Offset: 0x000D26A4
		public int GetResolution()
		{
			return vtkLineWidget.vtkLineWidget_GetResolution_16(base.GetCppThis());
		}

		// Token: 0x060095E3 RID: 38371
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineWidget_GetSelectedHandleProperty_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the handle properties (the little balls are the handles). The
		/// properties of the handles when selected and normal can be
		/// manipulated.
		/// </summary>
		// Token: 0x060095E4 RID: 38372 RVA: 0x000D44C4 File Offset: 0x000D26C4
		public virtual vtkProperty GetSelectedHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLineWidget.vtkLineWidget_GetSelectedHandleProperty_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060095E5 RID: 38373
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineWidget_GetSelectedLineProperty_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the line properties. The properties of the line when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x060095E6 RID: 38374 RVA: 0x000D4534 File Offset: 0x000D2734
		public virtual vtkProperty GetSelectedLineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLineWidget.vtkLineWidget_GetSelectedLineProperty_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060095E7 RID: 38375
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLineWidget_IsA_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x060095E8 RID: 38376 RVA: 0x000D45A4 File Offset: 0x000D27A4
		public override int IsA(string type)
		{
			return vtkLineWidget.vtkLineWidget_IsA_19(base.GetCppThis(), type);
		}

		// Token: 0x060095E9 RID: 38377
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLineWidget_IsTypeOf_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x060095EA RID: 38378 RVA: 0x000D45C4 File Offset: 0x000D27C4
		public new static int IsTypeOf(string type)
		{
			return vtkLineWidget.vtkLineWidget_IsTypeOf_20(type);
		}

		// Token: 0x060095EB RID: 38379
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineWidget_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x060095EC RID: 38380 RVA: 0x000D45E0 File Offset: 0x000D27E0
		public new vtkLineWidget NewInstance()
		{
			vtkLineWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLineWidget.vtkLineWidget_NewInstance_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLineWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060095ED RID: 38381
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineWidget_PlaceWidget_23(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x060095EE RID: 38382 RVA: 0x000D463A File Offset: 0x000D283A
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkLineWidget.vtkLineWidget_PlaceWidget_23(base.GetCppThis(), bounds);
		}

		// Token: 0x060095EF RID: 38383
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineWidget_PlaceWidget_24(HandleRef pThis);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x060095F0 RID: 38384 RVA: 0x000D464A File Offset: 0x000D284A
		public override void PlaceWidget()
		{
			vtkLineWidget.vtkLineWidget_PlaceWidget_24(base.GetCppThis());
		}

		// Token: 0x060095F1 RID: 38385
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineWidget_PlaceWidget_25(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x060095F2 RID: 38386 RVA: 0x000D4659 File Offset: 0x000D2859
		public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkLineWidget.vtkLineWidget_PlaceWidget_25(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		// Token: 0x060095F3 RID: 38387
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLineWidget_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x060095F4 RID: 38388 RVA: 0x000D4674 File Offset: 0x000D2874
		public new static vtkLineWidget SafeDownCast(vtkObjectBase o)
		{
			vtkLineWidget vtkLineWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLineWidget.vtkLineWidget_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLineWidget = (vtkLineWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLineWidget.Register(null);
				}
			}
			return vtkLineWidget;
		}

		// Token: 0x060095F5 RID: 38389
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineWidget_SetAlign_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Force the line widget to be aligned with one of the x-y-z axes.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the line to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x060095F6 RID: 38390 RVA: 0x000D46F3 File Offset: 0x000D28F3
		public virtual void SetAlign(int _arg)
		{
			vtkLineWidget.vtkLineWidget_SetAlign_27(base.GetCppThis(), _arg);
		}

		// Token: 0x060095F7 RID: 38391
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineWidget_SetAlignToNone_28(HandleRef pThis);

		/// <summary>
		/// Force the line widget to be aligned with one of the x-y-z axes.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the line to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x060095F8 RID: 38392 RVA: 0x000D4703 File Offset: 0x000D2903
		public void SetAlignToNone()
		{
			vtkLineWidget.vtkLineWidget_SetAlignToNone_28(base.GetCppThis());
		}

		// Token: 0x060095F9 RID: 38393
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineWidget_SetAlignToXAxis_29(HandleRef pThis);

		/// <summary>
		/// Force the line widget to be aligned with one of the x-y-z axes.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the line to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x060095FA RID: 38394 RVA: 0x000D4712 File Offset: 0x000D2912
		public void SetAlignToXAxis()
		{
			vtkLineWidget.vtkLineWidget_SetAlignToXAxis_29(base.GetCppThis());
		}

		// Token: 0x060095FB RID: 38395
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineWidget_SetAlignToYAxis_30(HandleRef pThis);

		/// <summary>
		/// Force the line widget to be aligned with one of the x-y-z axes.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the line to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x060095FC RID: 38396 RVA: 0x000D4721 File Offset: 0x000D2921
		public void SetAlignToYAxis()
		{
			vtkLineWidget.vtkLineWidget_SetAlignToYAxis_30(base.GetCppThis());
		}

		// Token: 0x060095FD RID: 38397
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineWidget_SetAlignToZAxis_31(HandleRef pThis);

		/// <summary>
		/// Force the line widget to be aligned with one of the x-y-z axes.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the line to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x060095FE RID: 38398 RVA: 0x000D4730 File Offset: 0x000D2930
		public void SetAlignToZAxis()
		{
			vtkLineWidget.vtkLineWidget_SetAlignToZAxis_31(base.GetCppThis());
		}

		// Token: 0x060095FF RID: 38399
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineWidget_SetClampToBounds_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/disable clamping of the point end points to the bounding box
		/// of the data. The bounding box is defined from the last PlaceWidget()
		/// invocation, and includes the effect of the PlaceFactor which is used
		/// to gram/shrink the bounding box.
		/// </summary>
		// Token: 0x06009600 RID: 38400 RVA: 0x000D473F File Offset: 0x000D293F
		public virtual void SetClampToBounds(int _arg)
		{
			vtkLineWidget.vtkLineWidget_SetClampToBounds_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06009601 RID: 38401
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineWidget_SetEnabled_33(HandleRef pThis, int arg0);

		/// <summary>
		/// Methods that satisfy the superclass' API.
		/// </summary>
		// Token: 0x06009602 RID: 38402 RVA: 0x000D474F File Offset: 0x000D294F
		public override void SetEnabled(int arg0)
		{
			vtkLineWidget.vtkLineWidget_SetEnabled_33(base.GetCppThis(), arg0);
		}

		// Token: 0x06009603 RID: 38403
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineWidget_SetPoint1_34(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set/Get the position of first end point.
		/// </summary>
		// Token: 0x06009604 RID: 38404 RVA: 0x000D475F File Offset: 0x000D295F
		public void SetPoint1(double x, double y, double z)
		{
			vtkLineWidget.vtkLineWidget_SetPoint1_34(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06009605 RID: 38405
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineWidget_SetPoint1_35(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Set/Get the position of first end point.
		/// </summary>
		// Token: 0x06009606 RID: 38406 RVA: 0x000D4771 File Offset: 0x000D2971
		public void SetPoint1(IntPtr x)
		{
			vtkLineWidget.vtkLineWidget_SetPoint1_35(base.GetCppThis(), x);
		}

		// Token: 0x06009607 RID: 38407
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineWidget_SetPoint2_36(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set position of other end point.
		/// </summary>
		// Token: 0x06009608 RID: 38408 RVA: 0x000D4781 File Offset: 0x000D2981
		public void SetPoint2(double x, double y, double z)
		{
			vtkLineWidget.vtkLineWidget_SetPoint2_36(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06009609 RID: 38409
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineWidget_SetPoint2_37(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Set position of other end point.
		/// </summary>
		// Token: 0x0600960A RID: 38410 RVA: 0x000D4793 File Offset: 0x000D2993
		public void SetPoint2(IntPtr x)
		{
			vtkLineWidget.vtkLineWidget_SetPoint2_37(base.GetCppThis(), x);
		}

		// Token: 0x0600960B RID: 38411
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLineWidget_SetResolution_38(HandleRef pThis, int r);

		/// <summary>
		/// Set/Get the resolution (number of subdivisions) of the line.
		/// </summary>
		// Token: 0x0600960C RID: 38412 RVA: 0x000D47A3 File Offset: 0x000D29A3
		public void SetResolution(int r)
		{
			vtkLineWidget.vtkLineWidget_SetResolution_38(base.GetCppThis(), r);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C4E RID: 3150
		public new const string MRFullTypeName = "Kitware.VTK.vtkLineWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C4F RID: 3151
		public new static readonly string MRClassNameKey = "class vtkLineWidget";
	}
}
