using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVRPanelRepresentation
	/// </summary>
	/// <remarks>
	///    Widget representation for vtkVRPanelWidget
	/// Implementation of the popup panel representation for the
	/// vtkVRPanelWidget.
	/// This representation is rebuilt every time the hovered prop changes.
	/// Its position is set according to the camera orientation and is placed at a
	/// distance defined in meters in the BuildRepresentation() method.
	///
	/// WARNING: The panel might be occluded by other props.
	/// </remarks>
	// Token: 0x020000C6 RID: 198
	public class vtkVRPanelRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002ACC RID: 10956 RVA: 0x0003F35B File Offset: 0x0003D55B
		static vtkVRPanelRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVRPanelRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVRPanelRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002ACD RID: 10957 RVA: 0x0003F383 File Offset: 0x0003D583
		public vtkVRPanelRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06002ACE RID: 10958
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRPanelRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06002ACF RID: 10959 RVA: 0x0003F394 File Offset: 0x0003D594
		public new static vtkVRPanelRepresentation New()
		{
			vtkVRPanelRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRPanelRepresentation.vtkVRPanelRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVRPanelRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06002AD0 RID: 10960 RVA: 0x0003F3E8 File Offset: 0x0003D5E8
		public vtkVRPanelRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVRPanelRepresentation.vtkVRPanelRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002AD1 RID: 10961 RVA: 0x0003F42C File Offset: 0x0003D62C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002AD2 RID: 10962
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRPanelRepresentation_AllowAdjustmentOff_01(HandleRef pThis);

		/// <summary>
		/// Can the panel be relocated by the user
		/// </summary>
		// Token: 0x06002AD3 RID: 10963 RVA: 0x0003F437 File Offset: 0x0003D637
		public virtual void AllowAdjustmentOff()
		{
			vtkVRPanelRepresentation.vtkVRPanelRepresentation_AllowAdjustmentOff_01(base.GetCppThis());
		}

		// Token: 0x06002AD4 RID: 10964
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRPanelRepresentation_AllowAdjustmentOn_02(HandleRef pThis);

		/// <summary>
		/// Can the panel be relocated by the user
		/// </summary>
		// Token: 0x06002AD5 RID: 10965 RVA: 0x0003F446 File Offset: 0x0003D646
		public virtual void AllowAdjustmentOn()
		{
			vtkVRPanelRepresentation.vtkVRPanelRepresentation_AllowAdjustmentOn_02(base.GetCppThis());
		}

		// Token: 0x06002AD6 RID: 10966
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRPanelRepresentation_BuildRepresentation_03(HandleRef pThis);

		/// <summary>
		/// Methods to interface with the vtkVRPanelWidget.
		/// </summary>
		// Token: 0x06002AD7 RID: 10967 RVA: 0x0003F455 File Offset: 0x0003D655
		public override void BuildRepresentation()
		{
			vtkVRPanelRepresentation.vtkVRPanelRepresentation_BuildRepresentation_03(base.GetCppThis());
		}

		// Token: 0x06002AD8 RID: 10968
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRPanelRepresentation_ComplexInteraction_04(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

		/// <summary>
		/// Methods to interface with the vtkVRPanelWidget.
		/// </summary>
		// Token: 0x06002AD9 RID: 10969 RVA: 0x0003F464 File Offset: 0x0003D664
		public override void ComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
		{
			vtkVRPanelRepresentation.vtkVRPanelRepresentation_ComplexInteraction_04(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis(), (widget == null) ? default(HandleRef) : widget.GetCppThis(), arg2, calldata);
		}

		// Token: 0x06002ADA RID: 10970
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRPanelRepresentation_ComputeComplexInteractionState_05(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata, int modify);

		/// <summary>
		/// Methods to interface with the vtkVRPanelWidget.
		/// </summary>
		// Token: 0x06002ADB RID: 10971 RVA: 0x0003F4AC File Offset: 0x0003D6AC
		public override int ComputeComplexInteractionState(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata, int modify)
		{
			return vtkVRPanelRepresentation.vtkVRPanelRepresentation_ComputeComplexInteractionState_05(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis(), (widget == null) ? default(HandleRef) : widget.GetCppThis(), arg2, calldata, modify);
		}

		// Token: 0x06002ADC RID: 10972
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRPanelRepresentation_EndComplexInteraction_06(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

		/// <summary>
		/// Methods to interface with the vtkVRPanelWidget.
		/// </summary>
		// Token: 0x06002ADD RID: 10973 RVA: 0x0003F4FC File Offset: 0x0003D6FC
		public override void EndComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
		{
			vtkVRPanelRepresentation.vtkVRPanelRepresentation_EndComplexInteraction_06(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis(), (widget == null) ? default(HandleRef) : widget.GetCppThis(), arg2, calldata);
		}

		// Token: 0x06002ADE RID: 10974
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVRPanelRepresentation_GetAllowAdjustment_07(HandleRef pThis);

		/// <summary>
		/// Can the panel be relocated by the user
		/// </summary>
		// Token: 0x06002ADF RID: 10975 RVA: 0x0003F544 File Offset: 0x0003D744
		public virtual bool GetAllowAdjustment()
		{
			return vtkVRPanelRepresentation.vtkVRPanelRepresentation_GetAllowAdjustment_07(base.GetCppThis()) != 0;
		}

		// Token: 0x06002AE0 RID: 10976
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRPanelRepresentation_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06002AE1 RID: 10977 RVA: 0x0003F56C File Offset: 0x0003D76C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVRPanelRepresentation.vtkVRPanelRepresentation_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x06002AE2 RID: 10978
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRPanelRepresentation_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06002AE3 RID: 10979 RVA: 0x0003F58C File Offset: 0x0003D78C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVRPanelRepresentation.vtkVRPanelRepresentation_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x06002AE4 RID: 10980
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRPanelRepresentation_GetTextActor_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set panel text
		/// </summary>
		// Token: 0x06002AE5 RID: 10981 RVA: 0x0003F5A8 File Offset: 0x0003D7A8
		public virtual vtkTextActor3D GetTextActor()
		{
			vtkTextActor3D vtkTextActor3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRPanelRepresentation.vtkVRPanelRepresentation_GetTextActor_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextActor3D = (vtkTextActor3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextActor3D.Register(null);
				}
			}
			return vtkTextActor3D;
		}

		// Token: 0x06002AE6 RID: 10982
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRPanelRepresentation_HasTranslucentPolygonalGeometry_11(HandleRef pThis);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x06002AE7 RID: 10983 RVA: 0x0003F618 File Offset: 0x0003D818
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkVRPanelRepresentation.vtkVRPanelRepresentation_HasTranslucentPolygonalGeometry_11(base.GetCppThis());
		}

		// Token: 0x06002AE8 RID: 10984
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRPanelRepresentation_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06002AE9 RID: 10985 RVA: 0x0003F638 File Offset: 0x0003D838
		public override int IsA(string type)
		{
			return vtkVRPanelRepresentation.vtkVRPanelRepresentation_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x06002AEA RID: 10986
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRPanelRepresentation_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06002AEB RID: 10987 RVA: 0x0003F658 File Offset: 0x0003D858
		public new static int IsTypeOf(string type)
		{
			return vtkVRPanelRepresentation.vtkVRPanelRepresentation_IsTypeOf_13(type);
		}

		// Token: 0x06002AEC RID: 10988
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRPanelRepresentation_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06002AED RID: 10989 RVA: 0x0003F674 File Offset: 0x0003D874
		public new vtkVRPanelRepresentation NewInstance()
		{
			vtkVRPanelRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRPanelRepresentation.vtkVRPanelRepresentation_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVRPanelRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002AEE RID: 10990
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRPanelRepresentation_PlaceWidget_16(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Methods to interface with the vtkVRPanelWidget.
		/// </summary>
		// Token: 0x06002AEF RID: 10991 RVA: 0x0003F6CE File Offset: 0x0003D8CE
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkVRPanelRepresentation.vtkVRPanelRepresentation_PlaceWidget_16(base.GetCppThis(), bounds);
		}

		// Token: 0x06002AF0 RID: 10992
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRPanelRepresentation_PlaceWidgetExtended_17(HandleRef pThis, IntPtr bounds, IntPtr normal, IntPtr upvec, double scale);

		/// <summary>
		/// Methods to interface with the vtkVRPanelWidget.
		/// </summary>
		// Token: 0x06002AF1 RID: 10993 RVA: 0x0003F6DE File Offset: 0x0003D8DE
		public void PlaceWidgetExtended(IntPtr bounds, IntPtr normal, IntPtr upvec, double scale)
		{
			vtkVRPanelRepresentation.vtkVRPanelRepresentation_PlaceWidgetExtended_17(base.GetCppThis(), bounds, normal, upvec, scale);
		}

		// Token: 0x06002AF2 RID: 10994
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRPanelRepresentation_ReleaseGraphicsResources_18(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x06002AF3 RID: 10995 RVA: 0x0003F6F4 File Offset: 0x0003D8F4
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkVRPanelRepresentation.vtkVRPanelRepresentation_ReleaseGraphicsResources_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002AF4 RID: 10996
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRPanelRepresentation_RenderOpaqueGeometry_19(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x06002AF5 RID: 10997 RVA: 0x0003F724 File Offset: 0x0003D924
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkVRPanelRepresentation.vtkVRPanelRepresentation_RenderOpaqueGeometry_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002AF6 RID: 10998
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRPanelRepresentation_RenderTranslucentPolygonalGeometry_20(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x06002AF7 RID: 10999 RVA: 0x0003F758 File Offset: 0x0003D958
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkVRPanelRepresentation.vtkVRPanelRepresentation_RenderTranslucentPolygonalGeometry_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002AF8 RID: 11000
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRPanelRepresentation_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06002AF9 RID: 11001 RVA: 0x0003F78C File Offset: 0x0003D98C
		public new static vtkVRPanelRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkVRPanelRepresentation vtkVRPanelRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRPanelRepresentation.vtkVRPanelRepresentation_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVRPanelRepresentation = (vtkVRPanelRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVRPanelRepresentation.Register(null);
				}
			}
			return vtkVRPanelRepresentation;
		}

		// Token: 0x06002AFA RID: 11002
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRPanelRepresentation_SetAllowAdjustment_22(HandleRef pThis, byte _arg);

		/// <summary>
		/// Can the panel be relocated by the user
		/// </summary>
		// Token: 0x06002AFB RID: 11003 RVA: 0x0003F80B File Offset: 0x0003DA0B
		public virtual void SetAllowAdjustment(bool _arg)
		{
			vtkVRPanelRepresentation.vtkVRPanelRepresentation_SetAllowAdjustment_22(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06002AFC RID: 11004
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRPanelRepresentation_SetCoordinateSystemToHMD_23(HandleRef pThis);

		/// <summary>
		/// Set panel text
		/// </summary>
		// Token: 0x06002AFD RID: 11005 RVA: 0x0003F823 File Offset: 0x0003DA23
		public void SetCoordinateSystemToHMD()
		{
			vtkVRPanelRepresentation.vtkVRPanelRepresentation_SetCoordinateSystemToHMD_23(base.GetCppThis());
		}

		// Token: 0x06002AFE RID: 11006
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRPanelRepresentation_SetCoordinateSystemToLeftController_24(HandleRef pThis);

		/// <summary>
		/// Set panel text
		/// </summary>
		// Token: 0x06002AFF RID: 11007 RVA: 0x0003F832 File Offset: 0x0003DA32
		public void SetCoordinateSystemToLeftController()
		{
			vtkVRPanelRepresentation.vtkVRPanelRepresentation_SetCoordinateSystemToLeftController_24(base.GetCppThis());
		}

		// Token: 0x06002B00 RID: 11008
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRPanelRepresentation_SetCoordinateSystemToRightController_25(HandleRef pThis);

		/// <summary>
		/// Set panel text
		/// </summary>
		// Token: 0x06002B01 RID: 11009 RVA: 0x0003F841 File Offset: 0x0003DA41
		public void SetCoordinateSystemToRightController()
		{
			vtkVRPanelRepresentation.vtkVRPanelRepresentation_SetCoordinateSystemToRightController_25(base.GetCppThis());
		}

		// Token: 0x06002B02 RID: 11010
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRPanelRepresentation_SetCoordinateSystemToWorld_26(HandleRef pThis);

		/// <summary>
		/// Set panel text
		/// </summary>
		// Token: 0x06002B03 RID: 11011 RVA: 0x0003F850 File Offset: 0x0003DA50
		public void SetCoordinateSystemToWorld()
		{
			vtkVRPanelRepresentation.vtkVRPanelRepresentation_SetCoordinateSystemToWorld_26(base.GetCppThis());
		}

		// Token: 0x06002B04 RID: 11012
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRPanelRepresentation_SetText_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string str);

		/// <summary>
		/// Set panel text
		/// </summary>
		// Token: 0x06002B05 RID: 11013 RVA: 0x0003F85F File Offset: 0x0003DA5F
		public void SetText(string str)
		{
			vtkVRPanelRepresentation.vtkVRPanelRepresentation_SetText_27(base.GetCppThis(), str);
		}

		// Token: 0x06002B06 RID: 11014
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRPanelRepresentation_StartComplexInteraction_28(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

		/// <summary>
		/// Methods to interface with the vtkVRPanelWidget.
		/// </summary>
		// Token: 0x06002B07 RID: 11015 RVA: 0x0003F870 File Offset: 0x0003DA70
		public override void StartComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
		{
			vtkVRPanelRepresentation.vtkVRPanelRepresentation_StartComplexInteraction_28(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis(), (widget == null) ? default(HandleRef) : widget.GetCppThis(), arg2, calldata);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400057D RID: 1405
		public new const string MRFullTypeName = "Kitware.VTK.vtkVRPanelRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400057E RID: 1406
		public new static readonly string MRClassNameKey = "class vtkVRPanelRepresentation";

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x020000C7 RID: 199
		public enum InteractionStateType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000580 RID: 1408
			Moving = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000581 RID: 1409
			Outside = 0
		}
	}
}
