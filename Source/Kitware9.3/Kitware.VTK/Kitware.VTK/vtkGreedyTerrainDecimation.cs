using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGreedyTerrainDecimation
	/// </summary>
	/// <remarks>
	///    reduce height field (represented as image) to reduced TIN
	///
	/// vtkGreedyTerrainDecimation approximates a height field with a triangle
	/// mesh (triangulated irregular network - TIN) using a greedy insertion
	/// algorithm similar to that described by Garland and Heckbert in their paper
	/// "Fast Polygonal Approximations of Terrain and Height Fields" (Technical
	/// Report CMU-CS-95-181).  The input to the filter is a height field
	/// (represented by a image whose scalar values are height) and the output of
	/// the filter is polygonal data consisting of triangles. The number of
	/// triangles in the output is reduced in number as compared to a naive
	/// tessellation of the input height field. This filter copies point data
	/// from the input to the output for those points present in the output.
	///
	/// An brief description of the algorithm is as follows. The algorithm uses a
	/// top-down decimation approach that initially represents the height field
	/// with two triangles (whose vertices are at the four corners of the
	/// image). These two triangles form a Delaunay triangulation. In an iterative
	/// fashion, the point in the image with the greatest error (as compared to
	/// the original height field) is injected into the triangulation. (Note that
	/// the single point with the greatest error per triangle is identified and
	/// placed into a priority queue. As the triangulation is modified, the errors
	/// from the deleted triangles are removed from the queue, error values from
	/// the new triangles are added.) The point whose error is at the top of the
	/// queue is added to the triangulaion modifying it using the standard
	/// incremental Delaunay point insertion (see vtkDelaunay2D) algorithm. Points
	/// are repeatedly inserted until the appropriate (user-specified) error
	/// criterion is met.
	///
	/// To use this filter, set the input and specify the error measure to be
	/// used.  The error measure options are 1) the absolute number of triangles
	/// to be produced; 2) a fractional reduction of the mesh (numTris/maxTris)
	/// where maxTris is the largest possible number of triangles
	/// 2*(dims[0]-1)*(dims[1]-1); 3) an absolute measure on error (maximum
	/// difference in height field to reduced TIN); and 4) relative error (the
	/// absolute error is normalized by the diagonal of the bounding box of the
	/// height field).
	///
	/// @warning
	/// This algorithm requires the entire input dataset to be in memory, hence it
	/// may not work for extremely large images. Invoking BoundaryVertexDeletionOff
	/// will allow you to stitch together images with matching boundaries.
	///
	/// @warning
	/// The input height image is assumed to be positioned in the x-y plane so the
	/// scalar value is the z-coordinate, height value.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDecimatePro vtkQuadricDecimation vtkQuadricClustering
	/// </seealso>
	// Token: 0x0200060C RID: 1548
	public class vtkGreedyTerrainDecimation : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010CA8 RID: 68776 RVA: 0x00176C7C File Offset: 0x00174E7C
		static vtkGreedyTerrainDecimation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGreedyTerrainDecimation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGreedyTerrainDecimation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010CA9 RID: 68777 RVA: 0x00176CA4 File Offset: 0x00174EA4
		public vtkGreedyTerrainDecimation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010CAA RID: 68778
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGreedyTerrainDecimation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06010CAB RID: 68779 RVA: 0x00176CB4 File Offset: 0x00174EB4
		public new static vtkGreedyTerrainDecimation New()
		{
			vtkGreedyTerrainDecimation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGreedyTerrainDecimation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06010CAC RID: 68780 RVA: 0x00176D08 File Offset: 0x00174F08
		public vtkGreedyTerrainDecimation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010CAD RID: 68781 RVA: 0x00176D4C File Offset: 0x00174F4C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010CAE RID: 68782
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGreedyTerrainDecimation_BoundaryVertexDeletionOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off the deletion of vertices on the boundary of a mesh. This
		/// may limit the maximum reduction that may be achieved.
		/// </summary>
		// Token: 0x06010CAF RID: 68783 RVA: 0x00176D57 File Offset: 0x00174F57
		public virtual void BoundaryVertexDeletionOff()
		{
			vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_BoundaryVertexDeletionOff_01(base.GetCppThis());
		}

		// Token: 0x06010CB0 RID: 68784
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGreedyTerrainDecimation_BoundaryVertexDeletionOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off the deletion of vertices on the boundary of a mesh. This
		/// may limit the maximum reduction that may be achieved.
		/// </summary>
		// Token: 0x06010CB1 RID: 68785 RVA: 0x00176D66 File Offset: 0x00174F66
		public virtual void BoundaryVertexDeletionOn()
		{
			vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_BoundaryVertexDeletionOn_02(base.GetCppThis());
		}

		// Token: 0x06010CB2 RID: 68786
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGreedyTerrainDecimation_ComputeNormalsOff_03(HandleRef pThis);

		/// <summary>
		/// Compute normals based on the input image. Off by default.
		/// </summary>
		// Token: 0x06010CB3 RID: 68787 RVA: 0x00176D75 File Offset: 0x00174F75
		public virtual void ComputeNormalsOff()
		{
			vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_ComputeNormalsOff_03(base.GetCppThis());
		}

		// Token: 0x06010CB4 RID: 68788
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGreedyTerrainDecimation_ComputeNormalsOn_04(HandleRef pThis);

		/// <summary>
		/// Compute normals based on the input image. Off by default.
		/// </summary>
		// Token: 0x06010CB5 RID: 68789 RVA: 0x00176D84 File Offset: 0x00174F84
		public virtual void ComputeNormalsOn()
		{
			vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_ComputeNormalsOn_04(base.GetCppThis());
		}

		// Token: 0x06010CB6 RID: 68790
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGreedyTerrainDecimation_GetAbsoluteError_05(HandleRef pThis);

		/// <summary>
		/// Specify the absolute error of the mesh; that is, the error in height
		/// between the decimated mesh and the original height field.  You need to
		/// set this value only when the error measure is set to AbsoluteError.
		/// </summary>
		// Token: 0x06010CB7 RID: 68791 RVA: 0x00176D94 File Offset: 0x00174F94
		public virtual double GetAbsoluteError()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetAbsoluteError_05(base.GetCppThis());
		}

		// Token: 0x06010CB8 RID: 68792
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGreedyTerrainDecimation_GetAbsoluteErrorMaxValue_06(HandleRef pThis);

		/// <summary>
		/// Specify the absolute error of the mesh; that is, the error in height
		/// between the decimated mesh and the original height field.  You need to
		/// set this value only when the error measure is set to AbsoluteError.
		/// </summary>
		// Token: 0x06010CB9 RID: 68793 RVA: 0x00176DB4 File Offset: 0x00174FB4
		public virtual double GetAbsoluteErrorMaxValue()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetAbsoluteErrorMaxValue_06(base.GetCppThis());
		}

		// Token: 0x06010CBA RID: 68794
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGreedyTerrainDecimation_GetAbsoluteErrorMinValue_07(HandleRef pThis);

		/// <summary>
		/// Specify the absolute error of the mesh; that is, the error in height
		/// between the decimated mesh and the original height field.  You need to
		/// set this value only when the error measure is set to AbsoluteError.
		/// </summary>
		// Token: 0x06010CBB RID: 68795 RVA: 0x00176DD4 File Offset: 0x00174FD4
		public virtual double GetAbsoluteErrorMinValue()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetAbsoluteErrorMinValue_07(base.GetCppThis());
		}

		// Token: 0x06010CBC RID: 68796
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGreedyTerrainDecimation_GetBoundaryVertexDeletion_08(HandleRef pThis);

		/// <summary>
		/// Turn on/off the deletion of vertices on the boundary of a mesh. This
		/// may limit the maximum reduction that may be achieved.
		/// </summary>
		// Token: 0x06010CBD RID: 68797 RVA: 0x00176DF4 File Offset: 0x00174FF4
		public virtual int GetBoundaryVertexDeletion()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetBoundaryVertexDeletion_08(base.GetCppThis());
		}

		// Token: 0x06010CBE RID: 68798
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGreedyTerrainDecimation_GetComputeNormals_09(HandleRef pThis);

		/// <summary>
		/// Compute normals based on the input image. Off by default.
		/// </summary>
		// Token: 0x06010CBF RID: 68799 RVA: 0x00176E14 File Offset: 0x00175014
		public virtual int GetComputeNormals()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetComputeNormals_09(base.GetCppThis());
		}

		// Token: 0x06010CC0 RID: 68800
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGreedyTerrainDecimation_GetErrorMeasure_10(HandleRef pThis);

		/// <summary>
		/// Specify how to terminate the algorithm: either as an absolute number of
		/// triangles, a relative number of triangles (normalized by the full
		/// resolution mesh), an absolute error (in the height field), or relative
		/// error (normalized by the length of the diagonal of the image).
		/// </summary>
		// Token: 0x06010CC1 RID: 68801 RVA: 0x00176E34 File Offset: 0x00175034
		public virtual int GetErrorMeasure()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetErrorMeasure_10(base.GetCppThis());
		}

		// Token: 0x06010CC2 RID: 68802
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGreedyTerrainDecimation_GetErrorMeasureMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Specify how to terminate the algorithm: either as an absolute number of
		/// triangles, a relative number of triangles (normalized by the full
		/// resolution mesh), an absolute error (in the height field), or relative
		/// error (normalized by the length of the diagonal of the image).
		/// </summary>
		// Token: 0x06010CC3 RID: 68803 RVA: 0x00176E54 File Offset: 0x00175054
		public virtual int GetErrorMeasureMaxValue()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetErrorMeasureMaxValue_11(base.GetCppThis());
		}

		// Token: 0x06010CC4 RID: 68804
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGreedyTerrainDecimation_GetErrorMeasureMinValue_12(HandleRef pThis);

		/// <summary>
		/// Specify how to terminate the algorithm: either as an absolute number of
		/// triangles, a relative number of triangles (normalized by the full
		/// resolution mesh), an absolute error (in the height field), or relative
		/// error (normalized by the length of the diagonal of the image).
		/// </summary>
		// Token: 0x06010CC5 RID: 68805 RVA: 0x00176E74 File Offset: 0x00175074
		public virtual int GetErrorMeasureMinValue()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetErrorMeasureMinValue_12(base.GetCppThis());
		}

		// Token: 0x06010CC6 RID: 68806
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGreedyTerrainDecimation_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010CC7 RID: 68807 RVA: 0x00176E94 File Offset: 0x00175094
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x06010CC8 RID: 68808
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGreedyTerrainDecimation_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010CC9 RID: 68809 RVA: 0x00176EB4 File Offset: 0x001750B4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x06010CCA RID: 68810
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGreedyTerrainDecimation_GetNumberOfTriangles_15(HandleRef pThis);

		/// <summary>
		/// Specify the number of triangles to produce on output. (It is a
		/// good idea to make sure this is less than a tessellated mesh
		/// at full resolution.) You need to set this value only when
		/// the error measure is set to NumberOfTriangles.
		/// </summary>
		// Token: 0x06010CCB RID: 68811 RVA: 0x00176ED0 File Offset: 0x001750D0
		public virtual long GetNumberOfTriangles()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetNumberOfTriangles_15(base.GetCppThis());
		}

		// Token: 0x06010CCC RID: 68812
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGreedyTerrainDecimation_GetNumberOfTrianglesMaxValue_16(HandleRef pThis);

		/// <summary>
		/// Specify the number of triangles to produce on output. (It is a
		/// good idea to make sure this is less than a tessellated mesh
		/// at full resolution.) You need to set this value only when
		/// the error measure is set to NumberOfTriangles.
		/// </summary>
		// Token: 0x06010CCD RID: 68813 RVA: 0x00176EF0 File Offset: 0x001750F0
		public virtual long GetNumberOfTrianglesMaxValue()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetNumberOfTrianglesMaxValue_16(base.GetCppThis());
		}

		// Token: 0x06010CCE RID: 68814
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGreedyTerrainDecimation_GetNumberOfTrianglesMinValue_17(HandleRef pThis);

		/// <summary>
		/// Specify the number of triangles to produce on output. (It is a
		/// good idea to make sure this is less than a tessellated mesh
		/// at full resolution.) You need to set this value only when
		/// the error measure is set to NumberOfTriangles.
		/// </summary>
		// Token: 0x06010CCF RID: 68815 RVA: 0x00176F10 File Offset: 0x00175110
		public virtual long GetNumberOfTrianglesMinValue()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetNumberOfTrianglesMinValue_17(base.GetCppThis());
		}

		// Token: 0x06010CD0 RID: 68816
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGreedyTerrainDecimation_GetReduction_18(HandleRef pThis);

		/// <summary>
		/// Specify the reduction of the mesh (represented as a fraction).  Note
		/// that a value of 0.10 means a 10% reduction.  You need to set this value
		/// only when the error measure is set to SpecifiedReduction.
		/// </summary>
		// Token: 0x06010CD1 RID: 68817 RVA: 0x00176F30 File Offset: 0x00175130
		public virtual double GetReduction()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetReduction_18(base.GetCppThis());
		}

		// Token: 0x06010CD2 RID: 68818
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGreedyTerrainDecimation_GetReductionMaxValue_19(HandleRef pThis);

		/// <summary>
		/// Specify the reduction of the mesh (represented as a fraction).  Note
		/// that a value of 0.10 means a 10% reduction.  You need to set this value
		/// only when the error measure is set to SpecifiedReduction.
		/// </summary>
		// Token: 0x06010CD3 RID: 68819 RVA: 0x00176F50 File Offset: 0x00175150
		public virtual double GetReductionMaxValue()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetReductionMaxValue_19(base.GetCppThis());
		}

		// Token: 0x06010CD4 RID: 68820
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGreedyTerrainDecimation_GetReductionMinValue_20(HandleRef pThis);

		/// <summary>
		/// Specify the reduction of the mesh (represented as a fraction).  Note
		/// that a value of 0.10 means a 10% reduction.  You need to set this value
		/// only when the error measure is set to SpecifiedReduction.
		/// </summary>
		// Token: 0x06010CD5 RID: 68821 RVA: 0x00176F70 File Offset: 0x00175170
		public virtual double GetReductionMinValue()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetReductionMinValue_20(base.GetCppThis());
		}

		// Token: 0x06010CD6 RID: 68822
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGreedyTerrainDecimation_GetRelativeError_21(HandleRef pThis);

		/// <summary>
		/// Specify the relative error of the mesh; that is, the error in height
		/// between the decimated mesh and the original height field normalized by
		/// the diagonal of the image.  You need to set this value only when the
		/// error measure is set to RelativeError.
		/// </summary>
		// Token: 0x06010CD7 RID: 68823 RVA: 0x00176F90 File Offset: 0x00175190
		public virtual double GetRelativeError()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetRelativeError_21(base.GetCppThis());
		}

		// Token: 0x06010CD8 RID: 68824
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGreedyTerrainDecimation_GetRelativeErrorMaxValue_22(HandleRef pThis);

		/// <summary>
		/// Specify the relative error of the mesh; that is, the error in height
		/// between the decimated mesh and the original height field normalized by
		/// the diagonal of the image.  You need to set this value only when the
		/// error measure is set to RelativeError.
		/// </summary>
		// Token: 0x06010CD9 RID: 68825 RVA: 0x00176FB0 File Offset: 0x001751B0
		public virtual double GetRelativeErrorMaxValue()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetRelativeErrorMaxValue_22(base.GetCppThis());
		}

		// Token: 0x06010CDA RID: 68826
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGreedyTerrainDecimation_GetRelativeErrorMinValue_23(HandleRef pThis);

		/// <summary>
		/// Specify the relative error of the mesh; that is, the error in height
		/// between the decimated mesh and the original height field normalized by
		/// the diagonal of the image.  You need to set this value only when the
		/// error measure is set to RelativeError.
		/// </summary>
		// Token: 0x06010CDB RID: 68827 RVA: 0x00176FD0 File Offset: 0x001751D0
		public virtual double GetRelativeErrorMinValue()
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_GetRelativeErrorMinValue_23(base.GetCppThis());
		}

		// Token: 0x06010CDC RID: 68828
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGreedyTerrainDecimation_IsA_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010CDD RID: 68829 RVA: 0x00176FF0 File Offset: 0x001751F0
		public override int IsA(string type)
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_IsA_24(base.GetCppThis(), type);
		}

		// Token: 0x06010CDE RID: 68830
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGreedyTerrainDecimation_IsTypeOf_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010CDF RID: 68831 RVA: 0x00177010 File Offset: 0x00175210
		public new static int IsTypeOf(string type)
		{
			return vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_IsTypeOf_25(type);
		}

		// Token: 0x06010CE0 RID: 68832
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGreedyTerrainDecimation_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010CE1 RID: 68833 RVA: 0x0017702C File Offset: 0x0017522C
		public new vtkGreedyTerrainDecimation NewInstance()
		{
			vtkGreedyTerrainDecimation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGreedyTerrainDecimation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010CE2 RID: 68834
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGreedyTerrainDecimation_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010CE3 RID: 68835 RVA: 0x00177088 File Offset: 0x00175288
		public new static vtkGreedyTerrainDecimation SafeDownCast(vtkObjectBase o)
		{
			vtkGreedyTerrainDecimation vtkGreedyTerrainDecimation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGreedyTerrainDecimation = (vtkGreedyTerrainDecimation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGreedyTerrainDecimation.Register(null);
				}
			}
			return vtkGreedyTerrainDecimation;
		}

		// Token: 0x06010CE4 RID: 68836
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGreedyTerrainDecimation_SetAbsoluteError_29(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the absolute error of the mesh; that is, the error in height
		/// between the decimated mesh and the original height field.  You need to
		/// set this value only when the error measure is set to AbsoluteError.
		/// </summary>
		// Token: 0x06010CE5 RID: 68837 RVA: 0x00177107 File Offset: 0x00175307
		public virtual void SetAbsoluteError(double _arg)
		{
			vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_SetAbsoluteError_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06010CE6 RID: 68838
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGreedyTerrainDecimation_SetBoundaryVertexDeletion_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the deletion of vertices on the boundary of a mesh. This
		/// may limit the maximum reduction that may be achieved.
		/// </summary>
		// Token: 0x06010CE7 RID: 68839 RVA: 0x00177117 File Offset: 0x00175317
		public virtual void SetBoundaryVertexDeletion(int _arg)
		{
			vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_SetBoundaryVertexDeletion_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06010CE8 RID: 68840
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGreedyTerrainDecimation_SetComputeNormals_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Compute normals based on the input image. Off by default.
		/// </summary>
		// Token: 0x06010CE9 RID: 68841 RVA: 0x00177127 File Offset: 0x00175327
		public virtual void SetComputeNormals(int _arg)
		{
			vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_SetComputeNormals_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06010CEA RID: 68842
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGreedyTerrainDecimation_SetErrorMeasure_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify how to terminate the algorithm: either as an absolute number of
		/// triangles, a relative number of triangles (normalized by the full
		/// resolution mesh), an absolute error (in the height field), or relative
		/// error (normalized by the length of the diagonal of the image).
		/// </summary>
		// Token: 0x06010CEB RID: 68843 RVA: 0x00177137 File Offset: 0x00175337
		public virtual void SetErrorMeasure(int _arg)
		{
			vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_SetErrorMeasure_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06010CEC RID: 68844
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGreedyTerrainDecimation_SetErrorMeasureToAbsoluteError_33(HandleRef pThis);

		/// <summary>
		/// Specify how to terminate the algorithm: either as an absolute number of
		/// triangles, a relative number of triangles (normalized by the full
		/// resolution mesh), an absolute error (in the height field), or relative
		/// error (normalized by the length of the diagonal of the image).
		/// </summary>
		// Token: 0x06010CED RID: 68845 RVA: 0x00177147 File Offset: 0x00175347
		public void SetErrorMeasureToAbsoluteError()
		{
			vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_SetErrorMeasureToAbsoluteError_33(base.GetCppThis());
		}

		// Token: 0x06010CEE RID: 68846
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGreedyTerrainDecimation_SetErrorMeasureToNumberOfTriangles_34(HandleRef pThis);

		/// <summary>
		/// Specify how to terminate the algorithm: either as an absolute number of
		/// triangles, a relative number of triangles (normalized by the full
		/// resolution mesh), an absolute error (in the height field), or relative
		/// error (normalized by the length of the diagonal of the image).
		/// </summary>
		// Token: 0x06010CEF RID: 68847 RVA: 0x00177156 File Offset: 0x00175356
		public void SetErrorMeasureToNumberOfTriangles()
		{
			vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_SetErrorMeasureToNumberOfTriangles_34(base.GetCppThis());
		}

		// Token: 0x06010CF0 RID: 68848
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGreedyTerrainDecimation_SetErrorMeasureToRelativeError_35(HandleRef pThis);

		/// <summary>
		/// Specify how to terminate the algorithm: either as an absolute number of
		/// triangles, a relative number of triangles (normalized by the full
		/// resolution mesh), an absolute error (in the height field), or relative
		/// error (normalized by the length of the diagonal of the image).
		/// </summary>
		// Token: 0x06010CF1 RID: 68849 RVA: 0x00177165 File Offset: 0x00175365
		public void SetErrorMeasureToRelativeError()
		{
			vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_SetErrorMeasureToRelativeError_35(base.GetCppThis());
		}

		// Token: 0x06010CF2 RID: 68850
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGreedyTerrainDecimation_SetErrorMeasureToSpecifiedReduction_36(HandleRef pThis);

		/// <summary>
		/// Specify how to terminate the algorithm: either as an absolute number of
		/// triangles, a relative number of triangles (normalized by the full
		/// resolution mesh), an absolute error (in the height field), or relative
		/// error (normalized by the length of the diagonal of the image).
		/// </summary>
		// Token: 0x06010CF3 RID: 68851 RVA: 0x00177174 File Offset: 0x00175374
		public void SetErrorMeasureToSpecifiedReduction()
		{
			vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_SetErrorMeasureToSpecifiedReduction_36(base.GetCppThis());
		}

		// Token: 0x06010CF4 RID: 68852
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGreedyTerrainDecimation_SetNumberOfTriangles_37(HandleRef pThis, long _arg);

		/// <summary>
		/// Specify the number of triangles to produce on output. (It is a
		/// good idea to make sure this is less than a tessellated mesh
		/// at full resolution.) You need to set this value only when
		/// the error measure is set to NumberOfTriangles.
		/// </summary>
		// Token: 0x06010CF5 RID: 68853 RVA: 0x00177183 File Offset: 0x00175383
		public virtual void SetNumberOfTriangles(long _arg)
		{
			vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_SetNumberOfTriangles_37(base.GetCppThis(), _arg);
		}

		// Token: 0x06010CF6 RID: 68854
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGreedyTerrainDecimation_SetReduction_38(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the reduction of the mesh (represented as a fraction).  Note
		/// that a value of 0.10 means a 10% reduction.  You need to set this value
		/// only when the error measure is set to SpecifiedReduction.
		/// </summary>
		// Token: 0x06010CF7 RID: 68855 RVA: 0x00177193 File Offset: 0x00175393
		public virtual void SetReduction(double _arg)
		{
			vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_SetReduction_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06010CF8 RID: 68856
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGreedyTerrainDecimation_SetRelativeError_39(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the relative error of the mesh; that is, the error in height
		/// between the decimated mesh and the original height field normalized by
		/// the diagonal of the image.  You need to set this value only when the
		/// error measure is set to RelativeError.
		/// </summary>
		// Token: 0x06010CF9 RID: 68857 RVA: 0x001771A3 File Offset: 0x001753A3
		public virtual void SetRelativeError(double _arg)
		{
			vtkGreedyTerrainDecimation.vtkGreedyTerrainDecimation_SetRelativeError_39(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001372 RID: 4978
		public new const string MRFullTypeName = "Kitware.VTK.vtkGreedyTerrainDecimation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001373 RID: 4979
		public new static readonly string MRClassNameKey = "class vtkGreedyTerrainDecimation";
	}
}
