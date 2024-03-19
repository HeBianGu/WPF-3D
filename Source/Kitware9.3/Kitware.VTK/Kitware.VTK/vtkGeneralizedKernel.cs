using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGeneralizedKernel
	/// </summary>
	/// <remarks>
	///    flexible, general interpolation kernels
	///
	///
	/// vtkGeneralizedKernel is an abstract class that defines an API for concrete
	/// general-purpose, kernel subclasses. vtkGeneralizedKernels has important
	/// properties that make them useful in a variety of interpolation
	/// applications:
	/// &lt;pre&gt;
	/// 1. The weights are normalized.
	/// 2. The footprint of the basis is configurable.
	/// 3. Probabilistic weighting functions can be used to favor certain weights.
	/// &lt;/pre&gt;
	/// The following paragraphs describe each of these properties in more detail.
	///
	/// Normalized weightings simple mean Sum(w_i) = 1. This ensures that the
	/// interpolation process is well behaved.
	///
	/// The interpolation footprint is the set of points that are used to perform
	/// the interpolation process. For example, it is possible to choose between a
	/// radius-based kernel selection, and one based on the N nearest
	/// neighbors. Note that the performance and mathematical properties of
	/// kernels may vary greatly depending on which kernel style is selected. For
	/// example, if a radius-based kernel footprint is used, and the radius is too
	/// big, the algorithm can perform in n^3 fashion.
	///
	/// Finally, in advanced usage, probability functions can be applied to the
	/// interpolation weights (prior to normalization). These probability
	/// functions are confidence estimates that the data at a particular point is
	/// accurate. A typical application is when laser scans are used to acquire
	/// point measurements, which return normals that indicate glancing returns
	/// versus direct, near orthogonal hits. Another use is when point clouds are
	/// combined, where some clouds are acquired with more accurate, detailed
	/// devices versus a broad, potentially coarser acquisition process.
	///
	/// @warning
	/// Some kernels, like the Voronoi kernel, cannot be subclasses of this class
	/// because their definition inherently defines the basis style. For example,
	/// the Voronoi kernel is simply the single closest point. SPH kernels are
	/// similar, because they implicitly depend on a particle distribution
	/// consistent with simulation constraints such as conservation of mass, etc.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPointInterpolator vtkPointInterpolator2D vtkGaussianKernel vtkSPHKernel
	/// vtkShepardKernel vtkLinearKernel vtkVoronoiKernel
	/// </seealso>
	// Token: 0x0200043A RID: 1082
	public abstract class vtkGeneralizedKernel : vtkInterpolationKernel
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600CA2B RID: 51755 RVA: 0x0011960F File Offset: 0x0011780F
		static vtkGeneralizedKernel()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeneralizedKernel.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeneralizedKernel"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600CA2C RID: 51756 RVA: 0x00119637 File Offset: 0x00117837
		public vtkGeneralizedKernel(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600CA2D RID: 51757 RVA: 0x00119645 File Offset: 0x00117845
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600CA2E RID: 51758
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeneralizedKernel_ComputeBasis_01(HandleRef pThis, IntPtr x, HandleRef pIds, long ptId);

		/// <summary>
		/// Based on the kernel style, invoke the appropriate locator method to
		/// obtain the points making up the basis. Given a point x (and optional
		/// associated point id), determine the points around x which form an
		/// interpolation basis. The user must provide the vtkIdList pIds, which
		/// will be dynamically resized as necessary. The method returns the number
		/// of points in the basis. Typically this method is called before
		/// ComputeWeights(). Note that ptId is optional in most cases, although in
		/// some kernels it is used to facilitate basis computation.
		/// </summary>
		// Token: 0x0600CA2F RID: 51759 RVA: 0x00119650 File Offset: 0x00117850
		public override long ComputeBasis(IntPtr x, vtkIdList pIds, long ptId)
		{
			return vtkGeneralizedKernel.vtkGeneralizedKernel_ComputeBasis_01(base.GetCppThis(), x, (pIds == null) ? default(HandleRef) : pIds.GetCppThis(), ptId);
		}

		// Token: 0x0600CA30 RID: 51760
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeneralizedKernel_ComputeWeights_02(HandleRef pThis, IntPtr x, HandleRef pIds, HandleRef prob, HandleRef weights);

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
		// Token: 0x0600CA31 RID: 51761 RVA: 0x00119688 File Offset: 0x00117888
		public virtual long ComputeWeights(IntPtr x, vtkIdList pIds, vtkDoubleArray prob, vtkDoubleArray weights)
		{
			return vtkGeneralizedKernel.vtkGeneralizedKernel_ComputeWeights_02(base.GetCppThis(), x, (pIds == null) ? default(HandleRef) : pIds.GetCppThis(), (prob == null) ? default(HandleRef) : prob.GetCppThis(), (weights == null) ? default(HandleRef) : weights.GetCppThis());
		}

		// Token: 0x0600CA32 RID: 51762
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeneralizedKernel_ComputeWeights_03(HandleRef pThis, IntPtr x, HandleRef pIds, HandleRef weights);

		/// <summary>
		/// Given a point x, and a list of basis points pIds, compute interpolation
		/// weights associated with these basis points.  Note that both the nearby
		/// basis points list pIds and the weights array are provided by the caller
		/// of the method, and may be dynamically resized as necessary. Typically
		/// this method is called after ComputeBasis(), although advanced users can
		/// invoke ComputeWeights() and provide the interpolation basis points pIds
		/// directly.
		/// </summary>
		// Token: 0x0600CA33 RID: 51763 RVA: 0x001196EC File Offset: 0x001178EC
		public override long ComputeWeights(IntPtr x, vtkIdList pIds, vtkDoubleArray weights)
		{
			return vtkGeneralizedKernel.vtkGeneralizedKernel_ComputeWeights_03(base.GetCppThis(), x, (pIds == null) ? default(HandleRef) : pIds.GetCppThis(), (weights == null) ? default(HandleRef) : weights.GetCppThis());
		}

		// Token: 0x0600CA34 RID: 51764
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeneralizedKernel_GetKernelFootprint_04(HandleRef pThis);

		/// <summary>
		/// Specify the interpolation basis style. By default, a Radius style is
		/// used (i.e., the basis is defined from all points within a specified
		/// radius). However, it is also possible to select the N closest points
		/// (NClosest). Note that in most formulations the Radius style is assumed
		/// as it provides better mathematical properties. However, for convenience
		/// some bases are easier to use when the N closest points are taken.
		/// </summary>
		// Token: 0x0600CA35 RID: 51765 RVA: 0x00119738 File Offset: 0x00117938
		public virtual int GetKernelFootprint()
		{
			return vtkGeneralizedKernel.vtkGeneralizedKernel_GetKernelFootprint_04(base.GetCppThis());
		}

		// Token: 0x0600CA36 RID: 51766
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGeneralizedKernel_GetNormalizeWeights_05(HandleRef pThis);

		/// <summary>
		/// Indicate whether the interpolation weights should be normalized after they
		/// are computed. Generally this is left on as it results in more reasonable
		/// behavior.
		/// </summary>
		// Token: 0x0600CA37 RID: 51767 RVA: 0x00119758 File Offset: 0x00117958
		public virtual bool GetNormalizeWeights()
		{
			return vtkGeneralizedKernel.vtkGeneralizedKernel_GetNormalizeWeights_05(base.GetCppThis()) != 0;
		}

		// Token: 0x0600CA38 RID: 51768
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeneralizedKernel_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type and printing.
		/// </summary>
		// Token: 0x0600CA39 RID: 51769 RVA: 0x00119780 File Offset: 0x00117980
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGeneralizedKernel.vtkGeneralizedKernel_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0600CA3A RID: 51770
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeneralizedKernel_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type and printing.
		/// </summary>
		// Token: 0x0600CA3B RID: 51771 RVA: 0x001197A0 File Offset: 0x001179A0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGeneralizedKernel.vtkGeneralizedKernel_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0600CA3C RID: 51772
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeneralizedKernel_GetNumberOfPoints_08(HandleRef pThis);

		/// <summary>
		/// If the interpolation basis style is NClosest, then this method specifies
		/// the number of the closest points used to form the interpolation basis.
		/// </summary>
		// Token: 0x0600CA3D RID: 51773 RVA: 0x001197BC File Offset: 0x001179BC
		public virtual int GetNumberOfPoints()
		{
			return vtkGeneralizedKernel.vtkGeneralizedKernel_GetNumberOfPoints_08(base.GetCppThis());
		}

		// Token: 0x0600CA3E RID: 51774
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeneralizedKernel_GetNumberOfPointsMaxValue_09(HandleRef pThis);

		/// <summary>
		/// If the interpolation basis style is NClosest, then this method specifies
		/// the number of the closest points used to form the interpolation basis.
		/// </summary>
		// Token: 0x0600CA3F RID: 51775 RVA: 0x001197DC File Offset: 0x001179DC
		public virtual int GetNumberOfPointsMaxValue()
		{
			return vtkGeneralizedKernel.vtkGeneralizedKernel_GetNumberOfPointsMaxValue_09(base.GetCppThis());
		}

		// Token: 0x0600CA40 RID: 51776
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeneralizedKernel_GetNumberOfPointsMinValue_10(HandleRef pThis);

		/// <summary>
		/// If the interpolation basis style is NClosest, then this method specifies
		/// the number of the closest points used to form the interpolation basis.
		/// </summary>
		// Token: 0x0600CA41 RID: 51777 RVA: 0x001197FC File Offset: 0x001179FC
		public virtual int GetNumberOfPointsMinValue()
		{
			return vtkGeneralizedKernel.vtkGeneralizedKernel_GetNumberOfPointsMinValue_10(base.GetCppThis());
		}

		// Token: 0x0600CA42 RID: 51778
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGeneralizedKernel_GetRadius_11(HandleRef pThis);

		/// <summary>
		/// If the interpolation basis style is Radius, then this method specifies
		/// the radius within which the basis points must lie.
		/// </summary>
		// Token: 0x0600CA43 RID: 51779 RVA: 0x0011981C File Offset: 0x00117A1C
		public virtual double GetRadius()
		{
			return vtkGeneralizedKernel.vtkGeneralizedKernel_GetRadius_11(base.GetCppThis());
		}

		// Token: 0x0600CA44 RID: 51780
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGeneralizedKernel_GetRadiusMaxValue_12(HandleRef pThis);

		/// <summary>
		/// If the interpolation basis style is Radius, then this method specifies
		/// the radius within which the basis points must lie.
		/// </summary>
		// Token: 0x0600CA45 RID: 51781 RVA: 0x0011983C File Offset: 0x00117A3C
		public virtual double GetRadiusMaxValue()
		{
			return vtkGeneralizedKernel.vtkGeneralizedKernel_GetRadiusMaxValue_12(base.GetCppThis());
		}

		// Token: 0x0600CA46 RID: 51782
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGeneralizedKernel_GetRadiusMinValue_13(HandleRef pThis);

		/// <summary>
		/// If the interpolation basis style is Radius, then this method specifies
		/// the radius within which the basis points must lie.
		/// </summary>
		// Token: 0x0600CA47 RID: 51783 RVA: 0x0011985C File Offset: 0x00117A5C
		public virtual double GetRadiusMinValue()
		{
			return vtkGeneralizedKernel.vtkGeneralizedKernel_GetRadiusMinValue_13(base.GetCppThis());
		}

		// Token: 0x0600CA48 RID: 51784
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeneralizedKernel_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type and printing.
		/// </summary>
		// Token: 0x0600CA49 RID: 51785 RVA: 0x0011987C File Offset: 0x00117A7C
		public override int IsA(string type)
		{
			return vtkGeneralizedKernel.vtkGeneralizedKernel_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x0600CA4A RID: 51786
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeneralizedKernel_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type and printing.
		/// </summary>
		// Token: 0x0600CA4B RID: 51787 RVA: 0x0011989C File Offset: 0x00117A9C
		public new static int IsTypeOf(string type)
		{
			return vtkGeneralizedKernel.vtkGeneralizedKernel_IsTypeOf_15(type);
		}

		// Token: 0x0600CA4C RID: 51788
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeneralizedKernel_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type and printing.
		/// </summary>
		// Token: 0x0600CA4D RID: 51789 RVA: 0x001198B8 File Offset: 0x00117AB8
		public new vtkGeneralizedKernel NewInstance()
		{
			vtkGeneralizedKernel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeneralizedKernel.vtkGeneralizedKernel_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeneralizedKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600CA4E RID: 51790
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeneralizedKernel_NormalizeWeightsOff_17(HandleRef pThis);

		/// <summary>
		/// Indicate whether the interpolation weights should be normalized after they
		/// are computed. Generally this is left on as it results in more reasonable
		/// behavior.
		/// </summary>
		// Token: 0x0600CA4F RID: 51791 RVA: 0x00119912 File Offset: 0x00117B12
		public virtual void NormalizeWeightsOff()
		{
			vtkGeneralizedKernel.vtkGeneralizedKernel_NormalizeWeightsOff_17(base.GetCppThis());
		}

		// Token: 0x0600CA50 RID: 51792
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeneralizedKernel_NormalizeWeightsOn_18(HandleRef pThis);

		/// <summary>
		/// Indicate whether the interpolation weights should be normalized after they
		/// are computed. Generally this is left on as it results in more reasonable
		/// behavior.
		/// </summary>
		// Token: 0x0600CA51 RID: 51793 RVA: 0x00119921 File Offset: 0x00117B21
		public virtual void NormalizeWeightsOn()
		{
			vtkGeneralizedKernel.vtkGeneralizedKernel_NormalizeWeightsOn_18(base.GetCppThis());
		}

		// Token: 0x0600CA52 RID: 51794
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeneralizedKernel_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type and printing.
		/// </summary>
		// Token: 0x0600CA53 RID: 51795 RVA: 0x00119930 File Offset: 0x00117B30
		public new static vtkGeneralizedKernel SafeDownCast(vtkObjectBase o)
		{
			vtkGeneralizedKernel vtkGeneralizedKernel = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeneralizedKernel.vtkGeneralizedKernel_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeneralizedKernel = (vtkGeneralizedKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeneralizedKernel.Register(null);
				}
			}
			return vtkGeneralizedKernel;
		}

		// Token: 0x0600CA54 RID: 51796
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeneralizedKernel_SetKernelFootprint_20(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the interpolation basis style. By default, a Radius style is
		/// used (i.e., the basis is defined from all points within a specified
		/// radius). However, it is also possible to select the N closest points
		/// (NClosest). Note that in most formulations the Radius style is assumed
		/// as it provides better mathematical properties. However, for convenience
		/// some bases are easier to use when the N closest points are taken.
		/// </summary>
		// Token: 0x0600CA55 RID: 51797 RVA: 0x001199AF File Offset: 0x00117BAF
		public virtual void SetKernelFootprint(int _arg)
		{
			vtkGeneralizedKernel.vtkGeneralizedKernel_SetKernelFootprint_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CA56 RID: 51798
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeneralizedKernel_SetKernelFootprintToNClosest_21(HandleRef pThis);

		/// <summary>
		/// Specify the interpolation basis style. By default, a Radius style is
		/// used (i.e., the basis is defined from all points within a specified
		/// radius). However, it is also possible to select the N closest points
		/// (NClosest). Note that in most formulations the Radius style is assumed
		/// as it provides better mathematical properties. However, for convenience
		/// some bases are easier to use when the N closest points are taken.
		/// </summary>
		// Token: 0x0600CA57 RID: 51799 RVA: 0x001199BF File Offset: 0x00117BBF
		public void SetKernelFootprintToNClosest()
		{
			vtkGeneralizedKernel.vtkGeneralizedKernel_SetKernelFootprintToNClosest_21(base.GetCppThis());
		}

		// Token: 0x0600CA58 RID: 51800
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeneralizedKernel_SetKernelFootprintToRadius_22(HandleRef pThis);

		/// <summary>
		/// Specify the interpolation basis style. By default, a Radius style is
		/// used (i.e., the basis is defined from all points within a specified
		/// radius). However, it is also possible to select the N closest points
		/// (NClosest). Note that in most formulations the Radius style is assumed
		/// as it provides better mathematical properties. However, for convenience
		/// some bases are easier to use when the N closest points are taken.
		/// </summary>
		// Token: 0x0600CA59 RID: 51801 RVA: 0x001199CE File Offset: 0x00117BCE
		public void SetKernelFootprintToRadius()
		{
			vtkGeneralizedKernel.vtkGeneralizedKernel_SetKernelFootprintToRadius_22(base.GetCppThis());
		}

		// Token: 0x0600CA5A RID: 51802
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeneralizedKernel_SetNormalizeWeights_23(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether the interpolation weights should be normalized after they
		/// are computed. Generally this is left on as it results in more reasonable
		/// behavior.
		/// </summary>
		// Token: 0x0600CA5B RID: 51803 RVA: 0x001199DD File Offset: 0x00117BDD
		public virtual void SetNormalizeWeights(bool _arg)
		{
			vtkGeneralizedKernel.vtkGeneralizedKernel_SetNormalizeWeights_23(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600CA5C RID: 51804
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeneralizedKernel_SetNumberOfPoints_24(HandleRef pThis, int _arg);

		/// <summary>
		/// If the interpolation basis style is NClosest, then this method specifies
		/// the number of the closest points used to form the interpolation basis.
		/// </summary>
		// Token: 0x0600CA5D RID: 51805 RVA: 0x001199F5 File Offset: 0x00117BF5
		public virtual void SetNumberOfPoints(int _arg)
		{
			vtkGeneralizedKernel.vtkGeneralizedKernel_SetNumberOfPoints_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CA5E RID: 51806
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeneralizedKernel_SetRadius_25(HandleRef pThis, double _arg);

		/// <summary>
		/// If the interpolation basis style is Radius, then this method specifies
		/// the radius within which the basis points must lie.
		/// </summary>
		// Token: 0x0600CA5F RID: 51807 RVA: 0x00119A05 File Offset: 0x00117C05
		public virtual void SetRadius(double _arg)
		{
			vtkGeneralizedKernel.vtkGeneralizedKernel_SetRadius_25(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F00 RID: 3840
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeneralizedKernel";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F01 RID: 3841
		public new static readonly string MRClassNameKey = "class vtkGeneralizedKernel";

		/// <summary>
		/// Enum used to select the interpolation basis form. By default, a Radius
		/// form is used (i.e., the basis is defined from all points within a
		/// specified radius). However, it is also possible to select the N closest
		/// points (NClosest).
		/// </summary>
		// Token: 0x0200043B RID: 1083
		public enum KernelStyle
		{
			/// <summary>enum member</summary>
			// Token: 0x04000F03 RID: 3843
			N_CLOSEST = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000F04 RID: 3844
			RADIUS = 0
		}
	}
}
