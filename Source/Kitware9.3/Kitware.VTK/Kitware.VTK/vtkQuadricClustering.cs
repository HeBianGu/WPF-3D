using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkQuadricClustering
	/// </summary>
	/// <remarks>
	///    reduce the number of triangles in a mesh
	///
	/// vtkQuadricClustering is a filter to reduce the number of triangles in a
	/// triangle mesh, forming a good approximation to the original geometry.  The
	/// input to vtkQuadricClustering is a vtkPolyData object, and all types of
	/// polygonal data are handled.
	///
	/// The algorithm used is the one described by Peter Lindstrom in his Siggraph
	/// 2000 paper, "Out-of-Core Simplification of Large Polygonal Models."  The
	/// general approach of the algorithm is to cluster vertices in a uniform
	/// binning of space, accumulating the quadric of each triangle (pushed out to
	/// the triangles vertices) within each bin, and then determining an optimal
	/// position for a single vertex in a bin by using the accumulated quadric. In
	/// more detail, the algorithm first gets the bounds of the input poly data.
	/// It then breaks this bounding volume into a user-specified number of
	/// spatial bins.  It then reads each triangle from the input and hashes its
	/// vertices into these bins.  (If this is the first time a bin has been
	/// visited, initialize its quadric to the 0 matrix.) The algorithm computes
	/// the error quadric for this triangle and adds it to the existing quadric of
	/// the bin in which each vertex is contained. Then, if 2 or more vertices of
	/// the triangle fall in the same bin, the triangle is discarded.  If the
	/// triangle is not discarded, it adds the triangle to the list of output
	/// triangles as a list of vertex identifiers.  (There is one vertex id per
	/// bin.)  After all the triangles have been read, the representative vertex
	/// for each bin is computed (an optimal location is found) using the quadric
	/// for that bin.  This determines the spatial location of the vertices of
	/// each of the triangles in the output.
	///
	/// To use this filter, specify the divisions defining the spatial subdivision
	/// in the x, y, and z directions. You must also specify an input vtkPolyData.
	/// Then choose to either 1) use the original points that minimize the quadric
	/// error to produce the output triangles or 2) compute an optimal position in
	/// each bin to produce the output triangles (recommended and default behavior).
	///
	/// This filter can take multiple inputs.  To do this, the user must explicitly
	/// call StartAppend, Append (once for each input), and EndAppend.  StartAppend
	/// sets up the data structure to hold the quadric matrices.  Append processes
	/// each triangle in the input poly data it was called on, hashes its vertices
	/// to the appropriate bins, determines whether to keep this triangle, and
	/// updates the appropriate quadric matrices.  EndAppend determines the spatial
	/// location of each of the representative vertices for the visited bins. While
	/// this approach does not fit into the visualization architecture and requires
	/// manual control, it has the advantage that extremely large data can be
	/// processed in pieces and appended to the filter piece-by-piece.
	///
	/// @warning
	/// This filter can drastically affect topology, i.e., topology is not
	/// preserved.
	///
	/// @warning
	/// The filter handles input triangle strips and arbitrary polygons. Arbitrary
	/// polygons are assumed convex: during insertion they are triangulated using
	/// a fan of triangles from the first point in the polygons. If the polygon is
	/// concave, this can produce bad results. In this case, use vtkTriangleFilter
	/// to triangulate the polygons first.
	///
	/// @warning
	/// The filter also treats polylines and vertices.
	///
	/// @warning
	/// Note that for certain types of geometry (e.g., a mostly 2D plane with
	/// jitter in the normal direction), the decimator can perform badly. In this
	/// situation, set the number of bins in the normal direction to one.
	///
	/// @warning
	/// vtkBinnedDecimation produces similar results with significant speedup
	/// and reduced memory consumption.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkQuadricDecimation vtkDecimatePro vtkDecimate vtkQuadricLODActor
	/// vtkBinnedDecimation
	/// </seealso>
	// Token: 0x0200098F RID: 2447
	public class vtkQuadricClustering : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019833 RID: 104499 RVA: 0x00238357 File Offset: 0x00236557
		static vtkQuadricClustering()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkQuadricClustering.MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadricClustering"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019834 RID: 104500 RVA: 0x0023837F File Offset: 0x0023657F
		public vtkQuadricClustering(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019835 RID: 104501
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadricClustering_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard instantiation, type and print methods.
		/// </summary>
		// Token: 0x06019836 RID: 104502 RVA: 0x00238390 File Offset: 0x00236590
		public new static vtkQuadricClustering New()
		{
			vtkQuadricClustering result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadricClustering.vtkQuadricClustering_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadricClustering)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard instantiation, type and print methods.
		/// </summary>
		// Token: 0x06019837 RID: 104503 RVA: 0x002383E4 File Offset: 0x002365E4
		public vtkQuadricClustering() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkQuadricClustering.vtkQuadricClustering_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019838 RID: 104504 RVA: 0x00238428 File Offset: 0x00236628
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019839 RID: 104505
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_Append_01(HandleRef pThis, HandleRef piece);

		/// <summary>
		/// These methods provide an alternative way of executing the filter.
		/// PolyData can be added to the result in pieces (append).
		/// In this mode, the user must specify the bounds of the entire model
		/// as an argument to the "StartAppend" method.
		/// </summary>
		// Token: 0x0601983A RID: 104506 RVA: 0x00238434 File Offset: 0x00236634
		public void Append(vtkPolyData piece)
		{
			vtkQuadricClustering.vtkQuadricClustering_Append_01(base.GetCppThis(), (piece == null) ? default(HandleRef) : piece.GetCppThis());
		}

		// Token: 0x0601983B RID: 104507
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_AutoAdjustNumberOfDivisionsOff_02(HandleRef pThis);

		/// <summary>
		/// Enable automatic adjustment of number of divisions. If off, the number
		/// of divisions specified by the user is always used (as long as it is valid).
		/// The default is On
		/// </summary>
		// Token: 0x0601983C RID: 104508 RVA: 0x00238463 File Offset: 0x00236663
		public virtual void AutoAdjustNumberOfDivisionsOff()
		{
			vtkQuadricClustering.vtkQuadricClustering_AutoAdjustNumberOfDivisionsOff_02(base.GetCppThis());
		}

		// Token: 0x0601983D RID: 104509
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_AutoAdjustNumberOfDivisionsOn_03(HandleRef pThis);

		/// <summary>
		/// Enable automatic adjustment of number of divisions. If off, the number
		/// of divisions specified by the user is always used (as long as it is valid).
		/// The default is On
		/// </summary>
		// Token: 0x0601983E RID: 104510 RVA: 0x00238472 File Offset: 0x00236672
		public virtual void AutoAdjustNumberOfDivisionsOn()
		{
			vtkQuadricClustering.vtkQuadricClustering_AutoAdjustNumberOfDivisionsOn_03(base.GetCppThis());
		}

		// Token: 0x0601983F RID: 104511
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_CopyCellDataOff_04(HandleRef pThis);

		/// <summary>
		/// This flag makes the filter copy cell data from input to output
		/// (the best it can).  It uses input cells that trigger the addition
		/// of output cells (no averaging).  This is off by default, and does
		/// not work when append is being called explicitly (non-pipeline usage).
		/// </summary>
		// Token: 0x06019840 RID: 104512 RVA: 0x00238481 File Offset: 0x00236681
		public virtual void CopyCellDataOff()
		{
			vtkQuadricClustering.vtkQuadricClustering_CopyCellDataOff_04(base.GetCppThis());
		}

		// Token: 0x06019841 RID: 104513
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_CopyCellDataOn_05(HandleRef pThis);

		/// <summary>
		/// This flag makes the filter copy cell data from input to output
		/// (the best it can).  It uses input cells that trigger the addition
		/// of output cells (no averaging).  This is off by default, and does
		/// not work when append is being called explicitly (non-pipeline usage).
		/// </summary>
		// Token: 0x06019842 RID: 104514 RVA: 0x00238490 File Offset: 0x00236690
		public virtual void CopyCellDataOn()
		{
			vtkQuadricClustering.vtkQuadricClustering_CopyCellDataOn_05(base.GetCppThis());
		}

		// Token: 0x06019843 RID: 104515
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_EndAppend_06(HandleRef pThis);

		/// <summary>
		/// These methods provide an alternative way of executing the filter.
		/// PolyData can be added to the result in pieces (append).
		/// In this mode, the user must specify the bounds of the entire model
		/// as an argument to the "StartAppend" method.
		/// </summary>
		// Token: 0x06019844 RID: 104516 RVA: 0x0023849F File Offset: 0x0023669F
		public void EndAppend()
		{
			vtkQuadricClustering.vtkQuadricClustering_EndAppend_06(base.GetCppThis());
		}

		// Token: 0x06019845 RID: 104517
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricClustering_GetAutoAdjustNumberOfDivisions_07(HandleRef pThis);

		/// <summary>
		/// Enable automatic adjustment of number of divisions. If off, the number
		/// of divisions specified by the user is always used (as long as it is valid).
		/// The default is On
		/// </summary>
		// Token: 0x06019846 RID: 104518 RVA: 0x002384B0 File Offset: 0x002366B0
		public virtual int GetAutoAdjustNumberOfDivisions()
		{
			return vtkQuadricClustering.vtkQuadricClustering_GetAutoAdjustNumberOfDivisions_07(base.GetCppThis());
		}

		// Token: 0x06019847 RID: 104519
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricClustering_GetCopyCellData_08(HandleRef pThis);

		/// <summary>
		/// This flag makes the filter copy cell data from input to output
		/// (the best it can).  It uses input cells that trigger the addition
		/// of output cells (no averaging).  This is off by default, and does
		/// not work when append is being called explicitly (non-pipeline usage).
		/// </summary>
		// Token: 0x06019848 RID: 104520 RVA: 0x002384D0 File Offset: 0x002366D0
		public virtual int GetCopyCellData()
		{
			return vtkQuadricClustering.vtkQuadricClustering_GetCopyCellData_08(base.GetCppThis());
		}

		// Token: 0x06019849 RID: 104521
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadricClustering_GetDivisionOrigin_09(HandleRef pThis);

		/// <summary>
		/// This is an alternative way to set up the bins.  If you are trying to match
		/// boundaries between pieces, then you should use these methods rather than
		/// SetNumberOfDivisions. To use these methods, specify the origin and spacing
		/// of the spatial binning.
		/// </summary>
		// Token: 0x0601984A RID: 104522 RVA: 0x002384F0 File Offset: 0x002366F0
		public virtual double[] GetDivisionOrigin()
		{
			IntPtr intPtr = vtkQuadricClustering.vtkQuadricClustering_GetDivisionOrigin_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601984B RID: 104523
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_GetDivisionOrigin_10(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// This is an alternative way to set up the bins.  If you are trying to match
		/// boundaries between pieces, then you should use these methods rather than
		/// SetNumberOfDivisions. To use these methods, specify the origin and spacing
		/// of the spatial binning.
		/// </summary>
		// Token: 0x0601984C RID: 104524 RVA: 0x00238538 File Offset: 0x00236738
		public virtual void GetDivisionOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkQuadricClustering.vtkQuadricClustering_GetDivisionOrigin_10(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0601984D RID: 104525
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_GetDivisionOrigin_11(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// This is an alternative way to set up the bins.  If you are trying to match
		/// boundaries between pieces, then you should use these methods rather than
		/// SetNumberOfDivisions. To use these methods, specify the origin and spacing
		/// of the spatial binning.
		/// </summary>
		// Token: 0x0601984E RID: 104526 RVA: 0x0023854A File Offset: 0x0023674A
		public virtual void GetDivisionOrigin(IntPtr _arg)
		{
			vtkQuadricClustering.vtkQuadricClustering_GetDivisionOrigin_11(base.GetCppThis(), _arg);
		}

		// Token: 0x0601984F RID: 104527
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadricClustering_GetDivisionSpacing_12(HandleRef pThis);

		/// <summary>
		/// This is an alternative way to set up the bins.  If you are trying to match
		/// boundaries between pieces, then you should use these methods rather than
		/// SetNumberOfDivisions. To use these methods, specify the origin and spacing
		/// of the spatial binning.
		/// </summary>
		// Token: 0x06019850 RID: 104528 RVA: 0x0023855C File Offset: 0x0023675C
		public virtual double[] GetDivisionSpacing()
		{
			IntPtr intPtr = vtkQuadricClustering.vtkQuadricClustering_GetDivisionSpacing_12(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06019851 RID: 104529
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_GetDivisionSpacing_13(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// This is an alternative way to set up the bins.  If you are trying to match
		/// boundaries between pieces, then you should use these methods rather than
		/// SetNumberOfDivisions. To use these methods, specify the origin and spacing
		/// of the spatial binning.
		/// </summary>
		// Token: 0x06019852 RID: 104530 RVA: 0x002385A4 File Offset: 0x002367A4
		public virtual void GetDivisionSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkQuadricClustering.vtkQuadricClustering_GetDivisionSpacing_13(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06019853 RID: 104531
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_GetDivisionSpacing_14(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// This is an alternative way to set up the bins.  If you are trying to match
		/// boundaries between pieces, then you should use these methods rather than
		/// SetNumberOfDivisions. To use these methods, specify the origin and spacing
		/// of the spatial binning.
		/// </summary>
		// Token: 0x06019854 RID: 104532 RVA: 0x002385B6 File Offset: 0x002367B6
		public virtual void GetDivisionSpacing(IntPtr _arg)
		{
			vtkQuadricClustering.vtkQuadricClustering_GetDivisionSpacing_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06019855 RID: 104533
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadricClustering_GetFeatureEdges_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// By default, this flag is off.  When "UseFeatureEdges" is on, then
		/// quadrics are computed for boundary edges/feature edges.  They influence
		/// the quadrics (position of points), but not the mesh.  Which features to
		/// use can be controlled by the filter "FeatureEdges".
		/// </summary>
		// Token: 0x06019856 RID: 104534 RVA: 0x002385C8 File Offset: 0x002367C8
		public vtkFeatureEdges GetFeatureEdges()
		{
			vtkFeatureEdges vtkFeatureEdges = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadricClustering.vtkQuadricClustering_GetFeatureEdges_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFeatureEdges = (vtkFeatureEdges)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFeatureEdges.Register(null);
				}
			}
			return vtkFeatureEdges;
		}

		// Token: 0x06019857 RID: 104535
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkQuadricClustering_GetFeaturePointsAngle_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the angle to use in determining whether a point on a boundary /
		/// feature edge is a feature point.
		/// </summary>
		// Token: 0x06019858 RID: 104536 RVA: 0x00238638 File Offset: 0x00236838
		public virtual double GetFeaturePointsAngle()
		{
			return vtkQuadricClustering.vtkQuadricClustering_GetFeaturePointsAngle_16(base.GetCppThis());
		}

		// Token: 0x06019859 RID: 104537
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkQuadricClustering_GetFeaturePointsAngleMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the angle to use in determining whether a point on a boundary /
		/// feature edge is a feature point.
		/// </summary>
		// Token: 0x0601985A RID: 104538 RVA: 0x00238658 File Offset: 0x00236858
		public virtual double GetFeaturePointsAngleMaxValue()
		{
			return vtkQuadricClustering.vtkQuadricClustering_GetFeaturePointsAngleMaxValue_17(base.GetCppThis());
		}

		// Token: 0x0601985B RID: 104539
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkQuadricClustering_GetFeaturePointsAngleMinValue_18(HandleRef pThis);

		/// <summary>
		/// Set/Get the angle to use in determining whether a point on a boundary /
		/// feature edge is a feature point.
		/// </summary>
		// Token: 0x0601985C RID: 104540 RVA: 0x00238678 File Offset: 0x00236878
		public virtual double GetFeaturePointsAngleMinValue()
		{
			return vtkQuadricClustering.vtkQuadricClustering_GetFeaturePointsAngleMinValue_18(base.GetCppThis());
		}

		// Token: 0x0601985D RID: 104541
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadricClustering_GetNumberOfDivisions_19(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of divisions along each axis for the spatial bins.
		/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
		/// NumberOfZDivisions.  The filter may choose to ignore large numbers of
		/// divisions if the input has few points and AutoAdjustNumberOfDivisions
		/// is enabled.
		/// </summary>
		// Token: 0x0601985E RID: 104542 RVA: 0x00238698 File Offset: 0x00236898
		public int[] GetNumberOfDivisions()
		{
			IntPtr intPtr = vtkQuadricClustering.vtkQuadricClustering_GetNumberOfDivisions_19(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601985F RID: 104543
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_GetNumberOfDivisions_20(HandleRef pThis, IntPtr div);

		/// <summary>
		/// Set/Get the number of divisions along each axis for the spatial bins.
		/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
		/// NumberOfZDivisions.  The filter may choose to ignore large numbers of
		/// divisions if the input has few points and AutoAdjustNumberOfDivisions
		/// is enabled.
		/// </summary>
		// Token: 0x06019860 RID: 104544 RVA: 0x002386E0 File Offset: 0x002368E0
		public void GetNumberOfDivisions(IntPtr div)
		{
			vtkQuadricClustering.vtkQuadricClustering_GetNumberOfDivisions_20(base.GetCppThis(), div);
		}

		// Token: 0x06019861 RID: 104545
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadricClustering_GetNumberOfGenerationsFromBase_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard instantiation, type and print methods.
		/// </summary>
		// Token: 0x06019862 RID: 104546 RVA: 0x002386F0 File Offset: 0x002368F0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkQuadricClustering.vtkQuadricClustering_GetNumberOfGenerationsFromBase_21(base.GetCppThis(), type);
		}

		// Token: 0x06019863 RID: 104547
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadricClustering_GetNumberOfGenerationsFromBaseType_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard instantiation, type and print methods.
		/// </summary>
		// Token: 0x06019864 RID: 104548 RVA: 0x00238710 File Offset: 0x00236910
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkQuadricClustering.vtkQuadricClustering_GetNumberOfGenerationsFromBaseType_22(type);
		}

		// Token: 0x06019865 RID: 104549
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricClustering_GetNumberOfXDivisions_23(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of divisions along each axis for the spatial bins.
		/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
		/// NumberOfZDivisions.  The filter may choose to ignore large numbers of
		/// divisions if the input has few points and AutoAdjustNumberOfDivisions
		/// is enabled.
		/// </summary>
		// Token: 0x06019866 RID: 104550 RVA: 0x0023872C File Offset: 0x0023692C
		public virtual int GetNumberOfXDivisions()
		{
			return vtkQuadricClustering.vtkQuadricClustering_GetNumberOfXDivisions_23(base.GetCppThis());
		}

		// Token: 0x06019867 RID: 104551
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricClustering_GetNumberOfYDivisions_24(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of divisions along each axis for the spatial bins.
		/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
		/// NumberOfZDivisions.  The filter may choose to ignore large numbers of
		/// divisions if the input has few points and AutoAdjustNumberOfDivisions
		/// is enabled.
		/// </summary>
		// Token: 0x06019868 RID: 104552 RVA: 0x0023874C File Offset: 0x0023694C
		public virtual int GetNumberOfYDivisions()
		{
			return vtkQuadricClustering.vtkQuadricClustering_GetNumberOfYDivisions_24(base.GetCppThis());
		}

		// Token: 0x06019869 RID: 104553
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricClustering_GetNumberOfZDivisions_25(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of divisions along each axis for the spatial bins.
		/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
		/// NumberOfZDivisions.  The filter may choose to ignore large numbers of
		/// divisions if the input has few points and AutoAdjustNumberOfDivisions
		/// is enabled.
		/// </summary>
		// Token: 0x0601986A RID: 104554 RVA: 0x0023876C File Offset: 0x0023696C
		public virtual int GetNumberOfZDivisions()
		{
			return vtkQuadricClustering.vtkQuadricClustering_GetNumberOfZDivisions_25(base.GetCppThis());
		}

		// Token: 0x0601986B RID: 104555
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricClustering_GetPreventDuplicateCells_26(HandleRef pThis);

		/// <summary>
		/// Specify a boolean indicating whether to remove duplicate cells
		/// (i.e. triangles).  This is a little slower, and takes more memory, but
		/// in some cases can reduce the number of cells produced by an order of
		/// magnitude. By default, this flag is true.
		/// </summary>
		// Token: 0x0601986C RID: 104556 RVA: 0x0023878C File Offset: 0x0023698C
		public virtual int GetPreventDuplicateCells()
		{
			return vtkQuadricClustering.vtkQuadricClustering_GetPreventDuplicateCells_26(base.GetCppThis());
		}

		// Token: 0x0601986D RID: 104557
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricClustering_GetUseFeatureEdges_27(HandleRef pThis);

		/// <summary>
		/// By default, this flag is off.  When "UseFeatureEdges" is on, then
		/// quadrics are computed for boundary edges/feature edges.  They influence
		/// the quadrics (position of points), but not the mesh.  Which features to
		/// use can be controlled by the filter "FeatureEdges".
		/// </summary>
		// Token: 0x0601986E RID: 104558 RVA: 0x002387AC File Offset: 0x002369AC
		public virtual int GetUseFeatureEdges()
		{
			return vtkQuadricClustering.vtkQuadricClustering_GetUseFeatureEdges_27(base.GetCppThis());
		}

		// Token: 0x0601986F RID: 104559
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricClustering_GetUseFeaturePoints_28(HandleRef pThis);

		/// <summary>
		/// By default, this flag is off.  It only has an effect when
		/// "UseFeatureEdges" is also on.  When "UseFeaturePoints" is on, then
		/// quadrics are computed for boundary / feature points used in the boundary
		/// / feature edges.  They influence the quadrics (position of points), but
		/// not the mesh.
		/// </summary>
		// Token: 0x06019870 RID: 104560 RVA: 0x002387CC File Offset: 0x002369CC
		public virtual int GetUseFeaturePoints()
		{
			return vtkQuadricClustering.vtkQuadricClustering_GetUseFeaturePoints_28(base.GetCppThis());
		}

		// Token: 0x06019871 RID: 104561
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricClustering_GetUseInputPoints_29(HandleRef pThis);

		/// <summary>
		/// Normally the point that minimizes the quadric error function is used as
		/// the output of the bin.  When this flag is on, the bin point is forced to
		/// be one of the points from the input (the one with the smallest
		/// error). This option does not work (i.e., input points cannot be used)
		/// when the append methods (StartAppend(), Append(), EndAppend()) are being
		/// called directly.
		/// </summary>
		// Token: 0x06019872 RID: 104562 RVA: 0x002387EC File Offset: 0x002369EC
		public virtual int GetUseInputPoints()
		{
			return vtkQuadricClustering.vtkQuadricClustering_GetUseInputPoints_29(base.GetCppThis());
		}

		// Token: 0x06019873 RID: 104563
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricClustering_GetUseInternalTriangles_30(HandleRef pThis);

		/// <summary>
		/// When this flag is on (and it is on by default), then triangles that are
		/// completely contained in a bin are added to the bin quadrics.  When the
		/// the flag is off the filter operates faster, but the surface may not be
		/// as well behaved.
		/// </summary>
		// Token: 0x06019874 RID: 104564 RVA: 0x0023880C File Offset: 0x00236A0C
		public virtual int GetUseInternalTriangles()
		{
			return vtkQuadricClustering.vtkQuadricClustering_GetUseInternalTriangles_30(base.GetCppThis());
		}

		// Token: 0x06019875 RID: 104565
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricClustering_IsA_31(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard instantiation, type and print methods.
		/// </summary>
		// Token: 0x06019876 RID: 104566 RVA: 0x0023882C File Offset: 0x00236A2C
		public override int IsA(string type)
		{
			return vtkQuadricClustering.vtkQuadricClustering_IsA_31(base.GetCppThis(), type);
		}

		// Token: 0x06019877 RID: 104567
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricClustering_IsTypeOf_32([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard instantiation, type and print methods.
		/// </summary>
		// Token: 0x06019878 RID: 104568 RVA: 0x0023884C File Offset: 0x00236A4C
		public new static int IsTypeOf(string type)
		{
			return vtkQuadricClustering.vtkQuadricClustering_IsTypeOf_32(type);
		}

		// Token: 0x06019879 RID: 104569
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadricClustering_NewInstance_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard instantiation, type and print methods.
		/// </summary>
		// Token: 0x0601987A RID: 104570 RVA: 0x00238868 File Offset: 0x00236A68
		public new vtkQuadricClustering NewInstance()
		{
			vtkQuadricClustering result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadricClustering.vtkQuadricClustering_NewInstance_34(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadricClustering)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601987B RID: 104571
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_PreventDuplicateCellsOff_35(HandleRef pThis);

		/// <summary>
		/// Specify a boolean indicating whether to remove duplicate cells
		/// (i.e. triangles).  This is a little slower, and takes more memory, but
		/// in some cases can reduce the number of cells produced by an order of
		/// magnitude. By default, this flag is true.
		/// </summary>
		// Token: 0x0601987C RID: 104572 RVA: 0x002388C2 File Offset: 0x00236AC2
		public virtual void PreventDuplicateCellsOff()
		{
			vtkQuadricClustering.vtkQuadricClustering_PreventDuplicateCellsOff_35(base.GetCppThis());
		}

		// Token: 0x0601987D RID: 104573
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_PreventDuplicateCellsOn_36(HandleRef pThis);

		/// <summary>
		/// Specify a boolean indicating whether to remove duplicate cells
		/// (i.e. triangles).  This is a little slower, and takes more memory, but
		/// in some cases can reduce the number of cells produced by an order of
		/// magnitude. By default, this flag is true.
		/// </summary>
		// Token: 0x0601987E RID: 104574 RVA: 0x002388D1 File Offset: 0x00236AD1
		public virtual void PreventDuplicateCellsOn()
		{
			vtkQuadricClustering.vtkQuadricClustering_PreventDuplicateCellsOn_36(base.GetCppThis());
		}

		// Token: 0x0601987F RID: 104575
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadricClustering_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard instantiation, type and print methods.
		/// </summary>
		// Token: 0x06019880 RID: 104576 RVA: 0x002388E0 File Offset: 0x00236AE0
		public new static vtkQuadricClustering SafeDownCast(vtkObjectBase o)
		{
			vtkQuadricClustering vtkQuadricClustering = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadricClustering.vtkQuadricClustering_SafeDownCast_37((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuadricClustering = (vtkQuadricClustering)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuadricClustering.Register(null);
				}
			}
			return vtkQuadricClustering;
		}

		// Token: 0x06019881 RID: 104577
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_SetAutoAdjustNumberOfDivisions_38(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable automatic adjustment of number of divisions. If off, the number
		/// of divisions specified by the user is always used (as long as it is valid).
		/// The default is On
		/// </summary>
		// Token: 0x06019882 RID: 104578 RVA: 0x0023895F File Offset: 0x00236B5F
		public virtual void SetAutoAdjustNumberOfDivisions(int _arg)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetAutoAdjustNumberOfDivisions_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06019883 RID: 104579
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_SetCopyCellData_39(HandleRef pThis, int _arg);

		/// <summary>
		/// This flag makes the filter copy cell data from input to output
		/// (the best it can).  It uses input cells that trigger the addition
		/// of output cells (no averaging).  This is off by default, and does
		/// not work when append is being called explicitly (non-pipeline usage).
		/// </summary>
		// Token: 0x06019884 RID: 104580 RVA: 0x0023896F File Offset: 0x00236B6F
		public virtual void SetCopyCellData(int _arg)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetCopyCellData_39(base.GetCppThis(), _arg);
		}

		// Token: 0x06019885 RID: 104581
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_SetDivisionOrigin_40(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// This is an alternative way to set up the bins.  If you are trying to match
		/// boundaries between pieces, then you should use these methods rather than
		/// SetNumberOfDivisions. To use these methods, specify the origin and spacing
		/// of the spatial binning.
		/// </summary>
		// Token: 0x06019886 RID: 104582 RVA: 0x0023897F File Offset: 0x00236B7F
		public void SetDivisionOrigin(double x, double y, double z)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetDivisionOrigin_40(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06019887 RID: 104583
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_SetDivisionOrigin_41(HandleRef pThis, IntPtr o);

		/// <summary>
		/// This is an alternative way to set up the bins.  If you are trying to match
		/// boundaries between pieces, then you should use these methods rather than
		/// SetNumberOfDivisions. To use these methods, specify the origin and spacing
		/// of the spatial binning.
		/// </summary>
		// Token: 0x06019888 RID: 104584 RVA: 0x00238991 File Offset: 0x00236B91
		public void SetDivisionOrigin(IntPtr o)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetDivisionOrigin_41(base.GetCppThis(), o);
		}

		// Token: 0x06019889 RID: 104585
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_SetDivisionSpacing_42(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// This is an alternative way to set up the bins.  If you are trying to match
		/// boundaries between pieces, then you should use these methods rather than
		/// SetNumberOfDivisions. To use these methods, specify the origin and spacing
		/// of the spatial binning.
		/// </summary>
		// Token: 0x0601988A RID: 104586 RVA: 0x002389A1 File Offset: 0x00236BA1
		public void SetDivisionSpacing(double x, double y, double z)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetDivisionSpacing_42(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0601988B RID: 104587
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_SetDivisionSpacing_43(HandleRef pThis, IntPtr s);

		/// <summary>
		/// This is an alternative way to set up the bins.  If you are trying to match
		/// boundaries between pieces, then you should use these methods rather than
		/// SetNumberOfDivisions. To use these methods, specify the origin and spacing
		/// of the spatial binning.
		/// </summary>
		// Token: 0x0601988C RID: 104588 RVA: 0x002389B3 File Offset: 0x00236BB3
		public void SetDivisionSpacing(IntPtr s)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetDivisionSpacing_43(base.GetCppThis(), s);
		}

		// Token: 0x0601988D RID: 104589
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_SetFeaturePointsAngle_44(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the angle to use in determining whether a point on a boundary /
		/// feature edge is a feature point.
		/// </summary>
		// Token: 0x0601988E RID: 104590 RVA: 0x002389C3 File Offset: 0x00236BC3
		public virtual void SetFeaturePointsAngle(double _arg)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetFeaturePointsAngle_44(base.GetCppThis(), _arg);
		}

		// Token: 0x0601988F RID: 104591
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_SetNumberOfDivisions_45(HandleRef pThis, IntPtr div);

		/// <summary>
		/// Set/Get the number of divisions along each axis for the spatial bins.
		/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
		/// NumberOfZDivisions.  The filter may choose to ignore large numbers of
		/// divisions if the input has few points and AutoAdjustNumberOfDivisions
		/// is enabled.
		/// </summary>
		// Token: 0x06019890 RID: 104592 RVA: 0x002389D3 File Offset: 0x00236BD3
		public void SetNumberOfDivisions(IntPtr div)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetNumberOfDivisions_45(base.GetCppThis(), div);
		}

		// Token: 0x06019891 RID: 104593
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_SetNumberOfDivisions_46(HandleRef pThis, int div0, int div1, int div2);

		/// <summary>
		/// Set/Get the number of divisions along each axis for the spatial bins.
		/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
		/// NumberOfZDivisions.  The filter may choose to ignore large numbers of
		/// divisions if the input has few points and AutoAdjustNumberOfDivisions
		/// is enabled.
		/// </summary>
		// Token: 0x06019892 RID: 104594 RVA: 0x002389E3 File Offset: 0x00236BE3
		public void SetNumberOfDivisions(int div0, int div1, int div2)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetNumberOfDivisions_46(base.GetCppThis(), div0, div1, div2);
		}

		// Token: 0x06019893 RID: 104595
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_SetNumberOfXDivisions_47(HandleRef pThis, int num);

		/// <summary>
		/// Set/Get the number of divisions along each axis for the spatial bins.
		/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
		/// NumberOfZDivisions.  The filter may choose to ignore large numbers of
		/// divisions if the input has few points and AutoAdjustNumberOfDivisions
		/// is enabled.
		/// </summary>
		// Token: 0x06019894 RID: 104596 RVA: 0x002389F5 File Offset: 0x00236BF5
		public void SetNumberOfXDivisions(int num)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetNumberOfXDivisions_47(base.GetCppThis(), num);
		}

		// Token: 0x06019895 RID: 104597
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_SetNumberOfYDivisions_48(HandleRef pThis, int num);

		/// <summary>
		/// Set/Get the number of divisions along each axis for the spatial bins.
		/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
		/// NumberOfZDivisions.  The filter may choose to ignore large numbers of
		/// divisions if the input has few points and AutoAdjustNumberOfDivisions
		/// is enabled.
		/// </summary>
		// Token: 0x06019896 RID: 104598 RVA: 0x00238A05 File Offset: 0x00236C05
		public void SetNumberOfYDivisions(int num)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetNumberOfYDivisions_48(base.GetCppThis(), num);
		}

		// Token: 0x06019897 RID: 104599
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_SetNumberOfZDivisions_49(HandleRef pThis, int num);

		/// <summary>
		/// Set/Get the number of divisions along each axis for the spatial bins.
		/// The number of spatial bins is NumberOfXDivisions*NumberOfYDivisions*
		/// NumberOfZDivisions.  The filter may choose to ignore large numbers of
		/// divisions if the input has few points and AutoAdjustNumberOfDivisions
		/// is enabled.
		/// </summary>
		// Token: 0x06019898 RID: 104600 RVA: 0x00238A15 File Offset: 0x00236C15
		public void SetNumberOfZDivisions(int num)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetNumberOfZDivisions_49(base.GetCppThis(), num);
		}

		// Token: 0x06019899 RID: 104601
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_SetPreventDuplicateCells_50(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify a boolean indicating whether to remove duplicate cells
		/// (i.e. triangles).  This is a little slower, and takes more memory, but
		/// in some cases can reduce the number of cells produced by an order of
		/// magnitude. By default, this flag is true.
		/// </summary>
		// Token: 0x0601989A RID: 104602 RVA: 0x00238A25 File Offset: 0x00236C25
		public virtual void SetPreventDuplicateCells(int _arg)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetPreventDuplicateCells_50(base.GetCppThis(), _arg);
		}

		// Token: 0x0601989B RID: 104603
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_SetUseFeatureEdges_51(HandleRef pThis, int _arg);

		/// <summary>
		/// By default, this flag is off.  When "UseFeatureEdges" is on, then
		/// quadrics are computed for boundary edges/feature edges.  They influence
		/// the quadrics (position of points), but not the mesh.  Which features to
		/// use can be controlled by the filter "FeatureEdges".
		/// </summary>
		// Token: 0x0601989C RID: 104604 RVA: 0x00238A35 File Offset: 0x00236C35
		public virtual void SetUseFeatureEdges(int _arg)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetUseFeatureEdges_51(base.GetCppThis(), _arg);
		}

		// Token: 0x0601989D RID: 104605
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_SetUseFeaturePoints_52(HandleRef pThis, int _arg);

		/// <summary>
		/// By default, this flag is off.  It only has an effect when
		/// "UseFeatureEdges" is also on.  When "UseFeaturePoints" is on, then
		/// quadrics are computed for boundary / feature points used in the boundary
		/// / feature edges.  They influence the quadrics (position of points), but
		/// not the mesh.
		/// </summary>
		// Token: 0x0601989E RID: 104606 RVA: 0x00238A45 File Offset: 0x00236C45
		public virtual void SetUseFeaturePoints(int _arg)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetUseFeaturePoints_52(base.GetCppThis(), _arg);
		}

		// Token: 0x0601989F RID: 104607
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_SetUseInputPoints_53(HandleRef pThis, int _arg);

		/// <summary>
		/// Normally the point that minimizes the quadric error function is used as
		/// the output of the bin.  When this flag is on, the bin point is forced to
		/// be one of the points from the input (the one with the smallest
		/// error). This option does not work (i.e., input points cannot be used)
		/// when the append methods (StartAppend(), Append(), EndAppend()) are being
		/// called directly.
		/// </summary>
		// Token: 0x060198A0 RID: 104608 RVA: 0x00238A55 File Offset: 0x00236C55
		public virtual void SetUseInputPoints(int _arg)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetUseInputPoints_53(base.GetCppThis(), _arg);
		}

		// Token: 0x060198A1 RID: 104609
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_SetUseInternalTriangles_54(HandleRef pThis, int _arg);

		/// <summary>
		/// When this flag is on (and it is on by default), then triangles that are
		/// completely contained in a bin are added to the bin quadrics.  When the
		/// the flag is off the filter operates faster, but the surface may not be
		/// as well behaved.
		/// </summary>
		// Token: 0x060198A2 RID: 104610 RVA: 0x00238A65 File Offset: 0x00236C65
		public virtual void SetUseInternalTriangles(int _arg)
		{
			vtkQuadricClustering.vtkQuadricClustering_SetUseInternalTriangles_54(base.GetCppThis(), _arg);
		}

		// Token: 0x060198A3 RID: 104611
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_StartAppend_55(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// These methods provide an alternative way of executing the filter.
		/// PolyData can be added to the result in pieces (append).
		/// In this mode, the user must specify the bounds of the entire model
		/// as an argument to the "StartAppend" method.
		/// </summary>
		// Token: 0x060198A4 RID: 104612 RVA: 0x00238A75 File Offset: 0x00236C75
		public void StartAppend(IntPtr bounds)
		{
			vtkQuadricClustering.vtkQuadricClustering_StartAppend_55(base.GetCppThis(), bounds);
		}

		// Token: 0x060198A5 RID: 104613
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_StartAppend_56(HandleRef pThis, double x0, double x1, double y0, double y1, double z0, double z1);

		/// <summary>
		/// These methods provide an alternative way of executing the filter.
		/// PolyData can be added to the result in pieces (append).
		/// In this mode, the user must specify the bounds of the entire model
		/// as an argument to the "StartAppend" method.
		/// </summary>
		// Token: 0x060198A6 RID: 104614 RVA: 0x00238A85 File Offset: 0x00236C85
		public void StartAppend(double x0, double x1, double y0, double y1, double z0, double z1)
		{
			vtkQuadricClustering.vtkQuadricClustering_StartAppend_56(base.GetCppThis(), x0, x1, y0, y1, z0, z1);
		}

		// Token: 0x060198A7 RID: 104615
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_UseFeatureEdgesOff_57(HandleRef pThis);

		/// <summary>
		/// By default, this flag is off.  When "UseFeatureEdges" is on, then
		/// quadrics are computed for boundary edges/feature edges.  They influence
		/// the quadrics (position of points), but not the mesh.  Which features to
		/// use can be controlled by the filter "FeatureEdges".
		/// </summary>
		// Token: 0x060198A8 RID: 104616 RVA: 0x00238A9D File Offset: 0x00236C9D
		public virtual void UseFeatureEdgesOff()
		{
			vtkQuadricClustering.vtkQuadricClustering_UseFeatureEdgesOff_57(base.GetCppThis());
		}

		// Token: 0x060198A9 RID: 104617
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_UseFeatureEdgesOn_58(HandleRef pThis);

		/// <summary>
		/// By default, this flag is off.  When "UseFeatureEdges" is on, then
		/// quadrics are computed for boundary edges/feature edges.  They influence
		/// the quadrics (position of points), but not the mesh.  Which features to
		/// use can be controlled by the filter "FeatureEdges".
		/// </summary>
		// Token: 0x060198AA RID: 104618 RVA: 0x00238AAC File Offset: 0x00236CAC
		public virtual void UseFeatureEdgesOn()
		{
			vtkQuadricClustering.vtkQuadricClustering_UseFeatureEdgesOn_58(base.GetCppThis());
		}

		// Token: 0x060198AB RID: 104619
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_UseFeaturePointsOff_59(HandleRef pThis);

		/// <summary>
		/// By default, this flag is off.  It only has an effect when
		/// "UseFeatureEdges" is also on.  When "UseFeaturePoints" is on, then
		/// quadrics are computed for boundary / feature points used in the boundary
		/// / feature edges.  They influence the quadrics (position of points), but
		/// not the mesh.
		/// </summary>
		// Token: 0x060198AC RID: 104620 RVA: 0x00238ABB File Offset: 0x00236CBB
		public virtual void UseFeaturePointsOff()
		{
			vtkQuadricClustering.vtkQuadricClustering_UseFeaturePointsOff_59(base.GetCppThis());
		}

		// Token: 0x060198AD RID: 104621
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_UseFeaturePointsOn_60(HandleRef pThis);

		/// <summary>
		/// By default, this flag is off.  It only has an effect when
		/// "UseFeatureEdges" is also on.  When "UseFeaturePoints" is on, then
		/// quadrics are computed for boundary / feature points used in the boundary
		/// / feature edges.  They influence the quadrics (position of points), but
		/// not the mesh.
		/// </summary>
		// Token: 0x060198AE RID: 104622 RVA: 0x00238ACA File Offset: 0x00236CCA
		public virtual void UseFeaturePointsOn()
		{
			vtkQuadricClustering.vtkQuadricClustering_UseFeaturePointsOn_60(base.GetCppThis());
		}

		// Token: 0x060198AF RID: 104623
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_UseInputPointsOff_61(HandleRef pThis);

		/// <summary>
		/// Normally the point that minimizes the quadric error function is used as
		/// the output of the bin.  When this flag is on, the bin point is forced to
		/// be one of the points from the input (the one with the smallest
		/// error). This option does not work (i.e., input points cannot be used)
		/// when the append methods (StartAppend(), Append(), EndAppend()) are being
		/// called directly.
		/// </summary>
		// Token: 0x060198B0 RID: 104624 RVA: 0x00238AD9 File Offset: 0x00236CD9
		public virtual void UseInputPointsOff()
		{
			vtkQuadricClustering.vtkQuadricClustering_UseInputPointsOff_61(base.GetCppThis());
		}

		// Token: 0x060198B1 RID: 104625
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_UseInputPointsOn_62(HandleRef pThis);

		/// <summary>
		/// Normally the point that minimizes the quadric error function is used as
		/// the output of the bin.  When this flag is on, the bin point is forced to
		/// be one of the points from the input (the one with the smallest
		/// error). This option does not work (i.e., input points cannot be used)
		/// when the append methods (StartAppend(), Append(), EndAppend()) are being
		/// called directly.
		/// </summary>
		// Token: 0x060198B2 RID: 104626 RVA: 0x00238AE8 File Offset: 0x00236CE8
		public virtual void UseInputPointsOn()
		{
			vtkQuadricClustering.vtkQuadricClustering_UseInputPointsOn_62(base.GetCppThis());
		}

		// Token: 0x060198B3 RID: 104627
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_UseInternalTrianglesOff_63(HandleRef pThis);

		/// <summary>
		/// When this flag is on (and it is on by default), then triangles that are
		/// completely contained in a bin are added to the bin quadrics.  When the
		/// the flag is off the filter operates faster, but the surface may not be
		/// as well behaved.
		/// </summary>
		// Token: 0x060198B4 RID: 104628 RVA: 0x00238AF7 File Offset: 0x00236CF7
		public virtual void UseInternalTrianglesOff()
		{
			vtkQuadricClustering.vtkQuadricClustering_UseInternalTrianglesOff_63(base.GetCppThis());
		}

		// Token: 0x060198B5 RID: 104629
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricClustering_UseInternalTrianglesOn_64(HandleRef pThis);

		/// <summary>
		/// When this flag is on (and it is on by default), then triangles that are
		/// completely contained in a bin are added to the bin quadrics.  When the
		/// the flag is off the filter operates faster, but the surface may not be
		/// as well behaved.
		/// </summary>
		// Token: 0x060198B6 RID: 104630 RVA: 0x00238B06 File Offset: 0x00236D06
		public virtual void UseInternalTrianglesOn()
		{
			vtkQuadricClustering.vtkQuadricClustering_UseInternalTrianglesOn_64(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BDF RID: 7135
		public new const string MRFullTypeName = "Kitware.VTK.vtkQuadricClustering";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BE0 RID: 7136
		public new static readonly string MRClassNameKey = "class vtkQuadricClustering";
	}
}
