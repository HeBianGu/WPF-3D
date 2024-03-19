using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAnimationCue
	/// </summary>
	/// <remarks>
	///    a seqin an animation.
	///
	/// vtkAnimationCue and vtkAnimationScene provide the framework to support
	/// animations in VTK. vtkAnimationCue represents an entity that changes/
	/// animates with time, while vtkAnimationScene represents scene or setup
	/// for the animation, which consists on individual cues or other scenes.
	///
	/// A cue has three states: UNINITIALIZED, ACTIVE and INACTIVE.
	/// UNINITIALIZED represents an point in time before the start time of the cue.
	/// The cue is in ACTIVE state at a point in time between start time and end time
	/// for the cue. While, beyond the end time, it is in INACTIVE state.
	/// When the cue enters the ACTIVE state, StartAnimationCueEvent is fired. This
	/// event may be handled to initialize the entity to be animated.
	/// When the cue leaves the ACTIVE state, EndAnimationCueEvent is fired, which
	/// can be handled to cleanup after having run the animation.
	/// For every request to render during the ACTIVE state, AnimationCueTickEvent is
	/// fired, which must be handled to perform the actual animation.
	/// </remarks>
	/// <seealso>
	///
	/// vtkAnimationScene
	/// </seealso>
	// Token: 0x020009F2 RID: 2546
	public class vtkAnimationCue : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A6FC RID: 108284 RVA: 0x0024B6AF File Offset: 0x002498AF
		static vtkAnimationCue()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAnimationCue.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAnimationCue"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A6FD RID: 108285 RVA: 0x0024B6D7 File Offset: 0x002498D7
		public vtkAnimationCue(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A6FE RID: 108286
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnimationCue_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A6FF RID: 108287 RVA: 0x0024B6E8 File Offset: 0x002498E8
		public new static vtkAnimationCue New()
		{
			vtkAnimationCue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnimationCue.vtkAnimationCue_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAnimationCue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A700 RID: 108288 RVA: 0x0024B73C File Offset: 0x0024993C
		public vtkAnimationCue() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAnimationCue.vtkAnimationCue_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A701 RID: 108289 RVA: 0x0024B780 File Offset: 0x00249980
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A702 RID: 108290
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimationCue_Finalize_01(HandleRef pThis);

		/// <summary>
		/// Called when the scene reaches the end.
		/// If the cue state is ACTIVE when this method is called, this will
		/// trigger a EndAnimationCueEvent.
		/// </summary>
		// Token: 0x0601A703 RID: 108291 RVA: 0x0024B78B File Offset: 0x0024998B
		public virtual void FinalizeWrapper()
		{
			vtkAnimationCue.vtkAnimationCue_Finalize_01(base.GetCppThis());
		}

		// Token: 0x0601A704 RID: 108292
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAnimationCue_GetAnimationTime_02(HandleRef pThis);

		/// <summary>
		/// This is valid only in a AnimationCueTickEvent handler.
		/// Before firing the event the animation cue sets the AnimationTime to
		/// the time of the tick.
		/// </summary>
		// Token: 0x0601A705 RID: 108293 RVA: 0x0024B79C File Offset: 0x0024999C
		public virtual double GetAnimationTime()
		{
			return vtkAnimationCue.vtkAnimationCue_GetAnimationTime_02(base.GetCppThis());
		}

		// Token: 0x0601A706 RID: 108294
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAnimationCue_GetClockTime_03(HandleRef pThis);

		/// <summary>
		/// This is valid only in a AnimationCueTickEvent handler.
		/// Before firing the event the animation cue sets the ClockTime to
		/// the time of the tick. ClockTime is directly the time from the animation
		/// scene neither normalized nor offsetted to the start of the scene.
		/// </summary>
		// Token: 0x0601A707 RID: 108295 RVA: 0x0024B7BC File Offset: 0x002499BC
		public virtual double GetClockTime()
		{
			return vtkAnimationCue.vtkAnimationCue_GetClockTime_03(base.GetCppThis());
		}

		// Token: 0x0601A708 RID: 108296
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAnimationCue_GetDeltaTime_04(HandleRef pThis);

		/// <summary>
		/// This is valid only in a AnimationCueTickEvent handler.
		/// Before firing the event the animation cue sets the DeltaTime
		/// to the difference in time between the current tick and the last tick.
		/// </summary>
		// Token: 0x0601A709 RID: 108297 RVA: 0x0024B7DC File Offset: 0x002499DC
		public virtual double GetDeltaTime()
		{
			return vtkAnimationCue.vtkAnimationCue_GetDeltaTime_04(base.GetCppThis());
		}

		// Token: 0x0601A70A RID: 108298
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkAnimationCue.PlayDirection vtkAnimationCue_GetDirection_05(HandleRef pThis);

		/// <summary>
		/// Set/get the direction of playback.
		/// </summary>
		// Token: 0x0601A70B RID: 108299 RVA: 0x0024B7FC File Offset: 0x002499FC
		public virtual vtkAnimationCue.PlayDirection GetDirection()
		{
			return vtkAnimationCue.vtkAnimationCue_GetDirection_05(base.GetCppThis());
		}

		// Token: 0x0601A70C RID: 108300
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAnimationCue_GetEndTime_06(HandleRef pThis);

		/// <summary>
		/// Get/Set the End time for this cue.
		/// When the current time is &gt; EndTime, the Cue is in
		/// INACTIVE state. Whenever the cue leaves an ACTIVE state to enter
		/// INACTIVE state, the EndEvent is triggered.
		/// The End time is in seconds relative to the start of the
		/// container Scene (when in Relative time mode) or is normalized
		/// over the span of the container Scene (when in Normalized time mode).
		/// </summary>
		// Token: 0x0601A70D RID: 108301 RVA: 0x0024B81C File Offset: 0x00249A1C
		public virtual double GetEndTime()
		{
			return vtkAnimationCue.vtkAnimationCue_GetEndTime_06(base.GetCppThis());
		}

		// Token: 0x0601A70E RID: 108302
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAnimationCue_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A70F RID: 108303 RVA: 0x0024B83C File Offset: 0x00249A3C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAnimationCue.vtkAnimationCue_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601A710 RID: 108304
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAnimationCue_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A711 RID: 108305 RVA: 0x0024B85C File Offset: 0x00249A5C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAnimationCue.vtkAnimationCue_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0601A712 RID: 108306
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAnimationCue_GetStartTime_09(HandleRef pThis);

		/// <summary>
		/// Get/Set the Start time for this cue.
		/// When the current time is &gt;= StartTime, the Cue is in
		/// ACTIVE state. if Current time i &lt; StartTime, the Cue is in
		/// UNINITIALIZED state. Whenever the cue enters the ACTIVE state from
		/// an INACTIVE state, it triggers the StartEvent.
		/// The Start time is in seconds relative to the start of the
		/// container Scene (when in Relative time mode) or is normalized
		/// over the span of the container Scene (when in Normalized time mode).
		/// </summary>
		// Token: 0x0601A713 RID: 108307 RVA: 0x0024B878 File Offset: 0x00249A78
		public virtual double GetStartTime()
		{
			return vtkAnimationCue.vtkAnimationCue_GetStartTime_09(base.GetCppThis());
		}

		// Token: 0x0601A714 RID: 108308
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnimationCue_GetTimeMode_10(HandleRef pThis);

		/// <summary>
		/// Get/Set the time mode. In Normalized mode, the start and end
		/// times of the cue are normalized [0,1] with respect to the start and
		/// end times of the container scene. In Relative mode the start and end
		/// time of the cue are specified in offset seconds relative to the
		/// start time of the container scene.
		/// </summary>
		// Token: 0x0601A715 RID: 108309 RVA: 0x0024B898 File Offset: 0x00249A98
		public virtual int GetTimeMode()
		{
			return vtkAnimationCue.vtkAnimationCue_GetTimeMode_10(base.GetCppThis());
		}

		// Token: 0x0601A716 RID: 108310
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimationCue_Initialize_11(HandleRef pThis);

		/// <summary>
		/// Called when the playing of the scene begins.
		/// This will set the Cue to UNINITIALIZED state.
		/// </summary>
		// Token: 0x0601A717 RID: 108311 RVA: 0x0024B8B7 File Offset: 0x00249AB7
		public virtual void Initialize()
		{
			vtkAnimationCue.vtkAnimationCue_Initialize_11(base.GetCppThis());
		}

		// Token: 0x0601A718 RID: 108312
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnimationCue_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A719 RID: 108313 RVA: 0x0024B8C8 File Offset: 0x00249AC8
		public override int IsA(string type)
		{
			return vtkAnimationCue.vtkAnimationCue_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0601A71A RID: 108314
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnimationCue_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A71B RID: 108315 RVA: 0x0024B8E8 File Offset: 0x00249AE8
		public new static int IsTypeOf(string type)
		{
			return vtkAnimationCue.vtkAnimationCue_IsTypeOf_13(type);
		}

		// Token: 0x0601A71C RID: 108316
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnimationCue_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A71D RID: 108317 RVA: 0x0024B904 File Offset: 0x00249B04
		public new vtkAnimationCue NewInstance()
		{
			vtkAnimationCue result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnimationCue.vtkAnimationCue_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAnimationCue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A71E RID: 108318
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnimationCue_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A71F RID: 108319 RVA: 0x0024B960 File Offset: 0x00249B60
		public new static vtkAnimationCue SafeDownCast(vtkObjectBase o)
		{
			vtkAnimationCue vtkAnimationCue = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnimationCue.vtkAnimationCue_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnimationCue = (vtkAnimationCue)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnimationCue.Register(null);
				}
			}
			return vtkAnimationCue;
		}

		// Token: 0x0601A720 RID: 108320
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimationCue_SetDirection_17(HandleRef pThis, vtkAnimationCue.PlayDirection _arg);

		/// <summary>
		/// Set/get the direction of playback.
		/// </summary>
		// Token: 0x0601A721 RID: 108321 RVA: 0x0024B9DF File Offset: 0x00249BDF
		public virtual void SetDirection(vtkAnimationCue.PlayDirection _arg)
		{
			vtkAnimationCue.vtkAnimationCue_SetDirection_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A722 RID: 108322
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimationCue_SetEndTime_18(HandleRef pThis, double _arg);

		/// <summary>
		/// Get/Set the End time for this cue.
		/// When the current time is &gt; EndTime, the Cue is in
		/// INACTIVE state. Whenever the cue leaves an ACTIVE state to enter
		/// INACTIVE state, the EndEvent is triggered.
		/// The End time is in seconds relative to the start of the
		/// container Scene (when in Relative time mode) or is normalized
		/// over the span of the container Scene (when in Normalized time mode).
		/// </summary>
		// Token: 0x0601A723 RID: 108323 RVA: 0x0024B9EF File Offset: 0x00249BEF
		public virtual void SetEndTime(double _arg)
		{
			vtkAnimationCue.vtkAnimationCue_SetEndTime_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A724 RID: 108324
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimationCue_SetStartTime_19(HandleRef pThis, double _arg);

		/// <summary>
		/// Get/Set the Start time for this cue.
		/// When the current time is &gt;= StartTime, the Cue is in
		/// ACTIVE state. if Current time i &lt; StartTime, the Cue is in
		/// UNINITIALIZED state. Whenever the cue enters the ACTIVE state from
		/// an INACTIVE state, it triggers the StartEvent.
		/// The Start time is in seconds relative to the start of the
		/// container Scene (when in Relative time mode) or is normalized
		/// over the span of the container Scene (when in Normalized time mode).
		/// </summary>
		// Token: 0x0601A725 RID: 108325 RVA: 0x0024B9FF File Offset: 0x00249BFF
		public virtual void SetStartTime(double _arg)
		{
			vtkAnimationCue.vtkAnimationCue_SetStartTime_19(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A726 RID: 108326
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimationCue_SetTimeMode_20(HandleRef pThis, int mode);

		/// <summary>
		/// Get/Set the time mode. In Normalized mode, the start and end
		/// times of the cue are normalized [0,1] with respect to the start and
		/// end times of the container scene. In Relative mode the start and end
		/// time of the cue are specified in offset seconds relative to the
		/// start time of the container scene.
		/// </summary>
		// Token: 0x0601A727 RID: 108327 RVA: 0x0024BA0F File Offset: 0x00249C0F
		public virtual void SetTimeMode(int mode)
		{
			vtkAnimationCue.vtkAnimationCue_SetTimeMode_20(base.GetCppThis(), mode);
		}

		// Token: 0x0601A728 RID: 108328
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimationCue_SetTimeModeToNormalized_21(HandleRef pThis);

		/// <summary>
		/// Get/Set the time mode. In Normalized mode, the start and end
		/// times of the cue are normalized [0,1] with respect to the start and
		/// end times of the container scene. In Relative mode the start and end
		/// time of the cue are specified in offset seconds relative to the
		/// start time of the container scene.
		/// </summary>
		// Token: 0x0601A729 RID: 108329 RVA: 0x0024BA1F File Offset: 0x00249C1F
		public void SetTimeModeToNormalized()
		{
			vtkAnimationCue.vtkAnimationCue_SetTimeModeToNormalized_21(base.GetCppThis());
		}

		// Token: 0x0601A72A RID: 108330
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimationCue_SetTimeModeToRelative_22(HandleRef pThis);

		/// <summary>
		/// Get/Set the time mode. In Normalized mode, the start and end
		/// times of the cue are normalized [0,1] with respect to the start and
		/// end times of the container scene. In Relative mode the start and end
		/// time of the cue are specified in offset seconds relative to the
		/// start time of the container scene.
		/// </summary>
		// Token: 0x0601A72B RID: 108331 RVA: 0x0024BA2E File Offset: 0x00249C2E
		public void SetTimeModeToRelative()
		{
			vtkAnimationCue.vtkAnimationCue_SetTimeModeToRelative_22(base.GetCppThis());
		}

		// Token: 0x0601A72C RID: 108332
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimationCue_Tick_23(HandleRef pThis, double currenttime, double deltatime, double clocktime);

		/// <summary>
		/// Indicates a tick or point in time in the animation.
		/// Triggers a Tick event if currenttime &gt;= StartTime and
		/// currenttime &lt;= EndTime.
		/// Whenever the state of the cue changes,
		/// either StartEvent or EndEvent is triggered depending upon
		/// whether the cue entered Active state or quit active state respectively.
		/// The current time is relative to the start of the container Scene
		/// (when in Relative time mode) or is normalized
		/// over the span of the container Scene (when in Normalized time mode).
		/// deltatime is the time since last call to Tick. deltatime also can be in seconds
		/// relative to the start of the container Scene or normalized depending upon the
		/// cue's Time mode.
		/// clocktime is the time from the scene i.e. it does not depend on the time
		/// mode for the cue.
		/// For the first call to Tick
		/// after a call to Initialize(), the deltatime is 0;
		/// </summary>
		// Token: 0x0601A72D RID: 108333 RVA: 0x0024BA3D File Offset: 0x00249C3D
		public virtual void Tick(double currenttime, double deltatime, double clocktime)
		{
			vtkAnimationCue.vtkAnimationCue_Tick_23(base.GetCppThis(), currenttime, deltatime, clocktime);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CB9 RID: 7353
		public new const string MRFullTypeName = "Kitware.VTK.vtkAnimationCue";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CBA RID: 7354
		public new static readonly string MRClassNameKey = "class vtkAnimationCue";

		/// <summary>
		/// This is valid only in a AnimationCueTickEvent handler.
		/// Before firing the event the animation cue sets the ClockTime to
		/// the time of the tick. ClockTime is directly the time from the animation
		/// scene neither normalized nor offsetted to the start of the scene.
		/// </summary>
		// Token: 0x020009F3 RID: 2547
		public enum PlayDirection
		{
			/// <summary>enum member</summary>
			// Token: 0x04001CBC RID: 7356
			BACKWARD,
			/// <summary>enum member</summary>
			// Token: 0x04001CBD RID: 7357
			FORWARD
		}

		/// <summary>
		/// This is valid only in a AnimationCueTickEvent handler.
		/// Before firing the event the animation cue sets the ClockTime to
		/// the time of the tick. ClockTime is directly the time from the animation
		/// scene neither normalized nor offsetted to the start of the scene.
		/// </summary>
		// Token: 0x020009F4 RID: 2548
		public enum TimeCodes
		{
			/// <summary>enum member</summary>
			// Token: 0x04001CBF RID: 7359
			TIMEMODE_NORMALIZED,
			/// <summary>enum member</summary>
			// Token: 0x04001CC0 RID: 7360
			TIMEMODE_RELATIVE
		}
	}
}
