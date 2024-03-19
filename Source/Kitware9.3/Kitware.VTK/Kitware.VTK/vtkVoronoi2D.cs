using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVoronoi2D
	/// </summary>
	/// <remarks>
	///    create 2D Voronoi convex tiling of input points
	///
	/// vtkVoronoi2D is a filter that constructs a 2D Voronoi tessellation of a
	/// list of input points. The points are assumed to lie in a plane. These
	/// points may be represented by any dataset of type vtkPointSet and
	/// subclasses. The output of the filter is a polygonal dataset. Each output
	/// cell is a convex polygon.
	///
	/// The 2D Voronoi tessellation is a tiling of space, where each Voronoi tile
	/// represents the region nearest to one of the input points. Voronoi
	/// tessellations are important in computational geometry (and many other
	/// fields), and are the dual of Delaunay triangulations.
	///
	/// The input to this filter is a list of points specified in 3D, even though
	/// the triangulation is 2D. Thus the triangulation is constructed in the x-y
	/// plane, and the z coordinate is ignored (although carried through to the
	/// output). If you desire to triangulate in a different plane, you can use
	/// the vtkTransformFilter to transform the points into and out of the x-y
	/// plane or you can specify a transform to vtkVoronoi2D directly.  In the
	/// latter case, the input points are transformed, the transformed points are
	/// triangulated, and the output will use the triangulated topology for the
	/// original (non-transformed) points.  This avoids transforming the data back
	/// as would be required when using the vtkTransformFilter method.  Specifying
	/// a transform directly also allows any transform to be used: rigid,
	/// non-rigid, non-invertible, etc.
	///
	/// This filter is a reference implementation written with simplicity in
	/// mind. Additional methods are available for debugging / instructional
	/// purposes. This includes producing a single tile under various stages of
	/// creation, as well as the Voronoi flower, related to the error metric for
	/// point insertion / half-space clipping.
	///
	/// Publications are in preparation to describe the algorithm. A brief summary
	/// is as follows. In parallel, each (generating) input point is associated
	/// with an initial Voronoi tile, which is simply the bounding box of the
	/// point set. A locator is then used to identify nearby points: each neighbor
	/// in turn generates a clipping line positioned halfway between the
	/// generating point and the neighboring point, and orthogonal to the line
	/// connecting them. Clips are readily performed by evaluating the vertices
	/// of the convex Voronoi tile as being on either side (inside,outside) of the
	/// clip line. If two intersections of the Voronoi tile are found, the portion
	/// of the tile "outside" the clip line is discarded, resulting in a new
	/// convex, Voronoi tile. As each clip occurs, the Voronoi "Flower" error
	/// metric (the union of error spheres) is compared to the extent of the
	/// region containing the neighboring clip points. The clip region (along with
	/// the points contained in it) is grown by careful expansion (e.g., outward
	/// spiraling iterator over all candidate clip points). When the Voronoi
	/// Flower is contained within the clip region, the algorithm terminates and
	/// the Voronoi tile is output. Once complete, it is possible to construct the
	/// Delaunay triangulation from the Voronoi tessellation. Note that
	/// topological and geometric information is used to generate a valid
	/// triangulation (e.g., merging points and validating topology).
	///
	/// @warning
	/// Coincident input points will result in overlapping tiles.  This is because
	/// the Voronoi tessellation requires unique input points.
	///
	/// @warning
	/// This is a novel approach which implements an embarrassingly parallel
	/// algorithm. At the core of the algorithm a locator is used to determine
	/// points close to a specified position. A vtkStaticPointLocator2D is used
	/// because it is both threaded (when constructed) and supports thread-safe
	/// queries. While other locators could be used in principal, they must
	/// support thread-safe operations.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDelaunay2D vtkTransformFilter vtkStaticPointLocator2D
	/// </seealso>
	// Token: 0x020009C1 RID: 2497
	public class vtkVoronoi2D : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A155 RID: 106837 RVA: 0x00242800 File Offset: 0x00240A00
		static vtkVoronoi2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVoronoi2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVoronoi2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A156 RID: 106838 RVA: 0x00242828 File Offset: 0x00240A28
		public vtkVoronoi2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A157 RID: 106839
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoronoi2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601A158 RID: 106840 RVA: 0x00242838 File Offset: 0x00240A38
		public new static vtkVoronoi2D New()
		{
			vtkVoronoi2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVoronoi2D.vtkVoronoi2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVoronoi2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601A159 RID: 106841 RVA: 0x0024288C File Offset: 0x00240A8C
		public vtkVoronoi2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVoronoi2D.vtkVoronoi2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A15A RID: 106842 RVA: 0x002428D0 File Offset: 0x00240AD0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A15B RID: 106843
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoronoi2D_GenerateVoronoiFlowerOff_01(HandleRef pThis);

		/// <summary>
		/// These methods are for debugging or instructional purposes. If
		/// GenerateVoronoiFlower is on, and the PointOfIntersect is specified, then
		/// second and third (optional) outputs are populated which contains a
		/// representation of the Voronoi flower error metric (second output) and
		/// the single Voronoi tile (corresponding to PointOfInterest) with point
		/// scalar values indicating the radii of the Voronoi Flower petals (i.e.,
		/// circles contributing to the error metric).
		/// </summary>
		// Token: 0x0601A15C RID: 106844 RVA: 0x002428DB File Offset: 0x00240ADB
		public virtual void GenerateVoronoiFlowerOff()
		{
			vtkVoronoi2D.vtkVoronoi2D_GenerateVoronoiFlowerOff_01(base.GetCppThis());
		}

		// Token: 0x0601A15D RID: 106845
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoronoi2D_GenerateVoronoiFlowerOn_02(HandleRef pThis);

		/// <summary>
		/// These methods are for debugging or instructional purposes. If
		/// GenerateVoronoiFlower is on, and the PointOfIntersect is specified, then
		/// second and third (optional) outputs are populated which contains a
		/// representation of the Voronoi flower error metric (second output) and
		/// the single Voronoi tile (corresponding to PointOfInterest) with point
		/// scalar values indicating the radii of the Voronoi Flower petals (i.e.,
		/// circles contributing to the error metric).
		/// </summary>
		// Token: 0x0601A15E RID: 106846 RVA: 0x002428EA File Offset: 0x00240AEA
		public virtual void GenerateVoronoiFlowerOn()
		{
			vtkVoronoi2D.vtkVoronoi2D_GenerateVoronoiFlowerOn_02(base.GetCppThis());
		}

		// Token: 0x0601A15F RID: 106847
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoronoi2D_GetGenerateScalars_03(HandleRef pThis);

		/// <summary>
		/// Indicate whether to create a scalar array as part of the output. No
		/// scalars; point ids, or execution thread ids may be output. By default no
		/// scalars are generated.
		/// </summary>
		// Token: 0x0601A160 RID: 106848 RVA: 0x002428FC File Offset: 0x00240AFC
		public virtual int GetGenerateScalars()
		{
			return vtkVoronoi2D.vtkVoronoi2D_GetGenerateScalars_03(base.GetCppThis());
		}

		// Token: 0x0601A161 RID: 106849
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoronoi2D_GetGenerateVoronoiFlower_04(HandleRef pThis);

		/// <summary>
		/// These methods are for debugging or instructional purposes. If
		/// GenerateVoronoiFlower is on, and the PointOfIntersect is specified, then
		/// second and third (optional) outputs are populated which contains a
		/// representation of the Voronoi flower error metric (second output) and
		/// the single Voronoi tile (corresponding to PointOfInterest) with point
		/// scalar values indicating the radii of the Voronoi Flower petals (i.e.,
		/// circles contributing to the error metric).
		/// </summary>
		// Token: 0x0601A162 RID: 106850 RVA: 0x0024291C File Offset: 0x00240B1C
		public virtual int GetGenerateVoronoiFlower()
		{
			return vtkVoronoi2D.vtkVoronoi2D_GetGenerateVoronoiFlower_04(base.GetCppThis());
		}

		// Token: 0x0601A163 RID: 106851
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoronoi2D_GetLocator_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve the internal locator to manually configure it, for example
		/// specifying the number of points per bucket. This method is generally
		/// used for debugging or testing purposes.
		/// </summary>
		// Token: 0x0601A164 RID: 106852 RVA: 0x0024293C File Offset: 0x00240B3C
		public vtkStaticPointLocator2D GetLocator()
		{
			vtkStaticPointLocator2D vtkStaticPointLocator2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVoronoi2D.vtkVoronoi2D_GetLocator_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStaticPointLocator2D = (vtkStaticPointLocator2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStaticPointLocator2D.Register(null);
				}
			}
			return vtkStaticPointLocator2D;
		}

		// Token: 0x0601A165 RID: 106853
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkVoronoi2D_GetMTime_06(HandleRef pThis);

		/// <summary>
		/// Get the MTime of this object also considering the locator.
		/// </summary>
		// Token: 0x0601A166 RID: 106854 RVA: 0x002429AC File Offset: 0x00240BAC
		public override ulong GetMTime()
		{
			return vtkVoronoi2D.vtkVoronoi2D_GetMTime_06(base.GetCppThis());
		}

		// Token: 0x0601A167 RID: 106855
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVoronoi2D_GetMaximumNumberOfTileClips_07(HandleRef pThis);

		/// <summary>
		/// These methods are for debugging or instructional purposes. When the
		/// point of interest is specified (i.e., to a non-negative number) then the
		/// algorithm will only process this single point (whose id is the
		/// PointOfInterest). The maximum number of clips (the
		/// MaximumNumberOfTileClips) can be specified. If
		/// MaximumNumberOfTileClips=0, then the initial tile (single point within
		/// the bounding box) is produced; if =1 then the split with the closest
		/// point is produced; and so on. By default the PointOfInterest is set to
		/// (-1), and the number of clips is unlimited (i.e.,
		/// MaximumNumberOfTileClips=VTK_ID_MAX and therefore automatically limited
		/// by the algorithm).
		/// </summary>
		// Token: 0x0601A168 RID: 106856 RVA: 0x002429CC File Offset: 0x00240BCC
		public virtual long GetMaximumNumberOfTileClips()
		{
			return vtkVoronoi2D.vtkVoronoi2D_GetMaximumNumberOfTileClips_07(base.GetCppThis());
		}

		// Token: 0x0601A169 RID: 106857
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVoronoi2D_GetMaximumNumberOfTileClipsMaxValue_08(HandleRef pThis);

		/// <summary>
		/// These methods are for debugging or instructional purposes. When the
		/// point of interest is specified (i.e., to a non-negative number) then the
		/// algorithm will only process this single point (whose id is the
		/// PointOfInterest). The maximum number of clips (the
		/// MaximumNumberOfTileClips) can be specified. If
		/// MaximumNumberOfTileClips=0, then the initial tile (single point within
		/// the bounding box) is produced; if =1 then the split with the closest
		/// point is produced; and so on. By default the PointOfInterest is set to
		/// (-1), and the number of clips is unlimited (i.e.,
		/// MaximumNumberOfTileClips=VTK_ID_MAX and therefore automatically limited
		/// by the algorithm).
		/// </summary>
		// Token: 0x0601A16A RID: 106858 RVA: 0x002429EC File Offset: 0x00240BEC
		public virtual long GetMaximumNumberOfTileClipsMaxValue()
		{
			return vtkVoronoi2D.vtkVoronoi2D_GetMaximumNumberOfTileClipsMaxValue_08(base.GetCppThis());
		}

		// Token: 0x0601A16B RID: 106859
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVoronoi2D_GetMaximumNumberOfTileClipsMinValue_09(HandleRef pThis);

		/// <summary>
		/// These methods are for debugging or instructional purposes. When the
		/// point of interest is specified (i.e., to a non-negative number) then the
		/// algorithm will only process this single point (whose id is the
		/// PointOfInterest). The maximum number of clips (the
		/// MaximumNumberOfTileClips) can be specified. If
		/// MaximumNumberOfTileClips=0, then the initial tile (single point within
		/// the bounding box) is produced; if =1 then the split with the closest
		/// point is produced; and so on. By default the PointOfInterest is set to
		/// (-1), and the number of clips is unlimited (i.e.,
		/// MaximumNumberOfTileClips=VTK_ID_MAX and therefore automatically limited
		/// by the algorithm).
		/// </summary>
		// Token: 0x0601A16C RID: 106860 RVA: 0x00242A0C File Offset: 0x00240C0C
		public virtual long GetMaximumNumberOfTileClipsMinValue()
		{
			return vtkVoronoi2D.vtkVoronoi2D_GetMaximumNumberOfTileClipsMinValue_09(base.GetCppThis());
		}

		// Token: 0x0601A16D RID: 106861
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVoronoi2D_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601A16E RID: 106862 RVA: 0x00242A2C File Offset: 0x00240C2C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVoronoi2D.vtkVoronoi2D_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x0601A16F RID: 106863
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVoronoi2D_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601A170 RID: 106864 RVA: 0x00242A4C File Offset: 0x00240C4C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVoronoi2D.vtkVoronoi2D_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x0601A171 RID: 106865
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoronoi2D_GetNumberOfThreadsUsed_12(HandleRef pThis);

		/// <summary>
		///  Return the number of threads actually used during execution. This is
		///  valid only after algorithm execution.
		/// </summary>
		// Token: 0x0601A172 RID: 106866 RVA: 0x00242A68 File Offset: 0x00240C68
		public int GetNumberOfThreadsUsed()
		{
			return vtkVoronoi2D.vtkVoronoi2D_GetNumberOfThreadsUsed_12(base.GetCppThis());
		}

		// Token: 0x0601A173 RID: 106867
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVoronoi2D_GetPadding_13(HandleRef pThis);

		/// <summary>
		/// Specify a padding for the bounding box of the points. A &gt;0 padding is
		/// necessary in order to create valid Voronoi tiles on the boundary of the
		/// tessellation. The padding is specified as a fraction of the diagonal
		/// length of the bounding box of the points.
		/// </summary>
		// Token: 0x0601A174 RID: 106868 RVA: 0x00242A88 File Offset: 0x00240C88
		public virtual double GetPadding()
		{
			return vtkVoronoi2D.vtkVoronoi2D_GetPadding_13(base.GetCppThis());
		}

		// Token: 0x0601A175 RID: 106869
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVoronoi2D_GetPaddingMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Specify a padding for the bounding box of the points. A &gt;0 padding is
		/// necessary in order to create valid Voronoi tiles on the boundary of the
		/// tessellation. The padding is specified as a fraction of the diagonal
		/// length of the bounding box of the points.
		/// </summary>
		// Token: 0x0601A176 RID: 106870 RVA: 0x00242AA8 File Offset: 0x00240CA8
		public virtual double GetPaddingMaxValue()
		{
			return vtkVoronoi2D.vtkVoronoi2D_GetPaddingMaxValue_14(base.GetCppThis());
		}

		// Token: 0x0601A177 RID: 106871
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVoronoi2D_GetPaddingMinValue_15(HandleRef pThis);

		/// <summary>
		/// Specify a padding for the bounding box of the points. A &gt;0 padding is
		/// necessary in order to create valid Voronoi tiles on the boundary of the
		/// tessellation. The padding is specified as a fraction of the diagonal
		/// length of the bounding box of the points.
		/// </summary>
		// Token: 0x0601A178 RID: 106872 RVA: 0x00242AC8 File Offset: 0x00240CC8
		public virtual double GetPaddingMinValue()
		{
			return vtkVoronoi2D.vtkVoronoi2D_GetPaddingMinValue_15(base.GetCppThis());
		}

		// Token: 0x0601A179 RID: 106873
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVoronoi2D_GetPointOfInterest_16(HandleRef pThis);

		/// <summary>
		/// These methods are for debugging or instructional purposes. When the
		/// point of interest is specified (i.e., to a non-negative number) then the
		/// algorithm will only process this single point (whose id is the
		/// PointOfInterest). The maximum number of clips (the
		/// MaximumNumberOfTileClips) can be specified. If
		/// MaximumNumberOfTileClips=0, then the initial tile (single point within
		/// the bounding box) is produced; if =1 then the split with the closest
		/// point is produced; and so on. By default the PointOfInterest is set to
		/// (-1), and the number of clips is unlimited (i.e.,
		/// MaximumNumberOfTileClips=VTK_ID_MAX and therefore automatically limited
		/// by the algorithm).
		/// </summary>
		// Token: 0x0601A17A RID: 106874 RVA: 0x00242AE8 File Offset: 0x00240CE8
		public virtual long GetPointOfInterest()
		{
			return vtkVoronoi2D.vtkVoronoi2D_GetPointOfInterest_16(base.GetCppThis());
		}

		// Token: 0x0601A17B RID: 106875
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVoronoi2D_GetPointOfInterestMaxValue_17(HandleRef pThis);

		/// <summary>
		/// These methods are for debugging or instructional purposes. When the
		/// point of interest is specified (i.e., to a non-negative number) then the
		/// algorithm will only process this single point (whose id is the
		/// PointOfInterest). The maximum number of clips (the
		/// MaximumNumberOfTileClips) can be specified. If
		/// MaximumNumberOfTileClips=0, then the initial tile (single point within
		/// the bounding box) is produced; if =1 then the split with the closest
		/// point is produced; and so on. By default the PointOfInterest is set to
		/// (-1), and the number of clips is unlimited (i.e.,
		/// MaximumNumberOfTileClips=VTK_ID_MAX and therefore automatically limited
		/// by the algorithm).
		/// </summary>
		// Token: 0x0601A17C RID: 106876 RVA: 0x00242B08 File Offset: 0x00240D08
		public virtual long GetPointOfInterestMaxValue()
		{
			return vtkVoronoi2D.vtkVoronoi2D_GetPointOfInterestMaxValue_17(base.GetCppThis());
		}

		// Token: 0x0601A17D RID: 106877
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVoronoi2D_GetPointOfInterestMinValue_18(HandleRef pThis);

		/// <summary>
		/// These methods are for debugging or instructional purposes. When the
		/// point of interest is specified (i.e., to a non-negative number) then the
		/// algorithm will only process this single point (whose id is the
		/// PointOfInterest). The maximum number of clips (the
		/// MaximumNumberOfTileClips) can be specified. If
		/// MaximumNumberOfTileClips=0, then the initial tile (single point within
		/// the bounding box) is produced; if =1 then the split with the closest
		/// point is produced; and so on. By default the PointOfInterest is set to
		/// (-1), and the number of clips is unlimited (i.e.,
		/// MaximumNumberOfTileClips=VTK_ID_MAX and therefore automatically limited
		/// by the algorithm).
		/// </summary>
		// Token: 0x0601A17E RID: 106878 RVA: 0x00242B28 File Offset: 0x00240D28
		public virtual long GetPointOfInterestMinValue()
		{
			return vtkVoronoi2D.vtkVoronoi2D_GetPointOfInterestMinValue_18(base.GetCppThis());
		}

		// Token: 0x0601A17F RID: 106879
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoronoi2D_GetProjectionPlaneMode_19(HandleRef pThis);

		/// <summary>
		/// Define the method to project the input 3D points into a 2D plane for
		/// tessellation. When the VTK_XY_PLANE is set, the z-coordinate is simply
		/// ignored. When VTK_SET_TRANSFORM_PLANE is set, then a transform must be
		/// supplied and the points are transformed using it. Finally, if
		/// VTK_BEST_FITTING_PLANE is set, then the filter computes a best fitting
		/// plane and projects the points onto it.
		/// </summary>
		// Token: 0x0601A180 RID: 106880 RVA: 0x00242B48 File Offset: 0x00240D48
		public virtual int GetProjectionPlaneMode()
		{
			return vtkVoronoi2D.vtkVoronoi2D_GetProjectionPlaneMode_19(base.GetCppThis());
		}

		// Token: 0x0601A181 RID: 106881
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoronoi2D_GetProjectionPlaneModeMaxValue_20(HandleRef pThis);

		/// <summary>
		/// Define the method to project the input 3D points into a 2D plane for
		/// tessellation. When the VTK_XY_PLANE is set, the z-coordinate is simply
		/// ignored. When VTK_SET_TRANSFORM_PLANE is set, then a transform must be
		/// supplied and the points are transformed using it. Finally, if
		/// VTK_BEST_FITTING_PLANE is set, then the filter computes a best fitting
		/// plane and projects the points onto it.
		/// </summary>
		// Token: 0x0601A182 RID: 106882 RVA: 0x00242B68 File Offset: 0x00240D68
		public virtual int GetProjectionPlaneModeMaxValue()
		{
			return vtkVoronoi2D.vtkVoronoi2D_GetProjectionPlaneModeMaxValue_20(base.GetCppThis());
		}

		// Token: 0x0601A183 RID: 106883
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoronoi2D_GetProjectionPlaneModeMinValue_21(HandleRef pThis);

		/// <summary>
		/// Define the method to project the input 3D points into a 2D plane for
		/// tessellation. When the VTK_XY_PLANE is set, the z-coordinate is simply
		/// ignored. When VTK_SET_TRANSFORM_PLANE is set, then a transform must be
		/// supplied and the points are transformed using it. Finally, if
		/// VTK_BEST_FITTING_PLANE is set, then the filter computes a best fitting
		/// plane and projects the points onto it.
		/// </summary>
		// Token: 0x0601A184 RID: 106884 RVA: 0x00242B88 File Offset: 0x00240D88
		public virtual int GetProjectionPlaneModeMinValue()
		{
			return vtkVoronoi2D.vtkVoronoi2D_GetProjectionPlaneModeMinValue_21(base.GetCppThis());
		}

		// Token: 0x0601A185 RID: 106885
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoronoi2D_GetSpheres_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the Voronoi flower (a collection of spheres) for the point of
		/// interest in the form of a vtkSpheres implicit function. This is valid
		/// only if GenerateVoronoiFlower and the PointOfInterest are set, and after
		/// the filter executes. Typically this is used for debugging or educational
		/// purposes.
		/// </summary>
		// Token: 0x0601A186 RID: 106886 RVA: 0x00242BA8 File Offset: 0x00240DA8
		public virtual vtkSpheres GetSpheres()
		{
			vtkSpheres vtkSpheres = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVoronoi2D.vtkVoronoi2D_GetSpheres_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSpheres = (vtkSpheres)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSpheres.Register(null);
				}
			}
			return vtkSpheres;
		}

		// Token: 0x0601A187 RID: 106887
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoronoi2D_GetTransform_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get the transform which is applied to points to generate a 2D
		/// problem.  This maps a 3D dataset into a 2D dataset where triangulation
		/// can be done on the XY plane.  The points are then tessellated and the
		/// topology of tessellation are used as the output topology.  The output
		/// points are the original (untransformed) points.  The transform can be
		/// any subclass of vtkAbstractTransform (thus it does not need to be a
		/// linear or invertible transform).
		/// </summary>
		// Token: 0x0601A188 RID: 106888 RVA: 0x00242C18 File Offset: 0x00240E18
		public virtual vtkAbstractTransform GetTransform()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVoronoi2D.vtkVoronoi2D_GetTransform_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractTransform = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractTransform.Register(null);
				}
			}
			return vtkAbstractTransform;
		}

		// Token: 0x0601A189 RID: 106889
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoronoi2D_IsA_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601A18A RID: 106890 RVA: 0x00242C88 File Offset: 0x00240E88
		public override int IsA(string type)
		{
			return vtkVoronoi2D.vtkVoronoi2D_IsA_24(base.GetCppThis(), type);
		}

		// Token: 0x0601A18B RID: 106891
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoronoi2D_IsTypeOf_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601A18C RID: 106892 RVA: 0x00242CA8 File Offset: 0x00240EA8
		public new static int IsTypeOf(string type)
		{
			return vtkVoronoi2D.vtkVoronoi2D_IsTypeOf_25(type);
		}

		// Token: 0x0601A18D RID: 106893
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoronoi2D_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601A18E RID: 106894 RVA: 0x00242CC4 File Offset: 0x00240EC4
		public new vtkVoronoi2D NewInstance()
		{
			vtkVoronoi2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVoronoi2D.vtkVoronoi2D_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVoronoi2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A18F RID: 106895
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoronoi2D_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601A190 RID: 106896 RVA: 0x00242D20 File Offset: 0x00240F20
		public new static vtkVoronoi2D SafeDownCast(vtkObjectBase o)
		{
			vtkVoronoi2D vtkVoronoi2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVoronoi2D.vtkVoronoi2D_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVoronoi2D = (vtkVoronoi2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVoronoi2D.Register(null);
				}
			}
			return vtkVoronoi2D;
		}

		// Token: 0x0601A191 RID: 106897
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoronoi2D_SetGenerateScalars_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate whether to create a scalar array as part of the output. No
		/// scalars; point ids, or execution thread ids may be output. By default no
		/// scalars are generated.
		/// </summary>
		// Token: 0x0601A192 RID: 106898 RVA: 0x00242D9F File Offset: 0x00240F9F
		public virtual void SetGenerateScalars(int _arg)
		{
			vtkVoronoi2D.vtkVoronoi2D_SetGenerateScalars_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A193 RID: 106899
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoronoi2D_SetGenerateScalarsToNone_30(HandleRef pThis);

		/// <summary>
		/// Indicate whether to create a scalar array as part of the output. No
		/// scalars; point ids, or execution thread ids may be output. By default no
		/// scalars are generated.
		/// </summary>
		// Token: 0x0601A194 RID: 106900 RVA: 0x00242DAF File Offset: 0x00240FAF
		public void SetGenerateScalarsToNone()
		{
			vtkVoronoi2D.vtkVoronoi2D_SetGenerateScalarsToNone_30(base.GetCppThis());
		}

		// Token: 0x0601A195 RID: 106901
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoronoi2D_SetGenerateScalarsToPointIds_31(HandleRef pThis);

		/// <summary>
		/// Indicate whether to create a scalar array as part of the output. No
		/// scalars; point ids, or execution thread ids may be output. By default no
		/// scalars are generated.
		/// </summary>
		// Token: 0x0601A196 RID: 106902 RVA: 0x00242DBE File Offset: 0x00240FBE
		public void SetGenerateScalarsToPointIds()
		{
			vtkVoronoi2D.vtkVoronoi2D_SetGenerateScalarsToPointIds_31(base.GetCppThis());
		}

		// Token: 0x0601A197 RID: 106903
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoronoi2D_SetGenerateScalarsToThreadIds_32(HandleRef pThis);

		/// <summary>
		/// Indicate whether to create a scalar array as part of the output. No
		/// scalars; point ids, or execution thread ids may be output. By default no
		/// scalars are generated.
		/// </summary>
		// Token: 0x0601A198 RID: 106904 RVA: 0x00242DCD File Offset: 0x00240FCD
		public void SetGenerateScalarsToThreadIds()
		{
			vtkVoronoi2D.vtkVoronoi2D_SetGenerateScalarsToThreadIds_32(base.GetCppThis());
		}

		// Token: 0x0601A199 RID: 106905
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoronoi2D_SetGenerateVoronoiFlower_33(HandleRef pThis, int _arg);

		/// <summary>
		/// These methods are for debugging or instructional purposes. If
		/// GenerateVoronoiFlower is on, and the PointOfIntersect is specified, then
		/// second and third (optional) outputs are populated which contains a
		/// representation of the Voronoi flower error metric (second output) and
		/// the single Voronoi tile (corresponding to PointOfInterest) with point
		/// scalar values indicating the radii of the Voronoi Flower petals (i.e.,
		/// circles contributing to the error metric).
		/// </summary>
		// Token: 0x0601A19A RID: 106906 RVA: 0x00242DDC File Offset: 0x00240FDC
		public virtual void SetGenerateVoronoiFlower(int _arg)
		{
			vtkVoronoi2D.vtkVoronoi2D_SetGenerateVoronoiFlower_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A19B RID: 106907
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoronoi2D_SetMaximumNumberOfTileClips_34(HandleRef pThis, long _arg);

		/// <summary>
		/// These methods are for debugging or instructional purposes. When the
		/// point of interest is specified (i.e., to a non-negative number) then the
		/// algorithm will only process this single point (whose id is the
		/// PointOfInterest). The maximum number of clips (the
		/// MaximumNumberOfTileClips) can be specified. If
		/// MaximumNumberOfTileClips=0, then the initial tile (single point within
		/// the bounding box) is produced; if =1 then the split with the closest
		/// point is produced; and so on. By default the PointOfInterest is set to
		/// (-1), and the number of clips is unlimited (i.e.,
		/// MaximumNumberOfTileClips=VTK_ID_MAX and therefore automatically limited
		/// by the algorithm).
		/// </summary>
		// Token: 0x0601A19C RID: 106908 RVA: 0x00242DEC File Offset: 0x00240FEC
		public virtual void SetMaximumNumberOfTileClips(long _arg)
		{
			vtkVoronoi2D.vtkVoronoi2D_SetMaximumNumberOfTileClips_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A19D RID: 106909
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoronoi2D_SetPadding_35(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify a padding for the bounding box of the points. A &gt;0 padding is
		/// necessary in order to create valid Voronoi tiles on the boundary of the
		/// tessellation. The padding is specified as a fraction of the diagonal
		/// length of the bounding box of the points.
		/// </summary>
		// Token: 0x0601A19E RID: 106910 RVA: 0x00242DFC File Offset: 0x00240FFC
		public virtual void SetPadding(double _arg)
		{
			vtkVoronoi2D.vtkVoronoi2D_SetPadding_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A19F RID: 106911
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoronoi2D_SetPointOfInterest_36(HandleRef pThis, long _arg);

		/// <summary>
		/// These methods are for debugging or instructional purposes. When the
		/// point of interest is specified (i.e., to a non-negative number) then the
		/// algorithm will only process this single point (whose id is the
		/// PointOfInterest). The maximum number of clips (the
		/// MaximumNumberOfTileClips) can be specified. If
		/// MaximumNumberOfTileClips=0, then the initial tile (single point within
		/// the bounding box) is produced; if =1 then the split with the closest
		/// point is produced; and so on. By default the PointOfInterest is set to
		/// (-1), and the number of clips is unlimited (i.e.,
		/// MaximumNumberOfTileClips=VTK_ID_MAX and therefore automatically limited
		/// by the algorithm).
		/// </summary>
		// Token: 0x0601A1A0 RID: 106912 RVA: 0x00242E0C File Offset: 0x0024100C
		public virtual void SetPointOfInterest(long _arg)
		{
			vtkVoronoi2D.vtkVoronoi2D_SetPointOfInterest_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A1A1 RID: 106913
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoronoi2D_SetProjectionPlaneMode_37(HandleRef pThis, int _arg);

		/// <summary>
		/// Define the method to project the input 3D points into a 2D plane for
		/// tessellation. When the VTK_XY_PLANE is set, the z-coordinate is simply
		/// ignored. When VTK_SET_TRANSFORM_PLANE is set, then a transform must be
		/// supplied and the points are transformed using it. Finally, if
		/// VTK_BEST_FITTING_PLANE is set, then the filter computes a best fitting
		/// plane and projects the points onto it.
		/// </summary>
		// Token: 0x0601A1A2 RID: 106914 RVA: 0x00242E1C File Offset: 0x0024101C
		public virtual void SetProjectionPlaneMode(int _arg)
		{
			vtkVoronoi2D.vtkVoronoi2D_SetProjectionPlaneMode_37(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A1A3 RID: 106915
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoronoi2D_SetProjectionPlaneModeToBestFittingPlane_38(HandleRef pThis);

		/// <summary>
		/// Define the method to project the input 3D points into a 2D plane for
		/// tessellation. When the VTK_XY_PLANE is set, the z-coordinate is simply
		/// ignored. When VTK_SET_TRANSFORM_PLANE is set, then a transform must be
		/// supplied and the points are transformed using it. Finally, if
		/// VTK_BEST_FITTING_PLANE is set, then the filter computes a best fitting
		/// plane and projects the points onto it.
		/// </summary>
		// Token: 0x0601A1A4 RID: 106916 RVA: 0x00242E2C File Offset: 0x0024102C
		public void SetProjectionPlaneModeToBestFittingPlane()
		{
			vtkVoronoi2D.vtkVoronoi2D_SetProjectionPlaneModeToBestFittingPlane_38(base.GetCppThis());
		}

		// Token: 0x0601A1A5 RID: 106917
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoronoi2D_SetProjectionPlaneModeToSpecifiedTransformPlane_39(HandleRef pThis);

		/// <summary>
		/// Define the method to project the input 3D points into a 2D plane for
		/// tessellation. When the VTK_XY_PLANE is set, the z-coordinate is simply
		/// ignored. When VTK_SET_TRANSFORM_PLANE is set, then a transform must be
		/// supplied and the points are transformed using it. Finally, if
		/// VTK_BEST_FITTING_PLANE is set, then the filter computes a best fitting
		/// plane and projects the points onto it.
		/// </summary>
		// Token: 0x0601A1A6 RID: 106918 RVA: 0x00242E3B File Offset: 0x0024103B
		public void SetProjectionPlaneModeToSpecifiedTransformPlane()
		{
			vtkVoronoi2D.vtkVoronoi2D_SetProjectionPlaneModeToSpecifiedTransformPlane_39(base.GetCppThis());
		}

		// Token: 0x0601A1A7 RID: 106919
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoronoi2D_SetProjectionPlaneModeToXYPlane_40(HandleRef pThis);

		/// <summary>
		/// Define the method to project the input 3D points into a 2D plane for
		/// tessellation. When the VTK_XY_PLANE is set, the z-coordinate is simply
		/// ignored. When VTK_SET_TRANSFORM_PLANE is set, then a transform must be
		/// supplied and the points are transformed using it. Finally, if
		/// VTK_BEST_FITTING_PLANE is set, then the filter computes a best fitting
		/// plane and projects the points onto it.
		/// </summary>
		// Token: 0x0601A1A8 RID: 106920 RVA: 0x00242E4A File Offset: 0x0024104A
		public void SetProjectionPlaneModeToXYPlane()
		{
			vtkVoronoi2D.vtkVoronoi2D_SetProjectionPlaneModeToXYPlane_40(base.GetCppThis());
		}

		// Token: 0x0601A1A9 RID: 106921
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoronoi2D_SetTransform_41(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set / get the transform which is applied to points to generate a 2D
		/// problem.  This maps a 3D dataset into a 2D dataset where triangulation
		/// can be done on the XY plane.  The points are then tessellated and the
		/// topology of tessellation are used as the output topology.  The output
		/// points are the original (untransformed) points.  The transform can be
		/// any subclass of vtkAbstractTransform (thus it does not need to be a
		/// linear or invertible transform).
		/// </summary>
		// Token: 0x0601A1AA RID: 106922 RVA: 0x00242E5C File Offset: 0x0024105C
		public virtual void SetTransform(vtkAbstractTransform arg0)
		{
			vtkVoronoi2D.vtkVoronoi2D_SetTransform_41(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C4B RID: 7243
		public new const string MRFullTypeName = "Kitware.VTK.vtkVoronoi2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C4C RID: 7244
		public new static readonly string MRClassNameKey = "class vtkVoronoi2D";

		/// <summary>
		/// Specify a padding for the bounding box of the points. A &gt;0 padding is
		/// necessary in order to create valid Voronoi tiles on the boundary of the
		/// tessellation. The padding is specified as a fraction of the diagonal
		/// length of the bounding box of the points.
		/// </summary>
		// Token: 0x020009C2 RID: 2498
		public enum GenerateScalarsStrategy
		{
			/// <summary>enum member</summary>
			// Token: 0x04001C4E RID: 7246
			NONE,
			/// <summary>enum member</summary>
			// Token: 0x04001C4F RID: 7247
			POINT_IDS,
			/// <summary>enum member</summary>
			// Token: 0x04001C50 RID: 7248
			THREAD_IDS
		}

		/// <summary>
		/// Set / get the transform which is applied to points to generate a 2D
		/// problem.  This maps a 3D dataset into a 2D dataset where triangulation
		/// can be done on the XY plane.  The points are then tessellated and the
		/// topology of tessellation are used as the output topology.  The output
		/// points are the original (untransformed) points.  The transform can be
		/// any subclass of vtkAbstractTransform (thus it does not need to be a
		/// linear or invertible transform).
		/// </summary>
		// Token: 0x020009C3 RID: 2499
		public enum ProjectionPlaneStrategy
		{
			/// <summary>enum member</summary>
			// Token: 0x04001C52 RID: 7250
			BEST_FITTING_PLANE = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001C53 RID: 7251
			SPECIFIED_TRANSFORM_PLANE = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001C54 RID: 7252
			XY_PLANE = 0
		}
	}
}
