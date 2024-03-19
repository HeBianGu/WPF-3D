using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkEllipsoidalGaussianKernel
	/// </summary>
	/// <remarks>
	///    an ellipsoidal Gaussian interpolation kernel
	///
	///
	/// vtkEllipsoidalGaussianKernel is an interpolation kernel that returns the
	/// weights for all points found in the ellipsoid defined by radius R in
	/// combination with local data (normals and/or scalars). For example, "pancake"
	/// weightings (the local normal parallel to the minimum ellisoidal axis); or
	/// "needle" weightings (the local normal parallel to the maximum ellipsoidal
	/// axis) are possible. (Note that spherical Gaussian weightings are more
	/// efficiently computed using vtkGaussianKernel.)
	///
	/// The ellipsoidal Gaussian can be described by:
	///
	///     W(x) = S * exp( -( Sharpness^2 * ((rxy/E)**2 + z**2)/R**2) )
	///
	/// where S is the local scalar value; E is a user-defined eccentricity factor
	/// that controls the elliptical shape of the splat; z is the distance of the
	/// current voxel sample point along the local normal N; and rxy is the
	/// distance to neighbor point x in the direction perpendicular to N.
	///
	/// @warning
	/// The weights are normalized so that SUM(Wi) = 1. If a neighbor point p
	/// precisely lies on the point to be interpolated, then the interpolated
	/// point takes on the values associated with p.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPointInterpolator vtkInterpolationKernel vtkGeneralizedKernel
	/// vtkGaussianKernel vtkVoronoiKernel vtkSPHKernel vtkShepardKernel
	/// </seealso>
	// Token: 0x0200043C RID: 1084
	public class vtkEllipsoidalGaussianKernel : vtkGeneralizedKernel
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600CA60 RID: 51808 RVA: 0x00119A15 File Offset: 0x00117C15
		static vtkEllipsoidalGaussianKernel()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEllipsoidalGaussianKernel.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEllipsoidalGaussianKernel"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600CA61 RID: 51809 RVA: 0x00119A3D File Offset: 0x00117C3D
		public vtkEllipsoidalGaussianKernel(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600CA62 RID: 51810
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEllipsoidalGaussianKernel_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CA63 RID: 51811 RVA: 0x00119A4C File Offset: 0x00117C4C
		public new static vtkEllipsoidalGaussianKernel New()
		{
			vtkEllipsoidalGaussianKernel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEllipsoidalGaussianKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CA64 RID: 51812 RVA: 0x00119AA0 File Offset: 0x00117CA0
		public vtkEllipsoidalGaussianKernel() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600CA65 RID: 51813 RVA: 0x00119AE4 File Offset: 0x00117CE4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600CA66 RID: 51814
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEllipsoidalGaussianKernel_ComputeWeights_01(HandleRef pThis, IntPtr x, HandleRef pIds, HandleRef prob, HandleRef weights);

		/// <summary>
		/// Given a point x, a list of basis points pIds, and a probability
		/// weighting function prob, compute interpolation weights associated with
		/// these basis points.  Note that basis points list pIds, the probability
		/// weighting prob, and the weights array are provided by the caller of the
		/// method, and may be dynamically resized as necessary. The method returns
		/// the number of weights (pIds may be resized in some cases). Typically
		/// this method is called after ComputeBasis(), although advanced users can
		/// invoke ComputeWeights() and provide the interpolation basis points pIds
		/// directly. The probably weighting prob are numbers 0&lt;=prob&lt;=1 which are
		/// multiplied against the interpolation weights before normalization. They
		/// are estimates of local confidence of weights. The prob may be nullptr in
		/// which all probabilities are considered =1.
		/// </summary>
		// Token: 0x0600CA67 RID: 51815 RVA: 0x00119AF0 File Offset: 0x00117CF0
		public override long ComputeWeights(IntPtr x, vtkIdList pIds, vtkDoubleArray prob, vtkDoubleArray weights)
		{
			return vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_ComputeWeights_01(base.GetCppThis(), x, (pIds == null) ? default(HandleRef) : pIds.GetCppThis(), (prob == null) ? default(HandleRef) : prob.GetCppThis(), (weights == null) ? default(HandleRef) : weights.GetCppThis());
		}

		// Token: 0x0600CA68 RID: 51816
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEllipsoidalGaussianKernel_GetEccentricity_02(HandleRef pThis);

		/// <summary>
		/// Set / Get the eccentricity of the ellipsoidal Gaussian. A value=1.0
		/// produces a spherical distribution. Values &lt; 1 produce a needle like
		/// distribution (in the direction of the normal); values &gt; 1 produce a
		/// pancake like distribution (orthogonal to the normal).
		/// </summary>
		// Token: 0x0600CA69 RID: 51817 RVA: 0x00119B54 File Offset: 0x00117D54
		public virtual double GetEccentricity()
		{
			return vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_GetEccentricity_02(base.GetCppThis());
		}

		// Token: 0x0600CA6A RID: 51818
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEllipsoidalGaussianKernel_GetEccentricityMaxValue_03(HandleRef pThis);

		/// <summary>
		/// Set / Get the eccentricity of the ellipsoidal Gaussian. A value=1.0
		/// produces a spherical distribution. Values &lt; 1 produce a needle like
		/// distribution (in the direction of the normal); values &gt; 1 produce a
		/// pancake like distribution (orthogonal to the normal).
		/// </summary>
		// Token: 0x0600CA6B RID: 51819 RVA: 0x00119B74 File Offset: 0x00117D74
		public virtual double GetEccentricityMaxValue()
		{
			return vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_GetEccentricityMaxValue_03(base.GetCppThis());
		}

		// Token: 0x0600CA6C RID: 51820
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEllipsoidalGaussianKernel_GetEccentricityMinValue_04(HandleRef pThis);

		/// <summary>
		/// Set / Get the eccentricity of the ellipsoidal Gaussian. A value=1.0
		/// produces a spherical distribution. Values &lt; 1 produce a needle like
		/// distribution (in the direction of the normal); values &gt; 1 produce a
		/// pancake like distribution (orthogonal to the normal).
		/// </summary>
		// Token: 0x0600CA6D RID: 51821 RVA: 0x00119B94 File Offset: 0x00117D94
		public virtual double GetEccentricityMinValue()
		{
			return vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_GetEccentricityMinValue_04(base.GetCppThis());
		}

		// Token: 0x0600CA6E RID: 51822
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkEllipsoidalGaussianKernel_GetNormalsArrayName_05(HandleRef pThis);

		/// <summary>
		/// Specify the normals array name. Used to orient the ellipsoid. Note that
		/// by default the input normals are used (i.e. the input to
		/// vtkPointInterpolator). If no input normals are available, then the named
		/// NormalsArrayName is used.
		/// </summary>
		// Token: 0x0600CA6F RID: 51823 RVA: 0x00119BB4 File Offset: 0x00117DB4
		public virtual string GetNormalsArrayName()
		{
			return vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_GetNormalsArrayName_05(base.GetCppThis());
		}

		// Token: 0x0600CA70 RID: 51824
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEllipsoidalGaussianKernel_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CA71 RID: 51825 RVA: 0x00119BD4 File Offset: 0x00117DD4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0600CA72 RID: 51826
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEllipsoidalGaussianKernel_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CA73 RID: 51827 RVA: 0x00119BF4 File Offset: 0x00117DF4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0600CA74 RID: 51828
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkEllipsoidalGaussianKernel_GetScalarsArrayName_08(HandleRef pThis);

		/// <summary>
		/// Specify the scalars array name. Used to scale the ellipsoid. Note that
		/// by default the input scalars are used (i.e. the input to
		/// vtkPointInterpolator). If no input scalars are available, then the named
		/// ScalarsArrayName is used.
		/// </summary>
		// Token: 0x0600CA75 RID: 51829 RVA: 0x00119C10 File Offset: 0x00117E10
		public virtual string GetScalarsArrayName()
		{
			return vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_GetScalarsArrayName_08(base.GetCppThis());
		}

		// Token: 0x0600CA76 RID: 51830
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEllipsoidalGaussianKernel_GetScaleFactor_09(HandleRef pThis);

		/// <summary>
		/// Multiply the Gaussian splat distribution by this value. If UseScalars is
		/// on and a scalar array is provided, then the scalar value will be
		/// multiplied by the ScaleFactor times the Gaussian function.
		/// </summary>
		// Token: 0x0600CA77 RID: 51831 RVA: 0x00119C30 File Offset: 0x00117E30
		public virtual double GetScaleFactor()
		{
			return vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_GetScaleFactor_09(base.GetCppThis());
		}

		// Token: 0x0600CA78 RID: 51832
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEllipsoidalGaussianKernel_GetScaleFactorMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Multiply the Gaussian splat distribution by this value. If UseScalars is
		/// on and a scalar array is provided, then the scalar value will be
		/// multiplied by the ScaleFactor times the Gaussian function.
		/// </summary>
		// Token: 0x0600CA79 RID: 51833 RVA: 0x00119C50 File Offset: 0x00117E50
		public virtual double GetScaleFactorMaxValue()
		{
			return vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_GetScaleFactorMaxValue_10(base.GetCppThis());
		}

		// Token: 0x0600CA7A RID: 51834
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEllipsoidalGaussianKernel_GetScaleFactorMinValue_11(HandleRef pThis);

		/// <summary>
		/// Multiply the Gaussian splat distribution by this value. If UseScalars is
		/// on and a scalar array is provided, then the scalar value will be
		/// multiplied by the ScaleFactor times the Gaussian function.
		/// </summary>
		// Token: 0x0600CA7B RID: 51835 RVA: 0x00119C70 File Offset: 0x00117E70
		public virtual double GetScaleFactorMinValue()
		{
			return vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_GetScaleFactorMinValue_11(base.GetCppThis());
		}

		// Token: 0x0600CA7C RID: 51836
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEllipsoidalGaussianKernel_GetSharpness_12(HandleRef pThis);

		/// <summary>
		/// Set / Get the sharpness (i.e., falloff) of the Gaussian. By default
		/// Sharpness=2. As the sharpness increases the effects of distant points
		/// are reduced.
		/// </summary>
		// Token: 0x0600CA7D RID: 51837 RVA: 0x00119C90 File Offset: 0x00117E90
		public virtual double GetSharpness()
		{
			return vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_GetSharpness_12(base.GetCppThis());
		}

		// Token: 0x0600CA7E RID: 51838
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEllipsoidalGaussianKernel_GetSharpnessMaxValue_13(HandleRef pThis);

		/// <summary>
		/// Set / Get the sharpness (i.e., falloff) of the Gaussian. By default
		/// Sharpness=2. As the sharpness increases the effects of distant points
		/// are reduced.
		/// </summary>
		// Token: 0x0600CA7F RID: 51839 RVA: 0x00119CB0 File Offset: 0x00117EB0
		public virtual double GetSharpnessMaxValue()
		{
			return vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_GetSharpnessMaxValue_13(base.GetCppThis());
		}

		// Token: 0x0600CA80 RID: 51840
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEllipsoidalGaussianKernel_GetSharpnessMinValue_14(HandleRef pThis);

		/// <summary>
		/// Set / Get the sharpness (i.e., falloff) of the Gaussian. By default
		/// Sharpness=2. As the sharpness increases the effects of distant points
		/// are reduced.
		/// </summary>
		// Token: 0x0600CA81 RID: 51841 RVA: 0x00119CD0 File Offset: 0x00117ED0
		public virtual double GetSharpnessMinValue()
		{
			return vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_GetSharpnessMinValue_14(base.GetCppThis());
		}

		// Token: 0x0600CA82 RID: 51842
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkEllipsoidalGaussianKernel_GetUseNormals_15(HandleRef pThis);

		/// <summary>
		/// Specify whether vector values should be used to affect the shape
		/// of the Gaussian distribution. By default this is on.
		/// </summary>
		// Token: 0x0600CA83 RID: 51843 RVA: 0x00119CF0 File Offset: 0x00117EF0
		public virtual bool GetUseNormals()
		{
			return vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_GetUseNormals_15(base.GetCppThis()) != 0;
		}

		// Token: 0x0600CA84 RID: 51844
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkEllipsoidalGaussianKernel_GetUseScalars_16(HandleRef pThis);

		/// <summary>
		/// Specify whether scalar values should be used to scale the weights.
		/// By default this is off.
		/// </summary>
		// Token: 0x0600CA85 RID: 51845 RVA: 0x00119D18 File Offset: 0x00117F18
		public virtual bool GetUseScalars()
		{
			return vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_GetUseScalars_16(base.GetCppThis()) != 0;
		}

		// Token: 0x0600CA86 RID: 51846
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipsoidalGaussianKernel_Initialize_17(HandleRef pThis, HandleRef loc, HandleRef ds, HandleRef pd);

		/// <summary>
		/// Initialize the kernel. Overload the superclass to set up scalars and
		/// vectors.
		/// </summary>
		// Token: 0x0600CA87 RID: 51847 RVA: 0x00119D40 File Offset: 0x00117F40
		public override void Initialize(vtkAbstractPointLocator loc, vtkDataSet ds, vtkPointData pd)
		{
			vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_Initialize_17(base.GetCppThis(), (loc == null) ? default(HandleRef) : loc.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0600CA88 RID: 51848
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEllipsoidalGaussianKernel_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CA89 RID: 51849 RVA: 0x00119D9C File Offset: 0x00117F9C
		public override int IsA(string type)
		{
			return vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x0600CA8A RID: 51850
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEllipsoidalGaussianKernel_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CA8B RID: 51851 RVA: 0x00119DBC File Offset: 0x00117FBC
		public new static int IsTypeOf(string type)
		{
			return vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_IsTypeOf_19(type);
		}

		// Token: 0x0600CA8C RID: 51852
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEllipsoidalGaussianKernel_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CA8D RID: 51853 RVA: 0x00119DD8 File Offset: 0x00117FD8
		public new vtkEllipsoidalGaussianKernel NewInstance()
		{
			vtkEllipsoidalGaussianKernel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEllipsoidalGaussianKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600CA8E RID: 51854
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEllipsoidalGaussianKernel_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CA8F RID: 51855 RVA: 0x00119E34 File Offset: 0x00118034
		public new static vtkEllipsoidalGaussianKernel SafeDownCast(vtkObjectBase o)
		{
			vtkEllipsoidalGaussianKernel vtkEllipsoidalGaussianKernel = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEllipsoidalGaussianKernel = (vtkEllipsoidalGaussianKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEllipsoidalGaussianKernel.Register(null);
				}
			}
			return vtkEllipsoidalGaussianKernel;
		}

		// Token: 0x0600CA90 RID: 51856
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipsoidalGaussianKernel_SetEccentricity_23(HandleRef pThis, double _arg);

		/// <summary>
		/// Set / Get the eccentricity of the ellipsoidal Gaussian. A value=1.0
		/// produces a spherical distribution. Values &lt; 1 produce a needle like
		/// distribution (in the direction of the normal); values &gt; 1 produce a
		/// pancake like distribution (orthogonal to the normal).
		/// </summary>
		// Token: 0x0600CA91 RID: 51857 RVA: 0x00119EB3 File Offset: 0x001180B3
		public virtual void SetEccentricity(double _arg)
		{
			vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_SetEccentricity_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CA92 RID: 51858
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipsoidalGaussianKernel_SetNormalsArrayName_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the normals array name. Used to orient the ellipsoid. Note that
		/// by default the input normals are used (i.e. the input to
		/// vtkPointInterpolator). If no input normals are available, then the named
		/// NormalsArrayName is used.
		/// </summary>
		// Token: 0x0600CA93 RID: 51859 RVA: 0x00119EC3 File Offset: 0x001180C3
		public virtual void SetNormalsArrayName(string _arg)
		{
			vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_SetNormalsArrayName_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CA94 RID: 51860
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipsoidalGaussianKernel_SetScalarsArrayName_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the scalars array name. Used to scale the ellipsoid. Note that
		/// by default the input scalars are used (i.e. the input to
		/// vtkPointInterpolator). If no input scalars are available, then the named
		/// ScalarsArrayName is used.
		/// </summary>
		// Token: 0x0600CA95 RID: 51861 RVA: 0x00119ED3 File Offset: 0x001180D3
		public virtual void SetScalarsArrayName(string _arg)
		{
			vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_SetScalarsArrayName_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CA96 RID: 51862
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipsoidalGaussianKernel_SetScaleFactor_26(HandleRef pThis, double _arg);

		/// <summary>
		/// Multiply the Gaussian splat distribution by this value. If UseScalars is
		/// on and a scalar array is provided, then the scalar value will be
		/// multiplied by the ScaleFactor times the Gaussian function.
		/// </summary>
		// Token: 0x0600CA97 RID: 51863 RVA: 0x00119EE3 File Offset: 0x001180E3
		public virtual void SetScaleFactor(double _arg)
		{
			vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_SetScaleFactor_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CA98 RID: 51864
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipsoidalGaussianKernel_SetSharpness_27(HandleRef pThis, double _arg);

		/// <summary>
		/// Set / Get the sharpness (i.e., falloff) of the Gaussian. By default
		/// Sharpness=2. As the sharpness increases the effects of distant points
		/// are reduced.
		/// </summary>
		// Token: 0x0600CA99 RID: 51865 RVA: 0x00119EF3 File Offset: 0x001180F3
		public virtual void SetSharpness(double _arg)
		{
			vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_SetSharpness_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CA9A RID: 51866
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipsoidalGaussianKernel_SetUseNormals_28(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify whether vector values should be used to affect the shape
		/// of the Gaussian distribution. By default this is on.
		/// </summary>
		// Token: 0x0600CA9B RID: 51867 RVA: 0x00119F03 File Offset: 0x00118103
		public virtual void SetUseNormals(bool _arg)
		{
			vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_SetUseNormals_28(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600CA9C RID: 51868
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipsoidalGaussianKernel_SetUseScalars_29(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify whether scalar values should be used to scale the weights.
		/// By default this is off.
		/// </summary>
		// Token: 0x0600CA9D RID: 51869 RVA: 0x00119F1B File Offset: 0x0011811B
		public virtual void SetUseScalars(bool _arg)
		{
			vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_SetUseScalars_29(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600CA9E RID: 51870
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipsoidalGaussianKernel_UseNormalsOff_30(HandleRef pThis);

		/// <summary>
		/// Specify whether vector values should be used to affect the shape
		/// of the Gaussian distribution. By default this is on.
		/// </summary>
		// Token: 0x0600CA9F RID: 51871 RVA: 0x00119F33 File Offset: 0x00118133
		public virtual void UseNormalsOff()
		{
			vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_UseNormalsOff_30(base.GetCppThis());
		}

		// Token: 0x0600CAA0 RID: 51872
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipsoidalGaussianKernel_UseNormalsOn_31(HandleRef pThis);

		/// <summary>
		/// Specify whether vector values should be used to affect the shape
		/// of the Gaussian distribution. By default this is on.
		/// </summary>
		// Token: 0x0600CAA1 RID: 51873 RVA: 0x00119F42 File Offset: 0x00118142
		public virtual void UseNormalsOn()
		{
			vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_UseNormalsOn_31(base.GetCppThis());
		}

		// Token: 0x0600CAA2 RID: 51874
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipsoidalGaussianKernel_UseScalarsOff_32(HandleRef pThis);

		/// <summary>
		/// Specify whether scalar values should be used to scale the weights.
		/// By default this is off.
		/// </summary>
		// Token: 0x0600CAA3 RID: 51875 RVA: 0x00119F51 File Offset: 0x00118151
		public virtual void UseScalarsOff()
		{
			vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_UseScalarsOff_32(base.GetCppThis());
		}

		// Token: 0x0600CAA4 RID: 51876
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEllipsoidalGaussianKernel_UseScalarsOn_33(HandleRef pThis);

		/// <summary>
		/// Specify whether scalar values should be used to scale the weights.
		/// By default this is off.
		/// </summary>
		// Token: 0x0600CAA5 RID: 51877 RVA: 0x00119F60 File Offset: 0x00118160
		public virtual void UseScalarsOn()
		{
			vtkEllipsoidalGaussianKernel.vtkEllipsoidalGaussianKernel_UseScalarsOn_33(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F05 RID: 3845
		public new const string MRFullTypeName = "Kitware.VTK.vtkEllipsoidalGaussianKernel";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F06 RID: 3846
		public new static readonly string MRClassNameKey = "class vtkEllipsoidalGaussianKernel";
	}
}
