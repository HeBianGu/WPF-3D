using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSPHKernel
	/// </summary>
	/// <remarks>
	///    a family of SPH interpolation kernels
	///
	///
	/// vtkSPHKernel is an abstract superclass for smoothed-particle hydrodynamics
	/// interpolation kernels as described by D.J. Price (see full reference
	/// below).
	///
	/// Note that the kernel operates over a volume in space defined by a radius
	/// at a sampling point. The kernel implicitly assumes that the particles
	/// making up the input data satisfies physical properties such as
	/// conservation of mass. Therefore subclasses of this kernel are not
	/// generally applicable for interpolation processes, and therefore operate in
	/// conjunction with the vthSPHInterpolator class.
	///
	/// By default the kernel computes local particle volume from the spatial step^3.
	/// However, if both an optional mass and density arrays are provided then they are
	/// used to compute local volume.
	///
	/// Also be default, the local neighborhood around a point to be interpolated is
	/// computed as the CutoffFactor * SpatialStep. (Note the CutoffFactor varies for
	/// each type of SPH kernel.) However, the user may specify a CutoffArray which
	/// enables variable cutoff distances per each point.
	///
	/// @warning
	/// For more information see D.J. Price, Smoothed particle hydrodynamics and
	/// magnetohydrodynamics, J. Comput. Phys. 231:759-794, 2012. Especially
	/// equation 49.
	///
	/// @par Acknowledgments:
	/// The following work has been generously supported by Altair Engineering
	/// and FluiDyna GmbH. Please contact Steve Cosgrove or Milos Stanic for
	/// more information.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSPHKernel vtkSPHQuinticKernel vtkInterpolationKernel vtkGaussianKernel
	/// vtkShepardKernel vtkLinearKernel
	/// </seealso>
	// Token: 0x0200045C RID: 1116
	public abstract class vtkSPHKernel : vtkInterpolationKernel
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600CF67 RID: 53095 RVA: 0x00120683 File Offset: 0x0011E883
		static vtkSPHKernel()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSPHKernel.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSPHKernel"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600CF68 RID: 53096 RVA: 0x001206AB File Offset: 0x0011E8AB
		public vtkSPHKernel(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600CF69 RID: 53097 RVA: 0x001206B9 File Offset: 0x0011E8B9
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600CF6A RID: 53098
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSPHKernel_ComputeBasis_01(HandleRef pThis, IntPtr x, HandleRef pIds, long ptId);

		/// <summary>
		/// Given a point x (and optional associated ptId), determine the points
		/// around x which form an interpolation basis. The user must provide the
		/// vtkIdList pIds, which will be dynamically resized as necessary. The
		/// method returns the number of points in the basis. Typically this method
		/// is called before ComputeWeights(). Note that while ptId is optional in most
		/// cases, if a cutoff array is provided, then ptId must be provided.
		/// </summary>
		// Token: 0x0600CF6B RID: 53099 RVA: 0x001206C4 File Offset: 0x0011E8C4
		public override long ComputeBasis(IntPtr x, vtkIdList pIds, long ptId)
		{
			return vtkSPHKernel.vtkSPHKernel_ComputeBasis_01(base.GetCppThis(), x, (pIds == null) ? default(HandleRef) : pIds.GetCppThis(), ptId);
		}

		// Token: 0x0600CF6C RID: 53100
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSPHKernel_ComputeDerivWeight_02(HandleRef pThis, double d);

		/// <summary>
		/// Compute weighting factor for derivative quantities given a normalized
		/// distance from a sample point.
		/// </summary>
		// Token: 0x0600CF6D RID: 53101 RVA: 0x001206FC File Offset: 0x0011E8FC
		public virtual double ComputeDerivWeight(double d)
		{
			return vtkSPHKernel.vtkSPHKernel_ComputeDerivWeight_02(base.GetCppThis(), d);
		}

		// Token: 0x0600CF6E RID: 53102
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSPHKernel_ComputeDerivWeights_03(HandleRef pThis, IntPtr x, HandleRef pIds, HandleRef weights, HandleRef gradWeights);

		/// <summary>
		/// Given a point x, and a list of basis points pIds, compute interpolation
		/// weights, plus derivative weights, associated with these basis points.
		/// </summary>
		// Token: 0x0600CF6F RID: 53103 RVA: 0x0012071C File Offset: 0x0011E91C
		public virtual long ComputeDerivWeights(IntPtr x, vtkIdList pIds, vtkDoubleArray weights, vtkDoubleArray gradWeights)
		{
			return vtkSPHKernel.vtkSPHKernel_ComputeDerivWeights_03(base.GetCppThis(), x, (pIds == null) ? default(HandleRef) : pIds.GetCppThis(), (weights == null) ? default(HandleRef) : weights.GetCppThis(), (gradWeights == null) ? default(HandleRef) : gradWeights.GetCppThis());
		}

		// Token: 0x0600CF70 RID: 53104
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSPHKernel_ComputeFunctionWeight_04(HandleRef pThis, double d);

		/// <summary>
		/// Compute weighting factor given a normalized distance from a sample point.
		/// </summary>
		// Token: 0x0600CF71 RID: 53105 RVA: 0x00120780 File Offset: 0x0011E980
		public virtual double ComputeFunctionWeight(double d)
		{
			return vtkSPHKernel.vtkSPHKernel_ComputeFunctionWeight_04(base.GetCppThis(), d);
		}

		// Token: 0x0600CF72 RID: 53106
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSPHKernel_ComputeWeights_05(HandleRef pThis, IntPtr x, HandleRef pIds, HandleRef weights);

		/// <summary>
		/// Given a point x, and a list of basis points pIds, compute interpolation
		/// weights associated with these basis points.
		/// </summary>
		// Token: 0x0600CF73 RID: 53107 RVA: 0x001207A0 File Offset: 0x0011E9A0
		public override long ComputeWeights(IntPtr x, vtkIdList pIds, vtkDoubleArray weights)
		{
			return vtkSPHKernel.vtkSPHKernel_ComputeWeights_05(base.GetCppThis(), x, (pIds == null) ? default(HandleRef) : pIds.GetCppThis(), (weights == null) ? default(HandleRef) : weights.GetCppThis());
		}

		// Token: 0x0600CF74 RID: 53108
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSPHKernel_GetCutoffArray_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the (optional) array defining a cutoff distance. If provided this
		/// distance is used to find the interpolating points within the local
		/// neighborbood. Otherwise the cutoff distance is defined as the cutoff
		/// factor times the spatial step size.
		/// </summary>
		// Token: 0x0600CF75 RID: 53109 RVA: 0x001207EC File Offset: 0x0011E9EC
		public virtual vtkDataArray GetCutoffArray()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSPHKernel.vtkSPHKernel_GetCutoffArray_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		// Token: 0x0600CF76 RID: 53110
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSPHKernel_GetCutoffFactor_07(HandleRef pThis);

		/// <summary>
		/// Return the cutoff factor. This is hard wired into the kernel (e.g., the
		/// vtkSPHQuinticKernel has a cutoff factor = 3.0).
		/// </summary>
		// Token: 0x0600CF77 RID: 53111 RVA: 0x0012085C File Offset: 0x0011EA5C
		public virtual double GetCutoffFactor()
		{
			return vtkSPHKernel.vtkSPHKernel_GetCutoffFactor_07(base.GetCppThis());
		}

		// Token: 0x0600CF78 RID: 53112
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSPHKernel_GetDensityArray_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the (optional) density array. Used with the mass array to
		/// compute local particle volumes.
		/// </summary>
		// Token: 0x0600CF79 RID: 53113 RVA: 0x0012087C File Offset: 0x0011EA7C
		public virtual vtkDataArray GetDensityArray()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSPHKernel.vtkSPHKernel_GetDensityArray_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		// Token: 0x0600CF7A RID: 53114
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSPHKernel_GetDimension_09(HandleRef pThis);

		/// <summary>
		/// The domain dimension, default to 3.
		/// </summary>
		// Token: 0x0600CF7B RID: 53115 RVA: 0x001208EC File Offset: 0x0011EAEC
		public virtual int GetDimension()
		{
			return vtkSPHKernel.vtkSPHKernel_GetDimension_09(base.GetCppThis());
		}

		// Token: 0x0600CF7C RID: 53116
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSPHKernel_GetDimensionMaxValue_10(HandleRef pThis);

		/// <summary>
		/// The domain dimension, default to 3.
		/// </summary>
		// Token: 0x0600CF7D RID: 53117 RVA: 0x0012090C File Offset: 0x0011EB0C
		public virtual int GetDimensionMaxValue()
		{
			return vtkSPHKernel.vtkSPHKernel_GetDimensionMaxValue_10(base.GetCppThis());
		}

		// Token: 0x0600CF7E RID: 53118
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSPHKernel_GetDimensionMinValue_11(HandleRef pThis);

		/// <summary>
		/// The domain dimension, default to 3.
		/// </summary>
		// Token: 0x0600CF7F RID: 53119 RVA: 0x0012092C File Offset: 0x0011EB2C
		public virtual int GetDimensionMinValue()
		{
			return vtkSPHKernel.vtkSPHKernel_GetDimensionMinValue_11(base.GetCppThis());
		}

		// Token: 0x0600CF80 RID: 53120
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSPHKernel_GetMassArray_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the (optional) mass array. Used with the density array to
		/// compute local particle volumes.
		/// </summary>
		// Token: 0x0600CF81 RID: 53121 RVA: 0x0012094C File Offset: 0x0011EB4C
		public virtual vtkDataArray GetMassArray()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSPHKernel.vtkSPHKernel_GetMassArray_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		// Token: 0x0600CF82 RID: 53122
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSPHKernel_GetNormFactor_13(HandleRef pThis);

		/// <summary>
		/// Return the SPH normalization factor. This also includes the contribution
		/// of 1/h^d, where h is the smoothing length (i.e., spatial step) and d is
		/// the dimension of the kernel. The returned value is only valid after the
		/// kernel is initialized.
		/// </summary>
		// Token: 0x0600CF83 RID: 53123 RVA: 0x001209BC File Offset: 0x0011EBBC
		public virtual double GetNormFactor()
		{
			return vtkSPHKernel.vtkSPHKernel_GetNormFactor_13(base.GetCppThis());
		}

		// Token: 0x0600CF84 RID: 53124
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSPHKernel_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CF85 RID: 53125 RVA: 0x001209DC File Offset: 0x0011EBDC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSPHKernel.vtkSPHKernel_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x0600CF86 RID: 53126
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSPHKernel_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CF87 RID: 53127 RVA: 0x001209FC File Offset: 0x0011EBFC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSPHKernel.vtkSPHKernel_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x0600CF88 RID: 53128
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSPHKernel_GetSpatialStep_16(HandleRef pThis);

		/// <summary>
		/// The user defined initial particle spatial step. This is also referred to as
		/// the smoothing length.
		/// </summary>
		// Token: 0x0600CF89 RID: 53129 RVA: 0x00120A18 File Offset: 0x0011EC18
		public virtual double GetSpatialStep()
		{
			return vtkSPHKernel.vtkSPHKernel_GetSpatialStep_16(base.GetCppThis());
		}

		// Token: 0x0600CF8A RID: 53130
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSPHKernel_GetSpatialStepMaxValue_17(HandleRef pThis);

		/// <summary>
		/// The user defined initial particle spatial step. This is also referred to as
		/// the smoothing length.
		/// </summary>
		// Token: 0x0600CF8B RID: 53131 RVA: 0x00120A38 File Offset: 0x0011EC38
		public virtual double GetSpatialStepMaxValue()
		{
			return vtkSPHKernel.vtkSPHKernel_GetSpatialStepMaxValue_17(base.GetCppThis());
		}

		// Token: 0x0600CF8C RID: 53132
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSPHKernel_GetSpatialStepMinValue_18(HandleRef pThis);

		/// <summary>
		/// The user defined initial particle spatial step. This is also referred to as
		/// the smoothing length.
		/// </summary>
		// Token: 0x0600CF8D RID: 53133 RVA: 0x00120A58 File Offset: 0x0011EC58
		public virtual double GetSpatialStepMinValue()
		{
			return vtkSPHKernel.vtkSPHKernel_GetSpatialStepMinValue_18(base.GetCppThis());
		}

		// Token: 0x0600CF8E RID: 53134
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHKernel_Initialize_19(HandleRef pThis, HandleRef loc, HandleRef ds, HandleRef pd);

		/// <summary>
		/// Produce the computational parameters for the kernel. Invoke this method
		/// after setting initial values like SpatialStep.
		/// </summary>
		// Token: 0x0600CF8F RID: 53135 RVA: 0x00120A78 File Offset: 0x0011EC78
		public override void Initialize(vtkAbstractPointLocator loc, vtkDataSet ds, vtkPointData pd)
		{
			vtkSPHKernel.vtkSPHKernel_Initialize_19(base.GetCppThis(), (loc == null) ? default(HandleRef) : loc.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0600CF90 RID: 53136
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSPHKernel_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CF91 RID: 53137 RVA: 0x00120AD4 File Offset: 0x0011ECD4
		public override int IsA(string type)
		{
			return vtkSPHKernel.vtkSPHKernel_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x0600CF92 RID: 53138
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSPHKernel_IsTypeOf_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CF93 RID: 53139 RVA: 0x00120AF4 File Offset: 0x0011ECF4
		public new static int IsTypeOf(string type)
		{
			return vtkSPHKernel.vtkSPHKernel_IsTypeOf_21(type);
		}

		// Token: 0x0600CF94 RID: 53140
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSPHKernel_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CF95 RID: 53141 RVA: 0x00120B10 File Offset: 0x0011ED10
		public new vtkSPHKernel NewInstance()
		{
			vtkSPHKernel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSPHKernel.vtkSPHKernel_NewInstance_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSPHKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600CF96 RID: 53142
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSPHKernel_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CF97 RID: 53143 RVA: 0x00120B6C File Offset: 0x0011ED6C
		public new static vtkSPHKernel SafeDownCast(vtkObjectBase o)
		{
			vtkSPHKernel vtkSPHKernel = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSPHKernel.vtkSPHKernel_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSPHKernel = (vtkSPHKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSPHKernel.Register(null);
				}
			}
			return vtkSPHKernel;
		}

		// Token: 0x0600CF98 RID: 53144
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHKernel_SetCutoffArray_24(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the (optional) array defining a cutoff distance. If provided this
		/// distance is used to find the interpolating points within the local
		/// neighborbood. Otherwise the cutoff distance is defined as the cutoff
		/// factor times the spatial step size.
		/// </summary>
		// Token: 0x0600CF99 RID: 53145 RVA: 0x00120BEC File Offset: 0x0011EDEC
		public virtual void SetCutoffArray(vtkDataArray arg0)
		{
			vtkSPHKernel.vtkSPHKernel_SetCutoffArray_24(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600CF9A RID: 53146
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHKernel_SetDensityArray_25(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the (optional) density array. Used with the mass array to
		/// compute local particle volumes.
		/// </summary>
		// Token: 0x0600CF9B RID: 53147 RVA: 0x00120C1C File Offset: 0x0011EE1C
		public virtual void SetDensityArray(vtkDataArray arg0)
		{
			vtkSPHKernel.vtkSPHKernel_SetDensityArray_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600CF9C RID: 53148
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHKernel_SetDimension_26(HandleRef pThis, int _arg);

		/// <summary>
		/// The domain dimension, default to 3.
		/// </summary>
		// Token: 0x0600CF9D RID: 53149 RVA: 0x00120C4B File Offset: 0x0011EE4B
		public virtual void SetDimension(int _arg)
		{
			vtkSPHKernel.vtkSPHKernel_SetDimension_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CF9E RID: 53150
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHKernel_SetMassArray_27(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the (optional) mass array. Used with the density array to
		/// compute local particle volumes.
		/// </summary>
		// Token: 0x0600CF9F RID: 53151 RVA: 0x00120C5C File Offset: 0x0011EE5C
		public virtual void SetMassArray(vtkDataArray arg0)
		{
			vtkSPHKernel.vtkSPHKernel_SetMassArray_27(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600CFA0 RID: 53152
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHKernel_SetSpatialStep_28(HandleRef pThis, double _arg);

		/// <summary>
		/// The user defined initial particle spatial step. This is also referred to as
		/// the smoothing length.
		/// </summary>
		// Token: 0x0600CFA1 RID: 53153 RVA: 0x00120C8B File Offset: 0x0011EE8B
		public virtual void SetSpatialStep(double _arg)
		{
			vtkSPHKernel.vtkSPHKernel_SetSpatialStep_28(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F56 RID: 3926
		public new const string MRFullTypeName = "Kitware.VTK.vtkSPHKernel";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F57 RID: 3927
		public new static readonly string MRClassNameKey = "class vtkSPHKernel";
	}
}
