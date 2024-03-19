using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHyperTreeCursor
	/// </summary>
	/// <remarks>
	///    Objects for depth-first traversal HyperTrees.
	///
	///
	/// Objects that can perform depth-first traversal of HyperTrees.
	/// This is an abstract class.
	/// Cursors are created by the HyperTree implementation.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkObject vtkHyperTree vtkHyperTreeGrid
	///
	/// @par Thanks:
	/// This class was written by Philippe Pebay, Joachim Pouderoux, and Charles Law, Kitware 2013
	/// This class was modified by Guenole Harel and Jacques-Bernard Lekien 2014
	/// This class was revised by Philippe Pebay, 2016
	/// This work was supported by Commissariat a l'Energie Atomique (CEA/DIF)
	/// </seealso>
	// Token: 0x02000A5E RID: 2654
	public abstract class vtkHyperTreeCursor : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601BBB9 RID: 113593 RVA: 0x0026D5C9 File Offset: 0x0026B7C9
		static vtkHyperTreeCursor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHyperTreeCursor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperTreeCursor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601BBBA RID: 113594 RVA: 0x0026D5F1 File Offset: 0x0026B7F1
		public vtkHyperTreeCursor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601BBBB RID: 113595 RVA: 0x0026D5FF File Offset: 0x0026B7FF
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601BBBC RID: 113596
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeCursor_Clone_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a copy of `this'.
		/// \post results_exists:result!=0
		/// \post same_tree: result-&gt;SameTree(this)
		/// </summary>
		// Token: 0x0601BBBD RID: 113597 RVA: 0x0026D60C File Offset: 0x0026B80C
		public virtual vtkHyperTreeCursor Clone()
		{
			vtkHyperTreeCursor vtkHyperTreeCursor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTreeCursor.vtkHyperTreeCursor_Clone_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperTreeCursor = (vtkHyperTreeCursor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperTreeCursor.Register(null);
				}
			}
			return vtkHyperTreeCursor;
		}

		// Token: 0x0601BBBE RID: 113598
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperTreeCursor_GetChildIndex_02(HandleRef pThis);

		/// <summary>
		/// Return the child number of the current vertex relative to its parent.
		/// \pre not_root: !IsRoot().
		/// \post valid_range: result&gt;=0 &amp;&amp; result&lt;GetNumberOfChildren()
		/// </summary>
		// Token: 0x0601BBBF RID: 113599 RVA: 0x0026D67C File Offset: 0x0026B87C
		public virtual int GetChildIndex()
		{
			return vtkHyperTreeCursor.vtkHyperTreeCursor_GetChildIndex_02(base.GetCppThis());
		}

		// Token: 0x0601BBC0 RID: 113600
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperTreeCursor_GetDimension_03(HandleRef pThis);

		/// <summary>
		/// Return the dimension of the tree.
		/// \post positive_result: result&gt;0
		/// </summary>
		// Token: 0x0601BBC1 RID: 113601 RVA: 0x0026D69C File Offset: 0x0026B89C
		public virtual int GetDimension()
		{
			return vtkHyperTreeCursor.vtkHyperTreeCursor_GetDimension_03(base.GetCppThis());
		}

		// Token: 0x0601BBC2 RID: 113602
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkHyperTreeCursor_GetLevel_04(HandleRef pThis);

		/// <summary>
		/// Return the level of the vertex pointed by the cursor.
		/// \post positive_result: result&gt;=0
		/// </summary>
		// Token: 0x0601BBC3 RID: 113603 RVA: 0x0026D6BC File Offset: 0x0026B8BC
		public virtual uint GetLevel()
		{
			return vtkHyperTreeCursor.vtkHyperTreeCursor_GetLevel_04(base.GetCppThis());
		}

		// Token: 0x0601BBC4 RID: 113604
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperTreeCursor_GetNumberOfChildren_05(HandleRef pThis);

		/// <summary>
		/// Return the number of children for each node (non-vertex leaf) of the tree.
		/// \post positive_number: result&gt;0
		/// </summary>
		// Token: 0x0601BBC5 RID: 113605 RVA: 0x0026D6DC File Offset: 0x0026B8DC
		public virtual int GetNumberOfChildren()
		{
			return vtkHyperTreeCursor.vtkHyperTreeCursor_GetNumberOfChildren_05(base.GetCppThis());
		}

		// Token: 0x0601BBC6 RID: 113606
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTreeCursor_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BBC7 RID: 113607 RVA: 0x0026D6FC File Offset: 0x0026B8FC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHyperTreeCursor.vtkHyperTreeCursor_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0601BBC8 RID: 113608
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTreeCursor_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BBC9 RID: 113609 RVA: 0x0026D71C File Offset: 0x0026B91C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHyperTreeCursor.vtkHyperTreeCursor_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0601BBCA RID: 113610
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeCursor_GetTree_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the HyperTree to which the cursor is pointing.
		/// </summary>
		// Token: 0x0601BBCB RID: 113611 RVA: 0x0026D738 File Offset: 0x0026B938
		public virtual vtkHyperTree GetTree()
		{
			vtkHyperTree vtkHyperTree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTreeCursor.vtkHyperTreeCursor_GetTree_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperTree = (vtkHyperTree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperTree.Register(null);
				}
			}
			return vtkHyperTree;
		}

		// Token: 0x0601BBCC RID: 113612
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTreeCursor_GetVertexId_09(HandleRef pThis);

		/// <summary>
		/// Return the index of the current vertex in the tree.
		/// </summary>
		// Token: 0x0601BBCD RID: 113613 RVA: 0x0026D7A8 File Offset: 0x0026B9A8
		public virtual long GetVertexId()
		{
			return vtkHyperTreeCursor.vtkHyperTreeCursor_GetVertexId_09(base.GetCppThis());
		}

		// Token: 0x0601BBCE RID: 113614
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperTreeCursor_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BBCF RID: 113615 RVA: 0x0026D7C8 File Offset: 0x0026B9C8
		public override int IsA(string type)
		{
			return vtkHyperTreeCursor.vtkHyperTreeCursor_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0601BBD0 RID: 113616
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTreeCursor_IsEqual_11(HandleRef pThis, HandleRef other);

		/// <summary>
		/// Is `this' equal to `other'?
		/// \pre other_exists: other!=0
		/// \pre same_hypertree: this-&gt;SameTree(other);
		/// </summary>
		// Token: 0x0601BBD1 RID: 113617 RVA: 0x0026D7E8 File Offset: 0x0026B9E8
		public virtual bool IsEqual(vtkHyperTreeCursor other)
		{
			return vtkHyperTreeCursor.vtkHyperTreeCursor_IsEqual_11(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis()) != 0;
		}

		// Token: 0x0601BBD2 RID: 113618
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTreeCursor_IsLeaf_12(HandleRef pThis);

		/// <summary>
		/// Is the cursor pointing to a leaf?
		/// </summary>
		// Token: 0x0601BBD3 RID: 113619 RVA: 0x0026D824 File Offset: 0x0026BA24
		public virtual bool IsLeaf()
		{
			return vtkHyperTreeCursor.vtkHyperTreeCursor_IsLeaf_12(base.GetCppThis()) != 0;
		}

		// Token: 0x0601BBD4 RID: 113620
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTreeCursor_IsRoot_13(HandleRef pThis);

		/// <summary>
		/// Is the cursor at tree root?
		/// </summary>
		// Token: 0x0601BBD5 RID: 113621 RVA: 0x0026D84C File Offset: 0x0026BA4C
		public virtual bool IsRoot()
		{
			return vtkHyperTreeCursor.vtkHyperTreeCursor_IsRoot_13(base.GetCppThis()) != 0;
		}

		// Token: 0x0601BBD6 RID: 113622
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperTreeCursor_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BBD7 RID: 113623 RVA: 0x0026D874 File Offset: 0x0026BA74
		public new static int IsTypeOf(string type)
		{
			return vtkHyperTreeCursor.vtkHyperTreeCursor_IsTypeOf_14(type);
		}

		// Token: 0x0601BBD8 RID: 113624
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeCursor_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BBD9 RID: 113625 RVA: 0x0026D890 File Offset: 0x0026BA90
		public new vtkHyperTreeCursor NewInstance()
		{
			vtkHyperTreeCursor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTreeCursor.vtkHyperTreeCursor_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperTreeCursor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601BBDA RID: 113626
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeCursor_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BBDB RID: 113627 RVA: 0x0026D8EC File Offset: 0x0026BAEC
		public new static vtkHyperTreeCursor SafeDownCast(vtkObjectBase o)
		{
			vtkHyperTreeCursor vtkHyperTreeCursor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTreeCursor.vtkHyperTreeCursor_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperTreeCursor = (vtkHyperTreeCursor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperTreeCursor.Register(null);
				}
			}
			return vtkHyperTreeCursor;
		}

		// Token: 0x0601BBDC RID: 113628
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperTreeCursor_SameTree_17(HandleRef pThis, HandleRef other);

		/// <summary>
		/// Are `this' and `other' pointing on the same hypertree?
		/// \pre other_exists: other!=0
		/// </summary>
		// Token: 0x0601BBDD RID: 113629 RVA: 0x0026D96C File Offset: 0x0026BB6C
		public virtual int SameTree(vtkHyperTreeCursor other)
		{
			return vtkHyperTreeCursor.vtkHyperTreeCursor_SameTree_17(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		// Token: 0x0601BBDE RID: 113630
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeCursor_SetTree_18(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the HyperTree to which the cursor is pointing.
		/// </summary>
		// Token: 0x0601BBDF RID: 113631 RVA: 0x0026D9A0 File Offset: 0x0026BBA0
		public virtual void SetTree(vtkHyperTree arg0)
		{
			vtkHyperTreeCursor.vtkHyperTreeCursor_SetTree_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601BBE0 RID: 113632
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeCursor_ToChild_19(HandleRef pThis, int child);

		/// <summary>
		/// Move the cursor to child `child' of the current vertex.
		/// \pre not_leaf: !IsLeaf()
		/// \pre valid_child: child&gt;=0 &amp;&amp; child&lt;this-&gt;GetNumberOfChildren()
		/// </summary>
		// Token: 0x0601BBE1 RID: 113633 RVA: 0x0026D9CF File Offset: 0x0026BBCF
		public virtual void ToChild(int child)
		{
			vtkHyperTreeCursor.vtkHyperTreeCursor_ToChild_19(base.GetCppThis(), child);
		}

		// Token: 0x0601BBE2 RID: 113634
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeCursor_ToParent_20(HandleRef pThis);

		/// <summary>
		/// Move the cursor to the parent of the current vertex.
		/// \pre not_root: !IsRoot()
		/// </summary>
		// Token: 0x0601BBE3 RID: 113635 RVA: 0x0026D9DF File Offset: 0x0026BBDF
		public virtual void ToParent()
		{
			vtkHyperTreeCursor.vtkHyperTreeCursor_ToParent_20(base.GetCppThis());
		}

		// Token: 0x0601BBE4 RID: 113636
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeCursor_ToRoot_21(HandleRef pThis);

		/// <summary>
		/// Move the cursor to the root vertex.
		/// \pre can be root
		/// \post is_root: IsRoot()
		/// </summary>
		// Token: 0x0601BBE5 RID: 113637 RVA: 0x0026D9EE File Offset: 0x0026BBEE
		public virtual void ToRoot()
		{
			vtkHyperTreeCursor.vtkHyperTreeCursor_ToRoot_21(base.GetCppThis());
		}

		// Token: 0x0601BBE6 RID: 113638
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeCursor_ToSameVertex_22(HandleRef pThis, HandleRef other);

		/// <summary>
		/// Move the cursor to the same vertex pointed by `other'.
		/// \pre other_exists: other!=0
		/// \pre same_hypertree: this-&gt;SameTree(other);
		/// \post equal: this-&gt;IsEqual(other)
		/// </summary>
		// Token: 0x0601BBE7 RID: 113639 RVA: 0x0026DA00 File Offset: 0x0026BC00
		public virtual void ToSameVertex(vtkHyperTreeCursor other)
		{
			vtkHyperTreeCursor.vtkHyperTreeCursor_ToSameVertex_22(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DB0 RID: 7600
		public new const string MRFullTypeName = "Kitware.VTK.vtkHyperTreeCursor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DB1 RID: 7601
		public new static readonly string MRClassNameKey = "class vtkHyperTreeCursor";
	}
}
