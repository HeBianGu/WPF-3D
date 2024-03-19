using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDistributedGraphHelper
	/// </summary>
	/// <remarks>
	///    helper for the vtkGraph class
	/// that allows the graph to be distributed across multiple memory spaces.
	///
	///
	/// A distributed graph helper can be attached to an empty vtkGraph
	/// object to turn the vtkGraph into a distributed graph, whose
	/// vertices and edges are distributed across several different
	/// processors. vtkDistributedGraphHelper is an abstract class. Use a
	/// subclass of vtkDistributedGraphHelper, such as
	/// vtkPBGLDistributedGraphHelper, to build distributed graphs.
	///
	/// The distributed graph helper provides facilities used by vtkGraph
	/// to communicate with other processors that store other parts of the
	/// same distributed graph. The only user-level functionality provided
	/// by vtkDistributedGraphHelper involves this communication among
	/// processors and the ability to map between "distributed" vertex and
	/// edge IDs and their component parts (processor and local index). For
	/// example, the Synchronize() method provides a barrier that allows
	/// all processors to catch up to the same point in the code before any
	/// processor can leave that Synchronize() call. For example, one would
	/// call Synchronize() after adding many edges to a distributed graph,
	/// so that all processors can handle the addition of inter-processor
	/// edges and continue, after the Synchronize() call, with a consistent
	/// view of the distributed graph. For more information about
	/// manipulating (distributed) graphs, see the vtkGraph documentation.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGraph
	/// </seealso>
	// Token: 0x02000A43 RID: 2627
	public abstract class vtkDistributedGraphHelper : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B5DF RID: 112095 RVA: 0x00264747 File Offset: 0x00262947
		static vtkDistributedGraphHelper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDistributedGraphHelper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDistributedGraphHelper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B5E0 RID: 112096 RVA: 0x0026476F File Offset: 0x0026296F
		public vtkDistributedGraphHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B5E1 RID: 112097 RVA: 0x0026477D File Offset: 0x0026297D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B5E2 RID: 112098
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistributedGraphHelper_Clone_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Clones the distributed graph helper, returning another
		/// distributed graph helper of the same kind that can be used in
		/// another vtkGraph.
		/// </summary>
		// Token: 0x0601B5E3 RID: 112099 RVA: 0x00264788 File Offset: 0x00262988
		public virtual vtkDistributedGraphHelper Clone()
		{
			vtkDistributedGraphHelper vtkDistributedGraphHelper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistributedGraphHelper.vtkDistributedGraphHelper_Clone_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDistributedGraphHelper = (vtkDistributedGraphHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDistributedGraphHelper.Register(null);
				}
			}
			return vtkDistributedGraphHelper;
		}

		// Token: 0x0601B5E4 RID: 112100
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistributedGraphHelper_DISTRIBUTEDEDGEIDS_02(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Information Keys that distributed graphs can append to attribute arrays
		/// to flag them as containing distributed IDs.  These can be used to let
		/// routines that migrate vertices (either repartitioning or collecting graphs
		/// to single nodes) to also modify the ids contained in the attribute arrays
		/// to maintain consistency.
		/// </summary>
		// Token: 0x0601B5E5 RID: 112101 RVA: 0x002647F8 File Offset: 0x002629F8
		public static vtkInformationIntegerKey DISTRIBUTEDEDGEIDS()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistributedGraphHelper.vtkDistributedGraphHelper_DISTRIBUTEDEDGEIDS_02(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x0601B5E6 RID: 112102
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistributedGraphHelper_DISTRIBUTEDVERTEXIDS_03(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Information Keys that distributed graphs can append to attribute arrays
		/// to flag them as containing distributed IDs.  These can be used to let
		/// routines that migrate vertices (either repartitioning or collecting graphs
		/// to single nodes) to also modify the ids contained in the attribute arrays
		/// to maintain consistency.
		/// </summary>
		// Token: 0x0601B5E7 RID: 112103 RVA: 0x00264864 File Offset: 0x00262A64
		public static vtkInformationIntegerKey DISTRIBUTEDVERTEXIDS()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistributedGraphHelper.vtkDistributedGraphHelper_DISTRIBUTEDVERTEXIDS_03(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x0601B5E8 RID: 112104
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDistributedGraphHelper_GetEdgeIndex_04(HandleRef pThis, long e_id);

		/// <summary>
		/// Returns local index of edge with ID e_id, by masking off top ceil(log2 P)
		/// bits of e_id.
		/// </summary>
		// Token: 0x0601B5E9 RID: 112105 RVA: 0x002648D0 File Offset: 0x00262AD0
		public long GetEdgeIndex(long e_id)
		{
			return vtkDistributedGraphHelper.vtkDistributedGraphHelper_GetEdgeIndex_04(base.GetCppThis(), e_id);
		}

		// Token: 0x0601B5EA RID: 112106
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDistributedGraphHelper_GetEdgeOwner_05(HandleRef pThis, long e_id);

		/// <summary>
		/// Returns owner of edge with ID e_id, by extracting top ceil(log2 P) bits of e_id.
		/// </summary>
		// Token: 0x0601B5EB RID: 112107 RVA: 0x002648F0 File Offset: 0x00262AF0
		public long GetEdgeOwner(long e_id)
		{
			return vtkDistributedGraphHelper.vtkDistributedGraphHelper_GetEdgeOwner_05(base.GetCppThis(), e_id);
		}

		// Token: 0x0601B5EC RID: 112108
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDistributedGraphHelper_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B5ED RID: 112109 RVA: 0x00264910 File Offset: 0x00262B10
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDistributedGraphHelper.vtkDistributedGraphHelper_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0601B5EE RID: 112110
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDistributedGraphHelper_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B5EF RID: 112111 RVA: 0x00264930 File Offset: 0x00262B30
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDistributedGraphHelper.vtkDistributedGraphHelper_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0601B5F0 RID: 112112
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDistributedGraphHelper_GetVertexIndex_08(HandleRef pThis, long v);

		/// <summary>
		/// Returns local index of vertex v, by masking off top ceil(log2 P) bits of v.
		/// </summary>
		// Token: 0x0601B5F1 RID: 112113 RVA: 0x0026494C File Offset: 0x00262B4C
		public long GetVertexIndex(long v)
		{
			return vtkDistributedGraphHelper.vtkDistributedGraphHelper_GetVertexIndex_08(base.GetCppThis(), v);
		}

		// Token: 0x0601B5F2 RID: 112114
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDistributedGraphHelper_GetVertexOwner_09(HandleRef pThis, long v);

		/// <summary>
		/// Returns owner of vertex v, by extracting top ceil(log2 P) bits of v.
		/// </summary>
		// Token: 0x0601B5F3 RID: 112115 RVA: 0x0026496C File Offset: 0x00262B6C
		public long GetVertexOwner(long v)
		{
			return vtkDistributedGraphHelper.vtkDistributedGraphHelper_GetVertexOwner_09(base.GetCppThis(), v);
		}

		// Token: 0x0601B5F4 RID: 112116
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDistributedGraphHelper_GetVertexOwnerByPedigreeId_10(HandleRef pThis, HandleRef pedigreeId);

		/// <summary>
		/// Determine which processor owns the vertex with the given pedigree ID.
		/// </summary>
		// Token: 0x0601B5F5 RID: 112117 RVA: 0x0026498C File Offset: 0x00262B8C
		public long GetVertexOwnerByPedigreeId(vtkVariant pedigreeId)
		{
			return vtkDistributedGraphHelper.vtkDistributedGraphHelper_GetVertexOwnerByPedigreeId_10(base.GetCppThis(), (pedigreeId == null) ? default(HandleRef) : pedigreeId.GetCppThis());
		}

		// Token: 0x0601B5F6 RID: 112118
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistributedGraphHelper_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B5F7 RID: 112119 RVA: 0x002649C0 File Offset: 0x00262BC0
		public override int IsA(string type)
		{
			return vtkDistributedGraphHelper.vtkDistributedGraphHelper_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0601B5F8 RID: 112120
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistributedGraphHelper_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B5F9 RID: 112121 RVA: 0x002649E0 File Offset: 0x00262BE0
		public new static int IsTypeOf(string type)
		{
			return vtkDistributedGraphHelper.vtkDistributedGraphHelper_IsTypeOf_12(type);
		}

		// Token: 0x0601B5FA RID: 112122
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDistributedGraphHelper_MakeDistributedId_13(HandleRef pThis, int owner, long local);

		/// <summary>
		/// Builds a distributed ID consisting of the given owner and the local ID.
		/// </summary>
		// Token: 0x0601B5FB RID: 112123 RVA: 0x002649FC File Offset: 0x00262BFC
		public long MakeDistributedId(int owner, long local)
		{
			return vtkDistributedGraphHelper.vtkDistributedGraphHelper_MakeDistributedId_13(base.GetCppThis(), owner, local);
		}

		// Token: 0x0601B5FC RID: 112124
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistributedGraphHelper_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B5FD RID: 112125 RVA: 0x00264A20 File Offset: 0x00262C20
		public new vtkDistributedGraphHelper NewInstance()
		{
			vtkDistributedGraphHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistributedGraphHelper.vtkDistributedGraphHelper_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDistributedGraphHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B5FE RID: 112126
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistributedGraphHelper_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601B5FF RID: 112127 RVA: 0x00264A7C File Offset: 0x00262C7C
		public new static vtkDistributedGraphHelper SafeDownCast(vtkObjectBase o)
		{
			vtkDistributedGraphHelper vtkDistributedGraphHelper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistributedGraphHelper.vtkDistributedGraphHelper_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDistributedGraphHelper = (vtkDistributedGraphHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDistributedGraphHelper.Register(null);
				}
			}
			return vtkDistributedGraphHelper;
		}

		// Token: 0x0601B600 RID: 112128
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistributedGraphHelper_Synchronize_16(HandleRef pThis);

		/// <summary>
		/// Synchronizes all of the processors involved in this distributed
		/// graph, so that all processors have a consistent view of the
		/// distributed graph for the computation that follows. This routine
		/// should be invoked after adding new edges into the distributed
		/// graph, so that other processors will see those edges (or their
		/// corresponding back-edges).
		/// </summary>
		// Token: 0x0601B601 RID: 112129 RVA: 0x00264AFB File Offset: 0x00262CFB
		public virtual void Synchronize()
		{
			vtkDistributedGraphHelper.vtkDistributedGraphHelper_Synchronize_16(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D7A RID: 7546
		public new const string MRFullTypeName = "Kitware.VTK.vtkDistributedGraphHelper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D7B RID: 7547
		public new static readonly string MRClassNameKey = "class vtkDistributedGraphHelper";
	}
}
