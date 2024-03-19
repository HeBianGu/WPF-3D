using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkQuadricDecimation
	/// </summary>
	/// <remarks>
	///    reduce the number of triangles in a mesh
	///
	/// vtkQuadricDecimation is a filter to reduce the number of triangles in
	/// a triangle mesh, forming a good approximation to the original geometry.
	/// The input to vtkQuadricDecimation is a vtkPolyData object, and only
	/// triangles are treated. If you desire to decimate polygonal meshes, first
	/// triangulate the polygons with vtkTriangleFilter.
	///
	/// The algorithm is based on repeated edge collapses until the requested mesh
	/// reduction is achieved. Edges are placed in a priority queue based on the
	/// "cost" to delete the edge. The cost is an approximate measure of error
	/// (distance to the original surface)--described by the so-called quadric
	/// error measure. The quadric error measure is associated with each vertex of
	/// the mesh and represents a matrix of planes incident on that vertex. The
	/// distance of the planes to the vertex is the error in the position of the
	/// vertex (originally the vertex error iz zero). As edges are deleted, the
	/// quadric error measure associated with the two end points of the edge are
	/// summed (this combines the plane equations) and an optimal collapse point
	/// can be computed. Edges connected to the collapse point are then reinserted
	/// into the queue after computing the new cost to delete them. The process
	/// continues until the desired reduction level is reached or topological
	/// constraints prevent further reduction. Note that this basic algorithm can
	/// be extended to higher dimensions by
	/// taking into account variation in attributes (i.e., scalars, vectors, and
	/// so on).
	///
	/// This paper is based on the work of Garland and Heckbert who first
	/// presented the quadric error measure at Siggraph '97 "Surface
	/// Simplification Using Quadric Error Metrics". For details of the algorithm
	/// Michael Garland's Ph.D. thesis is also recommended. Hughues Hoppe's Vis
	/// '99 paper, "New Quadric Metric for Simplifying Meshes with Appearance
	/// Attributes" is also a good take on the subject especially as it pertains
	/// to the error metric applied to attributes.
	///
	/// @par Thanks:
	/// Thanks to Bradley Lowekamp of the National Library of Medicine/NIH for
	/// contributing this class.
	/// </remarks>
	// Token: 0x02000990 RID: 2448
	public class vtkQuadricDecimation : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060198B7 RID: 104631 RVA: 0x00238B15 File Offset: 0x00236D15
		static vtkQuadricDecimation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkQuadricDecimation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadricDecimation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060198B8 RID: 104632 RVA: 0x00238B3D File Offset: 0x00236D3D
		public vtkQuadricDecimation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060198B9 RID: 104633
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadricDecimation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060198BA RID: 104634 RVA: 0x00238B4C File Offset: 0x00236D4C
		public new static vtkQuadricDecimation New()
		{
			vtkQuadricDecimation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadricDecimation.vtkQuadricDecimation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadricDecimation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060198BB RID: 104635 RVA: 0x00238BA0 File Offset: 0x00236DA0
		public vtkQuadricDecimation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkQuadricDecimation.vtkQuadricDecimation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060198BC RID: 104636 RVA: 0x00238BE4 File Offset: 0x00236DE4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060198BD RID: 104637
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_AttributeErrorMetricOff_01(HandleRef pThis);

		/// <summary>
		/// Decide whether to include data attributes in the error metric. If off,
		/// then only geometric error is used to control the decimation. By default
		/// the attribute errors are off.
		/// </summary>
		// Token: 0x060198BE RID: 104638 RVA: 0x00238BEF File Offset: 0x00236DEF
		public virtual void AttributeErrorMetricOff()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_AttributeErrorMetricOff_01(base.GetCppThis());
		}

		// Token: 0x060198BF RID: 104639
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_AttributeErrorMetricOn_02(HandleRef pThis);

		/// <summary>
		/// Decide whether to include data attributes in the error metric. If off,
		/// then only geometric error is used to control the decimation. By default
		/// the attribute errors are off.
		/// </summary>
		// Token: 0x060198C0 RID: 104640 RVA: 0x00238BFE File Offset: 0x00236DFE
		public virtual void AttributeErrorMetricOn()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_AttributeErrorMetricOn_02(base.GetCppThis());
		}

		// Token: 0x060198C1 RID: 104641
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkQuadricDecimation_GetActualReduction_03(HandleRef pThis);

		/// <summary>
		/// Get the actual reduction. This value is only valid after the
		/// filter has executed.
		/// </summary>
		// Token: 0x060198C2 RID: 104642 RVA: 0x00238C10 File Offset: 0x00236E10
		public virtual double GetActualReduction()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetActualReduction_03(base.GetCppThis());
		}

		// Token: 0x060198C3 RID: 104643
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricDecimation_GetAttributeErrorMetric_04(HandleRef pThis);

		/// <summary>
		/// Decide whether to include data attributes in the error metric. If off,
		/// then only geometric error is used to control the decimation. By default
		/// the attribute errors are off.
		/// </summary>
		// Token: 0x060198C4 RID: 104644 RVA: 0x00238C30 File Offset: 0x00236E30
		public virtual int GetAttributeErrorMetric()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetAttributeErrorMetric_04(base.GetCppThis());
		}

		// Token: 0x060198C5 RID: 104645
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkQuadricDecimation_GetBoundaryWeightFactor_05(HandleRef pThis);

		/// <summary>
		/// Parameters related to the treatment of the boundary of the mesh during decimation.
		///
		/// WeighBoundaryConstraintsByLength: When this boolean is set to true, use the legacy weighting by
		/// boundary_edge_length instead of by boundary_edge_length^2 for backwards compatibility (default
		/// to false) BoundaryWeightFactor: A floating point factor to weigh the boundary quadric
		/// constraints by: higher factors further constrain the boundary.
		/// </summary>
		// Token: 0x060198C6 RID: 104646 RVA: 0x00238C50 File Offset: 0x00236E50
		public virtual double GetBoundaryWeightFactor()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetBoundaryWeightFactor_05(base.GetCppThis());
		}

		// Token: 0x060198C7 RID: 104647
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkQuadricDecimation_GetMapPointData_06(HandleRef pThis);

		/// <summary>
		/// Getter/Setter for mapping point data to the output during decimation.
		/// </summary>
		// Token: 0x060198C8 RID: 104648 RVA: 0x00238C70 File Offset: 0x00236E70
		public virtual bool GetMapPointData()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetMapPointData_06(base.GetCppThis()) != 0;
		}

		// Token: 0x060198C9 RID: 104649
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricDecimation_GetNormalsAttribute_07(HandleRef pThis);

		/// <summary>
		/// If attribute errors are to be included in the metric (i.e.,
		/// AttributeErrorMetric is on), then the following flags control which
		/// attributes are to be included in the error calculation. By default all
		/// of these are on.
		/// </summary>
		// Token: 0x060198CA RID: 104650 RVA: 0x00238C98 File Offset: 0x00236E98
		public virtual int GetNormalsAttribute()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetNormalsAttribute_07(base.GetCppThis());
		}

		// Token: 0x060198CB RID: 104651
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkQuadricDecimation_GetNormalsWeight_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the scaling weight contribution of the attribute. These
		/// values are used to weight the contribution of the attributes
		/// towards the error metric.
		/// </summary>
		// Token: 0x060198CC RID: 104652 RVA: 0x00238CB8 File Offset: 0x00236EB8
		public virtual double GetNormalsWeight()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetNormalsWeight_08(base.GetCppThis());
		}

		// Token: 0x060198CD RID: 104653
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadricDecimation_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060198CE RID: 104654 RVA: 0x00238CD8 File Offset: 0x00236ED8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x060198CF RID: 104655
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadricDecimation_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060198D0 RID: 104656 RVA: 0x00238CF8 File Offset: 0x00236EF8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x060198D1 RID: 104657
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkQuadricDecimation_GetRegularization_11(HandleRef pThis);

		/// <summary>
		/// Parameters related to adding a probabilistic uncertainty to the position and normals of the
		/// quadrics following [1]. The goal using these parameters is to regularize the point finding
		/// algorithm so as to have better quality mesh elements at the cost of a slightly lower precision
		/// on the geometry potentially (mostly at sharp edges). Can also be useful for decimating meshes
		/// that have been triangulated on noisy data.
		///
		/// Regularize: boolean property determining whether or not to use the regularization method
		/// Regularization: user defined variable that can be used to adjust the level of
		/// regularization. One can think of it as the standard deviation of the probability distribution
		/// of normals in the context of noisy data.
		///
		/// [1] P. Trettner and L. Kobbelt, Fast and Robust QEF Minimization using Probabilistic Quadrics,
		/// EUROGRAPHICS, Volume 39, Number 2 (2020)
		/// </summary>
		// Token: 0x060198D2 RID: 104658 RVA: 0x00238D14 File Offset: 0x00236F14
		public virtual double GetRegularization()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetRegularization_11(base.GetCppThis());
		}

		// Token: 0x060198D3 RID: 104659
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricDecimation_GetRegularize_12(HandleRef pThis);

		/// <summary>
		/// Parameters related to adding a probabilistic uncertainty to the position and normals of the
		/// quadrics following [1]. The goal using these parameters is to regularize the point finding
		/// algorithm so as to have better quality mesh elements at the cost of a slightly lower precision
		/// on the geometry potentially (mostly at sharp edges). Can also be useful for decimating meshes
		/// that have been triangulated on noisy data.
		///
		/// Regularize: boolean property determining whether or not to use the regularization method
		/// Regularization: user defined variable that can be used to adjust the level of
		/// regularization. One can think of it as the standard deviation of the probability distribution
		/// of normals in the context of noisy data.
		///
		/// [1] P. Trettner and L. Kobbelt, Fast and Robust QEF Minimization using Probabilistic Quadrics,
		/// EUROGRAPHICS, Volume 39, Number 2 (2020)
		/// </summary>
		// Token: 0x060198D4 RID: 104660 RVA: 0x00238D34 File Offset: 0x00236F34
		public virtual int GetRegularize()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetRegularize_12(base.GetCppThis());
		}

		// Token: 0x060198D5 RID: 104661
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricDecimation_GetScalarsAttribute_13(HandleRef pThis);

		/// <summary>
		/// If attribute errors are to be included in the metric (i.e.,
		/// AttributeErrorMetric is on), then the following flags control which
		/// attributes are to be included in the error calculation. By default all
		/// of these are on.
		/// </summary>
		// Token: 0x060198D6 RID: 104662 RVA: 0x00238D54 File Offset: 0x00236F54
		public virtual int GetScalarsAttribute()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetScalarsAttribute_13(base.GetCppThis());
		}

		// Token: 0x060198D7 RID: 104663
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkQuadricDecimation_GetScalarsWeight_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the scaling weight contribution of the attribute. These
		/// values are used to weight the contribution of the attributes
		/// towards the error metric.
		/// </summary>
		// Token: 0x060198D8 RID: 104664 RVA: 0x00238D74 File Offset: 0x00236F74
		public virtual double GetScalarsWeight()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetScalarsWeight_14(base.GetCppThis());
		}

		// Token: 0x060198D9 RID: 104665
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricDecimation_GetTCoordsAttribute_15(HandleRef pThis);

		/// <summary>
		/// If attribute errors are to be included in the metric (i.e.,
		/// AttributeErrorMetric is on), then the following flags control which
		/// attributes are to be included in the error calculation. By default all
		/// of these are on.
		/// </summary>
		// Token: 0x060198DA RID: 104666 RVA: 0x00238D94 File Offset: 0x00236F94
		public virtual int GetTCoordsAttribute()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetTCoordsAttribute_15(base.GetCppThis());
		}

		// Token: 0x060198DB RID: 104667
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkQuadricDecimation_GetTCoordsWeight_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the scaling weight contribution of the attribute. These
		/// values are used to weight the contribution of the attributes
		/// towards the error metric.
		/// </summary>
		// Token: 0x060198DC RID: 104668 RVA: 0x00238DB4 File Offset: 0x00236FB4
		public virtual double GetTCoordsWeight()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetTCoordsWeight_16(base.GetCppThis());
		}

		// Token: 0x060198DD RID: 104669
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkQuadricDecimation_GetTargetReduction_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the desired reduction (expressed as a fraction of the original
		/// number of triangles). The actual reduction may be less depending on
		/// triangulation and topological constraints.
		/// </summary>
		// Token: 0x060198DE RID: 104670 RVA: 0x00238DD4 File Offset: 0x00236FD4
		public virtual double GetTargetReduction()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetTargetReduction_17(base.GetCppThis());
		}

		// Token: 0x060198DF RID: 104671
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkQuadricDecimation_GetTargetReductionMaxValue_18(HandleRef pThis);

		/// <summary>
		/// Set/Get the desired reduction (expressed as a fraction of the original
		/// number of triangles). The actual reduction may be less depending on
		/// triangulation and topological constraints.
		/// </summary>
		// Token: 0x060198E0 RID: 104672 RVA: 0x00238DF4 File Offset: 0x00236FF4
		public virtual double GetTargetReductionMaxValue()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetTargetReductionMaxValue_18(base.GetCppThis());
		}

		// Token: 0x060198E1 RID: 104673
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkQuadricDecimation_GetTargetReductionMinValue_19(HandleRef pThis);

		/// <summary>
		/// Set/Get the desired reduction (expressed as a fraction of the original
		/// number of triangles). The actual reduction may be less depending on
		/// triangulation and topological constraints.
		/// </summary>
		// Token: 0x060198E2 RID: 104674 RVA: 0x00238E14 File Offset: 0x00237014
		public virtual double GetTargetReductionMinValue()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetTargetReductionMinValue_19(base.GetCppThis());
		}

		// Token: 0x060198E3 RID: 104675
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricDecimation_GetTensorsAttribute_20(HandleRef pThis);

		/// <summary>
		/// If attribute errors are to be included in the metric (i.e.,
		/// AttributeErrorMetric is on), then the following flags control which
		/// attributes are to be included in the error calculation. By default all
		/// of these are on.
		/// </summary>
		// Token: 0x060198E4 RID: 104676 RVA: 0x00238E34 File Offset: 0x00237034
		public virtual int GetTensorsAttribute()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetTensorsAttribute_20(base.GetCppThis());
		}

		// Token: 0x060198E5 RID: 104677
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkQuadricDecimation_GetTensorsWeight_21(HandleRef pThis);

		/// <summary>
		/// Set/Get the scaling weight contribution of the attribute. These
		/// values are used to weight the contribution of the attributes
		/// towards the error metric.
		/// </summary>
		// Token: 0x060198E6 RID: 104678 RVA: 0x00238E54 File Offset: 0x00237054
		public virtual double GetTensorsWeight()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetTensorsWeight_21(base.GetCppThis());
		}

		// Token: 0x060198E7 RID: 104679
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricDecimation_GetVectorsAttribute_22(HandleRef pThis);

		/// <summary>
		/// If attribute errors are to be included in the metric (i.e.,
		/// AttributeErrorMetric is on), then the following flags control which
		/// attributes are to be included in the error calculation. By default all
		/// of these are on.
		/// </summary>
		// Token: 0x060198E8 RID: 104680 RVA: 0x00238E74 File Offset: 0x00237074
		public virtual int GetVectorsAttribute()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetVectorsAttribute_22(base.GetCppThis());
		}

		// Token: 0x060198E9 RID: 104681
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkQuadricDecimation_GetVectorsWeight_23(HandleRef pThis);

		/// <summary>
		/// Set/Get the scaling weight contribution of the attribute. These
		/// values are used to weight the contribution of the attributes
		/// towards the error metric.
		/// </summary>
		// Token: 0x060198EA RID: 104682 RVA: 0x00238E94 File Offset: 0x00237094
		public virtual double GetVectorsWeight()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetVectorsWeight_23(base.GetCppThis());
		}

		// Token: 0x060198EB RID: 104683
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricDecimation_GetVolumePreservation_24(HandleRef pThis);

		/// <summary>
		/// Decide whether to activate volume preservation which greatly reduces errors
		/// in triangle normal direction. If off, volume preservation is disabled and
		/// if AttributeErrorMetric is active, these errors can be large.
		/// By default VolumePreservation is off
		/// the attribute errors are off.
		/// </summary>
		// Token: 0x060198EC RID: 104684 RVA: 0x00238EB4 File Offset: 0x002370B4
		public virtual int GetVolumePreservation()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetVolumePreservation_24(base.GetCppThis());
		}

		// Token: 0x060198ED RID: 104685
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricDecimation_GetWeighBoundaryConstraintsByLength_25(HandleRef pThis);

		/// <summary>
		/// Parameters related to the treatment of the boundary of the mesh during decimation.
		///
		/// WeighBoundaryConstraintsByLength: When this boolean is set to true, use the legacy weighting by
		/// boundary_edge_length instead of by boundary_edge_length^2 for backwards compatibility (default
		/// to false) BoundaryWeightFactor: A floating point factor to weigh the boundary quadric
		/// constraints by: higher factors further constrain the boundary.
		/// </summary>
		// Token: 0x060198EE RID: 104686 RVA: 0x00238ED4 File Offset: 0x002370D4
		public virtual int GetWeighBoundaryConstraintsByLength()
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_GetWeighBoundaryConstraintsByLength_25(base.GetCppThis());
		}

		// Token: 0x060198EF RID: 104687
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricDecimation_IsA_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060198F0 RID: 104688 RVA: 0x00238EF4 File Offset: 0x002370F4
		public override int IsA(string type)
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_IsA_26(base.GetCppThis(), type);
		}

		// Token: 0x060198F1 RID: 104689
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadricDecimation_IsTypeOf_27([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060198F2 RID: 104690 RVA: 0x00238F14 File Offset: 0x00237114
		public new static int IsTypeOf(string type)
		{
			return vtkQuadricDecimation.vtkQuadricDecimation_IsTypeOf_27(type);
		}

		// Token: 0x060198F3 RID: 104691
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_MapPointDataOff_28(HandleRef pThis);

		/// <summary>
		/// Getter/Setter for mapping point data to the output during decimation.
		/// </summary>
		// Token: 0x060198F4 RID: 104692 RVA: 0x00238F2E File Offset: 0x0023712E
		public virtual void MapPointDataOff()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_MapPointDataOff_28(base.GetCppThis());
		}

		// Token: 0x060198F5 RID: 104693
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_MapPointDataOn_29(HandleRef pThis);

		/// <summary>
		/// Getter/Setter for mapping point data to the output during decimation.
		/// </summary>
		// Token: 0x060198F6 RID: 104694 RVA: 0x00238F3D File Offset: 0x0023713D
		public virtual void MapPointDataOn()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_MapPointDataOn_29(base.GetCppThis());
		}

		// Token: 0x060198F7 RID: 104695
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadricDecimation_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060198F8 RID: 104696 RVA: 0x00238F4C File Offset: 0x0023714C
		public new vtkQuadricDecimation NewInstance()
		{
			vtkQuadricDecimation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadricDecimation.vtkQuadricDecimation_NewInstance_31(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadricDecimation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060198F9 RID: 104697
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_NormalsAttributeOff_32(HandleRef pThis);

		/// <summary>
		/// If attribute errors are to be included in the metric (i.e.,
		/// AttributeErrorMetric is on), then the following flags control which
		/// attributes are to be included in the error calculation. By default all
		/// of these are on.
		/// </summary>
		// Token: 0x060198FA RID: 104698 RVA: 0x00238FA6 File Offset: 0x002371A6
		public virtual void NormalsAttributeOff()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_NormalsAttributeOff_32(base.GetCppThis());
		}

		// Token: 0x060198FB RID: 104699
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_NormalsAttributeOn_33(HandleRef pThis);

		/// <summary>
		/// If attribute errors are to be included in the metric (i.e.,
		/// AttributeErrorMetric is on), then the following flags control which
		/// attributes are to be included in the error calculation. By default all
		/// of these are on.
		/// </summary>
		// Token: 0x060198FC RID: 104700 RVA: 0x00238FB5 File Offset: 0x002371B5
		public virtual void NormalsAttributeOn()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_NormalsAttributeOn_33(base.GetCppThis());
		}

		// Token: 0x060198FD RID: 104701
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_RegularizeOff_34(HandleRef pThis);

		/// <summary>
		/// Parameters related to adding a probabilistic uncertainty to the position and normals of the
		/// quadrics following [1]. The goal using these parameters is to regularize the point finding
		/// algorithm so as to have better quality mesh elements at the cost of a slightly lower precision
		/// on the geometry potentially (mostly at sharp edges). Can also be useful for decimating meshes
		/// that have been triangulated on noisy data.
		///
		/// Regularize: boolean property determining whether or not to use the regularization method
		/// Regularization: user defined variable that can be used to adjust the level of
		/// regularization. One can think of it as the standard deviation of the probability distribution
		/// of normals in the context of noisy data.
		///
		/// [1] P. Trettner and L. Kobbelt, Fast and Robust QEF Minimization using Probabilistic Quadrics,
		/// EUROGRAPHICS, Volume 39, Number 2 (2020)
		/// </summary>
		// Token: 0x060198FE RID: 104702 RVA: 0x00238FC4 File Offset: 0x002371C4
		public virtual void RegularizeOff()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_RegularizeOff_34(base.GetCppThis());
		}

		// Token: 0x060198FF RID: 104703
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_RegularizeOn_35(HandleRef pThis);

		/// <summary>
		/// Parameters related to adding a probabilistic uncertainty to the position and normals of the
		/// quadrics following [1]. The goal using these parameters is to regularize the point finding
		/// algorithm so as to have better quality mesh elements at the cost of a slightly lower precision
		/// on the geometry potentially (mostly at sharp edges). Can also be useful for decimating meshes
		/// that have been triangulated on noisy data.
		///
		/// Regularize: boolean property determining whether or not to use the regularization method
		/// Regularization: user defined variable that can be used to adjust the level of
		/// regularization. One can think of it as the standard deviation of the probability distribution
		/// of normals in the context of noisy data.
		///
		/// [1] P. Trettner and L. Kobbelt, Fast and Robust QEF Minimization using Probabilistic Quadrics,
		/// EUROGRAPHICS, Volume 39, Number 2 (2020)
		/// </summary>
		// Token: 0x06019900 RID: 104704 RVA: 0x00238FD3 File Offset: 0x002371D3
		public virtual void RegularizeOn()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_RegularizeOn_35(base.GetCppThis());
		}

		// Token: 0x06019901 RID: 104705
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadricDecimation_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019902 RID: 104706 RVA: 0x00238FE4 File Offset: 0x002371E4
		public new static vtkQuadricDecimation SafeDownCast(vtkObjectBase o)
		{
			vtkQuadricDecimation vtkQuadricDecimation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadricDecimation.vtkQuadricDecimation_SafeDownCast_36((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuadricDecimation = (vtkQuadricDecimation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuadricDecimation.Register(null);
				}
			}
			return vtkQuadricDecimation;
		}

		// Token: 0x06019903 RID: 104707
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_ScalarsAttributeOff_37(HandleRef pThis);

		/// <summary>
		/// If attribute errors are to be included in the metric (i.e.,
		/// AttributeErrorMetric is on), then the following flags control which
		/// attributes are to be included in the error calculation. By default all
		/// of these are on.
		/// </summary>
		// Token: 0x06019904 RID: 104708 RVA: 0x00239063 File Offset: 0x00237263
		public virtual void ScalarsAttributeOff()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_ScalarsAttributeOff_37(base.GetCppThis());
		}

		// Token: 0x06019905 RID: 104709
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_ScalarsAttributeOn_38(HandleRef pThis);

		/// <summary>
		/// If attribute errors are to be included in the metric (i.e.,
		/// AttributeErrorMetric is on), then the following flags control which
		/// attributes are to be included in the error calculation. By default all
		/// of these are on.
		/// </summary>
		// Token: 0x06019906 RID: 104710 RVA: 0x00239072 File Offset: 0x00237272
		public virtual void ScalarsAttributeOn()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_ScalarsAttributeOn_38(base.GetCppThis());
		}

		// Token: 0x06019907 RID: 104711
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_SetAttributeErrorMetric_39(HandleRef pThis, int _arg);

		/// <summary>
		/// Decide whether to include data attributes in the error metric. If off,
		/// then only geometric error is used to control the decimation. By default
		/// the attribute errors are off.
		/// </summary>
		// Token: 0x06019908 RID: 104712 RVA: 0x00239081 File Offset: 0x00237281
		public virtual void SetAttributeErrorMetric(int _arg)
		{
			vtkQuadricDecimation.vtkQuadricDecimation_SetAttributeErrorMetric_39(base.GetCppThis(), _arg);
		}

		// Token: 0x06019909 RID: 104713
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_SetBoundaryWeightFactor_40(HandleRef pThis, double _arg);

		/// <summary>
		/// Parameters related to the treatment of the boundary of the mesh during decimation.
		///
		/// WeighBoundaryConstraintsByLength: When this boolean is set to true, use the legacy weighting by
		/// boundary_edge_length instead of by boundary_edge_length^2 for backwards compatibility (default
		/// to false) BoundaryWeightFactor: A floating point factor to weigh the boundary quadric
		/// constraints by: higher factors further constrain the boundary.
		/// </summary>
		// Token: 0x0601990A RID: 104714 RVA: 0x00239091 File Offset: 0x00237291
		public virtual void SetBoundaryWeightFactor(double _arg)
		{
			vtkQuadricDecimation.vtkQuadricDecimation_SetBoundaryWeightFactor_40(base.GetCppThis(), _arg);
		}

		// Token: 0x0601990B RID: 104715
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_SetMapPointData_41(HandleRef pThis, byte _arg);

		/// <summary>
		/// Getter/Setter for mapping point data to the output during decimation.
		/// </summary>
		// Token: 0x0601990C RID: 104716 RVA: 0x002390A1 File Offset: 0x002372A1
		public virtual void SetMapPointData(bool _arg)
		{
			vtkQuadricDecimation.vtkQuadricDecimation_SetMapPointData_41(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601990D RID: 104717
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_SetNormalsAttribute_42(HandleRef pThis, int _arg);

		/// <summary>
		/// If attribute errors are to be included in the metric (i.e.,
		/// AttributeErrorMetric is on), then the following flags control which
		/// attributes are to be included in the error calculation. By default all
		/// of these are on.
		/// </summary>
		// Token: 0x0601990E RID: 104718 RVA: 0x002390B9 File Offset: 0x002372B9
		public virtual void SetNormalsAttribute(int _arg)
		{
			vtkQuadricDecimation.vtkQuadricDecimation_SetNormalsAttribute_42(base.GetCppThis(), _arg);
		}

		// Token: 0x0601990F RID: 104719
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_SetNormalsWeight_43(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the scaling weight contribution of the attribute. These
		/// values are used to weight the contribution of the attributes
		/// towards the error metric.
		/// </summary>
		// Token: 0x06019910 RID: 104720 RVA: 0x002390C9 File Offset: 0x002372C9
		public virtual void SetNormalsWeight(double _arg)
		{
			vtkQuadricDecimation.vtkQuadricDecimation_SetNormalsWeight_43(base.GetCppThis(), _arg);
		}

		// Token: 0x06019911 RID: 104721
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_SetRegularization_44(HandleRef pThis, double _arg);

		/// <summary>
		/// Parameters related to adding a probabilistic uncertainty to the position and normals of the
		/// quadrics following [1]. The goal using these parameters is to regularize the point finding
		/// algorithm so as to have better quality mesh elements at the cost of a slightly lower precision
		/// on the geometry potentially (mostly at sharp edges). Can also be useful for decimating meshes
		/// that have been triangulated on noisy data.
		///
		/// Regularize: boolean property determining whether or not to use the regularization method
		/// Regularization: user defined variable that can be used to adjust the level of
		/// regularization. One can think of it as the standard deviation of the probability distribution
		/// of normals in the context of noisy data.
		///
		/// [1] P. Trettner and L. Kobbelt, Fast and Robust QEF Minimization using Probabilistic Quadrics,
		/// EUROGRAPHICS, Volume 39, Number 2 (2020)
		/// </summary>
		// Token: 0x06019912 RID: 104722 RVA: 0x002390D9 File Offset: 0x002372D9
		public virtual void SetRegularization(double _arg)
		{
			vtkQuadricDecimation.vtkQuadricDecimation_SetRegularization_44(base.GetCppThis(), _arg);
		}

		// Token: 0x06019913 RID: 104723
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_SetRegularize_45(HandleRef pThis, int _arg);

		/// <summary>
		/// Parameters related to adding a probabilistic uncertainty to the position and normals of the
		/// quadrics following [1]. The goal using these parameters is to regularize the point finding
		/// algorithm so as to have better quality mesh elements at the cost of a slightly lower precision
		/// on the geometry potentially (mostly at sharp edges). Can also be useful for decimating meshes
		/// that have been triangulated on noisy data.
		///
		/// Regularize: boolean property determining whether or not to use the regularization method
		/// Regularization: user defined variable that can be used to adjust the level of
		/// regularization. One can think of it as the standard deviation of the probability distribution
		/// of normals in the context of noisy data.
		///
		/// [1] P. Trettner and L. Kobbelt, Fast and Robust QEF Minimization using Probabilistic Quadrics,
		/// EUROGRAPHICS, Volume 39, Number 2 (2020)
		/// </summary>
		// Token: 0x06019914 RID: 104724 RVA: 0x002390E9 File Offset: 0x002372E9
		public virtual void SetRegularize(int _arg)
		{
			vtkQuadricDecimation.vtkQuadricDecimation_SetRegularize_45(base.GetCppThis(), _arg);
		}

		// Token: 0x06019915 RID: 104725
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_SetScalarsAttribute_46(HandleRef pThis, int _arg);

		/// <summary>
		/// If attribute errors are to be included in the metric (i.e.,
		/// AttributeErrorMetric is on), then the following flags control which
		/// attributes are to be included in the error calculation. By default all
		/// of these are on.
		/// </summary>
		// Token: 0x06019916 RID: 104726 RVA: 0x002390F9 File Offset: 0x002372F9
		public virtual void SetScalarsAttribute(int _arg)
		{
			vtkQuadricDecimation.vtkQuadricDecimation_SetScalarsAttribute_46(base.GetCppThis(), _arg);
		}

		// Token: 0x06019917 RID: 104727
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_SetScalarsWeight_47(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the scaling weight contribution of the attribute. These
		/// values are used to weight the contribution of the attributes
		/// towards the error metric.
		/// </summary>
		// Token: 0x06019918 RID: 104728 RVA: 0x00239109 File Offset: 0x00237309
		public virtual void SetScalarsWeight(double _arg)
		{
			vtkQuadricDecimation.vtkQuadricDecimation_SetScalarsWeight_47(base.GetCppThis(), _arg);
		}

		// Token: 0x06019919 RID: 104729
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_SetTCoordsAttribute_48(HandleRef pThis, int _arg);

		/// <summary>
		/// If attribute errors are to be included in the metric (i.e.,
		/// AttributeErrorMetric is on), then the following flags control which
		/// attributes are to be included in the error calculation. By default all
		/// of these are on.
		/// </summary>
		// Token: 0x0601991A RID: 104730 RVA: 0x00239119 File Offset: 0x00237319
		public virtual void SetTCoordsAttribute(int _arg)
		{
			vtkQuadricDecimation.vtkQuadricDecimation_SetTCoordsAttribute_48(base.GetCppThis(), _arg);
		}

		// Token: 0x0601991B RID: 104731
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_SetTCoordsWeight_49(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the scaling weight contribution of the attribute. These
		/// values are used to weight the contribution of the attributes
		/// towards the error metric.
		/// </summary>
		// Token: 0x0601991C RID: 104732 RVA: 0x00239129 File Offset: 0x00237329
		public virtual void SetTCoordsWeight(double _arg)
		{
			vtkQuadricDecimation.vtkQuadricDecimation_SetTCoordsWeight_49(base.GetCppThis(), _arg);
		}

		// Token: 0x0601991D RID: 104733
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_SetTargetReduction_50(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the desired reduction (expressed as a fraction of the original
		/// number of triangles). The actual reduction may be less depending on
		/// triangulation and topological constraints.
		/// </summary>
		// Token: 0x0601991E RID: 104734 RVA: 0x00239139 File Offset: 0x00237339
		public virtual void SetTargetReduction(double _arg)
		{
			vtkQuadricDecimation.vtkQuadricDecimation_SetTargetReduction_50(base.GetCppThis(), _arg);
		}

		// Token: 0x0601991F RID: 104735
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_SetTensorsAttribute_51(HandleRef pThis, int _arg);

		/// <summary>
		/// If attribute errors are to be included in the metric (i.e.,
		/// AttributeErrorMetric is on), then the following flags control which
		/// attributes are to be included in the error calculation. By default all
		/// of these are on.
		/// </summary>
		// Token: 0x06019920 RID: 104736 RVA: 0x00239149 File Offset: 0x00237349
		public virtual void SetTensorsAttribute(int _arg)
		{
			vtkQuadricDecimation.vtkQuadricDecimation_SetTensorsAttribute_51(base.GetCppThis(), _arg);
		}

		// Token: 0x06019921 RID: 104737
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_SetTensorsWeight_52(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the scaling weight contribution of the attribute. These
		/// values are used to weight the contribution of the attributes
		/// towards the error metric.
		/// </summary>
		// Token: 0x06019922 RID: 104738 RVA: 0x00239159 File Offset: 0x00237359
		public virtual void SetTensorsWeight(double _arg)
		{
			vtkQuadricDecimation.vtkQuadricDecimation_SetTensorsWeight_52(base.GetCppThis(), _arg);
		}

		// Token: 0x06019923 RID: 104739
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_SetVectorsAttribute_53(HandleRef pThis, int _arg);

		/// <summary>
		/// If attribute errors are to be included in the metric (i.e.,
		/// AttributeErrorMetric is on), then the following flags control which
		/// attributes are to be included in the error calculation. By default all
		/// of these are on.
		/// </summary>
		// Token: 0x06019924 RID: 104740 RVA: 0x00239169 File Offset: 0x00237369
		public virtual void SetVectorsAttribute(int _arg)
		{
			vtkQuadricDecimation.vtkQuadricDecimation_SetVectorsAttribute_53(base.GetCppThis(), _arg);
		}

		// Token: 0x06019925 RID: 104741
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_SetVectorsWeight_54(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the scaling weight contribution of the attribute. These
		/// values are used to weight the contribution of the attributes
		/// towards the error metric.
		/// </summary>
		// Token: 0x06019926 RID: 104742 RVA: 0x00239179 File Offset: 0x00237379
		public virtual void SetVectorsWeight(double _arg)
		{
			vtkQuadricDecimation.vtkQuadricDecimation_SetVectorsWeight_54(base.GetCppThis(), _arg);
		}

		// Token: 0x06019927 RID: 104743
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_SetVolumePreservation_55(HandleRef pThis, int _arg);

		/// <summary>
		/// Decide whether to activate volume preservation which greatly reduces errors
		/// in triangle normal direction. If off, volume preservation is disabled and
		/// if AttributeErrorMetric is active, these errors can be large.
		/// By default VolumePreservation is off
		/// the attribute errors are off.
		/// </summary>
		// Token: 0x06019928 RID: 104744 RVA: 0x00239189 File Offset: 0x00237389
		public virtual void SetVolumePreservation(int _arg)
		{
			vtkQuadricDecimation.vtkQuadricDecimation_SetVolumePreservation_55(base.GetCppThis(), _arg);
		}

		// Token: 0x06019929 RID: 104745
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_SetWeighBoundaryConstraintsByLength_56(HandleRef pThis, int _arg);

		/// <summary>
		/// Parameters related to the treatment of the boundary of the mesh during decimation.
		///
		/// WeighBoundaryConstraintsByLength: When this boolean is set to true, use the legacy weighting by
		/// boundary_edge_length instead of by boundary_edge_length^2 for backwards compatibility (default
		/// to false) BoundaryWeightFactor: A floating point factor to weigh the boundary quadric
		/// constraints by: higher factors further constrain the boundary.
		/// </summary>
		// Token: 0x0601992A RID: 104746 RVA: 0x00239199 File Offset: 0x00237399
		public virtual void SetWeighBoundaryConstraintsByLength(int _arg)
		{
			vtkQuadricDecimation.vtkQuadricDecimation_SetWeighBoundaryConstraintsByLength_56(base.GetCppThis(), _arg);
		}

		// Token: 0x0601992B RID: 104747
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_TCoordsAttributeOff_57(HandleRef pThis);

		/// <summary>
		/// If attribute errors are to be included in the metric (i.e.,
		/// AttributeErrorMetric is on), then the following flags control which
		/// attributes are to be included in the error calculation. By default all
		/// of these are on.
		/// </summary>
		// Token: 0x0601992C RID: 104748 RVA: 0x002391A9 File Offset: 0x002373A9
		public virtual void TCoordsAttributeOff()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_TCoordsAttributeOff_57(base.GetCppThis());
		}

		// Token: 0x0601992D RID: 104749
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_TCoordsAttributeOn_58(HandleRef pThis);

		/// <summary>
		/// If attribute errors are to be included in the metric (i.e.,
		/// AttributeErrorMetric is on), then the following flags control which
		/// attributes are to be included in the error calculation. By default all
		/// of these are on.
		/// </summary>
		// Token: 0x0601992E RID: 104750 RVA: 0x002391B8 File Offset: 0x002373B8
		public virtual void TCoordsAttributeOn()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_TCoordsAttributeOn_58(base.GetCppThis());
		}

		// Token: 0x0601992F RID: 104751
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_TensorsAttributeOff_59(HandleRef pThis);

		/// <summary>
		/// If attribute errors are to be included in the metric (i.e.,
		/// AttributeErrorMetric is on), then the following flags control which
		/// attributes are to be included in the error calculation. By default all
		/// of these are on.
		/// </summary>
		// Token: 0x06019930 RID: 104752 RVA: 0x002391C7 File Offset: 0x002373C7
		public virtual void TensorsAttributeOff()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_TensorsAttributeOff_59(base.GetCppThis());
		}

		// Token: 0x06019931 RID: 104753
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_TensorsAttributeOn_60(HandleRef pThis);

		/// <summary>
		/// If attribute errors are to be included in the metric (i.e.,
		/// AttributeErrorMetric is on), then the following flags control which
		/// attributes are to be included in the error calculation. By default all
		/// of these are on.
		/// </summary>
		// Token: 0x06019932 RID: 104754 RVA: 0x002391D6 File Offset: 0x002373D6
		public virtual void TensorsAttributeOn()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_TensorsAttributeOn_60(base.GetCppThis());
		}

		// Token: 0x06019933 RID: 104755
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_VectorsAttributeOff_61(HandleRef pThis);

		/// <summary>
		/// If attribute errors are to be included in the metric (i.e.,
		/// AttributeErrorMetric is on), then the following flags control which
		/// attributes are to be included in the error calculation. By default all
		/// of these are on.
		/// </summary>
		// Token: 0x06019934 RID: 104756 RVA: 0x002391E5 File Offset: 0x002373E5
		public virtual void VectorsAttributeOff()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_VectorsAttributeOff_61(base.GetCppThis());
		}

		// Token: 0x06019935 RID: 104757
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_VectorsAttributeOn_62(HandleRef pThis);

		/// <summary>
		/// If attribute errors are to be included in the metric (i.e.,
		/// AttributeErrorMetric is on), then the following flags control which
		/// attributes are to be included in the error calculation. By default all
		/// of these are on.
		/// </summary>
		// Token: 0x06019936 RID: 104758 RVA: 0x002391F4 File Offset: 0x002373F4
		public virtual void VectorsAttributeOn()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_VectorsAttributeOn_62(base.GetCppThis());
		}

		// Token: 0x06019937 RID: 104759
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_VolumePreservationOff_63(HandleRef pThis);

		/// <summary>
		/// Decide whether to activate volume preservation which greatly reduces errors
		/// in triangle normal direction. If off, volume preservation is disabled and
		/// if AttributeErrorMetric is active, these errors can be large.
		/// By default VolumePreservation is off
		/// the attribute errors are off.
		/// </summary>
		// Token: 0x06019938 RID: 104760 RVA: 0x00239203 File Offset: 0x00237403
		public virtual void VolumePreservationOff()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_VolumePreservationOff_63(base.GetCppThis());
		}

		// Token: 0x06019939 RID: 104761
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_VolumePreservationOn_64(HandleRef pThis);

		/// <summary>
		/// Decide whether to activate volume preservation which greatly reduces errors
		/// in triangle normal direction. If off, volume preservation is disabled and
		/// if AttributeErrorMetric is active, these errors can be large.
		/// By default VolumePreservation is off
		/// the attribute errors are off.
		/// </summary>
		// Token: 0x0601993A RID: 104762 RVA: 0x00239212 File Offset: 0x00237412
		public virtual void VolumePreservationOn()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_VolumePreservationOn_64(base.GetCppThis());
		}

		// Token: 0x0601993B RID: 104763
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_WeighBoundaryConstraintsByLengthOff_65(HandleRef pThis);

		/// <summary>
		/// Parameters related to the treatment of the boundary of the mesh during decimation.
		///
		/// WeighBoundaryConstraintsByLength: When this boolean is set to true, use the legacy weighting by
		/// boundary_edge_length instead of by boundary_edge_length^2 for backwards compatibility (default
		/// to false) BoundaryWeightFactor: A floating point factor to weigh the boundary quadric
		/// constraints by: higher factors further constrain the boundary.
		/// </summary>
		// Token: 0x0601993C RID: 104764 RVA: 0x00239221 File Offset: 0x00237421
		public virtual void WeighBoundaryConstraintsByLengthOff()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_WeighBoundaryConstraintsByLengthOff_65(base.GetCppThis());
		}

		// Token: 0x0601993D RID: 104765
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkQuadricDecimation_WeighBoundaryConstraintsByLengthOn_66(HandleRef pThis);

		/// <summary>
		/// Parameters related to the treatment of the boundary of the mesh during decimation.
		///
		/// WeighBoundaryConstraintsByLength: When this boolean is set to true, use the legacy weighting by
		/// boundary_edge_length instead of by boundary_edge_length^2 for backwards compatibility (default
		/// to false) BoundaryWeightFactor: A floating point factor to weigh the boundary quadric
		/// constraints by: higher factors further constrain the boundary.
		/// </summary>
		// Token: 0x0601993E RID: 104766 RVA: 0x00239230 File Offset: 0x00237430
		public virtual void WeighBoundaryConstraintsByLengthOn()
		{
			vtkQuadricDecimation.vtkQuadricDecimation_WeighBoundaryConstraintsByLengthOn_66(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BE1 RID: 7137
		public new const string MRFullTypeName = "Kitware.VTK.vtkQuadricDecimation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BE2 RID: 7138
		public new static readonly string MRClassNameKey = "class vtkQuadricDecimation";
	}
}
