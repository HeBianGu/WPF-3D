using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPCANormalEstimation
	/// </summary>
	/// <remarks>
	///    generate point normals using local tangent planes
	///
	///
	/// vtkPCANormalEstimation generates point normals using PCA (principal
	/// component analysis).  Basically this estimates a local tangent plane
	/// around each sample point p by considering a small neighborhood of points
	/// around p, and fitting a plane to the neighborhood (via PCA). A good
	/// introductory reference is Hoppe's "Surface reconstruction from
	/// unorganized points."
	///
	/// To use this filter, specify a neighborhood size (SampleSize) or/and a
	/// neighborhood radius (Radius). This may have to be set via
	/// experimentation. Both options can be set with SetSearchMode.
	/// If SearchMode is set to KNN, K points (set by SampleSize) are selected
	/// regardless of their location. If Radius is also set to a value different
	/// from 0, the code checks if the farthest point found (K-th) is inside this
	/// radius. In that case, the selection is performed again to return all
	/// points inside this radius, indicating that the initial SampleSize was
	/// probably too small compared to the cloud density. Otherwise, if the
	/// farthest point is outside the radius, the selection is kept unchanged.
	/// If SearchMode is set to Radius, the surrounding points are
	/// selected inside the radius. If SampleSize is also set to a value greater
	/// than 0, the code checks if at least SampleSize (K) points have been
	/// selected. Otherwise, the selection is performed again to include
	/// SampleSize (K) points, indicating that the initial Radius was
	/// probably too small to estimate the normals relative to the low density
	/// of the cloud.
	/// Default behavior is KNN with no radius checked (radius is null).
	/// Both approaches give the same results. The first approach is faster for
	/// uniform point clouds, in other cases, the second approach is faster.
	/// In addition, the user may optionally specify a point locator (instead of
	/// the default locator), which is used to accelerate searches around the
	/// sample point. Finally, the user should specify how to generate
	/// consistently-oriented normals. As computed by PCA, normals may point in
	/// arbitrary +/- orientation, which may not be consistent with neighboring
	/// normals. There are three methods to address normal consistency: 1)
	/// leave the normals as computed, 2) adjust the +/- sign of the normals so
	/// that the normals all point towards a specified point, and 3) perform a
	/// traversal of the point cloud and flip neighboring normals so that they
	/// are mutually consistent.
	///
	/// The output of this filter is the same as the input except that a normal
	/// per point is produced. (Note that these are unit normals.) While any
	/// vtkPointSet type can be provided as input, the output is represented by an
	/// explicit representation of points via a vtkPolyData. This output polydata
	/// will populate its instance of vtkPoints, but no cells will be defined
	/// (i.e., no vtkVertex or vtkPolyVertex are contained in the output).
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPCACurvatureEstimation
	/// </seealso>
	// Token: 0x0200044A RID: 1098
	public class vtkPCANormalEstimation : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600CCAB RID: 52395 RVA: 0x0011CDF3 File Offset: 0x0011AFF3
		static vtkPCANormalEstimation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPCANormalEstimation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPCANormalEstimation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600CCAC RID: 52396 RVA: 0x0011CE1B File Offset: 0x0011B01B
		public vtkPCANormalEstimation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600CCAD RID: 52397
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPCANormalEstimation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CCAE RID: 52398 RVA: 0x0011CE2C File Offset: 0x0011B02C
		public new static vtkPCANormalEstimation New()
		{
			vtkPCANormalEstimation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPCANormalEstimation.vtkPCANormalEstimation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPCANormalEstimation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CCAF RID: 52399 RVA: 0x0011CE80 File Offset: 0x0011B080
		public vtkPCANormalEstimation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPCANormalEstimation.vtkPCANormalEstimation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600CCB0 RID: 52400 RVA: 0x0011CEC4 File Offset: 0x0011B0C4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600CCB1 RID: 52401
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCANormalEstimation_FlipNormalsOff_01(HandleRef pThis);

		/// <summary>
		/// The normal orientation can be flipped by enabling this flag.
		/// </summary>
		// Token: 0x0600CCB2 RID: 52402 RVA: 0x0011CECF File Offset: 0x0011B0CF
		public virtual void FlipNormalsOff()
		{
			vtkPCANormalEstimation.vtkPCANormalEstimation_FlipNormalsOff_01(base.GetCppThis());
		}

		// Token: 0x0600CCB3 RID: 52403
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCANormalEstimation_FlipNormalsOn_02(HandleRef pThis);

		/// <summary>
		/// The normal orientation can be flipped by enabling this flag.
		/// </summary>
		// Token: 0x0600CCB4 RID: 52404 RVA: 0x0011CEDE File Offset: 0x0011B0DE
		public virtual void FlipNormalsOn()
		{
			vtkPCANormalEstimation.vtkPCANormalEstimation_FlipNormalsOn_02(base.GetCppThis());
		}

		// Token: 0x0600CCB5 RID: 52405
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPCANormalEstimation_GetFlipNormals_03(HandleRef pThis);

		/// <summary>
		/// The normal orientation can be flipped by enabling this flag.
		/// </summary>
		// Token: 0x0600CCB6 RID: 52406 RVA: 0x0011CEF0 File Offset: 0x0011B0F0
		public virtual bool GetFlipNormals()
		{
			return vtkPCANormalEstimation.vtkPCANormalEstimation_GetFlipNormals_03(base.GetCppThis()) != 0;
		}

		// Token: 0x0600CCB7 RID: 52407
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPCANormalEstimation_GetLocator_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a point locator. By default a vtkStaticPointLocator is
		/// used. The locator performs efficient searches to locate points
		/// around a sample point.
		/// </summary>
		// Token: 0x0600CCB8 RID: 52408 RVA: 0x0011CF18 File Offset: 0x0011B118
		public virtual vtkAbstractPointLocator GetLocator()
		{
			vtkAbstractPointLocator vtkAbstractPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPCANormalEstimation.vtkPCANormalEstimation_GetLocator_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600CCB9 RID: 52409
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPCANormalEstimation_GetNormalOrientation_05(HandleRef pThis);

		/// <summary>
		/// Configure how the filter addresses consistency in normal
		/// oreientation. When initially computed using PCA, a point normal may
		/// point in the + or - direction, which may not be consistent with
		/// neighboring points. To address this, various strategies have been used
		/// to create consistent normals. The simplest approach is to do nothing
		/// (AsComputed). Another simple approach is to flip the normal based on its
		/// direction with respect to a specified point (i.e., point normals will
		/// point towrads the specified point). Finally, a full traversal of points
		/// across the graph of neighboring, connected points produces the best
		/// results but is computationally expensive.
		/// </summary>
		// Token: 0x0600CCBA RID: 52410 RVA: 0x0011CF88 File Offset: 0x0011B188
		public virtual int GetNormalOrientation()
		{
			return vtkPCANormalEstimation.vtkPCANormalEstimation_GetNormalOrientation_05(base.GetCppThis());
		}

		// Token: 0x0600CCBB RID: 52411
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPCANormalEstimation_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CCBC RID: 52412 RVA: 0x0011CFA8 File Offset: 0x0011B1A8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPCANormalEstimation.vtkPCANormalEstimation_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0600CCBD RID: 52413
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPCANormalEstimation_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CCBE RID: 52414 RVA: 0x0011CFC8 File Offset: 0x0011B1C8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPCANormalEstimation.vtkPCANormalEstimation_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0600CCBF RID: 52415
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPCANormalEstimation_GetOrientationPoint_08(HandleRef pThis);

		/// <summary>
		/// If the normal orientation is to be consistent with a specified
		/// direction, then an orientation point should be set. The sign of the
		/// normals will be modified so that they point towards this point. By
		/// default, the specified orientation point is (0,0,0).
		/// </summary>
		// Token: 0x0600CCC0 RID: 52416 RVA: 0x0011CFE4 File Offset: 0x0011B1E4
		public virtual double[] GetOrientationPoint()
		{
			IntPtr intPtr = vtkPCANormalEstimation.vtkPCANormalEstimation_GetOrientationPoint_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600CCC1 RID: 52417
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCANormalEstimation_GetOrientationPoint_09(HandleRef pThis, IntPtr data);

		/// <summary>
		/// If the normal orientation is to be consistent with a specified
		/// direction, then an orientation point should be set. The sign of the
		/// normals will be modified so that they point towards this point. By
		/// default, the specified orientation point is (0,0,0).
		/// </summary>
		// Token: 0x0600CCC2 RID: 52418 RVA: 0x0011D02C File Offset: 0x0011B22C
		public virtual void GetOrientationPoint(IntPtr data)
		{
			vtkPCANormalEstimation.vtkPCANormalEstimation_GetOrientationPoint_09(base.GetCppThis(), data);
		}

		// Token: 0x0600CCC3 RID: 52419
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPCANormalEstimation_GetRadius_10(HandleRef pThis);

		/// <summary>
		/// For each sampled point, specify the radius within which the surrounding
		/// points used to estimate the normal are selected. By default a 1 meter
		/// radius is used. Smaller radius may speed performance at the cost of
		/// accuracy.
		/// </summary>
		// Token: 0x0600CCC4 RID: 52420 RVA: 0x0011D03C File Offset: 0x0011B23C
		public virtual double GetRadius()
		{
			return vtkPCANormalEstimation.vtkPCANormalEstimation_GetRadius_10(base.GetCppThis());
		}

		// Token: 0x0600CCC5 RID: 52421
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPCANormalEstimation_GetSampleSize_11(HandleRef pThis);

		/// <summary>
		/// For each sampled point, specify the number of the closest, surrounding
		/// points used to estimate the normal (the so called k-neighborhood). By
		/// default 25 points are used. Smaller numbers may speed performance at the
		/// cost of accuracy.
		/// </summary>
		// Token: 0x0600CCC6 RID: 52422 RVA: 0x0011D05C File Offset: 0x0011B25C
		public virtual int GetSampleSize()
		{
			return vtkPCANormalEstimation.vtkPCANormalEstimation_GetSampleSize_11(base.GetCppThis());
		}

		// Token: 0x0600CCC7 RID: 52423
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPCANormalEstimation_GetSampleSizeMaxValue_12(HandleRef pThis);

		/// <summary>
		/// For each sampled point, specify the number of the closest, surrounding
		/// points used to estimate the normal (the so called k-neighborhood). By
		/// default 25 points are used. Smaller numbers may speed performance at the
		/// cost of accuracy.
		/// </summary>
		// Token: 0x0600CCC8 RID: 52424 RVA: 0x0011D07C File Offset: 0x0011B27C
		public virtual int GetSampleSizeMaxValue()
		{
			return vtkPCANormalEstimation.vtkPCANormalEstimation_GetSampleSizeMaxValue_12(base.GetCppThis());
		}

		// Token: 0x0600CCC9 RID: 52425
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPCANormalEstimation_GetSampleSizeMinValue_13(HandleRef pThis);

		/// <summary>
		/// For each sampled point, specify the number of the closest, surrounding
		/// points used to estimate the normal (the so called k-neighborhood). By
		/// default 25 points are used. Smaller numbers may speed performance at the
		/// cost of accuracy.
		/// </summary>
		// Token: 0x0600CCCA RID: 52426 RVA: 0x0011D09C File Offset: 0x0011B29C
		public virtual int GetSampleSizeMinValue()
		{
			return vtkPCANormalEstimation.vtkPCANormalEstimation_GetSampleSizeMinValue_13(base.GetCppThis());
		}

		// Token: 0x0600CCCB RID: 52427
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPCANormalEstimation_GetSearchMode_14(HandleRef pThis);

		/// <summary>
		/// Configure how the filter selects the neighbor points used to calculate
		/// the PCA. By default (KNN mode and radius set to 0), K (SampleSize) points
		/// are selected regardless of their location relative to the sampled point.
		/// The radius can also be set to ensure that a sufficiently large
		/// neighborhood is taken into account, if not (i.e. all points fall inside
		/// the radius), the second approach is performed. A second approach is to
		/// select neighboring points inside a radius (RADIUS), only the neighborhood
		/// of the sampled point is considered. If K (SampleSize) is also set, the
		/// number of points found inside the radius must be larger than K, if not
		/// the first approach is performed.
		/// Both approaches give the same results. The first approach is faster for
		/// uniform point clouds, in other cases, the second approach is faster.
		/// </summary>
		// Token: 0x0600CCCC RID: 52428 RVA: 0x0011D0BC File Offset: 0x0011B2BC
		public virtual int GetSearchMode()
		{
			return vtkPCANormalEstimation.vtkPCANormalEstimation_GetSearchMode_14(base.GetCppThis());
		}

		// Token: 0x0600CCCD RID: 52429
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPCANormalEstimation_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CCCE RID: 52430 RVA: 0x0011D0DC File Offset: 0x0011B2DC
		public override int IsA(string type)
		{
			return vtkPCANormalEstimation.vtkPCANormalEstimation_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x0600CCCF RID: 52431
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPCANormalEstimation_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CCD0 RID: 52432 RVA: 0x0011D0FC File Offset: 0x0011B2FC
		public new static int IsTypeOf(string type)
		{
			return vtkPCANormalEstimation.vtkPCANormalEstimation_IsTypeOf_16(type);
		}

		// Token: 0x0600CCD1 RID: 52433
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPCANormalEstimation_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CCD2 RID: 52434 RVA: 0x0011D118 File Offset: 0x0011B318
		public new vtkPCANormalEstimation NewInstance()
		{
			vtkPCANormalEstimation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPCANormalEstimation.vtkPCANormalEstimation_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPCANormalEstimation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600CCD3 RID: 52435
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPCANormalEstimation_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CCD4 RID: 52436 RVA: 0x0011D174 File Offset: 0x0011B374
		public new static vtkPCANormalEstimation SafeDownCast(vtkObjectBase o)
		{
			vtkPCANormalEstimation vtkPCANormalEstimation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPCANormalEstimation.vtkPCANormalEstimation_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPCANormalEstimation = (vtkPCANormalEstimation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPCANormalEstimation.Register(null);
				}
			}
			return vtkPCANormalEstimation;
		}

		// Token: 0x0600CCD5 RID: 52437
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCANormalEstimation_SetFlipNormals_20(HandleRef pThis, byte _arg);

		/// <summary>
		/// The normal orientation can be flipped by enabling this flag.
		/// </summary>
		// Token: 0x0600CCD6 RID: 52438 RVA: 0x0011D1F3 File Offset: 0x0011B3F3
		public virtual void SetFlipNormals(bool _arg)
		{
			vtkPCANormalEstimation.vtkPCANormalEstimation_SetFlipNormals_20(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600CCD7 RID: 52439
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCANormalEstimation_SetLocator_21(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Specify a point locator. By default a vtkStaticPointLocator is
		/// used. The locator performs efficient searches to locate points
		/// around a sample point.
		/// </summary>
		// Token: 0x0600CCD8 RID: 52440 RVA: 0x0011D20C File Offset: 0x0011B40C
		public void SetLocator(vtkAbstractPointLocator locator)
		{
			vtkPCANormalEstimation.vtkPCANormalEstimation_SetLocator_21(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0600CCD9 RID: 52441
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCANormalEstimation_SetNormalOrientation_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Configure how the filter addresses consistency in normal
		/// oreientation. When initially computed using PCA, a point normal may
		/// point in the + or - direction, which may not be consistent with
		/// neighboring points. To address this, various strategies have been used
		/// to create consistent normals. The simplest approach is to do nothing
		/// (AsComputed). Another simple approach is to flip the normal based on its
		/// direction with respect to a specified point (i.e., point normals will
		/// point towrads the specified point). Finally, a full traversal of points
		/// across the graph of neighboring, connected points produces the best
		/// results but is computationally expensive.
		/// </summary>
		// Token: 0x0600CCDA RID: 52442 RVA: 0x0011D23B File Offset: 0x0011B43B
		public virtual void SetNormalOrientation(int _arg)
		{
			vtkPCANormalEstimation.vtkPCANormalEstimation_SetNormalOrientation_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CCDB RID: 52443
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCANormalEstimation_SetNormalOrientationToAsComputed_23(HandleRef pThis);

		/// <summary>
		/// Configure how the filter addresses consistency in normal
		/// oreientation. When initially computed using PCA, a point normal may
		/// point in the + or - direction, which may not be consistent with
		/// neighboring points. To address this, various strategies have been used
		/// to create consistent normals. The simplest approach is to do nothing
		/// (AsComputed). Another simple approach is to flip the normal based on its
		/// direction with respect to a specified point (i.e., point normals will
		/// point towrads the specified point). Finally, a full traversal of points
		/// across the graph of neighboring, connected points produces the best
		/// results but is computationally expensive.
		/// </summary>
		// Token: 0x0600CCDC RID: 52444 RVA: 0x0011D24B File Offset: 0x0011B44B
		public void SetNormalOrientationToAsComputed()
		{
			vtkPCANormalEstimation.vtkPCANormalEstimation_SetNormalOrientationToAsComputed_23(base.GetCppThis());
		}

		// Token: 0x0600CCDD RID: 52445
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCANormalEstimation_SetNormalOrientationToGraphTraversal_24(HandleRef pThis);

		/// <summary>
		/// Configure how the filter addresses consistency in normal
		/// oreientation. When initially computed using PCA, a point normal may
		/// point in the + or - direction, which may not be consistent with
		/// neighboring points. To address this, various strategies have been used
		/// to create consistent normals. The simplest approach is to do nothing
		/// (AsComputed). Another simple approach is to flip the normal based on its
		/// direction with respect to a specified point (i.e., point normals will
		/// point towrads the specified point). Finally, a full traversal of points
		/// across the graph of neighboring, connected points produces the best
		/// results but is computationally expensive.
		/// </summary>
		// Token: 0x0600CCDE RID: 52446 RVA: 0x0011D25A File Offset: 0x0011B45A
		public void SetNormalOrientationToGraphTraversal()
		{
			vtkPCANormalEstimation.vtkPCANormalEstimation_SetNormalOrientationToGraphTraversal_24(base.GetCppThis());
		}

		// Token: 0x0600CCDF RID: 52447
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCANormalEstimation_SetNormalOrientationToPoint_25(HandleRef pThis);

		/// <summary>
		/// Configure how the filter addresses consistency in normal
		/// oreientation. When initially computed using PCA, a point normal may
		/// point in the + or - direction, which may not be consistent with
		/// neighboring points. To address this, various strategies have been used
		/// to create consistent normals. The simplest approach is to do nothing
		/// (AsComputed). Another simple approach is to flip the normal based on its
		/// direction with respect to a specified point (i.e., point normals will
		/// point towrads the specified point). Finally, a full traversal of points
		/// across the graph of neighboring, connected points produces the best
		/// results but is computationally expensive.
		/// </summary>
		// Token: 0x0600CCE0 RID: 52448 RVA: 0x0011D269 File Offset: 0x0011B469
		public void SetNormalOrientationToPoint()
		{
			vtkPCANormalEstimation.vtkPCANormalEstimation_SetNormalOrientationToPoint_25(base.GetCppThis());
		}

		// Token: 0x0600CCE1 RID: 52449
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCANormalEstimation_SetOrientationPoint_26(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// If the normal orientation is to be consistent with a specified
		/// direction, then an orientation point should be set. The sign of the
		/// normals will be modified so that they point towards this point. By
		/// default, the specified orientation point is (0,0,0).
		/// </summary>
		// Token: 0x0600CCE2 RID: 52450 RVA: 0x0011D278 File Offset: 0x0011B478
		public virtual void SetOrientationPoint(double _arg1, double _arg2, double _arg3)
		{
			vtkPCANormalEstimation.vtkPCANormalEstimation_SetOrientationPoint_26(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600CCE3 RID: 52451
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCANormalEstimation_SetOrientationPoint_27(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// If the normal orientation is to be consistent with a specified
		/// direction, then an orientation point should be set. The sign of the
		/// normals will be modified so that they point towards this point. By
		/// default, the specified orientation point is (0,0,0).
		/// </summary>
		// Token: 0x0600CCE4 RID: 52452 RVA: 0x0011D28A File Offset: 0x0011B48A
		public virtual void SetOrientationPoint(IntPtr _arg)
		{
			vtkPCANormalEstimation.vtkPCANormalEstimation_SetOrientationPoint_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CCE5 RID: 52453
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCANormalEstimation_SetRadius_28(HandleRef pThis, double _arg);

		/// <summary>
		/// For each sampled point, specify the radius within which the surrounding
		/// points used to estimate the normal are selected. By default a 1 meter
		/// radius is used. Smaller radius may speed performance at the cost of
		/// accuracy.
		/// </summary>
		// Token: 0x0600CCE6 RID: 52454 RVA: 0x0011D29A File Offset: 0x0011B49A
		public virtual void SetRadius(double _arg)
		{
			vtkPCANormalEstimation.vtkPCANormalEstimation_SetRadius_28(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CCE7 RID: 52455
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCANormalEstimation_SetSampleSize_29(HandleRef pThis, int _arg);

		/// <summary>
		/// For each sampled point, specify the number of the closest, surrounding
		/// points used to estimate the normal (the so called k-neighborhood). By
		/// default 25 points are used. Smaller numbers may speed performance at the
		/// cost of accuracy.
		/// </summary>
		// Token: 0x0600CCE8 RID: 52456 RVA: 0x0011D2AA File Offset: 0x0011B4AA
		public virtual void SetSampleSize(int _arg)
		{
			vtkPCANormalEstimation.vtkPCANormalEstimation_SetSampleSize_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CCE9 RID: 52457
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCANormalEstimation_SetSearchMode_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Configure how the filter selects the neighbor points used to calculate
		/// the PCA. By default (KNN mode and radius set to 0), K (SampleSize) points
		/// are selected regardless of their location relative to the sampled point.
		/// The radius can also be set to ensure that a sufficiently large
		/// neighborhood is taken into account, if not (i.e. all points fall inside
		/// the radius), the second approach is performed. A second approach is to
		/// select neighboring points inside a radius (RADIUS), only the neighborhood
		/// of the sampled point is considered. If K (SampleSize) is also set, the
		/// number of points found inside the radius must be larger than K, if not
		/// the first approach is performed.
		/// Both approaches give the same results. The first approach is faster for
		/// uniform point clouds, in other cases, the second approach is faster.
		/// </summary>
		// Token: 0x0600CCEA RID: 52458 RVA: 0x0011D2BA File Offset: 0x0011B4BA
		public virtual void SetSearchMode(int _arg)
		{
			vtkPCANormalEstimation.vtkPCANormalEstimation_SetSearchMode_30(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CCEB RID: 52459
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCANormalEstimation_SetSearchModeToKNN_31(HandleRef pThis);

		/// <summary>
		/// Configure how the filter selects the neighbor points used to calculate
		/// the PCA. By default (KNN mode and radius set to 0), K (SampleSize) points
		/// are selected regardless of their location relative to the sampled point.
		/// The radius can also be set to ensure that a sufficiently large
		/// neighborhood is taken into account, if not (i.e. all points fall inside
		/// the radius), the second approach is performed. A second approach is to
		/// select neighboring points inside a radius (RADIUS), only the neighborhood
		/// of the sampled point is considered. If K (SampleSize) is also set, the
		/// number of points found inside the radius must be larger than K, if not
		/// the first approach is performed.
		/// Both approaches give the same results. The first approach is faster for
		/// uniform point clouds, in other cases, the second approach is faster.
		/// </summary>
		// Token: 0x0600CCEC RID: 52460 RVA: 0x0011D2CA File Offset: 0x0011B4CA
		public void SetSearchModeToKNN()
		{
			vtkPCANormalEstimation.vtkPCANormalEstimation_SetSearchModeToKNN_31(base.GetCppThis());
		}

		// Token: 0x0600CCED RID: 52461
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCANormalEstimation_SetSearchModeToRadius_32(HandleRef pThis);

		/// <summary>
		/// Configure how the filter selects the neighbor points used to calculate
		/// the PCA. By default (KNN mode and radius set to 0), K (SampleSize) points
		/// are selected regardless of their location relative to the sampled point.
		/// The radius can also be set to ensure that a sufficiently large
		/// neighborhood is taken into account, if not (i.e. all points fall inside
		/// the radius), the second approach is performed. A second approach is to
		/// select neighboring points inside a radius (RADIUS), only the neighborhood
		/// of the sampled point is considered. If K (SampleSize) is also set, the
		/// number of points found inside the radius must be larger than K, if not
		/// the first approach is performed.
		/// Both approaches give the same results. The first approach is faster for
		/// uniform point clouds, in other cases, the second approach is faster.
		/// </summary>
		// Token: 0x0600CCEE RID: 52462 RVA: 0x0011D2D9 File Offset: 0x0011B4D9
		public void SetSearchModeToRadius()
		{
			vtkPCANormalEstimation.vtkPCANormalEstimation_SetSearchModeToRadius_32(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F21 RID: 3873
		public new const string MRFullTypeName = "Kitware.VTK.vtkPCANormalEstimation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F22 RID: 3874
		public new static readonly string MRClassNameKey = "class vtkPCANormalEstimation";

		/// <summary>
		/// This enum is used to control how the closest neighbor is calculated
		/// </summary>
		// Token: 0x0200044B RID: 1099
		public enum NeighborSearchMode
		{
			/// <summary>enum member</summary>
			// Token: 0x04000F24 RID: 3876
			KNN,
			/// <summary>enum member</summary>
			// Token: 0x04000F25 RID: 3877
			RADIUS
		}

		/// <summary>
		/// This enum is used to control how normals oriented is controlled.
		/// </summary>
		// Token: 0x0200044C RID: 1100
		public enum Style
		{
			/// <summary>enum member</summary>
			// Token: 0x04000F27 RID: 3879
			AS_COMPUTED,
			/// <summary>enum member</summary>
			// Token: 0x04000F28 RID: 3880
			GRAPH_TRAVERSAL = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000F29 RID: 3881
			POINT = 1
		}
	}
}
