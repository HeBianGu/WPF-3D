using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStaticCleanPolyData
	/// </summary>
	/// <remarks>
	///    merge duplicate points, and/or remove unused points and/or remove degenerate cells
	///
	/// vtkStaticCleanPolyData is a filter that takes polygonal data as input and
	/// generates polygonal data as output. vtkStaticCleanPolyData will merge
	/// duplicate points (within specified tolerance), and if enabled, transform
	/// degenerate cells into appropriate forms (for example, a triangle is
	/// converted into a line if two points of triangle are merged).
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
	/// Internally this class uses vtkStaticPointLocator, which is a threaded, and
	/// much faster locator (especially for large data) than the incremental
	/// locators that vtkCleanPolyData uses. Note because of these and other
	/// differences, the output of this filter may be different than
	/// vtkCleanPolyData.
	///
	/// @warning
	/// Merging points can alter topology, including introducing non-manifold
	/// forms. The tolerance should be chosen carefully to avoid these problems.
	/// Large tolerances (of size &gt; locator bin width) may generate poor results.
	///
	/// @warning
	/// Unlike vtkCleanPolyData, point merging is always performed (i.e., there
	/// is no PointMergingOff()).
	///
	/// @warning
	/// Unlike vtkCleanPolyData, conversion from one cell type to another is
	/// disabled/off. This produces more predictable behavior in many applications.
	///
	/// @warning
	/// The vtkStaticCleanPolyData filter is similar in operation to
	/// vtkCleanPolyData. However, vtkStaticCleanPolyData is non-incremental and
	/// uses a much faster (especially for larger datasets) threading approach and
	/// when merging points with a non-zero tolerance. However because of the
	/// difference in the traversal order in the point merging process, the output
	/// of the filters may be different.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCleanPolyData vtkStaticCleanUnstructuredGrid
	/// </seealso>
	// Token: 0x0200099F RID: 2463
	public class vtkStaticCleanPolyData : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019BA5 RID: 105381 RVA: 0x0023C18F File Offset: 0x0023A38F
		static vtkStaticCleanPolyData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStaticCleanPolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStaticCleanPolyData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019BA6 RID: 105382 RVA: 0x0023C1B7 File Offset: 0x0023A3B7
		public vtkStaticCleanPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019BA7 RID: 105383
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStaticCleanPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to instantiate, print, and provide type information.
		/// </summary>
		// Token: 0x06019BA8 RID: 105384 RVA: 0x0023C1C8 File Offset: 0x0023A3C8
		public new static vtkStaticCleanPolyData New()
		{
			vtkStaticCleanPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStaticCleanPolyData.vtkStaticCleanPolyData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStaticCleanPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods to instantiate, print, and provide type information.
		/// </summary>
		// Token: 0x06019BA9 RID: 105385 RVA: 0x0023C21C File Offset: 0x0023A41C
		public vtkStaticCleanPolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStaticCleanPolyData.vtkStaticCleanPolyData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019BAA RID: 105386 RVA: 0x0023C260 File Offset: 0x0023A460
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019BAB RID: 105387
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanPolyData_AveragePointDataOff_01(HandleRef pThis);

		/// <summary>
		/// Indicate whether point coordinates and point data of merged points are
		/// averaged. By default, the point coordinates and attribute data are not
		/// averaged, and the point coordinate and data of the single, remaining
		/// merged point is retained. Otherwise, the data coordinates and attribute
		/// values of all merged points are averaged. By default this feature is
		/// disabled.
		/// </summary>
		// Token: 0x06019BAC RID: 105388 RVA: 0x0023C26B File Offset: 0x0023A46B
		public virtual void AveragePointDataOff()
		{
			vtkStaticCleanPolyData.vtkStaticCleanPolyData_AveragePointDataOff_01(base.GetCppThis());
		}

		// Token: 0x06019BAD RID: 105389
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanPolyData_AveragePointDataOn_02(HandleRef pThis);

		/// <summary>
		/// Indicate whether point coordinates and point data of merged points are
		/// averaged. By default, the point coordinates and attribute data are not
		/// averaged, and the point coordinate and data of the single, remaining
		/// merged point is retained. Otherwise, the data coordinates and attribute
		/// values of all merged points are averaged. By default this feature is
		/// disabled.
		/// </summary>
		// Token: 0x06019BAE RID: 105390 RVA: 0x0023C27A File Offset: 0x0023A47A
		public virtual void AveragePointDataOn()
		{
			vtkStaticCleanPolyData.vtkStaticCleanPolyData_AveragePointDataOn_02(base.GetCppThis());
		}

		// Token: 0x06019BAF RID: 105391
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanPolyData_ConvertLinesToPointsOff_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off conversion of degenerate lines to points. Default is Off.
		/// </summary>
		// Token: 0x06019BB0 RID: 105392 RVA: 0x0023C289 File Offset: 0x0023A489
		public virtual void ConvertLinesToPointsOff()
		{
			vtkStaticCleanPolyData.vtkStaticCleanPolyData_ConvertLinesToPointsOff_03(base.GetCppThis());
		}

		// Token: 0x06019BB1 RID: 105393
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanPolyData_ConvertLinesToPointsOn_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off conversion of degenerate lines to points. Default is Off.
		/// </summary>
		// Token: 0x06019BB2 RID: 105394 RVA: 0x0023C298 File Offset: 0x0023A498
		public virtual void ConvertLinesToPointsOn()
		{
			vtkStaticCleanPolyData.vtkStaticCleanPolyData_ConvertLinesToPointsOn_04(base.GetCppThis());
		}

		// Token: 0x06019BB3 RID: 105395
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanPolyData_ConvertPolysToLinesOff_05(HandleRef pThis);

		/// <summary>
		/// Turn on/off conversion of degenerate polys to lines. Default is Off.
		/// </summary>
		// Token: 0x06019BB4 RID: 105396 RVA: 0x0023C2A7 File Offset: 0x0023A4A7
		public virtual void ConvertPolysToLinesOff()
		{
			vtkStaticCleanPolyData.vtkStaticCleanPolyData_ConvertPolysToLinesOff_05(base.GetCppThis());
		}

		// Token: 0x06019BB5 RID: 105397
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanPolyData_ConvertPolysToLinesOn_06(HandleRef pThis);

		/// <summary>
		/// Turn on/off conversion of degenerate polys to lines. Default is Off.
		/// </summary>
		// Token: 0x06019BB6 RID: 105398 RVA: 0x0023C2B6 File Offset: 0x0023A4B6
		public virtual void ConvertPolysToLinesOn()
		{
			vtkStaticCleanPolyData.vtkStaticCleanPolyData_ConvertPolysToLinesOn_06(base.GetCppThis());
		}

		// Token: 0x06019BB7 RID: 105399
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanPolyData_ConvertStripsToPolysOff_07(HandleRef pThis);

		/// <summary>
		/// Turn on/off conversion of degenerate strips to polys. Default is Off.
		/// </summary>
		// Token: 0x06019BB8 RID: 105400 RVA: 0x0023C2C5 File Offset: 0x0023A4C5
		public virtual void ConvertStripsToPolysOff()
		{
			vtkStaticCleanPolyData.vtkStaticCleanPolyData_ConvertStripsToPolysOff_07(base.GetCppThis());
		}

		// Token: 0x06019BB9 RID: 105401
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanPolyData_ConvertStripsToPolysOn_08(HandleRef pThis);

		/// <summary>
		/// Turn on/off conversion of degenerate strips to polys. Default is Off.
		/// </summary>
		// Token: 0x06019BBA RID: 105402 RVA: 0x0023C2D4 File Offset: 0x0023A4D4
		public virtual void ConvertStripsToPolysOn()
		{
			vtkStaticCleanPolyData.vtkStaticCleanPolyData_ConvertStripsToPolysOn_08(base.GetCppThis());
		}

		// Token: 0x06019BBB RID: 105403
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStaticCleanPolyData_GetAbsoluteTolerance_09(HandleRef pThis);

		/// <summary>
		/// Specify tolerance in absolute terms. Default is 1.0.
		/// </summary>
		// Token: 0x06019BBC RID: 105404 RVA: 0x0023C2E4 File Offset: 0x0023A4E4
		public virtual double GetAbsoluteTolerance()
		{
			return vtkStaticCleanPolyData.vtkStaticCleanPolyData_GetAbsoluteTolerance_09(base.GetCppThis());
		}

		// Token: 0x06019BBD RID: 105405
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStaticCleanPolyData_GetAbsoluteToleranceMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Specify tolerance in absolute terms. Default is 1.0.
		/// </summary>
		// Token: 0x06019BBE RID: 105406 RVA: 0x0023C304 File Offset: 0x0023A504
		public virtual double GetAbsoluteToleranceMaxValue()
		{
			return vtkStaticCleanPolyData.vtkStaticCleanPolyData_GetAbsoluteToleranceMaxValue_10(base.GetCppThis());
		}

		// Token: 0x06019BBF RID: 105407
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStaticCleanPolyData_GetAbsoluteToleranceMinValue_11(HandleRef pThis);

		/// <summary>
		/// Specify tolerance in absolute terms. Default is 1.0.
		/// </summary>
		// Token: 0x06019BC0 RID: 105408 RVA: 0x0023C324 File Offset: 0x0023A524
		public virtual double GetAbsoluteToleranceMinValue()
		{
			return vtkStaticCleanPolyData.vtkStaticCleanPolyData_GetAbsoluteToleranceMinValue_11(base.GetCppThis());
		}

		// Token: 0x06019BC1 RID: 105409
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStaticCleanPolyData_GetAveragePointData_12(HandleRef pThis);

		/// <summary>
		/// Indicate whether point coordinates and point data of merged points are
		/// averaged. By default, the point coordinates and attribute data are not
		/// averaged, and the point coordinate and data of the single, remaining
		/// merged point is retained. Otherwise, the data coordinates and attribute
		/// values of all merged points are averaged. By default this feature is
		/// disabled.
		/// </summary>
		// Token: 0x06019BC2 RID: 105410 RVA: 0x0023C344 File Offset: 0x0023A544
		public virtual bool GetAveragePointData()
		{
			return vtkStaticCleanPolyData.vtkStaticCleanPolyData_GetAveragePointData_12(base.GetCppThis()) != 0;
		}

		// Token: 0x06019BC3 RID: 105411
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStaticCleanPolyData_GetConvertLinesToPoints_13(HandleRef pThis);

		/// <summary>
		/// Turn on/off conversion of degenerate lines to points. Default is Off.
		/// </summary>
		// Token: 0x06019BC4 RID: 105412 RVA: 0x0023C36C File Offset: 0x0023A56C
		public virtual bool GetConvertLinesToPoints()
		{
			return vtkStaticCleanPolyData.vtkStaticCleanPolyData_GetConvertLinesToPoints_13(base.GetCppThis()) != 0;
		}

		// Token: 0x06019BC5 RID: 105413
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStaticCleanPolyData_GetConvertPolysToLines_14(HandleRef pThis);

		/// <summary>
		/// Turn on/off conversion of degenerate polys to lines. Default is Off.
		/// </summary>
		// Token: 0x06019BC6 RID: 105414 RVA: 0x0023C394 File Offset: 0x0023A594
		public virtual bool GetConvertPolysToLines()
		{
			return vtkStaticCleanPolyData.vtkStaticCleanPolyData_GetConvertPolysToLines_14(base.GetCppThis()) != 0;
		}

		// Token: 0x06019BC7 RID: 105415
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStaticCleanPolyData_GetConvertStripsToPolys_15(HandleRef pThis);

		/// <summary>
		/// Turn on/off conversion of degenerate strips to polys. Default is Off.
		/// </summary>
		// Token: 0x06019BC8 RID: 105416 RVA: 0x0023C3BC File Offset: 0x0023A5BC
		public virtual bool GetConvertStripsToPolys()
		{
			return vtkStaticCleanPolyData.vtkStaticCleanPolyData_GetConvertStripsToPolys_15(base.GetCppThis()) != 0;
		}

		// Token: 0x06019BC9 RID: 105417
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStaticCleanPolyData_GetLocator_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve the internal locator to manually configure it, for example
		/// specifying the number of points per bucket, or controlling the traversal
		/// order. This method is generally used for debugging or testing purposes.
		/// </summary>
		// Token: 0x06019BCA RID: 105418 RVA: 0x0023C3E4 File Offset: 0x0023A5E4
		public virtual vtkStaticPointLocator GetLocator()
		{
			vtkStaticPointLocator vtkStaticPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStaticCleanPolyData.vtkStaticCleanPolyData_GetLocator_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStaticPointLocator = (vtkStaticPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStaticPointLocator.Register(null);
				}
			}
			return vtkStaticPointLocator;
		}

		// Token: 0x06019BCB RID: 105419
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkStaticCleanPolyData_GetMTime_17(HandleRef pThis);

		/// <summary>
		/// Get the MTime of this object also considering the locator.
		/// </summary>
		// Token: 0x06019BCC RID: 105420 RVA: 0x0023C454 File Offset: 0x0023A654
		public override ulong GetMTime()
		{
			return vtkStaticCleanPolyData.vtkStaticCleanPolyData_GetMTime_17(base.GetCppThis());
		}

		// Token: 0x06019BCD RID: 105421
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStaticCleanPolyData_GetMergingArray_18(HandleRef pThis);

		/// <summary>
		/// Specify the name of a point data array associated with the point merging
		/// process. If a data array is specified, and exists in the input point
		/// data, then point merging will switch into a mode where merged points
		/// must be both geometrically coincident and have matching point data
		/// (i.e., an exact match of position and data - tolerances have no
		/// effect). Note that the number of tuples in the merging data array must
		/// be equal to the number of points in the input. By default, no data array
		/// is associated with the input points (i.e., the name of the data array is
		/// empty).
		/// </summary>
		// Token: 0x06019BCE RID: 105422 RVA: 0x0023C474 File Offset: 0x0023A674
		public virtual string GetMergingArray()
		{
			string s = Marshal.PtrToStringAnsi(vtkStaticCleanPolyData.vtkStaticCleanPolyData_GetMergingArray_18(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06019BCF RID: 105423
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStaticCleanPolyData_GetNumberOfGenerationsFromBase_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, print, and provide type information.
		/// </summary>
		// Token: 0x06019BD0 RID: 105424 RVA: 0x0023C4B0 File Offset: 0x0023A6B0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStaticCleanPolyData.vtkStaticCleanPolyData_GetNumberOfGenerationsFromBase_19(base.GetCppThis(), type);
		}

		// Token: 0x06019BD1 RID: 105425
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStaticCleanPolyData_GetNumberOfGenerationsFromBaseType_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, print, and provide type information.
		/// </summary>
		// Token: 0x06019BD2 RID: 105426 RVA: 0x0023C4D0 File Offset: 0x0023A6D0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStaticCleanPolyData.vtkStaticCleanPolyData_GetNumberOfGenerationsFromBaseType_20(type);
		}

		// Token: 0x06019BD3 RID: 105427
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStaticCleanPolyData_GetOutputPointsPrecision_21(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06019BD4 RID: 105428 RVA: 0x0023C4EC File Offset: 0x0023A6EC
		public virtual int GetOutputPointsPrecision()
		{
			return vtkStaticCleanPolyData.vtkStaticCleanPolyData_GetOutputPointsPrecision_21(base.GetCppThis());
		}

		// Token: 0x06019BD5 RID: 105429
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStaticCleanPolyData_GetPieceInvariant_22(HandleRef pThis);

		/// <summary>
		/// Retrieve the internal locator to manually configure it, for example
		/// specifying the number of points per bucket, or controlling the traversal
		/// order. This method is generally used for debugging or testing purposes.
		/// </summary>
		// Token: 0x06019BD6 RID: 105430 RVA: 0x0023C50C File Offset: 0x0023A70C
		public virtual bool GetPieceInvariant()
		{
			return vtkStaticCleanPolyData.vtkStaticCleanPolyData_GetPieceInvariant_22(base.GetCppThis()) != 0;
		}

		// Token: 0x06019BD7 RID: 105431
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStaticCleanPolyData_GetProduceMergeMap_23(HandleRef pThis);

		/// <summary>
		/// Indicate whether a merge map should be produced on output. The merge
		/// map, if requested, maps each input point to its output point id, or
		/// provides a value of -1 if the input point is not used in the output.
		/// The merge map is associated with the filter's output field data and
		/// is named "PointMergeMap". By default, ProduceMergeMap is disabled.
		/// </summary>
		// Token: 0x06019BD8 RID: 105432 RVA: 0x0023C534 File Offset: 0x0023A734
		public virtual bool GetProduceMergeMap()
		{
			return vtkStaticCleanPolyData.vtkStaticCleanPolyData_GetProduceMergeMap_23(base.GetCppThis()) != 0;
		}

		// Token: 0x06019BD9 RID: 105433
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStaticCleanPolyData_GetRemoveUnusedPoints_24(HandleRef pThis);

		/// <summary>
		/// Indicate whether points unused by any cell are removed from the output.
		/// By default this point removal is on. Note that when this is off, the
		/// filter can successfully process datasets with no cells (and just
		/// points). If on, and there are no cells, than the output will be empty.
		/// </summary>
		// Token: 0x06019BDA RID: 105434 RVA: 0x0023C55C File Offset: 0x0023A75C
		public virtual bool GetRemoveUnusedPoints()
		{
			return vtkStaticCleanPolyData.vtkStaticCleanPolyData_GetRemoveUnusedPoints_24(base.GetCppThis()) != 0;
		}

		// Token: 0x06019BDB RID: 105435
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStaticCleanPolyData_GetTolerance_25(HandleRef pThis);

		/// <summary>
		/// Specify tolerance in terms of fraction of bounding box length.  Default
		/// is 0.0. This takes effect only if ToleranceIsAbsolute is false.
		/// </summary>
		// Token: 0x06019BDC RID: 105436 RVA: 0x0023C584 File Offset: 0x0023A784
		public virtual double GetTolerance()
		{
			return vtkStaticCleanPolyData.vtkStaticCleanPolyData_GetTolerance_25(base.GetCppThis());
		}

		// Token: 0x06019BDD RID: 105437
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStaticCleanPolyData_GetToleranceIsAbsolute_26(HandleRef pThis);

		/// <summary>
		/// By default ToleranceIsAbsolute is false and Tolerance is
		/// a fraction of Bounding box diagonal, if true, AbsoluteTolerance is
		/// used when adding points to locator (merging)
		/// </summary>
		// Token: 0x06019BDE RID: 105438 RVA: 0x0023C5A4 File Offset: 0x0023A7A4
		public virtual bool GetToleranceIsAbsolute()
		{
			return vtkStaticCleanPolyData.vtkStaticCleanPolyData_GetToleranceIsAbsolute_26(base.GetCppThis()) != 0;
		}

		// Token: 0x06019BDF RID: 105439
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStaticCleanPolyData_GetToleranceMaxValue_27(HandleRef pThis);

		/// <summary>
		/// Specify tolerance in terms of fraction of bounding box length.  Default
		/// is 0.0. This takes effect only if ToleranceIsAbsolute is false.
		/// </summary>
		// Token: 0x06019BE0 RID: 105440 RVA: 0x0023C5CC File Offset: 0x0023A7CC
		public virtual double GetToleranceMaxValue()
		{
			return vtkStaticCleanPolyData.vtkStaticCleanPolyData_GetToleranceMaxValue_27(base.GetCppThis());
		}

		// Token: 0x06019BE1 RID: 105441
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkStaticCleanPolyData_GetToleranceMinValue_28(HandleRef pThis);

		/// <summary>
		/// Specify tolerance in terms of fraction of bounding box length.  Default
		/// is 0.0. This takes effect only if ToleranceIsAbsolute is false.
		/// </summary>
		// Token: 0x06019BE2 RID: 105442 RVA: 0x0023C5EC File Offset: 0x0023A7EC
		public virtual double GetToleranceMinValue()
		{
			return vtkStaticCleanPolyData.vtkStaticCleanPolyData_GetToleranceMinValue_28(base.GetCppThis());
		}

		// Token: 0x06019BE3 RID: 105443
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStaticCleanPolyData_IsA_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, print, and provide type information.
		/// </summary>
		// Token: 0x06019BE4 RID: 105444 RVA: 0x0023C60C File Offset: 0x0023A80C
		public override int IsA(string type)
		{
			return vtkStaticCleanPolyData.vtkStaticCleanPolyData_IsA_29(base.GetCppThis(), type);
		}

		// Token: 0x06019BE5 RID: 105445
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStaticCleanPolyData_IsTypeOf_30([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods to instantiate, print, and provide type information.
		/// </summary>
		// Token: 0x06019BE6 RID: 105446 RVA: 0x0023C62C File Offset: 0x0023A82C
		public new static int IsTypeOf(string type)
		{
			return vtkStaticCleanPolyData.vtkStaticCleanPolyData_IsTypeOf_30(type);
		}

		// Token: 0x06019BE7 RID: 105447
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStaticCleanPolyData_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to instantiate, print, and provide type information.
		/// </summary>
		// Token: 0x06019BE8 RID: 105448 RVA: 0x0023C648 File Offset: 0x0023A848
		public new vtkStaticCleanPolyData NewInstance()
		{
			vtkStaticCleanPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStaticCleanPolyData.vtkStaticCleanPolyData_NewInstance_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStaticCleanPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019BE9 RID: 105449
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanPolyData_PieceInvariantOff_33(HandleRef pThis);

		/// <summary>
		/// Retrieve the internal locator to manually configure it, for example
		/// specifying the number of points per bucket, or controlling the traversal
		/// order. This method is generally used for debugging or testing purposes.
		/// </summary>
		// Token: 0x06019BEA RID: 105450 RVA: 0x0023C6A2 File Offset: 0x0023A8A2
		public virtual void PieceInvariantOff()
		{
			vtkStaticCleanPolyData.vtkStaticCleanPolyData_PieceInvariantOff_33(base.GetCppThis());
		}

		// Token: 0x06019BEB RID: 105451
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanPolyData_PieceInvariantOn_34(HandleRef pThis);

		/// <summary>
		/// Retrieve the internal locator to manually configure it, for example
		/// specifying the number of points per bucket, or controlling the traversal
		/// order. This method is generally used for debugging or testing purposes.
		/// </summary>
		// Token: 0x06019BEC RID: 105452 RVA: 0x0023C6B1 File Offset: 0x0023A8B1
		public virtual void PieceInvariantOn()
		{
			vtkStaticCleanPolyData.vtkStaticCleanPolyData_PieceInvariantOn_34(base.GetCppThis());
		}

		// Token: 0x06019BED RID: 105453
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanPolyData_ProduceMergeMapOff_35(HandleRef pThis);

		/// <summary>
		/// Indicate whether a merge map should be produced on output. The merge
		/// map, if requested, maps each input point to its output point id, or
		/// provides a value of -1 if the input point is not used in the output.
		/// The merge map is associated with the filter's output field data and
		/// is named "PointMergeMap". By default, ProduceMergeMap is disabled.
		/// </summary>
		// Token: 0x06019BEE RID: 105454 RVA: 0x0023C6C0 File Offset: 0x0023A8C0
		public virtual void ProduceMergeMapOff()
		{
			vtkStaticCleanPolyData.vtkStaticCleanPolyData_ProduceMergeMapOff_35(base.GetCppThis());
		}

		// Token: 0x06019BEF RID: 105455
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanPolyData_ProduceMergeMapOn_36(HandleRef pThis);

		/// <summary>
		/// Indicate whether a merge map should be produced on output. The merge
		/// map, if requested, maps each input point to its output point id, or
		/// provides a value of -1 if the input point is not used in the output.
		/// The merge map is associated with the filter's output field data and
		/// is named "PointMergeMap". By default, ProduceMergeMap is disabled.
		/// </summary>
		// Token: 0x06019BF0 RID: 105456 RVA: 0x0023C6CF File Offset: 0x0023A8CF
		public virtual void ProduceMergeMapOn()
		{
			vtkStaticCleanPolyData.vtkStaticCleanPolyData_ProduceMergeMapOn_36(base.GetCppThis());
		}

		// Token: 0x06019BF1 RID: 105457
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanPolyData_RemoveUnusedPointsOff_37(HandleRef pThis);

		/// <summary>
		/// Indicate whether points unused by any cell are removed from the output.
		/// By default this point removal is on. Note that when this is off, the
		/// filter can successfully process datasets with no cells (and just
		/// points). If on, and there are no cells, than the output will be empty.
		/// </summary>
		// Token: 0x06019BF2 RID: 105458 RVA: 0x0023C6DE File Offset: 0x0023A8DE
		public virtual void RemoveUnusedPointsOff()
		{
			vtkStaticCleanPolyData.vtkStaticCleanPolyData_RemoveUnusedPointsOff_37(base.GetCppThis());
		}

		// Token: 0x06019BF3 RID: 105459
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanPolyData_RemoveUnusedPointsOn_38(HandleRef pThis);

		/// <summary>
		/// Indicate whether points unused by any cell are removed from the output.
		/// By default this point removal is on. Note that when this is off, the
		/// filter can successfully process datasets with no cells (and just
		/// points). If on, and there are no cells, than the output will be empty.
		/// </summary>
		// Token: 0x06019BF4 RID: 105460 RVA: 0x0023C6ED File Offset: 0x0023A8ED
		public virtual void RemoveUnusedPointsOn()
		{
			vtkStaticCleanPolyData.vtkStaticCleanPolyData_RemoveUnusedPointsOn_38(base.GetCppThis());
		}

		// Token: 0x06019BF5 RID: 105461
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStaticCleanPolyData_SafeDownCast_39(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods to instantiate, print, and provide type information.
		/// </summary>
		// Token: 0x06019BF6 RID: 105462 RVA: 0x0023C6FC File Offset: 0x0023A8FC
		public new static vtkStaticCleanPolyData SafeDownCast(vtkObjectBase o)
		{
			vtkStaticCleanPolyData vtkStaticCleanPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStaticCleanPolyData.vtkStaticCleanPolyData_SafeDownCast_39((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStaticCleanPolyData = (vtkStaticCleanPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStaticCleanPolyData.Register(null);
				}
			}
			return vtkStaticCleanPolyData;
		}

		// Token: 0x06019BF7 RID: 105463
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanPolyData_SetAbsoluteTolerance_40(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify tolerance in absolute terms. Default is 1.0.
		/// </summary>
		// Token: 0x06019BF8 RID: 105464 RVA: 0x0023C77B File Offset: 0x0023A97B
		public virtual void SetAbsoluteTolerance(double _arg)
		{
			vtkStaticCleanPolyData.vtkStaticCleanPolyData_SetAbsoluteTolerance_40(base.GetCppThis(), _arg);
		}

		// Token: 0x06019BF9 RID: 105465
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanPolyData_SetAveragePointData_41(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether point coordinates and point data of merged points are
		/// averaged. By default, the point coordinates and attribute data are not
		/// averaged, and the point coordinate and data of the single, remaining
		/// merged point is retained. Otherwise, the data coordinates and attribute
		/// values of all merged points are averaged. By default this feature is
		/// disabled.
		/// </summary>
		// Token: 0x06019BFA RID: 105466 RVA: 0x0023C78B File Offset: 0x0023A98B
		public virtual void SetAveragePointData(bool _arg)
		{
			vtkStaticCleanPolyData.vtkStaticCleanPolyData_SetAveragePointData_41(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019BFB RID: 105467
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanPolyData_SetConvertLinesToPoints_42(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off conversion of degenerate lines to points. Default is Off.
		/// </summary>
		// Token: 0x06019BFC RID: 105468 RVA: 0x0023C7A3 File Offset: 0x0023A9A3
		public virtual void SetConvertLinesToPoints(bool _arg)
		{
			vtkStaticCleanPolyData.vtkStaticCleanPolyData_SetConvertLinesToPoints_42(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019BFD RID: 105469
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanPolyData_SetConvertPolysToLines_43(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off conversion of degenerate polys to lines. Default is Off.
		/// </summary>
		// Token: 0x06019BFE RID: 105470 RVA: 0x0023C7BB File Offset: 0x0023A9BB
		public virtual void SetConvertPolysToLines(bool _arg)
		{
			vtkStaticCleanPolyData.vtkStaticCleanPolyData_SetConvertPolysToLines_43(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019BFF RID: 105471
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanPolyData_SetConvertStripsToPolys_44(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off conversion of degenerate strips to polys. Default is Off.
		/// </summary>
		// Token: 0x06019C00 RID: 105472 RVA: 0x0023C7D3 File Offset: 0x0023A9D3
		public virtual void SetConvertStripsToPolys(bool _arg)
		{
			vtkStaticCleanPolyData.vtkStaticCleanPolyData_SetConvertStripsToPolys_44(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019C01 RID: 105473
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanPolyData_SetMergingArray_45(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the name of a point data array associated with the point merging
		/// process. If a data array is specified, and exists in the input point
		/// data, then point merging will switch into a mode where merged points
		/// must be both geometrically coincident and have matching point data
		/// (i.e., an exact match of position and data - tolerances have no
		/// effect). Note that the number of tuples in the merging data array must
		/// be equal to the number of points in the input. By default, no data array
		/// is associated with the input points (i.e., the name of the data array is
		/// empty).
		/// </summary>
		// Token: 0x06019C02 RID: 105474 RVA: 0x0023C7EB File Offset: 0x0023A9EB
		public virtual void SetMergingArray(string _arg)
		{
			vtkStaticCleanPolyData.vtkStaticCleanPolyData_SetMergingArray_45(base.GetCppThis(), _arg);
		}

		// Token: 0x06019C03 RID: 105475
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanPolyData_SetOutputPointsPrecision_46(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06019C04 RID: 105476 RVA: 0x0023C7FB File Offset: 0x0023A9FB
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkStaticCleanPolyData.vtkStaticCleanPolyData_SetOutputPointsPrecision_46(base.GetCppThis(), _arg);
		}

		// Token: 0x06019C05 RID: 105477
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanPolyData_SetPieceInvariant_47(HandleRef pThis, byte _arg);

		/// <summary>
		/// Retrieve the internal locator to manually configure it, for example
		/// specifying the number of points per bucket, or controlling the traversal
		/// order. This method is generally used for debugging or testing purposes.
		/// </summary>
		// Token: 0x06019C06 RID: 105478 RVA: 0x0023C80B File Offset: 0x0023AA0B
		public virtual void SetPieceInvariant(bool _arg)
		{
			vtkStaticCleanPolyData.vtkStaticCleanPolyData_SetPieceInvariant_47(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019C07 RID: 105479
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanPolyData_SetProduceMergeMap_48(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether a merge map should be produced on output. The merge
		/// map, if requested, maps each input point to its output point id, or
		/// provides a value of -1 if the input point is not used in the output.
		/// The merge map is associated with the filter's output field data and
		/// is named "PointMergeMap". By default, ProduceMergeMap is disabled.
		/// </summary>
		// Token: 0x06019C08 RID: 105480 RVA: 0x0023C823 File Offset: 0x0023AA23
		public virtual void SetProduceMergeMap(bool _arg)
		{
			vtkStaticCleanPolyData.vtkStaticCleanPolyData_SetProduceMergeMap_48(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019C09 RID: 105481
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanPolyData_SetRemoveUnusedPoints_49(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate whether points unused by any cell are removed from the output.
		/// By default this point removal is on. Note that when this is off, the
		/// filter can successfully process datasets with no cells (and just
		/// points). If on, and there are no cells, than the output will be empty.
		/// </summary>
		// Token: 0x06019C0A RID: 105482 RVA: 0x0023C83B File Offset: 0x0023AA3B
		public virtual void SetRemoveUnusedPoints(bool _arg)
		{
			vtkStaticCleanPolyData.vtkStaticCleanPolyData_SetRemoveUnusedPoints_49(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019C0B RID: 105483
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanPolyData_SetTolerance_50(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify tolerance in terms of fraction of bounding box length.  Default
		/// is 0.0. This takes effect only if ToleranceIsAbsolute is false.
		/// </summary>
		// Token: 0x06019C0C RID: 105484 RVA: 0x0023C853 File Offset: 0x0023AA53
		public virtual void SetTolerance(double _arg)
		{
			vtkStaticCleanPolyData.vtkStaticCleanPolyData_SetTolerance_50(base.GetCppThis(), _arg);
		}

		// Token: 0x06019C0D RID: 105485
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanPolyData_SetToleranceIsAbsolute_51(HandleRef pThis, byte _arg);

		/// <summary>
		/// By default ToleranceIsAbsolute is false and Tolerance is
		/// a fraction of Bounding box diagonal, if true, AbsoluteTolerance is
		/// used when adding points to locator (merging)
		/// </summary>
		// Token: 0x06019C0E RID: 105486 RVA: 0x0023C863 File Offset: 0x0023AA63
		public virtual void SetToleranceIsAbsolute(bool _arg)
		{
			vtkStaticCleanPolyData.vtkStaticCleanPolyData_SetToleranceIsAbsolute_51(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06019C0F RID: 105487
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanPolyData_ToleranceIsAbsoluteOff_52(HandleRef pThis);

		/// <summary>
		/// By default ToleranceIsAbsolute is false and Tolerance is
		/// a fraction of Bounding box diagonal, if true, AbsoluteTolerance is
		/// used when adding points to locator (merging)
		/// </summary>
		// Token: 0x06019C10 RID: 105488 RVA: 0x0023C87B File Offset: 0x0023AA7B
		public virtual void ToleranceIsAbsoluteOff()
		{
			vtkStaticCleanPolyData.vtkStaticCleanPolyData_ToleranceIsAbsoluteOff_52(base.GetCppThis());
		}

		// Token: 0x06019C11 RID: 105489
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStaticCleanPolyData_ToleranceIsAbsoluteOn_53(HandleRef pThis);

		/// <summary>
		/// By default ToleranceIsAbsolute is false and Tolerance is
		/// a fraction of Bounding box diagonal, if true, AbsoluteTolerance is
		/// used when adding points to locator (merging)
		/// </summary>
		// Token: 0x06019C12 RID: 105490 RVA: 0x0023C88A File Offset: 0x0023AA8A
		public virtual void ToleranceIsAbsoluteOn()
		{
			vtkStaticCleanPolyData.vtkStaticCleanPolyData_ToleranceIsAbsoluteOn_53(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C03 RID: 7171
		public new const string MRFullTypeName = "Kitware.VTK.vtkStaticCleanPolyData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C04 RID: 7172
		public new static readonly string MRClassNameKey = "class vtkStaticCleanPolyData";
	}
}
