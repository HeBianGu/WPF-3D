using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyDataNormals
	/// </summary>
	/// <remarks>
	///    compute normals for polygonal mesh
	///
	/// vtkPolyDataNormals is a filter that computes point and/or cell normals
	/// for a polygonal mesh. The user specifies if they would like the point
	/// and/or cell normals to be computed by setting the ComputeCellNormals
	/// and ComputePointNormals flags.
	///
	/// The computed normals (a vtkFloatArray) are set to be the active normals
	/// (using SetNormals()) of the PointData and/or the CellData (respectively)
	/// of the output PolyData. The name of these arrays is "Normals", so they
	/// can be retrieved either with
	/// vtkArrayDownCast&lt;vtkFloatArray&gt;(output-&gt;GetPointData()-&gt;GetNormals())
	/// or with
	/// vtkArrayDownCast&lt;vtkFloatArray&gt;(output-&gt;GetPointData()-&gt;GetArray("Normals"))
	///
	/// The filter can reorder polygons to ensure consistent
	/// orientation across polygon neighbors. Sharp edges can be split and points
	/// duplicated with separate normals to give crisp (rendered) surface definition.
	/// It is also possible to globally flip the normal orientation.
	///
	/// The algorithm works by determining normals for each polygon and then
	/// averaging them at shared points. When sharp edges are present, the edges
	/// are split and new points generated to prevent blurry edges (due to
	/// Gouraud shading).
	///
	/// @warning
	/// Normals are computed only for polygons and triangle strips. Normals are
	/// not computed for lines or vertices.
	///
	/// @warning
	/// Triangle strips are broken up into triangle polygons. You may want to
	/// restrip the triangles.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// For high-performance rendering, you could use vtkTriangleMeshPointNormals
	/// if you know that you have a triangle mesh which does not require splitting
	/// nor consistency check on the cell orientations.
	///
	/// </seealso>
	// Token: 0x02000524 RID: 1316
	public class vtkPolyDataNormals : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EB37 RID: 60215 RVA: 0x001481E3 File Offset: 0x001463E3
		static vtkPolyDataNormals()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataNormals.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataNormals"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EB38 RID: 60216 RVA: 0x0014820B File Offset: 0x0014640B
		public vtkPolyDataNormals(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600EB39 RID: 60217
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataNormals_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with feature angle=30, splitting and consistency turned on,
		/// flipNormals turned off, and non-manifold traversal turned on.
		/// ComputePointNormals is on and ComputeCellNormals is off.
		/// </summary>
		// Token: 0x0600EB3A RID: 60218 RVA: 0x0014821C File Offset: 0x0014641C
		public new static vtkPolyDataNormals New()
		{
			vtkPolyDataNormals result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataNormals.vtkPolyDataNormals_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataNormals)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with feature angle=30, splitting and consistency turned on,
		/// flipNormals turned off, and non-manifold traversal turned on.
		/// ComputePointNormals is on and ComputeCellNormals is off.
		/// </summary>
		// Token: 0x0600EB3B RID: 60219 RVA: 0x00148270 File Offset: 0x00146470
		public vtkPolyDataNormals() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolyDataNormals.vtkPolyDataNormals_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EB3C RID: 60220 RVA: 0x001482B4 File Offset: 0x001464B4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EB3D RID: 60221
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataNormals_AutoOrientNormalsOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off the automatic determination of correct normal
		/// orientation. NOTE: This assumes a completely closed surface
		/// (i.e. no boundary edges) and no non-manifold edges. If these
		/// constraints do not hold, all bets are off. This option adds some
		/// computational complexity, and is useful if you don't want to have
		/// to inspect the rendered image to determine whether to turn on the
		/// FlipNormals flag. However, this flag can work with the FlipNormals
		/// flag, and if both are set, all the normals in the output will
		/// point "inward".
		/// </summary>
		// Token: 0x0600EB3E RID: 60222 RVA: 0x001482BF File Offset: 0x001464BF
		public virtual void AutoOrientNormalsOff()
		{
			vtkPolyDataNormals.vtkPolyDataNormals_AutoOrientNormalsOff_01(base.GetCppThis());
		}

		// Token: 0x0600EB3F RID: 60223
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataNormals_AutoOrientNormalsOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off the automatic determination of correct normal
		/// orientation. NOTE: This assumes a completely closed surface
		/// (i.e. no boundary edges) and no non-manifold edges. If these
		/// constraints do not hold, all bets are off. This option adds some
		/// computational complexity, and is useful if you don't want to have
		/// to inspect the rendered image to determine whether to turn on the
		/// FlipNormals flag. However, this flag can work with the FlipNormals
		/// flag, and if both are set, all the normals in the output will
		/// point "inward".
		/// </summary>
		// Token: 0x0600EB40 RID: 60224 RVA: 0x001482CE File Offset: 0x001464CE
		public virtual void AutoOrientNormalsOn()
		{
			vtkPolyDataNormals.vtkPolyDataNormals_AutoOrientNormalsOn_02(base.GetCppThis());
		}

		// Token: 0x0600EB41 RID: 60225
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataNormals_ComputeCellNormalsOff_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off the computation of cell normals.
		/// </summary>
		// Token: 0x0600EB42 RID: 60226 RVA: 0x001482DD File Offset: 0x001464DD
		public virtual void ComputeCellNormalsOff()
		{
			vtkPolyDataNormals.vtkPolyDataNormals_ComputeCellNormalsOff_03(base.GetCppThis());
		}

		// Token: 0x0600EB43 RID: 60227
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataNormals_ComputeCellNormalsOn_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off the computation of cell normals.
		/// </summary>
		// Token: 0x0600EB44 RID: 60228 RVA: 0x001482EC File Offset: 0x001464EC
		public virtual void ComputeCellNormalsOn()
		{
			vtkPolyDataNormals.vtkPolyDataNormals_ComputeCellNormalsOn_04(base.GetCppThis());
		}

		// Token: 0x0600EB45 RID: 60229
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataNormals_ComputePointNormalsOff_05(HandleRef pThis);

		/// <summary>
		/// Turn on/off the computation of point normals.
		/// </summary>
		// Token: 0x0600EB46 RID: 60230 RVA: 0x001482FB File Offset: 0x001464FB
		public virtual void ComputePointNormalsOff()
		{
			vtkPolyDataNormals.vtkPolyDataNormals_ComputePointNormalsOff_05(base.GetCppThis());
		}

		// Token: 0x0600EB47 RID: 60231
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataNormals_ComputePointNormalsOn_06(HandleRef pThis);

		/// <summary>
		/// Turn on/off the computation of point normals.
		/// </summary>
		// Token: 0x0600EB48 RID: 60232 RVA: 0x0014830A File Offset: 0x0014650A
		public virtual void ComputePointNormalsOn()
		{
			vtkPolyDataNormals.vtkPolyDataNormals_ComputePointNormalsOn_06(base.GetCppThis());
		}

		// Token: 0x0600EB49 RID: 60233
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataNormals_ConsistencyOff_07(HandleRef pThis);

		/// <summary>
		/// Turn on/off the enforcement of consistent polygon ordering.
		/// </summary>
		// Token: 0x0600EB4A RID: 60234 RVA: 0x00148319 File Offset: 0x00146519
		public virtual void ConsistencyOff()
		{
			vtkPolyDataNormals.vtkPolyDataNormals_ConsistencyOff_07(base.GetCppThis());
		}

		// Token: 0x0600EB4B RID: 60235
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataNormals_ConsistencyOn_08(HandleRef pThis);

		/// <summary>
		/// Turn on/off the enforcement of consistent polygon ordering.
		/// </summary>
		// Token: 0x0600EB4C RID: 60236 RVA: 0x00148328 File Offset: 0x00146528
		public virtual void ConsistencyOn()
		{
			vtkPolyDataNormals.vtkPolyDataNormals_ConsistencyOn_08(base.GetCppThis());
		}

		// Token: 0x0600EB4D RID: 60237
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataNormals_FlipNormalsOff_09(HandleRef pThis);

		/// <summary>
		/// Turn on/off the global flipping of normal orientation. Flipping
		/// reverves the meaning of front and back for Frontface and Backface
		/// culling in vtkProperty.  Flipping modifies both the normal
		/// direction and the order of a cell's points.
		/// </summary>
		// Token: 0x0600EB4E RID: 60238 RVA: 0x00148337 File Offset: 0x00146537
		public virtual void FlipNormalsOff()
		{
			vtkPolyDataNormals.vtkPolyDataNormals_FlipNormalsOff_09(base.GetCppThis());
		}

		// Token: 0x0600EB4F RID: 60239
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataNormals_FlipNormalsOn_10(HandleRef pThis);

		/// <summary>
		/// Turn on/off the global flipping of normal orientation. Flipping
		/// reverves the meaning of front and back for Frontface and Backface
		/// culling in vtkProperty.  Flipping modifies both the normal
		/// direction and the order of a cell's points.
		/// </summary>
		// Token: 0x0600EB50 RID: 60240 RVA: 0x00148346 File Offset: 0x00146546
		public virtual void FlipNormalsOn()
		{
			vtkPolyDataNormals.vtkPolyDataNormals_FlipNormalsOn_10(base.GetCppThis());
		}

		// Token: 0x0600EB51 RID: 60241
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataNormals_GetAutoOrientNormals_11(HandleRef pThis);

		/// <summary>
		/// Turn on/off the automatic determination of correct normal
		/// orientation. NOTE: This assumes a completely closed surface
		/// (i.e. no boundary edges) and no non-manifold edges. If these
		/// constraints do not hold, all bets are off. This option adds some
		/// computational complexity, and is useful if you don't want to have
		/// to inspect the rendered image to determine whether to turn on the
		/// FlipNormals flag. However, this flag can work with the FlipNormals
		/// flag, and if both are set, all the normals in the output will
		/// point "inward".
		/// </summary>
		// Token: 0x0600EB52 RID: 60242 RVA: 0x00148358 File Offset: 0x00146558
		public virtual int GetAutoOrientNormals()
		{
			return vtkPolyDataNormals.vtkPolyDataNormals_GetAutoOrientNormals_11(base.GetCppThis());
		}

		// Token: 0x0600EB53 RID: 60243
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataNormals_GetComputeCellNormals_12(HandleRef pThis);

		/// <summary>
		/// Turn on/off the computation of cell normals.
		/// </summary>
		// Token: 0x0600EB54 RID: 60244 RVA: 0x00148378 File Offset: 0x00146578
		public virtual int GetComputeCellNormals()
		{
			return vtkPolyDataNormals.vtkPolyDataNormals_GetComputeCellNormals_12(base.GetCppThis());
		}

		// Token: 0x0600EB55 RID: 60245
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataNormals_GetComputePointNormals_13(HandleRef pThis);

		/// <summary>
		/// Turn on/off the computation of point normals.
		/// </summary>
		// Token: 0x0600EB56 RID: 60246 RVA: 0x00148398 File Offset: 0x00146598
		public virtual int GetComputePointNormals()
		{
			return vtkPolyDataNormals.vtkPolyDataNormals_GetComputePointNormals_13(base.GetCppThis());
		}

		// Token: 0x0600EB57 RID: 60247
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataNormals_GetConsistency_14(HandleRef pThis);

		/// <summary>
		/// Turn on/off the enforcement of consistent polygon ordering.
		/// </summary>
		// Token: 0x0600EB58 RID: 60248 RVA: 0x001483B8 File Offset: 0x001465B8
		public virtual int GetConsistency()
		{
			return vtkPolyDataNormals.vtkPolyDataNormals_GetConsistency_14(base.GetCppThis());
		}

		// Token: 0x0600EB59 RID: 60249
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolyDataNormals_GetFeatureAngle_15(HandleRef pThis);

		/// <summary>
		/// Specify the angle that defines a sharp edge. If the difference in
		/// angle across neighboring polygons is greater than this value, the
		/// shared edge is considered "sharp".
		/// </summary>
		// Token: 0x0600EB5A RID: 60250 RVA: 0x001483D8 File Offset: 0x001465D8
		public virtual double GetFeatureAngle()
		{
			return vtkPolyDataNormals.vtkPolyDataNormals_GetFeatureAngle_15(base.GetCppThis());
		}

		// Token: 0x0600EB5B RID: 60251
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolyDataNormals_GetFeatureAngleMaxValue_16(HandleRef pThis);

		/// <summary>
		/// Specify the angle that defines a sharp edge. If the difference in
		/// angle across neighboring polygons is greater than this value, the
		/// shared edge is considered "sharp".
		/// </summary>
		// Token: 0x0600EB5C RID: 60252 RVA: 0x001483F8 File Offset: 0x001465F8
		public virtual double GetFeatureAngleMaxValue()
		{
			return vtkPolyDataNormals.vtkPolyDataNormals_GetFeatureAngleMaxValue_16(base.GetCppThis());
		}

		// Token: 0x0600EB5D RID: 60253
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPolyDataNormals_GetFeatureAngleMinValue_17(HandleRef pThis);

		/// <summary>
		/// Specify the angle that defines a sharp edge. If the difference in
		/// angle across neighboring polygons is greater than this value, the
		/// shared edge is considered "sharp".
		/// </summary>
		// Token: 0x0600EB5E RID: 60254 RVA: 0x00148418 File Offset: 0x00146618
		public virtual double GetFeatureAngleMinValue()
		{
			return vtkPolyDataNormals.vtkPolyDataNormals_GetFeatureAngleMinValue_17(base.GetCppThis());
		}

		// Token: 0x0600EB5F RID: 60255
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataNormals_GetFlipNormals_18(HandleRef pThis);

		/// <summary>
		/// Turn on/off the global flipping of normal orientation. Flipping
		/// reverves the meaning of front and back for Frontface and Backface
		/// culling in vtkProperty.  Flipping modifies both the normal
		/// direction and the order of a cell's points.
		/// </summary>
		// Token: 0x0600EB60 RID: 60256 RVA: 0x00148438 File Offset: 0x00146638
		public virtual int GetFlipNormals()
		{
			return vtkPolyDataNormals.vtkPolyDataNormals_GetFlipNormals_18(base.GetCppThis());
		}

		// Token: 0x0600EB61 RID: 60257
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataNormals_GetNonManifoldTraversal_19(HandleRef pThis);

		/// <summary>
		/// Turn on/off traversal across non-manifold edges. This will prevent
		/// problems where the consistency of polygonal ordering is corrupted due
		/// to topological loops.
		/// </summary>
		// Token: 0x0600EB62 RID: 60258 RVA: 0x00148458 File Offset: 0x00146658
		public virtual int GetNonManifoldTraversal()
		{
			return vtkPolyDataNormals.vtkPolyDataNormals_GetNonManifoldTraversal_19(base.GetCppThis());
		}

		// Token: 0x0600EB63 RID: 60259
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataNormals_GetNumberOfGenerationsFromBase_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EB64 RID: 60260 RVA: 0x00148478 File Offset: 0x00146678
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolyDataNormals.vtkPolyDataNormals_GetNumberOfGenerationsFromBase_20(base.GetCppThis(), type);
		}

		// Token: 0x0600EB65 RID: 60261
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataNormals_GetNumberOfGenerationsFromBaseType_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EB66 RID: 60262 RVA: 0x00148498 File Offset: 0x00146698
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolyDataNormals.vtkPolyDataNormals_GetNumberOfGenerationsFromBaseType_21(type);
		}

		// Token: 0x0600EB67 RID: 60263
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataNormals_GetOutputPointsPrecision_22(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x0600EB68 RID: 60264 RVA: 0x001484B4 File Offset: 0x001466B4
		public virtual int GetOutputPointsPrecision()
		{
			return vtkPolyDataNormals.vtkPolyDataNormals_GetOutputPointsPrecision_22(base.GetCppThis());
		}

		// Token: 0x0600EB69 RID: 60265
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataNormals_GetOutputPointsPrecisionMaxValue_23(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x0600EB6A RID: 60266 RVA: 0x001484D4 File Offset: 0x001466D4
		public virtual int GetOutputPointsPrecisionMaxValue()
		{
			return vtkPolyDataNormals.vtkPolyDataNormals_GetOutputPointsPrecisionMaxValue_23(base.GetCppThis());
		}

		// Token: 0x0600EB6B RID: 60267
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataNormals_GetOutputPointsPrecisionMinValue_24(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x0600EB6C RID: 60268 RVA: 0x001484F4 File Offset: 0x001466F4
		public virtual int GetOutputPointsPrecisionMinValue()
		{
			return vtkPolyDataNormals.vtkPolyDataNormals_GetOutputPointsPrecisionMinValue_24(base.GetCppThis());
		}

		// Token: 0x0600EB6D RID: 60269
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataNormals_GetSplitting_25(HandleRef pThis);

		/// <summary>
		/// Turn on/off the splitting of sharp edges.
		/// </summary>
		// Token: 0x0600EB6E RID: 60270 RVA: 0x00148514 File Offset: 0x00146714
		public virtual int GetSplitting()
		{
			return vtkPolyDataNormals.vtkPolyDataNormals_GetSplitting_25(base.GetCppThis());
		}

		// Token: 0x0600EB6F RID: 60271
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataNormals_IsA_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EB70 RID: 60272 RVA: 0x00148534 File Offset: 0x00146734
		public override int IsA(string type)
		{
			return vtkPolyDataNormals.vtkPolyDataNormals_IsA_26(base.GetCppThis(), type);
		}

		// Token: 0x0600EB71 RID: 60273
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataNormals_IsTypeOf_27([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EB72 RID: 60274 RVA: 0x00148554 File Offset: 0x00146754
		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataNormals.vtkPolyDataNormals_IsTypeOf_27(type);
		}

		// Token: 0x0600EB73 RID: 60275
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataNormals_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EB74 RID: 60276 RVA: 0x00148570 File Offset: 0x00146770
		public new vtkPolyDataNormals NewInstance()
		{
			vtkPolyDataNormals result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataNormals.vtkPolyDataNormals_NewInstance_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataNormals)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EB75 RID: 60277
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataNormals_NonManifoldTraversalOff_30(HandleRef pThis);

		/// <summary>
		/// Turn on/off traversal across non-manifold edges. This will prevent
		/// problems where the consistency of polygonal ordering is corrupted due
		/// to topological loops.
		/// </summary>
		// Token: 0x0600EB76 RID: 60278 RVA: 0x001485CA File Offset: 0x001467CA
		public virtual void NonManifoldTraversalOff()
		{
			vtkPolyDataNormals.vtkPolyDataNormals_NonManifoldTraversalOff_30(base.GetCppThis());
		}

		// Token: 0x0600EB77 RID: 60279
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataNormals_NonManifoldTraversalOn_31(HandleRef pThis);

		/// <summary>
		/// Turn on/off traversal across non-manifold edges. This will prevent
		/// problems where the consistency of polygonal ordering is corrupted due
		/// to topological loops.
		/// </summary>
		// Token: 0x0600EB78 RID: 60280 RVA: 0x001485D9 File Offset: 0x001467D9
		public virtual void NonManifoldTraversalOn()
		{
			vtkPolyDataNormals.vtkPolyDataNormals_NonManifoldTraversalOn_31(base.GetCppThis());
		}

		// Token: 0x0600EB79 RID: 60281
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataNormals_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EB7A RID: 60282 RVA: 0x001485E8 File Offset: 0x001467E8
		public new static vtkPolyDataNormals SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataNormals vtkPolyDataNormals = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataNormals.vtkPolyDataNormals_SafeDownCast_32((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataNormals = (vtkPolyDataNormals)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataNormals.Register(null);
				}
			}
			return vtkPolyDataNormals;
		}

		// Token: 0x0600EB7B RID: 60283
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataNormals_SetAutoOrientNormals_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the automatic determination of correct normal
		/// orientation. NOTE: This assumes a completely closed surface
		/// (i.e. no boundary edges) and no non-manifold edges. If these
		/// constraints do not hold, all bets are off. This option adds some
		/// computational complexity, and is useful if you don't want to have
		/// to inspect the rendered image to determine whether to turn on the
		/// FlipNormals flag. However, this flag can work with the FlipNormals
		/// flag, and if both are set, all the normals in the output will
		/// point "inward".
		/// </summary>
		// Token: 0x0600EB7C RID: 60284 RVA: 0x00148667 File Offset: 0x00146867
		public virtual void SetAutoOrientNormals(int _arg)
		{
			vtkPolyDataNormals.vtkPolyDataNormals_SetAutoOrientNormals_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EB7D RID: 60285
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataNormals_SetComputeCellNormals_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the computation of cell normals.
		/// </summary>
		// Token: 0x0600EB7E RID: 60286 RVA: 0x00148677 File Offset: 0x00146877
		public virtual void SetComputeCellNormals(int _arg)
		{
			vtkPolyDataNormals.vtkPolyDataNormals_SetComputeCellNormals_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EB7F RID: 60287
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataNormals_SetComputePointNormals_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the computation of point normals.
		/// </summary>
		// Token: 0x0600EB80 RID: 60288 RVA: 0x00148687 File Offset: 0x00146887
		public virtual void SetComputePointNormals(int _arg)
		{
			vtkPolyDataNormals.vtkPolyDataNormals_SetComputePointNormals_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EB81 RID: 60289
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataNormals_SetConsistency_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the enforcement of consistent polygon ordering.
		/// </summary>
		// Token: 0x0600EB82 RID: 60290 RVA: 0x00148697 File Offset: 0x00146897
		public virtual void SetConsistency(int _arg)
		{
			vtkPolyDataNormals.vtkPolyDataNormals_SetConsistency_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EB83 RID: 60291
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataNormals_SetFeatureAngle_37(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the angle that defines a sharp edge. If the difference in
		/// angle across neighboring polygons is greater than this value, the
		/// shared edge is considered "sharp".
		/// </summary>
		// Token: 0x0600EB84 RID: 60292 RVA: 0x001486A7 File Offset: 0x001468A7
		public virtual void SetFeatureAngle(double _arg)
		{
			vtkPolyDataNormals.vtkPolyDataNormals_SetFeatureAngle_37(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EB85 RID: 60293
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataNormals_SetFlipNormals_38(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the global flipping of normal orientation. Flipping
		/// reverves the meaning of front and back for Frontface and Backface
		/// culling in vtkProperty.  Flipping modifies both the normal
		/// direction and the order of a cell's points.
		/// </summary>
		// Token: 0x0600EB86 RID: 60294 RVA: 0x001486B7 File Offset: 0x001468B7
		public virtual void SetFlipNormals(int _arg)
		{
			vtkPolyDataNormals.vtkPolyDataNormals_SetFlipNormals_38(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EB87 RID: 60295
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataNormals_SetNonManifoldTraversal_39(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off traversal across non-manifold edges. This will prevent
		/// problems where the consistency of polygonal ordering is corrupted due
		/// to topological loops.
		/// </summary>
		// Token: 0x0600EB88 RID: 60296 RVA: 0x001486C7 File Offset: 0x001468C7
		public virtual void SetNonManifoldTraversal(int _arg)
		{
			vtkPolyDataNormals.vtkPolyDataNormals_SetNonManifoldTraversal_39(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EB89 RID: 60297
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataNormals_SetOutputPointsPrecision_40(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x0600EB8A RID: 60298 RVA: 0x001486D7 File Offset: 0x001468D7
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkPolyDataNormals.vtkPolyDataNormals_SetOutputPointsPrecision_40(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EB8B RID: 60299
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataNormals_SetSplitting_41(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the splitting of sharp edges.
		/// </summary>
		// Token: 0x0600EB8C RID: 60300 RVA: 0x001486E7 File Offset: 0x001468E7
		public virtual void SetSplitting(int _arg)
		{
			vtkPolyDataNormals.vtkPolyDataNormals_SetSplitting_41(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EB8D RID: 60301
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataNormals_SplittingOff_42(HandleRef pThis);

		/// <summary>
		/// Turn on/off the splitting of sharp edges.
		/// </summary>
		// Token: 0x0600EB8E RID: 60302 RVA: 0x001486F7 File Offset: 0x001468F7
		public virtual void SplittingOff()
		{
			vtkPolyDataNormals.vtkPolyDataNormals_SplittingOff_42(base.GetCppThis());
		}

		// Token: 0x0600EB8F RID: 60303
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataNormals_SplittingOn_43(HandleRef pThis);

		/// <summary>
		/// Turn on/off the splitting of sharp edges.
		/// </summary>
		// Token: 0x0600EB90 RID: 60304 RVA: 0x00148706 File Offset: 0x00146906
		public virtual void SplittingOn()
		{
			vtkPolyDataNormals.vtkPolyDataNormals_SplittingOn_43(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001137 RID: 4407
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataNormals";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001138 RID: 4408
		public new static readonly string MRClassNameKey = "class vtkPolyDataNormals";
	}
}
