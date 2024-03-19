using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRenderer
	/// </summary>
	/// <remarks>
	///    abstract specification for renderers
	///
	/// vtkRenderer provides an abstract specification for renderers. A renderer
	/// is an object that controls the rendering process for objects. Rendering
	/// is the process of converting geometry, a specification for lights, and
	/// a camera view into an image. vtkRenderer also performs coordinate
	/// transformation between world coordinates, view coordinates (the computer
	/// graphics rendering coordinate system), and display coordinates (the
	/// actual screen coordinates on the display device). Certain advanced
	/// rendering features such as two-sided lighting can also be controlled.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderWindow vtkActor vtkCamera vtkLight vtkVolume
	/// </seealso>
	// Token: 0x020000AC RID: 172
	public class vtkRenderer : vtkViewport
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060024EB RID: 9451 RVA: 0x00036FDD File Offset: 0x000351DD
		static vtkRenderer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRenderer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060024EC RID: 9452 RVA: 0x00037005 File Offset: 0x00035205
		public vtkRenderer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060024ED RID: 9453
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a vtkRenderer with a black background, a white ambient light,
		/// two-sided lighting turned on, a viewport of (0,0,1,1), and backface
		/// culling turned off.
		/// </summary>
		// Token: 0x060024EE RID: 9454 RVA: 0x00037014 File Offset: 0x00035214
		public new static vtkRenderer New()
		{
			vtkRenderer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderer.vtkRenderer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create a vtkRenderer with a black background, a white ambient light,
		/// two-sided lighting turned on, a viewport of (0,0,1,1), and backface
		/// culling turned off.
		/// </summary>
		// Token: 0x060024EF RID: 9455 RVA: 0x00037068 File Offset: 0x00035268
		public vtkRenderer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRenderer.vtkRenderer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060024F0 RID: 9456 RVA: 0x000370AC File Offset: 0x000352AC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060024F1 RID: 9457
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_AddActor_01(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Add/Remove different types of props to the renderer.
		/// These methods are all synonyms to AddViewProp and RemoveViewProp.
		/// They are here for convenience and backwards compatibility.
		/// </summary>
		// Token: 0x060024F2 RID: 9458 RVA: 0x000370B8 File Offset: 0x000352B8
		public void AddActor(vtkProp p)
		{
			vtkRenderer.vtkRenderer_AddActor_01(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x060024F3 RID: 9459
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_AddCuller_02(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Add an culler to the list of cullers.
		/// </summary>
		// Token: 0x060024F4 RID: 9460 RVA: 0x000370E8 File Offset: 0x000352E8
		public void AddCuller(vtkCuller arg0)
		{
			vtkRenderer.vtkRenderer_AddCuller_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060024F5 RID: 9461
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_AddLight_03(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Add a light to the list of lights.
		/// </summary>
		// Token: 0x060024F6 RID: 9462 RVA: 0x00037118 File Offset: 0x00035318
		public void AddLight(vtkLight arg0)
		{
			vtkRenderer.vtkRenderer_AddLight_03(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060024F7 RID: 9463
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_AddVolume_04(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Add/Remove different types of props to the renderer.
		/// These methods are all synonyms to AddViewProp and RemoveViewProp.
		/// They are here for convenience and backwards compatibility.
		/// </summary>
		// Token: 0x060024F8 RID: 9464 RVA: 0x00037148 File Offset: 0x00035348
		public void AddVolume(vtkProp p)
		{
			vtkRenderer.vtkRenderer_AddVolume_04(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x060024F9 RID: 9465
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_AutomaticLightCreationOff_05(HandleRef pThis);

		/// <summary>
		/// Turn on/off a flag which disables the automatic light creation capability.
		/// Normally in VTK if no lights are associated with the renderer, then a light
		/// is automatically created. However, in special circumstances this feature is
		/// undesirable, so the following boolean is provided to disable automatic
		/// light creation. (Turn AutomaticLightCreation off if you do not want lights
		/// to be created.)
		/// </summary>
		// Token: 0x060024FA RID: 9466 RVA: 0x00037177 File Offset: 0x00035377
		public virtual void AutomaticLightCreationOff()
		{
			vtkRenderer.vtkRenderer_AutomaticLightCreationOff_05(base.GetCppThis());
		}

		// Token: 0x060024FB RID: 9467
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_AutomaticLightCreationOn_06(HandleRef pThis);

		/// <summary>
		/// Turn on/off a flag which disables the automatic light creation capability.
		/// Normally in VTK if no lights are associated with the renderer, then a light
		/// is automatically created. However, in special circumstances this feature is
		/// undesirable, so the following boolean is provided to disable automatic
		/// light creation. (Turn AutomaticLightCreation off if you do not want lights
		/// to be created.)
		/// </summary>
		// Token: 0x060024FC RID: 9468 RVA: 0x00037186 File Offset: 0x00035386
		public virtual void AutomaticLightCreationOn()
		{
			vtkRenderer.vtkRenderer_AutomaticLightCreationOn_06(base.GetCppThis());
		}

		// Token: 0x060024FD RID: 9469
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_BackingStoreOff_07(HandleRef pThis);

		/// <summary>
		/// Turn on/off using backing store. This may cause the re-rendering
		/// time to be slightly slower when the view changes. But it is
		/// much faster when the image has not changed, such as during an
		/// expose event.
		/// </summary>
		// Token: 0x060024FE RID: 9470 RVA: 0x00037195 File Offset: 0x00035395
		public virtual void BackingStoreOff()
		{
			vtkRenderer.vtkRenderer_BackingStoreOff_07(base.GetCppThis());
		}

		// Token: 0x060024FF RID: 9471
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_BackingStoreOn_08(HandleRef pThis);

		/// <summary>
		/// Turn on/off using backing store. This may cause the re-rendering
		/// time to be slightly slower when the view changes. But it is
		/// much faster when the image has not changed, such as during an
		/// expose event.
		/// </summary>
		// Token: 0x06002500 RID: 9472 RVA: 0x000371A4 File Offset: 0x000353A4
		public virtual void BackingStoreOn()
		{
			vtkRenderer.vtkRenderer_BackingStoreOn_08(base.GetCppThis());
		}

		// Token: 0x06002501 RID: 9473
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderer_CaptureGL2PSSpecialProp_09(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// This function is called to capture an instance of vtkProp that requires
		/// special handling during vtkRenderWindow::CaptureGL2PSSpecialProps().
		/// </summary>
		// Token: 0x06002502 RID: 9474 RVA: 0x000371B4 File Offset: 0x000353B4
		public int CaptureGL2PSSpecialProp(vtkProp arg0)
		{
			return vtkRenderer.vtkRenderer_CaptureGL2PSSpecialProp_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002503 RID: 9475
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_Clear_10(HandleRef pThis);

		/// <summary>
		/// Clear the image to the background color.
		/// </summary>
		// Token: 0x06002504 RID: 9476 RVA: 0x000371E8 File Offset: 0x000353E8
		public virtual void Clear()
		{
			vtkRenderer.vtkRenderer_Clear_10(base.GetCppThis());
		}

		// Token: 0x06002505 RID: 9477
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_ClearLights_11(HandleRef pThis);

		/// <summary>
		/// Internal method temporarily removes lights before reloading them
		/// into graphics pipeline.
		/// </summary>
		// Token: 0x06002506 RID: 9478 RVA: 0x000371F7 File Offset: 0x000353F7
		public virtual void ClearLights()
		{
			vtkRenderer.vtkRenderer_ClearLights_11(base.GetCppThis());
		}

		// Token: 0x06002507 RID: 9479
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_ComputeVisiblePropBounds_12(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Compute the bounding box of all the visible props
		/// Used in ResetCamera() and ResetCameraClippingRange()
		/// </summary>
		// Token: 0x06002508 RID: 9480 RVA: 0x00037206 File Offset: 0x00035406
		public void ComputeVisiblePropBounds(IntPtr bounds)
		{
			vtkRenderer.vtkRenderer_ComputeVisiblePropBounds_12(base.GetCppThis(), bounds);
		}

		// Token: 0x06002509 RID: 9481
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderer_ComputeVisiblePropBounds_13(HandleRef pThis);

		/// <summary>
		/// Wrapper-friendly version of ComputeVisiblePropBounds
		/// </summary>
		// Token: 0x0600250A RID: 9482 RVA: 0x00037218 File Offset: 0x00035418
		public double[] ComputeVisiblePropBounds()
		{
			IntPtr intPtr = vtkRenderer.vtkRenderer_ComputeVisiblePropBounds_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600250B RID: 9483
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_CreateLight_14(HandleRef pThis);

		/// <summary>
		/// Create and add a light to renderer.
		/// </summary>
		// Token: 0x0600250C RID: 9484 RVA: 0x00037260 File Offset: 0x00035460
		public void CreateLight()
		{
			vtkRenderer.vtkRenderer_CreateLight_14(base.GetCppThis());
		}

		// Token: 0x0600250D RID: 9485
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_DeviceRender_15(HandleRef pThis);

		/// <summary>
		/// Create an image. Subclasses of vtkRenderer must implement this method.
		/// </summary>
		// Token: 0x0600250E RID: 9486 RVA: 0x0003726F File Offset: 0x0003546F
		public virtual void DeviceRender()
		{
			vtkRenderer.vtkRenderer_DeviceRender_15(base.GetCppThis());
		}

		// Token: 0x0600250F RID: 9487
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_DeviceRenderOpaqueGeometry_16(HandleRef pThis, HandleRef fbo);

		/// <summary>
		/// Render opaque polygonal geometry. Default implementation just calls
		/// UpdateOpaquePolygonalGeometry().
		/// Subclasses of vtkRenderer that can deal with, e.g. hidden line removal must
		/// override this method.
		/// </summary>
		// Token: 0x06002510 RID: 9488 RVA: 0x00037280 File Offset: 0x00035480
		public virtual void DeviceRenderOpaqueGeometry(vtkFrameBufferObjectBase fbo)
		{
			vtkRenderer.vtkRenderer_DeviceRenderOpaqueGeometry_16(base.GetCppThis(), (fbo == null) ? default(HandleRef) : fbo.GetCppThis());
		}

		// Token: 0x06002511 RID: 9489
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_DeviceRenderTranslucentPolygonalGeometry_17(HandleRef pThis, HandleRef fbo);

		/// <summary>
		/// Render translucent polygonal geometry. Default implementation just call
		/// UpdateTranslucentPolygonalGeometry().
		/// Subclasses of vtkRenderer that can deal with depth peeling must
		/// override this method.
		/// If UseDepthPeeling and UseDepthPeelingForVolumes are true, volumetric data
		/// will be rendered here as well.
		/// It updates boolean ivar LastRenderingUsedDepthPeeling.
		/// </summary>
		// Token: 0x06002512 RID: 9490 RVA: 0x000372B0 File Offset: 0x000354B0
		public virtual void DeviceRenderTranslucentPolygonalGeometry(vtkFrameBufferObjectBase fbo)
		{
			vtkRenderer.vtkRenderer_DeviceRenderTranslucentPolygonalGeometry_17(base.GetCppThis(), (fbo == null) ? default(HandleRef) : fbo.GetCppThis());
		}

		// Token: 0x06002513 RID: 9491
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderer_DisplayToWorld_18(HandleRef pThis, HandleRef display, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Convert a vtkVector3d from display space to world space.
		/// </summary>
		// Token: 0x06002514 RID: 9492 RVA: 0x000372E0 File Offset: 0x000354E0
		public vtkVector3d DisplayToWorld(vtkVector3d display)
		{
			vtkVector3d result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderer.vtkRenderer_DisplayToWorld_18(base.GetCppThis(), (display == null) ? default(HandleRef) : display.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector3d)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002515 RID: 9493
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_DrawOff_19(HandleRef pThis);

		/// <summary>
		/// When this flag is off, render commands are ignored.  It is used to either
		/// multiplex a vtkRenderWindow or render only part of a vtkRenderWindow.
		/// By default, Draw is on.
		/// </summary>
		// Token: 0x06002516 RID: 9494 RVA: 0x00037350 File Offset: 0x00035550
		public virtual void DrawOff()
		{
			vtkRenderer.vtkRenderer_DrawOff_19(base.GetCppThis());
		}

		// Token: 0x06002517 RID: 9495
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_DrawOn_20(HandleRef pThis);

		/// <summary>
		/// When this flag is off, render commands are ignored.  It is used to either
		/// multiplex a vtkRenderWindow or render only part of a vtkRenderWindow.
		/// By default, Draw is on.
		/// </summary>
		// Token: 0x06002518 RID: 9496 RVA: 0x0003735F File Offset: 0x0003555F
		public virtual void DrawOn()
		{
			vtkRenderer.vtkRenderer_DrawOn_20(base.GetCppThis());
		}

		// Token: 0x06002519 RID: 9497
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_EraseOff_21(HandleRef pThis);

		/// <summary>
		/// When this flag is off, the renderer will not erase the background
		/// or the Zbuffer.  It is used to have overlapping renderers.
		/// Both the RenderWindow Erase and Render Erase must be on
		/// for the camera to clear the renderer.  By default, Erase is on.
		/// </summary>
		// Token: 0x0600251A RID: 9498 RVA: 0x0003736E File Offset: 0x0003556E
		public virtual void EraseOff()
		{
			vtkRenderer.vtkRenderer_EraseOff_21(base.GetCppThis());
		}

		// Token: 0x0600251B RID: 9499
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_EraseOn_22(HandleRef pThis);

		/// <summary>
		/// When this flag is off, the renderer will not erase the background
		/// or the Zbuffer.  It is used to have overlapping renderers.
		/// Both the RenderWindow Erase and Render Erase must be on
		/// for the camera to clear the renderer.  By default, Erase is on.
		/// </summary>
		// Token: 0x0600251C RID: 9500 RVA: 0x0003737D File Offset: 0x0003557D
		public virtual void EraseOn()
		{
			vtkRenderer.vtkRenderer_EraseOn_22(base.GetCppThis());
		}

		// Token: 0x0600251D RID: 9501
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderer_GetActiveCamera_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the current camera. If there is not camera assigned to the
		/// renderer already, a new one is created automatically.
		/// This does *not* reset the camera.
		/// </summary>
		// Token: 0x0600251E RID: 9502 RVA: 0x0003738C File Offset: 0x0003558C
		public vtkCamera GetActiveCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderer.vtkRenderer_GetActiveCamera_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600251F RID: 9503
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderer_GetActors_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return any actors in this renderer.
		/// </summary>
		// Token: 0x06002520 RID: 9504 RVA: 0x000373FC File Offset: 0x000355FC
		public vtkActorCollection GetActors()
		{
			vtkActorCollection vtkActorCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderer.vtkRenderer_GetActors_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActorCollection = (vtkActorCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActorCollection.Register(null);
				}
			}
			return vtkActorCollection;
		}

		// Token: 0x06002521 RID: 9505
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderer_GetAllocatedRenderTime_25(HandleRef pThis);

		/// <summary>
		/// Set/Get the amount of time this renderer is allowed to spend
		/// rendering its scene. This is used by vtkLODActor's.
		/// </summary>
		// Token: 0x06002522 RID: 9506 RVA: 0x0003746C File Offset: 0x0003566C
		public virtual double GetAllocatedRenderTime()
		{
			return vtkRenderer.vtkRenderer_GetAllocatedRenderTime_25(base.GetCppThis());
		}

		// Token: 0x06002523 RID: 9507
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderer_GetAmbient_26(HandleRef pThis);

		/// <summary>
		/// Set the intensity of ambient lighting.
		/// </summary>
		// Token: 0x06002524 RID: 9508 RVA: 0x0003748C File Offset: 0x0003568C
		public virtual double[] GetAmbient()
		{
			IntPtr intPtr = vtkRenderer.vtkRenderer_GetAmbient_26(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06002525 RID: 9509
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_GetAmbient_27(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the intensity of ambient lighting.
		/// </summary>
		// Token: 0x06002526 RID: 9510 RVA: 0x000374D4 File Offset: 0x000356D4
		public virtual void GetAmbient(IntPtr data)
		{
			vtkRenderer.vtkRenderer_GetAmbient_27(base.GetCppThis(), data);
		}

		// Token: 0x06002527 RID: 9511
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderer_GetAutomaticLightCreation_28(HandleRef pThis);

		/// <summary>
		/// Turn on/off a flag which disables the automatic light creation capability.
		/// Normally in VTK if no lights are associated with the renderer, then a light
		/// is automatically created. However, in special circumstances this feature is
		/// undesirable, so the following boolean is provided to disable automatic
		/// light creation. (Turn AutomaticLightCreation off if you do not want lights
		/// to be created.)
		/// </summary>
		// Token: 0x06002528 RID: 9512 RVA: 0x000374E4 File Offset: 0x000356E4
		public virtual int GetAutomaticLightCreation()
		{
			return vtkRenderer.vtkRenderer_GetAutomaticLightCreation_28(base.GetCppThis());
		}

		// Token: 0x06002529 RID: 9513
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderer_GetBackgroundTexture_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the texture to be used for the monocular or stereo left eye
		/// background. If set and enabled this gets the priority over the gradient
		/// background.
		/// </summary>
		// Token: 0x0600252A RID: 9514 RVA: 0x00037504 File Offset: 0x00035704
		public virtual vtkTexture GetBackgroundTexture()
		{
			vtkTexture vtkTexture = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderer.vtkRenderer_GetBackgroundTexture_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTexture = (vtkTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTexture.Register(null);
				}
			}
			return vtkTexture;
		}

		// Token: 0x0600252B RID: 9515
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderer_GetBackingStore_30(HandleRef pThis);

		/// <summary>
		/// Turn on/off using backing store. This may cause the re-rendering
		/// time to be slightly slower when the view changes. But it is
		/// much faster when the image has not changed, such as during an
		/// expose event.
		/// </summary>
		// Token: 0x0600252C RID: 9516 RVA: 0x00037574 File Offset: 0x00035774
		public virtual int GetBackingStore()
		{
			return vtkRenderer.vtkRenderer_GetBackingStore_30(base.GetCppThis());
		}

		// Token: 0x0600252D RID: 9517
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderer_GetClippingRangeExpansion_31(HandleRef pThis);

		/// <summary>
		/// Specify enlargement of bounds when resetting the
		/// camera clipping range.  By default the range is not expanded by
		/// any percent of the (far - near) on the near and far sides
		/// </summary>
		// Token: 0x0600252E RID: 9518 RVA: 0x00037594 File Offset: 0x00035794
		public virtual double GetClippingRangeExpansion()
		{
			return vtkRenderer.vtkRenderer_GetClippingRangeExpansion_31(base.GetCppThis());
		}

		// Token: 0x0600252F RID: 9519
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderer_GetClippingRangeExpansionMaxValue_32(HandleRef pThis);

		/// <summary>
		/// Specify enlargement of bounds when resetting the
		/// camera clipping range.  By default the range is not expanded by
		/// any percent of the (far - near) on the near and far sides
		/// </summary>
		// Token: 0x06002530 RID: 9520 RVA: 0x000375B4 File Offset: 0x000357B4
		public virtual double GetClippingRangeExpansionMaxValue()
		{
			return vtkRenderer.vtkRenderer_GetClippingRangeExpansionMaxValue_32(base.GetCppThis());
		}

		// Token: 0x06002531 RID: 9521
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderer_GetClippingRangeExpansionMinValue_33(HandleRef pThis);

		/// <summary>
		/// Specify enlargement of bounds when resetting the
		/// camera clipping range.  By default the range is not expanded by
		/// any percent of the (far - near) on the near and far sides
		/// </summary>
		// Token: 0x06002532 RID: 9522 RVA: 0x000375D4 File Offset: 0x000357D4
		public virtual double GetClippingRangeExpansionMinValue()
		{
			return vtkRenderer.vtkRenderer_GetClippingRangeExpansionMinValue_33(base.GetCppThis());
		}

		// Token: 0x06002533 RID: 9523
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderer_GetCullers_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the collection of cullers.
		/// </summary>
		// Token: 0x06002534 RID: 9524 RVA: 0x000375F4 File Offset: 0x000357F4
		public vtkCullerCollection GetCullers()
		{
			vtkCullerCollection vtkCullerCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderer.vtkRenderer_GetCullers_34(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCullerCollection = (vtkCullerCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCullerCollection.Register(null);
				}
			}
			return vtkCullerCollection;
		}

		// Token: 0x06002535 RID: 9525
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderer_GetDelegate_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get a custom Render call. Allows to hook a Render call from an
		/// external project.It will be used in place of vtkRenderer::Render() if it
		/// is not NULL and its Used ivar is set to true.
		/// Initial value is NULL.
		/// </summary>
		// Token: 0x06002536 RID: 9526 RVA: 0x00037664 File Offset: 0x00035864
		public virtual vtkRendererDelegate GetDelegate()
		{
			vtkRendererDelegate vtkRendererDelegate = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderer.vtkRenderer_GetDelegate_35(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRendererDelegate = (vtkRendererDelegate)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRendererDelegate.Register(null);
				}
			}
			return vtkRendererDelegate;
		}

		// Token: 0x06002537 RID: 9527
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderer_GetDraw_36(HandleRef pThis);

		/// <summary>
		/// When this flag is off, render commands are ignored.  It is used to either
		/// multiplex a vtkRenderWindow or render only part of a vtkRenderWindow.
		/// By default, Draw is on.
		/// </summary>
		// Token: 0x06002538 RID: 9528 RVA: 0x000376D4 File Offset: 0x000358D4
		public virtual int GetDraw()
		{
			return vtkRenderer.vtkRenderer_GetDraw_36(base.GetCppThis());
		}

		// Token: 0x06002539 RID: 9529
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderer_GetEnvironmentRight_37(HandleRef pThis);

		/// <summary>
		/// Set/Get the environment right vector.
		/// </summary>
		// Token: 0x0600253A RID: 9530 RVA: 0x000376F4 File Offset: 0x000358F4
		public virtual double[] GetEnvironmentRight()
		{
			IntPtr intPtr = vtkRenderer.vtkRenderer_GetEnvironmentRight_37(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600253B RID: 9531
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_GetEnvironmentRight_38(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the environment right vector.
		/// </summary>
		// Token: 0x0600253C RID: 9532 RVA: 0x0003773C File Offset: 0x0003593C
		public virtual void GetEnvironmentRight(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkRenderer.vtkRenderer_GetEnvironmentRight_38(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600253D RID: 9533
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_GetEnvironmentRight_39(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the environment right vector.
		/// </summary>
		// Token: 0x0600253E RID: 9534 RVA: 0x0003774E File Offset: 0x0003594E
		public virtual void GetEnvironmentRight(IntPtr _arg)
		{
			vtkRenderer.vtkRenderer_GetEnvironmentRight_39(base.GetCppThis(), _arg);
		}

		// Token: 0x0600253F RID: 9535
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderer_GetEnvironmentTexture_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the environment texture used for image based lighting.
		/// This texture is supposed to represent the scene background.
		/// @sa vtkTexture::UseSRGBColorSpaceOn
		/// </summary>
		// Token: 0x06002540 RID: 9536 RVA: 0x00037760 File Offset: 0x00035960
		public virtual vtkTexture GetEnvironmentTexture()
		{
			vtkTexture vtkTexture = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderer.vtkRenderer_GetEnvironmentTexture_40(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTexture = (vtkTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTexture.Register(null);
				}
			}
			return vtkTexture;
		}

		// Token: 0x06002541 RID: 9537
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderer_GetEnvironmentUp_41(HandleRef pThis);

		/// <summary>
		/// Set/Get the environment up vector.
		/// </summary>
		// Token: 0x06002542 RID: 9538 RVA: 0x000377D0 File Offset: 0x000359D0
		public virtual double[] GetEnvironmentUp()
		{
			IntPtr intPtr = vtkRenderer.vtkRenderer_GetEnvironmentUp_41(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06002543 RID: 9539
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_GetEnvironmentUp_42(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the environment up vector.
		/// </summary>
		// Token: 0x06002544 RID: 9540 RVA: 0x00037818 File Offset: 0x00035A18
		public virtual void GetEnvironmentUp(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkRenderer.vtkRenderer_GetEnvironmentUp_42(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06002545 RID: 9541
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_GetEnvironmentUp_43(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the environment up vector.
		/// </summary>
		// Token: 0x06002546 RID: 9542 RVA: 0x0003782A File Offset: 0x00035A2A
		public virtual void GetEnvironmentUp(IntPtr _arg)
		{
			vtkRenderer.vtkRenderer_GetEnvironmentUp_43(base.GetCppThis(), _arg);
		}

		// Token: 0x06002547 RID: 9543
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderer_GetErase_44(HandleRef pThis);

		/// <summary>
		/// When this flag is off, the renderer will not erase the background
		/// or the Zbuffer.  It is used to have overlapping renderers.
		/// Both the RenderWindow Erase and Render Erase must be on
		/// for the camera to clear the renderer.  By default, Erase is on.
		/// </summary>
		// Token: 0x06002548 RID: 9544 RVA: 0x0003783C File Offset: 0x00035A3C
		public virtual int GetErase()
		{
			return vtkRenderer.vtkRenderer_GetErase_44(base.GetCppThis());
		}

		// Token: 0x06002549 RID: 9545
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderer_GetFXAAOptions_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The configuration object for FXAA antialiasing.
		/// </summary>
		// Token: 0x0600254A RID: 9546 RVA: 0x0003785C File Offset: 0x00035A5C
		public virtual vtkFXAAOptions GetFXAAOptions()
		{
			vtkFXAAOptions vtkFXAAOptions = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderer.vtkRenderer_GetFXAAOptions_45(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFXAAOptions = (vtkFXAAOptions)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFXAAOptions.Register(null);
				}
			}
			return vtkFXAAOptions;
		}

		// Token: 0x0600254B RID: 9547
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderer_GetInformation_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the information object associated with this algorithm.
		/// </summary>
		// Token: 0x0600254C RID: 9548 RVA: 0x000378CC File Offset: 0x00035ACC
		public virtual vtkInformation GetInformation()
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderer.vtkRenderer_GetInformation_46(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		// Token: 0x0600254D RID: 9549
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderer_GetInteractive_47(HandleRef pThis);

		/// <summary>
		/// Turn on/off interactive status.  An interactive renderer is one that
		/// can receive events from an interactor.  Should only be set if
		/// there are multiple renderers in the same section of the viewport.
		/// </summary>
		// Token: 0x0600254E RID: 9550 RVA: 0x0003793C File Offset: 0x00035B3C
		public virtual int GetInteractive()
		{
			return vtkRenderer.vtkRenderer_GetInteractive_47(base.GetCppThis());
		}

		// Token: 0x0600254F RID: 9551
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderer_GetLastRenderTimeInSeconds_48(HandleRef pThis);

		/// <summary>
		/// Get the time required, in seconds, for the last Render call.
		/// </summary>
		// Token: 0x06002550 RID: 9552 RVA: 0x0003795C File Offset: 0x00035B5C
		public virtual double GetLastRenderTimeInSeconds()
		{
			return vtkRenderer.vtkRenderer_GetLastRenderTimeInSeconds_48(base.GetCppThis());
		}

		// Token: 0x06002551 RID: 9553
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderer_GetLastRenderingUsedDepthPeeling_49(HandleRef pThis);

		/// <summary>
		/// Tells if the last call to DeviceRenderTranslucentPolygonalGeometry()
		/// actually used depth peeling.
		/// Initial value is false.
		/// </summary>
		// Token: 0x06002552 RID: 9554 RVA: 0x0003797C File Offset: 0x00035B7C
		public virtual int GetLastRenderingUsedDepthPeeling()
		{
			return vtkRenderer.vtkRenderer_GetLastRenderingUsedDepthPeeling_49(base.GetCppThis());
		}

		// Token: 0x06002553 RID: 9555
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderer_GetLayer_50(HandleRef pThis);

		/// <summary>
		/// Set/Get the layer that this renderer belongs to.  This is only used if
		/// there are layered renderers.
		///
		/// Note: Changing the layer will update the PreserveColorBuffer setting. If
		/// the layer is 0, PreserveColorBuffer will be set to false, making the
		/// bottom renderer opaque. If the layer is non-zero, PreserveColorBuffer will
		/// be set to true, giving the renderer a transparent background. If other
		/// PreserveColorBuffer configurations are desired, they must be adjusted after
		/// the layer is set.
		/// </summary>
		// Token: 0x06002554 RID: 9556 RVA: 0x0003799C File Offset: 0x00035B9C
		public virtual int GetLayer()
		{
			return vtkRenderer.vtkRenderer_GetLayer_50(base.GetCppThis());
		}

		// Token: 0x06002555 RID: 9557
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderer_GetLeftBackgroundTexture_51(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the texture to be used for the monocular or stereo left eye
		/// background. If set and enabled this gets the priority over the gradient
		/// background.
		/// </summary>
		// Token: 0x06002556 RID: 9558 RVA: 0x000379BC File Offset: 0x00035BBC
		public vtkTexture GetLeftBackgroundTexture()
		{
			vtkTexture vtkTexture = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderer.vtkRenderer_GetLeftBackgroundTexture_51(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTexture = (vtkTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTexture.Register(null);
				}
			}
			return vtkTexture;
		}

		// Token: 0x06002557 RID: 9559
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderer_GetLightFollowCamera_52(HandleRef pThis);

		/// <summary>
		/// Turn on/off the automatic repositioning of lights as the camera moves.
		/// If LightFollowCamera is on, lights that are designated as Headlights
		/// or CameraLights will be adjusted to move with this renderer's camera.
		/// If LightFollowCamera is off, the lights will not be adjusted.
		///
		/// (Note: In previous versions of vtk, this light-tracking
		/// functionality was part of the interactors, not the renderer. For
		/// backwards compatibility, the older, more limited interactor
		/// behavior is enabled by default. To disable this mode, turn the
		/// interactor's LightFollowCamera flag OFF, and leave the renderer's
		/// LightFollowCamera flag ON.)
		/// </summary>
		// Token: 0x06002558 RID: 9560 RVA: 0x00037A2C File Offset: 0x00035C2C
		public virtual int GetLightFollowCamera()
		{
			return vtkRenderer.vtkRenderer_GetLightFollowCamera_52(base.GetCppThis());
		}

		// Token: 0x06002559 RID: 9561
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderer_GetLights_53(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the collection of lights.
		/// </summary>
		// Token: 0x0600255A RID: 9562 RVA: 0x00037A4C File Offset: 0x00035C4C
		public vtkLightCollection GetLights()
		{
			vtkLightCollection vtkLightCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderer.vtkRenderer_GetLights_53(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLightCollection = (vtkLightCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLightCollection.Register(null);
				}
			}
			return vtkLightCollection;
		}

		// Token: 0x0600255B RID: 9563
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkRenderer_GetMTime_54(HandleRef pThis);

		/// <summary>
		/// Return the MTime of the renderer also considering its ivars.
		/// </summary>
		// Token: 0x0600255C RID: 9564 RVA: 0x00037ABC File Offset: 0x00035CBC
		public override ulong GetMTime()
		{
			return vtkRenderer.vtkRenderer_GetMTime_54(base.GetCppThis());
		}

		// Token: 0x0600255D RID: 9565
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderer_GetMaximumNumberOfPeels_55(HandleRef pThis);

		/// <summary>
		/// In case of depth peeling, define the maximum number of peeling layers.
		/// Initial value is 4. A special value of 0 means no maximum limit.
		/// It has to be a positive value.
		/// </summary>
		// Token: 0x0600255E RID: 9566 RVA: 0x00037ADC File Offset: 0x00035CDC
		public virtual int GetMaximumNumberOfPeels()
		{
			return vtkRenderer.vtkRenderer_GetMaximumNumberOfPeels_55(base.GetCppThis());
		}

		// Token: 0x0600255F RID: 9567
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderer_GetNearClippingPlaneTolerance_56(HandleRef pThis);

		/// <summary>
		/// Specify tolerance for near clipping plane distance to the camera as a
		/// percentage of the far clipping plane distance. By default this will be
		/// set to 0.01 for 16 bit zbuffers and 0.001 for higher depth z buffers
		/// </summary>
		// Token: 0x06002560 RID: 9568 RVA: 0x00037AFC File Offset: 0x00035CFC
		public virtual double GetNearClippingPlaneTolerance()
		{
			return vtkRenderer.vtkRenderer_GetNearClippingPlaneTolerance_56(base.GetCppThis());
		}

		// Token: 0x06002561 RID: 9569
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderer_GetNearClippingPlaneToleranceMaxValue_57(HandleRef pThis);

		/// <summary>
		/// Specify tolerance for near clipping plane distance to the camera as a
		/// percentage of the far clipping plane distance. By default this will be
		/// set to 0.01 for 16 bit zbuffers and 0.001 for higher depth z buffers
		/// </summary>
		// Token: 0x06002562 RID: 9570 RVA: 0x00037B1C File Offset: 0x00035D1C
		public virtual double GetNearClippingPlaneToleranceMaxValue()
		{
			return vtkRenderer.vtkRenderer_GetNearClippingPlaneToleranceMaxValue_57(base.GetCppThis());
		}

		// Token: 0x06002563 RID: 9571
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderer_GetNearClippingPlaneToleranceMinValue_58(HandleRef pThis);

		/// <summary>
		/// Specify tolerance for near clipping plane distance to the camera as a
		/// percentage of the far clipping plane distance. By default this will be
		/// set to 0.01 for 16 bit zbuffers and 0.001 for higher depth z buffers
		/// </summary>
		// Token: 0x06002564 RID: 9572 RVA: 0x00037B3C File Offset: 0x00035D3C
		public virtual double GetNearClippingPlaneToleranceMinValue()
		{
			return vtkRenderer.vtkRenderer_GetNearClippingPlaneToleranceMinValue_58(base.GetCppThis());
		}

		// Token: 0x06002565 RID: 9573
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderer_GetNumberOfGenerationsFromBase_59(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002566 RID: 9574 RVA: 0x00037B5C File Offset: 0x00035D5C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRenderer.vtkRenderer_GetNumberOfGenerationsFromBase_59(base.GetCppThis(), type);
		}

		// Token: 0x06002567 RID: 9575
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderer_GetNumberOfGenerationsFromBaseType_60([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002568 RID: 9576 RVA: 0x00037B7C File Offset: 0x00035D7C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRenderer.vtkRenderer_GetNumberOfGenerationsFromBaseType_60(type);
		}

		// Token: 0x06002569 RID: 9577
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderer_GetNumberOfPropsRendered_61(HandleRef pThis);

		/// <summary>
		/// Should be used internally only during a render
		/// Get the number of props that were rendered using a
		/// RenderOpaqueGeometry or RenderTranslucentPolygonalGeometry call.
		/// This is used to know if something is in the frame buffer.
		/// </summary>
		// Token: 0x0600256A RID: 9578 RVA: 0x00037B98 File Offset: 0x00035D98
		public virtual int GetNumberOfPropsRendered()
		{
			return vtkRenderer.vtkRenderer_GetNumberOfPropsRendered_61(base.GetCppThis());
		}

		// Token: 0x0600256B RID: 9579
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderer_GetOcclusionRatio_62(HandleRef pThis);

		/// <summary>
		/// In case of use of depth peeling technique for rendering translucent
		/// material, define the threshold under which the algorithm stops to
		/// iterate over peel layers. This is the ratio of the number of pixels
		/// that have been touched by the last layer over the total number of pixels
		/// of the viewport area.
		/// Initial value is 0.0, meaning rendering have to be exact. Greater values
		/// may speed-up the rendering with small impact on the quality.
		/// </summary>
		// Token: 0x0600256C RID: 9580 RVA: 0x00037BB8 File Offset: 0x00035DB8
		public virtual double GetOcclusionRatio()
		{
			return vtkRenderer.vtkRenderer_GetOcclusionRatio_62(base.GetCppThis());
		}

		// Token: 0x0600256D RID: 9581
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderer_GetOcclusionRatioMaxValue_63(HandleRef pThis);

		/// <summary>
		/// In case of use of depth peeling technique for rendering translucent
		/// material, define the threshold under which the algorithm stops to
		/// iterate over peel layers. This is the ratio of the number of pixels
		/// that have been touched by the last layer over the total number of pixels
		/// of the viewport area.
		/// Initial value is 0.0, meaning rendering have to be exact. Greater values
		/// may speed-up the rendering with small impact on the quality.
		/// </summary>
		// Token: 0x0600256E RID: 9582 RVA: 0x00037BD8 File Offset: 0x00035DD8
		public virtual double GetOcclusionRatioMaxValue()
		{
			return vtkRenderer.vtkRenderer_GetOcclusionRatioMaxValue_63(base.GetCppThis());
		}

		// Token: 0x0600256F RID: 9583
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderer_GetOcclusionRatioMinValue_64(HandleRef pThis);

		/// <summary>
		/// In case of use of depth peeling technique for rendering translucent
		/// material, define the threshold under which the algorithm stops to
		/// iterate over peel layers. This is the ratio of the number of pixels
		/// that have been touched by the last layer over the total number of pixels
		/// of the viewport area.
		/// Initial value is 0.0, meaning rendering have to be exact. Greater values
		/// may speed-up the rendering with small impact on the quality.
		/// </summary>
		// Token: 0x06002570 RID: 9584 RVA: 0x00037BF8 File Offset: 0x00035DF8
		public virtual double GetOcclusionRatioMinValue()
		{
			return vtkRenderer.vtkRenderer_GetOcclusionRatioMinValue_64(base.GetCppThis());
		}

		// Token: 0x06002571 RID: 9585
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderer_GetPass_65(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// If this flag is true and the rendering engine supports it, wireframe
		/// geometry will be drawn using hidden line removal.
		/// </summary>
		// Token: 0x06002572 RID: 9586 RVA: 0x00037C18 File Offset: 0x00035E18
		public virtual vtkRenderPass GetPass()
		{
			vtkRenderPass vtkRenderPass = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderer.vtkRenderer_GetPass_65(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderPass = (vtkRenderPass)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderPass.Register(null);
				}
			}
			return vtkRenderPass;
		}

		// Token: 0x06002573 RID: 9587
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderer_GetPreserveColorBuffer_66(HandleRef pThis);

		/// <summary>
		/// By default, the renderer at layer 0 is opaque, and all non-zero layer
		/// renderers are transparent. This flag allows this behavior to be overridden.
		/// If true, this setting will force the renderer to preserve the existing
		/// color buffer regardless of layer. If false, it will always be cleared at
		/// the start of rendering.
		///
		/// This flag influences the Transparent() method, and is updated by calls to
		/// SetLayer(). For this reason it should only be set after changing the layer.
		/// </summary>
		// Token: 0x06002574 RID: 9588 RVA: 0x00037C88 File Offset: 0x00035E88
		public virtual int GetPreserveColorBuffer()
		{
			return vtkRenderer.vtkRenderer_GetPreserveColorBuffer_66(base.GetCppThis());
		}

		// Token: 0x06002575 RID: 9589
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderer_GetPreserveDepthBuffer_67(HandleRef pThis);

		/// <summary>
		/// By default, the depth buffer is reset for each renderer. If this flag is
		/// true, this renderer will use the existing depth buffer for its rendering.
		/// </summary>
		// Token: 0x06002576 RID: 9590 RVA: 0x00037CA8 File Offset: 0x00035EA8
		public virtual int GetPreserveDepthBuffer()
		{
			return vtkRenderer.vtkRenderer_GetPreserveDepthBuffer_67(base.GetCppThis());
		}

		// Token: 0x06002577 RID: 9591
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderer_GetRenderWindow_68(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the rendering window in which to draw. This is automatically set
		/// when the renderer is created by MakeRenderer.  The user probably
		/// shouldn't ever need to call this method.
		/// </summary>
		// Token: 0x06002578 RID: 9592 RVA: 0x00037CC8 File Offset: 0x00035EC8
		public vtkRenderWindow GetRenderWindow()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderer.vtkRenderer_GetRenderWindow_68(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindow = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindow.Register(null);
				}
			}
			return vtkRenderWindow;
		}

		// Token: 0x06002579 RID: 9593
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderer_GetRightBackgroundTexture_69(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the texture to be used for the right eye background. If set
		/// and enabled this gets the priority over the gradient background.
		/// </summary>
		// Token: 0x0600257A RID: 9594 RVA: 0x00037D38 File Offset: 0x00035F38
		public virtual vtkTexture GetRightBackgroundTexture()
		{
			vtkTexture vtkTexture = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderer.vtkRenderer_GetRightBackgroundTexture_69(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTexture = (vtkTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTexture.Register(null);
				}
			}
			return vtkTexture;
		}

		// Token: 0x0600257B RID: 9595
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderer_GetSSAOBias_70(HandleRef pThis);

		/// <summary>
		/// When using SSAO, define the bias when comparing samples.
		/// Default is 0.01
		/// </summary>
		// Token: 0x0600257C RID: 9596 RVA: 0x00037DA8 File Offset: 0x00035FA8
		public virtual double GetSSAOBias()
		{
			return vtkRenderer.vtkRenderer_GetSSAOBias_70(base.GetCppThis());
		}

		// Token: 0x0600257D RID: 9597
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderer_GetSSAOBlur_71(HandleRef pThis);

		/// <summary>
		/// When using SSAO, define blurring of the ambient occlusion.
		/// Blurring can help to improve the result if samples number is low.
		/// Default is false
		/// </summary>
		// Token: 0x0600257E RID: 9598 RVA: 0x00037DC8 File Offset: 0x00035FC8
		public virtual bool GetSSAOBlur()
		{
			return vtkRenderer.vtkRenderer_GetSSAOBlur_71(base.GetCppThis()) != 0;
		}

		// Token: 0x0600257F RID: 9599
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkRenderer_GetSSAOKernelSize_72(HandleRef pThis);

		/// <summary>
		/// When using SSAO, define the number of samples.
		/// Default is 32
		/// </summary>
		// Token: 0x06002580 RID: 9600 RVA: 0x00037DF0 File Offset: 0x00035FF0
		public virtual uint GetSSAOKernelSize()
		{
			return vtkRenderer.vtkRenderer_GetSSAOKernelSize_72(base.GetCppThis());
		}

		// Token: 0x06002581 RID: 9601
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderer_GetSSAORadius_73(HandleRef pThis);

		/// <summary>
		/// When using SSAO, define the SSAO hemisphere radius.
		/// Default is 0.5
		/// </summary>
		// Token: 0x06002582 RID: 9602 RVA: 0x00037E10 File Offset: 0x00036010
		public virtual double GetSSAORadius()
		{
			return vtkRenderer.vtkRenderer_GetSSAORadius_73(base.GetCppThis());
		}

		// Token: 0x06002583 RID: 9603
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderer_GetSelector_74(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the current hardware selector. If the Selector is set, it implies the
		/// current render pass is for selection. Mappers/Properties may choose to
		/// behave differently when rendering for hardware selection.
		/// </summary>
		// Token: 0x06002584 RID: 9604 RVA: 0x00037E30 File Offset: 0x00036030
		public virtual vtkHardwareSelector GetSelector()
		{
			vtkHardwareSelector vtkHardwareSelector = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderer.vtkRenderer_GetSelector_74(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHardwareSelector = (vtkHardwareSelector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHardwareSelector.Register(null);
				}
			}
			return vtkHardwareSelector;
		}

		// Token: 0x06002585 RID: 9605
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderer_GetTexturedBackground_75(HandleRef pThis);

		/// <summary>
		/// Set/Get whether this viewport should have a textured background.
		/// Default is off.
		/// </summary>
		// Token: 0x06002586 RID: 9606 RVA: 0x00037EA0 File Offset: 0x000360A0
		public virtual bool GetTexturedBackground()
		{
			return vtkRenderer.vtkRenderer_GetTexturedBackground_75(base.GetCppThis()) != 0;
		}

		// Token: 0x06002587 RID: 9607
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderer_GetTiledAspectRatio_76(HandleRef pThis);

		/// <summary>
		/// Compute the aspect ratio of this renderer for the current tile. When
		/// tiled displays are used the aspect ratio of the renderer for a given
		/// tile may be different that the aspect ratio of the renderer when rendered
		/// in it entirety
		/// </summary>
		// Token: 0x06002588 RID: 9608 RVA: 0x00037EC8 File Offset: 0x000360C8
		public double GetTiledAspectRatio()
		{
			return vtkRenderer.vtkRenderer_GetTiledAspectRatio_76(base.GetCppThis());
		}

		// Token: 0x06002589 RID: 9609
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderer_GetTimeFactor_77(HandleRef pThis);

		/// <summary>
		/// Get the ratio between allocated time and actual render time.
		/// TimeFactor has been taken out of the render process.
		/// It is still computed in case someone finds it useful.
		/// It may be taken away in the future.
		/// </summary>
		// Token: 0x0600258A RID: 9610 RVA: 0x00037EE8 File Offset: 0x000360E8
		public virtual double GetTimeFactor()
		{
			return vtkRenderer.vtkRenderer_GetTimeFactor_77(base.GetCppThis());
		}

		// Token: 0x0600258B RID: 9611
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderer_GetTwoSidedLighting_78(HandleRef pThis);

		/// <summary>
		/// Turn on/off two-sided lighting of surfaces. If two-sided lighting is
		/// off, then only the side of the surface facing the light(s) will be lit,
		/// and the other side dark. If two-sided lighting on, both sides of the
		/// surface will be lit.
		/// </summary>
		// Token: 0x0600258C RID: 9612 RVA: 0x00037F08 File Offset: 0x00036108
		public virtual int GetTwoSidedLighting()
		{
			return vtkRenderer.vtkRenderer_GetTwoSidedLighting_78(base.GetCppThis());
		}

		// Token: 0x0600258D RID: 9613
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderer_GetUseDepthPeeling_79(HandleRef pThis);

		/// <summary>
		/// Turn on/off rendering of translucent material with depth peeling
		/// technique. The render window must have alpha bits (ie call
		/// SetAlphaBitPlanes(1)) and no multisample buffer (ie call
		/// SetMultiSamples(0) ) to support depth peeling.
		/// If UseDepthPeeling is on and the GPU supports it, depth peeling is used
		/// for rendering translucent materials.
		/// If UseDepthPeeling is off, alpha blending is used.
		/// Initial value is off.
		/// </summary>
		// Token: 0x0600258E RID: 9614 RVA: 0x00037F28 File Offset: 0x00036128
		public virtual int GetUseDepthPeeling()
		{
			return vtkRenderer.vtkRenderer_GetUseDepthPeeling_79(base.GetCppThis());
		}

		// Token: 0x0600258F RID: 9615
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderer_GetUseDepthPeelingForVolumes_80(HandleRef pThis);

		/// <summary>
		/// This flag is on and the GPU supports it, depth-peel volumes along with
		/// the translucent geometry. Only supported on OpenGL2 with dual-depth
		/// peeling. Default is false.
		/// </summary>
		// Token: 0x06002590 RID: 9616 RVA: 0x00037F48 File Offset: 0x00036148
		public virtual bool GetUseDepthPeelingForVolumes()
		{
			return vtkRenderer.vtkRenderer_GetUseDepthPeelingForVolumes_80(base.GetCppThis()) != 0;
		}

		// Token: 0x06002591 RID: 9617
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderer_GetUseFXAA_81(HandleRef pThis);

		/// <summary>
		/// Turn on/off FXAA anti-aliasing, if supported. Initial value is off.
		/// </summary>
		// Token: 0x06002592 RID: 9618 RVA: 0x00037F70 File Offset: 0x00036170
		public virtual bool GetUseFXAA()
		{
			return vtkRenderer.vtkRenderer_GetUseFXAA_81(base.GetCppThis()) != 0;
		}

		// Token: 0x06002593 RID: 9619
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderer_GetUseHiddenLineRemoval_82(HandleRef pThis);

		/// <summary>
		/// If this flag is true and the rendering engine supports it, wireframe
		/// geometry will be drawn using hidden line removal.
		/// </summary>
		// Token: 0x06002594 RID: 9620 RVA: 0x00037F98 File Offset: 0x00036198
		public virtual int GetUseHiddenLineRemoval()
		{
			return vtkRenderer.vtkRenderer_GetUseHiddenLineRemoval_82(base.GetCppThis());
		}

		// Token: 0x06002595 RID: 9621
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderer_GetUseImageBasedLighting_83(HandleRef pThis);

		/// <summary>
		/// If this flag is true and the rendering engine supports it, image based
		/// lighting is enabled and surface rendering displays environment reflections.
		/// Image Based Lighting rely on the environment texture to compute lighting
		/// if it has been provided.
		/// </summary>
		// Token: 0x06002596 RID: 9622 RVA: 0x00037FB8 File Offset: 0x000361B8
		public virtual bool GetUseImageBasedLighting()
		{
			return vtkRenderer.vtkRenderer_GetUseImageBasedLighting_83(base.GetCppThis()) != 0;
		}

		// Token: 0x06002597 RID: 9623
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRenderer_GetUseSSAO_84(HandleRef pThis);

		/// <summary>
		/// Enable or disable Screen Space Ambient Occlusion.
		/// SSAO darkens some pixels to improve depth perception.
		/// </summary>
		// Token: 0x06002598 RID: 9624 RVA: 0x00037FE0 File Offset: 0x000361E0
		public virtual bool GetUseSSAO()
		{
			return vtkRenderer.vtkRenderer_GetUseSSAO_84(base.GetCppThis()) != 0;
		}

		// Token: 0x06002599 RID: 9625
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderer_GetUseShadows_85(HandleRef pThis);

		/// <summary>
		/// Turn on/off rendering of shadows if supported
		/// Initial value is off.
		/// </summary>
		// Token: 0x0600259A RID: 9626 RVA: 0x00038008 File Offset: 0x00036208
		public virtual int GetUseShadows()
		{
			return vtkRenderer.vtkRenderer_GetUseShadows_85(base.GetCppThis());
		}

		// Token: 0x0600259B RID: 9627
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderer_GetVTKWindow_86(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the rendering window in which to draw. This is automatically set
		/// when the renderer is created by MakeRenderer.  The user probably
		/// shouldn't ever need to call this method.
		/// </summary>
		// Token: 0x0600259C RID: 9628 RVA: 0x00038028 File Offset: 0x00036228
		public override vtkWindow GetVTKWindow()
		{
			vtkWindow vtkWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderer.vtkRenderer_GetVTKWindow_86(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWindow = (vtkWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWindow.Register(null);
				}
			}
			return vtkWindow;
		}

		// Token: 0x0600259D RID: 9629
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderer_GetVolumes_87(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the collection of volumes.
		/// </summary>
		// Token: 0x0600259E RID: 9630 RVA: 0x00038098 File Offset: 0x00036298
		public vtkVolumeCollection GetVolumes()
		{
			vtkVolumeCollection vtkVolumeCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderer.vtkRenderer_GetVolumes_87(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeCollection = (vtkVolumeCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeCollection.Register(null);
				}
			}
			return vtkVolumeCollection;
		}

		// Token: 0x0600259F RID: 9631
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderer_GetZ_88(HandleRef pThis, int x, int y);

		/// <summary>
		/// Given a pixel location, return the Z value. The z value is
		/// normalized (0,1) between the front and back clipping planes.
		/// </summary>
		// Token: 0x060025A0 RID: 9632 RVA: 0x00038108 File Offset: 0x00036308
		public double GetZ(int x, int y)
		{
			return vtkRenderer.vtkRenderer_GetZ_88(base.GetCppThis(), x, y);
		}

		// Token: 0x060025A1 RID: 9633
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_InteractiveOff_89(HandleRef pThis);

		/// <summary>
		/// Turn on/off interactive status.  An interactive renderer is one that
		/// can receive events from an interactor.  Should only be set if
		/// there are multiple renderers in the same section of the viewport.
		/// </summary>
		// Token: 0x060025A2 RID: 9634 RVA: 0x00038129 File Offset: 0x00036329
		public virtual void InteractiveOff()
		{
			vtkRenderer.vtkRenderer_InteractiveOff_89(base.GetCppThis());
		}

		// Token: 0x060025A3 RID: 9635
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_InteractiveOn_90(HandleRef pThis);

		/// <summary>
		/// Turn on/off interactive status.  An interactive renderer is one that
		/// can receive events from an interactor.  Should only be set if
		/// there are multiple renderers in the same section of the viewport.
		/// </summary>
		// Token: 0x060025A4 RID: 9636 RVA: 0x00038138 File Offset: 0x00036338
		public virtual void InteractiveOn()
		{
			vtkRenderer.vtkRenderer_InteractiveOn_90(base.GetCppThis());
		}

		// Token: 0x060025A5 RID: 9637
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderer_IsA_91(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060025A6 RID: 9638 RVA: 0x00038148 File Offset: 0x00036348
		public override int IsA(string type)
		{
			return vtkRenderer.vtkRenderer_IsA_91(base.GetCppThis(), type);
		}

		// Token: 0x060025A7 RID: 9639
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderer_IsActiveCameraCreated_92(HandleRef pThis);

		/// <summary>
		/// This method returns 1 if the ActiveCamera has already been set or
		/// automatically created by the renderer. It returns 0 if the
		/// ActiveCamera does not yet exist.
		/// </summary>
		// Token: 0x060025A8 RID: 9640 RVA: 0x00038168 File Offset: 0x00036368
		public int IsActiveCameraCreated()
		{
			return vtkRenderer.vtkRenderer_IsActiveCameraCreated_92(base.GetCppThis());
		}

		// Token: 0x060025A9 RID: 9641
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderer_IsTypeOf_93([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060025AA RID: 9642 RVA: 0x00038188 File Offset: 0x00036388
		public new static int IsTypeOf(string type)
		{
			return vtkRenderer.vtkRenderer_IsTypeOf_93(type);
		}

		// Token: 0x060025AB RID: 9643
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_LightFollowCameraOff_94(HandleRef pThis);

		/// <summary>
		/// Turn on/off the automatic repositioning of lights as the camera moves.
		/// If LightFollowCamera is on, lights that are designated as Headlights
		/// or CameraLights will be adjusted to move with this renderer's camera.
		/// If LightFollowCamera is off, the lights will not be adjusted.
		///
		/// (Note: In previous versions of vtk, this light-tracking
		/// functionality was part of the interactors, not the renderer. For
		/// backwards compatibility, the older, more limited interactor
		/// behavior is enabled by default. To disable this mode, turn the
		/// interactor's LightFollowCamera flag OFF, and leave the renderer's
		/// LightFollowCamera flag ON.)
		/// </summary>
		// Token: 0x060025AC RID: 9644 RVA: 0x000381A2 File Offset: 0x000363A2
		public virtual void LightFollowCameraOff()
		{
			vtkRenderer.vtkRenderer_LightFollowCameraOff_94(base.GetCppThis());
		}

		// Token: 0x060025AD RID: 9645
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_LightFollowCameraOn_95(HandleRef pThis);

		/// <summary>
		/// Turn on/off the automatic repositioning of lights as the camera moves.
		/// If LightFollowCamera is on, lights that are designated as Headlights
		/// or CameraLights will be adjusted to move with this renderer's camera.
		/// If LightFollowCamera is off, the lights will not be adjusted.
		///
		/// (Note: In previous versions of vtk, this light-tracking
		/// functionality was part of the interactors, not the renderer. For
		/// backwards compatibility, the older, more limited interactor
		/// behavior is enabled by default. To disable this mode, turn the
		/// interactor's LightFollowCamera flag OFF, and leave the renderer's
		/// LightFollowCamera flag ON.)
		/// </summary>
		// Token: 0x060025AE RID: 9646 RVA: 0x000381B1 File Offset: 0x000363B1
		public virtual void LightFollowCameraOn()
		{
			vtkRenderer.vtkRenderer_LightFollowCameraOn_95(base.GetCppThis());
		}

		// Token: 0x060025AF RID: 9647
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderer_MakeCamera_96(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a new Camera sutible for use with this type of Renderer.
		/// For example, a vtkMesaRenderer should create a vtkMesaCamera
		/// in this function.   The default is to just call vtkCamera::New.
		/// </summary>
		// Token: 0x060025B0 RID: 9648 RVA: 0x000381C0 File Offset: 0x000363C0
		public virtual vtkCamera MakeCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderer.vtkRenderer_MakeCamera_96(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060025B1 RID: 9649
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderer_MakeLight_97(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a new Light sutible for use with this type of Renderer.
		/// For example, a vtkMesaRenderer should create a vtkMesaLight
		/// in this function.   The default is to just call vtkLight::New.
		/// </summary>
		// Token: 0x060025B2 RID: 9650 RVA: 0x00038230 File Offset: 0x00036430
		public virtual vtkLight MakeLight()
		{
			vtkLight vtkLight = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderer.vtkRenderer_MakeLight_97(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLight = (vtkLight)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLight.Register(null);
				}
			}
			return vtkLight;
		}

		// Token: 0x060025B3 RID: 9651
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderer_NewInstance_99(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060025B4 RID: 9652 RVA: 0x000382A0 File Offset: 0x000364A0
		public new vtkRenderer NewInstance()
		{
			vtkRenderer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderer.vtkRenderer_NewInstance_99(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060025B5 RID: 9653
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderer_PickProp_100(HandleRef pThis, double selectionX, double selectionY, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the prop (via a vtkAssemblyPath) that has the highest z value
		/// at the given x, y position in the viewport.  Basically, the top most
		/// prop that renders the pixel at selectionX, selectionY will be returned.
		/// If nothing was picked then NULL is returned.  This method selects from
		/// the renderer's Prop list.
		/// </summary>
		// Token: 0x060025B6 RID: 9654 RVA: 0x000382FC File Offset: 0x000364FC
		public override vtkAssemblyPath PickProp(double selectionX, double selectionY)
		{
			vtkAssemblyPath vtkAssemblyPath = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderer.vtkRenderer_PickProp_100(base.GetCppThis(), selectionX, selectionY, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssemblyPath = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssemblyPath.Register(null);
				}
			}
			return vtkAssemblyPath;
		}

		// Token: 0x060025B7 RID: 9655
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderer_PickProp_101(HandleRef pThis, double selectionX1, double selectionY1, double selectionX2, double selectionY2, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the prop (via a vtkAssemblyPath) that has the highest z value
		/// at the given x, y position in the viewport.  Basically, the top most
		/// prop that renders the pixel at selectionX, selectionY will be returned.
		/// If nothing was picked then NULL is returned.  This method selects from
		/// the renderer's Prop list.
		/// </summary>
		// Token: 0x060025B8 RID: 9656 RVA: 0x00038370 File Offset: 0x00036570
		public override vtkAssemblyPath PickProp(double selectionX1, double selectionY1, double selectionX2, double selectionY2)
		{
			vtkAssemblyPath vtkAssemblyPath = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderer.vtkRenderer_PickProp_101(base.GetCppThis(), selectionX1, selectionY1, selectionX2, selectionY2, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssemblyPath = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssemblyPath.Register(null);
				}
			}
			return vtkAssemblyPath;
		}

		// Token: 0x060025B9 RID: 9657
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_PoseToView_102(HandleRef pThis, ref double wx, ref double wy, ref double wz);

		/// <summary>
		/// Convert to from pose coordinates
		/// </summary>
		// Token: 0x060025BA RID: 9658 RVA: 0x000383E4 File Offset: 0x000365E4
		public override void PoseToView(ref double wx, ref double wy, ref double wz)
		{
			vtkRenderer.vtkRenderer_PoseToView_102(base.GetCppThis(), ref wx, ref wy, ref wz);
		}

		// Token: 0x060025BB RID: 9659
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_PoseToWorld_103(HandleRef pThis, ref double wx, ref double wy, ref double wz);

		/// <summary>
		/// Convert to from pose coordinates
		/// </summary>
		// Token: 0x060025BC RID: 9660 RVA: 0x000383F6 File Offset: 0x000365F6
		public override void PoseToWorld(ref double wx, ref double wy, ref double wz)
		{
			vtkRenderer.vtkRenderer_PoseToWorld_103(base.GetCppThis(), ref wx, ref wy, ref wz);
		}

		// Token: 0x060025BD RID: 9661
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_PreserveColorBufferOff_104(HandleRef pThis);

		/// <summary>
		/// By default, the renderer at layer 0 is opaque, and all non-zero layer
		/// renderers are transparent. This flag allows this behavior to be overridden.
		/// If true, this setting will force the renderer to preserve the existing
		/// color buffer regardless of layer. If false, it will always be cleared at
		/// the start of rendering.
		///
		/// This flag influences the Transparent() method, and is updated by calls to
		/// SetLayer(). For this reason it should only be set after changing the layer.
		/// </summary>
		// Token: 0x060025BE RID: 9662 RVA: 0x00038408 File Offset: 0x00036608
		public virtual void PreserveColorBufferOff()
		{
			vtkRenderer.vtkRenderer_PreserveColorBufferOff_104(base.GetCppThis());
		}

		// Token: 0x060025BF RID: 9663
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_PreserveColorBufferOn_105(HandleRef pThis);

		/// <summary>
		/// By default, the renderer at layer 0 is opaque, and all non-zero layer
		/// renderers are transparent. This flag allows this behavior to be overridden.
		/// If true, this setting will force the renderer to preserve the existing
		/// color buffer regardless of layer. If false, it will always be cleared at
		/// the start of rendering.
		///
		/// This flag influences the Transparent() method, and is updated by calls to
		/// SetLayer(). For this reason it should only be set after changing the layer.
		/// </summary>
		// Token: 0x060025C0 RID: 9664 RVA: 0x00038417 File Offset: 0x00036617
		public virtual void PreserveColorBufferOn()
		{
			vtkRenderer.vtkRenderer_PreserveColorBufferOn_105(base.GetCppThis());
		}

		// Token: 0x060025C1 RID: 9665
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_PreserveDepthBufferOff_106(HandleRef pThis);

		/// <summary>
		/// By default, the depth buffer is reset for each renderer. If this flag is
		/// true, this renderer will use the existing depth buffer for its rendering.
		/// </summary>
		// Token: 0x060025C2 RID: 9666 RVA: 0x00038426 File Offset: 0x00036626
		public virtual void PreserveDepthBufferOff()
		{
			vtkRenderer.vtkRenderer_PreserveDepthBufferOff_106(base.GetCppThis());
		}

		// Token: 0x060025C3 RID: 9667
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_PreserveDepthBufferOn_107(HandleRef pThis);

		/// <summary>
		/// By default, the depth buffer is reset for each renderer. If this flag is
		/// true, this renderer will use the existing depth buffer for its rendering.
		/// </summary>
		// Token: 0x060025C4 RID: 9668 RVA: 0x00038435 File Offset: 0x00036635
		public virtual void PreserveDepthBufferOn()
		{
			vtkRenderer.vtkRenderer_PreserveDepthBufferOn_107(base.GetCppThis());
		}

		// Token: 0x060025C5 RID: 9669
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_ReleaseGraphicsResources_108(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get whether this viewport should have a textured background.
		/// Default is off.
		/// </summary>
		// Token: 0x060025C6 RID: 9670 RVA: 0x00038444 File Offset: 0x00036644
		public virtual void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkRenderer.vtkRenderer_ReleaseGraphicsResources_108(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060025C7 RID: 9671
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_RemoveActor_109(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Add/Remove different types of props to the renderer.
		/// These methods are all synonyms to AddViewProp and RemoveViewProp.
		/// They are here for convenience and backwards compatibility.
		/// </summary>
		// Token: 0x060025C8 RID: 9672 RVA: 0x00038474 File Offset: 0x00036674
		public void RemoveActor(vtkProp p)
		{
			vtkRenderer.vtkRenderer_RemoveActor_109(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x060025C9 RID: 9673
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_RemoveAllLights_110(HandleRef pThis);

		/// <summary>
		/// Remove all lights from the list of lights.
		/// </summary>
		// Token: 0x060025CA RID: 9674 RVA: 0x000384A3 File Offset: 0x000366A3
		public void RemoveAllLights()
		{
			vtkRenderer.vtkRenderer_RemoveAllLights_110(base.GetCppThis());
		}

		// Token: 0x060025CB RID: 9675
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_RemoveCuller_111(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Remove an actor from the list of cullers.
		/// </summary>
		// Token: 0x060025CC RID: 9676 RVA: 0x000384B4 File Offset: 0x000366B4
		public void RemoveCuller(vtkCuller arg0)
		{
			vtkRenderer.vtkRenderer_RemoveCuller_111(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060025CD RID: 9677
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_RemoveLight_112(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Remove a light from the list of lights.
		/// </summary>
		// Token: 0x060025CE RID: 9678 RVA: 0x000384E4 File Offset: 0x000366E4
		public void RemoveLight(vtkLight arg0)
		{
			vtkRenderer.vtkRenderer_RemoveLight_112(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060025CF RID: 9679
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_RemoveVolume_113(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Add/Remove different types of props to the renderer.
		/// These methods are all synonyms to AddViewProp and RemoveViewProp.
		/// They are here for convenience and backwards compatibility.
		/// </summary>
		// Token: 0x060025D0 RID: 9680 RVA: 0x00038514 File Offset: 0x00036714
		public void RemoveVolume(vtkProp p)
		{
			vtkRenderer.vtkRenderer_RemoveVolume_113(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x060025D1 RID: 9681
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_Render_114(HandleRef pThis);

		/// <summary>
		/// CALLED BY vtkRenderWindow ONLY. End-user pass your way and call
		/// vtkRenderWindow::Render().
		/// Create an image. This is a superclass method which will in turn
		/// call the DeviceRender method of Subclasses of vtkRenderer.
		/// </summary>
		// Token: 0x060025D2 RID: 9682 RVA: 0x00038543 File Offset: 0x00036743
		public virtual void Render()
		{
			vtkRenderer.vtkRenderer_Render_114(base.GetCppThis());
		}

		// Token: 0x060025D3 RID: 9683
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_ResetCamera_115(HandleRef pThis);

		/// <summary>
		/// Automatically set up the camera based on the visible actors.
		/// The camera will reposition itself to view the center point of the actors,
		/// and move along its initial view plane normal (i.e., vector defined from
		/// camera position to focal point) so that all of the actors can be seen.
		/// </summary>
		// Token: 0x060025D4 RID: 9684 RVA: 0x00038552 File Offset: 0x00036752
		public virtual void ResetCamera()
		{
			vtkRenderer.vtkRenderer_ResetCamera_115(base.GetCppThis());
		}

		// Token: 0x060025D5 RID: 9685
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_ResetCamera_116(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Automatically set up the camera based on a specified bounding box
		/// (xmin, xmax, ymin, ymax, zmin, zmax). Camera will reposition itself so
		/// that its focal point is the center of the bounding box, and adjust its
		/// distance and position to preserve its initial view plane normal
		/// (i.e., vector defined from camera position to focal point). Note: if
		/// the view plane is parallel to the view up axis, the view up axis will
		/// be reset to one of the three coordinate axes.
		/// </summary>
		// Token: 0x060025D6 RID: 9686 RVA: 0x00038561 File Offset: 0x00036761
		public virtual void ResetCamera(IntPtr bounds)
		{
			vtkRenderer.vtkRenderer_ResetCamera_116(base.GetCppThis(), bounds);
		}

		// Token: 0x060025D7 RID: 9687
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_ResetCamera_117(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		/// <summary>
		/// Alternative version of ResetCamera(bounds[6]);
		/// </summary>
		// Token: 0x060025D8 RID: 9688 RVA: 0x00038571 File Offset: 0x00036771
		public virtual void ResetCamera(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkRenderer.vtkRenderer_ResetCamera_117(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		// Token: 0x060025D9 RID: 9689
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_ResetCameraClippingRange_118(HandleRef pThis);

		/// <summary>
		/// Reset the camera clipping range based on the bounds of the
		/// visible actors. This ensures that no props are cut off
		/// </summary>
		// Token: 0x060025DA RID: 9690 RVA: 0x00038589 File Offset: 0x00036789
		public virtual void ResetCameraClippingRange()
		{
			vtkRenderer.vtkRenderer_ResetCameraClippingRange_118(base.GetCppThis());
		}

		// Token: 0x060025DB RID: 9691
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_ResetCameraClippingRange_119(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Reset the camera clipping range based on a bounding box.
		/// </summary>
		// Token: 0x060025DC RID: 9692 RVA: 0x00038598 File Offset: 0x00036798
		public virtual void ResetCameraClippingRange(IntPtr bounds)
		{
			vtkRenderer.vtkRenderer_ResetCameraClippingRange_119(base.GetCppThis(), bounds);
		}

		// Token: 0x060025DD RID: 9693
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_ResetCameraClippingRange_120(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		/// <summary>
		/// Reset the camera clipping range based on a bounding box.
		/// </summary>
		// Token: 0x060025DE RID: 9694 RVA: 0x000385A8 File Offset: 0x000367A8
		public virtual void ResetCameraClippingRange(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkRenderer.vtkRenderer_ResetCameraClippingRange_120(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		// Token: 0x060025DF RID: 9695
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_ResetCameraScreenSpace_121(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, double offsetRatio);

		/// <summary>
		/// Alternative version of ResetCameraScreenSpace(bounds[6]);
		///
		/// OffsetRatio can be used to add a zoom offset.
		/// Default value is 0.9, which means that the camera will be 10% further from the data.
		/// </summary>
		// Token: 0x060025E0 RID: 9696 RVA: 0x000385C0 File Offset: 0x000367C0
		public virtual void ResetCameraScreenSpace(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, double offsetRatio)
		{
			vtkRenderer.vtkRenderer_ResetCameraScreenSpace_121(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax, offsetRatio);
		}

		// Token: 0x060025E1 RID: 9697
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_ResetCameraScreenSpace_122(HandleRef pThis, double offsetRatio);

		/// <summary>
		/// Automatically set up the camera based on the visible actors.
		/// Use a screen space bounding box to zoom closer to the data.
		///
		/// OffsetRatio can be used to add a zoom offset.
		/// Default value is 0.9, which means that the camera will be 10% further from the data
		/// </summary>
		// Token: 0x060025E2 RID: 9698 RVA: 0x000385DA File Offset: 0x000367DA
		public virtual void ResetCameraScreenSpace(double offsetRatio)
		{
			vtkRenderer.vtkRenderer_ResetCameraScreenSpace_122(base.GetCppThis(), offsetRatio);
		}

		// Token: 0x060025E3 RID: 9699
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_ResetCameraScreenSpace_123(HandleRef pThis, IntPtr bounds, double offsetRatio);

		/// <summary>
		/// Automatically set up the camera based on a specified bounding box
		/// (xmin, xmax, ymin, ymax, zmin, zmax).
		/// Use a screen space bounding box to zoom closer to the data.
		///
		/// OffsetRatio can be used to add a zoom offset.
		/// Default value is 0.9, which means that the camera will be 10% further from the data.
		/// </summary>
		// Token: 0x060025E4 RID: 9700 RVA: 0x000385EA File Offset: 0x000367EA
		public virtual void ResetCameraScreenSpace(IntPtr bounds, double offsetRatio)
		{
			vtkRenderer.vtkRenderer_ResetCameraScreenSpace_123(base.GetCppThis(), bounds, offsetRatio);
		}

		// Token: 0x060025E5 RID: 9701
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SSAOBlurOff_124(HandleRef pThis);

		/// <summary>
		/// When using SSAO, define blurring of the ambient occlusion.
		/// Blurring can help to improve the result if samples number is low.
		/// Default is false
		/// </summary>
		// Token: 0x060025E6 RID: 9702 RVA: 0x000385FB File Offset: 0x000367FB
		public virtual void SSAOBlurOff()
		{
			vtkRenderer.vtkRenderer_SSAOBlurOff_124(base.GetCppThis());
		}

		// Token: 0x060025E7 RID: 9703
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SSAOBlurOn_125(HandleRef pThis);

		/// <summary>
		/// When using SSAO, define blurring of the ambient occlusion.
		/// Blurring can help to improve the result if samples number is low.
		/// Default is false
		/// </summary>
		// Token: 0x060025E8 RID: 9704 RVA: 0x0003860A File Offset: 0x0003680A
		public virtual void SSAOBlurOn()
		{
			vtkRenderer.vtkRenderer_SSAOBlurOn_125(base.GetCppThis());
		}

		// Token: 0x060025E9 RID: 9705
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderer_SafeDownCast_126(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060025EA RID: 9706 RVA: 0x0003861C File Offset: 0x0003681C
		public new static vtkRenderer SafeDownCast(vtkObjectBase o)
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderer.vtkRenderer_SafeDownCast_126((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		// Token: 0x060025EB RID: 9707
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetActiveCamera_127(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the camera to use for this renderer.
		/// </summary>
		// Token: 0x060025EC RID: 9708 RVA: 0x0003869C File Offset: 0x0003689C
		public void SetActiveCamera(vtkCamera arg0)
		{
			vtkRenderer.vtkRenderer_SetActiveCamera_127(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060025ED RID: 9709
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetAllocatedRenderTime_128(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the amount of time this renderer is allowed to spend
		/// rendering its scene. This is used by vtkLODActor's.
		/// </summary>
		// Token: 0x060025EE RID: 9710 RVA: 0x000386CB File Offset: 0x000368CB
		public virtual void SetAllocatedRenderTime(double _arg)
		{
			vtkRenderer.vtkRenderer_SetAllocatedRenderTime_128(base.GetCppThis(), _arg);
		}

		// Token: 0x060025EF RID: 9711
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetAmbient_129(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the intensity of ambient lighting.
		/// </summary>
		// Token: 0x060025F0 RID: 9712 RVA: 0x000386DB File Offset: 0x000368DB
		public virtual void SetAmbient(double _arg1, double _arg2, double _arg3)
		{
			vtkRenderer.vtkRenderer_SetAmbient_129(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060025F1 RID: 9713
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetAmbient_130(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the intensity of ambient lighting.
		/// </summary>
		// Token: 0x060025F2 RID: 9714 RVA: 0x000386ED File Offset: 0x000368ED
		public virtual void SetAmbient(IntPtr _arg)
		{
			vtkRenderer.vtkRenderer_SetAmbient_130(base.GetCppThis(), _arg);
		}

		// Token: 0x060025F3 RID: 9715
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetAutomaticLightCreation_131(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off a flag which disables the automatic light creation capability.
		/// Normally in VTK if no lights are associated with the renderer, then a light
		/// is automatically created. However, in special circumstances this feature is
		/// undesirable, so the following boolean is provided to disable automatic
		/// light creation. (Turn AutomaticLightCreation off if you do not want lights
		/// to be created.)
		/// </summary>
		// Token: 0x060025F4 RID: 9716 RVA: 0x000386FD File Offset: 0x000368FD
		public virtual void SetAutomaticLightCreation(int _arg)
		{
			vtkRenderer.vtkRenderer_SetAutomaticLightCreation_131(base.GetCppThis(), _arg);
		}

		// Token: 0x060025F5 RID: 9717
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetBackgroundTexture_132(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the texture to be used for the monocular or stereo left eye
		/// background. If set and enabled this gets the priority over the gradient
		/// background.
		/// </summary>
		// Token: 0x060025F6 RID: 9718 RVA: 0x00038710 File Offset: 0x00036910
		public virtual void SetBackgroundTexture(vtkTexture arg0)
		{
			vtkRenderer.vtkRenderer_SetBackgroundTexture_132(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060025F7 RID: 9719
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetBackingStore_133(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off using backing store. This may cause the re-rendering
		/// time to be slightly slower when the view changes. But it is
		/// much faster when the image has not changed, such as during an
		/// expose event.
		/// </summary>
		// Token: 0x060025F8 RID: 9720 RVA: 0x0003873F File Offset: 0x0003693F
		public virtual void SetBackingStore(int _arg)
		{
			vtkRenderer.vtkRenderer_SetBackingStore_133(base.GetCppThis(), _arg);
		}

		// Token: 0x060025F9 RID: 9721
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetClippingRangeExpansion_134(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify enlargement of bounds when resetting the
		/// camera clipping range.  By default the range is not expanded by
		/// any percent of the (far - near) on the near and far sides
		/// </summary>
		// Token: 0x060025FA RID: 9722 RVA: 0x0003874F File Offset: 0x0003694F
		public virtual void SetClippingRangeExpansion(double _arg)
		{
			vtkRenderer.vtkRenderer_SetClippingRangeExpansion_134(base.GetCppThis(), _arg);
		}

		// Token: 0x060025FB RID: 9723
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetDelegate_135(HandleRef pThis, HandleRef d);

		/// <summary>
		/// Set/Get a custom Render call. Allows to hook a Render call from an
		/// external project.It will be used in place of vtkRenderer::Render() if it
		/// is not NULL and its Used ivar is set to true.
		/// Initial value is NULL.
		/// </summary>
		// Token: 0x060025FC RID: 9724 RVA: 0x00038760 File Offset: 0x00036960
		public void SetDelegate(vtkRendererDelegate d)
		{
			vtkRenderer.vtkRenderer_SetDelegate_135(base.GetCppThis(), (d == null) ? default(HandleRef) : d.GetCppThis());
		}

		// Token: 0x060025FD RID: 9725
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetDraw_136(HandleRef pThis, int _arg);

		/// <summary>
		/// When this flag is off, render commands are ignored.  It is used to either
		/// multiplex a vtkRenderWindow or render only part of a vtkRenderWindow.
		/// By default, Draw is on.
		/// </summary>
		// Token: 0x060025FE RID: 9726 RVA: 0x0003878F File Offset: 0x0003698F
		public virtual void SetDraw(int _arg)
		{
			vtkRenderer.vtkRenderer_SetDraw_136(base.GetCppThis(), _arg);
		}

		// Token: 0x060025FF RID: 9727
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetEnvironmentRight_137(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the environment right vector.
		/// </summary>
		// Token: 0x06002600 RID: 9728 RVA: 0x0003879F File Offset: 0x0003699F
		public virtual void SetEnvironmentRight(double _arg1, double _arg2, double _arg3)
		{
			vtkRenderer.vtkRenderer_SetEnvironmentRight_137(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06002601 RID: 9729
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetEnvironmentRight_138(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the environment right vector.
		/// </summary>
		// Token: 0x06002602 RID: 9730 RVA: 0x000387B1 File Offset: 0x000369B1
		public virtual void SetEnvironmentRight(IntPtr _arg)
		{
			vtkRenderer.vtkRenderer_SetEnvironmentRight_138(base.GetCppThis(), _arg);
		}

		// Token: 0x06002603 RID: 9731
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetEnvironmentTexture_139(HandleRef pThis, HandleRef texture, byte isSRGB);

		/// <summary>
		/// Set/Get the environment texture used for image based lighting.
		/// This texture is supposed to represent the scene background.
		/// @sa vtkTexture::UseSRGBColorSpaceOn
		/// </summary>
		// Token: 0x06002604 RID: 9732 RVA: 0x000387C4 File Offset: 0x000369C4
		public virtual void SetEnvironmentTexture(vtkTexture texture, bool isSRGB)
		{
			vtkRenderer.vtkRenderer_SetEnvironmentTexture_139(base.GetCppThis(), (texture == null) ? default(HandleRef) : texture.GetCppThis(), isSRGB ? (byte)1 : (byte)0);
		}

		// Token: 0x06002605 RID: 9733
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetEnvironmentUp_140(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the environment up vector.
		/// </summary>
		// Token: 0x06002606 RID: 9734 RVA: 0x000387FC File Offset: 0x000369FC
		public virtual void SetEnvironmentUp(double _arg1, double _arg2, double _arg3)
		{
			vtkRenderer.vtkRenderer_SetEnvironmentUp_140(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06002607 RID: 9735
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetEnvironmentUp_141(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the environment up vector.
		/// </summary>
		// Token: 0x06002608 RID: 9736 RVA: 0x0003880E File Offset: 0x00036A0E
		public virtual void SetEnvironmentUp(IntPtr _arg)
		{
			vtkRenderer.vtkRenderer_SetEnvironmentUp_141(base.GetCppThis(), _arg);
		}

		// Token: 0x06002609 RID: 9737
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetErase_142(HandleRef pThis, int _arg);

		/// <summary>
		/// When this flag is off, the renderer will not erase the background
		/// or the Zbuffer.  It is used to have overlapping renderers.
		/// Both the RenderWindow Erase and Render Erase must be on
		/// for the camera to clear the renderer.  By default, Erase is on.
		/// </summary>
		// Token: 0x0600260A RID: 9738 RVA: 0x0003881E File Offset: 0x00036A1E
		public virtual void SetErase(int _arg)
		{
			vtkRenderer.vtkRenderer_SetErase_142(base.GetCppThis(), _arg);
		}

		// Token: 0x0600260B RID: 9739
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetFXAAOptions_143(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// The configuration object for FXAA antialiasing.
		/// </summary>
		// Token: 0x0600260C RID: 9740 RVA: 0x00038830 File Offset: 0x00036A30
		public virtual void SetFXAAOptions(vtkFXAAOptions arg0)
		{
			vtkRenderer.vtkRenderer_SetFXAAOptions_143(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600260D RID: 9741
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetGL2PSSpecialPropCollection_144(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the prop collection object used during
		/// vtkRenderWindow::CaptureGL2PSSpecialProps(). Do not call manually, this
		/// is handled automatically by the render window.
		/// </summary>
		// Token: 0x0600260E RID: 9742 RVA: 0x00038860 File Offset: 0x00036A60
		public void SetGL2PSSpecialPropCollection(vtkPropCollection arg0)
		{
			vtkRenderer.vtkRenderer_SetGL2PSSpecialPropCollection_144(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600260F RID: 9743
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetInformation_145(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the information object associated with this algorithm.
		/// </summary>
		// Token: 0x06002610 RID: 9744 RVA: 0x00038890 File Offset: 0x00036A90
		public virtual void SetInformation(vtkInformation arg0)
		{
			vtkRenderer.vtkRenderer_SetInformation_145(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002611 RID: 9745
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetInteractive_146(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off interactive status.  An interactive renderer is one that
		/// can receive events from an interactor.  Should only be set if
		/// there are multiple renderers in the same section of the viewport.
		/// </summary>
		// Token: 0x06002612 RID: 9746 RVA: 0x000388BF File Offset: 0x00036ABF
		public virtual void SetInteractive(int _arg)
		{
			vtkRenderer.vtkRenderer_SetInteractive_146(base.GetCppThis(), _arg);
		}

		// Token: 0x06002613 RID: 9747
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetLayer_147(HandleRef pThis, int layer);

		/// <summary>
		/// Set/Get the layer that this renderer belongs to.  This is only used if
		/// there are layered renderers.
		///
		/// Note: Changing the layer will update the PreserveColorBuffer setting. If
		/// the layer is 0, PreserveColorBuffer will be set to false, making the
		/// bottom renderer opaque. If the layer is non-zero, PreserveColorBuffer will
		/// be set to true, giving the renderer a transparent background. If other
		/// PreserveColorBuffer configurations are desired, they must be adjusted after
		/// the layer is set.
		/// </summary>
		// Token: 0x06002614 RID: 9748 RVA: 0x000388CF File Offset: 0x00036ACF
		public virtual void SetLayer(int layer)
		{
			vtkRenderer.vtkRenderer_SetLayer_147(base.GetCppThis(), layer);
		}

		// Token: 0x06002615 RID: 9749
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetLeftBackgroundTexture_148(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the texture to be used for the monocular or stereo left eye
		/// background. If set and enabled this gets the priority over the gradient
		/// background.
		/// </summary>
		// Token: 0x06002616 RID: 9750 RVA: 0x000388E0 File Offset: 0x00036AE0
		public virtual void SetLeftBackgroundTexture(vtkTexture arg0)
		{
			vtkRenderer.vtkRenderer_SetLeftBackgroundTexture_148(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002617 RID: 9751
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetLightCollection_149(HandleRef pThis, HandleRef lights);

		/// <summary>
		/// Set the collection of lights.
		/// We cannot name it SetLights because of TestSetGet
		/// \pre lights_exist: lights!=0
		/// \post lights_set: lights==this-&gt;GetLights()
		/// </summary>
		// Token: 0x06002618 RID: 9752 RVA: 0x00038910 File Offset: 0x00036B10
		public void SetLightCollection(vtkLightCollection lights)
		{
			vtkRenderer.vtkRenderer_SetLightCollection_149(base.GetCppThis(), (lights == null) ? default(HandleRef) : lights.GetCppThis());
		}

		// Token: 0x06002619 RID: 9753
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetLightFollowCamera_150(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the automatic repositioning of lights as the camera moves.
		/// If LightFollowCamera is on, lights that are designated as Headlights
		/// or CameraLights will be adjusted to move with this renderer's camera.
		/// If LightFollowCamera is off, the lights will not be adjusted.
		///
		/// (Note: In previous versions of vtk, this light-tracking
		/// functionality was part of the interactors, not the renderer. For
		/// backwards compatibility, the older, more limited interactor
		/// behavior is enabled by default. To disable this mode, turn the
		/// interactor's LightFollowCamera flag OFF, and leave the renderer's
		/// LightFollowCamera flag ON.)
		/// </summary>
		// Token: 0x0600261A RID: 9754 RVA: 0x0003893F File Offset: 0x00036B3F
		public virtual void SetLightFollowCamera(int _arg)
		{
			vtkRenderer.vtkRenderer_SetLightFollowCamera_150(base.GetCppThis(), _arg);
		}

		// Token: 0x0600261B RID: 9755
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetMaximumNumberOfPeels_151(HandleRef pThis, int _arg);

		/// <summary>
		/// In case of depth peeling, define the maximum number of peeling layers.
		/// Initial value is 4. A special value of 0 means no maximum limit.
		/// It has to be a positive value.
		/// </summary>
		// Token: 0x0600261C RID: 9756 RVA: 0x0003894F File Offset: 0x00036B4F
		public virtual void SetMaximumNumberOfPeels(int _arg)
		{
			vtkRenderer.vtkRenderer_SetMaximumNumberOfPeels_151(base.GetCppThis(), _arg);
		}

		// Token: 0x0600261D RID: 9757
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetNearClippingPlaneTolerance_152(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify tolerance for near clipping plane distance to the camera as a
		/// percentage of the far clipping plane distance. By default this will be
		/// set to 0.01 for 16 bit zbuffers and 0.001 for higher depth z buffers
		/// </summary>
		// Token: 0x0600261E RID: 9758 RVA: 0x0003895F File Offset: 0x00036B5F
		public virtual void SetNearClippingPlaneTolerance(double _arg)
		{
			vtkRenderer.vtkRenderer_SetNearClippingPlaneTolerance_152(base.GetCppThis(), _arg);
		}

		// Token: 0x0600261F RID: 9759
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetOcclusionRatio_153(HandleRef pThis, double _arg);

		/// <summary>
		/// In case of use of depth peeling technique for rendering translucent
		/// material, define the threshold under which the algorithm stops to
		/// iterate over peel layers. This is the ratio of the number of pixels
		/// that have been touched by the last layer over the total number of pixels
		/// of the viewport area.
		/// Initial value is 0.0, meaning rendering have to be exact. Greater values
		/// may speed-up the rendering with small impact on the quality.
		/// </summary>
		// Token: 0x06002620 RID: 9760 RVA: 0x0003896F File Offset: 0x00036B6F
		public virtual void SetOcclusionRatio(double _arg)
		{
			vtkRenderer.vtkRenderer_SetOcclusionRatio_153(base.GetCppThis(), _arg);
		}

		// Token: 0x06002621 RID: 9761
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetPass_154(HandleRef pThis, HandleRef p);

		/// <summary>
		/// If this flag is true and the rendering engine supports it, wireframe
		/// geometry will be drawn using hidden line removal.
		/// </summary>
		// Token: 0x06002622 RID: 9762 RVA: 0x00038980 File Offset: 0x00036B80
		public void SetPass(vtkRenderPass p)
		{
			vtkRenderer.vtkRenderer_SetPass_154(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x06002623 RID: 9763
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetPreserveColorBuffer_155(HandleRef pThis, int _arg);

		/// <summary>
		/// By default, the renderer at layer 0 is opaque, and all non-zero layer
		/// renderers are transparent. This flag allows this behavior to be overridden.
		/// If true, this setting will force the renderer to preserve the existing
		/// color buffer regardless of layer. If false, it will always be cleared at
		/// the start of rendering.
		///
		/// This flag influences the Transparent() method, and is updated by calls to
		/// SetLayer(). For this reason it should only be set after changing the layer.
		/// </summary>
		// Token: 0x06002624 RID: 9764 RVA: 0x000389AF File Offset: 0x00036BAF
		public virtual void SetPreserveColorBuffer(int _arg)
		{
			vtkRenderer.vtkRenderer_SetPreserveColorBuffer_155(base.GetCppThis(), _arg);
		}

		// Token: 0x06002625 RID: 9765
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetPreserveDepthBuffer_156(HandleRef pThis, int _arg);

		/// <summary>
		/// By default, the depth buffer is reset for each renderer. If this flag is
		/// true, this renderer will use the existing depth buffer for its rendering.
		/// </summary>
		// Token: 0x06002626 RID: 9766 RVA: 0x000389BF File Offset: 0x00036BBF
		public virtual void SetPreserveDepthBuffer(int _arg)
		{
			vtkRenderer.vtkRenderer_SetPreserveDepthBuffer_156(base.GetCppThis(), _arg);
		}

		// Token: 0x06002627 RID: 9767
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetRenderWindow_157(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the rendering window in which to draw. This is automatically set
		/// when the renderer is created by MakeRenderer.  The user probably
		/// shouldn't ever need to call this method.
		/// </summary>
		// Token: 0x06002628 RID: 9768 RVA: 0x000389D0 File Offset: 0x00036BD0
		public void SetRenderWindow(vtkRenderWindow arg0)
		{
			vtkRenderer.vtkRenderer_SetRenderWindow_157(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002629 RID: 9769
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetRightBackgroundTexture_158(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the texture to be used for the right eye background. If set
		/// and enabled this gets the priority over the gradient background.
		/// </summary>
		// Token: 0x0600262A RID: 9770 RVA: 0x00038A00 File Offset: 0x00036C00
		public virtual void SetRightBackgroundTexture(vtkTexture arg0)
		{
			vtkRenderer.vtkRenderer_SetRightBackgroundTexture_158(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600262B RID: 9771
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetSSAOBias_159(HandleRef pThis, double _arg);

		/// <summary>
		/// When using SSAO, define the bias when comparing samples.
		/// Default is 0.01
		/// </summary>
		// Token: 0x0600262C RID: 9772 RVA: 0x00038A2F File Offset: 0x00036C2F
		public virtual void SetSSAOBias(double _arg)
		{
			vtkRenderer.vtkRenderer_SetSSAOBias_159(base.GetCppThis(), _arg);
		}

		// Token: 0x0600262D RID: 9773
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetSSAOBlur_160(HandleRef pThis, byte _arg);

		/// <summary>
		/// When using SSAO, define blurring of the ambient occlusion.
		/// Blurring can help to improve the result if samples number is low.
		/// Default is false
		/// </summary>
		// Token: 0x0600262E RID: 9774 RVA: 0x00038A3F File Offset: 0x00036C3F
		public virtual void SetSSAOBlur(bool _arg)
		{
			vtkRenderer.vtkRenderer_SetSSAOBlur_160(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600262F RID: 9775
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetSSAOKernelSize_161(HandleRef pThis, uint _arg);

		/// <summary>
		/// When using SSAO, define the number of samples.
		/// Default is 32
		/// </summary>
		// Token: 0x06002630 RID: 9776 RVA: 0x00038A57 File Offset: 0x00036C57
		public virtual void SetSSAOKernelSize(uint _arg)
		{
			vtkRenderer.vtkRenderer_SetSSAOKernelSize_161(base.GetCppThis(), _arg);
		}

		// Token: 0x06002631 RID: 9777
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetSSAORadius_162(HandleRef pThis, double _arg);

		/// <summary>
		/// When using SSAO, define the SSAO hemisphere radius.
		/// Default is 0.5
		/// </summary>
		// Token: 0x06002632 RID: 9778 RVA: 0x00038A67 File Offset: 0x00036C67
		public virtual void SetSSAORadius(double _arg)
		{
			vtkRenderer.vtkRenderer_SetSSAORadius_162(base.GetCppThis(), _arg);
		}

		// Token: 0x06002633 RID: 9779
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetTexturedBackground_163(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get whether this viewport should have a textured background.
		/// Default is off.
		/// </summary>
		// Token: 0x06002634 RID: 9780 RVA: 0x00038A77 File Offset: 0x00036C77
		public virtual void SetTexturedBackground(bool _arg)
		{
			vtkRenderer.vtkRenderer_SetTexturedBackground_163(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06002635 RID: 9781
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetTwoSidedLighting_164(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off two-sided lighting of surfaces. If two-sided lighting is
		/// off, then only the side of the surface facing the light(s) will be lit,
		/// and the other side dark. If two-sided lighting on, both sides of the
		/// surface will be lit.
		/// </summary>
		// Token: 0x06002636 RID: 9782 RVA: 0x00038A8F File Offset: 0x00036C8F
		public virtual void SetTwoSidedLighting(int _arg)
		{
			vtkRenderer.vtkRenderer_SetTwoSidedLighting_164(base.GetCppThis(), _arg);
		}

		// Token: 0x06002637 RID: 9783
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetUseDepthPeeling_165(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off rendering of translucent material with depth peeling
		/// technique. The render window must have alpha bits (ie call
		/// SetAlphaBitPlanes(1)) and no multisample buffer (ie call
		/// SetMultiSamples(0) ) to support depth peeling.
		/// If UseDepthPeeling is on and the GPU supports it, depth peeling is used
		/// for rendering translucent materials.
		/// If UseDepthPeeling is off, alpha blending is used.
		/// Initial value is off.
		/// </summary>
		// Token: 0x06002638 RID: 9784 RVA: 0x00038A9F File Offset: 0x00036C9F
		public virtual void SetUseDepthPeeling(int _arg)
		{
			vtkRenderer.vtkRenderer_SetUseDepthPeeling_165(base.GetCppThis(), _arg);
		}

		// Token: 0x06002639 RID: 9785
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetUseDepthPeelingForVolumes_166(HandleRef pThis, byte _arg);

		/// <summary>
		/// This flag is on and the GPU supports it, depth-peel volumes along with
		/// the translucent geometry. Only supported on OpenGL2 with dual-depth
		/// peeling. Default is false.
		/// </summary>
		// Token: 0x0600263A RID: 9786 RVA: 0x00038AAF File Offset: 0x00036CAF
		public virtual void SetUseDepthPeelingForVolumes(bool _arg)
		{
			vtkRenderer.vtkRenderer_SetUseDepthPeelingForVolumes_166(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600263B RID: 9787
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetUseFXAA_167(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off FXAA anti-aliasing, if supported. Initial value is off.
		/// </summary>
		// Token: 0x0600263C RID: 9788 RVA: 0x00038AC7 File Offset: 0x00036CC7
		public virtual void SetUseFXAA(bool _arg)
		{
			vtkRenderer.vtkRenderer_SetUseFXAA_167(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600263D RID: 9789
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetUseHiddenLineRemoval_168(HandleRef pThis, int _arg);

		/// <summary>
		/// If this flag is true and the rendering engine supports it, wireframe
		/// geometry will be drawn using hidden line removal.
		/// </summary>
		// Token: 0x0600263E RID: 9790 RVA: 0x00038ADF File Offset: 0x00036CDF
		public virtual void SetUseHiddenLineRemoval(int _arg)
		{
			vtkRenderer.vtkRenderer_SetUseHiddenLineRemoval_168(base.GetCppThis(), _arg);
		}

		// Token: 0x0600263F RID: 9791
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetUseImageBasedLighting_169(HandleRef pThis, byte _arg);

		/// <summary>
		/// If this flag is true and the rendering engine supports it, image based
		/// lighting is enabled and surface rendering displays environment reflections.
		/// Image Based Lighting rely on the environment texture to compute lighting
		/// if it has been provided.
		/// </summary>
		// Token: 0x06002640 RID: 9792 RVA: 0x00038AEF File Offset: 0x00036CEF
		public virtual void SetUseImageBasedLighting(bool _arg)
		{
			vtkRenderer.vtkRenderer_SetUseImageBasedLighting_169(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06002641 RID: 9793
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetUseSSAO_170(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable or disable Screen Space Ambient Occlusion.
		/// SSAO darkens some pixels to improve depth perception.
		/// </summary>
		// Token: 0x06002642 RID: 9794 RVA: 0x00038B07 File Offset: 0x00036D07
		public virtual void SetUseSSAO(bool _arg)
		{
			vtkRenderer.vtkRenderer_SetUseSSAO_170(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06002643 RID: 9795
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_SetUseShadows_171(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off rendering of shadows if supported
		/// Initial value is off.
		/// </summary>
		// Token: 0x06002644 RID: 9796 RVA: 0x00038B1F File Offset: 0x00036D1F
		public virtual void SetUseShadows(int _arg)
		{
			vtkRenderer.vtkRenderer_SetUseShadows_171(base.GetCppThis(), _arg);
		}

		// Token: 0x06002645 RID: 9797
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_StereoMidpoint_172(HandleRef pThis);

		/// <summary>
		/// Do anything necessary between rendering the left and right viewpoints
		/// in a stereo render. Doesn't do anything except in the derived
		/// vtkIceTRenderer in ParaView.
		/// </summary>
		// Token: 0x06002646 RID: 9798 RVA: 0x00038B2F File Offset: 0x00036D2F
		public virtual void StereoMidpoint()
		{
			vtkRenderer.vtkRenderer_StereoMidpoint_172(base.GetCppThis());
		}

		// Token: 0x06002647 RID: 9799
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_TexturedBackgroundOff_173(HandleRef pThis);

		/// <summary>
		/// Set/Get whether this viewport should have a textured background.
		/// Default is off.
		/// </summary>
		// Token: 0x06002648 RID: 9800 RVA: 0x00038B3E File Offset: 0x00036D3E
		public virtual void TexturedBackgroundOff()
		{
			vtkRenderer.vtkRenderer_TexturedBackgroundOff_173(base.GetCppThis());
		}

		// Token: 0x06002649 RID: 9801
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_TexturedBackgroundOn_174(HandleRef pThis);

		/// <summary>
		/// Set/Get whether this viewport should have a textured background.
		/// Default is off.
		/// </summary>
		// Token: 0x0600264A RID: 9802 RVA: 0x00038B4D File Offset: 0x00036D4D
		public virtual void TexturedBackgroundOn()
		{
			vtkRenderer.vtkRenderer_TexturedBackgroundOn_174(base.GetCppThis());
		}

		// Token: 0x0600264B RID: 9803
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderer_Transparent_175(HandleRef pThis);

		/// <summary>
		/// Returns a boolean indicating if this renderer is transparent.  It is
		/// transparent if it is not in the deepest layer of its render window.
		/// </summary>
		// Token: 0x0600264C RID: 9804 RVA: 0x00038B5C File Offset: 0x00036D5C
		public int Transparent()
		{
			return vtkRenderer.vtkRenderer_Transparent_175(base.GetCppThis());
		}

		// Token: 0x0600264D RID: 9805
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_TwoSidedLightingOff_176(HandleRef pThis);

		/// <summary>
		/// Turn on/off two-sided lighting of surfaces. If two-sided lighting is
		/// off, then only the side of the surface facing the light(s) will be lit,
		/// and the other side dark. If two-sided lighting on, both sides of the
		/// surface will be lit.
		/// </summary>
		// Token: 0x0600264E RID: 9806 RVA: 0x00038B7B File Offset: 0x00036D7B
		public virtual void TwoSidedLightingOff()
		{
			vtkRenderer.vtkRenderer_TwoSidedLightingOff_176(base.GetCppThis());
		}

		// Token: 0x0600264F RID: 9807
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_TwoSidedLightingOn_177(HandleRef pThis);

		/// <summary>
		/// Turn on/off two-sided lighting of surfaces. If two-sided lighting is
		/// off, then only the side of the surface facing the light(s) will be lit,
		/// and the other side dark. If two-sided lighting on, both sides of the
		/// surface will be lit.
		/// </summary>
		// Token: 0x06002650 RID: 9808 RVA: 0x00038B8A File Offset: 0x00036D8A
		public virtual void TwoSidedLightingOn()
		{
			vtkRenderer.vtkRenderer_TwoSidedLightingOn_177(base.GetCppThis());
		}

		// Token: 0x06002651 RID: 9809
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderer_UpdateLightsGeometryToFollowCamera_178(HandleRef pThis);

		/// <summary>
		/// Ask the lights in the scene that are not in world space
		/// (for instance, Headlights or CameraLights that are attached to the
		/// camera) to update their geometry to match the active camera.
		/// </summary>
		// Token: 0x06002652 RID: 9810 RVA: 0x00038B9C File Offset: 0x00036D9C
		public virtual int UpdateLightsGeometryToFollowCamera()
		{
			return vtkRenderer.vtkRenderer_UpdateLightsGeometryToFollowCamera_178(base.GetCppThis());
		}

		// Token: 0x06002653 RID: 9811
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_UseDepthPeelingForVolumesOff_179(HandleRef pThis);

		/// <summary>
		/// This flag is on and the GPU supports it, depth-peel volumes along with
		/// the translucent geometry. Only supported on OpenGL2 with dual-depth
		/// peeling. Default is false.
		/// </summary>
		// Token: 0x06002654 RID: 9812 RVA: 0x00038BBB File Offset: 0x00036DBB
		public virtual void UseDepthPeelingForVolumesOff()
		{
			vtkRenderer.vtkRenderer_UseDepthPeelingForVolumesOff_179(base.GetCppThis());
		}

		// Token: 0x06002655 RID: 9813
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_UseDepthPeelingForVolumesOn_180(HandleRef pThis);

		/// <summary>
		/// This flag is on and the GPU supports it, depth-peel volumes along with
		/// the translucent geometry. Only supported on OpenGL2 with dual-depth
		/// peeling. Default is false.
		/// </summary>
		// Token: 0x06002656 RID: 9814 RVA: 0x00038BCA File Offset: 0x00036DCA
		public virtual void UseDepthPeelingForVolumesOn()
		{
			vtkRenderer.vtkRenderer_UseDepthPeelingForVolumesOn_180(base.GetCppThis());
		}

		// Token: 0x06002657 RID: 9815
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_UseDepthPeelingOff_181(HandleRef pThis);

		/// <summary>
		/// Turn on/off rendering of translucent material with depth peeling
		/// technique. The render window must have alpha bits (ie call
		/// SetAlphaBitPlanes(1)) and no multisample buffer (ie call
		/// SetMultiSamples(0) ) to support depth peeling.
		/// If UseDepthPeeling is on and the GPU supports it, depth peeling is used
		/// for rendering translucent materials.
		/// If UseDepthPeeling is off, alpha blending is used.
		/// Initial value is off.
		/// </summary>
		// Token: 0x06002658 RID: 9816 RVA: 0x00038BD9 File Offset: 0x00036DD9
		public virtual void UseDepthPeelingOff()
		{
			vtkRenderer.vtkRenderer_UseDepthPeelingOff_181(base.GetCppThis());
		}

		// Token: 0x06002659 RID: 9817
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_UseDepthPeelingOn_182(HandleRef pThis);

		/// <summary>
		/// Turn on/off rendering of translucent material with depth peeling
		/// technique. The render window must have alpha bits (ie call
		/// SetAlphaBitPlanes(1)) and no multisample buffer (ie call
		/// SetMultiSamples(0) ) to support depth peeling.
		/// If UseDepthPeeling is on and the GPU supports it, depth peeling is used
		/// for rendering translucent materials.
		/// If UseDepthPeeling is off, alpha blending is used.
		/// Initial value is off.
		/// </summary>
		// Token: 0x0600265A RID: 9818 RVA: 0x00038BE8 File Offset: 0x00036DE8
		public virtual void UseDepthPeelingOn()
		{
			vtkRenderer.vtkRenderer_UseDepthPeelingOn_182(base.GetCppThis());
		}

		// Token: 0x0600265B RID: 9819
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_UseFXAAOff_183(HandleRef pThis);

		/// <summary>
		/// Turn on/off FXAA anti-aliasing, if supported. Initial value is off.
		/// </summary>
		// Token: 0x0600265C RID: 9820 RVA: 0x00038BF7 File Offset: 0x00036DF7
		public virtual void UseFXAAOff()
		{
			vtkRenderer.vtkRenderer_UseFXAAOff_183(base.GetCppThis());
		}

		// Token: 0x0600265D RID: 9821
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_UseFXAAOn_184(HandleRef pThis);

		/// <summary>
		/// Turn on/off FXAA anti-aliasing, if supported. Initial value is off.
		/// </summary>
		// Token: 0x0600265E RID: 9822 RVA: 0x00038C06 File Offset: 0x00036E06
		public virtual void UseFXAAOn()
		{
			vtkRenderer.vtkRenderer_UseFXAAOn_184(base.GetCppThis());
		}

		// Token: 0x0600265F RID: 9823
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_UseHiddenLineRemovalOff_185(HandleRef pThis);

		/// <summary>
		/// If this flag is true and the rendering engine supports it, wireframe
		/// geometry will be drawn using hidden line removal.
		/// </summary>
		// Token: 0x06002660 RID: 9824 RVA: 0x00038C15 File Offset: 0x00036E15
		public virtual void UseHiddenLineRemovalOff()
		{
			vtkRenderer.vtkRenderer_UseHiddenLineRemovalOff_185(base.GetCppThis());
		}

		// Token: 0x06002661 RID: 9825
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_UseHiddenLineRemovalOn_186(HandleRef pThis);

		/// <summary>
		/// If this flag is true and the rendering engine supports it, wireframe
		/// geometry will be drawn using hidden line removal.
		/// </summary>
		// Token: 0x06002662 RID: 9826 RVA: 0x00038C24 File Offset: 0x00036E24
		public virtual void UseHiddenLineRemovalOn()
		{
			vtkRenderer.vtkRenderer_UseHiddenLineRemovalOn_186(base.GetCppThis());
		}

		// Token: 0x06002663 RID: 9827
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_UseImageBasedLightingOff_187(HandleRef pThis);

		/// <summary>
		/// If this flag is true and the rendering engine supports it, image based
		/// lighting is enabled and surface rendering displays environment reflections.
		/// Image Based Lighting rely on the environment texture to compute lighting
		/// if it has been provided.
		/// </summary>
		// Token: 0x06002664 RID: 9828 RVA: 0x00038C33 File Offset: 0x00036E33
		public virtual void UseImageBasedLightingOff()
		{
			vtkRenderer.vtkRenderer_UseImageBasedLightingOff_187(base.GetCppThis());
		}

		// Token: 0x06002665 RID: 9829
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_UseImageBasedLightingOn_188(HandleRef pThis);

		/// <summary>
		/// If this flag is true and the rendering engine supports it, image based
		/// lighting is enabled and surface rendering displays environment reflections.
		/// Image Based Lighting rely on the environment texture to compute lighting
		/// if it has been provided.
		/// </summary>
		// Token: 0x06002666 RID: 9830 RVA: 0x00038C42 File Offset: 0x00036E42
		public virtual void UseImageBasedLightingOn()
		{
			vtkRenderer.vtkRenderer_UseImageBasedLightingOn_188(base.GetCppThis());
		}

		// Token: 0x06002667 RID: 9831
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_UseSSAOOff_189(HandleRef pThis);

		/// <summary>
		/// Enable or disable Screen Space Ambient Occlusion.
		/// SSAO darkens some pixels to improve depth perception.
		/// </summary>
		// Token: 0x06002668 RID: 9832 RVA: 0x00038C51 File Offset: 0x00036E51
		public virtual void UseSSAOOff()
		{
			vtkRenderer.vtkRenderer_UseSSAOOff_189(base.GetCppThis());
		}

		// Token: 0x06002669 RID: 9833
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_UseSSAOOn_190(HandleRef pThis);

		/// <summary>
		/// Enable or disable Screen Space Ambient Occlusion.
		/// SSAO darkens some pixels to improve depth perception.
		/// </summary>
		// Token: 0x0600266A RID: 9834 RVA: 0x00038C60 File Offset: 0x00036E60
		public virtual void UseSSAOOn()
		{
			vtkRenderer.vtkRenderer_UseSSAOOn_190(base.GetCppThis());
		}

		// Token: 0x0600266B RID: 9835
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_UseShadowsOff_191(HandleRef pThis);

		/// <summary>
		/// Turn on/off rendering of shadows if supported
		/// Initial value is off.
		/// </summary>
		// Token: 0x0600266C RID: 9836 RVA: 0x00038C6F File Offset: 0x00036E6F
		public virtual void UseShadowsOff()
		{
			vtkRenderer.vtkRenderer_UseShadowsOff_191(base.GetCppThis());
		}

		// Token: 0x0600266D RID: 9837
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_UseShadowsOn_192(HandleRef pThis);

		/// <summary>
		/// Turn on/off rendering of shadows if supported
		/// Initial value is off.
		/// </summary>
		// Token: 0x0600266E RID: 9838 RVA: 0x00038C7E File Offset: 0x00036E7E
		public virtual void UseShadowsOn()
		{
			vtkRenderer.vtkRenderer_UseShadowsOn_192(base.GetCppThis());
		}

		// Token: 0x0600266F RID: 9839
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_ViewToPose_193(HandleRef pThis, ref double wx, ref double wy, ref double wz);

		/// <summary>
		/// Convert to from pose coordinates
		/// </summary>
		// Token: 0x06002670 RID: 9840 RVA: 0x00038C8D File Offset: 0x00036E8D
		public override void ViewToPose(ref double wx, ref double wy, ref double wz)
		{
			vtkRenderer.vtkRenderer_ViewToPose_193(base.GetCppThis(), ref wx, ref wy, ref wz);
		}

		// Token: 0x06002671 RID: 9841
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_ViewToWorld_194(HandleRef pThis);

		/// <summary>
		/// Convert view point coordinates to world coordinates.
		/// </summary>
		// Token: 0x06002672 RID: 9842 RVA: 0x00038C9F File Offset: 0x00036E9F
		public override void ViewToWorld()
		{
			vtkRenderer.vtkRenderer_ViewToWorld_194(base.GetCppThis());
		}

		// Token: 0x06002673 RID: 9843
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_ViewToWorld_195(HandleRef pThis, ref double wx, ref double wy, ref double wz);

		/// <summary>
		/// Convert view point coordinates to world coordinates.
		/// </summary>
		// Token: 0x06002674 RID: 9844 RVA: 0x00038CAE File Offset: 0x00036EAE
		public override void ViewToWorld(ref double wx, ref double wy, ref double wz)
		{
			vtkRenderer.vtkRenderer_ViewToWorld_195(base.GetCppThis(), ref wx, ref wy, ref wz);
		}

		// Token: 0x06002675 RID: 9845
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderer_VisibleActorCount_196(HandleRef pThis);

		/// <summary>
		/// Returns the number of visible actors.
		/// </summary>
		// Token: 0x06002676 RID: 9846 RVA: 0x00038CC0 File Offset: 0x00036EC0
		public int VisibleActorCount()
		{
			return vtkRenderer.vtkRenderer_VisibleActorCount_196(base.GetCppThis());
		}

		// Token: 0x06002677 RID: 9847
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderer_VisibleVolumeCount_197(HandleRef pThis);

		/// <summary>
		/// Returns the number of visible volumes.
		/// </summary>
		// Token: 0x06002678 RID: 9848 RVA: 0x00038CE0 File Offset: 0x00036EE0
		public int VisibleVolumeCount()
		{
			return vtkRenderer.vtkRenderer_VisibleVolumeCount_197(base.GetCppThis());
		}

		// Token: 0x06002679 RID: 9849
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_WorldToPose_198(HandleRef pThis, ref double wx, ref double wy, ref double wz);

		/// <summary>
		/// Convert to from pose coordinates
		/// </summary>
		// Token: 0x0600267A RID: 9850 RVA: 0x00038CFF File Offset: 0x00036EFF
		public override void WorldToPose(ref double wx, ref double wy, ref double wz)
		{
			vtkRenderer.vtkRenderer_WorldToPose_198(base.GetCppThis(), ref wx, ref wy, ref wz);
		}

		// Token: 0x0600267B RID: 9851
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_WorldToView_199(HandleRef pThis);

		/// <summary>
		/// Convert world point coordinates to view coordinates.
		/// </summary>
		// Token: 0x0600267C RID: 9852 RVA: 0x00038D11 File Offset: 0x00036F11
		public override void WorldToView()
		{
			vtkRenderer.vtkRenderer_WorldToView_199(base.GetCppThis());
		}

		// Token: 0x0600267D RID: 9853
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_WorldToView_200(HandleRef pThis, ref double wx, ref double wy, ref double wz);

		/// <summary>
		/// Convert world point coordinates to view coordinates.
		/// </summary>
		// Token: 0x0600267E RID: 9854 RVA: 0x00038D20 File Offset: 0x00036F20
		public override void WorldToView(ref double wx, ref double wy, ref double wz)
		{
			vtkRenderer.vtkRenderer_WorldToView_200(base.GetCppThis(), ref wx, ref wy, ref wz);
		}

		// Token: 0x0600267F RID: 9855
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderer_ZoomToBoxUsingViewAngle_201(HandleRef pThis, HandleRef box, double offsetRatio);

		/// <summary>
		/// Automatically set up the camera focal point and zoom factor to
		/// observe the \p box in display coordinates.
		/// \p OffsetRatio can be used to add a zoom offset.
		/// </summary>
		// Token: 0x06002680 RID: 9856 RVA: 0x00038D34 File Offset: 0x00036F34
		public void ZoomToBoxUsingViewAngle(vtkRecti box, double offsetRatio)
		{
			vtkRenderer.vtkRenderer_ZoomToBoxUsingViewAngle_201(base.GetCppThis(), (box == null) ? default(HandleRef) : box.GetCppThis(), offsetRatio);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400053E RID: 1342
		public new const string MRFullTypeName = "Kitware.VTK.vtkRenderer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400053F RID: 1343
		public new static readonly string MRClassNameKey = "class vtkRenderer";
	}
}
