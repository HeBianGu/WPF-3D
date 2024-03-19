using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCamera3DWidget
	/// </summary>
	/// <remarks>
	///    3D Widget for manipulating a vtkCamera
	///
	/// This 3D widget interacts with a vtkCamera3DRepresentation class (i.e., it
	/// handles the events that drive its corresponding representation). A nice
	/// feature of vtkCamera3DWidget, like any 3D widget, will work with the current
	/// interactor style. That is, if vtkCamera3DWidget does not handle an event,
	/// then all other registered observers (including the interactor style) have
	/// an opportunity to process the event. Otherwise, the vtkCamera3DWidget will
	/// terminate the processing of the event that it handles.
	///
	/// To use this widget, you pair it with a vtkCamera3DRepresentation
	/// (or a subclass). Various options are available in the representation for
	/// controlling how the widget appears, and how the widget functions.
	///
	/// @par Mouse Event Bindings:
	/// By default, the widget responds to the following VTK events (i.e., it
	/// watches the vtkRenderWindowInteractor for these events):
	/// &lt;pre&gt;
	/// Select and move the camera box to change the camera position.
	/// Select and move the camera cone to change the camera view angle.
	/// Select and move the sphere handles to change the target and view up.
	/// &lt;/pre&gt;
	///
	/// @par Key Event Bindings:
	/// By default, the widget responds to the following key pressed event:
	/// &lt;pre&gt;
	/// 'x' or 'X': set the translation constrained to X axis, or None if
	/// already set to X.
	/// 'y' or 'Y': set the translation constrained to Y axis, or None if
	/// already set to Y.
	/// 'z' or 'Z': set the translation constrained to Z axis, or None if
	/// already set to Z.
	/// 'o' or 'O': remove any translation constraint.
	/// 'a' or 'A': toggle translation of both position and target, or only
	/// one at a time.
	/// 'c' or 'C': toggle frustum visibility.
	/// &lt;/pre&gt;
	///
	/// @warning
	/// This class, and vtkCamera3DRepresentation, are second generation VTK widgets.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCamera3DRepresentation
	/// </seealso>
	// Token: 0x020002E1 RID: 737
	public class vtkCamera3DWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060084A8 RID: 33960 RVA: 0x000BD63D File Offset: 0x000BB83D
		static vtkCamera3DWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCamera3DWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCamera3DWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060084A9 RID: 33961 RVA: 0x000BD665 File Offset: 0x000BB865
		public vtkCamera3DWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060084AA RID: 33962
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera3DWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x060084AB RID: 33963 RVA: 0x000BD674 File Offset: 0x000BB874
		public new static vtkCamera3DWidget New()
		{
			vtkCamera3DWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCamera3DWidget.vtkCamera3DWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCamera3DWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x060084AC RID: 33964 RVA: 0x000BD6C8 File Offset: 0x000BB8C8
		public vtkCamera3DWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCamera3DWidget.vtkCamera3DWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060084AD RID: 33965 RVA: 0x000BD70C File Offset: 0x000BB90C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060084AE RID: 33966
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera3DWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set. By default,
		/// this is an instance of the vtkCamera3DRepresentation class.
		/// </summary>
		// Token: 0x060084AF RID: 33967 RVA: 0x000BD717 File Offset: 0x000BB917
		public override void CreateDefaultRepresentation()
		{
			vtkCamera3DWidget.vtkCamera3DWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x060084B0 RID: 33968
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCamera3DWidget_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x060084B1 RID: 33969 RVA: 0x000BD728 File Offset: 0x000BB928
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCamera3DWidget.vtkCamera3DWidget_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060084B2 RID: 33970
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCamera3DWidget_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x060084B3 RID: 33971 RVA: 0x000BD748 File Offset: 0x000BB948
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCamera3DWidget.vtkCamera3DWidget_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060084B4 RID: 33972
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCamera3DWidget_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x060084B5 RID: 33973 RVA: 0x000BD764 File Offset: 0x000BB964
		public override int IsA(string type)
		{
			return vtkCamera3DWidget.vtkCamera3DWidget_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060084B6 RID: 33974
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCamera3DWidget_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x060084B7 RID: 33975 RVA: 0x000BD784 File Offset: 0x000BB984
		public new static int IsTypeOf(string type)
		{
			return vtkCamera3DWidget.vtkCamera3DWidget_IsTypeOf_05(type);
		}

		// Token: 0x060084B8 RID: 33976
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera3DWidget_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x060084B9 RID: 33977 RVA: 0x000BD7A0 File Offset: 0x000BB9A0
		public new vtkCamera3DWidget NewInstance()
		{
			vtkCamera3DWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCamera3DWidget.vtkCamera3DWidget_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCamera3DWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060084BA RID: 33978
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCamera3DWidget_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x060084BB RID: 33979 RVA: 0x000BD7FC File Offset: 0x000BB9FC
		public new static vtkCamera3DWidget SafeDownCast(vtkObjectBase o)
		{
			vtkCamera3DWidget vtkCamera3DWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCamera3DWidget.vtkCamera3DWidget_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCamera3DWidget = (vtkCamera3DWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCamera3DWidget.Register(null);
				}
			}
			return vtkCamera3DWidget;
		}

		// Token: 0x060084BC RID: 33980
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera3DWidget_SetEnabled_09(HandleRef pThis, int enabling);

		/// <summary>
		/// Override superclasses' SetEnabled() method for
		/// key event registration.
		/// </summary>
		// Token: 0x060084BD RID: 33981 RVA: 0x000BD87B File Offset: 0x000BBA7B
		public override void SetEnabled(int enabling)
		{
			vtkCamera3DWidget.vtkCamera3DWidget_SetEnabled_09(base.GetCppThis(), enabling);
		}

		// Token: 0x060084BE RID: 33982
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCamera3DWidget_SetRepresentation_10(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independently of the widget.
		/// </summary>
		// Token: 0x060084BF RID: 33983 RVA: 0x000BD88C File Offset: 0x000BBA8C
		public void SetRepresentation(vtkCamera3DRepresentation r)
		{
			vtkCamera3DWidget.vtkCamera3DWidget_SetRepresentation_10(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B3E RID: 2878
		public new const string MRFullTypeName = "Kitware.VTK.vtkCamera3DWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B3F RID: 2879
		public new static readonly string MRClassNameKey = "class vtkCamera3DWidget";
	}
}
