using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFitToHeightMapFilter
	/// </summary>
	/// <remarks>
	///    adjust polydata to fit image height map
	///
	/// vtkFitToHeightMapFilter "drapes" or "covers" a height map image by
	/// determining new point coordinates of an input polydata by projecting (in
	/// the z-direction) onto the height map. Different projection approaches can
	/// be used including projecting points, or averaging / taking the minimum /
	/// taking the maximum of the cell's points or sampled interior points.  The
	/// filter passes the input to the output, however new new point coordinates
	/// are generated, and point normals are not passed through. Note that the
	/// draping supports verts, lines, polygons, and triangle strips.
	///
	/// @warning
	/// Since new point coordinates are generated, planar polygons may become
	/// non-planar. To guarantee planarity, use a triangle mesh as input. Also
	/// note that strategies based on averaging across a cell, or the points of a
	/// cell, set the z-value for all of the cell's points to the same
	/// value. However, as currently written, depending on the order in which
	/// cells are processed, the last z-value set is the final value (since points
	/// may be shared by multiple cells). Thus the filter works best with triangle
	/// meshes, or if cells are topologically disconnected (i.e., points are only
	/// used by one cell - use vtkShrinkFilter to topologically disconnect
	/// the cells in a mesh).
	///
	/// @warning
	/// The point normals are not passed through to the output as the projection
	/// process may distort the projected polydata surface.
	///
	/// @warning
	/// The interior cell sampling is currently carried out by triangulating the
	/// cells, and then taking the centroid of each resulting triangle. Thus the
	/// number of samples for each cell is (number of cell points - 2). Future
	/// implementations may use a different sampling strategy.
	///
	/// @warning
	/// Points outside of the height map image are clamped to the boundary of the
	/// height map. This may produce unexpected behavior in some cases.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTrimmedExtrusionFilter vtkShrinkFilter vtkShrinkPolyData
	/// </seealso>
	// Token: 0x02000555 RID: 1365
	public class vtkFitToHeightMapFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F2A9 RID: 62121 RVA: 0x00152163 File Offset: 0x00150363
		static vtkFitToHeightMapFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFitToHeightMapFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFitToHeightMapFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F2AA RID: 62122 RVA: 0x0015218B File Offset: 0x0015038B
		public vtkFitToHeightMapFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F2AB RID: 62123
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFitToHeightMapFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x0600F2AC RID: 62124 RVA: 0x0015219C File Offset: 0x0015039C
		public new static vtkFitToHeightMapFilter New()
		{
			vtkFitToHeightMapFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFitToHeightMapFilter.vtkFitToHeightMapFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFitToHeightMapFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x0600F2AD RID: 62125 RVA: 0x001521F0 File Offset: 0x001503F0
		public vtkFitToHeightMapFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFitToHeightMapFilter.vtkFitToHeightMapFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F2AE RID: 62126 RVA: 0x00152234 File Offset: 0x00150434
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F2AF RID: 62127
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFitToHeightMapFilter_GetFittingStrategy_01(HandleRef pThis);

		/// <summary>
		/// Specify a strategy for fitting, or projecting, the polydata to the
		/// height field.  By default the points of the polydata are projected onto
		/// the height field (POINT_PROJECTION).  However, to preserve planarity,
		/// or to fit the polydata cells at the average/minimum/maximum height to
		/// the height field, different strategies can be used (i.e., placing the
		/// cells). The point-based strategies (e.g, POINT_MINIMUM_HEIGHT) set the
		/// cell at the minimum height of the cell's points (and so on). The
		/// cell-based strategies (e.g., CELL_MINIMUM_HEIGHT) sample the interior of
		/// the cell and place the cell at the minimum height (and so on) of the
		/// cell's sampled interior points.
		/// </summary>
		// Token: 0x0600F2B0 RID: 62128 RVA: 0x00152240 File Offset: 0x00150440
		public virtual int GetFittingStrategy()
		{
			return vtkFitToHeightMapFilter.vtkFitToHeightMapFilter_GetFittingStrategy_01(base.GetCppThis());
		}

		// Token: 0x0600F2B1 RID: 62129
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFitToHeightMapFilter_GetHeightMap_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a pointer to the height map.
		/// </summary>
		// Token: 0x0600F2B2 RID: 62130 RVA: 0x00152260 File Offset: 0x00150460
		public vtkImageData GetHeightMap()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFitToHeightMapFilter.vtkFitToHeightMapFilter_GetHeightMap_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600F2B3 RID: 62131
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFitToHeightMapFilter_GetHeightMap_03(HandleRef pThis, HandleRef sourceInfo, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a pointer to the height map.
		/// </summary>
		// Token: 0x0600F2B4 RID: 62132 RVA: 0x001522D0 File Offset: 0x001504D0
		public vtkImageData GetHeightMap(vtkInformationVector sourceInfo)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFitToHeightMapFilter.vtkFitToHeightMapFilter_GetHeightMap_03(base.GetCppThis(), (sourceInfo == null) ? default(HandleRef) : sourceInfo.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600F2B5 RID: 62133
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFitToHeightMapFilter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x0600F2B6 RID: 62134 RVA: 0x00152358 File Offset: 0x00150558
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFitToHeightMapFilter.vtkFitToHeightMapFilter_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600F2B7 RID: 62135
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFitToHeightMapFilter_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x0600F2B8 RID: 62136 RVA: 0x00152378 File Offset: 0x00150578
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFitToHeightMapFilter.vtkFitToHeightMapFilter_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600F2B9 RID: 62137
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFitToHeightMapFilter_GetUseHeightMapOffset_06(HandleRef pThis);

		/// <summary>
		/// Indicate whether the z-offset from the image height map should be added
		/// to the final result. Some height map images are offset in z-coordinate
		/// which is independent of the height map values. By default this value is
		/// true.
		/// </summary>
		// Token: 0x0600F2BA RID: 62138 RVA: 0x00152394 File Offset: 0x00150594
		public virtual int GetUseHeightMapOffset()
		{
			return vtkFitToHeightMapFilter.vtkFitToHeightMapFilter_GetUseHeightMapOffset_06(base.GetCppThis());
		}

		// Token: 0x0600F2BB RID: 62139
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFitToHeightMapFilter_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x0600F2BC RID: 62140 RVA: 0x001523B4 File Offset: 0x001505B4
		public override int IsA(string type)
		{
			return vtkFitToHeightMapFilter.vtkFitToHeightMapFilter_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0600F2BD RID: 62141
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFitToHeightMapFilter_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x0600F2BE RID: 62142 RVA: 0x001523D4 File Offset: 0x001505D4
		public new static int IsTypeOf(string type)
		{
			return vtkFitToHeightMapFilter.vtkFitToHeightMapFilter_IsTypeOf_08(type);
		}

		// Token: 0x0600F2BF RID: 62143
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFitToHeightMapFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x0600F2C0 RID: 62144 RVA: 0x001523F0 File Offset: 0x001505F0
		public new vtkFitToHeightMapFilter NewInstance()
		{
			vtkFitToHeightMapFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFitToHeightMapFilter.vtkFitToHeightMapFilter_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFitToHeightMapFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F2C1 RID: 62145
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFitToHeightMapFilter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x0600F2C2 RID: 62146 RVA: 0x0015244C File Offset: 0x0015064C
		public new static vtkFitToHeightMapFilter SafeDownCast(vtkObjectBase o)
		{
			vtkFitToHeightMapFilter vtkFitToHeightMapFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFitToHeightMapFilter.vtkFitToHeightMapFilter_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFitToHeightMapFilter = (vtkFitToHeightMapFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFitToHeightMapFilter.Register(null);
				}
			}
			return vtkFitToHeightMapFilter;
		}

		// Token: 0x0600F2C3 RID: 62147
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFitToHeightMapFilter_SetFittingStrategy_12(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify a strategy for fitting, or projecting, the polydata to the
		/// height field.  By default the points of the polydata are projected onto
		/// the height field (POINT_PROJECTION).  However, to preserve planarity,
		/// or to fit the polydata cells at the average/minimum/maximum height to
		/// the height field, different strategies can be used (i.e., placing the
		/// cells). The point-based strategies (e.g, POINT_MINIMUM_HEIGHT) set the
		/// cell at the minimum height of the cell's points (and so on). The
		/// cell-based strategies (e.g., CELL_MINIMUM_HEIGHT) sample the interior of
		/// the cell and place the cell at the minimum height (and so on) of the
		/// cell's sampled interior points.
		/// </summary>
		// Token: 0x0600F2C4 RID: 62148 RVA: 0x001524CB File Offset: 0x001506CB
		public virtual void SetFittingStrategy(int _arg)
		{
			vtkFitToHeightMapFilter.vtkFitToHeightMapFilter_SetFittingStrategy_12(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F2C5 RID: 62149
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFitToHeightMapFilter_SetFittingStrategyToAverageHeight_13(HandleRef pThis);

		/// <summary>
		/// Specify a strategy for fitting, or projecting, the polydata to the
		/// height field.  By default the points of the polydata are projected onto
		/// the height field (POINT_PROJECTION).  However, to preserve planarity,
		/// or to fit the polydata cells at the average/minimum/maximum height to
		/// the height field, different strategies can be used (i.e., placing the
		/// cells). The point-based strategies (e.g, POINT_MINIMUM_HEIGHT) set the
		/// cell at the minimum height of the cell's points (and so on). The
		/// cell-based strategies (e.g., CELL_MINIMUM_HEIGHT) sample the interior of
		/// the cell and place the cell at the minimum height (and so on) of the
		/// cell's sampled interior points.
		/// </summary>
		// Token: 0x0600F2C6 RID: 62150 RVA: 0x001524DB File Offset: 0x001506DB
		public void SetFittingStrategyToAverageHeight()
		{
			vtkFitToHeightMapFilter.vtkFitToHeightMapFilter_SetFittingStrategyToAverageHeight_13(base.GetCppThis());
		}

		// Token: 0x0600F2C7 RID: 62151
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFitToHeightMapFilter_SetFittingStrategyToCellAverageHeight_14(HandleRef pThis);

		/// <summary>
		/// Specify a strategy for fitting, or projecting, the polydata to the
		/// height field.  By default the points of the polydata are projected onto
		/// the height field (POINT_PROJECTION).  However, to preserve planarity,
		/// or to fit the polydata cells at the average/minimum/maximum height to
		/// the height field, different strategies can be used (i.e., placing the
		/// cells). The point-based strategies (e.g, POINT_MINIMUM_HEIGHT) set the
		/// cell at the minimum height of the cell's points (and so on). The
		/// cell-based strategies (e.g., CELL_MINIMUM_HEIGHT) sample the interior of
		/// the cell and place the cell at the minimum height (and so on) of the
		/// cell's sampled interior points.
		/// </summary>
		// Token: 0x0600F2C8 RID: 62152 RVA: 0x001524EA File Offset: 0x001506EA
		public void SetFittingStrategyToCellAverageHeight()
		{
			vtkFitToHeightMapFilter.vtkFitToHeightMapFilter_SetFittingStrategyToCellAverageHeight_14(base.GetCppThis());
		}

		// Token: 0x0600F2C9 RID: 62153
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFitToHeightMapFilter_SetFittingStrategyToCellMaximumHeight_15(HandleRef pThis);

		/// <summary>
		/// Specify a strategy for fitting, or projecting, the polydata to the
		/// height field.  By default the points of the polydata are projected onto
		/// the height field (POINT_PROJECTION).  However, to preserve planarity,
		/// or to fit the polydata cells at the average/minimum/maximum height to
		/// the height field, different strategies can be used (i.e., placing the
		/// cells). The point-based strategies (e.g, POINT_MINIMUM_HEIGHT) set the
		/// cell at the minimum height of the cell's points (and so on). The
		/// cell-based strategies (e.g., CELL_MINIMUM_HEIGHT) sample the interior of
		/// the cell and place the cell at the minimum height (and so on) of the
		/// cell's sampled interior points.
		/// </summary>
		// Token: 0x0600F2CA RID: 62154 RVA: 0x001524F9 File Offset: 0x001506F9
		public void SetFittingStrategyToCellMaximumHeight()
		{
			vtkFitToHeightMapFilter.vtkFitToHeightMapFilter_SetFittingStrategyToCellMaximumHeight_15(base.GetCppThis());
		}

		// Token: 0x0600F2CB RID: 62155
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFitToHeightMapFilter_SetFittingStrategyToCellMinimumHeight_16(HandleRef pThis);

		/// <summary>
		/// Specify a strategy for fitting, or projecting, the polydata to the
		/// height field.  By default the points of the polydata are projected onto
		/// the height field (POINT_PROJECTION).  However, to preserve planarity,
		/// or to fit the polydata cells at the average/minimum/maximum height to
		/// the height field, different strategies can be used (i.e., placing the
		/// cells). The point-based strategies (e.g, POINT_MINIMUM_HEIGHT) set the
		/// cell at the minimum height of the cell's points (and so on). The
		/// cell-based strategies (e.g., CELL_MINIMUM_HEIGHT) sample the interior of
		/// the cell and place the cell at the minimum height (and so on) of the
		/// cell's sampled interior points.
		/// </summary>
		// Token: 0x0600F2CC RID: 62156 RVA: 0x00152508 File Offset: 0x00150708
		public void SetFittingStrategyToCellMinimumHeight()
		{
			vtkFitToHeightMapFilter.vtkFitToHeightMapFilter_SetFittingStrategyToCellMinimumHeight_16(base.GetCppThis());
		}

		// Token: 0x0600F2CD RID: 62157
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFitToHeightMapFilter_SetFittingStrategyToPointMaximumHeight_17(HandleRef pThis);

		/// <summary>
		/// Specify a strategy for fitting, or projecting, the polydata to the
		/// height field.  By default the points of the polydata are projected onto
		/// the height field (POINT_PROJECTION).  However, to preserve planarity,
		/// or to fit the polydata cells at the average/minimum/maximum height to
		/// the height field, different strategies can be used (i.e., placing the
		/// cells). The point-based strategies (e.g, POINT_MINIMUM_HEIGHT) set the
		/// cell at the minimum height of the cell's points (and so on). The
		/// cell-based strategies (e.g., CELL_MINIMUM_HEIGHT) sample the interior of
		/// the cell and place the cell at the minimum height (and so on) of the
		/// cell's sampled interior points.
		/// </summary>
		// Token: 0x0600F2CE RID: 62158 RVA: 0x00152517 File Offset: 0x00150717
		public void SetFittingStrategyToPointMaximumHeight()
		{
			vtkFitToHeightMapFilter.vtkFitToHeightMapFilter_SetFittingStrategyToPointMaximumHeight_17(base.GetCppThis());
		}

		// Token: 0x0600F2CF RID: 62159
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFitToHeightMapFilter_SetFittingStrategyToPointMinimumHeight_18(HandleRef pThis);

		/// <summary>
		/// Specify a strategy for fitting, or projecting, the polydata to the
		/// height field.  By default the points of the polydata are projected onto
		/// the height field (POINT_PROJECTION).  However, to preserve planarity,
		/// or to fit the polydata cells at the average/minimum/maximum height to
		/// the height field, different strategies can be used (i.e., placing the
		/// cells). The point-based strategies (e.g, POINT_MINIMUM_HEIGHT) set the
		/// cell at the minimum height of the cell's points (and so on). The
		/// cell-based strategies (e.g., CELL_MINIMUM_HEIGHT) sample the interior of
		/// the cell and place the cell at the minimum height (and so on) of the
		/// cell's sampled interior points.
		/// </summary>
		// Token: 0x0600F2D0 RID: 62160 RVA: 0x00152526 File Offset: 0x00150726
		public void SetFittingStrategyToPointMinimumHeight()
		{
			vtkFitToHeightMapFilter.vtkFitToHeightMapFilter_SetFittingStrategyToPointMinimumHeight_18(base.GetCppThis());
		}

		// Token: 0x0600F2D1 RID: 62161
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFitToHeightMapFilter_SetFittingStrategyToPointProjection_19(HandleRef pThis);

		/// <summary>
		/// Specify a strategy for fitting, or projecting, the polydata to the
		/// height field.  By default the points of the polydata are projected onto
		/// the height field (POINT_PROJECTION).  However, to preserve planarity,
		/// or to fit the polydata cells at the average/minimum/maximum height to
		/// the height field, different strategies can be used (i.e., placing the
		/// cells). The point-based strategies (e.g, POINT_MINIMUM_HEIGHT) set the
		/// cell at the minimum height of the cell's points (and so on). The
		/// cell-based strategies (e.g., CELL_MINIMUM_HEIGHT) sample the interior of
		/// the cell and place the cell at the minimum height (and so on) of the
		/// cell's sampled interior points.
		/// </summary>
		// Token: 0x0600F2D2 RID: 62162 RVA: 0x00152535 File Offset: 0x00150735
		public void SetFittingStrategyToPointProjection()
		{
			vtkFitToHeightMapFilter.vtkFitToHeightMapFilter_SetFittingStrategyToPointProjection_19(base.GetCppThis());
		}

		// Token: 0x0600F2D3 RID: 62163
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFitToHeightMapFilter_SetHeightMapConnection_20(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Specify the pipeline connection to the height map.
		/// </summary>
		// Token: 0x0600F2D4 RID: 62164 RVA: 0x00152544 File Offset: 0x00150744
		public void SetHeightMapConnection(vtkAlgorithmOutput algOutput)
		{
			vtkFitToHeightMapFilter.vtkFitToHeightMapFilter_SetHeightMapConnection_20(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x0600F2D5 RID: 62165
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFitToHeightMapFilter_SetHeightMapData_21(HandleRef pThis, HandleRef idata);

		/// <summary>
		/// Set the height map for the filter.  Note that this method does not
		/// connect the pipeline. The algorithm will work on the input data as it is
		/// without updating the producer of the data.  See SetHeightMapConnection()
		/// for connecting the pipeline.
		/// </summary>
		// Token: 0x0600F2D6 RID: 62166 RVA: 0x00152574 File Offset: 0x00150774
		public void SetHeightMapData(vtkImageData idata)
		{
			vtkFitToHeightMapFilter.vtkFitToHeightMapFilter_SetHeightMapData_21(base.GetCppThis(), (idata == null) ? default(HandleRef) : idata.GetCppThis());
		}

		// Token: 0x0600F2D7 RID: 62167
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFitToHeightMapFilter_SetUseHeightMapOffset_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate whether the z-offset from the image height map should be added
		/// to the final result. Some height map images are offset in z-coordinate
		/// which is independent of the height map values. By default this value is
		/// true.
		/// </summary>
		// Token: 0x0600F2D8 RID: 62168 RVA: 0x001525A3 File Offset: 0x001507A3
		public virtual void SetUseHeightMapOffset(int _arg)
		{
			vtkFitToHeightMapFilter.vtkFitToHeightMapFilter_SetUseHeightMapOffset_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F2D9 RID: 62169
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFitToHeightMapFilter_UseHeightMapOffsetOff_23(HandleRef pThis);

		/// <summary>
		/// Indicate whether the z-offset from the image height map should be added
		/// to the final result. Some height map images are offset in z-coordinate
		/// which is independent of the height map values. By default this value is
		/// true.
		/// </summary>
		// Token: 0x0600F2DA RID: 62170 RVA: 0x001525B3 File Offset: 0x001507B3
		public virtual void UseHeightMapOffsetOff()
		{
			vtkFitToHeightMapFilter.vtkFitToHeightMapFilter_UseHeightMapOffsetOff_23(base.GetCppThis());
		}

		// Token: 0x0600F2DB RID: 62171
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFitToHeightMapFilter_UseHeightMapOffsetOn_24(HandleRef pThis);

		/// <summary>
		/// Indicate whether the z-offset from the image height map should be added
		/// to the final result. Some height map images are offset in z-coordinate
		/// which is independent of the height map values. By default this value is
		/// true.
		/// </summary>
		// Token: 0x0600F2DC RID: 62172 RVA: 0x001525C2 File Offset: 0x001507C2
		public virtual void UseHeightMapOffsetOn()
		{
			vtkFitToHeightMapFilter.vtkFitToHeightMapFilter_UseHeightMapOffsetOn_24(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011A5 RID: 4517
		public new const string MRFullTypeName = "Kitware.VTK.vtkFitToHeightMapFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011A6 RID: 4518
		public new static readonly string MRClassNameKey = "class vtkFitToHeightMapFilter";

		/// <summary>
		/// Get a pointer to the height map.
		/// </summary>
		// Token: 0x02000556 RID: 1366
		public enum FittingStrategy
		{
			/// <summary>enum member</summary>
			// Token: 0x040011A8 RID: 4520
			CELL_AVERAGE_HEIGHT = 6,
			/// <summary>enum member</summary>
			// Token: 0x040011A9 RID: 4521
			CELL_MAXIMUM_HEIGHT = 5,
			/// <summary>enum member</summary>
			// Token: 0x040011AA RID: 4522
			CELL_MINIMUM_HEIGHT = 4,
			/// <summary>enum member</summary>
			// Token: 0x040011AB RID: 4523
			POINT_AVERAGE_HEIGHT = 3,
			/// <summary>enum member</summary>
			// Token: 0x040011AC RID: 4524
			POINT_MAXIMUM_HEIGHT = 2,
			/// <summary>enum member</summary>
			// Token: 0x040011AD RID: 4525
			POINT_MINIMUM_HEIGHT = 1,
			/// <summary>enum member</summary>
			// Token: 0x040011AE RID: 4526
			POINT_PROJECTION = 0
		}
	}
}
