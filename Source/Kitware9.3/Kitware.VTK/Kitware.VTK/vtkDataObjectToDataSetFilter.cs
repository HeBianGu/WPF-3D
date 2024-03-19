using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataObjectToDataSetFilter
	/// </summary>
	/// <remarks>
	///    map field data to concrete dataset
	///
	/// vtkDataObjectToDataSetFilter is an class that maps a data object (i.e., a field)
	/// into a concrete dataset, i.e., gives structure to the field by defining a
	/// geometry and topology.
	///
	/// To use this filter you associate components in the input field data with
	/// portions of the output dataset. (A component is an array of values from
	/// the field.) For example, you would specify x-y-z points by assigning
	/// components from the field for the x, then y, then z values of the points.
	/// You may also have to specify component ranges (for each z-y-z) to make
	/// sure that the number of x, y, and z values is the same. Also, you may
	/// want to normalize the components which helps distribute the data
	/// uniformly. Once you've setup the filter to combine all the pieces of
	/// data into a specified dataset (the geometry, topology, point and cell
	/// data attributes), the various output methods (e.g., GetPolyData()) are
	/// used to retrieve the final product.
	///
	/// This filter is often used in conjunction with
	/// vtkFieldDataToAttributeDataFilter.  vtkFieldDataToAttributeDataFilter
	/// takes field data and transforms it into attribute data (e.g., point and
	/// cell data attributes such as scalars and vectors).  To do this, use this
	/// filter which constructs a concrete dataset and passes the input data
	/// object field data to its output. and then use
	/// vtkFieldDataToAttributeDataFilter to generate the attribute data associated
	/// with the dataset.
	///
	/// @warning
	/// Make sure that the data you extract is consistent. That is, if you have N
	/// points, extract N x, y, and z components. Also, all the information
	/// necessary to define a dataset must be given. For example, vtkPolyData
	/// requires points at a minimum; vtkStructuredPoints requires setting the
	/// dimensions; vtkStructuredGrid requires defining points and dimensions;
	/// vtkUnstructuredGrid requires setting points; and vtkRectilinearGrid
	/// requires that you define the x, y, and z-coordinate arrays (by specifying
	/// points) as well as the dimensions.
	///
	/// @warning
	/// If you wish to create a dataset of just points (i.e., unstructured points
	/// dataset), create vtkPolyData consisting of points. There will be no cells
	/// in such a dataset.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDataObject vtkFieldData vtkDataSet vtkPolyData vtkStructuredPoints
	/// vtkStructuredGrid vtkUnstructuredGrid vtkRectilinearGrid
	/// vtkDataSetAttributes vtkDataArray
	/// </seealso>
	// Token: 0x02000956 RID: 2390
	public class vtkDataObjectToDataSetFilter : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018C9B RID: 101531 RVA: 0x00229A4F File Offset: 0x00227C4F
		static vtkDataObjectToDataSetFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataObjectToDataSetFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataObjectToDataSetFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018C9C RID: 101532 RVA: 0x00229A77 File Offset: 0x00227C77
		public vtkDataObjectToDataSetFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018C9D RID: 101533
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018C9E RID: 101534 RVA: 0x00229A88 File Offset: 0x00227C88
		public new static vtkDataObjectToDataSetFilter New()
		{
			vtkDataObjectToDataSetFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObjectToDataSetFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018C9F RID: 101535 RVA: 0x00229ADC File Offset: 0x00227CDC
		public vtkDataObjectToDataSetFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018CA0 RID: 101536 RVA: 0x00229B20 File Offset: 0x00227D20
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018CA1 RID: 101537
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_DefaultNormalizeOff_01(HandleRef pThis);

		/// <summary>
		/// Set the default Normalize() flag for those methods setting a default
		/// Normalize value (e.g., SetPointComponent).
		/// </summary>
		// Token: 0x06018CA2 RID: 101538 RVA: 0x00229B2B File Offset: 0x00227D2B
		public virtual void DefaultNormalizeOff()
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_DefaultNormalizeOff_01(base.GetCppThis());
		}

		// Token: 0x06018CA3 RID: 101539
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_DefaultNormalizeOn_02(HandleRef pThis);

		/// <summary>
		/// Set the default Normalize() flag for those methods setting a default
		/// Normalize value (e.g., SetPointComponent).
		/// </summary>
		// Token: 0x06018CA4 RID: 101540 RVA: 0x00229B3A File Offset: 0x00227D3A
		public virtual void DefaultNormalizeOn()
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_DefaultNormalizeOn_02(base.GetCppThis());
		}

		// Token: 0x06018CA5 RID: 101541
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectToDataSetFilter_GetCellConnectivityComponentArrayComponent_03(HandleRef pThis);

		/// <summary>
		/// Define cell types and cell connectivity when creating unstructured grid
		/// data.  These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of cell types (an integer value per cell), and another
		/// array consisting (for each cell) of a number of points per cell, and
		/// then the cell connectivity. (This is the vtk file format described in
		/// in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018CA6 RID: 101542 RVA: 0x00229B4C File Offset: 0x00227D4C
		public int GetCellConnectivityComponentArrayComponent()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetCellConnectivityComponentArrayComponent_03(base.GetCppThis());
		}

		// Token: 0x06018CA7 RID: 101543
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetCellConnectivityComponentArrayName_04(HandleRef pThis);

		/// <summary>
		/// Define cell types and cell connectivity when creating unstructured grid
		/// data.  These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of cell types (an integer value per cell), and another
		/// array consisting (for each cell) of a number of points per cell, and
		/// then the cell connectivity. (This is the vtk file format described in
		/// in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018CA8 RID: 101544 RVA: 0x00229B6C File Offset: 0x00227D6C
		public string GetCellConnectivityComponentArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetCellConnectivityComponentArrayName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06018CA9 RID: 101545
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectToDataSetFilter_GetCellConnectivityComponentMaxRange_05(HandleRef pThis);

		/// <summary>
		/// Define cell types and cell connectivity when creating unstructured grid
		/// data.  These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of cell types (an integer value per cell), and another
		/// array consisting (for each cell) of a number of points per cell, and
		/// then the cell connectivity. (This is the vtk file format described in
		/// in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018CAA RID: 101546 RVA: 0x00229BA8 File Offset: 0x00227DA8
		public int GetCellConnectivityComponentMaxRange()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetCellConnectivityComponentMaxRange_05(base.GetCppThis());
		}

		// Token: 0x06018CAB RID: 101547
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectToDataSetFilter_GetCellConnectivityComponentMinRange_06(HandleRef pThis);

		/// <summary>
		/// Define cell types and cell connectivity when creating unstructured grid
		/// data.  These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of cell types (an integer value per cell), and another
		/// array consisting (for each cell) of a number of points per cell, and
		/// then the cell connectivity. (This is the vtk file format described in
		/// in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018CAC RID: 101548 RVA: 0x00229BC8 File Offset: 0x00227DC8
		public int GetCellConnectivityComponentMinRange()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetCellConnectivityComponentMinRange_06(base.GetCppThis());
		}

		// Token: 0x06018CAD RID: 101549
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectToDataSetFilter_GetCellTypeComponentArrayComponent_07(HandleRef pThis);

		/// <summary>
		/// Define cell types and cell connectivity when creating unstructured grid
		/// data.  These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of cell types (an integer value per cell), and another
		/// array consisting (for each cell) of a number of points per cell, and
		/// then the cell connectivity. (This is the vtk file format described in
		/// in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018CAE RID: 101550 RVA: 0x00229BE8 File Offset: 0x00227DE8
		public int GetCellTypeComponentArrayComponent()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetCellTypeComponentArrayComponent_07(base.GetCppThis());
		}

		// Token: 0x06018CAF RID: 101551
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetCellTypeComponentArrayName_08(HandleRef pThis);

		/// <summary>
		/// Define cell types and cell connectivity when creating unstructured grid
		/// data.  These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of cell types (an integer value per cell), and another
		/// array consisting (for each cell) of a number of points per cell, and
		/// then the cell connectivity. (This is the vtk file format described in
		/// in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018CB0 RID: 101552 RVA: 0x00229C08 File Offset: 0x00227E08
		public string GetCellTypeComponentArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetCellTypeComponentArrayName_08(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06018CB1 RID: 101553
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectToDataSetFilter_GetCellTypeComponentMaxRange_09(HandleRef pThis);

		/// <summary>
		/// Define cell types and cell connectivity when creating unstructured grid
		/// data.  These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of cell types (an integer value per cell), and another
		/// array consisting (for each cell) of a number of points per cell, and
		/// then the cell connectivity. (This is the vtk file format described in
		/// in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018CB2 RID: 101554 RVA: 0x00229C44 File Offset: 0x00227E44
		public int GetCellTypeComponentMaxRange()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetCellTypeComponentMaxRange_09(base.GetCppThis());
		}

		// Token: 0x06018CB3 RID: 101555
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectToDataSetFilter_GetCellTypeComponentMinRange_10(HandleRef pThis);

		/// <summary>
		/// Define cell types and cell connectivity when creating unstructured grid
		/// data.  These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of cell types (an integer value per cell), and another
		/// array consisting (for each cell) of a number of points per cell, and
		/// then the cell connectivity. (This is the vtk file format described in
		/// in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018CB4 RID: 101556 RVA: 0x00229C64 File Offset: 0x00227E64
		public int GetCellTypeComponentMinRange()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetCellTypeComponentMinRange_10(base.GetCppThis());
		}

		// Token: 0x06018CB5 RID: 101557
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectToDataSetFilter_GetDataSetType_11(HandleRef pThis);

		/// <summary>
		/// Control what type of data is generated for output.
		/// </summary>
		// Token: 0x06018CB6 RID: 101558 RVA: 0x00229C84 File Offset: 0x00227E84
		public virtual int GetDataSetType()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetDataSetType_11(base.GetCppThis());
		}

		// Token: 0x06018CB7 RID: 101559
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectToDataSetFilter_GetDefaultNormalize_12(HandleRef pThis);

		/// <summary>
		/// Set the default Normalize() flag for those methods setting a default
		/// Normalize value (e.g., SetPointComponent).
		/// </summary>
		// Token: 0x06018CB8 RID: 101560 RVA: 0x00229CA4 File Offset: 0x00227EA4
		public virtual int GetDefaultNormalize()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetDefaultNormalize_12(base.GetCppThis());
		}

		// Token: 0x06018CB9 RID: 101561
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetDimensions_13(HandleRef pThis);

		/// <summary>
		/// Specify the dimensions to use if generating a dataset that requires
		/// dimensions specification (vtkStructuredPoints, vtkStructuredGrid,
		/// vtkRectilinearGrid).
		/// </summary>
		// Token: 0x06018CBA RID: 101562 RVA: 0x00229CC4 File Offset: 0x00227EC4
		public virtual int[] GetDimensions()
		{
			IntPtr intPtr = vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetDimensions_13(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06018CBB RID: 101563
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_GetDimensions_14(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the dimensions to use if generating a dataset that requires
		/// dimensions specification (vtkStructuredPoints, vtkStructuredGrid,
		/// vtkRectilinearGrid).
		/// </summary>
		// Token: 0x06018CBC RID: 101564 RVA: 0x00229D0C File Offset: 0x00227F0C
		public virtual void GetDimensions(IntPtr data)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetDimensions_14(base.GetCppThis(), data);
		}

		// Token: 0x06018CBD RID: 101565
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetInput_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to the filter.
		/// </summary>
		// Token: 0x06018CBE RID: 101566 RVA: 0x00229D1C File Offset: 0x00227F1C
		public new vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetInput_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x06018CBF RID: 101567
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectToDataSetFilter_GetLinesComponentArrayComponent_16(HandleRef pThis);

		/// <summary>
		/// Define cell connectivity when creating vtkPolyData. You can define
		/// vertices, lines, polygons, and/or triangle strips via these methods.
		/// These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of values that (for each cell) includes the number of
		/// points per cell, and then the cell connectivity. (This is the vtk file
		/// format described in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018CC0 RID: 101568 RVA: 0x00229D8C File Offset: 0x00227F8C
		public int GetLinesComponentArrayComponent()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetLinesComponentArrayComponent_16(base.GetCppThis());
		}

		// Token: 0x06018CC1 RID: 101569
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetLinesComponentArrayName_17(HandleRef pThis);

		/// <summary>
		/// Define cell connectivity when creating vtkPolyData. You can define
		/// vertices, lines, polygons, and/or triangle strips via these methods.
		/// These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of values that (for each cell) includes the number of
		/// points per cell, and then the cell connectivity. (This is the vtk file
		/// format described in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018CC2 RID: 101570 RVA: 0x00229DAC File Offset: 0x00227FAC
		public string GetLinesComponentArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetLinesComponentArrayName_17(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06018CC3 RID: 101571
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectToDataSetFilter_GetLinesComponentMaxRange_18(HandleRef pThis);

		/// <summary>
		/// Define cell connectivity when creating vtkPolyData. You can define
		/// vertices, lines, polygons, and/or triangle strips via these methods.
		/// These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of values that (for each cell) includes the number of
		/// points per cell, and then the cell connectivity. (This is the vtk file
		/// format described in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018CC4 RID: 101572 RVA: 0x00229DE8 File Offset: 0x00227FE8
		public int GetLinesComponentMaxRange()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetLinesComponentMaxRange_18(base.GetCppThis());
		}

		// Token: 0x06018CC5 RID: 101573
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectToDataSetFilter_GetLinesComponentMinRange_19(HandleRef pThis);

		/// <summary>
		/// Define cell connectivity when creating vtkPolyData. You can define
		/// vertices, lines, polygons, and/or triangle strips via these methods.
		/// These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of values that (for each cell) includes the number of
		/// points per cell, and then the cell connectivity. (This is the vtk file
		/// format described in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018CC6 RID: 101574 RVA: 0x00229E08 File Offset: 0x00228008
		public int GetLinesComponentMinRange()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetLinesComponentMinRange_19(base.GetCppThis());
		}

		// Token: 0x06018CC7 RID: 101575
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataObjectToDataSetFilter_GetNumberOfGenerationsFromBase_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018CC8 RID: 101576 RVA: 0x00229E28 File Offset: 0x00228028
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetNumberOfGenerationsFromBase_20(base.GetCppThis(), type);
		}

		// Token: 0x06018CC9 RID: 101577
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataObjectToDataSetFilter_GetNumberOfGenerationsFromBaseType_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018CCA RID: 101578 RVA: 0x00229E48 File Offset: 0x00228048
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetNumberOfGenerationsFromBaseType_21(type);
		}

		// Token: 0x06018CCB RID: 101579
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetOrigin_22(HandleRef pThis);

		/// <summary>
		/// Specify the origin to use if generating a dataset whose origin
		/// can be set (i.e., a vtkStructuredPoints dataset).
		/// </summary>
		// Token: 0x06018CCC RID: 101580 RVA: 0x00229E64 File Offset: 0x00228064
		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetOrigin_22(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06018CCD RID: 101581
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_GetOrigin_23(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the origin to use if generating a dataset whose origin
		/// can be set (i.e., a vtkStructuredPoints dataset).
		/// </summary>
		// Token: 0x06018CCE RID: 101582 RVA: 0x00229EAC File Offset: 0x002280AC
		public virtual void GetOrigin(IntPtr data)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetOrigin_23(base.GetCppThis(), data);
		}

		// Token: 0x06018CCF RID: 101583
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetOutput_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output in different forms. The particular method invoked
		/// should be consistent with the SetDataSetType() method. (Note:
		/// GetOutput() will always return a type consistent with
		/// SetDataSetType(). Also, GetOutput() will return nullptr if the filter
		/// aborted due to inconsistent data.)
		/// </summary>
		// Token: 0x06018CD0 RID: 101584 RVA: 0x00229EBC File Offset: 0x002280BC
		public new vtkDataSet GetOutput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetOutput_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06018CD1 RID: 101585
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetOutput_25(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output in different forms. The particular method invoked
		/// should be consistent with the SetDataSetType() method. (Note:
		/// GetOutput() will always return a type consistent with
		/// SetDataSetType(). Also, GetOutput() will return nullptr if the filter
		/// aborted due to inconsistent data.)
		/// </summary>
		// Token: 0x06018CD2 RID: 101586 RVA: 0x00229F2C File Offset: 0x0022812C
		public new vtkDataSet GetOutput(int idx)
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetOutput_25(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06018CD3 RID: 101587
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectToDataSetFilter_GetPointComponentArrayComponent_26(HandleRef pThis, int comp);

		/// <summary>
		/// Define the component of the field to be used for the x, y, and z values
		/// of the points. Note that the parameter comp must lie between (0,2) and
		/// refers to the x-y-z (i.e., 0,1,2) components of the points. To define
		/// the field component to use you can specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract. (This method should be used for
		/// vtkPolyData, vtkUnstructuredGrid, vtkStructuredGrid, and
		/// vtkRectilinearGrid.) A convenience method, SetPointComponent(),is also
		/// provided which does not require setting the (min,max) component range or
		/// the normalize flag (normalize is set to DefaulatNormalize value).
		/// </summary>
		// Token: 0x06018CD4 RID: 101588 RVA: 0x00229F9C File Offset: 0x0022819C
		public int GetPointComponentArrayComponent(int comp)
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetPointComponentArrayComponent_26(base.GetCppThis(), comp);
		}

		// Token: 0x06018CD5 RID: 101589
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetPointComponentArrayName_27(HandleRef pThis, int comp);

		/// <summary>
		/// Define the component of the field to be used for the x, y, and z values
		/// of the points. Note that the parameter comp must lie between (0,2) and
		/// refers to the x-y-z (i.e., 0,1,2) components of the points. To define
		/// the field component to use you can specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract. (This method should be used for
		/// vtkPolyData, vtkUnstructuredGrid, vtkStructuredGrid, and
		/// vtkRectilinearGrid.) A convenience method, SetPointComponent(),is also
		/// provided which does not require setting the (min,max) component range or
		/// the normalize flag (normalize is set to DefaulatNormalize value).
		/// </summary>
		// Token: 0x06018CD6 RID: 101590 RVA: 0x00229FBC File Offset: 0x002281BC
		public string GetPointComponentArrayName(int comp)
		{
			string s = Marshal.PtrToStringAnsi(vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetPointComponentArrayName_27(base.GetCppThis(), comp));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06018CD7 RID: 101591
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectToDataSetFilter_GetPointComponentMaxRange_28(HandleRef pThis, int comp);

		/// <summary>
		/// Define the component of the field to be used for the x, y, and z values
		/// of the points. Note that the parameter comp must lie between (0,2) and
		/// refers to the x-y-z (i.e., 0,1,2) components of the points. To define
		/// the field component to use you can specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract. (This method should be used for
		/// vtkPolyData, vtkUnstructuredGrid, vtkStructuredGrid, and
		/// vtkRectilinearGrid.) A convenience method, SetPointComponent(),is also
		/// provided which does not require setting the (min,max) component range or
		/// the normalize flag (normalize is set to DefaulatNormalize value).
		/// </summary>
		// Token: 0x06018CD8 RID: 101592 RVA: 0x00229FF8 File Offset: 0x002281F8
		public int GetPointComponentMaxRange(int comp)
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetPointComponentMaxRange_28(base.GetCppThis(), comp);
		}

		// Token: 0x06018CD9 RID: 101593
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectToDataSetFilter_GetPointComponentMinRange_29(HandleRef pThis, int comp);

		/// <summary>
		/// Define the component of the field to be used for the x, y, and z values
		/// of the points. Note that the parameter comp must lie between (0,2) and
		/// refers to the x-y-z (i.e., 0,1,2) components of the points. To define
		/// the field component to use you can specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract. (This method should be used for
		/// vtkPolyData, vtkUnstructuredGrid, vtkStructuredGrid, and
		/// vtkRectilinearGrid.) A convenience method, SetPointComponent(),is also
		/// provided which does not require setting the (min,max) component range or
		/// the normalize flag (normalize is set to DefaulatNormalize value).
		/// </summary>
		// Token: 0x06018CDA RID: 101594 RVA: 0x0022A018 File Offset: 0x00228218
		public int GetPointComponentMinRange(int comp)
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetPointComponentMinRange_29(base.GetCppThis(), comp);
		}

		// Token: 0x06018CDB RID: 101595
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectToDataSetFilter_GetPointComponentNormailzeFlag_30(HandleRef pThis, int comp);

		/// <summary>
		/// Define the component of the field to be used for the x, y, and z values
		/// of the points. Note that the parameter comp must lie between (0,2) and
		/// refers to the x-y-z (i.e., 0,1,2) components of the points. To define
		/// the field component to use you can specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract. (This method should be used for
		/// vtkPolyData, vtkUnstructuredGrid, vtkStructuredGrid, and
		/// vtkRectilinearGrid.) A convenience method, SetPointComponent(),is also
		/// provided which does not require setting the (min,max) component range or
		/// the normalize flag (normalize is set to DefaulatNormalize value).
		/// </summary>
		// Token: 0x06018CDC RID: 101596 RVA: 0x0022A038 File Offset: 0x00228238
		public int GetPointComponentNormailzeFlag(int comp)
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetPointComponentNormailzeFlag_30(base.GetCppThis(), comp);
		}

		// Token: 0x06018CDD RID: 101597
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetPolyDataOutput_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output in different forms. The particular method invoked
		/// should be consistent with the SetDataSetType() method. (Note:
		/// GetOutput() will always return a type consistent with
		/// SetDataSetType(). Also, GetOutput() will return nullptr if the filter
		/// aborted due to inconsistent data.)
		/// </summary>
		// Token: 0x06018CDE RID: 101598 RVA: 0x0022A058 File Offset: 0x00228258
		public new vtkPolyData GetPolyDataOutput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetPolyDataOutput_31(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06018CDF RID: 101599
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectToDataSetFilter_GetPolysComponentArrayComponent_32(HandleRef pThis);

		/// <summary>
		/// Define cell connectivity when creating vtkPolyData. You can define
		/// vertices, lines, polygons, and/or triangle strips via these methods.
		/// These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of values that (for each cell) includes the number of
		/// points per cell, and then the cell connectivity. (This is the vtk file
		/// format described in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018CE0 RID: 101600 RVA: 0x0022A0C8 File Offset: 0x002282C8
		public int GetPolysComponentArrayComponent()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetPolysComponentArrayComponent_32(base.GetCppThis());
		}

		// Token: 0x06018CE1 RID: 101601
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetPolysComponentArrayName_33(HandleRef pThis);

		/// <summary>
		/// Define cell connectivity when creating vtkPolyData. You can define
		/// vertices, lines, polygons, and/or triangle strips via these methods.
		/// These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of values that (for each cell) includes the number of
		/// points per cell, and then the cell connectivity. (This is the vtk file
		/// format described in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018CE2 RID: 101602 RVA: 0x0022A0E8 File Offset: 0x002282E8
		public string GetPolysComponentArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetPolysComponentArrayName_33(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06018CE3 RID: 101603
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectToDataSetFilter_GetPolysComponentMaxRange_34(HandleRef pThis);

		/// <summary>
		/// Define cell connectivity when creating vtkPolyData. You can define
		/// vertices, lines, polygons, and/or triangle strips via these methods.
		/// These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of values that (for each cell) includes the number of
		/// points per cell, and then the cell connectivity. (This is the vtk file
		/// format described in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018CE4 RID: 101604 RVA: 0x0022A124 File Offset: 0x00228324
		public int GetPolysComponentMaxRange()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetPolysComponentMaxRange_34(base.GetCppThis());
		}

		// Token: 0x06018CE5 RID: 101605
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectToDataSetFilter_GetPolysComponentMinRange_35(HandleRef pThis);

		/// <summary>
		/// Define cell connectivity when creating vtkPolyData. You can define
		/// vertices, lines, polygons, and/or triangle strips via these methods.
		/// These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of values that (for each cell) includes the number of
		/// points per cell, and then the cell connectivity. (This is the vtk file
		/// format described in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018CE6 RID: 101606 RVA: 0x0022A144 File Offset: 0x00228344
		public int GetPolysComponentMinRange()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetPolysComponentMinRange_35(base.GetCppThis());
		}

		// Token: 0x06018CE7 RID: 101607
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetRectilinearGridOutput_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output in different forms. The particular method invoked
		/// should be consistent with the SetDataSetType() method. (Note:
		/// GetOutput() will always return a type consistent with
		/// SetDataSetType(). Also, GetOutput() will return nullptr if the filter
		/// aborted due to inconsistent data.)
		/// </summary>
		// Token: 0x06018CE8 RID: 101608 RVA: 0x0022A164 File Offset: 0x00228364
		public new vtkRectilinearGrid GetRectilinearGridOutput()
		{
			vtkRectilinearGrid vtkRectilinearGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetRectilinearGridOutput_36(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGrid = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGrid.Register(null);
				}
			}
			return vtkRectilinearGrid;
		}

		// Token: 0x06018CE9 RID: 101609
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetSpacing_37(HandleRef pThis);

		/// <summary>
		/// Specify the spacing to use if generating a dataset whose spacing
		/// can be set (i.e., a vtkStructuredPoints dataset).
		/// </summary>
		// Token: 0x06018CEA RID: 101610 RVA: 0x0022A1D4 File Offset: 0x002283D4
		public virtual double[] GetSpacing()
		{
			IntPtr intPtr = vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetSpacing_37(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06018CEB RID: 101611
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_GetSpacing_38(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the spacing to use if generating a dataset whose spacing
		/// can be set (i.e., a vtkStructuredPoints dataset).
		/// </summary>
		// Token: 0x06018CEC RID: 101612 RVA: 0x0022A21C File Offset: 0x0022841C
		public virtual void GetSpacing(IntPtr data)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetSpacing_38(base.GetCppThis(), data);
		}

		// Token: 0x06018CED RID: 101613
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectToDataSetFilter_GetStripsComponentArrayComponent_39(HandleRef pThis);

		/// <summary>
		/// Define cell connectivity when creating vtkPolyData. You can define
		/// vertices, lines, polygons, and/or triangle strips via these methods.
		/// These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of values that (for each cell) includes the number of
		/// points per cell, and then the cell connectivity. (This is the vtk file
		/// format described in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018CEE RID: 101614 RVA: 0x0022A22C File Offset: 0x0022842C
		public int GetStripsComponentArrayComponent()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetStripsComponentArrayComponent_39(base.GetCppThis());
		}

		// Token: 0x06018CEF RID: 101615
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetStripsComponentArrayName_40(HandleRef pThis);

		/// <summary>
		/// Define cell connectivity when creating vtkPolyData. You can define
		/// vertices, lines, polygons, and/or triangle strips via these methods.
		/// These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of values that (for each cell) includes the number of
		/// points per cell, and then the cell connectivity. (This is the vtk file
		/// format described in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018CF0 RID: 101616 RVA: 0x0022A24C File Offset: 0x0022844C
		public string GetStripsComponentArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetStripsComponentArrayName_40(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06018CF1 RID: 101617
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectToDataSetFilter_GetStripsComponentMaxRange_41(HandleRef pThis);

		/// <summary>
		/// Define cell connectivity when creating vtkPolyData. You can define
		/// vertices, lines, polygons, and/or triangle strips via these methods.
		/// These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of values that (for each cell) includes the number of
		/// points per cell, and then the cell connectivity. (This is the vtk file
		/// format described in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018CF2 RID: 101618 RVA: 0x0022A288 File Offset: 0x00228488
		public int GetStripsComponentMaxRange()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetStripsComponentMaxRange_41(base.GetCppThis());
		}

		// Token: 0x06018CF3 RID: 101619
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectToDataSetFilter_GetStripsComponentMinRange_42(HandleRef pThis);

		/// <summary>
		/// Define cell connectivity when creating vtkPolyData. You can define
		/// vertices, lines, polygons, and/or triangle strips via these methods.
		/// These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of values that (for each cell) includes the number of
		/// points per cell, and then the cell connectivity. (This is the vtk file
		/// format described in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018CF4 RID: 101620 RVA: 0x0022A2A8 File Offset: 0x002284A8
		public int GetStripsComponentMinRange()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetStripsComponentMinRange_42(base.GetCppThis());
		}

		// Token: 0x06018CF5 RID: 101621
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetStructuredGridOutput_43(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output in different forms. The particular method invoked
		/// should be consistent with the SetDataSetType() method. (Note:
		/// GetOutput() will always return a type consistent with
		/// SetDataSetType(). Also, GetOutput() will return nullptr if the filter
		/// aborted due to inconsistent data.)
		/// </summary>
		// Token: 0x06018CF6 RID: 101622 RVA: 0x0022A2C8 File Offset: 0x002284C8
		public new vtkStructuredGrid GetStructuredGridOutput()
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetStructuredGridOutput_43(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGrid = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGrid.Register(null);
				}
			}
			return vtkStructuredGrid;
		}

		// Token: 0x06018CF7 RID: 101623
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetStructuredPointsOutput_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output in different forms. The particular method invoked
		/// should be consistent with the SetDataSetType() method. (Note:
		/// GetOutput() will always return a type consistent with
		/// SetDataSetType(). Also, GetOutput() will return nullptr if the filter
		/// aborted due to inconsistent data.)
		/// </summary>
		// Token: 0x06018CF8 RID: 101624 RVA: 0x0022A338 File Offset: 0x00228538
		public new vtkStructuredPoints GetStructuredPointsOutput()
		{
			vtkStructuredPoints vtkStructuredPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetStructuredPointsOutput_44(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredPoints = (vtkStructuredPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredPoints.Register(null);
				}
			}
			return vtkStructuredPoints;
		}

		// Token: 0x06018CF9 RID: 101625
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetUnstructuredGridOutput_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output in different forms. The particular method invoked
		/// should be consistent with the SetDataSetType() method. (Note:
		/// GetOutput() will always return a type consistent with
		/// SetDataSetType(). Also, GetOutput() will return nullptr if the filter
		/// aborted due to inconsistent data.)
		/// </summary>
		// Token: 0x06018CFA RID: 101626 RVA: 0x0022A3A8 File Offset: 0x002285A8
		public new vtkUnstructuredGrid GetUnstructuredGridOutput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetUnstructuredGridOutput_45(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		// Token: 0x06018CFB RID: 101627
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectToDataSetFilter_GetVertsComponentArrayComponent_46(HandleRef pThis);

		/// <summary>
		/// Define cell connectivity when creating vtkPolyData. You can define
		/// vertices, lines, polygons, and/or triangle strips via these methods.
		/// These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of values that (for each cell) includes the number of
		/// points per cell, and then the cell connectivity. (This is the vtk file
		/// format described in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018CFC RID: 101628 RVA: 0x0022A418 File Offset: 0x00228618
		public int GetVertsComponentArrayComponent()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetVertsComponentArrayComponent_46(base.GetCppThis());
		}

		// Token: 0x06018CFD RID: 101629
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_GetVertsComponentArrayName_47(HandleRef pThis);

		/// <summary>
		/// Define cell connectivity when creating vtkPolyData. You can define
		/// vertices, lines, polygons, and/or triangle strips via these methods.
		/// These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of values that (for each cell) includes the number of
		/// points per cell, and then the cell connectivity. (This is the vtk file
		/// format described in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018CFE RID: 101630 RVA: 0x0022A438 File Offset: 0x00228638
		public string GetVertsComponentArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetVertsComponentArrayName_47(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06018CFF RID: 101631
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectToDataSetFilter_GetVertsComponentMaxRange_48(HandleRef pThis);

		/// <summary>
		/// Define cell connectivity when creating vtkPolyData. You can define
		/// vertices, lines, polygons, and/or triangle strips via these methods.
		/// These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of values that (for each cell) includes the number of
		/// points per cell, and then the cell connectivity. (This is the vtk file
		/// format described in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018D00 RID: 101632 RVA: 0x0022A474 File Offset: 0x00228674
		public int GetVertsComponentMaxRange()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetVertsComponentMaxRange_48(base.GetCppThis());
		}

		// Token: 0x06018D01 RID: 101633
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectToDataSetFilter_GetVertsComponentMinRange_49(HandleRef pThis);

		/// <summary>
		/// Define cell connectivity when creating vtkPolyData. You can define
		/// vertices, lines, polygons, and/or triangle strips via these methods.
		/// These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of values that (for each cell) includes the number of
		/// points per cell, and then the cell connectivity. (This is the vtk file
		/// format described in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018D02 RID: 101634 RVA: 0x0022A494 File Offset: 0x00228694
		public int GetVertsComponentMinRange()
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_GetVertsComponentMinRange_49(base.GetCppThis());
		}

		// Token: 0x06018D03 RID: 101635
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectToDataSetFilter_IsA_50(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018D04 RID: 101636 RVA: 0x0022A4B4 File Offset: 0x002286B4
		public override int IsA(string type)
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_IsA_50(base.GetCppThis(), type);
		}

		// Token: 0x06018D05 RID: 101637
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataObjectToDataSetFilter_IsTypeOf_51([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018D06 RID: 101638 RVA: 0x0022A4D4 File Offset: 0x002286D4
		public new static int IsTypeOf(string type)
		{
			return vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_IsTypeOf_51(type);
		}

		// Token: 0x06018D07 RID: 101639
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_NewInstance_53(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018D08 RID: 101640 RVA: 0x0022A4F0 File Offset: 0x002286F0
		public new vtkDataObjectToDataSetFilter NewInstance()
		{
			vtkDataObjectToDataSetFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_NewInstance_53(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataObjectToDataSetFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018D09 RID: 101641
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataObjectToDataSetFilter_SafeDownCast_54(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018D0A RID: 101642 RVA: 0x0022A54C File Offset: 0x0022874C
		public new static vtkDataObjectToDataSetFilter SafeDownCast(vtkObjectBase o)
		{
			vtkDataObjectToDataSetFilter vtkDataObjectToDataSetFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SafeDownCast_54((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObjectToDataSetFilter = (vtkDataObjectToDataSetFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObjectToDataSetFilter.Register(null);
				}
			}
			return vtkDataObjectToDataSetFilter;
		}

		// Token: 0x06018D0B RID: 101643
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetCellConnectivityComponent_55(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int arrayComp, int min, int max);

		/// <summary>
		/// Define cell types and cell connectivity when creating unstructured grid
		/// data.  These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of cell types (an integer value per cell), and another
		/// array consisting (for each cell) of a number of points per cell, and
		/// then the cell connectivity. (This is the vtk file format described in
		/// in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018D0C RID: 101644 RVA: 0x0022A5CB File Offset: 0x002287CB
		public void SetCellConnectivityComponent(string arrayName, int arrayComp, int min, int max)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetCellConnectivityComponent_55(base.GetCppThis(), arrayName, arrayComp, min, max);
		}

		// Token: 0x06018D0D RID: 101645
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetCellConnectivityComponent_56(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int arrayComp);

		/// <summary>
		/// Define cell types and cell connectivity when creating unstructured grid
		/// data.  These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of cell types (an integer value per cell), and another
		/// array consisting (for each cell) of a number of points per cell, and
		/// then the cell connectivity. (This is the vtk file format described in
		/// in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018D0E RID: 101646 RVA: 0x0022A5DF File Offset: 0x002287DF
		public void SetCellConnectivityComponent(string arrayName, int arrayComp)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetCellConnectivityComponent_56(base.GetCppThis(), arrayName, arrayComp);
		}

		// Token: 0x06018D0F RID: 101647
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetCellTypeComponent_57(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int arrayComp, int min, int max);

		/// <summary>
		/// Define cell types and cell connectivity when creating unstructured grid
		/// data.  These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of cell types (an integer value per cell), and another
		/// array consisting (for each cell) of a number of points per cell, and
		/// then the cell connectivity. (This is the vtk file format described in
		/// in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018D10 RID: 101648 RVA: 0x0022A5F0 File Offset: 0x002287F0
		public void SetCellTypeComponent(string arrayName, int arrayComp, int min, int max)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetCellTypeComponent_57(base.GetCppThis(), arrayName, arrayComp, min, max);
		}

		// Token: 0x06018D11 RID: 101649
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetCellTypeComponent_58(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int arrayComp);

		/// <summary>
		/// Define cell types and cell connectivity when creating unstructured grid
		/// data.  These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of cell types (an integer value per cell), and another
		/// array consisting (for each cell) of a number of points per cell, and
		/// then the cell connectivity. (This is the vtk file format described in
		/// in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018D12 RID: 101650 RVA: 0x0022A604 File Offset: 0x00228804
		public void SetCellTypeComponent(string arrayName, int arrayComp)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetCellTypeComponent_58(base.GetCppThis(), arrayName, arrayComp);
		}

		// Token: 0x06018D13 RID: 101651
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetDataSetType_59(HandleRef pThis, int arg0);

		/// <summary>
		/// Control what type of data is generated for output.
		/// </summary>
		// Token: 0x06018D14 RID: 101652 RVA: 0x0022A615 File Offset: 0x00228815
		public void SetDataSetType(int arg0)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetDataSetType_59(base.GetCppThis(), arg0);
		}

		// Token: 0x06018D15 RID: 101653
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetDataSetTypeToPolyData_60(HandleRef pThis);

		/// <summary>
		/// Control what type of data is generated for output.
		/// </summary>
		// Token: 0x06018D16 RID: 101654 RVA: 0x0022A625 File Offset: 0x00228825
		public void SetDataSetTypeToPolyData()
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetDataSetTypeToPolyData_60(base.GetCppThis());
		}

		// Token: 0x06018D17 RID: 101655
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetDataSetTypeToRectilinearGrid_61(HandleRef pThis);

		/// <summary>
		/// Control what type of data is generated for output.
		/// </summary>
		// Token: 0x06018D18 RID: 101656 RVA: 0x0022A634 File Offset: 0x00228834
		public void SetDataSetTypeToRectilinearGrid()
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetDataSetTypeToRectilinearGrid_61(base.GetCppThis());
		}

		// Token: 0x06018D19 RID: 101657
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetDataSetTypeToStructuredGrid_62(HandleRef pThis);

		/// <summary>
		/// Control what type of data is generated for output.
		/// </summary>
		// Token: 0x06018D1A RID: 101658 RVA: 0x0022A643 File Offset: 0x00228843
		public void SetDataSetTypeToStructuredGrid()
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetDataSetTypeToStructuredGrid_62(base.GetCppThis());
		}

		// Token: 0x06018D1B RID: 101659
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetDataSetTypeToStructuredPoints_63(HandleRef pThis);

		/// <summary>
		/// Control what type of data is generated for output.
		/// </summary>
		// Token: 0x06018D1C RID: 101660 RVA: 0x0022A652 File Offset: 0x00228852
		public void SetDataSetTypeToStructuredPoints()
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetDataSetTypeToStructuredPoints_63(base.GetCppThis());
		}

		// Token: 0x06018D1D RID: 101661
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetDataSetTypeToUnstructuredGrid_64(HandleRef pThis);

		/// <summary>
		/// Control what type of data is generated for output.
		/// </summary>
		// Token: 0x06018D1E RID: 101662 RVA: 0x0022A661 File Offset: 0x00228861
		public void SetDataSetTypeToUnstructuredGrid()
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetDataSetTypeToUnstructuredGrid_64(base.GetCppThis());
		}

		// Token: 0x06018D1F RID: 101663
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetDefaultNormalize_65(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the default Normalize() flag for those methods setting a default
		/// Normalize value (e.g., SetPointComponent).
		/// </summary>
		// Token: 0x06018D20 RID: 101664 RVA: 0x0022A670 File Offset: 0x00228870
		public virtual void SetDefaultNormalize(int _arg)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetDefaultNormalize_65(base.GetCppThis(), _arg);
		}

		// Token: 0x06018D21 RID: 101665
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetDimensions_66(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		/// <summary>
		/// Specify the dimensions to use if generating a dataset that requires
		/// dimensions specification (vtkStructuredPoints, vtkStructuredGrid,
		/// vtkRectilinearGrid).
		/// </summary>
		// Token: 0x06018D22 RID: 101666 RVA: 0x0022A680 File Offset: 0x00228880
		public virtual void SetDimensions(int _arg1, int _arg2, int _arg3)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetDimensions_66(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06018D23 RID: 101667
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetDimensions_67(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the dimensions to use if generating a dataset that requires
		/// dimensions specification (vtkStructuredPoints, vtkStructuredGrid,
		/// vtkRectilinearGrid).
		/// </summary>
		// Token: 0x06018D24 RID: 101668 RVA: 0x0022A692 File Offset: 0x00228892
		public virtual void SetDimensions(IntPtr _arg)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetDimensions_67(base.GetCppThis(), _arg);
		}

		// Token: 0x06018D25 RID: 101669
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetDimensionsComponent_68(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int arrayComp, int min, int max);

		/// <summary>
		/// Alternative methods to specify the dimensions, spacing, and origin for those
		/// datasets requiring this information. You need to specify the name of an array;
		/// the component of the array, and the range of the array (min,max). These methods
		/// will override the information given by the previous methods.
		/// </summary>
		// Token: 0x06018D26 RID: 101670 RVA: 0x0022A6A2 File Offset: 0x002288A2
		public void SetDimensionsComponent(string arrayName, int arrayComp, int min, int max)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetDimensionsComponent_68(base.GetCppThis(), arrayName, arrayComp, min, max);
		}

		// Token: 0x06018D27 RID: 101671
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetDimensionsComponent_69(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int arrayComp);

		/// <summary>
		/// Alternative methods to specify the dimensions, spacing, and origin for those
		/// datasets requiring this information. You need to specify the name of an array;
		/// the component of the array, and the range of the array (min,max). These methods
		/// will override the information given by the previous methods.
		/// </summary>
		// Token: 0x06018D28 RID: 101672 RVA: 0x0022A6B6 File Offset: 0x002288B6
		public void SetDimensionsComponent(string arrayName, int arrayComp)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetDimensionsComponent_69(base.GetCppThis(), arrayName, arrayComp);
		}

		// Token: 0x06018D29 RID: 101673
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetLinesComponent_70(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int arrayComp, int min, int max);

		/// <summary>
		/// Define cell connectivity when creating vtkPolyData. You can define
		/// vertices, lines, polygons, and/or triangle strips via these methods.
		/// These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of values that (for each cell) includes the number of
		/// points per cell, and then the cell connectivity. (This is the vtk file
		/// format described in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018D2A RID: 101674 RVA: 0x0022A6C7 File Offset: 0x002288C7
		public void SetLinesComponent(string arrayName, int arrayComp, int min, int max)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetLinesComponent_70(base.GetCppThis(), arrayName, arrayComp, min, max);
		}

		// Token: 0x06018D2B RID: 101675
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetLinesComponent_71(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int arrayComp);

		/// <summary>
		/// Define cell connectivity when creating vtkPolyData. You can define
		/// vertices, lines, polygons, and/or triangle strips via these methods.
		/// These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of values that (for each cell) includes the number of
		/// points per cell, and then the cell connectivity. (This is the vtk file
		/// format described in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018D2C RID: 101676 RVA: 0x0022A6DB File Offset: 0x002288DB
		public void SetLinesComponent(string arrayName, int arrayComp)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetLinesComponent_71(base.GetCppThis(), arrayName, arrayComp);
		}

		// Token: 0x06018D2D RID: 101677
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetOrigin_72(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Specify the origin to use if generating a dataset whose origin
		/// can be set (i.e., a vtkStructuredPoints dataset).
		/// </summary>
		// Token: 0x06018D2E RID: 101678 RVA: 0x0022A6EC File Offset: 0x002288EC
		public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetOrigin_72(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06018D2F RID: 101679
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetOrigin_73(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the origin to use if generating a dataset whose origin
		/// can be set (i.e., a vtkStructuredPoints dataset).
		/// </summary>
		// Token: 0x06018D30 RID: 101680 RVA: 0x0022A6FE File Offset: 0x002288FE
		public virtual void SetOrigin(IntPtr _arg)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetOrigin_73(base.GetCppThis(), _arg);
		}

		// Token: 0x06018D31 RID: 101681
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetOriginComponent_74(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int arrayComp, int min, int max);

		/// <summary>
		/// Alternative methods to specify the dimensions, spacing, and origin for those
		/// datasets requiring this information. You need to specify the name of an array;
		/// the component of the array, and the range of the array (min,max). These methods
		/// will override the information given by the previous methods.
		/// </summary>
		// Token: 0x06018D32 RID: 101682 RVA: 0x0022A70E File Offset: 0x0022890E
		public void SetOriginComponent(string arrayName, int arrayComp, int min, int max)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetOriginComponent_74(base.GetCppThis(), arrayName, arrayComp, min, max);
		}

		// Token: 0x06018D33 RID: 101683
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetOriginComponent_75(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int arrayComp);

		/// <summary>
		/// Alternative methods to specify the dimensions, spacing, and origin for those
		/// datasets requiring this information. You need to specify the name of an array;
		/// the component of the array, and the range of the array (min,max). These methods
		/// will override the information given by the previous methods.
		/// </summary>
		// Token: 0x06018D34 RID: 101684 RVA: 0x0022A722 File Offset: 0x00228922
		public void SetOriginComponent(string arrayName, int arrayComp)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetOriginComponent_75(base.GetCppThis(), arrayName, arrayComp);
		}

		// Token: 0x06018D35 RID: 101685
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetPointComponent_76(HandleRef pThis, int comp, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int arrayComp, int min, int max, int normalize);

		/// <summary>
		/// Define the component of the field to be used for the x, y, and z values
		/// of the points. Note that the parameter comp must lie between (0,2) and
		/// refers to the x-y-z (i.e., 0,1,2) components of the points. To define
		/// the field component to use you can specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract. (This method should be used for
		/// vtkPolyData, vtkUnstructuredGrid, vtkStructuredGrid, and
		/// vtkRectilinearGrid.) A convenience method, SetPointComponent(),is also
		/// provided which does not require setting the (min,max) component range or
		/// the normalize flag (normalize is set to DefaulatNormalize value).
		/// </summary>
		// Token: 0x06018D36 RID: 101686 RVA: 0x0022A733 File Offset: 0x00228933
		public void SetPointComponent(int comp, string arrayName, int arrayComp, int min, int max, int normalize)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetPointComponent_76(base.GetCppThis(), comp, arrayName, arrayComp, min, max, normalize);
		}

		// Token: 0x06018D37 RID: 101687
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetPointComponent_77(HandleRef pThis, int comp, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int arrayComp);

		/// <summary>
		/// Define the component of the field to be used for the x, y, and z values
		/// of the points. Note that the parameter comp must lie between (0,2) and
		/// refers to the x-y-z (i.e., 0,1,2) components of the points. To define
		/// the field component to use you can specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract. (This method should be used for
		/// vtkPolyData, vtkUnstructuredGrid, vtkStructuredGrid, and
		/// vtkRectilinearGrid.) A convenience method, SetPointComponent(),is also
		/// provided which does not require setting the (min,max) component range or
		/// the normalize flag (normalize is set to DefaulatNormalize value).
		/// </summary>
		// Token: 0x06018D38 RID: 101688 RVA: 0x0022A74B File Offset: 0x0022894B
		public void SetPointComponent(int comp, string arrayName, int arrayComp)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetPointComponent_77(base.GetCppThis(), comp, arrayName, arrayComp);
		}

		// Token: 0x06018D39 RID: 101689
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetPolysComponent_78(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int arrayComp, int min, int max);

		/// <summary>
		/// Define cell connectivity when creating vtkPolyData. You can define
		/// vertices, lines, polygons, and/or triangle strips via these methods.
		/// These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of values that (for each cell) includes the number of
		/// points per cell, and then the cell connectivity. (This is the vtk file
		/// format described in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018D3A RID: 101690 RVA: 0x0022A75D File Offset: 0x0022895D
		public void SetPolysComponent(string arrayName, int arrayComp, int min, int max)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetPolysComponent_78(base.GetCppThis(), arrayName, arrayComp, min, max);
		}

		// Token: 0x06018D3B RID: 101691
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetPolysComponent_79(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int arrayComp);

		/// <summary>
		/// Define cell connectivity when creating vtkPolyData. You can define
		/// vertices, lines, polygons, and/or triangle strips via these methods.
		/// These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of values that (for each cell) includes the number of
		/// points per cell, and then the cell connectivity. (This is the vtk file
		/// format described in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018D3C RID: 101692 RVA: 0x0022A771 File Offset: 0x00228971
		public void SetPolysComponent(string arrayName, int arrayComp)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetPolysComponent_79(base.GetCppThis(), arrayName, arrayComp);
		}

		// Token: 0x06018D3D RID: 101693
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetSpacing_80(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Specify the spacing to use if generating a dataset whose spacing
		/// can be set (i.e., a vtkStructuredPoints dataset).
		/// </summary>
		// Token: 0x06018D3E RID: 101694 RVA: 0x0022A782 File Offset: 0x00228982
		public virtual void SetSpacing(double _arg1, double _arg2, double _arg3)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetSpacing_80(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06018D3F RID: 101695
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetSpacing_81(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the spacing to use if generating a dataset whose spacing
		/// can be set (i.e., a vtkStructuredPoints dataset).
		/// </summary>
		// Token: 0x06018D40 RID: 101696 RVA: 0x0022A794 File Offset: 0x00228994
		public virtual void SetSpacing(IntPtr _arg)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetSpacing_81(base.GetCppThis(), _arg);
		}

		// Token: 0x06018D41 RID: 101697
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetSpacingComponent_82(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int arrayComp, int min, int max);

		/// <summary>
		/// Alternative methods to specify the dimensions, spacing, and origin for those
		/// datasets requiring this information. You need to specify the name of an array;
		/// the component of the array, and the range of the array (min,max). These methods
		/// will override the information given by the previous methods.
		/// </summary>
		// Token: 0x06018D42 RID: 101698 RVA: 0x0022A7A4 File Offset: 0x002289A4
		public void SetSpacingComponent(string arrayName, int arrayComp, int min, int max)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetSpacingComponent_82(base.GetCppThis(), arrayName, arrayComp, min, max);
		}

		// Token: 0x06018D43 RID: 101699
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetSpacingComponent_83(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int arrayComp);

		/// <summary>
		/// Alternative methods to specify the dimensions, spacing, and origin for those
		/// datasets requiring this information. You need to specify the name of an array;
		/// the component of the array, and the range of the array (min,max). These methods
		/// will override the information given by the previous methods.
		/// </summary>
		// Token: 0x06018D44 RID: 101700 RVA: 0x0022A7B8 File Offset: 0x002289B8
		public void SetSpacingComponent(string arrayName, int arrayComp)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetSpacingComponent_83(base.GetCppThis(), arrayName, arrayComp);
		}

		// Token: 0x06018D45 RID: 101701
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetStripsComponent_84(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int arrayComp, int min, int max);

		/// <summary>
		/// Define cell connectivity when creating vtkPolyData. You can define
		/// vertices, lines, polygons, and/or triangle strips via these methods.
		/// These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of values that (for each cell) includes the number of
		/// points per cell, and then the cell connectivity. (This is the vtk file
		/// format described in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018D46 RID: 101702 RVA: 0x0022A7C9 File Offset: 0x002289C9
		public void SetStripsComponent(string arrayName, int arrayComp, int min, int max)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetStripsComponent_84(base.GetCppThis(), arrayName, arrayComp, min, max);
		}

		// Token: 0x06018D47 RID: 101703
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetStripsComponent_85(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int arrayComp);

		/// <summary>
		/// Define cell connectivity when creating vtkPolyData. You can define
		/// vertices, lines, polygons, and/or triangle strips via these methods.
		/// These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of values that (for each cell) includes the number of
		/// points per cell, and then the cell connectivity. (This is the vtk file
		/// format described in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018D48 RID: 101704 RVA: 0x0022A7DD File Offset: 0x002289DD
		public void SetStripsComponent(string arrayName, int arrayComp)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetStripsComponent_85(base.GetCppThis(), arrayName, arrayComp);
		}

		// Token: 0x06018D49 RID: 101705
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetVertsComponent_86(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int arrayComp, int min, int max);

		/// <summary>
		/// Define cell connectivity when creating vtkPolyData. You can define
		/// vertices, lines, polygons, and/or triangle strips via these methods.
		/// These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of values that (for each cell) includes the number of
		/// points per cell, and then the cell connectivity. (This is the vtk file
		/// format described in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018D4A RID: 101706 RVA: 0x0022A7EE File Offset: 0x002289EE
		public void SetVertsComponent(string arrayName, int arrayComp, int min, int max)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetVertsComponent_86(base.GetCppThis(), arrayName, arrayComp, min, max);
		}

		// Token: 0x06018D4B RID: 101707
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataObjectToDataSetFilter_SetVertsComponent_87(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int arrayComp);

		/// <summary>
		/// Define cell connectivity when creating vtkPolyData. You can define
		/// vertices, lines, polygons, and/or triangle strips via these methods.
		/// These methods are similar to those for defining points, except
		/// that no normalization of the data is possible. Basically, you need to
		/// define an array of values that (for each cell) includes the number of
		/// points per cell, and then the cell connectivity. (This is the vtk file
		/// format described in the textbook or User's Guide.)
		/// </summary>
		// Token: 0x06018D4C RID: 101708 RVA: 0x0022A802 File Offset: 0x00228A02
		public void SetVertsComponent(string arrayName, int arrayComp)
		{
			vtkDataObjectToDataSetFilter.vtkDataObjectToDataSetFilter_SetVertsComponent_87(base.GetCppThis(), arrayName, arrayComp);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B65 RID: 7013
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataObjectToDataSetFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B66 RID: 7014
		public new static readonly string MRClassNameKey = "class vtkDataObjectToDataSetFilter";
	}
}
