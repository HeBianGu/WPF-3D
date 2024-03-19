using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkEuclideanClusterExtraction
	/// </summary>
	/// <remarks>
	///    perform segmentation based on geometric
	/// proximity and optional scalar threshold
	///
	/// vtkEuclideanClusterExtraction is a filter that extracts points that are in
	/// close geometric proximity, and optionally satisfies a scalar threshold
	/// criterion. (Points extracted in this way are referred to as clusters.)
	/// The filter works in one of five ways: 1) extract the largest cluster in the
	/// dataset; 2) extract specified cluster number(s); 3) extract all clusters
	/// containing specified point ids; 4) extract the cluster closest to a specified
	/// point; or 5) extract all clusters (which can be used for coloring the clusters).
	///
	/// Note that geometric proximity is defined by setting the Radius instance
	/// variable. This variable defines a local sphere around each point; other
	/// points contained in this sphere are considered "connected" to the
	/// point. Setting this number too large will connect clusters that should not
	/// be; setting it too small will fragment the point cloud into myriad
	/// clusters. To accelerate the geometric proximity operations, a point
	/// locator may be specified. By default, a vtkStaticPointLocator is used, but
	/// any vtkAbstractPointLocator may be specified.
	///
	/// The behavior of vtkEuclideanClusterExtraction can be modified by turning
	/// on the boolean ivar ScalarConnectivity. If this flag is on, the clustering
	/// algorithm is modified so that points are considered part of a cluster if
	/// they satisfy both the geometric proximity measure, and the points scalar
	/// values falls into the scalar range specified. This use of
	/// ScalarConnectivity is particularly useful for data with intensity or color
	/// information, serving as a simple "connected segmentation" algorithm. For
	/// example, by using a seed point in a known cluster, clustering will pull
	/// out all points "representing" the local structure.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkConnectivityFilter vtkPolyDataConnectivityFilter
	/// </seealso>
	// Token: 0x0200043D RID: 1085
	public class vtkEuclideanClusterExtraction : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600CAA6 RID: 51878 RVA: 0x00119F6F File Offset: 0x0011816F
		static vtkEuclideanClusterExtraction()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEuclideanClusterExtraction.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEuclideanClusterExtraction"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600CAA7 RID: 51879 RVA: 0x00119F97 File Offset: 0x00118197
		public vtkEuclideanClusterExtraction(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600CAA8 RID: 51880
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEuclideanClusterExtraction_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with default extraction mode to extract largest clusters.
		/// </summary>
		// Token: 0x0600CAA9 RID: 51881 RVA: 0x00119FA8 File Offset: 0x001181A8
		public new static vtkEuclideanClusterExtraction New()
		{
			vtkEuclideanClusterExtraction result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEuclideanClusterExtraction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with default extraction mode to extract largest clusters.
		/// </summary>
		// Token: 0x0600CAAA RID: 51882 RVA: 0x00119FFC File Offset: 0x001181FC
		public vtkEuclideanClusterExtraction() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600CAAB RID: 51883 RVA: 0x0011A040 File Offset: 0x00118240
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600CAAC RID: 51884
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEuclideanClusterExtraction_AddSeed_01(HandleRef pThis, long id);

		/// <summary>
		/// Add a seed id (point id). Note: ids are 0-offset.
		/// </summary>
		// Token: 0x0600CAAD RID: 51885 RVA: 0x0011A04B File Offset: 0x0011824B
		public void AddSeed(long id)
		{
			vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_AddSeed_01(base.GetCppThis(), id);
		}

		// Token: 0x0600CAAE RID: 51886
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEuclideanClusterExtraction_AddSpecifiedCluster_02(HandleRef pThis, int id);

		/// <summary>
		/// Add a cluster id to extract. Note: ids are 0-offset.
		/// </summary>
		// Token: 0x0600CAAF RID: 51887 RVA: 0x0011A05B File Offset: 0x0011825B
		public void AddSpecifiedCluster(int id)
		{
			vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_AddSpecifiedCluster_02(base.GetCppThis(), id);
		}

		// Token: 0x0600CAB0 RID: 51888
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEuclideanClusterExtraction_ColorClustersOff_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off the coloring of connected clusters.
		/// </summary>
		// Token: 0x0600CAB1 RID: 51889 RVA: 0x0011A06B File Offset: 0x0011826B
		public virtual void ColorClustersOff()
		{
			vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_ColorClustersOff_03(base.GetCppThis());
		}

		// Token: 0x0600CAB2 RID: 51890
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEuclideanClusterExtraction_ColorClustersOn_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off the coloring of connected clusters.
		/// </summary>
		// Token: 0x0600CAB3 RID: 51891 RVA: 0x0011A07A File Offset: 0x0011827A
		public virtual void ColorClustersOn()
		{
			vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_ColorClustersOn_04(base.GetCppThis());
		}

		// Token: 0x0600CAB4 RID: 51892
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEuclideanClusterExtraction_DeleteSeed_05(HandleRef pThis, long id);

		/// <summary>
		/// Delete a seed id.a
		/// </summary>
		// Token: 0x0600CAB5 RID: 51893 RVA: 0x0011A089 File Offset: 0x00118289
		public void DeleteSeed(long id)
		{
			vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_DeleteSeed_05(base.GetCppThis(), id);
		}

		// Token: 0x0600CAB6 RID: 51894
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEuclideanClusterExtraction_DeleteSpecifiedCluster_06(HandleRef pThis, int id);

		/// <summary>
		/// Delete a cluster id to extract.
		/// </summary>
		// Token: 0x0600CAB7 RID: 51895 RVA: 0x0011A099 File Offset: 0x00118299
		public void DeleteSpecifiedCluster(int id)
		{
			vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_DeleteSpecifiedCluster_06(base.GetCppThis(), id);
		}

		// Token: 0x0600CAB8 RID: 51896
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEuclideanClusterExtraction_GetClosestPoint_07(HandleRef pThis);

		/// <summary>
		/// Used to specify the x-y-z point coordinates when extracting the cluster
		/// closest to a specified point.
		/// </summary>
		// Token: 0x0600CAB9 RID: 51897 RVA: 0x0011A0AC File Offset: 0x001182AC
		public virtual double[] GetClosestPoint()
		{
			IntPtr intPtr = vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_GetClosestPoint_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600CABA RID: 51898
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEuclideanClusterExtraction_GetClosestPoint_08(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Used to specify the x-y-z point coordinates when extracting the cluster
		/// closest to a specified point.
		/// </summary>
		// Token: 0x0600CABB RID: 51899 RVA: 0x0011A0F4 File Offset: 0x001182F4
		public virtual void GetClosestPoint(IntPtr data)
		{
			vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_GetClosestPoint_08(base.GetCppThis(), data);
		}

		// Token: 0x0600CABC RID: 51900
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkEuclideanClusterExtraction_GetColorClusters_09(HandleRef pThis);

		/// <summary>
		/// Turn on/off the coloring of connected clusters.
		/// </summary>
		// Token: 0x0600CABD RID: 51901 RVA: 0x0011A104 File Offset: 0x00118304
		public virtual bool GetColorClusters()
		{
			return vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_GetColorClusters_09(base.GetCppThis()) != 0;
		}

		// Token: 0x0600CABE RID: 51902
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEuclideanClusterExtraction_GetExtractionMode_10(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x0600CABF RID: 51903 RVA: 0x0011A12C File Offset: 0x0011832C
		public virtual int GetExtractionMode()
		{
			return vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_GetExtractionMode_10(base.GetCppThis());
		}

		// Token: 0x0600CAC0 RID: 51904
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEuclideanClusterExtraction_GetExtractionModeAsString_11(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x0600CAC1 RID: 51905 RVA: 0x0011A14C File Offset: 0x0011834C
		public string GetExtractionModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_GetExtractionModeAsString_11(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600CAC2 RID: 51906
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEuclideanClusterExtraction_GetExtractionModeMaxValue_12(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x0600CAC3 RID: 51907 RVA: 0x0011A188 File Offset: 0x00118388
		public virtual int GetExtractionModeMaxValue()
		{
			return vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_GetExtractionModeMaxValue_12(base.GetCppThis());
		}

		// Token: 0x0600CAC4 RID: 51908
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEuclideanClusterExtraction_GetExtractionModeMinValue_13(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x0600CAC5 RID: 51909 RVA: 0x0011A1A8 File Offset: 0x001183A8
		public virtual int GetExtractionModeMinValue()
		{
			return vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_GetExtractionModeMinValue_13(base.GetCppThis());
		}

		// Token: 0x0600CAC6 RID: 51910
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEuclideanClusterExtraction_GetLocator_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a point locator. By default a vtkStaticPointLocator is
		/// used. The locator performs efficient proximity searches near a
		/// specified interpolation position.
		/// </summary>
		// Token: 0x0600CAC7 RID: 51911 RVA: 0x0011A1C8 File Offset: 0x001183C8
		public virtual vtkAbstractPointLocator GetLocator()
		{
			vtkAbstractPointLocator vtkAbstractPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_GetLocator_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600CAC8 RID: 51912
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEuclideanClusterExtraction_GetNumberOfExtractedClusters_15(HandleRef pThis);

		/// <summary>
		/// Obtain the number of connected clusters. This value is valid only after filter execution.
		/// </summary>
		// Token: 0x0600CAC9 RID: 51913 RVA: 0x0011A238 File Offset: 0x00118438
		public int GetNumberOfExtractedClusters()
		{
			return vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_GetNumberOfExtractedClusters_15(base.GetCppThis());
		}

		// Token: 0x0600CACA RID: 51914
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEuclideanClusterExtraction_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600CACB RID: 51915 RVA: 0x0011A258 File Offset: 0x00118458
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x0600CACC RID: 51916
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEuclideanClusterExtraction_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600CACD RID: 51917 RVA: 0x0011A278 File Offset: 0x00118478
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x0600CACE RID: 51918
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEuclideanClusterExtraction_GetRadius_18(HandleRef pThis);

		/// <summary>
		/// Specify the local search radius.
		/// </summary>
		// Token: 0x0600CACF RID: 51919 RVA: 0x0011A294 File Offset: 0x00118494
		public virtual double GetRadius()
		{
			return vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_GetRadius_18(base.GetCppThis());
		}

		// Token: 0x0600CAD0 RID: 51920
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEuclideanClusterExtraction_GetRadiusMaxValue_19(HandleRef pThis);

		/// <summary>
		/// Specify the local search radius.
		/// </summary>
		// Token: 0x0600CAD1 RID: 51921 RVA: 0x0011A2B4 File Offset: 0x001184B4
		public virtual double GetRadiusMaxValue()
		{
			return vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_GetRadiusMaxValue_19(base.GetCppThis());
		}

		// Token: 0x0600CAD2 RID: 51922
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEuclideanClusterExtraction_GetRadiusMinValue_20(HandleRef pThis);

		/// <summary>
		/// Specify the local search radius.
		/// </summary>
		// Token: 0x0600CAD3 RID: 51923 RVA: 0x0011A2D4 File Offset: 0x001184D4
		public virtual double GetRadiusMinValue()
		{
			return vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_GetRadiusMinValue_20(base.GetCppThis());
		}

		// Token: 0x0600CAD4 RID: 51924
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkEuclideanClusterExtraction_GetScalarConnectivity_21(HandleRef pThis);

		/// <summary>
		/// Turn on/off connectivity based on scalar value. If on, points are
		/// connected only if the are proximal AND the scalar value of a candidate
		/// point falls in the scalar range specified. Of course input point scalar
		/// data must be provided.
		/// </summary>
		// Token: 0x0600CAD5 RID: 51925 RVA: 0x0011A2F4 File Offset: 0x001184F4
		public virtual bool GetScalarConnectivity()
		{
			return vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_GetScalarConnectivity_21(base.GetCppThis()) != 0;
		}

		// Token: 0x0600CAD6 RID: 51926
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEuclideanClusterExtraction_GetScalarRange_22(HandleRef pThis);

		/// <summary>
		/// Set the scalar range used to extract points based on scalar connectivity.
		/// </summary>
		// Token: 0x0600CAD7 RID: 51927 RVA: 0x0011A31C File Offset: 0x0011851C
		public virtual double[] GetScalarRange()
		{
			IntPtr intPtr = vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_GetScalarRange_22(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600CAD8 RID: 51928
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEuclideanClusterExtraction_GetScalarRange_23(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Set the scalar range used to extract points based on scalar connectivity.
		/// </summary>
		// Token: 0x0600CAD9 RID: 51929 RVA: 0x0011A364 File Offset: 0x00118564
		public virtual void GetScalarRange(ref double _arg1, ref double _arg2)
		{
			vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_GetScalarRange_23(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600CADA RID: 51930
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEuclideanClusterExtraction_GetScalarRange_24(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the scalar range used to extract points based on scalar connectivity.
		/// </summary>
		// Token: 0x0600CADB RID: 51931 RVA: 0x0011A375 File Offset: 0x00118575
		public virtual void GetScalarRange(IntPtr _arg)
		{
			vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_GetScalarRange_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CADC RID: 51932
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEuclideanClusterExtraction_InitializeSeedList_25(HandleRef pThis);

		/// <summary>
		/// Initialize the list of point ids used to seed clusters.
		/// </summary>
		// Token: 0x0600CADD RID: 51933 RVA: 0x0011A385 File Offset: 0x00118585
		public void InitializeSeedList()
		{
			vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_InitializeSeedList_25(base.GetCppThis());
		}

		// Token: 0x0600CADE RID: 51934
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEuclideanClusterExtraction_InitializeSpecifiedClusterList_26(HandleRef pThis);

		/// <summary>
		/// Initialize the list of cluster ids to extract.
		/// </summary>
		// Token: 0x0600CADF RID: 51935 RVA: 0x0011A394 File Offset: 0x00118594
		public void InitializeSpecifiedClusterList()
		{
			vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_InitializeSpecifiedClusterList_26(base.GetCppThis());
		}

		// Token: 0x0600CAE0 RID: 51936
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEuclideanClusterExtraction_IsA_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600CAE1 RID: 51937 RVA: 0x0011A3A4 File Offset: 0x001185A4
		public override int IsA(string type)
		{
			return vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_IsA_27(base.GetCppThis(), type);
		}

		// Token: 0x0600CAE2 RID: 51938
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEuclideanClusterExtraction_IsTypeOf_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600CAE3 RID: 51939 RVA: 0x0011A3C4 File Offset: 0x001185C4
		public new static int IsTypeOf(string type)
		{
			return vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_IsTypeOf_28(type);
		}

		// Token: 0x0600CAE4 RID: 51940
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEuclideanClusterExtraction_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600CAE5 RID: 51941 RVA: 0x0011A3E0 File Offset: 0x001185E0
		public new vtkEuclideanClusterExtraction NewInstance()
		{
			vtkEuclideanClusterExtraction result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_NewInstance_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEuclideanClusterExtraction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600CAE6 RID: 51942
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEuclideanClusterExtraction_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600CAE7 RID: 51943 RVA: 0x0011A43C File Offset: 0x0011863C
		public new static vtkEuclideanClusterExtraction SafeDownCast(vtkObjectBase o)
		{
			vtkEuclideanClusterExtraction vtkEuclideanClusterExtraction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEuclideanClusterExtraction = (vtkEuclideanClusterExtraction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEuclideanClusterExtraction.Register(null);
				}
			}
			return vtkEuclideanClusterExtraction;
		}

		// Token: 0x0600CAE8 RID: 51944
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEuclideanClusterExtraction_ScalarConnectivityOff_32(HandleRef pThis);

		/// <summary>
		/// Turn on/off connectivity based on scalar value. If on, points are
		/// connected only if the are proximal AND the scalar value of a candidate
		/// point falls in the scalar range specified. Of course input point scalar
		/// data must be provided.
		/// </summary>
		// Token: 0x0600CAE9 RID: 51945 RVA: 0x0011A4BB File Offset: 0x001186BB
		public virtual void ScalarConnectivityOff()
		{
			vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_ScalarConnectivityOff_32(base.GetCppThis());
		}

		// Token: 0x0600CAEA RID: 51946
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEuclideanClusterExtraction_ScalarConnectivityOn_33(HandleRef pThis);

		/// <summary>
		/// Turn on/off connectivity based on scalar value. If on, points are
		/// connected only if the are proximal AND the scalar value of a candidate
		/// point falls in the scalar range specified. Of course input point scalar
		/// data must be provided.
		/// </summary>
		// Token: 0x0600CAEB RID: 51947 RVA: 0x0011A4CA File Offset: 0x001186CA
		public virtual void ScalarConnectivityOn()
		{
			vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_ScalarConnectivityOn_33(base.GetCppThis());
		}

		// Token: 0x0600CAEC RID: 51948
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEuclideanClusterExtraction_SetClosestPoint_34(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Used to specify the x-y-z point coordinates when extracting the cluster
		/// closest to a specified point.
		/// </summary>
		// Token: 0x0600CAED RID: 51949 RVA: 0x0011A4D9 File Offset: 0x001186D9
		public virtual void SetClosestPoint(double _arg1, double _arg2, double _arg3)
		{
			vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_SetClosestPoint_34(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600CAEE RID: 51950
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEuclideanClusterExtraction_SetClosestPoint_35(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Used to specify the x-y-z point coordinates when extracting the cluster
		/// closest to a specified point.
		/// </summary>
		// Token: 0x0600CAEF RID: 51951 RVA: 0x0011A4EB File Offset: 0x001186EB
		public virtual void SetClosestPoint(IntPtr _arg)
		{
			vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_SetClosestPoint_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CAF0 RID: 51952
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEuclideanClusterExtraction_SetColorClusters_36(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off the coloring of connected clusters.
		/// </summary>
		// Token: 0x0600CAF1 RID: 51953 RVA: 0x0011A4FB File Offset: 0x001186FB
		public virtual void SetColorClusters(bool _arg)
		{
			vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_SetColorClusters_36(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600CAF2 RID: 51954
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEuclideanClusterExtraction_SetExtractionMode_37(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x0600CAF3 RID: 51955 RVA: 0x0011A513 File Offset: 0x00118713
		public virtual void SetExtractionMode(int _arg)
		{
			vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_SetExtractionMode_37(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CAF4 RID: 51956
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEuclideanClusterExtraction_SetExtractionModeToAllClusters_38(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x0600CAF5 RID: 51957 RVA: 0x0011A523 File Offset: 0x00118723
		public void SetExtractionModeToAllClusters()
		{
			vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_SetExtractionModeToAllClusters_38(base.GetCppThis());
		}

		// Token: 0x0600CAF6 RID: 51958
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEuclideanClusterExtraction_SetExtractionModeToClosestPointCluster_39(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x0600CAF7 RID: 51959 RVA: 0x0011A532 File Offset: 0x00118732
		public void SetExtractionModeToClosestPointCluster()
		{
			vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_SetExtractionModeToClosestPointCluster_39(base.GetCppThis());
		}

		// Token: 0x0600CAF8 RID: 51960
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEuclideanClusterExtraction_SetExtractionModeToLargestCluster_40(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x0600CAF9 RID: 51961 RVA: 0x0011A541 File Offset: 0x00118741
		public void SetExtractionModeToLargestCluster()
		{
			vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_SetExtractionModeToLargestCluster_40(base.GetCppThis());
		}

		// Token: 0x0600CAFA RID: 51962
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEuclideanClusterExtraction_SetExtractionModeToPointSeededClusters_41(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x0600CAFB RID: 51963 RVA: 0x0011A550 File Offset: 0x00118750
		public void SetExtractionModeToPointSeededClusters()
		{
			vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_SetExtractionModeToPointSeededClusters_41(base.GetCppThis());
		}

		// Token: 0x0600CAFC RID: 51964
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEuclideanClusterExtraction_SetExtractionModeToSpecifiedClusters_42(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x0600CAFD RID: 51965 RVA: 0x0011A55F File Offset: 0x0011875F
		public void SetExtractionModeToSpecifiedClusters()
		{
			vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_SetExtractionModeToSpecifiedClusters_42(base.GetCppThis());
		}

		// Token: 0x0600CAFE RID: 51966
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEuclideanClusterExtraction_SetLocator_43(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Specify a point locator. By default a vtkStaticPointLocator is
		/// used. The locator performs efficient proximity searches near a
		/// specified interpolation position.
		/// </summary>
		// Token: 0x0600CAFF RID: 51967 RVA: 0x0011A570 File Offset: 0x00118770
		public void SetLocator(vtkAbstractPointLocator locator)
		{
			vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_SetLocator_43(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0600CB00 RID: 51968
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEuclideanClusterExtraction_SetRadius_44(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the local search radius.
		/// </summary>
		// Token: 0x0600CB01 RID: 51969 RVA: 0x0011A59F File Offset: 0x0011879F
		public virtual void SetRadius(double _arg)
		{
			vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_SetRadius_44(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CB02 RID: 51970
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEuclideanClusterExtraction_SetScalarConnectivity_45(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off connectivity based on scalar value. If on, points are
		/// connected only if the are proximal AND the scalar value of a candidate
		/// point falls in the scalar range specified. Of course input point scalar
		/// data must be provided.
		/// </summary>
		// Token: 0x0600CB03 RID: 51971 RVA: 0x0011A5AF File Offset: 0x001187AF
		public virtual void SetScalarConnectivity(bool _arg)
		{
			vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_SetScalarConnectivity_45(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600CB04 RID: 51972
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEuclideanClusterExtraction_SetScalarRange_46(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Set the scalar range used to extract points based on scalar connectivity.
		/// </summary>
		// Token: 0x0600CB05 RID: 51973 RVA: 0x0011A5C7 File Offset: 0x001187C7
		public virtual void SetScalarRange(double _arg1, double _arg2)
		{
			vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_SetScalarRange_46(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600CB06 RID: 51974
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEuclideanClusterExtraction_SetScalarRange_47(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the scalar range used to extract points based on scalar connectivity.
		/// </summary>
		// Token: 0x0600CB07 RID: 51975 RVA: 0x0011A5D8 File Offset: 0x001187D8
		public void SetScalarRange(IntPtr _arg)
		{
			vtkEuclideanClusterExtraction.vtkEuclideanClusterExtraction_SetScalarRange_47(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F07 RID: 3847
		public new const string MRFullTypeName = "Kitware.VTK.vtkEuclideanClusterExtraction";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F08 RID: 3848
		public new static readonly string MRClassNameKey = "class vtkEuclideanClusterExtraction";
	}
}
