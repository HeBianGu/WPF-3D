using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVRPanelWidget
	/// </summary>
	/// <remarks>
	///    3D widget to display a panel/billboard
	///
	/// Handles events for a PanelRepresentation.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkVRPanelRepresentation
	/// </seealso>
	// Token: 0x020000C8 RID: 200
	public class vtkVRPanelWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002B08 RID: 11016 RVA: 0x0003F8B7 File Offset: 0x0003DAB7
		static vtkVRPanelWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVRPanelWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVRPanelWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002B09 RID: 11017 RVA: 0x0003F8DF File Offset: 0x0003DADF
		public vtkVRPanelWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06002B0A RID: 11018
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRPanelWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06002B0B RID: 11019 RVA: 0x0003F8F0 File Offset: 0x0003DAF0
		public new static vtkVRPanelWidget New()
		{
			vtkVRPanelWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRPanelWidget.vtkVRPanelWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVRPanelWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06002B0C RID: 11020 RVA: 0x0003F944 File Offset: 0x0003DB44
		public vtkVRPanelWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVRPanelWidget.vtkVRPanelWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002B0D RID: 11021 RVA: 0x0003F988 File Offset: 0x0003DB88
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002B0E RID: 11022
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRPanelWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x06002B0F RID: 11023 RVA: 0x0003F993 File Offset: 0x0003DB93
		public override void CreateDefaultRepresentation()
		{
			vtkVRPanelWidget.vtkVRPanelWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06002B10 RID: 11024
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRPanelWidget_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06002B11 RID: 11025 RVA: 0x0003F9A4 File Offset: 0x0003DBA4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVRPanelWidget.vtkVRPanelWidget_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06002B12 RID: 11026
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRPanelWidget_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06002B13 RID: 11027 RVA: 0x0003F9C4 File Offset: 0x0003DBC4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVRPanelWidget.vtkVRPanelWidget_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06002B14 RID: 11028
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRPanelWidget_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06002B15 RID: 11029 RVA: 0x0003F9E0 File Offset: 0x0003DBE0
		public override int IsA(string type)
		{
			return vtkVRPanelWidget.vtkVRPanelWidget_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06002B16 RID: 11030
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRPanelWidget_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06002B17 RID: 11031 RVA: 0x0003FA00 File Offset: 0x0003DC00
		public new static int IsTypeOf(string type)
		{
			return vtkVRPanelWidget.vtkVRPanelWidget_IsTypeOf_05(type);
		}

		// Token: 0x06002B18 RID: 11032
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRPanelWidget_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06002B19 RID: 11033 RVA: 0x0003FA1C File Offset: 0x0003DC1C
		public new vtkVRPanelWidget NewInstance()
		{
			vtkVRPanelWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRPanelWidget.vtkVRPanelWidget_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVRPanelWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002B1A RID: 11034
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRPanelWidget_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06002B1B RID: 11035 RVA: 0x0003FA78 File Offset: 0x0003DC78
		public new static vtkVRPanelWidget SafeDownCast(vtkObjectBase o)
		{
			vtkVRPanelWidget vtkVRPanelWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRPanelWidget.vtkVRPanelWidget_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVRPanelWidget = (vtkVRPanelWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVRPanelWidget.Register(null);
				}
			}
			return vtkVRPanelWidget;
		}

		// Token: 0x06002B1C RID: 11036
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRPanelWidget_SetRepresentation_09(HandleRef pThis, HandleRef rep);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x06002B1D RID: 11037 RVA: 0x0003FAF8 File Offset: 0x0003DCF8
		public void SetRepresentation(vtkVRPanelRepresentation rep)
		{
			vtkVRPanelWidget.vtkVRPanelWidget_SetRepresentation_09(base.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000582 RID: 1410
		public new const string MRFullTypeName = "Kitware.VTK.vtkVRPanelWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000583 RID: 1411
		public new static readonly string MRClassNameKey = "class vtkVRPanelWidget";
	}
}
