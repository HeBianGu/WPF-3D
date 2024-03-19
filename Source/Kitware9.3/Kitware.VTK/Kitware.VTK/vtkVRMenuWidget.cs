using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVRMenuWidget
	/// </summary>
	/// <remarks>
	///    3D widget to display a menu in VR
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkVRMenuRepresentation
	/// </seealso>
	// Token: 0x020000C4 RID: 196
	public class vtkVRMenuWidget : vtkAbstractWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002AA8 RID: 10920 RVA: 0x0003F007 File Offset: 0x0003D207
		static vtkVRMenuWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVRMenuWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVRMenuWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002AA9 RID: 10921 RVA: 0x0003F02F File Offset: 0x0003D22F
		public vtkVRMenuWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06002AAA RID: 10922
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRMenuWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06002AAB RID: 10923 RVA: 0x0003F040 File Offset: 0x0003D240
		public new static vtkVRMenuWidget New()
		{
			vtkVRMenuWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRMenuWidget.vtkVRMenuWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVRMenuWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the object.
		/// </summary>
		// Token: 0x06002AAC RID: 10924 RVA: 0x0003F094 File Offset: 0x0003D294
		public vtkVRMenuWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVRMenuWidget.vtkVRMenuWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002AAD RID: 10925 RVA: 0x0003F0D8 File Offset: 0x0003D2D8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002AAE RID: 10926
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRMenuWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x06002AAF RID: 10927 RVA: 0x0003F0E3 File Offset: 0x0003D2E3
		public override void CreateDefaultRepresentation()
		{
			vtkVRMenuWidget.vtkVRMenuWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06002AB0 RID: 10928
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRMenuWidget_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06002AB1 RID: 10929 RVA: 0x0003F0F4 File Offset: 0x0003D2F4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVRMenuWidget.vtkVRMenuWidget_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06002AB2 RID: 10930
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRMenuWidget_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06002AB3 RID: 10931 RVA: 0x0003F114 File Offset: 0x0003D314
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVRMenuWidget.vtkVRMenuWidget_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06002AB4 RID: 10932
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRMenuWidget_GetWidgetState_04(HandleRef pThis);

		/// <summary>
		/// Get the widget state.
		/// </summary>
		// Token: 0x06002AB5 RID: 10933 RVA: 0x0003F130 File Offset: 0x0003D330
		public virtual int GetWidgetState()
		{
			return vtkVRMenuWidget.vtkVRMenuWidget_GetWidgetState_04(base.GetCppThis());
		}

		// Token: 0x06002AB6 RID: 10934
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRMenuWidget_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06002AB7 RID: 10935 RVA: 0x0003F150 File Offset: 0x0003D350
		public override int IsA(string type)
		{
			return vtkVRMenuWidget.vtkVRMenuWidget_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06002AB8 RID: 10936
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRMenuWidget_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06002AB9 RID: 10937 RVA: 0x0003F170 File Offset: 0x0003D370
		public new static int IsTypeOf(string type)
		{
			return vtkVRMenuWidget.vtkVRMenuWidget_IsTypeOf_06(type);
		}

		// Token: 0x06002ABA RID: 10938
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRMenuWidget_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06002ABB RID: 10939 RVA: 0x0003F18C File Offset: 0x0003D38C
		public new vtkVRMenuWidget NewInstance()
		{
			vtkVRMenuWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRMenuWidget.vtkVRMenuWidget_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVRMenuWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002ABC RID: 10940
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRMenuWidget_PushFrontMenuItem_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string text, HandleRef cmd);

		/// <summary>
		/// Methods to add/remove items to the menu, called by the menu widget
		/// </summary>
		// Token: 0x06002ABD RID: 10941 RVA: 0x0003F1E8 File Offset: 0x0003D3E8
		public void PushFrontMenuItem(string name, string text, vtkCommand cmd)
		{
			vtkVRMenuWidget.vtkVRMenuWidget_PushFrontMenuItem_09(base.GetCppThis(), name, text, (cmd == null) ? default(HandleRef) : cmd.GetCppThis());
		}

		// Token: 0x06002ABE RID: 10942
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRMenuWidget_RemoveAllMenuItems_10(HandleRef pThis);

		/// <summary>
		/// Methods to add/remove items to the menu, called by the menu widget
		/// </summary>
		// Token: 0x06002ABF RID: 10943 RVA: 0x0003F219 File Offset: 0x0003D419
		public void RemoveAllMenuItems()
		{
			vtkVRMenuWidget.vtkVRMenuWidget_RemoveAllMenuItems_10(base.GetCppThis());
		}

		// Token: 0x06002AC0 RID: 10944
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRMenuWidget_RemoveMenuItem_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Methods to add/remove items to the menu, called by the menu widget
		/// </summary>
		// Token: 0x06002AC1 RID: 10945 RVA: 0x0003F228 File Offset: 0x0003D428
		public void RemoveMenuItem(string name)
		{
			vtkVRMenuWidget.vtkVRMenuWidget_RemoveMenuItem_11(base.GetCppThis(), name);
		}

		// Token: 0x06002AC2 RID: 10946
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRMenuWidget_RenameMenuItem_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string text);

		/// <summary>
		/// Methods to add/remove items to the menu, called by the menu widget
		/// </summary>
		// Token: 0x06002AC3 RID: 10947 RVA: 0x0003F238 File Offset: 0x0003D438
		public void RenameMenuItem(string name, string text)
		{
			vtkVRMenuWidget.vtkVRMenuWidget_RenameMenuItem_12(base.GetCppThis(), name, text);
		}

		// Token: 0x06002AC4 RID: 10948
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRMenuWidget_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06002AC5 RID: 10949 RVA: 0x0003F24C File Offset: 0x0003D44C
		public new static vtkVRMenuWidget SafeDownCast(vtkObjectBase o)
		{
			vtkVRMenuWidget vtkVRMenuWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRMenuWidget.vtkVRMenuWidget_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVRMenuWidget = (vtkVRMenuWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVRMenuWidget.Register(null);
				}
			}
			return vtkVRMenuWidget;
		}

		// Token: 0x06002AC6 RID: 10950
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRMenuWidget_SetRepresentation_14(HandleRef pThis, HandleRef rep);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x06002AC7 RID: 10951 RVA: 0x0003F2CC File Offset: 0x0003D4CC
		public void SetRepresentation(vtkVRMenuRepresentation rep)
		{
			vtkVRMenuWidget.vtkVRMenuWidget_SetRepresentation_14(base.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis());
		}

		// Token: 0x06002AC8 RID: 10952
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRMenuWidget_Show_15(HandleRef pThis, HandleRef ed);

		/// <summary>
		/// Methods to add/remove items to the menu, called by the menu widget
		/// </summary>
		// Token: 0x06002AC9 RID: 10953 RVA: 0x0003F2FC File Offset: 0x0003D4FC
		public void Show(vtkEventData ed)
		{
			vtkVRMenuWidget.vtkVRMenuWidget_Show_15(base.GetCppThis(), (ed == null) ? default(HandleRef) : ed.GetCppThis());
		}

		// Token: 0x06002ACA RID: 10954
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRMenuWidget_ShowSubMenu_16(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods to add/remove items to the menu, called by the menu widget
		/// </summary>
		// Token: 0x06002ACB RID: 10955 RVA: 0x0003F32C File Offset: 0x0003D52C
		public void ShowSubMenu(vtkVRMenuWidget arg0)
		{
			vtkVRMenuWidget.vtkVRMenuWidget_ShowSubMenu_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000578 RID: 1400
		public new const string MRFullTypeName = "Kitware.VTK.vtkVRMenuWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000579 RID: 1401
		public new static readonly string MRClassNameKey = "class vtkVRMenuWidget";

		/// <summary>
		/// Get the widget state.
		/// </summary>
		// Token: 0x020000C5 RID: 197
		public enum WidgetStateType
		{
			/// <summary>enum member</summary>
			// Token: 0x0400057B RID: 1403
			Active = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400057C RID: 1404
			Start = 0
		}
	}
}
