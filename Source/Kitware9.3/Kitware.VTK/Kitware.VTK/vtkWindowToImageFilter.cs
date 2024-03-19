using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkWindowToImageFilter
	/// </summary>
	/// <remarks>
	///    Use a vtkWindow as input to image pipeline
	///
	/// vtkWindowToImageFilter provides methods needed to read the data in
	/// a vtkWindow and use it as input to the imaging pipeline. This is
	/// useful for saving an image to a file for example. The window can
	/// be read as either RGB or RGBA pixels;  in addition, the depth buffer
	/// can also be read.   RGB and RGBA pixels are of type unsigned char,
	/// while Z-Buffer data is returned as floats.  Use this filter
	/// to convert RenderWindows or ImageWindows to an image format.
	///
	/// @warning
	/// A vtkWindow doesn't behave like other parts of the VTK pipeline: its
	/// modification time doesn't get updated when an image is rendered.  As a
	/// result, naive use of vtkWindowToImageFilter will produce an image of
	/// the first image that the window rendered, but which is never updated
	/// on subsequent window updates.  This behavior is unexpected and in
	/// general undesirable.
	///
	/// @warning
	/// To force an update of the output image, call vtkWindowToImageFilter's
	/// Modified method after rendering to the window.
	///
	/// @warning
	/// In VTK versions 4 and later, this filter is part of the canonical
	/// way to output an image of a window to a file (replacing the
	/// obsolete SaveImageAsPPM method for vtkRenderWindows that existed in
	/// 3.2 and earlier).  Connect this filter to the output of the window,
	/// and filter's output to a writer such as vtkPNGWriter.
	///
	/// @warning
	/// Reading back alpha planes is dependent on the correct operation of
	/// the render window's GetRGBACharPixelData method, which in turn is
	/// dependent on the configuration of the window's alpha planes.  As of
	/// VTK 4.4+, machine-independent behavior is not automatically
	/// assured because of these dependencies.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRendererSource vtkRendererPointCloudSource vtkWindow
	/// vtkRenderLargeImage
	/// </seealso>
	// Token: 0x0200080C RID: 2060
	public class vtkWindowToImageFilter : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060152DE RID: 86750 RVA: 0x001DF977 File Offset: 0x001DDB77
		static vtkWindowToImageFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWindowToImageFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWindowToImageFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060152DF RID: 86751 RVA: 0x001DF99F File Offset: 0x001DDB9F
		public vtkWindowToImageFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060152E0 RID: 86752
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindowToImageFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060152E1 RID: 86753 RVA: 0x001DF9B0 File Offset: 0x001DDBB0
		public new static vtkWindowToImageFilter New()
		{
			vtkWindowToImageFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWindowToImageFilter.vtkWindowToImageFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWindowToImageFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060152E2 RID: 86754 RVA: 0x001DFA04 File Offset: 0x001DDC04
		public vtkWindowToImageFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkWindowToImageFilter.vtkWindowToImageFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060152E3 RID: 86755 RVA: 0x001DFA48 File Offset: 0x001DDC48
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060152E4 RID: 86756
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowToImageFilter_FixBoundaryOff_01(HandleRef pThis);

		/// <summary>
		/// When scale factor &gt; 1, this class render the full image in tiles.
		/// Sometimes that results in artificial artifacts at internal tile seams.
		/// To overcome this issue, set this flag to true.
		/// </summary>
		// Token: 0x060152E5 RID: 86757 RVA: 0x001DFA53 File Offset: 0x001DDC53
		public virtual void FixBoundaryOff()
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_FixBoundaryOff_01(base.GetCppThis());
		}

		// Token: 0x060152E6 RID: 86758
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowToImageFilter_FixBoundaryOn_02(HandleRef pThis);

		/// <summary>
		/// When scale factor &gt; 1, this class render the full image in tiles.
		/// Sometimes that results in artificial artifacts at internal tile seams.
		/// To overcome this issue, set this flag to true.
		/// </summary>
		// Token: 0x060152E7 RID: 86759 RVA: 0x001DFA62 File Offset: 0x001DDC62
		public virtual void FixBoundaryOn()
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_FixBoundaryOn_02(base.GetCppThis());
		}

		// Token: 0x060152E8 RID: 86760
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkWindowToImageFilter_GetFixBoundary_03(HandleRef pThis);

		/// <summary>
		/// When scale factor &gt; 1, this class render the full image in tiles.
		/// Sometimes that results in artificial artifacts at internal tile seams.
		/// To overcome this issue, set this flag to true.
		/// </summary>
		// Token: 0x060152E9 RID: 86761 RVA: 0x001DFA74 File Offset: 0x001DDC74
		public virtual bool GetFixBoundary()
		{
			return vtkWindowToImageFilter.vtkWindowToImageFilter_GetFixBoundary_03(base.GetCppThis()) != 0;
		}

		// Token: 0x060152EA RID: 86762
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindowToImageFilter_GetInput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns which renderer is being used as the source for the pixel data.
		/// Initial value is 0.
		/// </summary>
		// Token: 0x060152EB RID: 86763 RVA: 0x001DFA9C File Offset: 0x001DDC9C
		public virtual vtkWindow GetInput()
		{
			vtkWindow vtkWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWindowToImageFilter.vtkWindowToImageFilter_GetInput_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060152EC RID: 86764
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindowToImageFilter_GetInputBufferType_05(HandleRef pThis);

		/// <summary>
		/// Set/get the window buffer from which data will be read.  Choices
		/// include VTK_RGB (read the color image from the window), VTK_RGBA
		/// (same, but include the alpha channel), and VTK_ZBUFFER (depth
		/// buffer, returned as a float array). Initial value is VTK_RGB.
		/// </summary>
		// Token: 0x060152ED RID: 86765 RVA: 0x001DFB0C File Offset: 0x001DDD0C
		public virtual int GetInputBufferType()
		{
			return vtkWindowToImageFilter.vtkWindowToImageFilter_GetInputBufferType_05(base.GetCppThis());
		}

		// Token: 0x060152EE RID: 86766
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWindowToImageFilter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060152EF RID: 86767 RVA: 0x001DFB2C File Offset: 0x001DDD2C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkWindowToImageFilter.vtkWindowToImageFilter_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x060152F0 RID: 86768
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWindowToImageFilter_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060152F1 RID: 86769 RVA: 0x001DFB4C File Offset: 0x001DDD4C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkWindowToImageFilter.vtkWindowToImageFilter_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x060152F2 RID: 86770
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindowToImageFilter_GetOutput_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x060152F3 RID: 86771 RVA: 0x001DFB68 File Offset: 0x001DDD68
		public vtkImageData GetOutput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWindowToImageFilter.vtkWindowToImageFilter_GetOutput_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060152F4 RID: 86772
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindowToImageFilter_GetReadFrontBuffer_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag that determines which buffer to read from.
		/// The default is to read from the front buffer.
		/// </summary>
		// Token: 0x060152F5 RID: 86773 RVA: 0x001DFBD8 File Offset: 0x001DDDD8
		public virtual int GetReadFrontBuffer()
		{
			return vtkWindowToImageFilter.vtkWindowToImageFilter_GetReadFrontBuffer_09(base.GetCppThis());
		}

		// Token: 0x060152F6 RID: 86774
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindowToImageFilter_GetScale_10(HandleRef pThis);

		/// <summary>
		/// Get/Set the scale (or magnification) factors in X and Y.
		/// </summary>
		// Token: 0x060152F7 RID: 86775 RVA: 0x001DFBF8 File Offset: 0x001DDDF8
		public virtual int[] GetScale()
		{
			IntPtr intPtr = vtkWindowToImageFilter.vtkWindowToImageFilter_GetScale_10(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060152F8 RID: 86776
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowToImageFilter_GetScale_11(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Get/Set the scale (or magnification) factors in X and Y.
		/// </summary>
		// Token: 0x060152F9 RID: 86777 RVA: 0x001DFC40 File Offset: 0x001DDE40
		public virtual void GetScale(ref int _arg1, ref int _arg2)
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_GetScale_11(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x060152FA RID: 86778
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowToImageFilter_GetScale_12(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the scale (or magnification) factors in X and Y.
		/// </summary>
		// Token: 0x060152FB RID: 86779 RVA: 0x001DFC51 File Offset: 0x001DDE51
		public virtual void GetScale(IntPtr _arg)
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_GetScale_12(base.GetCppThis(), _arg);
		}

		// Token: 0x060152FC RID: 86780
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindowToImageFilter_GetShouldRerender_13(HandleRef pThis);

		/// <summary>
		/// Set/get whether to re-render the input window. Initial value is true.
		/// (This option makes no difference if scale factor &gt; 1.)
		/// </summary>
		// Token: 0x060152FD RID: 86781 RVA: 0x001DFC64 File Offset: 0x001DDE64
		public virtual int GetShouldRerender()
		{
			return vtkWindowToImageFilter.vtkWindowToImageFilter_GetShouldRerender_13(base.GetCppThis());
		}

		// Token: 0x060152FE RID: 86782
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindowToImageFilter_GetViewport_14(HandleRef pThis);

		/// <summary>
		/// Set/get the extents to be used to generate the image. Initial value is
		/// {0,0,1,1} (This option does not work if scale factor &gt; 1.)
		/// </summary>
		// Token: 0x060152FF RID: 86783 RVA: 0x001DFC84 File Offset: 0x001DDE84
		public virtual double[] GetViewport()
		{
			IntPtr intPtr = vtkWindowToImageFilter.vtkWindowToImageFilter_GetViewport_14(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06015300 RID: 86784
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowToImageFilter_GetViewport_15(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/get the extents to be used to generate the image. Initial value is
		/// {0,0,1,1} (This option does not work if scale factor &gt; 1.)
		/// </summary>
		// Token: 0x06015301 RID: 86785 RVA: 0x001DFCCC File Offset: 0x001DDECC
		public virtual void GetViewport(IntPtr data)
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_GetViewport_15(base.GetCppThis(), data);
		}

		// Token: 0x06015302 RID: 86786
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindowToImageFilter_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015303 RID: 86787 RVA: 0x001DFCDC File Offset: 0x001DDEDC
		public override int IsA(string type)
		{
			return vtkWindowToImageFilter.vtkWindowToImageFilter_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x06015304 RID: 86788
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindowToImageFilter_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015305 RID: 86789 RVA: 0x001DFCFC File Offset: 0x001DDEFC
		public new static int IsTypeOf(string type)
		{
			return vtkWindowToImageFilter.vtkWindowToImageFilter_IsTypeOf_17(type);
		}

		// Token: 0x06015306 RID: 86790
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindowToImageFilter_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015307 RID: 86791 RVA: 0x001DFD18 File Offset: 0x001DDF18
		public new vtkWindowToImageFilter NewInstance()
		{
			vtkWindowToImageFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWindowToImageFilter.vtkWindowToImageFilter_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWindowToImageFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015308 RID: 86792
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowToImageFilter_ReadFrontBufferOff_20(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag that determines which buffer to read from.
		/// The default is to read from the front buffer.
		/// </summary>
		// Token: 0x06015309 RID: 86793 RVA: 0x001DFD72 File Offset: 0x001DDF72
		public virtual void ReadFrontBufferOff()
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_ReadFrontBufferOff_20(base.GetCppThis());
		}

		// Token: 0x0601530A RID: 86794
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowToImageFilter_ReadFrontBufferOn_21(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag that determines which buffer to read from.
		/// The default is to read from the front buffer.
		/// </summary>
		// Token: 0x0601530B RID: 86795 RVA: 0x001DFD81 File Offset: 0x001DDF81
		public virtual void ReadFrontBufferOn()
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_ReadFrontBufferOn_21(base.GetCppThis());
		}

		// Token: 0x0601530C RID: 86796
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindowToImageFilter_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601530D RID: 86797 RVA: 0x001DFD90 File Offset: 0x001DDF90
		public new static vtkWindowToImageFilter SafeDownCast(vtkObjectBase o)
		{
			vtkWindowToImageFilter vtkWindowToImageFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWindowToImageFilter.vtkWindowToImageFilter_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWindowToImageFilter = (vtkWindowToImageFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWindowToImageFilter.Register(null);
				}
			}
			return vtkWindowToImageFilter;
		}

		// Token: 0x0601530E RID: 86798
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowToImageFilter_SetFixBoundary_23(HandleRef pThis, byte _arg);

		/// <summary>
		/// When scale factor &gt; 1, this class render the full image in tiles.
		/// Sometimes that results in artificial artifacts at internal tile seams.
		/// To overcome this issue, set this flag to true.
		/// </summary>
		// Token: 0x0601530F RID: 86799 RVA: 0x001DFE0F File Offset: 0x001DE00F
		public virtual void SetFixBoundary(bool _arg)
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_SetFixBoundary_23(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06015310 RID: 86800
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowToImageFilter_SetInput_24(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Indicates what renderer to get the pixel data from. Initial value is 0.
		/// </summary>
		// Token: 0x06015311 RID: 86801 RVA: 0x001DFE28 File Offset: 0x001DE028
		public void SetInput(vtkWindow input)
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_SetInput_24(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06015312 RID: 86802
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowToImageFilter_SetInputBufferType_25(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the window buffer from which data will be read.  Choices
		/// include VTK_RGB (read the color image from the window), VTK_RGBA
		/// (same, but include the alpha channel), and VTK_ZBUFFER (depth
		/// buffer, returned as a float array). Initial value is VTK_RGB.
		/// </summary>
		// Token: 0x06015313 RID: 86803 RVA: 0x001DFE57 File Offset: 0x001DE057
		public virtual void SetInputBufferType(int _arg)
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_SetInputBufferType_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06015314 RID: 86804
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowToImageFilter_SetInputBufferTypeToRGB_26(HandleRef pThis);

		/// <summary>
		/// Set/get the window buffer from which data will be read.  Choices
		/// include VTK_RGB (read the color image from the window), VTK_RGBA
		/// (same, but include the alpha channel), and VTK_ZBUFFER (depth
		/// buffer, returned as a float array). Initial value is VTK_RGB.
		/// </summary>
		// Token: 0x06015315 RID: 86805 RVA: 0x001DFE67 File Offset: 0x001DE067
		public void SetInputBufferTypeToRGB()
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_SetInputBufferTypeToRGB_26(base.GetCppThis());
		}

		// Token: 0x06015316 RID: 86806
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowToImageFilter_SetInputBufferTypeToRGBA_27(HandleRef pThis);

		/// <summary>
		/// Set/get the window buffer from which data will be read.  Choices
		/// include VTK_RGB (read the color image from the window), VTK_RGBA
		/// (same, but include the alpha channel), and VTK_ZBUFFER (depth
		/// buffer, returned as a float array). Initial value is VTK_RGB.
		/// </summary>
		// Token: 0x06015317 RID: 86807 RVA: 0x001DFE76 File Offset: 0x001DE076
		public void SetInputBufferTypeToRGBA()
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_SetInputBufferTypeToRGBA_27(base.GetCppThis());
		}

		// Token: 0x06015318 RID: 86808
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowToImageFilter_SetInputBufferTypeToZBuffer_28(HandleRef pThis);

		/// <summary>
		/// Set/get the window buffer from which data will be read.  Choices
		/// include VTK_RGB (read the color image from the window), VTK_RGBA
		/// (same, but include the alpha channel), and VTK_ZBUFFER (depth
		/// buffer, returned as a float array). Initial value is VTK_RGB.
		/// </summary>
		// Token: 0x06015319 RID: 86809 RVA: 0x001DFE85 File Offset: 0x001DE085
		public void SetInputBufferTypeToZBuffer()
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_SetInputBufferTypeToZBuffer_28(base.GetCppThis());
		}

		// Token: 0x0601531A RID: 86810
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowToImageFilter_SetReadFrontBuffer_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the flag that determines which buffer to read from.
		/// The default is to read from the front buffer.
		/// </summary>
		// Token: 0x0601531B RID: 86811 RVA: 0x001DFE94 File Offset: 0x001DE094
		public virtual void SetReadFrontBuffer(int _arg)
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_SetReadFrontBuffer_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0601531C RID: 86812
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowToImageFilter_SetScale_30(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Get/Set the scale (or magnification) factors in X and Y.
		/// </summary>
		// Token: 0x0601531D RID: 86813 RVA: 0x001DFEA4 File Offset: 0x001DE0A4
		public virtual void SetScale(int _arg1, int _arg2)
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_SetScale_30(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0601531E RID: 86814
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowToImageFilter_SetScale_31(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the scale (or magnification) factors in X and Y.
		/// </summary>
		// Token: 0x0601531F RID: 86815 RVA: 0x001DFEB5 File Offset: 0x001DE0B5
		public void SetScale(IntPtr _arg)
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_SetScale_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06015320 RID: 86816
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowToImageFilter_SetScale_32(HandleRef pThis, int scale);

		/// <summary>
		/// Convenience method to set same scale factors for x and y.
		/// i.e. same as calling this-&gt;SetScale(scale, scale).
		/// </summary>
		// Token: 0x06015321 RID: 86817 RVA: 0x001DFEC5 File Offset: 0x001DE0C5
		public void SetScale(int scale)
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_SetScale_32(base.GetCppThis(), scale);
		}

		// Token: 0x06015322 RID: 86818
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowToImageFilter_SetShouldRerender_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get whether to re-render the input window. Initial value is true.
		/// (This option makes no difference if scale factor &gt; 1.)
		/// </summary>
		// Token: 0x06015323 RID: 86819 RVA: 0x001DFED5 File Offset: 0x001DE0D5
		public virtual void SetShouldRerender(int _arg)
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_SetShouldRerender_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06015324 RID: 86820
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowToImageFilter_SetViewport_34(HandleRef pThis, double arg0, double arg1, double arg2, double arg3);

		/// <summary>
		/// Set/get the extents to be used to generate the image. Initial value is
		/// {0,0,1,1} (This option does not work if scale factor &gt; 1.)
		/// </summary>
		// Token: 0x06015325 RID: 86821 RVA: 0x001DFEE5 File Offset: 0x001DE0E5
		public void SetViewport(double arg0, double arg1, double arg2, double arg3)
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_SetViewport_34(base.GetCppThis(), arg0, arg1, arg2, arg3);
		}

		// Token: 0x06015326 RID: 86822
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowToImageFilter_SetViewport_35(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Set/get the extents to be used to generate the image. Initial value is
		/// {0,0,1,1} (This option does not work if scale factor &gt; 1.)
		/// </summary>
		// Token: 0x06015327 RID: 86823 RVA: 0x001DFEF9 File Offset: 0x001DE0F9
		public void SetViewport(IntPtr arg0)
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_SetViewport_35(base.GetCppThis(), arg0);
		}

		// Token: 0x06015328 RID: 86824
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowToImageFilter_ShouldRerenderOff_36(HandleRef pThis);

		/// <summary>
		/// Set/get whether to re-render the input window. Initial value is true.
		/// (This option makes no difference if scale factor &gt; 1.)
		/// </summary>
		// Token: 0x06015329 RID: 86825 RVA: 0x001DFF09 File Offset: 0x001DE109
		public virtual void ShouldRerenderOff()
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_ShouldRerenderOff_36(base.GetCppThis());
		}

		// Token: 0x0601532A RID: 86826
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowToImageFilter_ShouldRerenderOn_37(HandleRef pThis);

		/// <summary>
		/// Set/get whether to re-render the input window. Initial value is true.
		/// (This option makes no difference if scale factor &gt; 1.)
		/// </summary>
		// Token: 0x0601532B RID: 86827 RVA: 0x001DFF18 File Offset: 0x001DE118
		public virtual void ShouldRerenderOn()
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_ShouldRerenderOn_37(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001860 RID: 6240
		public new const string MRFullTypeName = "Kitware.VTK.vtkWindowToImageFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001861 RID: 6241
		public new static readonly string MRClassNameKey = "class vtkWindowToImageFilter";
	}
}
