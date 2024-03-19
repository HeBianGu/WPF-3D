using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVRRenderWindow
	/// </summary>
	/// <remarks>
	///    VR rendering window
	///
	///
	/// vtkVRRenderWindow is a abstract class to define a RenderWindow in a
	/// VR context.
	///
	/// VR provides HMD and controller positions in the "Physical" coordinate
	/// system. For room scale VR this is based on the room setup
	/// per the underlying VR API being used. Units are in meters.
	///
	/// Renderer shows actors in the World coordinate system. Transformation between
	/// Physical and World coordinate systems is defined by PhysicalToWorldMatrix.
	/// This matrix determines the user's position and orientation in the rendered
	/// scene and scaling (magnification) of rendered actors.
	///
	/// This class introduces the notion of DeviceHandles. A DeviceHandle is
	/// a uint32_t handle that represents a device in the underlying VR API
	/// such as OpenVR or OpenXR. Implementations of this class are responsible
	/// for mapping the actual devices from that API into unique DeviceHandles.
	/// Typically these devices are handheld controllers, HMDs, stylus etc.
	/// The subclass should call AddDeviceHandle when it first sees a new device.
	///
	/// This class also uses the term Device from vtkEventDataDevice to represent
	/// a generic device type that is used in the event handling system. Multiple
	/// DeviceHandles could point to the same Device though most often there is a
	/// one to one mapping. For example vtkEventDataDevice::LeftController will
	/// typically have one or zero DeviceHandles that map to it.
	///
	/// Most event processing works with generic devices and this class provides a
	/// number of methods to support that. This class also provides a number of methods
	/// that work on DeviceHandles which are typically used by VR classes and their
	/// subclasses.
	/// </remarks>
	// Token: 0x02000094 RID: 148
	public abstract class vtkVRRenderWindow : vtkOpenGLRenderWindow
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06001E46 RID: 7750 RVA: 0x0002ED1A File Offset: 0x0002CF1A
		static vtkVRRenderWindow()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVRRenderWindow.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVRRenderWindow"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06001E47 RID: 7751 RVA: 0x0002ED42 File Offset: 0x0002CF42
		public vtkVRRenderWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06001E48 RID: 7752 RVA: 0x0002ED50 File Offset: 0x0002CF50
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06001E49 RID: 7753
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_AddDeviceHandle_01(HandleRef pThis, uint handle);

		/// <summary>
		/// Get the DeviceToPhysical matrix corresponding to the device or device handle.
		/// e.g. 0,0,0,1 pushed through this matrix will give you the location of the
		/// device in physical coordinates.
		/// </summary>
		// Token: 0x06001E4A RID: 7754 RVA: 0x0002ED5B File Offset: 0x0002CF5B
		public void AddDeviceHandle(uint handle)
		{
			vtkVRRenderWindow.vtkVRRenderWindow_AddDeviceHandle_01(base.GetCppThis(), handle);
		}

		// Token: 0x06001E4B RID: 7755
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_AddDeviceHandle_02(HandleRef pThis, uint handle, vtkEventDataDevice device);

		/// <summary>
		/// Get the DeviceToPhysical matrix corresponding to the device or device handle.
		/// e.g. 0,0,0,1 pushed through this matrix will give you the location of the
		/// device in physical coordinates.
		/// </summary>
		// Token: 0x06001E4C RID: 7756 RVA: 0x0002ED6B File Offset: 0x0002CF6B
		public void AddDeviceHandle(uint handle, vtkEventDataDevice device)
		{
			vtkVRRenderWindow.vtkVRRenderWindow_AddDeviceHandle_02(base.GetCppThis(), handle, device);
		}

		// Token: 0x06001E4D RID: 7757
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_AddRenderer_03(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Add a renderer to the list of renderers.
		/// </summary>
		// Token: 0x06001E4E RID: 7758 RVA: 0x0002ED7C File Offset: 0x0002CF7C
		public override void AddRenderer(vtkRenderer arg0)
		{
			vtkVRRenderWindow.vtkVRRenderWindow_AddRenderer_03(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06001E4F RID: 7759
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_BaseStationVisibilityOff_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the visibility of the base stations. Defaults to false
		/// </summary>
		// Token: 0x06001E50 RID: 7760 RVA: 0x0002EDAB File Offset: 0x0002CFAB
		public virtual void BaseStationVisibilityOff()
		{
			vtkVRRenderWindow.vtkVRRenderWindow_BaseStationVisibilityOff_04(base.GetCppThis());
		}

		// Token: 0x06001E51 RID: 7761
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_BaseStationVisibilityOn_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the visibility of the base stations. Defaults to false
		/// </summary>
		// Token: 0x06001E52 RID: 7762 RVA: 0x0002EDBA File Offset: 0x0002CFBA
		public virtual void BaseStationVisibilityOn()
		{
			vtkVRRenderWindow.vtkVRRenderWindow_BaseStationVisibilityOn_05(base.GetCppThis());
		}

		// Token: 0x06001E53 RID: 7763
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVRRenderWindow_GetBaseStationVisibility_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the visibility of the base stations. Defaults to false
		/// </summary>
		// Token: 0x06001E54 RID: 7764 RVA: 0x0002EDCC File Offset: 0x0002CFCC
		public virtual bool GetBaseStationVisibility()
		{
			return vtkVRRenderWindow.vtkVRRenderWindow_GetBaseStationVisibility_06(base.GetCppThis()) != 0;
		}

		// Token: 0x06001E55 RID: 7765
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkEventDataDevice vtkVRRenderWindow_GetDeviceForDeviceHandle_07(HandleRef pThis, uint handle);

		/// <summary>
		/// Get the DeviceToPhysical matrix corresponding to the device or device handle.
		/// e.g. 0,0,0,1 pushed through this matrix will give you the location of the
		/// device in physical coordinates.
		/// </summary>
		// Token: 0x06001E56 RID: 7766 RVA: 0x0002EDF4 File Offset: 0x0002CFF4
		public vtkEventDataDevice GetDeviceForDeviceHandle(uint handle)
		{
			return vtkVRRenderWindow.vtkVRRenderWindow_GetDeviceForDeviceHandle_07(base.GetCppThis(), handle);
		}

		// Token: 0x06001E57 RID: 7767
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkVRRenderWindow_GetDeviceHandleForDevice_08(HandleRef pThis, vtkEventDataDevice dev, uint index);

		/// <summary>
		/// Get the DeviceToPhysical matrix corresponding to the device or device handle.
		/// e.g. 0,0,0,1 pushed through this matrix will give you the location of the
		/// device in physical coordinates.
		/// </summary>
		// Token: 0x06001E58 RID: 7768 RVA: 0x0002EE14 File Offset: 0x0002D014
		public uint GetDeviceHandleForDevice(vtkEventDataDevice dev, uint index)
		{
			return vtkVRRenderWindow.vtkVRRenderWindow_GetDeviceHandleForDevice_08(base.GetCppThis(), dev, index);
		}

		// Token: 0x06001E59 RID: 7769
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRRenderWindow_GetDeviceToPhysicalMatrixForDevice_09(HandleRef pThis, vtkEventDataDevice idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the DeviceToPhysical matrix corresponding to the device or device handle.
		/// e.g. 0,0,0,1 pushed through this matrix will give you the location of the
		/// device in physical coordinates.
		/// </summary>
		// Token: 0x06001E5A RID: 7770 RVA: 0x0002EE38 File Offset: 0x0002D038
		public vtkMatrix4x4 GetDeviceToPhysicalMatrixForDevice(vtkEventDataDevice idx)
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRRenderWindow.vtkVRRenderWindow_GetDeviceToPhysicalMatrixForDevice_09(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x06001E5B RID: 7771
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRRenderWindow_GetDeviceToPhysicalMatrixForDeviceHandle_10(HandleRef pThis, uint handle, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the DeviceToPhysical matrix corresponding to the device or device handle.
		/// e.g. 0,0,0,1 pushed through this matrix will give you the location of the
		/// device in physical coordinates.
		/// </summary>
		// Token: 0x06001E5C RID: 7772 RVA: 0x0002EEA8 File Offset: 0x0002D0A8
		public vtkMatrix4x4 GetDeviceToPhysicalMatrixForDeviceHandle(uint handle)
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRRenderWindow.vtkVRRenderWindow_GetDeviceToPhysicalMatrixForDeviceHandle_10(base.GetCppThis(), handle, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x06001E5D RID: 7773
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVRRenderWindow_GetDeviceToWorldMatrixForDevice_11(HandleRef pThis, vtkEventDataDevice device, HandleRef deviceToWorldMatrix);

		/// <summary>
		/// Store in \p deviceToWorldMatrix the matrix that goes from device coordinates
		/// to world coordinates. e.g. if you push 0,0,0,1 through this matrix you will get
		/// the location of the device in world coordinates.
		/// Return true if the query is valid, else false.
		/// </summary>
		// Token: 0x06001E5E RID: 7774 RVA: 0x0002EF18 File Offset: 0x0002D118
		public override bool GetDeviceToWorldMatrixForDevice(vtkEventDataDevice device, vtkMatrix4x4 deviceToWorldMatrix)
		{
			return vtkVRRenderWindow.vtkVRRenderWindow_GetDeviceToWorldMatrixForDevice_11(base.GetCppThis(), device, (deviceToWorldMatrix == null) ? default(HandleRef) : deviceToWorldMatrix.GetCppThis()) != 0;
		}

		// Token: 0x06001E5F RID: 7775
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVRRenderWindow_GetDeviceToWorldMatrixForDeviceHandle_12(HandleRef pThis, uint handle, HandleRef deviceToWorldMatrix);

		/// <summary>
		/// Store in \p deviceToWorldMatrix the matrix that goes from device coordinates
		/// to world coordinates. e.g. if you push 0,0,0,1 through this matrix you will get
		/// the location of the device in world coordinates.
		/// Return true if the query is valid, else false.
		/// </summary>
		// Token: 0x06001E60 RID: 7776 RVA: 0x0002EF54 File Offset: 0x0002D154
		public virtual bool GetDeviceToWorldMatrixForDeviceHandle(uint handle, vtkMatrix4x4 deviceToWorldMatrix)
		{
			return vtkVRRenderWindow.vtkVRRenderWindow_GetDeviceToWorldMatrixForDeviceHandle_12(base.GetCppThis(), handle, (deviceToWorldMatrix == null) ? default(HandleRef) : deviceToWorldMatrix.GetCppThis()) != 0;
		}

		// Token: 0x06001E61 RID: 7777
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRRenderWindow_GetEventPending_13(HandleRef pThis);

		/// <summary>
		/// Check to see if a mouse button has been pressed or mouse wheel activated.
		/// All other events are ignored by this method.
		/// Maybe should return 1 always?
		/// </summary>
		// Token: 0x06001E62 RID: 7778 RVA: 0x0002EF90 File Offset: 0x0002D190
		public override int GetEventPending()
		{
			return vtkVRRenderWindow.vtkVRRenderWindow_GetEventPending_13(base.GetCppThis());
		}

		// Token: 0x06001E63 RID: 7779
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRRenderWindow_GetGenericContext_14(HandleRef pThis);

		/// <summary>
		/// Implement required virtual functions.
		/// </summary>
		// Token: 0x06001E64 RID: 7780 RVA: 0x0002EFB0 File Offset: 0x0002D1B0
		public override IntPtr GetGenericContext()
		{
			return vtkVRRenderWindow.vtkVRRenderWindow_GetGenericContext_14(base.GetCppThis());
		}

		// Token: 0x06001E65 RID: 7781
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRRenderWindow_GetGenericDisplayId_15(HandleRef pThis);

		/// <summary>
		/// Implement required virtual functions.
		/// </summary>
		// Token: 0x06001E66 RID: 7782 RVA: 0x0002EFD0 File Offset: 0x0002D1D0
		public override IntPtr GetGenericDisplayId()
		{
			return vtkVRRenderWindow.vtkVRRenderWindow_GetGenericDisplayId_15(base.GetCppThis());
		}

		// Token: 0x06001E67 RID: 7783
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRRenderWindow_GetGenericDrawable_16(HandleRef pThis);

		/// <summary>
		/// Implement required virtual functions.
		/// </summary>
		// Token: 0x06001E68 RID: 7784 RVA: 0x0002EFF0 File Offset: 0x0002D1F0
		public override IntPtr GetGenericDrawable()
		{
			return vtkVRRenderWindow.vtkVRRenderWindow_GetGenericDrawable_16(base.GetCppThis());
		}

		// Token: 0x06001E69 RID: 7785
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRRenderWindow_GetGenericParentId_17(HandleRef pThis);

		/// <summary>
		/// Implement required virtual functions.
		/// </summary>
		// Token: 0x06001E6A RID: 7786 RVA: 0x0002F010 File Offset: 0x0002D210
		public override IntPtr GetGenericParentId()
		{
			return vtkVRRenderWindow.vtkVRRenderWindow_GetGenericParentId_17(base.GetCppThis());
		}

		// Token: 0x06001E6B RID: 7787
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRRenderWindow_GetGenericWindowId_18(HandleRef pThis);

		/// <summary>
		/// Implement required virtual functions.
		/// </summary>
		// Token: 0x06001E6C RID: 7788 RVA: 0x0002F030 File Offset: 0x0002D230
		public override IntPtr GetGenericWindowId()
		{
			return vtkVRRenderWindow.vtkVRRenderWindow_GetGenericWindowId_18(base.GetCppThis());
		}

		// Token: 0x06001E6D RID: 7789
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRRenderWindow_GetHelperWindow_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the window to use for the openGL context
		/// </summary>
		// Token: 0x06001E6E RID: 7790 RVA: 0x0002F050 File Offset: 0x0002D250
		public virtual vtkOpenGLRenderWindow GetHelperWindow()
		{
			vtkOpenGLRenderWindow vtkOpenGLRenderWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRRenderWindow.vtkVRRenderWindow_GetHelperWindow_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLRenderWindow = (vtkOpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLRenderWindow.Register(null);
				}
			}
			return vtkOpenGLRenderWindow;
		}

		// Token: 0x06001E6F RID: 7791
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkVRRenderWindow_GetLeftResolveBufferId_20(HandleRef pThis);

		/// <summary>
		/// Get the frame buffers used for rendering
		/// </summary>
		// Token: 0x06001E70 RID: 7792 RVA: 0x0002F0C0 File Offset: 0x0002D2C0
		public uint GetLeftResolveBufferId()
		{
			return vtkVRRenderWindow.vtkVRRenderWindow_GetLeftResolveBufferId_20(base.GetCppThis());
		}

		// Token: 0x06001E71 RID: 7793
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRRenderWindow_GetModelForDevice_21(HandleRef pThis, vtkEventDataDevice idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the VRModel corresponding to the device or device handle.
		/// </summary>
		// Token: 0x06001E72 RID: 7794 RVA: 0x0002F0E0 File Offset: 0x0002D2E0
		public vtkVRModel GetModelForDevice(vtkEventDataDevice idx)
		{
			vtkVRModel vtkVRModel = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRRenderWindow.vtkVRRenderWindow_GetModelForDevice_21(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVRModel = (vtkVRModel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVRModel.Register(null);
				}
			}
			return vtkVRModel;
		}

		// Token: 0x06001E73 RID: 7795
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRRenderWindow_GetModelForDeviceHandle_22(HandleRef pThis, uint handle, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the VRModel corresponding to the device or device handle.
		/// </summary>
		// Token: 0x06001E74 RID: 7796 RVA: 0x0002F150 File Offset: 0x0002D350
		public vtkVRModel GetModelForDeviceHandle(uint handle)
		{
			vtkVRModel vtkVRModel = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRRenderWindow.vtkVRRenderWindow_GetModelForDeviceHandle_22(base.GetCppThis(), handle, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVRModel = (vtkVRModel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVRModel.Register(null);
				}
			}
			return vtkVRModel;
		}

		// Token: 0x06001E75 RID: 7797
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkVRRenderWindow_GetNumberOfDeviceHandlesForDevice_23(HandleRef pThis, vtkEventDataDevice dev);

		/// <summary>
		/// Get the DeviceToPhysical matrix corresponding to the device or device handle.
		/// e.g. 0,0,0,1 pushed through this matrix will give you the location of the
		/// device in physical coordinates.
		/// </summary>
		// Token: 0x06001E76 RID: 7798 RVA: 0x0002F1C0 File Offset: 0x0002D3C0
		public uint GetNumberOfDeviceHandlesForDevice(vtkEventDataDevice dev)
		{
			return vtkVRRenderWindow.vtkVRRenderWindow_GetNumberOfDeviceHandlesForDevice_23(base.GetCppThis(), dev);
		}

		// Token: 0x06001E77 RID: 7799
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRRenderWindow_GetNumberOfGenerationsFromBase_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001E78 RID: 7800 RVA: 0x0002F1E0 File Offset: 0x0002D3E0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVRRenderWindow.vtkVRRenderWindow_GetNumberOfGenerationsFromBase_24(base.GetCppThis(), type);
		}

		// Token: 0x06001E79 RID: 7801
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRRenderWindow_GetNumberOfGenerationsFromBaseType_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001E7A RID: 7802 RVA: 0x0002F200 File Offset: 0x0002D400
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVRRenderWindow.vtkVRRenderWindow_GetNumberOfGenerationsFromBaseType_25(type);
		}

		// Token: 0x06001E7B RID: 7803
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVRRenderWindow_GetPhysicalScale_26(HandleRef pThis);

		/// <summary>
		/// Set/get physical coordinate system in world coordinate system.
		///
		/// Ratio of distance in world coordinate and physical and system
		/// (PhysicalScale = distance_World / distance_Physical).
		/// Example: if world coordinate system is in mm then
		/// PhysicalScale = 1000.0 makes objects appear in real size.
		/// PhysicalScale = 100.0 makes objects appear 10x larger than real size.
		/// </summary>
		// Token: 0x06001E7C RID: 7804 RVA: 0x0002F21C File Offset: 0x0002D41C
		public virtual double GetPhysicalScale()
		{
			return vtkVRRenderWindow.vtkVRRenderWindow_GetPhysicalScale_26(base.GetCppThis());
		}

		// Token: 0x06001E7D RID: 7805
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_GetPhysicalToWorldMatrix_27(HandleRef pThis, HandleRef matrix);

		/// <summary>
		/// Get physical to world transform matrix. Members used to calculate the matrix:
		/// \sa PhysicalViewDirection, \sa PhysicalViewUp, \sa PhysicalTranslation, \sa PhysicalScale
		/// </summary>
		// Token: 0x06001E7E RID: 7806 RVA: 0x0002F23C File Offset: 0x0002D43C
		public override void GetPhysicalToWorldMatrix(vtkMatrix4x4 matrix)
		{
			vtkVRRenderWindow.vtkVRRenderWindow_GetPhysicalToWorldMatrix_27(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		// Token: 0x06001E7F RID: 7807
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRRenderWindow_GetPhysicalTranslation_28(HandleRef pThis);

		/// <summary>
		/// Set/get physical coordinate system in world coordinate system.
		///
		/// Position of the physical coordinate system origin
		/// in world coordinates.
		/// \sa SetPhysicalViewDirection, \sa SetPhysicalViewUp,
		/// \sa SetPhysicalScale, \sa SetPhysicalToWorldMatrix
		/// </summary>
		// Token: 0x06001E80 RID: 7808 RVA: 0x0002F26C File Offset: 0x0002D46C
		public virtual double[] GetPhysicalTranslation()
		{
			IntPtr intPtr = vtkVRRenderWindow.vtkVRRenderWindow_GetPhysicalTranslation_28(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06001E81 RID: 7809
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_GetPhysicalTranslation_29(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/get physical coordinate system in world coordinate system.
		///
		/// Position of the physical coordinate system origin
		/// in world coordinates.
		/// \sa SetPhysicalViewDirection, \sa SetPhysicalViewUp,
		/// \sa SetPhysicalScale, \sa SetPhysicalToWorldMatrix
		/// </summary>
		// Token: 0x06001E82 RID: 7810 RVA: 0x0002F2B4 File Offset: 0x0002D4B4
		public virtual void GetPhysicalTranslation(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkVRRenderWindow.vtkVRRenderWindow_GetPhysicalTranslation_29(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06001E83 RID: 7811
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_GetPhysicalTranslation_30(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get physical coordinate system in world coordinate system.
		///
		/// Position of the physical coordinate system origin
		/// in world coordinates.
		/// \sa SetPhysicalViewDirection, \sa SetPhysicalViewUp,
		/// \sa SetPhysicalScale, \sa SetPhysicalToWorldMatrix
		/// </summary>
		// Token: 0x06001E84 RID: 7812 RVA: 0x0002F2C6 File Offset: 0x0002D4C6
		public virtual void GetPhysicalTranslation(IntPtr _arg)
		{
			vtkVRRenderWindow.vtkVRRenderWindow_GetPhysicalTranslation_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06001E85 RID: 7813
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRRenderWindow_GetPhysicalViewDirection_31(HandleRef pThis);

		/// <summary>
		/// Set/get physical coordinate system in world coordinate system.
		///
		/// View direction is the -Z axis of the physical coordinate system
		/// in world coordinate system.
		/// \sa SetPhysicalViewUp, \sa SetPhysicalTranslation,
		/// \sa SetPhysicalScale, \sa SetPhysicalToWorldMatrix
		/// </summary>
		// Token: 0x06001E86 RID: 7814 RVA: 0x0002F2D8 File Offset: 0x0002D4D8
		public virtual double[] GetPhysicalViewDirection()
		{
			IntPtr intPtr = vtkVRRenderWindow.vtkVRRenderWindow_GetPhysicalViewDirection_31(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06001E87 RID: 7815
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_GetPhysicalViewDirection_32(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/get physical coordinate system in world coordinate system.
		///
		/// View direction is the -Z axis of the physical coordinate system
		/// in world coordinate system.
		/// \sa SetPhysicalViewUp, \sa SetPhysicalTranslation,
		/// \sa SetPhysicalScale, \sa SetPhysicalToWorldMatrix
		/// </summary>
		// Token: 0x06001E88 RID: 7816 RVA: 0x0002F320 File Offset: 0x0002D520
		public virtual void GetPhysicalViewDirection(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkVRRenderWindow.vtkVRRenderWindow_GetPhysicalViewDirection_32(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06001E89 RID: 7817
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_GetPhysicalViewDirection_33(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get physical coordinate system in world coordinate system.
		///
		/// View direction is the -Z axis of the physical coordinate system
		/// in world coordinate system.
		/// \sa SetPhysicalViewUp, \sa SetPhysicalTranslation,
		/// \sa SetPhysicalScale, \sa SetPhysicalToWorldMatrix
		/// </summary>
		// Token: 0x06001E8A RID: 7818 RVA: 0x0002F332 File Offset: 0x0002D532
		public virtual void GetPhysicalViewDirection(IntPtr _arg)
		{
			vtkVRRenderWindow.vtkVRRenderWindow_GetPhysicalViewDirection_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06001E8B RID: 7819
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRRenderWindow_GetPhysicalViewUp_34(HandleRef pThis);

		/// <summary>
		/// Set/get physical coordinate system in world coordinate system.
		///
		/// View up is the +Y axis of the physical coordinate system
		/// in world coordinate system.
		/// \sa SetPhysicalViewDirection, \sa SetPhysicalTranslation,
		/// \sa SetPhysicalScale, \sa SetPhysicalToWorldMatrix
		/// </summary>
		// Token: 0x06001E8C RID: 7820 RVA: 0x0002F344 File Offset: 0x0002D544
		public virtual double[] GetPhysicalViewUp()
		{
			IntPtr intPtr = vtkVRRenderWindow.vtkVRRenderWindow_GetPhysicalViewUp_34(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06001E8D RID: 7821
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_GetPhysicalViewUp_35(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/get physical coordinate system in world coordinate system.
		///
		/// View up is the +Y axis of the physical coordinate system
		/// in world coordinate system.
		/// \sa SetPhysicalViewDirection, \sa SetPhysicalTranslation,
		/// \sa SetPhysicalScale, \sa SetPhysicalToWorldMatrix
		/// </summary>
		// Token: 0x06001E8E RID: 7822 RVA: 0x0002F38C File Offset: 0x0002D58C
		public virtual void GetPhysicalViewUp(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkVRRenderWindow.vtkVRRenderWindow_GetPhysicalViewUp_35(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06001E8F RID: 7823
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_GetPhysicalViewUp_36(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get physical coordinate system in world coordinate system.
		///
		/// View up is the +Y axis of the physical coordinate system
		/// in world coordinate system.
		/// \sa SetPhysicalViewDirection, \sa SetPhysicalTranslation,
		/// \sa SetPhysicalScale, \sa SetPhysicalToWorldMatrix
		/// </summary>
		// Token: 0x06001E90 RID: 7824 RVA: 0x0002F39E File Offset: 0x0002D59E
		public virtual void GetPhysicalViewUp(IntPtr _arg)
		{
			vtkVRRenderWindow.vtkVRRenderWindow_GetPhysicalViewUp_36(base.GetCppThis(), _arg);
		}

		// Token: 0x06001E91 RID: 7825
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_GetRenderBufferSize_37(HandleRef pThis, ref int width, ref int height);

		/// <summary>
		/// Get the frame buffers used for rendering
		/// </summary>
		// Token: 0x06001E92 RID: 7826 RVA: 0x0002F3AE File Offset: 0x0002D5AE
		public void GetRenderBufferSize(ref int width, ref int height)
		{
			vtkVRRenderWindow.vtkVRRenderWindow_GetRenderBufferSize_37(base.GetCppThis(), ref width, ref height);
		}

		// Token: 0x06001E93 RID: 7827
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkVRRenderWindow_GetRightResolveBufferId_38(HandleRef pThis);

		/// <summary>
		/// Get the frame buffers used for rendering
		/// </summary>
		// Token: 0x06001E94 RID: 7828 RVA: 0x0002F3C0 File Offset: 0x0002D5C0
		public uint GetRightResolveBufferId()
		{
			return vtkVRRenderWindow.vtkVRRenderWindow_GetRightResolveBufferId_38(base.GetCppThis());
		}

		// Token: 0x06001E95 RID: 7829
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRRenderWindow_GetScreenSize_39(HandleRef pThis);

		/// <summary>
		/// Get the current size of the screen in pixels.
		/// </summary>
		// Token: 0x06001E96 RID: 7830 RVA: 0x0002F3E0 File Offset: 0x0002D5E0
		public override int[] GetScreenSize()
		{
			IntPtr intPtr = vtkVRRenderWindow.vtkVRRenderWindow_GetScreenSize_39(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06001E97 RID: 7831
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVRRenderWindow_GetTrackHMD_40(HandleRef pThis);

		/// <summary>
		/// When on the camera will track the HMD position.
		/// On is the default.
		/// </summary>
		// Token: 0x06001E98 RID: 7832 RVA: 0x0002F428 File Offset: 0x0002D628
		public virtual bool GetTrackHMD()
		{
			return vtkVRRenderWindow.vtkVRRenderWindow_GetTrackHMD_40(base.GetCppThis()) != 0;
		}

		// Token: 0x06001E99 RID: 7833
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVRRenderWindow_GetVRInitialized_41(HandleRef pThis);

		/// <summary>
		/// Get whether the XR components of the window
		/// have been initialized successfully.
		/// </summary>
		// Token: 0x06001E9A RID: 7834 RVA: 0x0002F450 File Offset: 0x0002D650
		public virtual bool GetVRInitialized()
		{
			return vtkVRRenderWindow.vtkVRRenderWindow_GetVRInitialized_41(base.GetCppThis()) != 0;
		}

		// Token: 0x06001E9B RID: 7835
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_InitializeViewFromCamera_42(HandleRef pThis, HandleRef cam);

		/// <summary>
		/// Initialize the HMD to World setting and camera settings so that the VR
		/// world view most closely matched the view from the provided camera. This
		/// method is useful for initializing a VR world from an existing on screen
		/// window and camera. The Renderer and its camera must already be created
		/// and set when this is called.
		/// </summary>
		// Token: 0x06001E9C RID: 7836 RVA: 0x0002F478 File Offset: 0x0002D678
		public virtual void InitializeViewFromCamera(vtkCamera cam)
		{
			vtkVRRenderWindow.vtkVRRenderWindow_InitializeViewFromCamera_42(base.GetCppThis(), (cam == null) ? default(HandleRef) : cam.GetCppThis());
		}

		// Token: 0x06001E9D RID: 7837
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRRenderWindow_IsA_43(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001E9E RID: 7838 RVA: 0x0002F4A8 File Offset: 0x0002D6A8
		public override int IsA(string type)
		{
			return vtkVRRenderWindow.vtkVRRenderWindow_IsA_43(base.GetCppThis(), type);
		}

		// Token: 0x06001E9F RID: 7839
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVRRenderWindow_IsCurrent_44(HandleRef pThis);

		/// <summary>
		/// Tells if this window is the current OpenGL context for the calling thread.
		/// </summary>
		// Token: 0x06001EA0 RID: 7840 RVA: 0x0002F4C8 File Offset: 0x0002D6C8
		public override bool IsCurrent()
		{
			return vtkVRRenderWindow.vtkVRRenderWindow_IsCurrent_44(base.GetCppThis()) != 0;
		}

		// Token: 0x06001EA1 RID: 7841
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRRenderWindow_IsDirect_45(HandleRef pThis);

		/// <summary>
		/// Is this render window using hardware acceleration? 0-false, 1-true
		/// </summary>
		// Token: 0x06001EA2 RID: 7842 RVA: 0x0002F4F0 File Offset: 0x0002D6F0
		public override int IsDirect()
		{
			return vtkVRRenderWindow.vtkVRRenderWindow_IsDirect_45(base.GetCppThis());
		}

		// Token: 0x06001EA3 RID: 7843
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRRenderWindow_IsTypeOf_46([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001EA4 RID: 7844 RVA: 0x0002F510 File Offset: 0x0002D710
		public new static int IsTypeOf(string type)
		{
			return vtkVRRenderWindow.vtkVRRenderWindow_IsTypeOf_46(type);
		}

		// Token: 0x06001EA5 RID: 7845
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_MakeCurrent_47(HandleRef pThis);

		/// <summary>
		/// Make this windows OpenGL context the current context.
		/// </summary>
		// Token: 0x06001EA6 RID: 7846 RVA: 0x0002F52A File Offset: 0x0002D72A
		public override void MakeCurrent()
		{
			vtkVRRenderWindow.vtkVRRenderWindow_MakeCurrent_47(base.GetCppThis());
		}

		// Token: 0x06001EA7 RID: 7847
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRRenderWindow_MakeRenderWindowInteractor_48(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create an interactor to control renderers in this window. Must be
		/// overridden to instantiate a specific interactor depending on the API
		/// </summary>
		// Token: 0x06001EA8 RID: 7848 RVA: 0x0002F53C File Offset: 0x0002D73C
		public override vtkRenderWindowInteractor MakeRenderWindowInteractor()
		{
			vtkRenderWindowInteractor vtkRenderWindowInteractor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRRenderWindow.vtkVRRenderWindow_MakeRenderWindowInteractor_48(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindowInteractor = (vtkRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindowInteractor.Register(null);
				}
			}
			return vtkRenderWindowInteractor;
		}

		// Token: 0x06001EA9 RID: 7849
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRRenderWindow_NewInstance_49(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001EAA RID: 7850 RVA: 0x0002F5AC File Offset: 0x0002D7AC
		public new vtkVRRenderWindow NewInstance()
		{
			vtkVRRenderWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRRenderWindow.vtkVRRenderWindow_NewInstance_49(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVRRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001EAB RID: 7851
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_ReleaseCurrent_50(HandleRef pThis);

		/// <summary>
		/// Release the current context.
		/// </summary>
		// Token: 0x06001EAC RID: 7852 RVA: 0x0002F606 File Offset: 0x0002D806
		public override void ReleaseCurrent()
		{
			vtkVRRenderWindow.vtkVRRenderWindow_ReleaseCurrent_50(base.GetCppThis());
		}

		// Token: 0x06001EAD RID: 7853
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_ReleaseGraphicsResources_51(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Free up any graphics resources associated with this window
		/// a value of nullptr means the context may already be destroyed
		/// </summary>
		// Token: 0x06001EAE RID: 7854 RVA: 0x0002F618 File Offset: 0x0002D818
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkVRRenderWindow.vtkVRRenderWindow_ReleaseGraphicsResources_51(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06001EAF RID: 7855
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_Render_52(HandleRef pThis);

		/// <summary>
		/// Overridden to not release resources that would interfere with an external
		/// application's rendering. Avoiding round trip.
		/// </summary>
		// Token: 0x06001EB0 RID: 7856 RVA: 0x0002F647 File Offset: 0x0002D847
		public override void Render()
		{
			vtkVRRenderWindow.vtkVRRenderWindow_Render_52(base.GetCppThis());
		}

		// Token: 0x06001EB1 RID: 7857
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_RenderModels_53(HandleRef pThis);

		/// <summary>
		/// Render the controller and base station models
		/// </summary>
		// Token: 0x06001EB2 RID: 7858 RVA: 0x0002F656 File Offset: 0x0002D856
		public virtual void RenderModels()
		{
			vtkVRRenderWindow.vtkVRRenderWindow_RenderModels_53(base.GetCppThis());
		}

		// Token: 0x06001EB3 RID: 7859
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRRenderWindow_ReportCapabilities_54(HandleRef pThis);

		/// <summary>
		/// Get report of capabilities for the render window
		/// </summary>
		// Token: 0x06001EB4 RID: 7860 RVA: 0x0002F668 File Offset: 0x0002D868
		public override string ReportCapabilities()
		{
			string s = Marshal.PtrToStringAnsi(vtkVRRenderWindow.vtkVRRenderWindow_ReportCapabilities_54(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001EB5 RID: 7861
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRRenderWindow_SafeDownCast_55(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001EB6 RID: 7862 RVA: 0x0002F6A4 File Offset: 0x0002D8A4
		public new static vtkVRRenderWindow SafeDownCast(vtkObjectBase o)
		{
			vtkVRRenderWindow vtkVRRenderWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRRenderWindow.vtkVRRenderWindow_SafeDownCast_55((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVRRenderWindow = (vtkVRRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVRRenderWindow.Register(null);
				}
			}
			return vtkVRRenderWindow;
		}

		// Token: 0x06001EB7 RID: 7863
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_SetBaseStationVisibility_56(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get the visibility of the base stations. Defaults to false
		/// </summary>
		// Token: 0x06001EB8 RID: 7864 RVA: 0x0002F723 File Offset: 0x0002D923
		public virtual void SetBaseStationVisibility(bool _arg)
		{
			vtkVRRenderWindow.vtkVRRenderWindow_SetBaseStationVisibility_56(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06001EB9 RID: 7865
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_SetHelperWindow_57(HandleRef pThis, HandleRef val);

		/// <summary>
		/// Set/Get the window to use for the openGL context
		/// </summary>
		// Token: 0x06001EBA RID: 7866 RVA: 0x0002F73C File Offset: 0x0002D93C
		public void SetHelperWindow(vtkOpenGLRenderWindow val)
		{
			vtkVRRenderWindow.vtkVRRenderWindow_SetHelperWindow_57(base.GetCppThis(), (val == null) ? default(HandleRef) : val.GetCppThis());
		}

		// Token: 0x06001EBB RID: 7867
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_SetModelForDeviceHandle_58(HandleRef pThis, uint handle, HandleRef model);

		/// <summary>
		/// Set the VRModel corresponding to the device handle
		/// </summary>
		// Token: 0x06001EBC RID: 7868 RVA: 0x0002F76C File Offset: 0x0002D96C
		public void SetModelForDeviceHandle(uint handle, vtkVRModel model)
		{
			vtkVRRenderWindow.vtkVRRenderWindow_SetModelForDeviceHandle_58(base.GetCppThis(), handle, (model == null) ? default(HandleRef) : model.GetCppThis());
		}

		// Token: 0x06001EBD RID: 7869
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_SetPhysicalScale_59(HandleRef pThis, double arg0);

		/// <summary>
		/// Set/get physical coordinate system in world coordinate system.
		///
		/// Ratio of distance in world coordinate and physical and system
		/// (PhysicalScale = distance_World / distance_Physical).
		/// Example: if world coordinate system is in mm then
		/// PhysicalScale = 1000.0 makes objects appear in real size.
		/// PhysicalScale = 100.0 makes objects appear 10x larger than real size.
		/// </summary>
		// Token: 0x06001EBE RID: 7870 RVA: 0x0002F79C File Offset: 0x0002D99C
		public virtual void SetPhysicalScale(double arg0)
		{
			vtkVRRenderWindow.vtkVRRenderWindow_SetPhysicalScale_59(base.GetCppThis(), arg0);
		}

		// Token: 0x06001EBF RID: 7871
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_SetPhysicalToWorldMatrix_60(HandleRef pThis, HandleRef matrix);

		/// <summary>
		/// Set physical to world transform matrix. Members calculated and set from the matrix:
		/// \sa PhysicalViewDirection, \sa PhysicalViewUp, \sa PhysicalTranslation, \sa PhysicalScale
		/// The x axis scale is used for \sa PhysicalScale
		/// </summary>
		// Token: 0x06001EC0 RID: 7872 RVA: 0x0002F7AC File Offset: 0x0002D9AC
		public void SetPhysicalToWorldMatrix(vtkMatrix4x4 matrix)
		{
			vtkVRRenderWindow.vtkVRRenderWindow_SetPhysicalToWorldMatrix_60(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		// Token: 0x06001EC1 RID: 7873
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_SetPhysicalTranslation_61(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Set/get physical coordinate system in world coordinate system.
		///
		/// Position of the physical coordinate system origin
		/// in world coordinates.
		/// \sa SetPhysicalViewDirection, \sa SetPhysicalViewUp,
		/// \sa SetPhysicalScale, \sa SetPhysicalToWorldMatrix
		/// </summary>
		// Token: 0x06001EC2 RID: 7874 RVA: 0x0002F7DB File Offset: 0x0002D9DB
		public virtual void SetPhysicalTranslation(double arg0, double arg1, double arg2)
		{
			vtkVRRenderWindow.vtkVRRenderWindow_SetPhysicalTranslation_61(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x06001EC3 RID: 7875
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_SetPhysicalTranslation_62(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Set/get physical coordinate system in world coordinate system.
		///
		/// Position of the physical coordinate system origin
		/// in world coordinates.
		/// \sa SetPhysicalViewDirection, \sa SetPhysicalViewUp,
		/// \sa SetPhysicalScale, \sa SetPhysicalToWorldMatrix
		/// </summary>
		// Token: 0x06001EC4 RID: 7876 RVA: 0x0002F7ED File Offset: 0x0002D9ED
		public virtual void SetPhysicalTranslation(IntPtr arg0)
		{
			vtkVRRenderWindow.vtkVRRenderWindow_SetPhysicalTranslation_62(base.GetCppThis(), arg0);
		}

		// Token: 0x06001EC5 RID: 7877
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_SetPhysicalViewDirection_63(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Set/get physical coordinate system in world coordinate system.
		///
		/// View direction is the -Z axis of the physical coordinate system
		/// in world coordinate system.
		/// \sa SetPhysicalViewUp, \sa SetPhysicalTranslation,
		/// \sa SetPhysicalScale, \sa SetPhysicalToWorldMatrix
		/// </summary>
		// Token: 0x06001EC6 RID: 7878 RVA: 0x0002F7FD File Offset: 0x0002D9FD
		public virtual void SetPhysicalViewDirection(double arg0, double arg1, double arg2)
		{
			vtkVRRenderWindow.vtkVRRenderWindow_SetPhysicalViewDirection_63(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x06001EC7 RID: 7879
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_SetPhysicalViewDirection_64(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Set/get physical coordinate system in world coordinate system.
		///
		/// View direction is the -Z axis of the physical coordinate system
		/// in world coordinate system.
		/// \sa SetPhysicalViewUp, \sa SetPhysicalTranslation,
		/// \sa SetPhysicalScale, \sa SetPhysicalToWorldMatrix
		/// </summary>
		// Token: 0x06001EC8 RID: 7880 RVA: 0x0002F80F File Offset: 0x0002DA0F
		public virtual void SetPhysicalViewDirection(IntPtr arg0)
		{
			vtkVRRenderWindow.vtkVRRenderWindow_SetPhysicalViewDirection_64(base.GetCppThis(), arg0);
		}

		// Token: 0x06001EC9 RID: 7881
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_SetPhysicalViewUp_65(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Set/get physical coordinate system in world coordinate system.
		///
		/// View up is the +Y axis of the physical coordinate system
		/// in world coordinate system.
		/// \sa SetPhysicalViewDirection, \sa SetPhysicalTranslation,
		/// \sa SetPhysicalScale, \sa SetPhysicalToWorldMatrix
		/// </summary>
		// Token: 0x06001ECA RID: 7882 RVA: 0x0002F81F File Offset: 0x0002DA1F
		public virtual void SetPhysicalViewUp(double arg0, double arg1, double arg2)
		{
			vtkVRRenderWindow.vtkVRRenderWindow_SetPhysicalViewUp_65(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x06001ECB RID: 7883
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_SetPhysicalViewUp_66(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Set/get physical coordinate system in world coordinate system.
		///
		/// View up is the +Y axis of the physical coordinate system
		/// in world coordinate system.
		/// \sa SetPhysicalViewDirection, \sa SetPhysicalTranslation,
		/// \sa SetPhysicalScale, \sa SetPhysicalToWorldMatrix
		/// </summary>
		// Token: 0x06001ECC RID: 7884 RVA: 0x0002F831 File Offset: 0x0002DA31
		public virtual void SetPhysicalViewUp(IntPtr arg0)
		{
			vtkVRRenderWindow.vtkVRRenderWindow_SetPhysicalViewUp_66(base.GetCppThis(), arg0);
		}

		// Token: 0x06001ECD RID: 7885
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_SetSize_67(HandleRef pThis, int width, int height);

		/// <summary>
		/// Set the size of the window in screen coordinates in pixels.
		/// This resizes the operating system's window and redraws it.
		///
		/// If the size has changed, this method will fire
		/// vtkCommand::WindowResizeEvent.
		/// </summary>
		// Token: 0x06001ECE RID: 7886 RVA: 0x0002F841 File Offset: 0x0002DA41
		public override void SetSize(int width, int height)
		{
			vtkVRRenderWindow.vtkVRRenderWindow_SetSize_67(base.GetCppThis(), width, height);
		}

		// Token: 0x06001ECF RID: 7887
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_SetSize_68(HandleRef pThis, IntPtr a);

		/// <summary>
		/// Set the size of the window in screen coordinates in pixels.
		/// This resizes the operating system's window and redraws it.
		///
		/// If the size has changed, this method will fire
		/// vtkCommand::WindowResizeEvent.
		/// </summary>
		// Token: 0x06001ED0 RID: 7888 RVA: 0x0002F852 File Offset: 0x0002DA52
		public override void SetSize(IntPtr a)
		{
			vtkVRRenderWindow.vtkVRRenderWindow_SetSize_68(base.GetCppThis(), a);
		}

		// Token: 0x06001ED1 RID: 7889
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_SetTrackHMD_69(HandleRef pThis, byte _arg);

		/// <summary>
		/// When on the camera will track the HMD position.
		/// On is the default.
		/// </summary>
		// Token: 0x06001ED2 RID: 7890 RVA: 0x0002F862 File Offset: 0x0002DA62
		public virtual void SetTrackHMD(bool _arg)
		{
			vtkVRRenderWindow.vtkVRRenderWindow_SetTrackHMD_69(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06001ED3 RID: 7891
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRRenderWindow_SupportsOpenGL_70(HandleRef pThis);

		/// <summary>
		/// Does this render window support OpenGL? 0-false, 1-true
		/// </summary>
		// Token: 0x06001ED4 RID: 7892 RVA: 0x0002F87C File Offset: 0x0002DA7C
		public override int SupportsOpenGL()
		{
			return vtkVRRenderWindow.vtkVRRenderWindow_SupportsOpenGL_70(base.GetCppThis());
		}

		// Token: 0x06001ED5 RID: 7893
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindow_UpdateHMDMatrixPose_71(HandleRef pThis);

		/// <summary>
		/// Update the HMD pose.
		/// </summary>
		// Token: 0x06001ED6 RID: 7894 RVA: 0x0002F89B File Offset: 0x0002DA9B
		public virtual void UpdateHMDMatrixPose()
		{
			vtkVRRenderWindow.vtkVRRenderWindow_UpdateHMDMatrixPose_71(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000507 RID: 1287
		public new const string MRFullTypeName = "Kitware.VTK.vtkVRRenderWindow";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000508 RID: 1288
		public new static readonly string MRClassNameKey = "class vtkVRRenderWindow";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000095 RID: 149
		public enum PhysicalToWorldMatrixModified_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x0400050A RID: 1290
			PhysicalToWorldMatrixModified = 1200
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000096 RID: 150
		public enum LeftEye_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x0400050C RID: 1292
			LeftEye,
			/// <summary>enum member</summary>
			// Token: 0x0400050D RID: 1293
			RightEye
		}
	}
}
