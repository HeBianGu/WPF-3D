using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUniformGrid
	/// </summary>
	/// <remarks>
	///    image data with blanking
	///
	/// vtkUniformGrid is a subclass of vtkImageData. In addition to all
	/// the image data functionality, it supports blanking.
	/// </remarks>
	// Token: 0x02000ADD RID: 2781
	public class vtkUniformGrid : vtkImageData
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D4CC RID: 120012 RVA: 0x0029581D File Offset: 0x00293A1D
		static vtkUniformGrid()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUniformGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUniformGrid"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D4CD RID: 120013 RVA: 0x00295845 File Offset: 0x00293A45
		public vtkUniformGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D4CE RID: 120014
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniformGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct an empty uniform grid.
		/// </summary>
		// Token: 0x0601D4CF RID: 120015 RVA: 0x00295854 File Offset: 0x00293A54
		public new static vtkUniformGrid New()
		{
			vtkUniformGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniformGrid.vtkUniformGrid_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUniformGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct an empty uniform grid.
		/// </summary>
		// Token: 0x0601D4D0 RID: 120016 RVA: 0x002958A8 File Offset: 0x00293AA8
		public vtkUniformGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUniformGrid.vtkUniformGrid_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D4D1 RID: 120017 RVA: 0x002958EC File Offset: 0x00293AEC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D4D2 RID: 120018
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGrid_BlankCell_01(HandleRef pThis, long ptId);

		/// <summary>
		/// Methods for supporting blanking of cells. Blanking turns on or off
		/// cells in the structured grid.
		/// These methods should be called only after the dimensions of the
		/// grid are set.
		/// </summary>
		// Token: 0x0601D4D3 RID: 120019 RVA: 0x002958F7 File Offset: 0x00293AF7
		public virtual void BlankCell(long ptId)
		{
			vtkUniformGrid.vtkUniformGrid_BlankCell_01(base.GetCppThis(), ptId);
		}

		// Token: 0x0601D4D4 RID: 120020
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGrid_BlankCell_02(HandleRef pThis, int i, int j, int k);

		/// <summary>
		/// Methods for supporting blanking of cells. Blanking turns on or off
		/// cells in the structured grid.
		/// These methods should be called only after the dimensions of the
		/// grid are set.
		/// </summary>
		// Token: 0x0601D4D5 RID: 120021 RVA: 0x00295907 File Offset: 0x00293B07
		public virtual void BlankCell(int i, int j, int k)
		{
			vtkUniformGrid.vtkUniformGrid_BlankCell_02(base.GetCppThis(), i, j, k);
		}

		// Token: 0x0601D4D6 RID: 120022
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGrid_BlankPoint_03(HandleRef pThis, long ptId);

		/// <summary>
		/// Methods for supporting blanking of cells. Blanking turns on or off
		/// points in the structured grid, and hence the cells connected to them.
		/// These methods should be called only after the dimensions of the
		/// grid are set.
		/// </summary>
		// Token: 0x0601D4D7 RID: 120023 RVA: 0x00295919 File Offset: 0x00293B19
		public virtual void BlankPoint(long ptId)
		{
			vtkUniformGrid.vtkUniformGrid_BlankPoint_03(base.GetCppThis(), ptId);
		}

		// Token: 0x0601D4D8 RID: 120024
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGrid_BlankPoint_04(HandleRef pThis, int i, int j, int k);

		/// <summary>
		/// Methods for supporting blanking of cells. Blanking turns on or off
		/// points in the structured grid, and hence the cells connected to them.
		/// These methods should be called only after the dimensions of the
		/// grid are set.
		/// </summary>
		// Token: 0x0601D4D9 RID: 120025 RVA: 0x00295929 File Offset: 0x00293B29
		public virtual void BlankPoint(int i, int j, int k)
		{
			vtkUniformGrid.vtkUniformGrid_BlankPoint_04(base.GetCppThis(), i, j, k);
		}

		// Token: 0x0601D4DA RID: 120026
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGrid_CopyStructure_05(HandleRef pThis, HandleRef ds);

		/// <summary>
		/// Copy the geometric and topological structure of an input image data
		/// object.
		/// </summary>
		// Token: 0x0601D4DB RID: 120027 RVA: 0x0029593C File Offset: 0x00293B3C
		public override void CopyStructure(vtkDataSet ds)
		{
			vtkUniformGrid.vtkUniformGrid_CopyStructure_05(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		// Token: 0x0601D4DC RID: 120028
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniformGrid_FindAndGetCell_06(HandleRef pThis, IntPtr x, HandleRef cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601D4DD RID: 120029 RVA: 0x0029596C File Offset: 0x00293B6C
		public override vtkCell FindAndGetCell(IntPtr x, vtkCell cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniformGrid.vtkUniformGrid_FindAndGetCell_06(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCell = (vtkCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCell.Register(null);
				}
			}
			return vtkCell;
		}

		// Token: 0x0601D4DE RID: 120030
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUniformGrid_FindCell_07(HandleRef pThis, IntPtr x, HandleRef cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601D4DF RID: 120031 RVA: 0x002959FC File Offset: 0x00293BFC
		public override long FindCell(IntPtr x, vtkCell cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			return vtkUniformGrid.vtkUniformGrid_FindCell_07(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights);
		}

		// Token: 0x0601D4E0 RID: 120032
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUniformGrid_FindCell_08(HandleRef pThis, IntPtr x, HandleRef cell, HandleRef gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601D4E1 RID: 120033 RVA: 0x00295A3C File Offset: 0x00293C3C
		public override long FindCell(IntPtr x, vtkCell cell, vtkGenericCell gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			return vtkUniformGrid.vtkUniformGrid_FindCell_08(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), (gencell == null) ? default(HandleRef) : gencell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights);
		}

		// Token: 0x0601D4E2 RID: 120034
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniformGrid_GetCell_09(HandleRef pThis, int i, int j, int k, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601D4E3 RID: 120035 RVA: 0x00295A90 File Offset: 0x00293C90
		public override vtkCell GetCell(int i, int j, int k)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniformGrid.vtkUniformGrid_GetCell_09(base.GetCppThis(), i, j, k, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCell = (vtkCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCell.Register(null);
				}
			}
			return vtkCell;
		}

		// Token: 0x0601D4E4 RID: 120036
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniformGrid_GetCell_10(HandleRef pThis, long cellId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601D4E5 RID: 120037 RVA: 0x00295B04 File Offset: 0x00293D04
		public override vtkCell GetCell(long cellId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniformGrid.vtkUniformGrid_GetCell_10(base.GetCppThis(), cellId, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCell = (vtkCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCell.Register(null);
				}
			}
			return vtkCell;
		}

		// Token: 0x0601D4E6 RID: 120038
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGrid_GetCell_11(HandleRef pThis, long cellId, HandleRef cell);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601D4E7 RID: 120039 RVA: 0x00295B74 File Offset: 0x00293D74
		public override void GetCell(long cellId, vtkGenericCell cell)
		{
			vtkUniformGrid.vtkUniformGrid_GetCell_11(base.GetCppThis(), cellId, (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x0601D4E8 RID: 120040
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGrid_GetCellPoints_12(HandleRef pThis, long cellId, HandleRef ptIds);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601D4E9 RID: 120041 RVA: 0x00295BA4 File Offset: 0x00293DA4
		public override void GetCellPoints(long cellId, vtkIdList ptIds)
		{
			vtkUniformGrid.vtkUniformGrid_GetCellPoints_12(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		// Token: 0x0601D4EA RID: 120042
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUniformGrid_GetCellType_13(HandleRef pThis, long cellId);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601D4EB RID: 120043 RVA: 0x00295BD4 File Offset: 0x00293DD4
		public override int GetCellType(long cellId)
		{
			return vtkUniformGrid.vtkUniformGrid_GetCellType_13(base.GetCppThis(), cellId);
		}

		// Token: 0x0601D4EC RID: 120044
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniformGrid_GetData_14(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601D4ED RID: 120045 RVA: 0x00295BF4 File Offset: 0x00293DF4
		public new static vtkUniformGrid GetData(vtkInformation info)
		{
			vtkUniformGrid vtkUniformGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniformGrid.vtkUniformGrid_GetData_14((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUniformGrid = (vtkUniformGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUniformGrid.Register(null);
				}
			}
			return vtkUniformGrid;
		}

		// Token: 0x0601D4EE RID: 120046
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniformGrid_GetData_15(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601D4EF RID: 120047 RVA: 0x00295C74 File Offset: 0x00293E74
		public new static vtkUniformGrid GetData(vtkInformationVector v, int i)
		{
			vtkUniformGrid vtkUniformGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniformGrid.vtkUniformGrid_GetData_15((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUniformGrid = (vtkUniformGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUniformGrid.Register(null);
				}
			}
			return vtkUniformGrid;
		}

		// Token: 0x0601D4F0 RID: 120048
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUniformGrid_GetDataObjectType_16(HandleRef pThis);

		/// <summary>
		/// Return what type of dataset this is.
		/// </summary>
		// Token: 0x0601D4F1 RID: 120049 RVA: 0x00295CF4 File Offset: 0x00293EF4
		public override int GetDataObjectType()
		{
			return vtkUniformGrid.vtkUniformGrid_GetDataObjectType_16(base.GetCppThis());
		}

		// Token: 0x0601D4F2 RID: 120050
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUniformGrid_GetGridDescription_17(HandleRef pThis);

		/// <summary>
		/// Returns the data description of this uniform grid instance.
		/// </summary>
		// Token: 0x0601D4F3 RID: 120051 RVA: 0x00295D14 File Offset: 0x00293F14
		public int GetGridDescription()
		{
			return vtkUniformGrid.vtkUniformGrid_GetGridDescription_17(base.GetCppThis());
		}

		// Token: 0x0601D4F4 RID: 120052
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUniformGrid_GetMaxCellSize_18(HandleRef pThis);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601D4F5 RID: 120053 RVA: 0x00295D34 File Offset: 0x00293F34
		public override int GetMaxCellSize()
		{
			return vtkUniformGrid.vtkUniformGrid_GetMaxCellSize_18(base.GetCppThis());
		}

		// Token: 0x0601D4F6 RID: 120054
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUniformGrid_GetNumberOfGenerationsFromBase_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct an empty uniform grid.
		/// </summary>
		// Token: 0x0601D4F7 RID: 120055 RVA: 0x00295D54 File Offset: 0x00293F54
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUniformGrid.vtkUniformGrid_GetNumberOfGenerationsFromBase_19(base.GetCppThis(), type);
		}

		// Token: 0x0601D4F8 RID: 120056
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUniformGrid_GetNumberOfGenerationsFromBaseType_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct an empty uniform grid.
		/// </summary>
		// Token: 0x0601D4F9 RID: 120057 RVA: 0x00295D74 File Offset: 0x00293F74
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUniformGrid.vtkUniformGrid_GetNumberOfGenerationsFromBaseType_20(type);
		}

		// Token: 0x0601D4FA RID: 120058
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGrid_GetPointCells_21(HandleRef pThis, long ptId, HandleRef cellIds);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601D4FB RID: 120059 RVA: 0x00295D90 File Offset: 0x00293F90
		public override void GetPointCells(long ptId, vtkIdList cellIds)
		{
			vtkUniformGrid.vtkUniformGrid_GetPointCells_21(base.GetCppThis(), ptId, (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		// Token: 0x0601D4FC RID: 120060
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkUniformGrid_HasAnyBlankCells_22(HandleRef pThis);

		/// <summary>
		/// Returns 1 if there is any visibility constraint on the cells,
		/// 0 otherwise.
		/// </summary>
		// Token: 0x0601D4FD RID: 120061 RVA: 0x00295DC0 File Offset: 0x00293FC0
		public override bool HasAnyBlankCells()
		{
			return vtkUniformGrid.vtkUniformGrid_HasAnyBlankCells_22(base.GetCppThis()) != 0;
		}

		// Token: 0x0601D4FE RID: 120062
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkUniformGrid_HasAnyBlankPoints_23(HandleRef pThis);

		/// <summary>
		/// Returns 1 if there is any visibility constraint on the points,
		/// 0 otherwise.
		/// </summary>
		// Token: 0x0601D4FF RID: 120063 RVA: 0x00295DE8 File Offset: 0x00293FE8
		public override bool HasAnyBlankPoints()
		{
			return vtkUniformGrid.vtkUniformGrid_HasAnyBlankPoints_23(base.GetCppThis()) != 0;
		}

		// Token: 0x0601D500 RID: 120064
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGrid_Initialize_24(HandleRef pThis);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x0601D501 RID: 120065 RVA: 0x00295E0E File Offset: 0x0029400E
		public override void Initialize()
		{
			vtkUniformGrid.vtkUniformGrid_Initialize_24(base.GetCppThis());
		}

		// Token: 0x0601D502 RID: 120066
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUniformGrid_IsA_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct an empty uniform grid.
		/// </summary>
		// Token: 0x0601D503 RID: 120067 RVA: 0x00295E20 File Offset: 0x00294020
		public override int IsA(string type)
		{
			return vtkUniformGrid.vtkUniformGrid_IsA_25(base.GetCppThis(), type);
		}

		// Token: 0x0601D504 RID: 120068
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkUniformGrid_IsCellVisible_26(HandleRef pThis, long cellId);

		/// <summary>
		/// Return non-zero value if specified cell is visible.
		/// These methods should be called only after the dimensions of the
		/// grid are set.
		/// </summary>
		// Token: 0x0601D505 RID: 120069 RVA: 0x00295E40 File Offset: 0x00294040
		public new virtual byte IsCellVisible(long cellId)
		{
			return vtkUniformGrid.vtkUniformGrid_IsCellVisible_26(base.GetCppThis(), cellId);
		}

		// Token: 0x0601D506 RID: 120070
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkUniformGrid_IsPointVisible_27(HandleRef pThis, long pointId);

		/// <summary>
		/// Return non-zero value if specified point is visible.
		/// These methods should be called only after the dimensions of the
		/// grid are set.
		/// </summary>
		// Token: 0x0601D507 RID: 120071 RVA: 0x00295E60 File Offset: 0x00294060
		public new virtual byte IsPointVisible(long pointId)
		{
			return vtkUniformGrid.vtkUniformGrid_IsPointVisible_27(base.GetCppThis(), pointId);
		}

		// Token: 0x0601D508 RID: 120072
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUniformGrid_IsTypeOf_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct an empty uniform grid.
		/// </summary>
		// Token: 0x0601D509 RID: 120073 RVA: 0x00295E80 File Offset: 0x00294080
		public new static int IsTypeOf(string type)
		{
			return vtkUniformGrid.vtkUniformGrid_IsTypeOf_28(type);
		}

		// Token: 0x0601D50A RID: 120074
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniformGrid_NewImageDataCopy_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return non-zero value if specified cell is visible.
		/// These methods should be called only after the dimensions of the
		/// grid are set.
		/// </summary>
		// Token: 0x0601D50B RID: 120075 RVA: 0x00295E9C File Offset: 0x0029409C
		public virtual vtkImageData NewImageDataCopy()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniformGrid.vtkUniformGrid_NewImageDataCopy_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x0601D50C RID: 120076
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniformGrid_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct an empty uniform grid.
		/// </summary>
		// Token: 0x0601D50D RID: 120077 RVA: 0x00295F0C File Offset: 0x0029410C
		public new vtkUniformGrid NewInstance()
		{
			vtkUniformGrid result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniformGrid.vtkUniformGrid_NewInstance_31(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUniformGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D50E RID: 120078
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniformGrid_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct an empty uniform grid.
		/// </summary>
		// Token: 0x0601D50F RID: 120079 RVA: 0x00295F68 File Offset: 0x00294168
		public new static vtkUniformGrid SafeDownCast(vtkObjectBase o)
		{
			vtkUniformGrid vtkUniformGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniformGrid.vtkUniformGrid_SafeDownCast_32((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUniformGrid = (vtkUniformGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUniformGrid.Register(null);
				}
			}
			return vtkUniformGrid;
		}

		// Token: 0x0601D510 RID: 120080
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGrid_UnBlankCell_33(HandleRef pThis, long ptId);

		/// <summary>
		/// Methods for supporting blanking of cells. Blanking turns on or off
		/// cells in the structured grid.
		/// These methods should be called only after the dimensions of the
		/// grid are set.
		/// </summary>
		// Token: 0x0601D511 RID: 120081 RVA: 0x00295FE7 File Offset: 0x002941E7
		public virtual void UnBlankCell(long ptId)
		{
			vtkUniformGrid.vtkUniformGrid_UnBlankCell_33(base.GetCppThis(), ptId);
		}

		// Token: 0x0601D512 RID: 120082
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGrid_UnBlankCell_34(HandleRef pThis, int i, int j, int k);

		/// <summary>
		/// Methods for supporting blanking of cells. Blanking turns on or off
		/// cells in the structured grid.
		/// These methods should be called only after the dimensions of the
		/// grid are set.
		/// </summary>
		// Token: 0x0601D513 RID: 120083 RVA: 0x00295FF7 File Offset: 0x002941F7
		public virtual void UnBlankCell(int i, int j, int k)
		{
			vtkUniformGrid.vtkUniformGrid_UnBlankCell_34(base.GetCppThis(), i, j, k);
		}

		// Token: 0x0601D514 RID: 120084
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGrid_UnBlankPoint_35(HandleRef pThis, long ptId);

		/// <summary>
		/// Methods for supporting blanking of cells. Blanking turns on or off
		/// points in the structured grid, and hence the cells connected to them.
		/// These methods should be called only after the dimensions of the
		/// grid are set.
		/// </summary>
		// Token: 0x0601D515 RID: 120085 RVA: 0x00296009 File Offset: 0x00294209
		public virtual void UnBlankPoint(long ptId)
		{
			vtkUniformGrid.vtkUniformGrid_UnBlankPoint_35(base.GetCppThis(), ptId);
		}

		// Token: 0x0601D516 RID: 120086
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGrid_UnBlankPoint_36(HandleRef pThis, int i, int j, int k);

		/// <summary>
		/// Methods for supporting blanking of cells. Blanking turns on or off
		/// points in the structured grid, and hence the cells connected to them.
		/// These methods should be called only after the dimensions of the
		/// grid are set.
		/// </summary>
		// Token: 0x0601D517 RID: 120087 RVA: 0x00296019 File Offset: 0x00294219
		public virtual void UnBlankPoint(int i, int j, int k)
		{
			vtkUniformGrid.vtkUniformGrid_UnBlankPoint_36(base.GetCppThis(), i, j, k);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EE1 RID: 7905
		public new const string MRFullTypeName = "Kitware.VTK.vtkUniformGrid";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EE2 RID: 7906
		public new static readonly string MRClassNameKey = "class vtkUniformGrid";
	}
}
