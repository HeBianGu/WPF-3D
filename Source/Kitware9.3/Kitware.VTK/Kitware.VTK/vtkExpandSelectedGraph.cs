using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExpandSelectedGraph
	/// </summary>
	/// <remarks>
	///    expands a selection set of a vtkGraph
	///
	///
	/// The first input is a vtkSelection containing the selected vertices.
	/// The second input is a vtkGraph.
	/// This filter 'grows' the selection set in one of the following ways
	/// 1) SetBFSDistance controls how many 'hops' the selection is grown
	///    from each seed point in the selection set (defaults to 1)
	/// 2) IncludeShortestPaths controls whether this filter tries to
	///    'connect' the vertices in the selection set by computing the
	///    shortest path between the vertices (if such a path exists)
	/// Note: IncludeShortestPaths is currently non-functional
	/// </remarks>
	// Token: 0x0200067B RID: 1659
	public class vtkExpandSelectedGraph : vtkSelectionAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011DB3 RID: 73139 RVA: 0x0018FC49 File Offset: 0x0018DE49
		static vtkExpandSelectedGraph()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExpandSelectedGraph.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExpandSelectedGraph"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011DB4 RID: 73140 RVA: 0x0018FC71 File Offset: 0x0018DE71
		public vtkExpandSelectedGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011DB5 RID: 73141
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExpandSelectedGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011DB6 RID: 73142 RVA: 0x0018FC80 File Offset: 0x0018DE80
		public new static vtkExpandSelectedGraph New()
		{
			vtkExpandSelectedGraph result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExpandSelectedGraph.vtkExpandSelectedGraph_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExpandSelectedGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011DB7 RID: 73143 RVA: 0x0018FCD4 File Offset: 0x0018DED4
		public vtkExpandSelectedGraph() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExpandSelectedGraph.vtkExpandSelectedGraph_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011DB8 RID: 73144 RVA: 0x0018FD18 File Offset: 0x0018DF18
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011DB9 RID: 73145
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExpandSelectedGraph_FillInputPortInformation_01(HandleRef pThis, int port, HandleRef info);

		/// <summary>
		/// Specify the first vtkSelection input and the second vtkGraph input.
		/// </summary>
		// Token: 0x06011DBA RID: 73146 RVA: 0x0018FD24 File Offset: 0x0018DF24
		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkExpandSelectedGraph.vtkExpandSelectedGraph_FillInputPortInformation_01(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x06011DBB RID: 73147
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExpandSelectedGraph_GetBFSDistance_02(HandleRef pThis);

		/// <summary>
		/// Set/Get BFSDistance which controls how many 'hops' the selection
		/// is grown from each seed point in the selection set (defaults to 1)
		/// </summary>
		// Token: 0x06011DBC RID: 73148 RVA: 0x0018FD5C File Offset: 0x0018DF5C
		public virtual int GetBFSDistance()
		{
			return vtkExpandSelectedGraph.vtkExpandSelectedGraph_GetBFSDistance_02(base.GetCppThis());
		}

		// Token: 0x06011DBD RID: 73149
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExpandSelectedGraph_GetDomain_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the vertex domain to use in the expansion.
		/// </summary>
		// Token: 0x06011DBE RID: 73150 RVA: 0x0018FD7C File Offset: 0x0018DF7C
		public virtual string GetDomain()
		{
			string s = Marshal.PtrToStringAnsi(vtkExpandSelectedGraph.vtkExpandSelectedGraph_GetDomain_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06011DBF RID: 73151
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExpandSelectedGraph_GetIncludeShortestPaths_04(HandleRef pThis);

		/// <summary>
		/// Set/Get IncludeShortestPaths controls whether this filter tries to
		/// 'connect' the vertices in the selection set by computing the
		/// shortest path between the vertices (if such a path exists)
		/// Note: IncludeShortestPaths is currently non-functional
		/// </summary>
		// Token: 0x06011DC0 RID: 73152 RVA: 0x0018FDB8 File Offset: 0x0018DFB8
		public virtual bool GetIncludeShortestPaths()
		{
			return vtkExpandSelectedGraph.vtkExpandSelectedGraph_GetIncludeShortestPaths_04(base.GetCppThis()) != 0;
		}

		// Token: 0x06011DC1 RID: 73153
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExpandSelectedGraph_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011DC2 RID: 73154 RVA: 0x0018FDE0 File Offset: 0x0018DFE0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExpandSelectedGraph.vtkExpandSelectedGraph_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06011DC3 RID: 73155
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExpandSelectedGraph_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011DC4 RID: 73156 RVA: 0x0018FE00 File Offset: 0x0018E000
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExpandSelectedGraph.vtkExpandSelectedGraph_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06011DC5 RID: 73157
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExpandSelectedGraph_GetUseDomain_07(HandleRef pThis);

		/// <summary>
		/// Whether or not to use the domain when deciding to add a vertex to the
		/// expansion. Defaults to false.
		/// </summary>
		// Token: 0x06011DC6 RID: 73158 RVA: 0x0018FE1C File Offset: 0x0018E01C
		public virtual bool GetUseDomain()
		{
			return vtkExpandSelectedGraph.vtkExpandSelectedGraph_GetUseDomain_07(base.GetCppThis()) != 0;
		}

		// Token: 0x06011DC7 RID: 73159
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExpandSelectedGraph_IncludeShortestPathsOff_08(HandleRef pThis);

		/// <summary>
		/// Set/Get IncludeShortestPaths controls whether this filter tries to
		/// 'connect' the vertices in the selection set by computing the
		/// shortest path between the vertices (if such a path exists)
		/// Note: IncludeShortestPaths is currently non-functional
		/// </summary>
		// Token: 0x06011DC8 RID: 73160 RVA: 0x0018FE42 File Offset: 0x0018E042
		public virtual void IncludeShortestPathsOff()
		{
			vtkExpandSelectedGraph.vtkExpandSelectedGraph_IncludeShortestPathsOff_08(base.GetCppThis());
		}

		// Token: 0x06011DC9 RID: 73161
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExpandSelectedGraph_IncludeShortestPathsOn_09(HandleRef pThis);

		/// <summary>
		/// Set/Get IncludeShortestPaths controls whether this filter tries to
		/// 'connect' the vertices in the selection set by computing the
		/// shortest path between the vertices (if such a path exists)
		/// Note: IncludeShortestPaths is currently non-functional
		/// </summary>
		// Token: 0x06011DCA RID: 73162 RVA: 0x0018FE51 File Offset: 0x0018E051
		public virtual void IncludeShortestPathsOn()
		{
			vtkExpandSelectedGraph.vtkExpandSelectedGraph_IncludeShortestPathsOn_09(base.GetCppThis());
		}

		// Token: 0x06011DCB RID: 73163
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExpandSelectedGraph_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011DCC RID: 73164 RVA: 0x0018FE60 File Offset: 0x0018E060
		public override int IsA(string type)
		{
			return vtkExpandSelectedGraph.vtkExpandSelectedGraph_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06011DCD RID: 73165
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExpandSelectedGraph_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011DCE RID: 73166 RVA: 0x0018FE80 File Offset: 0x0018E080
		public new static int IsTypeOf(string type)
		{
			return vtkExpandSelectedGraph.vtkExpandSelectedGraph_IsTypeOf_11(type);
		}

		// Token: 0x06011DCF RID: 73167
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExpandSelectedGraph_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011DD0 RID: 73168 RVA: 0x0018FE9C File Offset: 0x0018E09C
		public new vtkExpandSelectedGraph NewInstance()
		{
			vtkExpandSelectedGraph result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExpandSelectedGraph.vtkExpandSelectedGraph_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExpandSelectedGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011DD1 RID: 73169
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExpandSelectedGraph_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011DD2 RID: 73170 RVA: 0x0018FEF8 File Offset: 0x0018E0F8
		public new static vtkExpandSelectedGraph SafeDownCast(vtkObjectBase o)
		{
			vtkExpandSelectedGraph vtkExpandSelectedGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExpandSelectedGraph.vtkExpandSelectedGraph_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExpandSelectedGraph = (vtkExpandSelectedGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExpandSelectedGraph.Register(null);
				}
			}
			return vtkExpandSelectedGraph;
		}

		// Token: 0x06011DD3 RID: 73171
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExpandSelectedGraph_SetBFSDistance_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get BFSDistance which controls how many 'hops' the selection
		/// is grown from each seed point in the selection set (defaults to 1)
		/// </summary>
		// Token: 0x06011DD4 RID: 73172 RVA: 0x0018FF77 File Offset: 0x0018E177
		public virtual void SetBFSDistance(int _arg)
		{
			vtkExpandSelectedGraph.vtkExpandSelectedGraph_SetBFSDistance_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06011DD5 RID: 73173
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExpandSelectedGraph_SetDomain_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the vertex domain to use in the expansion.
		/// </summary>
		// Token: 0x06011DD6 RID: 73174 RVA: 0x0018FF87 File Offset: 0x0018E187
		public virtual void SetDomain(string _arg)
		{
			vtkExpandSelectedGraph.vtkExpandSelectedGraph_SetDomain_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06011DD7 RID: 73175
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExpandSelectedGraph_SetGraphConnection_17(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// A convenience method for setting the second input (i.e. the graph).
		/// </summary>
		// Token: 0x06011DD8 RID: 73176 RVA: 0x0018FF98 File Offset: 0x0018E198
		public void SetGraphConnection(vtkAlgorithmOutput arg0)
		{
			vtkExpandSelectedGraph.vtkExpandSelectedGraph_SetGraphConnection_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06011DD9 RID: 73177
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExpandSelectedGraph_SetIncludeShortestPaths_18(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get IncludeShortestPaths controls whether this filter tries to
		/// 'connect' the vertices in the selection set by computing the
		/// shortest path between the vertices (if such a path exists)
		/// Note: IncludeShortestPaths is currently non-functional
		/// </summary>
		// Token: 0x06011DDA RID: 73178 RVA: 0x0018FFC7 File Offset: 0x0018E1C7
		public virtual void SetIncludeShortestPaths(bool _arg)
		{
			vtkExpandSelectedGraph.vtkExpandSelectedGraph_SetIncludeShortestPaths_18(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011DDB RID: 73179
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExpandSelectedGraph_SetUseDomain_19(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether or not to use the domain when deciding to add a vertex to the
		/// expansion. Defaults to false.
		/// </summary>
		// Token: 0x06011DDC RID: 73180 RVA: 0x0018FFDF File Offset: 0x0018E1DF
		public virtual void SetUseDomain(bool _arg)
		{
			vtkExpandSelectedGraph.vtkExpandSelectedGraph_SetUseDomain_19(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011DDD RID: 73181
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExpandSelectedGraph_UseDomainOff_20(HandleRef pThis);

		/// <summary>
		/// Whether or not to use the domain when deciding to add a vertex to the
		/// expansion. Defaults to false.
		/// </summary>
		// Token: 0x06011DDE RID: 73182 RVA: 0x0018FFF7 File Offset: 0x0018E1F7
		public virtual void UseDomainOff()
		{
			vtkExpandSelectedGraph.vtkExpandSelectedGraph_UseDomainOff_20(base.GetCppThis());
		}

		// Token: 0x06011DDF RID: 73183
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExpandSelectedGraph_UseDomainOn_21(HandleRef pThis);

		/// <summary>
		/// Whether or not to use the domain when deciding to add a vertex to the
		/// expansion. Defaults to false.
		/// </summary>
		// Token: 0x06011DE0 RID: 73184 RVA: 0x00190006 File Offset: 0x0018E206
		public virtual void UseDomainOn()
		{
			vtkExpandSelectedGraph.vtkExpandSelectedGraph_UseDomainOn_21(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400149B RID: 5275
		public new const string MRFullTypeName = "Kitware.VTK.vtkExpandSelectedGraph";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400149C RID: 5276
		public new static readonly string MRClassNameKey = "class vtkExpandSelectedGraph";
	}
}
