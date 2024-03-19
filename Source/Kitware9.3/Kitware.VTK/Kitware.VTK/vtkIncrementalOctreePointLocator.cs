using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkIncrementalOctreePointLocator
	/// </summary>
	/// <remarks>
	///    Incremental octree in support
	///  of both point location and point insertion.
	///
	///
	///  As opposed to the uniform bin-based search structure (adopted in class
	///  vtkPointLocator) with a fixed spatial resolution, an octree mechanism
	///  employs a hierarchy of tree-like sub-division of the 3D data domain. Thus
	///  it enables data-aware multi-resolution and accordingly accelerated point
	///  location as well as insertion, particularly when handling a radically
	///  imbalanced layout of points as not uncommon in datasets defined on
	///  adaptive meshes. Compared to a static point locator supporting pure
	///  location functionalities through some search structure established from
	///  a fixed set of points, an incremental point locator allows for, in addition,
	///  point insertion capabilities, with the search structure maintaining a
	///  dynamically increasing number of points.
	///  Class vtkIncrementalOctreePointLocator is an octree-based accelerated
	///  implementation of the functionalities of the uniform bin-based incremental
	///  point locator vtkPointLocator. For point location, an octree is built by
	///  accessing a vtkDataSet, specifically a vtkPointSet. For point insertion,
	///  an empty octree is inited and then incrementally populated as points are
	///  inserted. Three increasingly complex point insertion modes, i.e., direct
	///  check-free insertion, zero tolerance insertion, and non-zero tolerance
	///  insertion, are supported. In fact, the octree used in the point location
	///  mode is actually constructed via direct check-free point insertion. This
	///  class also provides a polygonal representation of the octree boundary.
	///
	/// </remarks>
	/// <seealso>
	///
	///  vtkAbstractPointLocator, vtkIncrementalPointLocator, vtkPointLocator,
	///  vtkMergePoints
	/// </seealso>
	// Token: 0x02000A70 RID: 2672
	public class vtkIncrementalOctreePointLocator : vtkIncrementalPointLocator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601BF99 RID: 114585 RVA: 0x00273277 File Offset: 0x00271477
		static vtkIncrementalOctreePointLocator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkIncrementalOctreePointLocator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkIncrementalOctreePointLocator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601BF9A RID: 114586 RVA: 0x0027329F File Offset: 0x0027149F
		public vtkIncrementalOctreePointLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601BF9B RID: 114587
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIncrementalOctreePointLocator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BF9C RID: 114588 RVA: 0x002732B0 File Offset: 0x002714B0
		public new static vtkIncrementalOctreePointLocator New()
		{
			vtkIncrementalOctreePointLocator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIncrementalOctreePointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BF9D RID: 114589 RVA: 0x00273304 File Offset: 0x00271504
		public vtkIncrementalOctreePointLocator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601BF9E RID: 114590 RVA: 0x00273348 File Offset: 0x00271548
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601BF9F RID: 114591
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalOctreePointLocator_BuildCubicOctreeOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the search octree is built as a cubic shape or not.
		/// </summary>
		// Token: 0x0601BFA0 RID: 114592 RVA: 0x00273353 File Offset: 0x00271553
		public virtual void BuildCubicOctreeOff()
		{
			vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_BuildCubicOctreeOff_01(base.GetCppThis());
		}

		// Token: 0x0601BFA1 RID: 114593
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalOctreePointLocator_BuildCubicOctreeOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the search octree is built as a cubic shape or not.
		/// </summary>
		// Token: 0x0601BFA2 RID: 114594 RVA: 0x00273362 File Offset: 0x00271562
		public virtual void BuildCubicOctreeOn()
		{
			vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_BuildCubicOctreeOn_02(base.GetCppThis());
		}

		// Token: 0x0601BFA3 RID: 114595
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalOctreePointLocator_BuildLocator_03(HandleRef pThis);

		/// <summary>
		/// Load points from a dataset to construct an octree for point location.
		/// This function resorts to InitPointInsertion() to fulfill some of the work.
		/// This will NOT do anything if UseExistingSearchStructure is on.
		/// </summary>
		// Token: 0x0601BFA4 RID: 114596 RVA: 0x00273371 File Offset: 0x00271571
		public override void BuildLocator()
		{
			vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_BuildLocator_03(base.GetCppThis());
		}

		// Token: 0x0601BFA5 RID: 114597
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIncrementalOctreePointLocator_FindClosestInsertedPoint_04(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Given a point x assumed to be covered by the octree, return the index of
		/// the closest in-octree point regardless of the associated minimum squared
		/// distance relative to the squared insertion-tolerance distance. This method
		/// is used when performing incremental point insertion. Note -1 indicates that
		/// no point is found. InitPointInsertion() should have been called in advance.
		/// </summary>
		// Token: 0x0601BFA6 RID: 114598 RVA: 0x00273380 File Offset: 0x00271580
		public override long FindClosestInsertedPoint(IntPtr x)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_FindClosestInsertedPoint_04(base.GetCppThis(), x);
		}

		// Token: 0x0601BFA7 RID: 114599
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalOctreePointLocator_FindClosestNPoints_05(HandleRef pThis, int N, IntPtr x, HandleRef result);

		/// <summary>
		/// Find the closest N points to a given point. The returned point ids (via
		/// result) are sorted from closest to farthest. BuildLocator() should have
		/// been called prior to this function. This method is thread safe if
		/// BuildLocator() is directly or indirectly called from a single thread first.
		/// </summary>
		// Token: 0x0601BFA8 RID: 114600 RVA: 0x002733A0 File Offset: 0x002715A0
		public override void FindClosestNPoints(int N, IntPtr x, vtkIdList result)
		{
			vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_FindClosestNPoints_05(base.GetCppThis(), N, x, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		// Token: 0x0601BFA9 RID: 114601
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIncrementalOctreePointLocator_FindClosestPoint_06(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Given a point x, return the id of the closest point. BuildLocator() should
		/// have been called prior to this function. This method is thread safe if
		/// BuildLocator() is directly or indirectly called from a single thread first.
		/// </summary>
		// Token: 0x0601BFAA RID: 114602 RVA: 0x002733D4 File Offset: 0x002715D4
		public override long FindClosestPoint(IntPtr x)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_FindClosestPoint_06(base.GetCppThis(), x);
		}

		// Token: 0x0601BFAB RID: 114603
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIncrementalOctreePointLocator_FindClosestPoint_07(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Given a point (x, y, z), return the id of the closest point. Note that
		/// BuildLocator() should have been called prior to this function. This method
		/// is thread safe if BuildLocator() is directly or indirectly called from a
		/// single thread first.
		/// </summary>
		// Token: 0x0601BFAC RID: 114604 RVA: 0x002733F4 File Offset: 0x002715F4
		public new virtual long FindClosestPoint(double x, double y, double z)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_FindClosestPoint_07(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0601BFAD RID: 114605
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIncrementalOctreePointLocator_FindClosestPoint_08(HandleRef pThis, IntPtr x, IntPtr miniDist2);

		/// <summary>
		/// Given a point x, return the id of the closest point and the associated
		/// minimum squared distance (via miniDist2). Note BuildLocator() should have
		/// been called prior to this function. This method is thread safe if
		/// BuildLocator() is directly or indirectly called from a single thread first.
		/// </summary>
		// Token: 0x0601BFAE RID: 114606 RVA: 0x00273418 File Offset: 0x00271618
		public virtual long FindClosestPoint(IntPtr x, IntPtr miniDist2)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_FindClosestPoint_08(base.GetCppThis(), x, miniDist2);
		}

		// Token: 0x0601BFAF RID: 114607
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIncrementalOctreePointLocator_FindClosestPoint_09(HandleRef pThis, double x, double y, double z, IntPtr miniDist2);

		/// <summary>
		/// Given a point (x, y, z), return the id of the closest point and the
		/// associated minimum squared distance (via miniDist2). BuildLocator() should
		/// have been called prior to this function. This method is thread safe if
		/// BuildLocator() is directly or indirectly called from a single thread first.
		/// </summary>
		// Token: 0x0601BFB0 RID: 114608 RVA: 0x0027343C File Offset: 0x0027163C
		public virtual long FindClosestPoint(double x, double y, double z, IntPtr miniDist2)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_FindClosestPoint_09(base.GetCppThis(), x, y, z, miniDist2);
		}

		// Token: 0x0601BFB1 RID: 114609
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIncrementalOctreePointLocator_FindClosestPointWithinRadius_10(HandleRef pThis, double radius, IntPtr x, ref double dist2);

		/// <summary>
		/// Given a point x and a radius, return the id of the closest point within
		/// the radius and the associated minimum squared distance (via dist2, this
		/// returned distance is valid only if the point id is not -1). Note that
		/// BuildLocator() should have been called prior to this function. This method
		/// is thread safe if BuildLocator() is directly or indirectly called from a
		/// single thread first.
		/// </summary>
		// Token: 0x0601BFB2 RID: 114610 RVA: 0x00273460 File Offset: 0x00271660
		public override long FindClosestPointWithinRadius(double radius, IntPtr x, ref double dist2)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_FindClosestPointWithinRadius_10(base.GetCppThis(), radius, x, ref dist2);
		}

		// Token: 0x0601BFB3 RID: 114611
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIncrementalOctreePointLocator_FindClosestPointWithinSquaredRadius_11(HandleRef pThis, double radius2, IntPtr x, ref double dist2);

		/// <summary>
		/// Given a point x and a squared radius radius2, return the id of the closest
		/// point within the radius and the associated minimum squared distance (via
		/// dist2, note this returned distance is valid only if the point id is not
		/// -1). BuildLocator() should have been called prior to this function.This
		/// method is thread safe if BuildLocator() is directly or indirectly called
		/// from a single thread first.
		/// </summary>
		// Token: 0x0601BFB4 RID: 114612 RVA: 0x00273484 File Offset: 0x00271684
		public long FindClosestPointWithinSquaredRadius(double radius2, IntPtr x, ref double dist2)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_FindClosestPointWithinSquaredRadius_11(base.GetCppThis(), radius2, x, ref dist2);
		}

		// Token: 0x0601BFB5 RID: 114613
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalOctreePointLocator_FindPointsWithinRadius_12(HandleRef pThis, double R, IntPtr x, HandleRef result);

		/// <summary>
		/// Find all points within a radius R relative to a given point x. The returned
		/// point ids (stored in result) are not sorted in any way. BuildLocator() should
		/// have been called prior to this function. This method is thread safe if
		/// BuildLocator() is directly or indirectly called from a single thread first.
		/// </summary>
		// Token: 0x0601BFB6 RID: 114614 RVA: 0x002734A8 File Offset: 0x002716A8
		public override void FindPointsWithinRadius(double R, IntPtr x, vtkIdList result)
		{
			vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_FindPointsWithinRadius_12(base.GetCppThis(), R, x, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		// Token: 0x0601BFB7 RID: 114615
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalOctreePointLocator_FindPointsWithinSquaredRadius_13(HandleRef pThis, double R2, IntPtr x, HandleRef result);

		/// <summary>
		/// Find all points within a squared radius R2 relative to a given point x. The
		/// returned point ids (stored in result) are not sorted in any way. BuildLocator()
		/// should have been called prior to this function. This method is thread safe if
		/// BuildLocator() is directly or indirectly called from a single thread first.
		/// </summary>
		// Token: 0x0601BFB8 RID: 114616 RVA: 0x002734DC File Offset: 0x002716DC
		public void FindPointsWithinSquaredRadius(double R2, IntPtr x, vtkIdList result)
		{
			vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_FindPointsWithinSquaredRadius_13(base.GetCppThis(), R2, x, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		// Token: 0x0601BFB9 RID: 114617
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalOctreePointLocator_ForceBuildLocator_14(HandleRef pThis);

		/// <summary>
		/// Build the locator from the input dataset (even if UseExistingSearchStructure is on).
		/// </summary>
		// Token: 0x0601BFBA RID: 114618 RVA: 0x0027350D File Offset: 0x0027170D
		public override void ForceBuildLocator()
		{
			vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_ForceBuildLocator_14(base.GetCppThis());
		}

		// Token: 0x0601BFBB RID: 114619
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalOctreePointLocator_FreeSearchStructure_15(HandleRef pThis);

		/// <summary>
		/// Delete the octree search structure.
		/// </summary>
		// Token: 0x0601BFBC RID: 114620 RVA: 0x0027351C File Offset: 0x0027171C
		public override void FreeSearchStructure()
		{
			vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_FreeSearchStructure_15(base.GetCppThis());
		}

		// Token: 0x0601BFBD RID: 114621
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalOctreePointLocator_GenerateRepresentation_16(HandleRef pThis, int level, HandleRef polysData);

		/// <summary>
		/// Create a polygonal representation of the octree 'level': for each node
		/// on the specified level we generate six faces for the bounding box of the node.
		/// We also include a cell attribute that specifies the Index of the node.
		/// The second version of this function, generates user defined boundaries
		/// provided by 'GetBounds'. This function takes as parameters a user defined
		/// opaque 'data', the current node, and a pointer to where to write the 'bounds'.
		/// The function returns true if we want to generate the representation for this node,
		/// and false otherwise. A user can store data associated with a node using
		/// the node index.
		/// @see vtkIncrementalOctreeNode::GetIndex
		/// </summary>
		// Token: 0x0601BFBE RID: 114622 RVA: 0x0027352C File Offset: 0x0027172C
		public override void GenerateRepresentation(int level, vtkPolyData polysData)
		{
			vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_GenerateRepresentation_16(base.GetCppThis(), level, (polysData == null) ? default(HandleRef) : polysData.GetCppThis());
		}

		// Token: 0x0601BFBF RID: 114623
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalOctreePointLocator_GetBounds_17(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the spatial bounding box of the octree.
		/// </summary>
		// Token: 0x0601BFC0 RID: 114624 RVA: 0x0027355C File Offset: 0x0027175C
		public override void GetBounds(IntPtr bounds)
		{
			vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_GetBounds_17(base.GetCppThis(), bounds);
		}

		// Token: 0x0601BFC1 RID: 114625
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIncrementalOctreePointLocator_GetBounds_18(HandleRef pThis);

		/// <summary>
		/// Get the spatial bounding box of the octree.
		/// </summary>
		// Token: 0x0601BFC2 RID: 114626 RVA: 0x0027356C File Offset: 0x0027176C
		public override IntPtr GetBounds()
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_GetBounds_18(base.GetCppThis());
		}

		// Token: 0x0601BFC3 RID: 114627
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIncrementalOctreePointLocator_GetBuildCubicOctree_19(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the search octree is built as a cubic shape or not.
		/// </summary>
		// Token: 0x0601BFC4 RID: 114628 RVA: 0x0027358C File Offset: 0x0027178C
		public virtual int GetBuildCubicOctree()
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_GetBuildCubicOctree_19(base.GetCppThis());
		}

		// Token: 0x0601BFC5 RID: 114629
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIncrementalOctreePointLocator_GetLocatorPoints_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get access to the vtkPoints object in which point coordinates are stored
		/// for either point location or point insertion.
		/// </summary>
		// Token: 0x0601BFC6 RID: 114630 RVA: 0x002735AC File Offset: 0x002717AC
		public virtual vtkPoints GetLocatorPoints()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_GetLocatorPoints_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601BFC7 RID: 114631
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIncrementalOctreePointLocator_GetMaxPointsPerLeaf_21(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of points that a leaf node may maintain.
		/// Note that the actual number of points maintained by a leaf node might
		/// exceed this threshold if there is a large number (equal to or greater
		/// than the threshold) of exactly duplicate points (with zero distance)
		/// to be inserted (e.g., to construct an octree for subsequent point
		/// location) in extreme cases. Respecting this threshold in such scenarios
		/// would cause endless node sub-division. Thus this threshold is broken, but
		/// only in case of such situations.
		/// </summary>
		// Token: 0x0601BFC8 RID: 114632 RVA: 0x0027361C File Offset: 0x0027181C
		public virtual int GetMaxPointsPerLeaf()
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_GetMaxPointsPerLeaf_21(base.GetCppThis());
		}

		// Token: 0x0601BFC9 RID: 114633
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIncrementalOctreePointLocator_GetNumberOfGenerationsFromBase_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BFCA RID: 114634 RVA: 0x0027363C File Offset: 0x0027183C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_GetNumberOfGenerationsFromBase_22(base.GetCppThis(), type);
		}

		// Token: 0x0601BFCB RID: 114635
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIncrementalOctreePointLocator_GetNumberOfGenerationsFromBaseType_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BFCC RID: 114636 RVA: 0x0027365C File Offset: 0x0027185C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_GetNumberOfGenerationsFromBaseType_23(type);
		}

		// Token: 0x0601BFCD RID: 114637
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIncrementalOctreePointLocator_GetNumberOfLevels_24(HandleRef pThis);

		/// <summary>
		/// Returns the maximum level of the tree. If a tree has one node it returns 1
		/// else it returns the maximum level of its children plus 1.
		/// </summary>
		// Token: 0x0601BFCE RID: 114638 RVA: 0x00273678 File Offset: 0x00271878
		public int GetNumberOfLevels()
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_GetNumberOfLevels_24(base.GetCppThis());
		}

		// Token: 0x0601BFCF RID: 114639
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIncrementalOctreePointLocator_GetNumberOfNodes_25(HandleRef pThis);

		/// <summary>
		/// Get number of nodes in the tree.
		/// </summary>
		// Token: 0x0601BFD0 RID: 114640 RVA: 0x00273698 File Offset: 0x00271898
		public virtual int GetNumberOfNodes()
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_GetNumberOfNodes_25(base.GetCppThis());
		}

		// Token: 0x0601BFD1 RID: 114641
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIncrementalOctreePointLocator_GetNumberOfPoints_26(HandleRef pThis);

		/// <summary>
		/// Get the number of points maintained by the octree.
		/// </summary>
		// Token: 0x0601BFD2 RID: 114642 RVA: 0x002736B8 File Offset: 0x002718B8
		public int GetNumberOfPoints()
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_GetNumberOfPoints_26(base.GetCppThis());
		}

		// Token: 0x0601BFD3 RID: 114643
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIncrementalOctreePointLocator_GetRoot_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// "Insert" a point to the octree without any checking. Argument insert means
		/// whether vtkPoints::InsertNextPoint() upon 1 is called or the point itself
		/// is not inserted to the vtkPoints at all but instead only the point index is
		/// inserted to a vtkIdList upon 0. For case 0, the point index needs to be
		/// specified via pntId. For case 1, the actual point index is returned via
		/// pntId. InitPointInsertion() should have been called.
		/// </summary>
		// Token: 0x0601BFD4 RID: 114644 RVA: 0x002736D8 File Offset: 0x002718D8
		public vtkIncrementalOctreeNode GetRoot()
		{
			vtkIncrementalOctreeNode vtkIncrementalOctreeNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_GetRoot_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIncrementalOctreeNode = (vtkIncrementalOctreeNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIncrementalOctreeNode.Register(null);
				}
			}
			return vtkIncrementalOctreeNode;
		}

		// Token: 0x0601BFD5 RID: 114645
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIncrementalOctreePointLocator_InitPointInsertion_28(HandleRef pThis, HandleRef points, IntPtr bounds);

		/// <summary>
		/// Initialize the point insertion process. points is an object, storing 3D
		/// point coordinates, to which incremental point insertion put coordinates.
		/// It is created and provided by an external VTK class. Argument bounds
		/// represents the spatial bounding box, into which the points fall. In fact,
		/// an adjusted version of the bounding box is used to build the octree to
		/// make sure no any point (to be inserted) falls outside the octree. This
		/// function is not thread safe.
		/// </summary>
		// Token: 0x0601BFD6 RID: 114646 RVA: 0x00273748 File Offset: 0x00271948
		public override int InitPointInsertion(vtkPoints points, IntPtr bounds)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_InitPointInsertion_28(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis(), bounds);
		}

		// Token: 0x0601BFD7 RID: 114647
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIncrementalOctreePointLocator_InitPointInsertion_29(HandleRef pThis, HandleRef points, IntPtr bounds, long estSize);

		/// <summary>
		/// Initialize the point insertion process. points is an object, storing 3D
		/// point coordinates, to which incremental point insertion put coordinates.
		/// It is created and provided by an external VTK class. Argument bounds
		/// represents the spatial bounding box, into which the points fall. In fact,
		/// an adjusted version of the bounding box is used to build the octree to
		/// make sure no any point (to be inserted) falls outside the octree. Argument
		/// estSize specifies the initial estimated size of the vtkPoints object. This
		/// function is not thread safe.
		/// </summary>
		// Token: 0x0601BFD8 RID: 114648 RVA: 0x00273780 File Offset: 0x00271980
		public override int InitPointInsertion(vtkPoints points, IntPtr bounds, long estSize)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_InitPointInsertion_29(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis(), bounds, estSize);
		}

		// Token: 0x0601BFD9 RID: 114649
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalOctreePointLocator_Initialize_30(HandleRef pThis);

		/// <summary>
		/// Delete the octree search structure.
		/// </summary>
		// Token: 0x0601BFDA RID: 114650 RVA: 0x002737B6 File Offset: 0x002719B6
		public override void Initialize()
		{
			vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_Initialize_30(base.GetCppThis());
		}

		// Token: 0x0601BFDB RID: 114651
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIncrementalOctreePointLocator_InsertNextPoint_31(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Insert a given point into the octree and return the point index. Note that
		/// InitPointInsertion() should have been called prior to this function. In
		/// addition, IsInsertedPoint() should have been called in advance to ensure
		/// that the given point has not been inserted unless point duplication is
		/// allowed (in this case, this function involves a repeated leaf container
		/// location). vtkPoints::InsertNextPoint() is invoked.
		/// </summary>
		// Token: 0x0601BFDC RID: 114652 RVA: 0x002737C8 File Offset: 0x002719C8
		public override long InsertNextPoint(IntPtr x)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_InsertNextPoint_31(base.GetCppThis(), x);
		}

		// Token: 0x0601BFDD RID: 114653
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalOctreePointLocator_InsertPoint_32(HandleRef pThis, long ptId, IntPtr x);

		/// <summary>
		/// Insert a given point into the octree with a specified point index ptId.
		/// InitPointInsertion() should have been called prior to this function. In
		/// addition, IsInsertedPoint() should have been called in advance to ensure
		/// that the given point has not been inserted unless point duplication is
		/// allowed (Note that in this case, this function involves a repeated leaf
		/// container location). vtkPoints::InsertPoint() is invoked.
		/// </summary>
		// Token: 0x0601BFDE RID: 114654 RVA: 0x002737E8 File Offset: 0x002719E8
		public override void InsertPoint(long ptId, IntPtr x)
		{
			vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_InsertPoint_32(base.GetCppThis(), ptId, x);
		}

		// Token: 0x0601BFDF RID: 114655
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalOctreePointLocator_InsertPointWithoutChecking_33(HandleRef pThis, IntPtr point, ref long pntId, int insert);

		/// <summary>
		/// "Insert" a point to the octree without any checking. Argument insert means
		/// whether vtkPoints::InsertNextPoint() upon 1 is called or the point itself
		/// is not inserted to the vtkPoints at all but instead only the point index is
		/// inserted to a vtkIdList upon 0. For case 0, the point index needs to be
		/// specified via pntId. For case 1, the actual point index is returned via
		/// pntId. InitPointInsertion() should have been called.
		/// </summary>
		// Token: 0x0601BFE0 RID: 114656 RVA: 0x002737F9 File Offset: 0x002719F9
		public void InsertPointWithoutChecking(IntPtr point, ref long pntId, int insert)
		{
			vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_InsertPointWithoutChecking_33(base.GetCppThis(), point, ref pntId, insert);
		}

		// Token: 0x0601BFE1 RID: 114657
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIncrementalOctreePointLocator_InsertUniquePoint_34(HandleRef pThis, IntPtr point, ref long pntId);

		/// <summary>
		/// Insert a point to the octree unless there has been a duplicate point.
		/// Whether the point is actually inserted (return 1) or not (return 0 upon a
		/// rejection by an existing duplicate), the index of the point (either new
		/// or the duplicate) is returned via pntId. Note that InitPointInsertion()
		/// should have been called prior to this function. vtkPoints::InsertNextPoint()
		/// is invoked. This method is not thread safe.
		/// </summary>
		// Token: 0x0601BFE2 RID: 114658 RVA: 0x0027380C File Offset: 0x00271A0C
		public override int InsertUniquePoint(IntPtr point, ref long pntId)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_InsertUniquePoint_34(base.GetCppThis(), point, ref pntId);
		}

		// Token: 0x0601BFE3 RID: 114659
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIncrementalOctreePointLocator_IsA_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BFE4 RID: 114660 RVA: 0x00273830 File Offset: 0x00271A30
		public override int IsA(string type)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_IsA_35(base.GetCppThis(), type);
		}

		// Token: 0x0601BFE5 RID: 114661
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIncrementalOctreePointLocator_IsInsertedPoint_36(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Determine whether or not a given point has been inserted into the octree.
		/// Return the id of the already inserted point if true, otherwise return -1.
		/// InitPointInsertion() should have been called in advance.
		/// </summary>
		// Token: 0x0601BFE6 RID: 114662 RVA: 0x00273850 File Offset: 0x00271A50
		public override long IsInsertedPoint(IntPtr x)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_IsInsertedPoint_36(base.GetCppThis(), x);
		}

		// Token: 0x0601BFE7 RID: 114663
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIncrementalOctreePointLocator_IsInsertedPoint_37(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Determine whether or not a given point has been inserted into the octree.
		/// Return the id of the already inserted point if true, otherwise return -1.
		/// InitPointInsertion() should have been called in advance.
		/// </summary>
		// Token: 0x0601BFE8 RID: 114664 RVA: 0x00273870 File Offset: 0x00271A70
		public override long IsInsertedPoint(double x, double y, double z)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_IsInsertedPoint_37(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0601BFE9 RID: 114665
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIncrementalOctreePointLocator_IsTypeOf_38([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BFEA RID: 114666 RVA: 0x00273894 File Offset: 0x00271A94
		public new static int IsTypeOf(string type)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_IsTypeOf_38(type);
		}

		// Token: 0x0601BFEB RID: 114667
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIncrementalOctreePointLocator_NewInstance_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BFEC RID: 114668 RVA: 0x002738B0 File Offset: 0x00271AB0
		public new vtkIncrementalOctreePointLocator NewInstance()
		{
			vtkIncrementalOctreePointLocator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_NewInstance_40(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIncrementalOctreePointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601BFED RID: 114669
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIncrementalOctreePointLocator_SafeDownCast_41(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BFEE RID: 114670 RVA: 0x0027390C File Offset: 0x00271B0C
		public new static vtkIncrementalOctreePointLocator SafeDownCast(vtkObjectBase o)
		{
			vtkIncrementalOctreePointLocator vtkIncrementalOctreePointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_SafeDownCast_41((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIncrementalOctreePointLocator = (vtkIncrementalOctreePointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIncrementalOctreePointLocator.Register(null);
				}
			}
			return vtkIncrementalOctreePointLocator;
		}

		// Token: 0x0601BFEF RID: 114671
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalOctreePointLocator_SetBuildCubicOctree_42(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get whether the search octree is built as a cubic shape or not.
		/// </summary>
		// Token: 0x0601BFF0 RID: 114672 RVA: 0x0027398B File Offset: 0x00271B8B
		public virtual void SetBuildCubicOctree(int _arg)
		{
			vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_SetBuildCubicOctree_42(base.GetCppThis(), _arg);
		}

		// Token: 0x0601BFF1 RID: 114673
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalOctreePointLocator_SetMaxPointsPerLeaf_43(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the maximum number of points that a leaf node may maintain.
		/// Note that the actual number of points maintained by a leaf node might
		/// exceed this threshold if there is a large number (equal to or greater
		/// than the threshold) of exactly duplicate points (with zero distance)
		/// to be inserted (e.g., to construct an octree for subsequent point
		/// location) in extreme cases. Respecting this threshold in such scenarios
		/// would cause endless node sub-division. Thus this threshold is broken, but
		/// only in case of such situations.
		/// </summary>
		// Token: 0x0601BFF2 RID: 114674 RVA: 0x0027399B File Offset: 0x00271B9B
		public virtual void SetMaxPointsPerLeaf(int _arg)
		{
			vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_SetMaxPointsPerLeaf_43(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DD7 RID: 7639
		public new const string MRFullTypeName = "Kitware.VTK.vtkIncrementalOctreePointLocator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DD8 RID: 7640
		public new static readonly string MRClassNameKey = "class vtkIncrementalOctreePointLocator";
	}
}
