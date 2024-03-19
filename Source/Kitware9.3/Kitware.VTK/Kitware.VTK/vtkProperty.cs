using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProperty
	/// </summary>
	/// <remarks>
	///    represent surface properties of a geometric object
	///
	/// vtkProperty is an object that represents lighting and other surface
	/// properties of a geometric object. The primary properties that can be
	/// set are colors (overall, ambient, diffuse, specular, and edge color);
	/// specular power; opacity of the object; the representation of the
	/// object (points, wireframe, or surface); and the shading method to be
	/// used (flat, Gouraud, and Phong). Also, some special graphics features
	/// like backface properties can be set and manipulated with this object.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkActor vtkPropertyDevice
	/// </seealso>
	// Token: 0x020001F1 RID: 497
	public class vtkProperty : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005E42 RID: 24130 RVA: 0x00088B2D File Offset: 0x00086D2D
		static vtkProperty()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProperty.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProperty"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005E43 RID: 24131 RVA: 0x00088B55 File Offset: 0x00086D55
		public vtkProperty(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005E44 RID: 24132
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProperty_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with object color, ambient color, diffuse color,
		/// specular color, and edge color white; ambient coefficient=0; diffuse
		/// coefficient=0; specular coefficient=0; specular power=1; Gouraud shading;
		/// and surface representation. Backface and frontface culling are off.
		/// </summary>
		// Token: 0x06005E45 RID: 24133 RVA: 0x00088B64 File Offset: 0x00086D64
		public new static vtkProperty New()
		{
			vtkProperty result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProperty.vtkProperty_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with object color, ambient color, diffuse color,
		/// specular color, and edge color white; ambient coefficient=0; diffuse
		/// coefficient=0; specular coefficient=0; specular power=1; Gouraud shading;
		/// and surface representation. Backface and frontface culling are off.
		/// </summary>
		// Token: 0x06005E46 RID: 24134 RVA: 0x00088BB8 File Offset: 0x00086DB8
		public vtkProperty() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkProperty.vtkProperty_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005E47 RID: 24135 RVA: 0x00088BFC File Offset: 0x00086DFC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005E48 RID: 24136
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_AddShaderVariable_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int numVars, IntPtr x);

		/// <summary>
		/// Provide values to initialize shader variables.
		/// Useful to initialize shader variables that change over time
		/// (animation, GUI widgets inputs, etc. )
		/// - \p name - hardware name of the uniform variable
		/// - \p numVars - number of variables being set
		/// - \p x - values
		/// </summary>
		// Token: 0x06005E49 RID: 24137 RVA: 0x00088C07 File Offset: 0x00086E07
		public virtual void AddShaderVariable(string name, int numVars, IntPtr x)
		{
			vtkProperty.vtkProperty_AddShaderVariable_01(base.GetCppThis(), name, numVars, x);
		}

		// Token: 0x06005E4A RID: 24138
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_AddShaderVariable_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int v);

		/// <summary>
		/// Methods to provide to add shader variables from wrappers.
		/// </summary>
		// Token: 0x06005E4B RID: 24139 RVA: 0x00088C19 File Offset: 0x00086E19
		public void AddShaderVariable(string name, int v)
		{
			vtkProperty.vtkProperty_AddShaderVariable_02(base.GetCppThis(), name, v);
		}

		// Token: 0x06005E4C RID: 24140
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_AddShaderVariable_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, float v);

		/// <summary>
		/// Methods to provide to add shader variables from wrappers.
		/// </summary>
		// Token: 0x06005E4D RID: 24141 RVA: 0x00088C2A File Offset: 0x00086E2A
		public void AddShaderVariable(string name, float v)
		{
			vtkProperty.vtkProperty_AddShaderVariable_03(base.GetCppThis(), name, v);
		}

		// Token: 0x06005E4E RID: 24142
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_AddShaderVariable_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, double v);

		/// <summary>
		/// Methods to provide to add shader variables from wrappers.
		/// </summary>
		// Token: 0x06005E4F RID: 24143 RVA: 0x00088C3B File Offset: 0x00086E3B
		public void AddShaderVariable(string name, double v)
		{
			vtkProperty.vtkProperty_AddShaderVariable_04(base.GetCppThis(), name, v);
		}

		// Token: 0x06005E50 RID: 24144
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_AddShaderVariable_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int v1, int v2);

		/// <summary>
		/// Methods to provide to add shader variables from wrappers.
		/// </summary>
		// Token: 0x06005E51 RID: 24145 RVA: 0x00088C4C File Offset: 0x00086E4C
		public void AddShaderVariable(string name, int v1, int v2)
		{
			vtkProperty.vtkProperty_AddShaderVariable_05(base.GetCppThis(), name, v1, v2);
		}

		// Token: 0x06005E52 RID: 24146
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_AddShaderVariable_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, float v1, float v2);

		/// <summary>
		/// Methods to provide to add shader variables from wrappers.
		/// </summary>
		// Token: 0x06005E53 RID: 24147 RVA: 0x00088C5E File Offset: 0x00086E5E
		public void AddShaderVariable(string name, float v1, float v2)
		{
			vtkProperty.vtkProperty_AddShaderVariable_06(base.GetCppThis(), name, v1, v2);
		}

		// Token: 0x06005E54 RID: 24148
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_AddShaderVariable_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, double v1, double v2);

		/// <summary>
		/// Methods to provide to add shader variables from wrappers.
		/// </summary>
		// Token: 0x06005E55 RID: 24149 RVA: 0x00088C70 File Offset: 0x00086E70
		public void AddShaderVariable(string name, double v1, double v2)
		{
			vtkProperty.vtkProperty_AddShaderVariable_07(base.GetCppThis(), name, v1, v2);
		}

		// Token: 0x06005E56 RID: 24150
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_AddShaderVariable_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int v1, int v2, int v3);

		/// <summary>
		/// Methods to provide to add shader variables from wrappers.
		/// </summary>
		// Token: 0x06005E57 RID: 24151 RVA: 0x00088C82 File Offset: 0x00086E82
		public void AddShaderVariable(string name, int v1, int v2, int v3)
		{
			vtkProperty.vtkProperty_AddShaderVariable_08(base.GetCppThis(), name, v1, v2, v3);
		}

		// Token: 0x06005E58 RID: 24152
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_AddShaderVariable_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, float v1, float v2, float v3);

		/// <summary>
		/// Methods to provide to add shader variables from wrappers.
		/// </summary>
		// Token: 0x06005E59 RID: 24153 RVA: 0x00088C96 File Offset: 0x00086E96
		public void AddShaderVariable(string name, float v1, float v2, float v3)
		{
			vtkProperty.vtkProperty_AddShaderVariable_09(base.GetCppThis(), name, v1, v2, v3);
		}

		// Token: 0x06005E5A RID: 24154
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_AddShaderVariable_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, double v1, double v2, double v3);

		/// <summary>
		/// Methods to provide to add shader variables from wrappers.
		/// </summary>
		// Token: 0x06005E5B RID: 24155 RVA: 0x00088CAA File Offset: 0x00086EAA
		public void AddShaderVariable(string name, double v1, double v2, double v3)
		{
			vtkProperty.vtkProperty_AddShaderVariable_10(base.GetCppThis(), name, v1, v2, v3);
		}

		// Token: 0x06005E5C RID: 24156
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_BackfaceCullingOff_11(HandleRef pThis);

		/// <summary>
		/// Turn on/off fast culling of polygons based on orientation of normal
		/// with respect to camera. If backface culling is on, polygons facing
		/// away from camera are not drawn.
		/// </summary>
		// Token: 0x06005E5D RID: 24157 RVA: 0x00088CBE File Offset: 0x00086EBE
		public virtual void BackfaceCullingOff()
		{
			vtkProperty.vtkProperty_BackfaceCullingOff_11(base.GetCppThis());
		}

		// Token: 0x06005E5E RID: 24158
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_BackfaceCullingOn_12(HandleRef pThis);

		/// <summary>
		/// Turn on/off fast culling of polygons based on orientation of normal
		/// with respect to camera. If backface culling is on, polygons facing
		/// away from camera are not drawn.
		/// </summary>
		// Token: 0x06005E5F RID: 24159 RVA: 0x00088CCD File Offset: 0x00086ECD
		public virtual void BackfaceCullingOn()
		{
			vtkProperty.vtkProperty_BackfaceCullingOn_12(base.GetCppThis());
		}

		// Token: 0x06005E60 RID: 24160
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_BackfaceRender_13(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// This method renders the property as a backface property. TwoSidedLighting
		/// must be turned off to see any backface properties. Note that only
		/// colors and opacity are used for backface properties. Other properties
		/// such as Representation, Culling are specified by the Property.
		/// </summary>
		// Token: 0x06005E61 RID: 24161 RVA: 0x00088CDC File Offset: 0x00086EDC
		public virtual void BackfaceRender(vtkActor arg0, vtkRenderer arg1)
		{
			vtkProperty.vtkProperty_BackfaceRender_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06005E62 RID: 24162
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_ComputeIORFromReflectance_14(double reflectance, double ior);

		/// <summary>
		/// For PBR, calculate the refractive index from the reflectance of the interface
		/// and the refractive index of one of both medium.
		/// </summary>
		// Token: 0x06005E63 RID: 24163 RVA: 0x00088D20 File Offset: 0x00086F20
		public static double ComputeIORFromReflectance(double reflectance, double ior)
		{
			return vtkProperty.vtkProperty_ComputeIORFromReflectance_14(reflectance, ior);
		}

		// Token: 0x06005E64 RID: 24164
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_ComputeReflectanceFromIOR_15(double IORTo, double IORFrom);

		/// <summary>
		/// For PBR, calculate the reflectance from the refractive index of
		/// ingoing and outgoing interfaces.
		/// </summary>
		// Token: 0x06005E65 RID: 24165 RVA: 0x00088D3C File Offset: 0x00086F3C
		public static double ComputeReflectanceFromIOR(double IORTo, double IORFrom)
		{
			return vtkProperty.vtkProperty_ComputeReflectanceFromIOR_15(IORTo, IORFrom);
		}

		// Token: 0x06005E66 RID: 24166
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_ComputeReflectanceOfBaseLayer_16(HandleRef pThis);

		/// <summary>
		/// For PBR, calculate the reflectance of the base layer depending on the presence
		/// of a coat layer. If there is no coat layer, the reflectance is the one at the
		/// interface environment - base layer. If a coat layer is present, the reflectance
		/// is the one at the interface between the base and the coat layer.
		/// </summary>
		// Token: 0x06005E67 RID: 24167 RVA: 0x00088D58 File Offset: 0x00086F58
		public double ComputeReflectanceOfBaseLayer()
		{
			return vtkProperty.vtkProperty_ComputeReflectanceOfBaseLayer_16(base.GetCppThis());
		}

		// Token: 0x06005E68 RID: 24168
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_DeepCopy_17(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Assign one property to another.
		/// </summary>
		// Token: 0x06005E69 RID: 24169 RVA: 0x00088D78 File Offset: 0x00086F78
		public void DeepCopy(vtkProperty p)
		{
			vtkProperty.vtkProperty_DeepCopy_17(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x06005E6A RID: 24170
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_EdgeVisibilityOff_18(HandleRef pThis);

		/// <summary>
		/// Turn on/off the visibility of edges. On some renderers it is
		/// possible to render the edges of geometric primitives separately
		/// from the interior.
		/// </summary>
		// Token: 0x06005E6B RID: 24171 RVA: 0x00088DA7 File Offset: 0x00086FA7
		public virtual void EdgeVisibilityOff()
		{
			vtkProperty.vtkProperty_EdgeVisibilityOff_18(base.GetCppThis());
		}

		// Token: 0x06005E6C RID: 24172
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_EdgeVisibilityOn_19(HandleRef pThis);

		/// <summary>
		/// Turn on/off the visibility of edges. On some renderers it is
		/// possible to render the edges of geometric primitives separately
		/// from the interior.
		/// </summary>
		// Token: 0x06005E6D RID: 24173 RVA: 0x00088DB6 File Offset: 0x00086FB6
		public virtual void EdgeVisibilityOn()
		{
			vtkProperty.vtkProperty_EdgeVisibilityOn_19(base.GetCppThis());
		}

		// Token: 0x06005E6E RID: 24174
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_FrontfaceCullingOff_20(HandleRef pThis);

		/// <summary>
		/// Turn on/off fast culling of polygons based on orientation of normal
		/// with respect to camera. If frontface culling is on, polygons facing
		/// towards camera are not drawn.
		/// </summary>
		// Token: 0x06005E6F RID: 24175 RVA: 0x00088DC5 File Offset: 0x00086FC5
		public virtual void FrontfaceCullingOff()
		{
			vtkProperty.vtkProperty_FrontfaceCullingOff_20(base.GetCppThis());
		}

		// Token: 0x06005E70 RID: 24176
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_FrontfaceCullingOn_21(HandleRef pThis);

		/// <summary>
		/// Turn on/off fast culling of polygons based on orientation of normal
		/// with respect to camera. If frontface culling is on, polygons facing
		/// towards camera are not drawn.
		/// </summary>
		// Token: 0x06005E71 RID: 24177 RVA: 0x00088DD4 File Offset: 0x00086FD4
		public virtual void FrontfaceCullingOn()
		{
			vtkProperty.vtkProperty_FrontfaceCullingOn_21(base.GetCppThis());
		}

		// Token: 0x06005E72 RID: 24178
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetAmbient_22(HandleRef pThis);

		/// <summary>
		/// Set/Get the ambient lighting coefficient.
		/// </summary>
		// Token: 0x06005E73 RID: 24179 RVA: 0x00088DE4 File Offset: 0x00086FE4
		public virtual double GetAmbient()
		{
			return vtkProperty.vtkProperty_GetAmbient_22(base.GetCppThis());
		}

		// Token: 0x06005E74 RID: 24180
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProperty_GetAmbientColor_23(HandleRef pThis);

		/// <summary>
		/// Set/Get the ambient surface color. Not all renderers support separate
		/// ambient and diffuse colors. From a physical standpoint it really
		/// doesn't make too much sense to have both. For the rendering
		/// libraries that don't support both, the diffuse color is used.
		/// </summary>
		// Token: 0x06005E75 RID: 24181 RVA: 0x00088E04 File Offset: 0x00087004
		public virtual double[] GetAmbientColor()
		{
			IntPtr intPtr = vtkProperty.vtkProperty_GetAmbientColor_23(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06005E76 RID: 24182
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_GetAmbientColor_24(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the ambient surface color. Not all renderers support separate
		/// ambient and diffuse colors. From a physical standpoint it really
		/// doesn't make too much sense to have both. For the rendering
		/// libraries that don't support both, the diffuse color is used.
		/// </summary>
		// Token: 0x06005E77 RID: 24183 RVA: 0x00088E4C File Offset: 0x0008704C
		public virtual void GetAmbientColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkProperty.vtkProperty_GetAmbientColor_24(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06005E78 RID: 24184
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_GetAmbientColor_25(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the ambient surface color. Not all renderers support separate
		/// ambient and diffuse colors. From a physical standpoint it really
		/// doesn't make too much sense to have both. For the rendering
		/// libraries that don't support both, the diffuse color is used.
		/// </summary>
		// Token: 0x06005E79 RID: 24185 RVA: 0x00088E5E File Offset: 0x0008705E
		public virtual void GetAmbientColor(IntPtr _arg)
		{
			vtkProperty.vtkProperty_GetAmbientColor_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06005E7A RID: 24186
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetAmbientMaxValue_26(HandleRef pThis);

		/// <summary>
		/// Set/Get the ambient lighting coefficient.
		/// </summary>
		// Token: 0x06005E7B RID: 24187 RVA: 0x00088E70 File Offset: 0x00087070
		public virtual double GetAmbientMaxValue()
		{
			return vtkProperty.vtkProperty_GetAmbientMaxValue_26(base.GetCppThis());
		}

		// Token: 0x06005E7C RID: 24188
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetAmbientMinValue_27(HandleRef pThis);

		/// <summary>
		/// Set/Get the ambient lighting coefficient.
		/// </summary>
		// Token: 0x06005E7D RID: 24189 RVA: 0x00088E90 File Offset: 0x00087090
		public virtual double GetAmbientMinValue()
		{
			return vtkProperty.vtkProperty_GetAmbientMinValue_27(base.GetCppThis());
		}

		// Token: 0x06005E7E RID: 24190
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetAnisotropy_28(HandleRef pThis);

		/// <summary>
		/// Set/Get the anisotropy coefficient.
		/// This value controls the anisotropy of the material (0.0 means isotropic)
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 0.0
		/// </summary>
		// Token: 0x06005E7F RID: 24191 RVA: 0x00088EB0 File Offset: 0x000870B0
		public virtual double GetAnisotropy()
		{
			return vtkProperty.vtkProperty_GetAnisotropy_28(base.GetCppThis());
		}

		// Token: 0x06005E80 RID: 24192
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetAnisotropyMaxValue_29(HandleRef pThis);

		/// <summary>
		/// Set/Get the anisotropy coefficient.
		/// This value controls the anisotropy of the material (0.0 means isotropic)
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 0.0
		/// </summary>
		// Token: 0x06005E81 RID: 24193 RVA: 0x00088ED0 File Offset: 0x000870D0
		public virtual double GetAnisotropyMaxValue()
		{
			return vtkProperty.vtkProperty_GetAnisotropyMaxValue_29(base.GetCppThis());
		}

		// Token: 0x06005E82 RID: 24194
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetAnisotropyMinValue_30(HandleRef pThis);

		/// <summary>
		/// Set/Get the anisotropy coefficient.
		/// This value controls the anisotropy of the material (0.0 means isotropic)
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 0.0
		/// </summary>
		// Token: 0x06005E83 RID: 24195 RVA: 0x00088EF0 File Offset: 0x000870F0
		public virtual double GetAnisotropyMinValue()
		{
			return vtkProperty.vtkProperty_GetAnisotropyMinValue_30(base.GetCppThis());
		}

		// Token: 0x06005E84 RID: 24196
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetAnisotropyRotation_31(HandleRef pThis);

		/// <summary>
		/// Set/Get the anisotropy rotation coefficient.
		/// This value controls the rotation of the direction of the anisotropy.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 0.0
		/// </summary>
		// Token: 0x06005E85 RID: 24197 RVA: 0x00088F10 File Offset: 0x00087110
		public virtual double GetAnisotropyRotation()
		{
			return vtkProperty.vtkProperty_GetAnisotropyRotation_31(base.GetCppThis());
		}

		// Token: 0x06005E86 RID: 24198
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetAnisotropyRotationMaxValue_32(HandleRef pThis);

		/// <summary>
		/// Set/Get the anisotropy rotation coefficient.
		/// This value controls the rotation of the direction of the anisotropy.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 0.0
		/// </summary>
		// Token: 0x06005E87 RID: 24199 RVA: 0x00088F30 File Offset: 0x00087130
		public virtual double GetAnisotropyRotationMaxValue()
		{
			return vtkProperty.vtkProperty_GetAnisotropyRotationMaxValue_32(base.GetCppThis());
		}

		// Token: 0x06005E88 RID: 24200
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetAnisotropyRotationMinValue_33(HandleRef pThis);

		/// <summary>
		/// Set/Get the anisotropy rotation coefficient.
		/// This value controls the rotation of the direction of the anisotropy.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 0.0
		/// </summary>
		// Token: 0x06005E89 RID: 24201 RVA: 0x00088F50 File Offset: 0x00087150
		public virtual double GetAnisotropyRotationMinValue()
		{
			return vtkProperty.vtkProperty_GetAnisotropyRotationMinValue_33(base.GetCppThis());
		}

		// Token: 0x06005E8A RID: 24202
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProperty_GetBackfaceCulling_34(HandleRef pThis);

		/// <summary>
		/// Turn on/off fast culling of polygons based on orientation of normal
		/// with respect to camera. If backface culling is on, polygons facing
		/// away from camera are not drawn.
		/// </summary>
		// Token: 0x06005E8B RID: 24203 RVA: 0x00088F70 File Offset: 0x00087170
		public virtual int GetBackfaceCulling()
		{
			return vtkProperty.vtkProperty_GetBackfaceCulling_34(base.GetCppThis());
		}

		// Token: 0x06005E8C RID: 24204
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetBaseIOR_35(HandleRef pThis);

		/// <summary>
		/// Set/Get the Index Of Refraction of the base layer.
		/// It controls the amount of light reflected at normal incidence (the reflectance F0),
		/// depending on the IOR of the upper layer (eg. coat layer, or environment).
		/// For example, with a base IOR of 1.5 and an IOR of 1.0 outside (IOR of the air),
		/// 4% of the amount of the light is reflected at normal incidence.
		/// Notice that modifying this value is only useful for dielectrics materials, as
		/// the reflectance for metallic is the albedo.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 1.5
		/// </summary>
		// Token: 0x06005E8D RID: 24205 RVA: 0x00088F90 File Offset: 0x00087190
		public virtual double GetBaseIOR()
		{
			return vtkProperty.vtkProperty_GetBaseIOR_35(base.GetCppThis());
		}

		// Token: 0x06005E8E RID: 24206
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetBaseIORMaxValue_36(HandleRef pThis);

		/// <summary>
		/// Set/Get the Index Of Refraction of the base layer.
		/// It controls the amount of light reflected at normal incidence (the reflectance F0),
		/// depending on the IOR of the upper layer (eg. coat layer, or environment).
		/// For example, with a base IOR of 1.5 and an IOR of 1.0 outside (IOR of the air),
		/// 4% of the amount of the light is reflected at normal incidence.
		/// Notice that modifying this value is only useful for dielectrics materials, as
		/// the reflectance for metallic is the albedo.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 1.5
		/// </summary>
		// Token: 0x06005E8F RID: 24207 RVA: 0x00088FB0 File Offset: 0x000871B0
		public virtual double GetBaseIORMaxValue()
		{
			return vtkProperty.vtkProperty_GetBaseIORMaxValue_36(base.GetCppThis());
		}

		// Token: 0x06005E90 RID: 24208
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetBaseIORMinValue_37(HandleRef pThis);

		/// <summary>
		/// Set/Get the Index Of Refraction of the base layer.
		/// It controls the amount of light reflected at normal incidence (the reflectance F0),
		/// depending on the IOR of the upper layer (eg. coat layer, or environment).
		/// For example, with a base IOR of 1.5 and an IOR of 1.0 outside (IOR of the air),
		/// 4% of the amount of the light is reflected at normal incidence.
		/// Notice that modifying this value is only useful for dielectrics materials, as
		/// the reflectance for metallic is the albedo.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 1.5
		/// </summary>
		// Token: 0x06005E91 RID: 24209 RVA: 0x00088FD0 File Offset: 0x000871D0
		public virtual double GetBaseIORMinValue()
		{
			return vtkProperty.vtkProperty_GetBaseIORMinValue_37(base.GetCppThis());
		}

		// Token: 0x06005E92 RID: 24210
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProperty_GetCoatColor_38(HandleRef pThis);

		/// <summary>
		/// Set/Get the color of the coat layer.
		/// This value is only used by PBR Interpolation.
		/// Default value is white [1.0, 1.0, 1.0]
		/// </summary>
		// Token: 0x06005E93 RID: 24211 RVA: 0x00088FF0 File Offset: 0x000871F0
		public virtual double[] GetCoatColor()
		{
			IntPtr intPtr = vtkProperty.vtkProperty_GetCoatColor_38(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06005E94 RID: 24212
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_GetCoatColor_39(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the color of the coat layer.
		/// This value is only used by PBR Interpolation.
		/// Default value is white [1.0, 1.0, 1.0]
		/// </summary>
		// Token: 0x06005E95 RID: 24213 RVA: 0x00089038 File Offset: 0x00087238
		public virtual void GetCoatColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkProperty.vtkProperty_GetCoatColor_39(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06005E96 RID: 24214
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_GetCoatColor_40(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the color of the coat layer.
		/// This value is only used by PBR Interpolation.
		/// Default value is white [1.0, 1.0, 1.0]
		/// </summary>
		// Token: 0x06005E97 RID: 24215 RVA: 0x0008904A File Offset: 0x0008724A
		public virtual void GetCoatColor(IntPtr _arg)
		{
			vtkProperty.vtkProperty_GetCoatColor_40(base.GetCppThis(), _arg);
		}

		// Token: 0x06005E98 RID: 24216
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetCoatIOR_41(HandleRef pThis);

		/// <summary>
		/// Set/Get the coat layer Index Of Refraction.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 2.0
		/// </summary>
		// Token: 0x06005E99 RID: 24217 RVA: 0x0008905C File Offset: 0x0008725C
		public virtual double GetCoatIOR()
		{
			return vtkProperty.vtkProperty_GetCoatIOR_41(base.GetCppThis());
		}

		// Token: 0x06005E9A RID: 24218
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetCoatIORMaxValue_42(HandleRef pThis);

		/// <summary>
		/// Set/Get the coat layer Index Of Refraction.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 2.0
		/// </summary>
		// Token: 0x06005E9B RID: 24219 RVA: 0x0008907C File Offset: 0x0008727C
		public virtual double GetCoatIORMaxValue()
		{
			return vtkProperty.vtkProperty_GetCoatIORMaxValue_42(base.GetCppThis());
		}

		// Token: 0x06005E9C RID: 24220
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetCoatIORMinValue_43(HandleRef pThis);

		/// <summary>
		/// Set/Get the coat layer Index Of Refraction.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 2.0
		/// </summary>
		// Token: 0x06005E9D RID: 24221 RVA: 0x0008909C File Offset: 0x0008729C
		public virtual double GetCoatIORMinValue()
		{
			return vtkProperty.vtkProperty_GetCoatIORMinValue_43(base.GetCppThis());
		}

		// Token: 0x06005E9E RID: 24222
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetCoatNormalScale_44(HandleRef pThis);

		/// <summary>
		/// Set/Get the coat layer normal scale coefficient.
		/// This value affects the strength of the normal deviation from the coat normal texture.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 1.0
		/// </summary>
		// Token: 0x06005E9F RID: 24223 RVA: 0x000890BC File Offset: 0x000872BC
		public virtual double GetCoatNormalScale()
		{
			return vtkProperty.vtkProperty_GetCoatNormalScale_44(base.GetCppThis());
		}

		// Token: 0x06005EA0 RID: 24224
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetCoatNormalScaleMaxValue_45(HandleRef pThis);

		/// <summary>
		/// Set/Get the coat layer normal scale coefficient.
		/// This value affects the strength of the normal deviation from the coat normal texture.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 1.0
		/// </summary>
		// Token: 0x06005EA1 RID: 24225 RVA: 0x000890DC File Offset: 0x000872DC
		public virtual double GetCoatNormalScaleMaxValue()
		{
			return vtkProperty.vtkProperty_GetCoatNormalScaleMaxValue_45(base.GetCppThis());
		}

		// Token: 0x06005EA2 RID: 24226
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetCoatNormalScaleMinValue_46(HandleRef pThis);

		/// <summary>
		/// Set/Get the coat layer normal scale coefficient.
		/// This value affects the strength of the normal deviation from the coat normal texture.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 1.0
		/// </summary>
		// Token: 0x06005EA3 RID: 24227 RVA: 0x000890FC File Offset: 0x000872FC
		public virtual double GetCoatNormalScaleMinValue()
		{
			return vtkProperty.vtkProperty_GetCoatNormalScaleMinValue_46(base.GetCppThis());
		}

		// Token: 0x06005EA4 RID: 24228
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetCoatRoughness_47(HandleRef pThis);

		/// <summary>
		/// Set/Get the coat layer roughness coefficient.
		/// This value has to be between 0 (glossy) and 1 (rough).
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 0.0
		/// </summary>
		// Token: 0x06005EA5 RID: 24229 RVA: 0x0008911C File Offset: 0x0008731C
		public virtual double GetCoatRoughness()
		{
			return vtkProperty.vtkProperty_GetCoatRoughness_47(base.GetCppThis());
		}

		// Token: 0x06005EA6 RID: 24230
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetCoatRoughnessMaxValue_48(HandleRef pThis);

		/// <summary>
		/// Set/Get the coat layer roughness coefficient.
		/// This value has to be between 0 (glossy) and 1 (rough).
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 0.0
		/// </summary>
		// Token: 0x06005EA7 RID: 24231 RVA: 0x0008913C File Offset: 0x0008733C
		public virtual double GetCoatRoughnessMaxValue()
		{
			return vtkProperty.vtkProperty_GetCoatRoughnessMaxValue_48(base.GetCppThis());
		}

		// Token: 0x06005EA8 RID: 24232
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetCoatRoughnessMinValue_49(HandleRef pThis);

		/// <summary>
		/// Set/Get the coat layer roughness coefficient.
		/// This value has to be between 0 (glossy) and 1 (rough).
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 0.0
		/// </summary>
		// Token: 0x06005EA9 RID: 24233 RVA: 0x0008915C File Offset: 0x0008735C
		public virtual double GetCoatRoughnessMinValue()
		{
			return vtkProperty.vtkProperty_GetCoatRoughnessMinValue_49(base.GetCppThis());
		}

		// Token: 0x06005EAA RID: 24234
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetCoatStrength_50(HandleRef pThis);

		/// <summary>
		/// Set/Get the coat layer strength coefficient.
		/// This value affects the strength of the coat layer reflection.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 0.0
		/// </summary>
		// Token: 0x06005EAB RID: 24235 RVA: 0x0008917C File Offset: 0x0008737C
		public virtual double GetCoatStrength()
		{
			return vtkProperty.vtkProperty_GetCoatStrength_50(base.GetCppThis());
		}

		// Token: 0x06005EAC RID: 24236
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetCoatStrengthMaxValue_51(HandleRef pThis);

		/// <summary>
		/// Set/Get the coat layer strength coefficient.
		/// This value affects the strength of the coat layer reflection.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 0.0
		/// </summary>
		// Token: 0x06005EAD RID: 24237 RVA: 0x0008919C File Offset: 0x0008739C
		public virtual double GetCoatStrengthMaxValue()
		{
			return vtkProperty.vtkProperty_GetCoatStrengthMaxValue_51(base.GetCppThis());
		}

		// Token: 0x06005EAE RID: 24238
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetCoatStrengthMinValue_52(HandleRef pThis);

		/// <summary>
		/// Set/Get the coat layer strength coefficient.
		/// This value affects the strength of the coat layer reflection.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 0.0
		/// </summary>
		// Token: 0x06005EAF RID: 24239 RVA: 0x000891BC File Offset: 0x000873BC
		public virtual double GetCoatStrengthMinValue()
		{
			return vtkProperty.vtkProperty_GetCoatStrengthMinValue_52(base.GetCppThis());
		}

		// Token: 0x06005EB0 RID: 24240
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProperty_GetColor_53(HandleRef pThis);

		/// <summary>
		/// Set the color of the object. Has the side effect of setting the
		/// ambient diffuse and specular colors as well. This is basically
		/// a quick overall color setting method.
		/// </summary>
		// Token: 0x06005EB1 RID: 24241 RVA: 0x000891DC File Offset: 0x000873DC
		public double[] GetColor()
		{
			IntPtr intPtr = vtkProperty.vtkProperty_GetColor_53(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06005EB2 RID: 24242
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_GetColor_54(HandleRef pThis, IntPtr rgb);

		/// <summary>
		/// Set the color of the object. Has the side effect of setting the
		/// ambient diffuse and specular colors as well. This is basically
		/// a quick overall color setting method.
		/// </summary>
		// Token: 0x06005EB3 RID: 24243 RVA: 0x00089224 File Offset: 0x00087424
		public void GetColor(IntPtr rgb)
		{
			vtkProperty.vtkProperty_GetColor_54(base.GetCppThis(), rgb);
		}

		// Token: 0x06005EB4 RID: 24244
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_GetColor_55(HandleRef pThis, ref double r, ref double g, ref double b);

		/// <summary>
		/// Set the color of the object. Has the side effect of setting the
		/// ambient diffuse and specular colors as well. This is basically
		/// a quick overall color setting method.
		/// </summary>
		// Token: 0x06005EB5 RID: 24245 RVA: 0x00089234 File Offset: 0x00087434
		public void GetColor(ref double r, ref double g, ref double b)
		{
			vtkProperty.vtkProperty_GetColor_55(base.GetCppThis(), ref r, ref g, ref b);
		}

		// Token: 0x06005EB6 RID: 24246
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetDiffuse_56(HandleRef pThis);

		/// <summary>
		/// Set/Get the diffuse lighting coefficient.
		/// </summary>
		// Token: 0x06005EB7 RID: 24247 RVA: 0x00089248 File Offset: 0x00087448
		public virtual double GetDiffuse()
		{
			return vtkProperty.vtkProperty_GetDiffuse_56(base.GetCppThis());
		}

		// Token: 0x06005EB8 RID: 24248
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProperty_GetDiffuseColor_57(HandleRef pThis);

		/// <summary>
		/// Set/Get the diffuse surface color.
		/// For PBR Interpolation, DiffuseColor is used as the base color
		/// </summary>
		// Token: 0x06005EB9 RID: 24249 RVA: 0x00089268 File Offset: 0x00087468
		public virtual double[] GetDiffuseColor()
		{
			IntPtr intPtr = vtkProperty.vtkProperty_GetDiffuseColor_57(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06005EBA RID: 24250
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_GetDiffuseColor_58(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the diffuse surface color.
		/// For PBR Interpolation, DiffuseColor is used as the base color
		/// </summary>
		// Token: 0x06005EBB RID: 24251 RVA: 0x000892B0 File Offset: 0x000874B0
		public virtual void GetDiffuseColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkProperty.vtkProperty_GetDiffuseColor_58(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06005EBC RID: 24252
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_GetDiffuseColor_59(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the diffuse surface color.
		/// For PBR Interpolation, DiffuseColor is used as the base color
		/// </summary>
		// Token: 0x06005EBD RID: 24253 RVA: 0x000892C2 File Offset: 0x000874C2
		public virtual void GetDiffuseColor(IntPtr _arg)
		{
			vtkProperty.vtkProperty_GetDiffuseColor_59(base.GetCppThis(), _arg);
		}

		// Token: 0x06005EBE RID: 24254
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetDiffuseMaxValue_60(HandleRef pThis);

		/// <summary>
		/// Set/Get the diffuse lighting coefficient.
		/// </summary>
		// Token: 0x06005EBF RID: 24255 RVA: 0x000892D4 File Offset: 0x000874D4
		public virtual double GetDiffuseMaxValue()
		{
			return vtkProperty.vtkProperty_GetDiffuseMaxValue_60(base.GetCppThis());
		}

		// Token: 0x06005EC0 RID: 24256
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetDiffuseMinValue_61(HandleRef pThis);

		/// <summary>
		/// Set/Get the diffuse lighting coefficient.
		/// </summary>
		// Token: 0x06005EC1 RID: 24257 RVA: 0x000892F4 File Offset: 0x000874F4
		public virtual double GetDiffuseMinValue()
		{
			return vtkProperty.vtkProperty_GetDiffuseMinValue_61(base.GetCppThis());
		}

		// Token: 0x06005EC2 RID: 24258
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProperty_GetEdgeColor_62(HandleRef pThis);

		/// <summary>
		/// Set/Get the color of primitive edges (if edge visibility is enabled).
		/// </summary>
		// Token: 0x06005EC3 RID: 24259 RVA: 0x00089314 File Offset: 0x00087514
		public virtual double[] GetEdgeColor()
		{
			IntPtr intPtr = vtkProperty.vtkProperty_GetEdgeColor_62(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06005EC4 RID: 24260
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_GetEdgeColor_63(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the color of primitive edges (if edge visibility is enabled).
		/// </summary>
		// Token: 0x06005EC5 RID: 24261 RVA: 0x0008935C File Offset: 0x0008755C
		public virtual void GetEdgeColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkProperty.vtkProperty_GetEdgeColor_63(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06005EC6 RID: 24262
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_GetEdgeColor_64(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the color of primitive edges (if edge visibility is enabled).
		/// </summary>
		// Token: 0x06005EC7 RID: 24263 RVA: 0x0008936E File Offset: 0x0008756E
		public virtual void GetEdgeColor(IntPtr _arg)
		{
			vtkProperty.vtkProperty_GetEdgeColor_64(base.GetCppThis(), _arg);
		}

		// Token: 0x06005EC8 RID: 24264
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetEdgeOpacity_65(HandleRef pThis);

		/// <summary>
		/// Set/Get the line opacity. 1.0 is totally opaque and 0.0 is completely
		/// transparent.
		/// </summary>
		// Token: 0x06005EC9 RID: 24265 RVA: 0x00089380 File Offset: 0x00087580
		public virtual double GetEdgeOpacity()
		{
			return vtkProperty.vtkProperty_GetEdgeOpacity_65(base.GetCppThis());
		}

		// Token: 0x06005ECA RID: 24266
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetEdgeOpacityMaxValue_66(HandleRef pThis);

		/// <summary>
		/// Set/Get the line opacity. 1.0 is totally opaque and 0.0 is completely
		/// transparent.
		/// </summary>
		// Token: 0x06005ECB RID: 24267 RVA: 0x000893A0 File Offset: 0x000875A0
		public virtual double GetEdgeOpacityMaxValue()
		{
			return vtkProperty.vtkProperty_GetEdgeOpacityMaxValue_66(base.GetCppThis());
		}

		// Token: 0x06005ECC RID: 24268
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetEdgeOpacityMinValue_67(HandleRef pThis);

		/// <summary>
		/// Set/Get the line opacity. 1.0 is totally opaque and 0.0 is completely
		/// transparent.
		/// </summary>
		// Token: 0x06005ECD RID: 24269 RVA: 0x000893C0 File Offset: 0x000875C0
		public virtual double GetEdgeOpacityMinValue()
		{
			return vtkProperty.vtkProperty_GetEdgeOpacityMinValue_67(base.GetCppThis());
		}

		// Token: 0x06005ECE RID: 24270
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProperty_GetEdgeTint_68(HandleRef pThis);

		/// <summary>
		/// Set/Get the edge tint (for metals only).
		/// Set the color at grazing angle (fresnel reflectance).
		/// This parameter is only used by PBR Interpolation.
		/// Default value is [1.0, 1.0, 1.0]
		/// </summary>
		// Token: 0x06005ECF RID: 24271 RVA: 0x000893E0 File Offset: 0x000875E0
		public virtual double[] GetEdgeTint()
		{
			IntPtr intPtr = vtkProperty.vtkProperty_GetEdgeTint_68(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06005ED0 RID: 24272
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_GetEdgeTint_69(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the edge tint (for metals only).
		/// Set the color at grazing angle (fresnel reflectance).
		/// This parameter is only used by PBR Interpolation.
		/// Default value is [1.0, 1.0, 1.0]
		/// </summary>
		// Token: 0x06005ED1 RID: 24273 RVA: 0x00089428 File Offset: 0x00087628
		public virtual void GetEdgeTint(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkProperty.vtkProperty_GetEdgeTint_69(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06005ED2 RID: 24274
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_GetEdgeTint_70(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the edge tint (for metals only).
		/// Set the color at grazing angle (fresnel reflectance).
		/// This parameter is only used by PBR Interpolation.
		/// Default value is [1.0, 1.0, 1.0]
		/// </summary>
		// Token: 0x06005ED3 RID: 24275 RVA: 0x0008943A File Offset: 0x0008763A
		public virtual void GetEdgeTint(IntPtr _arg)
		{
			vtkProperty.vtkProperty_GetEdgeTint_70(base.GetCppThis(), _arg);
		}

		// Token: 0x06005ED4 RID: 24276
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProperty_GetEdgeVisibility_71(HandleRef pThis);

		/// <summary>
		/// Turn on/off the visibility of edges. On some renderers it is
		/// possible to render the edges of geometric primitives separately
		/// from the interior.
		/// </summary>
		// Token: 0x06005ED5 RID: 24277 RVA: 0x0008944C File Offset: 0x0008764C
		public virtual int GetEdgeVisibility()
		{
			return vtkProperty.vtkProperty_GetEdgeVisibility_71(base.GetCppThis());
		}

		// Token: 0x06005ED6 RID: 24278
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProperty_GetEmissiveFactor_72(HandleRef pThis);

		/// <summary>
		/// Set/Get the emissive factor.
		/// This value is multiplied with the emissive color when an emissive texture is present.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is [1.0, 1.0, 1.0]
		/// </summary>
		// Token: 0x06005ED7 RID: 24279 RVA: 0x0008946C File Offset: 0x0008766C
		public virtual double[] GetEmissiveFactor()
		{
			IntPtr intPtr = vtkProperty.vtkProperty_GetEmissiveFactor_72(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06005ED8 RID: 24280
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_GetEmissiveFactor_73(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the emissive factor.
		/// This value is multiplied with the emissive color when an emissive texture is present.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is [1.0, 1.0, 1.0]
		/// </summary>
		// Token: 0x06005ED9 RID: 24281 RVA: 0x000894B4 File Offset: 0x000876B4
		public virtual void GetEmissiveFactor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkProperty.vtkProperty_GetEmissiveFactor_73(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06005EDA RID: 24282
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_GetEmissiveFactor_74(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the emissive factor.
		/// This value is multiplied with the emissive color when an emissive texture is present.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is [1.0, 1.0, 1.0]
		/// </summary>
		// Token: 0x06005EDB RID: 24283 RVA: 0x000894C6 File Offset: 0x000876C6
		public virtual void GetEmissiveFactor(IntPtr _arg)
		{
			vtkProperty.vtkProperty_GetEmissiveFactor_74(base.GetCppThis(), _arg);
		}

		// Token: 0x06005EDC RID: 24284
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProperty_GetFrontfaceCulling_75(HandleRef pThis);

		/// <summary>
		/// Turn on/off fast culling of polygons based on orientation of normal
		/// with respect to camera. If frontface culling is on, polygons facing
		/// towards camera are not drawn.
		/// </summary>
		// Token: 0x06005EDD RID: 24285 RVA: 0x000894D8 File Offset: 0x000876D8
		public virtual int GetFrontfaceCulling()
		{
			return vtkProperty.vtkProperty_GetFrontfaceCulling_75(base.GetCppThis());
		}

		// Token: 0x06005EDE RID: 24286
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProperty_GetInformation_76(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the information object associated with the Property.
		/// </summary>
		// Token: 0x06005EDF RID: 24287 RVA: 0x000894F8 File Offset: 0x000876F8
		public virtual vtkInformation GetInformation()
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProperty.vtkProperty_GetInformation_76(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06005EE0 RID: 24288
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProperty_GetInterpolation_77(HandleRef pThis);

		/// <summary>
		/// Set the shading interpolation method for an object.
		/// </summary>
		// Token: 0x06005EE1 RID: 24289 RVA: 0x00089568 File Offset: 0x00087768
		public virtual int GetInterpolation()
		{
			return vtkProperty.vtkProperty_GetInterpolation_77(base.GetCppThis());
		}

		// Token: 0x06005EE2 RID: 24290
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProperty_GetInterpolationAsString_78(HandleRef pThis);

		/// <summary>
		/// Set the shading interpolation method for an object.
		/// </summary>
		// Token: 0x06005EE3 RID: 24291 RVA: 0x00089588 File Offset: 0x00087788
		public string GetInterpolationAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkProperty.vtkProperty_GetInterpolationAsString_78(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005EE4 RID: 24292
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProperty_GetInterpolationMaxValue_79(HandleRef pThis);

		/// <summary>
		/// Set the shading interpolation method for an object.
		/// </summary>
		// Token: 0x06005EE5 RID: 24293 RVA: 0x000895C4 File Offset: 0x000877C4
		public virtual int GetInterpolationMaxValue()
		{
			return vtkProperty.vtkProperty_GetInterpolationMaxValue_79(base.GetCppThis());
		}

		// Token: 0x06005EE6 RID: 24294
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProperty_GetInterpolationMinValue_80(HandleRef pThis);

		/// <summary>
		/// Set the shading interpolation method for an object.
		/// </summary>
		// Token: 0x06005EE7 RID: 24295 RVA: 0x000895E4 File Offset: 0x000877E4
		public virtual int GetInterpolationMinValue()
		{
			return vtkProperty.vtkProperty_GetInterpolationMinValue_80(base.GetCppThis());
		}

		// Token: 0x06005EE8 RID: 24296
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkProperty_GetLighting_81(HandleRef pThis);

		/// <summary>
		/// Set/Get lighting flag for an object. Initial value is true.
		/// </summary>
		// Token: 0x06005EE9 RID: 24297 RVA: 0x00089604 File Offset: 0x00087804
		public virtual bool GetLighting()
		{
			return vtkProperty.vtkProperty_GetLighting_81(base.GetCppThis()) != 0;
		}

		// Token: 0x06005EEA RID: 24298
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProperty_GetLineStipplePattern_82(HandleRef pThis);

		/// <summary>
		/// Set/Get the stippling pattern of a Line, as a 16-bit binary pattern
		/// (1 = pixel on, 0 = pixel off).
		/// This is only implemented for OpenGL, not OpenGL2. The default is 0xFFFF.
		/// </summary>
		// Token: 0x06005EEB RID: 24299 RVA: 0x0008962C File Offset: 0x0008782C
		public virtual int GetLineStipplePattern()
		{
			return vtkProperty.vtkProperty_GetLineStipplePattern_82(base.GetCppThis());
		}

		// Token: 0x06005EEC RID: 24300
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProperty_GetLineStippleRepeatFactor_83(HandleRef pThis);

		/// <summary>
		/// Set/Get the stippling repeat factor of a Line, which specifies how
		/// many times each bit in the pattern is to be repeated.
		/// This is only implemented for OpenGL, not OpenGL2. The default is 1.
		/// </summary>
		// Token: 0x06005EED RID: 24301 RVA: 0x0008964C File Offset: 0x0008784C
		public virtual int GetLineStippleRepeatFactor()
		{
			return vtkProperty.vtkProperty_GetLineStippleRepeatFactor_83(base.GetCppThis());
		}

		// Token: 0x06005EEE RID: 24302
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProperty_GetLineStippleRepeatFactorMaxValue_84(HandleRef pThis);

		/// <summary>
		/// Set/Get the stippling repeat factor of a Line, which specifies how
		/// many times each bit in the pattern is to be repeated.
		/// This is only implemented for OpenGL, not OpenGL2. The default is 1.
		/// </summary>
		// Token: 0x06005EEF RID: 24303 RVA: 0x0008966C File Offset: 0x0008786C
		public virtual int GetLineStippleRepeatFactorMaxValue()
		{
			return vtkProperty.vtkProperty_GetLineStippleRepeatFactorMaxValue_84(base.GetCppThis());
		}

		// Token: 0x06005EF0 RID: 24304
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProperty_GetLineStippleRepeatFactorMinValue_85(HandleRef pThis);

		/// <summary>
		/// Set/Get the stippling repeat factor of a Line, which specifies how
		/// many times each bit in the pattern is to be repeated.
		/// This is only implemented for OpenGL, not OpenGL2. The default is 1.
		/// </summary>
		// Token: 0x06005EF1 RID: 24305 RVA: 0x0008968C File Offset: 0x0008788C
		public virtual int GetLineStippleRepeatFactorMinValue()
		{
			return vtkProperty.vtkProperty_GetLineStippleRepeatFactorMinValue_85(base.GetCppThis());
		}

		// Token: 0x06005EF2 RID: 24306
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkProperty_GetLineWidth_86(HandleRef pThis);

		/// <summary>
		/// Set/Get the width of a Line. The width is expressed in screen units.
		/// This is only implemented for OpenGL. The default is 1.0.
		/// </summary>
		// Token: 0x06005EF3 RID: 24307 RVA: 0x000896AC File Offset: 0x000878AC
		public virtual float GetLineWidth()
		{
			return vtkProperty.vtkProperty_GetLineWidth_86(base.GetCppThis());
		}

		// Token: 0x06005EF4 RID: 24308
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkProperty_GetLineWidthMaxValue_87(HandleRef pThis);

		/// <summary>
		/// Set/Get the width of a Line. The width is expressed in screen units.
		/// This is only implemented for OpenGL. The default is 1.0.
		/// </summary>
		// Token: 0x06005EF5 RID: 24309 RVA: 0x000896CC File Offset: 0x000878CC
		public virtual float GetLineWidthMaxValue()
		{
			return vtkProperty.vtkProperty_GetLineWidthMaxValue_87(base.GetCppThis());
		}

		// Token: 0x06005EF6 RID: 24310
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkProperty_GetLineWidthMinValue_88(HandleRef pThis);

		/// <summary>
		/// Set/Get the width of a Line. The width is expressed in screen units.
		/// This is only implemented for OpenGL. The default is 1.0.
		/// </summary>
		// Token: 0x06005EF7 RID: 24311 RVA: 0x000896EC File Offset: 0x000878EC
		public virtual float GetLineWidthMinValue()
		{
			return vtkProperty.vtkProperty_GetLineWidthMinValue_88(base.GetCppThis());
		}

		// Token: 0x06005EF8 RID: 24312
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProperty_GetMaterialName_89(HandleRef pThis);

		/// <summary>
		/// Returns the name of the material currently loaded, if any.
		/// </summary>
		// Token: 0x06005EF9 RID: 24313 RVA: 0x0008970C File Offset: 0x0008790C
		public virtual string GetMaterialName()
		{
			string s = Marshal.PtrToStringAnsi(vtkProperty.vtkProperty_GetMaterialName_89(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005EFA RID: 24314
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetMetallic_90(HandleRef pThis);

		/// <summary>
		/// Set/Get the metallic coefficient.
		/// Usually this value is either 0 or 1 for real material but any value in between is valid.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 0.0
		/// </summary>
		// Token: 0x06005EFB RID: 24315 RVA: 0x00089748 File Offset: 0x00087948
		public virtual double GetMetallic()
		{
			return vtkProperty.vtkProperty_GetMetallic_90(base.GetCppThis());
		}

		// Token: 0x06005EFC RID: 24316
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetMetallicMaxValue_91(HandleRef pThis);

		/// <summary>
		/// Set/Get the metallic coefficient.
		/// Usually this value is either 0 or 1 for real material but any value in between is valid.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 0.0
		/// </summary>
		// Token: 0x06005EFD RID: 24317 RVA: 0x00089768 File Offset: 0x00087968
		public virtual double GetMetallicMaxValue()
		{
			return vtkProperty.vtkProperty_GetMetallicMaxValue_91(base.GetCppThis());
		}

		// Token: 0x06005EFE RID: 24318
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetMetallicMinValue_92(HandleRef pThis);

		/// <summary>
		/// Set/Get the metallic coefficient.
		/// Usually this value is either 0 or 1 for real material but any value in between is valid.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 0.0
		/// </summary>
		// Token: 0x06005EFF RID: 24319 RVA: 0x00089788 File Offset: 0x00087988
		public virtual double GetMetallicMinValue()
		{
			return vtkProperty.vtkProperty_GetMetallicMinValue_92(base.GetCppThis());
		}

		// Token: 0x06005F00 RID: 24320
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetNormalScale_93(HandleRef pThis);

		/// <summary>
		/// Set/Get the normal scale coefficient.
		/// This value affects the strength of the normal deviation from the texture.
		/// Default value is 1.0
		/// </summary>
		// Token: 0x06005F01 RID: 24321 RVA: 0x000897A8 File Offset: 0x000879A8
		public virtual double GetNormalScale()
		{
			return vtkProperty.vtkProperty_GetNormalScale_93(base.GetCppThis());
		}

		// Token: 0x06005F02 RID: 24322
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProperty_GetNumberOfGenerationsFromBase_94(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005F03 RID: 24323 RVA: 0x000897C8 File Offset: 0x000879C8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProperty.vtkProperty_GetNumberOfGenerationsFromBase_94(base.GetCppThis(), type);
		}

		// Token: 0x06005F04 RID: 24324
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProperty_GetNumberOfGenerationsFromBaseType_95([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005F05 RID: 24325 RVA: 0x000897E8 File Offset: 0x000879E8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProperty.vtkProperty_GetNumberOfGenerationsFromBaseType_95(type);
		}

		// Token: 0x06005F06 RID: 24326
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProperty_GetNumberOfTextures_96(HandleRef pThis);

		/// <summary>
		/// Returns the number of textures in this property.
		/// </summary>
		// Token: 0x06005F07 RID: 24327 RVA: 0x00089804 File Offset: 0x00087A04
		public int GetNumberOfTextures()
		{
			return vtkProperty.vtkProperty_GetNumberOfTextures_96(base.GetCppThis());
		}

		// Token: 0x06005F08 RID: 24328
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetOcclusionStrength_97(HandleRef pThis);

		/// <summary>
		/// Set/Get the occlusion strength coefficient.
		/// This value affects the strength of the occlusion if a material texture is present.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 1.0
		/// </summary>
		// Token: 0x06005F09 RID: 24329 RVA: 0x00089824 File Offset: 0x00087A24
		public virtual double GetOcclusionStrength()
		{
			return vtkProperty.vtkProperty_GetOcclusionStrength_97(base.GetCppThis());
		}

		// Token: 0x06005F0A RID: 24330
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetOcclusionStrengthMaxValue_98(HandleRef pThis);

		/// <summary>
		/// Set/Get the occlusion strength coefficient.
		/// This value affects the strength of the occlusion if a material texture is present.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 1.0
		/// </summary>
		// Token: 0x06005F0B RID: 24331 RVA: 0x00089844 File Offset: 0x00087A44
		public virtual double GetOcclusionStrengthMaxValue()
		{
			return vtkProperty.vtkProperty_GetOcclusionStrengthMaxValue_98(base.GetCppThis());
		}

		// Token: 0x06005F0C RID: 24332
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetOcclusionStrengthMinValue_99(HandleRef pThis);

		/// <summary>
		/// Set/Get the occlusion strength coefficient.
		/// This value affects the strength of the occlusion if a material texture is present.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 1.0
		/// </summary>
		// Token: 0x06005F0D RID: 24333 RVA: 0x00089864 File Offset: 0x00087A64
		public virtual double GetOcclusionStrengthMinValue()
		{
			return vtkProperty.vtkProperty_GetOcclusionStrengthMinValue_99(base.GetCppThis());
		}

		// Token: 0x06005F0E RID: 24334
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetOpacity_100(HandleRef pThis);

		/// <summary>
		/// Set/Get the object's opacity. 1.0 is totally opaque and 0.0 is completely
		/// transparent.
		/// </summary>
		// Token: 0x06005F0F RID: 24335 RVA: 0x00089884 File Offset: 0x00087A84
		public virtual double GetOpacity()
		{
			return vtkProperty.vtkProperty_GetOpacity_100(base.GetCppThis());
		}

		// Token: 0x06005F10 RID: 24336
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetOpacityMaxValue_101(HandleRef pThis);

		/// <summary>
		/// Set/Get the object's opacity. 1.0 is totally opaque and 0.0 is completely
		/// transparent.
		/// </summary>
		// Token: 0x06005F11 RID: 24337 RVA: 0x000898A4 File Offset: 0x00087AA4
		public virtual double GetOpacityMaxValue()
		{
			return vtkProperty.vtkProperty_GetOpacityMaxValue_101(base.GetCppThis());
		}

		// Token: 0x06005F12 RID: 24338
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetOpacityMinValue_102(HandleRef pThis);

		/// <summary>
		/// Set/Get the object's opacity. 1.0 is totally opaque and 0.0 is completely
		/// transparent.
		/// </summary>
		// Token: 0x06005F13 RID: 24339 RVA: 0x000898C4 File Offset: 0x00087AC4
		public virtual double GetOpacityMinValue()
		{
			return vtkProperty.vtkProperty_GetOpacityMinValue_102(base.GetCppThis());
		}

		// Token: 0x06005F14 RID: 24340
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkProperty_GetPointSize_103(HandleRef pThis);

		/// <summary>
		/// Set/Get the diameter of a point. The size is expressed in screen units.
		/// This is only implemented for OpenGL. The default is 1.0.
		/// </summary>
		// Token: 0x06005F15 RID: 24341 RVA: 0x000898E4 File Offset: 0x00087AE4
		public virtual float GetPointSize()
		{
			return vtkProperty.vtkProperty_GetPointSize_103(base.GetCppThis());
		}

		// Token: 0x06005F16 RID: 24342
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkProperty_GetPointSizeMaxValue_104(HandleRef pThis);

		/// <summary>
		/// Set/Get the diameter of a point. The size is expressed in screen units.
		/// This is only implemented for OpenGL. The default is 1.0.
		/// </summary>
		// Token: 0x06005F17 RID: 24343 RVA: 0x00089904 File Offset: 0x00087B04
		public virtual float GetPointSizeMaxValue()
		{
			return vtkProperty.vtkProperty_GetPointSizeMaxValue_104(base.GetCppThis());
		}

		// Token: 0x06005F18 RID: 24344
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkProperty_GetPointSizeMinValue_105(HandleRef pThis);

		/// <summary>
		/// Set/Get the diameter of a point. The size is expressed in screen units.
		/// This is only implemented for OpenGL. The default is 1.0.
		/// </summary>
		// Token: 0x06005F19 RID: 24345 RVA: 0x00089924 File Offset: 0x00087B24
		public virtual float GetPointSizeMinValue()
		{
			return vtkProperty.vtkProperty_GetPointSizeMinValue_105(base.GetCppThis());
		}

		// Token: 0x06005F1A RID: 24346
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkProperty_GetRenderLinesAsTubes_106(HandleRef pThis);

		/// <summary>
		/// Set/Get rendering of lines as tubes. The width of the
		/// line in pixels is controlled by the LineWidth
		/// attribute. May not be supported on every platform
		/// and the implementation may be half tubes, or something
		/// only tube like in appearance.
		/// </summary>
		// Token: 0x06005F1B RID: 24347 RVA: 0x00089944 File Offset: 0x00087B44
		public virtual bool GetRenderLinesAsTubes()
		{
			return vtkProperty.vtkProperty_GetRenderLinesAsTubes_106(base.GetCppThis()) != 0;
		}

		// Token: 0x06005F1C RID: 24348
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkProperty_GetRenderPointsAsSpheres_107(HandleRef pThis);

		/// <summary>
		/// Set/Get rendering of points as spheres. The size of the
		/// sphere in pixels is controlled by the PointSize
		/// attribute. Note that half spheres may be rendered
		/// instead of spheres.
		/// </summary>
		// Token: 0x06005F1D RID: 24349 RVA: 0x0008996C File Offset: 0x00087B6C
		public virtual bool GetRenderPointsAsSpheres()
		{
			return vtkProperty.vtkProperty_GetRenderPointsAsSpheres_107(base.GetCppThis()) != 0;
		}

		// Token: 0x06005F1E RID: 24350
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProperty_GetRepresentation_108(HandleRef pThis);

		/// <summary>
		/// Control the surface geometry representation for the object.
		/// </summary>
		// Token: 0x06005F1F RID: 24351 RVA: 0x00089994 File Offset: 0x00087B94
		public virtual int GetRepresentation()
		{
			return vtkProperty.vtkProperty_GetRepresentation_108(base.GetCppThis());
		}

		// Token: 0x06005F20 RID: 24352
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProperty_GetRepresentationAsString_109(HandleRef pThis);

		/// <summary>
		/// Control the surface geometry representation for the object.
		/// </summary>
		// Token: 0x06005F21 RID: 24353 RVA: 0x000899B4 File Offset: 0x00087BB4
		public string GetRepresentationAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkProperty.vtkProperty_GetRepresentationAsString_109(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005F22 RID: 24354
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProperty_GetRepresentationMaxValue_110(HandleRef pThis);

		/// <summary>
		/// Control the surface geometry representation for the object.
		/// </summary>
		// Token: 0x06005F23 RID: 24355 RVA: 0x000899F0 File Offset: 0x00087BF0
		public virtual int GetRepresentationMaxValue()
		{
			return vtkProperty.vtkProperty_GetRepresentationMaxValue_110(base.GetCppThis());
		}

		// Token: 0x06005F24 RID: 24356
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProperty_GetRepresentationMinValue_111(HandleRef pThis);

		/// <summary>
		/// Control the surface geometry representation for the object.
		/// </summary>
		// Token: 0x06005F25 RID: 24357 RVA: 0x00089A10 File Offset: 0x00087C10
		public virtual int GetRepresentationMinValue()
		{
			return vtkProperty.vtkProperty_GetRepresentationMinValue_111(base.GetCppThis());
		}

		// Token: 0x06005F26 RID: 24358
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetRoughness_112(HandleRef pThis);

		/// <summary>
		/// Set/Get the roughness coefficient.
		/// This value has to be between 0 (glossy) and 1 (rough).
		/// A glossy material has reflections and a high specular part.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 0.5
		/// </summary>
		// Token: 0x06005F27 RID: 24359 RVA: 0x00089A30 File Offset: 0x00087C30
		public virtual double GetRoughness()
		{
			return vtkProperty.vtkProperty_GetRoughness_112(base.GetCppThis());
		}

		// Token: 0x06005F28 RID: 24360
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetRoughnessMaxValue_113(HandleRef pThis);

		/// <summary>
		/// Set/Get the roughness coefficient.
		/// This value has to be between 0 (glossy) and 1 (rough).
		/// A glossy material has reflections and a high specular part.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 0.5
		/// </summary>
		// Token: 0x06005F29 RID: 24361 RVA: 0x00089A50 File Offset: 0x00087C50
		public virtual double GetRoughnessMaxValue()
		{
			return vtkProperty.vtkProperty_GetRoughnessMaxValue_113(base.GetCppThis());
		}

		// Token: 0x06005F2A RID: 24362
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetRoughnessMinValue_114(HandleRef pThis);

		/// <summary>
		/// Set/Get the roughness coefficient.
		/// This value has to be between 0 (glossy) and 1 (rough).
		/// A glossy material has reflections and a high specular part.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 0.5
		/// </summary>
		// Token: 0x06005F2B RID: 24363 RVA: 0x00089A70 File Offset: 0x00087C70
		public virtual double GetRoughnessMinValue()
		{
			return vtkProperty.vtkProperty_GetRoughnessMinValue_114(base.GetCppThis());
		}

		// Token: 0x06005F2C RID: 24364
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProperty_GetSelectionColor_115(HandleRef pThis);

		/// <summary>
		/// Set/Get the RGBA color of selection primitives (if a selection is active on the mapper).
		/// Default is red and opaque.
		/// </summary>
		// Token: 0x06005F2D RID: 24365 RVA: 0x00089A90 File Offset: 0x00087C90
		public virtual double[] GetSelectionColor()
		{
			IntPtr intPtr = vtkProperty.vtkProperty_GetSelectionColor_115(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06005F2E RID: 24366
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_GetSelectionColor_116(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		/// <summary>
		/// Set/Get the RGBA color of selection primitives (if a selection is active on the mapper).
		/// Default is red and opaque.
		/// </summary>
		// Token: 0x06005F2F RID: 24367 RVA: 0x00089AD8 File Offset: 0x00087CD8
		public virtual void GetSelectionColor(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkProperty.vtkProperty_GetSelectionColor_116(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x06005F30 RID: 24368
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_GetSelectionColor_117(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the RGBA color of selection primitives (if a selection is active on the mapper).
		/// Default is red and opaque.
		/// </summary>
		// Token: 0x06005F31 RID: 24369 RVA: 0x00089AEC File Offset: 0x00087CEC
		public virtual void GetSelectionColor(IntPtr _arg)
		{
			vtkProperty.vtkProperty_GetSelectionColor_117(base.GetCppThis(), _arg);
		}

		// Token: 0x06005F32 RID: 24370
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkProperty_GetSelectionLineWidth_118(HandleRef pThis);

		/// <summary>
		/// Set/Get the selection line width.
		/// Default is 2.
		/// </summary>
		// Token: 0x06005F33 RID: 24371 RVA: 0x00089AFC File Offset: 0x00087CFC
		public virtual float GetSelectionLineWidth()
		{
			return vtkProperty.vtkProperty_GetSelectionLineWidth_118(base.GetCppThis());
		}

		// Token: 0x06005F34 RID: 24372
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkProperty_GetSelectionPointSize_119(HandleRef pThis);

		/// <summary>
		/// Set/Get the selection point size.
		/// Default is 2.
		/// </summary>
		// Token: 0x06005F35 RID: 24373 RVA: 0x00089B1C File Offset: 0x00087D1C
		public virtual float GetSelectionPointSize()
		{
			return vtkProperty.vtkProperty_GetSelectionPointSize_119(base.GetCppThis());
		}

		// Token: 0x06005F36 RID: 24374
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProperty_GetShading_120(HandleRef pThis);

		/// <summary>
		/// Enable/Disable shading. When shading is enabled, the
		/// Material must be set.
		/// </summary>
		// Token: 0x06005F37 RID: 24375 RVA: 0x00089B3C File Offset: 0x00087D3C
		public virtual int GetShading()
		{
			return vtkProperty.vtkProperty_GetShading_120(base.GetCppThis());
		}

		// Token: 0x06005F38 RID: 24376
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkProperty_GetShowTexturesOnBackface_121(HandleRef pThis);

		/// <summary>
		/// Show texture maps when the geometry is backfacing. Texture maps are
		/// always shown when frontfacing. By default this is true.
		/// </summary>
		// Token: 0x06005F39 RID: 24377 RVA: 0x00089B5C File Offset: 0x00087D5C
		public virtual bool GetShowTexturesOnBackface()
		{
			return vtkProperty.vtkProperty_GetShowTexturesOnBackface_121(base.GetCppThis()) != 0;
		}

		// Token: 0x06005F3A RID: 24378
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetSpecular_122(HandleRef pThis);

		/// <summary>
		/// Set/Get the specular lighting coefficient.
		/// </summary>
		// Token: 0x06005F3B RID: 24379 RVA: 0x00089B84 File Offset: 0x00087D84
		public virtual double GetSpecular()
		{
			return vtkProperty.vtkProperty_GetSpecular_122(base.GetCppThis());
		}

		// Token: 0x06005F3C RID: 24380
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProperty_GetSpecularColor_123(HandleRef pThis);

		/// <summary>
		/// Set/Get the specular surface color.
		/// </summary>
		// Token: 0x06005F3D RID: 24381 RVA: 0x00089BA4 File Offset: 0x00087DA4
		public virtual double[] GetSpecularColor()
		{
			IntPtr intPtr = vtkProperty.vtkProperty_GetSpecularColor_123(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06005F3E RID: 24382
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_GetSpecularColor_124(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the specular surface color.
		/// </summary>
		// Token: 0x06005F3F RID: 24383 RVA: 0x00089BEC File Offset: 0x00087DEC
		public virtual void GetSpecularColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkProperty.vtkProperty_GetSpecularColor_124(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06005F40 RID: 24384
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_GetSpecularColor_125(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the specular surface color.
		/// </summary>
		// Token: 0x06005F41 RID: 24385 RVA: 0x00089BFE File Offset: 0x00087DFE
		public virtual void GetSpecularColor(IntPtr _arg)
		{
			vtkProperty.vtkProperty_GetSpecularColor_125(base.GetCppThis(), _arg);
		}

		// Token: 0x06005F42 RID: 24386
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetSpecularMaxValue_126(HandleRef pThis);

		/// <summary>
		/// Set/Get the specular lighting coefficient.
		/// </summary>
		// Token: 0x06005F43 RID: 24387 RVA: 0x00089C10 File Offset: 0x00087E10
		public virtual double GetSpecularMaxValue()
		{
			return vtkProperty.vtkProperty_GetSpecularMaxValue_126(base.GetCppThis());
		}

		// Token: 0x06005F44 RID: 24388
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetSpecularMinValue_127(HandleRef pThis);

		/// <summary>
		/// Set/Get the specular lighting coefficient.
		/// </summary>
		// Token: 0x06005F45 RID: 24389 RVA: 0x00089C30 File Offset: 0x00087E30
		public virtual double GetSpecularMinValue()
		{
			return vtkProperty.vtkProperty_GetSpecularMinValue_127(base.GetCppThis());
		}

		// Token: 0x06005F46 RID: 24390
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetSpecularPower_128(HandleRef pThis);

		/// <summary>
		/// Set/Get the specular power.
		/// </summary>
		// Token: 0x06005F47 RID: 24391 RVA: 0x00089C50 File Offset: 0x00087E50
		public virtual double GetSpecularPower()
		{
			return vtkProperty.vtkProperty_GetSpecularPower_128(base.GetCppThis());
		}

		// Token: 0x06005F48 RID: 24392
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetSpecularPowerMaxValue_129(HandleRef pThis);

		/// <summary>
		/// Set/Get the specular power.
		/// </summary>
		// Token: 0x06005F49 RID: 24393 RVA: 0x00089C70 File Offset: 0x00087E70
		public virtual double GetSpecularPowerMaxValue()
		{
			return vtkProperty.vtkProperty_GetSpecularPowerMaxValue_129(base.GetCppThis());
		}

		// Token: 0x06005F4A RID: 24394
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProperty_GetSpecularPowerMinValue_130(HandleRef pThis);

		/// <summary>
		/// Set/Get the specular power.
		/// </summary>
		// Token: 0x06005F4B RID: 24395 RVA: 0x00089C90 File Offset: 0x00087E90
		public virtual double GetSpecularPowerMinValue()
		{
			return vtkProperty.vtkProperty_GetSpecularPowerMinValue_130(base.GetCppThis());
		}

		// Token: 0x06005F4C RID: 24396
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProperty_GetTexture_131(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the texture object to control rendering texture maps. This will
		/// be a vtkTexture object. A property does not need to have an associated
		/// texture map and multiple properties can share one texture. Textures
		/// must be assigned unique names. Note that for texture blending the
		/// textures will be rendering is alphabetical order and after any texture
		/// defined in the actor.
		/// There exists 6 special textures with reserved names: "albedoTex", "materialTex", "normalTex",
		/// "emissiveTex", "anisotropyTex" and "coatNormalTex". While these textures can be added with the
		/// regular SetTexture method, it is preferred to use the methods SetBaseColorTexture,
		/// SetORMTexture, SetNormalTexture, SetEmissiveTexture, SetAnisotropyTexture and SetCoatNormalTex
		/// respectively.
		/// </summary>
		// Token: 0x06005F4D RID: 24397 RVA: 0x00089CB0 File Offset: 0x00087EB0
		public vtkTexture GetTexture(string name)
		{
			vtkTexture vtkTexture = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProperty.vtkProperty_GetTexture_131(base.GetCppThis(), name, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTexture = (vtkTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTexture.Register(null);
				}
			}
			return vtkTexture;
		}

		// Token: 0x06005F4E RID: 24398
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProperty_GetVertexColor_132(HandleRef pThis);

		/// <summary>
		/// Set/Get the color of primitive vertices (if vertex visibility is enabled).
		/// </summary>
		// Token: 0x06005F4F RID: 24399 RVA: 0x00089D20 File Offset: 0x00087F20
		public virtual double[] GetVertexColor()
		{
			IntPtr intPtr = vtkProperty.vtkProperty_GetVertexColor_132(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06005F50 RID: 24400
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_GetVertexColor_133(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the color of primitive vertices (if vertex visibility is enabled).
		/// </summary>
		// Token: 0x06005F51 RID: 24401 RVA: 0x00089D68 File Offset: 0x00087F68
		public virtual void GetVertexColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkProperty.vtkProperty_GetVertexColor_133(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06005F52 RID: 24402
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_GetVertexColor_134(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the color of primitive vertices (if vertex visibility is enabled).
		/// </summary>
		// Token: 0x06005F53 RID: 24403 RVA: 0x00089D7A File Offset: 0x00087F7A
		public virtual void GetVertexColor(IntPtr _arg)
		{
			vtkProperty.vtkProperty_GetVertexColor_134(base.GetCppThis(), _arg);
		}

		// Token: 0x06005F54 RID: 24404
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProperty_GetVertexVisibility_135(HandleRef pThis);

		/// <summary>
		/// Turn on/off the visibility of vertices. On some renderers it is
		/// possible to render the vertices of geometric primitives separately
		/// from the interior.
		/// </summary>
		// Token: 0x06005F55 RID: 24405 RVA: 0x00089D8C File Offset: 0x00087F8C
		public virtual int GetVertexVisibility()
		{
			return vtkProperty.vtkProperty_GetVertexVisibility_135(base.GetCppThis());
		}

		// Token: 0x06005F56 RID: 24406
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProperty_IsA_136(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005F57 RID: 24407 RVA: 0x00089DAC File Offset: 0x00087FAC
		public override int IsA(string type)
		{
			return vtkProperty.vtkProperty_IsA_136(base.GetCppThis(), type);
		}

		// Token: 0x06005F58 RID: 24408
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProperty_IsTypeOf_137([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005F59 RID: 24409 RVA: 0x00089DCC File Offset: 0x00087FCC
		public new static int IsTypeOf(string type)
		{
			return vtkProperty.vtkProperty_IsTypeOf_137(type);
		}

		// Token: 0x06005F5A RID: 24410
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_LightingOff_138(HandleRef pThis);

		/// <summary>
		/// Set/Get lighting flag for an object. Initial value is true.
		/// </summary>
		// Token: 0x06005F5B RID: 24411 RVA: 0x00089DE6 File Offset: 0x00087FE6
		public virtual void LightingOff()
		{
			vtkProperty.vtkProperty_LightingOff_138(base.GetCppThis());
		}

		// Token: 0x06005F5C RID: 24412
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_LightingOn_139(HandleRef pThis);

		/// <summary>
		/// Set/Get lighting flag for an object. Initial value is true.
		/// </summary>
		// Token: 0x06005F5D RID: 24413 RVA: 0x00089DF5 File Offset: 0x00087FF5
		public virtual void LightingOn()
		{
			vtkProperty.vtkProperty_LightingOn_139(base.GetCppThis());
		}

		// Token: 0x06005F5E RID: 24414
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProperty_NewInstance_141(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005F5F RID: 24415 RVA: 0x00089E04 File Offset: 0x00088004
		public new vtkProperty NewInstance()
		{
			vtkProperty result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProperty.vtkProperty_NewInstance_141(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005F60 RID: 24416
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_PostRender_142(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// This method is called after the actor has been rendered.
		/// Don't call this directly. This method cleans up
		/// any shaders allocated.
		/// </summary>
		// Token: 0x06005F61 RID: 24417 RVA: 0x00089E60 File Offset: 0x00088060
		public virtual void PostRender(vtkActor arg0, vtkRenderer arg1)
		{
			vtkProperty.vtkProperty_PostRender_142(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06005F62 RID: 24418
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_ReleaseGraphicsResources_143(HandleRef pThis, HandleRef win);

		/// <summary>
		/// Release any graphics resources that are being consumed by this
		/// property. The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x06005F63 RID: 24419 RVA: 0x00089EA4 File Offset: 0x000880A4
		public virtual void ReleaseGraphicsResources(vtkWindow win)
		{
			vtkProperty.vtkProperty_ReleaseGraphicsResources_143(base.GetCppThis(), (win == null) ? default(HandleRef) : win.GetCppThis());
		}

		// Token: 0x06005F64 RID: 24420
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_RemoveAllTextures_144(HandleRef pThis);

		/// <summary>
		/// Remove all the textures.
		/// </summary>
		// Token: 0x06005F65 RID: 24421 RVA: 0x00089ED3 File Offset: 0x000880D3
		public void RemoveAllTextures()
		{
			vtkProperty.vtkProperty_RemoveAllTextures_144(base.GetCppThis());
		}

		// Token: 0x06005F66 RID: 24422
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_RemoveTexture_145(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Remove a texture from the collection.
		/// </summary>
		// Token: 0x06005F67 RID: 24423 RVA: 0x00089EE2 File Offset: 0x000880E2
		public void RemoveTexture(string name)
		{
			vtkProperty.vtkProperty_RemoveTexture_145(base.GetCppThis(), name);
		}

		// Token: 0x06005F68 RID: 24424
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_Render_146(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// This method causes the property to set up whatever is required for
		/// its instance variables. This is actually handled by a subclass of
		/// vtkProperty, which is created automatically. This
		/// method includes the invoking actor as an argument which can
		/// be used by property devices that require the actor.
		/// </summary>
		// Token: 0x06005F69 RID: 24425 RVA: 0x00089EF4 File Offset: 0x000880F4
		public virtual void Render(vtkActor arg0, vtkRenderer arg1)
		{
			vtkProperty.vtkProperty_Render_146(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06005F6A RID: 24426
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_RenderLinesAsTubesOff_147(HandleRef pThis);

		/// <summary>
		/// Set/Get rendering of lines as tubes. The width of the
		/// line in pixels is controlled by the LineWidth
		/// attribute. May not be supported on every platform
		/// and the implementation may be half tubes, or something
		/// only tube like in appearance.
		/// </summary>
		// Token: 0x06005F6B RID: 24427 RVA: 0x00089F38 File Offset: 0x00088138
		public virtual void RenderLinesAsTubesOff()
		{
			vtkProperty.vtkProperty_RenderLinesAsTubesOff_147(base.GetCppThis());
		}

		// Token: 0x06005F6C RID: 24428
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_RenderLinesAsTubesOn_148(HandleRef pThis);

		/// <summary>
		/// Set/Get rendering of lines as tubes. The width of the
		/// line in pixels is controlled by the LineWidth
		/// attribute. May not be supported on every platform
		/// and the implementation may be half tubes, or something
		/// only tube like in appearance.
		/// </summary>
		// Token: 0x06005F6D RID: 24429 RVA: 0x00089F47 File Offset: 0x00088147
		public virtual void RenderLinesAsTubesOn()
		{
			vtkProperty.vtkProperty_RenderLinesAsTubesOn_148(base.GetCppThis());
		}

		// Token: 0x06005F6E RID: 24430
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_RenderPointsAsSpheresOff_149(HandleRef pThis);

		/// <summary>
		/// Set/Get rendering of points as spheres. The size of the
		/// sphere in pixels is controlled by the PointSize
		/// attribute. Note that half spheres may be rendered
		/// instead of spheres.
		/// </summary>
		// Token: 0x06005F6F RID: 24431 RVA: 0x00089F56 File Offset: 0x00088156
		public virtual void RenderPointsAsSpheresOff()
		{
			vtkProperty.vtkProperty_RenderPointsAsSpheresOff_149(base.GetCppThis());
		}

		// Token: 0x06005F70 RID: 24432
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_RenderPointsAsSpheresOn_150(HandleRef pThis);

		/// <summary>
		/// Set/Get rendering of points as spheres. The size of the
		/// sphere in pixels is controlled by the PointSize
		/// attribute. Note that half spheres may be rendered
		/// instead of spheres.
		/// </summary>
		// Token: 0x06005F71 RID: 24433 RVA: 0x00089F65 File Offset: 0x00088165
		public virtual void RenderPointsAsSpheresOn()
		{
			vtkProperty.vtkProperty_RenderPointsAsSpheresOn_150(base.GetCppThis());
		}

		// Token: 0x06005F72 RID: 24434
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProperty_SafeDownCast_151(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005F73 RID: 24435 RVA: 0x00089F74 File Offset: 0x00088174
		public new static vtkProperty SafeDownCast(vtkObjectBase o)
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProperty.vtkProperty_SafeDownCast_151((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x06005F74 RID: 24436
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetAmbient_152(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the ambient lighting coefficient.
		/// </summary>
		// Token: 0x06005F75 RID: 24437 RVA: 0x00089FF3 File Offset: 0x000881F3
		public virtual void SetAmbient(double _arg)
		{
			vtkProperty.vtkProperty_SetAmbient_152(base.GetCppThis(), _arg);
		}

		// Token: 0x06005F76 RID: 24438
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetAmbientColor_153(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the ambient surface color. Not all renderers support separate
		/// ambient and diffuse colors. From a physical standpoint it really
		/// doesn't make too much sense to have both. For the rendering
		/// libraries that don't support both, the diffuse color is used.
		/// </summary>
		// Token: 0x06005F77 RID: 24439 RVA: 0x0008A003 File Offset: 0x00088203
		public virtual void SetAmbientColor(double _arg1, double _arg2, double _arg3)
		{
			vtkProperty.vtkProperty_SetAmbientColor_153(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06005F78 RID: 24440
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetAmbientColor_154(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the ambient surface color. Not all renderers support separate
		/// ambient and diffuse colors. From a physical standpoint it really
		/// doesn't make too much sense to have both. For the rendering
		/// libraries that don't support both, the diffuse color is used.
		/// </summary>
		// Token: 0x06005F79 RID: 24441 RVA: 0x0008A015 File Offset: 0x00088215
		public virtual void SetAmbientColor(IntPtr _arg)
		{
			vtkProperty.vtkProperty_SetAmbientColor_154(base.GetCppThis(), _arg);
		}

		// Token: 0x06005F7A RID: 24442
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetAnisotropy_155(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the anisotropy coefficient.
		/// This value controls the anisotropy of the material (0.0 means isotropic)
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 0.0
		/// </summary>
		// Token: 0x06005F7B RID: 24443 RVA: 0x0008A025 File Offset: 0x00088225
		public virtual void SetAnisotropy(double _arg)
		{
			vtkProperty.vtkProperty_SetAnisotropy_155(base.GetCppThis(), _arg);
		}

		// Token: 0x06005F7C RID: 24444
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetAnisotropyRotation_156(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the anisotropy rotation coefficient.
		/// This value controls the rotation of the direction of the anisotropy.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 0.0
		/// </summary>
		// Token: 0x06005F7D RID: 24445 RVA: 0x0008A035 File Offset: 0x00088235
		public virtual void SetAnisotropyRotation(double _arg)
		{
			vtkProperty.vtkProperty_SetAnisotropyRotation_156(base.GetCppThis(), _arg);
		}

		// Token: 0x06005F7E RID: 24446
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetAnisotropyTexture_157(HandleRef pThis, HandleRef texture);

		/// <summary>
		/// Set the anisotropy texture. This texture contains two independent components corresponding to
		/// the anisotropy value and anisotropy rotation. The last component (blue channel) is discarded.
		/// The anisotropy value is scaled by the anisotropy coefficient of the material. The anisotropy
		/// rotation rotates the direction of the anisotropy (ie. the tangent) around the normal and is not
		/// scaled by the anisotropy rotation coefficient.
		/// This texture must be in linear color space.
		/// This is only used by the PBR shading model.
		/// @sa SetInterpolationToPBR SetAnisotropy
		/// </summary>
		// Token: 0x06005F7F RID: 24447 RVA: 0x0008A048 File Offset: 0x00088248
		public void SetAnisotropyTexture(vtkTexture texture)
		{
			vtkProperty.vtkProperty_SetAnisotropyTexture_157(base.GetCppThis(), (texture == null) ? default(HandleRef) : texture.GetCppThis());
		}

		// Token: 0x06005F80 RID: 24448
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetBackfaceCulling_158(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off fast culling of polygons based on orientation of normal
		/// with respect to camera. If backface culling is on, polygons facing
		/// away from camera are not drawn.
		/// </summary>
		// Token: 0x06005F81 RID: 24449 RVA: 0x0008A077 File Offset: 0x00088277
		public virtual void SetBackfaceCulling(int _arg)
		{
			vtkProperty.vtkProperty_SetBackfaceCulling_158(base.GetCppThis(), _arg);
		}

		// Token: 0x06005F82 RID: 24450
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetBaseColorTexture_159(HandleRef pThis, HandleRef texture);

		/// <summary>
		/// Set the base color texture. Also called albedo, this texture is only used while rendering
		/// with PBR interpolation. This is the color of the object.
		/// This texture must be in sRGB color space.
		/// @sa SetInterpolationToPBR vtkTexture::UseSRGBColorSpaceOn
		/// </summary>
		// Token: 0x06005F83 RID: 24451 RVA: 0x0008A088 File Offset: 0x00088288
		public void SetBaseColorTexture(vtkTexture texture)
		{
			vtkProperty.vtkProperty_SetBaseColorTexture_159(base.GetCppThis(), (texture == null) ? default(HandleRef) : texture.GetCppThis());
		}

		// Token: 0x06005F84 RID: 24452
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetBaseIOR_160(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the Index Of Refraction of the base layer.
		/// It controls the amount of light reflected at normal incidence (the reflectance F0),
		/// depending on the IOR of the upper layer (eg. coat layer, or environment).
		/// For example, with a base IOR of 1.5 and an IOR of 1.0 outside (IOR of the air),
		/// 4% of the amount of the light is reflected at normal incidence.
		/// Notice that modifying this value is only useful for dielectrics materials, as
		/// the reflectance for metallic is the albedo.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 1.5
		/// </summary>
		// Token: 0x06005F85 RID: 24453 RVA: 0x0008A0B7 File Offset: 0x000882B7
		public virtual void SetBaseIOR(double _arg)
		{
			vtkProperty.vtkProperty_SetBaseIOR_160(base.GetCppThis(), _arg);
		}

		// Token: 0x06005F86 RID: 24454
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetCoatColor_161(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the color of the coat layer.
		/// This value is only used by PBR Interpolation.
		/// Default value is white [1.0, 1.0, 1.0]
		/// </summary>
		// Token: 0x06005F87 RID: 24455 RVA: 0x0008A0C7 File Offset: 0x000882C7
		public virtual void SetCoatColor(double _arg1, double _arg2, double _arg3)
		{
			vtkProperty.vtkProperty_SetCoatColor_161(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06005F88 RID: 24456
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetCoatColor_162(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the color of the coat layer.
		/// This value is only used by PBR Interpolation.
		/// Default value is white [1.0, 1.0, 1.0]
		/// </summary>
		// Token: 0x06005F89 RID: 24457 RVA: 0x0008A0D9 File Offset: 0x000882D9
		public virtual void SetCoatColor(IntPtr _arg)
		{
			vtkProperty.vtkProperty_SetCoatColor_162(base.GetCppThis(), _arg);
		}

		// Token: 0x06005F8A RID: 24458
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetCoatIOR_163(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the coat layer Index Of Refraction.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 2.0
		/// </summary>
		// Token: 0x06005F8B RID: 24459 RVA: 0x0008A0E9 File Offset: 0x000882E9
		public virtual void SetCoatIOR(double _arg)
		{
			vtkProperty.vtkProperty_SetCoatIOR_163(base.GetCppThis(), _arg);
		}

		// Token: 0x06005F8C RID: 24460
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetCoatNormalScale_164(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the coat layer normal scale coefficient.
		/// This value affects the strength of the normal deviation from the coat normal texture.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 1.0
		/// </summary>
		// Token: 0x06005F8D RID: 24461 RVA: 0x0008A0F9 File Offset: 0x000882F9
		public virtual void SetCoatNormalScale(double _arg)
		{
			vtkProperty.vtkProperty_SetCoatNormalScale_164(base.GetCppThis(), _arg);
		}

		// Token: 0x06005F8E RID: 24462
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetCoatNormalTexture_165(HandleRef pThis, HandleRef texture);

		/// <summary>
		/// Set the coat normal texture. This texture is required for coat normal mapping.
		/// It is valid only for PBR interpolation.
		/// The coat normal mapping is enabled if this texture is present and both normals and tangents are
		/// presents in the vtkPolyData.
		/// This texture must be in linear color space.
		/// @sa vtkPolyDataTangents SetCoatNormalScale
		/// </summary>
		// Token: 0x06005F8F RID: 24463 RVA: 0x0008A10C File Offset: 0x0008830C
		public void SetCoatNormalTexture(vtkTexture texture)
		{
			vtkProperty.vtkProperty_SetCoatNormalTexture_165(base.GetCppThis(), (texture == null) ? default(HandleRef) : texture.GetCppThis());
		}

		// Token: 0x06005F90 RID: 24464
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetCoatRoughness_166(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the coat layer roughness coefficient.
		/// This value has to be between 0 (glossy) and 1 (rough).
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 0.0
		/// </summary>
		// Token: 0x06005F91 RID: 24465 RVA: 0x0008A13B File Offset: 0x0008833B
		public virtual void SetCoatRoughness(double _arg)
		{
			vtkProperty.vtkProperty_SetCoatRoughness_166(base.GetCppThis(), _arg);
		}

		// Token: 0x06005F92 RID: 24466
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetCoatStrength_167(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the coat layer strength coefficient.
		/// This value affects the strength of the coat layer reflection.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 0.0
		/// </summary>
		// Token: 0x06005F93 RID: 24467 RVA: 0x0008A14B File Offset: 0x0008834B
		public virtual void SetCoatStrength(double _arg)
		{
			vtkProperty.vtkProperty_SetCoatStrength_167(base.GetCppThis(), _arg);
		}

		// Token: 0x06005F94 RID: 24468
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetColor_168(HandleRef pThis, double r, double g, double b);

		/// <summary>
		/// Set the color of the object. Has the side effect of setting the
		/// ambient diffuse and specular colors as well. This is basically
		/// a quick overall color setting method.
		/// </summary>
		// Token: 0x06005F95 RID: 24469 RVA: 0x0008A15B File Offset: 0x0008835B
		public virtual void SetColor(double r, double g, double b)
		{
			vtkProperty.vtkProperty_SetColor_168(base.GetCppThis(), r, g, b);
		}

		// Token: 0x06005F96 RID: 24470
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetColor_169(HandleRef pThis, IntPtr a);

		/// <summary>
		/// Set the color of the object. Has the side effect of setting the
		/// ambient diffuse and specular colors as well. This is basically
		/// a quick overall color setting method.
		/// </summary>
		// Token: 0x06005F97 RID: 24471 RVA: 0x0008A16D File Offset: 0x0008836D
		public virtual void SetColor(IntPtr a)
		{
			vtkProperty.vtkProperty_SetColor_169(base.GetCppThis(), a);
		}

		// Token: 0x06005F98 RID: 24472
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetDiffuse_170(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the diffuse lighting coefficient.
		/// </summary>
		// Token: 0x06005F99 RID: 24473 RVA: 0x0008A17D File Offset: 0x0008837D
		public virtual void SetDiffuse(double _arg)
		{
			vtkProperty.vtkProperty_SetDiffuse_170(base.GetCppThis(), _arg);
		}

		// Token: 0x06005F9A RID: 24474
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetDiffuseColor_171(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the diffuse surface color.
		/// For PBR Interpolation, DiffuseColor is used as the base color
		/// </summary>
		// Token: 0x06005F9B RID: 24475 RVA: 0x0008A18D File Offset: 0x0008838D
		public virtual void SetDiffuseColor(double _arg1, double _arg2, double _arg3)
		{
			vtkProperty.vtkProperty_SetDiffuseColor_171(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06005F9C RID: 24476
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetDiffuseColor_172(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the diffuse surface color.
		/// For PBR Interpolation, DiffuseColor is used as the base color
		/// </summary>
		// Token: 0x06005F9D RID: 24477 RVA: 0x0008A19F File Offset: 0x0008839F
		public virtual void SetDiffuseColor(IntPtr _arg)
		{
			vtkProperty.vtkProperty_SetDiffuseColor_172(base.GetCppThis(), _arg);
		}

		// Token: 0x06005F9E RID: 24478
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetEdgeColor_173(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the color of primitive edges (if edge visibility is enabled).
		/// </summary>
		// Token: 0x06005F9F RID: 24479 RVA: 0x0008A1AF File Offset: 0x000883AF
		public virtual void SetEdgeColor(double _arg1, double _arg2, double _arg3)
		{
			vtkProperty.vtkProperty_SetEdgeColor_173(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06005FA0 RID: 24480
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetEdgeColor_174(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the color of primitive edges (if edge visibility is enabled).
		/// </summary>
		// Token: 0x06005FA1 RID: 24481 RVA: 0x0008A1C1 File Offset: 0x000883C1
		public virtual void SetEdgeColor(IntPtr _arg)
		{
			vtkProperty.vtkProperty_SetEdgeColor_174(base.GetCppThis(), _arg);
		}

		// Token: 0x06005FA2 RID: 24482
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetEdgeOpacity_175(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the line opacity. 1.0 is totally opaque and 0.0 is completely
		/// transparent.
		/// </summary>
		// Token: 0x06005FA3 RID: 24483 RVA: 0x0008A1D1 File Offset: 0x000883D1
		public virtual void SetEdgeOpacity(double _arg)
		{
			vtkProperty.vtkProperty_SetEdgeOpacity_175(base.GetCppThis(), _arg);
		}

		// Token: 0x06005FA4 RID: 24484
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetEdgeTint_176(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the edge tint (for metals only).
		/// Set the color at grazing angle (fresnel reflectance).
		/// This parameter is only used by PBR Interpolation.
		/// Default value is [1.0, 1.0, 1.0]
		/// </summary>
		// Token: 0x06005FA5 RID: 24485 RVA: 0x0008A1E1 File Offset: 0x000883E1
		public virtual void SetEdgeTint(double _arg1, double _arg2, double _arg3)
		{
			vtkProperty.vtkProperty_SetEdgeTint_176(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06005FA6 RID: 24486
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetEdgeTint_177(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the edge tint (for metals only).
		/// Set the color at grazing angle (fresnel reflectance).
		/// This parameter is only used by PBR Interpolation.
		/// Default value is [1.0, 1.0, 1.0]
		/// </summary>
		// Token: 0x06005FA7 RID: 24487 RVA: 0x0008A1F3 File Offset: 0x000883F3
		public virtual void SetEdgeTint(IntPtr _arg)
		{
			vtkProperty.vtkProperty_SetEdgeTint_177(base.GetCppThis(), _arg);
		}

		// Token: 0x06005FA8 RID: 24488
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetEdgeVisibility_178(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the visibility of edges. On some renderers it is
		/// possible to render the edges of geometric primitives separately
		/// from the interior.
		/// </summary>
		// Token: 0x06005FA9 RID: 24489 RVA: 0x0008A203 File Offset: 0x00088403
		public virtual void SetEdgeVisibility(int _arg)
		{
			vtkProperty.vtkProperty_SetEdgeVisibility_178(base.GetCppThis(), _arg);
		}

		// Token: 0x06005FAA RID: 24490
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetEmissiveFactor_179(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the emissive factor.
		/// This value is multiplied with the emissive color when an emissive texture is present.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is [1.0, 1.0, 1.0]
		/// </summary>
		// Token: 0x06005FAB RID: 24491 RVA: 0x0008A213 File Offset: 0x00088413
		public virtual void SetEmissiveFactor(double _arg1, double _arg2, double _arg3)
		{
			vtkProperty.vtkProperty_SetEmissiveFactor_179(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06005FAC RID: 24492
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetEmissiveFactor_180(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the emissive factor.
		/// This value is multiplied with the emissive color when an emissive texture is present.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is [1.0, 1.0, 1.0]
		/// </summary>
		// Token: 0x06005FAD RID: 24493 RVA: 0x0008A225 File Offset: 0x00088425
		public virtual void SetEmissiveFactor(IntPtr _arg)
		{
			vtkProperty.vtkProperty_SetEmissiveFactor_180(base.GetCppThis(), _arg);
		}

		// Token: 0x06005FAE RID: 24494
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetEmissiveTexture_181(HandleRef pThis, HandleRef texture);

		/// <summary>
		/// Set the emissive texture. When present, this RGB texture provides location and color to the
		/// shader where the vtkPolyData should emit light. Emitted light is scaled by EmissiveFactor.
		/// This is only supported by PBR interpolation model.
		/// This texture must be in sRGB color space.
		/// @sa SetInterpolationToPBR SetEmissiveFactor vtkTexture::UseSRGBColorSpaceOn
		/// </summary>
		// Token: 0x06005FAF RID: 24495 RVA: 0x0008A238 File Offset: 0x00088438
		public void SetEmissiveTexture(vtkTexture texture)
		{
			vtkProperty.vtkProperty_SetEmissiveTexture_181(base.GetCppThis(), (texture == null) ? default(HandleRef) : texture.GetCppThis());
		}

		// Token: 0x06005FB0 RID: 24496
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetFrontfaceCulling_182(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off fast culling of polygons based on orientation of normal
		/// with respect to camera. If frontface culling is on, polygons facing
		/// towards camera are not drawn.
		/// </summary>
		// Token: 0x06005FB1 RID: 24497 RVA: 0x0008A267 File Offset: 0x00088467
		public virtual void SetFrontfaceCulling(int _arg)
		{
			vtkProperty.vtkProperty_SetFrontfaceCulling_182(base.GetCppThis(), _arg);
		}

		// Token: 0x06005FB2 RID: 24498
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetInformation_183(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the information object associated with the Property.
		/// </summary>
		// Token: 0x06005FB3 RID: 24499 RVA: 0x0008A278 File Offset: 0x00088478
		public virtual void SetInformation(vtkInformation arg0)
		{
			vtkProperty.vtkProperty_SetInformation_183(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06005FB4 RID: 24500
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetInterpolation_184(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the shading interpolation method for an object.
		/// </summary>
		// Token: 0x06005FB5 RID: 24501 RVA: 0x0008A2A7 File Offset: 0x000884A7
		public virtual void SetInterpolation(int _arg)
		{
			vtkProperty.vtkProperty_SetInterpolation_184(base.GetCppThis(), _arg);
		}

		// Token: 0x06005FB6 RID: 24502
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetInterpolationToFlat_185(HandleRef pThis);

		/// <summary>
		/// Set the shading interpolation method for an object.
		/// </summary>
		// Token: 0x06005FB7 RID: 24503 RVA: 0x0008A2B7 File Offset: 0x000884B7
		public void SetInterpolationToFlat()
		{
			vtkProperty.vtkProperty_SetInterpolationToFlat_185(base.GetCppThis());
		}

		// Token: 0x06005FB8 RID: 24504
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetInterpolationToGouraud_186(HandleRef pThis);

		/// <summary>
		/// Set the shading interpolation method for an object.
		/// </summary>
		// Token: 0x06005FB9 RID: 24505 RVA: 0x0008A2C6 File Offset: 0x000884C6
		public void SetInterpolationToGouraud()
		{
			vtkProperty.vtkProperty_SetInterpolationToGouraud_186(base.GetCppThis());
		}

		// Token: 0x06005FBA RID: 24506
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetInterpolationToPBR_187(HandleRef pThis);

		/// <summary>
		/// Set the shading interpolation method for an object.
		/// </summary>
		// Token: 0x06005FBB RID: 24507 RVA: 0x0008A2D5 File Offset: 0x000884D5
		public void SetInterpolationToPBR()
		{
			vtkProperty.vtkProperty_SetInterpolationToPBR_187(base.GetCppThis());
		}

		// Token: 0x06005FBC RID: 24508
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetInterpolationToPhong_188(HandleRef pThis);

		/// <summary>
		/// Set the shading interpolation method for an object.
		/// </summary>
		// Token: 0x06005FBD RID: 24509 RVA: 0x0008A2E4 File Offset: 0x000884E4
		public void SetInterpolationToPhong()
		{
			vtkProperty.vtkProperty_SetInterpolationToPhong_188(base.GetCppThis());
		}

		// Token: 0x06005FBE RID: 24510
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetLighting_189(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get lighting flag for an object. Initial value is true.
		/// </summary>
		// Token: 0x06005FBF RID: 24511 RVA: 0x0008A2F3 File Offset: 0x000884F3
		public virtual void SetLighting(bool _arg)
		{
			vtkProperty.vtkProperty_SetLighting_189(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005FC0 RID: 24512
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetLineStipplePattern_190(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the stippling pattern of a Line, as a 16-bit binary pattern
		/// (1 = pixel on, 0 = pixel off).
		/// This is only implemented for OpenGL, not OpenGL2. The default is 0xFFFF.
		/// </summary>
		// Token: 0x06005FC1 RID: 24513 RVA: 0x0008A30B File Offset: 0x0008850B
		public virtual void SetLineStipplePattern(int _arg)
		{
			vtkProperty.vtkProperty_SetLineStipplePattern_190(base.GetCppThis(), _arg);
		}

		// Token: 0x06005FC2 RID: 24514
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetLineStippleRepeatFactor_191(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the stippling repeat factor of a Line, which specifies how
		/// many times each bit in the pattern is to be repeated.
		/// This is only implemented for OpenGL, not OpenGL2. The default is 1.
		/// </summary>
		// Token: 0x06005FC3 RID: 24515 RVA: 0x0008A31B File Offset: 0x0008851B
		public virtual void SetLineStippleRepeatFactor(int _arg)
		{
			vtkProperty.vtkProperty_SetLineStippleRepeatFactor_191(base.GetCppThis(), _arg);
		}

		// Token: 0x06005FC4 RID: 24516
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetLineWidth_192(HandleRef pThis, float _arg);

		/// <summary>
		/// Set/Get the width of a Line. The width is expressed in screen units.
		/// This is only implemented for OpenGL. The default is 1.0.
		/// </summary>
		// Token: 0x06005FC5 RID: 24517 RVA: 0x0008A32B File Offset: 0x0008852B
		public virtual void SetLineWidth(float _arg)
		{
			vtkProperty.vtkProperty_SetLineWidth_192(base.GetCppThis(), _arg);
		}

		// Token: 0x06005FC6 RID: 24518
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetMaterialName_193(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Returns the name of the material currently loaded, if any.
		/// </summary>
		// Token: 0x06005FC7 RID: 24519 RVA: 0x0008A33B File Offset: 0x0008853B
		public virtual void SetMaterialName(string _arg)
		{
			vtkProperty.vtkProperty_SetMaterialName_193(base.GetCppThis(), _arg);
		}

		// Token: 0x06005FC8 RID: 24520
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetMetallic_194(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the metallic coefficient.
		/// Usually this value is either 0 or 1 for real material but any value in between is valid.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 0.0
		/// </summary>
		// Token: 0x06005FC9 RID: 24521 RVA: 0x0008A34B File Offset: 0x0008854B
		public virtual void SetMetallic(double _arg)
		{
			vtkProperty.vtkProperty_SetMetallic_194(base.GetCppThis(), _arg);
		}

		// Token: 0x06005FCA RID: 24522
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetNormalScale_195(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the normal scale coefficient.
		/// This value affects the strength of the normal deviation from the texture.
		/// Default value is 1.0
		/// </summary>
		// Token: 0x06005FCB RID: 24523 RVA: 0x0008A35B File Offset: 0x0008855B
		public virtual void SetNormalScale(double _arg)
		{
			vtkProperty.vtkProperty_SetNormalScale_195(base.GetCppThis(), _arg);
		}

		// Token: 0x06005FCC RID: 24524
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetNormalTexture_196(HandleRef pThis, HandleRef texture);

		/// <summary>
		/// Set the normal texture. This texture is required for normal mapping. It is valid for both PBR
		/// and Phong interpolation.
		/// The normal mapping is enabled if this texture is present and both normals and tangents are
		/// presents in the vtkPolyData.
		/// This texture must be in linear color space.
		/// @sa vtkPolyDataTangents SetNormalScale
		/// </summary>
		// Token: 0x06005FCD RID: 24525 RVA: 0x0008A36C File Offset: 0x0008856C
		public void SetNormalTexture(vtkTexture texture)
		{
			vtkProperty.vtkProperty_SetNormalTexture_196(base.GetCppThis(), (texture == null) ? default(HandleRef) : texture.GetCppThis());
		}

		// Token: 0x06005FCE RID: 24526
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetORMTexture_197(HandleRef pThis, HandleRef texture);

		/// <summary>
		/// Set the ORM texture. This texture contains three RGB independent components corresponding to
		/// the Occlusion value, Roughness value and Metallic value respectively.
		/// Each texture value is scaled by the Occlusion strength, roughness coefficient and metallic
		/// coefficient.
		/// This texture must be in linear color space.
		/// This is only used by the PBR shading model.
		/// @sa SetInterpolationToPBR SetOcclusionStrength SetMetallic SetRoughness
		/// </summary>
		// Token: 0x06005FCF RID: 24527 RVA: 0x0008A39C File Offset: 0x0008859C
		public void SetORMTexture(vtkTexture texture)
		{
			vtkProperty.vtkProperty_SetORMTexture_197(base.GetCppThis(), (texture == null) ? default(HandleRef) : texture.GetCppThis());
		}

		// Token: 0x06005FD0 RID: 24528
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetOcclusionStrength_198(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the occlusion strength coefficient.
		/// This value affects the strength of the occlusion if a material texture is present.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 1.0
		/// </summary>
		// Token: 0x06005FD1 RID: 24529 RVA: 0x0008A3CB File Offset: 0x000885CB
		public virtual void SetOcclusionStrength(double _arg)
		{
			vtkProperty.vtkProperty_SetOcclusionStrength_198(base.GetCppThis(), _arg);
		}

		// Token: 0x06005FD2 RID: 24530
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetOpacity_199(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the object's opacity. 1.0 is totally opaque and 0.0 is completely
		/// transparent.
		/// </summary>
		// Token: 0x06005FD3 RID: 24531 RVA: 0x0008A3DB File Offset: 0x000885DB
		public virtual void SetOpacity(double _arg)
		{
			vtkProperty.vtkProperty_SetOpacity_199(base.GetCppThis(), _arg);
		}

		// Token: 0x06005FD4 RID: 24532
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetPointSize_200(HandleRef pThis, float _arg);

		/// <summary>
		/// Set/Get the diameter of a point. The size is expressed in screen units.
		/// This is only implemented for OpenGL. The default is 1.0.
		/// </summary>
		// Token: 0x06005FD5 RID: 24533 RVA: 0x0008A3EB File Offset: 0x000885EB
		public virtual void SetPointSize(float _arg)
		{
			vtkProperty.vtkProperty_SetPointSize_200(base.GetCppThis(), _arg);
		}

		// Token: 0x06005FD6 RID: 24534
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetRenderLinesAsTubes_201(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get rendering of lines as tubes. The width of the
		/// line in pixels is controlled by the LineWidth
		/// attribute. May not be supported on every platform
		/// and the implementation may be half tubes, or something
		/// only tube like in appearance.
		/// </summary>
		// Token: 0x06005FD7 RID: 24535 RVA: 0x0008A3FB File Offset: 0x000885FB
		public virtual void SetRenderLinesAsTubes(bool _arg)
		{
			vtkProperty.vtkProperty_SetRenderLinesAsTubes_201(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005FD8 RID: 24536
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetRenderPointsAsSpheres_202(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get rendering of points as spheres. The size of the
		/// sphere in pixels is controlled by the PointSize
		/// attribute. Note that half spheres may be rendered
		/// instead of spheres.
		/// </summary>
		// Token: 0x06005FD9 RID: 24537 RVA: 0x0008A413 File Offset: 0x00088613
		public virtual void SetRenderPointsAsSpheres(bool _arg)
		{
			vtkProperty.vtkProperty_SetRenderPointsAsSpheres_202(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005FDA RID: 24538
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetRepresentation_203(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the surface geometry representation for the object.
		/// </summary>
		// Token: 0x06005FDB RID: 24539 RVA: 0x0008A42B File Offset: 0x0008862B
		public virtual void SetRepresentation(int _arg)
		{
			vtkProperty.vtkProperty_SetRepresentation_203(base.GetCppThis(), _arg);
		}

		// Token: 0x06005FDC RID: 24540
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetRepresentationToPoints_204(HandleRef pThis);

		/// <summary>
		/// Control the surface geometry representation for the object.
		/// </summary>
		// Token: 0x06005FDD RID: 24541 RVA: 0x0008A43B File Offset: 0x0008863B
		public void SetRepresentationToPoints()
		{
			vtkProperty.vtkProperty_SetRepresentationToPoints_204(base.GetCppThis());
		}

		// Token: 0x06005FDE RID: 24542
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetRepresentationToSurface_205(HandleRef pThis);

		/// <summary>
		/// Control the surface geometry representation for the object.
		/// </summary>
		// Token: 0x06005FDF RID: 24543 RVA: 0x0008A44A File Offset: 0x0008864A
		public void SetRepresentationToSurface()
		{
			vtkProperty.vtkProperty_SetRepresentationToSurface_205(base.GetCppThis());
		}

		// Token: 0x06005FE0 RID: 24544
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetRepresentationToWireframe_206(HandleRef pThis);

		/// <summary>
		/// Control the surface geometry representation for the object.
		/// </summary>
		// Token: 0x06005FE1 RID: 24545 RVA: 0x0008A459 File Offset: 0x00088659
		public void SetRepresentationToWireframe()
		{
			vtkProperty.vtkProperty_SetRepresentationToWireframe_206(base.GetCppThis());
		}

		// Token: 0x06005FE2 RID: 24546
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetRoughness_207(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the roughness coefficient.
		/// This value has to be between 0 (glossy) and 1 (rough).
		/// A glossy material has reflections and a high specular part.
		/// This parameter is only used by PBR Interpolation.
		/// Default value is 0.5
		/// </summary>
		// Token: 0x06005FE3 RID: 24547 RVA: 0x0008A468 File Offset: 0x00088668
		public virtual void SetRoughness(double _arg)
		{
			vtkProperty.vtkProperty_SetRoughness_207(base.GetCppThis(), _arg);
		}

		// Token: 0x06005FE4 RID: 24548
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetSelectionColor_208(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		/// <summary>
		/// Set/Get the RGBA color of selection primitives (if a selection is active on the mapper).
		/// Default is red and opaque.
		/// </summary>
		// Token: 0x06005FE5 RID: 24549 RVA: 0x0008A478 File Offset: 0x00088678
		public virtual void SetSelectionColor(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkProperty.vtkProperty_SetSelectionColor_208(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x06005FE6 RID: 24550
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetSelectionColor_209(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the RGBA color of selection primitives (if a selection is active on the mapper).
		/// Default is red and opaque.
		/// </summary>
		// Token: 0x06005FE7 RID: 24551 RVA: 0x0008A48C File Offset: 0x0008868C
		public virtual void SetSelectionColor(IntPtr _arg)
		{
			vtkProperty.vtkProperty_SetSelectionColor_209(base.GetCppThis(), _arg);
		}

		// Token: 0x06005FE8 RID: 24552
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetSelectionLineWidth_210(HandleRef pThis, float _arg);

		/// <summary>
		/// Set/Get the selection line width.
		/// Default is 2.
		/// </summary>
		// Token: 0x06005FE9 RID: 24553 RVA: 0x0008A49C File Offset: 0x0008869C
		public virtual void SetSelectionLineWidth(float _arg)
		{
			vtkProperty.vtkProperty_SetSelectionLineWidth_210(base.GetCppThis(), _arg);
		}

		// Token: 0x06005FEA RID: 24554
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetSelectionPointSize_211(HandleRef pThis, float _arg);

		/// <summary>
		/// Set/Get the selection point size.
		/// Default is 2.
		/// </summary>
		// Token: 0x06005FEB RID: 24555 RVA: 0x0008A4AC File Offset: 0x000886AC
		public virtual void SetSelectionPointSize(float _arg)
		{
			vtkProperty.vtkProperty_SetSelectionPointSize_211(base.GetCppThis(), _arg);
		}

		// Token: 0x06005FEC RID: 24556
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetShading_212(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/Disable shading. When shading is enabled, the
		/// Material must be set.
		/// </summary>
		// Token: 0x06005FED RID: 24557 RVA: 0x0008A4BC File Offset: 0x000886BC
		public virtual void SetShading(int _arg)
		{
			vtkProperty.vtkProperty_SetShading_212(base.GetCppThis(), _arg);
		}

		// Token: 0x06005FEE RID: 24558
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetShowTexturesOnBackface_213(HandleRef pThis, byte _arg);

		/// <summary>
		/// Show texture maps when the geometry is backfacing. Texture maps are
		/// always shown when frontfacing. By default this is true.
		/// </summary>
		// Token: 0x06005FEF RID: 24559 RVA: 0x0008A4CC File Offset: 0x000886CC
		public virtual void SetShowTexturesOnBackface(bool _arg)
		{
			vtkProperty.vtkProperty_SetShowTexturesOnBackface_213(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06005FF0 RID: 24560
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetSpecular_214(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the specular lighting coefficient.
		/// </summary>
		// Token: 0x06005FF1 RID: 24561 RVA: 0x0008A4E4 File Offset: 0x000886E4
		public virtual void SetSpecular(double _arg)
		{
			vtkProperty.vtkProperty_SetSpecular_214(base.GetCppThis(), _arg);
		}

		// Token: 0x06005FF2 RID: 24562
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetSpecularColor_215(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the specular surface color.
		/// </summary>
		// Token: 0x06005FF3 RID: 24563 RVA: 0x0008A4F4 File Offset: 0x000886F4
		public virtual void SetSpecularColor(double _arg1, double _arg2, double _arg3)
		{
			vtkProperty.vtkProperty_SetSpecularColor_215(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06005FF4 RID: 24564
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetSpecularColor_216(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the specular surface color.
		/// </summary>
		// Token: 0x06005FF5 RID: 24565 RVA: 0x0008A506 File Offset: 0x00088706
		public virtual void SetSpecularColor(IntPtr _arg)
		{
			vtkProperty.vtkProperty_SetSpecularColor_216(base.GetCppThis(), _arg);
		}

		// Token: 0x06005FF6 RID: 24566
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetSpecularPower_217(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the specular power.
		/// </summary>
		// Token: 0x06005FF7 RID: 24567 RVA: 0x0008A516 File Offset: 0x00088716
		public virtual void SetSpecularPower(double _arg)
		{
			vtkProperty.vtkProperty_SetSpecularPower_217(base.GetCppThis(), _arg);
		}

		// Token: 0x06005FF8 RID: 24568
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetTexture_218(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, HandleRef texture);

		/// <summary>
		/// Set/Get the texture object to control rendering texture maps. This will
		/// be a vtkTexture object. A property does not need to have an associated
		/// texture map and multiple properties can share one texture. Textures
		/// must be assigned unique names. Note that for texture blending the
		/// textures will be rendering is alphabetical order and after any texture
		/// defined in the actor.
		/// There exists 6 special textures with reserved names: "albedoTex", "materialTex", "normalTex",
		/// "emissiveTex", "anisotropyTex" and "coatNormalTex". While these textures can be added with the
		/// regular SetTexture method, it is preferred to use the methods SetBaseColorTexture,
		/// SetORMTexture, SetNormalTexture, SetEmissiveTexture, SetAnisotropyTexture and SetCoatNormalTex
		/// respectively.
		/// </summary>
		// Token: 0x06005FF9 RID: 24569 RVA: 0x0008A528 File Offset: 0x00088728
		public void SetTexture(string name, vtkTexture texture)
		{
			vtkProperty.vtkProperty_SetTexture_218(base.GetCppThis(), name, (texture == null) ? default(HandleRef) : texture.GetCppThis());
		}

		// Token: 0x06005FFA RID: 24570
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetVertexColor_219(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the color of primitive vertices (if vertex visibility is enabled).
		/// </summary>
		// Token: 0x06005FFB RID: 24571 RVA: 0x0008A558 File Offset: 0x00088758
		public virtual void SetVertexColor(double _arg1, double _arg2, double _arg3)
		{
			vtkProperty.vtkProperty_SetVertexColor_219(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06005FFC RID: 24572
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetVertexColor_220(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the color of primitive vertices (if vertex visibility is enabled).
		/// </summary>
		// Token: 0x06005FFD RID: 24573 RVA: 0x0008A56A File Offset: 0x0008876A
		public virtual void SetVertexColor(IntPtr _arg)
		{
			vtkProperty.vtkProperty_SetVertexColor_220(base.GetCppThis(), _arg);
		}

		// Token: 0x06005FFE RID: 24574
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_SetVertexVisibility_221(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the visibility of vertices. On some renderers it is
		/// possible to render the vertices of geometric primitives separately
		/// from the interior.
		/// </summary>
		// Token: 0x06005FFF RID: 24575 RVA: 0x0008A57A File Offset: 0x0008877A
		public virtual void SetVertexVisibility(int _arg)
		{
			vtkProperty.vtkProperty_SetVertexVisibility_221(base.GetCppThis(), _arg);
		}

		// Token: 0x06006000 RID: 24576
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_ShadingOff_222(HandleRef pThis);

		/// <summary>
		/// Enable/Disable shading. When shading is enabled, the
		/// Material must be set.
		/// </summary>
		// Token: 0x06006001 RID: 24577 RVA: 0x0008A58A File Offset: 0x0008878A
		public virtual void ShadingOff()
		{
			vtkProperty.vtkProperty_ShadingOff_222(base.GetCppThis());
		}

		// Token: 0x06006002 RID: 24578
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_ShadingOn_223(HandleRef pThis);

		/// <summary>
		/// Enable/Disable shading. When shading is enabled, the
		/// Material must be set.
		/// </summary>
		// Token: 0x06006003 RID: 24579 RVA: 0x0008A599 File Offset: 0x00088799
		public virtual void ShadingOn()
		{
			vtkProperty.vtkProperty_ShadingOn_223(base.GetCppThis());
		}

		// Token: 0x06006004 RID: 24580
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_ShowTexturesOnBackfaceOff_224(HandleRef pThis);

		/// <summary>
		/// Show texture maps when the geometry is backfacing. Texture maps are
		/// always shown when frontfacing. By default this is true.
		/// </summary>
		// Token: 0x06006005 RID: 24581 RVA: 0x0008A5A8 File Offset: 0x000887A8
		public virtual void ShowTexturesOnBackfaceOff()
		{
			vtkProperty.vtkProperty_ShowTexturesOnBackfaceOff_224(base.GetCppThis());
		}

		// Token: 0x06006006 RID: 24582
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_ShowTexturesOnBackfaceOn_225(HandleRef pThis);

		/// <summary>
		/// Show texture maps when the geometry is backfacing. Texture maps are
		/// always shown when frontfacing. By default this is true.
		/// </summary>
		// Token: 0x06006007 RID: 24583 RVA: 0x0008A5B7 File Offset: 0x000887B7
		public virtual void ShowTexturesOnBackfaceOn()
		{
			vtkProperty.vtkProperty_ShowTexturesOnBackfaceOn_225(base.GetCppThis());
		}

		// Token: 0x06006008 RID: 24584
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_VertexVisibilityOff_226(HandleRef pThis);

		/// <summary>
		/// Turn on/off the visibility of vertices. On some renderers it is
		/// possible to render the vertices of geometric primitives separately
		/// from the interior.
		/// </summary>
		// Token: 0x06006009 RID: 24585 RVA: 0x0008A5C6 File Offset: 0x000887C6
		public virtual void VertexVisibilityOff()
		{
			vtkProperty.vtkProperty_VertexVisibilityOff_226(base.GetCppThis());
		}

		// Token: 0x0600600A RID: 24586
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProperty_VertexVisibilityOn_227(HandleRef pThis);

		/// <summary>
		/// Turn on/off the visibility of vertices. On some renderers it is
		/// possible to render the vertices of geometric primitives separately
		/// from the interior.
		/// </summary>
		// Token: 0x0600600B RID: 24587 RVA: 0x0008A5D5 File Offset: 0x000887D5
		public virtual void VertexVisibilityOn()
		{
			vtkProperty.vtkProperty_VertexVisibilityOn_227(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008AC RID: 2220
		public new const string MRFullTypeName = "Kitware.VTK.vtkProperty";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008AD RID: 2221
		public new static readonly string MRClassNameKey = "class vtkProperty";
	}
}
