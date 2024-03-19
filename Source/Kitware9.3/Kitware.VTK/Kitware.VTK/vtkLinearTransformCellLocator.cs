using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLinearTransformCellLocator
	/// </summary>
	/// <remarks>
	///    Cell locator adaptor to perform cell Location on datasets that are a linear
	/// transformation of the original dataset.
	///
	/// vtkLinearTransformCellLocator is a cell locator adaptor that can accept any cell locator, e.g.
	/// vtkStaticCellLocator, vtkCellLocator, calculate the transformation matrix from the cell
	/// locator adaptor's dataset to the given dataset inside BuildLocator, and then use the cell locator
	/// and transformation to perform cell locator operations. The transformation matrix is computed
	/// using the https://en.wikipedia.org/wiki/Kabsch_algorithm. UseAllPoints allows you to compute the
	/// transformation using all the points of the dataset (use that when you are not sure if it's a
	/// linear transformation) or 100 sample points (or less if the dataset is smaller) that are chosen
	/// every-nth. IsLinearTransformation validates if the dataset is a linear transformation of the cell
	/// locator's dataset based on the used points.
	///
	/// @warning The cell locator adaptor MUST be built before using it.
	///
	/// vtkLinearTransformCellLocator does NOT utilize ANY vtkLocator/vtkAbstractCellLocator parameter:
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAbstractCellLocator vtkCellLocator vtkStaticCellLocator vtkCellTreeLocator vtkModifiedBSPTree
	/// vtkOBBTree
	/// </seealso>
	// Token: 0x020004B5 RID: 1205
	public class vtkLinearTransformCellLocator : vtkAbstractCellLocator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600DD5A RID: 56666 RVA: 0x0013333F File Offset: 0x0013153F
		static vtkLinearTransformCellLocator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLinearTransformCellLocator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLinearTransformCellLocator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600DD5B RID: 56667 RVA: 0x00133367 File Offset: 0x00131567
		public vtkLinearTransformCellLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600DD5C RID: 56668
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearTransformCellLocator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to instantiate, print and obtain type-related information.
		/// </summary>
		// Token: 0x0600DD5D RID: 56669 RVA: 0x00133378 File Offset: 0x00131578
		public new static vtkLinearTransformCellLocator New()
		{
			vtkLinearTransformCellLocator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLinearTransformCellLocator.vtkLinearTransformCellLocator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLinearTransformCellLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods to instantiate, print and obtain type-related information.
		/// </summary>
		// Token: 0x0600DD5E RID: 56670 RVA: 0x001333CC File Offset: 0x001315CC
		public vtkLinearTransformCellLocator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLinearTransformCellLocator.vtkLinearTransformCellLocator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600DD5F RID: 56671 RVA: 0x00133410 File Offset: 0x00131610
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600DD60 RID: 56672
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearTransformCellLocator_BuildLocator_01(HandleRef pThis);

		/// <summary>
		/// Satisfy vtkLocator abstract interface.
		/// </summary>
		// Token: 0x0600DD61 RID: 56673 RVA: 0x0013341B File Offset: 0x0013161B
		public override void BuildLocator()
		{
			vtkLinearTransformCellLocator.vtkLinearTransformCellLocator_BuildLocator_01(base.GetCppThis());
		}

		// Token: 0x0600DD62 RID: 56674
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLinearTransformCellLocator_FindCell_02(HandleRef pThis, IntPtr x, double arg1, HandleRef cell, ref int subId, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Find the cell containing a given point. returns -1 if no cell found
		/// the cell parameters are copied into the supplied variables, a cell must
		/// be provided to store the information.
		///
		/// For other FindCell signatures, see vtkAbstractCellLocator.
		/// </summary>
		// Token: 0x0600DD63 RID: 56675 RVA: 0x0013342C File Offset: 0x0013162C
		public override long FindCell(IntPtr x, double arg1, vtkGenericCell cell, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			return vtkLinearTransformCellLocator.vtkLinearTransformCellLocator_FindCell_02(base.GetCppThis(), x, arg1, (cell == null) ? default(HandleRef) : cell.GetCppThis(), ref subId, pcoords, weights);
		}

		// Token: 0x0600DD64 RID: 56676
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearTransformCellLocator_FindCellsAlongLine_03(HandleRef pThis, IntPtr p1, IntPtr p2, double tolerance, HandleRef cellsIds);

		/// <summary>
		/// Take the passed line segment and intersect it with the data set.
		/// For each intersection with the bounds of a cell, the cellIds
		/// have the relevant information added. If cellIds is nullptr
		/// pointer, then no information is generated for that list.
		/// </summary>
		// Token: 0x0600DD65 RID: 56677 RVA: 0x00133468 File Offset: 0x00131668
		public override void FindCellsAlongLine(IntPtr p1, IntPtr p2, double tolerance, vtkIdList cellsIds)
		{
			vtkLinearTransformCellLocator.vtkLinearTransformCellLocator_FindCellsAlongLine_03(base.GetCppThis(), p1, p2, tolerance, (cellsIds == null) ? default(HandleRef) : cellsIds.GetCppThis());
		}

		// Token: 0x0600DD66 RID: 56678
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearTransformCellLocator_FindCellsAlongPlane_04(HandleRef pThis, IntPtr o, IntPtr n, double tolerance, HandleRef cells);

		/// <summary>
		/// Take the passed line segment and intersect it with the data set.
		/// For each intersection with the bounds of a cell, the cellIds
		/// have the relevant information added sort by t. If cellIds is nullptr
		/// pointer, then no information is generated for that list.
		/// </summary>
		// Token: 0x0600DD67 RID: 56679 RVA: 0x0013349C File Offset: 0x0013169C
		public override void FindCellsAlongPlane(IntPtr o, IntPtr n, double tolerance, vtkIdList cells)
		{
			vtkLinearTransformCellLocator.vtkLinearTransformCellLocator_FindCellsAlongPlane_04(base.GetCppThis(), o, n, tolerance, (cells == null) ? default(HandleRef) : cells.GetCppThis());
		}

		// Token: 0x0600DD68 RID: 56680
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearTransformCellLocator_FindCellsWithinBounds_05(HandleRef pThis, IntPtr bbox, HandleRef cells);

		/// <summary>
		/// Return a list of unique cell ids inside of a given bounding box. The
		/// user must provide the vtkIdList to populate.
		///
		/// This function does NOT work when SupportLinearTransformation is on.
		/// </summary>
		// Token: 0x0600DD69 RID: 56681 RVA: 0x001334D0 File Offset: 0x001316D0
		public override void FindCellsWithinBounds(IntPtr bbox, vtkIdList cells)
		{
			vtkLinearTransformCellLocator.vtkLinearTransformCellLocator_FindCellsWithinBounds_05(base.GetCppThis(), bbox, (cells == null) ? default(HandleRef) : cells.GetCppThis());
		}

		// Token: 0x0600DD6A RID: 56682
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearTransformCellLocator_FindClosestPoint_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2);

		/// <summary>
		/// Return the closest point and the cell which is closest to the point x.
		/// The closest point is somewhere on a cell, it need not be one of the
		/// vertices of the cell.
		///
		/// For other FindClosestPoint signatures, see vtkAbstractCellLocator.
		/// </summary>
		// Token: 0x0600DD6B RID: 56683 RVA: 0x00133500 File Offset: 0x00131700
		public override void FindClosestPoint(IntPtr x, IntPtr closestPoint, vtkGenericCell cell, ref long cellId, ref int subId, ref double dist2)
		{
			vtkLinearTransformCellLocator.vtkLinearTransformCellLocator_FindClosestPoint_06(base.GetCppThis(), x, closestPoint, (cell == null) ? default(HandleRef) : cell.GetCppThis(), ref cellId, ref subId, ref dist2);
		}

		// Token: 0x0600DD6C RID: 56684
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLinearTransformCellLocator_FindClosestPointWithinRadius_07(HandleRef pThis, IntPtr x, double radius, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2, ref int inside);

		/// <summary>
		/// Return the closest point within a specified radius and the cell which is
		/// closest to the point x. The closest point is somewhere on a cell, it
		/// need not be one of the vertices of the cell. This method returns 1 if a
		/// point is found within the specified radius. If there are no cells within
		/// the specified radius, the method returns 0 and the values of
		/// closestPoint, cellId, subId, and dist2 are undefined. If a closest point
		/// is found, inside returns the return value of the EvaluatePosition call to
		/// the closest cell; inside(=1) or outside(=0).
		/// </summary>
		// Token: 0x0600DD6D RID: 56685 RVA: 0x00133538 File Offset: 0x00131738
		public override long FindClosestPointWithinRadius(IntPtr x, double radius, IntPtr closestPoint, vtkGenericCell cell, ref long cellId, ref int subId, ref double dist2, ref int inside)
		{
			return vtkLinearTransformCellLocator.vtkLinearTransformCellLocator_FindClosestPointWithinRadius_07(base.GetCppThis(), x, radius, closestPoint, (cell == null) ? default(HandleRef) : cell.GetCppThis(), ref cellId, ref subId, ref dist2, ref inside);
		}

		// Token: 0x0600DD6E RID: 56686
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearTransformCellLocator_ForceBuildLocator_08(HandleRef pThis);

		/// <summary>
		/// Satisfy vtkLocator abstract interface.
		/// </summary>
		// Token: 0x0600DD6F RID: 56687 RVA: 0x00133579 File Offset: 0x00131779
		public override void ForceBuildLocator()
		{
			vtkLinearTransformCellLocator.vtkLinearTransformCellLocator_ForceBuildLocator_08(base.GetCppThis());
		}

		// Token: 0x0600DD70 RID: 56688
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearTransformCellLocator_FreeSearchStructure_09(HandleRef pThis);

		/// <summary>
		/// Satisfy vtkLocator abstract interface.
		/// </summary>
		// Token: 0x0600DD71 RID: 56689 RVA: 0x00133588 File Offset: 0x00131788
		public override void FreeSearchStructure()
		{
			vtkLinearTransformCellLocator.vtkLinearTransformCellLocator_FreeSearchStructure_09(base.GetCppThis());
		}

		// Token: 0x0600DD72 RID: 56690
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearTransformCellLocator_GenerateRepresentation_10(HandleRef pThis, int level, HandleRef pd);

		/// <summary>
		/// Satisfy vtkLocator abstract interface.
		/// </summary>
		// Token: 0x0600DD73 RID: 56691 RVA: 0x00133598 File Offset: 0x00131798
		public override void GenerateRepresentation(int level, vtkPolyData pd)
		{
			vtkLinearTransformCellLocator.vtkLinearTransformCellLocator_GenerateRepresentation_10(base.GetCppThis(), level, (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0600DD74 RID: 56692
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearTransformCellLocator_GetCellLocator_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the cell locator to be used internally.
		///
		/// The cell locator MUST be built before using it.
		/// </summary>
		// Token: 0x0600DD75 RID: 56693 RVA: 0x001335C8 File Offset: 0x001317C8
		public virtual vtkAbstractCellLocator GetCellLocator()
		{
			vtkAbstractCellLocator vtkAbstractCellLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLinearTransformCellLocator.vtkLinearTransformCellLocator_GetCellLocator_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600DD76 RID: 56694
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLinearTransformCellLocator_GetIsLinearTransformation_12(HandleRef pThis);

		/// <summary>
		/// Get if the set dataset is a linear transformation of cell locator's dataset. The value is
		/// inside BuildLocator().
		/// </summary>
		// Token: 0x0600DD77 RID: 56695 RVA: 0x00133638 File Offset: 0x00131838
		public virtual bool GetIsLinearTransformation()
		{
			return vtkLinearTransformCellLocator.vtkLinearTransformCellLocator_GetIsLinearTransformation_12(base.GetCppThis()) != 0;
		}

		// Token: 0x0600DD78 RID: 56696
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLinearTransformCellLocator_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, print and obtain type-related information.
		/// </summary>
		// Token: 0x0600DD79 RID: 56697 RVA: 0x00133660 File Offset: 0x00131860
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLinearTransformCellLocator.vtkLinearTransformCellLocator_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x0600DD7A RID: 56698
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLinearTransformCellLocator_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, print and obtain type-related information.
		/// </summary>
		// Token: 0x0600DD7B RID: 56699 RVA: 0x00133680 File Offset: 0x00131880
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLinearTransformCellLocator.vtkLinearTransformCellLocator_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x0600DD7C RID: 56700
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLinearTransformCellLocator_GetUseAllPoints_15(HandleRef pThis);

		/// <summary>
		/// UseAllPoints allows to compute the transformation using all the points of the dataset
		/// (use that when you are not if it's a linear transformation) or 100 sample points
		/// (or less if the dataset is smaller) that are chosen every-nth.
		///
		/// Default is off.
		/// </summary>
		// Token: 0x0600DD7D RID: 56701 RVA: 0x0013369C File Offset: 0x0013189C
		public virtual bool GetUseAllPoints()
		{
			return vtkLinearTransformCellLocator.vtkLinearTransformCellLocator_GetUseAllPoints_15(base.GetCppThis()) != 0;
		}

		// Token: 0x0600DD7E RID: 56702
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLinearTransformCellLocator_InsideCellBounds_16(HandleRef pThis, IntPtr x, long cellId);

		/// <summary>
		/// Quickly test if a point is inside the bounds of a particular cell.
		/// This function should be used ONLY after the locator is built.
		/// </summary>
		// Token: 0x0600DD7F RID: 56703 RVA: 0x001336C4 File Offset: 0x001318C4
		public override bool InsideCellBounds(IntPtr x, long cellId)
		{
			return vtkLinearTransformCellLocator.vtkLinearTransformCellLocator_InsideCellBounds_16(base.GetCppThis(), x, cellId) != 0;
		}

		// Token: 0x0600DD80 RID: 56704
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLinearTransformCellLocator_IntersectWithLine_17(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, HandleRef cell);

		/// <summary>
		/// Return intersection point (if any) AND the cell which was intersected by
		/// the finite line. The cell is returned as a cell id and as a generic cell.
		///
		/// For other IntersectWithLine signatures, see vtkAbstractCellLocator.
		/// </summary>
		// Token: 0x0600DD81 RID: 56705 RVA: 0x001336EC File Offset: 0x001318EC
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, vtkGenericCell cell)
		{
			return vtkLinearTransformCellLocator.vtkLinearTransformCellLocator_IntersectWithLine_17(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId, ref cellId, (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x0600DD82 RID: 56706
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLinearTransformCellLocator_IntersectWithLine_18(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, HandleRef points, HandleRef cellIds, HandleRef cell);

		/// <summary>
		/// Take the passed line segment and intersect it with the data set.
		/// The return value of the function is 0 if no intersections were found.
		/// For each intersection with the bounds of a cell or with a cell (if a cell is provided),
		/// the points and cellIds have the relevant information added sorted by t.
		/// If points or cellIds are nullptr pointers, then no information is generated for that list.
		///
		/// For other IntersectWithLine signatures, see vtkAbstractCellLocator.
		/// </summary>
		// Token: 0x0600DD83 RID: 56707 RVA: 0x00133730 File Offset: 0x00131930
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, vtkPoints points, vtkIdList cellIds, vtkGenericCell cell)
		{
			return vtkLinearTransformCellLocator.vtkLinearTransformCellLocator_IntersectWithLine_18(base.GetCppThis(), p1, p2, tol, (points == null) ? default(HandleRef) : points.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x0600DD84 RID: 56708
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLinearTransformCellLocator_IsA_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, print and obtain type-related information.
		/// </summary>
		// Token: 0x0600DD85 RID: 56709 RVA: 0x00133798 File Offset: 0x00131998
		public override int IsA(string type)
		{
			return vtkLinearTransformCellLocator.vtkLinearTransformCellLocator_IsA_19(base.GetCppThis(), type);
		}

		// Token: 0x0600DD86 RID: 56710
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLinearTransformCellLocator_IsTypeOf_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, print and obtain type-related information.
		/// </summary>
		// Token: 0x0600DD87 RID: 56711 RVA: 0x001337B8 File Offset: 0x001319B8
		public new static int IsTypeOf(string type)
		{
			return vtkLinearTransformCellLocator.vtkLinearTransformCellLocator_IsTypeOf_20(type);
		}

		// Token: 0x0600DD88 RID: 56712
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearTransformCellLocator_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to instantiate, print and obtain type-related information.
		/// </summary>
		// Token: 0x0600DD89 RID: 56713 RVA: 0x001337D4 File Offset: 0x001319D4
		public new vtkLinearTransformCellLocator NewInstance()
		{
			vtkLinearTransformCellLocator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLinearTransformCellLocator.vtkLinearTransformCellLocator_NewInstance_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLinearTransformCellLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600DD8A RID: 56714
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearTransformCellLocator_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to instantiate, print and obtain type-related information.
		/// </summary>
		// Token: 0x0600DD8B RID: 56715 RVA: 0x00133830 File Offset: 0x00131A30
		public new static vtkLinearTransformCellLocator SafeDownCast(vtkObjectBase o)
		{
			vtkLinearTransformCellLocator vtkLinearTransformCellLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLinearTransformCellLocator.vtkLinearTransformCellLocator_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLinearTransformCellLocator = (vtkLinearTransformCellLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLinearTransformCellLocator.Register(null);
				}
			}
			return vtkLinearTransformCellLocator;
		}

		// Token: 0x0600DD8C RID: 56716
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearTransformCellLocator_SetCellLocator_24(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Set/Get the cell locator to be used internally.
		///
		/// The cell locator MUST be built before using it.
		/// </summary>
		// Token: 0x0600DD8D RID: 56717 RVA: 0x001338B0 File Offset: 0x00131AB0
		public virtual void SetCellLocator(vtkAbstractCellLocator locator)
		{
			vtkLinearTransformCellLocator.vtkLinearTransformCellLocator_SetCellLocator_24(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0600DD8E RID: 56718
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearTransformCellLocator_SetUseAllPoints_25(HandleRef pThis, byte _arg);

		/// <summary>
		/// UseAllPoints allows to compute the transformation using all the points of the dataset
		/// (use that when you are not if it's a linear transformation) or 100 sample points
		/// (or less if the dataset is smaller) that are chosen every-nth.
		///
		/// Default is off.
		/// </summary>
		// Token: 0x0600DD8F RID: 56719 RVA: 0x001338DF File Offset: 0x00131ADF
		public virtual void SetUseAllPoints(bool _arg)
		{
			vtkLinearTransformCellLocator.vtkLinearTransformCellLocator_SetUseAllPoints_25(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600DD90 RID: 56720
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearTransformCellLocator_ShallowCopy_26(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Shallow copy of a vtkLinearTransformCellLocator.
		/// </summary>
		// Token: 0x0600DD91 RID: 56721 RVA: 0x001338F8 File Offset: 0x00131AF8
		public override void ShallowCopy(vtkAbstractCellLocator locator)
		{
			vtkLinearTransformCellLocator.vtkLinearTransformCellLocator_ShallowCopy_26(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0600DD92 RID: 56722
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearTransformCellLocator_UseAllPointsOff_27(HandleRef pThis);

		/// <summary>
		/// UseAllPoints allows to compute the transformation using all the points of the dataset
		/// (use that when you are not if it's a linear transformation) or 100 sample points
		/// (or less if the dataset is smaller) that are chosen every-nth.
		///
		/// Default is off.
		/// </summary>
		// Token: 0x0600DD93 RID: 56723 RVA: 0x00133927 File Offset: 0x00131B27
		public virtual void UseAllPointsOff()
		{
			vtkLinearTransformCellLocator.vtkLinearTransformCellLocator_UseAllPointsOff_27(base.GetCppThis());
		}

		// Token: 0x0600DD94 RID: 56724
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLinearTransformCellLocator_UseAllPointsOn_28(HandleRef pThis);

		/// <summary>
		/// UseAllPoints allows to compute the transformation using all the points of the dataset
		/// (use that when you are not if it's a linear transformation) or 100 sample points
		/// (or less if the dataset is smaller) that are chosen every-nth.
		///
		/// Default is off.
		/// </summary>
		// Token: 0x0600DD95 RID: 56725 RVA: 0x00133936 File Offset: 0x00131B36
		public virtual void UseAllPointsOn()
		{
			vtkLinearTransformCellLocator.vtkLinearTransformCellLocator_UseAllPointsOn_28(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001029 RID: 4137
		public new const string MRFullTypeName = "Kitware.VTK.vtkLinearTransformCellLocator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400102A RID: 4138
		public new static readonly string MRClassNameKey = "class vtkLinearTransformCellLocator";
	}
}
