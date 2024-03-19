using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMergeGraphs
	/// </summary>
	/// <remarks>
	///    combines two graphs
	///
	///
	/// vtkMergeGraphs combines information from two graphs into one.
	/// Both graphs must have pedigree ids assigned to the vertices.
	/// The output will contain the vertices/edges in the first graph, in
	/// addition to:
	///
	///  - vertices in the second graph whose pedigree id does not
	///    match a vertex in the first input
	///
	///  - edges in the second graph
	///
	/// The output will contain the same attribute structure as the input;
	/// fields associated only with the second input graph will not be passed
	/// to the output. When possible, the vertex/edge data for new vertices and
	/// edges will be populated with matching attributes on the second graph.
	/// To be considered a matching attribute, the array must have the same name,
	/// type, and number of components.
	///
	/// @warning
	/// This filter is not "domain-aware". Pedigree ids are assumed to be globally
	/// unique, regardless of their domain.
	/// </remarks>
	// Token: 0x02000684 RID: 1668
	public class vtkMergeGraphs : vtkGraphAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011EB5 RID: 73397 RVA: 0x00191483 File Offset: 0x0018F683
		static vtkMergeGraphs()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMergeGraphs.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMergeGraphs"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011EB6 RID: 73398 RVA: 0x001914AB File Offset: 0x0018F6AB
		public vtkMergeGraphs(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011EB7 RID: 73399
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeGraphs_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011EB8 RID: 73400 RVA: 0x001914BC File Offset: 0x0018F6BC
		public new static vtkMergeGraphs New()
		{
			vtkMergeGraphs result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeGraphs.vtkMergeGraphs_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeGraphs)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011EB9 RID: 73401 RVA: 0x00191510 File Offset: 0x0018F710
		public vtkMergeGraphs() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMergeGraphs.vtkMergeGraphs_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011EBA RID: 73402 RVA: 0x00191554 File Offset: 0x0018F754
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011EBB RID: 73403
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergeGraphs_ExtendGraph_01(HandleRef pThis, HandleRef g1, HandleRef g2);

		/// <summary>
		/// This is the core functionality of the algorithm. Adds edges
		/// and vertices from g2 into g1.
		/// </summary>
		// Token: 0x06011EBC RID: 73404 RVA: 0x00191560 File Offset: 0x0018F760
		public int ExtendGraph(vtkMutableGraphHelper g1, vtkGraph g2)
		{
			return vtkMergeGraphs.vtkMergeGraphs_ExtendGraph_01(base.GetCppThis(), (g1 == null) ? default(HandleRef) : g1.GetCppThis(), (g2 == null) ? default(HandleRef) : g2.GetCppThis());
		}

		// Token: 0x06011EBD RID: 73405
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMergeGraphs_GetEdgeWindow_02(HandleRef pThis);

		/// <summary>
		/// The time window amount. Edges with values lower
		/// than the maximum value minus this window will be
		/// removed from the graph. The default edge window is
		/// 10000.
		/// </summary>
		// Token: 0x06011EBE RID: 73406 RVA: 0x001915AC File Offset: 0x0018F7AC
		public virtual double GetEdgeWindow()
		{
			return vtkMergeGraphs.vtkMergeGraphs_GetEdgeWindow_02(base.GetCppThis());
		}

		// Token: 0x06011EBF RID: 73407
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeGraphs_GetEdgeWindowArrayName_03(HandleRef pThis);

		/// <summary>
		/// The edge window array. The default array name is "time".
		/// </summary>
		// Token: 0x06011EC0 RID: 73408 RVA: 0x001915CC File Offset: 0x0018F7CC
		public virtual string GetEdgeWindowArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMergeGraphs.vtkMergeGraphs_GetEdgeWindowArrayName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06011EC1 RID: 73409
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMergeGraphs_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011EC2 RID: 73410 RVA: 0x00191608 File Offset: 0x0018F808
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMergeGraphs.vtkMergeGraphs_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06011EC3 RID: 73411
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMergeGraphs_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011EC4 RID: 73412 RVA: 0x00191628 File Offset: 0x0018F828
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMergeGraphs.vtkMergeGraphs_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06011EC5 RID: 73413
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMergeGraphs_GetUseEdgeWindow_06(HandleRef pThis);

		/// <summary>
		/// Whether to use an edge window array. The default is to
		/// not use a window array.
		/// </summary>
		// Token: 0x06011EC6 RID: 73414 RVA: 0x00191644 File Offset: 0x0018F844
		public virtual bool GetUseEdgeWindow()
		{
			return vtkMergeGraphs.vtkMergeGraphs_GetUseEdgeWindow_06(base.GetCppThis()) != 0;
		}

		// Token: 0x06011EC7 RID: 73415
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergeGraphs_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011EC8 RID: 73416 RVA: 0x0019166C File Offset: 0x0018F86C
		public override int IsA(string type)
		{
			return vtkMergeGraphs.vtkMergeGraphs_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06011EC9 RID: 73417
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergeGraphs_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011ECA RID: 73418 RVA: 0x0019168C File Offset: 0x0018F88C
		public new static int IsTypeOf(string type)
		{
			return vtkMergeGraphs.vtkMergeGraphs_IsTypeOf_08(type);
		}

		// Token: 0x06011ECB RID: 73419
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeGraphs_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011ECC RID: 73420 RVA: 0x001916A8 File Offset: 0x0018F8A8
		public new vtkMergeGraphs NewInstance()
		{
			vtkMergeGraphs result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeGraphs.vtkMergeGraphs_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeGraphs)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011ECD RID: 73421
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeGraphs_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011ECE RID: 73422 RVA: 0x00191704 File Offset: 0x0018F904
		public new static vtkMergeGraphs SafeDownCast(vtkObjectBase o)
		{
			vtkMergeGraphs vtkMergeGraphs = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeGraphs.vtkMergeGraphs_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMergeGraphs = (vtkMergeGraphs)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMergeGraphs.Register(null);
				}
			}
			return vtkMergeGraphs;
		}

		// Token: 0x06011ECF RID: 73423
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeGraphs_SetEdgeWindow_12(HandleRef pThis, double _arg);

		/// <summary>
		/// The time window amount. Edges with values lower
		/// than the maximum value minus this window will be
		/// removed from the graph. The default edge window is
		/// 10000.
		/// </summary>
		// Token: 0x06011ED0 RID: 73424 RVA: 0x00191783 File Offset: 0x0018F983
		public virtual void SetEdgeWindow(double _arg)
		{
			vtkMergeGraphs.vtkMergeGraphs_SetEdgeWindow_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06011ED1 RID: 73425
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeGraphs_SetEdgeWindowArrayName_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The edge window array. The default array name is "time".
		/// </summary>
		// Token: 0x06011ED2 RID: 73426 RVA: 0x00191793 File Offset: 0x0018F993
		public virtual void SetEdgeWindowArrayName(string _arg)
		{
			vtkMergeGraphs.vtkMergeGraphs_SetEdgeWindowArrayName_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06011ED3 RID: 73427
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeGraphs_SetUseEdgeWindow_14(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether to use an edge window array. The default is to
		/// not use a window array.
		/// </summary>
		// Token: 0x06011ED4 RID: 73428 RVA: 0x001917A3 File Offset: 0x0018F9A3
		public virtual void SetUseEdgeWindow(bool _arg)
		{
			vtkMergeGraphs.vtkMergeGraphs_SetUseEdgeWindow_14(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011ED5 RID: 73429
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeGraphs_UseEdgeWindowOff_15(HandleRef pThis);

		/// <summary>
		/// Whether to use an edge window array. The default is to
		/// not use a window array.
		/// </summary>
		// Token: 0x06011ED6 RID: 73430 RVA: 0x001917BB File Offset: 0x0018F9BB
		public virtual void UseEdgeWindowOff()
		{
			vtkMergeGraphs.vtkMergeGraphs_UseEdgeWindowOff_15(base.GetCppThis());
		}

		// Token: 0x06011ED7 RID: 73431
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMergeGraphs_UseEdgeWindowOn_16(HandleRef pThis);

		/// <summary>
		/// Whether to use an edge window array. The default is to
		/// not use a window array.
		/// </summary>
		// Token: 0x06011ED8 RID: 73432 RVA: 0x001917CA File Offset: 0x0018F9CA
		public virtual void UseEdgeWindowOn()
		{
			vtkMergeGraphs.vtkMergeGraphs_UseEdgeWindowOn_16(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014B1 RID: 5297
		public new const string MRFullTypeName = "Kitware.VTK.vtkMergeGraphs";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014B2 RID: 5298
		public new static readonly string MRClassNameKey = "class vtkMergeGraphs";
	}
}
