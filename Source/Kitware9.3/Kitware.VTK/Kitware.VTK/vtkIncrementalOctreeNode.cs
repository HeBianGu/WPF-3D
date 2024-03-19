using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkIncrementalOctreeNode
	/// </summary>
	/// <remarks>
	///    Octree node constituting incremental
	///  octree (in support of both point location and point insertion)
	///
	///
	///  Octree nodes serve as spatial sub-division primitives to build the search
	///  structure of an incremental octree in a recursive top-down manner. The
	///  hierarchy takes the form of a tree-like representation by which a parent
	///  node contains eight mutually non-overlapping child nodes. Each child is
	///  assigned with an axis-aligned rectangular volume (Spatial Bounding Box)
	///  and the eight children together cover exactly the same region as governed
	///  by their parent. The eight child nodes / octants are ordered as
	///
	///  { (xBBoxMin, xBBoxMid] &amp; (yBBoxMin, yBBoxMid] &amp; (zBBoxMin, zBBoxMid] },
	///  { (xBBoxMid, xBBoxMax] &amp; (yBBoxMin, yBBoxMid] &amp; (zBBoxMin, zBBoxMid] },
	///  { (xBBoxMin, xBBoxMid] &amp; (yBBoxMid, yBBoxMax] &amp; (zBBoxMin, zBBoxMid] },
	///  { (xBBoxMid, xBBoxMax] &amp; (yBBoxMid, yBBoxMax] &amp; (zBBoxMin, zBBoxMid] },
	///  { (xBBoxMin, xBBoxMid] &amp; (yBBoxMin, yBBoxMid] &amp; (zBBoxMid, zBBoxMax] },
	///  { (xBBoxMid, xBBoxMax] &amp; (yBBoxMin, yBBoxMid] &amp; (zBBoxMid, zBBoxMax] },
	///  { (xBBoxMin, xBBoxMid] &amp; (yBBoxMid, yBBoxMax] &amp; (zBBoxMid, zBBoxMax] },
	///  { (xBBoxMid, xBBoxMax] &amp; (yBBoxMid, yBBoxMax] &amp; (zBBoxMid, zBBoxMax] },
	///
	///  where { xrange &amp; yRange &amp; zRange } defines the region of each 3D octant.
	///  In addition, the points falling within and registered, by means of point
	///  indices, in the parent node are distributed to the child nodes for delegated
	///  maintenance. In fact, only leaf nodes, i.e., those without any descendants,
	///  actually store point indices while each node, regardless of a leaf or non-
	///  leaf node, keeps a dynamically updated Data Bounding Box of the inhabitant
	///  points, if any. Given a maximum number of points per leaf node, an octree
	///  is initialized with an empty leaf node that is then recursively sub-divided,
	///  but only on demand as points are incrementally inserted, to construct a
	///  populated tree.
	///
	///  Please note that this octree node class is able to handle a large number
	///  of EXACTLY duplicate points that is greater than the specified maximum
	///  number of points per leaf node. In other words, as an exception, a leaf
	///  node may maintain an arbitrary number of exactly duplicate points to deal
	///  with possible extreme cases.
	///
	/// </remarks>
	/// <seealso>
	///
	///  vtkIncrementalOctreePointLocator
	/// </seealso>
	// Token: 0x02000A6F RID: 2671
	public class vtkIncrementalOctreeNode : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601BF51 RID: 114513 RVA: 0x00272B83 File Offset: 0x00270D83
		static vtkIncrementalOctreeNode()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkIncrementalOctreeNode.MRClassNameKey, Type.GetType("Kitware.VTK.vtkIncrementalOctreeNode"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601BF52 RID: 114514 RVA: 0x00272BAB File Offset: 0x00270DAB
		public vtkIncrementalOctreeNode(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601BF53 RID: 114515
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIncrementalOctreeNode_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BF54 RID: 114516 RVA: 0x00272BBC File Offset: 0x00270DBC
		public new static vtkIncrementalOctreeNode New()
		{
			vtkIncrementalOctreeNode result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIncrementalOctreeNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BF55 RID: 114517 RVA: 0x00272C10 File Offset: 0x00270E10
		public vtkIncrementalOctreeNode() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601BF56 RID: 114518 RVA: 0x00272C54 File Offset: 0x00270E54
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601BF57 RID: 114519
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIncrementalOctreeNode_ContainsPoint_01(HandleRef pThis, IntPtr pnt);

		/// <summary>
		/// A point is in a node if and only if MinBounds[i] &lt; p[i] &lt;= MaxBounds[i],
		/// which allows a node to be divided into eight non-overlapping children.
		/// </summary>
		// Token: 0x0601BF58 RID: 114520 RVA: 0x00272C60 File Offset: 0x00270E60
		public int ContainsPoint(IntPtr pnt)
		{
			return vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_ContainsPoint_01(base.GetCppThis(), pnt);
		}

		// Token: 0x0601BF59 RID: 114521
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIncrementalOctreeNode_ContainsPointByData_02(HandleRef pThis, IntPtr pnt);

		/// <summary>
		/// A point is in a node, in terms of data, if and only if MinDataBounds[i]
		/// &lt;= p[i] &lt;= MaxDataBounds[i].
		/// </summary>
		// Token: 0x0601BF5A RID: 114522 RVA: 0x00272C80 File Offset: 0x00270E80
		public int ContainsPointByData(IntPtr pnt)
		{
			return vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_ContainsPointByData_02(base.GetCppThis(), pnt);
		}

		// Token: 0x0601BF5B RID: 114523
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalOctreeNode_DeleteChildNodes_03(HandleRef pThis);

		/// <summary>
		/// Delete the eight child nodes.
		/// </summary>
		// Token: 0x0601BF5C RID: 114524 RVA: 0x00272CA0 File Offset: 0x00270EA0
		public void DeleteChildNodes()
		{
			vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_DeleteChildNodes_03(base.GetCppThis());
		}

		// Token: 0x0601BF5D RID: 114525
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalOctreeNode_ExportAllPointIdsByDirectSet_04(HandleRef pThis, IntPtr pntIdx, HandleRef idList);

		/// <summary>
		/// Export all the indices of the points (contained in or under this node) by
		/// directly setting them in an allocated vtkIdList object. pntIdx indicates
		/// the starting location (in terms of vtkIdList) from which new point indices
		/// are added to vtkIdList by vtkIdList::SetId().
		/// </summary>
		// Token: 0x0601BF5E RID: 114526 RVA: 0x00272CB0 File Offset: 0x00270EB0
		public void ExportAllPointIdsByDirectSet(IntPtr pntIdx, vtkIdList idList)
		{
			vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_ExportAllPointIdsByDirectSet_04(base.GetCppThis(), pntIdx, (idList == null) ? default(HandleRef) : idList.GetCppThis());
		}

		// Token: 0x0601BF5F RID: 114527
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalOctreeNode_ExportAllPointIdsByInsertion_05(HandleRef pThis, HandleRef idList);

		/// <summary>
		/// Export all the indices of the points (contained in or under this node) by
		/// inserting them to an allocated vtkIdList via vtkIdList::InsertNextId().
		/// </summary>
		// Token: 0x0601BF60 RID: 114528 RVA: 0x00272CE0 File Offset: 0x00270EE0
		public void ExportAllPointIdsByInsertion(vtkIdList idList)
		{
			vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_ExportAllPointIdsByInsertion_05(base.GetCppThis(), (idList == null) ? default(HandleRef) : idList.GetCppThis());
		}

		// Token: 0x0601BF61 RID: 114529
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalOctreeNode_GetBounds_06(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the spatial bounding box of the node. The values are returned via
		/// an array in order of: x_min, x_max, y_min, y_max, z_min, z_max.
		/// </summary>
		// Token: 0x0601BF62 RID: 114530 RVA: 0x00272D0F File Offset: 0x00270F0F
		public void GetBounds(IntPtr bounds)
		{
			vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetBounds_06(base.GetCppThis(), bounds);
		}

		// Token: 0x0601BF63 RID: 114531
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIncrementalOctreeNode_GetChild_07(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get quick access to a child of this node. Note that this node is assumed
		/// to be a non-leaf one and no checking is performed on the node type.
		/// </summary>
		// Token: 0x0601BF64 RID: 114532 RVA: 0x00272D20 File Offset: 0x00270F20
		public vtkIncrementalOctreeNode GetChild(int i)
		{
			vtkIncrementalOctreeNode vtkIncrementalOctreeNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetChild_07(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601BF65 RID: 114533
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIncrementalOctreeNode_GetChildIndex_08(HandleRef pThis, IntPtr point);

		/// <summary>
		/// Determine which specific child / octant contains a given point. Note that
		/// the point is assumed to be inside this node and no checking is performed
		/// on the inside issue.
		/// </summary>
		// Token: 0x0601BF66 RID: 114534 RVA: 0x00272D90 File Offset: 0x00270F90
		public int GetChildIndex(IntPtr point)
		{
			return vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetChildIndex_08(base.GetCppThis(), point);
		}

		// Token: 0x0601BF67 RID: 114535
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkIncrementalOctreeNode_GetDistance2ToBoundary_09(HandleRef pThis, IntPtr point, HandleRef rootNode, int checkData);

		/// <summary>
		/// Compute the minimum squared distance from a point to this node, with all
		/// six boundaries considered. The data bounding box is checked if checkData
		/// is non-zero.
		/// </summary>
		// Token: 0x0601BF68 RID: 114536 RVA: 0x00272DB0 File Offset: 0x00270FB0
		public double GetDistance2ToBoundary(IntPtr point, vtkIncrementalOctreeNode rootNode, int checkData)
		{
			return vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetDistance2ToBoundary_09(base.GetCppThis(), point, (rootNode == null) ? default(HandleRef) : rootNode.GetCppThis(), checkData);
		}

		// Token: 0x0601BF69 RID: 114537
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkIncrementalOctreeNode_GetDistance2ToBoundary_10(HandleRef pThis, IntPtr point, IntPtr closest, HandleRef rootNode, int checkData);

		/// <summary>
		/// Compute the minimum squared distance from a point to this node, with all
		/// six boundaries considered. The data bounding box is checked if checkData
		/// is non-zero. The closest on-boundary point is returned via closest.
		/// </summary>
		// Token: 0x0601BF6A RID: 114538 RVA: 0x00272DE8 File Offset: 0x00270FE8
		public double GetDistance2ToBoundary(IntPtr point, IntPtr closest, vtkIncrementalOctreeNode rootNode, int checkData)
		{
			return vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetDistance2ToBoundary_10(base.GetCppThis(), point, closest, (rootNode == null) ? default(HandleRef) : rootNode.GetCppThis(), checkData);
		}

		// Token: 0x0601BF6B RID: 114539
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkIncrementalOctreeNode_GetDistance2ToInnerBoundary_11(HandleRef pThis, IntPtr point, HandleRef rootNode);

		/// <summary>
		/// Given a point inside this node, get the minimum squared distance to all
		/// inner boundaries. An inner boundary is a node's face that is shared by
		/// another non-root node.
		/// </summary>
		// Token: 0x0601BF6C RID: 114540 RVA: 0x00272E20 File Offset: 0x00271020
		public double GetDistance2ToInnerBoundary(IntPtr point, vtkIncrementalOctreeNode rootNode)
		{
			return vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetDistance2ToInnerBoundary_11(base.GetCppThis(), point, (rootNode == null) ? default(HandleRef) : rootNode.GetCppThis());
		}

		// Token: 0x0601BF6D RID: 114541
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIncrementalOctreeNode_GetID_12(HandleRef pThis);

		/// <summary>
		/// Returns the ID of this node which is the index of the node in the
		/// octree. The index of the node enables users of this class to
		/// associate additional information with each node.
		/// </summary>
		// Token: 0x0601BF6E RID: 114542 RVA: 0x00272E58 File Offset: 0x00271058
		public int GetID()
		{
			return vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetID_12(base.GetCppThis());
		}

		// Token: 0x0601BF6F RID: 114543
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIncrementalOctreeNode_GetMaxBounds_13(HandleRef pThis);

		/// <summary>
		/// Get access to MaxBounds. Do not free this pointer.
		/// </summary>
		// Token: 0x0601BF70 RID: 114544 RVA: 0x00272E78 File Offset: 0x00271078
		public virtual double[] GetMaxBounds()
		{
			IntPtr intPtr = vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetMaxBounds_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601BF71 RID: 114545
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalOctreeNode_GetMaxBounds_14(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Get access to MaxBounds. Do not free this pointer.
		/// </summary>
		// Token: 0x0601BF72 RID: 114546 RVA: 0x00272EC0 File Offset: 0x002710C0
		public virtual void GetMaxBounds(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetMaxBounds_14(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0601BF73 RID: 114547
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalOctreeNode_GetMaxBounds_15(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get access to MaxBounds. Do not free this pointer.
		/// </summary>
		// Token: 0x0601BF74 RID: 114548 RVA: 0x00272ED2 File Offset: 0x002710D2
		public virtual void GetMaxBounds(IntPtr _arg)
		{
			vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetMaxBounds_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0601BF75 RID: 114549
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIncrementalOctreeNode_GetMaxDataBounds_16(HandleRef pThis);

		/// <summary>
		/// Get access to MaxDataBounds. Note that MaxDataBounds is not valid until
		/// point insertion.
		/// </summary>
		// Token: 0x0601BF76 RID: 114550 RVA: 0x00272EE4 File Offset: 0x002710E4
		public IntPtr GetMaxDataBounds()
		{
			return vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetMaxDataBounds_16(base.GetCppThis());
		}

		// Token: 0x0601BF77 RID: 114551
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIncrementalOctreeNode_GetMinBounds_17(HandleRef pThis);

		/// <summary>
		/// Get access to MinBounds. Do not free this pointer.
		/// </summary>
		// Token: 0x0601BF78 RID: 114552 RVA: 0x00272F04 File Offset: 0x00271104
		public virtual double[] GetMinBounds()
		{
			IntPtr intPtr = vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetMinBounds_17(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601BF79 RID: 114553
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalOctreeNode_GetMinBounds_18(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Get access to MinBounds. Do not free this pointer.
		/// </summary>
		// Token: 0x0601BF7A RID: 114554 RVA: 0x00272F4C File Offset: 0x0027114C
		public virtual void GetMinBounds(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetMinBounds_18(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0601BF7B RID: 114555
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalOctreeNode_GetMinBounds_19(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get access to MinBounds. Do not free this pointer.
		/// </summary>
		// Token: 0x0601BF7C RID: 114556 RVA: 0x00272F5E File Offset: 0x0027115E
		public virtual void GetMinBounds(IntPtr _arg)
		{
			vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetMinBounds_19(base.GetCppThis(), _arg);
		}

		// Token: 0x0601BF7D RID: 114557
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIncrementalOctreeNode_GetMinDataBounds_20(HandleRef pThis);

		/// <summary>
		/// Get access to MinDataBounds. Note that MinDataBounds is not valid until
		/// point insertion.
		/// </summary>
		// Token: 0x0601BF7E RID: 114558 RVA: 0x00272F70 File Offset: 0x00271170
		public IntPtr GetMinDataBounds()
		{
			return vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetMinDataBounds_20(base.GetCppThis());
		}

		// Token: 0x0601BF7F RID: 114559
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIncrementalOctreeNode_GetNumberOfGenerationsFromBase_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BF80 RID: 114560 RVA: 0x00272F90 File Offset: 0x00271190
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetNumberOfGenerationsFromBase_21(base.GetCppThis(), type);
		}

		// Token: 0x0601BF81 RID: 114561
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIncrementalOctreeNode_GetNumberOfGenerationsFromBaseType_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BF82 RID: 114562 RVA: 0x00272FB0 File Offset: 0x002711B0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetNumberOfGenerationsFromBaseType_22(type);
		}

		// Token: 0x0601BF83 RID: 114563
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIncrementalOctreeNode_GetNumberOfLevels_23(HandleRef pThis);

		/// <summary>
		/// Computes and returns the maximum level of the tree. If a tree has
		/// one node it returns 1 else it returns the maximum level of its
		/// children plus 1.
		/// </summary>
		// Token: 0x0601BF84 RID: 114564 RVA: 0x00272FCC File Offset: 0x002711CC
		public int GetNumberOfLevels()
		{
			return vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetNumberOfLevels_23(base.GetCppThis());
		}

		// Token: 0x0601BF85 RID: 114565
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIncrementalOctreeNode_GetNumberOfPoints_24(HandleRef pThis);

		/// <summary>
		/// Get the number of points inside or under this node.
		/// </summary>
		// Token: 0x0601BF86 RID: 114566 RVA: 0x00272FEC File Offset: 0x002711EC
		public virtual int GetNumberOfPoints()
		{
			return vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetNumberOfPoints_24(base.GetCppThis());
		}

		// Token: 0x0601BF87 RID: 114567
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIncrementalOctreeNode_GetPointIdSet_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the list of point indices, nullptr for a non-leaf node.
		/// </summary>
		// Token: 0x0601BF88 RID: 114568 RVA: 0x0027300C File Offset: 0x0027120C
		public virtual vtkIdList GetPointIdSet()
		{
			vtkIdList vtkIdList = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetPointIdSet_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601BF89 RID: 114569
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIncrementalOctreeNode_GetPointIds_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the ID of this node which is the index of the node in the
		/// octree. The index of the node enables users of this class to
		/// associate additional information with each node.
		/// </summary>
		// Token: 0x0601BF8A RID: 114570 RVA: 0x0027307C File Offset: 0x0027127C
		public vtkIdList GetPointIds()
		{
			vtkIdList vtkIdList = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetPointIds_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601BF8B RID: 114571
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIncrementalOctreeNode_InsertPoint_27(HandleRef pThis, HandleRef points, IntPtr newPnt, int maxPts, IntPtr pntId, int ptMode, ref int numberOfNodes);

		/// <summary>
		/// This function is called after a successful point-insertion check and
		/// only applies to a leaf node. Prior to a call to this function, the
		/// octree should have been retrieved top-down to find the specific leaf
		/// node in which this new point (newPt) will be inserted. The actual index
		/// of the new point (to be inserted to points) is stored in pntId. Argument
		/// ptMode specifies whether the point is not inserted at all but instead only
		/// the point index is provided upon 0, the point is inserted via vtkPoints::
		/// InsertPoint() upon 1, or it is inserted via vtkPoints::InsertNextPoint()
		/// upon 2. For case 0, pntId needs to be specified. For cases 1 and 2, the
		/// actual point index is returned via pntId. Note that this function always
		/// returns 1 to indicate the success of point insertion.
		/// numberOfNodes is the number of nodes present in the tree at this time.
		/// it is used to assign an ID to each node which can be used to associate
		/// application specific information with each node. It is updated if new nodes
		/// are added to the tree.
		/// </summary>
		// Token: 0x0601BF8C RID: 114572 RVA: 0x002730EC File Offset: 0x002712EC
		public int InsertPoint(vtkPoints points, IntPtr newPnt, int maxPts, IntPtr pntId, int ptMode, ref int numberOfNodes)
		{
			return vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_InsertPoint_27(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis(), newPnt, maxPts, pntId, ptMode, ref numberOfNodes);
		}

		// Token: 0x0601BF8D RID: 114573
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIncrementalOctreeNode_IsA_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BF8E RID: 114574 RVA: 0x00273128 File Offset: 0x00271328
		public override int IsA(string type)
		{
			return vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_IsA_28(base.GetCppThis(), type);
		}

		// Token: 0x0601BF8F RID: 114575
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIncrementalOctreeNode_IsLeaf_29(HandleRef pThis);

		/// <summary>
		/// Determine whether or not this node is a leaf.
		/// </summary>
		// Token: 0x0601BF90 RID: 114576 RVA: 0x00273148 File Offset: 0x00271348
		public int IsLeaf()
		{
			return vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_IsLeaf_29(base.GetCppThis());
		}

		// Token: 0x0601BF91 RID: 114577
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIncrementalOctreeNode_IsTypeOf_30([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BF92 RID: 114578 RVA: 0x00273168 File Offset: 0x00271368
		public new static int IsTypeOf(string type)
		{
			return vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_IsTypeOf_30(type);
		}

		// Token: 0x0601BF93 RID: 114579
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIncrementalOctreeNode_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BF94 RID: 114580 RVA: 0x00273184 File Offset: 0x00271384
		public new vtkIncrementalOctreeNode NewInstance()
		{
			vtkIncrementalOctreeNode result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_NewInstance_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIncrementalOctreeNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601BF95 RID: 114581
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIncrementalOctreeNode_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BF96 RID: 114582 RVA: 0x002731E0 File Offset: 0x002713E0
		public new static vtkIncrementalOctreeNode SafeDownCast(vtkObjectBase o)
		{
			vtkIncrementalOctreeNode vtkIncrementalOctreeNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601BF97 RID: 114583
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIncrementalOctreeNode_SetBounds_34(HandleRef pThis, double x1, double x2, double y1, double y2, double z1, double z2);

		/// <summary>
		/// Set the spatial bounding box of the node. This function sets a default
		/// data bounding box.
		/// </summary>
		// Token: 0x0601BF98 RID: 114584 RVA: 0x0027325F File Offset: 0x0027145F
		public void SetBounds(double x1, double x2, double y1, double y2, double z1, double z2)
		{
			vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_SetBounds_34(base.GetCppThis(), x1, x2, y1, y2, z1, z2);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DD5 RID: 7637
		public new const string MRFullTypeName = "Kitware.VTK.vtkIncrementalOctreeNode";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DD6 RID: 7638
		public new static readonly string MRClassNameKey = "class vtkIncrementalOctreeNode";
	}
}
