using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPointCloudRepresentation
	/// </summary>
	/// <remarks>
	///    represent the vtkPointCloudWidget
	///
	/// This class provides support for interactively querying and selecting
	/// points from a point cloud. It is a representation for the
	/// vtkPointCloudWidget.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPointCloudWidget vtkHardwareSelection vtkPointPicker
	/// </seealso>
	// Token: 0x0200034F RID: 847
	public class vtkPointCloudRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009A13 RID: 39443 RVA: 0x000DA5FB File Offset: 0x000D87FB
		static vtkPointCloudRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointCloudRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointCloudRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009A14 RID: 39444 RVA: 0x000DA623 File Offset: 0x000D8823
		public vtkPointCloudRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06009A15 RID: 39445
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointCloudRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06009A16 RID: 39446 RVA: 0x000DA634 File Offset: 0x000D8834
		public new static vtkPointCloudRepresentation New()
		{
			vtkPointCloudRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointCloudRepresentation.vtkPointCloudRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointCloudRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06009A17 RID: 39447 RVA: 0x000DA688 File Offset: 0x000D8888
		public vtkPointCloudRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPointCloudRepresentation.vtkPointCloudRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009A18 RID: 39448 RVA: 0x000DA6CC File Offset: 0x000D88CC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009A19 RID: 39449
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointCloudRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Some methods required to satisfy the vtkWidgetRepresentation API.
		/// </summary>
		// Token: 0x06009A1A RID: 39450 RVA: 0x000DA6D7 File Offset: 0x000D88D7
		public override void BuildRepresentation()
		{
			vtkPointCloudRepresentation.vtkPointCloudRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06009A1B RID: 39451
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointCloudRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// Some methods required to satisfy the vtkWidgetRepresentation API.
		/// </summary>
		// Token: 0x06009A1C RID: 39452 RVA: 0x000DA6E8 File Offset: 0x000D88E8
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkPointCloudRepresentation.vtkPointCloudRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x06009A1D RID: 39453
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointCloudRepresentation_GetActors_03(HandleRef pThis, HandleRef pc);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp (i.e., support rendering).
		/// </summary>
		// Token: 0x06009A1E RID: 39454 RVA: 0x000DA70C File Offset: 0x000D890C
		public override void GetActors(vtkPropCollection pc)
		{
			vtkPointCloudRepresentation.vtkPointCloudRepresentation_GetActors_03(base.GetCppThis(), (pc == null) ? default(HandleRef) : pc.GetCppThis());
		}

		// Token: 0x06009A1F RID: 39455
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointCloudRepresentation_GetActors2D_04(HandleRef pThis, HandleRef pc);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp (i.e., support rendering).
		/// </summary>
		// Token: 0x06009A20 RID: 39456 RVA: 0x000DA73C File Offset: 0x000D893C
		public override void GetActors2D(vtkPropCollection pc)
		{
			vtkPointCloudRepresentation.vtkPointCloudRepresentation_GetActors2D_04(base.GetCppThis(), (pc == null) ? default(HandleRef) : pc.GetCppThis());
		}

		// Token: 0x06009A21 RID: 39457
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointCloudRepresentation_GetBounds_05(HandleRef pThis);

		/// <summary>
		/// Some methods required to satisfy the vtkWidgetRepresentation API.
		/// </summary>
		// Token: 0x06009A22 RID: 39458 RVA: 0x000DA76C File Offset: 0x000D896C
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkPointCloudRepresentation.vtkPointCloudRepresentation_GetBounds_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009A23 RID: 39459
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkPointCloudRepresentation_GetHardwarePickingTolerance_06(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to a point expressed in pixels.
		/// A tolerance of 0 selects from the pixel precisely under the cursor. A
		/// tolerance of 1 results in a 3x3 pixel square under the cursor (padded
		/// out by 1 in each direction); a tolerance of N results in a (2N+1)**2
		/// selection rectangle. The point in the selection rectangle which is
		/// closest in z-buffer to the pick position is selected. Note that this can
		/// sometimes return points further away from the cursor (which can be
		/// unexpected - use the tolerance carefully).
		/// </summary>
		// Token: 0x06009A24 RID: 39460 RVA: 0x000DA7B4 File Offset: 0x000D89B4
		public virtual uint GetHardwarePickingTolerance()
		{
			return vtkPointCloudRepresentation.vtkPointCloudRepresentation_GetHardwarePickingTolerance_06(base.GetCppThis());
		}

		// Token: 0x06009A25 RID: 39461
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointCloudRepresentation_GetHighlighting_07(HandleRef pThis);

		/// <summary>
		/// Flag controls whether highlighting of points occurs as the mouse
		/// moves over them. This can cause extra rendering operations.
		/// </summary>
		// Token: 0x06009A26 RID: 39462 RVA: 0x000DA7D4 File Offset: 0x000D89D4
		public virtual bool GetHighlighting()
		{
			return vtkPointCloudRepresentation.vtkPointCloudRepresentation_GetHighlighting_07(base.GetCppThis()) != 0;
		}

		// Token: 0x06009A27 RID: 39463
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointCloudRepresentation_GetInteractionStateMaxValue_08(HandleRef pThis);

		/// <summary>
		/// The interaction state may be set from a widget (e.g., PointCloudWidget)
		/// or other object. This controls how the interaction with the widget
		/// proceeds. Normally this method is used as part of a handshaking process
		/// with the widget: First ComputeInteractionState() is invoked that returns
		/// a state based on geometric considerations (i.e., cursor near a widget
		/// feature), then based on events, the widget may modify this further.
		/// </summary>
		// Token: 0x06009A28 RID: 39464 RVA: 0x000DA7FC File Offset: 0x000D89FC
		public virtual int GetInteractionStateMaxValue()
		{
			return vtkPointCloudRepresentation.vtkPointCloudRepresentation_GetInteractionStateMaxValue_08(base.GetCppThis());
		}

		// Token: 0x06009A29 RID: 39465
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointCloudRepresentation_GetInteractionStateMinValue_09(HandleRef pThis);

		/// <summary>
		/// The interaction state may be set from a widget (e.g., PointCloudWidget)
		/// or other object. This controls how the interaction with the widget
		/// proceeds. Normally this method is used as part of a handshaking process
		/// with the widget: First ComputeInteractionState() is invoked that returns
		/// a state based on geometric considerations (i.e., cursor near a widget
		/// feature), then based on events, the widget may modify this further.
		/// </summary>
		// Token: 0x06009A2A RID: 39466 RVA: 0x000DA81C File Offset: 0x000D8A1C
		public virtual int GetInteractionStateMinValue()
		{
			return vtkPointCloudRepresentation.vtkPointCloudRepresentation_GetInteractionStateMinValue_09(base.GetCppThis());
		}

		// Token: 0x06009A2B RID: 39467
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointCloudRepresentation_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods for obtaining type information and printing.
		/// </summary>
		// Token: 0x06009A2C RID: 39468 RVA: 0x000DA83C File Offset: 0x000D8A3C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPointCloudRepresentation.vtkPointCloudRepresentation_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x06009A2D RID: 39469
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointCloudRepresentation_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods for obtaining type information and printing.
		/// </summary>
		// Token: 0x06009A2E RID: 39470 RVA: 0x000DA85C File Offset: 0x000D8A5C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPointCloudRepresentation.vtkPointCloudRepresentation_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x06009A2F RID: 39471
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointCloudRepresentation_GetPickingMode_12(HandleRef pThis);

		/// <summary>
		/// Because point clouds can be very large, alternative point picking
		/// approaches can be used to select points: either hardware picking (via
		/// rendering) or software rendering (via CPU ray cast). In summary,
		/// hardware picking (via vtkHardwareSelector) is preferred, with an
		/// optional software picker (via vtkPointPicker) available. Each approach
		/// has potential advantages and disadvantages - mainly, vtkHardwareSelector
		/// is faster but only selects opaque geometry and what is visible on the
		/// screen, does not work with anti-aliasing, cannot handle assemblies, and
		/// may not work on some systems. vtkPointPicker avoids extra renders, and
		/// can handle translucent geometry, can select points "behind" other
		/// objects, will work on all systems, but is scalable to only a few tens of
		/// thousands of points. (See vtkHardwareSelector and vtkPointPicker for
		/// further information.) The choice of picker also has implications on the
		/// type of tolerancing used (as described in the following documentation).
		/// (Note also that the pickers may return slightly different results, this
		/// is expected due to the different way tolerancing works.)
		/// </summary>
		// Token: 0x06009A30 RID: 39472 RVA: 0x000DA878 File Offset: 0x000D8A78
		public virtual int GetPickingMode()
		{
			return vtkPointCloudRepresentation.vtkPointCloudRepresentation_GetPickingMode_12(base.GetCppThis());
		}

		// Token: 0x06009A31 RID: 39473
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointCloudRepresentation_GetPickingModeMaxValue_13(HandleRef pThis);

		/// <summary>
		/// Because point clouds can be very large, alternative point picking
		/// approaches can be used to select points: either hardware picking (via
		/// rendering) or software rendering (via CPU ray cast). In summary,
		/// hardware picking (via vtkHardwareSelector) is preferred, with an
		/// optional software picker (via vtkPointPicker) available. Each approach
		/// has potential advantages and disadvantages - mainly, vtkHardwareSelector
		/// is faster but only selects opaque geometry and what is visible on the
		/// screen, does not work with anti-aliasing, cannot handle assemblies, and
		/// may not work on some systems. vtkPointPicker avoids extra renders, and
		/// can handle translucent geometry, can select points "behind" other
		/// objects, will work on all systems, but is scalable to only a few tens of
		/// thousands of points. (See vtkHardwareSelector and vtkPointPicker for
		/// further information.) The choice of picker also has implications on the
		/// type of tolerancing used (as described in the following documentation).
		/// (Note also that the pickers may return slightly different results, this
		/// is expected due to the different way tolerancing works.)
		/// </summary>
		// Token: 0x06009A32 RID: 39474 RVA: 0x000DA898 File Offset: 0x000D8A98
		public virtual int GetPickingModeMaxValue()
		{
			return vtkPointCloudRepresentation.vtkPointCloudRepresentation_GetPickingModeMaxValue_13(base.GetCppThis());
		}

		// Token: 0x06009A33 RID: 39475
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointCloudRepresentation_GetPickingModeMinValue_14(HandleRef pThis);

		/// <summary>
		/// Because point clouds can be very large, alternative point picking
		/// approaches can be used to select points: either hardware picking (via
		/// rendering) or software rendering (via CPU ray cast). In summary,
		/// hardware picking (via vtkHardwareSelector) is preferred, with an
		/// optional software picker (via vtkPointPicker) available. Each approach
		/// has potential advantages and disadvantages - mainly, vtkHardwareSelector
		/// is faster but only selects opaque geometry and what is visible on the
		/// screen, does not work with anti-aliasing, cannot handle assemblies, and
		/// may not work on some systems. vtkPointPicker avoids extra renders, and
		/// can handle translucent geometry, can select points "behind" other
		/// objects, will work on all systems, but is scalable to only a few tens of
		/// thousands of points. (See vtkHardwareSelector and vtkPointPicker for
		/// further information.) The choice of picker also has implications on the
		/// type of tolerancing used (as described in the following documentation).
		/// (Note also that the pickers may return slightly different results, this
		/// is expected due to the different way tolerancing works.)
		/// </summary>
		// Token: 0x06009A34 RID: 39476 RVA: 0x000DA8B8 File Offset: 0x000D8AB8
		public virtual int GetPickingModeMinValue()
		{
			return vtkPointCloudRepresentation.vtkPointCloudRepresentation_GetPickingModeMinValue_14(base.GetCppThis());
		}

		// Token: 0x06009A35 RID: 39477
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointCloudRepresentation_GetPointCloudActor_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve the associated actor and mapper used to render the point cloud.
		/// </summary>
		// Token: 0x06009A36 RID: 39478 RVA: 0x000DA8D8 File Offset: 0x000D8AD8
		public virtual vtkActor GetPointCloudActor()
		{
			vtkActor vtkActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointCloudRepresentation.vtkPointCloudRepresentation_GetPointCloudActor_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor = (vtkActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor.Register(null);
				}
			}
			return vtkActor;
		}

		// Token: 0x06009A37 RID: 39479
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointCloudRepresentation_GetPointCloudMapper_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve the associated actor and mapper used to render the point cloud.
		/// </summary>
		// Token: 0x06009A38 RID: 39480 RVA: 0x000DA948 File Offset: 0x000D8B48
		public virtual vtkPolyDataMapper GetPointCloudMapper()
		{
			vtkPolyDataMapper vtkPolyDataMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointCloudRepresentation.vtkPointCloudRepresentation_GetPointCloudMapper_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataMapper = (vtkPolyDataMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataMapper.Register(null);
				}
			}
			return vtkPolyDataMapper;
		}

		// Token: 0x06009A39 RID: 39481
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointCloudRepresentation_GetPointCoordinates_17(HandleRef pThis);

		/// <summary>
		/// Retrieve the point coordinates of the selected point. Note that if the
		/// point id is invalid (&lt;0) then the coordinates are undefined.
		/// </summary>
		// Token: 0x06009A3A RID: 39482 RVA: 0x000DA9B8 File Offset: 0x000D8BB8
		public IntPtr GetPointCoordinates()
		{
			return vtkPointCloudRepresentation.vtkPointCloudRepresentation_GetPointCoordinates_17(base.GetCppThis());
		}

		// Token: 0x06009A3B RID: 39483
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointCloudRepresentation_GetPointCoordinates_18(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Retrieve the point coordinates of the selected point. Note that if the
		/// point id is invalid (&lt;0) then the coordinates are undefined.
		/// </summary>
		// Token: 0x06009A3C RID: 39484 RVA: 0x000DA9D7 File Offset: 0x000D8BD7
		public void GetPointCoordinates(IntPtr x)
		{
			vtkPointCloudRepresentation.vtkPointCloudRepresentation_GetPointCoordinates_18(base.GetCppThis(), x);
		}

		// Token: 0x06009A3D RID: 39485
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointCloudRepresentation_GetPointId_19(HandleRef pThis);

		/// <summary>
		/// Retrieve the point id from the selected point. Note that this can
		/// be invalid (&lt;0) if nothing was picked.
		/// </summary>
		// Token: 0x06009A3E RID: 39486 RVA: 0x000DA9E8 File Offset: 0x000D8BE8
		public long GetPointId()
		{
			return vtkPointCloudRepresentation.vtkPointCloudRepresentation_GetPointId_19(base.GetCppThis());
		}

		// Token: 0x06009A3F RID: 39487
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointCloudRepresentation_GetSoftwarePickingTolerance_20(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to a point (as a fraction of the
		/// bounding box of the point cloud). This specifies when the cursor is
		/// considered near enough to the point to highlight it. Note that this is
		/// a sensitive parameter - too small and it's hard to pick anything; too
		/// large and points close to the eye can be picked in preference to points
		/// further away which are closer to the pick ray.
		/// </summary>
		// Token: 0x06009A40 RID: 39488 RVA: 0x000DAA08 File Offset: 0x000D8C08
		public virtual double GetSoftwarePickingTolerance()
		{
			return vtkPointCloudRepresentation.vtkPointCloudRepresentation_GetSoftwarePickingTolerance_20(base.GetCppThis());
		}

		// Token: 0x06009A41 RID: 39489
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointCloudRepresentation_GetSoftwarePickingToleranceMaxValue_21(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to a point (as a fraction of the
		/// bounding box of the point cloud). This specifies when the cursor is
		/// considered near enough to the point to highlight it. Note that this is
		/// a sensitive parameter - too small and it's hard to pick anything; too
		/// large and points close to the eye can be picked in preference to points
		/// further away which are closer to the pick ray.
		/// </summary>
		// Token: 0x06009A42 RID: 39490 RVA: 0x000DAA28 File Offset: 0x000D8C28
		public virtual double GetSoftwarePickingToleranceMaxValue()
		{
			return vtkPointCloudRepresentation.vtkPointCloudRepresentation_GetSoftwarePickingToleranceMaxValue_21(base.GetCppThis());
		}

		// Token: 0x06009A43 RID: 39491
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointCloudRepresentation_GetSoftwarePickingToleranceMinValue_22(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to a point (as a fraction of the
		/// bounding box of the point cloud). This specifies when the cursor is
		/// considered near enough to the point to highlight it. Note that this is
		/// a sensitive parameter - too small and it's hard to pick anything; too
		/// large and points close to the eye can be picked in preference to points
		/// further away which are closer to the pick ray.
		/// </summary>
		// Token: 0x06009A44 RID: 39492 RVA: 0x000DAA48 File Offset: 0x000D8C48
		public virtual double GetSoftwarePickingToleranceMinValue()
		{
			return vtkPointCloudRepresentation.vtkPointCloudRepresentation_GetSoftwarePickingToleranceMinValue_22(base.GetCppThis());
		}

		// Token: 0x06009A45 RID: 39493
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointCloudRepresentation_HasTranslucentPolygonalGeometry_23(HandleRef pThis);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp (i.e., support rendering).
		/// </summary>
		// Token: 0x06009A46 RID: 39494 RVA: 0x000DAA68 File Offset: 0x000D8C68
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkPointCloudRepresentation.vtkPointCloudRepresentation_HasTranslucentPolygonalGeometry_23(base.GetCppThis());
		}

		// Token: 0x06009A47 RID: 39495
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointCloudRepresentation_HighlightingOff_24(HandleRef pThis);

		/// <summary>
		/// Flag controls whether highlighting of points occurs as the mouse
		/// moves over them. This can cause extra rendering operations.
		/// </summary>
		// Token: 0x06009A48 RID: 39496 RVA: 0x000DAA87 File Offset: 0x000D8C87
		public virtual void HighlightingOff()
		{
			vtkPointCloudRepresentation.vtkPointCloudRepresentation_HighlightingOff_24(base.GetCppThis());
		}

		// Token: 0x06009A49 RID: 39497
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointCloudRepresentation_HighlightingOn_25(HandleRef pThis);

		/// <summary>
		/// Flag controls whether highlighting of points occurs as the mouse
		/// moves over them. This can cause extra rendering operations.
		/// </summary>
		// Token: 0x06009A4A RID: 39498 RVA: 0x000DAA96 File Offset: 0x000D8C96
		public virtual void HighlightingOn()
		{
			vtkPointCloudRepresentation.vtkPointCloudRepresentation_HighlightingOn_25(base.GetCppThis());
		}

		// Token: 0x06009A4B RID: 39499
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointCloudRepresentation_IsA_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods for obtaining type information and printing.
		/// </summary>
		// Token: 0x06009A4C RID: 39500 RVA: 0x000DAAA8 File Offset: 0x000D8CA8
		public override int IsA(string type)
		{
			return vtkPointCloudRepresentation.vtkPointCloudRepresentation_IsA_26(base.GetCppThis(), type);
		}

		// Token: 0x06009A4D RID: 39501
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointCloudRepresentation_IsTypeOf_27([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods for obtaining type information and printing.
		/// </summary>
		// Token: 0x06009A4E RID: 39502 RVA: 0x000DAAC8 File Offset: 0x000D8CC8
		public new static int IsTypeOf(string type)
		{
			return vtkPointCloudRepresentation.vtkPointCloudRepresentation_IsTypeOf_27(type);
		}

		// Token: 0x06009A4F RID: 39503
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointCloudRepresentation_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK class methods for obtaining type information and printing.
		/// </summary>
		// Token: 0x06009A50 RID: 39504 RVA: 0x000DAAE4 File Offset: 0x000D8CE4
		public new vtkPointCloudRepresentation NewInstance()
		{
			vtkPointCloudRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointCloudRepresentation.vtkPointCloudRepresentation_NewInstance_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointCloudRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009A51 RID: 39505
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointCloudRepresentation_PlacePointCloud_30(HandleRef pThis, HandleRef a);

		/// <summary>
		/// Specify and place either an actor (vtkActor) or a point set
		/// (vtkPointSet) that represents the point cloud. If placing with an
		/// actor, then the actor must refer to a mapper which in turn refers to a
		/// vtkPointSet, with the actor being used to render the point cloud. If
		/// placing with a vtkPointSet, then an internal vtkActor (and associated
		/// vtkPointGaussianMapper) is created to render the point cloud.
		/// </summary>
		// Token: 0x06009A52 RID: 39506 RVA: 0x000DAB40 File Offset: 0x000D8D40
		public void PlacePointCloud(vtkActor a)
		{
			vtkPointCloudRepresentation.vtkPointCloudRepresentation_PlacePointCloud_30(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		// Token: 0x06009A53 RID: 39507
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointCloudRepresentation_PlacePointCloud_31(HandleRef pThis, HandleRef ps);

		/// <summary>
		/// Specify and place either an actor (vtkActor) or a point set
		/// (vtkPointSet) that represents the point cloud. If placing with an
		/// actor, then the actor must refer to a mapper which in turn refers to a
		/// vtkPointSet, with the actor being used to render the point cloud. If
		/// placing with a vtkPointSet, then an internal vtkActor (and associated
		/// vtkPointGaussianMapper) is created to render the point cloud.
		/// </summary>
		// Token: 0x06009A54 RID: 39508 RVA: 0x000DAB70 File Offset: 0x000D8D70
		public void PlacePointCloud(vtkPointSet ps)
		{
			vtkPointCloudRepresentation.vtkPointCloudRepresentation_PlacePointCloud_31(base.GetCppThis(), (ps == null) ? default(HandleRef) : ps.GetCppThis());
		}

		// Token: 0x06009A55 RID: 39509
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointCloudRepresentation_RegisterPickers_32(HandleRef pThis);

		/// <summary>
		/// The tolerance representing the distance to a point (as a fraction of the
		/// bounding box of the point cloud). This specifies when the cursor is
		/// considered near enough to the point to highlight it. Note that this is
		/// a sensitive parameter - too small and it's hard to pick anything; too
		/// large and points close to the eye can be picked in preference to points
		/// further away which are closer to the pick ray.
		/// </summary>
		// Token: 0x06009A56 RID: 39510 RVA: 0x000DAB9F File Offset: 0x000D8D9F
		public override void RegisterPickers()
		{
			vtkPointCloudRepresentation.vtkPointCloudRepresentation_RegisterPickers_32(base.GetCppThis());
		}

		// Token: 0x06009A57 RID: 39511
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointCloudRepresentation_ReleaseGraphicsResources_33(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp (i.e., support rendering).
		/// </summary>
		// Token: 0x06009A58 RID: 39512 RVA: 0x000DABB0 File Offset: 0x000D8DB0
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkPointCloudRepresentation.vtkPointCloudRepresentation_ReleaseGraphicsResources_33(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009A59 RID: 39513
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointCloudRepresentation_RenderOpaqueGeometry_34(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp (i.e., support rendering).
		/// </summary>
		// Token: 0x06009A5A RID: 39514 RVA: 0x000DABE0 File Offset: 0x000D8DE0
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkPointCloudRepresentation.vtkPointCloudRepresentation_RenderOpaqueGeometry_34(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06009A5B RID: 39515
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointCloudRepresentation_RenderOverlay_35(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp (i.e., support rendering).
		/// </summary>
		// Token: 0x06009A5C RID: 39516 RVA: 0x000DAC14 File Offset: 0x000D8E14
		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkPointCloudRepresentation.vtkPointCloudRepresentation_RenderOverlay_35(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009A5D RID: 39517
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointCloudRepresentation_RenderTranslucentPolygonalGeometry_36(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp (i.e., support rendering).
		/// </summary>
		// Token: 0x06009A5E RID: 39518 RVA: 0x000DAC48 File Offset: 0x000D8E48
		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkPointCloudRepresentation.vtkPointCloudRepresentation_RenderTranslucentPolygonalGeometry_36(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06009A5F RID: 39519
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointCloudRepresentation_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK class methods for obtaining type information and printing.
		/// </summary>
		// Token: 0x06009A60 RID: 39520 RVA: 0x000DAC7C File Offset: 0x000D8E7C
		public new static vtkPointCloudRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkPointCloudRepresentation vtkPointCloudRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointCloudRepresentation.vtkPointCloudRepresentation_SafeDownCast_37((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointCloudRepresentation = (vtkPointCloudRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointCloudRepresentation.Register(null);
				}
			}
			return vtkPointCloudRepresentation;
		}

		// Token: 0x06009A61 RID: 39521
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointCloudRepresentation_SetHardwarePickingTolerance_38(HandleRef pThis, uint _arg);

		/// <summary>
		/// The tolerance representing the distance to a point expressed in pixels.
		/// A tolerance of 0 selects from the pixel precisely under the cursor. A
		/// tolerance of 1 results in a 3x3 pixel square under the cursor (padded
		/// out by 1 in each direction); a tolerance of N results in a (2N+1)**2
		/// selection rectangle. The point in the selection rectangle which is
		/// closest in z-buffer to the pick position is selected. Note that this can
		/// sometimes return points further away from the cursor (which can be
		/// unexpected - use the tolerance carefully).
		/// </summary>
		// Token: 0x06009A62 RID: 39522 RVA: 0x000DACFB File Offset: 0x000D8EFB
		public virtual void SetHardwarePickingTolerance(uint _arg)
		{
			vtkPointCloudRepresentation.vtkPointCloudRepresentation_SetHardwarePickingTolerance_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06009A63 RID: 39523
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointCloudRepresentation_SetHighlighting_39(HandleRef pThis, byte _arg);

		/// <summary>
		/// Flag controls whether highlighting of points occurs as the mouse
		/// moves over them. This can cause extra rendering operations.
		/// </summary>
		// Token: 0x06009A64 RID: 39524 RVA: 0x000DAD0B File Offset: 0x000D8F0B
		public virtual void SetHighlighting(bool _arg)
		{
			vtkPointCloudRepresentation.vtkPointCloudRepresentation_SetHighlighting_39(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06009A65 RID: 39525
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointCloudRepresentation_SetInteractionState_40(HandleRef pThis, int _arg);

		/// <summary>
		/// The interaction state may be set from a widget (e.g., PointCloudWidget)
		/// or other object. This controls how the interaction with the widget
		/// proceeds. Normally this method is used as part of a handshaking process
		/// with the widget: First ComputeInteractionState() is invoked that returns
		/// a state based on geometric considerations (i.e., cursor near a widget
		/// feature), then based on events, the widget may modify this further.
		/// </summary>
		// Token: 0x06009A66 RID: 39526 RVA: 0x000DAD23 File Offset: 0x000D8F23
		public virtual void SetInteractionState(int _arg)
		{
			vtkPointCloudRepresentation.vtkPointCloudRepresentation_SetInteractionState_40(base.GetCppThis(), _arg);
		}

		// Token: 0x06009A67 RID: 39527
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointCloudRepresentation_SetPickingMode_41(HandleRef pThis, int _arg);

		/// <summary>
		/// Because point clouds can be very large, alternative point picking
		/// approaches can be used to select points: either hardware picking (via
		/// rendering) or software rendering (via CPU ray cast). In summary,
		/// hardware picking (via vtkHardwareSelector) is preferred, with an
		/// optional software picker (via vtkPointPicker) available. Each approach
		/// has potential advantages and disadvantages - mainly, vtkHardwareSelector
		/// is faster but only selects opaque geometry and what is visible on the
		/// screen, does not work with anti-aliasing, cannot handle assemblies, and
		/// may not work on some systems. vtkPointPicker avoids extra renders, and
		/// can handle translucent geometry, can select points "behind" other
		/// objects, will work on all systems, but is scalable to only a few tens of
		/// thousands of points. (See vtkHardwareSelector and vtkPointPicker for
		/// further information.) The choice of picker also has implications on the
		/// type of tolerancing used (as described in the following documentation).
		/// (Note also that the pickers may return slightly different results, this
		/// is expected due to the different way tolerancing works.)
		/// </summary>
		// Token: 0x06009A68 RID: 39528 RVA: 0x000DAD33 File Offset: 0x000D8F33
		public virtual void SetPickingMode(int _arg)
		{
			vtkPointCloudRepresentation.vtkPointCloudRepresentation_SetPickingMode_41(base.GetCppThis(), _arg);
		}

		// Token: 0x06009A69 RID: 39529
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointCloudRepresentation_SetPickingModeToHardware_42(HandleRef pThis);

		/// <summary>
		/// Because point clouds can be very large, alternative point picking
		/// approaches can be used to select points: either hardware picking (via
		/// rendering) or software rendering (via CPU ray cast). In summary,
		/// hardware picking (via vtkHardwareSelector) is preferred, with an
		/// optional software picker (via vtkPointPicker) available. Each approach
		/// has potential advantages and disadvantages - mainly, vtkHardwareSelector
		/// is faster but only selects opaque geometry and what is visible on the
		/// screen, does not work with anti-aliasing, cannot handle assemblies, and
		/// may not work on some systems. vtkPointPicker avoids extra renders, and
		/// can handle translucent geometry, can select points "behind" other
		/// objects, will work on all systems, but is scalable to only a few tens of
		/// thousands of points. (See vtkHardwareSelector and vtkPointPicker for
		/// further information.) The choice of picker also has implications on the
		/// type of tolerancing used (as described in the following documentation).
		/// (Note also that the pickers may return slightly different results, this
		/// is expected due to the different way tolerancing works.)
		/// </summary>
		// Token: 0x06009A6A RID: 39530 RVA: 0x000DAD43 File Offset: 0x000D8F43
		public void SetPickingModeToHardware()
		{
			vtkPointCloudRepresentation.vtkPointCloudRepresentation_SetPickingModeToHardware_42(base.GetCppThis());
		}

		// Token: 0x06009A6B RID: 39531
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointCloudRepresentation_SetPickingModeToSoftware_43(HandleRef pThis);

		/// <summary>
		/// Because point clouds can be very large, alternative point picking
		/// approaches can be used to select points: either hardware picking (via
		/// rendering) or software rendering (via CPU ray cast). In summary,
		/// hardware picking (via vtkHardwareSelector) is preferred, with an
		/// optional software picker (via vtkPointPicker) available. Each approach
		/// has potential advantages and disadvantages - mainly, vtkHardwareSelector
		/// is faster but only selects opaque geometry and what is visible on the
		/// screen, does not work with anti-aliasing, cannot handle assemblies, and
		/// may not work on some systems. vtkPointPicker avoids extra renders, and
		/// can handle translucent geometry, can select points "behind" other
		/// objects, will work on all systems, but is scalable to only a few tens of
		/// thousands of points. (See vtkHardwareSelector and vtkPointPicker for
		/// further information.) The choice of picker also has implications on the
		/// type of tolerancing used (as described in the following documentation).
		/// (Note also that the pickers may return slightly different results, this
		/// is expected due to the different way tolerancing works.)
		/// </summary>
		// Token: 0x06009A6C RID: 39532 RVA: 0x000DAD52 File Offset: 0x000D8F52
		public void SetPickingModeToSoftware()
		{
			vtkPointCloudRepresentation.vtkPointCloudRepresentation_SetPickingModeToSoftware_43(base.GetCppThis());
		}

		// Token: 0x06009A6D RID: 39533
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointCloudRepresentation_SetSoftwarePickingTolerance_44(HandleRef pThis, double _arg);

		/// <summary>
		/// The tolerance representing the distance to a point (as a fraction of the
		/// bounding box of the point cloud). This specifies when the cursor is
		/// considered near enough to the point to highlight it. Note that this is
		/// a sensitive parameter - too small and it's hard to pick anything; too
		/// large and points close to the eye can be picked in preference to points
		/// further away which are closer to the pick ray.
		/// </summary>
		// Token: 0x06009A6E RID: 39534 RVA: 0x000DAD61 File Offset: 0x000D8F61
		public virtual void SetSoftwarePickingTolerance(double _arg)
		{
			vtkPointCloudRepresentation.vtkPointCloudRepresentation_SetSoftwarePickingTolerance_44(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C8D RID: 3213
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointCloudRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C8E RID: 3214
		public new static readonly string MRClassNameKey = "class vtkPointCloudRepresentation";

		/// <summary>
		/// Flag controls whether highlighting of points occurs as the mouse
		/// moves over them. This can cause extra rendering operations.
		/// </summary>
		// Token: 0x02000350 RID: 848
		public enum InteractionStateType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000C90 RID: 3216
			Outside,
			/// <summary>enum member</summary>
			// Token: 0x04000C91 RID: 3217
			Over = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000C92 RID: 3218
			OverOutline = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000C93 RID: 3219
			Selecting = 3
		}

		/// <summary>
		/// Because point clouds can be very large, alternative point picking
		/// approaches can be used to select points: either hardware picking (via
		/// rendering) or software rendering (via CPU ray cast). In summary,
		/// hardware picking (via vtkHardwareSelector) is preferred, with an
		/// optional software picker (via vtkPointPicker) available. Each approach
		/// has potential advantages and disadvantages - mainly, vtkHardwareSelector
		/// is faster but only selects opaque geometry and what is visible on the
		/// screen, does not work with anti-aliasing, cannot handle assemblies, and
		/// may not work on some systems. vtkPointPicker avoids extra renders, and
		/// can handle translucent geometry, can select points "behind" other
		/// objects, will work on all systems, but is scalable to only a few tens of
		/// thousands of points. (See vtkHardwareSelector and vtkPointPicker for
		/// further information.) The choice of picker also has implications on the
		/// type of tolerancing used (as described in the following documentation).
		/// (Note also that the pickers may return slightly different results, this
		/// is expected due to the different way tolerancing works.)
		/// </summary>
		// Token: 0x02000351 RID: 849
		public enum PickingModeType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000C95 RID: 3221
			HARDWARE_PICKING,
			/// <summary>enum member</summary>
			// Token: 0x04000C96 RID: 3222
			SOFTWARE_PICKING
		}
	}
}
