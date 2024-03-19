using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkEdgeTable
	/// </summary>
	/// <remarks>
	///    keep track of edges (edge is pair of integer id's)
	///
	/// vtkEdgeTable is a general object for keeping track of lists of edges. An
	/// edge is defined by the pair of point id's (p1,p2). Methods are available
	/// to insert edges, check if edges exist, and traverse the list of edges.
	/// Also, it's possible to associate attribute information with each edge.
	/// The attribute information may take the form of vtkIdType id's, void*
	/// pointers, or points. To store attributes, make sure that
	/// InitEdgeInsertion() is invoked with the storeAttributes flag set properly.
	/// If points are inserted, use the methods InitPointInsertion() and
	/// InsertUniquePoint().
	/// </remarks>
	// Token: 0x02000A45 RID: 2629
	public class vtkEdgeTable : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B61C RID: 112156 RVA: 0x00264E6F File Offset: 0x0026306F
		static vtkEdgeTable()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEdgeTable.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEdgeTable"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B61D RID: 112157 RVA: 0x00264E97 File Offset: 0x00263097
		public vtkEdgeTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B61E RID: 112158
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEdgeTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object assuming that 1000 edges are to be inserted.
		/// </summary>
		// Token: 0x0601B61F RID: 112159 RVA: 0x00264EA8 File Offset: 0x002630A8
		public new static vtkEdgeTable New()
		{
			vtkEdgeTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEdgeTable.vtkEdgeTable_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEdgeTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate object assuming that 1000 edges are to be inserted.
		/// </summary>
		// Token: 0x0601B620 RID: 112160 RVA: 0x00264EFC File Offset: 0x002630FC
		public vtkEdgeTable() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkEdgeTable.vtkEdgeTable_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B621 RID: 112161 RVA: 0x00264F40 File Offset: 0x00263140
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B622 RID: 112162
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEdgeTable_GetNextEdge_01(HandleRef pThis, ref long p1, ref long p2);

		/// <summary>
		/// Traverse list of edges in table. Return the edge as (p1,p2), where p1
		/// and p2 are point id's. Method return value is &lt;0 if list is exhausted;
		/// non-zero otherwise. The value of p1 is guaranteed to be &lt;= p2.
		/// </summary>
		// Token: 0x0601B623 RID: 112163 RVA: 0x00264F4C File Offset: 0x0026314C
		public long GetNextEdge(ref long p1, ref long p2)
		{
			return vtkEdgeTable.vtkEdgeTable_GetNextEdge_01(base.GetCppThis(), ref p1, ref p2);
		}

		// Token: 0x0601B624 RID: 112164
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEdgeTable_GetNumberOfEdges_02(HandleRef pThis);

		/// <summary>
		/// Return the number of edges that have been inserted thus far.
		/// </summary>
		// Token: 0x0601B625 RID: 112165 RVA: 0x00264F70 File Offset: 0x00263170
		public virtual long GetNumberOfEdges()
		{
			return vtkEdgeTable.vtkEdgeTable_GetNumberOfEdges_02(base.GetCppThis());
		}

		// Token: 0x0601B626 RID: 112166
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEdgeTable_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate object assuming that 1000 edges are to be inserted.
		/// </summary>
		// Token: 0x0601B627 RID: 112167 RVA: 0x00264F90 File Offset: 0x00263190
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEdgeTable.vtkEdgeTable_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601B628 RID: 112168
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEdgeTable_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate object assuming that 1000 edges are to be inserted.
		/// </summary>
		// Token: 0x0601B629 RID: 112169 RVA: 0x00264FB0 File Offset: 0x002631B0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEdgeTable.vtkEdgeTable_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601B62A RID: 112170
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEdgeTable_InitEdgeInsertion_05(HandleRef pThis, long numPoints, int storeAttributes);

		/// <summary>
		/// Initialize the edge insertion process. Provide an estimate of the number
		/// of points in a dataset (the maximum range value of p1 or p2).  The
		/// storeAttributes variable controls whether attributes are to be stored
		/// with the edge, and what type of attributes. If storeAttributes==1, then
		/// attributes of vtkIdType can be stored. If storeAttributes==2, then
		/// attributes of type void* can be stored. In either case, additional
		/// memory will be required by the data structure to store attribute data
		/// per each edge.  This method is used in conjunction with one of the three
		/// InsertEdge() methods described below (don't mix the InsertEdge()
		/// methods---make sure that the one used is consistent with the
		/// storeAttributes flag set in InitEdgeInsertion()).
		/// </summary>
		// Token: 0x0601B62B RID: 112171 RVA: 0x00264FCC File Offset: 0x002631CC
		public int InitEdgeInsertion(long numPoints, int storeAttributes)
		{
			return vtkEdgeTable.vtkEdgeTable_InitEdgeInsertion_05(base.GetCppThis(), numPoints, storeAttributes);
		}

		// Token: 0x0601B62C RID: 112172
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEdgeTable_InitPointInsertion_06(HandleRef pThis, HandleRef newPts, long estSize);

		/// <summary>
		/// Initialize the point insertion process. The newPts is an object
		/// representing point coordinates into which incremental insertion methods
		/// place their data. The points are associated with the edge.
		/// </summary>
		// Token: 0x0601B62D RID: 112173 RVA: 0x00264FF0 File Offset: 0x002631F0
		public int InitPointInsertion(vtkPoints newPts, long estSize)
		{
			return vtkEdgeTable.vtkEdgeTable_InitPointInsertion_06(base.GetCppThis(), (newPts == null) ? default(HandleRef) : newPts.GetCppThis(), estSize);
		}

		// Token: 0x0601B62E RID: 112174
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEdgeTable_InitTraversal_07(HandleRef pThis);

		/// <summary>
		/// Initialize traversal of edges in table.
		/// </summary>
		// Token: 0x0601B62F RID: 112175 RVA: 0x00265025 File Offset: 0x00263225
		public void InitTraversal()
		{
			vtkEdgeTable.vtkEdgeTable_InitTraversal_07(base.GetCppThis());
		}

		// Token: 0x0601B630 RID: 112176
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEdgeTable_Initialize_08(HandleRef pThis);

		/// <summary>
		/// Free memory and return to the initially instantiated state.
		/// </summary>
		// Token: 0x0601B631 RID: 112177 RVA: 0x00265034 File Offset: 0x00263234
		public void Initialize()
		{
			vtkEdgeTable.vtkEdgeTable_Initialize_08(base.GetCppThis());
		}

		// Token: 0x0601B632 RID: 112178
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEdgeTable_InsertEdge_09(HandleRef pThis, long p1, long p2);

		/// <summary>
		/// Insert the edge (p1,p2) into the table. It is the user's
		/// responsibility to check if the edge has already been inserted
		/// (use IsEdge()). If the storeAttributes flag in InitEdgeInsertion()
		/// has been set, then the method returns a unique integer id (i.e.,
		/// the edge id) that can be used to set and get edge
		/// attributes. Otherwise, the method will return 1. Do not mix this
		/// method with the InsertEdge() method that follows.
		/// </summary>
		// Token: 0x0601B633 RID: 112179 RVA: 0x00265044 File Offset: 0x00263244
		public long InsertEdge(long p1, long p2)
		{
			return vtkEdgeTable.vtkEdgeTable_InsertEdge_09(base.GetCppThis(), p1, p2);
		}

		// Token: 0x0601B634 RID: 112180
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEdgeTable_InsertEdge_10(HandleRef pThis, long p1, long p2, long attributeId);

		/// <summary>
		/// Insert the edge (p1,p2) into the table with the attribute id
		/// specified (make sure the attributeId &gt;= 0). Note that the
		/// attributeId is ignored if the storeAttributes variable was set to
		/// 0 in the InitEdgeInsertion() method. It is the user's
		/// responsibility to check if the edge has already been inserted
		/// (use IsEdge()). Do not mix this method with the other two
		/// InsertEdge() methods.
		/// </summary>
		// Token: 0x0601B635 RID: 112181 RVA: 0x00265065 File Offset: 0x00263265
		public void InsertEdge(long p1, long p2, long attributeId)
		{
			vtkEdgeTable.vtkEdgeTable_InsertEdge_10(base.GetCppThis(), p1, p2, attributeId);
		}

		// Token: 0x0601B636 RID: 112182
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEdgeTable_InsertEdge_11(HandleRef pThis, long p1, long p2, IntPtr ptr);

		/// <summary>
		/// Insert the edge (p1,p2) into the table with the attribute id
		/// specified (make sure the attributeId &gt;= 0). Note that the
		/// attributeId is ignored if the storeAttributes variable was set to
		/// 0 in the InitEdgeInsertion() method. It is the user's
		/// responsibility to check if the edge has already been inserted
		/// (use IsEdge()). Do not mix this method with the other two
		/// InsertEdge() methods.
		/// </summary>
		// Token: 0x0601B637 RID: 112183 RVA: 0x00265077 File Offset: 0x00263277
		public void InsertEdge(long p1, long p2, IntPtr ptr)
		{
			vtkEdgeTable.vtkEdgeTable_InsertEdge_11(base.GetCppThis(), p1, p2, ptr);
		}

		// Token: 0x0601B638 RID: 112184
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEdgeTable_InsertUniquePoint_12(HandleRef pThis, long p1, long p2, IntPtr x, ref long ptId);

		/// <summary>
		/// Insert a unique point on the specified edge. Invoke this method only
		/// after InitPointInsertion() has been called. Return 0 if point was
		/// already in the list, otherwise return 1.
		/// </summary>
		// Token: 0x0601B639 RID: 112185 RVA: 0x0026508C File Offset: 0x0026328C
		public int InsertUniquePoint(long p1, long p2, IntPtr x, ref long ptId)
		{
			return vtkEdgeTable.vtkEdgeTable_InsertUniquePoint_12(base.GetCppThis(), p1, p2, x, ref ptId);
		}

		// Token: 0x0601B63A RID: 112186
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEdgeTable_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate object assuming that 1000 edges are to be inserted.
		/// </summary>
		// Token: 0x0601B63B RID: 112187 RVA: 0x002650B0 File Offset: 0x002632B0
		public override int IsA(string type)
		{
			return vtkEdgeTable.vtkEdgeTable_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x0601B63C RID: 112188
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEdgeTable_IsEdge_14(HandleRef pThis, long p1, long p2);

		/// <summary>
		/// Return an integer id for the edge, or an attribute id of the edge
		/// (p1,p2) if the edge has been previously defined (it depends upon
		/// which version of InsertEdge() is being used); otherwise -1. The
		/// unique integer id can be used to set and retrieve attributes to
		/// the edge.
		/// </summary>
		// Token: 0x0601B63D RID: 112189 RVA: 0x002650D0 File Offset: 0x002632D0
		public long IsEdge(long p1, long p2)
		{
			return vtkEdgeTable.vtkEdgeTable_IsEdge_14(base.GetCppThis(), p1, p2);
		}

		// Token: 0x0601B63E RID: 112190
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEdgeTable_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate object assuming that 1000 edges are to be inserted.
		/// </summary>
		// Token: 0x0601B63F RID: 112191 RVA: 0x002650F4 File Offset: 0x002632F4
		public new static int IsTypeOf(string type)
		{
			return vtkEdgeTable.vtkEdgeTable_IsTypeOf_15(type);
		}

		// Token: 0x0601B640 RID: 112192
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEdgeTable_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object assuming that 1000 edges are to be inserted.
		/// </summary>
		// Token: 0x0601B641 RID: 112193 RVA: 0x00265110 File Offset: 0x00263310
		public new vtkEdgeTable NewInstance()
		{
			vtkEdgeTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEdgeTable.vtkEdgeTable_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEdgeTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B642 RID: 112194
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEdgeTable_Reset_18(HandleRef pThis);

		/// <summary>
		/// Reset the object and prepare for reinsertion of edges. Does not delete
		/// memory like the Initialize() method.
		/// </summary>
		// Token: 0x0601B643 RID: 112195 RVA: 0x0026516A File Offset: 0x0026336A
		public void Reset()
		{
			vtkEdgeTable.vtkEdgeTable_Reset_18(base.GetCppThis());
		}

		// Token: 0x0601B644 RID: 112196
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEdgeTable_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object assuming that 1000 edges are to be inserted.
		/// </summary>
		// Token: 0x0601B645 RID: 112197 RVA: 0x0026517C File Offset: 0x0026337C
		public new static vtkEdgeTable SafeDownCast(vtkObjectBase o)
		{
			vtkEdgeTable vtkEdgeTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEdgeTable.vtkEdgeTable_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEdgeTable = (vtkEdgeTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEdgeTable.Register(null);
				}
			}
			return vtkEdgeTable;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D7E RID: 7550
		public new const string MRFullTypeName = "Kitware.VTK.vtkEdgeTable";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D7F RID: 7551
		public new static readonly string MRClassNameKey = "class vtkEdgeTable";
	}
}
