using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGenericAdaptorCell
	/// </summary>
	/// <remarks>
	///    defines cell interface
	///
	/// In VTK, spatial-temporal data is defined in terms of a dataset which is
	/// composed of cells. The cells are topological entities over which an
	/// interpolation field is applied. Cells are defined in terms of a topology
	/// (e.g., vertices, lines, triangles, polygons, tetrahedra, etc.), points
	/// that instantiate the geometry of the cells, and interpolation fields
	/// (in the general case one interpolation field is for geometry, the other
	/// is for attribute data associated with the cell).
	///
	/// Currently most algorithms in VTK use vtkCell and vtkDataSet, which make
	/// assumptions about the nature of datasets, cells, and attributes. In
	/// particular, this abstraction assumes that cell interpolation functions
	/// are linear, or products of linear functions. Further, VTK implements
	/// most of the interpolation functions. This implementation starts breaking
	/// down as the complexity of the interpolation (or basis) functions
	/// increases.
	///
	/// vtkGenericAdaptorCell addresses these issues by providing more general
	/// abstraction for cells. It also adopts modern C++ practices including using
	/// iterators. The vtkGenericAdaptorCell is designed to fit within the adaptor
	/// framework; meaning that it is meant to adapt VTK to external simulation
	/// systems (see the GenericFiltering/README.html).
	///
	/// Please note that most cells are defined in terms of other cells (the
	/// boundary cells). They are also defined in terms of points, which are
	/// not the same as vertices (vertices are a 0-D cell; points represent a
	/// position in space).
	///
	/// Another important concept is the notion of DOFNodes. These concept
	/// supports cell types with complex interpolation functions. For example,
	/// higher-order p-method finite elements may have different functions on each
	/// of their topological features (edges, faces, region). The coefficients of
	/// these polynomial functions are associated with DOFNodes. (There is a
	/// single DOFNode for each topological feature.) Note that from this
	/// perspective, points are used to establish the topological form of the
	/// cell; mid-side nodes and such are considered DOFNodes.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGenericDataSet
	/// </seealso>
	// Token: 0x02000A49 RID: 2633
	public abstract class vtkGenericAdaptorCell : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B71E RID: 112414 RVA: 0x00266727 File Offset: 0x00264927
		static vtkGenericAdaptorCell()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericAdaptorCell.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericAdaptorCell"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B71F RID: 112415 RVA: 0x0026674F File Offset: 0x0026494F
		public vtkGenericAdaptorCell(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B720 RID: 112416 RVA: 0x0026675D File Offset: 0x0026495D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B721 RID: 112417
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericAdaptorCell_Clip_01(HandleRef pThis, double value, HandleRef f, HandleRef attributes, HandleRef tess, int insideOut, HandleRef locator, HandleRef connectivity, HandleRef outPd, HandleRef outCd, HandleRef internalPd, HandleRef secondaryPd, HandleRef secondaryCd);

		/// <summary>
		/// Cut (or clip) the current cell with respect to the contour defined by
		/// the `value' or the implicit function `f' of the scalar attribute
		/// (`attributes-&gt;GetActiveAttribute()',`attributes-&gt;GetActiveComponent()').
		/// If `f' exists, `value' is not used. The output is the part of the
		/// current cell which is inside the contour.  The output is a set of zero,
		/// one or more cells of the same topological dimension as the current
		/// cell. Normally, cell points whose scalar value is greater than "value"
		/// are considered inside. If `insideOut' is on, this is reversed.  Clipping
		/// interpolates the `attributes-&gt;GetNumberOfattributesToInterpolate()'
		/// attributes `attributes-&gt;GetAttributesToInterpolate()'.  `locator',
		/// `connectivity', `outPd' and `outCd' are cumulative data arrays over cell
		/// iterations: they store the result of each call to Clip():
		/// - `locator' is a points list that merges points as they are inserted
		/// (i.e., prevents duplicates).
		/// - `connectivity' is an array of generated cells
		/// - `outPd' is an array of interpolated point data along the edge (if
		/// not-nullptr)
		/// - `outCd' is an array of copied cell data of the current cell (if
		/// not-nullptr)
		/// `internalPd', `secondaryPd' and `secondaryCd' are initialized by the
		/// filter that call it from `attributes'.
		/// - `internalPd' stores the result of the tessellation pass: the
		/// higher-order cell is tessellated into linear sub-cells.
		/// - `secondaryPd' and `secondaryCd' are used internally as inputs to the
		/// Clip() method on linear sub-cells.
		/// Note: the CopyAllocate() method must be invoked on both `outPd' and
		/// `outCd', from `secondaryPd' and `secondaryCd'.
		///
		/// NOTE: `vtkGenericAttributeCollection *attributes' will be replaced by a
		/// `vtkInformation'.
		///
		/// \pre attributes_exist: attributes!=0
		/// \pre tessellator_exists: tess!=0
		/// \pre locator_exists: locator!=0
		/// \pre connectivity_exists: connectivity!=0
		/// \pre internalPd_exists: internalPd!=0
		/// \pre secondaryPd_exists: secondaryPd!=0
		/// \pre secondaryCd_exists: secondaryCd!=0
		/// </summary>
		// Token: 0x0601B722 RID: 112418 RVA: 0x00266768 File Offset: 0x00264968
		public virtual void Clip(double value, vtkImplicitFunction f, vtkGenericAttributeCollection attributes, vtkGenericCellTessellator tess, int insideOut, vtkIncrementalPointLocator locator, vtkCellArray connectivity, vtkPointData outPd, vtkCellData outCd, vtkPointData internalPd, vtkPointData secondaryPd, vtkCellData secondaryCd)
		{
			vtkGenericAdaptorCell.vtkGenericAdaptorCell_Clip_01(base.GetCppThis(), value, (f == null) ? default(HandleRef) : f.GetCppThis(), (attributes == null) ? default(HandleRef) : attributes.GetCppThis(), (tess == null) ? default(HandleRef) : tess.GetCppThis(), insideOut, (locator == null) ? default(HandleRef) : locator.GetCppThis(), (connectivity == null) ? default(HandleRef) : connectivity.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), (internalPd == null) ? default(HandleRef) : internalPd.GetCppThis(), (secondaryPd == null) ? default(HandleRef) : secondaryPd.GetCppThis(), (secondaryCd == null) ? default(HandleRef) : secondaryCd.GetCppThis());
		}

		// Token: 0x0601B723 RID: 112419
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericAdaptorCell_Contour_02(HandleRef pThis, HandleRef values, HandleRef f, HandleRef attributes, HandleRef tess, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef outPd, HandleRef outCd, HandleRef internalPd, HandleRef secondaryPd, HandleRef secondaryCd);

		/// <summary>
		/// Generate a contour (contouring primitives) for each `values' or with
		/// respect to an implicit function `f'. Contouring is performed on the
		/// scalar attribute (`attributes-&gt;GetActiveAttribute()'
		/// `attributes-&gt;GetActiveComponent()').  Contouring interpolates the
		/// `attributes-&gt;GetNumberOfattributesToInterpolate()' attributes
		/// `attributes-&gt;GetAttributesToInterpolate()'.  The `locator', `verts',
		/// `lines', `polys', `outPd' and `outCd' are cumulative data arrays over
		/// cell iterations: they store the result of each call to Contour():
		/// - `locator' is a points list that merges points as they are inserted
		/// (i.e., prevents duplicates).
		/// - `verts' is an array of generated vertices
		/// - `lines' is an array of generated lines
		/// - `polys' is an array of generated polygons
		/// - `outPd' is an array of interpolated point data along the edge (if
		/// not-nullptr)
		/// - `outCd' is an array of copied cell data of the current cell (if
		/// not-nullptr)
		/// `internalPd', `secondaryPd' and `secondaryCd' are initialized by the
		/// filter that call it from `attributes'.
		/// - `internalPd' stores the result of the tessellation pass: the
		/// higher-order cell is tessellated into linear sub-cells.
		/// - `secondaryPd' and `secondaryCd' are used internally as inputs to the
		/// Contour() method on linear sub-cells.
		/// Note: the CopyAllocate() method must be invoked on both `outPd' and
		/// `outCd', from `secondaryPd' and `secondaryCd'.
		///
		/// NOTE: `vtkGenericAttributeCollection *attributes' will be replaced by a
		/// `vtkInformation'.
		///
		/// \pre values_exist: (values!=0 &amp;&amp; f==0) || (values==0 &amp;&amp; f!=0)
		/// \pre attributes_exist: attributes!=0
		/// \pre tessellator_exists: tess!=0
		/// \pre locator_exists: locator!=0
		/// \pre verts_exist: verts!=0
		/// \pre lines_exist: lines!=0
		/// \pre polys_exist: polys!=0
		/// \pre internalPd_exists: internalPd!=0
		/// \pre secondaryPd_exists: secondaryPd!=0
		/// \pre secondaryCd_exists: secondaryCd!=0
		/// </summary>
		// Token: 0x0601B724 RID: 112420 RVA: 0x00266868 File Offset: 0x00264A68
		public virtual void Contour(vtkContourValues values, vtkImplicitFunction f, vtkGenericAttributeCollection attributes, vtkGenericCellTessellator tess, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData outPd, vtkCellData outCd, vtkPointData internalPd, vtkPointData secondaryPd, vtkCellData secondaryCd)
		{
			vtkGenericAdaptorCell.vtkGenericAdaptorCell_Contour_02(base.GetCppThis(), (values == null) ? default(HandleRef) : values.GetCppThis(), (f == null) ? default(HandleRef) : f.GetCppThis(), (attributes == null) ? default(HandleRef) : attributes.GetCppThis(), (tess == null) ? default(HandleRef) : tess.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), (internalPd == null) ? default(HandleRef) : internalPd.GetCppThis(), (secondaryPd == null) ? default(HandleRef) : secondaryPd.GetCppThis(), (secondaryCd == null) ? default(HandleRef) : secondaryCd.GetCppThis());
		}

		// Token: 0x0601B725 RID: 112421
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericAdaptorCell_CountEdgeNeighbors_03(HandleRef pThis, IntPtr sharing);

		/// <summary>
		/// Number of cells (dimension&gt;boundary-&gt;GetDimension()) of the dataset
		/// that share the boundary `boundary' of `this'.
		/// `this' IS NOT INCLUDED.
		/// \pre boundary_exists: boundary!=0
		/// \pre real_boundary: !boundary-&gt;IsInDataSet()
		/// \pre cell_of_the_dataset: IsInDataSet()
		/// \pre boundary: HasBoundary(boundary)
		/// \post positive_result: result&gt;=0
		/// </summary>
		// Token: 0x0601B726 RID: 112422 RVA: 0x002669A7 File Offset: 0x00264BA7
		public virtual void CountEdgeNeighbors(IntPtr sharing)
		{
			vtkGenericAdaptorCell.vtkGenericAdaptorCell_CountEdgeNeighbors_03(base.GetCppThis(), sharing);
		}

		// Token: 0x0601B727 RID: 112423
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAdaptorCell_CountNeighbors_04(HandleRef pThis, HandleRef boundary);

		/// <summary>
		/// Number of cells (dimension&gt;boundary-&gt;GetDimension()) of the dataset
		/// that share the boundary `boundary' of `this'.
		/// `this' IS NOT INCLUDED.
		/// \pre boundary_exists: boundary!=0
		/// \pre real_boundary: !boundary-&gt;IsInDataSet()
		/// \pre cell_of_the_dataset: IsInDataSet()
		/// \pre boundary: HasBoundary(boundary)
		/// \post positive_result: result&gt;=0
		/// </summary>
		// Token: 0x0601B728 RID: 112424 RVA: 0x002669B8 File Offset: 0x00264BB8
		public virtual int CountNeighbors(vtkGenericAdaptorCell boundary)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_CountNeighbors_04(base.GetCppThis(), (boundary == null) ? default(HandleRef) : boundary.GetCppThis());
		}

		// Token: 0x0601B729 RID: 112425
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericAdaptorCell_Derivatives_05(HandleRef pThis, int subId, IntPtr pcoords, HandleRef attribute, IntPtr derivs);

		/// <summary>
		/// Compute derivatives `derivs' of the attribute `attribute' (from its
		/// values at the corner points of the cell) given sub-cell `subId' (0 means
		/// primary cell) and parametric coordinates `pcoords'.
		/// Derivatives are in the x-y-z coordinate directions for each data value.
		/// \pre positive_subId: subId&gt;=0
		/// \pre clamped_pcoords: (0&lt;=pcoords[0])&amp;&amp;(pcoords[0]&lt;=1)&amp;&amp;(0&lt;=pcoords[1])
		/// &amp;&amp;(pcoords[1]&lt;=1)&amp;&amp;(0&lt;=pcoords[2])%%(pcoords[2]&lt;=1)
		/// \pre attribute_exists: attribute!=0
		/// \pre derivs_exists: derivs!=0
		/// \pre valid_size: sizeof(derivs)&gt;=attribute-&gt;GetNumberOfComponents()*3
		/// </summary>
		// Token: 0x0601B72A RID: 112426 RVA: 0x002669EC File Offset: 0x00264BEC
		public virtual void Derivatives(int subId, IntPtr pcoords, vtkGenericAttribute attribute, IntPtr derivs)
		{
			vtkGenericAdaptorCell.vtkGenericAdaptorCell_Derivatives_05(base.GetCppThis(), subId, pcoords, (attribute == null) ? default(HandleRef) : attribute.GetCppThis(), derivs);
		}

		// Token: 0x0601B72B RID: 112427
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericAdaptorCell_EvaluateLocation_06(HandleRef pThis, int subId, IntPtr pcoords, IntPtr x);

		/// <summary>
		/// Determine the global coordinates `x' from sub-cell `subId' and parametric
		/// coordinates `pcoords' in the cell.
		/// \pre positive_subId: subId&gt;=0
		/// \pre clamped_pcoords: (0&lt;=pcoords[0])&amp;&amp;(pcoords[0]&lt;=1)&amp;&amp;(0&lt;=pcoords[1])
		/// &amp;&amp;(pcoords[1]&lt;=1)&amp;&amp;(0&lt;=pcoords[2])&amp;&amp;(pcoords[2]&lt;=1)
		/// </summary>
		// Token: 0x0601B72C RID: 112428 RVA: 0x00266A1F File Offset: 0x00264C1F
		public virtual void EvaluateLocation(int subId, IntPtr pcoords, IntPtr x)
		{
			vtkGenericAdaptorCell.vtkGenericAdaptorCell_EvaluateLocation_06(base.GetCppThis(), subId, pcoords, x);
		}

		// Token: 0x0601B72D RID: 112429
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAdaptorCell_EvaluatePosition_07(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2);

		/// <summary>
		/// Is `x' inside the current cell? It also evaluates parametric coordinates
		/// `pcoords', sub-cell id `subId' (0 means primary cell), distance squared
		/// to the sub-cell in `dist2' and closest corner point `closestPoint'.
		/// `dist2' and `closestPoint' are not evaluated if `closestPoint'==0.
		/// If a numerical error occurred, -1 is returned and all other results
		/// should be ignored.
		/// \post valid_result: result==-1 || result==0 || result==1
		/// \post positive_distance: result!=-1 implies (closestPoint!=0 implies
		/// dist2&gt;=0)
		/// </summary>
		// Token: 0x0601B72E RID: 112430 RVA: 0x00266A34 File Offset: 0x00264C34
		public virtual int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_EvaluatePosition_07(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2);
		}

		// Token: 0x0601B72F RID: 112431
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAdaptorCell_FindClosestBoundary_08(HandleRef pThis, int subId, IntPtr pcoords, HandleRef boundary);

		/// <summary>
		/// Compute the closest boundary of the current sub-cell `subId' for point
		/// `pcoord' (in parametric coordinates) in `boundary', and return whether
		/// the point is inside the cell or not. `boundary' is of dimension
		/// GetDimension()-1.
		/// \pre positive_subId: subId&gt;=0
		/// </summary>
		// Token: 0x0601B730 RID: 112432 RVA: 0x00266A5C File Offset: 0x00264C5C
		public virtual int FindClosestBoundary(int subId, IntPtr pcoords, vtkGenericCellIterator boundary)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_FindClosestBoundary_08(base.GetCppThis(), subId, pcoords, (boundary == null) ? default(HandleRef) : boundary.GetCppThis());
		}

		// Token: 0x0601B731 RID: 112433
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAdaptorCell_GetAttributeOrder_09(HandleRef pThis, HandleRef a);

		/// <summary>
		/// Return the interpolation order of attribute `a' on the cell
		/// (may differ by cell).
		/// \pre a_exists: a!=0
		/// \post positive_result: result&gt;=0
		/// </summary>
		// Token: 0x0601B732 RID: 112434 RVA: 0x00266A94 File Offset: 0x00264C94
		public virtual int GetAttributeOrder(vtkGenericAttribute a)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetAttributeOrder_09(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		// Token: 0x0601B733 RID: 112435
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericAdaptorCell_GetBoundaryIterator_10(HandleRef pThis, HandleRef boundaries, int dim);

		/// <summary>
		/// Return the `boundaries' cells of dimension `dim' (or all dimensions
		/// less than GetDimension() if -1) that are part of the boundary of the cell.
		/// \pre valid_dim_range: (dim==-1) || ((dim&gt;=0)&amp;&amp;(dim&lt;GetDimension()))
		/// \pre boundaries_exist: boundaries!=0
		/// </summary>
		// Token: 0x0601B734 RID: 112436 RVA: 0x00266AC8 File Offset: 0x00264CC8
		public virtual void GetBoundaryIterator(vtkGenericCellIterator boundaries, int dim)
		{
			vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetBoundaryIterator_10(base.GetCppThis(), (boundaries == null) ? default(HandleRef) : boundaries.GetCppThis(), dim);
		}

		// Token: 0x0601B735 RID: 112437
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericAdaptorCell_GetBounds_11(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Compute the bounding box of the current cell in `bounds' in global
		/// coordinates.
		/// THREAD SAFE
		/// </summary>
		// Token: 0x0601B736 RID: 112438 RVA: 0x00266AF8 File Offset: 0x00264CF8
		public virtual void GetBounds(IntPtr bounds)
		{
			vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetBounds_11(base.GetCppThis(), bounds);
		}

		// Token: 0x0601B737 RID: 112439
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericAdaptorCell_GetBounds_12(HandleRef pThis);

		/// <summary>
		/// Return the bounding box of the current cell in global coordinates.
		/// NOT THREAD SAFE
		/// \post result_exists: result!=0
		/// \post valid_size: sizeof(result)&gt;=6
		/// </summary>
		// Token: 0x0601B738 RID: 112440 RVA: 0x00266B08 File Offset: 0x00264D08
		public virtual IntPtr GetBounds()
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetBounds_12(base.GetCppThis());
		}

		// Token: 0x0601B739 RID: 112441
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAdaptorCell_GetDimension_13(HandleRef pThis);

		/// <summary>
		/// Return the topological dimension of the current cell.
		/// \post valid_result: result&gt;=0 &amp;&amp; result&lt;=3
		/// </summary>
		// Token: 0x0601B73A RID: 112442 RVA: 0x00266B28 File Offset: 0x00264D28
		public virtual int GetDimension()
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetDimension_13(base.GetCppThis());
		}

		// Token: 0x0601B73B RID: 112443
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericAdaptorCell_GetEdgeArray_14(HandleRef pThis, long edgeId);

		/// <summary>
		/// Return the ids of the vertices defining edge `edgeId'.
		/// Ids are related to the cell, not to the dataset.
		/// \pre valid_dimension: this-&gt;GetDimension()&gt;=2
		/// \pre valid_edgeId_range: edgeId&gt;=0 &amp;&amp; edgeId&lt;this-&gt;GetNumberOfBoundaries(1)
		/// \post result_exists: result!=0
		/// \post valid_size: sizeof(result)==2
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints.
		/// </summary>
		// Token: 0x0601B73C RID: 112444 RVA: 0x00266B48 File Offset: 0x00264D48
		public virtual IntPtr GetEdgeArray(long edgeId)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetEdgeArray_14(base.GetCppThis(), edgeId);
		}

		// Token: 0x0601B73D RID: 112445
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericAdaptorCell_GetFaceArray_15(HandleRef pThis, long faceId);

		/// <summary>
		/// Return the ids of the vertices defining face `faceId'.
		/// Ids are related to the cell, not to the dataset.
		/// \pre is_3d: this-&gt;GetDimension()==3
		/// \pre valid_faceId_range: faceId&gt;=0 &amp;&amp; faceId&lt;this-&gt;GetNumberOfBoundaries(2)
		/// \post result_exists: result!=0
		/// \post valid_size: sizeof(result)&gt;=GetNumberOfVerticesOnFace(faceId)
		///
		/// @note The return type changed. It used to be int*, it is now const vtkIdType*.
		/// This is so ids are unified between vtkCell and vtkPoints, and so vtkCell ids
		/// can be used as inputs in algorithms such as vtkPolygon::ComputeNormal.
		/// </summary>
		// Token: 0x0601B73E RID: 112446 RVA: 0x00266B68 File Offset: 0x00264D68
		public virtual IntPtr GetFaceArray(long faceId)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetFaceArray_15(base.GetCppThis(), faceId);
		}

		// Token: 0x0601B73F RID: 112447
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAdaptorCell_GetGeometryOrder_16(HandleRef pThis);

		/// <summary>
		/// Return the interpolation order of the geometry.
		/// \post positive_result: result&gt;=0
		/// </summary>
		// Token: 0x0601B740 RID: 112448 RVA: 0x00266B88 File Offset: 0x00264D88
		public virtual int GetGeometryOrder()
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetGeometryOrder_16(base.GetCppThis());
		}

		// Token: 0x0601B741 RID: 112449
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAdaptorCell_GetHighestOrderAttribute_17(HandleRef pThis, HandleRef ac);

		/// <summary>
		/// Return the index of the first point centered attribute with the highest
		/// order in `ac'.
		/// \pre ac_exists: ac!=0
		/// \post valid_result: result&gt;=-1 &amp;&amp; result&lt;ac-&gt;GetNumberOfAttributes()
		/// </summary>
		// Token: 0x0601B742 RID: 112450 RVA: 0x00266BA8 File Offset: 0x00264DA8
		public virtual int GetHighestOrderAttribute(vtkGenericAttributeCollection ac)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetHighestOrderAttribute_17(base.GetCppThis(), (ac == null) ? default(HandleRef) : ac.GetCppThis());
		}

		// Token: 0x0601B743 RID: 112451
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericAdaptorCell_GetId_18(HandleRef pThis);

		/// <summary>
		/// Unique identification number of the cell over the whole
		/// data set. This unique key may not be contiguous.
		/// </summary>
		// Token: 0x0601B744 RID: 112452 RVA: 0x00266BDC File Offset: 0x00264DDC
		public virtual long GetId()
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetId_18(base.GetCppThis());
		}

		// Token: 0x0601B745 RID: 112453
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGenericAdaptorCell_GetLength2_19(HandleRef pThis);

		/// <summary>
		/// Return the bounding box diagonal squared of the current cell.
		/// \post positive_result: result&gt;=0
		/// </summary>
		// Token: 0x0601B746 RID: 112454 RVA: 0x00266BFC File Offset: 0x00264DFC
		public virtual double GetLength2()
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetLength2_19(base.GetCppThis());
		}

		// Token: 0x0601B747 RID: 112455
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericAdaptorCell_GetNeighbors_20(HandleRef pThis, HandleRef boundary, HandleRef neighbors);

		/// <summary>
		/// Put into `neighbors' the cells (dimension&gt;boundary-&gt;GetDimension())
		/// of the dataset that share the boundary `boundary' with this cell.
		/// `this' IS NOT INCLUDED.
		/// \pre boundary_exists: boundary!=0
		/// \pre real_boundary: !boundary-&gt;IsInDataSet()
		/// \pre cell_of_the_dataset: IsInDataSet()
		/// \pre boundary: HasBoundary(boundary)
		/// \pre neighbors_exist: neighbors!=0
		/// </summary>
		// Token: 0x0601B748 RID: 112456 RVA: 0x00266C1C File Offset: 0x00264E1C
		public virtual void GetNeighbors(vtkGenericAdaptorCell boundary, vtkGenericCellIterator neighbors)
		{
			vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetNeighbors_20(base.GetCppThis(), (boundary == null) ? default(HandleRef) : boundary.GetCppThis(), (neighbors == null) ? default(HandleRef) : neighbors.GetCppThis());
		}

		// Token: 0x0601B749 RID: 112457
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAdaptorCell_GetNumberOfBoundaries_21(HandleRef pThis, int dim);

		/// <summary>
		/// Return the number of boundaries of dimension `dim' (or all dimensions
		/// greater than 0 and less than GetDimension() if -1) of the cell.
		/// When \a dim is -1, the number of vertices is not included in the
		/// count because vertices are a special case: a vertex will have
		/// at most a single field value associated with it; DOF nodes may have
		/// an arbitrary number of field values associated with them.
		/// \pre valid_dim_range: (dim==-1) || ((dim&gt;=0)&amp;&amp;(dim&lt;GetDimension()))
		/// \post positive_result: result&gt;=0
		/// </summary>
		// Token: 0x0601B74A RID: 112458 RVA: 0x00266C60 File Offset: 0x00264E60
		public virtual int GetNumberOfBoundaries(int dim)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetNumberOfBoundaries_21(base.GetCppThis(), dim);
		}

		// Token: 0x0601B74B RID: 112459
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAdaptorCell_GetNumberOfDOFNodes_22(HandleRef pThis);

		/// <summary>
		/// Accumulated number of DOF nodes of the current cell. A DOF node is
		/// a component of cell with a given topological dimension. e.g.: a triangle
		/// has 4 DOF: 1 face and 3 edges. An hexahedron has 19 DOF:
		/// 1 region, 6 faces, and 12 edges.
		///
		/// The number of vertices is not included in the
		/// count because vertices are a special case: a vertex will have
		/// at most a single field value associated with it; DOF nodes may have
		/// an arbitrary number of field values associated with them.
		/// \post valid_result: result==GetNumberOfBoundaries(-1)+1
		/// </summary>
		// Token: 0x0601B74C RID: 112460 RVA: 0x00266C80 File Offset: 0x00264E80
		public virtual int GetNumberOfDOFNodes()
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetNumberOfDOFNodes_22(base.GetCppThis());
		}

		// Token: 0x0601B74D RID: 112461
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericAdaptorCell_GetNumberOfGenerationsFromBase_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B74E RID: 112462 RVA: 0x00266CA0 File Offset: 0x00264EA0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetNumberOfGenerationsFromBase_23(base.GetCppThis(), type);
		}

		// Token: 0x0601B74F RID: 112463
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericAdaptorCell_GetNumberOfGenerationsFromBaseType_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B750 RID: 112464 RVA: 0x00266CC0 File Offset: 0x00264EC0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetNumberOfGenerationsFromBaseType_24(type);
		}

		// Token: 0x0601B751 RID: 112465
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAdaptorCell_GetNumberOfPoints_25(HandleRef pThis);

		/// <summary>
		/// Return the number of corner points that compose the cell.
		/// \post positive_result: result&gt;=0
		/// </summary>
		// Token: 0x0601B752 RID: 112466 RVA: 0x00266CDC File Offset: 0x00264EDC
		public virtual int GetNumberOfPoints()
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetNumberOfPoints_25(base.GetCppThis());
		}

		// Token: 0x0601B753 RID: 112467
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAdaptorCell_GetNumberOfVerticesOnFace_26(HandleRef pThis, int faceId);

		/// <summary>
		/// Return the number of vertices defining face `faceId'.
		/// \pre is_3d: this-&gt;GetDimension()==3
		/// \pre valid_faceId_range: faceId&gt;=0 &amp;&amp; faceId&lt;this-&gt;GetNumberOfBoundaries(2)
		/// \post positive_result: &amp;&amp; result&gt;0
		/// </summary>
		// Token: 0x0601B754 RID: 112468 RVA: 0x00266CFC File Offset: 0x00264EFC
		public virtual int GetNumberOfVerticesOnFace(int faceId)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetNumberOfVerticesOnFace_26(base.GetCppThis(), faceId);
		}

		// Token: 0x0601B755 RID: 112469
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAdaptorCell_GetParametricCenter_27(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Get the center of the current cell (in parametric coordinates) and place
		/// it in `pcoords'.  If the current cell is a composite, the return value
		/// is the sub-cell id that the center is in.  \post valid_result:
		/// (result&gt;=0) &amp;&amp; (IsPrimary() implies result==0)
		/// </summary>
		// Token: 0x0601B756 RID: 112470 RVA: 0x00266D1C File Offset: 0x00264F1C
		public virtual int GetParametricCenter(IntPtr pcoords)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetParametricCenter_27(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601B757 RID: 112471
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericAdaptorCell_GetParametricCoords_28(HandleRef pThis);

		/// <summary>
		/// Return a contiguous array of parametric coordinates of the corrner points
		/// defining the current cell. In other words, (px,py,pz, px,py,pz, etc..) The
		/// coordinates are ordered consistent with the definition of the point
		/// ordering for the cell. Note that 3D parametric coordinates are returned
		/// no matter what the topological dimension of the cell.
		/// \post valid_result_exists: ((IsPrimary()) &amp;&amp; (result!=0)) ||
		/// ((!IsPrimary()) &amp;&amp; (result==0))
		/// result!=0 implies sizeof(result)==GetNumberOfPoints()
		/// </summary>
		// Token: 0x0601B758 RID: 112472 RVA: 0x00266D3C File Offset: 0x00264F3C
		public virtual IntPtr GetParametricCoords()
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetParametricCoords_28(base.GetCppThis());
		}

		// Token: 0x0601B759 RID: 112473
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGenericAdaptorCell_GetParametricDistance_29(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the distance of the parametric coordinate `pcoords' to the
		/// current cell.  If inside the cell, a distance of zero is returned. This
		/// is used during picking to get the correct cell picked. (The tolerance
		/// will occasionally allow cells to be picked who are not really
		/// intersected "inside" the cell.)  \post positive_result: result&gt;=0
		/// </summary>
		// Token: 0x0601B75A RID: 112474 RVA: 0x00266D5C File Offset: 0x00264F5C
		public virtual double GetParametricDistance(IntPtr pcoords)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetParametricDistance_29(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601B75B RID: 112475
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericAdaptorCell_GetPointIds_30(HandleRef pThis, IntPtr id);

		/// <summary>
		/// Put into `id' the list of the dataset points that define the corner points
		/// of the cell.
		/// \pre id_exists: id!=0
		/// \pre valid_size: sizeof(id)==GetNumberOfPoints();
		/// </summary>
		// Token: 0x0601B75C RID: 112476 RVA: 0x00266D7C File Offset: 0x00264F7C
		public virtual void GetPointIds(IntPtr id)
		{
			vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetPointIds_30(base.GetCppThis(), id);
		}

		// Token: 0x0601B75D RID: 112477
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericAdaptorCell_GetPointIterator_31(HandleRef pThis, HandleRef it);

		/// <summary>
		/// Return the points of cell into `it'.
		/// \pre it_exists: it!=0
		/// </summary>
		// Token: 0x0601B75E RID: 112478 RVA: 0x00266D8C File Offset: 0x00264F8C
		public virtual void GetPointIterator(vtkGenericPointIterator it)
		{
			vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetPointIterator_31(base.GetCppThis(), (it == null) ? default(HandleRef) : it.GetCppThis());
		}

		// Token: 0x0601B75F RID: 112479
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAdaptorCell_GetType_32(HandleRef pThis);

		/// <summary>
		/// Return the type of the current cell.
		/// \post (result==VTK_HIGHER_ORDER_EDGE)||
		/// (result==VTK_HIGHER_ORDER_TRIANGLE)||
		/// (result==VTK_HIGHER_ORDER_TETRAHEDRON)
		/// </summary>
		// Token: 0x0601B760 RID: 112480 RVA: 0x00266DBC File Offset: 0x00264FBC
		public virtual int GetTypeWrapper()
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetType_32(base.GetCppThis());
		}

		// Token: 0x0601B761 RID: 112481
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericAdaptorCell_InterpolateTuple_33(HandleRef pThis, HandleRef a, IntPtr pcoords, IntPtr val);

		/// <summary>
		/// Interpolate the attribute `a' at local position `pcoords' of the cell into
		/// `val'.
		/// \pre a_exists: a!=0
		/// \pre a_is_point_centered: a-&gt;GetCentering()==vtkPointCentered
		/// \pre clamped_point: pcoords[0]&gt;=0 &amp;&amp; pcoords[0]&lt;=1 &amp;&amp; pcoords[1]&gt;=0 &amp;&amp;
		/// pcoords[1]&lt;=1 &amp;&amp; pcoords[2]&gt;=0 &amp;&amp; pcoords[2]&lt;=1
		/// \pre val_exists: val!=0
		/// \pre valid_size: sizeof(val)==a-&gt;GetNumberOfComponents()
		/// </summary>
		// Token: 0x0601B762 RID: 112482 RVA: 0x00266DDC File Offset: 0x00264FDC
		public virtual void InterpolateTuple(vtkGenericAttribute a, IntPtr pcoords, IntPtr val)
		{
			vtkGenericAdaptorCell.vtkGenericAdaptorCell_InterpolateTuple_33(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis(), pcoords, val);
		}

		// Token: 0x0601B763 RID: 112483
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericAdaptorCell_InterpolateTuple_34(HandleRef pThis, HandleRef c, IntPtr pcoords, IntPtr val);

		/// <summary>
		/// Interpolate the whole collection of attributes `c' at local position
		/// `pcoords' of the cell into `val'. Only point centered attributes are
		/// taken into account.
		/// \pre c_exists: c!=0
		/// \pre clamped_point: pcoords[0]&gt;=0 &amp;&amp; pcoords[0]&lt;=1 &amp;&amp; pcoords[1]&gt;=0 &amp;&amp;
		/// pcoords[1]&lt;=1 &amp;&amp; pcoords[2]&gt;=0 &amp;&amp; pcoords[2]&lt;=1
		/// \pre val_exists: val!=0
		/// \pre valid_size: sizeof(val)==c-&gt;GetNumberOfPointCenteredComponents()
		/// </summary>
		// Token: 0x0601B764 RID: 112484 RVA: 0x00266E10 File Offset: 0x00265010
		public virtual void InterpolateTuple(vtkGenericAttributeCollection c, IntPtr pcoords, IntPtr val)
		{
			vtkGenericAdaptorCell.vtkGenericAdaptorCell_InterpolateTuple_34(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis(), pcoords, val);
		}

		// Token: 0x0601B765 RID: 112485
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAdaptorCell_IntersectWithLine_35(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// Is there an intersection between the current cell and the ray (`p1',`p2')
		/// according to a tolerance `tol'? If true, `x' is the global intersection,
		/// `t' is the parametric coordinate for the line, `pcoords' are the
		/// parametric coordinates for cell. `subId' is the sub-cell where
		/// the intersection occurs.
		/// \pre positive_tolerance: tol&gt;0
		/// </summary>
		// Token: 0x0601B766 RID: 112486 RVA: 0x00266E44 File Offset: 0x00265044
		public virtual int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_IntersectWithLine_35(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601B767 RID: 112487
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAdaptorCell_IsA_36(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B768 RID: 112488 RVA: 0x00266E70 File Offset: 0x00265070
		public override int IsA(string type)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_IsA_36(base.GetCppThis(), type);
		}

		// Token: 0x0601B769 RID: 112489
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAdaptorCell_IsAttributeLinear_37(HandleRef pThis, HandleRef a);

		/// <summary>
		/// Does the attribute `a' have a non-linear interpolation?
		/// \pre a_exists: a!=0
		/// \post definition: result==(GetAttributeOrder()==1)
		/// </summary>
		// Token: 0x0601B76A RID: 112490 RVA: 0x00266E90 File Offset: 0x00265090
		public int IsAttributeLinear(vtkGenericAttribute a)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_IsAttributeLinear_37(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		// Token: 0x0601B76B RID: 112491
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAdaptorCell_IsFaceOnBoundary_38(HandleRef pThis, long faceId);

		/// <summary>
		/// Is the face `faceId' of the current cell on the exterior boundary of the
		/// dataset?
		/// \pre 3d: GetDimension()==3
		/// </summary>
		// Token: 0x0601B76C RID: 112492 RVA: 0x00266EC4 File Offset: 0x002650C4
		public virtual int IsFaceOnBoundary(long faceId)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_IsFaceOnBoundary_38(base.GetCppThis(), faceId);
		}

		// Token: 0x0601B76D RID: 112493
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAdaptorCell_IsGeometryLinear_39(HandleRef pThis);

		/// <summary>
		/// Does the cell have a non-linear interpolation for the geometry?
		/// \post definition: result==(GetGeometryOrder()==1)
		/// </summary>
		// Token: 0x0601B76E RID: 112494 RVA: 0x00266EE4 File Offset: 0x002650E4
		public int IsGeometryLinear()
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_IsGeometryLinear_39(base.GetCppThis());
		}

		// Token: 0x0601B76F RID: 112495
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAdaptorCell_IsInDataSet_40(HandleRef pThis);

		/// <summary>
		/// Does `this' a cell of a dataset? (otherwise, it is a boundary cell)
		/// </summary>
		// Token: 0x0601B770 RID: 112496 RVA: 0x00266F04 File Offset: 0x00265104
		public virtual int IsInDataSet()
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_IsInDataSet_40(base.GetCppThis());
		}

		// Token: 0x0601B771 RID: 112497
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAdaptorCell_IsOnBoundary_41(HandleRef pThis);

		/// <summary>
		/// Is the cell on the exterior boundary of the dataset?
		/// \pre 2d: GetDimension()==2
		/// </summary>
		// Token: 0x0601B772 RID: 112498 RVA: 0x00266F24 File Offset: 0x00265124
		public virtual int IsOnBoundary()
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_IsOnBoundary_41(base.GetCppThis());
		}

		// Token: 0x0601B773 RID: 112499
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAdaptorCell_IsPrimary_42(HandleRef pThis);

		/// <summary>
		/// Is the cell primary (i.e. not composite) ?
		/// </summary>
		// Token: 0x0601B774 RID: 112500 RVA: 0x00266F44 File Offset: 0x00265144
		public virtual int IsPrimary()
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_IsPrimary_42(base.GetCppThis());
		}

		// Token: 0x0601B775 RID: 112501
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericAdaptorCell_IsTypeOf_43([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B776 RID: 112502 RVA: 0x00266F64 File Offset: 0x00265164
		public new static int IsTypeOf(string type)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_IsTypeOf_43(type);
		}

		// Token: 0x0601B777 RID: 112503
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericAdaptorCell_NewCellIterator_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create an empty cell iterator. The user is responsible for deleting it.
		/// \post result_exists: result!=0
		/// </summary>
		// Token: 0x0601B778 RID: 112504 RVA: 0x00266F80 File Offset: 0x00265180
		public virtual vtkGenericCellIterator NewCellIterator()
		{
			vtkGenericCellIterator vtkGenericCellIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericAdaptorCell.vtkGenericAdaptorCell_NewCellIterator_44(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericCellIterator = (vtkGenericCellIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericCellIterator.Register(null);
				}
			}
			return vtkGenericCellIterator;
		}

		// Token: 0x0601B779 RID: 112505
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericAdaptorCell_NewInstance_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B77A RID: 112506 RVA: 0x00266FF0 File Offset: 0x002651F0
		public new vtkGenericAdaptorCell NewInstance()
		{
			vtkGenericAdaptorCell result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericAdaptorCell.vtkGenericAdaptorCell_NewInstance_45(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericAdaptorCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B77B RID: 112507
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericAdaptorCell_SafeDownCast_46(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B77C RID: 112508 RVA: 0x0026704C File Offset: 0x0026524C
		public new static vtkGenericAdaptorCell SafeDownCast(vtkObjectBase o)
		{
			vtkGenericAdaptorCell vtkGenericAdaptorCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericAdaptorCell.vtkGenericAdaptorCell_SafeDownCast_46((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericAdaptorCell = (vtkGenericAdaptorCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericAdaptorCell.Register(null);
				}
			}
			return vtkGenericAdaptorCell;
		}

		// Token: 0x0601B77D RID: 112509
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericAdaptorCell_Tessellate_47(HandleRef pThis, HandleRef attributes, HandleRef tess, HandleRef points, HandleRef locator, HandleRef cellArray, HandleRef internalPd, HandleRef pd, HandleRef cd, HandleRef types);

		/// <summary>
		/// Tessellate the cell if it is not linear or if at least one attribute of
		/// `attributes' is not linear. The output are linear cells of the same
		/// dimension than the cell. If the cell is linear and all attributes are
		/// linear, the output is just a copy of the current cell.
		/// `points', `cellArray', `pd' and `cd' are cumulative output data arrays
		/// over cell iterations: they store the result of each call to Tessellate().
		/// `internalPd' is initialized by the calling filter and stores the
		/// result of the tessellation.
		/// If it is not null, `types' is filled with the types of the linear cells.
		/// `types' is null when it is called from vtkGenericGeometryFilter and not
		/// null when it is called from vtkGenericDatasetTessellator.
		/// \pre attributes_exist: attributes!=0
		/// \pre tessellator_exists: tess!=0
		/// \pre points_exist: points!=0
		/// \pre cellArray_exists: cellArray!=0
		/// \pre internalPd_exists: internalPd!=0
		/// \pre pd_exist: pd!=0
		/// \pre cd_exists: cd!=0
		/// </summary>
		// Token: 0x0601B77E RID: 112510 RVA: 0x002670CC File Offset: 0x002652CC
		public virtual void Tessellate(vtkGenericAttributeCollection attributes, vtkGenericCellTessellator tess, vtkPoints points, vtkIncrementalPointLocator locator, vtkCellArray cellArray, vtkPointData internalPd, vtkPointData pd, vtkCellData cd, vtkUnsignedCharArray types)
		{
			vtkGenericAdaptorCell.vtkGenericAdaptorCell_Tessellate_47(base.GetCppThis(), (attributes == null) ? default(HandleRef) : attributes.GetCppThis(), (tess == null) ? default(HandleRef) : tess.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (cellArray == null) ? default(HandleRef) : cellArray.GetCppThis(), (internalPd == null) ? default(HandleRef) : internalPd.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis(), (cd == null) ? default(HandleRef) : cd.GetCppThis(), (types == null) ? default(HandleRef) : types.GetCppThis());
		}

		// Token: 0x0601B77F RID: 112511
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericAdaptorCell_TriangulateFace_48(HandleRef pThis, HandleRef attributes, HandleRef tess, int index, HandleRef points, HandleRef locator, HandleRef cellArray, HandleRef internalPd, HandleRef pd, HandleRef cd);

		/// <summary>
		/// Tessellate face `index' of the cell. See Tessellate() for further
		/// explanations.
		/// \pre cell_is_3d: GetDimension()==3
		/// \pre attributes_exist: attributes!=0
		/// \pre tessellator_exists: tess!=0
		/// \pre valid_face: index&gt;=0
		/// \pre points_exist: points!=0
		/// \pre cellArray_exists: cellArray!=0
		/// \pre internalPd_exists: internalPd!=0
		/// \pre pd_exist: pd!=0
		/// \pre cd_exists: cd!=0
		/// </summary>
		// Token: 0x0601B780 RID: 112512 RVA: 0x002671B0 File Offset: 0x002653B0
		public virtual void TriangulateFace(vtkGenericAttributeCollection attributes, vtkGenericCellTessellator tess, int index, vtkPoints points, vtkIncrementalPointLocator locator, vtkCellArray cellArray, vtkPointData internalPd, vtkPointData pd, vtkCellData cd)
		{
			vtkGenericAdaptorCell.vtkGenericAdaptorCell_TriangulateFace_48(base.GetCppThis(), (attributes == null) ? default(HandleRef) : attributes.GetCppThis(), (tess == null) ? default(HandleRef) : tess.GetCppThis(), index, (points == null) ? default(HandleRef) : points.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (cellArray == null) ? default(HandleRef) : cellArray.GetCppThis(), (internalPd == null) ? default(HandleRef) : internalPd.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis(), (cd == null) ? default(HandleRef) : cd.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D86 RID: 7558
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericAdaptorCell";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D87 RID: 7559
		public new static readonly string MRClassNameKey = "class vtkGenericAdaptorCell";
	}
}
