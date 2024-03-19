using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGraphLayoutStrategy
	/// </summary>
	/// <remarks>
	///    abstract superclass for all graph layout strategies
	///
	///
	/// All graph layouts should subclass from this class.  vtkGraphLayoutStrategy
	/// works as a plug-in to the vtkGraphLayout algorithm.  The Layout()
	/// function should perform some reasonable "chunk" of the layout.
	/// This allows the user to be able to see the progress of the layout.
	/// Use IsLayoutComplete() to tell the user when there is no more layout
	/// to perform.
	///
	/// @par Thanks:
	/// Thanks to Brian Wylie from Sandia National Laboratories for adding incremental
	/// layout capabilities.
	/// </remarks>
	// Token: 0x0200027D RID: 637
	public abstract class vtkGraphLayoutStrategy : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060073A9 RID: 29609 RVA: 0x000A739F File Offset: 0x000A559F
		static vtkGraphLayoutStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphLayoutStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060073AA RID: 29610 RVA: 0x000A73C7 File Offset: 0x000A55C7
		public vtkGraphLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060073AB RID: 29611 RVA: 0x000A73D5 File Offset: 0x000A55D5
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060073AC RID: 29612
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphLayoutStrategy_GetEdgeWeightField_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the field to use for the edge weights.
		/// </summary>
		// Token: 0x060073AD RID: 29613 RVA: 0x000A73E0 File Offset: 0x000A55E0
		public virtual string GetEdgeWeightField()
		{
			string s = Marshal.PtrToStringAnsi(vtkGraphLayoutStrategy.vtkGraphLayoutStrategy_GetEdgeWeightField_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060073AE RID: 29614
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphLayoutStrategy_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060073AF RID: 29615 RVA: 0x000A741C File Offset: 0x000A561C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGraphLayoutStrategy.vtkGraphLayoutStrategy_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060073B0 RID: 29616
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphLayoutStrategy_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060073B1 RID: 29617 RVA: 0x000A743C File Offset: 0x000A563C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGraphLayoutStrategy.vtkGraphLayoutStrategy_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060073B2 RID: 29618
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGraphLayoutStrategy_GetWeightEdges_04(HandleRef pThis);

		/// <summary>
		/// Whether to use edge weights in the layout or not.
		/// </summary>
		// Token: 0x060073B3 RID: 29619 RVA: 0x000A7458 File Offset: 0x000A5658
		public virtual bool GetWeightEdges()
		{
			return vtkGraphLayoutStrategy.vtkGraphLayoutStrategy_GetWeightEdges_04(base.GetCppThis()) != 0;
		}

		// Token: 0x060073B4 RID: 29620
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutStrategy_Initialize_05(HandleRef pThis);

		/// <summary>
		/// This method allows the layout strategy to
		/// do initialization of data structures
		/// or whatever else it might want to do.
		/// </summary>
		// Token: 0x060073B5 RID: 29621 RVA: 0x000A747E File Offset: 0x000A567E
		public virtual void Initialize()
		{
			vtkGraphLayoutStrategy.vtkGraphLayoutStrategy_Initialize_05(base.GetCppThis());
		}

		// Token: 0x060073B6 RID: 29622
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphLayoutStrategy_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060073B7 RID: 29623 RVA: 0x000A7490 File Offset: 0x000A5690
		public override int IsA(string type)
		{
			return vtkGraphLayoutStrategy.vtkGraphLayoutStrategy_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060073B8 RID: 29624
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphLayoutStrategy_IsLayoutComplete_07(HandleRef pThis);

		/// <summary>
		/// If your concrete class is iterative than
		/// you should overload IsLayoutComplete()
		/// otherwise it simply returns 1 by default;
		/// </summary>
		// Token: 0x060073B9 RID: 29625 RVA: 0x000A74B0 File Offset: 0x000A56B0
		public virtual int IsLayoutComplete()
		{
			return vtkGraphLayoutStrategy.vtkGraphLayoutStrategy_IsLayoutComplete_07(base.GetCppThis());
		}

		// Token: 0x060073BA RID: 29626
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphLayoutStrategy_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060073BB RID: 29627 RVA: 0x000A74D0 File Offset: 0x000A56D0
		public new static int IsTypeOf(string type)
		{
			return vtkGraphLayoutStrategy.vtkGraphLayoutStrategy_IsTypeOf_08(type);
		}

		// Token: 0x060073BC RID: 29628
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutStrategy_Layout_09(HandleRef pThis);

		/// <summary>
		/// This is the layout method where the graph that was
		/// set in SetGraph() is laid out. The method can either
		/// entirely layout the graph or iteratively lay out the
		/// graph. If you have an iterative layout please implement
		/// the IsLayoutComplete() method.
		/// </summary>
		// Token: 0x060073BD RID: 29629 RVA: 0x000A74EA File Offset: 0x000A56EA
		public virtual void Layout()
		{
			vtkGraphLayoutStrategy.vtkGraphLayoutStrategy_Layout_09(base.GetCppThis());
		}

		// Token: 0x060073BE RID: 29630
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphLayoutStrategy_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060073BF RID: 29631 RVA: 0x000A74FC File Offset: 0x000A56FC
		public new vtkGraphLayoutStrategy NewInstance()
		{
			vtkGraphLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphLayoutStrategy.vtkGraphLayoutStrategy_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060073C0 RID: 29632
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphLayoutStrategy_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060073C1 RID: 29633 RVA: 0x000A7558 File Offset: 0x000A5758
		public new static vtkGraphLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkGraphLayoutStrategy vtkGraphLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphLayoutStrategy.vtkGraphLayoutStrategy_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphLayoutStrategy = (vtkGraphLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphLayoutStrategy.Register(null);
				}
			}
			return vtkGraphLayoutStrategy;
		}

		// Token: 0x060073C2 RID: 29634
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutStrategy_SetEdgeWeightField_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string field);

		/// <summary>
		/// Set/Get the field to use for the edge weights.
		/// </summary>
		// Token: 0x060073C3 RID: 29635 RVA: 0x000A75D7 File Offset: 0x000A57D7
		public virtual void SetEdgeWeightField(string field)
		{
			vtkGraphLayoutStrategy.vtkGraphLayoutStrategy_SetEdgeWeightField_12(base.GetCppThis(), field);
		}

		// Token: 0x060073C4 RID: 29636
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutStrategy_SetGraph_13(HandleRef pThis, HandleRef graph);

		/// <summary>
		/// Setting the graph for the layout strategy
		/// </summary>
		// Token: 0x060073C5 RID: 29637 RVA: 0x000A75E8 File Offset: 0x000A57E8
		public virtual void SetGraph(vtkGraph graph)
		{
			vtkGraphLayoutStrategy.vtkGraphLayoutStrategy_SetGraph_13(base.GetCppThis(), (graph == null) ? default(HandleRef) : graph.GetCppThis());
		}

		// Token: 0x060073C6 RID: 29638
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphLayoutStrategy_SetWeightEdges_14(HandleRef pThis, byte state);

		/// <summary>
		/// Whether to use edge weights in the layout or not.
		/// </summary>
		// Token: 0x060073C7 RID: 29639 RVA: 0x000A7617 File Offset: 0x000A5817
		public virtual void SetWeightEdges(bool state)
		{
			vtkGraphLayoutStrategy.vtkGraphLayoutStrategy_SetWeightEdges_14(base.GetCppThis(), state ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A08 RID: 2568
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphLayoutStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A09 RID: 2569
		public new static readonly string MRClassNameKey = "class vtkGraphLayoutStrategy";
	}
}
