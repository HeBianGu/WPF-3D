using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInEdgeIterator
	/// </summary>
	/// <remarks>
	///    Iterates through all incoming edges to a vertex.
	///
	///
	/// vtkInEdgeIterator iterates through all edges whose target is a particular
	/// vertex. Instantiate this class directly and call Initialize() to traverse
	/// the vertex of a graph. Alternately, use GetInEdges() on the graph to
	/// initialize the iterator. it-&gt;Next() returns a vtkInEdgeType structure,
	/// which contains Id, the edge's id, and Source, the edge's source vertex.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGraph vtkOutEdgeIterator
	/// </seealso>
	// Token: 0x02000A6E RID: 2670
	public class vtkInEdgeIterator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601BF35 RID: 114485 RVA: 0x002727FE File Offset: 0x002709FE
		static vtkInEdgeIterator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInEdgeIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInEdgeIterator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601BF36 RID: 114486 RVA: 0x00272826 File Offset: 0x00270A26
		public vtkInEdgeIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601BF37 RID: 114487
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInEdgeIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BF38 RID: 114488 RVA: 0x00272834 File Offset: 0x00270A34
		public new static vtkInEdgeIterator New()
		{
			vtkInEdgeIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInEdgeIterator.vtkInEdgeIterator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInEdgeIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BF39 RID: 114489 RVA: 0x00272888 File Offset: 0x00270A88
		public vtkInEdgeIterator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInEdgeIterator.vtkInEdgeIterator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601BF3A RID: 114490 RVA: 0x002728CC File Offset: 0x00270ACC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601BF3B RID: 114491
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInEdgeIterator_GetGraph_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the graph and vertex associated with this iterator.
		/// </summary>
		// Token: 0x0601BF3C RID: 114492 RVA: 0x002728D8 File Offset: 0x00270AD8
		public virtual vtkGraph GetGraph()
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInEdgeIterator.vtkInEdgeIterator_GetGraph_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601BF3D RID: 114493
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInEdgeIterator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BF3E RID: 114494 RVA: 0x00272948 File Offset: 0x00270B48
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInEdgeIterator.vtkInEdgeIterator_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601BF3F RID: 114495
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInEdgeIterator_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BF40 RID: 114496 RVA: 0x00272968 File Offset: 0x00270B68
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInEdgeIterator.vtkInEdgeIterator_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601BF41 RID: 114497
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInEdgeIterator_GetVertex_04(HandleRef pThis);

		/// <summary>
		/// Get the graph and vertex associated with this iterator.
		/// </summary>
		// Token: 0x0601BF42 RID: 114498 RVA: 0x00272984 File Offset: 0x00270B84
		public virtual long GetVertex()
		{
			return vtkInEdgeIterator.vtkInEdgeIterator_GetVertex_04(base.GetCppThis());
		}

		// Token: 0x0601BF43 RID: 114499
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkInEdgeIterator_HasNext_05(HandleRef pThis);

		/// <summary>
		/// Whether this iterator has more edges.
		/// </summary>
		// Token: 0x0601BF44 RID: 114500 RVA: 0x002729A4 File Offset: 0x00270BA4
		public bool HasNext()
		{
			return vtkInEdgeIterator.vtkInEdgeIterator_HasNext_05(base.GetCppThis()) != 0;
		}

		// Token: 0x0601BF45 RID: 114501
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInEdgeIterator_Initialize_06(HandleRef pThis, HandleRef g, long v);

		/// <summary>
		/// Initialize the iterator with a graph and vertex.
		/// </summary>
		// Token: 0x0601BF46 RID: 114502 RVA: 0x002729CC File Offset: 0x00270BCC
		public void Initialize(vtkGraph g, long v)
		{
			vtkInEdgeIterator.vtkInEdgeIterator_Initialize_06(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis(), v);
		}

		// Token: 0x0601BF47 RID: 114503
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInEdgeIterator_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BF48 RID: 114504 RVA: 0x002729FC File Offset: 0x00270BFC
		public override int IsA(string type)
		{
			return vtkInEdgeIterator.vtkInEdgeIterator_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601BF49 RID: 114505
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInEdgeIterator_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BF4A RID: 114506 RVA: 0x00272A1C File Offset: 0x00270C1C
		public new static int IsTypeOf(string type)
		{
			return vtkInEdgeIterator.vtkInEdgeIterator_IsTypeOf_08(type);
		}

		// Token: 0x0601BF4B RID: 114507
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInEdgeIterator_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BF4C RID: 114508 RVA: 0x00272A38 File Offset: 0x00270C38
		public new vtkInEdgeIterator NewInstance()
		{
			vtkInEdgeIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInEdgeIterator.vtkInEdgeIterator_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInEdgeIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601BF4D RID: 114509
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInEdgeIterator_NextGraphEdge_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Just like Next(), but
		/// returns heavy-weight vtkGraphEdge object instead of
		/// the vtkEdgeType struct, for use with wrappers.
		/// The graph edge is owned by this iterator, and changes
		/// after each call to NextGraphEdge().
		/// </summary>
		// Token: 0x0601BF4E RID: 114510 RVA: 0x00272A94 File Offset: 0x00270C94
		public vtkGraphEdge NextGraphEdge()
		{
			vtkGraphEdge vtkGraphEdge = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInEdgeIterator.vtkInEdgeIterator_NextGraphEdge_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601BF4F RID: 114511
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInEdgeIterator_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BF50 RID: 114512 RVA: 0x00272B04 File Offset: 0x00270D04
		public new static vtkInEdgeIterator SafeDownCast(vtkObjectBase o)
		{
			vtkInEdgeIterator vtkInEdgeIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInEdgeIterator.vtkInEdgeIterator_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInEdgeIterator = (vtkInEdgeIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInEdgeIterator.Register(null);
				}
			}
			return vtkInEdgeIterator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DD3 RID: 7635
		public new const string MRFullTypeName = "Kitware.VTK.vtkInEdgeIterator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DD4 RID: 7636
		public new static readonly string MRClassNameKey = "class vtkInEdgeIterator";
	}
}
