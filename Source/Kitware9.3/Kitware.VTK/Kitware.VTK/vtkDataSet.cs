using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataSet
	/// </summary>
	/// <remarks>
	///    abstract class to specify dataset behavior
	///
	/// vtkDataSet is an abstract class that specifies an interface for dataset
	/// objects. vtkDataSet also provides methods to provide information about
	/// the data, such as center, bounding box, and representative length.
	///
	/// In vtk a dataset consists of a structure (geometry and topology) and
	/// attribute data. The structure is defined implicitly or explicitly as
	/// a collection of cells. The geometry of the structure is contained in
	/// point coordinates plus the cell interpolation functions. The topology
	/// of the dataset structure is defined by cell types and how the cells
	/// share their defining points.
	///
	/// Attribute data in vtk is either point data (data at points) or cell data
	/// (data at cells). Typically filters operate on point data, but some may
	/// operate on cell data, both cell and point data, either one, or none.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPointSet vtkStructuredPoints vtkStructuredGrid vtkUnstructuredGrid
	/// vtkRectilinearGrid vtkPolyData vtkPointData vtkCellData
	/// vtkDataObject vtkFieldData
	/// </seealso>
	// Token: 0x020000E8 RID: 232
	public abstract class vtkDataSet : vtkDataObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003009 RID: 12297 RVA: 0x000464F6 File Offset: 0x000446F6
		static vtkDataSet()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSet"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600300A RID: 12298 RVA: 0x0004651E File Offset: 0x0004471E
		public vtkDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600300B RID: 12299 RVA: 0x0004652C File Offset: 0x0004472C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600300C RID: 12300
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSet_AllocateCellGhostArray_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Allocate ghost array for cells.
		/// </summary>
		// Token: 0x0600300D RID: 12301 RVA: 0x00046538 File Offset: 0x00044738
		public vtkUnsignedCharArray AllocateCellGhostArray()
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSet.vtkDataSet_AllocateCellGhostArray_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		// Token: 0x0600300E RID: 12302
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSet_AllocatePointGhostArray_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Allocate ghost array for points.
		/// </summary>
		// Token: 0x0600300F RID: 12303 RVA: 0x000465A8 File Offset: 0x000447A8
		public vtkUnsignedCharArray AllocatePointGhostArray()
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSet.vtkDataSet_AllocatePointGhostArray_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		// Token: 0x06003010 RID: 12304
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSet_CheckAttributes_03(HandleRef pThis);

		/// <summary>
		/// This method checks to see if the cell and point attributes
		/// match the geometry.  Many filters will crash if the number of
		/// tuples in an array is less than the number of points/cells.
		/// This method returns 1 if there is a mismatch,
		/// and 0 if everything is ok.  It prints an error if an
		/// array is too short, and a warning if an array is too long.
		/// </summary>
		// Token: 0x06003011 RID: 12305 RVA: 0x00046618 File Offset: 0x00044818
		public int CheckAttributes()
		{
			return vtkDataSet.vtkDataSet_CheckAttributes_03(base.GetCppThis());
		}

		// Token: 0x06003012 RID: 12306
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSet_ComputeBounds_04(HandleRef pThis);

		/// <summary>
		/// Compute the data bounding box from data points.
		/// THIS METHOD IS NOT THREAD SAFE.
		/// </summary>
		// Token: 0x06003013 RID: 12307 RVA: 0x00046637 File Offset: 0x00044837
		public virtual void ComputeBounds()
		{
			vtkDataSet.vtkDataSet_ComputeBounds_04(base.GetCppThis());
		}

		// Token: 0x06003014 RID: 12308
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSet_CopyAttributes_05(HandleRef pThis, HandleRef ds);

		/// <summary>
		/// Copy the attributes associated with the specified dataset to this
		/// instance of vtkDataSet.
		/// THIS METHOD IS NOT THREAD SAFE.
		/// </summary>
		// Token: 0x06003015 RID: 12309 RVA: 0x00046648 File Offset: 0x00044848
		public virtual void CopyAttributes(vtkDataSet ds)
		{
			vtkDataSet.vtkDataSet_CopyAttributes_05(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		// Token: 0x06003016 RID: 12310
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSet_CopyStructure_06(HandleRef pThis, HandleRef ds);

		/// <summary>
		/// Copy the geometric and topological structure of an object. Note that
		/// the invoking object and the object pointed to by the parameter ds must
		/// be of the same type.
		/// THIS METHOD IS NOT THREAD SAFE.
		/// </summary>
		// Token: 0x06003017 RID: 12311 RVA: 0x00046678 File Offset: 0x00044878
		public virtual void CopyStructure(vtkDataSet ds)
		{
			vtkDataSet.vtkDataSet_CopyStructure_06(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		// Token: 0x06003018 RID: 12312
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSet_DeepCopy_07(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Shallow and Deep copy.
		/// </summary>
		// Token: 0x06003019 RID: 12313 RVA: 0x000466A8 File Offset: 0x000448A8
		public override void DeepCopy(vtkDataObject src)
		{
			vtkDataSet.vtkDataSet_DeepCopy_07(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0600301A RID: 12314
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSet_FindAndGetCell_08(HandleRef pThis, IntPtr x, HandleRef cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Locate the cell that contains a point and return the cell. Also returns
		/// the subcell id, parametric coordinates and weights for subsequent
		/// interpolation. This method combines the derived class methods
		/// int FindCell and vtkCell *GetCell. Derived classes may provide a more
		/// efficient implementation. See for example vtkStructuredPoints.
		/// THIS METHOD IS NOT THREAD SAFE.
		/// </summary>
		// Token: 0x0600301B RID: 12315 RVA: 0x000466D8 File Offset: 0x000448D8
		public virtual vtkCell FindAndGetCell(IntPtr x, vtkCell cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSet.vtkDataSet_FindAndGetCell_08(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600301C RID: 12316
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSet_FindCell_09(HandleRef pThis, IntPtr x, HandleRef cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Locate cell based on global coordinate x and tolerance
		/// squared. If cell and cellId is non-nullptr, then search starts from
		/// this cell and looks at immediate neighbors.  Returns cellId &gt;= 0
		/// if inside, &lt; 0 otherwise.  The parametric coordinates are
		/// provided in pcoords[3]. The interpolation weights are returned in
		/// weights[]. (The number of weights is equal to the number of
		/// points in the found cell). Tolerance is used to control how close
		/// the point is to be considered "in" the cell.
		/// THIS METHOD IS NOT THREAD SAFE.
		/// </summary>
		// Token: 0x0600301D RID: 12317 RVA: 0x00046768 File Offset: 0x00044968
		public virtual long FindCell(IntPtr x, vtkCell cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			return vtkDataSet.vtkDataSet_FindCell_09(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights);
		}

		// Token: 0x0600301E RID: 12318
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSet_FindCell_10(HandleRef pThis, IntPtr x, HandleRef cell, HandleRef gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// This is a version of the above method that can be used with
		/// multithreaded applications. A vtkGenericCell must be passed in
		/// to be used in internal calls that might be made to GetCell()
		/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
		/// THE DATASET IS NOT MODIFIED
		/// </summary>
		// Token: 0x0600301F RID: 12319 RVA: 0x000467A8 File Offset: 0x000449A8
		public virtual long FindCell(IntPtr x, vtkCell cell, vtkGenericCell gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			return vtkDataSet.vtkDataSet_FindCell_10(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), (gencell == null) ? default(HandleRef) : gencell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights);
		}

		// Token: 0x06003020 RID: 12320
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSet_FindPoint_11(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Locate the closest point to the global coordinate x. Return the
		/// point id. If point id &lt; 0; then no point found. (This may arise
		/// when point is outside of dataset.)
		/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
		/// THE DATASET IS NOT MODIFIED
		/// </summary>
		// Token: 0x06003021 RID: 12321 RVA: 0x000467FC File Offset: 0x000449FC
		public long FindPoint(double x, double y, double z)
		{
			return vtkDataSet.vtkDataSet_FindPoint_11(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06003022 RID: 12322
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSet_FindPoint_12(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Locate the closest point to the global coordinate x. Return the
		/// point id. If point id &lt; 0; then no point found. (This may arise
		/// when point is outside of dataset.)
		/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
		/// THE DATASET IS NOT MODIFIED
		/// </summary>
		// Token: 0x06003023 RID: 12323 RVA: 0x00046820 File Offset: 0x00044A20
		public virtual long FindPoint(IntPtr x)
		{
			return vtkDataSet.vtkDataSet_FindPoint_12(base.GetCppThis(), x);
		}

		// Token: 0x06003024 RID: 12324
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSet_GenerateGhostArray_13(HandleRef pThis, IntPtr zeroExt);

		/// <summary>
		/// Normally called by pipeline executives or algorithms only. This method
		/// computes the ghost arrays for a given dataset. The zeroExt argument
		/// specifies the extent of the region which ghost type = 0.
		/// </summary>
		// Token: 0x06003025 RID: 12325 RVA: 0x00046840 File Offset: 0x00044A40
		public virtual void GenerateGhostArray(IntPtr zeroExt)
		{
			vtkDataSet.vtkDataSet_GenerateGhostArray_13(base.GetCppThis(), zeroExt);
		}

		// Token: 0x06003026 RID: 12326
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSet_GenerateGhostArray_14(HandleRef pThis, IntPtr zeroExt, byte cellOnly);

		/// <summary>
		/// Normally called by pipeline executives or algorithms only. This method
		/// computes the ghost arrays for a given dataset. The zeroExt argument
		/// specifies the extent of the region which ghost type = 0.
		/// </summary>
		// Token: 0x06003027 RID: 12327 RVA: 0x00046850 File Offset: 0x00044A50
		public virtual void GenerateGhostArray(IntPtr zeroExt, bool cellOnly)
		{
			vtkDataSet.vtkDataSet_GenerateGhostArray_14(base.GetCppThis(), zeroExt, cellOnly ? (byte)1 : (byte)0);
		}

		// Token: 0x06003028 RID: 12328
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkDataSet_GetActualMemorySize_15(HandleRef pThis);

		/// <summary>
		/// Return the actual size of the data in kibibytes (1024 bytes). This number
		/// is valid only after the pipeline has updated. The memory size
		/// returned is guaranteed to be greater than or equal to the
		/// memory required to represent the data (e.g., extra space in
		/// arrays, etc. are not included in the return value). THIS METHOD
		/// IS THREAD SAFE.
		/// </summary>
		// Token: 0x06003029 RID: 12329 RVA: 0x0004686C File Offset: 0x00044A6C
		public override uint GetActualMemorySize()
		{
			return vtkDataSet.vtkDataSet_GetActualMemorySize_15(base.GetCppThis());
		}

		// Token: 0x0600302A RID: 12330
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSet_GetAttributesAsFieldData_16(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the attributes of the data object as a vtkFieldData.
		/// This returns non-null values in all the same cases as GetAttributes,
		/// in addition to the case of FIELD, which will return the field data
		/// for any vtkDataObject subclass.
		/// </summary>
		// Token: 0x0600302B RID: 12331 RVA: 0x0004688C File Offset: 0x00044A8C
		public override vtkFieldData GetAttributesAsFieldData(int type)
		{
			vtkFieldData vtkFieldData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSet.vtkDataSet_GetAttributesAsFieldData_16(base.GetCppThis(), type, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFieldData = (vtkFieldData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFieldData.Register(null);
				}
			}
			return vtkFieldData;
		}

		// Token: 0x0600302C RID: 12332
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSet_GetBounds_17(HandleRef pThis);

		/// <summary>
		/// Return a pointer to the geometry bounding box in the form
		/// (xmin,xmax, ymin,ymax, zmin,zmax).
		/// THIS METHOD IS NOT THREAD SAFE.
		/// </summary>
		// Token: 0x0600302D RID: 12333 RVA: 0x000468FC File Offset: 0x00044AFC
		public double[] GetBounds()
		{
			IntPtr intPtr = vtkDataSet.vtkDataSet_GetBounds_17(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600302E RID: 12334
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSet_GetBounds_18(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Return a pointer to the geometry bounding box in the form
		/// (xmin,xmax, ymin,ymax, zmin,zmax).
		/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
		/// THE DATASET IS NOT MODIFIED
		/// </summary>
		// Token: 0x0600302F RID: 12335 RVA: 0x00046944 File Offset: 0x00044B44
		public void GetBounds(IntPtr bounds)
		{
			vtkDataSet.vtkDataSet_GetBounds_18(base.GetCppThis(), bounds);
		}

		// Token: 0x06003030 RID: 12336
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSet_GetCell_19(HandleRef pThis, long cellId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get cell with cellId such that: 0 &lt;= cellId &lt; NumberOfCells. The returned
		/// vtkCell is an object owned by this instance, hence the return value must not
		/// be deleted by the caller.
		///
		/// @warning Repeat calls to this function for different face ids will change
		/// the data stored in the internal member object whose pointer is returned by
		/// this function.
		///
		/// @warning THIS METHOD IS NOT THREAD SAFE. For a thread-safe version, please use
		/// void GetCell(vtkIdType cellId, vtkGenericCell* cell).
		/// </summary>
		// Token: 0x06003031 RID: 12337 RVA: 0x00046954 File Offset: 0x00044B54
		public virtual vtkCell GetCell(long cellId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSet.vtkDataSet_GetCell_19(base.GetCppThis(), cellId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06003032 RID: 12338
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSet_GetCell_20(HandleRef pThis, int arg0, int arg1, int arg2, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get cell with cellId such that: 0 &lt;= cellId &lt; NumberOfCells. The returned
		/// vtkCell is an object owned by this instance, hence the return value must not
		/// be deleted by the caller.
		///
		/// @warning Repeat calls to this function for different face ids will change
		/// the data stored in the internal member object whose pointer is returned by
		/// this function.
		///
		/// @warning THIS METHOD IS NOT THREAD SAFE. For a thread-safe version, please use
		/// void GetCell(vtkIdType cellId, vtkGenericCell* cell).
		/// </summary>
		// Token: 0x06003033 RID: 12339 RVA: 0x000469C4 File Offset: 0x00044BC4
		public virtual vtkCell GetCell(int arg0, int arg1, int arg2)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSet.vtkDataSet_GetCell_20(base.GetCppThis(), arg0, arg1, arg2, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06003034 RID: 12340
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSet_GetCell_21(HandleRef pThis, long cellId, HandleRef cell);

		/// <summary>
		/// Get cell with cellId such that: 0 &lt;= cellId &lt; NumberOfCells.
		/// This is a thread-safe alternative to the previous GetCell()
		/// method.
		/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
		/// THE DATASET IS NOT MODIFIED
		/// </summary>
		// Token: 0x06003035 RID: 12341 RVA: 0x00046A38 File Offset: 0x00044C38
		public virtual void GetCell(long cellId, vtkGenericCell cell)
		{
			vtkDataSet.vtkDataSet_GetCell_21(base.GetCppThis(), cellId, (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06003036 RID: 12342
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSet_GetCellBounds_22(HandleRef pThis, long cellId, IntPtr bounds);

		/// <summary>
		/// Get the bounds of the cell with cellId such that:
		/// 0 &lt;= cellId &lt; NumberOfCells.
		/// A subclass may be able to determine the bounds of cell without using
		/// an expensive GetCell() method. A default implementation is provided
		/// that actually uses a GetCell() call.  This is to ensure the method
		/// is available to all datasets.  Subclasses should override this method
		/// to provide an efficient implementation.
		/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
		/// THE DATASET IS NOT MODIFIED
		/// </summary>
		// Token: 0x06003037 RID: 12343 RVA: 0x00046A68 File Offset: 0x00044C68
		public virtual void GetCellBounds(long cellId, IntPtr bounds)
		{
			vtkDataSet.vtkDataSet_GetCellBounds_22(base.GetCppThis(), cellId, bounds);
		}

		// Token: 0x06003038 RID: 12344
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSet_GetCellData_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return a pointer to this dataset's cell data.
		/// THIS METHOD IS THREAD SAFE
		/// </summary>
		// Token: 0x06003039 RID: 12345 RVA: 0x00046A7C File Offset: 0x00044C7C
		public vtkCellData GetCellData()
		{
			vtkCellData vtkCellData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSet.vtkDataSet_GetCellData_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellData = (vtkCellData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellData.Register(null);
				}
			}
			return vtkCellData;
		}

		// Token: 0x0600303A RID: 12346
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSet_GetCellGhostArray_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the array that defines the ghost type of each cell.
		/// We cache the pointer to the array to save a lookup involving string comparisons
		/// </summary>
		// Token: 0x0600303B RID: 12347 RVA: 0x00046AEC File Offset: 0x00044CEC
		public vtkUnsignedCharArray GetCellGhostArray()
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSet.vtkDataSet_GetCellGhostArray_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		// Token: 0x0600303C RID: 12348
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSet_GetCellNeighbors_25(HandleRef pThis, long cellId, HandleRef ptIds, HandleRef cellIds);

		/// <summary>
		/// Topological inquiry to get all cells using list of points exclusive of
		/// cell specified (e.g., cellId). Note that the list consists of only
		/// cells that use ALL the points provided.
		/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
		/// THE DATASET IS NOT MODIFIED
		/// </summary>
		// Token: 0x0600303D RID: 12349 RVA: 0x00046B5C File Offset: 0x00044D5C
		public virtual void GetCellNeighbors(long cellId, vtkIdList ptIds, vtkIdList cellIds)
		{
			vtkDataSet.vtkDataSet_GetCellNeighbors_25(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		// Token: 0x0600303E RID: 12350
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSet_GetCellNumberOfFaces_26(HandleRef pThis, long cellId, ref byte cellType, HandleRef cell);

		/// <summary>
		/// Get the number of faces of a cell.
		///
		/// Most of the times extracting the number of faces requires only extracting
		/// the cell type. However, for some cell types, the number of faces is not
		/// constant. For example, a vtkPolyhedron cell can have a different number of
		/// faces for each cell. That's why this method requires the cell id and the
		/// dataset.
		/// </summary>
		// Token: 0x0600303F RID: 12351 RVA: 0x00046BA4 File Offset: 0x00044DA4
		public int GetCellNumberOfFaces(long cellId, ref byte cellType, vtkGenericCell cell)
		{
			return vtkDataSet.vtkDataSet_GetCellNumberOfFaces_26(base.GetCppThis(), cellId, ref cellType, (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06003040 RID: 12352
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSet_GetCellPoints_27(HandleRef pThis, long cellId, HandleRef ptIds);

		/// <summary>
		/// Topological inquiry to get points defining cell.
		/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
		/// THE DATASET IS NOT MODIFIED
		/// </summary>
		// Token: 0x06003041 RID: 12353 RVA: 0x00046BDC File Offset: 0x00044DDC
		public virtual void GetCellPoints(long cellId, vtkIdList ptIds)
		{
			vtkDataSet.vtkDataSet_GetCellPoints_27(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		// Token: 0x06003042 RID: 12354
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSet_GetCellSize_28(HandleRef pThis, long cellId);

		/// <summary>
		/// Get the size of cell with cellId such that: 0 &lt;= cellId &lt; NumberOfCells.
		/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
		/// THE DATASET IS NOT MODIFIED
		///
		/// @warning This method MUST be overridden for performance reasons.
		/// Default implementation is very inefficient.
		/// </summary>
		// Token: 0x06003043 RID: 12355 RVA: 0x00046C0C File Offset: 0x00044E0C
		public virtual long GetCellSize(long cellId)
		{
			return vtkDataSet.vtkDataSet_GetCellSize_28(base.GetCppThis(), cellId);
		}

		// Token: 0x06003044 RID: 12356
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSet_GetCellType_29(HandleRef pThis, long cellId);

		/// <summary>
		/// Get type of cell with cellId such that: 0 &lt;= cellId &lt; NumberOfCells.
		/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
		/// THE DATASET IS NOT MODIFIED
		/// </summary>
		// Token: 0x06003045 RID: 12357 RVA: 0x00046C2C File Offset: 0x00044E2C
		public virtual int GetCellType(long cellId)
		{
			return vtkDataSet.vtkDataSet_GetCellType_29(base.GetCppThis(), cellId);
		}

		// Token: 0x06003046 RID: 12358
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSet_GetCellTypes_30(HandleRef pThis, HandleRef types);

		/// <summary>
		/// Get a list of types of cells in a dataset. The list consists of an array
		/// of types (not necessarily in any order), with a single entry per type.
		/// For example a dataset 5 triangles, 3 lines, and 100 hexahedra would
		/// result a list of three entries, corresponding to the types VTK_TRIANGLE,
		/// VTK_LINE, and VTK_HEXAHEDRON.
		/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
		/// THE DATASET IS NOT MODIFIED
		/// </summary>
		// Token: 0x06003047 RID: 12359 RVA: 0x00046C4C File Offset: 0x00044E4C
		public virtual void GetCellTypes(vtkCellTypes types)
		{
			vtkDataSet.vtkDataSet_GetCellTypes_30(base.GetCppThis(), (types == null) ? default(HandleRef) : types.GetCppThis());
		}

		// Token: 0x06003048 RID: 12360
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSet_GetCenter_31(HandleRef pThis);

		/// <summary>
		/// Get the center of the bounding box.
		/// THIS METHOD IS NOT THREAD SAFE.
		/// </summary>
		// Token: 0x06003049 RID: 12361 RVA: 0x00046C7C File Offset: 0x00044E7C
		public double[] GetCenter()
		{
			IntPtr intPtr = vtkDataSet.vtkDataSet_GetCenter_31(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600304A RID: 12362
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSet_GetCenter_32(HandleRef pThis, IntPtr center);

		/// <summary>
		/// Get the center of the bounding box.
		/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
		/// THE DATASET IS NOT MODIFIED
		/// </summary>
		// Token: 0x0600304B RID: 12363 RVA: 0x00046CC4 File Offset: 0x00044EC4
		public void GetCenter(IntPtr center)
		{
			vtkDataSet.vtkDataSet_GetCenter_32(base.GetCppThis(), center);
		}

		// Token: 0x0600304C RID: 12364
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSet_GetData_33(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0600304D RID: 12365 RVA: 0x00046CD4 File Offset: 0x00044ED4
		public new static vtkDataSet GetData(vtkInformation info)
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSet.vtkDataSet_GetData_33((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x0600304E RID: 12366
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSet_GetData_34(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0600304F RID: 12367 RVA: 0x00046D54 File Offset: 0x00044F54
		public new static vtkDataSet GetData(vtkInformationVector v, int i)
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSet.vtkDataSet_GetData_34((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x06003050 RID: 12368
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSet_GetDataObjectType_35(HandleRef pThis);

		/// <summary>
		/// Return the type of data object.
		/// </summary>
		// Token: 0x06003051 RID: 12369 RVA: 0x00046DD4 File Offset: 0x00044FD4
		public override int GetDataObjectType()
		{
			return vtkDataSet.vtkDataSet_GetDataObjectType_35(base.GetCppThis());
		}

		// Token: 0x06003052 RID: 12370
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSet_GetGhostArray_36(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the ghost array for the given type (point or cell).
		/// Takes advantage of the cache with the pointer to the array to save a string
		/// comparison.
		/// </summary>
		// Token: 0x06003053 RID: 12371 RVA: 0x00046DF4 File Offset: 0x00044FF4
		public override vtkUnsignedCharArray GetGhostArray(int type)
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSet.vtkDataSet_GetGhostArray_36(base.GetCppThis(), type, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		// Token: 0x06003054 RID: 12372
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDataSet_GetLength_37(HandleRef pThis);

		/// <summary>
		/// Return the length of the diagonal of the bounding box.
		/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
		/// THE DATASET IS NOT MODIFIED
		/// </summary>
		// Token: 0x06003055 RID: 12373 RVA: 0x00046E64 File Offset: 0x00045064
		public double GetLength()
		{
			return vtkDataSet.vtkDataSet_GetLength_37(base.GetCppThis());
		}

		// Token: 0x06003056 RID: 12374
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDataSet_GetLength2_38(HandleRef pThis);

		/// <summary>
		/// Return the squared length of the diagonal of the bounding box.
		/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
		/// THE DATASET IS NOT MODIFIED
		/// </summary>
		// Token: 0x06003057 RID: 12375 RVA: 0x00046E84 File Offset: 0x00045084
		public double GetLength2()
		{
			return vtkDataSet.vtkDataSet_GetLength2_38(base.GetCppThis());
		}

		// Token: 0x06003058 RID: 12376
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkDataSet_GetMTime_39(HandleRef pThis);

		/// <summary>
		/// Datasets are composite objects and need to check each part for MTime
		/// THIS METHOD IS THREAD SAFE
		/// </summary>
		// Token: 0x06003059 RID: 12377 RVA: 0x00046EA4 File Offset: 0x000450A4
		public override ulong GetMTime()
		{
			return vtkDataSet.vtkDataSet_GetMTime_39(base.GetCppThis());
		}

		// Token: 0x0600305A RID: 12378
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSet_GetMaxCellSize_40(HandleRef pThis);

		/// <summary>
		/// Convenience method returns largest cell size in dataset. This is generally
		/// used to allocate memory for supporting data structures.
		/// THIS METHOD IS THREAD SAFE
		/// </summary>
		// Token: 0x0600305B RID: 12379 RVA: 0x00046EC4 File Offset: 0x000450C4
		public virtual int GetMaxCellSize()
		{
			return vtkDataSet.vtkDataSet_GetMaxCellSize_40(base.GetCppThis());
		}

		// Token: 0x0600305C RID: 12380
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSet_GetMaxSpatialDimension_41(HandleRef pThis);

		/// <summary>
		/// Get the maximum spatial dimensionality of the data
		/// which is the maximum dimension of all cells.
		///
		/// @warning This method MUST be overridden for performance reasons.
		/// Default implementation is very inefficient.
		/// </summary>
		// Token: 0x0600305D RID: 12381 RVA: 0x00046EE4 File Offset: 0x000450E4
		public virtual int GetMaxSpatialDimension()
		{
			return vtkDataSet.vtkDataSet_GetMaxSpatialDimension_41(base.GetCppThis());
		}

		// Token: 0x0600305E RID: 12382
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSet_GetNumberOfCells_42(HandleRef pThis);

		/// <summary>
		/// Determine the number of cells composing the dataset.
		/// THIS METHOD IS THREAD SAFE
		/// </summary>
		// Token: 0x0600305F RID: 12383 RVA: 0x00046F04 File Offset: 0x00045104
		public virtual long GetNumberOfCells()
		{
			return vtkDataSet.vtkDataSet_GetNumberOfCells_42(base.GetCppThis());
		}

		// Token: 0x06003060 RID: 12384
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSet_GetNumberOfElements_43(HandleRef pThis, int type);

		/// <summary>
		/// Get the number of elements for a specific attribute type (POINT, CELL, etc.).
		/// </summary>
		// Token: 0x06003061 RID: 12385 RVA: 0x00046F24 File Offset: 0x00045124
		public override long GetNumberOfElements(int type)
		{
			return vtkDataSet.vtkDataSet_GetNumberOfElements_43(base.GetCppThis(), type);
		}

		// Token: 0x06003062 RID: 12386
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSet_GetNumberOfGenerationsFromBase_44(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003063 RID: 12387 RVA: 0x00046F44 File Offset: 0x00045144
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataSet.vtkDataSet_GetNumberOfGenerationsFromBase_44(base.GetCppThis(), type);
		}

		// Token: 0x06003064 RID: 12388
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSet_GetNumberOfGenerationsFromBaseType_45([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003065 RID: 12389 RVA: 0x00046F64 File Offset: 0x00045164
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataSet.vtkDataSet_GetNumberOfGenerationsFromBaseType_45(type);
		}

		// Token: 0x06003066 RID: 12390
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSet_GetNumberOfPoints_46(HandleRef pThis);

		/// <summary>
		/// Determine the number of points composing the dataset.
		/// THIS METHOD IS THREAD SAFE
		/// </summary>
		// Token: 0x06003067 RID: 12391 RVA: 0x00046F80 File Offset: 0x00045180
		public virtual long GetNumberOfPoints()
		{
			return vtkDataSet.vtkDataSet_GetNumberOfPoints_46(base.GetCppThis());
		}

		// Token: 0x06003068 RID: 12392
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSet_GetPoint_47(HandleRef pThis, long ptId);

		/// <summary>
		/// Get point coordinates with ptId such that: 0 &lt;= ptId &lt; NumberOfPoints.
		/// THIS METHOD IS NOT THREAD SAFE.
		/// </summary>
		// Token: 0x06003069 RID: 12393 RVA: 0x00046FA0 File Offset: 0x000451A0
		public virtual double[] GetPoint(long ptId)
		{
			IntPtr intPtr = vtkDataSet.vtkDataSet_GetPoint_47(base.GetCppThis(), ptId);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600306A RID: 12394
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSet_GetPoint_48(HandleRef pThis, long id, IntPtr x);

		/// <summary>
		/// Copy point coordinates into user provided array x[3] for specified
		/// point id.
		/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
		/// THE DATASET IS NOT MODIFIED
		/// </summary>
		// Token: 0x0600306B RID: 12395 RVA: 0x00046FE9 File Offset: 0x000451E9
		public virtual void GetPoint(long id, IntPtr x)
		{
			vtkDataSet.vtkDataSet_GetPoint_48(base.GetCppThis(), id, x);
		}

		// Token: 0x0600306C RID: 12396
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSet_GetPointCells_49(HandleRef pThis, long ptId, HandleRef cellIds);

		/// <summary>
		/// Topological inquiry to get cells using point.
		/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
		/// THE DATASET IS NOT MODIFIED
		/// </summary>
		// Token: 0x0600306D RID: 12397 RVA: 0x00046FFC File Offset: 0x000451FC
		public virtual void GetPointCells(long ptId, vtkIdList cellIds)
		{
			vtkDataSet.vtkDataSet_GetPointCells_49(base.GetCppThis(), ptId, (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		// Token: 0x0600306E RID: 12398
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSet_GetPointData_50(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return a pointer to this dataset's point data.
		/// THIS METHOD IS THREAD SAFE
		/// </summary>
		// Token: 0x0600306F RID: 12399 RVA: 0x0004702C File Offset: 0x0004522C
		public vtkPointData GetPointData()
		{
			vtkPointData vtkPointData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSet.vtkDataSet_GetPointData_50(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointData = (vtkPointData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointData.Register(null);
				}
			}
			return vtkPointData;
		}

		// Token: 0x06003070 RID: 12400
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSet_GetPointGhostArray_51(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Gets the array that defines the ghost type of each point.
		/// We cache the pointer to the array to save a lookup involving string comparisons
		/// </summary>
		// Token: 0x06003071 RID: 12401 RVA: 0x0004709C File Offset: 0x0004529C
		public vtkUnsignedCharArray GetPointGhostArray()
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSet.vtkDataSet_GetPointGhostArray_51(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		// Token: 0x06003072 RID: 12402
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSet_GetScalarRange_52(HandleRef pThis, IntPtr range);

		/// <summary>
		/// Convenience method to get the range of the first component (and only
		/// the first component) of any scalars in the data set.  If the data has
		/// both point data and cell data, it returns the (min/max) range of
		/// combined point and cell data.  If there are no point or cell scalars
		/// the method will return (0,1).  Note: It might be necessary to call
		/// Update to create or refresh the scalars before calling this method.
		/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
		/// THE DATASET IS NOT MODIFIED
		/// </summary>
		// Token: 0x06003073 RID: 12403 RVA: 0x0004710B File Offset: 0x0004530B
		public virtual void GetScalarRange(IntPtr range)
		{
			vtkDataSet.vtkDataSet_GetScalarRange_52(base.GetCppThis(), range);
		}

		// Token: 0x06003074 RID: 12404
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSet_GetScalarRange_53(HandleRef pThis);

		/// <summary>
		/// Convenience method to get the range of the first component (and only
		/// the first component) of any scalars in the data set.  If the data has
		/// both point data and cell data, it returns the (min/max) range of
		/// combined point and cell data.  If there are no point or cell scalars
		/// the method will return (0,1).  Note: It might be necessary to call
		/// Update to create or refresh the scalars before calling this method.
		/// THIS METHOD IS NOT THREAD SAFE.
		/// </summary>
		// Token: 0x06003075 RID: 12405 RVA: 0x0004711C File Offset: 0x0004531C
		public double[] GetScalarRange()
		{
			IntPtr intPtr = vtkDataSet.vtkDataSet_GetScalarRange_53(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06003076 RID: 12406
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataSet_HasAnyBlankCells_54(HandleRef pThis);

		/// <summary>
		/// Returns 1 if there are any blanking cells
		/// 0 otherwise. Blanking is supported only for vtkStructuredGrid
		/// and vtkUniformGrid
		/// </summary>
		// Token: 0x06003077 RID: 12407 RVA: 0x00047164 File Offset: 0x00045364
		public virtual bool HasAnyBlankCells()
		{
			return vtkDataSet.vtkDataSet_HasAnyBlankCells_54(base.GetCppThis()) != 0;
		}

		// Token: 0x06003078 RID: 12408
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataSet_HasAnyBlankPoints_55(HandleRef pThis);

		/// <summary>
		/// Returns 1 if there are any blanking points
		/// 0 otherwise. Blanking is supported only for vtkStructuredGrid
		/// and vtkUniformGrid
		/// </summary>
		// Token: 0x06003079 RID: 12409 RVA: 0x0004718C File Offset: 0x0004538C
		public virtual bool HasAnyBlankPoints()
		{
			return vtkDataSet.vtkDataSet_HasAnyBlankPoints_55(base.GetCppThis()) != 0;
		}

		// Token: 0x0600307A RID: 12410
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataSet_HasAnyGhostCells_56(HandleRef pThis);

		/// <summary>
		/// Returns 1 if there are any ghost cells
		/// 0 otherwise.
		/// </summary>
		// Token: 0x0600307B RID: 12411 RVA: 0x000471B4 File Offset: 0x000453B4
		public bool HasAnyGhostCells()
		{
			return vtkDataSet.vtkDataSet_HasAnyGhostCells_56(base.GetCppThis()) != 0;
		}

		// Token: 0x0600307C RID: 12412
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataSet_HasAnyGhostPoints_57(HandleRef pThis);

		/// <summary>
		/// Returns 1 if there are any ghost points
		/// 0 otherwise.
		/// </summary>
		// Token: 0x0600307D RID: 12413 RVA: 0x000471DC File Offset: 0x000453DC
		public bool HasAnyGhostPoints()
		{
			return vtkDataSet.vtkDataSet_HasAnyGhostPoints_57(base.GetCppThis()) != 0;
		}

		// Token: 0x0600307E RID: 12414
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSet_Initialize_58(HandleRef pThis);

		/// <summary>
		/// Restore data object to initial state.
		/// THIS METHOD IS NOT THREAD SAFE.
		/// </summary>
		// Token: 0x0600307F RID: 12415 RVA: 0x00047202 File Offset: 0x00045402
		public override void Initialize()
		{
			vtkDataSet.vtkDataSet_Initialize_58(base.GetCppThis());
		}

		// Token: 0x06003080 RID: 12416
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSet_IsA_59(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003081 RID: 12417 RVA: 0x00047214 File Offset: 0x00045414
		public override int IsA(string type)
		{
			return vtkDataSet.vtkDataSet_IsA_59(base.GetCppThis(), type);
		}

		// Token: 0x06003082 RID: 12418
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSet_IsTypeOf_60([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003083 RID: 12419 RVA: 0x00047234 File Offset: 0x00045434
		public new static int IsTypeOf(string type)
		{
			return vtkDataSet.vtkDataSet_IsTypeOf_60(type);
		}

		// Token: 0x06003084 RID: 12420
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSet_NewCellIterator_61(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return an iterator that traverses the cells in this data set.
		/// </summary>
		// Token: 0x06003085 RID: 12421 RVA: 0x00047250 File Offset: 0x00045450
		public virtual vtkCellIterator NewCellIterator()
		{
			vtkCellIterator vtkCellIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSet.vtkDataSet_NewCellIterator_61(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06003086 RID: 12422
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSet_NewInstance_62(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003087 RID: 12423 RVA: 0x000472C0 File Offset: 0x000454C0
		public new vtkDataSet NewInstance()
		{
			vtkDataSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSet.vtkDataSet_NewInstance_62(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003088 RID: 12424
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSet_SafeDownCast_63(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003089 RID: 12425 RVA: 0x0004731C File Offset: 0x0004551C
		public new static vtkDataSet SafeDownCast(vtkObjectBase o)
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSet.vtkDataSet_SafeDownCast_63((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x0600308A RID: 12426
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSet_SetCellOrderAndRationalWeights_64(HandleRef pThis, long cellId, HandleRef cell);

		/// <summary>
		/// Get cell with cellId such that: 0 &lt;= cellId &lt; NumberOfCells. The returned
		/// vtkCell is an object owned by this instance, hence the return value must not
		/// be deleted by the caller.
		///
		/// @warning Repeat calls to this function for different face ids will change
		/// the data stored in the internal member object whose pointer is returned by
		/// this function.
		///
		/// @warning THIS METHOD IS NOT THREAD SAFE. For a thread-safe version, please use
		/// void GetCell(vtkIdType cellId, vtkGenericCell* cell).
		/// </summary>
		// Token: 0x0600308B RID: 12427 RVA: 0x0004739C File Offset: 0x0004559C
		public void SetCellOrderAndRationalWeights(long cellId, vtkGenericCell cell)
		{
			vtkDataSet.vtkDataSet_SetCellOrderAndRationalWeights_64(base.GetCppThis(), cellId, (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x0600308C RID: 12428
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSet_ShallowCopy_65(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Shallow and Deep copy.
		/// </summary>
		// Token: 0x0600308D RID: 12429 RVA: 0x000473CC File Offset: 0x000455CC
		public override void ShallowCopy(vtkDataObject src)
		{
			vtkDataSet.vtkDataSet_ShallowCopy_65(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0600308E RID: 12430
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSet_Squeeze_66(HandleRef pThis);

		/// <summary>
		/// Reclaim any extra memory used to store data.
		/// THIS METHOD IS NOT THREAD SAFE.
		/// </summary>
		// Token: 0x0600308F RID: 12431 RVA: 0x000473FB File Offset: 0x000455FB
		public virtual void Squeeze()
		{
			vtkDataSet.vtkDataSet_Squeeze_66(base.GetCppThis());
		}

		// Token: 0x06003090 RID: 12432
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataSet_SupportsGhostArray_67(HandleRef pThis, int type);

		/// <summary>
		/// Returns true for POINT or CELL, false otherwise
		/// </summary>
		// Token: 0x06003091 RID: 12433 RVA: 0x0004740C File Offset: 0x0004560C
		public override bool SupportsGhostArray(int type)
		{
			return vtkDataSet.vtkDataSet_SupportsGhostArray_67(base.GetCppThis(), type) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005D5 RID: 1493
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataSet";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005D6 RID: 1494
		public new static readonly string MRClassNameKey = "class vtkDataSet";

		/// <summary>
		/// Shallow and Deep copy.
		/// </summary>
		// Token: 0x020000E9 RID: 233
		public enum FieldDataType
		{
			/// <summary>enum member</summary>
			// Token: 0x040005D8 RID: 1496
			CELL_DATA_FIELD = 2,
			/// <summary>enum member</summary>
			// Token: 0x040005D9 RID: 1497
			DATA_OBJECT_FIELD = 0,
			/// <summary>enum member</summary>
			// Token: 0x040005DA RID: 1498
			POINT_DATA_FIELD
		}
	}
}
