using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGenericEdgeTable
	/// </summary>
	/// <remarks>
	///    keep track of edges (defined by pair of integer id's)
	///
	/// vtkGenericEdgeTable is used to indicate the existence of and hold
	/// information about edges. Similar to vtkEdgeTable, this class is
	/// more sophisticated in that it uses reference counting to keep track
	/// of when information about an edge should be deleted.
	///
	/// vtkGenericEdgeTable is a helper class used in the adaptor framework.  It
	/// is used during the tessellation process to hold information about the
	/// error metric on each edge. This avoids recomputing the error metric each
	/// time the same edge is visited.
	/// </remarks>
	// Token: 0x02000A50 RID: 2640
	public class vtkGenericEdgeTable : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B931 RID: 112945 RVA: 0x002697FB File Offset: 0x002679FB
		static vtkGenericEdgeTable()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericEdgeTable.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericEdgeTable"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B932 RID: 112946 RVA: 0x00269823 File Offset: 0x00267A23
		public vtkGenericEdgeTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B933 RID: 112947
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericEdgeTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate an empty edge table.
		/// </summary>
		// Token: 0x0601B934 RID: 112948 RVA: 0x00269834 File Offset: 0x00267A34
		public new static vtkGenericEdgeTable New()
		{
			vtkGenericEdgeTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericEdgeTable.vtkGenericEdgeTable_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericEdgeTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate an empty edge table.
		/// </summary>
		// Token: 0x0601B935 RID: 112949 RVA: 0x00269888 File Offset: 0x00267A88
		public vtkGenericEdgeTable() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGenericEdgeTable.vtkGenericEdgeTable_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B936 RID: 112950 RVA: 0x002698CC File Offset: 0x00267ACC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B937 RID: 112951
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEdgeTable_CheckEdge_01(HandleRef pThis, long e1, long e2, ref long ptId);

		/// <summary>
		/// Method to determine whether an edge is in the table (0 or 1), or not (-1).
		/// It returns whether the edge was split (1) or not (0),
		/// and the point id exists.
		/// </summary>
		// Token: 0x0601B938 RID: 112952 RVA: 0x002698D8 File Offset: 0x00267AD8
		public int CheckEdge(long e1, long e2, ref long ptId)
		{
			return vtkGenericEdgeTable.vtkGenericEdgeTable_CheckEdge_01(base.GetCppThis(), e1, e2, ref ptId);
		}

		// Token: 0x0601B939 RID: 112953
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEdgeTable_CheckEdgeReferenceCount_02(HandleRef pThis, long e1, long e2);

		/// <summary>
		/// Return the edge reference count.
		/// </summary>
		// Token: 0x0601B93A RID: 112954 RVA: 0x002698FC File Offset: 0x00267AFC
		public int CheckEdgeReferenceCount(long e1, long e2)
		{
			return vtkGenericEdgeTable.vtkGenericEdgeTable_CheckEdgeReferenceCount_02(base.GetCppThis(), e1, e2);
		}

		// Token: 0x0601B93B RID: 112955
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEdgeTable_CheckPoint_03(HandleRef pThis, long ptId);

		/// <summary>
		/// Check if a point is already in the point table.
		/// </summary>
		// Token: 0x0601B93C RID: 112956 RVA: 0x00269920 File Offset: 0x00267B20
		public int CheckPoint(long ptId)
		{
			return vtkGenericEdgeTable.vtkGenericEdgeTable_CheckPoint_03(base.GetCppThis(), ptId);
		}

		// Token: 0x0601B93D RID: 112957
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEdgeTable_CheckPoint_04(HandleRef pThis, long ptId, IntPtr point, IntPtr scalar);

		/// <summary>
		/// Check for the existence of a point and return its coordinate value.
		/// \pre scalar_size: sizeof(scalar)==this-&gt;GetNumberOfComponents()
		/// </summary>
		// Token: 0x0601B93E RID: 112958 RVA: 0x00269940 File Offset: 0x00267B40
		public int CheckPoint(long ptId, IntPtr point, IntPtr scalar)
		{
			return vtkGenericEdgeTable.vtkGenericEdgeTable_CheckPoint_04(base.GetCppThis(), ptId, point, scalar);
		}

		// Token: 0x0601B93F RID: 112959
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericEdgeTable_DumpTable_05(HandleRef pThis);

		/// <summary>
		/// For debugging purposes. It is particularly useful to dump the table
		/// and check that nothing is left after a complete iteration. LoadFactor
		/// should ideally be very low to be able to have a constant time access
		/// </summary>
		// Token: 0x0601B940 RID: 112960 RVA: 0x00269962 File Offset: 0x00267B62
		public void DumpTable()
		{
			vtkGenericEdgeTable.vtkGenericEdgeTable_DumpTable_05(base.GetCppThis());
		}

		// Token: 0x0601B941 RID: 112961
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEdgeTable_GetNumberOfComponents_06(HandleRef pThis);

		/// <summary>
		/// Return the total number of components for the point-centered attributes.
		/// \post positive_result: result&gt;0
		/// </summary>
		// Token: 0x0601B942 RID: 112962 RVA: 0x00269974 File Offset: 0x00267B74
		public int GetNumberOfComponents()
		{
			return vtkGenericEdgeTable.vtkGenericEdgeTable_GetNumberOfComponents_06(base.GetCppThis());
		}

		// Token: 0x0601B943 RID: 112963
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericEdgeTable_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK type and print macros.
		/// </summary>
		// Token: 0x0601B944 RID: 112964 RVA: 0x00269994 File Offset: 0x00267B94
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGenericEdgeTable.vtkGenericEdgeTable_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601B945 RID: 112965
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericEdgeTable_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK type and print macros.
		/// </summary>
		// Token: 0x0601B946 RID: 112966 RVA: 0x002699B4 File Offset: 0x00267BB4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGenericEdgeTable.vtkGenericEdgeTable_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0601B947 RID: 112967
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEdgeTable_IncrementEdgeReferenceCount_09(HandleRef pThis, long e1, long e2, long cellId);

		/// <summary>
		/// Method that increments the referencecount and returns it.
		/// </summary>
		// Token: 0x0601B948 RID: 112968 RVA: 0x002699D0 File Offset: 0x00267BD0
		public int IncrementEdgeReferenceCount(long e1, long e2, long cellId)
		{
			return vtkGenericEdgeTable.vtkGenericEdgeTable_IncrementEdgeReferenceCount_09(base.GetCppThis(), e1, e2, cellId);
		}

		// Token: 0x0601B949 RID: 112969
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericEdgeTable_IncrementPointReferenceCount_10(HandleRef pThis, long ptId);

		/// <summary>
		/// Increment the reference count for the indicated point.
		/// </summary>
		// Token: 0x0601B94A RID: 112970 RVA: 0x002699F2 File Offset: 0x00267BF2
		public void IncrementPointReferenceCount(long ptId)
		{
			vtkGenericEdgeTable.vtkGenericEdgeTable_IncrementPointReferenceCount_10(base.GetCppThis(), ptId);
		}

		// Token: 0x0601B94B RID: 112971
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericEdgeTable_Initialize_11(HandleRef pThis, long start);

		/// <summary>
		/// To specify the starting point id. It will initialize LastPointId
		/// This is very sensitive the start point should be cautiously chosen
		/// </summary>
		// Token: 0x0601B94C RID: 112972 RVA: 0x00269A02 File Offset: 0x00267C02
		public void Initialize(long start)
		{
			vtkGenericEdgeTable.vtkGenericEdgeTable_Initialize_11(base.GetCppThis(), start);
		}

		// Token: 0x0601B94D RID: 112973
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericEdgeTable_InsertEdge_12(HandleRef pThis, long e1, long e2, long cellId, int arg3, ref long ptId);

		/// <summary>
		/// Split the edge with the indicated point id.
		/// </summary>
		// Token: 0x0601B94E RID: 112974 RVA: 0x00269A12 File Offset: 0x00267C12
		public void InsertEdge(long e1, long e2, long cellId, int arg3, ref long ptId)
		{
			vtkGenericEdgeTable.vtkGenericEdgeTable_InsertEdge_12(base.GetCppThis(), e1, e2, cellId, arg3, ref ptId);
		}

		// Token: 0x0601B94F RID: 112975
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericEdgeTable_InsertEdge_13(HandleRef pThis, long e1, long e2, long cellId, int arg3);

		/// <summary>
		/// Insert an edge but do not split it.
		/// </summary>
		// Token: 0x0601B950 RID: 112976 RVA: 0x00269A28 File Offset: 0x00267C28
		public void InsertEdge(long e1, long e2, long cellId, int arg3)
		{
			vtkGenericEdgeTable.vtkGenericEdgeTable_InsertEdge_13(base.GetCppThis(), e1, e2, cellId, arg3);
		}

		// Token: 0x0601B951 RID: 112977
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericEdgeTable_InsertPoint_14(HandleRef pThis, long ptId, IntPtr point);

		/// <summary>
		/// Insert point associated with an edge.
		/// </summary>
		// Token: 0x0601B952 RID: 112978 RVA: 0x00269A3C File Offset: 0x00267C3C
		public void InsertPoint(long ptId, IntPtr point)
		{
			vtkGenericEdgeTable.vtkGenericEdgeTable_InsertPoint_14(base.GetCppThis(), ptId, point);
		}

		// Token: 0x0601B953 RID: 112979
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericEdgeTable_InsertPointAndScalar_15(HandleRef pThis, long ptId, IntPtr pt, IntPtr s);

		/// <summary>
		/// Insert point associated with an edge.
		/// </summary>
		// Token: 0x0601B954 RID: 112980 RVA: 0x00269A4D File Offset: 0x00267C4D
		public void InsertPointAndScalar(long ptId, IntPtr pt, IntPtr s)
		{
			vtkGenericEdgeTable.vtkGenericEdgeTable_InsertPointAndScalar_15(base.GetCppThis(), ptId, pt, s);
		}

		// Token: 0x0601B955 RID: 112981
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEdgeTable_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK type and print macros.
		/// </summary>
		// Token: 0x0601B956 RID: 112982 RVA: 0x00269A60 File Offset: 0x00267C60
		public override int IsA(string type)
		{
			return vtkGenericEdgeTable.vtkGenericEdgeTable_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x0601B957 RID: 112983
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEdgeTable_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK type and print macros.
		/// </summary>
		// Token: 0x0601B958 RID: 112984 RVA: 0x00269A80 File Offset: 0x00267C80
		public new static int IsTypeOf(string type)
		{
			return vtkGenericEdgeTable.vtkGenericEdgeTable_IsTypeOf_17(type);
		}

		// Token: 0x0601B959 RID: 112985
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericEdgeTable_LoadFactor_18(HandleRef pThis);

		/// <summary>
		/// For debugging purposes. It is particularly useful to dump the table
		/// and check that nothing is left after a complete iteration. LoadFactor
		/// should ideally be very low to be able to have a constant time access
		/// </summary>
		// Token: 0x0601B95A RID: 112986 RVA: 0x00269A9A File Offset: 0x00267C9A
		public void LoadFactor()
		{
			vtkGenericEdgeTable.vtkGenericEdgeTable_LoadFactor_18(base.GetCppThis());
		}

		// Token: 0x0601B95B RID: 112987
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericEdgeTable_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK type and print macros.
		/// </summary>
		// Token: 0x0601B95C RID: 112988 RVA: 0x00269AAC File Offset: 0x00267CAC
		public new vtkGenericEdgeTable NewInstance()
		{
			vtkGenericEdgeTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericEdgeTable.vtkGenericEdgeTable_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericEdgeTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B95D RID: 112989
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericEdgeTable_RemoveEdge_21(HandleRef pThis, long e1, long e2);

		/// <summary>
		/// Method to remove an edge from the table. The method returns the
		/// current reference count.
		/// </summary>
		// Token: 0x0601B95E RID: 112990 RVA: 0x00269B08 File Offset: 0x00267D08
		public int RemoveEdge(long e1, long e2)
		{
			return vtkGenericEdgeTable.vtkGenericEdgeTable_RemoveEdge_21(base.GetCppThis(), e1, e2);
		}

		// Token: 0x0601B95F RID: 112991
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericEdgeTable_RemovePoint_22(HandleRef pThis, long ptId);

		/// <summary>
		/// Remove a point from the point table.
		/// </summary>
		// Token: 0x0601B960 RID: 112992 RVA: 0x00269B29 File Offset: 0x00267D29
		public void RemovePoint(long ptId)
		{
			vtkGenericEdgeTable.vtkGenericEdgeTable_RemovePoint_22(base.GetCppThis(), ptId);
		}

		// Token: 0x0601B961 RID: 112993
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericEdgeTable_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK type and print macros.
		/// </summary>
		// Token: 0x0601B962 RID: 112994 RVA: 0x00269B3C File Offset: 0x00267D3C
		public new static vtkGenericEdgeTable SafeDownCast(vtkObjectBase o)
		{
			vtkGenericEdgeTable vtkGenericEdgeTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericEdgeTable.vtkGenericEdgeTable_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericEdgeTable = (vtkGenericEdgeTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericEdgeTable.Register(null);
				}
			}
			return vtkGenericEdgeTable;
		}

		// Token: 0x0601B963 RID: 112995
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericEdgeTable_SetNumberOfComponents_24(HandleRef pThis, int count);

		/// <summary>
		/// Set the total number of components for the point-centered attributes.
		/// \pre positive_count: count&gt;0
		/// </summary>
		// Token: 0x0601B964 RID: 112996 RVA: 0x00269BBB File Offset: 0x00267DBB
		public void SetNumberOfComponents(int count)
		{
			vtkGenericEdgeTable.vtkGenericEdgeTable_SetNumberOfComponents_24(base.GetCppThis(), count);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D94 RID: 7572
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericEdgeTable";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D95 RID: 7573
		public new static readonly string MRClassNameKey = "class vtkGenericEdgeTable";
	}
}
