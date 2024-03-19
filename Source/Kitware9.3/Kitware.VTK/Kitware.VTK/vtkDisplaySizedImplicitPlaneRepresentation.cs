using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDisplaySizedImplicitPlaneRepresentation
	/// </summary>
	/// <remarks>
	///    a class defining the representation for a vtkDisplaySizedImplicitPlaneWidget
	///
	/// This class is a concrete representation for the
	/// vtkDisplaySizedImplicitPlaneWidget. It represents an display sized disk plane defined
	/// by a normal and point. Through interaction with the widget, the plane can be manipulated
	/// by adjusting the plane normal, disk radius or moving/picking the origin point.
	///
	/// To use this representation, you normally define a (plane) origin and (plane)
	/// normal. The PlaceWidget() method is also used to initially position the
	/// representation.
	///
	/// @warning
	/// This class, and vtkDisplaySizedImplicitPlaneWidget, are next generation VTK
	/// widgets.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDisplaySizedImplicitPlaneWidget vtkImplicitPlaneWidget2 vtkImplicitPlaneWidget
	/// vtkImplicitImageRepresentation
	/// </seealso>
	// Token: 0x0200030A RID: 778
	public class vtkDisplaySizedImplicitPlaneRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008B33 RID: 35635 RVA: 0x000C6DBF File Offset: 0x000C4FBF
		static vtkDisplaySizedImplicitPlaneRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDisplaySizedImplicitPlaneRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDisplaySizedImplicitPlaneRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008B34 RID: 35636 RVA: 0x000C6DE7 File Offset: 0x000C4FE7
		public vtkDisplaySizedImplicitPlaneRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008B35 RID: 35637
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06008B36 RID: 35638 RVA: 0x000C6DF8 File Offset: 0x000C4FF8
		public new static vtkDisplaySizedImplicitPlaneRepresentation New()
		{
			vtkDisplaySizedImplicitPlaneRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDisplaySizedImplicitPlaneRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06008B37 RID: 35639 RVA: 0x000C6E4C File Offset: 0x000C504C
		public vtkDisplaySizedImplicitPlaneRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008B38 RID: 35640 RVA: 0x000C6E90 File Offset: 0x000C5090
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008B39 RID: 35641
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Methods to interface with the vtkDisplaySizedImplicitPlaneWidget.
		/// </summary>
		// Token: 0x06008B3A RID: 35642 RVA: 0x000C6E9B File Offset: 0x000C509B
		public override void BuildRepresentation()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06008B3B RID: 35643
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_BumpPlane_02(HandleRef pThis, int dir, double factor);

		/// <summary>
		/// Translate the plane in the direction of the normal by the
		/// specified BumpDistance.  The dir parameter controls which
		/// direction the pushing occurs, either in the same direction
		/// as the normal, or when negative, in the opposite direction.
		/// The factor controls whether what percentage of the bump is
		/// used.
		/// </summary>
		// Token: 0x06008B3C RID: 35644 RVA: 0x000C6EAA File Offset: 0x000C50AA
		public void BumpPlane(int dir, double factor)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_BumpPlane_02(base.GetCppThis(), dir, factor);
		}

		// Token: 0x06008B3D RID: 35645
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_ComplexInteraction_03(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

		/// <summary>
		/// Methods to interface with the vtkDisplaySizedImplicitPlaneWidget.
		/// </summary>
		// Token: 0x06008B3E RID: 35646 RVA: 0x000C6EBC File Offset: 0x000C50BC
		public override void ComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_ComplexInteraction_03(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis(), (widget == null) ? default(HandleRef) : widget.GetCppThis(), arg2, calldata);
		}

		// Token: 0x06008B3F RID: 35647
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_ComputeComplexInteractionState_04(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata, int modify);

		/// <summary>
		/// Methods to interface with the vtkDisplaySizedImplicitPlaneWidget.
		/// </summary>
		// Token: 0x06008B40 RID: 35648 RVA: 0x000C6F04 File Offset: 0x000C5104
		public override int ComputeComplexInteractionState(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata, int modify)
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_ComputeComplexInteractionState_04(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis(), (widget == null) ? default(HandleRef) : widget.GetCppThis(), arg2, calldata, modify);
		}

		// Token: 0x06008B41 RID: 35649
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_ComputeInteractionState_05(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// Methods to interface with the vtkDisplaySizedImplicitPlaneWidget.
		/// </summary>
		// Token: 0x06008B42 RID: 35650 RVA: 0x000C6F54 File Offset: 0x000C5154
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_ComputeInteractionState_05(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x06008B43 RID: 35651
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_ConstrainMaximumSizeToWidgetBoundsOff_06(HandleRef pThis);

		/// <summary>
		/// Turn on/off whether the maximum widget size should be constrained to the widget bounds.
		/// If on, the radius of the disk plane and plane normal arrow will not be allowed to be larger
		/// than the half diagonal of the bounding box formed by the widget bounds.
		/// If off, the radius of the disk plane and plane normal arrow can be arbitrary big
		/// The default behaviour is off.
		/// </summary>
		// Token: 0x06008B44 RID: 35652 RVA: 0x000C6F76 File Offset: 0x000C5176
		public virtual void ConstrainMaximumSizeToWidgetBoundsOff()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_ConstrainMaximumSizeToWidgetBoundsOff_06(base.GetCppThis());
		}

		// Token: 0x06008B45 RID: 35653
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_ConstrainMaximumSizeToWidgetBoundsOn_07(HandleRef pThis);

		/// <summary>
		/// Turn on/off whether the maximum widget size should be constrained to the widget bounds.
		/// If on, the radius of the disk plane and plane normal arrow will not be allowed to be larger
		/// than the half diagonal of the bounding box formed by the widget bounds.
		/// If off, the radius of the disk plane and plane normal arrow can be arbitrary big
		/// The default behaviour is off.
		/// </summary>
		// Token: 0x06008B46 RID: 35654 RVA: 0x000C6F85 File Offset: 0x000C5185
		public virtual void ConstrainMaximumSizeToWidgetBoundsOn()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_ConstrainMaximumSizeToWidgetBoundsOn_07(base.GetCppThis());
		}

		// Token: 0x06008B47 RID: 35655
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_ConstrainToWidgetBoundsOff_08(HandleRef pThis);

		/// <summary>
		/// Turn on/off whether the plane should be constrained to the widget bounds.
		/// If on, the origin will not be allowed to move outside the set widget bounds.
		/// The default behaviour is off.
		/// If off, the origin can be freely moved and the widget outline will change
		/// accordingly.
		/// </summary>
		// Token: 0x06008B48 RID: 35656 RVA: 0x000C6F94 File Offset: 0x000C5194
		public virtual void ConstrainToWidgetBoundsOff()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_ConstrainToWidgetBoundsOff_08(base.GetCppThis());
		}

		// Token: 0x06008B49 RID: 35657
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_ConstrainToWidgetBoundsOn_09(HandleRef pThis);

		/// <summary>
		/// Turn on/off whether the plane should be constrained to the widget bounds.
		/// If on, the origin will not be allowed to move outside the set widget bounds.
		/// The default behaviour is off.
		/// If off, the origin can be freely moved and the widget outline will change
		/// accordingly.
		/// </summary>
		// Token: 0x06008B4A RID: 35658 RVA: 0x000C6FA3 File Offset: 0x000C51A3
		public virtual void ConstrainToWidgetBoundsOn()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_ConstrainToWidgetBoundsOn_09(base.GetCppThis());
		}

		// Token: 0x06008B4B RID: 35659
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_DrawIntersectionEdgesOff_10(HandleRef pThis);

		/// <summary>
		/// Enable/disable the drawing of the intersection edges. Default is off.
		///
		/// Note: drawing the intersection edges requires DrawOutline to be on.
		/// </summary>
		// Token: 0x06008B4C RID: 35660 RVA: 0x000C6FB2 File Offset: 0x000C51B2
		public virtual void DrawIntersectionEdgesOff()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_DrawIntersectionEdgesOff_10(base.GetCppThis());
		}

		// Token: 0x06008B4D RID: 35661
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_DrawIntersectionEdgesOn_11(HandleRef pThis);

		/// <summary>
		/// Enable/disable the drawing of the intersection edges. Default is off.
		///
		/// Note: drawing the intersection edges requires DrawOutline to be on.
		/// </summary>
		// Token: 0x06008B4E RID: 35662 RVA: 0x000C6FC1 File Offset: 0x000C51C1
		public virtual void DrawIntersectionEdgesOn()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_DrawIntersectionEdgesOn_11(base.GetCppThis());
		}

		// Token: 0x06008B4F RID: 35663
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_DrawOutlineOff_12(HandleRef pThis);

		/// <summary>
		/// Enable/disable the drawing of the outline. Default is off.
		/// </summary>
		// Token: 0x06008B50 RID: 35664 RVA: 0x000C6FD0 File Offset: 0x000C51D0
		public virtual void DrawOutlineOff()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_DrawOutlineOff_12(base.GetCppThis());
		}

		// Token: 0x06008B51 RID: 35665
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_DrawOutlineOn_13(HandleRef pThis);

		/// <summary>
		/// Enable/disable the drawing of the outline. Default is off.
		/// </summary>
		// Token: 0x06008B52 RID: 35666 RVA: 0x000C6FDF File Offset: 0x000C51DF
		public virtual void DrawOutlineOn()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_DrawOutlineOn_13(base.GetCppThis());
		}

		// Token: 0x06008B53 RID: 35667
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_DrawPlaneOff_14(HandleRef pThis);

		/// <summary>
		/// Enable/disable the drawing of the plane. In some cases the plane
		/// interferes with the object that it is operating on (i.e., the
		/// plane interferes with the cut surface it produces producing
		/// z-buffer artifacts.)
		/// </summary>
		// Token: 0x06008B54 RID: 35668 RVA: 0x000C6FEE File Offset: 0x000C51EE
		public virtual void DrawPlaneOff()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_DrawPlaneOff_14(base.GetCppThis());
		}

		// Token: 0x06008B55 RID: 35669
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_DrawPlaneOn_15(HandleRef pThis);

		/// <summary>
		/// Enable/disable the drawing of the plane. In some cases the plane
		/// interferes with the object that it is operating on (i.e., the
		/// plane interferes with the cut surface it produces producing
		/// z-buffer artifacts.)
		/// </summary>
		// Token: 0x06008B56 RID: 35670 RVA: 0x000C6FFD File Offset: 0x000C51FD
		public virtual void DrawPlaneOn()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_DrawPlaneOn_15(base.GetCppThis());
		}

		// Token: 0x06008B57 RID: 35671
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_EndComplexInteraction_16(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

		/// <summary>
		/// Methods to interface with the vtkDisplaySizedImplicitPlaneWidget.
		/// </summary>
		// Token: 0x06008B58 RID: 35672 RVA: 0x000C700C File Offset: 0x000C520C
		public override void EndComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_EndComplexInteraction_16(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis(), (widget == null) ? default(HandleRef) : widget.GetCppThis(), arg2, calldata);
		}

		// Token: 0x06008B59 RID: 35673
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_EndWidgetInteraction_17(HandleRef pThis, IntPtr newEventPos);

		/// <summary>
		/// Methods to interface with the vtkDisplaySizedImplicitPlaneWidget.
		/// </summary>
		// Token: 0x06008B5A RID: 35674 RVA: 0x000C7053 File Offset: 0x000C5253
		public override void EndWidgetInteraction(IntPtr newEventPos)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_EndWidgetInteraction_17(base.GetCppThis(), newEventPos);
		}

		// Token: 0x06008B5B RID: 35675
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_GetActors_18(HandleRef pThis, HandleRef pc);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x06008B5C RID: 35676 RVA: 0x000C7064 File Offset: 0x000C5264
		public override void GetActors(vtkPropCollection pc)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetActors_18(base.GetCppThis(), (pc == null) ? default(HandleRef) : pc.GetCppThis());
		}

		// Token: 0x06008B5D RID: 35677
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDisplaySizedImplicitPlaneRepresentation_GetAlwaysSnapToNearestAxis_19(HandleRef pThis);

		/// <summary>
		/// Forces the plane's normal to be aligned with x, y or z axis.
		/// The alignment happens when calling SetNormal.
		/// It defers with SnapToAxes from it is always applicable, and SnapToAxes
		/// only snaps when the angle difference exceeds 16 degrees in complex interactions.
		/// </summary>
		// Token: 0x06008B5E RID: 35678 RVA: 0x000C7094 File Offset: 0x000C5294
		public virtual bool GetAlwaysSnapToNearestAxis()
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetAlwaysSnapToNearestAxis_19(base.GetCppThis()) != 0;
		}

		// Token: 0x06008B5F RID: 35679
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetBounds_20(HandleRef pThis);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x06008B60 RID: 35680 RVA: 0x000C70BC File Offset: 0x000C52BC
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetBounds_20(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008B61 RID: 35681
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDisplaySizedImplicitPlaneRepresentation_GetBumpDistance_21(HandleRef pThis);

		/// <summary>
		/// Specify a translation distance used by the BumpPlane() method. Note that the
		/// distance is normalized; it is the fraction of the length of the bounding
		/// box of the wire outline.
		/// </summary>
		// Token: 0x06008B62 RID: 35682 RVA: 0x000C7104 File Offset: 0x000C5304
		public virtual double GetBumpDistance()
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetBumpDistance_21(base.GetCppThis());
		}

		// Token: 0x06008B63 RID: 35683
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDisplaySizedImplicitPlaneRepresentation_GetBumpDistanceMaxValue_22(HandleRef pThis);

		/// <summary>
		/// Specify a translation distance used by the BumpPlane() method. Note that the
		/// distance is normalized; it is the fraction of the length of the bounding
		/// box of the wire outline.
		/// </summary>
		// Token: 0x06008B64 RID: 35684 RVA: 0x000C7124 File Offset: 0x000C5324
		public virtual double GetBumpDistanceMaxValue()
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetBumpDistanceMaxValue_22(base.GetCppThis());
		}

		// Token: 0x06008B65 RID: 35685
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDisplaySizedImplicitPlaneRepresentation_GetBumpDistanceMinValue_23(HandleRef pThis);

		/// <summary>
		/// Specify a translation distance used by the BumpPlane() method. Note that the
		/// distance is normalized; it is the fraction of the length of the bounding
		/// box of the wire outline.
		/// </summary>
		// Token: 0x06008B66 RID: 35686 RVA: 0x000C7144 File Offset: 0x000C5344
		public virtual double GetBumpDistanceMinValue()
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetBumpDistanceMinValue_23(base.GetCppThis());
		}

		// Token: 0x06008B67 RID: 35687
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_GetConstrainMaximumSizeToWidgetBounds_24(HandleRef pThis);

		/// <summary>
		/// Turn on/off whether the maximum widget size should be constrained to the widget bounds.
		/// If on, the radius of the disk plane and plane normal arrow will not be allowed to be larger
		/// than the half diagonal of the bounding box formed by the widget bounds.
		/// If off, the radius of the disk plane and plane normal arrow can be arbitrary big
		/// The default behaviour is off.
		/// </summary>
		// Token: 0x06008B68 RID: 35688 RVA: 0x000C7164 File Offset: 0x000C5364
		public virtual int GetConstrainMaximumSizeToWidgetBounds()
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetConstrainMaximumSizeToWidgetBounds_24(base.GetCppThis());
		}

		// Token: 0x06008B69 RID: 35689
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_GetConstrainToWidgetBounds_25(HandleRef pThis);

		/// <summary>
		/// Turn on/off whether the plane should be constrained to the widget bounds.
		/// If on, the origin will not be allowed to move outside the set widget bounds.
		/// The default behaviour is off.
		/// If off, the origin can be freely moved and the widget outline will change
		/// accordingly.
		/// </summary>
		// Token: 0x06008B6A RID: 35690 RVA: 0x000C7184 File Offset: 0x000C5384
		public virtual int GetConstrainToWidgetBounds()
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetConstrainToWidgetBounds_25(base.GetCppThis());
		}

		// Token: 0x06008B6B RID: 35691
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_GetDrawIntersectionEdges_26(HandleRef pThis);

		/// <summary>
		/// Enable/disable the drawing of the intersection edges. Default is off.
		///
		/// Note: drawing the intersection edges requires DrawOutline to be on.
		/// </summary>
		// Token: 0x06008B6C RID: 35692 RVA: 0x000C71A4 File Offset: 0x000C53A4
		public virtual int GetDrawIntersectionEdges()
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetDrawIntersectionEdges_26(base.GetCppThis());
		}

		// Token: 0x06008B6D RID: 35693
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_GetDrawOutline_27(HandleRef pThis);

		/// <summary>
		/// Enable/disable the drawing of the outline. Default is off.
		/// </summary>
		// Token: 0x06008B6E RID: 35694 RVA: 0x000C71C4 File Offset: 0x000C53C4
		public virtual int GetDrawOutline()
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetDrawOutline_27(base.GetCppThis());
		}

		// Token: 0x06008B6F RID: 35695
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_GetDrawPlane_28(HandleRef pThis);

		/// <summary>
		/// Enable/disable the drawing of the plane. In some cases the plane
		/// interferes with the object that it is operating on (i.e., the
		/// plane interferes with the cut surface it produces producing
		/// z-buffer artifacts.)
		/// </summary>
		// Token: 0x06008B70 RID: 35696 RVA: 0x000C71E4 File Offset: 0x000C53E4
		public virtual int GetDrawPlane()
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetDrawPlane_28(base.GetCppThis());
		}

		// Token: 0x06008B71 RID: 35697
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetEdgesProperty_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the property of the disk edges. The properties of the edges when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06008B72 RID: 35698 RVA: 0x000C7204 File Offset: 0x000C5404
		public virtual vtkProperty GetEdgesProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetEdgesProperty_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008B73 RID: 35699
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_GetInteractionStateMaxValue_30(HandleRef pThis);

		/// <summary>
		/// The interaction state may be set from a widget (e.g.,
		/// vtkDisplaySizedImplicitPlaneWidget) or other object. This controls how the
		/// interaction with the widget proceeds. Normally this method is used as
		/// part of a handshaking process with the widget: First
		/// ComputeInteractionState() is invoked that returns a state based on
		/// geometric considerations (i.e., cursor near a widget feature), then
		/// based on events, the widget may modify this further.
		/// </summary>
		// Token: 0x06008B74 RID: 35700 RVA: 0x000C7274 File Offset: 0x000C5474
		public virtual int GetInteractionStateMaxValue()
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetInteractionStateMaxValue_30(base.GetCppThis());
		}

		// Token: 0x06008B75 RID: 35701
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_GetInteractionStateMinValue_31(HandleRef pThis);

		/// <summary>
		/// The interaction state may be set from a widget (e.g.,
		/// vtkDisplaySizedImplicitPlaneWidget) or other object. This controls how the
		/// interaction with the widget proceeds. Normally this method is used as
		/// part of a handshaking process with the widget: First
		/// ComputeInteractionState() is invoked that returns a state based on
		/// geometric considerations (i.e., cursor near a widget feature), then
		/// based on events, the widget may modify this further.
		/// </summary>
		// Token: 0x06008B76 RID: 35702 RVA: 0x000C7294 File Offset: 0x000C5494
		public virtual int GetInteractionStateMinValue()
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetInteractionStateMinValue_31(base.GetCppThis());
		}

		// Token: 0x06008B77 RID: 35703
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetIntersectionEdgesProperty_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the property of the intersection edges of the plane with the outline.
		/// </summary>
		// Token: 0x06008B78 RID: 35704 RVA: 0x000C72B4 File Offset: 0x000C54B4
		public virtual vtkProperty GetIntersectionEdgesProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetIntersectionEdgesProperty_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008B79 RID: 35705
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_GetLockNormalToCamera_33(HandleRef pThis);

		/// <summary>
		/// If enabled, and a vtkCamera is available through the renderer, then
		/// LockNormalToCamera will cause the normal to follow the camera's
		/// normal.
		/// </summary>
		// Token: 0x06008B7A RID: 35706 RVA: 0x000C7324 File Offset: 0x000C5524
		public virtual int GetLockNormalToCamera()
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetLockNormalToCamera_33(base.GetCppThis());
		}

		// Token: 0x06008B7B RID: 35707
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetNormal_34(HandleRef pThis);

		/// <summary>
		/// Set/Get the normal to the plane.
		/// </summary>
		// Token: 0x06008B7C RID: 35708 RVA: 0x000C7344 File Offset: 0x000C5544
		public IntPtr GetNormal()
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetNormal_34(base.GetCppThis());
		}

		// Token: 0x06008B7D RID: 35709
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_GetNormal_35(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// Set/Get the normal to the plane.
		/// </summary>
		// Token: 0x06008B7E RID: 35710 RVA: 0x000C7363 File Offset: 0x000C5563
		public void GetNormal(IntPtr xyz)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetNormal_35(base.GetCppThis(), xyz);
		}

		// Token: 0x06008B7F RID: 35711
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetNormalProperty_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties on the normal (line and cone). The properties of the normal when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06008B80 RID: 35712 RVA: 0x000C7374 File Offset: 0x000C5574
		public virtual vtkProperty GetNormalProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetNormalProperty_36(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008B81 RID: 35713
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_GetNormalToXAxis_37(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06008B82 RID: 35714 RVA: 0x000C73E4 File Offset: 0x000C55E4
		public virtual int GetNormalToXAxis()
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetNormalToXAxis_37(base.GetCppThis());
		}

		// Token: 0x06008B83 RID: 35715
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_GetNormalToYAxis_38(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06008B84 RID: 35716 RVA: 0x000C7404 File Offset: 0x000C5604
		public virtual int GetNormalToYAxis()
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetNormalToYAxis_38(base.GetCppThis());
		}

		// Token: 0x06008B85 RID: 35717
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_GetNormalToZAxis_39(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06008B86 RID: 35718 RVA: 0x000C7424 File Offset: 0x000C5624
		public virtual int GetNormalToZAxis()
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetNormalToZAxis_39(base.GetCppThis());
		}

		// Token: 0x06008B87 RID: 35719
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDisplaySizedImplicitPlaneRepresentation_GetNumberOfGenerationsFromBase_40(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008B88 RID: 35720 RVA: 0x000C7444 File Offset: 0x000C5644
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetNumberOfGenerationsFromBase_40(base.GetCppThis(), type);
		}

		// Token: 0x06008B89 RID: 35721
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDisplaySizedImplicitPlaneRepresentation_GetNumberOfGenerationsFromBaseType_41([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008B8A RID: 35722 RVA: 0x000C7464 File Offset: 0x000C5664
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetNumberOfGenerationsFromBaseType_41(type);
		}

		// Token: 0x06008B8B RID: 35723
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetOrigin_42(HandleRef pThis);

		/// <summary>
		/// Set/Get the origin of the plane.
		/// </summary>
		// Token: 0x06008B8C RID: 35724 RVA: 0x000C7480 File Offset: 0x000C5680
		public IntPtr GetOrigin()
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetOrigin_42(base.GetCppThis());
		}

		// Token: 0x06008B8D RID: 35725
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_GetOrigin_43(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// Set/Get the origin of the plane.
		/// </summary>
		// Token: 0x06008B8E RID: 35726 RVA: 0x000C749F File Offset: 0x000C569F
		public void GetOrigin(IntPtr xyz)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetOrigin_43(base.GetCppThis(), xyz);
		}

		// Token: 0x06008B8F RID: 35727
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetOutlineProperty_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the property of the outline.
		/// </summary>
		// Token: 0x06008B90 RID: 35728 RVA: 0x000C74B0 File Offset: 0x000C56B0
		public virtual vtkProperty GetOutlineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetOutlineProperty_44(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008B91 RID: 35729
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_GetOutlineTranslation_45(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to translate the bounding box by grabbing it
		/// with the left mouse button. Default is off.
		/// </summary>
		// Token: 0x06008B92 RID: 35730 RVA: 0x000C7520 File Offset: 0x000C5720
		public virtual int GetOutlineTranslation()
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetOutlineTranslation_45(base.GetCppThis());
		}

		// Token: 0x06008B93 RID: 35731
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_GetOutsideBounds_46(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to move the widget outside of the bounds
		/// specified in the initial PlaceWidget() invocation.
		/// </summary>
		// Token: 0x06008B94 RID: 35732 RVA: 0x000C7540 File Offset: 0x000C5740
		public virtual int GetOutsideBounds()
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetOutsideBounds_46(base.GetCppThis());
		}

		// Token: 0x06008B95 RID: 35733
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDisplaySizedImplicitPlaneRepresentation_GetPickCameraFocalInfo_47(HandleRef pThis);

		/// <summary>
		/// Enable/Disable picking camera focal info if no result is available for PickOrigin and
		/// PickNormal. The default is disabled.
		/// </summary>
		// Token: 0x06008B96 RID: 35734 RVA: 0x000C7560 File Offset: 0x000C5760
		public virtual bool GetPickCameraFocalInfo()
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetPickCameraFocalInfo_47(base.GetCppThis()) != 0;
		}

		// Token: 0x06008B97 RID: 35735
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_GetPlane_48(HandleRef pThis, HandleRef plane);

		/// <summary>
		/// Get the implicit function for the plane by copying the origin and normal
		/// of the cut plane into the provided vtkPlane. The user must provide the
		/// instance of the class vtkPlane. Note that vtkPlane is a subclass of
		/// vtkImplicitFunction, meaning that it can be used by a variety of filters
		/// to perform clipping, cutting, and selection of data.
		/// </summary>
		// Token: 0x06008B98 RID: 35736 RVA: 0x000C7588 File Offset: 0x000C5788
		public void GetPlane(vtkPlane plane)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetPlane_48(base.GetCppThis(), (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		// Token: 0x06008B99 RID: 35737
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetPlaneProperty_49(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the plane properties. The properties of the plane when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06008B9A RID: 35738 RVA: 0x000C75B8 File Offset: 0x000C57B8
		public virtual vtkProperty GetPlaneProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetPlaneProperty_49(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008B9B RID: 35739
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_GetPolyData_50(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Grab the polydata that defines the plane. The polydata contains a single
		/// polygon that is clipped by the bounding box.
		/// </summary>
		// Token: 0x06008B9C RID: 35740 RVA: 0x000C7628 File Offset: 0x000C5828
		public void GetPolyData(vtkPolyData pd)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetPolyData_50(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x06008B9D RID: 35741
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetPolyDataAlgorithm_51(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Satisfies superclass API.  This returns a pointer to the underlying
		/// PolyData (which represents the plane).
		/// </summary>
		// Token: 0x06008B9E RID: 35742 RVA: 0x000C7658 File Offset: 0x000C5858
		public vtkPolyDataAlgorithm GetPolyDataAlgorithm()
		{
			vtkPolyDataAlgorithm vtkPolyDataAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetPolyDataAlgorithm_51(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataAlgorithm = (vtkPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataAlgorithm.Register(null);
				}
			}
			return vtkPolyDataAlgorithm;
		}

		// Token: 0x06008B9F RID: 35743
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDisplaySizedImplicitPlaneRepresentation_GetRadiusMultiplier_52(HandleRef pThis);

		/// <summary>
		/// Set/Get the Radius Multiplier value. Default is 1.0.
		/// </summary>
		// Token: 0x06008BA0 RID: 35744 RVA: 0x000C76C8 File Offset: 0x000C58C8
		public virtual double GetRadiusMultiplier()
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetRadiusMultiplier_52(base.GetCppThis());
		}

		// Token: 0x06008BA1 RID: 35745
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDisplaySizedImplicitPlaneRepresentation_GetRadiusMultiplierMaxValue_53(HandleRef pThis);

		/// <summary>
		/// Set/Get the Radius Multiplier value. Default is 1.0.
		/// </summary>
		// Token: 0x06008BA2 RID: 35746 RVA: 0x000C76E8 File Offset: 0x000C58E8
		public virtual double GetRadiusMultiplierMaxValue()
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetRadiusMultiplierMaxValue_53(base.GetCppThis());
		}

		// Token: 0x06008BA3 RID: 35747
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDisplaySizedImplicitPlaneRepresentation_GetRadiusMultiplierMinValue_54(HandleRef pThis);

		/// <summary>
		/// Set/Get the Radius Multiplier value. Default is 1.0.
		/// </summary>
		// Token: 0x06008BA4 RID: 35748 RVA: 0x000C7708 File Offset: 0x000C5908
		public virtual double GetRadiusMultiplierMinValue()
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetRadiusMultiplierMinValue_54(base.GetCppThis());
		}

		// Token: 0x06008BA5 RID: 35749
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_GetRepresentationState_55(HandleRef pThis);

		/// <summary>
		/// Sets the visual appearance of the representation based on the
		/// state it is in. This state is usually the same as InteractionState.
		/// </summary>
		// Token: 0x06008BA6 RID: 35750 RVA: 0x000C7728 File Offset: 0x000C5928
		public virtual int GetRepresentationState()
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetRepresentationState_55(base.GetCppThis());
		}

		// Token: 0x06008BA7 RID: 35751
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_GetScaleEnabled_56(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to scale the widget with the mouse.
		/// </summary>
		// Token: 0x06008BA8 RID: 35752 RVA: 0x000C7748 File Offset: 0x000C5948
		public virtual int GetScaleEnabled()
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetScaleEnabled_56(base.GetCppThis());
		}

		// Token: 0x06008BA9 RID: 35753
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetSelectedEdgesProperty_57(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the property of the disk edges. The properties of the edges when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06008BAA RID: 35754 RVA: 0x000C7768 File Offset: 0x000C5968
		public virtual vtkProperty GetSelectedEdgesProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetSelectedEdgesProperty_57(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008BAB RID: 35755
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetSelectedNormalProperty_58(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties on the normal (line and cone). The properties of the normal when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06008BAC RID: 35756 RVA: 0x000C77D8 File Offset: 0x000C59D8
		public virtual vtkProperty GetSelectedNormalProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetSelectedNormalProperty_58(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008BAD RID: 35757
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetSelectedOutlineProperty_59(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the property of the outline.
		/// </summary>
		// Token: 0x06008BAE RID: 35758 RVA: 0x000C7848 File Offset: 0x000C5A48
		public virtual vtkProperty GetSelectedOutlineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetSelectedOutlineProperty_59(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008BAF RID: 35759
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetSelectedPlaneProperty_60(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the plane properties. The properties of the plane when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06008BB0 RID: 35760 RVA: 0x000C78B8 File Offset: 0x000C5AB8
		public virtual vtkProperty GetSelectedPlaneProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetSelectedPlaneProperty_60(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008BB1 RID: 35761
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetSelectedSphereProperty_61(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties on the sphere. The properties of the sphere when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06008BB2 RID: 35762 RVA: 0x000C7928 File Offset: 0x000C5B28
		public virtual vtkProperty GetSelectedSphereProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetSelectedSphereProperty_61(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008BB3 RID: 35763
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDisplaySizedImplicitPlaneRepresentation_GetSnapToAxes_62(HandleRef pThis);

		/// <summary>
		/// For complex events should we snap orientations to
		/// be aligned with the x y z axes.
		/// </summary>
		// Token: 0x06008BB4 RID: 35764 RVA: 0x000C7998 File Offset: 0x000C5B98
		public virtual bool GetSnapToAxes()
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetSnapToAxes_62(base.GetCppThis()) != 0;
		}

		// Token: 0x06008BB5 RID: 35765
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetSphereProperty_63(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties on the sphere. The properties of the sphere when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06008BB6 RID: 35766 RVA: 0x000C79C0 File Offset: 0x000C5BC0
		public virtual vtkProperty GetSphereProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetSphereProperty_63(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008BB7 RID: 35767
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetUnderlyingPlane_64(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Sets the visual appearance of the representation based on the
		/// state it is in. This state is usually the same as InteractionState.
		/// </summary>
		// Token: 0x06008BB8 RID: 35768 RVA: 0x000C7A30 File Offset: 0x000C5C30
		public vtkPlane GetUnderlyingPlane()
		{
			vtkPlane vtkPlane = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetUnderlyingPlane_64(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlane = (vtkPlane)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlane.Register(null);
				}
			}
			return vtkPlane;
		}

		// Token: 0x06008BB9 RID: 35769
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_GetWidgetBounds_65(HandleRef pThis);

		/// <summary>
		/// Set/Get the bounds of the widget representation. PlaceWidget can also be
		/// used to set the bounds of the widget but it may also have other effects
		/// on the internal state of the representation. Use this function when only
		/// the widget bounds need to be modified.
		/// </summary>
		// Token: 0x06008BBA RID: 35770 RVA: 0x000C7AA0 File Offset: 0x000C5CA0
		public virtual double[] GetWidgetBounds()
		{
			IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetWidgetBounds_65(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008BBB RID: 35771
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_GetWidgetBounds_66(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

		/// <summary>
		/// Set/Get the bounds of the widget representation. PlaceWidget can also be
		/// used to set the bounds of the widget but it may also have other effects
		/// on the internal state of the representation. Use this function when only
		/// the widget bounds need to be modified.
		/// </summary>
		// Token: 0x06008BBC RID: 35772 RVA: 0x000C7AE8 File Offset: 0x000C5CE8
		public virtual void GetWidgetBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetWidgetBounds_66(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x06008BBD RID: 35773
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_GetWidgetBounds_67(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the bounds of the widget representation. PlaceWidget can also be
		/// used to set the bounds of the widget but it may also have other effects
		/// on the internal state of the representation. Use this function when only
		/// the widget bounds need to be modified.
		/// </summary>
		// Token: 0x06008BBE RID: 35774 RVA: 0x000C7B00 File Offset: 0x000C5D00
		public virtual void GetWidgetBounds(IntPtr _arg)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_GetWidgetBounds_67(base.GetCppThis(), _arg);
		}

		// Token: 0x06008BBF RID: 35775
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_HasTranslucentPolygonalGeometry_68(HandleRef pThis);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x06008BC0 RID: 35776 RVA: 0x000C7B10 File Offset: 0x000C5D10
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_HasTranslucentPolygonalGeometry_68(base.GetCppThis());
		}

		// Token: 0x06008BC1 RID: 35777
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_IsA_69(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008BC2 RID: 35778 RVA: 0x000C7B30 File Offset: 0x000C5D30
		public override int IsA(string type)
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_IsA_69(base.GetCppThis(), type);
		}

		// Token: 0x06008BC3 RID: 35779
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDisplaySizedImplicitPlaneRepresentation_IsTranslationConstrained_70(HandleRef pThis);

		/// <summary>
		/// Returns true if ConstrainedAxis
		/// </summary>
		// Token: 0x06008BC4 RID: 35780 RVA: 0x000C7B50 File Offset: 0x000C5D50
		public bool IsTranslationConstrained()
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_IsTranslationConstrained_70(base.GetCppThis()) != 0;
		}

		// Token: 0x06008BC5 RID: 35781
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_IsTypeOf_71([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008BC6 RID: 35782 RVA: 0x000C7B78 File Offset: 0x000C5D78
		public new static int IsTypeOf(string type)
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_IsTypeOf_71(type);
		}

		// Token: 0x06008BC7 RID: 35783
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_LockNormalToCameraOff_72(HandleRef pThis);

		/// <summary>
		/// If enabled, and a vtkCamera is available through the renderer, then
		/// LockNormalToCamera will cause the normal to follow the camera's
		/// normal.
		/// </summary>
		// Token: 0x06008BC8 RID: 35784 RVA: 0x000C7B92 File Offset: 0x000C5D92
		public virtual void LockNormalToCameraOff()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_LockNormalToCameraOff_72(base.GetCppThis());
		}

		// Token: 0x06008BC9 RID: 35785
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_LockNormalToCameraOn_73(HandleRef pThis);

		/// <summary>
		/// If enabled, and a vtkCamera is available through the renderer, then
		/// LockNormalToCamera will cause the normal to follow the camera's
		/// normal.
		/// </summary>
		// Token: 0x06008BCA RID: 35786 RVA: 0x000C7BA1 File Offset: 0x000C5DA1
		public virtual void LockNormalToCameraOn()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_LockNormalToCameraOn_73(base.GetCppThis());
		}

		// Token: 0x06008BCB RID: 35787
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_NewInstance_75(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008BCC RID: 35788 RVA: 0x000C7BB0 File Offset: 0x000C5DB0
		public new vtkDisplaySizedImplicitPlaneRepresentation NewInstance()
		{
			vtkDisplaySizedImplicitPlaneRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_NewInstance_75(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDisplaySizedImplicitPlaneRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008BCD RID: 35789
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_NormalToXAxisOff_76(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06008BCE RID: 35790 RVA: 0x000C7C0A File Offset: 0x000C5E0A
		public virtual void NormalToXAxisOff()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_NormalToXAxisOff_76(base.GetCppThis());
		}

		// Token: 0x06008BCF RID: 35791
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_NormalToXAxisOn_77(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06008BD0 RID: 35792 RVA: 0x000C7C19 File Offset: 0x000C5E19
		public virtual void NormalToXAxisOn()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_NormalToXAxisOn_77(base.GetCppThis());
		}

		// Token: 0x06008BD1 RID: 35793
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_NormalToYAxisOff_78(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06008BD2 RID: 35794 RVA: 0x000C7C28 File Offset: 0x000C5E28
		public virtual void NormalToYAxisOff()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_NormalToYAxisOff_78(base.GetCppThis());
		}

		// Token: 0x06008BD3 RID: 35795
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_NormalToYAxisOn_79(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06008BD4 RID: 35796 RVA: 0x000C7C37 File Offset: 0x000C5E37
		public virtual void NormalToYAxisOn()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_NormalToYAxisOn_79(base.GetCppThis());
		}

		// Token: 0x06008BD5 RID: 35797
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_NormalToZAxisOff_80(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06008BD6 RID: 35798 RVA: 0x000C7C46 File Offset: 0x000C5E46
		public virtual void NormalToZAxisOff()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_NormalToZAxisOff_80(base.GetCppThis());
		}

		// Token: 0x06008BD7 RID: 35799
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_NormalToZAxisOn_81(HandleRef pThis);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06008BD8 RID: 35800 RVA: 0x000C7C55 File Offset: 0x000C5E55
		public virtual void NormalToZAxisOn()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_NormalToZAxisOn_81(base.GetCppThis());
		}

		// Token: 0x06008BD9 RID: 35801
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_OutlineTranslationOff_82(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to translate the bounding box by grabbing it
		/// with the left mouse button. Default is off.
		/// </summary>
		// Token: 0x06008BDA RID: 35802 RVA: 0x000C7C64 File Offset: 0x000C5E64
		public virtual void OutlineTranslationOff()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_OutlineTranslationOff_82(base.GetCppThis());
		}

		// Token: 0x06008BDB RID: 35803
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_OutlineTranslationOn_83(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to translate the bounding box by grabbing it
		/// with the left mouse button. Default is off.
		/// </summary>
		// Token: 0x06008BDC RID: 35804 RVA: 0x000C7C73 File Offset: 0x000C5E73
		public virtual void OutlineTranslationOn()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_OutlineTranslationOn_83(base.GetCppThis());
		}

		// Token: 0x06008BDD RID: 35805
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_OutsideBoundsOff_84(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to move the widget outside of the bounds
		/// specified in the initial PlaceWidget() invocation.
		/// </summary>
		// Token: 0x06008BDE RID: 35806 RVA: 0x000C7C82 File Offset: 0x000C5E82
		public virtual void OutsideBoundsOff()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_OutsideBoundsOff_84(base.GetCppThis());
		}

		// Token: 0x06008BDF RID: 35807
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_OutsideBoundsOn_85(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to move the widget outside of the bounds
		/// specified in the initial PlaceWidget() invocation.
		/// </summary>
		// Token: 0x06008BE0 RID: 35808 RVA: 0x000C7C91 File Offset: 0x000C5E91
		public virtual void OutsideBoundsOn()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_OutsideBoundsOn_85(base.GetCppThis());
		}

		// Token: 0x06008BE1 RID: 35809
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_PickCameraFocalInfoOff_86(HandleRef pThis);

		/// <summary>
		/// Enable/Disable picking camera focal info if no result is available for PickOrigin and
		/// PickNormal. The default is disabled.
		/// </summary>
		// Token: 0x06008BE2 RID: 35810 RVA: 0x000C7CA0 File Offset: 0x000C5EA0
		public virtual void PickCameraFocalInfoOff()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_PickCameraFocalInfoOff_86(base.GetCppThis());
		}

		// Token: 0x06008BE3 RID: 35811
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_PickCameraFocalInfoOn_87(HandleRef pThis);

		/// <summary>
		/// Enable/Disable picking camera focal info if no result is available for PickOrigin and
		/// PickNormal. The default is disabled.
		/// </summary>
		// Token: 0x06008BE4 RID: 35812 RVA: 0x000C7CAF File Offset: 0x000C5EAF
		public virtual void PickCameraFocalInfoOn()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_PickCameraFocalInfoOn_87(base.GetCppThis());
		}

		// Token: 0x06008BE5 RID: 35813
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDisplaySizedImplicitPlaneRepresentation_PickNormal_88(HandleRef pThis, int X, int Y, byte snapToMeshPoint);

		/// <summary>
		/// Given the X, Y display coordinates, pick a new normal for the plane
		/// from a point that is on the objects rendered by the renderer.
		///
		/// Note: if a normal from a rendered object is not picked, the camera plane normal can optionally
		/// be set.
		/// </summary>
		// Token: 0x06008BE6 RID: 35814 RVA: 0x000C7CC0 File Offset: 0x000C5EC0
		public bool PickNormal(int X, int Y, bool snapToMeshPoint)
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_PickNormal_88(base.GetCppThis(), X, Y, snapToMeshPoint ? (byte)1 : (byte)0) != 0;
		}

		// Token: 0x06008BE7 RID: 35815
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDisplaySizedImplicitPlaneRepresentation_PickOrigin_89(HandleRef pThis, int X, int Y, byte snapToMeshPoint);

		/// <summary>
		/// Given the X, Y display coordinates, pick a new origin for the plane
		/// from a point that is on the objects rendered by the renderer.
		///
		/// Note: if a point from a rendered object is not picked, the camera focal point can optionally be
		/// set.
		/// </summary>
		// Token: 0x06008BE8 RID: 35816 RVA: 0x000C7CF4 File Offset: 0x000C5EF4
		public bool PickOrigin(int X, int Y, bool snapToMeshPoint)
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_PickOrigin_89(base.GetCppThis(), X, Y, snapToMeshPoint ? (byte)1 : (byte)0) != 0;
		}

		// Token: 0x06008BE9 RID: 35817
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_PlaceWidget_90(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Methods to interface with the vtkDisplaySizedImplicitPlaneWidget.
		/// </summary>
		// Token: 0x06008BEA RID: 35818 RVA: 0x000C7D25 File Offset: 0x000C5F25
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_PlaceWidget_90(base.GetCppThis(), bounds);
		}

		// Token: 0x06008BEB RID: 35819
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_PushPlane_91(HandleRef pThis, double distance);

		/// <summary>
		/// Push the plane the distance specified along the normal. Positive
		/// values are in the direction of the normal; negative values are
		/// in the opposite direction of the normal. The distance value is
		/// expressed in world coordinates.
		/// </summary>
		// Token: 0x06008BEC RID: 35820 RVA: 0x000C7D35 File Offset: 0x000C5F35
		public void PushPlane(double distance)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_PushPlane_91(base.GetCppThis(), distance);
		}

		// Token: 0x06008BED RID: 35821
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_ReleaseGraphicsResources_92(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x06008BEE RID: 35822 RVA: 0x000C7D48 File Offset: 0x000C5F48
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_ReleaseGraphicsResources_92(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008BEF RID: 35823
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_RenderOpaqueGeometry_93(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x06008BF0 RID: 35824 RVA: 0x000C7D78 File Offset: 0x000C5F78
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_RenderOpaqueGeometry_93(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008BF1 RID: 35825
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDisplaySizedImplicitPlaneRepresentation_RenderTranslucentPolygonalGeometry_94(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x06008BF2 RID: 35826 RVA: 0x000C7DAC File Offset: 0x000C5FAC
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_RenderTranslucentPolygonalGeometry_94(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008BF3 RID: 35827
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDisplaySizedImplicitPlaneRepresentation_SafeDownCast_95(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008BF4 RID: 35828 RVA: 0x000C7DE0 File Offset: 0x000C5FE0
		public new static vtkDisplaySizedImplicitPlaneRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkDisplaySizedImplicitPlaneRepresentation vtkDisplaySizedImplicitPlaneRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SafeDownCast_95((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDisplaySizedImplicitPlaneRepresentation = (vtkDisplaySizedImplicitPlaneRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDisplaySizedImplicitPlaneRepresentation.Register(null);
				}
			}
			return vtkDisplaySizedImplicitPlaneRepresentation;
		}

		// Token: 0x06008BF5 RID: 35829
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_ScaleEnabledOff_96(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to scale the widget with the mouse.
		/// </summary>
		// Token: 0x06008BF6 RID: 35830 RVA: 0x000C7E5F File Offset: 0x000C605F
		public virtual void ScaleEnabledOff()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_ScaleEnabledOff_96(base.GetCppThis());
		}

		// Token: 0x06008BF7 RID: 35831
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_ScaleEnabledOn_97(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to scale the widget with the mouse.
		/// </summary>
		// Token: 0x06008BF8 RID: 35832 RVA: 0x000C7E6E File Offset: 0x000C606E
		public virtual void ScaleEnabledOn()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_ScaleEnabledOn_97(base.GetCppThis());
		}

		// Token: 0x06008BF9 RID: 35833
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetAlwaysSnapToNearestAxis_98(HandleRef pThis, byte snap);

		/// <summary>
		/// Forces the plane's normal to be aligned with x, y or z axis.
		/// The alignment happens when calling SetNormal.
		/// It defers with SnapToAxes from it is always applicable, and SnapToAxes
		/// only snaps when the angle difference exceeds 16 degrees in complex interactions.
		/// </summary>
		// Token: 0x06008BFA RID: 35834 RVA: 0x000C7E7D File Offset: 0x000C607D
		public virtual void SetAlwaysSnapToNearestAxis(bool snap)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetAlwaysSnapToNearestAxis_98(base.GetCppThis(), snap ? (byte)1 : (byte)0);
		}

		// Token: 0x06008BFB RID: 35835
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetBumpDistance_99(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify a translation distance used by the BumpPlane() method. Note that the
		/// distance is normalized; it is the fraction of the length of the bounding
		/// box of the wire outline.
		/// </summary>
		// Token: 0x06008BFC RID: 35836 RVA: 0x000C7E95 File Offset: 0x000C6095
		public virtual void SetBumpDistance(double _arg)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetBumpDistance_99(base.GetCppThis(), _arg);
		}

		// Token: 0x06008BFD RID: 35837
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetConstrainMaximumSizeToWidgetBounds_100(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off whether the maximum widget size should be constrained to the widget bounds.
		/// If on, the radius of the disk plane and plane normal arrow will not be allowed to be larger
		/// than the half diagonal of the bounding box formed by the widget bounds.
		/// If off, the radius of the disk plane and plane normal arrow can be arbitrary big
		/// The default behaviour is off.
		/// </summary>
		// Token: 0x06008BFE RID: 35838 RVA: 0x000C7EA5 File Offset: 0x000C60A5
		public virtual void SetConstrainMaximumSizeToWidgetBounds(int _arg)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetConstrainMaximumSizeToWidgetBounds_100(base.GetCppThis(), _arg);
		}

		// Token: 0x06008BFF RID: 35839
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetConstrainToWidgetBounds_101(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off whether the plane should be constrained to the widget bounds.
		/// If on, the origin will not be allowed to move outside the set widget bounds.
		/// The default behaviour is off.
		/// If off, the origin can be freely moved and the widget outline will change
		/// accordingly.
		/// </summary>
		// Token: 0x06008C00 RID: 35840 RVA: 0x000C7EB5 File Offset: 0x000C60B5
		public virtual void SetConstrainToWidgetBounds(int _arg)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetConstrainToWidgetBounds_101(base.GetCppThis(), _arg);
		}

		// Token: 0x06008C01 RID: 35841
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetDrawIntersectionEdges_102(HandleRef pThis, int intersectionEdges);

		/// <summary>
		/// Enable/disable the drawing of the intersection edges. Default is off.
		///
		/// Note: drawing the intersection edges requires DrawOutline to be on.
		/// </summary>
		// Token: 0x06008C02 RID: 35842 RVA: 0x000C7EC5 File Offset: 0x000C60C5
		public void SetDrawIntersectionEdges(int intersectionEdges)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetDrawIntersectionEdges_102(base.GetCppThis(), intersectionEdges);
		}

		// Token: 0x06008C03 RID: 35843
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetDrawOutline_103(HandleRef pThis, int outline);

		/// <summary>
		/// Enable/disable the drawing of the outline. Default is off.
		/// </summary>
		// Token: 0x06008C04 RID: 35844 RVA: 0x000C7ED5 File Offset: 0x000C60D5
		public void SetDrawOutline(int outline)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetDrawOutline_103(base.GetCppThis(), outline);
		}

		// Token: 0x06008C05 RID: 35845
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetDrawPlane_104(HandleRef pThis, int plane);

		/// <summary>
		/// Enable/disable the drawing of the plane. In some cases the plane
		/// interferes with the object that it is operating on (i.e., the
		/// plane interferes with the cut surface it produces producing
		/// z-buffer artifacts.)
		/// </summary>
		// Token: 0x06008C06 RID: 35846 RVA: 0x000C7EE5 File Offset: 0x000C60E5
		public void SetDrawPlane(int plane)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetDrawPlane_104(base.GetCppThis(), plane);
		}

		// Token: 0x06008C07 RID: 35847
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetForegroundColor_105(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Set the color of all the widget's handles (edges, cone1, cone2, line, sphere, selected plane)
		/// and their color during interaction. Foreground color applies to the outlines and unselected
		/// plane.
		/// </summary>
		// Token: 0x06008C08 RID: 35848 RVA: 0x000C7EF5 File Offset: 0x000C60F5
		public void SetForegroundColor(double arg0, double arg1, double arg2)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetForegroundColor_105(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x06008C09 RID: 35849
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetForegroundColor_106(HandleRef pThis, IntPtr c);

		/// <summary>
		/// Set the color of all the widget's handles (edges, cone1, cone2, line, sphere, selected plane)
		/// and their color during interaction. Foreground color applies to the outlines and unselected
		/// plane.
		/// </summary>
		// Token: 0x06008C0A RID: 35850 RVA: 0x000C7F07 File Offset: 0x000C6107
		public void SetForegroundColor(IntPtr c)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetForegroundColor_106(base.GetCppThis(), c);
		}

		// Token: 0x06008C0B RID: 35851
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetHandleColor_107(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Set the color of all the widget's handles (edges, cone1, cone2, line, sphere, selected plane)
		/// and their color during interaction. Foreground color applies to the outlines and unselected
		/// plane.
		/// </summary>
		// Token: 0x06008C0C RID: 35852 RVA: 0x000C7F17 File Offset: 0x000C6117
		public void SetHandleColor(double arg0, double arg1, double arg2)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetHandleColor_107(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x06008C0D RID: 35853
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetHandleColor_108(HandleRef pThis, IntPtr c);

		/// <summary>
		/// Set the color of all the widget's handles (edges, cone1, cone2, line, sphere, selected plane)
		/// and their color during interaction. Foreground color applies to the outlines and unselected
		/// plane.
		/// </summary>
		// Token: 0x06008C0E RID: 35854 RVA: 0x000C7F29 File Offset: 0x000C6129
		public void SetHandleColor(IntPtr c)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetHandleColor_108(base.GetCppThis(), c);
		}

		// Token: 0x06008C0F RID: 35855
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetInteractionColor_109(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Set the color of all the widget's handles (edges, cone1, cone2, line, sphere, selected plane)
		/// and their color during interaction. Foreground color applies to the outlines and unselected
		/// plane.
		/// </summary>
		// Token: 0x06008C10 RID: 35856 RVA: 0x000C7F39 File Offset: 0x000C6139
		public void SetInteractionColor(double arg0, double arg1, double arg2)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetInteractionColor_109(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x06008C11 RID: 35857
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetInteractionColor_110(HandleRef pThis, IntPtr c);

		/// <summary>
		/// Set the color of all the widget's handles (edges, cone1, cone2, line, sphere, selected plane)
		/// and their color during interaction. Foreground color applies to the outlines and unselected
		/// plane.
		/// </summary>
		// Token: 0x06008C12 RID: 35858 RVA: 0x000C7F4B File Offset: 0x000C614B
		public void SetInteractionColor(IntPtr c)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetInteractionColor_110(base.GetCppThis(), c);
		}

		// Token: 0x06008C13 RID: 35859
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetInteractionState_111(HandleRef pThis, int _arg);

		/// <summary>
		/// The interaction state may be set from a widget (e.g.,
		/// vtkDisplaySizedImplicitPlaneWidget) or other object. This controls how the
		/// interaction with the widget proceeds. Normally this method is used as
		/// part of a handshaking process with the widget: First
		/// ComputeInteractionState() is invoked that returns a state based on
		/// geometric considerations (i.e., cursor near a widget feature), then
		/// based on events, the widget may modify this further.
		/// </summary>
		// Token: 0x06008C14 RID: 35860 RVA: 0x000C7F5B File Offset: 0x000C615B
		public virtual void SetInteractionState(int _arg)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetInteractionState_111(base.GetCppThis(), _arg);
		}

		// Token: 0x06008C15 RID: 35861
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetLockNormalToCamera_112(HandleRef pThis, int arg0);

		/// <summary>
		/// If enabled, and a vtkCamera is available through the renderer, then
		/// LockNormalToCamera will cause the normal to follow the camera's
		/// normal.
		/// </summary>
		// Token: 0x06008C16 RID: 35862 RVA: 0x000C7F6B File Offset: 0x000C616B
		public virtual void SetLockNormalToCamera(int arg0)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetLockNormalToCamera_112(base.GetCppThis(), arg0);
		}

		// Token: 0x06008C17 RID: 35863
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetNormal_113(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set/Get the normal to the plane.
		/// </summary>
		// Token: 0x06008C18 RID: 35864 RVA: 0x000C7F7B File Offset: 0x000C617B
		public void SetNormal(double x, double y, double z)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetNormal_113(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06008C19 RID: 35865
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetNormal_114(HandleRef pThis, IntPtr n);

		/// <summary>
		/// Set/Get the normal to the plane.
		/// </summary>
		// Token: 0x06008C1A RID: 35866 RVA: 0x000C7F8D File Offset: 0x000C618D
		public void SetNormal(IntPtr n)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetNormal_114(base.GetCppThis(), n);
		}

		// Token: 0x06008C1B RID: 35867
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetNormalToCamera_115(HandleRef pThis);

		/// <summary>
		/// Set/Get the normal to the plane.
		/// </summary>
		// Token: 0x06008C1C RID: 35868 RVA: 0x000C7F9D File Offset: 0x000C619D
		public void SetNormalToCamera()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetNormalToCamera_115(base.GetCppThis());
		}

		// Token: 0x06008C1D RID: 35869
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetNormalToXAxis_116(HandleRef pThis, int arg0);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06008C1E RID: 35870 RVA: 0x000C7FAC File Offset: 0x000C61AC
		public void SetNormalToXAxis(int arg0)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetNormalToXAxis_116(base.GetCppThis(), arg0);
		}

		// Token: 0x06008C1F RID: 35871
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetNormalToYAxis_117(HandleRef pThis, int arg0);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06008C20 RID: 35872 RVA: 0x000C7FBC File Offset: 0x000C61BC
		public void SetNormalToYAxis(int arg0)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetNormalToYAxis_117(base.GetCppThis(), arg0);
		}

		// Token: 0x06008C21 RID: 35873
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetNormalToZAxis_118(HandleRef pThis, int arg0);

		/// <summary>
		/// Force the plane widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the plane to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x06008C22 RID: 35874 RVA: 0x000C7FCC File Offset: 0x000C61CC
		public void SetNormalToZAxis(int arg0)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetNormalToZAxis_118(base.GetCppThis(), arg0);
		}

		// Token: 0x06008C23 RID: 35875
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetOrigin_119(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set/Get the origin of the plane.
		/// </summary>
		// Token: 0x06008C24 RID: 35876 RVA: 0x000C7FDC File Offset: 0x000C61DC
		public void SetOrigin(double x, double y, double z)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetOrigin_119(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06008C25 RID: 35877
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetOrigin_120(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Set/Get the origin of the plane.
		/// </summary>
		// Token: 0x06008C26 RID: 35878 RVA: 0x000C7FEE File Offset: 0x000C61EE
		public void SetOrigin(IntPtr x)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetOrigin_120(base.GetCppThis(), x);
		}

		// Token: 0x06008C27 RID: 35879
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetOutlineTranslation_121(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the ability to translate the bounding box by grabbing it
		/// with the left mouse button. Default is off.
		/// </summary>
		// Token: 0x06008C28 RID: 35880 RVA: 0x000C7FFE File Offset: 0x000C61FE
		public virtual void SetOutlineTranslation(int _arg)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetOutlineTranslation_121(base.GetCppThis(), _arg);
		}

		// Token: 0x06008C29 RID: 35881
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetOutsideBounds_122(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the ability to move the widget outside of the bounds
		/// specified in the initial PlaceWidget() invocation.
		/// </summary>
		// Token: 0x06008C2A RID: 35882 RVA: 0x000C800E File Offset: 0x000C620E
		public virtual void SetOutsideBounds(int _arg)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetOutsideBounds_122(base.GetCppThis(), _arg);
		}

		// Token: 0x06008C2B RID: 35883
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetPickCameraFocalInfo_123(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable/Disable picking camera focal info if no result is available for PickOrigin and
		/// PickNormal. The default is disabled.
		/// </summary>
		// Token: 0x06008C2C RID: 35884 RVA: 0x000C801E File Offset: 0x000C621E
		public virtual void SetPickCameraFocalInfo(bool _arg)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetPickCameraFocalInfo_123(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06008C2D RID: 35885
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetPlane_124(HandleRef pThis, HandleRef plane);

		/// <summary>
		/// Alternative way to define the cutting plane. The normal and origin of
		/// the plane provided is copied into the internal instance of the class
		/// cutting vtkPlane.
		/// </summary>
		// Token: 0x06008C2E RID: 35886 RVA: 0x000C8038 File Offset: 0x000C6238
		public void SetPlane(vtkPlane plane)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetPlane_124(base.GetCppThis(), (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		// Token: 0x06008C2F RID: 35887
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetRadiusMultiplier_125(HandleRef pThis, double radiusMultiplier);

		/// <summary>
		/// Set/Get the Radius Multiplier value. Default is 1.0.
		/// </summary>
		// Token: 0x06008C30 RID: 35888 RVA: 0x000C8067 File Offset: 0x000C6267
		public virtual void SetRadiusMultiplier(double radiusMultiplier)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetRadiusMultiplier_125(base.GetCppThis(), radiusMultiplier);
		}

		// Token: 0x06008C31 RID: 35889
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetRepresentationState_126(HandleRef pThis, int arg0);

		/// <summary>
		/// Sets the visual appearance of the representation based on the
		/// state it is in. This state is usually the same as InteractionState.
		/// </summary>
		// Token: 0x06008C32 RID: 35890 RVA: 0x000C8077 File Offset: 0x000C6277
		public virtual void SetRepresentationState(int arg0)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetRepresentationState_126(base.GetCppThis(), arg0);
		}

		// Token: 0x06008C33 RID: 35891
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetScaleEnabled_127(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the ability to scale the widget with the mouse.
		/// </summary>
		// Token: 0x06008C34 RID: 35892 RVA: 0x000C8087 File Offset: 0x000C6287
		public virtual void SetScaleEnabled(int _arg)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetScaleEnabled_127(base.GetCppThis(), _arg);
		}

		// Token: 0x06008C35 RID: 35893
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetSnapToAxes_128(HandleRef pThis, byte _arg);

		/// <summary>
		/// For complex events should we snap orientations to
		/// be aligned with the x y z axes.
		/// </summary>
		// Token: 0x06008C36 RID: 35894 RVA: 0x000C8097 File Offset: 0x000C6297
		public virtual void SetSnapToAxes(bool _arg)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetSnapToAxes_128(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06008C37 RID: 35895
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetTranslationAxisOff_129(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x06008C38 RID: 35896 RVA: 0x000C80AF File Offset: 0x000C62AF
		public void SetTranslationAxisOff()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetTranslationAxisOff_129(base.GetCppThis());
		}

		// Token: 0x06008C39 RID: 35897
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetWidgetBounds_130(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Set/Get the bounds of the widget representation. PlaceWidget can also be
		/// used to set the bounds of the widget but it may also have other effects
		/// on the internal state of the representation. Use this function when only
		/// the widget bounds need to be modified.
		/// </summary>
		// Token: 0x06008C3A RID: 35898 RVA: 0x000C80BE File Offset: 0x000C62BE
		public virtual void SetWidgetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetWidgetBounds_130(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x06008C3B RID: 35899
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetWidgetBounds_131(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the bounds of the widget representation. PlaceWidget can also be
		/// used to set the bounds of the widget but it may also have other effects
		/// on the internal state of the representation. Use this function when only
		/// the widget bounds need to be modified.
		/// </summary>
		// Token: 0x06008C3C RID: 35900 RVA: 0x000C80D6 File Offset: 0x000C62D6
		public virtual void SetWidgetBounds(IntPtr _arg)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetWidgetBounds_131(base.GetCppThis(), _arg);
		}

		// Token: 0x06008C3D RID: 35901
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetXTranslationAxisOn_132(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x06008C3E RID: 35902 RVA: 0x000C80E6 File Offset: 0x000C62E6
		public void SetXTranslationAxisOn()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetXTranslationAxisOn_132(base.GetCppThis());
		}

		// Token: 0x06008C3F RID: 35903
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetYTranslationAxisOn_133(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x06008C40 RID: 35904 RVA: 0x000C80F5 File Offset: 0x000C62F5
		public void SetYTranslationAxisOn()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetYTranslationAxisOn_133(base.GetCppThis());
		}

		// Token: 0x06008C41 RID: 35905
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SetZTranslationAxisOn_134(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x06008C42 RID: 35906 RVA: 0x000C8104 File Offset: 0x000C6304
		public void SetZTranslationAxisOn()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SetZTranslationAxisOn_134(base.GetCppThis());
		}

		// Token: 0x06008C43 RID: 35907
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SnapToAxesOff_135(HandleRef pThis);

		/// <summary>
		/// For complex events should we snap orientations to
		/// be aligned with the x y z axes.
		/// </summary>
		// Token: 0x06008C44 RID: 35908 RVA: 0x000C8113 File Offset: 0x000C6313
		public virtual void SnapToAxesOff()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SnapToAxesOff_135(base.GetCppThis());
		}

		// Token: 0x06008C45 RID: 35909
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_SnapToAxesOn_136(HandleRef pThis);

		/// <summary>
		/// For complex events should we snap orientations to
		/// be aligned with the x y z axes.
		/// </summary>
		// Token: 0x06008C46 RID: 35910 RVA: 0x000C8122 File Offset: 0x000C6322
		public virtual void SnapToAxesOn()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_SnapToAxesOn_136(base.GetCppThis());
		}

		// Token: 0x06008C47 RID: 35911
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_StartComplexInteraction_137(HandleRef pThis, HandleRef iren, HandleRef widget, uint arg2, IntPtr calldata);

		/// <summary>
		/// Methods to interface with the vtkDisplaySizedImplicitPlaneWidget.
		/// </summary>
		// Token: 0x06008C48 RID: 35912 RVA: 0x000C8134 File Offset: 0x000C6334
		public override void StartComplexInteraction(vtkRenderWindowInteractor iren, vtkAbstractWidget widget, uint arg2, IntPtr calldata)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_StartComplexInteraction_137(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis(), (widget == null) ? default(HandleRef) : widget.GetCppThis(), arg2, calldata);
		}

		// Token: 0x06008C49 RID: 35913
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_StartWidgetInteraction_138(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Methods to interface with the vtkDisplaySizedImplicitPlaneWidget.
		/// </summary>
		// Token: 0x06008C4A RID: 35914 RVA: 0x000C817B File Offset: 0x000C637B
		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_StartWidgetInteraction_138(base.GetCppThis(), eventPos);
		}

		// Token: 0x06008C4B RID: 35915
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_UpdatePlacement_139(HandleRef pThis);

		/// <summary>
		/// Satisfies the superclass API.  This will change the state of the widget
		/// to match changes that have been made to the underlying PolyDataSource
		/// </summary>
		// Token: 0x06008C4C RID: 35916 RVA: 0x000C818B File Offset: 0x000C638B
		public void UpdatePlacement()
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_UpdatePlacement_139(base.GetCppThis());
		}

		// Token: 0x06008C4D RID: 35917
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDisplaySizedImplicitPlaneRepresentation_WidgetInteraction_140(HandleRef pThis, IntPtr newEventPos);

		/// <summary>
		/// Methods to interface with the vtkDisplaySizedImplicitPlaneWidget.
		/// </summary>
		// Token: 0x06008C4E RID: 35918 RVA: 0x000C819A File Offset: 0x000C639A
		public override void WidgetInteraction(IntPtr newEventPos)
		{
			vtkDisplaySizedImplicitPlaneRepresentation.vtkDisplaySizedImplicitPlaneRepresentation_WidgetInteraction_140(base.GetCppThis(), newEventPos);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BB9 RID: 3001
		public new const string MRFullTypeName = "Kitware.VTK.vtkDisplaySizedImplicitPlaneRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BBA RID: 3002
		public new static readonly string MRClassNameKey = "class vtkDisplaySizedImplicitPlaneRepresentation";

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x0200030B RID: 779
		public enum InteractionStateType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000BBC RID: 3004
			Moving = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000BBD RID: 3005
			MovingOrigin = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000BBE RID: 3006
			MovingOutline = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000BBF RID: 3007
			Outside = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000BC0 RID: 3008
			Pushing = 5,
			/// <summary>enum member</summary>
			// Token: 0x04000BC1 RID: 3009
			ResizeDiskRadius,
			/// <summary>enum member</summary>
			// Token: 0x04000BC2 RID: 3010
			Rotating = 4,
			/// <summary>enum member</summary>
			// Token: 0x04000BC3 RID: 3011
			Scaling = 7
		}
	}
}
