using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAdjacentVertexIterator
	/// </summary>
	/// <remarks>
	///    Iterates through adjacent vertices in a graph.
	///
	///
	/// vtkAdjacentVertexIterator iterates through all vertices adjacent to a
	/// vertex, i.e. the vertices which may be reached by traversing an out edge
	/// of the source vertex. Use graph-&gt;GetAdjacentVertices(v, it) to initialize
	/// the iterator.
	///
	///
	///
	/// </remarks>
	// Token: 0x020009F1 RID: 2545
	public class vtkAdjacentVertexIterator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A6E0 RID: 108256 RVA: 0x0024B37A File Offset: 0x0024957A
		static vtkAdjacentVertexIterator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAdjacentVertexIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAdjacentVertexIterator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A6E1 RID: 108257 RVA: 0x0024B3A2 File Offset: 0x002495A2
		public vtkAdjacentVertexIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A6E2 RID: 108258
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAdjacentVertexIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A6E3 RID: 108259 RVA: 0x0024B3B0 File Offset: 0x002495B0
		public new static vtkAdjacentVertexIterator New()
		{
			vtkAdjacentVertexIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAdjacentVertexIterator.vtkAdjacentVertexIterator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAdjacentVertexIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A6E4 RID: 108260 RVA: 0x0024B404 File Offset: 0x00249604
		public vtkAdjacentVertexIterator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAdjacentVertexIterator.vtkAdjacentVertexIterator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A6E5 RID: 108261 RVA: 0x0024B448 File Offset: 0x00249648
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A6E6 RID: 108262
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAdjacentVertexIterator_GetGraph_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the graph and vertex associated with this iterator.
		/// </summary>
		// Token: 0x0601A6E7 RID: 108263 RVA: 0x0024B454 File Offset: 0x00249654
		public virtual vtkGraph GetGraph()
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAdjacentVertexIterator.vtkAdjacentVertexIterator_GetGraph_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601A6E8 RID: 108264
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAdjacentVertexIterator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A6E9 RID: 108265 RVA: 0x0024B4C4 File Offset: 0x002496C4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAdjacentVertexIterator.vtkAdjacentVertexIterator_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601A6EA RID: 108266
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAdjacentVertexIterator_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A6EB RID: 108267 RVA: 0x0024B4E4 File Offset: 0x002496E4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAdjacentVertexIterator.vtkAdjacentVertexIterator_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601A6EC RID: 108268
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAdjacentVertexIterator_GetVertex_04(HandleRef pThis);

		/// <summary>
		/// Get the graph and vertex associated with this iterator.
		/// </summary>
		// Token: 0x0601A6ED RID: 108269 RVA: 0x0024B500 File Offset: 0x00249700
		public virtual long GetVertex()
		{
			return vtkAdjacentVertexIterator.vtkAdjacentVertexIterator_GetVertex_04(base.GetCppThis());
		}

		// Token: 0x0601A6EE RID: 108270
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAdjacentVertexIterator_HasNext_05(HandleRef pThis);

		/// <summary>
		/// Whether this iterator has more edges.
		/// </summary>
		// Token: 0x0601A6EF RID: 108271 RVA: 0x0024B520 File Offset: 0x00249720
		public bool HasNext()
		{
			return vtkAdjacentVertexIterator.vtkAdjacentVertexIterator_HasNext_05(base.GetCppThis()) != 0;
		}

		// Token: 0x0601A6F0 RID: 108272
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAdjacentVertexIterator_Initialize_06(HandleRef pThis, HandleRef g, long v);

		/// <summary>
		/// Initialize the iterator with a graph and vertex.
		/// </summary>
		// Token: 0x0601A6F1 RID: 108273 RVA: 0x0024B548 File Offset: 0x00249748
		public void Initialize(vtkGraph g, long v)
		{
			vtkAdjacentVertexIterator.vtkAdjacentVertexIterator_Initialize_06(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis(), v);
		}

		// Token: 0x0601A6F2 RID: 108274
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAdjacentVertexIterator_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A6F3 RID: 108275 RVA: 0x0024B578 File Offset: 0x00249778
		public override int IsA(string type)
		{
			return vtkAdjacentVertexIterator.vtkAdjacentVertexIterator_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601A6F4 RID: 108276
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAdjacentVertexIterator_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A6F5 RID: 108277 RVA: 0x0024B598 File Offset: 0x00249798
		public new static int IsTypeOf(string type)
		{
			return vtkAdjacentVertexIterator.vtkAdjacentVertexIterator_IsTypeOf_08(type);
		}

		// Token: 0x0601A6F6 RID: 108278
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAdjacentVertexIterator_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A6F7 RID: 108279 RVA: 0x0024B5B4 File Offset: 0x002497B4
		public new vtkAdjacentVertexIterator NewInstance()
		{
			vtkAdjacentVertexIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAdjacentVertexIterator.vtkAdjacentVertexIterator_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAdjacentVertexIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A6F8 RID: 108280
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAdjacentVertexIterator_Next_11(HandleRef pThis);

		/// <summary>
		/// Returns the next edge in the graph.
		/// </summary>
		// Token: 0x0601A6F9 RID: 108281 RVA: 0x0024B610 File Offset: 0x00249810
		public long Next()
		{
			return vtkAdjacentVertexIterator.vtkAdjacentVertexIterator_Next_11(base.GetCppThis());
		}

		// Token: 0x0601A6FA RID: 108282
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAdjacentVertexIterator_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A6FB RID: 108283 RVA: 0x0024B630 File Offset: 0x00249830
		public new static vtkAdjacentVertexIterator SafeDownCast(vtkObjectBase o)
		{
			vtkAdjacentVertexIterator vtkAdjacentVertexIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAdjacentVertexIterator.vtkAdjacentVertexIterator_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAdjacentVertexIterator = (vtkAdjacentVertexIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAdjacentVertexIterator.Register(null);
				}
			}
			return vtkAdjacentVertexIterator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CB7 RID: 7351
		public new const string MRFullTypeName = "Kitware.VTK.vtkAdjacentVertexIterator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CB8 RID: 7352
		public new static readonly string MRClassNameKey = "class vtkAdjacentVertexIterator";
	}
}
