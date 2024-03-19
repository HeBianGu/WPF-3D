using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGenericDataSet
	/// </summary>
	/// <remarks>
	///    defines dataset interface
	///
	/// In VTK, spatial-temporal data is defined in terms of a dataset. The
	/// dataset consists of geometry (e.g., points), topology (e.g., cells), and
	/// attributes (e.g., scalars, vectors, etc.) vtkGenericDataSet is an abstract
	/// class defining this abstraction.
	///
	/// Since vtkGenericDataSet provides a general interface to manipulate data,
	/// algorithms that process it tend to be slower than those specialized for a
	/// particular data type. For this reason, there are concrete, non-abstract
	/// subclasses that represent and provide access to data more efficiently.
	/// Note that filters to process this dataset type are currently found in the
	/// VTK/GenericFiltering/ subdirectory.
	///
	/// Unlike the vtkDataSet class, vtkGenericDataSet provides a more flexible
	/// interface including support for iterators. vtkGenericDataSet is also
	/// designed to interface VTK to external simulation packages without the
	/// penalty of copying memory (see VTK/GenericFiltering/README.html) for
	/// more information. Thus vtkGenericDataSet plays a central role in the
	/// adaptor framework.
	///
	/// Please note that this class introduces the concepts of "boundary cells".
	/// This refers to the boundaries of a cell (e.g., face of a tetrahedron)
	/// which may in turn be represented as a cell. Boundary cells are derivative
	/// topological features of cells, and are therefore never explicitly
	/// represented in the dataset. Often in visualization algorithms, looping
	/// over boundaries (edges or faces) is employed, while the actual dataset
	/// cells may not traversed. Thus there are methods to loop over these
	/// boundary cells.
	///
	/// Finally, as a point of clarification, points are not the same as vertices.
	/// Vertices refer to points, and points specify a position is space. Vertices
	/// are a type of 0-D cell. Also, the concept of a DOFNode, which is where
	/// coefficients for higher-order cells are kept, is a new concept introduced
	/// by the adaptor framework (see vtkGenericAdaptorCell for more information).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGenericAdaptorCell vtkDataSet
	/// </seealso>
	// Token: 0x02000A4F RID: 2639
	public abstract class vtkGenericDataSet : vtkDataObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B8EE RID: 112878 RVA: 0x00269067 File Offset: 0x00267267
		static vtkGenericDataSet()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericDataSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericDataSet"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B8EF RID: 112879 RVA: 0x0026908F File Offset: 0x0026728F
		public vtkGenericDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B8F0 RID: 112880 RVA: 0x0026909D File Offset: 0x0026729D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B8F1 RID: 112881
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericDataSet_ComputeBounds_01(HandleRef pThis);

		/// <summary>
		/// Compute the geometry bounding box.
		/// </summary>
		// Token: 0x0601B8F2 RID: 112882 RVA: 0x002690A8 File Offset: 0x002672A8
		public virtual void ComputeBounds()
		{
			vtkGenericDataSet.vtkGenericDataSet_ComputeBounds_01(base.GetCppThis());
		}

		// Token: 0x0601B8F3 RID: 112883
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericDataSet_FindCell_02(HandleRef pThis, IntPtr x, HandleRef cell, double tol2, ref int subId, IntPtr pcoords);

		/// <summary>
		/// Locate the closest cell to position `x' (global coordinates) with
		/// respect to a tolerance squared `tol2' and an initial guess `cell' (if
		/// valid). The result consists in the `cell', the `subId' of the sub-cell
		/// (0 if primary cell), the parametric coordinates `pcoord' of the
		/// position. It returns whether the position is inside the cell or
		/// not (boolean). Tolerance is used to control how close the point is to be
		/// considered "in" the cell.
		/// THIS METHOD IS NOT THREAD SAFE.
		/// \pre not_empty: GetNumberOfCells()&gt;0
		/// \pre cell_exists: cell!=0
		/// \pre positive_tolerance: tol2&gt;0
		/// </summary>
		// Token: 0x0601B8F4 RID: 112884 RVA: 0x002690B8 File Offset: 0x002672B8
		public virtual int FindCell(IntPtr x, vtkGenericCellIterator cell, double tol2, ref int subId, IntPtr pcoords)
		{
			return vtkGenericDataSet.vtkGenericDataSet_FindCell_02(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), tol2, ref subId, pcoords);
		}

		// Token: 0x0601B8F5 RID: 112885
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericDataSet_FindPoint_03(HandleRef pThis, IntPtr x, HandleRef p);

		/// <summary>
		/// Locate the closest point `p' to position `x' (global coordinates).
		/// \pre not_empty: GetNumberOfPoints()&gt;0
		/// \pre p_exists: p!=0
		/// </summary>
		// Token: 0x0601B8F6 RID: 112886 RVA: 0x002690F4 File Offset: 0x002672F4
		public virtual void FindPoint(IntPtr x, vtkGenericPointIterator p)
		{
			vtkGenericDataSet.vtkGenericDataSet_FindPoint_03(base.GetCppThis(), x, (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0601B8F7 RID: 112887
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkGenericDataSet_GetActualMemorySize_04(HandleRef pThis);

		/// <summary>
		/// Actual size of the data in kibibytes (1024 bytes); only valid after the pipeline has
		/// updated. It is guaranteed to be greater than or equal to the memory
		/// required to represent the data.
		/// </summary>
		// Token: 0x0601B8F8 RID: 112888 RVA: 0x00269124 File Offset: 0x00267324
		public override uint GetActualMemorySize()
		{
			return vtkGenericDataSet.vtkGenericDataSet_GetActualMemorySize_04(base.GetCppThis());
		}

		// Token: 0x0601B8F9 RID: 112889
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataSet_GetAttributes_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the collection of attributes associated with this dataset.
		/// </summary>
		// Token: 0x0601B8FA RID: 112890 RVA: 0x00269144 File Offset: 0x00267344
		public virtual vtkGenericAttributeCollection GetAttributes()
		{
			vtkGenericAttributeCollection vtkGenericAttributeCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericDataSet.vtkGenericDataSet_GetAttributes_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericAttributeCollection = (vtkGenericAttributeCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericAttributeCollection.Register(null);
				}
			}
			return vtkGenericAttributeCollection;
		}

		// Token: 0x0601B8FB RID: 112891
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataSet_GetAttributes_06(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the attributes of the data object of the specified
		/// attribute type. The type may be:
		/// &lt;ul&gt;
		/// &lt;li&gt;POINT  - Defined in vtkDataSet subclasses.
		/// &lt;li&gt;CELL   - Defined in vtkDataSet subclasses.
		/// &lt;li&gt;VERTEX - Defined in vtkGraph subclasses.
		/// &lt;li&gt;EDGE   - Defined in vtkGraph subclasses.
		/// &lt;li&gt;ROW    - Defined in vtkTable.
		/// &lt;/ul&gt;
		/// The other attribute type, FIELD, will return nullptr since
		/// field data is stored as a vtkFieldData instance, not a
		/// vtkDataSetAttributes instance. To retrieve field data, use
		/// GetAttributesAsFieldData.
		/// </summary>
		// Token: 0x0601B8FC RID: 112892 RVA: 0x002691B4 File Offset: 0x002673B4
		public override vtkDataSetAttributes GetAttributes(int type)
		{
			vtkDataSetAttributes vtkDataSetAttributes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericDataSet.vtkGenericDataSet_GetAttributes_06(base.GetCppThis(), type, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetAttributes = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetAttributes.Register(null);
				}
			}
			return vtkDataSetAttributes;
		}

		// Token: 0x0601B8FD RID: 112893
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataSet_GetBounds_07(HandleRef pThis);

		/// <summary>
		/// Return a pointer to the geometry bounding box in the form
		/// (xmin,xmax, ymin,ymax, zmin,zmax).
		/// The return value is VOLATILE.
		/// \post result_exists: result!=0
		/// </summary>
		// Token: 0x0601B8FE RID: 112894 RVA: 0x00269224 File Offset: 0x00267424
		public virtual IntPtr GetBounds()
		{
			return vtkGenericDataSet.vtkGenericDataSet_GetBounds_07(base.GetCppThis());
		}

		// Token: 0x0601B8FF RID: 112895
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericDataSet_GetBounds_08(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Return the geometry bounding box in global coordinates in
		/// the form (xmin,xmax, ymin,ymax, zmin,zmax) in the `bounds' array.
		/// </summary>
		// Token: 0x0601B900 RID: 112896 RVA: 0x00269243 File Offset: 0x00267443
		public virtual void GetBounds(IntPtr bounds)
		{
			vtkGenericDataSet.vtkGenericDataSet_GetBounds_08(base.GetCppThis(), bounds);
		}

		// Token: 0x0601B901 RID: 112897
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericDataSet_GetCellDimension_09(HandleRef pThis);

		/// <summary>
		/// Return -1 if the dataset is explicitly defined by cells of varying
		/// dimensions or if there are no cells. If the dataset is explicitly
		/// defined by cells of a unique dimension, return this dimension.
		/// \post valid_range: (result&gt;=-1) &amp;&amp; (result&lt;=3)
		/// </summary>
		// Token: 0x0601B902 RID: 112898 RVA: 0x00269254 File Offset: 0x00267454
		public virtual int GetCellDimension()
		{
			return vtkGenericDataSet.vtkGenericDataSet_GetCellDimension_09(base.GetCppThis());
		}

		// Token: 0x0601B903 RID: 112899
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericDataSet_GetCellTypes_10(HandleRef pThis, HandleRef types);

		/// <summary>
		/// Get a list of types of cells in a dataset. The list consists of an array
		/// of types (not necessarily in any order), with a single entry per type.
		/// For example a dataset 5 triangles, 3 lines, and 100 hexahedra would
		/// result a list of three entries, corresponding to the types VTK_TRIANGLE,
		/// VTK_LINE, and VTK_HEXAHEDRON.
		/// THIS METHOD IS THREAD SAFE IF FIRST CALLED FROM A SINGLE THREAD AND
		/// THE DATASET IS NOT MODIFIED
		/// \pre types_exist: types!=0
		/// </summary>
		// Token: 0x0601B904 RID: 112900 RVA: 0x00269274 File Offset: 0x00267474
		public virtual void GetCellTypes(vtkCellTypes types)
		{
			vtkGenericDataSet.vtkGenericDataSet_GetCellTypes_10(base.GetCppThis(), (types == null) ? default(HandleRef) : types.GetCppThis());
		}

		// Token: 0x0601B905 RID: 112901
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataSet_GetCenter_11(HandleRef pThis);

		/// <summary>
		/// Get the center of the bounding box in global coordinates.
		/// The return value is VOLATILE.
		/// \post result_exists: result!=0
		/// </summary>
		// Token: 0x0601B906 RID: 112902 RVA: 0x002692A4 File Offset: 0x002674A4
		public virtual IntPtr GetCenter()
		{
			return vtkGenericDataSet.vtkGenericDataSet_GetCenter_11(base.GetCppThis());
		}

		// Token: 0x0601B907 RID: 112903
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericDataSet_GetCenter_12(HandleRef pThis, IntPtr center);

		/// <summary>
		/// Get the center of the bounding box in global coordinates.
		/// </summary>
		// Token: 0x0601B908 RID: 112904 RVA: 0x002692C3 File Offset: 0x002674C3
		public virtual void GetCenter(IntPtr center)
		{
			vtkGenericDataSet.vtkGenericDataSet_GetCenter_12(base.GetCppThis(), center);
		}

		// Token: 0x0601B909 RID: 112905
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataSet_GetData_13(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601B90A RID: 112906 RVA: 0x002692D4 File Offset: 0x002674D4
		public new static vtkGenericDataSet GetData(vtkInformation info)
		{
			vtkGenericDataSet vtkGenericDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericDataSet.vtkGenericDataSet_GetData_13((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericDataSet = (vtkGenericDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericDataSet.Register(null);
				}
			}
			return vtkGenericDataSet;
		}

		// Token: 0x0601B90B RID: 112907
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataSet_GetData_14(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601B90C RID: 112908 RVA: 0x00269354 File Offset: 0x00267554
		public new static vtkGenericDataSet GetData(vtkInformationVector v, int i)
		{
			vtkGenericDataSet vtkGenericDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericDataSet.vtkGenericDataSet_GetData_14((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericDataSet = (vtkGenericDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericDataSet.Register(null);
				}
			}
			return vtkGenericDataSet;
		}

		// Token: 0x0601B90D RID: 112909
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericDataSet_GetDataObjectType_15(HandleRef pThis);

		/// <summary>
		/// Return the type of data object.
		/// </summary>
		// Token: 0x0601B90E RID: 112910 RVA: 0x002693D4 File Offset: 0x002675D4
		public override int GetDataObjectType()
		{
			return vtkGenericDataSet.vtkGenericDataSet_GetDataObjectType_15(base.GetCppThis());
		}

		// Token: 0x0601B90F RID: 112911
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericDataSet_GetEstimatedSize_16(HandleRef pThis);

		/// <summary>
		/// Estimated size needed after tessellation (or special operation)
		/// </summary>
		// Token: 0x0601B910 RID: 112912 RVA: 0x002693F4 File Offset: 0x002675F4
		public virtual long GetEstimatedSize()
		{
			return vtkGenericDataSet.vtkGenericDataSet_GetEstimatedSize_16(base.GetCppThis());
		}

		// Token: 0x0601B911 RID: 112913
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGenericDataSet_GetLength_17(HandleRef pThis);

		/// <summary>
		/// Return the length of the diagonal of the bounding box.
		/// \post positive_result: result&gt;=0
		/// </summary>
		// Token: 0x0601B912 RID: 112914 RVA: 0x00269414 File Offset: 0x00267614
		public virtual double GetLength()
		{
			return vtkGenericDataSet.vtkGenericDataSet_GetLength_17(base.GetCppThis());
		}

		// Token: 0x0601B913 RID: 112915
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkGenericDataSet_GetMTime_18(HandleRef pThis);

		/// <summary>
		/// Datasets are composite objects and need to check each part for their
		/// modified time.
		/// </summary>
		// Token: 0x0601B914 RID: 112916 RVA: 0x00269434 File Offset: 0x00267634
		public override ulong GetMTime()
		{
			return vtkGenericDataSet.vtkGenericDataSet_GetMTime_18(base.GetCppThis());
		}

		// Token: 0x0601B915 RID: 112917
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericDataSet_GetNumberOfCells_19(HandleRef pThis, int dim);

		/// <summary>
		/// Return the number of cells that explicitly define the dataset. See
		/// NewCellIterator() for more details.
		/// \pre valid_dim_range: (dim&gt;=-1) &amp;&amp; (dim&lt;=3)
		/// \post positive_result: result&gt;=0
		/// </summary>
		// Token: 0x0601B916 RID: 112918 RVA: 0x00269454 File Offset: 0x00267654
		public virtual long GetNumberOfCells(int dim)
		{
			return vtkGenericDataSet.vtkGenericDataSet_GetNumberOfCells_19(base.GetCppThis(), dim);
		}

		// Token: 0x0601B917 RID: 112919
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericDataSet_GetNumberOfElements_20(HandleRef pThis, int type);

		/// <summary>
		/// Get the number of elements for a specific attribute type (POINT, CELL, etc.).
		/// </summary>
		// Token: 0x0601B918 RID: 112920 RVA: 0x00269474 File Offset: 0x00267674
		public override long GetNumberOfElements(int type)
		{
			return vtkGenericDataSet.vtkGenericDataSet_GetNumberOfElements_20(base.GetCppThis(), type);
		}

		// Token: 0x0601B919 RID: 112921
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericDataSet_GetNumberOfGenerationsFromBase_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK type and print macros.
		/// </summary>
		// Token: 0x0601B91A RID: 112922 RVA: 0x00269494 File Offset: 0x00267694
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGenericDataSet.vtkGenericDataSet_GetNumberOfGenerationsFromBase_21(base.GetCppThis(), type);
		}

		// Token: 0x0601B91B RID: 112923
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericDataSet_GetNumberOfGenerationsFromBaseType_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK type and print macros.
		/// </summary>
		// Token: 0x0601B91C RID: 112924 RVA: 0x002694B4 File Offset: 0x002676B4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGenericDataSet.vtkGenericDataSet_GetNumberOfGenerationsFromBaseType_22(type);
		}

		// Token: 0x0601B91D RID: 112925
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericDataSet_GetNumberOfPoints_23(HandleRef pThis);

		/// <summary>
		/// Return the number of points composing the dataset. See NewPointIterator()
		/// for more details.
		/// \post positive_result: result&gt;=0
		/// </summary>
		// Token: 0x0601B91E RID: 112926 RVA: 0x002694D0 File Offset: 0x002676D0
		public virtual long GetNumberOfPoints()
		{
			return vtkGenericDataSet.vtkGenericDataSet_GetNumberOfPoints_23(base.GetCppThis());
		}

		// Token: 0x0601B91F RID: 112927
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataSet_GetTessellator_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get a cell tessellator if cells must be tessellated during
		/// processing.
		/// \pre tessellator_exists: tessellator!=0
		/// </summary>
		// Token: 0x0601B920 RID: 112928 RVA: 0x002694F0 File Offset: 0x002676F0
		public virtual vtkGenericCellTessellator GetTessellator()
		{
			vtkGenericCellTessellator vtkGenericCellTessellator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericDataSet.vtkGenericDataSet_GetTessellator_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericCellTessellator = (vtkGenericCellTessellator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericCellTessellator.Register(null);
				}
			}
			return vtkGenericCellTessellator;
		}

		// Token: 0x0601B921 RID: 112929
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericDataSet_IsA_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK type and print macros.
		/// </summary>
		// Token: 0x0601B922 RID: 112930 RVA: 0x00269560 File Offset: 0x00267760
		public override int IsA(string type)
		{
			return vtkGenericDataSet.vtkGenericDataSet_IsA_25(base.GetCppThis(), type);
		}

		// Token: 0x0601B923 RID: 112931
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericDataSet_IsTypeOf_26([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK type and print macros.
		/// </summary>
		// Token: 0x0601B924 RID: 112932 RVA: 0x00269580 File Offset: 0x00267780
		public new static int IsTypeOf(string type)
		{
			return vtkGenericDataSet.vtkGenericDataSet_IsTypeOf_26(type);
		}

		// Token: 0x0601B925 RID: 112933
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataSet_NewBoundaryIterator_27(HandleRef pThis, int dim, int exteriorOnly, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return an iterator to traverse cell boundaries of dimension `dim' (or
		/// all dimensions if -1) of the dataset.  If `exteriorOnly' is true, only
		/// the exterior cell boundaries of the dataset will be returned, otherwise
		/// it will return exterior and interior cell boundaries. The user is
		/// responsible for deleting the iterator.
		/// \pre valid_dim_range: (dim&gt;=-1) &amp;&amp; (dim&lt;=2)
		/// \post result_exists: result!=0
		/// </summary>
		// Token: 0x0601B926 RID: 112934 RVA: 0x0026959C File Offset: 0x0026779C
		public virtual vtkGenericCellIterator NewBoundaryIterator(int dim, int exteriorOnly)
		{
			vtkGenericCellIterator vtkGenericCellIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericDataSet.vtkGenericDataSet_NewBoundaryIterator_27(base.GetCppThis(), dim, exteriorOnly, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericCellIterator = (vtkGenericCellIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericCellIterator.Register(null);
				}
			}
			return vtkGenericCellIterator;
		}

		// Token: 0x0601B927 RID: 112935
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataSet_NewCellIterator_28(HandleRef pThis, int dim, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return an iterator to traverse cells of dimension `dim' (or all
		/// dimensions if -1) that explicitly define the dataset. For instance, it
		/// will return only tetrahedra if the mesh is defined by tetrahedra. If the
		/// mesh is composed of two parts, one with tetrahedra and another part with
		/// triangles, it will return both, but will not return the boundary edges
		/// and vertices of these cells. The user is responsible for deleting the
		/// iterator.
		/// \pre valid_dim_range: (dim&gt;=-1) &amp;&amp; (dim&lt;=3)
		/// \post result_exists: result!=0
		/// </summary>
		// Token: 0x0601B928 RID: 112936 RVA: 0x00269610 File Offset: 0x00267810
		public virtual vtkGenericCellIterator NewCellIterator(int dim)
		{
			vtkGenericCellIterator vtkGenericCellIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericDataSet.vtkGenericDataSet_NewCellIterator_28(base.GetCppThis(), dim, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericCellIterator = (vtkGenericCellIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericCellIterator.Register(null);
				}
			}
			return vtkGenericCellIterator;
		}

		// Token: 0x0601B929 RID: 112937
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataSet_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK type and print macros.
		/// </summary>
		// Token: 0x0601B92A RID: 112938 RVA: 0x00269680 File Offset: 0x00267880
		public new vtkGenericDataSet NewInstance()
		{
			vtkGenericDataSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericDataSet.vtkGenericDataSet_NewInstance_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B92B RID: 112939
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataSet_NewPointIterator_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return an iterator to traverse the points composing the dataset; they
		/// can be points that define a cell (corner points) or isolated points.
		/// The user is responsible for deleting the iterator.
		/// \post result_exists: result!=0
		/// </summary>
		// Token: 0x0601B92C RID: 112940 RVA: 0x002696DC File Offset: 0x002678DC
		public virtual vtkGenericPointIterator NewPointIterator()
		{
			vtkGenericPointIterator vtkGenericPointIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericDataSet.vtkGenericDataSet_NewPointIterator_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericPointIterator = (vtkGenericPointIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericPointIterator.Register(null);
				}
			}
			return vtkGenericPointIterator;
		}

		// Token: 0x0601B92D RID: 112941
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericDataSet_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK type and print macros.
		/// </summary>
		// Token: 0x0601B92E RID: 112942 RVA: 0x0026974C File Offset: 0x0026794C
		public new static vtkGenericDataSet SafeDownCast(vtkObjectBase o)
		{
			vtkGenericDataSet vtkGenericDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericDataSet.vtkGenericDataSet_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericDataSet = (vtkGenericDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericDataSet.Register(null);
				}
			}
			return vtkGenericDataSet;
		}

		// Token: 0x0601B92F RID: 112943
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericDataSet_SetTessellator_32(HandleRef pThis, HandleRef tessellator);

		/// <summary>
		/// Set/Get a cell tessellator if cells must be tessellated during
		/// processing.
		/// \pre tessellator_exists: tessellator!=0
		/// </summary>
		// Token: 0x0601B930 RID: 112944 RVA: 0x002697CC File Offset: 0x002679CC
		public virtual void SetTessellator(vtkGenericCellTessellator tessellator)
		{
			vtkGenericDataSet.vtkGenericDataSet_SetTessellator_32(base.GetCppThis(), (tessellator == null) ? default(HandleRef) : tessellator.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D92 RID: 7570
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericDataSet";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D93 RID: 7571
		public new static readonly string MRClassNameKey = "class vtkGenericDataSet";
	}
}
