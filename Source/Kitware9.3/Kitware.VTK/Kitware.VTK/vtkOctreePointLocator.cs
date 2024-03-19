using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOctreePointLocator
	/// </summary>
	/// <remarks>
	///    an octree spatial decomposition of a set of points
	///
	///
	/// Given a vtkDataSet, create an octree that is locally refined
	/// such that all leaf octants contain less than a certain
	/// amount of points.  Note that there is no size constraint that
	/// a leaf octant in relation to any of its neighbors.
	///
	/// This class can also generate a PolyData representation of
	/// the boundaries of the spatial regions in the decomposition.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkLocator vtkPointLocator vtkOctreePointLocatorNode
	/// </seealso>
	// Token: 0x02000A8A RID: 2698
	public class vtkOctreePointLocator : vtkAbstractPointLocator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C41C RID: 115740 RVA: 0x0027B01B File Offset: 0x0027921B
		static vtkOctreePointLocator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOctreePointLocator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOctreePointLocator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C41D RID: 115741 RVA: 0x0027B043 File Offset: 0x00279243
		public vtkOctreePointLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C41E RID: 115742
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOctreePointLocator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C41F RID: 115743 RVA: 0x0027B054 File Offset: 0x00279254
		public new static vtkOctreePointLocator New()
		{
			vtkOctreePointLocator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOctreePointLocator.vtkOctreePointLocator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOctreePointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C420 RID: 115744 RVA: 0x0027B0A8 File Offset: 0x002792A8
		public vtkOctreePointLocator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOctreePointLocator.vtkOctreePointLocator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C421 RID: 115745 RVA: 0x0027B0EC File Offset: 0x002792EC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C422 RID: 115746
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreePointLocator_BuildLocator_01(HandleRef pThis);

		/// <summary>
		/// Create the octree decomposition of the cells of the data set
		/// or data sets.  Cells are assigned to octree spatial regions
		/// based on the location of their centroids.
		///
		/// This will NOT do anything if UseExistingSearchStructure is on.
		/// </summary>
		// Token: 0x0601C423 RID: 115747 RVA: 0x0027B0F7 File Offset: 0x002792F7
		public override void BuildLocator()
		{
			vtkOctreePointLocator.vtkOctreePointLocator_BuildLocator_01(base.GetCppThis());
		}

		// Token: 0x0601C424 RID: 115748
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreePointLocator_FindClosestNPoints_02(HandleRef pThis, int N, IntPtr x, HandleRef result);

		/// <summary>
		/// Find the closest N points to a position. This returns the closest
		/// N points to a position. A faster method could be created that returned
		/// N close points to a position, but not necessarily the exact N closest.
		/// The returned points are sorted from closest to farthest.
		/// These methods are thread safe if BuildLocator() is directly or
		/// indirectly called from a single thread first.
		/// </summary>
		// Token: 0x0601C425 RID: 115749 RVA: 0x0027B108 File Offset: 0x00279308
		public override void FindClosestNPoints(int N, IntPtr x, vtkIdList result)
		{
			vtkOctreePointLocator.vtkOctreePointLocator_FindClosestNPoints_02(base.GetCppThis(), N, x, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		// Token: 0x0601C426 RID: 115750
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOctreePointLocator_FindClosestPoint_03(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Return the Id of the point that is closest to the given point.
		/// Set the square of the distance between the two points.
		/// </summary>
		// Token: 0x0601C427 RID: 115751 RVA: 0x0027B13C File Offset: 0x0027933C
		public override long FindClosestPoint(IntPtr x)
		{
			return vtkOctreePointLocator.vtkOctreePointLocator_FindClosestPoint_03(base.GetCppThis(), x);
		}

		// Token: 0x0601C428 RID: 115752
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOctreePointLocator_FindClosestPoint_04(HandleRef pThis, double x, double y, double z, ref double dist2);

		/// <summary>
		/// Return the Id of the point that is closest to the given point.
		/// Set the square of the distance between the two points.
		/// </summary>
		// Token: 0x0601C429 RID: 115753 RVA: 0x0027B15C File Offset: 0x0027935C
		public long FindClosestPoint(double x, double y, double z, ref double dist2)
		{
			return vtkOctreePointLocator.vtkOctreePointLocator_FindClosestPoint_04(base.GetCppThis(), x, y, z, ref dist2);
		}

		// Token: 0x0601C42A RID: 115754
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOctreePointLocator_FindClosestPointInRegion_05(HandleRef pThis, int regionId, IntPtr x, ref double dist2);

		/// <summary>
		/// Find the Id of the point in the given leaf region which is
		/// closest to the given point.  Return the ID of the point,
		/// and set the square of the distance of between the points.
		/// </summary>
		// Token: 0x0601C42B RID: 115755 RVA: 0x0027B180 File Offset: 0x00279380
		public long FindClosestPointInRegion(int regionId, IntPtr x, ref double dist2)
		{
			return vtkOctreePointLocator.vtkOctreePointLocator_FindClosestPointInRegion_05(base.GetCppThis(), regionId, x, ref dist2);
		}

		// Token: 0x0601C42C RID: 115756
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOctreePointLocator_FindClosestPointInRegion_06(HandleRef pThis, int regionId, double x, double y, double z, ref double dist2);

		/// <summary>
		/// Find the Id of the point in the given leaf region which is
		/// closest to the given point.  Return the ID of the point,
		/// and set the square of the distance of between the points.
		/// </summary>
		// Token: 0x0601C42D RID: 115757 RVA: 0x0027B1A4 File Offset: 0x002793A4
		public long FindClosestPointInRegion(int regionId, double x, double y, double z, ref double dist2)
		{
			return vtkOctreePointLocator.vtkOctreePointLocator_FindClosestPointInRegion_06(base.GetCppThis(), regionId, x, y, z, ref dist2);
		}

		// Token: 0x0601C42E RID: 115758
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOctreePointLocator_FindClosestPointWithinRadius_07(HandleRef pThis, double radius, IntPtr x, ref double dist2);

		/// <summary>
		/// Given a position x and a radius r, return the id of the point
		/// closest to the point in that radius.
		/// dist2 returns the squared distance to the point.
		/// </summary>
		// Token: 0x0601C42F RID: 115759 RVA: 0x0027B1CC File Offset: 0x002793CC
		public override long FindClosestPointWithinRadius(double radius, IntPtr x, ref double dist2)
		{
			return vtkOctreePointLocator.vtkOctreePointLocator_FindClosestPointWithinRadius_07(base.GetCppThis(), radius, x, ref dist2);
		}

		// Token: 0x0601C430 RID: 115760
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreePointLocator_FindPointsInArea_08(HandleRef pThis, IntPtr area, HandleRef ids, byte clearArray);

		/// <summary>
		/// Fill ids with points found in area.  The area is a 6-tuple containing
		/// (xmin, xmax, ymin, ymax, zmin, zmax).
		/// This method will clear the array by default.  To append ids to an array,
		/// set clearArray to false.
		/// </summary>
		// Token: 0x0601C431 RID: 115761 RVA: 0x0027B1F0 File Offset: 0x002793F0
		public void FindPointsInArea(IntPtr area, vtkIdTypeArray ids, bool clearArray)
		{
			vtkOctreePointLocator.vtkOctreePointLocator_FindPointsInArea_08(base.GetCppThis(), area, (ids == null) ? default(HandleRef) : ids.GetCppThis(), clearArray ? (byte)1 : (byte)0);
		}

		// Token: 0x0601C432 RID: 115762
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreePointLocator_FindPointsWithinRadius_09(HandleRef pThis, double radius, IntPtr x, HandleRef result);

		/// <summary>
		/// Find all points within a specified radius of position x.
		/// The result is not sorted in any specific manner.
		/// </summary>
		// Token: 0x0601C433 RID: 115763 RVA: 0x0027B22C File Offset: 0x0027942C
		public override void FindPointsWithinRadius(double radius, IntPtr x, vtkIdList result)
		{
			vtkOctreePointLocator.vtkOctreePointLocator_FindPointsWithinRadius_09(base.GetCppThis(), radius, x, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		// Token: 0x0601C434 RID: 115764
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreePointLocator_ForceBuildLocator_10(HandleRef pThis);

		/// <summary>
		/// Build the locator from the input dataset (even if UseExistingSearchStructure is on).
		/// </summary>
		// Token: 0x0601C435 RID: 115765 RVA: 0x0027B25D File Offset: 0x0027945D
		public override void ForceBuildLocator()
		{
			vtkOctreePointLocator.vtkOctreePointLocator_ForceBuildLocator_10(base.GetCppThis());
		}

		// Token: 0x0601C436 RID: 115766
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreePointLocator_FreeSearchStructure_11(HandleRef pThis);

		/// <summary>
		/// Delete the octree data structure.
		/// </summary>
		// Token: 0x0601C437 RID: 115767 RVA: 0x0027B26C File Offset: 0x0027946C
		public override void FreeSearchStructure()
		{
			vtkOctreePointLocator.vtkOctreePointLocator_FreeSearchStructure_11(base.GetCppThis());
		}

		// Token: 0x0601C438 RID: 115768
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreePointLocator_GenerateRepresentation_12(HandleRef pThis, int level, HandleRef pd);

		/// <summary>
		/// Create a polydata representation of the boundaries of
		/// the octree regions.
		/// </summary>
		// Token: 0x0601C439 RID: 115769 RVA: 0x0027B27C File Offset: 0x0027947C
		public override void GenerateRepresentation(int level, vtkPolyData pd)
		{
			vtkOctreePointLocator.vtkOctreePointLocator_GenerateRepresentation_12(base.GetCppThis(), level, (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0601C43A RID: 115770
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOctreePointLocator_GetBounds_13(HandleRef pThis);

		/// <summary>
		/// Get the spatial bounds of the entire octree space. Sets
		/// bounds array to xmin, xmax, ymin, ymax, zmin, zmax.
		/// </summary>
		// Token: 0x0601C43B RID: 115771 RVA: 0x0027B2AC File Offset: 0x002794AC
		public override IntPtr GetBounds()
		{
			return vtkOctreePointLocator.vtkOctreePointLocator_GetBounds_13(base.GetCppThis());
		}

		// Token: 0x0601C43C RID: 115772
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreePointLocator_GetBounds_14(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the spatial bounds of the entire octree space. Sets
		/// bounds array to xmin, xmax, ymin, ymax, zmin, zmax.
		/// </summary>
		// Token: 0x0601C43D RID: 115773 RVA: 0x0027B2CB File Offset: 0x002794CB
		public override void GetBounds(IntPtr bounds)
		{
			vtkOctreePointLocator.vtkOctreePointLocator_GetBounds_14(base.GetCppThis(), bounds);
		}

		// Token: 0x0601C43E RID: 115774
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOctreePointLocator_GetCreateCubicOctants_15(HandleRef pThis);

		/// <summary>
		/// Get/Set macro for CreateCubicOctants.
		/// </summary>
		// Token: 0x0601C43F RID: 115775 RVA: 0x0027B2DC File Offset: 0x002794DC
		public virtual int GetCreateCubicOctants()
		{
			return vtkOctreePointLocator.vtkOctreePointLocator_GetCreateCubicOctants_15(base.GetCppThis());
		}

		// Token: 0x0601C440 RID: 115776
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOctreePointLocator_GetFudgeFactor_16(HandleRef pThis);

		/// <summary>
		/// Some algorithms on octrees require a value that is a very
		/// small distance relative to the diameter of the entire space
		/// divided by the octree.  This factor is the maximum axis-aligned
		/// width of the space multiplied by 10e-6.
		/// </summary>
		// Token: 0x0601C441 RID: 115777 RVA: 0x0027B2FC File Offset: 0x002794FC
		public virtual double GetFudgeFactor()
		{
			return vtkOctreePointLocator.vtkOctreePointLocator_GetFudgeFactor_16(base.GetCppThis());
		}

		// Token: 0x0601C442 RID: 115778
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOctreePointLocator_GetMaximumPointsPerRegion_17(HandleRef pThis);

		/// <summary>
		/// Maximum number of points per spatial region.  Default is 100.
		/// </summary>
		// Token: 0x0601C443 RID: 115779 RVA: 0x0027B31C File Offset: 0x0027951C
		public virtual int GetMaximumPointsPerRegion()
		{
			return vtkOctreePointLocator.vtkOctreePointLocator_GetMaximumPointsPerRegion_17(base.GetCppThis());
		}

		// Token: 0x0601C444 RID: 115780
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOctreePointLocator_GetNumberOfGenerationsFromBase_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C445 RID: 115781 RVA: 0x0027B33C File Offset: 0x0027953C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOctreePointLocator.vtkOctreePointLocator_GetNumberOfGenerationsFromBase_18(base.GetCppThis(), type);
		}

		// Token: 0x0601C446 RID: 115782
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOctreePointLocator_GetNumberOfGenerationsFromBaseType_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C447 RID: 115783 RVA: 0x0027B35C File Offset: 0x0027955C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOctreePointLocator.vtkOctreePointLocator_GetNumberOfGenerationsFromBaseType_19(type);
		}

		// Token: 0x0601C448 RID: 115784
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOctreePointLocator_GetNumberOfLeafNodes_20(HandleRef pThis);

		/// <summary>
		/// The number of leaf nodes of the tree, the spatial regions
		/// </summary>
		// Token: 0x0601C449 RID: 115785 RVA: 0x0027B378 File Offset: 0x00279578
		public virtual int GetNumberOfLeafNodes()
		{
			return vtkOctreePointLocator.vtkOctreePointLocator_GetNumberOfLeafNodes_20(base.GetCppThis());
		}

		// Token: 0x0601C44A RID: 115786
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOctreePointLocator_GetPointsInRegion_21(HandleRef pThis, int leafNodeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a list of the original IDs of all points in a leaf node.
		/// </summary>
		// Token: 0x0601C44B RID: 115787 RVA: 0x0027B398 File Offset: 0x00279598
		public vtkIdTypeArray GetPointsInRegion(int leafNodeId)
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOctreePointLocator.vtkOctreePointLocator_GetPointsInRegion_21(base.GetCppThis(), leafNodeId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C44C RID: 115788
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreePointLocator_GetRegionBounds_22(HandleRef pThis, int regionID, IntPtr bounds);

		/// <summary>
		/// Get the spatial bounds of octree region
		/// </summary>
		// Token: 0x0601C44D RID: 115789 RVA: 0x0027B408 File Offset: 0x00279608
		public void GetRegionBounds(int regionID, IntPtr bounds)
		{
			vtkOctreePointLocator.vtkOctreePointLocator_GetRegionBounds_22(base.GetCppThis(), regionID, bounds);
		}

		// Token: 0x0601C44E RID: 115790
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOctreePointLocator_GetRegionContainingPoint_23(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Get the id of the leaf region containing the specified location.
		/// </summary>
		// Token: 0x0601C44F RID: 115791 RVA: 0x0027B41C File Offset: 0x0027961C
		public int GetRegionContainingPoint(double x, double y, double z)
		{
			return vtkOctreePointLocator.vtkOctreePointLocator_GetRegionContainingPoint_23(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0601C450 RID: 115792
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreePointLocator_GetRegionDataBounds_24(HandleRef pThis, int leafNodeID, IntPtr bounds);

		/// <summary>
		/// Get the bounds of the data within the leaf node
		/// </summary>
		// Token: 0x0601C451 RID: 115793 RVA: 0x0027B43E File Offset: 0x0027963E
		public void GetRegionDataBounds(int leafNodeID, IntPtr bounds)
		{
			vtkOctreePointLocator.vtkOctreePointLocator_GetRegionDataBounds_24(base.GetCppThis(), leafNodeID, bounds);
		}

		// Token: 0x0601C452 RID: 115794
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOctreePointLocator_IsA_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C453 RID: 115795 RVA: 0x0027B450 File Offset: 0x00279650
		public override int IsA(string type)
		{
			return vtkOctreePointLocator.vtkOctreePointLocator_IsA_25(base.GetCppThis(), type);
		}

		// Token: 0x0601C454 RID: 115796
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOctreePointLocator_IsTypeOf_26([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C455 RID: 115797 RVA: 0x0027B470 File Offset: 0x00279670
		public new static int IsTypeOf(string type)
		{
			return vtkOctreePointLocator.vtkOctreePointLocator_IsTypeOf_26(type);
		}

		// Token: 0x0601C456 RID: 115798
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOctreePointLocator_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C457 RID: 115799 RVA: 0x0027B48C File Offset: 0x0027968C
		public new vtkOctreePointLocator NewInstance()
		{
			vtkOctreePointLocator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOctreePointLocator.vtkOctreePointLocator_NewInstance_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOctreePointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C458 RID: 115800
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOctreePointLocator_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C459 RID: 115801 RVA: 0x0027B4E8 File Offset: 0x002796E8
		public new static vtkOctreePointLocator SafeDownCast(vtkObjectBase o)
		{
			vtkOctreePointLocator vtkOctreePointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOctreePointLocator.vtkOctreePointLocator_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOctreePointLocator = (vtkOctreePointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOctreePointLocator.Register(null);
				}
			}
			return vtkOctreePointLocator;
		}

		// Token: 0x0601C45A RID: 115802
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreePointLocator_SetCreateCubicOctants_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set macro for CreateCubicOctants.
		/// </summary>
		// Token: 0x0601C45B RID: 115803 RVA: 0x0027B567 File Offset: 0x00279767
		public virtual void SetCreateCubicOctants(int _arg)
		{
			vtkOctreePointLocator.vtkOctreePointLocator_SetCreateCubicOctants_30(base.GetCppThis(), _arg);
		}

		// Token: 0x0601C45C RID: 115804
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreePointLocator_SetFudgeFactor_31(HandleRef pThis, double _arg);

		/// <summary>
		/// Some algorithms on octrees require a value that is a very
		/// small distance relative to the diameter of the entire space
		/// divided by the octree.  This factor is the maximum axis-aligned
		/// width of the space multiplied by 10e-6.
		/// </summary>
		// Token: 0x0601C45D RID: 115805 RVA: 0x0027B577 File Offset: 0x00279777
		public virtual void SetFudgeFactor(double _arg)
		{
			vtkOctreePointLocator.vtkOctreePointLocator_SetFudgeFactor_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0601C45E RID: 115806
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreePointLocator_SetMaximumPointsPerRegion_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Maximum number of points per spatial region.  Default is 100.
		/// </summary>
		// Token: 0x0601C45F RID: 115807 RVA: 0x0027B587 File Offset: 0x00279787
		public virtual void SetMaximumPointsPerRegion(int _arg)
		{
			vtkOctreePointLocator.vtkOctreePointLocator_SetMaximumPointsPerRegion_32(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E10 RID: 7696
		public new const string MRFullTypeName = "Kitware.VTK.vtkOctreePointLocator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E11 RID: 7697
		public new static readonly string MRClassNameKey = "class vtkOctreePointLocator";
	}
}
