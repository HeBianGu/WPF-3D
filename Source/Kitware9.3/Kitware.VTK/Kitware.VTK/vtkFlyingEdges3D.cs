using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFlyingEdges3D
	/// </summary>
	/// <remarks>
	///    generate isosurface from 3D image data (volume)
	///
	/// vtkFlyingEdges3D is a reference implementation of the 3D version of the
	/// flying edges algorithm. It is designed to be highly scalable (i.e.,
	/// parallelizable) for large data. It implements certain performance
	/// optimizations including computational trimming to rapidly eliminate
	/// processing of data regions, packed bit representation of case table
	/// values, single edge intersection, elimination of point merging, and
	/// elimination of any reallocs (due to dynamic data insertion). Note that
	/// computational trimming is a method to reduce total computational cost in
	/// which partial computational results can be used to eliminate future
	/// computations.
	///
	/// This is a four-pass algorithm. The first pass processes all x-edges and
	/// builds x-edge case values (which, when the four x-edges defining a voxel
	/// are combined, are equivalent to vertex-based case table except edge-based
	/// approaches are separable in support of parallel computing). Next x-voxel
	/// rows are processed to gather information from yz-edges (basically to count
	/// the number of y-z edge intersections and triangles generated). In the third
	/// pass a prefix sum is used to count and allocate memory for the output
	/// primitives. Finally in the fourth pass output primitives are generated into
	/// pre-allocated arrays. This implementation uses voxel cell axes (a x-y-z
	/// triad located at the voxel origin) to ensure that each edge is intersected
	/// at most one time. Note that this implementation also reuses the VTK
	/// Marching Cubes case table, although the vertex-based MC table is
	/// transformed into an edge-based table on object instantiation.
	///
	/// See the paper "Flying Edges: A High-Performance Scalable Isocontouring
	/// Algorithm" by Schroeder, Maynard, Geveci. Proc. of LDAV 2015. Chicago, IL.
	///
	/// @warning
	/// This filter is specialized to 3D volumes. Note that Flying Edges can produce
	/// degenerate triangles (i.e., zero-area triangles). Consequently, this filter
	/// may not produce the exact same output as Marching Cubes (since many
	/// implementations of MC remove degenerate triangles / duplicate points on
	/// output).
	///
	/// @warning
	/// If you are interested in extracting segmented regions from a label mask,
	/// consider using vtkSurfaceNets3D or vtkDiscreteFlyingEdges3D.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkContourFilter vtkFlyingEdges2D vtkSynchronizedTemplates3D
	/// vtkMarchingCubes vtkSurfaceNets3D vtkDiscreteFlyingEdges3D
	/// vtkContour3DLinearGrid vtkFlyingEdgesPlaneCutter
	/// </seealso>
	// Token: 0x0200096A RID: 2410
	public class vtkFlyingEdges3D : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601917E RID: 102782 RVA: 0x0022FC70 File Offset: 0x0022DE70
		static vtkFlyingEdges3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFlyingEdges3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFlyingEdges3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601917F RID: 102783 RVA: 0x0022FC98 File Offset: 0x0022DE98
		public vtkFlyingEdges3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019180 RID: 102784
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFlyingEdges3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing
		/// information.
		/// </summary>
		// Token: 0x06019181 RID: 102785 RVA: 0x0022FCA8 File Offset: 0x0022DEA8
		public new static vtkFlyingEdges3D New()
		{
			vtkFlyingEdges3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFlyingEdges3D.vtkFlyingEdges3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFlyingEdges3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing
		/// information.
		/// </summary>
		// Token: 0x06019182 RID: 102786 RVA: 0x0022FCFC File Offset: 0x0022DEFC
		public vtkFlyingEdges3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFlyingEdges3D.vtkFlyingEdges3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019183 RID: 102787 RVA: 0x0022FD40 File Offset: 0x0022DF40
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019184 RID: 102788
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdges3D_ComputeGradientsOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is fairly
		/// expensive in both time and storage. Note that if ComputeNormals is on,
		/// gradients will have to be calculated, but will not be stored in the
		/// output dataset. If the output data will be processed by filters that
		/// modify topology or geometry, it may be wise to turn Normals and
		/// Gradients off.
		/// </summary>
		// Token: 0x06019185 RID: 102789 RVA: 0x0022FD4B File Offset: 0x0022DF4B
		public virtual void ComputeGradientsOff()
		{
			vtkFlyingEdges3D.vtkFlyingEdges3D_ComputeGradientsOff_01(base.GetCppThis());
		}

		// Token: 0x06019186 RID: 102790
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdges3D_ComputeGradientsOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is fairly
		/// expensive in both time and storage. Note that if ComputeNormals is on,
		/// gradients will have to be calculated, but will not be stored in the
		/// output dataset. If the output data will be processed by filters that
		/// modify topology or geometry, it may be wise to turn Normals and
		/// Gradients off.
		/// </summary>
		// Token: 0x06019187 RID: 102791 RVA: 0x0022FD5A File Offset: 0x0022DF5A
		public virtual void ComputeGradientsOn()
		{
			vtkFlyingEdges3D.vtkFlyingEdges3D_ComputeGradientsOn_02(base.GetCppThis());
		}

		// Token: 0x06019188 RID: 102792
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdges3D_ComputeNormalsOff_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be processed
		/// by filters that modify topology or geometry, it may be wise to turn
		/// Normals and Gradients off.
		/// </summary>
		// Token: 0x06019189 RID: 102793 RVA: 0x0022FD69 File Offset: 0x0022DF69
		public virtual void ComputeNormalsOff()
		{
			vtkFlyingEdges3D.vtkFlyingEdges3D_ComputeNormalsOff_03(base.GetCppThis());
		}

		// Token: 0x0601918A RID: 102794
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdges3D_ComputeNormalsOn_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be processed
		/// by filters that modify topology or geometry, it may be wise to turn
		/// Normals and Gradients off.
		/// </summary>
		// Token: 0x0601918B RID: 102795 RVA: 0x0022FD78 File Offset: 0x0022DF78
		public virtual void ComputeNormalsOn()
		{
			vtkFlyingEdges3D.vtkFlyingEdges3D_ComputeNormalsOn_04(base.GetCppThis());
		}

		// Token: 0x0601918C RID: 102796
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdges3D_ComputeScalarsOff_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x0601918D RID: 102797 RVA: 0x0022FD87 File Offset: 0x0022DF87
		public virtual void ComputeScalarsOff()
		{
			vtkFlyingEdges3D.vtkFlyingEdges3D_ComputeScalarsOff_05(base.GetCppThis());
		}

		// Token: 0x0601918E RID: 102798
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdges3D_ComputeScalarsOn_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x0601918F RID: 102799 RVA: 0x0022FD96 File Offset: 0x0022DF96
		public virtual void ComputeScalarsOn()
		{
			vtkFlyingEdges3D.vtkFlyingEdges3D_ComputeScalarsOn_06(base.GetCppThis());
		}

		// Token: 0x06019190 RID: 102800
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdges3D_GenerateValues_07(HandleRef pThis, int numContours, IntPtr range);

		/// <summary>
		/// Generate numContours equally spaced contour values between specified
		/// range. Contour values will include min/max range values.
		/// </summary>
		// Token: 0x06019191 RID: 102801 RVA: 0x0022FDA5 File Offset: 0x0022DFA5
		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkFlyingEdges3D.vtkFlyingEdges3D_GenerateValues_07(base.GetCppThis(), numContours, range);
		}

		// Token: 0x06019192 RID: 102802
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdges3D_GenerateValues_08(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		/// <summary>
		/// Generate numContours equally spaced contour values between specified
		/// range. Contour values will include min/max range values.
		/// </summary>
		// Token: 0x06019193 RID: 102803 RVA: 0x0022FDB6 File Offset: 0x0022DFB6
		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkFlyingEdges3D.vtkFlyingEdges3D_GenerateValues_08(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		// Token: 0x06019194 RID: 102804
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFlyingEdges3D_GetArrayComponent_09(HandleRef pThis);

		/// <summary>
		/// Set/get which component of the scalar array to contour on; defaults to 0.
		/// </summary>
		// Token: 0x06019195 RID: 102805 RVA: 0x0022FDC8 File Offset: 0x0022DFC8
		public virtual int GetArrayComponent()
		{
			return vtkFlyingEdges3D.vtkFlyingEdges3D_GetArrayComponent_09(base.GetCppThis());
		}

		// Token: 0x06019196 RID: 102806
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFlyingEdges3D_GetComputeGradients_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is fairly
		/// expensive in both time and storage. Note that if ComputeNormals is on,
		/// gradients will have to be calculated, but will not be stored in the
		/// output dataset. If the output data will be processed by filters that
		/// modify topology or geometry, it may be wise to turn Normals and
		/// Gradients off.
		/// </summary>
		// Token: 0x06019197 RID: 102807 RVA: 0x0022FDE8 File Offset: 0x0022DFE8
		public virtual int GetComputeGradients()
		{
			return vtkFlyingEdges3D.vtkFlyingEdges3D_GetComputeGradients_10(base.GetCppThis());
		}

		// Token: 0x06019198 RID: 102808
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFlyingEdges3D_GetComputeNormals_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be processed
		/// by filters that modify topology or geometry, it may be wise to turn
		/// Normals and Gradients off.
		/// </summary>
		// Token: 0x06019199 RID: 102809 RVA: 0x0022FE08 File Offset: 0x0022E008
		public virtual int GetComputeNormals()
		{
			return vtkFlyingEdges3D.vtkFlyingEdges3D_GetComputeNormals_11(base.GetCppThis());
		}

		// Token: 0x0601919A RID: 102810
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFlyingEdges3D_GetComputeScalars_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x0601919B RID: 102811 RVA: 0x0022FE28 File Offset: 0x0022E028
		public virtual int GetComputeScalars()
		{
			return vtkFlyingEdges3D.vtkFlyingEdges3D_GetComputeScalars_12(base.GetCppThis());
		}

		// Token: 0x0601919C RID: 102812
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFlyingEdges3D_GetInterpolateAttributes_13(HandleRef pThis);

		/// <summary>
		/// Indicate whether to interpolate other attribute data. That is, as the
		/// isosurface is generated, interpolate all point attribute data across
		/// the edge. This is independent of scalar interpolation, which is
		/// controlled by the ComputeScalars flag.
		/// </summary>
		// Token: 0x0601919D RID: 102813 RVA: 0x0022FE48 File Offset: 0x0022E048
		public virtual int GetInterpolateAttributes()
		{
			return vtkFlyingEdges3D.vtkFlyingEdges3D_GetInterpolateAttributes_13(base.GetCppThis());
		}

		// Token: 0x0601919E RID: 102814
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkFlyingEdges3D_GetMTime_14(HandleRef pThis);

		/// <summary>
		/// Because we delegate to vtkContourValues.
		/// </summary>
		// Token: 0x0601919F RID: 102815 RVA: 0x0022FE68 File Offset: 0x0022E068
		public override ulong GetMTime()
		{
			return vtkFlyingEdges3D.vtkFlyingEdges3D_GetMTime_14(base.GetCppThis());
		}

		// Token: 0x060191A0 RID: 102816
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFlyingEdges3D_GetNumberOfContours_15(HandleRef pThis);

		/// <summary>
		/// Get the number of contours in the list of contour values.
		/// </summary>
		// Token: 0x060191A1 RID: 102817 RVA: 0x0022FE88 File Offset: 0x0022E088
		public long GetNumberOfContours()
		{
			return vtkFlyingEdges3D.vtkFlyingEdges3D_GetNumberOfContours_15(base.GetCppThis());
		}

		// Token: 0x060191A2 RID: 102818
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFlyingEdges3D_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing
		/// information.
		/// </summary>
		// Token: 0x060191A3 RID: 102819 RVA: 0x0022FEA8 File Offset: 0x0022E0A8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFlyingEdges3D.vtkFlyingEdges3D_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x060191A4 RID: 102820
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFlyingEdges3D_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing
		/// information.
		/// </summary>
		// Token: 0x060191A5 RID: 102821 RVA: 0x0022FEC8 File Offset: 0x0022E0C8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFlyingEdges3D.vtkFlyingEdges3D_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x060191A6 RID: 102822
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFlyingEdges3D_GetValue_18(HandleRef pThis, int i);

		/// <summary>
		/// Get the ith contour value.
		/// </summary>
		// Token: 0x060191A7 RID: 102823 RVA: 0x0022FEE4 File Offset: 0x0022E0E4
		public double GetValue(int i)
		{
			return vtkFlyingEdges3D.vtkFlyingEdges3D_GetValue_18(base.GetCppThis(), i);
		}

		// Token: 0x060191A8 RID: 102824
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFlyingEdges3D_GetValues_19(HandleRef pThis);

		/// <summary>
		/// Get a pointer to an array of contour values. There will be
		/// GetNumberOfContours() values in the list.
		/// </summary>
		// Token: 0x060191A9 RID: 102825 RVA: 0x0022FF04 File Offset: 0x0022E104
		public IntPtr GetValues()
		{
			return vtkFlyingEdges3D.vtkFlyingEdges3D_GetValues_19(base.GetCppThis());
		}

		// Token: 0x060191AA RID: 102826
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdges3D_GetValues_20(HandleRef pThis, IntPtr contourValues);

		/// <summary>
		/// Fill a supplied list with contour values. There will be
		/// GetNumberOfContours() values in the list. Make sure you allocate
		/// enough memory to hold the list.
		/// </summary>
		// Token: 0x060191AB RID: 102827 RVA: 0x0022FF23 File Offset: 0x0022E123
		public void GetValues(IntPtr contourValues)
		{
			vtkFlyingEdges3D.vtkFlyingEdges3D_GetValues_20(base.GetCppThis(), contourValues);
		}

		// Token: 0x060191AC RID: 102828
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdges3D_InterpolateAttributesOff_21(HandleRef pThis);

		/// <summary>
		/// Indicate whether to interpolate other attribute data. That is, as the
		/// isosurface is generated, interpolate all point attribute data across
		/// the edge. This is independent of scalar interpolation, which is
		/// controlled by the ComputeScalars flag.
		/// </summary>
		// Token: 0x060191AD RID: 102829 RVA: 0x0022FF33 File Offset: 0x0022E133
		public virtual void InterpolateAttributesOff()
		{
			vtkFlyingEdges3D.vtkFlyingEdges3D_InterpolateAttributesOff_21(base.GetCppThis());
		}

		// Token: 0x060191AE RID: 102830
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdges3D_InterpolateAttributesOn_22(HandleRef pThis);

		/// <summary>
		/// Indicate whether to interpolate other attribute data. That is, as the
		/// isosurface is generated, interpolate all point attribute data across
		/// the edge. This is independent of scalar interpolation, which is
		/// controlled by the ComputeScalars flag.
		/// </summary>
		// Token: 0x060191AF RID: 102831 RVA: 0x0022FF42 File Offset: 0x0022E142
		public virtual void InterpolateAttributesOn()
		{
			vtkFlyingEdges3D.vtkFlyingEdges3D_InterpolateAttributesOn_22(base.GetCppThis());
		}

		// Token: 0x060191B0 RID: 102832
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFlyingEdges3D_IsA_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing
		/// information.
		/// </summary>
		// Token: 0x060191B1 RID: 102833 RVA: 0x0022FF54 File Offset: 0x0022E154
		public override int IsA(string type)
		{
			return vtkFlyingEdges3D.vtkFlyingEdges3D_IsA_23(base.GetCppThis(), type);
		}

		// Token: 0x060191B2 RID: 102834
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFlyingEdges3D_IsTypeOf_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing
		/// information.
		/// </summary>
		// Token: 0x060191B3 RID: 102835 RVA: 0x0022FF74 File Offset: 0x0022E174
		public new static int IsTypeOf(string type)
		{
			return vtkFlyingEdges3D.vtkFlyingEdges3D_IsTypeOf_24(type);
		}

		// Token: 0x060191B4 RID: 102836
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFlyingEdges3D_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing
		/// information.
		/// </summary>
		// Token: 0x060191B5 RID: 102837 RVA: 0x0022FF90 File Offset: 0x0022E190
		public new vtkFlyingEdges3D NewInstance()
		{
			vtkFlyingEdges3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFlyingEdges3D.vtkFlyingEdges3D_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFlyingEdges3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060191B6 RID: 102838
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFlyingEdges3D_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing
		/// information.
		/// </summary>
		// Token: 0x060191B7 RID: 102839 RVA: 0x0022FFEC File Offset: 0x0022E1EC
		public new static vtkFlyingEdges3D SafeDownCast(vtkObjectBase o)
		{
			vtkFlyingEdges3D vtkFlyingEdges3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFlyingEdges3D.vtkFlyingEdges3D_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFlyingEdges3D = (vtkFlyingEdges3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFlyingEdges3D.Register(null);
				}
			}
			return vtkFlyingEdges3D;
		}

		// Token: 0x060191B8 RID: 102840
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdges3D_SetArrayComponent_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get which component of the scalar array to contour on; defaults to 0.
		/// </summary>
		// Token: 0x060191B9 RID: 102841 RVA: 0x0023006B File Offset: 0x0022E26B
		public virtual void SetArrayComponent(int _arg)
		{
			vtkFlyingEdges3D.vtkFlyingEdges3D_SetArrayComponent_28(base.GetCppThis(), _arg);
		}

		// Token: 0x060191BA RID: 102842
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdges3D_SetComputeGradients_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is fairly
		/// expensive in both time and storage. Note that if ComputeNormals is on,
		/// gradients will have to be calculated, but will not be stored in the
		/// output dataset. If the output data will be processed by filters that
		/// modify topology or geometry, it may be wise to turn Normals and
		/// Gradients off.
		/// </summary>
		// Token: 0x060191BB RID: 102843 RVA: 0x0023007B File Offset: 0x0022E27B
		public virtual void SetComputeGradients(int _arg)
		{
			vtkFlyingEdges3D.vtkFlyingEdges3D_SetComputeGradients_29(base.GetCppThis(), _arg);
		}

		// Token: 0x060191BC RID: 102844
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdges3D_SetComputeNormals_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be processed
		/// by filters that modify topology or geometry, it may be wise to turn
		/// Normals and Gradients off.
		/// </summary>
		// Token: 0x060191BD RID: 102845 RVA: 0x0023008B File Offset: 0x0022E28B
		public virtual void SetComputeNormals(int _arg)
		{
			vtkFlyingEdges3D.vtkFlyingEdges3D_SetComputeNormals_30(base.GetCppThis(), _arg);
		}

		// Token: 0x060191BE RID: 102846
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdges3D_SetComputeScalars_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of scalars.
		/// </summary>
		// Token: 0x060191BF RID: 102847 RVA: 0x0023009B File Offset: 0x0022E29B
		public virtual void SetComputeScalars(int _arg)
		{
			vtkFlyingEdges3D.vtkFlyingEdges3D_SetComputeScalars_31(base.GetCppThis(), _arg);
		}

		// Token: 0x060191C0 RID: 102848
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdges3D_SetInterpolateAttributes_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate whether to interpolate other attribute data. That is, as the
		/// isosurface is generated, interpolate all point attribute data across
		/// the edge. This is independent of scalar interpolation, which is
		/// controlled by the ComputeScalars flag.
		/// </summary>
		// Token: 0x060191C1 RID: 102849 RVA: 0x002300AB File Offset: 0x0022E2AB
		public virtual void SetInterpolateAttributes(int _arg)
		{
			vtkFlyingEdges3D.vtkFlyingEdges3D_SetInterpolateAttributes_32(base.GetCppThis(), _arg);
		}

		// Token: 0x060191C2 RID: 102850
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdges3D_SetNumberOfContours_33(HandleRef pThis, int number);

		/// <summary>
		/// Set the number of contours to place into the list. You only really
		/// need to use this method to reduce list size. The method SetValue()
		/// will automatically increase list size as needed.
		/// </summary>
		// Token: 0x060191C3 RID: 102851 RVA: 0x002300BB File Offset: 0x0022E2BB
		public void SetNumberOfContours(int number)
		{
			vtkFlyingEdges3D.vtkFlyingEdges3D_SetNumberOfContours_33(base.GetCppThis(), number);
		}

		// Token: 0x060191C4 RID: 102852
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFlyingEdges3D_SetValue_34(HandleRef pThis, int i, double value);

		/// <summary>
		/// Set a particular contour value at contour number i. The index i ranges
		/// between 0&lt;=i&lt;NumberOfContours.
		/// </summary>
		// Token: 0x060191C5 RID: 102853 RVA: 0x002300CB File Offset: 0x0022E2CB
		public void SetValue(int i, double value)
		{
			vtkFlyingEdges3D.vtkFlyingEdges3D_SetValue_34(base.GetCppThis(), i, value);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B8D RID: 7053
		public new const string MRFullTypeName = "Kitware.VTK.vtkFlyingEdges3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B8E RID: 7054
		public new static readonly string MRClassNameKey = "class vtkFlyingEdges3D";
	}
}
