using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageResize
	/// </summary>
	/// <remarks>
	///    High-quality image resizing filter
	///
	/// vtkImageResize will magnify or shrink an image with interpolation and
	/// antialiasing.  The resizing is done with a 5-lobe Lanczos-windowed sinc
	/// filter that is bandlimited to the output sampling frequency in order to
	/// avoid aliasing when the image size is reduced.  This filter utilizes a
	/// O(n) algorithm to provide good efficiency even though the filtering kernel
	/// is large.  The sinc interpolator can be turned off if nearest-neighbor
	/// interpolation is required, or it can be replaced with a different
	/// vtkImageInterpolator object.
	/// @par Thanks:
	/// Thanks to David Gobbi for contributing this class to VTK.
	/// </remarks>
	// Token: 0x02000862 RID: 2146
	public class vtkImageResize : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060163C6 RID: 91078 RVA: 0x001F4E15 File Offset: 0x001F3015
		static vtkImageResize()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageResize.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageResize"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060163C7 RID: 91079 RVA: 0x001F4E3D File Offset: 0x001F303D
		public vtkImageResize(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060163C8 RID: 91080
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageResize_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060163C9 RID: 91081 RVA: 0x001F4E4C File Offset: 0x001F304C
		public new static vtkImageResize New()
		{
			vtkImageResize result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageResize.vtkImageResize_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageResize)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060163CA RID: 91082 RVA: 0x001F4EA0 File Offset: 0x001F30A0
		public vtkImageResize() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageResize.vtkImageResize_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060163CB RID: 91083 RVA: 0x001F4EE4 File Offset: 0x001F30E4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060163CC RID: 91084
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResize_BorderOff_01(HandleRef pThis);

		/// <summary>
		/// If Border is Off (the default), then the centers of each of the corner
		/// voxels will be considered to form the rectangular bounds of the image.
		/// This is the way that VTK normally computes image bounds.  If Border is On,
		/// then the image bounds will be defined by the outer corners of the voxels.
		/// This setting impacts how the resizing is done.  For example, if a
		/// MagnificationFactor of two is applied to a 256x256 image, the output
		/// image will be 512x512 if Border is On, or 511x511 if Border is Off.
		/// </summary>
		// Token: 0x060163CD RID: 91085 RVA: 0x001F4EEF File Offset: 0x001F30EF
		public virtual void BorderOff()
		{
			vtkImageResize.vtkImageResize_BorderOff_01(base.GetCppThis());
		}

		// Token: 0x060163CE RID: 91086
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResize_BorderOn_02(HandleRef pThis);

		/// <summary>
		/// If Border is Off (the default), then the centers of each of the corner
		/// voxels will be considered to form the rectangular bounds of the image.
		/// This is the way that VTK normally computes image bounds.  If Border is On,
		/// then the image bounds will be defined by the outer corners of the voxels.
		/// This setting impacts how the resizing is done.  For example, if a
		/// MagnificationFactor of two is applied to a 256x256 image, the output
		/// image will be 512x512 if Border is On, or 511x511 if Border is Off.
		/// </summary>
		// Token: 0x060163CF RID: 91087 RVA: 0x001F4EFE File Offset: 0x001F30FE
		public virtual void BorderOn()
		{
			vtkImageResize.vtkImageResize_BorderOn_02(base.GetCppThis());
		}

		// Token: 0x060163D0 RID: 91088
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResize_CroppingOff_03(HandleRef pThis);

		/// <summary>
		/// Whether to crop the input image before resizing (Off by default).  If this
		/// is On, then the CroppingRegion must be set.
		/// </summary>
		// Token: 0x060163D1 RID: 91089 RVA: 0x001F4F0D File Offset: 0x001F310D
		public virtual void CroppingOff()
		{
			vtkImageResize.vtkImageResize_CroppingOff_03(base.GetCppThis());
		}

		// Token: 0x060163D2 RID: 91090
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResize_CroppingOn_04(HandleRef pThis);

		/// <summary>
		/// Whether to crop the input image before resizing (Off by default).  If this
		/// is On, then the CroppingRegion must be set.
		/// </summary>
		// Token: 0x060163D3 RID: 91091 RVA: 0x001F4F1C File Offset: 0x001F311C
		public virtual void CroppingOn()
		{
			vtkImageResize.vtkImageResize_CroppingOn_04(base.GetCppThis());
		}

		// Token: 0x060163D4 RID: 91092
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResize_GetBorder_05(HandleRef pThis);

		/// <summary>
		/// If Border is Off (the default), then the centers of each of the corner
		/// voxels will be considered to form the rectangular bounds of the image.
		/// This is the way that VTK normally computes image bounds.  If Border is On,
		/// then the image bounds will be defined by the outer corners of the voxels.
		/// This setting impacts how the resizing is done.  For example, if a
		/// MagnificationFactor of two is applied to a 256x256 image, the output
		/// image will be 512x512 if Border is On, or 511x511 if Border is Off.
		/// </summary>
		// Token: 0x060163D5 RID: 91093 RVA: 0x001F4F2C File Offset: 0x001F312C
		public virtual int GetBorder()
		{
			return vtkImageResize.vtkImageResize_GetBorder_05(base.GetCppThis());
		}

		// Token: 0x060163D6 RID: 91094
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResize_GetCropping_06(HandleRef pThis);

		/// <summary>
		/// Whether to crop the input image before resizing (Off by default).  If this
		/// is On, then the CroppingRegion must be set.
		/// </summary>
		// Token: 0x060163D7 RID: 91095 RVA: 0x001F4F4C File Offset: 0x001F314C
		public virtual int GetCropping()
		{
			return vtkImageResize.vtkImageResize_GetCropping_06(base.GetCppThis());
		}

		// Token: 0x060163D8 RID: 91096
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageResize_GetCroppingRegion_07(HandleRef pThis);

		/// <summary>
		/// If Cropping is On, then the CroppingRegion will be used to crop the image
		/// before it is resized.  The region must be specified in data coordinates,
		/// rather than voxel indices.
		/// </summary>
		// Token: 0x060163D9 RID: 91097 RVA: 0x001F4F6C File Offset: 0x001F316C
		public virtual double[] GetCroppingRegion()
		{
			IntPtr intPtr = vtkImageResize.vtkImageResize_GetCroppingRegion_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060163DA RID: 91098
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResize_GetCroppingRegion_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

		/// <summary>
		/// If Cropping is On, then the CroppingRegion will be used to crop the image
		/// before it is resized.  The region must be specified in data coordinates,
		/// rather than voxel indices.
		/// </summary>
		// Token: 0x060163DB RID: 91099 RVA: 0x001F4FB4 File Offset: 0x001F31B4
		public virtual void GetCroppingRegion(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
		{
			vtkImageResize.vtkImageResize_GetCroppingRegion_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x060163DC RID: 91100
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResize_GetCroppingRegion_09(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// If Cropping is On, then the CroppingRegion will be used to crop the image
		/// before it is resized.  The region must be specified in data coordinates,
		/// rather than voxel indices.
		/// </summary>
		// Token: 0x060163DD RID: 91101 RVA: 0x001F4FCC File Offset: 0x001F31CC
		public virtual void GetCroppingRegion(IntPtr _arg)
		{
			vtkImageResize.vtkImageResize_GetCroppingRegion_09(base.GetCppThis(), _arg);
		}

		// Token: 0x060163DE RID: 91102
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResize_GetInterpolate_10(HandleRef pThis);

		/// <summary>
		/// Turn interpolation on or off (by default, interpolation is on).
		/// </summary>
		// Token: 0x060163DF RID: 91103 RVA: 0x001F4FDC File Offset: 0x001F31DC
		public virtual int GetInterpolate()
		{
			return vtkImageResize.vtkImageResize_GetInterpolate_10(base.GetCppThis());
		}

		// Token: 0x060163E0 RID: 91104
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageResize_GetInterpolator_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the interpolator for resampling the data.
		/// </summary>
		// Token: 0x060163E1 RID: 91105 RVA: 0x001F4FFC File Offset: 0x001F31FC
		public virtual vtkAbstractImageInterpolator GetInterpolator()
		{
			vtkAbstractImageInterpolator vtkAbstractImageInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageResize.vtkImageResize_GetInterpolator_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060163E2 RID: 91106
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkImageResize_GetMTime_12(HandleRef pThis);

		/// <summary>
		/// Get the modified time of the filter.
		/// </summary>
		// Token: 0x060163E3 RID: 91107 RVA: 0x001F506C File Offset: 0x001F326C
		public override ulong GetMTime()
		{
			return vtkImageResize.vtkImageResize_GetMTime_12(base.GetCppThis());
		}

		// Token: 0x060163E4 RID: 91108
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageResize_GetMagnificationFactors_13(HandleRef pThis);

		/// <summary>
		/// The desired magnification factor, meaning that the sample spacing will
		/// be reduced by this factor.  This setting is only used if the ResizeMethod
		/// is set to MagnificationFactors.
		/// </summary>
		// Token: 0x060163E5 RID: 91109 RVA: 0x001F508C File Offset: 0x001F328C
		public virtual double[] GetMagnificationFactors()
		{
			IntPtr intPtr = vtkImageResize.vtkImageResize_GetMagnificationFactors_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060163E6 RID: 91110
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResize_GetMagnificationFactors_14(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// The desired magnification factor, meaning that the sample spacing will
		/// be reduced by this factor.  This setting is only used if the ResizeMethod
		/// is set to MagnificationFactors.
		/// </summary>
		// Token: 0x060163E7 RID: 91111 RVA: 0x001F50D4 File Offset: 0x001F32D4
		public virtual void GetMagnificationFactors(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageResize.vtkImageResize_GetMagnificationFactors_14(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060163E8 RID: 91112
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResize_GetMagnificationFactors_15(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The desired magnification factor, meaning that the sample spacing will
		/// be reduced by this factor.  This setting is only used if the ResizeMethod
		/// is set to MagnificationFactors.
		/// </summary>
		// Token: 0x060163E9 RID: 91113 RVA: 0x001F50E6 File Offset: 0x001F32E6
		public virtual void GetMagnificationFactors(IntPtr _arg)
		{
			vtkImageResize.vtkImageResize_GetMagnificationFactors_15(base.GetCppThis(), _arg);
		}

		// Token: 0x060163EA RID: 91114
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageResize_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060163EB RID: 91115 RVA: 0x001F50F8 File Offset: 0x001F32F8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageResize.vtkImageResize_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x060163EC RID: 91116
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageResize_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060163ED RID: 91117 RVA: 0x001F5118 File Offset: 0x001F3318
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageResize.vtkImageResize_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x060163EE RID: 91118
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageResize_GetOutputDimensions_18(HandleRef pThis);

		/// <summary>
		/// The desired output dimensions.  This is only used if the ResizeMethod is
		/// set to OutputDimensions.  If you want to keep one of the image dimensions
		/// the same as the input, then set that dimension to -1.
		/// </summary>
		// Token: 0x060163EF RID: 91119 RVA: 0x001F5134 File Offset: 0x001F3334
		public virtual int[] GetOutputDimensions()
		{
			IntPtr intPtr = vtkImageResize.vtkImageResize_GetOutputDimensions_18(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060163F0 RID: 91120
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResize_GetOutputDimensions_19(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		/// <summary>
		/// The desired output dimensions.  This is only used if the ResizeMethod is
		/// set to OutputDimensions.  If you want to keep one of the image dimensions
		/// the same as the input, then set that dimension to -1.
		/// </summary>
		// Token: 0x060163F1 RID: 91121 RVA: 0x001F517C File Offset: 0x001F337C
		public virtual void GetOutputDimensions(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkImageResize.vtkImageResize_GetOutputDimensions_19(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060163F2 RID: 91122
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResize_GetOutputDimensions_20(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The desired output dimensions.  This is only used if the ResizeMethod is
		/// set to OutputDimensions.  If you want to keep one of the image dimensions
		/// the same as the input, then set that dimension to -1.
		/// </summary>
		// Token: 0x060163F3 RID: 91123 RVA: 0x001F518E File Offset: 0x001F338E
		public virtual void GetOutputDimensions(IntPtr _arg)
		{
			vtkImageResize.vtkImageResize_GetOutputDimensions_20(base.GetCppThis(), _arg);
		}

		// Token: 0x060163F4 RID: 91124
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageResize_GetOutputSpacing_21(HandleRef pThis);

		/// <summary>
		/// The desired output spacing.  This is only used if the ResizeMethod is
		/// set to OutputSpacing.  If you want to keep one of the original spacing
		/// values, then set that spacing value to zero.
		/// </summary>
		// Token: 0x060163F5 RID: 91125 RVA: 0x001F51A0 File Offset: 0x001F33A0
		public virtual double[] GetOutputSpacing()
		{
			IntPtr intPtr = vtkImageResize.vtkImageResize_GetOutputSpacing_21(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060163F6 RID: 91126
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResize_GetOutputSpacing_22(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// The desired output spacing.  This is only used if the ResizeMethod is
		/// set to OutputSpacing.  If you want to keep one of the original spacing
		/// values, then set that spacing value to zero.
		/// </summary>
		// Token: 0x060163F7 RID: 91127 RVA: 0x001F51E8 File Offset: 0x001F33E8
		public virtual void GetOutputSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageResize.vtkImageResize_GetOutputSpacing_22(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060163F8 RID: 91128
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResize_GetOutputSpacing_23(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The desired output spacing.  This is only used if the ResizeMethod is
		/// set to OutputSpacing.  If you want to keep one of the original spacing
		/// values, then set that spacing value to zero.
		/// </summary>
		// Token: 0x060163F9 RID: 91129 RVA: 0x001F51FA File Offset: 0x001F33FA
		public virtual void GetOutputSpacing(IntPtr _arg)
		{
			vtkImageResize.vtkImageResize_GetOutputSpacing_23(base.GetCppThis(), _arg);
		}

		// Token: 0x060163FA RID: 91130
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResize_GetResizeMethod_24(HandleRef pThis);

		/// <summary>
		/// The resizing method to use.  The default is to set the output image
		/// dimensions, and allow the filter to resize the image to these new
		/// dimensions.  It is also possible to resize the image by setting the
		/// output image spacing or by setting a magnification factor.
		/// </summary>
		// Token: 0x060163FB RID: 91131 RVA: 0x001F520C File Offset: 0x001F340C
		public virtual int GetResizeMethod()
		{
			return vtkImageResize.vtkImageResize_GetResizeMethod_24(base.GetCppThis());
		}

		// Token: 0x060163FC RID: 91132
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageResize_GetResizeMethodAsString_25(HandleRef pThis);

		/// <summary>
		/// The resizing method to use.  The default is to set the output image
		/// dimensions, and allow the filter to resize the image to these new
		/// dimensions.  It is also possible to resize the image by setting the
		/// output image spacing or by setting a magnification factor.
		/// </summary>
		// Token: 0x060163FD RID: 91133 RVA: 0x001F522C File Offset: 0x001F342C
		public virtual string GetResizeMethodAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageResize.vtkImageResize_GetResizeMethodAsString_25(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060163FE RID: 91134
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResize_GetResizeMethodMaxValue_26(HandleRef pThis);

		/// <summary>
		/// The resizing method to use.  The default is to set the output image
		/// dimensions, and allow the filter to resize the image to these new
		/// dimensions.  It is also possible to resize the image by setting the
		/// output image spacing or by setting a magnification factor.
		/// </summary>
		// Token: 0x060163FF RID: 91135 RVA: 0x001F5268 File Offset: 0x001F3468
		public virtual int GetResizeMethodMaxValue()
		{
			return vtkImageResize.vtkImageResize_GetResizeMethodMaxValue_26(base.GetCppThis());
		}

		// Token: 0x06016400 RID: 91136
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResize_GetResizeMethodMinValue_27(HandleRef pThis);

		/// <summary>
		/// The resizing method to use.  The default is to set the output image
		/// dimensions, and allow the filter to resize the image to these new
		/// dimensions.  It is also possible to resize the image by setting the
		/// output image spacing or by setting a magnification factor.
		/// </summary>
		// Token: 0x06016401 RID: 91137 RVA: 0x001F5288 File Offset: 0x001F3488
		public virtual int GetResizeMethodMinValue()
		{
			return vtkImageResize.vtkImageResize_GetResizeMethodMinValue_27(base.GetCppThis());
		}

		// Token: 0x06016402 RID: 91138
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResize_InterpolateOff_28(HandleRef pThis);

		/// <summary>
		/// Turn interpolation on or off (by default, interpolation is on).
		/// </summary>
		// Token: 0x06016403 RID: 91139 RVA: 0x001F52A7 File Offset: 0x001F34A7
		public virtual void InterpolateOff()
		{
			vtkImageResize.vtkImageResize_InterpolateOff_28(base.GetCppThis());
		}

		// Token: 0x06016404 RID: 91140
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResize_InterpolateOn_29(HandleRef pThis);

		/// <summary>
		/// Turn interpolation on or off (by default, interpolation is on).
		/// </summary>
		// Token: 0x06016405 RID: 91141 RVA: 0x001F52B6 File Offset: 0x001F34B6
		public virtual void InterpolateOn()
		{
			vtkImageResize.vtkImageResize_InterpolateOn_29(base.GetCppThis());
		}

		// Token: 0x06016406 RID: 91142
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResize_IsA_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016407 RID: 91143 RVA: 0x001F52C8 File Offset: 0x001F34C8
		public override int IsA(string type)
		{
			return vtkImageResize.vtkImageResize_IsA_30(base.GetCppThis(), type);
		}

		// Token: 0x06016408 RID: 91144
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageResize_IsTypeOf_31([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016409 RID: 91145 RVA: 0x001F52E8 File Offset: 0x001F34E8
		public new static int IsTypeOf(string type)
		{
			return vtkImageResize.vtkImageResize_IsTypeOf_31(type);
		}

		// Token: 0x0601640A RID: 91146
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageResize_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601640B RID: 91147 RVA: 0x001F5304 File Offset: 0x001F3504
		public new vtkImageResize NewInstance()
		{
			vtkImageResize result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageResize.vtkImageResize_NewInstance_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageResize)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601640C RID: 91148
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageResize_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601640D RID: 91149 RVA: 0x001F5360 File Offset: 0x001F3560
		public new static vtkImageResize SafeDownCast(vtkObjectBase o)
		{
			vtkImageResize vtkImageResize = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageResize.vtkImageResize_SafeDownCast_34((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageResize = (vtkImageResize)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageResize.Register(null);
				}
			}
			return vtkImageResize;
		}

		// Token: 0x0601640E RID: 91150
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResize_SetBorder_35(HandleRef pThis, int _arg);

		/// <summary>
		/// If Border is Off (the default), then the centers of each of the corner
		/// voxels will be considered to form the rectangular bounds of the image.
		/// This is the way that VTK normally computes image bounds.  If Border is On,
		/// then the image bounds will be defined by the outer corners of the voxels.
		/// This setting impacts how the resizing is done.  For example, if a
		/// MagnificationFactor of two is applied to a 256x256 image, the output
		/// image will be 512x512 if Border is On, or 511x511 if Border is Off.
		/// </summary>
		// Token: 0x0601640F RID: 91151 RVA: 0x001F53DF File Offset: 0x001F35DF
		public virtual void SetBorder(int _arg)
		{
			vtkImageResize.vtkImageResize_SetBorder_35(base.GetCppThis(), _arg);
		}

		// Token: 0x06016410 RID: 91152
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResize_SetCropping_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Whether to crop the input image before resizing (Off by default).  If this
		/// is On, then the CroppingRegion must be set.
		/// </summary>
		// Token: 0x06016411 RID: 91153 RVA: 0x001F53EF File Offset: 0x001F35EF
		public virtual void SetCropping(int _arg)
		{
			vtkImageResize.vtkImageResize_SetCropping_36(base.GetCppThis(), _arg);
		}

		// Token: 0x06016412 RID: 91154
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResize_SetCroppingRegion_37(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// If Cropping is On, then the CroppingRegion will be used to crop the image
		/// before it is resized.  The region must be specified in data coordinates,
		/// rather than voxel indices.
		/// </summary>
		// Token: 0x06016413 RID: 91155 RVA: 0x001F53FF File Offset: 0x001F35FF
		public virtual void SetCroppingRegion(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkImageResize.vtkImageResize_SetCroppingRegion_37(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x06016414 RID: 91156
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResize_SetCroppingRegion_38(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// If Cropping is On, then the CroppingRegion will be used to crop the image
		/// before it is resized.  The region must be specified in data coordinates,
		/// rather than voxel indices.
		/// </summary>
		// Token: 0x06016415 RID: 91157 RVA: 0x001F5417 File Offset: 0x001F3617
		public virtual void SetCroppingRegion(IntPtr _arg)
		{
			vtkImageResize.vtkImageResize_SetCroppingRegion_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06016416 RID: 91158
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResize_SetInterpolate_39(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn interpolation on or off (by default, interpolation is on).
		/// </summary>
		// Token: 0x06016417 RID: 91159 RVA: 0x001F5427 File Offset: 0x001F3627
		public virtual void SetInterpolate(int _arg)
		{
			vtkImageResize.vtkImageResize_SetInterpolate_39(base.GetCppThis(), _arg);
		}

		// Token: 0x06016418 RID: 91160
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResize_SetInterpolator_40(HandleRef pThis, HandleRef sampler);

		/// <summary>
		/// Set the interpolator for resampling the data.
		/// </summary>
		// Token: 0x06016419 RID: 91161 RVA: 0x001F5438 File Offset: 0x001F3638
		public virtual void SetInterpolator(vtkAbstractImageInterpolator sampler)
		{
			vtkImageResize.vtkImageResize_SetInterpolator_40(base.GetCppThis(), (sampler == null) ? default(HandleRef) : sampler.GetCppThis());
		}

		// Token: 0x0601641A RID: 91162
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResize_SetMagnificationFactors_41(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// The desired magnification factor, meaning that the sample spacing will
		/// be reduced by this factor.  This setting is only used if the ResizeMethod
		/// is set to MagnificationFactors.
		/// </summary>
		// Token: 0x0601641B RID: 91163 RVA: 0x001F5467 File Offset: 0x001F3667
		public virtual void SetMagnificationFactors(double _arg1, double _arg2, double _arg3)
		{
			vtkImageResize.vtkImageResize_SetMagnificationFactors_41(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601641C RID: 91164
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResize_SetMagnificationFactors_42(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The desired magnification factor, meaning that the sample spacing will
		/// be reduced by this factor.  This setting is only used if the ResizeMethod
		/// is set to MagnificationFactors.
		/// </summary>
		// Token: 0x0601641D RID: 91165 RVA: 0x001F5479 File Offset: 0x001F3679
		public virtual void SetMagnificationFactors(IntPtr _arg)
		{
			vtkImageResize.vtkImageResize_SetMagnificationFactors_42(base.GetCppThis(), _arg);
		}

		// Token: 0x0601641E RID: 91166
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResize_SetOutputDimensions_43(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		/// <summary>
		/// The desired output dimensions.  This is only used if the ResizeMethod is
		/// set to OutputDimensions.  If you want to keep one of the image dimensions
		/// the same as the input, then set that dimension to -1.
		/// </summary>
		// Token: 0x0601641F RID: 91167 RVA: 0x001F5489 File Offset: 0x001F3689
		public virtual void SetOutputDimensions(int _arg1, int _arg2, int _arg3)
		{
			vtkImageResize.vtkImageResize_SetOutputDimensions_43(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06016420 RID: 91168
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResize_SetOutputDimensions_44(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The desired output dimensions.  This is only used if the ResizeMethod is
		/// set to OutputDimensions.  If you want to keep one of the image dimensions
		/// the same as the input, then set that dimension to -1.
		/// </summary>
		// Token: 0x06016421 RID: 91169 RVA: 0x001F549B File Offset: 0x001F369B
		public virtual void SetOutputDimensions(IntPtr _arg)
		{
			vtkImageResize.vtkImageResize_SetOutputDimensions_44(base.GetCppThis(), _arg);
		}

		// Token: 0x06016422 RID: 91170
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResize_SetOutputSpacing_45(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// The desired output spacing.  This is only used if the ResizeMethod is
		/// set to OutputSpacing.  If you want to keep one of the original spacing
		/// values, then set that spacing value to zero.
		/// </summary>
		// Token: 0x06016423 RID: 91171 RVA: 0x001F54AB File Offset: 0x001F36AB
		public virtual void SetOutputSpacing(double _arg1, double _arg2, double _arg3)
		{
			vtkImageResize.vtkImageResize_SetOutputSpacing_45(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06016424 RID: 91172
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResize_SetOutputSpacing_46(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// The desired output spacing.  This is only used if the ResizeMethod is
		/// set to OutputSpacing.  If you want to keep one of the original spacing
		/// values, then set that spacing value to zero.
		/// </summary>
		// Token: 0x06016425 RID: 91173 RVA: 0x001F54BD File Offset: 0x001F36BD
		public virtual void SetOutputSpacing(IntPtr _arg)
		{
			vtkImageResize.vtkImageResize_SetOutputSpacing_46(base.GetCppThis(), _arg);
		}

		// Token: 0x06016426 RID: 91174
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResize_SetResizeMethod_47(HandleRef pThis, int _arg);

		/// <summary>
		/// The resizing method to use.  The default is to set the output image
		/// dimensions, and allow the filter to resize the image to these new
		/// dimensions.  It is also possible to resize the image by setting the
		/// output image spacing or by setting a magnification factor.
		/// </summary>
		// Token: 0x06016427 RID: 91175 RVA: 0x001F54CD File Offset: 0x001F36CD
		public virtual void SetResizeMethod(int _arg)
		{
			vtkImageResize.vtkImageResize_SetResizeMethod_47(base.GetCppThis(), _arg);
		}

		// Token: 0x06016428 RID: 91176
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResize_SetResizeMethodToMagnificationFactors_48(HandleRef pThis);

		/// <summary>
		/// The resizing method to use.  The default is to set the output image
		/// dimensions, and allow the filter to resize the image to these new
		/// dimensions.  It is also possible to resize the image by setting the
		/// output image spacing or by setting a magnification factor.
		/// </summary>
		// Token: 0x06016429 RID: 91177 RVA: 0x001F54DD File Offset: 0x001F36DD
		public void SetResizeMethodToMagnificationFactors()
		{
			vtkImageResize.vtkImageResize_SetResizeMethodToMagnificationFactors_48(base.GetCppThis());
		}

		// Token: 0x0601642A RID: 91178
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResize_SetResizeMethodToOutputDimensions_49(HandleRef pThis);

		/// <summary>
		/// The resizing method to use.  The default is to set the output image
		/// dimensions, and allow the filter to resize the image to these new
		/// dimensions.  It is also possible to resize the image by setting the
		/// output image spacing or by setting a magnification factor.
		/// </summary>
		// Token: 0x0601642B RID: 91179 RVA: 0x001F54EC File Offset: 0x001F36EC
		public void SetResizeMethodToOutputDimensions()
		{
			vtkImageResize.vtkImageResize_SetResizeMethodToOutputDimensions_49(base.GetCppThis());
		}

		// Token: 0x0601642C RID: 91180
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageResize_SetResizeMethodToOutputSpacing_50(HandleRef pThis);

		/// <summary>
		/// The resizing method to use.  The default is to set the output image
		/// dimensions, and allow the filter to resize the image to these new
		/// dimensions.  It is also possible to resize the image by setting the
		/// output image spacing or by setting a magnification factor.
		/// </summary>
		// Token: 0x0601642D RID: 91181 RVA: 0x001F54FB File Offset: 0x001F36FB
		public void SetResizeMethodToOutputSpacing()
		{
			vtkImageResize.vtkImageResize_SetResizeMethodToOutputSpacing_50(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001918 RID: 6424
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageResize";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001919 RID: 6425
		public new static readonly string MRClassNameKey = "class vtkImageResize";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000863 RID: 2147
		public enum MAGNIFICATION_FACTORS_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x0400191B RID: 6427
			MAGNIFICATION_FACTORS = 2,
			/// <summary>enum member</summary>
			// Token: 0x0400191C RID: 6428
			OUTPUT_DIMENSIONS = 0,
			/// <summary>enum member</summary>
			// Token: 0x0400191D RID: 6429
			OUTPUT_SPACING
		}
	}
}
