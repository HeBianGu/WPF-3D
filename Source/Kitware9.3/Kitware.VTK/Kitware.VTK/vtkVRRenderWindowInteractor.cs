using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVRRenderWindowInteractor
	/// </summary>
	/// <remarks>
	///    Implements VR specific functions required by vtkRenderWindowInteractor.
	/// </remarks>
	// Token: 0x0200009C RID: 156
	public abstract class vtkVRRenderWindowInteractor : vtkRenderWindowInteractor3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002106 RID: 8454 RVA: 0x00031D40 File Offset: 0x0002FF40
		static vtkVRRenderWindowInteractor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVRRenderWindowInteractor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVRRenderWindowInteractor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002107 RID: 8455 RVA: 0x00031D68 File Offset: 0x0002FF68
		public vtkVRRenderWindowInteractor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002108 RID: 8456 RVA: 0x00031D76 File Offset: 0x0002FF76
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002109 RID: 8457
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindowInteractor_ConvertPoseToWorldCoordinates_01(HandleRef pThis, HandleRef poseInTrackingCoordinates, IntPtr pos, IntPtr wxyz, IntPtr ppos, IntPtr wdir);

		/// <summary>
		/// Set/get the physical scale (world / physical distance ratio)
		/// </summary>
		// Token: 0x0600210A RID: 8458 RVA: 0x00031D84 File Offset: 0x0002FF84
		public void ConvertPoseToWorldCoordinates(vtkMatrix4x4 poseInTrackingCoordinates, IntPtr pos, IntPtr wxyz, IntPtr ppos, IntPtr wdir)
		{
			vtkVRRenderWindowInteractor.vtkVRRenderWindowInteractor_ConvertPoseToWorldCoordinates_01(base.GetCppThis(), (poseInTrackingCoordinates == null) ? default(HandleRef) : poseInTrackingCoordinates.GetCppThis(), pos, wxyz, ppos, wdir);
		}

		// Token: 0x0600210B RID: 8459
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindowInteractor_DoOneEvent_02(HandleRef pThis, HandleRef renWin, HandleRef ren);

		/// <summary>
		/// Implements the event loop.
		/// </summary>
		// Token: 0x0600210C RID: 8460 RVA: 0x00031DBC File Offset: 0x0002FFBC
		public virtual void DoOneEvent(vtkVRRenderWindow renWin, vtkRenderer ren)
		{
			vtkVRRenderWindowInteractor.vtkVRRenderWindowInteractor_DoOneEvent_02(base.GetCppThis(), (renWin == null) ? default(HandleRef) : renWin.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x0600210D RID: 8461
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindowInteractor_ExitCallback_03(HandleRef pThis);

		/// <summary>
		/// This method corresponds to the Exit callback, allowing for the style to invoke it.
		/// </summary>
		// Token: 0x0600210E RID: 8462 RVA: 0x00031E00 File Offset: 0x00030000
		public override void ExitCallback()
		{
			vtkVRRenderWindowInteractor.vtkVRRenderWindowInteractor_ExitCallback_03(base.GetCppThis());
		}

		// Token: 0x0600210F RID: 8463
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkVRRenderWindowInteractor_GetActionManifestDirectory_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the path to the directory to search for the ActionManifestFileName
		/// Default is empty.
		/// </summary>
		// Token: 0x06002110 RID: 8464 RVA: 0x00031E10 File Offset: 0x00030010
		public virtual string GetActionManifestDirectory()
		{
			return vtkVRRenderWindowInteractor.vtkVRRenderWindowInteractor_GetActionManifestDirectory_04(base.GetCppThis());
		}

		// Token: 0x06002111 RID: 8465
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkVRRenderWindowInteractor_GetActionManifestFileName_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the .json filename describing action bindings for events.
		/// Based on https://github.com/ValveSoftware/openvr/wiki/Action-manifest
		/// Default is empty.
		/// </summary>
		// Token: 0x06002112 RID: 8466 RVA: 0x00031E30 File Offset: 0x00030030
		public virtual string GetActionManifestFileName()
		{
			return vtkVRRenderWindowInteractor.vtkVRRenderWindowInteractor_GetActionManifestFileName_05(base.GetCppThis());
		}

		// Token: 0x06002113 RID: 8467
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkVRRenderWindowInteractor_GetActionSetName_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the name of the action set to use from the action manifest
		/// </summary>
		// Token: 0x06002114 RID: 8468 RVA: 0x00031E50 File Offset: 0x00030050
		public virtual string GetActionSetName()
		{
			return vtkVRRenderWindowInteractor.vtkVRRenderWindowInteractor_GetActionSetName_06(base.GetCppThis());
		}

		// Token: 0x06002115 RID: 8469
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRRenderWindowInteractor_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002116 RID: 8470 RVA: 0x00031E70 File Offset: 0x00030070
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVRRenderWindowInteractor.vtkVRRenderWindowInteractor_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06002117 RID: 8471
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRRenderWindowInteractor_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002118 RID: 8472 RVA: 0x00031E90 File Offset: 0x00030090
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVRRenderWindowInteractor.vtkVRRenderWindowInteractor_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06002119 RID: 8473
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVRRenderWindowInteractor_GetPhysicalScale_09(HandleRef pThis);

		/// <summary>
		/// Set/get the physical scale (world / physical distance ratio)
		/// </summary>
		// Token: 0x0600211A RID: 8474 RVA: 0x00031EAC File Offset: 0x000300AC
		public override double GetPhysicalScale()
		{
			return vtkVRRenderWindowInteractor.vtkVRRenderWindowInteractor_GetPhysicalScale_09(base.GetCppThis());
		}

		// Token: 0x0600211B RID: 8475
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRRenderWindowInteractor_GetPhysicalTranslation_10(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/get position of the physical coordinate system origin in world coordinates.
		/// </summary>
		// Token: 0x0600211C RID: 8476 RVA: 0x00031ECC File Offset: 0x000300CC
		public override IntPtr GetPhysicalTranslation(vtkCamera arg0)
		{
			return vtkVRRenderWindowInteractor.vtkVRRenderWindowInteractor_GetPhysicalTranslation_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600211D RID: 8477
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRRenderWindowInteractor_GetPhysicalViewDirection_11(HandleRef pThis);

		/// <summary>
		/// Set/get the direction of the physical coordinate system -Z axis in world coordinates.
		/// </summary>
		// Token: 0x0600211E RID: 8478 RVA: 0x00031F00 File Offset: 0x00030100
		public override IntPtr GetPhysicalViewDirection()
		{
			return vtkVRRenderWindowInteractor.vtkVRRenderWindowInteractor_GetPhysicalViewDirection_11(base.GetCppThis());
		}

		// Token: 0x0600211F RID: 8479
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRRenderWindowInteractor_GetPhysicalViewUp_12(HandleRef pThis);

		/// <summary>
		/// Set/get the direction of the physical coordinate system +Y axis in world coordinates.
		/// </summary>
		// Token: 0x06002120 RID: 8480 RVA: 0x00031F20 File Offset: 0x00030120
		public override IntPtr GetPhysicalViewUp()
		{
			return vtkVRRenderWindowInteractor.vtkVRRenderWindowInteractor_GetPhysicalViewUp_12(base.GetCppThis());
		}

		// Token: 0x06002121 RID: 8481
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkEventDataDevice vtkVRRenderWindowInteractor_GetPointerDevice_13(HandleRef pThis);

		/// <summary>
		/// Set/get the physical scale (world / physical distance ratio)
		/// </summary>
		// Token: 0x06002122 RID: 8482 RVA: 0x00031F40 File Offset: 0x00030140
		public vtkEventDataDevice GetPointerDevice()
		{
			return vtkVRRenderWindowInteractor.vtkVRRenderWindowInteractor_GetPointerDevice_13(base.GetCppThis());
		}

		// Token: 0x06002123 RID: 8483
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindowInteractor_GetStartingPhysicalToWorldMatrix_14(HandleRef pThis, HandleRef startingPhysicalToWorldMatrix);

		/// <summary>
		/// Set/get the physical scale (world / physical distance ratio)
		/// </summary>
		// Token: 0x06002124 RID: 8484 RVA: 0x00031F60 File Offset: 0x00030160
		public void GetStartingPhysicalToWorldMatrix(vtkMatrix4x4 startingPhysicalToWorldMatrix)
		{
			vtkVRRenderWindowInteractor.vtkVRRenderWindowInteractor_GetStartingPhysicalToWorldMatrix_14(base.GetCppThis(), (startingPhysicalToWorldMatrix == null) ? default(HandleRef) : startingPhysicalToWorldMatrix.GetCppThis());
		}

		// Token: 0x06002125 RID: 8485
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindowInteractor_Initialize_15(HandleRef pThis);

		/// <summary>
		/// Initialize the event handler.
		/// </summary>
		// Token: 0x06002126 RID: 8486 RVA: 0x00031F8F File Offset: 0x0003018F
		public override void Initialize()
		{
			vtkVRRenderWindowInteractor.vtkVRRenderWindowInteractor_Initialize_15(base.GetCppThis());
		}

		// Token: 0x06002127 RID: 8487
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRRenderWindowInteractor_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002128 RID: 8488 RVA: 0x00031FA0 File Offset: 0x000301A0
		public override int IsA(string type)
		{
			return vtkVRRenderWindowInteractor.vtkVRRenderWindowInteractor_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x06002129 RID: 8489
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRRenderWindowInteractor_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600212A RID: 8490 RVA: 0x00031FC0 File Offset: 0x000301C0
		public new static int IsTypeOf(string type)
		{
			return vtkVRRenderWindowInteractor.vtkVRRenderWindowInteractor_IsTypeOf_17(type);
		}

		// Token: 0x0600212B RID: 8491
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRRenderWindowInteractor_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600212C RID: 8492 RVA: 0x00031FDC File Offset: 0x000301DC
		public new vtkVRRenderWindowInteractor NewInstance()
		{
			vtkVRRenderWindowInteractor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRRenderWindowInteractor.vtkVRRenderWindowInteractor_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVRRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600212D RID: 8493
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindowInteractor_ProcessEvents_19(HandleRef pThis);

		/// <summary>
		/// Run the event loop and return. This is provided so that you can
		/// implement your own event loop but yet use the VTK event handling as well.
		/// </summary>
		// Token: 0x0600212E RID: 8494 RVA: 0x00032036 File Offset: 0x00030236
		public override void ProcessEvents()
		{
			vtkVRRenderWindowInteractor.vtkVRRenderWindowInteractor_ProcessEvents_19(base.GetCppThis());
		}

		// Token: 0x0600212F RID: 8495
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRRenderWindowInteractor_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002130 RID: 8496 RVA: 0x00032048 File Offset: 0x00030248
		public new static vtkVRRenderWindowInteractor SafeDownCast(vtkObjectBase o)
		{
			vtkVRRenderWindowInteractor vtkVRRenderWindowInteractor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRRenderWindowInteractor.vtkVRRenderWindowInteractor_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVRRenderWindowInteractor = (vtkVRRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVRRenderWindowInteractor.Register(null);
				}
			}
			return vtkVRRenderWindowInteractor;
		}

		// Token: 0x06002131 RID: 8497
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindowInteractor_SetActionManifestDirectory_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the path to the directory to search for the ActionManifestFileName
		/// Default is empty.
		/// </summary>
		// Token: 0x06002132 RID: 8498 RVA: 0x000320C7 File Offset: 0x000302C7
		public virtual void SetActionManifestDirectory(string _arg)
		{
			vtkVRRenderWindowInteractor.vtkVRRenderWindowInteractor_SetActionManifestDirectory_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06002133 RID: 8499
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindowInteractor_SetActionManifestFileName_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the .json filename describing action bindings for events.
		/// Based on https://github.com/ValveSoftware/openvr/wiki/Action-manifest
		/// Default is empty.
		/// </summary>
		// Token: 0x06002134 RID: 8500 RVA: 0x000320D7 File Offset: 0x000302D7
		public virtual void SetActionManifestFileName(string _arg)
		{
			vtkVRRenderWindowInteractor.vtkVRRenderWindowInteractor_SetActionManifestFileName_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06002135 RID: 8501
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindowInteractor_SetActionSetName_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the name of the action set to use from the action manifest
		/// </summary>
		// Token: 0x06002136 RID: 8502 RVA: 0x000320E7 File Offset: 0x000302E7
		public virtual void SetActionSetName(string _arg)
		{
			vtkVRRenderWindowInteractor.vtkVRRenderWindowInteractor_SetActionSetName_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06002137 RID: 8503
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindowInteractor_SetPhysicalScale_24(HandleRef pThis, double arg0);

		/// <summary>
		/// Set/get the physical scale (world / physical distance ratio)
		/// </summary>
		// Token: 0x06002138 RID: 8504 RVA: 0x000320F7 File Offset: 0x000302F7
		public override void SetPhysicalScale(double arg0)
		{
			vtkVRRenderWindowInteractor.vtkVRRenderWindowInteractor_SetPhysicalScale_24(base.GetCppThis(), arg0);
		}

		// Token: 0x06002139 RID: 8505
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindowInteractor_SetPhysicalTranslation_25(HandleRef pThis, HandleRef arg0, double arg1, double arg2, double arg3);

		/// <summary>
		/// Set/get position of the physical coordinate system origin in world coordinates.
		/// </summary>
		// Token: 0x0600213A RID: 8506 RVA: 0x00032108 File Offset: 0x00030308
		public override void SetPhysicalTranslation(vtkCamera arg0, double arg1, double arg2, double arg3)
		{
			vtkVRRenderWindowInteractor.vtkVRRenderWindowInteractor_SetPhysicalTranslation_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), arg1, arg2, arg3);
		}

		// Token: 0x0600213B RID: 8507
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindowInteractor_SetPhysicalViewDirection_26(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Set/get the direction of the physical coordinate system -Z axis in world coordinates.
		/// </summary>
		// Token: 0x0600213C RID: 8508 RVA: 0x0003213B File Offset: 0x0003033B
		public override void SetPhysicalViewDirection(double arg0, double arg1, double arg2)
		{
			vtkVRRenderWindowInteractor.vtkVRRenderWindowInteractor_SetPhysicalViewDirection_26(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x0600213D RID: 8509
		[DllImport("Kitware.VTK.RenderingVR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRRenderWindowInteractor_SetPhysicalViewUp_27(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Set/get the direction of the physical coordinate system +Y axis in world coordinates.
		/// </summary>
		// Token: 0x0600213E RID: 8510 RVA: 0x0003214D File Offset: 0x0003034D
		public override void SetPhysicalViewUp(double arg0, double arg1, double arg2)
		{
			vtkVRRenderWindowInteractor.vtkVRRenderWindowInteractor_SetPhysicalViewUp_27(base.GetCppThis(), arg0, arg1, arg2);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000519 RID: 1305
		public new const string MRFullTypeName = "Kitware.VTK.vtkVRRenderWindowInteractor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400051A RID: 1306
		public new static readonly string MRClassNameKey = "class vtkVRRenderWindowInteractor";
	}
}
