using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDendrogramItem
	/// </summary>
	/// <remarks>
	///    A 2D graphics item for rendering a tree as
	/// a dendrogram
	///
	///
	/// Draw a tree as a dendrogram
	/// The input tree's vertex data must contain at least two arrays.
	/// The first required array is a vtkStringArray called "node name".
	/// This array is used to label the leaf nodes of the tree.
	/// The second required array is a scalar array called "node weight".
	/// This array is used by vtkTreeLayoutStrategy to set any particular
	/// node's distance from the root of the tree.
	///
	/// The vtkNewickTreeReader automatically initializes both of these
	/// required arrays in its output tree.
	///
	/// .SEE ALSO
	/// vtkTree vtkNewickTreeReader
	/// </remarks>
	// Token: 0x02000062 RID: 98
	public class vtkDendrogramItem : vtkContextItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060011B0 RID: 4528 RVA: 0x0001F92B File Offset: 0x0001DB2B
		static vtkDendrogramItem()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDendrogramItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDendrogramItem"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060011B1 RID: 4529 RVA: 0x0001F953 File Offset: 0x0001DB53
		public vtkDendrogramItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060011B2 RID: 4530
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDendrogramItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060011B3 RID: 4531 RVA: 0x0001F964 File Offset: 0x0001DB64
		public new static vtkDendrogramItem New()
		{
			vtkDendrogramItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDendrogramItem.vtkDendrogramItem_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDendrogramItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060011B4 RID: 4532 RVA: 0x0001F9B8 File Offset: 0x0001DBB8
		public vtkDendrogramItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDendrogramItem.vtkDendrogramItem_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060011B5 RID: 4533 RVA: 0x0001F9FC File Offset: 0x0001DBFC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060011B6 RID: 4534
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDendrogramItem_CollapseToNumberOfLeafNodes_01(HandleRef pThis, uint n);

		/// <summary>
		/// Collapse subtrees until there are only n leaf nodes left in the tree.
		/// The leaf nodes that remain are those that are closest to the root.
		/// Any subtrees that were collapsed prior to this function being called
		/// may be re-expanded.
		/// </summary>
		// Token: 0x060011B7 RID: 4535 RVA: 0x0001FA07 File Offset: 0x0001DC07
		public void CollapseToNumberOfLeafNodes(uint n)
		{
			vtkDendrogramItem.vtkDendrogramItem_CollapseToNumberOfLeafNodes_01(base.GetCppThis(), n);
		}

		// Token: 0x060011B8 RID: 4536
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDendrogramItem_ComputeLabelWidth_02(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Compute the width of the longest leaf node label.
		/// </summary>
		// Token: 0x060011B9 RID: 4537 RVA: 0x0001FA18 File Offset: 0x0001DC18
		public void ComputeLabelWidth(vtkContext2D painter)
		{
			vtkDendrogramItem.vtkDendrogramItem_ComputeLabelWidth_02(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis());
		}

		// Token: 0x060011BA RID: 4538
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDendrogramItem_DisplayNumberOfCollapsedLeafNodesOff_03(HandleRef pThis);

		/// <summary>
		/// Get/set whether or not the number of collapsed leaf nodes should be written
		/// inside the triangle representing a collapsed subtree.  Default is true.
		/// </summary>
		// Token: 0x060011BB RID: 4539 RVA: 0x0001FA47 File Offset: 0x0001DC47
		public virtual void DisplayNumberOfCollapsedLeafNodesOff()
		{
			vtkDendrogramItem.vtkDendrogramItem_DisplayNumberOfCollapsedLeafNodesOff_03(base.GetCppThis());
		}

		// Token: 0x060011BC RID: 4540
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDendrogramItem_DisplayNumberOfCollapsedLeafNodesOn_04(HandleRef pThis);

		/// <summary>
		/// Get/set whether or not the number of collapsed leaf nodes should be written
		/// inside the triangle representing a collapsed subtree.  Default is true.
		/// </summary>
		// Token: 0x060011BD RID: 4541 RVA: 0x0001FA56 File Offset: 0x0001DC56
		public virtual void DisplayNumberOfCollapsedLeafNodesOn()
		{
			vtkDendrogramItem.vtkDendrogramItem_DisplayNumberOfCollapsedLeafNodesOn_04(base.GetCppThis());
		}

		// Token: 0x060011BE RID: 4542
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDendrogramItem_DrawLabelsOff_05(HandleRef pThis);

		/// <summary>
		/// Get/Set whether or not leaf nodes should be labeled by this class.
		/// Default is true.
		/// </summary>
		// Token: 0x060011BF RID: 4543 RVA: 0x0001FA65 File Offset: 0x0001DC65
		public virtual void DrawLabelsOff()
		{
			vtkDendrogramItem.vtkDendrogramItem_DrawLabelsOff_05(base.GetCppThis());
		}

		// Token: 0x060011C0 RID: 4544
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDendrogramItem_DrawLabelsOn_06(HandleRef pThis);

		/// <summary>
		/// Get/Set whether or not leaf nodes should be labeled by this class.
		/// Default is true.
		/// </summary>
		// Token: 0x060011C1 RID: 4545 RVA: 0x0001FA74 File Offset: 0x0001DC74
		public virtual void DrawLabelsOn()
		{
			vtkDendrogramItem.vtkDendrogramItem_DrawLabelsOn_06(base.GetCppThis());
		}

		// Token: 0x060011C2 RID: 4546
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDendrogramItem_ExtendLeafNodesOff_07(HandleRef pThis);

		/// <summary>
		/// Get/set whether or not leaf nodes should be extended so that they all line
		/// up vertically.  The default is to NOT extend leaf nodes.  When extending
		/// leaf nodes, the extra length is drawn in grey so as to distinguish it from
		/// the actual length of the leaf node.
		/// </summary>
		// Token: 0x060011C3 RID: 4547 RVA: 0x0001FA83 File Offset: 0x0001DC83
		public virtual void ExtendLeafNodesOff()
		{
			vtkDendrogramItem.vtkDendrogramItem_ExtendLeafNodesOff_07(base.GetCppThis());
		}

		// Token: 0x060011C4 RID: 4548
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDendrogramItem_ExtendLeafNodesOn_08(HandleRef pThis);

		/// <summary>
		/// Get/set whether or not leaf nodes should be extended so that they all line
		/// up vertically.  The default is to NOT extend leaf nodes.  When extending
		/// leaf nodes, the extra length is drawn in grey so as to distinguish it from
		/// the actual length of the leaf node.
		/// </summary>
		// Token: 0x060011C5 RID: 4549 RVA: 0x0001FA92 File Offset: 0x0001DC92
		public virtual void ExtendLeafNodesOn()
		{
			vtkDendrogramItem.vtkDendrogramItem_ExtendLeafNodesOn_08(base.GetCppThis());
		}

		// Token: 0x060011C6 RID: 4550
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDendrogramItem_GetAngleForOrientation_09(HandleRef pThis, int orientation);

		/// <summary>
		/// Get the rotation angle (in degrees) that corresponds to the given
		/// tree orientation.  For the default orientation (LEFT_TO_RIGHT), this
		/// is 90 degrees.
		/// </summary>
		// Token: 0x060011C7 RID: 4551 RVA: 0x0001FAA4 File Offset: 0x0001DCA4
		public double GetAngleForOrientation(int orientation)
		{
			return vtkDendrogramItem.vtkDendrogramItem_GetAngleForOrientation_09(base.GetCppThis(), orientation);
		}

		// Token: 0x060011C8 RID: 4552
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDendrogramItem_GetBounds_10(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the bounds for this item as (Xmin,Xmax,Ymin,Ymax).
		/// These bounds are only guaranteed to be accurate after Paint() or
		/// PrepareToPaint() has been called.
		/// </summary>
		// Token: 0x060011C9 RID: 4553 RVA: 0x0001FAC4 File Offset: 0x0001DCC4
		public virtual void GetBounds(IntPtr bounds)
		{
			vtkDendrogramItem.vtkDendrogramItem_GetBounds_10(base.GetCppThis(), bounds);
		}

		// Token: 0x060011CA RID: 4554
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDendrogramItem_GetDisplayNumberOfCollapsedLeafNodes_11(HandleRef pThis);

		/// <summary>
		/// Get/set whether or not the number of collapsed leaf nodes should be written
		/// inside the triangle representing a collapsed subtree.  Default is true.
		/// </summary>
		// Token: 0x060011CB RID: 4555 RVA: 0x0001FAD4 File Offset: 0x0001DCD4
		public virtual bool GetDisplayNumberOfCollapsedLeafNodes()
		{
			return vtkDendrogramItem.vtkDendrogramItem_GetDisplayNumberOfCollapsedLeafNodes_11(base.GetCppThis()) != 0;
		}

		// Token: 0x060011CC RID: 4556
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDendrogramItem_GetDistanceArrayName_12(HandleRef pThis);

		/// <summary>
		/// Get/Set the name of the array that specifies the distance of each vertex
		/// from the root (NOT the vertex's parent).  This array should be a part of
		/// the input tree's VertexData.  By default, this value is "node weight",
		/// which is the name of the array created by vtkNewickTreeReader.
		/// </summary>
		// Token: 0x060011CD RID: 4557 RVA: 0x0001FAFC File Offset: 0x0001DCFC
		public virtual string GetDistanceArrayName()
		{
			return vtkDendrogramItem.vtkDendrogramItem_GetDistanceArrayName_12(base.GetCppThis());
		}

		// Token: 0x060011CE RID: 4558
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDendrogramItem_GetDrawLabels_13(HandleRef pThis);

		/// <summary>
		/// Get/Set whether or not leaf nodes should be labeled by this class.
		/// Default is true.
		/// </summary>
		// Token: 0x060011CF RID: 4559 RVA: 0x0001FB1C File Offset: 0x0001DD1C
		public virtual bool GetDrawLabels()
		{
			return vtkDendrogramItem.vtkDendrogramItem_GetDrawLabels_13(base.GetCppThis()) != 0;
		}

		// Token: 0x060011D0 RID: 4560
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDendrogramItem_GetExtendLeafNodes_14(HandleRef pThis);

		/// <summary>
		/// Get/set whether or not leaf nodes should be extended so that they all line
		/// up vertically.  The default is to NOT extend leaf nodes.  When extending
		/// leaf nodes, the extra length is drawn in grey so as to distinguish it from
		/// the actual length of the leaf node.
		/// </summary>
		// Token: 0x060011D1 RID: 4561 RVA: 0x0001FB44 File Offset: 0x0001DD44
		public virtual bool GetExtendLeafNodes()
		{
			return vtkDendrogramItem.vtkDendrogramItem_GetExtendLeafNodes_14(base.GetCppThis()) != 0;
		}

		// Token: 0x060011D2 RID: 4562
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkDendrogramItem_GetLabelWidth_15(HandleRef pThis);

		/// <summary>
		/// Get the width of the longest leaf node label.
		/// </summary>
		// Token: 0x060011D3 RID: 4563 RVA: 0x0001FB6C File Offset: 0x0001DD6C
		public float GetLabelWidth()
		{
			return vtkDendrogramItem.vtkDendrogramItem_GetLabelWidth_15(base.GetCppThis());
		}

		// Token: 0x060011D4 RID: 4564
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDendrogramItem_GetLeafSpacing_16(HandleRef pThis);

		/// <summary>
		/// Get/Set the spacing between the leaf nodes in our dendrogram.
		/// Default is 18 pixels.
		/// </summary>
		// Token: 0x060011D5 RID: 4565 RVA: 0x0001FB8C File Offset: 0x0001DD8C
		public virtual double GetLeafSpacing()
		{
			return vtkDendrogramItem.vtkDendrogramItem_GetLeafSpacing_16(base.GetCppThis());
		}

		// Token: 0x060011D6 RID: 4566
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkDendrogramItem_GetLineWidth_17(HandleRef pThis);

		/// <summary>
		/// Get/Set how wide the edges of this dendrogram should be.  Default is one pixel.
		/// </summary>
		// Token: 0x060011D7 RID: 4567 RVA: 0x0001FBAC File Offset: 0x0001DDAC
		public virtual float GetLineWidth()
		{
			return vtkDendrogramItem.vtkDendrogramItem_GetLineWidth_17(base.GetCppThis());
		}

		// Token: 0x060011D8 RID: 4568
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDendrogramItem_GetNumberOfGenerationsFromBase_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060011D9 RID: 4569 RVA: 0x0001FBCC File Offset: 0x0001DDCC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDendrogramItem.vtkDendrogramItem_GetNumberOfGenerationsFromBase_18(base.GetCppThis(), type);
		}

		// Token: 0x060011DA RID: 4570
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDendrogramItem_GetNumberOfGenerationsFromBaseType_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060011DB RID: 4571 RVA: 0x0001FBEC File Offset: 0x0001DDEC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDendrogramItem.vtkDendrogramItem_GetNumberOfGenerationsFromBaseType_19(type);
		}

		// Token: 0x060011DC RID: 4572
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDendrogramItem_GetOrientation_20(HandleRef pThis);

		/// <summary>
		/// Get the current tree orientation.
		/// </summary>
		// Token: 0x060011DD RID: 4573 RVA: 0x0001FC08 File Offset: 0x0001DE08
		public int GetOrientation()
		{
			return vtkDendrogramItem.vtkDendrogramItem_GetOrientation_20(base.GetCppThis());
		}

		// Token: 0x060011DE RID: 4574
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDendrogramItem_GetPosition_21(HandleRef pThis);

		/// <summary>
		/// Get position of the dendrogram.
		/// </summary>
		// Token: 0x060011DF RID: 4575 RVA: 0x0001FC28 File Offset: 0x0001DE28
		public virtual float[] GetPosition()
		{
			IntPtr intPtr = vtkDendrogramItem.vtkDendrogramItem_GetPosition_21(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060011E0 RID: 4576
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDendrogramItem_GetPosition_22(HandleRef pThis, ref float _arg1, ref float _arg2);

		/// <summary>
		/// Get position of the dendrogram.
		/// </summary>
		// Token: 0x060011E1 RID: 4577 RVA: 0x0001FC70 File Offset: 0x0001DE70
		public virtual void GetPosition(ref float _arg1, ref float _arg2)
		{
			vtkDendrogramItem.vtkDendrogramItem_GetPosition_22(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x060011E2 RID: 4578
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDendrogramItem_GetPosition_23(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get position of the dendrogram.
		/// </summary>
		// Token: 0x060011E3 RID: 4579 RVA: 0x0001FC81 File Offset: 0x0001DE81
		public virtual void GetPosition(IntPtr _arg)
		{
			vtkDendrogramItem.vtkDendrogramItem_GetPosition_23(base.GetCppThis(), _arg);
		}

		// Token: 0x060011E4 RID: 4580
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDendrogramItem_GetPositionOfVertex_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string vertexName, IntPtr position);

		/// <summary>
		/// Find the position of the vertex with the specified name.  Store
		/// this information in the passed array.  Returns true if the vertex
		/// was found, false otherwise.
		/// </summary>
		// Token: 0x060011E5 RID: 4581 RVA: 0x0001FC94 File Offset: 0x0001DE94
		public bool GetPositionOfVertex(string vertexName, IntPtr position)
		{
			return vtkDendrogramItem.vtkDendrogramItem_GetPositionOfVertex_24(base.GetCppThis(), vertexName, position) != 0;
		}

		// Token: 0x060011E6 RID: 4582
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDendrogramItem_GetPositionVector_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get position of the dendrogram.
		/// </summary>
		// Token: 0x060011E7 RID: 4583 RVA: 0x0001FCBC File Offset: 0x0001DEBC
		public vtkVector2f GetPositionVector()
		{
			vtkVector2f result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDendrogramItem.vtkDendrogramItem_GetPositionVector_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector2f)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060011E8 RID: 4584
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDendrogramItem_GetPrunedTree_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the collapsed tree
		/// </summary>
		// Token: 0x060011E9 RID: 4585 RVA: 0x0001FD18 File Offset: 0x0001DF18
		public vtkTree GetPrunedTree()
		{
			vtkTree vtkTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDendrogramItem.vtkDendrogramItem_GetPrunedTree_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060011EA RID: 4586
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDendrogramItem_GetTextAngleForOrientation_27(HandleRef pThis, int orientation);

		/// <summary>
		/// Get the angle that vertex labels should be rotated for the corresponding
		/// tree orientation.  For the default orientation (LEFT_TO_RIGHT), this
		/// is 0 degrees.
		/// </summary>
		// Token: 0x060011EB RID: 4587 RVA: 0x0001FD88 File Offset: 0x0001DF88
		public double GetTextAngleForOrientation(int orientation)
		{
			return vtkDendrogramItem.vtkDendrogramItem_GetTextAngleForOrientation_27(base.GetCppThis(), orientation);
		}

		// Token: 0x060011EC RID: 4588
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDendrogramItem_GetTree_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the tree that this item draws.
		/// </summary>
		// Token: 0x060011ED RID: 4589 RVA: 0x0001FDA8 File Offset: 0x0001DFA8
		public vtkTree GetTree()
		{
			vtkTree vtkTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDendrogramItem.vtkDendrogramItem_GetTree_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060011EE RID: 4590
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDendrogramItem_GetVertexNameArrayName_29(HandleRef pThis);

		/// <summary>
		/// Get/Set the name of a vtkStringArray that specifies the names of the
		/// vertices of the input tree.  This array should be a part of the input
		/// tree's VertexData.  By default, this value is "node name", which is the
		/// name of the array created by vtkNewickTreeReader.
		/// </summary>
		// Token: 0x060011EF RID: 4591 RVA: 0x0001FE18 File Offset: 0x0001E018
		public virtual string GetVertexNameArrayName()
		{
			return vtkDendrogramItem.vtkDendrogramItem_GetVertexNameArrayName_29(base.GetCppThis());
		}

		// Token: 0x060011F0 RID: 4592
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDendrogramItem_IsA_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060011F1 RID: 4593 RVA: 0x0001FE38 File Offset: 0x0001E038
		public override int IsA(string type)
		{
			return vtkDendrogramItem.vtkDendrogramItem_IsA_30(base.GetCppThis(), type);
		}

		// Token: 0x060011F2 RID: 4594
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDendrogramItem_IsTypeOf_31([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060011F3 RID: 4595 RVA: 0x0001FE58 File Offset: 0x0001E058
		public new static int IsTypeOf(string type)
		{
			return vtkDendrogramItem.vtkDendrogramItem_IsTypeOf_31(type);
		}

		// Token: 0x060011F4 RID: 4596
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDendrogramItem_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060011F5 RID: 4597 RVA: 0x0001FE74 File Offset: 0x0001E074
		public new vtkDendrogramItem NewInstance()
		{
			vtkDendrogramItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDendrogramItem.vtkDendrogramItem_NewInstance_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDendrogramItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060011F6 RID: 4598
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDendrogramItem_Paint_34(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paints the input tree as a dendrogram.
		/// </summary>
		// Token: 0x060011F7 RID: 4599 RVA: 0x0001FED0 File Offset: 0x0001E0D0
		public override bool Paint(vtkContext2D painter)
		{
			return vtkDendrogramItem.vtkDendrogramItem_Paint_34(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x060011F8 RID: 4600
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDendrogramItem_PrepareToPaint_35(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// This function calls RebuildBuffers() if necessary.
		/// Once PrepareToPaint() has been called, GetBounds() is guaranteed
		/// to provide useful information.
		/// </summary>
		// Token: 0x060011F9 RID: 4601 RVA: 0x0001FF0C File Offset: 0x0001E10C
		public void PrepareToPaint(vtkContext2D painter)
		{
			vtkDendrogramItem.vtkDendrogramItem_PrepareToPaint_35(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis());
		}

		// Token: 0x060011FA RID: 4602
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDendrogramItem_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060011FB RID: 4603 RVA: 0x0001FF3C File Offset: 0x0001E13C
		public new static vtkDendrogramItem SafeDownCast(vtkObjectBase o)
		{
			vtkDendrogramItem vtkDendrogramItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDendrogramItem.vtkDendrogramItem_SafeDownCast_36((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060011FC RID: 4604
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDendrogramItem_SetColorArray_37(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName);

		/// <summary>
		/// Indicate which array within the Tree's VertexData should be used to
		/// color the tree.  The specified array must be a vtkDoubleArray.
		/// By default, the tree will be drawn in black.
		/// </summary>
		// Token: 0x060011FD RID: 4605 RVA: 0x0001FFBB File Offset: 0x0001E1BB
		public void SetColorArray(string arrayName)
		{
			vtkDendrogramItem.vtkDendrogramItem_SetColorArray_37(base.GetCppThis(), arrayName);
		}

		// Token: 0x060011FE RID: 4606
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDendrogramItem_SetDisplayNumberOfCollapsedLeafNodes_38(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/set whether or not the number of collapsed leaf nodes should be written
		/// inside the triangle representing a collapsed subtree.  Default is true.
		/// </summary>
		// Token: 0x060011FF RID: 4607 RVA: 0x0001FFCB File Offset: 0x0001E1CB
		public virtual void SetDisplayNumberOfCollapsedLeafNodes(bool _arg)
		{
			vtkDendrogramItem.vtkDendrogramItem_SetDisplayNumberOfCollapsedLeafNodes_38(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06001200 RID: 4608
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDendrogramItem_SetDistanceArrayName_39(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the name of the array that specifies the distance of each vertex
		/// from the root (NOT the vertex's parent).  This array should be a part of
		/// the input tree's VertexData.  By default, this value is "node weight",
		/// which is the name of the array created by vtkNewickTreeReader.
		/// </summary>
		// Token: 0x06001201 RID: 4609 RVA: 0x0001FFE3 File Offset: 0x0001E1E3
		public virtual void SetDistanceArrayName(string _arg)
		{
			vtkDendrogramItem.vtkDendrogramItem_SetDistanceArrayName_39(base.GetCppThis(), _arg);
		}

		// Token: 0x06001202 RID: 4610
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDendrogramItem_SetDrawLabels_40(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/Set whether or not leaf nodes should be labeled by this class.
		/// Default is true.
		/// </summary>
		// Token: 0x06001203 RID: 4611 RVA: 0x0001FFF3 File Offset: 0x0001E1F3
		public virtual void SetDrawLabels(bool _arg)
		{
			vtkDendrogramItem.vtkDendrogramItem_SetDrawLabels_40(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06001204 RID: 4612
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDendrogramItem_SetExtendLeafNodes_41(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/set whether or not leaf nodes should be extended so that they all line
		/// up vertically.  The default is to NOT extend leaf nodes.  When extending
		/// leaf nodes, the extra length is drawn in grey so as to distinguish it from
		/// the actual length of the leaf node.
		/// </summary>
		// Token: 0x06001205 RID: 4613 RVA: 0x0002000B File Offset: 0x0001E20B
		public virtual void SetExtendLeafNodes(bool _arg)
		{
			vtkDendrogramItem.vtkDendrogramItem_SetExtendLeafNodes_41(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06001206 RID: 4614
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDendrogramItem_SetLeafSpacing_42(HandleRef pThis, double _arg);

		/// <summary>
		/// Get/Set the spacing between the leaf nodes in our dendrogram.
		/// Default is 18 pixels.
		/// </summary>
		// Token: 0x06001207 RID: 4615 RVA: 0x00020023 File Offset: 0x0001E223
		public virtual void SetLeafSpacing(double _arg)
		{
			vtkDendrogramItem.vtkDendrogramItem_SetLeafSpacing_42(base.GetCppThis(), _arg);
		}

		// Token: 0x06001208 RID: 4616
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDendrogramItem_SetLineWidth_43(HandleRef pThis, float _arg);

		/// <summary>
		/// Get/Set how wide the edges of this dendrogram should be.  Default is one pixel.
		/// </summary>
		// Token: 0x06001209 RID: 4617 RVA: 0x00020033 File Offset: 0x0001E233
		public virtual void SetLineWidth(float _arg)
		{
			vtkDendrogramItem.vtkDendrogramItem_SetLineWidth_43(base.GetCppThis(), _arg);
		}

		// Token: 0x0600120A RID: 4618
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDendrogramItem_SetOrientation_44(HandleRef pThis, int orientation);

		/// <summary>
		/// Set which way the tree should face within the visualization.  The default
		/// is for the tree to be drawn left to right.
		/// </summary>
		// Token: 0x0600120B RID: 4619 RVA: 0x00020043 File Offset: 0x0001E243
		public void SetOrientation(int orientation)
		{
			vtkDendrogramItem.vtkDendrogramItem_SetOrientation_44(base.GetCppThis(), orientation);
		}

		// Token: 0x0600120C RID: 4620
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDendrogramItem_SetPosition_45(HandleRef pThis, float _arg1, float _arg2);

		/// <summary>
		/// Set the position of the dendrogram.
		/// </summary>
		// Token: 0x0600120D RID: 4621 RVA: 0x00020053 File Offset: 0x0001E253
		public virtual void SetPosition(float _arg1, float _arg2)
		{
			vtkDendrogramItem.vtkDendrogramItem_SetPosition_45(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600120E RID: 4622
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDendrogramItem_SetPosition_46(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the position of the dendrogram.
		/// </summary>
		// Token: 0x0600120F RID: 4623 RVA: 0x00020064 File Offset: 0x0001E264
		public void SetPosition(IntPtr _arg)
		{
			vtkDendrogramItem.vtkDendrogramItem_SetPosition_46(base.GetCppThis(), _arg);
		}

		// Token: 0x06001210 RID: 4624
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDendrogramItem_SetPosition_47(HandleRef pThis, HandleRef pos);

		/// <summary>
		/// Set the position of the dendrogram.
		/// </summary>
		// Token: 0x06001211 RID: 4625 RVA: 0x00020074 File Offset: 0x0001E274
		public void SetPosition(vtkVector2f pos)
		{
			vtkDendrogramItem.vtkDendrogramItem_SetPosition_47(base.GetCppThis(), (pos == null) ? default(HandleRef) : pos.GetCppThis());
		}

		// Token: 0x06001212 RID: 4626
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDendrogramItem_SetTree_48(HandleRef pThis, HandleRef tree);

		/// <summary>
		/// Set the tree that this item draws.  Note that this tree's vertex data
		/// must contain a vtkStringArray called "node name".  The vtkNewickTreeReader
		/// automatically creates this required array for you.
		/// </summary>
		// Token: 0x06001213 RID: 4627 RVA: 0x000200A4 File Offset: 0x0001E2A4
		public virtual void SetTree(vtkTree tree)
		{
			vtkDendrogramItem.vtkDendrogramItem_SetTree_48(base.GetCppThis(), (tree == null) ? default(HandleRef) : tree.GetCppThis());
		}

		// Token: 0x06001214 RID: 4628
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDendrogramItem_SetVertexNameArrayName_49(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the name of a vtkStringArray that specifies the names of the
		/// vertices of the input tree.  This array should be a part of the input
		/// tree's VertexData.  By default, this value is "node name", which is the
		/// name of the array created by vtkNewickTreeReader.
		/// </summary>
		// Token: 0x06001215 RID: 4629 RVA: 0x000200D3 File Offset: 0x0001E2D3
		public virtual void SetVertexNameArrayName(string _arg)
		{
			vtkDendrogramItem.vtkDendrogramItem_SetVertexNameArrayName_49(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000447 RID: 1095
		public new const string MRFullTypeName = "Kitware.VTK.vtkDendrogramItem";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000448 RID: 1096
		public new static readonly string MRClassNameKey = "class vtkDendrogramItem";

		/// <summary>
		/// Enum for Orientation.
		/// </summary>
		// Token: 0x02000063 RID: 99
		public enum DOWN_TO_UP_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x0400044A RID: 1098
			DOWN_TO_UP = 3,
			/// <summary>enum member</summary>
			// Token: 0x0400044B RID: 1099
			LEFT_TO_RIGHT = 0,
			/// <summary>enum member</summary>
			// Token: 0x0400044C RID: 1100
			RIGHT_TO_LEFT = 2,
			/// <summary>enum member</summary>
			// Token: 0x0400044D RID: 1101
			UP_TO_DOWN = 1
		}
	}
}
