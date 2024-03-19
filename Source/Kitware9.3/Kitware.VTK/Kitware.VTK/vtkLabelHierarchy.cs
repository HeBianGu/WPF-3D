using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLabelHierarchy
	/// </summary>
	/// <remarks>
	///    contains an octree of labels
	///
	///
	/// This class represents labels in a hierarchy used to denote rendering priority.
	/// A binary tree of labels is maintained that subdivides the bounds of the
	/// of the label anchors spatially. Which level of the tree a label occupies
	/// determines its priority; those at higher levels of the tree will be
	/// more likely to render than those at lower levels of the tree.
	///
	/// Pass vtkLabelHierarchy objects to a vtkLabelPlacementMapper filter for dynamic,
	/// non-overlapping, per-frame placement of labels.
	///
	/// Note that if we have a d-dimensional binary tree and we want a fixed
	/// number \f$n\f$ of labels in each node (all nodes, not just leaves),
	/// we can compute the depth of tree required assuming a uniform distribution
	/// of points. Given a total of \f$N\f$ points we know that
	/// \f$\frac{N}{|T|} = n\f$, where \f$|T|\f$ is the cardinality of the tree (i.e.,
	/// the number of nodes it contains).
	/// Because we have a uniform distribution, the tree will be uniformly subdivided
	/// and thus \f$|T| = 1 + 2^d + \left(2^d\right)^2 + \cdots + \left(2^d\right)^k\f$,
	/// where \f$d\f$ is the dimensionality of the input points (fixed at 3 for now).
	/// As \f$k\f$ becomes large, \f$|T|\approx 2 \left(2^d\right)^k\f$.
	/// Using this approximation, we can solve for \f$k\f$:
	/// \f[ k = \frac{\log{\frac{N}{2n}}}{\log{2^d}} \f]
	/// Given a set of \f$N\f$ input label anchors, we'll compute \f$k\f$ and then
	/// bin the anchors into tree nodes at level \f$k\f$ of the tree. After this,
	/// all the nodes will be in the leaves of the tree and those leaves will be at
	/// the \f$k\f$-th level; no anchors will be in levels \f$1, 2, \ldots, k-1\f$.
	/// To fix that, we'll choose to move some anchors upwards.
	/// The exact number to move upwards depends on \a TargetLabelCount. We'll
	/// move as many up as required to have \a TargetLabelCount at each node.
	///
	/// You should avoid situations where \a MaximumDepth does not allow for
	/// \a TargetLabelCount or fewer entries at each node. The \a MaximumDepth
	/// is a hard limit while \a TargetLabelCount is a suggested optimum. You will
	/// end up with many more than \a TargetLabelCount entries per node and things
	/// will be sloooow.
	/// </remarks>
	// Token: 0x020000EB RID: 235
	public class vtkLabelHierarchy : vtkPointSet
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060030F8 RID: 12536 RVA: 0x00047EC6 File Offset: 0x000460C6
		static vtkLabelHierarchy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLabelHierarchy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabelHierarchy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060030F9 RID: 12537 RVA: 0x00047EEE File Offset: 0x000460EE
		public vtkLabelHierarchy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060030FA RID: 12538
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelHierarchy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060030FB RID: 12539 RVA: 0x00047EFC File Offset: 0x000460FC
		public new static vtkLabelHierarchy New()
		{
			vtkLabelHierarchy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelHierarchy.vtkLabelHierarchy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabelHierarchy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060030FC RID: 12540 RVA: 0x00047F50 File Offset: 0x00046150
		public vtkLabelHierarchy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLabelHierarchy.vtkLabelHierarchy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060030FD RID: 12541 RVA: 0x00047F94 File Offset: 0x00046194
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060030FE RID: 12542
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchy_ComputeHierarchy_01(HandleRef pThis);

		/// <summary>
		/// Fill the hierarchy with the input labels.
		/// </summary>
		// Token: 0x060030FF RID: 12543 RVA: 0x00047F9F File Offset: 0x0004619F
		public virtual void ComputeHierarchy()
		{
			vtkLabelHierarchy.vtkLabelHierarchy_ComputeHierarchy_01(base.GetCppThis());
		}

		// Token: 0x06003100 RID: 12544
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLabelHierarchy_FindCell_02(HandleRef pThis, IntPtr arg0, HandleRef arg1, long arg2, double arg3, ref int arg4, IntPtr arg5, IntPtr arg6);

		/// <summary>
		/// Inherited members (from vtkDataSet)
		/// </summary>
		// Token: 0x06003101 RID: 12545 RVA: 0x00047FB0 File Offset: 0x000461B0
		public override long FindCell(IntPtr arg0, vtkCell arg1, long arg2, double arg3, ref int arg4, IntPtr arg5, IntPtr arg6)
		{
			return vtkLabelHierarchy.vtkLabelHierarchy_FindCell_02(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), arg2, arg3, ref arg4, arg5, arg6);
		}

		// Token: 0x06003102 RID: 12546
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLabelHierarchy_FindCell_03(HandleRef pThis, IntPtr arg0, HandleRef arg1, HandleRef arg2, long arg3, double arg4, ref int arg5, IntPtr arg6, IntPtr arg7);

		/// <summary>
		/// Inherited members (from vtkDataSet)
		/// </summary>
		// Token: 0x06003103 RID: 12547 RVA: 0x00047FF0 File Offset: 0x000461F0
		public override long FindCell(IntPtr arg0, vtkCell arg1, vtkGenericCell arg2, long arg3, double arg4, ref int arg5, IntPtr arg6, IntPtr arg7)
		{
			return vtkLabelHierarchy.vtkLabelHierarchy_FindCell_03(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), (arg2 == null) ? default(HandleRef) : arg2.GetCppThis(), arg3, arg4, ref arg5, arg6, arg7);
		}

		// Token: 0x06003104 RID: 12548
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchy_GetAnchorFrustumPlanes_04(IntPtr frustumPlanes, HandleRef ren, HandleRef anchorTransform);

		/// <summary>
		/// Compute frustum for quickly excluding labels from rendering
		/// that are outside the visible region.
		/// This is a shared utility function.
		/// </summary>
		// Token: 0x06003105 RID: 12549 RVA: 0x00048044 File Offset: 0x00046244
		public static void GetAnchorFrustumPlanes(IntPtr frustumPlanes, vtkRenderer ren, vtkCoordinate anchorTransform)
		{
			vtkLabelHierarchy.vtkLabelHierarchy_GetAnchorFrustumPlanes_04(frustumPlanes, (ren == null) ? default(HandleRef) : ren.GetCppThis(), (anchorTransform == null) ? default(HandleRef) : anchorTransform.GetCppThis());
		}

		// Token: 0x06003106 RID: 12550
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelHierarchy_GetBoundedSizes_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the array specifying the maximum width and height in world coordinates of each label.
		/// </summary>
		// Token: 0x06003107 RID: 12551 RVA: 0x00048084 File Offset: 0x00046284
		public virtual vtkDataArray GetBoundedSizes()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelHierarchy.vtkLabelHierarchy_GetBoundedSizes_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		// Token: 0x06003108 RID: 12552
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelHierarchy_GetCell_06(HandleRef pThis, long arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Inherited members (from vtkDataSet)
		/// </summary>
		// Token: 0x06003109 RID: 12553 RVA: 0x000480F4 File Offset: 0x000462F4
		public override vtkCell GetCell(long arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelHierarchy.vtkLabelHierarchy_GetCell_06(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600310A RID: 12554
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchy_GetCell_07(HandleRef pThis, long arg0, HandleRef arg1);

		/// <summary>
		/// Inherited members (from vtkDataSet)
		/// </summary>
		// Token: 0x0600310B RID: 12555 RVA: 0x00048164 File Offset: 0x00046364
		public override void GetCell(long arg0, vtkGenericCell arg1)
		{
			vtkLabelHierarchy.vtkLabelHierarchy_GetCell_07(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0600310C RID: 12556
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchy_GetCellPoints_08(HandleRef pThis, long arg0, HandleRef arg1);

		/// <summary>
		/// Inherited members (from vtkDataSet)
		/// </summary>
		// Token: 0x0600310D RID: 12557 RVA: 0x00048194 File Offset: 0x00046394
		public override void GetCellPoints(long arg0, vtkIdList arg1)
		{
			vtkLabelHierarchy.vtkLabelHierarchy_GetCellPoints_08(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0600310E RID: 12558
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelHierarchy_GetCellType_09(HandleRef pThis, long arg0);

		/// <summary>
		/// Inherited members (from vtkDataSet)
		/// </summary>
		// Token: 0x0600310F RID: 12559 RVA: 0x000481C4 File Offset: 0x000463C4
		public override int GetCellType(long arg0)
		{
			return vtkLabelHierarchy.vtkLabelHierarchy_GetCellType_09(base.GetCppThis(), arg0);
		}

		// Token: 0x06003110 RID: 12560
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelHierarchy_GetCenterPts_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Provide access to original coordinates of sets of coincident points
		/// </summary>
		// Token: 0x06003111 RID: 12561 RVA: 0x000481E4 File Offset: 0x000463E4
		public virtual vtkPoints GetCenterPts()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelHierarchy.vtkLabelHierarchy_GetCenterPts_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06003112 RID: 12562
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelHierarchy_GetCoincidentPoints_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Provide access to the set of coincident points that have been
		/// perturbed by the hierarchy in order to render labels for each
		/// without overlap.
		/// </summary>
		// Token: 0x06003113 RID: 12563 RVA: 0x00048254 File Offset: 0x00046454
		public virtual vtkCoincidentPoints GetCoincidentPoints()
		{
			vtkCoincidentPoints vtkCoincidentPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelHierarchy.vtkLabelHierarchy_GetCoincidentPoints_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoincidentPoints = (vtkCoincidentPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoincidentPoints.Register(null);
				}
			}
			return vtkCoincidentPoints;
		}

		// Token: 0x06003114 RID: 12564
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchy_GetDiscreteNodeCoordinatesFromWorldPoint_12(HandleRef pThis, IntPtr ijk, IntPtr pt, int level);

		/// <summary>
		/// Given a depth in the hierarchy (\a level) and a point \a pt in world space, compute \a ijk.
		/// This is used to find other octree nodes at the same \a level that are within the search radius
		/// for candidate labels to be placed. It is called with \a pt set to the camera eye point and
		/// pythagorean quadruples increasingly distant from the origin are added to \a ijk to identify
		/// octree nodes whose labels should be placed.
		/// @param[out] ijk - discrete coordinates of the octree node at \a level containing \a pt.
		/// @param[in]  pt - input world point coordinates
		/// @param[in]  level - input octree level to be considered
		/// </summary>
		// Token: 0x06003115 RID: 12565 RVA: 0x000482C3 File Offset: 0x000464C3
		public void GetDiscreteNodeCoordinatesFromWorldPoint(IntPtr ijk, IntPtr pt, int level)
		{
			vtkLabelHierarchy.vtkLabelHierarchy_GetDiscreteNodeCoordinatesFromWorldPoint_12(base.GetCppThis(), ijk, pt, level);
		}

		// Token: 0x06003116 RID: 12566
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelHierarchy_GetIconIndices_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the array specifying the icon index of each label.
		/// </summary>
		// Token: 0x06003117 RID: 12567 RVA: 0x000482D8 File Offset: 0x000464D8
		public virtual vtkIntArray GetIconIndices()
		{
			vtkIntArray vtkIntArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelHierarchy.vtkLabelHierarchy_GetIconIndices_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIntArray = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIntArray.Register(null);
				}
			}
			return vtkIntArray;
		}

		// Token: 0x06003118 RID: 12568
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelHierarchy_GetLabels_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the array specifying the text of each label.
		/// </summary>
		// Token: 0x06003119 RID: 12569 RVA: 0x00048348 File Offset: 0x00046548
		public virtual vtkAbstractArray GetLabels()
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelHierarchy.vtkLabelHierarchy_GetLabels_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractArray = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractArray.Register(null);
				}
			}
			return vtkAbstractArray;
		}

		// Token: 0x0600311A RID: 12570
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelHierarchy_GetMaxCellSize_15(HandleRef pThis);

		/// <summary>
		/// Inherited members (from vtkDataSet)
		/// </summary>
		// Token: 0x0600311B RID: 12571 RVA: 0x000483B8 File Offset: 0x000465B8
		public override int GetMaxCellSize()
		{
			return vtkLabelHierarchy.vtkLabelHierarchy_GetMaxCellSize_15(base.GetCppThis());
		}

		// Token: 0x0600311C RID: 12572
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelHierarchy_GetMaximumDepth_16(HandleRef pThis);

		/// <summary>
		/// The maximum depth of the octree.
		/// </summary>
		// Token: 0x0600311D RID: 12573 RVA: 0x000483D8 File Offset: 0x000465D8
		public virtual int GetMaximumDepth()
		{
			return vtkLabelHierarchy.vtkLabelHierarchy_GetMaximumDepth_16(base.GetCppThis());
		}

		// Token: 0x0600311E RID: 12574
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLabelHierarchy_GetNumberOfCells_17(HandleRef pThis);

		/// <summary>
		/// Inherited members (from vtkDataSet)
		/// </summary>
		// Token: 0x0600311F RID: 12575 RVA: 0x000483F8 File Offset: 0x000465F8
		public override long GetNumberOfCells()
		{
			return vtkLabelHierarchy.vtkLabelHierarchy_GetNumberOfCells_17(base.GetCppThis());
		}

		// Token: 0x06003120 RID: 12576
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLabelHierarchy_GetNumberOfGenerationsFromBase_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003121 RID: 12577 RVA: 0x00048418 File Offset: 0x00046618
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLabelHierarchy.vtkLabelHierarchy_GetNumberOfGenerationsFromBase_18(base.GetCppThis(), type);
		}

		// Token: 0x06003122 RID: 12578
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLabelHierarchy_GetNumberOfGenerationsFromBaseType_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003123 RID: 12579 RVA: 0x00048438 File Offset: 0x00046638
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLabelHierarchy.vtkLabelHierarchy_GetNumberOfGenerationsFromBaseType_19(type);
		}

		// Token: 0x06003124 RID: 12580
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelHierarchy_GetOrientations_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the array specifying the orientation of each label.
		/// </summary>
		// Token: 0x06003125 RID: 12581 RVA: 0x00048454 File Offset: 0x00046654
		public virtual vtkDataArray GetOrientations()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelHierarchy.vtkLabelHierarchy_GetOrientations_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		// Token: 0x06003126 RID: 12582
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLabelHierarchy_GetPathForNodalCoordinates_21(IntPtr path, IntPtr ijk, int level);

		/// <summary>
		/// Given a \a level of the tree and \a ijk coordinates in a lattice,
		/// compute a \a path down the tree to reach the corresponding lattice node.
		/// If the lattice coordinates are outside the tree, this returns
		/// false. Otherwise it returns true. This does &lt;b&gt;not&lt;/b&gt; guarantee that
		/// the path exists in the hierarchy.
		/// @param[out] path - a vector of \a level integers specifying which child to descend at each
		/// level to reach \a ijk
		/// @param[in] ijk - discrete coordinates of the octree node at \a level
		/// @param[in] level - input octree level to be considered
		/// </summary>
		// Token: 0x06003127 RID: 12583 RVA: 0x000484C4 File Offset: 0x000466C4
		public static bool GetPathForNodalCoordinates(IntPtr path, IntPtr ijk, int level)
		{
			return vtkLabelHierarchy.vtkLabelHierarchy_GetPathForNodalCoordinates_21(path, ijk, level) != 0;
		}

		// Token: 0x06003128 RID: 12584
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchy_GetPointCells_22(HandleRef pThis, long arg0, HandleRef arg1);

		/// <summary>
		/// Inherited members (from vtkDataSet)
		/// </summary>
		// Token: 0x06003129 RID: 12585 RVA: 0x000484E8 File Offset: 0x000466E8
		public override void GetPointCells(long arg0, vtkIdList arg1)
		{
			vtkLabelHierarchy.vtkLabelHierarchy_GetPointCells_22(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0600312A RID: 12586
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelHierarchy_GetPriorities_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the array specifying the importance (priority) of each label.
		/// </summary>
		// Token: 0x0600312B RID: 12587 RVA: 0x00048518 File Offset: 0x00046718
		public virtual vtkDataArray GetPriorities()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelHierarchy.vtkLabelHierarchy_GetPriorities_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		// Token: 0x0600312C RID: 12588
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelHierarchy_GetSizes_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the array specifying the size of each label.
		/// </summary>
		// Token: 0x0600312D RID: 12589 RVA: 0x00048588 File Offset: 0x00046788
		public virtual vtkDataArray GetSizes()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelHierarchy.vtkLabelHierarchy_GetSizes_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		// Token: 0x0600312E RID: 12590
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelHierarchy_GetTargetLabelCount_25(HandleRef pThis);

		/// <summary>
		/// The number of labels that is ideally present at any octree node.
		/// It is best if this is a multiple of \f$2^d\f$.
		/// </summary>
		// Token: 0x0600312F RID: 12591 RVA: 0x000485F8 File Offset: 0x000467F8
		public virtual int GetTargetLabelCount()
		{
			return vtkLabelHierarchy.vtkLabelHierarchy_GetTargetLabelCount_25(base.GetCppThis());
		}

		// Token: 0x06003130 RID: 12592
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelHierarchy_GetTextProperty_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The default text property assigned to labels in this hierarchy.
		/// </summary>
		// Token: 0x06003131 RID: 12593 RVA: 0x00048618 File Offset: 0x00046818
		public virtual vtkTextProperty GetTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelHierarchy.vtkLabelHierarchy_GetTextProperty_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x06003132 RID: 12594
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelHierarchy_IsA_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003133 RID: 12595 RVA: 0x00048688 File Offset: 0x00046888
		public override int IsA(string type)
		{
			return vtkLabelHierarchy.vtkLabelHierarchy_IsA_27(base.GetCppThis(), type);
		}

		// Token: 0x06003134 RID: 12596
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabelHierarchy_IsTypeOf_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003135 RID: 12597 RVA: 0x000486A8 File Offset: 0x000468A8
		public new static int IsTypeOf(string type)
		{
			return vtkLabelHierarchy.vtkLabelHierarchy_IsTypeOf_28(type);
		}

		// Token: 0x06003136 RID: 12598
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelHierarchy_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003137 RID: 12599 RVA: 0x000486C4 File Offset: 0x000468C4
		public new vtkLabelHierarchy NewInstance()
		{
			vtkLabelHierarchy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelHierarchy.vtkLabelHierarchy_NewInstance_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabelHierarchy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003138 RID: 12600
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelHierarchy_NewIterator_31(HandleRef pThis, int type, HandleRef ren, HandleRef cam, IntPtr frustumPlanes, byte positionsAsNormals, IntPtr bucketSize, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns an iterator for this data object.
		/// positionsAsNormals should only be true when labels are on a sphere centered at the origin
		/// (3D world).
		/// @param type - the type should be one of FULL_SORT, QUEUE, DEPTH_FIRST, or FRUSTUM.
		/// @param ren - the current renderer (used for viewport information)
		/// @param cam - the current camera.
		/// @param frustumPlanes - should be the output of the camera's frustum planes.
		/// @param positionsAsNormals - throws out octree nodes on the opposite side of the origin.
		/// @param bucketSize - an array of 2 integers describing the width and height of label placer
		/// buckets.
		/// </summary>
		// Token: 0x06003139 RID: 12601 RVA: 0x00048720 File Offset: 0x00046920
		public vtkLabelHierarchyIterator NewIterator(int type, vtkRenderer ren, vtkCamera cam, IntPtr frustumPlanes, bool positionsAsNormals, IntPtr bucketSize)
		{
			vtkLabelHierarchyIterator vtkLabelHierarchyIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelHierarchy.vtkLabelHierarchy_NewIterator_31(base.GetCppThis(), type, (ren == null) ? default(HandleRef) : ren.GetCppThis(), (cam == null) ? default(HandleRef) : cam.GetCppThis(), frustumPlanes, positionsAsNormals ? (byte)1 : (byte)0, bucketSize, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabelHierarchyIterator = (vtkLabelHierarchyIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabelHierarchyIterator.Register(null);
				}
			}
			return vtkLabelHierarchyIterator;
		}

		// Token: 0x0600313A RID: 12602
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabelHierarchy_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600313B RID: 12603 RVA: 0x000487CC File Offset: 0x000469CC
		public new static vtkLabelHierarchy SafeDownCast(vtkObjectBase o)
		{
			vtkLabelHierarchy vtkLabelHierarchy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabelHierarchy.vtkLabelHierarchy_SafeDownCast_32((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabelHierarchy = (vtkLabelHierarchy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabelHierarchy.Register(null);
				}
			}
			return vtkLabelHierarchy;
		}

		// Token: 0x0600313C RID: 12604
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchy_SetBoundedSizes_33(HandleRef pThis, HandleRef arr);

		/// <summary>
		/// Set/get the array specifying the maximum width and height in world coordinates of each label.
		/// </summary>
		// Token: 0x0600313D RID: 12605 RVA: 0x0004884C File Offset: 0x00046A4C
		public virtual void SetBoundedSizes(vtkDataArray arr)
		{
			vtkLabelHierarchy.vtkLabelHierarchy_SetBoundedSizes_33(base.GetCppThis(), (arr == null) ? default(HandleRef) : arr.GetCppThis());
		}

		// Token: 0x0600313E RID: 12606
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchy_SetIconIndices_34(HandleRef pThis, HandleRef arr);

		/// <summary>
		/// Set/get the array specifying the icon index of each label.
		/// </summary>
		// Token: 0x0600313F RID: 12607 RVA: 0x0004887C File Offset: 0x00046A7C
		public virtual void SetIconIndices(vtkIntArray arr)
		{
			vtkLabelHierarchy.vtkLabelHierarchy_SetIconIndices_34(base.GetCppThis(), (arr == null) ? default(HandleRef) : arr.GetCppThis());
		}

		// Token: 0x06003140 RID: 12608
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchy_SetLabels_35(HandleRef pThis, HandleRef arr);

		/// <summary>
		/// Set/get the array specifying the text of each label.
		/// </summary>
		// Token: 0x06003141 RID: 12609 RVA: 0x000488AC File Offset: 0x00046AAC
		public virtual void SetLabels(vtkAbstractArray arr)
		{
			vtkLabelHierarchy.vtkLabelHierarchy_SetLabels_35(base.GetCppThis(), (arr == null) ? default(HandleRef) : arr.GetCppThis());
		}

		// Token: 0x06003142 RID: 12610
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchy_SetMaximumDepth_36(HandleRef pThis, int _arg);

		/// <summary>
		/// The maximum depth of the octree.
		/// </summary>
		// Token: 0x06003143 RID: 12611 RVA: 0x000488DB File Offset: 0x00046ADB
		public virtual void SetMaximumDepth(int _arg)
		{
			vtkLabelHierarchy.vtkLabelHierarchy_SetMaximumDepth_36(base.GetCppThis(), _arg);
		}

		// Token: 0x06003144 RID: 12612
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchy_SetOrientations_37(HandleRef pThis, HandleRef arr);

		/// <summary>
		/// Set/get the array specifying the orientation of each label.
		/// </summary>
		// Token: 0x06003145 RID: 12613 RVA: 0x000488EC File Offset: 0x00046AEC
		public virtual void SetOrientations(vtkDataArray arr)
		{
			vtkLabelHierarchy.vtkLabelHierarchy_SetOrientations_37(base.GetCppThis(), (arr == null) ? default(HandleRef) : arr.GetCppThis());
		}

		// Token: 0x06003146 RID: 12614
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchy_SetPoints_38(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Override SetPoints so we can reset the hierarchy when the points change.
		/// </summary>
		// Token: 0x06003147 RID: 12615 RVA: 0x0004891C File Offset: 0x00046B1C
		public override void SetPoints(vtkPoints arg0)
		{
			vtkLabelHierarchy.vtkLabelHierarchy_SetPoints_38(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06003148 RID: 12616
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchy_SetPriorities_39(HandleRef pThis, HandleRef arr);

		/// <summary>
		/// Set/get the array specifying the importance (priority) of each label.
		/// </summary>
		// Token: 0x06003149 RID: 12617 RVA: 0x0004894C File Offset: 0x00046B4C
		public virtual void SetPriorities(vtkDataArray arr)
		{
			vtkLabelHierarchy.vtkLabelHierarchy_SetPriorities_39(base.GetCppThis(), (arr == null) ? default(HandleRef) : arr.GetCppThis());
		}

		// Token: 0x0600314A RID: 12618
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchy_SetSizes_40(HandleRef pThis, HandleRef arr);

		/// <summary>
		/// Set/get the array specifying the size of each label.
		/// </summary>
		// Token: 0x0600314B RID: 12619 RVA: 0x0004897C File Offset: 0x00046B7C
		public virtual void SetSizes(vtkDataArray arr)
		{
			vtkLabelHierarchy.vtkLabelHierarchy_SetSizes_40(base.GetCppThis(), (arr == null) ? default(HandleRef) : arr.GetCppThis());
		}

		// Token: 0x0600314C RID: 12620
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchy_SetTargetLabelCount_41(HandleRef pThis, int _arg);

		/// <summary>
		/// The number of labels that is ideally present at any octree node.
		/// It is best if this is a multiple of \f$2^d\f$.
		/// </summary>
		// Token: 0x0600314D RID: 12621 RVA: 0x000489AB File Offset: 0x00046BAB
		public virtual void SetTargetLabelCount(int _arg)
		{
			vtkLabelHierarchy.vtkLabelHierarchy_SetTargetLabelCount_41(base.GetCppThis(), _arg);
		}

		// Token: 0x0600314E RID: 12622
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabelHierarchy_SetTextProperty_42(HandleRef pThis, HandleRef tprop);

		/// <summary>
		/// The default text property assigned to labels in this hierarchy.
		/// </summary>
		// Token: 0x0600314F RID: 12623 RVA: 0x000489BC File Offset: 0x00046BBC
		public virtual void SetTextProperty(vtkTextProperty tprop)
		{
			vtkLabelHierarchy.vtkLabelHierarchy_SetTextProperty_42(base.GetCppThis(), (tprop == null) ? default(HandleRef) : tprop.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005DD RID: 1501
		public new const string MRFullTypeName = "Kitware.VTK.vtkLabelHierarchy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005DE RID: 1502
		public new static readonly string MRClassNameKey = "class vtkLabelHierarchy";

		/// <summary>
		/// Enumeration of iterator types.
		/// </summary>
		// Token: 0x020000EC RID: 236
		public enum IteratorType
		{
			/// <summary>enum member</summary>
			// Token: 0x040005E0 RID: 1504
			DEPTH_FIRST = 2,
			/// <summary>enum member</summary>
			// Token: 0x040005E1 RID: 1505
			FRUSTUM,
			/// <summary>enum member</summary>
			// Token: 0x040005E2 RID: 1506
			FULL_SORT = 0,
			/// <summary>enum member</summary>
			// Token: 0x040005E3 RID: 1507
			QUEUE
		}
	}
}
