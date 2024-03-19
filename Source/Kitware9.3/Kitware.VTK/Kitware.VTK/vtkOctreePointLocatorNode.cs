using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOctreePointLocatorNode
	/// </summary>
	/// <remarks>
	///    Octree node that has 8 children each of equal size
	///
	///
	/// This class represents a single spatial region in a 3D axis octant
	/// partitioning.  It is intended to work efficiently with the
	/// vtkOctreePointLocator and is not meant for general use.  It is assumed
	/// the region bounds some set of points.  The ordering of the children is
	/// (-x,-y,-z),(+x,-y,-z),(-x,+y,-z),(+x,+y,-z),(-x,-y,+z),(+x,-y,+z),
	/// (-x,+y,+z),(+x,+y,+z).  The portion of the domain assigned to an
	/// octant is Min &lt; x &lt;= Max.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkOctreePointLocator
	/// </seealso>
	// Token: 0x02000A8B RID: 2699
	public class vtkOctreePointLocatorNode : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C460 RID: 115808 RVA: 0x0027B597 File Offset: 0x00279797
		static vtkOctreePointLocatorNode()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOctreePointLocatorNode.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOctreePointLocatorNode"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C461 RID: 115809 RVA: 0x0027B5BF File Offset: 0x002797BF
		public vtkOctreePointLocatorNode(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C462 RID: 115810
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOctreePointLocatorNode_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C463 RID: 115811 RVA: 0x0027B5D0 File Offset: 0x002797D0
		public new static vtkOctreePointLocatorNode New()
		{
			vtkOctreePointLocatorNode result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOctreePointLocatorNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C464 RID: 115812 RVA: 0x0027B624 File Offset: 0x00279824
		public vtkOctreePointLocatorNode() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C465 RID: 115813 RVA: 0x0027B668 File Offset: 0x00279868
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C466 RID: 115814
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreePointLocatorNode_ComputeOctreeNodeInformation_01(HandleRef pThis, HandleRef Parent, ref int NextLeafId, ref int NextMinId, IntPtr coordinates);

		/// <summary>
		/// Recursive function to compute ID, MinVal, MaxVal, and MinID.
		/// Parent is used for MinVal and MaxVal in the case that no
		/// points are in the leaf node.
		/// </summary>
		// Token: 0x0601C467 RID: 115815 RVA: 0x0027B674 File Offset: 0x00279874
		public void ComputeOctreeNodeInformation(vtkOctreePointLocatorNode Parent, ref int NextLeafId, ref int NextMinId, IntPtr coordinates)
		{
			vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_ComputeOctreeNodeInformation_01(base.GetCppThis(), (Parent == null) ? default(HandleRef) : Parent.GetCppThis(), ref NextLeafId, ref NextMinId, coordinates);
		}

		// Token: 0x0601C468 RID: 115816
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOctreePointLocatorNode_ContainsPoint_02(HandleRef pThis, double x, double y, double z, int useDataBounds);

		/// <summary>
		/// Return 1 if this spatial region entirely contains the given point.
		/// Use the possibly smaller bounds of the points within the region
		/// if useDataBounds is non-zero.
		/// </summary>
		// Token: 0x0601C469 RID: 115817 RVA: 0x0027B6A8 File Offset: 0x002798A8
		public int ContainsPoint(double x, double y, double z, int useDataBounds)
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_ContainsPoint_02(base.GetCppThis(), x, y, z, useDataBounds);
		}

		// Token: 0x0601C46A RID: 115818
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreePointLocatorNode_CreateChildNodes_03(HandleRef pThis);

		/// <summary>
		/// Add the 8 children.
		/// </summary>
		// Token: 0x0601C46B RID: 115819 RVA: 0x0027B6CC File Offset: 0x002798CC
		public void CreateChildNodes()
		{
			vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_CreateChildNodes_03(base.GetCppThis());
		}

		// Token: 0x0601C46C RID: 115820
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreePointLocatorNode_DeleteChildNodes_04(HandleRef pThis);

		/// <summary>
		/// Delete the 8 children.
		/// </summary>
		// Token: 0x0601C46D RID: 115821 RVA: 0x0027B6DB File Offset: 0x002798DB
		public void DeleteChildNodes()
		{
			vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_DeleteChildNodes_04(base.GetCppThis());
		}

		// Token: 0x0601C46E RID: 115822
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreePointLocatorNode_GetBounds_05(HandleRef pThis, IntPtr b);

		/// <summary>
		/// Set/Get the bounds of the spatial region represented by this node.
		/// Caller allocates storage for 6-vector in GetBounds.
		/// </summary>
		// Token: 0x0601C46F RID: 115823 RVA: 0x0027B6EA File Offset: 0x002798EA
		public void GetBounds(IntPtr b)
		{
			vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_GetBounds_05(base.GetCppThis(), b);
		}

		// Token: 0x0601C470 RID: 115824
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOctreePointLocatorNode_GetChild_06(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a pointer to the ith child of this node.
		/// </summary>
		// Token: 0x0601C471 RID: 115825 RVA: 0x0027B6FC File Offset: 0x002798FC
		public vtkOctreePointLocatorNode GetChild(int i)
		{
			vtkOctreePointLocatorNode vtkOctreePointLocatorNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_GetChild_06(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOctreePointLocatorNode = (vtkOctreePointLocatorNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOctreePointLocatorNode.Register(null);
				}
			}
			return vtkOctreePointLocatorNode;
		}

		// Token: 0x0601C472 RID: 115826
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreePointLocatorNode_GetDataBounds_07(HandleRef pThis, IntPtr b);

		/// <summary>
		/// Set/Get the bounds of the points contained in this spatial region.
		/// This may be smaller than the bounds of the region itself.
		/// Caller allocates storage for 6-vector in GetDataBounds.
		/// </summary>
		// Token: 0x0601C473 RID: 115827 RVA: 0x0027B76C File Offset: 0x0027996C
		public void GetDataBounds(IntPtr b)
		{
			vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_GetDataBounds_07(base.GetCppThis(), b);
		}

		// Token: 0x0601C474 RID: 115828
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOctreePointLocatorNode_GetDistance2ToBoundary_08(HandleRef pThis, double x, double y, double z, HandleRef top, int useDataBounds);

		/// <summary>
		/// Calculate the distance squared from any point to the boundary of this
		/// region.  Use the boundary of the points within the region if useDataBounds
		/// is non-zero.
		/// </summary>
		// Token: 0x0601C475 RID: 115829 RVA: 0x0027B77C File Offset: 0x0027997C
		public double GetDistance2ToBoundary(double x, double y, double z, vtkOctreePointLocatorNode top, int useDataBounds)
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_GetDistance2ToBoundary_08(base.GetCppThis(), x, y, z, (top == null) ? default(HandleRef) : top.GetCppThis(), useDataBounds);
		}

		// Token: 0x0601C476 RID: 115830
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOctreePointLocatorNode_GetDistance2ToBoundary_09(HandleRef pThis, double x, double y, double z, IntPtr boundaryPt, HandleRef top, int useDataBounds);

		/// <summary>
		/// Calculate the distance squared from any point to the boundary of this
		/// region.  Use the boundary of the points within the region if useDataBounds
		/// is non-zero.  Set boundaryPt to the point on the boundary.
		/// </summary>
		// Token: 0x0601C477 RID: 115831 RVA: 0x0027B7B8 File Offset: 0x002799B8
		public double GetDistance2ToBoundary(double x, double y, double z, IntPtr boundaryPt, vtkOctreePointLocatorNode top, int useDataBounds)
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_GetDistance2ToBoundary_09(base.GetCppThis(), x, y, z, boundaryPt, (top == null) ? default(HandleRef) : top.GetCppThis(), useDataBounds);
		}

		// Token: 0x0601C478 RID: 115832
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkOctreePointLocatorNode_GetDistance2ToInnerBoundary_10(HandleRef pThis, double x, double y, double z, HandleRef top);

		/// <summary>
		/// Calculate the distance from the specified point (which is required to
		/// be inside this spatial region) to an interior boundary.  An interior
		/// boundary is one that is not also an boundary of the entire space
		/// partitioned by the tree of vtkOctreePointLocatorNode's.
		/// </summary>
		// Token: 0x0601C479 RID: 115833 RVA: 0x0027B7F8 File Offset: 0x002799F8
		public double GetDistance2ToInnerBoundary(double x, double y, double z, vtkOctreePointLocatorNode top)
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_GetDistance2ToInnerBoundary_10(base.GetCppThis(), x, y, z, (top == null) ? default(HandleRef) : top.GetCppThis());
		}

		// Token: 0x0601C47A RID: 115834
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOctreePointLocatorNode_GetID_11(HandleRef pThis);

		/// <summary>
		/// Get the ID associated with the region described by this node.  If
		/// this is not a leaf node, this value should be -1.
		/// </summary>
		// Token: 0x0601C47B RID: 115835 RVA: 0x0027B834 File Offset: 0x00279A34
		public virtual int GetID()
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_GetID_11(base.GetCppThis());
		}

		// Token: 0x0601C47C RID: 115836
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOctreePointLocatorNode_GetMaxBounds_12(HandleRef pThis);

		/// <summary>
		/// Get a pointer to the 3 bound minima (xmin, ymin and zmin) or the
		/// 3 bound maxima (xmax, ymax, zmax).  Don't free this pointer.
		/// </summary>
		// Token: 0x0601C47D RID: 115837 RVA: 0x0027B854 File Offset: 0x00279A54
		public virtual IntPtr GetMaxBounds()
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_GetMaxBounds_12(base.GetCppThis());
		}

		// Token: 0x0601C47E RID: 115838
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOctreePointLocatorNode_GetMaxDataBounds_13(HandleRef pThis);

		/// <summary>
		/// Get a pointer to the 3 data bound minima (xmin, ymin and zmin) or the
		/// 3 data bound maxima (xmax, ymax, zmax).  Don't free this pointer.
		/// </summary>
		// Token: 0x0601C47F RID: 115839 RVA: 0x0027B874 File Offset: 0x00279A74
		public virtual IntPtr GetMaxDataBounds()
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_GetMaxDataBounds_13(base.GetCppThis());
		}

		// Token: 0x0601C480 RID: 115840
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOctreePointLocatorNode_GetMinBounds_14(HandleRef pThis);

		/// <summary>
		/// Get a pointer to the 3 bound minima (xmin, ymin and zmin) or the
		/// 3 bound maxima (xmax, ymax, zmax).  Don't free this pointer.
		/// </summary>
		// Token: 0x0601C481 RID: 115841 RVA: 0x0027B894 File Offset: 0x00279A94
		public virtual IntPtr GetMinBounds()
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_GetMinBounds_14(base.GetCppThis());
		}

		// Token: 0x0601C482 RID: 115842
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOctreePointLocatorNode_GetMinDataBounds_15(HandleRef pThis);

		/// <summary>
		/// Get a pointer to the 3 data bound minima (xmin, ymin and zmin) or the
		/// 3 data bound maxima (xmax, ymax, zmax).  Don't free this pointer.
		/// </summary>
		// Token: 0x0601C483 RID: 115843 RVA: 0x0027B8B4 File Offset: 0x00279AB4
		public virtual IntPtr GetMinDataBounds()
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_GetMinDataBounds_15(base.GetCppThis());
		}

		// Token: 0x0601C484 RID: 115844
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOctreePointLocatorNode_GetMinID_16(HandleRef pThis);

		/// <summary>
		/// If this node is not a leaf node, there are leaf nodes below it whose
		/// regions represent a partitioning of this region.  The IDs of these
		/// leaf nodes form a contiguous set.  Get the first of the first point's
		/// ID that is contained in this node.
		/// </summary>
		// Token: 0x0601C485 RID: 115845 RVA: 0x0027B8D4 File Offset: 0x00279AD4
		public virtual int GetMinID()
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_GetMinID_16(base.GetCppThis());
		}

		// Token: 0x0601C486 RID: 115846
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOctreePointLocatorNode_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C487 RID: 115847 RVA: 0x0027B8F4 File Offset: 0x00279AF4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x0601C488 RID: 115848
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOctreePointLocatorNode_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C489 RID: 115849 RVA: 0x0027B914 File Offset: 0x00279B14
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x0601C48A RID: 115850
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOctreePointLocatorNode_GetNumberOfPoints_19(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of points contained in this region.
		/// </summary>
		// Token: 0x0601C48B RID: 115851 RVA: 0x0027B930 File Offset: 0x00279B30
		public virtual int GetNumberOfPoints()
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_GetNumberOfPoints_19(base.GetCppThis());
		}

		// Token: 0x0601C48C RID: 115852
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOctreePointLocatorNode_GetSubOctantIndex_20(HandleRef pThis, IntPtr point, int CheckContainment);

		/// <summary>
		/// Return the id of the suboctant that a given point is in.
		/// If CheckContainment is non-zero then it checks whether
		/// the point is in the actual bounding box of the suboctant,
		/// otherwise it only checks which octant the point is in
		/// that is created from the axis-aligned partitioning of
		/// the domain at this octant's center.
		/// </summary>
		// Token: 0x0601C48D RID: 115853 RVA: 0x0027B950 File Offset: 0x00279B50
		public int GetSubOctantIndex(IntPtr point, int CheckContainment)
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_GetSubOctantIndex_20(base.GetCppThis(), point, CheckContainment);
		}

		// Token: 0x0601C48E RID: 115854
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOctreePointLocatorNode_IntersectsRegion_21(HandleRef pThis, HandleRef pi, int useDataBounds);

		/// <summary>
		/// A vtkPlanesIntersection object represents a convex 3D region bounded
		/// by planes, and it is capable of computing intersections of
		/// boxes with itself.  Return 1 if this spatial region intersects
		/// the spatial region described by the vtkPlanesIntersection object.
		/// Use the possibly smaller bounds of the points within the region
		/// if useDataBounds is non-zero.
		/// </summary>
		// Token: 0x0601C48F RID: 115855 RVA: 0x0027B974 File Offset: 0x00279B74
		public int IntersectsRegion(vtkPlanesIntersection pi, int useDataBounds)
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_IntersectsRegion_21(base.GetCppThis(), (pi == null) ? default(HandleRef) : pi.GetCppThis(), useDataBounds);
		}

		// Token: 0x0601C490 RID: 115856
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOctreePointLocatorNode_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C491 RID: 115857 RVA: 0x0027B9AC File Offset: 0x00279BAC
		public override int IsA(string type)
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x0601C492 RID: 115858
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOctreePointLocatorNode_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C493 RID: 115859 RVA: 0x0027B9CC File Offset: 0x00279BCC
		public new static int IsTypeOf(string type)
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_IsTypeOf_23(type);
		}

		// Token: 0x0601C494 RID: 115860
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOctreePointLocatorNode_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C495 RID: 115861 RVA: 0x0027B9E8 File Offset: 0x00279BE8
		public new vtkOctreePointLocatorNode NewInstance()
		{
			vtkOctreePointLocatorNode result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOctreePointLocatorNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C496 RID: 115862
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOctreePointLocatorNode_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C497 RID: 115863 RVA: 0x0027BA44 File Offset: 0x00279C44
		public new static vtkOctreePointLocatorNode SafeDownCast(vtkObjectBase o)
		{
			vtkOctreePointLocatorNode vtkOctreePointLocatorNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOctreePointLocatorNode = (vtkOctreePointLocatorNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOctreePointLocatorNode.Register(null);
				}
			}
			return vtkOctreePointLocatorNode;
		}

		// Token: 0x0601C498 RID: 115864
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreePointLocatorNode_SetBounds_27(HandleRef pThis, double xMin, double xMax, double yMin, double yMax, double zMin, double zMax);

		/// <summary>
		/// Set/Get the bounds of the spatial region represented by this node.
		/// Caller allocates storage for 6-vector in GetBounds.
		/// </summary>
		// Token: 0x0601C499 RID: 115865 RVA: 0x0027BAC3 File Offset: 0x00279CC3
		public void SetBounds(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
		{
			vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_SetBounds_27(base.GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
		}

		// Token: 0x0601C49A RID: 115866
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreePointLocatorNode_SetBounds_28(HandleRef pThis, IntPtr b);

		/// <summary>
		/// Set/Get the bounds of the spatial region represented by this node.
		/// Caller allocates storage for 6-vector in GetBounds.
		/// </summary>
		// Token: 0x0601C49B RID: 115867 RVA: 0x0027BADB File Offset: 0x00279CDB
		public void SetBounds(IntPtr b)
		{
			vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_SetBounds_28(base.GetCppThis(), b);
		}

		// Token: 0x0601C49C RID: 115868
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreePointLocatorNode_SetDataBounds_29(HandleRef pThis, double xMin, double xMax, double yMin, double yMax, double zMin, double zMax);

		/// <summary>
		/// Set/Get the bounds of the points contained in this spatial region.
		/// This may be smaller than the bounds of the region itself.
		/// Caller allocates storage for 6-vector in GetDataBounds.
		/// </summary>
		// Token: 0x0601C49D RID: 115869 RVA: 0x0027BAEB File Offset: 0x00279CEB
		public void SetDataBounds(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
		{
			vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_SetDataBounds_29(base.GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
		}

		// Token: 0x0601C49E RID: 115870
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreePointLocatorNode_SetMaxBounds_30(HandleRef pThis, IntPtr maxBounds);

		/// <summary>
		/// Set the xmax, ymax and zmax value of the bounds of this region
		/// </summary>
		// Token: 0x0601C49F RID: 115871 RVA: 0x0027BB03 File Offset: 0x00279D03
		public void SetMaxBounds(IntPtr maxBounds)
		{
			vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_SetMaxBounds_30(base.GetCppThis(), maxBounds);
		}

		// Token: 0x0601C4A0 RID: 115872
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreePointLocatorNode_SetMaxDataBounds_31(HandleRef pThis, IntPtr maxDataBounds);

		/// <summary>
		/// Set the xmax, ymax and zmax value of the bounds of this
		/// data within this region.
		/// </summary>
		// Token: 0x0601C4A1 RID: 115873 RVA: 0x0027BB13 File Offset: 0x00279D13
		public void SetMaxDataBounds(IntPtr maxDataBounds)
		{
			vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_SetMaxDataBounds_31(base.GetCppThis(), maxDataBounds);
		}

		// Token: 0x0601C4A2 RID: 115874
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreePointLocatorNode_SetMinBounds_32(HandleRef pThis, IntPtr minBounds);

		/// <summary>
		/// Set the xmin, ymin and zmin value of the bounds of this region
		/// </summary>
		// Token: 0x0601C4A3 RID: 115875 RVA: 0x0027BB23 File Offset: 0x00279D23
		public void SetMinBounds(IntPtr minBounds)
		{
			vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_SetMinBounds_32(base.GetCppThis(), minBounds);
		}

		// Token: 0x0601C4A4 RID: 115876
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreePointLocatorNode_SetMinDataBounds_33(HandleRef pThis, IntPtr minDataBounds);

		/// <summary>
		/// Set the xmin, ymin and zmin value of the bounds of this
		/// data within this region.
		/// </summary>
		// Token: 0x0601C4A5 RID: 115877 RVA: 0x0027BB33 File Offset: 0x00279D33
		public void SetMinDataBounds(IntPtr minDataBounds)
		{
			vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_SetMinDataBounds_33(base.GetCppThis(), minDataBounds);
		}

		// Token: 0x0601C4A6 RID: 115878
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreePointLocatorNode_SetNumberOfPoints_34(HandleRef pThis, int numberOfPoints);

		/// <summary>
		/// Set/Get the number of points contained in this region.
		/// </summary>
		// Token: 0x0601C4A7 RID: 115879 RVA: 0x0027BB43 File Offset: 0x00279D43
		public void SetNumberOfPoints(int numberOfPoints)
		{
			vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_SetNumberOfPoints_34(base.GetCppThis(), numberOfPoints);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E12 RID: 7698
		public new const string MRFullTypeName = "Kitware.VTK.vtkOctreePointLocatorNode";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E13 RID: 7699
		public new static readonly string MRClassNameKey = "class vtkOctreePointLocatorNode";
	}
}
