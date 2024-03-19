using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCosmicTreeLayoutStrategy
	/// </summary>
	/// <remarks>
	///    tree layout strategy reminiscent of astronomical systems
	///
	///
	/// This layout strategy takes an input tree and places all the children of a
	/// node into a containing circle. The placement is such that each child
	/// placed can be represented with a circle tangent to the containing circle
	/// and (usually) 2 other children. The interior of the circle is left empty
	/// so that graph edges drawn on top of the tree will not obfuscate the tree.
	/// However, when one child is much larger than all the others, it may
	/// encroach on the center of the containing circle; that's OK, because it's
	/// large enough not to be obscured by edges drawn atop it.
	///
	/// @par Thanks:
	/// Thanks to the galaxy and David Thompson hierarchically nested inside it
	/// for inspiring this layout strategy.
	/// </remarks>
	// Token: 0x0200028B RID: 651
	public class vtkCosmicTreeLayoutStrategy : vtkGraphLayoutStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060075D2 RID: 30162 RVA: 0x000AA287 File Offset: 0x000A8487
		static vtkCosmicTreeLayoutStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCosmicTreeLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCosmicTreeLayoutStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060075D3 RID: 30163 RVA: 0x000AA2AF File Offset: 0x000A84AF
		public vtkCosmicTreeLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060075D4 RID: 30164
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCosmicTreeLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060075D5 RID: 30165 RVA: 0x000AA2C0 File Offset: 0x000A84C0
		public new static vtkCosmicTreeLayoutStrategy New()
		{
			vtkCosmicTreeLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCosmicTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060075D6 RID: 30166 RVA: 0x000AA314 File Offset: 0x000A8514
		public vtkCosmicTreeLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060075D7 RID: 30167 RVA: 0x000AA358 File Offset: 0x000A8558
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060075D8 RID: 30168
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCosmicTreeLayoutStrategy_GetLayoutDepth_01(HandleRef pThis);

		/// <summary>
		/// How many levels of the tree should be laid out?
		/// For large trees, you may wish to set the root and maximum depth
		/// in order to retrieve the layout for the visible portion of the tree.
		/// When this value is zero or negative, all nodes below and including
		/// the LayoutRoot will be presented.
		/// This defaults to 0.
		/// </summary>
		// Token: 0x060075D9 RID: 30169 RVA: 0x000AA364 File Offset: 0x000A8564
		public virtual int GetLayoutDepth()
		{
			return vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_GetLayoutDepth_01(base.GetCppThis());
		}

		// Token: 0x060075DA RID: 30170
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCosmicTreeLayoutStrategy_GetLayoutRoot_02(HandleRef pThis);

		/// <summary>
		/// What is the top-most tree node to lay out?
		/// This node will become the largest containing circle in the layout.
		/// Use this in combination with SetLayoutDepth to retrieve the
		/// layout of a subtree of interest for rendering.
		/// Setting LayoutRoot to a negative number signals that the root node
		/// of the tree should be used as the root node of the layout.
		/// This defaults to -1.
		/// </summary>
		// Token: 0x060075DB RID: 30171 RVA: 0x000AA384 File Offset: 0x000A8584
		public virtual long GetLayoutRoot()
		{
			return vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_GetLayoutRoot_02(base.GetCppThis());
		}

		// Token: 0x060075DC RID: 30172
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCosmicTreeLayoutStrategy_GetNodeSizeArrayName_03(HandleRef pThis);

		/// <summary>
		/// Set the array to be used for sizing nodes.
		/// If this is set to an empty string or nullptr (the default),
		/// then all leaf nodes (or all nodes, when SizeLeafNodesOnly is false)
		/// will be assigned a unit size.
		/// </summary>
		// Token: 0x060075DD RID: 30173 RVA: 0x000AA3A4 File Offset: 0x000A85A4
		public virtual string GetNodeSizeArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_GetNodeSizeArrayName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060075DE RID: 30174
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCosmicTreeLayoutStrategy_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060075DF RID: 30175 RVA: 0x000AA3E0 File Offset: 0x000A85E0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060075E0 RID: 30176
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCosmicTreeLayoutStrategy_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060075E1 RID: 30177 RVA: 0x000AA400 File Offset: 0x000A8600
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060075E2 RID: 30178
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCosmicTreeLayoutStrategy_GetSizeLeafNodesOnly_06(HandleRef pThis);

		/// <summary>
		/// Should node size specifications be obeyed at leaf nodes only or
		/// (with scaling as required to meet constraints) at every node in
		/// the tree?
		/// This defaults to true, so that leaf nodes are scaled according to
		/// the size specification provided, and the parent node sizes are
		/// calculated by the algorithm.
		/// </summary>
		// Token: 0x060075E3 RID: 30179 RVA: 0x000AA41C File Offset: 0x000A861C
		public virtual int GetSizeLeafNodesOnly()
		{
			return vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_GetSizeLeafNodesOnly_06(base.GetCppThis());
		}

		// Token: 0x060075E4 RID: 30180
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCosmicTreeLayoutStrategy_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060075E5 RID: 30181 RVA: 0x000AA43C File Offset: 0x000A863C
		public override int IsA(string type)
		{
			return vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x060075E6 RID: 30182
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCosmicTreeLayoutStrategy_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060075E7 RID: 30183 RVA: 0x000AA45C File Offset: 0x000A865C
		public new static int IsTypeOf(string type)
		{
			return vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_IsTypeOf_08(type);
		}

		// Token: 0x060075E8 RID: 30184
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCosmicTreeLayoutStrategy_Layout_09(HandleRef pThis);

		/// <summary>
		/// Perform the layout.
		/// </summary>
		// Token: 0x060075E9 RID: 30185 RVA: 0x000AA476 File Offset: 0x000A8676
		public override void Layout()
		{
			vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_Layout_09(base.GetCppThis());
		}

		// Token: 0x060075EA RID: 30186
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCosmicTreeLayoutStrategy_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060075EB RID: 30187 RVA: 0x000AA488 File Offset: 0x000A8688
		public new vtkCosmicTreeLayoutStrategy NewInstance()
		{
			vtkCosmicTreeLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCosmicTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060075EC RID: 30188
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCosmicTreeLayoutStrategy_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060075ED RID: 30189 RVA: 0x000AA4E4 File Offset: 0x000A86E4
		public new static vtkCosmicTreeLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkCosmicTreeLayoutStrategy vtkCosmicTreeLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCosmicTreeLayoutStrategy = (vtkCosmicTreeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCosmicTreeLayoutStrategy.Register(null);
				}
			}
			return vtkCosmicTreeLayoutStrategy;
		}

		// Token: 0x060075EE RID: 30190
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCosmicTreeLayoutStrategy_SetLayoutDepth_13(HandleRef pThis, int _arg);

		/// <summary>
		/// How many levels of the tree should be laid out?
		/// For large trees, you may wish to set the root and maximum depth
		/// in order to retrieve the layout for the visible portion of the tree.
		/// When this value is zero or negative, all nodes below and including
		/// the LayoutRoot will be presented.
		/// This defaults to 0.
		/// </summary>
		// Token: 0x060075EF RID: 30191 RVA: 0x000AA563 File Offset: 0x000A8763
		public virtual void SetLayoutDepth(int _arg)
		{
			vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_SetLayoutDepth_13(base.GetCppThis(), _arg);
		}

		// Token: 0x060075F0 RID: 30192
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCosmicTreeLayoutStrategy_SetLayoutRoot_14(HandleRef pThis, long _arg);

		/// <summary>
		/// What is the top-most tree node to lay out?
		/// This node will become the largest containing circle in the layout.
		/// Use this in combination with SetLayoutDepth to retrieve the
		/// layout of a subtree of interest for rendering.
		/// Setting LayoutRoot to a negative number signals that the root node
		/// of the tree should be used as the root node of the layout.
		/// This defaults to -1.
		/// </summary>
		// Token: 0x060075F1 RID: 30193 RVA: 0x000AA573 File Offset: 0x000A8773
		public virtual void SetLayoutRoot(long _arg)
		{
			vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_SetLayoutRoot_14(base.GetCppThis(), _arg);
		}

		// Token: 0x060075F2 RID: 30194
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCosmicTreeLayoutStrategy_SetNodeSizeArrayName_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the array to be used for sizing nodes.
		/// If this is set to an empty string or nullptr (the default),
		/// then all leaf nodes (or all nodes, when SizeLeafNodesOnly is false)
		/// will be assigned a unit size.
		/// </summary>
		// Token: 0x060075F3 RID: 30195 RVA: 0x000AA583 File Offset: 0x000A8783
		public virtual void SetNodeSizeArrayName(string _arg)
		{
			vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_SetNodeSizeArrayName_15(base.GetCppThis(), _arg);
		}

		// Token: 0x060075F4 RID: 30196
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCosmicTreeLayoutStrategy_SetSizeLeafNodesOnly_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Should node size specifications be obeyed at leaf nodes only or
		/// (with scaling as required to meet constraints) at every node in
		/// the tree?
		/// This defaults to true, so that leaf nodes are scaled according to
		/// the size specification provided, and the parent node sizes are
		/// calculated by the algorithm.
		/// </summary>
		// Token: 0x060075F5 RID: 30197 RVA: 0x000AA593 File Offset: 0x000A8793
		public virtual void SetSizeLeafNodesOnly(int _arg)
		{
			vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_SetSizeLeafNodesOnly_16(base.GetCppThis(), _arg);
		}

		// Token: 0x060075F6 RID: 30198
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCosmicTreeLayoutStrategy_SizeLeafNodesOnlyOff_17(HandleRef pThis);

		/// <summary>
		/// Should node size specifications be obeyed at leaf nodes only or
		/// (with scaling as required to meet constraints) at every node in
		/// the tree?
		/// This defaults to true, so that leaf nodes are scaled according to
		/// the size specification provided, and the parent node sizes are
		/// calculated by the algorithm.
		/// </summary>
		// Token: 0x060075F7 RID: 30199 RVA: 0x000AA5A3 File Offset: 0x000A87A3
		public virtual void SizeLeafNodesOnlyOff()
		{
			vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_SizeLeafNodesOnlyOff_17(base.GetCppThis());
		}

		// Token: 0x060075F8 RID: 30200
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCosmicTreeLayoutStrategy_SizeLeafNodesOnlyOn_18(HandleRef pThis);

		/// <summary>
		/// Should node size specifications be obeyed at leaf nodes only or
		/// (with scaling as required to meet constraints) at every node in
		/// the tree?
		/// This defaults to true, so that leaf nodes are scaled according to
		/// the size specification provided, and the parent node sizes are
		/// calculated by the algorithm.
		/// </summary>
		// Token: 0x060075F9 RID: 30201 RVA: 0x000AA5B2 File Offset: 0x000A87B2
		public virtual void SizeLeafNodesOnlyOn()
		{
			vtkCosmicTreeLayoutStrategy.vtkCosmicTreeLayoutStrategy_SizeLeafNodesOnlyOn_18(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A24 RID: 2596
		public new const string MRFullTypeName = "Kitware.VTK.vtkCosmicTreeLayoutStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A25 RID: 2597
		public new static readonly string MRClassNameKey = "class vtkCosmicTreeLayoutStrategy";
	}
}
