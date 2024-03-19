using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLightWidget
	/// </summary>
	/// <remarks>
	///    3D widget for showing a LightRepresentation
	///
	/// To use this widget, one generally pairs it with a
	/// vtkLightRepresentation. Various options are available in the representation
	/// for controlling how the widget appears, and how it functions.
	///
	/// @par Event Bindings:
	/// By default, the widget responds to the following VTK events (i.e., it
	/// watches the vtkRenderWindowInteractor for these events):
	/// &lt;pre&gt;
	/// Select and move the sphere to change the light position.
	/// Select and move the cone or the line to change the focal point.
	/// Right-Click and scale on the cone to change the cone angle.
	/// &lt;/pre&gt;
	///
	/// @warning
	/// Note that the widget can be picked even when it is "behind"
	/// other actors.  This is an intended feature and not a bug.
	///
	/// @warning
	/// This class, and vtkLightRepresentation, are second generation VTK widgets.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkLightRepresentation vtkSphereWidget
	/// </seealso>
	// Token: 0x02000334 RID: 820
	public class vtkLightWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060094F5 RID: 38133 RVA: 0x000D2E0B File Offset: 0x000D100B
		static vtkLightWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLightWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLightWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060094F6 RID: 38134 RVA: 0x000D2E33 File Offset: 0x000D1033
		public vtkLightWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060094F7 RID: 38135
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060094F8 RID: 38136 RVA: 0x000D2E44 File Offset: 0x000D1044
		public new static vtkLightWidget New()
		{
			vtkLightWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightWidget.vtkLightWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLightWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060094F9 RID: 38137 RVA: 0x000D2E98 File Offset: 0x000D1098
		public vtkLightWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLightWidget.vtkLightWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060094FA RID: 38138 RVA: 0x000D2EDC File Offset: 0x000D10DC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060094FB RID: 38139
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x060094FC RID: 38140 RVA: 0x000D2EE7 File Offset: 0x000D10E7
		public override void CreateDefaultRepresentation()
		{
			vtkLightWidget.vtkLightWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x060094FD RID: 38141
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightWidget_GetLightRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the representation as a vtkLightRepresentation.
		/// </summary>
		// Token: 0x060094FE RID: 38142 RVA: 0x000D2EF8 File Offset: 0x000D10F8
		public vtkLightRepresentation GetLightRepresentation()
		{
			vtkLightRepresentation vtkLightRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightWidget.vtkLightWidget_GetLightRepresentation_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLightRepresentation = (vtkLightRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLightRepresentation.Register(null);
				}
			}
			return vtkLightRepresentation;
		}

		// Token: 0x060094FF RID: 38143
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLightWidget_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009500 RID: 38144 RVA: 0x000D2F68 File Offset: 0x000D1168
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLightWidget.vtkLightWidget_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06009501 RID: 38145
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLightWidget_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009502 RID: 38146 RVA: 0x000D2F88 File Offset: 0x000D1188
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLightWidget.vtkLightWidget_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06009503 RID: 38147
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLightWidget_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009504 RID: 38148 RVA: 0x000D2FA4 File Offset: 0x000D11A4
		public override int IsA(string type)
		{
			return vtkLightWidget.vtkLightWidget_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06009505 RID: 38149
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLightWidget_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009506 RID: 38150 RVA: 0x000D2FC4 File Offset: 0x000D11C4
		public new static int IsTypeOf(string type)
		{
			return vtkLightWidget.vtkLightWidget_IsTypeOf_06(type);
		}

		// Token: 0x06009507 RID: 38151
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightWidget_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009508 RID: 38152 RVA: 0x000D2FE0 File Offset: 0x000D11E0
		public new vtkLightWidget NewInstance()
		{
			vtkLightWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightWidget.vtkLightWidget_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLightWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009509 RID: 38153
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightWidget_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600950A RID: 38154 RVA: 0x000D303C File Offset: 0x000D123C
		public new static vtkLightWidget SafeDownCast(vtkObjectBase o)
		{
			vtkLightWidget vtkLightWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightWidget.vtkLightWidget_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLightWidget = (vtkLightWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLightWidget.Register(null);
				}
			}
			return vtkLightWidget;
		}

		// Token: 0x0600950B RID: 38155
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightWidget_SetRepresentation_10(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x0600950C RID: 38156 RVA: 0x000D30BC File Offset: 0x000D12BC
		public void SetRepresentation(vtkLightRepresentation r)
		{
			vtkLightWidget.vtkLightWidget_SetRepresentation_10(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C3B RID: 3131
		public new const string MRFullTypeName = "Kitware.VTK.vtkLightWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C3C RID: 3132
		public new static readonly string MRClassNameKey = "class vtkLightWidget";
	}
}
