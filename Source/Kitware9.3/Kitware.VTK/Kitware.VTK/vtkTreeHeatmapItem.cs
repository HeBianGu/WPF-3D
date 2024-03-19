using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTreeHeatmapItem
	/// </summary>
	/// <remarks>
	///    A 2D graphics item for rendering a tree and
	/// an associated heatmap.
	///
	///
	/// This item draws a tree and a heatmap as a part of a vtkContextScene.
	/// The input tree's vertex data must contain at least two arrays.
	/// The first required array is a vtkStringArray called "node name".
	/// This array corresponds to the first column of the input table.
	/// The second required array is a scalar array called "node weight".
	/// This array is used by vtkTreeLayoutStrategy to set any particular
	/// node's distance from the root of the tree.
	///
	/// The vtkNewickTreeReader automatically initializes both of these
	/// required arrays in its output tree.
	///
	/// .SEE ALSO
	/// vtkDendrogramItem vtkHeatmapItem vtkTree vtkTable vtkNewickTreeReader
	/// </remarks>
	// Token: 0x02000088 RID: 136
	public class vtkTreeHeatmapItem : vtkContextItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06001AA1 RID: 6817 RVA: 0x0002A707 File Offset: 0x00028907
		static vtkTreeHeatmapItem()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeHeatmapItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeHeatmapItem"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06001AA2 RID: 6818 RVA: 0x0002A72F File Offset: 0x0002892F
		public vtkTreeHeatmapItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06001AA3 RID: 6819
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeHeatmapItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001AA4 RID: 6820 RVA: 0x0002A740 File Offset: 0x00028940
		public new static vtkTreeHeatmapItem New()
		{
			vtkTreeHeatmapItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeHeatmapItem.vtkTreeHeatmapItem_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeHeatmapItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001AA5 RID: 6821 RVA: 0x0002A794 File Offset: 0x00028994
		public vtkTreeHeatmapItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTreeHeatmapItem.vtkTreeHeatmapItem_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06001AA6 RID: 6822 RVA: 0x0002A7D8 File Offset: 0x000289D8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06001AA7 RID: 6823
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeHeatmapItem_CollapseToNumberOfLeafNodes_01(HandleRef pThis, uint n);

		/// <summary>
		/// Collapse subtrees until there are only n leaf nodes left in the tree.
		/// The leaf nodes that remain are those that are closest to the root.
		/// Any subtrees that were collapsed prior to this function being called
		/// may be re-expanded.  Use this function instead of
		/// this-&gt;GetDendrogram-&gt;CollapseToNumberOfLeafNodes(), as this function
		/// also handles the hiding of heatmap rows that correspond to newly
		/// collapsed subtrees.
		/// </summary>
		// Token: 0x06001AA8 RID: 6824 RVA: 0x0002A7E3 File Offset: 0x000289E3
		public void CollapseToNumberOfLeafNodes(uint n)
		{
			vtkTreeHeatmapItem.vtkTreeHeatmapItem_CollapseToNumberOfLeafNodes_01(base.GetCppThis(), n);
		}

		// Token: 0x06001AA9 RID: 6825
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeHeatmapItem_GetBounds_02(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the bounds of this item (xMin, xMax, yMin, Max) in pixel coordinates.
		/// </summary>
		// Token: 0x06001AAA RID: 6826 RVA: 0x0002A7F3 File Offset: 0x000289F3
		public void GetBounds(IntPtr bounds)
		{
			vtkTreeHeatmapItem.vtkTreeHeatmapItem_GetBounds_02(base.GetCppThis(), bounds);
		}

		// Token: 0x06001AAB RID: 6827
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeHeatmapItem_GetCenter_03(HandleRef pThis, IntPtr center);

		/// <summary>
		/// Get the center point of this item in pixel coordinates.
		/// </summary>
		// Token: 0x06001AAC RID: 6828 RVA: 0x0002A803 File Offset: 0x00028A03
		public void GetCenter(IntPtr center)
		{
			vtkTreeHeatmapItem.vtkTreeHeatmapItem_GetCenter_03(base.GetCppThis(), center);
		}

		// Token: 0x06001AAD RID: 6829
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeHeatmapItem_GetColumnTree_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the tree that represents the columns of the heatmap (if one has
		/// been set).
		/// </summary>
		// Token: 0x06001AAE RID: 6830 RVA: 0x0002A814 File Offset: 0x00028A14
		public vtkTree GetColumnTree()
		{
			vtkTree vtkTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeHeatmapItem.vtkTreeHeatmapItem_GetColumnTree_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTree = (vtkTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTree.Register(null);
				}
			}
			return vtkTree;
		}

		// Token: 0x06001AAF RID: 6831
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeHeatmapItem_GetDendrogram_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the dendrogram contained by this item.
		/// </summary>
		// Token: 0x06001AB0 RID: 6832 RVA: 0x0002A884 File Offset: 0x00028A84
		public vtkDendrogramItem GetDendrogram()
		{
			vtkDendrogramItem vtkDendrogramItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeHeatmapItem.vtkTreeHeatmapItem_GetDendrogram_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDendrogramItem = (vtkDendrogramItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDendrogramItem.Register(null);
				}
			}
			return vtkDendrogramItem;
		}

		// Token: 0x06001AB1 RID: 6833
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeHeatmapItem_GetHeatmap_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the heatmap contained by this item.
		/// </summary>
		// Token: 0x06001AB2 RID: 6834 RVA: 0x0002A8F4 File Offset: 0x00028AF4
		public vtkHeatmapItem GetHeatmap()
		{
			vtkHeatmapItem vtkHeatmapItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeHeatmapItem.vtkTreeHeatmapItem_GetHeatmap_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHeatmapItem = (vtkHeatmapItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHeatmapItem.Register(null);
				}
			}
			return vtkHeatmapItem;
		}

		// Token: 0x06001AB3 RID: 6835
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeHeatmapItem_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001AB4 RID: 6836 RVA: 0x0002A964 File Offset: 0x00028B64
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTreeHeatmapItem.vtkTreeHeatmapItem_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06001AB5 RID: 6837
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeHeatmapItem_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001AB6 RID: 6838 RVA: 0x0002A984 File Offset: 0x00028B84
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTreeHeatmapItem.vtkTreeHeatmapItem_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06001AB7 RID: 6839
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeHeatmapItem_GetOrientation_09(HandleRef pThis);

		/// <summary>
		/// Get the current orientation.
		/// </summary>
		// Token: 0x06001AB8 RID: 6840 RVA: 0x0002A9A0 File Offset: 0x00028BA0
		public int GetOrientation()
		{
			return vtkTreeHeatmapItem.vtkTreeHeatmapItem_GetOrientation_09(base.GetCppThis());
		}

		// Token: 0x06001AB9 RID: 6841
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeHeatmapItem_GetPrunedTree_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Deprecated.  Use this-&gt;GetDendrogram()-&gt;GetPrunedTree() instead.
		/// </summary>
		// Token: 0x06001ABA RID: 6842 RVA: 0x0002A9C0 File Offset: 0x00028BC0
		public vtkTree GetPrunedTree()
		{
			vtkTree vtkTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeHeatmapItem.vtkTreeHeatmapItem_GetPrunedTree_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTree = (vtkTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTree.Register(null);
				}
			}
			return vtkTree;
		}

		// Token: 0x06001ABB RID: 6843
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeHeatmapItem_GetSize_11(HandleRef pThis, IntPtr size);

		/// <summary>
		/// Get the size of this item in pixel coordinates.
		/// </summary>
		// Token: 0x06001ABC RID: 6844 RVA: 0x0002AA2F File Offset: 0x00028C2F
		public void GetSize(IntPtr size)
		{
			vtkTreeHeatmapItem.vtkTreeHeatmapItem_GetSize_11(base.GetCppThis(), size);
		}

		// Token: 0x06001ABD RID: 6845
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeHeatmapItem_GetTable_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the table that this item draws.
		/// </summary>
		// Token: 0x06001ABE RID: 6846 RVA: 0x0002AA40 File Offset: 0x00028C40
		public vtkTable GetTable()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeHeatmapItem.vtkTreeHeatmapItem_GetTable_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		// Token: 0x06001ABF RID: 6847
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeHeatmapItem_GetTree_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the tree that this item draws.
		/// </summary>
		// Token: 0x06001AC0 RID: 6848 RVA: 0x0002AAB0 File Offset: 0x00028CB0
		public vtkTree GetTree()
		{
			vtkTree vtkTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeHeatmapItem.vtkTreeHeatmapItem_GetTree_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTree = (vtkTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTree.Register(null);
				}
			}
			return vtkTree;
		}

		// Token: 0x06001AC1 RID: 6849
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkTreeHeatmapItem_GetTreeLineWidth_14(HandleRef pThis);

		/// <summary>
		/// Get/Set how wide the edges of the trees should be.  Default is one pixel.
		/// </summary>
		// Token: 0x06001AC2 RID: 6850 RVA: 0x0002AB20 File Offset: 0x00028D20
		public float GetTreeLineWidth()
		{
			return vtkTreeHeatmapItem.vtkTreeHeatmapItem_GetTreeLineWidth_14(base.GetCppThis());
		}

		// Token: 0x06001AC3 RID: 6851
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeHeatmapItem_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001AC4 RID: 6852 RVA: 0x0002AB40 File Offset: 0x00028D40
		public override int IsA(string type)
		{
			return vtkTreeHeatmapItem.vtkTreeHeatmapItem_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x06001AC5 RID: 6853
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeHeatmapItem_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001AC6 RID: 6854 RVA: 0x0002AB60 File Offset: 0x00028D60
		public new static int IsTypeOf(string type)
		{
			return vtkTreeHeatmapItem.vtkTreeHeatmapItem_IsTypeOf_16(type);
		}

		// Token: 0x06001AC7 RID: 6855
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeHeatmapItem_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001AC8 RID: 6856 RVA: 0x0002AB7C File Offset: 0x00028D7C
		public new vtkTreeHeatmapItem NewInstance()
		{
			vtkTreeHeatmapItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeHeatmapItem.vtkTreeHeatmapItem_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeHeatmapItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001AC9 RID: 6857
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeHeatmapItem_ReorderTable_19(HandleRef pThis);

		/// <summary>
		/// Reorder the rows in the table so they match the order of the leaf
		/// nodes in our tree.
		/// </summary>
		// Token: 0x06001ACA RID: 6858 RVA: 0x0002ABD6 File Offset: 0x00028DD6
		public void ReorderTable()
		{
			vtkTreeHeatmapItem.vtkTreeHeatmapItem_ReorderTable_19(base.GetCppThis());
		}

		// Token: 0x06001ACB RID: 6859
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeHeatmapItem_ReverseTableColumns_20(HandleRef pThis);

		/// <summary>
		/// Reverse the order of the rows in our input table.  This is used
		/// to simplify the table layout for DOWN_TO_UP and UP_TO_DOWN
		/// orientations.
		/// </summary>
		// Token: 0x06001ACC RID: 6860 RVA: 0x0002ABE5 File Offset: 0x00028DE5
		public void ReverseTableColumns()
		{
			vtkTreeHeatmapItem.vtkTreeHeatmapItem_ReverseTableColumns_20(base.GetCppThis());
		}

		// Token: 0x06001ACD RID: 6861
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeHeatmapItem_ReverseTableRows_21(HandleRef pThis);

		/// <summary>
		/// Reverse the order of the rows in our input table.  This is used
		/// to simplify the table layout for DOWN_TO_UP and RIGHT_TO_LEFT
		/// orientations.
		/// </summary>
		// Token: 0x06001ACE RID: 6862 RVA: 0x0002ABF4 File Offset: 0x00028DF4
		public void ReverseTableRows()
		{
			vtkTreeHeatmapItem.vtkTreeHeatmapItem_ReverseTableRows_21(base.GetCppThis());
		}

		// Token: 0x06001ACF RID: 6863
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeHeatmapItem_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001AD0 RID: 6864 RVA: 0x0002AC04 File Offset: 0x00028E04
		public new static vtkTreeHeatmapItem SafeDownCast(vtkObjectBase o)
		{
			vtkTreeHeatmapItem vtkTreeHeatmapItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeHeatmapItem.vtkTreeHeatmapItem_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeHeatmapItem = (vtkTreeHeatmapItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeHeatmapItem.Register(null);
				}
			}
			return vtkTreeHeatmapItem;
		}

		// Token: 0x06001AD1 RID: 6865
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeHeatmapItem_SetColumnTree_23(HandleRef pThis, HandleRef tree);

		/// <summary>
		/// Set a tree to be drawn for the columns of the heatmap.  This tree's
		/// vertex data must contain a vtkStringArray called "node name" that
		/// corresponds to the names of the columns in the heatmap.
		/// </summary>
		// Token: 0x06001AD2 RID: 6866 RVA: 0x0002AC84 File Offset: 0x00028E84
		public virtual void SetColumnTree(vtkTree tree)
		{
			vtkTreeHeatmapItem.vtkTreeHeatmapItem_SetColumnTree_23(base.GetCppThis(), (tree == null) ? default(HandleRef) : tree.GetCppThis());
		}

		// Token: 0x06001AD3 RID: 6867
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeHeatmapItem_SetDendrogram_24(HandleRef pThis, HandleRef dendrogram);

		/// <summary>
		/// Get/Set the dendrogram contained by this item.
		/// </summary>
		// Token: 0x06001AD4 RID: 6868 RVA: 0x0002ACB4 File Offset: 0x00028EB4
		public void SetDendrogram(vtkDendrogramItem dendrogram)
		{
			vtkTreeHeatmapItem.vtkTreeHeatmapItem_SetDendrogram_24(base.GetCppThis(), (dendrogram == null) ? default(HandleRef) : dendrogram.GetCppThis());
		}

		// Token: 0x06001AD5 RID: 6869
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeHeatmapItem_SetHeatmap_25(HandleRef pThis, HandleRef heatmap);

		/// <summary>
		/// Get/Set the heatmap contained by this item.
		/// </summary>
		// Token: 0x06001AD6 RID: 6870 RVA: 0x0002ACE4 File Offset: 0x00028EE4
		public void SetHeatmap(vtkHeatmapItem heatmap)
		{
			vtkTreeHeatmapItem.vtkTreeHeatmapItem_SetHeatmap_25(base.GetCppThis(), (heatmap == null) ? default(HandleRef) : heatmap.GetCppThis());
		}

		// Token: 0x06001AD7 RID: 6871
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeHeatmapItem_SetOrientation_26(HandleRef pThis, int orientation);

		/// <summary>
		/// Set which way the tree / heatmap should face within the visualization.
		/// The default is for both components to be drawn left to right.
		/// </summary>
		// Token: 0x06001AD8 RID: 6872 RVA: 0x0002AD13 File Offset: 0x00028F13
		public void SetOrientation(int orientation)
		{
			vtkTreeHeatmapItem.vtkTreeHeatmapItem_SetOrientation_26(base.GetCppThis(), orientation);
		}

		// Token: 0x06001AD9 RID: 6873
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeHeatmapItem_SetTable_27(HandleRef pThis, HandleRef table);

		/// <summary>
		/// Set the table that this item draws.  The first column of the table
		/// must contain the names of the rows.  These names, in turn, must correspond
		/// with the nodes names in the input tree.  See SetTree for more information.
		/// </summary>
		// Token: 0x06001ADA RID: 6874 RVA: 0x0002AD24 File Offset: 0x00028F24
		public virtual void SetTable(vtkTable table)
		{
			vtkTreeHeatmapItem.vtkTreeHeatmapItem_SetTable_27(base.GetCppThis(), (table == null) ? default(HandleRef) : table.GetCppThis());
		}

		// Token: 0x06001ADB RID: 6875
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeHeatmapItem_SetTree_28(HandleRef pThis, HandleRef tree);

		/// <summary>
		/// Set the tree that this item draws.  Note that this tree's vertex data
		/// must contain a vtkStringArray called "node name".  Additionally, this
		/// array must contain the same values as the first column of the input
		/// table.  See SetTable for more information.  The vtkNewickTreeReader
		/// automatically creates this required array for you.
		/// </summary>
		// Token: 0x06001ADC RID: 6876 RVA: 0x0002AD54 File Offset: 0x00028F54
		public virtual void SetTree(vtkTree tree)
		{
			vtkTreeHeatmapItem.vtkTreeHeatmapItem_SetTree_28(base.GetCppThis(), (tree == null) ? default(HandleRef) : tree.GetCppThis());
		}

		// Token: 0x06001ADD RID: 6877
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeHeatmapItem_SetTreeColorArray_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName);

		/// <summary>
		/// Deprecated.  Use this-&gt;GetDendrogram()-&gt;SetColorArray(const char *arrayName)
		/// instead.
		/// </summary>
		// Token: 0x06001ADE RID: 6878 RVA: 0x0002AD83 File Offset: 0x00028F83
		public void SetTreeColorArray(string arrayName)
		{
			vtkTreeHeatmapItem.vtkTreeHeatmapItem_SetTreeColorArray_29(base.GetCppThis(), arrayName);
		}

		// Token: 0x06001ADF RID: 6879
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeHeatmapItem_SetTreeLineWidth_30(HandleRef pThis, float width);

		/// <summary>
		/// Get/Set how wide the edges of the trees should be.  Default is one pixel.
		/// </summary>
		// Token: 0x06001AE0 RID: 6880 RVA: 0x0002AD93 File Offset: 0x00028F93
		public void SetTreeLineWidth(float width)
		{
			vtkTreeHeatmapItem.vtkTreeHeatmapItem_SetTreeLineWidth_30(base.GetCppThis(), width);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040004AE RID: 1198
		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeHeatmapItem";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040004AF RID: 1199
		public new static readonly string MRClassNameKey = "class vtkTreeHeatmapItem";
	}
}
