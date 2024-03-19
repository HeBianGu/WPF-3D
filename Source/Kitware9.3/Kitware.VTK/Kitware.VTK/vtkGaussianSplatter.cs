using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGaussianSplatter
	/// </summary>
	/// <remarks>
	///    splat points into a volume with an elliptical, Gaussian distribution
	///
	/// vtkGaussianSplatter is a filter that injects input points into a
	/// structured points (volume) dataset. As each point is injected, it "splats"
	/// or distributes values to nearby voxels. Data is distributed using an
	/// elliptical, Gaussian distribution function. The distribution function is
	/// modified using scalar values (expands distribution) or normals
	/// (creates ellipsoidal distribution rather than spherical).
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
	/// If points normals are present (and NormalWarping is on), then the splat
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
	/// @warning
	/// The input to this filter is any dataset type. This filter can be used
	/// to resample any form of data, i.e., the input data need not be
	/// unstructured.
	///
	/// @warning
	/// Some voxels may never receive a contribution during the splatting process.
	/// The final value of these points can be specified with the "NullValue"
	/// instance variable.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkShepardMethod vtkCheckerboardSplatter
	/// </seealso>
	// Token: 0x020003E1 RID: 993
	public class vtkGaussianSplatter : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600BE2A RID: 48682 RVA: 0x0010936B File Offset: 0x0010756B
		static vtkGaussianSplatter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGaussianSplatter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGaussianSplatter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600BE2B RID: 48683 RVA: 0x00109393 File Offset: 0x00107593
		public vtkGaussianSplatter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600BE2C RID: 48684
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGaussianSplatter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with dimensions=(50,50,50); automatic computation of
		/// bounds; a splat radius of 0.1; an exponent factor of -5; and normal and
		/// scalar warping turned on.
		/// </summary>
		// Token: 0x0600BE2D RID: 48685 RVA: 0x001093A4 File Offset: 0x001075A4
		public new static vtkGaussianSplatter New()
		{
			vtkGaussianSplatter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGaussianSplatter.vtkGaussianSplatter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGaussianSplatter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with dimensions=(50,50,50); automatic computation of
		/// bounds; a splat radius of 0.1; an exponent factor of -5; and normal and
		/// scalar warping turned on.
		/// </summary>
		// Token: 0x0600BE2E RID: 48686 RVA: 0x001093F8 File Offset: 0x001075F8
		public vtkGaussianSplatter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGaussianSplatter.vtkGaussianSplatter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600BE2F RID: 48687 RVA: 0x0010943C File Offset: 0x0010763C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600BE30 RID: 48688
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianSplatter_CappingOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off the capping of the outer boundary of the volume
		/// to a specified cap value. This can be used to close surfaces
		/// (after iso-surfacing) and create other effects.
		/// </summary>
		// Token: 0x0600BE31 RID: 48689 RVA: 0x00109447 File Offset: 0x00107647
		public virtual void CappingOff()
		{
			vtkGaussianSplatter.vtkGaussianSplatter_CappingOff_01(base.GetCppThis());
		}

		// Token: 0x0600BE32 RID: 48690
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianSplatter_CappingOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off the capping of the outer boundary of the volume
		/// to a specified cap value. This can be used to close surfaces
		/// (after iso-surfacing) and create other effects.
		/// </summary>
		// Token: 0x0600BE33 RID: 48691 RVA: 0x00109456 File Offset: 0x00107656
		public virtual void CappingOn()
		{
			vtkGaussianSplatter.vtkGaussianSplatter_CappingOn_02(base.GetCppThis());
		}

		// Token: 0x0600BE34 RID: 48692
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianSplatter_ComputeModelBounds_03(HandleRef pThis, HandleRef input, HandleRef output, HandleRef outInfo);

		/// <summary>
		/// Compute the size of the sample bounding box automatically from the
		/// input data. This is an internal helper function.
		/// </summary>
		// Token: 0x0600BE35 RID: 48693 RVA: 0x00109468 File Offset: 0x00107668
		public void ComputeModelBounds(vtkDataSet input, vtkImageData output, vtkInformation outInfo)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_ComputeModelBounds_03(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis(), (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis());
		}

		// Token: 0x0600BE36 RID: 48694
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianSplatter_ComputeModelBounds_04(HandleRef pThis, HandleRef input, HandleRef output, HandleRef outInfo);

		/// <summary>
		/// Compute the size of the sample bounding box automatically from the
		/// input data. This is an internal helper function.
		/// </summary>
		// Token: 0x0600BE37 RID: 48695 RVA: 0x001094C4 File Offset: 0x001076C4
		public void ComputeModelBounds(vtkCompositeDataSet input, vtkImageData output, vtkInformation outInfo)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_ComputeModelBounds_04(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis(), (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis());
		}

		// Token: 0x0600BE38 RID: 48696
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGaussianSplatter_GetAccumulationMode_05(HandleRef pThis);

		/// <summary>
		/// Specify the scalar accumulation mode. This mode expresses how scalar
		/// values are combined when splats are overlapped. The Max mode acts
		/// like a set union operation and is the most commonly used; the Min
		/// mode acts like a set intersection, and the sum is just weird.
		/// </summary>
		// Token: 0x0600BE39 RID: 48697 RVA: 0x00109520 File Offset: 0x00107720
		public virtual int GetAccumulationMode()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetAccumulationMode_05(base.GetCppThis());
		}

		// Token: 0x0600BE3A RID: 48698
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGaussianSplatter_GetAccumulationModeAsString_06(HandleRef pThis);

		/// <summary>
		/// Specify the scalar accumulation mode. This mode expresses how scalar
		/// values are combined when splats are overlapped. The Max mode acts
		/// like a set union operation and is the most commonly used; the Min
		/// mode acts like a set intersection, and the sum is just weird.
		/// </summary>
		// Token: 0x0600BE3B RID: 48699 RVA: 0x00109540 File Offset: 0x00107740
		public string GetAccumulationModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkGaussianSplatter.vtkGaussianSplatter_GetAccumulationModeAsString_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600BE3C RID: 48700
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGaussianSplatter_GetAccumulationModeMaxValue_07(HandleRef pThis);

		/// <summary>
		/// Specify the scalar accumulation mode. This mode expresses how scalar
		/// values are combined when splats are overlapped. The Max mode acts
		/// like a set union operation and is the most commonly used; the Min
		/// mode acts like a set intersection, and the sum is just weird.
		/// </summary>
		// Token: 0x0600BE3D RID: 48701 RVA: 0x0010957C File Offset: 0x0010777C
		public virtual int GetAccumulationModeMaxValue()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetAccumulationModeMaxValue_07(base.GetCppThis());
		}

		// Token: 0x0600BE3E RID: 48702
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGaussianSplatter_GetAccumulationModeMinValue_08(HandleRef pThis);

		/// <summary>
		/// Specify the scalar accumulation mode. This mode expresses how scalar
		/// values are combined when splats are overlapped. The Max mode acts
		/// like a set union operation and is the most commonly used; the Min
		/// mode acts like a set intersection, and the sum is just weird.
		/// </summary>
		// Token: 0x0600BE3F RID: 48703 RVA: 0x0010959C File Offset: 0x0010779C
		public virtual int GetAccumulationModeMinValue()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetAccumulationModeMinValue_08(base.GetCppThis());
		}

		// Token: 0x0600BE40 RID: 48704
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGaussianSplatter_GetCapValue_09(HandleRef pThis);

		/// <summary>
		/// Specify the cap value to use. (This instance variable only has effect
		/// if the ivar Capping is on.)
		/// </summary>
		// Token: 0x0600BE41 RID: 48705 RVA: 0x001095BC File Offset: 0x001077BC
		public virtual double GetCapValue()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetCapValue_09(base.GetCppThis());
		}

		// Token: 0x0600BE42 RID: 48706
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGaussianSplatter_GetCapping_10(HandleRef pThis);

		/// <summary>
		/// Turn on/off the capping of the outer boundary of the volume
		/// to a specified cap value. This can be used to close surfaces
		/// (after iso-surfacing) and create other effects.
		/// </summary>
		// Token: 0x0600BE43 RID: 48707 RVA: 0x001095DC File Offset: 0x001077DC
		public virtual int GetCapping()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetCapping_10(base.GetCppThis());
		}

		// Token: 0x0600BE44 RID: 48708
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGaussianSplatter_GetEccentricity_11(HandleRef pThis);

		/// <summary>
		/// Control the shape of elliptical splatting. Eccentricity is the ratio
		/// of the major axis (aligned along normal) to the minor (axes) aligned
		/// along other two axes. So Eccentricity &gt; 1 creates needles with the
		/// long axis in the direction of the normal; Eccentricity&lt;1 creates
		/// pancakes perpendicular to the normal vector.
		/// </summary>
		// Token: 0x0600BE45 RID: 48709 RVA: 0x001095FC File Offset: 0x001077FC
		public virtual double GetEccentricity()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetEccentricity_11(base.GetCppThis());
		}

		// Token: 0x0600BE46 RID: 48710
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGaussianSplatter_GetEccentricityMaxValue_12(HandleRef pThis);

		/// <summary>
		/// Control the shape of elliptical splatting. Eccentricity is the ratio
		/// of the major axis (aligned along normal) to the minor (axes) aligned
		/// along other two axes. So Eccentricity &gt; 1 creates needles with the
		/// long axis in the direction of the normal; Eccentricity&lt;1 creates
		/// pancakes perpendicular to the normal vector.
		/// </summary>
		// Token: 0x0600BE47 RID: 48711 RVA: 0x0010961C File Offset: 0x0010781C
		public virtual double GetEccentricityMaxValue()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetEccentricityMaxValue_12(base.GetCppThis());
		}

		// Token: 0x0600BE48 RID: 48712
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGaussianSplatter_GetEccentricityMinValue_13(HandleRef pThis);

		/// <summary>
		/// Control the shape of elliptical splatting. Eccentricity is the ratio
		/// of the major axis (aligned along normal) to the minor (axes) aligned
		/// along other two axes. So Eccentricity &gt; 1 creates needles with the
		/// long axis in the direction of the normal; Eccentricity&lt;1 creates
		/// pancakes perpendicular to the normal vector.
		/// </summary>
		// Token: 0x0600BE49 RID: 48713 RVA: 0x0010963C File Offset: 0x0010783C
		public virtual double GetEccentricityMinValue()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetEccentricityMinValue_13(base.GetCppThis());
		}

		// Token: 0x0600BE4A RID: 48714
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGaussianSplatter_GetExponentFactor_14(HandleRef pThis);

		/// <summary>
		/// Set / get the sharpness of decay of the splats. This is the
		/// exponent constant in the Gaussian equation. Normally this is
		/// a negative value.
		/// </summary>
		// Token: 0x0600BE4B RID: 48715 RVA: 0x0010965C File Offset: 0x0010785C
		public virtual double GetExponentFactor()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetExponentFactor_14(base.GetCppThis());
		}

		// Token: 0x0600BE4C RID: 48716
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGaussianSplatter_GetModelBounds_15(HandleRef pThis);

		/// <summary>
		/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
		/// the sampling is performed. If any of the (min,max) bounds values are
		/// min &gt;= max, then the bounds will be computed automatically from the input
		/// data. Otherwise, the user-specified bounds will be used.
		/// </summary>
		// Token: 0x0600BE4D RID: 48717 RVA: 0x0010967C File Offset: 0x0010787C
		public virtual double[] GetModelBounds()
		{
			IntPtr intPtr = vtkGaussianSplatter.vtkGaussianSplatter_GetModelBounds_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600BE4E RID: 48718
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianSplatter_GetModelBounds_16(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
		/// the sampling is performed. If any of the (min,max) bounds values are
		/// min &gt;= max, then the bounds will be computed automatically from the input
		/// data. Otherwise, the user-specified bounds will be used.
		/// </summary>
		// Token: 0x0600BE4F RID: 48719 RVA: 0x001096C4 File Offset: 0x001078C4
		public virtual void GetModelBounds(IntPtr data)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_GetModelBounds_16(base.GetCppThis(), data);
		}

		// Token: 0x0600BE50 RID: 48720
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGaussianSplatter_GetNormalWarping_17(HandleRef pThis);

		/// <summary>
		/// Turn on/off the generation of elliptical splats. If normal warping is
		/// on, then the input normals affect the distribution of the splat. This
		/// boolean is used in combination with the Eccentricity ivar.
		/// </summary>
		// Token: 0x0600BE51 RID: 48721 RVA: 0x001096D4 File Offset: 0x001078D4
		public virtual int GetNormalWarping()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetNormalWarping_17(base.GetCppThis());
		}

		// Token: 0x0600BE52 RID: 48722
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGaussianSplatter_GetNullValue_18(HandleRef pThis);

		/// <summary>
		/// Set the Null value for output points not receiving a contribution from the
		/// input points. (This is the initial value of the voxel samples.)
		/// </summary>
		// Token: 0x0600BE53 RID: 48723 RVA: 0x001096F4 File Offset: 0x001078F4
		public virtual double GetNullValue()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetNullValue_18(base.GetCppThis());
		}

		// Token: 0x0600BE54 RID: 48724
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGaussianSplatter_GetNumberOfGenerationsFromBase_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BE55 RID: 48725 RVA: 0x00109714 File Offset: 0x00107914
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetNumberOfGenerationsFromBase_19(base.GetCppThis(), type);
		}

		// Token: 0x0600BE56 RID: 48726
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGaussianSplatter_GetNumberOfGenerationsFromBaseType_20([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BE57 RID: 48727 RVA: 0x00109734 File Offset: 0x00107934
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetNumberOfGenerationsFromBaseType_20(type);
		}

		// Token: 0x0600BE58 RID: 48728
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGaussianSplatter_GetRadius_21(HandleRef pThis);

		/// <summary>
		/// Set / get the radius of propagation of the splat. This value is expressed
		/// as a percentage of the length of the longest side of the sampling
		/// volume. Smaller numbers greatly reduce execution time.
		/// </summary>
		// Token: 0x0600BE59 RID: 48729 RVA: 0x00109750 File Offset: 0x00107950
		public virtual double GetRadius()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetRadius_21(base.GetCppThis());
		}

		// Token: 0x0600BE5A RID: 48730
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGaussianSplatter_GetRadiusMaxValue_22(HandleRef pThis);

		/// <summary>
		/// Set / get the radius of propagation of the splat. This value is expressed
		/// as a percentage of the length of the longest side of the sampling
		/// volume. Smaller numbers greatly reduce execution time.
		/// </summary>
		// Token: 0x0600BE5B RID: 48731 RVA: 0x00109770 File Offset: 0x00107970
		public virtual double GetRadiusMaxValue()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetRadiusMaxValue_22(base.GetCppThis());
		}

		// Token: 0x0600BE5C RID: 48732
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGaussianSplatter_GetRadiusMinValue_23(HandleRef pThis);

		/// <summary>
		/// Set / get the radius of propagation of the splat. This value is expressed
		/// as a percentage of the length of the longest side of the sampling
		/// volume. Smaller numbers greatly reduce execution time.
		/// </summary>
		// Token: 0x0600BE5D RID: 48733 RVA: 0x00109790 File Offset: 0x00107990
		public virtual double GetRadiusMinValue()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetRadiusMinValue_23(base.GetCppThis());
		}

		// Token: 0x0600BE5E RID: 48734
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGaussianSplatter_GetSampleDimensions_24(HandleRef pThis);

		/// <summary>
		/// Set / get the dimensions of the sampling structured point set. Higher
		/// values produce better results but are much slower.
		/// </summary>
		// Token: 0x0600BE5F RID: 48735 RVA: 0x001097B0 File Offset: 0x001079B0
		public virtual int[] GetSampleDimensions()
		{
			IntPtr intPtr = vtkGaussianSplatter.vtkGaussianSplatter_GetSampleDimensions_24(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600BE60 RID: 48736
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianSplatter_GetSampleDimensions_25(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set / get the dimensions of the sampling structured point set. Higher
		/// values produce better results but are much slower.
		/// </summary>
		// Token: 0x0600BE61 RID: 48737 RVA: 0x001097F8 File Offset: 0x001079F8
		public virtual void GetSampleDimensions(IntPtr data)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_GetSampleDimensions_25(base.GetCppThis(), data);
		}

		// Token: 0x0600BE62 RID: 48738
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGaussianSplatter_GetScalarWarping_26(HandleRef pThis);

		/// <summary>
		/// Turn on/off the scaling of splats by scalar value.
		/// </summary>
		// Token: 0x0600BE63 RID: 48739 RVA: 0x00109808 File Offset: 0x00107A08
		public virtual int GetScalarWarping()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetScalarWarping_26(base.GetCppThis());
		}

		// Token: 0x0600BE64 RID: 48740
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGaussianSplatter_GetScaleFactor_27(HandleRef pThis);

		/// <summary>
		/// Multiply Gaussian splat distribution by this value. If ScalarWarping
		/// is on, then the Scalar value will be multiplied by the ScaleFactor
		/// times the Gaussian function.
		/// </summary>
		// Token: 0x0600BE65 RID: 48741 RVA: 0x00109828 File Offset: 0x00107A28
		public virtual double GetScaleFactor()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetScaleFactor_27(base.GetCppThis());
		}

		// Token: 0x0600BE66 RID: 48742
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGaussianSplatter_GetScaleFactorMaxValue_28(HandleRef pThis);

		/// <summary>
		/// Multiply Gaussian splat distribution by this value. If ScalarWarping
		/// is on, then the Scalar value will be multiplied by the ScaleFactor
		/// times the Gaussian function.
		/// </summary>
		// Token: 0x0600BE67 RID: 48743 RVA: 0x00109848 File Offset: 0x00107A48
		public virtual double GetScaleFactorMaxValue()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetScaleFactorMaxValue_28(base.GetCppThis());
		}

		// Token: 0x0600BE68 RID: 48744
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGaussianSplatter_GetScaleFactorMinValue_29(HandleRef pThis);

		/// <summary>
		/// Multiply Gaussian splat distribution by this value. If ScalarWarping
		/// is on, then the Scalar value will be multiplied by the ScaleFactor
		/// times the Gaussian function.
		/// </summary>
		// Token: 0x0600BE69 RID: 48745 RVA: 0x00109868 File Offset: 0x00107A68
		public virtual double GetScaleFactorMinValue()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetScaleFactorMinValue_29(base.GetCppThis());
		}

		// Token: 0x0600BE6A RID: 48746
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGaussianSplatter_IsA_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BE6B RID: 48747 RVA: 0x00109888 File Offset: 0x00107A88
		public override int IsA(string type)
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_IsA_30(base.GetCppThis(), type);
		}

		// Token: 0x0600BE6C RID: 48748
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGaussianSplatter_IsTypeOf_31([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BE6D RID: 48749 RVA: 0x001098A8 File Offset: 0x00107AA8
		public new static int IsTypeOf(string type)
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_IsTypeOf_31(type);
		}

		// Token: 0x0600BE6E RID: 48750
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGaussianSplatter_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BE6F RID: 48751 RVA: 0x001098C4 File Offset: 0x00107AC4
		public new vtkGaussianSplatter NewInstance()
		{
			vtkGaussianSplatter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGaussianSplatter.vtkGaussianSplatter_NewInstance_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGaussianSplatter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600BE70 RID: 48752
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianSplatter_NormalWarpingOff_34(HandleRef pThis);

		/// <summary>
		/// Turn on/off the generation of elliptical splats. If normal warping is
		/// on, then the input normals affect the distribution of the splat. This
		/// boolean is used in combination with the Eccentricity ivar.
		/// </summary>
		// Token: 0x0600BE71 RID: 48753 RVA: 0x0010991E File Offset: 0x00107B1E
		public virtual void NormalWarpingOff()
		{
			vtkGaussianSplatter.vtkGaussianSplatter_NormalWarpingOff_34(base.GetCppThis());
		}

		// Token: 0x0600BE72 RID: 48754
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianSplatter_NormalWarpingOn_35(HandleRef pThis);

		/// <summary>
		/// Turn on/off the generation of elliptical splats. If normal warping is
		/// on, then the input normals affect the distribution of the splat. This
		/// boolean is used in combination with the Eccentricity ivar.
		/// </summary>
		// Token: 0x0600BE73 RID: 48755 RVA: 0x0010992D File Offset: 0x00107B2D
		public virtual void NormalWarpingOn()
		{
			vtkGaussianSplatter.vtkGaussianSplatter_NormalWarpingOn_35(base.GetCppThis());
		}

		// Token: 0x0600BE74 RID: 48756
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGaussianSplatter_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BE75 RID: 48757 RVA: 0x0010993C File Offset: 0x00107B3C
		public new static vtkGaussianSplatter SafeDownCast(vtkObjectBase o)
		{
			vtkGaussianSplatter vtkGaussianSplatter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGaussianSplatter.vtkGaussianSplatter_SafeDownCast_36((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGaussianSplatter = (vtkGaussianSplatter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGaussianSplatter.Register(null);
				}
			}
			return vtkGaussianSplatter;
		}

		// Token: 0x0600BE76 RID: 48758
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGaussianSplatter_SamplePoint_37(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Provide access to templated helper class. Note that SamplePoint() method
		/// is public here because some compilers don't handle friend functions
		/// properly.
		/// </summary>
		// Token: 0x0600BE77 RID: 48759 RVA: 0x001099BC File Offset: 0x00107BBC
		public double SamplePoint(IntPtr x)
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_SamplePoint_37(base.GetCppThis(), x);
		}

		// Token: 0x0600BE78 RID: 48760
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianSplatter_ScalarWarpingOff_38(HandleRef pThis);

		/// <summary>
		/// Turn on/off the scaling of splats by scalar value.
		/// </summary>
		// Token: 0x0600BE79 RID: 48761 RVA: 0x001099DC File Offset: 0x00107BDC
		public virtual void ScalarWarpingOff()
		{
			vtkGaussianSplatter.vtkGaussianSplatter_ScalarWarpingOff_38(base.GetCppThis());
		}

		// Token: 0x0600BE7A RID: 48762
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianSplatter_ScalarWarpingOn_39(HandleRef pThis);

		/// <summary>
		/// Turn on/off the scaling of splats by scalar value.
		/// </summary>
		// Token: 0x0600BE7B RID: 48763 RVA: 0x001099EB File Offset: 0x00107BEB
		public virtual void ScalarWarpingOn()
		{
			vtkGaussianSplatter.vtkGaussianSplatter_ScalarWarpingOn_39(base.GetCppThis());
		}

		// Token: 0x0600BE7C RID: 48764
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianSplatter_SetAccumulationMode_40(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the scalar accumulation mode. This mode expresses how scalar
		/// values are combined when splats are overlapped. The Max mode acts
		/// like a set union operation and is the most commonly used; the Min
		/// mode acts like a set intersection, and the sum is just weird.
		/// </summary>
		// Token: 0x0600BE7D RID: 48765 RVA: 0x001099FA File Offset: 0x00107BFA
		public virtual void SetAccumulationMode(int _arg)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetAccumulationMode_40(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BE7E RID: 48766
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianSplatter_SetAccumulationModeToMax_41(HandleRef pThis);

		/// <summary>
		/// Specify the scalar accumulation mode. This mode expresses how scalar
		/// values are combined when splats are overlapped. The Max mode acts
		/// like a set union operation and is the most commonly used; the Min
		/// mode acts like a set intersection, and the sum is just weird.
		/// </summary>
		// Token: 0x0600BE7F RID: 48767 RVA: 0x00109A0A File Offset: 0x00107C0A
		public void SetAccumulationModeToMax()
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetAccumulationModeToMax_41(base.GetCppThis());
		}

		// Token: 0x0600BE80 RID: 48768
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianSplatter_SetAccumulationModeToMin_42(HandleRef pThis);

		/// <summary>
		/// Specify the scalar accumulation mode. This mode expresses how scalar
		/// values are combined when splats are overlapped. The Max mode acts
		/// like a set union operation and is the most commonly used; the Min
		/// mode acts like a set intersection, and the sum is just weird.
		/// </summary>
		// Token: 0x0600BE81 RID: 48769 RVA: 0x00109A19 File Offset: 0x00107C19
		public void SetAccumulationModeToMin()
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetAccumulationModeToMin_42(base.GetCppThis());
		}

		// Token: 0x0600BE82 RID: 48770
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianSplatter_SetAccumulationModeToSum_43(HandleRef pThis);

		/// <summary>
		/// Specify the scalar accumulation mode. This mode expresses how scalar
		/// values are combined when splats are overlapped. The Max mode acts
		/// like a set union operation and is the most commonly used; the Min
		/// mode acts like a set intersection, and the sum is just weird.
		/// </summary>
		// Token: 0x0600BE83 RID: 48771 RVA: 0x00109A28 File Offset: 0x00107C28
		public void SetAccumulationModeToSum()
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetAccumulationModeToSum_43(base.GetCppThis());
		}

		// Token: 0x0600BE84 RID: 48772
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianSplatter_SetCapValue_44(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the cap value to use. (This instance variable only has effect
		/// if the ivar Capping is on.)
		/// </summary>
		// Token: 0x0600BE85 RID: 48773 RVA: 0x00109A37 File Offset: 0x00107C37
		public virtual void SetCapValue(double _arg)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetCapValue_44(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BE86 RID: 48774
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianSplatter_SetCapping_45(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the capping of the outer boundary of the volume
		/// to a specified cap value. This can be used to close surfaces
		/// (after iso-surfacing) and create other effects.
		/// </summary>
		// Token: 0x0600BE87 RID: 48775 RVA: 0x00109A47 File Offset: 0x00107C47
		public virtual void SetCapping(int _arg)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetCapping_45(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BE88 RID: 48776
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianSplatter_SetEccentricity_46(HandleRef pThis, double _arg);

		/// <summary>
		/// Control the shape of elliptical splatting. Eccentricity is the ratio
		/// of the major axis (aligned along normal) to the minor (axes) aligned
		/// along other two axes. So Eccentricity &gt; 1 creates needles with the
		/// long axis in the direction of the normal; Eccentricity&lt;1 creates
		/// pancakes perpendicular to the normal vector.
		/// </summary>
		// Token: 0x0600BE89 RID: 48777 RVA: 0x00109A57 File Offset: 0x00107C57
		public virtual void SetEccentricity(double _arg)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetEccentricity_46(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BE8A RID: 48778
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianSplatter_SetExponentFactor_47(HandleRef pThis, double _arg);

		/// <summary>
		/// Set / get the sharpness of decay of the splats. This is the
		/// exponent constant in the Gaussian equation. Normally this is
		/// a negative value.
		/// </summary>
		// Token: 0x0600BE8B RID: 48779 RVA: 0x00109A67 File Offset: 0x00107C67
		public virtual void SetExponentFactor(double _arg)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetExponentFactor_47(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BE8C RID: 48780
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianSplatter_SetModelBounds_48(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
		/// the sampling is performed. If any of the (min,max) bounds values are
		/// min &gt;= max, then the bounds will be computed automatically from the input
		/// data. Otherwise, the user-specified bounds will be used.
		/// </summary>
		// Token: 0x0600BE8D RID: 48781 RVA: 0x00109A77 File Offset: 0x00107C77
		public virtual void SetModelBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetModelBounds_48(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x0600BE8E RID: 48782
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianSplatter_SetModelBounds_49(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set / get the (xmin,xmax, ymin,ymax, zmin,zmax) bounding box in which
		/// the sampling is performed. If any of the (min,max) bounds values are
		/// min &gt;= max, then the bounds will be computed automatically from the input
		/// data. Otherwise, the user-specified bounds will be used.
		/// </summary>
		// Token: 0x0600BE8F RID: 48783 RVA: 0x00109A8F File Offset: 0x00107C8F
		public virtual void SetModelBounds(IntPtr _arg)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetModelBounds_49(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BE90 RID: 48784
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianSplatter_SetNormalWarping_50(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the generation of elliptical splats. If normal warping is
		/// on, then the input normals affect the distribution of the splat. This
		/// boolean is used in combination with the Eccentricity ivar.
		/// </summary>
		// Token: 0x0600BE91 RID: 48785 RVA: 0x00109A9F File Offset: 0x00107C9F
		public virtual void SetNormalWarping(int _arg)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetNormalWarping_50(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BE92 RID: 48786
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianSplatter_SetNullValue_51(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the Null value for output points not receiving a contribution from the
		/// input points. (This is the initial value of the voxel samples.)
		/// </summary>
		// Token: 0x0600BE93 RID: 48787 RVA: 0x00109AAF File Offset: 0x00107CAF
		public virtual void SetNullValue(double _arg)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetNullValue_51(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BE94 RID: 48788
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianSplatter_SetRadius_52(HandleRef pThis, double _arg);

		/// <summary>
		/// Set / get the radius of propagation of the splat. This value is expressed
		/// as a percentage of the length of the longest side of the sampling
		/// volume. Smaller numbers greatly reduce execution time.
		/// </summary>
		// Token: 0x0600BE95 RID: 48789 RVA: 0x00109ABF File Offset: 0x00107CBF
		public virtual void SetRadius(double _arg)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetRadius_52(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BE96 RID: 48790
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianSplatter_SetSampleDimensions_53(HandleRef pThis, int i, int j, int k);

		/// <summary>
		/// Set / get the dimensions of the sampling structured point set. Higher
		/// values produce better results but are much slower.
		/// </summary>
		// Token: 0x0600BE97 RID: 48791 RVA: 0x00109ACF File Offset: 0x00107CCF
		public void SetSampleDimensions(int i, int j, int k)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetSampleDimensions_53(base.GetCppThis(), i, j, k);
		}

		// Token: 0x0600BE98 RID: 48792
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianSplatter_SetSampleDimensions_54(HandleRef pThis, IntPtr dim);

		/// <summary>
		/// Set / get the dimensions of the sampling structured point set. Higher
		/// values produce better results but are much slower.
		/// </summary>
		// Token: 0x0600BE99 RID: 48793 RVA: 0x00109AE1 File Offset: 0x00107CE1
		public void SetSampleDimensions(IntPtr dim)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetSampleDimensions_54(base.GetCppThis(), dim);
		}

		// Token: 0x0600BE9A RID: 48794
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianSplatter_SetScalar_55(HandleRef pThis, long idx, double dist2, IntPtr sPtr);

		/// <summary>
		/// Provide access to templated helper class. Note that SamplePoint() method
		/// is public here because some compilers don't handle friend functions
		/// properly.
		/// </summary>
		// Token: 0x0600BE9B RID: 48795 RVA: 0x00109AF1 File Offset: 0x00107CF1
		public void SetScalar(long idx, double dist2, IntPtr sPtr)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetScalar_55(base.GetCppThis(), idx, dist2, sPtr);
		}

		// Token: 0x0600BE9C RID: 48796
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianSplatter_SetScalarWarping_56(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the scaling of splats by scalar value.
		/// </summary>
		// Token: 0x0600BE9D RID: 48797 RVA: 0x00109B03 File Offset: 0x00107D03
		public virtual void SetScalarWarping(int _arg)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetScalarWarping_56(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BE9E RID: 48798
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGaussianSplatter_SetScaleFactor_57(HandleRef pThis, double _arg);

		/// <summary>
		/// Multiply Gaussian splat distribution by this value. If ScalarWarping
		/// is on, then the Scalar value will be multiplied by the ScaleFactor
		/// times the Gaussian function.
		/// </summary>
		// Token: 0x0600BE9F RID: 48799 RVA: 0x00109B13 File Offset: 0x00107D13
		public virtual void SetScaleFactor(double _arg)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetScaleFactor_57(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E2F RID: 3631
		public new const string MRFullTypeName = "Kitware.VTK.vtkGaussianSplatter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E30 RID: 3632
		public new static readonly string MRClassNameKey = "class vtkGaussianSplatter";
	}
}
