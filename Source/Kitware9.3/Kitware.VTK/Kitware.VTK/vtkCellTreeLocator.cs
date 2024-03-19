using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellTreeLocator
	/// </summary>
	/// <remarks>
	///    This class implements the data structures, construction
	/// algorithms for fast cell location.
	///
	/// Cell Tree is a bounding interval hierarchy based data structure, where child boxes
	/// do not form an exact split of the parent boxes along a dimension.  Therefore two axis-
	/// aligned bounding planes (left max and right min) are stored for each node along a
	/// dimension. This class implements the data structure (Cell Tree Node) and its build
	/// and traversal algorithms described in the paper.
	/// Some methods in building and traversing the cell tree in this class were derived
	/// from avtCellLocatorBIH class in the VisIT Visualization Tool.
	///
	/// vtkCellTreeLocator utilizes the following parent class parameters:
	/// - NumberOfCellsPerNode        (default 8)
	/// - CacheCellBounds             (default true)
	/// - UseExistingSearchStructure  (default false)
	///
	/// vtkCellTreeLocator does NOT utilize the following parameters:
	/// - Automatic
	/// - Level
	/// - MaxLevel
	/// - Tolerance
	/// - RetainCellLists
	///
	/// @warning
	/// This class is templated. It may run slower than serial execution if the code
	/// is not optimized during compilation. Build in Release or ReleaseWithDebugInfo.
	///
	/// From the article: "Fast, Memory-Efficient Cell location in Unstructured Grids for Visualization"
	/// by Christoph Garth and Kenneth I. Joy in VisWeek, 2011.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAbstractCellLocator vtkCellLocator vtkStaticCellLocator vtkModifiedBSPTree vtkOBBTree
	/// </seealso>
	// Token: 0x02000A2B RID: 2603
	public class vtkCellTreeLocator : vtkAbstractCellLocator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B1C6 RID: 111046 RVA: 0x0025D9A3 File Offset: 0x0025BBA3
		static vtkCellTreeLocator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellTreeLocator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellTreeLocator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B1C7 RID: 111047 RVA: 0x0025D9CB File Offset: 0x0025BBCB
		public vtkCellTreeLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B1C8 RID: 111048
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellTreeLocator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Constructor sets the maximum number of cells in a leaf to 8 and number of buckets to 6.
		/// Buckets are used in building the cell tree as described in the paper.
		/// </summary>
		// Token: 0x0601B1C9 RID: 111049 RVA: 0x0025D9DC File Offset: 0x0025BBDC
		public new static vtkCellTreeLocator New()
		{
			vtkCellTreeLocator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellTreeLocator.vtkCellTreeLocator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellTreeLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Constructor sets the maximum number of cells in a leaf to 8 and number of buckets to 6.
		/// Buckets are used in building the cell tree as described in the paper.
		/// </summary>
		// Token: 0x0601B1CA RID: 111050 RVA: 0x0025DA30 File Offset: 0x0025BC30
		public vtkCellTreeLocator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellTreeLocator.vtkCellTreeLocator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B1CB RID: 111051 RVA: 0x0025DA74 File Offset: 0x0025BC74
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B1CC RID: 111052
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellTreeLocator_BuildLocator_01(HandleRef pThis);

		/// <summary>
		/// Satisfy vtkLocator abstract interface.
		/// </summary>
		// Token: 0x0601B1CD RID: 111053 RVA: 0x0025DA7F File Offset: 0x0025BC7F
		public override void BuildLocator()
		{
			vtkCellTreeLocator.vtkCellTreeLocator_BuildLocator_01(base.GetCppThis());
		}

		// Token: 0x0601B1CE RID: 111054
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellTreeLocator_FindCell_02(HandleRef pThis, IntPtr pos, double arg1, HandleRef cell, ref int subId, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Find the cell containing a given point. returns -1 if no cell found
		/// the cell parameters are copied into the supplied variables, a cell must
		/// be provided to store the information.
		/// </summary>
		// Token: 0x0601B1CF RID: 111055 RVA: 0x0025DA90 File Offset: 0x0025BC90
		public override long FindCell(IntPtr pos, double arg1, vtkGenericCell cell, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			return vtkCellTreeLocator.vtkCellTreeLocator_FindCell_02(base.GetCppThis(), pos, arg1, (cell == null) ? default(HandleRef) : cell.GetCppThis(), ref subId, pcoords, weights);
		}

		// Token: 0x0601B1D0 RID: 111056
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellTreeLocator_FindCellsAlongLine_03(HandleRef pThis, IntPtr p1, IntPtr p2, double tolerance, HandleRef cellsIds);

		/// <summary>
		/// Take the passed line segment and intersect it with the data set.
		/// For each intersection with the bounds of a cell, the cellIds
		/// have the relevant information added sort by t. If cellIds is nullptr
		/// pointer, then no information is generated for that list.
		///
		/// Reimplemented from vtkAbstractCellLocator to showcase that it's a supported function.
		/// </summary>
		// Token: 0x0601B1D1 RID: 111057 RVA: 0x0025DACC File Offset: 0x0025BCCC
		public override void FindCellsAlongLine(IntPtr p1, IntPtr p2, double tolerance, vtkIdList cellsIds)
		{
			vtkCellTreeLocator.vtkCellTreeLocator_FindCellsAlongLine_03(base.GetCppThis(), p1, p2, tolerance, (cellsIds == null) ? default(HandleRef) : cellsIds.GetCppThis());
		}

		// Token: 0x0601B1D2 RID: 111058
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellTreeLocator_FindCellsWithinBounds_04(HandleRef pThis, IntPtr bbox, HandleRef cells);

		/// <summary>
		/// Return a list of unique cell ids inside of a given bounding box. The
		/// user must provide the vtkIdList to populate.
		/// </summary>
		// Token: 0x0601B1D3 RID: 111059 RVA: 0x0025DB00 File Offset: 0x0025BD00
		public override void FindCellsWithinBounds(IntPtr bbox, vtkIdList cells)
		{
			vtkCellTreeLocator.vtkCellTreeLocator_FindCellsWithinBounds_04(base.GetCppThis(), bbox, (cells == null) ? default(HandleRef) : cells.GetCppThis());
		}

		// Token: 0x0601B1D4 RID: 111060
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellTreeLocator_ForceBuildLocator_05(HandleRef pThis);

		/// <summary>
		/// Satisfy vtkLocator abstract interface.
		/// </summary>
		// Token: 0x0601B1D5 RID: 111061 RVA: 0x0025DB30 File Offset: 0x0025BD30
		public override void ForceBuildLocator()
		{
			vtkCellTreeLocator.vtkCellTreeLocator_ForceBuildLocator_05(base.GetCppThis());
		}

		// Token: 0x0601B1D6 RID: 111062
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellTreeLocator_FreeSearchStructure_06(HandleRef pThis);

		/// <summary>
		/// Satisfy vtkLocator abstract interface.
		/// </summary>
		// Token: 0x0601B1D7 RID: 111063 RVA: 0x0025DB3F File Offset: 0x0025BD3F
		public override void FreeSearchStructure()
		{
			vtkCellTreeLocator.vtkCellTreeLocator_FreeSearchStructure_06(base.GetCppThis());
		}

		// Token: 0x0601B1D8 RID: 111064
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellTreeLocator_GenerateRepresentation_07(HandleRef pThis, int level, HandleRef pd);

		/// <summary>
		/// Satisfy vtkLocator abstract interface.
		/// </summary>
		// Token: 0x0601B1D9 RID: 111065 RVA: 0x0025DB50 File Offset: 0x0025BD50
		public override void GenerateRepresentation(int level, vtkPolyData pd)
		{
			vtkCellTreeLocator.vtkCellTreeLocator_GenerateRepresentation_07(base.GetCppThis(), level, (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0601B1DA RID: 111066
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellTreeLocator_GetLargeIds_08(HandleRef pThis);

		/// <summary>
		/// Inform the user as to whether large ids are being used. This flag only
		/// has meaning after the locator has been built. Large ids are used when the
		/// number of binned points, or the number of bins, is &gt;= the maximum number
		/// of buckets (specified by the user). Note that LargeIds are only available
		/// on 64-bit architectures.
		/// </summary>
		// Token: 0x0601B1DB RID: 111067 RVA: 0x0025DB80 File Offset: 0x0025BD80
		public bool GetLargeIds()
		{
			return vtkCellTreeLocator.vtkCellTreeLocator_GetLargeIds_08(base.GetCppThis()) != 0;
		}

		// Token: 0x0601B1DC RID: 111068
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellTreeLocator_GetNumberOfBuckets_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of buckets.
		///
		/// Default is 6.
		/// </summary>
		// Token: 0x0601B1DD RID: 111069 RVA: 0x0025DBA8 File Offset: 0x0025BDA8
		public virtual int GetNumberOfBuckets()
		{
			return vtkCellTreeLocator.vtkCellTreeLocator_GetNumberOfBuckets_09(base.GetCppThis());
		}

		// Token: 0x0601B1DE RID: 111070
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellTreeLocator_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to print and obtain type-related information.
		/// </summary>
		// Token: 0x0601B1DF RID: 111071 RVA: 0x0025DBC8 File Offset: 0x0025BDC8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellTreeLocator.vtkCellTreeLocator_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x0601B1E0 RID: 111072
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellTreeLocator_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to print and obtain type-related information.
		/// </summary>
		// Token: 0x0601B1E1 RID: 111073 RVA: 0x0025DBE8 File Offset: 0x0025BDE8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellTreeLocator.vtkCellTreeLocator_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x0601B1E2 RID: 111074
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellTreeLocator_IntersectWithLine_12(HandleRef pThis, IntPtr a0, IntPtr a1, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, HandleRef cell);

		/// <summary>
		/// Return intersection point (if any) AND the cell which was intersected by
		/// the finite line. The cell is returned as a cell id and as a generic cell.
		/// </summary>
		// Token: 0x0601B1E3 RID: 111075 RVA: 0x0025DC04 File Offset: 0x0025BE04
		public override int IntersectWithLine(IntPtr a0, IntPtr a1, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, vtkGenericCell cell)
		{
			return vtkCellTreeLocator.vtkCellTreeLocator_IntersectWithLine_12(base.GetCppThis(), a0, a1, tol, ref t, x, pcoords, ref subId, ref cellId, (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x0601B1E4 RID: 111076
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellTreeLocator_IntersectWithLine_13(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, HandleRef points, HandleRef cellIds, HandleRef cell);

		/// <summary>
		/// Take the passed line segment and intersect it with the data set.
		/// The return value of the function is 0 if no intersections were found.
		/// For each intersection with the bounds of a cell or with a cell (if a cell is provided),
		/// the points and cellIds have the relevant information added sorted by t.
		/// If points or cellIds are nullptr pointers, then no information is generated for that list.
		///
		/// For other IntersectWithLine signatures, see vtkAbstractCellLocator.
		/// </summary>
		// Token: 0x0601B1E5 RID: 111077 RVA: 0x0025DC48 File Offset: 0x0025BE48
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, vtkPoints points, vtkIdList cellIds, vtkGenericCell cell)
		{
			return vtkCellTreeLocator.vtkCellTreeLocator_IntersectWithLine_13(base.GetCppThis(), p1, p2, tol, (points == null) ? default(HandleRef) : points.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x0601B1E6 RID: 111078
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellTreeLocator_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to print and obtain type-related information.
		/// </summary>
		// Token: 0x0601B1E7 RID: 111079 RVA: 0x0025DCB0 File Offset: 0x0025BEB0
		public override int IsA(string type)
		{
			return vtkCellTreeLocator.vtkCellTreeLocator_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x0601B1E8 RID: 111080
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellTreeLocator_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to print and obtain type-related information.
		/// </summary>
		// Token: 0x0601B1E9 RID: 111081 RVA: 0x0025DCD0 File Offset: 0x0025BED0
		public new static int IsTypeOf(string type)
		{
			return vtkCellTreeLocator.vtkCellTreeLocator_IsTypeOf_15(type);
		}

		// Token: 0x0601B1EA RID: 111082
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellTreeLocator_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to print and obtain type-related information.
		/// </summary>
		// Token: 0x0601B1EB RID: 111083 RVA: 0x0025DCEC File Offset: 0x0025BEEC
		public new vtkCellTreeLocator NewInstance()
		{
			vtkCellTreeLocator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellTreeLocator.vtkCellTreeLocator_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellTreeLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B1EC RID: 111084
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellTreeLocator_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to print and obtain type-related information.
		/// </summary>
		// Token: 0x0601B1ED RID: 111085 RVA: 0x0025DD48 File Offset: 0x0025BF48
		public new static vtkCellTreeLocator SafeDownCast(vtkObjectBase o)
		{
			vtkCellTreeLocator vtkCellTreeLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellTreeLocator.vtkCellTreeLocator_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellTreeLocator = (vtkCellTreeLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellTreeLocator.Register(null);
				}
			}
			return vtkCellTreeLocator;
		}

		// Token: 0x0601B1EE RID: 111086
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellTreeLocator_SetNumberOfBuckets_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the number of buckets.
		///
		/// Default is 6.
		/// </summary>
		// Token: 0x0601B1EF RID: 111087 RVA: 0x0025DDC7 File Offset: 0x0025BFC7
		public virtual void SetNumberOfBuckets(int _arg)
		{
			vtkCellTreeLocator.vtkCellTreeLocator_SetNumberOfBuckets_19(base.GetCppThis(), _arg);
		}

		// Token: 0x0601B1F0 RID: 111088
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellTreeLocator_ShallowCopy_20(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Shallow copy of a vtkCellTreeLocator.
		/// </summary>
		// Token: 0x0601B1F1 RID: 111089 RVA: 0x0025DDD8 File Offset: 0x0025BFD8
		public override void ShallowCopy(vtkAbstractCellLocator locator)
		{
			vtkCellTreeLocator.vtkCellTreeLocator_ShallowCopy_20(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D49 RID: 7497
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellTreeLocator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D4A RID: 7498
		public new static readonly string MRClassNameKey = "class vtkCellTreeLocator";
	}
}
