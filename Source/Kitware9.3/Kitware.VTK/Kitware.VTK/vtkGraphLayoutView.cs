using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGraphLayoutView
	/// </summary>
	/// <remarks>
	///    Lays out and displays a graph
	///
	///
	/// vtkGraphLayoutView performs graph layout and displays a vtkGraph.
	/// You may color and label the vertices and edges using fields in the graph.
	/// If coordinates are already assigned to the graph vertices in your graph,
	/// set the layout strategy to PassThrough in this view. The default layout
	/// is Fast2D which is fast but not that good, for better layout set the
	/// layout to Simple2D or ForceDirected. There are also tree and circle
	/// layout strategies. :)
	///
	/// .SEE ALSO
	/// vtkFast2DLayoutStrategy
	/// vtkSimple2DLayoutStrategy
	/// vtkForceDirectedLayoutStrategy
	///
	/// @par Thanks:
	/// Thanks a bunch to the holographic unfolding pattern.
	/// </remarks>
	// Token: 0x0200006A RID: 106
	public class vtkGraphLayoutView : vtkRenderView
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060012A4 RID: 4772 RVA: 0x00020C97 File Offset: 0x0001EE97
		static vtkGraphLayoutView()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphLayoutView.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphLayoutView"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060012A5 RID: 4773 RVA: 0x00020CBF File Offset: 0x0001EEBF
		public vtkGraphLayoutView(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060012A6 RID: 4774
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphLayoutView_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060012A7 RID: 4775 RVA: 0x00020CD0 File Offset: 0x0001EED0
		public new static vtkGraphLayoutView New()
		{
			vtkGraphLayoutView result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphLayoutView.vtkGraphLayoutView_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphLayoutView)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060012A8 RID: 4776 RVA: 0x00020D24 File Offset: 0x0001EF24
		public vtkGraphLayoutView() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGraphLayoutView.vtkGraphLayoutView_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060012A9 RID: 4777 RVA: 0x00020D68 File Offset: 0x0001EF68
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060012AA RID: 4778
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_AddIconType_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type, int index);

		/// <summary>
		/// Associate the icon at index "index" in the vtkTexture to all vertices
		/// containing "type" as a value in the vertex attribute array specified by
		/// IconArrayName.
		/// </summary>
		// Token: 0x060012AB RID: 4779 RVA: 0x00020D73 File Offset: 0x0001EF73
		public void AddIconType(string type, int index)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_AddIconType_01(base.GetCppThis(), type, index);
		}

		// Token: 0x060012AC RID: 4780
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_ClearIconTypes_02(HandleRef pThis);

		/// <summary>
		/// Clear all icon mappings.
		/// </summary>
		// Token: 0x060012AD RID: 4781 RVA: 0x00020D84 File Offset: 0x0001EF84
		public void ClearIconTypes()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_ClearIconTypes_02(base.GetCppThis());
		}

		// Token: 0x060012AE RID: 4782
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_ColorEdgesOff_03(HandleRef pThis);

		/// <summary>
		/// Whether to color edges.  Default is off.
		/// </summary>
		// Token: 0x060012AF RID: 4783 RVA: 0x00020D93 File Offset: 0x0001EF93
		public virtual void ColorEdgesOff()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_ColorEdgesOff_03(base.GetCppThis());
		}

		// Token: 0x060012B0 RID: 4784
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_ColorEdgesOn_04(HandleRef pThis);

		/// <summary>
		/// Whether to color edges.  Default is off.
		/// </summary>
		// Token: 0x060012B1 RID: 4785 RVA: 0x00020DA2 File Offset: 0x0001EFA2
		public virtual void ColorEdgesOn()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_ColorEdgesOn_04(base.GetCppThis());
		}

		// Token: 0x060012B2 RID: 4786
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_ColorVerticesOff_05(HandleRef pThis);

		/// <summary>
		/// Whether to color vertices.  Default is off.
		/// </summary>
		// Token: 0x060012B3 RID: 4787 RVA: 0x00020DB1 File Offset: 0x0001EFB1
		public virtual void ColorVerticesOff()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_ColorVerticesOff_05(base.GetCppThis());
		}

		// Token: 0x060012B4 RID: 4788
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_ColorVerticesOn_06(HandleRef pThis);

		/// <summary>
		/// Whether to color vertices.  Default is off.
		/// </summary>
		// Token: 0x060012B5 RID: 4789 RVA: 0x00020DC0 File Offset: 0x0001EFC0
		public virtual void ColorVerticesOn()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_ColorVerticesOn_06(base.GetCppThis());
		}

		// Token: 0x060012B6 RID: 4790
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_EdgeLabelVisibilityOff_07(HandleRef pThis);

		/// <summary>
		/// Whether to show edge labels.  Default is off.
		/// </summary>
		// Token: 0x060012B7 RID: 4791 RVA: 0x00020DCF File Offset: 0x0001EFCF
		public virtual void EdgeLabelVisibilityOff()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_EdgeLabelVisibilityOff_07(base.GetCppThis());
		}

		// Token: 0x060012B8 RID: 4792
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_EdgeLabelVisibilityOn_08(HandleRef pThis);

		/// <summary>
		/// Whether to show edge labels.  Default is off.
		/// </summary>
		// Token: 0x060012B9 RID: 4793 RVA: 0x00020DDE File Offset: 0x0001EFDE
		public virtual void EdgeLabelVisibilityOn()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_EdgeLabelVisibilityOn_08(base.GetCppThis());
		}

		// Token: 0x060012BA RID: 4794
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_EdgeSelectionOff_09(HandleRef pThis);

		/// <summary>
		/// Whether edges are selectable. Default is on.
		/// </summary>
		// Token: 0x060012BB RID: 4795 RVA: 0x00020DED File Offset: 0x0001EFED
		public virtual void EdgeSelectionOff()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_EdgeSelectionOff_09(base.GetCppThis());
		}

		// Token: 0x060012BC RID: 4796
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_EdgeSelectionOn_10(HandleRef pThis);

		/// <summary>
		/// Whether edges are selectable. Default is on.
		/// </summary>
		// Token: 0x060012BD RID: 4797 RVA: 0x00020DFC File Offset: 0x0001EFFC
		public virtual void EdgeSelectionOn()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_EdgeSelectionOn_10(base.GetCppThis());
		}

		// Token: 0x060012BE RID: 4798
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_EdgeVisibilityOff_11(HandleRef pThis);

		/// <summary>
		/// Whether to show the edges at all. Default is on
		/// </summary>
		// Token: 0x060012BF RID: 4799 RVA: 0x00020E0B File Offset: 0x0001F00B
		public virtual void EdgeVisibilityOff()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_EdgeVisibilityOff_11(base.GetCppThis());
		}

		// Token: 0x060012C0 RID: 4800
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_EdgeVisibilityOn_12(HandleRef pThis);

		/// <summary>
		/// Whether to show the edges at all. Default is on
		/// </summary>
		// Token: 0x060012C1 RID: 4801 RVA: 0x00020E1A File Offset: 0x0001F01A
		public virtual void EdgeVisibilityOn()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_EdgeVisibilityOn_12(base.GetCppThis());
		}

		// Token: 0x060012C2 RID: 4802
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGraphLayoutView_GetColorEdges_13(HandleRef pThis);

		/// <summary>
		/// Whether to color edges.  Default is off.
		/// </summary>
		// Token: 0x060012C3 RID: 4803 RVA: 0x00020E2C File Offset: 0x0001F02C
		public bool GetColorEdges()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetColorEdges_13(base.GetCppThis()) != 0;
		}

		// Token: 0x060012C4 RID: 4804
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGraphLayoutView_GetColorVertices_14(HandleRef pThis);

		/// <summary>
		/// Whether to color vertices.  Default is off.
		/// </summary>
		// Token: 0x060012C5 RID: 4805 RVA: 0x00020E54 File Offset: 0x0001F054
		public bool GetColorVertices()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetColorVertices_14(base.GetCppThis()) != 0;
		}

		// Token: 0x060012C6 RID: 4806
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphLayoutView_GetEdgeColorArrayName_15(HandleRef pThis);

		/// <summary>
		/// The array to use for coloring edges.  Default is "color".
		/// </summary>
		// Token: 0x060012C7 RID: 4807 RVA: 0x00020E7C File Offset: 0x0001F07C
		public string GetEdgeColorArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGraphLayoutView.vtkGraphLayoutView_GetEdgeColorArrayName_15(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060012C8 RID: 4808
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphLayoutView_GetEdgeLabelArrayName_16(HandleRef pThis);

		/// <summary>
		/// The array to use for edge labeling.  Default is "LabelText".
		/// </summary>
		// Token: 0x060012C9 RID: 4809 RVA: 0x00020EB8 File Offset: 0x0001F0B8
		public string GetEdgeLabelArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGraphLayoutView.vtkGraphLayoutView_GetEdgeLabelArrayName_16(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060012CA RID: 4810
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphLayoutView_GetEdgeLabelFontSize_17(HandleRef pThis);

		/// <summary>
		/// The size of the font used for edge labeling
		/// </summary>
		// Token: 0x060012CB RID: 4811 RVA: 0x00020EF4 File Offset: 0x0001F0F4
		public virtual int GetEdgeLabelFontSize()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetEdgeLabelFontSize_17(base.GetCppThis());
		}

		// Token: 0x060012CC RID: 4812
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGraphLayoutView_GetEdgeLabelVisibility_18(HandleRef pThis);

		/// <summary>
		/// Whether to show edge labels.  Default is off.
		/// </summary>
		// Token: 0x060012CD RID: 4813 RVA: 0x00020F14 File Offset: 0x0001F114
		public bool GetEdgeLabelVisibility()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetEdgeLabelVisibility_18(base.GetCppThis()) != 0;
		}

		// Token: 0x060012CE RID: 4814
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphLayoutView_GetEdgeLayoutStrategy_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The layout strategy to use when performing the edge layout.
		/// This signature allows an application to create a layout
		/// object directly and simply set the pointer through this method.
		/// </summary>
		// Token: 0x060012CF RID: 4815 RVA: 0x00020F3C File Offset: 0x0001F13C
		public vtkEdgeLayoutStrategy GetEdgeLayoutStrategy()
		{
			vtkEdgeLayoutStrategy vtkEdgeLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphLayoutView.vtkGraphLayoutView_GetEdgeLayoutStrategy_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEdgeLayoutStrategy = (vtkEdgeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEdgeLayoutStrategy.Register(null);
				}
			}
			return vtkEdgeLayoutStrategy;
		}

		// Token: 0x060012D0 RID: 4816
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphLayoutView_GetEdgeLayoutStrategyName_20(HandleRef pThis);

		/// <summary>
		/// The layout strategy to use when performing the edge layout.
		/// The possible strings are:
		/// "Arc Parallel"   - Arc parallel edges and self loops.
		/// "Pass Through"   - Use edge routes assigned to the input.
		/// Default is "Arc Parallel".
		/// </summary>
		// Token: 0x060012D1 RID: 4817 RVA: 0x00020FAC File Offset: 0x0001F1AC
		public string GetEdgeLayoutStrategyName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGraphLayoutView.vtkGraphLayoutView_GetEdgeLayoutStrategyName_20(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060012D2 RID: 4818
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGraphLayoutView_GetEdgeScalarBarVisibility_21(HandleRef pThis);

		/// <summary>
		/// Whether the scalar bar for edges is visible.  Default is off.
		/// </summary>
		// Token: 0x060012D3 RID: 4819 RVA: 0x00020FE8 File Offset: 0x0001F1E8
		public bool GetEdgeScalarBarVisibility()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetEdgeScalarBarVisibility_21(base.GetCppThis()) != 0;
		}

		// Token: 0x060012D4 RID: 4820
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGraphLayoutView_GetEdgeSelection_22(HandleRef pThis);

		/// <summary>
		/// Whether edges are selectable. Default is on.
		/// </summary>
		// Token: 0x060012D5 RID: 4821 RVA: 0x00021010 File Offset: 0x0001F210
		public bool GetEdgeSelection()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetEdgeSelection_22(base.GetCppThis()) != 0;
		}

		// Token: 0x060012D6 RID: 4822
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGraphLayoutView_GetEdgeVisibility_23(HandleRef pThis);

		/// <summary>
		/// Whether to show the edges at all. Default is on
		/// </summary>
		// Token: 0x060012D7 RID: 4823 RVA: 0x00021038 File Offset: 0x0001F238
		public bool GetEdgeVisibility()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetEdgeVisibility_23(base.GetCppThis()) != 0;
		}

		// Token: 0x060012D8 RID: 4824
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphLayoutView_GetEnableEdgesByArray_24(HandleRef pThis);

		/// <summary>
		/// Whether to color edges.  Default is off.
		/// </summary>
		// Token: 0x060012D9 RID: 4825 RVA: 0x00021060 File Offset: 0x0001F260
		public int GetEnableEdgesByArray()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetEnableEdgesByArray_24(base.GetCppThis());
		}

		// Token: 0x060012DA RID: 4826
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphLayoutView_GetEnableVerticesByArray_25(HandleRef pThis);

		/// <summary>
		/// Whether to color vertices.  Default is off.
		/// </summary>
		// Token: 0x060012DB RID: 4827 RVA: 0x00021080 File Offset: 0x0001F280
		public int GetEnableVerticesByArray()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetEnableVerticesByArray_25(base.GetCppThis());
		}

		// Token: 0x060012DC RID: 4828
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphLayoutView_GetEnabledEdgesArrayName_26(HandleRef pThis);

		/// <summary>
		/// The array to use for coloring edges.
		/// </summary>
		// Token: 0x060012DD RID: 4829 RVA: 0x000210A0 File Offset: 0x0001F2A0
		public string GetEnabledEdgesArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGraphLayoutView.vtkGraphLayoutView_GetEnabledEdgesArrayName_26(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060012DE RID: 4830
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphLayoutView_GetEnabledVerticesArrayName_27(HandleRef pThis);

		/// <summary>
		/// The array to use for coloring vertices.
		/// </summary>
		// Token: 0x060012DF RID: 4831 RVA: 0x000210DC File Offset: 0x0001F2DC
		public string GetEnabledVerticesArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGraphLayoutView.vtkGraphLayoutView_GetEnabledVerticesArrayName_27(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060012E0 RID: 4832
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphLayoutView_GetGlyphType_28(HandleRef pThis);

		/// <summary>
		/// The type of glyph to use for the vertices
		/// </summary>
		// Token: 0x060012E1 RID: 4833 RVA: 0x00021118 File Offset: 0x0001F318
		public int GetGlyphType()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetGlyphType_28(base.GetCppThis());
		}

		// Token: 0x060012E2 RID: 4834
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGraphLayoutView_GetHideEdgeLabelsOnInteraction_29(HandleRef pThis);

		/// <summary>
		/// Whether to hide edge labels during mouse interactions.  Default is off.
		/// </summary>
		// Token: 0x060012E3 RID: 4835 RVA: 0x00021138 File Offset: 0x0001F338
		public bool GetHideEdgeLabelsOnInteraction()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetHideEdgeLabelsOnInteraction_29(base.GetCppThis()) != 0;
		}

		// Token: 0x060012E4 RID: 4836
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGraphLayoutView_GetHideVertexLabelsOnInteraction_30(HandleRef pThis);

		/// <summary>
		/// Whether to hide vertex labels during mouse interactions.  Default is off.
		/// </summary>
		// Token: 0x060012E5 RID: 4837 RVA: 0x00021160 File Offset: 0x0001F360
		public bool GetHideVertexLabelsOnInteraction()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetHideVertexLabelsOnInteraction_30(base.GetCppThis()) != 0;
		}

		// Token: 0x060012E6 RID: 4838
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphLayoutView_GetIconArrayName_31(HandleRef pThis);

		/// <summary>
		/// The array used for assigning icons
		/// </summary>
		// Token: 0x060012E7 RID: 4839 RVA: 0x00021188 File Offset: 0x0001F388
		public string GetIconArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGraphLayoutView.vtkGraphLayoutView_GetIconArrayName_31(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060012E8 RID: 4840
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGraphLayoutView_GetIconVisibility_32(HandleRef pThis);

		/// <summary>
		/// Whether icons are visible (default off).
		/// </summary>
		// Token: 0x060012E9 RID: 4841 RVA: 0x000211C4 File Offset: 0x0001F3C4
		public bool GetIconVisibility()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetIconVisibility_32(base.GetCppThis()) != 0;
		}

		// Token: 0x060012EA RID: 4842
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphLayoutView_GetLayoutStrategy_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The layout strategy to use when performing the graph layout.
		/// This signature allows an application to create a layout
		/// object directly and simply set the pointer through this method.
		/// </summary>
		// Token: 0x060012EB RID: 4843 RVA: 0x000211EC File Offset: 0x0001F3EC
		public vtkGraphLayoutStrategy GetLayoutStrategy()
		{
			vtkGraphLayoutStrategy vtkGraphLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphLayoutView.vtkGraphLayoutView_GetLayoutStrategy_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphLayoutStrategy = (vtkGraphLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphLayoutStrategy.Register(null);
				}
			}
			return vtkGraphLayoutStrategy;
		}

		// Token: 0x060012EC RID: 4844
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphLayoutView_GetLayoutStrategyName_34(HandleRef pThis);

		/// <summary>
		/// The layout strategy to use when performing the graph layout.
		/// The possible strings are:
		/// - "Random"         Randomly places vertices in a box.
		/// - "Force Directed" A layout in 3D or 2D simulating forces on edges.
		/// - "Simple 2D"      A simple 2D force directed layout.
		/// - "Clustering 2D"  A 2D force directed layout that's just like
		/// simple 2D but uses some techniques to cluster better.
		/// - "Community 2D"   A linear-time 2D layout that's just like
		/// Fast 2D but looks for and uses a community
		/// array to 'accentuate' clusters.
		/// - "Fast 2D"       A linear-time 2D layout.
		/// - "Pass Through"  Use locations assigned to the input.
		/// - "Circular"      Places vertices uniformly on a circle.
		/// - "Cone"          Cone tree layout.
		/// - "Span Tree"     Span Tree Layout.
		/// Default is "Simple 2D".
		/// </summary>
		// Token: 0x060012ED RID: 4845 RVA: 0x0002125C File Offset: 0x0001F45C
		public string GetLayoutStrategyName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGraphLayoutView.vtkGraphLayoutView_GetLayoutStrategyName_34(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060012EE RID: 4846
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphLayoutView_GetNumberOfGenerationsFromBase_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060012EF RID: 4847 RVA: 0x00021298 File Offset: 0x0001F498
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetNumberOfGenerationsFromBase_35(base.GetCppThis(), type);
		}

		// Token: 0x060012F0 RID: 4848
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphLayoutView_GetNumberOfGenerationsFromBaseType_36([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060012F1 RID: 4849 RVA: 0x000212B8 File Offset: 0x0001F4B8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetNumberOfGenerationsFromBaseType_36(type);
		}

		// Token: 0x060012F2 RID: 4850
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGraphLayoutView_GetScaledGlyphs_37(HandleRef pThis);

		/// <summary>
		/// Whether to use scaled glyphs or not.  Default is off.
		/// </summary>
		// Token: 0x060012F3 RID: 4851 RVA: 0x000212D4 File Offset: 0x0001F4D4
		public bool GetScaledGlyphs()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetScaledGlyphs_37(base.GetCppThis()) != 0;
		}

		// Token: 0x060012F4 RID: 4852
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphLayoutView_GetScalingArrayName_38(HandleRef pThis);

		/// <summary>
		/// The array used for scaling (if ScaledGlyphs is ON)
		/// </summary>
		// Token: 0x060012F5 RID: 4853 RVA: 0x000212FC File Offset: 0x0001F4FC
		public string GetScalingArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGraphLayoutView.vtkGraphLayoutView_GetScalingArrayName_38(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060012F6 RID: 4854
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphLayoutView_GetVertexColorArrayName_39(HandleRef pThis);

		/// <summary>
		/// The array to use for coloring vertices.  The default behavior
		/// is to color by vertex degree.
		/// </summary>
		// Token: 0x060012F7 RID: 4855 RVA: 0x00021338 File Offset: 0x0001F538
		public string GetVertexColorArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGraphLayoutView.vtkGraphLayoutView_GetVertexColorArrayName_39(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060012F8 RID: 4856
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphLayoutView_GetVertexLabelArrayName_40(HandleRef pThis);

		/// <summary>
		/// The array to use for vertex labeling.  Default is "VertexDegree".
		/// </summary>
		// Token: 0x060012F9 RID: 4857 RVA: 0x00021374 File Offset: 0x0001F574
		public string GetVertexLabelArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGraphLayoutView.vtkGraphLayoutView_GetVertexLabelArrayName_40(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060012FA RID: 4858
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphLayoutView_GetVertexLabelFontSize_41(HandleRef pThis);

		/// <summary>
		/// The size of the font used for vertex labeling
		/// </summary>
		// Token: 0x060012FB RID: 4859 RVA: 0x000213B0 File Offset: 0x0001F5B0
		public virtual int GetVertexLabelFontSize()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetVertexLabelFontSize_41(base.GetCppThis());
		}

		// Token: 0x060012FC RID: 4860
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGraphLayoutView_GetVertexLabelVisibility_42(HandleRef pThis);

		/// <summary>
		/// Whether to show vertex labels.  Default is off.
		/// </summary>
		// Token: 0x060012FD RID: 4861 RVA: 0x000213D0 File Offset: 0x0001F5D0
		public bool GetVertexLabelVisibility()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetVertexLabelVisibility_42(base.GetCppThis()) != 0;
		}

		// Token: 0x060012FE RID: 4862
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGraphLayoutView_GetVertexScalarBarVisibility_43(HandleRef pThis);

		/// <summary>
		/// Whether the scalar bar for vertices is visible.  Default is off.
		/// </summary>
		// Token: 0x060012FF RID: 4863 RVA: 0x000213F8 File Offset: 0x0001F5F8
		public bool GetVertexScalarBarVisibility()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_GetVertexScalarBarVisibility_43(base.GetCppThis()) != 0;
		}

		// Token: 0x06001300 RID: 4864
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_HideEdgeLabelsOnInteractionOff_44(HandleRef pThis);

		/// <summary>
		/// Whether to hide edge labels during mouse interactions.  Default is off.
		/// </summary>
		// Token: 0x06001301 RID: 4865 RVA: 0x0002141E File Offset: 0x0001F61E
		public virtual void HideEdgeLabelsOnInteractionOff()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_HideEdgeLabelsOnInteractionOff_44(base.GetCppThis());
		}

		// Token: 0x06001302 RID: 4866
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_HideEdgeLabelsOnInteractionOn_45(HandleRef pThis);

		/// <summary>
		/// Whether to hide edge labels during mouse interactions.  Default is off.
		/// </summary>
		// Token: 0x06001303 RID: 4867 RVA: 0x0002142D File Offset: 0x0001F62D
		public virtual void HideEdgeLabelsOnInteractionOn()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_HideEdgeLabelsOnInteractionOn_45(base.GetCppThis());
		}

		// Token: 0x06001304 RID: 4868
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_HideVertexLabelsOnInteractionOff_46(HandleRef pThis);

		/// <summary>
		/// Whether to hide vertex labels during mouse interactions.  Default is off.
		/// </summary>
		// Token: 0x06001305 RID: 4869 RVA: 0x0002143C File Offset: 0x0001F63C
		public virtual void HideVertexLabelsOnInteractionOff()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_HideVertexLabelsOnInteractionOff_46(base.GetCppThis());
		}

		// Token: 0x06001306 RID: 4870
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_HideVertexLabelsOnInteractionOn_47(HandleRef pThis);

		/// <summary>
		/// Whether to hide vertex labels during mouse interactions.  Default is off.
		/// </summary>
		// Token: 0x06001307 RID: 4871 RVA: 0x0002144B File Offset: 0x0001F64B
		public virtual void HideVertexLabelsOnInteractionOn()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_HideVertexLabelsOnInteractionOn_47(base.GetCppThis());
		}

		// Token: 0x06001308 RID: 4872
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_IconVisibilityOff_48(HandleRef pThis);

		/// <summary>
		/// Whether icons are visible (default off).
		/// </summary>
		// Token: 0x06001309 RID: 4873 RVA: 0x0002145A File Offset: 0x0001F65A
		public virtual void IconVisibilityOff()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_IconVisibilityOff_48(base.GetCppThis());
		}

		// Token: 0x0600130A RID: 4874
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_IconVisibilityOn_49(HandleRef pThis);

		/// <summary>
		/// Whether icons are visible (default off).
		/// </summary>
		// Token: 0x0600130B RID: 4875 RVA: 0x00021469 File Offset: 0x0001F669
		public virtual void IconVisibilityOn()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_IconVisibilityOn_49(base.GetCppThis());
		}

		// Token: 0x0600130C RID: 4876
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphLayoutView_IsA_50(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600130D RID: 4877 RVA: 0x00021478 File Offset: 0x0001F678
		public override int IsA(string type)
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_IsA_50(base.GetCppThis(), type);
		}

		// Token: 0x0600130E RID: 4878
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphLayoutView_IsLayoutComplete_51(HandleRef pThis);

		/// <summary>
		/// Is the graph layout complete? This method is useful
		/// for when the strategy is iterative and the application
		/// wants to show the iterative progress of the graph layout
		/// See Also: UpdateLayout();
		/// </summary>
		// Token: 0x0600130F RID: 4879 RVA: 0x00021498 File Offset: 0x0001F698
		public virtual int IsLayoutComplete()
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_IsLayoutComplete_51(base.GetCppThis());
		}

		// Token: 0x06001310 RID: 4880
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphLayoutView_IsTypeOf_52([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001311 RID: 4881 RVA: 0x000214B8 File Offset: 0x0001F6B8
		public new static int IsTypeOf(string type)
		{
			return vtkGraphLayoutView.vtkGraphLayoutView_IsTypeOf_52(type);
		}

		// Token: 0x06001312 RID: 4882
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphLayoutView_NewInstance_54(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001313 RID: 4883 RVA: 0x000214D4 File Offset: 0x0001F6D4
		public new vtkGraphLayoutView NewInstance()
		{
			vtkGraphLayoutView result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphLayoutView.vtkGraphLayoutView_NewInstance_54(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphLayoutView)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001314 RID: 4884
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphLayoutView_SafeDownCast_55(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001315 RID: 4885 RVA: 0x00021530 File Offset: 0x0001F730
		public new static vtkGraphLayoutView SafeDownCast(vtkObjectBase o)
		{
			vtkGraphLayoutView vtkGraphLayoutView = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphLayoutView.vtkGraphLayoutView_SafeDownCast_55((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphLayoutView = (vtkGraphLayoutView)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphLayoutView.Register(null);
				}
			}
			return vtkGraphLayoutView;
		}

		// Token: 0x06001316 RID: 4886
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_ScaledGlyphsOff_56(HandleRef pThis);

		/// <summary>
		/// Whether to use scaled glyphs or not.  Default is off.
		/// </summary>
		// Token: 0x06001317 RID: 4887 RVA: 0x000215AF File Offset: 0x0001F7AF
		public virtual void ScaledGlyphsOff()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_ScaledGlyphsOff_56(base.GetCppThis());
		}

		// Token: 0x06001318 RID: 4888
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_ScaledGlyphsOn_57(HandleRef pThis);

		/// <summary>
		/// Whether to use scaled glyphs or not.  Default is off.
		/// </summary>
		// Token: 0x06001319 RID: 4889 RVA: 0x000215BE File Offset: 0x0001F7BE
		public virtual void ScaledGlyphsOn()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_ScaledGlyphsOn_57(base.GetCppThis());
		}

		// Token: 0x0600131A RID: 4890
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetColorEdges_58(HandleRef pThis, byte vis);

		/// <summary>
		/// Whether to color edges.  Default is off.
		/// </summary>
		// Token: 0x0600131B RID: 4891 RVA: 0x000215CD File Offset: 0x0001F7CD
		public void SetColorEdges(bool vis)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetColorEdges_58(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x0600131C RID: 4892
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetColorVertices_59(HandleRef pThis, byte vis);

		/// <summary>
		/// Whether to color vertices.  Default is off.
		/// </summary>
		// Token: 0x0600131D RID: 4893 RVA: 0x000215E5 File Offset: 0x0001F7E5
		public void SetColorVertices(bool vis)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetColorVertices_59(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x0600131E RID: 4894
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetEdgeColorArrayName_60(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The array to use for coloring edges.  Default is "color".
		/// </summary>
		// Token: 0x0600131F RID: 4895 RVA: 0x000215FD File Offset: 0x0001F7FD
		public void SetEdgeColorArrayName(string name)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetEdgeColorArrayName_60(base.GetCppThis(), name);
		}

		// Token: 0x06001320 RID: 4896
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetEdgeLabelArrayName_61(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The array to use for edge labeling.  Default is "LabelText".
		/// </summary>
		// Token: 0x06001321 RID: 4897 RVA: 0x0002160D File Offset: 0x0001F80D
		public void SetEdgeLabelArrayName(string name)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetEdgeLabelArrayName_61(base.GetCppThis(), name);
		}

		// Token: 0x06001322 RID: 4898
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetEdgeLabelFontSize_62(HandleRef pThis, int size);

		/// <summary>
		/// The size of the font used for edge labeling
		/// </summary>
		// Token: 0x06001323 RID: 4899 RVA: 0x0002161D File Offset: 0x0001F81D
		public virtual void SetEdgeLabelFontSize(int size)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetEdgeLabelFontSize_62(base.GetCppThis(), size);
		}

		// Token: 0x06001324 RID: 4900
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetEdgeLabelVisibility_63(HandleRef pThis, byte vis);

		/// <summary>
		/// Whether to show edge labels.  Default is off.
		/// </summary>
		// Token: 0x06001325 RID: 4901 RVA: 0x0002162D File Offset: 0x0001F82D
		public void SetEdgeLabelVisibility(bool vis)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetEdgeLabelVisibility_63(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x06001326 RID: 4902
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetEdgeLayoutStrategy_64(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The layout strategy to use when performing the edge layout.
		/// The possible strings are:
		/// "Arc Parallel"   - Arc parallel edges and self loops.
		/// "Pass Through"   - Use edge routes assigned to the input.
		/// Default is "Arc Parallel".
		/// </summary>
		// Token: 0x06001327 RID: 4903 RVA: 0x00021645 File Offset: 0x0001F845
		public void SetEdgeLayoutStrategy(string name)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetEdgeLayoutStrategy_64(base.GetCppThis(), name);
		}

		// Token: 0x06001328 RID: 4904
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetEdgeLayoutStrategy_65(HandleRef pThis, HandleRef s);

		/// <summary>
		/// The layout strategy to use when performing the edge layout.
		/// This signature allows an application to create a layout
		/// object directly and simply set the pointer through this method.
		/// </summary>
		// Token: 0x06001329 RID: 4905 RVA: 0x00021658 File Offset: 0x0001F858
		public void SetEdgeLayoutStrategy(vtkEdgeLayoutStrategy s)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetEdgeLayoutStrategy_65(base.GetCppThis(), (s == null) ? default(HandleRef) : s.GetCppThis());
		}

		// Token: 0x0600132A RID: 4906
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetEdgeLayoutStrategyToArcParallel_66(HandleRef pThis);

		/// <summary>
		/// The layout strategy to use when performing the edge layout.
		/// The possible strings are:
		/// "Arc Parallel"   - Arc parallel edges and self loops.
		/// "Pass Through"   - Use edge routes assigned to the input.
		/// Default is "Arc Parallel".
		/// </summary>
		// Token: 0x0600132B RID: 4907 RVA: 0x00021687 File Offset: 0x0001F887
		public void SetEdgeLayoutStrategyToArcParallel()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetEdgeLayoutStrategyToArcParallel_66(base.GetCppThis());
		}

		// Token: 0x0600132C RID: 4908
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetEdgeLayoutStrategyToPassThrough_67(HandleRef pThis);

		/// <summary>
		/// The layout strategy to use when performing the edge layout.
		/// The possible strings are:
		/// "Arc Parallel"   - Arc parallel edges and self loops.
		/// "Pass Through"   - Use edge routes assigned to the input.
		/// Default is "Arc Parallel".
		/// </summary>
		// Token: 0x0600132D RID: 4909 RVA: 0x00021696 File Offset: 0x0001F896
		public void SetEdgeLayoutStrategyToPassThrough()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetEdgeLayoutStrategyToPassThrough_67(base.GetCppThis());
		}

		// Token: 0x0600132E RID: 4910
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetEdgeScalarBarVisibility_68(HandleRef pThis, byte vis);

		/// <summary>
		/// Whether the scalar bar for edges is visible.  Default is off.
		/// </summary>
		// Token: 0x0600132F RID: 4911 RVA: 0x000216A5 File Offset: 0x0001F8A5
		public void SetEdgeScalarBarVisibility(bool vis)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetEdgeScalarBarVisibility_68(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x06001330 RID: 4912
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetEdgeSelection_69(HandleRef pThis, byte vis);

		/// <summary>
		/// Whether edges are selectable. Default is on.
		/// </summary>
		// Token: 0x06001331 RID: 4913 RVA: 0x000216BD File Offset: 0x0001F8BD
		public void SetEdgeSelection(bool vis)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetEdgeSelection_69(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x06001332 RID: 4914
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetEdgeVisibility_70(HandleRef pThis, byte vis);

		/// <summary>
		/// Whether to show the edges at all. Default is on
		/// </summary>
		// Token: 0x06001333 RID: 4915 RVA: 0x000216D5 File Offset: 0x0001F8D5
		public void SetEdgeVisibility(bool vis)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetEdgeVisibility_70(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x06001334 RID: 4916
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetEnableEdgesByArray_71(HandleRef pThis, byte vis);

		/// <summary>
		/// Whether to color edges.  Default is off.
		/// </summary>
		// Token: 0x06001335 RID: 4917 RVA: 0x000216ED File Offset: 0x0001F8ED
		public void SetEnableEdgesByArray(bool vis)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetEnableEdgesByArray_71(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x06001336 RID: 4918
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetEnableVerticesByArray_72(HandleRef pThis, byte vis);

		/// <summary>
		/// Whether to color vertices.  Default is off.
		/// </summary>
		// Token: 0x06001337 RID: 4919 RVA: 0x00021705 File Offset: 0x0001F905
		public void SetEnableVerticesByArray(bool vis)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetEnableVerticesByArray_72(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x06001338 RID: 4920
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetEnabledEdgesArrayName_73(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The array to use for coloring edges.
		/// </summary>
		// Token: 0x06001339 RID: 4921 RVA: 0x0002171D File Offset: 0x0001F91D
		public void SetEnabledEdgesArrayName(string name)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetEnabledEdgesArrayName_73(base.GetCppThis(), name);
		}

		// Token: 0x0600133A RID: 4922
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetEnabledVerticesArrayName_74(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The array to use for coloring vertices.
		/// </summary>
		// Token: 0x0600133B RID: 4923 RVA: 0x0002172D File Offset: 0x0001F92D
		public void SetEnabledVerticesArrayName(string name)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetEnabledVerticesArrayName_74(base.GetCppThis(), name);
		}

		// Token: 0x0600133C RID: 4924
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetGlyphType_75(HandleRef pThis, int type);

		/// <summary>
		/// The type of glyph to use for the vertices
		/// </summary>
		// Token: 0x0600133D RID: 4925 RVA: 0x0002173D File Offset: 0x0001F93D
		public void SetGlyphType(int type)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetGlyphType_75(base.GetCppThis(), type);
		}

		// Token: 0x0600133E RID: 4926
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetHideEdgeLabelsOnInteraction_76(HandleRef pThis, byte vis);

		/// <summary>
		/// Whether to hide edge labels during mouse interactions.  Default is off.
		/// </summary>
		// Token: 0x0600133F RID: 4927 RVA: 0x0002174D File Offset: 0x0001F94D
		public void SetHideEdgeLabelsOnInteraction(bool vis)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetHideEdgeLabelsOnInteraction_76(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x06001340 RID: 4928
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetHideVertexLabelsOnInteraction_77(HandleRef pThis, byte vis);

		/// <summary>
		/// Whether to hide vertex labels during mouse interactions.  Default is off.
		/// </summary>
		// Token: 0x06001341 RID: 4929 RVA: 0x00021765 File Offset: 0x0001F965
		public void SetHideVertexLabelsOnInteraction(bool vis)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetHideVertexLabelsOnInteraction_77(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x06001342 RID: 4930
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetIconAlignment_78(HandleRef pThis, int alignment);

		/// <summary>
		/// Specify where the icons should be placed in relation to the vertex.
		/// See vtkIconGlyphFilter.h for possible values.
		/// </summary>
		// Token: 0x06001343 RID: 4931 RVA: 0x0002177D File Offset: 0x0001F97D
		public void SetIconAlignment(int alignment)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetIconAlignment_78(base.GetCppThis(), alignment);
		}

		// Token: 0x06001344 RID: 4932
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetIconArrayName_79(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The array used for assigning icons
		/// </summary>
		// Token: 0x06001345 RID: 4933 RVA: 0x0002178D File Offset: 0x0001F98D
		public void SetIconArrayName(string name)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetIconArrayName_79(base.GetCppThis(), name);
		}

		// Token: 0x06001346 RID: 4934
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetIconVisibility_80(HandleRef pThis, byte b);

		/// <summary>
		/// Whether icons are visible (default off).
		/// </summary>
		// Token: 0x06001347 RID: 4935 RVA: 0x0002179D File Offset: 0x0001F99D
		public void SetIconVisibility(bool b)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetIconVisibility_80(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		// Token: 0x06001348 RID: 4936
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetLayoutStrategy_81(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The layout strategy to use when performing the graph layout.
		/// The possible strings are:
		/// - "Random"         Randomly places vertices in a box.
		/// - "Force Directed" A layout in 3D or 2D simulating forces on edges.
		/// - "Simple 2D"      A simple 2D force directed layout.
		/// - "Clustering 2D"  A 2D force directed layout that's just like
		/// simple 2D but uses some techniques to cluster better.
		/// - "Community 2D"   A linear-time 2D layout that's just like
		/// Fast 2D but looks for and uses a community
		/// array to 'accentuate' clusters.
		/// - "Fast 2D"       A linear-time 2D layout.
		/// - "Pass Through"  Use locations assigned to the input.
		/// - "Circular"      Places vertices uniformly on a circle.
		/// - "Cone"          Cone tree layout.
		/// - "Span Tree"     Span Tree Layout.
		/// Default is "Simple 2D".
		/// </summary>
		// Token: 0x06001349 RID: 4937 RVA: 0x000217B5 File Offset: 0x0001F9B5
		public void SetLayoutStrategy(string name)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetLayoutStrategy_81(base.GetCppThis(), name);
		}

		// Token: 0x0600134A RID: 4938
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetLayoutStrategy_82(HandleRef pThis, HandleRef s);

		/// <summary>
		/// The layout strategy to use when performing the graph layout.
		/// This signature allows an application to create a layout
		/// object directly and simply set the pointer through this method.
		/// </summary>
		// Token: 0x0600134B RID: 4939 RVA: 0x000217C8 File Offset: 0x0001F9C8
		public void SetLayoutStrategy(vtkGraphLayoutStrategy s)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetLayoutStrategy_82(base.GetCppThis(), (s == null) ? default(HandleRef) : s.GetCppThis());
		}

		// Token: 0x0600134C RID: 4940
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetLayoutStrategyToCircular_83(HandleRef pThis);

		/// <summary>
		/// The layout strategy to use when performing the graph layout.
		/// The possible strings are:
		/// - "Random"         Randomly places vertices in a box.
		/// - "Force Directed" A layout in 3D or 2D simulating forces on edges.
		/// - "Simple 2D"      A simple 2D force directed layout.
		/// - "Clustering 2D"  A 2D force directed layout that's just like
		/// simple 2D but uses some techniques to cluster better.
		/// - "Community 2D"   A linear-time 2D layout that's just like
		/// Fast 2D but looks for and uses a community
		/// array to 'accentuate' clusters.
		/// - "Fast 2D"       A linear-time 2D layout.
		/// - "Pass Through"  Use locations assigned to the input.
		/// - "Circular"      Places vertices uniformly on a circle.
		/// - "Cone"          Cone tree layout.
		/// - "Span Tree"     Span Tree Layout.
		/// Default is "Simple 2D".
		/// </summary>
		// Token: 0x0600134D RID: 4941 RVA: 0x000217F7 File Offset: 0x0001F9F7
		public void SetLayoutStrategyToCircular()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetLayoutStrategyToCircular_83(base.GetCppThis());
		}

		// Token: 0x0600134E RID: 4942
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetLayoutStrategyToClustering2D_84(HandleRef pThis);

		/// <summary>
		/// The layout strategy to use when performing the graph layout.
		/// The possible strings are:
		/// - "Random"         Randomly places vertices in a box.
		/// - "Force Directed" A layout in 3D or 2D simulating forces on edges.
		/// - "Simple 2D"      A simple 2D force directed layout.
		/// - "Clustering 2D"  A 2D force directed layout that's just like
		/// simple 2D but uses some techniques to cluster better.
		/// - "Community 2D"   A linear-time 2D layout that's just like
		/// Fast 2D but looks for and uses a community
		/// array to 'accentuate' clusters.
		/// - "Fast 2D"       A linear-time 2D layout.
		/// - "Pass Through"  Use locations assigned to the input.
		/// - "Circular"      Places vertices uniformly on a circle.
		/// - "Cone"          Cone tree layout.
		/// - "Span Tree"     Span Tree Layout.
		/// Default is "Simple 2D".
		/// </summary>
		// Token: 0x0600134F RID: 4943 RVA: 0x00021806 File Offset: 0x0001FA06
		public void SetLayoutStrategyToClustering2D()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetLayoutStrategyToClustering2D_84(base.GetCppThis());
		}

		// Token: 0x06001350 RID: 4944
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetLayoutStrategyToCommunity2D_85(HandleRef pThis);

		/// <summary>
		/// The layout strategy to use when performing the graph layout.
		/// The possible strings are:
		/// - "Random"         Randomly places vertices in a box.
		/// - "Force Directed" A layout in 3D or 2D simulating forces on edges.
		/// - "Simple 2D"      A simple 2D force directed layout.
		/// - "Clustering 2D"  A 2D force directed layout that's just like
		/// simple 2D but uses some techniques to cluster better.
		/// - "Community 2D"   A linear-time 2D layout that's just like
		/// Fast 2D but looks for and uses a community
		/// array to 'accentuate' clusters.
		/// - "Fast 2D"       A linear-time 2D layout.
		/// - "Pass Through"  Use locations assigned to the input.
		/// - "Circular"      Places vertices uniformly on a circle.
		/// - "Cone"          Cone tree layout.
		/// - "Span Tree"     Span Tree Layout.
		/// Default is "Simple 2D".
		/// </summary>
		// Token: 0x06001351 RID: 4945 RVA: 0x00021815 File Offset: 0x0001FA15
		public void SetLayoutStrategyToCommunity2D()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetLayoutStrategyToCommunity2D_85(base.GetCppThis());
		}

		// Token: 0x06001352 RID: 4946
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetLayoutStrategyToCone_86(HandleRef pThis);

		/// <summary>
		/// The layout strategy to use when performing the graph layout.
		/// The possible strings are:
		/// - "Random"         Randomly places vertices in a box.
		/// - "Force Directed" A layout in 3D or 2D simulating forces on edges.
		/// - "Simple 2D"      A simple 2D force directed layout.
		/// - "Clustering 2D"  A 2D force directed layout that's just like
		/// simple 2D but uses some techniques to cluster better.
		/// - "Community 2D"   A linear-time 2D layout that's just like
		/// Fast 2D but looks for and uses a community
		/// array to 'accentuate' clusters.
		/// - "Fast 2D"       A linear-time 2D layout.
		/// - "Pass Through"  Use locations assigned to the input.
		/// - "Circular"      Places vertices uniformly on a circle.
		/// - "Cone"          Cone tree layout.
		/// - "Span Tree"     Span Tree Layout.
		/// Default is "Simple 2D".
		/// </summary>
		// Token: 0x06001353 RID: 4947 RVA: 0x00021824 File Offset: 0x0001FA24
		public void SetLayoutStrategyToCone()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetLayoutStrategyToCone_86(base.GetCppThis());
		}

		// Token: 0x06001354 RID: 4948
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetLayoutStrategyToCosmicTree_87(HandleRef pThis);

		/// <summary>
		/// The layout strategy to use when performing the graph layout.
		/// The possible strings are:
		/// - "Random"         Randomly places vertices in a box.
		/// - "Force Directed" A layout in 3D or 2D simulating forces on edges.
		/// - "Simple 2D"      A simple 2D force directed layout.
		/// - "Clustering 2D"  A 2D force directed layout that's just like
		/// simple 2D but uses some techniques to cluster better.
		/// - "Community 2D"   A linear-time 2D layout that's just like
		/// Fast 2D but looks for and uses a community
		/// array to 'accentuate' clusters.
		/// - "Fast 2D"       A linear-time 2D layout.
		/// - "Pass Through"  Use locations assigned to the input.
		/// - "Circular"      Places vertices uniformly on a circle.
		/// - "Cone"          Cone tree layout.
		/// - "Span Tree"     Span Tree Layout.
		/// Default is "Simple 2D".
		/// </summary>
		// Token: 0x06001355 RID: 4949 RVA: 0x00021833 File Offset: 0x0001FA33
		public void SetLayoutStrategyToCosmicTree()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetLayoutStrategyToCosmicTree_87(base.GetCppThis());
		}

		// Token: 0x06001356 RID: 4950
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetLayoutStrategyToFast2D_88(HandleRef pThis);

		/// <summary>
		/// The layout strategy to use when performing the graph layout.
		/// The possible strings are:
		/// - "Random"         Randomly places vertices in a box.
		/// - "Force Directed" A layout in 3D or 2D simulating forces on edges.
		/// - "Simple 2D"      A simple 2D force directed layout.
		/// - "Clustering 2D"  A 2D force directed layout that's just like
		/// simple 2D but uses some techniques to cluster better.
		/// - "Community 2D"   A linear-time 2D layout that's just like
		/// Fast 2D but looks for and uses a community
		/// array to 'accentuate' clusters.
		/// - "Fast 2D"       A linear-time 2D layout.
		/// - "Pass Through"  Use locations assigned to the input.
		/// - "Circular"      Places vertices uniformly on a circle.
		/// - "Cone"          Cone tree layout.
		/// - "Span Tree"     Span Tree Layout.
		/// Default is "Simple 2D".
		/// </summary>
		// Token: 0x06001357 RID: 4951 RVA: 0x00021842 File Offset: 0x0001FA42
		public void SetLayoutStrategyToFast2D()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetLayoutStrategyToFast2D_88(base.GetCppThis());
		}

		// Token: 0x06001358 RID: 4952
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetLayoutStrategyToForceDirected_89(HandleRef pThis);

		/// <summary>
		/// The layout strategy to use when performing the graph layout.
		/// The possible strings are:
		/// - "Random"         Randomly places vertices in a box.
		/// - "Force Directed" A layout in 3D or 2D simulating forces on edges.
		/// - "Simple 2D"      A simple 2D force directed layout.
		/// - "Clustering 2D"  A 2D force directed layout that's just like
		/// simple 2D but uses some techniques to cluster better.
		/// - "Community 2D"   A linear-time 2D layout that's just like
		/// Fast 2D but looks for and uses a community
		/// array to 'accentuate' clusters.
		/// - "Fast 2D"       A linear-time 2D layout.
		/// - "Pass Through"  Use locations assigned to the input.
		/// - "Circular"      Places vertices uniformly on a circle.
		/// - "Cone"          Cone tree layout.
		/// - "Span Tree"     Span Tree Layout.
		/// Default is "Simple 2D".
		/// </summary>
		// Token: 0x06001359 RID: 4953 RVA: 0x00021851 File Offset: 0x0001FA51
		public void SetLayoutStrategyToForceDirected()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetLayoutStrategyToForceDirected_89(base.GetCppThis());
		}

		// Token: 0x0600135A RID: 4954
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetLayoutStrategyToPassThrough_90(HandleRef pThis);

		/// <summary>
		/// The layout strategy to use when performing the graph layout.
		/// The possible strings are:
		/// - "Random"         Randomly places vertices in a box.
		/// - "Force Directed" A layout in 3D or 2D simulating forces on edges.
		/// - "Simple 2D"      A simple 2D force directed layout.
		/// - "Clustering 2D"  A 2D force directed layout that's just like
		/// simple 2D but uses some techniques to cluster better.
		/// - "Community 2D"   A linear-time 2D layout that's just like
		/// Fast 2D but looks for and uses a community
		/// array to 'accentuate' clusters.
		/// - "Fast 2D"       A linear-time 2D layout.
		/// - "Pass Through"  Use locations assigned to the input.
		/// - "Circular"      Places vertices uniformly on a circle.
		/// - "Cone"          Cone tree layout.
		/// - "Span Tree"     Span Tree Layout.
		/// Default is "Simple 2D".
		/// </summary>
		// Token: 0x0600135B RID: 4955 RVA: 0x00021860 File Offset: 0x0001FA60
		public void SetLayoutStrategyToPassThrough()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetLayoutStrategyToPassThrough_90(base.GetCppThis());
		}

		// Token: 0x0600135C RID: 4956
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetLayoutStrategyToRandom_91(HandleRef pThis);

		/// <summary>
		/// The layout strategy to use when performing the graph layout.
		/// The possible strings are:
		/// - "Random"         Randomly places vertices in a box.
		/// - "Force Directed" A layout in 3D or 2D simulating forces on edges.
		/// - "Simple 2D"      A simple 2D force directed layout.
		/// - "Clustering 2D"  A 2D force directed layout that's just like
		/// simple 2D but uses some techniques to cluster better.
		/// - "Community 2D"   A linear-time 2D layout that's just like
		/// Fast 2D but looks for and uses a community
		/// array to 'accentuate' clusters.
		/// - "Fast 2D"       A linear-time 2D layout.
		/// - "Pass Through"  Use locations assigned to the input.
		/// - "Circular"      Places vertices uniformly on a circle.
		/// - "Cone"          Cone tree layout.
		/// - "Span Tree"     Span Tree Layout.
		/// Default is "Simple 2D".
		/// </summary>
		// Token: 0x0600135D RID: 4957 RVA: 0x0002186F File Offset: 0x0001FA6F
		public void SetLayoutStrategyToRandom()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetLayoutStrategyToRandom_91(base.GetCppThis());
		}

		// Token: 0x0600135E RID: 4958
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetLayoutStrategyToSimple2D_92(HandleRef pThis);

		/// <summary>
		/// The layout strategy to use when performing the graph layout.
		/// The possible strings are:
		/// - "Random"         Randomly places vertices in a box.
		/// - "Force Directed" A layout in 3D or 2D simulating forces on edges.
		/// - "Simple 2D"      A simple 2D force directed layout.
		/// - "Clustering 2D"  A 2D force directed layout that's just like
		/// simple 2D but uses some techniques to cluster better.
		/// - "Community 2D"   A linear-time 2D layout that's just like
		/// Fast 2D but looks for and uses a community
		/// array to 'accentuate' clusters.
		/// - "Fast 2D"       A linear-time 2D layout.
		/// - "Pass Through"  Use locations assigned to the input.
		/// - "Circular"      Places vertices uniformly on a circle.
		/// - "Cone"          Cone tree layout.
		/// - "Span Tree"     Span Tree Layout.
		/// Default is "Simple 2D".
		/// </summary>
		// Token: 0x0600135F RID: 4959 RVA: 0x0002187E File Offset: 0x0001FA7E
		public void SetLayoutStrategyToSimple2D()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetLayoutStrategyToSimple2D_92(base.GetCppThis());
		}

		// Token: 0x06001360 RID: 4960
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetLayoutStrategyToSpanTree_93(HandleRef pThis);

		/// <summary>
		/// The layout strategy to use when performing the graph layout.
		/// The possible strings are:
		/// - "Random"         Randomly places vertices in a box.
		/// - "Force Directed" A layout in 3D or 2D simulating forces on edges.
		/// - "Simple 2D"      A simple 2D force directed layout.
		/// - "Clustering 2D"  A 2D force directed layout that's just like
		/// simple 2D but uses some techniques to cluster better.
		/// - "Community 2D"   A linear-time 2D layout that's just like
		/// Fast 2D but looks for and uses a community
		/// array to 'accentuate' clusters.
		/// - "Fast 2D"       A linear-time 2D layout.
		/// - "Pass Through"  Use locations assigned to the input.
		/// - "Circular"      Places vertices uniformly on a circle.
		/// - "Cone"          Cone tree layout.
		/// - "Span Tree"     Span Tree Layout.
		/// Default is "Simple 2D".
		/// </summary>
		// Token: 0x06001361 RID: 4961 RVA: 0x0002188D File Offset: 0x0001FA8D
		public void SetLayoutStrategyToSpanTree()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetLayoutStrategyToSpanTree_93(base.GetCppThis());
		}

		// Token: 0x06001362 RID: 4962
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetLayoutStrategyToTree_94(HandleRef pThis);

		/// <summary>
		/// The layout strategy to use when performing the graph layout.
		/// The possible strings are:
		/// - "Random"         Randomly places vertices in a box.
		/// - "Force Directed" A layout in 3D or 2D simulating forces on edges.
		/// - "Simple 2D"      A simple 2D force directed layout.
		/// - "Clustering 2D"  A 2D force directed layout that's just like
		/// simple 2D but uses some techniques to cluster better.
		/// - "Community 2D"   A linear-time 2D layout that's just like
		/// Fast 2D but looks for and uses a community
		/// array to 'accentuate' clusters.
		/// - "Fast 2D"       A linear-time 2D layout.
		/// - "Pass Through"  Use locations assigned to the input.
		/// - "Circular"      Places vertices uniformly on a circle.
		/// - "Cone"          Cone tree layout.
		/// - "Span Tree"     Span Tree Layout.
		/// Default is "Simple 2D".
		/// </summary>
		// Token: 0x06001363 RID: 4963 RVA: 0x0002189C File Offset: 0x0001FA9C
		public void SetLayoutStrategyToTree()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetLayoutStrategyToTree_94(base.GetCppThis());
		}

		// Token: 0x06001364 RID: 4964
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetScaledGlyphs_95(HandleRef pThis, byte arg);

		/// <summary>
		/// Whether to use scaled glyphs or not.  Default is off.
		/// </summary>
		// Token: 0x06001365 RID: 4965 RVA: 0x000218AB File Offset: 0x0001FAAB
		public void SetScaledGlyphs(bool arg)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetScaledGlyphs_95(base.GetCppThis(), arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06001366 RID: 4966
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetScalingArrayName_96(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The array used for scaling (if ScaledGlyphs is ON)
		/// </summary>
		// Token: 0x06001367 RID: 4967 RVA: 0x000218C3 File Offset: 0x0001FAC3
		public void SetScalingArrayName(string name)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetScalingArrayName_96(base.GetCppThis(), name);
		}

		// Token: 0x06001368 RID: 4968
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetVertexColorArrayName_97(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The array to use for coloring vertices.  The default behavior
		/// is to color by vertex degree.
		/// </summary>
		// Token: 0x06001369 RID: 4969 RVA: 0x000218D3 File Offset: 0x0001FAD3
		public void SetVertexColorArrayName(string name)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetVertexColorArrayName_97(base.GetCppThis(), name);
		}

		// Token: 0x0600136A RID: 4970
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetVertexLabelArrayName_98(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The array to use for vertex labeling.  Default is "VertexDegree".
		/// </summary>
		// Token: 0x0600136B RID: 4971 RVA: 0x000218E3 File Offset: 0x0001FAE3
		public void SetVertexLabelArrayName(string name)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetVertexLabelArrayName_98(base.GetCppThis(), name);
		}

		// Token: 0x0600136C RID: 4972
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetVertexLabelFontSize_99(HandleRef pThis, int size);

		/// <summary>
		/// The size of the font used for vertex labeling
		/// </summary>
		// Token: 0x0600136D RID: 4973 RVA: 0x000218F3 File Offset: 0x0001FAF3
		public virtual void SetVertexLabelFontSize(int size)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetVertexLabelFontSize_99(base.GetCppThis(), size);
		}

		// Token: 0x0600136E RID: 4974
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetVertexLabelVisibility_100(HandleRef pThis, byte vis);

		/// <summary>
		/// Whether to show vertex labels.  Default is off.
		/// </summary>
		// Token: 0x0600136F RID: 4975 RVA: 0x00021903 File Offset: 0x0001FB03
		public void SetVertexLabelVisibility(bool vis)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetVertexLabelVisibility_100(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x06001370 RID: 4976
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_SetVertexScalarBarVisibility_101(HandleRef pThis, byte vis);

		/// <summary>
		/// Whether the scalar bar for vertices is visible.  Default is off.
		/// </summary>
		// Token: 0x06001371 RID: 4977 RVA: 0x0002191B File Offset: 0x0001FB1B
		public void SetVertexScalarBarVisibility(bool vis)
		{
			vtkGraphLayoutView.vtkGraphLayoutView_SetVertexScalarBarVisibility_101(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x06001372 RID: 4978
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_UpdateLayout_102(HandleRef pThis);

		/// <summary>
		/// This method is useful for when the strategy is iterative
		/// and the application wants to show the iterative progress
		/// of the graph layout. The application would have something like
		/// while(!IsLayoutComplete())
		/// {
		/// UpdateLayout();
		/// }
		/// See Also: IsLayoutComplete();
		/// </summary>
		// Token: 0x06001373 RID: 4979 RVA: 0x00021933 File Offset: 0x0001FB33
		public virtual void UpdateLayout()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_UpdateLayout_102(base.GetCppThis());
		}

		// Token: 0x06001374 RID: 4980
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_VertexLabelVisibilityOff_103(HandleRef pThis);

		/// <summary>
		/// Whether to show vertex labels.  Default is off.
		/// </summary>
		// Token: 0x06001375 RID: 4981 RVA: 0x00021942 File Offset: 0x0001FB42
		public virtual void VertexLabelVisibilityOff()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_VertexLabelVisibilityOff_103(base.GetCppThis());
		}

		// Token: 0x06001376 RID: 4982
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_VertexLabelVisibilityOn_104(HandleRef pThis);

		/// <summary>
		/// Whether to show vertex labels.  Default is off.
		/// </summary>
		// Token: 0x06001377 RID: 4983 RVA: 0x00021951 File Offset: 0x0001FB51
		public virtual void VertexLabelVisibilityOn()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_VertexLabelVisibilityOn_104(base.GetCppThis());
		}

		// Token: 0x06001378 RID: 4984
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutView_ZoomToSelection_105(HandleRef pThis);

		/// <summary>
		/// Reset the camera based on the bounds of the selected region.
		/// </summary>
		// Token: 0x06001379 RID: 4985 RVA: 0x00021960 File Offset: 0x0001FB60
		public void ZoomToSelection()
		{
			vtkGraphLayoutView.vtkGraphLayoutView_ZoomToSelection_105(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400045F RID: 1119
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphLayoutView";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000460 RID: 1120
		public new static readonly string MRClassNameKey = "class vtkGraphLayoutView";
	}
}
