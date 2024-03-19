using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPCACurvatureEstimation
	/// </summary>
	/// <remarks>
	///    generate curvature estimates using
	/// principal component analysis
	///
	///
	/// vtkPCACurvatureEstimation generates point normals using PCA (principal
	/// component analysis).  Basically this estimates a local tangent plane
	/// around sample point p by considering a small neighborhood of points
	/// around p, and fitting a plane to the neighborhood (via PCA). A good
	/// introductory reference is Hoppe's "Surface reconstruction from
	/// unorganized points."
	///
	/// To use this filter, specify a neighborhood size. This may have to be set
	/// via experimentation. Optionally a point locator can be specified (instead
	/// of the default locator), which is used to accelerate searches around a
	/// sample point. Finally, the user should specify how to generate
	/// consistently-oriented normals. As computed by PCA, normals may point in
	/// +/- orientation, which may not be consistent with neighboring normals.
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
	/// vtkPCANormalEstimation
	/// </seealso>
	// Token: 0x02000449 RID: 1097
	public class vtkPCACurvatureEstimation : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600CC8D RID: 52365 RVA: 0x0011CAB3 File Offset: 0x0011ACB3
		static vtkPCACurvatureEstimation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPCACurvatureEstimation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPCACurvatureEstimation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600CC8E RID: 52366 RVA: 0x0011CADB File Offset: 0x0011ACDB
		public vtkPCACurvatureEstimation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600CC8F RID: 52367
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPCACurvatureEstimation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CC90 RID: 52368 RVA: 0x0011CAEC File Offset: 0x0011ACEC
		public new static vtkPCACurvatureEstimation New()
		{
			vtkPCACurvatureEstimation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPCACurvatureEstimation.vtkPCACurvatureEstimation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPCACurvatureEstimation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CC91 RID: 52369 RVA: 0x0011CB40 File Offset: 0x0011AD40
		public vtkPCACurvatureEstimation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPCACurvatureEstimation.vtkPCACurvatureEstimation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600CC92 RID: 52370 RVA: 0x0011CB84 File Offset: 0x0011AD84
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600CC93 RID: 52371
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPCACurvatureEstimation_GetLocator_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a point locator. By default a vtkStaticPointLocator is
		/// used. The locator performs efficient searches to locate points
		/// around a sample point.
		/// </summary>
		// Token: 0x0600CC94 RID: 52372 RVA: 0x0011CB90 File Offset: 0x0011AD90
		public virtual vtkAbstractPointLocator GetLocator()
		{
			vtkAbstractPointLocator vtkAbstractPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPCACurvatureEstimation.vtkPCACurvatureEstimation_GetLocator_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600CC95 RID: 52373
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPCACurvatureEstimation_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CC96 RID: 52374 RVA: 0x0011CC00 File Offset: 0x0011AE00
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPCACurvatureEstimation.vtkPCACurvatureEstimation_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600CC97 RID: 52375
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPCACurvatureEstimation_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CC98 RID: 52376 RVA: 0x0011CC20 File Offset: 0x0011AE20
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPCACurvatureEstimation.vtkPCACurvatureEstimation_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600CC99 RID: 52377
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPCACurvatureEstimation_GetSampleSize_04(HandleRef pThis);

		/// <summary>
		/// For each sampled point, specify the number of the closest, surrounding
		/// points used to estimate the normal (the so called k-neighborhood). By
		/// default 25 points are used. Smaller numbers may speed performance at the
		/// cost of accuracy.
		/// </summary>
		// Token: 0x0600CC9A RID: 52378 RVA: 0x0011CC3C File Offset: 0x0011AE3C
		public virtual int GetSampleSize()
		{
			return vtkPCACurvatureEstimation.vtkPCACurvatureEstimation_GetSampleSize_04(base.GetCppThis());
		}

		// Token: 0x0600CC9B RID: 52379
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPCACurvatureEstimation_GetSampleSizeMaxValue_05(HandleRef pThis);

		/// <summary>
		/// For each sampled point, specify the number of the closest, surrounding
		/// points used to estimate the normal (the so called k-neighborhood). By
		/// default 25 points are used. Smaller numbers may speed performance at the
		/// cost of accuracy.
		/// </summary>
		// Token: 0x0600CC9C RID: 52380 RVA: 0x0011CC5C File Offset: 0x0011AE5C
		public virtual int GetSampleSizeMaxValue()
		{
			return vtkPCACurvatureEstimation.vtkPCACurvatureEstimation_GetSampleSizeMaxValue_05(base.GetCppThis());
		}

		// Token: 0x0600CC9D RID: 52381
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPCACurvatureEstimation_GetSampleSizeMinValue_06(HandleRef pThis);

		/// <summary>
		/// For each sampled point, specify the number of the closest, surrounding
		/// points used to estimate the normal (the so called k-neighborhood). By
		/// default 25 points are used. Smaller numbers may speed performance at the
		/// cost of accuracy.
		/// </summary>
		// Token: 0x0600CC9E RID: 52382 RVA: 0x0011CC7C File Offset: 0x0011AE7C
		public virtual int GetSampleSizeMinValue()
		{
			return vtkPCACurvatureEstimation.vtkPCACurvatureEstimation_GetSampleSizeMinValue_06(base.GetCppThis());
		}

		// Token: 0x0600CC9F RID: 52383
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPCACurvatureEstimation_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CCA0 RID: 52384 RVA: 0x0011CC9C File Offset: 0x0011AE9C
		public override int IsA(string type)
		{
			return vtkPCACurvatureEstimation.vtkPCACurvatureEstimation_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0600CCA1 RID: 52385
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPCACurvatureEstimation_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CCA2 RID: 52386 RVA: 0x0011CCBC File Offset: 0x0011AEBC
		public new static int IsTypeOf(string type)
		{
			return vtkPCACurvatureEstimation.vtkPCACurvatureEstimation_IsTypeOf_08(type);
		}

		// Token: 0x0600CCA3 RID: 52387
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPCACurvatureEstimation_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CCA4 RID: 52388 RVA: 0x0011CCD8 File Offset: 0x0011AED8
		public new vtkPCACurvatureEstimation NewInstance()
		{
			vtkPCACurvatureEstimation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPCACurvatureEstimation.vtkPCACurvatureEstimation_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPCACurvatureEstimation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600CCA5 RID: 52389
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPCACurvatureEstimation_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CCA6 RID: 52390 RVA: 0x0011CD34 File Offset: 0x0011AF34
		public new static vtkPCACurvatureEstimation SafeDownCast(vtkObjectBase o)
		{
			vtkPCACurvatureEstimation vtkPCACurvatureEstimation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPCACurvatureEstimation.vtkPCACurvatureEstimation_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPCACurvatureEstimation = (vtkPCACurvatureEstimation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPCACurvatureEstimation.Register(null);
				}
			}
			return vtkPCACurvatureEstimation;
		}

		// Token: 0x0600CCA7 RID: 52391
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCACurvatureEstimation_SetLocator_12(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Specify a point locator. By default a vtkStaticPointLocator is
		/// used. The locator performs efficient searches to locate points
		/// around a sample point.
		/// </summary>
		// Token: 0x0600CCA8 RID: 52392 RVA: 0x0011CDB4 File Offset: 0x0011AFB4
		public void SetLocator(vtkAbstractPointLocator locator)
		{
			vtkPCACurvatureEstimation.vtkPCACurvatureEstimation_SetLocator_12(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0600CCA9 RID: 52393
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPCACurvatureEstimation_SetSampleSize_13(HandleRef pThis, int _arg);

		/// <summary>
		/// For each sampled point, specify the number of the closest, surrounding
		/// points used to estimate the normal (the so called k-neighborhood). By
		/// default 25 points are used. Smaller numbers may speed performance at the
		/// cost of accuracy.
		/// </summary>
		// Token: 0x0600CCAA RID: 52394 RVA: 0x0011CDE3 File Offset: 0x0011AFE3
		public virtual void SetSampleSize(int _arg)
		{
			vtkPCACurvatureEstimation.vtkPCACurvatureEstimation_SetSampleSize_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F1F RID: 3871
		public new const string MRFullTypeName = "Kitware.VTK.vtkPCACurvatureEstimation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F20 RID: 3872
		public new static readonly string MRClassNameKey = "class vtkPCACurvatureEstimation";
	}
}
