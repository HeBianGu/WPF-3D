using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCheckerboardSplatter
	/// </summary>
	/// <remarks>
	///    splat points into a volume with an elliptical, Gaussian distribution
	///
	/// vtkCheckerboardSplatter is a filter that injects input points into a
	/// structured points (volume) dataset using a multithreaded 8-way
	/// checkerboard approach. It produces a scalar field of a specified type. As
	/// each point is injected, it "splats" or distributes values to nearby
	/// voxels. Data is distributed using an elliptical, Gaussian distribution
	/// function. The distribution function is modified using scalar values
	/// (expands distribution) or normals (creates ellipsoidal distribution rather
	/// than spherical). This algorithm is designed for scalability through
	/// multithreading.
	///
	/// In general, the Gaussian distribution function f(x) around a given
	/// splat point p is given by
	///
	///     f(x) = ScaleFactor * exp( ExponentFactor*((r/Radius)**2) )
	///
	/// where x is the current voxel sample point; r is the distance |x-p|
	/// ExponentFactor &lt;= 0.0, and ScaleFactor can be multiplied by the scalar
	/// value of the point p that is currently being splatted.
	///
	/// If point normals are present (and NormalWarping is on), then the splat
	/// function becomes elliptical (as compared to the spherical one described
	/// by the previous equation). The Gaussian distribution function then
	/// becomes:
	///
	///     f(x) = ScaleFactor *
	///               exp( ExponentFactor*( ((rxy/E)**2 + z**2)/R**2) )
	///
	/// where E is a user-defined eccentricity factor that controls the elliptical
	/// shape of the splat; z is the distance of the current voxel sample point
	/// along normal N; and rxy is the distance of x in the direction
	/// perpendicular to N.
	///
	/// This class is typically used to convert point-valued distributions into
	/// a volume representation. The volume is then usually iso-surfaced or
	/// volume rendered to generate a visualization. It can be used to create
	/// surfaces from point distributions, or to create structure (i.e.,
	/// topology) when none exists.
	///
	/// This class makes use of vtkSMPTools to implement a parallel, shared-memory
	/// implementation. Hence performance will be significantly improved if VTK is
	/// built with VTK_SMP_IMPLEMENTATION_TYPE set to something other than
	/// "Sequential" (typically TBB). For example, on a standard laptop with four
	/// threads it is common to see a &gt;10x speedup as compared to the serial
	/// version of vtkGaussianSplatter.
	///
	/// In summary, the algorithm operates by dividing the volume into a 3D
	/// checkerboard, where the squares of the checkerboard overlay voxels in the
	/// volume. The checkerboard overlay is designed as a function of the splat
	/// footprint, so that when splatting occurs in a group (or color) of
	/// checkerboard squares, the splat operation will not cause write contention
	/// as the splatting proceeds in parallel. There are eight colors in this
	/// checkerboard (like an octree) and parallel splatting occurs simultaneously
	/// in one of the eight colors (e.g., octants). A single splat operation
	/// (across the given 3D footprint) may also be parallelized if the splat is
	/// large enough.
	///
	/// @warning
	/// The input to this filter is of type vtkPointSet. Currently only real types
	/// (e.g., float, double) are supported as input, but this could easily be
	/// extended to other types. The output type is limited to real types as well.
	///
	/// @warning
	/// Some voxels may never receive a contribution during the splatting process.
	/// The final value of these points can be specified with the "NullValue"
	/// instance variable. Note that NullValue is also the initial value of the
	/// output voxel values and will affect the accumulation process.
	///
	/// @warning
	/// While this class is very similar to vtkGaussianSplatter, it does produce
	/// slightly different output in most cases (due to the way the footprint is
	/// computed).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkShepardMethod vtkGaussianSplatter
	/// </seealso>
	// Token: 0x020003DE RID: 990
	public class vtkCheckerboardSplatter : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600BD5E RID: 48478 RVA: 0x0010864C File Offset: 0x0010684C
		static vtkCheckerboardSplatter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCheckerboardSplatter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCheckerboardSplatter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600BD5F RID: 48479 RVA: 0x00108674 File Offset: 0x00106874
		public vtkCheckerboardSplatter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600BD60 RID: 48480
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCheckerboardSplatter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with dimensions=(50,50,50); automatic computation of
		/// bounds; a Footprint of 2; a Radius of 0; an exponent factor of -5; and normal and
		/// scalar warping enabled; and Capping enabled.
		/// </summary>
		// Token: 0x0600BD61 RID: 48481 RVA: 0x00108684 File Offset: 0x00106884
		public new static vtkCheckerboardSplatter New()
		{
			vtkCheckerboardSplatter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCheckerboardSplatter.vtkCheckerboardSplatter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCheckerboardSplatter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with dimensions=(50,50,50); automatic computation of
		/// bounds; a Footprint of 2; a Radius of 0; an exponent factor of -5; and normal and
		/// scalar warping enabled; and Capping enabled.
		/// </summary>
		// Token: 0x0600BD62 RID: 48482 RVA: 0x001086D8 File Offset: 0x001068D8
		public vtkCheckerboardSplatter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCheckerboardSplatter.vtkCheckerboardSplatter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600BD63 RID: 48483 RVA: 0x0010871C File Offset: 0x0010691C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600BD64 RID: 48484
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_CappingOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off the capping of the outer boundary of the volume
		/// to a specified cap value. This can be used to close surfaces
		/// (after iso-surfacing) and create other effects.
		/// </summary>
		// Token: 0x0600BD65 RID: 48485 RVA: 0x00108727 File Offset: 0x00106927
		public virtual void CappingOff()
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_CappingOff_01(base.GetCppThis());
		}

		// Token: 0x0600BD66 RID: 48486
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_CappingOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off the capping of the outer boundary of the volume
		/// to a specified cap value. This can be used to close surfaces
		/// (after iso-surfacing) and create other effects.
		/// </summary>
		// Token: 0x0600BD67 RID: 48487 RVA: 0x00108736 File Offset: 0x00106936
		public virtual void CappingOn()
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_CappingOn_02(base.GetCppThis());
		}

		// Token: 0x0600BD68 RID: 48488
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_ComputeModelBounds_03(HandleRef pThis, HandleRef input, HandleRef output, HandleRef outInfo);

		/// <summary>
		/// Compute the size of the sample bounding box automatically from the
		/// input data. This is an internal helper function.
		/// </summary>
		// Token: 0x0600BD69 RID: 48489 RVA: 0x00108748 File Offset: 0x00106948
		public void ComputeModelBounds(vtkDataSet input, vtkImageData output, vtkInformation outInfo)
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_ComputeModelBounds_03(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis(), (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis());
		}

		// Token: 0x0600BD6A RID: 48490
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCheckerboardSplatter_GetAccumulationMode_04(HandleRef pThis);

		/// <summary>
		/// Specify the scalar accumulation mode. This mode expresses how scalar
		/// values are combined when splats overlap one another. The Max mode acts
		/// like a set union operation and is the most commonly used; the Min mode
		/// acts like a set intersection, and the sum is just weird (and can
		/// potentially cause accumulation overflow in extreme cases). Note that the
		/// NullValue must be set consistent with the accumulation operation.
		/// </summary>
		// Token: 0x0600BD6B RID: 48491 RVA: 0x001087A4 File Offset: 0x001069A4
		public virtual int GetAccumulationMode()
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetAccumulationMode_04(base.GetCppThis());
		}

		// Token: 0x0600BD6C RID: 48492
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCheckerboardSplatter_GetAccumulationModeAsString_05(HandleRef pThis);

		/// <summary>
		/// Specify the scalar accumulation mode. This mode expresses how scalar
		/// values are combined when splats overlap one another. The Max mode acts
		/// like a set union operation and is the most commonly used; the Min mode
		/// acts like a set intersection, and the sum is just weird (and can
		/// potentially cause accumulation overflow in extreme cases). Note that the
		/// NullValue must be set consistent with the accumulation operation.
		/// </summary>
		// Token: 0x0600BD6D RID: 48493 RVA: 0x001087C4 File Offset: 0x001069C4
		public string GetAccumulationModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetAccumulationModeAsString_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600BD6E RID: 48494
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCheckerboardSplatter_GetAccumulationModeMaxValue_06(HandleRef pThis);

		/// <summary>
		/// Specify the scalar accumulation mode. This mode expresses how scalar
		/// values are combined when splats overlap one another. The Max mode acts
		/// like a set union operation and is the most commonly used; the Min mode
		/// acts like a set intersection, and the sum is just weird (and can
		/// potentially cause accumulation overflow in extreme cases). Note that the
		/// NullValue must be set consistent with the accumulation operation.
		/// </summary>
		// Token: 0x0600BD6F RID: 48495 RVA: 0x00108800 File Offset: 0x00106A00
		public virtual int GetAccumulationModeMaxValue()
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetAccumulationModeMaxValue_06(base.GetCppThis());
		}

		// Token: 0x0600BD70 RID: 48496
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCheckerboardSplatter_GetAccumulationModeMinValue_07(HandleRef pThis);

		/// <summary>
		/// Specify the scalar accumulation mode. This mode expresses how scalar
		/// values are combined when splats overlap one another. The Max mode acts
		/// like a set union operation and is the most commonly used; the Min mode
		/// acts like a set intersection, and the sum is just weird (and can
		/// potentially cause accumulation overflow in extreme cases). Note that the
		/// NullValue must be set consistent with the accumulation operation.
		/// </summary>
		// Token: 0x0600BD71 RID: 48497 RVA: 0x00108820 File Offset: 0x00106A20
		public virtual int GetAccumulationModeMinValue()
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetAccumulationModeMinValue_07(base.GetCppThis());
		}

		// Token: 0x0600BD72 RID: 48498
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCheckerboardSplatter_GetCapValue_08(HandleRef pThis);

		/// <summary>
		/// Specify the cap value to use. (This instance variable only has effect
		/// if the ivar Capping is on.)
		/// </summary>
		// Token: 0x0600BD73 RID: 48499 RVA: 0x00108840 File Offset: 0x00106A40
		public virtual double GetCapValue()
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetCapValue_08(base.GetCppThis());
		}

		// Token: 0x0600BD74 RID: 48500
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCheckerboardSplatter_GetCapping_09(HandleRef pThis);

		/// <summary>
		/// Turn on/off the capping of the outer boundary of the volume
		/// to a specified cap value. This can be used to close surfaces
		/// (after iso-surfacing) and create other effects.
		/// </summary>
		// Token: 0x0600BD75 RID: 48501 RVA: 0x00108860 File Offset: 0x00106A60
		public virtual int GetCapping()
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetCapping_09(base.GetCppThis());
		}

		// Token: 0x0600BD76 RID: 48502
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCheckerboardSplatter_GetEccentricity_10(HandleRef pThis);

		/// <summary>
		/// Control the shape of elliptical splatting. Eccentricity is the ratio
		/// of the major axis (aligned along normal) to the minor (axes) aligned
		/// along other two axes. So Eccentricity &gt; 1 creates needles with the
		/// long axis in the direction of the normal; Eccentricity&lt;1 creates
		/// pancakes perpendicular to the normal vector.
		/// </summary>
		// Token: 0x0600BD77 RID: 48503 RVA: 0x00108880 File Offset: 0x00106A80
		public virtual double GetEccentricity()
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetEccentricity_10(base.GetCppThis());
		}

		// Token: 0x0600BD78 RID: 48504
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCheckerboardSplatter_GetEccentricityMaxValue_11(HandleRef pThis);

		/// <summary>
		/// Control the shape of elliptical splatting. Eccentricity is the ratio
		/// of the major axis (aligned along normal) to the minor (axes) aligned
		/// along other two axes. So Eccentricity &gt; 1 creates needles with the
		/// long axis in the direction of the normal; Eccentricity&lt;1 creates
		/// pancakes perpendicular to the normal vector.
		/// </summary>
		// Token: 0x0600BD79 RID: 48505 RVA: 0x001088A0 File Offset: 0x00106AA0
		public virtual double GetEccentricityMaxValue()
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetEccentricityMaxValue_11(base.GetCppThis());
		}

		// Token: 0x0600BD7A RID: 48506
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCheckerboardSplatter_GetEccentricityMinValue_12(HandleRef pThis);

		/// <summary>
		/// Control the shape of elliptical splatting. Eccentricity is the ratio
		/// of the major axis (aligned along normal) to the minor (axes) aligned
		/// along other two axes. So Eccentricity &gt; 1 creates needles with the
		/// long axis in the direction of the normal; Eccentricity&lt;1 creates
		/// pancakes perpendicular to the normal vector.
		/// </summary>
		// Token: 0x0600BD7B RID: 48507 RVA: 0x001088C0 File Offset: 0x00106AC0
		public virtual double GetEccentricityMinValue()
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetEccentricityMinValue_12(base.GetCppThis());
		}

		// Token: 0x0600BD7C RID: 48508
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCheckerboardSplatter_GetExponentFactor_13(HandleRef pThis);

		/// <summary>
		/// Set / get the sharpness of decay of the splats. This is the exponent
		/// constant in the Gaussian equation described above. Normally this is a
		/// negative value.
		/// </summary>
		// Token: 0x0600BD7D RID: 48509 RVA: 0x001088E0 File Offset: 0x00106AE0
		public virtual double GetExponentFactor()
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetExponentFactor_13(base.GetCppThis());
		}

		// Token: 0x0600BD7E RID: 48510
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCheckerboardSplatter_GetFootprint_14(HandleRef pThis);

		/// <summary>
		/// Control the footprint size of the splat in terms of propagation across a
		/// voxel neighborhood. The Footprint value simply indicates the number of
		/// neighboring voxels in the i-j-k directions to extend the splat. A value
		/// of zero means that only the voxel containing the splat point is
		/// affected. A value of one means the immediate neighbors touching the
		/// affected voxel are affected as well. Larger numbers increase the splat
		/// footprint and significantly increase processing time. Note that the
		/// footprint is always 3D rectangular.
		/// </summary>
		// Token: 0x0600BD7F RID: 48511 RVA: 0x00108900 File Offset: 0x00106B00
		public virtual int GetFootprint()
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetFootprint_14(base.GetCppThis());
		}

		// Token: 0x0600BD80 RID: 48512
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCheckerboardSplatter_GetFootprintMaxValue_15(HandleRef pThis);

		/// <summary>
		/// Control the footprint size of the splat in terms of propagation across a
		/// voxel neighborhood. The Footprint value simply indicates the number of
		/// neighboring voxels in the i-j-k directions to extend the splat. A value
		/// of zero means that only the voxel containing the splat point is
		/// affected. A value of one means the immediate neighbors touching the
		/// affected voxel are affected as well. Larger numbers increase the splat
		/// footprint and significantly increase processing time. Note that the
		/// footprint is always 3D rectangular.
		/// </summary>
		// Token: 0x0600BD81 RID: 48513 RVA: 0x00108920 File Offset: 0x00106B20
		public virtual int GetFootprintMaxValue()
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetFootprintMaxValue_15(base.GetCppThis());
		}

		// Token: 0x0600BD82 RID: 48514
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCheckerboardSplatter_GetFootprintMinValue_16(HandleRef pThis);

		/// <summary>
		/// Control the footprint size of the splat in terms of propagation across a
		/// voxel neighborhood. The Footprint value simply indicates the number of
		/// neighboring voxels in the i-j-k directions to extend the splat. A value
		/// of zero means that only the voxel containing the splat point is
		/// affected. A value of one means the immediate neighbors touching the
		/// affected voxel are affected as well. Larger numbers increase the splat
		/// footprint and significantly increase processing time. Note that the
		/// footprint is always 3D rectangular.
		/// </summary>
		// Token: 0x0600BD83 RID: 48515 RVA: 0x00108940 File Offset: 0x00106B40
		public virtual int GetFootprintMinValue()
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetFootprintMinValue_16(base.GetCppThis());
		}

		// Token: 0x0600BD84 RID: 48516
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCheckerboardSplatter_GetMaximumDimension_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum dimension of the checkerboard (i.e., the number of
		/// squares in any of the i, j, or k directions). This number also impacts
		/// the granularity of the parallel threading (since each checker square is
		/// processed separaely). Because of the internal addressing, the maximum
		/// dimension is limited to 255 (maximum value of an unsigned char).
		/// </summary>
		// Token: 0x0600BD85 RID: 48517 RVA: 0x00108960 File Offset: 0x00106B60
		public virtual int GetMaximumDimension()
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetMaximumDimension_17(base.GetCppThis());
		}

		// Token: 0x0600BD86 RID: 48518
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCheckerboardSplatter_GetMaximumDimensionMaxValue_18(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum dimension of the checkerboard (i.e., the number of
		/// squares in any of the i, j, or k directions). This number also impacts
		/// the granularity of the parallel threading (since each checker square is
		/// processed separaely). Because of the internal addressing, the maximum
		/// dimension is limited to 255 (maximum value of an unsigned char).
		/// </summary>
		// Token: 0x0600BD87 RID: 48519 RVA: 0x00108980 File Offset: 0x00106B80
		public virtual int GetMaximumDimensionMaxValue()
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetMaximumDimensionMaxValue_18(base.GetCppThis());
		}

		// Token: 0x0600BD88 RID: 48520
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCheckerboardSplatter_GetMaximumDimensionMinValue_19(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum dimension of the checkerboard (i.e., the number of
		/// squares in any of the i, j, or k directions). This number also impacts
		/// the granularity of the parallel threading (since each checker square is
		/// processed separaely). Because of the internal addressing, the maximum
		/// dimension is limited to 255 (maximum value of an unsigned char).
		/// </summary>
		// Token: 0x0600BD89 RID: 48521 RVA: 0x001089A0 File Offset: 0x00106BA0
		public virtual int GetMaximumDimensionMinValue()
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetMaximumDimensionMinValue_19(base.GetCppThis());
		}

		// Token: 0x0600BD8A RID: 48522
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCheckerboardSplatter_GetModelBounds_20(HandleRef pThis);

		/// <summary>
		/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
		/// the sampling is performed. If any of the (min,max) bounds values are
		/// min &gt;= max, then the bounds will be computed automatically from the input
		/// data. Otherwise, the user-specified bounds will be used.
		/// </summary>
		// Token: 0x0600BD8B RID: 48523 RVA: 0x001089C0 File Offset: 0x00106BC0
		public virtual double[] GetModelBounds()
		{
			IntPtr intPtr = vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetModelBounds_20(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600BD8C RID: 48524
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_GetModelBounds_21(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
		/// the sampling is performed. If any of the (min,max) bounds values are
		/// min &gt;= max, then the bounds will be computed automatically from the input
		/// data. Otherwise, the user-specified bounds will be used.
		/// </summary>
		// Token: 0x0600BD8D RID: 48525 RVA: 0x00108A08 File Offset: 0x00106C08
		public virtual void GetModelBounds(IntPtr data)
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetModelBounds_21(base.GetCppThis(), data);
		}

		// Token: 0x0600BD8E RID: 48526
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCheckerboardSplatter_GetNormalWarping_22(HandleRef pThis);

		/// <summary>
		/// Turn on/off the generation of elliptical splats. If normal warping is
		/// on, then the input normals affect the distribution of the splat. This
		/// boolean is used in combination with the Eccentricity ivar.
		/// </summary>
		// Token: 0x0600BD8F RID: 48527 RVA: 0x00108A18 File Offset: 0x00106C18
		public virtual int GetNormalWarping()
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetNormalWarping_22(base.GetCppThis());
		}

		// Token: 0x0600BD90 RID: 48528
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCheckerboardSplatter_GetNullValue_23(HandleRef pThis);

		/// <summary>
		/// Set the Null value for output points not receiving a contribution from
		/// the input points. (This is the initial value of the voxel samples, by
		/// default it is set to zero.) Note that the value should be consistent
		/// with the output dataset type. The NullValue also provides the initial
		/// value on which the accumulations process operates.
		/// </summary>
		// Token: 0x0600BD91 RID: 48529 RVA: 0x00108A38 File Offset: 0x00106C38
		public virtual double GetNullValue()
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetNullValue_23(base.GetCppThis());
		}

		// Token: 0x0600BD92 RID: 48530
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCheckerboardSplatter_GetNumberOfGenerationsFromBase_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BD93 RID: 48531 RVA: 0x00108A58 File Offset: 0x00106C58
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetNumberOfGenerationsFromBase_24(base.GetCppThis(), type);
		}

		// Token: 0x0600BD94 RID: 48532
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCheckerboardSplatter_GetNumberOfGenerationsFromBaseType_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BD95 RID: 48533 RVA: 0x00108A78 File Offset: 0x00106C78
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetNumberOfGenerationsFromBaseType_25(type);
		}

		// Token: 0x0600BD96 RID: 48534
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCheckerboardSplatter_GetOutputScalarType_26(HandleRef pThis);

		/// <summary>
		/// Set what type of scalar data this source should generate. Only double
		/// and float types are supported currently due to precision requirements
		/// during accumulation. By default, float scalars are produced.
		/// </summary>
		// Token: 0x0600BD97 RID: 48535 RVA: 0x00108A94 File Offset: 0x00106C94
		public virtual int GetOutputScalarType()
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetOutputScalarType_26(base.GetCppThis());
		}

		// Token: 0x0600BD98 RID: 48536
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCheckerboardSplatter_GetParallelSplatCrossover_27(HandleRef pThis);

		/// <summary>
		/// Set/get the crossover point expressed in footprint size where the
		/// splatting operation is parallelized (through vtkSMPTools). By default
		/// the parallel crossover point is for splat footprints of size two or
		/// greater (i.e., at footprint=2 then splat is 5x5x5 and parallel splatting
		/// occurs). This is really meant for experimental purposes.
		/// </summary>
		// Token: 0x0600BD99 RID: 48537 RVA: 0x00108AB4 File Offset: 0x00106CB4
		public virtual int GetParallelSplatCrossover()
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetParallelSplatCrossover_27(base.GetCppThis());
		}

		// Token: 0x0600BD9A RID: 48538
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCheckerboardSplatter_GetParallelSplatCrossoverMaxValue_28(HandleRef pThis);

		/// <summary>
		/// Set/get the crossover point expressed in footprint size where the
		/// splatting operation is parallelized (through vtkSMPTools). By default
		/// the parallel crossover point is for splat footprints of size two or
		/// greater (i.e., at footprint=2 then splat is 5x5x5 and parallel splatting
		/// occurs). This is really meant for experimental purposes.
		/// </summary>
		// Token: 0x0600BD9B RID: 48539 RVA: 0x00108AD4 File Offset: 0x00106CD4
		public virtual int GetParallelSplatCrossoverMaxValue()
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetParallelSplatCrossoverMaxValue_28(base.GetCppThis());
		}

		// Token: 0x0600BD9C RID: 48540
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCheckerboardSplatter_GetParallelSplatCrossoverMinValue_29(HandleRef pThis);

		/// <summary>
		/// Set/get the crossover point expressed in footprint size where the
		/// splatting operation is parallelized (through vtkSMPTools). By default
		/// the parallel crossover point is for splat footprints of size two or
		/// greater (i.e., at footprint=2 then splat is 5x5x5 and parallel splatting
		/// occurs). This is really meant for experimental purposes.
		/// </summary>
		// Token: 0x0600BD9D RID: 48541 RVA: 0x00108AF4 File Offset: 0x00106CF4
		public virtual int GetParallelSplatCrossoverMinValue()
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetParallelSplatCrossoverMinValue_29(base.GetCppThis());
		}

		// Token: 0x0600BD9E RID: 48542
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCheckerboardSplatter_GetRadius_30(HandleRef pThis);

		/// <summary>
		/// Set / get the radius variable that controls the Gaussian exponential
		/// function (see equation above). If set to zero, it is automatically set
		/// to the radius of the circumsphere bounding a single voxel. (By default,
		/// the Radius is set to zero and is automatically computed.)
		/// </summary>
		// Token: 0x0600BD9F RID: 48543 RVA: 0x00108B14 File Offset: 0x00106D14
		public virtual double GetRadius()
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetRadius_30(base.GetCppThis());
		}

		// Token: 0x0600BDA0 RID: 48544
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCheckerboardSplatter_GetRadiusMaxValue_31(HandleRef pThis);

		/// <summary>
		/// Set / get the radius variable that controls the Gaussian exponential
		/// function (see equation above). If set to zero, it is automatically set
		/// to the radius of the circumsphere bounding a single voxel. (By default,
		/// the Radius is set to zero and is automatically computed.)
		/// </summary>
		// Token: 0x0600BDA1 RID: 48545 RVA: 0x00108B34 File Offset: 0x00106D34
		public virtual double GetRadiusMaxValue()
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetRadiusMaxValue_31(base.GetCppThis());
		}

		// Token: 0x0600BDA2 RID: 48546
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCheckerboardSplatter_GetRadiusMinValue_32(HandleRef pThis);

		/// <summary>
		/// Set / get the radius variable that controls the Gaussian exponential
		/// function (see equation above). If set to zero, it is automatically set
		/// to the radius of the circumsphere bounding a single voxel. (By default,
		/// the Radius is set to zero and is automatically computed.)
		/// </summary>
		// Token: 0x0600BDA3 RID: 48547 RVA: 0x00108B54 File Offset: 0x00106D54
		public virtual double GetRadiusMinValue()
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetRadiusMinValue_32(base.GetCppThis());
		}

		// Token: 0x0600BDA4 RID: 48548
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCheckerboardSplatter_GetSampleDimensions_33(HandleRef pThis);

		/// <summary>
		/// Set / get the dimensions of the sampling structured point set. Higher
		/// values produce better results but may be much slower.
		/// </summary>
		// Token: 0x0600BDA5 RID: 48549 RVA: 0x00108B74 File Offset: 0x00106D74
		public virtual int[] GetSampleDimensions()
		{
			IntPtr intPtr = vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetSampleDimensions_33(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600BDA6 RID: 48550
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_GetSampleDimensions_34(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set / get the dimensions of the sampling structured point set. Higher
		/// values produce better results but may be much slower.
		/// </summary>
		// Token: 0x0600BDA7 RID: 48551 RVA: 0x00108BBC File Offset: 0x00106DBC
		public virtual void GetSampleDimensions(IntPtr data)
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetSampleDimensions_34(base.GetCppThis(), data);
		}

		// Token: 0x0600BDA8 RID: 48552
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCheckerboardSplatter_GetScalarWarping_35(HandleRef pThis);

		/// <summary>
		/// Turn on/off the scaling of splats by scalar value.
		/// </summary>
		// Token: 0x0600BDA9 RID: 48553 RVA: 0x00108BCC File Offset: 0x00106DCC
		public virtual int GetScalarWarping()
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetScalarWarping_35(base.GetCppThis());
		}

		// Token: 0x0600BDAA RID: 48554
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCheckerboardSplatter_GetScaleFactor_36(HandleRef pThis);

		/// <summary>
		/// Multiply Gaussian splat distribution by this value. If ScalarWarping
		/// is on, then the Scalar value will be multiplied by the ScaleFactor
		/// times the Gaussian function.
		/// </summary>
		// Token: 0x0600BDAB RID: 48555 RVA: 0x00108BEC File Offset: 0x00106DEC
		public virtual double GetScaleFactor()
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetScaleFactor_36(base.GetCppThis());
		}

		// Token: 0x0600BDAC RID: 48556
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCheckerboardSplatter_GetScaleFactorMaxValue_37(HandleRef pThis);

		/// <summary>
		/// Multiply Gaussian splat distribution by this value. If ScalarWarping
		/// is on, then the Scalar value will be multiplied by the ScaleFactor
		/// times the Gaussian function.
		/// </summary>
		// Token: 0x0600BDAD RID: 48557 RVA: 0x00108C0C File Offset: 0x00106E0C
		public virtual double GetScaleFactorMaxValue()
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetScaleFactorMaxValue_37(base.GetCppThis());
		}

		// Token: 0x0600BDAE RID: 48558
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCheckerboardSplatter_GetScaleFactorMinValue_38(HandleRef pThis);

		/// <summary>
		/// Multiply Gaussian splat distribution by this value. If ScalarWarping
		/// is on, then the Scalar value will be multiplied by the ScaleFactor
		/// times the Gaussian function.
		/// </summary>
		// Token: 0x0600BDAF RID: 48559 RVA: 0x00108C2C File Offset: 0x00106E2C
		public virtual double GetScaleFactorMinValue()
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_GetScaleFactorMinValue_38(base.GetCppThis());
		}

		// Token: 0x0600BDB0 RID: 48560
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCheckerboardSplatter_IsA_39(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BDB1 RID: 48561 RVA: 0x00108C4C File Offset: 0x00106E4C
		public override int IsA(string type)
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_IsA_39(base.GetCppThis(), type);
		}

		// Token: 0x0600BDB2 RID: 48562
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCheckerboardSplatter_IsTypeOf_40([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BDB3 RID: 48563 RVA: 0x00108C6C File Offset: 0x00106E6C
		public new static int IsTypeOf(string type)
		{
			return vtkCheckerboardSplatter.vtkCheckerboardSplatter_IsTypeOf_40(type);
		}

		// Token: 0x0600BDB4 RID: 48564
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCheckerboardSplatter_NewInstance_42(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BDB5 RID: 48565 RVA: 0x00108C88 File Offset: 0x00106E88
		public new vtkCheckerboardSplatter NewInstance()
		{
			vtkCheckerboardSplatter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCheckerboardSplatter.vtkCheckerboardSplatter_NewInstance_42(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCheckerboardSplatter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600BDB6 RID: 48566
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_NormalWarpingOff_43(HandleRef pThis);

		/// <summary>
		/// Turn on/off the generation of elliptical splats. If normal warping is
		/// on, then the input normals affect the distribution of the splat. This
		/// boolean is used in combination with the Eccentricity ivar.
		/// </summary>
		// Token: 0x0600BDB7 RID: 48567 RVA: 0x00108CE2 File Offset: 0x00106EE2
		public virtual void NormalWarpingOff()
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_NormalWarpingOff_43(base.GetCppThis());
		}

		// Token: 0x0600BDB8 RID: 48568
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_NormalWarpingOn_44(HandleRef pThis);

		/// <summary>
		/// Turn on/off the generation of elliptical splats. If normal warping is
		/// on, then the input normals affect the distribution of the splat. This
		/// boolean is used in combination with the Eccentricity ivar.
		/// </summary>
		// Token: 0x0600BDB9 RID: 48569 RVA: 0x00108CF1 File Offset: 0x00106EF1
		public virtual void NormalWarpingOn()
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_NormalWarpingOn_44(base.GetCppThis());
		}

		// Token: 0x0600BDBA RID: 48570
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCheckerboardSplatter_SafeDownCast_45(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BDBB RID: 48571 RVA: 0x00108D00 File Offset: 0x00106F00
		public new static vtkCheckerboardSplatter SafeDownCast(vtkObjectBase o)
		{
			vtkCheckerboardSplatter vtkCheckerboardSplatter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCheckerboardSplatter.vtkCheckerboardSplatter_SafeDownCast_45((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCheckerboardSplatter = (vtkCheckerboardSplatter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCheckerboardSplatter.Register(null);
				}
			}
			return vtkCheckerboardSplatter;
		}

		// Token: 0x0600BDBC RID: 48572
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_ScalarWarpingOff_46(HandleRef pThis);

		/// <summary>
		/// Turn on/off the scaling of splats by scalar value.
		/// </summary>
		// Token: 0x0600BDBD RID: 48573 RVA: 0x00108D7F File Offset: 0x00106F7F
		public virtual void ScalarWarpingOff()
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_ScalarWarpingOff_46(base.GetCppThis());
		}

		// Token: 0x0600BDBE RID: 48574
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_ScalarWarpingOn_47(HandleRef pThis);

		/// <summary>
		/// Turn on/off the scaling of splats by scalar value.
		/// </summary>
		// Token: 0x0600BDBF RID: 48575 RVA: 0x00108D8E File Offset: 0x00106F8E
		public virtual void ScalarWarpingOn()
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_ScalarWarpingOn_47(base.GetCppThis());
		}

		// Token: 0x0600BDC0 RID: 48576
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_SetAccumulationMode_48(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the scalar accumulation mode. This mode expresses how scalar
		/// values are combined when splats overlap one another. The Max mode acts
		/// like a set union operation and is the most commonly used; the Min mode
		/// acts like a set intersection, and the sum is just weird (and can
		/// potentially cause accumulation overflow in extreme cases). Note that the
		/// NullValue must be set consistent with the accumulation operation.
		/// </summary>
		// Token: 0x0600BDC1 RID: 48577 RVA: 0x00108D9D File Offset: 0x00106F9D
		public virtual void SetAccumulationMode(int _arg)
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_SetAccumulationMode_48(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BDC2 RID: 48578
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_SetAccumulationModeToMax_49(HandleRef pThis);

		/// <summary>
		/// Specify the scalar accumulation mode. This mode expresses how scalar
		/// values are combined when splats overlap one another. The Max mode acts
		/// like a set union operation and is the most commonly used; the Min mode
		/// acts like a set intersection, and the sum is just weird (and can
		/// potentially cause accumulation overflow in extreme cases). Note that the
		/// NullValue must be set consistent with the accumulation operation.
		/// </summary>
		// Token: 0x0600BDC3 RID: 48579 RVA: 0x00108DAD File Offset: 0x00106FAD
		public void SetAccumulationModeToMax()
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_SetAccumulationModeToMax_49(base.GetCppThis());
		}

		// Token: 0x0600BDC4 RID: 48580
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_SetAccumulationModeToMin_50(HandleRef pThis);

		/// <summary>
		/// Specify the scalar accumulation mode. This mode expresses how scalar
		/// values are combined when splats overlap one another. The Max mode acts
		/// like a set union operation and is the most commonly used; the Min mode
		/// acts like a set intersection, and the sum is just weird (and can
		/// potentially cause accumulation overflow in extreme cases). Note that the
		/// NullValue must be set consistent with the accumulation operation.
		/// </summary>
		// Token: 0x0600BDC5 RID: 48581 RVA: 0x00108DBC File Offset: 0x00106FBC
		public void SetAccumulationModeToMin()
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_SetAccumulationModeToMin_50(base.GetCppThis());
		}

		// Token: 0x0600BDC6 RID: 48582
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_SetAccumulationModeToSum_51(HandleRef pThis);

		/// <summary>
		/// Specify the scalar accumulation mode. This mode expresses how scalar
		/// values are combined when splats overlap one another. The Max mode acts
		/// like a set union operation and is the most commonly used; the Min mode
		/// acts like a set intersection, and the sum is just weird (and can
		/// potentially cause accumulation overflow in extreme cases). Note that the
		/// NullValue must be set consistent with the accumulation operation.
		/// </summary>
		// Token: 0x0600BDC7 RID: 48583 RVA: 0x00108DCB File Offset: 0x00106FCB
		public void SetAccumulationModeToSum()
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_SetAccumulationModeToSum_51(base.GetCppThis());
		}

		// Token: 0x0600BDC8 RID: 48584
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_SetCapValue_52(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the cap value to use. (This instance variable only has effect
		/// if the ivar Capping is on.)
		/// </summary>
		// Token: 0x0600BDC9 RID: 48585 RVA: 0x00108DDA File Offset: 0x00106FDA
		public virtual void SetCapValue(double _arg)
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_SetCapValue_52(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BDCA RID: 48586
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_SetCapping_53(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the capping of the outer boundary of the volume
		/// to a specified cap value. This can be used to close surfaces
		/// (after iso-surfacing) and create other effects.
		/// </summary>
		// Token: 0x0600BDCB RID: 48587 RVA: 0x00108DEA File Offset: 0x00106FEA
		public virtual void SetCapping(int _arg)
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_SetCapping_53(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BDCC RID: 48588
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_SetEccentricity_54(HandleRef pThis, double _arg);

		/// <summary>
		/// Control the shape of elliptical splatting. Eccentricity is the ratio
		/// of the major axis (aligned along normal) to the minor (axes) aligned
		/// along other two axes. So Eccentricity &gt; 1 creates needles with the
		/// long axis in the direction of the normal; Eccentricity&lt;1 creates
		/// pancakes perpendicular to the normal vector.
		/// </summary>
		// Token: 0x0600BDCD RID: 48589 RVA: 0x00108DFA File Offset: 0x00106FFA
		public virtual void SetEccentricity(double _arg)
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_SetEccentricity_54(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BDCE RID: 48590
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_SetExponentFactor_55(HandleRef pThis, double _arg);

		/// <summary>
		/// Set / get the sharpness of decay of the splats. This is the exponent
		/// constant in the Gaussian equation described above. Normally this is a
		/// negative value.
		/// </summary>
		// Token: 0x0600BDCF RID: 48591 RVA: 0x00108E0A File Offset: 0x0010700A
		public virtual void SetExponentFactor(double _arg)
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_SetExponentFactor_55(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BDD0 RID: 48592
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_SetFootprint_56(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the footprint size of the splat in terms of propagation across a
		/// voxel neighborhood. The Footprint value simply indicates the number of
		/// neighboring voxels in the i-j-k directions to extend the splat. A value
		/// of zero means that only the voxel containing the splat point is
		/// affected. A value of one means the immediate neighbors touching the
		/// affected voxel are affected as well. Larger numbers increase the splat
		/// footprint and significantly increase processing time. Note that the
		/// footprint is always 3D rectangular.
		/// </summary>
		// Token: 0x0600BDD1 RID: 48593 RVA: 0x00108E1A File Offset: 0x0010701A
		public virtual void SetFootprint(int _arg)
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_SetFootprint_56(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BDD2 RID: 48594
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_SetMaximumDimension_57(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the maximum dimension of the checkerboard (i.e., the number of
		/// squares in any of the i, j, or k directions). This number also impacts
		/// the granularity of the parallel threading (since each checker square is
		/// processed separaely). Because of the internal addressing, the maximum
		/// dimension is limited to 255 (maximum value of an unsigned char).
		/// </summary>
		// Token: 0x0600BDD3 RID: 48595 RVA: 0x00108E2A File Offset: 0x0010702A
		public virtual void SetMaximumDimension(int _arg)
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_SetMaximumDimension_57(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BDD4 RID: 48596
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_SetModelBounds_58(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
		/// the sampling is performed. If any of the (min,max) bounds values are
		/// min &gt;= max, then the bounds will be computed automatically from the input
		/// data. Otherwise, the user-specified bounds will be used.
		/// </summary>
		// Token: 0x0600BDD5 RID: 48597 RVA: 0x00108E3A File Offset: 0x0010703A
		public virtual void SetModelBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_SetModelBounds_58(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x0600BDD6 RID: 48598
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_SetModelBounds_59(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
		/// the sampling is performed. If any of the (min,max) bounds values are
		/// min &gt;= max, then the bounds will be computed automatically from the input
		/// data. Otherwise, the user-specified bounds will be used.
		/// </summary>
		// Token: 0x0600BDD7 RID: 48599 RVA: 0x00108E52 File Offset: 0x00107052
		public virtual void SetModelBounds(IntPtr _arg)
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_SetModelBounds_59(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BDD8 RID: 48600
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_SetNormalWarping_60(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the generation of elliptical splats. If normal warping is
		/// on, then the input normals affect the distribution of the splat. This
		/// boolean is used in combination with the Eccentricity ivar.
		/// </summary>
		// Token: 0x0600BDD9 RID: 48601 RVA: 0x00108E62 File Offset: 0x00107062
		public virtual void SetNormalWarping(int _arg)
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_SetNormalWarping_60(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BDDA RID: 48602
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_SetNullValue_61(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the Null value for output points not receiving a contribution from
		/// the input points. (This is the initial value of the voxel samples, by
		/// default it is set to zero.) Note that the value should be consistent
		/// with the output dataset type. The NullValue also provides the initial
		/// value on which the accumulations process operates.
		/// </summary>
		// Token: 0x0600BDDB RID: 48603 RVA: 0x00108E72 File Offset: 0x00107072
		public virtual void SetNullValue(double _arg)
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_SetNullValue_61(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BDDC RID: 48604
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_SetOutputScalarType_62(HandleRef pThis, int _arg);

		/// <summary>
		/// Set what type of scalar data this source should generate. Only double
		/// and float types are supported currently due to precision requirements
		/// during accumulation. By default, float scalars are produced.
		/// </summary>
		// Token: 0x0600BDDD RID: 48605 RVA: 0x00108E82 File Offset: 0x00107082
		public virtual void SetOutputScalarType(int _arg)
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_SetOutputScalarType_62(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BDDE RID: 48606
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_SetOutputScalarTypeToDouble_63(HandleRef pThis);

		/// <summary>
		/// Set what type of scalar data this source should generate. Only double
		/// and float types are supported currently due to precision requirements
		/// during accumulation. By default, float scalars are produced.
		/// </summary>
		// Token: 0x0600BDDF RID: 48607 RVA: 0x00108E92 File Offset: 0x00107092
		public void SetOutputScalarTypeToDouble()
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_SetOutputScalarTypeToDouble_63(base.GetCppThis());
		}

		// Token: 0x0600BDE0 RID: 48608
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_SetOutputScalarTypeToFloat_64(HandleRef pThis);

		/// <summary>
		/// Set what type of scalar data this source should generate. Only double
		/// and float types are supported currently due to precision requirements
		/// during accumulation. By default, float scalars are produced.
		/// </summary>
		// Token: 0x0600BDE1 RID: 48609 RVA: 0x00108EA1 File Offset: 0x001070A1
		public void SetOutputScalarTypeToFloat()
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_SetOutputScalarTypeToFloat_64(base.GetCppThis());
		}

		// Token: 0x0600BDE2 RID: 48610
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_SetParallelSplatCrossover_65(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the crossover point expressed in footprint size where the
		/// splatting operation is parallelized (through vtkSMPTools). By default
		/// the parallel crossover point is for splat footprints of size two or
		/// greater (i.e., at footprint=2 then splat is 5x5x5 and parallel splatting
		/// occurs). This is really meant for experimental purposes.
		/// </summary>
		// Token: 0x0600BDE3 RID: 48611 RVA: 0x00108EB0 File Offset: 0x001070B0
		public virtual void SetParallelSplatCrossover(int _arg)
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_SetParallelSplatCrossover_65(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BDE4 RID: 48612
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_SetRadius_66(HandleRef pThis, double _arg);

		/// <summary>
		/// Set / get the radius variable that controls the Gaussian exponential
		/// function (see equation above). If set to zero, it is automatically set
		/// to the radius of the circumsphere bounding a single voxel. (By default,
		/// the Radius is set to zero and is automatically computed.)
		/// </summary>
		// Token: 0x0600BDE5 RID: 48613 RVA: 0x00108EC0 File Offset: 0x001070C0
		public virtual void SetRadius(double _arg)
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_SetRadius_66(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BDE6 RID: 48614
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_SetSampleDimensions_67(HandleRef pThis, int i, int j, int k);

		/// <summary>
		/// Set / get the dimensions of the sampling structured point set. Higher
		/// values produce better results but may be much slower.
		/// </summary>
		// Token: 0x0600BDE7 RID: 48615 RVA: 0x00108ED0 File Offset: 0x001070D0
		public void SetSampleDimensions(int i, int j, int k)
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_SetSampleDimensions_67(base.GetCppThis(), i, j, k);
		}

		// Token: 0x0600BDE8 RID: 48616
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_SetSampleDimensions_68(HandleRef pThis, IntPtr dim);

		/// <summary>
		/// Set / get the dimensions of the sampling structured point set. Higher
		/// values produce better results but may be much slower.
		/// </summary>
		// Token: 0x0600BDE9 RID: 48617 RVA: 0x00108EE2 File Offset: 0x001070E2
		public void SetSampleDimensions(IntPtr dim)
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_SetSampleDimensions_68(base.GetCppThis(), dim);
		}

		// Token: 0x0600BDEA RID: 48618
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_SetScalarWarping_69(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the scaling of splats by scalar value.
		/// </summary>
		// Token: 0x0600BDEB RID: 48619 RVA: 0x00108EF2 File Offset: 0x001070F2
		public virtual void SetScalarWarping(int _arg)
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_SetScalarWarping_69(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BDEC RID: 48620
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCheckerboardSplatter_SetScaleFactor_70(HandleRef pThis, double _arg);

		/// <summary>
		/// Multiply Gaussian splat distribution by this value. If ScalarWarping
		/// is on, then the Scalar value will be multiplied by the ScaleFactor
		/// times the Gaussian function.
		/// </summary>
		// Token: 0x0600BDED RID: 48621 RVA: 0x00108F02 File Offset: 0x00107102
		public virtual void SetScaleFactor(double _arg)
		{
			vtkCheckerboardSplatter.vtkCheckerboardSplatter_SetScaleFactor_70(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E26 RID: 3622
		public new const string MRFullTypeName = "Kitware.VTK.vtkCheckerboardSplatter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E27 RID: 3623
		public new static readonly string MRClassNameKey = "class vtkCheckerboardSplatter";
	}
}
