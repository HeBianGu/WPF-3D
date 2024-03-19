using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImplicitCylinderRepresentation
	/// </summary>
	/// <remarks>
	///    defining the representation for a vtkImplicitCylinderWidget
	///
	/// This class is a concrete representation for the
	/// vtkImplicitCylinderWidget. It represents an infinite cylinder
	/// defined by a radius, a center, and an axis. The cylinder is placed
	/// within its associated bounding box and the intersection of the
	/// cylinder with the bounding box is shown to visually indicate the
	/// orientation and position of the representation. This cylinder
	/// representation can be manipulated by using the
	/// vtkImplicitCylinderWidget to adjust the cylinder radius, axis,
	/// and/or center point. (Note that the bounding box is defined during
	/// invocation of the superclass' PlaceWidget() method.)
	///
	/// To use this representation, you normally specify a radius, center,
	/// and axis. Optionally you can specify a minimum and maximum radius,
	/// and a resolution for the cylinder. Finally, place the widget and
	/// its representation in the scene using PlaceWidget().
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImplicitCylinderWidget vtkImplicitPlaneWidget vtkImplicitPlaneWidget
	/// </seealso>
	// Token: 0x0200032A RID: 810
	public class vtkImplicitCylinderRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060091B3 RID: 37299 RVA: 0x000CF13D File Offset: 0x000CD33D
		static vtkImplicitCylinderRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitCylinderRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitCylinderRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060091B4 RID: 37300 RVA: 0x000CF165 File Offset: 0x000CD365
		public vtkImplicitCylinderRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060091B5 RID: 37301
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitCylinderRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x060091B6 RID: 37302 RVA: 0x000CF174 File Offset: 0x000CD374
		public new static vtkImplicitCylinderRepresentation New()
		{
			vtkImplicitCylinderRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitCylinderRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x060091B7 RID: 37303 RVA: 0x000CF1C8 File Offset: 0x000CD3C8
		public vtkImplicitCylinderRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060091B8 RID: 37304 RVA: 0x000CF20C File Offset: 0x000CD40C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060091B9 RID: 37305
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_AlongXAxisOff_01(HandleRef pThis);

		/// <summary>
		/// Force the cylinder widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the cylinder to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x060091BA RID: 37306 RVA: 0x000CF217 File Offset: 0x000CD417
		public virtual void AlongXAxisOff()
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_AlongXAxisOff_01(base.GetCppThis());
		}

		// Token: 0x060091BB RID: 37307
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_AlongXAxisOn_02(HandleRef pThis);

		/// <summary>
		/// Force the cylinder widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the cylinder to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x060091BC RID: 37308 RVA: 0x000CF226 File Offset: 0x000CD426
		public virtual void AlongXAxisOn()
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_AlongXAxisOn_02(base.GetCppThis());
		}

		// Token: 0x060091BD RID: 37309
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_AlongYAxisOff_03(HandleRef pThis);

		/// <summary>
		/// Force the cylinder widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the cylinder to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x060091BE RID: 37310 RVA: 0x000CF235 File Offset: 0x000CD435
		public virtual void AlongYAxisOff()
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_AlongYAxisOff_03(base.GetCppThis());
		}

		// Token: 0x060091BF RID: 37311
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_AlongYAxisOn_04(HandleRef pThis);

		/// <summary>
		/// Force the cylinder widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the cylinder to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x060091C0 RID: 37312 RVA: 0x000CF244 File Offset: 0x000CD444
		public virtual void AlongYAxisOn()
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_AlongYAxisOn_04(base.GetCppThis());
		}

		// Token: 0x060091C1 RID: 37313
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_AlongZAxisOff_05(HandleRef pThis);

		/// <summary>
		/// Force the cylinder widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the cylinder to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x060091C2 RID: 37314 RVA: 0x000CF253 File Offset: 0x000CD453
		public virtual void AlongZAxisOff()
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_AlongZAxisOff_05(base.GetCppThis());
		}

		// Token: 0x060091C3 RID: 37315
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_AlongZAxisOn_06(HandleRef pThis);

		/// <summary>
		/// Force the cylinder widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the cylinder to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x060091C4 RID: 37316 RVA: 0x000CF262 File Offset: 0x000CD462
		public virtual void AlongZAxisOn()
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_AlongZAxisOn_06(base.GetCppThis());
		}

		// Token: 0x060091C5 RID: 37317
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_BuildRepresentation_07(HandleRef pThis);

		/// <summary>
		/// Methods to interface with the vtkImplicitCylinderWidget.
		/// </summary>
		// Token: 0x060091C6 RID: 37318 RVA: 0x000CF271 File Offset: 0x000CD471
		public override void BuildRepresentation()
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_BuildRepresentation_07(base.GetCppThis());
		}

		// Token: 0x060091C7 RID: 37319
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_BumpCylinder_08(HandleRef pThis, int dir, double factor);

		/// <summary>
		/// Translate the cylinder in the direction of the view vector by the
		/// specified BumpDistance. The dir parameter controls which
		/// direction the pushing occurs, either in the same direction as the
		/// view vector, or when negative, in the opposite direction.  The factor
		/// controls what percentage of the bump is used.
		/// </summary>
		// Token: 0x060091C8 RID: 37320 RVA: 0x000CF280 File Offset: 0x000CD480
		public void BumpCylinder(int dir, double factor)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_BumpCylinder_08(base.GetCppThis(), dir, factor);
		}

		// Token: 0x060091C9 RID: 37321
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitCylinderRepresentation_ComputeInteractionState_09(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// Methods to interface with the vtkImplicitCylinderWidget.
		/// </summary>
		// Token: 0x060091CA RID: 37322 RVA: 0x000CF294 File Offset: 0x000CD494
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_ComputeInteractionState_09(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x060091CB RID: 37323
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_ConstrainToWidgetBoundsOff_10(HandleRef pThis);

		/// <summary>
		/// Turn on/off whether the cylinder should be constrained to the widget bounds.
		/// If on, the center will not be allowed to move outside the set widget bounds
		/// and the radius will be limited by MinRadius and MaxRadius. This is the
		/// default behaviour.
		/// If off, the center can be freely moved and the radius can be set to
		/// arbitrary values. The widget outline will change accordingly.
		/// </summary>
		// Token: 0x060091CC RID: 37324 RVA: 0x000CF2B6 File Offset: 0x000CD4B6
		public virtual void ConstrainToWidgetBoundsOff()
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_ConstrainToWidgetBoundsOff_10(base.GetCppThis());
		}

		// Token: 0x060091CD RID: 37325
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_ConstrainToWidgetBoundsOn_11(HandleRef pThis);

		/// <summary>
		/// Turn on/off whether the cylinder should be constrained to the widget bounds.
		/// If on, the center will not be allowed to move outside the set widget bounds
		/// and the radius will be limited by MinRadius and MaxRadius. This is the
		/// default behaviour.
		/// If off, the center can be freely moved and the radius can be set to
		/// arbitrary values. The widget outline will change accordingly.
		/// </summary>
		// Token: 0x060091CE RID: 37326 RVA: 0x000CF2C5 File Offset: 0x000CD4C5
		public virtual void ConstrainToWidgetBoundsOn()
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_ConstrainToWidgetBoundsOn_11(base.GetCppThis());
		}

		// Token: 0x060091CF RID: 37327
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_DrawCylinderOff_12(HandleRef pThis);

		/// <summary>
		/// Enable/disable the drawing of the cylinder. In some cases the cylinder
		/// interferes with the object that it is operating on (e.g., the
		/// cylinder interferes with the cut surface it produces resulting in
		/// z-buffer artifacts.) By default it is off.
		/// </summary>
		// Token: 0x060091D0 RID: 37328 RVA: 0x000CF2D4 File Offset: 0x000CD4D4
		public virtual void DrawCylinderOff()
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_DrawCylinderOff_12(base.GetCppThis());
		}

		// Token: 0x060091D1 RID: 37329
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_DrawCylinderOn_13(HandleRef pThis);

		/// <summary>
		/// Enable/disable the drawing of the cylinder. In some cases the cylinder
		/// interferes with the object that it is operating on (e.g., the
		/// cylinder interferes with the cut surface it produces resulting in
		/// z-buffer artifacts.) By default it is off.
		/// </summary>
		// Token: 0x060091D2 RID: 37330 RVA: 0x000CF2E3 File Offset: 0x000CD4E3
		public virtual void DrawCylinderOn()
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_DrawCylinderOn_13(base.GetCppThis());
		}

		// Token: 0x060091D3 RID: 37331
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_EndWidgetInteraction_14(HandleRef pThis, IntPtr newEventPos);

		/// <summary>
		/// Methods to interface with the vtkImplicitCylinderWidget.
		/// </summary>
		// Token: 0x060091D4 RID: 37332 RVA: 0x000CF2F2 File Offset: 0x000CD4F2
		public override void EndWidgetInteraction(IntPtr newEventPos)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_EndWidgetInteraction_14(base.GetCppThis(), newEventPos);
		}

		// Token: 0x060091D5 RID: 37333
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_GetActors_15(HandleRef pThis, HandleRef pc);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x060091D6 RID: 37334 RVA: 0x000CF304 File Offset: 0x000CD504
		public override void GetActors(vtkPropCollection pc)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetActors_15(base.GetCppThis(), (pc == null) ? default(HandleRef) : pc.GetCppThis());
		}

		// Token: 0x060091D7 RID: 37335
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitCylinderRepresentation_GetAlongXAxis_16(HandleRef pThis);

		/// <summary>
		/// Force the cylinder widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the cylinder to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x060091D8 RID: 37336 RVA: 0x000CF334 File Offset: 0x000CD534
		public virtual int GetAlongXAxis()
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetAlongXAxis_16(base.GetCppThis());
		}

		// Token: 0x060091D9 RID: 37337
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitCylinderRepresentation_GetAlongYAxis_17(HandleRef pThis);

		/// <summary>
		/// Force the cylinder widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the cylinder to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x060091DA RID: 37338 RVA: 0x000CF354 File Offset: 0x000CD554
		public virtual int GetAlongYAxis()
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetAlongYAxis_17(base.GetCppThis());
		}

		// Token: 0x060091DB RID: 37339
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitCylinderRepresentation_GetAlongZAxis_18(HandleRef pThis);

		/// <summary>
		/// Force the cylinder widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the cylinder to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x060091DC RID: 37340 RVA: 0x000CF374 File Offset: 0x000CD574
		public virtual int GetAlongZAxis()
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetAlongZAxis_18(base.GetCppThis());
		}

		// Token: 0x060091DD RID: 37341
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitCylinderRepresentation_GetAxis_19(HandleRef pThis);

		/// <summary>
		/// Set/Get the axis of rotation for the cylinder. If the axis is not
		/// specified as a unit vector, it will be normalized.
		/// </summary>
		// Token: 0x060091DE RID: 37342 RVA: 0x000CF394 File Offset: 0x000CD594
		public double[] GetAxis()
		{
			IntPtr intPtr = vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetAxis_19(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060091DF RID: 37343
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_GetAxis_20(HandleRef pThis, IntPtr a);

		/// <summary>
		/// Set/Get the axis of rotation for the cylinder. If the axis is not
		/// specified as a unit vector, it will be normalized.
		/// </summary>
		// Token: 0x060091E0 RID: 37344 RVA: 0x000CF3DC File Offset: 0x000CD5DC
		public void GetAxis(IntPtr a)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetAxis_20(base.GetCppThis(), a);
		}

		// Token: 0x060091E1 RID: 37345
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitCylinderRepresentation_GetAxisProperty_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties on the axis (line and cone).
		/// </summary>
		// Token: 0x060091E2 RID: 37346 RVA: 0x000CF3EC File Offset: 0x000CD5EC
		public virtual vtkProperty GetAxisProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetAxisProperty_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060091E3 RID: 37347
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitCylinderRepresentation_GetBounds_22(HandleRef pThis);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x060091E4 RID: 37348 RVA: 0x000CF45C File Offset: 0x000CD65C
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetBounds_22(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060091E5 RID: 37349
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitCylinderRepresentation_GetBumpDistance_23(HandleRef pThis);

		/// <summary>
		/// Specify a translation distance used by the BumpCylinder() method. Note that the
		/// distance is normalized; it is the fraction of the length of the bounding
		/// box of the wire outline.
		/// </summary>
		// Token: 0x060091E6 RID: 37350 RVA: 0x000CF4A4 File Offset: 0x000CD6A4
		public virtual double GetBumpDistance()
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetBumpDistance_23(base.GetCppThis());
		}

		// Token: 0x060091E7 RID: 37351
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitCylinderRepresentation_GetBumpDistanceMaxValue_24(HandleRef pThis);

		/// <summary>
		/// Specify a translation distance used by the BumpCylinder() method. Note that the
		/// distance is normalized; it is the fraction of the length of the bounding
		/// box of the wire outline.
		/// </summary>
		// Token: 0x060091E8 RID: 37352 RVA: 0x000CF4C4 File Offset: 0x000CD6C4
		public virtual double GetBumpDistanceMaxValue()
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetBumpDistanceMaxValue_24(base.GetCppThis());
		}

		// Token: 0x060091E9 RID: 37353
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitCylinderRepresentation_GetBumpDistanceMinValue_25(HandleRef pThis);

		/// <summary>
		/// Specify a translation distance used by the BumpCylinder() method. Note that the
		/// distance is normalized; it is the fraction of the length of the bounding
		/// box of the wire outline.
		/// </summary>
		// Token: 0x060091EA RID: 37354 RVA: 0x000CF4E4 File Offset: 0x000CD6E4
		public virtual double GetBumpDistanceMinValue()
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetBumpDistanceMinValue_25(base.GetCppThis());
		}

		// Token: 0x060091EB RID: 37355
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitCylinderRepresentation_GetCenter_26(HandleRef pThis);

		/// <summary>
		/// Get the center of the cylinder. The center is located along the
		/// cylinder axis.
		/// </summary>
		// Token: 0x060091EC RID: 37356 RVA: 0x000CF504 File Offset: 0x000CD704
		public double[] GetCenter()
		{
			IntPtr intPtr = vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetCenter_26(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060091ED RID: 37357
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_GetCenter_27(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// Get the center of the cylinder. The center is located along the
		/// cylinder axis.
		/// </summary>
		// Token: 0x060091EE RID: 37358 RVA: 0x000CF54C File Offset: 0x000CD74C
		public void GetCenter(IntPtr xyz)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetCenter_27(base.GetCppThis(), xyz);
		}

		// Token: 0x060091EF RID: 37359
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitCylinderRepresentation_GetConstrainToWidgetBounds_28(HandleRef pThis);

		/// <summary>
		/// Turn on/off whether the cylinder should be constrained to the widget bounds.
		/// If on, the center will not be allowed to move outside the set widget bounds
		/// and the radius will be limited by MinRadius and MaxRadius. This is the
		/// default behaviour.
		/// If off, the center can be freely moved and the radius can be set to
		/// arbitrary values. The widget outline will change accordingly.
		/// </summary>
		// Token: 0x060091F0 RID: 37360 RVA: 0x000CF55C File Offset: 0x000CD75C
		public virtual int GetConstrainToWidgetBounds()
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetConstrainToWidgetBounds_28(base.GetCppThis());
		}

		// Token: 0x060091F1 RID: 37361
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_GetCylinder_29(HandleRef pThis, HandleRef cyl);

		/// <summary>
		/// Get the implicit function for the cylinder. The user must provide the
		/// instance of the class vtkCylinder. Note that vtkCylinder is a subclass of
		/// vtkImplicitFunction, meaning that it can be used by a variety of filters
		/// to perform clipping, cutting, and selection of data.
		/// </summary>
		// Token: 0x060091F2 RID: 37362 RVA: 0x000CF57C File Offset: 0x000CD77C
		public void GetCylinder(vtkCylinder cyl)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetCylinder_29(base.GetCppThis(), (cyl == null) ? default(HandleRef) : cyl.GetCppThis());
		}

		// Token: 0x060091F3 RID: 37363
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitCylinderRepresentation_GetCylinderProperty_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the cylinder properties. The properties of the cylinder when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x060091F4 RID: 37364 RVA: 0x000CF5AC File Offset: 0x000CD7AC
		public virtual vtkProperty GetCylinderProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetCylinderProperty_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060091F5 RID: 37365
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitCylinderRepresentation_GetDrawCylinder_31(HandleRef pThis);

		/// <summary>
		/// Enable/disable the drawing of the cylinder. In some cases the cylinder
		/// interferes with the object that it is operating on (e.g., the
		/// cylinder interferes with the cut surface it produces resulting in
		/// z-buffer artifacts.) By default it is off.
		/// </summary>
		// Token: 0x060091F6 RID: 37366 RVA: 0x000CF61C File Offset: 0x000CD81C
		public virtual int GetDrawCylinder()
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetDrawCylinder_31(base.GetCppThis());
		}

		// Token: 0x060091F7 RID: 37367
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitCylinderRepresentation_GetEdgesProperty_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the property of the intersection edges. (This property also
		/// applies to the edges when tubed.)
		/// </summary>
		// Token: 0x060091F8 RID: 37368 RVA: 0x000CF63C File Offset: 0x000CD83C
		public virtual vtkProperty GetEdgesProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetEdgesProperty_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060091F9 RID: 37369
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitCylinderRepresentation_GetInteractionStateMaxValue_33(HandleRef pThis);

		/// <summary>
		/// The interaction state may be set from a widget (e.g.,
		/// vtkImplicitCylinderWidget) or other object. This controls how the
		/// interaction with the widget proceeds. Normally this method is used as
		/// part of a handshaking process with the widget: First
		/// ComputeInteractionState() is invoked that returns a state based on
		/// geometric considerations (i.e., cursor near a widget feature), then
		/// based on events, the widget may modify this further.
		/// </summary>
		// Token: 0x060091FA RID: 37370 RVA: 0x000CF6AC File Offset: 0x000CD8AC
		public virtual int GetInteractionStateMaxValue()
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetInteractionStateMaxValue_33(base.GetCppThis());
		}

		// Token: 0x060091FB RID: 37371
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitCylinderRepresentation_GetInteractionStateMinValue_34(HandleRef pThis);

		/// <summary>
		/// The interaction state may be set from a widget (e.g.,
		/// vtkImplicitCylinderWidget) or other object. This controls how the
		/// interaction with the widget proceeds. Normally this method is used as
		/// part of a handshaking process with the widget: First
		/// ComputeInteractionState() is invoked that returns a state based on
		/// geometric considerations (i.e., cursor near a widget feature), then
		/// based on events, the widget may modify this further.
		/// </summary>
		// Token: 0x060091FC RID: 37372 RVA: 0x000CF6CC File Offset: 0x000CD8CC
		public virtual int GetInteractionStateMinValue()
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetInteractionStateMinValue_34(base.GetCppThis());
		}

		// Token: 0x060091FD RID: 37373
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitCylinderRepresentation_GetMaxRadius_35(HandleRef pThis);

		/// <summary>
		/// Set/Get the minimum and maximum radius of the cylinder. This
		/// helps prevent the cylinder from "disappearing" during
		/// interaction.  Note that the minimum and maximum radius is
		/// specified as a fraction of the diagonal length of the widget
		/// bounding box.
		/// </summary>
		// Token: 0x060091FE RID: 37374 RVA: 0x000CF6EC File Offset: 0x000CD8EC
		public virtual double GetMaxRadius()
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetMaxRadius_35(base.GetCppThis());
		}

		// Token: 0x060091FF RID: 37375
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitCylinderRepresentation_GetMaxRadiusMaxValue_36(HandleRef pThis);

		/// <summary>
		/// Set/Get the minimum and maximum radius of the cylinder. This
		/// helps prevent the cylinder from "disappearing" during
		/// interaction.  Note that the minimum and maximum radius is
		/// specified as a fraction of the diagonal length of the widget
		/// bounding box.
		/// </summary>
		// Token: 0x06009200 RID: 37376 RVA: 0x000CF70C File Offset: 0x000CD90C
		public virtual double GetMaxRadiusMaxValue()
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetMaxRadiusMaxValue_36(base.GetCppThis());
		}

		// Token: 0x06009201 RID: 37377
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitCylinderRepresentation_GetMaxRadiusMinValue_37(HandleRef pThis);

		/// <summary>
		/// Set/Get the minimum and maximum radius of the cylinder. This
		/// helps prevent the cylinder from "disappearing" during
		/// interaction.  Note that the minimum and maximum radius is
		/// specified as a fraction of the diagonal length of the widget
		/// bounding box.
		/// </summary>
		// Token: 0x06009202 RID: 37378 RVA: 0x000CF72C File Offset: 0x000CD92C
		public virtual double GetMaxRadiusMinValue()
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetMaxRadiusMinValue_37(base.GetCppThis());
		}

		// Token: 0x06009203 RID: 37379
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitCylinderRepresentation_GetMinRadius_38(HandleRef pThis);

		/// <summary>
		/// Set/Get the minimum and maximum radius of the cylinder. This
		/// helps prevent the cylinder from "disappearing" during
		/// interaction.  Note that the minimum and maximum radius is
		/// specified as a fraction of the diagonal length of the widget
		/// bounding box.
		/// </summary>
		// Token: 0x06009204 RID: 37380 RVA: 0x000CF74C File Offset: 0x000CD94C
		public virtual double GetMinRadius()
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetMinRadius_38(base.GetCppThis());
		}

		// Token: 0x06009205 RID: 37381
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitCylinderRepresentation_GetMinRadiusMaxValue_39(HandleRef pThis);

		/// <summary>
		/// Set/Get the minimum and maximum radius of the cylinder. This
		/// helps prevent the cylinder from "disappearing" during
		/// interaction.  Note that the minimum and maximum radius is
		/// specified as a fraction of the diagonal length of the widget
		/// bounding box.
		/// </summary>
		// Token: 0x06009206 RID: 37382 RVA: 0x000CF76C File Offset: 0x000CD96C
		public virtual double GetMinRadiusMaxValue()
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetMinRadiusMaxValue_39(base.GetCppThis());
		}

		// Token: 0x06009207 RID: 37383
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitCylinderRepresentation_GetMinRadiusMinValue_40(HandleRef pThis);

		/// <summary>
		/// Set/Get the minimum and maximum radius of the cylinder. This
		/// helps prevent the cylinder from "disappearing" during
		/// interaction.  Note that the minimum and maximum radius is
		/// specified as a fraction of the diagonal length of the widget
		/// bounding box.
		/// </summary>
		// Token: 0x06009208 RID: 37384 RVA: 0x000CF78C File Offset: 0x000CD98C
		public virtual double GetMinRadiusMinValue()
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetMinRadiusMinValue_40(base.GetCppThis());
		}

		// Token: 0x06009209 RID: 37385
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitCylinderRepresentation_GetNumberOfGenerationsFromBase_41(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600920A RID: 37386 RVA: 0x000CF7AC File Offset: 0x000CD9AC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetNumberOfGenerationsFromBase_41(base.GetCppThis(), type);
		}

		// Token: 0x0600920B RID: 37387
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitCylinderRepresentation_GetNumberOfGenerationsFromBaseType_42([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600920C RID: 37388 RVA: 0x000CF7CC File Offset: 0x000CD9CC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetNumberOfGenerationsFromBaseType_42(type);
		}

		// Token: 0x0600920D RID: 37389
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitCylinderRepresentation_GetOutlineProperty_43(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the property of the outline.
		/// </summary>
		// Token: 0x0600920E RID: 37390 RVA: 0x000CF7E8 File Offset: 0x000CD9E8
		public virtual vtkProperty GetOutlineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetOutlineProperty_43(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600920F RID: 37391
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitCylinderRepresentation_GetOutlineTranslation_44(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to translate the bounding box by moving it
		/// with the mouse.
		/// </summary>
		// Token: 0x06009210 RID: 37392 RVA: 0x000CF858 File Offset: 0x000CDA58
		public virtual int GetOutlineTranslation()
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetOutlineTranslation_44(base.GetCppThis());
		}

		// Token: 0x06009211 RID: 37393
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitCylinderRepresentation_GetOutsideBounds_45(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to move the widget outside of the bounds
		/// specified in the PlaceWidget() invocation.
		/// </summary>
		// Token: 0x06009212 RID: 37394 RVA: 0x000CF878 File Offset: 0x000CDA78
		public virtual int GetOutsideBounds()
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetOutsideBounds_45(base.GetCppThis());
		}

		// Token: 0x06009213 RID: 37395
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_GetPolyData_46(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Grab the polydata that defines the cylinder. The polydata contains
		/// polygons that are clipped by the bounding box.
		/// </summary>
		// Token: 0x06009214 RID: 37396 RVA: 0x000CF898 File Offset: 0x000CDA98
		public void GetPolyData(vtkPolyData pd)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetPolyData_46(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x06009215 RID: 37397
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitCylinderRepresentation_GetRadius_47(HandleRef pThis);

		/// <summary>
		/// Set/Get the radius of the cylinder. Note that if the radius is
		/// too big the cylinder will be outside of the bounding box.
		/// </summary>
		// Token: 0x06009216 RID: 37398 RVA: 0x000CF8C8 File Offset: 0x000CDAC8
		public double GetRadius()
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetRadius_47(base.GetCppThis());
		}

		// Token: 0x06009217 RID: 37399
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitCylinderRepresentation_GetRepresentationState_48(HandleRef pThis);

		/// <summary>
		/// Sets the visual appearance of the representation based on the
		/// state it is in. This state is usually the same as InteractionState.
		/// </summary>
		// Token: 0x06009218 RID: 37400 RVA: 0x000CF8E8 File Offset: 0x000CDAE8
		public virtual int GetRepresentationState()
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetRepresentationState_48(base.GetCppThis());
		}

		// Token: 0x06009219 RID: 37401
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitCylinderRepresentation_GetResolution_49(HandleRef pThis);

		/// <summary>
		/// Set/Get the resolution of the cylinder. This is the number of
		/// polygonal facets used to approximate the curved cylindrical
		/// surface (for rendering purposes). An vtkCylinder is used under
		/// the hood to provide an exact surface representation.
		/// </summary>
		// Token: 0x0600921A RID: 37402 RVA: 0x000CF908 File Offset: 0x000CDB08
		public virtual int GetResolution()
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetResolution_49(base.GetCppThis());
		}

		// Token: 0x0600921B RID: 37403
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitCylinderRepresentation_GetResolutionMaxValue_50(HandleRef pThis);

		/// <summary>
		/// Set/Get the resolution of the cylinder. This is the number of
		/// polygonal facets used to approximate the curved cylindrical
		/// surface (for rendering purposes). An vtkCylinder is used under
		/// the hood to provide an exact surface representation.
		/// </summary>
		// Token: 0x0600921C RID: 37404 RVA: 0x000CF928 File Offset: 0x000CDB28
		public virtual int GetResolutionMaxValue()
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetResolutionMaxValue_50(base.GetCppThis());
		}

		// Token: 0x0600921D RID: 37405
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitCylinderRepresentation_GetResolutionMinValue_51(HandleRef pThis);

		/// <summary>
		/// Set/Get the resolution of the cylinder. This is the number of
		/// polygonal facets used to approximate the curved cylindrical
		/// surface (for rendering purposes). An vtkCylinder is used under
		/// the hood to provide an exact surface representation.
		/// </summary>
		// Token: 0x0600921E RID: 37406 RVA: 0x000CF948 File Offset: 0x000CDB48
		public virtual int GetResolutionMinValue()
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetResolutionMinValue_51(base.GetCppThis());
		}

		// Token: 0x0600921F RID: 37407
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitCylinderRepresentation_GetScaleEnabled_52(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to scale the widget with the mouse.
		/// </summary>
		// Token: 0x06009220 RID: 37408 RVA: 0x000CF968 File Offset: 0x000CDB68
		public virtual int GetScaleEnabled()
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetScaleEnabled_52(base.GetCppThis());
		}

		// Token: 0x06009221 RID: 37409
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitCylinderRepresentation_GetSelectedAxisProperty_53(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties on the axis (line and cone).
		/// </summary>
		// Token: 0x06009222 RID: 37410 RVA: 0x000CF988 File Offset: 0x000CDB88
		public virtual vtkProperty GetSelectedAxisProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetSelectedAxisProperty_53(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009223 RID: 37411
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitCylinderRepresentation_GetSelectedCylinderProperty_54(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the cylinder properties. The properties of the cylinder when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06009224 RID: 37412 RVA: 0x000CF9F8 File Offset: 0x000CDBF8
		public virtual vtkProperty GetSelectedCylinderProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetSelectedCylinderProperty_54(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009225 RID: 37413
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitCylinderRepresentation_GetSelectedOutlineProperty_55(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the property of the outline.
		/// </summary>
		// Token: 0x06009226 RID: 37414 RVA: 0x000CFA68 File Offset: 0x000CDC68
		public virtual vtkProperty GetSelectedOutlineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetSelectedOutlineProperty_55(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009227 RID: 37415
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitCylinderRepresentation_GetTranslationAxis_56(HandleRef pThis);

		/// <summary>
		/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
		/// if none.
		/// </summary>
		// Token: 0x06009228 RID: 37416 RVA: 0x000CFAD8 File Offset: 0x000CDCD8
		public virtual int GetTranslationAxis()
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetTranslationAxis_56(base.GetCppThis());
		}

		// Token: 0x06009229 RID: 37417
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitCylinderRepresentation_GetTranslationAxisMaxValue_57(HandleRef pThis);

		/// <summary>
		/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
		/// if none.
		/// </summary>
		// Token: 0x0600922A RID: 37418 RVA: 0x000CFAF8 File Offset: 0x000CDCF8
		public virtual int GetTranslationAxisMaxValue()
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetTranslationAxisMaxValue_57(base.GetCppThis());
		}

		// Token: 0x0600922B RID: 37419
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitCylinderRepresentation_GetTranslationAxisMinValue_58(HandleRef pThis);

		/// <summary>
		/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
		/// if none.
		/// </summary>
		// Token: 0x0600922C RID: 37420 RVA: 0x000CFB18 File Offset: 0x000CDD18
		public virtual int GetTranslationAxisMinValue()
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetTranslationAxisMinValue_58(base.GetCppThis());
		}

		// Token: 0x0600922D RID: 37421
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitCylinderRepresentation_GetTubing_59(HandleRef pThis);

		/// <summary>
		/// Turn on/off tubing of the wire outline of the cylinder
		/// intersection (against the bounding box). The tube thickens the
		/// line by wrapping with a vtkTubeFilter.
		/// </summary>
		// Token: 0x0600922E RID: 37422 RVA: 0x000CFB38 File Offset: 0x000CDD38
		public virtual int GetTubing()
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetTubing_59(base.GetCppThis());
		}

		// Token: 0x0600922F RID: 37423
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitCylinderRepresentation_GetWidgetBounds_60(HandleRef pThis);

		/// <summary>
		/// Set/Get the bounds of the widget representation. PlaceWidget can also be
		/// used to set the bounds of the widget but it may also have other effects
		/// on the internal state of the representation. Use this function when only
		/// the widget bounds are needs to be modified.
		/// </summary>
		// Token: 0x06009230 RID: 37424 RVA: 0x000CFB58 File Offset: 0x000CDD58
		public virtual double[] GetWidgetBounds()
		{
			IntPtr intPtr = vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetWidgetBounds_60(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009231 RID: 37425
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_GetWidgetBounds_61(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

		/// <summary>
		/// Set/Get the bounds of the widget representation. PlaceWidget can also be
		/// used to set the bounds of the widget but it may also have other effects
		/// on the internal state of the representation. Use this function when only
		/// the widget bounds are needs to be modified.
		/// </summary>
		// Token: 0x06009232 RID: 37426 RVA: 0x000CFBA0 File Offset: 0x000CDDA0
		public virtual void GetWidgetBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetWidgetBounds_61(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x06009233 RID: 37427
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_GetWidgetBounds_62(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the bounds of the widget representation. PlaceWidget can also be
		/// used to set the bounds of the widget but it may also have other effects
		/// on the internal state of the representation. Use this function when only
		/// the widget bounds are needs to be modified.
		/// </summary>
		// Token: 0x06009234 RID: 37428 RVA: 0x000CFBB8 File Offset: 0x000CDDB8
		public virtual void GetWidgetBounds(IntPtr _arg)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_GetWidgetBounds_62(base.GetCppThis(), _arg);
		}

		// Token: 0x06009235 RID: 37429
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitCylinderRepresentation_HasTranslucentPolygonalGeometry_63(HandleRef pThis);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x06009236 RID: 37430 RVA: 0x000CFBC8 File Offset: 0x000CDDC8
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_HasTranslucentPolygonalGeometry_63(base.GetCppThis());
		}

		// Token: 0x06009237 RID: 37431
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitCylinderRepresentation_IsA_64(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06009238 RID: 37432 RVA: 0x000CFBE8 File Offset: 0x000CDDE8
		public override int IsA(string type)
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_IsA_64(base.GetCppThis(), type);
		}

		// Token: 0x06009239 RID: 37433
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImplicitCylinderRepresentation_IsTranslationConstrained_65(HandleRef pThis);

		/// <summary>
		/// Returns true if ConstrainedAxis
		/// </summary>
		// Token: 0x0600923A RID: 37434 RVA: 0x000CFC08 File Offset: 0x000CDE08
		public bool IsTranslationConstrained()
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_IsTranslationConstrained_65(base.GetCppThis()) != 0;
		}

		// Token: 0x0600923B RID: 37435
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitCylinderRepresentation_IsTypeOf_66([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600923C RID: 37436 RVA: 0x000CFC30 File Offset: 0x000CDE30
		public new static int IsTypeOf(string type)
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_IsTypeOf_66(type);
		}

		// Token: 0x0600923D RID: 37437
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitCylinderRepresentation_NewInstance_68(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600923E RID: 37438 RVA: 0x000CFC4C File Offset: 0x000CDE4C
		public new vtkImplicitCylinderRepresentation NewInstance()
		{
			vtkImplicitCylinderRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_NewInstance_68(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitCylinderRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600923F RID: 37439
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_OutlineTranslationOff_69(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to translate the bounding box by moving it
		/// with the mouse.
		/// </summary>
		// Token: 0x06009240 RID: 37440 RVA: 0x000CFCA6 File Offset: 0x000CDEA6
		public virtual void OutlineTranslationOff()
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_OutlineTranslationOff_69(base.GetCppThis());
		}

		// Token: 0x06009241 RID: 37441
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_OutlineTranslationOn_70(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to translate the bounding box by moving it
		/// with the mouse.
		/// </summary>
		// Token: 0x06009242 RID: 37442 RVA: 0x000CFCB5 File Offset: 0x000CDEB5
		public virtual void OutlineTranslationOn()
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_OutlineTranslationOn_70(base.GetCppThis());
		}

		// Token: 0x06009243 RID: 37443
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_OutsideBoundsOff_71(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to move the widget outside of the bounds
		/// specified in the PlaceWidget() invocation.
		/// </summary>
		// Token: 0x06009244 RID: 37444 RVA: 0x000CFCC4 File Offset: 0x000CDEC4
		public virtual void OutsideBoundsOff()
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_OutsideBoundsOff_71(base.GetCppThis());
		}

		// Token: 0x06009245 RID: 37445
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_OutsideBoundsOn_72(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to move the widget outside of the bounds
		/// specified in the PlaceWidget() invocation.
		/// </summary>
		// Token: 0x06009246 RID: 37446 RVA: 0x000CFCD3 File Offset: 0x000CDED3
		public virtual void OutsideBoundsOn()
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_OutsideBoundsOn_72(base.GetCppThis());
		}

		// Token: 0x06009247 RID: 37447
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_PlaceWidget_73(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Methods to interface with the vtkImplicitCylinderWidget.
		/// </summary>
		// Token: 0x06009248 RID: 37448 RVA: 0x000CFCE2 File Offset: 0x000CDEE2
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_PlaceWidget_73(base.GetCppThis(), bounds);
		}

		// Token: 0x06009249 RID: 37449
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_PushCylinder_74(HandleRef pThis, double distance);

		/// <summary>
		/// Push the cylinder the distance specified along the view
		/// vector. Positive values are in the direction of the view vector;
		/// negative values are in the opposite direction. The distance value
		/// is expressed in world coordinates.
		/// </summary>
		// Token: 0x0600924A RID: 37450 RVA: 0x000CFCF2 File Offset: 0x000CDEF2
		public void PushCylinder(double distance)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_PushCylinder_74(base.GetCppThis(), distance);
		}

		// Token: 0x0600924B RID: 37451
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_RegisterPickers_75(HandleRef pThis);

		/// <summary>
		/// Sets the visual appearance of the representation based on the
		/// state it is in. This state is usually the same as InteractionState.
		/// </summary>
		// Token: 0x0600924C RID: 37452 RVA: 0x000CFD02 File Offset: 0x000CDF02
		public override void RegisterPickers()
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_RegisterPickers_75(base.GetCppThis());
		}

		// Token: 0x0600924D RID: 37453
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_ReleaseGraphicsResources_76(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x0600924E RID: 37454 RVA: 0x000CFD14 File Offset: 0x000CDF14
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_ReleaseGraphicsResources_76(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600924F RID: 37455
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitCylinderRepresentation_RenderOpaqueGeometry_77(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x06009250 RID: 37456 RVA: 0x000CFD44 File Offset: 0x000CDF44
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_RenderOpaqueGeometry_77(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009251 RID: 37457
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitCylinderRepresentation_RenderTranslucentPolygonalGeometry_78(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x06009252 RID: 37458 RVA: 0x000CFD78 File Offset: 0x000CDF78
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_RenderTranslucentPolygonalGeometry_78(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009253 RID: 37459
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitCylinderRepresentation_SafeDownCast_79(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06009254 RID: 37460 RVA: 0x000CFDAC File Offset: 0x000CDFAC
		public new static vtkImplicitCylinderRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitCylinderRepresentation vtkImplicitCylinderRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SafeDownCast_79((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitCylinderRepresentation = (vtkImplicitCylinderRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitCylinderRepresentation.Register(null);
				}
			}
			return vtkImplicitCylinderRepresentation;
		}

		// Token: 0x06009255 RID: 37461
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_ScaleEnabledOff_80(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to scale the widget with the mouse.
		/// </summary>
		// Token: 0x06009256 RID: 37462 RVA: 0x000CFE2B File Offset: 0x000CE02B
		public virtual void ScaleEnabledOff()
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_ScaleEnabledOff_80(base.GetCppThis());
		}

		// Token: 0x06009257 RID: 37463
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_ScaleEnabledOn_81(HandleRef pThis);

		/// <summary>
		/// Turn on/off the ability to scale the widget with the mouse.
		/// </summary>
		// Token: 0x06009258 RID: 37464 RVA: 0x000CFE3A File Offset: 0x000CE03A
		public virtual void ScaleEnabledOn()
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_ScaleEnabledOn_81(base.GetCppThis());
		}

		// Token: 0x06009259 RID: 37465
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetAlongXAxis_82(HandleRef pThis, int arg0);

		/// <summary>
		/// Force the cylinder widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the cylinder to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x0600925A RID: 37466 RVA: 0x000CFE49 File Offset: 0x000CE049
		public void SetAlongXAxis(int arg0)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetAlongXAxis_82(base.GetCppThis(), arg0);
		}

		// Token: 0x0600925B RID: 37467
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetAlongYAxis_83(HandleRef pThis, int arg0);

		/// <summary>
		/// Force the cylinder widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the cylinder to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x0600925C RID: 37468 RVA: 0x000CFE59 File Offset: 0x000CE059
		public void SetAlongYAxis(int arg0)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetAlongYAxis_83(base.GetCppThis(), arg0);
		}

		// Token: 0x0600925D RID: 37469
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetAlongZAxis_84(HandleRef pThis, int arg0);

		/// <summary>
		/// Force the cylinder widget to be aligned with one of the x-y-z axes.
		/// If one axis is set on, the other two will be set off.
		/// Remember that when the state changes, a ModifiedEvent is invoked.
		/// This can be used to snap the cylinder to the axes if it is originally
		/// not aligned.
		/// </summary>
		// Token: 0x0600925E RID: 37470 RVA: 0x000CFE69 File Offset: 0x000CE069
		public void SetAlongZAxis(int arg0)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetAlongZAxis_84(base.GetCppThis(), arg0);
		}

		// Token: 0x0600925F RID: 37471
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetAxis_85(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set/Get the axis of rotation for the cylinder. If the axis is not
		/// specified as a unit vector, it will be normalized.
		/// </summary>
		// Token: 0x06009260 RID: 37472 RVA: 0x000CFE79 File Offset: 0x000CE079
		public void SetAxis(double x, double y, double z)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetAxis_85(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06009261 RID: 37473
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetAxis_86(HandleRef pThis, IntPtr a);

		/// <summary>
		/// Set/Get the axis of rotation for the cylinder. If the axis is not
		/// specified as a unit vector, it will be normalized.
		/// </summary>
		// Token: 0x06009262 RID: 37474 RVA: 0x000CFE8B File Offset: 0x000CE08B
		public void SetAxis(IntPtr a)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetAxis_86(base.GetCppThis(), a);
		}

		// Token: 0x06009263 RID: 37475
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetBumpDistance_87(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify a translation distance used by the BumpCylinder() method. Note that the
		/// distance is normalized; it is the fraction of the length of the bounding
		/// box of the wire outline.
		/// </summary>
		// Token: 0x06009264 RID: 37476 RVA: 0x000CFE9B File Offset: 0x000CE09B
		public virtual void SetBumpDistance(double _arg)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetBumpDistance_87(base.GetCppThis(), _arg);
		}

		// Token: 0x06009265 RID: 37477
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetCenter_88(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Get the center of the cylinder. The center is located along the
		/// cylinder axis.
		/// </summary>
		// Token: 0x06009266 RID: 37478 RVA: 0x000CFEAB File Offset: 0x000CE0AB
		public void SetCenter(double x, double y, double z)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetCenter_88(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06009267 RID: 37479
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetCenter_89(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Get the center of the cylinder. The center is located along the
		/// cylinder axis.
		/// </summary>
		// Token: 0x06009268 RID: 37480 RVA: 0x000CFEBD File Offset: 0x000CE0BD
		public void SetCenter(IntPtr x)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetCenter_89(base.GetCppThis(), x);
		}

		// Token: 0x06009269 RID: 37481
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetConstrainToWidgetBounds_90(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off whether the cylinder should be constrained to the widget bounds.
		/// If on, the center will not be allowed to move outside the set widget bounds
		/// and the radius will be limited by MinRadius and MaxRadius. This is the
		/// default behaviour.
		/// If off, the center can be freely moved and the radius can be set to
		/// arbitrary values. The widget outline will change accordingly.
		/// </summary>
		// Token: 0x0600926A RID: 37482 RVA: 0x000CFECD File Offset: 0x000CE0CD
		public virtual void SetConstrainToWidgetBounds(int _arg)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetConstrainToWidgetBounds_90(base.GetCppThis(), _arg);
		}

		// Token: 0x0600926B RID: 37483
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetDrawCylinder_91(HandleRef pThis, int drawCyl);

		/// <summary>
		/// Enable/disable the drawing of the cylinder. In some cases the cylinder
		/// interferes with the object that it is operating on (e.g., the
		/// cylinder interferes with the cut surface it produces resulting in
		/// z-buffer artifacts.) By default it is off.
		/// </summary>
		// Token: 0x0600926C RID: 37484 RVA: 0x000CFEDD File Offset: 0x000CE0DD
		public void SetDrawCylinder(int drawCyl)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetDrawCylinder_91(base.GetCppThis(), drawCyl);
		}

		// Token: 0x0600926D RID: 37485
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetForegroundColor_92(HandleRef pThis, IntPtr c);

		/// <summary>
		/// Set the color of all the widgets handles (edges, axis, selected cylinder)
		/// and their color during interaction. Foreground color applies to the outlines and unselected
		/// cylinder.
		/// </summary>
		// Token: 0x0600926E RID: 37486 RVA: 0x000CFEED File Offset: 0x000CE0ED
		public void SetForegroundColor(IntPtr c)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetForegroundColor_92(base.GetCppThis(), c);
		}

		// Token: 0x0600926F RID: 37487
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetForegroundColor_93(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Set the color of all the widgets handles (edges, axis, selected cylinder)
		/// and their color during interaction. Foreground color applies to the outlines and unselected
		/// cylinder.
		/// </summary>
		// Token: 0x06009270 RID: 37488 RVA: 0x000CFEFD File Offset: 0x000CE0FD
		public void SetForegroundColor(double arg0, double arg1, double arg2)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetForegroundColor_93(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x06009271 RID: 37489
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetHandleColor_94(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Set the color of all the widgets handles (edges, axis, selected cylinder)
		/// and their color during interaction. Foreground color applies to the outlines and unselected
		/// cylinder.
		/// </summary>
		// Token: 0x06009272 RID: 37490 RVA: 0x000CFF0F File Offset: 0x000CE10F
		public void SetHandleColor(double arg0, double arg1, double arg2)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetHandleColor_94(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x06009273 RID: 37491
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetHandleColor_95(HandleRef pThis, IntPtr c);

		/// <summary>
		/// Set the color of all the widgets handles (edges, axis, selected cylinder)
		/// and their color during interaction. Foreground color applies to the outlines and unselected
		/// cylinder.
		/// </summary>
		// Token: 0x06009274 RID: 37492 RVA: 0x000CFF21 File Offset: 0x000CE121
		public void SetHandleColor(IntPtr c)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetHandleColor_95(base.GetCppThis(), c);
		}

		// Token: 0x06009275 RID: 37493
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetInteractionColor_96(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Set the color of all the widgets handles (edges, axis, selected cylinder)
		/// and their color during interaction. Foreground color applies to the outlines and unselected
		/// cylinder.
		/// </summary>
		// Token: 0x06009276 RID: 37494 RVA: 0x000CFF31 File Offset: 0x000CE131
		public void SetInteractionColor(double arg0, double arg1, double arg2)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetInteractionColor_96(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x06009277 RID: 37495
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetInteractionColor_97(HandleRef pThis, IntPtr c);

		/// <summary>
		/// Set the color of all the widgets handles (edges, axis, selected cylinder)
		/// and their color during interaction. Foreground color applies to the outlines and unselected
		/// cylinder.
		/// </summary>
		// Token: 0x06009278 RID: 37496 RVA: 0x000CFF43 File Offset: 0x000CE143
		public void SetInteractionColor(IntPtr c)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetInteractionColor_97(base.GetCppThis(), c);
		}

		// Token: 0x06009279 RID: 37497
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetInteractionState_98(HandleRef pThis, int _arg);

		/// <summary>
		/// The interaction state may be set from a widget (e.g.,
		/// vtkImplicitCylinderWidget) or other object. This controls how the
		/// interaction with the widget proceeds. Normally this method is used as
		/// part of a handshaking process with the widget: First
		/// ComputeInteractionState() is invoked that returns a state based on
		/// geometric considerations (i.e., cursor near a widget feature), then
		/// based on events, the widget may modify this further.
		/// </summary>
		// Token: 0x0600927A RID: 37498 RVA: 0x000CFF53 File Offset: 0x000CE153
		public virtual void SetInteractionState(int _arg)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetInteractionState_98(base.GetCppThis(), _arg);
		}

		// Token: 0x0600927B RID: 37499
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetMaxRadius_99(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the minimum and maximum radius of the cylinder. This
		/// helps prevent the cylinder from "disappearing" during
		/// interaction.  Note that the minimum and maximum radius is
		/// specified as a fraction of the diagonal length of the widget
		/// bounding box.
		/// </summary>
		// Token: 0x0600927C RID: 37500 RVA: 0x000CFF63 File Offset: 0x000CE163
		public virtual void SetMaxRadius(double _arg)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetMaxRadius_99(base.GetCppThis(), _arg);
		}

		// Token: 0x0600927D RID: 37501
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetMinRadius_100(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the minimum and maximum radius of the cylinder. This
		/// helps prevent the cylinder from "disappearing" during
		/// interaction.  Note that the minimum and maximum radius is
		/// specified as a fraction of the diagonal length of the widget
		/// bounding box.
		/// </summary>
		// Token: 0x0600927E RID: 37502 RVA: 0x000CFF73 File Offset: 0x000CE173
		public virtual void SetMinRadius(double _arg)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetMinRadius_100(base.GetCppThis(), _arg);
		}

		// Token: 0x0600927F RID: 37503
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetOutlineTranslation_101(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the ability to translate the bounding box by moving it
		/// with the mouse.
		/// </summary>
		// Token: 0x06009280 RID: 37504 RVA: 0x000CFF83 File Offset: 0x000CE183
		public virtual void SetOutlineTranslation(int _arg)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetOutlineTranslation_101(base.GetCppThis(), _arg);
		}

		// Token: 0x06009281 RID: 37505
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetOutsideBounds_102(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the ability to move the widget outside of the bounds
		/// specified in the PlaceWidget() invocation.
		/// </summary>
		// Token: 0x06009282 RID: 37506 RVA: 0x000CFF93 File Offset: 0x000CE193
		public virtual void SetOutsideBounds(int _arg)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetOutsideBounds_102(base.GetCppThis(), _arg);
		}

		// Token: 0x06009283 RID: 37507
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetRadius_103(HandleRef pThis, double r);

		/// <summary>
		/// Set/Get the radius of the cylinder. Note that if the radius is
		/// too big the cylinder will be outside of the bounding box.
		/// </summary>
		// Token: 0x06009284 RID: 37508 RVA: 0x000CFFA3 File Offset: 0x000CE1A3
		public void SetRadius(double r)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetRadius_103(base.GetCppThis(), r);
		}

		// Token: 0x06009285 RID: 37509
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetRepresentationState_104(HandleRef pThis, int arg0);

		/// <summary>
		/// Sets the visual appearance of the representation based on the
		/// state it is in. This state is usually the same as InteractionState.
		/// </summary>
		// Token: 0x06009286 RID: 37510 RVA: 0x000CFFB3 File Offset: 0x000CE1B3
		public virtual void SetRepresentationState(int arg0)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetRepresentationState_104(base.GetCppThis(), arg0);
		}

		// Token: 0x06009287 RID: 37511
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetResolution_105(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the resolution of the cylinder. This is the number of
		/// polygonal facets used to approximate the curved cylindrical
		/// surface (for rendering purposes). An vtkCylinder is used under
		/// the hood to provide an exact surface representation.
		/// </summary>
		// Token: 0x06009288 RID: 37512 RVA: 0x000CFFC3 File Offset: 0x000CE1C3
		public virtual void SetResolution(int _arg)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetResolution_105(base.GetCppThis(), _arg);
		}

		// Token: 0x06009289 RID: 37513
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetScaleEnabled_106(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the ability to scale the widget with the mouse.
		/// </summary>
		// Token: 0x0600928A RID: 37514 RVA: 0x000CFFD3 File Offset: 0x000CE1D3
		public virtual void SetScaleEnabled(int _arg)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetScaleEnabled_106(base.GetCppThis(), _arg);
		}

		// Token: 0x0600928B RID: 37515
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetTranslationAxis_107(HandleRef pThis, int _arg);

		/// <summary>
		/// Gets/Sets the constraint axis for translations. Returns Axis::NONE
		/// if none.
		/// </summary>
		// Token: 0x0600928C RID: 37516 RVA: 0x000CFFE3 File Offset: 0x000CE1E3
		public virtual void SetTranslationAxis(int _arg)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetTranslationAxis_107(base.GetCppThis(), _arg);
		}

		// Token: 0x0600928D RID: 37517
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetTranslationAxisOff_108(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x0600928E RID: 37518 RVA: 0x000CFFF3 File Offset: 0x000CE1F3
		public void SetTranslationAxisOff()
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetTranslationAxisOff_108(base.GetCppThis());
		}

		// Token: 0x0600928F RID: 37519
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetTubing_109(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off tubing of the wire outline of the cylinder
		/// intersection (against the bounding box). The tube thickens the
		/// line by wrapping with a vtkTubeFilter.
		/// </summary>
		// Token: 0x06009290 RID: 37520 RVA: 0x000D0002 File Offset: 0x000CE202
		public virtual void SetTubing(int _arg)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetTubing_109(base.GetCppThis(), _arg);
		}

		// Token: 0x06009291 RID: 37521
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetWidgetBounds_110(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Set/Get the bounds of the widget representation. PlaceWidget can also be
		/// used to set the bounds of the widget but it may also have other effects
		/// on the internal state of the representation. Use this function when only
		/// the widget bounds are needs to be modified.
		/// </summary>
		// Token: 0x06009292 RID: 37522 RVA: 0x000D0012 File Offset: 0x000CE212
		public virtual void SetWidgetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetWidgetBounds_110(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x06009293 RID: 37523
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetWidgetBounds_111(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the bounds of the widget representation. PlaceWidget can also be
		/// used to set the bounds of the widget but it may also have other effects
		/// on the internal state of the representation. Use this function when only
		/// the widget bounds are needs to be modified.
		/// </summary>
		// Token: 0x06009294 RID: 37524 RVA: 0x000D002A File Offset: 0x000CE22A
		public virtual void SetWidgetBounds(IntPtr _arg)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetWidgetBounds_111(base.GetCppThis(), _arg);
		}

		// Token: 0x06009295 RID: 37525
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetXTranslationAxisOn_112(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x06009296 RID: 37526 RVA: 0x000D003A File Offset: 0x000CE23A
		public void SetXTranslationAxisOn()
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetXTranslationAxisOn_112(base.GetCppThis());
		}

		// Token: 0x06009297 RID: 37527
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetYTranslationAxisOn_113(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x06009298 RID: 37528 RVA: 0x000D0049 File Offset: 0x000CE249
		public void SetYTranslationAxisOn()
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetYTranslationAxisOn_113(base.GetCppThis());
		}

		// Token: 0x06009299 RID: 37529
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_SetZTranslationAxisOn_114(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x0600929A RID: 37530 RVA: 0x000D0058 File Offset: 0x000CE258
		public void SetZTranslationAxisOn()
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_SetZTranslationAxisOn_114(base.GetCppThis());
		}

		// Token: 0x0600929B RID: 37531
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_StartWidgetInteraction_115(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Methods to interface with the vtkImplicitCylinderWidget.
		/// </summary>
		// Token: 0x0600929C RID: 37532 RVA: 0x000D0067 File Offset: 0x000CE267
		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_StartWidgetInteraction_115(base.GetCppThis(), eventPos);
		}

		// Token: 0x0600929D RID: 37533
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_TubingOff_116(HandleRef pThis);

		/// <summary>
		/// Turn on/off tubing of the wire outline of the cylinder
		/// intersection (against the bounding box). The tube thickens the
		/// line by wrapping with a vtkTubeFilter.
		/// </summary>
		// Token: 0x0600929E RID: 37534 RVA: 0x000D0077 File Offset: 0x000CE277
		public virtual void TubingOff()
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_TubingOff_116(base.GetCppThis());
		}

		// Token: 0x0600929F RID: 37535
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_TubingOn_117(HandleRef pThis);

		/// <summary>
		/// Turn on/off tubing of the wire outline of the cylinder
		/// intersection (against the bounding box). The tube thickens the
		/// line by wrapping with a vtkTubeFilter.
		/// </summary>
		// Token: 0x060092A0 RID: 37536 RVA: 0x000D0086 File Offset: 0x000CE286
		public virtual void TubingOn()
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_TubingOn_117(base.GetCppThis());
		}

		// Token: 0x060092A1 RID: 37537
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_UpdatePlacement_118(HandleRef pThis);

		/// <summary>
		/// Satisfies the superclass API.  This will change the state of the widget
		/// to match changes that have been made to the underlying PolyDataSource.
		/// </summary>
		// Token: 0x060092A2 RID: 37538 RVA: 0x000D0095 File Offset: 0x000CE295
		public void UpdatePlacement()
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_UpdatePlacement_118(base.GetCppThis());
		}

		// Token: 0x060092A3 RID: 37539
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitCylinderRepresentation_WidgetInteraction_119(HandleRef pThis, IntPtr newEventPos);

		/// <summary>
		/// Methods to interface with the vtkImplicitCylinderWidget.
		/// </summary>
		// Token: 0x060092A4 RID: 37540 RVA: 0x000D00A4 File Offset: 0x000CE2A4
		public override void WidgetInteraction(IntPtr newEventPos)
		{
			vtkImplicitCylinderRepresentation.vtkImplicitCylinderRepresentation_WidgetInteraction_119(base.GetCppThis(), newEventPos);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C16 RID: 3094
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitCylinderRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C17 RID: 3095
		public new static readonly string MRClassNameKey = "class vtkImplicitCylinderRepresentation";

		/// <summary>
		/// Push the cylinder the distance specified along the view
		/// vector. Positive values are in the direction of the view vector;
		/// negative values are in the opposite direction. The distance value
		/// is expressed in world coordinates.
		/// </summary>
		// Token: 0x0200032B RID: 811
		public enum InteractionStateType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000C19 RID: 3097
			AdjustingRadius = 5,
			/// <summary>enum member</summary>
			// Token: 0x04000C1A RID: 3098
			Moving = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000C1B RID: 3099
			MovingCenter = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000C1C RID: 3100
			MovingOutline = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000C1D RID: 3101
			Outside = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000C1E RID: 3102
			RotatingAxis = 4,
			/// <summary>enum member</summary>
			// Token: 0x04000C1F RID: 3103
			Scaling = 6,
			/// <summary>enum member</summary>
			// Token: 0x04000C20 RID: 3104
			TranslatingCenter
		}
	}
}
