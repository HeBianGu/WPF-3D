using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSPHInterpolator
	/// </summary>
	/// <remarks>
	///    interpolate over point cloud using SPH kernels
	///
	///
	/// This filter uses SPH (smooth particle hydrodynamics) kernels to
	/// interpolate a data source onto an input structure. For example, while the
	/// data source is a set of particles, the data from these particles can be
	/// interpolated onto an input object such as a line, plane or volume. Then
	/// the output (which consists of the input structure plus interpolated data)
	/// can then be visualized using classical visualization techniques such as
	/// isocontouring, slicing, heat maps and so on.
	///
	/// To use this filter, besides setting the input P and source Pc, specify a
	/// point locator (which accelerates queries about points and their neighbors)
	/// and an interpolation kernel (a subclass of vtkSPHKernel). In addition, the
	/// name of the source's density and mass arrays can optionally be provided;
	/// however if not provided then the local volume is computed from the
	/// kernel's spatial step. Finally, a cutoff distance array can optionally be
	/// provided (as part of the input P point data) when the local neighborhood
	/// around each sample point varies. The cutoff distance defines a local
	/// neighborhood in which the points in that neighborhood are used to
	/// interpolate values. If not provided, then the cutoff distance is computed
	/// from the spatial step size times the cutoff factor (see vtkSPHKernel).
	///
	/// Other options to the filter include specifying which data attributes to
	/// interpolate from the source. By default, all data attributes contained in
	/// the source are interpolated. However, by adding array names to the
	/// exclusion list, these arrays will not be interpolated. Also, it is
	/// possible to use a SPH derivative formulation to interpolate from the
	/// source data attributes. This requires adding arrays (by name) to the
	/// derivative list, in which case the derivative formulation will be applied
	/// to create a new output array named "X_deriv" where X is the name of a
	/// source point attribute array.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// @warning
	/// For widely spaced points in Pc, or when p is located outside the bounding
	/// region of Pc, the interpolation may behave badly and the interpolation
	/// process will adapt as necessary to produce output. For example, if the N
	/// closest points within R are requested to interpolate p, if N=0 then the
	/// interpolation will switch to a different strategy (which can be controlled
	/// as in the NullPointsStrategy).
	///
	/// @warning
	/// For more information and technical reference, see D.J. Price, Smoothed
	/// particle hydrodynamics and magnetohydrodynamics,
	/// J. Comput. Phys. 231:759-794, 2012. Especially equation 49.
	///
	/// @par Acknowledgments:
	/// The following work has been generously supported by Altair Engineering
	/// and FluiDyna GmbH. Please contact Steve Cosgrove or Milos Stanic for
	/// more information.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPointInterpolator vtkSPHKernel vtkSPHQuinticKernel
	/// </seealso>
	// Token: 0x0200045E RID: 1118
	public class vtkSPHInterpolator : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600CFBA RID: 53178 RVA: 0x00120F67 File Offset: 0x0011F167
		static vtkSPHInterpolator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSPHInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSPHInterpolator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600CFBB RID: 53179 RVA: 0x00120F8F File Offset: 0x0011F18F
		public vtkSPHInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600CFBC RID: 53180
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSPHInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600CFBD RID: 53181 RVA: 0x00120FA0 File Offset: 0x0011F1A0
		public new static vtkSPHInterpolator New()
		{
			vtkSPHInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSPHInterpolator.vtkSPHInterpolator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSPHInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600CFBE RID: 53182 RVA: 0x00120FF4 File Offset: 0x0011F1F4
		public vtkSPHInterpolator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSPHInterpolator.vtkSPHInterpolator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600CFBF RID: 53183 RVA: 0x00121038 File Offset: 0x0011F238
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600CFC0 RID: 53184
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_AddDerivativeArray_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string derivArray);

		/// <summary>
		/// Adds an array to the list of arrays whose derivative is to be taken. If
		/// the name of the array is "derivArray" this will produce an output array
		/// with the name "derivArray_deriv" (after filter execution).
		/// </summary>
		// Token: 0x0600CFC1 RID: 53185 RVA: 0x00121043 File Offset: 0x0011F243
		public void AddDerivativeArray(string derivArray)
		{
			vtkSPHInterpolator.vtkSPHInterpolator_AddDerivativeArray_01(base.GetCppThis(), derivArray);
		}

		// Token: 0x0600CFC2 RID: 53186
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_AddExcludedArray_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string excludedArray);

		/// <summary>
		/// Adds an array to the list of arrays which are to be excluded from the
		/// interpolation process.
		/// </summary>
		// Token: 0x0600CFC3 RID: 53187 RVA: 0x00121053 File Offset: 0x0011F253
		public void AddExcludedArray(string excludedArray)
		{
			vtkSPHInterpolator.vtkSPHInterpolator_AddExcludedArray_02(base.GetCppThis(), excludedArray);
		}

		// Token: 0x0600CFC4 RID: 53188
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_ClearDerivativeArrays_03(HandleRef pThis);

		/// <summary>
		/// Clears the contents of derivative array list.
		/// </summary>
		// Token: 0x0600CFC5 RID: 53189 RVA: 0x00121063 File Offset: 0x0011F263
		public void ClearDerivativeArrays()
		{
			vtkSPHInterpolator.vtkSPHInterpolator_ClearDerivativeArrays_03(base.GetCppThis());
		}

		// Token: 0x0600CFC6 RID: 53190
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_ClearExcludedArrays_04(HandleRef pThis);

		/// <summary>
		/// Clears the contents of excluded array list.
		/// </summary>
		// Token: 0x0600CFC7 RID: 53191 RVA: 0x00121072 File Offset: 0x0011F272
		public void ClearExcludedArrays()
		{
			vtkSPHInterpolator.vtkSPHInterpolator_ClearExcludedArrays_04(base.GetCppThis());
		}

		// Token: 0x0600CFC8 RID: 53192
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_ComputeShepardSumOff_05(HandleRef pThis);

		/// <summary>
		/// Indicate whether to compute the summation of weighting coefficients (the
		/// so-called Shepard sum). In the interior of a SPH point cloud, the
		/// Shepard summation value should be ~1.0.  Towards the boundary, the
		/// Shepard summation generally falls off &lt;1.0. If ComputeShepardSum is specified, then the
		/// output will contain an array of summed Shepard weights for each output
		/// point. On by default.
		/// </summary>
		// Token: 0x0600CFC9 RID: 53193 RVA: 0x00121081 File Offset: 0x0011F281
		public virtual void ComputeShepardSumOff()
		{
			vtkSPHInterpolator.vtkSPHInterpolator_ComputeShepardSumOff_05(base.GetCppThis());
		}

		// Token: 0x0600CFCA RID: 53194
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_ComputeShepardSumOn_06(HandleRef pThis);

		/// <summary>
		/// Indicate whether to compute the summation of weighting coefficients (the
		/// so-called Shepard sum). In the interior of a SPH point cloud, the
		/// Shepard summation value should be ~1.0.  Towards the boundary, the
		/// Shepard summation generally falls off &lt;1.0. If ComputeShepardSum is specified, then the
		/// output will contain an array of summed Shepard weights for each output
		/// point. On by default.
		/// </summary>
		// Token: 0x0600CFCB RID: 53195 RVA: 0x00121090 File Offset: 0x0011F290
		public virtual void ComputeShepardSumOn()
		{
			vtkSPHInterpolator.vtkSPHInterpolator_ComputeShepardSumOn_06(base.GetCppThis());
		}

		// Token: 0x0600CFCC RID: 53196
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSPHInterpolator_GetComputeShepardSum_07(HandleRef pThis);

		/// <summary>
		/// Indicate whether to compute the summation of weighting coefficients (the
		/// so-called Shepard sum). In the interior of a SPH point cloud, the
		/// Shepard summation value should be ~1.0.  Towards the boundary, the
		/// Shepard summation generally falls off &lt;1.0. If ComputeShepardSum is specified, then the
		/// output will contain an array of summed Shepard weights for each output
		/// point. On by default.
		/// </summary>
		// Token: 0x0600CFCD RID: 53197 RVA: 0x001210A0 File Offset: 0x0011F2A0
		public virtual int GetComputeShepardSum()
		{
			return vtkSPHInterpolator.vtkSPHInterpolator_GetComputeShepardSum_07(base.GetCppThis());
		}

		// Token: 0x0600CFCE RID: 53198
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkSPHInterpolator_GetCutoffArrayName_08(HandleRef pThis);

		/// <summary>
		/// Specify an (optional) cutoff distance for each point in the input P. If
		/// not specified, then the kernel cutoff is used.
		/// </summary>
		// Token: 0x0600CFCF RID: 53199 RVA: 0x001210C0 File Offset: 0x0011F2C0
		public virtual string GetCutoffArrayName()
		{
			return vtkSPHInterpolator.vtkSPHInterpolator_GetCutoffArrayName_08(base.GetCppThis());
		}

		// Token: 0x0600CFD0 RID: 53200
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkSPHInterpolator_GetDensityArrayName_09(HandleRef pThis);

		/// <summary>
		/// Specify the density array name. This is optional. Typically both the density
		/// and mass arrays are specified together (in order to compute the local volume).
		/// Both the mass and density arrays must consist of tuples of 1-component. (Note that
		/// the density array name specifies a point array found in the Pc source.)
		/// </summary>
		// Token: 0x0600CFD1 RID: 53201 RVA: 0x001210E0 File Offset: 0x0011F2E0
		public virtual string GetDensityArrayName()
		{
			return vtkSPHInterpolator.vtkSPHInterpolator_GetDensityArrayName_09(base.GetCppThis());
		}

		// Token: 0x0600CFD2 RID: 53202
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSPHInterpolator_GetDerivativeArray_10(HandleRef pThis, int i);

		/// <summary>
		/// Return the name of the ith derivative array.
		/// </summary>
		// Token: 0x0600CFD3 RID: 53203 RVA: 0x00121100 File Offset: 0x0011F300
		public string GetDerivativeArray(int i)
		{
			string s = Marshal.PtrToStringAnsi(vtkSPHInterpolator.vtkSPHInterpolator_GetDerivativeArray_10(base.GetCppThis(), i));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600CFD4 RID: 53204
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSPHInterpolator_GetExcludedArray_11(HandleRef pThis, int i);

		/// <summary>
		/// Return the name of the ith excluded array.
		/// </summary>
		// Token: 0x0600CFD5 RID: 53205 RVA: 0x0012113C File Offset: 0x0011F33C
		public string GetExcludedArray(int i)
		{
			string s = Marshal.PtrToStringAnsi(vtkSPHInterpolator.vtkSPHInterpolator_GetExcludedArray_11(base.GetCppThis(), i));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600CFD6 RID: 53206
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSPHInterpolator_GetKernel_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify an interpolation kernel. By default a vtkSPHQuinticKernel is used
		/// (i.e., closest point). The interpolation kernel changes the basis of the
		/// interpolation.
		/// </summary>
		// Token: 0x0600CFD7 RID: 53207 RVA: 0x00121178 File Offset: 0x0011F378
		public virtual vtkSPHKernel GetKernel()
		{
			vtkSPHKernel vtkSPHKernel = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSPHInterpolator.vtkSPHInterpolator_GetKernel_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600CFD8 RID: 53208
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSPHInterpolator_GetLocator_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a point locator. By default a vtkStaticPointLocator is
		/// used. The locator performs efficient searches to locate near a
		/// specified interpolation position.
		/// </summary>
		// Token: 0x0600CFD9 RID: 53209 RVA: 0x001211E8 File Offset: 0x0011F3E8
		public virtual vtkAbstractPointLocator GetLocator()
		{
			vtkAbstractPointLocator vtkAbstractPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSPHInterpolator.vtkSPHInterpolator_GetLocator_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractPointLocator = (vtkAbstractPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractPointLocator.Register(null);
				}
			}
			return vtkAbstractPointLocator;
		}

		// Token: 0x0600CFDA RID: 53210
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkSPHInterpolator_GetMTime_14(HandleRef pThis);

		/// <summary>
		/// Get the MTime of this object also considering the locator and kernel.
		/// </summary>
		// Token: 0x0600CFDB RID: 53211 RVA: 0x00121258 File Offset: 0x0011F458
		public override ulong GetMTime()
		{
			return vtkSPHInterpolator.vtkSPHInterpolator_GetMTime_14(base.GetCppThis());
		}

		// Token: 0x0600CFDC RID: 53212
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkSPHInterpolator_GetMassArrayName_15(HandleRef pThis);

		/// <summary>
		/// Specify the mass array name. This is optional. Typically both the
		/// density and mass arrays are specified together (in order to compute the
		/// local volume).  Both the mass and density arrays must consist of tuples
		/// of 1-component. (Note that the mass array name specifies a point
		/// array found in the Pc source.)
		/// </summary>
		// Token: 0x0600CFDD RID: 53213 RVA: 0x00121278 File Offset: 0x0011F478
		public virtual string GetMassArrayName()
		{
			return vtkSPHInterpolator.vtkSPHInterpolator_GetMassArrayName_15(base.GetCppThis());
		}

		// Token: 0x0600CFDE RID: 53214
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSPHInterpolator_GetNullPointsStrategy_16(HandleRef pThis);

		/// <summary>
		/// Specify a strategy to use when encountering a "null" point during the
		/// interpolation process. Null points occur when the local neighborhood (of
		/// nearby points to interpolate from) is empty. If the strategy is set to
		/// MaskPoints, then an output array is created that marks points as being
		/// valid (=1) or null (invalid =0) (and the NullValue is set as well). If
		/// the strategy is set to NullValue, then the output data value(s) are set
		/// to the NullPoint value.
		/// </summary>
		// Token: 0x0600CFDF RID: 53215 RVA: 0x00121298 File Offset: 0x0011F498
		public virtual int GetNullPointsStrategy()
		{
			return vtkSPHInterpolator.vtkSPHInterpolator_GetNullPointsStrategy_16(base.GetCppThis());
		}

		// Token: 0x0600CFE0 RID: 53216
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkSPHInterpolator_GetNullValue_17(HandleRef pThis);

		/// <summary>
		/// Specify the null point value. When a null point is encountered then all
		/// components of each null tuple are set to this value. By default the
		/// null value is set to zero.
		/// </summary>
		// Token: 0x0600CFE1 RID: 53217 RVA: 0x001212B8 File Offset: 0x0011F4B8
		public virtual double GetNullValue()
		{
			return vtkSPHInterpolator.vtkSPHInterpolator_GetNullValue_17(base.GetCppThis());
		}

		// Token: 0x0600CFE2 RID: 53218
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSPHInterpolator_GetNumberOfDerivativeArrays_18(HandleRef pThis);

		/// <summary>
		/// Return the number of derivative arrays.
		/// </summary>
		// Token: 0x0600CFE3 RID: 53219 RVA: 0x001212D8 File Offset: 0x0011F4D8
		public int GetNumberOfDerivativeArrays()
		{
			return vtkSPHInterpolator.vtkSPHInterpolator_GetNumberOfDerivativeArrays_18(base.GetCppThis());
		}

		// Token: 0x0600CFE4 RID: 53220
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSPHInterpolator_GetNumberOfExcludedArrays_19(HandleRef pThis);

		/// <summary>
		/// Return the number of excluded arrays.
		/// </summary>
		// Token: 0x0600CFE5 RID: 53221 RVA: 0x001212F8 File Offset: 0x0011F4F8
		public int GetNumberOfExcludedArrays()
		{
			return vtkSPHInterpolator.vtkSPHInterpolator_GetNumberOfExcludedArrays_19(base.GetCppThis());
		}

		// Token: 0x0600CFE6 RID: 53222
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSPHInterpolator_GetNumberOfGenerationsFromBase_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600CFE7 RID: 53223 RVA: 0x00121318 File Offset: 0x0011F518
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSPHInterpolator.vtkSPHInterpolator_GetNumberOfGenerationsFromBase_20(base.GetCppThis(), type);
		}

		// Token: 0x0600CFE8 RID: 53224
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSPHInterpolator_GetNumberOfGenerationsFromBaseType_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600CFE9 RID: 53225 RVA: 0x00121338 File Offset: 0x0011F538
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSPHInterpolator.vtkSPHInterpolator_GetNumberOfGenerationsFromBaseType_21(type);
		}

		// Token: 0x0600CFEA RID: 53226
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSPHInterpolator_GetPassCellArrays_22(HandleRef pThis);

		/// <summary>
		/// Indicate whether to shallow copy the input cell data arrays to the
		/// output. On by default.
		/// </summary>
		// Token: 0x0600CFEB RID: 53227 RVA: 0x00121354 File Offset: 0x0011F554
		public virtual int GetPassCellArrays()
		{
			return vtkSPHInterpolator.vtkSPHInterpolator_GetPassCellArrays_22(base.GetCppThis());
		}

		// Token: 0x0600CFEC RID: 53228
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSPHInterpolator_GetPassFieldArrays_23(HandleRef pThis);

		/// <summary>
		/// Indicate whether to pass the field-data arrays from the input to the
		/// output. On by default.
		/// </summary>
		// Token: 0x0600CFED RID: 53229 RVA: 0x00121374 File Offset: 0x0011F574
		public virtual int GetPassFieldArrays()
		{
			return vtkSPHInterpolator.vtkSPHInterpolator_GetPassFieldArrays_23(base.GetCppThis());
		}

		// Token: 0x0600CFEE RID: 53230
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSPHInterpolator_GetPassPointArrays_24(HandleRef pThis);

		/// <summary>
		/// Indicate whether to shallow copy the input point data arrays to the
		/// output. On by default.
		/// </summary>
		// Token: 0x0600CFEF RID: 53231 RVA: 0x00121394 File Offset: 0x0011F594
		public virtual int GetPassPointArrays()
		{
			return vtkSPHInterpolator.vtkSPHInterpolator_GetPassPointArrays_24(base.GetCppThis());
		}

		// Token: 0x0600CFF0 RID: 53232
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSPHInterpolator_GetPromoteOutputArrays_25(HandleRef pThis);

		/// <summary>
		/// If enabled, then input arrays that are non-real types (i.e., not float
		/// or double) are promoted to float type on output. This is because the
		/// interpolation process may not be well behaved when integral types are
		/// combined using interpolation weights.
		/// </summary>
		// Token: 0x0600CFF1 RID: 53233 RVA: 0x001213B4 File Offset: 0x0011F5B4
		public virtual int GetPromoteOutputArrays()
		{
			return vtkSPHInterpolator.vtkSPHInterpolator_GetPromoteOutputArrays_25(base.GetCppThis());
		}

		// Token: 0x0600CFF2 RID: 53234
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSPHInterpolator_GetShepardNormalization_26(HandleRef pThis);

		/// <summary>
		/// Indicate whether to normalize all arrays with the Shepard coefficients
		/// (except the density array and the Shepard sum array). If the Shepard
		/// coefficient is 0, then the data value is set to zero. Note that enabling
		/// ShepardNormalization forces the computation of the ShepardSum array.
		/// </summary>
		// Token: 0x0600CFF3 RID: 53235 RVA: 0x001213D4 File Offset: 0x0011F5D4
		public virtual int GetShepardNormalization()
		{
			return vtkSPHInterpolator.vtkSPHInterpolator_GetShepardNormalization_26(base.GetCppThis());
		}

		// Token: 0x0600CFF4 RID: 53236
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkSPHInterpolator_GetShepardSumArrayName_27(HandleRef pThis);

		/// <summary>
		/// If ComputeShepardSum is on, then an array is generated with name
		/// ShepardSumArrayName for each input point. This vtkFloatArray is placed
		/// into the output of the filter, and NullPoints have value =0.0. The
		/// default name is "Shepard Summation".
		/// </summary>
		// Token: 0x0600CFF5 RID: 53237 RVA: 0x001213F4 File Offset: 0x0011F5F4
		public virtual string GetShepardSumArrayName()
		{
			return vtkSPHInterpolator.vtkSPHInterpolator_GetShepardSumArrayName_27(base.GetCppThis());
		}

		// Token: 0x0600CFF6 RID: 53238
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSPHInterpolator_GetSource_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the dataset Pc that will be probed by the input points P.  The
		/// Input P defines the dataset structure (the points and cells) for the
		/// output, while the Source Pc is probed (interpolated) to generate the
		/// scalars, vectors, etc. for the output points based on the point
		/// locations.
		/// </summary>
		// Token: 0x0600CFF7 RID: 53239 RVA: 0x00121414 File Offset: 0x0011F614
		public vtkDataObject GetSource()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSPHInterpolator.vtkSPHInterpolator_GetSource_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x0600CFF8 RID: 53240
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkSPHInterpolator_GetValidPointsMaskArrayName_29(HandleRef pThis);

		/// <summary>
		/// If the NullPointsStrategy == MASK_POINTS, then an array is generated for
		/// each input point. This vtkCharArray is placed into the output of the filter,
		/// with a non-zero value for a valid point, and zero otherwise. The name of
		/// this masking array is specified here.
		/// </summary>
		// Token: 0x0600CFF9 RID: 53241 RVA: 0x00121484 File Offset: 0x0011F684
		public virtual string GetValidPointsMaskArrayName()
		{
			return vtkSPHInterpolator.vtkSPHInterpolator_GetValidPointsMaskArrayName_29(base.GetCppThis());
		}

		// Token: 0x0600CFFA RID: 53242
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSPHInterpolator_IsA_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600CFFB RID: 53243 RVA: 0x001214A4 File Offset: 0x0011F6A4
		public override int IsA(string type)
		{
			return vtkSPHInterpolator.vtkSPHInterpolator_IsA_30(base.GetCppThis(), type);
		}

		// Token: 0x0600CFFC RID: 53244
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSPHInterpolator_IsTypeOf_31([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600CFFD RID: 53245 RVA: 0x001214C4 File Offset: 0x0011F6C4
		public new static int IsTypeOf(string type)
		{
			return vtkSPHInterpolator.vtkSPHInterpolator_IsTypeOf_31(type);
		}

		// Token: 0x0600CFFE RID: 53246
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSPHInterpolator_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600CFFF RID: 53247 RVA: 0x001214E0 File Offset: 0x0011F6E0
		public new vtkSPHInterpolator NewInstance()
		{
			vtkSPHInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSPHInterpolator.vtkSPHInterpolator_NewInstance_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSPHInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D000 RID: 53248
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_PassCellArraysOff_34(HandleRef pThis);

		/// <summary>
		/// Indicate whether to shallow copy the input cell data arrays to the
		/// output. On by default.
		/// </summary>
		// Token: 0x0600D001 RID: 53249 RVA: 0x0012153A File Offset: 0x0011F73A
		public virtual void PassCellArraysOff()
		{
			vtkSPHInterpolator.vtkSPHInterpolator_PassCellArraysOff_34(base.GetCppThis());
		}

		// Token: 0x0600D002 RID: 53250
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_PassCellArraysOn_35(HandleRef pThis);

		/// <summary>
		/// Indicate whether to shallow copy the input cell data arrays to the
		/// output. On by default.
		/// </summary>
		// Token: 0x0600D003 RID: 53251 RVA: 0x00121549 File Offset: 0x0011F749
		public virtual void PassCellArraysOn()
		{
			vtkSPHInterpolator.vtkSPHInterpolator_PassCellArraysOn_35(base.GetCppThis());
		}

		// Token: 0x0600D004 RID: 53252
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_PassFieldArraysOff_36(HandleRef pThis);

		/// <summary>
		/// Indicate whether to pass the field-data arrays from the input to the
		/// output. On by default.
		/// </summary>
		// Token: 0x0600D005 RID: 53253 RVA: 0x00121558 File Offset: 0x0011F758
		public virtual void PassFieldArraysOff()
		{
			vtkSPHInterpolator.vtkSPHInterpolator_PassFieldArraysOff_36(base.GetCppThis());
		}

		// Token: 0x0600D006 RID: 53254
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_PassFieldArraysOn_37(HandleRef pThis);

		/// <summary>
		/// Indicate whether to pass the field-data arrays from the input to the
		/// output. On by default.
		/// </summary>
		// Token: 0x0600D007 RID: 53255 RVA: 0x00121567 File Offset: 0x0011F767
		public virtual void PassFieldArraysOn()
		{
			vtkSPHInterpolator.vtkSPHInterpolator_PassFieldArraysOn_37(base.GetCppThis());
		}

		// Token: 0x0600D008 RID: 53256
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_PassPointArraysOff_38(HandleRef pThis);

		/// <summary>
		/// Indicate whether to shallow copy the input point data arrays to the
		/// output. On by default.
		/// </summary>
		// Token: 0x0600D009 RID: 53257 RVA: 0x00121576 File Offset: 0x0011F776
		public virtual void PassPointArraysOff()
		{
			vtkSPHInterpolator.vtkSPHInterpolator_PassPointArraysOff_38(base.GetCppThis());
		}

		// Token: 0x0600D00A RID: 53258
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_PassPointArraysOn_39(HandleRef pThis);

		/// <summary>
		/// Indicate whether to shallow copy the input point data arrays to the
		/// output. On by default.
		/// </summary>
		// Token: 0x0600D00B RID: 53259 RVA: 0x00121585 File Offset: 0x0011F785
		public virtual void PassPointArraysOn()
		{
			vtkSPHInterpolator.vtkSPHInterpolator_PassPointArraysOn_39(base.GetCppThis());
		}

		// Token: 0x0600D00C RID: 53260
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_PromoteOutputArraysOff_40(HandleRef pThis);

		/// <summary>
		/// If enabled, then input arrays that are non-real types (i.e., not float
		/// or double) are promoted to float type on output. This is because the
		/// interpolation process may not be well behaved when integral types are
		/// combined using interpolation weights.
		/// </summary>
		// Token: 0x0600D00D RID: 53261 RVA: 0x00121594 File Offset: 0x0011F794
		public virtual void PromoteOutputArraysOff()
		{
			vtkSPHInterpolator.vtkSPHInterpolator_PromoteOutputArraysOff_40(base.GetCppThis());
		}

		// Token: 0x0600D00E RID: 53262
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_PromoteOutputArraysOn_41(HandleRef pThis);

		/// <summary>
		/// If enabled, then input arrays that are non-real types (i.e., not float
		/// or double) are promoted to float type on output. This is because the
		/// interpolation process may not be well behaved when integral types are
		/// combined using interpolation weights.
		/// </summary>
		// Token: 0x0600D00F RID: 53263 RVA: 0x001215A3 File Offset: 0x0011F7A3
		public virtual void PromoteOutputArraysOn()
		{
			vtkSPHInterpolator.vtkSPHInterpolator_PromoteOutputArraysOn_41(base.GetCppThis());
		}

		// Token: 0x0600D010 RID: 53264
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSPHInterpolator_SafeDownCast_42(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing.
		/// </summary>
		// Token: 0x0600D011 RID: 53265 RVA: 0x001215B4 File Offset: 0x0011F7B4
		public new static vtkSPHInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkSPHInterpolator vtkSPHInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSPHInterpolator.vtkSPHInterpolator_SafeDownCast_42((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSPHInterpolator = (vtkSPHInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSPHInterpolator.Register(null);
				}
			}
			return vtkSPHInterpolator;
		}

		// Token: 0x0600D012 RID: 53266
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_SetComputeShepardSum_43(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate whether to compute the summation of weighting coefficients (the
		/// so-called Shepard sum). In the interior of a SPH point cloud, the
		/// Shepard summation value should be ~1.0.  Towards the boundary, the
		/// Shepard summation generally falls off &lt;1.0. If ComputeShepardSum is specified, then the
		/// output will contain an array of summed Shepard weights for each output
		/// point. On by default.
		/// </summary>
		// Token: 0x0600D013 RID: 53267 RVA: 0x00121633 File Offset: 0x0011F833
		public virtual void SetComputeShepardSum(int _arg)
		{
			vtkSPHInterpolator.vtkSPHInterpolator_SetComputeShepardSum_43(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D014 RID: 53268
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_SetCutoffArrayName_44(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify an (optional) cutoff distance for each point in the input P. If
		/// not specified, then the kernel cutoff is used.
		/// </summary>
		// Token: 0x0600D015 RID: 53269 RVA: 0x00121643 File Offset: 0x0011F843
		public virtual void SetCutoffArrayName(string _arg)
		{
			vtkSPHInterpolator.vtkSPHInterpolator_SetCutoffArrayName_44(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D016 RID: 53270
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_SetDensityArrayName_45(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the density array name. This is optional. Typically both the density
		/// and mass arrays are specified together (in order to compute the local volume).
		/// Both the mass and density arrays must consist of tuples of 1-component. (Note that
		/// the density array name specifies a point array found in the Pc source.)
		/// </summary>
		// Token: 0x0600D017 RID: 53271 RVA: 0x00121653 File Offset: 0x0011F853
		public virtual void SetDensityArrayName(string _arg)
		{
			vtkSPHInterpolator.vtkSPHInterpolator_SetDensityArrayName_45(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D018 RID: 53272
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_SetKernel_46(HandleRef pThis, HandleRef kernel);

		/// <summary>
		/// Specify an interpolation kernel. By default a vtkSPHQuinticKernel is used
		/// (i.e., closest point). The interpolation kernel changes the basis of the
		/// interpolation.
		/// </summary>
		// Token: 0x0600D019 RID: 53273 RVA: 0x00121664 File Offset: 0x0011F864
		public void SetKernel(vtkSPHKernel kernel)
		{
			vtkSPHInterpolator.vtkSPHInterpolator_SetKernel_46(base.GetCppThis(), (kernel == null) ? default(HandleRef) : kernel.GetCppThis());
		}

		// Token: 0x0600D01A RID: 53274
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_SetLocator_47(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Specify a point locator. By default a vtkStaticPointLocator is
		/// used. The locator performs efficient searches to locate near a
		/// specified interpolation position.
		/// </summary>
		// Token: 0x0600D01B RID: 53275 RVA: 0x00121694 File Offset: 0x0011F894
		public void SetLocator(vtkAbstractPointLocator locator)
		{
			vtkSPHInterpolator.vtkSPHInterpolator_SetLocator_47(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0600D01C RID: 53276
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_SetMassArrayName_48(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the mass array name. This is optional. Typically both the
		/// density and mass arrays are specified together (in order to compute the
		/// local volume).  Both the mass and density arrays must consist of tuples
		/// of 1-component. (Note that the mass array name specifies a point
		/// array found in the Pc source.)
		/// </summary>
		// Token: 0x0600D01D RID: 53277 RVA: 0x001216C3 File Offset: 0x0011F8C3
		public virtual void SetMassArrayName(string _arg)
		{
			vtkSPHInterpolator.vtkSPHInterpolator_SetMassArrayName_48(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D01E RID: 53278
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_SetNullPointsStrategy_49(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify a strategy to use when encountering a "null" point during the
		/// interpolation process. Null points occur when the local neighborhood (of
		/// nearby points to interpolate from) is empty. If the strategy is set to
		/// MaskPoints, then an output array is created that marks points as being
		/// valid (=1) or null (invalid =0) (and the NullValue is set as well). If
		/// the strategy is set to NullValue, then the output data value(s) are set
		/// to the NullPoint value.
		/// </summary>
		// Token: 0x0600D01F RID: 53279 RVA: 0x001216D3 File Offset: 0x0011F8D3
		public virtual void SetNullPointsStrategy(int _arg)
		{
			vtkSPHInterpolator.vtkSPHInterpolator_SetNullPointsStrategy_49(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D020 RID: 53280
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_SetNullPointsStrategyToMaskPoints_50(HandleRef pThis);

		/// <summary>
		/// Specify a strategy to use when encountering a "null" point during the
		/// interpolation process. Null points occur when the local neighborhood (of
		/// nearby points to interpolate from) is empty. If the strategy is set to
		/// MaskPoints, then an output array is created that marks points as being
		/// valid (=1) or null (invalid =0) (and the NullValue is set as well). If
		/// the strategy is set to NullValue, then the output data value(s) are set
		/// to the NullPoint value.
		/// </summary>
		// Token: 0x0600D021 RID: 53281 RVA: 0x001216E3 File Offset: 0x0011F8E3
		public void SetNullPointsStrategyToMaskPoints()
		{
			vtkSPHInterpolator.vtkSPHInterpolator_SetNullPointsStrategyToMaskPoints_50(base.GetCppThis());
		}

		// Token: 0x0600D022 RID: 53282
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_SetNullPointsStrategyToNullValue_51(HandleRef pThis);

		/// <summary>
		/// Specify a strategy to use when encountering a "null" point during the
		/// interpolation process. Null points occur when the local neighborhood (of
		/// nearby points to interpolate from) is empty. If the strategy is set to
		/// MaskPoints, then an output array is created that marks points as being
		/// valid (=1) or null (invalid =0) (and the NullValue is set as well). If
		/// the strategy is set to NullValue, then the output data value(s) are set
		/// to the NullPoint value.
		/// </summary>
		// Token: 0x0600D023 RID: 53283 RVA: 0x001216F2 File Offset: 0x0011F8F2
		public void SetNullPointsStrategyToNullValue()
		{
			vtkSPHInterpolator.vtkSPHInterpolator_SetNullPointsStrategyToNullValue_51(base.GetCppThis());
		}

		// Token: 0x0600D024 RID: 53284
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_SetNullValue_52(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the null point value. When a null point is encountered then all
		/// components of each null tuple are set to this value. By default the
		/// null value is set to zero.
		/// </summary>
		// Token: 0x0600D025 RID: 53285 RVA: 0x00121701 File Offset: 0x0011F901
		public virtual void SetNullValue(double _arg)
		{
			vtkSPHInterpolator.vtkSPHInterpolator_SetNullValue_52(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D026 RID: 53286
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_SetPassCellArrays_53(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate whether to shallow copy the input cell data arrays to the
		/// output. On by default.
		/// </summary>
		// Token: 0x0600D027 RID: 53287 RVA: 0x00121711 File Offset: 0x0011F911
		public virtual void SetPassCellArrays(int _arg)
		{
			vtkSPHInterpolator.vtkSPHInterpolator_SetPassCellArrays_53(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D028 RID: 53288
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_SetPassFieldArrays_54(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate whether to pass the field-data arrays from the input to the
		/// output. On by default.
		/// </summary>
		// Token: 0x0600D029 RID: 53289 RVA: 0x00121721 File Offset: 0x0011F921
		public virtual void SetPassFieldArrays(int _arg)
		{
			vtkSPHInterpolator.vtkSPHInterpolator_SetPassFieldArrays_54(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D02A RID: 53290
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_SetPassPointArrays_55(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate whether to shallow copy the input point data arrays to the
		/// output. On by default.
		/// </summary>
		// Token: 0x0600D02B RID: 53291 RVA: 0x00121731 File Offset: 0x0011F931
		public virtual void SetPassPointArrays(int _arg)
		{
			vtkSPHInterpolator.vtkSPHInterpolator_SetPassPointArrays_55(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D02C RID: 53292
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_SetPromoteOutputArrays_56(HandleRef pThis, int _arg);

		/// <summary>
		/// If enabled, then input arrays that are non-real types (i.e., not float
		/// or double) are promoted to float type on output. This is because the
		/// interpolation process may not be well behaved when integral types are
		/// combined using interpolation weights.
		/// </summary>
		// Token: 0x0600D02D RID: 53293 RVA: 0x00121741 File Offset: 0x0011F941
		public virtual void SetPromoteOutputArrays(int _arg)
		{
			vtkSPHInterpolator.vtkSPHInterpolator_SetPromoteOutputArrays_56(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D02E RID: 53294
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_SetShepardNormalization_57(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate whether to normalize all arrays with the Shepard coefficients
		/// (except the density array and the Shepard sum array). If the Shepard
		/// coefficient is 0, then the data value is set to zero. Note that enabling
		/// ShepardNormalization forces the computation of the ShepardSum array.
		/// </summary>
		// Token: 0x0600D02F RID: 53295 RVA: 0x00121751 File Offset: 0x0011F951
		public virtual void SetShepardNormalization(int _arg)
		{
			vtkSPHInterpolator.vtkSPHInterpolator_SetShepardNormalization_57(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D030 RID: 53296
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_SetShepardSumArrayName_58(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// If ComputeShepardSum is on, then an array is generated with name
		/// ShepardSumArrayName for each input point. This vtkFloatArray is placed
		/// into the output of the filter, and NullPoints have value =0.0. The
		/// default name is "Shepard Summation".
		/// </summary>
		// Token: 0x0600D031 RID: 53297 RVA: 0x00121761 File Offset: 0x0011F961
		public virtual void SetShepardSumArrayName(string _arg)
		{
			vtkSPHInterpolator.vtkSPHInterpolator_SetShepardSumArrayName_58(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D032 RID: 53298
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_SetSourceConnection_59(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Specify the dataset Pc that will be probed by the input points P.  The
		/// Input P defines the structure (the points and cells) for the output,
		/// while the Source Pc is probed (interpolated) to generate the scalars,
		/// vectors, etc. for the output points based on the point locations.
		/// </summary>
		// Token: 0x0600D033 RID: 53299 RVA: 0x00121774 File Offset: 0x0011F974
		public void SetSourceConnection(vtkAlgorithmOutput algOutput)
		{
			vtkSPHInterpolator.vtkSPHInterpolator_SetSourceConnection_59(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x0600D034 RID: 53300
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_SetSourceData_60(HandleRef pThis, HandleRef source);

		/// <summary>
		/// Specify the dataset Pc that will be probed by the input points P.  The
		/// Input P defines the dataset structure (the points and cells) for the
		/// output, while the Source Pc is probed (interpolated) to generate the
		/// scalars, vectors, etc. for the output points based on the point
		/// locations.
		/// </summary>
		// Token: 0x0600D035 RID: 53301 RVA: 0x001217A4 File Offset: 0x0011F9A4
		public void SetSourceData(vtkDataObject source)
		{
			vtkSPHInterpolator.vtkSPHInterpolator_SetSourceData_60(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0600D036 RID: 53302
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_SetValidPointsMaskArrayName_61(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// If the NullPointsStrategy == MASK_POINTS, then an array is generated for
		/// each input point. This vtkCharArray is placed into the output of the filter,
		/// with a non-zero value for a valid point, and zero otherwise. The name of
		/// this masking array is specified here.
		/// </summary>
		// Token: 0x0600D037 RID: 53303 RVA: 0x001217D3 File Offset: 0x0011F9D3
		public virtual void SetValidPointsMaskArrayName(string _arg)
		{
			vtkSPHInterpolator.vtkSPHInterpolator_SetValidPointsMaskArrayName_61(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D038 RID: 53304
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_ShepardNormalizationOff_62(HandleRef pThis);

		/// <summary>
		/// Indicate whether to normalize all arrays with the Shepard coefficients
		/// (except the density array and the Shepard sum array). If the Shepard
		/// coefficient is 0, then the data value is set to zero. Note that enabling
		/// ShepardNormalization forces the computation of the ShepardSum array.
		/// </summary>
		// Token: 0x0600D039 RID: 53305 RVA: 0x001217E3 File Offset: 0x0011F9E3
		public virtual void ShepardNormalizationOff()
		{
			vtkSPHInterpolator.vtkSPHInterpolator_ShepardNormalizationOff_62(base.GetCppThis());
		}

		// Token: 0x0600D03A RID: 53306
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSPHInterpolator_ShepardNormalizationOn_63(HandleRef pThis);

		/// <summary>
		/// Indicate whether to normalize all arrays with the Shepard coefficients
		/// (except the density array and the Shepard sum array). If the Shepard
		/// coefficient is 0, then the data value is set to zero. Note that enabling
		/// ShepardNormalization forces the computation of the ShepardSum array.
		/// </summary>
		// Token: 0x0600D03B RID: 53307 RVA: 0x001217F2 File Offset: 0x0011F9F2
		public virtual void ShepardNormalizationOn()
		{
			vtkSPHInterpolator.vtkSPHInterpolator_ShepardNormalizationOn_63(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F5A RID: 3930
		public new const string MRFullTypeName = "Kitware.VTK.vtkSPHInterpolator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F5B RID: 3931
		public new static readonly string MRClassNameKey = "class vtkSPHInterpolator";

		/// <summary>
		/// Return the name of the ith derivative array.
		/// </summary>
		// Token: 0x0200045F RID: 1119
		public enum NullStrategy
		{
			/// <summary>enum member</summary>
			// Token: 0x04000F5D RID: 3933
			MASK_POINTS,
			/// <summary>enum member</summary>
			// Token: 0x04000F5E RID: 3934
			NULL_VALUE
		}
	}
}
