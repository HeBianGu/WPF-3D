using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRenderWindowInteractor3D
	/// </summary>
	/// <remarks>
	///    adds support for 3D events to vtkRenderWindowInteractor.
	///
	///
	/// vtkRenderWindowInteractor3D provides a platform-independent interaction
	/// support for 3D events including 3D clicks and 3D controller
	/// orientations. It follows the same basic model as
	/// vtkRenderWindowInteractor but adds methods to set and get 3D event
	/// locations and orientations. VR systems will subclass this class to
	/// provide the code to set these values based on events from their VR
	/// controllers.
	/// </remarks>
	// Token: 0x0200009B RID: 155
	public class vtkRenderWindowInteractor3D : vtkRenderWindowInteractor
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060020AC RID: 8364 RVA: 0x000316AF File Offset: 0x0002F8AF
		static vtkRenderWindowInteractor3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRenderWindowInteractor3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderWindowInteractor3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060020AD RID: 8365 RVA: 0x000316D7 File Offset: 0x0002F8D7
		public vtkRenderWindowInteractor3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060020AE RID: 8366
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object so that light follows camera motion.
		/// </summary>
		// Token: 0x060020AF RID: 8367 RVA: 0x000316E8 File Offset: 0x0002F8E8
		public new static vtkRenderWindowInteractor3D New()
		{
			vtkRenderWindowInteractor3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderWindowInteractor3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object so that light follows camera motion.
		/// </summary>
		// Token: 0x060020B0 RID: 8368 RVA: 0x0003173C File Offset: 0x0002F93C
		public vtkRenderWindowInteractor3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060020B1 RID: 8369 RVA: 0x00031780 File Offset: 0x0002F980
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060020B2 RID: 8370
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor3D_Disable_01(HandleRef pThis);

		/// <summary>
		/// Enable/Disable interactions.  By default interactors are enabled when
		/// initialized.  Initialize() must be called prior to enabling/disabling
		/// interaction. These methods are used when a window/widget is being
		/// shared by multiple renderers and interactors.  This allows a "modal"
		/// display where one interactor is active when its data is to be displayed
		/// and all other interactors associated with the widget are disabled
		/// when their data is not displayed.
		/// </summary>
		// Token: 0x060020B3 RID: 8371 RVA: 0x0003178B File Offset: 0x0002F98B
		public override void Disable()
		{
			vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_Disable_01(base.GetCppThis());
		}

		// Token: 0x060020B4 RID: 8372
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor3D_Enable_02(HandleRef pThis);

		/// <summary>
		/// Enable/Disable interactions.  By default interactors are enabled when
		/// initialized.  Initialize() must be called prior to enabling/disabling
		/// interaction. These methods are used when a window/widget is being
		/// shared by multiple renderers and interactors.  This allows a "modal"
		/// display where one interactor is active when its data is to be displayed
		/// and all other interactors associated with the widget are disabled
		/// when their data is not displayed.
		/// </summary>
		// Token: 0x060020B5 RID: 8373 RVA: 0x0003179A File Offset: 0x0002F99A
		public override void Enable()
		{
			vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_Enable_02(base.GetCppThis());
		}

		// Token: 0x060020B6 RID: 8374
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor3D_GetLastPhysicalEventPose_03(HandleRef pThis, HandleRef poseMatrix, int pointerIndex);

		/// <summary>
		/// With VR we know the physical/room coordinate positions
		/// and orientations of events.
		/// These methods support getting them.
		/// </summary>
		// Token: 0x060020B7 RID: 8375 RVA: 0x000317AC File Offset: 0x0002F9AC
		public virtual void GetLastPhysicalEventPose(vtkMatrix4x4 poseMatrix, int pointerIndex)
		{
			vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_GetLastPhysicalEventPose_03(base.GetCppThis(), (poseMatrix == null) ? default(HandleRef) : poseMatrix.GetCppThis(), pointerIndex);
		}

		// Token: 0x060020B8 RID: 8376
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor3D_GetLastTranslation3D_04(HandleRef pThis);

		/// <summary>
		/// Set/get the translation for pan/swipe gestures, update LastTranslation
		/// </summary>
		// Token: 0x060020B9 RID: 8377 RVA: 0x000317DC File Offset: 0x0002F9DC
		public virtual double[] GetLastTranslation3D()
		{
			IntPtr intPtr = vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_GetLastTranslation3D_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060020BA RID: 8378
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor3D_GetLastTranslation3D_05(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/get the translation for pan/swipe gestures, update LastTranslation
		/// </summary>
		// Token: 0x060020BB RID: 8379 RVA: 0x00031824 File Offset: 0x0002FA24
		public virtual void GetLastTranslation3D(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_GetLastTranslation3D_05(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060020BC RID: 8380
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor3D_GetLastTranslation3D_06(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the translation for pan/swipe gestures, update LastTranslation
		/// </summary>
		// Token: 0x060020BD RID: 8381 RVA: 0x00031836 File Offset: 0x0002FA36
		public virtual void GetLastTranslation3D(IntPtr _arg)
		{
			vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_GetLastTranslation3D_06(base.GetCppThis(), _arg);
		}

		// Token: 0x060020BE RID: 8382
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor3D_GetLastWorldEventOrientation_07(HandleRef pThis, int pointerIndex);

		/// <summary>
		/// With VR we know the world coordinate positions and orientations of events.
		/// These methods support querying them instead of going through a display X,Y
		/// coordinate approach as is standard for mouse/touch events
		/// </summary>
		// Token: 0x060020BF RID: 8383 RVA: 0x00031848 File Offset: 0x0002FA48
		public virtual IntPtr GetLastWorldEventOrientation(int pointerIndex)
		{
			return vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_GetLastWorldEventOrientation_07(base.GetCppThis(), pointerIndex);
		}

		// Token: 0x060020C0 RID: 8384
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor3D_GetLastWorldEventPose_08(HandleRef pThis, HandleRef poseMatrix, int pointerIndex);

		/// <summary>
		/// With VR we know the world coordinate positions and orientations of events.
		/// These methods support querying them instead of going through a display X,Y
		/// coordinate approach as is standard for mouse/touch events
		/// </summary>
		// Token: 0x060020C1 RID: 8385 RVA: 0x00031868 File Offset: 0x0002FA68
		public virtual void GetLastWorldEventPose(vtkMatrix4x4 poseMatrix, int pointerIndex)
		{
			vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_GetLastWorldEventPose_08(base.GetCppThis(), (poseMatrix == null) ? default(HandleRef) : poseMatrix.GetCppThis(), pointerIndex);
		}

		// Token: 0x060020C2 RID: 8386
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor3D_GetLastWorldEventPosition_09(HandleRef pThis, int pointerIndex);

		/// <summary>
		/// With VR we know the world coordinate positions and orientations of events.
		/// These methods support querying them instead of going through a display X,Y
		/// coordinate approach as is standard for mouse/touch events
		/// </summary>
		// Token: 0x060020C3 RID: 8387 RVA: 0x00031898 File Offset: 0x0002FA98
		public virtual IntPtr GetLastWorldEventPosition(int pointerIndex)
		{
			return vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_GetLastWorldEventPosition_09(base.GetCppThis(), pointerIndex);
		}

		// Token: 0x060020C4 RID: 8388
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderWindowInteractor3D_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object so that light follows camera motion.
		/// </summary>
		// Token: 0x060020C5 RID: 8389 RVA: 0x000318B8 File Offset: 0x0002FAB8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x060020C6 RID: 8390
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderWindowInteractor3D_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object so that light follows camera motion.
		/// </summary>
		// Token: 0x060020C7 RID: 8391 RVA: 0x000318D8 File Offset: 0x0002FAD8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x060020C8 RID: 8392
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor3D_GetPhysicalEventPose_12(HandleRef pThis, HandleRef poseMatrix, int pointerIndex);

		/// <summary>
		/// With VR we know the physical/room coordinate positions
		/// and orientations of events.
		/// These methods support getting them.
		/// </summary>
		// Token: 0x060020C9 RID: 8393 RVA: 0x000318F4 File Offset: 0x0002FAF4
		public virtual void GetPhysicalEventPose(vtkMatrix4x4 poseMatrix, int pointerIndex)
		{
			vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_GetPhysicalEventPose_12(base.GetCppThis(), (poseMatrix == null) ? default(HandleRef) : poseMatrix.GetCppThis(), pointerIndex);
		}

		// Token: 0x060020CA RID: 8394
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRenderWindowInteractor3D_GetPhysicalScale_13(HandleRef pThis);

		/// <summary>
		/// Set/get the physical scale (world / physical distance ratio)
		/// </summary>
		// Token: 0x060020CB RID: 8395 RVA: 0x00031924 File Offset: 0x0002FB24
		public virtual double GetPhysicalScale()
		{
			return vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_GetPhysicalScale_13(base.GetCppThis());
		}

		// Token: 0x060020CC RID: 8396
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor3D_GetPhysicalTranslation_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/get position of the physical coordinate system origin in world coordinates.
		/// </summary>
		// Token: 0x060020CD RID: 8397 RVA: 0x00031944 File Offset: 0x0002FB44
		public virtual IntPtr GetPhysicalTranslation(vtkCamera arg0)
		{
			return vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_GetPhysicalTranslation_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060020CE RID: 8398
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor3D_GetPhysicalViewDirection_15(HandleRef pThis);

		/// <summary>
		/// Set/get the direction of the physical coordinate system -Z axis in world coordinates.
		/// </summary>
		// Token: 0x060020CF RID: 8399 RVA: 0x00031978 File Offset: 0x0002FB78
		public virtual IntPtr GetPhysicalViewDirection()
		{
			return vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_GetPhysicalViewDirection_15(base.GetCppThis());
		}

		// Token: 0x060020D0 RID: 8400
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor3D_GetPhysicalViewUp_16(HandleRef pThis);

		/// <summary>
		/// Set/get the direction of the physical coordinate system +Y axis in world coordinates.
		/// </summary>
		// Token: 0x060020D1 RID: 8401 RVA: 0x00031998 File Offset: 0x0002FB98
		public virtual IntPtr GetPhysicalViewUp()
		{
			return vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_GetPhysicalViewUp_16(base.GetCppThis());
		}

		// Token: 0x060020D2 RID: 8402
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor3D_GetStartingPhysicalEventPose_17(HandleRef pThis, HandleRef poseMatrix, int pointerIndex);

		/// <summary>
		/// With VR we know the physical/room coordinate positions
		/// and orientations of events.
		/// These methods support getting them.
		/// </summary>
		// Token: 0x060020D3 RID: 8403 RVA: 0x000319B8 File Offset: 0x0002FBB8
		public virtual void GetStartingPhysicalEventPose(vtkMatrix4x4 poseMatrix, int pointerIndex)
		{
			vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_GetStartingPhysicalEventPose_17(base.GetCppThis(), (poseMatrix == null) ? default(HandleRef) : poseMatrix.GetCppThis(), pointerIndex);
		}

		// Token: 0x060020D4 RID: 8404
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor3D_GetTouchPadPosition_18(HandleRef pThis, vtkEventDataDevice arg0, vtkEventDataDeviceInput arg1, IntPtr arg2);

		/// <summary>
		/// Get the latest touchpad or joystick position for a device
		/// </summary>
		// Token: 0x060020D5 RID: 8405 RVA: 0x000319E8 File Offset: 0x0002FBE8
		public virtual void GetTouchPadPosition(vtkEventDataDevice arg0, vtkEventDataDeviceInput arg1, IntPtr arg2)
		{
			vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_GetTouchPadPosition_18(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x060020D6 RID: 8406
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor3D_GetTranslation3D_19(HandleRef pThis);

		/// <summary>
		/// Set/get the translation for pan/swipe gestures, update LastTranslation
		/// </summary>
		// Token: 0x060020D7 RID: 8407 RVA: 0x000319FC File Offset: 0x0002FBFC
		public virtual double[] GetTranslation3D()
		{
			IntPtr intPtr = vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_GetTranslation3D_19(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060020D8 RID: 8408
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor3D_GetTranslation3D_20(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/get the translation for pan/swipe gestures, update LastTranslation
		/// </summary>
		// Token: 0x060020D9 RID: 8409 RVA: 0x00031A44 File Offset: 0x0002FC44
		public virtual void GetTranslation3D(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_GetTranslation3D_20(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060020DA RID: 8410
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor3D_GetTranslation3D_21(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the translation for pan/swipe gestures, update LastTranslation
		/// </summary>
		// Token: 0x060020DB RID: 8411 RVA: 0x00031A56 File Offset: 0x0002FC56
		public virtual void GetTranslation3D(IntPtr _arg)
		{
			vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_GetTranslation3D_21(base.GetCppThis(), _arg);
		}

		// Token: 0x060020DC RID: 8412
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor3D_GetWorldEventOrientation_22(HandleRef pThis, int pointerIndex);

		/// <summary>
		/// With VR we know the world coordinate positions and orientations of events.
		/// These methods support querying them instead of going through a display X,Y
		/// coordinate approach as is standard for mouse/touch events
		/// </summary>
		// Token: 0x060020DD RID: 8413 RVA: 0x00031A68 File Offset: 0x0002FC68
		public virtual IntPtr GetWorldEventOrientation(int pointerIndex)
		{
			return vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_GetWorldEventOrientation_22(base.GetCppThis(), pointerIndex);
		}

		// Token: 0x060020DE RID: 8414
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor3D_GetWorldEventPose_23(HandleRef pThis, HandleRef poseMatrix, int pointerIndex);

		/// <summary>
		/// With VR we know the world coordinate positions and orientations of events.
		/// These methods support querying them instead of going through a display X,Y
		/// coordinate approach as is standard for mouse/touch events
		/// </summary>
		// Token: 0x060020DF RID: 8415 RVA: 0x00031A88 File Offset: 0x0002FC88
		public virtual void GetWorldEventPose(vtkMatrix4x4 poseMatrix, int pointerIndex)
		{
			vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_GetWorldEventPose_23(base.GetCppThis(), (poseMatrix == null) ? default(HandleRef) : poseMatrix.GetCppThis(), pointerIndex);
		}

		// Token: 0x060020E0 RID: 8416
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor3D_GetWorldEventPosition_24(HandleRef pThis, int pointerIndex);

		/// <summary>
		/// With VR we know the world coordinate positions and orientations of events.
		/// These methods support querying them instead of going through a display X,Y
		/// coordinate approach as is standard for mouse/touch events
		/// </summary>
		// Token: 0x060020E1 RID: 8417 RVA: 0x00031AB8 File Offset: 0x0002FCB8
		public virtual IntPtr GetWorldEventPosition(int pointerIndex)
		{
			return vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_GetWorldEventPosition_24(base.GetCppThis(), pointerIndex);
		}

		// Token: 0x060020E2 RID: 8418
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowInteractor3D_IsA_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object so that light follows camera motion.
		/// </summary>
		// Token: 0x060020E3 RID: 8419 RVA: 0x00031AD8 File Offset: 0x0002FCD8
		public override int IsA(string type)
		{
			return vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_IsA_25(base.GetCppThis(), type);
		}

		// Token: 0x060020E4 RID: 8420
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderWindowInteractor3D_IsTypeOf_26([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object so that light follows camera motion.
		/// </summary>
		// Token: 0x060020E5 RID: 8421 RVA: 0x00031AF8 File Offset: 0x0002FCF8
		public new static int IsTypeOf(string type)
		{
			return vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_IsTypeOf_26(type);
		}

		// Token: 0x060020E6 RID: 8422
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor3D_MiddleButtonPressEvent_27(HandleRef pThis);

		/// <summary>
		/// Override to set pointers down
		/// </summary>
		// Token: 0x060020E7 RID: 8423 RVA: 0x00031B12 File Offset: 0x0002FD12
		public override void MiddleButtonPressEvent()
		{
			vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_MiddleButtonPressEvent_27(base.GetCppThis());
		}

		// Token: 0x060020E8 RID: 8424
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor3D_MiddleButtonReleaseEvent_28(HandleRef pThis);

		/// <summary>
		/// Override to set pointers down
		/// </summary>
		// Token: 0x060020E9 RID: 8425 RVA: 0x00031B21 File Offset: 0x0002FD21
		public override void MiddleButtonReleaseEvent()
		{
			vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_MiddleButtonReleaseEvent_28(base.GetCppThis());
		}

		// Token: 0x060020EA RID: 8426
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor3D_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object so that light follows camera motion.
		/// </summary>
		// Token: 0x060020EB RID: 8427 RVA: 0x00031B30 File Offset: 0x0002FD30
		public new vtkRenderWindowInteractor3D NewInstance()
		{
			vtkRenderWindowInteractor3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_NewInstance_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderWindowInteractor3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060020EC RID: 8428
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor3D_RightButtonPressEvent_31(HandleRef pThis);

		/// <summary>
		/// Override to set pointers down
		/// </summary>
		// Token: 0x060020ED RID: 8429 RVA: 0x00031B8A File Offset: 0x0002FD8A
		public override void RightButtonPressEvent()
		{
			vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_RightButtonPressEvent_31(base.GetCppThis());
		}

		// Token: 0x060020EE RID: 8430
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor3D_RightButtonReleaseEvent_32(HandleRef pThis);

		/// <summary>
		/// Override to set pointers down
		/// </summary>
		// Token: 0x060020EF RID: 8431 RVA: 0x00031B99 File Offset: 0x0002FD99
		public override void RightButtonReleaseEvent()
		{
			vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_RightButtonReleaseEvent_32(base.GetCppThis());
		}

		// Token: 0x060020F0 RID: 8432
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderWindowInteractor3D_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object so that light follows camera motion.
		/// </summary>
		// Token: 0x060020F1 RID: 8433 RVA: 0x00031BA8 File Offset: 0x0002FDA8
		public new static vtkRenderWindowInteractor3D SafeDownCast(vtkObjectBase o)
		{
			vtkRenderWindowInteractor3D vtkRenderWindowInteractor3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindowInteractor3D = (vtkRenderWindowInteractor3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindowInteractor3D.Register(null);
				}
			}
			return vtkRenderWindowInteractor3D;
		}

		// Token: 0x060020F2 RID: 8434
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor3D_SetPhysicalEventPose_34(HandleRef pThis, HandleRef poseMatrix, int pointerIndex);

		/// <summary>
		/// With VR we know the physical/room coordinate positions
		/// and orientations of events.
		/// These methods support setting them.
		/// </summary>
		// Token: 0x060020F3 RID: 8435 RVA: 0x00031C28 File Offset: 0x0002FE28
		public virtual void SetPhysicalEventPose(vtkMatrix4x4 poseMatrix, int pointerIndex)
		{
			vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_SetPhysicalEventPose_34(base.GetCppThis(), (poseMatrix == null) ? default(HandleRef) : poseMatrix.GetCppThis(), pointerIndex);
		}

		// Token: 0x060020F4 RID: 8436
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor3D_SetPhysicalEventPosition_35(HandleRef pThis, double x, double y, double z, int pointerIndex);

		/// <summary>
		/// With VR we know the physical/room coordinate positions
		/// and orientations of events.
		/// These methods support setting them.
		/// </summary>
		// Token: 0x060020F5 RID: 8437 RVA: 0x00031C58 File Offset: 0x0002FE58
		public virtual void SetPhysicalEventPosition(double x, double y, double z, int pointerIndex)
		{
			vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_SetPhysicalEventPosition_35(base.GetCppThis(), x, y, z, pointerIndex);
		}

		// Token: 0x060020F6 RID: 8438
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor3D_SetPhysicalScale_36(HandleRef pThis, double arg0);

		/// <summary>
		/// Set/get the physical scale (world / physical distance ratio)
		/// </summary>
		// Token: 0x060020F7 RID: 8439 RVA: 0x00031C6C File Offset: 0x0002FE6C
		public virtual void SetPhysicalScale(double arg0)
		{
			vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_SetPhysicalScale_36(base.GetCppThis(), arg0);
		}

		// Token: 0x060020F8 RID: 8440
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor3D_SetPhysicalTranslation_37(HandleRef pThis, HandleRef arg0, double arg1, double arg2, double arg3);

		/// <summary>
		/// Set/get position of the physical coordinate system origin in world coordinates.
		/// </summary>
		// Token: 0x060020F9 RID: 8441 RVA: 0x00031C7C File Offset: 0x0002FE7C
		public virtual void SetPhysicalTranslation(vtkCamera arg0, double arg1, double arg2, double arg3)
		{
			vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_SetPhysicalTranslation_37(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), arg1, arg2, arg3);
		}

		// Token: 0x060020FA RID: 8442
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor3D_SetPhysicalViewDirection_38(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Set/get the direction of the physical coordinate system -Z axis in world coordinates.
		/// </summary>
		// Token: 0x060020FB RID: 8443 RVA: 0x00031CAF File Offset: 0x0002FEAF
		public virtual void SetPhysicalViewDirection(double arg0, double arg1, double arg2)
		{
			vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_SetPhysicalViewDirection_38(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x060020FC RID: 8444
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor3D_SetPhysicalViewUp_39(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Set/get the direction of the physical coordinate system +Y axis in world coordinates.
		/// </summary>
		// Token: 0x060020FD RID: 8445 RVA: 0x00031CC1 File Offset: 0x0002FEC1
		public virtual void SetPhysicalViewUp(double arg0, double arg1, double arg2)
		{
			vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_SetPhysicalViewUp_39(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x060020FE RID: 8446
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor3D_SetTranslation3D_40(HandleRef pThis, IntPtr val);

		/// <summary>
		/// Set/get the translation for pan/swipe gestures, update LastTranslation
		/// </summary>
		// Token: 0x060020FF RID: 8447 RVA: 0x00031CD3 File Offset: 0x0002FED3
		public void SetTranslation3D(IntPtr val)
		{
			vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_SetTranslation3D_40(base.GetCppThis(), val);
		}

		// Token: 0x06002100 RID: 8448
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor3D_SetWorldEventOrientation_41(HandleRef pThis, double w, double x, double y, double z, int pointerIndex);

		/// <summary>
		/// With VR we know the world coordinate positions
		/// and orientations of events. These methods
		/// support setting them.
		/// </summary>
		// Token: 0x06002101 RID: 8449 RVA: 0x00031CE3 File Offset: 0x0002FEE3
		public virtual void SetWorldEventOrientation(double w, double x, double y, double z, int pointerIndex)
		{
			vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_SetWorldEventOrientation_41(base.GetCppThis(), w, x, y, z, pointerIndex);
		}

		// Token: 0x06002102 RID: 8450
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor3D_SetWorldEventPose_42(HandleRef pThis, HandleRef poseMatrix, int pointerIndex);

		/// <summary>
		/// With VR we know the world coordinate positions
		/// and orientations of events. These methods
		/// support setting them.
		/// </summary>
		// Token: 0x06002103 RID: 8451 RVA: 0x00031CFC File Offset: 0x0002FEFC
		public virtual void SetWorldEventPose(vtkMatrix4x4 poseMatrix, int pointerIndex)
		{
			vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_SetWorldEventPose_42(base.GetCppThis(), (poseMatrix == null) ? default(HandleRef) : poseMatrix.GetCppThis(), pointerIndex);
		}

		// Token: 0x06002104 RID: 8452
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRenderWindowInteractor3D_SetWorldEventPosition_43(HandleRef pThis, double x, double y, double z, int pointerIndex);

		/// <summary>
		/// With VR we know the world coordinate positions
		/// and orientations of events. These methods
		/// support setting them.
		/// </summary>
		// Token: 0x06002105 RID: 8453 RVA: 0x00031D2C File Offset: 0x0002FF2C
		public virtual void SetWorldEventPosition(double x, double y, double z, int pointerIndex)
		{
			vtkRenderWindowInteractor3D.vtkRenderWindowInteractor3D_SetWorldEventPosition_43(base.GetCppThis(), x, y, z, pointerIndex);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000517 RID: 1303
		public new const string MRFullTypeName = "Kitware.VTK.vtkRenderWindowInteractor3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000518 RID: 1304
		public new static readonly string MRClassNameKey = "class vtkRenderWindowInteractor3D";
	}
}
