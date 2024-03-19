using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCameraRepresentation
	/// </summary>
	/// <remarks>
	///    represent the vtkCameraWidget
	///
	/// This class provides support for interactively saving a series of camera
	/// views into an interpolated path (using vtkCameraInterpolator). The class
	/// typically works in conjunction with vtkCameraWidget. To use this class
	/// simply specify the camera to interpolate and use the methods
	/// AddCameraToPath(), AnimatePath(), and InitializePath() to add a new camera
	/// view, animate the current views, and initialize the interpolation.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCameraWidget vtkCameraInterpolator
	/// </seealso>
	// Token: 0x020002EA RID: 746
	public class vtkCameraRepresentation : vtkBorderRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600860D RID: 34317 RVA: 0x000BF4AF File Offset: 0x000BD6AF
		static vtkCameraRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCameraRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCameraRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600860E RID: 34318 RVA: 0x000BF4D7 File Offset: 0x000BD6D7
		public vtkCameraRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600860F RID: 34319
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06008610 RID: 34320 RVA: 0x000BF4E8 File Offset: 0x000BD6E8
		public new static vtkCameraRepresentation New()
		{
			vtkCameraRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraRepresentation.vtkCameraRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCameraRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x06008611 RID: 34321 RVA: 0x000BF53C File Offset: 0x000BD73C
		public vtkCameraRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCameraRepresentation.vtkCameraRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008612 RID: 34322 RVA: 0x000BF580 File Offset: 0x000BD780
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008613 RID: 34323
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraRepresentation_AddCameraToPath_01(HandleRef pThis);

		/// <summary>
		/// These methods are used to create interpolated camera paths.  The
		/// AddCameraToPath() method adds the view defined by the current camera
		/// (via SetCamera()) to the interpolated camera path. AnimatePath()
		/// interpolates NumberOfFrames along the current path. InitializePath()
		/// resets the interpolated path to its initial, empty configuration.
		/// </summary>
		// Token: 0x06008614 RID: 34324 RVA: 0x000BF58B File Offset: 0x000BD78B
		public void AddCameraToPath()
		{
			vtkCameraRepresentation.vtkCameraRepresentation_AddCameraToPath_01(base.GetCppThis());
		}

		// Token: 0x06008615 RID: 34325
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraRepresentation_AnimatePath_02(HandleRef pThis, HandleRef rwi);

		/// <summary>
		/// These methods are used to create interpolated camera paths.  The
		/// AddCameraToPath() method adds the view defined by the current camera
		/// (via SetCamera()) to the interpolated camera path. AnimatePath()
		/// interpolates NumberOfFrames along the current path. InitializePath()
		/// resets the interpolated path to its initial, empty configuration.
		/// </summary>
		// Token: 0x06008616 RID: 34326 RVA: 0x000BF59C File Offset: 0x000BD79C
		public void AnimatePath(vtkRenderWindowInteractor rwi)
		{
			vtkCameraRepresentation.vtkCameraRepresentation_AnimatePath_02(base.GetCppThis(), (rwi == null) ? default(HandleRef) : rwi.GetCppThis());
		}

		// Token: 0x06008617 RID: 34327
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraRepresentation_BuildRepresentation_03(HandleRef pThis);

		/// <summary>
		/// Satisfy the superclasses' API.
		/// </summary>
		// Token: 0x06008618 RID: 34328 RVA: 0x000BF5CB File Offset: 0x000BD7CB
		public override void BuildRepresentation()
		{
			vtkCameraRepresentation.vtkCameraRepresentation_BuildRepresentation_03(base.GetCppThis());
		}

		// Token: 0x06008619 RID: 34329
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraRepresentation_GetActors2D_04(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x0600861A RID: 34330 RVA: 0x000BF5DC File Offset: 0x000BD7DC
		public override void GetActors2D(vtkPropCollection arg0)
		{
			vtkCameraRepresentation.vtkCameraRepresentation_GetActors2D_04(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600861B RID: 34331
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraRepresentation_GetCamera_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the camera to interpolate. This must be specified by
		/// the user.
		/// </summary>
		// Token: 0x0600861C RID: 34332 RVA: 0x000BF60C File Offset: 0x000BD80C
		public virtual vtkCamera GetCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraRepresentation.vtkCameraRepresentation_GetCamera_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCamera = (vtkCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCamera.Register(null);
				}
			}
			return vtkCamera;
		}

		// Token: 0x0600861D RID: 34333
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraRepresentation_GetInterpolator_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the vtkCameraInterpolator used to interpolate and save the
		/// sequence of camera views. If not defined, one is created
		/// automatically. Note that you can access this object to set
		/// the interpolation type (linear, spline) and other instance
		/// variables.
		/// </summary>
		// Token: 0x0600861E RID: 34334 RVA: 0x000BF67C File Offset: 0x000BD87C
		public virtual vtkCameraInterpolator GetInterpolator()
		{
			vtkCameraInterpolator vtkCameraInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraRepresentation.vtkCameraRepresentation_GetInterpolator_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCameraInterpolator = (vtkCameraInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCameraInterpolator.Register(null);
				}
			}
			return vtkCameraInterpolator;
		}

		// Token: 0x0600861F RID: 34335
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraRepresentation_GetNumberOfFrames_07(HandleRef pThis);

		/// <summary>
		/// Set the number of frames to generate when playback is initiated.
		/// </summary>
		// Token: 0x06008620 RID: 34336 RVA: 0x000BF6EC File Offset: 0x000BD8EC
		public virtual int GetNumberOfFrames()
		{
			return vtkCameraRepresentation.vtkCameraRepresentation_GetNumberOfFrames_07(base.GetCppThis());
		}

		// Token: 0x06008621 RID: 34337
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraRepresentation_GetNumberOfFramesMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Set the number of frames to generate when playback is initiated.
		/// </summary>
		// Token: 0x06008622 RID: 34338 RVA: 0x000BF70C File Offset: 0x000BD90C
		public virtual int GetNumberOfFramesMaxValue()
		{
			return vtkCameraRepresentation.vtkCameraRepresentation_GetNumberOfFramesMaxValue_08(base.GetCppThis());
		}

		// Token: 0x06008623 RID: 34339
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraRepresentation_GetNumberOfFramesMinValue_09(HandleRef pThis);

		/// <summary>
		/// Set the number of frames to generate when playback is initiated.
		/// </summary>
		// Token: 0x06008624 RID: 34340 RVA: 0x000BF72C File Offset: 0x000BD92C
		public virtual int GetNumberOfFramesMinValue()
		{
			return vtkCameraRepresentation.vtkCameraRepresentation_GetNumberOfFramesMinValue_09(base.GetCppThis());
		}

		// Token: 0x06008625 RID: 34341
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCameraRepresentation_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06008626 RID: 34342 RVA: 0x000BF74C File Offset: 0x000BD94C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCameraRepresentation.vtkCameraRepresentation_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x06008627 RID: 34343
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCameraRepresentation_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06008628 RID: 34344 RVA: 0x000BF76C File Offset: 0x000BD96C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCameraRepresentation.vtkCameraRepresentation_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x06008629 RID: 34345
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraRepresentation_GetProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// By obtaining this property you can specify the properties of the
		/// representation.
		/// </summary>
		// Token: 0x0600862A RID: 34346 RVA: 0x000BF788 File Offset: 0x000BD988
		public virtual vtkProperty2D GetProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraRepresentation.vtkCameraRepresentation_GetProperty_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty2D = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty2D.Register(null);
				}
			}
			return vtkProperty2D;
		}

		// Token: 0x0600862B RID: 34347
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraRepresentation_GetSize_13(HandleRef pThis, IntPtr size);

		/// <summary>
		/// Satisfy the superclasses' API.
		/// </summary>
		// Token: 0x0600862C RID: 34348 RVA: 0x000BF7F7 File Offset: 0x000BD9F7
		public override void GetSize(IntPtr size)
		{
			vtkCameraRepresentation.vtkCameraRepresentation_GetSize_13(base.GetCppThis(), size);
		}

		// Token: 0x0600862D RID: 34349
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraRepresentation_HasTranslucentPolygonalGeometry_14(HandleRef pThis);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x0600862E RID: 34350 RVA: 0x000BF808 File Offset: 0x000BDA08
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkCameraRepresentation.vtkCameraRepresentation_HasTranslucentPolygonalGeometry_14(base.GetCppThis());
		}

		// Token: 0x0600862F RID: 34351
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraRepresentation_InitializePath_15(HandleRef pThis);

		/// <summary>
		/// These methods are used to create interpolated camera paths.  The
		/// AddCameraToPath() method adds the view defined by the current camera
		/// (via SetCamera()) to the interpolated camera path. AnimatePath()
		/// interpolates NumberOfFrames along the current path. InitializePath()
		/// resets the interpolated path to its initial, empty configuration.
		/// </summary>
		// Token: 0x06008630 RID: 34352 RVA: 0x000BF827 File Offset: 0x000BDA27
		public void InitializePath()
		{
			vtkCameraRepresentation.vtkCameraRepresentation_InitializePath_15(base.GetCppThis());
		}

		// Token: 0x06008631 RID: 34353
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraRepresentation_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06008632 RID: 34354 RVA: 0x000BF838 File Offset: 0x000BDA38
		public override int IsA(string type)
		{
			return vtkCameraRepresentation.vtkCameraRepresentation_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x06008633 RID: 34355
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraRepresentation_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06008634 RID: 34356 RVA: 0x000BF858 File Offset: 0x000BDA58
		public new static int IsTypeOf(string type)
		{
			return vtkCameraRepresentation.vtkCameraRepresentation_IsTypeOf_17(type);
		}

		// Token: 0x06008635 RID: 34357
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraRepresentation_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06008636 RID: 34358 RVA: 0x000BF874 File Offset: 0x000BDA74
		public new vtkCameraRepresentation NewInstance()
		{
			vtkCameraRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraRepresentation.vtkCameraRepresentation_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCameraRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008637 RID: 34359
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraRepresentation_ReleaseGraphicsResources_20(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x06008638 RID: 34360 RVA: 0x000BF8D0 File Offset: 0x000BDAD0
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkCameraRepresentation.vtkCameraRepresentation_ReleaseGraphicsResources_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008639 RID: 34361
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraRepresentation_RenderOpaqueGeometry_21(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x0600863A RID: 34362 RVA: 0x000BF900 File Offset: 0x000BDB00
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkCameraRepresentation.vtkCameraRepresentation_RenderOpaqueGeometry_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600863B RID: 34363
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraRepresentation_RenderOverlay_22(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x0600863C RID: 34364 RVA: 0x000BF934 File Offset: 0x000BDB34
		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkCameraRepresentation.vtkCameraRepresentation_RenderOverlay_22(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600863D RID: 34365
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraRepresentation_RenderTranslucentPolygonalGeometry_23(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// These methods are necessary to make this representation behave as
		/// a vtkProp.
		/// </summary>
		// Token: 0x0600863E RID: 34366 RVA: 0x000BF968 File Offset: 0x000BDB68
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkCameraRepresentation.vtkCameraRepresentation_RenderTranslucentPolygonalGeometry_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600863F RID: 34367
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraRepresentation_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06008640 RID: 34368 RVA: 0x000BF99C File Offset: 0x000BDB9C
		public new static vtkCameraRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkCameraRepresentation vtkCameraRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraRepresentation.vtkCameraRepresentation_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCameraRepresentation = (vtkCameraRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCameraRepresentation.Register(null);
				}
			}
			return vtkCameraRepresentation;
		}

		// Token: 0x06008641 RID: 34369
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraRepresentation_SetCamera_25(HandleRef pThis, HandleRef camera);

		/// <summary>
		/// Specify the camera to interpolate. This must be specified by
		/// the user.
		/// </summary>
		// Token: 0x06008642 RID: 34370 RVA: 0x000BFA1C File Offset: 0x000BDC1C
		public void SetCamera(vtkCamera camera)
		{
			vtkCameraRepresentation.vtkCameraRepresentation_SetCamera_25(base.GetCppThis(), (camera == null) ? default(HandleRef) : camera.GetCppThis());
		}

		// Token: 0x06008643 RID: 34371
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraRepresentation_SetInterpolator_26(HandleRef pThis, HandleRef camInt);

		/// <summary>
		/// Get the vtkCameraInterpolator used to interpolate and save the
		/// sequence of camera views. If not defined, one is created
		/// automatically. Note that you can access this object to set
		/// the interpolation type (linear, spline) and other instance
		/// variables.
		/// </summary>
		// Token: 0x06008644 RID: 34372 RVA: 0x000BFA4C File Offset: 0x000BDC4C
		public void SetInterpolator(vtkCameraInterpolator camInt)
		{
			vtkCameraRepresentation.vtkCameraRepresentation_SetInterpolator_26(base.GetCppThis(), (camInt == null) ? default(HandleRef) : camInt.GetCppThis());
		}

		// Token: 0x06008645 RID: 34373
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraRepresentation_SetNumberOfFrames_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the number of frames to generate when playback is initiated.
		/// </summary>
		// Token: 0x06008646 RID: 34374 RVA: 0x000BFA7B File Offset: 0x000BDC7B
		public virtual void SetNumberOfFrames(int _arg)
		{
			vtkCameraRepresentation.vtkCameraRepresentation_SetNumberOfFrames_27(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B55 RID: 2901
		public new const string MRFullTypeName = "Kitware.VTK.vtkCameraRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B56 RID: 2902
		public new static readonly string MRClassNameKey = "class vtkCameraRepresentation";
	}
}
