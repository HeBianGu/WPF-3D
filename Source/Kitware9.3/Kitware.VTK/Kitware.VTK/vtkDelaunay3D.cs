using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDelaunay3D
	/// </summary>
	/// <remarks>
	///    create 3D Delaunay triangulation of input points
	///
	/// vtkDelaunay3D is a filter that constructs a 3D Delaunay
	/// triangulation from a list of input points. These points may be
	/// represented by any dataset of type vtkPointSet and subclasses. The
	/// output of the filter is an unstructured grid dataset. Usually the
	/// output is a tetrahedral mesh, but if a non-zero alpha distance
	/// value is specified (called the "alpha" value), then only tetrahedra,
	/// triangles, edges, and vertices laying within the alpha radius are
	/// output. In other words, non-zero alpha values may result in arbitrary
	/// combinations of tetrahedra, triangles, lines, and vertices. (The notion
	/// of alpha value is derived from Edelsbrunner's work on "alpha shapes".)
	/// Note that a modification to alpha shapes enables output of combinations
	/// of tetrahedra, triangles, lines, and/or verts (see the boolean ivars
	/// AlphaTets, AlphaTris, AlphaLines, AlphaVerts).
	///
	/// The 3D Delaunay triangulation is defined as the triangulation that
	/// satisfies the Delaunay criterion for n-dimensional simplexes (in
	/// this case n=3 and the simplexes are tetrahedra). This criterion
	/// states that a circumsphere of each simplex in a triangulation
	/// contains only the n+1 defining points of the simplex. (See text for
	/// more information.) While in two dimensions this translates into an
	/// "optimal" triangulation, this is not true in 3D, since a measurement
	/// for optimality in 3D is not agreed on.
	///
	/// Delaunay triangulations are used to build topological structures
	/// from unorganized (or unstructured) points. The input to this filter
	/// is a list of points specified in 3D. (If you wish to create 2D
	/// triangulations see vtkDelaunay2D.) The output is an unstructured grid.
	///
	/// The Delaunay triangulation can be numerically sensitive. To prevent
	/// problems, try to avoid injecting points that will result in
	/// triangles with bad aspect ratios (1000:1 or greater). In practice
	/// this means inserting points that are "widely dispersed", and
	/// enables smooth transition of triangle sizes throughout the
	/// mesh. (You may even want to add extra points to create a better
	/// point distribution.) If numerical problems are present, you will
	/// see a warning message to this effect at the end of the
	/// triangulation process.
	///
	/// @warning
	/// Points arranged on a regular lattice (termed degenerate cases) can be
	/// triangulated in more than one way (at least according to the Delaunay
	/// criterion). The choice of triangulation (as implemented by
	/// this algorithm) depends on the order of the input points. The first four
	/// points will form a tetrahedron; other degenerate points (relative to this
	/// initial tetrahedron) will not break it.
	///
	/// @warning
	/// Points that are coincident (or nearly so) may be discarded by the
	/// algorithm.  This is because the Delaunay triangulation requires
	/// unique input points.  You can control the definition of coincidence
	/// with the "Tolerance" instance variable.
	///
	/// @warning
	/// The output of the Delaunay triangulation is supposedly a convex hull. In
	/// certain cases this implementation may not generate the convex hull. This
	/// behavior can be controlled by the Offset instance variable. Offset is a
	/// multiplier used to control the size of the initial triangulation. The
	/// larger the offset value, the more likely you will generate a convex hull;
	/// and the more likely you are to see numerical problems.
	///
	/// @warning
	/// The implementation of this algorithm varies from the 2D Delaunay
	/// algorithm (i.e., vtkDelaunay2D) in an important way. When points are
	/// injected into the triangulation, the search for the enclosing tetrahedron
	/// is quite different. In the 3D case, the closest previously inserted point
	/// point is found, and then the connected tetrahedra are searched to find
	/// the containing one. (In 2D, a "walk" towards the enclosing triangle is
	/// performed.) If the triangulation is Delaunay, then an enclosing tetrahedron
	/// will be found. However, in degenerate cases an enclosing tetrahedron may
	/// not be found and the point will be rejected.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDelaunay2D vtkGaussianSplatter vtkUnstructuredGrid
	/// </seealso>
	// Token: 0x0200095D RID: 2397
	public class vtkDelaunay3D : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018EDA RID: 102106 RVA: 0x0022C4C7 File Offset: 0x0022A6C7
		static vtkDelaunay3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDelaunay3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDelaunay3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018EDB RID: 102107 RVA: 0x0022C4EF File Offset: 0x0022A6EF
		public vtkDelaunay3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018EDC RID: 102108
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDelaunay3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with Alpha = 0.0; Tolerance = 0.001; Offset = 2.5;
		/// BoundingTriangulation turned off.
		/// </summary>
		// Token: 0x06018EDD RID: 102109 RVA: 0x0022C500 File Offset: 0x0022A700
		public new static vtkDelaunay3D New()
		{
			vtkDelaunay3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDelaunay3D.vtkDelaunay3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDelaunay3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with Alpha = 0.0; Tolerance = 0.001; Offset = 2.5;
		/// BoundingTriangulation turned off.
		/// </summary>
		// Token: 0x06018EDE RID: 102110 RVA: 0x0022C554 File Offset: 0x0022A754
		public vtkDelaunay3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDelaunay3D.vtkDelaunay3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018EDF RID: 102111 RVA: 0x0022C598 File Offset: 0x0022A798
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018EE0 RID: 102112
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay3D_AlphaLinesOff_01(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether lines are output for non-zero alpha values.
		/// </summary>
		// Token: 0x06018EE1 RID: 102113 RVA: 0x0022C5A3 File Offset: 0x0022A7A3
		public virtual void AlphaLinesOff()
		{
			vtkDelaunay3D.vtkDelaunay3D_AlphaLinesOff_01(base.GetCppThis());
		}

		// Token: 0x06018EE2 RID: 102114
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay3D_AlphaLinesOn_02(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether lines are output for non-zero alpha values.
		/// </summary>
		// Token: 0x06018EE3 RID: 102115 RVA: 0x0022C5B2 File Offset: 0x0022A7B2
		public virtual void AlphaLinesOn()
		{
			vtkDelaunay3D.vtkDelaunay3D_AlphaLinesOn_02(base.GetCppThis());
		}

		// Token: 0x06018EE4 RID: 102116
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay3D_AlphaTetsOff_03(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether tetrahedra are output for non-zero alpha values.
		/// </summary>
		// Token: 0x06018EE5 RID: 102117 RVA: 0x0022C5C1 File Offset: 0x0022A7C1
		public virtual void AlphaTetsOff()
		{
			vtkDelaunay3D.vtkDelaunay3D_AlphaTetsOff_03(base.GetCppThis());
		}

		// Token: 0x06018EE6 RID: 102118
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay3D_AlphaTetsOn_04(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether tetrahedra are output for non-zero alpha values.
		/// </summary>
		// Token: 0x06018EE7 RID: 102119 RVA: 0x0022C5D0 File Offset: 0x0022A7D0
		public virtual void AlphaTetsOn()
		{
			vtkDelaunay3D.vtkDelaunay3D_AlphaTetsOn_04(base.GetCppThis());
		}

		// Token: 0x06018EE8 RID: 102120
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay3D_AlphaTrisOff_05(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether triangles are output for non-zero alpha values.
		/// </summary>
		// Token: 0x06018EE9 RID: 102121 RVA: 0x0022C5DF File Offset: 0x0022A7DF
		public virtual void AlphaTrisOff()
		{
			vtkDelaunay3D.vtkDelaunay3D_AlphaTrisOff_05(base.GetCppThis());
		}

		// Token: 0x06018EEA RID: 102122
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay3D_AlphaTrisOn_06(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether triangles are output for non-zero alpha values.
		/// </summary>
		// Token: 0x06018EEB RID: 102123 RVA: 0x0022C5EE File Offset: 0x0022A7EE
		public virtual void AlphaTrisOn()
		{
			vtkDelaunay3D.vtkDelaunay3D_AlphaTrisOn_06(base.GetCppThis());
		}

		// Token: 0x06018EEC RID: 102124
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay3D_AlphaVertsOff_07(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether vertices are output for non-zero alpha values.
		/// </summary>
		// Token: 0x06018EED RID: 102125 RVA: 0x0022C5FD File Offset: 0x0022A7FD
		public virtual void AlphaVertsOff()
		{
			vtkDelaunay3D.vtkDelaunay3D_AlphaVertsOff_07(base.GetCppThis());
		}

		// Token: 0x06018EEE RID: 102126
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay3D_AlphaVertsOn_08(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether vertices are output for non-zero alpha values.
		/// </summary>
		// Token: 0x06018EEF RID: 102127 RVA: 0x0022C60C File Offset: 0x0022A80C
		public virtual void AlphaVertsOn()
		{
			vtkDelaunay3D.vtkDelaunay3D_AlphaVertsOn_08(base.GetCppThis());
		}

		// Token: 0x06018EF0 RID: 102128
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay3D_BoundingTriangulationOff_09(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether bounding triangulation points (and associated
		/// triangles) are included in the output. (These are introduced as an
		/// initial triangulation to begin the triangulation process. This feature
		/// is nice for debugging output.)
		/// </summary>
		// Token: 0x06018EF1 RID: 102129 RVA: 0x0022C61B File Offset: 0x0022A81B
		public virtual void BoundingTriangulationOff()
		{
			vtkDelaunay3D.vtkDelaunay3D_BoundingTriangulationOff_09(base.GetCppThis());
		}

		// Token: 0x06018EF2 RID: 102130
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay3D_BoundingTriangulationOn_10(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether bounding triangulation points (and associated
		/// triangles) are included in the output. (These are introduced as an
		/// initial triangulation to begin the triangulation process. This feature
		/// is nice for debugging output.)
		/// </summary>
		// Token: 0x06018EF3 RID: 102131 RVA: 0x0022C62A File Offset: 0x0022A82A
		public virtual void BoundingTriangulationOn()
		{
			vtkDelaunay3D.vtkDelaunay3D_BoundingTriangulationOn_10(base.GetCppThis());
		}

		// Token: 0x06018EF4 RID: 102132
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay3D_CreateDefaultLocator_11(HandleRef pThis);

		/// <summary>
		/// Create default locator. Used to create one when none is specified. The
		/// locator is used to eliminate "coincident" points.
		/// </summary>
		// Token: 0x06018EF5 RID: 102133 RVA: 0x0022C639 File Offset: 0x0022A839
		public void CreateDefaultLocator()
		{
			vtkDelaunay3D.vtkDelaunay3D_CreateDefaultLocator_11(base.GetCppThis());
		}

		// Token: 0x06018EF6 RID: 102134
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay3D_EndPointInsertion_12(HandleRef pThis);

		/// <summary>
		/// Invoke this method after all points have been inserted. The purpose of
		/// the method is to clean up internal data structures. Note that the
		/// (vtkUnstructuredGrid *)Mesh returned from InitPointInsertion() is NOT
		/// deleted, you still are responsible for cleaning that up.
		/// </summary>
		// Token: 0x06018EF7 RID: 102135 RVA: 0x0022C648 File Offset: 0x0022A848
		public void EndPointInsertion()
		{
			vtkDelaunay3D.vtkDelaunay3D_EndPointInsertion_12(base.GetCppThis());
		}

		// Token: 0x06018EF8 RID: 102136
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDelaunay3D_GetAlpha_13(HandleRef pThis);

		/// <summary>
		/// Specify alpha (or distance) value to control output of this filter.  For
		/// a non-zero alpha value, only verts, edges, faces, or tetra contained
		/// within the circumsphere (of radius alpha) will be output. Otherwise,
		/// only tetrahedra will be output. Note that the flags AlphaTets, AlphaTris,
		/// AlphaLines, and AlphaVerts control whether these primitives are output
		/// when Alpha is non-zero. (By default all tets, triangles, lines and verts
		/// satisfying the alpha shape criterion are output.)
		/// </summary>
		// Token: 0x06018EF9 RID: 102137 RVA: 0x0022C658 File Offset: 0x0022A858
		public virtual double GetAlpha()
		{
			return vtkDelaunay3D.vtkDelaunay3D_GetAlpha_13(base.GetCppThis());
		}

		// Token: 0x06018EFA RID: 102138
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDelaunay3D_GetAlphaLines_14(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether lines are output for non-zero alpha values.
		/// </summary>
		// Token: 0x06018EFB RID: 102139 RVA: 0x0022C678 File Offset: 0x0022A878
		public virtual int GetAlphaLines()
		{
			return vtkDelaunay3D.vtkDelaunay3D_GetAlphaLines_14(base.GetCppThis());
		}

		// Token: 0x06018EFC RID: 102140
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDelaunay3D_GetAlphaMaxValue_15(HandleRef pThis);

		/// <summary>
		/// Specify alpha (or distance) value to control output of this filter.  For
		/// a non-zero alpha value, only verts, edges, faces, or tetra contained
		/// within the circumsphere (of radius alpha) will be output. Otherwise,
		/// only tetrahedra will be output. Note that the flags AlphaTets, AlphaTris,
		/// AlphaLines, and AlphaVerts control whether these primitives are output
		/// when Alpha is non-zero. (By default all tets, triangles, lines and verts
		/// satisfying the alpha shape criterion are output.)
		/// </summary>
		// Token: 0x06018EFD RID: 102141 RVA: 0x0022C698 File Offset: 0x0022A898
		public virtual double GetAlphaMaxValue()
		{
			return vtkDelaunay3D.vtkDelaunay3D_GetAlphaMaxValue_15(base.GetCppThis());
		}

		// Token: 0x06018EFE RID: 102142
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDelaunay3D_GetAlphaMinValue_16(HandleRef pThis);

		/// <summary>
		/// Specify alpha (or distance) value to control output of this filter.  For
		/// a non-zero alpha value, only verts, edges, faces, or tetra contained
		/// within the circumsphere (of radius alpha) will be output. Otherwise,
		/// only tetrahedra will be output. Note that the flags AlphaTets, AlphaTris,
		/// AlphaLines, and AlphaVerts control whether these primitives are output
		/// when Alpha is non-zero. (By default all tets, triangles, lines and verts
		/// satisfying the alpha shape criterion are output.)
		/// </summary>
		// Token: 0x06018EFF RID: 102143 RVA: 0x0022C6B8 File Offset: 0x0022A8B8
		public virtual double GetAlphaMinValue()
		{
			return vtkDelaunay3D.vtkDelaunay3D_GetAlphaMinValue_16(base.GetCppThis());
		}

		// Token: 0x06018F00 RID: 102144
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDelaunay3D_GetAlphaTets_17(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether tetrahedra are output for non-zero alpha values.
		/// </summary>
		// Token: 0x06018F01 RID: 102145 RVA: 0x0022C6D8 File Offset: 0x0022A8D8
		public virtual int GetAlphaTets()
		{
			return vtkDelaunay3D.vtkDelaunay3D_GetAlphaTets_17(base.GetCppThis());
		}

		// Token: 0x06018F02 RID: 102146
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDelaunay3D_GetAlphaTris_18(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether triangles are output for non-zero alpha values.
		/// </summary>
		// Token: 0x06018F03 RID: 102147 RVA: 0x0022C6F8 File Offset: 0x0022A8F8
		public virtual int GetAlphaTris()
		{
			return vtkDelaunay3D.vtkDelaunay3D_GetAlphaTris_18(base.GetCppThis());
		}

		// Token: 0x06018F04 RID: 102148
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDelaunay3D_GetAlphaVerts_19(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether vertices are output for non-zero alpha values.
		/// </summary>
		// Token: 0x06018F05 RID: 102149 RVA: 0x0022C718 File Offset: 0x0022A918
		public virtual int GetAlphaVerts()
		{
			return vtkDelaunay3D.vtkDelaunay3D_GetAlphaVerts_19(base.GetCppThis());
		}

		// Token: 0x06018F06 RID: 102150
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDelaunay3D_GetBoundingTriangulation_20(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether bounding triangulation points (and associated
		/// triangles) are included in the output. (These are introduced as an
		/// initial triangulation to begin the triangulation process. This feature
		/// is nice for debugging output.)
		/// </summary>
		// Token: 0x06018F07 RID: 102151 RVA: 0x0022C738 File Offset: 0x0022A938
		public virtual int GetBoundingTriangulation()
		{
			return vtkDelaunay3D.vtkDelaunay3D_GetBoundingTriangulation_20(base.GetCppThis());
		}

		// Token: 0x06018F08 RID: 102152
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDelaunay3D_GetLocator_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get a spatial locator for merging points. By default,
		/// an instance of vtkPointLocator is used.
		/// </summary>
		// Token: 0x06018F09 RID: 102153 RVA: 0x0022C758 File Offset: 0x0022A958
		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDelaunay3D.vtkDelaunay3D_GetLocator_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06018F0A RID: 102154
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkDelaunay3D_GetMTime_22(HandleRef pThis);

		/// <summary>
		/// Return the MTime also considering the locator.
		/// </summary>
		// Token: 0x06018F0B RID: 102155 RVA: 0x0022C7C8 File Offset: 0x0022A9C8
		public override ulong GetMTime()
		{
			return vtkDelaunay3D.vtkDelaunay3D_GetMTime_22(base.GetCppThis());
		}

		// Token: 0x06018F0C RID: 102156
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDelaunay3D_GetNumberOfGenerationsFromBase_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018F0D RID: 102157 RVA: 0x0022C7E8 File Offset: 0x0022A9E8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDelaunay3D.vtkDelaunay3D_GetNumberOfGenerationsFromBase_23(base.GetCppThis(), type);
		}

		// Token: 0x06018F0E RID: 102158
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDelaunay3D_GetNumberOfGenerationsFromBaseType_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018F0F RID: 102159 RVA: 0x0022C808 File Offset: 0x0022AA08
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDelaunay3D.vtkDelaunay3D_GetNumberOfGenerationsFromBaseType_24(type);
		}

		// Token: 0x06018F10 RID: 102160
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDelaunay3D_GetOffset_25(HandleRef pThis);

		/// <summary>
		/// Specify a multiplier to control the size of the initial, bounding
		/// Delaunay triangulation.
		/// </summary>
		// Token: 0x06018F11 RID: 102161 RVA: 0x0022C824 File Offset: 0x0022AA24
		public virtual double GetOffset()
		{
			return vtkDelaunay3D.vtkDelaunay3D_GetOffset_25(base.GetCppThis());
		}

		// Token: 0x06018F12 RID: 102162
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDelaunay3D_GetOffsetMaxValue_26(HandleRef pThis);

		/// <summary>
		/// Specify a multiplier to control the size of the initial, bounding
		/// Delaunay triangulation.
		/// </summary>
		// Token: 0x06018F13 RID: 102163 RVA: 0x0022C844 File Offset: 0x0022AA44
		public virtual double GetOffsetMaxValue()
		{
			return vtkDelaunay3D.vtkDelaunay3D_GetOffsetMaxValue_26(base.GetCppThis());
		}

		// Token: 0x06018F14 RID: 102164
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDelaunay3D_GetOffsetMinValue_27(HandleRef pThis);

		/// <summary>
		/// Specify a multiplier to control the size of the initial, bounding
		/// Delaunay triangulation.
		/// </summary>
		// Token: 0x06018F15 RID: 102165 RVA: 0x0022C864 File Offset: 0x0022AA64
		public virtual double GetOffsetMinValue()
		{
			return vtkDelaunay3D.vtkDelaunay3D_GetOffsetMinValue_27(base.GetCppThis());
		}

		// Token: 0x06018F16 RID: 102166
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDelaunay3D_GetOutputPointsPrecision_28(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06018F17 RID: 102167 RVA: 0x0022C884 File Offset: 0x0022AA84
		public virtual int GetOutputPointsPrecision()
		{
			return vtkDelaunay3D.vtkDelaunay3D_GetOutputPointsPrecision_28(base.GetCppThis());
		}

		// Token: 0x06018F18 RID: 102168
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDelaunay3D_GetTolerance_29(HandleRef pThis);

		/// <summary>
		/// Specify a tolerance to control discarding of closely spaced points.
		/// This tolerance is specified as a fraction of the diagonal length of
		/// the bounding box of the points.
		/// </summary>
		// Token: 0x06018F19 RID: 102169 RVA: 0x0022C8A4 File Offset: 0x0022AAA4
		public virtual double GetTolerance()
		{
			return vtkDelaunay3D.vtkDelaunay3D_GetTolerance_29(base.GetCppThis());
		}

		// Token: 0x06018F1A RID: 102170
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDelaunay3D_GetToleranceMaxValue_30(HandleRef pThis);

		/// <summary>
		/// Specify a tolerance to control discarding of closely spaced points.
		/// This tolerance is specified as a fraction of the diagonal length of
		/// the bounding box of the points.
		/// </summary>
		// Token: 0x06018F1B RID: 102171 RVA: 0x0022C8C4 File Offset: 0x0022AAC4
		public virtual double GetToleranceMaxValue()
		{
			return vtkDelaunay3D.vtkDelaunay3D_GetToleranceMaxValue_30(base.GetCppThis());
		}

		// Token: 0x06018F1C RID: 102172
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDelaunay3D_GetToleranceMinValue_31(HandleRef pThis);

		/// <summary>
		/// Specify a tolerance to control discarding of closely spaced points.
		/// This tolerance is specified as a fraction of the diagonal length of
		/// the bounding box of the points.
		/// </summary>
		// Token: 0x06018F1D RID: 102173 RVA: 0x0022C8E4 File Offset: 0x0022AAE4
		public virtual double GetToleranceMinValue()
		{
			return vtkDelaunay3D.vtkDelaunay3D_GetToleranceMinValue_31(base.GetCppThis());
		}

		// Token: 0x06018F1E RID: 102174
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDelaunay3D_InitPointInsertion_32(HandleRef pThis, IntPtr center, double length, long numPts, HandleRef points, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This is a helper method used with InsertPoint() to create
		/// tetrahedronalizations of points. Its purpose is construct an initial
		/// Delaunay triangulation into which to inject other points. You must
		/// specify the center of a cubical bounding box and its length, as well
		/// as the number of points to insert. The method returns a pointer to
		/// an unstructured grid. Use this pointer to manipulate the mesh as
		/// necessary. You must delete (with Delete()) the mesh when done.
		/// Note: This initialization method places points forming bounding octahedron
		/// at the end of the Mesh's point list. That is, InsertPoint() assumes that
		/// you will be inserting points between (0,numPtsToInsert-1).
		/// </summary>
		// Token: 0x06018F1F RID: 102175 RVA: 0x0022C904 File Offset: 0x0022AB04
		public vtkUnstructuredGrid InitPointInsertion(IntPtr center, double length, long numPts, vtkPoints points)
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDelaunay3D.vtkDelaunay3D_InitPointInsertion_32(base.GetCppThis(), center, length, numPts, (points == null) ? default(HandleRef) : points.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06018F20 RID: 102176
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay3D_InsertPoint_33(HandleRef pThis, HandleRef Mesh, HandleRef points, long id, IntPtr x, HandleRef holeTetras);

		/// <summary>
		/// This is a helper method used with InitPointInsertion() to create
		/// tetrahedronalizations of points. Its purpose is to inject point at
		/// coordinates specified into tetrahedronalization. The point id is an index
		/// into the list of points in the mesh structure.  (See
		/// vtkDelaunay3D::InitPointInsertion() for more information.)  When you have
		/// completed inserting points, traverse the mesh structure to extract desired
		/// tetrahedra (or tetra faces and edges).The holeTetras id list lists all the
		/// tetrahedra that are deleted (invalid) in the mesh structure.
		/// </summary>
		// Token: 0x06018F21 RID: 102177 RVA: 0x0022C990 File Offset: 0x0022AB90
		public void InsertPoint(vtkUnstructuredGrid Mesh, vtkPoints points, long id, IntPtr x, vtkIdList holeTetras)
		{
			vtkDelaunay3D.vtkDelaunay3D_InsertPoint_33(base.GetCppThis(), (Mesh == null) ? default(HandleRef) : Mesh.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis(), id, x, (holeTetras == null) ? default(HandleRef) : holeTetras.GetCppThis());
		}

		// Token: 0x06018F22 RID: 102178
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDelaunay3D_IsA_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018F23 RID: 102179 RVA: 0x0022C9F0 File Offset: 0x0022ABF0
		public override int IsA(string type)
		{
			return vtkDelaunay3D.vtkDelaunay3D_IsA_34(base.GetCppThis(), type);
		}

		// Token: 0x06018F24 RID: 102180
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDelaunay3D_IsTypeOf_35([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018F25 RID: 102181 RVA: 0x0022CA10 File Offset: 0x0022AC10
		public new static int IsTypeOf(string type)
		{
			return vtkDelaunay3D.vtkDelaunay3D_IsTypeOf_35(type);
		}

		// Token: 0x06018F26 RID: 102182
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDelaunay3D_NewInstance_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018F27 RID: 102183 RVA: 0x0022CA2C File Offset: 0x0022AC2C
		public new vtkDelaunay3D NewInstance()
		{
			vtkDelaunay3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDelaunay3D.vtkDelaunay3D_NewInstance_37(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDelaunay3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018F28 RID: 102184
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDelaunay3D_SafeDownCast_38(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018F29 RID: 102185 RVA: 0x0022CA88 File Offset: 0x0022AC88
		public new static vtkDelaunay3D SafeDownCast(vtkObjectBase o)
		{
			vtkDelaunay3D vtkDelaunay3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDelaunay3D.vtkDelaunay3D_SafeDownCast_38((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDelaunay3D = (vtkDelaunay3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDelaunay3D.Register(null);
				}
			}
			return vtkDelaunay3D;
		}

		// Token: 0x06018F2A RID: 102186
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay3D_SetAlpha_39(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify alpha (or distance) value to control output of this filter.  For
		/// a non-zero alpha value, only verts, edges, faces, or tetra contained
		/// within the circumsphere (of radius alpha) will be output. Otherwise,
		/// only tetrahedra will be output. Note that the flags AlphaTets, AlphaTris,
		/// AlphaLines, and AlphaVerts control whether these primitives are output
		/// when Alpha is non-zero. (By default all tets, triangles, lines and verts
		/// satisfying the alpha shape criterion are output.)
		/// </summary>
		// Token: 0x06018F2B RID: 102187 RVA: 0x0022CB07 File Offset: 0x0022AD07
		public virtual void SetAlpha(double _arg)
		{
			vtkDelaunay3D.vtkDelaunay3D_SetAlpha_39(base.GetCppThis(), _arg);
		}

		// Token: 0x06018F2C RID: 102188
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay3D_SetAlphaLines_40(HandleRef pThis, int _arg);

		/// <summary>
		/// Boolean controls whether lines are output for non-zero alpha values.
		/// </summary>
		// Token: 0x06018F2D RID: 102189 RVA: 0x0022CB17 File Offset: 0x0022AD17
		public virtual void SetAlphaLines(int _arg)
		{
			vtkDelaunay3D.vtkDelaunay3D_SetAlphaLines_40(base.GetCppThis(), _arg);
		}

		// Token: 0x06018F2E RID: 102190
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay3D_SetAlphaTets_41(HandleRef pThis, int _arg);

		/// <summary>
		/// Boolean controls whether tetrahedra are output for non-zero alpha values.
		/// </summary>
		// Token: 0x06018F2F RID: 102191 RVA: 0x0022CB27 File Offset: 0x0022AD27
		public virtual void SetAlphaTets(int _arg)
		{
			vtkDelaunay3D.vtkDelaunay3D_SetAlphaTets_41(base.GetCppThis(), _arg);
		}

		// Token: 0x06018F30 RID: 102192
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay3D_SetAlphaTris_42(HandleRef pThis, int _arg);

		/// <summary>
		/// Boolean controls whether triangles are output for non-zero alpha values.
		/// </summary>
		// Token: 0x06018F31 RID: 102193 RVA: 0x0022CB37 File Offset: 0x0022AD37
		public virtual void SetAlphaTris(int _arg)
		{
			vtkDelaunay3D.vtkDelaunay3D_SetAlphaTris_42(base.GetCppThis(), _arg);
		}

		// Token: 0x06018F32 RID: 102194
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay3D_SetAlphaVerts_43(HandleRef pThis, int _arg);

		/// <summary>
		/// Boolean controls whether vertices are output for non-zero alpha values.
		/// </summary>
		// Token: 0x06018F33 RID: 102195 RVA: 0x0022CB47 File Offset: 0x0022AD47
		public virtual void SetAlphaVerts(int _arg)
		{
			vtkDelaunay3D.vtkDelaunay3D_SetAlphaVerts_43(base.GetCppThis(), _arg);
		}

		// Token: 0x06018F34 RID: 102196
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay3D_SetBoundingTriangulation_44(HandleRef pThis, int _arg);

		/// <summary>
		/// Boolean controls whether bounding triangulation points (and associated
		/// triangles) are included in the output. (These are introduced as an
		/// initial triangulation to begin the triangulation process. This feature
		/// is nice for debugging output.)
		/// </summary>
		// Token: 0x06018F35 RID: 102197 RVA: 0x0022CB57 File Offset: 0x0022AD57
		public virtual void SetBoundingTriangulation(int _arg)
		{
			vtkDelaunay3D.vtkDelaunay3D_SetBoundingTriangulation_44(base.GetCppThis(), _arg);
		}

		// Token: 0x06018F36 RID: 102198
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay3D_SetLocator_45(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Set / get a spatial locator for merging points. By default,
		/// an instance of vtkPointLocator is used.
		/// </summary>
		// Token: 0x06018F37 RID: 102199 RVA: 0x0022CB68 File Offset: 0x0022AD68
		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkDelaunay3D.vtkDelaunay3D_SetLocator_45(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x06018F38 RID: 102200
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay3D_SetOffset_46(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify a multiplier to control the size of the initial, bounding
		/// Delaunay triangulation.
		/// </summary>
		// Token: 0x06018F39 RID: 102201 RVA: 0x0022CB97 File Offset: 0x0022AD97
		public virtual void SetOffset(double _arg)
		{
			vtkDelaunay3D.vtkDelaunay3D_SetOffset_46(base.GetCppThis(), _arg);
		}

		// Token: 0x06018F3A RID: 102202
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay3D_SetOutputPointsPrecision_47(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06018F3B RID: 102203 RVA: 0x0022CBA7 File Offset: 0x0022ADA7
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkDelaunay3D.vtkDelaunay3D_SetOutputPointsPrecision_47(base.GetCppThis(), _arg);
		}

		// Token: 0x06018F3C RID: 102204
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDelaunay3D_SetTolerance_48(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify a tolerance to control discarding of closely spaced points.
		/// This tolerance is specified as a fraction of the diagonal length of
		/// the bounding box of the points.
		/// </summary>
		// Token: 0x06018F3D RID: 102205 RVA: 0x0022CBB7 File Offset: 0x0022ADB7
		public virtual void SetTolerance(double _arg)
		{
			vtkDelaunay3D.vtkDelaunay3D_SetTolerance_48(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B73 RID: 7027
		public new const string MRFullTypeName = "Kitware.VTK.vtkDelaunay3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B74 RID: 7028
		public new static readonly string MRClassNameKey = "class vtkDelaunay3D";
	}
}
