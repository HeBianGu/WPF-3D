using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProp3DButtonRepresentation
	/// </summary>
	/// <remarks>
	///    defines a representation for a vtkButtonWidget
	///
	/// This class implements one type of vtkButtonRepresentation. Each button
	/// state can be represented with a separate instance of vtkProp3D. Thus
	/// buttons can be represented with vtkActor, vtkImageActor, volumes (e.g.,
	/// vtkVolume) and/or any other vtkProp3D. Also, the class invokes events when
	/// highlighting occurs (i.e., hovering, selecting) so that appropriate action
	/// can be taken to highlight the button (if desired).
	///
	/// To use this representation, always begin by specifying the number of
	/// button states.  Then provide, for each state, an instance of vtkProp3D.
	///
	/// This widget representation uses the conventional placement method. The
	/// button is placed inside the bounding box defined by PlaceWidget by translating
	/// and scaling the vtkProp3D to fit (each vtkProp3D is transformed). Therefore,
	/// you must define the number of button states and each state (i.e., vtkProp3D)
	/// prior to calling vtkPlaceWidget.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkButtonWidget vtkButtonRepresentation vtkButtonSource vtkEllipticalButtonSource
	/// vtkRectangularButtonSource
	/// </seealso>
	// Token: 0x0200035E RID: 862
	public class vtkProp3DButtonRepresentation : vtkButtonRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009CD8 RID: 40152 RVA: 0x000DE357 File Offset: 0x000DC557
		static vtkProp3DButtonRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProp3DButtonRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProp3DButtonRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009CD9 RID: 40153 RVA: 0x000DE37F File Offset: 0x000DC57F
		public vtkProp3DButtonRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06009CDA RID: 40154
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3DButtonRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06009CDB RID: 40155 RVA: 0x000DE390 File Offset: 0x000DC590
		public new static vtkProp3DButtonRepresentation New()
		{
			vtkProp3DButtonRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProp3DButtonRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06009CDC RID: 40156 RVA: 0x000DE3E4 File Offset: 0x000DC5E4
		public vtkProp3DButtonRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009CDD RID: 40157 RVA: 0x000DE428 File Offset: 0x000DC628
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009CDE RID: 40158
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DButtonRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Provide the necessary methods to satisfy the vtkWidgetRepresentation API.
		/// </summary>
		// Token: 0x06009CDF RID: 40159 RVA: 0x000DE433 File Offset: 0x000DC633
		public override void BuildRepresentation()
		{
			vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06009CE0 RID: 40160
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp3DButtonRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// Provide the necessary methods to satisfy the vtkWidgetRepresentation API.
		/// </summary>
		// Token: 0x06009CE1 RID: 40161 RVA: 0x000DE444 File Offset: 0x000DC644
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x06009CE2 RID: 40162
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DButtonRepresentation_FollowCameraOff_03(HandleRef pThis);

		/// <summary>
		/// Specify whether the button should always face the camera. If enabled,
		/// the button reorients itself towards the camera as the camera moves.
		/// </summary>
		// Token: 0x06009CE3 RID: 40163 RVA: 0x000DE466 File Offset: 0x000DC666
		public virtual void FollowCameraOff()
		{
			vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_FollowCameraOff_03(base.GetCppThis());
		}

		// Token: 0x06009CE4 RID: 40164
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DButtonRepresentation_FollowCameraOn_04(HandleRef pThis);

		/// <summary>
		/// Specify whether the button should always face the camera. If enabled,
		/// the button reorients itself towards the camera as the camera moves.
		/// </summary>
		// Token: 0x06009CE5 RID: 40165 RVA: 0x000DE475 File Offset: 0x000DC675
		public virtual void FollowCameraOn()
		{
			vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_FollowCameraOn_04(base.GetCppThis());
		}

		// Token: 0x06009CE6 RID: 40166
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DButtonRepresentation_GetActors_05(HandleRef pThis, HandleRef pc);

		/// <summary>
		/// Provide the necessary methods to satisfy the rendering API.
		/// </summary>
		// Token: 0x06009CE7 RID: 40167 RVA: 0x000DE484 File Offset: 0x000DC684
		public override void GetActors(vtkPropCollection pc)
		{
			vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_GetActors_05(base.GetCppThis(), (pc == null) ? default(HandleRef) : pc.GetCppThis());
		}

		// Token: 0x06009CE8 RID: 40168
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3DButtonRepresentation_GetBounds_06(HandleRef pThis);

		/// <summary>
		/// Provide the necessary methods to satisfy the rendering API.
		/// </summary>
		// Token: 0x06009CE9 RID: 40169 RVA: 0x000DE4B4 File Offset: 0x000DC6B4
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_GetBounds_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009CEA RID: 40170
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3DButtonRepresentation_GetButtonProp_07(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Add the ith texture corresponding to the ith button state.
		/// The parameter i should be (0 &lt;= i &lt; NumberOfStates).
		/// </summary>
		// Token: 0x06009CEB RID: 40171 RVA: 0x000DE4FC File Offset: 0x000DC6FC
		public vtkProp3D GetButtonProp(int i)
		{
			vtkProp3D vtkProp3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_GetButtonProp_07(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp3D = (vtkProp3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp3D.Register(null);
				}
			}
			return vtkProp3D;
		}

		// Token: 0x06009CEC RID: 40172
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp3DButtonRepresentation_GetFollowCamera_08(HandleRef pThis);

		/// <summary>
		/// Specify whether the button should always face the camera. If enabled,
		/// the button reorients itself towards the camera as the camera moves.
		/// </summary>
		// Token: 0x06009CED RID: 40173 RVA: 0x000DE56C File Offset: 0x000DC76C
		public virtual int GetFollowCamera()
		{
			return vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_GetFollowCamera_08(base.GetCppThis());
		}

		// Token: 0x06009CEE RID: 40174
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProp3DButtonRepresentation_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of the class.
		/// </summary>
		// Token: 0x06009CEF RID: 40175 RVA: 0x000DE58C File Offset: 0x000DC78C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x06009CF0 RID: 40176
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProp3DButtonRepresentation_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of the class.
		/// </summary>
		// Token: 0x06009CF1 RID: 40177 RVA: 0x000DE5AC File Offset: 0x000DC7AC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x06009CF2 RID: 40178
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp3DButtonRepresentation_HasTranslucentPolygonalGeometry_11(HandleRef pThis);

		/// <summary>
		/// Provide the necessary methods to satisfy the rendering API.
		/// </summary>
		// Token: 0x06009CF3 RID: 40179 RVA: 0x000DE5C8 File Offset: 0x000DC7C8
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_HasTranslucentPolygonalGeometry_11(base.GetCppThis());
		}

		// Token: 0x06009CF4 RID: 40180
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp3DButtonRepresentation_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of the class.
		/// </summary>
		// Token: 0x06009CF5 RID: 40181 RVA: 0x000DE5E8 File Offset: 0x000DC7E8
		public override int IsA(string type)
		{
			return vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x06009CF6 RID: 40182
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp3DButtonRepresentation_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instances of the class.
		/// </summary>
		// Token: 0x06009CF7 RID: 40183 RVA: 0x000DE608 File Offset: 0x000DC808
		public new static int IsTypeOf(string type)
		{
			return vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_IsTypeOf_13(type);
		}

		// Token: 0x06009CF8 RID: 40184
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3DButtonRepresentation_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of the class.
		/// </summary>
		// Token: 0x06009CF9 RID: 40185 RVA: 0x000DE624 File Offset: 0x000DC824
		public new vtkProp3DButtonRepresentation NewInstance()
		{
			vtkProp3DButtonRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProp3DButtonRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009CFA RID: 40186
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DButtonRepresentation_PlaceWidget_16(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// This method positions (translates and scales the props) into the
		/// bounding box specified. Note all the button props are scaled.
		/// </summary>
		// Token: 0x06009CFB RID: 40187 RVA: 0x000DE67E File Offset: 0x000DC87E
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_PlaceWidget_16(base.GetCppThis(), bounds);
		}

		// Token: 0x06009CFC RID: 40188
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DButtonRepresentation_RegisterPickers_17(HandleRef pThis);

		/// <summary>
		/// Provide the necessary methods to satisfy the rendering API.
		/// </summary>
		// Token: 0x06009CFD RID: 40189 RVA: 0x000DE68E File Offset: 0x000DC88E
		public override void RegisterPickers()
		{
			vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_RegisterPickers_17(base.GetCppThis());
		}

		// Token: 0x06009CFE RID: 40190
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DButtonRepresentation_ReleaseGraphicsResources_18(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Provide the necessary methods to satisfy the rendering API.
		/// </summary>
		// Token: 0x06009CFF RID: 40191 RVA: 0x000DE6A0 File Offset: 0x000DC8A0
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_ReleaseGraphicsResources_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009D00 RID: 40192
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp3DButtonRepresentation_RenderOpaqueGeometry_19(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Provide the necessary methods to satisfy the rendering API.
		/// </summary>
		// Token: 0x06009D01 RID: 40193 RVA: 0x000DE6D0 File Offset: 0x000DC8D0
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_RenderOpaqueGeometry_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009D02 RID: 40194
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp3DButtonRepresentation_RenderTranslucentPolygonalGeometry_20(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Provide the necessary methods to satisfy the rendering API.
		/// </summary>
		// Token: 0x06009D03 RID: 40195 RVA: 0x000DE704 File Offset: 0x000DC904
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_RenderTranslucentPolygonalGeometry_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009D04 RID: 40196
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp3DButtonRepresentation_RenderVolumetricGeometry_21(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Provide the necessary methods to satisfy the rendering API.
		/// </summary>
		// Token: 0x06009D05 RID: 40197 RVA: 0x000DE738 File Offset: 0x000DC938
		public override int RenderVolumetricGeometry(vtkViewport arg0)
		{
			return vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_RenderVolumetricGeometry_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009D06 RID: 40198
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3DButtonRepresentation_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instances of the class.
		/// </summary>
		// Token: 0x06009D07 RID: 40199 RVA: 0x000DE76C File Offset: 0x000DC96C
		public new static vtkProp3DButtonRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkProp3DButtonRepresentation vtkProp3DButtonRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp3DButtonRepresentation = (vtkProp3DButtonRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp3DButtonRepresentation.Register(null);
				}
			}
			return vtkProp3DButtonRepresentation;
		}

		// Token: 0x06009D08 RID: 40200
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DButtonRepresentation_SetButtonProp_23(HandleRef pThis, int i, HandleRef prop);

		/// <summary>
		/// Add the ith texture corresponding to the ith button state.
		/// The parameter i should be (0 &lt;= i &lt; NumberOfStates).
		/// </summary>
		// Token: 0x06009D09 RID: 40201 RVA: 0x000DE7EC File Offset: 0x000DC9EC
		public void SetButtonProp(int i, vtkProp3D prop)
		{
			vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_SetButtonProp_23(base.GetCppThis(), i, (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x06009D0A RID: 40202
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DButtonRepresentation_SetFollowCamera_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether the button should always face the camera. If enabled,
		/// the button reorients itself towards the camera as the camera moves.
		/// </summary>
		// Token: 0x06009D0B RID: 40203 RVA: 0x000DE81C File Offset: 0x000DCA1C
		public virtual void SetFollowCamera(int _arg)
		{
			vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_SetFollowCamera_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06009D0C RID: 40204
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DButtonRepresentation_SetState_25(HandleRef pThis, int state);

		/// <summary>
		/// Extend the vtkButtonRepresentation::SetState() method.
		/// </summary>
		// Token: 0x06009D0D RID: 40205 RVA: 0x000DE82C File Offset: 0x000DCA2C
		public override void SetState(int state)
		{
			vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_SetState_25(base.GetCppThis(), state);
		}

		// Token: 0x06009D0E RID: 40206
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DButtonRepresentation_ShallowCopy_26(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Provide the necessary methods to satisfy the rendering API.
		/// </summary>
		// Token: 0x06009D0F RID: 40207 RVA: 0x000DE83C File Offset: 0x000DCA3C
		public override void ShallowCopy(vtkProp prop)
		{
			vtkProp3DButtonRepresentation.vtkProp3DButtonRepresentation_ShallowCopy_26(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CAF RID: 3247
		public new const string MRFullTypeName = "Kitware.VTK.vtkProp3DButtonRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CB0 RID: 3248
		public new static readonly string MRClassNameKey = "class vtkProp3DButtonRepresentation";
	}
}
