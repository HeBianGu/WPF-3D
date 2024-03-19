using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInteractorStyleImage
	/// </summary>
	/// <remarks>
	///    interactive manipulation of the camera specialized for images
	///
	/// vtkInteractorStyleImage allows the user to interactively manipulate
	/// (rotate, pan, zoom etc.) the camera. vtkInteractorStyleImage is specially
	/// designed to work with images that are being rendered with
	/// vtkImageActor. Several events are overloaded from its superclass
	/// vtkInteractorStyle, hence the mouse bindings are different. (The bindings
	/// keep the camera's view plane normal perpendicular to the x-y plane.) In
	/// summary the mouse events for 2D image interaction are as follows:
	/// - Left Mouse button triggers window level events
	/// - CTRL Left Mouse spins the camera around its view plane normal
	/// - SHIFT Left Mouse pans the camera
	/// - CTRL SHIFT Left Mouse dollys (a positional zoom) the camera
	/// - Middle mouse button pans the camera
	/// - Right mouse button dollys the camera.
	/// - SHIFT Right Mouse triggers pick events
	///
	/// If SetInteractionModeToImageSlicing() is called, then some of the mouse
	/// events are changed as follows:
	/// - CTRL Left Mouse slices through the image
	/// - SHIFT Middle Mouse slices through the image
	/// - CTRL Right Mouse spins the camera
	///
	/// If SetInteractionModeToImage3D() is called, then some of the mouse
	/// events are changed as follows:
	/// - SHIFT Left Mouse rotates the camera for oblique slicing
	/// - SHIFT Middle Mouse slices through the image
	/// - CTRL Right Mouse also slices through the image
	///
	/// In all modes, the following key bindings are in effect:
	/// - R Reset the Window/Level
	/// - X Reset to a sagittal view
	/// - Y Reset to a coronal view
	/// - Z Reset to an axial view
	///
	/// Note that the renderer's actors are not moved; instead the camera is moved.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkInteractorStyle vtkInteractorStyleTrackballActor
	/// vtkInteractorStyleJoystickCamera vtkInteractorStyleJoystickActor
	/// </seealso>
	// Token: 0x02000076 RID: 118
	public class vtkInteractorStyleImage : vtkInteractorStyleTrackballCamera
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600158A RID: 5514 RVA: 0x000245AA File Offset: 0x000227AA
		static vtkInteractorStyleImage()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleImage.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleImage"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600158B RID: 5515 RVA: 0x000245D2 File Offset: 0x000227D2
		public vtkInteractorStyleImage(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600158C RID: 5516
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleImage_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600158D RID: 5517 RVA: 0x000245E0 File Offset: 0x000227E0
		public new static vtkInteractorStyleImage New()
		{
			vtkInteractorStyleImage result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleImage.vtkInteractorStyleImage_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleImage)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600158E RID: 5518 RVA: 0x00024634 File Offset: 0x00022834
		public vtkInteractorStyleImage() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInteractorStyleImage.vtkInteractorStyleImage_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600158F RID: 5519 RVA: 0x00024678 File Offset: 0x00022878
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06001590 RID: 5520
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_EndPick_01(HandleRef pThis);

		/// <summary>
		/// Override the "fly-to" (f keypress) for images.
		/// </summary>
		// Token: 0x06001591 RID: 5521 RVA: 0x00024683 File Offset: 0x00022883
		public virtual void EndPick()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_EndPick_01(base.GetCppThis());
		}

		// Token: 0x06001592 RID: 5522
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_EndSlice_02(HandleRef pThis);

		/// <summary>
		/// Override the "fly-to" (f keypress) for images.
		/// </summary>
		// Token: 0x06001593 RID: 5523 RVA: 0x00024692 File Offset: 0x00022892
		public virtual void EndSlice()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_EndSlice_02(base.GetCppThis());
		}

		// Token: 0x06001594 RID: 5524
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_EndWindowLevel_03(HandleRef pThis);

		/// <summary>
		/// Override the "fly-to" (f keypress) for images.
		/// </summary>
		// Token: 0x06001595 RID: 5525 RVA: 0x000246A1 File Offset: 0x000228A1
		public virtual void EndWindowLevel()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_EndWindowLevel_03(base.GetCppThis());
		}

		// Token: 0x06001596 RID: 5526
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleImage_GetCurrentImageNumber_04(HandleRef pThis);

		/// <summary>
		/// Set the image to use for WindowLevel interaction.
		/// Any images for which the Pickable flag is off are ignored.
		/// Images are counted back-to-front, so 0 is the rearmost image.
		/// Negative values can be used to count front-to-back, so -1 is
		/// the frontmost image, -2 is the image behind that one, etc.
		/// The default is to use the frontmost image for interaction.
		/// If the specified image does not exist, then no WindowLevel
		/// interaction will take place.
		/// </summary>
		// Token: 0x06001597 RID: 5527 RVA: 0x000246B0 File Offset: 0x000228B0
		public int GetCurrentImageNumber()
		{
			return vtkInteractorStyleImage.vtkInteractorStyleImage_GetCurrentImageNumber_04(base.GetCppThis());
		}

		// Token: 0x06001598 RID: 5528
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleImage_GetCurrentImageProperty_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the current image property, which is set when StartWindowLevel
		/// is called immediately before StartWindowLevelEvent is generated.
		/// This is the image property of the topmost vtkImageSlice in the
		/// renderer or nullptr if no image actors are present.
		/// </summary>
		// Token: 0x06001599 RID: 5529 RVA: 0x000246D0 File Offset: 0x000228D0
		public vtkImageProperty GetCurrentImageProperty()
		{
			vtkImageProperty vtkImageProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleImage.vtkInteractorStyleImage_GetCurrentImageProperty_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageProperty = (vtkImageProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageProperty.Register(null);
				}
			}
			return vtkImageProperty;
		}

		// Token: 0x0600159A RID: 5530
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleImage_GetInteractionMode_06(HandleRef pThis);

		/// <summary>
		/// Set/Get current mode to 2D or 3D.  The default is 2D.  In 3D mode,
		/// it is possible to rotate the camera to view oblique slices.  In Slicing
		/// mode, it is possible to slice through the data, but not to generate oblique
		/// views by rotating the camera.
		/// </summary>
		// Token: 0x0600159B RID: 5531 RVA: 0x00024740 File Offset: 0x00022940
		public virtual int GetInteractionMode()
		{
			return vtkInteractorStyleImage.vtkInteractorStyleImage_GetInteractionMode_06(base.GetCppThis());
		}

		// Token: 0x0600159C RID: 5532
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleImage_GetInteractionModeMaxValue_07(HandleRef pThis);

		/// <summary>
		/// Set/Get current mode to 2D or 3D.  The default is 2D.  In 3D mode,
		/// it is possible to rotate the camera to view oblique slices.  In Slicing
		/// mode, it is possible to slice through the data, but not to generate oblique
		/// views by rotating the camera.
		/// </summary>
		// Token: 0x0600159D RID: 5533 RVA: 0x00024760 File Offset: 0x00022960
		public virtual int GetInteractionModeMaxValue()
		{
			return vtkInteractorStyleImage.vtkInteractorStyleImage_GetInteractionModeMaxValue_07(base.GetCppThis());
		}

		// Token: 0x0600159E RID: 5534
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleImage_GetInteractionModeMinValue_08(HandleRef pThis);

		/// <summary>
		/// Set/Get current mode to 2D or 3D.  The default is 2D.  In 3D mode,
		/// it is possible to rotate the camera to view oblique slices.  In Slicing
		/// mode, it is possible to slice through the data, but not to generate oblique
		/// views by rotating the camera.
		/// </summary>
		// Token: 0x0600159F RID: 5535 RVA: 0x00024780 File Offset: 0x00022980
		public virtual int GetInteractionModeMinValue()
		{
			return vtkInteractorStyleImage.vtkInteractorStyleImage_GetInteractionModeMinValue_08(base.GetCppThis());
		}

		// Token: 0x060015A0 RID: 5536
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleImage_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060015A1 RID: 5537 RVA: 0x000247A0 File Offset: 0x000229A0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInteractorStyleImage.vtkInteractorStyleImage_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x060015A2 RID: 5538
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorStyleImage_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060015A3 RID: 5539 RVA: 0x000247C0 File Offset: 0x000229C0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInteractorStyleImage.vtkInteractorStyleImage_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x060015A4 RID: 5540
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleImage_GetWindowLevelCurrentPosition_11(HandleRef pThis);

		/// <summary>
		/// Some useful information for handling window level
		/// </summary>
		// Token: 0x060015A5 RID: 5541 RVA: 0x000247DC File Offset: 0x000229DC
		public virtual int[] GetWindowLevelCurrentPosition()
		{
			IntPtr intPtr = vtkInteractorStyleImage.vtkInteractorStyleImage_GetWindowLevelCurrentPosition_11(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060015A6 RID: 5542
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_GetWindowLevelCurrentPosition_12(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Some useful information for handling window level
		/// </summary>
		// Token: 0x060015A7 RID: 5543 RVA: 0x00024824 File Offset: 0x00022A24
		public virtual void GetWindowLevelCurrentPosition(ref int _arg1, ref int _arg2)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_GetWindowLevelCurrentPosition_12(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x060015A8 RID: 5544
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_GetWindowLevelCurrentPosition_13(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Some useful information for handling window level
		/// </summary>
		// Token: 0x060015A9 RID: 5545 RVA: 0x00024835 File Offset: 0x00022A35
		public virtual void GetWindowLevelCurrentPosition(IntPtr _arg)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_GetWindowLevelCurrentPosition_13(base.GetCppThis(), _arg);
		}

		// Token: 0x060015AA RID: 5546
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleImage_GetWindowLevelStartPosition_14(HandleRef pThis);

		/// <summary>
		/// Some useful information for handling window level
		/// </summary>
		// Token: 0x060015AB RID: 5547 RVA: 0x00024848 File Offset: 0x00022A48
		public virtual int[] GetWindowLevelStartPosition()
		{
			IntPtr intPtr = vtkInteractorStyleImage.vtkInteractorStyleImage_GetWindowLevelStartPosition_14(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060015AC RID: 5548
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_GetWindowLevelStartPosition_15(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Some useful information for handling window level
		/// </summary>
		// Token: 0x060015AD RID: 5549 RVA: 0x00024890 File Offset: 0x00022A90
		public virtual void GetWindowLevelStartPosition(ref int _arg1, ref int _arg2)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_GetWindowLevelStartPosition_15(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x060015AE RID: 5550
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_GetWindowLevelStartPosition_16(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Some useful information for handling window level
		/// </summary>
		// Token: 0x060015AF RID: 5551 RVA: 0x000248A1 File Offset: 0x00022AA1
		public virtual void GetWindowLevelStartPosition(IntPtr _arg)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_GetWindowLevelStartPosition_16(base.GetCppThis(), _arg);
		}

		// Token: 0x060015B0 RID: 5552
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleImage_GetXViewRightVector_17(HandleRef pThis);

		/// <summary>
		/// Set the orientations that will be used when the X, Y, or Z
		/// keys are pressed.  See SetImageOrientation for more information.
		/// </summary>
		// Token: 0x060015B1 RID: 5553 RVA: 0x000248B4 File Offset: 0x00022AB4
		public virtual double[] GetXViewRightVector()
		{
			IntPtr intPtr = vtkInteractorStyleImage.vtkInteractorStyleImage_GetXViewRightVector_17(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060015B2 RID: 5554
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_GetXViewRightVector_18(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set the orientations that will be used when the X, Y, or Z
		/// keys are pressed.  See SetImageOrientation for more information.
		/// </summary>
		// Token: 0x060015B3 RID: 5555 RVA: 0x000248FC File Offset: 0x00022AFC
		public virtual void GetXViewRightVector(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_GetXViewRightVector_18(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060015B4 RID: 5556
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_GetXViewRightVector_19(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the orientations that will be used when the X, Y, or Z
		/// keys are pressed.  See SetImageOrientation for more information.
		/// </summary>
		// Token: 0x060015B5 RID: 5557 RVA: 0x0002490E File Offset: 0x00022B0E
		public virtual void GetXViewRightVector(IntPtr _arg)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_GetXViewRightVector_19(base.GetCppThis(), _arg);
		}

		// Token: 0x060015B6 RID: 5558
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleImage_GetXViewUpVector_20(HandleRef pThis);

		/// <summary>
		/// Set the orientations that will be used when the X, Y, or Z
		/// keys are pressed.  See SetImageOrientation for more information.
		/// </summary>
		// Token: 0x060015B7 RID: 5559 RVA: 0x00024920 File Offset: 0x00022B20
		public virtual double[] GetXViewUpVector()
		{
			IntPtr intPtr = vtkInteractorStyleImage.vtkInteractorStyleImage_GetXViewUpVector_20(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060015B8 RID: 5560
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_GetXViewUpVector_21(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set the orientations that will be used when the X, Y, or Z
		/// keys are pressed.  See SetImageOrientation for more information.
		/// </summary>
		// Token: 0x060015B9 RID: 5561 RVA: 0x00024968 File Offset: 0x00022B68
		public virtual void GetXViewUpVector(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_GetXViewUpVector_21(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060015BA RID: 5562
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_GetXViewUpVector_22(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the orientations that will be used when the X, Y, or Z
		/// keys are pressed.  See SetImageOrientation for more information.
		/// </summary>
		// Token: 0x060015BB RID: 5563 RVA: 0x0002497A File Offset: 0x00022B7A
		public virtual void GetXViewUpVector(IntPtr _arg)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_GetXViewUpVector_22(base.GetCppThis(), _arg);
		}

		// Token: 0x060015BC RID: 5564
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleImage_GetYViewRightVector_23(HandleRef pThis);

		/// <summary>
		/// Set the orientations that will be used when the X, Y, or Z
		/// keys are pressed.  See SetImageOrientation for more information.
		/// </summary>
		// Token: 0x060015BD RID: 5565 RVA: 0x0002498C File Offset: 0x00022B8C
		public virtual double[] GetYViewRightVector()
		{
			IntPtr intPtr = vtkInteractorStyleImage.vtkInteractorStyleImage_GetYViewRightVector_23(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060015BE RID: 5566
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_GetYViewRightVector_24(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set the orientations that will be used when the X, Y, or Z
		/// keys are pressed.  See SetImageOrientation for more information.
		/// </summary>
		// Token: 0x060015BF RID: 5567 RVA: 0x000249D4 File Offset: 0x00022BD4
		public virtual void GetYViewRightVector(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_GetYViewRightVector_24(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060015C0 RID: 5568
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_GetYViewRightVector_25(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the orientations that will be used when the X, Y, or Z
		/// keys are pressed.  See SetImageOrientation for more information.
		/// </summary>
		// Token: 0x060015C1 RID: 5569 RVA: 0x000249E6 File Offset: 0x00022BE6
		public virtual void GetYViewRightVector(IntPtr _arg)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_GetYViewRightVector_25(base.GetCppThis(), _arg);
		}

		// Token: 0x060015C2 RID: 5570
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleImage_GetYViewUpVector_26(HandleRef pThis);

		/// <summary>
		/// Set the orientations that will be used when the X, Y, or Z
		/// keys are pressed.  See SetImageOrientation for more information.
		/// </summary>
		// Token: 0x060015C3 RID: 5571 RVA: 0x000249F8 File Offset: 0x00022BF8
		public virtual double[] GetYViewUpVector()
		{
			IntPtr intPtr = vtkInteractorStyleImage.vtkInteractorStyleImage_GetYViewUpVector_26(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060015C4 RID: 5572
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_GetYViewUpVector_27(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set the orientations that will be used when the X, Y, or Z
		/// keys are pressed.  See SetImageOrientation for more information.
		/// </summary>
		// Token: 0x060015C5 RID: 5573 RVA: 0x00024A40 File Offset: 0x00022C40
		public virtual void GetYViewUpVector(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_GetYViewUpVector_27(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060015C6 RID: 5574
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_GetYViewUpVector_28(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the orientations that will be used when the X, Y, or Z
		/// keys are pressed.  See SetImageOrientation for more information.
		/// </summary>
		// Token: 0x060015C7 RID: 5575 RVA: 0x00024A52 File Offset: 0x00022C52
		public virtual void GetYViewUpVector(IntPtr _arg)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_GetYViewUpVector_28(base.GetCppThis(), _arg);
		}

		// Token: 0x060015C8 RID: 5576
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleImage_GetZViewRightVector_29(HandleRef pThis);

		/// <summary>
		/// Set the orientations that will be used when the X, Y, or Z
		/// keys are pressed.  See SetImageOrientation for more information.
		/// </summary>
		// Token: 0x060015C9 RID: 5577 RVA: 0x00024A64 File Offset: 0x00022C64
		public virtual double[] GetZViewRightVector()
		{
			IntPtr intPtr = vtkInteractorStyleImage.vtkInteractorStyleImage_GetZViewRightVector_29(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060015CA RID: 5578
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_GetZViewRightVector_30(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set the orientations that will be used when the X, Y, or Z
		/// keys are pressed.  See SetImageOrientation for more information.
		/// </summary>
		// Token: 0x060015CB RID: 5579 RVA: 0x00024AAC File Offset: 0x00022CAC
		public virtual void GetZViewRightVector(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_GetZViewRightVector_30(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060015CC RID: 5580
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_GetZViewRightVector_31(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the orientations that will be used when the X, Y, or Z
		/// keys are pressed.  See SetImageOrientation for more information.
		/// </summary>
		// Token: 0x060015CD RID: 5581 RVA: 0x00024ABE File Offset: 0x00022CBE
		public virtual void GetZViewRightVector(IntPtr _arg)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_GetZViewRightVector_31(base.GetCppThis(), _arg);
		}

		// Token: 0x060015CE RID: 5582
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleImage_GetZViewUpVector_32(HandleRef pThis);

		/// <summary>
		/// Set the orientations that will be used when the X, Y, or Z
		/// keys are pressed.  See SetImageOrientation for more information.
		/// </summary>
		// Token: 0x060015CF RID: 5583 RVA: 0x00024AD0 File Offset: 0x00022CD0
		public virtual double[] GetZViewUpVector()
		{
			IntPtr intPtr = vtkInteractorStyleImage.vtkInteractorStyleImage_GetZViewUpVector_32(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060015D0 RID: 5584
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_GetZViewUpVector_33(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set the orientations that will be used when the X, Y, or Z
		/// keys are pressed.  See SetImageOrientation for more information.
		/// </summary>
		// Token: 0x060015D1 RID: 5585 RVA: 0x00024B18 File Offset: 0x00022D18
		public virtual void GetZViewUpVector(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_GetZViewUpVector_33(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060015D2 RID: 5586
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_GetZViewUpVector_34(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the orientations that will be used when the X, Y, or Z
		/// keys are pressed.  See SetImageOrientation for more information.
		/// </summary>
		// Token: 0x060015D3 RID: 5587 RVA: 0x00024B2A File Offset: 0x00022D2A
		public virtual void GetZViewUpVector(IntPtr _arg)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_GetZViewUpVector_34(base.GetCppThis(), _arg);
		}

		// Token: 0x060015D4 RID: 5588
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleImage_IsA_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060015D5 RID: 5589 RVA: 0x00024B3C File Offset: 0x00022D3C
		public override int IsA(string type)
		{
			return vtkInteractorStyleImage.vtkInteractorStyleImage_IsA_35(base.GetCppThis(), type);
		}

		// Token: 0x060015D6 RID: 5590
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorStyleImage_IsTypeOf_36([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060015D7 RID: 5591 RVA: 0x00024B5C File Offset: 0x00022D5C
		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleImage.vtkInteractorStyleImage_IsTypeOf_36(type);
		}

		// Token: 0x060015D8 RID: 5592
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleImage_NewInstance_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060015D9 RID: 5593 RVA: 0x00024B78 File Offset: 0x00022D78
		public new vtkInteractorStyleImage NewInstance()
		{
			vtkInteractorStyleImage result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleImage.vtkInteractorStyleImage_NewInstance_38(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleImage)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060015DA RID: 5594
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_OnChar_39(HandleRef pThis);

		/// <summary>
		/// Override the "fly-to" (f keypress) for images.
		/// </summary>
		// Token: 0x060015DB RID: 5595 RVA: 0x00024BD2 File Offset: 0x00022DD2
		public override void OnChar()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_OnChar_39(base.GetCppThis());
		}

		// Token: 0x060015DC RID: 5596
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_OnLeftButtonDown_40(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x060015DD RID: 5597 RVA: 0x00024BE1 File Offset: 0x00022DE1
		public override void OnLeftButtonDown()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_OnLeftButtonDown_40(base.GetCppThis());
		}

		// Token: 0x060015DE RID: 5598
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_OnLeftButtonUp_41(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x060015DF RID: 5599 RVA: 0x00024BF0 File Offset: 0x00022DF0
		public override void OnLeftButtonUp()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_OnLeftButtonUp_41(base.GetCppThis());
		}

		// Token: 0x060015E0 RID: 5600
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_OnMiddleButtonDown_42(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x060015E1 RID: 5601 RVA: 0x00024BFF File Offset: 0x00022DFF
		public override void OnMiddleButtonDown()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_OnMiddleButtonDown_42(base.GetCppThis());
		}

		// Token: 0x060015E2 RID: 5602
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_OnMiddleButtonUp_43(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x060015E3 RID: 5603 RVA: 0x00024C0E File Offset: 0x00022E0E
		public override void OnMiddleButtonUp()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_OnMiddleButtonUp_43(base.GetCppThis());
		}

		// Token: 0x060015E4 RID: 5604
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_OnMouseMove_44(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x060015E5 RID: 5605 RVA: 0x00024C1D File Offset: 0x00022E1D
		public override void OnMouseMove()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_OnMouseMove_44(base.GetCppThis());
		}

		// Token: 0x060015E6 RID: 5606
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_OnRightButtonDown_45(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x060015E7 RID: 5607 RVA: 0x00024C2C File Offset: 0x00022E2C
		public override void OnRightButtonDown()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_OnRightButtonDown_45(base.GetCppThis());
		}

		// Token: 0x060015E8 RID: 5608
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_OnRightButtonUp_46(HandleRef pThis);

		/// <summary>
		/// Event bindings controlling the effects of pressing mouse buttons
		/// or moving the mouse.
		/// </summary>
		// Token: 0x060015E9 RID: 5609 RVA: 0x00024C3B File Offset: 0x00022E3B
		public override void OnRightButtonUp()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_OnRightButtonUp_46(base.GetCppThis());
		}

		// Token: 0x060015EA RID: 5610
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_Pick_47(HandleRef pThis);

		/// <summary>
		/// Override the "fly-to" (f keypress) for images.
		/// </summary>
		// Token: 0x060015EB RID: 5611 RVA: 0x00024C4A File Offset: 0x00022E4A
		public virtual void Pick()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_Pick_47(base.GetCppThis());
		}

		// Token: 0x060015EC RID: 5612
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorStyleImage_SafeDownCast_48(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060015ED RID: 5613 RVA: 0x00024C5C File Offset: 0x00022E5C
		public new static vtkInteractorStyleImage SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleImage vtkInteractorStyleImage = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorStyleImage.vtkInteractorStyleImage_SafeDownCast_48((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleImage = (vtkInteractorStyleImage)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleImage.Register(null);
				}
			}
			return vtkInteractorStyleImage;
		}

		// Token: 0x060015EE RID: 5614
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_SetCurrentImageNumber_49(HandleRef pThis, int i);

		/// <summary>
		/// Set the image to use for WindowLevel interaction.
		/// Any images for which the Pickable flag is off are ignored.
		/// Images are counted back-to-front, so 0 is the rearmost image.
		/// Negative values can be used to count front-to-back, so -1 is
		/// the frontmost image, -2 is the image behind that one, etc.
		/// The default is to use the frontmost image for interaction.
		/// If the specified image does not exist, then no WindowLevel
		/// interaction will take place.
		/// </summary>
		// Token: 0x060015EF RID: 5615 RVA: 0x00024CDB File Offset: 0x00022EDB
		public virtual void SetCurrentImageNumber(int i)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_SetCurrentImageNumber_49(base.GetCppThis(), i);
		}

		// Token: 0x060015F0 RID: 5616
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_SetImageOrientation_50(HandleRef pThis, IntPtr leftToRight, IntPtr bottomToTop);

		/// <summary>
		/// Set the view orientation, in terms of the horizontal and
		/// vertical directions of the computer screen.  The first
		/// vector gives the direction that will correspond to moving
		/// horizontally left-to-right across the screen, and the
		/// second vector gives the direction that will correspond to
		/// moving bottom-to-top up the screen.  This method changes
		/// the position of the camera to provide the desired view.
		/// </summary>
		// Token: 0x060015F1 RID: 5617 RVA: 0x00024CEB File Offset: 0x00022EEB
		public void SetImageOrientation(IntPtr leftToRight, IntPtr bottomToTop)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_SetImageOrientation_50(base.GetCppThis(), leftToRight, bottomToTop);
		}

		// Token: 0x060015F2 RID: 5618
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_SetInteractionMode_51(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get current mode to 2D or 3D.  The default is 2D.  In 3D mode,
		/// it is possible to rotate the camera to view oblique slices.  In Slicing
		/// mode, it is possible to slice through the data, but not to generate oblique
		/// views by rotating the camera.
		/// </summary>
		// Token: 0x060015F3 RID: 5619 RVA: 0x00024CFC File Offset: 0x00022EFC
		public virtual void SetInteractionMode(int _arg)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_SetInteractionMode_51(base.GetCppThis(), _arg);
		}

		// Token: 0x060015F4 RID: 5620
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_SetInteractionModeToImage2D_52(HandleRef pThis);

		/// <summary>
		/// Set/Get current mode to 2D or 3D.  The default is 2D.  In 3D mode,
		/// it is possible to rotate the camera to view oblique slices.  In Slicing
		/// mode, it is possible to slice through the data, but not to generate oblique
		/// views by rotating the camera.
		/// </summary>
		// Token: 0x060015F5 RID: 5621 RVA: 0x00024D0C File Offset: 0x00022F0C
		public void SetInteractionModeToImage2D()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_SetInteractionModeToImage2D_52(base.GetCppThis());
		}

		// Token: 0x060015F6 RID: 5622
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_SetInteractionModeToImage3D_53(HandleRef pThis);

		/// <summary>
		/// Set/Get current mode to 2D or 3D.  The default is 2D.  In 3D mode,
		/// it is possible to rotate the camera to view oblique slices.  In Slicing
		/// mode, it is possible to slice through the data, but not to generate oblique
		/// views by rotating the camera.
		/// </summary>
		// Token: 0x060015F7 RID: 5623 RVA: 0x00024D1B File Offset: 0x00022F1B
		public void SetInteractionModeToImage3D()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_SetInteractionModeToImage3D_53(base.GetCppThis());
		}

		// Token: 0x060015F8 RID: 5624
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_SetInteractionModeToImageSlicing_54(HandleRef pThis);

		/// <summary>
		/// Set/Get current mode to 2D or 3D.  The default is 2D.  In 3D mode,
		/// it is possible to rotate the camera to view oblique slices.  In Slicing
		/// mode, it is possible to slice through the data, but not to generate oblique
		/// views by rotating the camera.
		/// </summary>
		// Token: 0x060015F9 RID: 5625 RVA: 0x00024D2A File Offset: 0x00022F2A
		public void SetInteractionModeToImageSlicing()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_SetInteractionModeToImageSlicing_54(base.GetCppThis());
		}

		// Token: 0x060015FA RID: 5626
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_SetXViewRightVector_55(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the orientations that will be used when the X, Y, or Z
		/// keys are pressed.  See SetImageOrientation for more information.
		/// </summary>
		// Token: 0x060015FB RID: 5627 RVA: 0x00024D39 File Offset: 0x00022F39
		public virtual void SetXViewRightVector(double _arg1, double _arg2, double _arg3)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_SetXViewRightVector_55(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060015FC RID: 5628
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_SetXViewRightVector_56(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the orientations that will be used when the X, Y, or Z
		/// keys are pressed.  See SetImageOrientation for more information.
		/// </summary>
		// Token: 0x060015FD RID: 5629 RVA: 0x00024D4B File Offset: 0x00022F4B
		public virtual void SetXViewRightVector(IntPtr _arg)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_SetXViewRightVector_56(base.GetCppThis(), _arg);
		}

		// Token: 0x060015FE RID: 5630
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_SetXViewUpVector_57(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the orientations that will be used when the X, Y, or Z
		/// keys are pressed.  See SetImageOrientation for more information.
		/// </summary>
		// Token: 0x060015FF RID: 5631 RVA: 0x00024D5B File Offset: 0x00022F5B
		public virtual void SetXViewUpVector(double _arg1, double _arg2, double _arg3)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_SetXViewUpVector_57(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06001600 RID: 5632
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_SetXViewUpVector_58(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the orientations that will be used when the X, Y, or Z
		/// keys are pressed.  See SetImageOrientation for more information.
		/// </summary>
		// Token: 0x06001601 RID: 5633 RVA: 0x00024D6D File Offset: 0x00022F6D
		public virtual void SetXViewUpVector(IntPtr _arg)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_SetXViewUpVector_58(base.GetCppThis(), _arg);
		}

		// Token: 0x06001602 RID: 5634
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_SetYViewRightVector_59(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the orientations that will be used when the X, Y, or Z
		/// keys are pressed.  See SetImageOrientation for more information.
		/// </summary>
		// Token: 0x06001603 RID: 5635 RVA: 0x00024D7D File Offset: 0x00022F7D
		public virtual void SetYViewRightVector(double _arg1, double _arg2, double _arg3)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_SetYViewRightVector_59(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06001604 RID: 5636
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_SetYViewRightVector_60(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the orientations that will be used when the X, Y, or Z
		/// keys are pressed.  See SetImageOrientation for more information.
		/// </summary>
		// Token: 0x06001605 RID: 5637 RVA: 0x00024D8F File Offset: 0x00022F8F
		public virtual void SetYViewRightVector(IntPtr _arg)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_SetYViewRightVector_60(base.GetCppThis(), _arg);
		}

		// Token: 0x06001606 RID: 5638
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_SetYViewUpVector_61(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the orientations that will be used when the X, Y, or Z
		/// keys are pressed.  See SetImageOrientation for more information.
		/// </summary>
		// Token: 0x06001607 RID: 5639 RVA: 0x00024D9F File Offset: 0x00022F9F
		public virtual void SetYViewUpVector(double _arg1, double _arg2, double _arg3)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_SetYViewUpVector_61(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06001608 RID: 5640
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_SetYViewUpVector_62(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the orientations that will be used when the X, Y, or Z
		/// keys are pressed.  See SetImageOrientation for more information.
		/// </summary>
		// Token: 0x06001609 RID: 5641 RVA: 0x00024DB1 File Offset: 0x00022FB1
		public virtual void SetYViewUpVector(IntPtr _arg)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_SetYViewUpVector_62(base.GetCppThis(), _arg);
		}

		// Token: 0x0600160A RID: 5642
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_SetZViewRightVector_63(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the orientations that will be used when the X, Y, or Z
		/// keys are pressed.  See SetImageOrientation for more information.
		/// </summary>
		// Token: 0x0600160B RID: 5643 RVA: 0x00024DC1 File Offset: 0x00022FC1
		public virtual void SetZViewRightVector(double _arg1, double _arg2, double _arg3)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_SetZViewRightVector_63(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600160C RID: 5644
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_SetZViewRightVector_64(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the orientations that will be used when the X, Y, or Z
		/// keys are pressed.  See SetImageOrientation for more information.
		/// </summary>
		// Token: 0x0600160D RID: 5645 RVA: 0x00024DD3 File Offset: 0x00022FD3
		public virtual void SetZViewRightVector(IntPtr _arg)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_SetZViewRightVector_64(base.GetCppThis(), _arg);
		}

		// Token: 0x0600160E RID: 5646
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_SetZViewUpVector_65(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the orientations that will be used when the X, Y, or Z
		/// keys are pressed.  See SetImageOrientation for more information.
		/// </summary>
		// Token: 0x0600160F RID: 5647 RVA: 0x00024DE3 File Offset: 0x00022FE3
		public virtual void SetZViewUpVector(double _arg1, double _arg2, double _arg3)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_SetZViewUpVector_65(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06001610 RID: 5648
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_SetZViewUpVector_66(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the orientations that will be used when the X, Y, or Z
		/// keys are pressed.  See SetImageOrientation for more information.
		/// </summary>
		// Token: 0x06001611 RID: 5649 RVA: 0x00024DF5 File Offset: 0x00022FF5
		public virtual void SetZViewUpVector(IntPtr _arg)
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_SetZViewUpVector_66(base.GetCppThis(), _arg);
		}

		// Token: 0x06001612 RID: 5650
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_Slice_67(HandleRef pThis);

		/// <summary>
		/// Override the "fly-to" (f keypress) for images.
		/// </summary>
		// Token: 0x06001613 RID: 5651 RVA: 0x00024E05 File Offset: 0x00023005
		public virtual void Slice()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_Slice_67(base.GetCppThis());
		}

		// Token: 0x06001614 RID: 5652
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_StartPick_68(HandleRef pThis);

		/// <summary>
		/// Override the "fly-to" (f keypress) for images.
		/// </summary>
		// Token: 0x06001615 RID: 5653 RVA: 0x00024E14 File Offset: 0x00023014
		public virtual void StartPick()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_StartPick_68(base.GetCppThis());
		}

		// Token: 0x06001616 RID: 5654
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_StartSlice_69(HandleRef pThis);

		/// <summary>
		/// Override the "fly-to" (f keypress) for images.
		/// </summary>
		// Token: 0x06001617 RID: 5655 RVA: 0x00024E23 File Offset: 0x00023023
		public virtual void StartSlice()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_StartSlice_69(base.GetCppThis());
		}

		// Token: 0x06001618 RID: 5656
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_StartWindowLevel_70(HandleRef pThis);

		/// <summary>
		/// Override the "fly-to" (f keypress) for images.
		/// </summary>
		// Token: 0x06001619 RID: 5657 RVA: 0x00024E32 File Offset: 0x00023032
		public virtual void StartWindowLevel()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_StartWindowLevel_70(base.GetCppThis());
		}

		// Token: 0x0600161A RID: 5658
		[DllImport("Kitware.VTK.InteractionStyle.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorStyleImage_WindowLevel_71(HandleRef pThis);

		/// <summary>
		/// Override the "fly-to" (f keypress) for images.
		/// </summary>
		// Token: 0x0600161B RID: 5659 RVA: 0x00024E41 File Offset: 0x00023041
		public virtual void WindowLevel()
		{
			vtkInteractorStyleImage.vtkInteractorStyleImage_WindowLevel_71(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400047E RID: 1150
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleImage";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400047F RID: 1151
		public new static readonly string MRClassNameKey = "class vtkInteractorStyleImage";
	}
}
