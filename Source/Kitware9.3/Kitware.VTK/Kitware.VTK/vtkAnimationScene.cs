using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAnimationScene
	/// </summary>
	/// <remarks>
	///    the animation scene manager.
	///
	/// vtkAnimationCue and vtkAnimationScene provide the framework to support
	/// animations in VTK. vtkAnimationCue represents an entity that changes/
	/// animates with time, while vtkAnimationScene represents scene or setup
	/// for the animation, which consists of individual cues or other scenes.
	///
	/// A scene can be played in real time mode, or as a sequence of frames
	/// 1/frame rate apart in time.
	/// </remarks>
	/// <seealso>
	///
	/// vtkAnimationCue
	/// </seealso>
	// Token: 0x020009F5 RID: 2549
	public class vtkAnimationScene : vtkAnimationCue
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A72E RID: 108334 RVA: 0x0024BA4F File Offset: 0x00249C4F
		static vtkAnimationScene()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAnimationScene.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAnimationScene"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A72F RID: 108335 RVA: 0x0024BA77 File Offset: 0x00249C77
		public vtkAnimationScene(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A730 RID: 108336
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnimationScene_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A731 RID: 108337 RVA: 0x0024BA88 File Offset: 0x00249C88
		public new static vtkAnimationScene New()
		{
			vtkAnimationScene result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnimationScene.vtkAnimationScene_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAnimationScene)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A732 RID: 108338 RVA: 0x0024BADC File Offset: 0x00249CDC
		public vtkAnimationScene() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAnimationScene.vtkAnimationScene_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A733 RID: 108339 RVA: 0x0024BB20 File Offset: 0x00249D20
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A734 RID: 108340
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimationScene_AddCue_01(HandleRef pThis, HandleRef cue);

		/// <summary>
		/// Add/Remove an AnimationCue to/from the Scene.
		/// It's an error to add a cue twice to the Scene.
		/// </summary>
		// Token: 0x0601A735 RID: 108341 RVA: 0x0024BB2C File Offset: 0x00249D2C
		public void AddCue(vtkAnimationCue cue)
		{
			vtkAnimationScene.vtkAnimationScene_AddCue_01(base.GetCppThis(), (cue == null) ? default(HandleRef) : cue.GetCppThis());
		}

		// Token: 0x0601A736 RID: 108342
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAnimationScene_GetFrameRate_02(HandleRef pThis);

		/// <summary>
		/// Get/Set the frame rate (in frames per second).
		/// This parameter affects only in the Sequence mode. The time interval
		/// indicated to each cue on every tick is progressed by 1/frame-rate seconds.
		/// </summary>
		// Token: 0x0601A737 RID: 108343 RVA: 0x0024BB5C File Offset: 0x00249D5C
		public virtual double GetFrameRate()
		{
			return vtkAnimationScene.vtkAnimationScene_GetFrameRate_02(base.GetCppThis());
		}

		// Token: 0x0601A738 RID: 108344
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnimationScene_GetLoop_03(HandleRef pThis);

		/// <summary>
		/// Enable/Disable animation loop.
		/// </summary>
		// Token: 0x0601A739 RID: 108345 RVA: 0x0024BB7C File Offset: 0x00249D7C
		public virtual int GetLoop()
		{
			return vtkAnimationScene.vtkAnimationScene_GetLoop_03(base.GetCppThis());
		}

		// Token: 0x0601A73A RID: 108346
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnimationScene_GetNumberOfCues_04(HandleRef pThis);

		/// <summary>
		/// Add/Remove an AnimationCue to/from the Scene.
		/// It's an error to add a cue twice to the Scene.
		/// </summary>
		// Token: 0x0601A73B RID: 108347 RVA: 0x0024BB9C File Offset: 0x00249D9C
		public int GetNumberOfCues()
		{
			return vtkAnimationScene.vtkAnimationScene_GetNumberOfCues_04(base.GetCppThis());
		}

		// Token: 0x0601A73C RID: 108348
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAnimationScene_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A73D RID: 108349 RVA: 0x0024BBBC File Offset: 0x00249DBC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAnimationScene.vtkAnimationScene_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601A73E RID: 108350
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAnimationScene_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A73F RID: 108351 RVA: 0x0024BBDC File Offset: 0x00249DDC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAnimationScene.vtkAnimationScene_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601A740 RID: 108352
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnimationScene_GetPlayMode_07(HandleRef pThis);

		/// <summary>
		/// Get/Set the PlayMode for running/playing the animation scene.
		/// In the Sequence mode, all the frames are generated one after the other.
		/// The time reported to each Tick of the constituent cues (during Play) is
		/// incremented by 1/frame rate, irrespective of the current time.
		/// In the RealTime mode, time indicates the instance in time.
		/// </summary>
		// Token: 0x0601A741 RID: 108353 RVA: 0x0024BBF8 File Offset: 0x00249DF8
		public virtual int GetPlayMode()
		{
			return vtkAnimationScene.vtkAnimationScene_GetPlayMode_07(base.GetCppThis());
		}

		// Token: 0x0601A742 RID: 108354
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnimationScene_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A743 RID: 108355 RVA: 0x0024BC18 File Offset: 0x00249E18
		public override int IsA(string type)
		{
			return vtkAnimationScene.vtkAnimationScene_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0601A744 RID: 108356
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnimationScene_IsInPlay_09(HandleRef pThis);

		/// <summary>
		/// Returns if the animation is being played.
		/// </summary>
		// Token: 0x0601A745 RID: 108357 RVA: 0x0024BC38 File Offset: 0x00249E38
		public int IsInPlay()
		{
			return vtkAnimationScene.vtkAnimationScene_IsInPlay_09(base.GetCppThis());
		}

		// Token: 0x0601A746 RID: 108358
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAnimationScene_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A747 RID: 108359 RVA: 0x0024BC58 File Offset: 0x00249E58
		public new static int IsTypeOf(string type)
		{
			return vtkAnimationScene.vtkAnimationScene_IsTypeOf_10(type);
		}

		// Token: 0x0601A748 RID: 108360
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnimationScene_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A749 RID: 108361 RVA: 0x0024BC74 File Offset: 0x00249E74
		public new vtkAnimationScene NewInstance()
		{
			vtkAnimationScene result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnimationScene.vtkAnimationScene_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAnimationScene)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A74A RID: 108362
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimationScene_Play_13(HandleRef pThis);

		/// <summary>
		/// Starts playing the animation scene. Fires a vtkCommand::StartEvent
		/// before play beings and vtkCommand::EndEvent after play ends.
		/// </summary>
		// Token: 0x0601A74B RID: 108363 RVA: 0x0024BCCE File Offset: 0x00249ECE
		public virtual void Play()
		{
			vtkAnimationScene.vtkAnimationScene_Play_13(base.GetCppThis());
		}

		// Token: 0x0601A74C RID: 108364
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimationScene_RemoveAllCues_14(HandleRef pThis);

		/// <summary>
		/// Add/Remove an AnimationCue to/from the Scene.
		/// It's an error to add a cue twice to the Scene.
		/// </summary>
		// Token: 0x0601A74D RID: 108365 RVA: 0x0024BCDD File Offset: 0x00249EDD
		public void RemoveAllCues()
		{
			vtkAnimationScene.vtkAnimationScene_RemoveAllCues_14(base.GetCppThis());
		}

		// Token: 0x0601A74E RID: 108366
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimationScene_RemoveCue_15(HandleRef pThis, HandleRef cue);

		/// <summary>
		/// Add/Remove an AnimationCue to/from the Scene.
		/// It's an error to add a cue twice to the Scene.
		/// </summary>
		// Token: 0x0601A74F RID: 108367 RVA: 0x0024BCEC File Offset: 0x00249EEC
		public void RemoveCue(vtkAnimationCue cue)
		{
			vtkAnimationScene.vtkAnimationScene_RemoveCue_15(base.GetCppThis(), (cue == null) ? default(HandleRef) : cue.GetCppThis());
		}

		// Token: 0x0601A750 RID: 108368
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAnimationScene_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A751 RID: 108369 RVA: 0x0024BD1C File Offset: 0x00249F1C
		public new static vtkAnimationScene SafeDownCast(vtkObjectBase o)
		{
			vtkAnimationScene vtkAnimationScene = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAnimationScene.vtkAnimationScene_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnimationScene = (vtkAnimationScene)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnimationScene.Register(null);
				}
			}
			return vtkAnimationScene;
		}

		// Token: 0x0601A752 RID: 108370
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimationScene_SetAnimationTime_17(HandleRef pThis, double time);

		/// <summary>
		/// Makes the state of the scene same as the given time.
		/// </summary>
		// Token: 0x0601A753 RID: 108371 RVA: 0x0024BD9B File Offset: 0x00249F9B
		public void SetAnimationTime(double time)
		{
			vtkAnimationScene.vtkAnimationScene_SetAnimationTime_17(base.GetCppThis(), time);
		}

		// Token: 0x0601A754 RID: 108372
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimationScene_SetFrameRate_18(HandleRef pThis, double _arg);

		/// <summary>
		/// Get/Set the frame rate (in frames per second).
		/// This parameter affects only in the Sequence mode. The time interval
		/// indicated to each cue on every tick is progressed by 1/frame-rate seconds.
		/// </summary>
		// Token: 0x0601A755 RID: 108373 RVA: 0x0024BDAB File Offset: 0x00249FAB
		public virtual void SetFrameRate(double _arg)
		{
			vtkAnimationScene.vtkAnimationScene_SetFrameRate_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A756 RID: 108374
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimationScene_SetLoop_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/Disable animation loop.
		/// </summary>
		// Token: 0x0601A757 RID: 108375 RVA: 0x0024BDBB File Offset: 0x00249FBB
		public virtual void SetLoop(int _arg)
		{
			vtkAnimationScene.vtkAnimationScene_SetLoop_19(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A758 RID: 108376
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimationScene_SetModeToRealTime_20(HandleRef pThis);

		/// <summary>
		/// Get/Set the PlayMode for running/playing the animation scene.
		/// In the Sequence mode, all the frames are generated one after the other.
		/// The time reported to each Tick of the constituent cues (during Play) is
		/// incremented by 1/frame rate, irrespective of the current time.
		/// In the RealTime mode, time indicates the instance in time.
		/// </summary>
		// Token: 0x0601A759 RID: 108377 RVA: 0x0024BDCB File Offset: 0x00249FCB
		public void SetModeToRealTime()
		{
			vtkAnimationScene.vtkAnimationScene_SetModeToRealTime_20(base.GetCppThis());
		}

		// Token: 0x0601A75A RID: 108378
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimationScene_SetModeToSequence_21(HandleRef pThis);

		/// <summary>
		/// Get/Set the PlayMode for running/playing the animation scene.
		/// In the Sequence mode, all the frames are generated one after the other.
		/// The time reported to each Tick of the constituent cues (during Play) is
		/// incremented by 1/frame rate, irrespective of the current time.
		/// In the RealTime mode, time indicates the instance in time.
		/// </summary>
		// Token: 0x0601A75B RID: 108379 RVA: 0x0024BDDA File Offset: 0x00249FDA
		public void SetModeToSequence()
		{
			vtkAnimationScene.vtkAnimationScene_SetModeToSequence_21(base.GetCppThis());
		}

		// Token: 0x0601A75C RID: 108380
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimationScene_SetPlayMode_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the PlayMode for running/playing the animation scene.
		/// In the Sequence mode, all the frames are generated one after the other.
		/// The time reported to each Tick of the constituent cues (during Play) is
		/// incremented by 1/frame rate, irrespective of the current time.
		/// In the RealTime mode, time indicates the instance in time.
		/// </summary>
		// Token: 0x0601A75D RID: 108381 RVA: 0x0024BDE9 File Offset: 0x00249FE9
		public virtual void SetPlayMode(int _arg)
		{
			vtkAnimationScene.vtkAnimationScene_SetPlayMode_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A75E RID: 108382
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimationScene_SetTimeMode_23(HandleRef pThis, int mode);

		/// <summary>
		/// Overridden to allow change to Normalized mode only
		/// if none of the constituent cues is in Relative time mode.
		/// </summary>
		// Token: 0x0601A75F RID: 108383 RVA: 0x0024BDF9 File Offset: 0x00249FF9
		public override void SetTimeMode(int mode)
		{
			vtkAnimationScene.vtkAnimationScene_SetTimeMode_23(base.GetCppThis(), mode);
		}

		// Token: 0x0601A760 RID: 108384
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAnimationScene_Stop_24(HandleRef pThis);

		/// <summary>
		/// Stops the animation scene that is running.
		/// </summary>
		// Token: 0x0601A761 RID: 108385 RVA: 0x0024BE09 File Offset: 0x0024A009
		public void Stop()
		{
			vtkAnimationScene.vtkAnimationScene_Stop_24(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CC1 RID: 7361
		public new const string MRFullTypeName = "Kitware.VTK.vtkAnimationScene";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CC2 RID: 7362
		public new static readonly string MRClassNameKey = "class vtkAnimationScene";

		/// <summary>
		/// Returns if the animation is being played.
		/// </summary>
		// Token: 0x020009F6 RID: 2550
		public enum PlayModes
		{
			/// <summary>enum member</summary>
			// Token: 0x04001CC4 RID: 7364
			PLAYMODE_REALTIME = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001CC5 RID: 7365
			PLAYMODE_SEQUENCE = 0
		}
	}
}
