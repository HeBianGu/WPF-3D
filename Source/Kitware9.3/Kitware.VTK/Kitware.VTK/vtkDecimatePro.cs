using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDecimatePro
	/// </summary>
	/// <remarks>
	///    reduce the number of triangles in a mesh
	///
	/// vtkDecimatePro is a filter to reduce the number of triangles in a triangle
	/// mesh, forming a good approximation to the original geometry. The input to
	/// vtkDecimatePro is a vtkPolyData object, and only triangles are treated. If
	/// you desire to decimate polygonal meshes, first triangulate the polygons
	/// with vtkTriangleFilter object.
	///
	/// The implementation of vtkDecimatePro is similar to the algorithm
	/// originally described in "Decimation of Triangle Meshes", Proc Siggraph
	/// `92, with three major differences. First, this algorithm does not
	/// necessarily preserve the topology of the mesh. Second, it is guaranteed to
	/// give the a mesh reduction factor specified by the user (as long as certain
	/// constraints are not set - see Caveats). Third, it is set up generate
	/// progressive meshes, that is a stream of operations that can be easily
	/// transmitted and incrementally updated (see Hugues Hoppe's Siggraph '96
	/// paper on progressive meshes).
	///
	/// The algorithm proceeds as follows. Each vertex in the mesh is classified
	/// and inserted into a priority queue. The priority is based on the error to
	/// delete the vertex and retriangulate the hole. Vertices that cannot be
	/// deleted or triangulated (at this point in the algorithm) are
	/// skipped. Then, each vertex in the priority queue is processed (i.e.,
	/// deleted followed by hole triangulation using edge collapse). This
	/// continues until the priority queue is empty. Next, all remaining vertices
	/// are processed, and the mesh is split into separate pieces along sharp
	/// edges or at non-manifold attachment points and reinserted into the
	/// priority queue. Again, the priority queue is processed until empty. If
	/// the desired reduction is still not achieved, the remaining vertices are
	/// split as necessary (in a recursive fashion) so that it is possible to
	/// eliminate every triangle as necessary.
	///
	/// To use this object, at a minimum you need to specify the ivar
	/// TargetReduction. The algorithm is guaranteed to generate a reduced mesh
	/// at this level as long as the following four conditions are met: 1)
	/// topology modification is allowed (i.e., the ivar PreserveTopology is off);
	/// 2) mesh splitting is enabled (i.e., the ivar Splitting is on); 3) the
	/// algorithm is allowed to modify the boundary of the mesh (i.e., the ivar
	/// BoundaryVertexDeletion is on); and 4) the maximum allowable error (i.e.,
	/// the ivar MaximumError) is set to VTK_DOUBLE_MAX.  Other important
	/// parameters to adjust include the FeatureAngle and SplitAngle ivars, since
	/// these can impact the quality of the final mesh. Also, you can set the
	/// ivar AccumulateError to force incremental error update and distribution
	/// to surrounding vertices as each vertex is deleted. The accumulated error
	/// is a conservative global error bounds and decimation error, but requires
	/// additional memory and time to compute.
	///
	/// @warning
	/// To guarantee a given level of reduction, the ivar PreserveTopology must
	/// be off; the ivar Splitting is on; the ivar BoundaryVertexDeletion is on;
	/// and the ivar MaximumError is set to VTK_DOUBLE_MAX.
	///
	/// @warning
	/// If PreserveTopology is off, and SplitEdges is off; the mesh topology may
	/// be modified by closing holes.
	///
	/// @warning
	/// Once mesh splitting begins, the feature angle is set to the split angle.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDecimate vtkQuadricClustering vtkQuadricDecimation
	/// </seealso>
	// Token: 0x0200095B RID: 2395
	public class vtkDecimatePro : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018E0C RID: 101900 RVA: 0x0022B6D7 File Offset: 0x002298D7
		static vtkDecimatePro()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDecimatePro.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDecimatePro"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018E0D RID: 101901 RVA: 0x0022B6FF File Offset: 0x002298FF
		public vtkDecimatePro(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018E0E RID: 101902
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDecimatePro_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create object with specified reduction of 90% and feature angle of
		/// 15 degrees. Edge splitting is on, defer splitting is on, and the
		/// split angle is 75 degrees. Topology preservation is off, delete
		/// boundary vertices is on, and the maximum error is set to
		/// VTK_DOUBLE_MAX. The inflection point ratio is 10 and the vertex
		/// degree is 25. Error accumulation is turned off.
		/// </summary>
		// Token: 0x06018E0F RID: 101903 RVA: 0x0022B710 File Offset: 0x00229910
		public new static vtkDecimatePro New()
		{
			vtkDecimatePro result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDecimatePro.vtkDecimatePro_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDecimatePro)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create object with specified reduction of 90% and feature angle of
		/// 15 degrees. Edge splitting is on, defer splitting is on, and the
		/// split angle is 75 degrees. Topology preservation is off, delete
		/// boundary vertices is on, and the maximum error is set to
		/// VTK_DOUBLE_MAX. The inflection point ratio is 10 and the vertex
		/// degree is 25. Error accumulation is turned off.
		/// </summary>
		// Token: 0x06018E10 RID: 101904 RVA: 0x0022B764 File Offset: 0x00229964
		public vtkDecimatePro() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDecimatePro.vtkDecimatePro_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018E11 RID: 101905 RVA: 0x0022B7A8 File Offset: 0x002299A8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018E12 RID: 101906
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDecimatePro_AccumulateErrorOff_01(HandleRef pThis);

		/// <summary>
		/// The computed error can either be computed directly from the mesh
		/// or the error may be accumulated as the mesh is modified. If the error
		/// is accumulated, then it represents a global error bounds, and the ivar
		/// MaximumError becomes a global bounds on mesh error. Accumulating the
		/// error requires extra memory proportional to the number of vertices in
		/// the mesh. If AccumulateError is off, then the error is not accumulated.
		/// </summary>
		// Token: 0x06018E13 RID: 101907 RVA: 0x0022B7B3 File Offset: 0x002299B3
		public virtual void AccumulateErrorOff()
		{
			vtkDecimatePro.vtkDecimatePro_AccumulateErrorOff_01(base.GetCppThis());
		}

		// Token: 0x06018E14 RID: 101908
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDecimatePro_AccumulateErrorOn_02(HandleRef pThis);

		/// <summary>
		/// The computed error can either be computed directly from the mesh
		/// or the error may be accumulated as the mesh is modified. If the error
		/// is accumulated, then it represents a global error bounds, and the ivar
		/// MaximumError becomes a global bounds on mesh error. Accumulating the
		/// error requires extra memory proportional to the number of vertices in
		/// the mesh. If AccumulateError is off, then the error is not accumulated.
		/// </summary>
		// Token: 0x06018E15 RID: 101909 RVA: 0x0022B7C2 File Offset: 0x002299C2
		public virtual void AccumulateErrorOn()
		{
			vtkDecimatePro.vtkDecimatePro_AccumulateErrorOn_02(base.GetCppThis());
		}

		// Token: 0x06018E16 RID: 101910
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDecimatePro_BoundaryVertexDeletionOff_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off the deletion of vertices on the boundary of a mesh. This
		/// may limit the maximum reduction that may be achieved.
		/// </summary>
		// Token: 0x06018E17 RID: 101911 RVA: 0x0022B7D1 File Offset: 0x002299D1
		public virtual void BoundaryVertexDeletionOff()
		{
			vtkDecimatePro.vtkDecimatePro_BoundaryVertexDeletionOff_03(base.GetCppThis());
		}

		// Token: 0x06018E18 RID: 101912
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDecimatePro_BoundaryVertexDeletionOn_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off the deletion of vertices on the boundary of a mesh. This
		/// may limit the maximum reduction that may be achieved.
		/// </summary>
		// Token: 0x06018E19 RID: 101913 RVA: 0x0022B7E0 File Offset: 0x002299E0
		public virtual void BoundaryVertexDeletionOn()
		{
			vtkDecimatePro.vtkDecimatePro_BoundaryVertexDeletionOn_04(base.GetCppThis());
		}

		// Token: 0x06018E1A RID: 101914
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDecimatePro_GetAbsoluteError_05(HandleRef pThis);

		/// <summary>
		/// Same as MaximumError, but to be used when ErrorIsAbsolute is 1
		/// </summary>
		// Token: 0x06018E1B RID: 101915 RVA: 0x0022B7F0 File Offset: 0x002299F0
		public virtual double GetAbsoluteError()
		{
			return vtkDecimatePro.vtkDecimatePro_GetAbsoluteError_05(base.GetCppThis());
		}

		// Token: 0x06018E1C RID: 101916
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDecimatePro_GetAbsoluteErrorMaxValue_06(HandleRef pThis);

		/// <summary>
		/// Same as MaximumError, but to be used when ErrorIsAbsolute is 1
		/// </summary>
		// Token: 0x06018E1D RID: 101917 RVA: 0x0022B810 File Offset: 0x00229A10
		public virtual double GetAbsoluteErrorMaxValue()
		{
			return vtkDecimatePro.vtkDecimatePro_GetAbsoluteErrorMaxValue_06(base.GetCppThis());
		}

		// Token: 0x06018E1E RID: 101918
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDecimatePro_GetAbsoluteErrorMinValue_07(HandleRef pThis);

		/// <summary>
		/// Same as MaximumError, but to be used when ErrorIsAbsolute is 1
		/// </summary>
		// Token: 0x06018E1F RID: 101919 RVA: 0x0022B830 File Offset: 0x00229A30
		public virtual double GetAbsoluteErrorMinValue()
		{
			return vtkDecimatePro.vtkDecimatePro_GetAbsoluteErrorMinValue_07(base.GetCppThis());
		}

		// Token: 0x06018E20 RID: 101920
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDecimatePro_GetAccumulateError_08(HandleRef pThis);

		/// <summary>
		/// The computed error can either be computed directly from the mesh
		/// or the error may be accumulated as the mesh is modified. If the error
		/// is accumulated, then it represents a global error bounds, and the ivar
		/// MaximumError becomes a global bounds on mesh error. Accumulating the
		/// error requires extra memory proportional to the number of vertices in
		/// the mesh. If AccumulateError is off, then the error is not accumulated.
		/// </summary>
		// Token: 0x06018E21 RID: 101921 RVA: 0x0022B850 File Offset: 0x00229A50
		public virtual int GetAccumulateError()
		{
			return vtkDecimatePro.vtkDecimatePro_GetAccumulateError_08(base.GetCppThis());
		}

		// Token: 0x06018E22 RID: 101922
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDecimatePro_GetBoundaryVertexDeletion_09(HandleRef pThis);

		/// <summary>
		/// Turn on/off the deletion of vertices on the boundary of a mesh. This
		/// may limit the maximum reduction that may be achieved.
		/// </summary>
		// Token: 0x06018E23 RID: 101923 RVA: 0x0022B870 File Offset: 0x00229A70
		public virtual int GetBoundaryVertexDeletion()
		{
			return vtkDecimatePro.vtkDecimatePro_GetBoundaryVertexDeletion_09(base.GetCppThis());
		}

		// Token: 0x06018E24 RID: 101924
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDecimatePro_GetDegree_10(HandleRef pThis);

		/// <summary>
		/// If the number of triangles connected to a vertex exceeds "Degree", then
		/// the vertex will be split. (NOTE: the complexity of the triangulation
		/// algorithm is proportional to Degree^2. Setting degree small can improve
		/// the performance of the algorithm.)
		/// </summary>
		// Token: 0x06018E25 RID: 101925 RVA: 0x0022B890 File Offset: 0x00229A90
		public virtual int GetDegree()
		{
			return vtkDecimatePro.vtkDecimatePro_GetDegree_10(base.GetCppThis());
		}

		// Token: 0x06018E26 RID: 101926
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDecimatePro_GetDegreeMaxValue_11(HandleRef pThis);

		/// <summary>
		/// If the number of triangles connected to a vertex exceeds "Degree", then
		/// the vertex will be split. (NOTE: the complexity of the triangulation
		/// algorithm is proportional to Degree^2. Setting degree small can improve
		/// the performance of the algorithm.)
		/// </summary>
		// Token: 0x06018E27 RID: 101927 RVA: 0x0022B8B0 File Offset: 0x00229AB0
		public virtual int GetDegreeMaxValue()
		{
			return vtkDecimatePro.vtkDecimatePro_GetDegreeMaxValue_11(base.GetCppThis());
		}

		// Token: 0x06018E28 RID: 101928
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDecimatePro_GetDegreeMinValue_12(HandleRef pThis);

		/// <summary>
		/// If the number of triangles connected to a vertex exceeds "Degree", then
		/// the vertex will be split. (NOTE: the complexity of the triangulation
		/// algorithm is proportional to Degree^2. Setting degree small can improve
		/// the performance of the algorithm.)
		/// </summary>
		// Token: 0x06018E29 RID: 101929 RVA: 0x0022B8D0 File Offset: 0x00229AD0
		public virtual int GetDegreeMinValue()
		{
			return vtkDecimatePro.vtkDecimatePro_GetDegreeMinValue_12(base.GetCppThis());
		}

		// Token: 0x06018E2A RID: 101930
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDecimatePro_GetErrorIsAbsolute_13(HandleRef pThis);

		/// <summary>
		/// The MaximumError is normally defined as a fraction of the dataset bounding
		/// diagonal. By setting ErrorIsAbsolute to 1, the error is instead defined
		/// as that specified by AbsoluteError. By default ErrorIsAbsolute=0.
		/// </summary>
		// Token: 0x06018E2B RID: 101931 RVA: 0x0022B8F0 File Offset: 0x00229AF0
		public virtual int GetErrorIsAbsolute()
		{
			return vtkDecimatePro.vtkDecimatePro_GetErrorIsAbsolute_13(base.GetCppThis());
		}

		// Token: 0x06018E2C RID: 101932
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDecimatePro_GetFeatureAngle_14(HandleRef pThis);

		/// <summary>
		/// Specify the mesh feature angle. This angle is used to define what
		/// an edge is (i.e., if the surface normal between two adjacent triangles
		/// is &gt;= FeatureAngle, an edge exists).
		/// </summary>
		// Token: 0x06018E2D RID: 101933 RVA: 0x0022B910 File Offset: 0x00229B10
		public virtual double GetFeatureAngle()
		{
			return vtkDecimatePro.vtkDecimatePro_GetFeatureAngle_14(base.GetCppThis());
		}

		// Token: 0x06018E2E RID: 101934
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDecimatePro_GetFeatureAngleMaxValue_15(HandleRef pThis);

		/// <summary>
		/// Specify the mesh feature angle. This angle is used to define what
		/// an edge is (i.e., if the surface normal between two adjacent triangles
		/// is &gt;= FeatureAngle, an edge exists).
		/// </summary>
		// Token: 0x06018E2F RID: 101935 RVA: 0x0022B930 File Offset: 0x00229B30
		public virtual double GetFeatureAngleMaxValue()
		{
			return vtkDecimatePro.vtkDecimatePro_GetFeatureAngleMaxValue_15(base.GetCppThis());
		}

		// Token: 0x06018E30 RID: 101936
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDecimatePro_GetFeatureAngleMinValue_16(HandleRef pThis);

		/// <summary>
		/// Specify the mesh feature angle. This angle is used to define what
		/// an edge is (i.e., if the surface normal between two adjacent triangles
		/// is &gt;= FeatureAngle, an edge exists).
		/// </summary>
		// Token: 0x06018E31 RID: 101937 RVA: 0x0022B950 File Offset: 0x00229B50
		public virtual double GetFeatureAngleMinValue()
		{
			return vtkDecimatePro.vtkDecimatePro_GetFeatureAngleMinValue_16(base.GetCppThis());
		}

		// Token: 0x06018E32 RID: 101938
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDecimatePro_GetInflectionPointRatio_17(HandleRef pThis);

		/// <summary>
		/// Specify the inflection point ratio. An inflection point occurs
		/// when the ratio of reduction error between two iterations is greater
		/// than or equal to the InflectionPointRatio.
		/// </summary>
		// Token: 0x06018E33 RID: 101939 RVA: 0x0022B970 File Offset: 0x00229B70
		public virtual double GetInflectionPointRatio()
		{
			return vtkDecimatePro.vtkDecimatePro_GetInflectionPointRatio_17(base.GetCppThis());
		}

		// Token: 0x06018E34 RID: 101940
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDecimatePro_GetInflectionPointRatioMaxValue_18(HandleRef pThis);

		/// <summary>
		/// Specify the inflection point ratio. An inflection point occurs
		/// when the ratio of reduction error between two iterations is greater
		/// than or equal to the InflectionPointRatio.
		/// </summary>
		// Token: 0x06018E35 RID: 101941 RVA: 0x0022B990 File Offset: 0x00229B90
		public virtual double GetInflectionPointRatioMaxValue()
		{
			return vtkDecimatePro.vtkDecimatePro_GetInflectionPointRatioMaxValue_18(base.GetCppThis());
		}

		// Token: 0x06018E36 RID: 101942
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDecimatePro_GetInflectionPointRatioMinValue_19(HandleRef pThis);

		/// <summary>
		/// Specify the inflection point ratio. An inflection point occurs
		/// when the ratio of reduction error between two iterations is greater
		/// than or equal to the InflectionPointRatio.
		/// </summary>
		// Token: 0x06018E37 RID: 101943 RVA: 0x0022B9B0 File Offset: 0x00229BB0
		public virtual double GetInflectionPointRatioMinValue()
		{
			return vtkDecimatePro.vtkDecimatePro_GetInflectionPointRatioMinValue_19(base.GetCppThis());
		}

		// Token: 0x06018E38 RID: 101944
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDecimatePro_GetInflectionPoints_20(HandleRef pThis, IntPtr inflectionPoints);

		/// <summary>
		/// Get a list of inflection points. These are double values 0 &lt; r &lt;= 1.0
		/// corresponding to reduction level, and there are a total of
		/// NumberOfInflectionPoints() values. You must provide an array (of
		/// the correct size) into which the inflection points are written.
		/// </summary>
		// Token: 0x06018E39 RID: 101945 RVA: 0x0022B9CF File Offset: 0x00229BCF
		public void GetInflectionPoints(IntPtr inflectionPoints)
		{
			vtkDecimatePro.vtkDecimatePro_GetInflectionPoints_20(base.GetCppThis(), inflectionPoints);
		}

		// Token: 0x06018E3A RID: 101946
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDecimatePro_GetInflectionPoints_21(HandleRef pThis);

		/// <summary>
		/// Get a list of inflection points. These are double values 0 &lt; r &lt;= 1.0
		/// corresponding to reduction level, and there are a total of
		/// NumberOfInflectionPoints() values. You must provide an array (of
		/// the correct size) into which the inflection points are written.
		/// This method returns a pointer to a list of inflection points.
		/// </summary>
		// Token: 0x06018E3B RID: 101947 RVA: 0x0022B9E0 File Offset: 0x00229BE0
		public IntPtr GetInflectionPoints()
		{
			return vtkDecimatePro.vtkDecimatePro_GetInflectionPoints_21(base.GetCppThis());
		}

		// Token: 0x06018E3C RID: 101948
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDecimatePro_GetMaximumError_22(HandleRef pThis);

		/// <summary>
		/// Set the largest decimation error that is allowed during the decimation
		/// process. This may limit the maximum reduction that may be achieved. The
		/// maximum error is specified as a fraction of the maximum length of
		/// the input data bounding box.
		/// </summary>
		// Token: 0x06018E3D RID: 101949 RVA: 0x0022BA00 File Offset: 0x00229C00
		public virtual double GetMaximumError()
		{
			return vtkDecimatePro.vtkDecimatePro_GetMaximumError_22(base.GetCppThis());
		}

		// Token: 0x06018E3E RID: 101950
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDecimatePro_GetMaximumErrorMaxValue_23(HandleRef pThis);

		/// <summary>
		/// Set the largest decimation error that is allowed during the decimation
		/// process. This may limit the maximum reduction that may be achieved. The
		/// maximum error is specified as a fraction of the maximum length of
		/// the input data bounding box.
		/// </summary>
		// Token: 0x06018E3F RID: 101951 RVA: 0x0022BA20 File Offset: 0x00229C20
		public virtual double GetMaximumErrorMaxValue()
		{
			return vtkDecimatePro.vtkDecimatePro_GetMaximumErrorMaxValue_23(base.GetCppThis());
		}

		// Token: 0x06018E40 RID: 101952
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDecimatePro_GetMaximumErrorMinValue_24(HandleRef pThis);

		/// <summary>
		/// Set the largest decimation error that is allowed during the decimation
		/// process. This may limit the maximum reduction that may be achieved. The
		/// maximum error is specified as a fraction of the maximum length of
		/// the input data bounding box.
		/// </summary>
		// Token: 0x06018E41 RID: 101953 RVA: 0x0022BA40 File Offset: 0x00229C40
		public virtual double GetMaximumErrorMinValue()
		{
			return vtkDecimatePro.vtkDecimatePro_GetMaximumErrorMinValue_24(base.GetCppThis());
		}

		// Token: 0x06018E42 RID: 101954
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDecimatePro_GetNumberOfGenerationsFromBase_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018E43 RID: 101955 RVA: 0x0022BA60 File Offset: 0x00229C60
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDecimatePro.vtkDecimatePro_GetNumberOfGenerationsFromBase_25(base.GetCppThis(), type);
		}

		// Token: 0x06018E44 RID: 101956
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDecimatePro_GetNumberOfGenerationsFromBaseType_26([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018E45 RID: 101957 RVA: 0x0022BA80 File Offset: 0x00229C80
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDecimatePro.vtkDecimatePro_GetNumberOfGenerationsFromBaseType_26(type);
		}

		// Token: 0x06018E46 RID: 101958
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDecimatePro_GetNumberOfInflectionPoints_27(HandleRef pThis);

		/// <summary>
		/// Get the number of inflection points. Only returns a valid value after
		/// the filter has executed.  The values in the list are mesh reduction
		/// values at each inflection point. Note: the first inflection point always
		/// occurs right before non-planar triangles are decimated (i.e., as the
		/// error becomes non-zero).
		/// </summary>
		// Token: 0x06018E47 RID: 101959 RVA: 0x0022BA9C File Offset: 0x00229C9C
		public long GetNumberOfInflectionPoints()
		{
			return vtkDecimatePro.vtkDecimatePro_GetNumberOfInflectionPoints_27(base.GetCppThis());
		}

		// Token: 0x06018E48 RID: 101960
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDecimatePro_GetOutputPointsPrecision_28(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06018E49 RID: 101961 RVA: 0x0022BABC File Offset: 0x00229CBC
		public virtual int GetOutputPointsPrecision()
		{
			return vtkDecimatePro.vtkDecimatePro_GetOutputPointsPrecision_28(base.GetCppThis());
		}

		// Token: 0x06018E4A RID: 101962
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDecimatePro_GetPreSplitMesh_29(HandleRef pThis);

		/// <summary>
		/// In some cases you may wish to split the mesh prior to algorithm
		/// execution. This separates the mesh into semi-planar patches, which are
		/// disconnected from each other. This can give superior results in some
		/// cases. If the ivar PreSplitMesh ivar is enabled, the mesh is split with
		/// the specified SplitAngle. Otherwise mesh splitting is deferred as long
		/// as possible.
		/// </summary>
		// Token: 0x06018E4B RID: 101963 RVA: 0x0022BADC File Offset: 0x00229CDC
		public virtual int GetPreSplitMesh()
		{
			return vtkDecimatePro.vtkDecimatePro_GetPreSplitMesh_29(base.GetCppThis());
		}

		// Token: 0x06018E4C RID: 101964
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDecimatePro_GetPreserveTopology_30(HandleRef pThis);

		/// <summary>
		/// Turn on/off whether to preserve the topology of the original mesh. If
		/// on, mesh splitting and hole elimination will not occur. This may limit
		/// the maximum reduction that may be achieved.
		/// </summary>
		// Token: 0x06018E4D RID: 101965 RVA: 0x0022BAFC File Offset: 0x00229CFC
		public virtual int GetPreserveTopology()
		{
			return vtkDecimatePro.vtkDecimatePro_GetPreserveTopology_30(base.GetCppThis());
		}

		// Token: 0x06018E4E RID: 101966
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDecimatePro_GetSplitAngle_31(HandleRef pThis);

		/// <summary>
		/// Specify the mesh split angle. This angle is used to control the splitting
		/// of the mesh. A split line exists when the surface normals between
		/// two edge connected triangles are &gt;= SplitAngle.
		/// </summary>
		// Token: 0x06018E4F RID: 101967 RVA: 0x0022BB1C File Offset: 0x00229D1C
		public virtual double GetSplitAngle()
		{
			return vtkDecimatePro.vtkDecimatePro_GetSplitAngle_31(base.GetCppThis());
		}

		// Token: 0x06018E50 RID: 101968
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDecimatePro_GetSplitAngleMaxValue_32(HandleRef pThis);

		/// <summary>
		/// Specify the mesh split angle. This angle is used to control the splitting
		/// of the mesh. A split line exists when the surface normals between
		/// two edge connected triangles are &gt;= SplitAngle.
		/// </summary>
		// Token: 0x06018E51 RID: 101969 RVA: 0x0022BB3C File Offset: 0x00229D3C
		public virtual double GetSplitAngleMaxValue()
		{
			return vtkDecimatePro.vtkDecimatePro_GetSplitAngleMaxValue_32(base.GetCppThis());
		}

		// Token: 0x06018E52 RID: 101970
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDecimatePro_GetSplitAngleMinValue_33(HandleRef pThis);

		/// <summary>
		/// Specify the mesh split angle. This angle is used to control the splitting
		/// of the mesh. A split line exists when the surface normals between
		/// two edge connected triangles are &gt;= SplitAngle.
		/// </summary>
		// Token: 0x06018E53 RID: 101971 RVA: 0x0022BB5C File Offset: 0x00229D5C
		public virtual double GetSplitAngleMinValue()
		{
			return vtkDecimatePro.vtkDecimatePro_GetSplitAngleMinValue_33(base.GetCppThis());
		}

		// Token: 0x06018E54 RID: 101972
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDecimatePro_GetSplitting_34(HandleRef pThis);

		/// <summary>
		/// Turn on/off the splitting of the mesh at corners, along edges, at
		/// non-manifold points, or anywhere else a split is required. Turning
		/// splitting off will better preserve the original topology of the
		/// mesh, but you may not obtain the requested reduction.
		/// </summary>
		// Token: 0x06018E55 RID: 101973 RVA: 0x0022BB7C File Offset: 0x00229D7C
		public virtual int GetSplitting()
		{
			return vtkDecimatePro.vtkDecimatePro_GetSplitting_34(base.GetCppThis());
		}

		// Token: 0x06018E56 RID: 101974
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDecimatePro_GetTargetReduction_35(HandleRef pThis);

		/// <summary>
		/// Specify the desired reduction in the total number of polygons (e.g., if
		/// TargetReduction is set to 0.9, this filter will try to reduce the data set
		/// to 10% of its original size). Because of various constraints, this level of
		/// reduction may not be realized. If you want to guarantee a particular
		/// reduction, you must turn off PreserveTopology, turn on SplitEdges and
		/// BoundaryVertexDeletion, and set the MaximumError to VTK_DOUBLE_MAX (these
		/// ivars are initialized this way when the object is instantiated).
		/// </summary>
		// Token: 0x06018E57 RID: 101975 RVA: 0x0022BB9C File Offset: 0x00229D9C
		public virtual double GetTargetReduction()
		{
			return vtkDecimatePro.vtkDecimatePro_GetTargetReduction_35(base.GetCppThis());
		}

		// Token: 0x06018E58 RID: 101976
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDecimatePro_GetTargetReductionMaxValue_36(HandleRef pThis);

		/// <summary>
		/// Specify the desired reduction in the total number of polygons (e.g., if
		/// TargetReduction is set to 0.9, this filter will try to reduce the data set
		/// to 10% of its original size). Because of various constraints, this level of
		/// reduction may not be realized. If you want to guarantee a particular
		/// reduction, you must turn off PreserveTopology, turn on SplitEdges and
		/// BoundaryVertexDeletion, and set the MaximumError to VTK_DOUBLE_MAX (these
		/// ivars are initialized this way when the object is instantiated).
		/// </summary>
		// Token: 0x06018E59 RID: 101977 RVA: 0x0022BBBC File Offset: 0x00229DBC
		public virtual double GetTargetReductionMaxValue()
		{
			return vtkDecimatePro.vtkDecimatePro_GetTargetReductionMaxValue_36(base.GetCppThis());
		}

		// Token: 0x06018E5A RID: 101978
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDecimatePro_GetTargetReductionMinValue_37(HandleRef pThis);

		/// <summary>
		/// Specify the desired reduction in the total number of polygons (e.g., if
		/// TargetReduction is set to 0.9, this filter will try to reduce the data set
		/// to 10% of its original size). Because of various constraints, this level of
		/// reduction may not be realized. If you want to guarantee a particular
		/// reduction, you must turn off PreserveTopology, turn on SplitEdges and
		/// BoundaryVertexDeletion, and set the MaximumError to VTK_DOUBLE_MAX (these
		/// ivars are initialized this way when the object is instantiated).
		/// </summary>
		// Token: 0x06018E5B RID: 101979 RVA: 0x0022BBDC File Offset: 0x00229DDC
		public virtual double GetTargetReductionMinValue()
		{
			return vtkDecimatePro.vtkDecimatePro_GetTargetReductionMinValue_37(base.GetCppThis());
		}

		// Token: 0x06018E5C RID: 101980
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDecimatePro_IsA_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018E5D RID: 101981 RVA: 0x0022BBFC File Offset: 0x00229DFC
		public override int IsA(string type)
		{
			return vtkDecimatePro.vtkDecimatePro_IsA_38(base.GetCppThis(), type);
		}

		// Token: 0x06018E5E RID: 101982
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDecimatePro_IsTypeOf_39([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018E5F RID: 101983 RVA: 0x0022BC1C File Offset: 0x00229E1C
		public new static int IsTypeOf(string type)
		{
			return vtkDecimatePro.vtkDecimatePro_IsTypeOf_39(type);
		}

		// Token: 0x06018E60 RID: 101984
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDecimatePro_NewInstance_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018E61 RID: 101985 RVA: 0x0022BC38 File Offset: 0x00229E38
		public new vtkDecimatePro NewInstance()
		{
			vtkDecimatePro result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDecimatePro.vtkDecimatePro_NewInstance_41(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDecimatePro)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018E62 RID: 101986
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDecimatePro_PreSplitMeshOff_42(HandleRef pThis);

		/// <summary>
		/// In some cases you may wish to split the mesh prior to algorithm
		/// execution. This separates the mesh into semi-planar patches, which are
		/// disconnected from each other. This can give superior results in some
		/// cases. If the ivar PreSplitMesh ivar is enabled, the mesh is split with
		/// the specified SplitAngle. Otherwise mesh splitting is deferred as long
		/// as possible.
		/// </summary>
		// Token: 0x06018E63 RID: 101987 RVA: 0x0022BC92 File Offset: 0x00229E92
		public virtual void PreSplitMeshOff()
		{
			vtkDecimatePro.vtkDecimatePro_PreSplitMeshOff_42(base.GetCppThis());
		}

		// Token: 0x06018E64 RID: 101988
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDecimatePro_PreSplitMeshOn_43(HandleRef pThis);

		/// <summary>
		/// In some cases you may wish to split the mesh prior to algorithm
		/// execution. This separates the mesh into semi-planar patches, which are
		/// disconnected from each other. This can give superior results in some
		/// cases. If the ivar PreSplitMesh ivar is enabled, the mesh is split with
		/// the specified SplitAngle. Otherwise mesh splitting is deferred as long
		/// as possible.
		/// </summary>
		// Token: 0x06018E65 RID: 101989 RVA: 0x0022BCA1 File Offset: 0x00229EA1
		public virtual void PreSplitMeshOn()
		{
			vtkDecimatePro.vtkDecimatePro_PreSplitMeshOn_43(base.GetCppThis());
		}

		// Token: 0x06018E66 RID: 101990
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDecimatePro_PreserveTopologyOff_44(HandleRef pThis);

		/// <summary>
		/// Turn on/off whether to preserve the topology of the original mesh. If
		/// on, mesh splitting and hole elimination will not occur. This may limit
		/// the maximum reduction that may be achieved.
		/// </summary>
		// Token: 0x06018E67 RID: 101991 RVA: 0x0022BCB0 File Offset: 0x00229EB0
		public virtual void PreserveTopologyOff()
		{
			vtkDecimatePro.vtkDecimatePro_PreserveTopologyOff_44(base.GetCppThis());
		}

		// Token: 0x06018E68 RID: 101992
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDecimatePro_PreserveTopologyOn_45(HandleRef pThis);

		/// <summary>
		/// Turn on/off whether to preserve the topology of the original mesh. If
		/// on, mesh splitting and hole elimination will not occur. This may limit
		/// the maximum reduction that may be achieved.
		/// </summary>
		// Token: 0x06018E69 RID: 101993 RVA: 0x0022BCBF File Offset: 0x00229EBF
		public virtual void PreserveTopologyOn()
		{
			vtkDecimatePro.vtkDecimatePro_PreserveTopologyOn_45(base.GetCppThis());
		}

		// Token: 0x06018E6A RID: 101994
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDecimatePro_SafeDownCast_46(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018E6B RID: 101995 RVA: 0x0022BCD0 File Offset: 0x00229ED0
		public new static vtkDecimatePro SafeDownCast(vtkObjectBase o)
		{
			vtkDecimatePro vtkDecimatePro = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDecimatePro.vtkDecimatePro_SafeDownCast_46((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDecimatePro = (vtkDecimatePro)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDecimatePro.Register(null);
				}
			}
			return vtkDecimatePro;
		}

		// Token: 0x06018E6C RID: 101996
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDecimatePro_SetAbsoluteError_47(HandleRef pThis, double _arg);

		/// <summary>
		/// Same as MaximumError, but to be used when ErrorIsAbsolute is 1
		/// </summary>
		// Token: 0x06018E6D RID: 101997 RVA: 0x0022BD4F File Offset: 0x00229F4F
		public virtual void SetAbsoluteError(double _arg)
		{
			vtkDecimatePro.vtkDecimatePro_SetAbsoluteError_47(base.GetCppThis(), _arg);
		}

		// Token: 0x06018E6E RID: 101998
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDecimatePro_SetAccumulateError_48(HandleRef pThis, int _arg);

		/// <summary>
		/// The computed error can either be computed directly from the mesh
		/// or the error may be accumulated as the mesh is modified. If the error
		/// is accumulated, then it represents a global error bounds, and the ivar
		/// MaximumError becomes a global bounds on mesh error. Accumulating the
		/// error requires extra memory proportional to the number of vertices in
		/// the mesh. If AccumulateError is off, then the error is not accumulated.
		/// </summary>
		// Token: 0x06018E6F RID: 101999 RVA: 0x0022BD5F File Offset: 0x00229F5F
		public virtual void SetAccumulateError(int _arg)
		{
			vtkDecimatePro.vtkDecimatePro_SetAccumulateError_48(base.GetCppThis(), _arg);
		}

		// Token: 0x06018E70 RID: 102000
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDecimatePro_SetBoundaryVertexDeletion_49(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the deletion of vertices on the boundary of a mesh. This
		/// may limit the maximum reduction that may be achieved.
		/// </summary>
		// Token: 0x06018E71 RID: 102001 RVA: 0x0022BD6F File Offset: 0x00229F6F
		public virtual void SetBoundaryVertexDeletion(int _arg)
		{
			vtkDecimatePro.vtkDecimatePro_SetBoundaryVertexDeletion_49(base.GetCppThis(), _arg);
		}

		// Token: 0x06018E72 RID: 102002
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDecimatePro_SetDegree_50(HandleRef pThis, int _arg);

		/// <summary>
		/// If the number of triangles connected to a vertex exceeds "Degree", then
		/// the vertex will be split. (NOTE: the complexity of the triangulation
		/// algorithm is proportional to Degree^2. Setting degree small can improve
		/// the performance of the algorithm.)
		/// </summary>
		// Token: 0x06018E73 RID: 102003 RVA: 0x0022BD7F File Offset: 0x00229F7F
		public virtual void SetDegree(int _arg)
		{
			vtkDecimatePro.vtkDecimatePro_SetDegree_50(base.GetCppThis(), _arg);
		}

		// Token: 0x06018E74 RID: 102004
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDecimatePro_SetErrorIsAbsolute_51(HandleRef pThis, int _arg);

		/// <summary>
		/// The MaximumError is normally defined as a fraction of the dataset bounding
		/// diagonal. By setting ErrorIsAbsolute to 1, the error is instead defined
		/// as that specified by AbsoluteError. By default ErrorIsAbsolute=0.
		/// </summary>
		// Token: 0x06018E75 RID: 102005 RVA: 0x0022BD8F File Offset: 0x00229F8F
		public virtual void SetErrorIsAbsolute(int _arg)
		{
			vtkDecimatePro.vtkDecimatePro_SetErrorIsAbsolute_51(base.GetCppThis(), _arg);
		}

		// Token: 0x06018E76 RID: 102006
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDecimatePro_SetFeatureAngle_52(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the mesh feature angle. This angle is used to define what
		/// an edge is (i.e., if the surface normal between two adjacent triangles
		/// is &gt;= FeatureAngle, an edge exists).
		/// </summary>
		// Token: 0x06018E77 RID: 102007 RVA: 0x0022BD9F File Offset: 0x00229F9F
		public virtual void SetFeatureAngle(double _arg)
		{
			vtkDecimatePro.vtkDecimatePro_SetFeatureAngle_52(base.GetCppThis(), _arg);
		}

		// Token: 0x06018E78 RID: 102008
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDecimatePro_SetInflectionPointRatio_53(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the inflection point ratio. An inflection point occurs
		/// when the ratio of reduction error between two iterations is greater
		/// than or equal to the InflectionPointRatio.
		/// </summary>
		// Token: 0x06018E79 RID: 102009 RVA: 0x0022BDAF File Offset: 0x00229FAF
		public virtual void SetInflectionPointRatio(double _arg)
		{
			vtkDecimatePro.vtkDecimatePro_SetInflectionPointRatio_53(base.GetCppThis(), _arg);
		}

		// Token: 0x06018E7A RID: 102010
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDecimatePro_SetMaximumError_54(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the largest decimation error that is allowed during the decimation
		/// process. This may limit the maximum reduction that may be achieved. The
		/// maximum error is specified as a fraction of the maximum length of
		/// the input data bounding box.
		/// </summary>
		// Token: 0x06018E7B RID: 102011 RVA: 0x0022BDBF File Offset: 0x00229FBF
		public virtual void SetMaximumError(double _arg)
		{
			vtkDecimatePro.vtkDecimatePro_SetMaximumError_54(base.GetCppThis(), _arg);
		}

		// Token: 0x06018E7C RID: 102012
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDecimatePro_SetOutputPointsPrecision_55(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06018E7D RID: 102013 RVA: 0x0022BDCF File Offset: 0x00229FCF
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkDecimatePro.vtkDecimatePro_SetOutputPointsPrecision_55(base.GetCppThis(), _arg);
		}

		// Token: 0x06018E7E RID: 102014
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDecimatePro_SetPreSplitMesh_56(HandleRef pThis, int _arg);

		/// <summary>
		/// In some cases you may wish to split the mesh prior to algorithm
		/// execution. This separates the mesh into semi-planar patches, which are
		/// disconnected from each other. This can give superior results in some
		/// cases. If the ivar PreSplitMesh ivar is enabled, the mesh is split with
		/// the specified SplitAngle. Otherwise mesh splitting is deferred as long
		/// as possible.
		/// </summary>
		// Token: 0x06018E7F RID: 102015 RVA: 0x0022BDDF File Offset: 0x00229FDF
		public virtual void SetPreSplitMesh(int _arg)
		{
			vtkDecimatePro.vtkDecimatePro_SetPreSplitMesh_56(base.GetCppThis(), _arg);
		}

		// Token: 0x06018E80 RID: 102016
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDecimatePro_SetPreserveTopology_57(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off whether to preserve the topology of the original mesh. If
		/// on, mesh splitting and hole elimination will not occur. This may limit
		/// the maximum reduction that may be achieved.
		/// </summary>
		// Token: 0x06018E81 RID: 102017 RVA: 0x0022BDEF File Offset: 0x00229FEF
		public virtual void SetPreserveTopology(int _arg)
		{
			vtkDecimatePro.vtkDecimatePro_SetPreserveTopology_57(base.GetCppThis(), _arg);
		}

		// Token: 0x06018E82 RID: 102018
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDecimatePro_SetSplitAngle_58(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the mesh split angle. This angle is used to control the splitting
		/// of the mesh. A split line exists when the surface normals between
		/// two edge connected triangles are &gt;= SplitAngle.
		/// </summary>
		// Token: 0x06018E83 RID: 102019 RVA: 0x0022BDFF File Offset: 0x00229FFF
		public virtual void SetSplitAngle(double _arg)
		{
			vtkDecimatePro.vtkDecimatePro_SetSplitAngle_58(base.GetCppThis(), _arg);
		}

		// Token: 0x06018E84 RID: 102020
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDecimatePro_SetSplitting_59(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the splitting of the mesh at corners, along edges, at
		/// non-manifold points, or anywhere else a split is required. Turning
		/// splitting off will better preserve the original topology of the
		/// mesh, but you may not obtain the requested reduction.
		/// </summary>
		// Token: 0x06018E85 RID: 102021 RVA: 0x0022BE0F File Offset: 0x0022A00F
		public virtual void SetSplitting(int _arg)
		{
			vtkDecimatePro.vtkDecimatePro_SetSplitting_59(base.GetCppThis(), _arg);
		}

		// Token: 0x06018E86 RID: 102022
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDecimatePro_SetTargetReduction_60(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the desired reduction in the total number of polygons (e.g., if
		/// TargetReduction is set to 0.9, this filter will try to reduce the data set
		/// to 10% of its original size). Because of various constraints, this level of
		/// reduction may not be realized. If you want to guarantee a particular
		/// reduction, you must turn off PreserveTopology, turn on SplitEdges and
		/// BoundaryVertexDeletion, and set the MaximumError to VTK_DOUBLE_MAX (these
		/// ivars are initialized this way when the object is instantiated).
		/// </summary>
		// Token: 0x06018E87 RID: 102023 RVA: 0x0022BE1F File Offset: 0x0022A01F
		public virtual void SetTargetReduction(double _arg)
		{
			vtkDecimatePro.vtkDecimatePro_SetTargetReduction_60(base.GetCppThis(), _arg);
		}

		// Token: 0x06018E88 RID: 102024
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDecimatePro_SplittingOff_61(HandleRef pThis);

		/// <summary>
		/// Turn on/off the splitting of the mesh at corners, along edges, at
		/// non-manifold points, or anywhere else a split is required. Turning
		/// splitting off will better preserve the original topology of the
		/// mesh, but you may not obtain the requested reduction.
		/// </summary>
		// Token: 0x06018E89 RID: 102025 RVA: 0x0022BE2F File Offset: 0x0022A02F
		public virtual void SplittingOff()
		{
			vtkDecimatePro.vtkDecimatePro_SplittingOff_61(base.GetCppThis());
		}

		// Token: 0x06018E8A RID: 102026
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDecimatePro_SplittingOn_62(HandleRef pThis);

		/// <summary>
		/// Turn on/off the splitting of the mesh at corners, along edges, at
		/// non-manifold points, or anywhere else a split is required. Turning
		/// splitting off will better preserve the original topology of the
		/// mesh, but you may not obtain the requested reduction.
		/// </summary>
		// Token: 0x06018E8B RID: 102027 RVA: 0x0022BE3E File Offset: 0x0022A03E
		public virtual void SplittingOn()
		{
			vtkDecimatePro.vtkDecimatePro_SplittingOn_62(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B6F RID: 7023
		public new const string MRFullTypeName = "Kitware.VTK.vtkDecimatePro";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B70 RID: 7024
		public new static readonly string MRClassNameKey = "class vtkDecimatePro";
	}
}
