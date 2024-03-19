using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenXRRenderWindow
	/// </summary>
	/// <remarks>
	///    OpenXR rendering window
	///
	///
	/// vtkOpenXRRenderWindow is a concrete implementation of the abstract
	/// class vtkRenderWindow.
	///
	/// This class handles the bulk of interfacing to OpenXR. It supports one
	/// renderer currently. The renderer is assumed to cover the entire window
	/// which is what makes sense to VR. Overlay renderers can probably be
	/// made to work with this but consider how overlays will appear in a
	/// HMD if they do not track the viewpoint etc.
	///
	/// OpenXR provides HMD and controller positions in "Physical" coordinate
	/// system.
	/// Origin: user's eye position at the time of calibration.
	/// Axis directions: x = user's right; y = user's up; z = user's back.
	/// Unit: meter.
	///
	/// Renderer shows actors in World coordinate system. Transformation between
	/// Physical and World coordinate systems is defined by PhysicalToWorldMatrix.
	/// This matrix determines the user's position and orientation in the rendered
	/// scene and scaling (magnification) of rendered actors.
	///
	/// </remarks>
	// Token: 0x02000097 RID: 151
	public class vtkOpenXRRenderWindow : vtkVRRenderWindow
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06001ED7 RID: 7895 RVA: 0x0002F8AA File Offset: 0x0002DAAA
		static vtkOpenXRRenderWindow()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenXRRenderWindow.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenXRRenderWindow"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06001ED8 RID: 7896 RVA: 0x0002F8D2 File Offset: 0x0002DAD2
		public vtkOpenXRRenderWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06001ED9 RID: 7897
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenXRRenderWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001EDA RID: 7898 RVA: 0x0002F8E0 File Offset: 0x0002DAE0
		public new static vtkOpenXRRenderWindow New()
		{
			vtkOpenXRRenderWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenXRRenderWindow.vtkOpenXRRenderWindow_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenXRRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001EDB RID: 7899 RVA: 0x0002F934 File Offset: 0x0002DB34
		public vtkOpenXRRenderWindow() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenXRRenderWindow.vtkOpenXRRenderWindow_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06001EDC RID: 7900 RVA: 0x0002F978 File Offset: 0x0002DB78
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06001EDD RID: 7901
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenXRRenderWindow_AddRenderer_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Add a renderer to the list of renderers.
		/// </summary>
		// Token: 0x06001EDE RID: 7902 RVA: 0x0002F984 File Offset: 0x0002DB84
		public override void AddRenderer(vtkRenderer arg0)
		{
			vtkOpenXRRenderWindow.vtkOpenXRRenderWindow_AddRenderer_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06001EDF RID: 7903
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenXRRenderWindow_Finalize_02(HandleRef pThis);

		/// <summary>
		/// Finalize the rendering window.  This will shutdown all system-specific
		/// resources.  After having called this, it should be possible to destroy
		/// a window that was used for a SetWindowId() call without any ill effects.
		/// </summary>
		// Token: 0x06001EE0 RID: 7904 RVA: 0x0002F9B3 File Offset: 0x0002DBB3
		public override void FinalizeWrapper()
		{
			vtkOpenXRRenderWindow.vtkOpenXRRenderWindow_Finalize_02(base.GetCppThis());
		}

		// Token: 0x06001EE1 RID: 7905
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkEventDataDevice vtkOpenXRRenderWindow_GetDeviceForOpenXRHandle_03(HandleRef pThis, uint ohandle);

		/// <summary>
		/// Set the active state (active: true / inactive: false) of the specified hand.
		/// </summary>
		// Token: 0x06001EE2 RID: 7906 RVA: 0x0002F9C4 File Offset: 0x0002DBC4
		public vtkEventDataDevice GetDeviceForOpenXRHandle(uint ohandle)
		{
			return vtkOpenXRRenderWindow.vtkOpenXRRenderWindow_GetDeviceForOpenXRHandle_03(base.GetCppThis(), ohandle);
		}

		// Token: 0x06001EE3 RID: 7907
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkOpenXRRenderWindow_GetDeviceHandleForOpenXRHandle_04(HandleRef pThis, uint index);

		/// <summary>
		/// Set the active state (active: true / inactive: false) of the specified hand.
		/// </summary>
		// Token: 0x06001EE4 RID: 7908 RVA: 0x0002F9E4 File Offset: 0x0002DBE4
		public uint GetDeviceHandleForOpenXRHandle(uint index)
		{
			return vtkOpenXRRenderWindow.vtkOpenXRRenderWindow_GetDeviceHandleForOpenXRHandle_04(base.GetCppThis(), index);
		}

		// Token: 0x06001EE5 RID: 7909
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenXRRenderWindow_GetEventPending_05(HandleRef pThis);

		/// <summary>
		/// Check to see if a mouse button has been pressed or mouse wheel activated.
		/// All other events are ignored by this method.
		/// Maybe should return 1 always?
		/// </summary>
		// Token: 0x06001EE6 RID: 7910 RVA: 0x0002FA04 File Offset: 0x0002DC04
		public override int GetEventPending()
		{
			return vtkOpenXRRenderWindow.vtkOpenXRRenderWindow_GetEventPending_05(base.GetCppThis());
		}

		// Token: 0x06001EE7 RID: 7911
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenXRRenderWindow_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001EE8 RID: 7912 RVA: 0x0002FA24 File Offset: 0x0002DC24
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenXRRenderWindow.vtkOpenXRRenderWindow_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06001EE9 RID: 7913
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenXRRenderWindow_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001EEA RID: 7914 RVA: 0x0002FA44 File Offset: 0x0002DC44
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenXRRenderWindow.vtkOpenXRRenderWindow_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06001EEB RID: 7915
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenXRRenderWindow_GetSizeFromAPI_08(HandleRef pThis);

		/// <summary>
		/// Get size of render window from OpenXR.
		/// </summary>
		// Token: 0x06001EEC RID: 7916 RVA: 0x0002FA60 File Offset: 0x0002DC60
		public virtual bool GetSizeFromAPI()
		{
			return vtkOpenXRRenderWindow.vtkOpenXRRenderWindow_GetSizeFromAPI_08(base.GetCppThis()) != 0;
		}

		// Token: 0x06001EED RID: 7917
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenXRRenderWindow_Initialize_09(HandleRef pThis);

		/// <summary>
		/// Initialize the rendering window.  This will setup all system-specific
		/// resources.  This method and Finalize() must be symmetric and it
		/// should be possible to call them multiple times, even changing WindowId
		/// in-between.  This is what WindowRemap does.
		/// </summary>
		// Token: 0x06001EEE RID: 7918 RVA: 0x0002FA86 File Offset: 0x0002DC86
		public override void Initialize()
		{
			vtkOpenXRRenderWindow.vtkOpenXRRenderWindow_Initialize_09(base.GetCppThis());
		}

		// Token: 0x06001EEF RID: 7919
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenXRRenderWindow_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001EF0 RID: 7920 RVA: 0x0002FA98 File Offset: 0x0002DC98
		public override int IsA(string type)
		{
			return vtkOpenXRRenderWindow.vtkOpenXRRenderWindow_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06001EF1 RID: 7921
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenXRRenderWindow_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001EF2 RID: 7922 RVA: 0x0002FAB8 File Offset: 0x0002DCB8
		public new static int IsTypeOf(string type)
		{
			return vtkOpenXRRenderWindow.vtkOpenXRRenderWindow_IsTypeOf_11(type);
		}

		// Token: 0x06001EF3 RID: 7923
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenXRRenderWindow_MakeRenderWindowInteractor_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create an interactor to control renderers in this window.
		/// </summary>
		// Token: 0x06001EF4 RID: 7924 RVA: 0x0002FAD4 File Offset: 0x0002DCD4
		public override vtkRenderWindowInteractor MakeRenderWindowInteractor()
		{
			vtkRenderWindowInteractor vtkRenderWindowInteractor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenXRRenderWindow.vtkOpenXRRenderWindow_MakeRenderWindowInteractor_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06001EF5 RID: 7925
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenXRRenderWindow_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001EF6 RID: 7926 RVA: 0x0002FB44 File Offset: 0x0002DD44
		public new vtkOpenXRRenderWindow NewInstance()
		{
			vtkOpenXRRenderWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenXRRenderWindow.vtkOpenXRRenderWindow_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenXRRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001EF7 RID: 7927
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenXRRenderWindow_Render_15(HandleRef pThis);

		/// <summary>
		/// Overridden to not release resources that would interfere with an external
		/// application's rendering. Avoiding round trip.
		/// </summary>
		// Token: 0x06001EF8 RID: 7928 RVA: 0x0002FB9E File Offset: 0x0002DD9E
		public override void Render()
		{
			vtkOpenXRRenderWindow.vtkOpenXRRenderWindow_Render_15(base.GetCppThis());
		}

		// Token: 0x06001EF9 RID: 7929
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenXRRenderWindow_RenderModels_16(HandleRef pThis);

		/// <summary>
		/// Render the controllers
		/// </summary>
		// Token: 0x06001EFA RID: 7930 RVA: 0x0002FBAD File Offset: 0x0002DDAD
		public override void RenderModels()
		{
			vtkOpenXRRenderWindow.vtkOpenXRRenderWindow_RenderModels_16(base.GetCppThis());
		}

		// Token: 0x06001EFB RID: 7931
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenXRRenderWindow_ReportCapabilities_17(HandleRef pThis);

		/// <summary>
		/// Get report of capabilities for the render window
		/// </summary>
		// Token: 0x06001EFC RID: 7932 RVA: 0x0002FBBC File Offset: 0x0002DDBC
		public override string ReportCapabilities()
		{
			string s = Marshal.PtrToStringAnsi(vtkOpenXRRenderWindow.vtkOpenXRRenderWindow_ReportCapabilities_17(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001EFD RID: 7933
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenXRRenderWindow_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001EFE RID: 7934 RVA: 0x0002FBF8 File Offset: 0x0002DDF8
		public new static vtkOpenXRRenderWindow SafeDownCast(vtkObjectBase o)
		{
			vtkOpenXRRenderWindow vtkOpenXRRenderWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenXRRenderWindow.vtkOpenXRRenderWindow_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenXRRenderWindow = (vtkOpenXRRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenXRRenderWindow.Register(null);
				}
			}
			return vtkOpenXRRenderWindow;
		}

		// Token: 0x06001EFF RID: 7935
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenXRRenderWindow_SetModelActiveState_19(HandleRef pThis, int hand, byte state);

		/// <summary>
		/// Set the active state (active: true / inactive: false) of the specified hand.
		/// </summary>
		// Token: 0x06001F00 RID: 7936 RVA: 0x0002FC77 File Offset: 0x0002DE77
		public void SetModelActiveState(int hand, bool state)
		{
			vtkOpenXRRenderWindow.vtkOpenXRRenderWindow_SetModelActiveState_19(base.GetCppThis(), hand, state ? (byte)1 : (byte)0);
		}

		// Token: 0x06001F01 RID: 7937
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenXRRenderWindow_StereoMidpoint_20(HandleRef pThis);

		/// <summary>
		/// Intermediate method performs operations required between the rendering
		/// of the left and right eye.
		/// </summary>
		// Token: 0x06001F02 RID: 7938 RVA: 0x0002FC90 File Offset: 0x0002DE90
		public override void StereoMidpoint()
		{
			vtkOpenXRRenderWindow.vtkOpenXRRenderWindow_StereoMidpoint_20(base.GetCppThis());
		}

		// Token: 0x06001F03 RID: 7939
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenXRRenderWindow_StereoRenderComplete_21(HandleRef pThis);

		/// <summary>
		/// Handles work required once both views have been rendered when using
		/// stereo rendering.
		/// </summary>
		// Token: 0x06001F04 RID: 7940 RVA: 0x0002FC9F File Offset: 0x0002DE9F
		public override void StereoRenderComplete()
		{
			vtkOpenXRRenderWindow.vtkOpenXRRenderWindow_StereoRenderComplete_21(base.GetCppThis());
		}

		// Token: 0x06001F05 RID: 7941
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenXRRenderWindow_StereoUpdate_22(HandleRef pThis);

		/// <summary>
		/// Update the system, if needed, due to stereo rendering. For some stereo
		/// methods, subclasses might need to switch some hardware settings here.
		/// </summary>
		// Token: 0x06001F06 RID: 7942 RVA: 0x0002FCAE File Offset: 0x0002DEAE
		public override void StereoUpdate()
		{
			vtkOpenXRRenderWindow.vtkOpenXRRenderWindow_StereoUpdate_22(base.GetCppThis());
		}

		// Token: 0x06001F07 RID: 7943
		[DllImport("Kitware.VTK.RenderingOpenXR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenXRRenderWindow_UpdateHMDMatrixPose_23(HandleRef pThis);

		/// <summary>
		/// Update the HMD pose based on hardware pose and physical to world transform.
		/// VR camera properties are directly modified based on physical to world to
		/// simulate \sa PhysicalTranslation, \sa PhysicalScale, etc.
		/// </summary>
		// Token: 0x06001F08 RID: 7944 RVA: 0x0002FCBD File Offset: 0x0002DEBD
		public override void UpdateHMDMatrixPose()
		{
			vtkOpenXRRenderWindow.vtkOpenXRRenderWindow_UpdateHMDMatrixPose_23(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400050E RID: 1294
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenXRRenderWindow";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400050F RID: 1295
		public new static readonly string MRClassNameKey = "class vtkOpenXRRenderWindow";
	}
}
