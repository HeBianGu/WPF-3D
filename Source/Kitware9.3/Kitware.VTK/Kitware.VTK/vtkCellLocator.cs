using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellLocator
	/// </summary>
	/// <remarks>
	///    octree-based spatial search object to quickly locate cells
	///
	/// vtkCellLocator is a spatial search object to quickly locate cells in 3D.
	/// vtkCellLocator uses a uniform-level octree subdivision, where each octant
	/// (an octant is also referred to as a bucket) carries an indication of
	/// whether it is empty or not, and each leaf octant carries a list of the
	/// cells inside of it. (An octant is not empty if it has one or more cells
	/// inside of it.)  Typical operations are intersection with a line to return
	/// candidate cells, or intersection with another vtkCellLocator to return
	/// candidate cells.
	///
	/// @warning
	/// vtkCellLocator utilizes the following parent class parameters:
	/// - Automatic                   (default true)
	/// - Level                       (default 8)
	/// - MaxLevel                    (default 8)
	/// - NumberOfCellsPerNode        (default 25)
	/// - CacheCellBounds             (default true)
	/// - UseExistingSearchStructure  (default false)
	///
	/// vtkCellLocator does NOT utilize the following parameters:
	/// - Tolerance
	/// - RetainCellLists
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAbstractCellLocator vtkStaticCellLocator vtkCellTreeLocator vtkModifiedBSPTree vtkOBBTree
	/// </seealso>
	// Token: 0x02000A28 RID: 2600
	public class vtkCellLocator : vtkAbstractCellLocator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B15B RID: 110939 RVA: 0x0025CDB3 File Offset: 0x0025AFB3
		static vtkCellLocator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellLocator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellLocator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B15C RID: 110940 RVA: 0x0025CDDB File Offset: 0x0025AFDB
		public vtkCellLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B15D RID: 110941
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellLocator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with automatic computation of divisions, averaging
		/// 25 cells per bucket.
		/// </summary>
		// Token: 0x0601B15E RID: 110942 RVA: 0x0025CDEC File Offset: 0x0025AFEC
		public new static vtkCellLocator New()
		{
			vtkCellLocator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellLocator.vtkCellLocator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with automatic computation of divisions, averaging
		/// 25 cells per bucket.
		/// </summary>
		// Token: 0x0601B15F RID: 110943 RVA: 0x0025CE40 File Offset: 0x0025B040
		public vtkCellLocator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellLocator.vtkCellLocator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B160 RID: 110944 RVA: 0x0025CE84 File Offset: 0x0025B084
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B161 RID: 110945
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellLocator_BuildLocator_01(HandleRef pThis);

		/// <summary>
		/// Satisfy vtkLocator abstract interface.
		/// </summary>
		// Token: 0x0601B162 RID: 110946 RVA: 0x0025CE8F File Offset: 0x0025B08F
		public override void BuildLocator()
		{
			vtkCellLocator.vtkCellLocator_BuildLocator_01(base.GetCppThis());
		}

		// Token: 0x0601B163 RID: 110947
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellLocator_FindCell_02(HandleRef pThis, IntPtr x, double arg1, HandleRef GenCell, ref int subId, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Find the cell containing a given point. returns -1 if no cell found
		/// the cell parameters are copied into the supplied variables, a cell must
		/// be provided to store the information.
		///
		/// For other FindCell signatures, see vtkAbstractCellLocator.
		/// </summary>
		// Token: 0x0601B164 RID: 110948 RVA: 0x0025CEA0 File Offset: 0x0025B0A0
		public override long FindCell(IntPtr x, double arg1, vtkGenericCell GenCell, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			return vtkCellLocator.vtkCellLocator_FindCell_02(base.GetCppThis(), x, arg1, (GenCell == null) ? default(HandleRef) : GenCell.GetCppThis(), ref subId, pcoords, weights);
		}

		// Token: 0x0601B165 RID: 110949
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellLocator_FindCellsAlongLine_03(HandleRef pThis, IntPtr p1, IntPtr p2, double tolerance, HandleRef cellsIds);

		/// <summary>
		/// Take the passed line segment and intersect it with the data set.
		/// For each intersection with the bounds of a cell, the cellIds
		/// have the relevant information added sort by t. If cellIds is nullptr
		/// pointer, then no information is generated for that list.
		///
		/// Reimplemented from vtkAbstractCellLocator to showcase that it's a supported function.
		/// </summary>
		// Token: 0x0601B166 RID: 110950 RVA: 0x0025CEDC File Offset: 0x0025B0DC
		public override void FindCellsAlongLine(IntPtr p1, IntPtr p2, double tolerance, vtkIdList cellsIds)
		{
			vtkCellLocator.vtkCellLocator_FindCellsAlongLine_03(base.GetCppThis(), p1, p2, tolerance, (cellsIds == null) ? default(HandleRef) : cellsIds.GetCppThis());
		}

		// Token: 0x0601B167 RID: 110951
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellLocator_FindCellsWithinBounds_04(HandleRef pThis, IntPtr bbox, HandleRef cells);

		/// <summary>
		/// Return a list of unique cell ids inside of a given bounding box. The
		/// user must provide the vtkIdList to populate.
		/// </summary>
		// Token: 0x0601B168 RID: 110952 RVA: 0x0025CF10 File Offset: 0x0025B110
		public override void FindCellsWithinBounds(IntPtr bbox, vtkIdList cells)
		{
			vtkCellLocator.vtkCellLocator_FindCellsWithinBounds_04(base.GetCppThis(), bbox, (cells == null) ? default(HandleRef) : cells.GetCppThis());
		}

		// Token: 0x0601B169 RID: 110953
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellLocator_FindClosestPoint_05(HandleRef pThis, IntPtr x, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2);

		/// <summary>
		/// Return the closest point and the cell which is closest to the point x.
		/// The closest point is somewhere on a cell, it need not be one of the
		/// vertices of the cell.
		///
		/// Reimplemented from vtkAbstractCellLocator to showcase that it's a supported function.
		///
		/// For other FindClosestPoint signatures, see vtkAbstractCellLocator.
		/// </summary>
		// Token: 0x0601B16A RID: 110954 RVA: 0x0025CF40 File Offset: 0x0025B140
		public override void FindClosestPoint(IntPtr x, IntPtr closestPoint, vtkGenericCell cell, ref long cellId, ref int subId, ref double dist2)
		{
			vtkCellLocator.vtkCellLocator_FindClosestPoint_05(base.GetCppThis(), x, closestPoint, (cell == null) ? default(HandleRef) : cell.GetCppThis(), ref cellId, ref subId, ref dist2);
		}

		// Token: 0x0601B16B RID: 110955
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellLocator_FindClosestPointWithinRadius_06(HandleRef pThis, IntPtr x, double radius, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2, ref int inside);

		/// <summary>
		/// Return the closest point within a specified radius and the cell which is
		/// closest to the point x. The closest point is somewhere on a cell, it
		/// need not be one of the vertices of the cell. This method returns 1 if a
		/// point is found within the specified radius. If there are no cells within
		/// the specified radius, the method returns 0 and the values of
		/// closestPoint, cellId, subId, and dist2 are undefined. If a closest point
		/// is found, inside returns the return value of the EvaluatePosition call to
		/// the closest cell; inside(=1) or outside(=0).
		///
		/// For other FindClosestPointWithinRadius signatures, see vtkAbstractCellLocator.
		/// </summary>
		// Token: 0x0601B16C RID: 110956 RVA: 0x0025CF78 File Offset: 0x0025B178
		public override long FindClosestPointWithinRadius(IntPtr x, double radius, IntPtr closestPoint, vtkGenericCell cell, ref long cellId, ref int subId, ref double dist2, ref int inside)
		{
			return vtkCellLocator.vtkCellLocator_FindClosestPointWithinRadius_06(base.GetCppThis(), x, radius, closestPoint, (cell == null) ? default(HandleRef) : cell.GetCppThis(), ref cellId, ref subId, ref dist2, ref inside);
		}

		// Token: 0x0601B16D RID: 110957
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellLocator_ForceBuildLocator_07(HandleRef pThis);

		/// <summary>
		/// Satisfy vtkLocator abstract interface.
		/// </summary>
		// Token: 0x0601B16E RID: 110958 RVA: 0x0025CFB9 File Offset: 0x0025B1B9
		public override void ForceBuildLocator()
		{
			vtkCellLocator.vtkCellLocator_ForceBuildLocator_07(base.GetCppThis());
		}

		// Token: 0x0601B16F RID: 110959
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellLocator_FreeSearchStructure_08(HandleRef pThis);

		/// <summary>
		/// Satisfy vtkLocator abstract interface.
		/// </summary>
		// Token: 0x0601B170 RID: 110960 RVA: 0x0025CFC8 File Offset: 0x0025B1C8
		public override void FreeSearchStructure()
		{
			vtkCellLocator.vtkCellLocator_FreeSearchStructure_08(base.GetCppThis());
		}

		// Token: 0x0601B171 RID: 110961
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellLocator_GenerateRepresentation_09(HandleRef pThis, int level, HandleRef pd);

		/// <summary>
		/// Satisfy vtkLocator abstract interface.
		/// </summary>
		// Token: 0x0601B172 RID: 110962 RVA: 0x0025CFD8 File Offset: 0x0025B1D8
		public override void GenerateRepresentation(int level, vtkPolyData pd)
		{
			vtkCellLocator.vtkCellLocator_GenerateRepresentation_09(base.GetCppThis(), level, (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0601B173 RID: 110963
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellLocator_GetCells_10(HandleRef pThis, int bucket, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the cells in a particular bucket.
		/// </summary>
		// Token: 0x0601B174 RID: 110964 RVA: 0x0025D008 File Offset: 0x0025B208
		public virtual vtkIdList GetCells(int bucket)
		{
			vtkIdList vtkIdList = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellLocator.vtkCellLocator_GetCells_10(base.GetCppThis(), bucket, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdList = (vtkIdList)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdList.Register(null);
				}
			}
			return vtkIdList;
		}

		// Token: 0x0601B175 RID: 110965
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellLocator_GetNumberOfBuckets_11(HandleRef pThis);

		/// <summary>
		/// Return number of buckets available. Ensure that the locator has been
		/// built before attempting to access buckets (octants).
		/// </summary>
		// Token: 0x0601B176 RID: 110966 RVA: 0x0025D078 File Offset: 0x0025B278
		public virtual int GetNumberOfBuckets()
		{
			return vtkCellLocator.vtkCellLocator_GetNumberOfBuckets_11(base.GetCppThis());
		}

		// Token: 0x0601B177 RID: 110967
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellLocator_GetNumberOfCellsPerBucket_12(HandleRef pThis);

		/// <summary>
		/// Specify the average number of cells in each octant.
		/// </summary>
		// Token: 0x0601B178 RID: 110968 RVA: 0x0025D098 File Offset: 0x0025B298
		public int GetNumberOfCellsPerBucket()
		{
			return vtkCellLocator.vtkCellLocator_GetNumberOfCellsPerBucket_12(base.GetCppThis());
		}

		// Token: 0x0601B179 RID: 110969
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellLocator_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to print and obtain type-related information.
		/// </summary>
		// Token: 0x0601B17A RID: 110970 RVA: 0x0025D0B8 File Offset: 0x0025B2B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellLocator.vtkCellLocator_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x0601B17B RID: 110971
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellLocator_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to print and obtain type-related information.
		/// </summary>
		// Token: 0x0601B17C RID: 110972 RVA: 0x0025D0D8 File Offset: 0x0025B2D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellLocator.vtkCellLocator_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x0601B17D RID: 110973
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellLocator_IntersectWithLine_15(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, HandleRef cell);

		/// <summary>
		/// Return intersection point (if any) AND the cell which was intersected by
		/// the finite line. The cell is returned as a cell id and as a generic cell.
		///
		/// For other IntersectWithLine signatures, see vtkAbstractCellLocator.
		/// </summary>
		// Token: 0x0601B17E RID: 110974 RVA: 0x0025D0F4 File Offset: 0x0025B2F4
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, vtkGenericCell cell)
		{
			return vtkCellLocator.vtkCellLocator_IntersectWithLine_15(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId, ref cellId, (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x0601B17F RID: 110975
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellLocator_IntersectWithLine_16(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, HandleRef points, HandleRef cellIds, HandleRef cell);

		/// <summary>
		/// Take the passed line segment and intersect it with the data set.
		/// The return value of the function is 0 if no intersections were found.
		/// For each intersection with the bounds of a cell or with a cell (if a cell is provided),
		/// the points and cellIds have the relevant information added sorted by t.
		/// If points or cellIds are nullptr pointers, then no information is generated for that list.
		///
		/// For other IntersectWithLine signatures, see vtkAbstractCellLocator.
		/// </summary>
		// Token: 0x0601B180 RID: 110976 RVA: 0x0025D138 File Offset: 0x0025B338
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, vtkPoints points, vtkIdList cellIds, vtkGenericCell cell)
		{
			return vtkCellLocator.vtkCellLocator_IntersectWithLine_16(base.GetCppThis(), p1, p2, tol, (points == null) ? default(HandleRef) : points.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x0601B181 RID: 110977
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellLocator_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to print and obtain type-related information.
		/// </summary>
		// Token: 0x0601B182 RID: 110978 RVA: 0x0025D1A0 File Offset: 0x0025B3A0
		public override int IsA(string type)
		{
			return vtkCellLocator.vtkCellLocator_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x0601B183 RID: 110979
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellLocator_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to print and obtain type-related information.
		/// </summary>
		// Token: 0x0601B184 RID: 110980 RVA: 0x0025D1C0 File Offset: 0x0025B3C0
		public new static int IsTypeOf(string type)
		{
			return vtkCellLocator.vtkCellLocator_IsTypeOf_18(type);
		}

		// Token: 0x0601B185 RID: 110981
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellLocator_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to print and obtain type-related information.
		/// </summary>
		// Token: 0x0601B186 RID: 110982 RVA: 0x0025D1DC File Offset: 0x0025B3DC
		public new vtkCellLocator NewInstance()
		{
			vtkCellLocator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellLocator.vtkCellLocator_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B187 RID: 110983
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellLocator_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to print and obtain type-related information.
		/// </summary>
		// Token: 0x0601B188 RID: 110984 RVA: 0x0025D238 File Offset: 0x0025B438
		public new static vtkCellLocator SafeDownCast(vtkObjectBase o)
		{
			vtkCellLocator vtkCellLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellLocator.vtkCellLocator_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellLocator = (vtkCellLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellLocator.Register(null);
				}
			}
			return vtkCellLocator;
		}

		// Token: 0x0601B189 RID: 110985
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellLocator_SetNumberOfCellsPerBucket_22(HandleRef pThis, int N);

		/// <summary>
		/// Specify the average number of cells in each octant.
		/// </summary>
		// Token: 0x0601B18A RID: 110986 RVA: 0x0025D2B7 File Offset: 0x0025B4B7
		public void SetNumberOfCellsPerBucket(int N)
		{
			vtkCellLocator.vtkCellLocator_SetNumberOfCellsPerBucket_22(base.GetCppThis(), N);
		}

		// Token: 0x0601B18B RID: 110987
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellLocator_ShallowCopy_23(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Shallow copy of a vtkCellLocator.
		/// </summary>
		// Token: 0x0601B18C RID: 110988 RVA: 0x0025D2C8 File Offset: 0x0025B4C8
		public override void ShallowCopy(vtkAbstractCellLocator locator)
		{
			vtkCellLocator.vtkCellLocator_ShallowCopy_23(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D43 RID: 7491
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellLocator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D44 RID: 7492
		public new static readonly string MRClassNameKey = "class vtkCellLocator";
	}
}
