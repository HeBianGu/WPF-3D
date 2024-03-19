using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPointSet
	/// </summary>
	/// <remarks>
	///    concrete class for storing a set of points
	///
	/// vtkPointSet is an concrete class representing a set of points
	/// that specifies the interface for
	/// datasets that explicitly use "point" arrays to represent geometry.
	/// For example, vtkPolyData, vtkUnstructuredGrid, and vtkStructuredGrid
	/// require point arrays to specify point positions, while vtkImageData
	/// represents point positions implicitly (and hence is not a subclass
	/// of vtkImageData).
	///
	/// Note: The vtkPolyData and vtkUnstructuredGrid datasets (derived classes of
	/// vtkPointSet) are often used in geometric computation (e.g.,
	/// vtkDelaunay2D).  In most cases during filter execution the output geometry
	/// and/or topology is created once and provided as output; however in a very
	/// few cases the underlying geometry/topology may be created and then
	/// incrementally modified. This has implications on the use of supporting
	/// classes like locators and cell links topological structures which may be
	/// required to support incremental editing operations. Consequently, there is
	/// a flag, Editable, that controls whether the dataset can be incrementally
	/// edited after it is initially created. By default, and for performance
	/// reasons, vtkPointSet derived classes are created as non-editable.  The few
	/// methods that require incremental editing capabilities are documented in
	/// derived classes.
	///
	/// Another important feature of vtkPointSet classes is the use of an internal
	/// locator to speed up certain operations like FindCell(). Depending on the
	/// application and desired performance, different locators (either a cell or
	/// point locator) of different locator types may be used, along with different
	/// strategies for using the locators to perform various operations. See
	/// the class vtkFindCellStrategy for more information
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPolyData vtkStructuredGrid vtkUnstructuredGrid vtkFindCellStrategy
	/// </seealso>
	// Token: 0x020000EA RID: 234
	public class vtkPointSet : vtkDataSet
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003092 RID: 12434 RVA: 0x00047433 File Offset: 0x00045633
		static vtkPointSet()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointSet"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003093 RID: 12435 RVA: 0x0004745B File Offset: 0x0004565B
		public vtkPointSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003094 RID: 12436
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard instantiation method.
		/// </summary>
		// Token: 0x06003095 RID: 12437 RVA: 0x0004746C File Offset: 0x0004566C
		public new static vtkPointSet New()
		{
			vtkPointSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSet.vtkPointSet_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard instantiation method.
		/// </summary>
		// Token: 0x06003096 RID: 12438 RVA: 0x000474C0 File Offset: 0x000456C0
		public vtkPointSet() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPointSet.vtkPointSet_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003097 RID: 12439 RVA: 0x00047504 File Offset: 0x00045704
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003098 RID: 12440
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSet_BuildCellLocator_01(HandleRef pThis);

		/// <summary>
		/// Build the cell locator. In a multi-threaded environment,
		/// call this method in a single thread before using FindCell().
		/// </summary>
		// Token: 0x06003099 RID: 12441 RVA: 0x0004750F File Offset: 0x0004570F
		public void BuildCellLocator()
		{
			vtkPointSet.vtkPointSet_BuildCellLocator_01(base.GetCppThis());
		}

		// Token: 0x0600309A RID: 12442
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSet_BuildLocator_02(HandleRef pThis);

		/// <summary>
		/// Build the internal point locator . In a multi-threaded environment, call
		/// this method in a single thread before using FindCell() or FindPoint().
		/// </summary>
		// Token: 0x0600309B RID: 12443 RVA: 0x0004751E File Offset: 0x0004571E
		public void BuildLocator()
		{
			vtkPointSet.vtkPointSet_BuildLocator_02(base.GetCppThis());
		}

		// Token: 0x0600309C RID: 12444
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSet_BuildPointLocator_03(HandleRef pThis);

		/// <summary>
		/// Build the internal point locator . In a multi-threaded environment, call
		/// this method in a single thread before using FindCell() or FindPoint().
		/// </summary>
		// Token: 0x0600309D RID: 12445 RVA: 0x0004752D File Offset: 0x0004572D
		public void BuildPointLocator()
		{
			vtkPointSet.vtkPointSet_BuildPointLocator_03(base.GetCppThis());
		}

		// Token: 0x0600309E RID: 12446
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSet_ComputeBounds_04(HandleRef pThis);

		/// <summary>
		/// Compute the (X, Y, Z)  bounds of the data.
		/// </summary>
		// Token: 0x0600309F RID: 12447 RVA: 0x0004753C File Offset: 0x0004573C
		public override void ComputeBounds()
		{
			vtkPointSet.vtkPointSet_ComputeBounds_04(base.GetCppThis());
		}

		// Token: 0x060030A0 RID: 12448
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSet_CopyStructure_05(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Copy the geometric structure of an input point set object.
		/// </summary>
		// Token: 0x060030A1 RID: 12449 RVA: 0x0004754C File Offset: 0x0004574C
		public override void CopyStructure(vtkDataSet pd)
		{
			vtkPointSet.vtkPointSet_CopyStructure_05(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x060030A2 RID: 12450
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSet_DeepCopy_06(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Shallow and Deep copy.
		/// </summary>
		// Token: 0x060030A3 RID: 12451 RVA: 0x0004757C File Offset: 0x0004577C
		public override void DeepCopy(vtkDataObject src)
		{
			vtkPointSet.vtkPointSet_DeepCopy_06(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x060030A4 RID: 12452
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSet_EditableOff_07(HandleRef pThis);

		/// <summary>
		/// Specify whether this dataset is editable after creation. Meaning, once
		/// the points and cells are defined, can the dataset be incrementally
		/// modified. By default, this dataset is non-editable (i.e., "static")
		/// after construction. The reason for this is performance: cell links and
		/// locators can be built (and destroyed) much faster is it is known that
		/// the data is static (see vtkStaticCellLinks, vtkStaticPointLocator,
		/// vtkStaticCellLocator).
		/// </summary>
		// Token: 0x060030A5 RID: 12453 RVA: 0x000475AB File Offset: 0x000457AB
		public virtual void EditableOff()
		{
			vtkPointSet.vtkPointSet_EditableOff_07(base.GetCppThis());
		}

		// Token: 0x060030A6 RID: 12454
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSet_EditableOn_08(HandleRef pThis);

		/// <summary>
		/// Specify whether this dataset is editable after creation. Meaning, once
		/// the points and cells are defined, can the dataset be incrementally
		/// modified. By default, this dataset is non-editable (i.e., "static")
		/// after construction. The reason for this is performance: cell links and
		/// locators can be built (and destroyed) much faster is it is known that
		/// the data is static (see vtkStaticCellLinks, vtkStaticPointLocator,
		/// vtkStaticCellLocator).
		/// </summary>
		// Token: 0x060030A7 RID: 12455 RVA: 0x000475BA File Offset: 0x000457BA
		public virtual void EditableOn()
		{
			vtkPointSet.vtkPointSet_EditableOn_08(base.GetCppThis());
		}

		// Token: 0x060030A8 RID: 12456
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSet_ExtendedNew_09(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard instantiation method.
		/// </summary>
		// Token: 0x060030A9 RID: 12457 RVA: 0x000475CC File Offset: 0x000457CC
		public static vtkPointSet ExtendedNew()
		{
			vtkPointSet vtkPointSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSet.vtkPointSet_ExtendedNew_09(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointSet = (vtkPointSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointSet.Register(null);
				}
			}
			return vtkPointSet;
		}

		// Token: 0x060030AA RID: 12458
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSet_FindCell_10(HandleRef pThis, IntPtr x, HandleRef cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// See vtkDataSet for additional information.
		/// </summary>
		// Token: 0x060030AB RID: 12459 RVA: 0x00047638 File Offset: 0x00045838
		public override long FindCell(IntPtr x, vtkCell cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			return vtkPointSet.vtkPointSet_FindCell_10(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights);
		}

		// Token: 0x060030AC RID: 12460
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSet_FindCell_11(HandleRef pThis, IntPtr x, HandleRef cell, HandleRef gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// See vtkDataSet for additional information.
		/// </summary>
		// Token: 0x060030AD RID: 12461 RVA: 0x00047678 File Offset: 0x00045878
		public override long FindCell(IntPtr x, vtkCell cell, vtkGenericCell gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			return vtkPointSet.vtkPointSet_FindCell_11(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), (gencell == null) ? default(HandleRef) : gencell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights);
		}

		// Token: 0x060030AE RID: 12462
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSet_FindPoint_12(HandleRef pThis, IntPtr x);

		/// <summary>
		/// See vtkDataSet for additional information.
		/// </summary>
		// Token: 0x060030AF RID: 12463 RVA: 0x000476CC File Offset: 0x000458CC
		public override long FindPoint(IntPtr x)
		{
			return vtkPointSet.vtkPointSet_FindPoint_12(base.GetCppThis(), x);
		}

		// Token: 0x060030B0 RID: 12464
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSet_FindPoint_13(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// See vtkDataSet for additional information.
		/// </summary>
		// Token: 0x060030B1 RID: 12465 RVA: 0x000476EC File Offset: 0x000458EC
		public new long FindPoint(double x, double y, double z)
		{
			return vtkPointSet.vtkPointSet_FindPoint_13(base.GetCppThis(), x, y, z);
		}

		// Token: 0x060030B2 RID: 12466
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkPointSet_GetActualMemorySize_14(HandleRef pThis);

		/// <summary>
		/// Return the actual size of the data in kibibytes (1024 bytes). This number
		/// is valid only after the pipeline has updated. The memory size
		/// returned is guaranteed to be greater than or equal to the
		/// memory required to represent the data (e.g., extra space in
		/// arrays, etc. are not included in the return value). THIS METHOD
		/// IS THREAD SAFE.
		/// </summary>
		// Token: 0x060030B3 RID: 12467 RVA: 0x00047710 File Offset: 0x00045910
		public override uint GetActualMemorySize()
		{
			return vtkPointSet.vtkPointSet_GetActualMemorySize_14(base.GetCppThis());
		}

		// Token: 0x060030B4 RID: 12468
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSet_GetCell_15(HandleRef pThis, long arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This method always return a `vtkEmptyCell`, as there is no cell in a
		/// `vtkPointSet`.
		/// </summary>
		// Token: 0x060030B5 RID: 12469 RVA: 0x00047730 File Offset: 0x00045930
		public override vtkCell GetCell(long arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSet.vtkPointSet_GetCell_15(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060030B6 RID: 12470
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSet_GetCell_16(HandleRef pThis, long arg0, HandleRef cell);

		/// <summary>
		/// This method sets cell to be an empty cell.
		/// </summary>
		// Token: 0x060030B7 RID: 12471 RVA: 0x000477A0 File Offset: 0x000459A0
		public override void GetCell(long arg0, vtkGenericCell cell)
		{
			vtkPointSet.vtkPointSet_GetCell_16(base.GetCppThis(), arg0, (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x060030B8 RID: 12472
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSet_GetCellLocator_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get an instance of vtkAbstractCellLocator which may be used
		/// when a vtkCellLocatorStrategy is used during a FindCell() operation.
		/// </summary>
		// Token: 0x060030B9 RID: 12473 RVA: 0x000477D0 File Offset: 0x000459D0
		public virtual vtkAbstractCellLocator GetCellLocator()
		{
			vtkAbstractCellLocator vtkAbstractCellLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSet.vtkPointSet_GetCellLocator_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractCellLocator = (vtkAbstractCellLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractCellLocator.Register(null);
				}
			}
			return vtkAbstractCellLocator;
		}

		// Token: 0x060030BA RID: 12474
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSet_GetCellPoints_18(HandleRef pThis, long arg0, HandleRef idList);

		/// <summary>
		/// This method resets parameter idList, as there is no cell in a `vtkPointSet`.
		/// </summary>
		// Token: 0x060030BB RID: 12475 RVA: 0x00047840 File Offset: 0x00045A40
		public override void GetCellPoints(long arg0, vtkIdList idList)
		{
			vtkPointSet.vtkPointSet_GetCellPoints_18(base.GetCppThis(), arg0, (idList == null) ? default(HandleRef) : idList.GetCppThis());
		}

		// Token: 0x060030BC RID: 12476
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSet_GetCellSize_19(HandleRef pThis, long arg0);

		/// <summary>
		/// This method always returns 1, as all cells are point in a pure
		/// `vtkPointSet`.
		/// </summary>
		// Token: 0x060030BD RID: 12477 RVA: 0x00047870 File Offset: 0x00045A70
		public override long GetCellSize(long arg0)
		{
			return vtkPointSet.vtkPointSet_GetCellSize_19(base.GetCppThis(), arg0);
		}

		// Token: 0x060030BE RID: 12478
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSet_GetCellType_20(HandleRef pThis, long arg0);

		/// <summary>
		/// This method always returns `VTK_EMPTY_CELL`, as there is no cell in a
		/// `vtkPointSet`.
		/// </summary>
		// Token: 0x060030BF RID: 12479 RVA: 0x00047890 File Offset: 0x00045A90
		public override int GetCellType(long arg0)
		{
			return vtkPointSet.vtkPointSet_GetCellType_20(base.GetCppThis(), arg0);
		}

		// Token: 0x060030C0 RID: 12480
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSet_GetData_21(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x060030C1 RID: 12481 RVA: 0x000478B0 File Offset: 0x00045AB0
		public new static vtkPointSet GetData(vtkInformation info)
		{
			vtkPointSet vtkPointSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSet.vtkPointSet_GetData_21((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointSet = (vtkPointSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointSet.Register(null);
				}
			}
			return vtkPointSet;
		}

		// Token: 0x060030C2 RID: 12482
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSet_GetData_22(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x060030C3 RID: 12483 RVA: 0x00047930 File Offset: 0x00045B30
		public new static vtkPointSet GetData(vtkInformationVector v, int i)
		{
			vtkPointSet vtkPointSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSet.vtkPointSet_GetData_22((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointSet = (vtkPointSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointSet.Register(null);
				}
			}
			return vtkPointSet;
		}

		// Token: 0x060030C4 RID: 12484
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSet_GetDataObjectType_23(HandleRef pThis);

		/// <summary>
		/// Standard vtkDataSet API methods. See vtkDataSet for more information.
		/// </summary>
		// Token: 0x060030C5 RID: 12485 RVA: 0x000479B0 File Offset: 0x00045BB0
		public override int GetDataObjectType()
		{
			return vtkPointSet.vtkPointSet_GetDataObjectType_23(base.GetCppThis());
		}

		// Token: 0x060030C6 RID: 12486
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointSet_GetEditable_24(HandleRef pThis);

		/// <summary>
		/// Specify whether this dataset is editable after creation. Meaning, once
		/// the points and cells are defined, can the dataset be incrementally
		/// modified. By default, this dataset is non-editable (i.e., "static")
		/// after construction. The reason for this is performance: cell links and
		/// locators can be built (and destroyed) much faster is it is known that
		/// the data is static (see vtkStaticCellLinks, vtkStaticPointLocator,
		/// vtkStaticCellLocator).
		/// </summary>
		// Token: 0x060030C7 RID: 12487 RVA: 0x000479D0 File Offset: 0x00045BD0
		public virtual bool GetEditable()
		{
			return vtkPointSet.vtkPointSet_GetEditable_24(base.GetCppThis()) != 0;
		}

		// Token: 0x060030C8 RID: 12488
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkPointSet_GetMTime_25(HandleRef pThis);

		/// <summary>
		/// Get MTime which also considers its vtkPoints MTime.
		/// </summary>
		// Token: 0x060030C9 RID: 12489 RVA: 0x000479F8 File Offset: 0x00045BF8
		public override ulong GetMTime()
		{
			return vtkPointSet.vtkPointSet_GetMTime_25(base.GetCppThis());
		}

		// Token: 0x060030CA RID: 12490
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSet_GetMaxCellSize_26(HandleRef pThis);

		/// <summary>
		/// This method always returns 0, as there are no cells in a `vtkPointSet`.
		/// </summary>
		// Token: 0x060030CB RID: 12491 RVA: 0x00047A18 File Offset: 0x00045C18
		public override int GetMaxCellSize()
		{
			return vtkPointSet.vtkPointSet_GetMaxCellSize_26(base.GetCppThis());
		}

		// Token: 0x060030CC RID: 12492
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSet_GetNumberOfCells_27(HandleRef pThis);

		/// <summary>
		/// This method always returns 0, as there are no cells in a `vtkPointSet`.
		/// </summary>
		// Token: 0x060030CD RID: 12493 RVA: 0x00047A38 File Offset: 0x00045C38
		public override long GetNumberOfCells()
		{
			return vtkPointSet.vtkPointSet_GetNumberOfCells_27(base.GetCppThis());
		}

		// Token: 0x060030CE RID: 12494
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSet_GetNumberOfGenerationsFromBase_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x060030CF RID: 12495 RVA: 0x00047A58 File Offset: 0x00045C58
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPointSet.vtkPointSet_GetNumberOfGenerationsFromBase_28(base.GetCppThis(), type);
		}

		// Token: 0x060030D0 RID: 12496
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSet_GetNumberOfGenerationsFromBaseType_29([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x060030D1 RID: 12497 RVA: 0x00047A78 File Offset: 0x00045C78
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPointSet.vtkPointSet_GetNumberOfGenerationsFromBaseType_29(type);
		}

		// Token: 0x060030D2 RID: 12498
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointSet_GetNumberOfPoints_30(HandleRef pThis);

		/// <summary>
		/// See vtkDataSet for additional information.
		/// </summary>
		// Token: 0x060030D3 RID: 12499 RVA: 0x00047A94 File Offset: 0x00045C94
		public override long GetNumberOfPoints()
		{
			return vtkPointSet.vtkPointSet_GetNumberOfPoints_30(base.GetCppThis());
		}

		// Token: 0x060030D4 RID: 12500
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSet_GetPoint_31(HandleRef pThis, long ptId, IntPtr x);

		/// <summary>
		/// See vtkDataSet for additional information.
		/// </summary>
		// Token: 0x060030D5 RID: 12501 RVA: 0x00047AB3 File Offset: 0x00045CB3
		public override void GetPoint(long ptId, IntPtr x)
		{
			vtkPointSet.vtkPointSet_GetPoint_31(base.GetCppThis(), ptId, x);
		}

		// Token: 0x060030D6 RID: 12502
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSet_GetPoint_32(HandleRef pThis, long ptId);

		/// <summary>
		/// See vtkDataSet for additional information.
		/// WARNING: Just don't use this error-prone method, the returned pointer
		/// and its values are only valid as long as another method invocation is not
		/// performed. Prefer GetPoint() with the return value in argument.
		/// </summary>
		// Token: 0x060030D7 RID: 12503 RVA: 0x00047AC4 File Offset: 0x00045CC4
		public override double[] GetPoint(long ptId)
		{
			IntPtr intPtr = vtkPointSet.vtkPointSet_GetPoint_32(base.GetCppThis(), ptId);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060030D8 RID: 12504
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSet_GetPointCells_33(HandleRef pThis, long arg0, HandleRef idList);

		/// <summary>
		/// This method resets parameter idList, as there is no cell in a `vtkPointSet`.
		/// </summary>
		// Token: 0x060030D9 RID: 12505 RVA: 0x00047B10 File Offset: 0x00045D10
		public override void GetPointCells(long arg0, vtkIdList idList)
		{
			vtkPointSet.vtkPointSet_GetPointCells_33(base.GetCppThis(), arg0, (idList == null) ? default(HandleRef) : idList.GetCppThis());
		}

		// Token: 0x060030DA RID: 12506
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSet_GetPointLocator_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get an instance of vtkAbstractPointLocator which is used to
		/// support the FindPoint() and FindCell() methods. By default a
		/// vtkStaticPointLocator is used, unless the class is set as Editable, in
		/// which case a vtkPointLocator is used.
		/// </summary>
		// Token: 0x060030DB RID: 12507 RVA: 0x00047B40 File Offset: 0x00045D40
		public virtual vtkAbstractPointLocator GetPointLocator()
		{
			vtkAbstractPointLocator vtkAbstractPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSet.vtkPointSet_GetPointLocator_34(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractPointLocator = (vtkAbstractPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractPointLocator.Register(null);
				}
			}
			return vtkAbstractPointLocator;
		}

		// Token: 0x060030DC RID: 12508
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSet_GetPoints_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify point array to define point coordinates.
		/// </summary>
		// Token: 0x060030DD RID: 12509 RVA: 0x00047BB0 File Offset: 0x00045DB0
		public virtual vtkPoints GetPoints()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSet.vtkPointSet_GetPoints_35(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		// Token: 0x060030DE RID: 12510
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSet_Initialize_36(HandleRef pThis);

		/// <summary>
		/// Reset to an empty state and free any memory.
		/// </summary>
		// Token: 0x060030DF RID: 12511 RVA: 0x00047C1F File Offset: 0x00045E1F
		public override void Initialize()
		{
			vtkPointSet.vtkPointSet_Initialize_36(base.GetCppThis());
		}

		// Token: 0x060030E0 RID: 12512
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSet_IsA_37(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x060030E1 RID: 12513 RVA: 0x00047C30 File Offset: 0x00045E30
		public override int IsA(string type)
		{
			return vtkPointSet.vtkPointSet_IsA_37(base.GetCppThis(), type);
		}

		// Token: 0x060030E2 RID: 12514
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointSet_IsTypeOf_38([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x060030E3 RID: 12515 RVA: 0x00047C50 File Offset: 0x00045E50
		public new static int IsTypeOf(string type)
		{
			return vtkPointSet.vtkPointSet_IsTypeOf_38(type);
		}

		// Token: 0x060030E4 RID: 12516
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSet_NewCellIterator_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return an iterator that traverses the cells in this data set.
		/// </summary>
		// Token: 0x060030E5 RID: 12517 RVA: 0x00047C6C File Offset: 0x00045E6C
		public override vtkCellIterator NewCellIterator()
		{
			vtkCellIterator vtkCellIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSet.vtkPointSet_NewCellIterator_40(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellIterator = (vtkCellIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellIterator.Register(null);
				}
			}
			return vtkCellIterator;
		}

		// Token: 0x060030E6 RID: 12518
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSet_NewInstance_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x060030E7 RID: 12519 RVA: 0x00047CDC File Offset: 0x00045EDC
		public new vtkPointSet NewInstance()
		{
			vtkPointSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSet.vtkPointSet_NewInstance_41(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060030E8 RID: 12520
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointSet_SafeDownCast_42(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x060030E9 RID: 12521 RVA: 0x00047D38 File Offset: 0x00045F38
		public new static vtkPointSet SafeDownCast(vtkObjectBase o)
		{
			vtkPointSet vtkPointSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointSet.vtkPointSet_SafeDownCast_42((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointSet = (vtkPointSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointSet.Register(null);
				}
			}
			return vtkPointSet;
		}

		// Token: 0x060030EA RID: 12522
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSet_SetCellLocator_43(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set / get an instance of vtkAbstractCellLocator which may be used
		/// when a vtkCellLocatorStrategy is used during a FindCell() operation.
		/// </summary>
		// Token: 0x060030EB RID: 12523 RVA: 0x00047DB8 File Offset: 0x00045FB8
		public virtual void SetCellLocator(vtkAbstractCellLocator arg0)
		{
			vtkPointSet.vtkPointSet_SetCellLocator_43(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060030EC RID: 12524
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSet_SetEditable_44(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify whether this dataset is editable after creation. Meaning, once
		/// the points and cells are defined, can the dataset be incrementally
		/// modified. By default, this dataset is non-editable (i.e., "static")
		/// after construction. The reason for this is performance: cell links and
		/// locators can be built (and destroyed) much faster is it is known that
		/// the data is static (see vtkStaticCellLinks, vtkStaticPointLocator,
		/// vtkStaticCellLocator).
		/// </summary>
		// Token: 0x060030ED RID: 12525 RVA: 0x00047DE7 File Offset: 0x00045FE7
		public virtual void SetEditable(bool _arg)
		{
			vtkPointSet.vtkPointSet_SetEditable_44(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060030EE RID: 12526
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSet_SetPointLocator_45(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set / get an instance of vtkAbstractPointLocator which is used to
		/// support the FindPoint() and FindCell() methods. By default a
		/// vtkStaticPointLocator is used, unless the class is set as Editable, in
		/// which case a vtkPointLocator is used.
		/// </summary>
		// Token: 0x060030EF RID: 12527 RVA: 0x00047E00 File Offset: 0x00046000
		public virtual void SetPointLocator(vtkAbstractPointLocator arg0)
		{
			vtkPointSet.vtkPointSet_SetPointLocator_45(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060030F0 RID: 12528
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSet_SetPoints_46(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify point array to define point coordinates.
		/// </summary>
		// Token: 0x060030F1 RID: 12529 RVA: 0x00047E30 File Offset: 0x00046030
		public virtual void SetPoints(vtkPoints arg0)
		{
			vtkPointSet.vtkPointSet_SetPoints_46(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060030F2 RID: 12530
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSet_ShallowCopy_47(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Shallow and Deep copy.
		/// </summary>
		// Token: 0x060030F3 RID: 12531 RVA: 0x00047E60 File Offset: 0x00046060
		public override void ShallowCopy(vtkDataObject src)
		{
			vtkPointSet.vtkPointSet_ShallowCopy_47(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x060030F4 RID: 12532
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointSet_Squeeze_48(HandleRef pThis);

		/// <summary>
		/// Reclaim any unused memory.
		/// </summary>
		// Token: 0x060030F5 RID: 12533 RVA: 0x00047E8F File Offset: 0x0004608F
		public override void Squeeze()
		{
			vtkPointSet.vtkPointSet_Squeeze_48(base.GetCppThis());
		}

		// Token: 0x060030F6 RID: 12534
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPointSet_UsesGarbageCollector_49(HandleRef pThis);

		/// <summary>
		/// Overwritten to handle the data/locator loop
		/// </summary>
		// Token: 0x060030F7 RID: 12535 RVA: 0x00047EA0 File Offset: 0x000460A0
		public override bool UsesGarbageCollector()
		{
			return vtkPointSet.vtkPointSet_UsesGarbageCollector_49(base.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005DB RID: 1499
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointSet";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005DC RID: 1500
		public new static readonly string MRClassNameKey = "class vtkPointSet";
	}
}
