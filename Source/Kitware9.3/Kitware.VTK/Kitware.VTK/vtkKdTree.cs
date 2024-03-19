using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkKdTree
	/// </summary>
	/// <remarks>
	///    a Kd-tree spatial decomposition of a set of points
	///
	///
	///     Given one or more vtkDataSets, create a load balancing
	///     k-d tree decomposition of the points at the center of the cells.
	///     Or, create a k-d tree point locator from a list of points.
	///
	///     This class can also generate a PolyData representation of
	///     the boundaries of the spatial regions in the decomposition.
	///
	///     It can sort the regions with respect to a viewing direction,
	///     and it can decompose a list of regions into subsets, each
	///     of which represent a convex spatial region (since many algorithms
	///     require a convex region).
	///
	///     If the points were derived from cells, vtkKdTree
	///     can create a list of cell Ids for each region for each data set.
	///     Two lists are available - all cells with centroid in the region,
	///     and all cells that intersect the region but whose centroid lies
	///     in another region.
	///
	///     For the purpose of removing duplicate points quickly from large
	///     data sets, or for finding nearby points, we added another mode for
	///     building the locator.  BuildLocatorFromPoints will build a k-d tree
	///     from one or more vtkPoints objects.  This can be followed by
	///     BuildMapForDuplicatePoints which returns a mapping from the original
	///     ids to a subset of the ids that is unique within a supplied
	///     tolerance, or you can use FindPoint and FindClosestPoint to
	///     locate points in the original set that the tree was built from.
	///
	/// </remarks>
	/// <seealso>
	///
	///      vtkLocator vtkCellLocator vtkPKdTree
	/// </seealso>
	// Token: 0x02000518 RID: 1304
	public class vtkKdTree : vtkLocator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E8FC RID: 59644 RVA: 0x00144F83 File Offset: 0x00143183
		static vtkKdTree()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkKdTree.MRClassNameKey, Type.GetType("Kitware.VTK.vtkKdTree"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E8FD RID: 59645 RVA: 0x00144FAB File Offset: 0x001431AB
		public vtkKdTree(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E8FE RID: 59646
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdTree_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E8FF RID: 59647 RVA: 0x00144FBC File Offset: 0x001431BC
		public new static vtkKdTree New()
		{
			vtkKdTree result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKdTree.vtkKdTree_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKdTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E900 RID: 59648 RVA: 0x00145010 File Offset: 0x00143210
		public vtkKdTree() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkKdTree.vtkKdTree_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E901 RID: 59649 RVA: 0x00145054 File Offset: 0x00143254
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E902 RID: 59650
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_AddDataSet_01(HandleRef pThis, HandleRef set);

		/// <summary>
		/// This class can compute a spatial decomposition based on the cells in a list
		/// of one or more input data sets.  Add them one at a time with this method.
		/// </summary>
		// Token: 0x0600E903 RID: 59651 RVA: 0x00145060 File Offset: 0x00143260
		public virtual void AddDataSet(vtkDataSet set)
		{
			vtkKdTree.vtkKdTree_AddDataSet_01(base.GetCppThis(), (set == null) ? default(HandleRef) : set.GetCppThis());
		}

		// Token: 0x0600E904 RID: 59652
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdTree_AllGetRegionContainingCell_02(HandleRef pThis);

		/// <summary>
		/// Get a list (in order by data set by cell id) of the
		/// region IDs of the region containing the centroid for
		/// each cell.
		/// This is faster than calling GetRegionContainingCell
		/// for each cell in the DataSet.
		/// vtkKdTree uses this list, so don't delete it.
		/// </summary>
		// Token: 0x0600E905 RID: 59653 RVA: 0x00145090 File Offset: 0x00143290
		public IntPtr AllGetRegionContainingCell()
		{
			return vtkKdTree.vtkKdTree_AllGetRegionContainingCell_02(base.GetCppThis());
		}

		// Token: 0x0600E906 RID: 59654
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_BuildLocator_03(HandleRef pThis);

		/// <summary>
		/// Create the k-d tree decomposition of the cells of the data set
		/// or data sets.  Cells are assigned to k-d tree spatial regions
		/// based on the location of their centroids.
		/// </summary>
		// Token: 0x0600E907 RID: 59655 RVA: 0x001450AF File Offset: 0x001432AF
		public override void BuildLocator()
		{
			vtkKdTree.vtkKdTree_BuildLocator_03(base.GetCppThis());
		}

		// Token: 0x0600E908 RID: 59656
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_BuildLocatorFromPoints_04(HandleRef pThis, HandleRef pointset);

		/// <summary>
		/// This is a special purpose locator that builds a k-d tree to
		/// find duplicate and near-by points.  It builds the tree from
		/// one or more vtkPoints objects instead of from the cells of
		/// a vtkDataSet.  This build would normally be followed by
		/// BuildMapForDuplicatePoints, FindPoint, or FindClosestPoint.
		/// Since this will build a normal k-d tree, all the region intersection
		/// queries will still work, as will most other calls except those that
		/// have "Cell" in the name.
		///
		/// This method works most efficiently when the point arrays are
		/// float arrays.
		/// </summary>
		// Token: 0x0600E909 RID: 59657 RVA: 0x001450C0 File Offset: 0x001432C0
		public void BuildLocatorFromPoints(vtkPointSet pointset)
		{
			vtkKdTree.vtkKdTree_BuildLocatorFromPoints_04(base.GetCppThis(), (pointset == null) ? default(HandleRef) : pointset.GetCppThis());
		}

		// Token: 0x0600E90A RID: 59658
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_BuildLocatorFromPoints_05(HandleRef pThis, HandleRef ptArray);

		/// <summary>
		/// This is a special purpose locator that builds a k-d tree to
		/// find duplicate and near-by points.  It builds the tree from
		/// one or more vtkPoints objects instead of from the cells of
		/// a vtkDataSet.  This build would normally be followed by
		/// BuildMapForDuplicatePoints, FindPoint, or FindClosestPoint.
		/// Since this will build a normal k-d tree, all the region intersection
		/// queries will still work, as will most other calls except those that
		/// have "Cell" in the name.
		///
		/// This method works most efficiently when the point arrays are
		/// float arrays.
		/// </summary>
		// Token: 0x0600E90B RID: 59659 RVA: 0x001450F0 File Offset: 0x001432F0
		public void BuildLocatorFromPoints(vtkPoints ptArray)
		{
			vtkKdTree.vtkKdTree_BuildLocatorFromPoints_05(base.GetCppThis(), (ptArray == null) ? default(HandleRef) : ptArray.GetCppThis());
		}

		// Token: 0x0600E90C RID: 59660
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdTree_BuildMapForDuplicatePoints_06(HandleRef pThis, float tolerance, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This call returns a mapping from the original point IDs supplied
		/// to BuildLocatorFromPoints to a subset of those IDs that is unique
		/// within the specified tolerance.
		/// If points 2, 5, and 12 are the same, then
		/// IdMap[2] = IdMap[5] = IdMap[12] = 2 (or 5 or 12).
		///
		/// "original point IDs" - For point IDs we start at 0 for the first
		/// point in the first vtkPoints object, and increase by 1 for subsequent
		/// points and subsequent vtkPoints objects.
		///
		/// You must have called BuildLocatorFromPoints() before calling this.
		/// You are responsible for deleting the returned array.
		/// </summary>
		// Token: 0x0600E90D RID: 59661 RVA: 0x00145120 File Offset: 0x00143320
		public vtkIdTypeArray BuildMapForDuplicatePoints(float tolerance)
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKdTree.vtkKdTree_BuildMapForDuplicatePoints_06(base.GetCppThis(), tolerance, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		// Token: 0x0600E90E RID: 59662
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdTree_CopyTree_07(HandleRef kd, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a copy of the binary tree representation of the
		/// k-d tree spatial partitioning provided.
		/// </summary>
		// Token: 0x0600E90F RID: 59663 RVA: 0x00145190 File Offset: 0x00143390
		public static vtkKdNode CopyTree(vtkKdNode kd)
		{
			vtkKdNode vtkKdNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKdTree.vtkKdTree_CopyTree_07((kd == null) ? default(HandleRef) : kd.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKdNode = (vtkKdNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKdNode.Register(null);
				}
			}
			return vtkKdNode;
		}

		// Token: 0x0600E910 RID: 59664
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_CreateCellLists_08(HandleRef pThis, int dataSetIndex, IntPtr regionReqList, int reqListSize);

		/// <summary>
		/// Create a list for each of the requested regions, listing
		/// the IDs of all cells whose centroid falls in the region.
		/// These lists are obtained with GetCellList().
		/// If no DataSet is specified, the cell list is created
		/// for DataSet 0.  If no list of requested regions is provided,
		/// the cell lists for all regions are created.
		///
		/// When CreateCellLists is called again, the lists created
		/// on the previous call are deleted.
		/// </summary>
		// Token: 0x0600E911 RID: 59665 RVA: 0x0014520F File Offset: 0x0014340F
		public void CreateCellLists(int dataSetIndex, IntPtr regionReqList, int reqListSize)
		{
			vtkKdTree.vtkKdTree_CreateCellLists_08(base.GetCppThis(), dataSetIndex, regionReqList, reqListSize);
		}

		// Token: 0x0600E912 RID: 59666
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_CreateCellLists_09(HandleRef pThis, HandleRef set, IntPtr regionReqList, int reqListSize);

		/// <summary>
		/// Create a list for each of the requested regions, listing
		/// the IDs of all cells whose centroid falls in the region.
		/// These lists are obtained with GetCellList().
		/// If no DataSet is specified, the cell list is created
		/// for DataSet 0.  If no list of requested regions is provided,
		/// the cell lists for all regions are created.
		///
		/// When CreateCellLists is called again, the lists created
		/// on the previous call are deleted.
		/// </summary>
		// Token: 0x0600E913 RID: 59667 RVA: 0x00145224 File Offset: 0x00143424
		public void CreateCellLists(vtkDataSet set, IntPtr regionReqList, int reqListSize)
		{
			vtkKdTree.vtkKdTree_CreateCellLists_09(base.GetCppThis(), (set == null) ? default(HandleRef) : set.GetCppThis(), regionReqList, reqListSize);
		}

		// Token: 0x0600E914 RID: 59668
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_CreateCellLists_10(HandleRef pThis, IntPtr regionReqList, int listSize);

		/// <summary>
		/// Create a list for each of the requested regions, listing
		/// the IDs of all cells whose centroid falls in the region.
		/// These lists are obtained with GetCellList().
		/// If no DataSet is specified, the cell list is created
		/// for DataSet 0.  If no list of requested regions is provided,
		/// the cell lists for all regions are created.
		///
		/// When CreateCellLists is called again, the lists created
		/// on the previous call are deleted.
		/// </summary>
		// Token: 0x0600E915 RID: 59669 RVA: 0x00145255 File Offset: 0x00143455
		public void CreateCellLists(IntPtr regionReqList, int listSize)
		{
			vtkKdTree.vtkKdTree_CreateCellLists_10(base.GetCppThis(), regionReqList, listSize);
		}

		// Token: 0x0600E916 RID: 59670
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_CreateCellLists_11(HandleRef pThis);

		/// <summary>
		/// Create a list for each of the requested regions, listing
		/// the IDs of all cells whose centroid falls in the region.
		/// These lists are obtained with GetCellList().
		/// If no DataSet is specified, the cell list is created
		/// for DataSet 0.  If no list of requested regions is provided,
		/// the cell lists for all regions are created.
		///
		/// When CreateCellLists is called again, the lists created
		/// on the previous call are deleted.
		/// </summary>
		// Token: 0x0600E917 RID: 59671 RVA: 0x00145266 File Offset: 0x00143466
		public void CreateCellLists()
		{
			vtkKdTree.vtkKdTree_CreateCellLists_11(base.GetCppThis());
		}

		// Token: 0x0600E918 RID: 59672
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_DeleteCellLists_12(HandleRef pThis);

		/// <summary>
		/// Free the memory used by the cell lists.
		/// </summary>
		// Token: 0x0600E919 RID: 59673 RVA: 0x00145275 File Offset: 0x00143475
		public void DeleteCellLists()
		{
			vtkKdTree.vtkKdTree_DeleteCellLists_12(base.GetCppThis());
		}

		// Token: 0x0600E91A RID: 59674
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_FindClosestNPoints_13(HandleRef pThis, int N, IntPtr x, HandleRef result);

		/// <summary>
		/// Find the closest N points to a position. This returns the closest
		/// N points to a position. A faster method could be created that returned
		/// N close points to a position, but necessarily the exact N closest.
		/// The returned points are sorted from closest to farthest.
		/// These methods are thread safe if BuildLocator() is directly or
		/// indirectly called from a single thread first.
		/// </summary>
		// Token: 0x0600E91B RID: 59675 RVA: 0x00145284 File Offset: 0x00143484
		public void FindClosestNPoints(int N, IntPtr x, vtkIdList result)
		{
			vtkKdTree.vtkKdTree_FindClosestNPoints_13(base.GetCppThis(), N, x, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		// Token: 0x0600E91C RID: 59676
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKdTree_FindClosestPoint_14(HandleRef pThis, IntPtr x, ref double dist2);

		/// <summary>
		/// Find the Id of the point that was previously supplied
		/// to BuildLocatorFromPoints() which is closest to the given point.
		/// Set the square of the distance between the two points.
		/// </summary>
		// Token: 0x0600E91D RID: 59677 RVA: 0x001452B8 File Offset: 0x001434B8
		public long FindClosestPoint(IntPtr x, ref double dist2)
		{
			return vtkKdTree.vtkKdTree_FindClosestPoint_14(base.GetCppThis(), x, ref dist2);
		}

		// Token: 0x0600E91E RID: 59678
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKdTree_FindClosestPoint_15(HandleRef pThis, double x, double y, double z, ref double dist2);

		/// <summary>
		/// Find the Id of the point that was previously supplied
		/// to BuildLocatorFromPoints() which is closest to the given point.
		/// Set the square of the distance between the two points.
		/// </summary>
		// Token: 0x0600E91F RID: 59679 RVA: 0x001452DC File Offset: 0x001434DC
		public long FindClosestPoint(double x, double y, double z, ref double dist2)
		{
			return vtkKdTree.vtkKdTree_FindClosestPoint_15(base.GetCppThis(), x, y, z, ref dist2);
		}

		// Token: 0x0600E920 RID: 59680
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKdTree_FindClosestPointInRegion_16(HandleRef pThis, int regionId, IntPtr x, ref double dist2);

		/// <summary>
		/// Find the Id of the point in the given region which is
		/// closest to the given point.  Return the ID of the point,
		/// and set the square of the distance of between the points.
		/// </summary>
		// Token: 0x0600E921 RID: 59681 RVA: 0x00145300 File Offset: 0x00143500
		public long FindClosestPointInRegion(int regionId, IntPtr x, ref double dist2)
		{
			return vtkKdTree.vtkKdTree_FindClosestPointInRegion_16(base.GetCppThis(), regionId, x, ref dist2);
		}

		// Token: 0x0600E922 RID: 59682
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKdTree_FindClosestPointInRegion_17(HandleRef pThis, int regionId, double x, double y, double z, ref double dist2);

		/// <summary>
		/// Find the Id of the point in the given region which is
		/// closest to the given point.  Return the ID of the point,
		/// and set the square of the distance of between the points.
		/// </summary>
		// Token: 0x0600E923 RID: 59683 RVA: 0x00145324 File Offset: 0x00143524
		public long FindClosestPointInRegion(int regionId, double x, double y, double z, ref double dist2)
		{
			return vtkKdTree.vtkKdTree_FindClosestPointInRegion_17(base.GetCppThis(), regionId, x, y, z, ref dist2);
		}

		// Token: 0x0600E924 RID: 59684
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKdTree_FindClosestPointWithinRadius_18(HandleRef pThis, double radius, IntPtr x, ref double dist2);

		/// <summary>
		/// Given a position x and a radius r, return the id of the point
		/// closest to the point in that radius.
		/// dist2 returns the squared distance to the point.
		/// </summary>
		// Token: 0x0600E925 RID: 59685 RVA: 0x0014534C File Offset: 0x0014354C
		public long FindClosestPointWithinRadius(double radius, IntPtr x, ref double dist2)
		{
			return vtkKdTree.vtkKdTree_FindClosestPointWithinRadius_18(base.GetCppThis(), radius, x, ref dist2);
		}

		// Token: 0x0600E926 RID: 59686
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKdTree_FindPoint_19(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Find the Id of the point that was previously supplied
		/// to BuildLocatorFromPoints().  Returns -1 if the point
		/// was not in the original array.
		/// </summary>
		// Token: 0x0600E927 RID: 59687 RVA: 0x00145370 File Offset: 0x00143570
		public long FindPoint(IntPtr x)
		{
			return vtkKdTree.vtkKdTree_FindPoint_19(base.GetCppThis(), x);
		}

		// Token: 0x0600E928 RID: 59688
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKdTree_FindPoint_20(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Find the Id of the point that was previously supplied
		/// to BuildLocatorFromPoints().  Returns -1 if the point
		/// was not in the original array.
		/// </summary>
		// Token: 0x0600E929 RID: 59689 RVA: 0x00145390 File Offset: 0x00143590
		public long FindPoint(double x, double y, double z)
		{
			return vtkKdTree.vtkKdTree_FindPoint_20(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0600E92A RID: 59690
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_FindPointsInArea_21(HandleRef pThis, IntPtr area, HandleRef ids, byte clearArray);

		/// <summary>
		/// Fill ids with points found in area.  The area is a 6-tuple containing
		/// (xmin, xmax, ymin, ymax, zmin, zmax).
		/// This method will clear the array by default.  To append ids to an array,
		/// set clearArray to false.
		/// </summary>
		// Token: 0x0600E92B RID: 59691 RVA: 0x001453B4 File Offset: 0x001435B4
		public void FindPointsInArea(IntPtr area, vtkIdTypeArray ids, bool clearArray)
		{
			vtkKdTree.vtkKdTree_FindPointsInArea_21(base.GetCppThis(), area, (ids == null) ? default(HandleRef) : ids.GetCppThis(), clearArray ? (byte)1 : (byte)0);
		}

		// Token: 0x0600E92C RID: 59692
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_FindPointsWithinRadius_22(HandleRef pThis, double R, IntPtr x, HandleRef result);

		/// <summary>
		/// Find all points within a specified radius R of position x.
		/// The result is not sorted in any specific manner.
		/// These methods are thread safe if BuildLocator() is directly or
		/// indirectly called from a single thread first.
		/// </summary>
		// Token: 0x0600E92D RID: 59693 RVA: 0x001453F0 File Offset: 0x001435F0
		public void FindPointsWithinRadius(double R, IntPtr x, vtkIdList result)
		{
			vtkKdTree.vtkKdTree_FindPointsWithinRadius_22(base.GetCppThis(), R, x, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		// Token: 0x0600E92E RID: 59694
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_ForceBuildLocator_23(HandleRef pThis);

		/// <summary>
		/// Build the locator from the input dataset (even if UseExistingSearchStructure is on).
		/// </summary>
		// Token: 0x0600E92F RID: 59695 RVA: 0x00145421 File Offset: 0x00143621
		public override void ForceBuildLocator()
		{
			vtkKdTree.vtkKdTree_ForceBuildLocator_23(base.GetCppThis());
		}

		// Token: 0x0600E930 RID: 59696
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_FreeSearchStructure_24(HandleRef pThis);

		/// <summary>
		/// Delete the k-d tree data structure. Also delete any
		/// cell lists that were computed with CreateCellLists().
		/// </summary>
		// Token: 0x0600E931 RID: 59697 RVA: 0x00145430 File Offset: 0x00143630
		public override void FreeSearchStructure()
		{
			vtkKdTree.vtkKdTree_FreeSearchStructure_24(base.GetCppThis());
		}

		// Token: 0x0600E932 RID: 59698
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_GenerateRepresentation_25(HandleRef pThis, int level, HandleRef pd);

		/// <summary>
		/// Create a polydata representation of the boundaries of
		/// the k-d tree regions.  If level equals GetLevel(), the
		/// leaf nodes are represented.
		/// </summary>
		// Token: 0x0600E933 RID: 59699 RVA: 0x00145440 File Offset: 0x00143640
		public override void GenerateRepresentation(int level, vtkPolyData pd)
		{
			vtkKdTree.vtkKdTree_GenerateRepresentation_25(base.GetCppThis(), level, (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0600E934 RID: 59700
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_GenerateRepresentation_26(HandleRef pThis, IntPtr regionList, int len, HandleRef pd);

		/// <summary>
		/// Generate a polygonal representation of a list of regions.
		/// Only leaf nodes have region IDs, so these will be leaf nodes.
		/// </summary>
		// Token: 0x0600E935 RID: 59701 RVA: 0x00145470 File Offset: 0x00143670
		public void GenerateRepresentation(IntPtr regionList, int len, vtkPolyData pd)
		{
			vtkKdTree.vtkKdTree_GenerateRepresentation_26(base.GetCppThis(), regionList, len, (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0600E936 RID: 59702
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_GenerateRepresentationUsingDataBoundsOff_27(HandleRef pThis);

		/// <summary>
		/// The polydata representation of the k-d tree shows the boundaries
		/// of the k-d tree decomposition spatial regions.  The data inside
		/// the regions may not occupy the entire space.  To draw just the
		/// bounds of the data in the regions, set this variable ON.
		/// </summary>
		// Token: 0x0600E937 RID: 59703 RVA: 0x001454A1 File Offset: 0x001436A1
		public virtual void GenerateRepresentationUsingDataBoundsOff()
		{
			vtkKdTree.vtkKdTree_GenerateRepresentationUsingDataBoundsOff_27(base.GetCppThis());
		}

		// Token: 0x0600E938 RID: 59704
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_GenerateRepresentationUsingDataBoundsOn_28(HandleRef pThis);

		/// <summary>
		/// The polydata representation of the k-d tree shows the boundaries
		/// of the k-d tree decomposition spatial regions.  The data inside
		/// the regions may not occupy the entire space.  To draw just the
		/// bounds of the data in the regions, set this variable ON.
		/// </summary>
		// Token: 0x0600E939 RID: 59705 RVA: 0x001454B0 File Offset: 0x001436B0
		public virtual void GenerateRepresentationUsingDataBoundsOn()
		{
			vtkKdTree.vtkKdTree_GenerateRepresentationUsingDataBoundsOn_28(base.GetCppThis());
		}

		// Token: 0x0600E93A RID: 59706
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdTree_GetBoundaryCellList_29(HandleRef pThis, int regionID, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The cell list obtained with GetCellList is the list
		/// of all cells such that their centroid is contained in
		/// the spatial region.  It may also be desirable to get
		/// a list of all cells intersecting a spatial region,
		/// but with centroid in some other region.  This is that
		/// list.  This list is computed in CreateCellLists() if
		/// and only if IncludeRegionBoundaryCells is ON.  This
		/// returns a pointer to KdTree's memory, so don't free it.
		/// </summary>
		// Token: 0x0600E93B RID: 59707 RVA: 0x001454C0 File Offset: 0x001436C0
		public vtkIdList GetBoundaryCellList(int regionID)
		{
			vtkIdList vtkIdList = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKdTree.vtkKdTree_GetBoundaryCellList_29(base.GetCppThis(), regionID, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600E93C RID: 59708
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_GetBounds_30(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the spatial bounds of the entire k-d tree space. Sets
		/// bounds array to xmin, xmax, ymin, ymax, zmin, zmax.
		/// </summary>
		// Token: 0x0600E93D RID: 59709 RVA: 0x00145530 File Offset: 0x00143730
		public void GetBounds(IntPtr bounds)
		{
			vtkKdTree.vtkKdTree_GetBounds_30(base.GetCppThis(), bounds);
		}

		// Token: 0x0600E93E RID: 59710
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdTree_GetCellList_31(HandleRef pThis, int regionID, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the cell list for a region.  This returns a pointer
		/// to vtkKdTree's memory, so don't free it.
		/// </summary>
		// Token: 0x0600E93F RID: 59711 RVA: 0x00145540 File Offset: 0x00143740
		public vtkIdList GetCellList(int regionID)
		{
			vtkIdList vtkIdList = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKdTree.vtkKdTree_GetCellList_31(base.GetCppThis(), regionID, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600E940 RID: 59712
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKdTree_GetCellLists_32(HandleRef pThis, HandleRef regions, int set, HandleRef inRegionCells, HandleRef onBoundaryCells);

		/// <summary>
		///
		/// For a list of regions, get two cell lists.  The first lists
		/// the IDs all cells whose centroids lie in one of the regions.
		/// The second lists the IDs of all cells that intersect the regions,
		/// but whose centroid lies in a region not on the list.
		///
		/// The total number of cell IDs written to both lists is returned.
		/// Either list pointer passed in can be nullptr, and it will be ignored.
		/// If there are multiple data sets, you must specify which data set
		/// you wish cell IDs for.
		///
		/// The caller should delete these two lists when done.  This method
		/// uses the cell lists created in CreateCellLists().
		/// If the cell list for any of the requested regions does not
		/// exist, then this method will call CreateCellLists() to create
		/// cell lists for *every* region of the k-d tree.  You must remember
		/// to DeleteCellLists() when done with all calls to this method, as
		/// cell lists can require a great deal of memory.
		/// </summary>
		// Token: 0x0600E941 RID: 59713 RVA: 0x001455B0 File Offset: 0x001437B0
		public long GetCellLists(vtkIntArray regions, int set, vtkIdList inRegionCells, vtkIdList onBoundaryCells)
		{
			return vtkKdTree.vtkKdTree_GetCellLists_32(base.GetCppThis(), (regions == null) ? default(HandleRef) : regions.GetCppThis(), set, (inRegionCells == null) ? default(HandleRef) : inRegionCells.GetCppThis(), (onBoundaryCells == null) ? default(HandleRef) : onBoundaryCells.GetCppThis());
		}

		// Token: 0x0600E942 RID: 59714
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKdTree_GetCellLists_33(HandleRef pThis, HandleRef regions, HandleRef set, HandleRef inRegionCells, HandleRef onBoundaryCells);

		/// <summary>
		///
		/// For a list of regions, get two cell lists.  The first lists
		/// the IDs all cells whose centroids lie in one of the regions.
		/// The second lists the IDs of all cells that intersect the regions,
		/// but whose centroid lies in a region not on the list.
		///
		/// The total number of cell IDs written to both lists is returned.
		/// Either list pointer passed in can be nullptr, and it will be ignored.
		/// If there are multiple data sets, you must specify which data set
		/// you wish cell IDs for.
		///
		/// The caller should delete these two lists when done.  This method
		/// uses the cell lists created in CreateCellLists().
		/// If the cell list for any of the requested regions does not
		/// exist, then this method will call CreateCellLists() to create
		/// cell lists for *every* region of the k-d tree.  You must remember
		/// to DeleteCellLists() when done with all calls to this method, as
		/// cell lists can require a great deal of memory.
		/// </summary>
		// Token: 0x0600E943 RID: 59715 RVA: 0x00145614 File Offset: 0x00143814
		public long GetCellLists(vtkIntArray regions, vtkDataSet set, vtkIdList inRegionCells, vtkIdList onBoundaryCells)
		{
			return vtkKdTree.vtkKdTree_GetCellLists_33(base.GetCppThis(), (regions == null) ? default(HandleRef) : regions.GetCppThis(), (set == null) ? default(HandleRef) : set.GetCppThis(), (inRegionCells == null) ? default(HandleRef) : inRegionCells.GetCppThis(), (onBoundaryCells == null) ? default(HandleRef) : onBoundaryCells.GetCppThis());
		}

		// Token: 0x0600E944 RID: 59716
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKdTree_GetCellLists_34(HandleRef pThis, HandleRef regions, HandleRef inRegionCells, HandleRef onBoundaryCells);

		/// <summary>
		///
		/// For a list of regions, get two cell lists.  The first lists
		/// the IDs all cells whose centroids lie in one of the regions.
		/// The second lists the IDs of all cells that intersect the regions,
		/// but whose centroid lies in a region not on the list.
		///
		/// The total number of cell IDs written to both lists is returned.
		/// Either list pointer passed in can be nullptr, and it will be ignored.
		/// If there are multiple data sets, you must specify which data set
		/// you wish cell IDs for.
		///
		/// The caller should delete these two lists when done.  This method
		/// uses the cell lists created in CreateCellLists().
		/// If the cell list for any of the requested regions does not
		/// exist, then this method will call CreateCellLists() to create
		/// cell lists for *every* region of the k-d tree.  You must remember
		/// to DeleteCellLists() when done with all calls to this method, as
		/// cell lists can require a great deal of memory.
		/// </summary>
		// Token: 0x0600E945 RID: 59717 RVA: 0x0014568C File Offset: 0x0014388C
		public long GetCellLists(vtkIntArray regions, vtkIdList inRegionCells, vtkIdList onBoundaryCells)
		{
			return vtkKdTree.vtkKdTree_GetCellLists_34(base.GetCppThis(), (regions == null) ? default(HandleRef) : regions.GetCppThis(), (inRegionCells == null) ? default(HandleRef) : inRegionCells.GetCppThis(), (onBoundaryCells == null) ? default(HandleRef) : onBoundaryCells.GetCppThis());
		}

		// Token: 0x0600E946 RID: 59718
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdTree_GetCuts_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a vtkBSPCuts object, a general object representing an axis-
		/// aligned spatial partitioning.  Used by vtkBSPIntersections.
		/// </summary>
		// Token: 0x0600E947 RID: 59719 RVA: 0x001456EC File Offset: 0x001438EC
		public virtual vtkBSPCuts GetCuts()
		{
			vtkBSPCuts vtkBSPCuts = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKdTree.vtkKdTree_GetCuts_35(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBSPCuts = (vtkBSPCuts)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBSPCuts.Register(null);
				}
			}
			return vtkBSPCuts;
		}

		// Token: 0x0600E948 RID: 59720
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdTree_GetDataSet_36(HandleRef pThis, int n, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the n'th data set.
		/// </summary>
		// Token: 0x0600E949 RID: 59721 RVA: 0x0014575C File Offset: 0x0014395C
		public vtkDataSet GetDataSet(int n)
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKdTree.vtkKdTree_GetDataSet_36(base.GetCppThis(), n, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x0600E94A RID: 59722
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdTree_GetDataSet_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the 0'th data set.  For compatibility with the superclass'
		/// interface.
		/// </summary>
		// Token: 0x0600E94B RID: 59723 RVA: 0x001457CC File Offset: 0x001439CC
		public override vtkDataSet GetDataSet()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKdTree.vtkKdTree_GetDataSet_37(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x0600E94C RID: 59724
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdTree_GetDataSetIndex_38(HandleRef pThis, HandleRef set);

		/// <summary>
		/// Return the index of the given data set.  Returns -1 if that data
		/// set does not exist.
		/// </summary>
		// Token: 0x0600E94D RID: 59725 RVA: 0x0014583C File Offset: 0x00143A3C
		public int GetDataSetIndex(vtkDataSet set)
		{
			return vtkKdTree.vtkKdTree_GetDataSetIndex_38(base.GetCppThis(), (set == null) ? default(HandleRef) : set.GetCppThis());
		}

		// Token: 0x0600E94E RID: 59726
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdTree_GetDataSets_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return a collection of all the data sets.
		/// </summary>
		// Token: 0x0600E94F RID: 59727 RVA: 0x00145870 File Offset: 0x00143A70
		public virtual vtkDataSetCollection GetDataSets()
		{
			vtkDataSetCollection vtkDataSetCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKdTree.vtkKdTree_GetDataSets_39(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetCollection = (vtkDataSetCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetCollection.Register(null);
				}
			}
			return vtkDataSetCollection;
		}

		// Token: 0x0600E950 RID: 59728
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkKdTree_GetFudgeFactor_40(HandleRef pThis);

		/// <summary>
		/// Some algorithms on k-d trees require a value that is a very
		/// small distance relative to the diameter of the entire space
		/// divided by the k-d tree.  This factor is the maximum axis-aligned
		/// width of the space multiplied by 10e-6.
		/// </summary>
		// Token: 0x0600E951 RID: 59729 RVA: 0x001458E0 File Offset: 0x00143AE0
		public virtual double GetFudgeFactor()
		{
			return vtkKdTree.vtkKdTree_GetFudgeFactor_40(base.GetCppThis());
		}

		// Token: 0x0600E952 RID: 59730
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdTree_GetGenerateRepresentationUsingDataBounds_41(HandleRef pThis);

		/// <summary>
		/// The polydata representation of the k-d tree shows the boundaries
		/// of the k-d tree decomposition spatial regions.  The data inside
		/// the regions may not occupy the entire space.  To draw just the
		/// bounds of the data in the regions, set this variable ON.
		/// </summary>
		// Token: 0x0600E953 RID: 59731 RVA: 0x00145900 File Offset: 0x00143B00
		public virtual int GetGenerateRepresentationUsingDataBounds()
		{
			return vtkKdTree.vtkKdTree_GetGenerateRepresentationUsingDataBounds_41(base.GetCppThis());
		}

		// Token: 0x0600E954 RID: 59732
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdTree_GetIncludeRegionBoundaryCells_42(HandleRef pThis);

		/// <summary>
		/// If IncludeRegionBoundaryCells is ON,
		/// CreateCellLists() will also create a list of cells which
		/// intersect a given region, but are not assigned
		/// to the region.  These lists are obtained with
		/// GetBoundaryCellList().  Default is OFF.
		/// </summary>
		// Token: 0x0600E955 RID: 59733 RVA: 0x00145920 File Offset: 0x00143B20
		public virtual int GetIncludeRegionBoundaryCells()
		{
			return vtkKdTree.vtkKdTree_GetIncludeRegionBoundaryCells_42(base.GetCppThis());
		}

		// Token: 0x0600E956 RID: 59734
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdTree_GetMinCells_43(HandleRef pThis);

		/// <summary>
		/// Minimum number of cells per spatial region.  Default is 100.
		/// </summary>
		// Token: 0x0600E957 RID: 59735 RVA: 0x00145940 File Offset: 0x00143B40
		public virtual int GetMinCells()
		{
			return vtkKdTree.vtkKdTree_GetMinCells_43(base.GetCppThis());
		}

		// Token: 0x0600E958 RID: 59736
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdTree_GetNumberOfDataSets_44(HandleRef pThis);

		/// <summary>
		/// Get the number of data sets included in spatial partitioning
		/// </summary>
		// Token: 0x0600E959 RID: 59737 RVA: 0x00145960 File Offset: 0x00143B60
		public int GetNumberOfDataSets()
		{
			return vtkKdTree.vtkKdTree_GetNumberOfDataSets_44(base.GetCppThis());
		}

		// Token: 0x0600E95A RID: 59738
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKdTree_GetNumberOfGenerationsFromBase_45(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E95B RID: 59739 RVA: 0x00145980 File Offset: 0x00143B80
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkKdTree.vtkKdTree_GetNumberOfGenerationsFromBase_45(base.GetCppThis(), type);
		}

		// Token: 0x0600E95C RID: 59740
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKdTree_GetNumberOfGenerationsFromBaseType_46([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E95D RID: 59741 RVA: 0x001459A0 File Offset: 0x00143BA0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkKdTree.vtkKdTree_GetNumberOfGenerationsFromBaseType_46(type);
		}

		// Token: 0x0600E95E RID: 59742
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdTree_GetNumberOfRegions_47(HandleRef pThis);

		/// <summary>
		/// The number of leaf nodes of the tree, the spatial regions
		/// </summary>
		// Token: 0x0600E95F RID: 59743 RVA: 0x001459BC File Offset: 0x00143BBC
		public virtual int GetNumberOfRegions()
		{
			return vtkKdTree.vtkKdTree_GetNumberOfRegions_47(base.GetCppThis());
		}

		// Token: 0x0600E960 RID: 59744
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdTree_GetNumberOfRegionsOrLess_48(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of spatial regions you want to get close
		/// to without going over.  (The number of spatial regions is normally
		/// a power of two.)  Call this before BuildLocator().  Default
		/// is unset (0).
		/// </summary>
		// Token: 0x0600E961 RID: 59745 RVA: 0x001459DC File Offset: 0x00143BDC
		public virtual int GetNumberOfRegionsOrLess()
		{
			return vtkKdTree.vtkKdTree_GetNumberOfRegionsOrLess_48(base.GetCppThis());
		}

		// Token: 0x0600E962 RID: 59746
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdTree_GetNumberOfRegionsOrMore_49(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of spatial regions you want to get close
		/// to while having at least this many regions.  (The number of
		/// spatial regions is normally a power of two.)   Default
		/// is unset (0).
		/// </summary>
		// Token: 0x0600E963 RID: 59747 RVA: 0x001459FC File Offset: 0x00143BFC
		public virtual int GetNumberOfRegionsOrMore()
		{
			return vtkKdTree.vtkKdTree_GetNumberOfRegionsOrMore_49(base.GetCppThis());
		}

		// Token: 0x0600E964 RID: 59748
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdTree_GetPointsInRegion_50(HandleRef pThis, int regionId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a list of the original IDs of all points in a region.  You
		/// must have called BuildLocatorFromPoints before calling this.
		/// </summary>
		// Token: 0x0600E965 RID: 59749 RVA: 0x00145A1C File Offset: 0x00143C1C
		public vtkIdTypeArray GetPointsInRegion(int regionId)
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKdTree.vtkKdTree_GetPointsInRegion_50(base.GetCppThis(), regionId, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		// Token: 0x0600E966 RID: 59750
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_GetRegionBounds_51(HandleRef pThis, int regionID, IntPtr bounds);

		/// <summary>
		/// Get the spatial bounds of k-d tree region
		/// </summary>
		// Token: 0x0600E967 RID: 59751 RVA: 0x00145A8C File Offset: 0x00143C8C
		public void GetRegionBounds(int regionID, IntPtr bounds)
		{
			vtkKdTree.vtkKdTree_GetRegionBounds_51(base.GetCppThis(), regionID, bounds);
		}

		// Token: 0x0600E968 RID: 59752
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdTree_GetRegionContainingCell_52(HandleRef pThis, HandleRef set, long cellID);

		/// <summary>
		/// Get the id of the region containing the cell centroid.  If
		/// no DataSet is specified, assume DataSet 0.  If you need the
		/// region ID for every cell, use AllGetRegionContainingCell
		/// instead.  It is more efficient.
		/// </summary>
		// Token: 0x0600E969 RID: 59753 RVA: 0x00145AA0 File Offset: 0x00143CA0
		public int GetRegionContainingCell(vtkDataSet set, long cellID)
		{
			return vtkKdTree.vtkKdTree_GetRegionContainingCell_52(base.GetCppThis(), (set == null) ? default(HandleRef) : set.GetCppThis(), cellID);
		}

		// Token: 0x0600E96A RID: 59754
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdTree_GetRegionContainingCell_53(HandleRef pThis, int set, long cellID);

		/// <summary>
		/// Get the id of the region containing the cell centroid.  If
		/// no DataSet is specified, assume DataSet 0.  If you need the
		/// region ID for every cell, use AllGetRegionContainingCell
		/// instead.  It is more efficient.
		/// </summary>
		// Token: 0x0600E96B RID: 59755 RVA: 0x00145AD8 File Offset: 0x00143CD8
		public int GetRegionContainingCell(int set, long cellID)
		{
			return vtkKdTree.vtkKdTree_GetRegionContainingCell_53(base.GetCppThis(), set, cellID);
		}

		// Token: 0x0600E96C RID: 59756
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdTree_GetRegionContainingCell_54(HandleRef pThis, long cellID);

		/// <summary>
		/// Get the id of the region containing the cell centroid.  If
		/// no DataSet is specified, assume DataSet 0.  If you need the
		/// region ID for every cell, use AllGetRegionContainingCell
		/// instead.  It is more efficient.
		/// </summary>
		// Token: 0x0600E96D RID: 59757 RVA: 0x00145AFC File Offset: 0x00143CFC
		public int GetRegionContainingCell(long cellID)
		{
			return vtkKdTree.vtkKdTree_GetRegionContainingCell_54(base.GetCppThis(), cellID);
		}

		// Token: 0x0600E96E RID: 59758
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdTree_GetRegionContainingPoint_55(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Get the id of the region containing the specified location.
		/// </summary>
		// Token: 0x0600E96F RID: 59759 RVA: 0x00145B1C File Offset: 0x00143D1C
		public int GetRegionContainingPoint(double x, double y, double z)
		{
			return vtkKdTree.vtkKdTree_GetRegionContainingPoint_55(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0600E970 RID: 59760
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_GetRegionDataBounds_56(HandleRef pThis, int regionID, IntPtr bounds);

		/// <summary>
		/// Get the bounds of the data within the k-d tree region
		/// </summary>
		// Token: 0x0600E971 RID: 59761 RVA: 0x00145B3E File Offset: 0x00143D3E
		public void GetRegionDataBounds(int regionID, IntPtr bounds)
		{
			vtkKdTree.vtkKdTree_GetRegionDataBounds_56(base.GetCppThis(), regionID, bounds);
		}

		// Token: 0x0600E972 RID: 59762
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdTree_GetTiming_57(HandleRef pThis);

		/// <summary>
		/// Turn on timing of the k-d tree build
		/// </summary>
		// Token: 0x0600E973 RID: 59763 RVA: 0x00145B50 File Offset: 0x00143D50
		public virtual int GetTiming()
		{
			return vtkKdTree.vtkKdTree_GetTiming_57(base.GetCppThis());
		}

		// Token: 0x0600E974 RID: 59764
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_IncludeRegionBoundaryCellsOff_58(HandleRef pThis);

		/// <summary>
		/// If IncludeRegionBoundaryCells is ON,
		/// CreateCellLists() will also create a list of cells which
		/// intersect a given region, but are not assigned
		/// to the region.  These lists are obtained with
		/// GetBoundaryCellList().  Default is OFF.
		/// </summary>
		// Token: 0x0600E975 RID: 59765 RVA: 0x00145B6F File Offset: 0x00143D6F
		public virtual void IncludeRegionBoundaryCellsOff()
		{
			vtkKdTree.vtkKdTree_IncludeRegionBoundaryCellsOff_58(base.GetCppThis());
		}

		// Token: 0x0600E976 RID: 59766
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_IncludeRegionBoundaryCellsOn_59(HandleRef pThis);

		/// <summary>
		/// If IncludeRegionBoundaryCells is ON,
		/// CreateCellLists() will also create a list of cells which
		/// intersect a given region, but are not assigned
		/// to the region.  These lists are obtained with
		/// GetBoundaryCellList().  Default is OFF.
		/// </summary>
		// Token: 0x0600E977 RID: 59767 RVA: 0x00145B7E File Offset: 0x00143D7E
		public virtual void IncludeRegionBoundaryCellsOn()
		{
			vtkKdTree.vtkKdTree_IncludeRegionBoundaryCellsOn_59(base.GetCppThis());
		}

		// Token: 0x0600E978 RID: 59768
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_InvalidateGeometry_60(HandleRef pThis);

		/// <summary>
		/// Forget about the last geometry used.  The next call to NewGeometry will
		/// return 1.  A new k-d tree will be built the next time BuildLocator is
		/// called.
		/// </summary>
		// Token: 0x0600E979 RID: 59769 RVA: 0x00145B8D File Offset: 0x00143D8D
		public virtual void InvalidateGeometry()
		{
			vtkKdTree.vtkKdTree_InvalidateGeometry_60(base.GetCppThis());
		}

		// Token: 0x0600E97A RID: 59770
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdTree_IsA_61(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E97B RID: 59771 RVA: 0x00145B9C File Offset: 0x00143D9C
		public override int IsA(string type)
		{
			return vtkKdTree.vtkKdTree_IsA_61(base.GetCppThis(), type);
		}

		// Token: 0x0600E97C RID: 59772
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdTree_IsTypeOf_62([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E97D RID: 59773 RVA: 0x00145BBC File Offset: 0x00143DBC
		public new static int IsTypeOf(string type)
		{
			return vtkKdTree.vtkKdTree_IsTypeOf_62(type);
		}

		// Token: 0x0600E97E RID: 59774
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdTree_NewGeometry_64(HandleRef pThis);

		/// <summary>
		/// Return 1 if the geometry of the input data sets
		/// has changed since the last time the k-d tree was built.
		/// </summary>
		// Token: 0x0600E97F RID: 59775 RVA: 0x00145BD8 File Offset: 0x00143DD8
		public virtual int NewGeometry()
		{
			return vtkKdTree.vtkKdTree_NewGeometry_64(base.GetCppThis());
		}

		// Token: 0x0600E980 RID: 59776
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdTree_NewInstance_65(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E981 RID: 59777 RVA: 0x00145BF8 File Offset: 0x00143DF8
		public new vtkKdTree NewInstance()
		{
			vtkKdTree result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKdTree.vtkKdTree_NewInstance_65(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKdTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E982 RID: 59778
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_OmitNoPartitioning_66(HandleRef pThis);

		/// <summary>
		/// Partition along all three axes - this is the default
		/// </summary>
		// Token: 0x0600E983 RID: 59779 RVA: 0x00145C52 File Offset: 0x00143E52
		public void OmitNoPartitioning()
		{
			vtkKdTree.vtkKdTree_OmitNoPartitioning_66(base.GetCppThis());
		}

		// Token: 0x0600E984 RID: 59780
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_OmitXPartitioning_67(HandleRef pThis);

		/// <summary>
		/// Omit partitions along the X axis, yielding shafts in the X direction
		/// </summary>
		// Token: 0x0600E985 RID: 59781 RVA: 0x00145C61 File Offset: 0x00143E61
		public void OmitXPartitioning()
		{
			vtkKdTree.vtkKdTree_OmitXPartitioning_67(base.GetCppThis());
		}

		// Token: 0x0600E986 RID: 59782
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_OmitXYPartitioning_68(HandleRef pThis);

		/// <summary>
		/// Omit partitions along the X and Y axes, yielding slabs along Z
		/// </summary>
		// Token: 0x0600E987 RID: 59783 RVA: 0x00145C70 File Offset: 0x00143E70
		public void OmitXYPartitioning()
		{
			vtkKdTree.vtkKdTree_OmitXYPartitioning_68(base.GetCppThis());
		}

		// Token: 0x0600E988 RID: 59784
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_OmitYPartitioning_69(HandleRef pThis);

		/// <summary>
		/// Omit partitions along the Y axis, yielding shafts in the Y direction
		/// </summary>
		// Token: 0x0600E989 RID: 59785 RVA: 0x00145C7F File Offset: 0x00143E7F
		public void OmitYPartitioning()
		{
			vtkKdTree.vtkKdTree_OmitYPartitioning_69(base.GetCppThis());
		}

		// Token: 0x0600E98A RID: 59786
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_OmitYZPartitioning_70(HandleRef pThis);

		/// <summary>
		/// Omit partitions along the Y and Z axes, yielding slabs along X
		/// </summary>
		// Token: 0x0600E98B RID: 59787 RVA: 0x00145C8E File Offset: 0x00143E8E
		public void OmitYZPartitioning()
		{
			vtkKdTree.vtkKdTree_OmitYZPartitioning_70(base.GetCppThis());
		}

		// Token: 0x0600E98C RID: 59788
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_OmitZPartitioning_71(HandleRef pThis);

		/// <summary>
		/// Omit partitions along the Z axis, yielding shafts in the Z direction
		/// </summary>
		// Token: 0x0600E98D RID: 59789 RVA: 0x00145C9D File Offset: 0x00143E9D
		public void OmitZPartitioning()
		{
			vtkKdTree.vtkKdTree_OmitZPartitioning_71(base.GetCppThis());
		}

		// Token: 0x0600E98E RID: 59790
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_OmitZXPartitioning_72(HandleRef pThis);

		/// <summary>
		/// Omit partitions along the Z and X axes, yielding slabs along Y
		/// </summary>
		// Token: 0x0600E98F RID: 59791 RVA: 0x00145CAC File Offset: 0x00143EAC
		public void OmitZXPartitioning()
		{
			vtkKdTree.vtkKdTree_OmitZXPartitioning_72(base.GetCppThis());
		}

		// Token: 0x0600E990 RID: 59792
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_PrintRegion_73(HandleRef pThis, int id);

		/// <summary>
		/// Print out leaf node data for given id
		/// </summary>
		// Token: 0x0600E991 RID: 59793 RVA: 0x00145CBB File Offset: 0x00143EBB
		public void PrintRegion(int id)
		{
			vtkKdTree.vtkKdTree_PrintRegion_73(base.GetCppThis(), id);
		}

		// Token: 0x0600E992 RID: 59794
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_PrintTree_74(HandleRef pThis);

		/// <summary>
		/// Print out nodes of kd tree
		/// </summary>
		// Token: 0x0600E993 RID: 59795 RVA: 0x00145CCB File Offset: 0x00143ECB
		public void PrintTree()
		{
			vtkKdTree.vtkKdTree_PrintTree_74(base.GetCppThis());
		}

		// Token: 0x0600E994 RID: 59796
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_PrintVerboseTree_75(HandleRef pThis);

		/// <summary>
		/// Print out nodes of kd tree
		/// </summary>
		// Token: 0x0600E995 RID: 59797 RVA: 0x00145CDA File Offset: 0x00143EDA
		public void PrintVerboseTree()
		{
			vtkKdTree.vtkKdTree_PrintVerboseTree_75(base.GetCppThis());
		}

		// Token: 0x0600E996 RID: 59798
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_RemoveAllDataSets_76(HandleRef pThis);

		/// <summary>
		/// Remove the given data set.
		/// </summary>
		// Token: 0x0600E997 RID: 59799 RVA: 0x00145CE9 File Offset: 0x00143EE9
		public virtual void RemoveAllDataSets()
		{
			vtkKdTree.vtkKdTree_RemoveAllDataSets_76(base.GetCppThis());
		}

		// Token: 0x0600E998 RID: 59800
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_RemoveDataSet_77(HandleRef pThis, int index);

		/// <summary>
		/// Remove the given data set.
		/// </summary>
		// Token: 0x0600E999 RID: 59801 RVA: 0x00145CF8 File Offset: 0x00143EF8
		public virtual void RemoveDataSet(int index)
		{
			vtkKdTree.vtkKdTree_RemoveDataSet_77(base.GetCppThis(), index);
		}

		// Token: 0x0600E99A RID: 59802
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_RemoveDataSet_78(HandleRef pThis, HandleRef set);

		/// <summary>
		/// Remove the given data set.
		/// </summary>
		// Token: 0x0600E99B RID: 59803 RVA: 0x00145D08 File Offset: 0x00143F08
		public virtual void RemoveDataSet(vtkDataSet set)
		{
			vtkKdTree.vtkKdTree_RemoveDataSet_78(base.GetCppThis(), (set == null) ? default(HandleRef) : set.GetCppThis());
		}

		// Token: 0x0600E99C RID: 59804
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKdTree_SafeDownCast_79(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E99D RID: 59805 RVA: 0x00145D38 File Offset: 0x00143F38
		public new static vtkKdTree SafeDownCast(vtkObjectBase o)
		{
			vtkKdTree vtkKdTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKdTree.vtkKdTree_SafeDownCast_79((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKdTree = (vtkKdTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKdTree.Register(null);
				}
			}
			return vtkKdTree;
		}

		// Token: 0x0600E99E RID: 59806
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_SetCuts_80(HandleRef pThis, HandleRef cuts);

		/// <summary>
		/// Normally the k-d tree is computed from the dataset(s) provided
		/// in SetDataSet.  Alternatively, you can provide the cuts that will
		/// be applied by calling SetCuts.
		/// </summary>
		// Token: 0x0600E99F RID: 59807 RVA: 0x00145DB8 File Offset: 0x00143FB8
		public void SetCuts(vtkBSPCuts cuts)
		{
			vtkKdTree.vtkKdTree_SetCuts_80(base.GetCppThis(), (cuts == null) ? default(HandleRef) : cuts.GetCppThis());
		}

		// Token: 0x0600E9A0 RID: 59808
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_SetDataSet_81(HandleRef pThis, HandleRef set);

		/// <summary>
		/// Clear out all data sets and replace with single data set.  For backward
		/// compatibility with superclass.
		/// </summary>
		// Token: 0x0600E9A1 RID: 59809 RVA: 0x00145DE8 File Offset: 0x00143FE8
		public override void SetDataSet(vtkDataSet set)
		{
			vtkKdTree.vtkKdTree_SetDataSet_81(base.GetCppThis(), (set == null) ? default(HandleRef) : set.GetCppThis());
		}

		// Token: 0x0600E9A2 RID: 59810
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_SetFudgeFactor_82(HandleRef pThis, double _arg);

		/// <summary>
		/// Some algorithms on k-d trees require a value that is a very
		/// small distance relative to the diameter of the entire space
		/// divided by the k-d tree.  This factor is the maximum axis-aligned
		/// width of the space multiplied by 10e-6.
		/// </summary>
		// Token: 0x0600E9A3 RID: 59811 RVA: 0x00145E17 File Offset: 0x00144017
		public virtual void SetFudgeFactor(double _arg)
		{
			vtkKdTree.vtkKdTree_SetFudgeFactor_82(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E9A4 RID: 59812
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_SetGenerateRepresentationUsingDataBounds_83(HandleRef pThis, int _arg);

		/// <summary>
		/// The polydata representation of the k-d tree shows the boundaries
		/// of the k-d tree decomposition spatial regions.  The data inside
		/// the regions may not occupy the entire space.  To draw just the
		/// bounds of the data in the regions, set this variable ON.
		/// </summary>
		// Token: 0x0600E9A5 RID: 59813 RVA: 0x00145E27 File Offset: 0x00144027
		public virtual void SetGenerateRepresentationUsingDataBounds(int _arg)
		{
			vtkKdTree.vtkKdTree_SetGenerateRepresentationUsingDataBounds_83(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E9A6 RID: 59814
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_SetIncludeRegionBoundaryCells_84(HandleRef pThis, int _arg);

		/// <summary>
		/// If IncludeRegionBoundaryCells is ON,
		/// CreateCellLists() will also create a list of cells which
		/// intersect a given region, but are not assigned
		/// to the region.  These lists are obtained with
		/// GetBoundaryCellList().  Default is OFF.
		/// </summary>
		// Token: 0x0600E9A7 RID: 59815 RVA: 0x00145E37 File Offset: 0x00144037
		public virtual void SetIncludeRegionBoundaryCells(int _arg)
		{
			vtkKdTree.vtkKdTree_SetIncludeRegionBoundaryCells_84(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E9A8 RID: 59816
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_SetMinCells_85(HandleRef pThis, int _arg);

		/// <summary>
		/// Minimum number of cells per spatial region.  Default is 100.
		/// </summary>
		// Token: 0x0600E9A9 RID: 59817 RVA: 0x00145E47 File Offset: 0x00144047
		public virtual void SetMinCells(int _arg)
		{
			vtkKdTree.vtkKdTree_SetMinCells_85(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E9AA RID: 59818
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_SetNewBounds_86(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// There are certain applications where you want the bounds of
		/// the k-d tree space to be at least as large as a specified
		/// box.  If the k-d tree has been built, you can expand it's
		/// bounds with this method.  If the bounds supplied are smaller
		/// than those computed, they will be ignored.
		/// </summary>
		// Token: 0x0600E9AB RID: 59819 RVA: 0x00145E57 File Offset: 0x00144057
		public void SetNewBounds(IntPtr bounds)
		{
			vtkKdTree.vtkKdTree_SetNewBounds_86(base.GetCppThis(), bounds);
		}

		// Token: 0x0600E9AC RID: 59820
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_SetNumberOfRegionsOrLess_87(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the number of spatial regions you want to get close
		/// to without going over.  (The number of spatial regions is normally
		/// a power of two.)  Call this before BuildLocator().  Default
		/// is unset (0).
		/// </summary>
		// Token: 0x0600E9AD RID: 59821 RVA: 0x00145E67 File Offset: 0x00144067
		public virtual void SetNumberOfRegionsOrLess(int _arg)
		{
			vtkKdTree.vtkKdTree_SetNumberOfRegionsOrLess_87(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E9AE RID: 59822
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_SetNumberOfRegionsOrMore_88(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the number of spatial regions you want to get close
		/// to while having at least this many regions.  (The number of
		/// spatial regions is normally a power of two.)   Default
		/// is unset (0).
		/// </summary>
		// Token: 0x0600E9AF RID: 59823 RVA: 0x00145E77 File Offset: 0x00144077
		public virtual void SetNumberOfRegionsOrMore(int _arg)
		{
			vtkKdTree.vtkKdTree_SetNumberOfRegionsOrMore_88(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E9B0 RID: 59824
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_SetTiming_89(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on timing of the k-d tree build
		/// </summary>
		// Token: 0x0600E9B1 RID: 59825 RVA: 0x00145E87 File Offset: 0x00144087
		public virtual void SetTiming(int _arg)
		{
			vtkKdTree.vtkKdTree_SetTiming_89(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E9B2 RID: 59826
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_TimingOff_90(HandleRef pThis);

		/// <summary>
		/// Turn on timing of the k-d tree build
		/// </summary>
		// Token: 0x0600E9B3 RID: 59827 RVA: 0x00145E97 File Offset: 0x00144097
		public virtual void TimingOff()
		{
			vtkKdTree.vtkKdTree_TimingOff_90(base.GetCppThis());
		}

		// Token: 0x0600E9B4 RID: 59828
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKdTree_TimingOn_91(HandleRef pThis);

		/// <summary>
		/// Turn on timing of the k-d tree build
		/// </summary>
		// Token: 0x0600E9B5 RID: 59829 RVA: 0x00145EA6 File Offset: 0x001440A6
		public virtual void TimingOn()
		{
			vtkKdTree.vtkKdTree_TimingOn_91(base.GetCppThis());
		}

		// Token: 0x0600E9B6 RID: 59830
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdTree_ViewOrderAllRegionsFromPosition_92(HandleRef pThis, IntPtr directionOfProjection, HandleRef orderedList);

		/// <summary>
		/// Given a camera position (typically obtained with vtkCamera::GetPosition()),
		/// this method, creates a list of the k-d tree region IDs in order from front
		/// to back with respect to that direction.  The number of ordered regions is
		/// returned.  Use this method to view order regions for cameras that use
		/// perspective projection.
		/// </summary>
		// Token: 0x0600E9B7 RID: 59831 RVA: 0x00145EB8 File Offset: 0x001440B8
		public int ViewOrderAllRegionsFromPosition(IntPtr directionOfProjection, vtkIntArray orderedList)
		{
			return vtkKdTree.vtkKdTree_ViewOrderAllRegionsFromPosition_92(base.GetCppThis(), directionOfProjection, (orderedList == null) ? default(HandleRef) : orderedList.GetCppThis());
		}

		// Token: 0x0600E9B8 RID: 59832
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdTree_ViewOrderAllRegionsInDirection_93(HandleRef pThis, IntPtr directionOfProjection, HandleRef orderedList);

		/// <summary>
		/// Given a direction of projection (typically obtained with
		/// vtkCamera::GetDirectionOfProjection()), this method, creates a list of the
		/// k-d tree region IDs in order from front to back with respect to that
		/// direction.  The number of ordered regions is returned.  Use this method to
		/// view order regions for cameras that use parallel projection.
		/// </summary>
		// Token: 0x0600E9B9 RID: 59833 RVA: 0x00145EF0 File Offset: 0x001440F0
		public int ViewOrderAllRegionsInDirection(IntPtr directionOfProjection, vtkIntArray orderedList)
		{
			return vtkKdTree.vtkKdTree_ViewOrderAllRegionsInDirection_93(base.GetCppThis(), directionOfProjection, (orderedList == null) ? default(HandleRef) : orderedList.GetCppThis());
		}

		// Token: 0x0600E9BA RID: 59834
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdTree_ViewOrderRegionsFromPosition_94(HandleRef pThis, HandleRef regionIds, IntPtr directionOfProjection, HandleRef orderedList);

		/// <summary>
		/// Given a camera position and a list of k-d tree region IDs, this method,
		/// creates a list of the k-d tree region IDs in order from front to back with
		/// respect to that direction.  The number of ordered regions is returned.  Use
		/// this method to view order regions for cameras that use perspective
		/// projection.
		/// </summary>
		// Token: 0x0600E9BB RID: 59835 RVA: 0x00145F28 File Offset: 0x00144128
		public int ViewOrderRegionsFromPosition(vtkIntArray regionIds, IntPtr directionOfProjection, vtkIntArray orderedList)
		{
			return vtkKdTree.vtkKdTree_ViewOrderRegionsFromPosition_94(base.GetCppThis(), (regionIds == null) ? default(HandleRef) : regionIds.GetCppThis(), directionOfProjection, (orderedList == null) ? default(HandleRef) : orderedList.GetCppThis());
		}

		// Token: 0x0600E9BC RID: 59836
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKdTree_ViewOrderRegionsInDirection_95(HandleRef pThis, HandleRef regionIds, IntPtr directionOfProjection, HandleRef orderedList);

		/// <summary>
		/// Given a direction of projection and a list of k-d tree region IDs, this
		/// method, creates a list of the k-d tree region IDs in order from front to
		/// back with respect to that direction.  The number of ordered regions is
		/// returned.  Use this method to view order regions for cameras that use
		/// parallel projection.
		/// </summary>
		// Token: 0x0600E9BD RID: 59837 RVA: 0x00145F74 File Offset: 0x00144174
		public int ViewOrderRegionsInDirection(vtkIntArray regionIds, IntPtr directionOfProjection, vtkIntArray orderedList)
		{
			return vtkKdTree.vtkKdTree_ViewOrderRegionsInDirection_95(base.GetCppThis(), (regionIds == null) ? default(HandleRef) : regionIds.GetCppThis(), directionOfProjection, (orderedList == null) ? default(HandleRef) : orderedList.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400111A RID: 4378
		public new const string MRFullTypeName = "Kitware.VTK.vtkKdTree";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400111B RID: 4379
		public new static readonly string MRClassNameKey = "class vtkKdTree";
	}
}
