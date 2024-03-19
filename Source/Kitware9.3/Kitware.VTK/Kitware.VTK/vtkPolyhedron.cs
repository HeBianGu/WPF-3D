using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyhedron
	/// </summary>
	/// <remarks>
	///    A 3D cell defined by a set of polygonal faces
	///
	/// @section Instantiation Instantiation
	///
	/// vtkPolyhedron is a concrete implementation of vtkCell that represents a 3D cell
	/// defined by a set of polygonal faces.
	///
	/// To instantiate a vtkPolyhedron, like any vtkCell, one needs to define the
	/// following structures:
	/// - A list of point coordinates
	/// - A list of global point IDs
	///
	/// Note that the ordering of points coordinates or IDs is not important.
	/// However, it MUST be consistent between the two lists.
	///
	/// Unlike other kinds of cells (e.g. vtkVoxel), the topology is not directly deduced from points
	/// coordinates or point IDs ordering; it must be explicitly defined by providing a list of faces
	/// (see the SetFaces() method). Each face is represented as a sequence of global point Ids.
	///
	/// Once point coordinates, point IDs and faces are defined, the Initialize() method should be called
	/// in order to setup the internal structures and finalize the construction of the polyhedron.
	///
	/// Here is an example of vtkPolyhedron instantiation:
	/// @code{.cpp}
	///
	/// //  9 +------+.11
	/// //    |`.    | `.
	/// //    |13`+--+---+ 15
	/// //    |   |  |   |
	/// //  8 +---+--+.10|
	/// //     `. |    `.|
	/// //     12`+------+ 14
	/// //
	/// // (Global IDs are arbitrarily chosen between 8 and 15)
	///
	/// // Insert point coordinates
	/// polyhedron-&gt;GetPoints()-&gt;SetNumberOfPoints(8);
	/// polyhedron-&gt;GetPoints()-&gt;SetPoint(0, 0., 0., 0.); // 8
	/// polyhedron-&gt;GetPoints()-&gt;SetPoint(1, 0., 1., 0.); // 9
	/// polyhedron-&gt;GetPoints()-&gt;SetPoint(2, 1., 0., 0.); // 10
	/// polyhedron-&gt;GetPoints()-&gt;SetPoint(3, 1., 1., 0.); // 11
	/// polyhedron-&gt;GetPoints()-&gt;SetPoint(4, 0., 0., 1.); // 12
	/// polyhedron-&gt;GetPoints()-&gt;SetPoint(5, 0., 1., 1.); // 13
	/// polyhedron-&gt;GetPoints()-&gt;SetPoint(6, 1., 0., 1.); // 14
	/// polyhedron-&gt;GetPoints()-&gt;SetPoint(7, 1., 1., 1.); // 15
	///
	/// // Insert point IDs (global IDs)
	/// // Note that the canonical ordering (0, 1, ..., 8) is used
	/// // to correlate point Ids and coordinates
	/// polyhedron-&gt;GetPointIds()-&gt;Allocate(8);
	/// for (int i = 8; i &lt; 16; ++i)
	/// {
	///   polyhedron-&gt;GetPointIds()-&gt;InsertNextId(i);
	/// }
	///
	/// // Describe faces, indexed on global IDs
	/// vtkIdType faces[31] = { 6, // Number of faces
	///                         4, 9 , 11, 10, 8 , // Number of points in the face + point IDs
	///                         4, 11, 15, 14, 10, // Faces are described counter-clockwise
	///                         4, 15, 13, 12, 14, // looking from the "outside" of the cell
	///                         4, 13, 9 , 8 , 12,
	///                         4, 14, 12, 8 , 10,
	///                         4, 13, 15, 11, 9 };
	///
	/// polyhedron-&gt;SetFaces(faces);
	///
	/// // Initialize the polyhedron
	/// // This will build internal structures and should be done before the proper
	/// // use of the cell.
	/// polyhedron-&gt;Initialize();
	/// @endcode
	///
	/// @section Specifications Specifications
	///
	/// Polyhedrons described by this class must conform to some criteria in order to avoid errors and
	/// guarantee good results in terms of visualization and processing.
	///
	/// These specifications are described as follows. Polyhedrons must:
	/// - be watertight : the faces describing the polyhedron should define an enclosed volume
	///   i.e. define the “inside” and the “outside” of the cell
	/// - have planar faces : all points defining a face should be in the same 2D plane
	/// - not be self-intersecting : for example, a face of the polyhedron can’t intersect other ones
	/// - not contain zero-thickness portions : adjacent faces should not overlap each other even
	/// partially
	/// - not contain disconnected elements : detached vertice(s), edge(s) or face(s)
	/// - be simply connected : vtkPolyhedron must describe a single polyhedron
	/// - not contain duplicate elements : each point index and each face description should be unique
	/// - not contain “internal” or “external” faces : for each face, one side should be “inside” the
	/// cell, the other side “outside”
	///
	/// In a more global perspective, polyhedrons must be watertight and manifold.
	/// In particular, each edge of the polyhedron must be adjacent to exactly two faces.
	/// Several algorithms like contour, clip or slice will assume that each edge of the polyhedron
	/// is adjacent to exactly two faces and will definitely lead to bad results (and generate numerous
	/// warnings) if this criterion is not fulfilled.
	///
	/// @section Limitations Limitations
	///
	/// The class does not require the polyhedron to be convex. However, the support of concave
	/// polyhedrons is currently limited. Concavity can lead to bad results with some filters,
	/// including:
	/// - Contour: the contour (surface) can be constructed outside of the cell,
	/// - Triangulate: the current tetrahedralization algorithm can modify the initial
	///   shape of the polygon (created tetrahedrons can change concave portions of the shape
	///   to convex ones).
	///
	/// @section OtherDetails Other details
	///
	/// Interpolation functions and weights are defined / computed using the method of Mean Value
	/// Coordinates (MVC). See the VTK class vtkMeanValueCoordinatesInterpolator for more information.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCell3D vtkConvexPointSet vtkMeanValueCoordinatesInterpolator vtkPolyhedronUtilities
	/// </seealso>
	// Token: 0x02000AA7 RID: 2727
	public class vtkPolyhedron : vtkCell3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601CA3B RID: 117307 RVA: 0x0028422A File Offset: 0x0028242A
		static vtkPolyhedron()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyhedron.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyhedron"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601CA3C RID: 117308 RVA: 0x00284252 File Offset: 0x00282452
		public vtkPolyhedron(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601CA3D RID: 117309
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyhedron_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard new methods.
		/// </summary>
		// Token: 0x0601CA3E RID: 117310 RVA: 0x00284260 File Offset: 0x00282460
		public new static vtkPolyhedron New()
		{
			vtkPolyhedron result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyhedron.vtkPolyhedron_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyhedron)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard new methods.
		/// </summary>
		// Token: 0x0601CA3F RID: 117311 RVA: 0x002842B4 File Offset: 0x002824B4
		public vtkPolyhedron() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolyhedron.vtkPolyhedron_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601CA40 RID: 117312 RVA: 0x002842F8 File Offset: 0x002824F8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601CA41 RID: 117313
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyhedron_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// Find the boundary face closest to the point defined by the pcoords[3]
		/// and subId of the cell (subId can be ignored).
		/// </summary>
		// Token: 0x0601CA42 RID: 117314 RVA: 0x00284304 File Offset: 0x00282504
		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkPolyhedron.vtkPolyhedron_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601CA43 RID: 117315
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyhedron_Clip_02(HandleRef pThis, double value, HandleRef scalars, HandleRef locator, HandleRef connectivity, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// Satisfy the vtkCell API. This method clips the input polyhedron and outputs
		/// a new polyhedron. The face information of the output polyhedron is encoded
		/// in the output vtkCellArray using a special format:
		/// CellLength [nCellFaces, nFace0Pts, i, j, k, nFace1Pts, i, j, k, ...].
		/// Use the static method vtkUnstructuredGrid::DecomposePolyhedronCellArray
		/// to convert it into a standard format.
		/// @warning The current implementation assumes water-tight and manifold polyhedron cells.
		/// </summary>
		// Token: 0x0601CA44 RID: 117316 RVA: 0x0028433C File Offset: 0x0028253C
		public override void Clip(double value, vtkDataArray scalars, vtkIncrementalPointLocator locator, vtkCellArray connectivity, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkPolyhedron.vtkPolyhedron_Clip_02(base.GetCppThis(), value, (scalars == null) ? default(HandleRef) : scalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (connectivity == null) ? default(HandleRef) : connectivity.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601CA45 RID: 117317
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyhedron_Contour_03(HandleRef pThis, double value, HandleRef scalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// Satisfy the vtkCell API. This method contours the input polyhedron and outputs
		/// a polygon. When the result polygon is not planar, it will be triangulated.
		/// @warning The current implementation assumes water-tight and manifold polyhedron cells.
		/// </summary>
		// Token: 0x0601CA46 RID: 117318 RVA: 0x002843F8 File Offset: 0x002825F8
		public override void Contour(double value, vtkDataArray scalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkPolyhedron.vtkPolyhedron_Contour_03(base.GetCppThis(), value, (scalars == null) ? default(HandleRef) : scalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601CA47 RID: 117319
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyhedron_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// Computes derivatives at the point specified by the parameter coordinate.
		/// Current implementation uses all vertices and subId is not used.
		/// To accelerate the speed, the future implementation can triangulate and
		/// extract the local tetrahedron from subId and pcoords, then evaluate
		/// derivatives on the local tetrahedron.
		/// </summary>
		// Token: 0x0601CA48 RID: 117320 RVA: 0x002844E0 File Offset: 0x002826E0
		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkPolyhedron.vtkPolyhedron_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601CA49 RID: 117321
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyhedron_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// The inverse of EvaluatePosition. Note the weights should be the MVC
		/// weights.
		/// </summary>
		// Token: 0x0601CA4A RID: 117322 RVA: 0x002844F6 File Offset: 0x002826F6
		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkPolyhedron.vtkPolyhedron_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601CA4B RID: 117323
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyhedron_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// Satisfy the vtkCell API. The subId is ignored and zero is always
		/// returned. The parametric coordinates pcoords are normalized values in
		/// the bounding box of the polyhedron. The weights are determined by
		/// evaluating the MVC coordinates. The dist is always zero if the point x[3]
		/// is inside the polyhedron; otherwise it's the distance to the surface.
		/// </summary>
		// Token: 0x0601CA4C RID: 117324 RVA: 0x0028450C File Offset: 0x0028270C
		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkPolyhedron.vtkPolyhedron_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601CA4D RID: 117325
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyhedron_GetCellType_07(HandleRef pThis);

		/// <summary>
		/// See the vtkCell API for descriptions of these methods.
		/// </summary>
		// Token: 0x0601CA4E RID: 117326 RVA: 0x00284534 File Offset: 0x00282734
		public override int GetCellType()
		{
			return vtkPolyhedron.vtkPolyhedron_GetCellType_07(base.GetCppThis());
		}

		// Token: 0x0601CA4F RID: 117327
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolyhedron_GetCentroid_08(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// See vtkCell3D API for description of these methods.
		/// @warning These method are unimplemented in vtkPolyhedron
		/// </summary>
		// Token: 0x0601CA50 RID: 117328 RVA: 0x00284554 File Offset: 0x00282754
		public override bool GetCentroid(IntPtr arg0)
		{
			return vtkPolyhedron.vtkPolyhedron_GetCentroid_08(base.GetCppThis(), arg0) != 0;
		}

		// Token: 0x0601CA51 RID: 117329
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyhedron_GetEdge_09(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// A polyhedron is represented internally by a set of polygonal faces.
		/// These faces can be processed to explicitly determine edges.
		/// </summary>
		// Token: 0x0601CA52 RID: 117330 RVA: 0x0028457C File Offset: 0x0028277C
		public override vtkCell GetEdge(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyhedron.vtkPolyhedron_GetEdge_09(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCell = (vtkCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCell.Register(null);
				}
			}
			return vtkCell;
		}

		// Token: 0x0601CA53 RID: 117331
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyhedron_GetFace_10(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// A polyhedron is represented internally by a set of polygonal faces.
		/// These faces can be processed to explicitly determine edges.
		/// </summary>
		// Token: 0x0601CA54 RID: 117332 RVA: 0x002845EC File Offset: 0x002827EC
		public override vtkCell GetFace(int faceId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyhedron.vtkPolyhedron_GetFace_10(base.GetCppThis(), faceId, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCell = (vtkCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCell.Register(null);
				}
			}
			return vtkCell;
		}

		// Token: 0x0601CA55 RID: 117333
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyhedron_GetFaces_11(HandleRef pThis);

		/// <summary>
		/// Get the faces of the polyhedron.
		/// Face are expressed as sequences of &lt;b&gt; global point IDs &lt;/b&gt;.
		///
		/// @return A 1-dimentional array with the following structure :
		/// ```
		/// [ NbOfPtsFace1, face1Pt1, face1Pt2, …, face1PtNbOfPtsFace1,
		///   NbOfPtsFace2, face2Pt1, face2Pt2, …, face2PtNbOfPtsFace2,
		///   …,
		///   NbOfPtsFaceN, faceNPt1, faceNPt2, …, faceNPtNbOfPtsFaceN ]
		/// ```
		/// This ordering corresponds to the legacy vtkCellArray form.
		/// Note that unlike the SetFaces method, the total faces number leading
		/// count is missing. In order to get the number of faces, please use the
		/// vtkPolyhedron::GetNumberOfFaces() method.
		/// </summary>
		// Token: 0x0601CA56 RID: 117334 RVA: 0x0028465C File Offset: 0x0028285C
		public override IntPtr GetFaces()
		{
			return vtkPolyhedron.vtkPolyhedron_GetFaces_11(base.GetCppThis());
		}

		// Token: 0x0601CA57 RID: 117335
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyhedron_GetNumberOfEdges_12(HandleRef pThis);

		/// <summary>
		/// A polyhedron is represented internally by a set of polygonal faces.
		/// These faces can be processed to explicitly determine edges.
		/// </summary>
		// Token: 0x0601CA58 RID: 117336 RVA: 0x0028467C File Offset: 0x0028287C
		public override int GetNumberOfEdges()
		{
			return vtkPolyhedron.vtkPolyhedron_GetNumberOfEdges_12(base.GetCppThis());
		}

		// Token: 0x0601CA59 RID: 117337
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyhedron_GetNumberOfFaces_13(HandleRef pThis);

		/// <summary>
		/// A polyhedron is represented internally by a set of polygonal faces.
		/// These faces can be processed to explicitly determine edges.
		/// </summary>
		// Token: 0x0601CA5A RID: 117338 RVA: 0x0028469C File Offset: 0x0028289C
		public override int GetNumberOfFaces()
		{
			return vtkPolyhedron.vtkPolyhedron_GetNumberOfFaces_13(base.GetCppThis());
		}

		// Token: 0x0601CA5B RID: 117339
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyhedron_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard new methods.
		/// </summary>
		// Token: 0x0601CA5C RID: 117340 RVA: 0x002846BC File Offset: 0x002828BC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolyhedron.vtkPolyhedron_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x0601CA5D RID: 117341
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyhedron_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard new methods.
		/// </summary>
		// Token: 0x0601CA5E RID: 117342 RVA: 0x002846DC File Offset: 0x002828DC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolyhedron.vtkPolyhedron_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x0601CA5F RID: 117343
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyhedron_GetParametricCenter_16(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the center of the cell in parametric coordinates. In this cell,
		/// the center of the bounding box is returned.
		/// </summary>
		// Token: 0x0601CA60 RID: 117344 RVA: 0x002846F8 File Offset: 0x002828F8
		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkPolyhedron.vtkPolyhedron_GetParametricCenter_16(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601CA61 RID: 117345
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyhedron_GetParametricCoords_17(HandleRef pThis);

		/// <summary>
		/// See vtkCell3D API for description of this method.
		/// </summary>
		// Token: 0x0601CA62 RID: 117346 RVA: 0x00284718 File Offset: 0x00282918
		public override IntPtr GetParametricCoords()
		{
			return vtkPolyhedron.vtkPolyhedron_GetParametricCoords_17(base.GetCppThis());
		}

		// Token: 0x0601CA63 RID: 117347
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyhedron_GetPolyData_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct polydata if no one exist, then return this-&gt;PolyData
		/// </summary>
		// Token: 0x0601CA64 RID: 117348 RVA: 0x00284738 File Offset: 0x00282938
		public vtkPolyData GetPolyData()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyhedron.vtkPolyhedron_GetPolyData_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x0601CA65 RID: 117349
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyhedron_Initialize_19(HandleRef pThis);

		/// <summary>
		/// The Initialize method builds up internal structures of vtkPolyhedron.
		/// @warning This method should be called after setting the point coordinates,
		/// point IDs and faces of the polyhedron in order to finalize its construction.
		/// </summary>
		// Token: 0x0601CA66 RID: 117350 RVA: 0x002847A7 File Offset: 0x002829A7
		public override void Initialize()
		{
			vtkPolyhedron.vtkPolyhedron_Initialize_19(base.GetCppThis());
		}

		// Token: 0x0601CA67 RID: 117351
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyhedron_InterpolateDerivs_20(HandleRef pThis, IntPtr x, IntPtr derivs);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives). Here we use the MVC calculation
		/// process to compute the interpolation functions.
		/// </summary>
		// Token: 0x0601CA68 RID: 117352 RVA: 0x002847B6 File Offset: 0x002829B6
		public override void InterpolateDerivs(IntPtr x, IntPtr derivs)
		{
			vtkPolyhedron.vtkPolyhedron_InterpolateDerivs_20(base.GetCppThis(), x, derivs);
		}

		// Token: 0x0601CA69 RID: 117353
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyhedron_InterpolateFunctions_21(HandleRef pThis, IntPtr x, IntPtr sf);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives). Here we use the MVC calculation
		/// process to compute the interpolation functions.
		/// </summary>
		// Token: 0x0601CA6A RID: 117354 RVA: 0x002847C7 File Offset: 0x002829C7
		public override void InterpolateFunctions(IntPtr x, IntPtr sf)
		{
			vtkPolyhedron.vtkPolyhedron_InterpolateFunctions_21(base.GetCppThis(), x, sf);
		}

		// Token: 0x0601CA6B RID: 117355
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyhedron_IntersectWithLine_22(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// Intersect the line (p1,p2) with a given tolerance tol to determine a
		/// point of intersection x[3] with parametric coordinate t along the
		/// line. The parametric coordinates are returned as well (subId can be
		/// ignored). Returns true if the line intersects a face.
		/// </summary>
		// Token: 0x0601CA6C RID: 117356 RVA: 0x002847D8 File Offset: 0x002829D8
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkPolyhedron.vtkPolyhedron_IntersectWithLine_22(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601CA6D RID: 117357
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyhedron_IsA_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard new methods.
		/// </summary>
		// Token: 0x0601CA6E RID: 117358 RVA: 0x00284804 File Offset: 0x00282A04
		public override int IsA(string type)
		{
			return vtkPolyhedron.vtkPolyhedron_IsA_23(base.GetCppThis(), type);
		}

		// Token: 0x0601CA6F RID: 117359
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolyhedron_IsConvex_24(HandleRef pThis);

		/// <summary>
		/// Determine whether or not a polyhedron is convex. This method is adapted
		/// from Devillers et al., "Checking the Convexity of Polytopes and the
		/// Planarity of Subdivisions", Computational Geometry, Volume 11, Issues
		/// 3 - 4, December 1998, Pages 187 - 208.
		/// </summary>
		// Token: 0x0601CA70 RID: 117360 RVA: 0x00284824 File Offset: 0x00282A24
		public bool IsConvex()
		{
			return vtkPolyhedron.vtkPolyhedron_IsConvex_24(base.GetCppThis()) != 0;
		}

		// Token: 0x0601CA71 RID: 117361
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyhedron_IsInside_25(HandleRef pThis, IntPtr x, double tolerance);

		/// <summary>
		/// A method particular to vtkPolyhedron. It determines whether a point x[3]
		/// is inside the polyhedron or not (returns 1 is the point is inside, 0
		/// otherwise). The tolerance is expressed in normalized space; i.e., a
		/// fraction of the size of the bounding box.
		/// </summary>
		// Token: 0x0601CA72 RID: 117362 RVA: 0x0028484C File Offset: 0x00282A4C
		public int IsInside(IntPtr x, double tolerance)
		{
			return vtkPolyhedron.vtkPolyhedron_IsInside_25(base.GetCppThis(), x, tolerance);
		}

		// Token: 0x0601CA73 RID: 117363
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyhedron_IsPrimaryCell_26(HandleRef pThis);

		/// <summary>
		/// A polyhedron is a full-fledged primary cell.
		/// </summary>
		// Token: 0x0601CA74 RID: 117364 RVA: 0x00284870 File Offset: 0x00282A70
		public override int IsPrimaryCell()
		{
			return vtkPolyhedron.vtkPolyhedron_IsPrimaryCell_26(base.GetCppThis());
		}

		// Token: 0x0601CA75 RID: 117365
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyhedron_IsTypeOf_27([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard new methods.
		/// </summary>
		// Token: 0x0601CA76 RID: 117366 RVA: 0x00284890 File Offset: 0x00282A90
		public new static int IsTypeOf(string type)
		{
			return vtkPolyhedron.vtkPolyhedron_IsTypeOf_27(type);
		}

		// Token: 0x0601CA77 RID: 117367
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyhedron_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard new methods.
		/// </summary>
		// Token: 0x0601CA78 RID: 117368 RVA: 0x002848AC File Offset: 0x00282AAC
		public new vtkPolyhedron NewInstance()
		{
			vtkPolyhedron result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyhedron.vtkPolyhedron_NewInstance_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyhedron)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601CA79 RID: 117369
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyhedron_RequiresExplicitFaceRepresentation_30(HandleRef pThis);

		/// <summary>
		/// Satisfy the vtkCell API. Always return true, because vtkPolyhedron
		/// needs explicit faces definition in order to describe the topology
		/// of the cell.
		/// </summary>
		// Token: 0x0601CA7A RID: 117370 RVA: 0x00284908 File Offset: 0x00282B08
		public override int RequiresExplicitFaceRepresentation()
		{
			return vtkPolyhedron.vtkPolyhedron_RequiresExplicitFaceRepresentation_30(base.GetCppThis());
		}

		// Token: 0x0601CA7B RID: 117371
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyhedron_RequiresInitialization_31(HandleRef pThis);

		/// <summary>
		/// This cell requires that it be initialized prior to access.
		/// </summary>
		// Token: 0x0601CA7C RID: 117372 RVA: 0x00284928 File Offset: 0x00282B28
		public override int RequiresInitialization()
		{
			return vtkPolyhedron.vtkPolyhedron_RequiresInitialization_31(base.GetCppThis());
		}

		// Token: 0x0601CA7D RID: 117373
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyhedron_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard new methods.
		/// </summary>
		// Token: 0x0601CA7E RID: 117374 RVA: 0x00284948 File Offset: 0x00282B48
		public new static vtkPolyhedron SafeDownCast(vtkObjectBase o)
		{
			vtkPolyhedron vtkPolyhedron = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyhedron.vtkPolyhedron_SafeDownCast_32((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyhedron = (vtkPolyhedron)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyhedron.Register(null);
				}
			}
			return vtkPolyhedron;
		}

		// Token: 0x0601CA7F RID: 117375
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyhedron_SetFaces_33(HandleRef pThis, IntPtr faces);

		/// <summary>
		/// Set the faces of the polyhedron.
		/// Face are expressed as sequences of &lt;b&gt; global point IDs &lt;/b&gt;.
		///
		/// @param faces 1-dimensional array with the following structure :
		/// ```
		/// [ NbOfFaces,
		///   NbOfPtsFace1, face1Pt1, face1Pt2, …, face1PtNbOfPtsFace1,
		///   NbOfPtsFace2, face2Pt1, face2Pt2, …, face2PtNbOfPtsFace2,
		///   …,
		///   NbOfPtsFaceN, faceNPt1, faceNPt2, …, faceNPtNbOfPtsFaceN ]
		/// ```
		/// This ordering corresponds to the legacy vtkCellArray form, with in
		/// addition a leading count indicating the total number of faces in
		/// the list.
		/// </summary>
		// Token: 0x0601CA80 RID: 117376 RVA: 0x002849C7 File Offset: 0x00282BC7
		public override void SetFaces(IntPtr faces)
		{
			vtkPolyhedron.vtkPolyhedron_SetFaces_33(base.GetCppThis(), faces);
		}

		// Token: 0x0601CA81 RID: 117377
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyhedron_TriangulateFaces_34(HandleRef pThis, HandleRef newFaces);

		/// <summary>
		/// Triangulate each face of the polyhedron.
		/// This method internally use the vtkCell::Triangulate method on each face (so the
		/// triangulation method vary depending on the 2D cell type corresponding to the face).
		/// @warning Can lead to bad results with non-planar faces.
		/// </summary>
		// Token: 0x0601CA82 RID: 117378 RVA: 0x002849D8 File Offset: 0x00282BD8
		public int TriangulateFaces(vtkIdList newFaces)
		{
			return vtkPolyhedron.vtkPolyhedron_TriangulateFaces_34(base.GetCppThis(), (newFaces == null) ? default(HandleRef) : newFaces.GetCppThis());
		}

		// Token: 0x0601CA83 RID: 117379
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyhedron_TriangulateLocalIds_35(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// Use vtkOrderedTriangulator to tetrahedralize the polyhedron mesh.
		/// Once triangulation has been performed, the results are saved in ptIds and
		/// pts. The ptIds is a vtkIdList with 4xn number of ids (n is the number of
		/// result tetrahedrons). The first 4 represent the point ids of the first
		/// tetrahedron, the second 4 represents the point ids of the second tetrahedron
		/// and so on. The point ids represent global dataset ids.
		/// The points of result tetrahedons are stored in pts. Note that there are
		/// 4xm output points (m is the number of points in the original polyhedron).
		/// A point may be stored multiple times when it is shared by more than one
		/// tetrahedrons. The points stored in pts are ordered the same as they are
		/// listed in ptIds.
		/// @warning This method works well for a convex polyhedron but may return
		/// wrong result in a concave case.
		/// </summary>
		// Token: 0x0601CA84 RID: 117380 RVA: 0x00284A0C File Offset: 0x00282C0C
		public override int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkPolyhedron.vtkPolyhedron_TriangulateLocalIds_35(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E57 RID: 7767
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyhedron";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E58 RID: 7768
		public new static readonly string MRClassNameKey = "class vtkPolyhedron";
	}
}
