using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTreeAreaView
	/// </summary>
	/// <remarks>
	///    Accepts a graph and a hierarchy - currently
	/// a tree - and provides a hierarchy-aware display.  Currently, this means
	/// displaying the hierarchy using a tree ring layout, then rendering the graph
	/// vertices as leaves of the tree with curved graph edges between leaves.
	///
	///
	/// Takes a graph and a hierarchy (currently a tree) and lays out the graph
	/// vertices based on their categorization within the hierarchy.
	///
	/// .SEE ALSO
	/// vtkGraphLayoutView
	///
	/// @par Thanks:
	/// Thanks to Jason Shepherd for implementing this class
	/// </remarks>
	// Token: 0x0200006F RID: 111
	public class vtkTreeAreaView : vtkRenderView
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600144E RID: 5198 RVA: 0x00022D19 File Offset: 0x00020F19
		static vtkTreeAreaView()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeAreaView.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeAreaView"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600144F RID: 5199 RVA: 0x00022D41 File Offset: 0x00020F41
		public vtkTreeAreaView(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06001450 RID: 5200
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeAreaView_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001451 RID: 5201 RVA: 0x00022D50 File Offset: 0x00020F50
		public new static vtkTreeAreaView New()
		{
			vtkTreeAreaView result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeAreaView.vtkTreeAreaView_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeAreaView)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001452 RID: 5202 RVA: 0x00022DA4 File Offset: 0x00020FA4
		public vtkTreeAreaView() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTreeAreaView.vtkTreeAreaView_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06001453 RID: 5203 RVA: 0x00022DE8 File Offset: 0x00020FE8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06001454 RID: 5204
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeAreaView_AreaLabelVisibilityOff_01(HandleRef pThis);

		/// <summary>
		/// Whether to show area labels.  Default is off.
		/// </summary>
		// Token: 0x06001455 RID: 5205 RVA: 0x00022DF3 File Offset: 0x00020FF3
		public virtual void AreaLabelVisibilityOff()
		{
			vtkTreeAreaView.vtkTreeAreaView_AreaLabelVisibilityOff_01(base.GetCppThis());
		}

		// Token: 0x06001456 RID: 5206
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeAreaView_AreaLabelVisibilityOn_02(HandleRef pThis);

		/// <summary>
		/// Whether to show area labels.  Default is off.
		/// </summary>
		// Token: 0x06001457 RID: 5207 RVA: 0x00022E02 File Offset: 0x00021002
		public virtual void AreaLabelVisibilityOn()
		{
			vtkTreeAreaView.vtkTreeAreaView_AreaLabelVisibilityOn_02(base.GetCppThis());
		}

		// Token: 0x06001458 RID: 5208
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeAreaView_ColorAreasOff_03(HandleRef pThis);

		/// <summary>
		/// Whether to color vertices.  Default is off.
		/// </summary>
		// Token: 0x06001459 RID: 5209 RVA: 0x00022E11 File Offset: 0x00021011
		public virtual void ColorAreasOff()
		{
			vtkTreeAreaView.vtkTreeAreaView_ColorAreasOff_03(base.GetCppThis());
		}

		// Token: 0x0600145A RID: 5210
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeAreaView_ColorAreasOn_04(HandleRef pThis);

		/// <summary>
		/// Whether to color vertices.  Default is off.
		/// </summary>
		// Token: 0x0600145B RID: 5211 RVA: 0x00022E20 File Offset: 0x00021020
		public virtual void ColorAreasOn()
		{
			vtkTreeAreaView.vtkTreeAreaView_ColorAreasOn_04(base.GetCppThis());
		}

		// Token: 0x0600145C RID: 5212
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeAreaView_ColorEdgesOff_05(HandleRef pThis);

		/// <summary>
		/// Whether to color edges.  Default is off.
		/// </summary>
		// Token: 0x0600145D RID: 5213 RVA: 0x00022E2F File Offset: 0x0002102F
		public virtual void ColorEdgesOff()
		{
			vtkTreeAreaView.vtkTreeAreaView_ColorEdgesOff_05(base.GetCppThis());
		}

		// Token: 0x0600145E RID: 5214
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeAreaView_ColorEdgesOn_06(HandleRef pThis);

		/// <summary>
		/// Whether to color edges.  Default is off.
		/// </summary>
		// Token: 0x0600145F RID: 5215 RVA: 0x00022E3E File Offset: 0x0002103E
		public virtual void ColorEdgesOn()
		{
			vtkTreeAreaView.vtkTreeAreaView_ColorEdgesOn_06(base.GetCppThis());
		}

		// Token: 0x06001460 RID: 5216
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeAreaView_EdgeLabelVisibilityOff_07(HandleRef pThis);

		/// <summary>
		/// Whether to show edge labels.  Default is off.
		/// </summary>
		// Token: 0x06001461 RID: 5217 RVA: 0x00022E4D File Offset: 0x0002104D
		public virtual void EdgeLabelVisibilityOff()
		{
			vtkTreeAreaView.vtkTreeAreaView_EdgeLabelVisibilityOff_07(base.GetCppThis());
		}

		// Token: 0x06001462 RID: 5218
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeAreaView_EdgeLabelVisibilityOn_08(HandleRef pThis);

		/// <summary>
		/// Whether to show edge labels.  Default is off.
		/// </summary>
		// Token: 0x06001463 RID: 5219 RVA: 0x00022E5C File Offset: 0x0002105C
		public virtual void EdgeLabelVisibilityOn()
		{
			vtkTreeAreaView.vtkTreeAreaView_EdgeLabelVisibilityOn_08(base.GetCppThis());
		}

		// Token: 0x06001464 RID: 5220
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeAreaView_GetAreaColorArrayName_09(HandleRef pThis);

		/// <summary>
		/// The array to use for coloring vertices.  Default is "color".
		/// </summary>
		// Token: 0x06001465 RID: 5221 RVA: 0x00022E6C File Offset: 0x0002106C
		public string GetAreaColorArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkTreeAreaView.vtkTreeAreaView_GetAreaColorArrayName_09(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001466 RID: 5222
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeAreaView_GetAreaHoverArrayName_10(HandleRef pThis);

		/// <summary>
		/// The name of the array whose value appears when the mouse hovers
		/// over a rectangle in the treemap.
		/// This must be a string array.
		/// </summary>
		// Token: 0x06001467 RID: 5223 RVA: 0x00022EA8 File Offset: 0x000210A8
		public string GetAreaHoverArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkTreeAreaView.vtkTreeAreaView_GetAreaHoverArrayName_10(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001468 RID: 5224
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeAreaView_GetAreaLabelArrayName_11(HandleRef pThis);

		/// <summary>
		/// The array to use for area labeling.  Default is "label".
		/// </summary>
		// Token: 0x06001469 RID: 5225 RVA: 0x00022EE4 File Offset: 0x000210E4
		public string GetAreaLabelArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkTreeAreaView.vtkTreeAreaView_GetAreaLabelArrayName_11(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600146A RID: 5226
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeAreaView_GetAreaLabelFontSize_12(HandleRef pThis);

		/// <summary>
		/// The size of the font used for area labeling
		/// </summary>
		// Token: 0x0600146B RID: 5227 RVA: 0x00022F20 File Offset: 0x00021120
		public virtual int GetAreaLabelFontSize()
		{
			return vtkTreeAreaView.vtkTreeAreaView_GetAreaLabelFontSize_12(base.GetCppThis());
		}

		// Token: 0x0600146C RID: 5228
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTreeAreaView_GetAreaLabelVisibility_13(HandleRef pThis);

		/// <summary>
		/// Whether to show area labels.  Default is off.
		/// </summary>
		// Token: 0x0600146D RID: 5229 RVA: 0x00022F40 File Offset: 0x00021140
		public bool GetAreaLabelVisibility()
		{
			return vtkTreeAreaView.vtkTreeAreaView_GetAreaLabelVisibility_13(base.GetCppThis()) != 0;
		}

		// Token: 0x0600146E RID: 5230
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeAreaView_GetAreaSizeArrayName_14(HandleRef pThis);

		/// <summary>
		/// The array to use for area sizes. Default is "size".
		/// </summary>
		// Token: 0x0600146F RID: 5231 RVA: 0x00022F68 File Offset: 0x00021168
		public string GetAreaSizeArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkTreeAreaView.vtkTreeAreaView_GetAreaSizeArrayName_14(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001470 RID: 5232
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTreeAreaView_GetBundlingStrength_15(HandleRef pThis);

		/// <summary>
		/// Set the bundling strength.
		/// </summary>
		// Token: 0x06001471 RID: 5233 RVA: 0x00022FA4 File Offset: 0x000211A4
		public double GetBundlingStrength()
		{
			return vtkTreeAreaView.vtkTreeAreaView_GetBundlingStrength_15(base.GetCppThis());
		}

		// Token: 0x06001472 RID: 5234
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTreeAreaView_GetColorAreas_16(HandleRef pThis);

		/// <summary>
		/// Whether to color vertices.  Default is off.
		/// </summary>
		// Token: 0x06001473 RID: 5235 RVA: 0x00022FC4 File Offset: 0x000211C4
		public bool GetColorAreas()
		{
			return vtkTreeAreaView.vtkTreeAreaView_GetColorAreas_16(base.GetCppThis()) != 0;
		}

		// Token: 0x06001474 RID: 5236
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTreeAreaView_GetColorEdges_17(HandleRef pThis);

		/// <summary>
		/// Whether to color edges.  Default is off.
		/// </summary>
		// Token: 0x06001475 RID: 5237 RVA: 0x00022FEC File Offset: 0x000211EC
		public bool GetColorEdges()
		{
			return vtkTreeAreaView.vtkTreeAreaView_GetColorEdges_17(base.GetCppThis()) != 0;
		}

		// Token: 0x06001476 RID: 5238
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeAreaView_GetEdgeColorArrayName_18(HandleRef pThis);

		/// <summary>
		/// The array to use for coloring edges.  Default is "color".
		/// </summary>
		// Token: 0x06001477 RID: 5239 RVA: 0x00023014 File Offset: 0x00021214
		public string GetEdgeColorArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkTreeAreaView.vtkTreeAreaView_GetEdgeColorArrayName_18(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001478 RID: 5240
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeAreaView_GetEdgeLabelArrayName_19(HandleRef pThis);

		/// <summary>
		/// The array to use for edge labeling.  Default is "label".
		/// </summary>
		// Token: 0x06001479 RID: 5241 RVA: 0x00023050 File Offset: 0x00021250
		public string GetEdgeLabelArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkTreeAreaView.vtkTreeAreaView_GetEdgeLabelArrayName_19(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600147A RID: 5242
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeAreaView_GetEdgeLabelFontSize_20(HandleRef pThis);

		/// <summary>
		/// The size of the font used for edge labeling
		/// </summary>
		// Token: 0x0600147B RID: 5243 RVA: 0x0002308C File Offset: 0x0002128C
		public virtual int GetEdgeLabelFontSize()
		{
			return vtkTreeAreaView.vtkTreeAreaView_GetEdgeLabelFontSize_20(base.GetCppThis());
		}

		// Token: 0x0600147C RID: 5244
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTreeAreaView_GetEdgeLabelVisibility_21(HandleRef pThis);

		/// <summary>
		/// Whether to show edge labels.  Default is off.
		/// </summary>
		// Token: 0x0600147D RID: 5245 RVA: 0x000230AC File Offset: 0x000212AC
		public bool GetEdgeLabelVisibility()
		{
			return vtkTreeAreaView.vtkTreeAreaView_GetEdgeLabelVisibility_21(base.GetCppThis()) != 0;
		}

		// Token: 0x0600147E RID: 5246
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTreeAreaView_GetEdgeScalarBarVisibility_22(HandleRef pThis);

		/// <summary>
		/// Visibility of scalar bar actor for edges.
		/// </summary>
		// Token: 0x0600147F RID: 5247 RVA: 0x000230D4 File Offset: 0x000212D4
		public virtual bool GetEdgeScalarBarVisibility()
		{
			return vtkTreeAreaView.vtkTreeAreaView_GetEdgeScalarBarVisibility_22(base.GetCppThis()) != 0;
		}

		// Token: 0x06001480 RID: 5248
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeAreaView_GetLabelPriorityArrayName_23(HandleRef pThis);

		/// <summary>
		/// The array to use for area labeling priority.
		/// Default is "GraphVertexDegree".
		/// </summary>
		// Token: 0x06001481 RID: 5249 RVA: 0x000230FC File Offset: 0x000212FC
		public string GetLabelPriorityArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkTreeAreaView.vtkTreeAreaView_GetLabelPriorityArrayName_23(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001482 RID: 5250
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeAreaView_GetLayoutStrategy_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The layout strategy for producing spatial regions for the tree.
		/// </summary>
		// Token: 0x06001483 RID: 5251 RVA: 0x00023138 File Offset: 0x00021338
		public virtual vtkAreaLayoutStrategy GetLayoutStrategy()
		{
			vtkAreaLayoutStrategy vtkAreaLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeAreaView.vtkTreeAreaView_GetLayoutStrategy_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAreaLayoutStrategy = (vtkAreaLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAreaLayoutStrategy.Register(null);
				}
			}
			return vtkAreaLayoutStrategy;
		}

		// Token: 0x06001484 RID: 5252
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeAreaView_GetNumberOfGenerationsFromBase_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001485 RID: 5253 RVA: 0x000231A8 File Offset: 0x000213A8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTreeAreaView.vtkTreeAreaView_GetNumberOfGenerationsFromBase_25(base.GetCppThis(), type);
		}

		// Token: 0x06001486 RID: 5254
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeAreaView_GetNumberOfGenerationsFromBaseType_26([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001487 RID: 5255 RVA: 0x000231C8 File Offset: 0x000213C8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTreeAreaView.vtkTreeAreaView_GetNumberOfGenerationsFromBaseType_26(type);
		}

		// Token: 0x06001488 RID: 5256
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTreeAreaView_GetShrinkPercentage_27(HandleRef pThis);

		/// <summary>
		/// Set the region shrink percentage between 0.0 and 1.0.
		/// </summary>
		// Token: 0x06001489 RID: 5257 RVA: 0x000231E4 File Offset: 0x000213E4
		public double GetShrinkPercentage()
		{
			return vtkTreeAreaView.vtkTreeAreaView_GetShrinkPercentage_27(base.GetCppThis());
		}

		// Token: 0x0600148A RID: 5258
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTreeAreaView_GetUseRectangularCoordinates_28(HandleRef pThis);

		/// <summary>
		/// Whether the area represents radial or rectangular coordinates.
		/// </summary>
		// Token: 0x0600148B RID: 5259 RVA: 0x00023204 File Offset: 0x00021404
		public virtual bool GetUseRectangularCoordinates()
		{
			return vtkTreeAreaView.vtkTreeAreaView_GetUseRectangularCoordinates_28(base.GetCppThis()) != 0;
		}

		// Token: 0x0600148C RID: 5260
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeAreaView_IsA_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600148D RID: 5261 RVA: 0x0002322C File Offset: 0x0002142C
		public override int IsA(string type)
		{
			return vtkTreeAreaView.vtkTreeAreaView_IsA_29(base.GetCppThis(), type);
		}

		// Token: 0x0600148E RID: 5262
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeAreaView_IsTypeOf_30([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600148F RID: 5263 RVA: 0x0002324C File Offset: 0x0002144C
		public new static int IsTypeOf(string type)
		{
			return vtkTreeAreaView.vtkTreeAreaView_IsTypeOf_30(type);
		}

		// Token: 0x06001490 RID: 5264
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeAreaView_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001491 RID: 5265 RVA: 0x00023268 File Offset: 0x00021468
		public new vtkTreeAreaView NewInstance()
		{
			vtkTreeAreaView result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeAreaView.vtkTreeAreaView_NewInstance_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeAreaView)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001492 RID: 5266
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeAreaView_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001493 RID: 5267 RVA: 0x000232C4 File Offset: 0x000214C4
		public new static vtkTreeAreaView SafeDownCast(vtkObjectBase o)
		{
			vtkTreeAreaView vtkTreeAreaView = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeAreaView.vtkTreeAreaView_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeAreaView = (vtkTreeAreaView)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeAreaView.Register(null);
				}
			}
			return vtkTreeAreaView;
		}

		// Token: 0x06001494 RID: 5268
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeAreaView_SetAreaColorArrayName_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The array to use for coloring vertices.  Default is "color".
		/// </summary>
		// Token: 0x06001495 RID: 5269 RVA: 0x00023343 File Offset: 0x00021543
		public void SetAreaColorArrayName(string name)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetAreaColorArrayName_34(base.GetCppThis(), name);
		}

		// Token: 0x06001496 RID: 5270
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeAreaView_SetAreaHoverArrayName_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The name of the array whose value appears when the mouse hovers
		/// over a rectangle in the treemap.
		/// This must be a string array.
		/// </summary>
		// Token: 0x06001497 RID: 5271 RVA: 0x00023353 File Offset: 0x00021553
		public void SetAreaHoverArrayName(string name)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetAreaHoverArrayName_35(base.GetCppThis(), name);
		}

		// Token: 0x06001498 RID: 5272
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeAreaView_SetAreaLabelArrayName_36(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The array to use for area labeling.  Default is "label".
		/// </summary>
		// Token: 0x06001499 RID: 5273 RVA: 0x00023363 File Offset: 0x00021563
		public void SetAreaLabelArrayName(string name)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetAreaLabelArrayName_36(base.GetCppThis(), name);
		}

		// Token: 0x0600149A RID: 5274
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeAreaView_SetAreaLabelFontSize_37(HandleRef pThis, int size);

		/// <summary>
		/// The size of the font used for area labeling
		/// </summary>
		// Token: 0x0600149B RID: 5275 RVA: 0x00023373 File Offset: 0x00021573
		public virtual void SetAreaLabelFontSize(int size)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetAreaLabelFontSize_37(base.GetCppThis(), size);
		}

		// Token: 0x0600149C RID: 5276
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeAreaView_SetAreaLabelVisibility_38(HandleRef pThis, byte vis);

		/// <summary>
		/// Whether to show area labels.  Default is off.
		/// </summary>
		// Token: 0x0600149D RID: 5277 RVA: 0x00023383 File Offset: 0x00021583
		public void SetAreaLabelVisibility(bool vis)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetAreaLabelVisibility_38(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x0600149E RID: 5278
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeAreaView_SetAreaSizeArrayName_39(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The array to use for area sizes. Default is "size".
		/// </summary>
		// Token: 0x0600149F RID: 5279 RVA: 0x0002339B File Offset: 0x0002159B
		public void SetAreaSizeArrayName(string name)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetAreaSizeArrayName_39(base.GetCppThis(), name);
		}

		// Token: 0x060014A0 RID: 5280
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeAreaView_SetBundlingStrength_40(HandleRef pThis, double strength);

		/// <summary>
		/// Set the bundling strength.
		/// </summary>
		// Token: 0x060014A1 RID: 5281 RVA: 0x000233AB File Offset: 0x000215AB
		public void SetBundlingStrength(double strength)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetBundlingStrength_40(base.GetCppThis(), strength);
		}

		// Token: 0x060014A2 RID: 5282
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeAreaView_SetColorAreas_41(HandleRef pThis, byte vis);

		/// <summary>
		/// Whether to color vertices.  Default is off.
		/// </summary>
		// Token: 0x060014A3 RID: 5283 RVA: 0x000233BB File Offset: 0x000215BB
		public void SetColorAreas(bool vis)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetColorAreas_41(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x060014A4 RID: 5284
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeAreaView_SetColorEdges_42(HandleRef pThis, byte vis);

		/// <summary>
		/// Whether to color edges.  Default is off.
		/// </summary>
		// Token: 0x060014A5 RID: 5285 RVA: 0x000233D3 File Offset: 0x000215D3
		public void SetColorEdges(bool vis)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetColorEdges_42(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x060014A6 RID: 5286
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeAreaView_SetEdgeColorArrayName_43(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The array to use for coloring edges.  Default is "color".
		/// </summary>
		// Token: 0x060014A7 RID: 5287 RVA: 0x000233EB File Offset: 0x000215EB
		public void SetEdgeColorArrayName(string name)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetEdgeColorArrayName_43(base.GetCppThis(), name);
		}

		// Token: 0x060014A8 RID: 5288
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeAreaView_SetEdgeColorToSplineFraction_44(HandleRef pThis);

		/// <summary>
		/// Set the color to be the spline fraction
		/// </summary>
		// Token: 0x060014A9 RID: 5289 RVA: 0x000233FB File Offset: 0x000215FB
		public void SetEdgeColorToSplineFraction()
		{
			vtkTreeAreaView.vtkTreeAreaView_SetEdgeColorToSplineFraction_44(base.GetCppThis());
		}

		// Token: 0x060014AA RID: 5290
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeAreaView_SetEdgeLabelArrayName_45(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The array to use for edge labeling.  Default is "label".
		/// </summary>
		// Token: 0x060014AB RID: 5291 RVA: 0x0002340A File Offset: 0x0002160A
		public void SetEdgeLabelArrayName(string name)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetEdgeLabelArrayName_45(base.GetCppThis(), name);
		}

		// Token: 0x060014AC RID: 5292
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeAreaView_SetEdgeLabelFontSize_46(HandleRef pThis, int size);

		/// <summary>
		/// The size of the font used for edge labeling
		/// </summary>
		// Token: 0x060014AD RID: 5293 RVA: 0x0002341A File Offset: 0x0002161A
		public virtual void SetEdgeLabelFontSize(int size)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetEdgeLabelFontSize_46(base.GetCppThis(), size);
		}

		// Token: 0x060014AE RID: 5294
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeAreaView_SetEdgeLabelVisibility_47(HandleRef pThis, byte vis);

		/// <summary>
		/// Whether to show edge labels.  Default is off.
		/// </summary>
		// Token: 0x060014AF RID: 5295 RVA: 0x0002342A File Offset: 0x0002162A
		public void SetEdgeLabelVisibility(bool vis)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetEdgeLabelVisibility_47(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x060014B0 RID: 5296
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeAreaView_SetEdgeScalarBarVisibility_48(HandleRef pThis, byte b);

		/// <summary>
		/// Visibility of scalar bar actor for edges.
		/// </summary>
		// Token: 0x060014B1 RID: 5297 RVA: 0x00023442 File Offset: 0x00021642
		public virtual void SetEdgeScalarBarVisibility(bool b)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetEdgeScalarBarVisibility_48(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		// Token: 0x060014B2 RID: 5298
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeAreaView_SetGraphFromInput_49(HandleRef pThis, HandleRef input, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the tree and graph representations to the appropriate input ports.
		/// </summary>
		// Token: 0x060014B3 RID: 5299 RVA: 0x0002345C File Offset: 0x0002165C
		public vtkDataRepresentation SetGraphFromInput(vtkGraph input)
		{
			vtkDataRepresentation vtkDataRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeAreaView.vtkTreeAreaView_SetGraphFromInput_49(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataRepresentation = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataRepresentation.Register(null);
				}
			}
			return vtkDataRepresentation;
		}

		// Token: 0x060014B4 RID: 5300
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeAreaView_SetGraphFromInputConnection_50(HandleRef pThis, HandleRef conn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the tree and graph representations to the appropriate input ports.
		/// </summary>
		// Token: 0x060014B5 RID: 5301 RVA: 0x000234E4 File Offset: 0x000216E4
		public vtkDataRepresentation SetGraphFromInputConnection(vtkAlgorithmOutput conn)
		{
			vtkDataRepresentation vtkDataRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeAreaView.vtkTreeAreaView_SetGraphFromInputConnection_50(base.GetCppThis(), (conn == null) ? default(HandleRef) : conn.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataRepresentation = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataRepresentation.Register(null);
				}
			}
			return vtkDataRepresentation;
		}

		// Token: 0x060014B6 RID: 5302
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeAreaView_SetLabelPriorityArrayName_51(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The array to use for area labeling priority.
		/// Default is "GraphVertexDegree".
		/// </summary>
		// Token: 0x060014B7 RID: 5303 RVA: 0x00023569 File Offset: 0x00021769
		public void SetLabelPriorityArrayName(string name)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetLabelPriorityArrayName_51(base.GetCppThis(), name);
		}

		// Token: 0x060014B8 RID: 5304
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeAreaView_SetLayoutStrategy_52(HandleRef pThis, HandleRef strategy);

		/// <summary>
		/// The layout strategy for producing spatial regions for the tree.
		/// </summary>
		// Token: 0x060014B9 RID: 5305 RVA: 0x0002357C File Offset: 0x0002177C
		public virtual void SetLayoutStrategy(vtkAreaLayoutStrategy strategy)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetLayoutStrategy_52(base.GetCppThis(), (strategy == null) ? default(HandleRef) : strategy.GetCppThis());
		}

		// Token: 0x060014BA RID: 5306
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeAreaView_SetShrinkPercentage_53(HandleRef pThis, double value);

		/// <summary>
		/// Set the region shrink percentage between 0.0 and 1.0.
		/// </summary>
		// Token: 0x060014BB RID: 5307 RVA: 0x000235AB File Offset: 0x000217AB
		public void SetShrinkPercentage(double value)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetShrinkPercentage_53(base.GetCppThis(), value);
		}

		// Token: 0x060014BC RID: 5308
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeAreaView_SetTreeFromInput_54(HandleRef pThis, HandleRef input, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the tree and graph representations to the appropriate input ports.
		/// </summary>
		// Token: 0x060014BD RID: 5309 RVA: 0x000235BC File Offset: 0x000217BC
		public vtkDataRepresentation SetTreeFromInput(vtkTree input)
		{
			vtkDataRepresentation vtkDataRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeAreaView.vtkTreeAreaView_SetTreeFromInput_54(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataRepresentation = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataRepresentation.Register(null);
				}
			}
			return vtkDataRepresentation;
		}

		// Token: 0x060014BE RID: 5310
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeAreaView_SetTreeFromInputConnection_55(HandleRef pThis, HandleRef conn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the tree and graph representations to the appropriate input ports.
		/// </summary>
		// Token: 0x060014BF RID: 5311 RVA: 0x00023644 File Offset: 0x00021844
		public vtkDataRepresentation SetTreeFromInputConnection(vtkAlgorithmOutput conn)
		{
			vtkDataRepresentation vtkDataRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeAreaView.vtkTreeAreaView_SetTreeFromInputConnection_55(base.GetCppThis(), (conn == null) ? default(HandleRef) : conn.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataRepresentation = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataRepresentation.Register(null);
				}
			}
			return vtkDataRepresentation;
		}

		// Token: 0x060014C0 RID: 5312
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeAreaView_SetUseRectangularCoordinates_56(HandleRef pThis, byte rect);

		/// <summary>
		/// Whether the area represents radial or rectangular coordinates.
		/// </summary>
		// Token: 0x060014C1 RID: 5313 RVA: 0x000236C9 File Offset: 0x000218C9
		public virtual void SetUseRectangularCoordinates(bool rect)
		{
			vtkTreeAreaView.vtkTreeAreaView_SetUseRectangularCoordinates_56(base.GetCppThis(), rect ? (byte)1 : (byte)0);
		}

		// Token: 0x060014C2 RID: 5314
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeAreaView_UseRectangularCoordinatesOff_57(HandleRef pThis);

		/// <summary>
		/// Whether the area represents radial or rectangular coordinates.
		/// </summary>
		// Token: 0x060014C3 RID: 5315 RVA: 0x000236E1 File Offset: 0x000218E1
		public virtual void UseRectangularCoordinatesOff()
		{
			vtkTreeAreaView.vtkTreeAreaView_UseRectangularCoordinatesOff_57(base.GetCppThis());
		}

		// Token: 0x060014C4 RID: 5316
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeAreaView_UseRectangularCoordinatesOn_58(HandleRef pThis);

		/// <summary>
		/// Whether the area represents radial or rectangular coordinates.
		/// </summary>
		// Token: 0x060014C5 RID: 5317 RVA: 0x000236F0 File Offset: 0x000218F0
		public virtual void UseRectangularCoordinatesOn()
		{
			vtkTreeAreaView.vtkTreeAreaView_UseRectangularCoordinatesOn_58(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400046C RID: 1132
		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeAreaView";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400046D RID: 1133
		public new static readonly string MRClassNameKey = "class vtkTreeAreaView";
	}
}
