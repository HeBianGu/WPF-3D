using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCleanPolyData
	/// </summary>
	/// <remarks>
	///    merge duplicate points, and/or remove unused points and/or remove degenerate cells
	///
	/// vtkCleanPolyData is a filter that takes polygonal data as input and
	/// generates polygonal data as output. vtkCleanPolyData will merge duplicate
	/// points (within specified tolerance and if enabled), eliminate points
	/// that are not used in any cell, and if enabled, transform degenerate cells into
	/// appropriate forms (for example, a triangle is converted into a line
	/// if two points of triangle are merged).
	///
	/// Conversion of degenerate cells is controlled by the flags
	/// ConvertLinesToPoints, ConvertPolysToLines, ConvertStripsToPolys which act
	/// cumulatively such that a degenerate strip may become a poly.
	/// The full set is
	/// Line with 1 points -&gt; Vert (if ConvertLinesToPoints)
	/// Poly with 2 points -&gt; Line (if ConvertPolysToLines)
	/// Poly with 1 points -&gt; Vert (if ConvertPolysToLines &amp;&amp; ConvertLinesToPoints)
	/// Strp with 3 points -&gt; Poly (if ConvertStripsToPolys)
	/// Strp with 2 points -&gt; Line (if ConvertStripsToPolys &amp;&amp; ConvertPolysToLines)
	/// Strp with 1 points -&gt; Vert (if ConvertStripsToPolys &amp;&amp; ConvertPolysToLines
	///   &amp;&amp; ConvertLinesToPoints)
	///
	/// Cells of type VTK_POLY_LINE will be converted to a vertex only if
	/// ConvertLinesToPoints is on and all points are merged into one. Degenerate line
	/// segments (with two identical end points) will be removed.
	///
	/// If tolerance is specified precisely=0.0, then vtkCleanPolyData will use
	/// the vtkMergePoints object to merge points (which is faster). Otherwise the
	/// slower vtkIncrementalPointLocator is used.  Before inserting points into the point
	/// locator, this class calls a function OperateOnPoint which can be used (in
	/// subclasses) to further refine the cleaning process. See
	/// vtkQuantizePolyDataPoints.
	///
	/// In addition, if a point global id array is available, then two points are merged
	/// if and only if they share the same global id.
	///
	/// Note that merging of points can be disabled. In this case, a point locator
	/// will not be used, and points that are not used by any cells will be
	/// eliminated, but never merged.
	///
	/// @warning
	/// Merging points can alter topology, including introducing non-manifold
	/// forms. The tolerance should be chosen carefully to avoid these problems.
	/// Subclasses should handle OperateOnBounds as well as OperateOnPoint
	/// to ensure that the locator is correctly initialized (i.e. all modified
	/// points must lie inside modified bounds).
	///
	/// @warning
	/// If you wish to operate on a set of point coordinates that has no cells,
	/// you must add a vtkPolyVertex cell with all of the points to the PolyData
	/// (or use a vtkVertexGlyphFilter) before using the vtkCleanPolyData filter.
	///
	/// @warning
	/// The vtkStaticCleanPolyData filter is similar in operation to
	/// vtkCleanPolyData. However, vtkStaticCleanPolyData is non-incremental and
	/// uses a much faster threading approach (especially for larger datasets, and
	/// when merging points with a non-zero tolerance). However because of the
	/// difference in the traversal order in the point merging process, the output
	/// of the filters may be different.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkQuantizePolyDataPoints vtkStaticCleanPolyData
	/// vtkStaticCleanUnstructuredGrid
	/// </seealso>
	// Token: 0x020008D1 RID: 2257
	public class vtkCleanPolyData : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060174B9 RID: 95417 RVA: 0x0020B8E7 File Offset: 0x00209AE7
		static vtkCleanPolyData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCleanPolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCleanPolyData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060174BA RID: 95418 RVA: 0x0020B90F File Offset: 0x00209B0F
		public vtkCleanPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060174BB RID: 95419
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCleanPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060174BC RID: 95420 RVA: 0x0020B920 File Offset: 0x00209B20
		public new static vtkCleanPolyData New()
		{
			vtkCleanPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCleanPolyData.vtkCleanPolyData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCleanPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060174BD RID: 95421 RVA: 0x0020B974 File Offset: 0x00209B74
		public vtkCleanPolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCleanPolyData.vtkCleanPolyData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060174BE RID: 95422 RVA: 0x0020B9B8 File Offset: 0x00209BB8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060174BF RID: 95423
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanPolyData_ConvertLinesToPointsOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off conversion of degenerate lines to points. Default is On.
		/// </summary>
		// Token: 0x060174C0 RID: 95424 RVA: 0x0020B9C3 File Offset: 0x00209BC3
		public virtual void ConvertLinesToPointsOff()
		{
			vtkCleanPolyData.vtkCleanPolyData_ConvertLinesToPointsOff_01(base.GetCppThis());
		}

		// Token: 0x060174C1 RID: 95425
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanPolyData_ConvertLinesToPointsOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off conversion of degenerate lines to points. Default is On.
		/// </summary>
		// Token: 0x060174C2 RID: 95426 RVA: 0x0020B9D2 File Offset: 0x00209BD2
		public virtual void ConvertLinesToPointsOn()
		{
			vtkCleanPolyData.vtkCleanPolyData_ConvertLinesToPointsOn_02(base.GetCppThis());
		}

		// Token: 0x060174C3 RID: 95427
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanPolyData_ConvertPolysToLinesOff_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off conversion of degenerate polys to lines. Default is On.
		/// </summary>
		// Token: 0x060174C4 RID: 95428 RVA: 0x0020B9E1 File Offset: 0x00209BE1
		public virtual void ConvertPolysToLinesOff()
		{
			vtkCleanPolyData.vtkCleanPolyData_ConvertPolysToLinesOff_03(base.GetCppThis());
		}

		// Token: 0x060174C5 RID: 95429
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanPolyData_ConvertPolysToLinesOn_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off conversion of degenerate polys to lines. Default is On.
		/// </summary>
		// Token: 0x060174C6 RID: 95430 RVA: 0x0020B9F0 File Offset: 0x00209BF0
		public virtual void ConvertPolysToLinesOn()
		{
			vtkCleanPolyData.vtkCleanPolyData_ConvertPolysToLinesOn_04(base.GetCppThis());
		}

		// Token: 0x060174C7 RID: 95431
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanPolyData_ConvertStripsToPolysOff_05(HandleRef pThis);

		/// <summary>
		/// Turn on/off conversion of degenerate strips to polys. Default is On.
		/// </summary>
		// Token: 0x060174C8 RID: 95432 RVA: 0x0020B9FF File Offset: 0x00209BFF
		public virtual void ConvertStripsToPolysOff()
		{
			vtkCleanPolyData.vtkCleanPolyData_ConvertStripsToPolysOff_05(base.GetCppThis());
		}

		// Token: 0x060174C9 RID: 95433
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanPolyData_ConvertStripsToPolysOn_06(HandleRef pThis);

		/// <summary>
		/// Turn on/off conversion of degenerate strips to polys. Default is On.
		/// </summary>
		// Token: 0x060174CA RID: 95434 RVA: 0x0020BA0E File Offset: 0x00209C0E
		public virtual void ConvertStripsToPolysOn()
		{
			vtkCleanPolyData.vtkCleanPolyData_ConvertStripsToPolysOn_06(base.GetCppThis());
		}

		// Token: 0x060174CB RID: 95435
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanPolyData_CreateDefaultLocator_07(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Create default locator. Used to create one when none is specified.
		/// </summary>
		// Token: 0x060174CC RID: 95436 RVA: 0x0020BA20 File Offset: 0x00209C20
		public void CreateDefaultLocator(vtkPolyData input)
		{
			vtkCleanPolyData.vtkCleanPolyData_CreateDefaultLocator_07(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x060174CD RID: 95437
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCleanPolyData_GetAbsoluteTolerance_08(HandleRef pThis);

		/// <summary>
		/// Specify tolerance in absolute terms. Default is 1.0.
		/// </summary>
		// Token: 0x060174CE RID: 95438 RVA: 0x0020BA50 File Offset: 0x00209C50
		public virtual double GetAbsoluteTolerance()
		{
			return vtkCleanPolyData.vtkCleanPolyData_GetAbsoluteTolerance_08(base.GetCppThis());
		}

		// Token: 0x060174CF RID: 95439
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCleanPolyData_GetAbsoluteToleranceMaxValue_09(HandleRef pThis);

		/// <summary>
		/// Specify tolerance in absolute terms. Default is 1.0.
		/// </summary>
		// Token: 0x060174D0 RID: 95440 RVA: 0x0020BA70 File Offset: 0x00209C70
		public virtual double GetAbsoluteToleranceMaxValue()
		{
			return vtkCleanPolyData.vtkCleanPolyData_GetAbsoluteToleranceMaxValue_09(base.GetCppThis());
		}

		// Token: 0x060174D1 RID: 95441
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCleanPolyData_GetAbsoluteToleranceMinValue_10(HandleRef pThis);

		/// <summary>
		/// Specify tolerance in absolute terms. Default is 1.0.
		/// </summary>
		// Token: 0x060174D2 RID: 95442 RVA: 0x0020BA90 File Offset: 0x00209C90
		public virtual double GetAbsoluteToleranceMinValue()
		{
			return vtkCleanPolyData.vtkCleanPolyData_GetAbsoluteToleranceMinValue_10(base.GetCppThis());
		}

		// Token: 0x060174D3 RID: 95443
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCleanPolyData_GetConvertLinesToPoints_11(HandleRef pThis);

		/// <summary>
		/// Turn on/off conversion of degenerate lines to points. Default is On.
		/// </summary>
		// Token: 0x060174D4 RID: 95444 RVA: 0x0020BAB0 File Offset: 0x00209CB0
		public virtual int GetConvertLinesToPoints()
		{
			return vtkCleanPolyData.vtkCleanPolyData_GetConvertLinesToPoints_11(base.GetCppThis());
		}

		// Token: 0x060174D5 RID: 95445
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCleanPolyData_GetConvertPolysToLines_12(HandleRef pThis);

		/// <summary>
		/// Turn on/off conversion of degenerate polys to lines. Default is On.
		/// </summary>
		// Token: 0x060174D6 RID: 95446 RVA: 0x0020BAD0 File Offset: 0x00209CD0
		public virtual int GetConvertPolysToLines()
		{
			return vtkCleanPolyData.vtkCleanPolyData_GetConvertPolysToLines_12(base.GetCppThis());
		}

		// Token: 0x060174D7 RID: 95447
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCleanPolyData_GetConvertStripsToPolys_13(HandleRef pThis);

		/// <summary>
		/// Turn on/off conversion of degenerate strips to polys. Default is On.
		/// </summary>
		// Token: 0x060174D8 RID: 95448 RVA: 0x0020BAF0 File Offset: 0x00209CF0
		public virtual int GetConvertStripsToPolys()
		{
			return vtkCleanPolyData.vtkCleanPolyData_GetConvertStripsToPolys_13(base.GetCppThis());
		}

		// Token: 0x060174D9 RID: 95449
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCleanPolyData_GetLocator_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get a spatial locator for speeding the search process. By
		/// default an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x060174DA RID: 95450 RVA: 0x0020BB10 File Offset: 0x00209D10
		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCleanPolyData.vtkCleanPolyData_GetLocator_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060174DB RID: 95451
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkCleanPolyData_GetMTime_15(HandleRef pThis);

		/// <summary>
		/// Get the MTime of this object also considering the locator.
		/// </summary>
		// Token: 0x060174DC RID: 95452 RVA: 0x0020BB80 File Offset: 0x00209D80
		public override ulong GetMTime()
		{
			return vtkCleanPolyData.vtkCleanPolyData_GetMTime_15(base.GetCppThis());
		}

		// Token: 0x060174DD RID: 95453
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCleanPolyData_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060174DE RID: 95454 RVA: 0x0020BBA0 File Offset: 0x00209DA0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCleanPolyData.vtkCleanPolyData_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x060174DF RID: 95455
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCleanPolyData_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060174E0 RID: 95456 RVA: 0x0020BBC0 File Offset: 0x00209DC0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCleanPolyData.vtkCleanPolyData_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x060174E1 RID: 95457
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCleanPolyData_GetOutputPointsPrecision_18(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x060174E2 RID: 95458 RVA: 0x0020BBDC File Offset: 0x00209DDC
		public virtual int GetOutputPointsPrecision()
		{
			return vtkCleanPolyData.vtkCleanPolyData_GetOutputPointsPrecision_18(base.GetCppThis());
		}

		// Token: 0x060174E3 RID: 95459
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCleanPolyData_GetPieceInvariant_19(HandleRef pThis);

		/// <summary>
		/// Perform operation on bounds
		/// </summary>
		// Token: 0x060174E4 RID: 95460 RVA: 0x0020BBFC File Offset: 0x00209DFC
		public virtual int GetPieceInvariant()
		{
			return vtkCleanPolyData.vtkCleanPolyData_GetPieceInvariant_19(base.GetCppThis());
		}

		// Token: 0x060174E5 RID: 95461
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCleanPolyData_GetPointMerging_20(HandleRef pThis);

		/// <summary>
		/// Set/Get a boolean value that controls whether point merging is
		/// performed. If on, a locator will be used, and points laying within
		/// the appropriate tolerance may be merged. If off, points are never
		/// merged. By default, merging is on.
		/// </summary>
		// Token: 0x060174E6 RID: 95462 RVA: 0x0020BC1C File Offset: 0x00209E1C
		public virtual int GetPointMerging()
		{
			return vtkCleanPolyData.vtkCleanPolyData_GetPointMerging_20(base.GetCppThis());
		}

		// Token: 0x060174E7 RID: 95463
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCleanPolyData_GetTolerance_21(HandleRef pThis);

		/// <summary>
		/// Specify tolerance in terms of fraction of bounding box length.
		/// Default is 0.0.
		/// </summary>
		// Token: 0x060174E8 RID: 95464 RVA: 0x0020BC3C File Offset: 0x00209E3C
		public virtual double GetTolerance()
		{
			return vtkCleanPolyData.vtkCleanPolyData_GetTolerance_21(base.GetCppThis());
		}

		// Token: 0x060174E9 RID: 95465
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCleanPolyData_GetToleranceIsAbsolute_22(HandleRef pThis);

		/// <summary>
		/// By default ToleranceIsAbsolute is false and Tolerance is
		/// a fraction of Bounding box diagonal, if true, AbsoluteTolerance is
		/// used when adding points to locator (merging)
		/// </summary>
		// Token: 0x060174EA RID: 95466 RVA: 0x0020BC5C File Offset: 0x00209E5C
		public virtual int GetToleranceIsAbsolute()
		{
			return vtkCleanPolyData.vtkCleanPolyData_GetToleranceIsAbsolute_22(base.GetCppThis());
		}

		// Token: 0x060174EB RID: 95467
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCleanPolyData_GetToleranceMaxValue_23(HandleRef pThis);

		/// <summary>
		/// Specify tolerance in terms of fraction of bounding box length.
		/// Default is 0.0.
		/// </summary>
		// Token: 0x060174EC RID: 95468 RVA: 0x0020BC7C File Offset: 0x00209E7C
		public virtual double GetToleranceMaxValue()
		{
			return vtkCleanPolyData.vtkCleanPolyData_GetToleranceMaxValue_23(base.GetCppThis());
		}

		// Token: 0x060174ED RID: 95469
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCleanPolyData_GetToleranceMinValue_24(HandleRef pThis);

		/// <summary>
		/// Specify tolerance in terms of fraction of bounding box length.
		/// Default is 0.0.
		/// </summary>
		// Token: 0x060174EE RID: 95470 RVA: 0x0020BC9C File Offset: 0x00209E9C
		public virtual double GetToleranceMinValue()
		{
			return vtkCleanPolyData.vtkCleanPolyData_GetToleranceMinValue_24(base.GetCppThis());
		}

		// Token: 0x060174EF RID: 95471
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCleanPolyData_IsA_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060174F0 RID: 95472 RVA: 0x0020BCBC File Offset: 0x00209EBC
		public override int IsA(string type)
		{
			return vtkCleanPolyData.vtkCleanPolyData_IsA_25(base.GetCppThis(), type);
		}

		// Token: 0x060174F1 RID: 95473
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCleanPolyData_IsTypeOf_26([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060174F2 RID: 95474 RVA: 0x0020BCDC File Offset: 0x00209EDC
		public new static int IsTypeOf(string type)
		{
			return vtkCleanPolyData.vtkCleanPolyData_IsTypeOf_26(type);
		}

		// Token: 0x060174F3 RID: 95475
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCleanPolyData_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060174F4 RID: 95476 RVA: 0x0020BCF8 File Offset: 0x00209EF8
		public new vtkCleanPolyData NewInstance()
		{
			vtkCleanPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCleanPolyData.vtkCleanPolyData_NewInstance_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCleanPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060174F5 RID: 95477
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanPolyData_OperateOnBounds_29(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		/// <summary>
		/// Perform operation on bounds
		/// </summary>
		// Token: 0x060174F6 RID: 95478 RVA: 0x0020BD52 File Offset: 0x00209F52
		public virtual void OperateOnBounds(IntPtr arg0, IntPtr arg1)
		{
			vtkCleanPolyData.vtkCleanPolyData_OperateOnBounds_29(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x060174F7 RID: 95479
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanPolyData_OperateOnPoint_30(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		/// <summary>
		/// Perform operation on a point
		/// </summary>
		// Token: 0x060174F8 RID: 95480 RVA: 0x0020BD63 File Offset: 0x00209F63
		public virtual void OperateOnPoint(IntPtr arg0, IntPtr arg1)
		{
			vtkCleanPolyData.vtkCleanPolyData_OperateOnPoint_30(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x060174F9 RID: 95481
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanPolyData_PieceInvariantOff_31(HandleRef pThis);

		/// <summary>
		/// Perform operation on bounds
		/// </summary>
		// Token: 0x060174FA RID: 95482 RVA: 0x0020BD74 File Offset: 0x00209F74
		public virtual void PieceInvariantOff()
		{
			vtkCleanPolyData.vtkCleanPolyData_PieceInvariantOff_31(base.GetCppThis());
		}

		// Token: 0x060174FB RID: 95483
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanPolyData_PieceInvariantOn_32(HandleRef pThis);

		/// <summary>
		/// Perform operation on bounds
		/// </summary>
		// Token: 0x060174FC RID: 95484 RVA: 0x0020BD83 File Offset: 0x00209F83
		public virtual void PieceInvariantOn()
		{
			vtkCleanPolyData.vtkCleanPolyData_PieceInvariantOn_32(base.GetCppThis());
		}

		// Token: 0x060174FD RID: 95485
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanPolyData_PointMergingOff_33(HandleRef pThis);

		/// <summary>
		/// Set/Get a boolean value that controls whether point merging is
		/// performed. If on, a locator will be used, and points laying within
		/// the appropriate tolerance may be merged. If off, points are never
		/// merged. By default, merging is on.
		/// </summary>
		// Token: 0x060174FE RID: 95486 RVA: 0x0020BD92 File Offset: 0x00209F92
		public virtual void PointMergingOff()
		{
			vtkCleanPolyData.vtkCleanPolyData_PointMergingOff_33(base.GetCppThis());
		}

		// Token: 0x060174FF RID: 95487
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanPolyData_PointMergingOn_34(HandleRef pThis);

		/// <summary>
		/// Set/Get a boolean value that controls whether point merging is
		/// performed. If on, a locator will be used, and points laying within
		/// the appropriate tolerance may be merged. If off, points are never
		/// merged. By default, merging is on.
		/// </summary>
		// Token: 0x06017500 RID: 95488 RVA: 0x0020BDA1 File Offset: 0x00209FA1
		public virtual void PointMergingOn()
		{
			vtkCleanPolyData.vtkCleanPolyData_PointMergingOn_34(base.GetCppThis());
		}

		// Token: 0x06017501 RID: 95489
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanPolyData_ReleaseLocator_35(HandleRef pThis);

		/// <summary>
		/// Release locator
		/// </summary>
		// Token: 0x06017502 RID: 95490 RVA: 0x0020BDB0 File Offset: 0x00209FB0
		public void ReleaseLocator()
		{
			vtkCleanPolyData.vtkCleanPolyData_ReleaseLocator_35(base.GetCppThis());
		}

		// Token: 0x06017503 RID: 95491
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCleanPolyData_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017504 RID: 95492 RVA: 0x0020BDC0 File Offset: 0x00209FC0
		public new static vtkCleanPolyData SafeDownCast(vtkObjectBase o)
		{
			vtkCleanPolyData vtkCleanPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCleanPolyData.vtkCleanPolyData_SafeDownCast_36((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCleanPolyData = (vtkCleanPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCleanPolyData.Register(null);
				}
			}
			return vtkCleanPolyData;
		}

		// Token: 0x06017505 RID: 95493
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanPolyData_SetAbsoluteTolerance_37(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify tolerance in absolute terms. Default is 1.0.
		/// </summary>
		// Token: 0x06017506 RID: 95494 RVA: 0x0020BE3F File Offset: 0x0020A03F
		public virtual void SetAbsoluteTolerance(double _arg)
		{
			vtkCleanPolyData.vtkCleanPolyData_SetAbsoluteTolerance_37(base.GetCppThis(), _arg);
		}

		// Token: 0x06017507 RID: 95495
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanPolyData_SetConvertLinesToPoints_38(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off conversion of degenerate lines to points. Default is On.
		/// </summary>
		// Token: 0x06017508 RID: 95496 RVA: 0x0020BE4F File Offset: 0x0020A04F
		public virtual void SetConvertLinesToPoints(int _arg)
		{
			vtkCleanPolyData.vtkCleanPolyData_SetConvertLinesToPoints_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06017509 RID: 95497
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanPolyData_SetConvertPolysToLines_39(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off conversion of degenerate polys to lines. Default is On.
		/// </summary>
		// Token: 0x0601750A RID: 95498 RVA: 0x0020BE5F File Offset: 0x0020A05F
		public virtual void SetConvertPolysToLines(int _arg)
		{
			vtkCleanPolyData.vtkCleanPolyData_SetConvertPolysToLines_39(base.GetCppThis(), _arg);
		}

		// Token: 0x0601750B RID: 95499
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanPolyData_SetConvertStripsToPolys_40(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off conversion of degenerate strips to polys. Default is On.
		/// </summary>
		// Token: 0x0601750C RID: 95500 RVA: 0x0020BE6F File Offset: 0x0020A06F
		public virtual void SetConvertStripsToPolys(int _arg)
		{
			vtkCleanPolyData.vtkCleanPolyData_SetConvertStripsToPolys_40(base.GetCppThis(), _arg);
		}

		// Token: 0x0601750D RID: 95501
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanPolyData_SetLocator_41(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Set/Get a spatial locator for speeding the search process. By
		/// default an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x0601750E RID: 95502 RVA: 0x0020BE80 File Offset: 0x0020A080
		public virtual void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkCleanPolyData.vtkCleanPolyData_SetLocator_41(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0601750F RID: 95503
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanPolyData_SetOutputPointsPrecision_42(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06017510 RID: 95504 RVA: 0x0020BEAF File Offset: 0x0020A0AF
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkCleanPolyData.vtkCleanPolyData_SetOutputPointsPrecision_42(base.GetCppThis(), _arg);
		}

		// Token: 0x06017511 RID: 95505
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanPolyData_SetPieceInvariant_43(HandleRef pThis, int _arg);

		/// <summary>
		/// Perform operation on bounds
		/// </summary>
		// Token: 0x06017512 RID: 95506 RVA: 0x0020BEBF File Offset: 0x0020A0BF
		public virtual void SetPieceInvariant(int _arg)
		{
			vtkCleanPolyData.vtkCleanPolyData_SetPieceInvariant_43(base.GetCppThis(), _arg);
		}

		// Token: 0x06017513 RID: 95507
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanPolyData_SetPointMerging_44(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get a boolean value that controls whether point merging is
		/// performed. If on, a locator will be used, and points laying within
		/// the appropriate tolerance may be merged. If off, points are never
		/// merged. By default, merging is on.
		/// </summary>
		// Token: 0x06017514 RID: 95508 RVA: 0x0020BECF File Offset: 0x0020A0CF
		public virtual void SetPointMerging(int _arg)
		{
			vtkCleanPolyData.vtkCleanPolyData_SetPointMerging_44(base.GetCppThis(), _arg);
		}

		// Token: 0x06017515 RID: 95509
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanPolyData_SetTolerance_45(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify tolerance in terms of fraction of bounding box length.
		/// Default is 0.0.
		/// </summary>
		// Token: 0x06017516 RID: 95510 RVA: 0x0020BEDF File Offset: 0x0020A0DF
		public virtual void SetTolerance(double _arg)
		{
			vtkCleanPolyData.vtkCleanPolyData_SetTolerance_45(base.GetCppThis(), _arg);
		}

		// Token: 0x06017517 RID: 95511
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanPolyData_SetToleranceIsAbsolute_46(HandleRef pThis, int _arg);

		/// <summary>
		/// By default ToleranceIsAbsolute is false and Tolerance is
		/// a fraction of Bounding box diagonal, if true, AbsoluteTolerance is
		/// used when adding points to locator (merging)
		/// </summary>
		// Token: 0x06017518 RID: 95512 RVA: 0x0020BEEF File Offset: 0x0020A0EF
		public virtual void SetToleranceIsAbsolute(int _arg)
		{
			vtkCleanPolyData.vtkCleanPolyData_SetToleranceIsAbsolute_46(base.GetCppThis(), _arg);
		}

		// Token: 0x06017519 RID: 95513
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanPolyData_ToleranceIsAbsoluteOff_47(HandleRef pThis);

		/// <summary>
		/// By default ToleranceIsAbsolute is false and Tolerance is
		/// a fraction of Bounding box diagonal, if true, AbsoluteTolerance is
		/// used when adding points to locator (merging)
		/// </summary>
		// Token: 0x0601751A RID: 95514 RVA: 0x0020BEFF File Offset: 0x0020A0FF
		public virtual void ToleranceIsAbsoluteOff()
		{
			vtkCleanPolyData.vtkCleanPolyData_ToleranceIsAbsoluteOff_47(base.GetCppThis());
		}

		// Token: 0x0601751B RID: 95515
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCleanPolyData_ToleranceIsAbsoluteOn_48(HandleRef pThis);

		/// <summary>
		/// By default ToleranceIsAbsolute is false and Tolerance is
		/// a fraction of Bounding box diagonal, if true, AbsoluteTolerance is
		/// used when adding points to locator (merging)
		/// </summary>
		// Token: 0x0601751C RID: 95516 RVA: 0x0020BF0E File Offset: 0x0020A10E
		public virtual void ToleranceIsAbsoluteOn()
		{
			vtkCleanPolyData.vtkCleanPolyData_ToleranceIsAbsoluteOn_48(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A15 RID: 6677
		public new const string MRFullTypeName = "Kitware.VTK.vtkCleanPolyData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A16 RID: 6678
		public new static readonly string MRClassNameKey = "class vtkCleanPolyData";
	}
}
