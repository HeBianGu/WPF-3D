using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOrderedTriangulator
	/// </summary>
	/// <remarks>
	///    helper class to generate triangulations
	///
	/// This class is used to generate unique triangulations of points. The
	/// uniqueness of the triangulation is controlled by the id of the inserted
	/// points in combination with a Delaunay criterion. The class is designed to
	/// be as fast as possible (since the algorithm can be slow) and uses block
	/// memory allocations to support rapid triangulation generation. Also, the
	/// assumption behind the class is that a maximum of hundreds of points are to
	/// be triangulated. If you desire more robust triangulation methods use
	/// vtkPolygon::Triangulate(), vtkDelaunay2D, or vtkDelaunay3D.
	///
	/// @par Background:
	/// This work is documented in the technical paper: W.J. Schroeder, B. Geveci,
	/// M. Malaterre. Compatible Triangulations of Spatial Decompositions. In
	/// Proceedings of Visualization 2004, IEEE Press October 2004.
	///
	/// @par Background:
	/// Delaunay triangulations are unique assuming a random distribution of input
	/// points. The 3D Delaunay criterion is as follows: the circumsphere of each
	/// tetrahedron contains no other points of the triangulation except for the
	/// four points defining the tetrahedron.  In application this property is
	/// hard to satisfy because objects like cubes are defined by eight points all
	/// sharing the same circumsphere (center and radius); hence the Delaunay
	/// triangulation is not unique.  These so-called degenerate situations are
	/// typically resolved by arbitrary selecting a triangulation. This code does
	/// something different: it resolves degenerate triangulations by modifying
	/// the "InCircumsphere" method to use a slightly smaller radius. Hence,
	/// degenerate points are always considered "out" of the circumsphere. This,
	/// in combination with an ordering (based on id) of the input points,
	/// guarantees a unique triangulation.
	///
	/// @par Background:
	/// There is another related characteristic of Delaunay triangulations. Given
	/// a N-dimensional Delaunay triangulation, points laying on a (N-1) dimensional
	/// plane also form a (N-1) Delaunay triangulation. This means for example,
	/// that if a 3D cell is defined by a set of (2D) planar faces, then the
	/// face triangulations are Delaunay. Combining this with the method to
	/// generate unique triangulations described previously, the triangulations
	/// on the face are guaranteed unique. This fact can be used to triangulate
	/// 3D objects in such a way to guarantee compatible face triangulations.
	/// This is a very useful fact for parallel processing, or performing
	/// operations like clipping that require compatible triangulations across
	/// 3D cell faces. (See vtkClipVolume for an example.)
	///
	/// @par Background:
	/// A special feature of this class is that it can generate triangulation
	/// templates on the fly. If template triangulation is enabled, then the
	/// ordered triangulator will first triangulate the cell using the slower
	/// ordered Delaunay approach, and then store the result as a template.
	/// Later, if the same cell type and cell configuration is encountered,
	/// then the template is reused which greatly speeds the triangulation.
	///
	/// @warning
	/// Duplicate vertices will be ignored, i.e., if two points have the same
	/// coordinates the second one is discarded. The implications are that the
	/// user of this class must prevent duplicate points. Because the precision
	/// of this algorithm is double, it's also a good idea to merge points
	/// that are within some epsilon of one another.
	///
	/// @warning
	/// The triangulation is performed using the parametric coordinates of the
	/// inserted points. Therefore the bounds (see InitTriangulation()) should
	/// represent the range of the parametric coordinates of the inserted points.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDelaunay2D vtkDelaunay3D vtkPolygon
	/// </seealso>
	// Token: 0x02000A8C RID: 2700
	public class vtkOrderedTriangulator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C4A8 RID: 115880 RVA: 0x0027BB53 File Offset: 0x00279D53
		static vtkOrderedTriangulator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOrderedTriangulator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOrderedTriangulator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C4A9 RID: 115881 RVA: 0x0027BB7B File Offset: 0x00279D7B
		public vtkOrderedTriangulator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C4AA RID: 115882
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrderedTriangulator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object.
		/// </summary>
		// Token: 0x0601C4AB RID: 115883 RVA: 0x0027BB8C File Offset: 0x00279D8C
		public new static vtkOrderedTriangulator New()
		{
			vtkOrderedTriangulator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrderedTriangulator.vtkOrderedTriangulator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOrderedTriangulator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object.
		/// </summary>
		// Token: 0x0601C4AC RID: 115884 RVA: 0x0027BBE0 File Offset: 0x00279DE0
		public vtkOrderedTriangulator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOrderedTriangulator.vtkOrderedTriangulator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C4AD RID: 115885 RVA: 0x0027BC24 File Offset: 0x00279E24
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C4AE RID: 115886
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrderedTriangulator_AddTetras_01(HandleRef pThis, int classification, HandleRef ugrid);

		/// <summary>
		/// Add the tetras to the unstructured grid provided. The unstructured
		/// grid is assumed to have been initialized (with Allocate()) and
		/// points set (with SetPoints()). The tetrahdera added are of the type
		/// specified (0=inside,1=outside,2=all). Inside tetrahedron are
		/// those whose points are classified "inside" or on the "boundary."
		/// Outside tetrahedron have at least one point classified "outside."
		/// The method returns the number of tetrahedrahedron of the type
		/// requested.
		/// </summary>
		// Token: 0x0601C4AF RID: 115887 RVA: 0x0027BC30 File Offset: 0x00279E30
		public long AddTetras(int classification, vtkUnstructuredGrid ugrid)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_AddTetras_01(base.GetCppThis(), classification, (ugrid == null) ? default(HandleRef) : ugrid.GetCppThis());
		}

		// Token: 0x0601C4B0 RID: 115888
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrderedTriangulator_AddTetras_02(HandleRef pThis, int classification, HandleRef connectivity);

		/// <summary>
		/// Add the tetrahedra classified (0=inside,1=outside) to the connectivity
		/// list provided. Inside tetrahedron are those whose points are all
		/// classified "inside." Outside tetrahedron have at least one point
		/// classified "outside." The method returns the number of tetrahedron
		/// of the type requested.
		/// </summary>
		// Token: 0x0601C4B1 RID: 115889 RVA: 0x0027BC68 File Offset: 0x00279E68
		public long AddTetras(int classification, vtkCellArray connectivity)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_AddTetras_02(base.GetCppThis(), classification, (connectivity == null) ? default(HandleRef) : connectivity.GetCppThis());
		}

		// Token: 0x0601C4B2 RID: 115890
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrderedTriangulator_AddTetras_03(HandleRef pThis, int classification, HandleRef locator, HandleRef outConnectivity, HandleRef inPD, HandleRef outPD, HandleRef inCD, long cellId, HandleRef outCD);

		/// <summary>
		/// Assuming that all the inserted points come from a cell `cellId' to
		/// triangulate, get the tetrahedra in outConnectivity, the points in locator
		/// and copy point data and cell data. Return the number of added tetras.
		/// \pre locator_exists: locator!=0
		/// \pre outConnectivity: outConnectivity!=0
		/// \pre inPD_exists: inPD!=0
		/// \pre outPD_exists:  outPD!=0
		/// \pre inCD_exists: inCD!=0
		/// \pre outCD_exists: outCD!=0
		/// </summary>
		// Token: 0x0601C4B3 RID: 115891 RVA: 0x0027BCA0 File Offset: 0x00279EA0
		public long AddTetras(int classification, vtkIncrementalPointLocator locator, vtkCellArray outConnectivity, vtkPointData inPD, vtkPointData outPD, vtkCellData inCD, long cellId, vtkCellData outCD)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_AddTetras_03(base.GetCppThis(), classification, (locator == null) ? default(HandleRef) : locator.GetCppThis(), (outConnectivity == null) ? default(HandleRef) : outConnectivity.GetCppThis(), (inPD == null) ? default(HandleRef) : inPD.GetCppThis(), (outPD == null) ? default(HandleRef) : outPD.GetCppThis(), (inCD == null) ? default(HandleRef) : inCD.GetCppThis(), cellId, (outCD == null) ? default(HandleRef) : outCD.GetCppThis());
		}

		// Token: 0x0601C4B4 RID: 115892
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrderedTriangulator_AddTetras_04(HandleRef pThis, int classification, HandleRef ptIds, HandleRef pts);

		/// <summary>
		/// Add the tetrahedra classified (0=inside,1=outside) to the list
		/// of ids and coordinates provided. These assume that the first four points
		/// form a tetrahedron, the next four the next, and so on.
		/// </summary>
		// Token: 0x0601C4B5 RID: 115893 RVA: 0x0027BD48 File Offset: 0x00279F48
		public long AddTetras(int classification, vtkIdList ptIds, vtkPoints pts)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_AddTetras_04(base.GetCppThis(), classification, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601C4B6 RID: 115894
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrderedTriangulator_AddTetras_05(HandleRef pThis, int classification, HandleRef ptIds);

		/// <summary>
		/// Add the tetrahedra classified (0=inside,1=outside) to the list
		/// of ids. These assume that the first four points
		/// form a tetrahedron, the next four the next, and so on.
		/// </summary>
		// Token: 0x0601C4B7 RID: 115895 RVA: 0x0027BD94 File Offset: 0x00279F94
		public long AddTetras(int classification, vtkIdList ptIds)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_AddTetras_05(base.GetCppThis(), classification, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		// Token: 0x0601C4B8 RID: 115896
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrderedTriangulator_AddTriangles_06(HandleRef pThis, HandleRef connectivity);

		/// <summary>
		/// Add the triangle faces classified (2=boundary) to the connectivity
		/// list provided. The method returns the number of triangles.
		/// </summary>
		// Token: 0x0601C4B9 RID: 115897 RVA: 0x0027BDCC File Offset: 0x00279FCC
		public long AddTriangles(vtkCellArray connectivity)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_AddTriangles_06(base.GetCppThis(), (connectivity == null) ? default(HandleRef) : connectivity.GetCppThis());
		}

		// Token: 0x0601C4BA RID: 115898
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrderedTriangulator_AddTriangles_07(HandleRef pThis, long id, HandleRef connectivity);

		/// <summary>
		/// Add the triangle faces classified (2=boundary) and attached to the
		/// specified point id to the connectivity list provided. (The id is the
		/// same as that specified in InsertPoint().)
		/// </summary>
		// Token: 0x0601C4BB RID: 115899 RVA: 0x0027BE00 File Offset: 0x0027A000
		public long AddTriangles(long id, vtkCellArray connectivity)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_AddTriangles_07(base.GetCppThis(), id, (connectivity == null) ? default(HandleRef) : connectivity.GetCppThis());
		}

		// Token: 0x0601C4BC RID: 115900
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrderedTriangulator_GetNextTetra_08(HandleRef pThis, int classification, HandleRef tet, HandleRef cellScalars, HandleRef tetScalars);

		/// <summary>
		/// Methods to get one tetra at a time. Start with InitTetraTraversal()
		/// and then invoke GetNextTetra() until the method returns 0.
		/// cellScalars are point-centered scalars on the original cell.
		/// tetScalars are point-centered scalars on the tetra: the values will be
		/// copied from cellScalars.
		/// \pre tet_exists: tet!=0
		/// \pre cellScalars_exists: cellScalars!=0
		/// \pre tetScalars_exists: tetScalars!=0
		/// \pre tetScalars_valid_size: tetScalars-&gt;GetNumberOfTuples()==4
		/// </summary>
		// Token: 0x0601C4BD RID: 115901 RVA: 0x0027BE38 File Offset: 0x0027A038
		public int GetNextTetra(int classification, vtkTetra tet, vtkDataArray cellScalars, vtkDoubleArray tetScalars)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_GetNextTetra_08(base.GetCppThis(), classification, (tet == null) ? default(HandleRef) : tet.GetCppThis(), (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (tetScalars == null) ? default(HandleRef) : tetScalars.GetCppThis());
		}

		// Token: 0x0601C4BE RID: 115902
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrderedTriangulator_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C4BF RID: 115903 RVA: 0x0027BE9C File Offset: 0x0027A09C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x0601C4C0 RID: 115904
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrderedTriangulator_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C4C1 RID: 115905 RVA: 0x0027BEBC File Offset: 0x0027A0BC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x0601C4C2 RID: 115906
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrderedTriangulator_GetNumberOfPoints_11(HandleRef pThis);

		/// <summary>
		/// Return the number of inserted points.
		/// </summary>
		// Token: 0x0601C4C3 RID: 115907 RVA: 0x0027BED8 File Offset: 0x0027A0D8
		public virtual int GetNumberOfPoints()
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_GetNumberOfPoints_11(base.GetCppThis());
		}

		// Token: 0x0601C4C4 RID: 115908
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrderedTriangulator_GetPointId_12(HandleRef pThis, long internalId);

		/// <summary>
		/// Return the Id of point `internalId'. This id is the one passed in
		/// argument of InsertPoint.
		/// It assumes that the point has already been inserted.
		/// The method should be invoked prior to the Triangulate method.
		/// \pre valid_range: internalId&gt;=0 &amp;&amp; internalId&lt;this-&gt;GetNumberOfPoints()
		/// </summary>
		// Token: 0x0601C4C5 RID: 115909 RVA: 0x0027BEF8 File Offset: 0x0027A0F8
		public long GetPointId(long internalId)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_GetPointId_12(base.GetCppThis(), internalId);
		}

		// Token: 0x0601C4C6 RID: 115910
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrderedTriangulator_GetPointLocation_13(HandleRef pThis, long internalId);

		/// <summary>
		/// Return the global coordinates of point `internalId'.
		/// It assumes that the point has already been inserted.
		/// The method should be invoked prior to the Triangulate method.
		/// \pre valid_range: internalId&gt;=0 &amp;&amp; internalId&lt;this-&gt;GetNumberOfPoints()
		/// </summary>
		// Token: 0x0601C4C7 RID: 115911 RVA: 0x0027BF18 File Offset: 0x0027A118
		public IntPtr GetPointLocation(long internalId)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_GetPointLocation_13(base.GetCppThis(), internalId);
		}

		// Token: 0x0601C4C8 RID: 115912
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrderedTriangulator_GetPointPosition_14(HandleRef pThis, long internalId);

		/// <summary>
		/// Return the parametric coordinates of point `internalId'.
		/// It assumes that the point has already been inserted.
		/// The method should be invoked prior to the Triangulate method.
		/// \pre valid_range: internalId&gt;=0 &amp;&amp; internalId&lt;this-&gt;GetNumberOfPoints()
		/// </summary>
		// Token: 0x0601C4C9 RID: 115913 RVA: 0x0027BF38 File Offset: 0x0027A138
		public IntPtr GetPointPosition(long internalId)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_GetPointPosition_14(base.GetCppThis(), internalId);
		}

		// Token: 0x0601C4CA RID: 115914
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrderedTriangulator_GetPreSorted_15(HandleRef pThis);

		/// <summary>
		/// Boolean indicates whether the points have been pre-sorted. If
		/// pre-sorted is enabled, the points are not sorted on point id.
		/// By default, presorted is off. (The point id is defined in
		/// InsertPoint().)
		/// </summary>
		// Token: 0x0601C4CB RID: 115915 RVA: 0x0027BF58 File Offset: 0x0027A158
		public virtual int GetPreSorted()
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_GetPreSorted_15(base.GetCppThis());
		}

		// Token: 0x0601C4CC RID: 115916
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrderedTriangulator_GetTetras_16(HandleRef pThis, int classification, HandleRef ugrid);

		/// <summary>
		/// Initialize and add the tetras and points from the triangulation to the
		/// unstructured grid provided.  New points are created and the mesh is
		/// allocated. (This method differs from AddTetras() in that it inserts
		/// points and cells; AddTetras only adds the tetra cells.) The tetrahdera
		/// added are of the type specified (0=inside,1=outside,2=all). Inside
		/// tetrahedron are those whose points are classified "inside" or on the
		/// "boundary."  Outside tetrahedron have at least one point classified
		/// "outside."  The method returns the number of tetrahedrahedron of the
		/// type requested.
		/// </summary>
		// Token: 0x0601C4CD RID: 115917 RVA: 0x0027BF78 File Offset: 0x0027A178
		public long GetTetras(int classification, vtkUnstructuredGrid ugrid)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_GetTetras_16(base.GetCppThis(), classification, (ugrid == null) ? default(HandleRef) : ugrid.GetCppThis());
		}

		// Token: 0x0601C4CE RID: 115918
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrderedTriangulator_GetUseTemplates_17(HandleRef pThis);

		/// <summary>
		/// If this flag is set, then the ordered triangulator will create
		/// and use templates for the triangulation. To use templates, the
		/// TemplateTriangulate() method should be called when appropriate.
		/// (Note: the TemplateTriangulate() method works for complete
		/// (interior) cells without extra points due to intersection, etc.)
		/// </summary>
		// Token: 0x0601C4CF RID: 115919 RVA: 0x0027BFB0 File Offset: 0x0027A1B0
		public virtual int GetUseTemplates()
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_GetUseTemplates_17(base.GetCppThis());
		}

		// Token: 0x0601C4D0 RID: 115920
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrderedTriangulator_GetUseTwoSortIds_18(HandleRef pThis);

		/// <summary>
		/// Tells the triangulator that a second sort id is provided
		/// for each point and should also be considered when sorting.
		/// </summary>
		// Token: 0x0601C4D1 RID: 115921 RVA: 0x0027BFD0 File Offset: 0x0027A1D0
		public virtual int GetUseTwoSortIds()
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_GetUseTwoSortIds_18(base.GetCppThis());
		}

		// Token: 0x0601C4D2 RID: 115922
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrderedTriangulator_InitTetraTraversal_19(HandleRef pThis);

		/// <summary>
		/// Methods to get one tetra at a time. Start with InitTetraTraversal()
		/// and then invoke GetNextTetra() until the method returns 0.
		/// </summary>
		// Token: 0x0601C4D3 RID: 115923 RVA: 0x0027BFEF File Offset: 0x0027A1EF
		public void InitTetraTraversal()
		{
			vtkOrderedTriangulator.vtkOrderedTriangulator_InitTetraTraversal_19(base.GetCppThis());
		}

		// Token: 0x0601C4D4 RID: 115924
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrderedTriangulator_InitTriangulation_20(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, int numPts);

		/// <summary>
		/// Initialize the triangulation process. Provide a bounding box and
		/// the maximum number of points to be inserted. Note that since the
		/// triangulation is performed using parametric coordinates (see
		/// InsertPoint()) the bounds should be represent the range of the
		/// parametric coordinates inserted.
		/// \post no_point_inserted: GetNumberOfPoints()==0
		/// </summary>
		// Token: 0x0601C4D5 RID: 115925 RVA: 0x0027BFFE File Offset: 0x0027A1FE
		public void InitTriangulation(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, int numPts)
		{
			vtkOrderedTriangulator.vtkOrderedTriangulator_InitTriangulation_20(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax, numPts);
		}

		// Token: 0x0601C4D6 RID: 115926
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrderedTriangulator_InitTriangulation_21(HandleRef pThis, IntPtr bounds, int numPts);

		/// <summary>
		/// Initialize the triangulation process. Provide a bounding box and
		/// the maximum number of points to be inserted. Note that since the
		/// triangulation is performed using parametric coordinates (see
		/// InsertPoint()) the bounds should be represent the range of the
		/// parametric coordinates inserted.
		/// \post no_point_inserted: GetNumberOfPoints()==0
		/// </summary>
		// Token: 0x0601C4D7 RID: 115927 RVA: 0x0027C018 File Offset: 0x0027A218
		public void InitTriangulation(IntPtr bounds, int numPts)
		{
			vtkOrderedTriangulator.vtkOrderedTriangulator_InitTriangulation_21(base.GetCppThis(), bounds, numPts);
		}

		// Token: 0x0601C4D8 RID: 115928
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrderedTriangulator_InsertPoint_22(HandleRef pThis, long id, IntPtr x, IntPtr p, int type);

		/// <summary>
		/// For each point to be inserted, provide an id, a position x, parametric
		/// coordinate p, and whether the point is inside (type=0), outside
		/// (type=1), or on the boundary (type=2). You must call InitTriangulation()
		/// prior to invoking this method. Make sure that the number of points
		/// inserted does not exceed the numPts specified in
		/// InitTriangulation(). Also note that the "id" can be any integer and can
		/// be greater than numPts. It is used to create tetras (in AddTetras()) with
		/// the appropriate connectivity ids. The method returns an internal id that
		/// can be used prior to the Triangulate() method to update the type of the
		/// point with UpdatePointType(). (Note: the algorithm triangulated with the
		/// parametric coordinate p[3] and creates tetras with the global coordinate
		/// x[3]. The parametric coordinates and global coordinates may be the same.)
		/// </summary>
		// Token: 0x0601C4D9 RID: 115929 RVA: 0x0027C02C File Offset: 0x0027A22C
		public long InsertPoint(long id, IntPtr x, IntPtr p, int type)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_InsertPoint_22(base.GetCppThis(), id, x, p, type);
		}

		// Token: 0x0601C4DA RID: 115930
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrderedTriangulator_InsertPoint_23(HandleRef pThis, long id, long sortid, IntPtr x, IntPtr p, int type);

		/// <summary>
		/// For each point to be inserted, provide an id, a position x, parametric
		/// coordinate p, and whether the point is inside (type=0), outside
		/// (type=1), or on the boundary (type=2). You must call InitTriangulation()
		/// prior to invoking this method. Make sure that the number of points
		/// inserted does not exceed the numPts specified in
		/// InitTriangulation(). Also note that the "id" can be any integer and can
		/// be greater than numPts. It is used to create tetras (in AddTetras()) with
		/// the appropriate connectivity ids. The method returns an internal id that
		/// can be used prior to the Triangulate() method to update the type of the
		/// point with UpdatePointType(). (Note: the algorithm triangulated with the
		/// parametric coordinate p[3] and creates tetras with the global coordinate
		/// x[3]. The parametric coordinates and global coordinates may be the same.)
		/// </summary>
		// Token: 0x0601C4DB RID: 115931 RVA: 0x0027C050 File Offset: 0x0027A250
		public long InsertPoint(long id, long sortid, IntPtr x, IntPtr p, int type)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_InsertPoint_23(base.GetCppThis(), id, sortid, x, p, type);
		}

		// Token: 0x0601C4DC RID: 115932
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOrderedTriangulator_InsertPoint_24(HandleRef pThis, long id, long sortid, long sortid2, IntPtr x, IntPtr p, int type);

		/// <summary>
		/// For each point to be inserted, provide an id, a position x, parametric
		/// coordinate p, and whether the point is inside (type=0), outside
		/// (type=1), or on the boundary (type=2). You must call InitTriangulation()
		/// prior to invoking this method. Make sure that the number of points
		/// inserted does not exceed the numPts specified in
		/// InitTriangulation(). Also note that the "id" can be any integer and can
		/// be greater than numPts. It is used to create tetras (in AddTetras()) with
		/// the appropriate connectivity ids. The method returns an internal id that
		/// can be used prior to the Triangulate() method to update the type of the
		/// point with UpdatePointType(). (Note: the algorithm triangulated with the
		/// parametric coordinate p[3] and creates tetras with the global coordinate
		/// x[3]. The parametric coordinates and global coordinates may be the same.)
		/// </summary>
		// Token: 0x0601C4DD RID: 115933 RVA: 0x0027C078 File Offset: 0x0027A278
		public long InsertPoint(long id, long sortid, long sortid2, IntPtr x, IntPtr p, int type)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_InsertPoint_24(base.GetCppThis(), id, sortid, sortid2, x, p, type);
		}

		// Token: 0x0601C4DE RID: 115934
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrderedTriangulator_IsA_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C4DF RID: 115935 RVA: 0x0027C0A0 File Offset: 0x0027A2A0
		public override int IsA(string type)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_IsA_25(base.GetCppThis(), type);
		}

		// Token: 0x0601C4E0 RID: 115936
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOrderedTriangulator_IsTypeOf_26([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C4E1 RID: 115937 RVA: 0x0027C0C0 File Offset: 0x0027A2C0
		public new static int IsTypeOf(string type)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_IsTypeOf_26(type);
		}

		// Token: 0x0601C4E2 RID: 115938
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrderedTriangulator_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C4E3 RID: 115939 RVA: 0x0027C0DC File Offset: 0x0027A2DC
		public new vtkOrderedTriangulator NewInstance()
		{
			vtkOrderedTriangulator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrderedTriangulator.vtkOrderedTriangulator_NewInstance_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOrderedTriangulator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C4E4 RID: 115940
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrderedTriangulator_PreSortedOff_29(HandleRef pThis);

		/// <summary>
		/// Boolean indicates whether the points have been pre-sorted. If
		/// pre-sorted is enabled, the points are not sorted on point id.
		/// By default, presorted is off. (The point id is defined in
		/// InsertPoint().)
		/// </summary>
		// Token: 0x0601C4E5 RID: 115941 RVA: 0x0027C136 File Offset: 0x0027A336
		public virtual void PreSortedOff()
		{
			vtkOrderedTriangulator.vtkOrderedTriangulator_PreSortedOff_29(base.GetCppThis());
		}

		// Token: 0x0601C4E6 RID: 115942
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrderedTriangulator_PreSortedOn_30(HandleRef pThis);

		/// <summary>
		/// Boolean indicates whether the points have been pre-sorted. If
		/// pre-sorted is enabled, the points are not sorted on point id.
		/// By default, presorted is off. (The point id is defined in
		/// InsertPoint().)
		/// </summary>
		// Token: 0x0601C4E7 RID: 115943 RVA: 0x0027C145 File Offset: 0x0027A345
		public virtual void PreSortedOn()
		{
			vtkOrderedTriangulator.vtkOrderedTriangulator_PreSortedOn_30(base.GetCppThis());
		}

		// Token: 0x0601C4E8 RID: 115944
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOrderedTriangulator_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C4E9 RID: 115945 RVA: 0x0027C154 File Offset: 0x0027A354
		public new static vtkOrderedTriangulator SafeDownCast(vtkObjectBase o)
		{
			vtkOrderedTriangulator vtkOrderedTriangulator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOrderedTriangulator.vtkOrderedTriangulator_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOrderedTriangulator = (vtkOrderedTriangulator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOrderedTriangulator.Register(null);
				}
			}
			return vtkOrderedTriangulator;
		}

		// Token: 0x0601C4EA RID: 115946
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrderedTriangulator_SetPreSorted_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Boolean indicates whether the points have been pre-sorted. If
		/// pre-sorted is enabled, the points are not sorted on point id.
		/// By default, presorted is off. (The point id is defined in
		/// InsertPoint().)
		/// </summary>
		// Token: 0x0601C4EB RID: 115947 RVA: 0x0027C1D3 File Offset: 0x0027A3D3
		public virtual void SetPreSorted(int _arg)
		{
			vtkOrderedTriangulator.vtkOrderedTriangulator_SetPreSorted_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0601C4EC RID: 115948
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrderedTriangulator_SetUseTemplates_33(HandleRef pThis, int _arg);

		/// <summary>
		/// If this flag is set, then the ordered triangulator will create
		/// and use templates for the triangulation. To use templates, the
		/// TemplateTriangulate() method should be called when appropriate.
		/// (Note: the TemplateTriangulate() method works for complete
		/// (interior) cells without extra points due to intersection, etc.)
		/// </summary>
		// Token: 0x0601C4ED RID: 115949 RVA: 0x0027C1E3 File Offset: 0x0027A3E3
		public virtual void SetUseTemplates(int _arg)
		{
			vtkOrderedTriangulator.vtkOrderedTriangulator_SetUseTemplates_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0601C4EE RID: 115950
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrderedTriangulator_SetUseTwoSortIds_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Tells the triangulator that a second sort id is provided
		/// for each point and should also be considered when sorting.
		/// </summary>
		// Token: 0x0601C4EF RID: 115951 RVA: 0x0027C1F3 File Offset: 0x0027A3F3
		public virtual void SetUseTwoSortIds(int _arg)
		{
			vtkOrderedTriangulator.vtkOrderedTriangulator_SetUseTwoSortIds_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0601C4F0 RID: 115952
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrderedTriangulator_TemplateTriangulate_35(HandleRef pThis, int cellType, int numPts, int numEdges);

		/// <summary>
		/// Perform the triangulation. (Complete all calls to InsertPoint() prior
		/// to invoking this method.) A special version is available when templates
		/// should be used.
		/// </summary>
		// Token: 0x0601C4F1 RID: 115953 RVA: 0x0027C203 File Offset: 0x0027A403
		public void TemplateTriangulate(int cellType, int numPts, int numEdges)
		{
			vtkOrderedTriangulator.vtkOrderedTriangulator_TemplateTriangulate_35(base.GetCppThis(), cellType, numPts, numEdges);
		}

		// Token: 0x0601C4F2 RID: 115954
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrderedTriangulator_Triangulate_36(HandleRef pThis);

		/// <summary>
		/// Perform the triangulation. (Complete all calls to InsertPoint() prior
		/// to invoking this method.) A special version is available when templates
		/// should be used.
		/// </summary>
		// Token: 0x0601C4F3 RID: 115955 RVA: 0x0027C215 File Offset: 0x0027A415
		public void Triangulate()
		{
			vtkOrderedTriangulator.vtkOrderedTriangulator_Triangulate_36(base.GetCppThis());
		}

		// Token: 0x0601C4F4 RID: 115956
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrderedTriangulator_UpdatePointType_37(HandleRef pThis, long internalId, int type);

		/// <summary>
		/// Update the point type. This is useful when the merging of nearly
		/// coincident points is performed. The id is the internal id returned
		/// from InsertPoint(). The method should be invoked prior to the
		/// Triangulate method. The type is specified as inside (type=0),
		/// outside (type=1), or on the boundary (type=2).
		/// \pre valid_range: internalId&gt;=0 &amp;&amp; internalId&lt;this-&gt;GetNumberOfPoints()
		/// </summary>
		// Token: 0x0601C4F5 RID: 115957 RVA: 0x0027C224 File Offset: 0x0027A424
		public void UpdatePointType(long internalId, int type)
		{
			vtkOrderedTriangulator.vtkOrderedTriangulator_UpdatePointType_37(base.GetCppThis(), internalId, type);
		}

		// Token: 0x0601C4F6 RID: 115958
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrderedTriangulator_UseTemplatesOff_38(HandleRef pThis);

		/// <summary>
		/// If this flag is set, then the ordered triangulator will create
		/// and use templates for the triangulation. To use templates, the
		/// TemplateTriangulate() method should be called when appropriate.
		/// (Note: the TemplateTriangulate() method works for complete
		/// (interior) cells without extra points due to intersection, etc.)
		/// </summary>
		// Token: 0x0601C4F7 RID: 115959 RVA: 0x0027C235 File Offset: 0x0027A435
		public virtual void UseTemplatesOff()
		{
			vtkOrderedTriangulator.vtkOrderedTriangulator_UseTemplatesOff_38(base.GetCppThis());
		}

		// Token: 0x0601C4F8 RID: 115960
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrderedTriangulator_UseTemplatesOn_39(HandleRef pThis);

		/// <summary>
		/// If this flag is set, then the ordered triangulator will create
		/// and use templates for the triangulation. To use templates, the
		/// TemplateTriangulate() method should be called when appropriate.
		/// (Note: the TemplateTriangulate() method works for complete
		/// (interior) cells without extra points due to intersection, etc.)
		/// </summary>
		// Token: 0x0601C4F9 RID: 115961 RVA: 0x0027C244 File Offset: 0x0027A444
		public virtual void UseTemplatesOn()
		{
			vtkOrderedTriangulator.vtkOrderedTriangulator_UseTemplatesOn_39(base.GetCppThis());
		}

		// Token: 0x0601C4FA RID: 115962
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrderedTriangulator_UseTwoSortIdsOff_40(HandleRef pThis);

		/// <summary>
		/// Tells the triangulator that a second sort id is provided
		/// for each point and should also be considered when sorting.
		/// </summary>
		// Token: 0x0601C4FB RID: 115963 RVA: 0x0027C253 File Offset: 0x0027A453
		public virtual void UseTwoSortIdsOff()
		{
			vtkOrderedTriangulator.vtkOrderedTriangulator_UseTwoSortIdsOff_40(base.GetCppThis());
		}

		// Token: 0x0601C4FC RID: 115964
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOrderedTriangulator_UseTwoSortIdsOn_41(HandleRef pThis);

		/// <summary>
		/// Tells the triangulator that a second sort id is provided
		/// for each point and should also be considered when sorting.
		/// </summary>
		// Token: 0x0601C4FD RID: 115965 RVA: 0x0027C262 File Offset: 0x0027A462
		public virtual void UseTwoSortIdsOn()
		{
			vtkOrderedTriangulator.vtkOrderedTriangulator_UseTwoSortIdsOn_41(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E14 RID: 7700
		public new const string MRFullTypeName = "Kitware.VTK.vtkOrderedTriangulator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E15 RID: 7701
		public new static readonly string MRClassNameKey = "class vtkOrderedTriangulator";
	}
}
