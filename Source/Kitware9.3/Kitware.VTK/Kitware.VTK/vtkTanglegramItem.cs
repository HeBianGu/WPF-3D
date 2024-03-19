using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTanglegramItem
	/// </summary>
	/// <remarks>
	///    Display two related trees
	///
	///
	/// This item draws two trees with connections between their leaf nodes.
	/// Use SetTable() to specify what leaf nodes correspond to one another
	/// between the two trees.  See the documentation for this function for
	/// more details on how this table should be formatted.
	///
	/// .SEE ALSO
	/// vtkTree vtkTable vtkDendrogramItem vtkNewickTreeReader
	/// </remarks>
	// Token: 0x02000087 RID: 135
	public class vtkTanglegramItem : vtkContextItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06001A6B RID: 6763 RVA: 0x0002A24F File Offset: 0x0002844F
		static vtkTanglegramItem()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTanglegramItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTanglegramItem"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06001A6C RID: 6764 RVA: 0x0002A277 File Offset: 0x00028477
		public vtkTanglegramItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06001A6D RID: 6765
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTanglegramItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001A6E RID: 6766 RVA: 0x0002A288 File Offset: 0x00028488
		public new static vtkTanglegramItem New()
		{
			vtkTanglegramItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTanglegramItem.vtkTanglegramItem_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTanglegramItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001A6F RID: 6767 RVA: 0x0002A2DC File Offset: 0x000284DC
		public vtkTanglegramItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTanglegramItem.vtkTanglegramItem_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06001A70 RID: 6768 RVA: 0x0002A320 File Offset: 0x00028520
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06001A71 RID: 6769
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkTanglegramItem_GetCorrespondenceLineWidth_01(HandleRef pThis);

		/// <summary>
		/// Get/Set how wide the correspondence lines should be.  Default is two pixels.
		/// </summary>
		// Token: 0x06001A72 RID: 6770 RVA: 0x0002A32C File Offset: 0x0002852C
		public virtual float GetCorrespondenceLineWidth()
		{
			return vtkTanglegramItem.vtkTanglegramItem_GetCorrespondenceLineWidth_01(base.GetCppThis());
		}

		// Token: 0x06001A73 RID: 6771
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTanglegramItem_GetLabelSizeDifference_02(HandleRef pThis);

		/// <summary>
		/// Get/Set how much larger the dendrogram labels should be compared to the
		/// vertex labels.  Because the vertex labels automatically resize based
		/// on zoom levels, this is a relative (not absolute) size.  Default value
		/// is 4 pts larger than the vertex labels.
		/// </summary>
		// Token: 0x06001A74 RID: 6772 RVA: 0x0002A34C File Offset: 0x0002854C
		public virtual int GetLabelSizeDifference()
		{
			return vtkTanglegramItem.vtkTanglegramItem_GetLabelSizeDifference_02(base.GetCppThis());
		}

		// Token: 0x06001A75 RID: 6773
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTanglegramItem_GetMinimumVisibleFontSize_03(HandleRef pThis);

		/// <summary>
		/// Get/Set the smallest font size that is still considered legible.
		/// If the current zoom level requires our vertex labels to be smaller
		/// than this size the labels will not be drawn at all.  Default value
		/// is 8 pt.
		/// </summary>
		// Token: 0x06001A76 RID: 6774 RVA: 0x0002A36C File Offset: 0x0002856C
		public virtual int GetMinimumVisibleFontSize()
		{
			return vtkTanglegramItem.vtkTanglegramItem_GetMinimumVisibleFontSize_03(base.GetCppThis());
		}

		// Token: 0x06001A77 RID: 6775
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTanglegramItem_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001A78 RID: 6776 RVA: 0x0002A38C File Offset: 0x0002858C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTanglegramItem.vtkTanglegramItem_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06001A79 RID: 6777
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTanglegramItem_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001A7A RID: 6778 RVA: 0x0002A3AC File Offset: 0x000285AC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTanglegramItem.vtkTanglegramItem_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06001A7B RID: 6779
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTanglegramItem_GetOrientation_06(HandleRef pThis);

		/// <summary>
		/// Get the current orientation.
		/// </summary>
		// Token: 0x06001A7C RID: 6780 RVA: 0x0002A3C8 File Offset: 0x000285C8
		public int GetOrientation()
		{
			return vtkTanglegramItem.vtkTanglegramItem_GetOrientation_06(base.GetCppThis());
		}

		// Token: 0x06001A7D RID: 6781
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTanglegramItem_GetTable_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the table that describes the correspondences between the
		/// two trees.  The first column should contain the names of the leaf
		/// nodes from tree #1.  The columns of this table should be named
		/// after the leaf nodes of tree #2.  A non-zero cell should be used
		/// to create a connection between the two trees.  Different numbers
		/// in the table will result in connections being drawn in different
		/// colors.
		/// </summary>
		// Token: 0x06001A7E RID: 6782 RVA: 0x0002A3E8 File Offset: 0x000285E8
		public vtkTable GetTable()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTanglegramItem.vtkTanglegramItem_GetTable_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06001A7F RID: 6783
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTanglegramItem_GetTree1Label_08(HandleRef pThis);

		/// <summary>
		/// Get/Set the label for tree #1.
		/// </summary>
		// Token: 0x06001A80 RID: 6784 RVA: 0x0002A458 File Offset: 0x00028658
		public virtual string GetTree1Label()
		{
			string s = Marshal.PtrToStringAnsi(vtkTanglegramItem.vtkTanglegramItem_GetTree1Label_08(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001A81 RID: 6785
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTanglegramItem_GetTree2Label_09(HandleRef pThis);

		/// <summary>
		/// Get/Set the label for tree #2.
		/// </summary>
		// Token: 0x06001A82 RID: 6786 RVA: 0x0002A494 File Offset: 0x00028694
		public virtual string GetTree2Label()
		{
			string s = Marshal.PtrToStringAnsi(vtkTanglegramItem.vtkTanglegramItem_GetTree2Label_09(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001A83 RID: 6787
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkTanglegramItem_GetTreeLineWidth_10(HandleRef pThis);

		/// <summary>
		/// Get/Set how wide the edges of the trees should be.  Default is one pixel.
		/// </summary>
		// Token: 0x06001A84 RID: 6788 RVA: 0x0002A4D0 File Offset: 0x000286D0
		public float GetTreeLineWidth()
		{
			return vtkTanglegramItem.vtkTanglegramItem_GetTreeLineWidth_10(base.GetCppThis());
		}

		// Token: 0x06001A85 RID: 6789
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTanglegramItem_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001A86 RID: 6790 RVA: 0x0002A4F0 File Offset: 0x000286F0
		public override int IsA(string type)
		{
			return vtkTanglegramItem.vtkTanglegramItem_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x06001A87 RID: 6791
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTanglegramItem_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001A88 RID: 6792 RVA: 0x0002A510 File Offset: 0x00028710
		public new static int IsTypeOf(string type)
		{
			return vtkTanglegramItem.vtkTanglegramItem_IsTypeOf_12(type);
		}

		// Token: 0x06001A89 RID: 6793
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTanglegramItem_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001A8A RID: 6794 RVA: 0x0002A52C File Offset: 0x0002872C
		public new vtkTanglegramItem NewInstance()
		{
			vtkTanglegramItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTanglegramItem.vtkTanglegramItem_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTanglegramItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001A8B RID: 6795
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTanglegramItem_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001A8C RID: 6796 RVA: 0x0002A588 File Offset: 0x00028788
		public new static vtkTanglegramItem SafeDownCast(vtkObjectBase o)
		{
			vtkTanglegramItem vtkTanglegramItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTanglegramItem.vtkTanglegramItem_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTanglegramItem = (vtkTanglegramItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTanglegramItem.Register(null);
				}
			}
			return vtkTanglegramItem;
		}

		// Token: 0x06001A8D RID: 6797
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTanglegramItem_SetCorrespondenceLineWidth_16(HandleRef pThis, float _arg);

		/// <summary>
		/// Get/Set how wide the correspondence lines should be.  Default is two pixels.
		/// </summary>
		// Token: 0x06001A8E RID: 6798 RVA: 0x0002A607 File Offset: 0x00028807
		public virtual void SetCorrespondenceLineWidth(float _arg)
		{
			vtkTanglegramItem.vtkTanglegramItem_SetCorrespondenceLineWidth_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06001A8F RID: 6799
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTanglegramItem_SetLabelSizeDifference_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set how much larger the dendrogram labels should be compared to the
		/// vertex labels.  Because the vertex labels automatically resize based
		/// on zoom levels, this is a relative (not absolute) size.  Default value
		/// is 4 pts larger than the vertex labels.
		/// </summary>
		// Token: 0x06001A90 RID: 6800 RVA: 0x0002A617 File Offset: 0x00028817
		public virtual void SetLabelSizeDifference(int _arg)
		{
			vtkTanglegramItem.vtkTanglegramItem_SetLabelSizeDifference_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06001A91 RID: 6801
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTanglegramItem_SetMinimumVisibleFontSize_18(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the smallest font size that is still considered legible.
		/// If the current zoom level requires our vertex labels to be smaller
		/// than this size the labels will not be drawn at all.  Default value
		/// is 8 pt.
		/// </summary>
		// Token: 0x06001A92 RID: 6802 RVA: 0x0002A627 File Offset: 0x00028827
		public virtual void SetMinimumVisibleFontSize(int _arg)
		{
			vtkTanglegramItem.vtkTanglegramItem_SetMinimumVisibleFontSize_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06001A93 RID: 6803
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTanglegramItem_SetOrientation_19(HandleRef pThis, int orientation);

		/// <summary>
		/// Set which way the tanglegram should face within the visualization.
		/// The default is for tree #1 to be drawn left to right.
		/// </summary>
		// Token: 0x06001A94 RID: 6804 RVA: 0x0002A637 File Offset: 0x00028837
		public void SetOrientation(int orientation)
		{
			vtkTanglegramItem.vtkTanglegramItem_SetOrientation_19(base.GetCppThis(), orientation);
		}

		// Token: 0x06001A95 RID: 6805
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTanglegramItem_SetTable_20(HandleRef pThis, HandleRef table);

		/// <summary>
		/// Get/Set the table that describes the correspondences between the
		/// two trees.  The first column should contain the names of the leaf
		/// nodes from tree #1.  The columns of this table should be named
		/// after the leaf nodes of tree #2.  A non-zero cell should be used
		/// to create a connection between the two trees.  Different numbers
		/// in the table will result in connections being drawn in different
		/// colors.
		/// </summary>
		// Token: 0x06001A96 RID: 6806 RVA: 0x0002A648 File Offset: 0x00028848
		public void SetTable(vtkTable table)
		{
			vtkTanglegramItem.vtkTanglegramItem_SetTable_20(base.GetCppThis(), (table == null) ? default(HandleRef) : table.GetCppThis());
		}

		// Token: 0x06001A97 RID: 6807
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTanglegramItem_SetTree1_21(HandleRef pThis, HandleRef tree);

		/// <summary>
		/// Set the first tree
		/// </summary>
		// Token: 0x06001A98 RID: 6808 RVA: 0x0002A678 File Offset: 0x00028878
		public virtual void SetTree1(vtkTree tree)
		{
			vtkTanglegramItem.vtkTanglegramItem_SetTree1_21(base.GetCppThis(), (tree == null) ? default(HandleRef) : tree.GetCppThis());
		}

		// Token: 0x06001A99 RID: 6809
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTanglegramItem_SetTree1Label_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the label for tree #1.
		/// </summary>
		// Token: 0x06001A9A RID: 6810 RVA: 0x0002A6A7 File Offset: 0x000288A7
		public virtual void SetTree1Label(string _arg)
		{
			vtkTanglegramItem.vtkTanglegramItem_SetTree1Label_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06001A9B RID: 6811
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTanglegramItem_SetTree2_23(HandleRef pThis, HandleRef tree);

		/// <summary>
		/// Set the second tree
		/// </summary>
		// Token: 0x06001A9C RID: 6812 RVA: 0x0002A6B8 File Offset: 0x000288B8
		public virtual void SetTree2(vtkTree tree)
		{
			vtkTanglegramItem.vtkTanglegramItem_SetTree2_23(base.GetCppThis(), (tree == null) ? default(HandleRef) : tree.GetCppThis());
		}

		// Token: 0x06001A9D RID: 6813
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTanglegramItem_SetTree2Label_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the label for tree #2.
		/// </summary>
		// Token: 0x06001A9E RID: 6814 RVA: 0x0002A6E7 File Offset: 0x000288E7
		public virtual void SetTree2Label(string _arg)
		{
			vtkTanglegramItem.vtkTanglegramItem_SetTree2Label_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06001A9F RID: 6815
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTanglegramItem_SetTreeLineWidth_25(HandleRef pThis, float width);

		/// <summary>
		/// Get/Set how wide the edges of the trees should be.  Default is one pixel.
		/// </summary>
		// Token: 0x06001AA0 RID: 6816 RVA: 0x0002A6F7 File Offset: 0x000288F7
		public void SetTreeLineWidth(float width)
		{
			vtkTanglegramItem.vtkTanglegramItem_SetTreeLineWidth_25(base.GetCppThis(), width);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040004AC RID: 1196
		public new const string MRFullTypeName = "Kitware.VTK.vtkTanglegramItem";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040004AD RID: 1197
		public new static readonly string MRClassNameKey = "class vtkTanglegramItem";
	}
}
