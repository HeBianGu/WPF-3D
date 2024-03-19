using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkModifiedBSPTree
	/// </summary>
	/// <remarks>
	///    Generate axis aligned BBox tree for ray-casting and other Locator based searches
	///
	///
	/// vtkModifiedBSPTree creates an evenly balanced BSP tree using a top down
	/// implementation. Axis aligned split planes are found which evenly divide
	/// cells into two buckets. Generally a split plane will intersect some cells
	/// and these are usually stored in both child nodes of the current parent.
	/// (Or split into separate cells which we cannot consider in this case).
	/// Storing cells in multiple buckets creates problems associated with multiple
	/// tests against rays and increases the required storage as complex meshes
	/// will have many cells straddling a split plane (and further splits may
	/// cause multiple copies of these).
	///
	/// During a discussion with Arno Formella in 1998 he suggested using
	/// a third child node to store objects which straddle split planes. I've not
	/// seen this published (Yes! - see below), but thought it worth trying. This
	/// implementation of the BSP tree creates a third child node for storing cells
	/// laying across split planes, the third cell may overlap the other two, but the
	/// two 'proper' nodes otherwise conform to usual BSP rules.
	///
	/// The advantage of this implementation is cells only ever lie in one node
	/// and mailbox testing is avoided. All BBoxes are axis aligned and a ray cast
	/// uses an efficient search strategy based on near/far nodes and rejects
	/// all BBoxes using simple tests.
	///
	/// For fast raytracing, 6 copies of cell lists are stored in each leaf node
	/// each list is in axis sorted order +/- x,y,z and cells are always tested
	/// in the direction of the ray dominant axis. Once an intersection is found
	/// any cell or BBox with a closest point further than the I-point can be
	/// instantly rejected and raytracing stops as soon as no nodes can be closer
	/// than the current best intersection point.
	///
	/// The addition of the 'middle' node upsets the optimal balance of the tree,
	/// but is a minor overhead during the raytrace. Each child node is contracted
	/// such that it tightly fits all cells inside it, enabling further ray/box
	/// rejections.
	///
	/// This class is intended for persons requiring many ray tests and is optimized
	/// for this purpose. As no cell ever lies in more than one leaf node, and parent
	/// nodes do not maintain cell lists, the memory overhead of the sorted cell
	/// lists is 6*num_cells*4 for 6 lists of ints, each num_cells in length.
	/// The memory requirement of the nodes themselves is usually of minor
	/// significance.
	///
	/// Subdivision is controlled by MaxCellsPerNode - any node with more than
	/// this number will be subdivided providing a good split plane can be found and
	/// the max depth is not exceeded.
	///
	/// The average cells per leaf will usually be around half the MaxCellsPerNode,
	/// though the middle node is usually sparsely populated and lowers the average
	/// slightly. The middle node will not be created when not needed.
	/// Subdividing down to very small cells per node is not generally suggested
	/// as then the 6 stored cell lists are effectively redundant.
	///
	/// Values of MaxCellsPerNode of around 16-&gt;128 depending on dataset size will
	/// usually give good results.
	///
	/// Cells are only sorted into 6 lists once - before tree creation, each node
	/// segments the lists and passes them down to the new child nodes whilst
	/// maintaining sorted order. This makes for an efficient subdivision strategy.
	///
	/// @warning
	/// vtkModifiedBSPTree utilizes the following parent class parameters:
	/// - Level                       (default 8)
	/// - MaxLevel                    (default 8)
	/// - NumberOfCellsPerNode        (default 32)
	/// - UseExistingSearchStructure  (default false)
	/// - CacheCellBounds             (default true)
	///
	/// vtkModifiedBSPTree does NOT utilize the following parameters:
	/// - Automatic
	/// - Tolerance
	/// - RetainCellLists
	///
	/// NB. The following reference has been sent to me
	/// <code>
	///   @Article{formella-1995-ray,
	///     author =     "Arno Formella and Christian Gill",
	///     title =      "{Ray Tracing: A Quantitative Analysis and a New
	///                   Practical Algorithm}",
	///     journal =    "{The Visual Computer}",
	///     year =       "{1995}",
	///     month =       dec,
	///     pages =      "{465--476}",
	///     volume =     "{11}",
	///     number =     "{9}",
	///     publisher =  "{Springer}",
	///     keywords =   "{ray tracing, space subdivision, plane traversal,
	///                    octree, clustering, benchmark scenes}",
	///     annote =     "{We present a new method to accelerate the process of
	///                    finding nearest ray--object intersections in ray
	///                    tracing. The algorithm consumes an amount of memory
	///                    more or less linear in the number of objects. The basic
	///                    ideas can be characterized with a modified BSP--tree
	///                    and plane traversal. Plane traversal is a fast linear
	///                    time algorithm to find the closest intersection point
	///                    in a list of bounding volumes hit by a ray. We use
	///                    plane traversal at every node of the high outdegree
	///                    BSP--tree. Our implementation is competitive to fast
	///                    ray tracing programs. We present a benchmark suite
	///                    which allows for an extensive comparison of ray tracing
	///                    algorithms.}",
	///   }
	/// </code>
	///
	/// @par Thanks:
	///  John Biddiscombe for developing and contributing this class
	///
	/// @todo
	/// -------------
	/// Implement intersection heap for testing rays against transparent objects
	///
	/// @par Style:
	/// --------------
	/// This class is currently maintained by J. Biddiscombe who has specially
	/// requested that the code style not be modified to the Kitware standard.
	/// Please respect the contribution of this class by keeping the style
	/// as close as possible to the author's original.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAbstractCellLocator vtkCellLocator vtkStaticCellLocator vtkCellTreeLocator vtkOBBTree
	/// </seealso>
	// Token: 0x020004B6 RID: 1206
	public class vtkModifiedBSPTree : vtkAbstractCellLocator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600DD96 RID: 56726 RVA: 0x00133945 File Offset: 0x00131B45
		static vtkModifiedBSPTree()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkModifiedBSPTree.MRClassNameKey, Type.GetType("Kitware.VTK.vtkModifiedBSPTree"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600DD97 RID: 56727 RVA: 0x0013396D File Offset: 0x00131B6D
		public vtkModifiedBSPTree(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600DD98 RID: 56728
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModifiedBSPTree_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with maximum 32 cells per node. (average 16-&gt;31)
		/// </summary>
		// Token: 0x0600DD99 RID: 56729 RVA: 0x0013397C File Offset: 0x00131B7C
		public new static vtkModifiedBSPTree New()
		{
			vtkModifiedBSPTree result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkModifiedBSPTree.vtkModifiedBSPTree_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkModifiedBSPTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with maximum 32 cells per node. (average 16-&gt;31)
		/// </summary>
		// Token: 0x0600DD9A RID: 56730 RVA: 0x001339D0 File Offset: 0x00131BD0
		public vtkModifiedBSPTree() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkModifiedBSPTree.vtkModifiedBSPTree_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600DD9B RID: 56731 RVA: 0x00133A14 File Offset: 0x00131C14
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600DD9C RID: 56732
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModifiedBSPTree_BuildLocator_01(HandleRef pThis);

		/// <summary>
		/// Satisfy vtkLocator abstract interface.
		/// </summary>
		// Token: 0x0600DD9D RID: 56733 RVA: 0x00133A1F File Offset: 0x00131C1F
		public override void BuildLocator()
		{
			vtkModifiedBSPTree.vtkModifiedBSPTree_BuildLocator_01(base.GetCppThis());
		}

		// Token: 0x0600DD9E RID: 56734
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkModifiedBSPTree_FindCell_02(HandleRef pThis, IntPtr x, double arg1, HandleRef GenCell, ref int subId, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Find the cell containing a given point. returns -1 if no cell found
		/// the cell parameters are copied into the supplied variables, a cell must
		/// be provided to store the information.
		///
		/// For other FindCell signatures, see vtkAbstractCellLocator.
		/// </summary>
		// Token: 0x0600DD9F RID: 56735 RVA: 0x00133A30 File Offset: 0x00131C30
		public override long FindCell(IntPtr x, double arg1, vtkGenericCell GenCell, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			return vtkModifiedBSPTree.vtkModifiedBSPTree_FindCell_02(base.GetCppThis(), x, arg1, (GenCell == null) ? default(HandleRef) : GenCell.GetCppThis(), ref subId, pcoords, weights);
		}

		// Token: 0x0600DDA0 RID: 56736
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModifiedBSPTree_FindCellsAlongLine_03(HandleRef pThis, IntPtr p1, IntPtr p2, double tolerance, HandleRef cellsIds);

		/// <summary>
		/// Take the passed line segment and intersect it with the data set.
		/// For each intersection with the bounds of a cell, the cellIds
		/// have the relevant information added sort by t. If cellIds is nullptr
		/// pointer, then no information is generated for that list.
		///
		/// Reimplemented from vtkAbstractCellLocator to showcase that it's a supported function.
		/// </summary>
		// Token: 0x0600DDA1 RID: 56737 RVA: 0x00133A6C File Offset: 0x00131C6C
		public override void FindCellsAlongLine(IntPtr p1, IntPtr p2, double tolerance, vtkIdList cellsIds)
		{
			vtkModifiedBSPTree.vtkModifiedBSPTree_FindCellsAlongLine_03(base.GetCppThis(), p1, p2, tolerance, (cellsIds == null) ? default(HandleRef) : cellsIds.GetCppThis());
		}

		// Token: 0x0600DDA2 RID: 56738
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModifiedBSPTree_ForceBuildLocator_04(HandleRef pThis);

		/// <summary>
		/// Satisfy vtkLocator abstract interface.
		/// </summary>
		// Token: 0x0600DDA3 RID: 56739 RVA: 0x00133AA0 File Offset: 0x00131CA0
		public override void ForceBuildLocator()
		{
			vtkModifiedBSPTree.vtkModifiedBSPTree_ForceBuildLocator_04(base.GetCppThis());
		}

		// Token: 0x0600DDA4 RID: 56740
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModifiedBSPTree_FreeSearchStructure_05(HandleRef pThis);

		/// <summary>
		/// Satisfy vtkLocator abstract interface.
		/// </summary>
		// Token: 0x0600DDA5 RID: 56741 RVA: 0x00133AAF File Offset: 0x00131CAF
		public override void FreeSearchStructure()
		{
			vtkModifiedBSPTree.vtkModifiedBSPTree_FreeSearchStructure_05(base.GetCppThis());
		}

		// Token: 0x0600DDA6 RID: 56742
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModifiedBSPTree_GenerateRepresentation_06(HandleRef pThis, int level, HandleRef pd);

		/// <summary>
		/// Satisfy vtkLocator abstract interface.
		/// </summary>
		// Token: 0x0600DDA7 RID: 56743 RVA: 0x00133AC0 File Offset: 0x00131CC0
		public override void GenerateRepresentation(int level, vtkPolyData pd)
		{
			vtkModifiedBSPTree.vtkModifiedBSPTree_GenerateRepresentation_06(base.GetCppThis(), level, (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0600DDA8 RID: 56744
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModifiedBSPTree_GenerateRepresentationLeafs_07(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Generate BBox representation of all leaf nodes
		/// </summary>
		// Token: 0x0600DDA9 RID: 56745 RVA: 0x00133AF0 File Offset: 0x00131CF0
		public virtual void GenerateRepresentationLeafs(vtkPolyData pd)
		{
			vtkModifiedBSPTree.vtkModifiedBSPTree_GenerateRepresentationLeafs_07(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0600DDAA RID: 56746
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModifiedBSPTree_GetLeafNodeCellInformation_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// After subdivision has completed, one may wish to query the tree to find
		/// which cells are in which leaf nodes. This function returns a list
		/// which holds a cell Id list for each leaf node.
		/// </summary>
		// Token: 0x0600DDAB RID: 56747 RVA: 0x00133B20 File Offset: 0x00131D20
		public vtkIdListCollection GetLeafNodeCellInformation()
		{
			vtkIdListCollection vtkIdListCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkModifiedBSPTree.vtkModifiedBSPTree_GetLeafNodeCellInformation_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdListCollection = (vtkIdListCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdListCollection.Register(null);
				}
			}
			return vtkIdListCollection;
		}

		// Token: 0x0600DDAC RID: 56748
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkModifiedBSPTree_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to print and obtain type-related information.
		/// </summary>
		// Token: 0x0600DDAD RID: 56749 RVA: 0x00133B90 File Offset: 0x00131D90
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkModifiedBSPTree.vtkModifiedBSPTree_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x0600DDAE RID: 56750
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkModifiedBSPTree_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to print and obtain type-related information.
		/// </summary>
		// Token: 0x0600DDAF RID: 56751 RVA: 0x00133BB0 File Offset: 0x00131DB0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkModifiedBSPTree.vtkModifiedBSPTree_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x0600DDB0 RID: 56752
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModifiedBSPTree_IntersectWithLine_11(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, HandleRef cell);

		/// <summary>
		/// Return intersection point (if any) AND the cell which was intersected by
		/// the finite line. The cell is returned as a cell id and as a generic cell.
		///
		/// For other IntersectWithLine signatures, see vtkAbstractCellLocator.
		/// </summary>
		// Token: 0x0600DDB1 RID: 56753 RVA: 0x00133BCC File Offset: 0x00131DCC
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, vtkGenericCell cell)
		{
			return vtkModifiedBSPTree.vtkModifiedBSPTree_IntersectWithLine_11(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId, ref cellId, (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x0600DDB2 RID: 56754
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModifiedBSPTree_IntersectWithLine_12(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, HandleRef points, HandleRef cellIds, HandleRef cell);

		/// <summary>
		/// Take the passed line segment and intersect it with the data set.
		/// The return value of the function is 0 if no intersections were found.
		/// For each intersection with the bounds of a cell or with a cell (if a cell is provided),
		/// the points and cellIds have the relevant information added sorted by t.
		/// If points or cellIds are nullptr pointers, then no information is generated for that list.
		///
		/// For other IntersectWithLine signatures, see vtkAbstractCellLocator.
		/// </summary>
		// Token: 0x0600DDB3 RID: 56755 RVA: 0x00133C10 File Offset: 0x00131E10
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, vtkPoints points, vtkIdList cellIds, vtkGenericCell cell)
		{
			return vtkModifiedBSPTree.vtkModifiedBSPTree_IntersectWithLine_12(base.GetCppThis(), p1, p2, tol, (points == null) ? default(HandleRef) : points.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x0600DDB4 RID: 56756
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModifiedBSPTree_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to print and obtain type-related information.
		/// </summary>
		// Token: 0x0600DDB5 RID: 56757 RVA: 0x00133C78 File Offset: 0x00131E78
		public override int IsA(string type)
		{
			return vtkModifiedBSPTree.vtkModifiedBSPTree_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x0600DDB6 RID: 56758
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkModifiedBSPTree_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to print and obtain type-related information.
		/// </summary>
		// Token: 0x0600DDB7 RID: 56759 RVA: 0x00133C98 File Offset: 0x00131E98
		public new static int IsTypeOf(string type)
		{
			return vtkModifiedBSPTree.vtkModifiedBSPTree_IsTypeOf_14(type);
		}

		// Token: 0x0600DDB8 RID: 56760
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModifiedBSPTree_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to print and obtain type-related information.
		/// </summary>
		// Token: 0x0600DDB9 RID: 56761 RVA: 0x00133CB4 File Offset: 0x00131EB4
		public new vtkModifiedBSPTree NewInstance()
		{
			vtkModifiedBSPTree result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkModifiedBSPTree.vtkModifiedBSPTree_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkModifiedBSPTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600DDBA RID: 56762
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkModifiedBSPTree_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to print and obtain type-related information.
		/// </summary>
		// Token: 0x0600DDBB RID: 56763 RVA: 0x00133D10 File Offset: 0x00131F10
		public new static vtkModifiedBSPTree SafeDownCast(vtkObjectBase o)
		{
			vtkModifiedBSPTree vtkModifiedBSPTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkModifiedBSPTree.vtkModifiedBSPTree_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkModifiedBSPTree = (vtkModifiedBSPTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkModifiedBSPTree.Register(null);
				}
			}
			return vtkModifiedBSPTree;
		}

		// Token: 0x0600DDBC RID: 56764
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkModifiedBSPTree_ShallowCopy_18(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Shallow copy of a vtkModifiedBSPTree.
		/// </summary>
		// Token: 0x0600DDBD RID: 56765 RVA: 0x00133D90 File Offset: 0x00131F90
		public override void ShallowCopy(vtkAbstractCellLocator locator)
		{
			vtkModifiedBSPTree.vtkModifiedBSPTree_ShallowCopy_18(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400102B RID: 4139
		public new const string MRFullTypeName = "Kitware.VTK.vtkModifiedBSPTree";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400102C RID: 4140
		public new static readonly string MRClassNameKey = "class vtkModifiedBSPTree";
	}
}
