using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractSurface
	/// </summary>
	/// <remarks>
	///    generate zero-crossing isosurface from
	/// truncated signed distance volume
	///
	///
	/// This filter extracts the zero-crossing isosurface from a truncated signed
	/// distance function TSDF. The TSDF is sampled across a volume, and is
	/// extracted using a modified version of the Flying Edges (FE) algorithm for
	/// increased speed, and to support multithreading. To use the filter, an
	/// input volume should be assigned, which may have special values indicating
	/// empty and/or unseen portions of the volume. These values are equal to +/-
	/// radius value of the signed distance function, and should be consistent
	/// with any filters used to generate the input volume (e.g.,
	/// vtkSignedDistance).
	///
	/// The Flying Edges algorithm is modified to deal with the nature of the
	/// truncated, signed distance function. Being truncated, the distance
	/// function typically is not computed throughout the volume, rather the
	/// special data values "unseen" and/or "empty" maybe assigned to distant or
	/// bordering voxels. The implications of this are that this implementation
	/// may produce non-closed, non-manifold surfaces, which is what is required
	/// to extract surfaces.
	///
	/// More specifically, voxels may exist in one of three states: 1) within the
	/// TSDF, which extends +/-Radius from a generating geometry (typically a
	/// point cloud); 2) in the empty state, in which it is known that the surface
	/// does not exist; and 3) the unseen state, where a surface may exist but not
	/// enough information is known to be certain. Such situations arise, for
	/// example, when laser scanners generate point clouds, and the propagation of
	/// the laser beam "carves" out regions where no geometry exists (thereby
	/// defining empty space). Furthermore, areas in which the beam are occluded
	/// by geometry are known as "unseen" and the boundary between empty and
	/// unseen can be processed to produced a portion of the output isosurface
	/// (this is called hole filling).
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// @warning
	/// Empty regions are expected to have a data value
	/// -(this-&gt;Radius+FLT_EPSILON). Unseen regions are expected to have a data
	/// value (this-&gt;Radius+FLT_EPSILON). Near regions have data values d such that:
	/// -(this-&gt;Radius+FLT_EPSILON) &lt; d (this-&gt;Radius+FLT_EPSILON).
	///
	/// @warning
	/// &lt;pre&gt;
	/// Notes on the implementation:
	/// 1. This is a lightly modified version of vtkFlyingEdges3D. Some design goals
	///    included minimizing the impact on the FE algorithm, and not adding extra
	///    memory requirements.
	/// 2. It presumes an isocontour value=0.0 (the zero crossing of a signed
	///    distance function).
	/// 3. The major modifications are to the edge cases. In Flying Edges, a single
	///    byte represents the case of an edge, and within that byte only 2 bits
	///    are needed (the extra six bytes are not used). Here, these unused bytes
	///    are repurposed to represent the "state" of the edge, whether it is
	///    1) near to the TSDF; 2) in an empty state; or 3) unseen state.
	/// 4. Since these now-used bits encode extra state information, masking and
	///    related methods are modified from FE to tease apart the edge cases from
	///    the edge state.
	/// 5. Voxels with edges marked "empty" are not processed, i.e., no output
	///    triangle primitives are generated. Depending on whether hole filling is
	///    enabled, voxels with edges marked "unseen" may not be processed either.
	/// 6. As a result of #1 and #5, and the desire to keep the implementation simple,
	///    it is possible to produce output points which are not used by any output
	///    triangle.
	///             &lt;/pre&gt;
	///
	/// @warning
	/// This algorithm loosely follows the most excellent paper by Curless and
	/// Levoy: "A Volumetric Method for Building Complex Models from Range
	/// Images."
	///
	/// @warning
	/// This algorithm differs from the paper cited above in an important way. The
	/// Curless &amp; Levoy algorithm is designed to create watertight surfaces, while this
	/// modified algorithm may not do so as the generating surface is not assumed to be
	/// closed.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSignedDistance vtkFlyingEdges3D
	/// </seealso>
	// Token: 0x02000443 RID: 1091
	public class vtkExtractSurface : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600CBAD RID: 52141 RVA: 0x0011B5CF File Offset: 0x001197CF
		static vtkExtractSurface()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractSurface.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractSurface"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600CBAE RID: 52142 RVA: 0x0011B5F7 File Offset: 0x001197F7
		public vtkExtractSurface(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600CBAF RID: 52143
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSurface_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating the class, providing type information,
		/// and printing.
		/// </summary>
		// Token: 0x0600CBB0 RID: 52144 RVA: 0x0011B608 File Offset: 0x00119808
		public new static vtkExtractSurface New()
		{
			vtkExtractSurface result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSurface.vtkExtractSurface_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSurface)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiating the class, providing type information,
		/// and printing.
		/// </summary>
		// Token: 0x0600CBB1 RID: 52145 RVA: 0x0011B65C File Offset: 0x0011985C
		public vtkExtractSurface() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractSurface.vtkExtractSurface_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600CBB2 RID: 52146 RVA: 0x0011B6A0 File Offset: 0x001198A0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600CBB3 RID: 52147
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSurface_ComputeGradientsOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is fairly
		/// expensive in both time and storage. Note that if ComputeNormals is on,
		/// gradients will have to be calculated, but will not be stored in the
		/// output dataset. If the output data will be processed by filters that
		/// modify topology or geometry, it may be wise to turn Normals and
		/// Gradients off.
		/// </summary>
		// Token: 0x0600CBB4 RID: 52148 RVA: 0x0011B6AB File Offset: 0x001198AB
		public virtual void ComputeGradientsOff()
		{
			vtkExtractSurface.vtkExtractSurface_ComputeGradientsOff_01(base.GetCppThis());
		}

		// Token: 0x0600CBB5 RID: 52149
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSurface_ComputeGradientsOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is fairly
		/// expensive in both time and storage. Note that if ComputeNormals is on,
		/// gradients will have to be calculated, but will not be stored in the
		/// output dataset. If the output data will be processed by filters that
		/// modify topology or geometry, it may be wise to turn Normals and
		/// Gradients off.
		/// </summary>
		// Token: 0x0600CBB6 RID: 52150 RVA: 0x0011B6BA File Offset: 0x001198BA
		public virtual void ComputeGradientsOn()
		{
			vtkExtractSurface.vtkExtractSurface_ComputeGradientsOn_02(base.GetCppThis());
		}

		// Token: 0x0600CBB7 RID: 52151
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSurface_ComputeNormalsOff_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be processed
		/// by filters that modify topology or geometry, it may be wise to turn
		/// Normals and Gradients off.
		/// </summary>
		// Token: 0x0600CBB8 RID: 52152 RVA: 0x0011B6C9 File Offset: 0x001198C9
		public virtual void ComputeNormalsOff()
		{
			vtkExtractSurface.vtkExtractSurface_ComputeNormalsOff_03(base.GetCppThis());
		}

		// Token: 0x0600CBB9 RID: 52153
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSurface_ComputeNormalsOn_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be processed
		/// by filters that modify topology or geometry, it may be wise to turn
		/// Normals and Gradients off.
		/// </summary>
		// Token: 0x0600CBBA RID: 52154 RVA: 0x0011B6D8 File Offset: 0x001198D8
		public virtual void ComputeNormalsOn()
		{
			vtkExtractSurface.vtkExtractSurface_ComputeNormalsOn_04(base.GetCppThis());
		}

		// Token: 0x0600CBBB RID: 52155
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSurface_GetComputeGradients_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is fairly
		/// expensive in both time and storage. Note that if ComputeNormals is on,
		/// gradients will have to be calculated, but will not be stored in the
		/// output dataset. If the output data will be processed by filters that
		/// modify topology or geometry, it may be wise to turn Normals and
		/// Gradients off.
		/// </summary>
		// Token: 0x0600CBBC RID: 52156 RVA: 0x0011B6E8 File Offset: 0x001198E8
		public virtual int GetComputeGradients()
		{
			return vtkExtractSurface.vtkExtractSurface_GetComputeGradients_05(base.GetCppThis());
		}

		// Token: 0x0600CBBD RID: 52157
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSurface_GetComputeNormals_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be processed
		/// by filters that modify topology or geometry, it may be wise to turn
		/// Normals and Gradients off.
		/// </summary>
		// Token: 0x0600CBBE RID: 52158 RVA: 0x0011B708 File Offset: 0x00119908
		public virtual int GetComputeNormals()
		{
			return vtkExtractSurface.vtkExtractSurface_GetComputeNormals_06(base.GetCppThis());
		}

		// Token: 0x0600CBBF RID: 52159
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkExtractSurface_GetHoleFilling_07(HandleRef pThis);

		/// <summary>
		/// Enable hole filling. This generates separating surfaces between the
		/// empty and unseen portions of the volume.
		/// </summary>
		// Token: 0x0600CBC0 RID: 52160 RVA: 0x0011B728 File Offset: 0x00119928
		public virtual bool GetHoleFilling()
		{
			return vtkExtractSurface.vtkExtractSurface_GetHoleFilling_07(base.GetCppThis()) != 0;
		}

		// Token: 0x0600CBC1 RID: 52161
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractSurface_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating the class, providing type information,
		/// and printing.
		/// </summary>
		// Token: 0x0600CBC2 RID: 52162 RVA: 0x0011B750 File Offset: 0x00119950
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractSurface.vtkExtractSurface_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0600CBC3 RID: 52163
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractSurface_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating the class, providing type information,
		/// and printing.
		/// </summary>
		// Token: 0x0600CBC4 RID: 52164 RVA: 0x0011B770 File Offset: 0x00119970
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractSurface.vtkExtractSurface_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0600CBC5 RID: 52165
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkExtractSurface_GetRadius_10(HandleRef pThis);

		/// <summary>
		/// Specify the radius of influence of the signed distance function. Data
		/// values (which are distances) that are greater than the radius (i.e., d &gt;
		/// Radius) are considered empty voxels; those voxel data values d &lt; -Radius
		/// are considered unseen voxels.
		/// </summary>
		// Token: 0x0600CBC6 RID: 52166 RVA: 0x0011B78C File Offset: 0x0011998C
		public virtual double GetRadius()
		{
			return vtkExtractSurface.vtkExtractSurface_GetRadius_10(base.GetCppThis());
		}

		// Token: 0x0600CBC7 RID: 52167
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkExtractSurface_GetRadiusMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Specify the radius of influence of the signed distance function. Data
		/// values (which are distances) that are greater than the radius (i.e., d &gt;
		/// Radius) are considered empty voxels; those voxel data values d &lt; -Radius
		/// are considered unseen voxels.
		/// </summary>
		// Token: 0x0600CBC8 RID: 52168 RVA: 0x0011B7AC File Offset: 0x001199AC
		public virtual double GetRadiusMaxValue()
		{
			return vtkExtractSurface.vtkExtractSurface_GetRadiusMaxValue_11(base.GetCppThis());
		}

		// Token: 0x0600CBC9 RID: 52169
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkExtractSurface_GetRadiusMinValue_12(HandleRef pThis);

		/// <summary>
		/// Specify the radius of influence of the signed distance function. Data
		/// values (which are distances) that are greater than the radius (i.e., d &gt;
		/// Radius) are considered empty voxels; those voxel data values d &lt; -Radius
		/// are considered unseen voxels.
		/// </summary>
		// Token: 0x0600CBCA RID: 52170 RVA: 0x0011B7CC File Offset: 0x001199CC
		public virtual double GetRadiusMinValue()
		{
			return vtkExtractSurface.vtkExtractSurface_GetRadiusMinValue_12(base.GetCppThis());
		}

		// Token: 0x0600CBCB RID: 52171
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSurface_HoleFillingOff_13(HandleRef pThis);

		/// <summary>
		/// Enable hole filling. This generates separating surfaces between the
		/// empty and unseen portions of the volume.
		/// </summary>
		// Token: 0x0600CBCC RID: 52172 RVA: 0x0011B7EB File Offset: 0x001199EB
		public virtual void HoleFillingOff()
		{
			vtkExtractSurface.vtkExtractSurface_HoleFillingOff_13(base.GetCppThis());
		}

		// Token: 0x0600CBCD RID: 52173
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSurface_HoleFillingOn_14(HandleRef pThis);

		/// <summary>
		/// Enable hole filling. This generates separating surfaces between the
		/// empty and unseen portions of the volume.
		/// </summary>
		// Token: 0x0600CBCE RID: 52174 RVA: 0x0011B7FA File Offset: 0x001199FA
		public virtual void HoleFillingOn()
		{
			vtkExtractSurface.vtkExtractSurface_HoleFillingOn_14(base.GetCppThis());
		}

		// Token: 0x0600CBCF RID: 52175
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSurface_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating the class, providing type information,
		/// and printing.
		/// </summary>
		// Token: 0x0600CBD0 RID: 52176 RVA: 0x0011B80C File Offset: 0x00119A0C
		public override int IsA(string type)
		{
			return vtkExtractSurface.vtkExtractSurface_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x0600CBD1 RID: 52177
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSurface_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating the class, providing type information,
		/// and printing.
		/// </summary>
		// Token: 0x0600CBD2 RID: 52178 RVA: 0x0011B82C File Offset: 0x00119A2C
		public new static int IsTypeOf(string type)
		{
			return vtkExtractSurface.vtkExtractSurface_IsTypeOf_16(type);
		}

		// Token: 0x0600CBD3 RID: 52179
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSurface_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating the class, providing type information,
		/// and printing.
		/// </summary>
		// Token: 0x0600CBD4 RID: 52180 RVA: 0x0011B848 File Offset: 0x00119A48
		public new vtkExtractSurface NewInstance()
		{
			vtkExtractSurface result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSurface.vtkExtractSurface_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSurface)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600CBD5 RID: 52181
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSurface_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating the class, providing type information,
		/// and printing.
		/// </summary>
		// Token: 0x0600CBD6 RID: 52182 RVA: 0x0011B8A4 File Offset: 0x00119AA4
		public new static vtkExtractSurface SafeDownCast(vtkObjectBase o)
		{
			vtkExtractSurface vtkExtractSurface = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSurface.vtkExtractSurface_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractSurface = (vtkExtractSurface)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractSurface.Register(null);
				}
			}
			return vtkExtractSurface;
		}

		// Token: 0x0600CBD7 RID: 52183
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSurface_SetComputeGradients_20(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of gradients. Gradient computation is fairly
		/// expensive in both time and storage. Note that if ComputeNormals is on,
		/// gradients will have to be calculated, but will not be stored in the
		/// output dataset. If the output data will be processed by filters that
		/// modify topology or geometry, it may be wise to turn Normals and
		/// Gradients off.
		/// </summary>
		// Token: 0x0600CBD8 RID: 52184 RVA: 0x0011B923 File Offset: 0x00119B23
		public virtual void SetComputeGradients(int _arg)
		{
			vtkExtractSurface.vtkExtractSurface_SetComputeGradients_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CBD9 RID: 52185
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSurface_SetComputeNormals_21(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of normals. Normal computation is fairly
		/// expensive in both time and storage. If the output data will be processed
		/// by filters that modify topology or geometry, it may be wise to turn
		/// Normals and Gradients off.
		/// </summary>
		// Token: 0x0600CBDA RID: 52186 RVA: 0x0011B933 File Offset: 0x00119B33
		public virtual void SetComputeNormals(int _arg)
		{
			vtkExtractSurface.vtkExtractSurface_SetComputeNormals_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CBDB RID: 52187
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSurface_SetHoleFilling_22(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable hole filling. This generates separating surfaces between the
		/// empty and unseen portions of the volume.
		/// </summary>
		// Token: 0x0600CBDC RID: 52188 RVA: 0x0011B943 File Offset: 0x00119B43
		public virtual void SetHoleFilling(bool _arg)
		{
			vtkExtractSurface.vtkExtractSurface_SetHoleFilling_22(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600CBDD RID: 52189
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractSurface_SetRadius_23(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the radius of influence of the signed distance function. Data
		/// values (which are distances) that are greater than the radius (i.e., d &gt;
		/// Radius) are considered empty voxels; those voxel data values d &lt; -Radius
		/// are considered unseen voxels.
		/// </summary>
		// Token: 0x0600CBDE RID: 52190 RVA: 0x0011B95B File Offset: 0x00119B5B
		public virtual void SetRadius(double _arg)
		{
			vtkExtractSurface.vtkExtractSurface_SetRadius_23(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F13 RID: 3859
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractSurface";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F14 RID: 3860
		public new static readonly string MRClassNameKey = "class vtkExtractSurface";
	}
}
