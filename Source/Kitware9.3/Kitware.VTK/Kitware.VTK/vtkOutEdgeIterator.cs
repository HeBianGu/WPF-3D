using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOutEdgeIterator
	/// </summary>
	/// <remarks>
	///    Iterates through all outgoing edges from a vertex.
	///
	///
	/// vtkOutEdgeIterator iterates through all edges whose source is a particular
	/// vertex. Instantiate this class directly and call Initialize() to traverse
	/// the vertex of a graph. Alternately, use GetInEdges() on the graph to
	/// initialize the iterator. it-&gt;Next() returns a vtkOutEdgeType structure,
	/// which contains Id, the edge's id, and Target, the edge's target vertex.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGraph vtkInEdgeIterator
	/// </seealso>
	// Token: 0x02000A8D RID: 2701
	public class vtkOutEdgeIterator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C4FE RID: 115966 RVA: 0x0027C271 File Offset: 0x0027A471
		static vtkOutEdgeIterator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOutEdgeIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOutEdgeIterator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C4FF RID: 115967 RVA: 0x0027C299 File Offset: 0x0027A499
		public vtkOutEdgeIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C500 RID: 115968
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOutEdgeIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C501 RID: 115969 RVA: 0x0027C2A8 File Offset: 0x0027A4A8
		public new static vtkOutEdgeIterator New()
		{
			vtkOutEdgeIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOutEdgeIterator.vtkOutEdgeIterator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOutEdgeIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C502 RID: 115970 RVA: 0x0027C2FC File Offset: 0x0027A4FC
		public vtkOutEdgeIterator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOutEdgeIterator.vtkOutEdgeIterator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C503 RID: 115971 RVA: 0x0027C340 File Offset: 0x0027A540
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C504 RID: 115972
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOutEdgeIterator_GetGraph_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the graph and vertex associated with this iterator.
		/// </summary>
		// Token: 0x0601C505 RID: 115973 RVA: 0x0027C34C File Offset: 0x0027A54C
		public virtual vtkGraph GetGraph()
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOutEdgeIterator.vtkOutEdgeIterator_GetGraph_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C506 RID: 115974
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOutEdgeIterator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C507 RID: 115975 RVA: 0x0027C3BC File Offset: 0x0027A5BC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOutEdgeIterator.vtkOutEdgeIterator_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601C508 RID: 115976
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOutEdgeIterator_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C509 RID: 115977 RVA: 0x0027C3DC File Offset: 0x0027A5DC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOutEdgeIterator.vtkOutEdgeIterator_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601C50A RID: 115978
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOutEdgeIterator_GetVertex_04(HandleRef pThis);

		/// <summary>
		/// Get the graph and vertex associated with this iterator.
		/// </summary>
		// Token: 0x0601C50B RID: 115979 RVA: 0x0027C3F8 File Offset: 0x0027A5F8
		public virtual long GetVertex()
		{
			return vtkOutEdgeIterator.vtkOutEdgeIterator_GetVertex_04(base.GetCppThis());
		}

		// Token: 0x0601C50C RID: 115980
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOutEdgeIterator_HasNext_05(HandleRef pThis);

		/// <summary>
		/// Whether this iterator has more edges.
		/// </summary>
		// Token: 0x0601C50D RID: 115981 RVA: 0x0027C418 File Offset: 0x0027A618
		public bool HasNext()
		{
			return vtkOutEdgeIterator.vtkOutEdgeIterator_HasNext_05(base.GetCppThis()) != 0;
		}

		// Token: 0x0601C50E RID: 115982
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOutEdgeIterator_Initialize_06(HandleRef pThis, HandleRef g, long v);

		/// <summary>
		/// Initialize the iterator with a graph and vertex.
		/// </summary>
		// Token: 0x0601C50F RID: 115983 RVA: 0x0027C440 File Offset: 0x0027A640
		public void Initialize(vtkGraph g, long v)
		{
			vtkOutEdgeIterator.vtkOutEdgeIterator_Initialize_06(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis(), v);
		}

		// Token: 0x0601C510 RID: 115984
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOutEdgeIterator_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C511 RID: 115985 RVA: 0x0027C470 File Offset: 0x0027A670
		public override int IsA(string type)
		{
			return vtkOutEdgeIterator.vtkOutEdgeIterator_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601C512 RID: 115986
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOutEdgeIterator_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C513 RID: 115987 RVA: 0x0027C490 File Offset: 0x0027A690
		public new static int IsTypeOf(string type)
		{
			return vtkOutEdgeIterator.vtkOutEdgeIterator_IsTypeOf_08(type);
		}

		// Token: 0x0601C514 RID: 115988
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOutEdgeIterator_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C515 RID: 115989 RVA: 0x0027C4AC File Offset: 0x0027A6AC
		public new vtkOutEdgeIterator NewInstance()
		{
			vtkOutEdgeIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOutEdgeIterator.vtkOutEdgeIterator_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOutEdgeIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C516 RID: 115990
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOutEdgeIterator_NextGraphEdge_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Just like Next(), but
		/// returns heavy-weight vtkGraphEdge object instead of
		/// the vtkEdgeType struct, for use with wrappers.
		/// The graph edge is owned by this iterator, and changes
		/// after each call to NextGraphEdge().
		/// </summary>
		// Token: 0x0601C517 RID: 115991 RVA: 0x0027C508 File Offset: 0x0027A708
		public vtkGraphEdge NextGraphEdge()
		{
			vtkGraphEdge vtkGraphEdge = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOutEdgeIterator.vtkOutEdgeIterator_NextGraphEdge_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C518 RID: 115992
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOutEdgeIterator_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C519 RID: 115993 RVA: 0x0027C578 File Offset: 0x0027A778
		public new static vtkOutEdgeIterator SafeDownCast(vtkObjectBase o)
		{
			vtkOutEdgeIterator vtkOutEdgeIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOutEdgeIterator.vtkOutEdgeIterator_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOutEdgeIterator = (vtkOutEdgeIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOutEdgeIterator.Register(null);
				}
			}
			return vtkOutEdgeIterator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E16 RID: 7702
		public new const string MRFullTypeName = "Kitware.VTK.vtkOutEdgeIterator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E17 RID: 7703
		public new static readonly string MRClassNameKey = "class vtkOutEdgeIterator";
	}
}
