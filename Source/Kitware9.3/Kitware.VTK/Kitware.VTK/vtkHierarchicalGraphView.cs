using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHierarchicalGraphView
	/// </summary>
	/// <remarks>
	///    Accepts a graph and a hierarchy - currently
	/// a tree - and provides a hierarchy-aware display.  Currently, this means
	/// displaying the hierarchy using a tree layout, then rendering the graph
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
	/// Thanks to the turtle with jets for feet, without you this class wouldn't
	/// have been possible.
	/// </remarks>
	// Token: 0x0200006E RID: 110
	public class vtkHierarchicalGraphView : vtkGraphLayoutView
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600140A RID: 5130 RVA: 0x000226A9 File Offset: 0x000208A9
		static vtkHierarchicalGraphView()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHierarchicalGraphView.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHierarchicalGraphView"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600140B RID: 5131 RVA: 0x000226D1 File Offset: 0x000208D1
		public vtkHierarchicalGraphView(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600140C RID: 5132
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalGraphView_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600140D RID: 5133 RVA: 0x000226E0 File Offset: 0x000208E0
		public new static vtkHierarchicalGraphView New()
		{
			vtkHierarchicalGraphView result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalGraphView.vtkHierarchicalGraphView_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalGraphView)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600140E RID: 5134 RVA: 0x00022734 File Offset: 0x00020934
		public vtkHierarchicalGraphView() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHierarchicalGraphView.vtkHierarchicalGraphView_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600140F RID: 5135 RVA: 0x00022778 File Offset: 0x00020978
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06001410 RID: 5136
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphView_ColorGraphEdgesByArrayOff_01(HandleRef pThis);

		/// <summary>
		/// Whether to color edges.  Default is off.
		/// </summary>
		// Token: 0x06001411 RID: 5137 RVA: 0x00022783 File Offset: 0x00020983
		public virtual void ColorGraphEdgesByArrayOff()
		{
			vtkHierarchicalGraphView.vtkHierarchicalGraphView_ColorGraphEdgesByArrayOff_01(base.GetCppThis());
		}

		// Token: 0x06001412 RID: 5138
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphView_ColorGraphEdgesByArrayOn_02(HandleRef pThis);

		/// <summary>
		/// Whether to color edges.  Default is off.
		/// </summary>
		// Token: 0x06001413 RID: 5139 RVA: 0x00022792 File Offset: 0x00020992
		public virtual void ColorGraphEdgesByArrayOn()
		{
			vtkHierarchicalGraphView.vtkHierarchicalGraphView_ColorGraphEdgesByArrayOn_02(base.GetCppThis());
		}

		// Token: 0x06001414 RID: 5140
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHierarchicalGraphView_GetBundlingStrength_03(HandleRef pThis);

		/// <summary>
		/// Set the bundling strength.
		/// </summary>
		// Token: 0x06001415 RID: 5141 RVA: 0x000227A4 File Offset: 0x000209A4
		public virtual double GetBundlingStrength()
		{
			return vtkHierarchicalGraphView.vtkHierarchicalGraphView_GetBundlingStrength_03(base.GetCppThis());
		}

		// Token: 0x06001416 RID: 5142
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHierarchicalGraphView_GetColorGraphEdgesByArray_04(HandleRef pThis);

		/// <summary>
		/// Whether to color edges.  Default is off.
		/// </summary>
		// Token: 0x06001417 RID: 5143 RVA: 0x000227C4 File Offset: 0x000209C4
		public virtual bool GetColorGraphEdgesByArray()
		{
			return vtkHierarchicalGraphView.vtkHierarchicalGraphView_GetColorGraphEdgesByArray_04(base.GetCppThis()) != 0;
		}

		// Token: 0x06001418 RID: 5144
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalGraphView_GetGraphEdgeColorArrayName_05(HandleRef pThis);

		/// <summary>
		/// The array to use for coloring edges.  Default is "color".
		/// </summary>
		// Token: 0x06001419 RID: 5145 RVA: 0x000227EC File Offset: 0x000209EC
		public virtual string GetGraphEdgeColorArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkHierarchicalGraphView.vtkHierarchicalGraphView_GetGraphEdgeColorArrayName_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600141A RID: 5146
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalGraphView_GetGraphEdgeLabelArrayName_06(HandleRef pThis);

		/// <summary>
		/// The array to use for edge labeling.  Default is "label".
		/// </summary>
		// Token: 0x0600141B RID: 5147 RVA: 0x00022828 File Offset: 0x00020A28
		public virtual string GetGraphEdgeLabelArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkHierarchicalGraphView.vtkHierarchicalGraphView_GetGraphEdgeLabelArrayName_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600141C RID: 5148
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHierarchicalGraphView_GetGraphEdgeLabelFontSize_07(HandleRef pThis);

		/// <summary>
		/// The size of the font used for edge labeling
		/// </summary>
		// Token: 0x0600141D RID: 5149 RVA: 0x00022864 File Offset: 0x00020A64
		public virtual int GetGraphEdgeLabelFontSize()
		{
			return vtkHierarchicalGraphView.vtkHierarchicalGraphView_GetGraphEdgeLabelFontSize_07(base.GetCppThis());
		}

		// Token: 0x0600141E RID: 5150
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHierarchicalGraphView_GetGraphEdgeLabelVisibility_08(HandleRef pThis);

		/// <summary>
		/// Whether to show edge labels.  Default is off.
		/// </summary>
		// Token: 0x0600141F RID: 5151 RVA: 0x00022884 File Offset: 0x00020A84
		public virtual bool GetGraphEdgeLabelVisibility()
		{
			return vtkHierarchicalGraphView.vtkHierarchicalGraphView_GetGraphEdgeLabelVisibility_08(base.GetCppThis()) != 0;
		}

		// Token: 0x06001420 RID: 5152
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHierarchicalGraphView_GetGraphVisibility_09(HandleRef pThis);

		/// <summary>
		/// Whether the graph edges are visible (default off).
		/// </summary>
		// Token: 0x06001421 RID: 5153 RVA: 0x000228AC File Offset: 0x00020AAC
		public virtual bool GetGraphVisibility()
		{
			return vtkHierarchicalGraphView.vtkHierarchicalGraphView_GetGraphVisibility_09(base.GetCppThis()) != 0;
		}

		// Token: 0x06001422 RID: 5154
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHierarchicalGraphView_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001423 RID: 5155 RVA: 0x000228D4 File Offset: 0x00020AD4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHierarchicalGraphView.vtkHierarchicalGraphView_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x06001424 RID: 5156
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHierarchicalGraphView_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001425 RID: 5157 RVA: 0x000228F4 File Offset: 0x00020AF4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHierarchicalGraphView.vtkHierarchicalGraphView_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x06001426 RID: 5158
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphView_GraphEdgeLabelVisibilityOff_12(HandleRef pThis);

		/// <summary>
		/// Whether to show edge labels.  Default is off.
		/// </summary>
		// Token: 0x06001427 RID: 5159 RVA: 0x0002290E File Offset: 0x00020B0E
		public virtual void GraphEdgeLabelVisibilityOff()
		{
			vtkHierarchicalGraphView.vtkHierarchicalGraphView_GraphEdgeLabelVisibilityOff_12(base.GetCppThis());
		}

		// Token: 0x06001428 RID: 5160
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphView_GraphEdgeLabelVisibilityOn_13(HandleRef pThis);

		/// <summary>
		/// Whether to show edge labels.  Default is off.
		/// </summary>
		// Token: 0x06001429 RID: 5161 RVA: 0x0002291D File Offset: 0x00020B1D
		public virtual void GraphEdgeLabelVisibilityOn()
		{
			vtkHierarchicalGraphView.vtkHierarchicalGraphView_GraphEdgeLabelVisibilityOn_13(base.GetCppThis());
		}

		// Token: 0x0600142A RID: 5162
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphView_GraphVisibilityOff_14(HandleRef pThis);

		/// <summary>
		/// Whether the graph edges are visible (default off).
		/// </summary>
		// Token: 0x0600142B RID: 5163 RVA: 0x0002292C File Offset: 0x00020B2C
		public virtual void GraphVisibilityOff()
		{
			vtkHierarchicalGraphView.vtkHierarchicalGraphView_GraphVisibilityOff_14(base.GetCppThis());
		}

		// Token: 0x0600142C RID: 5164
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphView_GraphVisibilityOn_15(HandleRef pThis);

		/// <summary>
		/// Whether the graph edges are visible (default off).
		/// </summary>
		// Token: 0x0600142D RID: 5165 RVA: 0x0002293B File Offset: 0x00020B3B
		public virtual void GraphVisibilityOn()
		{
			vtkHierarchicalGraphView.vtkHierarchicalGraphView_GraphVisibilityOn_15(base.GetCppThis());
		}

		// Token: 0x0600142E RID: 5166
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHierarchicalGraphView_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600142F RID: 5167 RVA: 0x0002294C File Offset: 0x00020B4C
		public override int IsA(string type)
		{
			return vtkHierarchicalGraphView.vtkHierarchicalGraphView_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x06001430 RID: 5168
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHierarchicalGraphView_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001431 RID: 5169 RVA: 0x0002296C File Offset: 0x00020B6C
		public new static int IsTypeOf(string type)
		{
			return vtkHierarchicalGraphView.vtkHierarchicalGraphView_IsTypeOf_17(type);
		}

		// Token: 0x06001432 RID: 5170
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalGraphView_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001433 RID: 5171 RVA: 0x00022988 File Offset: 0x00020B88
		public new vtkHierarchicalGraphView NewInstance()
		{
			vtkHierarchicalGraphView result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalGraphView.vtkHierarchicalGraphView_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalGraphView)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001434 RID: 5172
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalGraphView_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001435 RID: 5173 RVA: 0x000229E4 File Offset: 0x00020BE4
		public new static vtkHierarchicalGraphView SafeDownCast(vtkObjectBase o)
		{
			vtkHierarchicalGraphView vtkHierarchicalGraphView = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalGraphView.vtkHierarchicalGraphView_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHierarchicalGraphView = (vtkHierarchicalGraphView)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHierarchicalGraphView.Register(null);
				}
			}
			return vtkHierarchicalGraphView;
		}

		// Token: 0x06001436 RID: 5174
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphView_SetBundlingStrength_21(HandleRef pThis, double strength);

		/// <summary>
		/// Set the bundling strength.
		/// </summary>
		// Token: 0x06001437 RID: 5175 RVA: 0x00022A63 File Offset: 0x00020C63
		public virtual void SetBundlingStrength(double strength)
		{
			vtkHierarchicalGraphView.vtkHierarchicalGraphView_SetBundlingStrength_21(base.GetCppThis(), strength);
		}

		// Token: 0x06001438 RID: 5176
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphView_SetColorGraphEdgesByArray_22(HandleRef pThis, byte vis);

		/// <summary>
		/// Whether to color edges.  Default is off.
		/// </summary>
		// Token: 0x06001439 RID: 5177 RVA: 0x00022A73 File Offset: 0x00020C73
		public virtual void SetColorGraphEdgesByArray(bool vis)
		{
			vtkHierarchicalGraphView.vtkHierarchicalGraphView_SetColorGraphEdgesByArray_22(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x0600143A RID: 5178
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphView_SetGraphEdgeColorArrayName_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The array to use for coloring edges.  Default is "color".
		/// </summary>
		// Token: 0x0600143B RID: 5179 RVA: 0x00022A8B File Offset: 0x00020C8B
		public virtual void SetGraphEdgeColorArrayName(string name)
		{
			vtkHierarchicalGraphView.vtkHierarchicalGraphView_SetGraphEdgeColorArrayName_23(base.GetCppThis(), name);
		}

		// Token: 0x0600143C RID: 5180
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphView_SetGraphEdgeColorToSplineFraction_24(HandleRef pThis);

		/// <summary>
		/// Set the color to be the spline fraction
		/// </summary>
		// Token: 0x0600143D RID: 5181 RVA: 0x00022A9B File Offset: 0x00020C9B
		public virtual void SetGraphEdgeColorToSplineFraction()
		{
			vtkHierarchicalGraphView.vtkHierarchicalGraphView_SetGraphEdgeColorToSplineFraction_24(base.GetCppThis());
		}

		// Token: 0x0600143E RID: 5182
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphView_SetGraphEdgeLabelArrayName_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The array to use for edge labeling.  Default is "label".
		/// </summary>
		// Token: 0x0600143F RID: 5183 RVA: 0x00022AAA File Offset: 0x00020CAA
		public virtual void SetGraphEdgeLabelArrayName(string name)
		{
			vtkHierarchicalGraphView.vtkHierarchicalGraphView_SetGraphEdgeLabelArrayName_25(base.GetCppThis(), name);
		}

		// Token: 0x06001440 RID: 5184
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphView_SetGraphEdgeLabelFontSize_26(HandleRef pThis, int size);

		/// <summary>
		/// The size of the font used for edge labeling
		/// </summary>
		// Token: 0x06001441 RID: 5185 RVA: 0x00022ABA File Offset: 0x00020CBA
		public virtual void SetGraphEdgeLabelFontSize(int size)
		{
			vtkHierarchicalGraphView.vtkHierarchicalGraphView_SetGraphEdgeLabelFontSize_26(base.GetCppThis(), size);
		}

		// Token: 0x06001442 RID: 5186
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphView_SetGraphEdgeLabelVisibility_27(HandleRef pThis, byte vis);

		/// <summary>
		/// Whether to show edge labels.  Default is off.
		/// </summary>
		// Token: 0x06001443 RID: 5187 RVA: 0x00022ACA File Offset: 0x00020CCA
		public virtual void SetGraphEdgeLabelVisibility(bool vis)
		{
			vtkHierarchicalGraphView.vtkHierarchicalGraphView_SetGraphEdgeLabelVisibility_27(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x06001444 RID: 5188
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalGraphView_SetGraphFromInput_28(HandleRef pThis, HandleRef input, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the tree and graph representations to the appropriate input ports.
		/// </summary>
		// Token: 0x06001445 RID: 5189 RVA: 0x00022AE4 File Offset: 0x00020CE4
		public vtkDataRepresentation SetGraphFromInput(vtkDataObject input)
		{
			vtkDataRepresentation vtkDataRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalGraphView.vtkHierarchicalGraphView_SetGraphFromInput_28(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06001446 RID: 5190
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalGraphView_SetGraphFromInputConnection_29(HandleRef pThis, HandleRef conn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the tree and graph representations to the appropriate input ports.
		/// </summary>
		// Token: 0x06001447 RID: 5191 RVA: 0x00022B6C File Offset: 0x00020D6C
		public vtkDataRepresentation SetGraphFromInputConnection(vtkAlgorithmOutput conn)
		{
			vtkDataRepresentation vtkDataRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalGraphView.vtkHierarchicalGraphView_SetGraphFromInputConnection_29(base.GetCppThis(), (conn == null) ? default(HandleRef) : conn.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06001448 RID: 5192
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHierarchicalGraphView_SetGraphVisibility_30(HandleRef pThis, byte vis);

		/// <summary>
		/// Whether the graph edges are visible (default off).
		/// </summary>
		// Token: 0x06001449 RID: 5193 RVA: 0x00022BF1 File Offset: 0x00020DF1
		public virtual void SetGraphVisibility(bool vis)
		{
			vtkHierarchicalGraphView.vtkHierarchicalGraphView_SetGraphVisibility_30(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x0600144A RID: 5194
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalGraphView_SetHierarchyFromInput_31(HandleRef pThis, HandleRef input, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the tree and graph representations to the appropriate input ports.
		/// </summary>
		// Token: 0x0600144B RID: 5195 RVA: 0x00022C0C File Offset: 0x00020E0C
		public vtkDataRepresentation SetHierarchyFromInput(vtkDataObject input)
		{
			vtkDataRepresentation vtkDataRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalGraphView.vtkHierarchicalGraphView_SetHierarchyFromInput_31(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600144C RID: 5196
		[DllImport("Kitware.VTK.ViewsInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalGraphView_SetHierarchyFromInputConnection_32(HandleRef pThis, HandleRef conn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the tree and graph representations to the appropriate input ports.
		/// </summary>
		// Token: 0x0600144D RID: 5197 RVA: 0x00022C94 File Offset: 0x00020E94
		public vtkDataRepresentation SetHierarchyFromInputConnection(vtkAlgorithmOutput conn)
		{
			vtkDataRepresentation vtkDataRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalGraphView.vtkHierarchicalGraphView_SetHierarchyFromInputConnection_32(base.GetCppThis(), (conn == null) ? default(HandleRef) : conn.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400046A RID: 1130
		public new const string MRFullTypeName = "Kitware.VTK.vtkHierarchicalGraphView";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400046B RID: 1131
		public new static readonly string MRClassNameKey = "class vtkHierarchicalGraphView";
	}
}
