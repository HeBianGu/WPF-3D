using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAxisFollower
	/// </summary>
	/// <remarks>
	///    a subclass of vtkFollower that ensures that
	/// data is always parallel to the axis defined by a vtkAxisActor.
	///
	/// vtkAxisFollower is a subclass of vtkFollower that always follows its
	/// specified axis. More specifically it will not change its position or scale,
	/// but it will continually update its orientation so that it is aligned with
	/// the axis and facing at angle to the camera to provide maximum visibility.
	/// This is typically used for text labels for 3d plots.
	/// </remarks>
	/// <seealso>
	///
	/// vtkActor vtkFollower vtkCamera vtkAxisActor vtkCubeAxesActor
	/// </seealso>
	// Token: 0x020003BD RID: 957
	public class vtkAxisFollower : vtkFollower
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600B06A RID: 45162 RVA: 0x000F9853 File Offset: 0x000F7A53
		static vtkAxisFollower()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAxisFollower.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAxisFollower"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600B06B RID: 45163 RVA: 0x000F987B File Offset: 0x000F7A7B
		public vtkAxisFollower(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600B06C RID: 45164
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisFollower_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates a follower with no camera set
		/// </summary>
		// Token: 0x0600B06D RID: 45165 RVA: 0x000F988C File Offset: 0x000F7A8C
		public new static vtkAxisFollower New()
		{
			vtkAxisFollower result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisFollower.vtkAxisFollower_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxisFollower)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Creates a follower with no camera set
		/// </summary>
		// Token: 0x0600B06E RID: 45166 RVA: 0x000F98E0 File Offset: 0x000F7AE0
		public vtkAxisFollower() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAxisFollower.vtkAxisFollower_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600B06F RID: 45167 RVA: 0x000F9924 File Offset: 0x000F7B24
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600B070 RID: 45168
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisFollower_AutoCenterOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get state of auto center mode where additional
		/// translation will be added to make sure the underlying
		/// geometry has its pivot point at the center of its bounds.
		/// </summary>
		// Token: 0x0600B071 RID: 45169 RVA: 0x000F992F File Offset: 0x000F7B2F
		public virtual void AutoCenterOff()
		{
			vtkAxisFollower.vtkAxisFollower_AutoCenterOff_01(base.GetCppThis());
		}

		// Token: 0x0600B072 RID: 45170
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisFollower_AutoCenterOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get state of auto center mode where additional
		/// translation will be added to make sure the underlying
		/// geometry has its pivot point at the center of its bounds.
		/// </summary>
		// Token: 0x0600B073 RID: 45171 RVA: 0x000F993E File Offset: 0x000F7B3E
		public virtual void AutoCenterOn()
		{
			vtkAxisFollower.vtkAxisFollower_AutoCenterOn_02(base.GetCppThis());
		}

		// Token: 0x0600B074 RID: 45172
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisFollower_AutoScale_03(HandleRef viewport, HandleRef camera, double screenSize, IntPtr position);

		/// <summary>
		/// Calculate scale factor to maintain same size of a object
		/// on the screen.
		/// </summary>
		// Token: 0x0600B075 RID: 45173 RVA: 0x000F9950 File Offset: 0x000F7B50
		public static double AutoScale(vtkViewport viewport, vtkCamera camera, double screenSize, IntPtr position)
		{
			return vtkAxisFollower.vtkAxisFollower_AutoScale_03((viewport == null) ? default(HandleRef) : viewport.GetCppThis(), (camera == null) ? default(HandleRef) : camera.GetCppThis(), screenSize, position);
		}

		// Token: 0x0600B076 RID: 45174
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisFollower_ComputeMatrix_04(HandleRef pThis);

		/// <summary>
		/// Overridden to disable this function, and use ComputeTransformMatrix instead, as
		/// we need a renderer to compute the transform matrix
		/// </summary>
		// Token: 0x0600B077 RID: 45175 RVA: 0x000F9995 File Offset: 0x000F7B95
		public override void ComputeMatrix()
		{
			vtkAxisFollower.vtkAxisFollower_ComputeMatrix_04(base.GetCppThis());
		}

		// Token: 0x0600B078 RID: 45176
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisFollower_ComputeTransformMatrix_05(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Generate the matrix based on ivars. This method overloads its superclasses
		/// ComputeMatrix() method due to the special vtkFollower matrix operations.
		/// </summary>
		// Token: 0x0600B079 RID: 45177 RVA: 0x000F99A4 File Offset: 0x000F7BA4
		public virtual void ComputeTransformMatrix(vtkRenderer ren)
		{
			vtkAxisFollower.vtkAxisFollower_ComputeTransformMatrix_05(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x0600B07A RID: 45178
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisFollower_GetAutoCenter_06(HandleRef pThis);

		/// <summary>
		/// Set/Get state of auto center mode where additional
		/// translation will be added to make sure the underlying
		/// geometry has its pivot point at the center of its bounds.
		/// </summary>
		// Token: 0x0600B07B RID: 45179 RVA: 0x000F99D4 File Offset: 0x000F7BD4
		public virtual int GetAutoCenter()
		{
			return vtkAxisFollower.vtkAxisFollower_GetAutoCenter_06(base.GetCppThis());
		}

		// Token: 0x0600B07C RID: 45180
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisFollower_GetAxis_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set axis that needs to be followed.
		/// </summary>
		// Token: 0x0600B07D RID: 45181 RVA: 0x000F99F4 File Offset: 0x000F7BF4
		public virtual vtkAxisActor GetAxis()
		{
			vtkAxisActor vtkAxisActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisFollower.vtkAxisFollower_GetAxis_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600B07E RID: 45182
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisFollower_GetDistanceLODThreshold_08(HandleRef pThis);

		/// <summary>
		/// Set distance LOD threshold (0.0 - 1.0).This determines at what fraction
		/// of camera far clip range, actor is not visible.
		/// Default is 0.80.
		/// </summary>
		// Token: 0x0600B07F RID: 45183 RVA: 0x000F9A64 File Offset: 0x000F7C64
		public virtual double GetDistanceLODThreshold()
		{
			return vtkAxisFollower.vtkAxisFollower_GetDistanceLODThreshold_08(base.GetCppThis());
		}

		// Token: 0x0600B080 RID: 45184
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisFollower_GetDistanceLODThresholdMaxValue_09(HandleRef pThis);

		/// <summary>
		/// Set distance LOD threshold (0.0 - 1.0).This determines at what fraction
		/// of camera far clip range, actor is not visible.
		/// Default is 0.80.
		/// </summary>
		// Token: 0x0600B081 RID: 45185 RVA: 0x000F9A84 File Offset: 0x000F7C84
		public virtual double GetDistanceLODThresholdMaxValue()
		{
			return vtkAxisFollower.vtkAxisFollower_GetDistanceLODThresholdMaxValue_09(base.GetCppThis());
		}

		// Token: 0x0600B082 RID: 45186
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisFollower_GetDistanceLODThresholdMinValue_10(HandleRef pThis);

		/// <summary>
		/// Set distance LOD threshold (0.0 - 1.0).This determines at what fraction
		/// of camera far clip range, actor is not visible.
		/// Default is 0.80.
		/// </summary>
		// Token: 0x0600B083 RID: 45187 RVA: 0x000F9AA4 File Offset: 0x000F7CA4
		public virtual double GetDistanceLODThresholdMinValue()
		{
			return vtkAxisFollower.vtkAxisFollower_GetDistanceLODThresholdMinValue_10(base.GetCppThis());
		}

		// Token: 0x0600B084 RID: 45188
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisFollower_GetEnableDistanceLOD_11(HandleRef pThis);

		/// <summary>
		/// Enable / disable use of distance based LOD. If enabled the actor
		/// will not be visible at a certain distance from the camera.
		/// Default is false.
		/// </summary>
		// Token: 0x0600B085 RID: 45189 RVA: 0x000F9AC4 File Offset: 0x000F7CC4
		public virtual int GetEnableDistanceLOD()
		{
			return vtkAxisFollower.vtkAxisFollower_GetEnableDistanceLOD_11(base.GetCppThis());
		}

		// Token: 0x0600B086 RID: 45190
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisFollower_GetEnableViewAngleLOD_12(HandleRef pThis);

		/// <summary>
		/// Enable / disable use of view angle based LOD. If enabled the actor
		/// will not be visible at a certain view angle.
		/// Default is true.
		/// </summary>
		// Token: 0x0600B087 RID: 45191 RVA: 0x000F9AE4 File Offset: 0x000F7CE4
		public virtual int GetEnableViewAngleLOD()
		{
			return vtkAxisFollower.vtkAxisFollower_GetEnableViewAngleLOD_12(base.GetCppThis());
		}

		// Token: 0x0600B088 RID: 45192
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAxisFollower_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B089 RID: 45193 RVA: 0x000F9B04 File Offset: 0x000F7D04
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAxisFollower.vtkAxisFollower_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x0600B08A RID: 45194
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAxisFollower_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B08B RID: 45195 RVA: 0x000F9B24 File Offset: 0x000F7D24
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAxisFollower.vtkAxisFollower_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x0600B08C RID: 45196
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisFollower_GetScreenOffset_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the desired screen offset from the axis.
		/// Convenience method, using a zero horizontal offset
		/// </summary>
		// Token: 0x0600B08D RID: 45197 RVA: 0x000F9B40 File Offset: 0x000F7D40
		public double GetScreenOffset()
		{
			return vtkAxisFollower.vtkAxisFollower_GetScreenOffset_15(base.GetCppThis());
		}

		// Token: 0x0600B08E RID: 45198
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisFollower_GetScreenOffsetVector_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the desired screen offset from the axis.
		/// first component is horizontal, second is vertical.
		/// </summary>
		// Token: 0x0600B08F RID: 45199 RVA: 0x000F9B60 File Offset: 0x000F7D60
		public virtual double[] GetScreenOffsetVector()
		{
			IntPtr intPtr = vtkAxisFollower.vtkAxisFollower_GetScreenOffsetVector_16(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600B090 RID: 45200
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisFollower_GetScreenOffsetVector_17(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Set/Get the desired screen offset from the axis.
		/// first component is horizontal, second is vertical.
		/// </summary>
		// Token: 0x0600B091 RID: 45201 RVA: 0x000F9BA8 File Offset: 0x000F7DA8
		public virtual void GetScreenOffsetVector(ref double _arg1, ref double _arg2)
		{
			vtkAxisFollower.vtkAxisFollower_GetScreenOffsetVector_17(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600B092 RID: 45202
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisFollower_GetScreenOffsetVector_18(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the desired screen offset from the axis.
		/// first component is horizontal, second is vertical.
		/// </summary>
		// Token: 0x0600B093 RID: 45203 RVA: 0x000F9BB9 File Offset: 0x000F7DB9
		public virtual void GetScreenOffsetVector(IntPtr _arg)
		{
			vtkAxisFollower.vtkAxisFollower_GetScreenOffsetVector_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B094 RID: 45204
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisFollower_GetViewAngleLODThreshold_19(HandleRef pThis);

		/// <summary>
		/// Set view angle LOD threshold (0.0 - 1.0).This determines at what view
		/// angle to geometry will make the geometry not visible.
		/// Default is 0.34.
		/// </summary>
		// Token: 0x0600B095 RID: 45205 RVA: 0x000F9BCC File Offset: 0x000F7DCC
		public virtual double GetViewAngleLODThreshold()
		{
			return vtkAxisFollower.vtkAxisFollower_GetViewAngleLODThreshold_19(base.GetCppThis());
		}

		// Token: 0x0600B096 RID: 45206
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisFollower_GetViewAngleLODThresholdMaxValue_20(HandleRef pThis);

		/// <summary>
		/// Set view angle LOD threshold (0.0 - 1.0).This determines at what view
		/// angle to geometry will make the geometry not visible.
		/// Default is 0.34.
		/// </summary>
		// Token: 0x0600B097 RID: 45207 RVA: 0x000F9BEC File Offset: 0x000F7DEC
		public virtual double GetViewAngleLODThresholdMaxValue()
		{
			return vtkAxisFollower.vtkAxisFollower_GetViewAngleLODThresholdMaxValue_20(base.GetCppThis());
		}

		// Token: 0x0600B098 RID: 45208
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisFollower_GetViewAngleLODThresholdMinValue_21(HandleRef pThis);

		/// <summary>
		/// Set view angle LOD threshold (0.0 - 1.0).This determines at what view
		/// angle to geometry will make the geometry not visible.
		/// Default is 0.34.
		/// </summary>
		// Token: 0x0600B099 RID: 45209 RVA: 0x000F9C0C File Offset: 0x000F7E0C
		public virtual double GetViewAngleLODThresholdMinValue()
		{
			return vtkAxisFollower.vtkAxisFollower_GetViewAngleLODThresholdMinValue_21(base.GetCppThis());
		}

		// Token: 0x0600B09A RID: 45210
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisFollower_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B09B RID: 45211 RVA: 0x000F9C2C File Offset: 0x000F7E2C
		public override int IsA(string type)
		{
			return vtkAxisFollower.vtkAxisFollower_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x0600B09C RID: 45212
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisFollower_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B09D RID: 45213 RVA: 0x000F9C4C File Offset: 0x000F7E4C
		public new static int IsTypeOf(string type)
		{
			return vtkAxisFollower.vtkAxisFollower_IsTypeOf_23(type);
		}

		// Token: 0x0600B09E RID: 45214
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisFollower_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B09F RID: 45215 RVA: 0x000F9C68 File Offset: 0x000F7E68
		public new vtkAxisFollower NewInstance()
		{
			vtkAxisFollower result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisFollower.vtkAxisFollower_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxisFollower)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600B0A0 RID: 45216
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisFollower_Render_26(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// This causes the actor to be rendered. It in turn will render the actor's
		/// property, texture map and then mapper. If a property hasn't been
		/// assigned, then the actor will create one automatically.
		/// </summary>
		// Token: 0x0600B0A1 RID: 45217 RVA: 0x000F9CC4 File Offset: 0x000F7EC4
		public override void Render(vtkRenderer ren)
		{
			vtkAxisFollower.vtkAxisFollower_Render_26(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x0600B0A2 RID: 45218
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisFollower_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B0A3 RID: 45219 RVA: 0x000F9CF4 File Offset: 0x000F7EF4
		public new static vtkAxisFollower SafeDownCast(vtkObjectBase o)
		{
			vtkAxisFollower vtkAxisFollower = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisFollower.vtkAxisFollower_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxisFollower = (vtkAxisFollower)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxisFollower.Register(null);
				}
			}
			return vtkAxisFollower;
		}

		// Token: 0x0600B0A4 RID: 45220
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisFollower_SetAutoCenter_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get state of auto center mode where additional
		/// translation will be added to make sure the underlying
		/// geometry has its pivot point at the center of its bounds.
		/// </summary>
		// Token: 0x0600B0A5 RID: 45221 RVA: 0x000F9D73 File Offset: 0x000F7F73
		public virtual void SetAutoCenter(int _arg)
		{
			vtkAxisFollower.vtkAxisFollower_SetAutoCenter_28(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B0A6 RID: 45222
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisFollower_SetAxis_29(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set axis that needs to be followed.
		/// </summary>
		// Token: 0x0600B0A7 RID: 45223 RVA: 0x000F9D84 File Offset: 0x000F7F84
		public virtual void SetAxis(vtkAxisActor arg0)
		{
			vtkAxisFollower.vtkAxisFollower_SetAxis_29(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B0A8 RID: 45224
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisFollower_SetDistanceLODThreshold_30(HandleRef pThis, double _arg);

		/// <summary>
		/// Set distance LOD threshold (0.0 - 1.0).This determines at what fraction
		/// of camera far clip range, actor is not visible.
		/// Default is 0.80.
		/// </summary>
		// Token: 0x0600B0A9 RID: 45225 RVA: 0x000F9DB3 File Offset: 0x000F7FB3
		public virtual void SetDistanceLODThreshold(double _arg)
		{
			vtkAxisFollower.vtkAxisFollower_SetDistanceLODThreshold_30(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B0AA RID: 45226
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisFollower_SetEnableDistanceLOD_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable / disable use of distance based LOD. If enabled the actor
		/// will not be visible at a certain distance from the camera.
		/// Default is false.
		/// </summary>
		// Token: 0x0600B0AB RID: 45227 RVA: 0x000F9DC3 File Offset: 0x000F7FC3
		public virtual void SetEnableDistanceLOD(int _arg)
		{
			vtkAxisFollower.vtkAxisFollower_SetEnableDistanceLOD_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B0AC RID: 45228
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisFollower_SetEnableViewAngleLOD_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable / disable use of view angle based LOD. If enabled the actor
		/// will not be visible at a certain view angle.
		/// Default is true.
		/// </summary>
		// Token: 0x0600B0AD RID: 45229 RVA: 0x000F9DD3 File Offset: 0x000F7FD3
		public virtual void SetEnableViewAngleLOD(int _arg)
		{
			vtkAxisFollower.vtkAxisFollower_SetEnableViewAngleLOD_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B0AE RID: 45230
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisFollower_SetScreenOffset_33(HandleRef pThis, double offset);

		/// <summary>
		/// Set/Get the desired screen offset from the axis.
		/// Convenience method, using a zero horizontal offset
		/// </summary>
		// Token: 0x0600B0AF RID: 45231 RVA: 0x000F9DE3 File Offset: 0x000F7FE3
		public void SetScreenOffset(double offset)
		{
			vtkAxisFollower.vtkAxisFollower_SetScreenOffset_33(base.GetCppThis(), offset);
		}

		// Token: 0x0600B0B0 RID: 45232
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisFollower_SetScreenOffsetVector_34(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Set/Get the desired screen offset from the axis.
		/// first component is horizontal, second is vertical.
		/// </summary>
		// Token: 0x0600B0B1 RID: 45233 RVA: 0x000F9DF3 File Offset: 0x000F7FF3
		public virtual void SetScreenOffsetVector(double _arg1, double _arg2)
		{
			vtkAxisFollower.vtkAxisFollower_SetScreenOffsetVector_34(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600B0B2 RID: 45234
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisFollower_SetScreenOffsetVector_35(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the desired screen offset from the axis.
		/// first component is horizontal, second is vertical.
		/// </summary>
		// Token: 0x0600B0B3 RID: 45235 RVA: 0x000F9E04 File Offset: 0x000F8004
		public void SetScreenOffsetVector(IntPtr _arg)
		{
			vtkAxisFollower.vtkAxisFollower_SetScreenOffsetVector_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B0B4 RID: 45236
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisFollower_SetViewAngleLODThreshold_36(HandleRef pThis, double _arg);

		/// <summary>
		/// Set view angle LOD threshold (0.0 - 1.0).This determines at what view
		/// angle to geometry will make the geometry not visible.
		/// Default is 0.34.
		/// </summary>
		// Token: 0x0600B0B5 RID: 45237 RVA: 0x000F9E14 File Offset: 0x000F8014
		public virtual void SetViewAngleLODThreshold(double _arg)
		{
			vtkAxisFollower.vtkAxisFollower_SetViewAngleLODThreshold_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B0B6 RID: 45238
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisFollower_ShallowCopy_37(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Shallow copy of a follower. Overloads the virtual vtkProp method.
		/// </summary>
		// Token: 0x0600B0B7 RID: 45239 RVA: 0x000F9E24 File Offset: 0x000F8024
		public override void ShallowCopy(vtkProp prop)
		{
			vtkAxisFollower.vtkAxisFollower_ShallowCopy_37(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000DBD RID: 3517
		public new const string MRFullTypeName = "Kitware.VTK.vtkAxisFollower";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000DBE RID: 3518
		public new static readonly string MRClassNameKey = "class vtkAxisFollower";
	}
}
