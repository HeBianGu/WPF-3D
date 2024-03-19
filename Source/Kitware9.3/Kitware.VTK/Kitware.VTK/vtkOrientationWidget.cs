using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOrientationWidget
	/// </summary>
	/// <remarks>
	///    3D Widget for manipulating a vtkCamera
	///
	/// This 3D widget interacts with a vtkOrientationRepresentation class (i.e., it
	/// handles the events that drive its corresponding representation). A nice
	/// feature of vtkOrientationWidget, like any 3D widget, will work with the current
	/// interactor style. That is, if vtkOrientationWidget does not handle an event,
	/// then all other registered observers (including the interactor style) have
	/// an opportunity to process the event. Otherwise, the vtkOrientationWidget will
	/// terminate the processing of the event that it handles.
	///
	/// To use this widget, you pair it with a vtkOrientationRepresentation
	/// (or a subclass). Various options are available in the representation for
	/// controlling how the widget appears, and how the widget functions.
	///
	/// @par Mouse Event Bindings:
	/// By default, the widget responds to the following VTK events (i.e., it
	/// watches the vtkRenderWindowInteractor for these events):
	/// &lt;pre&gt;
	/// Select and move a torus to update the associated orientation.
	/// Select and move an arrow to update the associated orientation.
	/// &lt;/pre&gt;
	///
	/// @warning
	/// This class, and vtkOrientationRepresentation, are second generation VTK widgets.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkOrientationRepresentation
	/// </seealso>
	// Token: 0x02000345 RID: 837
	public class vtkOrientationWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009831 RID: 38961 RVA: 0x000D767A File Offset: 0x000D587A
		static vtkOrientationWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOrientationWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOrientationWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009832 RID: 38962 RVA: 0x000D76A2 File Offset: 0x000D58A2
		public vtkOrientationWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06009833 RID: 38963
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientationWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009834 RID: 38964 RVA: 0x000D76B0 File Offset: 0x000D58B0
		public new static vtkOrientationWidget New()
		{
			vtkOrientationWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientationWidget.vtkOrientationWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOrientationWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009835 RID: 38965 RVA: 0x000D7704 File Offset: 0x000D5904
		public vtkOrientationWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOrientationWidget.vtkOrientationWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009836 RID: 38966 RVA: 0x000D7748 File Offset: 0x000D5948
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009837 RID: 38967
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set. By default,
		/// this is an instance of the vtkOrientationRepresentation class.
		/// </summary>
		// Token: 0x06009838 RID: 38968 RVA: 0x000D7753 File Offset: 0x000D5953
		public override void CreateDefaultRepresentation()
		{
			vtkOrientationWidget.vtkOrientationWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06009839 RID: 38969
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrientationWidget_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600983A RID: 38970 RVA: 0x000D7764 File Offset: 0x000D5964
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOrientationWidget.vtkOrientationWidget_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600983B RID: 38971
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrientationWidget_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600983C RID: 38972 RVA: 0x000D7784 File Offset: 0x000D5984
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOrientationWidget.vtkOrientationWidget_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600983D RID: 38973
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientationWidget_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x0600983E RID: 38974 RVA: 0x000D77A0 File Offset: 0x000D59A0
		public override int IsA(string type)
		{
			return vtkOrientationWidget.vtkOrientationWidget_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600983F RID: 38975
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrientationWidget_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009840 RID: 38976 RVA: 0x000D77C0 File Offset: 0x000D59C0
		public new static int IsTypeOf(string type)
		{
			return vtkOrientationWidget.vtkOrientationWidget_IsTypeOf_05(type);
		}

		// Token: 0x06009841 RID: 38977
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientationWidget_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009842 RID: 38978 RVA: 0x000D77DC File Offset: 0x000D59DC
		public new vtkOrientationWidget NewInstance()
		{
			vtkOrientationWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientationWidget.vtkOrientationWidget_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOrientationWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009843 RID: 38979
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrientationWidget_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06009844 RID: 38980 RVA: 0x000D7838 File Offset: 0x000D5A38
		public new static vtkOrientationWidget SafeDownCast(vtkObjectBase o)
		{
			vtkOrientationWidget vtkOrientationWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrientationWidget.vtkOrientationWidget_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOrientationWidget = (vtkOrientationWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOrientationWidget.Register(null);
				}
			}
			return vtkOrientationWidget;
		}

		// Token: 0x06009845 RID: 38981
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrientationWidget_SetRepresentation_09(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independently of the widget.
		/// </summary>
		// Token: 0x06009846 RID: 38982 RVA: 0x000D78B8 File Offset: 0x000D5AB8
		public void SetRepresentation(vtkOrientationRepresentation r)
		{
			vtkOrientationWidget.vtkOrientationWidget_SetRepresentation_09(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C6C RID: 3180
		public new const string MRFullTypeName = "Kitware.VTK.vtkOrientationWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C6D RID: 3181
		public new static readonly string MRClassNameKey = "class vtkOrientationWidget";
	}
}
