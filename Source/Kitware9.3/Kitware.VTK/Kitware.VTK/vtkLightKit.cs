using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLightKit
	/// </summary>
	/// <remarks>
	///    a simple but quality lighting kit
	///
	/// vtkLightKit is designed to make general purpose lighting of vtk
	/// scenes simple, flexible, and attractive (or at least not horribly
	/// ugly without significant effort).  Use a LightKit when you want
	/// more control over your lighting than you can get with the default
	/// vtk light, which is a headlight located at the camera. (HeadLights
	/// are very simple to use, but they don't show the shape of objects very
	/// well, don't give a good sense of "up" and "down", and don't evenly
	/// light the object.)
	///
	/// A LightKit consists of three lights, a key light, a fill light, and
	/// a headlight.  The main light is the key light.  It is usually
	/// positioned so that it appears like an overhead light (like the sun,
	/// or a ceiling light).  It is generally positioned to shine down on the
	/// scene from about a 45 degree angle vertically and at least a little
	/// offset side to side.  The key light usually at least about twice as
	/// bright as the total of all other lights in the scene to provide good
	/// modeling of object features.
	///
	/// The other lights in the kit (the fill light, headlight, and a pair of
	/// back lights) are weaker sources that provide extra
	/// illumination to fill in the spots that the key light misses.  The
	/// fill light is usually positioned across from or opposite from the
	/// key light (though still on the same side of the object as the
	/// camera) in order to simulate diffuse reflections from other objects
	/// in the scene.  The headlight, always located at the position of the
	/// camera, reduces the contrast between areas lit by the key and fill
	/// light. The two back lights, one on the left of the object as seen
	/// from the observer and one on the right, fill on the high-contrast
	/// areas behind the object.  To enforce the relationship between the
	/// different lights, the intensity of the fill, back and headlights
	/// are set as a ratio to the key light brightness.  Thus, the
	/// brightness of all the lights in the scene can be changed by
	/// changing the key light intensity.
	///
	/// All lights are directional lights (infinitely far away with no
	/// falloff).  Lights move with the camera.
	///
	/// For simplicity, the position of lights in the LightKit can only be
	/// specified using angles: the elevation (latitude) and azimuth
	/// (longitude) of each light with respect to the camera, expressed in
	/// degrees.  (Lights always shine on the camera's lookat point.) For
	/// example, a light at (elevation=0, azimuth=0) is located at the
	/// camera (a headlight).  A light at (elevation=90, azimuth=0) is
	/// above the lookat point, shining down.  Negative azimuth values move
	/// the lights clockwise as seen above, positive values
	/// counter-clockwise.  So, a light at (elevation=45, azimuth=-20) is
	/// above and in front of the object and shining slightly from the left
	/// side.
	///
	/// vtkLightKit limits the colors that can be assigned to any light to
	/// those of incandescent sources such as light bulbs and sunlight.  It
	/// defines a special color spectrum called "warmth" from which light
	/// colors can be chosen, where 0 is cold blue, 0.5 is neutral white,
	/// and 1 is deep sunset red.  Colors close to 0.5 are "cool whites" and
	/// "warm whites," respectively.
	///
	/// Since colors far from white on the warmth scale appear less bright,
	/// key-to-fill and key-to-headlight ratios are skewed by
	/// key, fill, and headlight colors.  If the flag MaintainLuminance
	/// is set, vtkLightKit will attempt to compensate for these perceptual
	/// differences by increasing the brightness of more saturated colors.
	///
	/// A LightKit is not explicitly part of the vtk pipeline.  Rather, it
	/// is a composite object that controls the behavior of lights using a
	/// unified user interface.  Every time a parameter of vtkLightKit is
	/// adjusted, the properties of its lights are modified.
	///
	/// @par Credits:
	/// vtkLightKit was originally written and contributed to vtk by
	/// Michael Halle (mhalle@bwh.harvard.edu) at the Surgical Planning
	/// Lab, Brigham and Women's Hospital.
	/// </remarks>
	// Token: 0x020007EE RID: 2030
	public class vtkLightKit : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014DEE RID: 85486 RVA: 0x001D8777 File Offset: 0x001D6977
		static vtkLightKit()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLightKit.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLightKit"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014DEF RID: 85487 RVA: 0x001D879F File Offset: 0x001D699F
		public vtkLightKit(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014DF0 RID: 85488
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightKit_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014DF1 RID: 85489 RVA: 0x001D87B0 File Offset: 0x001D69B0
		public new static vtkLightKit New()
		{
			vtkLightKit result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightKit.vtkLightKit_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLightKit)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014DF2 RID: 85490 RVA: 0x001D8804 File Offset: 0x001D6A04
		public vtkLightKit() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLightKit.vtkLightKit_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014DF3 RID: 85491 RVA: 0x001D8848 File Offset: 0x001D6A48
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014DF4 RID: 85492
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_AddLightsToRenderer_01(HandleRef pThis, HandleRef renderer);

		/// <summary>
		/// Add lights to, or remove lights from, a renderer.
		/// Lights may be added to more than one renderer, if desired.
		/// </summary>
		// Token: 0x06014DF5 RID: 85493 RVA: 0x001D8854 File Offset: 0x001D6A54
		public void AddLightsToRenderer(vtkRenderer renderer)
		{
			vtkLightKit.vtkLightKit_AddLightsToRenderer_01(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		// Token: 0x06014DF6 RID: 85494
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_DeepCopy_02(HandleRef pThis, HandleRef kit);

		/// <summary>
		/// Add lights to, or remove lights from, a renderer.
		/// Lights may be added to more than one renderer, if desired.
		/// </summary>
		// Token: 0x06014DF7 RID: 85495 RVA: 0x001D8884 File Offset: 0x001D6A84
		public void DeepCopy(vtkLightKit kit)
		{
			vtkLightKit.vtkLightKit_DeepCopy_02(base.GetCppThis(), (kit == null) ? default(HandleRef) : kit.GetCppThis());
		}

		// Token: 0x06014DF8 RID: 85496
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightKit_GetBackLightAngle_03(HandleRef pThis);

		/// <summary>
		/// Get/Set the position of the key, fill, and back lights
		/// using angular methods.  Elevation corresponds to latitude,
		/// azimuth to longitude.  It is recommended that the key light
		/// always be on the viewer's side of the object and above the
		/// object, while the fill light generally lights the part of the object
		/// not lit by the fill light.  The headlight, which is always located
		/// at the viewer, can then be used to reduce the contrast in the image.
		/// There are a pair of back lights.  They are located at the same
		/// elevation and at opposing azimuths (ie, one to the left, and one to
		/// the right).  They are generally set at the equator (elevation = 0),
		/// and at approximately 120 degrees (lighting from each side and behind).
		/// </summary>
		// Token: 0x06014DF9 RID: 85497 RVA: 0x001D88B4 File Offset: 0x001D6AB4
		public virtual double[] GetBackLightAngle()
		{
			IntPtr intPtr = vtkLightKit.vtkLightKit_GetBackLightAngle_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014DFA RID: 85498
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_GetBackLightAngle_04(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Get/Set the position of the key, fill, and back lights
		/// using angular methods.  Elevation corresponds to latitude,
		/// azimuth to longitude.  It is recommended that the key light
		/// always be on the viewer's side of the object and above the
		/// object, while the fill light generally lights the part of the object
		/// not lit by the fill light.  The headlight, which is always located
		/// at the viewer, can then be used to reduce the contrast in the image.
		/// There are a pair of back lights.  They are located at the same
		/// elevation and at opposing azimuths (ie, one to the left, and one to
		/// the right).  They are generally set at the equator (elevation = 0),
		/// and at approximately 120 degrees (lighting from each side and behind).
		/// </summary>
		// Token: 0x06014DFB RID: 85499 RVA: 0x001D88FC File Offset: 0x001D6AFC
		public virtual void GetBackLightAngle(IntPtr data)
		{
			vtkLightKit.vtkLightKit_GetBackLightAngle_04(base.GetCppThis(), data);
		}

		// Token: 0x06014DFC RID: 85500
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLightKit_GetBackLightAzimuth_05(HandleRef pThis);

		/// <summary>
		/// Get/Set the position of the key, fill, and back lights
		/// using angular methods.  Elevation corresponds to latitude,
		/// azimuth to longitude.  It is recommended that the key light
		/// always be on the viewer's side of the object and above the
		/// object, while the fill light generally lights the part of the object
		/// not lit by the fill light.  The headlight, which is always located
		/// at the viewer, can then be used to reduce the contrast in the image.
		/// There are a pair of back lights.  They are located at the same
		/// elevation and at opposing azimuths (ie, one to the left, and one to
		/// the right).  They are generally set at the equator (elevation = 0),
		/// and at approximately 120 degrees (lighting from each side and behind).
		/// </summary>
		// Token: 0x06014DFD RID: 85501 RVA: 0x001D890C File Offset: 0x001D6B0C
		public double GetBackLightAzimuth()
		{
			return vtkLightKit.vtkLightKit_GetBackLightAzimuth_05(base.GetCppThis());
		}

		// Token: 0x06014DFE RID: 85502
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightKit_GetBackLightColor_06(HandleRef pThis);

		/// <summary>
		/// Returns the floating-point RGB values of each of the light's color.
		/// </summary>
		// Token: 0x06014DFF RID: 85503 RVA: 0x001D892C File Offset: 0x001D6B2C
		public virtual double[] GetBackLightColor()
		{
			IntPtr intPtr = vtkLightKit.vtkLightKit_GetBackLightColor_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014E00 RID: 85504
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_GetBackLightColor_07(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Returns the floating-point RGB values of each of the light's color.
		/// </summary>
		// Token: 0x06014E01 RID: 85505 RVA: 0x001D8974 File Offset: 0x001D6B74
		public virtual void GetBackLightColor(IntPtr data)
		{
			vtkLightKit.vtkLightKit_GetBackLightColor_07(base.GetCppThis(), data);
		}

		// Token: 0x06014E02 RID: 85506
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLightKit_GetBackLightElevation_08(HandleRef pThis);

		/// <summary>
		/// Get/Set the position of the key, fill, and back lights
		/// using angular methods.  Elevation corresponds to latitude,
		/// azimuth to longitude.  It is recommended that the key light
		/// always be on the viewer's side of the object and above the
		/// object, while the fill light generally lights the part of the object
		/// not lit by the fill light.  The headlight, which is always located
		/// at the viewer, can then be used to reduce the contrast in the image.
		/// There are a pair of back lights.  They are located at the same
		/// elevation and at opposing azimuths (ie, one to the left, and one to
		/// the right).  They are generally set at the equator (elevation = 0),
		/// and at approximately 120 degrees (lighting from each side and behind).
		/// </summary>
		// Token: 0x06014E03 RID: 85507 RVA: 0x001D8984 File Offset: 0x001D6B84
		public double GetBackLightElevation()
		{
			return vtkLightKit.vtkLightKit_GetBackLightElevation_08(base.GetCppThis());
		}

		// Token: 0x06014E04 RID: 85508
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLightKit_GetBackLightWarmth_09(HandleRef pThis);

		/// <summary>
		/// Set the warmth of each the lights.  Warmth is a parameter that
		/// varies from 0 to 1, where 0 is "cold" (looks icy or lit by a very
		/// blue sky), 1 is "warm" (the red of a very red sunset, or the
		/// embers of a campfire), and 0.5 is a neutral white.  The warmth
		/// scale is non-linear. Warmth values close to 0.5 are subtly
		/// "warmer" or "cooler," much like a warmer tungsten incandescent
		/// bulb, a cooler halogen, or daylight (cooler still).  Moving
		/// further away from 0.5, colors become more quickly varying towards
		/// blues and reds.  With regards to aesthetics, extremes of warmth
		/// should be used sparingly.
		/// </summary>
		// Token: 0x06014E05 RID: 85509 RVA: 0x001D89A4 File Offset: 0x001D6BA4
		public virtual double GetBackLightWarmth()
		{
			return vtkLightKit.vtkLightKit_GetBackLightWarmth_09(base.GetCppThis());
		}

		// Token: 0x06014E06 RID: 85510
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightKit_GetFillLightAngle_10(HandleRef pThis);

		/// <summary>
		/// Get/Set the position of the key, fill, and back lights
		/// using angular methods.  Elevation corresponds to latitude,
		/// azimuth to longitude.  It is recommended that the key light
		/// always be on the viewer's side of the object and above the
		/// object, while the fill light generally lights the part of the object
		/// not lit by the fill light.  The headlight, which is always located
		/// at the viewer, can then be used to reduce the contrast in the image.
		/// There are a pair of back lights.  They are located at the same
		/// elevation and at opposing azimuths (ie, one to the left, and one to
		/// the right).  They are generally set at the equator (elevation = 0),
		/// and at approximately 120 degrees (lighting from each side and behind).
		/// </summary>
		// Token: 0x06014E07 RID: 85511 RVA: 0x001D89C4 File Offset: 0x001D6BC4
		public virtual double[] GetFillLightAngle()
		{
			IntPtr intPtr = vtkLightKit.vtkLightKit_GetFillLightAngle_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014E08 RID: 85512
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_GetFillLightAngle_11(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Get/Set the position of the key, fill, and back lights
		/// using angular methods.  Elevation corresponds to latitude,
		/// azimuth to longitude.  It is recommended that the key light
		/// always be on the viewer's side of the object and above the
		/// object, while the fill light generally lights the part of the object
		/// not lit by the fill light.  The headlight, which is always located
		/// at the viewer, can then be used to reduce the contrast in the image.
		/// There are a pair of back lights.  They are located at the same
		/// elevation and at opposing azimuths (ie, one to the left, and one to
		/// the right).  They are generally set at the equator (elevation = 0),
		/// and at approximately 120 degrees (lighting from each side and behind).
		/// </summary>
		// Token: 0x06014E09 RID: 85513 RVA: 0x001D8A0C File Offset: 0x001D6C0C
		public virtual void GetFillLightAngle(IntPtr data)
		{
			vtkLightKit.vtkLightKit_GetFillLightAngle_11(base.GetCppThis(), data);
		}

		// Token: 0x06014E0A RID: 85514
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLightKit_GetFillLightAzimuth_12(HandleRef pThis);

		/// <summary>
		/// Get/Set the position of the key, fill, and back lights
		/// using angular methods.  Elevation corresponds to latitude,
		/// azimuth to longitude.  It is recommended that the key light
		/// always be on the viewer's side of the object and above the
		/// object, while the fill light generally lights the part of the object
		/// not lit by the fill light.  The headlight, which is always located
		/// at the viewer, can then be used to reduce the contrast in the image.
		/// There are a pair of back lights.  They are located at the same
		/// elevation and at opposing azimuths (ie, one to the left, and one to
		/// the right).  They are generally set at the equator (elevation = 0),
		/// and at approximately 120 degrees (lighting from each side and behind).
		/// </summary>
		// Token: 0x06014E0B RID: 85515 RVA: 0x001D8A1C File Offset: 0x001D6C1C
		public double GetFillLightAzimuth()
		{
			return vtkLightKit.vtkLightKit_GetFillLightAzimuth_12(base.GetCppThis());
		}

		// Token: 0x06014E0C RID: 85516
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightKit_GetFillLightColor_13(HandleRef pThis);

		/// <summary>
		/// Returns the floating-point RGB values of each of the light's color.
		/// </summary>
		// Token: 0x06014E0D RID: 85517 RVA: 0x001D8A3C File Offset: 0x001D6C3C
		public virtual double[] GetFillLightColor()
		{
			IntPtr intPtr = vtkLightKit.vtkLightKit_GetFillLightColor_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014E0E RID: 85518
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_GetFillLightColor_14(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Returns the floating-point RGB values of each of the light's color.
		/// </summary>
		// Token: 0x06014E0F RID: 85519 RVA: 0x001D8A84 File Offset: 0x001D6C84
		public virtual void GetFillLightColor(IntPtr data)
		{
			vtkLightKit.vtkLightKit_GetFillLightColor_14(base.GetCppThis(), data);
		}

		// Token: 0x06014E10 RID: 85520
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLightKit_GetFillLightElevation_15(HandleRef pThis);

		/// <summary>
		/// Get/Set the position of the key, fill, and back lights
		/// using angular methods.  Elevation corresponds to latitude,
		/// azimuth to longitude.  It is recommended that the key light
		/// always be on the viewer's side of the object and above the
		/// object, while the fill light generally lights the part of the object
		/// not lit by the fill light.  The headlight, which is always located
		/// at the viewer, can then be used to reduce the contrast in the image.
		/// There are a pair of back lights.  They are located at the same
		/// elevation and at opposing azimuths (ie, one to the left, and one to
		/// the right).  They are generally set at the equator (elevation = 0),
		/// and at approximately 120 degrees (lighting from each side and behind).
		/// </summary>
		// Token: 0x06014E11 RID: 85521 RVA: 0x001D8A94 File Offset: 0x001D6C94
		public double GetFillLightElevation()
		{
			return vtkLightKit.vtkLightKit_GetFillLightElevation_15(base.GetCppThis());
		}

		// Token: 0x06014E12 RID: 85522
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLightKit_GetFillLightWarmth_16(HandleRef pThis);

		/// <summary>
		/// Set the warmth of each the lights.  Warmth is a parameter that
		/// varies from 0 to 1, where 0 is "cold" (looks icy or lit by a very
		/// blue sky), 1 is "warm" (the red of a very red sunset, or the
		/// embers of a campfire), and 0.5 is a neutral white.  The warmth
		/// scale is non-linear. Warmth values close to 0.5 are subtly
		/// "warmer" or "cooler," much like a warmer tungsten incandescent
		/// bulb, a cooler halogen, or daylight (cooler still).  Moving
		/// further away from 0.5, colors become more quickly varying towards
		/// blues and reds.  With regards to aesthetics, extremes of warmth
		/// should be used sparingly.
		/// </summary>
		// Token: 0x06014E13 RID: 85523 RVA: 0x001D8AB4 File Offset: 0x001D6CB4
		public virtual double GetFillLightWarmth()
		{
			return vtkLightKit.vtkLightKit_GetFillLightWarmth_16(base.GetCppThis());
		}

		// Token: 0x06014E14 RID: 85524
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightKit_GetHeadLightColor_17(HandleRef pThis);

		/// <summary>
		/// Returns the floating-point RGB values of each of the light's color.
		/// </summary>
		// Token: 0x06014E15 RID: 85525 RVA: 0x001D8AD4 File Offset: 0x001D6CD4
		public virtual double[] GetHeadLightColor()
		{
			IntPtr intPtr = vtkLightKit.vtkLightKit_GetHeadLightColor_17(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014E16 RID: 85526
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_GetHeadLightColor_18(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Returns the floating-point RGB values of each of the light's color.
		/// </summary>
		// Token: 0x06014E17 RID: 85527 RVA: 0x001D8B1C File Offset: 0x001D6D1C
		public virtual void GetHeadLightColor(IntPtr data)
		{
			vtkLightKit.vtkLightKit_GetHeadLightColor_18(base.GetCppThis(), data);
		}

		// Token: 0x06014E18 RID: 85528
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLightKit_GetHeadLightWarmth_19(HandleRef pThis);

		/// <summary>
		/// Set the warmth of each the lights.  Warmth is a parameter that
		/// varies from 0 to 1, where 0 is "cold" (looks icy or lit by a very
		/// blue sky), 1 is "warm" (the red of a very red sunset, or the
		/// embers of a campfire), and 0.5 is a neutral white.  The warmth
		/// scale is non-linear. Warmth values close to 0.5 are subtly
		/// "warmer" or "cooler," much like a warmer tungsten incandescent
		/// bulb, a cooler halogen, or daylight (cooler still).  Moving
		/// further away from 0.5, colors become more quickly varying towards
		/// blues and reds.  With regards to aesthetics, extremes of warmth
		/// should be used sparingly.
		/// </summary>
		// Token: 0x06014E19 RID: 85529 RVA: 0x001D8B2C File Offset: 0x001D6D2C
		public virtual double GetHeadLightWarmth()
		{
			return vtkLightKit.vtkLightKit_GetHeadLightWarmth_19(base.GetCppThis());
		}

		// Token: 0x06014E1A RID: 85530
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightKit_GetKeyLightAngle_20(HandleRef pThis);

		/// <summary>
		/// Get/Set the position of the key, fill, and back lights
		/// using angular methods.  Elevation corresponds to latitude,
		/// azimuth to longitude.  It is recommended that the key light
		/// always be on the viewer's side of the object and above the
		/// object, while the fill light generally lights the part of the object
		/// not lit by the fill light.  The headlight, which is always located
		/// at the viewer, can then be used to reduce the contrast in the image.
		/// There are a pair of back lights.  They are located at the same
		/// elevation and at opposing azimuths (ie, one to the left, and one to
		/// the right).  They are generally set at the equator (elevation = 0),
		/// and at approximately 120 degrees (lighting from each side and behind).
		/// </summary>
		// Token: 0x06014E1B RID: 85531 RVA: 0x001D8B4C File Offset: 0x001D6D4C
		public virtual double[] GetKeyLightAngle()
		{
			IntPtr intPtr = vtkLightKit.vtkLightKit_GetKeyLightAngle_20(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014E1C RID: 85532
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_GetKeyLightAngle_21(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Get/Set the position of the key, fill, and back lights
		/// using angular methods.  Elevation corresponds to latitude,
		/// azimuth to longitude.  It is recommended that the key light
		/// always be on the viewer's side of the object and above the
		/// object, while the fill light generally lights the part of the object
		/// not lit by the fill light.  The headlight, which is always located
		/// at the viewer, can then be used to reduce the contrast in the image.
		/// There are a pair of back lights.  They are located at the same
		/// elevation and at opposing azimuths (ie, one to the left, and one to
		/// the right).  They are generally set at the equator (elevation = 0),
		/// and at approximately 120 degrees (lighting from each side and behind).
		/// </summary>
		// Token: 0x06014E1D RID: 85533 RVA: 0x001D8B94 File Offset: 0x001D6D94
		public virtual void GetKeyLightAngle(IntPtr data)
		{
			vtkLightKit.vtkLightKit_GetKeyLightAngle_21(base.GetCppThis(), data);
		}

		// Token: 0x06014E1E RID: 85534
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLightKit_GetKeyLightAzimuth_22(HandleRef pThis);

		/// <summary>
		/// Get/Set the position of the key, fill, and back lights
		/// using angular methods.  Elevation corresponds to latitude,
		/// azimuth to longitude.  It is recommended that the key light
		/// always be on the viewer's side of the object and above the
		/// object, while the fill light generally lights the part of the object
		/// not lit by the fill light.  The headlight, which is always located
		/// at the viewer, can then be used to reduce the contrast in the image.
		/// There are a pair of back lights.  They are located at the same
		/// elevation and at opposing azimuths (ie, one to the left, and one to
		/// the right).  They are generally set at the equator (elevation = 0),
		/// and at approximately 120 degrees (lighting from each side and behind).
		/// </summary>
		// Token: 0x06014E1F RID: 85535 RVA: 0x001D8BA4 File Offset: 0x001D6DA4
		public double GetKeyLightAzimuth()
		{
			return vtkLightKit.vtkLightKit_GetKeyLightAzimuth_22(base.GetCppThis());
		}

		// Token: 0x06014E20 RID: 85536
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightKit_GetKeyLightColor_23(HandleRef pThis);

		/// <summary>
		/// Returns the floating-point RGB values of each of the light's color.
		/// </summary>
		// Token: 0x06014E21 RID: 85537 RVA: 0x001D8BC4 File Offset: 0x001D6DC4
		public virtual double[] GetKeyLightColor()
		{
			IntPtr intPtr = vtkLightKit.vtkLightKit_GetKeyLightColor_23(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014E22 RID: 85538
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_GetKeyLightColor_24(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Returns the floating-point RGB values of each of the light's color.
		/// </summary>
		// Token: 0x06014E23 RID: 85539 RVA: 0x001D8C0C File Offset: 0x001D6E0C
		public virtual void GetKeyLightColor(IntPtr data)
		{
			vtkLightKit.vtkLightKit_GetKeyLightColor_24(base.GetCppThis(), data);
		}

		// Token: 0x06014E24 RID: 85540
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLightKit_GetKeyLightElevation_25(HandleRef pThis);

		/// <summary>
		/// Get/Set the position of the key, fill, and back lights
		/// using angular methods.  Elevation corresponds to latitude,
		/// azimuth to longitude.  It is recommended that the key light
		/// always be on the viewer's side of the object and above the
		/// object, while the fill light generally lights the part of the object
		/// not lit by the fill light.  The headlight, which is always located
		/// at the viewer, can then be used to reduce the contrast in the image.
		/// There are a pair of back lights.  They are located at the same
		/// elevation and at opposing azimuths (ie, one to the left, and one to
		/// the right).  They are generally set at the equator (elevation = 0),
		/// and at approximately 120 degrees (lighting from each side and behind).
		/// </summary>
		// Token: 0x06014E25 RID: 85541 RVA: 0x001D8C1C File Offset: 0x001D6E1C
		public double GetKeyLightElevation()
		{
			return vtkLightKit.vtkLightKit_GetKeyLightElevation_25(base.GetCppThis());
		}

		// Token: 0x06014E26 RID: 85542
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLightKit_GetKeyLightIntensity_26(HandleRef pThis);

		/// <summary>
		/// Set/Get the intensity of the key light.  The key light is the
		/// brightest light in the scene.  The intensities of the other two
		/// lights are ratios of the key light's intensity.
		/// </summary>
		// Token: 0x06014E27 RID: 85543 RVA: 0x001D8C3C File Offset: 0x001D6E3C
		public virtual double GetKeyLightIntensity()
		{
			return vtkLightKit.vtkLightKit_GetKeyLightIntensity_26(base.GetCppThis());
		}

		// Token: 0x06014E28 RID: 85544
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLightKit_GetKeyLightWarmth_27(HandleRef pThis);

		/// <summary>
		/// Set the warmth of each the lights.  Warmth is a parameter that
		/// varies from 0 to 1, where 0 is "cold" (looks icy or lit by a very
		/// blue sky), 1 is "warm" (the red of a very red sunset, or the
		/// embers of a campfire), and 0.5 is a neutral white.  The warmth
		/// scale is non-linear. Warmth values close to 0.5 are subtly
		/// "warmer" or "cooler," much like a warmer tungsten incandescent
		/// bulb, a cooler halogen, or daylight (cooler still).  Moving
		/// further away from 0.5, colors become more quickly varying towards
		/// blues and reds.  With regards to aesthetics, extremes of warmth
		/// should be used sparingly.
		/// </summary>
		// Token: 0x06014E29 RID: 85545 RVA: 0x001D8C5C File Offset: 0x001D6E5C
		public virtual double GetKeyLightWarmth()
		{
			return vtkLightKit.vtkLightKit_GetKeyLightWarmth_27(base.GetCppThis());
		}

		// Token: 0x06014E2A RID: 85546
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLightKit_GetKeyToBackRatio_28(HandleRef pThis);

		/// <summary>
		/// Set/Get the key-to-back light ratio.  This ratio controls
		/// how bright the back lights are compared to the key light: larger
		/// values correspond to dimmer back lights.  The back lights fill
		/// in the remaining high-contrast regions behind the object.
		/// Values between 2 and 10 are good.
		/// </summary>
		// Token: 0x06014E2B RID: 85547 RVA: 0x001D8C7C File Offset: 0x001D6E7C
		public virtual double GetKeyToBackRatio()
		{
			return vtkLightKit.vtkLightKit_GetKeyToBackRatio_28(base.GetCppThis());
		}

		// Token: 0x06014E2C RID: 85548
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLightKit_GetKeyToBackRatioMaxValue_29(HandleRef pThis);

		/// <summary>
		/// Set/Get the key-to-back light ratio.  This ratio controls
		/// how bright the back lights are compared to the key light: larger
		/// values correspond to dimmer back lights.  The back lights fill
		/// in the remaining high-contrast regions behind the object.
		/// Values between 2 and 10 are good.
		/// </summary>
		// Token: 0x06014E2D RID: 85549 RVA: 0x001D8C9C File Offset: 0x001D6E9C
		public virtual double GetKeyToBackRatioMaxValue()
		{
			return vtkLightKit.vtkLightKit_GetKeyToBackRatioMaxValue_29(base.GetCppThis());
		}

		// Token: 0x06014E2E RID: 85550
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLightKit_GetKeyToBackRatioMinValue_30(HandleRef pThis);

		/// <summary>
		/// Set/Get the key-to-back light ratio.  This ratio controls
		/// how bright the back lights are compared to the key light: larger
		/// values correspond to dimmer back lights.  The back lights fill
		/// in the remaining high-contrast regions behind the object.
		/// Values between 2 and 10 are good.
		/// </summary>
		// Token: 0x06014E2F RID: 85551 RVA: 0x001D8CBC File Offset: 0x001D6EBC
		public virtual double GetKeyToBackRatioMinValue()
		{
			return vtkLightKit.vtkLightKit_GetKeyToBackRatioMinValue_30(base.GetCppThis());
		}

		// Token: 0x06014E30 RID: 85552
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLightKit_GetKeyToFillRatio_31(HandleRef pThis);

		/// <summary>
		/// Set/Get the key-to-fill ratio.  This ratio controls
		/// how bright the fill light is compared to the key light: larger
		/// values correspond to a dimmer fill light.  The purpose of the
		/// fill light is to light parts of the object not lit by the key
		/// light, while still maintaining contrast.  This type of lighting
		/// may correspond to indirect illumination from the key light, bounced
		/// off a wall, floor, or other object.  The fill light should never
		/// be brighter than the key light:  a good range for the key-to-fill
		/// ratio is between 2 and 10.
		/// </summary>
		// Token: 0x06014E31 RID: 85553 RVA: 0x001D8CDC File Offset: 0x001D6EDC
		public virtual double GetKeyToFillRatio()
		{
			return vtkLightKit.vtkLightKit_GetKeyToFillRatio_31(base.GetCppThis());
		}

		// Token: 0x06014E32 RID: 85554
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLightKit_GetKeyToFillRatioMaxValue_32(HandleRef pThis);

		/// <summary>
		/// Set/Get the key-to-fill ratio.  This ratio controls
		/// how bright the fill light is compared to the key light: larger
		/// values correspond to a dimmer fill light.  The purpose of the
		/// fill light is to light parts of the object not lit by the key
		/// light, while still maintaining contrast.  This type of lighting
		/// may correspond to indirect illumination from the key light, bounced
		/// off a wall, floor, or other object.  The fill light should never
		/// be brighter than the key light:  a good range for the key-to-fill
		/// ratio is between 2 and 10.
		/// </summary>
		// Token: 0x06014E33 RID: 85555 RVA: 0x001D8CFC File Offset: 0x001D6EFC
		public virtual double GetKeyToFillRatioMaxValue()
		{
			return vtkLightKit.vtkLightKit_GetKeyToFillRatioMaxValue_32(base.GetCppThis());
		}

		// Token: 0x06014E34 RID: 85556
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLightKit_GetKeyToFillRatioMinValue_33(HandleRef pThis);

		/// <summary>
		/// Set/Get the key-to-fill ratio.  This ratio controls
		/// how bright the fill light is compared to the key light: larger
		/// values correspond to a dimmer fill light.  The purpose of the
		/// fill light is to light parts of the object not lit by the key
		/// light, while still maintaining contrast.  This type of lighting
		/// may correspond to indirect illumination from the key light, bounced
		/// off a wall, floor, or other object.  The fill light should never
		/// be brighter than the key light:  a good range for the key-to-fill
		/// ratio is between 2 and 10.
		/// </summary>
		// Token: 0x06014E35 RID: 85557 RVA: 0x001D8D1C File Offset: 0x001D6F1C
		public virtual double GetKeyToFillRatioMinValue()
		{
			return vtkLightKit.vtkLightKit_GetKeyToFillRatioMinValue_33(base.GetCppThis());
		}

		// Token: 0x06014E36 RID: 85558
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLightKit_GetKeyToHeadRatio_34(HandleRef pThis);

		/// <summary>
		/// Set/Get the key-to-headlight ratio.  Similar to the key-to-fill
		/// ratio, this ratio controls how bright the headlight light is
		/// compared to the key light: larger values correspond to a dimmer
		/// headlight light.  The headlight is special kind of fill light,
		/// lighting only the parts of the object that the camera can see.
		/// As such, a headlight tends to reduce the contrast of a scene.  It
		/// can be used to fill in "shadows" of the object missed by the key
		/// and fill lights.  The headlight should always be significantly
		/// dimmer than the key light:  ratios of 2 to 15 are typical.
		/// </summary>
		// Token: 0x06014E37 RID: 85559 RVA: 0x001D8D3C File Offset: 0x001D6F3C
		public virtual double GetKeyToHeadRatio()
		{
			return vtkLightKit.vtkLightKit_GetKeyToHeadRatio_34(base.GetCppThis());
		}

		// Token: 0x06014E38 RID: 85560
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLightKit_GetKeyToHeadRatioMaxValue_35(HandleRef pThis);

		/// <summary>
		/// Set/Get the key-to-headlight ratio.  Similar to the key-to-fill
		/// ratio, this ratio controls how bright the headlight light is
		/// compared to the key light: larger values correspond to a dimmer
		/// headlight light.  The headlight is special kind of fill light,
		/// lighting only the parts of the object that the camera can see.
		/// As such, a headlight tends to reduce the contrast of a scene.  It
		/// can be used to fill in "shadows" of the object missed by the key
		/// and fill lights.  The headlight should always be significantly
		/// dimmer than the key light:  ratios of 2 to 15 are typical.
		/// </summary>
		// Token: 0x06014E39 RID: 85561 RVA: 0x001D8D5C File Offset: 0x001D6F5C
		public virtual double GetKeyToHeadRatioMaxValue()
		{
			return vtkLightKit.vtkLightKit_GetKeyToHeadRatioMaxValue_35(base.GetCppThis());
		}

		// Token: 0x06014E3A RID: 85562
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLightKit_GetKeyToHeadRatioMinValue_36(HandleRef pThis);

		/// <summary>
		/// Set/Get the key-to-headlight ratio.  Similar to the key-to-fill
		/// ratio, this ratio controls how bright the headlight light is
		/// compared to the key light: larger values correspond to a dimmer
		/// headlight light.  The headlight is special kind of fill light,
		/// lighting only the parts of the object that the camera can see.
		/// As such, a headlight tends to reduce the contrast of a scene.  It
		/// can be used to fill in "shadows" of the object missed by the key
		/// and fill lights.  The headlight should always be significantly
		/// dimmer than the key light:  ratios of 2 to 15 are typical.
		/// </summary>
		// Token: 0x06014E3B RID: 85563 RVA: 0x001D8D7C File Offset: 0x001D6F7C
		public virtual double GetKeyToHeadRatioMinValue()
		{
			return vtkLightKit.vtkLightKit_GetKeyToHeadRatioMinValue_36(base.GetCppThis());
		}

		// Token: 0x06014E3C RID: 85564
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLightKit_GetMaintainLuminance_37(HandleRef pThis);

		/// <summary>
		/// If MaintainLuminance is set, the LightKit will attempt to maintain
		/// the apparent intensity of lights based on their perceptual brightnesses.
		/// By default, MaintainLuminance is off.
		/// </summary>
		// Token: 0x06014E3D RID: 85565 RVA: 0x001D8D9C File Offset: 0x001D6F9C
		public virtual int GetMaintainLuminance()
		{
			return vtkLightKit.vtkLightKit_GetMaintainLuminance_37(base.GetCppThis());
		}

		// Token: 0x06014E3E RID: 85566
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLightKit_GetNumberOfGenerationsFromBase_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014E3F RID: 85567 RVA: 0x001D8DBC File Offset: 0x001D6FBC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLightKit.vtkLightKit_GetNumberOfGenerationsFromBase_38(base.GetCppThis(), type);
		}

		// Token: 0x06014E40 RID: 85568
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLightKit_GetNumberOfGenerationsFromBaseType_39([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014E41 RID: 85569 RVA: 0x001D8DDC File Offset: 0x001D6FDC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLightKit.vtkLightKit_GetNumberOfGenerationsFromBaseType_39(type);
		}

		// Token: 0x06014E42 RID: 85570
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightKit_GetShortStringFromSubType_40(int subtype);

		/// <summary>
		/// Helper method to go from a enum subtype to a string subtype
		/// The difference from GetStringFromSubType is that it returns
		/// a shorter strings (useful for GUI with minimum space)
		/// </summary>
		// Token: 0x06014E43 RID: 85571 RVA: 0x001D8DF8 File Offset: 0x001D6FF8
		public static string GetShortStringFromSubType(int subtype)
		{
			string s = Marshal.PtrToStringAnsi(vtkLightKit.vtkLightKit_GetShortStringFromSubType_40(subtype));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014E44 RID: 85572
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightKit_GetStringFromSubType_41(int type);

		/// <summary>
		/// Helper method to go from a enum subtype to a string subtype
		/// </summary>
		// Token: 0x06014E45 RID: 85573 RVA: 0x001D8E30 File Offset: 0x001D7030
		public static string GetStringFromSubType(int type)
		{
			string s = Marshal.PtrToStringAnsi(vtkLightKit.vtkLightKit_GetStringFromSubType_41(type));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014E46 RID: 85574
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightKit_GetStringFromType_42(int type);

		/// <summary>
		/// Helper method to go from a enum type to a string type
		/// </summary>
		// Token: 0x06014E47 RID: 85575 RVA: 0x001D8E68 File Offset: 0x001D7068
		public static string GetStringFromType(int type)
		{
			string s = Marshal.PtrToStringAnsi(vtkLightKit.vtkLightKit_GetStringFromType_42(type));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014E48 RID: 85576
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkLightKit.LightKitSubType vtkLightKit_GetSubType_43(vtkLightKit.LightKitType type, int i);

		/// <summary>
		/// Return the possible subtype from a given type. You have to pass
		/// in a number i [0,3] no check is done.
		/// </summary>
		// Token: 0x06014E49 RID: 85577 RVA: 0x001D8EA0 File Offset: 0x001D70A0
		public static vtkLightKit.LightKitSubType GetSubType(vtkLightKit.LightKitType type, int i)
		{
			return vtkLightKit.vtkLightKit_GetSubType_43(type, i);
		}

		// Token: 0x06014E4A RID: 85578
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLightKit_IsA_44(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014E4B RID: 85579 RVA: 0x001D8EBC File Offset: 0x001D70BC
		public override int IsA(string type)
		{
			return vtkLightKit.vtkLightKit_IsA_44(base.GetCppThis(), type);
		}

		// Token: 0x06014E4C RID: 85580
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLightKit_IsTypeOf_45([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014E4D RID: 85581 RVA: 0x001D8EDC File Offset: 0x001D70DC
		public new static int IsTypeOf(string type)
		{
			return vtkLightKit.vtkLightKit_IsTypeOf_45(type);
		}

		// Token: 0x06014E4E RID: 85582
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_MaintainLuminanceOff_46(HandleRef pThis);

		/// <summary>
		/// If MaintainLuminance is set, the LightKit will attempt to maintain
		/// the apparent intensity of lights based on their perceptual brightnesses.
		/// By default, MaintainLuminance is off.
		/// </summary>
		// Token: 0x06014E4F RID: 85583 RVA: 0x001D8EF6 File Offset: 0x001D70F6
		public virtual void MaintainLuminanceOff()
		{
			vtkLightKit.vtkLightKit_MaintainLuminanceOff_46(base.GetCppThis());
		}

		// Token: 0x06014E50 RID: 85584
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_MaintainLuminanceOn_47(HandleRef pThis);

		/// <summary>
		/// If MaintainLuminance is set, the LightKit will attempt to maintain
		/// the apparent intensity of lights based on their perceptual brightnesses.
		/// By default, MaintainLuminance is off.
		/// </summary>
		// Token: 0x06014E51 RID: 85585 RVA: 0x001D8F05 File Offset: 0x001D7105
		public virtual void MaintainLuminanceOn()
		{
			vtkLightKit.vtkLightKit_MaintainLuminanceOn_47(base.GetCppThis());
		}

		// Token: 0x06014E52 RID: 85586
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_Modified_48(HandleRef pThis);

		/// <summary>
		/// Add lights to, or remove lights from, a renderer.
		/// Lights may be added to more than one renderer, if desired.
		/// </summary>
		// Token: 0x06014E53 RID: 85587 RVA: 0x001D8F14 File Offset: 0x001D7114
		public override void Modified()
		{
			vtkLightKit.vtkLightKit_Modified_48(base.GetCppThis());
		}

		// Token: 0x06014E54 RID: 85588
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightKit_NewInstance_50(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014E55 RID: 85589 RVA: 0x001D8F24 File Offset: 0x001D7124
		public new vtkLightKit NewInstance()
		{
			vtkLightKit result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightKit.vtkLightKit_NewInstance_50(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLightKit)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014E56 RID: 85590
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_RemoveLightsFromRenderer_51(HandleRef pThis, HandleRef renderer);

		/// <summary>
		/// Add lights to, or remove lights from, a renderer.
		/// Lights may be added to more than one renderer, if desired.
		/// </summary>
		// Token: 0x06014E57 RID: 85591 RVA: 0x001D8F80 File Offset: 0x001D7180
		public void RemoveLightsFromRenderer(vtkRenderer renderer)
		{
			vtkLightKit.vtkLightKit_RemoveLightsFromRenderer_51(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		// Token: 0x06014E58 RID: 85592
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightKit_SafeDownCast_52(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014E59 RID: 85593 RVA: 0x001D8FB0 File Offset: 0x001D71B0
		public new static vtkLightKit SafeDownCast(vtkObjectBase o)
		{
			vtkLightKit vtkLightKit = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightKit.vtkLightKit_SafeDownCast_52((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLightKit = (vtkLightKit)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLightKit.Register(null);
				}
			}
			return vtkLightKit;
		}

		// Token: 0x06014E5A RID: 85594
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_SetBackLightAngle_53(HandleRef pThis, double elevation, double azimuth);

		/// <summary>
		/// Get/Set the position of the key, fill, and back lights
		/// using angular methods.  Elevation corresponds to latitude,
		/// azimuth to longitude.  It is recommended that the key light
		/// always be on the viewer's side of the object and above the
		/// object, while the fill light generally lights the part of the object
		/// not lit by the fill light.  The headlight, which is always located
		/// at the viewer, can then be used to reduce the contrast in the image.
		/// There are a pair of back lights.  They are located at the same
		/// elevation and at opposing azimuths (ie, one to the left, and one to
		/// the right).  They are generally set at the equator (elevation = 0),
		/// and at approximately 120 degrees (lighting from each side and behind).
		/// </summary>
		// Token: 0x06014E5B RID: 85595 RVA: 0x001D902F File Offset: 0x001D722F
		public void SetBackLightAngle(double elevation, double azimuth)
		{
			vtkLightKit.vtkLightKit_SetBackLightAngle_53(base.GetCppThis(), elevation, azimuth);
		}

		// Token: 0x06014E5C RID: 85596
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_SetBackLightAngle_54(HandleRef pThis, IntPtr angle);

		/// <summary>
		/// Get/Set the position of the key, fill, and back lights
		/// using angular methods.  Elevation corresponds to latitude,
		/// azimuth to longitude.  It is recommended that the key light
		/// always be on the viewer's side of the object and above the
		/// object, while the fill light generally lights the part of the object
		/// not lit by the fill light.  The headlight, which is always located
		/// at the viewer, can then be used to reduce the contrast in the image.
		/// There are a pair of back lights.  They are located at the same
		/// elevation and at opposing azimuths (ie, one to the left, and one to
		/// the right).  They are generally set at the equator (elevation = 0),
		/// and at approximately 120 degrees (lighting from each side and behind).
		/// </summary>
		// Token: 0x06014E5D RID: 85597 RVA: 0x001D9040 File Offset: 0x001D7240
		public void SetBackLightAngle(IntPtr angle)
		{
			vtkLightKit.vtkLightKit_SetBackLightAngle_54(base.GetCppThis(), angle);
		}

		// Token: 0x06014E5E RID: 85598
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_SetBackLightAzimuth_55(HandleRef pThis, double x);

		/// <summary>
		/// Get/Set the position of the key, fill, and back lights
		/// using angular methods.  Elevation corresponds to latitude,
		/// azimuth to longitude.  It is recommended that the key light
		/// always be on the viewer's side of the object and above the
		/// object, while the fill light generally lights the part of the object
		/// not lit by the fill light.  The headlight, which is always located
		/// at the viewer, can then be used to reduce the contrast in the image.
		/// There are a pair of back lights.  They are located at the same
		/// elevation and at opposing azimuths (ie, one to the left, and one to
		/// the right).  They are generally set at the equator (elevation = 0),
		/// and at approximately 120 degrees (lighting from each side and behind).
		/// </summary>
		// Token: 0x06014E5F RID: 85599 RVA: 0x001D9050 File Offset: 0x001D7250
		public void SetBackLightAzimuth(double x)
		{
			vtkLightKit.vtkLightKit_SetBackLightAzimuth_55(base.GetCppThis(), x);
		}

		// Token: 0x06014E60 RID: 85600
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_SetBackLightElevation_56(HandleRef pThis, double x);

		/// <summary>
		/// Get/Set the position of the key, fill, and back lights
		/// using angular methods.  Elevation corresponds to latitude,
		/// azimuth to longitude.  It is recommended that the key light
		/// always be on the viewer's side of the object and above the
		/// object, while the fill light generally lights the part of the object
		/// not lit by the fill light.  The headlight, which is always located
		/// at the viewer, can then be used to reduce the contrast in the image.
		/// There are a pair of back lights.  They are located at the same
		/// elevation and at opposing azimuths (ie, one to the left, and one to
		/// the right).  They are generally set at the equator (elevation = 0),
		/// and at approximately 120 degrees (lighting from each side and behind).
		/// </summary>
		// Token: 0x06014E61 RID: 85601 RVA: 0x001D9060 File Offset: 0x001D7260
		public void SetBackLightElevation(double x)
		{
			vtkLightKit.vtkLightKit_SetBackLightElevation_56(base.GetCppThis(), x);
		}

		// Token: 0x06014E62 RID: 85602
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_SetBackLightWarmth_57(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the warmth of each the lights.  Warmth is a parameter that
		/// varies from 0 to 1, where 0 is "cold" (looks icy or lit by a very
		/// blue sky), 1 is "warm" (the red of a very red sunset, or the
		/// embers of a campfire), and 0.5 is a neutral white.  The warmth
		/// scale is non-linear. Warmth values close to 0.5 are subtly
		/// "warmer" or "cooler," much like a warmer tungsten incandescent
		/// bulb, a cooler halogen, or daylight (cooler still).  Moving
		/// further away from 0.5, colors become more quickly varying towards
		/// blues and reds.  With regards to aesthetics, extremes of warmth
		/// should be used sparingly.
		/// </summary>
		// Token: 0x06014E63 RID: 85603 RVA: 0x001D9070 File Offset: 0x001D7270
		public virtual void SetBackLightWarmth(double _arg)
		{
			vtkLightKit.vtkLightKit_SetBackLightWarmth_57(base.GetCppThis(), _arg);
		}

		// Token: 0x06014E64 RID: 85604
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_SetFillLightAngle_58(HandleRef pThis, double elevation, double azimuth);

		/// <summary>
		/// Get/Set the position of the key, fill, and back lights
		/// using angular methods.  Elevation corresponds to latitude,
		/// azimuth to longitude.  It is recommended that the key light
		/// always be on the viewer's side of the object and above the
		/// object, while the fill light generally lights the part of the object
		/// not lit by the fill light.  The headlight, which is always located
		/// at the viewer, can then be used to reduce the contrast in the image.
		/// There are a pair of back lights.  They are located at the same
		/// elevation and at opposing azimuths (ie, one to the left, and one to
		/// the right).  They are generally set at the equator (elevation = 0),
		/// and at approximately 120 degrees (lighting from each side and behind).
		/// </summary>
		// Token: 0x06014E65 RID: 85605 RVA: 0x001D9080 File Offset: 0x001D7280
		public void SetFillLightAngle(double elevation, double azimuth)
		{
			vtkLightKit.vtkLightKit_SetFillLightAngle_58(base.GetCppThis(), elevation, azimuth);
		}

		// Token: 0x06014E66 RID: 85606
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_SetFillLightAngle_59(HandleRef pThis, IntPtr angle);

		/// <summary>
		/// Get/Set the position of the key, fill, and back lights
		/// using angular methods.  Elevation corresponds to latitude,
		/// azimuth to longitude.  It is recommended that the key light
		/// always be on the viewer's side of the object and above the
		/// object, while the fill light generally lights the part of the object
		/// not lit by the fill light.  The headlight, which is always located
		/// at the viewer, can then be used to reduce the contrast in the image.
		/// There are a pair of back lights.  They are located at the same
		/// elevation and at opposing azimuths (ie, one to the left, and one to
		/// the right).  They are generally set at the equator (elevation = 0),
		/// and at approximately 120 degrees (lighting from each side and behind).
		/// </summary>
		// Token: 0x06014E67 RID: 85607 RVA: 0x001D9091 File Offset: 0x001D7291
		public void SetFillLightAngle(IntPtr angle)
		{
			vtkLightKit.vtkLightKit_SetFillLightAngle_59(base.GetCppThis(), angle);
		}

		// Token: 0x06014E68 RID: 85608
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_SetFillLightAzimuth_60(HandleRef pThis, double x);

		/// <summary>
		/// Get/Set the position of the key, fill, and back lights
		/// using angular methods.  Elevation corresponds to latitude,
		/// azimuth to longitude.  It is recommended that the key light
		/// always be on the viewer's side of the object and above the
		/// object, while the fill light generally lights the part of the object
		/// not lit by the fill light.  The headlight, which is always located
		/// at the viewer, can then be used to reduce the contrast in the image.
		/// There are a pair of back lights.  They are located at the same
		/// elevation and at opposing azimuths (ie, one to the left, and one to
		/// the right).  They are generally set at the equator (elevation = 0),
		/// and at approximately 120 degrees (lighting from each side and behind).
		/// </summary>
		// Token: 0x06014E69 RID: 85609 RVA: 0x001D90A1 File Offset: 0x001D72A1
		public void SetFillLightAzimuth(double x)
		{
			vtkLightKit.vtkLightKit_SetFillLightAzimuth_60(base.GetCppThis(), x);
		}

		// Token: 0x06014E6A RID: 85610
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_SetFillLightElevation_61(HandleRef pThis, double x);

		/// <summary>
		/// Get/Set the position of the key, fill, and back lights
		/// using angular methods.  Elevation corresponds to latitude,
		/// azimuth to longitude.  It is recommended that the key light
		/// always be on the viewer's side of the object and above the
		/// object, while the fill light generally lights the part of the object
		/// not lit by the fill light.  The headlight, which is always located
		/// at the viewer, can then be used to reduce the contrast in the image.
		/// There are a pair of back lights.  They are located at the same
		/// elevation and at opposing azimuths (ie, one to the left, and one to
		/// the right).  They are generally set at the equator (elevation = 0),
		/// and at approximately 120 degrees (lighting from each side and behind).
		/// </summary>
		// Token: 0x06014E6B RID: 85611 RVA: 0x001D90B1 File Offset: 0x001D72B1
		public void SetFillLightElevation(double x)
		{
			vtkLightKit.vtkLightKit_SetFillLightElevation_61(base.GetCppThis(), x);
		}

		// Token: 0x06014E6C RID: 85612
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_SetFillLightWarmth_62(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the warmth of each the lights.  Warmth is a parameter that
		/// varies from 0 to 1, where 0 is "cold" (looks icy or lit by a very
		/// blue sky), 1 is "warm" (the red of a very red sunset, or the
		/// embers of a campfire), and 0.5 is a neutral white.  The warmth
		/// scale is non-linear. Warmth values close to 0.5 are subtly
		/// "warmer" or "cooler," much like a warmer tungsten incandescent
		/// bulb, a cooler halogen, or daylight (cooler still).  Moving
		/// further away from 0.5, colors become more quickly varying towards
		/// blues and reds.  With regards to aesthetics, extremes of warmth
		/// should be used sparingly.
		/// </summary>
		// Token: 0x06014E6D RID: 85613 RVA: 0x001D90C1 File Offset: 0x001D72C1
		public virtual void SetFillLightWarmth(double _arg)
		{
			vtkLightKit.vtkLightKit_SetFillLightWarmth_62(base.GetCppThis(), _arg);
		}

		// Token: 0x06014E6E RID: 85614
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_SetHeadLightWarmth_63(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the warmth of each the lights.  Warmth is a parameter that
		/// varies from 0 to 1, where 0 is "cold" (looks icy or lit by a very
		/// blue sky), 1 is "warm" (the red of a very red sunset, or the
		/// embers of a campfire), and 0.5 is a neutral white.  The warmth
		/// scale is non-linear. Warmth values close to 0.5 are subtly
		/// "warmer" or "cooler," much like a warmer tungsten incandescent
		/// bulb, a cooler halogen, or daylight (cooler still).  Moving
		/// further away from 0.5, colors become more quickly varying towards
		/// blues and reds.  With regards to aesthetics, extremes of warmth
		/// should be used sparingly.
		/// </summary>
		// Token: 0x06014E6F RID: 85615 RVA: 0x001D90D1 File Offset: 0x001D72D1
		public virtual void SetHeadLightWarmth(double _arg)
		{
			vtkLightKit.vtkLightKit_SetHeadLightWarmth_63(base.GetCppThis(), _arg);
		}

		// Token: 0x06014E70 RID: 85616
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_SetKeyLightAngle_64(HandleRef pThis, double elevation, double azimuth);

		/// <summary>
		/// Get/Set the position of the key, fill, and back lights
		/// using angular methods.  Elevation corresponds to latitude,
		/// azimuth to longitude.  It is recommended that the key light
		/// always be on the viewer's side of the object and above the
		/// object, while the fill light generally lights the part of the object
		/// not lit by the fill light.  The headlight, which is always located
		/// at the viewer, can then be used to reduce the contrast in the image.
		/// There are a pair of back lights.  They are located at the same
		/// elevation and at opposing azimuths (ie, one to the left, and one to
		/// the right).  They are generally set at the equator (elevation = 0),
		/// and at approximately 120 degrees (lighting from each side and behind).
		/// </summary>
		// Token: 0x06014E71 RID: 85617 RVA: 0x001D90E1 File Offset: 0x001D72E1
		public void SetKeyLightAngle(double elevation, double azimuth)
		{
			vtkLightKit.vtkLightKit_SetKeyLightAngle_64(base.GetCppThis(), elevation, azimuth);
		}

		// Token: 0x06014E72 RID: 85618
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_SetKeyLightAngle_65(HandleRef pThis, IntPtr angle);

		/// <summary>
		/// Get/Set the position of the key, fill, and back lights
		/// using angular methods.  Elevation corresponds to latitude,
		/// azimuth to longitude.  It is recommended that the key light
		/// always be on the viewer's side of the object and above the
		/// object, while the fill light generally lights the part of the object
		/// not lit by the fill light.  The headlight, which is always located
		/// at the viewer, can then be used to reduce the contrast in the image.
		/// There are a pair of back lights.  They are located at the same
		/// elevation and at opposing azimuths (ie, one to the left, and one to
		/// the right).  They are generally set at the equator (elevation = 0),
		/// and at approximately 120 degrees (lighting from each side and behind).
		/// </summary>
		// Token: 0x06014E73 RID: 85619 RVA: 0x001D90F2 File Offset: 0x001D72F2
		public void SetKeyLightAngle(IntPtr angle)
		{
			vtkLightKit.vtkLightKit_SetKeyLightAngle_65(base.GetCppThis(), angle);
		}

		// Token: 0x06014E74 RID: 85620
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_SetKeyLightAzimuth_66(HandleRef pThis, double x);

		/// <summary>
		/// Get/Set the position of the key, fill, and back lights
		/// using angular methods.  Elevation corresponds to latitude,
		/// azimuth to longitude.  It is recommended that the key light
		/// always be on the viewer's side of the object and above the
		/// object, while the fill light generally lights the part of the object
		/// not lit by the fill light.  The headlight, which is always located
		/// at the viewer, can then be used to reduce the contrast in the image.
		/// There are a pair of back lights.  They are located at the same
		/// elevation and at opposing azimuths (ie, one to the left, and one to
		/// the right).  They are generally set at the equator (elevation = 0),
		/// and at approximately 120 degrees (lighting from each side and behind).
		/// </summary>
		// Token: 0x06014E75 RID: 85621 RVA: 0x001D9102 File Offset: 0x001D7302
		public void SetKeyLightAzimuth(double x)
		{
			vtkLightKit.vtkLightKit_SetKeyLightAzimuth_66(base.GetCppThis(), x);
		}

		// Token: 0x06014E76 RID: 85622
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_SetKeyLightElevation_67(HandleRef pThis, double x);

		/// <summary>
		/// Get/Set the position of the key, fill, and back lights
		/// using angular methods.  Elevation corresponds to latitude,
		/// azimuth to longitude.  It is recommended that the key light
		/// always be on the viewer's side of the object and above the
		/// object, while the fill light generally lights the part of the object
		/// not lit by the fill light.  The headlight, which is always located
		/// at the viewer, can then be used to reduce the contrast in the image.
		/// There are a pair of back lights.  They are located at the same
		/// elevation and at opposing azimuths (ie, one to the left, and one to
		/// the right).  They are generally set at the equator (elevation = 0),
		/// and at approximately 120 degrees (lighting from each side and behind).
		/// </summary>
		// Token: 0x06014E77 RID: 85623 RVA: 0x001D9112 File Offset: 0x001D7312
		public void SetKeyLightElevation(double x)
		{
			vtkLightKit.vtkLightKit_SetKeyLightElevation_67(base.GetCppThis(), x);
		}

		// Token: 0x06014E78 RID: 85624
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_SetKeyLightIntensity_68(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the intensity of the key light.  The key light is the
		/// brightest light in the scene.  The intensities of the other two
		/// lights are ratios of the key light's intensity.
		/// </summary>
		// Token: 0x06014E79 RID: 85625 RVA: 0x001D9122 File Offset: 0x001D7322
		public virtual void SetKeyLightIntensity(double _arg)
		{
			vtkLightKit.vtkLightKit_SetKeyLightIntensity_68(base.GetCppThis(), _arg);
		}

		// Token: 0x06014E7A RID: 85626
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_SetKeyLightWarmth_69(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the warmth of each the lights.  Warmth is a parameter that
		/// varies from 0 to 1, where 0 is "cold" (looks icy or lit by a very
		/// blue sky), 1 is "warm" (the red of a very red sunset, or the
		/// embers of a campfire), and 0.5 is a neutral white.  The warmth
		/// scale is non-linear. Warmth values close to 0.5 are subtly
		/// "warmer" or "cooler," much like a warmer tungsten incandescent
		/// bulb, a cooler halogen, or daylight (cooler still).  Moving
		/// further away from 0.5, colors become more quickly varying towards
		/// blues and reds.  With regards to aesthetics, extremes of warmth
		/// should be used sparingly.
		/// </summary>
		// Token: 0x06014E7B RID: 85627 RVA: 0x001D9132 File Offset: 0x001D7332
		public virtual void SetKeyLightWarmth(double _arg)
		{
			vtkLightKit.vtkLightKit_SetKeyLightWarmth_69(base.GetCppThis(), _arg);
		}

		// Token: 0x06014E7C RID: 85628
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_SetKeyToBackRatio_70(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the key-to-back light ratio.  This ratio controls
		/// how bright the back lights are compared to the key light: larger
		/// values correspond to dimmer back lights.  The back lights fill
		/// in the remaining high-contrast regions behind the object.
		/// Values between 2 and 10 are good.
		/// </summary>
		// Token: 0x06014E7D RID: 85629 RVA: 0x001D9142 File Offset: 0x001D7342
		public virtual void SetKeyToBackRatio(double _arg)
		{
			vtkLightKit.vtkLightKit_SetKeyToBackRatio_70(base.GetCppThis(), _arg);
		}

		// Token: 0x06014E7E RID: 85630
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_SetKeyToFillRatio_71(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the key-to-fill ratio.  This ratio controls
		/// how bright the fill light is compared to the key light: larger
		/// values correspond to a dimmer fill light.  The purpose of the
		/// fill light is to light parts of the object not lit by the key
		/// light, while still maintaining contrast.  This type of lighting
		/// may correspond to indirect illumination from the key light, bounced
		/// off a wall, floor, or other object.  The fill light should never
		/// be brighter than the key light:  a good range for the key-to-fill
		/// ratio is between 2 and 10.
		/// </summary>
		// Token: 0x06014E7F RID: 85631 RVA: 0x001D9152 File Offset: 0x001D7352
		public virtual void SetKeyToFillRatio(double _arg)
		{
			vtkLightKit.vtkLightKit_SetKeyToFillRatio_71(base.GetCppThis(), _arg);
		}

		// Token: 0x06014E80 RID: 85632
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_SetKeyToHeadRatio_72(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the key-to-headlight ratio.  Similar to the key-to-fill
		/// ratio, this ratio controls how bright the headlight light is
		/// compared to the key light: larger values correspond to a dimmer
		/// headlight light.  The headlight is special kind of fill light,
		/// lighting only the parts of the object that the camera can see.
		/// As such, a headlight tends to reduce the contrast of a scene.  It
		/// can be used to fill in "shadows" of the object missed by the key
		/// and fill lights.  The headlight should always be significantly
		/// dimmer than the key light:  ratios of 2 to 15 are typical.
		/// </summary>
		// Token: 0x06014E81 RID: 85633 RVA: 0x001D9162 File Offset: 0x001D7362
		public virtual void SetKeyToHeadRatio(double _arg)
		{
			vtkLightKit.vtkLightKit_SetKeyToHeadRatio_72(base.GetCppThis(), _arg);
		}

		// Token: 0x06014E82 RID: 85634
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_SetMaintainLuminance_73(HandleRef pThis, int _arg);

		/// <summary>
		/// If MaintainLuminance is set, the LightKit will attempt to maintain
		/// the apparent intensity of lights based on their perceptual brightnesses.
		/// By default, MaintainLuminance is off.
		/// </summary>
		// Token: 0x06014E83 RID: 85635 RVA: 0x001D9172 File Offset: 0x001D7372
		public virtual void SetMaintainLuminance(int _arg)
		{
			vtkLightKit.vtkLightKit_SetMaintainLuminance_73(base.GetCppThis(), _arg);
		}

		// Token: 0x06014E84 RID: 85636
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightKit_Update_74(HandleRef pThis);

		/// <summary>
		/// Add lights to, or remove lights from, a renderer.
		/// Lights may be added to more than one renderer, if desired.
		/// </summary>
		// Token: 0x06014E85 RID: 85637 RVA: 0x001D9182 File Offset: 0x001D7382
		public void Update()
		{
			vtkLightKit.vtkLightKit_Update_74(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001812 RID: 6162
		public new const string MRFullTypeName = "Kitware.VTK.vtkLightKit";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001813 RID: 6163
		public new static readonly string MRClassNameKey = "class vtkLightKit";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x020007EF RID: 2031
		public enum LightKitSubType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001815 RID: 6165
			Azimuth = 3,
			/// <summary>enum member</summary>
			// Token: 0x04001816 RID: 6166
			Elevation = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001817 RID: 6167
			Intensity = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001818 RID: 6168
			KBRatio = 5,
			/// <summary>enum member</summary>
			// Token: 0x04001819 RID: 6169
			KFRatio = 4,
			/// <summary>enum member</summary>
			// Token: 0x0400181A RID: 6170
			KHRatio = 6,
			/// <summary>enum member</summary>
			// Token: 0x0400181B RID: 6171
			Warmth = 0
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x020007F0 RID: 2032
		public enum LightKitType
		{
			/// <summary>enum member</summary>
			// Token: 0x0400181D RID: 6173
			TBackLight = 2,
			/// <summary>enum member</summary>
			// Token: 0x0400181E RID: 6174
			TFillLight = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400181F RID: 6175
			THeadLight = 3,
			/// <summary>enum member</summary>
			// Token: 0x04001820 RID: 6176
			TKeyLight = 0
		}
	}
}
