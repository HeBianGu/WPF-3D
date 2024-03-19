using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAdaptiveSubdivisionFilter
	/// </summary>
	/// <remarks>
	///    subdivide triangles based on edge and/or area metrics
	///
	///
	/// vtkAdaptiveSubdivisionFilter is a filter that subdivides triangles based
	/// on maximum edge length and/or triangle area. It uses a simple case-based,
	/// multi-pass approach to repeatedly subdivide the input triangle mesh to
	/// meet the area and/or edge length criteria. New points may be inserted only
	/// on edges; depending on the number of edges to be subdivided a different
	/// number of triangles are inserted ranging from two (i.e., two triangles
	/// replace the original one) to four.
	///
	/// Triangle subdivision is controlled by specifying a maximum edge length
	/// and/or triangle area that any given triangle may have. Subdivision
	/// proceeds until their criteria are satisfied. Note that using excessively
	/// small criteria values can produce enormous meshes with the possibility of
	/// exhausting system memory. Also, if you want to ignore a particular
	/// criterion value (e.g., triangle area) then simply set the criterion value
	/// to a very large value (e.g., VTK_DOUBLE_MAX).
	///
	/// An incremental point locator is used because as new points are created, a
	/// search is made to ensure that a point has not already been created. This
	/// ensures that the mesh remains compatible (watertight) as long as certain
	/// criteria are not used (triangle area limit, and number of triangles limit).
	///
	/// To prevent overly large triangle meshes from being created, it is possible
	/// to set a limit on the number of triangles created. By default this number
	/// is a very large number (i.e., no limit). Further, a limit on the number of
	/// passes can also be set, this is mostly useful to generated animations of
	/// the algorithm.
	///
	/// Finally, the attribute data (point and cell data) is treated as follows.
	/// The cell data from a parent triangle is assigned to its subdivided
	/// children.  Point data is interpolated along edges as the edges are
	/// subdivided.
	///
	/// @warning
	/// The subdivision is linear along edges. Thus do not expect smoothing or
	/// blending effects to occur. If you need to smooth the resulting mesh use an
	/// algorithm like vtkWindowedSincPolyDataFilter or vtkSmoothPolyDataFilter.
	///
	/// The filter retains mesh compatibility (watertightness) if the mesh was
	/// originally compatible; and the area, max triangles criteria are not used.
	///
	/// @warning
	/// The filter requires a triangle mesh. Use vtkTriangleFilter to tessellate
	/// the mesh if necessary.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkInterpolatingSubdivisionFilter vtkLinearSubdivisionFilter
	/// vtkButterflySubdivisionFilter vtkTriangleFilter
	/// </seealso>
	// Token: 0x02000546 RID: 1350
	public class vtkAdaptiveSubdivisionFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F05F RID: 61535 RVA: 0x0014EFFF File Offset: 0x0014D1FF
		static vtkAdaptiveSubdivisionFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAdaptiveSubdivisionFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAdaptiveSubdivisionFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F060 RID: 61536 RVA: 0x0014F027 File Offset: 0x0014D227
		public vtkAdaptiveSubdivisionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F061 RID: 61537
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAdaptiveSubdivisionFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type info, and printing.
		/// </summary>
		// Token: 0x0600F062 RID: 61538 RVA: 0x0014F038 File Offset: 0x0014D238
		public new static vtkAdaptiveSubdivisionFilter New()
		{
			vtkAdaptiveSubdivisionFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAdaptiveSubdivisionFilter.vtkAdaptiveSubdivisionFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAdaptiveSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, type info, and printing.
		/// </summary>
		// Token: 0x0600F063 RID: 61539 RVA: 0x0014F08C File Offset: 0x0014D28C
		public vtkAdaptiveSubdivisionFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAdaptiveSubdivisionFilter.vtkAdaptiveSubdivisionFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F064 RID: 61540 RVA: 0x0014F0D0 File Offset: 0x0014D2D0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F065 RID: 61541
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAdaptiveSubdivisionFilter_CreateDefaultLocator_01(HandleRef pThis);

		/// <summary>
		/// Create a default locator. Used to create one when none is
		/// specified.
		/// </summary>
		// Token: 0x0600F066 RID: 61542 RVA: 0x0014F0DB File Offset: 0x0014D2DB
		public void CreateDefaultLocator()
		{
			vtkAdaptiveSubdivisionFilter.vtkAdaptiveSubdivisionFilter_CreateDefaultLocator_01(base.GetCppThis());
		}

		// Token: 0x0600F067 RID: 61543
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAdaptiveSubdivisionFilter_GetLocator_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get a spatial locator for merging points. By default,
		/// an instance of vtkMergePoints is used. This is used to merge
		/// coincident points during subdivision.
		/// </summary>
		// Token: 0x0600F068 RID: 61544 RVA: 0x0014F0EC File Offset: 0x0014D2EC
		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAdaptiveSubdivisionFilter.vtkAdaptiveSubdivisionFilter_GetLocator_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIncrementalPointLocator = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIncrementalPointLocator.Register(null);
				}
			}
			return vtkIncrementalPointLocator;
		}

		// Token: 0x0600F069 RID: 61545
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkAdaptiveSubdivisionFilter_GetMTime_03(HandleRef pThis);

		/// <summary>
		/// Modified GetMTime because of the dependence on the locator.
		/// </summary>
		// Token: 0x0600F06A RID: 61546 RVA: 0x0014F15C File Offset: 0x0014D35C
		public override ulong GetMTime()
		{
			return vtkAdaptiveSubdivisionFilter.vtkAdaptiveSubdivisionFilter_GetMTime_03(base.GetCppThis());
		}

		// Token: 0x0600F06B RID: 61547
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAdaptiveSubdivisionFilter_GetMaximumEdgeLength_04(HandleRef pThis);

		/// <summary>
		/// Specify the maximum edge length that a triangle may have. Edges longer
		/// than this value are split in half and the associated triangles are
		/// modified accordingly.
		/// </summary>
		// Token: 0x0600F06C RID: 61548 RVA: 0x0014F17C File Offset: 0x0014D37C
		public virtual double GetMaximumEdgeLength()
		{
			return vtkAdaptiveSubdivisionFilter.vtkAdaptiveSubdivisionFilter_GetMaximumEdgeLength_04(base.GetCppThis());
		}

		// Token: 0x0600F06D RID: 61549
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAdaptiveSubdivisionFilter_GetMaximumEdgeLengthMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Specify the maximum edge length that a triangle may have. Edges longer
		/// than this value are split in half and the associated triangles are
		/// modified accordingly.
		/// </summary>
		// Token: 0x0600F06E RID: 61550 RVA: 0x0014F19C File Offset: 0x0014D39C
		public virtual double GetMaximumEdgeLengthMaxValue()
		{
			return vtkAdaptiveSubdivisionFilter.vtkAdaptiveSubdivisionFilter_GetMaximumEdgeLengthMaxValue_05(base.GetCppThis());
		}

		// Token: 0x0600F06F RID: 61551
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAdaptiveSubdivisionFilter_GetMaximumEdgeLengthMinValue_06(HandleRef pThis);

		/// <summary>
		/// Specify the maximum edge length that a triangle may have. Edges longer
		/// than this value are split in half and the associated triangles are
		/// modified accordingly.
		/// </summary>
		// Token: 0x0600F070 RID: 61552 RVA: 0x0014F1BC File Offset: 0x0014D3BC
		public virtual double GetMaximumEdgeLengthMinValue()
		{
			return vtkAdaptiveSubdivisionFilter.vtkAdaptiveSubdivisionFilter_GetMaximumEdgeLengthMinValue_06(base.GetCppThis());
		}

		// Token: 0x0600F071 RID: 61553
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAdaptiveSubdivisionFilter_GetMaximumNumberOfPasses_07(HandleRef pThis);

		/// <summary>
		/// Set a limit on the number of passes (i.e., levels of subdivision).  If
		/// the limit is hit, then the subdivision process stops and additional
		/// passes (needed to meet other criteria) are aborted. The default limit is
		/// set to a very large number (i.e., no effective limit).
		/// </summary>
		// Token: 0x0600F072 RID: 61554 RVA: 0x0014F1DC File Offset: 0x0014D3DC
		public virtual long GetMaximumNumberOfPasses()
		{
			return vtkAdaptiveSubdivisionFilter.vtkAdaptiveSubdivisionFilter_GetMaximumNumberOfPasses_07(base.GetCppThis());
		}

		// Token: 0x0600F073 RID: 61555
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAdaptiveSubdivisionFilter_GetMaximumNumberOfPassesMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Set a limit on the number of passes (i.e., levels of subdivision).  If
		/// the limit is hit, then the subdivision process stops and additional
		/// passes (needed to meet other criteria) are aborted. The default limit is
		/// set to a very large number (i.e., no effective limit).
		/// </summary>
		// Token: 0x0600F074 RID: 61556 RVA: 0x0014F1FC File Offset: 0x0014D3FC
		public virtual long GetMaximumNumberOfPassesMaxValue()
		{
			return vtkAdaptiveSubdivisionFilter.vtkAdaptiveSubdivisionFilter_GetMaximumNumberOfPassesMaxValue_08(base.GetCppThis());
		}

		// Token: 0x0600F075 RID: 61557
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAdaptiveSubdivisionFilter_GetMaximumNumberOfPassesMinValue_09(HandleRef pThis);

		/// <summary>
		/// Set a limit on the number of passes (i.e., levels of subdivision).  If
		/// the limit is hit, then the subdivision process stops and additional
		/// passes (needed to meet other criteria) are aborted. The default limit is
		/// set to a very large number (i.e., no effective limit).
		/// </summary>
		// Token: 0x0600F076 RID: 61558 RVA: 0x0014F21C File Offset: 0x0014D41C
		public virtual long GetMaximumNumberOfPassesMinValue()
		{
			return vtkAdaptiveSubdivisionFilter.vtkAdaptiveSubdivisionFilter_GetMaximumNumberOfPassesMinValue_09(base.GetCppThis());
		}

		// Token: 0x0600F077 RID: 61559
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAdaptiveSubdivisionFilter_GetMaximumNumberOfTriangles_10(HandleRef pThis);

		/// <summary>
		/// Set a limit on the maximum number of triangles that can be created.  If
		/// the limit is hit, it may result in premature termination of the
		/// algorithm and the results may be less than satisfactory (for example
		/// non-watertight meshes may be created). By default, the limit is set to a
		/// very large number (i.e., no effective limit).
		/// </summary>
		// Token: 0x0600F078 RID: 61560 RVA: 0x0014F23C File Offset: 0x0014D43C
		public virtual long GetMaximumNumberOfTriangles()
		{
			return vtkAdaptiveSubdivisionFilter.vtkAdaptiveSubdivisionFilter_GetMaximumNumberOfTriangles_10(base.GetCppThis());
		}

		// Token: 0x0600F079 RID: 61561
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAdaptiveSubdivisionFilter_GetMaximumNumberOfTrianglesMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Set a limit on the maximum number of triangles that can be created.  If
		/// the limit is hit, it may result in premature termination of the
		/// algorithm and the results may be less than satisfactory (for example
		/// non-watertight meshes may be created). By default, the limit is set to a
		/// very large number (i.e., no effective limit).
		/// </summary>
		// Token: 0x0600F07A RID: 61562 RVA: 0x0014F25C File Offset: 0x0014D45C
		public virtual long GetMaximumNumberOfTrianglesMaxValue()
		{
			return vtkAdaptiveSubdivisionFilter.vtkAdaptiveSubdivisionFilter_GetMaximumNumberOfTrianglesMaxValue_11(base.GetCppThis());
		}

		// Token: 0x0600F07B RID: 61563
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAdaptiveSubdivisionFilter_GetMaximumNumberOfTrianglesMinValue_12(HandleRef pThis);

		/// <summary>
		/// Set a limit on the maximum number of triangles that can be created.  If
		/// the limit is hit, it may result in premature termination of the
		/// algorithm and the results may be less than satisfactory (for example
		/// non-watertight meshes may be created). By default, the limit is set to a
		/// very large number (i.e., no effective limit).
		/// </summary>
		// Token: 0x0600F07C RID: 61564 RVA: 0x0014F27C File Offset: 0x0014D47C
		public virtual long GetMaximumNumberOfTrianglesMinValue()
		{
			return vtkAdaptiveSubdivisionFilter.vtkAdaptiveSubdivisionFilter_GetMaximumNumberOfTrianglesMinValue_12(base.GetCppThis());
		}

		// Token: 0x0600F07D RID: 61565
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAdaptiveSubdivisionFilter_GetMaximumTriangleArea_13(HandleRef pThis);

		/// <summary>
		/// Specify the maximum area that a triangle may have. Triangles larger
		/// than this value are subdivided to meet this threshold. Note that if
		/// this criterion is used it may produce non-watertight meshes as a
		/// result.
		/// </summary>
		// Token: 0x0600F07E RID: 61566 RVA: 0x0014F29C File Offset: 0x0014D49C
		public virtual double GetMaximumTriangleArea()
		{
			return vtkAdaptiveSubdivisionFilter.vtkAdaptiveSubdivisionFilter_GetMaximumTriangleArea_13(base.GetCppThis());
		}

		// Token: 0x0600F07F RID: 61567
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAdaptiveSubdivisionFilter_GetMaximumTriangleAreaMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Specify the maximum area that a triangle may have. Triangles larger
		/// than this value are subdivided to meet this threshold. Note that if
		/// this criterion is used it may produce non-watertight meshes as a
		/// result.
		/// </summary>
		// Token: 0x0600F080 RID: 61568 RVA: 0x0014F2BC File Offset: 0x0014D4BC
		public virtual double GetMaximumTriangleAreaMaxValue()
		{
			return vtkAdaptiveSubdivisionFilter.vtkAdaptiveSubdivisionFilter_GetMaximumTriangleAreaMaxValue_14(base.GetCppThis());
		}

		// Token: 0x0600F081 RID: 61569
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAdaptiveSubdivisionFilter_GetMaximumTriangleAreaMinValue_15(HandleRef pThis);

		/// <summary>
		/// Specify the maximum area that a triangle may have. Triangles larger
		/// than this value are subdivided to meet this threshold. Note that if
		/// this criterion is used it may produce non-watertight meshes as a
		/// result.
		/// </summary>
		// Token: 0x0600F082 RID: 61570 RVA: 0x0014F2DC File Offset: 0x0014D4DC
		public virtual double GetMaximumTriangleAreaMinValue()
		{
			return vtkAdaptiveSubdivisionFilter.vtkAdaptiveSubdivisionFilter_GetMaximumTriangleAreaMinValue_15(base.GetCppThis());
		}

		// Token: 0x0600F083 RID: 61571
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAdaptiveSubdivisionFilter_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type info, and printing.
		/// </summary>
		// Token: 0x0600F084 RID: 61572 RVA: 0x0014F2FC File Offset: 0x0014D4FC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAdaptiveSubdivisionFilter.vtkAdaptiveSubdivisionFilter_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x0600F085 RID: 61573
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAdaptiveSubdivisionFilter_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type info, and printing.
		/// </summary>
		// Token: 0x0600F086 RID: 61574 RVA: 0x0014F31C File Offset: 0x0014D51C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAdaptiveSubdivisionFilter.vtkAdaptiveSubdivisionFilter_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x0600F087 RID: 61575
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAdaptiveSubdivisionFilter_GetOutputPointsPrecision_18(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::Precision enum for an explanation of the available
		/// precision settings.
		/// </summary>
		// Token: 0x0600F088 RID: 61576 RVA: 0x0014F338 File Offset: 0x0014D538
		public virtual int GetOutputPointsPrecision()
		{
			return vtkAdaptiveSubdivisionFilter.vtkAdaptiveSubdivisionFilter_GetOutputPointsPrecision_18(base.GetCppThis());
		}

		// Token: 0x0600F089 RID: 61577
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAdaptiveSubdivisionFilter_IsA_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type info, and printing.
		/// </summary>
		// Token: 0x0600F08A RID: 61578 RVA: 0x0014F358 File Offset: 0x0014D558
		public override int IsA(string type)
		{
			return vtkAdaptiveSubdivisionFilter.vtkAdaptiveSubdivisionFilter_IsA_19(base.GetCppThis(), type);
		}

		// Token: 0x0600F08B RID: 61579
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAdaptiveSubdivisionFilter_IsTypeOf_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type info, and printing.
		/// </summary>
		// Token: 0x0600F08C RID: 61580 RVA: 0x0014F378 File Offset: 0x0014D578
		public new static int IsTypeOf(string type)
		{
			return vtkAdaptiveSubdivisionFilter.vtkAdaptiveSubdivisionFilter_IsTypeOf_20(type);
		}

		// Token: 0x0600F08D RID: 61581
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAdaptiveSubdivisionFilter_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type info, and printing.
		/// </summary>
		// Token: 0x0600F08E RID: 61582 RVA: 0x0014F394 File Offset: 0x0014D594
		public new vtkAdaptiveSubdivisionFilter NewInstance()
		{
			vtkAdaptiveSubdivisionFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAdaptiveSubdivisionFilter.vtkAdaptiveSubdivisionFilter_NewInstance_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAdaptiveSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F08F RID: 61583
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAdaptiveSubdivisionFilter_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type info, and printing.
		/// </summary>
		// Token: 0x0600F090 RID: 61584 RVA: 0x0014F3F0 File Offset: 0x0014D5F0
		public new static vtkAdaptiveSubdivisionFilter SafeDownCast(vtkObjectBase o)
		{
			vtkAdaptiveSubdivisionFilter vtkAdaptiveSubdivisionFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAdaptiveSubdivisionFilter.vtkAdaptiveSubdivisionFilter_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAdaptiveSubdivisionFilter = (vtkAdaptiveSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAdaptiveSubdivisionFilter.Register(null);
				}
			}
			return vtkAdaptiveSubdivisionFilter;
		}

		// Token: 0x0600F091 RID: 61585
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAdaptiveSubdivisionFilter_SetLocator_24(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Set / get a spatial locator for merging points. By default,
		/// an instance of vtkMergePoints is used. This is used to merge
		/// coincident points during subdivision.
		/// </summary>
		// Token: 0x0600F092 RID: 61586 RVA: 0x0014F470 File Offset: 0x0014D670
		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkAdaptiveSubdivisionFilter.vtkAdaptiveSubdivisionFilter_SetLocator_24(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0600F093 RID: 61587
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAdaptiveSubdivisionFilter_SetMaximumEdgeLength_25(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the maximum edge length that a triangle may have. Edges longer
		/// than this value are split in half and the associated triangles are
		/// modified accordingly.
		/// </summary>
		// Token: 0x0600F094 RID: 61588 RVA: 0x0014F49F File Offset: 0x0014D69F
		public virtual void SetMaximumEdgeLength(double _arg)
		{
			vtkAdaptiveSubdivisionFilter.vtkAdaptiveSubdivisionFilter_SetMaximumEdgeLength_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F095 RID: 61589
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAdaptiveSubdivisionFilter_SetMaximumNumberOfPasses_26(HandleRef pThis, long _arg);

		/// <summary>
		/// Set a limit on the number of passes (i.e., levels of subdivision).  If
		/// the limit is hit, then the subdivision process stops and additional
		/// passes (needed to meet other criteria) are aborted. The default limit is
		/// set to a very large number (i.e., no effective limit).
		/// </summary>
		// Token: 0x0600F096 RID: 61590 RVA: 0x0014F4AF File Offset: 0x0014D6AF
		public virtual void SetMaximumNumberOfPasses(long _arg)
		{
			vtkAdaptiveSubdivisionFilter.vtkAdaptiveSubdivisionFilter_SetMaximumNumberOfPasses_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F097 RID: 61591
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAdaptiveSubdivisionFilter_SetMaximumNumberOfTriangles_27(HandleRef pThis, long _arg);

		/// <summary>
		/// Set a limit on the maximum number of triangles that can be created.  If
		/// the limit is hit, it may result in premature termination of the
		/// algorithm and the results may be less than satisfactory (for example
		/// non-watertight meshes may be created). By default, the limit is set to a
		/// very large number (i.e., no effective limit).
		/// </summary>
		// Token: 0x0600F098 RID: 61592 RVA: 0x0014F4BF File Offset: 0x0014D6BF
		public virtual void SetMaximumNumberOfTriangles(long _arg)
		{
			vtkAdaptiveSubdivisionFilter.vtkAdaptiveSubdivisionFilter_SetMaximumNumberOfTriangles_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F099 RID: 61593
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAdaptiveSubdivisionFilter_SetMaximumTriangleArea_28(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the maximum area that a triangle may have. Triangles larger
		/// than this value are subdivided to meet this threshold. Note that if
		/// this criterion is used it may produce non-watertight meshes as a
		/// result.
		/// </summary>
		// Token: 0x0600F09A RID: 61594 RVA: 0x0014F4CF File Offset: 0x0014D6CF
		public virtual void SetMaximumTriangleArea(double _arg)
		{
			vtkAdaptiveSubdivisionFilter.vtkAdaptiveSubdivisionFilter_SetMaximumTriangleArea_28(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F09B RID: 61595
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAdaptiveSubdivisionFilter_SetOutputPointsPrecision_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::Precision enum for an explanation of the available
		/// precision settings.
		/// </summary>
		// Token: 0x0600F09C RID: 61596 RVA: 0x0014F4DF File Offset: 0x0014D6DF
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkAdaptiveSubdivisionFilter.vtkAdaptiveSubdivisionFilter_SetOutputPointsPrecision_29(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001184 RID: 4484
		public new const string MRFullTypeName = "Kitware.VTK.vtkAdaptiveSubdivisionFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001185 RID: 4485
		public new static readonly string MRClassNameKey = "class vtkAdaptiveSubdivisionFilter";
	}
}
