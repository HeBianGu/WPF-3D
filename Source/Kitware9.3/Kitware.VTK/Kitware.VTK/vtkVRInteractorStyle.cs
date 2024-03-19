using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVRInteractorStyle
	/// </summary>
	/// <remarks>
	///    Extended from vtkInteractorStyle3D to override command methods.
	///
	/// This abstract class defines an interactor style in a virtual reality context.
	/// </remarks>
	// Token: 0x020000B2 RID: 178
	public abstract class vtkVRInteractorStyle : vtkInteractorStyle3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600271E RID: 10014 RVA: 0x00039DD8 File Offset: 0x00037FD8
		static vtkVRInteractorStyle()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVRInteractorStyle.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVRInteractorStyle"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600271F RID: 10015 RVA: 0x00039E00 File Offset: 0x00038000
		public vtkVRInteractorStyle(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002720 RID: 10016 RVA: 0x00039E0E File Offset: 0x0003800E
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002721 RID: 10017
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_AddTooltipForInput_01(HandleRef pThis, vtkEventDataDevice device, vtkEventDataDeviceInput input, [MarshalAs(UnmanagedType.LPUTF8Str)] string text);

		/// <summary>
		/// Define the helper text that goes with an input.
		/// </summary>
		// Token: 0x06002722 RID: 10018 RVA: 0x00039E19 File Offset: 0x00038019
		public void AddTooltipForInput(vtkEventDataDevice device, vtkEventDataDeviceInput input, string text)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_AddTooltipForInput_01(base.GetCppThis(), device, input, text);
		}

		// Token: 0x06002723 RID: 10019
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_Clip_02(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods for interaction.
		/// </summary>
		// Token: 0x06002724 RID: 10020 RVA: 0x00039E2C File Offset: 0x0003802C
		public void Clip(vtkEventDataDevice3D arg0)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_Clip_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002725 RID: 10021
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_Elevation3D_03(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Move the camera following the "Z" axis (elevation) using the thumbstick/trackpad
		/// position (up/down).
		/// </summary>
		// Token: 0x06002726 RID: 10022 RVA: 0x00039E5C File Offset: 0x0003805C
		public void Elevation3D(vtkEventDataDevice3D arg0)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_Elevation3D_03(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002727 RID: 10023
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_EndClip_04(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Interaction mode entry points.
		/// </summary>
		// Token: 0x06002728 RID: 10024 RVA: 0x00039E8C File Offset: 0x0003808C
		public void EndClip(vtkEventDataDevice3D arg0)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_EndClip_04(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002729 RID: 10025
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_EndLoadCamPose_05(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Interaction mode entry points.
		/// </summary>
		// Token: 0x0600272A RID: 10026 RVA: 0x00039EBC File Offset: 0x000380BC
		public void EndLoadCamPose(vtkEventDataDevice3D arg0)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_EndLoadCamPose_05(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600272B RID: 10027
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_EndMovement3D_06(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Interaction mode entry points.
		/// </summary>
		// Token: 0x0600272C RID: 10028 RVA: 0x00039EEC File Offset: 0x000380EC
		public void EndMovement3D(vtkEventDataDevice3D arg0)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_EndMovement3D_06(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600272D RID: 10029
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_EndPick_07(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Interaction mode entry points.
		/// </summary>
		// Token: 0x0600272E RID: 10030 RVA: 0x00039F1C File Offset: 0x0003811C
		public void EndPick(vtkEventDataDevice3D arg0)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_EndPick_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600272F RID: 10031
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_EndPositionProp_08(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Interaction mode entry points.
		/// </summary>
		// Token: 0x06002730 RID: 10032 RVA: 0x00039F4C File Offset: 0x0003814C
		public void EndPositionProp(vtkEventDataDevice3D arg0)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_EndPositionProp_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002731 RID: 10033
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVRInteractorStyle_GetGrabWithRay_09(HandleRef pThis);

		/// <summary>
		/// Specify if the grab mode uses the ray to grab distant objects.
		/// Default is set to on.
		/// </summary>
		// Token: 0x06002732 RID: 10034 RVA: 0x00039F7C File Offset: 0x0003817C
		public virtual bool GetGrabWithRay()
		{
			return vtkVRInteractorStyle.vtkVRInteractorStyle_GetGrabWithRay_09(base.GetCppThis()) != 0;
		}

		// Token: 0x06002733 RID: 10035
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVRInteractorStyle_GetHoverPick_10(HandleRef pThis);

		/// <summary>
		/// Indicates if picking should be updated every frame. If so, the interaction
		/// picker will try to pick a prop and rays will be updated accordingly.
		/// Default is set to off.
		/// </summary>
		// Token: 0x06002734 RID: 10036 RVA: 0x00039FA4 File Offset: 0x000381A4
		public virtual bool GetHoverPick()
		{
			return vtkVRInteractorStyle.vtkVRInteractorStyle_GetHoverPick_10(base.GetCppThis()) != 0;
		}

		// Token: 0x06002735 RID: 10037
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRInteractorStyle_GetInteractionState_11(HandleRef pThis, vtkEventDataDevice device);

		/// <summary>
		/// Return interaction state for the specified device (dolly, pick, none, etc...).
		/// </summary>
		// Token: 0x06002736 RID: 10038 RVA: 0x00039FCC File Offset: 0x000381CC
		public int GetInteractionState(vtkEventDataDevice device)
		{
			return vtkVRInteractorStyle.vtkVRInteractorStyle_GetInteractionState_11(base.GetCppThis(), device);
		}

		// Token: 0x06002737 RID: 10039
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRInteractorStyle_GetMenu_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the menu to allow the user to add options to it.
		/// </summary>
		// Token: 0x06002738 RID: 10040 RVA: 0x00039FEC File Offset: 0x000381EC
		public vtkVRMenuWidget GetMenu()
		{
			vtkVRMenuWidget vtkVRMenuWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRInteractorStyle.vtkVRInteractorStyle_GetMenu_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06002739 RID: 10041
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRInteractorStyle_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600273A RID: 10042 RVA: 0x0003A05C File Offset: 0x0003825C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVRInteractorStyle.vtkVRInteractorStyle_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x0600273B RID: 10043
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRInteractorStyle_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600273C RID: 10044 RVA: 0x0003A07C File Offset: 0x0003827C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVRInteractorStyle.vtkVRInteractorStyle_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x0600273D RID: 10045
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkVRInteractorStyle.MovementStyle vtkVRInteractorStyle_GetStyle_15(HandleRef pThis);

		/// <summary>
		/// Specify the movement style between 'Flying" and "Grounded".
		/// Default is Flying.
		/// </summary>
		// Token: 0x0600273E RID: 10046 RVA: 0x0003A098 File Offset: 0x00038298
		public virtual vtkVRInteractorStyle.MovementStyle GetStyle()
		{
			return vtkVRInteractorStyle.vtkVRInteractorStyle_GetStyle_15(base.GetCppThis());
		}

		// Token: 0x0600273F RID: 10047
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_GrabWithRayOff_16(HandleRef pThis);

		/// <summary>
		/// Specify if the grab mode uses the ray to grab distant objects.
		/// Default is set to on.
		/// </summary>
		// Token: 0x06002740 RID: 10048 RVA: 0x0003A0B7 File Offset: 0x000382B7
		public virtual void GrabWithRayOff()
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_GrabWithRayOff_16(base.GetCppThis());
		}

		// Token: 0x06002741 RID: 10049
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_GrabWithRayOn_17(HandleRef pThis);

		/// <summary>
		/// Specify if the grab mode uses the ray to grab distant objects.
		/// Default is set to on.
		/// </summary>
		// Token: 0x06002742 RID: 10050 RVA: 0x0003A0C6 File Offset: 0x000382C6
		public virtual void GrabWithRayOn()
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_GrabWithRayOn_17(base.GetCppThis());
		}

		// Token: 0x06002743 RID: 10051
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_GroundMovement3D_18(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Move the camera on the "XY" plan (ground) using the thumbstick/trackpad position
		/// (up/down and left/right), according to the headset view direction.
		/// </summary>
		// Token: 0x06002744 RID: 10052 RVA: 0x0003A0D8 File Offset: 0x000382D8
		public void GroundMovement3D(vtkEventDataDevice3D arg0)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_GroundMovement3D_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002745 RID: 10053
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_HideBillboard_19(HandleRef pThis);

		/// <summary>
		/// Show/hide billboard with given text string.
		/// </summary>
		// Token: 0x06002746 RID: 10054 RVA: 0x0003A107 File Offset: 0x00038307
		public void HideBillboard()
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_HideBillboard_19(base.GetCppThis());
		}

		// Token: 0x06002747 RID: 10055
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_HidePickActor_20(HandleRef pThis);

		/// <summary>
		/// Hide the pick actor (sphere or polydata).
		/// </summary>
		// Token: 0x06002748 RID: 10056 RVA: 0x0003A116 File Offset: 0x00038316
		public void HidePickActor()
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_HidePickActor_20(base.GetCppThis());
		}

		// Token: 0x06002749 RID: 10057
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_HideRay_21(HandleRef pThis, vtkEventDataDevice controller);

		/// <summary>
		/// Show/hide the ray for the specified controller.
		/// </summary>
		// Token: 0x0600274A RID: 10058 RVA: 0x0003A125 File Offset: 0x00038325
		public void HideRay(vtkEventDataDevice controller)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_HideRay_21(base.GetCppThis(), controller);
		}

		// Token: 0x0600274B RID: 10059
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_HoverPickOff_22(HandleRef pThis);

		/// <summary>
		/// Indicates if picking should be updated every frame. If so, the interaction
		/// picker will try to pick a prop and rays will be updated accordingly.
		/// Default is set to off.
		/// </summary>
		// Token: 0x0600274C RID: 10060 RVA: 0x0003A135 File Offset: 0x00038335
		public virtual void HoverPickOff()
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_HoverPickOff_22(base.GetCppThis());
		}

		// Token: 0x0600274D RID: 10061
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_HoverPickOn_23(HandleRef pThis);

		/// <summary>
		/// Indicates if picking should be updated every frame. If so, the interaction
		/// picker will try to pick a prop and rays will be updated accordingly.
		/// Default is set to off.
		/// </summary>
		// Token: 0x0600274E RID: 10062 RVA: 0x0003A144 File Offset: 0x00038344
		public virtual void HoverPickOn()
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_HoverPickOn_23(base.GetCppThis());
		}

		// Token: 0x0600274F RID: 10063
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRInteractorStyle_IsA_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002750 RID: 10064 RVA: 0x0003A154 File Offset: 0x00038354
		public override int IsA(string type)
		{
			return vtkVRInteractorStyle.vtkVRInteractorStyle_IsA_24(base.GetCppThis(), type);
		}

		// Token: 0x06002751 RID: 10065
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRInteractorStyle_IsTypeOf_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002752 RID: 10066 RVA: 0x0003A174 File Offset: 0x00038374
		public new static int IsTypeOf(string type)
		{
			return vtkVRInteractorStyle.vtkVRInteractorStyle_IsTypeOf_25(type);
		}

		// Token: 0x06002753 RID: 10067
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_LoadNextCameraPose_26(HandleRef pThis);

		/// <summary>
		/// Methods for interaction.
		/// </summary>
		// Token: 0x06002754 RID: 10068 RVA: 0x0003A18E File Offset: 0x0003838E
		public virtual void LoadNextCameraPose()
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_LoadNextCameraPose_26(base.GetCppThis());
		}

		// Token: 0x06002755 RID: 10069
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRInteractorStyle_MakeControlsHelper_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a new ControlsHelper suitable for use with the child class.
		/// </summary>
		// Token: 0x06002756 RID: 10070 RVA: 0x0003A1A0 File Offset: 0x000383A0
		public virtual vtkVRControlsHelper MakeControlsHelper()
		{
			vtkVRControlsHelper vtkVRControlsHelper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRInteractorStyle.vtkVRInteractorStyle_MakeControlsHelper_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06002757 RID: 10071
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_MapInputToAction_28(HandleRef pThis, vtkCommand.EventIds eid, int state);

		/// <summary>
		/// Map controller inputs to actions.
		/// Actions are defined by a VTKIS_*STATE*, interaction entry points,
		/// and the corresponding method for interaction.
		/// </summary>
		// Token: 0x06002758 RID: 10072 RVA: 0x0003A20F File Offset: 0x0003840F
		public void MapInputToAction(vtkCommand.EventIds eid, int state)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_MapInputToAction_28(base.GetCppThis(), eid, state);
		}

		// Token: 0x06002759 RID: 10073
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_MapInputToAction_29(HandleRef pThis, vtkCommand.EventIds eid, vtkEventDataAction action, int state);

		/// <summary>
		/// Map controller inputs to actions.
		/// Actions are defined by a VTKIS_*STATE*, interaction entry points,
		/// and the corresponding method for interaction.
		/// </summary>
		// Token: 0x0600275A RID: 10074 RVA: 0x0003A220 File Offset: 0x00038420
		public void MapInputToAction(vtkCommand.EventIds eid, vtkEventDataAction action, int state)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_MapInputToAction_29(base.GetCppThis(), eid, action, state);
		}

		// Token: 0x0600275B RID: 10075
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRInteractorStyle_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600275C RID: 10076 RVA: 0x0003A234 File Offset: 0x00038434
		public new vtkVRInteractorStyle NewInstance()
		{
			vtkVRInteractorStyle result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRInteractorStyle.vtkVRInteractorStyle_NewInstance_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVRInteractorStyle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600275D RID: 10077
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_OnElevation3D_31(HandleRef pThis, HandleRef edata);

		/// <summary>
		/// Override generic event bindings to call the corresponding action.
		/// </summary>
		// Token: 0x0600275E RID: 10078 RVA: 0x0003A290 File Offset: 0x00038490
		public override void OnElevation3D(vtkEventData edata)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_OnElevation3D_31(base.GetCppThis(), (edata == null) ? default(HandleRef) : edata.GetCppThis());
		}

		// Token: 0x0600275F RID: 10079
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_OnMenu3D_32(HandleRef pThis, HandleRef edata);

		/// <summary>
		/// Override generic event bindings to call the corresponding action.
		/// </summary>
		// Token: 0x06002760 RID: 10080 RVA: 0x0003A2C0 File Offset: 0x000384C0
		public override void OnMenu3D(vtkEventData edata)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_OnMenu3D_32(base.GetCppThis(), (edata == null) ? default(HandleRef) : edata.GetCppThis());
		}

		// Token: 0x06002761 RID: 10081
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_OnMove3D_33(HandleRef pThis, HandleRef edata);

		/// <summary>
		/// Override generic event bindings to call the corresponding action.
		/// </summary>
		// Token: 0x06002762 RID: 10082 RVA: 0x0003A2F0 File Offset: 0x000384F0
		public override void OnMove3D(vtkEventData edata)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_OnMove3D_33(base.GetCppThis(), (edata == null) ? default(HandleRef) : edata.GetCppThis());
		}

		// Token: 0x06002763 RID: 10083
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_OnNextPose3D_34(HandleRef pThis, HandleRef edata);

		/// <summary>
		/// Override generic event bindings to call the corresponding action.
		/// </summary>
		// Token: 0x06002764 RID: 10084 RVA: 0x0003A320 File Offset: 0x00038520
		public override void OnNextPose3D(vtkEventData edata)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_OnNextPose3D_34(base.GetCppThis(), (edata == null) ? default(HandleRef) : edata.GetCppThis());
		}

		// Token: 0x06002765 RID: 10085
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_OnPan_35(HandleRef pThis);

		/// <summary>
		/// Complex gesture events binding.
		/// </summary>
		// Token: 0x06002766 RID: 10086 RVA: 0x0003A34F File Offset: 0x0003854F
		public override void OnPan()
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_OnPan_35(base.GetCppThis());
		}

		// Token: 0x06002767 RID: 10087
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_OnPinch_36(HandleRef pThis);

		/// <summary>
		/// Complex gesture events binding.
		/// </summary>
		// Token: 0x06002768 RID: 10088 RVA: 0x0003A35E File Offset: 0x0003855E
		public override void OnPinch()
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_OnPinch_36(base.GetCppThis());
		}

		// Token: 0x06002769 RID: 10089
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_OnRotate_37(HandleRef pThis);

		/// <summary>
		/// Complex gesture events binding.
		/// </summary>
		// Token: 0x0600276A RID: 10090 RVA: 0x0003A36D File Offset: 0x0003856D
		public override void OnRotate()
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_OnRotate_37(base.GetCppThis());
		}

		// Token: 0x0600276B RID: 10091
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_OnSelect3D_38(HandleRef pThis, HandleRef edata);

		/// <summary>
		/// Override generic event bindings to call the corresponding action.
		/// </summary>
		// Token: 0x0600276C RID: 10092 RVA: 0x0003A37C File Offset: 0x0003857C
		public override void OnSelect3D(vtkEventData edata)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_OnSelect3D_38(base.GetCppThis(), (edata == null) ? default(HandleRef) : edata.GetCppThis());
		}

		// Token: 0x0600276D RID: 10093
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_OnViewerMovement3D_39(HandleRef pThis, HandleRef edata);

		/// <summary>
		/// Override generic event bindings to call the corresponding action.
		/// </summary>
		// Token: 0x0600276E RID: 10094 RVA: 0x0003A3AC File Offset: 0x000385AC
		public override void OnViewerMovement3D(vtkEventData edata)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_OnViewerMovement3D_39(base.GetCppThis(), (edata == null) ? default(HandleRef) : edata.GetCppThis());
		}

		// Token: 0x0600276F RID: 10095
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_PositionProp_40(HandleRef pThis, HandleRef arg0, IntPtr lwpos, IntPtr lwori);

		/// <summary>
		/// Methods for interaction.
		/// </summary>
		// Token: 0x06002770 RID: 10096 RVA: 0x0003A3DC File Offset: 0x000385DC
		public override void PositionProp(vtkEventData arg0, IntPtr lwpos, IntPtr lwori)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_PositionProp_40(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), lwpos, lwori);
		}

		// Token: 0x06002771 RID: 10097
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_ProbeData_41(HandleRef pThis, vtkEventDataDevice controller);

		/// <summary>
		/// Methods for interaction.
		/// </summary>
		// Token: 0x06002772 RID: 10098 RVA: 0x0003A40D File Offset: 0x0003860D
		public void ProbeData(vtkEventDataDevice controller)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_ProbeData_41(base.GetCppThis(), controller);
		}

		// Token: 0x06002773 RID: 10099
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRInteractorStyle_SafeDownCast_42(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002774 RID: 10100 RVA: 0x0003A420 File Offset: 0x00038620
		public new static vtkVRInteractorStyle SafeDownCast(vtkObjectBase o)
		{
			vtkVRInteractorStyle vtkVRInteractorStyle = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRInteractorStyle.vtkVRInteractorStyle_SafeDownCast_42((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVRInteractorStyle = (vtkVRInteractorStyle)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVRInteractorStyle.Register(null);
				}
			}
			return vtkVRInteractorStyle;
		}

		// Token: 0x06002775 RID: 10101
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_SetDrawControls_43(HandleRef pThis, byte arg0);

		/// <summary>
		/// Control visibility of descriptive tooltips for controller/HMD models.
		/// </summary>
		// Token: 0x06002776 RID: 10102 RVA: 0x0003A49F File Offset: 0x0003869F
		public void SetDrawControls(bool arg0)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_SetDrawControls_43(base.GetCppThis(), arg0 ? (byte)1 : (byte)0);
		}

		// Token: 0x06002777 RID: 10103
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_SetGrabWithRay_44(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify if the grab mode uses the ray to grab distant objects.
		/// Default is set to on.
		/// </summary>
		// Token: 0x06002778 RID: 10104 RVA: 0x0003A4B7 File Offset: 0x000386B7
		public virtual void SetGrabWithRay(bool _arg)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_SetGrabWithRay_44(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06002779 RID: 10105
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_SetHoverPick_45(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicates if picking should be updated every frame. If so, the interaction
		/// picker will try to pick a prop and rays will be updated accordingly.
		/// Default is set to off.
		/// </summary>
		// Token: 0x0600277A RID: 10106 RVA: 0x0003A4CF File Offset: 0x000386CF
		public virtual void SetHoverPick(bool _arg)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_SetHoverPick_45(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600277B RID: 10107
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_SetInteractor_46(HandleRef pThis, HandleRef iren);

		/// <summary>
		/// Set the Interactor wrapper being controlled by this object.
		/// </summary>
		// Token: 0x0600277C RID: 10108 RVA: 0x0003A4E8 File Offset: 0x000386E8
		public override void SetInteractor(vtkRenderWindowInteractor iren)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_SetInteractor_46(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis());
		}

		// Token: 0x0600277D RID: 10109
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_SetStyle_47(HandleRef pThis, vtkVRInteractorStyle.MovementStyle _arg);

		/// <summary>
		/// Specify the movement style between 'Flying" and "Grounded".
		/// Default is Flying.
		/// </summary>
		// Token: 0x0600277E RID: 10110 RVA: 0x0003A517 File Offset: 0x00038717
		public virtual void SetStyle(vtkVRInteractorStyle.MovementStyle _arg)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_SetStyle_47(base.GetCppThis(), _arg);
		}

		// Token: 0x0600277F RID: 10111
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_SetupActions_48(HandleRef pThis, HandleRef iren);

		/// <summary>
		/// Setup default actions defined with an action path and a corresponding command.
		/// </summary>
		// Token: 0x06002780 RID: 10112 RVA: 0x0003A528 File Offset: 0x00038728
		public virtual void SetupActions(vtkRenderWindowInteractor iren)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_SetupActions_48(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis());
		}

		// Token: 0x06002781 RID: 10113
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_ShowBillboard_49(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string text);

		/// <summary>
		/// Show/hide billboard with given text string.
		/// </summary>
		// Token: 0x06002782 RID: 10114 RVA: 0x0003A557 File Offset: 0x00038757
		public void ShowBillboard(string text)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_ShowBillboard_49(base.GetCppThis(), text);
		}

		// Token: 0x06002783 RID: 10115
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_ShowPickCell_50(HandleRef pThis, HandleRef cell, HandleRef arg1);

		/// <summary>
		/// Make the pick actor a polydata built from the points and edges of the
		/// given cell, and show it.
		/// </summary>
		// Token: 0x06002784 RID: 10116 RVA: 0x0003A568 File Offset: 0x00038768
		public void ShowPickCell(vtkCell cell, vtkProp3D arg1)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_ShowPickCell_50(base.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06002785 RID: 10117
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_ShowPickSphere_51(HandleRef pThis, IntPtr pos, double radius, HandleRef arg2);

		/// <summary>
		/// Make the pick actor a sphere of given radius centered at given position,
		/// and show it.
		/// </summary>
		// Token: 0x06002786 RID: 10118 RVA: 0x0003A5AC File Offset: 0x000387AC
		public void ShowPickSphere(IntPtr pos, double radius, vtkProp3D arg2)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_ShowPickSphere_51(base.GetCppThis(), pos, radius, (arg2 == null) ? default(HandleRef) : arg2.GetCppThis());
		}

		// Token: 0x06002787 RID: 10119
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_ShowRay_52(HandleRef pThis, vtkEventDataDevice controller);

		/// <summary>
		/// Show/hide the ray for the specified controller.
		/// </summary>
		// Token: 0x06002788 RID: 10120 RVA: 0x0003A5DD File Offset: 0x000387DD
		public void ShowRay(vtkEventDataDevice controller)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_ShowRay_52(base.GetCppThis(), controller);
		}

		// Token: 0x06002789 RID: 10121
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_StartClip_53(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Interaction mode entry points.
		/// </summary>
		// Token: 0x0600278A RID: 10122 RVA: 0x0003A5F0 File Offset: 0x000387F0
		public void StartClip(vtkEventDataDevice3D arg0)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_StartClip_53(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600278B RID: 10123
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_StartLoadCamPose_54(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Interaction mode entry points.
		/// </summary>
		// Token: 0x0600278C RID: 10124 RVA: 0x0003A620 File Offset: 0x00038820
		public void StartLoadCamPose(vtkEventDataDevice3D arg0)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_StartLoadCamPose_54(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600278D RID: 10125
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_StartMovement3D_55(HandleRef pThis, int interactionState, HandleRef arg1);

		/// <summary>
		/// Interaction mode entry points.
		/// </summary>
		// Token: 0x0600278E RID: 10126 RVA: 0x0003A650 File Offset: 0x00038850
		public void StartMovement3D(int interactionState, vtkEventDataDevice3D arg1)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_StartMovement3D_55(base.GetCppThis(), interactionState, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0600278F RID: 10127
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_StartPick_56(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Interaction mode entry points.
		/// </summary>
		// Token: 0x06002790 RID: 10128 RVA: 0x0003A680 File Offset: 0x00038880
		public void StartPick(vtkEventDataDevice3D arg0)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_StartPick_56(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002791 RID: 10129
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_StartPositionProp_57(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Interaction mode entry points.
		/// </summary>
		// Token: 0x06002792 RID: 10130 RVA: 0x0003A6B0 File Offset: 0x000388B0
		public void StartPositionProp(vtkEventDataDevice3D arg0)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_StartPositionProp_57(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002793 RID: 10131
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_Teleportation3D_58(HandleRef pThis, HandleRef edd);

		/// <summary>
		/// Instant movement to the picked point
		/// </summary>
		// Token: 0x06002794 RID: 10132 RVA: 0x0003A6E0 File Offset: 0x000388E0
		public void Teleportation3D(vtkEventDataDevice3D edd)
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_Teleportation3D_58(base.GetCppThis(), (edd == null) ? default(HandleRef) : edd.GetCppThis());
		}

		// Token: 0x06002795 RID: 10133
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRInteractorStyle_ToggleDrawControls_59(HandleRef pThis);

		/// <summary>
		/// Control visibility of descriptive tooltips for controller/HMD models.
		/// </summary>
		// Token: 0x06002796 RID: 10134 RVA: 0x0003A70F File Offset: 0x0003890F
		public void ToggleDrawControls()
		{
			vtkVRInteractorStyle.vtkVRInteractorStyle_ToggleDrawControls_59(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400054D RID: 1357
		public new const string MRFullTypeName = "Kitware.VTK.vtkVRInteractorStyle";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400054E RID: 1358
		public new static readonly string MRClassNameKey = "class vtkVRInteractorStyle";

		/// <summary>
		/// Specify if the grab mode uses the ray to grab distant objects.
		/// Default is set to on.
		/// </summary>
		// Token: 0x020000B3 RID: 179
		public enum MovementStyle
		{
			/// <summary>enum member</summary>
			// Token: 0x04000550 RID: 1360
			FLY_STYLE,
			/// <summary>enum member</summary>
			// Token: 0x04000551 RID: 1361
			GROUNDED_STYLE
		}
	}
}
