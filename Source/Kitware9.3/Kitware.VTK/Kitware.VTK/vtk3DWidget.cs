using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtk3DWidget
	/// </summary>
	/// <remarks>
	///    an abstract superclass for 3D widgets
	///
	/// vtk3DWidget is an abstract superclass for 3D interactor observers. These
	/// 3D widgets represent themselves in the scene, and have special callbacks
	/// associated with them that allows interactive manipulation of the widget.
	/// Inparticular, the difference between a vtk3DWidget and its abstract
	/// superclass vtkInteractorObserver is that vtk3DWidgets are "placed" in 3D
	/// space.  vtkInteractorObservers have no notion of where they are placed,
	/// and may not exist in 3D space at all.  3D widgets also provide auxiliary
	/// functions like producing a transformation, creating polydata (for seeding
	/// streamlines, probes, etc.) or creating implicit functions. See the
	/// concrete subclasses for particulars.
	///
	/// Typically the widget is used by specifying a vtkProp3D or VTK dataset as
	/// input, and then invoking the "On" method to activate it. (You can also
	/// specify a bounding box to help position the widget.) Prior to invoking the
	/// On() method, the user may also wish to use the PlaceWidget() to initially
	/// position it. The 'i' (for "interactor") keypresses also can be used to
	/// turn the widgets on and off (methods exist to change the key value
	/// and enable keypress activiation).
	///
	/// To support interactive manipulation of objects, this class (and
	/// subclasses) invoke the events StartInteractionEvent, InteractionEvent, and
	/// EndInteractionEvent.  These events are invoked when the vtk3DWidget enters
	/// a state where rapid response is desired: mouse motion, etc. The events can
	/// be used, for example, to set the desired update frame rate
	/// (StartInteractionEvent), operate on the vtkProp3D or other object
	/// (InteractionEvent), and set the desired frame rate back to normal values
	/// (EndInteractionEvent).
	///
	/// Note that the Priority attribute inherited from vtkInteractorObserver has
	/// a new default value which is now 0.5 so that all 3D widgets have a higher
	/// priority than the usual interactor styles.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkBoxWidget vtkPlaneWidget vtkLineWidget vtkPointWidget
	/// vtkSphereWidget vtkImplicitPlaneWidget
	/// </seealso>
	// Token: 0x020002AC RID: 684
	public abstract class vtk3DWidget : vtkInteractorObserver
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007B72 RID: 31602 RVA: 0x000B1B23 File Offset: 0x000AFD23
		static vtk3DWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtk3DWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtk3DWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007B73 RID: 31603 RVA: 0x000B1B4B File Offset: 0x000AFD4B
		public vtk3DWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007B74 RID: 31604 RVA: 0x000B1B59 File Offset: 0x000AFD59
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007B75 RID: 31605
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtk3DWidget_GetHandleSize_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls the size of the handles that
		/// appear as part of the widget. These handles (like spheres, etc.)
		/// are used to manipulate the widget, and are sized as a fraction of
		/// the screen diagonal.
		/// </summary>
		// Token: 0x06007B76 RID: 31606 RVA: 0x000B1B64 File Offset: 0x000AFD64
		public virtual double GetHandleSize()
		{
			return vtk3DWidget.vtk3DWidget_GetHandleSize_01(base.GetCppThis());
		}

		// Token: 0x06007B77 RID: 31607
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtk3DWidget_GetHandleSizeMaxValue_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls the size of the handles that
		/// appear as part of the widget. These handles (like spheres, etc.)
		/// are used to manipulate the widget, and are sized as a fraction of
		/// the screen diagonal.
		/// </summary>
		// Token: 0x06007B78 RID: 31608 RVA: 0x000B1B84 File Offset: 0x000AFD84
		public virtual double GetHandleSizeMaxValue()
		{
			return vtk3DWidget.vtk3DWidget_GetHandleSizeMaxValue_02(base.GetCppThis());
		}

		// Token: 0x06007B79 RID: 31609
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtk3DWidget_GetHandleSizeMinValue_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls the size of the handles that
		/// appear as part of the widget. These handles (like spheres, etc.)
		/// are used to manipulate the widget, and are sized as a fraction of
		/// the screen diagonal.
		/// </summary>
		// Token: 0x06007B7A RID: 31610 RVA: 0x000B1BA4 File Offset: 0x000AFDA4
		public virtual double GetHandleSizeMinValue()
		{
			return vtk3DWidget.vtk3DWidget_GetHandleSizeMinValue_03(base.GetCppThis());
		}

		// Token: 0x06007B7B RID: 31611
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtk3DWidget_GetInput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the input dataset. This is not required, but if supplied,
		/// and no vtkProp3D is specified, it is used to initially position
		/// the widget.
		/// </summary>
		// Token: 0x06007B7C RID: 31612 RVA: 0x000B1BC4 File Offset: 0x000AFDC4
		public virtual vtkDataSet GetInput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtk3DWidget.vtk3DWidget_GetInput_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x06007B7D RID: 31613
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtk3DWidget_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007B7E RID: 31614 RVA: 0x000B1C34 File Offset: 0x000AFE34
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtk3DWidget.vtk3DWidget_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06007B7F RID: 31615
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtk3DWidget_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007B80 RID: 31616 RVA: 0x000B1C54 File Offset: 0x000AFE54
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtk3DWidget.vtk3DWidget_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06007B81 RID: 31617
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtk3DWidget_GetPlaceFactor_07(HandleRef pThis);

		/// <summary>
		/// Set/Get a factor representing the scaling of the widget upon placement
		/// (via the PlaceWidget() method). Normally the widget is placed so that
		/// it just fits within the bounding box defined in PlaceWidget(bounds).
		/// The PlaceFactor will make the widget larger (PlaceFactor &gt; 1) or smaller
		/// (PlaceFactor &lt; 1). By default, PlaceFactor is set to 0.5.
		/// </summary>
		// Token: 0x06007B82 RID: 31618 RVA: 0x000B1C70 File Offset: 0x000AFE70
		public virtual double GetPlaceFactor()
		{
			return vtk3DWidget.vtk3DWidget_GetPlaceFactor_07(base.GetCppThis());
		}

		// Token: 0x06007B83 RID: 31619
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtk3DWidget_GetPlaceFactorMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Set/Get a factor representing the scaling of the widget upon placement
		/// (via the PlaceWidget() method). Normally the widget is placed so that
		/// it just fits within the bounding box defined in PlaceWidget(bounds).
		/// The PlaceFactor will make the widget larger (PlaceFactor &gt; 1) or smaller
		/// (PlaceFactor &lt; 1). By default, PlaceFactor is set to 0.5.
		/// </summary>
		// Token: 0x06007B84 RID: 31620 RVA: 0x000B1C90 File Offset: 0x000AFE90
		public virtual double GetPlaceFactorMaxValue()
		{
			return vtk3DWidget.vtk3DWidget_GetPlaceFactorMaxValue_08(base.GetCppThis());
		}

		// Token: 0x06007B85 RID: 31621
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtk3DWidget_GetPlaceFactorMinValue_09(HandleRef pThis);

		/// <summary>
		/// Set/Get a factor representing the scaling of the widget upon placement
		/// (via the PlaceWidget() method). Normally the widget is placed so that
		/// it just fits within the bounding box defined in PlaceWidget(bounds).
		/// The PlaceFactor will make the widget larger (PlaceFactor &gt; 1) or smaller
		/// (PlaceFactor &lt; 1). By default, PlaceFactor is set to 0.5.
		/// </summary>
		// Token: 0x06007B86 RID: 31622 RVA: 0x000B1CB0 File Offset: 0x000AFEB0
		public virtual double GetPlaceFactorMinValue()
		{
			return vtk3DWidget.vtk3DWidget_GetPlaceFactorMinValue_09(base.GetCppThis());
		}

		// Token: 0x06007B87 RID: 31623
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtk3DWidget_GetProp3D_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a vtkProp3D around which to place the widget. This
		/// is not required, but if supplied, it is used to initially
		/// position the widget.
		/// </summary>
		// Token: 0x06007B88 RID: 31624 RVA: 0x000B1CD0 File Offset: 0x000AFED0
		public virtual vtkProp3D GetProp3D()
		{
			vtkProp3D vtkProp3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtk3DWidget.vtk3DWidget_GetProp3D_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp3D = (vtkProp3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp3D.Register(null);
				}
			}
			return vtkProp3D;
		}

		// Token: 0x06007B89 RID: 31625
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtk3DWidget_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007B8A RID: 31626 RVA: 0x000B1D40 File Offset: 0x000AFF40
		public override int IsA(string type)
		{
			return vtk3DWidget.vtk3DWidget_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x06007B8B RID: 31627
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtk3DWidget_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007B8C RID: 31628 RVA: 0x000B1D60 File Offset: 0x000AFF60
		public new static int IsTypeOf(string type)
		{
			return vtk3DWidget.vtk3DWidget_IsTypeOf_12(type);
		}

		// Token: 0x06007B8D RID: 31629
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtk3DWidget_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007B8E RID: 31630 RVA: 0x000B1D7C File Offset: 0x000AFF7C
		public new vtk3DWidget NewInstance()
		{
			vtk3DWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtk3DWidget.vtk3DWidget_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtk3DWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007B8F RID: 31631
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DWidget_PlaceWidget_14(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// This method is used to initially place the widget.  The placement of the
		/// widget depends on whether a Prop3D or input dataset is provided. If one
		/// of these two is provided, they will be used to obtain a bounding box,
		/// around which the widget is placed. Otherwise, you can manually specify a
		/// bounds with the PlaceWidget(bounds) method. Note: PlaceWidget(bounds)
		/// is required by all subclasses; the other methods are provided as
		/// convenience methods.
		/// </summary>
		// Token: 0x06007B90 RID: 31632 RVA: 0x000B1DD6 File Offset: 0x000AFFD6
		public virtual void PlaceWidget(IntPtr bounds)
		{
			vtk3DWidget.vtk3DWidget_PlaceWidget_14(base.GetCppThis(), bounds);
		}

		// Token: 0x06007B91 RID: 31633
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DWidget_PlaceWidget_15(HandleRef pThis);

		/// <summary>
		/// This method is used to initially place the widget.  The placement of the
		/// widget depends on whether a Prop3D or input dataset is provided. If one
		/// of these two is provided, they will be used to obtain a bounding box,
		/// around which the widget is placed. Otherwise, you can manually specify a
		/// bounds with the PlaceWidget(bounds) method. Note: PlaceWidget(bounds)
		/// is required by all subclasses; the other methods are provided as
		/// convenience methods.
		/// </summary>
		// Token: 0x06007B92 RID: 31634 RVA: 0x000B1DE6 File Offset: 0x000AFFE6
		public virtual void PlaceWidget()
		{
			vtk3DWidget.vtk3DWidget_PlaceWidget_15(base.GetCppThis());
		}

		// Token: 0x06007B93 RID: 31635
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DWidget_PlaceWidget_16(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		/// <summary>
		/// This method is used to initially place the widget.  The placement of the
		/// widget depends on whether a Prop3D or input dataset is provided. If one
		/// of these two is provided, they will be used to obtain a bounding box,
		/// around which the widget is placed. Otherwise, you can manually specify a
		/// bounds with the PlaceWidget(bounds) method. Note: PlaceWidget(bounds)
		/// is required by all subclasses; the other methods are provided as
		/// convenience methods.
		/// </summary>
		// Token: 0x06007B94 RID: 31636 RVA: 0x000B1DF5 File Offset: 0x000AFFF5
		public virtual void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtk3DWidget.vtk3DWidget_PlaceWidget_16(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		// Token: 0x06007B95 RID: 31637
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtk3DWidget_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007B96 RID: 31638 RVA: 0x000B1E10 File Offset: 0x000B0010
		public new static vtk3DWidget SafeDownCast(vtkObjectBase o)
		{
			vtk3DWidget vtk3DWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtk3DWidget.vtk3DWidget_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtk3DWidget = (vtk3DWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtk3DWidget.Register(null);
				}
			}
			return vtk3DWidget;
		}

		// Token: 0x06007B97 RID: 31639
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DWidget_SetHandleSize_18(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the factor that controls the size of the handles that
		/// appear as part of the widget. These handles (like spheres, etc.)
		/// are used to manipulate the widget, and are sized as a fraction of
		/// the screen diagonal.
		/// </summary>
		// Token: 0x06007B98 RID: 31640 RVA: 0x000B1E8F File Offset: 0x000B008F
		public virtual void SetHandleSize(double _arg)
		{
			vtk3DWidget.vtk3DWidget_SetHandleSize_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06007B99 RID: 31641
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DWidget_SetInputConnection_19(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the input dataset. This is not required, but if supplied,
		/// and no vtkProp3D is specified, it is used to initially position
		/// the widget.
		/// </summary>
		// Token: 0x06007B9A RID: 31642 RVA: 0x000B1EA0 File Offset: 0x000B00A0
		public virtual void SetInputConnection(vtkAlgorithmOutput arg0)
		{
			vtk3DWidget.vtk3DWidget_SetInputConnection_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06007B9B RID: 31643
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DWidget_SetInputData_20(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the input dataset. This is not required, but if supplied,
		/// and no vtkProp3D is specified, it is used to initially position
		/// the widget.
		/// </summary>
		// Token: 0x06007B9C RID: 31644 RVA: 0x000B1ED0 File Offset: 0x000B00D0
		public virtual void SetInputData(vtkDataSet arg0)
		{
			vtk3DWidget.vtk3DWidget_SetInputData_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06007B9D RID: 31645
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DWidget_SetPlaceFactor_21(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get a factor representing the scaling of the widget upon placement
		/// (via the PlaceWidget() method). Normally the widget is placed so that
		/// it just fits within the bounding box defined in PlaceWidget(bounds).
		/// The PlaceFactor will make the widget larger (PlaceFactor &gt; 1) or smaller
		/// (PlaceFactor &lt; 1). By default, PlaceFactor is set to 0.5.
		/// </summary>
		// Token: 0x06007B9E RID: 31646 RVA: 0x000B1EFF File Offset: 0x000B00FF
		public virtual void SetPlaceFactor(double _arg)
		{
			vtk3DWidget.vtk3DWidget_SetPlaceFactor_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06007B9F RID: 31647
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DWidget_SetProp3D_22(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify a vtkProp3D around which to place the widget. This
		/// is not required, but if supplied, it is used to initially
		/// position the widget.
		/// </summary>
		// Token: 0x06007BA0 RID: 31648 RVA: 0x000B1F10 File Offset: 0x000B0110
		public virtual void SetProp3D(vtkProp3D arg0)
		{
			vtk3DWidget.vtk3DWidget_SetProp3D_22(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A6A RID: 2666
		public new const string MRFullTypeName = "Kitware.VTK.vtk3DWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A6B RID: 2667
		public new static readonly string MRClassNameKey = "class vtk3DWidget";
	}
}
