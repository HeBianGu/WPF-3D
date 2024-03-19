using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPointDensityFilter
	/// </summary>
	/// <remarks>
	///    produce density field from input point cloud
	///
	/// vtkPointDensityFilter is a filter that generates a density field on a
	/// volume from a point cloud. Basically the density is computed as number of
	/// points in a local neighborhood per unit volume; or optionally, the number
	/// of points in a local neighborhood surrounding each voxel. The local
	/// neighborhood is specified as a radius around each sample position (i.e.,
	/// each voxel) which can be of fixed value; or the radius can be relative to
	/// the voxel size. The density computation may be further weighted by a
	/// scalar value which is simply multiplied by each point's presumed density
	/// of 1.0.
	///
	/// To use this filter, specify an input of type vtkPointSet (i.e., has an
	/// explicit representation of points). Optionally a scalar weighting function
	/// can be provided (part of the input to the filter). Then specify how the
	/// local spherical neighborhood is to be defined, either by a fixed radius or
	/// a radius relative to the voxel size. Finally, specify how the density is
	/// specified, either as a points/volume, or as number of points. (The
	/// weighting scalar array will affect both of these results if provided and
	/// enabled.)
	///
	/// An optional capability of the filter is to compute the gradients of the
	/// resulting density function (a 3-component vector), which also includes the
	/// gradient magnitude (single component scalar) and classification (regions
	/// of zero function, a scalar with single unsigned char value per voxel).
	///
	/// @warning
	/// A point locator is used to speed up searches. By default a fast
	/// vtkStaticPointLocator is used; however the user may specify an alternative
	/// locator. In some situations adaptive locators may run faster depending on
	/// the relative variation in point cloud density.
	///
	/// @warning
	/// Note that the volume calculation can be affected by the boundary. The
	/// local spherical neighborhood around a "near volume boundary" voxel may
	/// extend beyond the volume extent, meaning that density computation may be
	/// reduced. To counter this effect, the volume may be increased in size
	/// and/or resolution so that the point cloud fits well within the volume.
	///
	/// @warning
	/// While this class is very similar to many other of VTK's the point
	/// splatting and interpolation classes, the algorithm density computation is
	/// specialized to generate the density computation over a volume, does not
	/// require (scalar weighting) data attributes to run, and does not require
	/// multiple inputs. As an interesting side note: using the
	/// vtkPointInterpolation class with a vtkLinearKernel, a (scalar) weighting
	/// point attribute, a point cloud source, and an input volume produces the
	/// same result as this filter does (assuming that the input volume is the
	/// same).
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCheckerboardSplatter vtkShepardMethod vtkGaussianSplatter
	/// vtkPointInterpolator vtkSPHInterpolator
	/// </seealso>
	// Token: 0x0200044D RID: 1101
	public class vtkPointDensityFilter : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600CCEF RID: 52463 RVA: 0x0011D2E8 File Offset: 0x0011B4E8
		static vtkPointDensityFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointDensityFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointDensityFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600CCF0 RID: 52464 RVA: 0x0011D310 File Offset: 0x0011B510
		public vtkPointDensityFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600CCF1 RID: 52465
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointDensityFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CCF2 RID: 52466 RVA: 0x0011D320 File Offset: 0x0011B520
		public new static vtkPointDensityFilter New()
		{
			vtkPointDensityFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointDensityFilter.vtkPointDensityFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointDensityFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CCF3 RID: 52467 RVA: 0x0011D374 File Offset: 0x0011B574
		public vtkPointDensityFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPointDensityFilter.vtkPointDensityFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600CCF4 RID: 52468 RVA: 0x0011D3B8 File Offset: 0x0011B5B8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600CCF5 RID: 52469
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDensityFilter_ComputeGradientOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off the generation of the gradient vector, gradient magnitude
		/// scalar, and function classification scalar. By default this is off. Note
		/// that this will increase execution time and the size of the output. (The
		/// names of these point data arrays are: "Gradient", "Gradient Magnitude",
		/// and "Classification".)
		/// </summary>
		// Token: 0x0600CCF6 RID: 52470 RVA: 0x0011D3C3 File Offset: 0x0011B5C3
		public virtual void ComputeGradientOff()
		{
			vtkPointDensityFilter.vtkPointDensityFilter_ComputeGradientOff_01(base.GetCppThis());
		}

		// Token: 0x0600CCF7 RID: 52471
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDensityFilter_ComputeGradientOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off the generation of the gradient vector, gradient magnitude
		/// scalar, and function classification scalar. By default this is off. Note
		/// that this will increase execution time and the size of the output. (The
		/// names of these point data arrays are: "Gradient", "Gradient Magnitude",
		/// and "Classification".)
		/// </summary>
		// Token: 0x0600CCF8 RID: 52472 RVA: 0x0011D3D2 File Offset: 0x0011B5D2
		public virtual void ComputeGradientOn()
		{
			vtkPointDensityFilter.vtkPointDensityFilter_ComputeGradientOn_02(base.GetCppThis());
		}

		// Token: 0x0600CCF9 RID: 52473
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointDensityFilter_GetAdjustDistance_03(HandleRef pThis);

		/// <summary>
		/// Set / get the relative amount to pad the model bounds if automatic
		/// computation is performed. The padding is the fraction to scale
		/// the model bounds in each of the x-y-z directions. By default the
		/// padding is 0.10 (i.e., 10% larger in each direction).
		/// </summary>
		// Token: 0x0600CCFA RID: 52474 RVA: 0x0011D3E4 File Offset: 0x0011B5E4
		public virtual double GetAdjustDistance()
		{
			return vtkPointDensityFilter.vtkPointDensityFilter_GetAdjustDistance_03(base.GetCppThis());
		}

		// Token: 0x0600CCFB RID: 52475
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointDensityFilter_GetAdjustDistanceMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Set / get the relative amount to pad the model bounds if automatic
		/// computation is performed. The padding is the fraction to scale
		/// the model bounds in each of the x-y-z directions. By default the
		/// padding is 0.10 (i.e., 10% larger in each direction).
		/// </summary>
		// Token: 0x0600CCFC RID: 52476 RVA: 0x0011D404 File Offset: 0x0011B604
		public virtual double GetAdjustDistanceMaxValue()
		{
			return vtkPointDensityFilter.vtkPointDensityFilter_GetAdjustDistanceMaxValue_04(base.GetCppThis());
		}

		// Token: 0x0600CCFD RID: 52477
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointDensityFilter_GetAdjustDistanceMinValue_05(HandleRef pThis);

		/// <summary>
		/// Set / get the relative amount to pad the model bounds if automatic
		/// computation is performed. The padding is the fraction to scale
		/// the model bounds in each of the x-y-z directions. By default the
		/// padding is 0.10 (i.e., 10% larger in each direction).
		/// </summary>
		// Token: 0x0600CCFE RID: 52478 RVA: 0x0011D424 File Offset: 0x0011B624
		public virtual double GetAdjustDistanceMinValue()
		{
			return vtkPointDensityFilter.vtkPointDensityFilter_GetAdjustDistanceMinValue_05(base.GetCppThis());
		}

		// Token: 0x0600CCFF RID: 52479
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointDensityFilter_GetComputeGradient_06(HandleRef pThis);

		/// <summary>
		/// Turn on/off the generation of the gradient vector, gradient magnitude
		/// scalar, and function classification scalar. By default this is off. Note
		/// that this will increase execution time and the size of the output. (The
		/// names of these point data arrays are: "Gradient", "Gradient Magnitude",
		/// and "Classification".)
		/// </summary>
		// Token: 0x0600CD00 RID: 52480 RVA: 0x0011D444 File Offset: 0x0011B644
		public virtual bool GetComputeGradient()
		{
			return vtkPointDensityFilter.vtkPointDensityFilter_GetComputeGradient_06(base.GetCppThis()) != 0;
		}

		// Token: 0x0600CD01 RID: 52481
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointDensityFilter_GetDensityEstimate_07(HandleRef pThis);

		/// <summary>
		/// Specify the method to estimate point density. The density can be
		/// calculated using a fixed sphere radius; or a sphere radius that is
		/// relative to voxel size.
		/// </summary>
		// Token: 0x0600CD02 RID: 52482 RVA: 0x0011D46C File Offset: 0x0011B66C
		public virtual int GetDensityEstimate()
		{
			return vtkPointDensityFilter.vtkPointDensityFilter_GetDensityEstimate_07(base.GetCppThis());
		}

		// Token: 0x0600CD03 RID: 52483
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointDensityFilter_GetDensityEstimateAsString_08(HandleRef pThis);

		/// <summary>
		/// Specify the method to estimate point density. The density can be
		/// calculated using a fixed sphere radius; or a sphere radius that is
		/// relative to voxel size.
		/// </summary>
		// Token: 0x0600CD04 RID: 52484 RVA: 0x0011D48C File Offset: 0x0011B68C
		public string GetDensityEstimateAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkPointDensityFilter.vtkPointDensityFilter_GetDensityEstimateAsString_08(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600CD05 RID: 52485
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointDensityFilter_GetDensityEstimateMaxValue_09(HandleRef pThis);

		/// <summary>
		/// Specify the method to estimate point density. The density can be
		/// calculated using a fixed sphere radius; or a sphere radius that is
		/// relative to voxel size.
		/// </summary>
		// Token: 0x0600CD06 RID: 52486 RVA: 0x0011D4C8 File Offset: 0x0011B6C8
		public virtual int GetDensityEstimateMaxValue()
		{
			return vtkPointDensityFilter.vtkPointDensityFilter_GetDensityEstimateMaxValue_09(base.GetCppThis());
		}

		// Token: 0x0600CD07 RID: 52487
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointDensityFilter_GetDensityEstimateMinValue_10(HandleRef pThis);

		/// <summary>
		/// Specify the method to estimate point density. The density can be
		/// calculated using a fixed sphere radius; or a sphere radius that is
		/// relative to voxel size.
		/// </summary>
		// Token: 0x0600CD08 RID: 52488 RVA: 0x0011D4E8 File Offset: 0x0011B6E8
		public virtual int GetDensityEstimateMinValue()
		{
			return vtkPointDensityFilter.vtkPointDensityFilter_GetDensityEstimateMinValue_10(base.GetCppThis());
		}

		// Token: 0x0600CD09 RID: 52489
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointDensityFilter_GetDensityForm_11(HandleRef pThis);

		/// <summary>
		/// Specify the form by which the density is expressed. Either the density is
		/// expressed as (number of points/local sphere volume), or as simply the
		/// (number of points) within the local sphere.
		/// </summary>
		// Token: 0x0600CD0A RID: 52490 RVA: 0x0011D508 File Offset: 0x0011B708
		public virtual int GetDensityForm()
		{
			return vtkPointDensityFilter.vtkPointDensityFilter_GetDensityForm_11(base.GetCppThis());
		}

		// Token: 0x0600CD0B RID: 52491
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointDensityFilter_GetDensityFormAsString_12(HandleRef pThis);

		/// <summary>
		/// Specify the form by which the density is expressed. Either the density is
		/// expressed as (number of points/local sphere volume), or as simply the
		/// (number of points) within the local sphere.
		/// </summary>
		// Token: 0x0600CD0C RID: 52492 RVA: 0x0011D528 File Offset: 0x0011B728
		public string GetDensityFormAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkPointDensityFilter.vtkPointDensityFilter_GetDensityFormAsString_12(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600CD0D RID: 52493
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointDensityFilter_GetDensityFormMaxValue_13(HandleRef pThis);

		/// <summary>
		/// Specify the form by which the density is expressed. Either the density is
		/// expressed as (number of points/local sphere volume), or as simply the
		/// (number of points) within the local sphere.
		/// </summary>
		// Token: 0x0600CD0E RID: 52494 RVA: 0x0011D564 File Offset: 0x0011B764
		public virtual int GetDensityFormMaxValue()
		{
			return vtkPointDensityFilter.vtkPointDensityFilter_GetDensityFormMaxValue_13(base.GetCppThis());
		}

		// Token: 0x0600CD0F RID: 52495
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointDensityFilter_GetDensityFormMinValue_14(HandleRef pThis);

		/// <summary>
		/// Specify the form by which the density is expressed. Either the density is
		/// expressed as (number of points/local sphere volume), or as simply the
		/// (number of points) within the local sphere.
		/// </summary>
		// Token: 0x0600CD10 RID: 52496 RVA: 0x0011D584 File Offset: 0x0011B784
		public virtual int GetDensityFormMinValue()
		{
			return vtkPointDensityFilter.vtkPointDensityFilter_GetDensityFormMinValue_14(base.GetCppThis());
		}

		// Token: 0x0600CD11 RID: 52497
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointDensityFilter_GetLocator_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a point locator. By default a vtkStaticPointLocator is
		/// used. The locator performs efficient searches to locate near a
		/// specified interpolation position.
		/// </summary>
		// Token: 0x0600CD12 RID: 52498 RVA: 0x0011D5A4 File Offset: 0x0011B7A4
		public virtual vtkAbstractPointLocator GetLocator()
		{
			vtkAbstractPointLocator vtkAbstractPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointDensityFilter.vtkPointDensityFilter_GetLocator_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600CD13 RID: 52499
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointDensityFilter_GetModelBounds_16(HandleRef pThis);

		/// <summary>
		/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
		/// the sampling is performed. If any of the (min,max) bounds values are
		/// min &gt;= max, then the bounds will be computed automatically from the input
		/// data. Otherwise, the user-specified bounds will be used.
		/// </summary>
		// Token: 0x0600CD14 RID: 52500 RVA: 0x0011D614 File Offset: 0x0011B814
		public virtual double[] GetModelBounds()
		{
			IntPtr intPtr = vtkPointDensityFilter.vtkPointDensityFilter_GetModelBounds_16(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600CD15 RID: 52501
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDensityFilter_GetModelBounds_17(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
		/// the sampling is performed. If any of the (min,max) bounds values are
		/// min &gt;= max, then the bounds will be computed automatically from the input
		/// data. Otherwise, the user-specified bounds will be used.
		/// </summary>
		// Token: 0x0600CD16 RID: 52502 RVA: 0x0011D65C File Offset: 0x0011B85C
		public virtual void GetModelBounds(IntPtr data)
		{
			vtkPointDensityFilter.vtkPointDensityFilter_GetModelBounds_17(base.GetCppThis(), data);
		}

		// Token: 0x0600CD17 RID: 52503
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointDensityFilter_GetNumberOfGenerationsFromBase_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CD18 RID: 52504 RVA: 0x0011D66C File Offset: 0x0011B86C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPointDensityFilter.vtkPointDensityFilter_GetNumberOfGenerationsFromBase_18(base.GetCppThis(), type);
		}

		// Token: 0x0600CD19 RID: 52505
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointDensityFilter_GetNumberOfGenerationsFromBaseType_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CD1A RID: 52506 RVA: 0x0011D68C File Offset: 0x0011B88C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPointDensityFilter.vtkPointDensityFilter_GetNumberOfGenerationsFromBaseType_19(type);
		}

		// Token: 0x0600CD1B RID: 52507
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointDensityFilter_GetRadius_20(HandleRef pThis);

		/// <summary>
		/// Set / get the radius variable defining the local sphere used to estimate
		/// the density function. The Radius is used when the density estimate is
		///             ^ set to a fixed radius (i.e., the radius doesn't change).
		/// </summary>
		// Token: 0x0600CD1C RID: 52508 RVA: 0x0011D6A8 File Offset: 0x0011B8A8
		public virtual double GetRadius()
		{
			return vtkPointDensityFilter.vtkPointDensityFilter_GetRadius_20(base.GetCppThis());
		}

		// Token: 0x0600CD1D RID: 52509
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointDensityFilter_GetRadiusMaxValue_21(HandleRef pThis);

		/// <summary>
		/// Set / get the radius variable defining the local sphere used to estimate
		/// the density function. The Radius is used when the density estimate is
		///             ^ set to a fixed radius (i.e., the radius doesn't change).
		/// </summary>
		// Token: 0x0600CD1E RID: 52510 RVA: 0x0011D6C8 File Offset: 0x0011B8C8
		public virtual double GetRadiusMaxValue()
		{
			return vtkPointDensityFilter.vtkPointDensityFilter_GetRadiusMaxValue_21(base.GetCppThis());
		}

		// Token: 0x0600CD1F RID: 52511
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointDensityFilter_GetRadiusMinValue_22(HandleRef pThis);

		/// <summary>
		/// Set / get the radius variable defining the local sphere used to estimate
		/// the density function. The Radius is used when the density estimate is
		///             ^ set to a fixed radius (i.e., the radius doesn't change).
		/// </summary>
		// Token: 0x0600CD20 RID: 52512 RVA: 0x0011D6E8 File Offset: 0x0011B8E8
		public virtual double GetRadiusMinValue()
		{
			return vtkPointDensityFilter.vtkPointDensityFilter_GetRadiusMinValue_22(base.GetCppThis());
		}

		// Token: 0x0600CD21 RID: 52513
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointDensityFilter_GetRelativeRadius_23(HandleRef pThis);

		/// <summary>
		/// Set / get the relative radius factor defining the local sphere used to
		/// estimate the density function. The relative sphere radius is equal to
		/// the diagonal length of a voxel times the radius factor. The RelativeRadius
		/// is used when the density estimate is set to relative radius (i.e.,
		/// relative to voxel size).
		/// </summary>
		// Token: 0x0600CD22 RID: 52514 RVA: 0x0011D708 File Offset: 0x0011B908
		public virtual double GetRelativeRadius()
		{
			return vtkPointDensityFilter.vtkPointDensityFilter_GetRelativeRadius_23(base.GetCppThis());
		}

		// Token: 0x0600CD23 RID: 52515
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointDensityFilter_GetRelativeRadiusMaxValue_24(HandleRef pThis);

		/// <summary>
		/// Set / get the relative radius factor defining the local sphere used to
		/// estimate the density function. The relative sphere radius is equal to
		/// the diagonal length of a voxel times the radius factor. The RelativeRadius
		/// is used when the density estimate is set to relative radius (i.e.,
		/// relative to voxel size).
		/// </summary>
		// Token: 0x0600CD24 RID: 52516 RVA: 0x0011D728 File Offset: 0x0011B928
		public virtual double GetRelativeRadiusMaxValue()
		{
			return vtkPointDensityFilter.vtkPointDensityFilter_GetRelativeRadiusMaxValue_24(base.GetCppThis());
		}

		// Token: 0x0600CD25 RID: 52517
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPointDensityFilter_GetRelativeRadiusMinValue_25(HandleRef pThis);

		/// <summary>
		/// Set / get the relative radius factor defining the local sphere used to
		/// estimate the density function. The relative sphere radius is equal to
		/// the diagonal length of a voxel times the radius factor. The RelativeRadius
		/// is used when the density estimate is set to relative radius (i.e.,
		/// relative to voxel size).
		/// </summary>
		// Token: 0x0600CD26 RID: 52518 RVA: 0x0011D748 File Offset: 0x0011B948
		public virtual double GetRelativeRadiusMinValue()
		{
			return vtkPointDensityFilter.vtkPointDensityFilter_GetRelativeRadiusMinValue_25(base.GetCppThis());
		}

		// Token: 0x0600CD27 RID: 52519
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointDensityFilter_GetSampleDimensions_26(HandleRef pThis);

		/// <summary>
		/// Set / get the dimensions of the sampling volume. Higher values generally
		/// produce better results but may be much slower. Note however that too
		/// high a resolution can generate excessive noise; too low and data can be
		/// excessively smoothed.
		/// </summary>
		// Token: 0x0600CD28 RID: 52520 RVA: 0x0011D768 File Offset: 0x0011B968
		public virtual int[] GetSampleDimensions()
		{
			IntPtr intPtr = vtkPointDensityFilter.vtkPointDensityFilter_GetSampleDimensions_26(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600CD29 RID: 52521
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDensityFilter_GetSampleDimensions_27(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set / get the dimensions of the sampling volume. Higher values generally
		/// produce better results but may be much slower. Note however that too
		/// high a resolution can generate excessive noise; too low and data can be
		/// excessively smoothed.
		/// </summary>
		// Token: 0x0600CD2A RID: 52522 RVA: 0x0011D7B0 File Offset: 0x0011B9B0
		public virtual void GetSampleDimensions(IntPtr data)
		{
			vtkPointDensityFilter.vtkPointDensityFilter_GetSampleDimensions_27(base.GetCppThis(), data);
		}

		// Token: 0x0600CD2B RID: 52523
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointDensityFilter_GetScalarWeighting_28(HandleRef pThis);

		/// <summary>
		/// Turn on/off the weighting of point density by a scalar array. By default
		/// scalar weighting is off.
		/// </summary>
		// Token: 0x0600CD2C RID: 52524 RVA: 0x0011D7C0 File Offset: 0x0011B9C0
		public virtual bool GetScalarWeighting()
		{
			return vtkPointDensityFilter.vtkPointDensityFilter_GetScalarWeighting_28(base.GetCppThis()) != 0;
		}

		// Token: 0x0600CD2D RID: 52525
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointDensityFilter_IsA_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CD2E RID: 52526 RVA: 0x0011D7E8 File Offset: 0x0011B9E8
		public override int IsA(string type)
		{
			return vtkPointDensityFilter.vtkPointDensityFilter_IsA_29(base.GetCppThis(), type);
		}

		// Token: 0x0600CD2F RID: 52527
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointDensityFilter_IsTypeOf_30([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CD30 RID: 52528 RVA: 0x0011D808 File Offset: 0x0011BA08
		public new static int IsTypeOf(string type)
		{
			return vtkPointDensityFilter.vtkPointDensityFilter_IsTypeOf_30(type);
		}

		// Token: 0x0600CD31 RID: 52529
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointDensityFilter_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CD32 RID: 52530 RVA: 0x0011D824 File Offset: 0x0011BA24
		public new vtkPointDensityFilter NewInstance()
		{
			vtkPointDensityFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointDensityFilter.vtkPointDensityFilter_NewInstance_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointDensityFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600CD33 RID: 52531
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointDensityFilter_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CD34 RID: 52532 RVA: 0x0011D880 File Offset: 0x0011BA80
		public new static vtkPointDensityFilter SafeDownCast(vtkObjectBase o)
		{
			vtkPointDensityFilter vtkPointDensityFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointDensityFilter.vtkPointDensityFilter_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointDensityFilter = (vtkPointDensityFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointDensityFilter.Register(null);
				}
			}
			return vtkPointDensityFilter;
		}

		// Token: 0x0600CD35 RID: 52533
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDensityFilter_ScalarWeightingOff_34(HandleRef pThis);

		/// <summary>
		/// Turn on/off the weighting of point density by a scalar array. By default
		/// scalar weighting is off.
		/// </summary>
		// Token: 0x0600CD36 RID: 52534 RVA: 0x0011D8FF File Offset: 0x0011BAFF
		public virtual void ScalarWeightingOff()
		{
			vtkPointDensityFilter.vtkPointDensityFilter_ScalarWeightingOff_34(base.GetCppThis());
		}

		// Token: 0x0600CD37 RID: 52535
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDensityFilter_ScalarWeightingOn_35(HandleRef pThis);

		/// <summary>
		/// Turn on/off the weighting of point density by a scalar array. By default
		/// scalar weighting is off.
		/// </summary>
		// Token: 0x0600CD38 RID: 52536 RVA: 0x0011D90E File Offset: 0x0011BB0E
		public virtual void ScalarWeightingOn()
		{
			vtkPointDensityFilter.vtkPointDensityFilter_ScalarWeightingOn_35(base.GetCppThis());
		}

		// Token: 0x0600CD39 RID: 52537
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDensityFilter_SetAdjustDistance_36(HandleRef pThis, double _arg);

		/// <summary>
		/// Set / get the relative amount to pad the model bounds if automatic
		/// computation is performed. The padding is the fraction to scale
		/// the model bounds in each of the x-y-z directions. By default the
		/// padding is 0.10 (i.e., 10% larger in each direction).
		/// </summary>
		// Token: 0x0600CD3A RID: 52538 RVA: 0x0011D91D File Offset: 0x0011BB1D
		public virtual void SetAdjustDistance(double _arg)
		{
			vtkPointDensityFilter.vtkPointDensityFilter_SetAdjustDistance_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CD3B RID: 52539
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDensityFilter_SetComputeGradient_37(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off the generation of the gradient vector, gradient magnitude
		/// scalar, and function classification scalar. By default this is off. Note
		/// that this will increase execution time and the size of the output. (The
		/// names of these point data arrays are: "Gradient", "Gradient Magnitude",
		/// and "Classification".)
		/// </summary>
		// Token: 0x0600CD3C RID: 52540 RVA: 0x0011D92D File Offset: 0x0011BB2D
		public virtual void SetComputeGradient(bool _arg)
		{
			vtkPointDensityFilter.vtkPointDensityFilter_SetComputeGradient_37(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600CD3D RID: 52541
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDensityFilter_SetDensityEstimate_38(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the method to estimate point density. The density can be
		/// calculated using a fixed sphere radius; or a sphere radius that is
		/// relative to voxel size.
		/// </summary>
		// Token: 0x0600CD3E RID: 52542 RVA: 0x0011D945 File Offset: 0x0011BB45
		public virtual void SetDensityEstimate(int _arg)
		{
			vtkPointDensityFilter.vtkPointDensityFilter_SetDensityEstimate_38(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CD3F RID: 52543
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDensityFilter_SetDensityEstimateToFixedRadius_39(HandleRef pThis);

		/// <summary>
		/// Specify the method to estimate point density. The density can be
		/// calculated using a fixed sphere radius; or a sphere radius that is
		/// relative to voxel size.
		/// </summary>
		// Token: 0x0600CD40 RID: 52544 RVA: 0x0011D955 File Offset: 0x0011BB55
		public void SetDensityEstimateToFixedRadius()
		{
			vtkPointDensityFilter.vtkPointDensityFilter_SetDensityEstimateToFixedRadius_39(base.GetCppThis());
		}

		// Token: 0x0600CD41 RID: 52545
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDensityFilter_SetDensityEstimateToRelativeRadius_40(HandleRef pThis);

		/// <summary>
		/// Specify the method to estimate point density. The density can be
		/// calculated using a fixed sphere radius; or a sphere radius that is
		/// relative to voxel size.
		/// </summary>
		// Token: 0x0600CD42 RID: 52546 RVA: 0x0011D964 File Offset: 0x0011BB64
		public void SetDensityEstimateToRelativeRadius()
		{
			vtkPointDensityFilter.vtkPointDensityFilter_SetDensityEstimateToRelativeRadius_40(base.GetCppThis());
		}

		// Token: 0x0600CD43 RID: 52547
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDensityFilter_SetDensityForm_41(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the form by which the density is expressed. Either the density is
		/// expressed as (number of points/local sphere volume), or as simply the
		/// (number of points) within the local sphere.
		/// </summary>
		// Token: 0x0600CD44 RID: 52548 RVA: 0x0011D973 File Offset: 0x0011BB73
		public virtual void SetDensityForm(int _arg)
		{
			vtkPointDensityFilter.vtkPointDensityFilter_SetDensityForm_41(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CD45 RID: 52549
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDensityFilter_SetDensityFormToNumberOfPoints_42(HandleRef pThis);

		/// <summary>
		/// Specify the form by which the density is expressed. Either the density is
		/// expressed as (number of points/local sphere volume), or as simply the
		/// (number of points) within the local sphere.
		/// </summary>
		// Token: 0x0600CD46 RID: 52550 RVA: 0x0011D983 File Offset: 0x0011BB83
		public void SetDensityFormToNumberOfPoints()
		{
			vtkPointDensityFilter.vtkPointDensityFilter_SetDensityFormToNumberOfPoints_42(base.GetCppThis());
		}

		// Token: 0x0600CD47 RID: 52551
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDensityFilter_SetDensityFormToVolumeNormalized_43(HandleRef pThis);

		/// <summary>
		/// Specify the form by which the density is expressed. Either the density is
		/// expressed as (number of points/local sphere volume), or as simply the
		/// (number of points) within the local sphere.
		/// </summary>
		// Token: 0x0600CD48 RID: 52552 RVA: 0x0011D992 File Offset: 0x0011BB92
		public void SetDensityFormToVolumeNormalized()
		{
			vtkPointDensityFilter.vtkPointDensityFilter_SetDensityFormToVolumeNormalized_43(base.GetCppThis());
		}

		// Token: 0x0600CD49 RID: 52553
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDensityFilter_SetLocator_44(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Specify a point locator. By default a vtkStaticPointLocator is
		/// used. The locator performs efficient searches to locate near a
		/// specified interpolation position.
		/// </summary>
		// Token: 0x0600CD4A RID: 52554 RVA: 0x0011D9A4 File Offset: 0x0011BBA4
		public void SetLocator(vtkAbstractPointLocator locator)
		{
			vtkPointDensityFilter.vtkPointDensityFilter_SetLocator_44(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0600CD4B RID: 52555
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDensityFilter_SetModelBounds_45(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
		/// the sampling is performed. If any of the (min,max) bounds values are
		/// min &gt;= max, then the bounds will be computed automatically from the input
		/// data. Otherwise, the user-specified bounds will be used.
		/// </summary>
		// Token: 0x0600CD4C RID: 52556 RVA: 0x0011D9D3 File Offset: 0x0011BBD3
		public virtual void SetModelBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkPointDensityFilter.vtkPointDensityFilter_SetModelBounds_45(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x0600CD4D RID: 52557
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDensityFilter_SetModelBounds_46(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
		/// the sampling is performed. If any of the (min,max) bounds values are
		/// min &gt;= max, then the bounds will be computed automatically from the input
		/// data. Otherwise, the user-specified bounds will be used.
		/// </summary>
		// Token: 0x0600CD4E RID: 52558 RVA: 0x0011D9EB File Offset: 0x0011BBEB
		public virtual void SetModelBounds(IntPtr _arg)
		{
			vtkPointDensityFilter.vtkPointDensityFilter_SetModelBounds_46(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CD4F RID: 52559
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDensityFilter_SetRadius_47(HandleRef pThis, double _arg);

		/// <summary>
		/// Set / get the radius variable defining the local sphere used to estimate
		/// the density function. The Radius is used when the density estimate is
		///             ^ set to a fixed radius (i.e., the radius doesn't change).
		/// </summary>
		// Token: 0x0600CD50 RID: 52560 RVA: 0x0011D9FB File Offset: 0x0011BBFB
		public virtual void SetRadius(double _arg)
		{
			vtkPointDensityFilter.vtkPointDensityFilter_SetRadius_47(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CD51 RID: 52561
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDensityFilter_SetRelativeRadius_48(HandleRef pThis, double _arg);

		/// <summary>
		/// Set / get the relative radius factor defining the local sphere used to
		/// estimate the density function. The relative sphere radius is equal to
		/// the diagonal length of a voxel times the radius factor. The RelativeRadius
		/// is used when the density estimate is set to relative radius (i.e.,
		/// relative to voxel size).
		/// </summary>
		// Token: 0x0600CD52 RID: 52562 RVA: 0x0011DA0B File Offset: 0x0011BC0B
		public virtual void SetRelativeRadius(double _arg)
		{
			vtkPointDensityFilter.vtkPointDensityFilter_SetRelativeRadius_48(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CD53 RID: 52563
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDensityFilter_SetSampleDimensions_49(HandleRef pThis, int i, int j, int k);

		/// <summary>
		/// Set / get the dimensions of the sampling volume. Higher values generally
		/// produce better results but may be much slower. Note however that too
		/// high a resolution can generate excessive noise; too low and data can be
		/// excessively smoothed.
		/// </summary>
		// Token: 0x0600CD54 RID: 52564 RVA: 0x0011DA1B File Offset: 0x0011BC1B
		public void SetSampleDimensions(int i, int j, int k)
		{
			vtkPointDensityFilter.vtkPointDensityFilter_SetSampleDimensions_49(base.GetCppThis(), i, j, k);
		}

		// Token: 0x0600CD55 RID: 52565
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDensityFilter_SetSampleDimensions_50(HandleRef pThis, IntPtr dim);

		/// <summary>
		/// Set / get the dimensions of the sampling volume. Higher values generally
		/// produce better results but may be much slower. Note however that too
		/// high a resolution can generate excessive noise; too low and data can be
		/// excessively smoothed.
		/// </summary>
		// Token: 0x0600CD56 RID: 52566 RVA: 0x0011DA2D File Offset: 0x0011BC2D
		public void SetSampleDimensions(IntPtr dim)
		{
			vtkPointDensityFilter.vtkPointDensityFilter_SetSampleDimensions_50(base.GetCppThis(), dim);
		}

		// Token: 0x0600CD57 RID: 52567
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointDensityFilter_SetScalarWeighting_51(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off the weighting of point density by a scalar array. By default
		/// scalar weighting is off.
		/// </summary>
		// Token: 0x0600CD58 RID: 52568 RVA: 0x0011DA3D File Offset: 0x0011BC3D
		public virtual void SetScalarWeighting(bool _arg)
		{
			vtkPointDensityFilter.vtkPointDensityFilter_SetScalarWeighting_51(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F2A RID: 3882
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointDensityFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F2B RID: 3883
		public new static readonly string MRClassNameKey = "class vtkPointDensityFilter";

		/// <summary>
		/// This enum is used to classify the behavior of the function gradient. Regions
		/// where all density values used in the calculation of the gradient are zero
		/// are referred to as ZERO regions. Otherwise NON_ZERO. This can be used to
		/// differentiate between regions where data is available and where it is not.
		/// </summary>
		// Token: 0x0200044E RID: 1102
		public enum FunctionClass
		{
			/// <summary>enum member</summary>
			// Token: 0x04000F2D RID: 3885
			NON_ZERO = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000F2E RID: 3886
			ZERO = 0
		}
	}
}
