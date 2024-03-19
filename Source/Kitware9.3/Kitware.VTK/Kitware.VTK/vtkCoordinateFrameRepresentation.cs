using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCoordinateFrameRepresentation
	/// </summary>
	/// <remarks>
	///    a class defining the representation for a vtkCoordinateFrameWidget
	///
	/// This class is a concrete representation for the
	/// vtkCoordinateFrameWidget. It represents a coordinate frame with an origin, 3 axis and
	/// 3 axis lockers. Through interaction with the widget, the coordinate frame can be manipulated
	/// by adjusting the axis normals, locking them, or moving/picking the origin point.
	///
	/// The PlaceWidget() method is also used to initially position the
	/// representation.
	///
	/// @warning
	/// This class, and vtkCoordinateFrameWidget, are next generation VTK
	/// widgets.
	/// </remarks>
	// Token: 0x02000305 RID: 773
	public class vtkCoordinateFrameRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008A23 RID: 35363 RVA: 0x000C522F File Offset: 0x000C342F
		static vtkCoordinateFrameRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCoordinateFrameRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCoordinateFrameRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008A24 RID: 35364 RVA: 0x000C5257 File Offset: 0x000C3457
		public vtkCoordinateFrameRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008A25 RID: 35365
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06008A26 RID: 35366 RVA: 0x000C5268 File Offset: 0x000C3468
		public new static vtkCoordinateFrameRepresentation New()
		{
			vtkCoordinateFrameRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCoordinateFrameRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06008A27 RID: 35367 RVA: 0x000C52BC File Offset: 0x000C34BC
		public vtkCoordinateFrameRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008A28 RID: 35368 RVA: 0x000C5300 File Offset: 0x000C3500
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008A29 RID: 35369
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Methods to interface with the vtkCoordinateFrameWidget.
		/// </summary>
		// Token: 0x06008A2A RID: 35370 RVA: 0x000C530B File Offset: 0x000C350B
		public override void BuildRepresentation()
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06008A2B RID: 35371
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCoordinateFrameRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// Methods to interface with the vtkCoordinateFrameWidget.
		/// </summary>
		// Token: 0x06008A2C RID: 35372 RVA: 0x000C531C File Offset: 0x000C351C
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x06008A2D RID: 35373
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_EndWidgetInteraction_03(HandleRef pThis, IntPtr newEventPos);

		/// <summary>
		/// Methods to interface with the vtkCoordinateFrameWidget.
		/// </summary>
		// Token: 0x06008A2E RID: 35374 RVA: 0x000C533E File Offset: 0x000C353E
		public override void EndWidgetInteraction(IntPtr newEventPos)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_EndWidgetInteraction_03(base.GetCppThis(), newEventPos);
		}

		// Token: 0x06008A2F RID: 35375
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_GetActors_04(HandleRef pThis, HandleRef pc);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x06008A30 RID: 35376 RVA: 0x000C5350 File Offset: 0x000C3550
		public override void GetActors(vtkPropCollection pc)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetActors_04(base.GetCppThis(), (pc == null) ? default(HandleRef) : pc.GetCppThis());
		}

		// Token: 0x06008A31 RID: 35377
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameRepresentation_GetBounds_05(HandleRef pThis);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x06008A32 RID: 35378 RVA: 0x000C5380 File Offset: 0x000C3580
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetBounds_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008A33 RID: 35379
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCoordinateFrameRepresentation_GetInteractionStateMaxValue_06(HandleRef pThis);

		/// <summary>
		/// The interaction state may be set from a widget (e.g.,
		/// vtkCoordinateFrameWidget) or other object. This controls how the
		/// interaction with the widget proceeds. Normally this method is used as
		/// part of a handshaking process with the widget: First
		/// ComputeInteractionState() is invoked that returns a state based on
		/// geometric considerations (i.e., cursor near a widget feature), then
		/// based on events, the widget may modify this further.
		/// </summary>
		// Token: 0x06008A34 RID: 35380 RVA: 0x000C53C8 File Offset: 0x000C35C8
		public virtual int GetInteractionStateMaxValue()
		{
			return vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetInteractionStateMaxValue_06(base.GetCppThis());
		}

		// Token: 0x06008A35 RID: 35381
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCoordinateFrameRepresentation_GetInteractionStateMinValue_07(HandleRef pThis);

		/// <summary>
		/// The interaction state may be set from a widget (e.g.,
		/// vtkCoordinateFrameWidget) or other object. This controls how the
		/// interaction with the widget proceeds. Normally this method is used as
		/// part of a handshaking process with the widget: First
		/// ComputeInteractionState() is invoked that returns a state based on
		/// geometric considerations (i.e., cursor near a widget feature), then
		/// based on events, the widget may modify this further.
		/// </summary>
		// Token: 0x06008A36 RID: 35382 RVA: 0x000C53E8 File Offset: 0x000C35E8
		public virtual int GetInteractionStateMinValue()
		{
			return vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetInteractionStateMinValue_07(base.GetCppThis());
		}

		// Token: 0x06008A37 RID: 35383
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCoordinateFrameRepresentation_GetLengthFactor_08(HandleRef pThis);

		/// <summary>
		/// Set/get the length of the axis glyphs relative to screen size.
		/// The default is 0.04.
		/// </summary>
		// Token: 0x06008A38 RID: 35384 RVA: 0x000C5408 File Offset: 0x000C3608
		public virtual double GetLengthFactor()
		{
			return vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetLengthFactor_08(base.GetCppThis());
		}

		// Token: 0x06008A39 RID: 35385
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCoordinateFrameRepresentation_GetLengthFactorMaxValue_09(HandleRef pThis);

		/// <summary>
		/// Set/get the length of the axis glyphs relative to screen size.
		/// The default is 0.04.
		/// </summary>
		// Token: 0x06008A3A RID: 35386 RVA: 0x000C5428 File Offset: 0x000C3628
		public virtual double GetLengthFactorMaxValue()
		{
			return vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetLengthFactorMaxValue_09(base.GetCppThis());
		}

		// Token: 0x06008A3B RID: 35387
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCoordinateFrameRepresentation_GetLengthFactorMinValue_10(HandleRef pThis);

		/// <summary>
		/// Set/get the length of the axis glyphs relative to screen size.
		/// The default is 0.04.
		/// </summary>
		// Token: 0x06008A3C RID: 35388 RVA: 0x000C5448 File Offset: 0x000C3648
		public virtual double GetLengthFactorMinValue()
		{
			return vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetLengthFactorMinValue_10(base.GetCppThis());
		}

		// Token: 0x06008A3D RID: 35389
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCoordinateFrameRepresentation_GetLockNormalToCamera_11(HandleRef pThis);

		/// <summary>
		/// If enabled, and a vtkCamera is available through the renderer, then
		/// LockNormalToCamera will cause the normal to follow the camera's
		/// normal.
		/// </summary>
		// Token: 0x06008A3E RID: 35390 RVA: 0x000C5468 File Offset: 0x000C3668
		public virtual int GetLockNormalToCamera()
		{
			return vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetLockNormalToCamera_11(base.GetCppThis());
		}

		// Token: 0x06008A3F RID: 35391
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCoordinateFrameRepresentation_GetLockedAxis_12(HandleRef pThis);

		/// <summary>
		/// Get/set which axis (if any) is locked.
		///
		/// At most, a single axis can be locked at a time.
		///
		/// The axis must be one of the following values: { -1, 0, 1, 2 }.
		/// -1 indicates that no axis is locked; 0 corresponds to the X axis; 1 to Y; and 2 to Z.
		///
		/// In terms of mouse interactions, locking an axis prevents its direction from being
		/// modified by rotation (so only rotations about that axis are possible) and
		/// prevents the origin from translating along it (so all translations must be in the
		/// plane using it as a normal).
		///
		/// In terms of picking interactions, locking an axis selects it as the target axis
		/// to be modified (i.e., the locked axis will be overwritten with a normal vector
		/// or direction vector).
		/// </summary>
		// Token: 0x06008A40 RID: 35392 RVA: 0x000C5488 File Offset: 0x000C3688
		public int GetLockedAxis()
		{
			return vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetLockedAxis_12(base.GetCppThis());
		}

		// Token: 0x06008A41 RID: 35393
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameRepresentation_GetLockedXVectorProperty_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties on the LockedXVector. The properties of the LockedXVector when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06008A42 RID: 35394 RVA: 0x000C54A8 File Offset: 0x000C36A8
		public virtual vtkProperty GetLockedXVectorProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetLockedXVectorProperty_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008A43 RID: 35395
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameRepresentation_GetLockedYVectorProperty_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties on the LockedYVector. The properties of the LockedYVector when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06008A44 RID: 35396 RVA: 0x000C5518 File Offset: 0x000C3718
		public virtual vtkProperty GetLockedYVectorProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetLockedYVectorProperty_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008A45 RID: 35397
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameRepresentation_GetLockedZVectorProperty_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties on the LockedZVector. The properties of the LockedZVector when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06008A46 RID: 35398 RVA: 0x000C5588 File Offset: 0x000C3788
		public virtual vtkProperty GetLockedZVectorProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetLockedZVectorProperty_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008A47 RID: 35399
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCoordinateFrameRepresentation_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008A48 RID: 35400 RVA: 0x000C55F8 File Offset: 0x000C37F8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x06008A49 RID: 35401
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCoordinateFrameRepresentation_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008A4A RID: 35402 RVA: 0x000C5618 File Offset: 0x000C3818
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x06008A4B RID: 35403
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameRepresentation_GetOrigin_18(HandleRef pThis);

		/// <summary>
		/// Set/Get the origin of the coordinate frame.
		/// </summary>
		// Token: 0x06008A4C RID: 35404 RVA: 0x000C5634 File Offset: 0x000C3834
		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetOrigin_18(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008A4D RID: 35405
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_GetOrigin_19(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the origin of the coordinate frame.
		/// </summary>
		// Token: 0x06008A4E RID: 35406 RVA: 0x000C567C File Offset: 0x000C387C
		public virtual void GetOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetOrigin_19(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06008A4F RID: 35407
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_GetOrigin_20(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the origin of the coordinate frame.
		/// </summary>
		// Token: 0x06008A50 RID: 35408 RVA: 0x000C568E File Offset: 0x000C388E
		public virtual void GetOrigin(IntPtr _arg)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetOrigin_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06008A51 RID: 35409
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameRepresentation_GetOriginProperty_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties of the origin. The properties of the origin when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06008A52 RID: 35410 RVA: 0x000C56A0 File Offset: 0x000C38A0
		public virtual vtkProperty GetOriginProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetOriginProperty_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008A53 RID: 35411
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCoordinateFrameRepresentation_GetPickCameraFocalInfo_22(HandleRef pThis);

		/// <summary>
		/// Enable/Disable picking camera focal info if no result is available for PickOrigin, PickNormal
		/// and PickDirectionPoint. The default is disabled.
		/// </summary>
		// Token: 0x06008A54 RID: 35412 RVA: 0x000C5710 File Offset: 0x000C3910
		public virtual bool GetPickCameraFocalInfo()
		{
			return vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetPickCameraFocalInfo_22(base.GetCppThis()) != 0;
		}

		// Token: 0x06008A55 RID: 35413
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCoordinateFrameRepresentation_GetRepresentationState_23(HandleRef pThis);

		/// <summary>
		/// Sets the visual appearance of the representation based on the
		/// state it is in. This state is usually the same as InteractionState.
		/// </summary>
		// Token: 0x06008A56 RID: 35414 RVA: 0x000C5738 File Offset: 0x000C3938
		public virtual int GetRepresentationState()
		{
			return vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetRepresentationState_23(base.GetCppThis());
		}

		// Token: 0x06008A57 RID: 35415
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameRepresentation_GetSelectedLockedXVectorProperty_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties on the LockedXVector. The properties of the LockedXVector when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06008A58 RID: 35416 RVA: 0x000C5758 File Offset: 0x000C3958
		public virtual vtkProperty GetSelectedLockedXVectorProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetSelectedLockedXVectorProperty_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008A59 RID: 35417
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameRepresentation_GetSelectedLockedYVectorProperty_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties on the LockedYVector. The properties of the LockedYVector when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06008A5A RID: 35418 RVA: 0x000C57C8 File Offset: 0x000C39C8
		public virtual vtkProperty GetSelectedLockedYVectorProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetSelectedLockedYVectorProperty_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008A5B RID: 35419
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameRepresentation_GetSelectedLockedZVectorProperty_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties on the LockedZVector. The properties of the LockedZVector when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06008A5C RID: 35420 RVA: 0x000C5838 File Offset: 0x000C3A38
		public virtual vtkProperty GetSelectedLockedZVectorProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetSelectedLockedZVectorProperty_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008A5D RID: 35421
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameRepresentation_GetSelectedOriginProperty_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties of the origin. The properties of the origin when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06008A5E RID: 35422 RVA: 0x000C58A8 File Offset: 0x000C3AA8
		public virtual vtkProperty GetSelectedOriginProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetSelectedOriginProperty_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008A5F RID: 35423
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameRepresentation_GetSelectedUnlockedXVectorProperty_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties on the UnlockedXVector. The properties of the UnlockedXVector when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06008A60 RID: 35424 RVA: 0x000C5918 File Offset: 0x000C3B18
		public virtual vtkProperty GetSelectedUnlockedXVectorProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetSelectedUnlockedXVectorProperty_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008A61 RID: 35425
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameRepresentation_GetSelectedUnlockedYVectorProperty_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties on the UnlockedYVector. The properties of the UnlockedYVector when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06008A62 RID: 35426 RVA: 0x000C5988 File Offset: 0x000C3B88
		public virtual vtkProperty GetSelectedUnlockedYVectorProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetSelectedUnlockedYVectorProperty_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008A63 RID: 35427
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameRepresentation_GetSelectedUnlockedZVectorProperty_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties on the UnlockedZVector. The properties of the UnlockedZVector when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06008A64 RID: 35428 RVA: 0x000C59F8 File Offset: 0x000C3BF8
		public virtual vtkProperty GetSelectedUnlockedZVectorProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetSelectedUnlockedZVectorProperty_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008A65 RID: 35429
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameRepresentation_GetSelectedXVectorProperty_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties on the XVector. The properties of the XVector when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06008A66 RID: 35430 RVA: 0x000C5A68 File Offset: 0x000C3C68
		public virtual vtkProperty GetSelectedXVectorProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetSelectedXVectorProperty_31(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008A67 RID: 35431
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameRepresentation_GetSelectedYVectorProperty_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties on the YVector. The properties of the YVector when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06008A68 RID: 35432 RVA: 0x000C5AD8 File Offset: 0x000C3CD8
		public virtual vtkProperty GetSelectedYVectorProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetSelectedYVectorProperty_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008A69 RID: 35433
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameRepresentation_GetSelectedZVectorProperty_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties on the ZVector. The properties of the ZVector when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06008A6A RID: 35434 RVA: 0x000C5B48 File Offset: 0x000C3D48
		public virtual vtkProperty GetSelectedZVectorProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetSelectedZVectorProperty_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008A6B RID: 35435
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameRepresentation_GetUnlockedXVectorProperty_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties on the UnlockedXVector. The properties of the UnlockedXVector when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06008A6C RID: 35436 RVA: 0x000C5BB8 File Offset: 0x000C3DB8
		public virtual vtkProperty GetUnlockedXVectorProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetUnlockedXVectorProperty_34(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008A6D RID: 35437
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameRepresentation_GetUnlockedYVectorProperty_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties on the UnlockedYVector. The properties of the UnlockedYVector when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06008A6E RID: 35438 RVA: 0x000C5C28 File Offset: 0x000C3E28
		public virtual vtkProperty GetUnlockedYVectorProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetUnlockedYVectorProperty_35(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008A6F RID: 35439
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameRepresentation_GetUnlockedZVectorProperty_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties on the UnlockedZVector. The properties of the UnlockedZVector when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06008A70 RID: 35440 RVA: 0x000C5C98 File Offset: 0x000C3E98
		public virtual vtkProperty GetUnlockedZVectorProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetUnlockedZVectorProperty_36(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008A71 RID: 35441
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameRepresentation_GetXVectorNormal_37(HandleRef pThis);

		/// <summary>
		/// Set/Get the normal of one of the axes of the coordinate frame.
		///
		/// 1) If 1 arrow tip is constrained, the corresponding normal vector is set to the picked normal.
		/// 2) Otherwise, the axis closest to the picked normal (i.e., with the largest dot product) is
		/// reset to the picked normal.
		///
		/// In both cases, the remaining normals are re-orthogonalized using the
		/// &lt;a href="https://en.wikipedia.org/wiki/Gram%E2%80%93Schmidt_process"&gt;
		/// Gram-Schmidt procedure&lt;/a&gt;.
		/// </summary>
		// Token: 0x06008A72 RID: 35442 RVA: 0x000C5D08 File Offset: 0x000C3F08
		public virtual double[] GetXVectorNormal()
		{
			IntPtr intPtr = vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetXVectorNormal_37(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008A73 RID: 35443
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_GetXVectorNormal_38(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the normal of one of the axes of the coordinate frame.
		///
		/// 1) If 1 arrow tip is constrained, the corresponding normal vector is set to the picked normal.
		/// 2) Otherwise, the axis closest to the picked normal (i.e., with the largest dot product) is
		/// reset to the picked normal.
		///
		/// In both cases, the remaining normals are re-orthogonalized using the
		/// &lt;a href="https://en.wikipedia.org/wiki/Gram%E2%80%93Schmidt_process"&gt;
		/// Gram-Schmidt procedure&lt;/a&gt;.
		/// </summary>
		// Token: 0x06008A74 RID: 35444 RVA: 0x000C5D50 File Offset: 0x000C3F50
		public virtual void GetXVectorNormal(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetXVectorNormal_38(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06008A75 RID: 35445
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_GetXVectorNormal_39(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the normal of one of the axes of the coordinate frame.
		///
		/// 1) If 1 arrow tip is constrained, the corresponding normal vector is set to the picked normal.
		/// 2) Otherwise, the axis closest to the picked normal (i.e., with the largest dot product) is
		/// reset to the picked normal.
		///
		/// In both cases, the remaining normals are re-orthogonalized using the
		/// &lt;a href="https://en.wikipedia.org/wiki/Gram%E2%80%93Schmidt_process"&gt;
		/// Gram-Schmidt procedure&lt;/a&gt;.
		/// </summary>
		// Token: 0x06008A76 RID: 35446 RVA: 0x000C5D62 File Offset: 0x000C3F62
		public virtual void GetXVectorNormal(IntPtr _arg)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetXVectorNormal_39(base.GetCppThis(), _arg);
		}

		// Token: 0x06008A77 RID: 35447
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameRepresentation_GetXVectorProperty_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties on the XVector. The properties of the XVector when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06008A78 RID: 35448 RVA: 0x000C5D74 File Offset: 0x000C3F74
		public virtual vtkProperty GetXVectorProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetXVectorProperty_40(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008A79 RID: 35449
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameRepresentation_GetYVectorNormal_41(HandleRef pThis);

		/// <summary>
		/// Set/Get the normal of one of the axes of the coordinate frame.
		///
		/// 1) If 1 arrow tip is constrained, the corresponding normal vector is set to the picked normal.
		/// 2) Otherwise, the axis closest to the picked normal (i.e., with the largest dot product) is
		/// reset to the picked normal.
		///
		/// In both cases, the remaining normals are re-orthogonalized using the
		/// &lt;a href="https://en.wikipedia.org/wiki/Gram%E2%80%93Schmidt_process"&gt;
		/// Gram-Schmidt procedure&lt;/a&gt;.
		/// </summary>
		// Token: 0x06008A7A RID: 35450 RVA: 0x000C5DE4 File Offset: 0x000C3FE4
		public virtual double[] GetYVectorNormal()
		{
			IntPtr intPtr = vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetYVectorNormal_41(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008A7B RID: 35451
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_GetYVectorNormal_42(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the normal of one of the axes of the coordinate frame.
		///
		/// 1) If 1 arrow tip is constrained, the corresponding normal vector is set to the picked normal.
		/// 2) Otherwise, the axis closest to the picked normal (i.e., with the largest dot product) is
		/// reset to the picked normal.
		///
		/// In both cases, the remaining normals are re-orthogonalized using the
		/// &lt;a href="https://en.wikipedia.org/wiki/Gram%E2%80%93Schmidt_process"&gt;
		/// Gram-Schmidt procedure&lt;/a&gt;.
		/// </summary>
		// Token: 0x06008A7C RID: 35452 RVA: 0x000C5E2C File Offset: 0x000C402C
		public virtual void GetYVectorNormal(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetYVectorNormal_42(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06008A7D RID: 35453
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_GetYVectorNormal_43(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the normal of one of the axes of the coordinate frame.
		///
		/// 1) If 1 arrow tip is constrained, the corresponding normal vector is set to the picked normal.
		/// 2) Otherwise, the axis closest to the picked normal (i.e., with the largest dot product) is
		/// reset to the picked normal.
		///
		/// In both cases, the remaining normals are re-orthogonalized using the
		/// &lt;a href="https://en.wikipedia.org/wiki/Gram%E2%80%93Schmidt_process"&gt;
		/// Gram-Schmidt procedure&lt;/a&gt;.
		/// </summary>
		// Token: 0x06008A7E RID: 35454 RVA: 0x000C5E3E File Offset: 0x000C403E
		public virtual void GetYVectorNormal(IntPtr _arg)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetYVectorNormal_43(base.GetCppThis(), _arg);
		}

		// Token: 0x06008A7F RID: 35455
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameRepresentation_GetYVectorProperty_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties on the YVector. The properties of the YVector when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06008A80 RID: 35456 RVA: 0x000C5E50 File Offset: 0x000C4050
		public virtual vtkProperty GetYVectorProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetYVectorProperty_44(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008A81 RID: 35457
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameRepresentation_GetZVectorNormal_45(HandleRef pThis);

		/// <summary>
		/// Set/Get the normal of one of the axes of the coordinate frame.
		///
		/// 1) If 1 arrow tip is constrained, the corresponding normal vector is set to the picked normal.
		/// 2) Otherwise, the axis closest to the picked normal (i.e., with the largest dot product) is
		/// reset to the picked normal.
		///
		/// In both cases, the remaining normals are re-orthogonalized using the
		/// &lt;a href="https://en.wikipedia.org/wiki/Gram%E2%80%93Schmidt_process"&gt;
		/// Gram-Schmidt procedure&lt;/a&gt;.
		/// </summary>
		// Token: 0x06008A82 RID: 35458 RVA: 0x000C5EC0 File Offset: 0x000C40C0
		public virtual double[] GetZVectorNormal()
		{
			IntPtr intPtr = vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetZVectorNormal_45(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008A83 RID: 35459
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_GetZVectorNormal_46(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the normal of one of the axes of the coordinate frame.
		///
		/// 1) If 1 arrow tip is constrained, the corresponding normal vector is set to the picked normal.
		/// 2) Otherwise, the axis closest to the picked normal (i.e., with the largest dot product) is
		/// reset to the picked normal.
		///
		/// In both cases, the remaining normals are re-orthogonalized using the
		/// &lt;a href="https://en.wikipedia.org/wiki/Gram%E2%80%93Schmidt_process"&gt;
		/// Gram-Schmidt procedure&lt;/a&gt;.
		/// </summary>
		// Token: 0x06008A84 RID: 35460 RVA: 0x000C5F08 File Offset: 0x000C4108
		public virtual void GetZVectorNormal(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetZVectorNormal_46(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06008A85 RID: 35461
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_GetZVectorNormal_47(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the normal of one of the axes of the coordinate frame.
		///
		/// 1) If 1 arrow tip is constrained, the corresponding normal vector is set to the picked normal.
		/// 2) Otherwise, the axis closest to the picked normal (i.e., with the largest dot product) is
		/// reset to the picked normal.
		///
		/// In both cases, the remaining normals are re-orthogonalized using the
		/// &lt;a href="https://en.wikipedia.org/wiki/Gram%E2%80%93Schmidt_process"&gt;
		/// Gram-Schmidt procedure&lt;/a&gt;.
		/// </summary>
		// Token: 0x06008A86 RID: 35462 RVA: 0x000C5F1A File Offset: 0x000C411A
		public virtual void GetZVectorNormal(IntPtr _arg)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetZVectorNormal_47(base.GetCppThis(), _arg);
		}

		// Token: 0x06008A87 RID: 35463
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameRepresentation_GetZVectorProperty_48(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties on the ZVector. The properties of the ZVector when selected
		/// and unselected can be manipulated.
		/// </summary>
		// Token: 0x06008A88 RID: 35464 RVA: 0x000C5F2C File Offset: 0x000C412C
		public virtual vtkProperty GetZVectorProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_GetZVectorProperty_48(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008A89 RID: 35465
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCoordinateFrameRepresentation_HasTranslucentPolygonalGeometry_49(HandleRef pThis);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x06008A8A RID: 35466 RVA: 0x000C5F9C File Offset: 0x000C419C
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_HasTranslucentPolygonalGeometry_49(base.GetCppThis());
		}

		// Token: 0x06008A8B RID: 35467
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCoordinateFrameRepresentation_IsA_50(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008A8C RID: 35468 RVA: 0x000C5FBC File Offset: 0x000C41BC
		public override int IsA(string type)
		{
			return vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_IsA_50(base.GetCppThis(), type);
		}

		// Token: 0x06008A8D RID: 35469
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCoordinateFrameRepresentation_IsTranslationConstrained_51(HandleRef pThis);

		/// <summary>
		/// Returns true if ConstrainedAxis
		/// </summary>
		// Token: 0x06008A8E RID: 35470 RVA: 0x000C5FDC File Offset: 0x000C41DC
		public bool IsTranslationConstrained()
		{
			return vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_IsTranslationConstrained_51(base.GetCppThis()) != 0;
		}

		// Token: 0x06008A8F RID: 35471
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCoordinateFrameRepresentation_IsTypeOf_52([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008A90 RID: 35472 RVA: 0x000C6004 File Offset: 0x000C4204
		public new static int IsTypeOf(string type)
		{
			return vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_IsTypeOf_52(type);
		}

		// Token: 0x06008A91 RID: 35473
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_LockNormalToCameraOff_53(HandleRef pThis);

		/// <summary>
		/// If enabled, and a vtkCamera is available through the renderer, then
		/// LockNormalToCamera will cause the normal to follow the camera's
		/// normal.
		/// </summary>
		// Token: 0x06008A92 RID: 35474 RVA: 0x000C601E File Offset: 0x000C421E
		public virtual void LockNormalToCameraOff()
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_LockNormalToCameraOff_53(base.GetCppThis());
		}

		// Token: 0x06008A93 RID: 35475
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_LockNormalToCameraOn_54(HandleRef pThis);

		/// <summary>
		/// If enabled, and a vtkCamera is available through the renderer, then
		/// LockNormalToCamera will cause the normal to follow the camera's
		/// normal.
		/// </summary>
		// Token: 0x06008A94 RID: 35476 RVA: 0x000C602D File Offset: 0x000C422D
		public virtual void LockNormalToCameraOn()
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_LockNormalToCameraOn_54(base.GetCppThis());
		}

		// Token: 0x06008A95 RID: 35477
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameRepresentation_NewInstance_56(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008A96 RID: 35478 RVA: 0x000C603C File Offset: 0x000C423C
		public new vtkCoordinateFrameRepresentation NewInstance()
		{
			vtkCoordinateFrameRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_NewInstance_56(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCoordinateFrameRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008A97 RID: 35479
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_PickCameraFocalInfoOff_57(HandleRef pThis);

		/// <summary>
		/// Enable/Disable picking camera focal info if no result is available for PickOrigin, PickNormal
		/// and PickDirectionPoint. The default is disabled.
		/// </summary>
		// Token: 0x06008A98 RID: 35480 RVA: 0x000C6096 File Offset: 0x000C4296
		public virtual void PickCameraFocalInfoOff()
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_PickCameraFocalInfoOff_57(base.GetCppThis());
		}

		// Token: 0x06008A99 RID: 35481
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_PickCameraFocalInfoOn_58(HandleRef pThis);

		/// <summary>
		/// Enable/Disable picking camera focal info if no result is available for PickOrigin, PickNormal
		/// and PickDirectionPoint. The default is disabled.
		/// </summary>
		// Token: 0x06008A9A RID: 35482 RVA: 0x000C60A5 File Offset: 0x000C42A5
		public virtual void PickCameraFocalInfoOn()
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_PickCameraFocalInfoOn_58(base.GetCppThis());
		}

		// Token: 0x06008A9B RID: 35483
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCoordinateFrameRepresentation_PickDirectionPoint_59(HandleRef pThis, int X, int Y, byte snapToMeshPoint);

		/// <summary>
		/// Given the X, Y display coordinates, pick a point and using the origin define normal for the
		/// coordinate frame from a point that is on the objects rendered by the renderer.
		///
		/// Note: if a point from a rendered object is not picked, the camera focal point can optionally be
		/// set.
		/// </summary>
		// Token: 0x06008A9C RID: 35484 RVA: 0x000C60B4 File Offset: 0x000C42B4
		public bool PickDirectionPoint(int X, int Y, bool snapToMeshPoint)
		{
			return vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_PickDirectionPoint_59(base.GetCppThis(), X, Y, snapToMeshPoint ? (byte)1 : (byte)0) != 0;
		}

		// Token: 0x06008A9D RID: 35485
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCoordinateFrameRepresentation_PickNormal_60(HandleRef pThis, int X, int Y, byte snapToMeshPoint);

		/// <summary>
		/// Given the X, Y display coordinates, pick a new normal for the coordinate frame
		/// from a point that is on the objects rendered by the renderer.
		///
		/// Note: if a normal from a rendered object is not picked, the camera plane normal can optionally
		/// be set.
		/// </summary>
		// Token: 0x06008A9E RID: 35486 RVA: 0x000C60E8 File Offset: 0x000C42E8
		public bool PickNormal(int X, int Y, bool snapToMeshPoint)
		{
			return vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_PickNormal_60(base.GetCppThis(), X, Y, snapToMeshPoint ? (byte)1 : (byte)0) != 0;
		}

		// Token: 0x06008A9F RID: 35487
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCoordinateFrameRepresentation_PickOrigin_61(HandleRef pThis, int X, int Y, byte snapToMeshPoint);

		/// <summary>
		/// Given the X, Y display coordinates, pick a new origin for the coordinate frame
		/// from a point that is on the objects rendered by the renderer.
		///
		/// Note: if a point from a rendered object is not picked, the camera focal point can optionally be
		/// set.
		/// </summary>
		// Token: 0x06008AA0 RID: 35488 RVA: 0x000C611C File Offset: 0x000C431C
		public bool PickOrigin(int X, int Y, bool snapToMeshPoint)
		{
			return vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_PickOrigin_61(base.GetCppThis(), X, Y, snapToMeshPoint ? (byte)1 : (byte)0) != 0;
		}

		// Token: 0x06008AA1 RID: 35489
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_PlaceWidget_62(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Methods to interface with the vtkCoordinateFrameWidget.
		/// </summary>
		// Token: 0x06008AA2 RID: 35490 RVA: 0x000C614D File Offset: 0x000C434D
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_PlaceWidget_62(base.GetCppThis(), bounds);
		}

		// Token: 0x06008AA3 RID: 35491
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_ReleaseGraphicsResources_63(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x06008AA4 RID: 35492 RVA: 0x000C6160 File Offset: 0x000C4360
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_ReleaseGraphicsResources_63(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008AA5 RID: 35493
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCoordinateFrameRepresentation_RenderOpaqueGeometry_64(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x06008AA6 RID: 35494 RVA: 0x000C6190 File Offset: 0x000C4390
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_RenderOpaqueGeometry_64(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008AA7 RID: 35495
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCoordinateFrameRepresentation_RenderTranslucentPolygonalGeometry_65(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x06008AA8 RID: 35496 RVA: 0x000C61C4 File Offset: 0x000C43C4
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_RenderTranslucentPolygonalGeometry_65(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008AA9 RID: 35497
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_Reset_66(HandleRef pThis);

		/// <summary>
		/// Reset the origin (by calling update placement) and the axes (to be aligned
		/// with the world coordinate X, Y, and Z axes).
		/// </summary>
		// Token: 0x06008AAA RID: 35498 RVA: 0x000C61F8 File Offset: 0x000C43F8
		public void Reset()
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_Reset_66(base.GetCppThis());
		}

		// Token: 0x06008AAB RID: 35499
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_ResetAxes_67(HandleRef pThis);

		/// <summary>
		/// Reset only the axis orientations (not the origin).
		/// </summary>
		// Token: 0x06008AAC RID: 35500 RVA: 0x000C6207 File Offset: 0x000C4407
		public void ResetAxes()
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_ResetAxes_67(base.GetCppThis());
		}

		// Token: 0x06008AAD RID: 35501
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCoordinateFrameRepresentation_SafeDownCast_68(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008AAE RID: 35502 RVA: 0x000C6218 File Offset: 0x000C4418
		public new static vtkCoordinateFrameRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkCoordinateFrameRepresentation vtkCoordinateFrameRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_SafeDownCast_68((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoordinateFrameRepresentation = (vtkCoordinateFrameRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoordinateFrameRepresentation.Register(null);
				}
			}
			return vtkCoordinateFrameRepresentation;
		}

		// Token: 0x06008AAF RID: 35503
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_SetDirection_69(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set the direction of the locked (or absent a locked axis, the nearest
		/// axis) to point from the frame's origin toward the given (x,y,z) location.
		/// </summary>
		// Token: 0x06008AB0 RID: 35504 RVA: 0x000C6297 File Offset: 0x000C4497
		public void SetDirection(double x, double y, double z)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_SetDirection_69(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06008AB1 RID: 35505
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_SetDirection_70(HandleRef pThis, IntPtr d);

		/// <summary>
		/// Set the direction of the locked (or absent a locked axis, the nearest
		/// axis) to point from the frame's origin toward the given (x,y,z) location.
		/// </summary>
		// Token: 0x06008AB2 RID: 35506 RVA: 0x000C62A9 File Offset: 0x000C44A9
		public void SetDirection(IntPtr d)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_SetDirection_70(base.GetCppThis(), d);
		}

		// Token: 0x06008AB3 RID: 35507
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_SetInteractionState_71(HandleRef pThis, int _arg);

		/// <summary>
		/// The interaction state may be set from a widget (e.g.,
		/// vtkCoordinateFrameWidget) or other object. This controls how the
		/// interaction with the widget proceeds. Normally this method is used as
		/// part of a handshaking process with the widget: First
		/// ComputeInteractionState() is invoked that returns a state based on
		/// geometric considerations (i.e., cursor near a widget feature), then
		/// based on events, the widget may modify this further.
		/// </summary>
		// Token: 0x06008AB4 RID: 35508 RVA: 0x000C62B9 File Offset: 0x000C44B9
		public virtual void SetInteractionState(int _arg)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_SetInteractionState_71(base.GetCppThis(), _arg);
		}

		// Token: 0x06008AB5 RID: 35509
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_SetLengthFactor_72(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/get the length of the axis glyphs relative to screen size.
		/// The default is 0.04.
		/// </summary>
		// Token: 0x06008AB6 RID: 35510 RVA: 0x000C62C9 File Offset: 0x000C44C9
		public virtual void SetLengthFactor(double _arg)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_SetLengthFactor_72(base.GetCppThis(), _arg);
		}

		// Token: 0x06008AB7 RID: 35511
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_SetLockNormalToCamera_73(HandleRef pThis, int arg0);

		/// <summary>
		/// If enabled, and a vtkCamera is available through the renderer, then
		/// LockNormalToCamera will cause the normal to follow the camera's
		/// normal.
		/// </summary>
		// Token: 0x06008AB8 RID: 35512 RVA: 0x000C62D9 File Offset: 0x000C44D9
		public virtual void SetLockNormalToCamera(int arg0)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_SetLockNormalToCamera_73(base.GetCppThis(), arg0);
		}

		// Token: 0x06008AB9 RID: 35513
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_SetLockedAxis_74(HandleRef pThis, int axis);

		/// <summary>
		/// Get/set which axis (if any) is locked.
		///
		/// At most, a single axis can be locked at a time.
		///
		/// The axis must be one of the following values: { -1, 0, 1, 2 }.
		/// -1 indicates that no axis is locked; 0 corresponds to the X axis; 1 to Y; and 2 to Z.
		///
		/// In terms of mouse interactions, locking an axis prevents its direction from being
		/// modified by rotation (so only rotations about that axis are possible) and
		/// prevents the origin from translating along it (so all translations must be in the
		/// plane using it as a normal).
		///
		/// In terms of picking interactions, locking an axis selects it as the target axis
		/// to be modified (i.e., the locked axis will be overwritten with a normal vector
		/// or direction vector).
		/// </summary>
		// Token: 0x06008ABA RID: 35514 RVA: 0x000C62E9 File Offset: 0x000C44E9
		public void SetLockedAxis(int axis)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_SetLockedAxis_74(base.GetCppThis(), axis);
		}

		// Token: 0x06008ABB RID: 35515
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_SetNormal_75(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set/Get the normal of one of the axes of the coordinate frame.
		///
		/// 1) If 1 arrow tip is constrained, the corresponding normal vector is set to the picked normal.
		/// 2) Otherwise, the axis closest to the picked normal (i.e., with the largest dot product) is
		/// reset to the picked normal.
		///
		/// In both cases, the remaining normals are re-orthogonalized using the
		/// &lt;a href="https://en.wikipedia.org/wiki/Gram%E2%80%93Schmidt_process"&gt;
		/// Gram-Schmidt procedure&lt;/a&gt;.
		/// </summary>
		// Token: 0x06008ABC RID: 35516 RVA: 0x000C62F9 File Offset: 0x000C44F9
		public void SetNormal(double x, double y, double z)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_SetNormal_75(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06008ABD RID: 35517
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_SetNormal_76(HandleRef pThis, IntPtr n);

		/// <summary>
		/// Set/Get the normal of one of the axes of the coordinate frame.
		///
		/// 1) If 1 arrow tip is constrained, the corresponding normal vector is set to the picked normal.
		/// 2) Otherwise, the axis closest to the picked normal (i.e., with the largest dot product) is
		/// reset to the picked normal.
		///
		/// In both cases, the remaining normals are re-orthogonalized using the
		/// &lt;a href="https://en.wikipedia.org/wiki/Gram%E2%80%93Schmidt_process"&gt;
		/// Gram-Schmidt procedure&lt;/a&gt;.
		/// </summary>
		// Token: 0x06008ABE RID: 35518 RVA: 0x000C630B File Offset: 0x000C450B
		public void SetNormal(IntPtr n)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_SetNormal_76(base.GetCppThis(), n);
		}

		// Token: 0x06008ABF RID: 35519
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_SetNormalToCamera_77(HandleRef pThis);

		/// <summary>
		/// Set/Get the normal of one of the axes of the coordinate frame.
		///
		/// 1) If 1 arrow tip is constrained, the corresponding normal vector is set to the picked normal.
		/// 2) Otherwise, the axis closest to the picked normal (i.e., with the largest dot product) is
		/// reset to the picked normal.
		///
		/// In both cases, the remaining normals are re-orthogonalized using the
		/// &lt;a href="https://en.wikipedia.org/wiki/Gram%E2%80%93Schmidt_process"&gt;
		/// Gram-Schmidt procedure&lt;/a&gt;.
		/// </summary>
		// Token: 0x06008AC0 RID: 35520 RVA: 0x000C631B File Offset: 0x000C451B
		public void SetNormalToCamera()
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_SetNormalToCamera_77(base.GetCppThis());
		}

		// Token: 0x06008AC1 RID: 35521
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_SetOrigin_78(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set/Get the origin of the coordinate frame.
		/// </summary>
		// Token: 0x06008AC2 RID: 35522 RVA: 0x000C632A File Offset: 0x000C452A
		public void SetOrigin(double x, double y, double z)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_SetOrigin_78(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06008AC3 RID: 35523
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_SetOrigin_79(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Set/Get the origin of the coordinate frame.
		/// </summary>
		// Token: 0x06008AC4 RID: 35524 RVA: 0x000C633C File Offset: 0x000C453C
		public void SetOrigin(IntPtr x)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_SetOrigin_79(base.GetCppThis(), x);
		}

		// Token: 0x06008AC5 RID: 35525
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_SetPickCameraFocalInfo_80(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable/Disable picking camera focal info if no result is available for PickOrigin, PickNormal
		/// and PickDirectionPoint. The default is disabled.
		/// </summary>
		// Token: 0x06008AC6 RID: 35526 RVA: 0x000C634C File Offset: 0x000C454C
		public virtual void SetPickCameraFocalInfo(bool _arg)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_SetPickCameraFocalInfo_80(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06008AC7 RID: 35527
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_SetRepresentationState_81(HandleRef pThis, int arg0);

		/// <summary>
		/// Sets the visual appearance of the representation based on the
		/// state it is in. This state is usually the same as InteractionState.
		/// </summary>
		// Token: 0x06008AC8 RID: 35528 RVA: 0x000C6364 File Offset: 0x000C4564
		public virtual void SetRepresentationState(int arg0)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_SetRepresentationState_81(base.GetCppThis(), arg0);
		}

		// Token: 0x06008AC9 RID: 35529
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_SetTranslationAxisOff_82(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x06008ACA RID: 35530 RVA: 0x000C6374 File Offset: 0x000C4574
		public void SetTranslationAxisOff()
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_SetTranslationAxisOff_82(base.GetCppThis());
		}

		// Token: 0x06008ACB RID: 35531
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_SetXAxisVector_83(HandleRef pThis, IntPtr v);

		/// <summary>
		/// Force an axis to be aligned with the vector \a v, regardless of whether any axis is locked.
		///
		/// This will normalize \a v and re-orthogonalize the remaining axes using the Gram-Schmidt
		/// procedure. Passing in a degenerate (zero-length) vector will be ignored.
		/// </summary>
		// Token: 0x06008ACC RID: 35532 RVA: 0x000C6383 File Offset: 0x000C4583
		public void SetXAxisVector(IntPtr v)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_SetXAxisVector_83(base.GetCppThis(), v);
		}

		// Token: 0x06008ACD RID: 35533
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_SetXAxisVector_84(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Force an axis to be aligned with the vector \a v, regardless of whether any axis is locked.
		///
		/// This will normalize \a v and re-orthogonalize the remaining axes using the Gram-Schmidt
		/// procedure. Passing in a degenerate (zero-length) vector will be ignored.
		/// </summary>
		// Token: 0x06008ACE RID: 35534 RVA: 0x000C6393 File Offset: 0x000C4593
		public void SetXAxisVector(double x, double y, double z)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_SetXAxisVector_84(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06008ACF RID: 35535
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_SetXTranslationAxisOn_85(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x06008AD0 RID: 35536 RVA: 0x000C63A5 File Offset: 0x000C45A5
		public void SetXTranslationAxisOn()
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_SetXTranslationAxisOn_85(base.GetCppThis());
		}

		// Token: 0x06008AD1 RID: 35537
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_SetYAxisVector_86(HandleRef pThis, IntPtr v);

		/// <summary>
		/// Force an axis to be aligned with the vector \a v, regardless of whether any axis is locked.
		///
		/// This will normalize \a v and re-orthogonalize the remaining axes using the Gram-Schmidt
		/// procedure. Passing in a degenerate (zero-length) vector will be ignored.
		/// </summary>
		// Token: 0x06008AD2 RID: 35538 RVA: 0x000C63B4 File Offset: 0x000C45B4
		public void SetYAxisVector(IntPtr v)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_SetYAxisVector_86(base.GetCppThis(), v);
		}

		// Token: 0x06008AD3 RID: 35539
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_SetYAxisVector_87(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Force an axis to be aligned with the vector \a v, regardless of whether any axis is locked.
		///
		/// This will normalize \a v and re-orthogonalize the remaining axes using the Gram-Schmidt
		/// procedure. Passing in a degenerate (zero-length) vector will be ignored.
		/// </summary>
		// Token: 0x06008AD4 RID: 35540 RVA: 0x000C63C4 File Offset: 0x000C45C4
		public void SetYAxisVector(double x, double y, double z)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_SetYAxisVector_87(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06008AD5 RID: 35541
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_SetYTranslationAxisOn_88(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x06008AD6 RID: 35542 RVA: 0x000C63D6 File Offset: 0x000C45D6
		public void SetYTranslationAxisOn()
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_SetYTranslationAxisOn_88(base.GetCppThis());
		}

		// Token: 0x06008AD7 RID: 35543
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_SetZAxisVector_89(HandleRef pThis, IntPtr v);

		/// <summary>
		/// Force an axis to be aligned with the vector \a v, regardless of whether any axis is locked.
		///
		/// This will normalize \a v and re-orthogonalize the remaining axes using the Gram-Schmidt
		/// procedure. Passing in a degenerate (zero-length) vector will be ignored.
		/// </summary>
		// Token: 0x06008AD8 RID: 35544 RVA: 0x000C63E5 File Offset: 0x000C45E5
		public void SetZAxisVector(IntPtr v)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_SetZAxisVector_89(base.GetCppThis(), v);
		}

		// Token: 0x06008AD9 RID: 35545
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_SetZAxisVector_90(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Force an axis to be aligned with the vector \a v, regardless of whether any axis is locked.
		///
		/// This will normalize \a v and re-orthogonalize the remaining axes using the Gram-Schmidt
		/// procedure. Passing in a degenerate (zero-length) vector will be ignored.
		/// </summary>
		// Token: 0x06008ADA RID: 35546 RVA: 0x000C63F5 File Offset: 0x000C45F5
		public void SetZAxisVector(double x, double y, double z)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_SetZAxisVector_90(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06008ADB RID: 35547
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_SetZTranslationAxisOn_91(HandleRef pThis);

		/// <summary>
		/// Toggles constraint translation axis on/off.
		/// </summary>
		// Token: 0x06008ADC RID: 35548 RVA: 0x000C6407 File Offset: 0x000C4607
		public void SetZTranslationAxisOn()
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_SetZTranslationAxisOn_91(base.GetCppThis());
		}

		// Token: 0x06008ADD RID: 35549
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_StartWidgetInteraction_92(HandleRef pThis, IntPtr eventPos);

		/// <summary>
		/// Methods to interface with the vtkCoordinateFrameWidget.
		/// </summary>
		// Token: 0x06008ADE RID: 35550 RVA: 0x000C6416 File Offset: 0x000C4616
		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_StartWidgetInteraction_92(base.GetCppThis(), eventPos);
		}

		// Token: 0x06008ADF RID: 35551
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_UpdatePlacement_93(HandleRef pThis);

		/// <summary>
		/// Satisfies the superclass API.  This will change the state of the widget
		/// to match changes that have been made to the underlying PolyDataSource
		/// </summary>
		// Token: 0x06008AE0 RID: 35552 RVA: 0x000C6426 File Offset: 0x000C4626
		public void UpdatePlacement()
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_UpdatePlacement_93(base.GetCppThis());
		}

		// Token: 0x06008AE1 RID: 35553
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCoordinateFrameRepresentation_WidgetInteraction_94(HandleRef pThis, IntPtr newEventPos);

		/// <summary>
		/// Methods to interface with the vtkCoordinateFrameWidget.
		/// </summary>
		// Token: 0x06008AE2 RID: 35554 RVA: 0x000C6435 File Offset: 0x000C4635
		public override void WidgetInteraction(IntPtr newEventPos)
		{
			vtkCoordinateFrameRepresentation.vtkCoordinateFrameRepresentation_WidgetInteraction_94(base.GetCppThis(), newEventPos);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BA7 RID: 2983
		public new const string MRFullTypeName = "Kitware.VTK.vtkCoordinateFrameRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BA8 RID: 2984
		public new static readonly string MRClassNameKey = "class vtkCoordinateFrameRepresentation";

		/// <summary>
		/// Methods supporting the rendering process.
		/// </summary>
		// Token: 0x02000306 RID: 774
		public enum InteractionStateType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000BAA RID: 2986
			ModifyingLockerXVector = 6,
			/// <summary>enum member</summary>
			// Token: 0x04000BAB RID: 2987
			ModifyingLockerYVector,
			/// <summary>enum member</summary>
			// Token: 0x04000BAC RID: 2988
			ModifyingLockerZVector,
			/// <summary>enum member</summary>
			// Token: 0x04000BAD RID: 2989
			Moving = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000BAE RID: 2990
			MovingOrigin,
			/// <summary>enum member</summary>
			// Token: 0x04000BAF RID: 2991
			Outside = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000BB0 RID: 2992
			RotatingXVector = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000BB1 RID: 2993
			RotatingYVector,
			/// <summary>enum member</summary>
			// Token: 0x04000BB2 RID: 2994
			RotatingZVector
		}
	}
}
