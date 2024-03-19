using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGeometryFilter
	/// </summary>
	/// <remarks>
	///    extract boundary geometry from dataset (or convert data to polygonal type)
	///
	/// vtkGeometryFilter is a general-purpose filter to extract dataset boundary
	/// geometry, topology, and associated attribute data from any type of
	/// dataset. Geometry is obtained as follows: all 0D, 1D, and 2D cells are
	/// extracted. All 2D faces that are used by only one 3D cell (i.e., boundary
	/// faces) are extracted. It also is possible to specify conditions on point
	/// ids, cell ids, and on a bounding box (referred to as "Extent") to control
	/// the extraction process.  This point and cell id- and extent-based clipping
	/// is a powerful way to "see inside" datasets; however it may impact
	/// performance significantly.
	///
	/// This filter may also be used to convert any type of data to polygonal
	/// type. This is particularly useful for surface rendering. The conversion
	/// process may be less than satisfactory for some 3D datasets. For example,
	/// this filter will extract the outer surface of a volume or structured grid
	/// dataset (if point, cell, and extent clipping is disabled). (For structured
	/// data you may want to use vtkImageDataGeometryFilter,
	/// vtkStructuredGridGeometryFilter, vtkExtractUnstructuredGrid,
	/// vtkRectilinearGridGeometryFilter, or vtkExtractVOI.)
	///
	/// Another important feature of vtkGeometryFilter is that it preserves
	/// topological connectivity. This enables filters that depend on correct
	/// connectivity (e.g., vtkQuadricDecimation, vtkFeatureEdges, etc.) to
	/// operate properly . It is possible to label the output polydata with an
	/// originating cell (PassThroughCellIds) or point id (PassThroughPointIds).
	/// The output precision of created points (if they need to be created) can
	/// also be specified.
	///
	/// Finally, this filter takes an optional second, vtkPolyData input. This
	/// input represents a list of faces that are to be excluded from the output
	/// of vtkGeometryFilter.
	///
	/// @warning
	/// While vtkGeometryFilter and vtkDataSetSurfaceFilter perform similar operations,
	/// there are important differences as follows:
	/// 1. vtkGeometryFilter can preserve (using RemoveGhostInterfaces) topological connectivity.
	///    vtkDataSetSurfaceFilter produces output primitives which may be disconnected from one another.
	/// 2. vtkGeometryFilter can generate output based on cell ids, point ids, and/or
	///    extent (bounding box) clipping. vtkDataSetSurfaceFilter strictly extracts
	///    the boundary surface of a dataset.
	/// 3. vtkGeometryFilter is much faster than vtkDataSetSurfaceFilter, because it's
	///    multi-threaded. As a result, vtkDataSetSurfaceFilter will delegate the processing
	///    of linear unstructured grids to vtkGeometryFilter.
	/// 4. vtkGeometryFilter can (currently) only handle linear cells. The filter
	///    will delegate to vtkDataSetSurfaceFilter for higher-order cells. (This
	///    is a historical artifact and may be rectified in the future.)
	///
	/// @warning
	/// If point merging (MergingOff) is disabled, the filter will (if possible)
	/// use the input points and point attributes.  This can result in a lot of
	/// unused points in the output, at some gain in filter performance.  If
	/// enabled, point merging will generate only new points that are used by the
	/// output polydata cells.
	///
	/// @warning
	/// This class is templated. It may run slower than serial execution if the code
	/// is not optimized during compilation. Build in Release or ReleaseWithDebugInfo.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDataSetSurfaceFilter vtkImageDataGeometryFilter
	/// vtkStructuredGridGeometryFilter vtkExtractGeometry vtkExtractVOI
	/// vtkMarkBoundaryFilter vtkRemovePolyData
	/// </seealso>
	// Token: 0x020005FF RID: 1535
	public class vtkGeometryFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010A59 RID: 68185 RVA: 0x00173B2A File Offset: 0x00171D2A
		static vtkGeometryFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeometryFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeometryFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010A5A RID: 68186 RVA: 0x00173B52 File Offset: 0x00171D52
		public vtkGeometryFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010A5B RID: 68187
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeometryFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06010A5C RID: 68188 RVA: 0x00173B60 File Offset: 0x00171D60
		public new static vtkGeometryFilter New()
		{
			vtkGeometryFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeometryFilter.vtkGeometryFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeometryFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06010A5D RID: 68189 RVA: 0x00173BB4 File Offset: 0x00171DB4
		public vtkGeometryFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGeometryFilter.vtkGeometryFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010A5E RID: 68190 RVA: 0x00173BF8 File Offset: 0x00171DF8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010A5F RID: 68191
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_CellClippingOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry by cell id.
		/// </summary>
		// Token: 0x06010A60 RID: 68192 RVA: 0x00173C03 File Offset: 0x00171E03
		public virtual void CellClippingOff()
		{
			vtkGeometryFilter.vtkGeometryFilter_CellClippingOff_01(base.GetCppThis());
		}

		// Token: 0x06010A61 RID: 68193
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_CellClippingOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry by cell id.
		/// </summary>
		// Token: 0x06010A62 RID: 68194 RVA: 0x00173C12 File Offset: 0x00171E12
		public virtual void CellClippingOn()
		{
			vtkGeometryFilter.vtkGeometryFilter_CellClippingOn_02(base.GetCppThis());
		}

		// Token: 0x06010A63 RID: 68195
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeometryFilter_DataSetExecute_03(HandleRef pThis, HandleRef input, HandleRef output, HandleRef exc);

		/// <summary>
		/// Direct access methods so that this class can be used as an
		/// algorithm without using it as a filter (i.e., no pipeline updates).
		/// Also some internal methods with additional options.
		/// </summary>
		// Token: 0x06010A64 RID: 68196 RVA: 0x00173C24 File Offset: 0x00171E24
		public int DataSetExecute(vtkDataSet input, vtkPolyData output, vtkPolyData exc)
		{
			return vtkGeometryFilter.vtkGeometryFilter_DataSetExecute_03(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis(), (exc == null) ? default(HandleRef) : exc.GetCppThis());
		}

		// Token: 0x06010A65 RID: 68197
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeometryFilter_DataSetExecute_04(HandleRef pThis, HandleRef input, HandleRef output);

		/// <summary>
		/// Direct access methods so that this class can be used as an
		/// algorithm without using it as a filter (i.e., no pipeline updates).
		/// Also some internal methods with additional options.
		/// </summary>
		// Token: 0x06010A66 RID: 68198 RVA: 0x00173C84 File Offset: 0x00171E84
		public virtual int DataSetExecute(vtkDataSet input, vtkPolyData output)
		{
			return vtkGeometryFilter.vtkGeometryFilter_DataSetExecute_04(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x06010A67 RID: 68199
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_DelegationOff_05(HandleRef pThis);

		/// <summary>
		/// Disable delegation to an internal vtkDataSetSurfaceFilter.
		/// </summary>
		// Token: 0x06010A68 RID: 68200 RVA: 0x00173CCD File Offset: 0x00171ECD
		public virtual void DelegationOff()
		{
			vtkGeometryFilter.vtkGeometryFilter_DelegationOff_05(base.GetCppThis());
		}

		// Token: 0x06010A69 RID: 68201
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_DelegationOn_06(HandleRef pThis);

		/// <summary>
		/// Disable delegation to an internal vtkDataSetSurfaceFilter.
		/// </summary>
		// Token: 0x06010A6A RID: 68202 RVA: 0x00173CDC File Offset: 0x00171EDC
		public virtual void DelegationOn()
		{
			vtkGeometryFilter.vtkGeometryFilter_DelegationOn_06(base.GetCppThis());
		}

		// Token: 0x06010A6B RID: 68203
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_ExtentClippingOff_07(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry via bounding box.
		/// </summary>
		// Token: 0x06010A6C RID: 68204 RVA: 0x00173CEB File Offset: 0x00171EEB
		public virtual void ExtentClippingOff()
		{
			vtkGeometryFilter.vtkGeometryFilter_ExtentClippingOff_07(base.GetCppThis());
		}

		// Token: 0x06010A6D RID: 68205
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_ExtentClippingOn_08(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry via bounding box.
		/// </summary>
		// Token: 0x06010A6E RID: 68206 RVA: 0x00173CFA File Offset: 0x00171EFA
		public virtual void ExtentClippingOn()
		{
			vtkGeometryFilter.vtkGeometryFilter_ExtentClippingOn_08(base.GetCppThis());
		}

		// Token: 0x06010A6F RID: 68207
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_FastModeOff_09(HandleRef pThis);

		/// <summary>
		/// Turn on/off fast mode execution. If enabled, fast mode typically runs
		/// much faster (2-3x) than the standard algorithm, however the output is an
		/// approximation to the correct result. FastMode is only meaningful when
		/// the input is vtkImageData/vtkRectilinearGrid/vtkStructuredGrid and there
		/// are blank cells.
		/// </summary>
		// Token: 0x06010A70 RID: 68208 RVA: 0x00173D09 File Offset: 0x00171F09
		public virtual void FastModeOff()
		{
			vtkGeometryFilter.vtkGeometryFilter_FastModeOff_09(base.GetCppThis());
		}

		// Token: 0x06010A71 RID: 68209
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_FastModeOn_10(HandleRef pThis);

		/// <summary>
		/// Turn on/off fast mode execution. If enabled, fast mode typically runs
		/// much faster (2-3x) than the standard algorithm, however the output is an
		/// approximation to the correct result. FastMode is only meaningful when
		/// the input is vtkImageData/vtkRectilinearGrid/vtkStructuredGrid and there
		/// are blank cells.
		/// </summary>
		// Token: 0x06010A72 RID: 68210 RVA: 0x00173D18 File Offset: 0x00171F18
		public virtual void FastModeOn()
		{
			vtkGeometryFilter.vtkGeometryFilter_FastModeOn_10(base.GetCppThis());
		}

		// Token: 0x06010A73 RID: 68211
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGeometryFilter_GetCellClipping_11(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry by cell id.
		/// </summary>
		// Token: 0x06010A74 RID: 68212 RVA: 0x00173D28 File Offset: 0x00171F28
		public virtual bool GetCellClipping()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetCellClipping_11(base.GetCppThis()) != 0;
		}

		// Token: 0x06010A75 RID: 68213
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeometryFilter_GetCellMaximum_12(HandleRef pThis);

		/// <summary>
		/// Specify the maximum cell id for point id selection.
		/// </summary>
		// Token: 0x06010A76 RID: 68214 RVA: 0x00173D50 File Offset: 0x00171F50
		public virtual long GetCellMaximum()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetCellMaximum_12(base.GetCppThis());
		}

		// Token: 0x06010A77 RID: 68215
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeometryFilter_GetCellMaximumMaxValue_13(HandleRef pThis);

		/// <summary>
		/// Specify the maximum cell id for point id selection.
		/// </summary>
		// Token: 0x06010A78 RID: 68216 RVA: 0x00173D70 File Offset: 0x00171F70
		public virtual long GetCellMaximumMaxValue()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetCellMaximumMaxValue_13(base.GetCppThis());
		}

		// Token: 0x06010A79 RID: 68217
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeometryFilter_GetCellMaximumMinValue_14(HandleRef pThis);

		/// <summary>
		/// Specify the maximum cell id for point id selection.
		/// </summary>
		// Token: 0x06010A7A RID: 68218 RVA: 0x00173D90 File Offset: 0x00171F90
		public virtual long GetCellMaximumMinValue()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetCellMaximumMinValue_14(base.GetCppThis());
		}

		// Token: 0x06010A7B RID: 68219
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeometryFilter_GetCellMinimum_15(HandleRef pThis);

		/// <summary>
		/// Specify the minimum cell id for point id selection.
		/// </summary>
		// Token: 0x06010A7C RID: 68220 RVA: 0x00173DB0 File Offset: 0x00171FB0
		public virtual long GetCellMinimum()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetCellMinimum_15(base.GetCppThis());
		}

		// Token: 0x06010A7D RID: 68221
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeometryFilter_GetCellMinimumMaxValue_16(HandleRef pThis);

		/// <summary>
		/// Specify the minimum cell id for point id selection.
		/// </summary>
		// Token: 0x06010A7E RID: 68222 RVA: 0x00173DD0 File Offset: 0x00171FD0
		public virtual long GetCellMinimumMaxValue()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetCellMinimumMaxValue_16(base.GetCppThis());
		}

		// Token: 0x06010A7F RID: 68223
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeometryFilter_GetCellMinimumMinValue_17(HandleRef pThis);

		/// <summary>
		/// Specify the minimum cell id for point id selection.
		/// </summary>
		// Token: 0x06010A80 RID: 68224 RVA: 0x00173DF0 File Offset: 0x00171FF0
		public virtual long GetCellMinimumMinValue()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetCellMinimumMinValue_17(base.GetCppThis());
		}

		// Token: 0x06010A81 RID: 68225
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeometryFilter_GetDelegation_18(HandleRef pThis);

		/// <summary>
		/// Disable delegation to an internal vtkDataSetSurfaceFilter.
		/// </summary>
		// Token: 0x06010A82 RID: 68226 RVA: 0x00173E10 File Offset: 0x00172010
		public virtual int GetDelegation()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetDelegation_18(base.GetCppThis());
		}

		// Token: 0x06010A83 RID: 68227
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeometryFilter_GetExcludedFaces_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// If a second, vtkPolyData input is provided, this second input specifies
		/// a list of faces to be excluded from the output (in the
		/// vtkPolyData::Polys attribute). This is useful to prevent the same face
		/// to be output multiple times in complex pipelines. (A candidate output
		/// boundary face is the same as a face in the excluded face list if it uses
		/// the same point ids as one of the polygons defined in the second input.) For
		/// example, a face may be extracted separately via a threshold filter; thus
		/// this face should not be also extracted via the vtkGeometryFilter. (This
		/// functionality is related to vtkRemovePolyData.)
		/// </summary>
		// Token: 0x06010A84 RID: 68228 RVA: 0x00173E30 File Offset: 0x00172030
		public vtkPolyData GetExcludedFaces()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeometryFilter.vtkGeometryFilter_GetExcludedFaces_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06010A85 RID: 68229
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeometryFilter_GetExtent_20(HandleRef pThis);

		/// <summary>
		/// Set / get a (xmin,xmax, ymin,ymax, zmin,zmax) bounding box to clip data.
		/// </summary>
		// Token: 0x06010A86 RID: 68230 RVA: 0x00173EA0 File Offset: 0x001720A0
		public double[] GetExtent()
		{
			IntPtr intPtr = vtkGeometryFilter.vtkGeometryFilter_GetExtent_20(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06010A87 RID: 68231
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGeometryFilter_GetExtentClipping_21(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry via bounding box.
		/// </summary>
		// Token: 0x06010A88 RID: 68232 RVA: 0x00173EE8 File Offset: 0x001720E8
		public virtual bool GetExtentClipping()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetExtentClipping_21(base.GetCppThis()) != 0;
		}

		// Token: 0x06010A89 RID: 68233
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGeometryFilter_GetFastMode_22(HandleRef pThis);

		/// <summary>
		/// Turn on/off fast mode execution. If enabled, fast mode typically runs
		/// much faster (2-3x) than the standard algorithm, however the output is an
		/// approximation to the correct result. FastMode is only meaningful when
		/// the input is vtkImageData/vtkRectilinearGrid/vtkStructuredGrid and there
		/// are blank cells.
		/// </summary>
		// Token: 0x06010A8A RID: 68234 RVA: 0x00173F10 File Offset: 0x00172110
		public virtual bool GetFastMode()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetFastMode_22(base.GetCppThis()) != 0;
		}

		// Token: 0x06010A8B RID: 68235
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeometryFilter_GetMatchBoundariesIgnoringCellOrder_23(HandleRef pThis);

		/// <summary>
		/// When two volumetric cells of different order are connected by their corners (for instance, a
		/// quadratic hexahedron next to a linear hexahedron ), the internal face is rendered and is not
		/// considered as a ghost cell. To remove these faces, switch MatchBoundariesIgnoringCellOrder to 1
		/// (default is 0).
		/// </summary>
		// Token: 0x06010A8C RID: 68236 RVA: 0x00173F38 File Offset: 0x00172138
		public virtual int GetMatchBoundariesIgnoringCellOrder()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetMatchBoundariesIgnoringCellOrder_23(base.GetCppThis());
		}

		// Token: 0x06010A8D RID: 68237
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGeometryFilter_GetMerging_24(HandleRef pThis);

		/// <summary>
		/// Turn on/off merging of points. This will reduce the number of output
		/// points, at some cost to performance. If Merging is off, then if possible
		/// (i.e., if the point representation is explicit), the filter will reuse
		/// the input points to create the output polydata. Certain input dataset
		/// types (with implicit point representations) will always create new
		/// points (effectively performing a merge operation).
		/// </summary>
		// Token: 0x06010A8E RID: 68238 RVA: 0x00173F58 File Offset: 0x00172158
		public virtual bool GetMerging()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetMerging_24(base.GetCppThis()) != 0;
		}

		// Token: 0x06010A8F RID: 68239
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeometryFilter_GetNonlinearSubdivisionLevel_25(HandleRef pThis);

		/// <summary>
		/// If the input is an unstructured grid with nonlinear faces, this parameter
		/// determines how many times the face is subdivided into linear faces.  If 0,
		/// the output is the equivalent of its linear counterpart (and the midpoints
		/// determining the nonlinear interpolation are discarded).  If 1 (the
		/// default), the nonlinear face is triangulated based on the midpoints.  If
		/// greater than 1, the triangulated pieces are recursively subdivided to reach
		/// the desired subdivision.  Setting the value to greater than 1 may cause
		/// some point data to not be passed even if no nonlinear faces exist.  This
		/// option has no effect if the input is not an unstructured grid.
		/// </summary>
		// Token: 0x06010A90 RID: 68240 RVA: 0x00173F80 File Offset: 0x00172180
		public virtual int GetNonlinearSubdivisionLevel()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetNonlinearSubdivisionLevel_25(base.GetCppThis());
		}

		// Token: 0x06010A91 RID: 68241
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeometryFilter_GetNumberOfGenerationsFromBase_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06010A92 RID: 68242 RVA: 0x00173FA0 File Offset: 0x001721A0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetNumberOfGenerationsFromBase_26(base.GetCppThis(), type);
		}

		// Token: 0x06010A93 RID: 68243
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeometryFilter_GetNumberOfGenerationsFromBaseType_27([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06010A94 RID: 68244 RVA: 0x00173FC0 File Offset: 0x001721C0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetNumberOfGenerationsFromBaseType_27(type);
		}

		// Token: 0x06010A95 RID: 68245
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeometryFilter_GetOriginalCellIdsName_28(HandleRef pThis);

		/// <summary>
		/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
		/// control the name given to the field in which the ids are written into.  If
		/// set to nullptr, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
		/// is used, respectively.
		/// </summary>
		// Token: 0x06010A96 RID: 68246 RVA: 0x00173FDC File Offset: 0x001721DC
		public virtual string GetOriginalCellIdsName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGeometryFilter.vtkGeometryFilter_GetOriginalCellIdsName_28(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06010A97 RID: 68247
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeometryFilter_GetOriginalPointIdsName_29(HandleRef pThis);

		/// <summary>
		/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
		/// control the name given to the field in which the ids are written into.  If
		/// set to nullptr, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
		/// is used, respectively.
		/// </summary>
		// Token: 0x06010A98 RID: 68248 RVA: 0x00174018 File Offset: 0x00172218
		public virtual string GetOriginalPointIdsName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGeometryFilter.vtkGeometryFilter_GetOriginalPointIdsName_29(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06010A99 RID: 68249
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeometryFilter_GetOutputPointsPrecision_30(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the
		/// documentation for the vtkAlgorithm::DesiredOutputPrecision enum for an
		/// explanation of the available precision settings. This only applies for
		/// data types where we create points (merging) as opposed to passing them
		/// from input to output, such as unstructured grids.
		/// </summary>
		// Token: 0x06010A9A RID: 68250 RVA: 0x00174054 File Offset: 0x00172254
		public int GetOutputPointsPrecision()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetOutputPointsPrecision_30(base.GetCppThis());
		}

		// Token: 0x06010A9B RID: 68251
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeometryFilter_GetPassThroughCellIds_31(HandleRef pThis);

		/// <summary>
		/// This parameter drives the generation or not of a CellData array for the output
		/// polygonal dataset that holds the cell index of the original 3D cell that produced
		/// each output cell. This is useful for cell picking. The default is off to conserve memory.
		///
		/// Note: Use SetOriginalCellIdsName() to set the name of the CellData array.
		/// </summary>
		// Token: 0x06010A9C RID: 68252 RVA: 0x00174074 File Offset: 0x00172274
		public virtual int GetPassThroughCellIds()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetPassThroughCellIds_31(base.GetCppThis());
		}

		// Token: 0x06010A9D RID: 68253
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeometryFilter_GetPassThroughPointIds_32(HandleRef pThis);

		/// <summary>
		/// This parameter drives the generation or not of a PointData array for the output
		/// polygonal dataset that holds the cell/point index of the original point that produced
		/// each output point. This is useful for point picking. The default is off to conserve memory.
		///
		/// Note: Use SetOriginalPointIdsName() to set the name of the PointData array.
		/// </summary>
		// Token: 0x06010A9E RID: 68254 RVA: 0x00174094 File Offset: 0x00172294
		public virtual int GetPassThroughPointIds()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetPassThroughPointIds_32(base.GetCppThis());
		}

		// Token: 0x06010A9F RID: 68255
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeometryFilter_GetPieceInvariant_33(HandleRef pThis);

		/// <summary>
		/// If PieceInvariant is true, vtkGeometryFilter requests
		/// 1 ghost level from input in order to remove internal surface
		/// that are between processes. False by default.
		/// </summary>
		// Token: 0x06010AA0 RID: 68256 RVA: 0x001740B4 File Offset: 0x001722B4
		public virtual int GetPieceInvariant()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetPieceInvariant_33(base.GetCppThis());
		}

		// Token: 0x06010AA1 RID: 68257
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGeometryFilter_GetPointClipping_34(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry by point id.
		/// </summary>
		// Token: 0x06010AA2 RID: 68258 RVA: 0x001740D4 File Offset: 0x001722D4
		public virtual bool GetPointClipping()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetPointClipping_34(base.GetCppThis()) != 0;
		}

		// Token: 0x06010AA3 RID: 68259
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeometryFilter_GetPointMaximum_35(HandleRef pThis);

		/// <summary>
		/// Specify the maximum point id for point id selection.
		/// </summary>
		// Token: 0x06010AA4 RID: 68260 RVA: 0x001740FC File Offset: 0x001722FC
		public virtual long GetPointMaximum()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetPointMaximum_35(base.GetCppThis());
		}

		// Token: 0x06010AA5 RID: 68261
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeometryFilter_GetPointMaximumMaxValue_36(HandleRef pThis);

		/// <summary>
		/// Specify the maximum point id for point id selection.
		/// </summary>
		// Token: 0x06010AA6 RID: 68262 RVA: 0x0017411C File Offset: 0x0017231C
		public virtual long GetPointMaximumMaxValue()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetPointMaximumMaxValue_36(base.GetCppThis());
		}

		// Token: 0x06010AA7 RID: 68263
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeometryFilter_GetPointMaximumMinValue_37(HandleRef pThis);

		/// <summary>
		/// Specify the maximum point id for point id selection.
		/// </summary>
		// Token: 0x06010AA8 RID: 68264 RVA: 0x0017413C File Offset: 0x0017233C
		public virtual long GetPointMaximumMinValue()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetPointMaximumMinValue_37(base.GetCppThis());
		}

		// Token: 0x06010AA9 RID: 68265
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeometryFilter_GetPointMinimum_38(HandleRef pThis);

		/// <summary>
		/// Specify the minimum point id for point id selection.
		/// </summary>
		// Token: 0x06010AAA RID: 68266 RVA: 0x0017415C File Offset: 0x0017235C
		public virtual long GetPointMinimum()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetPointMinimum_38(base.GetCppThis());
		}

		// Token: 0x06010AAB RID: 68267
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeometryFilter_GetPointMinimumMaxValue_39(HandleRef pThis);

		/// <summary>
		/// Specify the minimum point id for point id selection.
		/// </summary>
		// Token: 0x06010AAC RID: 68268 RVA: 0x0017417C File Offset: 0x0017237C
		public virtual long GetPointMinimumMaxValue()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetPointMinimumMaxValue_39(base.GetCppThis());
		}

		// Token: 0x06010AAD RID: 68269
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeometryFilter_GetPointMinimumMinValue_40(HandleRef pThis);

		/// <summary>
		/// Specify the minimum point id for point id selection.
		/// </summary>
		// Token: 0x06010AAE RID: 68270 RVA: 0x0017419C File Offset: 0x0017239C
		public virtual long GetPointMinimumMinValue()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetPointMinimumMinValue_40(base.GetCppThis());
		}

		// Token: 0x06010AAF RID: 68271
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGeometryFilter_GetRemoveGhostInterfaces_41(HandleRef pThis);

		/// <summary>
		/// Set/Get if Ghost interfaces will be removed.
		/// When you are rendering you want to remove ghost interfaces that originate from duplicate cells.
		///
		/// There are certain algorithms though that need the ghost interfaces, such as GhostCellGenerator
		/// and FeatureEdges.
		///
		/// Since Rendering is the most common case, the Default is on.
		///
		/// Note: DON'T change it if there are no ghost cells.
		/// </summary>
		// Token: 0x06010AB0 RID: 68272 RVA: 0x001741BC File Offset: 0x001723BC
		public virtual bool GetRemoveGhostInterfaces()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetRemoveGhostInterfaces_41(base.GetCppThis()) != 0;
		}

		// Token: 0x06010AB1 RID: 68273
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeometryFilter_IsA_42(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06010AB2 RID: 68274 RVA: 0x001741E4 File Offset: 0x001723E4
		public override int IsA(string type)
		{
			return vtkGeometryFilter.vtkGeometryFilter_IsA_42(base.GetCppThis(), type);
		}

		// Token: 0x06010AB3 RID: 68275
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeometryFilter_IsTypeOf_43([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06010AB4 RID: 68276 RVA: 0x00174204 File Offset: 0x00172404
		public new static int IsTypeOf(string type)
		{
			return vtkGeometryFilter.vtkGeometryFilter_IsTypeOf_43(type);
		}

		// Token: 0x06010AB5 RID: 68277
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_MergingOff_44(HandleRef pThis);

		/// <summary>
		/// Turn on/off merging of points. This will reduce the number of output
		/// points, at some cost to performance. If Merging is off, then if possible
		/// (i.e., if the point representation is explicit), the filter will reuse
		/// the input points to create the output polydata. Certain input dataset
		/// types (with implicit point representations) will always create new
		/// points (effectively performing a merge operation).
		/// </summary>
		// Token: 0x06010AB6 RID: 68278 RVA: 0x0017421E File Offset: 0x0017241E
		public virtual void MergingOff()
		{
			vtkGeometryFilter.vtkGeometryFilter_MergingOff_44(base.GetCppThis());
		}

		// Token: 0x06010AB7 RID: 68279
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_MergingOn_45(HandleRef pThis);

		/// <summary>
		/// Turn on/off merging of points. This will reduce the number of output
		/// points, at some cost to performance. If Merging is off, then if possible
		/// (i.e., if the point representation is explicit), the filter will reuse
		/// the input points to create the output polydata. Certain input dataset
		/// types (with implicit point representations) will always create new
		/// points (effectively performing a merge operation).
		/// </summary>
		// Token: 0x06010AB8 RID: 68280 RVA: 0x0017422D File Offset: 0x0017242D
		public virtual void MergingOn()
		{
			vtkGeometryFilter.vtkGeometryFilter_MergingOn_45(base.GetCppThis());
		}

		// Token: 0x06010AB9 RID: 68281
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeometryFilter_NewInstance_47(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06010ABA RID: 68282 RVA: 0x0017423C File Offset: 0x0017243C
		public new vtkGeometryFilter NewInstance()
		{
			vtkGeometryFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeometryFilter.vtkGeometryFilter_NewInstance_47(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeometryFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010ABB RID: 68283
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_PassThroughCellIdsOff_48(HandleRef pThis);

		/// <summary>
		/// This parameter drives the generation or not of a CellData array for the output
		/// polygonal dataset that holds the cell index of the original 3D cell that produced
		/// each output cell. This is useful for cell picking. The default is off to conserve memory.
		///
		/// Note: Use SetOriginalCellIdsName() to set the name of the CellData array.
		/// </summary>
		// Token: 0x06010ABC RID: 68284 RVA: 0x00174296 File Offset: 0x00172496
		public virtual void PassThroughCellIdsOff()
		{
			vtkGeometryFilter.vtkGeometryFilter_PassThroughCellIdsOff_48(base.GetCppThis());
		}

		// Token: 0x06010ABD RID: 68285
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_PassThroughCellIdsOn_49(HandleRef pThis);

		/// <summary>
		/// This parameter drives the generation or not of a CellData array for the output
		/// polygonal dataset that holds the cell index of the original 3D cell that produced
		/// each output cell. This is useful for cell picking. The default is off to conserve memory.
		///
		/// Note: Use SetOriginalCellIdsName() to set the name of the CellData array.
		/// </summary>
		// Token: 0x06010ABE RID: 68286 RVA: 0x001742A5 File Offset: 0x001724A5
		public virtual void PassThroughCellIdsOn()
		{
			vtkGeometryFilter.vtkGeometryFilter_PassThroughCellIdsOn_49(base.GetCppThis());
		}

		// Token: 0x06010ABF RID: 68287
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_PassThroughPointIdsOff_50(HandleRef pThis);

		/// <summary>
		/// This parameter drives the generation or not of a PointData array for the output
		/// polygonal dataset that holds the cell/point index of the original point that produced
		/// each output point. This is useful for point picking. The default is off to conserve memory.
		///
		/// Note: Use SetOriginalPointIdsName() to set the name of the PointData array.
		/// </summary>
		// Token: 0x06010AC0 RID: 68288 RVA: 0x001742B4 File Offset: 0x001724B4
		public virtual void PassThroughPointIdsOff()
		{
			vtkGeometryFilter.vtkGeometryFilter_PassThroughPointIdsOff_50(base.GetCppThis());
		}

		// Token: 0x06010AC1 RID: 68289
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_PassThroughPointIdsOn_51(HandleRef pThis);

		/// <summary>
		/// This parameter drives the generation or not of a PointData array for the output
		/// polygonal dataset that holds the cell/point index of the original point that produced
		/// each output point. This is useful for point picking. The default is off to conserve memory.
		///
		/// Note: Use SetOriginalPointIdsName() to set the name of the PointData array.
		/// </summary>
		// Token: 0x06010AC2 RID: 68290 RVA: 0x001742C3 File Offset: 0x001724C3
		public virtual void PassThroughPointIdsOn()
		{
			vtkGeometryFilter.vtkGeometryFilter_PassThroughPointIdsOn_51(base.GetCppThis());
		}

		// Token: 0x06010AC3 RID: 68291
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_PointClippingOff_52(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry by point id.
		/// </summary>
		// Token: 0x06010AC4 RID: 68292 RVA: 0x001742D2 File Offset: 0x001724D2
		public virtual void PointClippingOff()
		{
			vtkGeometryFilter.vtkGeometryFilter_PointClippingOff_52(base.GetCppThis());
		}

		// Token: 0x06010AC5 RID: 68293
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_PointClippingOn_53(HandleRef pThis);

		/// <summary>
		/// Turn on/off selection of geometry by point id.
		/// </summary>
		// Token: 0x06010AC6 RID: 68294 RVA: 0x001742E1 File Offset: 0x001724E1
		public virtual void PointClippingOn()
		{
			vtkGeometryFilter.vtkGeometryFilter_PointClippingOn_53(base.GetCppThis());
		}

		// Token: 0x06010AC7 RID: 68295
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeometryFilter_PolyDataExecute_54(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Direct access methods so that this class can be used as an
		/// algorithm without using it as a filter (i.e., no pipeline updates).
		/// Also some internal methods with additional options.
		/// </summary>
		// Token: 0x06010AC8 RID: 68296 RVA: 0x001742F0 File Offset: 0x001724F0
		public virtual int PolyDataExecute(vtkDataSet arg0, vtkPolyData arg1)
		{
			return vtkGeometryFilter.vtkGeometryFilter_PolyDataExecute_54(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06010AC9 RID: 68297
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeometryFilter_PolyDataExecute_55(HandleRef pThis, HandleRef input, HandleRef output, HandleRef exc);

		/// <summary>
		/// Direct access methods so that this class can be used as an
		/// algorithm without using it as a filter (i.e., no pipeline updates).
		/// Also some internal methods with additional options.
		/// </summary>
		// Token: 0x06010ACA RID: 68298 RVA: 0x0017433C File Offset: 0x0017253C
		public int PolyDataExecute(vtkDataSet input, vtkPolyData output, vtkPolyData exc)
		{
			return vtkGeometryFilter.vtkGeometryFilter_PolyDataExecute_55(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis(), (exc == null) ? default(HandleRef) : exc.GetCppThis());
		}

		// Token: 0x06010ACB RID: 68299
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_RemoveGhostInterfacesOff_56(HandleRef pThis);

		/// <summary>
		/// Set/Get if Ghost interfaces will be removed.
		/// When you are rendering you want to remove ghost interfaces that originate from duplicate cells.
		///
		/// There are certain algorithms though that need the ghost interfaces, such as GhostCellGenerator
		/// and FeatureEdges.
		///
		/// Since Rendering is the most common case, the Default is on.
		///
		/// Note: DON'T change it if there are no ghost cells.
		/// </summary>
		// Token: 0x06010ACC RID: 68300 RVA: 0x0017439A File Offset: 0x0017259A
		public virtual void RemoveGhostInterfacesOff()
		{
			vtkGeometryFilter.vtkGeometryFilter_RemoveGhostInterfacesOff_56(base.GetCppThis());
		}

		// Token: 0x06010ACD RID: 68301
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_RemoveGhostInterfacesOn_57(HandleRef pThis);

		/// <summary>
		/// Set/Get if Ghost interfaces will be removed.
		/// When you are rendering you want to remove ghost interfaces that originate from duplicate cells.
		///
		/// There are certain algorithms though that need the ghost interfaces, such as GhostCellGenerator
		/// and FeatureEdges.
		///
		/// Since Rendering is the most common case, the Default is on.
		///
		/// Note: DON'T change it if there are no ghost cells.
		/// </summary>
		// Token: 0x06010ACE RID: 68302 RVA: 0x001743A9 File Offset: 0x001725A9
		public virtual void RemoveGhostInterfacesOn()
		{
			vtkGeometryFilter.vtkGeometryFilter_RemoveGhostInterfacesOn_57(base.GetCppThis());
		}

		// Token: 0x06010ACF RID: 68303
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeometryFilter_SafeDownCast_58(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06010AD0 RID: 68304 RVA: 0x001743B8 File Offset: 0x001725B8
		public new static vtkGeometryFilter SafeDownCast(vtkObjectBase o)
		{
			vtkGeometryFilter vtkGeometryFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeometryFilter.vtkGeometryFilter_SafeDownCast_58((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeometryFilter = (vtkGeometryFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeometryFilter.Register(null);
				}
			}
			return vtkGeometryFilter;
		}

		// Token: 0x06010AD1 RID: 68305
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_SetCellClipping_59(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off selection of geometry by cell id.
		/// </summary>
		// Token: 0x06010AD2 RID: 68306 RVA: 0x00174437 File Offset: 0x00172637
		public virtual void SetCellClipping(bool _arg)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetCellClipping_59(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06010AD3 RID: 68307
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_SetCellMaximum_60(HandleRef pThis, long _arg);

		/// <summary>
		/// Specify the maximum cell id for point id selection.
		/// </summary>
		// Token: 0x06010AD4 RID: 68308 RVA: 0x0017444F File Offset: 0x0017264F
		public virtual void SetCellMaximum(long _arg)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetCellMaximum_60(base.GetCppThis(), _arg);
		}

		// Token: 0x06010AD5 RID: 68309
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_SetCellMinimum_61(HandleRef pThis, long _arg);

		/// <summary>
		/// Specify the minimum cell id for point id selection.
		/// </summary>
		// Token: 0x06010AD6 RID: 68310 RVA: 0x0017445F File Offset: 0x0017265F
		public virtual void SetCellMinimum(long _arg)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetCellMinimum_61(base.GetCppThis(), _arg);
		}

		// Token: 0x06010AD7 RID: 68311
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_SetDelegation_62(HandleRef pThis, int _arg);

		/// <summary>
		/// Disable delegation to an internal vtkDataSetSurfaceFilter.
		/// </summary>
		// Token: 0x06010AD8 RID: 68312 RVA: 0x0017446F File Offset: 0x0017266F
		public virtual void SetDelegation(int _arg)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetDelegation_62(base.GetCppThis(), _arg);
		}

		// Token: 0x06010AD9 RID: 68313
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_SetExcludedFacesConnection_63(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// If a second, vtkPolyData input is provided, this second input specifies
		/// a list of faces to be excluded from the output (in the
		/// vtkPolyData::Polys attribute). This is useful to prevent the same face
		/// to be output multiple times in complex pipelines. (A candidate output
		/// boundary face is the same as a face in the excluded face list if it uses
		/// the same point ids as one of the polygons defined in the second input.) For
		/// example, a face may be extracted separately via a threshold filter; thus
		/// this face should not be also extracted via the vtkGeometryFilter. (This
		/// functionality is related to vtkRemovePolyData.)
		/// </summary>
		// Token: 0x06010ADA RID: 68314 RVA: 0x00174480 File Offset: 0x00172680
		public void SetExcludedFacesConnection(vtkAlgorithmOutput algOutput)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetExcludedFacesConnection_63(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x06010ADB RID: 68315
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_SetExcludedFacesData_64(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// If a second, vtkPolyData input is provided, this second input specifies
		/// a list of faces to be excluded from the output (in the
		/// vtkPolyData::Polys attribute). This is useful to prevent the same face
		/// to be output multiple times in complex pipelines. (A candidate output
		/// boundary face is the same as a face in the excluded face list if it uses
		/// the same point ids as one of the polygons defined in the second input.) For
		/// example, a face may be extracted separately via a threshold filter; thus
		/// this face should not be also extracted via the vtkGeometryFilter. (This
		/// functionality is related to vtkRemovePolyData.)
		/// </summary>
		// Token: 0x06010ADC RID: 68316 RVA: 0x001744B0 File Offset: 0x001726B0
		public void SetExcludedFacesData(vtkPolyData arg0)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetExcludedFacesData_64(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06010ADD RID: 68317
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_SetExtent_65(HandleRef pThis, double xMin, double xMax, double yMin, double yMax, double zMin, double zMax);

		/// <summary>
		/// Specify a (xmin,xmax, ymin,ymax, zmin,zmax) bounding box to clip data.
		/// </summary>
		// Token: 0x06010ADE RID: 68318 RVA: 0x001744DF File Offset: 0x001726DF
		public void SetExtent(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetExtent_65(base.GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
		}

		// Token: 0x06010ADF RID: 68319
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_SetExtent_66(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// Set / get a (xmin,xmax, ymin,ymax, zmin,zmax) bounding box to clip data.
		/// </summary>
		// Token: 0x06010AE0 RID: 68320 RVA: 0x001744F7 File Offset: 0x001726F7
		public void SetExtent(IntPtr extent)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetExtent_66(base.GetCppThis(), extent);
		}

		// Token: 0x06010AE1 RID: 68321
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_SetExtentClipping_67(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off selection of geometry via bounding box.
		/// </summary>
		// Token: 0x06010AE2 RID: 68322 RVA: 0x00174507 File Offset: 0x00172707
		public virtual void SetExtentClipping(bool _arg)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetExtentClipping_67(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06010AE3 RID: 68323
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_SetFastMode_68(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off fast mode execution. If enabled, fast mode typically runs
		/// much faster (2-3x) than the standard algorithm, however the output is an
		/// approximation to the correct result. FastMode is only meaningful when
		/// the input is vtkImageData/vtkRectilinearGrid/vtkStructuredGrid and there
		/// are blank cells.
		/// </summary>
		// Token: 0x06010AE4 RID: 68324 RVA: 0x0017451F File Offset: 0x0017271F
		public virtual void SetFastMode(bool _arg)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetFastMode_68(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06010AE5 RID: 68325
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_SetMatchBoundariesIgnoringCellOrder_69(HandleRef pThis, int _arg);

		/// <summary>
		/// When two volumetric cells of different order are connected by their corners (for instance, a
		/// quadratic hexahedron next to a linear hexahedron ), the internal face is rendered and is not
		/// considered as a ghost cell. To remove these faces, switch MatchBoundariesIgnoringCellOrder to 1
		/// (default is 0).
		/// </summary>
		// Token: 0x06010AE6 RID: 68326 RVA: 0x00174537 File Offset: 0x00172737
		public virtual void SetMatchBoundariesIgnoringCellOrder(int _arg)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetMatchBoundariesIgnoringCellOrder_69(base.GetCppThis(), _arg);
		}

		// Token: 0x06010AE7 RID: 68327
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_SetMerging_70(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off merging of points. This will reduce the number of output
		/// points, at some cost to performance. If Merging is off, then if possible
		/// (i.e., if the point representation is explicit), the filter will reuse
		/// the input points to create the output polydata. Certain input dataset
		/// types (with implicit point representations) will always create new
		/// points (effectively performing a merge operation).
		/// </summary>
		// Token: 0x06010AE8 RID: 68328 RVA: 0x00174547 File Offset: 0x00172747
		public virtual void SetMerging(bool _arg)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetMerging_70(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06010AE9 RID: 68329
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_SetNonlinearSubdivisionLevel_71(HandleRef pThis, int _arg);

		/// <summary>
		/// If the input is an unstructured grid with nonlinear faces, this parameter
		/// determines how many times the face is subdivided into linear faces.  If 0,
		/// the output is the equivalent of its linear counterpart (and the midpoints
		/// determining the nonlinear interpolation are discarded).  If 1 (the
		/// default), the nonlinear face is triangulated based on the midpoints.  If
		/// greater than 1, the triangulated pieces are recursively subdivided to reach
		/// the desired subdivision.  Setting the value to greater than 1 may cause
		/// some point data to not be passed even if no nonlinear faces exist.  This
		/// option has no effect if the input is not an unstructured grid.
		/// </summary>
		// Token: 0x06010AEA RID: 68330 RVA: 0x0017455F File Offset: 0x0017275F
		public virtual void SetNonlinearSubdivisionLevel(int _arg)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetNonlinearSubdivisionLevel_71(base.GetCppThis(), _arg);
		}

		// Token: 0x06010AEB RID: 68331
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_SetOriginalCellIdsName_72(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
		/// control the name given to the field in which the ids are written into.  If
		/// set to nullptr, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
		/// is used, respectively.
		/// </summary>
		// Token: 0x06010AEC RID: 68332 RVA: 0x0017456F File Offset: 0x0017276F
		public virtual void SetOriginalCellIdsName(string _arg)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetOriginalCellIdsName_72(base.GetCppThis(), _arg);
		}

		// Token: 0x06010AED RID: 68333
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_SetOriginalPointIdsName_73(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// If PassThroughCellIds or PassThroughPointIds is on, then these ivars
		/// control the name given to the field in which the ids are written into.  If
		/// set to nullptr, then vtkOriginalCellIds or vtkOriginalPointIds (the default)
		/// is used, respectively.
		/// </summary>
		// Token: 0x06010AEE RID: 68334 RVA: 0x0017457F File Offset: 0x0017277F
		public virtual void SetOriginalPointIdsName(string _arg)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetOriginalPointIdsName_73(base.GetCppThis(), _arg);
		}

		// Token: 0x06010AEF RID: 68335
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_SetOutputPointsPrecision_74(HandleRef pThis, int precision);

		/// <summary>
		/// Set/get the desired precision for the output types. See the
		/// documentation for the vtkAlgorithm::DesiredOutputPrecision enum for an
		/// explanation of the available precision settings. This only applies for
		/// data types where we create points (merging) as opposed to passing them
		/// from input to output, such as unstructured grids.
		/// </summary>
		// Token: 0x06010AF0 RID: 68336 RVA: 0x0017458F File Offset: 0x0017278F
		public void SetOutputPointsPrecision(int precision)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetOutputPointsPrecision_74(base.GetCppThis(), precision);
		}

		// Token: 0x06010AF1 RID: 68337
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_SetPassThroughCellIds_75(HandleRef pThis, int _arg);

		/// <summary>
		/// This parameter drives the generation or not of a CellData array for the output
		/// polygonal dataset that holds the cell index of the original 3D cell that produced
		/// each output cell. This is useful for cell picking. The default is off to conserve memory.
		///
		/// Note: Use SetOriginalCellIdsName() to set the name of the CellData array.
		/// </summary>
		// Token: 0x06010AF2 RID: 68338 RVA: 0x0017459F File Offset: 0x0017279F
		public virtual void SetPassThroughCellIds(int _arg)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetPassThroughCellIds_75(base.GetCppThis(), _arg);
		}

		// Token: 0x06010AF3 RID: 68339
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_SetPassThroughPointIds_76(HandleRef pThis, int _arg);

		/// <summary>
		/// This parameter drives the generation or not of a PointData array for the output
		/// polygonal dataset that holds the cell/point index of the original point that produced
		/// each output point. This is useful for point picking. The default is off to conserve memory.
		///
		/// Note: Use SetOriginalPointIdsName() to set the name of the PointData array.
		/// </summary>
		// Token: 0x06010AF4 RID: 68340 RVA: 0x001745AF File Offset: 0x001727AF
		public virtual void SetPassThroughPointIds(int _arg)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetPassThroughPointIds_76(base.GetCppThis(), _arg);
		}

		// Token: 0x06010AF5 RID: 68341
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_SetPieceInvariant_77(HandleRef pThis, int _arg);

		/// <summary>
		/// If PieceInvariant is true, vtkGeometryFilter requests
		/// 1 ghost level from input in order to remove internal surface
		/// that are between processes. False by default.
		/// </summary>
		// Token: 0x06010AF6 RID: 68342 RVA: 0x001745BF File Offset: 0x001727BF
		public virtual void SetPieceInvariant(int _arg)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetPieceInvariant_77(base.GetCppThis(), _arg);
		}

		// Token: 0x06010AF7 RID: 68343
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_SetPointClipping_78(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off selection of geometry by point id.
		/// </summary>
		// Token: 0x06010AF8 RID: 68344 RVA: 0x001745CF File Offset: 0x001727CF
		public virtual void SetPointClipping(bool _arg)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetPointClipping_78(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06010AF9 RID: 68345
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_SetPointMaximum_79(HandleRef pThis, long _arg);

		/// <summary>
		/// Specify the maximum point id for point id selection.
		/// </summary>
		// Token: 0x06010AFA RID: 68346 RVA: 0x001745E7 File Offset: 0x001727E7
		public virtual void SetPointMaximum(long _arg)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetPointMaximum_79(base.GetCppThis(), _arg);
		}

		// Token: 0x06010AFB RID: 68347
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_SetPointMinimum_80(HandleRef pThis, long _arg);

		/// <summary>
		/// Specify the minimum point id for point id selection.
		/// </summary>
		// Token: 0x06010AFC RID: 68348 RVA: 0x001745F7 File Offset: 0x001727F7
		public virtual void SetPointMinimum(long _arg)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetPointMinimum_80(base.GetCppThis(), _arg);
		}

		// Token: 0x06010AFD RID: 68349
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeometryFilter_SetRemoveGhostInterfaces_81(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get if Ghost interfaces will be removed.
		/// When you are rendering you want to remove ghost interfaces that originate from duplicate cells.
		///
		/// There are certain algorithms though that need the ghost interfaces, such as GhostCellGenerator
		/// and FeatureEdges.
		///
		/// Since Rendering is the most common case, the Default is on.
		///
		/// Note: DON'T change it if there are no ghost cells.
		/// </summary>
		// Token: 0x06010AFE RID: 68350 RVA: 0x00174607 File Offset: 0x00172807
		public virtual void SetRemoveGhostInterfaces(bool _arg)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetRemoveGhostInterfaces_81(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06010AFF RID: 68351
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeometryFilter_StructuredExecute_82(HandleRef pThis, HandleRef input, HandleRef output, IntPtr wholeExtent, HandleRef exc, IntPtr extractFace);

		/// <summary>
		/// Direct access methods so that this class can be used as an
		/// algorithm without using it as a filter (i.e., no pipeline updates).
		/// Also some internal methods with additional options.
		/// </summary>
		// Token: 0x06010B00 RID: 68352 RVA: 0x00174620 File Offset: 0x00172820
		public int StructuredExecute(vtkDataSet input, vtkPolyData output, IntPtr wholeExtent, vtkPolyData exc, IntPtr extractFace)
		{
			return vtkGeometryFilter.vtkGeometryFilter_StructuredExecute_82(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis(), wholeExtent, (exc == null) ? default(HandleRef) : exc.GetCppThis(), extractFace);
		}

		// Token: 0x06010B01 RID: 68353
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeometryFilter_StructuredExecute_83(HandleRef pThis, HandleRef input, HandleRef output, IntPtr wholeExt, IntPtr extractFace);

		/// <summary>
		/// Direct access methods so that this class can be used as an
		/// algorithm without using it as a filter (i.e., no pipeline updates).
		/// Also some internal methods with additional options.
		/// </summary>
		// Token: 0x06010B02 RID: 68354 RVA: 0x00174684 File Offset: 0x00172884
		public virtual int StructuredExecute(vtkDataSet input, vtkPolyData output, IntPtr wholeExt, IntPtr extractFace)
		{
			return vtkGeometryFilter.vtkGeometryFilter_StructuredExecute_83(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis(), wholeExt, extractFace);
		}

		// Token: 0x06010B03 RID: 68355
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeometryFilter_UnstructuredGridExecute_84(HandleRef pThis, HandleRef input, HandleRef output);

		/// <summary>
		/// Direct access methods so that this class can be used as an
		/// algorithm without using it as a filter (i.e., no pipeline updates).
		/// Also some internal methods with additional options.
		/// </summary>
		// Token: 0x06010B04 RID: 68356 RVA: 0x001746D0 File Offset: 0x001728D0
		public virtual int UnstructuredGridExecute(vtkDataSet input, vtkPolyData output)
		{
			return vtkGeometryFilter.vtkGeometryFilter_UnstructuredGridExecute_84(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001354 RID: 4948
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeometryFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001355 RID: 4949
		public new static readonly string MRClassNameKey = "class vtkGeometryFilter";
	}
}
