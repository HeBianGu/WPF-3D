using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyDataPointSampler
	/// </summary>
	/// <remarks>
	///    generate points from vtkPolyData
	///
	/// vtkPolyDataPointSampler generates points from input vtkPolyData. The
	/// filter has two modes of operation: random point generation, or regular
	/// point generation. In random generation mode, points are generated in each
	/// polygonal entity using a random approach. In regular generation mode, the
	/// points are placed approximately a specified distance apart. Optionally,
	/// the points attributes can be interpolated from the generating vertices,
	/// edges, and polygons.
	///
	/// In regular point generation mode, this filter functions as follows. First,
	/// it regurgitates all input points, then it samples all lines, plus edges
	/// associated with the input polygons and triangle strips to produce edge
	/// points. Finally, the interiors of polygons and triangle strips are
	/// subsampled to produce points. All of these operations can be enabled or
	/// disabled separately. Note that this algorithm only approximately generates
	/// points the specified distance apart. Generally the point density is finer
	/// than requested.
	///
	/// In random point generation mode, this filter functions as follows. First,
	/// it randomly regurgitates all input points (if enabled), then it randomly
	/// samples all lines, plus edges associated with the input polygons and
	/// triangle strips to produce edge points (if enabled). Finally, the
	/// interiors of polygons and triangle strips are randomly subsampled to
	/// produce points. All of these operations can be enabled or disabled
	/// separately. Note that this algorithm only approximately generates points
	/// the specified distance apart. Generally the point density is finer than
	/// requested. Also note that the result is not truly random due to the
	/// constraints of the mesh construction.
	///
	/// @warning
	/// Although this algorithm processes general polygons. it does so by performing
	/// a fan triangulation. This may produce poor results, especially for concave
	/// polygons. For better results, use a triangle filter to pre-tesselate
	/// polygons.
	///
	/// @warning
	/// In random point generation mode, producing random edges and vertex points
	/// from polygons and triangle strips is less random than is typically
	/// desirable. You may wish to disable vertex and edge point generation for a
	/// result that is closer to random.
	///
	/// @warning
	/// Point generation can be useful in a variety of applications. For example,
	/// generating seed points for glyphing or streamline generation. Another
	/// useful application is generating points for implicit modeling. In many
	/// cases implicit models can be more efficiently generated from points than
	/// from polygons or other primitives.
	///
	/// @warning
	/// When sampling polygons of five sides or more, the polygon is triangulated.
	/// This can result in variations in point density near tessellation boundaries.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTriangleFilter vtkImplicitModeller
	/// </seealso>
	// Token: 0x02000565 RID: 1381
	public class vtkPolyDataPointSampler : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F44A RID: 62538 RVA: 0x00154387 File Offset: 0x00152587
		static vtkPolyDataPointSampler()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataPointSampler.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataPointSampler"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F44B RID: 62539 RVA: 0x001543AF File Offset: 0x001525AF
		public vtkPolyDataPointSampler(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F44C RID: 62540
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataPointSampler_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x0600F44D RID: 62541 RVA: 0x001543C0 File Offset: 0x001525C0
		public new static vtkPolyDataPointSampler New()
		{
			vtkPolyDataPointSampler result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataPointSampler.vtkPolyDataPointSampler_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataPointSampler)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x0600F44E RID: 62542 RVA: 0x00154414 File Offset: 0x00152614
		public vtkPolyDataPointSampler() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolyDataPointSampler.vtkPolyDataPointSampler_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F44F RID: 62543 RVA: 0x00154458 File Offset: 0x00152658
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F450 RID: 62544
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPointSampler_GenerateEdgePointsOff_01(HandleRef pThis);

		/// <summary>
		/// Specify/retrieve a boolean flag indicating whether cell edges should
		/// be sampled to produce output points. The default is true.
		/// </summary>
		// Token: 0x0600F451 RID: 62545 RVA: 0x00154463 File Offset: 0x00152663
		public virtual void GenerateEdgePointsOff()
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_GenerateEdgePointsOff_01(base.GetCppThis());
		}

		// Token: 0x0600F452 RID: 62546
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPointSampler_GenerateEdgePointsOn_02(HandleRef pThis);

		/// <summary>
		/// Specify/retrieve a boolean flag indicating whether cell edges should
		/// be sampled to produce output points. The default is true.
		/// </summary>
		// Token: 0x0600F453 RID: 62547 RVA: 0x00154472 File Offset: 0x00152672
		public virtual void GenerateEdgePointsOn()
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_GenerateEdgePointsOn_02(base.GetCppThis());
		}

		// Token: 0x0600F454 RID: 62548
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPointSampler_GenerateInteriorPointsOff_03(HandleRef pThis);

		/// <summary>
		/// Specify/retrieve a boolean flag indicating whether cell interiors should
		/// be sampled to produce output points. The default is true.
		/// </summary>
		// Token: 0x0600F455 RID: 62549 RVA: 0x00154481 File Offset: 0x00152681
		public virtual void GenerateInteriorPointsOff()
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_GenerateInteriorPointsOff_03(base.GetCppThis());
		}

		// Token: 0x0600F456 RID: 62550
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPointSampler_GenerateInteriorPointsOn_04(HandleRef pThis);

		/// <summary>
		/// Specify/retrieve a boolean flag indicating whether cell interiors should
		/// be sampled to produce output points. The default is true.
		/// </summary>
		// Token: 0x0600F457 RID: 62551 RVA: 0x00154490 File Offset: 0x00152690
		public virtual void GenerateInteriorPointsOn()
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_GenerateInteriorPointsOn_04(base.GetCppThis());
		}

		// Token: 0x0600F458 RID: 62552
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPointSampler_GenerateVertexPointsOff_05(HandleRef pThis);

		/// <summary>
		/// Specify/retrieve a boolean flag indicating whether cell vertex points should
		/// be output.
		/// </summary>
		// Token: 0x0600F459 RID: 62553 RVA: 0x0015449F File Offset: 0x0015269F
		public virtual void GenerateVertexPointsOff()
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_GenerateVertexPointsOff_05(base.GetCppThis());
		}

		// Token: 0x0600F45A RID: 62554
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPointSampler_GenerateVertexPointsOn_06(HandleRef pThis);

		/// <summary>
		/// Specify/retrieve a boolean flag indicating whether cell vertex points should
		/// be output.
		/// </summary>
		// Token: 0x0600F45B RID: 62555 RVA: 0x001544AE File Offset: 0x001526AE
		public virtual void GenerateVertexPointsOn()
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_GenerateVertexPointsOn_06(base.GetCppThis());
		}

		// Token: 0x0600F45C RID: 62556
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPointSampler_GenerateVerticesOff_07(HandleRef pThis);

		/// <summary>
		/// Specify/retrieve a boolean flag indicating whether cell vertices should
		/// be generated. Cell vertices are useful if you actually want to display
		/// the points (that is, for each point generated, a vertex is generated).
		/// Recall that VTK only renders vertices and not points.  The default is
		/// true.
		/// </summary>
		// Token: 0x0600F45D RID: 62557 RVA: 0x001544BD File Offset: 0x001526BD
		public virtual void GenerateVerticesOff()
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_GenerateVerticesOff_07(base.GetCppThis());
		}

		// Token: 0x0600F45E RID: 62558
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPointSampler_GenerateVerticesOn_08(HandleRef pThis);

		/// <summary>
		/// Specify/retrieve a boolean flag indicating whether cell vertices should
		/// be generated. Cell vertices are useful if you actually want to display
		/// the points (that is, for each point generated, a vertex is generated).
		/// Recall that VTK only renders vertices and not points.  The default is
		/// true.
		/// </summary>
		// Token: 0x0600F45F RID: 62559 RVA: 0x001544CC File Offset: 0x001526CC
		public virtual void GenerateVerticesOn()
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_GenerateVerticesOn_08(base.GetCppThis());
		}

		// Token: 0x0600F460 RID: 62560
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolyDataPointSampler_GetDistance_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the approximate distance between points. This is an absolute
		/// distance measure. The default is 0.01.
		/// </summary>
		// Token: 0x0600F461 RID: 62561 RVA: 0x001544DC File Offset: 0x001526DC
		public virtual double GetDistance()
		{
			return vtkPolyDataPointSampler.vtkPolyDataPointSampler_GetDistance_09(base.GetCppThis());
		}

		// Token: 0x0600F462 RID: 62562
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolyDataPointSampler_GetDistanceMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the approximate distance between points. This is an absolute
		/// distance measure. The default is 0.01.
		/// </summary>
		// Token: 0x0600F463 RID: 62563 RVA: 0x001544FC File Offset: 0x001526FC
		public virtual double GetDistanceMaxValue()
		{
			return vtkPolyDataPointSampler.vtkPolyDataPointSampler_GetDistanceMaxValue_10(base.GetCppThis());
		}

		// Token: 0x0600F464 RID: 62564
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolyDataPointSampler_GetDistanceMinValue_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the approximate distance between points. This is an absolute
		/// distance measure. The default is 0.01.
		/// </summary>
		// Token: 0x0600F465 RID: 62565 RVA: 0x0015451C File Offset: 0x0015271C
		public virtual double GetDistanceMinValue()
		{
			return vtkPolyDataPointSampler.vtkPolyDataPointSampler_GetDistanceMinValue_11(base.GetCppThis());
		}

		// Token: 0x0600F466 RID: 62566
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolyDataPointSampler_GetGenerateEdgePoints_12(HandleRef pThis);

		/// <summary>
		/// Specify/retrieve a boolean flag indicating whether cell edges should
		/// be sampled to produce output points. The default is true.
		/// </summary>
		// Token: 0x0600F467 RID: 62567 RVA: 0x0015453C File Offset: 0x0015273C
		public virtual bool GetGenerateEdgePoints()
		{
			return vtkPolyDataPointSampler.vtkPolyDataPointSampler_GetGenerateEdgePoints_12(base.GetCppThis()) != 0;
		}

		// Token: 0x0600F468 RID: 62568
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolyDataPointSampler_GetGenerateInteriorPoints_13(HandleRef pThis);

		/// <summary>
		/// Specify/retrieve a boolean flag indicating whether cell interiors should
		/// be sampled to produce output points. The default is true.
		/// </summary>
		// Token: 0x0600F469 RID: 62569 RVA: 0x00154564 File Offset: 0x00152764
		public virtual bool GetGenerateInteriorPoints()
		{
			return vtkPolyDataPointSampler.vtkPolyDataPointSampler_GetGenerateInteriorPoints_13(base.GetCppThis()) != 0;
		}

		// Token: 0x0600F46A RID: 62570
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolyDataPointSampler_GetGenerateVertexPoints_14(HandleRef pThis);

		/// <summary>
		/// Specify/retrieve a boolean flag indicating whether cell vertex points should
		/// be output.
		/// </summary>
		// Token: 0x0600F46B RID: 62571 RVA: 0x0015458C File Offset: 0x0015278C
		public virtual bool GetGenerateVertexPoints()
		{
			return vtkPolyDataPointSampler.vtkPolyDataPointSampler_GetGenerateVertexPoints_14(base.GetCppThis()) != 0;
		}

		// Token: 0x0600F46C RID: 62572
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolyDataPointSampler_GetGenerateVertices_15(HandleRef pThis);

		/// <summary>
		/// Specify/retrieve a boolean flag indicating whether cell vertices should
		/// be generated. Cell vertices are useful if you actually want to display
		/// the points (that is, for each point generated, a vertex is generated).
		/// Recall that VTK only renders vertices and not points.  The default is
		/// true.
		/// </summary>
		// Token: 0x0600F46D RID: 62573 RVA: 0x001545B4 File Offset: 0x001527B4
		public virtual bool GetGenerateVertices()
		{
			return vtkPolyDataPointSampler.vtkPolyDataPointSampler_GetGenerateVertices_15(base.GetCppThis()) != 0;
		}

		// Token: 0x0600F46E RID: 62574
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolyDataPointSampler_GetInterpolatePointData_16(HandleRef pThis);

		/// <summary>
		/// Specify/retrieve a boolean flag indicating whether point data should be
		/// interpolated onto the newly generated points. If enabled, points
		/// generated from existing vertices will carry the vertex point data;
		/// points generated from edges will interpolate point data along each edge;
		/// and interior point data (inside triangles, polygons cells) will be
		/// interpolated from the cell vertices. By default this is off.
		/// </summary>
		// Token: 0x0600F46F RID: 62575 RVA: 0x001545DC File Offset: 0x001527DC
		public virtual bool GetInterpolatePointData()
		{
			return vtkPolyDataPointSampler.vtkPolyDataPointSampler_GetInterpolatePointData_16(base.GetCppThis()) != 0;
		}

		// Token: 0x0600F470 RID: 62576
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataPointSampler_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros for type information and printing.
		/// </summary>
		// Token: 0x0600F471 RID: 62577 RVA: 0x00154604 File Offset: 0x00152804
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolyDataPointSampler.vtkPolyDataPointSampler_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x0600F472 RID: 62578
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataPointSampler_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros for type information and printing.
		/// </summary>
		// Token: 0x0600F473 RID: 62579 RVA: 0x00154624 File Offset: 0x00152824
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolyDataPointSampler.vtkPolyDataPointSampler_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x0600F474 RID: 62580
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataPointSampler_GetPointGenerationMode_19(HandleRef pThis);

		/// <summary>
		/// Specify/retrieve the type of point generation: either regular point
		/// generation or random point generation. By default, regular point
		/// generation is used.
		/// </summary>
		// Token: 0x0600F475 RID: 62581 RVA: 0x00154640 File Offset: 0x00152840
		public virtual int GetPointGenerationMode()
		{
			return vtkPolyDataPointSampler.vtkPolyDataPointSampler_GetPointGenerationMode_19(base.GetCppThis());
		}

		// Token: 0x0600F476 RID: 62582
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataPointSampler_GetPointGenerationModeMaxValue_20(HandleRef pThis);

		/// <summary>
		/// Specify/retrieve the type of point generation: either regular point
		/// generation or random point generation. By default, regular point
		/// generation is used.
		/// </summary>
		// Token: 0x0600F477 RID: 62583 RVA: 0x00154660 File Offset: 0x00152860
		public virtual int GetPointGenerationModeMaxValue()
		{
			return vtkPolyDataPointSampler.vtkPolyDataPointSampler_GetPointGenerationModeMaxValue_20(base.GetCppThis());
		}

		// Token: 0x0600F478 RID: 62584
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataPointSampler_GetPointGenerationModeMinValue_21(HandleRef pThis);

		/// <summary>
		/// Specify/retrieve the type of point generation: either regular point
		/// generation or random point generation. By default, regular point
		/// generation is used.
		/// </summary>
		// Token: 0x0600F479 RID: 62585 RVA: 0x00154680 File Offset: 0x00152880
		public virtual int GetPointGenerationModeMinValue()
		{
			return vtkPolyDataPointSampler.vtkPolyDataPointSampler_GetPointGenerationModeMinValue_21(base.GetCppThis());
		}

		// Token: 0x0600F47A RID: 62586
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPointSampler_InterpolatePointDataOff_22(HandleRef pThis);

		/// <summary>
		/// Specify/retrieve a boolean flag indicating whether point data should be
		/// interpolated onto the newly generated points. If enabled, points
		/// generated from existing vertices will carry the vertex point data;
		/// points generated from edges will interpolate point data along each edge;
		/// and interior point data (inside triangles, polygons cells) will be
		/// interpolated from the cell vertices. By default this is off.
		/// </summary>
		// Token: 0x0600F47B RID: 62587 RVA: 0x0015469F File Offset: 0x0015289F
		public virtual void InterpolatePointDataOff()
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_InterpolatePointDataOff_22(base.GetCppThis());
		}

		// Token: 0x0600F47C RID: 62588
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPointSampler_InterpolatePointDataOn_23(HandleRef pThis);

		/// <summary>
		/// Specify/retrieve a boolean flag indicating whether point data should be
		/// interpolated onto the newly generated points. If enabled, points
		/// generated from existing vertices will carry the vertex point data;
		/// points generated from edges will interpolate point data along each edge;
		/// and interior point data (inside triangles, polygons cells) will be
		/// interpolated from the cell vertices. By default this is off.
		/// </summary>
		// Token: 0x0600F47D RID: 62589 RVA: 0x001546AE File Offset: 0x001528AE
		public virtual void InterpolatePointDataOn()
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_InterpolatePointDataOn_23(base.GetCppThis());
		}

		// Token: 0x0600F47E RID: 62590
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataPointSampler_IsA_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros for type information and printing.
		/// </summary>
		// Token: 0x0600F47F RID: 62591 RVA: 0x001546C0 File Offset: 0x001528C0
		public override int IsA(string type)
		{
			return vtkPolyDataPointSampler.vtkPolyDataPointSampler_IsA_24(base.GetCppThis(), type);
		}

		// Token: 0x0600F480 RID: 62592
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataPointSampler_IsTypeOf_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros for type information and printing.
		/// </summary>
		// Token: 0x0600F481 RID: 62593 RVA: 0x001546E0 File Offset: 0x001528E0
		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataPointSampler.vtkPolyDataPointSampler_IsTypeOf_25(type);
		}

		// Token: 0x0600F482 RID: 62594
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataPointSampler_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard macros for type information and printing.
		/// </summary>
		// Token: 0x0600F483 RID: 62595 RVA: 0x001546FC File Offset: 0x001528FC
		public new vtkPolyDataPointSampler NewInstance()
		{
			vtkPolyDataPointSampler result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataPointSampler.vtkPolyDataPointSampler_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataPointSampler)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F484 RID: 62596
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataPointSampler_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard macros for type information and printing.
		/// </summary>
		// Token: 0x0600F485 RID: 62597 RVA: 0x00154758 File Offset: 0x00152958
		public new static vtkPolyDataPointSampler SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataPointSampler vtkPolyDataPointSampler = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataPointSampler.vtkPolyDataPointSampler_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataPointSampler = (vtkPolyDataPointSampler)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataPointSampler.Register(null);
				}
			}
			return vtkPolyDataPointSampler;
		}

		// Token: 0x0600F486 RID: 62598
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPointSampler_SetDistance_29(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the approximate distance between points. This is an absolute
		/// distance measure. The default is 0.01.
		/// </summary>
		// Token: 0x0600F487 RID: 62599 RVA: 0x001547D7 File Offset: 0x001529D7
		public virtual void SetDistance(double _arg)
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_SetDistance_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F488 RID: 62600
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPointSampler_SetGenerateEdgePoints_30(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify/retrieve a boolean flag indicating whether cell edges should
		/// be sampled to produce output points. The default is true.
		/// </summary>
		// Token: 0x0600F489 RID: 62601 RVA: 0x001547E7 File Offset: 0x001529E7
		public virtual void SetGenerateEdgePoints(bool _arg)
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_SetGenerateEdgePoints_30(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600F48A RID: 62602
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPointSampler_SetGenerateInteriorPoints_31(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify/retrieve a boolean flag indicating whether cell interiors should
		/// be sampled to produce output points. The default is true.
		/// </summary>
		// Token: 0x0600F48B RID: 62603 RVA: 0x001547FF File Offset: 0x001529FF
		public virtual void SetGenerateInteriorPoints(bool _arg)
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_SetGenerateInteriorPoints_31(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600F48C RID: 62604
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPointSampler_SetGenerateVertexPoints_32(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify/retrieve a boolean flag indicating whether cell vertex points should
		/// be output.
		/// </summary>
		// Token: 0x0600F48D RID: 62605 RVA: 0x00154817 File Offset: 0x00152A17
		public virtual void SetGenerateVertexPoints(bool _arg)
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_SetGenerateVertexPoints_32(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600F48E RID: 62606
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPointSampler_SetGenerateVertices_33(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify/retrieve a boolean flag indicating whether cell vertices should
		/// be generated. Cell vertices are useful if you actually want to display
		/// the points (that is, for each point generated, a vertex is generated).
		/// Recall that VTK only renders vertices and not points.  The default is
		/// true.
		/// </summary>
		// Token: 0x0600F48F RID: 62607 RVA: 0x0015482F File Offset: 0x00152A2F
		public virtual void SetGenerateVertices(bool _arg)
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_SetGenerateVertices_33(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600F490 RID: 62608
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPointSampler_SetInterpolatePointData_34(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify/retrieve a boolean flag indicating whether point data should be
		/// interpolated onto the newly generated points. If enabled, points
		/// generated from existing vertices will carry the vertex point data;
		/// points generated from edges will interpolate point data along each edge;
		/// and interior point data (inside triangles, polygons cells) will be
		/// interpolated from the cell vertices. By default this is off.
		/// </summary>
		// Token: 0x0600F491 RID: 62609 RVA: 0x00154847 File Offset: 0x00152A47
		public virtual void SetInterpolatePointData(bool _arg)
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_SetInterpolatePointData_34(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600F492 RID: 62610
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPointSampler_SetPointGenerationMode_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify/retrieve the type of point generation: either regular point
		/// generation or random point generation. By default, regular point
		/// generation is used.
		/// </summary>
		// Token: 0x0600F493 RID: 62611 RVA: 0x0015485F File Offset: 0x00152A5F
		public virtual void SetPointGenerationMode(int _arg)
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_SetPointGenerationMode_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F494 RID: 62612
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPointSampler_SetPointGenerationModeToRandom_36(HandleRef pThis);

		/// <summary>
		/// Specify/retrieve the type of point generation: either regular point
		/// generation or random point generation. By default, regular point
		/// generation is used.
		/// </summary>
		// Token: 0x0600F495 RID: 62613 RVA: 0x0015486F File Offset: 0x00152A6F
		public void SetPointGenerationModeToRandom()
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_SetPointGenerationModeToRandom_36(base.GetCppThis());
		}

		// Token: 0x0600F496 RID: 62614
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataPointSampler_SetPointGenerationModeToRegular_37(HandleRef pThis);

		/// <summary>
		/// Specify/retrieve the type of point generation: either regular point
		/// generation or random point generation. By default, regular point
		/// generation is used.
		/// </summary>
		// Token: 0x0600F497 RID: 62615 RVA: 0x0015487E File Offset: 0x00152A7E
		public void SetPointGenerationModeToRegular()
		{
			vtkPolyDataPointSampler.vtkPolyDataPointSampler_SetPointGenerationModeToRegular_37(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011D8 RID: 4568
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataPointSampler";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011D9 RID: 4569
		public new static readonly string MRClassNameKey = "class vtkPolyDataPointSampler";

		/// <summary>
		/// Specify how points are to be generated.
		/// </summary>
		// Token: 0x02000566 RID: 1382
		public enum RANDOM_GENERATION_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040011DB RID: 4571
			RANDOM_GENERATION = 1,
			/// <summary>enum member</summary>
			// Token: 0x040011DC RID: 4572
			REGULAR_GENERATION = 0
		}
	}
}
