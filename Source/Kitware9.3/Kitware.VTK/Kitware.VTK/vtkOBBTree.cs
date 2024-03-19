using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOBBTree
	/// </summary>
	/// <remarks>
	///    generate oriented bounding box (OBB) tree
	///
	/// vtkOBBTree is an object to generate oriented bounding box (OBB) trees.
	/// An oriented bounding box is a bounding box that does not necessarily line
	/// up along coordinate axes. The OBB tree is a hierarchical tree structure
	/// of such boxes, where deeper levels of OBB confine smaller regions of space.
	///
	/// To build the OBB, a recursive, top-down process is used. First, the root OBB
	/// is constructed by finding the mean and covariance matrix of the cells (and
	/// their points) that define the dataset. The eigenvectors of the covariance
	/// matrix are extracted, giving a set of three orthogonal vectors that define
	/// the tightest-fitting OBB. To create the two children OBB's, a split plane
	/// is found that (approximately) divides the number cells in half. These are
	/// then assigned to the children OBB's. This process then continues until
	/// the MaxLevel ivar limits the recursion, or no split plane can be found.
	///
	/// A good reference for OBB-trees is Gottschalk &amp; Manocha in Proceedings of
	/// Siggraph `96.
	///
	/// @warning
	/// vtkOBBTree utilizes the following parent class parameters:
	/// - Tolerance                   (default 0.01)
	/// - Level                       (default 4)
	/// - MaxLevel                    (default 12)
	/// - NumberOfCellsPerNode        (default 32)
	/// - RetainCellLists             (default true)
	/// - UseExistingSearchStructure  (default false)
	///
	/// vtkOBBTree does NOT utilize the following parameters:
	/// - Automatic
	/// - CacheCellBounds
	///
	/// @warning
	/// Since this algorithms works from a list of cells, the OBB tree will only
	/// bound the "geometry" attached to the cells if the convex hull of the
	/// cells bounds the geometry.
	///
	/// @warning
	/// Long, skinny cells (i.e., cells with poor aspect ratio) may cause
	/// unsatisfactory results. This is due to the fact that this is a top-down
	/// implementation of the OBB tree, requiring that one or more complete cells
	/// are contained in each OBB. This requirement makes it hard to find good
	/// split planes during the recursion process. A bottom-up implementation would
	/// go a long way to correcting this problem.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAbstractCellLocator vtkCellLocator vtkStaticCellLocator vtkCellTreeLocator vtkModifiedBSPTree
	/// </seealso>
	// Token: 0x020008C6 RID: 2246
	public class vtkOBBTree : vtkAbstractCellLocator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601737A RID: 95098 RVA: 0x00209863 File Offset: 0x00207A63
		static vtkOBBTree()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOBBTree.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOBBTree"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601737B RID: 95099 RVA: 0x0020988B File Offset: 0x00207A8B
		public vtkOBBTree(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601737C RID: 95100
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOBBTree_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with automatic computation of divisions, averaging
		/// 25 cells per octant.
		/// </summary>
		// Token: 0x0601737D RID: 95101 RVA: 0x0020989C File Offset: 0x00207A9C
		public new static vtkOBBTree New()
		{
			vtkOBBTree result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOBBTree.vtkOBBTree_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOBBTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with automatic computation of divisions, averaging
		/// 25 cells per octant.
		/// </summary>
		// Token: 0x0601737E RID: 95102 RVA: 0x002098F0 File Offset: 0x00207AF0
		public vtkOBBTree() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOBBTree.vtkOBBTree_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601737F RID: 95103 RVA: 0x00209934 File Offset: 0x00207B34
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017380 RID: 95104
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOBBTree_BuildLocator_01(HandleRef pThis);

		/// <summary>
		/// Satisfy locator's abstract interface, see vtkLocator.
		/// </summary>
		// Token: 0x06017381 RID: 95105 RVA: 0x0020993F File Offset: 0x00207B3F
		public override void BuildLocator()
		{
			vtkOBBTree.vtkOBBTree_BuildLocator_01(base.GetCppThis());
		}

		// Token: 0x06017382 RID: 95106
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOBBTree_ComputeOBB_02(HandleRef pts, IntPtr corner, IntPtr max, IntPtr mid, IntPtr min, IntPtr size);

		/// <summary>
		/// Compute an OBB from the list of points given. Return the corner point
		/// and the three axes defining the orientation of the OBB. Also return
		/// a sorted list of relative "sizes" of axes for comparison purposes.
		/// </summary>
		// Token: 0x06017383 RID: 95107 RVA: 0x00209950 File Offset: 0x00207B50
		public static void ComputeOBB(vtkPoints pts, IntPtr corner, IntPtr max, IntPtr mid, IntPtr min, IntPtr size)
		{
			vtkOBBTree.vtkOBBTree_ComputeOBB_02((pts == null) ? default(HandleRef) : pts.GetCppThis(), corner, max, mid, min, size);
		}

		// Token: 0x06017384 RID: 95108
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOBBTree_ComputeOBB_03(HandleRef pThis, HandleRef input, IntPtr corner, IntPtr max, IntPtr mid, IntPtr min, IntPtr size);

		/// <summary>
		/// Compute an OBB for the input dataset using the cells in the data.
		/// Return the corner point and the three axes defining the orientation
		/// of the OBB. Also return a sorted list of relative "sizes" of axes for
		/// comparison purposes.
		/// </summary>
		// Token: 0x06017385 RID: 95109 RVA: 0x00209980 File Offset: 0x00207B80
		public void ComputeOBB(vtkDataSet input, IntPtr corner, IntPtr max, IntPtr mid, IntPtr min, IntPtr size)
		{
			vtkOBBTree.vtkOBBTree_ComputeOBB_03(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), corner, max, mid, min, size);
		}

		// Token: 0x06017386 RID: 95110
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOBBTree_ForceBuildLocator_04(HandleRef pThis);

		/// <summary>
		/// Satisfy locator's abstract interface, see vtkLocator.
		/// </summary>
		// Token: 0x06017387 RID: 95111 RVA: 0x002099B7 File Offset: 0x00207BB7
		public override void ForceBuildLocator()
		{
			vtkOBBTree.vtkOBBTree_ForceBuildLocator_04(base.GetCppThis());
		}

		// Token: 0x06017388 RID: 95112
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOBBTree_FreeSearchStructure_05(HandleRef pThis);

		/// <summary>
		/// Satisfy locator's abstract interface, see vtkLocator.
		/// </summary>
		// Token: 0x06017389 RID: 95113 RVA: 0x002099C6 File Offset: 0x00207BC6
		public override void FreeSearchStructure()
		{
			vtkOBBTree.vtkOBBTree_FreeSearchStructure_05(base.GetCppThis());
		}

		// Token: 0x0601738A RID: 95114
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOBBTree_GenerateRepresentation_06(HandleRef pThis, int level, HandleRef pd);

		/// <summary>
		/// Create polygonal representation for OBB tree at specified level. If
		/// level &lt; 0, then the leaf OBB nodes will be gathered. The aspect ratio (ar)
		/// and line diameter (d) are used to control the building of the
		/// representation. If a OBB node edge ratio's are greater than ar, then the
		/// dimension of the OBB is collapsed (OBB-&gt;plane-&gt;line). A "line" OBB will be
		/// represented either as two crossed polygons, or as a line, depending on
		/// the relative diameter of the OBB compared to the diameter (d).
		/// </summary>
		// Token: 0x0601738B RID: 95115 RVA: 0x002099D8 File Offset: 0x00207BD8
		public override void GenerateRepresentation(int level, vtkPolyData pd)
		{
			vtkOBBTree.vtkOBBTree_GenerateRepresentation_06(base.GetCppThis(), level, (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0601738C RID: 95116
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOBBTree_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to print and obtain type-related information.
		/// </summary>
		// Token: 0x0601738D RID: 95117 RVA: 0x00209A08 File Offset: 0x00207C08
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOBBTree.vtkOBBTree_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601738E RID: 95118
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOBBTree_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to print and obtain type-related information.
		/// </summary>
		// Token: 0x0601738F RID: 95119 RVA: 0x00209A28 File Offset: 0x00207C28
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOBBTree.vtkOBBTree_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06017390 RID: 95120
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOBBTree_InsideOrOutside_09(HandleRef pThis, IntPtr point);

		/// <summary>
		/// Determine whether a point is inside or outside the data used to build
		/// this OBB tree.  The data must be a closed surface vtkPolyData data set.
		/// The return value is +1 if outside, -1 if inside, and 0 if undecided.
		/// </summary>
		// Token: 0x06017391 RID: 95121 RVA: 0x00209A44 File Offset: 0x00207C44
		public int InsideOrOutside(IntPtr point)
		{
			return vtkOBBTree.vtkOBBTree_InsideOrOutside_09(base.GetCppThis(), point);
		}

		// Token: 0x06017392 RID: 95122
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOBBTree_IntersectWithLine_10(HandleRef pThis, IntPtr a0, IntPtr a1, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, HandleRef cell);

		/// <summary>
		/// Return the first intersection of the specified line segment with
		/// the OBB tree, as well as information about the cell which the
		/// line segment intersected. A return value of 1 indicates an intersection
		/// and 0 indicates no intersection.
		/// </summary>
		// Token: 0x06017393 RID: 95123 RVA: 0x00209A64 File Offset: 0x00207C64
		public override int IntersectWithLine(IntPtr a0, IntPtr a1, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, vtkGenericCell cell)
		{
			return vtkOBBTree.vtkOBBTree_IntersectWithLine_10(base.GetCppThis(), a0, a1, tol, ref t, x, pcoords, ref subId, ref cellId, (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017394 RID: 95124
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOBBTree_IntersectWithLine_11(HandleRef pThis, IntPtr a0, IntPtr a1, HandleRef points, HandleRef cellIds);

		/// <summary>
		/// Take the passed line segment and intersect it with the data set.
		/// This method assumes that the data set is a vtkPolyData that describes
		/// a closed surface, and the intersection points that are returned in
		/// 'points' alternate between entrance points and exit points.
		/// The return value of the function is 0 if no intersections were found,
		/// -1 if point 'a0' lies inside the closed surface, or +1 if point 'a0'
		/// lies outside the closed surface.
		/// Either 'points' or 'cellIds' can be set to nullptr if you don't want
		/// to receive that information.
		/// </summary>
		// Token: 0x06017395 RID: 95125 RVA: 0x00209AA8 File Offset: 0x00207CA8
		public override int IntersectWithLine(IntPtr a0, IntPtr a1, vtkPoints points, vtkIdList cellIds)
		{
			return vtkOBBTree.vtkOBBTree_IntersectWithLine_11(base.GetCppThis(), a0, a1, (points == null) ? default(HandleRef) : points.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		// Token: 0x06017396 RID: 95126
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOBBTree_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to print and obtain type-related information.
		/// </summary>
		// Token: 0x06017397 RID: 95127 RVA: 0x00209AF8 File Offset: 0x00207CF8
		public override int IsA(string type)
		{
			return vtkOBBTree.vtkOBBTree_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x06017398 RID: 95128
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOBBTree_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to print and obtain type-related information.
		/// </summary>
		// Token: 0x06017399 RID: 95129 RVA: 0x00209B18 File Offset: 0x00207D18
		public new static int IsTypeOf(string type)
		{
			return vtkOBBTree.vtkOBBTree_IsTypeOf_13(type);
		}

		// Token: 0x0601739A RID: 95130
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOBBTree_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to print and obtain type-related information.
		/// </summary>
		// Token: 0x0601739B RID: 95131 RVA: 0x00209B34 File Offset: 0x00207D34
		public new vtkOBBTree NewInstance()
		{
			vtkOBBTree result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOBBTree.vtkOBBTree_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOBBTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601739C RID: 95132
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOBBTree_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to print and obtain type-related information.
		/// </summary>
		// Token: 0x0601739D RID: 95133 RVA: 0x00209B90 File Offset: 0x00207D90
		public new static vtkOBBTree SafeDownCast(vtkObjectBase o)
		{
			vtkOBBTree vtkOBBTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOBBTree.vtkOBBTree_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOBBTree = (vtkOBBTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOBBTree.Register(null);
				}
			}
			return vtkOBBTree;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019FF RID: 6655
		public new const string MRFullTypeName = "Kitware.VTK.vtkOBBTree";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A00 RID: 6656
		public new static readonly string MRClassNameKey = "class vtkOBBTree";
	}
}
