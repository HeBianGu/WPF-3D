using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMagnifierWidget
	/// </summary>
	/// <remarks>
	///    create a moving, magnifying renderer that can inspect the contents
	///          of an encapsulating renderer.
	///
	/// This class provides a small, interactive, overlaid viewport (i.e.,
	/// renderer) that follows the mouse while inside another, larger
	/// renderer. Inside this viewport effects like magnification (via zoom or
	/// adjustment of the view angle), or other rendering effects are possible.
	///
	/// To use this widget, pair it with a representation (which provides options
	/// like a border and so on). In the representation, indicate what renderer
	/// with which the magnifier is associated. Optionally, a list of actors can
	/// be provided to the magnifier so that it only renders the actors specified
	/// (this is useful for removing objects like widgets from the scene, or
	/// creating separate pipelines for creating special effects).
	///
	/// By default, the magnifier responds to the keypress "m" to toggle between
	/// showing/hiding the magnifier. Internally, it also follows mouse move events
	/// to track the magnifier with the mouse motion. Finally, using the "-" or "+"
	/// keys can be used to decrease/increase the magnification factor by observing
	/// the "vtkCommand::WidgetValueChangedEvent".
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkMagnifierRepresentation
	/// </seealso>
	// Token: 0x0200033F RID: 831
	public class vtkMagnifierWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060096B3 RID: 38579 RVA: 0x000D5860 File Offset: 0x000D3A60
		static vtkMagnifierWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMagnifierWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMagnifierWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060096B4 RID: 38580 RVA: 0x000D5888 File Offset: 0x000D3A88
		public vtkMagnifierWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060096B5 RID: 38581
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMagnifierWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Method to instantiate class.
		/// </summary>
		// Token: 0x060096B6 RID: 38582 RVA: 0x000D5898 File Offset: 0x000D3A98
		public new static vtkMagnifierWidget New()
		{
			vtkMagnifierWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMagnifierWidget.vtkMagnifierWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMagnifierWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Method to instantiate class.
		/// </summary>
		// Token: 0x060096B7 RID: 38583 RVA: 0x000D58EC File Offset: 0x000D3AEC
		public vtkMagnifierWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMagnifierWidget.vtkMagnifierWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060096B8 RID: 38584 RVA: 0x000D5930 File Offset: 0x000D3B30
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060096B9 RID: 38585
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMagnifierWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x060096BA RID: 38586 RVA: 0x000D593B File Offset: 0x000D3B3B
		public override void CreateDefaultRepresentation()
		{
			vtkMagnifierWidget.vtkMagnifierWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x060096BB RID: 38587
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern sbyte vtkMagnifierWidget_GetKeyPressDecreaseValue_02(HandleRef pThis);

		/// <summary>
		/// By default, the keypress "+" increases magnification, and the keypress
		/// "-" decreases magnification. These can be changed to other key press
		/// values. Note that in either case, these keypresses cause the widget to
		/// emit the "vtkCommand::WidgetValueChangedEvent".
		/// </summary>
		// Token: 0x060096BC RID: 38588 RVA: 0x000D594C File Offset: 0x000D3B4C
		public virtual sbyte GetKeyPressDecreaseValue()
		{
			return vtkMagnifierWidget.vtkMagnifierWidget_GetKeyPressDecreaseValue_02(base.GetCppThis());
		}

		// Token: 0x060096BD RID: 38589
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern sbyte vtkMagnifierWidget_GetKeyPressIncreaseValue_03(HandleRef pThis);

		/// <summary>
		/// By default, the keypress "+" increases magnification, and the keypress
		/// "-" decreases magnification. These can be changed to other key press
		/// values. Note that in either case, these keypresses cause the widget to
		/// emit the "vtkCommand::WidgetValueChangedEvent".
		/// </summary>
		// Token: 0x060096BE RID: 38590 RVA: 0x000D596C File Offset: 0x000D3B6C
		public virtual sbyte GetKeyPressIncreaseValue()
		{
			return vtkMagnifierWidget.vtkMagnifierWidget_GetKeyPressIncreaseValue_03(base.GetCppThis());
		}

		// Token: 0x060096BF RID: 38591
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMagnifierWidget_GetMagnifierRepresentation_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the representation as a vtkBorderRepresentation.
		/// </summary>
		// Token: 0x060096C0 RID: 38592 RVA: 0x000D598C File Offset: 0x000D3B8C
		public vtkMagnifierRepresentation GetMagnifierRepresentation()
		{
			vtkMagnifierRepresentation vtkMagnifierRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMagnifierWidget.vtkMagnifierWidget_GetMagnifierRepresentation_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMagnifierRepresentation = (vtkMagnifierRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMagnifierRepresentation.Register(null);
				}
			}
			return vtkMagnifierRepresentation;
		}

		// Token: 0x060096C1 RID: 38593
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMagnifierWidget_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for class.
		/// </summary>
		// Token: 0x060096C2 RID: 38594 RVA: 0x000D59FC File Offset: 0x000D3BFC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMagnifierWidget.vtkMagnifierWidget_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x060096C3 RID: 38595
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMagnifierWidget_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for class.
		/// </summary>
		// Token: 0x060096C4 RID: 38596 RVA: 0x000D5A1C File Offset: 0x000D3C1C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMagnifierWidget.vtkMagnifierWidget_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x060096C5 RID: 38597
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMagnifierWidget_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for class.
		/// </summary>
		// Token: 0x060096C6 RID: 38598 RVA: 0x000D5A38 File Offset: 0x000D3C38
		public override int IsA(string type)
		{
			return vtkMagnifierWidget.vtkMagnifierWidget_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x060096C7 RID: 38599
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMagnifierWidget_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for class.
		/// </summary>
		// Token: 0x060096C8 RID: 38600 RVA: 0x000D5A58 File Offset: 0x000D3C58
		public new static int IsTypeOf(string type)
		{
			return vtkMagnifierWidget.vtkMagnifierWidget_IsTypeOf_08(type);
		}

		// Token: 0x060096C9 RID: 38601
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMagnifierWidget_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for class.
		/// </summary>
		// Token: 0x060096CA RID: 38602 RVA: 0x000D5A74 File Offset: 0x000D3C74
		public new vtkMagnifierWidget NewInstance()
		{
			vtkMagnifierWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMagnifierWidget.vtkMagnifierWidget_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMagnifierWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060096CB RID: 38603
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMagnifierWidget_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for class.
		/// </summary>
		// Token: 0x060096CC RID: 38604 RVA: 0x000D5AD0 File Offset: 0x000D3CD0
		public new static vtkMagnifierWidget SafeDownCast(vtkObjectBase o)
		{
			vtkMagnifierWidget vtkMagnifierWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMagnifierWidget.vtkMagnifierWidget_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMagnifierWidget = (vtkMagnifierWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMagnifierWidget.Register(null);
				}
			}
			return vtkMagnifierWidget;
		}

		// Token: 0x060096CD RID: 38605
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMagnifierWidget_SetEnabled_12(HandleRef pThis, int enabling);

		/// <summary>
		/// Override superclasses' SetEnabled() method because the this widget
		/// must activate the representation.
		/// </summary>
		// Token: 0x060096CE RID: 38606 RVA: 0x000D5B4F File Offset: 0x000D3D4F
		public override void SetEnabled(int enabling)
		{
			vtkMagnifierWidget.vtkMagnifierWidget_SetEnabled_12(base.GetCppThis(), enabling);
		}

		// Token: 0x060096CF RID: 38607
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMagnifierWidget_SetKeyPressDecreaseValue_13(HandleRef pThis, sbyte _arg);

		/// <summary>
		/// By default, the keypress "+" increases magnification, and the keypress
		/// "-" decreases magnification. These can be changed to other key press
		/// values. Note that in either case, these keypresses cause the widget to
		/// emit the "vtkCommand::WidgetValueChangedEvent".
		/// </summary>
		// Token: 0x060096D0 RID: 38608 RVA: 0x000D5B5F File Offset: 0x000D3D5F
		public virtual void SetKeyPressDecreaseValue(sbyte _arg)
		{
			vtkMagnifierWidget.vtkMagnifierWidget_SetKeyPressDecreaseValue_13(base.GetCppThis(), _arg);
		}

		// Token: 0x060096D1 RID: 38609
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMagnifierWidget_SetKeyPressIncreaseValue_14(HandleRef pThis, sbyte _arg);

		/// <summary>
		/// By default, the keypress "+" increases magnification, and the keypress
		/// "-" decreases magnification. These can be changed to other key press
		/// values. Note that in either case, these keypresses cause the widget to
		/// emit the "vtkCommand::WidgetValueChangedEvent".
		/// </summary>
		// Token: 0x060096D2 RID: 38610 RVA: 0x000D5B6F File Offset: 0x000D3D6F
		public virtual void SetKeyPressIncreaseValue(sbyte _arg)
		{
			vtkMagnifierWidget.vtkMagnifierWidget_SetKeyPressIncreaseValue_14(base.GetCppThis(), _arg);
		}

		// Token: 0x060096D3 RID: 38611
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMagnifierWidget_SetRepresentation_15(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkMagnifierRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x060096D4 RID: 38612 RVA: 0x000D5B80 File Offset: 0x000D3D80
		public void SetRepresentation(vtkMagnifierRepresentation r)
		{
			vtkMagnifierWidget.vtkMagnifierWidget_SetRepresentation_15(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C5B RID: 3163
		public new const string MRFullTypeName = "Kitware.VTK.vtkMagnifierWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C5C RID: 3164
		public new static readonly string MRClassNameKey = "class vtkMagnifierWidget";
	}
}
