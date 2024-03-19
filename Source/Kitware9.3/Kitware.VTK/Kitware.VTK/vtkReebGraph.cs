using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkReebGraph
	/// </summary>
	/// <remarks>
	///    Reeb graph computation for PL scalar fields.
	///
	///
	/// vtkReebGraph is a class that computes a Reeb graph given a PL scalar
	/// field (vtkDataArray) defined on a simplicial mesh.
	/// A Reeb graph is a concise representation of the connectivity evolution of
	/// the level sets of a scalar function.
	///
	/// It is particularly useful in visualization (optimal seed set computation,
	/// fast flexible isosurface extraction, automated transfer function design,
	/// feature-driven visualization, etc.) and computer graphics (shape
	/// deformation, shape matching, shape compression, etc.).
	///
	/// Reference:
	/// "Sur les points singuliers d'une forme de Pfaff completement integrable ou
	/// d'une fonction numerique",
	/// G. Reeb,
	/// Comptes-rendus de l'Academie des Sciences, 222:847-849, 1946.
	///
	/// vtkReebGraph implements one of the latest and most robust Reeb graph
	/// computation algorithms.
	///
	/// Reference:
	/// "Robust on-line computation of Reeb graphs: simplicity and speed",
	/// V. Pascucci, G. Scorzelli, P.-T. Bremer, and A. Mascarenhas,
	/// ACM Transactions on Graphics, Proc. of SIGGRAPH 2007.
	///
	/// vtkReebGraph provides methods for computing multi-resolution topological
	/// hierarchies through topological simplification.
	/// Topoligical simplification can be either driven by persistence homology
	/// concepts (default behavior) or by application specific metrics (see
	/// vtkReebGraphSimplificationMetric).
	/// In the latter case, designing customized simplification metric evaluation
	/// algorithms enables the user to control the definition of what should be
	/// considered as noise or signal in the topological filtering process.
	///
	/// References:
	/// "Topological persistence and simplification",
	/// H. Edelsbrunner, D. Letscher, and A. Zomorodian,
	/// Discrete Computational Geometry, 28:511-533, 2002.
	///
	/// "Extreme elevation on a 2-manifold",
	/// P.K. Agarwal, H. Edelsbrunner, J. Harer, and Y. Wang,
	/// ACM Symposium on Computational Geometry, pp. 357-365, 2004.
	///
	/// "Simplifying flexible isosurfaces using local geometric measures",
	/// H. Carr, J. Snoeyink, M van de Panne,
	/// IEEE Visualization, 497-504, 2004
	///
	/// "Loop surgery for volumetric meshes: Reeb graphs reduced to contour trees",
	/// J. Tierny, A. Gyulassy, E. Simon, V. Pascucci,
	/// IEEE Trans. on Vis. and Comp. Graph. (Proc of IEEE VIS), 15:1177-1184, 2009.
	///
	///
	///
	/// Reeb graphs can be computed from 2D data (vtkPolyData, with triangles only)
	/// or 3D data (vtkUnstructuredGrid, with tetrahedra only), sequentially (see
	/// the "Build" calls) or in streaming (see the "StreamTriangle" and
	/// "StreamTetrahedron" calls).
	///
	/// vtkReebGraph inherits from vtkMutableDirectedGraph.
	///
	/// Each vertex of a vtkReebGraph object represents a critical point of the
	/// scalar field where the connectivity of the related level set changes
	/// (creation, deletion, split or merge of connected components).
	/// A vtkIdTypeArray (called "Vertex Ids") is associated with the VertexData of
	/// a vtkReebGraph object, in order to retrieve if necessary the exact Ids of
	/// the corresponding vertices in the input mesh.
	///
	/// The edges of a vtkReebGraph object represent the regions of the input mesh
	/// separated by the critical contours of the field, and where the connectivity
	/// of the input field does not change.
	/// A vtkVariantArray is associated with the EdgeDta of a vtkReebGraph object and
	/// each entry of this array is a vtkAbstractArray containing the Ids of the
	/// vertices of those regions, sorted by function value (useful for flexible
	/// isosurface extraction or level set signature computation, for instance).
	///
	/// See Graphics/Testing/Cxx/TestReebGraph.cxx for examples of traversals and
	/// typical usages (customized simplification, skeletonization, contour spectra,
	///  etc.) of a vtkReebGraph object.
	///
	///
	/// </remarks>
	/// <seealso>
	///
	///      vtkReebGraphSimplificationMetric
	///      vtkPolyDataToReebGraphFilter
	///      vtkUnstructuredGridToReebGraphFilter
	///      vtkReebGraphSimplificationFilter
	///      vtkReebGraphSurfaceSkeletonFilter
	///      vtkReebGraphVolumeSkeletonFilter
	///      vtkAreaContourSpectrumFilter
	///      vtkVolumeContourSpectrumFilter
	///
	/// @par Tests:
	///      Graphics/Testing/Cxx/TestReebGraph.cxx
	/// </seealso>
	// Token: 0x02000AB8 RID: 2744
	public class vtkReebGraph : vtkMutableDirectedGraph
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601CE64 RID: 118372 RVA: 0x0028B523 File Offset: 0x00289723
		static vtkReebGraph()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkReebGraph.MRClassNameKey, Type.GetType("Kitware.VTK.vtkReebGraph"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601CE65 RID: 118373 RVA: 0x0028B54B File Offset: 0x0028974B
		public vtkReebGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601CE66 RID: 118374
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkReebGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CE67 RID: 118375 RVA: 0x0028B55C File Offset: 0x0028975C
		public new static vtkReebGraph New()
		{
			vtkReebGraph result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkReebGraph.vtkReebGraph_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkReebGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CE68 RID: 118376 RVA: 0x0028B5B0 File Offset: 0x002897B0
		public vtkReebGraph() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkReebGraph.vtkReebGraph_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601CE69 RID: 118377 RVA: 0x0028B5F4 File Offset: 0x002897F4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601CE6A RID: 118378
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReebGraph_Build_01(HandleRef pThis, HandleRef mesh, HandleRef scalarField);

		/// <summary>
		/// Build the Reeb graph of the field 'scalarField' defined on the surface
		/// mesh 'mesh'.
		///
		/// Returned values:
		///
		/// vtkReebGraph::ERR_INCORRECT_FIELD: 'scalarField' does not have as many
		/// tuples as 'mesh' has vertices.
		///
		/// vtkReebGraph::ERR_NOT_A_SIMPLICIAL_MESH: the input mesh 'mesh' is not a
		/// simplicial mesh (for example, the surface mesh contains quads instead of
		/// triangles).
		/// </summary>
		// Token: 0x0601CE6B RID: 118379 RVA: 0x0028B600 File Offset: 0x00289800
		public int Build(vtkPolyData mesh, vtkDataArray scalarField)
		{
			return vtkReebGraph.vtkReebGraph_Build_01(base.GetCppThis(), (mesh == null) ? default(HandleRef) : mesh.GetCppThis(), (scalarField == null) ? default(HandleRef) : scalarField.GetCppThis());
		}

		// Token: 0x0601CE6C RID: 118380
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReebGraph_Build_02(HandleRef pThis, HandleRef mesh, HandleRef scalarField);

		/// <summary>
		/// Build the Reeb graph of the field 'scalarField' defined on the volume
		/// mesh 'mesh'.
		///
		/// Returned values:
		///
		/// vtkReebGraph::ERR_INCORRECT_FIELD: 'scalarField' does not have as many
		/// tuples as 'mesh' has vertices.
		///
		/// vtkReebGraph::ERR_NOT_A_SIMPLICIAL_MESH: the input mesh 'mesh' is not a
		/// simplicial mesh.
		/// </summary>
		// Token: 0x0601CE6D RID: 118381 RVA: 0x0028B64C File Offset: 0x0028984C
		public int Build(vtkUnstructuredGrid mesh, vtkDataArray scalarField)
		{
			return vtkReebGraph.vtkReebGraph_Build_02(base.GetCppThis(), (mesh == null) ? default(HandleRef) : mesh.GetCppThis(), (scalarField == null) ? default(HandleRef) : scalarField.GetCppThis());
		}

		// Token: 0x0601CE6E RID: 118382
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReebGraph_Build_03(HandleRef pThis, HandleRef mesh, long scalarFieldId);

		/// <summary>
		/// Build the Reeb graph of the field given by the Id 'scalarFieldId',
		/// defined on the surface mesh 'mesh'.
		///
		/// Returned values:
		///
		/// vtkReebGraph::ERR_INCORRECT_FIELD: 'scalarField' does not have as many
		/// tuples as 'mesh' as vertices.
		///
		/// vtkReebGraph::ERR_NOT_A_SIMPLICIAL_MESH: the input mesh 'mesh' is not a
		/// simplicial mesh (for example, the surface mesh contains quads instead of
		/// triangles).
		///
		/// vtkReebGraph::ERR_NO_SUCH_FIELD: the scalar field given by the Id
		/// 'scalarFieldId' does not exist.
		/// </summary>
		// Token: 0x0601CE6F RID: 118383 RVA: 0x0028B698 File Offset: 0x00289898
		public int Build(vtkPolyData mesh, long scalarFieldId)
		{
			return vtkReebGraph.vtkReebGraph_Build_03(base.GetCppThis(), (mesh == null) ? default(HandleRef) : mesh.GetCppThis(), scalarFieldId);
		}

		// Token: 0x0601CE70 RID: 118384
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReebGraph_Build_04(HandleRef pThis, HandleRef mesh, long scalarFieldId);

		/// <summary>
		/// Build the Reeb graph of the field given by the Id 'scalarFieldId',
		/// defined on the volume mesh 'mesh'.
		///
		/// Returned values:
		///
		/// vtkReebGraph::ERR_INCORRECT_FIELD: 'scalarField' does not have as many
		/// tuples as 'mesh' as vertices.
		///
		/// vtkReebGraph::ERR_NOT_A_SIMPLICIAL_MESH: the input mesh 'mesh' is not a
		/// simplicial mesh.
		///
		/// vtkReebGraph::ERR_NO_SUCH_FIELD: the scalar field given by the Id
		/// 'scalarFieldId' does not exist.
		/// </summary>
		// Token: 0x0601CE71 RID: 118385 RVA: 0x0028B6D0 File Offset: 0x002898D0
		public int Build(vtkUnstructuredGrid mesh, long scalarFieldId)
		{
			return vtkReebGraph.vtkReebGraph_Build_04(base.GetCppThis(), (mesh == null) ? default(HandleRef) : mesh.GetCppThis(), scalarFieldId);
		}

		// Token: 0x0601CE72 RID: 118386
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReebGraph_Build_05(HandleRef pThis, HandleRef mesh, [MarshalAs(UnmanagedType.LPUTF8Str)] string scalarFieldName);

		/// <summary>
		/// Build the Reeb graph of the field given by the name 'scalarFieldName',
		/// defined on the surface mesh 'mesh'.
		///
		/// Returned values:
		///
		/// vtkReebGraph::ERR_INCORRECT_FIELD: 'scalarField' does not have as many
		/// tuples as 'mesh' as vertices.
		///
		/// vtkReebGraph::ERR_NOT_A_SIMPLICIAL_MESH: the input mesh 'mesh' is not a
		/// simplicial mesh (for example, the surface mesh contains quads instead of
		/// triangles).
		///
		/// vtkReebGraph::ERR_NO_SUCH_FIELD: the scalar field given by the name
		/// 'scalarFieldName' does not exist.
		/// </summary>
		// Token: 0x0601CE73 RID: 118387 RVA: 0x0028B708 File Offset: 0x00289908
		public int Build(vtkPolyData mesh, string scalarFieldName)
		{
			return vtkReebGraph.vtkReebGraph_Build_05(base.GetCppThis(), (mesh == null) ? default(HandleRef) : mesh.GetCppThis(), scalarFieldName);
		}

		// Token: 0x0601CE74 RID: 118388
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReebGraph_Build_06(HandleRef pThis, HandleRef mesh, [MarshalAs(UnmanagedType.LPUTF8Str)] string scalarFieldName);

		/// <summary>
		/// Build the Reeb graph of the field given by the name 'scalarFieldName',
		/// defined on the volume mesh 'mesh'.
		///
		/// Returned values:
		///
		/// vtkReebGraph::ERR_INCORRECT_FIELD: 'scalarField' does not have as many
		/// tuples as 'mesh' as vertices.
		///
		/// vtkReebGraph::ERR_NOT_A_SIMPLICIAL_MESH: the input mesh 'mesh' is not a
		/// simplicial mesh.
		///
		/// vtkReebGraph::ERR_NO_SUCH_FIELD: the scalar field given by the name
		/// 'scalarFieldName' does not exist.
		/// </summary>
		// Token: 0x0601CE75 RID: 118389 RVA: 0x0028B740 File Offset: 0x00289940
		public int Build(vtkUnstructuredGrid mesh, string scalarFieldName)
		{
			return vtkReebGraph.vtkReebGraph_Build_06(base.GetCppThis(), (mesh == null) ? default(HandleRef) : mesh.GetCppThis(), scalarFieldName);
		}

		// Token: 0x0601CE76 RID: 118390
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReebGraph_CloseStream_07(HandleRef pThis);

		/// <summary>
		/// Finalize internal data structures, in the case of streaming computations
		/// (with StreamTriangle or StreamTetrahedron).
		/// After this call, no more triangle or tetrahedron can be inserted via
		/// StreamTriangle or StreamTetrahedron.
		/// IMPORTANT: This method _must_ be called when the input stream is finished.
		/// If you need to get a snapshot of the Reeb graph during the streaming
		/// process (to parse or simplify it), do a DeepCopy followed by a
		/// CloseStream on the copy.
		/// </summary>
		// Token: 0x0601CE77 RID: 118391 RVA: 0x0028B775 File Offset: 0x00289975
		public void CloseStream()
		{
			vtkReebGraph.vtkReebGraph_CloseStream_07(base.GetCppThis());
		}

		// Token: 0x0601CE78 RID: 118392
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReebGraph_DeepCopy_08(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Finalize internal data structures, in the case of streaming computations
		/// (with StreamTriangle or StreamTetrahedron).
		/// After this call, no more triangle or tetrahedron can be inserted via
		/// StreamTriangle or StreamTetrahedron.
		/// IMPORTANT: This method _must_ be called when the input stream is finished.
		/// If you need to get a snapshot of the Reeb graph during the streaming
		/// process (to parse or simplify it), do a DeepCopy followed by a
		/// CloseStream on the copy.
		/// </summary>
		// Token: 0x0601CE79 RID: 118393 RVA: 0x0028B784 File Offset: 0x00289984
		public override void DeepCopy(vtkDataObject src)
		{
			vtkReebGraph.vtkReebGraph_DeepCopy_08(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0601CE7A RID: 118394
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReebGraph_GetDataObjectType_09(HandleRef pThis);

		/// <summary>
		/// Return class name of data type. This is one of VTK_STRUCTURED_GRID,
		/// VTK_STRUCTURED_POINTS, VTK_UNSTRUCTURED_GRID, VTK_POLY_DATA, or
		/// VTK_RECTILINEAR_GRID (see vtkSetGet.h for definitions).
		/// THIS METHOD IS THREAD SAFE
		/// </summary>
		// Token: 0x0601CE7B RID: 118395 RVA: 0x0028B7B4 File Offset: 0x002899B4
		public override int GetDataObjectType()
		{
			return vtkReebGraph.vtkReebGraph_GetDataObjectType_09(base.GetCppThis());
		}

		// Token: 0x0601CE7C RID: 118396
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkReebGraph_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CE7D RID: 118397 RVA: 0x0028B7D4 File Offset: 0x002899D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkReebGraph.vtkReebGraph_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x0601CE7E RID: 118398
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkReebGraph_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CE7F RID: 118399 RVA: 0x0028B7F4 File Offset: 0x002899F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkReebGraph.vtkReebGraph_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x0601CE80 RID: 118400
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReebGraph_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CE81 RID: 118401 RVA: 0x0028B810 File Offset: 0x00289A10
		public override int IsA(string type)
		{
			return vtkReebGraph.vtkReebGraph_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0601CE82 RID: 118402
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReebGraph_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CE83 RID: 118403 RVA: 0x0028B830 File Offset: 0x00289A30
		public new static int IsTypeOf(string type)
		{
			return vtkReebGraph.vtkReebGraph_IsTypeOf_13(type);
		}

		// Token: 0x0601CE84 RID: 118404
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkReebGraph_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CE85 RID: 118405 RVA: 0x0028B84C File Offset: 0x00289A4C
		public new vtkReebGraph NewInstance()
		{
			vtkReebGraph result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkReebGraph.vtkReebGraph_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkReebGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601CE86 RID: 118406
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkReebGraph_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CE87 RID: 118407 RVA: 0x0028B8A8 File Offset: 0x00289AA8
		public new static vtkReebGraph SafeDownCast(vtkObjectBase o)
		{
			vtkReebGraph vtkReebGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkReebGraph.vtkReebGraph_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkReebGraph = (vtkReebGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkReebGraph.Register(null);
				}
			}
			return vtkReebGraph;
		}

		// Token: 0x0601CE88 RID: 118408
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReebGraph_Set_17(HandleRef pThis, HandleRef g);

		/// <summary>
		/// Use a pre-defined Reeb graph (post-processing).
		/// Use with caution!
		/// </summary>
		// Token: 0x0601CE89 RID: 118409 RVA: 0x0028B928 File Offset: 0x00289B28
		public void Set(vtkMutableDirectedGraph g)
		{
			vtkReebGraph.vtkReebGraph_Set_17(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis());
		}

		// Token: 0x0601CE8A RID: 118410
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReebGraph_Simplify_18(HandleRef pThis, double simplificationThreshold, HandleRef simplificationMetric);

		/// <summary>
		/// Simplify the Reeb graph given a threshold 'simplificationThreshold'
		/// (between 0 and 1).
		///
		/// This method is the core feature for Reeb graph multi-resolution hierarchy
		/// construction.
		///
		/// Return the number of arcs that have been removed through the simplification
		/// process.
		///
		/// 'simplificationThreshold' represents a "scale", under which each Reeb graph
		/// feature is considered as noise. 'simplificationThreshold' is expressed as a
		/// fraction of the scalar field overall span. It can vary from 0
		/// (no simplification) to 1 (maximal simplification).
		///
		/// 'simplificationMetric' is an object in charge of evaluating the importance
		/// of a Reeb graph arc at each step of the simplification process.
		/// if 'simplificationMetric' is nullptr, the default strategy (persitence of the
		/// scalar field) is used.
		/// Customized simplification metric evaluation algorithm can be designed (see
		/// vtkReebGraphSimplificationMetric), enabling the user to control the
		/// definition of what should be considered as noise or signal.
		///
		/// References:
		///
		/// "Topological persistence and simplification",
		/// H. Edelsbrunner, D. Letscher, and A. Zomorodian,
		/// Discrete Computational Geometry, 28:511-533, 2002.
		///
		/// "Extreme elevation on a 2-manifold",
		/// P.K. Agarwal, H. Edelsbrunner, J. Harer, and Y. Wang,
		/// ACM Symposium on Computational Geometry, pp. 357-365, 2004.
		///
		/// "Simplifying flexible isosurfaces using local geometric measures",
		/// H. Carr, J. Snoeyink, M van de Panne,
		/// IEEE Visualization, 497-504, 2004
		///
		/// "Loop surgery for volumetric meshes: Reeb graphs reduced to contour trees",
		/// J. Tierny, A. Gyulassy, E. Simon, V. Pascucci,
		/// IEEE Trans. on Vis. and Comp. Graph. (Proc of IEEE VIS), 15:1177-1184,2009.
		/// </summary>
		// Token: 0x0601CE8B RID: 118411 RVA: 0x0028B958 File Offset: 0x00289B58
		public int Simplify(double simplificationThreshold, vtkReebGraphSimplificationMetric simplificationMetric)
		{
			return vtkReebGraph.vtkReebGraph_Simplify_18(base.GetCppThis(), simplificationThreshold, (simplificationMetric == null) ? default(HandleRef) : simplificationMetric.GetCppThis());
		}

		// Token: 0x0601CE8C RID: 118412
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReebGraph_StreamTetrahedron_19(HandleRef pThis, long vertex0Id, double scalar0, long vertex1Id, double scalar1, long vertex2Id, double scalar2, long vertex3Id, double scalar3);

		/// <summary>
		/// Streaming Reeb graph computation.
		/// Add to the streaming computation the tetrahedra of the vtkUnstructuredGrid
		/// volume mesh described by
		/// vertex0Id, scalar0
		/// vertex1Id, scalar1
		/// vertex2Id, scalar2
		/// vertex3Id, scalar3
		///
		/// where vertexNId is the Id of the vertex in the vtkUnstructuredGrid
		/// structure and scalarN is the corresponding scalar field value.
		///
		/// IMPORTANT: The stream _must_ be finalized with the "CloseStream" call.
		/// </summary>
		// Token: 0x0601CE8D RID: 118413 RVA: 0x0028B990 File Offset: 0x00289B90
		public int StreamTetrahedron(long vertex0Id, double scalar0, long vertex1Id, double scalar1, long vertex2Id, double scalar2, long vertex3Id, double scalar3)
		{
			return vtkReebGraph.vtkReebGraph_StreamTetrahedron_19(base.GetCppThis(), vertex0Id, scalar0, vertex1Id, scalar1, vertex2Id, scalar2, vertex3Id, scalar3);
		}

		// Token: 0x0601CE8E RID: 118414
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReebGraph_StreamTriangle_20(HandleRef pThis, long vertex0Id, double scalar0, long vertex1Id, double scalar1, long vertex2Id, double scalar2);

		/// <summary>
		/// Streaming Reeb graph computation.
		/// Add to the streaming computation the triangle of the vtkPolyData surface
		/// mesh described by
		/// vertex0Id, scalar0
		/// vertex1Id, scalar1
		/// vertex2Id, scalar2
		///
		/// where vertexNId is the Id of the vertex in the vtkPolyData structure
		/// and scalarN is the corresponding scalar field value.
		///
		/// IMPORTANT: The stream _must_ be finalized with the "CloseStream" call.
		/// </summary>
		// Token: 0x0601CE8F RID: 118415 RVA: 0x0028B9BC File Offset: 0x00289BBC
		public int StreamTriangle(long vertex0Id, double scalar0, long vertex1Id, double scalar1, long vertex2Id, double scalar2)
		{
			return vtkReebGraph.vtkReebGraph_StreamTriangle_20(base.GetCppThis(), vertex0Id, scalar0, vertex1Id, scalar1, vertex2Id, scalar2);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E79 RID: 7801
		public new const string MRFullTypeName = "Kitware.VTK.vtkReebGraph";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E7A RID: 7802
		public new static readonly string MRClassNameKey = "class vtkReebGraph";

		/// <summary>
		/// Return class name of data type. This is one of VTK_STRUCTURED_GRID,
		/// VTK_STRUCTURED_POINTS, VTK_UNSTRUCTURED_GRID, VTK_POLY_DATA, or
		/// VTK_RECTILINEAR_GRID (see vtkSetGet.h for definitions).
		/// THIS METHOD IS THREAD SAFE
		/// </summary>
		// Token: 0x02000AB9 RID: 2745
		public enum ERR_INCORRECT_FIELD_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04001E7C RID: 7804
			ERR_INCORRECT_FIELD = -1,
			/// <summary>enum member</summary>
			// Token: 0x04001E7D RID: 7805
			ERR_NOT_A_SIMPLICIAL_MESH = -3,
			/// <summary>enum member</summary>
			// Token: 0x04001E7E RID: 7806
			ERR_NO_SUCH_FIELD
		}
	}
}
