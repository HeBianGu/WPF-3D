using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTreeIterator
	/// </summary>
	/// <remarks>
	///    Abstract class for iterator over a vtkTree.
	///
	///
	/// The base class for tree iterators vtkTreeBFSIterator and vtkTreeDFSIterator.
	///
	/// After setting up the iterator, the normal mode of operation is to
	/// set up a &lt;code&gt;while(iter-&gt;HasNext())&lt;/code&gt; loop, with the statement
	/// &lt;code&gt;vtkIdType vertex = iter-&gt;Next()&lt;/code&gt; inside the loop.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTreeBFSIterator vtkTreeDFSIterator
	/// </seealso>
	// Token: 0x02000AD5 RID: 2773
	public abstract class vtkTreeIterator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D37F RID: 119679 RVA: 0x0029342B File Offset: 0x0029162B
		static vtkTreeIterator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeIterator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D380 RID: 119680 RVA: 0x00293453 File Offset: 0x00291653
		public vtkTreeIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D381 RID: 119681 RVA: 0x00293461 File Offset: 0x00291661
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D382 RID: 119682
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeIterator_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D383 RID: 119683 RVA: 0x0029346C File Offset: 0x0029166C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTreeIterator.vtkTreeIterator_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601D384 RID: 119684
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeIterator_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D385 RID: 119685 RVA: 0x0029348C File Offset: 0x0029168C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTreeIterator.vtkTreeIterator_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601D386 RID: 119686
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeIterator_GetStartVertex_03(HandleRef pThis);

		/// <summary>
		/// The start vertex of the traversal.
		/// The tree iterator will only iterate over the subtree rooted at vertex.
		/// If not set (or set to a negative value), starts at the root of the tree.
		/// </summary>
		// Token: 0x0601D387 RID: 119687 RVA: 0x002934A8 File Offset: 0x002916A8
		public virtual long GetStartVertex()
		{
			return vtkTreeIterator.vtkTreeIterator_GetStartVertex_03(base.GetCppThis());
		}

		// Token: 0x0601D388 RID: 119688
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeIterator_GetTree_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the graph to iterate over.
		/// </summary>
		// Token: 0x0601D389 RID: 119689 RVA: 0x002934C8 File Offset: 0x002916C8
		public virtual vtkTree GetTree()
		{
			vtkTree vtkTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeIterator.vtkTreeIterator_GetTree_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTree = (vtkTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTree.Register(null);
				}
			}
			return vtkTree;
		}

		// Token: 0x0601D38A RID: 119690
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTreeIterator_HasNext_05(HandleRef pThis);

		/// <summary>
		/// Return true when all vertices have been visited.
		/// </summary>
		// Token: 0x0601D38B RID: 119691 RVA: 0x00293538 File Offset: 0x00291738
		public bool HasNext()
		{
			return vtkTreeIterator.vtkTreeIterator_HasNext_05(base.GetCppThis()) != 0;
		}

		// Token: 0x0601D38C RID: 119692
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeIterator_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D38D RID: 119693 RVA: 0x00293560 File Offset: 0x00291760
		public override int IsA(string type)
		{
			return vtkTreeIterator.vtkTreeIterator_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601D38E RID: 119694
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeIterator_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D38F RID: 119695 RVA: 0x00293580 File Offset: 0x00291780
		public new static int IsTypeOf(string type)
		{
			return vtkTreeIterator.vtkTreeIterator_IsTypeOf_07(type);
		}

		// Token: 0x0601D390 RID: 119696
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeIterator_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D391 RID: 119697 RVA: 0x0029359C File Offset: 0x0029179C
		public new vtkTreeIterator NewInstance()
		{
			vtkTreeIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeIterator.vtkTreeIterator_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D392 RID: 119698
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeIterator_Next_09(HandleRef pThis);

		/// <summary>
		/// The next vertex visited in the graph.
		/// </summary>
		// Token: 0x0601D393 RID: 119699 RVA: 0x002935F8 File Offset: 0x002917F8
		public long Next()
		{
			return vtkTreeIterator.vtkTreeIterator_Next_09(base.GetCppThis());
		}

		// Token: 0x0601D394 RID: 119700
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeIterator_Restart_10(HandleRef pThis);

		/// <summary>
		/// Reset the iterator to its start vertex.
		/// </summary>
		// Token: 0x0601D395 RID: 119701 RVA: 0x00293617 File Offset: 0x00291817
		public void Restart()
		{
			vtkTreeIterator.vtkTreeIterator_Restart_10(base.GetCppThis());
		}

		// Token: 0x0601D396 RID: 119702
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeIterator_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D397 RID: 119703 RVA: 0x00293628 File Offset: 0x00291828
		public new static vtkTreeIterator SafeDownCast(vtkObjectBase o)
		{
			vtkTreeIterator vtkTreeIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeIterator.vtkTreeIterator_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeIterator = (vtkTreeIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeIterator.Register(null);
				}
			}
			return vtkTreeIterator;
		}

		// Token: 0x0601D398 RID: 119704
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeIterator_SetStartVertex_12(HandleRef pThis, long vertex);

		/// <summary>
		/// The start vertex of the traversal.
		/// The tree iterator will only iterate over the subtree rooted at vertex.
		/// If not set (or set to a negative value), starts at the root of the tree.
		/// </summary>
		// Token: 0x0601D399 RID: 119705 RVA: 0x002936A7 File Offset: 0x002918A7
		public void SetStartVertex(long vertex)
		{
			vtkTreeIterator.vtkTreeIterator_SetStartVertex_12(base.GetCppThis(), vertex);
		}

		// Token: 0x0601D39A RID: 119706
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeIterator_SetTree_13(HandleRef pThis, HandleRef tree);

		/// <summary>
		/// Set/get the graph to iterate over.
		/// </summary>
		// Token: 0x0601D39B RID: 119707 RVA: 0x002936B8 File Offset: 0x002918B8
		public void SetTree(vtkTree tree)
		{
			vtkTreeIterator.vtkTreeIterator_SetTree_13(base.GetCppThis(), (tree == null) ? default(HandleRef) : tree.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001ED0 RID: 7888
		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeIterator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001ED1 RID: 7889
		public new static readonly string MRClassNameKey = "class vtkTreeIterator";
	}
}
