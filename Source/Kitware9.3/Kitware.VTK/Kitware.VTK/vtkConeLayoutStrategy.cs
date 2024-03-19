using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkConeLayoutStrategy
	/// </summary>
	/// <remarks>
	///    produce a cone-tree layout for a forest
	///
	/// vtkConeLayoutStrategy positions the nodes of a tree(forest) in 3D
	/// space based on the cone-tree approach first described by
	/// Robertson, Mackinlay and Card in Proc. CHI'91.  This
	/// implementation incorporates refinements to the layout
	/// developed by Carriere and Kazman, and by Auber.
	///
	/// The input graph must be a forest (i.e. a set of trees, or a
	/// single tree); in the case of a forest, the input will be
	/// converted to a single tree by introducing a new root node,
	/// and connecting each root in the input forest to the meta-root.
	/// The tree is then laid out, after which the meta-root is removed.
	///
	/// The cones are positioned so that children lie in planes parallel
	/// to the X-Y plane, with the axis of cones parallel to Z, and
	/// with Z coordinate increasing with distance of nodes from the root.
	///
	/// @par Thanks:
	/// Thanks to David Duke from the University of Leeds for providing this
	/// implementation.
	/// </remarks>
	// Token: 0x02000289 RID: 649
	public class vtkConeLayoutStrategy : vtkGraphLayoutStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007566 RID: 30054 RVA: 0x000A9A7B File Offset: 0x000A7C7B
		static vtkConeLayoutStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkConeLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkConeLayoutStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007567 RID: 30055 RVA: 0x000A9AA3 File Offset: 0x000A7CA3
		public vtkConeLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007568 RID: 30056
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConeLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007569 RID: 30057 RVA: 0x000A9AB4 File Offset: 0x000A7CB4
		public new static vtkConeLayoutStrategy New()
		{
			vtkConeLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConeLayoutStrategy.vtkConeLayoutStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600756A RID: 30058 RVA: 0x000A9B08 File Offset: 0x000A7D08
		public vtkConeLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkConeLayoutStrategy.vtkConeLayoutStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600756B RID: 30059 RVA: 0x000A9B4C File Offset: 0x000A7D4C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600756C RID: 30060
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConeLayoutStrategy_CompressionOff_01(HandleRef pThis);

		/// <summary>
		/// Determine if layout should be compressed, i.e. the
		/// layout puts children closer together, possibly allowing
		/// sub-trees to overlap.  This is useful if the tree is
		/// actually the spanning tree of a graph.  For "real" trees,
		/// non-compressed layout is best, and is the default.
		/// </summary>
		// Token: 0x0600756D RID: 30061 RVA: 0x000A9B57 File Offset: 0x000A7D57
		public virtual void CompressionOff()
		{
			vtkConeLayoutStrategy.vtkConeLayoutStrategy_CompressionOff_01(base.GetCppThis());
		}

		// Token: 0x0600756E RID: 30062
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConeLayoutStrategy_CompressionOn_02(HandleRef pThis);

		/// <summary>
		/// Determine if layout should be compressed, i.e. the
		/// layout puts children closer together, possibly allowing
		/// sub-trees to overlap.  This is useful if the tree is
		/// actually the spanning tree of a graph.  For "real" trees,
		/// non-compressed layout is best, and is the default.
		/// </summary>
		// Token: 0x0600756F RID: 30063 RVA: 0x000A9B66 File Offset: 0x000A7D66
		public virtual void CompressionOn()
		{
			vtkConeLayoutStrategy.vtkConeLayoutStrategy_CompressionOn_02(base.GetCppThis());
		}

		// Token: 0x06007570 RID: 30064
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkConeLayoutStrategy_GetCompactness_03(HandleRef pThis);

		/// <summary>
		/// Determine the compactness, the ratio between the
		/// average width of a cone in the tree, and the
		/// height of the cone.  The default setting is 0.75
		/// which (empirically) seems reasonable, but this
		/// will need adapting depending on the data.
		/// </summary>
		// Token: 0x06007571 RID: 30065 RVA: 0x000A9B78 File Offset: 0x000A7D78
		public virtual float GetCompactness()
		{
			return vtkConeLayoutStrategy.vtkConeLayoutStrategy_GetCompactness_03(base.GetCppThis());
		}

		// Token: 0x06007572 RID: 30066
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConeLayoutStrategy_GetCompression_04(HandleRef pThis);

		/// <summary>
		/// Determine if layout should be compressed, i.e. the
		/// layout puts children closer together, possibly allowing
		/// sub-trees to overlap.  This is useful if the tree is
		/// actually the spanning tree of a graph.  For "real" trees,
		/// non-compressed layout is best, and is the default.
		/// </summary>
		// Token: 0x06007573 RID: 30067 RVA: 0x000A9B98 File Offset: 0x000A7D98
		public virtual int GetCompression()
		{
			return vtkConeLayoutStrategy.vtkConeLayoutStrategy_GetCompression_04(base.GetCppThis());
		}

		// Token: 0x06007574 RID: 30068
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkConeLayoutStrategy_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007575 RID: 30069 RVA: 0x000A9BB8 File Offset: 0x000A7DB8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkConeLayoutStrategy.vtkConeLayoutStrategy_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06007576 RID: 30070
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkConeLayoutStrategy_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007577 RID: 30071 RVA: 0x000A9BD8 File Offset: 0x000A7DD8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkConeLayoutStrategy.vtkConeLayoutStrategy_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06007578 RID: 30072
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkConeLayoutStrategy_GetSpacing_07(HandleRef pThis);

		/// <summary>
		/// Set the spacing parameter that affects space between
		/// layers of the tree.  If compression is on, Spacing is the
		/// actual distance between layers.  If compression is off,
		/// actual distance also includes a factor of the compactness
		/// and maximum cone radius.
		/// </summary>
		// Token: 0x06007579 RID: 30073 RVA: 0x000A9BF4 File Offset: 0x000A7DF4
		public virtual float GetSpacing()
		{
			return vtkConeLayoutStrategy.vtkConeLayoutStrategy_GetSpacing_07(base.GetCppThis());
		}

		// Token: 0x0600757A RID: 30074
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConeLayoutStrategy_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600757B RID: 30075 RVA: 0x000A9C14 File Offset: 0x000A7E14
		public override int IsA(string type)
		{
			return vtkConeLayoutStrategy.vtkConeLayoutStrategy_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0600757C RID: 30076
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkConeLayoutStrategy_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600757D RID: 30077 RVA: 0x000A9C34 File Offset: 0x000A7E34
		public new static int IsTypeOf(string type)
		{
			return vtkConeLayoutStrategy.vtkConeLayoutStrategy_IsTypeOf_09(type);
		}

		// Token: 0x0600757E RID: 30078
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConeLayoutStrategy_Layout_10(HandleRef pThis);

		/// <summary>
		/// Perform the layout.
		/// </summary>
		// Token: 0x0600757F RID: 30079 RVA: 0x000A9C4E File Offset: 0x000A7E4E
		public override void Layout()
		{
			vtkConeLayoutStrategy.vtkConeLayoutStrategy_Layout_10(base.GetCppThis());
		}

		// Token: 0x06007580 RID: 30080
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConeLayoutStrategy_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007581 RID: 30081 RVA: 0x000A9C60 File Offset: 0x000A7E60
		public new vtkConeLayoutStrategy NewInstance()
		{
			vtkConeLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConeLayoutStrategy.vtkConeLayoutStrategy_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007582 RID: 30082
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkConeLayoutStrategy_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007583 RID: 30083 RVA: 0x000A9CBC File Offset: 0x000A7EBC
		public new static vtkConeLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkConeLayoutStrategy vtkConeLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkConeLayoutStrategy.vtkConeLayoutStrategy_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkConeLayoutStrategy = (vtkConeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkConeLayoutStrategy.Register(null);
				}
			}
			return vtkConeLayoutStrategy;
		}

		// Token: 0x06007584 RID: 30084
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConeLayoutStrategy_SetCompactness_14(HandleRef pThis, float _arg);

		/// <summary>
		/// Determine the compactness, the ratio between the
		/// average width of a cone in the tree, and the
		/// height of the cone.  The default setting is 0.75
		/// which (empirically) seems reasonable, but this
		/// will need adapting depending on the data.
		/// </summary>
		// Token: 0x06007585 RID: 30085 RVA: 0x000A9D3B File Offset: 0x000A7F3B
		public virtual void SetCompactness(float _arg)
		{
			vtkConeLayoutStrategy.vtkConeLayoutStrategy_SetCompactness_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06007586 RID: 30086
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConeLayoutStrategy_SetCompression_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Determine if layout should be compressed, i.e. the
		/// layout puts children closer together, possibly allowing
		/// sub-trees to overlap.  This is useful if the tree is
		/// actually the spanning tree of a graph.  For "real" trees,
		/// non-compressed layout is best, and is the default.
		/// </summary>
		// Token: 0x06007587 RID: 30087 RVA: 0x000A9D4B File Offset: 0x000A7F4B
		public virtual void SetCompression(int _arg)
		{
			vtkConeLayoutStrategy.vtkConeLayoutStrategy_SetCompression_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06007588 RID: 30088
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkConeLayoutStrategy_SetSpacing_16(HandleRef pThis, float _arg);

		/// <summary>
		/// Set the spacing parameter that affects space between
		/// layers of the tree.  If compression is on, Spacing is the
		/// actual distance between layers.  If compression is off,
		/// actual distance also includes a factor of the compactness
		/// and maximum cone radius.
		/// </summary>
		// Token: 0x06007589 RID: 30089 RVA: 0x000A9D5B File Offset: 0x000A7F5B
		public virtual void SetSpacing(float _arg)
		{
			vtkConeLayoutStrategy.vtkConeLayoutStrategy_SetSpacing_16(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A20 RID: 2592
		public new const string MRFullTypeName = "Kitware.VTK.vtkConeLayoutStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A21 RID: 2593
		public new static readonly string MRClassNameKey = "class vtkConeLayoutStrategy";
	}
}
