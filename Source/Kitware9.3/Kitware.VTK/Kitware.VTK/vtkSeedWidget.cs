using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSeedWidget
	/// </summary>
	/// <remarks>
	///    place multiple seed points
	///
	/// The vtkSeedWidget is used to placed multiple seed points in the scene.
	/// The seed points can be used for operations like connectivity, segmentation,
	/// and region growing.
	///
	/// To use this widget, specify an instance of vtkSeedWidget and a
	/// representation (a subclass of vtkSeedRepresentation). The widget is
	/// implemented using multiple instances of vtkHandleWidget which can be used
	/// to position the seed points (after they are initially placed). The
	/// representations for these handle widgets are provided by the
	/// vtkSeedRepresentation.
	///
	/// @par Event Bindings:
	/// By default, the widget responds to the following VTK events (i.e., it
	/// watches the vtkRenderWindowInteractor for these events):
	/// &lt;pre&gt;
	///   LeftButtonPressEvent - add a point or select a handle (i.e., seed)
	///   RightButtonPressEvent - finish adding the seeds
	///   MouseMoveEvent - move a handle (i.e., seed)
	///   LeftButtonReleaseEvent - release the selected handle (seed)
	/// &lt;/pre&gt;
	///
	/// @par Event Bindings:
	/// Note that the event bindings described above can be changed using this
	/// class's vtkWidgetEventTranslator. This class translates VTK events
	/// into the vtkSeedWidget's widget events:
	/// &lt;pre&gt;
	///   vtkWidgetEvent::AddPoint -- add one point; depending on the state
	///                               it may the first or second point added. Or,
	///                               if near handle, select handle.
	///   vtkWidgetEvent::Completed -- finished adding seeds.
	///   vtkWidgetEvent::Move -- move the second point or handle depending on the state.
	///   vtkWidgetEvent::EndSelect -- the handle manipulation process has completed.
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
	///   vtkCommand::DeletePointEvent (before point is deleted;
	///                                call data includes handle id (0,1))
	/// &lt;/pre&gt;
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkHandleWidget vtkSeedRepresentation
	/// </seealso>
	// Token: 0x02000373 RID: 883
	public class vtkSeedWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A017 RID: 40983 RVA: 0x000E327D File Offset: 0x000E147D
		static vtkSeedWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSeedWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSeedWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A018 RID: 40984 RVA: 0x000E32A5 File Offset: 0x000E14A5
		public vtkSeedWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A019 RID: 40985
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSeedWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x0600A01A RID: 40986 RVA: 0x000E32B4 File Offset: 0x000E14B4
		public new static vtkSeedWidget New()
		{
			vtkSeedWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSeedWidget.vtkSeedWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSeedWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x0600A01B RID: 40987 RVA: 0x000E3308 File Offset: 0x000E1508
		public vtkSeedWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSeedWidget.vtkSeedWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A01C RID: 40988 RVA: 0x000E334C File Offset: 0x000E154C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A01D RID: 40989
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSeedWidget_CompleteInteraction_01(HandleRef pThis);

		/// <summary>
		/// Method to be called when the seed widget should stop responding to
		/// the place point interaction. The seed widget, when defined allows you
		/// place seeds by clicking on the render window. Use this method to
		/// indicate that you would like to stop placing seeds interactively. If
		/// you'd like the widget to stop responding to *any* user interaction
		/// simply disable event processing by the widget by calling
		/// widget-&gt;ProcessEventsOff()
		/// </summary>
		// Token: 0x0600A01E RID: 40990 RVA: 0x000E3357 File Offset: 0x000E1557
		public virtual void CompleteInteraction()
		{
			vtkSeedWidget.vtkSeedWidget_CompleteInteraction_01(base.GetCppThis());
		}

		// Token: 0x0600A01F RID: 40991
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSeedWidget_CreateDefaultRepresentation_02(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x0600A020 RID: 40992 RVA: 0x000E3366 File Offset: 0x000E1566
		public override void CreateDefaultRepresentation()
		{
			vtkSeedWidget.vtkSeedWidget_CreateDefaultRepresentation_02(base.GetCppThis());
		}

		// Token: 0x0600A021 RID: 40993
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSeedWidget_CreateNewHandle_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Use this method to programmatically create a new handle. In interactive
		/// mode, (when the widget is in the PlacingSeeds state) this method is
		/// automatically invoked. The method returns the handle created.
		/// A valid seed representation must exist for the widget to create a new
		/// handle.
		/// </summary>
		// Token: 0x0600A022 RID: 40994 RVA: 0x000E3378 File Offset: 0x000E1578
		public virtual vtkHandleWidget CreateNewHandle()
		{
			vtkHandleWidget vtkHandleWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSeedWidget.vtkSeedWidget_CreateNewHandle_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHandleWidget = (vtkHandleWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHandleWidget.Register(null);
				}
			}
			return vtkHandleWidget;
		}

		// Token: 0x0600A023 RID: 40995
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSeedWidget_DeleteSeed_04(HandleRef pThis, int n);

		/// <summary>
		/// Delete the nth seed.
		/// </summary>
		// Token: 0x0600A024 RID: 40996 RVA: 0x000E33E7 File Offset: 0x000E15E7
		public void DeleteSeed(int n)
		{
			vtkSeedWidget.vtkSeedWidget_DeleteSeed_04(base.GetCppThis(), n);
		}

		// Token: 0x0600A025 RID: 40997
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSeedWidget_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x0600A026 RID: 40998 RVA: 0x000E33F8 File Offset: 0x000E15F8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSeedWidget.vtkSeedWidget_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600A027 RID: 40999
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSeedWidget_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x0600A028 RID: 41000 RVA: 0x000E3418 File Offset: 0x000E1618
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSeedWidget.vtkSeedWidget_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600A029 RID: 41001
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSeedWidget_GetSeed_07(HandleRef pThis, int n, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the nth seed
		/// </summary>
		// Token: 0x0600A02A RID: 41002 RVA: 0x000E3434 File Offset: 0x000E1634
		public vtkHandleWidget GetSeed(int n)
		{
			vtkHandleWidget vtkHandleWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSeedWidget.vtkSeedWidget_GetSeed_07(base.GetCppThis(), n, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHandleWidget = (vtkHandleWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHandleWidget.Register(null);
				}
			}
			return vtkHandleWidget;
		}

		// Token: 0x0600A02B RID: 41003
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSeedWidget_GetSeedRepresentation_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the representation as a vtkSeedRepresentation.
		/// </summary>
		// Token: 0x0600A02C RID: 41004 RVA: 0x000E34A4 File Offset: 0x000E16A4
		public vtkSeedRepresentation GetSeedRepresentation()
		{
			vtkSeedRepresentation vtkSeedRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSeedWidget.vtkSeedWidget_GetSeedRepresentation_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSeedRepresentation = (vtkSeedRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSeedRepresentation.Register(null);
				}
			}
			return vtkSeedRepresentation;
		}

		// Token: 0x0600A02D RID: 41005
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSeedWidget_GetWidgetState_09(HandleRef pThis);

		/// <summary>
		/// Get the widget state.
		/// </summary>
		// Token: 0x0600A02E RID: 41006 RVA: 0x000E3514 File Offset: 0x000E1714
		public virtual int GetWidgetState()
		{
			return vtkSeedWidget.vtkSeedWidget_GetWidgetState_09(base.GetCppThis());
		}

		// Token: 0x0600A02F RID: 41007
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSeedWidget_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x0600A030 RID: 41008 RVA: 0x000E3534 File Offset: 0x000E1734
		public override int IsA(string type)
		{
			return vtkSeedWidget.vtkSeedWidget_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0600A031 RID: 41009
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSeedWidget_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x0600A032 RID: 41010 RVA: 0x000E3554 File Offset: 0x000E1754
		public new static int IsTypeOf(string type)
		{
			return vtkSeedWidget.vtkSeedWidget_IsTypeOf_11(type);
		}

		// Token: 0x0600A033 RID: 41011
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSeedWidget_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x0600A034 RID: 41012 RVA: 0x000E3570 File Offset: 0x000E1770
		public new vtkSeedWidget NewInstance()
		{
			vtkSeedWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSeedWidget.vtkSeedWidget_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSeedWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A035 RID: 41013
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSeedWidget_RestartInteraction_14(HandleRef pThis);

		/// <summary>
		/// Method to be called when the seed widget should start responding
		/// to the interaction.
		/// </summary>
		// Token: 0x0600A036 RID: 41014 RVA: 0x000E35CA File Offset: 0x000E17CA
		public virtual void RestartInteraction()
		{
			vtkSeedWidget.vtkSeedWidget_RestartInteraction_14(base.GetCppThis());
		}

		// Token: 0x0600A037 RID: 41015
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSeedWidget_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for a VTK class.
		/// </summary>
		// Token: 0x0600A038 RID: 41016 RVA: 0x000E35DC File Offset: 0x000E17DC
		public new static vtkSeedWidget SafeDownCast(vtkObjectBase o)
		{
			vtkSeedWidget vtkSeedWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSeedWidget.vtkSeedWidget_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSeedWidget = (vtkSeedWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSeedWidget.Register(null);
				}
			}
			return vtkSeedWidget;
		}

		// Token: 0x0600A039 RID: 41017
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSeedWidget_SetCurrentRenderer_16(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the current renderer. This method also propagates to all the child
		/// handle widgets, if any exist
		/// </summary>
		// Token: 0x0600A03A RID: 41018 RVA: 0x000E365C File Offset: 0x000E185C
		public override void SetCurrentRenderer(vtkRenderer arg0)
		{
			vtkSeedWidget.vtkSeedWidget_SetCurrentRenderer_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A03B RID: 41019
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSeedWidget_SetEnabled_17(HandleRef pThis, int arg0);

		/// <summary>
		/// The method for activating and deactivating this widget. This method
		/// must be overridden because it is a composite widget and does more than
		/// its superclasses' vtkAbstractWidget::SetEnabled() method.
		/// </summary>
		// Token: 0x0600A03C RID: 41020 RVA: 0x000E368B File Offset: 0x000E188B
		public override void SetEnabled(int arg0)
		{
			vtkSeedWidget.vtkSeedWidget_SetEnabled_17(base.GetCppThis(), arg0);
		}

		// Token: 0x0600A03D RID: 41021
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSeedWidget_SetInteractor_18(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the interactor. This method also propagates to all the child
		/// handle widgets, if any exist
		/// </summary>
		// Token: 0x0600A03E RID: 41022 RVA: 0x000E369C File Offset: 0x000E189C
		public override void SetInteractor(vtkRenderWindowInteractor arg0)
		{
			vtkSeedWidget.vtkSeedWidget_SetInteractor_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600A03F RID: 41023
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSeedWidget_SetProcessEvents_19(HandleRef pThis, int arg0);

		/// <summary>
		/// Methods to change the whether the widget responds to interaction.
		/// Overridden to pass the state to component widgets.
		/// </summary>
		// Token: 0x0600A040 RID: 41024 RVA: 0x000E36CB File Offset: 0x000E18CB
		public override void SetProcessEvents(int arg0)
		{
			vtkSeedWidget.vtkSeedWidget_SetProcessEvents_19(base.GetCppThis(), arg0);
		}

		// Token: 0x0600A041 RID: 41025
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSeedWidget_SetRepresentation_20(HandleRef pThis, HandleRef rep);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x0600A042 RID: 41026 RVA: 0x000E36DC File Offset: 0x000E18DC
		public void SetRepresentation(vtkSeedRepresentation rep)
		{
			vtkSeedWidget.vtkSeedWidget_SetRepresentation_20(base.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CED RID: 3309
		public new const string MRFullTypeName = "Kitware.VTK.vtkSeedWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CEE RID: 3310
		public new static readonly string MRClassNameKey = "class vtkSeedWidget";

		/// <summary>
		/// Get the widget state.
		/// </summary>
		// Token: 0x02000374 RID: 884
		public enum MovingSeed_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000CF0 RID: 3312
			MovingSeed = 8,
			/// <summary>enum member</summary>
			// Token: 0x04000CF1 RID: 3313
			PlacedSeeds = 4,
			/// <summary>enum member</summary>
			// Token: 0x04000CF2 RID: 3314
			PlacingSeeds = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000CF3 RID: 3315
			Start = 1
		}
	}
}
