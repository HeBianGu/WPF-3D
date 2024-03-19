using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkResizingWindowToImageFilter
	/// </summary>
	/// <remarks>
	///    Use a vtkWindow as input to image pipeline
	///
	/// vtkResizingWindowToImageFilter provides methods needed to read the data in
	/// a vtkWindow and use it as input to the imaging pipeline. This is
	/// useful for saving an image to a file for example. The window can
	/// be read as either RGB or RGBA pixels;  in addition, the depth buffer
	/// can also be read.   RGB and RGBA pixels are of type unsigned char,
	/// while Z-Buffer data is returned as floats.  Use this filter
	/// to convert RenderWindows or ImageWindows to an image format.
	///
	/// @note
	/// In contrast to the vtkWindowToImageFilter, this allows also for non-integral
	/// values to be used as scaling factors for the generated image. Also, it
	/// provides a SizeLimit parameter which enables to control when the algorithm
	/// will switch to using tiling for generating a large image instead of
	/// rendering the entire result at once.
	///
	/// @warning
	/// A vtkWindow doesn't behave like other parts of the VTK pipeline: its
	/// modification time doesn't get updated when an image is rendered.  As a
	/// result, naive use of vtkResizingWindowToImageFilter will produce an image of
	/// the first image that the window rendered, but which is never updated
	/// on subsequent window updates.  This behavior is unexpected and in
	/// general undesirable.
	///
	/// @warning
	/// To force an update of the output image, call vtkResizingWindowToImageFilter's
	/// Modified method after rendering to the window.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRendererSource vtkRendererPointCloudSource vtkWindow
	/// vtkRenderLargeImage vtkWindowToImageFilter
	/// </seealso>
	// Token: 0x020007FE RID: 2046
	public class vtkResizingWindowToImageFilter : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015041 RID: 86081 RVA: 0x001DBCF1 File Offset: 0x001D9EF1
		static vtkResizingWindowToImageFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkResizingWindowToImageFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkResizingWindowToImageFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015042 RID: 86082 RVA: 0x001DBD19 File Offset: 0x001D9F19
		public vtkResizingWindowToImageFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015043 RID: 86083
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResizingWindowToImageFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015044 RID: 86084 RVA: 0x001DBD28 File Offset: 0x001D9F28
		public new static vtkResizingWindowToImageFilter New()
		{
			vtkResizingWindowToImageFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResizingWindowToImageFilter.vtkResizingWindowToImageFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkResizingWindowToImageFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015045 RID: 86085 RVA: 0x001DBD7C File Offset: 0x001D9F7C
		public vtkResizingWindowToImageFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkResizingWindowToImageFilter.vtkResizingWindowToImageFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015046 RID: 86086 RVA: 0x001DBDC0 File Offset: 0x001D9FC0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015047 RID: 86087
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResizingWindowToImageFilter_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns which renderer is being used as the source for the pixel data.
		/// Initial value is 0.
		/// </summary>
		// Token: 0x06015048 RID: 86088 RVA: 0x001DBDCC File Offset: 0x001D9FCC
		public virtual vtkWindow GetInput()
		{
			vtkWindow vtkWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResizingWindowToImageFilter.vtkResizingWindowToImageFilter_GetInput_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWindow = (vtkWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWindow.Register(null);
				}
			}
			return vtkWindow;
		}

		// Token: 0x06015049 RID: 86089
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResizingWindowToImageFilter_GetInputBufferType_02(HandleRef pThis);

		/// <summary>
		/// Set/get the window buffer from which data will be read.  Choices
		/// include VTK_RGB (read the color image from the window), VTK_RGBA
		/// (same, but include the alpha channel), and VTK_ZBUFFER (depth
		/// buffer, returned as a float array). Initial value is VTK_RGB.
		/// </summary>
		// Token: 0x0601504A RID: 86090 RVA: 0x001DBE3C File Offset: 0x001DA03C
		public virtual int GetInputBufferType()
		{
			return vtkResizingWindowToImageFilter.vtkResizingWindowToImageFilter_GetInputBufferType_02(base.GetCppThis());
		}

		// Token: 0x0601504B RID: 86091
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResizingWindowToImageFilter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601504C RID: 86092 RVA: 0x001DBE5C File Offset: 0x001DA05C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkResizingWindowToImageFilter.vtkResizingWindowToImageFilter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601504D RID: 86093
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResizingWindowToImageFilter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601504E RID: 86094 RVA: 0x001DBE7C File Offset: 0x001DA07C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkResizingWindowToImageFilter.vtkResizingWindowToImageFilter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601504F RID: 86095
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResizingWindowToImageFilter_GetOutput_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06015050 RID: 86096 RVA: 0x001DBE98 File Offset: 0x001DA098
		public vtkImageData GetOutput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResizingWindowToImageFilter.vtkResizingWindowToImageFilter_GetOutput_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06015051 RID: 86097
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResizingWindowToImageFilter_GetSize_06(HandleRef pThis);

		/// <summary>
		/// Get/Set the size of the target image in pixels.
		/// </summary>
		// Token: 0x06015052 RID: 86098 RVA: 0x001DBF08 File Offset: 0x001DA108
		public virtual int[] GetSize()
		{
			IntPtr intPtr = vtkResizingWindowToImageFilter.vtkResizingWindowToImageFilter_GetSize_06(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06015053 RID: 86099
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResizingWindowToImageFilter_GetSize_07(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Get/Set the size of the target image in pixels.
		/// </summary>
		// Token: 0x06015054 RID: 86100 RVA: 0x001DBF50 File Offset: 0x001DA150
		public virtual void GetSize(ref int _arg1, ref int _arg2)
		{
			vtkResizingWindowToImageFilter.vtkResizingWindowToImageFilter_GetSize_07(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06015055 RID: 86101
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResizingWindowToImageFilter_GetSize_08(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the size of the target image in pixels.
		/// </summary>
		// Token: 0x06015056 RID: 86102 RVA: 0x001DBF61 File Offset: 0x001DA161
		public virtual void GetSize(IntPtr _arg)
		{
			vtkResizingWindowToImageFilter.vtkResizingWindowToImageFilter_GetSize_08(base.GetCppThis(), _arg);
		}

		// Token: 0x06015057 RID: 86103
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResizingWindowToImageFilter_GetSizeLimit_09(HandleRef pThis);

		/// <summary>
		/// Get/Set the size limit of the image (in pixels per axis) for switching
		/// from rendering the entire image in memory to using tiling which uses less
		/// memory but may fail to produce the exact size in pixels as requested.
		/// </summary>
		// Token: 0x06015058 RID: 86104 RVA: 0x001DBF74 File Offset: 0x001DA174
		public virtual int GetSizeLimit()
		{
			return vtkResizingWindowToImageFilter.vtkResizingWindowToImageFilter_GetSizeLimit_09(base.GetCppThis());
		}

		// Token: 0x06015059 RID: 86105
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResizingWindowToImageFilter_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601505A RID: 86106 RVA: 0x001DBF94 File Offset: 0x001DA194
		public override int IsA(string type)
		{
			return vtkResizingWindowToImageFilter.vtkResizingWindowToImageFilter_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0601505B RID: 86107
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResizingWindowToImageFilter_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601505C RID: 86108 RVA: 0x001DBFB4 File Offset: 0x001DA1B4
		public new static int IsTypeOf(string type)
		{
			return vtkResizingWindowToImageFilter.vtkResizingWindowToImageFilter_IsTypeOf_11(type);
		}

		// Token: 0x0601505D RID: 86109
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResizingWindowToImageFilter_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601505E RID: 86110 RVA: 0x001DBFD0 File Offset: 0x001DA1D0
		public new vtkResizingWindowToImageFilter NewInstance()
		{
			vtkResizingWindowToImageFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResizingWindowToImageFilter.vtkResizingWindowToImageFilter_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkResizingWindowToImageFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601505F RID: 86111
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResizingWindowToImageFilter_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015060 RID: 86112 RVA: 0x001DC02C File Offset: 0x001DA22C
		public new static vtkResizingWindowToImageFilter SafeDownCast(vtkObjectBase o)
		{
			vtkResizingWindowToImageFilter vtkResizingWindowToImageFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResizingWindowToImageFilter.vtkResizingWindowToImageFilter_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkResizingWindowToImageFilter = (vtkResizingWindowToImageFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkResizingWindowToImageFilter.Register(null);
				}
			}
			return vtkResizingWindowToImageFilter;
		}

		// Token: 0x06015061 RID: 86113
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResizingWindowToImageFilter_SetInput_15(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Indicates what renderer to get the pixel data from. Initial value is 0.
		/// </summary>
		// Token: 0x06015062 RID: 86114 RVA: 0x001DC0AC File Offset: 0x001DA2AC
		public void SetInput(vtkWindow input)
		{
			vtkResizingWindowToImageFilter.vtkResizingWindowToImageFilter_SetInput_15(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06015063 RID: 86115
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResizingWindowToImageFilter_SetInputBufferType_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the window buffer from which data will be read.  Choices
		/// include VTK_RGB (read the color image from the window), VTK_RGBA
		/// (same, but include the alpha channel), and VTK_ZBUFFER (depth
		/// buffer, returned as a float array). Initial value is VTK_RGB.
		/// </summary>
		// Token: 0x06015064 RID: 86116 RVA: 0x001DC0DB File Offset: 0x001DA2DB
		public virtual void SetInputBufferType(int _arg)
		{
			vtkResizingWindowToImageFilter.vtkResizingWindowToImageFilter_SetInputBufferType_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06015065 RID: 86117
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResizingWindowToImageFilter_SetInputBufferTypeToRGB_17(HandleRef pThis);

		/// <summary>
		/// Set/get the window buffer from which data will be read.  Choices
		/// include VTK_RGB (read the color image from the window), VTK_RGBA
		/// (same, but include the alpha channel), and VTK_ZBUFFER (depth
		/// buffer, returned as a float array). Initial value is VTK_RGB.
		/// </summary>
		// Token: 0x06015066 RID: 86118 RVA: 0x001DC0EB File Offset: 0x001DA2EB
		public void SetInputBufferTypeToRGB()
		{
			vtkResizingWindowToImageFilter.vtkResizingWindowToImageFilter_SetInputBufferTypeToRGB_17(base.GetCppThis());
		}

		// Token: 0x06015067 RID: 86119
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResizingWindowToImageFilter_SetInputBufferTypeToRGBA_18(HandleRef pThis);

		/// <summary>
		/// Set/get the window buffer from which data will be read.  Choices
		/// include VTK_RGB (read the color image from the window), VTK_RGBA
		/// (same, but include the alpha channel), and VTK_ZBUFFER (depth
		/// buffer, returned as a float array). Initial value is VTK_RGB.
		/// </summary>
		// Token: 0x06015068 RID: 86120 RVA: 0x001DC0FA File Offset: 0x001DA2FA
		public void SetInputBufferTypeToRGBA()
		{
			vtkResizingWindowToImageFilter.vtkResizingWindowToImageFilter_SetInputBufferTypeToRGBA_18(base.GetCppThis());
		}

		// Token: 0x06015069 RID: 86121
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResizingWindowToImageFilter_SetInputBufferTypeToZBuffer_19(HandleRef pThis);

		/// <summary>
		/// Set/get the window buffer from which data will be read.  Choices
		/// include VTK_RGB (read the color image from the window), VTK_RGBA
		/// (same, but include the alpha channel), and VTK_ZBUFFER (depth
		/// buffer, returned as a float array). Initial value is VTK_RGB.
		/// </summary>
		// Token: 0x0601506A RID: 86122 RVA: 0x001DC109 File Offset: 0x001DA309
		public void SetInputBufferTypeToZBuffer()
		{
			vtkResizingWindowToImageFilter.vtkResizingWindowToImageFilter_SetInputBufferTypeToZBuffer_19(base.GetCppThis());
		}

		// Token: 0x0601506B RID: 86123
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResizingWindowToImageFilter_SetSize_20(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Get/Set the size of the target image in pixels.
		/// </summary>
		// Token: 0x0601506C RID: 86124 RVA: 0x001DC118 File Offset: 0x001DA318
		public virtual void SetSize(int _arg1, int _arg2)
		{
			vtkResizingWindowToImageFilter.vtkResizingWindowToImageFilter_SetSize_20(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0601506D RID: 86125
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResizingWindowToImageFilter_SetSize_21(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the size of the target image in pixels.
		/// </summary>
		// Token: 0x0601506E RID: 86126 RVA: 0x001DC129 File Offset: 0x001DA329
		public void SetSize(IntPtr _arg)
		{
			vtkResizingWindowToImageFilter.vtkResizingWindowToImageFilter_SetSize_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0601506F RID: 86127
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResizingWindowToImageFilter_SetSizeLimit_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the size limit of the image (in pixels per axis) for switching
		/// from rendering the entire image in memory to using tiling which uses less
		/// memory but may fail to produce the exact size in pixels as requested.
		/// </summary>
		// Token: 0x06015070 RID: 86128 RVA: 0x001DC139 File Offset: 0x001DA339
		public virtual void SetSizeLimit(int _arg)
		{
			vtkResizingWindowToImageFilter.vtkResizingWindowToImageFilter_SetSizeLimit_22(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001840 RID: 6208
		public new const string MRFullTypeName = "Kitware.VTK.vtkResizingWindowToImageFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001841 RID: 6209
		public new static readonly string MRClassNameKey = "class vtkResizingWindowToImageFilter";
	}
}
