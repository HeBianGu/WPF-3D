using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkDataAssemblyVisitor
	/// </summary>
	/// <remarks>
	///  visitor API for vtkDataAssembly
	///
	/// vtkDataAssemblyVisitor defines a visitor API for vtkDataAssembly. A concrete
	/// subclass of vtkDataAssemblyVisitor can be passed to `vtkDataAssembly::Visit`
	/// to execute custom code on each node in the data-assembly.
	///
	/// `vtkDataAssembly::Visit` will call `vtkDataAssemblyVisitor::Visit` on each
	/// node in the assembly (or chosen subtree). The traversal order, i.e.
	/// depth-first or breadth-first, is selected by the arguments passed to
	/// `vtkDataAssembly::Visit`. Before traversing a sub-tree for a particular node,
	/// `vtkDataAssemblyVisitor::GetTraverseSubtree` is called, if it returns false,
	/// the subtree is skipped. If it returns true, then then
	/// `vtkDataAssemblyVisitor::BeginSubTree` is called, followed by calls to
	/// `vtkDataAssemblyVisitor::Visit` for each of the child nodes, and finally
	/// `vtkDataAssemblyVisitor::EndSubTree` is called.
	///
	/// In depth-first order, the subtree traversal is recursive. Thus, after
	/// `BeginSubTree` is called for specific node, all its children and their
	/// subtrees are traversed before `EndSubTree` gets called for that node.
	///
	/// In breadth-first order, a first-in-first-out queue is used. A node is
	/// visited, i.e. `vtkDataAssemblyVisitor::Visit` called on it, then if
	/// `GetTraverseSubtree` returns true, `Visit` gets called on all its immediate
	/// children one after another followed by `EndSubTree` on the parent node.
	/// As each of the child nodes are visited, they get added to the queue.
	/// Now, for each node in the queue, the process repeats i.e.
	/// `GetTraverseSubtree` is called, followed by the subtree traversal for that
	/// node. This continues until the queue empty.
	///
	/// </remarks>
	/// <seealso>
	///  vtkDataAssembly
	/// </seealso>
	// Token: 0x020009EC RID: 2540
	public abstract class vtkDataAssemblyVisitor : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A68E RID: 108174 RVA: 0x0024AD0B File Offset: 0x00248F0B
		static vtkDataAssemblyVisitor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataAssemblyVisitor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataAssemblyVisitor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A68F RID: 108175 RVA: 0x0024AD33 File Offset: 0x00248F33
		public vtkDataAssemblyVisitor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A690 RID: 108176 RVA: 0x0024AD41 File Offset: 0x00248F41
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A691 RID: 108177
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataAssemblyVisitor_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A692 RID: 108178 RVA: 0x0024AD4C File Offset: 0x00248F4C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataAssemblyVisitor.vtkDataAssemblyVisitor_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601A693 RID: 108179
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataAssemblyVisitor_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A694 RID: 108180 RVA: 0x0024AD6C File Offset: 0x00248F6C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataAssemblyVisitor.vtkDataAssemblyVisitor_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601A695 RID: 108181
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataAssemblyVisitor_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A696 RID: 108182 RVA: 0x0024AD88 File Offset: 0x00248F88
		public override int IsA(string type)
		{
			return vtkDataAssemblyVisitor.vtkDataAssemblyVisitor_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601A697 RID: 108183
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataAssemblyVisitor_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A698 RID: 108184 RVA: 0x0024ADA8 File Offset: 0x00248FA8
		public new static int IsTypeOf(string type)
		{
			return vtkDataAssemblyVisitor.vtkDataAssemblyVisitor_IsTypeOf_04(type);
		}

		// Token: 0x0601A699 RID: 108185
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataAssemblyVisitor_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A69A RID: 108186 RVA: 0x0024ADC4 File Offset: 0x00248FC4
		public new vtkDataAssemblyVisitor NewInstance()
		{
			vtkDataAssemblyVisitor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataAssemblyVisitor.vtkDataAssemblyVisitor_NewInstance_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataAssemblyVisitor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A69B RID: 108187
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataAssemblyVisitor_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A69C RID: 108188 RVA: 0x0024AE20 File Offset: 0x00249020
		public new static vtkDataAssemblyVisitor SafeDownCast(vtkObjectBase o)
		{
			vtkDataAssemblyVisitor vtkDataAssemblyVisitor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataAssemblyVisitor.vtkDataAssemblyVisitor_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataAssemblyVisitor = (vtkDataAssemblyVisitor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataAssemblyVisitor.Register(null);
				}
			}
			return vtkDataAssemblyVisitor;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CA8 RID: 7336
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataAssemblyVisitor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CA9 RID: 7337
		public new static readonly string MRClassNameKey = "class vtkDataAssemblyVisitor";
	}
}
