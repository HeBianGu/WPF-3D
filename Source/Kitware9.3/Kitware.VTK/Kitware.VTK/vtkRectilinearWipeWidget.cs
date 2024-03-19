using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRectilinearWipeWidget
	/// </summary>
	/// <remarks>
	///    interactively control an instance of vtkImageRectilinearWipe filter
	///
	/// The vtkRectilinearWipeWidget is used to interactively control an instance
	/// of vtkImageRectilinearWipe (and an associated vtkImageActor used to
	/// display the rectilinear wipe). A rectilinear wipe is a 2x2 checkerboard
	/// pattern created by combining two separate images, where various
	/// combinations of the checker squares are possible. Using this widget, the
	/// user can adjust the layout of the checker pattern, such as moving the
	/// center point, moving the horizontal separator, or moving the vertical
	/// separator. These capabilities are particularly useful for comparing two
	/// images.
	///
	/// To use this widget, specify its representation (by default the
	/// representation is an instance of vtkRectilinearWipeProp). The
	/// representation generally requires that you specify an instance of
	/// vtkImageRectilinearWipe and an instance of vtkImageActor. Other instance
	/// variables may also be required to be set -- see the documentation for
	/// vtkRectilinearWipeProp (or appropriate subclass).
	///
	/// By default, the widget responds to the following events:
	/// &lt;pre&gt;
	/// Selecting the center point, horizontal separator, and verticel separator:
	///   LeftButtonPressEvent - move the separators
	///   LeftButtonReleaseEvent - release the separators
	///   MouseMoveEvent - move the separators
	/// &lt;/pre&gt;
	/// Selecting the center point allows you to move the horizontal and vertical
	/// separators simultaneously. Otherwise only horizontal or vertical motion
	/// is possible/
	///
	/// Note that the event bindings described above can be changed using this
	/// class's vtkWidgetEventTranslator. This class translates VTK events into
	/// the vtkRectilinearWipeWidget's widget events:
	/// &lt;pre&gt;
	///   vtkWidgetEvent::Select -- some part of the widget has been selected
	///   vtkWidgetEvent::EndSelect -- the selection process has completed
	///   vtkWidgetEvent::Move -- a request for motion has been invoked
	/// &lt;/pre&gt;
	///
	/// In turn, when these widget events are processed, the
	/// vtkRectilinearWipeWidget invokes the following VTK events (which
	/// observers can listen for):
	/// &lt;pre&gt;
	///   vtkCommand::StartInteractionEvent (on vtkWidgetEvent::Select)
	///   vtkCommand::EndInteractionEvent (on vtkWidgetEvent::EndSelect)
	///   vtkCommand::InteractionEvent (on vtkWidgetEvent::Move)
	/// &lt;/pre&gt;
	///
	/// @warning
	/// The appearance of this widget is defined by its representation, including
	/// any properties associated with the representation.  The widget
	/// representation is a type of vtkProp that defines a particular API that
	/// works with this widget. If desired, the vtkProp may be subclassed to
	/// create new looks for the widget.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRectilinearWipeProp vtkImageRectilinearWipe vtkImageActor
	/// vtkCheckerboardWidget
	/// </seealso>
	// Token: 0x02000361 RID: 865
	public class vtkRectilinearWipeWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009D48 RID: 40264 RVA: 0x000DEE2B File Offset: 0x000DD02B
		static vtkRectilinearWipeWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRectilinearWipeWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectilinearWipeWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009D49 RID: 40265 RVA: 0x000DEE53 File Offset: 0x000DD053
		public vtkRectilinearWipeWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06009D4A RID: 40266
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearWipeWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06009D4B RID: 40267 RVA: 0x000DEE64 File Offset: 0x000DD064
		public new static vtkRectilinearWipeWidget New()
		{
			vtkRectilinearWipeWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearWipeWidget.vtkRectilinearWipeWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearWipeWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06009D4C RID: 40268 RVA: 0x000DEEB8 File Offset: 0x000DD0B8
		public vtkRectilinearWipeWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRectilinearWipeWidget.vtkRectilinearWipeWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009D4D RID: 40269 RVA: 0x000DEEFC File Offset: 0x000DD0FC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009D4E RID: 40270
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearWipeWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x06009D4F RID: 40271 RVA: 0x000DEF07 File Offset: 0x000DD107
		public override void CreateDefaultRepresentation()
		{
			vtkRectilinearWipeWidget.vtkRectilinearWipeWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06009D50 RID: 40272
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearWipeWidget_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x06009D51 RID: 40273 RVA: 0x000DEF18 File Offset: 0x000DD118
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRectilinearWipeWidget.vtkRectilinearWipeWidget_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06009D52 RID: 40274
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearWipeWidget_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x06009D53 RID: 40275 RVA: 0x000DEF38 File Offset: 0x000DD138
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRectilinearWipeWidget.vtkRectilinearWipeWidget_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06009D54 RID: 40276
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearWipeWidget_GetRectilinearWipeRepresentation_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the representation as a vtkRectilinearWipeRepresentation.
		/// </summary>
		// Token: 0x06009D55 RID: 40277 RVA: 0x000DEF54 File Offset: 0x000DD154
		public vtkRectilinearWipeRepresentation GetRectilinearWipeRepresentation()
		{
			vtkRectilinearWipeRepresentation vtkRectilinearWipeRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearWipeWidget.vtkRectilinearWipeWidget_GetRectilinearWipeRepresentation_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearWipeRepresentation = (vtkRectilinearWipeRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearWipeRepresentation.Register(null);
				}
			}
			return vtkRectilinearWipeRepresentation;
		}

		// Token: 0x06009D56 RID: 40278
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearWipeWidget_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x06009D57 RID: 40279 RVA: 0x000DEFC4 File Offset: 0x000DD1C4
		public override int IsA(string type)
		{
			return vtkRectilinearWipeWidget.vtkRectilinearWipeWidget_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06009D58 RID: 40280
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearWipeWidget_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x06009D59 RID: 40281 RVA: 0x000DEFE4 File Offset: 0x000DD1E4
		public new static int IsTypeOf(string type)
		{
			return vtkRectilinearWipeWidget.vtkRectilinearWipeWidget_IsTypeOf_06(type);
		}

		// Token: 0x06009D5A RID: 40282
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearWipeWidget_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x06009D5B RID: 40283 RVA: 0x000DF000 File Offset: 0x000DD200
		public new vtkRectilinearWipeWidget NewInstance()
		{
			vtkRectilinearWipeWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearWipeWidget.vtkRectilinearWipeWidget_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearWipeWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009D5C RID: 40284
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearWipeWidget_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x06009D5D RID: 40285 RVA: 0x000DF05C File Offset: 0x000DD25C
		public new static vtkRectilinearWipeWidget SafeDownCast(vtkObjectBase o)
		{
			vtkRectilinearWipeWidget vtkRectilinearWipeWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearWipeWidget.vtkRectilinearWipeWidget_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearWipeWidget = (vtkRectilinearWipeWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearWipeWidget.Register(null);
				}
			}
			return vtkRectilinearWipeWidget;
		}

		// Token: 0x06009D5E RID: 40286
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRectilinearWipeWidget_SetRepresentation_10(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x06009D5F RID: 40287 RVA: 0x000DF0DC File Offset: 0x000DD2DC
		public void SetRepresentation(vtkRectilinearWipeRepresentation r)
		{
			vtkRectilinearWipeWidget.vtkRectilinearWipeWidget_SetRepresentation_10(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CB8 RID: 3256
		public new const string MRFullTypeName = "Kitware.VTK.vtkRectilinearWipeWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CB9 RID: 3257
		public new static readonly string MRClassNameKey = "class vtkRectilinearWipeWidget";
	}
}
