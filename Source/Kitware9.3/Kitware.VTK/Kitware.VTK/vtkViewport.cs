using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkViewport
	/// </summary>
	/// <remarks>
	///    abstract specification for Viewports
	///
	/// vtkViewport provides an abstract specification for Viewports. A Viewport
	/// is an object that controls the rendering process for objects. Rendering
	/// is the process of converting geometry, a specification for lights, and
	/// a camera view into an image. vtkViewport also performs coordinate
	/// transformation between world coordinates, view coordinates (the computer
	/// graphics rendering coordinate system), and display coordinates (the
	/// actual screen coordinates on the display device). Certain advanced
	/// rendering features such as two-sided lighting can also be controlled.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkWindow vtkRenderer
	/// </seealso>
	// Token: 0x020000AA RID: 170
	public abstract class vtkViewport : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060023FC RID: 9212 RVA: 0x00035F2F File Offset: 0x0003412F
		static vtkViewport()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkViewport.MRClassNameKey, Type.GetType("Kitware.VTK.vtkViewport"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060023FD RID: 9213 RVA: 0x00035F57 File Offset: 0x00034157
		public vtkViewport(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060023FE RID: 9214 RVA: 0x00035F65 File Offset: 0x00034165
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060023FF RID: 9215
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_AddActor2D_01(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Add/Remove different types of props to the renderer.
		/// These methods are all synonyms to AddViewProp and RemoveViewProp.
		/// They are here for convenience and backwards compatibility.
		/// </summary>
		// Token: 0x06002400 RID: 9216 RVA: 0x00035F70 File Offset: 0x00034170
		public void AddActor2D(vtkProp p)
		{
			vtkViewport.vtkViewport_AddActor2D_01(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x06002401 RID: 9217
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_AddViewProp_02(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Add a prop to the list of props. Does nothing if the prop is
		/// already present. Prop is the superclass of all actors, volumes,
		/// 2D actors, composite props etc.
		/// </summary>
		// Token: 0x06002402 RID: 9218 RVA: 0x00035FA0 File Offset: 0x000341A0
		public void AddViewProp(vtkProp arg0)
		{
			vtkViewport.vtkViewport_AddViewProp_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002403 RID: 9219
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_ComputeAspect_03(HandleRef pThis);

		/// <summary>
		/// Set the aspect ratio of the rendered image. This is computed
		/// automatically and should not be set by the user.
		/// </summary>
		// Token: 0x06002404 RID: 9220 RVA: 0x00035FCF File Offset: 0x000341CF
		public virtual void ComputeAspect()
		{
			vtkViewport.vtkViewport_ComputeAspect_03(base.GetCppThis());
		}

		// Token: 0x06002405 RID: 9221
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_DisplayToLocalDisplay_04(HandleRef pThis, ref double x, ref double y);

		/// <summary>
		/// These methods map from one coordinate system to another.
		/// They are primarily used by the vtkCoordinate object and
		/// are often strung together. These methods return valid information
		/// only if the window has been realized (e.g., GetSize() returns
		/// something other than (0,0)).
		/// </summary>
		// Token: 0x06002406 RID: 9222 RVA: 0x00035FDE File Offset: 0x000341DE
		public virtual void DisplayToLocalDisplay(ref double x, ref double y)
		{
			vtkViewport.vtkViewport_DisplayToLocalDisplay_04(base.GetCppThis(), ref x, ref y);
		}

		// Token: 0x06002407 RID: 9223
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_DisplayToNormalizedDisplay_05(HandleRef pThis, ref double u, ref double v);

		/// <summary>
		/// These methods map from one coordinate system to another.
		/// They are primarily used by the vtkCoordinate object and
		/// are often strung together. These methods return valid information
		/// only if the window has been realized (e.g., GetSize() returns
		/// something other than (0,0)).
		/// </summary>
		// Token: 0x06002408 RID: 9224 RVA: 0x00035FEF File Offset: 0x000341EF
		public virtual void DisplayToNormalizedDisplay(ref double u, ref double v)
		{
			vtkViewport.vtkViewport_DisplayToNormalizedDisplay_05(base.GetCppThis(), ref u, ref v);
		}

		// Token: 0x06002409 RID: 9225
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_DisplayToView_06(HandleRef pThis);

		/// <summary>
		/// Convert display coordinates to view coordinates.
		/// </summary>
		// Token: 0x0600240A RID: 9226 RVA: 0x00036000 File Offset: 0x00034200
		public virtual void DisplayToView()
		{
			vtkViewport.vtkViewport_DisplayToView_06(base.GetCppThis());
		}

		// Token: 0x0600240B RID: 9227
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_DisplayToWorld_07(HandleRef pThis);

		/// <summary>
		/// Convert display (or screen) coordinates to world coordinates.
		/// </summary>
		// Token: 0x0600240C RID: 9228 RVA: 0x0003600F File Offset: 0x0003420F
		public void DisplayToWorld()
		{
			vtkViewport.vtkViewport_DisplayToWorld_07(base.GetCppThis());
		}

		// Token: 0x0600240D RID: 9229
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewport_GetActors2D_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Add/Remove different types of props to the renderer.
		/// These methods are all synonyms to AddViewProp and RemoveViewProp.
		/// They are here for convenience and backwards compatibility.
		/// </summary>
		// Token: 0x0600240E RID: 9230 RVA: 0x00036020 File Offset: 0x00034220
		public vtkActor2DCollection GetActors2D()
		{
			vtkActor2DCollection vtkActor2DCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewport.vtkViewport_GetActors2D_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor2DCollection = (vtkActor2DCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor2DCollection.Register(null);
				}
			}
			return vtkActor2DCollection;
		}

		// Token: 0x0600240F RID: 9231
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewport_GetAspect_09(HandleRef pThis);

		/// <summary>
		/// Set the aspect ratio of the rendered image. This is computed
		/// automatically and should not be set by the user.
		/// </summary>
		// Token: 0x06002410 RID: 9232 RVA: 0x00036090 File Offset: 0x00034290
		public virtual double[] GetAspect()
		{
			IntPtr intPtr = vtkViewport.vtkViewport_GetAspect_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06002411 RID: 9233
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_GetAspect_10(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the aspect ratio of the rendered image. This is computed
		/// automatically and should not be set by the user.
		/// </summary>
		// Token: 0x06002412 RID: 9234 RVA: 0x000360D8 File Offset: 0x000342D8
		public virtual void GetAspect(IntPtr data)
		{
			vtkViewport.vtkViewport_GetAspect_10(base.GetCppThis(), data);
		}

		// Token: 0x06002413 RID: 9235
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewport_GetBackground_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the background color of the rendering screen using an rgb color
		/// specification.
		/// </summary>
		// Token: 0x06002414 RID: 9236 RVA: 0x000360E8 File Offset: 0x000342E8
		public virtual double[] GetBackground()
		{
			IntPtr intPtr = vtkViewport.vtkViewport_GetBackground_11(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06002415 RID: 9237
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_GetBackground_12(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the background color of the rendering screen using an rgb color
		/// specification.
		/// </summary>
		// Token: 0x06002416 RID: 9238 RVA: 0x00036130 File Offset: 0x00034330
		public virtual void GetBackground(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkViewport.vtkViewport_GetBackground_12(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06002417 RID: 9239
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_GetBackground_13(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the background color of the rendering screen using an rgb color
		/// specification.
		/// </summary>
		// Token: 0x06002418 RID: 9240 RVA: 0x00036142 File Offset: 0x00034342
		public virtual void GetBackground(IntPtr _arg)
		{
			vtkViewport.vtkViewport_GetBackground_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06002419 RID: 9241
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewport_GetBackground2_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the second background color of the rendering screen
		/// for gradient backgrounds using an rgb color specification.
		/// </summary>
		// Token: 0x0600241A RID: 9242 RVA: 0x00036154 File Offset: 0x00034354
		public virtual double[] GetBackground2()
		{
			IntPtr intPtr = vtkViewport.vtkViewport_GetBackground2_14(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600241B RID: 9243
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_GetBackground2_15(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the second background color of the rendering screen
		/// for gradient backgrounds using an rgb color specification.
		/// </summary>
		// Token: 0x0600241C RID: 9244 RVA: 0x0003619C File Offset: 0x0003439C
		public virtual void GetBackground2(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkViewport.vtkViewport_GetBackground2_15(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600241D RID: 9245
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_GetBackground2_16(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the second background color of the rendering screen
		/// for gradient backgrounds using an rgb color specification.
		/// </summary>
		// Token: 0x0600241E RID: 9246 RVA: 0x000361AE File Offset: 0x000343AE
		public virtual void GetBackground2(IntPtr _arg)
		{
			vtkViewport.vtkViewport_GetBackground2_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0600241F RID: 9247
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkViewport_GetBackgroundAlpha_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the alpha value used to fill the background with.
		/// By default, this is set to 0.0.
		/// </summary>
		// Token: 0x06002420 RID: 9248 RVA: 0x000361C0 File Offset: 0x000343C0
		public virtual double GetBackgroundAlpha()
		{
			return vtkViewport.vtkViewport_GetBackgroundAlpha_17(base.GetCppThis());
		}

		// Token: 0x06002421 RID: 9249
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkViewport_GetBackgroundAlphaMaxValue_18(HandleRef pThis);

		/// <summary>
		/// Set/Get the alpha value used to fill the background with.
		/// By default, this is set to 0.0.
		/// </summary>
		// Token: 0x06002422 RID: 9250 RVA: 0x000361E0 File Offset: 0x000343E0
		public virtual double GetBackgroundAlphaMaxValue()
		{
			return vtkViewport.vtkViewport_GetBackgroundAlphaMaxValue_18(base.GetCppThis());
		}

		// Token: 0x06002423 RID: 9251
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkViewport_GetBackgroundAlphaMinValue_19(HandleRef pThis);

		/// <summary>
		/// Set/Get the alpha value used to fill the background with.
		/// By default, this is set to 0.0.
		/// </summary>
		// Token: 0x06002424 RID: 9252 RVA: 0x00036200 File Offset: 0x00034400
		public virtual double GetBackgroundAlphaMinValue()
		{
			return vtkViewport.vtkViewport_GetBackgroundAlphaMinValue_19(base.GetCppThis());
		}

		// Token: 0x06002425 RID: 9253
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewport_GetCenter_20(HandleRef pThis);

		/// <summary>
		/// Return the center of this viewport in display coordinates.
		/// </summary>
		// Token: 0x06002426 RID: 9254 RVA: 0x00036220 File Offset: 0x00034420
		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkViewport.vtkViewport_GetCenter_20(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06002427 RID: 9255
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewport_GetDisplayPoint_21(HandleRef pThis);

		/// <summary>
		/// Set/get a point location in display (or screen) coordinates.
		/// The lower left corner of the window is the origin and y increases
		/// as you go up the screen.
		/// </summary>
		// Token: 0x06002428 RID: 9256 RVA: 0x00036268 File Offset: 0x00034468
		public virtual double[] GetDisplayPoint()
		{
			IntPtr intPtr = vtkViewport.vtkViewport_GetDisplayPoint_21(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06002429 RID: 9257
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_GetDisplayPoint_22(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/get a point location in display (or screen) coordinates.
		/// The lower left corner of the window is the origin and y increases
		/// as you go up the screen.
		/// </summary>
		// Token: 0x0600242A RID: 9258 RVA: 0x000362B0 File Offset: 0x000344B0
		public virtual void GetDisplayPoint(IntPtr data)
		{
			vtkViewport.vtkViewport_GetDisplayPoint_22(base.GetCppThis(), data);
		}

		// Token: 0x0600242B RID: 9259
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewport_GetEnvironmentalBG_23(HandleRef pThis);

		/// <summary>
		/// Set/Get the constant environmental color using an rgb color specification.
		/// Note this is currently ignored outside of RayTracing.
		/// </summary>
		// Token: 0x0600242C RID: 9260 RVA: 0x000362C0 File Offset: 0x000344C0
		public virtual double[] GetEnvironmentalBG()
		{
			IntPtr intPtr = vtkViewport.vtkViewport_GetEnvironmentalBG_23(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600242D RID: 9261
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_GetEnvironmentalBG_24(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the constant environmental color using an rgb color specification.
		/// Note this is currently ignored outside of RayTracing.
		/// </summary>
		// Token: 0x0600242E RID: 9262 RVA: 0x00036308 File Offset: 0x00034508
		public virtual void GetEnvironmentalBG(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkViewport.vtkViewport_GetEnvironmentalBG_24(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600242F RID: 9263
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_GetEnvironmentalBG_25(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the constant environmental color using an rgb color specification.
		/// Note this is currently ignored outside of RayTracing.
		/// </summary>
		// Token: 0x06002430 RID: 9264 RVA: 0x0003631A File Offset: 0x0003451A
		public virtual void GetEnvironmentalBG(IntPtr _arg)
		{
			vtkViewport.vtkViewport_GetEnvironmentalBG_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06002431 RID: 9265
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewport_GetEnvironmentalBG2_26(HandleRef pThis);

		/// <summary>
		/// Set/Get the second environmental gradient color using an rgb color specification.
		/// Note this is currently ignored outside of RayTracing.
		/// </summary>
		// Token: 0x06002432 RID: 9266 RVA: 0x0003632C File Offset: 0x0003452C
		public virtual double[] GetEnvironmentalBG2()
		{
			IntPtr intPtr = vtkViewport.vtkViewport_GetEnvironmentalBG2_26(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06002433 RID: 9267
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_GetEnvironmentalBG2_27(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the second environmental gradient color using an rgb color specification.
		/// Note this is currently ignored outside of RayTracing.
		/// </summary>
		// Token: 0x06002434 RID: 9268 RVA: 0x00036374 File Offset: 0x00034574
		public virtual void GetEnvironmentalBG2(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkViewport.vtkViewport_GetEnvironmentalBG2_27(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06002435 RID: 9269
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_GetEnvironmentalBG2_28(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the second environmental gradient color using an rgb color specification.
		/// Note this is currently ignored outside of RayTracing.
		/// </summary>
		// Token: 0x06002436 RID: 9270 RVA: 0x00036386 File Offset: 0x00034586
		public virtual void GetEnvironmentalBG2(IntPtr _arg)
		{
			vtkViewport.vtkViewport_GetEnvironmentalBG2_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06002437 RID: 9271
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkViewport_GetGradientBackground_29(HandleRef pThis);

		/// <summary>
		/// Set/Get whether this viewport should have a gradient background
		/// using the Background (bottom) and Background2 (top) colors.
		/// Default is off.
		/// </summary>
		// Token: 0x06002438 RID: 9272 RVA: 0x00036398 File Offset: 0x00034598
		public virtual bool GetGradientBackground()
		{
			return vtkViewport.vtkViewport_GetGradientBackground_29(base.GetCppThis()) != 0;
		}

		// Token: 0x06002439 RID: 9273
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkViewport_GetGradientEnvironmentalBG_30(HandleRef pThis);

		/// <summary>
		/// Set/Get whether this viewport should enable the gradient environment
		/// using the EnvironmentalBG (bottom) and EnvironmentalBG2 (top) colors.
		/// Note this is currently ignored outside of RayTracing.
		/// Default is off.
		/// </summary>
		// Token: 0x0600243A RID: 9274 RVA: 0x000363C0 File Offset: 0x000345C0
		public virtual bool GetGradientEnvironmentalBG()
		{
			return vtkViewport.vtkViewport_GetGradientEnvironmentalBG_30(base.GetCppThis()) != 0;
		}

		// Token: 0x0600243B RID: 9275
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkViewport.GradientModes vtkViewport_GetGradientMode_31(HandleRef pThis);

		/// <summary>
		/// Specify the direction of the gradient background.
		/// All modes smoothly interpolate the color from `Background` to `Background2`
		/// @sa vtkViewport::GradientModes
		/// </summary>
		// Token: 0x0600243C RID: 9276 RVA: 0x000363E8 File Offset: 0x000345E8
		public virtual vtkViewport.GradientModes GetGradientMode()
		{
			return vtkViewport.vtkViewport_GetGradientMode_31(base.GetCppThis());
		}

		// Token: 0x0600243D RID: 9277
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkViewport_GetNumberOfGenerationsFromBase_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600243E RID: 9278 RVA: 0x00036408 File Offset: 0x00034608
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkViewport.vtkViewport_GetNumberOfGenerationsFromBase_32(base.GetCppThis(), type);
		}

		// Token: 0x0600243F RID: 9279
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkViewport_GetNumberOfGenerationsFromBaseType_33([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002440 RID: 9280 RVA: 0x00036428 File Offset: 0x00034628
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkViewport.vtkViewport_GetNumberOfGenerationsFromBaseType_33(type);
		}

		// Token: 0x06002441 RID: 9281
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewport_GetOrigin_34(HandleRef pThis);

		/// <summary>
		/// Get the size and origin of the viewport in display coordinates. Note:
		/// if the window has not yet been realized, GetSize() and GetOrigin()
		/// return (0,0).
		/// </summary>
		// Token: 0x06002442 RID: 9282 RVA: 0x00036444 File Offset: 0x00034644
		public virtual int[] GetOrigin()
		{
			IntPtr intPtr = vtkViewport.vtkViewport_GetOrigin_34(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06002443 RID: 9283
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkViewport_GetPickHeight_35(HandleRef pThis);

		/// <summary>
		/// Methods used to return the pick (x,y) in local display coordinates (i.e.,
		/// it's that same as selectionX and selectionY).
		/// </summary>
		// Token: 0x06002444 RID: 9284 RVA: 0x0003648C File Offset: 0x0003468C
		public double GetPickHeight()
		{
			return vtkViewport.vtkViewport_GetPickHeight_35(base.GetCppThis());
		}

		// Token: 0x06002445 RID: 9285
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewport_GetPickResultProps_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Methods used to return the pick (x,y) in local display coordinates (i.e.,
		/// it's that same as selectionX and selectionY).
		/// </summary>
		// Token: 0x06002446 RID: 9286 RVA: 0x000364AC File Offset: 0x000346AC
		public virtual vtkPropCollection GetPickResultProps()
		{
			vtkPropCollection vtkPropCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewport.vtkViewport_GetPickResultProps_36(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPropCollection = (vtkPropCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPropCollection.Register(null);
				}
			}
			return vtkPropCollection;
		}

		// Token: 0x06002447 RID: 9287
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkViewport_GetPickWidth_37(HandleRef pThis);

		/// <summary>
		/// Methods used to return the pick (x,y) in local display coordinates (i.e.,
		/// it's that same as selectionX and selectionY).
		/// </summary>
		// Token: 0x06002448 RID: 9288 RVA: 0x0003651C File Offset: 0x0003471C
		public double GetPickWidth()
		{
			return vtkViewport.vtkViewport_GetPickWidth_37(base.GetCppThis());
		}

		// Token: 0x06002449 RID: 9289
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkViewport_GetPickX_38(HandleRef pThis);

		/// <summary>
		/// Methods used to return the pick (x,y) in local display coordinates (i.e.,
		/// it's that same as selectionX and selectionY).
		/// </summary>
		// Token: 0x0600244A RID: 9290 RVA: 0x0003653C File Offset: 0x0003473C
		public double GetPickX()
		{
			return vtkViewport.vtkViewport_GetPickX_38(base.GetCppThis());
		}

		// Token: 0x0600244B RID: 9291
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkViewport_GetPickX1_39(HandleRef pThis);

		/// <summary>
		/// Methods used to return the pick (x,y) in local display coordinates (i.e.,
		/// it's that same as selectionX and selectionY).
		/// </summary>
		// Token: 0x0600244C RID: 9292 RVA: 0x0003655C File Offset: 0x0003475C
		public double GetPickX1()
		{
			return vtkViewport.vtkViewport_GetPickX1_39(base.GetCppThis());
		}

		// Token: 0x0600244D RID: 9293
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkViewport_GetPickX2_40(HandleRef pThis);

		/// <summary>
		/// Methods used to return the pick (x,y) in local display coordinates (i.e.,
		/// it's that same as selectionX and selectionY).
		/// </summary>
		// Token: 0x0600244E RID: 9294 RVA: 0x0003657C File Offset: 0x0003477C
		public double GetPickX2()
		{
			return vtkViewport.vtkViewport_GetPickX2_40(base.GetCppThis());
		}

		// Token: 0x0600244F RID: 9295
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkViewport_GetPickY_41(HandleRef pThis);

		/// <summary>
		/// Methods used to return the pick (x,y) in local display coordinates (i.e.,
		/// it's that same as selectionX and selectionY).
		/// </summary>
		// Token: 0x06002450 RID: 9296 RVA: 0x0003659C File Offset: 0x0003479C
		public double GetPickY()
		{
			return vtkViewport.vtkViewport_GetPickY_41(base.GetCppThis());
		}

		// Token: 0x06002451 RID: 9297
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkViewport_GetPickY1_42(HandleRef pThis);

		/// <summary>
		/// Methods used to return the pick (x,y) in local display coordinates (i.e.,
		/// it's that same as selectionX and selectionY).
		/// </summary>
		// Token: 0x06002452 RID: 9298 RVA: 0x000365BC File Offset: 0x000347BC
		public double GetPickY1()
		{
			return vtkViewport.vtkViewport_GetPickY1_42(base.GetCppThis());
		}

		// Token: 0x06002453 RID: 9299
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkViewport_GetPickY2_43(HandleRef pThis);

		/// <summary>
		/// Methods used to return the pick (x,y) in local display coordinates (i.e.,
		/// it's that same as selectionX and selectionY).
		/// </summary>
		// Token: 0x06002454 RID: 9300 RVA: 0x000365DC File Offset: 0x000347DC
		public double GetPickY2()
		{
			return vtkViewport.vtkViewport_GetPickY2_43(base.GetCppThis());
		}

		// Token: 0x06002455 RID: 9301
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkViewport_GetPickedZ_44(HandleRef pThis);

		/// <summary>
		/// Return the Z value for the last picked Prop.
		/// </summary>
		// Token: 0x06002456 RID: 9302 RVA: 0x000365FC File Offset: 0x000347FC
		public virtual double GetPickedZ()
		{
			return vtkViewport.vtkViewport_GetPickedZ_44(base.GetCppThis());
		}

		// Token: 0x06002457 RID: 9303
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewport_GetPixelAspect_45(HandleRef pThis);

		/// <summary>
		/// Set the aspect ratio of a pixel in the rendered image.
		/// This factor permits the image to rendered anisotropically
		/// (i.e., stretched in one direction or the other).
		/// </summary>
		// Token: 0x06002458 RID: 9304 RVA: 0x0003661C File Offset: 0x0003481C
		public virtual double[] GetPixelAspect()
		{
			IntPtr intPtr = vtkViewport.vtkViewport_GetPixelAspect_45(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06002459 RID: 9305
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_GetPixelAspect_46(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the aspect ratio of a pixel in the rendered image.
		/// This factor permits the image to rendered anisotropically
		/// (i.e., stretched in one direction or the other).
		/// </summary>
		// Token: 0x0600245A RID: 9306 RVA: 0x00036664 File Offset: 0x00034864
		public virtual void GetPixelAspect(IntPtr data)
		{
			vtkViewport.vtkViewport_GetPixelAspect_46(base.GetCppThis(), data);
		}

		// Token: 0x0600245B RID: 9307
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewport_GetSize_47(HandleRef pThis);

		/// <summary>
		/// Get the size and origin of the viewport in display coordinates. Note:
		/// if the window has not yet been realized, GetSize() and GetOrigin()
		/// return (0,0).
		/// </summary>
		// Token: 0x0600245C RID: 9308 RVA: 0x00036674 File Offset: 0x00034874
		public virtual int[] GetSize()
		{
			IntPtr intPtr = vtkViewport.vtkViewport_GetSize_47(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600245D RID: 9309
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_GetTiledSize_48(HandleRef pThis, IntPtr width, IntPtr height);

		/// <summary>
		/// Get the size and origin of the viewport in display coordinates. Note:
		/// if the window has not yet been realized, GetSize() and GetOrigin()
		/// return (0,0).
		/// </summary>
		// Token: 0x0600245E RID: 9310 RVA: 0x000366BC File Offset: 0x000348BC
		public void GetTiledSize(IntPtr width, IntPtr height)
		{
			vtkViewport.vtkViewport_GetTiledSize_48(base.GetCppThis(), width, height);
		}

		// Token: 0x0600245F RID: 9311
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_GetTiledSizeAndOrigin_49(HandleRef pThis, IntPtr width, IntPtr height, IntPtr lowerLeftX, IntPtr lowerLeftY);

		/// <summary>
		/// Get the size and origin of the viewport in display coordinates. Note:
		/// if the window has not yet been realized, GetSize() and GetOrigin()
		/// return (0,0).
		/// </summary>
		// Token: 0x06002460 RID: 9312 RVA: 0x000366CD File Offset: 0x000348CD
		public virtual void GetTiledSizeAndOrigin(IntPtr width, IntPtr height, IntPtr lowerLeftX, IntPtr lowerLeftY)
		{
			vtkViewport.vtkViewport_GetTiledSizeAndOrigin_49(base.GetCppThis(), width, height, lowerLeftX, lowerLeftY);
		}

		// Token: 0x06002461 RID: 9313
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewport_GetVTKWindow_50(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the vtkWindow that owns this vtkViewport.
		/// </summary>
		// Token: 0x06002462 RID: 9314 RVA: 0x000366E4 File Offset: 0x000348E4
		public virtual vtkWindow GetVTKWindow()
		{
			vtkWindow vtkWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewport.vtkViewport_GetVTKWindow_50(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06002463 RID: 9315
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewport_GetViewPoint_51(HandleRef pThis);

		/// <summary>
		/// Specify a point location in view coordinates. The origin is in the
		/// middle of the viewport and it extends from -1 to 1 in all three
		/// dimensions.
		/// </summary>
		// Token: 0x06002464 RID: 9316 RVA: 0x00036754 File Offset: 0x00034954
		public virtual double[] GetViewPoint()
		{
			IntPtr intPtr = vtkViewport.vtkViewport_GetViewPoint_51(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06002465 RID: 9317
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_GetViewPoint_52(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify a point location in view coordinates. The origin is in the
		/// middle of the viewport and it extends from -1 to 1 in all three
		/// dimensions.
		/// </summary>
		// Token: 0x06002466 RID: 9318 RVA: 0x0003679C File Offset: 0x0003499C
		public virtual void GetViewPoint(IntPtr data)
		{
			vtkViewport.vtkViewport_GetViewPoint_52(base.GetCppThis(), data);
		}

		// Token: 0x06002467 RID: 9319
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewport_GetViewProps_53(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return any props in this viewport.
		/// </summary>
		// Token: 0x06002468 RID: 9320 RVA: 0x000367AC File Offset: 0x000349AC
		public vtkPropCollection GetViewProps()
		{
			vtkPropCollection vtkPropCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewport.vtkViewport_GetViewProps_53(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPropCollection = (vtkPropCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPropCollection.Register(null);
				}
			}
			return vtkPropCollection;
		}

		// Token: 0x06002469 RID: 9321
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewport_GetViewport_54(HandleRef pThis);

		/// <summary>
		/// Specify the viewport for the Viewport to draw in the rendering window.
		/// Coordinates are expressed as (xmin,ymin,xmax,ymax), where each
		/// coordinate is 0 &lt;= coordinate &lt;= 1.0.
		/// </summary>
		// Token: 0x0600246A RID: 9322 RVA: 0x0003681C File Offset: 0x00034A1C
		public virtual double[] GetViewport()
		{
			IntPtr intPtr = vtkViewport.vtkViewport_GetViewport_54(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600246B RID: 9323
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_GetViewport_55(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the viewport for the Viewport to draw in the rendering window.
		/// Coordinates are expressed as (xmin,ymin,xmax,ymax), where each
		/// coordinate is 0 &lt;= coordinate &lt;= 1.0.
		/// </summary>
		// Token: 0x0600246C RID: 9324 RVA: 0x00036864 File Offset: 0x00034A64
		public virtual void GetViewport(IntPtr data)
		{
			vtkViewport.vtkViewport_GetViewport_55(base.GetCppThis(), data);
		}

		// Token: 0x0600246D RID: 9325
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewport_GetWorldPoint_56(HandleRef pThis);

		/// <summary>
		/// Specify a point location in world coordinates. This method takes
		/// homogeneous coordinates.
		/// </summary>
		// Token: 0x0600246E RID: 9326 RVA: 0x00036874 File Offset: 0x00034A74
		public virtual double[] GetWorldPoint()
		{
			IntPtr intPtr = vtkViewport.vtkViewport_GetWorldPoint_56(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600246F RID: 9327
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_GetWorldPoint_57(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify a point location in world coordinates. This method takes
		/// homogeneous coordinates.
		/// </summary>
		// Token: 0x06002470 RID: 9328 RVA: 0x000368BC File Offset: 0x00034ABC
		public virtual void GetWorldPoint(IntPtr data)
		{
			vtkViewport.vtkViewport_GetWorldPoint_57(base.GetCppThis(), data);
		}

		// Token: 0x06002471 RID: 9329
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_GradientBackgroundOff_58(HandleRef pThis);

		/// <summary>
		/// Set/Get whether this viewport should have a gradient background
		/// using the Background (bottom) and Background2 (top) colors.
		/// Default is off.
		/// </summary>
		// Token: 0x06002472 RID: 9330 RVA: 0x000368CC File Offset: 0x00034ACC
		public virtual void GradientBackgroundOff()
		{
			vtkViewport.vtkViewport_GradientBackgroundOff_58(base.GetCppThis());
		}

		// Token: 0x06002473 RID: 9331
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_GradientBackgroundOn_59(HandleRef pThis);

		/// <summary>
		/// Set/Get whether this viewport should have a gradient background
		/// using the Background (bottom) and Background2 (top) colors.
		/// Default is off.
		/// </summary>
		// Token: 0x06002474 RID: 9332 RVA: 0x000368DB File Offset: 0x00034ADB
		public virtual void GradientBackgroundOn()
		{
			vtkViewport.vtkViewport_GradientBackgroundOn_59(base.GetCppThis());
		}

		// Token: 0x06002475 RID: 9333
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_GradientEnvironmentalBGOff_60(HandleRef pThis);

		/// <summary>
		/// Set/Get whether this viewport should enable the gradient environment
		/// using the EnvironmentalBG (bottom) and EnvironmentalBG2 (top) colors.
		/// Note this is currently ignored outside of RayTracing.
		/// Default is off.
		/// </summary>
		// Token: 0x06002476 RID: 9334 RVA: 0x000368EA File Offset: 0x00034AEA
		public virtual void GradientEnvironmentalBGOff()
		{
			vtkViewport.vtkViewport_GradientEnvironmentalBGOff_60(base.GetCppThis());
		}

		// Token: 0x06002477 RID: 9335
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_GradientEnvironmentalBGOn_61(HandleRef pThis);

		/// <summary>
		/// Set/Get whether this viewport should enable the gradient environment
		/// using the EnvironmentalBG (bottom) and EnvironmentalBG2 (top) colors.
		/// Note this is currently ignored outside of RayTracing.
		/// Default is off.
		/// </summary>
		// Token: 0x06002478 RID: 9336 RVA: 0x000368F9 File Offset: 0x00034AF9
		public virtual void GradientEnvironmentalBGOn()
		{
			vtkViewport.vtkViewport_GradientEnvironmentalBGOn_61(base.GetCppThis());
		}

		// Token: 0x06002479 RID: 9337
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkViewport_HasViewProp_62(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Query if a prop is in the list of props.
		/// </summary>
		// Token: 0x0600247A RID: 9338 RVA: 0x00036908 File Offset: 0x00034B08
		public int HasViewProp(vtkProp arg0)
		{
			return vtkViewport.vtkViewport_HasViewProp_62(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600247B RID: 9339
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkViewport_IsA_63(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600247C RID: 9340 RVA: 0x0003693C File Offset: 0x00034B3C
		public override int IsA(string type)
		{
			return vtkViewport.vtkViewport_IsA_63(base.GetCppThis(), type);
		}

		// Token: 0x0600247D RID: 9341
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkViewport_IsInViewport_64(HandleRef pThis, int x, int y);

		/// <summary>
		/// Is a given display point in this Viewport's viewport.
		/// </summary>
		// Token: 0x0600247E RID: 9342 RVA: 0x0003695C File Offset: 0x00034B5C
		public virtual int IsInViewport(int x, int y)
		{
			return vtkViewport.vtkViewport_IsInViewport_64(base.GetCppThis(), x, y);
		}

		// Token: 0x0600247F RID: 9343
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkViewport_IsTypeOf_65([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002480 RID: 9344 RVA: 0x00036980 File Offset: 0x00034B80
		public new static int IsTypeOf(string type)
		{
			return vtkViewport.vtkViewport_IsTypeOf_65(type);
		}

		// Token: 0x06002481 RID: 9345
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_LocalDisplayToDisplay_66(HandleRef pThis, ref double x, ref double y);

		/// <summary>
		/// These methods map from one coordinate system to another.
		/// They are primarily used by the vtkCoordinate object and
		/// are often strung together. These methods return valid information
		/// only if the window has been realized (e.g., GetSize() returns
		/// something other than (0,0)).
		/// </summary>
		// Token: 0x06002482 RID: 9346 RVA: 0x0003699A File Offset: 0x00034B9A
		public virtual void LocalDisplayToDisplay(ref double x, ref double y)
		{
			vtkViewport.vtkViewport_LocalDisplayToDisplay_66(base.GetCppThis(), ref x, ref y);
		}

		// Token: 0x06002483 RID: 9347
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewport_NewInstance_67(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002484 RID: 9348 RVA: 0x000369AC File Offset: 0x00034BAC
		public new vtkViewport NewInstance()
		{
			vtkViewport result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewport.vtkViewport_NewInstance_67(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkViewport)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002485 RID: 9349
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_NormalizedDisplayToDisplay_68(HandleRef pThis, ref double u, ref double v);

		/// <summary>
		/// These methods map from one coordinate system to another.
		/// They are primarily used by the vtkCoordinate object and
		/// are often strung together. These methods return valid information
		/// only if the window has been realized (e.g., GetSize() returns
		/// something other than (0,0)).
		/// </summary>
		// Token: 0x06002486 RID: 9350 RVA: 0x00036A06 File Offset: 0x00034C06
		public virtual void NormalizedDisplayToDisplay(ref double u, ref double v)
		{
			vtkViewport.vtkViewport_NormalizedDisplayToDisplay_68(base.GetCppThis(), ref u, ref v);
		}

		// Token: 0x06002487 RID: 9351
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_NormalizedDisplayToViewport_69(HandleRef pThis, ref double x, ref double y);

		/// <summary>
		/// These methods map from one coordinate system to another.
		/// They are primarily used by the vtkCoordinate object and
		/// are often strung together. These methods return valid information
		/// only if the window has been realized (e.g., GetSize() returns
		/// something other than (0,0)).
		/// </summary>
		// Token: 0x06002488 RID: 9352 RVA: 0x00036A17 File Offset: 0x00034C17
		public virtual void NormalizedDisplayToViewport(ref double x, ref double y)
		{
			vtkViewport.vtkViewport_NormalizedDisplayToViewport_69(base.GetCppThis(), ref x, ref y);
		}

		// Token: 0x06002489 RID: 9353
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_NormalizedViewportToView_70(HandleRef pThis, ref double x, ref double y, ref double z);

		/// <summary>
		/// These methods map from one coordinate system to another.
		/// They are primarily used by the vtkCoordinate object and
		/// are often strung together. These methods return valid information
		/// only if the window has been realized (e.g., GetSize() returns
		/// something other than (0,0)).
		/// </summary>
		// Token: 0x0600248A RID: 9354 RVA: 0x00036A28 File Offset: 0x00034C28
		public virtual void NormalizedViewportToView(ref double x, ref double y, ref double z)
		{
			vtkViewport.vtkViewport_NormalizedViewportToView_70(base.GetCppThis(), ref x, ref y, ref z);
		}

		// Token: 0x0600248B RID: 9355
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_NormalizedViewportToViewport_71(HandleRef pThis, ref double u, ref double v);

		/// <summary>
		/// These methods map from one coordinate system to another.
		/// They are primarily used by the vtkCoordinate object and
		/// are often strung together. These methods return valid information
		/// only if the window has been realized (e.g., GetSize() returns
		/// something other than (0,0)).
		/// </summary>
		// Token: 0x0600248C RID: 9356 RVA: 0x00036A3A File Offset: 0x00034C3A
		public virtual void NormalizedViewportToViewport(ref double u, ref double v)
		{
			vtkViewport.vtkViewport_NormalizedViewportToViewport_71(base.GetCppThis(), ref u, ref v);
		}

		// Token: 0x0600248D RID: 9357
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewport_PickProp_72(HandleRef pThis, double selectionX, double selectionY, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the Prop that has the highest z value at the given x, y position
		/// in the viewport.  Basically, the top most prop that renders the pixel at
		/// selectionX, selectionY will be returned.  If no Props are there NULL is
		/// returned.  This method selects from the Viewports Prop list.
		/// </summary>
		// Token: 0x0600248E RID: 9358 RVA: 0x00036A4C File Offset: 0x00034C4C
		public virtual vtkAssemblyPath PickProp(double selectionX, double selectionY)
		{
			vtkAssemblyPath vtkAssemblyPath = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewport.vtkViewport_PickProp_72(base.GetCppThis(), selectionX, selectionY, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600248F RID: 9359
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewport_PickProp_73(HandleRef pThis, double selectionX1, double selectionY1, double selectionX2, double selectionY2, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the Prop that has the highest z value at the given x1, y1
		/// and x2,y2 positions in the viewport.  Basically, the top most prop that
		/// renders the pixel at selectionX1, selectionY1, selectionX2, selectionY2
		/// will be returned.  If no Props are there NULL is returned.  This method
		/// selects from the Viewports Prop list.
		/// </summary>
		// Token: 0x06002490 RID: 9360 RVA: 0x00036AC0 File Offset: 0x00034CC0
		public virtual vtkAssemblyPath PickProp(double selectionX1, double selectionY1, double selectionX2, double selectionY2)
		{
			vtkAssemblyPath vtkAssemblyPath = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewport.vtkViewport_PickProp_73(base.GetCppThis(), selectionX1, selectionY1, selectionX2, selectionY2, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06002491 RID: 9361
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewport_PickPropFrom_74(HandleRef pThis, double selectionX, double selectionY, HandleRef arg2, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Same as PickProp with two arguments, but selects from the given
		/// collection of Props instead of the Renderers props.  Make sure
		/// the Props in the collection are in this renderer.
		/// </summary>
		// Token: 0x06002492 RID: 9362 RVA: 0x00036B34 File Offset: 0x00034D34
		public vtkAssemblyPath PickPropFrom(double selectionX, double selectionY, vtkPropCollection arg2)
		{
			vtkAssemblyPath vtkAssemblyPath = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewport.vtkViewport_PickPropFrom_74(base.GetCppThis(), selectionX, selectionY, (arg2 == null) ? default(HandleRef) : arg2.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06002493 RID: 9363
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewport_PickPropFrom_75(HandleRef pThis, double selectionX1, double selectionY1, double selectionX2, double selectionY2, HandleRef arg4, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Same as PickProp with four arguments, but selects from the given
		/// collection of Props instead of the Renderers props.  Make sure
		/// the Props in the collection are in this renderer.
		/// </summary>
		// Token: 0x06002494 RID: 9364 RVA: 0x00036BBC File Offset: 0x00034DBC
		public vtkAssemblyPath PickPropFrom(double selectionX1, double selectionY1, double selectionX2, double selectionY2, vtkPropCollection arg4)
		{
			vtkAssemblyPath vtkAssemblyPath = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewport.vtkViewport_PickPropFrom_75(base.GetCppThis(), selectionX1, selectionY1, selectionX2, selectionY2, (arg4 == null) ? default(HandleRef) : arg4.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06002495 RID: 9365
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_PoseToView_76(HandleRef pThis, ref double arg0, ref double arg1, ref double arg2);

		/// <summary>
		/// These methods map from one coordinate system to another.
		/// They are primarily used by the vtkCoordinate object and
		/// are often strung together. These methods return valid information
		/// only if the window has been realized (e.g., GetSize() returns
		/// something other than (0,0)).
		/// </summary>
		// Token: 0x06002496 RID: 9366 RVA: 0x00036C48 File Offset: 0x00034E48
		public virtual void PoseToView(ref double arg0, ref double arg1, ref double arg2)
		{
			vtkViewport.vtkViewport_PoseToView_76(base.GetCppThis(), ref arg0, ref arg1, ref arg2);
		}

		// Token: 0x06002497 RID: 9367
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_PoseToWorld_77(HandleRef pThis, ref double arg0, ref double arg1, ref double arg2);

		/// <summary>
		/// These methods map from one coordinate system to another.
		/// They are primarily used by the vtkCoordinate object and
		/// are often strung together. These methods return valid information
		/// only if the window has been realized (e.g., GetSize() returns
		/// something other than (0,0)).
		/// </summary>
		// Token: 0x06002498 RID: 9368 RVA: 0x00036C5A File Offset: 0x00034E5A
		public virtual void PoseToWorld(ref double arg0, ref double arg1, ref double arg2)
		{
			vtkViewport.vtkViewport_PoseToWorld_77(base.GetCppThis(), ref arg0, ref arg1, ref arg2);
		}

		// Token: 0x06002499 RID: 9369
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_RemoveActor2D_78(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Add/Remove different types of props to the renderer.
		/// These methods are all synonyms to AddViewProp and RemoveViewProp.
		/// They are here for convenience and backwards compatibility.
		/// </summary>
		// Token: 0x0600249A RID: 9370 RVA: 0x00036C6C File Offset: 0x00034E6C
		public void RemoveActor2D(vtkProp p)
		{
			vtkViewport.vtkViewport_RemoveActor2D_78(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600249B RID: 9371
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_RemoveAllViewProps_79(HandleRef pThis);

		/// <summary>
		/// Remove all props from the list of props.
		/// </summary>
		// Token: 0x0600249C RID: 9372 RVA: 0x00036C9B File Offset: 0x00034E9B
		public void RemoveAllViewProps()
		{
			vtkViewport.vtkViewport_RemoveAllViewProps_79(base.GetCppThis());
		}

		// Token: 0x0600249D RID: 9373
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_RemoveViewProp_80(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Remove a prop from the list of props. Does nothing if the prop
		/// is not already present or if the parameter is NULL.
		/// </summary>
		// Token: 0x0600249E RID: 9374 RVA: 0x00036CAC File Offset: 0x00034EAC
		public void RemoveViewProp(vtkProp arg0)
		{
			vtkViewport.vtkViewport_RemoveViewProp_80(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600249F RID: 9375
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkViewport_SafeDownCast_81(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060024A0 RID: 9376 RVA: 0x00036CDC File Offset: 0x00034EDC
		public new static vtkViewport SafeDownCast(vtkObjectBase o)
		{
			vtkViewport vtkViewport = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkViewport.vtkViewport_SafeDownCast_81((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkViewport = (vtkViewport)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkViewport.Register(null);
				}
			}
			return vtkViewport;
		}

		// Token: 0x060024A1 RID: 9377
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_SetAspect_82(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Set the aspect ratio of the rendered image. This is computed
		/// automatically and should not be set by the user.
		/// </summary>
		// Token: 0x060024A2 RID: 9378 RVA: 0x00036D5B File Offset: 0x00034F5B
		public virtual void SetAspect(double _arg1, double _arg2)
		{
			vtkViewport.vtkViewport_SetAspect_82(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x060024A3 RID: 9379
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_SetAspect_83(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the aspect ratio of the rendered image. This is computed
		/// automatically and should not be set by the user.
		/// </summary>
		// Token: 0x060024A4 RID: 9380 RVA: 0x00036D6C File Offset: 0x00034F6C
		public void SetAspect(IntPtr _arg)
		{
			vtkViewport.vtkViewport_SetAspect_83(base.GetCppThis(), _arg);
		}

		// Token: 0x060024A5 RID: 9381
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_SetBackground_84(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the background color of the rendering screen using an rgb color
		/// specification.
		/// </summary>
		// Token: 0x060024A6 RID: 9382 RVA: 0x00036D7C File Offset: 0x00034F7C
		public virtual void SetBackground(double _arg1, double _arg2, double _arg3)
		{
			vtkViewport.vtkViewport_SetBackground_84(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060024A7 RID: 9383
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_SetBackground_85(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the background color of the rendering screen using an rgb color
		/// specification.
		/// </summary>
		// Token: 0x060024A8 RID: 9384 RVA: 0x00036D8E File Offset: 0x00034F8E
		public virtual void SetBackground(IntPtr _arg)
		{
			vtkViewport.vtkViewport_SetBackground_85(base.GetCppThis(), _arg);
		}

		// Token: 0x060024A9 RID: 9385
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_SetBackground2_86(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the second background color of the rendering screen
		/// for gradient backgrounds using an rgb color specification.
		/// </summary>
		// Token: 0x060024AA RID: 9386 RVA: 0x00036D9E File Offset: 0x00034F9E
		public virtual void SetBackground2(double _arg1, double _arg2, double _arg3)
		{
			vtkViewport.vtkViewport_SetBackground2_86(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060024AB RID: 9387
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_SetBackground2_87(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the second background color of the rendering screen
		/// for gradient backgrounds using an rgb color specification.
		/// </summary>
		// Token: 0x060024AC RID: 9388 RVA: 0x00036DB0 File Offset: 0x00034FB0
		public virtual void SetBackground2(IntPtr _arg)
		{
			vtkViewport.vtkViewport_SetBackground2_87(base.GetCppThis(), _arg);
		}

		// Token: 0x060024AD RID: 9389
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_SetBackgroundAlpha_88(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the alpha value used to fill the background with.
		/// By default, this is set to 0.0.
		/// </summary>
		// Token: 0x060024AE RID: 9390 RVA: 0x00036DC0 File Offset: 0x00034FC0
		public virtual void SetBackgroundAlpha(double _arg)
		{
			vtkViewport.vtkViewport_SetBackgroundAlpha_88(base.GetCppThis(), _arg);
		}

		// Token: 0x060024AF RID: 9391
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_SetDisplayPoint_89(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/get a point location in display (or screen) coordinates.
		/// The lower left corner of the window is the origin and y increases
		/// as you go up the screen.
		/// </summary>
		// Token: 0x060024B0 RID: 9392 RVA: 0x00036DD0 File Offset: 0x00034FD0
		public virtual void SetDisplayPoint(double _arg1, double _arg2, double _arg3)
		{
			vtkViewport.vtkViewport_SetDisplayPoint_89(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060024B1 RID: 9393
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_SetDisplayPoint_90(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get a point location in display (or screen) coordinates.
		/// The lower left corner of the window is the origin and y increases
		/// as you go up the screen.
		/// </summary>
		// Token: 0x060024B2 RID: 9394 RVA: 0x00036DE2 File Offset: 0x00034FE2
		public virtual void SetDisplayPoint(IntPtr _arg)
		{
			vtkViewport.vtkViewport_SetDisplayPoint_90(base.GetCppThis(), _arg);
		}

		// Token: 0x060024B3 RID: 9395
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_SetEnvironmentalBG_91(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the constant environmental color using an rgb color specification.
		/// Note this is currently ignored outside of RayTracing.
		/// </summary>
		// Token: 0x060024B4 RID: 9396 RVA: 0x00036DF2 File Offset: 0x00034FF2
		public virtual void SetEnvironmentalBG(double _arg1, double _arg2, double _arg3)
		{
			vtkViewport.vtkViewport_SetEnvironmentalBG_91(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060024B5 RID: 9397
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_SetEnvironmentalBG_92(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the constant environmental color using an rgb color specification.
		/// Note this is currently ignored outside of RayTracing.
		/// </summary>
		// Token: 0x060024B6 RID: 9398 RVA: 0x00036E04 File Offset: 0x00035004
		public virtual void SetEnvironmentalBG(IntPtr _arg)
		{
			vtkViewport.vtkViewport_SetEnvironmentalBG_92(base.GetCppThis(), _arg);
		}

		// Token: 0x060024B7 RID: 9399
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_SetEnvironmentalBG2_93(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the second environmental gradient color using an rgb color specification.
		/// Note this is currently ignored outside of RayTracing.
		/// </summary>
		// Token: 0x060024B8 RID: 9400 RVA: 0x00036E14 File Offset: 0x00035014
		public virtual void SetEnvironmentalBG2(double _arg1, double _arg2, double _arg3)
		{
			vtkViewport.vtkViewport_SetEnvironmentalBG2_93(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060024B9 RID: 9401
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_SetEnvironmentalBG2_94(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the second environmental gradient color using an rgb color specification.
		/// Note this is currently ignored outside of RayTracing.
		/// </summary>
		// Token: 0x060024BA RID: 9402 RVA: 0x00036E26 File Offset: 0x00035026
		public virtual void SetEnvironmentalBG2(IntPtr _arg)
		{
			vtkViewport.vtkViewport_SetEnvironmentalBG2_94(base.GetCppThis(), _arg);
		}

		// Token: 0x060024BB RID: 9403
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_SetGradientBackground_95(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get whether this viewport should have a gradient background
		/// using the Background (bottom) and Background2 (top) colors.
		/// Default is off.
		/// </summary>
		// Token: 0x060024BC RID: 9404 RVA: 0x00036E36 File Offset: 0x00035036
		public virtual void SetGradientBackground(bool _arg)
		{
			vtkViewport.vtkViewport_SetGradientBackground_95(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060024BD RID: 9405
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_SetGradientEnvironmentalBG_96(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get whether this viewport should enable the gradient environment
		/// using the EnvironmentalBG (bottom) and EnvironmentalBG2 (top) colors.
		/// Note this is currently ignored outside of RayTracing.
		/// Default is off.
		/// </summary>
		// Token: 0x060024BE RID: 9406 RVA: 0x00036E4E File Offset: 0x0003504E
		public virtual void SetGradientEnvironmentalBG(bool _arg)
		{
			vtkViewport.vtkViewport_SetGradientEnvironmentalBG_96(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060024BF RID: 9407
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_SetGradientMode_97(HandleRef pThis, vtkViewport.GradientModes _arg);

		/// <summary>
		/// Specify the direction of the gradient background.
		/// All modes smoothly interpolate the color from `Background` to `Background2`
		/// @sa vtkViewport::GradientModes
		/// </summary>
		// Token: 0x060024C0 RID: 9408 RVA: 0x00036E66 File Offset: 0x00035066
		public virtual void SetGradientMode(vtkViewport.GradientModes _arg)
		{
			vtkViewport.vtkViewport_SetGradientMode_97(base.GetCppThis(), _arg);
		}

		// Token: 0x060024C1 RID: 9409
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_SetPixelAspect_98(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Set the aspect ratio of a pixel in the rendered image.
		/// This factor permits the image to rendered anisotropically
		/// (i.e., stretched in one direction or the other).
		/// </summary>
		// Token: 0x060024C2 RID: 9410 RVA: 0x00036E76 File Offset: 0x00035076
		public virtual void SetPixelAspect(double _arg1, double _arg2)
		{
			vtkViewport.vtkViewport_SetPixelAspect_98(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x060024C3 RID: 9411
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_SetPixelAspect_99(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the aspect ratio of a pixel in the rendered image.
		/// This factor permits the image to rendered anisotropically
		/// (i.e., stretched in one direction or the other).
		/// </summary>
		// Token: 0x060024C4 RID: 9412 RVA: 0x00036E87 File Offset: 0x00035087
		public void SetPixelAspect(IntPtr _arg)
		{
			vtkViewport.vtkViewport_SetPixelAspect_99(base.GetCppThis(), _arg);
		}

		// Token: 0x060024C5 RID: 9413
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_SetViewPoint_100(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Specify a point location in view coordinates. The origin is in the
		/// middle of the viewport and it extends from -1 to 1 in all three
		/// dimensions.
		/// </summary>
		// Token: 0x060024C6 RID: 9414 RVA: 0x00036E97 File Offset: 0x00035097
		public virtual void SetViewPoint(double _arg1, double _arg2, double _arg3)
		{
			vtkViewport.vtkViewport_SetViewPoint_100(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060024C7 RID: 9415
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_SetViewPoint_101(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify a point location in view coordinates. The origin is in the
		/// middle of the viewport and it extends from -1 to 1 in all three
		/// dimensions.
		/// </summary>
		// Token: 0x060024C8 RID: 9416 RVA: 0x00036EA9 File Offset: 0x000350A9
		public virtual void SetViewPoint(IntPtr _arg)
		{
			vtkViewport.vtkViewport_SetViewPoint_101(base.GetCppThis(), _arg);
		}

		// Token: 0x060024C9 RID: 9417
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_SetViewport_102(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		/// <summary>
		/// Specify the viewport for the Viewport to draw in the rendering window.
		/// Coordinates are expressed as (xmin,ymin,xmax,ymax), where each
		/// coordinate is 0 &lt;= coordinate &lt;= 1.0.
		/// </summary>
		// Token: 0x060024CA RID: 9418 RVA: 0x00036EB9 File Offset: 0x000350B9
		public virtual void SetViewport(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkViewport.vtkViewport_SetViewport_102(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x060024CB RID: 9419
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_SetViewport_103(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the viewport for the Viewport to draw in the rendering window.
		/// Coordinates are expressed as (xmin,ymin,xmax,ymax), where each
		/// coordinate is 0 &lt;= coordinate &lt;= 1.0.
		/// </summary>
		// Token: 0x060024CC RID: 9420 RVA: 0x00036ECD File Offset: 0x000350CD
		public virtual void SetViewport(IntPtr _arg)
		{
			vtkViewport.vtkViewport_SetViewport_103(base.GetCppThis(), _arg);
		}

		// Token: 0x060024CD RID: 9421
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_SetWorldPoint_104(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		/// <summary>
		/// Specify a point location in world coordinates. This method takes
		/// homogeneous coordinates.
		/// </summary>
		// Token: 0x060024CE RID: 9422 RVA: 0x00036EDD File Offset: 0x000350DD
		public virtual void SetWorldPoint(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkViewport.vtkViewport_SetWorldPoint_104(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x060024CF RID: 9423
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_SetWorldPoint_105(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify a point location in world coordinates. This method takes
		/// homogeneous coordinates.
		/// </summary>
		// Token: 0x060024D0 RID: 9424 RVA: 0x00036EF1 File Offset: 0x000350F1
		public virtual void SetWorldPoint(IntPtr _arg)
		{
			vtkViewport.vtkViewport_SetWorldPoint_105(base.GetCppThis(), _arg);
		}

		// Token: 0x060024D1 RID: 9425
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_ViewToDisplay_106(HandleRef pThis, ref double x, ref double y, ref double z);

		/// <summary>
		/// These methods map from one coordinate system to another.
		/// They are primarily used by the vtkCoordinate object and
		/// are often strung together. These methods return valid information
		/// only if the window has been realized (e.g., GetSize() returns
		/// something other than (0,0)).
		/// </summary>
		// Token: 0x060024D2 RID: 9426 RVA: 0x00036F01 File Offset: 0x00035101
		public virtual void ViewToDisplay(ref double x, ref double y, ref double z)
		{
			vtkViewport.vtkViewport_ViewToDisplay_106(base.GetCppThis(), ref x, ref y, ref z);
		}

		// Token: 0x060024D3 RID: 9427
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_ViewToDisplay_107(HandleRef pThis);

		/// <summary>
		/// Convert view coordinates to display coordinates.
		/// </summary>
		// Token: 0x060024D4 RID: 9428 RVA: 0x00036F13 File Offset: 0x00035113
		public virtual void ViewToDisplay()
		{
			vtkViewport.vtkViewport_ViewToDisplay_107(base.GetCppThis());
		}

		// Token: 0x060024D5 RID: 9429
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_ViewToNormalizedViewport_108(HandleRef pThis, ref double x, ref double y, ref double z);

		/// <summary>
		/// These methods map from one coordinate system to another.
		/// They are primarily used by the vtkCoordinate object and
		/// are often strung together. These methods return valid information
		/// only if the window has been realized (e.g., GetSize() returns
		/// something other than (0,0)).
		/// </summary>
		// Token: 0x060024D6 RID: 9430 RVA: 0x00036F22 File Offset: 0x00035122
		public virtual void ViewToNormalizedViewport(ref double x, ref double y, ref double z)
		{
			vtkViewport.vtkViewport_ViewToNormalizedViewport_108(base.GetCppThis(), ref x, ref y, ref z);
		}

		// Token: 0x060024D7 RID: 9431
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_ViewToPose_109(HandleRef pThis, ref double arg0, ref double arg1, ref double arg2);

		/// <summary>
		/// These methods map from one coordinate system to another.
		/// They are primarily used by the vtkCoordinate object and
		/// are often strung together. These methods return valid information
		/// only if the window has been realized (e.g., GetSize() returns
		/// something other than (0,0)).
		/// </summary>
		// Token: 0x060024D8 RID: 9432 RVA: 0x00036F34 File Offset: 0x00035134
		public virtual void ViewToPose(ref double arg0, ref double arg1, ref double arg2)
		{
			vtkViewport.vtkViewport_ViewToPose_109(base.GetCppThis(), ref arg0, ref arg1, ref arg2);
		}

		// Token: 0x060024D9 RID: 9433
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_ViewToWorld_110(HandleRef pThis);

		/// <summary>
		/// Convert view point coordinates to world coordinates.
		/// </summary>
		// Token: 0x060024DA RID: 9434 RVA: 0x00036F46 File Offset: 0x00035146
		public virtual void ViewToWorld()
		{
			vtkViewport.vtkViewport_ViewToWorld_110(base.GetCppThis());
		}

		// Token: 0x060024DB RID: 9435
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_ViewToWorld_111(HandleRef pThis, ref double arg0, ref double arg1, ref double arg2);

		/// <summary>
		/// These methods map from one coordinate system to another.
		/// They are primarily used by the vtkCoordinate object and
		/// are often strung together. These methods return valid information
		/// only if the window has been realized (e.g., GetSize() returns
		/// something other than (0,0)).
		/// </summary>
		// Token: 0x060024DC RID: 9436 RVA: 0x00036F55 File Offset: 0x00035155
		public virtual void ViewToWorld(ref double arg0, ref double arg1, ref double arg2)
		{
			vtkViewport.vtkViewport_ViewToWorld_111(base.GetCppThis(), ref arg0, ref arg1, ref arg2);
		}

		// Token: 0x060024DD RID: 9437
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_ViewportToNormalizedDisplay_112(HandleRef pThis, ref double x, ref double y);

		/// <summary>
		/// These methods map from one coordinate system to another.
		/// They are primarily used by the vtkCoordinate object and
		/// are often strung together. These methods return valid information
		/// only if the window has been realized (e.g., GetSize() returns
		/// something other than (0,0)).
		/// </summary>
		// Token: 0x060024DE RID: 9438 RVA: 0x00036F67 File Offset: 0x00035167
		public virtual void ViewportToNormalizedDisplay(ref double x, ref double y)
		{
			vtkViewport.vtkViewport_ViewportToNormalizedDisplay_112(base.GetCppThis(), ref x, ref y);
		}

		// Token: 0x060024DF RID: 9439
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_ViewportToNormalizedViewport_113(HandleRef pThis, ref double u, ref double v);

		/// <summary>
		/// These methods map from one coordinate system to another.
		/// They are primarily used by the vtkCoordinate object and
		/// are often strung together. These methods return valid information
		/// only if the window has been realized (e.g., GetSize() returns
		/// something other than (0,0)).
		/// </summary>
		// Token: 0x060024E0 RID: 9440 RVA: 0x00036F78 File Offset: 0x00035178
		public virtual void ViewportToNormalizedViewport(ref double u, ref double v)
		{
			vtkViewport.vtkViewport_ViewportToNormalizedViewport_113(base.GetCppThis(), ref u, ref v);
		}

		// Token: 0x060024E1 RID: 9441
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_WorldToDisplay_114(HandleRef pThis);

		/// <summary>
		/// Convert world point coordinates to display (or screen) coordinates.
		/// </summary>
		// Token: 0x060024E2 RID: 9442 RVA: 0x00036F89 File Offset: 0x00035189
		public void WorldToDisplay()
		{
			vtkViewport.vtkViewport_WorldToDisplay_114(base.GetCppThis());
		}

		// Token: 0x060024E3 RID: 9443
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_WorldToDisplay_115(HandleRef pThis, ref double x, ref double y, ref double z);

		/// <summary>
		/// Convert world point coordinates to display (or screen) coordinates.
		/// </summary>
		// Token: 0x060024E4 RID: 9444 RVA: 0x00036F98 File Offset: 0x00035198
		public void WorldToDisplay(ref double x, ref double y, ref double z)
		{
			vtkViewport.vtkViewport_WorldToDisplay_115(base.GetCppThis(), ref x, ref y, ref z);
		}

		// Token: 0x060024E5 RID: 9445
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_WorldToPose_116(HandleRef pThis, ref double arg0, ref double arg1, ref double arg2);

		/// <summary>
		/// These methods map from one coordinate system to another.
		/// They are primarily used by the vtkCoordinate object and
		/// are often strung together. These methods return valid information
		/// only if the window has been realized (e.g., GetSize() returns
		/// something other than (0,0)).
		/// </summary>
		// Token: 0x060024E6 RID: 9446 RVA: 0x00036FAA File Offset: 0x000351AA
		public virtual void WorldToPose(ref double arg0, ref double arg1, ref double arg2)
		{
			vtkViewport.vtkViewport_WorldToPose_116(base.GetCppThis(), ref arg0, ref arg1, ref arg2);
		}

		// Token: 0x060024E7 RID: 9447
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_WorldToView_117(HandleRef pThis, ref double arg0, ref double arg1, ref double arg2);

		/// <summary>
		/// These methods map from one coordinate system to another.
		/// They are primarily used by the vtkCoordinate object and
		/// are often strung together. These methods return valid information
		/// only if the window has been realized (e.g., GetSize() returns
		/// something other than (0,0)).
		/// </summary>
		// Token: 0x060024E8 RID: 9448 RVA: 0x00036FBC File Offset: 0x000351BC
		public virtual void WorldToView(ref double arg0, ref double arg1, ref double arg2)
		{
			vtkViewport.vtkViewport_WorldToView_117(base.GetCppThis(), ref arg0, ref arg1, ref arg2);
		}

		// Token: 0x060024E9 RID: 9449
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkViewport_WorldToView_118(HandleRef pThis);

		/// <summary>
		/// Convert world point coordinates to view coordinates.
		/// </summary>
		// Token: 0x060024EA RID: 9450 RVA: 0x00036FCE File Offset: 0x000351CE
		public virtual void WorldToView()
		{
			vtkViewport.vtkViewport_WorldToView_118(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000537 RID: 1335
		public new const string MRFullTypeName = "Kitware.VTK.vtkViewport";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000538 RID: 1336
		public new static readonly string MRClassNameKey = "class vtkViewport";

		/// <summary>
		/// Set/Get whether this viewport should have a gradient background
		/// using the Background (bottom) and Background2 (top) colors.
		/// Default is off.
		/// </summary>
		// Token: 0x020000AB RID: 171
		public enum GradientModes
		{
			/// <summary>enum member</summary>
			// Token: 0x0400053A RID: 1338
			VTK_GRADIENT_HORIZONTAL = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400053B RID: 1339
			VTK_GRADIENT_RADIAL_VIEWPORT_FARTHEST_CORNER = 3,
			/// <summary>enum member</summary>
			// Token: 0x0400053C RID: 1340
			VTK_GRADIENT_RADIAL_VIEWPORT_FARTHEST_SIDE = 2,
			/// <summary>enum member</summary>
			// Token: 0x0400053D RID: 1341
			VTK_GRADIENT_VERTICAL = 0
		}
	}
}
