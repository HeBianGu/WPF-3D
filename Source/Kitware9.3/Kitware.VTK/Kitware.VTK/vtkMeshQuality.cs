using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMeshQuality
	/// </summary>
	/// <remarks>
	///    Calculate functions of quality of the elements of a mesh
	///
	/// vtkMeshQuality computes one or more functions of (geometric)
	/// quality for each 2-D and 3-D cell (triangle, quadrilateral, tetrahedron, pyramid,
	/// wedge, or hexahedron) of a mesh. These functions of quality are then averaged
	/// over the entire mesh. The minimum, average, maximum, and unbiased variance
	/// of quality for each type of cell is stored in the output mesh's FieldData.
	/// The FieldData arrays are named "Mesh Triangle Quality,"
	/// "Mesh Quadrilateral Quality," "Mesh Tetrahedron Quality," "Mesh Pyramid Quality,"
	/// "Mesh Wedge Quality," and "Mesh Hexahedron Quality." Each array has
	/// a single tuple with 5 components. The first 4 components are the quality
	/// statistics mentioned above; the final value is the number of cells of the
	/// given type. This final component makes aggregation of statistics for
	/// distributed mesh data possible.
	///
	/// By default, the per-cell quality is added to the mesh's cell data, in
	/// an array named "Quality." Cell types not supported by
	/// this filter will have an entry of 0. Use SaveCellQualityOff() to
	/// store only the final statistics.
	///
	/// This version of the filter written by Philippe Pebay and David Thompson
	/// overtakes an older version written by Leila Baghdadi, Hanif Ladak, and
	/// David Steinman at the Imaging Research Labs, Robarts Research Institute.
	/// That version only supported tetrahedral radius ratio. See the
	/// CompatibilityModeOn() member for information on how to make this filter
	/// behave like the previous implementation.
	/// For more information on the triangle quality functions of this class, cf.
	/// Pebay &amp; Baker 2003, Analysis of triangle quality measures, Math Comp 72:244.
	/// For more information on the quadrangle quality functions of this class, cf.
	/// Pebay 2004, Planar Quadrangle Quality Measures, Eng Comp 20:2.
	///
	/// @warning
	/// While more general than before, this class does not address many
	/// cell types, including triangle strips and fans in 2D (among others).
	/// Most quadrilateral quality functions are intended for planar quadrilaterals
	/// only.
	/// The minimal angle is not, strictly speaking, a quality function, but it is
	/// provided because of its usage by many authors.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	/// </remarks>
	// Token: 0x02000901 RID: 2305
	public class vtkMeshQuality : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017D27 RID: 97575 RVA: 0x002161AB File Offset: 0x002143AB
		static vtkMeshQuality()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMeshQuality.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMeshQuality"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017D28 RID: 97576 RVA: 0x002161D3 File Offset: 0x002143D3
		public vtkMeshQuality(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017D29 RID: 97577
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMeshQuality_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017D2A RID: 97578 RVA: 0x002161E4 File Offset: 0x002143E4
		public new static vtkMeshQuality New()
		{
			vtkMeshQuality result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMeshQuality.vtkMeshQuality_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMeshQuality)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017D2B RID: 97579 RVA: 0x00216238 File Offset: 0x00214438
		public vtkMeshQuality() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMeshQuality.vtkMeshQuality_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017D2C RID: 97580 RVA: 0x0021627C File Offset: 0x0021447C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017D2D RID: 97581
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkMeshQuality.QualityMeasureTypes vtkMeshQuality_GetHexQualityMeasure_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of hexahedra.
		/// The default is MAX_ASPECT_FROBENIUS and valid values also include
		/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
		/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
		/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
		/// </summary>
		// Token: 0x06017D2E RID: 97582 RVA: 0x00216288 File Offset: 0x00214488
		public virtual vtkMeshQuality.QualityMeasureTypes GetHexQualityMeasure()
		{
			return vtkMeshQuality.vtkMeshQuality_GetHexQualityMeasure_01(base.GetCppThis());
		}

		// Token: 0x06017D2F RID: 97583
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMeshQuality_GetLinearApproximation_02(HandleRef pThis);

		/// <summary>
		/// If set to true, then this filter will output 2 quality arrays instead of one.
		/// The second array is names "Quality (Linear Approx)" and features measure for all non-linear
		/// cells in addition to the linear ones, but treated like if they were linear.
		///
		/// @note In the array "Quality", any non-linear cell quality is set to NaN.
		/// </summary>
		// Token: 0x06017D30 RID: 97584 RVA: 0x002162A8 File Offset: 0x002144A8
		public virtual bool GetLinearApproximation()
		{
			return vtkMeshQuality.vtkMeshQuality_GetLinearApproximation_02(base.GetCppThis()) != 0;
		}

		// Token: 0x06017D31 RID: 97585
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMeshQuality_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017D32 RID: 97586 RVA: 0x002162D0 File Offset: 0x002144D0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMeshQuality.vtkMeshQuality_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06017D33 RID: 97587
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMeshQuality_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017D34 RID: 97588 RVA: 0x002162F0 File Offset: 0x002144F0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMeshQuality.vtkMeshQuality_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06017D35 RID: 97589
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkMeshQuality.QualityMeasureTypes vtkMeshQuality_GetPyramidQualityMeasure_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of pyramids.
		/// The default is SHAPE and valid values also include
		/// EQUIANGLE_SKEW, JACOBIAN, SCALED_JACOBIAN, and VOLUME.
		/// </summary>
		// Token: 0x06017D36 RID: 97590 RVA: 0x0021630C File Offset: 0x0021450C
		public virtual vtkMeshQuality.QualityMeasureTypes GetPyramidQualityMeasure()
		{
			return vtkMeshQuality.vtkMeshQuality_GetPyramidQualityMeasure_05(base.GetCppThis());
		}

		// Token: 0x06017D37 RID: 97591
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkMeshQuality.QualityMeasureTypes vtkMeshQuality_GetQuadQualityMeasure_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
		/// The default is EDGE_RATIO and valid values also include
		/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
		/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
		/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
		/// and EQUIANGLE_SKEW.
		///
		/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
		/// quadrilaterals only; use at your own risk if you really want to assess non-planar
		/// quadrilateral quality with those.
		/// </summary>
		// Token: 0x06017D38 RID: 97592 RVA: 0x0021632C File Offset: 0x0021452C
		public virtual vtkMeshQuality.QualityMeasureTypes GetQuadQualityMeasure()
		{
			return vtkMeshQuality.vtkMeshQuality_GetQuadQualityMeasure_06(base.GetCppThis());
		}

		// Token: 0x06017D39 RID: 97593
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMeshQuality_GetRatio_07(HandleRef pThis);

		/// <summary>
		/// These methods are deprecated. Use Get/SetSaveCellQuality() instead.
		///
		/// Formerly, SetRatio could be used to disable computation
		/// of the tetrahedral radius ratio so that volume alone could be computed.
		/// Now, cell quality is always computed, but you may decide not
		/// to store the result for each cell.
		/// This allows average cell quality of a mesh to be
		/// calculated without requiring per-cell storage.
		/// </summary>
		// Token: 0x06017D3A RID: 97594 RVA: 0x0021634C File Offset: 0x0021454C
		public int GetRatio()
		{
			return vtkMeshQuality.vtkMeshQuality_GetRatio_07(base.GetCppThis());
		}

		// Token: 0x06017D3B RID: 97595
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMeshQuality_GetSaveCellQuality_08(HandleRef pThis);

		/// <summary>
		/// This variable controls whether or not cell quality is stored as
		/// cell data in the resulting mesh or discarded (leaving only the
		/// aggregate quality average of the entire mesh, recorded in the
		/// FieldData).
		/// </summary>
		// Token: 0x06017D3C RID: 97596 RVA: 0x0021636C File Offset: 0x0021456C
		public virtual int GetSaveCellQuality()
		{
			return vtkMeshQuality.vtkMeshQuality_GetSaveCellQuality_08(base.GetCppThis());
		}

		// Token: 0x06017D3D RID: 97597
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkMeshQuality.QualityMeasureTypes vtkMeshQuality_GetTetQualityMeasure_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of tetrahedra.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
		/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
		/// </summary>
		// Token: 0x06017D3E RID: 97598 RVA: 0x0021638C File Offset: 0x0021458C
		public virtual vtkMeshQuality.QualityMeasureTypes GetTetQualityMeasure()
		{
			return vtkMeshQuality.vtkMeshQuality_GetTetQualityMeasure_09(base.GetCppThis());
		}

		// Token: 0x06017D3F RID: 97599
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkMeshQuality.QualityMeasureTypes vtkMeshQuality_GetTriangleQualityMeasure_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of triangles.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
		/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
		/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
		/// </summary>
		// Token: 0x06017D40 RID: 97600 RVA: 0x002163AC File Offset: 0x002145AC
		public virtual vtkMeshQuality.QualityMeasureTypes GetTriangleQualityMeasure()
		{
			return vtkMeshQuality.vtkMeshQuality_GetTriangleQualityMeasure_10(base.GetCppThis());
		}

		// Token: 0x06017D41 RID: 97601
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkMeshQuality.QualityMeasureTypes vtkMeshQuality_GetWedgeQualityMeasure_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of wedges.
		/// The default is EDGE_RATIO and valid values also include
		/// CONDITION, DISTORTION, EQUIANGLE_SKEW, JACOBIAN, MAX_ASPECT_FROBENIUS, MAX_STRETCH,
		/// MEAN_ASPECT_FROBENIUS, SCALED_JACOBIAN, SHAPE, and VOLUME.
		/// </summary>
		// Token: 0x06017D42 RID: 97602 RVA: 0x002163CC File Offset: 0x002145CC
		public virtual vtkMeshQuality.QualityMeasureTypes GetWedgeQualityMeasure()
		{
			return vtkMeshQuality.vtkMeshQuality_GetWedgeQualityMeasure_11(base.GetCppThis());
		}

		// Token: 0x06017D43 RID: 97603
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_HexCondition_12(HandleRef cell);

		/// <summary>
		/// Calculate the condition of a hexahedron.
		/// The condition of a hexahedron is equivalent to HexMaxAspectFrobenius.
		/// </summary>
		// Token: 0x06017D44 RID: 97604 RVA: 0x002163EC File Offset: 0x002145EC
		public static double HexCondition(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexCondition_12((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D45 RID: 97605
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_HexDiagonal_13(HandleRef cell);

		/// <summary>
		/// Calculate the diagonal of a hexahedron.
		/// The diagonal of a hexahedron Minimum diagonal length / maximum diagonal length.
		/// </summary>
		// Token: 0x06017D46 RID: 97606 RVA: 0x0021641C File Offset: 0x0021461C
		public static double HexDiagonal(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexDiagonal_13((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D47 RID: 97607
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_HexDimension_14(HandleRef cell);

		/// <summary>
		/// Calculate the dimension of a hexahedron.
		/// The dimension of a hexahedron is the Pronto-specific characteristic length
		/// for stable time step calculation, where characteristic length = Volume / 2 grad Volume.
		/// </summary>
		// Token: 0x06017D48 RID: 97608 RVA: 0x0021644C File Offset: 0x0021464C
		public static double HexDimension(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexDimension_14((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D49 RID: 97609
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_HexDistortion_15(HandleRef cell);

		/// <summary>
		/// Calculate the distortion of a hexahedron.
		/// The distortion of a hexahedron is {min(|J|)/actual volume} * parent volume,
		/// parent volume = 8 for a hexahedron.
		/// </summary>
		// Token: 0x06017D4A RID: 97610 RVA: 0x0021647C File Offset: 0x0021467C
		public static double HexDistortion(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexDistortion_15((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D4B RID: 97611
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_HexEdgeRatio_16(HandleRef cell);

		/// <summary>
		/// Calculate the edge ratio of a hexahedron.
		/// The edge ratio of a hexahedron \f$H\f$ is:
		/// \f$\frac{|H|_\infty}{|H|_0}\f$,
		/// where \f$|H|_\infty\f$ and \f$|H|_0\f$ respectively denote the greatest and
		/// the smallest edge lengths of \f$H\f$.
		/// </summary>
		// Token: 0x06017D4C RID: 97612 RVA: 0x002164AC File Offset: 0x002146AC
		public static double HexEdgeRatio(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexEdgeRatio_16((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D4D RID: 97613
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_HexEquiangleSkew_17(HandleRef cell);

		/// <summary>
		/// Calculate the equiangle skew of a hexahedron.
		/// </summary>
		// Token: 0x06017D4E RID: 97614 RVA: 0x002164DC File Offset: 0x002146DC
		public static double HexEquiangleSkew(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexEquiangleSkew_17((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D4F RID: 97615
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_HexJacobian_18(HandleRef cell);

		/// <summary>
		/// Calculate the Jacobian of a hexahedron.
		/// The jacobian of a hexahedron is the minimum point-wise of local map at
		/// 8 corners &amp; center of the hexahedron.
		/// </summary>
		// Token: 0x06017D50 RID: 97616 RVA: 0x0021650C File Offset: 0x0021470C
		public static double HexJacobian(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexJacobian_18((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D51 RID: 97617
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_HexMaxAspectFrobenius_19(HandleRef cell);

		/// <summary>
		/// Calculate the maximal Frobenius aspect of the 8 corner tetrahedra of a hexahedron,
		/// when the reference tetrahedral elements are right isosceles at the hexahedron vertices.
		/// </summary>
		// Token: 0x06017D52 RID: 97618 RVA: 0x0021653C File Offset: 0x0021473C
		public static double HexMaxAspectFrobenius(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexMaxAspectFrobenius_19((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D53 RID: 97619
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_HexMaxEdgeRatio_20(HandleRef cell);

		/// <summary>
		/// Calculate the maximum edge ratio of a hexahedron at its center.
		/// </summary>
		// Token: 0x06017D54 RID: 97620 RVA: 0x0021656C File Offset: 0x0021476C
		public static double HexMaxEdgeRatio(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexMaxEdgeRatio_20((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D55 RID: 97621
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_HexMedAspectFrobenius_21(HandleRef cell);

		/// <summary>
		/// Calculate the average Frobenius aspect of the 8 corner tetrahedra of a hexahedron,
		/// when the reference tetrahedral elements are right isosceles at the hexahedron vertices.
		/// </summary>
		// Token: 0x06017D56 RID: 97622 RVA: 0x0021659C File Offset: 0x0021479C
		public static double HexMedAspectFrobenius(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexMedAspectFrobenius_21((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D57 RID: 97623
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_HexNodalJacobianRatio_22(HandleRef cell);

		/// <summary>
		/// Calculate the nodal Jacobian ratio of a hexahedron.
		/// The nodal Jacobian ratio of a hexahedron is min(Jacobian) / max(Jacobian) over all nodes.
		/// </summary>
		// Token: 0x06017D58 RID: 97624 RVA: 0x002165CC File Offset: 0x002147CC
		public static double HexNodalJacobianRatio(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexNodalJacobianRatio_22((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D59 RID: 97625
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_HexOddy_23(HandleRef cell);

		/// <summary>
		/// Calculate the oddy of a hexahedron.
		/// The oddy of a hexahedron is the general distortion measure based on left
		/// Cauchy-Green Tensor.
		/// </summary>
		// Token: 0x06017D5A RID: 97626 RVA: 0x002165FC File Offset: 0x002147FC
		public static double HexOddy(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexOddy_23((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D5B RID: 97627
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_HexRelativeSizeSquared_24(HandleRef cell);

		/// <summary>
		/// Calculate the relative size squared of a hexahedron.
		/// The relative size squared of a hexahedron is Min(J, 1 / J), where J is determinant
		/// of weighted Jacobian matrix.
		///
		/// Note: HexRelativeSizeSquared will return 0.0 if the MeshQuality filter has NOT
		/// been executed, because it relies on the average hex size.
		/// </summary>
		// Token: 0x06017D5C RID: 97628 RVA: 0x0021662C File Offset: 0x0021482C
		public static double HexRelativeSizeSquared(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexRelativeSizeSquared_24((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D5D RID: 97629
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_HexScaledJacobian_25(HandleRef cell);

		/// <summary>
		/// Calculate the scaled Jacobian of a hexahedron.
		/// The scaled jacobian of a hexahedron is the minimum Jacobian divided
		/// by the lengths of 3 edge vectors.
		/// </summary>
		// Token: 0x06017D5E RID: 97630 RVA: 0x0021665C File Offset: 0x0021485C
		public static double HexScaledJacobian(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexScaledJacobian_25((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D5F RID: 97631
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_HexShape_26(HandleRef cell);

		/// <summary>
		/// Calculate the shape of a hexahedron.
		/// The shape of a hexahedron is 3 / Mean Ratio of weighted Jacobian matrix.
		/// </summary>
		// Token: 0x06017D60 RID: 97632 RVA: 0x0021668C File Offset: 0x0021488C
		public static double HexShape(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexShape_26((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D61 RID: 97633
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_HexShapeAndSize_27(HandleRef cell);

		/// <summary>
		/// Calculate the shape and size of a hexahedron.
		/// The shape and size of a hexahedron is product of shape and average size.
		///
		/// Note: HexShapeAndSize will return 0.0 if the MeshQuality filter has NOT
		/// been executed, because it relies on the average hex size.
		/// </summary>
		// Token: 0x06017D62 RID: 97634 RVA: 0x002166BC File Offset: 0x002148BC
		public static double HexShapeAndSize(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexShapeAndSize_27((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D63 RID: 97635
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_HexShear_28(HandleRef cell);

		/// <summary>
		/// Calculate the shear of a hexahedron.
		/// The shear of a hexahedron is 3 / Mean Ratio of Jacobian Skew matrix.
		/// </summary>
		// Token: 0x06017D64 RID: 97636 RVA: 0x002166EC File Offset: 0x002148EC
		public static double HexShear(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexShear_28((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D65 RID: 97637
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_HexShearAndSize_29(HandleRef cell);

		/// <summary>
		/// Calculate the shear and size of a hexahedron.
		/// The shear and size of a hexahedron is product of shear and average size.
		///
		/// Note: HexShearAndSize will return 0.0 if the MeshQuality filter has NOT
		/// been executed, because it relies on the average hex size.
		/// </summary>
		// Token: 0x06017D66 RID: 97638 RVA: 0x0021671C File Offset: 0x0021491C
		public static double HexShearAndSize(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexShearAndSize_29((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D67 RID: 97639
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_HexSkew_30(HandleRef cell);

		/// <summary>
		/// Calculate the skew of a hexahedron.
		/// The skew of a hexahedron is the maximum |cos A|, where A is the angle
		/// between edges at the hexahedron center.
		/// </summary>
		// Token: 0x06017D68 RID: 97640 RVA: 0x0021674C File Offset: 0x0021494C
		public static double HexSkew(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexSkew_30((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D69 RID: 97641
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_HexStretch_31(HandleRef cell);

		/// <summary>
		/// Calculate the stretch of a hexahedron.
		/// The stretch of a hexahedron is Sqrt(3) * minimum edge length / maximum diagonal length.
		/// </summary>
		// Token: 0x06017D6A RID: 97642 RVA: 0x0021677C File Offset: 0x0021497C
		public static double HexStretch(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexStretch_31((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D6B RID: 97643
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_HexTaper_32(HandleRef cell);

		/// <summary>
		/// Calculate the taper of a hexahedron.
		/// The taper of a hexahedron is the ratio of lengths derived from opposite edges.
		/// </summary>
		// Token: 0x06017D6C RID: 97644 RVA: 0x002167AC File Offset: 0x002149AC
		public static double HexTaper(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexTaper_32((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D6D RID: 97645
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_HexVolume_33(HandleRef cell);

		/// <summary>
		/// Calculate the volume of a hexahedron.
		/// The volume of a hexahedron is the Jacobian at the hexahedron center.
		/// </summary>
		// Token: 0x06017D6E RID: 97646 RVA: 0x002167DC File Offset: 0x002149DC
		public static double HexVolume(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_HexVolume_33((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D6F RID: 97647
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMeshQuality_IsA_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017D70 RID: 97648 RVA: 0x0021680C File Offset: 0x00214A0C
		public override int IsA(string type)
		{
			return vtkMeshQuality.vtkMeshQuality_IsA_34(base.GetCppThis(), type);
		}

		// Token: 0x06017D71 RID: 97649
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMeshQuality_IsTypeOf_35([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017D72 RID: 97650 RVA: 0x0021682C File Offset: 0x00214A2C
		public new static int IsTypeOf(string type)
		{
			return vtkMeshQuality.vtkMeshQuality_IsTypeOf_35(type);
		}

		// Token: 0x06017D73 RID: 97651
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_LinearApproximationOff_36(HandleRef pThis);

		/// <summary>
		/// If set to true, then this filter will output 2 quality arrays instead of one.
		/// The second array is names "Quality (Linear Approx)" and features measure for all non-linear
		/// cells in addition to the linear ones, but treated like if they were linear.
		///
		/// @note In the array "Quality", any non-linear cell quality is set to NaN.
		/// </summary>
		// Token: 0x06017D74 RID: 97652 RVA: 0x00216846 File Offset: 0x00214A46
		public virtual void LinearApproximationOff()
		{
			vtkMeshQuality.vtkMeshQuality_LinearApproximationOff_36(base.GetCppThis());
		}

		// Token: 0x06017D75 RID: 97653
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_LinearApproximationOn_37(HandleRef pThis);

		/// <summary>
		/// If set to true, then this filter will output 2 quality arrays instead of one.
		/// The second array is names "Quality (Linear Approx)" and features measure for all non-linear
		/// cells in addition to the linear ones, but treated like if they were linear.
		///
		/// @note In the array "Quality", any non-linear cell quality is set to NaN.
		/// </summary>
		// Token: 0x06017D76 RID: 97654 RVA: 0x00216855 File Offset: 0x00214A55
		public virtual void LinearApproximationOn()
		{
			vtkMeshQuality.vtkMeshQuality_LinearApproximationOn_37(base.GetCppThis());
		}

		// Token: 0x06017D77 RID: 97655
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMeshQuality_NewInstance_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017D78 RID: 97656 RVA: 0x00216864 File Offset: 0x00214A64
		public new vtkMeshQuality NewInstance()
		{
			vtkMeshQuality result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMeshQuality.vtkMeshQuality_NewInstance_39(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMeshQuality)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017D79 RID: 97657
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_PyramidEquiangleSkew_40(HandleRef cell);

		/// <summary>
		/// Calculate the equiangle skew of a pyramid.
		/// </summary>
		// Token: 0x06017D7A RID: 97658 RVA: 0x002168C0 File Offset: 0x00214AC0
		public static double PyramidEquiangleSkew(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_PyramidEquiangleSkew_40((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D7B RID: 97659
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_PyramidJacobian_41(HandleRef cell);

		/// <summary>
		/// Calculate the Jacobian of a pyramid.
		/// The jacobian of a tetrahedron is the minimum point-wise volume at any corner.
		/// </summary>
		// Token: 0x06017D7C RID: 97660 RVA: 0x002168F0 File Offset: 0x00214AF0
		public static double PyramidJacobian(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_PyramidJacobian_41((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D7D RID: 97661
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_PyramidScaledJacobian_42(HandleRef cell);

		/// <summary>
		/// Calculate the Jacobian of a pyramid.
		/// The jacobian of a tetrahedron is the minimum point-wise volume at any corner.
		/// </summary>
		// Token: 0x06017D7E RID: 97662 RVA: 0x00216920 File Offset: 0x00214B20
		public static double PyramidScaledJacobian(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_PyramidScaledJacobian_42((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D7F RID: 97663
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_PyramidShape_43(HandleRef cell);

		/// <summary>
		/// Calculate the shape of a pyramid.
		/// The shape of a pyramid is 4 divided by the minimum mean ratio of the
		/// Jacobian matrix at each element corner.
		/// </summary>
		// Token: 0x06017D80 RID: 97664 RVA: 0x00216950 File Offset: 0x00214B50
		public static double PyramidShape(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_PyramidShape_43((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D81 RID: 97665
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_PyramidVolume_44(HandleRef cell);

		/// <summary>
		/// Calculate the volume of a pyramid.
		/// </summary>
		// Token: 0x06017D82 RID: 97666 RVA: 0x00216980 File Offset: 0x00214B80
		public static double PyramidVolume(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_PyramidVolume_44((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D83 RID: 97667
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_QuadArea_45(HandleRef cell);

		/// <summary>
		/// Calculate the area of a quadrilateral.
		/// The area of a quadrilateral is the Jacobian at quad center.
		/// </summary>
		// Token: 0x06017D84 RID: 97668 RVA: 0x002169B0 File Offset: 0x00214BB0
		public static double QuadArea(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadArea_45((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D85 RID: 97669
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_QuadAspectRatio_46(HandleRef cell);

		/// <summary>
		/// Calculate the aspect ratio of a planar quadrilateral.
		/// The aspect ratio of a planar quadrilateral \f$q\f$ is:
		/// \f$\frac{|q|_1|q|_\infty}{4{\cal A}}\f$,
		/// where \f$|q|_1\f$, \f$|q|_\infty\f$ and \f${\cal A}\f$ respectively denote the
		/// perimeter, the greatest edge length and the area of \f$q\f$.
		/// </summary>
		// Token: 0x06017D86 RID: 97670 RVA: 0x002169E0 File Offset: 0x00214BE0
		public static double QuadAspectRatio(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadAspectRatio_46((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D87 RID: 97671
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_QuadCondition_47(HandleRef cell);

		/// <summary>
		/// Calculate the condition number of a quadrilateral.
		/// The condition number of a quadrilateral is the (maximum) condition number of the
		/// Jacobian matrix at the 4 corners.
		/// </summary>
		// Token: 0x06017D88 RID: 97672 RVA: 0x00216A10 File Offset: 0x00214C10
		public static double QuadCondition(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadCondition_47((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D89 RID: 97673
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_QuadDistortion_48(HandleRef cell);

		/// <summary>
		/// Calculate the distortion of a quadrilateral.
		/// The distortion of a quadrilateral is {min(|J|)/actual area} * parent area,
		/// parent area = 4 for quad.
		/// </summary>
		// Token: 0x06017D8A RID: 97674 RVA: 0x00216A40 File Offset: 0x00214C40
		public static double QuadDistortion(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadDistortion_48((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D8B RID: 97675
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_QuadEdgeRatio_49(HandleRef cell);

		/// <summary>
		/// Calculate the edge ratio of a quadrilateral.
		/// The edge ratio of a quadrilateral \f$q\f$ is:
		/// \f$\frac{|q|_\infty}{|q|_0}\f$,
		/// where \f$|q|_\infty\f$ and \f$|q|_0\f$ respectively denote the greatest and
		/// the smallest edge lengths of \f$q\f$.
		/// </summary>
		// Token: 0x06017D8C RID: 97676 RVA: 0x00216A70 File Offset: 0x00214C70
		public static double QuadEdgeRatio(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadEdgeRatio_49((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D8D RID: 97677
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_QuadEquiangleSkew_50(HandleRef cell);

		/// <summary>
		/// Calculate the equiangle skew of a quadrilateral.
		/// </summary>
		// Token: 0x06017D8E RID: 97678 RVA: 0x00216AA0 File Offset: 0x00214CA0
		public static double QuadEquiangleSkew(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadEquiangleSkew_50((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D8F RID: 97679
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_QuadJacobian_51(HandleRef cell);

		/// <summary>
		/// Calculate the Jacobian of a quadrilateral.
		/// The Jacobian of a quadrilateral is the minimum point-wise volume of local map
		/// at 4 corners &amp; center of quad.
		/// </summary>
		// Token: 0x06017D90 RID: 97680 RVA: 0x00216AD0 File Offset: 0x00214CD0
		public static double QuadJacobian(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadJacobian_51((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D91 RID: 97681
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_QuadMaxAngle_52(HandleRef cell);

		/// <summary>
		/// Calculate the maximum (nonoriented) angle of a quadrilateral, expressed in degrees.
		/// </summary>
		// Token: 0x06017D92 RID: 97682 RVA: 0x00216B00 File Offset: 0x00214D00
		public static double QuadMaxAngle(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadMaxAngle_52((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D93 RID: 97683
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_QuadMaxAspectFrobenius_53(HandleRef cell);

		/// <summary>
		/// Calculate the maximal Frobenius aspect of the 4 corner triangles of a planar quadrilateral,
		/// when the reference triangle elements are right isosceles at the quadrangle vertices.
		/// The Frobenius aspect of a triangle \f$t\f$, when the reference element is
		/// right isosceles at vertex \f$V\f$, is:
		/// \f$\frac{f^2+g^2}{4{\cal A}}\f$,
		/// where \f$f^2+g^2\f$ and \f$\cal A\f$ respectively denote the sum of the
		/// squared lengths of the edges attached to \f$V\f$ and the area of \f$t\f$.
		/// </summary>
		// Token: 0x06017D94 RID: 97684 RVA: 0x00216B30 File Offset: 0x00214D30
		public static double QuadMaxAspectFrobenius(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadMaxAspectFrobenius_53((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D95 RID: 97685
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_QuadMaxEdgeRatio_54(HandleRef cell);

		/// <summary>
		/// Calculate the maximum edge length ratio of a quadrilateral at quad center.
		/// </summary>
		// Token: 0x06017D96 RID: 97686 RVA: 0x00216B60 File Offset: 0x00214D60
		public static double QuadMaxEdgeRatio(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadMaxEdgeRatio_54((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D97 RID: 97687
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_QuadMedAspectFrobenius_55(HandleRef cell);

		/// <summary>
		/// Calculate the average Frobenius aspect of the 4 corner triangles of a planar quadrilateral,
		/// when the reference triangle elements are right isosceles at the quadrangle vertices.
		/// The Frobenius aspect of a triangle \f$t\f$, when the reference element is
		/// right isosceles at vertex \f$V\f$, is:
		/// \f$\frac{f^2+g^2}{4{\cal A}}\f$,
		/// where \f$f^2+g^2\f$ and \f$\cal A\f$ respectively denote the sum of the
		/// squared lengths of the edges attached to \f$V\f$ and the area of \f$t\f$.
		/// </summary>
		// Token: 0x06017D98 RID: 97688 RVA: 0x00216B90 File Offset: 0x00214D90
		public static double QuadMedAspectFrobenius(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadMedAspectFrobenius_55((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D99 RID: 97689
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_QuadMinAngle_56(HandleRef cell);

		/// <summary>
		/// Calculate the minimal (nonoriented) angle of a quadrilateral, expressed in degrees.
		/// </summary>
		// Token: 0x06017D9A RID: 97690 RVA: 0x00216BC0 File Offset: 0x00214DC0
		public static double QuadMinAngle(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadMinAngle_56((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D9B RID: 97691
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_QuadOddy_57(HandleRef cell);

		/// <summary>
		/// Calculate the oddy of a quadrilateral.
		/// The oddy of a quadrilateral is the general distortion measure based on left
		/// Cauchy-Green Tensor.
		/// </summary>
		// Token: 0x06017D9C RID: 97692 RVA: 0x00216BF0 File Offset: 0x00214DF0
		public static double QuadOddy(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadOddy_57((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D9D RID: 97693
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_QuadRadiusRatio_58(HandleRef cell);

		/// <summary>
		/// Calculate the radius ratio of a planar quadrilateral. The name is only used by analogy
		/// with the triangle radius ratio, because in general a quadrilateral does not have a
		/// circumcircle nor an incircle.
		/// The radius ratio of a planar quadrilateral \f$q\f$ is:
		/// \f$\frac{|q|_2h_{\max}}{\min_i{\cal A}_i}\f$,
		/// where \f$|q|_2\f$, \f$h_{\max}\f$ and \f$\min{\cal A}_i\f$ respectively denote
		/// the sum of the squared edge lengths, the greatest amongst diagonal and edge
		/// lengths and the smallest area of the 4 triangles extractable from \f$q\f$.
		/// </summary>
		// Token: 0x06017D9E RID: 97694 RVA: 0x00216C20 File Offset: 0x00214E20
		public static double QuadRadiusRatio(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadRadiusRatio_58((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017D9F RID: 97695
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_QuadRelativeSizeSquared_59(HandleRef cell);

		/// <summary>
		/// Calculate the relative size squared of a quadrilateral.
		/// The relative size squared of a quadrilateral is the Min(J, 1 / J), where J is the
		/// determinant of weighted Jacobian matrix.
		///
		/// Note: QuadRelativeSizeSquared will return 0.0 if the MeshQuality filter has NOT
		/// been executed, because it relies on the average quad size.
		/// </summary>
		// Token: 0x06017DA0 RID: 97696 RVA: 0x00216C50 File Offset: 0x00214E50
		public static double QuadRelativeSizeSquared(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadRelativeSizeSquared_59((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017DA1 RID: 97697
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_QuadScaledJacobian_60(HandleRef cell);

		/// <summary>
		/// Calculate the scaled Jacobian of a quadrilateral.
		/// The scaled Jacobian of a quadrilateral is the minimum Jacobian divided by the lengths
		/// of the 2 edge vectors.
		/// </summary>
		// Token: 0x06017DA2 RID: 97698 RVA: 0x00216C80 File Offset: 0x00214E80
		public static double QuadScaledJacobian(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadScaledJacobian_60((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017DA3 RID: 97699
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_QuadShape_61(HandleRef cell);

		/// <summary>
		/// Calculate the shear of a quadrilateral.
		/// The shear of a quadrilateral is 2 / Condition number of weighted Jacobian matrix.
		/// </summary>
		// Token: 0x06017DA4 RID: 97700 RVA: 0x00216CB0 File Offset: 0x00214EB0
		public static double QuadShape(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadShape_61((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017DA5 RID: 97701
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_QuadShapeAndSize_62(HandleRef cell);

		/// <summary>
		/// Calculate the shape and size of a quadrilateral.
		/// The shape and size of a quadrilateral is product of shape and average size.
		///
		/// Note: QuadShapeAndSize will return 0.0 if the MeshQuality filter has NOT
		/// been executed, because it relies on the average triangle size.
		/// </summary>
		// Token: 0x06017DA6 RID: 97702 RVA: 0x00216CE0 File Offset: 0x00214EE0
		public static double QuadShapeAndSize(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadShapeAndSize_62((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017DA7 RID: 97703
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_QuadShear_63(HandleRef cell);

		/// <summary>
		/// Calculate the shear of a quadrilateral.
		/// The shear of a quadrilateral is 2 / Condition number of Jacobian Skew matrix.
		/// </summary>
		// Token: 0x06017DA8 RID: 97704 RVA: 0x00216D10 File Offset: 0x00214F10
		public static double QuadShear(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadShear_63((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017DA9 RID: 97705
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_QuadShearAndSize_64(HandleRef cell);

		/// <summary>
		/// Calculate the shear and size of a quadrilateral.
		/// The shear and size of a quadrilateral is product of shear and average size.
		///
		/// Note: QuadShearAndSize will return 0.0 if the MeshQuality filter has NOT
		/// been executed, because it relies on the average triangle size.
		/// </summary>
		// Token: 0x06017DAA RID: 97706 RVA: 0x00216D40 File Offset: 0x00214F40
		public static double QuadShearAndSize(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadShearAndSize_64((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017DAB RID: 97707
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_QuadSkew_65(HandleRef cell);

		/// <summary>
		/// Calculate the skew of a quadrilateral.
		/// The skew of a quadrilateral is the maximum |cos A|, where A is the angle
		/// between edges at the quad center.
		/// </summary>
		// Token: 0x06017DAC RID: 97708 RVA: 0x00216D70 File Offset: 0x00214F70
		public static double QuadSkew(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadSkew_65((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017DAD RID: 97709
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_QuadStretch_66(HandleRef cell);

		/// <summary>
		/// Calculate the stretch of a quadrilateral.
		/// The stretch of a quadrilateral is Sqrt(2) * minimum edge length / maximum diagonal length.
		/// </summary>
		// Token: 0x06017DAE RID: 97710 RVA: 0x00216DA0 File Offset: 0x00214FA0
		public static double QuadStretch(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadStretch_66((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017DAF RID: 97711
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_QuadTaper_67(HandleRef cell);

		/// <summary>
		/// Calculate the taper of a quadrilateral.
		/// The taper of a quadrilateral is the ratio of lengths derived from opposite edges.
		/// </summary>
		// Token: 0x06017DB0 RID: 97712 RVA: 0x00216DD0 File Offset: 0x00214FD0
		public static double QuadTaper(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadTaper_67((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017DB1 RID: 97713
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_QuadWarpage_68(HandleRef cell);

		/// <summary>
		/// Calculate the warpage of a quadrilateral.
		/// The warpage of a quadrilateral is the cosine of Minimum Dihedral Angle formed by
		/// Planes Intersecting in Diagonals.
		/// </summary>
		// Token: 0x06017DB2 RID: 97714 RVA: 0x00216E00 File Offset: 0x00215000
		public static double QuadWarpage(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_QuadWarpage_68((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017DB3 RID: 97715
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_RatioOff_69(HandleRef pThis);

		/// <summary>
		/// These methods are deprecated. Use Get/SetSaveCellQuality() instead.
		///
		/// Formerly, SetRatio could be used to disable computation
		/// of the tetrahedral radius ratio so that volume alone could be computed.
		/// Now, cell quality is always computed, but you may decide not
		/// to store the result for each cell.
		/// This allows average cell quality of a mesh to be
		/// calculated without requiring per-cell storage.
		/// </summary>
		// Token: 0x06017DB4 RID: 97716 RVA: 0x00216E2E File Offset: 0x0021502E
		public virtual void RatioOff()
		{
			vtkMeshQuality.vtkMeshQuality_RatioOff_69(base.GetCppThis());
		}

		// Token: 0x06017DB5 RID: 97717
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_RatioOn_70(HandleRef pThis);

		/// <summary>
		/// These methods are deprecated. Use Get/SetSaveCellQuality() instead.
		///
		/// Formerly, SetRatio could be used to disable computation
		/// of the tetrahedral radius ratio so that volume alone could be computed.
		/// Now, cell quality is always computed, but you may decide not
		/// to store the result for each cell.
		/// This allows average cell quality of a mesh to be
		/// calculated without requiring per-cell storage.
		/// </summary>
		// Token: 0x06017DB6 RID: 97718 RVA: 0x00216E3D File Offset: 0x0021503D
		public virtual void RatioOn()
		{
			vtkMeshQuality.vtkMeshQuality_RatioOn_70(base.GetCppThis());
		}

		// Token: 0x06017DB7 RID: 97719
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMeshQuality_SafeDownCast_71(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017DB8 RID: 97720 RVA: 0x00216E4C File Offset: 0x0021504C
		public new static vtkMeshQuality SafeDownCast(vtkObjectBase o)
		{
			vtkMeshQuality vtkMeshQuality = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMeshQuality.vtkMeshQuality_SafeDownCast_71((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMeshQuality = (vtkMeshQuality)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMeshQuality.Register(null);
				}
			}
			return vtkMeshQuality;
		}

		// Token: 0x06017DB9 RID: 97721
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SaveCellQualityOff_72(HandleRef pThis);

		/// <summary>
		/// This variable controls whether or not cell quality is stored as
		/// cell data in the resulting mesh or discarded (leaving only the
		/// aggregate quality average of the entire mesh, recorded in the
		/// FieldData).
		/// </summary>
		// Token: 0x06017DBA RID: 97722 RVA: 0x00216ECB File Offset: 0x002150CB
		public virtual void SaveCellQualityOff()
		{
			vtkMeshQuality.vtkMeshQuality_SaveCellQualityOff_72(base.GetCppThis());
		}

		// Token: 0x06017DBB RID: 97723
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SaveCellQualityOn_73(HandleRef pThis);

		/// <summary>
		/// This variable controls whether or not cell quality is stored as
		/// cell data in the resulting mesh or discarded (leaving only the
		/// aggregate quality average of the entire mesh, recorded in the
		/// FieldData).
		/// </summary>
		// Token: 0x06017DBC RID: 97724 RVA: 0x00216EDA File Offset: 0x002150DA
		public virtual void SaveCellQualityOn()
		{
			vtkMeshQuality.vtkMeshQuality_SaveCellQualityOn_73(base.GetCppThis());
		}

		// Token: 0x06017DBD RID: 97725
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetHexQualityMeasure_74(HandleRef pThis, vtkMeshQuality.QualityMeasureTypes _arg);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of hexahedra.
		/// The default is MAX_ASPECT_FROBENIUS and valid values also include
		/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
		/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
		/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
		/// </summary>
		// Token: 0x06017DBE RID: 97726 RVA: 0x00216EE9 File Offset: 0x002150E9
		public virtual void SetHexQualityMeasure(vtkMeshQuality.QualityMeasureTypes _arg)
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasure_74(base.GetCppThis(), _arg);
		}

		// Token: 0x06017DBF RID: 97727
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetHexQualityMeasure_75(HandleRef pThis, int measure);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of hexahedra.
		/// The default is MAX_ASPECT_FROBENIUS and valid values also include
		/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
		/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
		/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
		/// </summary>
		// Token: 0x06017DC0 RID: 97728 RVA: 0x00216EF9 File Offset: 0x002150F9
		public virtual void SetHexQualityMeasure(int measure)
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasure_75(base.GetCppThis(), measure);
		}

		// Token: 0x06017DC1 RID: 97729
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToCondition_76(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of hexahedra.
		/// The default is MAX_ASPECT_FROBENIUS and valid values also include
		/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
		/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
		/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
		/// </summary>
		// Token: 0x06017DC2 RID: 97730 RVA: 0x00216F09 File Offset: 0x00215109
		public void SetHexQualityMeasureToCondition()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToCondition_76(base.GetCppThis());
		}

		// Token: 0x06017DC3 RID: 97731
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToDiagonal_77(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of hexahedra.
		/// The default is MAX_ASPECT_FROBENIUS and valid values also include
		/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
		/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
		/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
		/// </summary>
		// Token: 0x06017DC4 RID: 97732 RVA: 0x00216F18 File Offset: 0x00215118
		public void SetHexQualityMeasureToDiagonal()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToDiagonal_77(base.GetCppThis());
		}

		// Token: 0x06017DC5 RID: 97733
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToDimension_78(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of hexahedra.
		/// The default is MAX_ASPECT_FROBENIUS and valid values also include
		/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
		/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
		/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
		/// </summary>
		// Token: 0x06017DC6 RID: 97734 RVA: 0x00216F27 File Offset: 0x00215127
		public void SetHexQualityMeasureToDimension()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToDimension_78(base.GetCppThis());
		}

		// Token: 0x06017DC7 RID: 97735
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToDistortion_79(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of hexahedra.
		/// The default is MAX_ASPECT_FROBENIUS and valid values also include
		/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
		/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
		/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
		/// </summary>
		// Token: 0x06017DC8 RID: 97736 RVA: 0x00216F36 File Offset: 0x00215136
		public void SetHexQualityMeasureToDistortion()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToDistortion_79(base.GetCppThis());
		}

		// Token: 0x06017DC9 RID: 97737
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToEdgeRatio_80(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of hexahedra.
		/// The default is MAX_ASPECT_FROBENIUS and valid values also include
		/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
		/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
		/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
		/// </summary>
		// Token: 0x06017DCA RID: 97738 RVA: 0x00216F45 File Offset: 0x00215145
		public void SetHexQualityMeasureToEdgeRatio()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToEdgeRatio_80(base.GetCppThis());
		}

		// Token: 0x06017DCB RID: 97739
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToEquiangleSkew_81(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of hexahedra.
		/// The default is MAX_ASPECT_FROBENIUS and valid values also include
		/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
		/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
		/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
		/// </summary>
		// Token: 0x06017DCC RID: 97740 RVA: 0x00216F54 File Offset: 0x00215154
		public void SetHexQualityMeasureToEquiangleSkew()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToEquiangleSkew_81(base.GetCppThis());
		}

		// Token: 0x06017DCD RID: 97741
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToJacobian_82(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of hexahedra.
		/// The default is MAX_ASPECT_FROBENIUS and valid values also include
		/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
		/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
		/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
		/// </summary>
		// Token: 0x06017DCE RID: 97742 RVA: 0x00216F63 File Offset: 0x00215163
		public void SetHexQualityMeasureToJacobian()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToJacobian_82(base.GetCppThis());
		}

		// Token: 0x06017DCF RID: 97743
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToMaxAspectFrobenius_83(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of hexahedra.
		/// The default is MAX_ASPECT_FROBENIUS and valid values also include
		/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
		/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
		/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
		/// </summary>
		// Token: 0x06017DD0 RID: 97744 RVA: 0x00216F72 File Offset: 0x00215172
		public void SetHexQualityMeasureToMaxAspectFrobenius()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToMaxAspectFrobenius_83(base.GetCppThis());
		}

		// Token: 0x06017DD1 RID: 97745
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToMaxEdgeRatio_84(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of hexahedra.
		/// The default is MAX_ASPECT_FROBENIUS and valid values also include
		/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
		/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
		/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
		/// </summary>
		// Token: 0x06017DD2 RID: 97746 RVA: 0x00216F81 File Offset: 0x00215181
		public void SetHexQualityMeasureToMaxEdgeRatio()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToMaxEdgeRatio_84(base.GetCppThis());
		}

		// Token: 0x06017DD3 RID: 97747
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToMedAspectFrobenius_85(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of hexahedra.
		/// The default is MAX_ASPECT_FROBENIUS and valid values also include
		/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
		/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
		/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
		/// </summary>
		// Token: 0x06017DD4 RID: 97748 RVA: 0x00216F90 File Offset: 0x00215190
		public void SetHexQualityMeasureToMedAspectFrobenius()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToMedAspectFrobenius_85(base.GetCppThis());
		}

		// Token: 0x06017DD5 RID: 97749
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToNodalJacobianRatio_86(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of hexahedra.
		/// The default is MAX_ASPECT_FROBENIUS and valid values also include
		/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
		/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
		/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
		/// </summary>
		// Token: 0x06017DD6 RID: 97750 RVA: 0x00216F9F File Offset: 0x0021519F
		public void SetHexQualityMeasureToNodalJacobianRatio()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToNodalJacobianRatio_86(base.GetCppThis());
		}

		// Token: 0x06017DD7 RID: 97751
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToOddy_87(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of hexahedra.
		/// The default is MAX_ASPECT_FROBENIUS and valid values also include
		/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
		/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
		/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
		/// </summary>
		// Token: 0x06017DD8 RID: 97752 RVA: 0x00216FAE File Offset: 0x002151AE
		public void SetHexQualityMeasureToOddy()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToOddy_87(base.GetCppThis());
		}

		// Token: 0x06017DD9 RID: 97753
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToRelativeSizeSquared_88(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of hexahedra.
		/// The default is MAX_ASPECT_FROBENIUS and valid values also include
		/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
		/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
		/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
		/// </summary>
		// Token: 0x06017DDA RID: 97754 RVA: 0x00216FBD File Offset: 0x002151BD
		public void SetHexQualityMeasureToRelativeSizeSquared()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToRelativeSizeSquared_88(base.GetCppThis());
		}

		// Token: 0x06017DDB RID: 97755
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToScaledJacobian_89(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of hexahedra.
		/// The default is MAX_ASPECT_FROBENIUS and valid values also include
		/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
		/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
		/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
		/// </summary>
		// Token: 0x06017DDC RID: 97756 RVA: 0x00216FCC File Offset: 0x002151CC
		public void SetHexQualityMeasureToScaledJacobian()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToScaledJacobian_89(base.GetCppThis());
		}

		// Token: 0x06017DDD RID: 97757
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToShape_90(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of hexahedra.
		/// The default is MAX_ASPECT_FROBENIUS and valid values also include
		/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
		/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
		/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
		/// </summary>
		// Token: 0x06017DDE RID: 97758 RVA: 0x00216FDB File Offset: 0x002151DB
		public void SetHexQualityMeasureToShape()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToShape_90(base.GetCppThis());
		}

		// Token: 0x06017DDF RID: 97759
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToShapeAndSize_91(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of hexahedra.
		/// The default is MAX_ASPECT_FROBENIUS and valid values also include
		/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
		/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
		/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
		/// </summary>
		// Token: 0x06017DE0 RID: 97760 RVA: 0x00216FEA File Offset: 0x002151EA
		public void SetHexQualityMeasureToShapeAndSize()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToShapeAndSize_91(base.GetCppThis());
		}

		// Token: 0x06017DE1 RID: 97761
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToShear_92(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of hexahedra.
		/// The default is MAX_ASPECT_FROBENIUS and valid values also include
		/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
		/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
		/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
		/// </summary>
		// Token: 0x06017DE2 RID: 97762 RVA: 0x00216FF9 File Offset: 0x002151F9
		public void SetHexQualityMeasureToShear()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToShear_92(base.GetCppThis());
		}

		// Token: 0x06017DE3 RID: 97763
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToShearAndSize_93(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of hexahedra.
		/// The default is MAX_ASPECT_FROBENIUS and valid values also include
		/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
		/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
		/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
		/// </summary>
		// Token: 0x06017DE4 RID: 97764 RVA: 0x00217008 File Offset: 0x00215208
		public void SetHexQualityMeasureToShearAndSize()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToShearAndSize_93(base.GetCppThis());
		}

		// Token: 0x06017DE5 RID: 97765
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToSkew_94(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of hexahedra.
		/// The default is MAX_ASPECT_FROBENIUS and valid values also include
		/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
		/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
		/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
		/// </summary>
		// Token: 0x06017DE6 RID: 97766 RVA: 0x00217017 File Offset: 0x00215217
		public void SetHexQualityMeasureToSkew()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToSkew_94(base.GetCppThis());
		}

		// Token: 0x06017DE7 RID: 97767
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToStretch_95(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of hexahedra.
		/// The default is MAX_ASPECT_FROBENIUS and valid values also include
		/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
		/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
		/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
		/// </summary>
		// Token: 0x06017DE8 RID: 97768 RVA: 0x00217026 File Offset: 0x00215226
		public void SetHexQualityMeasureToStretch()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToStretch_95(base.GetCppThis());
		}

		// Token: 0x06017DE9 RID: 97769
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToTaper_96(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of hexahedra.
		/// The default is MAX_ASPECT_FROBENIUS and valid values also include
		/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
		/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
		/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
		/// </summary>
		// Token: 0x06017DEA RID: 97770 RVA: 0x00217035 File Offset: 0x00215235
		public void SetHexQualityMeasureToTaper()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToTaper_96(base.GetCppThis());
		}

		// Token: 0x06017DEB RID: 97771
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetHexQualityMeasureToVolume_97(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of hexahedra.
		/// The default is MAX_ASPECT_FROBENIUS and valid values also include
		/// EDGE_RATIO, MAX_ASPECT_FROBENIUS, MAX_EDGE_RATIO, SKEW, TAPER, VOLUME,
		/// STRETCH, DIAGONAL, DIMENSION, ODDY, CONDITION, JACOBIAN,
		/// SCALED_JACOBIAN, SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// SHEAR_AND_SIZE, DISTORTION, EQUIANGLE_SKEW, and NODAL_JACOBIAN_RATIO.
		/// </summary>
		// Token: 0x06017DEC RID: 97772 RVA: 0x00217044 File Offset: 0x00215244
		public void SetHexQualityMeasureToVolume()
		{
			vtkMeshQuality.vtkMeshQuality_SetHexQualityMeasureToVolume_97(base.GetCppThis());
		}

		// Token: 0x06017DED RID: 97773
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetLinearApproximation_98(HandleRef pThis, byte _arg);

		/// <summary>
		/// If set to true, then this filter will output 2 quality arrays instead of one.
		/// The second array is names "Quality (Linear Approx)" and features measure for all non-linear
		/// cells in addition to the linear ones, but treated like if they were linear.
		///
		/// @note In the array "Quality", any non-linear cell quality is set to NaN.
		/// </summary>
		// Token: 0x06017DEE RID: 97774 RVA: 0x00217053 File Offset: 0x00215253
		public virtual void SetLinearApproximation(bool _arg)
		{
			vtkMeshQuality.vtkMeshQuality_SetLinearApproximation_98(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06017DEF RID: 97775
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetPyramidQualityMeasure_99(HandleRef pThis, vtkMeshQuality.QualityMeasureTypes _arg);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of pyramids.
		/// The default is SHAPE and valid values also include
		/// EQUIANGLE_SKEW, JACOBIAN, SCALED_JACOBIAN, and VOLUME.
		/// </summary>
		// Token: 0x06017DF0 RID: 97776 RVA: 0x0021706B File Offset: 0x0021526B
		public virtual void SetPyramidQualityMeasure(vtkMeshQuality.QualityMeasureTypes _arg)
		{
			vtkMeshQuality.vtkMeshQuality_SetPyramidQualityMeasure_99(base.GetCppThis(), _arg);
		}

		// Token: 0x06017DF1 RID: 97777
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetPyramidQualityMeasure_100(HandleRef pThis, int measure);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of pyramids.
		/// The default is SHAPE and valid values also include
		/// EQUIANGLE_SKEW, JACOBIAN, SCALED_JACOBIAN, and VOLUME.
		/// </summary>
		// Token: 0x06017DF2 RID: 97778 RVA: 0x0021707B File Offset: 0x0021527B
		public virtual void SetPyramidQualityMeasure(int measure)
		{
			vtkMeshQuality.vtkMeshQuality_SetPyramidQualityMeasure_100(base.GetCppThis(), measure);
		}

		// Token: 0x06017DF3 RID: 97779
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetPyramidQualityMeasureToEquiangleSkew_101(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of pyramids.
		/// The default is SHAPE and valid values also include
		/// EQUIANGLE_SKEW, JACOBIAN, SCALED_JACOBIAN, and VOLUME.
		/// </summary>
		// Token: 0x06017DF4 RID: 97780 RVA: 0x0021708B File Offset: 0x0021528B
		public void SetPyramidQualityMeasureToEquiangleSkew()
		{
			vtkMeshQuality.vtkMeshQuality_SetPyramidQualityMeasureToEquiangleSkew_101(base.GetCppThis());
		}

		// Token: 0x06017DF5 RID: 97781
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetPyramidQualityMeasureToJacobian_102(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of pyramids.
		/// The default is SHAPE and valid values also include
		/// EQUIANGLE_SKEW, JACOBIAN, SCALED_JACOBIAN, and VOLUME.
		/// </summary>
		// Token: 0x06017DF6 RID: 97782 RVA: 0x0021709A File Offset: 0x0021529A
		public void SetPyramidQualityMeasureToJacobian()
		{
			vtkMeshQuality.vtkMeshQuality_SetPyramidQualityMeasureToJacobian_102(base.GetCppThis());
		}

		// Token: 0x06017DF7 RID: 97783
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetPyramidQualityMeasureToScaledJacobian_103(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of pyramids.
		/// The default is SHAPE and valid values also include
		/// EQUIANGLE_SKEW, JACOBIAN, SCALED_JACOBIAN, and VOLUME.
		/// </summary>
		// Token: 0x06017DF8 RID: 97784 RVA: 0x002170A9 File Offset: 0x002152A9
		public void SetPyramidQualityMeasureToScaledJacobian()
		{
			vtkMeshQuality.vtkMeshQuality_SetPyramidQualityMeasureToScaledJacobian_103(base.GetCppThis());
		}

		// Token: 0x06017DF9 RID: 97785
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetPyramidQualityMeasureToShape_104(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of pyramids.
		/// The default is SHAPE and valid values also include
		/// EQUIANGLE_SKEW, JACOBIAN, SCALED_JACOBIAN, and VOLUME.
		/// </summary>
		// Token: 0x06017DFA RID: 97786 RVA: 0x002170B8 File Offset: 0x002152B8
		public void SetPyramidQualityMeasureToShape()
		{
			vtkMeshQuality.vtkMeshQuality_SetPyramidQualityMeasureToShape_104(base.GetCppThis());
		}

		// Token: 0x06017DFB RID: 97787
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetPyramidQualityMeasureToVolume_105(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of pyramids.
		/// The default is SHAPE and valid values also include
		/// EQUIANGLE_SKEW, JACOBIAN, SCALED_JACOBIAN, and VOLUME.
		/// </summary>
		// Token: 0x06017DFC RID: 97788 RVA: 0x002170C7 File Offset: 0x002152C7
		public void SetPyramidQualityMeasureToVolume()
		{
			vtkMeshQuality.vtkMeshQuality_SetPyramidQualityMeasureToVolume_105(base.GetCppThis());
		}

		// Token: 0x06017DFD RID: 97789
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasure_106(HandleRef pThis, vtkMeshQuality.QualityMeasureTypes _arg);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
		/// The default is EDGE_RATIO and valid values also include
		/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
		/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
		/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
		/// and EQUIANGLE_SKEW.
		///
		/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
		/// quadrilaterals only; use at your own risk if you really want to assess non-planar
		/// quadrilateral quality with those.
		/// </summary>
		// Token: 0x06017DFE RID: 97790 RVA: 0x002170D6 File Offset: 0x002152D6
		public virtual void SetQuadQualityMeasure(vtkMeshQuality.QualityMeasureTypes _arg)
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasure_106(base.GetCppThis(), _arg);
		}

		// Token: 0x06017DFF RID: 97791
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasure_107(HandleRef pThis, int measure);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
		/// The default is EDGE_RATIO and valid values also include
		/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
		/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
		/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
		/// and EQUIANGLE_SKEW.
		///
		/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
		/// quadrilaterals only; use at your own risk if you really want to assess non-planar
		/// quadrilateral quality with those.
		/// </summary>
		// Token: 0x06017E00 RID: 97792 RVA: 0x002170E6 File Offset: 0x002152E6
		public virtual void SetQuadQualityMeasure(int measure)
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasure_107(base.GetCppThis(), measure);
		}

		// Token: 0x06017E01 RID: 97793
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToArea_108(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
		/// The default is EDGE_RATIO and valid values also include
		/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
		/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
		/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
		/// and EQUIANGLE_SKEW.
		///
		/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
		/// quadrilaterals only; use at your own risk if you really want to assess non-planar
		/// quadrilateral quality with those.
		/// </summary>
		// Token: 0x06017E02 RID: 97794 RVA: 0x002170F6 File Offset: 0x002152F6
		public void SetQuadQualityMeasureToArea()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToArea_108(base.GetCppThis());
		}

		// Token: 0x06017E03 RID: 97795
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToAspectRatio_109(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
		/// The default is EDGE_RATIO and valid values also include
		/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
		/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
		/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
		/// and EQUIANGLE_SKEW.
		///
		/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
		/// quadrilaterals only; use at your own risk if you really want to assess non-planar
		/// quadrilateral quality with those.
		/// </summary>
		// Token: 0x06017E04 RID: 97796 RVA: 0x00217105 File Offset: 0x00215305
		public void SetQuadQualityMeasureToAspectRatio()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToAspectRatio_109(base.GetCppThis());
		}

		// Token: 0x06017E05 RID: 97797
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToCondition_110(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
		/// The default is EDGE_RATIO and valid values also include
		/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
		/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
		/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
		/// and EQUIANGLE_SKEW.
		///
		/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
		/// quadrilaterals only; use at your own risk if you really want to assess non-planar
		/// quadrilateral quality with those.
		/// </summary>
		// Token: 0x06017E06 RID: 97798 RVA: 0x00217114 File Offset: 0x00215314
		public void SetQuadQualityMeasureToCondition()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToCondition_110(base.GetCppThis());
		}

		// Token: 0x06017E07 RID: 97799
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToDistortion_111(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
		/// The default is EDGE_RATIO and valid values also include
		/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
		/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
		/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
		/// and EQUIANGLE_SKEW.
		///
		/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
		/// quadrilaterals only; use at your own risk if you really want to assess non-planar
		/// quadrilateral quality with those.
		/// </summary>
		// Token: 0x06017E08 RID: 97800 RVA: 0x00217123 File Offset: 0x00215323
		public void SetQuadQualityMeasureToDistortion()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToDistortion_111(base.GetCppThis());
		}

		// Token: 0x06017E09 RID: 97801
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToEdgeRatio_112(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
		/// The default is EDGE_RATIO and valid values also include
		/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
		/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
		/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
		/// and EQUIANGLE_SKEW.
		///
		/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
		/// quadrilaterals only; use at your own risk if you really want to assess non-planar
		/// quadrilateral quality with those.
		/// </summary>
		// Token: 0x06017E0A RID: 97802 RVA: 0x00217132 File Offset: 0x00215332
		public void SetQuadQualityMeasureToEdgeRatio()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToEdgeRatio_112(base.GetCppThis());
		}

		// Token: 0x06017E0B RID: 97803
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToEquiangleSkew_113(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
		/// The default is EDGE_RATIO and valid values also include
		/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
		/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
		/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
		/// and EQUIANGLE_SKEW.
		///
		/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
		/// quadrilaterals only; use at your own risk if you really want to assess non-planar
		/// quadrilateral quality with those.
		/// </summary>
		// Token: 0x06017E0C RID: 97804 RVA: 0x00217141 File Offset: 0x00215341
		public void SetQuadQualityMeasureToEquiangleSkew()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToEquiangleSkew_113(base.GetCppThis());
		}

		// Token: 0x06017E0D RID: 97805
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToJacobian_114(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
		/// The default is EDGE_RATIO and valid values also include
		/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
		/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
		/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
		/// and EQUIANGLE_SKEW.
		///
		/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
		/// quadrilaterals only; use at your own risk if you really want to assess non-planar
		/// quadrilateral quality with those.
		/// </summary>
		// Token: 0x06017E0E RID: 97806 RVA: 0x00217150 File Offset: 0x00215350
		public void SetQuadQualityMeasureToJacobian()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToJacobian_114(base.GetCppThis());
		}

		// Token: 0x06017E0F RID: 97807
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToMaxAngle_115(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
		/// The default is EDGE_RATIO and valid values also include
		/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
		/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
		/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
		/// and EQUIANGLE_SKEW.
		///
		/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
		/// quadrilaterals only; use at your own risk if you really want to assess non-planar
		/// quadrilateral quality with those.
		/// </summary>
		// Token: 0x06017E10 RID: 97808 RVA: 0x0021715F File Offset: 0x0021535F
		public void SetQuadQualityMeasureToMaxAngle()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToMaxAngle_115(base.GetCppThis());
		}

		// Token: 0x06017E11 RID: 97809
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToMaxAspectFrobenius_116(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
		/// The default is EDGE_RATIO and valid values also include
		/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
		/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
		/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
		/// and EQUIANGLE_SKEW.
		///
		/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
		/// quadrilaterals only; use at your own risk if you really want to assess non-planar
		/// quadrilateral quality with those.
		/// </summary>
		// Token: 0x06017E12 RID: 97810 RVA: 0x0021716E File Offset: 0x0021536E
		public void SetQuadQualityMeasureToMaxAspectFrobenius()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToMaxAspectFrobenius_116(base.GetCppThis());
		}

		// Token: 0x06017E13 RID: 97811
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToMaxEdgeRatio_117(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
		/// The default is EDGE_RATIO and valid values also include
		/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
		/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
		/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
		/// and EQUIANGLE_SKEW.
		///
		/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
		/// quadrilaterals only; use at your own risk if you really want to assess non-planar
		/// quadrilateral quality with those.
		/// </summary>
		// Token: 0x06017E14 RID: 97812 RVA: 0x0021717D File Offset: 0x0021537D
		public void SetQuadQualityMeasureToMaxEdgeRatio()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToMaxEdgeRatio_117(base.GetCppThis());
		}

		// Token: 0x06017E15 RID: 97813
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToMedAspectFrobenius_118(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
		/// The default is EDGE_RATIO and valid values also include
		/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
		/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
		/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
		/// and EQUIANGLE_SKEW.
		///
		/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
		/// quadrilaterals only; use at your own risk if you really want to assess non-planar
		/// quadrilateral quality with those.
		/// </summary>
		// Token: 0x06017E16 RID: 97814 RVA: 0x0021718C File Offset: 0x0021538C
		public void SetQuadQualityMeasureToMedAspectFrobenius()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToMedAspectFrobenius_118(base.GetCppThis());
		}

		// Token: 0x06017E17 RID: 97815
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToMinAngle_119(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
		/// The default is EDGE_RATIO and valid values also include
		/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
		/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
		/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
		/// and EQUIANGLE_SKEW.
		///
		/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
		/// quadrilaterals only; use at your own risk if you really want to assess non-planar
		/// quadrilateral quality with those.
		/// </summary>
		// Token: 0x06017E18 RID: 97816 RVA: 0x0021719B File Offset: 0x0021539B
		public void SetQuadQualityMeasureToMinAngle()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToMinAngle_119(base.GetCppThis());
		}

		// Token: 0x06017E19 RID: 97817
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToOddy_120(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
		/// The default is EDGE_RATIO and valid values also include
		/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
		/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
		/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
		/// and EQUIANGLE_SKEW.
		///
		/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
		/// quadrilaterals only; use at your own risk if you really want to assess non-planar
		/// quadrilateral quality with those.
		/// </summary>
		// Token: 0x06017E1A RID: 97818 RVA: 0x002171AA File Offset: 0x002153AA
		public void SetQuadQualityMeasureToOddy()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToOddy_120(base.GetCppThis());
		}

		// Token: 0x06017E1B RID: 97819
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToRadiusRatio_121(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
		/// The default is EDGE_RATIO and valid values also include
		/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
		/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
		/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
		/// and EQUIANGLE_SKEW.
		///
		/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
		/// quadrilaterals only; use at your own risk if you really want to assess non-planar
		/// quadrilateral quality with those.
		/// </summary>
		// Token: 0x06017E1C RID: 97820 RVA: 0x002171B9 File Offset: 0x002153B9
		public void SetQuadQualityMeasureToRadiusRatio()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToRadiusRatio_121(base.GetCppThis());
		}

		// Token: 0x06017E1D RID: 97821
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToRelativeSizeSquared_122(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
		/// The default is EDGE_RATIO and valid values also include
		/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
		/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
		/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
		/// and EQUIANGLE_SKEW.
		///
		/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
		/// quadrilaterals only; use at your own risk if you really want to assess non-planar
		/// quadrilateral quality with those.
		/// </summary>
		// Token: 0x06017E1E RID: 97822 RVA: 0x002171C8 File Offset: 0x002153C8
		public void SetQuadQualityMeasureToRelativeSizeSquared()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToRelativeSizeSquared_122(base.GetCppThis());
		}

		// Token: 0x06017E1F RID: 97823
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToScaledJacobian_123(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
		/// The default is EDGE_RATIO and valid values also include
		/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
		/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
		/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
		/// and EQUIANGLE_SKEW.
		///
		/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
		/// quadrilaterals only; use at your own risk if you really want to assess non-planar
		/// quadrilateral quality with those.
		/// </summary>
		// Token: 0x06017E20 RID: 97824 RVA: 0x002171D7 File Offset: 0x002153D7
		public void SetQuadQualityMeasureToScaledJacobian()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToScaledJacobian_123(base.GetCppThis());
		}

		// Token: 0x06017E21 RID: 97825
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToShape_124(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
		/// The default is EDGE_RATIO and valid values also include
		/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
		/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
		/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
		/// and EQUIANGLE_SKEW.
		///
		/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
		/// quadrilaterals only; use at your own risk if you really want to assess non-planar
		/// quadrilateral quality with those.
		/// </summary>
		// Token: 0x06017E22 RID: 97826 RVA: 0x002171E6 File Offset: 0x002153E6
		public void SetQuadQualityMeasureToShape()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToShape_124(base.GetCppThis());
		}

		// Token: 0x06017E23 RID: 97827
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToShapeAndSize_125(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
		/// The default is EDGE_RATIO and valid values also include
		/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
		/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
		/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
		/// and EQUIANGLE_SKEW.
		///
		/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
		/// quadrilaterals only; use at your own risk if you really want to assess non-planar
		/// quadrilateral quality with those.
		/// </summary>
		// Token: 0x06017E24 RID: 97828 RVA: 0x002171F5 File Offset: 0x002153F5
		public void SetQuadQualityMeasureToShapeAndSize()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToShapeAndSize_125(base.GetCppThis());
		}

		// Token: 0x06017E25 RID: 97829
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToShear_126(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
		/// The default is EDGE_RATIO and valid values also include
		/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
		/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
		/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
		/// and EQUIANGLE_SKEW.
		///
		/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
		/// quadrilaterals only; use at your own risk if you really want to assess non-planar
		/// quadrilateral quality with those.
		/// </summary>
		// Token: 0x06017E26 RID: 97830 RVA: 0x00217204 File Offset: 0x00215404
		public void SetQuadQualityMeasureToShear()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToShear_126(base.GetCppThis());
		}

		// Token: 0x06017E27 RID: 97831
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToShearAndSize_127(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
		/// The default is EDGE_RATIO and valid values also include
		/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
		/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
		/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
		/// and EQUIANGLE_SKEW.
		///
		/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
		/// quadrilaterals only; use at your own risk if you really want to assess non-planar
		/// quadrilateral quality with those.
		/// </summary>
		// Token: 0x06017E28 RID: 97832 RVA: 0x00217213 File Offset: 0x00215413
		public void SetQuadQualityMeasureToShearAndSize()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToShearAndSize_127(base.GetCppThis());
		}

		// Token: 0x06017E29 RID: 97833
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToSkew_128(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
		/// The default is EDGE_RATIO and valid values also include
		/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
		/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
		/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
		/// and EQUIANGLE_SKEW.
		///
		/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
		/// quadrilaterals only; use at your own risk if you really want to assess non-planar
		/// quadrilateral quality with those.
		/// </summary>
		// Token: 0x06017E2A RID: 97834 RVA: 0x00217222 File Offset: 0x00215422
		public void SetQuadQualityMeasureToSkew()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToSkew_128(base.GetCppThis());
		}

		// Token: 0x06017E2B RID: 97835
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToStretch_129(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
		/// The default is EDGE_RATIO and valid values also include
		/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
		/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
		/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
		/// and EQUIANGLE_SKEW.
		///
		/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
		/// quadrilaterals only; use at your own risk if you really want to assess non-planar
		/// quadrilateral quality with those.
		/// </summary>
		// Token: 0x06017E2C RID: 97836 RVA: 0x00217231 File Offset: 0x00215431
		public void SetQuadQualityMeasureToStretch()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToStretch_129(base.GetCppThis());
		}

		// Token: 0x06017E2D RID: 97837
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToTaper_130(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
		/// The default is EDGE_RATIO and valid values also include
		/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
		/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
		/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
		/// and EQUIANGLE_SKEW.
		///
		/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
		/// quadrilaterals only; use at your own risk if you really want to assess non-planar
		/// quadrilateral quality with those.
		/// </summary>
		// Token: 0x06017E2E RID: 97838 RVA: 0x00217240 File Offset: 0x00215440
		public void SetQuadQualityMeasureToTaper()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToTaper_130(base.GetCppThis());
		}

		// Token: 0x06017E2F RID: 97839
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetQuadQualityMeasureToWarpage_131(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of quadrilaterals.
		/// The default is EDGE_RATIO and valid values also include
		/// RADIUS_RATIO, ASPECT_RATIO, MAX_EDGE_RATIO SKEW, TAPER, WARPAGE, AREA,
		/// STRETCH, MIN_ANGLE, MAX_ANGLE, ODDY, CONDITION, JACOBIAN, SCALED_JACOBIAN,
		/// SHEAR, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE, SHEAR_AND_SIZE, DISTORTION,
		/// and EQUIANGLE_SKEW.
		///
		/// Scope: Except for EDGE_RATIO, these estimators are intended for planar
		/// quadrilaterals only; use at your own risk if you really want to assess non-planar
		/// quadrilateral quality with those.
		/// </summary>
		// Token: 0x06017E30 RID: 97840 RVA: 0x0021724F File Offset: 0x0021544F
		public void SetQuadQualityMeasureToWarpage()
		{
			vtkMeshQuality.vtkMeshQuality_SetQuadQualityMeasureToWarpage_131(base.GetCppThis());
		}

		// Token: 0x06017E31 RID: 97841
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetRatio_132(HandleRef pThis, int r);

		/// <summary>
		/// These methods are deprecated. Use Get/SetSaveCellQuality() instead.
		///
		/// Formerly, SetRatio could be used to disable computation
		/// of the tetrahedral radius ratio so that volume alone could be computed.
		/// Now, cell quality is always computed, but you may decide not
		/// to store the result for each cell.
		/// This allows average cell quality of a mesh to be
		/// calculated without requiring per-cell storage.
		/// </summary>
		// Token: 0x06017E32 RID: 97842 RVA: 0x0021725E File Offset: 0x0021545E
		public virtual void SetRatio(int r)
		{
			vtkMeshQuality.vtkMeshQuality_SetRatio_132(base.GetCppThis(), r);
		}

		// Token: 0x06017E33 RID: 97843
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetSaveCellQuality_133(HandleRef pThis, int _arg);

		/// <summary>
		/// This variable controls whether or not cell quality is stored as
		/// cell data in the resulting mesh or discarded (leaving only the
		/// aggregate quality average of the entire mesh, recorded in the
		/// FieldData).
		/// </summary>
		// Token: 0x06017E34 RID: 97844 RVA: 0x0021726E File Offset: 0x0021546E
		public virtual void SetSaveCellQuality(int _arg)
		{
			vtkMeshQuality.vtkMeshQuality_SetSaveCellQuality_133(base.GetCppThis(), _arg);
		}

		// Token: 0x06017E35 RID: 97845
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTetQualityMeasure_134(HandleRef pThis, vtkMeshQuality.QualityMeasureTypes _arg);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of tetrahedra.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
		/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
		/// </summary>
		// Token: 0x06017E36 RID: 97846 RVA: 0x0021727E File Offset: 0x0021547E
		public virtual void SetTetQualityMeasure(vtkMeshQuality.QualityMeasureTypes _arg)
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasure_134(base.GetCppThis(), _arg);
		}

		// Token: 0x06017E37 RID: 97847
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTetQualityMeasure_135(HandleRef pThis, int measure);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of tetrahedra.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
		/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
		/// </summary>
		// Token: 0x06017E38 RID: 97848 RVA: 0x0021728E File Offset: 0x0021548E
		public virtual void SetTetQualityMeasure(int measure)
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasure_135(base.GetCppThis(), measure);
		}

		// Token: 0x06017E39 RID: 97849
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToAspectFrobenius_136(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of tetrahedra.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
		/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
		/// </summary>
		// Token: 0x06017E3A RID: 97850 RVA: 0x0021729E File Offset: 0x0021549E
		public void SetTetQualityMeasureToAspectFrobenius()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToAspectFrobenius_136(base.GetCppThis());
		}

		// Token: 0x06017E3B RID: 97851
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToAspectGamma_137(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of tetrahedra.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
		/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
		/// </summary>
		// Token: 0x06017E3C RID: 97852 RVA: 0x002172AD File Offset: 0x002154AD
		public void SetTetQualityMeasureToAspectGamma()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToAspectGamma_137(base.GetCppThis());
		}

		// Token: 0x06017E3D RID: 97853
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToAspectRatio_138(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of tetrahedra.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
		/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
		/// </summary>
		// Token: 0x06017E3E RID: 97854 RVA: 0x002172BC File Offset: 0x002154BC
		public void SetTetQualityMeasureToAspectRatio()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToAspectRatio_138(base.GetCppThis());
		}

		// Token: 0x06017E3F RID: 97855
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToCollapseRatio_139(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of tetrahedra.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
		/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
		/// </summary>
		// Token: 0x06017E40 RID: 97856 RVA: 0x002172CB File Offset: 0x002154CB
		public void SetTetQualityMeasureToCollapseRatio()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToCollapseRatio_139(base.GetCppThis());
		}

		// Token: 0x06017E41 RID: 97857
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToCondition_140(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of tetrahedra.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
		/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
		/// </summary>
		// Token: 0x06017E42 RID: 97858 RVA: 0x002172DA File Offset: 0x002154DA
		public void SetTetQualityMeasureToCondition()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToCondition_140(base.GetCppThis());
		}

		// Token: 0x06017E43 RID: 97859
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToDistortion_141(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of tetrahedra.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
		/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
		/// </summary>
		// Token: 0x06017E44 RID: 97860 RVA: 0x002172E9 File Offset: 0x002154E9
		public void SetTetQualityMeasureToDistortion()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToDistortion_141(base.GetCppThis());
		}

		// Token: 0x06017E45 RID: 97861
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToEdgeRatio_142(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of tetrahedra.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
		/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
		/// </summary>
		// Token: 0x06017E46 RID: 97862 RVA: 0x002172F8 File Offset: 0x002154F8
		public void SetTetQualityMeasureToEdgeRatio()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToEdgeRatio_142(base.GetCppThis());
		}

		// Token: 0x06017E47 RID: 97863
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToEquiangleSkew_143(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of tetrahedra.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
		/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
		/// </summary>
		// Token: 0x06017E48 RID: 97864 RVA: 0x00217307 File Offset: 0x00215507
		public void SetTetQualityMeasureToEquiangleSkew()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToEquiangleSkew_143(base.GetCppThis());
		}

		// Token: 0x06017E49 RID: 97865
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToEquivolumeSkew_144(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of tetrahedra.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
		/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
		/// </summary>
		// Token: 0x06017E4A RID: 97866 RVA: 0x00217316 File Offset: 0x00215516
		public void SetTetQualityMeasureToEquivolumeSkew()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToEquivolumeSkew_144(base.GetCppThis());
		}

		// Token: 0x06017E4B RID: 97867
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToJacobian_145(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of tetrahedra.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
		/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
		/// </summary>
		// Token: 0x06017E4C RID: 97868 RVA: 0x00217325 File Offset: 0x00215525
		public void SetTetQualityMeasureToJacobian()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToJacobian_145(base.GetCppThis());
		}

		// Token: 0x06017E4D RID: 97869
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToMeanRatio_146(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of tetrahedra.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
		/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
		/// </summary>
		// Token: 0x06017E4E RID: 97870 RVA: 0x00217334 File Offset: 0x00215534
		public void SetTetQualityMeasureToMeanRatio()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToMeanRatio_146(base.GetCppThis());
		}

		// Token: 0x06017E4F RID: 97871
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToMinAngle_147(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of tetrahedra.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
		/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
		/// </summary>
		// Token: 0x06017E50 RID: 97872 RVA: 0x00217343 File Offset: 0x00215543
		public void SetTetQualityMeasureToMinAngle()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToMinAngle_147(base.GetCppThis());
		}

		// Token: 0x06017E51 RID: 97873
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToNormalizedInradius_148(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of tetrahedra.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
		/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
		/// </summary>
		// Token: 0x06017E52 RID: 97874 RVA: 0x00217352 File Offset: 0x00215552
		public void SetTetQualityMeasureToNormalizedInradius()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToNormalizedInradius_148(base.GetCppThis());
		}

		// Token: 0x06017E53 RID: 97875
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToRadiusRatio_149(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of tetrahedra.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
		/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
		/// </summary>
		// Token: 0x06017E54 RID: 97876 RVA: 0x00217361 File Offset: 0x00215561
		public void SetTetQualityMeasureToRadiusRatio()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToRadiusRatio_149(base.GetCppThis());
		}

		// Token: 0x06017E55 RID: 97877
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToRelativeSizeSquared_150(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of tetrahedra.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
		/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
		/// </summary>
		// Token: 0x06017E56 RID: 97878 RVA: 0x00217370 File Offset: 0x00215570
		public void SetTetQualityMeasureToRelativeSizeSquared()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToRelativeSizeSquared_150(base.GetCppThis());
		}

		// Token: 0x06017E57 RID: 97879
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToScaledJacobian_151(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of tetrahedra.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
		/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
		/// </summary>
		// Token: 0x06017E58 RID: 97880 RVA: 0x0021737F File Offset: 0x0021557F
		public void SetTetQualityMeasureToScaledJacobian()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToScaledJacobian_151(base.GetCppThis());
		}

		// Token: 0x06017E59 RID: 97881
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToShape_152(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of tetrahedra.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
		/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
		/// </summary>
		// Token: 0x06017E5A RID: 97882 RVA: 0x0021738E File Offset: 0x0021558E
		public void SetTetQualityMeasureToShape()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToShape_152(base.GetCppThis());
		}

		// Token: 0x06017E5B RID: 97883
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToShapeAndSize_153(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of tetrahedra.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
		/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
		/// </summary>
		// Token: 0x06017E5C RID: 97884 RVA: 0x0021739D File Offset: 0x0021559D
		public void SetTetQualityMeasureToShapeAndSize()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToShapeAndSize_153(base.GetCppThis());
		}

		// Token: 0x06017E5D RID: 97885
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToSquishIndex_154(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of tetrahedra.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
		/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
		/// </summary>
		// Token: 0x06017E5E RID: 97886 RVA: 0x002173AC File Offset: 0x002155AC
		public void SetTetQualityMeasureToSquishIndex()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToSquishIndex_154(base.GetCppThis());
		}

		// Token: 0x06017E5F RID: 97887
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTetQualityMeasureToVolume_155(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of tetrahedra.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, EDGE_RATIO, COLLAPSE_RATIO, ASPECT_GAMMA, VOLUME,
		/// CONDITION, JACOBIAN, SCALED_JACOBIAN, SHAPE, RELATIVE_SIZE_SQUARED, SHAPE_AND_SIZE,
		/// DISTORTION, EQUIANGLE_SKEW, EQUIVOLUME_SKEW, MEAN_RATIO, NORMALIZED_INRADIUS, and SQUISH_INDEX.
		/// </summary>
		// Token: 0x06017E60 RID: 97888 RVA: 0x002173BB File Offset: 0x002155BB
		public void SetTetQualityMeasureToVolume()
		{
			vtkMeshQuality.vtkMeshQuality_SetTetQualityMeasureToVolume_155(base.GetCppThis());
		}

		// Token: 0x06017E61 RID: 97889
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTriangleQualityMeasure_156(HandleRef pThis, vtkMeshQuality.QualityMeasureTypes _arg);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of triangles.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
		/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
		/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
		/// </summary>
		// Token: 0x06017E62 RID: 97890 RVA: 0x002173CA File Offset: 0x002155CA
		public virtual void SetTriangleQualityMeasure(vtkMeshQuality.QualityMeasureTypes _arg)
		{
			vtkMeshQuality.vtkMeshQuality_SetTriangleQualityMeasure_156(base.GetCppThis(), _arg);
		}

		// Token: 0x06017E63 RID: 97891
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTriangleQualityMeasure_157(HandleRef pThis, int measure);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of triangles.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
		/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
		/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
		/// </summary>
		// Token: 0x06017E64 RID: 97892 RVA: 0x002173DA File Offset: 0x002155DA
		public virtual void SetTriangleQualityMeasure(int measure)
		{
			vtkMeshQuality.vtkMeshQuality_SetTriangleQualityMeasure_157(base.GetCppThis(), measure);
		}

		// Token: 0x06017E65 RID: 97893
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToArea_158(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of triangles.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
		/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
		/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
		/// </summary>
		// Token: 0x06017E66 RID: 97894 RVA: 0x002173EA File Offset: 0x002155EA
		public void SetTriangleQualityMeasureToArea()
		{
			vtkMeshQuality.vtkMeshQuality_SetTriangleQualityMeasureToArea_158(base.GetCppThis());
		}

		// Token: 0x06017E67 RID: 97895
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToAspectFrobenius_159(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of triangles.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
		/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
		/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
		/// </summary>
		// Token: 0x06017E68 RID: 97896 RVA: 0x002173F9 File Offset: 0x002155F9
		public void SetTriangleQualityMeasureToAspectFrobenius()
		{
			vtkMeshQuality.vtkMeshQuality_SetTriangleQualityMeasureToAspectFrobenius_159(base.GetCppThis());
		}

		// Token: 0x06017E69 RID: 97897
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToAspectRatio_160(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of triangles.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
		/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
		/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
		/// </summary>
		// Token: 0x06017E6A RID: 97898 RVA: 0x00217408 File Offset: 0x00215608
		public void SetTriangleQualityMeasureToAspectRatio()
		{
			vtkMeshQuality.vtkMeshQuality_SetTriangleQualityMeasureToAspectRatio_160(base.GetCppThis());
		}

		// Token: 0x06017E6B RID: 97899
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToCondition_161(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of triangles.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
		/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
		/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
		/// </summary>
		// Token: 0x06017E6C RID: 97900 RVA: 0x00217417 File Offset: 0x00215617
		public void SetTriangleQualityMeasureToCondition()
		{
			vtkMeshQuality.vtkMeshQuality_SetTriangleQualityMeasureToCondition_161(base.GetCppThis());
		}

		// Token: 0x06017E6D RID: 97901
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToDistortion_162(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of triangles.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
		/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
		/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
		/// </summary>
		// Token: 0x06017E6E RID: 97902 RVA: 0x00217426 File Offset: 0x00215626
		public void SetTriangleQualityMeasureToDistortion()
		{
			vtkMeshQuality.vtkMeshQuality_SetTriangleQualityMeasureToDistortion_162(base.GetCppThis());
		}

		// Token: 0x06017E6F RID: 97903
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToEdgeRatio_163(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of triangles.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
		/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
		/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
		/// </summary>
		// Token: 0x06017E70 RID: 97904 RVA: 0x00217435 File Offset: 0x00215635
		public void SetTriangleQualityMeasureToEdgeRatio()
		{
			vtkMeshQuality.vtkMeshQuality_SetTriangleQualityMeasureToEdgeRatio_163(base.GetCppThis());
		}

		// Token: 0x06017E71 RID: 97905
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToEquiangleSkew_164(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of triangles.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
		/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
		/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
		/// </summary>
		// Token: 0x06017E72 RID: 97906 RVA: 0x00217444 File Offset: 0x00215644
		public void SetTriangleQualityMeasureToEquiangleSkew()
		{
			vtkMeshQuality.vtkMeshQuality_SetTriangleQualityMeasureToEquiangleSkew_164(base.GetCppThis());
		}

		// Token: 0x06017E73 RID: 97907
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToMaxAngle_165(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of triangles.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
		/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
		/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
		/// </summary>
		// Token: 0x06017E74 RID: 97908 RVA: 0x00217453 File Offset: 0x00215653
		public void SetTriangleQualityMeasureToMaxAngle()
		{
			vtkMeshQuality.vtkMeshQuality_SetTriangleQualityMeasureToMaxAngle_165(base.GetCppThis());
		}

		// Token: 0x06017E75 RID: 97909
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToMinAngle_166(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of triangles.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
		/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
		/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
		/// </summary>
		// Token: 0x06017E76 RID: 97910 RVA: 0x00217462 File Offset: 0x00215662
		public void SetTriangleQualityMeasureToMinAngle()
		{
			vtkMeshQuality.vtkMeshQuality_SetTriangleQualityMeasureToMinAngle_166(base.GetCppThis());
		}

		// Token: 0x06017E77 RID: 97911
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToNormalizedInradius_167(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of triangles.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
		/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
		/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
		/// </summary>
		// Token: 0x06017E78 RID: 97912 RVA: 0x00217471 File Offset: 0x00215671
		public void SetTriangleQualityMeasureToNormalizedInradius()
		{
			vtkMeshQuality.vtkMeshQuality_SetTriangleQualityMeasureToNormalizedInradius_167(base.GetCppThis());
		}

		// Token: 0x06017E79 RID: 97913
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToRadiusRatio_168(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of triangles.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
		/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
		/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
		/// </summary>
		// Token: 0x06017E7A RID: 97914 RVA: 0x00217480 File Offset: 0x00215680
		public void SetTriangleQualityMeasureToRadiusRatio()
		{
			vtkMeshQuality.vtkMeshQuality_SetTriangleQualityMeasureToRadiusRatio_168(base.GetCppThis());
		}

		// Token: 0x06017E7B RID: 97915
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToRelativeSizeSquared_169(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of triangles.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
		/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
		/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
		/// </summary>
		// Token: 0x06017E7C RID: 97916 RVA: 0x0021748F File Offset: 0x0021568F
		public void SetTriangleQualityMeasureToRelativeSizeSquared()
		{
			vtkMeshQuality.vtkMeshQuality_SetTriangleQualityMeasureToRelativeSizeSquared_169(base.GetCppThis());
		}

		// Token: 0x06017E7D RID: 97917
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToScaledJacobian_170(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of triangles.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
		/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
		/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
		/// </summary>
		// Token: 0x06017E7E RID: 97918 RVA: 0x0021749E File Offset: 0x0021569E
		public void SetTriangleQualityMeasureToScaledJacobian()
		{
			vtkMeshQuality.vtkMeshQuality_SetTriangleQualityMeasureToScaledJacobian_170(base.GetCppThis());
		}

		// Token: 0x06017E7F RID: 97919
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToShape_171(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of triangles.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
		/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
		/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
		/// </summary>
		// Token: 0x06017E80 RID: 97920 RVA: 0x002174AD File Offset: 0x002156AD
		public void SetTriangleQualityMeasureToShape()
		{
			vtkMeshQuality.vtkMeshQuality_SetTriangleQualityMeasureToShape_171(base.GetCppThis());
		}

		// Token: 0x06017E81 RID: 97921
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetTriangleQualityMeasureToShapeAndSize_172(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of triangles.
		/// The default is RADIUS_RATIO and valid values also include
		/// ASPECT_RATIO, ASPECT_FROBENIUS, and EDGE_RATIO, MIN_ANGLE, MAX_ANGLE, CONDITION,
		/// SCALED_JACOBIAN, RELATIVE_SIZE_SQUARED, SHAPE, SHAPE_AND_SIZE, DISTORTION,
		/// EQUIANGLE_SKEW, and NORMALIZED_INRADIUS.
		/// </summary>
		// Token: 0x06017E82 RID: 97922 RVA: 0x002174BC File Offset: 0x002156BC
		public void SetTriangleQualityMeasureToShapeAndSize()
		{
			vtkMeshQuality.vtkMeshQuality_SetTriangleQualityMeasureToShapeAndSize_172(base.GetCppThis());
		}

		// Token: 0x06017E83 RID: 97923
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetWedgeQualityMeasure_173(HandleRef pThis, vtkMeshQuality.QualityMeasureTypes _arg);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of wedges.
		/// The default is EDGE_RATIO and valid values also include
		/// CONDITION, DISTORTION, EQUIANGLE_SKEW, JACOBIAN, MAX_ASPECT_FROBENIUS, MAX_STRETCH,
		/// MEAN_ASPECT_FROBENIUS, SCALED_JACOBIAN, SHAPE, and VOLUME.
		/// </summary>
		// Token: 0x06017E84 RID: 97924 RVA: 0x002174CB File Offset: 0x002156CB
		public virtual void SetWedgeQualityMeasure(vtkMeshQuality.QualityMeasureTypes _arg)
		{
			vtkMeshQuality.vtkMeshQuality_SetWedgeQualityMeasure_173(base.GetCppThis(), _arg);
		}

		// Token: 0x06017E85 RID: 97925
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetWedgeQualityMeasure_174(HandleRef pThis, int measure);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of wedges.
		/// The default is EDGE_RATIO and valid values also include
		/// CONDITION, DISTORTION, EQUIANGLE_SKEW, JACOBIAN, MAX_ASPECT_FROBENIUS, MAX_STRETCH,
		/// MEAN_ASPECT_FROBENIUS, SCALED_JACOBIAN, SHAPE, and VOLUME.
		/// </summary>
		// Token: 0x06017E86 RID: 97926 RVA: 0x002174DB File Offset: 0x002156DB
		public virtual void SetWedgeQualityMeasure(int measure)
		{
			vtkMeshQuality.vtkMeshQuality_SetWedgeQualityMeasure_174(base.GetCppThis(), measure);
		}

		// Token: 0x06017E87 RID: 97927
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetWedgeQualityMeasureToCondition_175(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of wedges.
		/// The default is EDGE_RATIO and valid values also include
		/// CONDITION, DISTORTION, EQUIANGLE_SKEW, JACOBIAN, MAX_ASPECT_FROBENIUS, MAX_STRETCH,
		/// MEAN_ASPECT_FROBENIUS, SCALED_JACOBIAN, SHAPE, and VOLUME.
		/// </summary>
		// Token: 0x06017E88 RID: 97928 RVA: 0x002174EB File Offset: 0x002156EB
		public void SetWedgeQualityMeasureToCondition()
		{
			vtkMeshQuality.vtkMeshQuality_SetWedgeQualityMeasureToCondition_175(base.GetCppThis());
		}

		// Token: 0x06017E89 RID: 97929
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetWedgeQualityMeasureToDistortion_176(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of wedges.
		/// The default is EDGE_RATIO and valid values also include
		/// CONDITION, DISTORTION, EQUIANGLE_SKEW, JACOBIAN, MAX_ASPECT_FROBENIUS, MAX_STRETCH,
		/// MEAN_ASPECT_FROBENIUS, SCALED_JACOBIAN, SHAPE, and VOLUME.
		/// </summary>
		// Token: 0x06017E8A RID: 97930 RVA: 0x002174FA File Offset: 0x002156FA
		public void SetWedgeQualityMeasureToDistortion()
		{
			vtkMeshQuality.vtkMeshQuality_SetWedgeQualityMeasureToDistortion_176(base.GetCppThis());
		}

		// Token: 0x06017E8B RID: 97931
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetWedgeQualityMeasureToEdgeRatio_177(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of wedges.
		/// The default is EDGE_RATIO and valid values also include
		/// CONDITION, DISTORTION, EQUIANGLE_SKEW, JACOBIAN, MAX_ASPECT_FROBENIUS, MAX_STRETCH,
		/// MEAN_ASPECT_FROBENIUS, SCALED_JACOBIAN, SHAPE, and VOLUME.
		/// </summary>
		// Token: 0x06017E8C RID: 97932 RVA: 0x00217509 File Offset: 0x00215709
		public void SetWedgeQualityMeasureToEdgeRatio()
		{
			vtkMeshQuality.vtkMeshQuality_SetWedgeQualityMeasureToEdgeRatio_177(base.GetCppThis());
		}

		// Token: 0x06017E8D RID: 97933
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetWedgeQualityMeasureToEquiangleSkew_178(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of wedges.
		/// The default is EDGE_RATIO and valid values also include
		/// CONDITION, DISTORTION, EQUIANGLE_SKEW, JACOBIAN, MAX_ASPECT_FROBENIUS, MAX_STRETCH,
		/// MEAN_ASPECT_FROBENIUS, SCALED_JACOBIAN, SHAPE, and VOLUME.
		/// </summary>
		// Token: 0x06017E8E RID: 97934 RVA: 0x00217518 File Offset: 0x00215718
		public void SetWedgeQualityMeasureToEquiangleSkew()
		{
			vtkMeshQuality.vtkMeshQuality_SetWedgeQualityMeasureToEquiangleSkew_178(base.GetCppThis());
		}

		// Token: 0x06017E8F RID: 97935
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetWedgeQualityMeasureToJacobian_179(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of wedges.
		/// The default is EDGE_RATIO and valid values also include
		/// CONDITION, DISTORTION, EQUIANGLE_SKEW, JACOBIAN, MAX_ASPECT_FROBENIUS, MAX_STRETCH,
		/// MEAN_ASPECT_FROBENIUS, SCALED_JACOBIAN, SHAPE, and VOLUME.
		/// </summary>
		// Token: 0x06017E90 RID: 97936 RVA: 0x00217527 File Offset: 0x00215727
		public void SetWedgeQualityMeasureToJacobian()
		{
			vtkMeshQuality.vtkMeshQuality_SetWedgeQualityMeasureToJacobian_179(base.GetCppThis());
		}

		// Token: 0x06017E91 RID: 97937
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetWedgeQualityMeasureToMaxAspectFrobenius_180(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of wedges.
		/// The default is EDGE_RATIO and valid values also include
		/// CONDITION, DISTORTION, EQUIANGLE_SKEW, JACOBIAN, MAX_ASPECT_FROBENIUS, MAX_STRETCH,
		/// MEAN_ASPECT_FROBENIUS, SCALED_JACOBIAN, SHAPE, and VOLUME.
		/// </summary>
		// Token: 0x06017E92 RID: 97938 RVA: 0x00217536 File Offset: 0x00215736
		public void SetWedgeQualityMeasureToMaxAspectFrobenius()
		{
			vtkMeshQuality.vtkMeshQuality_SetWedgeQualityMeasureToMaxAspectFrobenius_180(base.GetCppThis());
		}

		// Token: 0x06017E93 RID: 97939
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetWedgeQualityMeasureToMaxStretch_181(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of wedges.
		/// The default is EDGE_RATIO and valid values also include
		/// CONDITION, DISTORTION, EQUIANGLE_SKEW, JACOBIAN, MAX_ASPECT_FROBENIUS, MAX_STRETCH,
		/// MEAN_ASPECT_FROBENIUS, SCALED_JACOBIAN, SHAPE, and VOLUME.
		/// </summary>
		// Token: 0x06017E94 RID: 97940 RVA: 0x00217545 File Offset: 0x00215745
		public void SetWedgeQualityMeasureToMaxStretch()
		{
			vtkMeshQuality.vtkMeshQuality_SetWedgeQualityMeasureToMaxStretch_181(base.GetCppThis());
		}

		// Token: 0x06017E95 RID: 97941
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetWedgeQualityMeasureToMeanAspectFrobenius_182(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of wedges.
		/// The default is EDGE_RATIO and valid values also include
		/// CONDITION, DISTORTION, EQUIANGLE_SKEW, JACOBIAN, MAX_ASPECT_FROBENIUS, MAX_STRETCH,
		/// MEAN_ASPECT_FROBENIUS, SCALED_JACOBIAN, SHAPE, and VOLUME.
		/// </summary>
		// Token: 0x06017E96 RID: 97942 RVA: 0x00217554 File Offset: 0x00215754
		public void SetWedgeQualityMeasureToMeanAspectFrobenius()
		{
			vtkMeshQuality.vtkMeshQuality_SetWedgeQualityMeasureToMeanAspectFrobenius_182(base.GetCppThis());
		}

		// Token: 0x06017E97 RID: 97943
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetWedgeQualityMeasureToScaledJacobian_183(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of wedges.
		/// The default is EDGE_RATIO and valid values also include
		/// CONDITION, DISTORTION, EQUIANGLE_SKEW, JACOBIAN, MAX_ASPECT_FROBENIUS, MAX_STRETCH,
		/// MEAN_ASPECT_FROBENIUS, SCALED_JACOBIAN, SHAPE, and VOLUME.
		/// </summary>
		// Token: 0x06017E98 RID: 97944 RVA: 0x00217563 File Offset: 0x00215763
		public void SetWedgeQualityMeasureToScaledJacobian()
		{
			vtkMeshQuality.vtkMeshQuality_SetWedgeQualityMeasureToScaledJacobian_183(base.GetCppThis());
		}

		// Token: 0x06017E99 RID: 97945
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetWedgeQualityMeasureToShape_184(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of wedges.
		/// The default is EDGE_RATIO and valid values also include
		/// CONDITION, DISTORTION, EQUIANGLE_SKEW, JACOBIAN, MAX_ASPECT_FROBENIUS, MAX_STRETCH,
		/// MEAN_ASPECT_FROBENIUS, SCALED_JACOBIAN, SHAPE, and VOLUME.
		/// </summary>
		// Token: 0x06017E9A RID: 97946 RVA: 0x00217572 File Offset: 0x00215772
		public void SetWedgeQualityMeasureToShape()
		{
			vtkMeshQuality.vtkMeshQuality_SetWedgeQualityMeasureToShape_184(base.GetCppThis());
		}

		// Token: 0x06017E9B RID: 97947
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMeshQuality_SetWedgeQualityMeasureToVolume_185(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to measure the quality of wedges.
		/// The default is EDGE_RATIO and valid values also include
		/// CONDITION, DISTORTION, EQUIANGLE_SKEW, JACOBIAN, MAX_ASPECT_FROBENIUS, MAX_STRETCH,
		/// MEAN_ASPECT_FROBENIUS, SCALED_JACOBIAN, SHAPE, and VOLUME.
		/// </summary>
		// Token: 0x06017E9C RID: 97948 RVA: 0x00217581 File Offset: 0x00215781
		public void SetWedgeQualityMeasureToVolume()
		{
			vtkMeshQuality.vtkMeshQuality_SetWedgeQualityMeasureToVolume_185(base.GetCppThis());
		}

		// Token: 0x06017E9D RID: 97949
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TetAspectFrobenius_186(HandleRef cell);

		/// <summary>
		/// Calculate the Frobenius condition number of the transformation matrix from a regular
		/// tetrahedron to a tetrahedron.
		/// The Frobenius aspect of a tetrahedron \f$K\f$, when the reference element is
		/// regular, is:
		/// \f$\frac{\frac{3}{2}(l_{11}+l_{22}+l_{33}) - (l_{12}+l_{13}+l_{23})}
		/// {3(\sqrt{2}\det{T})^\frac{2}{3}}\f$,
		/// where \f$T\f$ and \f$l_{ij}\f$ respectively denote the edge matrix of \f$K\f$
		/// and the entries of \f$L=T^t\,T\f$.
		/// </summary>
		// Token: 0x06017E9E RID: 97950 RVA: 0x00217590 File Offset: 0x00215790
		public static double TetAspectFrobenius(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetAspectFrobenius_186((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017E9F RID: 97951
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TetAspectGamma_187(HandleRef cell);

		/// <summary>
		/// Calculate the aspect gamma of a tetrahedron.
		/// The aspect gamma of a tetrahedron is:
		/// Srms**3 / (8.479670*V) where Srms = sqrt(Sum(Si**2)/6), Si = edge length.
		/// </summary>
		// Token: 0x06017EA0 RID: 97952 RVA: 0x002175C0 File Offset: 0x002157C0
		public static double TetAspectGamma(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetAspectGamma_187((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EA1 RID: 97953
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TetAspectRatio_188(HandleRef cell);

		/// <summary>
		/// Calculate the aspect ratio of a tetrahedron.
		/// The aspect ratio of a tetrahedron \f$K\f$ is:
		/// \f$\frac{|K|_\infty}{2\sqrt{6}r}\f$,
		/// where \f$|K|_\infty\f$ and \f$r\f$ respectively denote the greatest edge
		/// length and the inradius of \f$K\f$.
		/// </summary>
		// Token: 0x06017EA2 RID: 97954 RVA: 0x002175F0 File Offset: 0x002157F0
		public static double TetAspectRatio(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetAspectRatio_188((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EA3 RID: 97955
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TetCollapseRatio_189(HandleRef cell);

		/// <summary>
		/// Calculate the collapse ratio of a tetrahedron.
		/// The collapse ratio is a dimensionless number defined as the smallest ratio of the
		/// height of a vertex above its opposing triangle to the longest edge of that opposing
		/// triangle across all vertices of the tetrahedron.
		/// </summary>
		// Token: 0x06017EA4 RID: 97956 RVA: 0x00217620 File Offset: 0x00215820
		public static double TetCollapseRatio(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetCollapseRatio_189((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EA5 RID: 97957
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TetCondition_190(HandleRef cell);

		/// <summary>
		/// Calculate the condition number of a tetrahedron.
		/// The condition number of a tetrahedron is Condition number of the Jacobian matrix at any corner.
		/// </summary>
		// Token: 0x06017EA6 RID: 97958 RVA: 0x00217650 File Offset: 0x00215850
		public static double TetCondition(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetCondition_190((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EA7 RID: 97959
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TetDistortion_191(HandleRef cell);

		/// <summary>
		/// Calculate the distortion of a tetrahedron.
		/// The distortion of a quadrilateral is {min(|J|)/actual volume} * parent volume,
		/// parent volume = 1 / 6 for a tetrahedron.
		/// </summary>
		// Token: 0x06017EA8 RID: 97960 RVA: 0x00217680 File Offset: 0x00215880
		public static double TetDistortion(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetDistortion_191((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EA9 RID: 97961
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TetEdgeRatio_192(HandleRef cell);

		/// <summary>
		/// Calculate the edge ratio of a tetrahedron.
		/// The edge ratio of a tetrahedron \f$K\f$ is:
		/// \f$\frac{|K|_\infty}{|K|_0}\f$,
		/// where \f$|K|_\infty\f$ and \f$|K|_0\f$ respectively denote the greatest and
		/// the smallest edge lengths of \f$K\f$.
		/// </summary>
		// Token: 0x06017EAA RID: 97962 RVA: 0x002176B0 File Offset: 0x002158B0
		public static double TetEdgeRatio(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetEdgeRatio_192((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EAB RID: 97963
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TetEquiangleSkew_193(HandleRef cell);

		/// <summary>
		/// Calculate the equiangle skew of a tetrahedron.
		/// </summary>
		// Token: 0x06017EAC RID: 97964 RVA: 0x002176E0 File Offset: 0x002158E0
		public static double TetEquiangleSkew(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetEquiangleSkew_193((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EAD RID: 97965
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TetEquivolumeSkew_194(HandleRef cell);

		/// <summary>
		/// Calculate the equivolume skew of a tetrahedron.
		/// </summary>
		// Token: 0x06017EAE RID: 97966 RVA: 0x00217710 File Offset: 0x00215910
		public static double TetEquivolumeSkew(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetEquivolumeSkew_194((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EAF RID: 97967
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TetJacobian_195(HandleRef cell);

		/// <summary>
		/// Calculate the Jacobian of a tetrahedron.
		/// The jacobian of a tetrahedron is the minimum point-wise volume at any corner.
		/// </summary>
		// Token: 0x06017EB0 RID: 97968 RVA: 0x00217740 File Offset: 0x00215940
		public static double TetJacobian(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetJacobian_195((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EB1 RID: 97969
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TetMeanRatio_196(HandleRef cell);

		/// <summary>
		/// Calculate the mean ratio of a tetrahedron.
		/// The mean ratio of a tetrahedron is the ratio of tetrahedron volume over the volume of an
		/// equilateral tetrahedron with the same RMS edge length.
		/// </summary>
		// Token: 0x06017EB2 RID: 97970 RVA: 0x00217770 File Offset: 0x00215970
		public static double TetMeanRatio(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetMeanRatio_196((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EB3 RID: 97971
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TetMinAngle_197(HandleRef cell);

		/// <summary>
		/// Calculate the minimal (nonoriented) dihedral angle of a tetrahedron, expressed in degrees.
		/// </summary>
		// Token: 0x06017EB4 RID: 97972 RVA: 0x002177A0 File Offset: 0x002159A0
		public static double TetMinAngle(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetMinAngle_197((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EB5 RID: 97973
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TetNormalizedInradius_198(HandleRef cell);

		/// <summary>
		/// Calculate the normalized in-radius of a tetrahedron.
		/// The minimum normalized in-radius of a tetrahedron is the ratio of the minimum
		/// sub-tetrahedron inner radius to the outer tetrahedron radius.
		/// </summary>
		// Token: 0x06017EB6 RID: 97974 RVA: 0x002177D0 File Offset: 0x002159D0
		public static double TetNormalizedInradius(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetNormalizedInradius_198((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EB7 RID: 97975
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TetRadiusRatio_199(HandleRef cell);

		/// <summary>
		/// Calculate the radius ratio of a tetrahedron.
		/// The radius ratio of a tetrahedron \f$K\f$ is:
		/// \f$\frac{R}{3r}\f$,
		/// where \f$R\f$ and \f$r\f$ respectively denote the circumradius and
		/// the inradius of \f$K\f$.
		/// </summary>
		// Token: 0x06017EB8 RID: 97976 RVA: 0x00217800 File Offset: 0x00215A00
		public static double TetRadiusRatio(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetRadiusRatio_199((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EB9 RID: 97977
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TetRelativeSizeSquared_200(HandleRef cell);

		/// <summary>
		/// Calculate the relative size squared of a tetrahedron.
		/// The relative size squared of a tetrahedron is Min(J, 1 / J), where J is determinant
		/// of weighted Jacobian matrix.
		///
		/// Note: TetRelativeSizeSquared will return 0.0 if the MeshQuality filter has NOT
		/// been executed, because it relies on the average tet size.
		/// </summary>
		// Token: 0x06017EBA RID: 97978 RVA: 0x00217830 File Offset: 0x00215A30
		public static double TetRelativeSizeSquared(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetRelativeSizeSquared_200((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EBB RID: 97979
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TetScaledJacobian_201(HandleRef cell);

		/// <summary>
		/// Calculate the scaled Jacobian of a tetrahedron.
		/// The scaled jacobian of a tetrahedron is the minimum Jacobian divided
		/// by the lengths of 3 edge vectors.
		/// </summary>
		// Token: 0x06017EBC RID: 97980 RVA: 0x00217860 File Offset: 0x00215A60
		public static double TetScaledJacobian(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetScaledJacobian_201((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EBD RID: 97981
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TetShape_202(HandleRef cell);

		/// <summary>
		/// Calculate the shape of a tetrahedron.
		/// The shape of a tetrahedron is 3 / Mean Ratio of weighted Jacobian matrix.
		/// </summary>
		// Token: 0x06017EBE RID: 97982 RVA: 0x00217890 File Offset: 0x00215A90
		public static double TetShape(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetShape_202((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EBF RID: 97983
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TetShapeAndSize_203(HandleRef cell);

		/// <summary>
		/// Calculate the shape and size of a tetrahedron.
		/// The shape and size of a tetrahedron is product of shape and average size.
		///
		/// Note: TetShapeAndSize will return 0.0 if the MeshQuality filter has NOT
		/// been executed, because it relies on the average tet size.
		/// </summary>
		// Token: 0x06017EC0 RID: 97984 RVA: 0x002178C0 File Offset: 0x00215AC0
		public static double TetShapeAndSize(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetShapeAndSize_203((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EC1 RID: 97985
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TetSquishIndex_204(HandleRef cell);

		/// <summary>
		/// Calculate the squish index of a tetrahedron.
		/// </summary>
		// Token: 0x06017EC2 RID: 97986 RVA: 0x002178F0 File Offset: 0x00215AF0
		public static double TetSquishIndex(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetSquishIndex_204((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EC3 RID: 97987
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TetVolume_205(HandleRef cell);

		/// <summary>
		/// Calculate the volume of a tetrahedron.
		/// The volume of a tetrahedron is (1/6) * Jacobian at corner node.
		/// </summary>
		// Token: 0x06017EC4 RID: 97988 RVA: 0x00217920 File Offset: 0x00215B20
		public static double TetVolume(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TetVolume_205((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EC5 RID: 97989
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TriangleArea_206(HandleRef cell);

		/// <summary>
		/// Calculate the area of a triangle.
		/// </summary>
		// Token: 0x06017EC6 RID: 97990 RVA: 0x00217950 File Offset: 0x00215B50
		public static double TriangleArea(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TriangleArea_206((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EC7 RID: 97991
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TriangleAspectFrobenius_207(HandleRef cell);

		/// <summary>
		/// Calculate the Frobenius condition number of the transformation matrix from an equilateral
		/// triangle to a triangle.
		/// The Frobenius aspect of a triangle \f$t\f$, when the reference element is
		/// equilateral, is:
		/// \f$\frac{|t|^2_2}{2\sqrt{3}{\cal A}}\f$,
		/// where \f$|t|^2_2\f$ and \f$\cal A\f$ respectively denote the sum of the
		/// squared edge lengths and the area of \f$t\f$.
		/// </summary>
		// Token: 0x06017EC8 RID: 97992 RVA: 0x00217980 File Offset: 0x00215B80
		public static double TriangleAspectFrobenius(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TriangleAspectFrobenius_207((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EC9 RID: 97993
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TriangleAspectRatio_208(HandleRef cell);

		/// <summary>
		/// Calculate the aspect ratio of a triangle.
		/// The aspect ratio of a triangle \f$t\f$ is:
		/// \f$\frac{|t|_\infty}{2\sqrt{3}r}\f$,
		/// where \f$|t|_\infty\f$ and \f$r\f$ respectively denote the greatest edge
		/// length and the inradius of \f$t\f$.
		/// </summary>
		// Token: 0x06017ECA RID: 97994 RVA: 0x002179B0 File Offset: 0x00215BB0
		public static double TriangleAspectRatio(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TriangleAspectRatio_208((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017ECB RID: 97995
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TriangleCondition_209(HandleRef cell);

		/// <summary>
		/// Calculate the condition number of a triangle.
		/// </summary>
		// Token: 0x06017ECC RID: 97996 RVA: 0x002179E0 File Offset: 0x00215BE0
		public static double TriangleCondition(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TriangleCondition_209((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017ECD RID: 97997
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TriangleDistortion_210(HandleRef cell);

		/// <summary>
		/// Calculate the distortion of a triangle.
		/// </summary>
		// Token: 0x06017ECE RID: 97998 RVA: 0x00217A10 File Offset: 0x00215C10
		public static double TriangleDistortion(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TriangleDistortion_210((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017ECF RID: 97999
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TriangleEdgeRatio_211(HandleRef cell);

		/// <summary>
		/// Calculate the edge ratio of a triangle.
		/// The edge ratio of a triangle \f$t\f$ is:
		/// \f$\frac{|t|_\infty}{|t|_0}\f$,
		/// where \f$|t|_\infty\f$ and \f$|t|_0\f$ respectively denote the greatest and
		/// the smallest edge lengths of \f$t\f$.
		/// </summary>
		// Token: 0x06017ED0 RID: 98000 RVA: 0x00217A40 File Offset: 0x00215C40
		public static double TriangleEdgeRatio(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TriangleEdgeRatio_211((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017ED1 RID: 98001
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TriangleEquiangleSkew_212(HandleRef cell);

		/// <summary>
		/// Calculate the equiangle skew of a triangle.
		/// </summary>
		// Token: 0x06017ED2 RID: 98002 RVA: 0x00217A70 File Offset: 0x00215C70
		public static double TriangleEquiangleSkew(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TriangleEquiangleSkew_212((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017ED3 RID: 98003
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TriangleMaxAngle_213(HandleRef cell);

		/// <summary>
		/// Calculate the maximal (nonoriented) angle of a triangle, expressed in degrees.
		/// </summary>
		// Token: 0x06017ED4 RID: 98004 RVA: 0x00217AA0 File Offset: 0x00215CA0
		public static double TriangleMaxAngle(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TriangleMaxAngle_213((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017ED5 RID: 98005
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TriangleMinAngle_214(HandleRef cell);

		/// <summary>
		/// Calculate the minimal (nonoriented) angle of a triangle, expressed in degrees.
		/// </summary>
		// Token: 0x06017ED6 RID: 98006 RVA: 0x00217AD0 File Offset: 0x00215CD0
		public static double TriangleMinAngle(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TriangleMinAngle_214((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017ED7 RID: 98007
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TriangleNormalizedInradius_215(HandleRef cell);

		/// <summary>
		/// Calculate the normalized in-radius of a triangle.
		/// The minimum normalized in-radius of a triangle is the ratio of the minimum
		/// sub-triangle inner radius to the outer triangle radius.
		/// </summary>
		// Token: 0x06017ED8 RID: 98008 RVA: 0x00217B00 File Offset: 0x00215D00
		public static double TriangleNormalizedInradius(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TriangleNormalizedInradius_215((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017ED9 RID: 98009
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TriangleRadiusRatio_216(HandleRef cell);

		/// <summary>
		/// Calculate the radius ratio of a triangle.
		/// The radius ratio of a triangle \f$t\f$ is:
		/// \f$\frac{R}{2r}\f$,
		/// where \f$R\f$ and \f$r\f$ respectively denote the circumradius and
		/// the inradius of \f$t\f$.
		/// </summary>
		// Token: 0x06017EDA RID: 98010 RVA: 0x00217B30 File Offset: 0x00215D30
		public static double TriangleRadiusRatio(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TriangleRadiusRatio_216((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EDB RID: 98011
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TriangleRelativeSizeSquared_217(HandleRef cell);

		/// <summary>
		/// Calculate the square of the relative size of a triangle.
		///
		/// Note: TriangleRelativeSizeSquared will return 0.0 if the MeshQuality filter has NOT
		/// been executed, because it relies on the average triangle size.
		/// </summary>
		// Token: 0x06017EDC RID: 98012 RVA: 0x00217B60 File Offset: 0x00215D60
		public static double TriangleRelativeSizeSquared(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TriangleRelativeSizeSquared_217((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EDD RID: 98013
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TriangleScaledJacobian_218(HandleRef cell);

		/// <summary>
		/// Calculate the scaled Jacobian of a triangle.
		/// </summary>
		// Token: 0x06017EDE RID: 98014 RVA: 0x00217B90 File Offset: 0x00215D90
		public static double TriangleScaledJacobian(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TriangleScaledJacobian_218((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EDF RID: 98015
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TriangleShape_219(HandleRef cell);

		/// <summary>
		/// Calculate the shape of a triangle.
		/// </summary>
		// Token: 0x06017EE0 RID: 98016 RVA: 0x00217BC0 File Offset: 0x00215DC0
		public static double TriangleShape(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TriangleShape_219((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EE1 RID: 98017
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_TriangleShapeAndSize_220(HandleRef cell);

		/// <summary>
		/// Calculate the product of shape and relative size of a triangle.
		///
		/// Note: TriangleShapeAndSize will return 0.0 if the MeshQuality filter has NOT
		/// been executed, because it relies on the average triangle size.
		/// </summary>
		// Token: 0x06017EE2 RID: 98018 RVA: 0x00217BF0 File Offset: 0x00215DF0
		public static double TriangleShapeAndSize(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_TriangleShapeAndSize_220((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EE3 RID: 98019
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_WedgeCondition_221(HandleRef cell);

		/// <summary>
		/// Calculate the condition number of a wedge.
		/// The condition number of a wedge is equivalent to the max aspect Frobenius.
		/// </summary>
		// Token: 0x06017EE4 RID: 98020 RVA: 0x00217C20 File Offset: 0x00215E20
		public static double WedgeCondition(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_WedgeCondition_221((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EE5 RID: 98021
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_WedgeDistortion_222(HandleRef cell);

		/// <summary>
		/// Calculate the distortion of a wedge.
		/// The distortion of a wedge is {min(|J|) / actual volume } * parent volume.
		/// </summary>
		// Token: 0x06017EE6 RID: 98022 RVA: 0x00217C50 File Offset: 0x00215E50
		public static double WedgeDistortion(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_WedgeDistortion_222((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EE7 RID: 98023
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_WedgeEdgeRatio_223(HandleRef cell);

		/// <summary>
		/// Calculate the edge ratio of a wedge.
		/// The edge ratio of a wedge is Hmax / Hmin, where Hmax and Hmin are respectively
		/// the maximum and the minimum edge lengths.
		/// </summary>
		// Token: 0x06017EE8 RID: 98024 RVA: 0x00217C80 File Offset: 0x00215E80
		public static double WedgeEdgeRatio(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_WedgeEdgeRatio_223((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EE9 RID: 98025
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_WedgeEquiangleSkew_224(HandleRef cell);

		/// <summary>
		/// Calculate the equiangle skew of a wedge.
		/// </summary>
		// Token: 0x06017EEA RID: 98026 RVA: 0x00217CB0 File Offset: 0x00215EB0
		public static double WedgeEquiangleSkew(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_WedgeEquiangleSkew_224((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EEB RID: 98027
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_WedgeJacobian_225(HandleRef cell);

		/// <summary>
		/// Calculate the Jacobian of a wedge.
		/// The jacobian of a wedge is the min{((L_2 X L_0) * L_3)_k}.
		/// </summary>
		// Token: 0x06017EEC RID: 98028 RVA: 0x00217CE0 File Offset: 0x00215EE0
		public static double WedgeJacobian(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_WedgeJacobian_225((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EED RID: 98029
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_WedgeMaxAspectFrobenius_226(HandleRef cell);

		/// <summary>
		/// Calculate the max aspect Frobenius of a wedge.
		/// The max aspect Frobenius of a wedge is max(F_0123, F_1204, F_2015, F_3540, F_4351, F_5432).
		/// </summary>
		// Token: 0x06017EEE RID: 98030 RVA: 0x00217D10 File Offset: 0x00215F10
		public static double WedgeMaxAspectFrobenius(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_WedgeMaxAspectFrobenius_226((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EEF RID: 98031
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_WedgeMaxStretch_227(HandleRef cell);

		/// <summary>
		/// Calculate the max stretch of a wedge.
		/// The maximum stretch of a wedge is maximum stretch (S) of the three quadrilateral faces:
		/// q = max[S_1043, S_1254, S_2035]
		/// </summary>
		// Token: 0x06017EF0 RID: 98032 RVA: 0x00217D40 File Offset: 0x00215F40
		public static double WedgeMaxStretch(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_WedgeMaxStretch_227((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EF1 RID: 98033
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_WedgeMeanAspectFrobenius_228(HandleRef cell);

		/// <summary>
		/// Calculate the mean aspect Frobenius of a wedge.
		/// The mean aspect Frobenius of a wedge is:
		/// 1/6 * (F_0123 + F_1204 + F+2015 + F_3540 + F_4351 + F_5432).
		/// </summary>
		// Token: 0x06017EF2 RID: 98034 RVA: 0x00217D70 File Offset: 0x00215F70
		public static double WedgeMeanAspectFrobenius(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_WedgeMeanAspectFrobenius_228((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EF3 RID: 98035
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_WedgeScaledJacobian_229(HandleRef cell);

		/// <summary>
		/// Calculate the scaled Jacobian a wedge.
		/// The jacobian of a wedge is the minimum point-wise volume at any corner divided by the
		/// corresponding edge lengths and normalized to the unit wedge:
		/// q = min(  2 / sqrt(3) * ((L_2 X L_0) * L_3)_k / sqrt(mag(L_2) * mag(L_0) * mag(L_3))),
		/// where ((L_2 X L_0) * L_3)_k is the determinant of the Jacobian of the tetrahedron defined
		/// at the kth corner node, and L_2, L_0 and L_3 are the edges defined according to the
		/// standard for tetrahedral elements.
		/// </summary>
		// Token: 0x06017EF4 RID: 98036 RVA: 0x00217DA0 File Offset: 0x00215FA0
		public static double WedgeScaledJacobian(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_WedgeScaledJacobian_229((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EF5 RID: 98037
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_WedgeShape_230(HandleRef cell);

		/// <summary>
		/// Calculate the shape of a wedge.
		/// The shape of a wedge is 3 divided by the minimum mean ratio of the Jacobian matrix at each
		/// element corner.
		/// </summary>
		// Token: 0x06017EF6 RID: 98038 RVA: 0x00217DD0 File Offset: 0x00215FD0
		public static double WedgeShape(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_WedgeShape_230((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		// Token: 0x06017EF7 RID: 98039
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMeshQuality_WedgeVolume_231(HandleRef cell);

		/// <summary>
		/// Calculate the volume of a wedge.
		/// </summary>
		// Token: 0x06017EF8 RID: 98040 RVA: 0x00217E00 File Offset: 0x00216000
		public static double WedgeVolume(vtkCell cell)
		{
			return vtkMeshQuality.vtkMeshQuality_WedgeVolume_231((cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A81 RID: 6785
		public new const string MRFullTypeName = "Kitware.VTK.vtkMeshQuality";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A82 RID: 6786
		public new static readonly string MRClassNameKey = "class vtkMeshQuality";

		/// <summary>
		/// Enum which lists the Quality Measures Types
		/// </summary>
		// Token: 0x02000902 RID: 2306
		public enum QualityMeasureTypes
		{
			/// <summary>enum member</summary>
			// Token: 0x04001A84 RID: 6788
			AREA = 28,
			/// <summary>enum member</summary>
			// Token: 0x04001A85 RID: 6789
			ASPECT_FROBENIUS = 3,
			/// <summary>enum member</summary>
			// Token: 0x04001A86 RID: 6790
			ASPECT_GAMMA = 27,
			/// <summary>enum member</summary>
			// Token: 0x04001A87 RID: 6791
			ASPECT_RATIO = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001A88 RID: 6792
			COLLAPSE_RATIO = 7,
			/// <summary>enum member</summary>
			// Token: 0x04001A89 RID: 6793
			CONDITION = 9,
			/// <summary>enum member</summary>
			// Token: 0x04001A8A RID: 6794
			DIAGONAL = 21,
			/// <summary>enum member</summary>
			// Token: 0x04001A8B RID: 6795
			DIMENSION,
			/// <summary>enum member</summary>
			// Token: 0x04001A8C RID: 6796
			DISTORTION = 15,
			/// <summary>enum member</summary>
			// Token: 0x04001A8D RID: 6797
			EDGE_RATIO = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001A8E RID: 6798
			EQUIANGLE_SKEW = 29,
			/// <summary>enum member</summary>
			// Token: 0x04001A8F RID: 6799
			EQUIVOLUME_SKEW,
			/// <summary>enum member</summary>
			// Token: 0x04001A90 RID: 6800
			JACOBIAN = 25,
			/// <summary>enum member</summary>
			// Token: 0x04001A91 RID: 6801
			MAX_ANGLE = 8,
			/// <summary>enum member</summary>
			// Token: 0x04001A92 RID: 6802
			MAX_ASPECT_FROBENIUS = 5,
			/// <summary>enum member</summary>
			// Token: 0x04001A93 RID: 6803
			MAX_EDGE_RATIO = 16,
			/// <summary>enum member</summary>
			// Token: 0x04001A94 RID: 6804
			MAX_STRETCH = 31,
			/// <summary>enum member</summary>
			// Token: 0x04001A95 RID: 6805
			MEAN_ASPECT_FROBENIUS,
			/// <summary>enum member</summary>
			// Token: 0x04001A96 RID: 6806
			MEAN_RATIO,
			/// <summary>enum member</summary>
			// Token: 0x04001A97 RID: 6807
			MED_ASPECT_FROBENIUS = 4,
			/// <summary>enum member</summary>
			// Token: 0x04001A98 RID: 6808
			MIN_ANGLE = 6,
			/// <summary>enum member</summary>
			// Token: 0x04001A99 RID: 6809
			NODAL_JACOBIAN_RATIO = 34,
			/// <summary>enum member</summary>
			// Token: 0x04001A9A RID: 6810
			NONE = 37,
			/// <summary>enum member</summary>
			// Token: 0x04001A9B RID: 6811
			NORMALIZED_INRADIUS = 35,
			/// <summary>enum member</summary>
			// Token: 0x04001A9C RID: 6812
			ODDY = 23,
			/// <summary>enum member</summary>
			// Token: 0x04001A9D RID: 6813
			RADIUS_RATIO = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001A9E RID: 6814
			RELATIVE_SIZE_SQUARED = 12,
			/// <summary>enum member</summary>
			// Token: 0x04001A9F RID: 6815
			SCALED_JACOBIAN = 10,
			/// <summary>enum member</summary>
			// Token: 0x04001AA0 RID: 6816
			SHAPE = 13,
			/// <summary>enum member</summary>
			// Token: 0x04001AA1 RID: 6817
			SHAPE_AND_SIZE,
			/// <summary>enum member</summary>
			// Token: 0x04001AA2 RID: 6818
			SHEAR = 11,
			/// <summary>enum member</summary>
			// Token: 0x04001AA3 RID: 6819
			SHEAR_AND_SIZE = 24,
			/// <summary>enum member</summary>
			// Token: 0x04001AA4 RID: 6820
			SKEW = 17,
			/// <summary>enum member</summary>
			// Token: 0x04001AA5 RID: 6821
			SQUISH_INDEX = 36,
			/// <summary>enum member</summary>
			// Token: 0x04001AA6 RID: 6822
			STRETCH = 20,
			/// <summary>enum member</summary>
			// Token: 0x04001AA7 RID: 6823
			TAPER = 18,
			/// <summary>enum member</summary>
			// Token: 0x04001AA8 RID: 6824
			TOTAL_QUALITY_MEASURE_TYPES = 37,
			/// <summary>enum member</summary>
			// Token: 0x04001AA9 RID: 6825
			VOLUME = 19,
			/// <summary>enum member</summary>
			// Token: 0x04001AAA RID: 6826
			WARPAGE = 26
		}
	}
}
