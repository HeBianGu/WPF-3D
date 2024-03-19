using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLight
	/// </summary>
	/// <remarks>
	///    a virtual light for 3D rendering
	///
	/// vtkLight is a virtual light for 3D rendering. It provides methods to locate
	/// and point the light, turn it on and off, and set its brightness and color.
	/// In addition to the basic infinite distance point light source attributes,
	/// you also can specify the light attenuation values and cone angle.
	/// These attributes are only used if the light is a positional light.
	/// The default is a directional light (e.g. infinite point light source).
	///
	/// Lights have a type that describes how the light should move with respect
	/// to the camera.  A Headlight is always located at the current camera position
	/// and shines on the camera's focal point.  A CameraLight also moves with
	/// the camera, but may not be coincident to it.  CameraLights are defined
	/// in a normalized coordinate space where the camera is located at (0, 0, 1),
	/// the camera is looking at (0, 0, 0), and up is (0, 1, 0).  Finally, a
	/// SceneLight is part of the scene itself and does not move with the camera.
	/// (Renderers are responsible for moving the light based on its type.)
	///
	/// Lights have a transformation matrix that describes the space in which
	/// they are positioned.  A light's world space position and focal point
	/// are defined by their local position and focal point, transformed by
	/// their transformation matrix (if it exists).
	/// </remarks>
	// Token: 0x02000117 RID: 279
	public class vtkLight : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060038D5 RID: 14549 RVA: 0x00053253 File Offset: 0x00051453
		static vtkLight()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLight.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLight"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060038D6 RID: 14550 RVA: 0x0005327B File Offset: 0x0005147B
		public vtkLight(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060038D7 RID: 14551
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLight_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a light with the focal point at the origin and its position
		/// set to (0,0,1). The light is a SceneLight, its color is white
		/// (black ambient, white diffuse, white specular),
		/// intensity=1, the light is turned on, positional lighting is off,
		/// ConeAngle=30, AttenuationValues=(1,0,0), Exponent=1 and the
		/// TransformMatrix is NULL.
		/// </summary>
		// Token: 0x060038D8 RID: 14552 RVA: 0x0005328C File Offset: 0x0005148C
		public new static vtkLight New()
		{
			vtkLight result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLight.vtkLight_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLight)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create a light with the focal point at the origin and its position
		/// set to (0,0,1). The light is a SceneLight, its color is white
		/// (black ambient, white diffuse, white specular),
		/// intensity=1, the light is turned on, positional lighting is off,
		/// ConeAngle=30, AttenuationValues=(1,0,0), Exponent=1 and the
		/// TransformMatrix is NULL.
		/// </summary>
		// Token: 0x060038D9 RID: 14553 RVA: 0x000532E0 File Offset: 0x000514E0
		public vtkLight() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLight.vtkLight_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060038DA RID: 14554 RVA: 0x00053324 File Offset: 0x00051524
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060038DB RID: 14555
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_DeepCopy_01(HandleRef pThis, HandleRef light);

		/// <summary>
		/// Perform deep copy of this light.
		/// </summary>
		// Token: 0x060038DC RID: 14556 RVA: 0x00053330 File Offset: 0x00051530
		public void DeepCopy(vtkLight light)
		{
			vtkLight.vtkLight_DeepCopy_01(base.GetCppThis(), (light == null) ? default(HandleRef) : light.GetCppThis());
		}

		// Token: 0x060038DD RID: 14557
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLight_GetAmbientColor_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the color of the light. It is possible to set the ambient,
		/// diffuse and specular colors separately. The SetColor() method sets
		/// the diffuse and specular colors to the same color (this is a feature
		/// to preserve backward compatibility.)
		/// </summary>
		// Token: 0x060038DE RID: 14558 RVA: 0x00053360 File Offset: 0x00051560
		public virtual double[] GetAmbientColor()
		{
			IntPtr intPtr = vtkLight.vtkLight_GetAmbientColor_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060038DF RID: 14559
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_GetAmbientColor_03(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the color of the light. It is possible to set the ambient,
		/// diffuse and specular colors separately. The SetColor() method sets
		/// the diffuse and specular colors to the same color (this is a feature
		/// to preserve backward compatibility.)
		/// </summary>
		// Token: 0x060038E0 RID: 14560 RVA: 0x000533A8 File Offset: 0x000515A8
		public virtual void GetAmbientColor(IntPtr data)
		{
			vtkLight.vtkLight_GetAmbientColor_03(base.GetCppThis(), data);
		}

		// Token: 0x060038E1 RID: 14561
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLight_GetAttenuationValues_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the quadratic attenuation constants. They are specified as
		/// constant, linear, and quadratic, in that order.
		/// </summary>
		// Token: 0x060038E2 RID: 14562 RVA: 0x000533B8 File Offset: 0x000515B8
		public virtual double[] GetAttenuationValues()
		{
			IntPtr intPtr = vtkLight.vtkLight_GetAttenuationValues_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060038E3 RID: 14563
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_GetAttenuationValues_05(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the quadratic attenuation constants. They are specified as
		/// constant, linear, and quadratic, in that order.
		/// </summary>
		// Token: 0x060038E4 RID: 14564 RVA: 0x00053400 File Offset: 0x00051600
		public virtual void GetAttenuationValues(IntPtr data)
		{
			vtkLight.vtkLight_GetAttenuationValues_05(base.GetCppThis(), data);
		}

		// Token: 0x060038E5 RID: 14565
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLight_GetConeAngle_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the lighting cone angle of a positional light in degrees.
		/// This is the angle between the axis of the cone and a ray along the edge of
		/// the cone.
		/// A value of 90 (or more) indicates that you want no spot lighting effects
		/// just a positional light.
		/// </summary>
		// Token: 0x060038E6 RID: 14566 RVA: 0x00053410 File Offset: 0x00051610
		public virtual double GetConeAngle()
		{
			return vtkLight.vtkLight_GetConeAngle_06(base.GetCppThis());
		}

		// Token: 0x060038E7 RID: 14567
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLight_GetDiffuseColor_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the color of the light. It is possible to set the ambient,
		/// diffuse and specular colors separately. The SetColor() method sets
		/// the diffuse and specular colors to the same color (this is a feature
		/// to preserve backward compatibility.)
		/// </summary>
		// Token: 0x060038E8 RID: 14568 RVA: 0x00053430 File Offset: 0x00051630
		public virtual double[] GetDiffuseColor()
		{
			IntPtr intPtr = vtkLight.vtkLight_GetDiffuseColor_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060038E9 RID: 14569
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_GetDiffuseColor_08(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the color of the light. It is possible to set the ambient,
		/// diffuse and specular colors separately. The SetColor() method sets
		/// the diffuse and specular colors to the same color (this is a feature
		/// to preserve backward compatibility.)
		/// </summary>
		// Token: 0x060038EA RID: 14570 RVA: 0x00053478 File Offset: 0x00051678
		public virtual void GetDiffuseColor(IntPtr data)
		{
			vtkLight.vtkLight_GetDiffuseColor_08(base.GetCppThis(), data);
		}

		// Token: 0x060038EB RID: 14571
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLight_GetExponent_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the exponent of the cosine used in positional lighting.
		/// </summary>
		// Token: 0x060038EC RID: 14572 RVA: 0x00053488 File Offset: 0x00051688
		public virtual double GetExponent()
		{
			return vtkLight.vtkLight_GetExponent_09(base.GetCppThis());
		}

		// Token: 0x060038ED RID: 14573
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLight_GetExponentMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the exponent of the cosine used in positional lighting.
		/// </summary>
		// Token: 0x060038EE RID: 14574 RVA: 0x000534A8 File Offset: 0x000516A8
		public virtual double GetExponentMaxValue()
		{
			return vtkLight.vtkLight_GetExponentMaxValue_10(base.GetCppThis());
		}

		// Token: 0x060038EF RID: 14575
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLight_GetExponentMinValue_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the exponent of the cosine used in positional lighting.
		/// </summary>
		// Token: 0x060038F0 RID: 14576 RVA: 0x000534C8 File Offset: 0x000516C8
		public virtual double GetExponentMinValue()
		{
			return vtkLight.vtkLight_GetExponentMinValue_11(base.GetCppThis());
		}

		// Token: 0x060038F1 RID: 14577
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLight_GetFocalPoint_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the point at which the light is shining.
		/// Note: The focal point of the light is defined in the coordinate
		/// space indicated by its transformation matrix (if it exists).
		/// Thus, to get the light's world space focal point, use
		/// vtkGetTransformedFocalPoint() instead of vtkGetFocalPoint().
		/// </summary>
		// Token: 0x060038F2 RID: 14578 RVA: 0x000534E8 File Offset: 0x000516E8
		public virtual double[] GetFocalPoint()
		{
			IntPtr intPtr = vtkLight.vtkLight_GetFocalPoint_12(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060038F3 RID: 14579
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_GetFocalPoint_13(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the point at which the light is shining.
		/// Note: The focal point of the light is defined in the coordinate
		/// space indicated by its transformation matrix (if it exists).
		/// Thus, to get the light's world space focal point, use
		/// vtkGetTransformedFocalPoint() instead of vtkGetFocalPoint().
		/// </summary>
		// Token: 0x060038F4 RID: 14580 RVA: 0x00053530 File Offset: 0x00051730
		public virtual void GetFocalPoint(IntPtr data)
		{
			vtkLight.vtkLight_GetFocalPoint_13(base.GetCppThis(), data);
		}

		// Token: 0x060038F5 RID: 14581
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLight_GetInformation_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the information object associated with the light.
		/// </summary>
		// Token: 0x060038F6 RID: 14582 RVA: 0x00053540 File Offset: 0x00051740
		public virtual vtkInformation GetInformation()
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLight.vtkLight_GetInformation_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		// Token: 0x060038F7 RID: 14583
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLight_GetIntensity_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the brightness of the light (from one to zero).
		/// </summary>
		// Token: 0x060038F8 RID: 14584 RVA: 0x000535B0 File Offset: 0x000517B0
		public virtual double GetIntensity()
		{
			return vtkLight.vtkLight_GetIntensity_15(base.GetCppThis());
		}

		// Token: 0x060038F9 RID: 14585
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLight_GetLightType_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the type of the light.
		/// A SceneLight is a light located in the world coordinate space.  A light
		/// is initially created as a scene light.
		///
		/// A Headlight is always located at the camera and is pointed at the
		/// camera's focal point.  The renderer is free to modify the position and
		/// focal point of the camera at any time.
		///
		/// A CameraLight is also attached to the camera, but is not necessarily
		/// located at the camera's position.  CameraLights are defined in a
		/// coordinate space where the camera is located at (0, 0, 1), looking
		/// towards (0, 0, 0) at a distance of 1, with up being (0, 1, 0).
		/// CameraLight uses the transform matrix to establish this space.
		///
		/// Note: All SetLightType(), and SetLightTypeTo*() calls clear the
		/// light's transform matrix.
		/// </summary>
		// Token: 0x060038FA RID: 14586 RVA: 0x000535D0 File Offset: 0x000517D0
		public virtual int GetLightType()
		{
			return vtkLight.vtkLight_GetLightType_16(base.GetCppThis());
		}

		// Token: 0x060038FB RID: 14587
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLight_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060038FC RID: 14588 RVA: 0x000535F0 File Offset: 0x000517F0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLight.vtkLight_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x060038FD RID: 14589
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLight_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060038FE RID: 14590 RVA: 0x00053610 File Offset: 0x00051810
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLight.vtkLight_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x060038FF RID: 14591
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLight_GetPosition_19(HandleRef pThis);

		/// <summary>
		/// Set/Get the position of the light.
		/// Note: The position of the light is defined in the coordinate
		/// space indicated by its transformation matrix (if it exists).
		/// Thus, to get the light's world space position, use
		/// vtkGetTransformedPosition() instead of vtkGetPosition().
		/// </summary>
		// Token: 0x06003900 RID: 14592 RVA: 0x0005362C File Offset: 0x0005182C
		public virtual double[] GetPosition()
		{
			IntPtr intPtr = vtkLight.vtkLight_GetPosition_19(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06003901 RID: 14593
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_GetPosition_20(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the position of the light.
		/// Note: The position of the light is defined in the coordinate
		/// space indicated by its transformation matrix (if it exists).
		/// Thus, to get the light's world space position, use
		/// vtkGetTransformedPosition() instead of vtkGetPosition().
		/// </summary>
		// Token: 0x06003902 RID: 14594 RVA: 0x00053674 File Offset: 0x00051874
		public virtual void GetPosition(IntPtr data)
		{
			vtkLight.vtkLight_GetPosition_20(base.GetCppThis(), data);
		}

		// Token: 0x06003903 RID: 14595
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLight_GetPositional_21(HandleRef pThis);

		/// <summary>
		/// Turn positional lighting on or off.
		/// </summary>
		// Token: 0x06003904 RID: 14596 RVA: 0x00053684 File Offset: 0x00051884
		public virtual int GetPositional()
		{
			return vtkLight.vtkLight_GetPositional_21(base.GetCppThis());
		}

		// Token: 0x06003905 RID: 14597
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkLight_GetShadowAttenuation_22(HandleRef pThis);

		/// <summary>
		/// Set/Get the shadow intensity
		/// By default a light will be completely blocked when in shadow
		/// by setting this value to less than 1.0 you can control how much
		/// light is attenuated when in shadow
		/// </summary>
		// Token: 0x06003906 RID: 14598 RVA: 0x000536A4 File Offset: 0x000518A4
		public virtual float GetShadowAttenuation()
		{
			return vtkLight.vtkLight_GetShadowAttenuation_22(base.GetCppThis());
		}

		// Token: 0x06003907 RID: 14599
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLight_GetSpecularColor_23(HandleRef pThis);

		/// <summary>
		/// Set/Get the color of the light. It is possible to set the ambient,
		/// diffuse and specular colors separately. The SetColor() method sets
		/// the diffuse and specular colors to the same color (this is a feature
		/// to preserve backward compatibility.)
		/// </summary>
		// Token: 0x06003908 RID: 14600 RVA: 0x000536C4 File Offset: 0x000518C4
		public virtual double[] GetSpecularColor()
		{
			IntPtr intPtr = vtkLight.vtkLight_GetSpecularColor_23(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06003909 RID: 14601
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_GetSpecularColor_24(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the color of the light. It is possible to set the ambient,
		/// diffuse and specular colors separately. The SetColor() method sets
		/// the diffuse and specular colors to the same color (this is a feature
		/// to preserve backward compatibility.)
		/// </summary>
		// Token: 0x0600390A RID: 14602 RVA: 0x0005370C File Offset: 0x0005190C
		public virtual void GetSpecularColor(IntPtr data)
		{
			vtkLight.vtkLight_GetSpecularColor_24(base.GetCppThis(), data);
		}

		// Token: 0x0600390B RID: 14603
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLight_GetSwitch_25(HandleRef pThis);

		/// <summary>
		/// Turn the light on or off.
		/// </summary>
		// Token: 0x0600390C RID: 14604 RVA: 0x0005371C File Offset: 0x0005191C
		public virtual int GetSwitch()
		{
			return vtkLight.vtkLight_GetSwitch_25(base.GetCppThis());
		}

		// Token: 0x0600390D RID: 14605
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLight_GetTransformMatrix_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the light's transformation matrix.  If a matrix is set for
		/// a light, the light's parameters (position and focal point) are
		/// transformed by the matrix before being rendered.
		/// </summary>
		// Token: 0x0600390E RID: 14606 RVA: 0x0005373C File Offset: 0x0005193C
		public virtual vtkMatrix4x4 GetTransformMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLight.vtkLight_GetTransformMatrix_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600390F RID: 14607
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_GetTransformedFocalPoint_27(HandleRef pThis, ref double x, ref double y, ref double z);

		/// <summary>
		/// Get the focal point of the light, modified by the transformation matrix
		/// (if it exists).
		/// </summary>
		// Token: 0x06003910 RID: 14608 RVA: 0x000537AB File Offset: 0x000519AB
		public void GetTransformedFocalPoint(ref double x, ref double y, ref double z)
		{
			vtkLight.vtkLight_GetTransformedFocalPoint_27(base.GetCppThis(), ref x, ref y, ref z);
		}

		// Token: 0x06003911 RID: 14609
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_GetTransformedFocalPoint_28(HandleRef pThis, IntPtr a);

		/// <summary>
		/// Get the focal point of the light, modified by the transformation matrix
		/// (if it exists).
		/// </summary>
		// Token: 0x06003912 RID: 14610 RVA: 0x000537BD File Offset: 0x000519BD
		public void GetTransformedFocalPoint(IntPtr a)
		{
			vtkLight.vtkLight_GetTransformedFocalPoint_28(base.GetCppThis(), a);
		}

		// Token: 0x06003913 RID: 14611
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLight_GetTransformedFocalPoint_29(HandleRef pThis);

		/// <summary>
		/// Get the focal point of the light, modified by the transformation matrix
		/// (if it exists).
		/// </summary>
		// Token: 0x06003914 RID: 14612 RVA: 0x000537D0 File Offset: 0x000519D0
		public double[] GetTransformedFocalPoint()
		{
			IntPtr intPtr = vtkLight.vtkLight_GetTransformedFocalPoint_29(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06003915 RID: 14613
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_GetTransformedPosition_30(HandleRef pThis, ref double x, ref double y, ref double z);

		/// <summary>
		/// Get the position of the light, modified by the transformation matrix
		/// (if it exists).
		/// </summary>
		// Token: 0x06003916 RID: 14614 RVA: 0x00053818 File Offset: 0x00051A18
		public void GetTransformedPosition(ref double x, ref double y, ref double z)
		{
			vtkLight.vtkLight_GetTransformedPosition_30(base.GetCppThis(), ref x, ref y, ref z);
		}

		// Token: 0x06003917 RID: 14615
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_GetTransformedPosition_31(HandleRef pThis, IntPtr a);

		/// <summary>
		/// Get the position of the light, modified by the transformation matrix
		/// (if it exists).
		/// </summary>
		// Token: 0x06003918 RID: 14616 RVA: 0x0005382A File Offset: 0x00051A2A
		public void GetTransformedPosition(IntPtr a)
		{
			vtkLight.vtkLight_GetTransformedPosition_31(base.GetCppThis(), a);
		}

		// Token: 0x06003919 RID: 14617
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLight_GetTransformedPosition_32(HandleRef pThis);

		/// <summary>
		/// Get the position of the light, modified by the transformation matrix
		/// (if it exists).
		/// </summary>
		// Token: 0x0600391A RID: 14618 RVA: 0x0005383C File Offset: 0x00051A3C
		public double[] GetTransformedPosition()
		{
			IntPtr intPtr = vtkLight.vtkLight_GetTransformedPosition_32(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600391B RID: 14619
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLight_IsA_33(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600391C RID: 14620 RVA: 0x00053884 File Offset: 0x00051A84
		public override int IsA(string type)
		{
			return vtkLight.vtkLight_IsA_33(base.GetCppThis(), type);
		}

		// Token: 0x0600391D RID: 14621
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLight_IsTypeOf_34([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600391E RID: 14622 RVA: 0x000538A4 File Offset: 0x00051AA4
		public new static int IsTypeOf(string type)
		{
			return vtkLight.vtkLight_IsTypeOf_34(type);
		}

		// Token: 0x0600391F RID: 14623
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLight_LightTypeIsCameraLight_35(HandleRef pThis);

		/// <summary>
		/// Query the type of the light.
		/// </summary>
		// Token: 0x06003920 RID: 14624 RVA: 0x000538C0 File Offset: 0x00051AC0
		public int LightTypeIsCameraLight()
		{
			return vtkLight.vtkLight_LightTypeIsCameraLight_35(base.GetCppThis());
		}

		// Token: 0x06003921 RID: 14625
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLight_LightTypeIsHeadlight_36(HandleRef pThis);

		/// <summary>
		/// Query the type of the light.
		/// </summary>
		// Token: 0x06003922 RID: 14626 RVA: 0x000538E0 File Offset: 0x00051AE0
		public int LightTypeIsHeadlight()
		{
			return vtkLight.vtkLight_LightTypeIsHeadlight_36(base.GetCppThis());
		}

		// Token: 0x06003923 RID: 14627
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLight_LightTypeIsSceneLight_37(HandleRef pThis);

		/// <summary>
		/// Query the type of the light.
		/// </summary>
		// Token: 0x06003924 RID: 14628 RVA: 0x00053900 File Offset: 0x00051B00
		public int LightTypeIsSceneLight()
		{
			return vtkLight.vtkLight_LightTypeIsSceneLight_37(base.GetCppThis());
		}

		// Token: 0x06003925 RID: 14629
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLight_NewInstance_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003926 RID: 14630 RVA: 0x00053920 File Offset: 0x00051B20
		public new vtkLight NewInstance()
		{
			vtkLight result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLight.vtkLight_NewInstance_39(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLight)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003927 RID: 14631
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_PositionalOff_40(HandleRef pThis);

		/// <summary>
		/// Turn positional lighting on or off.
		/// </summary>
		// Token: 0x06003928 RID: 14632 RVA: 0x0005397A File Offset: 0x00051B7A
		public virtual void PositionalOff()
		{
			vtkLight.vtkLight_PositionalOff_40(base.GetCppThis());
		}

		// Token: 0x06003929 RID: 14633
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_PositionalOn_41(HandleRef pThis);

		/// <summary>
		/// Turn positional lighting on or off.
		/// </summary>
		// Token: 0x0600392A RID: 14634 RVA: 0x00053989 File Offset: 0x00051B89
		public virtual void PositionalOn()
		{
			vtkLight.vtkLight_PositionalOn_41(base.GetCppThis());
		}

		// Token: 0x0600392B RID: 14635
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_Render_42(HandleRef pThis, HandleRef arg0, int arg1);

		/// <summary>
		/// Abstract interface to renderer. Each concrete subclass of vtkLight
		/// will load its data into the graphics system in response to this method
		/// invocation. The actual loading is performed by a vtkLightDevice
		/// subclass, which will get created automatically.
		/// </summary>
		// Token: 0x0600392C RID: 14636 RVA: 0x00053998 File Offset: 0x00051B98
		public virtual void Render(vtkRenderer arg0, int arg1)
		{
			vtkLight.vtkLight_Render_42(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), arg1);
		}

		// Token: 0x0600392D RID: 14637
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLight_SafeDownCast_43(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600392E RID: 14638 RVA: 0x000539C8 File Offset: 0x00051BC8
		public new static vtkLight SafeDownCast(vtkObjectBase o)
		{
			vtkLight vtkLight = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLight.vtkLight_SafeDownCast_43((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLight = (vtkLight)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLight.Register(null);
				}
			}
			return vtkLight;
		}

		// Token: 0x0600392F RID: 14639
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_SetAmbientColor_44(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the color of the light. It is possible to set the ambient,
		/// diffuse and specular colors separately. The SetColor() method sets
		/// the diffuse and specular colors to the same color (this is a feature
		/// to preserve backward compatibility.)
		/// </summary>
		// Token: 0x06003930 RID: 14640 RVA: 0x00053A47 File Offset: 0x00051C47
		public virtual void SetAmbientColor(double _arg1, double _arg2, double _arg3)
		{
			vtkLight.vtkLight_SetAmbientColor_44(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06003931 RID: 14641
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_SetAmbientColor_45(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the color of the light. It is possible to set the ambient,
		/// diffuse and specular colors separately. The SetColor() method sets
		/// the diffuse and specular colors to the same color (this is a feature
		/// to preserve backward compatibility.)
		/// </summary>
		// Token: 0x06003932 RID: 14642 RVA: 0x00053A59 File Offset: 0x00051C59
		public virtual void SetAmbientColor(IntPtr _arg)
		{
			vtkLight.vtkLight_SetAmbientColor_45(base.GetCppThis(), _arg);
		}

		// Token: 0x06003933 RID: 14643
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_SetAttenuationValues_46(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the quadratic attenuation constants. They are specified as
		/// constant, linear, and quadratic, in that order.
		/// </summary>
		// Token: 0x06003934 RID: 14644 RVA: 0x00053A69 File Offset: 0x00051C69
		public virtual void SetAttenuationValues(double _arg1, double _arg2, double _arg3)
		{
			vtkLight.vtkLight_SetAttenuationValues_46(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06003935 RID: 14645
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_SetAttenuationValues_47(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the quadratic attenuation constants. They are specified as
		/// constant, linear, and quadratic, in that order.
		/// </summary>
		// Token: 0x06003936 RID: 14646 RVA: 0x00053A7B File Offset: 0x00051C7B
		public virtual void SetAttenuationValues(IntPtr _arg)
		{
			vtkLight.vtkLight_SetAttenuationValues_47(base.GetCppThis(), _arg);
		}

		// Token: 0x06003937 RID: 14647
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_SetColor_48(HandleRef pThis, double arg0, double arg1, double arg2);

		/// <summary>
		/// Set/Get the color of the light. It is possible to set the ambient,
		/// diffuse and specular colors separately. The SetColor() method sets
		/// the diffuse and specular colors to the same color (this is a feature
		/// to preserve backward compatibility.)
		/// </summary>
		// Token: 0x06003938 RID: 14648 RVA: 0x00053A8B File Offset: 0x00051C8B
		public void SetColor(double arg0, double arg1, double arg2)
		{
			vtkLight.vtkLight_SetColor_48(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x06003939 RID: 14649
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_SetColor_49(HandleRef pThis, IntPtr a);

		/// <summary>
		/// Set/Get the color of the light. It is possible to set the ambient,
		/// diffuse and specular colors separately. The SetColor() method sets
		/// the diffuse and specular colors to the same color (this is a feature
		/// to preserve backward compatibility.)
		/// </summary>
		// Token: 0x0600393A RID: 14650 RVA: 0x00053A9D File Offset: 0x00051C9D
		public void SetColor(IntPtr a)
		{
			vtkLight.vtkLight_SetColor_49(base.GetCppThis(), a);
		}

		// Token: 0x0600393B RID: 14651
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_SetConeAngle_50(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the lighting cone angle of a positional light in degrees.
		/// This is the angle between the axis of the cone and a ray along the edge of
		/// the cone.
		/// A value of 90 (or more) indicates that you want no spot lighting effects
		/// just a positional light.
		/// </summary>
		// Token: 0x0600393C RID: 14652 RVA: 0x00053AAD File Offset: 0x00051CAD
		public virtual void SetConeAngle(double _arg)
		{
			vtkLight.vtkLight_SetConeAngle_50(base.GetCppThis(), _arg);
		}

		// Token: 0x0600393D RID: 14653
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_SetDiffuseColor_51(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the color of the light. It is possible to set the ambient,
		/// diffuse and specular colors separately. The SetColor() method sets
		/// the diffuse and specular colors to the same color (this is a feature
		/// to preserve backward compatibility.)
		/// </summary>
		// Token: 0x0600393E RID: 14654 RVA: 0x00053ABD File Offset: 0x00051CBD
		public virtual void SetDiffuseColor(double _arg1, double _arg2, double _arg3)
		{
			vtkLight.vtkLight_SetDiffuseColor_51(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600393F RID: 14655
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_SetDiffuseColor_52(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the color of the light. It is possible to set the ambient,
		/// diffuse and specular colors separately. The SetColor() method sets
		/// the diffuse and specular colors to the same color (this is a feature
		/// to preserve backward compatibility.)
		/// </summary>
		// Token: 0x06003940 RID: 14656 RVA: 0x00053ACF File Offset: 0x00051CCF
		public virtual void SetDiffuseColor(IntPtr _arg)
		{
			vtkLight.vtkLight_SetDiffuseColor_52(base.GetCppThis(), _arg);
		}

		// Token: 0x06003941 RID: 14657
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_SetDirectionAngle_53(HandleRef pThis, double elevation, double azimuth);

		/// <summary>
		/// Set the position and focal point of a light based on elevation and
		/// azimuth.  The light is moved so it is shining from the given angle.
		/// Angles are given in degrees.  If the light is a
		/// positional light, it is made directional instead.
		/// </summary>
		// Token: 0x06003942 RID: 14658 RVA: 0x00053ADF File Offset: 0x00051CDF
		public void SetDirectionAngle(double elevation, double azimuth)
		{
			vtkLight.vtkLight_SetDirectionAngle_53(base.GetCppThis(), elevation, azimuth);
		}

		// Token: 0x06003943 RID: 14659
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_SetDirectionAngle_54(HandleRef pThis, IntPtr ang);

		/// <summary>
		/// Set the position and focal point of a light based on elevation and
		/// azimuth.  The light is moved so it is shining from the given angle.
		/// Angles are given in degrees.  If the light is a
		/// positional light, it is made directional instead.
		/// </summary>
		// Token: 0x06003944 RID: 14660 RVA: 0x00053AF0 File Offset: 0x00051CF0
		public void SetDirectionAngle(IntPtr ang)
		{
			vtkLight.vtkLight_SetDirectionAngle_54(base.GetCppThis(), ang);
		}

		// Token: 0x06003945 RID: 14661
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_SetExponent_55(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the exponent of the cosine used in positional lighting.
		/// </summary>
		// Token: 0x06003946 RID: 14662 RVA: 0x00053B00 File Offset: 0x00051D00
		public virtual void SetExponent(double _arg)
		{
			vtkLight.vtkLight_SetExponent_55(base.GetCppThis(), _arg);
		}

		// Token: 0x06003947 RID: 14663
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_SetFocalPoint_56(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the point at which the light is shining.
		/// Note: The focal point of the light is defined in the coordinate
		/// space indicated by its transformation matrix (if it exists).
		/// Thus, to get the light's world space focal point, use
		/// vtkGetTransformedFocalPoint() instead of vtkGetFocalPoint().
		/// </summary>
		// Token: 0x06003948 RID: 14664 RVA: 0x00053B10 File Offset: 0x00051D10
		public virtual void SetFocalPoint(double _arg1, double _arg2, double _arg3)
		{
			vtkLight.vtkLight_SetFocalPoint_56(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06003949 RID: 14665
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_SetFocalPoint_57(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the point at which the light is shining.
		/// Note: The focal point of the light is defined in the coordinate
		/// space indicated by its transformation matrix (if it exists).
		/// Thus, to get the light's world space focal point, use
		/// vtkGetTransformedFocalPoint() instead of vtkGetFocalPoint().
		/// </summary>
		// Token: 0x0600394A RID: 14666 RVA: 0x00053B22 File Offset: 0x00051D22
		public virtual void SetFocalPoint(IntPtr _arg)
		{
			vtkLight.vtkLight_SetFocalPoint_57(base.GetCppThis(), _arg);
		}

		// Token: 0x0600394B RID: 14667
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_SetInformation_58(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the information object associated with the light.
		/// </summary>
		// Token: 0x0600394C RID: 14668 RVA: 0x00053B34 File Offset: 0x00051D34
		public virtual void SetInformation(vtkInformation arg0)
		{
			vtkLight.vtkLight_SetInformation_58(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600394D RID: 14669
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_SetIntensity_59(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the brightness of the light (from one to zero).
		/// </summary>
		// Token: 0x0600394E RID: 14670 RVA: 0x00053B63 File Offset: 0x00051D63
		public virtual void SetIntensity(double _arg)
		{
			vtkLight.vtkLight_SetIntensity_59(base.GetCppThis(), _arg);
		}

		// Token: 0x0600394F RID: 14671
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_SetLightType_60(HandleRef pThis, int arg0);

		/// <summary>
		/// Set/Get the type of the light.
		/// A SceneLight is a light located in the world coordinate space.  A light
		/// is initially created as a scene light.
		///
		/// A Headlight is always located at the camera and is pointed at the
		/// camera's focal point.  The renderer is free to modify the position and
		/// focal point of the camera at any time.
		///
		/// A CameraLight is also attached to the camera, but is not necessarily
		/// located at the camera's position.  CameraLights are defined in a
		/// coordinate space where the camera is located at (0, 0, 1), looking
		/// towards (0, 0, 0) at a distance of 1, with up being (0, 1, 0).
		/// CameraLight uses the transform matrix to establish this space.
		///
		/// Note: All SetLightType(), and SetLightTypeTo*() calls clear the
		/// light's transform matrix.
		/// </summary>
		// Token: 0x06003950 RID: 14672 RVA: 0x00053B73 File Offset: 0x00051D73
		public virtual void SetLightType(int arg0)
		{
			vtkLight.vtkLight_SetLightType_60(base.GetCppThis(), arg0);
		}

		// Token: 0x06003951 RID: 14673
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_SetLightTypeToCameraLight_61(HandleRef pThis);

		/// <summary>
		/// Set/Get the type of the light.
		/// A SceneLight is a light located in the world coordinate space.  A light
		/// is initially created as a scene light.
		///
		/// A Headlight is always located at the camera and is pointed at the
		/// camera's focal point.  The renderer is free to modify the position and
		/// focal point of the camera at any time.
		///
		/// A CameraLight is also attached to the camera, but is not necessarily
		/// located at the camera's position.  CameraLights are defined in a
		/// coordinate space where the camera is located at (0, 0, 1), looking
		/// towards (0, 0, 0) at a distance of 1, with up being (0, 1, 0).
		/// CameraLight uses the transform matrix to establish this space.
		///
		/// Note: All SetLightType(), and SetLightTypeTo*() calls clear the
		/// light's transform matrix.
		/// </summary>
		// Token: 0x06003952 RID: 14674 RVA: 0x00053B83 File Offset: 0x00051D83
		public void SetLightTypeToCameraLight()
		{
			vtkLight.vtkLight_SetLightTypeToCameraLight_61(base.GetCppThis());
		}

		// Token: 0x06003953 RID: 14675
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_SetLightTypeToHeadlight_62(HandleRef pThis);

		/// <summary>
		/// Set/Get the type of the light.
		/// A SceneLight is a light located in the world coordinate space.  A light
		/// is initially created as a scene light.
		///
		/// A Headlight is always located at the camera and is pointed at the
		/// camera's focal point.  The renderer is free to modify the position and
		/// focal point of the camera at any time.
		///
		/// A CameraLight is also attached to the camera, but is not necessarily
		/// located at the camera's position.  CameraLights are defined in a
		/// coordinate space where the camera is located at (0, 0, 1), looking
		/// towards (0, 0, 0) at a distance of 1, with up being (0, 1, 0).
		/// CameraLight uses the transform matrix to establish this space.
		///
		/// Note: All SetLightType(), and SetLightTypeTo*() calls clear the
		/// light's transform matrix.
		/// </summary>
		// Token: 0x06003954 RID: 14676 RVA: 0x00053B92 File Offset: 0x00051D92
		public void SetLightTypeToHeadlight()
		{
			vtkLight.vtkLight_SetLightTypeToHeadlight_62(base.GetCppThis());
		}

		// Token: 0x06003955 RID: 14677
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_SetLightTypeToSceneLight_63(HandleRef pThis);

		/// <summary>
		/// Set/Get the type of the light.
		/// A SceneLight is a light located in the world coordinate space.  A light
		/// is initially created as a scene light.
		///
		/// A Headlight is always located at the camera and is pointed at the
		/// camera's focal point.  The renderer is free to modify the position and
		/// focal point of the camera at any time.
		///
		/// A CameraLight is also attached to the camera, but is not necessarily
		/// located at the camera's position.  CameraLights are defined in a
		/// coordinate space where the camera is located at (0, 0, 1), looking
		/// towards (0, 0, 0) at a distance of 1, with up being (0, 1, 0).
		/// CameraLight uses the transform matrix to establish this space.
		///
		/// Note: All SetLightType(), and SetLightTypeTo*() calls clear the
		/// light's transform matrix.
		/// </summary>
		// Token: 0x06003956 RID: 14678 RVA: 0x00053BA1 File Offset: 0x00051DA1
		public void SetLightTypeToSceneLight()
		{
			vtkLight.vtkLight_SetLightTypeToSceneLight_63(base.GetCppThis());
		}

		// Token: 0x06003957 RID: 14679
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_SetPosition_64(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the position of the light.
		/// Note: The position of the light is defined in the coordinate
		/// space indicated by its transformation matrix (if it exists).
		/// Thus, to get the light's world space position, use
		/// vtkGetTransformedPosition() instead of vtkGetPosition().
		/// </summary>
		// Token: 0x06003958 RID: 14680 RVA: 0x00053BB0 File Offset: 0x00051DB0
		public virtual void SetPosition(double _arg1, double _arg2, double _arg3)
		{
			vtkLight.vtkLight_SetPosition_64(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06003959 RID: 14681
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_SetPosition_65(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the position of the light.
		/// Note: The position of the light is defined in the coordinate
		/// space indicated by its transformation matrix (if it exists).
		/// Thus, to get the light's world space position, use
		/// vtkGetTransformedPosition() instead of vtkGetPosition().
		/// </summary>
		// Token: 0x0600395A RID: 14682 RVA: 0x00053BC2 File Offset: 0x00051DC2
		public virtual void SetPosition(IntPtr _arg)
		{
			vtkLight.vtkLight_SetPosition_65(base.GetCppThis(), _arg);
		}

		// Token: 0x0600395B RID: 14683
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_SetPositional_66(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn positional lighting on or off.
		/// </summary>
		// Token: 0x0600395C RID: 14684 RVA: 0x00053BD2 File Offset: 0x00051DD2
		public virtual void SetPositional(int _arg)
		{
			vtkLight.vtkLight_SetPositional_66(base.GetCppThis(), _arg);
		}

		// Token: 0x0600395D RID: 14685
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_SetShadowAttenuation_67(HandleRef pThis, float _arg);

		/// <summary>
		/// Set/Get the shadow intensity
		/// By default a light will be completely blocked when in shadow
		/// by setting this value to less than 1.0 you can control how much
		/// light is attenuated when in shadow
		/// </summary>
		// Token: 0x0600395E RID: 14686 RVA: 0x00053BE2 File Offset: 0x00051DE2
		public virtual void SetShadowAttenuation(float _arg)
		{
			vtkLight.vtkLight_SetShadowAttenuation_67(base.GetCppThis(), _arg);
		}

		// Token: 0x0600395F RID: 14687
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_SetSpecularColor_68(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the color of the light. It is possible to set the ambient,
		/// diffuse and specular colors separately. The SetColor() method sets
		/// the diffuse and specular colors to the same color (this is a feature
		/// to preserve backward compatibility.)
		/// </summary>
		// Token: 0x06003960 RID: 14688 RVA: 0x00053BF2 File Offset: 0x00051DF2
		public virtual void SetSpecularColor(double _arg1, double _arg2, double _arg3)
		{
			vtkLight.vtkLight_SetSpecularColor_68(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06003961 RID: 14689
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_SetSpecularColor_69(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the color of the light. It is possible to set the ambient,
		/// diffuse and specular colors separately. The SetColor() method sets
		/// the diffuse and specular colors to the same color (this is a feature
		/// to preserve backward compatibility.)
		/// </summary>
		// Token: 0x06003962 RID: 14690 RVA: 0x00053C04 File Offset: 0x00051E04
		public virtual void SetSpecularColor(IntPtr _arg)
		{
			vtkLight.vtkLight_SetSpecularColor_69(base.GetCppThis(), _arg);
		}

		// Token: 0x06003963 RID: 14691
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_SetSwitch_70(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn the light on or off.
		/// </summary>
		// Token: 0x06003964 RID: 14692 RVA: 0x00053C14 File Offset: 0x00051E14
		public virtual void SetSwitch(int _arg)
		{
			vtkLight.vtkLight_SetSwitch_70(base.GetCppThis(), _arg);
		}

		// Token: 0x06003965 RID: 14693
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_SetTransformMatrix_71(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the light's transformation matrix.  If a matrix is set for
		/// a light, the light's parameters (position and focal point) are
		/// transformed by the matrix before being rendered.
		/// </summary>
		// Token: 0x06003966 RID: 14694 RVA: 0x00053C24 File Offset: 0x00051E24
		public virtual void SetTransformMatrix(vtkMatrix4x4 arg0)
		{
			vtkLight.vtkLight_SetTransformMatrix_71(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003967 RID: 14695
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLight_ShallowClone_72(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a new light object with the same light parameters than the current
		/// object (any ivar from the superclasses (vtkObject and vtkObjectBase),
		/// like reference counting, timestamp and observers are not copied).
		/// This is a shallow clone (TransformMatrix is referenced)
		/// </summary>
		// Token: 0x06003968 RID: 14696 RVA: 0x00053C54 File Offset: 0x00051E54
		public virtual vtkLight ShallowClone()
		{
			vtkLight vtkLight = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLight.vtkLight_ShallowClone_72(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLight = (vtkLight)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLight.Register(null);
				}
			}
			return vtkLight;
		}

		// Token: 0x06003969 RID: 14697
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_SwitchOff_73(HandleRef pThis);

		/// <summary>
		/// Turn the light on or off.
		/// </summary>
		// Token: 0x0600396A RID: 14698 RVA: 0x00053CC3 File Offset: 0x00051EC3
		public virtual void SwitchOff()
		{
			vtkLight.vtkLight_SwitchOff_73(base.GetCppThis());
		}

		// Token: 0x0600396B RID: 14699
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_SwitchOn_74(HandleRef pThis);

		/// <summary>
		/// Turn the light on or off.
		/// </summary>
		// Token: 0x0600396C RID: 14700 RVA: 0x00053CD2 File Offset: 0x00051ED2
		public virtual void SwitchOn()
		{
			vtkLight.vtkLight_SwitchOn_74(base.GetCppThis());
		}

		// Token: 0x0600396D RID: 14701
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_TransformPoint_75(HandleRef pThis, IntPtr a, IntPtr b);

		/// <summary>
		/// Use transform matrix to transform point (if it exists).
		/// </summary>
		// Token: 0x0600396E RID: 14702 RVA: 0x00053CE1 File Offset: 0x00051EE1
		public void TransformPoint(IntPtr a, IntPtr b)
		{
			vtkLight.vtkLight_TransformPoint_75(base.GetCppThis(), a, b);
		}

		// Token: 0x0600396F RID: 14703
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLight_TransformVector_76(HandleRef pThis, IntPtr a, IntPtr b);

		/// <summary>
		/// Use transform matrix to transform vector (if it exists).
		/// </summary>
		// Token: 0x06003970 RID: 14704 RVA: 0x00053CF2 File Offset: 0x00051EF2
		public void TransformVector(IntPtr a, IntPtr b)
		{
			vtkLight.vtkLight_TransformVector_76(base.GetCppThis(), a, b);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000666 RID: 1638
		public new const string MRFullTypeName = "Kitware.VTK.vtkLight";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000667 RID: 1639
		public new static readonly string MRClassNameKey = "class vtkLight";
	}
}
