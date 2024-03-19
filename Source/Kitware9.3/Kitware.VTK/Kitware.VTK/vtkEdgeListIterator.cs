using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkEdgeListIterator
	/// </summary>
	/// <remarks>
	///    Iterates through all edges in a graph.
	///
	///
	/// vtkEdgeListIterator iterates through all the edges in a graph, by traversing
	/// the adjacency list for each vertex. You may instantiate this class directly
	/// and call SetGraph() to traverse a certain graph. You may also call the graph's
	/// GetEdges() method to set up the iterator for a certain graph.
	///
	/// Note that this class does NOT guarantee that the edges will be processed in
	/// order of their ids (i.e. it will not necessarily return edge 0, then edge 1,
	/// etc.).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGraph
	/// </seealso>
	// Token: 0x02000A44 RID: 2628
	public class vtkEdgeListIterator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B602 RID: 112130 RVA: 0x00264B0A File Offset: 0x00262D0A
		static vtkEdgeListIterator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEdgeListIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEdgeListIterator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B603 RID: 112131 RVA: 0x00264B32 File Offset: 0x00262D32
		public vtkEdgeListIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B604 RID: 112132
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEdgeListIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B605 RID: 112133 RVA: 0x00264B40 File Offset: 0x00262D40
		public new static vtkEdgeListIterator New()
		{
			vtkEdgeListIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEdgeListIterator.vtkEdgeListIterator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEdgeListIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B606 RID: 112134 RVA: 0x00264B94 File Offset: 0x00262D94
		public vtkEdgeListIterator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkEdgeListIterator.vtkEdgeListIterator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B607 RID: 112135 RVA: 0x00264BD8 File Offset: 0x00262DD8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B608 RID: 112136
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEdgeListIterator_GetGraph_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B609 RID: 112137 RVA: 0x00264BE4 File Offset: 0x00262DE4
		public virtual vtkGraph GetGraph()
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEdgeListIterator.vtkEdgeListIterator_GetGraph_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraph = (vtkGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraph.Register(null);
				}
			}
			return vtkGraph;
		}

		// Token: 0x0601B60A RID: 112138
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEdgeListIterator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B60B RID: 112139 RVA: 0x00264C54 File Offset: 0x00262E54
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEdgeListIterator.vtkEdgeListIterator_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601B60C RID: 112140
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEdgeListIterator_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B60D RID: 112141 RVA: 0x00264C74 File Offset: 0x00262E74
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEdgeListIterator.vtkEdgeListIterator_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601B60E RID: 112142
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkEdgeListIterator_HasNext_04(HandleRef pThis);

		/// <summary>
		/// Whether this iterator has more edges.
		/// </summary>
		// Token: 0x0601B60F RID: 112143 RVA: 0x00264C90 File Offset: 0x00262E90
		public bool HasNext()
		{
			return vtkEdgeListIterator.vtkEdgeListIterator_HasNext_04(base.GetCppThis()) != 0;
		}

		// Token: 0x0601B610 RID: 112144
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEdgeListIterator_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B611 RID: 112145 RVA: 0x00264CB8 File Offset: 0x00262EB8
		public override int IsA(string type)
		{
			return vtkEdgeListIterator.vtkEdgeListIterator_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601B612 RID: 112146
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEdgeListIterator_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B613 RID: 112147 RVA: 0x00264CD8 File Offset: 0x00262ED8
		public new static int IsTypeOf(string type)
		{
			return vtkEdgeListIterator.vtkEdgeListIterator_IsTypeOf_06(type);
		}

		// Token: 0x0601B614 RID: 112148
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEdgeListIterator_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B615 RID: 112149 RVA: 0x00264CF4 File Offset: 0x00262EF4
		public new vtkEdgeListIterator NewInstance()
		{
			vtkEdgeListIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEdgeListIterator.vtkEdgeListIterator_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEdgeListIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B616 RID: 112150
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEdgeListIterator_NextGraphEdge_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Just like Next(), but
		/// returns heavy-weight vtkGraphEdge object instead of
		/// the vtkEdgeType struct, for use with wrappers.
		/// The graph edge is owned by this iterator, and changes
		/// after each call to NextGraphEdge().
		/// </summary>
		// Token: 0x0601B617 RID: 112151 RVA: 0x00264D50 File Offset: 0x00262F50
		public vtkGraphEdge NextGraphEdge()
		{
			vtkGraphEdge vtkGraphEdge = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEdgeListIterator.vtkEdgeListIterator_NextGraphEdge_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphEdge = (vtkGraphEdge)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphEdge.Register(null);
				}
			}
			return vtkGraphEdge;
		}

		// Token: 0x0601B618 RID: 112152
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEdgeListIterator_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B619 RID: 112153 RVA: 0x00264DC0 File Offset: 0x00262FC0
		public new static vtkEdgeListIterator SafeDownCast(vtkObjectBase o)
		{
			vtkEdgeListIterator vtkEdgeListIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEdgeListIterator.vtkEdgeListIterator_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEdgeListIterator = (vtkEdgeListIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEdgeListIterator.Register(null);
				}
			}
			return vtkEdgeListIterator;
		}

		// Token: 0x0601B61A RID: 112154
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEdgeListIterator_SetGraph_11(HandleRef pThis, HandleRef graph);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B61B RID: 112155 RVA: 0x00264E40 File Offset: 0x00263040
		public virtual void SetGraph(vtkGraph graph)
		{
			vtkEdgeListIterator.vtkEdgeListIterator_SetGraph_11(base.GetCppThis(), (graph == null) ? default(HandleRef) : graph.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D7C RID: 7548
		public new const string MRFullTypeName = "Kitware.VTK.vtkEdgeListIterator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D7D RID: 7549
		public new static readonly string MRClassNameKey = "class vtkEdgeListIterator";
	}
}
