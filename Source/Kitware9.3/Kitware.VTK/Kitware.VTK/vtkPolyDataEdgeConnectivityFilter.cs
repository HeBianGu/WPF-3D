using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyDataEdgeConnectivityFilter
	/// </summary>
	/// <remarks>
	///    segment polygonal mesh based on shared edge connectivity
	///
	/// vtkPolyDataEdgeConnectivityFilter is a filter to segment cells that
	/// share common edges (i.e., are edge connected), given certain conditions on
	/// edge connectivity. These conditions are 1) the shared edge is not a
	/// barrier edge, and 2) the edge neighbor satisfies conditions on scalar
	/// values.  Specification of both #1 and #2 are optional; in which case all
	/// polygons in a region that share edges are connected. Barrier edges are
	/// either defined by providing an optional second polydata input (which
	/// contains a list of lines defining the barrier edges), or a condition on
	/// edge length. The conditions on edge length specify whether edges within a
	/// range of edge lengths are considered barrier edges.  All connected
	/// polygonal cells satisfying these conditions form a region. Typically the
	/// filter segments multiple regions; however the user can specify which
	/// region(s) are to be extracted and output.
	///
	/// The filter works in one of seven ways: 1) extract the largest (in terms of
	/// total surface area) edge-connected region in the dataset; 2) extract
	/// specified regions; 3) extract all regions containing user-specified
	/// point ids; 4) extract all regions containing user-specified cell ids; 5)
	/// extract the region closest to a user-specified point; 6) extract all
	/// edge-connected regions (used to color regions, i.e., create segmentation
	/// labeling); or 7) extract "large" regions, that is all regions considered
	/// large in terms of their surface area relative to the total input polydata
	/// surface area.
	///
	/// Barrier edges add a unique twist to the filter. By using them, it is
	/// possible to segment out portions of a mesh with very small, very large, or
	/// in between polygon-sized features.
	///
	/// Due to the nature of edge connectivity, the filter only operates on
	/// polygons. Vertices, lines, and triangle strips are ignored (and not passed
	/// through to the output). Point and cell attribute data are copied to the
	/// output; however, an additional, optional array named "RegionId" may be
	/// added to the output cell attribute data by enabling ColorRegions.
	///
	/// @warning
	/// If more than one output region is produced, regions are sorted based on
	/// their surface area. Thus region# 0 is the largest, followed by the next
	/// largest and so on.
	///
	/// @warning
	/// To be clear: if scalar connectivity is enabled, this filter segments data
	/// based on *cell* attribute data based on edge-connected meshes. The similar
	/// vtkPolyDataConnectivityFilter segments based on point attribute data and
	/// point-connected meshes.
	///
	/// @warning
	/// A second, optional vtkPolyData (the Source) may be specified which
	/// contains edges (i.e., vtkPolyData::Lines) that specify barries to edge
	/// connectivity. That is, two polygons who share an edge are not connected if
	/// the shared edge exists in the Source vtkPolyData. This feature can be used
	/// with other filters such as vtkDelaunay2D (and its constraint edges) to
	/// create segmented regions.
	///
	/// @warning
	/// Note that mesh regions attached at just a point are not considered
	/// connected. Thus such point-connected meshes will be segmented into
	/// different regions. This differs from vtkPolyDataConnectivityFilter which
	/// segments produces point-connected regions.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPolyDataConnectivityFilter vtkConnectivityFilter vtkDelaunay2D
	/// </seealso>
	// Token: 0x02000989 RID: 2441
	public class vtkPolyDataEdgeConnectivityFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060196E5 RID: 104165 RVA: 0x00236AA6 File Offset: 0x00234CA6
		static vtkPolyDataEdgeConnectivityFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataEdgeConnectivityFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataEdgeConnectivityFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060196E6 RID: 104166 RVA: 0x00236ACE File Offset: 0x00234CCE
		public vtkPolyDataEdgeConnectivityFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060196E7 RID: 104167
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataEdgeConnectivityFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to instantiate, get type information, and print the object.
		/// </summary>
		// Token: 0x060196E8 RID: 104168 RVA: 0x00236ADC File Offset: 0x00234CDC
		public new static vtkPolyDataEdgeConnectivityFilter New()
		{
			vtkPolyDataEdgeConnectivityFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataEdgeConnectivityFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods to instantiate, get type information, and print the object.
		/// </summary>
		// Token: 0x060196E9 RID: 104169 RVA: 0x00236B30 File Offset: 0x00234D30
		public vtkPolyDataEdgeConnectivityFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060196EA RID: 104170 RVA: 0x00236B74 File Offset: 0x00234D74
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060196EB RID: 104171
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_AddSeed_01(HandleRef pThis, int id);

		/// <summary>
		/// Add a seed id (point or cell id). Note: ids are 0-offset.
		/// </summary>
		// Token: 0x060196EC RID: 104172 RVA: 0x00236B7F File Offset: 0x00234D7F
		public void AddSeed(int id)
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_AddSeed_01(base.GetCppThis(), id);
		}

		// Token: 0x060196ED RID: 104173
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_AddSpecifiedRegion_02(HandleRef pThis, int id);

		/// <summary>
		/// Add a region id to extract. Note: ids are 0-offset.
		/// </summary>
		// Token: 0x060196EE RID: 104174 RVA: 0x00236B8F File Offset: 0x00234D8F
		public void AddSpecifiedRegion(int id)
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_AddSpecifiedRegion_02(base.GetCppThis(), id);
		}

		// Token: 0x060196EF RID: 104175
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_BarrierEdgesOff_03(HandleRef pThis);

		/// <summary>
		/// Control connectivity traversal based on barrier edges. If enabled, then
		/// either the length of edges, or a explicit specification of barrier
		/// edges, is used to control what are considered connected edge neighbors.
		/// </summary>
		// Token: 0x060196F0 RID: 104176 RVA: 0x00236B9F File Offset: 0x00234D9F
		public virtual void BarrierEdgesOff()
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_BarrierEdgesOff_03(base.GetCppThis());
		}

		// Token: 0x060196F1 RID: 104177
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_BarrierEdgesOn_04(HandleRef pThis);

		/// <summary>
		/// Control connectivity traversal based on barrier edges. If enabled, then
		/// either the length of edges, or a explicit specification of barrier
		/// edges, is used to control what are considered connected edge neighbors.
		/// </summary>
		// Token: 0x060196F2 RID: 104178 RVA: 0x00236BAE File Offset: 0x00234DAE
		public virtual void BarrierEdgesOn()
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_BarrierEdgesOn_04(base.GetCppThis());
		}

		// Token: 0x060196F3 RID: 104179
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_CellRegionAreasOff_05(HandleRef pThis);

		/// <summary>
		/// Turn on/off the creation of a cell array that, for each cell, contains
		/// the area of the region to which the cell is associated. If enabled, then
		/// an array named "CellRegionArea" is added to the output cell data.
		/// </summary>
		// Token: 0x060196F4 RID: 104180 RVA: 0x00236BBD File Offset: 0x00234DBD
		public virtual void CellRegionAreasOff()
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_CellRegionAreasOff_05(base.GetCppThis());
		}

		// Token: 0x060196F5 RID: 104181
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_CellRegionAreasOn_06(HandleRef pThis);

		/// <summary>
		/// Turn on/off the creation of a cell array that, for each cell, contains
		/// the area of the region to which the cell is associated. If enabled, then
		/// an array named "CellRegionArea" is added to the output cell data.
		/// </summary>
		// Token: 0x060196F6 RID: 104182 RVA: 0x00236BCC File Offset: 0x00234DCC
		public virtual void CellRegionAreasOn()
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_CellRegionAreasOn_06(base.GetCppThis());
		}

		// Token: 0x060196F7 RID: 104183
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_ColorRegionsOff_07(HandleRef pThis);

		/// <summary>
		/// Turn on/off the coloring of edge-connected regions. If enabled, then
		/// a array named "RegionId" is added to the output cell data. The array
		/// contains, for each cell, the id with which the cell is associated.
		/// </summary>
		// Token: 0x060196F8 RID: 104184 RVA: 0x00236BDB File Offset: 0x00234DDB
		public virtual void ColorRegionsOff()
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_ColorRegionsOff_07(base.GetCppThis());
		}

		// Token: 0x060196F9 RID: 104185
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_ColorRegionsOn_08(HandleRef pThis);

		/// <summary>
		/// Turn on/off the coloring of edge-connected regions. If enabled, then
		/// a array named "RegionId" is added to the output cell data. The array
		/// contains, for each cell, the id with which the cell is associated.
		/// </summary>
		// Token: 0x060196FA RID: 104186 RVA: 0x00236BEA File Offset: 0x00234DEA
		public virtual void ColorRegionsOn()
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_ColorRegionsOn_08(base.GetCppThis());
		}

		// Token: 0x060196FB RID: 104187
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_DeleteSeed_09(HandleRef pThis, int id);

		/// <summary>
		/// Delete a seed id (point or cell id). Note: ids are 0-offset.
		/// </summary>
		// Token: 0x060196FC RID: 104188 RVA: 0x00236BF9 File Offset: 0x00234DF9
		public void DeleteSeed(int id)
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_DeleteSeed_09(base.GetCppThis(), id);
		}

		// Token: 0x060196FD RID: 104189
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_DeleteSpecifiedRegion_10(HandleRef pThis, int id);

		/// <summary>
		/// Delete a region id to extract. Note: ids are 0-offset.
		/// </summary>
		// Token: 0x060196FE RID: 104190 RVA: 0x00236C09 File Offset: 0x00234E09
		public void DeleteSpecifiedRegion(int id)
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_DeleteSpecifiedRegion_10(base.GetCppThis(), id);
		}

		// Token: 0x060196FF RID: 104191
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataEdgeConnectivityFilter_GetBarrierEdgeLength_11(HandleRef pThis);

		/// <summary>
		/// Edges E of length edgeLen (BarrierEdgeLength[0]&lt;=edgeLen&lt;=BarrierEdgeLength[1])
		/// define barrier edges. If edgeLen falls within this range, then polygon
		/// cells on either side of the edge E are not neighbors, since the edge is
		/// a barrier edge. Note that a range of [VTK_DOUBLE_MAX,VTK_DOUBLE_MAX]
		/// (which is the default range) implies that all edges are not barrier
		/// edges (based on edge length).
		/// </summary>
		// Token: 0x06019700 RID: 104192 RVA: 0x00236C1C File Offset: 0x00234E1C
		public virtual double[] GetBarrierEdgeLength()
		{
			IntPtr intPtr = vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GetBarrierEdgeLength_11(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06019701 RID: 104193
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_GetBarrierEdgeLength_12(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Edges E of length edgeLen (BarrierEdgeLength[0]&lt;=edgeLen&lt;=BarrierEdgeLength[1])
		/// define barrier edges. If edgeLen falls within this range, then polygon
		/// cells on either side of the edge E are not neighbors, since the edge is
		/// a barrier edge. Note that a range of [VTK_DOUBLE_MAX,VTK_DOUBLE_MAX]
		/// (which is the default range) implies that all edges are not barrier
		/// edges (based on edge length).
		/// </summary>
		// Token: 0x06019702 RID: 104194 RVA: 0x00236C64 File Offset: 0x00234E64
		public virtual void GetBarrierEdgeLength(ref double _arg1, ref double _arg2)
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GetBarrierEdgeLength_12(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06019703 RID: 104195
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_GetBarrierEdgeLength_13(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Edges E of length edgeLen (BarrierEdgeLength[0]&lt;=edgeLen&lt;=BarrierEdgeLength[1])
		/// define barrier edges. If edgeLen falls within this range, then polygon
		/// cells on either side of the edge E are not neighbors, since the edge is
		/// a barrier edge. Note that a range of [VTK_DOUBLE_MAX,VTK_DOUBLE_MAX]
		/// (which is the default range) implies that all edges are not barrier
		/// edges (based on edge length).
		/// </summary>
		// Token: 0x06019704 RID: 104196 RVA: 0x00236C75 File Offset: 0x00234E75
		public virtual void GetBarrierEdgeLength(IntPtr _arg)
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GetBarrierEdgeLength_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06019705 RID: 104197
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataEdgeConnectivityFilter_GetBarrierEdges_14(HandleRef pThis);

		/// <summary>
		/// Control connectivity traversal based on barrier edges. If enabled, then
		/// either the length of edges, or a explicit specification of barrier
		/// edges, is used to control what are considered connected edge neighbors.
		/// </summary>
		// Token: 0x06019706 RID: 104198 RVA: 0x00236C88 File Offset: 0x00234E88
		public virtual int GetBarrierEdges()
		{
			return vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GetBarrierEdges_14(base.GetCppThis());
		}

		// Token: 0x06019707 RID: 104199
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataEdgeConnectivityFilter_GetCellRegionAreas_15(HandleRef pThis);

		/// <summary>
		/// Turn on/off the creation of a cell array that, for each cell, contains
		/// the area of the region to which the cell is associated. If enabled, then
		/// an array named "CellRegionArea" is added to the output cell data.
		/// </summary>
		// Token: 0x06019708 RID: 104200 RVA: 0x00236CA8 File Offset: 0x00234EA8
		public virtual int GetCellRegionAreas()
		{
			return vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GetCellRegionAreas_15(base.GetCppThis());
		}

		// Token: 0x06019709 RID: 104201
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataEdgeConnectivityFilter_GetClosestPoint_16(HandleRef pThis);

		/// <summary>
		/// Use to specify x-y-z point coordinates when extracting the region
		/// closest to a specified point.
		/// </summary>
		// Token: 0x0601970A RID: 104202 RVA: 0x00236CC8 File Offset: 0x00234EC8
		public virtual double[] GetClosestPoint()
		{
			IntPtr intPtr = vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GetClosestPoint_16(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601970B RID: 104203
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_GetClosestPoint_17(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Use to specify x-y-z point coordinates when extracting the region
		/// closest to a specified point.
		/// </summary>
		// Token: 0x0601970C RID: 104204 RVA: 0x00236D10 File Offset: 0x00234F10
		public virtual void GetClosestPoint(IntPtr data)
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GetClosestPoint_17(base.GetCppThis(), data);
		}

		// Token: 0x0601970D RID: 104205
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataEdgeConnectivityFilter_GetColorRegions_18(HandleRef pThis);

		/// <summary>
		/// Turn on/off the coloring of edge-connected regions. If enabled, then
		/// a array named "RegionId" is added to the output cell data. The array
		/// contains, for each cell, the id with which the cell is associated.
		/// </summary>
		// Token: 0x0601970E RID: 104206 RVA: 0x00236D20 File Offset: 0x00234F20
		public virtual int GetColorRegions()
		{
			return vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GetColorRegions_18(base.GetCppThis());
		}

		// Token: 0x0601970F RID: 104207
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataEdgeConnectivityFilter_GetExtractionMode_19(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x06019710 RID: 104208 RVA: 0x00236D40 File Offset: 0x00234F40
		public virtual int GetExtractionMode()
		{
			return vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GetExtractionMode_19(base.GetCppThis());
		}

		// Token: 0x06019711 RID: 104209
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataEdgeConnectivityFilter_GetExtractionModeAsString_20(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x06019712 RID: 104210 RVA: 0x00236D60 File Offset: 0x00234F60
		public string GetExtractionModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GetExtractionModeAsString_20(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06019713 RID: 104211
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataEdgeConnectivityFilter_GetExtractionModeMaxValue_21(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x06019714 RID: 104212 RVA: 0x00236D9C File Offset: 0x00234F9C
		public virtual int GetExtractionModeMaxValue()
		{
			return vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GetExtractionModeMaxValue_21(base.GetCppThis());
		}

		// Token: 0x06019715 RID: 104213
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataEdgeConnectivityFilter_GetExtractionModeMinValue_22(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x06019716 RID: 104214 RVA: 0x00236DBC File Offset: 0x00234FBC
		public virtual int GetExtractionModeMinValue()
		{
			return vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GetExtractionModeMinValue_22(base.GetCppThis());
		}

		// Token: 0x06019717 RID: 104215
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolyDataEdgeConnectivityFilter_GetLargeRegionThreshold_23(HandleRef pThis);

		/// <summary>
		/// Define what a large region is by specifying the fraction of total input
		/// mesh area a region must be in order to be considered large. So for
		/// example, if the LargeRegionThreshold is 0.10, then if the summed surface
		/// area of all the cells composing a region is greater than or equal to
		/// 10%, the region is considered large. By default, the LargeRegionThreshold
		/// is 0.05.
		/// </summary>
		// Token: 0x06019718 RID: 104216 RVA: 0x00236DDC File Offset: 0x00234FDC
		public virtual double GetLargeRegionThreshold()
		{
			return vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GetLargeRegionThreshold_23(base.GetCppThis());
		}

		// Token: 0x06019719 RID: 104217
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolyDataEdgeConnectivityFilter_GetLargeRegionThresholdMaxValue_24(HandleRef pThis);

		/// <summary>
		/// Define what a large region is by specifying the fraction of total input
		/// mesh area a region must be in order to be considered large. So for
		/// example, if the LargeRegionThreshold is 0.10, then if the summed surface
		/// area of all the cells composing a region is greater than or equal to
		/// 10%, the region is considered large. By default, the LargeRegionThreshold
		/// is 0.05.
		/// </summary>
		// Token: 0x0601971A RID: 104218 RVA: 0x00236DFC File Offset: 0x00234FFC
		public virtual double GetLargeRegionThresholdMaxValue()
		{
			return vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GetLargeRegionThresholdMaxValue_24(base.GetCppThis());
		}

		// Token: 0x0601971B RID: 104219
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolyDataEdgeConnectivityFilter_GetLargeRegionThresholdMinValue_25(HandleRef pThis);

		/// <summary>
		/// Define what a large region is by specifying the fraction of total input
		/// mesh area a region must be in order to be considered large. So for
		/// example, if the LargeRegionThreshold is 0.10, then if the summed surface
		/// area of all the cells composing a region is greater than or equal to
		/// 10%, the region is considered large. By default, the LargeRegionThreshold
		/// is 0.05.
		/// </summary>
		// Token: 0x0601971C RID: 104220 RVA: 0x00236E1C File Offset: 0x0023501C
		public virtual double GetLargeRegionThresholdMinValue()
		{
			return vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GetLargeRegionThresholdMinValue_25(base.GetCppThis());
		}

		// Token: 0x0601971D RID: 104221
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataEdgeConnectivityFilter_GetNumberOfExtractedRegions_26(HandleRef pThis);

		/// <summary>
		/// Obtain the number of connected regions found. This returns valid
		/// information only after the filter has successfully executed.
		/// </summary>
		// Token: 0x0601971E RID: 104222 RVA: 0x00236E3C File Offset: 0x0023503C
		public int GetNumberOfExtractedRegions()
		{
			return vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GetNumberOfExtractedRegions_26(base.GetCppThis());
		}

		// Token: 0x0601971F RID: 104223
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataEdgeConnectivityFilter_GetNumberOfGenerationsFromBase_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, get type information, and print the object.
		/// </summary>
		// Token: 0x06019720 RID: 104224 RVA: 0x00236E5C File Offset: 0x0023505C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GetNumberOfGenerationsFromBase_27(base.GetCppThis(), type);
		}

		// Token: 0x06019721 RID: 104225
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataEdgeConnectivityFilter_GetNumberOfGenerationsFromBaseType_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, get type information, and print the object.
		/// </summary>
		// Token: 0x06019722 RID: 104226 RVA: 0x00236E7C File Offset: 0x0023507C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GetNumberOfGenerationsFromBaseType_28(type);
		}

		// Token: 0x06019723 RID: 104227
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataEdgeConnectivityFilter_GetNumberOfSpecifiedRegions_29(HandleRef pThis);

		/// <summary>
		/// Get number of specified regions.
		/// </summary>
		// Token: 0x06019724 RID: 104228 RVA: 0x00236E98 File Offset: 0x00235098
		public int GetNumberOfSpecifiedRegions()
		{
			return vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GetNumberOfSpecifiedRegions_29(base.GetCppThis());
		}

		// Token: 0x06019725 RID: 104229
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataEdgeConnectivityFilter_GetOutputPointsPrecision_30(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06019726 RID: 104230 RVA: 0x00236EB8 File Offset: 0x002350B8
		public virtual int GetOutputPointsPrecision()
		{
			return vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GetOutputPointsPrecision_30(base.GetCppThis());
		}

		// Token: 0x06019727 RID: 104231
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataEdgeConnectivityFilter_GetRegionGrowing_31(HandleRef pThis);

		/// <summary>
		/// Specify a strategy for region growing. Regions growing is a
		/// postprocessing step which assimilates small regions into larger regions;
		/// i.e., region growing is an additional step as part of a segmentation
		/// workflow. By default, region growing is off. If growing large regions
		/// is enabled, then smaller regions are assimilated into larger regions. If
		/// growing small regions is enabled, then small regions are combined to
		/// form larger regions. Note that the definition of a large region is a
		/// region that exceeds the large region threshold.
		/// </summary>
		// Token: 0x06019728 RID: 104232 RVA: 0x00236ED8 File Offset: 0x002350D8
		public virtual int GetRegionGrowing()
		{
			return vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GetRegionGrowing_31(base.GetCppThis());
		}

		// Token: 0x06019729 RID: 104233
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataEdgeConnectivityFilter_GetRegionGrowingMaxValue_32(HandleRef pThis);

		/// <summary>
		/// Specify a strategy for region growing. Regions growing is a
		/// postprocessing step which assimilates small regions into larger regions;
		/// i.e., region growing is an additional step as part of a segmentation
		/// workflow. By default, region growing is off. If growing large regions
		/// is enabled, then smaller regions are assimilated into larger regions. If
		/// growing small regions is enabled, then small regions are combined to
		/// form larger regions. Note that the definition of a large region is a
		/// region that exceeds the large region threshold.
		/// </summary>
		// Token: 0x0601972A RID: 104234 RVA: 0x00236EF8 File Offset: 0x002350F8
		public virtual int GetRegionGrowingMaxValue()
		{
			return vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GetRegionGrowingMaxValue_32(base.GetCppThis());
		}

		// Token: 0x0601972B RID: 104235
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataEdgeConnectivityFilter_GetRegionGrowingMinValue_33(HandleRef pThis);

		/// <summary>
		/// Specify a strategy for region growing. Regions growing is a
		/// postprocessing step which assimilates small regions into larger regions;
		/// i.e., region growing is an additional step as part of a segmentation
		/// workflow. By default, region growing is off. If growing large regions
		/// is enabled, then smaller regions are assimilated into larger regions. If
		/// growing small regions is enabled, then small regions are combined to
		/// form larger regions. Note that the definition of a large region is a
		/// region that exceeds the large region threshold.
		/// </summary>
		// Token: 0x0601972C RID: 104236 RVA: 0x00236F18 File Offset: 0x00235118
		public virtual int GetRegionGrowingMinValue()
		{
			return vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GetRegionGrowingMinValue_33(base.GetCppThis());
		}

		// Token: 0x0601972D RID: 104237
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataEdgeConnectivityFilter_GetRegionSizes_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Obtain the array containing the region sizes of the extracted
		/// regions.
		/// </summary>
		// Token: 0x0601972E RID: 104238 RVA: 0x00236F38 File Offset: 0x00235138
		public virtual vtkIdTypeArray GetRegionSizes()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GetRegionSizes_34(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		// Token: 0x0601972F RID: 104239
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataEdgeConnectivityFilter_GetScalarConnectivity_35(HandleRef pThis);

		/// <summary>
		/// Turn on/off connectivity based on scalar value. If on, cells are
		/// connected only if they share a non-barrier edge AND and cell's scalar
		/// value falls within the scalar range specified.
		/// </summary>
		// Token: 0x06019730 RID: 104240 RVA: 0x00236FA8 File Offset: 0x002351A8
		public virtual int GetScalarConnectivity()
		{
			return vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GetScalarConnectivity_35(base.GetCppThis());
		}

		// Token: 0x06019731 RID: 104241
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataEdgeConnectivityFilter_GetScalarRange_36(HandleRef pThis);

		/// <summary>
		/// Set the scalar range to extract cells based on scalar connectivity.
		/// </summary>
		// Token: 0x06019732 RID: 104242 RVA: 0x00236FC8 File Offset: 0x002351C8
		public virtual double[] GetScalarRange()
		{
			IntPtr intPtr = vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GetScalarRange_36(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06019733 RID: 104243
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_GetScalarRange_37(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Set the scalar range to extract cells based on scalar connectivity.
		/// </summary>
		// Token: 0x06019734 RID: 104244 RVA: 0x00237010 File Offset: 0x00235210
		public virtual void GetScalarRange(ref double _arg1, ref double _arg2)
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GetScalarRange_37(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06019735 RID: 104245
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_GetScalarRange_38(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the scalar range to extract cells based on scalar connectivity.
		/// </summary>
		// Token: 0x06019736 RID: 104246 RVA: 0x00237021 File Offset: 0x00235221
		public virtual void GetScalarRange(IntPtr _arg)
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GetScalarRange_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06019737 RID: 104247
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataEdgeConnectivityFilter_GetSource_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the source vtkPolyData object used to specify barrier edges
		/// (this is an optional connection.) If specified, the connected traversal
		/// cannot traverse across the edges indicated as they are defined as
		/// barrier edges. Also note that the data member BarrierEdges must be
		/// enabled.
		/// </summary>
		// Token: 0x06019738 RID: 104248 RVA: 0x00237034 File Offset: 0x00235234
		public vtkPolyData GetSource()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GetSource_39(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06019739 RID: 104249
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolyDataEdgeConnectivityFilter_GetTotalArea_40(HandleRef pThis);

		/// <summary>
		/// Obtain the total area of all regions combined.
		/// </summary>
		// Token: 0x0601973A RID: 104250 RVA: 0x002370A4 File Offset: 0x002352A4
		public double GetTotalArea()
		{
			return vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GetTotalArea_40(base.GetCppThis());
		}

		// Token: 0x0601973B RID: 104251
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_GrowLargeRegionsOff_41(HandleRef pThis);

		/// <summary>
		/// Specify a strategy for region growing. Regions growing is a
		/// postprocessing step which assimilates small regions into larger regions;
		/// i.e., region growing is an additional step as part of a segmentation
		/// workflow. By default, region growing is off. If growing large regions
		/// is enabled, then smaller regions are assimilated into larger regions. If
		/// growing small regions is enabled, then small regions are combined to
		/// form larger regions. Note that the definition of a large region is a
		/// region that exceeds the large region threshold.
		/// </summary>
		// Token: 0x0601973C RID: 104252 RVA: 0x002370C3 File Offset: 0x002352C3
		public void GrowLargeRegionsOff()
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GrowLargeRegionsOff_41(base.GetCppThis());
		}

		// Token: 0x0601973D RID: 104253
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_GrowLargeRegionsOn_42(HandleRef pThis);

		/// <summary>
		/// Specify a strategy for region growing. Regions growing is a
		/// postprocessing step which assimilates small regions into larger regions;
		/// i.e., region growing is an additional step as part of a segmentation
		/// workflow. By default, region growing is off. If growing large regions
		/// is enabled, then smaller regions are assimilated into larger regions. If
		/// growing small regions is enabled, then small regions are combined to
		/// form larger regions. Note that the definition of a large region is a
		/// region that exceeds the large region threshold.
		/// </summary>
		// Token: 0x0601973E RID: 104254 RVA: 0x002370D2 File Offset: 0x002352D2
		public void GrowLargeRegionsOn()
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GrowLargeRegionsOn_42(base.GetCppThis());
		}

		// Token: 0x0601973F RID: 104255
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_GrowSmallRegionsOff_43(HandleRef pThis);

		/// <summary>
		/// Specify a strategy for region growing. Regions growing is a
		/// postprocessing step which assimilates small regions into larger regions;
		/// i.e., region growing is an additional step as part of a segmentation
		/// workflow. By default, region growing is off. If growing large regions
		/// is enabled, then smaller regions are assimilated into larger regions. If
		/// growing small regions is enabled, then small regions are combined to
		/// form larger regions. Note that the definition of a large region is a
		/// region that exceeds the large region threshold.
		/// </summary>
		// Token: 0x06019740 RID: 104256 RVA: 0x002370E1 File Offset: 0x002352E1
		public void GrowSmallRegionsOff()
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GrowSmallRegionsOff_43(base.GetCppThis());
		}

		// Token: 0x06019741 RID: 104257
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_GrowSmallRegionsOn_44(HandleRef pThis);

		/// <summary>
		/// Specify a strategy for region growing. Regions growing is a
		/// postprocessing step which assimilates small regions into larger regions;
		/// i.e., region growing is an additional step as part of a segmentation
		/// workflow. By default, region growing is off. If growing large regions
		/// is enabled, then smaller regions are assimilated into larger regions. If
		/// growing small regions is enabled, then small regions are combined to
		/// form larger regions. Note that the definition of a large region is a
		/// region that exceeds the large region threshold.
		/// </summary>
		// Token: 0x06019742 RID: 104258 RVA: 0x002370F0 File Offset: 0x002352F0
		public void GrowSmallRegionsOn()
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_GrowSmallRegionsOn_44(base.GetCppThis());
		}

		// Token: 0x06019743 RID: 104259
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_InitializeSeedList_45(HandleRef pThis);

		/// <summary>
		/// Initialize list of point ids/cell ids used to seed regions.
		/// </summary>
		// Token: 0x06019744 RID: 104260 RVA: 0x002370FF File Offset: 0x002352FF
		public void InitializeSeedList()
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_InitializeSeedList_45(base.GetCppThis());
		}

		// Token: 0x06019745 RID: 104261
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_InitializeSpecifiedRegionList_46(HandleRef pThis);

		/// <summary>
		/// Initialize list of region ids to extract.
		/// </summary>
		// Token: 0x06019746 RID: 104262 RVA: 0x0023710E File Offset: 0x0023530E
		public void InitializeSpecifiedRegionList()
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_InitializeSpecifiedRegionList_46(base.GetCppThis());
		}

		// Token: 0x06019747 RID: 104263
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataEdgeConnectivityFilter_IsA_47(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, get type information, and print the object.
		/// </summary>
		// Token: 0x06019748 RID: 104264 RVA: 0x00237120 File Offset: 0x00235320
		public override int IsA(string type)
		{
			return vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_IsA_47(base.GetCppThis(), type);
		}

		// Token: 0x06019749 RID: 104265
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataEdgeConnectivityFilter_IsTypeOf_48([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, get type information, and print the object.
		/// </summary>
		// Token: 0x0601974A RID: 104266 RVA: 0x00237140 File Offset: 0x00235340
		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_IsTypeOf_48(type);
		}

		// Token: 0x0601974B RID: 104267
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataEdgeConnectivityFilter_NewInstance_50(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to instantiate, get type information, and print the object.
		/// </summary>
		// Token: 0x0601974C RID: 104268 RVA: 0x0023715C File Offset: 0x0023535C
		public new vtkPolyDataEdgeConnectivityFilter NewInstance()
		{
			vtkPolyDataEdgeConnectivityFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_NewInstance_50(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataEdgeConnectivityFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601974D RID: 104269
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataEdgeConnectivityFilter_SafeDownCast_51(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to instantiate, get type information, and print the object.
		/// </summary>
		// Token: 0x0601974E RID: 104270 RVA: 0x002371B8 File Offset: 0x002353B8
		public new static vtkPolyDataEdgeConnectivityFilter SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataEdgeConnectivityFilter vtkPolyDataEdgeConnectivityFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_SafeDownCast_51((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataEdgeConnectivityFilter = (vtkPolyDataEdgeConnectivityFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataEdgeConnectivityFilter.Register(null);
				}
			}
			return vtkPolyDataEdgeConnectivityFilter;
		}

		// Token: 0x0601974F RID: 104271
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_ScalarConnectivityOff_52(HandleRef pThis);

		/// <summary>
		/// Turn on/off connectivity based on scalar value. If on, cells are
		/// connected only if they share a non-barrier edge AND and cell's scalar
		/// value falls within the scalar range specified.
		/// </summary>
		// Token: 0x06019750 RID: 104272 RVA: 0x00237237 File Offset: 0x00235437
		public virtual void ScalarConnectivityOff()
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_ScalarConnectivityOff_52(base.GetCppThis());
		}

		// Token: 0x06019751 RID: 104273
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_ScalarConnectivityOn_53(HandleRef pThis);

		/// <summary>
		/// Turn on/off connectivity based on scalar value. If on, cells are
		/// connected only if they share a non-barrier edge AND and cell's scalar
		/// value falls within the scalar range specified.
		/// </summary>
		// Token: 0x06019752 RID: 104274 RVA: 0x00237246 File Offset: 0x00235446
		public virtual void ScalarConnectivityOn()
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_ScalarConnectivityOn_53(base.GetCppThis());
		}

		// Token: 0x06019753 RID: 104275
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_SetBarrierEdgeLength_54(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Edges E of length edgeLen (BarrierEdgeLength[0]&lt;=edgeLen&lt;=BarrierEdgeLength[1])
		/// define barrier edges. If edgeLen falls within this range, then polygon
		/// cells on either side of the edge E are not neighbors, since the edge is
		/// a barrier edge. Note that a range of [VTK_DOUBLE_MAX,VTK_DOUBLE_MAX]
		/// (which is the default range) implies that all edges are not barrier
		/// edges (based on edge length).
		/// </summary>
		// Token: 0x06019754 RID: 104276 RVA: 0x00237255 File Offset: 0x00235455
		public virtual void SetBarrierEdgeLength(double _arg1, double _arg2)
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_SetBarrierEdgeLength_54(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06019755 RID: 104277
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_SetBarrierEdgeLength_55(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Edges E of length edgeLen (BarrierEdgeLength[0]&lt;=edgeLen&lt;=BarrierEdgeLength[1])
		/// define barrier edges. If edgeLen falls within this range, then polygon
		/// cells on either side of the edge E are not neighbors, since the edge is
		/// a barrier edge. Note that a range of [VTK_DOUBLE_MAX,VTK_DOUBLE_MAX]
		/// (which is the default range) implies that all edges are not barrier
		/// edges (based on edge length).
		/// </summary>
		// Token: 0x06019756 RID: 104278 RVA: 0x00237266 File Offset: 0x00235466
		public void SetBarrierEdgeLength(IntPtr _arg)
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_SetBarrierEdgeLength_55(base.GetCppThis(), _arg);
		}

		// Token: 0x06019757 RID: 104279
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_SetBarrierEdges_56(HandleRef pThis, int _arg);

		/// <summary>
		/// Control connectivity traversal based on barrier edges. If enabled, then
		/// either the length of edges, or a explicit specification of barrier
		/// edges, is used to control what are considered connected edge neighbors.
		/// </summary>
		// Token: 0x06019758 RID: 104280 RVA: 0x00237276 File Offset: 0x00235476
		public virtual void SetBarrierEdges(int _arg)
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_SetBarrierEdges_56(base.GetCppThis(), _arg);
		}

		// Token: 0x06019759 RID: 104281
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_SetCellRegionAreas_57(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the creation of a cell array that, for each cell, contains
		/// the area of the region to which the cell is associated. If enabled, then
		/// an array named "CellRegionArea" is added to the output cell data.
		/// </summary>
		// Token: 0x0601975A RID: 104282 RVA: 0x00237286 File Offset: 0x00235486
		public virtual void SetCellRegionAreas(int _arg)
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_SetCellRegionAreas_57(base.GetCppThis(), _arg);
		}

		// Token: 0x0601975B RID: 104283
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_SetClosestPoint_58(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Use to specify x-y-z point coordinates when extracting the region
		/// closest to a specified point.
		/// </summary>
		// Token: 0x0601975C RID: 104284 RVA: 0x00237296 File Offset: 0x00235496
		public virtual void SetClosestPoint(double _arg1, double _arg2, double _arg3)
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_SetClosestPoint_58(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601975D RID: 104285
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_SetClosestPoint_59(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Use to specify x-y-z point coordinates when extracting the region
		/// closest to a specified point.
		/// </summary>
		// Token: 0x0601975E RID: 104286 RVA: 0x002372A8 File Offset: 0x002354A8
		public virtual void SetClosestPoint(IntPtr _arg)
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_SetClosestPoint_59(base.GetCppThis(), _arg);
		}

		// Token: 0x0601975F RID: 104287
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_SetColorRegions_60(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the coloring of edge-connected regions. If enabled, then
		/// a array named "RegionId" is added to the output cell data. The array
		/// contains, for each cell, the id with which the cell is associated.
		/// </summary>
		// Token: 0x06019760 RID: 104288 RVA: 0x002372B8 File Offset: 0x002354B8
		public virtual void SetColorRegions(int _arg)
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_SetColorRegions_60(base.GetCppThis(), _arg);
		}

		// Token: 0x06019761 RID: 104289
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_SetExtractionMode_61(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x06019762 RID: 104290 RVA: 0x002372C8 File Offset: 0x002354C8
		public virtual void SetExtractionMode(int _arg)
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_SetExtractionMode_61(base.GetCppThis(), _arg);
		}

		// Token: 0x06019763 RID: 104291
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_SetExtractionModeToAllRegions_62(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x06019764 RID: 104292 RVA: 0x002372D8 File Offset: 0x002354D8
		public void SetExtractionModeToAllRegions()
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_SetExtractionModeToAllRegions_62(base.GetCppThis());
		}

		// Token: 0x06019765 RID: 104293
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_SetExtractionModeToCellSeededRegions_63(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x06019766 RID: 104294 RVA: 0x002372E7 File Offset: 0x002354E7
		public void SetExtractionModeToCellSeededRegions()
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_SetExtractionModeToCellSeededRegions_63(base.GetCppThis());
		}

		// Token: 0x06019767 RID: 104295
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_SetExtractionModeToClosestPointRegion_64(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x06019768 RID: 104296 RVA: 0x002372F6 File Offset: 0x002354F6
		public void SetExtractionModeToClosestPointRegion()
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_SetExtractionModeToClosestPointRegion_64(base.GetCppThis());
		}

		// Token: 0x06019769 RID: 104297
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_SetExtractionModeToLargeRegions_65(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x0601976A RID: 104298 RVA: 0x00237305 File Offset: 0x00235505
		public void SetExtractionModeToLargeRegions()
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_SetExtractionModeToLargeRegions_65(base.GetCppThis());
		}

		// Token: 0x0601976B RID: 104299
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_SetExtractionModeToLargestRegion_66(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x0601976C RID: 104300 RVA: 0x00237314 File Offset: 0x00235514
		public void SetExtractionModeToLargestRegion()
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_SetExtractionModeToLargestRegion_66(base.GetCppThis());
		}

		// Token: 0x0601976D RID: 104301
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_SetExtractionModeToPointSeededRegions_67(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x0601976E RID: 104302 RVA: 0x00237323 File Offset: 0x00235523
		public void SetExtractionModeToPointSeededRegions()
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_SetExtractionModeToPointSeededRegions_67(base.GetCppThis());
		}

		// Token: 0x0601976F RID: 104303
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_SetExtractionModeToSpecifiedRegions_68(HandleRef pThis);

		/// <summary>
		/// Control the extraction of connected surfaces.
		/// </summary>
		// Token: 0x06019770 RID: 104304 RVA: 0x00237332 File Offset: 0x00235532
		public void SetExtractionModeToSpecifiedRegions()
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_SetExtractionModeToSpecifiedRegions_68(base.GetCppThis());
		}

		// Token: 0x06019771 RID: 104305
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_SetLargeRegionThreshold_69(HandleRef pThis, double _arg);

		/// <summary>
		/// Define what a large region is by specifying the fraction of total input
		/// mesh area a region must be in order to be considered large. So for
		/// example, if the LargeRegionThreshold is 0.10, then if the summed surface
		/// area of all the cells composing a region is greater than or equal to
		/// 10%, the region is considered large. By default, the LargeRegionThreshold
		/// is 0.05.
		/// </summary>
		// Token: 0x06019772 RID: 104306 RVA: 0x00237341 File Offset: 0x00235541
		public virtual void SetLargeRegionThreshold(double _arg)
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_SetLargeRegionThreshold_69(base.GetCppThis(), _arg);
		}

		// Token: 0x06019773 RID: 104307
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_SetOutputPointsPrecision_70(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06019774 RID: 104308 RVA: 0x00237351 File Offset: 0x00235551
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_SetOutputPointsPrecision_70(base.GetCppThis(), _arg);
		}

		// Token: 0x06019775 RID: 104309
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_SetRegionGrowing_71(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify a strategy for region growing. Regions growing is a
		/// postprocessing step which assimilates small regions into larger regions;
		/// i.e., region growing is an additional step as part of a segmentation
		/// workflow. By default, region growing is off. If growing large regions
		/// is enabled, then smaller regions are assimilated into larger regions. If
		/// growing small regions is enabled, then small regions are combined to
		/// form larger regions. Note that the definition of a large region is a
		/// region that exceeds the large region threshold.
		/// </summary>
		// Token: 0x06019776 RID: 104310 RVA: 0x00237361 File Offset: 0x00235561
		public virtual void SetRegionGrowing(int _arg)
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_SetRegionGrowing_71(base.GetCppThis(), _arg);
		}

		// Token: 0x06019777 RID: 104311
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_SetRegionGrowingOff_72(HandleRef pThis);

		/// <summary>
		/// Specify a strategy for region growing. Regions growing is a
		/// postprocessing step which assimilates small regions into larger regions;
		/// i.e., region growing is an additional step as part of a segmentation
		/// workflow. By default, region growing is off. If growing large regions
		/// is enabled, then smaller regions are assimilated into larger regions. If
		/// growing small regions is enabled, then small regions are combined to
		/// form larger regions. Note that the definition of a large region is a
		/// region that exceeds the large region threshold.
		/// </summary>
		// Token: 0x06019778 RID: 104312 RVA: 0x00237371 File Offset: 0x00235571
		public void SetRegionGrowingOff()
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_SetRegionGrowingOff_72(base.GetCppThis());
		}

		// Token: 0x06019779 RID: 104313
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_SetRegionGrowingToLargeRegions_73(HandleRef pThis);

		/// <summary>
		/// Specify a strategy for region growing. Regions growing is a
		/// postprocessing step which assimilates small regions into larger regions;
		/// i.e., region growing is an additional step as part of a segmentation
		/// workflow. By default, region growing is off. If growing large regions
		/// is enabled, then smaller regions are assimilated into larger regions. If
		/// growing small regions is enabled, then small regions are combined to
		/// form larger regions. Note that the definition of a large region is a
		/// region that exceeds the large region threshold.
		/// </summary>
		// Token: 0x0601977A RID: 104314 RVA: 0x00237380 File Offset: 0x00235580
		public void SetRegionGrowingToLargeRegions()
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_SetRegionGrowingToLargeRegions_73(base.GetCppThis());
		}

		// Token: 0x0601977B RID: 104315
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_SetRegionGrowingToSmallRegions_74(HandleRef pThis);

		/// <summary>
		/// Specify a strategy for region growing. Regions growing is a
		/// postprocessing step which assimilates small regions into larger regions;
		/// i.e., region growing is an additional step as part of a segmentation
		/// workflow. By default, region growing is off. If growing large regions
		/// is enabled, then smaller regions are assimilated into larger regions. If
		/// growing small regions is enabled, then small regions are combined to
		/// form larger regions. Note that the definition of a large region is a
		/// region that exceeds the large region threshold.
		/// </summary>
		// Token: 0x0601977C RID: 104316 RVA: 0x0023738F File Offset: 0x0023558F
		public void SetRegionGrowingToSmallRegions()
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_SetRegionGrowingToSmallRegions_74(base.GetCppThis());
		}

		// Token: 0x0601977D RID: 104317
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_SetScalarConnectivity_75(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off connectivity based on scalar value. If on, cells are
		/// connected only if they share a non-barrier edge AND and cell's scalar
		/// value falls within the scalar range specified.
		/// </summary>
		// Token: 0x0601977E RID: 104318 RVA: 0x0023739E File Offset: 0x0023559E
		public virtual void SetScalarConnectivity(int _arg)
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_SetScalarConnectivity_75(base.GetCppThis(), _arg);
		}

		// Token: 0x0601977F RID: 104319
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_SetScalarRange_76(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Set the scalar range to extract cells based on scalar connectivity.
		/// </summary>
		// Token: 0x06019780 RID: 104320 RVA: 0x002373AE File Offset: 0x002355AE
		public virtual void SetScalarRange(double _arg1, double _arg2)
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_SetScalarRange_76(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06019781 RID: 104321
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_SetScalarRange_77(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the scalar range to extract cells based on scalar connectivity.
		/// </summary>
		// Token: 0x06019782 RID: 104322 RVA: 0x002373BF File Offset: 0x002355BF
		public void SetScalarRange(IntPtr _arg)
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_SetScalarRange_77(base.GetCppThis(), _arg);
		}

		// Token: 0x06019783 RID: 104323
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_SetSourceConnection_78(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Specify the source vtkPolyData object used to specify barrier edges
		/// (this is an optional connection.) If specified, the connected traversal
		/// cannot traverse across the edges indicated as they are defined as
		/// barrier edges. Also note that the data member BarrierEdges must be
		/// enabled.
		/// </summary>
		// Token: 0x06019784 RID: 104324 RVA: 0x002373D0 File Offset: 0x002355D0
		public void SetSourceConnection(vtkAlgorithmOutput algOutput)
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_SetSourceConnection_78(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x06019785 RID: 104325
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataEdgeConnectivityFilter_SetSourceData_79(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the source vtkPolyData object used to specify barrier edges
		/// (this is an optional connection.) If specified, the connected traversal
		/// cannot traverse across the edges indicated as they are defined as
		/// barrier edges. Also note that the data member BarrierEdges must be
		/// enabled.
		/// </summary>
		// Token: 0x06019786 RID: 104326 RVA: 0x00237400 File Offset: 0x00235600
		public void SetSourceData(vtkPolyData arg0)
		{
			vtkPolyDataEdgeConnectivityFilter.vtkPolyDataEdgeConnectivityFilter_SetSourceData_79(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BD1 RID: 7121
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataEdgeConnectivityFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BD2 RID: 7122
		public new static readonly string MRClassNameKey = "class vtkPolyDataEdgeConnectivityFilter";

		/// <summary>
		/// Use to specify x-y-z point coordinates when extracting the region
		/// closest to a specified point.
		/// </summary>
		// Token: 0x0200098A RID: 2442
		public enum RegionGrowingType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001BD4 RID: 7124
			LargeRegions = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001BD5 RID: 7125
			RegionGrowingOff = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001BD6 RID: 7126
			SmallRegions = 2
		}
	}
}
