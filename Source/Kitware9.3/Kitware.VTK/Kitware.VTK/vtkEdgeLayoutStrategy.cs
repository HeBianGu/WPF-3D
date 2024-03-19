using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkEdgeLayoutStrategy
	/// </summary>
	/// <remarks>
	///    abstract superclass for all edge layout strategies
	///
	///
	/// All edge layouts should subclass from this class.  vtkEdgeLayoutStrategy
	/// works as a plug-in to the vtkEdgeLayout algorithm.
	/// </remarks>
	// Token: 0x02000278 RID: 632
	public abstract class vtkEdgeLayoutStrategy : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007311 RID: 29457 RVA: 0x000A64D8 File Offset: 0x000A46D8
		static vtkEdgeLayoutStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEdgeLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEdgeLayoutStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007312 RID: 29458 RVA: 0x000A6500 File Offset: 0x000A4700
		public vtkEdgeLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007313 RID: 29459 RVA: 0x000A650E File Offset: 0x000A470E
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007314 RID: 29460
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEdgeLayoutStrategy_GetEdgeWeightArrayName_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the field to use for the edge weights.
		/// </summary>
		// Token: 0x06007315 RID: 29461 RVA: 0x000A651C File Offset: 0x000A471C
		public virtual string GetEdgeWeightArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkEdgeLayoutStrategy.vtkEdgeLayoutStrategy_GetEdgeWeightArrayName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007316 RID: 29462
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEdgeLayoutStrategy_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007317 RID: 29463 RVA: 0x000A6558 File Offset: 0x000A4758
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEdgeLayoutStrategy.vtkEdgeLayoutStrategy_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06007318 RID: 29464
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEdgeLayoutStrategy_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007319 RID: 29465 RVA: 0x000A6578 File Offset: 0x000A4778
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEdgeLayoutStrategy.vtkEdgeLayoutStrategy_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600731A RID: 29466
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEdgeLayoutStrategy_Initialize_04(HandleRef pThis);

		/// <summary>
		/// This method allows the layout strategy to
		/// do initialization of data structures
		/// or whatever else it might want to do.
		/// </summary>
		// Token: 0x0600731B RID: 29467 RVA: 0x000A6592 File Offset: 0x000A4792
		public virtual void Initialize()
		{
			vtkEdgeLayoutStrategy.vtkEdgeLayoutStrategy_Initialize_04(base.GetCppThis());
		}

		// Token: 0x0600731C RID: 29468
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEdgeLayoutStrategy_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600731D RID: 29469 RVA: 0x000A65A4 File Offset: 0x000A47A4
		public override int IsA(string type)
		{
			return vtkEdgeLayoutStrategy.vtkEdgeLayoutStrategy_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600731E RID: 29470
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEdgeLayoutStrategy_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600731F RID: 29471 RVA: 0x000A65C4 File Offset: 0x000A47C4
		public new static int IsTypeOf(string type)
		{
			return vtkEdgeLayoutStrategy.vtkEdgeLayoutStrategy_IsTypeOf_06(type);
		}

		// Token: 0x06007320 RID: 29472
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEdgeLayoutStrategy_Layout_07(HandleRef pThis);

		/// <summary>
		/// This is the layout method where the graph that was
		/// set in SetGraph() is laid out.
		/// </summary>
		// Token: 0x06007321 RID: 29473 RVA: 0x000A65DE File Offset: 0x000A47DE
		public virtual void Layout()
		{
			vtkEdgeLayoutStrategy.vtkEdgeLayoutStrategy_Layout_07(base.GetCppThis());
		}

		// Token: 0x06007322 RID: 29474
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEdgeLayoutStrategy_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007323 RID: 29475 RVA: 0x000A65F0 File Offset: 0x000A47F0
		public new vtkEdgeLayoutStrategy NewInstance()
		{
			vtkEdgeLayoutStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEdgeLayoutStrategy.vtkEdgeLayoutStrategy_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEdgeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007324 RID: 29476
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEdgeLayoutStrategy_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007325 RID: 29477 RVA: 0x000A664C File Offset: 0x000A484C
		public new static vtkEdgeLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkEdgeLayoutStrategy vtkEdgeLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEdgeLayoutStrategy.vtkEdgeLayoutStrategy_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEdgeLayoutStrategy = (vtkEdgeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEdgeLayoutStrategy.Register(null);
				}
			}
			return vtkEdgeLayoutStrategy;
		}

		// Token: 0x06007326 RID: 29478
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEdgeLayoutStrategy_SetEdgeWeightArrayName_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the field to use for the edge weights.
		/// </summary>
		// Token: 0x06007327 RID: 29479 RVA: 0x000A66CB File Offset: 0x000A48CB
		public virtual void SetEdgeWeightArrayName(string _arg)
		{
			vtkEdgeLayoutStrategy.vtkEdgeLayoutStrategy_SetEdgeWeightArrayName_10(base.GetCppThis(), _arg);
		}

		// Token: 0x06007328 RID: 29480
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEdgeLayoutStrategy_SetGraph_11(HandleRef pThis, HandleRef graph);

		/// <summary>
		/// Setting the graph for the layout strategy
		/// </summary>
		// Token: 0x06007329 RID: 29481 RVA: 0x000A66DC File Offset: 0x000A48DC
		public virtual void SetGraph(vtkGraph graph)
		{
			vtkEdgeLayoutStrategy.vtkEdgeLayoutStrategy_SetGraph_11(base.GetCppThis(), (graph == null) ? default(HandleRef) : graph.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009FE RID: 2558
		public new const string MRFullTypeName = "Kitware.VTK.vtkEdgeLayoutStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009FF RID: 2559
		public new static readonly string MRClassNameKey = "class vtkEdgeLayoutStrategy";
	}
}
