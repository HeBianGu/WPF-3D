using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkKCoreDecomposition
	/// </summary>
	/// <remarks>
	///    Compute the k-core decomposition of the input graph.
	///
	///
	/// The k-core decomposition is a graph partitioning strategy that is useful for
	/// analyzing the structure of large networks. A k-core of a graph G is a maximal
	/// connected subgraph of G in which all vertices have degree at least k.  The k-core
	/// membership for each vertex of the input graph is found on the vertex data of the
	/// output graph as an array named 'KCoreDecompositionNumbers' by default.  The algorithm
	/// used to find the k-cores has O(number of graph edges) running time, and is described
	/// in the following reference paper.
	///
	/// An O(m) Algorithm for Cores Decomposition of Networks
	///   V. Batagelj, M. Zaversnik, 2001
	///
	/// @par Thanks:
	/// Thanks to Thomas Otahal from Sandia National Laboratories for providing this
	/// implementation.
	/// </remarks>
	// Token: 0x02000682 RID: 1666
	public class vtkKCoreDecomposition : vtkGraphAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011E73 RID: 73331 RVA: 0x00190EAB File Offset: 0x0018F0AB
		static vtkKCoreDecomposition()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkKCoreDecomposition.MRClassNameKey, Type.GetType("Kitware.VTK.vtkKCoreDecomposition"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011E74 RID: 73332 RVA: 0x00190ED3 File Offset: 0x0018F0D3
		public vtkKCoreDecomposition(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011E75 RID: 73333
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKCoreDecomposition_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E76 RID: 73334 RVA: 0x00190EE4 File Offset: 0x0018F0E4
		public new static vtkKCoreDecomposition New()
		{
			vtkKCoreDecomposition result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKCoreDecomposition.vtkKCoreDecomposition_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKCoreDecomposition)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E77 RID: 73335 RVA: 0x00190F38 File Offset: 0x0018F138
		public vtkKCoreDecomposition() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkKCoreDecomposition.vtkKCoreDecomposition_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011E78 RID: 73336 RVA: 0x00190F7C File Offset: 0x0018F17C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011E79 RID: 73337
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKCoreDecomposition_CheckInputGraphOff_01(HandleRef pThis);

		/// <summary>
		/// Check the input graph for self loops and parallel
		/// edges.  The k-core is not defined for graphs that
		/// contain either of these.  Default is on.
		/// </summary>
		// Token: 0x06011E7A RID: 73338 RVA: 0x00190F87 File Offset: 0x0018F187
		public virtual void CheckInputGraphOff()
		{
			vtkKCoreDecomposition.vtkKCoreDecomposition_CheckInputGraphOff_01(base.GetCppThis());
		}

		// Token: 0x06011E7B RID: 73339
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKCoreDecomposition_CheckInputGraphOn_02(HandleRef pThis);

		/// <summary>
		/// Check the input graph for self loops and parallel
		/// edges.  The k-core is not defined for graphs that
		/// contain either of these.  Default is on.
		/// </summary>
		// Token: 0x06011E7C RID: 73340 RVA: 0x00190F96 File Offset: 0x0018F196
		public virtual void CheckInputGraphOn()
		{
			vtkKCoreDecomposition.vtkKCoreDecomposition_CheckInputGraphOn_02(base.GetCppThis());
		}

		// Token: 0x06011E7D RID: 73341
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkKCoreDecomposition_GetCheckInputGraph_03(HandleRef pThis);

		/// <summary>
		/// Check the input graph for self loops and parallel
		/// edges.  The k-core is not defined for graphs that
		/// contain either of these.  Default is on.
		/// </summary>
		// Token: 0x06011E7E RID: 73342 RVA: 0x00190FA8 File Offset: 0x0018F1A8
		public virtual bool GetCheckInputGraph()
		{
			return vtkKCoreDecomposition.vtkKCoreDecomposition_GetCheckInputGraph_03(base.GetCppThis()) != 0;
		}

		// Token: 0x06011E7F RID: 73343
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKCoreDecomposition_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E80 RID: 73344 RVA: 0x00190FD0 File Offset: 0x0018F1D0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkKCoreDecomposition.vtkKCoreDecomposition_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06011E81 RID: 73345
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKCoreDecomposition_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E82 RID: 73346 RVA: 0x00190FF0 File Offset: 0x0018F1F0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkKCoreDecomposition.vtkKCoreDecomposition_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06011E83 RID: 73347
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkKCoreDecomposition_GetUseInDegreeNeighbors_06(HandleRef pThis);

		/// <summary>
		/// Directed graphs only.  Use only the in edges to
		/// compute the vertex degree of a vertex.  The default
		/// is to use both in and out edges to compute vertex
		/// degree.
		/// </summary>
		// Token: 0x06011E84 RID: 73348 RVA: 0x0019100C File Offset: 0x0018F20C
		public virtual bool GetUseInDegreeNeighbors()
		{
			return vtkKCoreDecomposition.vtkKCoreDecomposition_GetUseInDegreeNeighbors_06(base.GetCppThis()) != 0;
		}

		// Token: 0x06011E85 RID: 73349
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkKCoreDecomposition_GetUseOutDegreeNeighbors_07(HandleRef pThis);

		/// <summary>
		/// Directed graphs only.  Use only the out edges to
		/// compute the vertex degree of a vertex.  The default
		/// is to use both in and out edges to compute vertex
		/// degree.
		/// </summary>
		// Token: 0x06011E86 RID: 73350 RVA: 0x00191034 File Offset: 0x0018F234
		public virtual bool GetUseOutDegreeNeighbors()
		{
			return vtkKCoreDecomposition.vtkKCoreDecomposition_GetUseOutDegreeNeighbors_07(base.GetCppThis()) != 0;
		}

		// Token: 0x06011E87 RID: 73351
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKCoreDecomposition_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E88 RID: 73352 RVA: 0x0019105C File Offset: 0x0018F25C
		public override int IsA(string type)
		{
			return vtkKCoreDecomposition.vtkKCoreDecomposition_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06011E89 RID: 73353
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKCoreDecomposition_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E8A RID: 73354 RVA: 0x0019107C File Offset: 0x0018F27C
		public new static int IsTypeOf(string type)
		{
			return vtkKCoreDecomposition.vtkKCoreDecomposition_IsTypeOf_09(type);
		}

		// Token: 0x06011E8B RID: 73355
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKCoreDecomposition_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E8C RID: 73356 RVA: 0x00191098 File Offset: 0x0018F298
		public new vtkKCoreDecomposition NewInstance()
		{
			vtkKCoreDecomposition result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKCoreDecomposition.vtkKCoreDecomposition_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKCoreDecomposition)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011E8D RID: 73357
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKCoreDecomposition_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E8E RID: 73358 RVA: 0x001910F4 File Offset: 0x0018F2F4
		public new static vtkKCoreDecomposition SafeDownCast(vtkObjectBase o)
		{
			vtkKCoreDecomposition vtkKCoreDecomposition = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKCoreDecomposition.vtkKCoreDecomposition_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKCoreDecomposition = (vtkKCoreDecomposition)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKCoreDecomposition.Register(null);
				}
			}
			return vtkKCoreDecomposition;
		}

		// Token: 0x06011E8F RID: 73359
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKCoreDecomposition_SetCheckInputGraph_13(HandleRef pThis, byte _arg);

		/// <summary>
		/// Check the input graph for self loops and parallel
		/// edges.  The k-core is not defined for graphs that
		/// contain either of these.  Default is on.
		/// </summary>
		// Token: 0x06011E90 RID: 73360 RVA: 0x00191173 File Offset: 0x0018F373
		public virtual void SetCheckInputGraph(bool _arg)
		{
			vtkKCoreDecomposition.vtkKCoreDecomposition_SetCheckInputGraph_13(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011E91 RID: 73361
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKCoreDecomposition_SetOutputArrayName_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the output array name. If no output array name is
		/// set then the name 'KCoreDecompositionNumbers' is used.
		/// </summary>
		// Token: 0x06011E92 RID: 73362 RVA: 0x0019118B File Offset: 0x0018F38B
		public virtual void SetOutputArrayName(string _arg)
		{
			vtkKCoreDecomposition.vtkKCoreDecomposition_SetOutputArrayName_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06011E93 RID: 73363
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKCoreDecomposition_SetUseInDegreeNeighbors_15(HandleRef pThis, byte _arg);

		/// <summary>
		/// Directed graphs only.  Use only the in edges to
		/// compute the vertex degree of a vertex.  The default
		/// is to use both in and out edges to compute vertex
		/// degree.
		/// </summary>
		// Token: 0x06011E94 RID: 73364 RVA: 0x0019119B File Offset: 0x0018F39B
		public virtual void SetUseInDegreeNeighbors(bool _arg)
		{
			vtkKCoreDecomposition.vtkKCoreDecomposition_SetUseInDegreeNeighbors_15(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011E95 RID: 73365
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKCoreDecomposition_SetUseOutDegreeNeighbors_16(HandleRef pThis, byte _arg);

		/// <summary>
		/// Directed graphs only.  Use only the out edges to
		/// compute the vertex degree of a vertex.  The default
		/// is to use both in and out edges to compute vertex
		/// degree.
		/// </summary>
		// Token: 0x06011E96 RID: 73366 RVA: 0x001911B3 File Offset: 0x0018F3B3
		public virtual void SetUseOutDegreeNeighbors(bool _arg)
		{
			vtkKCoreDecomposition.vtkKCoreDecomposition_SetUseOutDegreeNeighbors_16(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011E97 RID: 73367
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKCoreDecomposition_UseInDegreeNeighborsOff_17(HandleRef pThis);

		/// <summary>
		/// Directed graphs only.  Use only the in edges to
		/// compute the vertex degree of a vertex.  The default
		/// is to use both in and out edges to compute vertex
		/// degree.
		/// </summary>
		// Token: 0x06011E98 RID: 73368 RVA: 0x001911CB File Offset: 0x0018F3CB
		public virtual void UseInDegreeNeighborsOff()
		{
			vtkKCoreDecomposition.vtkKCoreDecomposition_UseInDegreeNeighborsOff_17(base.GetCppThis());
		}

		// Token: 0x06011E99 RID: 73369
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKCoreDecomposition_UseInDegreeNeighborsOn_18(HandleRef pThis);

		/// <summary>
		/// Directed graphs only.  Use only the in edges to
		/// compute the vertex degree of a vertex.  The default
		/// is to use both in and out edges to compute vertex
		/// degree.
		/// </summary>
		// Token: 0x06011E9A RID: 73370 RVA: 0x001911DA File Offset: 0x0018F3DA
		public virtual void UseInDegreeNeighborsOn()
		{
			vtkKCoreDecomposition.vtkKCoreDecomposition_UseInDegreeNeighborsOn_18(base.GetCppThis());
		}

		// Token: 0x06011E9B RID: 73371
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKCoreDecomposition_UseOutDegreeNeighborsOff_19(HandleRef pThis);

		/// <summary>
		/// Directed graphs only.  Use only the out edges to
		/// compute the vertex degree of a vertex.  The default
		/// is to use both in and out edges to compute vertex
		/// degree.
		/// </summary>
		// Token: 0x06011E9C RID: 73372 RVA: 0x001911E9 File Offset: 0x0018F3E9
		public virtual void UseOutDegreeNeighborsOff()
		{
			vtkKCoreDecomposition.vtkKCoreDecomposition_UseOutDegreeNeighborsOff_19(base.GetCppThis());
		}

		// Token: 0x06011E9D RID: 73373
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKCoreDecomposition_UseOutDegreeNeighborsOn_20(HandleRef pThis);

		/// <summary>
		/// Directed graphs only.  Use only the out edges to
		/// compute the vertex degree of a vertex.  The default
		/// is to use both in and out edges to compute vertex
		/// degree.
		/// </summary>
		// Token: 0x06011E9E RID: 73374 RVA: 0x001911F8 File Offset: 0x0018F3F8
		public virtual void UseOutDegreeNeighborsOn()
		{
			vtkKCoreDecomposition.vtkKCoreDecomposition_UseOutDegreeNeighborsOn_20(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014AD RID: 5293
		public new const string MRFullTypeName = "Kitware.VTK.vtkKCoreDecomposition";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014AE RID: 5294
		public new static readonly string MRClassNameKey = "class vtkKCoreDecomposition";
	}
}
