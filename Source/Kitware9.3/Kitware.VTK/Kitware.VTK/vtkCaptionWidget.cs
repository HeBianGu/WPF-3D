using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCaptionWidget
	/// </summary>
	/// <remarks>
	///    widget for placing a caption (text plus leader)
	///
	/// This class provides support for interactively placing a caption on the 2D
	/// overlay plane. A caption is defined by some text with a leader (e.g.,
	/// arrow) that points from the text to a point in the scene. The caption is
	/// represented by a vtkCaptionRepresentation. It uses the event bindings of
	/// its superclass (vtkBorderWidget) to control the placement of the text, and
	/// adds the ability to move the attachment point around. In addition, when
	/// the caption text is selected, the widget emits a ActivateEvent that
	/// observers can watch for. This is useful for opening GUI dialogoues to
	/// adjust font characteristics, etc. (Please see the superclass for a
	/// description of event bindings.)
	///
	/// Note that this widget extends the behavior of its superclass
	/// vtkBorderWidget. The end point of the leader can be selected and
	/// moved around with an internal vtkHandleWidget.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkBorderWidget vtkTextWidget
	/// </seealso>
	// Token: 0x020002ED RID: 749
	public class vtkCaptionWidget : vtkBorderWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008693 RID: 34451 RVA: 0x000C0237 File Offset: 0x000BE437
		static vtkCaptionWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCaptionWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCaptionWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008694 RID: 34452 RVA: 0x000C025F File Offset: 0x000BE45F
		public vtkCaptionWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008695 RID: 34453
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCaptionWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06008696 RID: 34454 RVA: 0x000C0270 File Offset: 0x000BE470
		public new static vtkCaptionWidget New()
		{
			vtkCaptionWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCaptionWidget.vtkCaptionWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCaptionWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06008697 RID: 34455 RVA: 0x000C02C4 File Offset: 0x000BE4C4
		public vtkCaptionWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCaptionWidget.vtkCaptionWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008698 RID: 34456 RVA: 0x000C0308 File Offset: 0x000BE508
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008699 RID: 34457
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x0600869A RID: 34458 RVA: 0x000C0313 File Offset: 0x000BE513
		public override void CreateDefaultRepresentation()
		{
			vtkCaptionWidget.vtkCaptionWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x0600869B RID: 34459
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCaptionWidget_GetCaptionActor2D_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a vtkCaptionActor2D to manage. This is convenient, alternative
		/// method to SetRepresentation(). It internally create a vtkCaptionRepresentation
		/// and then invokes vtkCaptionRepresentation::SetCaptionActor2D().
		/// </summary>
		// Token: 0x0600869C RID: 34460 RVA: 0x000C0324 File Offset: 0x000BE524
		public vtkCaptionActor2D GetCaptionActor2D()
		{
			vtkCaptionActor2D vtkCaptionActor2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCaptionWidget.vtkCaptionWidget_GetCaptionActor2D_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCaptionActor2D = (vtkCaptionActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCaptionActor2D.Register(null);
				}
			}
			return vtkCaptionActor2D;
		}

		// Token: 0x0600869D RID: 34461
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCaptionWidget_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x0600869E RID: 34462 RVA: 0x000C0394 File Offset: 0x000BE594
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCaptionWidget.vtkCaptionWidget_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600869F RID: 34463
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCaptionWidget_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x060086A0 RID: 34464 RVA: 0x000C03B4 File Offset: 0x000BE5B4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCaptionWidget.vtkCaptionWidget_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060086A1 RID: 34465
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCaptionWidget_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x060086A2 RID: 34466 RVA: 0x000C03D0 File Offset: 0x000BE5D0
		public override int IsA(string type)
		{
			return vtkCaptionWidget.vtkCaptionWidget_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060086A3 RID: 34467
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCaptionWidget_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x060086A4 RID: 34468 RVA: 0x000C03F0 File Offset: 0x000BE5F0
		public new static int IsTypeOf(string type)
		{
			return vtkCaptionWidget.vtkCaptionWidget_IsTypeOf_06(type);
		}

		// Token: 0x060086A5 RID: 34469
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCaptionWidget_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x060086A6 RID: 34470 RVA: 0x000C040C File Offset: 0x000BE60C
		public new vtkCaptionWidget NewInstance()
		{
			vtkCaptionWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCaptionWidget.vtkCaptionWidget_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCaptionWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060086A7 RID: 34471
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCaptionWidget_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x060086A8 RID: 34472 RVA: 0x000C0468 File Offset: 0x000BE668
		public new static vtkCaptionWidget SafeDownCast(vtkObjectBase o)
		{
			vtkCaptionWidget vtkCaptionWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCaptionWidget.vtkCaptionWidget_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCaptionWidget = (vtkCaptionWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCaptionWidget.Register(null);
				}
			}
			return vtkCaptionWidget;
		}

		// Token: 0x060086A9 RID: 34473
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionWidget_SetCaptionActor2D_10(HandleRef pThis, HandleRef capActor);

		/// <summary>
		/// Specify a vtkCaptionActor2D to manage. This is convenient, alternative
		/// method to SetRepresentation(). It internally create a vtkCaptionRepresentation
		/// and then invokes vtkCaptionRepresentation::SetCaptionActor2D().
		/// </summary>
		// Token: 0x060086AA RID: 34474 RVA: 0x000C04E8 File Offset: 0x000BE6E8
		public void SetCaptionActor2D(vtkCaptionActor2D capActor)
		{
			vtkCaptionWidget.vtkCaptionWidget_SetCaptionActor2D_10(base.GetCppThis(), (capActor == null) ? default(HandleRef) : capActor.GetCppThis());
		}

		// Token: 0x060086AB RID: 34475
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionWidget_SetEnabled_11(HandleRef pThis, int enabling);

		/// <summary>
		/// Override superclasses' SetEnabled() method because the caption leader
		/// has its own dedicated widget.
		/// </summary>
		// Token: 0x060086AC RID: 34476 RVA: 0x000C0517 File Offset: 0x000BE717
		public override void SetEnabled(int enabling)
		{
			vtkCaptionWidget.vtkCaptionWidget_SetEnabled_11(base.GetCppThis(), enabling);
		}

		// Token: 0x060086AD RID: 34477
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCaptionWidget_SetRepresentation_12(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x060086AE RID: 34478 RVA: 0x000C0528 File Offset: 0x000BE728
		public void SetRepresentation(vtkCaptionRepresentation r)
		{
			vtkCaptionWidget.vtkCaptionWidget_SetRepresentation_12(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B5B RID: 2907
		public new const string MRFullTypeName = "Kitware.VTK.vtkCaptionWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B5C RID: 2908
		public new static readonly string MRClassNameKey = "class vtkCaptionWidget";
	}
}
