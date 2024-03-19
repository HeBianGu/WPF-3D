using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkHyperTreeGridLocator
	/// </summary>
	/// <remarks>
	///  abstract base class for objects that implement accelerated searches through HyperTree
	/// Grids (HTGs)
	///
	/// The goal of this abstract class is to define an interface to helper objects that implement
	/// optimized search methods through vtkHyperTreeGrids. This class is heavily inspired from the
	/// vtkLocator interface but constructed to be compatible with vtkHyperTreeGrids (which are not
	/// vtkDataSets at the time of this implementation). Ideally, implementations of this interface
	/// leverage the specific structure of HyperTrees and HyperTreeGrids to deliver accelerated search
	/// algorithms through their data.
	///
	/// As a side comment: ideally we would inherit from vtkLocator which only supports vtkDataSets right
	/// now. Hopefully in the future vtkHyperTreeGrid will become a vtkDataSet or vtkCompositeDataSet and
	/// we could accomplish just that with minimal refactoring.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkHyperTreeGrid, vtkHyperTree, vtkHyperTreeGridOrientedCursor, vtkHyperTreeGridNonOrientedCursor
	/// </seealso>
	// Token: 0x02000A5F RID: 2655
	public abstract class vtkHyperTreeGridLocator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601BBE8 RID: 113640 RVA: 0x0026DA2F File Offset: 0x0026BC2F
		static vtkHyperTreeGridLocator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHyperTreeGridLocator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperTreeGridLocator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601BBE9 RID: 113641 RVA: 0x0026DA57 File Offset: 0x0026BC57
		public vtkHyperTreeGridLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601BBEA RID: 113642 RVA: 0x0026DA65 File Offset: 0x0026BC65
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601BBEB RID: 113643
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTreeGridLocator_FindCell_01(HandleRef pThis, IntPtr point, double tol, HandleRef cell, ref int subId, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Pure virtual. Find the cell where a given point lies
		/// @param[in] point an array holding the coordinates of the point to search for
		/// @param[in] tol tolerance level
		/// @param[out] cell pointer to a cell configured with information from return value cell index
		/// @param[out] subId index of the sub cell if composite cell
		/// @param[out] pcoords parametric coordinates of the point in the cell
		/// @param[out] weights interpolation weights of the sought point in the cell
		/// @return the global index of the cell holding the point (-1 if no cell is found or masked)
		/// </summary>
		// Token: 0x0601BBEC RID: 113644 RVA: 0x0026DA70 File Offset: 0x0026BC70
		public virtual long FindCell(IntPtr point, double tol, vtkGenericCell cell, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			return vtkHyperTreeGridLocator.vtkHyperTreeGridLocator_FindCell_01(base.GetCppThis(), point, tol, (cell == null) ? default(HandleRef) : cell.GetCppThis(), ref subId, pcoords, weights);
		}

		// Token: 0x0601BBED RID: 113645
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTreeGridLocator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BBEE RID: 113646 RVA: 0x0026DAAC File Offset: 0x0026BCAC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHyperTreeGridLocator.vtkHyperTreeGridLocator_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601BBEF RID: 113647
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTreeGridLocator_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BBF0 RID: 113648 RVA: 0x0026DACC File Offset: 0x0026BCCC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHyperTreeGridLocator.vtkHyperTreeGridLocator_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601BBF1 RID: 113649
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHyperTreeGridLocator_GetTolerance_04(HandleRef pThis);

		/// <summary>
		/// Get/Set tolerance used when searching for cells in the HTG.
		/// Default is 0.0
		/// </summary>
		// Token: 0x0601BBF2 RID: 113650 RVA: 0x0026DAE8 File Offset: 0x0026BCE8
		public virtual double GetTolerance()
		{
			return vtkHyperTreeGridLocator.vtkHyperTreeGridLocator_GetTolerance_04(base.GetCppThis());
		}

		// Token: 0x0601BBF3 RID: 113651
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridLocator_Initialize_05(HandleRef pThis);

		/// <summary>
		/// Initialize or reinitialize the locator (setting or re-setting clean objects in memory)
		/// (Does nothing)
		/// </summary>
		// Token: 0x0601BBF4 RID: 113652 RVA: 0x0026DB07 File Offset: 0x0026BD07
		public virtual void Initialize()
		{
			vtkHyperTreeGridLocator.vtkHyperTreeGridLocator_Initialize_05(base.GetCppThis());
		}

		// Token: 0x0601BBF5 RID: 113653
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperTreeGridLocator_IntersectWithLine_06(HandleRef pThis, IntPtr p0, IntPtr p1, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, HandleRef cell);

		/// <summary>
		/// Pure virtual. Find first intersection of the line defined by (p0, p1) with the HTG
		/// @param[in] p0 first point of the line
		/// @param[in] p1 second point of the line
		/// @param[in] tol tolerance level
		/// @param[out] t pseudo-time along line path at intersection
		/// @param[out] x intersection point
		/// @param[out] pcoords parametric coordinatesof intersection
		/// @param[out] subId index of the sub cell if composite cell
		/// @param[out] cellId the global index of the intersected cell
		/// @param[out] cell pointer to a vtkCell object corresponding to cellId
		/// @return an integer with 0 if no intersection could be found
		/// </summary>
		// Token: 0x0601BBF6 RID: 113654 RVA: 0x0026DB18 File Offset: 0x0026BD18
		public virtual int IntersectWithLine(IntPtr p0, IntPtr p1, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, vtkGenericCell cell)
		{
			return vtkHyperTreeGridLocator.vtkHyperTreeGridLocator_IntersectWithLine_06(base.GetCppThis(), p0, p1, tol, ref t, x, pcoords, ref subId, ref cellId, (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x0601BBF7 RID: 113655
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperTreeGridLocator_IntersectWithLine_07(HandleRef pThis, IntPtr p0, IntPtr p1, double tol, HandleRef points, HandleRef cellIds, HandleRef cell);

		/// <summary>
		/// Pure virtual. Find all intersections of the line defined by (p0, p1) with the HTG
		/// @param[in] p0 first point of the line
		/// @param[in] p1 second point of the line
		/// @param[in] tol tolerance level
		/// @param[out] points array of points on the line intersecting the HTG
		/// @param[out] cellIds array of cellIds holding the different points of the points array
		/// @param[out] cell pointer to a vtkCell object corresponding to the last cellId found
		/// @return an integer with 0 if no intersection could be found
		/// </summary>
		// Token: 0x0601BBF8 RID: 113656 RVA: 0x0026DB5C File Offset: 0x0026BD5C
		public virtual int IntersectWithLine(IntPtr p0, IntPtr p1, double tol, vtkPoints points, vtkIdList cellIds, vtkGenericCell cell)
		{
			return vtkHyperTreeGridLocator.vtkHyperTreeGridLocator_IntersectWithLine_07(base.GetCppThis(), p0, p1, tol, (points == null) ? default(HandleRef) : points.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x0601BBF9 RID: 113657
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperTreeGridLocator_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BBFA RID: 113658 RVA: 0x0026DBC4 File Offset: 0x0026BDC4
		public override int IsA(string type)
		{
			return vtkHyperTreeGridLocator.vtkHyperTreeGridLocator_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0601BBFB RID: 113659
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperTreeGridLocator_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BBFC RID: 113660 RVA: 0x0026DBE4 File Offset: 0x0026BDE4
		public new static int IsTypeOf(string type)
		{
			return vtkHyperTreeGridLocator.vtkHyperTreeGridLocator_IsTypeOf_09(type);
		}

		// Token: 0x0601BBFD RID: 113661
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeGridLocator_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BBFE RID: 113662 RVA: 0x0026DC00 File Offset: 0x0026BE00
		public new vtkHyperTreeGridLocator NewInstance()
		{
			vtkHyperTreeGridLocator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTreeGridLocator.vtkHyperTreeGridLocator_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperTreeGridLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601BBFF RID: 113663
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeGridLocator_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BC00 RID: 113664 RVA: 0x0026DC5C File Offset: 0x0026BE5C
		public new static vtkHyperTreeGridLocator SafeDownCast(vtkObjectBase o)
		{
			vtkHyperTreeGridLocator vtkHyperTreeGridLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTreeGridLocator.vtkHyperTreeGridLocator_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperTreeGridLocator = (vtkHyperTreeGridLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperTreeGridLocator.Register(null);
				}
			}
			return vtkHyperTreeGridLocator;
		}

		// Token: 0x0601BC01 RID: 113665
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTreeGridLocator_Search_12(HandleRef pThis, IntPtr point);

		/// <summary>
		/// Basic search for cell holding a given point
		/// @param point coordinated of sought point
		/// @return the global index of the cell holding the point (-1 if cell not found or masked)
		/// </summary>
		// Token: 0x0601BC02 RID: 113666 RVA: 0x0026DCDC File Offset: 0x0026BEDC
		public virtual long Search(IntPtr point)
		{
			return vtkHyperTreeGridLocator.vtkHyperTreeGridLocator_Search_12(base.GetCppThis(), point);
		}

		// Token: 0x0601BC03 RID: 113667
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridLocator_SetTolerance_13(HandleRef pThis, double _arg);

		/// <summary>
		/// Get/Set tolerance used when searching for cells in the HTG.
		/// Default is 0.0
		/// </summary>
		// Token: 0x0601BC04 RID: 113668 RVA: 0x0026DCFC File Offset: 0x0026BEFC
		public virtual void SetTolerance(double _arg)
		{
			vtkHyperTreeGridLocator.vtkHyperTreeGridLocator_SetTolerance_13(base.GetCppThis(), _arg);
		}

		// Token: 0x0601BC05 RID: 113669
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridLocator_Update_14(HandleRef pThis);

		/// <summary>
		/// Update the locator's internal variables with respect to changes that could have happened
		/// outside.
		/// </summary>
		// Token: 0x0601BC06 RID: 113670 RVA: 0x0026DD0C File Offset: 0x0026BF0C
		public virtual void Update()
		{
			vtkHyperTreeGridLocator.vtkHyperTreeGridLocator_Update_14(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DB2 RID: 7602
		public new const string MRFullTypeName = "Kitware.VTK.vtkHyperTreeGridLocator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DB3 RID: 7603
		public new static readonly string MRClassNameKey = "class vtkHyperTreeGridLocator";
	}
}
