using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFixedPointRayCastImage
	/// </summary>
	/// <remarks>
	///    helper class for a ray cast image
	///
	/// This is a helper class for storing the ray cast image including the
	/// underlying data and the size of the image. This class is not intended
	/// to be used directly - just as an internal class in the
	/// vtkFixedPointVolumeRayCastMapper so that multiple mappers can share
	/// the same image. This class also stored the ZBuffer (if necessary due
	/// to intermixed geometry). Perhaps this class could be generalized
	/// in the future to be used for other ray cast methods other than the
	/// fixed point method.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkFixedPointVolumeRayCastMapper
	/// </seealso>
	// Token: 0x02000395 RID: 917
	public class vtkFixedPointRayCastImage : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A6CD RID: 42701 RVA: 0x000ECA6F File Offset: 0x000EAC6F
		static vtkFixedPointRayCastImage()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFixedPointRayCastImage.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFixedPointRayCastImage"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A6CE RID: 42702 RVA: 0x000ECA97 File Offset: 0x000EAC97
		public vtkFixedPointRayCastImage(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A6CF RID: 42703
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointRayCastImage_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A6D0 RID: 42704 RVA: 0x000ECAA8 File Offset: 0x000EACA8
		public new static vtkFixedPointRayCastImage New()
		{
			vtkFixedPointRayCastImage result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedPointRayCastImage)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A6D1 RID: 42705 RVA: 0x000ECAFC File Offset: 0x000EACFC
		public vtkFixedPointRayCastImage() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A6D2 RID: 42706 RVA: 0x000ECB40 File Offset: 0x000EAD40
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A6D3 RID: 42707
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointRayCastImage_AllocateImage_01(HandleRef pThis);

		/// <summary>
		/// Call this method once the ImageMemorySize has been set
		/// the allocate the image. If an image already exists,
		/// it will be deleted first.
		/// </summary>
		// Token: 0x0600A6D4 RID: 42708 RVA: 0x000ECB4B File Offset: 0x000EAD4B
		public void AllocateImage()
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_AllocateImage_01(base.GetCppThis());
		}

		// Token: 0x0600A6D5 RID: 42709
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointRayCastImage_AllocateZBuffer_02(HandleRef pThis);

		/// <summary>
		/// Get the ZBuffer. The size of the ZBuffer should be specific
		/// with SetZBufferSize, and AllocateZBuffer method should be called
		/// before getting the ZBuffer.
		/// </summary>
		// Token: 0x0600A6D6 RID: 42710 RVA: 0x000ECB5A File Offset: 0x000EAD5A
		public void AllocateZBuffer()
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_AllocateZBuffer_02(base.GetCppThis());
		}

		// Token: 0x0600A6D7 RID: 42711
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointRayCastImage_ClearImage_03(HandleRef pThis);

		/// <summary>
		/// Clear the image to (0,0,0,0) for each pixel.
		/// </summary>
		// Token: 0x0600A6D8 RID: 42712 RVA: 0x000ECB69 File Offset: 0x000EAD69
		public void ClearImage()
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_ClearImage_03(base.GetCppThis());
		}

		// Token: 0x0600A6D9 RID: 42713
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointRayCastImage_GetImage_04(HandleRef pThis);

		/// <summary>
		/// Get the internal storage for the image. It is a pointer to
		/// unsigned short with four components (RGBA) per pixel. This
		/// memory is allocated when the AllocateImage method is called.
		/// </summary>
		// Token: 0x0600A6DA RID: 42714 RVA: 0x000ECB78 File Offset: 0x000EAD78
		public IntPtr GetImage()
		{
			return vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetImage_04(base.GetCppThis());
		}

		// Token: 0x0600A6DB RID: 42715
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointRayCastImage_GetImageInUseSize_05(HandleRef pThis);

		/// <summary>
		/// Set / Get the size of the image we are actually using. As
		/// long as the memory size is big enough, but not too big,
		/// we won't bother deleting and re-allocated, we'll just
		/// continue to use the memory size we have. This size will
		/// always be equal to or less than the ImageMemorySize.
		/// </summary>
		// Token: 0x0600A6DC RID: 42716 RVA: 0x000ECB98 File Offset: 0x000EAD98
		public virtual int[] GetImageInUseSize()
		{
			IntPtr intPtr = vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetImageInUseSize_05(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600A6DD RID: 42717
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointRayCastImage_GetImageInUseSize_06(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set / Get the size of the image we are actually using. As
		/// long as the memory size is big enough, but not too big,
		/// we won't bother deleting and re-allocated, we'll just
		/// continue to use the memory size we have. This size will
		/// always be equal to or less than the ImageMemorySize.
		/// </summary>
		// Token: 0x0600A6DE RID: 42718 RVA: 0x000ECBE0 File Offset: 0x000EADE0
		public virtual void GetImageInUseSize(IntPtr data)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetImageInUseSize_06(base.GetCppThis(), data);
		}

		// Token: 0x0600A6DF RID: 42719
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointRayCastImage_GetImageMemorySize_07(HandleRef pThis);

		/// <summary>
		/// Set / Get the ImageMemorySize. This is the size in pixels
		/// of the Image ivar. This will be a power of two in order
		/// to ensure that the texture can be rendered by graphics
		/// hardware that requires power of two textures.
		/// </summary>
		// Token: 0x0600A6E0 RID: 42720 RVA: 0x000ECBF0 File Offset: 0x000EADF0
		public virtual int[] GetImageMemorySize()
		{
			IntPtr intPtr = vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetImageMemorySize_07(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600A6E1 RID: 42721
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointRayCastImage_GetImageMemorySize_08(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set / Get the ImageMemorySize. This is the size in pixels
		/// of the Image ivar. This will be a power of two in order
		/// to ensure that the texture can be rendered by graphics
		/// hardware that requires power of two textures.
		/// </summary>
		// Token: 0x0600A6E2 RID: 42722 RVA: 0x000ECC38 File Offset: 0x000EAE38
		public virtual void GetImageMemorySize(IntPtr data)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetImageMemorySize_08(base.GetCppThis(), data);
		}

		// Token: 0x0600A6E3 RID: 42723
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointRayCastImage_GetImageOrigin_09(HandleRef pThis);

		/// <summary>
		/// Set / Get the origin of the image. This is the starting
		/// pixel within the whole viewport that our Image starts on.
		/// That is, we could be generating just a subregion of the
		/// whole viewport due to the fact that our volume occupies
		/// only a portion of the viewport. The Image pixels will
		/// start from this location.
		/// </summary>
		// Token: 0x0600A6E4 RID: 42724 RVA: 0x000ECC48 File Offset: 0x000EAE48
		public virtual int[] GetImageOrigin()
		{
			IntPtr intPtr = vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetImageOrigin_09(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600A6E5 RID: 42725
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointRayCastImage_GetImageOrigin_10(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set / Get the origin of the image. This is the starting
		/// pixel within the whole viewport that our Image starts on.
		/// That is, we could be generating just a subregion of the
		/// whole viewport due to the fact that our volume occupies
		/// only a portion of the viewport. The Image pixels will
		/// start from this location.
		/// </summary>
		// Token: 0x0600A6E6 RID: 42726 RVA: 0x000ECC90 File Offset: 0x000EAE90
		public virtual void GetImageOrigin(IntPtr data)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetImageOrigin_10(base.GetCppThis(), data);
		}

		// Token: 0x0600A6E7 RID: 42727
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFixedPointRayCastImage_GetImageSampleDistance_11(HandleRef pThis);

		/// <summary>
		/// Set / Get the ImageSampleDistance that will be used for
		/// rendering. This is a copy of the value stored in the
		/// mapper. It is stored here for sharing between all mappers
		/// that are participating in the creation of this image.
		/// </summary>
		// Token: 0x0600A6E8 RID: 42728 RVA: 0x000ECCA0 File Offset: 0x000EAEA0
		public virtual float GetImageSampleDistance()
		{
			return vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetImageSampleDistance_11(base.GetCppThis());
		}

		// Token: 0x0600A6E9 RID: 42729
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointRayCastImage_GetImageViewportSize_12(HandleRef pThis);

		/// <summary>
		/// Set / Get the ImageViewportSize. This is the size of the
		/// whole viewport in pixels.
		/// </summary>
		// Token: 0x0600A6EA RID: 42730 RVA: 0x000ECCC0 File Offset: 0x000EAEC0
		public virtual int[] GetImageViewportSize()
		{
			IntPtr intPtr = vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetImageViewportSize_12(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600A6EB RID: 42731
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointRayCastImage_GetImageViewportSize_13(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set / Get the ImageViewportSize. This is the size of the
		/// whole viewport in pixels.
		/// </summary>
		// Token: 0x0600A6EC RID: 42732 RVA: 0x000ECD08 File Offset: 0x000EAF08
		public virtual void GetImageViewportSize(IntPtr data)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetImageViewportSize_13(base.GetCppThis(), data);
		}

		// Token: 0x0600A6ED RID: 42733
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFixedPointRayCastImage_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A6EE RID: 42734 RVA: 0x000ECD18 File Offset: 0x000EAF18
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x0600A6EF RID: 42735
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFixedPointRayCastImage_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A6F0 RID: 42736 RVA: 0x000ECD38 File Offset: 0x000EAF38
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x0600A6F1 RID: 42737
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointRayCastImage_GetUseZBuffer_16(HandleRef pThis);

		/// <summary>
		/// The UseZBuffer flag indicates whether the ZBuffer is in use.
		/// The ZBuffer is captured and used when IntermixIntersectingGeometry
		/// is on in the mapper, and when there are props that have been
		/// rendered before the current volume.
		/// </summary>
		// Token: 0x0600A6F2 RID: 42738 RVA: 0x000ECD54 File Offset: 0x000EAF54
		public virtual int GetUseZBuffer()
		{
			return vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetUseZBuffer_16(base.GetCppThis());
		}

		// Token: 0x0600A6F3 RID: 42739
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointRayCastImage_GetUseZBufferMaxValue_17(HandleRef pThis);

		/// <summary>
		/// The UseZBuffer flag indicates whether the ZBuffer is in use.
		/// The ZBuffer is captured and used when IntermixIntersectingGeometry
		/// is on in the mapper, and when there are props that have been
		/// rendered before the current volume.
		/// </summary>
		// Token: 0x0600A6F4 RID: 42740 RVA: 0x000ECD74 File Offset: 0x000EAF74
		public virtual int GetUseZBufferMaxValue()
		{
			return vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetUseZBufferMaxValue_17(base.GetCppThis());
		}

		// Token: 0x0600A6F5 RID: 42741
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointRayCastImage_GetUseZBufferMinValue_18(HandleRef pThis);

		/// <summary>
		/// The UseZBuffer flag indicates whether the ZBuffer is in use.
		/// The ZBuffer is captured and used when IntermixIntersectingGeometry
		/// is on in the mapper, and when there are props that have been
		/// rendered before the current volume.
		/// </summary>
		// Token: 0x0600A6F6 RID: 42742 RVA: 0x000ECD94 File Offset: 0x000EAF94
		public virtual int GetUseZBufferMinValue()
		{
			return vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetUseZBufferMinValue_18(base.GetCppThis());
		}

		// Token: 0x0600A6F7 RID: 42743
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointRayCastImage_GetZBuffer_19(HandleRef pThis);

		/// <summary>
		/// Get the ZBuffer. The size of the ZBuffer should be specific
		/// with SetZBufferSize, and AllocateZBuffer method should be called
		/// before getting the ZBuffer.
		/// </summary>
		// Token: 0x0600A6F8 RID: 42744 RVA: 0x000ECDB4 File Offset: 0x000EAFB4
		public IntPtr GetZBuffer()
		{
			return vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetZBuffer_19(base.GetCppThis());
		}

		// Token: 0x0600A6F9 RID: 42745
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointRayCastImage_GetZBufferOrigin_20(HandleRef pThis);

		/// <summary>
		/// Set / Get the origin of the ZBuffer. This is the distance
		/// from the lower left corner of the viewport where the ZBuffer
		/// started (multiply the ImageOrigin by the ImageSampleDistance)
		/// This is the pixel location on the full resolution viewport
		/// where the ZBuffer capture will start. These values are used
		/// to convert the (x,y) pixel location within the ImageInUseSize
		/// image into a ZBuffer location.
		/// </summary>
		// Token: 0x0600A6FA RID: 42746 RVA: 0x000ECDD4 File Offset: 0x000EAFD4
		public virtual int[] GetZBufferOrigin()
		{
			IntPtr intPtr = vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetZBufferOrigin_20(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600A6FB RID: 42747
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointRayCastImage_GetZBufferOrigin_21(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set / Get the origin of the ZBuffer. This is the distance
		/// from the lower left corner of the viewport where the ZBuffer
		/// started (multiply the ImageOrigin by the ImageSampleDistance)
		/// This is the pixel location on the full resolution viewport
		/// where the ZBuffer capture will start. These values are used
		/// to convert the (x,y) pixel location within the ImageInUseSize
		/// image into a ZBuffer location.
		/// </summary>
		// Token: 0x0600A6FC RID: 42748 RVA: 0x000ECE1C File Offset: 0x000EB01C
		public virtual void GetZBufferOrigin(IntPtr data)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetZBufferOrigin_21(base.GetCppThis(), data);
		}

		// Token: 0x0600A6FD RID: 42749
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointRayCastImage_GetZBufferSize_22(HandleRef pThis);

		/// <summary>
		/// Set / Get the size of the ZBuffer in pixels. The zbuffer will
		/// be captured for the region of the screen covered by the
		/// ImageInUseSize image. However, due to subsampling, the size
		/// of the ImageInUseSize image may be smaller than this ZBuffer
		/// image which will be captured at screen resolution.
		/// </summary>
		// Token: 0x0600A6FE RID: 42750 RVA: 0x000ECE2C File Offset: 0x000EB02C
		public virtual int[] GetZBufferSize()
		{
			IntPtr intPtr = vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetZBufferSize_22(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600A6FF RID: 42751
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointRayCastImage_GetZBufferSize_23(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set / Get the size of the ZBuffer in pixels. The zbuffer will
		/// be captured for the region of the screen covered by the
		/// ImageInUseSize image. However, due to subsampling, the size
		/// of the ImageInUseSize image may be smaller than this ZBuffer
		/// image which will be captured at screen resolution.
		/// </summary>
		// Token: 0x0600A700 RID: 42752 RVA: 0x000ECE74 File Offset: 0x000EB074
		public virtual void GetZBufferSize(IntPtr data)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetZBufferSize_23(base.GetCppThis(), data);
		}

		// Token: 0x0600A701 RID: 42753
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkFixedPointRayCastImage_GetZBufferValue_24(HandleRef pThis, int x, int y);

		/// <summary>
		/// Get the ZBuffer value corresponding to location (x,y) where (x,y)
		/// are indexing into the ImageInUse image. This must be converted to
		/// the zbuffer image coordinates. Nearest neighbor value is returned.
		/// If UseZBuffer is off, then 1.0 is always returned.
		/// </summary>
		// Token: 0x0600A702 RID: 42754 RVA: 0x000ECE84 File Offset: 0x000EB084
		public float GetZBufferValue(int x, int y)
		{
			return vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetZBufferValue_24(base.GetCppThis(), x, y);
		}

		// Token: 0x0600A703 RID: 42755
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointRayCastImage_IsA_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A704 RID: 42756 RVA: 0x000ECEA8 File Offset: 0x000EB0A8
		public override int IsA(string type)
		{
			return vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_IsA_25(base.GetCppThis(), type);
		}

		// Token: 0x0600A705 RID: 42757
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedPointRayCastImage_IsTypeOf_26([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A706 RID: 42758 RVA: 0x000ECEC8 File Offset: 0x000EB0C8
		public new static int IsTypeOf(string type)
		{
			return vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_IsTypeOf_26(type);
		}

		// Token: 0x0600A707 RID: 42759
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointRayCastImage_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A708 RID: 42760 RVA: 0x000ECEE4 File Offset: 0x000EB0E4
		public new vtkFixedPointRayCastImage NewInstance()
		{
			vtkFixedPointRayCastImage result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_NewInstance_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedPointRayCastImage)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A709 RID: 42761
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedPointRayCastImage_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A70A RID: 42762 RVA: 0x000ECF40 File Offset: 0x000EB140
		public new static vtkFixedPointRayCastImage SafeDownCast(vtkObjectBase o)
		{
			vtkFixedPointRayCastImage vtkFixedPointRayCastImage = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFixedPointRayCastImage = (vtkFixedPointRayCastImage)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFixedPointRayCastImage.Register(null);
				}
			}
			return vtkFixedPointRayCastImage;
		}

		// Token: 0x0600A70B RID: 42763
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointRayCastImage_SetImageInUseSize_30(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Set / Get the size of the image we are actually using. As
		/// long as the memory size is big enough, but not too big,
		/// we won't bother deleting and re-allocated, we'll just
		/// continue to use the memory size we have. This size will
		/// always be equal to or less than the ImageMemorySize.
		/// </summary>
		// Token: 0x0600A70C RID: 42764 RVA: 0x000ECFBF File Offset: 0x000EB1BF
		public virtual void SetImageInUseSize(int _arg1, int _arg2)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_SetImageInUseSize_30(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600A70D RID: 42765
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointRayCastImage_SetImageInUseSize_31(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set / Get the size of the image we are actually using. As
		/// long as the memory size is big enough, but not too big,
		/// we won't bother deleting and re-allocated, we'll just
		/// continue to use the memory size we have. This size will
		/// always be equal to or less than the ImageMemorySize.
		/// </summary>
		// Token: 0x0600A70E RID: 42766 RVA: 0x000ECFD0 File Offset: 0x000EB1D0
		public void SetImageInUseSize(IntPtr _arg)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_SetImageInUseSize_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A70F RID: 42767
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointRayCastImage_SetImageMemorySize_32(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Set / Get the ImageMemorySize. This is the size in pixels
		/// of the Image ivar. This will be a power of two in order
		/// to ensure that the texture can be rendered by graphics
		/// hardware that requires power of two textures.
		/// </summary>
		// Token: 0x0600A710 RID: 42768 RVA: 0x000ECFE0 File Offset: 0x000EB1E0
		public virtual void SetImageMemorySize(int _arg1, int _arg2)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_SetImageMemorySize_32(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600A711 RID: 42769
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointRayCastImage_SetImageMemorySize_33(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set / Get the ImageMemorySize. This is the size in pixels
		/// of the Image ivar. This will be a power of two in order
		/// to ensure that the texture can be rendered by graphics
		/// hardware that requires power of two textures.
		/// </summary>
		// Token: 0x0600A712 RID: 42770 RVA: 0x000ECFF1 File Offset: 0x000EB1F1
		public void SetImageMemorySize(IntPtr _arg)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_SetImageMemorySize_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A713 RID: 42771
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointRayCastImage_SetImageOrigin_34(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Set / Get the origin of the image. This is the starting
		/// pixel within the whole viewport that our Image starts on.
		/// That is, we could be generating just a subregion of the
		/// whole viewport due to the fact that our volume occupies
		/// only a portion of the viewport. The Image pixels will
		/// start from this location.
		/// </summary>
		// Token: 0x0600A714 RID: 42772 RVA: 0x000ED001 File Offset: 0x000EB201
		public virtual void SetImageOrigin(int _arg1, int _arg2)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_SetImageOrigin_34(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600A715 RID: 42773
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointRayCastImage_SetImageOrigin_35(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set / Get the origin of the image. This is the starting
		/// pixel within the whole viewport that our Image starts on.
		/// That is, we could be generating just a subregion of the
		/// whole viewport due to the fact that our volume occupies
		/// only a portion of the viewport. The Image pixels will
		/// start from this location.
		/// </summary>
		// Token: 0x0600A716 RID: 42774 RVA: 0x000ED012 File Offset: 0x000EB212
		public void SetImageOrigin(IntPtr _arg)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_SetImageOrigin_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A717 RID: 42775
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointRayCastImage_SetImageSampleDistance_36(HandleRef pThis, float _arg);

		/// <summary>
		/// Set / Get the ImageSampleDistance that will be used for
		/// rendering. This is a copy of the value stored in the
		/// mapper. It is stored here for sharing between all mappers
		/// that are participating in the creation of this image.
		/// </summary>
		// Token: 0x0600A718 RID: 42776 RVA: 0x000ED022 File Offset: 0x000EB222
		public virtual void SetImageSampleDistance(float _arg)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_SetImageSampleDistance_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A719 RID: 42777
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointRayCastImage_SetImageViewportSize_37(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Set / Get the ImageViewportSize. This is the size of the
		/// whole viewport in pixels.
		/// </summary>
		// Token: 0x0600A71A RID: 42778 RVA: 0x000ED032 File Offset: 0x000EB232
		public virtual void SetImageViewportSize(int _arg1, int _arg2)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_SetImageViewportSize_37(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600A71B RID: 42779
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointRayCastImage_SetImageViewportSize_38(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set / Get the ImageViewportSize. This is the size of the
		/// whole viewport in pixels.
		/// </summary>
		// Token: 0x0600A71C RID: 42780 RVA: 0x000ED043 File Offset: 0x000EB243
		public void SetImageViewportSize(IntPtr _arg)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_SetImageViewportSize_38(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A71D RID: 42781
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointRayCastImage_SetUseZBuffer_39(HandleRef pThis, int _arg);

		/// <summary>
		/// The UseZBuffer flag indicates whether the ZBuffer is in use.
		/// The ZBuffer is captured and used when IntermixIntersectingGeometry
		/// is on in the mapper, and when there are props that have been
		/// rendered before the current volume.
		/// </summary>
		// Token: 0x0600A71E RID: 42782 RVA: 0x000ED053 File Offset: 0x000EB253
		public virtual void SetUseZBuffer(int _arg)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_SetUseZBuffer_39(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A71F RID: 42783
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointRayCastImage_SetZBufferOrigin_40(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Set / Get the origin of the ZBuffer. This is the distance
		/// from the lower left corner of the viewport where the ZBuffer
		/// started (multiply the ImageOrigin by the ImageSampleDistance)
		/// This is the pixel location on the full resolution viewport
		/// where the ZBuffer capture will start. These values are used
		/// to convert the (x,y) pixel location within the ImageInUseSize
		/// image into a ZBuffer location.
		/// </summary>
		// Token: 0x0600A720 RID: 42784 RVA: 0x000ED063 File Offset: 0x000EB263
		public virtual void SetZBufferOrigin(int _arg1, int _arg2)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_SetZBufferOrigin_40(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600A721 RID: 42785
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointRayCastImage_SetZBufferOrigin_41(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set / Get the origin of the ZBuffer. This is the distance
		/// from the lower left corner of the viewport where the ZBuffer
		/// started (multiply the ImageOrigin by the ImageSampleDistance)
		/// This is the pixel location on the full resolution viewport
		/// where the ZBuffer capture will start. These values are used
		/// to convert the (x,y) pixel location within the ImageInUseSize
		/// image into a ZBuffer location.
		/// </summary>
		// Token: 0x0600A722 RID: 42786 RVA: 0x000ED074 File Offset: 0x000EB274
		public void SetZBufferOrigin(IntPtr _arg)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_SetZBufferOrigin_41(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A723 RID: 42787
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointRayCastImage_SetZBufferSize_42(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Set / Get the size of the ZBuffer in pixels. The zbuffer will
		/// be captured for the region of the screen covered by the
		/// ImageInUseSize image. However, due to subsampling, the size
		/// of the ImageInUseSize image may be smaller than this ZBuffer
		/// image which will be captured at screen resolution.
		/// </summary>
		// Token: 0x0600A724 RID: 42788 RVA: 0x000ED084 File Offset: 0x000EB284
		public virtual void SetZBufferSize(int _arg1, int _arg2)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_SetZBufferSize_42(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600A725 RID: 42789
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointRayCastImage_SetZBufferSize_43(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set / Get the size of the ZBuffer in pixels. The zbuffer will
		/// be captured for the region of the screen covered by the
		/// ImageInUseSize image. However, due to subsampling, the size
		/// of the ImageInUseSize image may be smaller than this ZBuffer
		/// image which will be captured at screen resolution.
		/// </summary>
		// Token: 0x0600A726 RID: 42790 RVA: 0x000ED095 File Offset: 0x000EB295
		public void SetZBufferSize(IntPtr _arg)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_SetZBufferSize_43(base.GetCppThis(), _arg);
		}

		// Token: 0x0600A727 RID: 42791
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointRayCastImage_UseZBufferOff_44(HandleRef pThis);

		/// <summary>
		/// The UseZBuffer flag indicates whether the ZBuffer is in use.
		/// The ZBuffer is captured and used when IntermixIntersectingGeometry
		/// is on in the mapper, and when there are props that have been
		/// rendered before the current volume.
		/// </summary>
		// Token: 0x0600A728 RID: 42792 RVA: 0x000ED0A5 File Offset: 0x000EB2A5
		public virtual void UseZBufferOff()
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_UseZBufferOff_44(base.GetCppThis());
		}

		// Token: 0x0600A729 RID: 42793
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedPointRayCastImage_UseZBufferOn_45(HandleRef pThis);

		/// <summary>
		/// The UseZBuffer flag indicates whether the ZBuffer is in use.
		/// The ZBuffer is captured and used when IntermixIntersectingGeometry
		/// is on in the mapper, and when there are props that have been
		/// rendered before the current volume.
		/// </summary>
		// Token: 0x0600A72A RID: 42794 RVA: 0x000ED0B4 File Offset: 0x000EB2B4
		public virtual void UseZBufferOn()
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_UseZBufferOn_45(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D5F RID: 3423
		public new const string MRFullTypeName = "Kitware.VTK.vtkFixedPointRayCastImage";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D60 RID: 3424
		public new static readonly string MRClassNameKey = "class vtkFixedPointRayCastImage";
	}
}
