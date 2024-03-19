using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVRControlsHelper
	/// </summary>
	/// <remarks>
	///    Tooltip helper explaining controls
	/// Helper class to draw one tooltip per button around the controller.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkVRPanelRepresentation
	/// </seealso>
	// Token: 0x020000A4 RID: 164
	public abstract class vtkVRControlsHelper : vtkProp
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002386 RID: 9094 RVA: 0x000353D7 File Offset: 0x000335D7
		static vtkVRControlsHelper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVRControlsHelper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVRControlsHelper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002387 RID: 9095 RVA: 0x000353FF File Offset: 0x000335FF
		public vtkVRControlsHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002388 RID: 9096 RVA: 0x0003540D File Offset: 0x0003360D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002389 RID: 9097
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRControlsHelper_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Methods to interface with the vtkVRPanelWidget.
		/// </summary>
		// Token: 0x0600238A RID: 9098 RVA: 0x00035418 File Offset: 0x00033618
		public void BuildRepresentation()
		{
			vtkVRControlsHelper.vtkVRControlsHelper_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x0600238B RID: 9099
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRControlsHelper_EnabledOff_02(HandleRef pThis);

		/// <summary>
		/// Set Tooltip text (used by TextActor)
		/// </summary>
		// Token: 0x0600238C RID: 9100 RVA: 0x00035427 File Offset: 0x00033627
		public virtual void EnabledOff()
		{
			vtkVRControlsHelper.vtkVRControlsHelper_EnabledOff_02(base.GetCppThis());
		}

		// Token: 0x0600238D RID: 9101
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRControlsHelper_EnabledOn_03(HandleRef pThis);

		/// <summary>
		/// Set Tooltip text (used by TextActor)
		/// </summary>
		// Token: 0x0600238E RID: 9102 RVA: 0x00035436 File Offset: 0x00033636
		public virtual void EnabledOn()
		{
			vtkVRControlsHelper.vtkVRControlsHelper_EnabledOn_03(base.GetCppThis());
		}

		// Token: 0x0600238F RID: 9103
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVRControlsHelper_GetEnabled_04(HandleRef pThis);

		/// <summary>
		/// Set Tooltip text (used by TextActor)
		/// </summary>
		// Token: 0x06002390 RID: 9104 RVA: 0x00035448 File Offset: 0x00033648
		public virtual bool GetEnabled()
		{
			return vtkVRControlsHelper.vtkVRControlsHelper_GetEnabled_04(base.GetCppThis()) != 0;
		}

		// Token: 0x06002391 RID: 9105
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRControlsHelper_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06002392 RID: 9106 RVA: 0x00035470 File Offset: 0x00033670
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVRControlsHelper.vtkVRControlsHelper_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06002393 RID: 9107
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRControlsHelper_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06002394 RID: 9108 RVA: 0x00035490 File Offset: 0x00033690
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVRControlsHelper.vtkVRControlsHelper_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06002395 RID: 9109
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRControlsHelper_GetRenderer_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set Tooltip text (used by TextActor)
		/// </summary>
		// Token: 0x06002396 RID: 9110 RVA: 0x000354AC File Offset: 0x000336AC
		public virtual vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRControlsHelper.vtkVRControlsHelper_GetRenderer_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		// Token: 0x06002397 RID: 9111
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRControlsHelper_HasTranslucentPolygonalGeometry_08(HandleRef pThis);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x06002398 RID: 9112 RVA: 0x0003551C File Offset: 0x0003371C
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkVRControlsHelper.vtkVRControlsHelper_HasTranslucentPolygonalGeometry_08(base.GetCppThis());
		}

		// Token: 0x06002399 RID: 9113
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRControlsHelper_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600239A RID: 9114 RVA: 0x0003553C File Offset: 0x0003373C
		public override int IsA(string type)
		{
			return vtkVRControlsHelper.vtkVRControlsHelper_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0600239B RID: 9115
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRControlsHelper_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600239C RID: 9116 RVA: 0x0003555C File Offset: 0x0003375C
		public new static int IsTypeOf(string type)
		{
			return vtkVRControlsHelper.vtkVRControlsHelper_IsTypeOf_10(type);
		}

		// Token: 0x0600239D RID: 9117
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRControlsHelper_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600239E RID: 9118 RVA: 0x00035578 File Offset: 0x00033778
		public new vtkVRControlsHelper NewInstance()
		{
			vtkVRControlsHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRControlsHelper.vtkVRControlsHelper_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVRControlsHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600239F RID: 9119
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRControlsHelper_ReleaseGraphicsResources_12(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x060023A0 RID: 9120 RVA: 0x000355D4 File Offset: 0x000337D4
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkVRControlsHelper.vtkVRControlsHelper_ReleaseGraphicsResources_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060023A1 RID: 9121
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRControlsHelper_RenderOpaqueGeometry_13(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x060023A2 RID: 9122 RVA: 0x00035604 File Offset: 0x00033804
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkVRControlsHelper.vtkVRControlsHelper_RenderOpaqueGeometry_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060023A3 RID: 9123
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRControlsHelper_RenderTranslucentPolygonalGeometry_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x060023A4 RID: 9124 RVA: 0x00035638 File Offset: 0x00033838
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkVRControlsHelper.vtkVRControlsHelper_RenderTranslucentPolygonalGeometry_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060023A5 RID: 9125
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRControlsHelper_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x060023A6 RID: 9126 RVA: 0x0003566C File Offset: 0x0003386C
		public new static vtkVRControlsHelper SafeDownCast(vtkObjectBase o)
		{
			vtkVRControlsHelper vtkVRControlsHelper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRControlsHelper.vtkVRControlsHelper_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVRControlsHelper = (vtkVRControlsHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVRControlsHelper.Register(null);
				}
			}
			return vtkVRControlsHelper;
		}

		// Token: 0x060023A7 RID: 9127
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRControlsHelper_SetDevice_16(HandleRef pThis, vtkEventDataDevice val);

		/// <summary>
		/// Set Tooltip text (used by TextActor)
		/// </summary>
		// Token: 0x060023A8 RID: 9128 RVA: 0x000356EB File Offset: 0x000338EB
		public void SetDevice(vtkEventDataDevice val)
		{
			vtkVRControlsHelper.vtkVRControlsHelper_SetDevice_16(base.GetCppThis(), val);
		}

		// Token: 0x060023A9 RID: 9129
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRControlsHelper_SetEnabled_17(HandleRef pThis, byte enabled);

		/// <summary>
		/// Set Tooltip text (used by TextActor)
		/// </summary>
		// Token: 0x060023AA RID: 9130 RVA: 0x000356FB File Offset: 0x000338FB
		public void SetEnabled(bool enabled)
		{
			vtkVRControlsHelper.vtkVRControlsHelper_SetEnabled_17(base.GetCppThis(), enabled ? (byte)1 : (byte)0);
		}

		// Token: 0x060023AB RID: 9131
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRControlsHelper_SetRenderer_18(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Set Tooltip text (used by TextActor)
		/// </summary>
		// Token: 0x060023AC RID: 9132 RVA: 0x00035714 File Offset: 0x00033914
		public virtual void SetRenderer(vtkRenderer ren)
		{
			vtkVRControlsHelper.vtkVRControlsHelper_SetRenderer_18(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x060023AD RID: 9133
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRControlsHelper_SetText_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string str);

		/// <summary>
		/// Set Tooltip text (used by TextActor)
		/// </summary>
		// Token: 0x060023AE RID: 9134 RVA: 0x00035743 File Offset: 0x00033943
		public void SetText(string str)
		{
			vtkVRControlsHelper.vtkVRControlsHelper_SetText_19(base.GetCppThis(), str);
		}

		// Token: 0x060023AF RID: 9135
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRControlsHelper_SetTooltipInfo_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string s, int buttonSide, int drawSide, [MarshalAs(UnmanagedType.LPUTF8Str)] string txt);

		/// <summary>
		/// Set Tooltip text (used by TextActor)
		/// </summary>
		// Token: 0x060023B0 RID: 9136 RVA: 0x00035753 File Offset: 0x00033953
		public void SetTooltipInfo(string s, int buttonSide, int drawSide, string txt)
		{
			vtkVRControlsHelper.vtkVRControlsHelper_SetTooltipInfo_20(base.GetCppThis(), s, buttonSide, drawSide, txt);
		}

		// Token: 0x060023B1 RID: 9137
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRControlsHelper_UpdateRepresentation_21(HandleRef pThis);

		/// <summary>
		/// Methods to interface with the vtkVRPanelWidget.
		/// </summary>
		// Token: 0x060023B2 RID: 9138 RVA: 0x00035767 File Offset: 0x00033967
		public void UpdateRepresentation()
		{
			vtkVRControlsHelper.vtkVRControlsHelper_UpdateRepresentation_21(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000529 RID: 1321
		public new const string MRFullTypeName = "Kitware.VTK.vtkVRControlsHelper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400052A RID: 1322
		public new static readonly string MRClassNameKey = "class vtkVRControlsHelper";

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x020000A5 RID: 165
		public enum ButtonSides
		{
			/// <summary>enum member</summary>
			// Token: 0x0400052C RID: 1324
			Back = -1,
			/// <summary>enum member</summary>
			// Token: 0x0400052D RID: 1325
			Front = 1
		}

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x020000A6 RID: 166
		public enum DrawSides
		{
			/// <summary>enum member</summary>
			// Token: 0x0400052F RID: 1327
			Left = -1,
			/// <summary>enum member</summary>
			// Token: 0x04000530 RID: 1328
			Right = 1
		}
	}
}
