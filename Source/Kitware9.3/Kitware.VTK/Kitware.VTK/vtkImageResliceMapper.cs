using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageResliceMapper
	/// </summary>
	/// <remarks>
	///    map a slice of a vtkImageData to the screen
	///
	/// vtkImageResliceMapper will cut a 3D image with an arbitrary slice plane
	/// and draw the results on the screen.  The slice can be set to automatically
	/// follow the camera, so that the camera controls the slicing.
	/// @par Thanks:
	/// Thanks to David Gobbi at the Seaman Family MR Centre and Dept. of Clinical
	/// Neurosciences, Foothills Medical Centre, Calgary, for providing this class.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageSlice vtkImageProperty vtkImageSliceMapper
	/// </seealso>
	// Token: 0x02000110 RID: 272
	public class vtkImageResliceMapper : vtkImageMapper3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003766 RID: 14182 RVA: 0x00050E3D File Offset: 0x0004F03D
		static vtkImageResliceMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageResliceMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageResliceMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003767 RID: 14183 RVA: 0x00050E65 File Offset: 0x0004F065
		public vtkImageResliceMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003768 RID: 14184
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageResliceMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003769 RID: 14185 RVA: 0x00050E74 File Offset: 0x0004F074
		public new static vtkImageResliceMapper New()
		{
			vtkImageResliceMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageResliceMapper.vtkImageResliceMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageResliceMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600376A RID: 14186 RVA: 0x00050EC8 File Offset: 0x0004F0C8
		public vtkImageResliceMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageResliceMapper.vtkImageResliceMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600376B RID: 14187 RVA: 0x00050F0C File Offset: 0x0004F10C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600376C RID: 14188
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceMapper_AutoAdjustImageQualityOff_01(HandleRef pThis);

		/// <summary>
		/// Automatically reduce the rendering quality for greater speed
		/// when doing an interactive render.  This is on by default.
		/// </summary>
		// Token: 0x0600376D RID: 14189 RVA: 0x00050F17 File Offset: 0x0004F117
		public virtual void AutoAdjustImageQualityOff()
		{
			vtkImageResliceMapper.vtkImageResliceMapper_AutoAdjustImageQualityOff_01(base.GetCppThis());
		}

		// Token: 0x0600376E RID: 14190
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceMapper_AutoAdjustImageQualityOn_02(HandleRef pThis);

		/// <summary>
		/// Automatically reduce the rendering quality for greater speed
		/// when doing an interactive render.  This is on by default.
		/// </summary>
		// Token: 0x0600376F RID: 14191 RVA: 0x00050F26 File Offset: 0x0004F126
		public virtual void AutoAdjustImageQualityOn()
		{
			vtkImageResliceMapper.vtkImageResliceMapper_AutoAdjustImageQualityOn_02(base.GetCppThis());
		}

		// Token: 0x06003770 RID: 14192
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResliceMapper_GetAutoAdjustImageQuality_03(HandleRef pThis);

		/// <summary>
		/// Automatically reduce the rendering quality for greater speed
		/// when doing an interactive render.  This is on by default.
		/// </summary>
		// Token: 0x06003771 RID: 14193 RVA: 0x00050F38 File Offset: 0x0004F138
		public virtual int GetAutoAdjustImageQuality()
		{
			return vtkImageResliceMapper.vtkImageResliceMapper_GetAutoAdjustImageQuality_03(base.GetCppThis());
		}

		// Token: 0x06003772 RID: 14194
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageResliceMapper_GetBounds_04(HandleRef pThis);

		/// <summary>
		/// The bounding box (array of six doubles) of the data expressed as
		/// (xmin,xmax, ymin,ymax, zmin,zmax).
		/// </summary>
		// Token: 0x06003773 RID: 14195 RVA: 0x00050F58 File Offset: 0x0004F158
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkImageResliceMapper.vtkImageResliceMapper_GetBounds_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06003774 RID: 14196
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceMapper_GetBounds_05(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// The bounding box (array of six doubles) of the data expressed as
		/// (xmin,xmax, ymin,ymax, zmin,zmax).
		/// </summary>
		// Token: 0x06003775 RID: 14197 RVA: 0x00050FA0 File Offset: 0x0004F1A0
		public override void GetBounds(IntPtr bounds)
		{
			vtkImageResliceMapper.vtkImageResliceMapper_GetBounds_05(base.GetCppThis(), bounds);
		}

		// Token: 0x06003776 RID: 14198
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResliceMapper_GetImageSampleFactor_06(HandleRef pThis);

		/// <summary>
		/// Set the reslice sample frequency as in relation to the input image
		/// sample frequency.  The default value is 1, but higher values can be
		/// used to improve the results.  This is cheaper than turning on
		/// ResampleToScreenPixels.
		/// </summary>
		// Token: 0x06003777 RID: 14199 RVA: 0x00050FB0 File Offset: 0x0004F1B0
		public virtual int GetImageSampleFactor()
		{
			return vtkImageResliceMapper.vtkImageResliceMapper_GetImageSampleFactor_06(base.GetCppThis());
		}

		// Token: 0x06003778 RID: 14200
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResliceMapper_GetImageSampleFactorMaxValue_07(HandleRef pThis);

		/// <summary>
		/// Set the reslice sample frequency as in relation to the input image
		/// sample frequency.  The default value is 1, but higher values can be
		/// used to improve the results.  This is cheaper than turning on
		/// ResampleToScreenPixels.
		/// </summary>
		// Token: 0x06003779 RID: 14201 RVA: 0x00050FD0 File Offset: 0x0004F1D0
		public virtual int GetImageSampleFactorMaxValue()
		{
			return vtkImageResliceMapper.vtkImageResliceMapper_GetImageSampleFactorMaxValue_07(base.GetCppThis());
		}

		// Token: 0x0600377A RID: 14202
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResliceMapper_GetImageSampleFactorMinValue_08(HandleRef pThis);

		/// <summary>
		/// Set the reslice sample frequency as in relation to the input image
		/// sample frequency.  The default value is 1, but higher values can be
		/// used to improve the results.  This is cheaper than turning on
		/// ResampleToScreenPixels.
		/// </summary>
		// Token: 0x0600377B RID: 14203 RVA: 0x00050FF0 File Offset: 0x0004F1F0
		public virtual int GetImageSampleFactorMinValue()
		{
			return vtkImageResliceMapper.vtkImageResliceMapper_GetImageSampleFactorMinValue_08(base.GetCppThis());
		}

		// Token: 0x0600377C RID: 14204
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceMapper_GetIndexBounds_09(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// Handle requests from the pipeline executive.
		/// </summary>
		// Token: 0x0600377D RID: 14205 RVA: 0x0005100F File Offset: 0x0004F20F
		public override void GetIndexBounds(IntPtr extent)
		{
			vtkImageResliceMapper.vtkImageResliceMapper_GetIndexBounds_09(base.GetCppThis(), extent);
		}

		// Token: 0x0600377E RID: 14206
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageResliceMapper_GetInterpolator_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set a custom interpolator.  This will only be used if the
		/// ResampleToScreenPixels option is on.
		/// </summary>
		// Token: 0x0600377F RID: 14207 RVA: 0x00051020 File Offset: 0x0004F220
		public virtual vtkAbstractImageInterpolator GetInterpolator()
		{
			vtkAbstractImageInterpolator vtkAbstractImageInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageResliceMapper.vtkImageResliceMapper_GetInterpolator_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractImageInterpolator = (vtkAbstractImageInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractImageInterpolator.Register(null);
				}
			}
			return vtkAbstractImageInterpolator;
		}

		// Token: 0x06003780 RID: 14208
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResliceMapper_GetJumpToNearestSlice_11(HandleRef pThis);

		/// <summary>
		/// When using SliceAtFocalPoint, this causes the slicing to occur at
		/// the closest slice to the focal point, instead of the default behavior
		/// where a new slice is interpolated between the original slices.  This
		/// flag is ignored if the slicing is oblique to the original slices.
		/// </summary>
		// Token: 0x06003781 RID: 14209 RVA: 0x00051090 File Offset: 0x0004F290
		public virtual int GetJumpToNearestSlice()
		{
			return vtkImageResliceMapper.vtkImageResliceMapper_GetJumpToNearestSlice_11(base.GetCppThis());
		}

		// Token: 0x06003782 RID: 14210
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkImageResliceMapper_GetMTime_12(HandleRef pThis);

		/// <summary>
		/// Get the mtime for the mapper.
		/// </summary>
		// Token: 0x06003783 RID: 14211 RVA: 0x000510B0 File Offset: 0x0004F2B0
		public override ulong GetMTime()
		{
			return vtkImageResliceMapper.vtkImageResliceMapper_GetMTime_12(base.GetCppThis());
		}

		// Token: 0x06003784 RID: 14212
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageResliceMapper_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003785 RID: 14213 RVA: 0x000510D0 File Offset: 0x0004F2D0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageResliceMapper.vtkImageResliceMapper_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x06003786 RID: 14214
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageResliceMapper_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003787 RID: 14215 RVA: 0x000510F0 File Offset: 0x0004F2F0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageResliceMapper.vtkImageResliceMapper_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x06003788 RID: 14216
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResliceMapper_GetResampleToScreenPixels_15(HandleRef pThis);

		/// <summary>
		/// Resample the image directly to the screen pixels, instead of
		/// using a texture to scale the image after resampling.  This is
		/// slower and uses more memory, but provides high-quality results.
		/// It is On by default.
		/// </summary>
		// Token: 0x06003789 RID: 14217 RVA: 0x0005110C File Offset: 0x0004F30C
		public virtual int GetResampleToScreenPixels()
		{
			return vtkImageResliceMapper.vtkImageResliceMapper_GetResampleToScreenPixels_15(base.GetCppThis());
		}

		// Token: 0x0600378A RID: 14218
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResliceMapper_GetSeparateWindowLevelOperation_16(HandleRef pThis);

		/// <summary>
		/// Keep the color mapping stage distinct from the reslicing stage.
		/// This will improve the quality and possibly the speed of interactive
		/// window/level operations, but it uses more memory and might slow down
		/// interactive slicing operations.  On by default.
		/// </summary>
		// Token: 0x0600378B RID: 14219 RVA: 0x0005112C File Offset: 0x0004F32C
		public virtual int GetSeparateWindowLevelOperation()
		{
			return vtkImageResliceMapper.vtkImageResliceMapper_GetSeparateWindowLevelOperation_16(base.GetCppThis());
		}

		// Token: 0x0600378C RID: 14220
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResliceMapper_GetSlabSampleFactor_17(HandleRef pThis);

		/// <summary>
		/// Set the number of slab samples to use as a factor of the number
		/// of input slices within the slab thickness.  The default value
		/// is 2, but 1 will increase speed with very little loss of quality.
		/// </summary>
		// Token: 0x0600378D RID: 14221 RVA: 0x0005114C File Offset: 0x0004F34C
		public virtual int GetSlabSampleFactor()
		{
			return vtkImageResliceMapper.vtkImageResliceMapper_GetSlabSampleFactor_17(base.GetCppThis());
		}

		// Token: 0x0600378E RID: 14222
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResliceMapper_GetSlabSampleFactorMaxValue_18(HandleRef pThis);

		/// <summary>
		/// Set the number of slab samples to use as a factor of the number
		/// of input slices within the slab thickness.  The default value
		/// is 2, but 1 will increase speed with very little loss of quality.
		/// </summary>
		// Token: 0x0600378F RID: 14223 RVA: 0x0005116C File Offset: 0x0004F36C
		public virtual int GetSlabSampleFactorMaxValue()
		{
			return vtkImageResliceMapper.vtkImageResliceMapper_GetSlabSampleFactorMaxValue_18(base.GetCppThis());
		}

		// Token: 0x06003790 RID: 14224
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResliceMapper_GetSlabSampleFactorMinValue_19(HandleRef pThis);

		/// <summary>
		/// Set the number of slab samples to use as a factor of the number
		/// of input slices within the slab thickness.  The default value
		/// is 2, but 1 will increase speed with very little loss of quality.
		/// </summary>
		// Token: 0x06003791 RID: 14225 RVA: 0x0005118C File Offset: 0x0004F38C
		public virtual int GetSlabSampleFactorMinValue()
		{
			return vtkImageResliceMapper.vtkImageResliceMapper_GetSlabSampleFactorMinValue_19(base.GetCppThis());
		}

		// Token: 0x06003792 RID: 14226
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageResliceMapper_GetSlabThickness_20(HandleRef pThis);

		/// <summary>
		/// The slab thickness, for thick slicing (default: zero)
		/// </summary>
		// Token: 0x06003793 RID: 14227 RVA: 0x000511AC File Offset: 0x0004F3AC
		public virtual double GetSlabThickness()
		{
			return vtkImageResliceMapper.vtkImageResliceMapper_GetSlabThickness_20(base.GetCppThis());
		}

		// Token: 0x06003794 RID: 14228
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResliceMapper_GetSlabType_21(HandleRef pThis);

		/// <summary>
		/// The slab type, for thick slicing (default: Mean).
		/// The resulting view is a parallel projection through the volume.  This
		/// method can be used to generate a facsimile of a digitally-reconstructed
		/// radiograph or a minimum-intensity projection as long as perspective
		/// geometry is not required.  Note that the Sum mode provides an output
		/// with units of intensity times distance, while all other modes provide
		/// an output with units of intensity.
		/// </summary>
		// Token: 0x06003795 RID: 14229 RVA: 0x000511CC File Offset: 0x0004F3CC
		public virtual int GetSlabType()
		{
			return vtkImageResliceMapper.vtkImageResliceMapper_GetSlabType_21(base.GetCppThis());
		}

		// Token: 0x06003796 RID: 14230
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageResliceMapper_GetSlabTypeAsString_22(HandleRef pThis);

		/// <summary>
		/// The slab type, for thick slicing (default: Mean).
		/// The resulting view is a parallel projection through the volume.  This
		/// method can be used to generate a facsimile of a digitally-reconstructed
		/// radiograph or a minimum-intensity projection as long as perspective
		/// geometry is not required.  Note that the Sum mode provides an output
		/// with units of intensity times distance, while all other modes provide
		/// an output with units of intensity.
		/// </summary>
		// Token: 0x06003797 RID: 14231 RVA: 0x000511EC File Offset: 0x0004F3EC
		public virtual string GetSlabTypeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageResliceMapper.vtkImageResliceMapper_GetSlabTypeAsString_22(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06003798 RID: 14232
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResliceMapper_GetSlabTypeMaxValue_23(HandleRef pThis);

		/// <summary>
		/// The slab type, for thick slicing (default: Mean).
		/// The resulting view is a parallel projection through the volume.  This
		/// method can be used to generate a facsimile of a digitally-reconstructed
		/// radiograph or a minimum-intensity projection as long as perspective
		/// geometry is not required.  Note that the Sum mode provides an output
		/// with units of intensity times distance, while all other modes provide
		/// an output with units of intensity.
		/// </summary>
		// Token: 0x06003799 RID: 14233 RVA: 0x00051228 File Offset: 0x0004F428
		public virtual int GetSlabTypeMaxValue()
		{
			return vtkImageResliceMapper.vtkImageResliceMapper_GetSlabTypeMaxValue_23(base.GetCppThis());
		}

		// Token: 0x0600379A RID: 14234
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResliceMapper_GetSlabTypeMinValue_24(HandleRef pThis);

		/// <summary>
		/// The slab type, for thick slicing (default: Mean).
		/// The resulting view is a parallel projection through the volume.  This
		/// method can be used to generate a facsimile of a digitally-reconstructed
		/// radiograph or a minimum-intensity projection as long as perspective
		/// geometry is not required.  Note that the Sum mode provides an output
		/// with units of intensity times distance, while all other modes provide
		/// an output with units of intensity.
		/// </summary>
		// Token: 0x0600379B RID: 14235 RVA: 0x00051248 File Offset: 0x0004F448
		public virtual int GetSlabTypeMinValue()
		{
			return vtkImageResliceMapper.vtkImageResliceMapper_GetSlabTypeMinValue_24(base.GetCppThis());
		}

		// Token: 0x0600379C RID: 14236
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResliceMapper_IsA_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600379D RID: 14237 RVA: 0x00051268 File Offset: 0x0004F468
		public override int IsA(string type)
		{
			return vtkImageResliceMapper.vtkImageResliceMapper_IsA_25(base.GetCppThis(), type);
		}

		// Token: 0x0600379E RID: 14238
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResliceMapper_IsTypeOf_26([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600379F RID: 14239 RVA: 0x00051288 File Offset: 0x0004F488
		public new static int IsTypeOf(string type)
		{
			return vtkImageResliceMapper.vtkImageResliceMapper_IsTypeOf_26(type);
		}

		// Token: 0x060037A0 RID: 14240
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceMapper_JumpToNearestSliceOff_27(HandleRef pThis);

		/// <summary>
		/// When using SliceAtFocalPoint, this causes the slicing to occur at
		/// the closest slice to the focal point, instead of the default behavior
		/// where a new slice is interpolated between the original slices.  This
		/// flag is ignored if the slicing is oblique to the original slices.
		/// </summary>
		// Token: 0x060037A1 RID: 14241 RVA: 0x000512A2 File Offset: 0x0004F4A2
		public virtual void JumpToNearestSliceOff()
		{
			vtkImageResliceMapper.vtkImageResliceMapper_JumpToNearestSliceOff_27(base.GetCppThis());
		}

		// Token: 0x060037A2 RID: 14242
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceMapper_JumpToNearestSliceOn_28(HandleRef pThis);

		/// <summary>
		/// When using SliceAtFocalPoint, this causes the slicing to occur at
		/// the closest slice to the focal point, instead of the default behavior
		/// where a new slice is interpolated between the original slices.  This
		/// flag is ignored if the slicing is oblique to the original slices.
		/// </summary>
		// Token: 0x060037A3 RID: 14243 RVA: 0x000512B1 File Offset: 0x0004F4B1
		public virtual void JumpToNearestSliceOn()
		{
			vtkImageResliceMapper.vtkImageResliceMapper_JumpToNearestSliceOn_28(base.GetCppThis());
		}

		// Token: 0x060037A4 RID: 14244
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageResliceMapper_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060037A5 RID: 14245 RVA: 0x000512C0 File Offset: 0x0004F4C0
		public new vtkImageResliceMapper NewInstance()
		{
			vtkImageResliceMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageResliceMapper.vtkImageResliceMapper_NewInstance_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageResliceMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060037A6 RID: 14246
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceMapper_ReleaseGraphicsResources_31(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by
		/// this mapper.  The parameter window is used to determine
		/// which graphic resources to release.
		/// </summary>
		// Token: 0x060037A7 RID: 14247 RVA: 0x0005131C File Offset: 0x0004F51C
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkImageResliceMapper.vtkImageResliceMapper_ReleaseGraphicsResources_31(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060037A8 RID: 14248
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceMapper_Render_32(HandleRef pThis, HandleRef renderer, HandleRef prop);

		/// <summary>
		/// This should only be called by the renderer.
		/// </summary>
		// Token: 0x060037A9 RID: 14249 RVA: 0x0005134C File Offset: 0x0004F54C
		public override void Render(vtkRenderer renderer, vtkImageSlice prop)
		{
			vtkImageResliceMapper.vtkImageResliceMapper_Render_32(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x060037AA RID: 14250
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceMapper_ResampleToScreenPixelsOff_33(HandleRef pThis);

		/// <summary>
		/// Resample the image directly to the screen pixels, instead of
		/// using a texture to scale the image after resampling.  This is
		/// slower and uses more memory, but provides high-quality results.
		/// It is On by default.
		/// </summary>
		// Token: 0x060037AB RID: 14251 RVA: 0x00051390 File Offset: 0x0004F590
		public virtual void ResampleToScreenPixelsOff()
		{
			vtkImageResliceMapper.vtkImageResliceMapper_ResampleToScreenPixelsOff_33(base.GetCppThis());
		}

		// Token: 0x060037AC RID: 14252
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceMapper_ResampleToScreenPixelsOn_34(HandleRef pThis);

		/// <summary>
		/// Resample the image directly to the screen pixels, instead of
		/// using a texture to scale the image after resampling.  This is
		/// slower and uses more memory, but provides high-quality results.
		/// It is On by default.
		/// </summary>
		// Token: 0x060037AD RID: 14253 RVA: 0x0005139F File Offset: 0x0004F59F
		public virtual void ResampleToScreenPixelsOn()
		{
			vtkImageResliceMapper.vtkImageResliceMapper_ResampleToScreenPixelsOn_34(base.GetCppThis());
		}

		// Token: 0x060037AE RID: 14254
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageResliceMapper_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060037AF RID: 14255 RVA: 0x000513B0 File Offset: 0x0004F5B0
		public new static vtkImageResliceMapper SafeDownCast(vtkObjectBase o)
		{
			vtkImageResliceMapper vtkImageResliceMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageResliceMapper.vtkImageResliceMapper_SafeDownCast_35((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageResliceMapper = (vtkImageResliceMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageResliceMapper.Register(null);
				}
			}
			return vtkImageResliceMapper;
		}

		// Token: 0x060037B0 RID: 14256
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceMapper_SeparateWindowLevelOperationOff_36(HandleRef pThis);

		/// <summary>
		/// Keep the color mapping stage distinct from the reslicing stage.
		/// This will improve the quality and possibly the speed of interactive
		/// window/level operations, but it uses more memory and might slow down
		/// interactive slicing operations.  On by default.
		/// </summary>
		// Token: 0x060037B1 RID: 14257 RVA: 0x0005142F File Offset: 0x0004F62F
		public virtual void SeparateWindowLevelOperationOff()
		{
			vtkImageResliceMapper.vtkImageResliceMapper_SeparateWindowLevelOperationOff_36(base.GetCppThis());
		}

		// Token: 0x060037B2 RID: 14258
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceMapper_SeparateWindowLevelOperationOn_37(HandleRef pThis);

		/// <summary>
		/// Keep the color mapping stage distinct from the reslicing stage.
		/// This will improve the quality and possibly the speed of interactive
		/// window/level operations, but it uses more memory and might slow down
		/// interactive slicing operations.  On by default.
		/// </summary>
		// Token: 0x060037B3 RID: 14259 RVA: 0x0005143E File Offset: 0x0004F63E
		public virtual void SeparateWindowLevelOperationOn()
		{
			vtkImageResliceMapper.vtkImageResliceMapper_SeparateWindowLevelOperationOn_37(base.GetCppThis());
		}

		// Token: 0x060037B4 RID: 14260
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceMapper_SetAutoAdjustImageQuality_38(HandleRef pThis, int _arg);

		/// <summary>
		/// Automatically reduce the rendering quality for greater speed
		/// when doing an interactive render.  This is on by default.
		/// </summary>
		// Token: 0x060037B5 RID: 14261 RVA: 0x0005144D File Offset: 0x0004F64D
		public virtual void SetAutoAdjustImageQuality(int _arg)
		{
			vtkImageResliceMapper.vtkImageResliceMapper_SetAutoAdjustImageQuality_38(base.GetCppThis(), _arg);
		}

		// Token: 0x060037B6 RID: 14262
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceMapper_SetImageSampleFactor_39(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the reslice sample frequency as in relation to the input image
		/// sample frequency.  The default value is 1, but higher values can be
		/// used to improve the results.  This is cheaper than turning on
		/// ResampleToScreenPixels.
		/// </summary>
		// Token: 0x060037B7 RID: 14263 RVA: 0x0005145D File Offset: 0x0004F65D
		public virtual void SetImageSampleFactor(int _arg)
		{
			vtkImageResliceMapper.vtkImageResliceMapper_SetImageSampleFactor_39(base.GetCppThis(), _arg);
		}

		// Token: 0x060037B8 RID: 14264
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceMapper_SetInterpolator_40(HandleRef pThis, HandleRef interpolator);

		/// <summary>
		/// Set a custom interpolator.  This will only be used if the
		/// ResampleToScreenPixels option is on.
		/// </summary>
		// Token: 0x060037B9 RID: 14265 RVA: 0x00051470 File Offset: 0x0004F670
		public virtual void SetInterpolator(vtkAbstractImageInterpolator interpolator)
		{
			vtkImageResliceMapper.vtkImageResliceMapper_SetInterpolator_40(base.GetCppThis(), (interpolator == null) ? default(HandleRef) : interpolator.GetCppThis());
		}

		// Token: 0x060037BA RID: 14266
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceMapper_SetJumpToNearestSlice_41(HandleRef pThis, int _arg);

		/// <summary>
		/// When using SliceAtFocalPoint, this causes the slicing to occur at
		/// the closest slice to the focal point, instead of the default behavior
		/// where a new slice is interpolated between the original slices.  This
		/// flag is ignored if the slicing is oblique to the original slices.
		/// </summary>
		// Token: 0x060037BB RID: 14267 RVA: 0x0005149F File Offset: 0x0004F69F
		public virtual void SetJumpToNearestSlice(int _arg)
		{
			vtkImageResliceMapper.vtkImageResliceMapper_SetJumpToNearestSlice_41(base.GetCppThis(), _arg);
		}

		// Token: 0x060037BC RID: 14268
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceMapper_SetResampleToScreenPixels_42(HandleRef pThis, int _arg);

		/// <summary>
		/// Resample the image directly to the screen pixels, instead of
		/// using a texture to scale the image after resampling.  This is
		/// slower and uses more memory, but provides high-quality results.
		/// It is On by default.
		/// </summary>
		// Token: 0x060037BD RID: 14269 RVA: 0x000514AF File Offset: 0x0004F6AF
		public virtual void SetResampleToScreenPixels(int _arg)
		{
			vtkImageResliceMapper.vtkImageResliceMapper_SetResampleToScreenPixels_42(base.GetCppThis(), _arg);
		}

		// Token: 0x060037BE RID: 14270
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceMapper_SetSeparateWindowLevelOperation_43(HandleRef pThis, int _arg);

		/// <summary>
		/// Keep the color mapping stage distinct from the reslicing stage.
		/// This will improve the quality and possibly the speed of interactive
		/// window/level operations, but it uses more memory and might slow down
		/// interactive slicing operations.  On by default.
		/// </summary>
		// Token: 0x060037BF RID: 14271 RVA: 0x000514BF File Offset: 0x0004F6BF
		public virtual void SetSeparateWindowLevelOperation(int _arg)
		{
			vtkImageResliceMapper.vtkImageResliceMapper_SetSeparateWindowLevelOperation_43(base.GetCppThis(), _arg);
		}

		// Token: 0x060037C0 RID: 14272
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceMapper_SetSlabSampleFactor_44(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the number of slab samples to use as a factor of the number
		/// of input slices within the slab thickness.  The default value
		/// is 2, but 1 will increase speed with very little loss of quality.
		/// </summary>
		// Token: 0x060037C1 RID: 14273 RVA: 0x000514CF File Offset: 0x0004F6CF
		public virtual void SetSlabSampleFactor(int _arg)
		{
			vtkImageResliceMapper.vtkImageResliceMapper_SetSlabSampleFactor_44(base.GetCppThis(), _arg);
		}

		// Token: 0x060037C2 RID: 14274
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceMapper_SetSlabThickness_45(HandleRef pThis, double _arg);

		/// <summary>
		/// The slab thickness, for thick slicing (default: zero)
		/// </summary>
		// Token: 0x060037C3 RID: 14275 RVA: 0x000514DF File Offset: 0x0004F6DF
		public virtual void SetSlabThickness(double _arg)
		{
			vtkImageResliceMapper.vtkImageResliceMapper_SetSlabThickness_45(base.GetCppThis(), _arg);
		}

		// Token: 0x060037C4 RID: 14276
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceMapper_SetSlabType_46(HandleRef pThis, int _arg);

		/// <summary>
		/// The slab type, for thick slicing (default: Mean).
		/// The resulting view is a parallel projection through the volume.  This
		/// method can be used to generate a facsimile of a digitally-reconstructed
		/// radiograph or a minimum-intensity projection as long as perspective
		/// geometry is not required.  Note that the Sum mode provides an output
		/// with units of intensity times distance, while all other modes provide
		/// an output with units of intensity.
		/// </summary>
		// Token: 0x060037C5 RID: 14277 RVA: 0x000514EF File Offset: 0x0004F6EF
		public virtual void SetSlabType(int _arg)
		{
			vtkImageResliceMapper.vtkImageResliceMapper_SetSlabType_46(base.GetCppThis(), _arg);
		}

		// Token: 0x060037C6 RID: 14278
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceMapper_SetSlabTypeToMax_47(HandleRef pThis);

		/// <summary>
		/// The slab type, for thick slicing (default: Mean).
		/// The resulting view is a parallel projection through the volume.  This
		/// method can be used to generate a facsimile of a digitally-reconstructed
		/// radiograph or a minimum-intensity projection as long as perspective
		/// geometry is not required.  Note that the Sum mode provides an output
		/// with units of intensity times distance, while all other modes provide
		/// an output with units of intensity.
		/// </summary>
		// Token: 0x060037C7 RID: 14279 RVA: 0x000514FF File Offset: 0x0004F6FF
		public void SetSlabTypeToMax()
		{
			vtkImageResliceMapper.vtkImageResliceMapper_SetSlabTypeToMax_47(base.GetCppThis());
		}

		// Token: 0x060037C8 RID: 14280
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceMapper_SetSlabTypeToMean_48(HandleRef pThis);

		/// <summary>
		/// The slab type, for thick slicing (default: Mean).
		/// The resulting view is a parallel projection through the volume.  This
		/// method can be used to generate a facsimile of a digitally-reconstructed
		/// radiograph or a minimum-intensity projection as long as perspective
		/// geometry is not required.  Note that the Sum mode provides an output
		/// with units of intensity times distance, while all other modes provide
		/// an output with units of intensity.
		/// </summary>
		// Token: 0x060037C9 RID: 14281 RVA: 0x0005150E File Offset: 0x0004F70E
		public void SetSlabTypeToMean()
		{
			vtkImageResliceMapper.vtkImageResliceMapper_SetSlabTypeToMean_48(base.GetCppThis());
		}

		// Token: 0x060037CA RID: 14282
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceMapper_SetSlabTypeToMin_49(HandleRef pThis);

		/// <summary>
		/// The slab type, for thick slicing (default: Mean).
		/// The resulting view is a parallel projection through the volume.  This
		/// method can be used to generate a facsimile of a digitally-reconstructed
		/// radiograph or a minimum-intensity projection as long as perspective
		/// geometry is not required.  Note that the Sum mode provides an output
		/// with units of intensity times distance, while all other modes provide
		/// an output with units of intensity.
		/// </summary>
		// Token: 0x060037CB RID: 14283 RVA: 0x0005151D File Offset: 0x0004F71D
		public void SetSlabTypeToMin()
		{
			vtkImageResliceMapper.vtkImageResliceMapper_SetSlabTypeToMin_49(base.GetCppThis());
		}

		// Token: 0x060037CC RID: 14284
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceMapper_SetSlabTypeToSum_50(HandleRef pThis);

		/// <summary>
		/// The slab type, for thick slicing (default: Mean).
		/// The resulting view is a parallel projection through the volume.  This
		/// method can be used to generate a facsimile of a digitally-reconstructed
		/// radiograph or a minimum-intensity projection as long as perspective
		/// geometry is not required.  Note that the Sum mode provides an output
		/// with units of intensity times distance, while all other modes provide
		/// an output with units of intensity.
		/// </summary>
		// Token: 0x060037CD RID: 14285 RVA: 0x0005152C File Offset: 0x0004F72C
		public void SetSlabTypeToSum()
		{
			vtkImageResliceMapper.vtkImageResliceMapper_SetSlabTypeToSum_50(base.GetCppThis());
		}

		// Token: 0x060037CE RID: 14286
		[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResliceMapper_SetSlicePlane_51(HandleRef pThis, HandleRef plane);

		/// <summary>
		/// Set the slice that will be used to cut through the image.
		/// This slice should be in world coordinates, rather than
		/// data coordinates.  Use SliceFacesCamera and SliceAtFocalPoint
		/// if you want the slice to automatically follow the camera.
		/// </summary>
		// Token: 0x060037CF RID: 14287 RVA: 0x0005153C File Offset: 0x0004F73C
		public virtual void SetSlicePlane(vtkPlane plane)
		{
			vtkImageResliceMapper.vtkImageResliceMapper_SetSlicePlane_51(base.GetCppThis(), (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000658 RID: 1624
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageResliceMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000659 RID: 1625
		public new static readonly string MRClassNameKey = "class vtkImageResliceMapper";
	}
}
