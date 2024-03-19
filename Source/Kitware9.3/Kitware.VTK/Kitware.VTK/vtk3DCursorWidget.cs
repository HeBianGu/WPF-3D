using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtk3DCursorWidget
	/// </summary>
	/// <remarks>
	///    Widget reprensenting a 3D cursor.
	///
	/// This cursor is primarily intended to be used when doing stereo rendering.
	/// The cursor is represented by an actor that is added to the scene,
	/// and hence can be rendered in stereo like other actors.
	/// The vtk3DCursorRepresentation class handles the placement of the cursor in the scene,
	/// given the display position of the mouse.
	///
	/// </remarks>
	/// <seealso>
	///  vtk3DCursorRepresentation
	/// </seealso>
	// Token: 0x020002AB RID: 683
	public class vtk3DCursorWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007B5A RID: 31578 RVA: 0x000B1843 File Offset: 0x000AFA43
		static vtk3DCursorWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtk3DCursorWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtk3DCursorWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007B5B RID: 31579 RVA: 0x000B186B File Offset: 0x000AFA6B
		public vtk3DCursorWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007B5C RID: 31580
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtk3DCursorWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007B5D RID: 31581 RVA: 0x000B187C File Offset: 0x000AFA7C
		public new static vtk3DCursorWidget New()
		{
			vtk3DCursorWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtk3DCursorWidget.vtk3DCursorWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtk3DCursorWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007B5E RID: 31582 RVA: 0x000B18D0 File Offset: 0x000AFAD0
		public vtk3DCursorWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtk3DCursorWidget.vtk3DCursorWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007B5F RID: 31583 RVA: 0x000B1914 File Offset: 0x000AFB14
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007B60 RID: 31584
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DCursorWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if no one is set. By default
		/// an instance of vtk3DCursorRepresentation is created.
		/// </summary>
		// Token: 0x06007B61 RID: 31585 RVA: 0x000B191F File Offset: 0x000AFB1F
		public override void CreateDefaultRepresentation()
		{
			vtk3DCursorWidget.vtk3DCursorWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06007B62 RID: 31586
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtk3DCursorWidget_Get3DCursorRepresentation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the widget representation as a vtk3DCursorRepresentation.
		/// </summary>
		// Token: 0x06007B63 RID: 31587 RVA: 0x000B1930 File Offset: 0x000AFB30
		public vtk3DCursorRepresentation Get3DCursorRepresentation()
		{
			vtk3DCursorRepresentation vtk3DCursorRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtk3DCursorWidget.vtk3DCursorWidget_Get3DCursorRepresentation_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtk3DCursorRepresentation = (vtk3DCursorRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtk3DCursorRepresentation.Register(null);
				}
			}
			return vtk3DCursorRepresentation;
		}

		// Token: 0x06007B64 RID: 31588
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtk3DCursorWidget_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007B65 RID: 31589 RVA: 0x000B19A0 File Offset: 0x000AFBA0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtk3DCursorWidget.vtk3DCursorWidget_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06007B66 RID: 31590
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtk3DCursorWidget_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007B67 RID: 31591 RVA: 0x000B19C0 File Offset: 0x000AFBC0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtk3DCursorWidget.vtk3DCursorWidget_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06007B68 RID: 31592
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtk3DCursorWidget_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007B69 RID: 31593 RVA: 0x000B19DC File Offset: 0x000AFBDC
		public override int IsA(string type)
		{
			return vtk3DCursorWidget.vtk3DCursorWidget_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06007B6A RID: 31594
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtk3DCursorWidget_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007B6B RID: 31595 RVA: 0x000B19FC File Offset: 0x000AFBFC
		public new static int IsTypeOf(string type)
		{
			return vtk3DCursorWidget.vtk3DCursorWidget_IsTypeOf_06(type);
		}

		// Token: 0x06007B6C RID: 31596
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtk3DCursorWidget_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007B6D RID: 31597 RVA: 0x000B1A18 File Offset: 0x000AFC18
		public new vtk3DCursorWidget NewInstance()
		{
			vtk3DCursorWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtk3DCursorWidget.vtk3DCursorWidget_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtk3DCursorWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007B6E RID: 31598
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtk3DCursorWidget_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007B6F RID: 31599 RVA: 0x000B1A74 File Offset: 0x000AFC74
		public new static vtk3DCursorWidget SafeDownCast(vtkObjectBase o)
		{
			vtk3DCursorWidget vtk3DCursorWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtk3DCursorWidget.vtk3DCursorWidget_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtk3DCursorWidget = (vtk3DCursorWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtk3DCursorWidget.Register(null);
				}
			}
			return vtk3DCursorWidget;
		}

		// Token: 0x06007B70 RID: 31600
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtk3DCursorWidget_SetRepresentation_10(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that vtkWidgetRepresentation is a subclass
		/// of vtkProp so it can be also added to the renderer directly.
		/// </summary>
		// Token: 0x06007B71 RID: 31601 RVA: 0x000B1AF4 File Offset: 0x000AFCF4
		public void SetRepresentation(vtk3DCursorRepresentation r)
		{
			vtk3DCursorWidget.vtk3DCursorWidget_SetRepresentation_10(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A68 RID: 2664
		public new const string MRFullTypeName = "Kitware.VTK.vtk3DCursorWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A69 RID: 2665
		public new static readonly string MRClassNameKey = "class vtk3DCursorWidget";
	}
}
