using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDirectedGraph
	/// </summary>
	/// <remarks>
	///    A directed graph.
	///
	///
	/// vtkDirectedGraph is a collection of vertices along with a collection of
	/// directed edges (edges that have a source and target). ShallowCopy()
	/// and DeepCopy() (and CheckedShallowCopy(), CheckedDeepCopy())
	/// accept instances of vtkTree and vtkMutableDirectedGraph.
	///
	/// vtkDirectedGraph is read-only. To create an undirected graph,
	/// use an instance of vtkMutableDirectedGraph, then you may set the
	/// structure to a vtkDirectedGraph using ShallowCopy().
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGraph vtkMutableDirectedGraph
	/// </seealso>
	// Token: 0x02000A41 RID: 2625
	public class vtkDirectedGraph : vtkGraph
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B5AD RID: 112045 RVA: 0x0026406B File Offset: 0x0026226B
		static vtkDirectedGraph()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDirectedGraph.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDirectedGraph"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B5AE RID: 112046 RVA: 0x00264093 File Offset: 0x00262293
		public vtkDirectedGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B5AF RID: 112047
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDirectedGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B5B0 RID: 112048 RVA: 0x002640A4 File Offset: 0x002622A4
		public new static vtkDirectedGraph New()
		{
			vtkDirectedGraph result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDirectedGraph.vtkDirectedGraph_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDirectedGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B5B1 RID: 112049 RVA: 0x002640F8 File Offset: 0x002622F8
		public vtkDirectedGraph() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDirectedGraph.vtkDirectedGraph_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B5B2 RID: 112050 RVA: 0x0026413C File Offset: 0x0026233C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B5B3 RID: 112051
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDirectedGraph_GetData_01(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve a graph from an information vector.
		/// </summary>
		// Token: 0x0601B5B4 RID: 112052 RVA: 0x00264148 File Offset: 0x00262348
		public new static vtkDirectedGraph GetData(vtkInformation info)
		{
			vtkDirectedGraph vtkDirectedGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDirectedGraph.vtkDirectedGraph_GetData_01((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDirectedGraph = (vtkDirectedGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDirectedGraph.Register(null);
				}
			}
			return vtkDirectedGraph;
		}

		// Token: 0x0601B5B5 RID: 112053
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDirectedGraph_GetData_02(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve a graph from an information vector.
		/// </summary>
		// Token: 0x0601B5B6 RID: 112054 RVA: 0x002641C8 File Offset: 0x002623C8
		public new static vtkDirectedGraph GetData(vtkInformationVector v, int i)
		{
			vtkDirectedGraph vtkDirectedGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDirectedGraph.vtkDirectedGraph_GetData_02((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDirectedGraph = (vtkDirectedGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDirectedGraph.Register(null);
				}
			}
			return vtkDirectedGraph;
		}

		// Token: 0x0601B5B7 RID: 112055
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDirectedGraph_GetDataObjectType_03(HandleRef pThis);

		/// <summary>
		/// Return what type of dataset this is.
		/// </summary>
		// Token: 0x0601B5B8 RID: 112056 RVA: 0x00264248 File Offset: 0x00262448
		public override int GetDataObjectType()
		{
			return vtkDirectedGraph.vtkDirectedGraph_GetDataObjectType_03(base.GetCppThis());
		}

		// Token: 0x0601B5B9 RID: 112057
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDirectedGraph_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B5BA RID: 112058 RVA: 0x00264268 File Offset: 0x00262468
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDirectedGraph.vtkDirectedGraph_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601B5BB RID: 112059
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDirectedGraph_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B5BC RID: 112060 RVA: 0x00264288 File Offset: 0x00262488
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDirectedGraph.vtkDirectedGraph_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601B5BD RID: 112061
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDirectedGraph_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B5BE RID: 112062 RVA: 0x002642A4 File Offset: 0x002624A4
		public override int IsA(string type)
		{
			return vtkDirectedGraph.vtkDirectedGraph_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601B5BF RID: 112063
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDirectedGraph_IsStructureValid_07(HandleRef pThis, HandleRef g);

		/// <summary>
		/// Check the storage, and accept it if it is a valid
		/// undirected graph. This is public to allow
		/// the ToDirected/UndirectedGraph to work.
		/// </summary>
		// Token: 0x0601B5C0 RID: 112064 RVA: 0x002642C4 File Offset: 0x002624C4
		public virtual bool IsStructureValid(vtkGraph g)
		{
			return vtkDirectedGraph.vtkDirectedGraph_IsStructureValid_07(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis()) != 0;
		}

		// Token: 0x0601B5C1 RID: 112065
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDirectedGraph_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B5C2 RID: 112066 RVA: 0x00264300 File Offset: 0x00262500
		public new static int IsTypeOf(string type)
		{
			return vtkDirectedGraph.vtkDirectedGraph_IsTypeOf_08(type);
		}

		// Token: 0x0601B5C3 RID: 112067
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDirectedGraph_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B5C4 RID: 112068 RVA: 0x0026431C File Offset: 0x0026251C
		public new vtkDirectedGraph NewInstance()
		{
			vtkDirectedGraph result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDirectedGraph.vtkDirectedGraph_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDirectedGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B5C5 RID: 112069
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDirectedGraph_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B5C6 RID: 112070 RVA: 0x00264378 File Offset: 0x00262578
		public new static vtkDirectedGraph SafeDownCast(vtkObjectBase o)
		{
			vtkDirectedGraph vtkDirectedGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDirectedGraph.vtkDirectedGraph_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDirectedGraph = (vtkDirectedGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDirectedGraph.Register(null);
				}
			}
			return vtkDirectedGraph;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D76 RID: 7542
		public new const string MRFullTypeName = "Kitware.VTK.vtkDirectedGraph";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D77 RID: 7543
		public new static readonly string MRClassNameKey = "class vtkDirectedGraph";
	}
}
