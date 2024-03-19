using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractSelectedGraph
	/// </summary>
	/// <remarks>
	///    return a subgraph of a vtkGraph
	///
	///
	/// The first input is a vtkGraph to take a subgraph from.
	/// The second input (optional) is a vtkSelection containing selected
	/// indices. The third input (optional) is a vtkAnnotationsLayers whose
	/// annotations contain selected specifying selected indices.
	/// The vtkSelection may have FIELD_TYPE set to POINTS (a vertex selection)
	/// or CELLS (an edge selection).  A vertex selection preserves all edges
	/// that connect selected vertices.  An edge selection preserves all vertices
	/// that are adjacent to at least one selected edge.  Alternately, you may
	/// indicate that an edge selection should maintain the full set of vertices,
	/// by turning RemoveIsolatedVertices off.
	/// </remarks>
	// Token: 0x0200067C RID: 1660
	public class vtkExtractSelectedGraph : vtkGraphAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011DE1 RID: 73185 RVA: 0x00190015 File Offset: 0x0018E215
		static vtkExtractSelectedGraph()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractSelectedGraph.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractSelectedGraph"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011DE2 RID: 73186 RVA: 0x0019003D File Offset: 0x0018E23D
		public vtkExtractSelectedGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011DE3 RID: 73187
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011DE4 RID: 73188 RVA: 0x0019004C File Offset: 0x0018E24C
		public new static vtkExtractSelectedGraph New()
		{
			vtkExtractSelectedGraph result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedGraph.vtkExtractSelectedGraph_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011DE5 RID: 73189 RVA: 0x001900A0 File Offset: 0x0018E2A0
		public vtkExtractSelectedGraph() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractSelectedGraph.vtkExtractSelectedGraph_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011DE6 RID: 73190 RVA: 0x001900E4 File Offset: 0x0018E2E4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011DE7 RID: 73191
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedGraph_FillInputPortInformation_01(HandleRef pThis, int port, HandleRef info);

		/// <summary>
		/// Specify the first vtkGraph input and the second vtkSelection input.
		/// </summary>
		// Token: 0x06011DE8 RID: 73192 RVA: 0x001900F0 File Offset: 0x0018E2F0
		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkExtractSelectedGraph.vtkExtractSelectedGraph_FillInputPortInformation_01(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x06011DE9 RID: 73193
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractSelectedGraph_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011DEA RID: 73194 RVA: 0x00190128 File Offset: 0x0018E328
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractSelectedGraph.vtkExtractSelectedGraph_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06011DEB RID: 73195
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractSelectedGraph_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011DEC RID: 73196 RVA: 0x00190148 File Offset: 0x0018E348
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractSelectedGraph.vtkExtractSelectedGraph_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06011DED RID: 73197
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExtractSelectedGraph_GetRemoveIsolatedVertices_04(HandleRef pThis);

		/// <summary>
		/// If set, removes vertices with no adjacent edges in an edge selection.
		/// A vertex selection ignores this flag and always returns the full set
		/// of selected vertices.  Default is on.
		/// </summary>
		// Token: 0x06011DEE RID: 73198 RVA: 0x00190164 File Offset: 0x0018E364
		public virtual bool GetRemoveIsolatedVertices()
		{
			return vtkExtractSelectedGraph.vtkExtractSelectedGraph_GetRemoveIsolatedVertices_04(base.GetCppThis()) != 0;
		}

		// Token: 0x06011DEF RID: 73199
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedGraph_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011DF0 RID: 73200 RVA: 0x0019018C File Offset: 0x0018E38C
		public override int IsA(string type)
		{
			return vtkExtractSelectedGraph.vtkExtractSelectedGraph_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06011DF1 RID: 73201
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedGraph_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011DF2 RID: 73202 RVA: 0x001901AC File Offset: 0x0018E3AC
		public new static int IsTypeOf(string type)
		{
			return vtkExtractSelectedGraph.vtkExtractSelectedGraph_IsTypeOf_06(type);
		}

		// Token: 0x06011DF3 RID: 73203
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedGraph_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011DF4 RID: 73204 RVA: 0x001901C8 File Offset: 0x0018E3C8
		public new vtkExtractSelectedGraph NewInstance()
		{
			vtkExtractSelectedGraph result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedGraph.vtkExtractSelectedGraph_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011DF5 RID: 73205
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelectedGraph_RemoveIsolatedVerticesOff_09(HandleRef pThis);

		/// <summary>
		/// If set, removes vertices with no adjacent edges in an edge selection.
		/// A vertex selection ignores this flag and always returns the full set
		/// of selected vertices.  Default is on.
		/// </summary>
		// Token: 0x06011DF6 RID: 73206 RVA: 0x00190222 File Offset: 0x0018E422
		public virtual void RemoveIsolatedVerticesOff()
		{
			vtkExtractSelectedGraph.vtkExtractSelectedGraph_RemoveIsolatedVerticesOff_09(base.GetCppThis());
		}

		// Token: 0x06011DF7 RID: 73207
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelectedGraph_RemoveIsolatedVerticesOn_10(HandleRef pThis);

		/// <summary>
		/// If set, removes vertices with no adjacent edges in an edge selection.
		/// A vertex selection ignores this flag and always returns the full set
		/// of selected vertices.  Default is on.
		/// </summary>
		// Token: 0x06011DF8 RID: 73208 RVA: 0x00190231 File Offset: 0x0018E431
		public virtual void RemoveIsolatedVerticesOn()
		{
			vtkExtractSelectedGraph.vtkExtractSelectedGraph_RemoveIsolatedVerticesOn_10(base.GetCppThis());
		}

		// Token: 0x06011DF9 RID: 73209
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedGraph_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011DFA RID: 73210 RVA: 0x00190240 File Offset: 0x0018E440
		public new static vtkExtractSelectedGraph SafeDownCast(vtkObjectBase o)
		{
			vtkExtractSelectedGraph vtkExtractSelectedGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedGraph.vtkExtractSelectedGraph_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractSelectedGraph = (vtkExtractSelectedGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractSelectedGraph.Register(null);
				}
			}
			return vtkExtractSelectedGraph;
		}

		// Token: 0x06011DFB RID: 73211
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelectedGraph_SetAnnotationLayersConnection_12(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// A convenience method for setting the third input (i.e. the annotation layers).
		/// </summary>
		// Token: 0x06011DFC RID: 73212 RVA: 0x001902C0 File Offset: 0x0018E4C0
		public void SetAnnotationLayersConnection(vtkAlgorithmOutput arg0)
		{
			vtkExtractSelectedGraph.vtkExtractSelectedGraph_SetAnnotationLayersConnection_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06011DFD RID: 73213
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelectedGraph_SetRemoveIsolatedVertices_13(HandleRef pThis, byte _arg);

		/// <summary>
		/// If set, removes vertices with no adjacent edges in an edge selection.
		/// A vertex selection ignores this flag and always returns the full set
		/// of selected vertices.  Default is on.
		/// </summary>
		// Token: 0x06011DFE RID: 73214 RVA: 0x001902EF File Offset: 0x0018E4EF
		public virtual void SetRemoveIsolatedVertices(bool _arg)
		{
			vtkExtractSelectedGraph.vtkExtractSelectedGraph_SetRemoveIsolatedVertices_13(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011DFF RID: 73215
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSelectedGraph_SetSelectionConnection_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// A convenience method for setting the second input (i.e. the selection).
		/// </summary>
		// Token: 0x06011E00 RID: 73216 RVA: 0x00190308 File Offset: 0x0018E508
		public void SetSelectionConnection(vtkAlgorithmOutput arg0)
		{
			vtkExtractSelectedGraph.vtkExtractSelectedGraph_SetSelectionConnection_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400149D RID: 5277
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractSelectedGraph";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400149E RID: 5278
		public new static readonly string MRClassNameKey = "class vtkExtractSelectedGraph";
	}
}
