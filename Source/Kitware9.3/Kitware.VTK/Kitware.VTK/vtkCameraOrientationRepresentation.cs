using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCameraOrientationRepresentation
	/// </summary>
	/// <remarks>
	///    A 3D representation for vtkCameraOrientationWidget.
	///
	/// Hover over the representation and drag with LMB to orbit around the view.
	/// Clicking on one of the axis labels will snap to that view.
	/// Click again on the same axis to switch to the opposite view of that same axis.
	///
	/// The representation anchors itself to a corner of the renderer's
	/// viewport. See AnchorType.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCameraOrientationWidget
	///
	/// </seealso>
	// Token: 0x020002E5 RID: 741
	public class vtkCameraOrientationRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008531 RID: 34097 RVA: 0x000BE202 File Offset: 0x000BC402
		static vtkCameraOrientationRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCameraOrientationRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCameraOrientationRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008532 RID: 34098 RVA: 0x000BE22A File Offset: 0x000BC42A
		public vtkCameraOrientationRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008533 RID: 34099
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraOrientationRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008534 RID: 34100 RVA: 0x000BE238 File Offset: 0x000BC438
		public new static vtkCameraOrientationRepresentation New()
		{
			vtkCameraOrientationRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCameraOrientationRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008535 RID: 34101 RVA: 0x000BE28C File Offset: 0x000BC48C
		public vtkCameraOrientationRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008536 RID: 34102 RVA: 0x000BE2D0 File Offset: 0x000BC4D0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008537 RID: 34103
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_AnchorToLowerLeft_01(HandleRef pThis);

		/// <summary>
		/// Get/Set the widget anchor type
		/// </summary>
		// Token: 0x06008538 RID: 34104 RVA: 0x000BE2DB File Offset: 0x000BC4DB
		public void AnchorToLowerLeft()
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_AnchorToLowerLeft_01(base.GetCppThis());
		}

		// Token: 0x06008539 RID: 34105
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_AnchorToLowerRight_02(HandleRef pThis);

		/// <summary>
		/// Get/Set the widget anchor type
		/// </summary>
		// Token: 0x0600853A RID: 34106 RVA: 0x000BE2EA File Offset: 0x000BC4EA
		public void AnchorToLowerRight()
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_AnchorToLowerRight_02(base.GetCppThis());
		}

		// Token: 0x0600853B RID: 34107
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_AnchorToUpperLeft_03(HandleRef pThis);

		/// <summary>
		/// Get/Set the widget anchor type
		/// </summary>
		// Token: 0x0600853C RID: 34108 RVA: 0x000BE2F9 File Offset: 0x000BC4F9
		public void AnchorToUpperLeft()
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_AnchorToUpperLeft_03(base.GetCppThis());
		}

		// Token: 0x0600853D RID: 34109
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_AnchorToUpperRight_04(HandleRef pThis);

		/// <summary>
		/// Get/Set the widget anchor type
		/// </summary>
		// Token: 0x0600853E RID: 34110 RVA: 0x000BE308 File Offset: 0x000BC508
		public void AnchorToUpperRight()
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_AnchorToUpperRight_04(base.GetCppThis());
		}

		// Token: 0x0600853F RID: 34111
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_ApplyInteractionState_05(HandleRef pThis, ref int state);

		/// <summary>
		/// The interaction state may be set from a widget (e.g., vtkCameraOrientationWidget) or
		/// other object. This call updates the representation to match the interaction state.
		/// </summary>
		// Token: 0x06008540 RID: 34112 RVA: 0x000BE317 File Offset: 0x000BC517
		public void ApplyInteractionState(ref int state)
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_ApplyInteractionState_05(base.GetCppThis(), ref state);
		}

		// Token: 0x06008541 RID: 34113
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_BuildRepresentation_06(HandleRef pThis);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06008542 RID: 34114 RVA: 0x000BE327 File Offset: 0x000BC527
		public override void BuildRepresentation()
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_BuildRepresentation_06(base.GetCppThis());
		}

		// Token: 0x06008543 RID: 34115
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraOrientationRepresentation_ComputeInteractionState_07(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06008544 RID: 34116 RVA: 0x000BE338 File Offset: 0x000BC538
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_ComputeInteractionState_07(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x06008545 RID: 34117
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_ContainerVisibilityOff_08(HandleRef pThis);

		/// <summary>
		/// Show container to indicate mouse presence.
		/// </summary>
		// Token: 0x06008546 RID: 34118 RVA: 0x000BE35A File Offset: 0x000BC55A
		public virtual void ContainerVisibilityOff()
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_ContainerVisibilityOff_08(base.GetCppThis());
		}

		// Token: 0x06008547 RID: 34119
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_ContainerVisibilityOn_09(HandleRef pThis);

		/// <summary>
		/// Show container to indicate mouse presence.
		/// </summary>
		// Token: 0x06008548 RID: 34120 RVA: 0x000BE369 File Offset: 0x000BC569
		public virtual void ContainerVisibilityOn()
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_ContainerVisibilityOn_09(base.GetCppThis());
		}

		// Token: 0x06008549 RID: 34121
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_EndWidgetInteraction_10(HandleRef pThis, IntPtr newEventPos);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x0600854A RID: 34122 RVA: 0x000BE378 File Offset: 0x000BC578
		public override void EndWidgetInteraction(IntPtr newEventPos)
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_EndWidgetInteraction_10(base.GetCppThis(), newEventPos);
		}

		// Token: 0x0600854B RID: 34123
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_GetActors_11(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// For some exporters and other other operations we must be
		/// able to collect all the actors or volumes. These methods
		/// are used in that process.
		/// </summary>
		// Token: 0x0600854C RID: 34124 RVA: 0x000BE388 File Offset: 0x000BC588
		public override void GetActors(vtkPropCollection arg0)
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetActors_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600854D RID: 34125
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCameraOrientationRepresentation.AnchorType vtkCameraOrientationRepresentation_GetAnchorPosition_12(HandleRef pThis);

		/// <summary>
		/// Get/Set the widget anchor type
		/// </summary>
		// Token: 0x0600854E RID: 34126 RVA: 0x000BE3B8 File Offset: 0x000BC5B8
		public vtkCameraOrientationRepresentation.AnchorType GetAnchorPosition()
		{
			return vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetAnchorPosition_12(base.GetCppThis());
		}

		// Token: 0x0600854F RID: 34127
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCameraOrientationRepresentation_GetAzimuth_13(HandleRef pThis);

		/// <summary>
		/// Orientation properties. (read only)
		/// </summary>
		// Token: 0x06008550 RID: 34128 RVA: 0x000BE3D8 File Offset: 0x000BC5D8
		public virtual double GetAzimuth()
		{
			return vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetAzimuth_13(base.GetCppThis());
		}

		// Token: 0x06008551 RID: 34129
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraOrientationRepresentation_GetBack_14(HandleRef pThis);

		/// <summary>
		/// Orientation properties. (read only)
		/// </summary>
		// Token: 0x06008552 RID: 34130 RVA: 0x000BE3F8 File Offset: 0x000BC5F8
		public virtual double[] GetBack()
		{
			IntPtr intPtr = vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetBack_14(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008553 RID: 34131
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_GetBack_15(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Orientation properties. (read only)
		/// </summary>
		// Token: 0x06008554 RID: 34132 RVA: 0x000BE440 File Offset: 0x000BC640
		public virtual void GetBack(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetBack_15(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06008555 RID: 34133
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_GetBack_16(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Orientation properties. (read only)
		/// </summary>
		// Token: 0x06008556 RID: 34134 RVA: 0x000BE452 File Offset: 0x000BC652
		public virtual void GetBack(IntPtr _arg)
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetBack_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06008557 RID: 34135
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraOrientationRepresentation_GetBounds_17(HandleRef pThis);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06008558 RID: 34136 RVA: 0x000BE464 File Offset: 0x000BC664
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetBounds_17(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008559 RID: 34137
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraOrientationRepresentation_GetContainerCircumferentialResolution_18(HandleRef pThis);

		/// <summary>
		/// Set container's circumferential resolution.
		/// </summary>
		// Token: 0x0600855A RID: 34138 RVA: 0x000BE4AC File Offset: 0x000BC6AC
		public virtual int GetContainerCircumferentialResolution()
		{
			return vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetContainerCircumferentialResolution_18(base.GetCppThis());
		}

		// Token: 0x0600855B RID: 34139
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraOrientationRepresentation_GetContainerCircumferentialResolutionMaxValue_19(HandleRef pThis);

		/// <summary>
		/// Set container's circumferential resolution.
		/// </summary>
		// Token: 0x0600855C RID: 34140 RVA: 0x000BE4CC File Offset: 0x000BC6CC
		public virtual int GetContainerCircumferentialResolutionMaxValue()
		{
			return vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetContainerCircumferentialResolutionMaxValue_19(base.GetCppThis());
		}

		// Token: 0x0600855D RID: 34141
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraOrientationRepresentation_GetContainerCircumferentialResolutionMinValue_20(HandleRef pThis);

		/// <summary>
		/// Set container's circumferential resolution.
		/// </summary>
		// Token: 0x0600855E RID: 34142 RVA: 0x000BE4EC File Offset: 0x000BC6EC
		public virtual int GetContainerCircumferentialResolutionMinValue()
		{
			return vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetContainerCircumferentialResolutionMinValue_20(base.GetCppThis());
		}

		// Token: 0x0600855F RID: 34143
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraOrientationRepresentation_GetContainerProperty_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the container property.
		/// </summary>
		// Token: 0x06008560 RID: 34144 RVA: 0x000BE50C File Offset: 0x000BC70C
		public vtkProperty GetContainerProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetContainerProperty_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x06008561 RID: 34145
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraOrientationRepresentation_GetContainerRadialResolution_22(HandleRef pThis);

		/// <summary>
		/// Set container's radial resolution.
		/// </summary>
		// Token: 0x06008562 RID: 34146 RVA: 0x000BE57C File Offset: 0x000BC77C
		public virtual int GetContainerRadialResolution()
		{
			return vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetContainerRadialResolution_22(base.GetCppThis());
		}

		// Token: 0x06008563 RID: 34147
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraOrientationRepresentation_GetContainerRadialResolutionMaxValue_23(HandleRef pThis);

		/// <summary>
		/// Set container's radial resolution.
		/// </summary>
		// Token: 0x06008564 RID: 34148 RVA: 0x000BE59C File Offset: 0x000BC79C
		public virtual int GetContainerRadialResolutionMaxValue()
		{
			return vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetContainerRadialResolutionMaxValue_23(base.GetCppThis());
		}

		// Token: 0x06008565 RID: 34149
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraOrientationRepresentation_GetContainerRadialResolutionMinValue_24(HandleRef pThis);

		/// <summary>
		/// Set container's radial resolution.
		/// </summary>
		// Token: 0x06008566 RID: 34150 RVA: 0x000BE5BC File Offset: 0x000BC7BC
		public virtual int GetContainerRadialResolutionMinValue()
		{
			return vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetContainerRadialResolutionMinValue_24(base.GetCppThis());
		}

		// Token: 0x06008567 RID: 34151
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCameraOrientationRepresentation_GetContainerVisibility_25(HandleRef pThis);

		/// <summary>
		/// Show container to indicate mouse presence.
		/// </summary>
		// Token: 0x06008568 RID: 34152 RVA: 0x000BE5DC File Offset: 0x000BC7DC
		public bool GetContainerVisibility()
		{
			return vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetContainerVisibility_25(base.GetCppThis()) != 0;
		}

		// Token: 0x06008569 RID: 34153
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCameraOrientationRepresentation_GetElevation_26(HandleRef pThis);

		/// <summary>
		/// Orientation properties. (read only)
		/// </summary>
		// Token: 0x0600856A RID: 34154 RVA: 0x000BE604 File Offset: 0x000BC804
		public virtual double GetElevation()
		{
			return vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetElevation_26(base.GetCppThis());
		}

		// Token: 0x0600856B RID: 34155
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraOrientationRepresentation_GetHandleCircumferentialResolution_27(HandleRef pThis);

		/// <summary>
		/// Set Handle's circumferential resolution.
		/// </summary>
		// Token: 0x0600856C RID: 34156 RVA: 0x000BE624 File Offset: 0x000BC824
		public virtual int GetHandleCircumferentialResolution()
		{
			return vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetHandleCircumferentialResolution_27(base.GetCppThis());
		}

		// Token: 0x0600856D RID: 34157
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraOrientationRepresentation_GetHandleCircumferentialResolutionMaxValue_28(HandleRef pThis);

		/// <summary>
		/// Set Handle's circumferential resolution.
		/// </summary>
		// Token: 0x0600856E RID: 34158 RVA: 0x000BE644 File Offset: 0x000BC844
		public virtual int GetHandleCircumferentialResolutionMaxValue()
		{
			return vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetHandleCircumferentialResolutionMaxValue_28(base.GetCppThis());
		}

		// Token: 0x0600856F RID: 34159
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraOrientationRepresentation_GetHandleCircumferentialResolutionMinValue_29(HandleRef pThis);

		/// <summary>
		/// Set Handle's circumferential resolution.
		/// </summary>
		// Token: 0x06008570 RID: 34160 RVA: 0x000BE664 File Offset: 0x000BC864
		public virtual int GetHandleCircumferentialResolutionMinValue()
		{
			return vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetHandleCircumferentialResolutionMinValue_29(base.GetCppThis());
		}

		// Token: 0x06008571 RID: 34161
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkCameraOrientationRepresentation.InteractionStateType vtkCameraOrientationRepresentation_GetInteractionStateAsEnum_30(HandleRef pThis);

		/// <summary>
		/// Convenient method to get InteractionState as enum.
		/// This method clamps the interaction state to possible values.
		/// Hence, it does not raise any exceptions.
		/// </summary>
		// Token: 0x06008572 RID: 34162 RVA: 0x000BE684 File Offset: 0x000BC884
		public vtkCameraOrientationRepresentation.InteractionStateType GetInteractionStateAsEnum()
		{
			return vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetInteractionStateAsEnum_30(base.GetCppThis());
		}

		// Token: 0x06008573 RID: 34163
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCameraOrientationRepresentation_GetNormalizedHandleDia_31(HandleRef pThis);

		/// <summary>
		/// Set the normalized (0-1) diameter of the Handle.
		/// Default value: 0.4
		/// </summary>
		// Token: 0x06008574 RID: 34164 RVA: 0x000BE6A4 File Offset: 0x000BC8A4
		public virtual double GetNormalizedHandleDia()
		{
			return vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetNormalizedHandleDia_31(base.GetCppThis());
		}

		// Token: 0x06008575 RID: 34165
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCameraOrientationRepresentation_GetNumberOfGenerationsFromBase_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008576 RID: 34166 RVA: 0x000BE6C4 File Offset: 0x000BC8C4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetNumberOfGenerationsFromBase_32(base.GetCppThis(), type);
		}

		// Token: 0x06008577 RID: 34167
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCameraOrientationRepresentation_GetNumberOfGenerationsFromBaseType_33([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008578 RID: 34168 RVA: 0x000BE6E4 File Offset: 0x000BC8E4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetNumberOfGenerationsFromBaseType_33(type);
		}

		// Token: 0x06008579 RID: 34169
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraOrientationRepresentation_GetPadding_34(HandleRef pThis);

		/// <summary>
		/// Get/Set the widget padding in display coordinates.
		/// </summary>
		// Token: 0x0600857A RID: 34170 RVA: 0x000BE700 File Offset: 0x000BC900
		public virtual int[] GetPadding()
		{
			IntPtr intPtr = vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetPadding_34(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600857B RID: 34171
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_GetPadding_35(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Get/Set the widget padding in display coordinates.
		/// </summary>
		// Token: 0x0600857C RID: 34172 RVA: 0x000BE748 File Offset: 0x000BC948
		public virtual void GetPadding(ref int _arg1, ref int _arg2)
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetPadding_35(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600857D RID: 34173
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_GetPadding_36(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the widget padding in display coordinates.
		/// </summary>
		// Token: 0x0600857E RID: 34174 RVA: 0x000BE759 File Offset: 0x000BC959
		public virtual void GetPadding(IntPtr _arg)
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetPadding_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0600857F RID: 34175
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraOrientationRepresentation_GetPickedAxis_37(HandleRef pThis);

		/// <summary>
		/// Get picked axis, direction
		/// </summary>
		// Token: 0x06008580 RID: 34176 RVA: 0x000BE76C File Offset: 0x000BC96C
		public virtual int GetPickedAxis()
		{
			return vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetPickedAxis_37(base.GetCppThis());
		}

		// Token: 0x06008581 RID: 34177
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraOrientationRepresentation_GetPickedDir_38(HandleRef pThis);

		/// <summary>
		/// Get picked axis, direction
		/// </summary>
		// Token: 0x06008582 RID: 34178 RVA: 0x000BE78C File Offset: 0x000BC98C
		public virtual int GetPickedDir()
		{
			return vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetPickedDir_38(base.GetCppThis());
		}

		// Token: 0x06008583 RID: 34179
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraOrientationRepresentation_GetShaftResolution_39(HandleRef pThis);

		/// <summary>
		/// Set shaft's resolution.
		/// </summary>
		// Token: 0x06008584 RID: 34180 RVA: 0x000BE7AC File Offset: 0x000BC9AC
		public virtual int GetShaftResolution()
		{
			return vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetShaftResolution_39(base.GetCppThis());
		}

		// Token: 0x06008585 RID: 34181
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraOrientationRepresentation_GetShaftResolutionMaxValue_40(HandleRef pThis);

		/// <summary>
		/// Set shaft's resolution.
		/// </summary>
		// Token: 0x06008586 RID: 34182 RVA: 0x000BE7CC File Offset: 0x000BC9CC
		public virtual int GetShaftResolutionMaxValue()
		{
			return vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetShaftResolutionMaxValue_40(base.GetCppThis());
		}

		// Token: 0x06008587 RID: 34183
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraOrientationRepresentation_GetShaftResolutionMinValue_41(HandleRef pThis);

		/// <summary>
		/// Set shaft's resolution.
		/// </summary>
		// Token: 0x06008588 RID: 34184 RVA: 0x000BE7EC File Offset: 0x000BC9EC
		public virtual int GetShaftResolutionMinValue()
		{
			return vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetShaftResolutionMinValue_41(base.GetCppThis());
		}

		// Token: 0x06008589 RID: 34185
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraOrientationRepresentation_GetSize_42(HandleRef pThis);

		/// <summary>
		/// Get/Set the widget size in display coordinates.
		/// </summary>
		// Token: 0x0600858A RID: 34186 RVA: 0x000BE80C File Offset: 0x000BCA0C
		public virtual int[] GetSize()
		{
			IntPtr intPtr = vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetSize_42(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600858B RID: 34187
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_GetSize_43(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Get/Set the widget size in display coordinates.
		/// </summary>
		// Token: 0x0600858C RID: 34188 RVA: 0x000BE854 File Offset: 0x000BCA54
		public virtual void GetSize(ref int _arg1, ref int _arg2)
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetSize_43(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600858D RID: 34189
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_GetSize_44(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the widget size in display coordinates.
		/// </summary>
		// Token: 0x0600858E RID: 34190 RVA: 0x000BE865 File Offset: 0x000BCA65
		public virtual void GetSize(IntPtr _arg)
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetSize_44(base.GetCppThis(), _arg);
		}

		// Token: 0x0600858F RID: 34191
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCameraOrientationRepresentation_GetTotalLength_45(HandleRef pThis);

		/// <summary>
		/// Set the total length of the axes in 3 dimensions.
		/// This is basis of normalization. Default value: 1.
		/// </summary>
		// Token: 0x06008590 RID: 34192 RVA: 0x000BE878 File Offset: 0x000BCA78
		public virtual double GetTotalLength()
		{
			return vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetTotalLength_45(base.GetCppThis());
		}

		// Token: 0x06008591 RID: 34193
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraOrientationRepresentation_GetTransform_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve internal transform of this widget representation.
		/// </summary>
		// Token: 0x06008592 RID: 34194 RVA: 0x000BE898 File Offset: 0x000BCA98
		public vtkTransform GetTransform()
		{
			vtkTransform vtkTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetTransform_46(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransform = (vtkTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransform.Register(null);
				}
			}
			return vtkTransform;
		}

		// Token: 0x06008593 RID: 34195
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraOrientationRepresentation_GetUp_47(HandleRef pThis);

		/// <summary>
		/// Orientation properties. (read only)
		/// </summary>
		// Token: 0x06008594 RID: 34196 RVA: 0x000BE908 File Offset: 0x000BCB08
		public virtual double[] GetUp()
		{
			IntPtr intPtr = vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetUp_47(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008595 RID: 34197
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_GetUp_48(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Orientation properties. (read only)
		/// </summary>
		// Token: 0x06008596 RID: 34198 RVA: 0x000BE950 File Offset: 0x000BCB50
		public virtual void GetUp(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetUp_48(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06008597 RID: 34199
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_GetUp_49(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Orientation properties. (read only)
		/// </summary>
		// Token: 0x06008598 RID: 34200 RVA: 0x000BE962 File Offset: 0x000BCB62
		public virtual void GetUp(IntPtr _arg)
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetUp_49(base.GetCppThis(), _arg);
		}

		// Token: 0x06008599 RID: 34201
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraOrientationRepresentation_GetXMinusLabelProperty_50(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the '-' axis label properties.
		/// </summary>
		// Token: 0x0600859A RID: 34202 RVA: 0x000BE974 File Offset: 0x000BCB74
		public vtkTextProperty GetXMinusLabelProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetXMinusLabelProperty_50(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x0600859B RID: 34203
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraOrientationRepresentation_GetXPlusLabelProperty_51(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the '+' axis label properties.
		/// </summary>
		// Token: 0x0600859C RID: 34204 RVA: 0x000BE9E4 File Offset: 0x000BCBE4
		public vtkTextProperty GetXPlusLabelProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetXPlusLabelProperty_51(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x0600859D RID: 34205
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraOrientationRepresentation_GetYMinusLabelProperty_52(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the '-' axis label properties.
		/// </summary>
		// Token: 0x0600859E RID: 34206 RVA: 0x000BEA54 File Offset: 0x000BCC54
		public vtkTextProperty GetYMinusLabelProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetYMinusLabelProperty_52(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x0600859F RID: 34207
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraOrientationRepresentation_GetYPlusLabelProperty_53(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the '+' axis label properties.
		/// </summary>
		// Token: 0x060085A0 RID: 34208 RVA: 0x000BEAC4 File Offset: 0x000BCCC4
		public vtkTextProperty GetYPlusLabelProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetYPlusLabelProperty_53(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x060085A1 RID: 34209
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraOrientationRepresentation_GetZMinusLabelProperty_54(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the '-' axis label properties.
		/// </summary>
		// Token: 0x060085A2 RID: 34210 RVA: 0x000BEB34 File Offset: 0x000BCD34
		public vtkTextProperty GetZMinusLabelProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetZMinusLabelProperty_54(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x060085A3 RID: 34211
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraOrientationRepresentation_GetZPlusLabelProperty_55(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the '+' axis label properties.
		/// </summary>
		// Token: 0x060085A4 RID: 34212 RVA: 0x000BEBA4 File Offset: 0x000BCDA4
		public vtkTextProperty GetZPlusLabelProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_GetZPlusLabelProperty_55(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x060085A5 RID: 34213
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraOrientationRepresentation_HasTranslucentPolygonalGeometry_56(HandleRef pThis);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x060085A6 RID: 34214 RVA: 0x000BEC14 File Offset: 0x000BCE14
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_HasTranslucentPolygonalGeometry_56(base.GetCppThis());
		}

		// Token: 0x060085A7 RID: 34215
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraOrientationRepresentation_IsA_57(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060085A8 RID: 34216 RVA: 0x000BEC34 File Offset: 0x000BCE34
		public override int IsA(string type)
		{
			return vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_IsA_57(base.GetCppThis(), type);
		}

		// Token: 0x060085A9 RID: 34217
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCameraOrientationRepresentation_IsAnyHandleSelected_58(HandleRef pThis);

		/// <summary>
		/// Is a grabber button picked.
		/// </summary>
		// Token: 0x060085AA RID: 34218 RVA: 0x000BEC54 File Offset: 0x000BCE54
		public bool IsAnyHandleSelected()
		{
			return vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_IsAnyHandleSelected_58(base.GetCppThis()) != 0;
		}

		// Token: 0x060085AB RID: 34219
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraOrientationRepresentation_IsTypeOf_59([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060085AC RID: 34220 RVA: 0x000BEC7C File Offset: 0x000BCE7C
		public new static int IsTypeOf(string type)
		{
			return vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_IsTypeOf_59(type);
		}

		// Token: 0x060085AD RID: 34221
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraOrientationRepresentation_NewInstance_61(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060085AE RID: 34222 RVA: 0x000BEC98 File Offset: 0x000BCE98
		public new vtkCameraOrientationRepresentation NewInstance()
		{
			vtkCameraOrientationRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_NewInstance_61(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCameraOrientationRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060085AF RID: 34223
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_PlaceWidget_62(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x060085B0 RID: 34224 RVA: 0x000BECF2 File Offset: 0x000BCEF2
		public override void PlaceWidget(IntPtr arg0)
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_PlaceWidget_62(base.GetCppThis(), arg0);
		}

		// Token: 0x060085B1 RID: 34225
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_ReleaseGraphicsResources_63(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x060085B2 RID: 34226 RVA: 0x000BED04 File Offset: 0x000BCF04
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_ReleaseGraphicsResources_63(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060085B3 RID: 34227
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraOrientationRepresentation_RenderOpaqueGeometry_64(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x060085B4 RID: 34228 RVA: 0x000BED34 File Offset: 0x000BCF34
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_RenderOpaqueGeometry_64(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060085B5 RID: 34229
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraOrientationRepresentation_RenderTranslucentPolygonalGeometry_65(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x060085B6 RID: 34230 RVA: 0x000BED68 File Offset: 0x000BCF68
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_RenderTranslucentPolygonalGeometry_65(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060085B7 RID: 34231
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraOrientationRepresentation_SafeDownCast_66(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060085B8 RID: 34232 RVA: 0x000BED9C File Offset: 0x000BCF9C
		public new static vtkCameraOrientationRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkCameraOrientationRepresentation vtkCameraOrientationRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_SafeDownCast_66((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCameraOrientationRepresentation = (vtkCameraOrientationRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCameraOrientationRepresentation.Register(null);
				}
			}
			return vtkCameraOrientationRepresentation;
		}

		// Token: 0x060085B9 RID: 34233
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_SetContainerCircumferentialResolution_67(HandleRef pThis, int _arg);

		/// <summary>
		/// Set container's circumferential resolution.
		/// </summary>
		// Token: 0x060085BA RID: 34234 RVA: 0x000BEE1B File Offset: 0x000BD01B
		public virtual void SetContainerCircumferentialResolution(int _arg)
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_SetContainerCircumferentialResolution_67(base.GetCppThis(), _arg);
		}

		// Token: 0x060085BB RID: 34235
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_SetContainerRadialResolution_68(HandleRef pThis, int _arg);

		/// <summary>
		/// Set container's radial resolution.
		/// </summary>
		// Token: 0x060085BC RID: 34236 RVA: 0x000BEE2B File Offset: 0x000BD02B
		public virtual void SetContainerRadialResolution(int _arg)
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_SetContainerRadialResolution_68(base.GetCppThis(), _arg);
		}

		// Token: 0x060085BD RID: 34237
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_SetContainerVisibility_69(HandleRef pThis, byte state);

		/// <summary>
		/// Show container to indicate mouse presence.
		/// </summary>
		// Token: 0x060085BE RID: 34238 RVA: 0x000BEE3B File Offset: 0x000BD03B
		public void SetContainerVisibility(bool state)
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_SetContainerVisibility_69(base.GetCppThis(), state ? (byte)1 : (byte)0);
		}

		// Token: 0x060085BF RID: 34239
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_SetHandleCircumferentialResolution_70(HandleRef pThis, int _arg);

		/// <summary>
		/// Set Handle's circumferential resolution.
		/// </summary>
		// Token: 0x060085C0 RID: 34240 RVA: 0x000BEE53 File Offset: 0x000BD053
		public virtual void SetHandleCircumferentialResolution(int _arg)
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_SetHandleCircumferentialResolution_70(base.GetCppThis(), _arg);
		}

		// Token: 0x060085C1 RID: 34241
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_SetNormalizedHandleDia_71(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the normalized (0-1) diameter of the Handle.
		/// Default value: 0.4
		/// </summary>
		// Token: 0x060085C2 RID: 34242 RVA: 0x000BEE63 File Offset: 0x000BD063
		public virtual void SetNormalizedHandleDia(double _arg)
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_SetNormalizedHandleDia_71(base.GetCppThis(), _arg);
		}

		// Token: 0x060085C3 RID: 34243
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_SetPadding_72(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Get/Set the widget padding in display coordinates.
		/// </summary>
		// Token: 0x060085C4 RID: 34244 RVA: 0x000BEE73 File Offset: 0x000BD073
		public virtual void SetPadding(int _arg1, int _arg2)
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_SetPadding_72(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x060085C5 RID: 34245
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_SetPadding_73(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the widget padding in display coordinates.
		/// </summary>
		// Token: 0x060085C6 RID: 34246 RVA: 0x000BEE84 File Offset: 0x000BD084
		public void SetPadding(IntPtr _arg)
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_SetPadding_73(base.GetCppThis(), _arg);
		}

		// Token: 0x060085C7 RID: 34247
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_SetShaftResolution_74(HandleRef pThis, int _arg);

		/// <summary>
		/// Set shaft's resolution.
		/// </summary>
		// Token: 0x060085C8 RID: 34248 RVA: 0x000BEE94 File Offset: 0x000BD094
		public virtual void SetShaftResolution(int _arg)
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_SetShaftResolution_74(base.GetCppThis(), _arg);
		}

		// Token: 0x060085C9 RID: 34249
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_SetSize_75(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Get/Set the widget size in display coordinates.
		/// </summary>
		// Token: 0x060085CA RID: 34250 RVA: 0x000BEEA4 File Offset: 0x000BD0A4
		public virtual void SetSize(int _arg1, int _arg2)
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_SetSize_75(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x060085CB RID: 34251
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_SetSize_76(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the widget size in display coordinates.
		/// </summary>
		// Token: 0x060085CC RID: 34252 RVA: 0x000BEEB5 File Offset: 0x000BD0B5
		public void SetSize(IntPtr _arg)
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_SetSize_76(base.GetCppThis(), _arg);
		}

		// Token: 0x060085CD RID: 34253
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_SetTotalLength_77(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the total length of the axes in 3 dimensions.
		/// This is basis of normalization. Default value: 1.
		/// </summary>
		// Token: 0x060085CE RID: 34254 RVA: 0x000BEEC5 File Offset: 0x000BD0C5
		public virtual void SetTotalLength(double _arg)
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_SetTotalLength_77(base.GetCppThis(), _arg);
		}

		// Token: 0x060085CF RID: 34255
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_ShallowCopy_78(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Shallow copy of an axes actor. Overloads the virtual vtkProp method.
		/// </summary>
		// Token: 0x060085D0 RID: 34256 RVA: 0x000BEED8 File Offset: 0x000BD0D8
		public override void ShallowCopy(vtkProp prop)
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_ShallowCopy_78(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x060085D1 RID: 34257
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_StartWidgetInteraction_79(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x060085D2 RID: 34258 RVA: 0x000BEF07 File Offset: 0x000BD107
		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_StartWidgetInteraction_79(base.GetCppThis(), eventPos);
		}

		// Token: 0x060085D3 RID: 34259
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraOrientationRepresentation_WidgetInteraction_80(HandleRef pThis, IntPtr newEventPos);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x060085D4 RID: 34260 RVA: 0x000BEF17 File Offset: 0x000BD117
		public override void WidgetInteraction(IntPtr newEventPos)
		{
			vtkCameraOrientationRepresentation.vtkCameraOrientationRepresentation_WidgetInteraction_80(base.GetCppThis(), newEventPos);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B46 RID: 2886
		public new const string MRFullTypeName = "Kitware.VTK.vtkCameraOrientationRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B47 RID: 2887
		public new static readonly string MRClassNameKey = "class vtkCameraOrientationRepresentation";

		/// <summary>
		/// Get/Set the widget padding in display coordinates.
		/// </summary>
		// Token: 0x020002E6 RID: 742
		public enum AnchorType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000B49 RID: 2889
			LowerLeft,
			/// <summary>enum member</summary>
			// Token: 0x04000B4A RID: 2890
			LowerRight = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000B4B RID: 2891
			UpperLeft = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000B4C RID: 2892
			UpperRight = 3
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x020002E7 RID: 743
		public enum InteractionStateType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000B4E RID: 2894
			Hovering = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000B4F RID: 2895
			Outside = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000B50 RID: 2896
			Rotating = 2
		}
	}
}
