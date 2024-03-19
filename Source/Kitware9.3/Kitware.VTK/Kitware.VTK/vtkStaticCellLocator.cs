using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStaticCellLocator
	/// </summary>
	/// <remarks>
	///    perform fast cell location operations
	///
	/// vtkStaticCellLocator is a type of vtkAbstractCellLocator that accelerates
	/// certain operations when performing spatial operations on cells. These
	/// operations include finding a point that contains a cell, and intersecting
	/// cells with a line.
	///
	/// vtkStaticCellLocator is an accelerated version of vtkCellLocator. It is
	/// threaded (via vtkSMPTools), and supports one-time static construction
	/// (i.e., incremental cell insertion is not supported).
	///
	/// @warning
	/// vtkStaticCellLocator utilizes the following parent class parameters:
	/// - Automatic                   (default true)
	/// - NumberOfCellsPerNode        (default 10)
	/// - UseExistingSearchStructure  (default false)
	///
	/// vtkStaticCellLocator does NOT utilize the following parameters:
	/// - CacheCellBounds             (always cached)
	/// - Tolerance
	/// - Level
	/// - MaxLevel
	/// - RetainCellLists
	///
	/// @warning
	/// This class is templated. It may run slower than serial execution if the code
	/// is not optimized during compilation. Build in Release or ReleaseWithDebugInfo.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAbstractCellLocator vtkCellLocator vtkCellTreeLocator vtkModifiedBSPTree vtkOBBTree
	/// </seealso>
	// Token: 0x02000AC8 RID: 2760
	public class vtkStaticCellLocator : vtkAbstractCellLocator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D06A RID: 118890 RVA: 0x0028EF38 File Offset: 0x0028D138
		static vtkStaticCellLocator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStaticCellLocator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStaticCellLocator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D06B RID: 118891 RVA: 0x0028EF60 File Offset: 0x0028D160
		public vtkStaticCellLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D06C RID: 118892
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStaticCellLocator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to instantiate, print and obtain type-related information.
		/// </summary>
		// Token: 0x0601D06D RID: 118893 RVA: 0x0028EF70 File Offset: 0x0028D170
		public new static vtkStaticCellLocator New()
		{
			vtkStaticCellLocator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStaticCellLocator.vtkStaticCellLocator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStaticCellLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods to instantiate, print and obtain type-related information.
		/// </summary>
		// Token: 0x0601D06E RID: 118894 RVA: 0x0028EFC4 File Offset: 0x0028D1C4
		public vtkStaticCellLocator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStaticCellLocator.vtkStaticCellLocator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D06F RID: 118895 RVA: 0x0028F008 File Offset: 0x0028D208
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D070 RID: 118896
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCellLocator_BuildLocator_01(HandleRef pThis);

		/// <summary>
		/// Satisfy vtkLocator abstract interface.
		/// </summary>
		// Token: 0x0601D071 RID: 118897 RVA: 0x0028F013 File Offset: 0x0028D213
		public override void BuildLocator()
		{
			vtkStaticCellLocator.vtkStaticCellLocator_BuildLocator_01(base.GetCppThis());
		}

		// Token: 0x0601D072 RID: 118898
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStaticCellLocator_FindCell_02(HandleRef pThis, IntPtr x, double arg1, HandleRef GenCell, ref int subId, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Find the cell containing a given point. returns -1 if no cell found
		/// the cell parameters are copied into the supplied variables, a cell must
		/// be provided to store the information.
		///
		/// For other FindCell signatures, see vtkAbstractCellLocator.
		/// </summary>
		// Token: 0x0601D073 RID: 118899 RVA: 0x0028F024 File Offset: 0x0028D224
		public override long FindCell(IntPtr x, double arg1, vtkGenericCell GenCell, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			return vtkStaticCellLocator.vtkStaticCellLocator_FindCell_02(base.GetCppThis(), x, arg1, (GenCell == null) ? default(HandleRef) : GenCell.GetCppThis(), ref subId, pcoords, weights);
		}

		// Token: 0x0601D074 RID: 118900
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCellLocator_FindCellsAlongLine_03(HandleRef pThis, IntPtr p1, IntPtr p2, double tolerance, HandleRef cellsIds);

		/// <summary>
		/// Take the passed line segment and intersect it with the data set.
		/// For each intersection with the bounds of a cell, the cellIds
		/// have the relevant information added. If cellIds is nullptr
		/// pointer, then no information is generated for that list.
		///
		/// Reimplemented from vtkAbstractCellLocator to showcase that it's a supported function.
		/// </summary>
		// Token: 0x0601D075 RID: 118901 RVA: 0x0028F060 File Offset: 0x0028D260
		public override void FindCellsAlongLine(IntPtr p1, IntPtr p2, double tolerance, vtkIdList cellsIds)
		{
			vtkStaticCellLocator.vtkStaticCellLocator_FindCellsAlongLine_03(base.GetCppThis(), p1, p2, tolerance, (cellsIds == null) ? default(HandleRef) : cellsIds.GetCppThis());
		}

		// Token: 0x0601D076 RID: 118902
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCellLocator_FindCellsAlongPlane_04(HandleRef pThis, IntPtr o, IntPtr n, double tolerance, HandleRef cells);

		/// <summary>
		/// Take the passed line segment and intersect it with the data set.
		/// For each intersection with the bounds of a cell, the cellIds
		/// have the relevant information added sort by t. If cellIds is nullptr
		/// pointer, then no information is generated for that list.
		/// </summary>
		// Token: 0x0601D077 RID: 118903 RVA: 0x0028F094 File Offset: 0x0028D294
		public override void FindCellsAlongPlane(IntPtr o, IntPtr n, double tolerance, vtkIdList cells)
		{
			vtkStaticCellLocator.vtkStaticCellLocator_FindCellsAlongPlane_04(base.GetCppThis(), o, n, tolerance, (cells == null) ? default(HandleRef) : cells.GetCppThis());
		}

		// Token: 0x0601D078 RID: 118904
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCellLocator_FindCellsWithinBounds_05(HandleRef pThis, IntPtr bbox, HandleRef cells);

		/// <summary>
		/// Return a list of unique cell ids inside of a given bounding box. The
		/// user must provide the vtkIdList to populate.
		/// </summary>
		// Token: 0x0601D079 RID: 118905 RVA: 0x0028F0C8 File Offset: 0x0028D2C8
		public override void FindCellsWithinBounds(IntPtr bbox, vtkIdList cells)
		{
			vtkStaticCellLocator.vtkStaticCellLocator_FindCellsWithinBounds_05(base.GetCppThis(), bbox, (cells == null) ? default(HandleRef) : cells.GetCppThis());
		}

		// Token: 0x0601D07A RID: 118906
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCellLocator_FindClosestPoint_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2);

		/// <summary>
		/// Return the closest point and the cell which is closest to the point x.
		/// The closest point is somewhere on a cell, it need not be one of the
		/// vertices of the cell.
		///
		/// Reimplemented from vtkAbstractCellLocator to showcase that it's a supported function.
		///
		/// For other FindClosestPoint signatures, see vtkAbstractCellLocator.
		/// </summary>
		// Token: 0x0601D07B RID: 118907 RVA: 0x0028F0F8 File Offset: 0x0028D2F8
		public override void FindClosestPoint(IntPtr x, IntPtr closestPoint, vtkGenericCell cell, ref long cellId, ref int subId, ref double dist2)
		{
			vtkStaticCellLocator.vtkStaticCellLocator_FindClosestPoint_06(base.GetCppThis(), x, closestPoint, (cell == null) ? default(HandleRef) : cell.GetCppThis(), ref cellId, ref subId, ref dist2);
		}

		// Token: 0x0601D07C RID: 118908
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStaticCellLocator_FindClosestPointWithinRadius_07(HandleRef pThis, IntPtr x, double radius, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2, ref int inside);

		/// <summary>
		/// Return the closest point within a specified radius and the cell which is
		/// closest to the point x. The closest point is somewhere on a cell, it
		/// need not be one of the vertices of the cell. This method returns 1 if a
		/// point is found within the specified radius. If there are no cells within
		/// the specified radius, the method returns 0 and the values of
		/// closestPoint, cellId, subId, and dist2 are undefined. If a closest point
		/// is found, inside returns the return value of the EvaluatePosition call to
		/// the closest cell; inside(=1) or outside(=0).
		/// </summary>
		// Token: 0x0601D07D RID: 118909 RVA: 0x0028F130 File Offset: 0x0028D330
		public override long FindClosestPointWithinRadius(IntPtr x, double radius, IntPtr closestPoint, vtkGenericCell cell, ref long cellId, ref int subId, ref double dist2, ref int inside)
		{
			return vtkStaticCellLocator.vtkStaticCellLocator_FindClosestPointWithinRadius_07(base.GetCppThis(), x, radius, closestPoint, (cell == null) ? default(HandleRef) : cell.GetCppThis(), ref cellId, ref subId, ref dist2, ref inside);
		}

		// Token: 0x0601D07E RID: 118910
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCellLocator_ForceBuildLocator_08(HandleRef pThis);

		/// <summary>
		/// Satisfy vtkLocator abstract interface.
		/// </summary>
		// Token: 0x0601D07F RID: 118911 RVA: 0x0028F171 File Offset: 0x0028D371
		public override void ForceBuildLocator()
		{
			vtkStaticCellLocator.vtkStaticCellLocator_ForceBuildLocator_08(base.GetCppThis());
		}

		// Token: 0x0601D080 RID: 118912
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCellLocator_FreeSearchStructure_09(HandleRef pThis);

		/// <summary>
		/// Satisfy vtkLocator abstract interface.
		/// </summary>
		// Token: 0x0601D081 RID: 118913 RVA: 0x0028F180 File Offset: 0x0028D380
		public override void FreeSearchStructure()
		{
			vtkStaticCellLocator.vtkStaticCellLocator_FreeSearchStructure_09(base.GetCppThis());
		}

		// Token: 0x0601D082 RID: 118914
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCellLocator_GenerateRepresentation_10(HandleRef pThis, int level, HandleRef pd);

		/// <summary>
		/// Satisfy vtkLocator abstract interface.
		/// </summary>
		// Token: 0x0601D083 RID: 118915 RVA: 0x0028F190 File Offset: 0x0028D390
		public override void GenerateRepresentation(int level, vtkPolyData pd)
		{
			vtkStaticCellLocator.vtkStaticCellLocator_GenerateRepresentation_10(base.GetCppThis(), level, (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0601D084 RID: 118916
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStaticCellLocator_GetDivisions_11(HandleRef pThis);

		/// <summary>
		/// Set the number of divisions in x-y-z directions. If the Automatic data
		/// member is enabled, the Divisions are set according to the
		/// NumberOfCellsPerNode and MaxNumberOfBuckets data members. The number
		/// of divisions must be &gt;= 1 in each direction.
		/// </summary>
		// Token: 0x0601D085 RID: 118917 RVA: 0x0028F1C0 File Offset: 0x0028D3C0
		public virtual int[] GetDivisions()
		{
			IntPtr intPtr = vtkStaticCellLocator.vtkStaticCellLocator_GetDivisions_11(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601D086 RID: 118918
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCellLocator_GetDivisions_12(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the number of divisions in x-y-z directions. If the Automatic data
		/// member is enabled, the Divisions are set according to the
		/// NumberOfCellsPerNode and MaxNumberOfBuckets data members. The number
		/// of divisions must be &gt;= 1 in each direction.
		/// </summary>
		// Token: 0x0601D087 RID: 118919 RVA: 0x0028F208 File Offset: 0x0028D408
		public virtual void GetDivisions(IntPtr data)
		{
			vtkStaticCellLocator.vtkStaticCellLocator_GetDivisions_12(base.GetCppThis(), data);
		}

		// Token: 0x0601D088 RID: 118920
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStaticCellLocator_GetLargeIds_13(HandleRef pThis);

		/// <summary>
		/// Inform the user as to whether large ids are being used. This flag only
		/// has meaning after the locator has been built. Large ids are used when the
		/// number of binned points, or the number of bins, is &gt;= the maximum number
		/// of buckets (specified by the user). Note that LargeIds are only available
		/// on 64-bit architectures.
		/// </summary>
		// Token: 0x0601D089 RID: 118921 RVA: 0x0028F218 File Offset: 0x0028D418
		public bool GetLargeIds()
		{
			return vtkStaticCellLocator.vtkStaticCellLocator_GetLargeIds_13(base.GetCppThis()) != 0;
		}

		// Token: 0x0601D08A RID: 118922
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStaticCellLocator_GetMaxNumberOfBuckets_14(HandleRef pThis);

		/// <summary>
		/// Set the maximum number of buckets in the locator. By default the value
		/// is set to VTK_INT_MAX. Note that there are significant performance
		/// implications at work here. If the number of buckets is set very large
		/// (meaning &gt; VTK_INT_MAX) then internal sorting may be performed using
		/// 64-bit integers (which is much slower than using a 32-bit int). Of
		/// course, memory requirements may dramatically increase as well.  It is
		/// recommended that the default value be used; but for extremely large data
		/// it may be desired to create a locator with an exceptionally large number
		/// of buckets. Note also that during initialization of the locator if the
		/// MaxNumberOfBuckets threshold is exceeded, the Divisions are scaled down
		/// in such a way as not to exceed the MaxNumberOfBuckets proportionally to
		/// the size of the bounding box in the x-y-z directions.
		/// </summary>
		// Token: 0x0601D08B RID: 118923 RVA: 0x0028F240 File Offset: 0x0028D440
		public virtual long GetMaxNumberOfBuckets()
		{
			return vtkStaticCellLocator.vtkStaticCellLocator_GetMaxNumberOfBuckets_14(base.GetCppThis());
		}

		// Token: 0x0601D08C RID: 118924
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStaticCellLocator_GetMaxNumberOfBucketsMaxValue_15(HandleRef pThis);

		/// <summary>
		/// Set the maximum number of buckets in the locator. By default the value
		/// is set to VTK_INT_MAX. Note that there are significant performance
		/// implications at work here. If the number of buckets is set very large
		/// (meaning &gt; VTK_INT_MAX) then internal sorting may be performed using
		/// 64-bit integers (which is much slower than using a 32-bit int). Of
		/// course, memory requirements may dramatically increase as well.  It is
		/// recommended that the default value be used; but for extremely large data
		/// it may be desired to create a locator with an exceptionally large number
		/// of buckets. Note also that during initialization of the locator if the
		/// MaxNumberOfBuckets threshold is exceeded, the Divisions are scaled down
		/// in such a way as not to exceed the MaxNumberOfBuckets proportionally to
		/// the size of the bounding box in the x-y-z directions.
		/// </summary>
		// Token: 0x0601D08D RID: 118925 RVA: 0x0028F260 File Offset: 0x0028D460
		public virtual long GetMaxNumberOfBucketsMaxValue()
		{
			return vtkStaticCellLocator.vtkStaticCellLocator_GetMaxNumberOfBucketsMaxValue_15(base.GetCppThis());
		}

		// Token: 0x0601D08E RID: 118926
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStaticCellLocator_GetMaxNumberOfBucketsMinValue_16(HandleRef pThis);

		/// <summary>
		/// Set the maximum number of buckets in the locator. By default the value
		/// is set to VTK_INT_MAX. Note that there are significant performance
		/// implications at work here. If the number of buckets is set very large
		/// (meaning &gt; VTK_INT_MAX) then internal sorting may be performed using
		/// 64-bit integers (which is much slower than using a 32-bit int). Of
		/// course, memory requirements may dramatically increase as well.  It is
		/// recommended that the default value be used; but for extremely large data
		/// it may be desired to create a locator with an exceptionally large number
		/// of buckets. Note also that during initialization of the locator if the
		/// MaxNumberOfBuckets threshold is exceeded, the Divisions are scaled down
		/// in such a way as not to exceed the MaxNumberOfBuckets proportionally to
		/// the size of the bounding box in the x-y-z directions.
		/// </summary>
		// Token: 0x0601D08F RID: 118927 RVA: 0x0028F280 File Offset: 0x0028D480
		public virtual long GetMaxNumberOfBucketsMinValue()
		{
			return vtkStaticCellLocator.vtkStaticCellLocator_GetMaxNumberOfBucketsMinValue_16(base.GetCppThis());
		}

		// Token: 0x0601D090 RID: 118928
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStaticCellLocator_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, print and obtain type-related information.
		/// </summary>
		// Token: 0x0601D091 RID: 118929 RVA: 0x0028F2A0 File Offset: 0x0028D4A0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStaticCellLocator.vtkStaticCellLocator_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x0601D092 RID: 118930
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStaticCellLocator_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, print and obtain type-related information.
		/// </summary>
		// Token: 0x0601D093 RID: 118931 RVA: 0x0028F2C0 File Offset: 0x0028D4C0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStaticCellLocator.vtkStaticCellLocator_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x0601D094 RID: 118932
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStaticCellLocator_InsideCellBounds_19(HandleRef pThis, IntPtr x, long cellId);

		/// <summary>
		/// Quickly test if a point is inside the bounds of a particular cell.
		/// This function should be used ONLY after the locator is built.
		/// </summary>
		// Token: 0x0601D095 RID: 118933 RVA: 0x0028F2DC File Offset: 0x0028D4DC
		public override bool InsideCellBounds(IntPtr x, long cellId)
		{
			return vtkStaticCellLocator.vtkStaticCellLocator_InsideCellBounds_19(base.GetCppThis(), x, cellId) != 0;
		}

		// Token: 0x0601D096 RID: 118934
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStaticCellLocator_IntersectWithLine_20(HandleRef pThis, IntPtr a0, IntPtr a1, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, HandleRef cell);

		/// <summary>
		/// Return intersection point (if any) AND the cell which was intersected by
		/// the finite line. The cell is returned as a cell id and as a generic cell.
		///
		/// For other IntersectWithLine signatures, see vtkAbstractCellLocator.
		/// </summary>
		// Token: 0x0601D097 RID: 118935 RVA: 0x0028F304 File Offset: 0x0028D504
		public override int IntersectWithLine(IntPtr a0, IntPtr a1, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, vtkGenericCell cell)
		{
			return vtkStaticCellLocator.vtkStaticCellLocator_IntersectWithLine_20(base.GetCppThis(), a0, a1, tol, ref t, x, pcoords, ref subId, ref cellId, (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x0601D098 RID: 118936
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStaticCellLocator_IntersectWithLine_21(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, HandleRef points, HandleRef cellIds, HandleRef cell);

		/// <summary>
		/// Take the passed line segment and intersect it with the data set.
		/// The return value of the function is 0 if no intersections were found.
		/// For each intersection with the bounds of a cell or with a cell (if a cell is provided),
		/// the points and cellIds have the relevant information added sorted by t.
		/// If points or cellIds are nullptr pointers, then no information is generated for that list.
		///
		/// For other IntersectWithLine signatures, see vtkAbstractCellLocator.
		/// </summary>
		// Token: 0x0601D099 RID: 118937 RVA: 0x0028F348 File Offset: 0x0028D548
		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, vtkPoints points, vtkIdList cellIds, vtkGenericCell cell)
		{
			return vtkStaticCellLocator.vtkStaticCellLocator_IntersectWithLine_21(base.GetCppThis(), p1, p2, tol, (points == null) ? default(HandleRef) : points.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x0601D09A RID: 118938
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStaticCellLocator_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, print and obtain type-related information.
		/// </summary>
		// Token: 0x0601D09B RID: 118939 RVA: 0x0028F3B0 File Offset: 0x0028D5B0
		public override int IsA(string type)
		{
			return vtkStaticCellLocator.vtkStaticCellLocator_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x0601D09C RID: 118940
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStaticCellLocator_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, print and obtain type-related information.
		/// </summary>
		// Token: 0x0601D09D RID: 118941 RVA: 0x0028F3D0 File Offset: 0x0028D5D0
		public new static int IsTypeOf(string type)
		{
			return vtkStaticCellLocator.vtkStaticCellLocator_IsTypeOf_23(type);
		}

		// Token: 0x0601D09E RID: 118942
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStaticCellLocator_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to instantiate, print and obtain type-related information.
		/// </summary>
		// Token: 0x0601D09F RID: 118943 RVA: 0x0028F3EC File Offset: 0x0028D5EC
		public new vtkStaticCellLocator NewInstance()
		{
			vtkStaticCellLocator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStaticCellLocator.vtkStaticCellLocator_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStaticCellLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D0A0 RID: 118944
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStaticCellLocator_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to instantiate, print and obtain type-related information.
		/// </summary>
		// Token: 0x0601D0A1 RID: 118945 RVA: 0x0028F448 File Offset: 0x0028D648
		public new static vtkStaticCellLocator SafeDownCast(vtkObjectBase o)
		{
			vtkStaticCellLocator vtkStaticCellLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStaticCellLocator.vtkStaticCellLocator_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStaticCellLocator = (vtkStaticCellLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStaticCellLocator.Register(null);
				}
			}
			return vtkStaticCellLocator;
		}

		// Token: 0x0601D0A2 RID: 118946
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCellLocator_SetDivisions_27(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		/// <summary>
		/// Set the number of divisions in x-y-z directions. If the Automatic data
		/// member is enabled, the Divisions are set according to the
		/// NumberOfCellsPerNode and MaxNumberOfBuckets data members. The number
		/// of divisions must be &gt;= 1 in each direction.
		/// </summary>
		// Token: 0x0601D0A3 RID: 118947 RVA: 0x0028F4C7 File Offset: 0x0028D6C7
		public virtual void SetDivisions(int _arg1, int _arg2, int _arg3)
		{
			vtkStaticCellLocator.vtkStaticCellLocator_SetDivisions_27(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601D0A4 RID: 118948
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCellLocator_SetDivisions_28(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the number of divisions in x-y-z directions. If the Automatic data
		/// member is enabled, the Divisions are set according to the
		/// NumberOfCellsPerNode and MaxNumberOfBuckets data members. The number
		/// of divisions must be &gt;= 1 in each direction.
		/// </summary>
		// Token: 0x0601D0A5 RID: 118949 RVA: 0x0028F4D9 File Offset: 0x0028D6D9
		public virtual void SetDivisions(IntPtr _arg)
		{
			vtkStaticCellLocator.vtkStaticCellLocator_SetDivisions_28(base.GetCppThis(), _arg);
		}

		// Token: 0x0601D0A6 RID: 118950
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCellLocator_SetMaxNumberOfBuckets_29(HandleRef pThis, long _arg);

		/// <summary>
		/// Set the maximum number of buckets in the locator. By default the value
		/// is set to VTK_INT_MAX. Note that there are significant performance
		/// implications at work here. If the number of buckets is set very large
		/// (meaning &gt; VTK_INT_MAX) then internal sorting may be performed using
		/// 64-bit integers (which is much slower than using a 32-bit int). Of
		/// course, memory requirements may dramatically increase as well.  It is
		/// recommended that the default value be used; but for extremely large data
		/// it may be desired to create a locator with an exceptionally large number
		/// of buckets. Note also that during initialization of the locator if the
		/// MaxNumberOfBuckets threshold is exceeded, the Divisions are scaled down
		/// in such a way as not to exceed the MaxNumberOfBuckets proportionally to
		/// the size of the bounding box in the x-y-z directions.
		/// </summary>
		// Token: 0x0601D0A7 RID: 118951 RVA: 0x0028F4E9 File Offset: 0x0028D6E9
		public virtual void SetMaxNumberOfBuckets(long _arg)
		{
			vtkStaticCellLocator.vtkStaticCellLocator_SetMaxNumberOfBuckets_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0601D0A8 RID: 118952
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCellLocator_ShallowCopy_30(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Shallow copy of a vtkStaticCellLocator.
		/// </summary>
		// Token: 0x0601D0A9 RID: 118953 RVA: 0x0028F4FC File Offset: 0x0028D6FC
		public override void ShallowCopy(vtkAbstractCellLocator locator)
		{
			vtkStaticCellLocator.vtkStaticCellLocator_ShallowCopy_30(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EB5 RID: 7861
		public new const string MRFullTypeName = "Kitware.VTK.vtkStaticCellLocator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EB6 RID: 7862
		public new static readonly string MRClassNameKey = "class vtkStaticCellLocator";
	}
}
