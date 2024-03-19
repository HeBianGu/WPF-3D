using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCell
	/// </summary>
	/// <remarks>
	///    abstract class to specify cell behavior
	///
	/// vtkCell is an abstract class that specifies the interfaces for data cells.
	/// Data cells are simple topological elements like points, lines, polygons,
	/// and tetrahedra of which visualization datasets are composed. In some
	/// cases visualization datasets may explicitly represent cells (e.g.,
	/// vtkPolyData, vtkUnstructuredGrid), and in some cases, the datasets are
	/// implicitly composed of cells (e.g., vtkStructuredPoints).
	///
	/// @warning
	/// The \#define VTK_CELL_SIZE is a parameter used to construct cells and provide
	/// a general guideline for controlling object execution. This parameter is
	/// not a hard boundary: you can create cells with more points.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkHexahedron vtkLine vtkPixel vtkPolyLine vtkPolyVertex
	/// vtkPolygon vtkQuad vtkTetra vtkTriangle
	/// vtkTriangleStrip vtkVertex vtkVoxel vtkWedge vtkPyramid
	/// </seealso>
	// Token: 0x020009FD RID: 2557
	public abstract class vtkCell : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A86C RID: 108652 RVA: 0x0024DD93 File Offset: 0x0024BF93
		static vtkCell()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCell.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCell"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A86D RID: 108653 RVA: 0x0024DDBB File Offset: 0x0024BFBB
		public vtkCell(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A86E RID: 108654 RVA: 0x0024DDC9 File Offset: 0x0024BFC9
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A86F RID: 108655
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCell_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		/// <summary>
		/// Given parametric coordinates of a point, return the closest cell
		/// boundary, and whether the point is inside or outside of the cell. The
		/// cell boundary is defined by a list of points (pts) that specify a face
		/// (3D cell), edge (2D cell), or vertex (1D cell). If the return value of
		/// the method is != 0, then the point is inside the cell.
		/// </summary>
		// Token: 0x0601A870 RID: 108656 RVA: 0x0024DDD4 File Offset: 0x0024BFD4
		public virtual int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkCell.vtkCell_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601A871 RID: 108657
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCell_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef connectivity, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		/// <summary>
		/// Cut (or clip) the cell based on the input cellScalars and the
		/// specified value. The output of the clip operation will be one or
		/// more cells of the same topological dimension as the original cell.
		/// The flag insideOut controls what part of the cell is considered inside -
		/// normally cell points whose scalar value is greater than "value" are
		/// considered inside. If insideOut is on, this is reversed. Also, if the
		/// output cell data is non-nullptr, the cell data from the clipped cell is
		/// passed to the generated contouring primitives. (Note: the CopyAllocate()
		/// method must be invoked on both the output cell and point data. The
		/// cellId refers to the cell from which the cell data is copied.)
		/// </summary>
		// Token: 0x0601A872 RID: 108658 RVA: 0x0024DE0C File Offset: 0x0024C00C
		public virtual void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray connectivity, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkCell.vtkCell_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (connectivity == null) ? default(HandleRef) : connectivity.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		// Token: 0x0601A873 RID: 108659
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCell_ComputeBoundingSphere_03(HandleRef pThis, IntPtr center);

		/// <summary>
		/// Computes the bounding sphere of the cell. If the number of points in the cell is lower
		/// or equal to 4, an exact bounding sphere is computed. If not, Ritter's algorithm
		/// is followed. If the input sphere has zero points, then each coordinate of
		/// center is set to NaN, as well as the returned distance.
		///
		/// This method computes the center of the sphere, and returns its squared radius.
		/// </summary>
		// Token: 0x0601A874 RID: 108660 RVA: 0x0024DEC8 File Offset: 0x0024C0C8
		public virtual double ComputeBoundingSphere(IntPtr center)
		{
			return vtkCell.vtkCell_ComputeBoundingSphere_03(base.GetCppThis(), center);
		}

		// Token: 0x0601A875 RID: 108661
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCell_Contour_04(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		/// <summary>
		/// Generate contouring primitives. The scalar list cellScalars are
		/// scalar values at each cell point. The point locator is essentially a
		/// points list that merges points as they are inserted (i.e., prevents
		/// duplicates). Contouring primitives can be vertices, lines, or
		/// polygons. It is possible to interpolate point data along the edge
		/// by providing input and output point data - if outPd is nullptr, then
		/// no interpolation is performed. Also, if the output cell data is
		/// non-nullptr, the cell data from the contoured cell is passed to the
		/// generated contouring primitives. (Note: the CopyAllocate() method
		/// must be invoked on both the output cell and point data. The
		/// cellId refers to the cell from which the cell data is copied.)
		/// </summary>
		// Token: 0x0601A876 RID: 108662 RVA: 0x0024DEE8 File Offset: 0x0024C0E8
		public virtual void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkCell.vtkCell_Contour_04(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		// Token: 0x0601A877 RID: 108663
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCell_DeepCopy_05(HandleRef pThis, HandleRef c);

		/// <summary>
		/// Copy this cell by completely copying internal data structures. This is
		/// slower but safer than ShallowCopy().
		/// </summary>
		// Token: 0x0601A878 RID: 108664 RVA: 0x0024DFD0 File Offset: 0x0024C1D0
		public virtual void DeepCopy(vtkCell c)
		{
			vtkCell.vtkCell_DeepCopy_05(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		// Token: 0x0601A879 RID: 108665
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCell_Derivatives_06(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		/// <summary>
		/// Compute derivatives given cell subId and parametric coordinates. The
		/// values array is a series of data value(s) at the cell points. There is a
		/// one-to-one correspondence between cell point and data value(s). Dim is
		/// the number of data values per cell point. Derivs are derivatives in the
		/// x-y-z coordinate directions for each data value. Thus, if computing
		/// derivatives for a scalar function in a hexahedron, dim=1, 8 values are
		/// supplied, and 3 deriv values are returned (i.e., derivatives in x-y-z
		/// directions). On the other hand, if computing derivatives of velocity
		/// (vx,vy,vz) dim=3, 24 values are supplied ((vx,vy,vz)1, (vx,vy,vz)2,
		/// ....()8), and 9 deriv values are returned
		/// ((d(vx)/dx),(d(vx)/dy),(d(vx)/dz), (d(vy)/dx),(d(vy)/dy), (d(vy)/dz),
		/// (d(vz)/dx),(d(vz)/dy),(d(vz)/dz)).
		/// </summary>
		// Token: 0x0601A87A RID: 108666 RVA: 0x0024DFFF File Offset: 0x0024C1FF
		public virtual void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkCell.vtkCell_Derivatives_06(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		// Token: 0x0601A87B RID: 108667
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCell_EvaluateLocation_07(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		/// <summary>
		/// Determine global coordinate (x[3]) from subId and parametric coordinates.
		/// Also returns interpolation weights. (The number of weights is equal to
		/// the number of points in the cell.)
		/// </summary>
		// Token: 0x0601A87C RID: 108668 RVA: 0x0024E015 File Offset: 0x0024C215
		public virtual void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkCell.vtkCell_EvaluateLocation_07(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		// Token: 0x0601A87D RID: 108669
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCell_EvaluatePosition_08(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		/// <summary>
		/// Given a point x[3] return inside(=1), outside(=0) cell, or (-1)
		/// computational problem encountered; evaluate
		/// parametric coordinates, sub-cell id (!=0 only if cell is composite),
		/// distance squared of point x[3] to cell (in particular, the sub-cell
		/// indicated), closest point on cell to x[3] (unless closestPoint is null,
		/// in which case, the closest point and dist2 are not found), and
		/// interpolation weights in cell. (The number of weights is equal to the
		/// number of points defining the cell). Note: on rare occasions a -1 is
		/// returned from the method. This means that numerical error has occurred
		/// and all data returned from this method should be ignored. Also,
		/// inside/outside is determine parametrically. That is, a point is inside
		/// if it satisfies parametric limits. This can cause problems for cells of
		/// topological dimension 2 or less, since a point in 3D can project onto
		/// the cell within parametric limits but be "far" from the cell.  Thus the
		/// value dist2 may be checked to determine true in/out.
		/// </summary>
		// Token: 0x0601A87E RID: 108670 RVA: 0x0024E02C File Offset: 0x0024C22C
		public virtual int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkCell.vtkCell_EvaluatePosition_08(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		// Token: 0x0601A87F RID: 108671
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCell_GetBounds_09(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Compute cell bounding box (xmin,xmax,ymin,ymax,zmin,zmax). Copy result
		/// into user provided array.
		/// </summary>
		// Token: 0x0601A880 RID: 108672 RVA: 0x0024E054 File Offset: 0x0024C254
		public void GetBounds(IntPtr bounds)
		{
			vtkCell.vtkCell_GetBounds_09(base.GetCppThis(), bounds);
		}

		// Token: 0x0601A881 RID: 108673
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCell_GetBounds_10(HandleRef pThis);

		/// <summary>
		/// Compute cell bounding box (xmin,xmax,ymin,ymax,zmin,zmax). Return pointer
		/// to array of six double values.
		/// </summary>
		// Token: 0x0601A882 RID: 108674 RVA: 0x0024E064 File Offset: 0x0024C264
		public double[] GetBounds()
		{
			IntPtr intPtr = vtkCell.vtkCell_GetBounds_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601A883 RID: 108675
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCell_GetCellDimension_11(HandleRef pThis);

		/// <summary>
		/// Return the topological dimensional of the cell (0,1,2, or 3).
		/// </summary>
		// Token: 0x0601A884 RID: 108676 RVA: 0x0024E0AC File Offset: 0x0024C2AC
		public virtual int GetCellDimension()
		{
			return vtkCell.vtkCell_GetCellDimension_11(base.GetCppThis());
		}

		// Token: 0x0601A885 RID: 108677
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCell_GetCellType_12(HandleRef pThis);

		/// <summary>
		/// Return the type of cell.
		/// </summary>
		// Token: 0x0601A886 RID: 108678 RVA: 0x0024E0CC File Offset: 0x0024C2CC
		public virtual int GetCellType()
		{
			return vtkCell.vtkCell_GetCellType_12(base.GetCppThis());
		}

		// Token: 0x0601A887 RID: 108679
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCell_GetEdge_13(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the edge cell from the edgeId of the cell.
		/// </summary>
		// Token: 0x0601A888 RID: 108680 RVA: 0x0024E0EC File Offset: 0x0024C2EC
		public virtual vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCell.vtkCell_GetEdge_13(base.GetCppThis(), edgeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601A889 RID: 108681
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCell_GetFace_14(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the face cell from the faceId of the cell. The returned vtkCell
		/// is an object owned by this instance, hence the return value
		/// must not be deleted by the caller.
		///
		/// @warning Repeat calls to this function for different face ids will change
		/// the data stored in the internal member object whose pointer is returned by
		/// this function.
		///
		/// @warning THIS METHOD IS NOT THREAD SAFE.
		/// </summary>
		// Token: 0x0601A88A RID: 108682 RVA: 0x0024E15C File Offset: 0x0024C35C
		public virtual vtkCell GetFace(int faceId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCell.vtkCell_GetFace_14(base.GetCppThis(), faceId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601A88B RID: 108683
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCell_GetFaces_15(HandleRef pThis);

		/// <summary>
		/// Determine whether the cell requires explicit face representation, and
		/// methods for setting and getting the faces (see vtkPolyhedron for example
		/// usage of these methods).
		/// </summary>
		// Token: 0x0601A88C RID: 108684 RVA: 0x0024E1CC File Offset: 0x0024C3CC
		public virtual IntPtr GetFaces()
		{
			return vtkCell.vtkCell_GetFaces_15(base.GetCppThis());
		}

		// Token: 0x0601A88D RID: 108685
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCell_GetLength2_16(HandleRef pThis);

		/// <summary>
		/// Compute Length squared of cell (i.e., bounding box diagonal squared).
		/// </summary>
		// Token: 0x0601A88E RID: 108686 RVA: 0x0024E1EC File Offset: 0x0024C3EC
		public double GetLength2()
		{
			return vtkCell.vtkCell_GetLength2_16(base.GetCppThis());
		}

		// Token: 0x0601A88F RID: 108687
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCell_GetNumberOfEdges_17(HandleRef pThis);

		/// <summary>
		/// Return the number of edges in the cell.
		/// </summary>
		// Token: 0x0601A890 RID: 108688 RVA: 0x0024E20C File Offset: 0x0024C40C
		public virtual int GetNumberOfEdges()
		{
			return vtkCell.vtkCell_GetNumberOfEdges_17(base.GetCppThis());
		}

		// Token: 0x0601A891 RID: 108689
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCell_GetNumberOfFaces_18(HandleRef pThis);

		/// <summary>
		/// Return the number of faces in the cell.
		/// </summary>
		// Token: 0x0601A892 RID: 108690 RVA: 0x0024E22C File Offset: 0x0024C42C
		public virtual int GetNumberOfFaces()
		{
			return vtkCell.vtkCell_GetNumberOfFaces_18(base.GetCppThis());
		}

		// Token: 0x0601A893 RID: 108691
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCell_GetNumberOfGenerationsFromBase_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A894 RID: 108692 RVA: 0x0024E24C File Offset: 0x0024C44C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCell.vtkCell_GetNumberOfGenerationsFromBase_19(base.GetCppThis(), type);
		}

		// Token: 0x0601A895 RID: 108693
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCell_GetNumberOfGenerationsFromBaseType_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A896 RID: 108694 RVA: 0x0024E26C File Offset: 0x0024C46C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCell.vtkCell_GetNumberOfGenerationsFromBaseType_20(type);
		}

		// Token: 0x0601A897 RID: 108695
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCell_GetNumberOfPoints_21(HandleRef pThis);

		/// <summary>
		/// Return the number of points in the cell.
		/// </summary>
		// Token: 0x0601A898 RID: 108696 RVA: 0x0024E288 File Offset: 0x0024C488
		public long GetNumberOfPoints()
		{
			return vtkCell.vtkCell_GetNumberOfPoints_21(base.GetCppThis());
		}

		// Token: 0x0601A899 RID: 108697
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCell_GetParametricCenter_22(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return center of the cell in parametric coordinates.  Note that the
		/// parametric center is not always located at (0.5,0.5,0.5). The return
		/// value is the subId that the center is in (if a composite cell). If you
		/// want the center in x-y-z space, invoke the EvaluateLocation() method.
		/// </summary>
		// Token: 0x0601A89A RID: 108698 RVA: 0x0024E2A8 File Offset: 0x0024C4A8
		public virtual int GetParametricCenter(IntPtr pcoords)
		{
			return vtkCell.vtkCell_GetParametricCenter_22(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601A89B RID: 108699
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCell_GetParametricCoords_23(HandleRef pThis);

		/// <summary>
		/// Return a contiguous array of parametric coordinates of the points
		/// defining this cell. In other words, (px,py,pz, px,py,pz, etc..)  The
		/// coordinates are ordered consistent with the definition of the point
		/// ordering for the cell. This method returns a non-nullptr pointer when
		/// the cell is a primary type (i.e., IsPrimaryCell() is true). Note that
		/// 3D parametric coordinates are returned no matter what the topological
		/// dimension of the cell.
		/// </summary>
		// Token: 0x0601A89C RID: 108700 RVA: 0x0024E2C8 File Offset: 0x0024C4C8
		public virtual IntPtr GetParametricCoords()
		{
			return vtkCell.vtkCell_GetParametricCoords_23(base.GetCppThis());
		}

		// Token: 0x0601A89D RID: 108701
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCell_GetParametricDistance_24(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Return the distance of the parametric coordinate provided to the
		/// cell. If inside the cell, a distance of zero is returned. This is
		/// used during picking to get the correct cell picked. (The tolerance
		/// will occasionally allow cells to be picked who are not really
		/// intersected "inside" the cell.)
		/// </summary>
		// Token: 0x0601A89E RID: 108702 RVA: 0x0024E2E8 File Offset: 0x0024C4E8
		public virtual double GetParametricDistance(IntPtr pcoords)
		{
			return vtkCell.vtkCell_GetParametricDistance_24(base.GetCppThis(), pcoords);
		}

		// Token: 0x0601A89F RID: 108703
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCell_GetPointId_25(HandleRef pThis, int ptId);

		/// <summary>
		/// For cell point i, return the actual point id.
		/// </summary>
		// Token: 0x0601A8A0 RID: 108704 RVA: 0x0024E308 File Offset: 0x0024C508
		public long GetPointId(int ptId)
		{
			return vtkCell.vtkCell_GetPointId_25(base.GetCppThis(), ptId);
		}

		// Token: 0x0601A8A1 RID: 108705
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCell_GetPointIds_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the list of point ids defining the cell.
		/// </summary>
		// Token: 0x0601A8A2 RID: 108706 RVA: 0x0024E328 File Offset: 0x0024C528
		public vtkIdList GetPointIds()
		{
			vtkIdList vtkIdList = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCell.vtkCell_GetPointIds_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdList = (vtkIdList)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdList.Register(null);
				}
			}
			return vtkIdList;
		}

		// Token: 0x0601A8A3 RID: 108707
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCell_GetPoints_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the point coordinates for the cell.
		/// </summary>
		// Token: 0x0601A8A4 RID: 108708 RVA: 0x0024E398 File Offset: 0x0024C598
		public vtkPoints GetPoints()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCell.vtkCell_GetPoints_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		// Token: 0x0601A8A5 RID: 108709
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCell_Inflate_28(HandleRef pThis, double dist);

		/// <summary>
		/// Inflates the cell. Each edge is displaced following its normal by a
		/// distance of value `dist`. If dist is negative, then the cell shrinks.
		/// The resulting cell edges / faces are colinear / coplanar to their previous
		/// self.
		///
		/// The cell is assumed to be non-degenerate and to have no
		/// edge of length zero for linear 2D cells.
		/// If it is not the case, then no inflation is performed.
		/// This method needs to be overridden by inheriting non-linear / non-2D cells.
		///
		/// \return 1 if inflation was successful, 0 if no inflation was performed
		/// </summary>
		// Token: 0x0601A8A6 RID: 108710 RVA: 0x0024E408 File Offset: 0x0024C608
		public virtual int Inflate(double dist)
		{
			return vtkCell.vtkCell_Inflate_28(base.GetCppThis(), dist);
		}

		// Token: 0x0601A8A7 RID: 108711
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCell_Initialize_29(HandleRef pThis, int npts, IntPtr pts, HandleRef p);

		/// <summary>
		/// Initialize cell from outside with point ids and point
		/// coordinates specified.
		/// </summary>
		// Token: 0x0601A8A8 RID: 108712 RVA: 0x0024E428 File Offset: 0x0024C628
		public void Initialize(int npts, IntPtr pts, vtkPoints p)
		{
			vtkCell.vtkCell_Initialize_29(base.GetCppThis(), npts, pts, (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0601A8A9 RID: 108713
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCell_Initialize_30(HandleRef pThis, int npts, HandleRef p);

		/// <summary>
		/// Initialize the cell with point coordinates specified. Note that this
		/// simplified version of Initialize() assumes that the point ids are simply
		/// the indices into the supplied points array. Make sure that the ordering
		/// of the points is consistent with the definition of the cell.
		/// </summary>
		// Token: 0x0601A8AA RID: 108714 RVA: 0x0024E45C File Offset: 0x0024C65C
		public void Initialize(int npts, vtkPoints p)
		{
			vtkCell.vtkCell_Initialize_30(base.GetCppThis(), npts, (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0601A8AB RID: 108715
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCell_Initialize_31(HandleRef pThis);

		/// <summary>
		/// Some cells require initialization prior to access. For example, they
		/// may have to triangulate themselves or set up internal data structures.
		/// </summary>
		// Token: 0x0601A8AC RID: 108716 RVA: 0x0024E48C File Offset: 0x0024C68C
		public virtual void Initialize()
		{
			vtkCell.vtkCell_Initialize_31(base.GetCppThis());
		}

		// Token: 0x0601A8AD RID: 108717
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCell_InterpolateDerivs_32(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// No-ops at this level. Typically overridden in subclasses.
		/// </summary>
		// Token: 0x0601A8AE RID: 108718 RVA: 0x0024E49B File Offset: 0x0024C69B
		public virtual void InterpolateDerivs(IntPtr arg0, IntPtr arg1)
		{
			vtkCell.vtkCell_InterpolateDerivs_32(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x0601A8AF RID: 108719
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCell_InterpolateFunctions_33(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		/// <summary>
		/// Compute the interpolation functions/derivatives
		/// (aka shape functions/derivatives)
		/// No-ops at this level. Typically overridden in subclasses.
		/// </summary>
		// Token: 0x0601A8B0 RID: 108720 RVA: 0x0024E4AC File Offset: 0x0024C6AC
		public virtual void InterpolateFunctions(IntPtr arg0, IntPtr arg1)
		{
			vtkCell.vtkCell_InterpolateFunctions_33(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x0601A8B1 RID: 108721
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCell_IntersectWithCell_34(HandleRef pThis, HandleRef other, double tol);

		/// <summary>
		/// Intersects with an other cell. Returns 1 if cells intersect, 0 otherwise.
		/// If an exact intersection detection with regards to floating point precision is wanted,
		/// tol should be disregarded.
		/// `vtkBoundingBox` are optional parameters which slightly improve the speed of the computation
		/// if bounding boxes are already available to user.
		/// </summary>
		// Token: 0x0601A8B2 RID: 108722 RVA: 0x0024E4C0 File Offset: 0x0024C6C0
		public virtual int IntersectWithCell(vtkCell other, double tol)
		{
			return vtkCell.vtkCell_IntersectWithCell_34(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis(), tol);
		}

		// Token: 0x0601A8B3 RID: 108723
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCell_IntersectWithLine_35(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// Intersect with a ray. Return parametric coordinates (both line and cell)
		/// and global intersection coordinates, given ray definition p1[3], p2[3] and tolerance tol.
		/// The method returns non-zero value if intersection occurs. A parametric distance t
		/// between 0 and 1 along the ray representing the intersection point, the point coordinates
		/// x[3] in data coordinates and also pcoords[3] in parametric coordinates. subId is the index
		/// within the cell if a composed cell like a triangle strip.
		/// </summary>
		// Token: 0x0601A8B4 RID: 108724 RVA: 0x0024E4F8 File Offset: 0x0024C6F8
		public virtual int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkCell.vtkCell_IntersectWithLine_35(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0601A8B5 RID: 108725
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCell_IsA_36(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A8B6 RID: 108726 RVA: 0x0024E524 File Offset: 0x0024C724
		public override int IsA(string type)
		{
			return vtkCell.vtkCell_IsA_36(base.GetCppThis(), type);
		}

		// Token: 0x0601A8B7 RID: 108727
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCell_IsExplicitCell_37(HandleRef pThis);

		/// <summary>
		/// Explicit cells require additional representational information
		/// beyond the usual cell type and connectivity list information.
		/// Most cells in VTK are implicit cells.
		/// </summary>
		// Token: 0x0601A8B8 RID: 108728 RVA: 0x0024E544 File Offset: 0x0024C744
		public virtual int IsExplicitCell()
		{
			return vtkCell.vtkCell_IsExplicitCell_37(base.GetCppThis());
		}

		// Token: 0x0601A8B9 RID: 108729
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCell_IsLinear_38(HandleRef pThis);

		/// <summary>
		/// Non-linear cells require special treatment beyond the usual cell type
		/// and connectivity list information.  Most cells in VTK are implicit
		/// cells.
		/// </summary>
		// Token: 0x0601A8BA RID: 108730 RVA: 0x0024E564 File Offset: 0x0024C764
		public virtual int IsLinear()
		{
			return vtkCell.vtkCell_IsLinear_38(base.GetCppThis());
		}

		// Token: 0x0601A8BB RID: 108731
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCell_IsPrimaryCell_39(HandleRef pThis);

		/// <summary>
		/// Return whether this cell type has a fixed topology or whether the
		/// topology varies depending on the data (e.g., vtkConvexPointSet).
		/// This compares to composite cells that are typically composed of
		/// primary cells (e.g., a triangle strip composite cell is made up of
		/// triangle primary cells).
		/// </summary>
		// Token: 0x0601A8BC RID: 108732 RVA: 0x0024E584 File Offset: 0x0024C784
		public virtual int IsPrimaryCell()
		{
			return vtkCell.vtkCell_IsPrimaryCell_39(base.GetCppThis());
		}

		// Token: 0x0601A8BD RID: 108733
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCell_IsTypeOf_40([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A8BE RID: 108734 RVA: 0x0024E5A4 File Offset: 0x0024C7A4
		public new static int IsTypeOf(string type)
		{
			return vtkCell.vtkCell_IsTypeOf_40(type);
		}

		// Token: 0x0601A8BF RID: 108735
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCell_NewInstance_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A8C0 RID: 108736 RVA: 0x0024E5C0 File Offset: 0x0024C7C0
		public new vtkCell NewInstance()
		{
			vtkCell result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCell.vtkCell_NewInstance_41(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A8C1 RID: 108737
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCell_RequiresExplicitFaceRepresentation_42(HandleRef pThis);

		/// <summary>
		/// Determine whether the cell requires explicit face representation, and
		/// methods for setting and getting the faces (see vtkPolyhedron for example
		/// usage of these methods).
		/// </summary>
		// Token: 0x0601A8C2 RID: 108738 RVA: 0x0024E61C File Offset: 0x0024C81C
		public virtual int RequiresExplicitFaceRepresentation()
		{
			return vtkCell.vtkCell_RequiresExplicitFaceRepresentation_42(base.GetCppThis());
		}

		// Token: 0x0601A8C3 RID: 108739
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCell_RequiresInitialization_43(HandleRef pThis);

		/// <summary>
		/// Some cells require initialization prior to access. For example, they
		/// may have to triangulate themselves or set up internal data structures.
		/// </summary>
		// Token: 0x0601A8C4 RID: 108740 RVA: 0x0024E63C File Offset: 0x0024C83C
		public virtual int RequiresInitialization()
		{
			return vtkCell.vtkCell_RequiresInitialization_43(base.GetCppThis());
		}

		// Token: 0x0601A8C5 RID: 108741
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCell_SafeDownCast_44(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A8C6 RID: 108742 RVA: 0x0024E65C File Offset: 0x0024C85C
		public new static vtkCell SafeDownCast(vtkObjectBase o)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCell.vtkCell_SafeDownCast_44((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601A8C7 RID: 108743
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCell_SetFaces_45(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Determine whether the cell requires explicit face representation, and
		/// methods for setting and getting the faces (see vtkPolyhedron for example
		/// usage of these methods).
		/// </summary>
		// Token: 0x0601A8C8 RID: 108744 RVA: 0x0024E6DB File Offset: 0x0024C8DB
		public virtual void SetFaces(IntPtr arg0)
		{
			vtkCell.vtkCell_SetFaces_45(base.GetCppThis(), arg0);
		}

		// Token: 0x0601A8C9 RID: 108745
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCell_ShallowCopy_46(HandleRef pThis, HandleRef c);

		/// <summary>
		/// Copy this cell by reference counting the internal data structures.
		/// This is safe if you want a "read-only" copy. If you modify the cell
		/// you might wish to use DeepCopy().
		/// </summary>
		// Token: 0x0601A8CA RID: 108746 RVA: 0x0024E6EC File Offset: 0x0024C8EC
		public virtual void ShallowCopy(vtkCell c)
		{
			vtkCell.vtkCell_ShallowCopy_46(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		// Token: 0x0601A8CB RID: 108747
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCell_Triangulate_47(HandleRef pThis, int index, HandleRef ptIds, HandleRef pts);

		/// <summary>
		/// Generate simplices of proper dimension. If cell is 3D, tetrahedra are
		/// generated; if 2D triangles; if 1D lines; if 0D points. The form of the
		/// output is a sequence of points, each n+1 points (where n is topological
		/// cell dimension) defining a simplex. The index is a parameter that controls
		/// which triangulation to use (if more than one is possible). If numerical
		/// degeneracy encountered, 0 is returned, otherwise 1 is returned.
		/// This method does not insert new points: all the points that define the
		/// simplices are the points that define the cell.
		/// </summary>
		// Token: 0x0601A8CC RID: 108748 RVA: 0x0024E71C File Offset: 0x0024C91C
		public virtual int Triangulate(int index, vtkIdList ptIds, vtkPoints pts)
		{
			return vtkCell.vtkCell_Triangulate_47(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601A8CD RID: 108749
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCell_TriangulateIds_48(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// Generate simplices of proper dimension. If cell is 3D, tetrahedra are
		/// generated; if 2D triangles; if 1D lines; if 0D points. The form of the
		/// output is a sequence of points, each n+1 points (where n is topological
		/// cell dimension) defining a simplex. The index is a parameter that controls
		/// which triangulation to use (if more than one is possible). If numerical
		/// degeneracy encountered, 0 is returned, otherwise 1 is returned.
		/// This method does not insert new points: all the points that define the
		/// simplices are the points that define the cell.
		/// </summary>
		// Token: 0x0601A8CE RID: 108750 RVA: 0x0024E768 File Offset: 0x0024C968
		public virtual int TriangulateIds(int index, vtkIdList ptIds)
		{
			return vtkCell.vtkCell_TriangulateIds_48(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		// Token: 0x0601A8CF RID: 108751
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCell_TriangulateLocalIds_49(HandleRef pThis, int index, HandleRef ptIds);

		/// <summary>
		/// Generate simplices of proper dimension. If cell is 3D, tetrahedra are
		/// generated; if 2D triangles; if 1D lines; if 0D points. The form of the
		/// output is a sequence of points, each n+1 points (where n is topological
		/// cell dimension) defining a simplex. The index is a parameter that controls
		/// which triangulation to use (if more than one is possible). If numerical
		/// degeneracy encountered, 0 is returned, otherwise 1 is returned.
		/// This method does not insert new points: all the points that define the
		/// simplices are the points that define the cell.
		/// ptIds are the local indices with respect to the cell
		/// </summary>
		// Token: 0x0601A8D0 RID: 108752 RVA: 0x0024E7A0 File Offset: 0x0024C9A0
		public virtual int TriangulateLocalIds(int index, vtkIdList ptIds)
		{
			return vtkCell.vtkCell_TriangulateLocalIds_49(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CD2 RID: 7378
		public new const string MRFullTypeName = "Kitware.VTK.vtkCell";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CD3 RID: 7379
		public new static readonly string MRClassNameKey = "class vtkCell";
	}
}
