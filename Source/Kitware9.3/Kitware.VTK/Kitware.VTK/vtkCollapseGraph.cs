using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCollapseGraph
	/// </summary>
	/// <remarks>
	///    "Collapses" vertices onto their neighbors.
	///
	///
	/// vtkCollapseGraph "collapses" vertices onto their neighbors, while maintaining
	/// connectivity.  Two inputs are required - a graph (directed or undirected),
	/// and a vertex selection that can be converted to indices.
	///
	/// Conceptually, each of the vertices specified in the input selection
	/// expands, "swallowing" adacent vertices.  Edges to-or-from the "swallowed"
	/// vertices become edges to-or-from the expanding vertices, maintaining the
	/// overall graph connectivity.
	///
	/// In the case of directed graphs, expanding vertices only swallow vertices that
	/// are connected via out edges.  This rule provides intuitive behavior when
	/// working with trees, so that "child" vertices collapse into their parents
	/// when the parents are part of the input selection.
	///
	/// Input port 0: graph
	/// Input port 1: selection
	/// </remarks>
	// Token: 0x02000674 RID: 1652
	public class vtkCollapseGraph : vtkGraphAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011CDF RID: 72927 RVA: 0x0018E9EF File Offset: 0x0018CBEF
		static vtkCollapseGraph()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCollapseGraph.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCollapseGraph"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011CE0 RID: 72928 RVA: 0x0018EA17 File Offset: 0x0018CC17
		public vtkCollapseGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011CE1 RID: 72929
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollapseGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CE2 RID: 72930 RVA: 0x0018EA28 File Offset: 0x0018CC28
		public new static vtkCollapseGraph New()
		{
			vtkCollapseGraph result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollapseGraph.vtkCollapseGraph_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCollapseGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CE3 RID: 72931 RVA: 0x0018EA7C File Offset: 0x0018CC7C
		public vtkCollapseGraph() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCollapseGraph.vtkCollapseGraph_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011CE4 RID: 72932 RVA: 0x0018EAC0 File Offset: 0x0018CCC0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011CE5 RID: 72933
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCollapseGraph_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CE6 RID: 72934 RVA: 0x0018EACC File Offset: 0x0018CCCC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCollapseGraph.vtkCollapseGraph_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06011CE7 RID: 72935
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCollapseGraph_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CE8 RID: 72936 RVA: 0x0018EAEC File Offset: 0x0018CCEC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCollapseGraph.vtkCollapseGraph_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06011CE9 RID: 72937
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollapseGraph_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CEA RID: 72938 RVA: 0x0018EB08 File Offset: 0x0018CD08
		public override int IsA(string type)
		{
			return vtkCollapseGraph.vtkCollapseGraph_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06011CEB RID: 72939
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollapseGraph_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CEC RID: 72940 RVA: 0x0018EB28 File Offset: 0x0018CD28
		public new static int IsTypeOf(string type)
		{
			return vtkCollapseGraph.vtkCollapseGraph_IsTypeOf_04(type);
		}

		// Token: 0x06011CED RID: 72941
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollapseGraph_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CEE RID: 72942 RVA: 0x0018EB44 File Offset: 0x0018CD44
		public new vtkCollapseGraph NewInstance()
		{
			vtkCollapseGraph result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollapseGraph.vtkCollapseGraph_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCollapseGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011CEF RID: 72943
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollapseGraph_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CF0 RID: 72944 RVA: 0x0018EBA0 File Offset: 0x0018CDA0
		public new static vtkCollapseGraph SafeDownCast(vtkObjectBase o)
		{
			vtkCollapseGraph vtkCollapseGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollapseGraph.vtkCollapseGraph_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCollapseGraph = (vtkCollapseGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCollapseGraph.Register(null);
				}
			}
			return vtkCollapseGraph;
		}

		// Token: 0x06011CF1 RID: 72945
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollapseGraph_SetGraphConnection_08(HandleRef pThis, HandleRef arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CF2 RID: 72946 RVA: 0x0018EC20 File Offset: 0x0018CE20
		public void SetGraphConnection(vtkAlgorithmOutput arg0)
		{
			vtkCollapseGraph.vtkCollapseGraph_SetGraphConnection_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06011CF3 RID: 72947
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollapseGraph_SetSelectionConnection_09(HandleRef pThis, HandleRef arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CF4 RID: 72948 RVA: 0x0018EC50 File Offset: 0x0018CE50
		public void SetSelectionConnection(vtkAlgorithmOutput arg0)
		{
			vtkCollapseGraph.vtkCollapseGraph_SetSelectionConnection_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001489 RID: 5257
		public new const string MRFullTypeName = "Kitware.VTK.vtkCollapseGraph";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400148A RID: 5258
		public new static readonly string MRClassNameKey = "class vtkCollapseGraph";
	}
}
