using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyData
	/// </summary>
	/// <remarks>
	///    concrete dataset represents vertices, lines, polygons, and triangle strips
	///
	/// vtkPolyData is a data object that is a concrete implementation of
	/// vtkDataSet. vtkPolyData represents a geometric structure consisting of
	/// vertices, lines, polygons, and/or triangle strips. Point and cell
	/// attribute values (e.g., scalars, vectors, etc.) also are represented.
	///
	/// The actual cell types (vtkCellType.h) supported by vtkPolyData are:
	/// vtkVertex, vtkPolyVertex, vtkLine, vtkPolyLine, vtkTriangle, vtkQuad,
	/// vtkPolygon, and vtkTriangleStrip.
	///
	/// One important feature of vtkPolyData objects is that special traversal and
	/// data manipulation methods are available to process data. These methods are
	/// generally more efficient than vtkDataSet methods and should be used
	/// whenever possible. For example, traversing the cells in a dataset we would
	/// use GetCell(). To traverse cells with vtkPolyData we would retrieve the
	/// cell array object representing polygons (for example using GetPolys()) and
	/// then use vtkCellArray's InitTraversal() and GetNextCell() methods.
	///
	/// @warning
	/// Because vtkPolyData is implemented with four separate instances of
	/// vtkCellArray to represent 0D vertices, 1D lines, 2D polygons, and 2D
	/// triangle strips, it is possible to create vtkPolyData instances that
	/// consist of a mixture of cell types. Because of the design of the class,
	/// there are certain limitations on how mixed cell types are inserted into
	/// the vtkPolyData, and in turn the order in which they are processed and
	/// rendered. To preserve the consistency of cell ids, and to ensure that
	/// cells with cell data are rendered properly, users must insert mixed cells
	/// in the order of vertices (vtkVertex and vtkPolyVertex), lines (vtkLine and
	/// vtkPolyLine), polygons (vtkTriangle, vtkQuad, vtkPolygon), and triangle
	/// strips (vtkTriangleStrip).
	///
	/// @warning
	/// Some filters when processing vtkPolyData with mixed cell types may process
	/// the cells in differing ways. Some will convert one type into another
	/// (e.g., vtkTriangleStrip into vtkTriangles) or expect a certain type
	/// (vtkDecimatePro expects triangles or triangle strips; vtkTubeFilter
	/// expects lines). Read the documentation for each filter carefully to
	/// understand how each part of vtkPolyData is processed.
	///
	/// @warning
	/// Some of the methods specified here function properly only when the dataset
	/// has been specified as "Editable". They are documented as such.
	/// </remarks>
	// Token: 0x02000A9F RID: 2719
	public class vtkPolyData : vtkPointSet
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C877 RID: 116855 RVA: 0x002812A6 File Offset: 0x0027F4A6
		static vtkPolyData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C878 RID: 116856 RVA: 0x002812CE File Offset: 0x0027F4CE
		public vtkPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C879 RID: 116857
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C87A RID: 116858 RVA: 0x002812DC File Offset: 0x0027F4DC
		public new static vtkPolyData New()
		{
			vtkPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyData.vtkPolyData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C87B RID: 116859 RVA: 0x00281330 File Offset: 0x0027F530
		public vtkPolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolyData.vtkPolyData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C87C RID: 116860 RVA: 0x00281374 File Offset: 0x0027F574
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C87D RID: 116861
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_AddCellReference_01(HandleRef pThis, long cellId);

		/// <summary>
		/// Add references to cell in cell structure. This means the links from
		/// the cell's points to the cell are modified. Memory is not extended. Use the
		/// method ResizeCellList() to resize the link list from a point to its using
		/// cells. (This operator assumes BuildLinks() has been called.) Use this
		/// method only when the dataset is set as Editable.
		/// </summary>
		// Token: 0x0601C87E RID: 116862 RVA: 0x0028137F File Offset: 0x0027F57F
		public void AddCellReference(long cellId)
		{
			vtkPolyData.vtkPolyData_AddCellReference_01(base.GetCppThis(), cellId);
		}

		// Token: 0x0601C87F RID: 116863
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_AddReferenceToCell_02(HandleRef pThis, long ptId, long cellId);

		/// <summary>
		/// Add a reference to a cell in a particular point's link list. (You may also
		/// consider using AddCellReference() to add the references from all the
		/// cell's points to the cell.) This operator does not realloc memory; use the
		/// operator ResizeCellList() to do this if necessary. Use this
		/// method only when the dataset is set as Editable.
		/// </summary>
		// Token: 0x0601C880 RID: 116864 RVA: 0x0028138F File Offset: 0x0027F58F
		public void AddReferenceToCell(long ptId, long cellId)
		{
			vtkPolyData.vtkPolyData_AddReferenceToCell_02(base.GetCppThis(), ptId, cellId);
		}

		// Token: 0x0601C881 RID: 116865
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_Allocate_03(HandleRef pThis, long numCells, int arg1);

		/// <summary>
		/// Method allocates initial storage for vertex, line, polygon, and
		/// triangle strip arrays. Use this method before the method
		/// PolyData::InsertNextCell(). (Or, provide vertex, line, polygon, and
		/// triangle strip cell arrays). @a extSize is no longer used.
		/// </summary>
		// Token: 0x0601C882 RID: 116866 RVA: 0x002813A0 File Offset: 0x0027F5A0
		public void Allocate(long numCells, int arg1)
		{
			vtkPolyData.vtkPolyData_Allocate_03(base.GetCppThis(), numCells, arg1);
		}

		// Token: 0x0601C883 RID: 116867
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_Allocate_04(HandleRef pThis, HandleRef inPolyData, long numCells, int arg2);

		/// <summary>
		/// Similar to the method above, this method allocates initial storage for
		/// vertex, line, polygon, and triangle strip arrays. It does this more
		/// intelligently, examining the supplied inPolyData to determine whether to
		/// allocate the verts, lines, polys, and strips arrays.  (These arrays are
		/// allocated only if there is data in the corresponding arrays in the
		/// inPolyData.)  Caution: if the inPolyData has no verts, and after
		/// allocating with this method an PolyData::InsertNextCell() is invoked
		/// where a vertex is inserted, bad things will happen.
		/// </summary>
		// Token: 0x0601C884 RID: 116868 RVA: 0x002813B4 File Offset: 0x0027F5B4
		public void Allocate(vtkPolyData inPolyData, long numCells, int arg2)
		{
			vtkPolyData.vtkPolyData_Allocate_04(base.GetCppThis(), (inPolyData == null) ? default(HandleRef) : inPolyData.GetCppThis(), numCells, arg2);
		}

		// Token: 0x0601C885 RID: 116869
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolyData_AllocateCopy_05(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Preallocate memory for the internal cell arrays such that they are the
		/// same size as those in @a pd.
		///
		/// Existing data is not preserved and the number of cells is set to zero.
		///
		/// @return True if allocation succeeds.
		/// </summary>
		// Token: 0x0601C886 RID: 116870 RVA: 0x002813E8 File Offset: 0x0027F5E8
		public bool AllocateCopy(vtkPolyData pd)
		{
			return vtkPolyData.vtkPolyData_AllocateCopy_05(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis()) != 0;
		}

		// Token: 0x0601C887 RID: 116871
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolyData_AllocateEstimate_06(HandleRef pThis, long numCells, long maxCellSize);

		/// <summary>
		/// Preallocate memory for the internal cell arrays. Each of the internal
		/// cell arrays (verts, lines, polys, and strips) will be resized to hold
		/// @a numCells cells of size @a maxCellSize.
		///
		/// Existing data is not preserved and the number of cells is set to zero.
		///
		/// @return True if allocation succeeds.
		/// </summary>
		// Token: 0x0601C888 RID: 116872 RVA: 0x00281424 File Offset: 0x0027F624
		public bool AllocateEstimate(long numCells, long maxCellSize)
		{
			return vtkPolyData.vtkPolyData_AllocateEstimate_06(base.GetCppThis(), numCells, maxCellSize) != 0;
		}

		// Token: 0x0601C889 RID: 116873
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolyData_AllocateEstimate_07(HandleRef pThis, long numVerts, long maxVertSize, long numLines, long maxLineSize, long numPolys, long maxPolySize, long numStrips, long maxStripSize);

		/// <summary>
		/// Preallocate memory for the internal cell arrays. Each of the internal
		/// cell arrays (verts, lines, polys, and strips) will be resized to hold
		/// the indicated number of cells of the specified cell size.
		///
		/// Existing data is not preserved and the number of cells is set to zero.
		///
		/// @return True if allocation succeeds.
		/// </summary>
		// Token: 0x0601C88A RID: 116874 RVA: 0x0028144C File Offset: 0x0027F64C
		public bool AllocateEstimate(long numVerts, long maxVertSize, long numLines, long maxLineSize, long numPolys, long maxPolySize, long numStrips, long maxStripSize)
		{
			return vtkPolyData.vtkPolyData_AllocateEstimate_07(base.GetCppThis(), numVerts, maxVertSize, numLines, maxLineSize, numPolys, maxPolySize, numStrips, maxStripSize) != 0;
		}

		// Token: 0x0601C88B RID: 116875
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolyData_AllocateExact_08(HandleRef pThis, long numCells, long connectivitySize);

		/// <summary>
		/// Preallocate memory for the internal cell arrays. Each of the internal
		/// cell arrays (verts, lines, polys, and strips) will be resized to hold
		/// @a numCells cells and @a connectivitySize pointIds.
		///
		/// Existing data is not preserved and the number of cells is set to zero.
		///
		/// @return True if allocation succeeds.
		/// </summary>
		// Token: 0x0601C88C RID: 116876 RVA: 0x00281480 File Offset: 0x0027F680
		public bool AllocateExact(long numCells, long connectivitySize)
		{
			return vtkPolyData.vtkPolyData_AllocateExact_08(base.GetCppThis(), numCells, connectivitySize) != 0;
		}

		// Token: 0x0601C88D RID: 116877
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolyData_AllocateExact_09(HandleRef pThis, long numVerts, long vertConnSize, long numLines, long lineConnSize, long numPolys, long polyConnSize, long numStrips, long stripConnSize);

		/// <summary>
		/// Preallocate memory for the internal cell arrays. Each of the internal
		/// cell arrays (verts, lines, polys, and strips) will be resized to hold
		/// the indicated number of cells and the specified number of point ids
		/// (ConnSize).
		///
		/// Existing data is not preserved and the number of cells is set to zero.
		///
		/// @return True if allocation succeeds.
		/// </summary>
		// Token: 0x0601C88E RID: 116878 RVA: 0x002814A8 File Offset: 0x0027F6A8
		public bool AllocateExact(long numVerts, long vertConnSize, long numLines, long lineConnSize, long numPolys, long polyConnSize, long numStrips, long stripConnSize)
		{
			return vtkPolyData.vtkPolyData_AllocateExact_09(base.GetCppThis(), numVerts, vertConnSize, numLines, lineConnSize, numPolys, polyConnSize, numStrips, stripConnSize) != 0;
		}

		// Token: 0x0601C88F RID: 116879
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolyData_AllocateProportional_10(HandleRef pThis, HandleRef pd, double ratio);

		/// <summary>
		/// Preallocate memory for the internal cell arrays such that they are
		/// proportional to those in @a pd by a factor of @a ratio (for instance,
		/// @a ratio = 2 allocates twice as many cells).
		///
		/// Existing data is not preserved and the number of cells is set to zero.
		///
		/// @return True if allocation succeeds.
		/// </summary>
		// Token: 0x0601C890 RID: 116880 RVA: 0x002814DC File Offset: 0x0027F6DC
		public bool AllocateProportional(vtkPolyData pd, double ratio)
		{
			return vtkPolyData.vtkPolyData_AllocateProportional_10(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis(), ratio) != 0;
		}

		// Token: 0x0601C891 RID: 116881
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_BuildCells_11(HandleRef pThis);

		/// <summary>
		/// Create data structure that allows random access of cells. BuildCells is
		/// expensive but necessary to make use of the faster non-virtual implementations
		/// of GetCell/GetCellPoints. One may check if cells need to be built via
		/// NeedToBuilds before invoking. Cells always need to be built/re-built after
		/// low level direct modifications to verts, lines, polys or strips cell arrays.
		/// </summary>
		// Token: 0x0601C892 RID: 116882 RVA: 0x00281518 File Offset: 0x0027F718
		public void BuildCells()
		{
			vtkPolyData.vtkPolyData_BuildCells_11(base.GetCppThis());
		}

		// Token: 0x0601C893 RID: 116883
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_BuildLinks_12(HandleRef pThis, int initialSize);

		/// <summary>
		/// Create upward links from points to cells that use each point. Enables
		/// topologically complex queries. Normally the links array is allocated
		/// based on the number of points in the vtkPolyData. The optional
		/// initialSize parameter can be used to allocate a larger size initially.
		/// </summary>
		// Token: 0x0601C894 RID: 116884 RVA: 0x00281527 File Offset: 0x0027F727
		public void BuildLinks(int initialSize)
		{
			vtkPolyData.vtkPolyData_BuildLinks_12(base.GetCppThis(), initialSize);
		}

		// Token: 0x0601C895 RID: 116885
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_ComputeCellsBounds_13(HandleRef pThis);

		/// <summary>
		/// Compute the (X, Y, Z)  bounds of the data. Note that the method only considers
		/// points that are used by cells.
		/// This is done for usability and historical reasons.
		///
		/// IMPORTANT
		///
		/// Until vtk 9.0.1, vtkPolyData::ComputeBounds() used to ignore points that do not belong
		/// to any cell.
		/// That was not consistent with other vtkPointSet subclasses and thus was error prone.
		/// See this ParaView issue https://gitlab.kitware.com/paraview/paraview/-/issues/20354
		/// Now it defers to vtkPointSet::ComputeBounds() so vtkPolyData::GetBounds() may
		/// not return the same bounds as before. This behavior is probably the one you want
		/// when using bounds.
		///
		/// The previous behavior is still available through vtkPolyData::ComputeCellsBounds()
		/// and vtkPolyData::GetCellsBounds(). This is mainly used for rendering purpose.
		/// </summary>
		// Token: 0x0601C896 RID: 116886 RVA: 0x00281537 File Offset: 0x0027F737
		public void ComputeCellsBounds()
		{
			vtkPolyData.vtkPolyData_ComputeCellsBounds_13(base.GetCppThis());
		}

		// Token: 0x0601C897 RID: 116887
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_CopyCells_14(HandleRef pThis, HandleRef pd, HandleRef idList, HandleRef locator);

		/// <summary>
		/// Copy cells listed in idList from pd, including points, point data,
		/// and cell data.  This method assumes that point and cell data have
		/// been allocated.  If you pass in a point locator, then the points
		/// won't be duplicated in the output. This requires the use of an
		/// incremental point locator.
		/// </summary>
		// Token: 0x0601C898 RID: 116888 RVA: 0x00281548 File Offset: 0x0027F748
		public void CopyCells(vtkPolyData pd, vtkIdList idList, vtkIncrementalPointLocator locator)
		{
			vtkPolyData.vtkPolyData_CopyCells_14(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis(), (idList == null) ? default(HandleRef) : idList.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0601C899 RID: 116889
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_CopyStructure_15(HandleRef pThis, HandleRef ds);

		/// <summary>
		/// Copy the geometric and topological structure of an input poly data object.
		/// </summary>
		// Token: 0x0601C89A RID: 116890 RVA: 0x002815A4 File Offset: 0x0027F7A4
		public override void CopyStructure(vtkDataSet ds)
		{
			vtkPolyData.vtkPolyData_CopyStructure_15(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		// Token: 0x0601C89B RID: 116891
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_DeepCopy_16(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Shallow and Deep copy.
		/// </summary>
		// Token: 0x0601C89C RID: 116892 RVA: 0x002815D4 File Offset: 0x0027F7D4
		public override void DeepCopy(vtkDataObject src)
		{
			vtkPolyData.vtkPolyData_DeepCopy_16(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0601C89D RID: 116893
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_DeleteCell_17(HandleRef pThis, long cellId);

		/// <summary>
		/// Mark a point/cell as deleted from this vtkPolyData. Use this
		/// method only when the dataset is set as Editable.
		/// </summary>
		// Token: 0x0601C89E RID: 116894 RVA: 0x00281603 File Offset: 0x0027F803
		public void DeleteCell(long cellId)
		{
			vtkPolyData.vtkPolyData_DeleteCell_17(base.GetCppThis(), cellId);
		}

		// Token: 0x0601C89F RID: 116895
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_DeleteCells_18(HandleRef pThis);

		/// <summary>
		/// Release data structure that allows random access of the cells. This must
		/// be done before a 2nd call to BuildLinks(). DeleteCells implicitly deletes
		/// the links as well since they are no longer valid.
		/// </summary>
		// Token: 0x0601C8A0 RID: 116896 RVA: 0x00281613 File Offset: 0x0027F813
		public void DeleteCells()
		{
			vtkPolyData.vtkPolyData_DeleteCells_18(base.GetCppThis());
		}

		// Token: 0x0601C8A1 RID: 116897
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_DeleteLinks_19(HandleRef pThis);

		/// <summary>
		/// Release the upward links from point to cells that use each point.
		/// </summary>
		// Token: 0x0601C8A2 RID: 116898 RVA: 0x00281622 File Offset: 0x0027F822
		public void DeleteLinks()
		{
			vtkPolyData.vtkPolyData_DeleteLinks_19(base.GetCppThis());
		}

		// Token: 0x0601C8A3 RID: 116899
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_DeletePoint_20(HandleRef pThis, long ptId);

		/// <summary>
		/// Mark a point/cell as deleted from this vtkPolyData. Use this
		/// method only when the dataset is set as Editable.
		/// </summary>
		// Token: 0x0601C8A4 RID: 116900 RVA: 0x00281631 File Offset: 0x0027F831
		public void DeletePoint(long ptId)
		{
			vtkPolyData.vtkPolyData_DeletePoint_20(base.GetCppThis(), ptId);
		}

		// Token: 0x0601C8A5 RID: 116901
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyData_ExtendedNew_21(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C8A6 RID: 116902 RVA: 0x00281644 File Offset: 0x0027F844
		public new static vtkPolyData ExtendedNew()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyData.vtkPolyData_ExtendedNew_21(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x0601C8A7 RID: 116903
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkPolyData_GetActualMemorySize_22(HandleRef pThis);

		/// <summary>
		/// Return the actual size of the data in kibibytes (1024 bytes). This number
		/// is valid only after the pipeline has updated. The memory size
		/// returned is guaranteed to be greater than or equal to the
		/// memory required to represent the data (e.g., extra space in
		/// arrays, etc. are not included in the return value). THIS METHOD
		/// IS THREAD SAFE.
		/// </summary>
		// Token: 0x0601C8A8 RID: 116904 RVA: 0x002816B0 File Offset: 0x0027F8B0
		public override uint GetActualMemorySize()
		{
			return vtkPolyData.vtkPolyData_GetActualMemorySize_22(base.GetCppThis());
		}

		// Token: 0x0601C8A9 RID: 116905
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyData_GetCell_23(HandleRef pThis, long cellId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkDataSet interface.
		/// </summary>
		// Token: 0x0601C8AA RID: 116906 RVA: 0x002816D0 File Offset: 0x0027F8D0
		public override vtkCell GetCell(long cellId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyData.vtkPolyData_GetCell_23(base.GetCppThis(), cellId, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C8AB RID: 116907
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_GetCell_24(HandleRef pThis, long cellId, HandleRef cell);

		/// <summary>
		/// Standard vtkDataSet interface.
		/// </summary>
		// Token: 0x0601C8AC RID: 116908 RVA: 0x00281740 File Offset: 0x0027F940
		public override void GetCell(long cellId, vtkGenericCell cell)
		{
			vtkPolyData.vtkPolyData_GetCell_24(base.GetCppThis(), cellId, (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x0601C8AD RID: 116909
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_GetCellBounds_25(HandleRef pThis, long cellId, IntPtr bounds);

		/// <summary>
		/// Standard vtkDataSet interface.
		/// </summary>
		// Token: 0x0601C8AE RID: 116910 RVA: 0x00281770 File Offset: 0x0027F970
		public override void GetCellBounds(long cellId, IntPtr bounds)
		{
			vtkPolyData.vtkPolyData_GetCellBounds_25(base.GetCppThis(), cellId, bounds);
		}

		// Token: 0x0601C8AF RID: 116911
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_GetCellEdgeNeighbors_26(HandleRef pThis, long cellId, long p1, long p2, HandleRef cellIds);

		/// <summary>
		/// Get the neighbors at an edge. More efficient than the general
		/// GetCellNeighbors(). Assumes links have been built (with BuildLinks()),
		/// and looks specifically for edge neighbors.
		/// </summary>
		// Token: 0x0601C8B0 RID: 116912 RVA: 0x00281784 File Offset: 0x0027F984
		public void GetCellEdgeNeighbors(long cellId, long p1, long p2, vtkIdList cellIds)
		{
			vtkPolyData.vtkPolyData_GetCellEdgeNeighbors_26(base.GetCppThis(), cellId, p1, p2, (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		// Token: 0x0601C8B1 RID: 116913
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyData_GetCellIdRelativeToCellArray_27(HandleRef pThis, long cellId);

		/// <summary>
		/// Maps the cell at position `cellId` inside the `vtkPolyData` to its location in the
		/// corresponding cell array. For instance, if cell `cellId` is a line, then this method returns
		/// the position of this cell in the `Lines` cell array.
		/// </summary>
		// Token: 0x0601C8B2 RID: 116914 RVA: 0x002817B8 File Offset: 0x0027F9B8
		public long GetCellIdRelativeToCellArray(long cellId)
		{
			return vtkPolyData.vtkPolyData_GetCellIdRelativeToCellArray_27(base.GetCppThis(), cellId);
		}

		// Token: 0x0601C8B3 RID: 116915
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_GetCellNeighbors_28(HandleRef pThis, long cellId, HandleRef ptIds, HandleRef cellIds);

		/// <summary>
		/// Standard vtkDataSet interface.
		/// </summary>
		// Token: 0x0601C8B4 RID: 116916 RVA: 0x002817D8 File Offset: 0x0027F9D8
		public override void GetCellNeighbors(long cellId, vtkIdList ptIds, vtkIdList cellIds)
		{
			vtkPolyData.vtkPolyData_GetCellNeighbors_28(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		// Token: 0x0601C8B5 RID: 116917
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_GetCellPoints_29(HandleRef pThis, long cellId, HandleRef ptIds);

		/// <summary>
		/// Copy a cells point ids into list provided. (Less efficient.)
		/// </summary>
		// Token: 0x0601C8B6 RID: 116918 RVA: 0x00281820 File Offset: 0x0027FA20
		public override void GetCellPoints(long cellId, vtkIdList ptIds)
		{
			vtkPolyData.vtkPolyData_GetCellPoints_29(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		// Token: 0x0601C8B7 RID: 116919
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyData_GetCellSize_30(HandleRef pThis, long cellId);

		/// <summary>
		/// Standard vtkDataSet interface.
		/// </summary>
		// Token: 0x0601C8B8 RID: 116920 RVA: 0x00281850 File Offset: 0x0027FA50
		public override long GetCellSize(long cellId)
		{
			return vtkPolyData.vtkPolyData_GetCellSize_30(base.GetCppThis(), cellId);
		}

		// Token: 0x0601C8B9 RID: 116921
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyData_GetCellType_31(HandleRef pThis, long cellId);

		/// <summary>
		/// Standard vtkDataSet interface.
		/// </summary>
		// Token: 0x0601C8BA RID: 116922 RVA: 0x00281870 File Offset: 0x0027FA70
		public override int GetCellType(long cellId)
		{
			return vtkPolyData.vtkPolyData_GetCellType_31(base.GetCppThis(), cellId);
		}

		// Token: 0x0601C8BB RID: 116923
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_GetCellsBounds_32(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the cells bounds.
		/// Internally calls ComputeCellsBounds().
		/// @sa ComputeCellsBounds()
		/// </summary>
		// Token: 0x0601C8BC RID: 116924 RVA: 0x00281890 File Offset: 0x0027FA90
		public void GetCellsBounds(IntPtr bounds)
		{
			vtkPolyData.vtkPolyData_GetCellsBounds_32(base.GetCppThis(), bounds);
		}

		// Token: 0x0601C8BD RID: 116925
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyData_GetData_33(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601C8BE RID: 116926 RVA: 0x002818A0 File Offset: 0x0027FAA0
		public new static vtkPolyData GetData(vtkInformation info)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyData.vtkPolyData_GetData_33((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x0601C8BF RID: 116927
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyData_GetData_34(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601C8C0 RID: 116928 RVA: 0x00281920 File Offset: 0x0027FB20
		public new static vtkPolyData GetData(vtkInformationVector v, int i)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyData.vtkPolyData_GetData_34((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x0601C8C1 RID: 116929
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyData_GetDataObjectType_35(HandleRef pThis);

		/// <summary>
		/// Return what type of dataset this is.
		/// </summary>
		// Token: 0x0601C8C2 RID: 116930 RVA: 0x002819A0 File Offset: 0x0027FBA0
		public override int GetDataObjectType()
		{
			return vtkPolyData.vtkPolyData_GetDataObjectType_35(base.GetCppThis());
		}

		// Token: 0x0601C8C3 RID: 116931
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyData_GetGhostLevel_36(HandleRef pThis);

		/// <summary>
		/// Get the ghost level.
		/// </summary>
		// Token: 0x0601C8C4 RID: 116932 RVA: 0x002819C0 File Offset: 0x0027FBC0
		public virtual int GetGhostLevel()
		{
			return vtkPolyData.vtkPolyData_GetGhostLevel_36(base.GetCppThis());
		}

		// Token: 0x0601C8C5 RID: 116933
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyData_GetLines_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the cell array defining lines. If there are no lines, an
		/// empty array will be returned (convenience to simplify traversal).
		/// </summary>
		// Token: 0x0601C8C6 RID: 116934 RVA: 0x002819E0 File Offset: 0x0027FBE0
		public vtkCellArray GetLines()
		{
			vtkCellArray vtkCellArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyData.vtkPolyData_GetLines_37(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellArray = (vtkCellArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellArray.Register(null);
				}
			}
			return vtkCellArray;
		}

		// Token: 0x0601C8C7 RID: 116935
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyData_GetLinks_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the links that you created possibly without using BuildLinks.
		///
		/// Note: Only vtkCellLinks are currently supported.
		/// </summary>
		// Token: 0x0601C8C8 RID: 116936 RVA: 0x00281A50 File Offset: 0x0027FC50
		public virtual vtkAbstractCellLinks GetLinks()
		{
			vtkAbstractCellLinks vtkAbstractCellLinks = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyData.vtkPolyData_GetLinks_38(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractCellLinks = (vtkAbstractCellLinks)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractCellLinks.Register(null);
				}
			}
			return vtkAbstractCellLinks;
		}

		// Token: 0x0601C8C9 RID: 116937
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkPolyData_GetMTime_39(HandleRef pThis);

		/// <summary>
		/// Get MTime which also considers its cell array MTime.
		/// </summary>
		// Token: 0x0601C8CA RID: 116938 RVA: 0x00281AC0 File Offset: 0x0027FCC0
		public override ulong GetMTime()
		{
			return vtkPolyData.vtkPolyData_GetMTime_39(base.GetCppThis());
		}

		// Token: 0x0601C8CB RID: 116939
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyData_GetMaxCellSize_40(HandleRef pThis);

		/// <summary>
		/// Return the maximum cell size in this poly data.
		/// </summary>
		// Token: 0x0601C8CC RID: 116940 RVA: 0x00281AE0 File Offset: 0x0027FCE0
		public override int GetMaxCellSize()
		{
			return vtkPolyData.vtkPolyData_GetMaxCellSize_40(base.GetCppThis());
		}

		// Token: 0x0601C8CD RID: 116941
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyData_GetMaxSpatialDimension_41(HandleRef pThis);

		/// <summary>
		/// Get the maximum spatial dimensionality of the data
		/// which is the maximum dimension of all cells.
		/// </summary>
		// Token: 0x0601C8CE RID: 116942 RVA: 0x00281B00 File Offset: 0x0027FD00
		public override int GetMaxSpatialDimension()
		{
			return vtkPolyData.vtkPolyData_GetMaxSpatialDimension_41(base.GetCppThis());
		}

		// Token: 0x0601C8CF RID: 116943
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkPolyData_GetMeshMTime_42(HandleRef pThis);

		/// <summary>
		/// Return the mesh (geometry/topology) modification time.
		/// This time is different from the usual MTime which also takes into
		/// account the modification of data arrays. This function can be used to
		/// track the changes on the mesh separately from the data arrays
		/// (eg. static mesh over time with transient data).
		/// </summary>
		// Token: 0x0601C8D0 RID: 116944 RVA: 0x00281B20 File Offset: 0x0027FD20
		public virtual ulong GetMeshMTime()
		{
			return vtkPolyData.vtkPolyData_GetMeshMTime_42(base.GetCppThis());
		}

		// Token: 0x0601C8D1 RID: 116945
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyData_GetNumberOfCells_43(HandleRef pThis);

		/// <summary>
		/// Standard vtkDataSet interface.
		/// </summary>
		// Token: 0x0601C8D2 RID: 116946 RVA: 0x00281B40 File Offset: 0x0027FD40
		public override long GetNumberOfCells()
		{
			return vtkPolyData.vtkPolyData_GetNumberOfCells_43(base.GetCppThis());
		}

		// Token: 0x0601C8D3 RID: 116947
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyData_GetNumberOfGenerationsFromBase_44(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C8D4 RID: 116948 RVA: 0x00281B60 File Offset: 0x0027FD60
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolyData.vtkPolyData_GetNumberOfGenerationsFromBase_44(base.GetCppThis(), type);
		}

		// Token: 0x0601C8D5 RID: 116949
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyData_GetNumberOfGenerationsFromBaseType_45([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C8D6 RID: 116950 RVA: 0x00281B80 File Offset: 0x0027FD80
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolyData.vtkPolyData_GetNumberOfGenerationsFromBaseType_45(type);
		}

		// Token: 0x0601C8D7 RID: 116951
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyData_GetNumberOfLines_46(HandleRef pThis);

		/// <summary>
		/// Return the number of primitives of a particular type held.
		/// </summary>
		// Token: 0x0601C8D8 RID: 116952 RVA: 0x00281B9C File Offset: 0x0027FD9C
		public long GetNumberOfLines()
		{
			return vtkPolyData.vtkPolyData_GetNumberOfLines_46(base.GetCppThis());
		}

		// Token: 0x0601C8D9 RID: 116953
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyData_GetNumberOfPieces_47(HandleRef pThis);

		/// <summary>
		/// Get the piece and the number of pieces. Similar to extent in 3D.
		/// </summary>
		// Token: 0x0601C8DA RID: 116954 RVA: 0x00281BBC File Offset: 0x0027FDBC
		public virtual int GetNumberOfPieces()
		{
			return vtkPolyData.vtkPolyData_GetNumberOfPieces_47(base.GetCppThis());
		}

		// Token: 0x0601C8DB RID: 116955
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyData_GetNumberOfPolys_48(HandleRef pThis);

		/// <summary>
		/// Return the number of primitives of a particular type held.
		/// </summary>
		// Token: 0x0601C8DC RID: 116956 RVA: 0x00281BDC File Offset: 0x0027FDDC
		public long GetNumberOfPolys()
		{
			return vtkPolyData.vtkPolyData_GetNumberOfPolys_48(base.GetCppThis());
		}

		// Token: 0x0601C8DD RID: 116957
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyData_GetNumberOfStrips_49(HandleRef pThis);

		/// <summary>
		/// Return the number of primitives of a particular type held.
		/// </summary>
		// Token: 0x0601C8DE RID: 116958 RVA: 0x00281BFC File Offset: 0x0027FDFC
		public long GetNumberOfStrips()
		{
			return vtkPolyData.vtkPolyData_GetNumberOfStrips_49(base.GetCppThis());
		}

		// Token: 0x0601C8DF RID: 116959
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyData_GetNumberOfVerts_50(HandleRef pThis);

		/// <summary>
		/// Return the number of primitives of a particular type held.
		/// </summary>
		// Token: 0x0601C8E0 RID: 116960 RVA: 0x00281C1C File Offset: 0x0027FE1C
		public long GetNumberOfVerts()
		{
			return vtkPolyData.vtkPolyData_GetNumberOfVerts_50(base.GetCppThis());
		}

		// Token: 0x0601C8E1 RID: 116961
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyData_GetPiece_51(HandleRef pThis);

		/// <summary>
		/// Get the piece and the number of pieces. Similar to extent in 3D.
		/// </summary>
		// Token: 0x0601C8E2 RID: 116962 RVA: 0x00281C3C File Offset: 0x0027FE3C
		public virtual int GetPiece()
		{
			return vtkPolyData.vtkPolyData_GetPiece_51(base.GetCppThis());
		}

		// Token: 0x0601C8E3 RID: 116963
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_GetPointCells_52(HandleRef pThis, long ptId, HandleRef cellIds);

		/// <summary>
		/// Efficient method to obtain cells using a particular point. Make sure that
		/// routine BuildLinks() has been called.
		/// </summary>
		// Token: 0x0601C8E4 RID: 116964 RVA: 0x00281C5C File Offset: 0x0027FE5C
		public override void GetPointCells(long ptId, vtkIdList cellIds)
		{
			vtkPolyData.vtkPolyData_GetPointCells_52(base.GetCppThis(), ptId, (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		// Token: 0x0601C8E5 RID: 116965
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyData_GetPolys_53(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the cell array defining polygons. If there are no polygons, an
		/// empty array will be returned (convenience to simplify traversal).
		/// </summary>
		// Token: 0x0601C8E6 RID: 116966 RVA: 0x00281C8C File Offset: 0x0027FE8C
		public vtkCellArray GetPolys()
		{
			vtkCellArray vtkCellArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyData.vtkPolyData_GetPolys_53(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellArray = (vtkCellArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellArray.Register(null);
				}
			}
			return vtkCellArray;
		}

		// Token: 0x0601C8E7 RID: 116967
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyData_GetScalarFieldCriticalIndex_54(HandleRef pThis, long pointId, HandleRef scalarField);

		/// <summary>
		/// Scalar field critical point classification (for manifold 2D meshes).
		/// Reference: J. Milnor "Morse Theory", Princeton University Press, 1963.
		///
		/// Given a pointId and an attribute representing a scalar field, this member
		/// returns the index of the critical point:
		/// vtkPolyData::MINIMUM (index 0): local minimum;
		/// vtkPolyData::SADDLE  (index 1): local saddle;
		/// vtkPolyData::MAXIMUM (index 2): local maximum.
		///
		/// Other returned values are:
		/// vtkPolyData::REGULAR_POINT: regular point (the gradient does not vanish);
		/// vtkPolyData::ERR_NON_MANIFOLD_STAR: the star of the considered vertex is
		/// not manifold (could not evaluate the index)
		/// vtkPolyData::ERR_INCORRECT_FIELD: the number of entries in the scalar field
		/// array is different form the number of vertices in the mesh.
		/// vtkPolyData::ERR_NO_SUCH_FIELD: the specified scalar field does not exist.
		/// </summary>
		// Token: 0x0601C8E8 RID: 116968 RVA: 0x00281CFC File Offset: 0x0027FEFC
		public int GetScalarFieldCriticalIndex(long pointId, vtkDataArray scalarField)
		{
			return vtkPolyData.vtkPolyData_GetScalarFieldCriticalIndex_54(base.GetCppThis(), pointId, (scalarField == null) ? default(HandleRef) : scalarField.GetCppThis());
		}

		// Token: 0x0601C8E9 RID: 116969
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyData_GetScalarFieldCriticalIndex_55(HandleRef pThis, long pointId, int fieldId);

		/// <summary>
		/// Scalar field critical point classification (for manifold 2D meshes).
		/// Reference: J. Milnor "Morse Theory", Princeton University Press, 1963.
		///
		/// Given a pointId and an attribute representing a scalar field, this member
		/// returns the index of the critical point:
		/// vtkPolyData::MINIMUM (index 0): local minimum;
		/// vtkPolyData::SADDLE  (index 1): local saddle;
		/// vtkPolyData::MAXIMUM (index 2): local maximum.
		///
		/// Other returned values are:
		/// vtkPolyData::REGULAR_POINT: regular point (the gradient does not vanish);
		/// vtkPolyData::ERR_NON_MANIFOLD_STAR: the star of the considered vertex is
		/// not manifold (could not evaluate the index)
		/// vtkPolyData::ERR_INCORRECT_FIELD: the number of entries in the scalar field
		/// array is different form the number of vertices in the mesh.
		/// vtkPolyData::ERR_NO_SUCH_FIELD: the specified scalar field does not exist.
		/// </summary>
		// Token: 0x0601C8EA RID: 116970 RVA: 0x00281D34 File Offset: 0x0027FF34
		public int GetScalarFieldCriticalIndex(long pointId, int fieldId)
		{
			return vtkPolyData.vtkPolyData_GetScalarFieldCriticalIndex_55(base.GetCppThis(), pointId, fieldId);
		}

		// Token: 0x0601C8EB RID: 116971
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyData_GetScalarFieldCriticalIndex_56(HandleRef pThis, long pointId, [MarshalAs(UnmanagedType.LPUTF8Str)] string fieldName);

		/// <summary>
		/// Scalar field critical point classification (for manifold 2D meshes).
		/// Reference: J. Milnor "Morse Theory", Princeton University Press, 1963.
		///
		/// Given a pointId and an attribute representing a scalar field, this member
		/// returns the index of the critical point:
		/// vtkPolyData::MINIMUM (index 0): local minimum;
		/// vtkPolyData::SADDLE  (index 1): local saddle;
		/// vtkPolyData::MAXIMUM (index 2): local maximum.
		///
		/// Other returned values are:
		/// vtkPolyData::REGULAR_POINT: regular point (the gradient does not vanish);
		/// vtkPolyData::ERR_NON_MANIFOLD_STAR: the star of the considered vertex is
		/// not manifold (could not evaluate the index)
		/// vtkPolyData::ERR_INCORRECT_FIELD: the number of entries in the scalar field
		/// array is different form the number of vertices in the mesh.
		/// vtkPolyData::ERR_NO_SUCH_FIELD: the specified scalar field does not exist.
		/// </summary>
		// Token: 0x0601C8EC RID: 116972 RVA: 0x00281D58 File Offset: 0x0027FF58
		public int GetScalarFieldCriticalIndex(long pointId, string fieldName)
		{
			return vtkPolyData.vtkPolyData_GetScalarFieldCriticalIndex_56(base.GetCppThis(), pointId, fieldName);
		}

		// Token: 0x0601C8ED RID: 116973
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyData_GetStrips_57(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the cell array defining triangle strips. If there are no
		/// triangle strips, an empty array will be returned (convenience to
		/// simplify traversal).
		/// </summary>
		// Token: 0x0601C8EE RID: 116974 RVA: 0x00281D7C File Offset: 0x0027FF7C
		public vtkCellArray GetStrips()
		{
			vtkCellArray vtkCellArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyData.vtkPolyData_GetStrips_57(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellArray = (vtkCellArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellArray.Register(null);
				}
			}
			return vtkCellArray;
		}

		// Token: 0x0601C8EF RID: 116975
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyData_GetVerts_58(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the cell array defining vertices. If there are no vertices, an
		/// empty array will be returned (convenience to simplify traversal).
		/// </summary>
		// Token: 0x0601C8F0 RID: 116976 RVA: 0x00281DEC File Offset: 0x0027FFEC
		public vtkCellArray GetVerts()
		{
			vtkCellArray vtkCellArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyData.vtkPolyData_GetVerts_58(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellArray = (vtkCellArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellArray.Register(null);
				}
			}
			return vtkCellArray;
		}

		// Token: 0x0601C8F1 RID: 116977
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_Initialize_59(HandleRef pThis);

		/// <summary>
		/// Restore object to initial state. Release memory back to system.
		/// </summary>
		// Token: 0x0601C8F2 RID: 116978 RVA: 0x00281E5B File Offset: 0x0028005B
		public override void Initialize()
		{
			vtkPolyData.vtkPolyData_Initialize_59(base.GetCppThis());
		}

		// Token: 0x0601C8F3 RID: 116979
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyData_InsertNextCell_60(HandleRef pThis, int type, int npts, IntPtr pts);

		/// <summary>
		/// Insert a cell of type VTK_VERTEX, VTK_POLY_VERTEX, VTK_LINE, VTK_POLY_LINE,
		/// VTK_TRIANGLE, VTK_QUAD, VTK_POLYGON, or VTK_TRIANGLE_STRIP.  Make sure that
		/// the PolyData::Allocate() function has been called first or that vertex,
		/// line, polygon, and triangle strip arrays have been supplied.
		/// Note: will also insert VTK_PIXEL, but converts it to VTK_QUAD.
		/// </summary>
		// Token: 0x0601C8F4 RID: 116980 RVA: 0x00281E6C File Offset: 0x0028006C
		public long InsertNextCell(int type, int npts, IntPtr pts)
		{
			return vtkPolyData.vtkPolyData_InsertNextCell_60(base.GetCppThis(), type, npts, pts);
		}

		// Token: 0x0601C8F5 RID: 116981
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyData_InsertNextCell_61(HandleRef pThis, int type, HandleRef pts);

		/// <summary>
		/// Insert a cell of type VTK_VERTEX, VTK_POLY_VERTEX, VTK_LINE, VTK_POLY_LINE,
		/// VTK_TRIANGLE, VTK_QUAD, VTK_POLYGON, or VTK_TRIANGLE_STRIP.  Make sure that
		/// the PolyData::Allocate() function has been called first or that vertex,
		/// line, polygon, and triangle strip arrays have been supplied.
		/// Note: will also insert VTK_PIXEL, but converts it to VTK_QUAD.
		/// </summary>
		// Token: 0x0601C8F6 RID: 116982 RVA: 0x00281E90 File Offset: 0x00280090
		public long InsertNextCell(int type, vtkIdList pts)
		{
			return vtkPolyData.vtkPolyData_InsertNextCell_61(base.GetCppThis(), type, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		// Token: 0x0601C8F7 RID: 116983
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyData_InsertNextLinkedCell_62(HandleRef pThis, int type, int npts, IntPtr pts);

		/// <summary>
		/// Add a new cell to the cell data structure (after cell pointers have been
		/// built). This method adds the cell and then updates the links from the
		/// points to the cells. (Memory is allocated as necessary.) Use this method
		/// only when the dataset is set as Editable.
		/// </summary>
		// Token: 0x0601C8F8 RID: 116984 RVA: 0x00281EC8 File Offset: 0x002800C8
		public long InsertNextLinkedCell(int type, int npts, IntPtr pts)
		{
			return vtkPolyData.vtkPolyData_InsertNextLinkedCell_62(base.GetCppThis(), type, npts, pts);
		}

		// Token: 0x0601C8F9 RID: 116985
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyData_InsertNextLinkedPoint_63(HandleRef pThis, int numLinks);

		/// <summary>
		/// Add a point to the cell data structure (after cell pointers have been
		/// built). This method adds the point and then allocates memory for the
		/// links to the cells.  (To use this method, make sure points are available
		/// and BuildLinks() has been invoked.) Of the two methods below, one inserts
		/// a point coordinate and the other just makes room for cell links. Use this
		/// method only when the dataset is set as Editable.
		/// </summary>
		// Token: 0x0601C8FA RID: 116986 RVA: 0x00281EEC File Offset: 0x002800EC
		public long InsertNextLinkedPoint(int numLinks)
		{
			return vtkPolyData.vtkPolyData_InsertNextLinkedPoint_63(base.GetCppThis(), numLinks);
		}

		// Token: 0x0601C8FB RID: 116987
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyData_InsertNextLinkedPoint_64(HandleRef pThis, IntPtr x, int numLinks);

		/// <summary>
		/// Add a point to the cell data structure (after cell pointers have been
		/// built). This method adds the point and then allocates memory for the
		/// links to the cells.  (To use this method, make sure points are available
		/// and BuildLinks() has been invoked.) Of the two methods below, one inserts
		/// a point coordinate and the other just makes room for cell links. Use this
		/// method only when the dataset is set as Editable.
		/// </summary>
		// Token: 0x0601C8FC RID: 116988 RVA: 0x00281F0C File Offset: 0x0028010C
		public long InsertNextLinkedPoint(IntPtr x, int numLinks)
		{
			return vtkPolyData.vtkPolyData_InsertNextLinkedPoint_64(base.GetCppThis(), x, numLinks);
		}

		// Token: 0x0601C8FD RID: 116989
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyData_IsA_65(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C8FE RID: 116990 RVA: 0x00281F30 File Offset: 0x00280130
		public override int IsA(string type)
		{
			return vtkPolyData.vtkPolyData_IsA_65(base.GetCppThis(), type);
		}

		// Token: 0x0601C8FF RID: 116991
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyData_IsEdge_66(HandleRef pThis, long p1, long p2);

		/// <summary>
		/// Determine whether two points form an edge. If they do, return non-zero.
		/// By definition PolyVertex and PolyLine have no edges since 1-dimensional
		/// edges are only found on cells 2D and higher.
		/// Edges are defined as 1-D boundary entities to cells.
		/// Make sure BuildLinks() has been called first.
		/// </summary>
		// Token: 0x0601C900 RID: 116992 RVA: 0x00281F50 File Offset: 0x00280150
		public int IsEdge(long p1, long p2)
		{
			return vtkPolyData.vtkPolyData_IsEdge_66(base.GetCppThis(), p1, p2);
		}

		// Token: 0x0601C901 RID: 116993
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyData_IsPointUsedByCell_67(HandleRef pThis, long ptId, long cellId);

		/// <summary>
		/// Determine whether a point is used by a particular cell. If it is, return
		/// non-zero. Make sure BuildCells() has been called first.
		/// </summary>
		// Token: 0x0601C902 RID: 116994 RVA: 0x00281F74 File Offset: 0x00280174
		public int IsPointUsedByCell(long ptId, long cellId)
		{
			return vtkPolyData.vtkPolyData_IsPointUsedByCell_67(base.GetCppThis(), ptId, cellId);
		}

		// Token: 0x0601C903 RID: 116995
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyData_IsTriangle_68(HandleRef pThis, int v1, int v2, int v3);

		/// <summary>
		/// Given three vertices, determine whether it's a triangle. Make sure
		/// BuildLinks() has been called first.
		/// </summary>
		// Token: 0x0601C904 RID: 116996 RVA: 0x00281F98 File Offset: 0x00280198
		public int IsTriangle(int v1, int v2, int v3)
		{
			return vtkPolyData.vtkPolyData_IsTriangle_68(base.GetCppThis(), v1, v2, v3);
		}

		// Token: 0x0601C905 RID: 116997
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyData_IsTypeOf_69([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C906 RID: 116998 RVA: 0x00281FBC File Offset: 0x002801BC
		public new static int IsTypeOf(string type)
		{
			return vtkPolyData.vtkPolyData_IsTypeOf_69(type);
		}

		// Token: 0x0601C907 RID: 116999
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolyData_NeedToBuildCells_70(HandleRef pThis);

		/// <summary>
		/// Check if BuildCells is needed.
		/// </summary>
		// Token: 0x0601C908 RID: 117000 RVA: 0x00281FD8 File Offset: 0x002801D8
		public bool NeedToBuildCells()
		{
			return vtkPolyData.vtkPolyData_NeedToBuildCells_70(base.GetCppThis()) != 0;
		}

		// Token: 0x0601C909 RID: 117001
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyData_NewInstance_72(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C90A RID: 117002 RVA: 0x00282000 File Offset: 0x00280200
		public new vtkPolyData NewInstance()
		{
			vtkPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyData.vtkPolyData_NewInstance_72(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C90B RID: 117003
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_RemoveCellReference_73(HandleRef pThis, long cellId);

		/// <summary>
		/// Remove all references to cell in cell structure. This means the links
		/// from the cell's points to the cell are deleted. Memory is not
		/// reclaimed. Use the method ResizeCellList() to resize the link list from
		/// a point to its using cells. (This operator assumes BuildLinks() has been
		/// called.) Use this method only when the dataset is set as Editable.
		/// </summary>
		// Token: 0x0601C90C RID: 117004 RVA: 0x0028205A File Offset: 0x0028025A
		public void RemoveCellReference(long cellId)
		{
			vtkPolyData.vtkPolyData_RemoveCellReference_73(base.GetCppThis(), cellId);
		}

		// Token: 0x0601C90D RID: 117005
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_RemoveDeletedCells_74(HandleRef pThis);

		/// <summary>
		/// The cells marked by calls to DeleteCell are stored in the Cell Array
		/// VTK_EMPTY_CELL, but they still exist in the cell arrays.  Calling
		/// RemoveDeletedCells will traverse the cell arrays and remove/compact the
		/// cell arrays as well as any cell data thus truly removing the cells from
		/// the polydata object. Use this method only when the dataset is set as
		/// Editable.
		/// </summary>
		// Token: 0x0601C90E RID: 117006 RVA: 0x0028206A File Offset: 0x0028026A
		public void RemoveDeletedCells()
		{
			vtkPolyData.vtkPolyData_RemoveDeletedCells_74(base.GetCppThis());
		}

		// Token: 0x0601C90F RID: 117007
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_RemoveGhostCells_75(HandleRef pThis);

		/// <summary>
		/// This method will remove any cell that is marked as ghost
		/// (has the vtkDataSetAttributes::DUPLICATECELL or
		/// the vtkDataSetAttributes::HIDDENCELL bit set).
		/// It does not remove unused points.
		/// </summary>
		// Token: 0x0601C910 RID: 117008 RVA: 0x00282079 File Offset: 0x00280279
		public void RemoveGhostCells()
		{
			vtkPolyData.vtkPolyData_RemoveGhostCells_75(base.GetCppThis());
		}

		// Token: 0x0601C911 RID: 117009
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_RemoveReferenceToCell_76(HandleRef pThis, long ptId, long cellId);

		/// <summary>
		/// Remove a reference to a cell in a particular point's link list. You may
		/// also consider using RemoveCellReference() to remove the references from
		/// all the cell's points to the cell. This operator does not reallocate
		/// memory; use the operator ResizeCellList() to do this if necessary. Use
		/// this method only when the dataset is set as Editable.
		/// </summary>
		// Token: 0x0601C912 RID: 117010 RVA: 0x00282088 File Offset: 0x00280288
		public void RemoveReferenceToCell(long ptId, long cellId)
		{
			vtkPolyData.vtkPolyData_RemoveReferenceToCell_76(base.GetCppThis(), ptId, cellId);
		}

		// Token: 0x0601C913 RID: 117011
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_ReplaceCell_77(HandleRef pThis, long cellId, HandleRef ids);

		/// <summary>
		/// Replace the points defining cell "cellId" with a new set of points. This
		/// operator is (typically) used when links from points to cells have not been
		/// built (i.e., BuildLinks() has not been executed). Use the operator
		/// ReplaceLinkedCell() to replace a cell when cell structure has been built. Use this
		/// method only when the dataset is set as Editable.
		/// @{
		/// </summary>
		// Token: 0x0601C914 RID: 117012 RVA: 0x0028209C File Offset: 0x0028029C
		public void ReplaceCell(long cellId, vtkIdList ids)
		{
			vtkPolyData.vtkPolyData_ReplaceCell_77(base.GetCppThis(), cellId, (ids == null) ? default(HandleRef) : ids.GetCppThis());
		}

		// Token: 0x0601C915 RID: 117013
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_ReplaceCell_78(HandleRef pThis, long cellId, int npts, IntPtr pts);

		/// <summary>
		/// Replace the points defining cell "cellId" with a new set of points. This
		/// operator is (typically) used when links from points to cells have not been
		/// built (i.e., BuildLinks() has not been executed). Use the operator
		/// ReplaceLinkedCell() to replace a cell when cell structure has been built. Use this
		/// method only when the dataset is set as Editable.
		/// @{
		/// </summary>
		// Token: 0x0601C916 RID: 117014 RVA: 0x002820CC File Offset: 0x002802CC
		public void ReplaceCell(long cellId, int npts, IntPtr pts)
		{
			vtkPolyData.vtkPolyData_ReplaceCell_78(base.GetCppThis(), cellId, npts, pts);
		}

		// Token: 0x0601C917 RID: 117015
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_ReplaceCellPoint_79(HandleRef pThis, long cellId, long oldPtId, long newPtId);

		/// <summary>
		/// Replace a point in the cell connectivity list with a different point. Use this
		/// method only when the dataset is set as Editable.
		///
		/// The version with cellPointIds avoids allocating/deallocating a vtkIdList at each call
		/// internally.
		///
		/// THIS METHOD IS THREAD SAFE IF BuildCells() IS FIRST CALLED FROM A SINGLE THREAD.
		/// </summary>
		// Token: 0x0601C918 RID: 117016 RVA: 0x002820DE File Offset: 0x002802DE
		public void ReplaceCellPoint(long cellId, long oldPtId, long newPtId)
		{
			vtkPolyData.vtkPolyData_ReplaceCellPoint_79(base.GetCppThis(), cellId, oldPtId, newPtId);
		}

		// Token: 0x0601C919 RID: 117017
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_ReplaceCellPoint_80(HandleRef pThis, long cellId, long oldPtId, long newPtId, HandleRef cellPointIds);

		/// <summary>
		/// Replace a point in the cell connectivity list with a different point. Use this
		/// method only when the dataset is set as Editable.
		///
		/// The version with cellPointIds avoids allocating/deallocating a vtkIdList at each call
		/// internally.
		///
		/// THIS METHOD IS THREAD SAFE IF BuildCells() IS FIRST CALLED FROM A SINGLE THREAD.
		/// </summary>
		// Token: 0x0601C91A RID: 117018 RVA: 0x002820F0 File Offset: 0x002802F0
		public void ReplaceCellPoint(long cellId, long oldPtId, long newPtId, vtkIdList cellPointIds)
		{
			vtkPolyData.vtkPolyData_ReplaceCellPoint_80(base.GetCppThis(), cellId, oldPtId, newPtId, (cellPointIds == null) ? default(HandleRef) : cellPointIds.GetCppThis());
		}

		// Token: 0x0601C91B RID: 117019
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_ReplaceLinkedCell_81(HandleRef pThis, long cellId, int npts, IntPtr pts);

		/// <summary>
		/// Replace one cell with another in cell structure. This operator updates
		/// the connectivity list and the point's link list. It does not delete
		/// references to the old cell in the point's link list. Use the operator
		/// RemoveCellReference() to delete all references from points to (old)
		/// cell.  You may also want to consider using the operator ResizeCellList()
		/// if the link list is changing size. Use this method only when the dataset
		/// is set as Editable.
		/// </summary>
		// Token: 0x0601C91C RID: 117020 RVA: 0x00282124 File Offset: 0x00280324
		public void ReplaceLinkedCell(long cellId, int npts, IntPtr pts)
		{
			vtkPolyData.vtkPolyData_ReplaceLinkedCell_81(base.GetCppThis(), cellId, npts, pts);
		}

		// Token: 0x0601C91D RID: 117021
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_Reset_82(HandleRef pThis);

		/// <summary>
		/// Begin inserting data all over again. Memory is not freed but otherwise
		/// objects are returned to their initial state.
		/// </summary>
		// Token: 0x0601C91E RID: 117022 RVA: 0x00282136 File Offset: 0x00280336
		public void Reset()
		{
			vtkPolyData.vtkPolyData_Reset_82(base.GetCppThis());
		}

		// Token: 0x0601C91F RID: 117023
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_ResizeCellList_83(HandleRef pThis, long ptId, int size);

		/// <summary>
		/// Resize the list of cells using a particular point. (This operator
		/// assumes that BuildLinks() has been called.) Use this method only when
		/// the dataset is set as Editable.
		/// </summary>
		// Token: 0x0601C920 RID: 117024 RVA: 0x00282145 File Offset: 0x00280345
		public void ResizeCellList(long ptId, int size)
		{
			vtkPolyData.vtkPolyData_ResizeCellList_83(base.GetCppThis(), ptId, size);
		}

		// Token: 0x0601C921 RID: 117025
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_ReverseCell_84(HandleRef pThis, long cellId);

		/// <summary>
		/// Reverse the order of point ids defining the cell. Use this
		/// method only when the dataset is set as Editable.
		/// </summary>
		// Token: 0x0601C922 RID: 117026 RVA: 0x00282156 File Offset: 0x00280356
		public void ReverseCell(long cellId)
		{
			vtkPolyData.vtkPolyData_ReverseCell_84(base.GetCppThis(), cellId);
		}

		// Token: 0x0601C923 RID: 117027
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyData_SafeDownCast_85(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C924 RID: 117028 RVA: 0x00282168 File Offset: 0x00280368
		public new static vtkPolyData SafeDownCast(vtkObjectBase o)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyData.vtkPolyData_SafeDownCast_85((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x0601C925 RID: 117029
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_SetLines_86(HandleRef pThis, HandleRef l);

		/// <summary>
		/// Set the cell array defining lines.
		/// </summary>
		// Token: 0x0601C926 RID: 117030 RVA: 0x002821E8 File Offset: 0x002803E8
		public void SetLines(vtkCellArray l)
		{
			vtkPolyData.vtkPolyData_SetLines_86(base.GetCppThis(), (l == null) ? default(HandleRef) : l.GetCppThis());
		}

		// Token: 0x0601C927 RID: 117031
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_SetLinks_87(HandleRef pThis, HandleRef links);

		/// <summary>
		/// Set/Get the links that you created possibly without using BuildLinks.
		///
		/// Note: Only vtkCellLinks are currently supported.
		/// </summary>
		// Token: 0x0601C928 RID: 117032 RVA: 0x00282218 File Offset: 0x00280418
		public virtual void SetLinks(vtkAbstractCellLinks links)
		{
			vtkPolyData.vtkPolyData_SetLinks_87(base.GetCppThis(), (links == null) ? default(HandleRef) : links.GetCppThis());
		}

		// Token: 0x0601C929 RID: 117033
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_SetPolys_88(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set the cell array defining polygons.
		/// </summary>
		// Token: 0x0601C92A RID: 117034 RVA: 0x00282248 File Offset: 0x00280448
		public void SetPolys(vtkCellArray p)
		{
			vtkPolyData.vtkPolyData_SetPolys_88(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0601C92B RID: 117035
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_SetStrips_89(HandleRef pThis, HandleRef s);

		/// <summary>
		/// Set the cell array defining triangle strips.
		/// </summary>
		// Token: 0x0601C92C RID: 117036 RVA: 0x00282278 File Offset: 0x00280478
		public void SetStrips(vtkCellArray s)
		{
			vtkPolyData.vtkPolyData_SetStrips_89(base.GetCppThis(), (s == null) ? default(HandleRef) : s.GetCppThis());
		}

		// Token: 0x0601C92D RID: 117037
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_SetVerts_90(HandleRef pThis, HandleRef v);

		/// <summary>
		/// Set the cell array defining vertices.
		/// </summary>
		// Token: 0x0601C92E RID: 117038 RVA: 0x002822A8 File Offset: 0x002804A8
		public void SetVerts(vtkCellArray v)
		{
			vtkPolyData.vtkPolyData_SetVerts_90(base.GetCppThis(), (v == null) ? default(HandleRef) : v.GetCppThis());
		}

		// Token: 0x0601C92F RID: 117039
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_ShallowCopy_91(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Shallow and Deep copy.
		/// </summary>
		// Token: 0x0601C930 RID: 117040 RVA: 0x002822D8 File Offset: 0x002804D8
		public override void ShallowCopy(vtkDataObject src)
		{
			vtkPolyData.vtkPolyData_ShallowCopy_91(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0601C931 RID: 117041
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyData_Squeeze_92(HandleRef pThis);

		/// <summary>
		/// Recover extra allocated memory when creating data whose initial size
		/// is unknown. Examples include using the InsertNextCell() method, or
		/// when using the CellArray::EstimateSize() method to create vertices,
		/// lines, polygons, or triangle strips.
		/// </summary>
		// Token: 0x0601C932 RID: 117042 RVA: 0x00282307 File Offset: 0x00280507
		public override void Squeeze()
		{
			vtkPolyData.vtkPolyData_Squeeze_92(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E3F RID: 7743
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E40 RID: 7744
		public new static readonly string MRClassNameKey = "class vtkPolyData";

		/// <summary>
		/// Scalar field critical point classification (for manifold 2D meshes).
		/// Reference: J. Milnor "Morse Theory", Princeton University Press, 1963.
		///
		/// Given a pointId and an attribute representing a scalar field, this member
		/// returns the index of the critical point:
		/// vtkPolyData::MINIMUM (index 0): local minimum;
		/// vtkPolyData::SADDLE  (index 1): local saddle;
		/// vtkPolyData::MAXIMUM (index 2): local maximum.
		///
		/// Other returned values are:
		/// vtkPolyData::REGULAR_POINT: regular point (the gradient does not vanish);
		/// vtkPolyData::ERR_NON_MANIFOLD_STAR: the star of the considered vertex is
		/// not manifold (could not evaluate the index)
		/// vtkPolyData::ERR_INCORRECT_FIELD: the number of entries in the scalar field
		/// array is different form the number of vertices in the mesh.
		/// vtkPolyData::ERR_NO_SUCH_FIELD: the specified scalar field does not exist.
		/// </summary>
		// Token: 0x02000AA0 RID: 2720
		public enum ERR_INCORRECT_FIELD_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04001E42 RID: 7746
			ERR_INCORRECT_FIELD = -3,
			/// <summary>enum member</summary>
			// Token: 0x04001E43 RID: 7747
			ERR_NON_MANIFOLD_STAR,
			/// <summary>enum member</summary>
			// Token: 0x04001E44 RID: 7748
			ERR_NO_SUCH_FIELD = -4,
			/// <summary>enum member</summary>
			// Token: 0x04001E45 RID: 7749
			MAXIMUM = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001E46 RID: 7750
			MINIMUM = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001E47 RID: 7751
			REGULAR_POINT = -1,
			/// <summary>enum member</summary>
			// Token: 0x04001E48 RID: 7752
			SADDLE = 1
		}
	}
}
