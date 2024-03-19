using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkWidgetSet
	/// </summary>
	/// <remarks>
	///    Synchronize a collection on vtkWidgets drawn on different renderwindows using the
	/// Callback - Dispatch Action mechanism.
	///
	///
	/// The class synchronizes a set of vtkAbstractWidget(s). Widgets typically
	/// invoke "Actions" that drive the geometry/behaviour of their representations
	/// in response to interactor events. Interactor interactions on a render window
	/// are mapped into "Callbacks" by the widget, from which "Actions" are
	/// dispatched to the entire set. This architecture allows us to tie widgets
	/// existing in different render windows together. For instance a HandleWidget
	/// might exist on the sagittal view. Moving it around should update the
	/// representations of the corresponding handle widget that lies on the axial
	/// and coronal and volume views as well.
	///
	/// @par User API:
	/// A user would use this class as follows.
	/// <code>
	/// vtkWidgetSet *set = vtkWidgetSet::New();
	/// vtkParallelopipedWidget *w1 = vtkParallelopipedWidget::New();
	/// set-&gt;AddWidget(w1);
	/// w1-&gt;SetInteractor(axialRenderWindow-&gt;GetInteractor());
	/// vtkParallelopipedWidget *w2 = vtkParallelopipedWidget::New();
	/// set-&gt;AddWidget(w2);
	/// w2-&gt;SetInteractor(coronalRenderWindow-&gt;GetInteractor());
	/// vtkParallelopipedWidget *w3 = vtkParallelopipedWidget::New();
	/// set-&gt;AddWidget(w3);
	/// w3-&gt;SetInteractor(sagittalRenderWindow-&gt;GetInteractor());
	/// set-&gt;SetEnabled(1);
	/// </code>
	///
	/// @par Motivation:
	/// The motivation for this class is really to provide a usable API to tie
	/// together multiple widgets of the same kind. To enable this, subclasses
	/// of vtkAbstractWidget, must be written as follows:
	///   They will generally have callback methods mapped to some user
	/// interaction such as:
	/// <code>
	/// this-&gt;CallbackMapper-&gt;SetCallbackMethod(vtkCommand::LeftButtonPressEvent,
	///                         vtkEvent::NoModifier, 0, 0, nullptr,
	///                         vtkPaintbrushWidget::BeginDrawStrokeEvent,
	///                         this, vtkPaintbrushWidget::BeginDrawCallback);
	/// </code>
	///   The callback invoked when the left button is pressed looks like:
	/// <code>
	/// void vtkPaintbrushWidget::BeginDrawCallback(vtkAbstractWidget *w)
	/// {
	///   vtkPaintbrushWidget *self = vtkPaintbrushWidget::SafeDownCast(w);
	///   self-&gt;WidgetSet-&gt;DispatchAction(self, &amp;vtkPaintbrushWidget::BeginDrawAction);
	/// }
	/// </code>
	///   The actual code for handling the drawing is written in the BeginDrawAction
	/// method.
	/// <code>
	/// void vtkPaintbrushWidget::BeginDrawAction( vtkPaintbrushWidget *dispatcher)
	/// {
	/// // Do stuff to draw...
	/// // Here dispatcher is the widget that was interacted with, the one that
	/// // dispatched an action to all the other widgets in its group. You may, if
	/// // necessary find it helpful to get parameters from it.
	/// //   For instance for a ResizeAction:
	/// //     if (this != dispatcher)
	/// //       {
	/// //       double *newsize = dispatcher-&gt;GetRepresentation()-&gt;GetSize();
	/// //       this-&gt;WidgetRep-&gt;SetSize(newsize);
	/// //       }
	/// //     else
	/// //       {
	/// //       this-&gt;WidgetRep-&gt;IncrementSizeByDelta();
	/// //       }
	/// }
	/// </code>
	///
	/// @warning
	/// Actions are always dispatched first to the activeWidget, the one calling
	/// the set, and then to the other widgets in the set.
	///
	/// </remarks>
	// Token: 0x0200038F RID: 911
	public class vtkWidgetSet : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A5BB RID: 42427 RVA: 0x000EB2C1 File Offset: 0x000E94C1
		static vtkWidgetSet()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWidgetSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWidgetSet"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A5BC RID: 42428 RVA: 0x000EB2E9 File Offset: 0x000E94E9
		public vtkWidgetSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A5BD RID: 42429
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWidgetSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x0600A5BE RID: 42430 RVA: 0x000EB2F8 File Offset: 0x000E94F8
		public new static vtkWidgetSet New()
		{
			vtkWidgetSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWidgetSet.vtkWidgetSet_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWidgetSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x0600A5BF RID: 42431 RVA: 0x000EB34C File Offset: 0x000E954C
		public vtkWidgetSet() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkWidgetSet.vtkWidgetSet_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A5C0 RID: 42432 RVA: 0x000EB390 File Offset: 0x000E9590
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A5C1 RID: 42433
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetSet_AddWidget_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Add a widget to the set.
		/// </summary>
		// Token: 0x0600A5C2 RID: 42434 RVA: 0x000EB39C File Offset: 0x000E959C
		public void AddWidget(vtkAbstractWidget arg0)
		{
			vtkWidgetSet.vtkWidgetSet_AddWidget_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A5C3 RID: 42435
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetSet_EnabledOff_02(HandleRef pThis);

		/// <summary>
		/// Method for activating and deactivating all widgets in the group.
		/// </summary>
		// Token: 0x0600A5C4 RID: 42436 RVA: 0x000EB3CB File Offset: 0x000E95CB
		public virtual void EnabledOff()
		{
			vtkWidgetSet.vtkWidgetSet_EnabledOff_02(base.GetCppThis());
		}

		// Token: 0x0600A5C5 RID: 42437
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetSet_EnabledOn_03(HandleRef pThis);

		/// <summary>
		/// Method for activating and deactivating all widgets in the group.
		/// </summary>
		// Token: 0x0600A5C6 RID: 42438 RVA: 0x000EB3DA File Offset: 0x000E95DA
		public virtual void EnabledOn()
		{
			vtkWidgetSet.vtkWidgetSet_EnabledOn_03(base.GetCppThis());
		}

		// Token: 0x0600A5C7 RID: 42439
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWidgetSet_GetNthWidget_04(HandleRef pThis, uint arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the Nth widget in the set.
		/// </summary>
		// Token: 0x0600A5C8 RID: 42440 RVA: 0x000EB3EC File Offset: 0x000E95EC
		public vtkAbstractWidget GetNthWidget(uint arg0)
		{
			vtkAbstractWidget vtkAbstractWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWidgetSet.vtkWidgetSet_GetNthWidget_04(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractWidget = (vtkAbstractWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractWidget.Register(null);
				}
			}
			return vtkAbstractWidget;
		}

		// Token: 0x0600A5C9 RID: 42441
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWidgetSet_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x0600A5CA RID: 42442 RVA: 0x000EB45C File Offset: 0x000E965C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkWidgetSet.vtkWidgetSet_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600A5CB RID: 42443
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWidgetSet_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x0600A5CC RID: 42444 RVA: 0x000EB47C File Offset: 0x000E967C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkWidgetSet.vtkWidgetSet_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600A5CD RID: 42445
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkWidgetSet_GetNumberOfWidgets_07(HandleRef pThis);

		/// <summary>
		/// Get number of widgets in the set.
		/// </summary>
		// Token: 0x0600A5CE RID: 42446 RVA: 0x000EB498 File Offset: 0x000E9698
		public uint GetNumberOfWidgets()
		{
			return vtkWidgetSet.vtkWidgetSet_GetNumberOfWidgets_07(base.GetCppThis());
		}

		// Token: 0x0600A5CF RID: 42447
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWidgetSet_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x0600A5D0 RID: 42448 RVA: 0x000EB4B8 File Offset: 0x000E96B8
		public override int IsA(string type)
		{
			return vtkWidgetSet.vtkWidgetSet_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0600A5D1 RID: 42449
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWidgetSet_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x0600A5D2 RID: 42450 RVA: 0x000EB4D8 File Offset: 0x000E96D8
		public new static int IsTypeOf(string type)
		{
			return vtkWidgetSet.vtkWidgetSet_IsTypeOf_09(type);
		}

		// Token: 0x0600A5D3 RID: 42451
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWidgetSet_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x0600A5D4 RID: 42452 RVA: 0x000EB4F4 File Offset: 0x000E96F4
		public new vtkWidgetSet NewInstance()
		{
			vtkWidgetSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWidgetSet.vtkWidgetSet_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWidgetSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A5D5 RID: 42453
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetSet_RemoveWidget_12(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Remove a widget from the set
		/// </summary>
		// Token: 0x0600A5D6 RID: 42454 RVA: 0x000EB550 File Offset: 0x000E9750
		public void RemoveWidget(vtkAbstractWidget arg0)
		{
			vtkWidgetSet.vtkWidgetSet_RemoveWidget_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A5D7 RID: 42455
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWidgetSet_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x0600A5D8 RID: 42456 RVA: 0x000EB580 File Offset: 0x000E9780
		public new static vtkWidgetSet SafeDownCast(vtkObjectBase o)
		{
			vtkWidgetSet vtkWidgetSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWidgetSet.vtkWidgetSet_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWidgetSet = (vtkWidgetSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWidgetSet.Register(null);
				}
			}
			return vtkWidgetSet;
		}

		// Token: 0x0600A5D9 RID: 42457
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWidgetSet_SetEnabled_14(HandleRef pThis, int arg0);

		/// <summary>
		/// Method for activating and deactivating all widgets in the group.
		/// </summary>
		// Token: 0x0600A5DA RID: 42458 RVA: 0x000EB5FF File Offset: 0x000E97FF
		public virtual void SetEnabled(int arg0)
		{
			vtkWidgetSet.vtkWidgetSet_SetEnabled_14(base.GetCppThis(), arg0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D53 RID: 3411
		public new const string MRFullTypeName = "Kitware.VTK.vtkWidgetSet";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D54 RID: 3412
		public new static readonly string MRClassNameKey = "class vtkWidgetSet";
	}
}
