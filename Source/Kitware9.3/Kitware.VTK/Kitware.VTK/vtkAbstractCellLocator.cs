using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAbstractCellLocator
	/// </summary>
	/// <remarks>
	///    an abstract base class for locators which find cells
	///
	/// vtkAbstractCellLocator is a spatial search object to quickly locate cells in 3D.
	/// vtkAbstractCellLocator supplies a basic interface which concrete subclasses
	/// should implement.
	///
	/// @warning
	/// When deriving a class from vtkAbstractCellLocator, one should include the
	/// 'hidden' member functions by the following construct in the derived class
	/// \verbatim
	///  using vtkAbstractCellLocator::IntersectWithLine;
	///  using vtkAbstractCellLocator::FindClosestPoint;
	///  using vtkAbstractCellLocator::FindClosestPointWithinRadius;
	///  using vtkAbstractCellLocator::FindCell;
	/// \endverbatim
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkLocator vtkCellLocator vtkStaticCellLocator vtkCellTreeLocator vtkModifiedBSPTree vtkOBBTree
	/// </seealso>
	// Token: 0x020004B4 RID: 1204
	public abstract class vtkAbstractCellLocator : vtkLocator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600DD0B RID: 56587 RVA: 0x00132C67 File Offset: 0x00130E67
		static vtkAbstractCellLocator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractCellLocator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractCellLocator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600DD0C RID: 56588 RVA: 0x00132C8F File Offset: 0x00130E8F
		public vtkAbstractCellLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600DD0D RID: 56589 RVA: 0x00132C9D File Offset: 0x00130E9D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600DD0E RID: 56590
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractCellLocator_CacheCellBoundsOff_01(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether the bounds of each cell are computed only
		/// once and then saved.  Should be 10 to 20% faster if repeatedly
		/// calling any of the Intersect/Find routines and the extra memory
		/// won't cause disk caching (48 extra bytes per cell are required to
		/// save the bounds).
		/// </summary>
		// Token: 0x0600DD0F RID: 56591 RVA: 0x00132CA8 File Offset: 0x00130EA8
		public virtual void CacheCellBoundsOff()
		{
			vtkAbstractCellLocator.vtkAbstractCellLocator_CacheCellBoundsOff_01(base.GetCppThis());
		}

		// Token: 0x0600DD10 RID: 56592
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractCellLocator_CacheCellBoundsOn_02(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether the bounds of each cell are computed only
		/// once and then saved.  Should be 10 to 20% faster if repeatedly
		/// calling any of the Intersect/Find routines and the extra memory
		/// won't cause disk caching (48 extra bytes per cell are required to
		/// save the bounds).
		/// </summary>
		// Token: 0x0600DD11 RID: 56593 RVA: 0x00132CB7 File Offset: 0x00130EB7
		public virtual void CacheCellBoundsOn()
		{
			vtkAbstractCellLocator.vtkAbstractCellLocator_CacheCellBoundsOn_02(base.GetCppThis());
		}

		// Token: 0x0600DD12 RID: 56594
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractCellLocator_ComputeCellBounds_03(HandleRef pThis);

		/// <summary>
		/// This function can be used either internally or externally to compute only the cached
		/// cell bounds if CacheCellBounds is on.
		/// </summary>
		// Token: 0x0600DD13 RID: 56595 RVA: 0x00132CC6 File Offset: 0x00130EC6
		public void ComputeCellBounds()
		{
			vtkAbstractCellLocator.vtkAbstractCellLocator_ComputeCellBounds_03(base.GetCppThis());
		}

		// Token: 0x0600DD14 RID: 56596
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractCellLocator_FindCell_04(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Returns the Id of the cell containing the point,
		/// returns -1 if no cell found. This interface uses a tolerance of zero
		///
		/// THIS FUNCTION IS NOT THREAD SAFE.
		/// </summary>
		// Token: 0x0600DD15 RID: 56597 RVA: 0x00132CD8 File Offset: 0x00130ED8
		public virtual long FindCell(IntPtr x)
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_FindCell_04(base.GetCppThis(), x);
		}

		// Token: 0x0600DD16 RID: 56598
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractCellLocator_FindCell_05(HandleRef pThis, IntPtr x, double tol2, HandleRef GenCell, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Find the cell containing a given point. returns -1 if no cell found
		/// the cell parameters are copied into the supplied variables, a cell must
		/// be provided to store the information.
		///
		/// THIS FUNCTION IS THREAD SAFE.
		/// </summary>
		// Token: 0x0600DD17 RID: 56599 RVA: 0x00132CF8 File Offset: 0x00130EF8
		public virtual long FindCell(IntPtr x, double tol2, vtkGenericCell GenCell, IntPtr pcoords, IntPtr weights)
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_FindCell_05(base.GetCppThis(), x, tol2, (GenCell == null) ? default(HandleRef) : GenCell.GetCppThis(), pcoords, weights);
		}

		// Token: 0x0600DD18 RID: 56600
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractCellLocator_FindCell_06(HandleRef pThis, IntPtr x, double tol2, HandleRef GenCell, ref int subId, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Find the cell containing a given point. returns -1 if no cell found
		/// the cell parameters are copied into the supplied variables, a cell must
		/// be provided to store the information.
		///
		/// THIS FUNCTION IS THREAD SAFE.
		/// </summary>
		// Token: 0x0600DD19 RID: 56601 RVA: 0x00132D34 File Offset: 0x00130F34
		public virtual long FindCell(IntPtr x, double tol2, vtkGenericCell GenCell, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_FindCell_06(base.GetCppThis(), x, tol2, (GenCell == null) ? default(HandleRef) : GenCell.GetCppThis(), ref subId, pcoords, weights);
		}

		// Token: 0x0600DD1A RID: 56602
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractCellLocator_FindCellsAlongLine_07(HandleRef pThis, IntPtr p1, IntPtr p2, double tolerance, HandleRef cells);

		/// <summary>
		/// Take the passed line segment and intersect it with the data set.
		/// For each intersection with the bounds of a cell, the cellIds
		/// have the relevant information added sort by t. If cellIds is nullptr
		/// pointer, then no information is generated for that list.
		///
		/// A vtkAbstractCellLocator subclass needs to implement IntersectWithLine that
		/// takes cells ids, which is used internally to implement FindCellsAlongLine.
		///
		/// THIS FUNCTION IS THREAD SAFE.
		/// </summary>
		// Token: 0x0600DD1B RID: 56603 RVA: 0x00132D70 File Offset: 0x00130F70
		public virtual void FindCellsAlongLine(IntPtr p1, IntPtr p2, double tolerance, vtkIdList cells)
		{
			vtkAbstractCellLocator.vtkAbstractCellLocator_FindCellsAlongLine_07(base.GetCppThis(), p1, p2, tolerance, (cells == null) ? default(HandleRef) : cells.GetCppThis());
		}

		// Token: 0x0600DD1C RID: 56604
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractCellLocator_FindCellsAlongPlane_08(HandleRef pThis, IntPtr o, IntPtr n, double tolerance, HandleRef cells);

		/// <summary>
		/// Given an unbounded plane defined by an origin o[3] and unit normal n[3],
		/// return the list of unique cell ids in the buckets containing the
		/// plane. It is possible that an empty cell list is returned. The user must
		/// provide the vtkIdList cell list to populate. This method returns data
		/// only after the locator has been built.
		///
		/// THIS FUNCTION IS THREAD SAFE.
		/// </summary>
		// Token: 0x0600DD1D RID: 56605 RVA: 0x00132DA4 File Offset: 0x00130FA4
		public virtual void FindCellsAlongPlane(IntPtr o, IntPtr n, double tolerance, vtkIdList cells)
		{
			vtkAbstractCellLocator.vtkAbstractCellLocator_FindCellsAlongPlane_08(base.GetCppThis(), o, n, tolerance, (cells == null) ? default(HandleRef) : cells.GetCppThis());
		}

		// Token: 0x0600DD1E RID: 56606
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractCellLocator_FindCellsWithinBounds_09(HandleRef pThis, IntPtr bbox, HandleRef cells);

		/// <summary>
		/// Return a list of unique cell ids inside of a given bounding box. The
		/// user must provide the vtkIdList to populate.
		///
		/// THIS FUNCTION IS THREAD SAFE.
		/// </summary>
		// Token: 0x0600DD1F RID: 56607 RVA: 0x00132DD8 File Offset: 0x00130FD8
		public virtual void FindCellsWithinBounds(IntPtr bbox, vtkIdList cells)
		{
			vtkAbstractCellLocator.vtkAbstractCellLocator_FindCellsWithinBounds_09(base.GetCppThis(), bbox, (cells == null) ? default(HandleRef) : cells.GetCppThis());
		}

		// Token: 0x0600DD20 RID: 56608
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractCellLocator_FindClosestPoint_10(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref long cellId, ref int subId, ref double dist2);

		/// <summary>
		/// Return the closest point and the cell which is closest to the point x.
		/// The closest point is somewhere on a cell, it need not be one of the
		/// vertices of the cell.
		///
		/// A vtkAbstractCellLocator subclass needs to implement FindClosestPointWithinRadius
		/// which is used internally to implement FindClosestPoint.
		///
		/// THIS FUNCTION IS NOT THREAD SAFE.
		/// </summary>
		// Token: 0x0600DD21 RID: 56609 RVA: 0x00132E08 File Offset: 0x00131008
		public virtual void FindClosestPoint(IntPtr x, IntPtr closestPoint, ref long cellId, ref int subId, ref double dist2)
		{
			vtkAbstractCellLocator.vtkAbstractCellLocator_FindClosestPoint_10(base.GetCppThis(), x, closestPoint, ref cellId, ref subId, ref dist2);
		}

		// Token: 0x0600DD22 RID: 56610
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractCellLocator_FindClosestPoint_11(HandleRef pThis, IntPtr x, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2);

		/// <summary>
		/// Return the closest point and the cell which is closest to the point x.
		/// The closest point is somewhere on a cell, it need not be one of the
		/// vertices of the cell.
		///
		/// A vtkAbstractCellLocator subclass needs to implement FindClosestPointWithinRadius
		/// which is used internally to implement FindClosestPoint.
		///
		/// This function takes in a vtkGenericCell to avoid using the internal vtkGenericCell.
		///
		/// THIS FUNCTION IS THREAD SAFE.
		/// </summary>
		// Token: 0x0600DD23 RID: 56611 RVA: 0x00132E20 File Offset: 0x00131020
		public virtual void FindClosestPoint(IntPtr x, IntPtr closestPoint, vtkGenericCell cell, ref long cellId, ref int subId, ref double dist2)
		{
			vtkAbstractCellLocator.vtkAbstractCellLocator_FindClosestPoint_11(base.GetCppThis(), x, closestPoint, (cell == null) ? default(HandleRef) : cell.GetCppThis(), ref cellId, ref subId, ref dist2);
		}

		// Token: 0x0600DD24 RID: 56612
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractCellLocator_FindClosestPointWithinRadius_12(HandleRef pThis, IntPtr x, double radius, IntPtr closestPoint, ref long cellId, ref int subId, ref double dist2);

		/// <summary>
		/// Return the closest point within a specified radius and the cell which is
		/// closest to the point x. The closest point is somewhere on a cell, it
		/// need not be one of the vertices of the cell. This method returns 1 if
		/// a point is found within the specified radius. If there are no cells within
		/// the specified radius, the method returns 0 and the values of closestPoint,
		/// cellId, subId, and dist2 are undefined.
		///
		/// THIS FUNCTION IS NOT THREAD SAFE.
		/// </summary>
		// Token: 0x0600DD25 RID: 56613 RVA: 0x00132E58 File Offset: 0x00131058
		public virtual long FindClosestPointWithinRadius(IntPtr x, double radius, IntPtr closestPoint, ref long cellId, ref int subId, ref double dist2)
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_FindClosestPointWithinRadius_12(base.GetCppThis(), x, radius, closestPoint, ref cellId, ref subId, ref dist2);
		}

		// Token: 0x0600DD26 RID: 56614
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractCellLocator_FindClosestPointWithinRadius_13(HandleRef pThis, IntPtr x, double radius, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2);

		/// <summary>
		/// Return the closest point within a specified radius and the cell which is
		/// closest to the point x. The closest point is somewhere on a cell, it
		/// need not be one of the vertices of the cell. This method returns 1 if
		/// a point is found within the specified radius. If there are no cells within
		/// the specified radius, the method returns 0 and the values of closestPoint,
		/// cellId, subId, and dist2 are undefined.
		///
		/// This function takes in a vtkGenericCell to avoid using the internal vtkGenericCell.
		///
		/// THIS FUNCTION IS THREAD SAFE.
		/// </summary>
		// Token: 0x0600DD27 RID: 56615 RVA: 0x00132E80 File Offset: 0x00131080
		public virtual long FindClosestPointWithinRadius(IntPtr x, double radius, IntPtr closestPoint, vtkGenericCell cell, ref long cellId, ref int subId, ref double dist2)
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_FindClosestPointWithinRadius_13(base.GetCppThis(), x, radius, closestPoint, (cell == null) ? default(HandleRef) : cell.GetCppThis(), ref cellId, ref subId, ref dist2);
		}

		// Token: 0x0600DD28 RID: 56616
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractCellLocator_FindClosestPointWithinRadius_14(HandleRef pThis, IntPtr x, double radius, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2, ref int inside);

		/// <summary>
		/// Return the closest point within a specified radius and the cell which is
		/// closest to the point x. The closest point is somewhere on a cell, it
		/// need not be one of the vertices of the cell. This method returns 1 if a
		/// point is found within the specified radius. If there are no cells within
		/// the specified radius, the method returns 0 and the values of
		/// closestPoint, cellId, subId, and dist2 are undefined. If a closest point
		/// is found, inside returns the return value of the EvaluatePosition call to
		/// the closest cell; inside(=1) or outside(=0).
		///
		/// This function takes in a vtkGenericCell to avoid using the internal vtkGenericCell.
		///
		/// THIS FUNCTION IS THREAD SAFE.
		/// </summary>
		// Token: 0x0600DD29 RID: 56617 RVA: 0x00132EC0 File Offset: 0x001310C0
		public virtual long FindClosestPointWithinRadius(IntPtr x, double radius, IntPtr closestPoint, vtkGenericCell cell, ref long cellId, ref int subId, ref double dist2, ref int inside)
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_FindClosestPointWithinRadius_14(base.GetCppThis(), x, radius, closestPoint, (cell == null) ? default(HandleRef) : cell.GetCppThis(), ref cellId, ref subId, ref dist2, ref inside);
		}

		// Token: 0x0600DD2A RID: 56618
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractCellLocator_GetCacheCellBounds_15(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether the bounds of each cell are computed only
		/// once and then saved.  Should be 10 to 20% faster if repeatedly
		/// calling any of the Intersect/Find routines and the extra memory
		/// won't cause disk caching (48 extra bytes per cell are required to
		/// save the bounds).
		/// </summary>
		// Token: 0x0600DD2B RID: 56619 RVA: 0x00132F04 File Offset: 0x00131104
		public virtual int GetCacheCellBounds()
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_GetCacheCellBounds_15(base.GetCppThis());
		}

		// Token: 0x0600DD2C RID: 56620
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractCellLocator_GetNumberOfCellsPerNode_16(HandleRef pThis);

		/// <summary>
		/// Specify the preferred/maximum number of cells in each node/bucket.
		/// Default 32. Locators generally operate by subdividing space into
		/// smaller regions until the number of cells in each region (or node)
		/// reaches the desired level.
		/// </summary>
		// Token: 0x0600DD2D RID: 56621 RVA: 0x00132F24 File Offset: 0x00131124
		public virtual int GetNumberOfCellsPerNode()
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_GetNumberOfCellsPerNode_16(base.GetCppThis());
		}

		// Token: 0x0600DD2E RID: 56622
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractCellLocator_GetNumberOfCellsPerNodeMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Specify the preferred/maximum number of cells in each node/bucket.
		/// Default 32. Locators generally operate by subdividing space into
		/// smaller regions until the number of cells in each region (or node)
		/// reaches the desired level.
		/// </summary>
		// Token: 0x0600DD2F RID: 56623 RVA: 0x00132F44 File Offset: 0x00131144
		public virtual int GetNumberOfCellsPerNodeMaxValue()
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_GetNumberOfCellsPerNodeMaxValue_17(base.GetCppThis());
		}

		// Token: 0x0600DD30 RID: 56624
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractCellLocator_GetNumberOfCellsPerNodeMinValue_18(HandleRef pThis);

		/// <summary>
		/// Specify the preferred/maximum number of cells in each node/bucket.
		/// Default 32. Locators generally operate by subdividing space into
		/// smaller regions until the number of cells in each region (or node)
		/// reaches the desired level.
		/// </summary>
		// Token: 0x0600DD31 RID: 56625 RVA: 0x00132F64 File Offset: 0x00131164
		public virtual int GetNumberOfCellsPerNodeMinValue()
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_GetNumberOfCellsPerNodeMinValue_18(base.GetCppThis());
		}

		// Token: 0x0600DD32 RID: 56626
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractCellLocator_GetNumberOfGenerationsFromBase_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DD33 RID: 56627 RVA: 0x00132F84 File Offset: 0x00131184
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_GetNumberOfGenerationsFromBase_19(base.GetCppThis(), type);
		}

		// Token: 0x0600DD34 RID: 56628
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractCellLocator_GetNumberOfGenerationsFromBaseType_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DD35 RID: 56629 RVA: 0x00132FA4 File Offset: 0x001311A4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_GetNumberOfGenerationsFromBaseType_20(type);
		}

		// Token: 0x0600DD36 RID: 56630
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractCellLocator_GetRetainCellLists_21(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether to maintain list of cells in each node.
		/// not applicable to all implementations, but if the locator is being used
		/// as a geometry simplification technique, there is no need to keep them.
		/// </summary>
		// Token: 0x0600DD37 RID: 56631 RVA: 0x00132FC0 File Offset: 0x001311C0
		public virtual int GetRetainCellLists()
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_GetRetainCellLists_21(base.GetCppThis());
		}

		// Token: 0x0600DD38 RID: 56632
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAbstractCellLocator_InsideCellBounds_22(HandleRef pThis, IntPtr x, long cell_ID);

		/// <summary>
		/// Quickly test if a point is inside the bounds of a particular cell.
		/// Some locators cache cell bounds and this function can make use
		/// of fast access to the data. This function should be used ONLY after the locator is built.
		/// </summary>
		// Token: 0x0600DD39 RID: 56633 RVA: 0x00132FE0 File Offset: 0x001311E0
		public virtual bool InsideCellBounds(IntPtr x, long cell_ID)
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_InsideCellBounds_22(base.GetCppThis(), x, cell_ID) != 0;
		}

		// Token: 0x0600DD3A RID: 56634
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractCellLocator_IntersectWithLine_23(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		/// <summary>
		/// Return intersection point (if any) of finite line with cells contained
		/// in cell locator. See vtkCell.h parameters documentation.
		///
		/// THIS FUNCTION IS NOT THREAD SAFE.
		/// </summary>
		// Token: 0x0600DD3B RID: 56635 RVA: 0x00133008 File Offset: 0x00131208
		public virtual int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_IntersectWithLine_23(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		// Token: 0x0600DD3C RID: 56636
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractCellLocator_IntersectWithLine_24(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId);

		/// <summary>
		/// Return intersection point (if any) AND the cell which was intersected by
		/// the finite line.
		///
		/// THIS FUNCTION IS NOT THREAD SAFE.
		/// </summary>
		// Token: 0x0600DD3D RID: 56637 RVA: 0x00133034 File Offset: 0x00131234
		public virtual int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId)
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_IntersectWithLine_24(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId, ref cellId);
		}

		// Token: 0x0600DD3E RID: 56638
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractCellLocator_IntersectWithLine_25(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, HandleRef cell);

		/// <summary>
		/// Return intersection point (if any) AND the cell which was intersected by
		/// the finite line. The cell is returned as a cell id and as a generic cell.
		///
		/// This function takes in a vtkGenericCell to avoid using the internal vtkGenericCell.
		///
		/// THIS FUNCTION IS THREAD SAFE.
		/// </summary>
		// Token: 0x0600DD3F RID: 56639 RVA: 0x00133060 File Offset: 0x00131260
		public virtual int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, vtkGenericCell cell)
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_IntersectWithLine_25(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId, ref cellId, (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x0600DD40 RID: 56640
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractCellLocator_IntersectWithLine_26(HandleRef pThis, IntPtr p1, IntPtr p2, HandleRef points, HandleRef cellIds);

		/// <summary>
		/// Take the passed line segment and intersect it with the data set.
		/// The return value of the function is 0 if no intersections were found,
		/// -1 if point 'a0' lies inside the closed surface, or +1 if point 'a0'
		/// lies outside the closed surface. This method assumes that the data set
		/// is a vtkPolyData that describes a closed surface, and the intersection
		/// points that are returned in 'points' alternate between entrance points and exit points.
		///
		/// Either 'points' or 'cellIds' can be set to nullptr if you don't want
		/// to receive that information.
		///
		/// This method is only implemented in vtkOBBTree.
		///
		/// THIS FUNCTION IS THREAD SAFE.
		/// </summary>
		// Token: 0x0600DD41 RID: 56641 RVA: 0x001330A4 File Offset: 0x001312A4
		public virtual int IntersectWithLine(IntPtr p1, IntPtr p2, vtkPoints points, vtkIdList cellIds)
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_IntersectWithLine_26(base.GetCppThis(), p1, p2, (points == null) ? default(HandleRef) : points.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		// Token: 0x0600DD42 RID: 56642
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractCellLocator_IntersectWithLine_27(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, HandleRef points, HandleRef cellIds);

		/// <summary>
		/// Take the passed line segment and intersect it with the data set.
		/// The return value of the function is 0 if no intersections were found.
		/// For each intersection with a cell, the points and cellIds have the relevant information
		/// added sorted by t. If points or cellIds are nullptr pointers, then no information is
		/// generated for that list.
		///
		/// THIS FUNCTION IS NOT THREAD SAFE.
		/// </summary>
		// Token: 0x0600DD43 RID: 56643 RVA: 0x001330F4 File Offset: 0x001312F4
		public virtual int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, vtkPoints points, vtkIdList cellIds)
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_IntersectWithLine_27(base.GetCppThis(), p1, p2, tol, (points == null) ? default(HandleRef) : points.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		// Token: 0x0600DD44 RID: 56644
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractCellLocator_IntersectWithLine_28(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, HandleRef points, HandleRef cellIds, HandleRef cell);

		/// <summary>
		/// Take the passed line segment and intersect it with the data set.
		/// The return value of the function is 0 if no intersections were found.
		/// For each intersection with the bounds of a cell or with a cell (if a cell is provided),
		/// the points and cellIds have the relevant information added sorted by t.
		/// If points or cellIds are nullptr pointers, then no information is generated for that list.
		///
		/// This function takes in a vtkGenericCell to avoid using the internal vtkGenericCell.
		///
		/// THIS FUNCTION IS THREAD SAFE.
		/// </summary>
		// Token: 0x0600DD45 RID: 56645 RVA: 0x00133144 File Offset: 0x00131344
		public virtual int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, vtkPoints points, vtkIdList cellIds, vtkGenericCell cell)
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_IntersectWithLine_28(base.GetCppThis(), p1, p2, tol, (points == null) ? default(HandleRef) : points.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x0600DD46 RID: 56646
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractCellLocator_IsA_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DD47 RID: 56647 RVA: 0x001331AC File Offset: 0x001313AC
		public override int IsA(string type)
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_IsA_29(base.GetCppThis(), type);
		}

		// Token: 0x0600DD48 RID: 56648
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractCellLocator_IsTypeOf_30([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DD49 RID: 56649 RVA: 0x001331CC File Offset: 0x001313CC
		public new static int IsTypeOf(string type)
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_IsTypeOf_30(type);
		}

		// Token: 0x0600DD4A RID: 56650
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractCellLocator_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DD4B RID: 56651 RVA: 0x001331E8 File Offset: 0x001313E8
		public new vtkAbstractCellLocator NewInstance()
		{
			vtkAbstractCellLocator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractCellLocator.vtkAbstractCellLocator_NewInstance_31(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractCellLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600DD4C RID: 56652
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractCellLocator_RetainCellListsOff_32(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether to maintain list of cells in each node.
		/// not applicable to all implementations, but if the locator is being used
		/// as a geometry simplification technique, there is no need to keep them.
		/// </summary>
		// Token: 0x0600DD4D RID: 56653 RVA: 0x00133242 File Offset: 0x00131442
		public virtual void RetainCellListsOff()
		{
			vtkAbstractCellLocator.vtkAbstractCellLocator_RetainCellListsOff_32(base.GetCppThis());
		}

		// Token: 0x0600DD4E RID: 56654
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractCellLocator_RetainCellListsOn_33(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether to maintain list of cells in each node.
		/// not applicable to all implementations, but if the locator is being used
		/// as a geometry simplification technique, there is no need to keep them.
		/// </summary>
		// Token: 0x0600DD4F RID: 56655 RVA: 0x00133251 File Offset: 0x00131451
		public virtual void RetainCellListsOn()
		{
			vtkAbstractCellLocator.vtkAbstractCellLocator_RetainCellListsOn_33(base.GetCppThis());
		}

		// Token: 0x0600DD50 RID: 56656
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractCellLocator_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DD51 RID: 56657 RVA: 0x00133260 File Offset: 0x00131460
		public new static vtkAbstractCellLocator SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractCellLocator vtkAbstractCellLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractCellLocator.vtkAbstractCellLocator_SafeDownCast_34((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractCellLocator = (vtkAbstractCellLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractCellLocator.Register(null);
				}
			}
			return vtkAbstractCellLocator;
		}

		// Token: 0x0600DD52 RID: 56658
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractCellLocator_SetCacheCellBounds_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Boolean controls whether the bounds of each cell are computed only
		/// once and then saved.  Should be 10 to 20% faster if repeatedly
		/// calling any of the Intersect/Find routines and the extra memory
		/// won't cause disk caching (48 extra bytes per cell are required to
		/// save the bounds).
		/// </summary>
		// Token: 0x0600DD53 RID: 56659 RVA: 0x001332DF File Offset: 0x001314DF
		public virtual void SetCacheCellBounds(int _arg)
		{
			vtkAbstractCellLocator.vtkAbstractCellLocator_SetCacheCellBounds_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DD54 RID: 56660
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractCellLocator_SetNumberOfCellsPerNode_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the preferred/maximum number of cells in each node/bucket.
		/// Default 32. Locators generally operate by subdividing space into
		/// smaller regions until the number of cells in each region (or node)
		/// reaches the desired level.
		/// </summary>
		// Token: 0x0600DD55 RID: 56661 RVA: 0x001332EF File Offset: 0x001314EF
		public virtual void SetNumberOfCellsPerNode(int _arg)
		{
			vtkAbstractCellLocator.vtkAbstractCellLocator_SetNumberOfCellsPerNode_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DD56 RID: 56662
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractCellLocator_SetRetainCellLists_37(HandleRef pThis, int _arg);

		/// <summary>
		/// Boolean controls whether to maintain list of cells in each node.
		/// not applicable to all implementations, but if the locator is being used
		/// as a geometry simplification technique, there is no need to keep them.
		/// </summary>
		// Token: 0x0600DD57 RID: 56663 RVA: 0x001332FF File Offset: 0x001314FF
		public virtual void SetRetainCellLists(int _arg)
		{
			vtkAbstractCellLocator.vtkAbstractCellLocator_SetRetainCellLists_37(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DD58 RID: 56664
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractCellLocator_ShallowCopy_38(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Shallow copy of a vtkAbstractCellLocator.
		/// </summary>
		// Token: 0x0600DD59 RID: 56665 RVA: 0x00133310 File Offset: 0x00131510
		public virtual void ShallowCopy(vtkAbstractCellLocator arg0)
		{
			vtkAbstractCellLocator.vtkAbstractCellLocator_ShallowCopy_38(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001027 RID: 4135
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractCellLocator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001028 RID: 4136
		public new static readonly string MRClassNameKey = "class vtkAbstractCellLocator";
	}
}
