using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageReslice
	/// </summary>
	/// <remarks>
	///    Reslices a volume along a new set of axes.
	///
	/// vtkImageReslice is the swiss-army-knife of image geometry filters:
	/// It can permute, rotate, flip, scale, resample, deform, and pad image
	/// data in any combination with reasonably high efficiency.  Simple
	/// operations such as permutation, resampling and padding are done
	/// with similar efficiently to the specialized vtkImagePermute,
	/// vtkImageResample, and vtkImagePad filters.  There are a number of
	/// tasks that vtkImageReslice is well suited for:
	/// &lt;p&gt;1) Application of transformations (either linear or nonlinear) to
	/// an image. It is sometimes convenient to use vtkImageChangeInformation
	/// to center the image first, so that scales and rotations occur around
	/// the center rather than around the lower-left corner of the image.
	/// &lt;p&gt;2) Resampling of one data set to match the voxel sampling of
	/// a second data set via the SetInformationInput() method, e.g. for
	/// the purpose of comparing two images or combining two images.
	/// A transformation, either linear or nonlinear, can be applied
	/// at the same time via the SetResliceTransform method if the two
	/// images are not in the same coordinate space.
	/// &lt;p&gt;3) Extraction of slices from an image volume. The most convenient
	/// way to do this is to use SetOutputDirection() to specify the
	/// orientation of the output slices. The columns of the direction
	/// matrix specify the x, y, and z axes for the output volume or slice,
	/// and SetOutputOrigin() can be used to specify the position. You can
	/// use these methods together with SetResliceTransform() in order
	/// to extract slices in a certain orientation while simultaneously
	/// applying a transformation to the coordinate system.
	/// @warning
	/// This filter is very inefficient if the output X dimension is 1.
	/// </remarks>
	/// <seealso>
	///
	/// vtkAbstractImageInterpolator vtkAbstractTransform vtkImageResliceToColors
	/// </seealso>
	// Token: 0x0200048F RID: 1167
	public class vtkImageReslice : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D627 RID: 54823 RVA: 0x0012A088 File Offset: 0x00128288
		static vtkImageReslice()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageReslice.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageReslice"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D628 RID: 54824 RVA: 0x0012A0B0 File Offset: 0x001282B0
		public vtkImageReslice(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D629 RID: 54825
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReslice_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D62A RID: 54826 RVA: 0x0012A0C0 File Offset: 0x001282C0
		public new static vtkImageReslice New()
		{
			vtkImageReslice result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageReslice.vtkImageReslice_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageReslice)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D62B RID: 54827 RVA: 0x0012A114 File Offset: 0x00128314
		public vtkImageReslice() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageReslice.vtkImageReslice_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D62C RID: 54828 RVA: 0x0012A158 File Offset: 0x00128358
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D62D RID: 54829
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_AutoCropOutputOff_01(HandleRef pThis);

		/// <summary>
		/// Turn this on if you want to guarantee that the extent of the
		/// output will be large enough to ensure that none of the
		/// data will be cropped (default: Off).
		/// </summary>
		// Token: 0x0600D62E RID: 54830 RVA: 0x0012A163 File Offset: 0x00128363
		public virtual void AutoCropOutputOff()
		{
			vtkImageReslice.vtkImageReslice_AutoCropOutputOff_01(base.GetCppThis());
		}

		// Token: 0x0600D62F RID: 54831
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_AutoCropOutputOn_02(HandleRef pThis);

		/// <summary>
		/// Turn this on if you want to guarantee that the extent of the
		/// output will be large enough to ensure that none of the
		/// data will be cropped (default: Off).
		/// </summary>
		// Token: 0x0600D630 RID: 54832 RVA: 0x0012A172 File Offset: 0x00128372
		public virtual void AutoCropOutputOn()
		{
			vtkImageReslice.vtkImageReslice_AutoCropOutputOn_02(base.GetCppThis());
		}

		// Token: 0x0600D631 RID: 54833
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_BorderOff_03(HandleRef pThis);

		/// <summary>
		/// Extend the apparent input border by a half voxel (default: On).
		/// This changes how interpolation is handled at the borders of the
		/// input image: if the center of an output voxel is beyond the edge
		/// of the input image, but is within a half voxel width of the edge
		/// (using the input voxel width), then the value of the output voxel
		/// is calculated as if the input's edge voxels were duplicated past
		/// the edges of the input.
		/// This has no effect if Mirror or Wrap are on.
		/// </summary>
		// Token: 0x0600D632 RID: 54834 RVA: 0x0012A181 File Offset: 0x00128381
		public virtual void BorderOff()
		{
			vtkImageReslice.vtkImageReslice_BorderOff_03(base.GetCppThis());
		}

		// Token: 0x0600D633 RID: 54835
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_BorderOn_04(HandleRef pThis);

		/// <summary>
		/// Extend the apparent input border by a half voxel (default: On).
		/// This changes how interpolation is handled at the borders of the
		/// input image: if the center of an output voxel is beyond the edge
		/// of the input image, but is within a half voxel width of the edge
		/// (using the input voxel width), then the value of the output voxel
		/// is calculated as if the input's edge voxels were duplicated past
		/// the edges of the input.
		/// This has no effect if Mirror or Wrap are on.
		/// </summary>
		// Token: 0x0600D634 RID: 54836 RVA: 0x0012A190 File Offset: 0x00128390
		public virtual void BorderOn()
		{
			vtkImageReslice.vtkImageReslice_BorderOn_04(base.GetCppThis());
		}

		// Token: 0x0600D635 RID: 54837
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_GenerateStencilOutputOff_05(HandleRef pThis);

		/// <summary>
		/// Generate an output stencil that defines which pixels were
		/// interpolated and which pixels were out-of-bounds of the input.
		/// </summary>
		// Token: 0x0600D636 RID: 54838 RVA: 0x0012A19F File Offset: 0x0012839F
		public virtual void GenerateStencilOutputOff()
		{
			vtkImageReslice.vtkImageReslice_GenerateStencilOutputOff_05(base.GetCppThis());
		}

		// Token: 0x0600D637 RID: 54839
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_GenerateStencilOutputOn_06(HandleRef pThis);

		/// <summary>
		/// Generate an output stencil that defines which pixels were
		/// interpolated and which pixels were out-of-bounds of the input.
		/// </summary>
		// Token: 0x0600D638 RID: 54840 RVA: 0x0012A1AE File Offset: 0x001283AE
		public virtual void GenerateStencilOutputOn()
		{
			vtkImageReslice.vtkImageReslice_GenerateStencilOutputOn_06(base.GetCppThis());
		}

		// Token: 0x0600D639 RID: 54841
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReslice_GetAutoCropOutput_07(HandleRef pThis);

		/// <summary>
		/// Turn this on if you want to guarantee that the extent of the
		/// output will be large enough to ensure that none of the
		/// data will be cropped (default: Off).
		/// </summary>
		// Token: 0x0600D63A RID: 54842 RVA: 0x0012A1C0 File Offset: 0x001283C0
		public virtual int GetAutoCropOutput()
		{
			return vtkImageReslice.vtkImageReslice_GetAutoCropOutput_07(base.GetCppThis());
		}

		// Token: 0x0600D63B RID: 54843
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_GetBackgroundColor_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		/// <summary>
		/// Set the background color (for multi-component images).
		/// </summary>
		// Token: 0x0600D63C RID: 54844 RVA: 0x0012A1DF File Offset: 0x001283DF
		public virtual void GetBackgroundColor(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkImageReslice.vtkImageReslice_GetBackgroundColor_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x0600D63D RID: 54845
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_GetBackgroundColor_09(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the background color (for multi-component images).
		/// </summary>
		// Token: 0x0600D63E RID: 54846 RVA: 0x0012A1F3 File Offset: 0x001283F3
		public virtual void GetBackgroundColor(IntPtr _arg)
		{
			vtkImageReslice.vtkImageReslice_GetBackgroundColor_09(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D63F RID: 54847
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReslice_GetBackgroundColor_10(HandleRef pThis);

		/// <summary>
		/// Set the background color (for multi-component images).
		/// </summary>
		// Token: 0x0600D640 RID: 54848 RVA: 0x0012A204 File Offset: 0x00128404
		public virtual double[] GetBackgroundColor()
		{
			IntPtr intPtr = vtkImageReslice.vtkImageReslice_GetBackgroundColor_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600D641 RID: 54849
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageReslice_GetBackgroundLevel_11(HandleRef pThis);

		/// <summary>
		/// Set background grey level (for single-component images).
		/// </summary>
		// Token: 0x0600D642 RID: 54850 RVA: 0x0012A24C File Offset: 0x0012844C
		public double GetBackgroundLevel()
		{
			return vtkImageReslice.vtkImageReslice_GetBackgroundLevel_11(base.GetCppThis());
		}

		// Token: 0x0600D643 RID: 54851
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReslice_GetBorder_12(HandleRef pThis);

		/// <summary>
		/// Extend the apparent input border by a half voxel (default: On).
		/// This changes how interpolation is handled at the borders of the
		/// input image: if the center of an output voxel is beyond the edge
		/// of the input image, but is within a half voxel width of the edge
		/// (using the input voxel width), then the value of the output voxel
		/// is calculated as if the input's edge voxels were duplicated past
		/// the edges of the input.
		/// This has no effect if Mirror or Wrap are on.
		/// </summary>
		// Token: 0x0600D644 RID: 54852 RVA: 0x0012A26C File Offset: 0x0012846C
		public virtual int GetBorder()
		{
			return vtkImageReslice.vtkImageReslice_GetBorder_12(base.GetCppThis());
		}

		// Token: 0x0600D645 RID: 54853
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageReslice_GetBorderThickness_13(HandleRef pThis);

		/// <summary>
		/// Set the border thickness for BorderOn() (default: 0.5).
		/// See SetBorder() for more information.
		/// </summary>
		// Token: 0x0600D646 RID: 54854 RVA: 0x0012A28C File Offset: 0x0012848C
		public virtual double GetBorderThickness()
		{
			return vtkImageReslice.vtkImageReslice_GetBorderThickness_13(base.GetCppThis());
		}

		// Token: 0x0600D647 RID: 54855
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReslice_GetGenerateStencilOutput_14(HandleRef pThis);

		/// <summary>
		/// Generate an output stencil that defines which pixels were
		/// interpolated and which pixels were out-of-bounds of the input.
		/// </summary>
		// Token: 0x0600D648 RID: 54856 RVA: 0x0012A2AC File Offset: 0x001284AC
		public virtual int GetGenerateStencilOutput()
		{
			return vtkImageReslice.vtkImageReslice_GetGenerateStencilOutput_14(base.GetCppThis());
		}

		// Token: 0x0600D649 RID: 54857
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReslice_GetInformationInput_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set a vtkImageData from which the default Spacing, Origin,
		/// and WholeExtent of the output will be copied.  The spacing,
		/// origin, and extent will be permuted according to the
		/// ResliceAxes.  Any values set via SetOutputSpacing,
		/// SetOutputOrigin, and SetOutputExtent will override these
		/// values.  By default, the Spacing, Origin, and WholeExtent
		/// of the Input are used.
		/// </summary>
		// Token: 0x0600D64A RID: 54858 RVA: 0x0012A2CC File Offset: 0x001284CC
		public virtual vtkImageData GetInformationInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageReslice.vtkImageReslice_GetInformationInput_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x0600D64B RID: 54859
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReslice_GetInterpolate_16(HandleRef pThis);

		/// <summary>
		/// Convenient methods for switching between nearest-neighbor and linear
		/// interpolation.
		/// InterpolateOn() is equivalent to SetInterpolationModeToLinear() and
		/// InterpolateOff() is equivalent to SetInterpolationModeToNearestNeighbor()
		/// You should not use these methods if you use the SetInterpolationMode
		/// methods.
		/// </summary>
		// Token: 0x0600D64C RID: 54860 RVA: 0x0012A33C File Offset: 0x0012853C
		public int GetInterpolate()
		{
			return vtkImageReslice.vtkImageReslice_GetInterpolate_16(base.GetCppThis());
		}

		// Token: 0x0600D64D RID: 54861
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReslice_GetInterpolationMode_17(HandleRef pThis);

		/// <summary>
		/// Set interpolation mode (default: nearest neighbor).
		/// </summary>
		// Token: 0x0600D64E RID: 54862 RVA: 0x0012A35C File Offset: 0x0012855C
		public virtual int GetInterpolationMode()
		{
			return vtkImageReslice.vtkImageReslice_GetInterpolationMode_17(base.GetCppThis());
		}

		// Token: 0x0600D64F RID: 54863
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReslice_GetInterpolationModeAsString_18(HandleRef pThis);

		/// <summary>
		/// Set interpolation mode (default: nearest neighbor).
		/// </summary>
		// Token: 0x0600D650 RID: 54864 RVA: 0x0012A37C File Offset: 0x0012857C
		public virtual string GetInterpolationModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageReslice.vtkImageReslice_GetInterpolationModeAsString_18(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600D651 RID: 54865
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReslice_GetInterpolationModeMaxValue_19(HandleRef pThis);

		/// <summary>
		/// Set interpolation mode (default: nearest neighbor).
		/// </summary>
		// Token: 0x0600D652 RID: 54866 RVA: 0x0012A3B8 File Offset: 0x001285B8
		public virtual int GetInterpolationModeMaxValue()
		{
			return vtkImageReslice.vtkImageReslice_GetInterpolationModeMaxValue_19(base.GetCppThis());
		}

		// Token: 0x0600D653 RID: 54867
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReslice_GetInterpolationModeMinValue_20(HandleRef pThis);

		/// <summary>
		/// Set interpolation mode (default: nearest neighbor).
		/// </summary>
		// Token: 0x0600D654 RID: 54868 RVA: 0x0012A3D8 File Offset: 0x001285D8
		public virtual int GetInterpolationModeMinValue()
		{
			return vtkImageReslice.vtkImageReslice_GetInterpolationModeMinValue_20(base.GetCppThis());
		}

		// Token: 0x0600D655 RID: 54869
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReslice_GetInterpolator_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the interpolator to use.  The default interpolator
		/// supports the Nearest, Linear, and Cubic interpolation modes.
		/// </summary>
		// Token: 0x0600D656 RID: 54870 RVA: 0x0012A3F8 File Offset: 0x001285F8
		public virtual vtkAbstractImageInterpolator GetInterpolator()
		{
			vtkAbstractImageInterpolator vtkAbstractImageInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageReslice.vtkImageReslice_GetInterpolator_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600D657 RID: 54871
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkImageReslice_GetMTime_22(HandleRef pThis);

		/// <summary>
		/// When determining the modified time of the filter,
		/// this check the modified time of the transform and matrix.
		/// </summary>
		// Token: 0x0600D658 RID: 54872 RVA: 0x0012A468 File Offset: 0x00128668
		public override ulong GetMTime()
		{
			return vtkImageReslice.vtkImageReslice_GetMTime_22(base.GetCppThis());
		}

		// Token: 0x0600D659 RID: 54873
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReslice_GetMirror_23(HandleRef pThis);

		/// <summary>
		/// Turn on mirror-pad feature (default: Off).
		/// This will override the wrap-pad.
		/// </summary>
		// Token: 0x0600D65A RID: 54874 RVA: 0x0012A488 File Offset: 0x00128688
		public virtual int GetMirror()
		{
			return vtkImageReslice.vtkImageReslice_GetMirror_23(base.GetCppThis());
		}

		// Token: 0x0600D65B RID: 54875
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageReslice_GetNumberOfGenerationsFromBase_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D65C RID: 54876 RVA: 0x0012A4A8 File Offset: 0x001286A8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageReslice.vtkImageReslice_GetNumberOfGenerationsFromBase_24(base.GetCppThis(), type);
		}

		// Token: 0x0600D65D RID: 54877
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageReslice_GetNumberOfGenerationsFromBaseType_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D65E RID: 54878 RVA: 0x0012A4C8 File Offset: 0x001286C8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageReslice.vtkImageReslice_GetNumberOfGenerationsFromBaseType_25(type);
		}

		// Token: 0x0600D65F RID: 54879
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReslice_GetOptimization_26(HandleRef pThis);

		/// <summary>
		/// Turn on and off optimizations (default on, they should only be
		/// turned off for testing purposes).
		/// </summary>
		// Token: 0x0600D660 RID: 54880 RVA: 0x0012A4E4 File Offset: 0x001286E4
		public virtual int GetOptimization()
		{
			return vtkImageReslice.vtkImageReslice_GetOptimization_26(base.GetCppThis());
		}

		// Token: 0x0600D661 RID: 54881
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReslice_GetOutputDimensionality_27(HandleRef pThis);

		/// <summary>
		/// Force the dimensionality of the output to either 1, 2,
		/// 3 or 0 (default: 3).  If the dimensionality is 2D, then
		/// the Z extent of the output is forced to (0,0) and the Z
		/// origin of the output is forced to 0.0 (i.e. the output
		/// extent is confined to the xy plane).  If the dimensionality
		/// is 1D, the output extent is confined to the x axis.
		/// For 0D, the output extent consists of a single voxel at
		/// (0,0,0).
		/// </summary>
		// Token: 0x0600D662 RID: 54882 RVA: 0x0012A504 File Offset: 0x00128704
		public virtual int GetOutputDimensionality()
		{
			return vtkImageReslice.vtkImageReslice_GetOutputDimensionality_27(base.GetCppThis());
		}

		// Token: 0x0600D663 RID: 54883
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReslice_GetOutputDirection_28(HandleRef pThis);

		/// <summary>
		/// Set the direction for the output data.  By default, the direction of
		/// the input data is passed to the output.  But if SetOutputDirection()
		/// is used, then the image will be resliced according to the new output
		/// direction.  Unlike SetResliceAxes(), this does not change the physical
		/// coordinate system for the image.  Instead, it changes the orientation
		/// of the sampling grid while maintaining the same physical coordinate
		/// system.
		/// </summary>
		// Token: 0x0600D664 RID: 54884 RVA: 0x0012A524 File Offset: 0x00128724
		public virtual double[] GetOutputDirection()
		{
			IntPtr intPtr = vtkImageReslice.vtkImageReslice_GetOutputDirection_28(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600D665 RID: 54885
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_GetOutputDirection_29(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set the direction for the output data.  By default, the direction of
		/// the input data is passed to the output.  But if SetOutputDirection()
		/// is used, then the image will be resliced according to the new output
		/// direction.  Unlike SetResliceAxes(), this does not change the physical
		/// coordinate system for the image.  Instead, it changes the orientation
		/// of the sampling grid while maintaining the same physical coordinate
		/// system.
		/// </summary>
		// Token: 0x0600D666 RID: 54886 RVA: 0x0012A56C File Offset: 0x0012876C
		public virtual void GetOutputDirection(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageReslice.vtkImageReslice_GetOutputDirection_29(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600D667 RID: 54887
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_GetOutputDirection_30(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the direction for the output data.  By default, the direction of
		/// the input data is passed to the output.  But if SetOutputDirection()
		/// is used, then the image will be resliced according to the new output
		/// direction.  Unlike SetResliceAxes(), this does not change the physical
		/// coordinate system for the image.  Instead, it changes the orientation
		/// of the sampling grid while maintaining the same physical coordinate
		/// system.
		/// </summary>
		// Token: 0x0600D668 RID: 54888 RVA: 0x0012A57E File Offset: 0x0012877E
		public virtual void GetOutputDirection(IntPtr _arg)
		{
			vtkImageReslice.vtkImageReslice_GetOutputDirection_30(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D669 RID: 54889
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReslice_GetOutputExtent_31(HandleRef pThis);

		/// <summary>
		/// Set the extent for the output data.  The default output extent
		/// is the input extent permuted through the ResliceAxes.
		/// </summary>
		// Token: 0x0600D66A RID: 54890 RVA: 0x0012A590 File Offset: 0x00128790
		public virtual int[] GetOutputExtent()
		{
			IntPtr intPtr = vtkImageReslice.vtkImageReslice_GetOutputExtent_31(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600D66B RID: 54891
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_GetOutputExtent_32(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		/// Set the extent for the output data.  The default output extent
		/// is the input extent permuted through the ResliceAxes.
		/// </summary>
		// Token: 0x0600D66C RID: 54892 RVA: 0x0012A5D8 File Offset: 0x001287D8
		public virtual void GetOutputExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkImageReslice.vtkImageReslice_GetOutputExtent_32(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x0600D66D RID: 54893
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_GetOutputExtent_33(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the extent for the output data.  The default output extent
		/// is the input extent permuted through the ResliceAxes.
		/// </summary>
		// Token: 0x0600D66E RID: 54894 RVA: 0x0012A5F0 File Offset: 0x001287F0
		public virtual void GetOutputExtent(IntPtr _arg)
		{
			vtkImageReslice.vtkImageReslice_GetOutputExtent_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D66F RID: 54895
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReslice_GetOutputOrigin_34(HandleRef pThis);

		/// <summary>
		/// Set the origin for the output data.  The default output origin
		/// is the input origin permuted through the ResliceAxes.
		/// </summary>
		// Token: 0x0600D670 RID: 54896 RVA: 0x0012A600 File Offset: 0x00128800
		public virtual double[] GetOutputOrigin()
		{
			IntPtr intPtr = vtkImageReslice.vtkImageReslice_GetOutputOrigin_34(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600D671 RID: 54897
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_GetOutputOrigin_35(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set the origin for the output data.  The default output origin
		/// is the input origin permuted through the ResliceAxes.
		/// </summary>
		// Token: 0x0600D672 RID: 54898 RVA: 0x0012A648 File Offset: 0x00128848
		public virtual void GetOutputOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageReslice.vtkImageReslice_GetOutputOrigin_35(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600D673 RID: 54899
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_GetOutputOrigin_36(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the origin for the output data.  The default output origin
		/// is the input origin permuted through the ResliceAxes.
		/// </summary>
		// Token: 0x0600D674 RID: 54900 RVA: 0x0012A65A File Offset: 0x0012885A
		public virtual void GetOutputOrigin(IntPtr _arg)
		{
			vtkImageReslice.vtkImageReslice_GetOutputOrigin_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D675 RID: 54901
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReslice_GetOutputScalarType_37(HandleRef pThis);

		/// <summary>
		/// Set the scalar type of the output to be different from the input.
		/// The default value is -1, which means that the input scalar type will be
		/// used to set the output scalar type.  Otherwise, this must be set to one
		/// of the following types: VTK_CHAR, VTK_SIGNED_CHAR, VTK_UNSIGNED_CHAR,
		/// VTK_SHORT, VTK_UNSIGNED_SHORT, VTK_INT, VTK_UNSIGNED_INT, VTK_FLOAT,
		/// or VTK_DOUBLE.  Other types are not permitted.  If the output type
		/// is an integer type, the output will be rounded and clamped to the
		/// limits of the type.
		/// </summary>
		// Token: 0x0600D676 RID: 54902 RVA: 0x0012A66C File Offset: 0x0012886C
		public virtual int GetOutputScalarType()
		{
			return vtkImageReslice.vtkImageReslice_GetOutputScalarType_37(base.GetCppThis());
		}

		// Token: 0x0600D677 RID: 54903
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReslice_GetOutputSpacing_38(HandleRef pThis);

		/// <summary>
		/// Set the voxel spacing for the output data.  The default output
		/// spacing is the input spacing permuted through the ResliceAxes.
		/// </summary>
		// Token: 0x0600D678 RID: 54904 RVA: 0x0012A68C File Offset: 0x0012888C
		public virtual double[] GetOutputSpacing()
		{
			IntPtr intPtr = vtkImageReslice.vtkImageReslice_GetOutputSpacing_38(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600D679 RID: 54905
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_GetOutputSpacing_39(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set the voxel spacing for the output data.  The default output
		/// spacing is the input spacing permuted through the ResliceAxes.
		/// </summary>
		// Token: 0x0600D67A RID: 54906 RVA: 0x0012A6D4 File Offset: 0x001288D4
		public virtual void GetOutputSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageReslice.vtkImageReslice_GetOutputSpacing_39(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600D67B RID: 54907
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_GetOutputSpacing_40(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the voxel spacing for the output data.  The default output
		/// spacing is the input spacing permuted through the ResliceAxes.
		/// </summary>
		// Token: 0x0600D67C RID: 54908 RVA: 0x0012A6E6 File Offset: 0x001288E6
		public virtual void GetOutputSpacing(IntPtr _arg)
		{
			vtkImageReslice.vtkImageReslice_GetOutputSpacing_40(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D67D RID: 54909
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReslice_GetResliceAxes_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This method is used to set up the axes for the output voxels.
		/// The output Spacing, Origin, and Extent specify the locations
		/// of the voxels within the coordinate system defined by the axes.
		/// The ResliceAxes are used most often to permute the data, e.g.
		/// to extract ZY or XZ slices of a volume as 2D XY images.
		/// &lt;p&gt;The first column of the matrix specifies the x-axis
		/// vector (the fourth element must be set to zero), the second
		/// column specifies the y-axis, and the third column the
		/// z-axis.  The fourth column is the origin of the
		/// axes (the fourth element must be set to one).
		/// &lt;p&gt;An alternative to SetResliceAxes() is to use
		/// SetResliceAxesDirectionCosines() to set the directions of the
		/// axes and SetResliceAxesOrigin() to set the origin of the axes.
		/// </summary>
		// Token: 0x0600D67E RID: 54910 RVA: 0x0012A6F8 File Offset: 0x001288F8
		public virtual vtkMatrix4x4 GetResliceAxes()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageReslice.vtkImageReslice_GetResliceAxes_41(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x0600D67F RID: 54911
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_GetResliceAxesDirectionCosines_42(HandleRef pThis, IntPtr x, IntPtr y, IntPtr z);

		/// <summary>
		/// Specify the direction cosines for the ResliceAxes (i.e. the
		/// first three elements of each of the first three columns of
		/// the ResliceAxes matrix).  This will modify the current
		/// ResliceAxes matrix, or create a new matrix if none exists.
		/// </summary>
		// Token: 0x0600D680 RID: 54912 RVA: 0x0012A767 File Offset: 0x00128967
		public void GetResliceAxesDirectionCosines(IntPtr x, IntPtr y, IntPtr z)
		{
			vtkImageReslice.vtkImageReslice_GetResliceAxesDirectionCosines_42(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0600D681 RID: 54913
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_GetResliceAxesDirectionCosines_43(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// Specify the direction cosines for the ResliceAxes (i.e. the
		/// first three elements of each of the first three columns of
		/// the ResliceAxes matrix).  This will modify the current
		/// ResliceAxes matrix, or create a new matrix if none exists.
		/// </summary>
		// Token: 0x0600D682 RID: 54914 RVA: 0x0012A779 File Offset: 0x00128979
		public void GetResliceAxesDirectionCosines(IntPtr xyz)
		{
			vtkImageReslice.vtkImageReslice_GetResliceAxesDirectionCosines_43(base.GetCppThis(), xyz);
		}

		// Token: 0x0600D683 RID: 54915
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReslice_GetResliceAxesDirectionCosines_44(HandleRef pThis);

		/// <summary>
		/// Specify the direction cosines for the ResliceAxes (i.e. the
		/// first three elements of each of the first three columns of
		/// the ResliceAxes matrix).  This will modify the current
		/// ResliceAxes matrix, or create a new matrix if none exists.
		/// </summary>
		// Token: 0x0600D684 RID: 54916 RVA: 0x0012A78C File Offset: 0x0012898C
		public double[] GetResliceAxesDirectionCosines()
		{
			IntPtr intPtr = vtkImageReslice.vtkImageReslice_GetResliceAxesDirectionCosines_44(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[9];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600D685 RID: 54917
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_GetResliceAxesOrigin_45(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// Specify the origin for the ResliceAxes (i.e. the first three
		/// elements of the final column of the ResliceAxes matrix).
		/// This will modify the current ResliceAxes matrix, or create
		/// new matrix if none exists.
		/// </summary>
		// Token: 0x0600D686 RID: 54918 RVA: 0x0012A7D5 File Offset: 0x001289D5
		public void GetResliceAxesOrigin(IntPtr xyz)
		{
			vtkImageReslice.vtkImageReslice_GetResliceAxesOrigin_45(base.GetCppThis(), xyz);
		}

		// Token: 0x0600D687 RID: 54919
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReslice_GetResliceAxesOrigin_46(HandleRef pThis);

		/// <summary>
		/// Specify the origin for the ResliceAxes (i.e. the first three
		/// elements of the final column of the ResliceAxes matrix).
		/// This will modify the current ResliceAxes matrix, or create
		/// new matrix if none exists.
		/// </summary>
		// Token: 0x0600D688 RID: 54920 RVA: 0x0012A7E8 File Offset: 0x001289E8
		public double[] GetResliceAxesOrigin()
		{
			IntPtr intPtr = vtkImageReslice.vtkImageReslice_GetResliceAxesOrigin_46(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600D689 RID: 54921
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReslice_GetResliceTransform_47(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set a transform to be applied to the resampling grid that has
		/// been defined via the ResliceAxes and the output Origin, Spacing
		/// and Extent.  Note that applying a transform to the resampling
		/// grid (which lies in the output coordinate system) is
		/// equivalent to applying the inverse of that transform to
		/// the input volume.  Nonlinear transforms such as vtkGridTransform
		/// and vtkThinPlateSplineTransform can be used here.
		/// </summary>
		// Token: 0x0600D68A RID: 54922 RVA: 0x0012A830 File Offset: 0x00128A30
		public virtual vtkAbstractTransform GetResliceTransform()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageReslice.vtkImageReslice_GetResliceTransform_47(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractTransform = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractTransform.Register(null);
				}
			}
			return vtkAbstractTransform;
		}

		// Token: 0x0600D68B RID: 54923
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageReslice_GetScalarScale_48(HandleRef pThis);

		/// <summary>
		/// Set multiplication factor to apply to all the output voxels.
		/// After a sample value has been interpolated from the input image, the
		/// equation u = (v + ScalarShift)*ScalarScale will be applied to it before
		/// it is written to the output image.  The result will always be clamped to
		/// the limits of the output data type.
		/// </summary>
		// Token: 0x0600D68C RID: 54924 RVA: 0x0012A8A0 File Offset: 0x00128AA0
		public virtual double GetScalarScale()
		{
			return vtkImageReslice.vtkImageReslice_GetScalarScale_48(base.GetCppThis());
		}

		// Token: 0x0600D68D RID: 54925
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageReslice_GetScalarShift_49(HandleRef pThis);

		/// <summary>
		/// Set a value to add to all the output voxels.
		/// After a sample value has been interpolated from the input image, the
		/// equation u = (v + ScalarShift)*ScalarScale will be applied to it before
		/// it is written to the output image.  The result will always be clamped to
		/// the limits of the output data type.
		/// </summary>
		// Token: 0x0600D68E RID: 54926 RVA: 0x0012A8C0 File Offset: 0x00128AC0
		public virtual double GetScalarShift()
		{
			return vtkImageReslice.vtkImageReslice_GetScalarShift_49(base.GetCppThis());
		}

		// Token: 0x0600D68F RID: 54927
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReslice_GetSlabMode_50(HandleRef pThis);

		/// <summary>
		/// Set the slab mode, for generating thick slices. The default is Mean.
		/// If SetSlabNumberOfSlices(N) is called with N greater than one, then
		/// each output slice will actually be a composite of N slices.  This method
		/// specifies the compositing mode to be used.
		/// </summary>
		// Token: 0x0600D690 RID: 54928 RVA: 0x0012A8E0 File Offset: 0x00128AE0
		public virtual int GetSlabMode()
		{
			return vtkImageReslice.vtkImageReslice_GetSlabMode_50(base.GetCppThis());
		}

		// Token: 0x0600D691 RID: 54929
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReslice_GetSlabModeAsString_51(HandleRef pThis);

		/// <summary>
		/// Set the slab mode, for generating thick slices. The default is Mean.
		/// If SetSlabNumberOfSlices(N) is called with N greater than one, then
		/// each output slice will actually be a composite of N slices.  This method
		/// specifies the compositing mode to be used.
		/// </summary>
		// Token: 0x0600D692 RID: 54930 RVA: 0x0012A900 File Offset: 0x00128B00
		public virtual string GetSlabModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageReslice.vtkImageReslice_GetSlabModeAsString_51(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600D693 RID: 54931
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReslice_GetSlabModeMaxValue_52(HandleRef pThis);

		/// <summary>
		/// Set the slab mode, for generating thick slices. The default is Mean.
		/// If SetSlabNumberOfSlices(N) is called with N greater than one, then
		/// each output slice will actually be a composite of N slices.  This method
		/// specifies the compositing mode to be used.
		/// </summary>
		// Token: 0x0600D694 RID: 54932 RVA: 0x0012A93C File Offset: 0x00128B3C
		public virtual int GetSlabModeMaxValue()
		{
			return vtkImageReslice.vtkImageReslice_GetSlabModeMaxValue_52(base.GetCppThis());
		}

		// Token: 0x0600D695 RID: 54933
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReslice_GetSlabModeMinValue_53(HandleRef pThis);

		/// <summary>
		/// Set the slab mode, for generating thick slices. The default is Mean.
		/// If SetSlabNumberOfSlices(N) is called with N greater than one, then
		/// each output slice will actually be a composite of N slices.  This method
		/// specifies the compositing mode to be used.
		/// </summary>
		// Token: 0x0600D696 RID: 54934 RVA: 0x0012A95C File Offset: 0x00128B5C
		public virtual int GetSlabModeMinValue()
		{
			return vtkImageReslice.vtkImageReslice_GetSlabModeMinValue_53(base.GetCppThis());
		}

		// Token: 0x0600D697 RID: 54935
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReslice_GetSlabNumberOfSlices_54(HandleRef pThis);

		/// <summary>
		/// Set the number of slices that will be combined to create the slab.
		/// </summary>
		// Token: 0x0600D698 RID: 54936 RVA: 0x0012A97C File Offset: 0x00128B7C
		public virtual int GetSlabNumberOfSlices()
		{
			return vtkImageReslice.vtkImageReslice_GetSlabNumberOfSlices_54(base.GetCppThis());
		}

		// Token: 0x0600D699 RID: 54937
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageReslice_GetSlabSliceSpacingFraction_55(HandleRef pThis);

		/// <summary>
		/// The slab spacing as a fraction of the output slice spacing.
		/// When one of the various slab modes is chosen, each output slice is
		/// produced by generating several "temporary" output slices and then
		/// combining them according to the slab mode.  By default, the spacing
		/// between these temporary slices is the Z component of the OutputSpacing.
		/// This method sets the spacing between these temporary slices to be a
		/// fraction of the output spacing.
		/// </summary>
		// Token: 0x0600D69A RID: 54938 RVA: 0x0012A99C File Offset: 0x00128B9C
		public virtual double GetSlabSliceSpacingFraction()
		{
			return vtkImageReslice.vtkImageReslice_GetSlabSliceSpacingFraction_55(base.GetCppThis());
		}

		// Token: 0x0600D69B RID: 54939
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReslice_GetSlabTrapezoidIntegration_56(HandleRef pThis);

		/// <summary>
		/// Use trapezoid integration for slab computation.  All this does is
		/// weigh the first and last slices by half when doing sum and mean.
		/// It is off by default.
		/// </summary>
		// Token: 0x0600D69C RID: 54940 RVA: 0x0012A9BC File Offset: 0x00128BBC
		public virtual int GetSlabTrapezoidIntegration()
		{
			return vtkImageReslice.vtkImageReslice_GetSlabTrapezoidIntegration_56(base.GetCppThis());
		}

		// Token: 0x0600D69D RID: 54941
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReslice_GetStencil_57(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Use a stencil to limit the calculations to a specific region of
		/// the output.  Portions of the output that are 'outside' the stencil
		/// will be cleared to the background color.
		/// </summary>
		// Token: 0x0600D69E RID: 54942 RVA: 0x0012A9DC File Offset: 0x00128BDC
		public vtkImageStencilData GetStencil()
		{
			vtkImageStencilData vtkImageStencilData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageReslice.vtkImageReslice_GetStencil_57(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageStencilData = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageStencilData.Register(null);
				}
			}
			return vtkImageStencilData;
		}

		// Token: 0x0600D69F RID: 54943
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReslice_GetStencilOutput_58(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output stencil.
		/// </summary>
		// Token: 0x0600D6A0 RID: 54944 RVA: 0x0012AA4C File Offset: 0x00128C4C
		public vtkImageStencilData GetStencilOutput()
		{
			vtkImageStencilData vtkImageStencilData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageReslice.vtkImageReslice_GetStencilOutput_58(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageStencilData = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageStencilData.Register(null);
				}
			}
			return vtkImageStencilData;
		}

		// Token: 0x0600D6A1 RID: 54945
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReslice_GetStencilOutputPort_59(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output stencil.
		/// </summary>
		// Token: 0x0600D6A2 RID: 54946 RVA: 0x0012AABC File Offset: 0x00128CBC
		public vtkAlgorithmOutput GetStencilOutputPort()
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageReslice.vtkImageReslice_GetStencilOutputPort_59(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		// Token: 0x0600D6A3 RID: 54947
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReslice_GetTransformInputSampling_60(HandleRef pThis);

		/// <summary>
		/// Specify whether to transform the spacing, origin and extent
		/// of the Input (or the InformationInput) according to the
		/// direction cosines and origin of the ResliceAxes before applying
		/// them as the default output spacing, origin and extent
		/// (default: On).
		/// </summary>
		// Token: 0x0600D6A4 RID: 54948 RVA: 0x0012AB2C File Offset: 0x00128D2C
		public virtual int GetTransformInputSampling()
		{
			return vtkImageReslice.vtkImageReslice_GetTransformInputSampling_60(base.GetCppThis());
		}

		// Token: 0x0600D6A5 RID: 54949
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReslice_GetWrap_61(HandleRef pThis);

		/// <summary>
		/// Turn on wrap-pad feature (default: Off).
		/// </summary>
		// Token: 0x0600D6A6 RID: 54950 RVA: 0x0012AB4C File Offset: 0x00128D4C
		public virtual int GetWrap()
		{
			return vtkImageReslice.vtkImageReslice_GetWrap_61(base.GetCppThis());
		}

		// Token: 0x0600D6A7 RID: 54951
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_InterpolateOff_62(HandleRef pThis);

		/// <summary>
		/// Convenient methods for switching between nearest-neighbor and linear
		/// interpolation.
		/// InterpolateOn() is equivalent to SetInterpolationModeToLinear() and
		/// InterpolateOff() is equivalent to SetInterpolationModeToNearestNeighbor()
		/// You should not use these methods if you use the SetInterpolationMode
		/// methods.
		/// </summary>
		// Token: 0x0600D6A8 RID: 54952 RVA: 0x0012AB6B File Offset: 0x00128D6B
		public void InterpolateOff()
		{
			vtkImageReslice.vtkImageReslice_InterpolateOff_62(base.GetCppThis());
		}

		// Token: 0x0600D6A9 RID: 54953
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_InterpolateOn_63(HandleRef pThis);

		/// <summary>
		/// Convenient methods for switching between nearest-neighbor and linear
		/// interpolation.
		/// InterpolateOn() is equivalent to SetInterpolationModeToLinear() and
		/// InterpolateOff() is equivalent to SetInterpolationModeToNearestNeighbor()
		/// You should not use these methods if you use the SetInterpolationMode
		/// methods.
		/// </summary>
		// Token: 0x0600D6AA RID: 54954 RVA: 0x0012AB7A File Offset: 0x00128D7A
		public void InterpolateOn()
		{
			vtkImageReslice.vtkImageReslice_InterpolateOn_63(base.GetCppThis());
		}

		// Token: 0x0600D6AB RID: 54955
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReslice_IsA_64(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D6AC RID: 54956 RVA: 0x0012AB8C File Offset: 0x00128D8C
		public override int IsA(string type)
		{
			return vtkImageReslice.vtkImageReslice_IsA_64(base.GetCppThis(), type);
		}

		// Token: 0x0600D6AD RID: 54957
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReslice_IsTypeOf_65([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D6AE RID: 54958 RVA: 0x0012ABAC File Offset: 0x00128DAC
		public new static int IsTypeOf(string type)
		{
			return vtkImageReslice.vtkImageReslice_IsTypeOf_65(type);
		}

		// Token: 0x0600D6AF RID: 54959
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_MirrorOff_66(HandleRef pThis);

		/// <summary>
		/// Turn on mirror-pad feature (default: Off).
		/// This will override the wrap-pad.
		/// </summary>
		// Token: 0x0600D6B0 RID: 54960 RVA: 0x0012ABC6 File Offset: 0x00128DC6
		public virtual void MirrorOff()
		{
			vtkImageReslice.vtkImageReslice_MirrorOff_66(base.GetCppThis());
		}

		// Token: 0x0600D6B1 RID: 54961
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_MirrorOn_67(HandleRef pThis);

		/// <summary>
		/// Turn on mirror-pad feature (default: Off).
		/// This will override the wrap-pad.
		/// </summary>
		// Token: 0x0600D6B2 RID: 54962 RVA: 0x0012ABD5 File Offset: 0x00128DD5
		public virtual void MirrorOn()
		{
			vtkImageReslice.vtkImageReslice_MirrorOn_67(base.GetCppThis());
		}

		// Token: 0x0600D6B3 RID: 54963
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReslice_NewInstance_69(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D6B4 RID: 54964 RVA: 0x0012ABE4 File Offset: 0x00128DE4
		public new vtkImageReslice NewInstance()
		{
			vtkImageReslice result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageReslice.vtkImageReslice_NewInstance_69(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageReslice)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D6B5 RID: 54965
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_OptimizationOff_70(HandleRef pThis);

		/// <summary>
		/// Turn on and off optimizations (default on, they should only be
		/// turned off for testing purposes).
		/// </summary>
		// Token: 0x0600D6B6 RID: 54966 RVA: 0x0012AC3E File Offset: 0x00128E3E
		public virtual void OptimizationOff()
		{
			vtkImageReslice.vtkImageReslice_OptimizationOff_70(base.GetCppThis());
		}

		// Token: 0x0600D6B7 RID: 54967
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_OptimizationOn_71(HandleRef pThis);

		/// <summary>
		/// Turn on and off optimizations (default on, they should only be
		/// turned off for testing purposes).
		/// </summary>
		// Token: 0x0600D6B8 RID: 54968 RVA: 0x0012AC4D File Offset: 0x00128E4D
		public virtual void OptimizationOn()
		{
			vtkImageReslice.vtkImageReslice_OptimizationOn_71(base.GetCppThis());
		}

		// Token: 0x0600D6B9 RID: 54969
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_ReportReferences_72(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Report object referenced by instances of this class.
		/// </summary>
		// Token: 0x0600D6BA RID: 54970 RVA: 0x0012AC5C File Offset: 0x00128E5C
		public virtual void ReportReferences(vtkGarbageCollector arg0)
		{
			vtkImageReslice.vtkImageReslice_ReportReferences_72(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600D6BB RID: 54971
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReslice_SafeDownCast_73(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D6BC RID: 54972 RVA: 0x0012AC8C File Offset: 0x00128E8C
		public new static vtkImageReslice SafeDownCast(vtkObjectBase o)
		{
			vtkImageReslice vtkImageReslice = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageReslice.vtkImageReslice_SafeDownCast_73((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageReslice = (vtkImageReslice)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageReslice.Register(null);
				}
			}
			return vtkImageReslice;
		}

		// Token: 0x0600D6BD RID: 54973
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetAutoCropOutput_74(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn this on if you want to guarantee that the extent of the
		/// output will be large enough to ensure that none of the
		/// data will be cropped (default: Off).
		/// </summary>
		// Token: 0x0600D6BE RID: 54974 RVA: 0x0012AD0B File Offset: 0x00128F0B
		public virtual void SetAutoCropOutput(int _arg)
		{
			vtkImageReslice.vtkImageReslice_SetAutoCropOutput_74(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D6BF RID: 54975
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetBackgroundColor_75(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		/// <summary>
		/// Set the background color (for multi-component images).
		/// </summary>
		// Token: 0x0600D6C0 RID: 54976 RVA: 0x0012AD1B File Offset: 0x00128F1B
		public virtual void SetBackgroundColor(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkImageReslice.vtkImageReslice_SetBackgroundColor_75(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x0600D6C1 RID: 54977
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetBackgroundColor_76(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the background color (for multi-component images).
		/// </summary>
		// Token: 0x0600D6C2 RID: 54978 RVA: 0x0012AD2F File Offset: 0x00128F2F
		public virtual void SetBackgroundColor(IntPtr _arg)
		{
			vtkImageReslice.vtkImageReslice_SetBackgroundColor_76(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D6C3 RID: 54979
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetBackgroundLevel_77(HandleRef pThis, double v);

		/// <summary>
		/// Set background grey level (for single-component images).
		/// </summary>
		// Token: 0x0600D6C4 RID: 54980 RVA: 0x0012AD3F File Offset: 0x00128F3F
		public void SetBackgroundLevel(double v)
		{
			vtkImageReslice.vtkImageReslice_SetBackgroundLevel_77(base.GetCppThis(), v);
		}

		// Token: 0x0600D6C5 RID: 54981
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetBorder_78(HandleRef pThis, int _arg);

		/// <summary>
		/// Extend the apparent input border by a half voxel (default: On).
		/// This changes how interpolation is handled at the borders of the
		/// input image: if the center of an output voxel is beyond the edge
		/// of the input image, but is within a half voxel width of the edge
		/// (using the input voxel width), then the value of the output voxel
		/// is calculated as if the input's edge voxels were duplicated past
		/// the edges of the input.
		/// This has no effect if Mirror or Wrap are on.
		/// </summary>
		// Token: 0x0600D6C6 RID: 54982 RVA: 0x0012AD4F File Offset: 0x00128F4F
		public virtual void SetBorder(int _arg)
		{
			vtkImageReslice.vtkImageReslice_SetBorder_78(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D6C7 RID: 54983
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetBorderThickness_79(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the border thickness for BorderOn() (default: 0.5).
		/// See SetBorder() for more information.
		/// </summary>
		// Token: 0x0600D6C8 RID: 54984 RVA: 0x0012AD5F File Offset: 0x00128F5F
		public virtual void SetBorderThickness(double _arg)
		{
			vtkImageReslice.vtkImageReslice_SetBorderThickness_79(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D6C9 RID: 54985
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetGenerateStencilOutput_80(HandleRef pThis, int _arg);

		/// <summary>
		/// Generate an output stencil that defines which pixels were
		/// interpolated and which pixels were out-of-bounds of the input.
		/// </summary>
		// Token: 0x0600D6CA RID: 54986 RVA: 0x0012AD6F File Offset: 0x00128F6F
		public virtual void SetGenerateStencilOutput(int _arg)
		{
			vtkImageReslice.vtkImageReslice_SetGenerateStencilOutput_80(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D6CB RID: 54987
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetInformationInput_81(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set a vtkImageData from which the default Spacing, Origin,
		/// and WholeExtent of the output will be copied.  The spacing,
		/// origin, and extent will be permuted according to the
		/// ResliceAxes.  Any values set via SetOutputSpacing,
		/// SetOutputOrigin, and SetOutputExtent will override these
		/// values.  By default, the Spacing, Origin, and WholeExtent
		/// of the Input are used.
		/// </summary>
		// Token: 0x0600D6CC RID: 54988 RVA: 0x0012AD80 File Offset: 0x00128F80
		public virtual void SetInformationInput(vtkImageData arg0)
		{
			vtkImageReslice.vtkImageReslice_SetInformationInput_81(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600D6CD RID: 54989
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetInterpolate_82(HandleRef pThis, int t);

		/// <summary>
		/// Convenient methods for switching between nearest-neighbor and linear
		/// interpolation.
		/// InterpolateOn() is equivalent to SetInterpolationModeToLinear() and
		/// InterpolateOff() is equivalent to SetInterpolationModeToNearestNeighbor()
		/// You should not use these methods if you use the SetInterpolationMode
		/// methods.
		/// </summary>
		// Token: 0x0600D6CE RID: 54990 RVA: 0x0012ADAF File Offset: 0x00128FAF
		public void SetInterpolate(int t)
		{
			vtkImageReslice.vtkImageReslice_SetInterpolate_82(base.GetCppThis(), t);
		}

		// Token: 0x0600D6CF RID: 54991
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetInterpolationMode_83(HandleRef pThis, int _arg);

		/// <summary>
		/// Set interpolation mode (default: nearest neighbor).
		/// </summary>
		// Token: 0x0600D6D0 RID: 54992 RVA: 0x0012ADBF File Offset: 0x00128FBF
		public virtual void SetInterpolationMode(int _arg)
		{
			vtkImageReslice.vtkImageReslice_SetInterpolationMode_83(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D6D1 RID: 54993
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetInterpolationModeToCubic_84(HandleRef pThis);

		/// <summary>
		/// Set interpolation mode (default: nearest neighbor).
		/// </summary>
		// Token: 0x0600D6D2 RID: 54994 RVA: 0x0012ADCF File Offset: 0x00128FCF
		public void SetInterpolationModeToCubic()
		{
			vtkImageReslice.vtkImageReslice_SetInterpolationModeToCubic_84(base.GetCppThis());
		}

		// Token: 0x0600D6D3 RID: 54995
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetInterpolationModeToLinear_85(HandleRef pThis);

		/// <summary>
		/// Set interpolation mode (default: nearest neighbor).
		/// </summary>
		// Token: 0x0600D6D4 RID: 54996 RVA: 0x0012ADDE File Offset: 0x00128FDE
		public void SetInterpolationModeToLinear()
		{
			vtkImageReslice.vtkImageReslice_SetInterpolationModeToLinear_85(base.GetCppThis());
		}

		// Token: 0x0600D6D5 RID: 54997
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetInterpolationModeToNearestNeighbor_86(HandleRef pThis);

		/// <summary>
		/// Set interpolation mode (default: nearest neighbor).
		/// </summary>
		// Token: 0x0600D6D6 RID: 54998 RVA: 0x0012ADED File Offset: 0x00128FED
		public void SetInterpolationModeToNearestNeighbor()
		{
			vtkImageReslice.vtkImageReslice_SetInterpolationModeToNearestNeighbor_86(base.GetCppThis());
		}

		// Token: 0x0600D6D7 RID: 54999
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetInterpolator_87(HandleRef pThis, HandleRef sampler);

		/// <summary>
		/// Set the interpolator to use.  The default interpolator
		/// supports the Nearest, Linear, and Cubic interpolation modes.
		/// </summary>
		// Token: 0x0600D6D8 RID: 55000 RVA: 0x0012ADFC File Offset: 0x00128FFC
		public virtual void SetInterpolator(vtkAbstractImageInterpolator sampler)
		{
			vtkImageReslice.vtkImageReslice_SetInterpolator_87(base.GetCppThis(), (sampler == null) ? default(HandleRef) : sampler.GetCppThis());
		}

		// Token: 0x0600D6D9 RID: 55001
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetMirror_88(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on mirror-pad feature (default: Off).
		/// This will override the wrap-pad.
		/// </summary>
		// Token: 0x0600D6DA RID: 55002 RVA: 0x0012AE2B File Offset: 0x0012902B
		public virtual void SetMirror(int _arg)
		{
			vtkImageReslice.vtkImageReslice_SetMirror_88(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D6DB RID: 55003
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetOptimization_89(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on and off optimizations (default on, they should only be
		/// turned off for testing purposes).
		/// </summary>
		// Token: 0x0600D6DC RID: 55004 RVA: 0x0012AE3B File Offset: 0x0012903B
		public virtual void SetOptimization(int _arg)
		{
			vtkImageReslice.vtkImageReslice_SetOptimization_89(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D6DD RID: 55005
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetOutputDimensionality_90(HandleRef pThis, int _arg);

		/// <summary>
		/// Force the dimensionality of the output to either 1, 2,
		/// 3 or 0 (default: 3).  If the dimensionality is 2D, then
		/// the Z extent of the output is forced to (0,0) and the Z
		/// origin of the output is forced to 0.0 (i.e. the output
		/// extent is confined to the xy plane).  If the dimensionality
		/// is 1D, the output extent is confined to the x axis.
		/// For 0D, the output extent consists of a single voxel at
		/// (0,0,0).
		/// </summary>
		// Token: 0x0600D6DE RID: 55006 RVA: 0x0012AE4B File Offset: 0x0012904B
		public virtual void SetOutputDimensionality(int _arg)
		{
			vtkImageReslice.vtkImageReslice_SetOutputDimensionality_90(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D6DF RID: 55007
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetOutputDirection_91(HandleRef pThis, double xx, double xy, double xz, double yx, double yy, double yz, double zx, double zy, double zz);

		/// <summary>
		/// Set the direction for the output data.  By default, the direction of
		/// the input data is passed to the output.  But if SetOutputDirection()
		/// is used, then the image will be resliced according to the new output
		/// direction.  Unlike SetResliceAxes(), this does not change the physical
		/// coordinate system for the image.  Instead, it changes the orientation
		/// of the sampling grid while maintaining the same physical coordinate
		/// system.
		/// </summary>
		// Token: 0x0600D6E0 RID: 55008 RVA: 0x0012AE5C File Offset: 0x0012905C
		public virtual void SetOutputDirection(double xx, double xy, double xz, double yx, double yy, double yz, double zx, double zy, double zz)
		{
			vtkImageReslice.vtkImageReslice_SetOutputDirection_91(base.GetCppThis(), xx, xy, xz, yx, yy, yz, zx, zy, zz);
		}

		// Token: 0x0600D6E1 RID: 55009
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetOutputDirection_92(HandleRef pThis, IntPtr a);

		/// <summary>
		/// Set the direction for the output data.  By default, the direction of
		/// the input data is passed to the output.  But if SetOutputDirection()
		/// is used, then the image will be resliced according to the new output
		/// direction.  Unlike SetResliceAxes(), this does not change the physical
		/// coordinate system for the image.  Instead, it changes the orientation
		/// of the sampling grid while maintaining the same physical coordinate
		/// system.
		/// </summary>
		// Token: 0x0600D6E2 RID: 55010 RVA: 0x0012AE85 File Offset: 0x00129085
		public virtual void SetOutputDirection(IntPtr a)
		{
			vtkImageReslice.vtkImageReslice_SetOutputDirection_92(base.GetCppThis(), a);
		}

		// Token: 0x0600D6E3 RID: 55011
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetOutputDirectionToDefault_93(HandleRef pThis);

		/// <summary>
		/// Set the direction for the output data.  By default, the direction of
		/// the input data is passed to the output.  But if SetOutputDirection()
		/// is used, then the image will be resliced according to the new output
		/// direction.  Unlike SetResliceAxes(), this does not change the physical
		/// coordinate system for the image.  Instead, it changes the orientation
		/// of the sampling grid while maintaining the same physical coordinate
		/// system.
		/// </summary>
		// Token: 0x0600D6E4 RID: 55012 RVA: 0x0012AE95 File Offset: 0x00129095
		public void SetOutputDirectionToDefault()
		{
			vtkImageReslice.vtkImageReslice_SetOutputDirectionToDefault_93(base.GetCppThis());
		}

		// Token: 0x0600D6E5 RID: 55013
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetOutputExtent_94(HandleRef pThis, int a, int b, int c, int d, int e, int f);

		/// <summary>
		/// Set the extent for the output data.  The default output extent
		/// is the input extent permuted through the ResliceAxes.
		/// </summary>
		// Token: 0x0600D6E6 RID: 55014 RVA: 0x0012AEA4 File Offset: 0x001290A4
		public virtual void SetOutputExtent(int a, int b, int c, int d, int e, int f)
		{
			vtkImageReslice.vtkImageReslice_SetOutputExtent_94(base.GetCppThis(), a, b, c, d, e, f);
		}

		// Token: 0x0600D6E7 RID: 55015
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetOutputExtent_95(HandleRef pThis, IntPtr a);

		/// <summary>
		/// Set the extent for the output data.  The default output extent
		/// is the input extent permuted through the ResliceAxes.
		/// </summary>
		// Token: 0x0600D6E8 RID: 55016 RVA: 0x0012AEBC File Offset: 0x001290BC
		public virtual void SetOutputExtent(IntPtr a)
		{
			vtkImageReslice.vtkImageReslice_SetOutputExtent_95(base.GetCppThis(), a);
		}

		// Token: 0x0600D6E9 RID: 55017
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetOutputExtentToDefault_96(HandleRef pThis);

		/// <summary>
		/// Set the extent for the output data.  The default output extent
		/// is the input extent permuted through the ResliceAxes.
		/// </summary>
		// Token: 0x0600D6EA RID: 55018 RVA: 0x0012AECC File Offset: 0x001290CC
		public void SetOutputExtentToDefault()
		{
			vtkImageReslice.vtkImageReslice_SetOutputExtentToDefault_96(base.GetCppThis());
		}

		// Token: 0x0600D6EB RID: 55019
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetOutputOrigin_97(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set the origin for the output data.  The default output origin
		/// is the input origin permuted through the ResliceAxes.
		/// </summary>
		// Token: 0x0600D6EC RID: 55020 RVA: 0x0012AEDB File Offset: 0x001290DB
		public virtual void SetOutputOrigin(double x, double y, double z)
		{
			vtkImageReslice.vtkImageReslice_SetOutputOrigin_97(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0600D6ED RID: 55021
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetOutputOrigin_98(HandleRef pThis, IntPtr a);

		/// <summary>
		/// Set the origin for the output data.  The default output origin
		/// is the input origin permuted through the ResliceAxes.
		/// </summary>
		// Token: 0x0600D6EE RID: 55022 RVA: 0x0012AEED File Offset: 0x001290ED
		public virtual void SetOutputOrigin(IntPtr a)
		{
			vtkImageReslice.vtkImageReslice_SetOutputOrigin_98(base.GetCppThis(), a);
		}

		// Token: 0x0600D6EF RID: 55023
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetOutputOriginToDefault_99(HandleRef pThis);

		/// <summary>
		/// Set the origin for the output data.  The default output origin
		/// is the input origin permuted through the ResliceAxes.
		/// </summary>
		// Token: 0x0600D6F0 RID: 55024 RVA: 0x0012AEFD File Offset: 0x001290FD
		public void SetOutputOriginToDefault()
		{
			vtkImageReslice.vtkImageReslice_SetOutputOriginToDefault_99(base.GetCppThis());
		}

		// Token: 0x0600D6F1 RID: 55025
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetOutputScalarType_100(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the scalar type of the output to be different from the input.
		/// The default value is -1, which means that the input scalar type will be
		/// used to set the output scalar type.  Otherwise, this must be set to one
		/// of the following types: VTK_CHAR, VTK_SIGNED_CHAR, VTK_UNSIGNED_CHAR,
		/// VTK_SHORT, VTK_UNSIGNED_SHORT, VTK_INT, VTK_UNSIGNED_INT, VTK_FLOAT,
		/// or VTK_DOUBLE.  Other types are not permitted.  If the output type
		/// is an integer type, the output will be rounded and clamped to the
		/// limits of the type.
		/// </summary>
		// Token: 0x0600D6F2 RID: 55026 RVA: 0x0012AF0C File Offset: 0x0012910C
		public virtual void SetOutputScalarType(int _arg)
		{
			vtkImageReslice.vtkImageReslice_SetOutputScalarType_100(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D6F3 RID: 55027
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetOutputSpacing_101(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set the voxel spacing for the output data.  The default output
		/// spacing is the input spacing permuted through the ResliceAxes.
		/// </summary>
		// Token: 0x0600D6F4 RID: 55028 RVA: 0x0012AF1C File Offset: 0x0012911C
		public virtual void SetOutputSpacing(double x, double y, double z)
		{
			vtkImageReslice.vtkImageReslice_SetOutputSpacing_101(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0600D6F5 RID: 55029
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetOutputSpacing_102(HandleRef pThis, IntPtr a);

		/// <summary>
		/// Set the voxel spacing for the output data.  The default output
		/// spacing is the input spacing permuted through the ResliceAxes.
		/// </summary>
		// Token: 0x0600D6F6 RID: 55030 RVA: 0x0012AF2E File Offset: 0x0012912E
		public virtual void SetOutputSpacing(IntPtr a)
		{
			vtkImageReslice.vtkImageReslice_SetOutputSpacing_102(base.GetCppThis(), a);
		}

		// Token: 0x0600D6F7 RID: 55031
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetOutputSpacingToDefault_103(HandleRef pThis);

		/// <summary>
		/// Set the voxel spacing for the output data.  The default output
		/// spacing is the input spacing permuted through the ResliceAxes.
		/// </summary>
		// Token: 0x0600D6F8 RID: 55032 RVA: 0x0012AF3E File Offset: 0x0012913E
		public void SetOutputSpacingToDefault()
		{
			vtkImageReslice.vtkImageReslice_SetOutputSpacingToDefault_103(base.GetCppThis());
		}

		// Token: 0x0600D6F9 RID: 55033
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetResliceAxes_104(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// This method is used to set up the axes for the output voxels.
		/// The output Spacing, Origin, and Extent specify the locations
		/// of the voxels within the coordinate system defined by the axes.
		/// The ResliceAxes are used most often to permute the data, e.g.
		/// to extract ZY or XZ slices of a volume as 2D XY images.
		/// &lt;p&gt;The first column of the matrix specifies the x-axis
		/// vector (the fourth element must be set to zero), the second
		/// column specifies the y-axis, and the third column the
		/// z-axis.  The fourth column is the origin of the
		/// axes (the fourth element must be set to one).
		/// &lt;p&gt;An alternative to SetResliceAxes() is to use
		/// SetResliceAxesDirectionCosines() to set the directions of the
		/// axes and SetResliceAxesOrigin() to set the origin of the axes.
		/// </summary>
		// Token: 0x0600D6FA RID: 55034 RVA: 0x0012AF50 File Offset: 0x00129150
		public virtual void SetResliceAxes(vtkMatrix4x4 arg0)
		{
			vtkImageReslice.vtkImageReslice_SetResliceAxes_104(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600D6FB RID: 55035
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetResliceAxesDirectionCosines_105(HandleRef pThis, double x0, double x1, double x2, double y0, double y1, double y2, double z0, double z1, double z2);

		/// <summary>
		/// Specify the direction cosines for the ResliceAxes (i.e. the
		/// first three elements of each of the first three columns of
		/// the ResliceAxes matrix).  This will modify the current
		/// ResliceAxes matrix, or create a new matrix if none exists.
		/// </summary>
		// Token: 0x0600D6FC RID: 55036 RVA: 0x0012AF80 File Offset: 0x00129180
		public void SetResliceAxesDirectionCosines(double x0, double x1, double x2, double y0, double y1, double y2, double z0, double z1, double z2)
		{
			vtkImageReslice.vtkImageReslice_SetResliceAxesDirectionCosines_105(base.GetCppThis(), x0, x1, x2, y0, y1, y2, z0, z1, z2);
		}

		// Token: 0x0600D6FD RID: 55037
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetResliceAxesDirectionCosines_106(HandleRef pThis, IntPtr x, IntPtr y, IntPtr z);

		/// <summary>
		/// Specify the direction cosines for the ResliceAxes (i.e. the
		/// first three elements of each of the first three columns of
		/// the ResliceAxes matrix).  This will modify the current
		/// ResliceAxes matrix, or create a new matrix if none exists.
		/// </summary>
		// Token: 0x0600D6FE RID: 55038 RVA: 0x0012AFA9 File Offset: 0x001291A9
		public void SetResliceAxesDirectionCosines(IntPtr x, IntPtr y, IntPtr z)
		{
			vtkImageReslice.vtkImageReslice_SetResliceAxesDirectionCosines_106(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0600D6FF RID: 55039
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetResliceAxesDirectionCosines_107(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// Specify the direction cosines for the ResliceAxes (i.e. the
		/// first three elements of each of the first three columns of
		/// the ResliceAxes matrix).  This will modify the current
		/// ResliceAxes matrix, or create a new matrix if none exists.
		/// </summary>
		// Token: 0x0600D700 RID: 55040 RVA: 0x0012AFBB File Offset: 0x001291BB
		public void SetResliceAxesDirectionCosines(IntPtr xyz)
		{
			vtkImageReslice.vtkImageReslice_SetResliceAxesDirectionCosines_107(base.GetCppThis(), xyz);
		}

		// Token: 0x0600D701 RID: 55041
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetResliceAxesOrigin_108(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Specify the origin for the ResliceAxes (i.e. the first three
		/// elements of the final column of the ResliceAxes matrix).
		/// This will modify the current ResliceAxes matrix, or create
		/// new matrix if none exists.
		/// </summary>
		// Token: 0x0600D702 RID: 55042 RVA: 0x0012AFCB File Offset: 0x001291CB
		public void SetResliceAxesOrigin(double x, double y, double z)
		{
			vtkImageReslice.vtkImageReslice_SetResliceAxesOrigin_108(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0600D703 RID: 55043
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetResliceAxesOrigin_109(HandleRef pThis, IntPtr xyz);

		/// <summary>
		/// Specify the origin for the ResliceAxes (i.e. the first three
		/// elements of the final column of the ResliceAxes matrix).
		/// This will modify the current ResliceAxes matrix, or create
		/// new matrix if none exists.
		/// </summary>
		// Token: 0x0600D704 RID: 55044 RVA: 0x0012AFDD File Offset: 0x001291DD
		public void SetResliceAxesOrigin(IntPtr xyz)
		{
			vtkImageReslice.vtkImageReslice_SetResliceAxesOrigin_109(base.GetCppThis(), xyz);
		}

		// Token: 0x0600D705 RID: 55045
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetResliceTransform_110(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set a transform to be applied to the resampling grid that has
		/// been defined via the ResliceAxes and the output Origin, Spacing
		/// and Extent.  Note that applying a transform to the resampling
		/// grid (which lies in the output coordinate system) is
		/// equivalent to applying the inverse of that transform to
		/// the input volume.  Nonlinear transforms such as vtkGridTransform
		/// and vtkThinPlateSplineTransform can be used here.
		/// </summary>
		// Token: 0x0600D706 RID: 55046 RVA: 0x0012AFF0 File Offset: 0x001291F0
		public virtual void SetResliceTransform(vtkAbstractTransform arg0)
		{
			vtkImageReslice.vtkImageReslice_SetResliceTransform_110(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600D707 RID: 55047
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetScalarScale_111(HandleRef pThis, double _arg);

		/// <summary>
		/// Set multiplication factor to apply to all the output voxels.
		/// After a sample value has been interpolated from the input image, the
		/// equation u = (v + ScalarShift)*ScalarScale will be applied to it before
		/// it is written to the output image.  The result will always be clamped to
		/// the limits of the output data type.
		/// </summary>
		// Token: 0x0600D708 RID: 55048 RVA: 0x0012B01F File Offset: 0x0012921F
		public virtual void SetScalarScale(double _arg)
		{
			vtkImageReslice.vtkImageReslice_SetScalarScale_111(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D709 RID: 55049
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetScalarShift_112(HandleRef pThis, double _arg);

		/// <summary>
		/// Set a value to add to all the output voxels.
		/// After a sample value has been interpolated from the input image, the
		/// equation u = (v + ScalarShift)*ScalarScale will be applied to it before
		/// it is written to the output image.  The result will always be clamped to
		/// the limits of the output data type.
		/// </summary>
		// Token: 0x0600D70A RID: 55050 RVA: 0x0012B02F File Offset: 0x0012922F
		public virtual void SetScalarShift(double _arg)
		{
			vtkImageReslice.vtkImageReslice_SetScalarShift_112(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D70B RID: 55051
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetSlabMode_113(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the slab mode, for generating thick slices. The default is Mean.
		/// If SetSlabNumberOfSlices(N) is called with N greater than one, then
		/// each output slice will actually be a composite of N slices.  This method
		/// specifies the compositing mode to be used.
		/// </summary>
		// Token: 0x0600D70C RID: 55052 RVA: 0x0012B03F File Offset: 0x0012923F
		public virtual void SetSlabMode(int _arg)
		{
			vtkImageReslice.vtkImageReslice_SetSlabMode_113(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D70D RID: 55053
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetSlabModeToMax_114(HandleRef pThis);

		/// <summary>
		/// Set the slab mode, for generating thick slices. The default is Mean.
		/// If SetSlabNumberOfSlices(N) is called with N greater than one, then
		/// each output slice will actually be a composite of N slices.  This method
		/// specifies the compositing mode to be used.
		/// </summary>
		// Token: 0x0600D70E RID: 55054 RVA: 0x0012B04F File Offset: 0x0012924F
		public void SetSlabModeToMax()
		{
			vtkImageReslice.vtkImageReslice_SetSlabModeToMax_114(base.GetCppThis());
		}

		// Token: 0x0600D70F RID: 55055
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetSlabModeToMean_115(HandleRef pThis);

		/// <summary>
		/// Set the slab mode, for generating thick slices. The default is Mean.
		/// If SetSlabNumberOfSlices(N) is called with N greater than one, then
		/// each output slice will actually be a composite of N slices.  This method
		/// specifies the compositing mode to be used.
		/// </summary>
		// Token: 0x0600D710 RID: 55056 RVA: 0x0012B05E File Offset: 0x0012925E
		public void SetSlabModeToMean()
		{
			vtkImageReslice.vtkImageReslice_SetSlabModeToMean_115(base.GetCppThis());
		}

		// Token: 0x0600D711 RID: 55057
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetSlabModeToMin_116(HandleRef pThis);

		/// <summary>
		/// Set the slab mode, for generating thick slices. The default is Mean.
		/// If SetSlabNumberOfSlices(N) is called with N greater than one, then
		/// each output slice will actually be a composite of N slices.  This method
		/// specifies the compositing mode to be used.
		/// </summary>
		// Token: 0x0600D712 RID: 55058 RVA: 0x0012B06D File Offset: 0x0012926D
		public void SetSlabModeToMin()
		{
			vtkImageReslice.vtkImageReslice_SetSlabModeToMin_116(base.GetCppThis());
		}

		// Token: 0x0600D713 RID: 55059
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetSlabModeToSum_117(HandleRef pThis);

		/// <summary>
		/// Set the slab mode, for generating thick slices. The default is Mean.
		/// If SetSlabNumberOfSlices(N) is called with N greater than one, then
		/// each output slice will actually be a composite of N slices.  This method
		/// specifies the compositing mode to be used.
		/// </summary>
		// Token: 0x0600D714 RID: 55060 RVA: 0x0012B07C File Offset: 0x0012927C
		public void SetSlabModeToSum()
		{
			vtkImageReslice.vtkImageReslice_SetSlabModeToSum_117(base.GetCppThis());
		}

		// Token: 0x0600D715 RID: 55061
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetSlabNumberOfSlices_118(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the number of slices that will be combined to create the slab.
		/// </summary>
		// Token: 0x0600D716 RID: 55062 RVA: 0x0012B08B File Offset: 0x0012928B
		public virtual void SetSlabNumberOfSlices(int _arg)
		{
			vtkImageReslice.vtkImageReslice_SetSlabNumberOfSlices_118(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D717 RID: 55063
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetSlabSliceSpacingFraction_119(HandleRef pThis, double _arg);

		/// <summary>
		/// The slab spacing as a fraction of the output slice spacing.
		/// When one of the various slab modes is chosen, each output slice is
		/// produced by generating several "temporary" output slices and then
		/// combining them according to the slab mode.  By default, the spacing
		/// between these temporary slices is the Z component of the OutputSpacing.
		/// This method sets the spacing between these temporary slices to be a
		/// fraction of the output spacing.
		/// </summary>
		// Token: 0x0600D718 RID: 55064 RVA: 0x0012B09B File Offset: 0x0012929B
		public virtual void SetSlabSliceSpacingFraction(double _arg)
		{
			vtkImageReslice.vtkImageReslice_SetSlabSliceSpacingFraction_119(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D719 RID: 55065
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetSlabTrapezoidIntegration_120(HandleRef pThis, int _arg);

		/// <summary>
		/// Use trapezoid integration for slab computation.  All this does is
		/// weigh the first and last slices by half when doing sum and mean.
		/// It is off by default.
		/// </summary>
		// Token: 0x0600D71A RID: 55066 RVA: 0x0012B0AB File Offset: 0x001292AB
		public virtual void SetSlabTrapezoidIntegration(int _arg)
		{
			vtkImageReslice.vtkImageReslice_SetSlabTrapezoidIntegration_120(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D71B RID: 55067
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetStencilData_121(HandleRef pThis, HandleRef stencil);

		/// <summary>
		/// Use a stencil to limit the calculations to a specific region of
		/// the output.  Portions of the output that are 'outside' the stencil
		/// will be cleared to the background color.
		/// </summary>
		// Token: 0x0600D71C RID: 55068 RVA: 0x0012B0BC File Offset: 0x001292BC
		public void SetStencilData(vtkImageStencilData stencil)
		{
			vtkImageReslice.vtkImageReslice_SetStencilData_121(base.GetCppThis(), (stencil == null) ? default(HandleRef) : stencil.GetCppThis());
		}

		// Token: 0x0600D71D RID: 55069
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetStencilOutput_122(HandleRef pThis, HandleRef stencil);

		/// <summary>
		/// Get the output stencil.
		/// </summary>
		// Token: 0x0600D71E RID: 55070 RVA: 0x0012B0EC File Offset: 0x001292EC
		public void SetStencilOutput(vtkImageStencilData stencil)
		{
			vtkImageReslice.vtkImageReslice_SetStencilOutput_122(base.GetCppThis(), (stencil == null) ? default(HandleRef) : stencil.GetCppThis());
		}

		// Token: 0x0600D71F RID: 55071
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetTransformInputSampling_123(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether to transform the spacing, origin and extent
		/// of the Input (or the InformationInput) according to the
		/// direction cosines and origin of the ResliceAxes before applying
		/// them as the default output spacing, origin and extent
		/// (default: On).
		/// </summary>
		// Token: 0x0600D720 RID: 55072 RVA: 0x0012B11B File Offset: 0x0012931B
		public virtual void SetTransformInputSampling(int _arg)
		{
			vtkImageReslice.vtkImageReslice_SetTransformInputSampling_123(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D721 RID: 55073
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SetWrap_124(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on wrap-pad feature (default: Off).
		/// </summary>
		// Token: 0x0600D722 RID: 55074 RVA: 0x0012B12B File Offset: 0x0012932B
		public virtual void SetWrap(int _arg)
		{
			vtkImageReslice.vtkImageReslice_SetWrap_124(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D723 RID: 55075
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SlabTrapezoidIntegrationOff_125(HandleRef pThis);

		/// <summary>
		/// Use trapezoid integration for slab computation.  All this does is
		/// weigh the first and last slices by half when doing sum and mean.
		/// It is off by default.
		/// </summary>
		// Token: 0x0600D724 RID: 55076 RVA: 0x0012B13B File Offset: 0x0012933B
		public virtual void SlabTrapezoidIntegrationOff()
		{
			vtkImageReslice.vtkImageReslice_SlabTrapezoidIntegrationOff_125(base.GetCppThis());
		}

		// Token: 0x0600D725 RID: 55077
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_SlabTrapezoidIntegrationOn_126(HandleRef pThis);

		/// <summary>
		/// Use trapezoid integration for slab computation.  All this does is
		/// weigh the first and last slices by half when doing sum and mean.
		/// It is off by default.
		/// </summary>
		// Token: 0x0600D726 RID: 55078 RVA: 0x0012B14A File Offset: 0x0012934A
		public virtual void SlabTrapezoidIntegrationOn()
		{
			vtkImageReslice.vtkImageReslice_SlabTrapezoidIntegrationOn_126(base.GetCppThis());
		}

		// Token: 0x0600D727 RID: 55079
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_TransformInputSamplingOff_127(HandleRef pThis);

		/// <summary>
		/// Specify whether to transform the spacing, origin and extent
		/// of the Input (or the InformationInput) according to the
		/// direction cosines and origin of the ResliceAxes before applying
		/// them as the default output spacing, origin and extent
		/// (default: On).
		/// </summary>
		// Token: 0x0600D728 RID: 55080 RVA: 0x0012B159 File Offset: 0x00129359
		public virtual void TransformInputSamplingOff()
		{
			vtkImageReslice.vtkImageReslice_TransformInputSamplingOff_127(base.GetCppThis());
		}

		// Token: 0x0600D729 RID: 55081
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_TransformInputSamplingOn_128(HandleRef pThis);

		/// <summary>
		/// Specify whether to transform the spacing, origin and extent
		/// of the Input (or the InformationInput) according to the
		/// direction cosines and origin of the ResliceAxes before applying
		/// them as the default output spacing, origin and extent
		/// (default: On).
		/// </summary>
		// Token: 0x0600D72A RID: 55082 RVA: 0x0012B168 File Offset: 0x00129368
		public virtual void TransformInputSamplingOn()
		{
			vtkImageReslice.vtkImageReslice_TransformInputSamplingOn_128(base.GetCppThis());
		}

		// Token: 0x0600D72B RID: 55083
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_WrapOff_129(HandleRef pThis);

		/// <summary>
		/// Turn on wrap-pad feature (default: Off).
		/// </summary>
		// Token: 0x0600D72C RID: 55084 RVA: 0x0012B177 File Offset: 0x00129377
		public virtual void WrapOff()
		{
			vtkImageReslice.vtkImageReslice_WrapOff_129(base.GetCppThis());
		}

		// Token: 0x0600D72D RID: 55085
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReslice_WrapOn_130(HandleRef pThis);

		/// <summary>
		/// Turn on wrap-pad feature (default: Off).
		/// </summary>
		// Token: 0x0600D72E RID: 55086 RVA: 0x0012B186 File Offset: 0x00129386
		public virtual void WrapOn()
		{
			vtkImageReslice.vtkImageReslice_WrapOn_130(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FC6 RID: 4038
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageReslice";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FC7 RID: 4039
		public new static readonly string MRClassNameKey = "class vtkImageReslice";
	}
}
