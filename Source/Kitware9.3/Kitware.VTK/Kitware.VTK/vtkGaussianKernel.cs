using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGaussianKernel
	/// </summary>
	/// <remarks>
	///    a spherical Gaussian interpolation kernel
	///
	///
	/// vtkGaussianKernel is an interpolation kernel that simply returns the
	/// weights for all points found in the sphere defined by radius R. The
	/// weights are computed as: exp(-(s*r/R)^2) where r is the distance from the
	/// point to be interpolated to a neighboring point within R. The sharpness s
	/// simply affects the rate of fall off of the Gaussian. (A more general
	/// Gaussian kernel is available from vtkEllipsoidalGaussianKernel.)
	///
	/// @warning
	/// The weights are normalized sp that SUM(Wi) = 1. If a neighbor point p
	/// precisely lies on the point to be interpolated, then the interpolated
	/// point takes on the values associated with p.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPointInterpolator vtkInterpolationKernel vtkEllipsoidalGaussianKernel
	/// vtkVoronoiKernel vtkSPHKernel vtkShepardKernel
	/// </seealso>
	// Token: 0x02000445 RID: 1093
	public class vtkGaussianKernel : vtkGeneralizedKernel
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600CBFF RID: 52223 RVA: 0x0011BCCB File Offset: 0x00119ECB
		static vtkGaussianKernel()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGaussianKernel.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGaussianKernel"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600CC00 RID: 52224 RVA: 0x0011BCF3 File Offset: 0x00119EF3
		public vtkGaussianKernel(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600CC01 RID: 52225
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGaussianKernel_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CC02 RID: 52226 RVA: 0x0011BD04 File Offset: 0x00119F04
		public new static vtkGaussianKernel New()
		{
			vtkGaussianKernel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGaussianKernel.vtkGaussianKernel_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGaussianKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CC03 RID: 52227 RVA: 0x0011BD58 File Offset: 0x00119F58
		public vtkGaussianKernel() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGaussianKernel.vtkGaussianKernel_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600CC04 RID: 52228 RVA: 0x0011BD9C File Offset: 0x00119F9C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600CC05 RID: 52229
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGaussianKernel_ComputeWeights_01(HandleRef pThis, IntPtr x, HandleRef pIds, HandleRef prob, HandleRef weights);

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
		// Token: 0x0600CC06 RID: 52230 RVA: 0x0011BDA8 File Offset: 0x00119FA8
		public override long ComputeWeights(IntPtr x, vtkIdList pIds, vtkDoubleArray prob, vtkDoubleArray weights)
		{
			return vtkGaussianKernel.vtkGaussianKernel_ComputeWeights_01(base.GetCppThis(), x, (pIds == null) ? default(HandleRef) : pIds.GetCppThis(), (prob == null) ? default(HandleRef) : prob.GetCppThis(), (weights == null) ? default(HandleRef) : weights.GetCppThis());
		}

		// Token: 0x0600CC07 RID: 52231
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGaussianKernel_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CC08 RID: 52232 RVA: 0x0011BE0C File Offset: 0x0011A00C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGaussianKernel.vtkGaussianKernel_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600CC09 RID: 52233
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGaussianKernel_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CC0A RID: 52234 RVA: 0x0011BE2C File Offset: 0x0011A02C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGaussianKernel.vtkGaussianKernel_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600CC0B RID: 52235
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGaussianKernel_GetSharpness_04(HandleRef pThis);

		/// <summary>
		/// Set / Get the sharpness (i.e., falloff) of the Gaussian. By default
		/// Sharpness=2. As the sharpness increases the effects of distant points
		/// are reduced.
		/// </summary>
		// Token: 0x0600CC0C RID: 52236 RVA: 0x0011BE48 File Offset: 0x0011A048
		public virtual double GetSharpness()
		{
			return vtkGaussianKernel.vtkGaussianKernel_GetSharpness_04(base.GetCppThis());
		}

		// Token: 0x0600CC0D RID: 52237
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGaussianKernel_GetSharpnessMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Set / Get the sharpness (i.e., falloff) of the Gaussian. By default
		/// Sharpness=2. As the sharpness increases the effects of distant points
		/// are reduced.
		/// </summary>
		// Token: 0x0600CC0E RID: 52238 RVA: 0x0011BE68 File Offset: 0x0011A068
		public virtual double GetSharpnessMaxValue()
		{
			return vtkGaussianKernel.vtkGaussianKernel_GetSharpnessMaxValue_05(base.GetCppThis());
		}

		// Token: 0x0600CC0F RID: 52239
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGaussianKernel_GetSharpnessMinValue_06(HandleRef pThis);

		/// <summary>
		/// Set / Get the sharpness (i.e., falloff) of the Gaussian. By default
		/// Sharpness=2. As the sharpness increases the effects of distant points
		/// are reduced.
		/// </summary>
		// Token: 0x0600CC10 RID: 52240 RVA: 0x0011BE88 File Offset: 0x0011A088
		public virtual double GetSharpnessMinValue()
		{
			return vtkGaussianKernel.vtkGaussianKernel_GetSharpnessMinValue_06(base.GetCppThis());
		}

		// Token: 0x0600CC11 RID: 52241
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianKernel_Initialize_07(HandleRef pThis, HandleRef loc, HandleRef ds, HandleRef pd);

		/// <summary>
		/// Initialize the kernel. Overload the superclass to set up internal
		/// computational values.
		/// </summary>
		// Token: 0x0600CC12 RID: 52242 RVA: 0x0011BEA8 File Offset: 0x0011A0A8
		public override void Initialize(vtkAbstractPointLocator loc, vtkDataSet ds, vtkPointData pd)
		{
			vtkGaussianKernel.vtkGaussianKernel_Initialize_07(base.GetCppThis(), (loc == null) ? default(HandleRef) : loc.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0600CC13 RID: 52243
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGaussianKernel_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CC14 RID: 52244 RVA: 0x0011BF04 File Offset: 0x0011A104
		public override int IsA(string type)
		{
			return vtkGaussianKernel.vtkGaussianKernel_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0600CC15 RID: 52245
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGaussianKernel_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CC16 RID: 52246 RVA: 0x0011BF24 File Offset: 0x0011A124
		public new static int IsTypeOf(string type)
		{
			return vtkGaussianKernel.vtkGaussianKernel_IsTypeOf_09(type);
		}

		// Token: 0x0600CC17 RID: 52247
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGaussianKernel_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CC18 RID: 52248 RVA: 0x0011BF40 File Offset: 0x0011A140
		public new vtkGaussianKernel NewInstance()
		{
			vtkGaussianKernel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGaussianKernel.vtkGaussianKernel_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGaussianKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600CC19 RID: 52249
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGaussianKernel_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CC1A RID: 52250 RVA: 0x0011BF9C File Offset: 0x0011A19C
		public new static vtkGaussianKernel SafeDownCast(vtkObjectBase o)
		{
			vtkGaussianKernel vtkGaussianKernel = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGaussianKernel.vtkGaussianKernel_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGaussianKernel = (vtkGaussianKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGaussianKernel.Register(null);
				}
			}
			return vtkGaussianKernel;
		}

		// Token: 0x0600CC1B RID: 52251
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianKernel_SetSharpness_13(HandleRef pThis, double _arg);

		/// <summary>
		/// Set / Get the sharpness (i.e., falloff) of the Gaussian. By default
		/// Sharpness=2. As the sharpness increases the effects of distant points
		/// are reduced.
		/// </summary>
		// Token: 0x0600CC1C RID: 52252 RVA: 0x0011C01B File Offset: 0x0011A21B
		public virtual void SetSharpness(double _arg)
		{
			vtkGaussianKernel.vtkGaussianKernel_SetSharpness_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F17 RID: 3863
		public new const string MRFullTypeName = "Kitware.VTK.vtkGaussianKernel";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F18 RID: 3864
		public new static readonly string MRClassNameKey = "class vtkGaussianKernel";
	}
}
