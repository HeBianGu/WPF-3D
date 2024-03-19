using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGraphHierarchicalBundleEdges
	/// </summary>
	/// <remarks>
	///    layout graph arcs in bundles
	///
	///
	/// This algorithm creates a vtkPolyData from a vtkGraph.  As opposed to
	/// vtkGraphToPolyData, which converts each arc into a straight line, each arc
	/// is converted to a polyline, following a tree structure.  The filter requires
	/// both a vtkGraph and vtkTree as input.  The tree vertices must be a
	/// superset of the graph vertices.  A common example is when the graph vertices
	/// correspond to the leaves of the tree, but the internal vertices of the tree
	/// represent groupings of graph vertices.  The algorithm matches the vertices
	/// using the array "PedigreeId".  The user may alternately set the
	/// DirectMapping flag to indicate that the two structures must have directly
	/// corresponding offsets (i.e. node i in the graph must correspond to node i in
	/// the tree).
	///
	/// The vtkGraph defines the topology of the output vtkPolyData (i.e.
	/// the connections between nodes) while the vtkTree defines the geometry (i.e.
	/// the location of nodes and arc routes).  Thus, the tree must have been
	/// assigned vertex locations, but the graph does not need locations, in fact
	/// they will be ignored.  The edges approximately follow the path from the
	/// source to target nodes in the tree.  A bundling parameter controls how
	/// closely the edges are bundled together along the tree structure.
	///
	/// You may follow this algorithm with vtkSplineFilter in order to make nicely
	/// curved edges.
	///
	/// @par Thanks:
	/// This algorithm was developed in the paper
	/// Danny Holten. Hierarchical Edge Bundles: Visualization of Adjacency Relations
	/// Relations in Hierarchical Data. IEEE Transactions on Visualization and
	/// Computer Graphics, Vol. 12, No. 5, 2006. pp. 741-748.
	/// </remarks>
	// Token: 0x02000680 RID: 1664
	public class vtkGraphHierarchicalBundleEdges : vtkGraphAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011E39 RID: 73273 RVA: 0x001908F7 File Offset: 0x0018EAF7
		static vtkGraphHierarchicalBundleEdges()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphHierarchicalBundleEdges.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphHierarchicalBundleEdges"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011E3A RID: 73274 RVA: 0x0019091F File Offset: 0x0018EB1F
		public vtkGraphHierarchicalBundleEdges(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011E3B RID: 73275
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphHierarchicalBundleEdges_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E3C RID: 73276 RVA: 0x00190930 File Offset: 0x0018EB30
		public new static vtkGraphHierarchicalBundleEdges New()
		{
			vtkGraphHierarchicalBundleEdges result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphHierarchicalBundleEdges)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E3D RID: 73277 RVA: 0x00190984 File Offset: 0x0018EB84
		public vtkGraphHierarchicalBundleEdges() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011E3E RID: 73278 RVA: 0x001909C8 File Offset: 0x0018EBC8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011E3F RID: 73279
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphHierarchicalBundleEdges_DirectMappingOff_01(HandleRef pThis);

		/// <summary>
		/// If on, uses direct mapping from tree to graph vertices.
		/// If off, both the graph and tree must contain PedigreeId arrays
		/// which are used to match graph and tree vertices.
		/// Default is off.
		/// </summary>
		// Token: 0x06011E40 RID: 73280 RVA: 0x001909D3 File Offset: 0x0018EBD3
		public virtual void DirectMappingOff()
		{
			vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_DirectMappingOff_01(base.GetCppThis());
		}

		// Token: 0x06011E41 RID: 73281
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphHierarchicalBundleEdges_DirectMappingOn_02(HandleRef pThis);

		/// <summary>
		/// If on, uses direct mapping from tree to graph vertices.
		/// If off, both the graph and tree must contain PedigreeId arrays
		/// which are used to match graph and tree vertices.
		/// Default is off.
		/// </summary>
		// Token: 0x06011E42 RID: 73282 RVA: 0x001909E2 File Offset: 0x0018EBE2
		public virtual void DirectMappingOn()
		{
			vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_DirectMappingOn_02(base.GetCppThis());
		}

		// Token: 0x06011E43 RID: 73283
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphHierarchicalBundleEdges_FillInputPortInformation_03(HandleRef pThis, int port, HandleRef info);

		/// <summary>
		/// Set the input type of the algorithm to vtkGraph.
		/// </summary>
		// Token: 0x06011E44 RID: 73284 RVA: 0x001909F4 File Offset: 0x0018EBF4
		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_FillInputPortInformation_03(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x06011E45 RID: 73285
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGraphHierarchicalBundleEdges_GetBundlingStrength_04(HandleRef pThis);

		/// <summary>
		/// The level of arc bundling in the graph.
		/// A strength of 0 creates straight lines, while a strength of 1
		/// forces arcs to pass directly through hierarchy node points.
		/// The default value is 0.8.
		/// </summary>
		// Token: 0x06011E46 RID: 73286 RVA: 0x00190A2C File Offset: 0x0018EC2C
		public virtual double GetBundlingStrength()
		{
			return vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_GetBundlingStrength_04(base.GetCppThis());
		}

		// Token: 0x06011E47 RID: 73287
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGraphHierarchicalBundleEdges_GetBundlingStrengthMaxValue_05(HandleRef pThis);

		/// <summary>
		/// The level of arc bundling in the graph.
		/// A strength of 0 creates straight lines, while a strength of 1
		/// forces arcs to pass directly through hierarchy node points.
		/// The default value is 0.8.
		/// </summary>
		// Token: 0x06011E48 RID: 73288 RVA: 0x00190A4C File Offset: 0x0018EC4C
		public virtual double GetBundlingStrengthMaxValue()
		{
			return vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_GetBundlingStrengthMaxValue_05(base.GetCppThis());
		}

		// Token: 0x06011E49 RID: 73289
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGraphHierarchicalBundleEdges_GetBundlingStrengthMinValue_06(HandleRef pThis);

		/// <summary>
		/// The level of arc bundling in the graph.
		/// A strength of 0 creates straight lines, while a strength of 1
		/// forces arcs to pass directly through hierarchy node points.
		/// The default value is 0.8.
		/// </summary>
		// Token: 0x06011E4A RID: 73290 RVA: 0x00190A6C File Offset: 0x0018EC6C
		public virtual double GetBundlingStrengthMinValue()
		{
			return vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_GetBundlingStrengthMinValue_06(base.GetCppThis());
		}

		// Token: 0x06011E4B RID: 73291
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGraphHierarchicalBundleEdges_GetDirectMapping_07(HandleRef pThis);

		/// <summary>
		/// If on, uses direct mapping from tree to graph vertices.
		/// If off, both the graph and tree must contain PedigreeId arrays
		/// which are used to match graph and tree vertices.
		/// Default is off.
		/// </summary>
		// Token: 0x06011E4C RID: 73292 RVA: 0x00190A8C File Offset: 0x0018EC8C
		public virtual bool GetDirectMapping()
		{
			return vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_GetDirectMapping_07(base.GetCppThis()) != 0;
		}

		// Token: 0x06011E4D RID: 73293
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphHierarchicalBundleEdges_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E4E RID: 73294 RVA: 0x00190AB4 File Offset: 0x0018ECB4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x06011E4F RID: 73295
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphHierarchicalBundleEdges_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E50 RID: 73296 RVA: 0x00190AD4 File Offset: 0x0018ECD4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x06011E51 RID: 73297
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphHierarchicalBundleEdges_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E52 RID: 73298 RVA: 0x00190AF0 File Offset: 0x0018ECF0
		public override int IsA(string type)
		{
			return vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06011E53 RID: 73299
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphHierarchicalBundleEdges_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E54 RID: 73300 RVA: 0x00190B10 File Offset: 0x0018ED10
		public new static int IsTypeOf(string type)
		{
			return vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_IsTypeOf_11(type);
		}

		// Token: 0x06011E55 RID: 73301
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphHierarchicalBundleEdges_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E56 RID: 73302 RVA: 0x00190B2C File Offset: 0x0018ED2C
		public new vtkGraphHierarchicalBundleEdges NewInstance()
		{
			vtkGraphHierarchicalBundleEdges result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphHierarchicalBundleEdges)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011E57 RID: 73303
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphHierarchicalBundleEdges_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E58 RID: 73304 RVA: 0x00190B88 File Offset: 0x0018ED88
		public new static vtkGraphHierarchicalBundleEdges SafeDownCast(vtkObjectBase o)
		{
			vtkGraphHierarchicalBundleEdges vtkGraphHierarchicalBundleEdges = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphHierarchicalBundleEdges = (vtkGraphHierarchicalBundleEdges)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphHierarchicalBundleEdges.Register(null);
				}
			}
			return vtkGraphHierarchicalBundleEdges;
		}

		// Token: 0x06011E59 RID: 73305
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphHierarchicalBundleEdges_SetBundlingStrength_15(HandleRef pThis, double _arg);

		/// <summary>
		/// The level of arc bundling in the graph.
		/// A strength of 0 creates straight lines, while a strength of 1
		/// forces arcs to pass directly through hierarchy node points.
		/// The default value is 0.8.
		/// </summary>
		// Token: 0x06011E5A RID: 73306 RVA: 0x00190C07 File Offset: 0x0018EE07
		public virtual void SetBundlingStrength(double _arg)
		{
			vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_SetBundlingStrength_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06011E5B RID: 73307
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphHierarchicalBundleEdges_SetDirectMapping_16(HandleRef pThis, byte _arg);

		/// <summary>
		/// If on, uses direct mapping from tree to graph vertices.
		/// If off, both the graph and tree must contain PedigreeId arrays
		/// which are used to match graph and tree vertices.
		/// Default is off.
		/// </summary>
		// Token: 0x06011E5C RID: 73308 RVA: 0x00190C17 File Offset: 0x0018EE17
		public virtual void SetDirectMapping(bool _arg)
		{
			vtkGraphHierarchicalBundleEdges.vtkGraphHierarchicalBundleEdges_SetDirectMapping_16(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014A9 RID: 5289
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphHierarchicalBundleEdges";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014AA RID: 5290
		public new static readonly string MRClassNameKey = "class vtkGraphHierarchicalBundleEdges";
	}
}
