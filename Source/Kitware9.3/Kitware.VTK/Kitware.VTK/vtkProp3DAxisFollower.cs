using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProp3DAxisFollower
	/// </summary>
	/// <remarks>
	///    a subclass of vtkProp3DFollower that ensures
	/// that data is always parallel to the axis defined by a vtkAxisActor.
	///
	/// vtkProp3DAxisFollower is a subclass of vtkProp3DFollower that always follows
	/// its specified axis. More specifically it will not change its position or
	/// scale, but it will continually update its orientation so that it is aligned
	/// with the axis and facing at angle to the camera to provide maximum visibility.
	/// This is typically used for text labels for 3d plots.
	/// </remarks>
	/// <seealso>
	///
	/// vtkFollower vtkAxisFollower vtkProp3DFollower
	/// </seealso>
	// Token: 0x020003D7 RID: 983
	public class vtkProp3DAxisFollower : vtkProp3DFollower
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600B930 RID: 47408 RVA: 0x00103EEF File Offset: 0x001020EF
		static vtkProp3DAxisFollower()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProp3DAxisFollower.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProp3DAxisFollower"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600B931 RID: 47409 RVA: 0x00103F17 File Offset: 0x00102117
		public vtkProp3DAxisFollower(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600B932 RID: 47410
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3DAxisFollower_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a follower with no camera set.
		/// </summary>
		// Token: 0x0600B933 RID: 47411 RVA: 0x00103F28 File Offset: 0x00102128
		public new static vtkProp3DAxisFollower New()
		{
			vtkProp3DAxisFollower result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp3DAxisFollower.vtkProp3DAxisFollower_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProp3DAxisFollower)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a follower with no camera set.
		/// </summary>
		// Token: 0x0600B934 RID: 47412 RVA: 0x00103F7C File Offset: 0x0010217C
		public vtkProp3DAxisFollower() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkProp3DAxisFollower.vtkProp3DAxisFollower_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600B935 RID: 47413 RVA: 0x00103FC0 File Offset: 0x001021C0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600B936 RID: 47414
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DAxisFollower_AutoCenterOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get state of auto center mode where additional
		/// translation will be added to make sure the underlying
		/// geometry has its pivot point at the center of its bounds.
		/// </summary>
		// Token: 0x0600B937 RID: 47415 RVA: 0x00103FCB File Offset: 0x001021CB
		public virtual void AutoCenterOff()
		{
			vtkProp3DAxisFollower.vtkProp3DAxisFollower_AutoCenterOff_01(base.GetCppThis());
		}

		// Token: 0x0600B938 RID: 47416
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DAxisFollower_AutoCenterOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get state of auto center mode where additional
		/// translation will be added to make sure the underlying
		/// geometry has its pivot point at the center of its bounds.
		/// </summary>
		// Token: 0x0600B939 RID: 47417 RVA: 0x00103FDA File Offset: 0x001021DA
		public virtual void AutoCenterOn()
		{
			vtkProp3DAxisFollower.vtkProp3DAxisFollower_AutoCenterOn_02(base.GetCppThis());
		}

		// Token: 0x0600B93A RID: 47418
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProp3DAxisFollower_AutoScale_03(HandleRef viewport, HandleRef camera, double screenSize, IntPtr position);

		/// <summary>
		/// Calculate scale factor to maintain same size of a object
		/// on the screen.
		/// </summary>
		// Token: 0x0600B93B RID: 47419 RVA: 0x00103FEC File Offset: 0x001021EC
		public static double AutoScale(vtkViewport viewport, vtkCamera camera, double screenSize, IntPtr position)
		{
			return vtkProp3DAxisFollower.vtkProp3DAxisFollower_AutoScale_03((viewport == null) ? default(HandleRef) : viewport.GetCppThis(), (camera == null) ? default(HandleRef) : camera.GetCppThis(), screenSize, position);
		}

		// Token: 0x0600B93C RID: 47420
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DAxisFollower_ComputeMatrix_04(HandleRef pThis);

		/// <summary>
		/// Generate the matrix based on ivars. This method overloads its superclasses
		/// ComputeMatrix() method due to the special vtkProp3DAxisFollower matrix operations.
		/// </summary>
		// Token: 0x0600B93D RID: 47421 RVA: 0x00104031 File Offset: 0x00102231
		public override void ComputeMatrix()
		{
			vtkProp3DAxisFollower.vtkProp3DAxisFollower_ComputeMatrix_04(base.GetCppThis());
		}

		// Token: 0x0600B93E RID: 47422
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp3DAxisFollower_GetAutoCenter_05(HandleRef pThis);

		/// <summary>
		/// Set/Get state of auto center mode where additional
		/// translation will be added to make sure the underlying
		/// geometry has its pivot point at the center of its bounds.
		/// </summary>
		// Token: 0x0600B93F RID: 47423 RVA: 0x00104040 File Offset: 0x00102240
		public virtual int GetAutoCenter()
		{
			return vtkProp3DAxisFollower.vtkProp3DAxisFollower_GetAutoCenter_05(base.GetCppThis());
		}

		// Token: 0x0600B940 RID: 47424
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3DAxisFollower_GetAxis_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set axis that needs to be followed.
		/// </summary>
		// Token: 0x0600B941 RID: 47425 RVA: 0x00104060 File Offset: 0x00102260
		public virtual vtkAxisActor GetAxis()
		{
			vtkAxisActor vtkAxisActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp3DAxisFollower.vtkProp3DAxisFollower_GetAxis_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxisActor = (vtkAxisActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxisActor.Register(null);
				}
			}
			return vtkAxisActor;
		}

		// Token: 0x0600B942 RID: 47426
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProp3DAxisFollower_GetDistanceLODThreshold_07(HandleRef pThis);

		/// <summary>
		/// Set distance LOD threshold (0.0 - 1.0).This determines at what fraction
		/// of camera far clip range, actor is not visible.
		/// Default is 0.80.
		/// </summary>
		// Token: 0x0600B943 RID: 47427 RVA: 0x001040D0 File Offset: 0x001022D0
		public virtual double GetDistanceLODThreshold()
		{
			return vtkProp3DAxisFollower.vtkProp3DAxisFollower_GetDistanceLODThreshold_07(base.GetCppThis());
		}

		// Token: 0x0600B944 RID: 47428
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProp3DAxisFollower_GetDistanceLODThresholdMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Set distance LOD threshold (0.0 - 1.0).This determines at what fraction
		/// of camera far clip range, actor is not visible.
		/// Default is 0.80.
		/// </summary>
		// Token: 0x0600B945 RID: 47429 RVA: 0x001040F0 File Offset: 0x001022F0
		public virtual double GetDistanceLODThresholdMaxValue()
		{
			return vtkProp3DAxisFollower.vtkProp3DAxisFollower_GetDistanceLODThresholdMaxValue_08(base.GetCppThis());
		}

		// Token: 0x0600B946 RID: 47430
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProp3DAxisFollower_GetDistanceLODThresholdMinValue_09(HandleRef pThis);

		/// <summary>
		/// Set distance LOD threshold (0.0 - 1.0).This determines at what fraction
		/// of camera far clip range, actor is not visible.
		/// Default is 0.80.
		/// </summary>
		// Token: 0x0600B947 RID: 47431 RVA: 0x00104110 File Offset: 0x00102310
		public virtual double GetDistanceLODThresholdMinValue()
		{
			return vtkProp3DAxisFollower.vtkProp3DAxisFollower_GetDistanceLODThresholdMinValue_09(base.GetCppThis());
		}

		// Token: 0x0600B948 RID: 47432
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp3DAxisFollower_GetEnableDistanceLOD_10(HandleRef pThis);

		/// <summary>
		/// Enable / disable use of distance based LOD. If enabled the actor
		/// will not be visible at a certain distance from the camera.
		/// Default is false.
		/// </summary>
		// Token: 0x0600B949 RID: 47433 RVA: 0x00104130 File Offset: 0x00102330
		public virtual int GetEnableDistanceLOD()
		{
			return vtkProp3DAxisFollower.vtkProp3DAxisFollower_GetEnableDistanceLOD_10(base.GetCppThis());
		}

		// Token: 0x0600B94A RID: 47434
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp3DAxisFollower_GetEnableViewAngleLOD_11(HandleRef pThis);

		/// <summary>
		/// Enable / disable use of view angle based LOD. If enabled the actor
		/// will not be visible at a certain view angle.
		/// Default is true.
		/// </summary>
		// Token: 0x0600B94B RID: 47435 RVA: 0x00104150 File Offset: 0x00102350
		public virtual int GetEnableViewAngleLOD()
		{
			return vtkProp3DAxisFollower.vtkProp3DAxisFollower_GetEnableViewAngleLOD_11(base.GetCppThis());
		}

		// Token: 0x0600B94C RID: 47436
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProp3DAxisFollower_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods for type and printing.
		/// </summary>
		// Token: 0x0600B94D RID: 47437 RVA: 0x00104170 File Offset: 0x00102370
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProp3DAxisFollower.vtkProp3DAxisFollower_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x0600B94E RID: 47438
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProp3DAxisFollower_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods for type and printing.
		/// </summary>
		// Token: 0x0600B94F RID: 47439 RVA: 0x00104190 File Offset: 0x00102390
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProp3DAxisFollower.vtkProp3DAxisFollower_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x0600B950 RID: 47440
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProp3DAxisFollower_GetScreenOffset_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the desired screen vertical offset from the axis.
		/// Convenience method, using a zero horizontal offset
		/// </summary>
		// Token: 0x0600B951 RID: 47441 RVA: 0x001041AC File Offset: 0x001023AC
		public double GetScreenOffset()
		{
			return vtkProp3DAxisFollower.vtkProp3DAxisFollower_GetScreenOffset_14(base.GetCppThis());
		}

		// Token: 0x0600B952 RID: 47442
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3DAxisFollower_GetScreenOffsetVector_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the desired screen offset from the axis.
		/// </summary>
		// Token: 0x0600B953 RID: 47443 RVA: 0x001041CC File Offset: 0x001023CC
		public virtual double[] GetScreenOffsetVector()
		{
			IntPtr intPtr = vtkProp3DAxisFollower.vtkProp3DAxisFollower_GetScreenOffsetVector_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600B954 RID: 47444
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DAxisFollower_GetScreenOffsetVector_16(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Set/Get the desired screen offset from the axis.
		/// </summary>
		// Token: 0x0600B955 RID: 47445 RVA: 0x00104214 File Offset: 0x00102414
		public virtual void GetScreenOffsetVector(ref double _arg1, ref double _arg2)
		{
			vtkProp3DAxisFollower.vtkProp3DAxisFollower_GetScreenOffsetVector_16(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600B956 RID: 47446
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DAxisFollower_GetScreenOffsetVector_17(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the desired screen offset from the axis.
		/// </summary>
		// Token: 0x0600B957 RID: 47447 RVA: 0x00104225 File Offset: 0x00102425
		public virtual void GetScreenOffsetVector(IntPtr _arg)
		{
			vtkProp3DAxisFollower.vtkProp3DAxisFollower_GetScreenOffsetVector_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B958 RID: 47448
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProp3DAxisFollower_GetViewAngleLODThreshold_18(HandleRef pThis);

		/// <summary>
		/// Set view angle LOD threshold (0.0 - 1.0).This determines at what view
		/// angle to geometry will make the geometry not visible.
		/// Default is 0.34.
		/// </summary>
		// Token: 0x0600B959 RID: 47449 RVA: 0x00104238 File Offset: 0x00102438
		public virtual double GetViewAngleLODThreshold()
		{
			return vtkProp3DAxisFollower.vtkProp3DAxisFollower_GetViewAngleLODThreshold_18(base.GetCppThis());
		}

		// Token: 0x0600B95A RID: 47450
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProp3DAxisFollower_GetViewAngleLODThresholdMaxValue_19(HandleRef pThis);

		/// <summary>
		/// Set view angle LOD threshold (0.0 - 1.0).This determines at what view
		/// angle to geometry will make the geometry not visible.
		/// Default is 0.34.
		/// </summary>
		// Token: 0x0600B95B RID: 47451 RVA: 0x00104258 File Offset: 0x00102458
		public virtual double GetViewAngleLODThresholdMaxValue()
		{
			return vtkProp3DAxisFollower.vtkProp3DAxisFollower_GetViewAngleLODThresholdMaxValue_19(base.GetCppThis());
		}

		// Token: 0x0600B95C RID: 47452
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProp3DAxisFollower_GetViewAngleLODThresholdMinValue_20(HandleRef pThis);

		/// <summary>
		/// Set view angle LOD threshold (0.0 - 1.0).This determines at what view
		/// angle to geometry will make the geometry not visible.
		/// Default is 0.34.
		/// </summary>
		// Token: 0x0600B95D RID: 47453 RVA: 0x00104278 File Offset: 0x00102478
		public virtual double GetViewAngleLODThresholdMinValue()
		{
			return vtkProp3DAxisFollower.vtkProp3DAxisFollower_GetViewAngleLODThresholdMinValue_20(base.GetCppThis());
		}

		// Token: 0x0600B95E RID: 47454
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3DAxisFollower_GetViewport_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This causes the actor to be rendered. It in turn will render the actor's
		/// property, texture map and then mapper. If a property hasn't been
		/// assigned, then the actor will create one automatically.
		/// </summary>
		// Token: 0x0600B95F RID: 47455 RVA: 0x00104298 File Offset: 0x00102498
		public virtual vtkViewport GetViewport()
		{
			vtkViewport vtkViewport = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp3DAxisFollower.vtkProp3DAxisFollower_GetViewport_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkViewport = (vtkViewport)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkViewport.Register(null);
				}
			}
			return vtkViewport;
		}

		// Token: 0x0600B960 RID: 47456
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp3DAxisFollower_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods for type and printing.
		/// </summary>
		// Token: 0x0600B961 RID: 47457 RVA: 0x00104308 File Offset: 0x00102508
		public override int IsA(string type)
		{
			return vtkProp3DAxisFollower.vtkProp3DAxisFollower_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x0600B962 RID: 47458
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp3DAxisFollower_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods for type and printing.
		/// </summary>
		// Token: 0x0600B963 RID: 47459 RVA: 0x00104328 File Offset: 0x00102528
		public new static int IsTypeOf(string type)
		{
			return vtkProp3DAxisFollower.vtkProp3DAxisFollower_IsTypeOf_23(type);
		}

		// Token: 0x0600B964 RID: 47460
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3DAxisFollower_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods for type and printing.
		/// </summary>
		// Token: 0x0600B965 RID: 47461 RVA: 0x00104344 File Offset: 0x00102544
		public new vtkProp3DAxisFollower NewInstance()
		{
			vtkProp3DAxisFollower result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp3DAxisFollower.vtkProp3DAxisFollower_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProp3DAxisFollower)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600B966 RID: 47462
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp3DAxisFollower_RenderOpaqueGeometry_26(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// This causes the actor to be rendered. It in turn will render the actor's
		/// property, texture map and then mapper. If a property hasn't been
		/// assigned, then the actor will create one automatically.
		/// </summary>
		// Token: 0x0600B967 RID: 47463 RVA: 0x001043A0 File Offset: 0x001025A0
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkProp3DAxisFollower.vtkProp3DAxisFollower_RenderOpaqueGeometry_26(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600B968 RID: 47464
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp3DAxisFollower_RenderTranslucentPolygonalGeometry_27(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// This causes the actor to be rendered. It in turn will render the actor's
		/// property, texture map and then mapper. If a property hasn't been
		/// assigned, then the actor will create one automatically.
		/// </summary>
		// Token: 0x0600B969 RID: 47465 RVA: 0x001043D4 File Offset: 0x001025D4
		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkProp3DAxisFollower.vtkProp3DAxisFollower_RenderTranslucentPolygonalGeometry_27(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600B96A RID: 47466
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProp3DAxisFollower_RenderVolumetricGeometry_28(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// This causes the actor to be rendered. It in turn will render the actor's
		/// property, texture map and then mapper. If a property hasn't been
		/// assigned, then the actor will create one automatically.
		/// </summary>
		// Token: 0x0600B96B RID: 47467 RVA: 0x00104408 File Offset: 0x00102608
		public override int RenderVolumetricGeometry(vtkViewport viewport)
		{
			return vtkProp3DAxisFollower.vtkProp3DAxisFollower_RenderVolumetricGeometry_28(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600B96C RID: 47468
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProp3DAxisFollower_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods for type and printing.
		/// </summary>
		// Token: 0x0600B96D RID: 47469 RVA: 0x0010443C File Offset: 0x0010263C
		public new static vtkProp3DAxisFollower SafeDownCast(vtkObjectBase o)
		{
			vtkProp3DAxisFollower vtkProp3DAxisFollower = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProp3DAxisFollower.vtkProp3DAxisFollower_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp3DAxisFollower = (vtkProp3DAxisFollower)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp3DAxisFollower.Register(null);
				}
			}
			return vtkProp3DAxisFollower;
		}

		// Token: 0x0600B96E RID: 47470
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DAxisFollower_SetAutoCenter_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get state of auto center mode where additional
		/// translation will be added to make sure the underlying
		/// geometry has its pivot point at the center of its bounds.
		/// </summary>
		// Token: 0x0600B96F RID: 47471 RVA: 0x001044BB File Offset: 0x001026BB
		public virtual void SetAutoCenter(int _arg)
		{
			vtkProp3DAxisFollower.vtkProp3DAxisFollower_SetAutoCenter_30(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B970 RID: 47472
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DAxisFollower_SetAxis_31(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set axis that needs to be followed.
		/// </summary>
		// Token: 0x0600B971 RID: 47473 RVA: 0x001044CC File Offset: 0x001026CC
		public virtual void SetAxis(vtkAxisActor arg0)
		{
			vtkProp3DAxisFollower.vtkProp3DAxisFollower_SetAxis_31(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B972 RID: 47474
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DAxisFollower_SetDistanceLODThreshold_32(HandleRef pThis, double _arg);

		/// <summary>
		/// Set distance LOD threshold (0.0 - 1.0).This determines at what fraction
		/// of camera far clip range, actor is not visible.
		/// Default is 0.80.
		/// </summary>
		// Token: 0x0600B973 RID: 47475 RVA: 0x001044FB File Offset: 0x001026FB
		public virtual void SetDistanceLODThreshold(double _arg)
		{
			vtkProp3DAxisFollower.vtkProp3DAxisFollower_SetDistanceLODThreshold_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B974 RID: 47476
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DAxisFollower_SetEnableDistanceLOD_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable / disable use of distance based LOD. If enabled the actor
		/// will not be visible at a certain distance from the camera.
		/// Default is false.
		/// </summary>
		// Token: 0x0600B975 RID: 47477 RVA: 0x0010450B File Offset: 0x0010270B
		public virtual void SetEnableDistanceLOD(int _arg)
		{
			vtkProp3DAxisFollower.vtkProp3DAxisFollower_SetEnableDistanceLOD_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B976 RID: 47478
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DAxisFollower_SetEnableViewAngleLOD_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable / disable use of view angle based LOD. If enabled the actor
		/// will not be visible at a certain view angle.
		/// Default is true.
		/// </summary>
		// Token: 0x0600B977 RID: 47479 RVA: 0x0010451B File Offset: 0x0010271B
		public virtual void SetEnableViewAngleLOD(int _arg)
		{
			vtkProp3DAxisFollower.vtkProp3DAxisFollower_SetEnableViewAngleLOD_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B978 RID: 47480
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DAxisFollower_SetScreenOffset_35(HandleRef pThis, double offset);

		/// <summary>
		/// Set/Get the desired screen vertical offset from the axis.
		/// Convenience method, using a zero horizontal offset
		/// </summary>
		// Token: 0x0600B979 RID: 47481 RVA: 0x0010452B File Offset: 0x0010272B
		public void SetScreenOffset(double offset)
		{
			vtkProp3DAxisFollower.vtkProp3DAxisFollower_SetScreenOffset_35(base.GetCppThis(), offset);
		}

		// Token: 0x0600B97A RID: 47482
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DAxisFollower_SetScreenOffsetVector_36(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Set/Get the desired screen offset from the axis.
		/// </summary>
		// Token: 0x0600B97B RID: 47483 RVA: 0x0010453B File Offset: 0x0010273B
		public virtual void SetScreenOffsetVector(double _arg1, double _arg2)
		{
			vtkProp3DAxisFollower.vtkProp3DAxisFollower_SetScreenOffsetVector_36(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600B97C RID: 47484
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DAxisFollower_SetScreenOffsetVector_37(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the desired screen offset from the axis.
		/// </summary>
		// Token: 0x0600B97D RID: 47485 RVA: 0x0010454C File Offset: 0x0010274C
		public void SetScreenOffsetVector(IntPtr _arg)
		{
			vtkProp3DAxisFollower.vtkProp3DAxisFollower_SetScreenOffsetVector_37(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B97E RID: 47486
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DAxisFollower_SetViewAngleLODThreshold_38(HandleRef pThis, double _arg);

		/// <summary>
		/// Set view angle LOD threshold (0.0 - 1.0).This determines at what view
		/// angle to geometry will make the geometry not visible.
		/// Default is 0.34.
		/// </summary>
		// Token: 0x0600B97F RID: 47487 RVA: 0x0010455C File Offset: 0x0010275C
		public virtual void SetViewAngleLODThreshold(double _arg)
		{
			vtkProp3DAxisFollower.vtkProp3DAxisFollower_SetViewAngleLODThreshold_38(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B980 RID: 47488
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DAxisFollower_SetViewport_39(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// This causes the actor to be rendered. It in turn will render the actor's
		/// property, texture map and then mapper. If a property hasn't been
		/// assigned, then the actor will create one automatically.
		/// </summary>
		// Token: 0x0600B981 RID: 47489 RVA: 0x0010456C File Offset: 0x0010276C
		public virtual void SetViewport(vtkViewport viewport)
		{
			vtkProp3DAxisFollower.vtkProp3DAxisFollower_SetViewport_39(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600B982 RID: 47490
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProp3DAxisFollower_ShallowCopy_40(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Shallow copy of a follower. Overloads the virtual vtkProp method.
		/// </summary>
		// Token: 0x0600B983 RID: 47491 RVA: 0x0010459C File Offset: 0x0010279C
		public override void ShallowCopy(vtkProp prop)
		{
			vtkProp3DAxisFollower.vtkProp3DAxisFollower_ShallowCopy_40(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E0C RID: 3596
		public new const string MRFullTypeName = "Kitware.VTK.vtkProp3DAxisFollower";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E0D RID: 3597
		public new static readonly string MRClassNameKey = "class vtkProp3DAxisFollower";
	}
}
