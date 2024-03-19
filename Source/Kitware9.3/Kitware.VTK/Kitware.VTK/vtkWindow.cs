using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkWindow
	/// </summary>
	/// <remarks>
	///    window superclass for vtkRenderWindow
	///
	/// vtkWindow is an abstract object to specify the behavior of a
	/// rendering window.  It contains vtkViewports.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderWindow vtkViewport
	/// </seealso>
	// Token: 0x02000090 RID: 144
	public class vtkWindow : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06001BC9 RID: 7113 RVA: 0x0002C351 File Offset: 0x0002A551
		static vtkWindow()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWindow.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWindow"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06001BCA RID: 7114 RVA: 0x0002C379 File Offset: 0x0002A579
		public vtkWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06001BCB RID: 7115 RVA: 0x0002C387 File Offset: 0x0002A587
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06001BCC RID: 7116
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkWindow_DetectDPI_01(HandleRef pThis);

		/// <summary>
		/// Attempt to detect and set the DPI of the display device by querying the
		/// system. Note that this is not supported on most backends, and this method
		/// will return false if the DPI could not be detected. Use GetDPI() to
		/// inspect the detected value.
		/// </summary>
		// Token: 0x06001BCD RID: 7117 RVA: 0x0002C394 File Offset: 0x0002A594
		public virtual bool DetectDPI()
		{
			return vtkWindow.vtkWindow_DetectDPI_01(base.GetCppThis()) != 0;
		}

		// Token: 0x06001BCE RID: 7118
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_DoubleBufferOff_02(HandleRef pThis);

		/// <summary>
		/// Keep track of whether double buffering is on or off
		/// </summary>
		// Token: 0x06001BCF RID: 7119 RVA: 0x0002C3BA File Offset: 0x0002A5BA
		public virtual void DoubleBufferOff()
		{
			vtkWindow.vtkWindow_DoubleBufferOff_02(base.GetCppThis());
		}

		// Token: 0x06001BD0 RID: 7120
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_DoubleBufferOn_03(HandleRef pThis);

		/// <summary>
		/// Keep track of whether double buffering is on or off
		/// </summary>
		// Token: 0x06001BD1 RID: 7121 RVA: 0x0002C3C9 File Offset: 0x0002A5C9
		public virtual void DoubleBufferOn()
		{
			vtkWindow.vtkWindow_DoubleBufferOn_03(base.GetCppThis());
		}

		// Token: 0x06001BD2 RID: 7122
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_EraseOff_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off erasing the screen between images. This allows multiple
		/// exposure sequences if turned on. You will need to turn double
		/// buffering off or make use of the SwapBuffers methods to prevent
		/// you from swapping buffers between exposures.
		/// </summary>
		// Token: 0x06001BD3 RID: 7123 RVA: 0x0002C3D8 File Offset: 0x0002A5D8
		public virtual void EraseOff()
		{
			vtkWindow.vtkWindow_EraseOff_04(base.GetCppThis());
		}

		// Token: 0x06001BD4 RID: 7124
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_EraseOn_05(HandleRef pThis);

		/// <summary>
		/// Turn on/off erasing the screen between images. This allows multiple
		/// exposure sequences if turned on. You will need to turn double
		/// buffering off or make use of the SwapBuffers methods to prevent
		/// you from swapping buffers between exposures.
		/// </summary>
		// Token: 0x06001BD5 RID: 7125 RVA: 0x0002C3E7 File Offset: 0x0002A5E7
		public virtual void EraseOn()
		{
			vtkWindow.vtkWindow_EraseOn_05(base.GetCppThis());
		}

		// Token: 0x06001BD6 RID: 7126
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindow_GetActualSize_06(HandleRef pThis);

		/// <summary>
		/// GetSize() returns the size * this-&gt;TileScale, whereas this method returns
		/// the size without multiplying with the tile scale. Measured in pixels.
		/// </summary>
		// Token: 0x06001BD7 RID: 7127 RVA: 0x0002C3F8 File Offset: 0x0002A5F8
		public IntPtr GetActualSize()
		{
			return vtkWindow.vtkWindow_GetActualSize_06(base.GetCppThis());
		}

		// Token: 0x06001BD8 RID: 7128
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindow_GetDPI_07(HandleRef pThis);

		/// <summary>
		/// Return a best estimate to the dots per inch of the display
		/// device being rendered (or printed).
		/// </summary>
		// Token: 0x06001BD9 RID: 7129 RVA: 0x0002C418 File Offset: 0x0002A618
		public virtual int GetDPI()
		{
			return vtkWindow.vtkWindow_GetDPI_07(base.GetCppThis());
		}

		// Token: 0x06001BDA RID: 7130
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindow_GetDPIMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Return a best estimate to the dots per inch of the display
		/// device being rendered (or printed).
		/// </summary>
		// Token: 0x06001BDB RID: 7131 RVA: 0x0002C438 File Offset: 0x0002A638
		public virtual int GetDPIMaxValue()
		{
			return vtkWindow.vtkWindow_GetDPIMaxValue_08(base.GetCppThis());
		}

		// Token: 0x06001BDC RID: 7132
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindow_GetDPIMinValue_09(HandleRef pThis);

		/// <summary>
		/// Return a best estimate to the dots per inch of the display
		/// device being rendered (or printed).
		/// </summary>
		// Token: 0x06001BDD RID: 7133 RVA: 0x0002C458 File Offset: 0x0002A658
		public virtual int GetDPIMinValue()
		{
			return vtkWindow.vtkWindow_GetDPIMinValue_09(base.GetCppThis());
		}

		// Token: 0x06001BDE RID: 7134
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindow_GetDoubleBuffer_10(HandleRef pThis);

		/// <summary>
		/// Keep track of whether double buffering is on or off
		/// </summary>
		// Token: 0x06001BDF RID: 7135 RVA: 0x0002C478 File Offset: 0x0002A678
		public virtual int GetDoubleBuffer()
		{
			return vtkWindow.vtkWindow_GetDoubleBuffer_10(base.GetCppThis());
		}

		// Token: 0x06001BE0 RID: 7136
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindow_GetErase_11(HandleRef pThis);

		/// <summary>
		/// Turn on/off erasing the screen between images. This allows multiple
		/// exposure sequences if turned on. You will need to turn double
		/// buffering off or make use of the SwapBuffers methods to prevent
		/// you from swapping buffers between exposures.
		/// </summary>
		// Token: 0x06001BE1 RID: 7137 RVA: 0x0002C498 File Offset: 0x0002A698
		public virtual int GetErase()
		{
			return vtkWindow.vtkWindow_GetErase_11(base.GetCppThis());
		}

		// Token: 0x06001BE2 RID: 7138
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindow_GetGenericContext_12(HandleRef pThis);

		/// <summary>
		/// These are window system independent methods that are used
		/// to help interface vtkWindow to native windowing systems.
		/// </summary>
		// Token: 0x06001BE3 RID: 7139 RVA: 0x0002C4B8 File Offset: 0x0002A6B8
		public virtual IntPtr GetGenericContext()
		{
			return vtkWindow.vtkWindow_GetGenericContext_12(base.GetCppThis());
		}

		// Token: 0x06001BE4 RID: 7140
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindow_GetGenericDisplayId_13(HandleRef pThis);

		/// <summary>
		/// These are window system independent methods that are used
		/// to help interface vtkWindow to native windowing systems.
		/// </summary>
		// Token: 0x06001BE5 RID: 7141 RVA: 0x0002C4D8 File Offset: 0x0002A6D8
		public virtual IntPtr GetGenericDisplayId()
		{
			return vtkWindow.vtkWindow_GetGenericDisplayId_13(base.GetCppThis());
		}

		// Token: 0x06001BE6 RID: 7142
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindow_GetGenericDrawable_14(HandleRef pThis);

		/// <summary>
		/// These are window system independent methods that are used
		/// to help interface vtkWindow to native windowing systems.
		/// </summary>
		// Token: 0x06001BE7 RID: 7143 RVA: 0x0002C4F8 File Offset: 0x0002A6F8
		public virtual IntPtr GetGenericDrawable()
		{
			return vtkWindow.vtkWindow_GetGenericDrawable_14(base.GetCppThis());
		}

		// Token: 0x06001BE8 RID: 7144
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindow_GetGenericParentId_15(HandleRef pThis);

		/// <summary>
		/// These are window system independent methods that are used
		/// to help interface vtkWindow to native windowing systems.
		/// </summary>
		// Token: 0x06001BE9 RID: 7145 RVA: 0x0002C518 File Offset: 0x0002A718
		public virtual IntPtr GetGenericParentId()
		{
			return vtkWindow.vtkWindow_GetGenericParentId_15(base.GetCppThis());
		}

		// Token: 0x06001BEA RID: 7146
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindow_GetGenericWindowId_16(HandleRef pThis);

		/// <summary>
		/// These are window system independent methods that are used
		/// to help interface vtkWindow to native windowing systems.
		/// </summary>
		// Token: 0x06001BEB RID: 7147 RVA: 0x0002C538 File Offset: 0x0002A738
		public virtual IntPtr GetGenericWindowId()
		{
			return vtkWindow.vtkWindow_GetGenericWindowId_16(base.GetCppThis());
		}

		// Token: 0x06001BEC RID: 7148
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindow_GetMapped_17(HandleRef pThis);

		/// <summary>
		/// Keep track of whether the rendering window has been mapped to screen.
		/// </summary>
		// Token: 0x06001BED RID: 7149 RVA: 0x0002C558 File Offset: 0x0002A758
		public virtual int GetMapped()
		{
			return vtkWindow.vtkWindow_GetMapped_17(base.GetCppThis());
		}

		// Token: 0x06001BEE RID: 7150
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWindow_GetNumberOfGenerationsFromBase_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001BEF RID: 7151 RVA: 0x0002C578 File Offset: 0x0002A778
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkWindow.vtkWindow_GetNumberOfGenerationsFromBase_18(base.GetCppThis(), type);
		}

		// Token: 0x06001BF0 RID: 7152
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWindow_GetNumberOfGenerationsFromBaseType_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001BF1 RID: 7153 RVA: 0x0002C598 File Offset: 0x0002A798
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkWindow.vtkWindow_GetNumberOfGenerationsFromBaseType_19(type);
		}

		// Token: 0x06001BF2 RID: 7154
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindow_GetOffScreenRendering_20(HandleRef pThis);

		/// <summary>
		/// Deprecated, directly use GetShowWindow and GetOffScreenBuffers
		/// instead.
		/// </summary>
		// Token: 0x06001BF3 RID: 7155 RVA: 0x0002C5B4 File Offset: 0x0002A7B4
		public int GetOffScreenRendering()
		{
			return vtkWindow.vtkWindow_GetOffScreenRendering_20(base.GetCppThis());
		}

		// Token: 0x06001BF4 RID: 7156
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindow_GetPixelData_21(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, int arg4, int arg5);

		/// <summary>
		/// Get the pixel data of an image, transmitted as RGBRGBRGB. The
		/// front argument indicates if the front buffer should be used or the back
		/// buffer. It is the caller's responsibility to delete the resulting
		/// array. It is very important to realize that the memory in this array
		/// is organized from the bottom of the window to the top. The origin
		/// of the screen is in the lower left corner. The y axis increases as
		/// you go up the screen. So the storage of pixels is from left to right
		/// and from bottom to top.
		/// (x,y) is any corner of the rectangle. (x2,y2) is its opposite corner on
		/// the diagonal.
		/// </summary>
		// Token: 0x06001BF5 RID: 7157 RVA: 0x0002C5D4 File Offset: 0x0002A7D4
		public virtual IntPtr GetPixelData(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)
		{
			return vtkWindow.vtkWindow_GetPixelData_21(base.GetCppThis(), arg0, arg1, arg2, arg3, arg4, arg5);
		}

		// Token: 0x06001BF6 RID: 7158
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindow_GetPixelData_22(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, int arg4, HandleRef arg5, int arg6);

		/// <summary>
		/// Get the pixel data of an image, transmitted as RGBRGBRGB. The
		/// front argument indicates if the front buffer should be used or the back
		/// buffer. It is the caller's responsibility to delete the resulting
		/// array. It is very important to realize that the memory in this array
		/// is organized from the bottom of the window to the top. The origin
		/// of the screen is in the lower left corner. The y axis increases as
		/// you go up the screen. So the storage of pixels is from left to right
		/// and from bottom to top.
		/// (x,y) is any corner of the rectangle. (x2,y2) is its opposite corner on
		/// the diagonal.
		/// </summary>
		// Token: 0x06001BF7 RID: 7159 RVA: 0x0002C5FC File Offset: 0x0002A7FC
		public virtual int GetPixelData(int arg0, int arg1, int arg2, int arg3, int arg4, vtkUnsignedCharArray arg5, int arg6)
		{
			return vtkWindow.vtkWindow_GetPixelData_22(base.GetCppThis(), arg0, arg1, arg2, arg3, arg4, (arg5 == null) ? default(HandleRef) : arg5.GetCppThis(), arg6);
		}

		// Token: 0x06001BF8 RID: 7160
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindow_GetPosition_23(HandleRef pThis);

		/// <summary>
		/// Get the position (x and y) of the rendering window in
		/// screen coordinates (in pixels).
		/// </summary>
		// Token: 0x06001BF9 RID: 7161 RVA: 0x0002C63C File Offset: 0x0002A83C
		public virtual int[] GetPosition()
		{
			IntPtr intPtr = vtkWindow.vtkWindow_GetPosition_23(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06001BFA RID: 7162
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindow_GetScreenSize_24(HandleRef pThis);

		/// <summary>
		/// Get the current size of the screen in pixels.
		/// </summary>
		// Token: 0x06001BFB RID: 7163 RVA: 0x0002C684 File Offset: 0x0002A884
		public virtual int[] GetScreenSize()
		{
			IntPtr intPtr = vtkWindow.vtkWindow_GetScreenSize_24(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06001BFC RID: 7164
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkWindow_GetShowWindow_25(HandleRef pThis);

		/// <summary>
		/// Show or not Show the window
		/// </summary>
		// Token: 0x06001BFD RID: 7165 RVA: 0x0002C6CC File Offset: 0x0002A8CC
		public virtual bool GetShowWindow()
		{
			return vtkWindow.vtkWindow_GetShowWindow_25(base.GetCppThis()) != 0;
		}

		// Token: 0x06001BFE RID: 7166
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindow_GetSize_26(HandleRef pThis);

		/// <summary>
		/// Get the size (width and height) of the rendering window in
		/// screen coordinates (in pixels).
		/// </summary>
		// Token: 0x06001BFF RID: 7167 RVA: 0x0002C6F4 File Offset: 0x0002A8F4
		public virtual int[] GetSize()
		{
			IntPtr intPtr = vtkWindow.vtkWindow_GetSize_26(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06001C00 RID: 7168
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindow_GetTileScale_27(HandleRef pThis);

		/// <summary>
		/// These methods are used by vtkWindowToImageFilter to tell a VTK window
		/// to simulate a larger window by tiling. For 3D geometry these methods
		/// have no impact. It is just in handling annotation that this information
		/// must be available to the mappers and the coordinate calculations.
		/// </summary>
		// Token: 0x06001C01 RID: 7169 RVA: 0x0002C73C File Offset: 0x0002A93C
		public virtual int[] GetTileScale()
		{
			IntPtr intPtr = vtkWindow.vtkWindow_GetTileScale_27(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06001C02 RID: 7170
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_GetTileScale_28(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// These methods are used by vtkWindowToImageFilter to tell a VTK window
		/// to simulate a larger window by tiling. For 3D geometry these methods
		/// have no impact. It is just in handling annotation that this information
		/// must be available to the mappers and the coordinate calculations.
		/// </summary>
		// Token: 0x06001C03 RID: 7171 RVA: 0x0002C784 File Offset: 0x0002A984
		public virtual void GetTileScale(ref int _arg1, ref int _arg2)
		{
			vtkWindow.vtkWindow_GetTileScale_28(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06001C04 RID: 7172
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_GetTileScale_29(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// These methods are used by vtkWindowToImageFilter to tell a VTK window
		/// to simulate a larger window by tiling. For 3D geometry these methods
		/// have no impact. It is just in handling annotation that this information
		/// must be available to the mappers and the coordinate calculations.
		/// </summary>
		// Token: 0x06001C05 RID: 7173 RVA: 0x0002C795 File Offset: 0x0002A995
		public virtual void GetTileScale(IntPtr _arg)
		{
			vtkWindow.vtkWindow_GetTileScale_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06001C06 RID: 7174
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindow_GetTileViewport_30(HandleRef pThis);

		/// <summary>
		/// These methods are used by vtkWindowToImageFilter to tell a VTK window
		/// to simulate a larger window by tiling. For 3D geometry these methods
		/// have no impact. It is just in handling annotation that this information
		/// must be available to the mappers and the coordinate calculations.
		/// </summary>
		// Token: 0x06001C07 RID: 7175 RVA: 0x0002C7A8 File Offset: 0x0002A9A8
		public virtual double[] GetTileViewport()
		{
			IntPtr intPtr = vtkWindow.vtkWindow_GetTileViewport_30(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06001C08 RID: 7176
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_GetTileViewport_31(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		/// <summary>
		/// These methods are used by vtkWindowToImageFilter to tell a VTK window
		/// to simulate a larger window by tiling. For 3D geometry these methods
		/// have no impact. It is just in handling annotation that this information
		/// must be available to the mappers and the coordinate calculations.
		/// </summary>
		// Token: 0x06001C09 RID: 7177 RVA: 0x0002C7F0 File Offset: 0x0002A9F0
		public virtual void GetTileViewport(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkWindow.vtkWindow_GetTileViewport_31(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x06001C0A RID: 7178
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_GetTileViewport_32(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// These methods are used by vtkWindowToImageFilter to tell a VTK window
		/// to simulate a larger window by tiling. For 3D geometry these methods
		/// have no impact. It is just in handling annotation that this information
		/// must be available to the mappers and the coordinate calculations.
		/// </summary>
		// Token: 0x06001C0B RID: 7179 RVA: 0x0002C804 File Offset: 0x0002AA04
		public virtual void GetTileViewport(IntPtr _arg)
		{
			vtkWindow.vtkWindow_GetTileViewport_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06001C0C RID: 7180
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkWindow_GetUseOffScreenBuffers_33(HandleRef pThis);

		/// <summary>
		/// Render to an offscreen destination such as a framebuffer.
		/// All four combinations of ShowWindow and UseOffScreenBuffers
		/// should work for most rendering backends.
		/// </summary>
		// Token: 0x06001C0D RID: 7181 RVA: 0x0002C814 File Offset: 0x0002AA14
		public virtual bool GetUseOffScreenBuffers()
		{
			return vtkWindow.vtkWindow_GetUseOffScreenBuffers_33(base.GetCppThis()) != 0;
		}

		// Token: 0x06001C0E RID: 7182
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindow_GetWindowName_34(HandleRef pThis);

		/// <summary>
		/// Get name of rendering window
		/// </summary>
		// Token: 0x06001C0F RID: 7183 RVA: 0x0002C83C File Offset: 0x0002AA3C
		public virtual string GetWindowName()
		{
			string s = Marshal.PtrToStringAnsi(vtkWindow.vtkWindow_GetWindowName_34(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06001C10 RID: 7184
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindow_IsA_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001C11 RID: 7185 RVA: 0x0002C878 File Offset: 0x0002AA78
		public override int IsA(string type)
		{
			return vtkWindow.vtkWindow_IsA_35(base.GetCppThis(), type);
		}

		// Token: 0x06001C12 RID: 7186
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindow_IsTypeOf_36([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001C13 RID: 7187 RVA: 0x0002C898 File Offset: 0x0002AA98
		public new static int IsTypeOf(string type)
		{
			return vtkWindow.vtkWindow_IsTypeOf_36(type);
		}

		// Token: 0x06001C14 RID: 7188
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_MakeCurrent_37(HandleRef pThis);

		/// <summary>
		/// Make the window current. May be overridden in subclasses to do
		/// for example a glXMakeCurrent or a wglMakeCurrent.
		/// </summary>
		// Token: 0x06001C15 RID: 7189 RVA: 0x0002C8B2 File Offset: 0x0002AAB2
		public virtual void MakeCurrent()
		{
			vtkWindow.vtkWindow_MakeCurrent_37(base.GetCppThis());
		}

		// Token: 0x06001C16 RID: 7190
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindow_NewInstance_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001C17 RID: 7191 RVA: 0x0002C8C4 File Offset: 0x0002AAC4
		public new vtkWindow NewInstance()
		{
			vtkWindow result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWindow.vtkWindow_NewInstance_38(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06001C18 RID: 7192
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_OffScreenRenderingOff_39(HandleRef pThis);

		/// <summary>
		/// Convenience to set SHowWindow and UseOffScreenBuffers in one call
		/// </summary>
		// Token: 0x06001C19 RID: 7193 RVA: 0x0002C91E File Offset: 0x0002AB1E
		public virtual void OffScreenRenderingOff()
		{
			vtkWindow.vtkWindow_OffScreenRenderingOff_39(base.GetCppThis());
		}

		// Token: 0x06001C1A RID: 7194
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_OffScreenRenderingOn_40(HandleRef pThis);

		/// <summary>
		/// Convenience to set SHowWindow and UseOffScreenBuffers in one call
		/// </summary>
		// Token: 0x06001C1B RID: 7195 RVA: 0x0002C92D File Offset: 0x0002AB2D
		public virtual void OffScreenRenderingOn()
		{
			vtkWindow.vtkWindow_OffScreenRenderingOn_40(base.GetCppThis());
		}

		// Token: 0x06001C1C RID: 7196
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_ReleaseCurrent_41(HandleRef pThis);

		/// <summary>
		/// Release the current context. May be overridden in subclasses to do
		/// for example a glXMakeCurrent or a wglMakeCurrent.
		/// </summary>
		// Token: 0x06001C1D RID: 7197 RVA: 0x0002C93C File Offset: 0x0002AB3C
		public virtual void ReleaseCurrent()
		{
			vtkWindow.vtkWindow_ReleaseCurrent_41(base.GetCppThis());
		}

		// Token: 0x06001C1E RID: 7198
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_ReleaseGraphicsResources_42(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this texture.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x06001C1F RID: 7199 RVA: 0x0002C94C File Offset: 0x0002AB4C
		public virtual void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkWindow.vtkWindow_ReleaseGraphicsResources_42(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06001C20 RID: 7200
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_Render_43(HandleRef pThis);

		/// <summary>
		/// Ask each viewport owned by this Window to render its image and
		/// synchronize this process.
		/// </summary>
		// Token: 0x06001C21 RID: 7201 RVA: 0x0002C97B File Offset: 0x0002AB7B
		public virtual void Render()
		{
			vtkWindow.vtkWindow_Render_43(base.GetCppThis());
		}

		// Token: 0x06001C22 RID: 7202
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindow_SafeDownCast_44(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06001C23 RID: 7203 RVA: 0x0002C98C File Offset: 0x0002AB8C
		public new static vtkWindow SafeDownCast(vtkObjectBase o)
		{
			vtkWindow vtkWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWindow.vtkWindow_SafeDownCast_44((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06001C24 RID: 7204
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_SetDPI_45(HandleRef pThis, int _arg);

		/// <summary>
		/// Return a best estimate to the dots per inch of the display
		/// device being rendered (or printed).
		/// </summary>
		// Token: 0x06001C25 RID: 7205 RVA: 0x0002CA0B File Offset: 0x0002AC0B
		public virtual void SetDPI(int _arg)
		{
			vtkWindow.vtkWindow_SetDPI_45(base.GetCppThis(), _arg);
		}

		// Token: 0x06001C26 RID: 7206
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_SetDisplayId_46(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// These are window system independent methods that are used
		/// to help interface vtkWindow to native windowing systems.
		/// </summary>
		// Token: 0x06001C27 RID: 7207 RVA: 0x0002CA1B File Offset: 0x0002AC1B
		public virtual void SetDisplayId(IntPtr arg0)
		{
			vtkWindow.vtkWindow_SetDisplayId_46(base.GetCppThis(), arg0);
		}

		// Token: 0x06001C28 RID: 7208
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_SetDoubleBuffer_47(HandleRef pThis, int _arg);

		/// <summary>
		/// Keep track of whether double buffering is on or off
		/// </summary>
		// Token: 0x06001C29 RID: 7209 RVA: 0x0002CA2B File Offset: 0x0002AC2B
		public virtual void SetDoubleBuffer(int _arg)
		{
			vtkWindow.vtkWindow_SetDoubleBuffer_47(base.GetCppThis(), _arg);
		}

		// Token: 0x06001C2A RID: 7210
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_SetErase_48(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off erasing the screen between images. This allows multiple
		/// exposure sequences if turned on. You will need to turn double
		/// buffering off or make use of the SwapBuffers methods to prevent
		/// you from swapping buffers between exposures.
		/// </summary>
		// Token: 0x06001C2B RID: 7211 RVA: 0x0002CA3B File Offset: 0x0002AC3B
		public virtual void SetErase(int _arg)
		{
			vtkWindow.vtkWindow_SetErase_48(base.GetCppThis(), _arg);
		}

		// Token: 0x06001C2C RID: 7212
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_SetIcon_49(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the icon used in title bar and task bar.
		/// Currently implemented for OpenGL windows on Windows and Linux.
		/// </summary>
		// Token: 0x06001C2D RID: 7213 RVA: 0x0002CA4C File Offset: 0x0002AC4C
		public virtual void SetIcon(vtkImageData arg0)
		{
			vtkWindow.vtkWindow_SetIcon_49(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06001C2E RID: 7214
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_SetOffScreenRendering_50(HandleRef pThis, int val);

		/// <summary>
		/// Convenience to set SHowWindow and UseOffScreenBuffers in one call
		/// </summary>
		// Token: 0x06001C2F RID: 7215 RVA: 0x0002CA7B File Offset: 0x0002AC7B
		public void SetOffScreenRendering(int val)
		{
			vtkWindow.vtkWindow_SetOffScreenRendering_50(base.GetCppThis(), val);
		}

		// Token: 0x06001C30 RID: 7216
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_SetParentId_51(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// These are window system independent methods that are used
		/// to help interface vtkWindow to native windowing systems.
		/// </summary>
		// Token: 0x06001C31 RID: 7217 RVA: 0x0002CA8B File Offset: 0x0002AC8B
		public virtual void SetParentId(IntPtr arg0)
		{
			vtkWindow.vtkWindow_SetParentId_51(base.GetCppThis(), arg0);
		}

		// Token: 0x06001C32 RID: 7218
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_SetParentInfo_52(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// These are window system independent methods that are used
		/// to help interface vtkWindow to native windowing systems.
		/// </summary>
		// Token: 0x06001C33 RID: 7219 RVA: 0x0002CA9B File Offset: 0x0002AC9B
		public virtual void SetParentInfo(string arg0)
		{
			vtkWindow.vtkWindow_SetParentInfo_52(base.GetCppThis(), arg0);
		}

		// Token: 0x06001C34 RID: 7220
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_SetPosition_53(HandleRef pThis, int x, int y);

		/// <summary>
		/// Set the position (x and y) of the rendering window in
		/// screen coordinates (in pixels). This resizes the operating
		/// system's view/window and redraws it.
		/// </summary>
		// Token: 0x06001C35 RID: 7221 RVA: 0x0002CAAB File Offset: 0x0002ACAB
		public virtual void SetPosition(int x, int y)
		{
			vtkWindow.vtkWindow_SetPosition_53(base.GetCppThis(), x, y);
		}

		// Token: 0x06001C36 RID: 7222
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_SetPosition_54(HandleRef pThis, IntPtr a);

		/// <summary>
		/// Set the position (x and y) of the rendering window in
		/// screen coordinates (in pixels). This resizes the operating
		/// system's view/window and redraws it.
		/// </summary>
		// Token: 0x06001C37 RID: 7223 RVA: 0x0002CABC File Offset: 0x0002ACBC
		public virtual void SetPosition(IntPtr a)
		{
			vtkWindow.vtkWindow_SetPosition_54(base.GetCppThis(), a);
		}

		// Token: 0x06001C38 RID: 7224
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_SetShowWindow_55(HandleRef pThis, byte _arg);

		/// <summary>
		/// Show or not Show the window
		/// </summary>
		// Token: 0x06001C39 RID: 7225 RVA: 0x0002CACC File Offset: 0x0002ACCC
		public virtual void SetShowWindow(bool _arg)
		{
			vtkWindow.vtkWindow_SetShowWindow_55(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06001C3A RID: 7226
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_SetSize_56(HandleRef pThis, int width, int height);

		/// <summary>
		/// Set the size (width and height) of the rendering window in
		/// screen coordinates (in pixels). This resizes the operating
		/// system's view/window and redraws it.
		///
		/// If the size has changed, this method will fire
		/// vtkCommand::WindowResizeEvent.
		/// </summary>
		// Token: 0x06001C3B RID: 7227 RVA: 0x0002CAE4 File Offset: 0x0002ACE4
		public virtual void SetSize(int width, int height)
		{
			vtkWindow.vtkWindow_SetSize_56(base.GetCppThis(), width, height);
		}

		// Token: 0x06001C3C RID: 7228
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_SetSize_57(HandleRef pThis, IntPtr a);

		/// <summary>
		/// Set the size (width and height) of the rendering window in
		/// screen coordinates (in pixels). This resizes the operating
		/// system's view/window and redraws it.
		///
		/// If the size has changed, this method will fire
		/// vtkCommand::WindowResizeEvent.
		/// </summary>
		// Token: 0x06001C3D RID: 7229 RVA: 0x0002CAF5 File Offset: 0x0002ACF5
		public virtual void SetSize(IntPtr a)
		{
			vtkWindow.vtkWindow_SetSize_57(base.GetCppThis(), a);
		}

		// Token: 0x06001C3E RID: 7230
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_SetTileScale_58(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// These methods are used by vtkWindowToImageFilter to tell a VTK window
		/// to simulate a larger window by tiling. For 3D geometry these methods
		/// have no impact. It is just in handling annotation that this information
		/// must be available to the mappers and the coordinate calculations.
		/// </summary>
		// Token: 0x06001C3F RID: 7231 RVA: 0x0002CB05 File Offset: 0x0002AD05
		public virtual void SetTileScale(int _arg1, int _arg2)
		{
			vtkWindow.vtkWindow_SetTileScale_58(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06001C40 RID: 7232
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_SetTileScale_59(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// These methods are used by vtkWindowToImageFilter to tell a VTK window
		/// to simulate a larger window by tiling. For 3D geometry these methods
		/// have no impact. It is just in handling annotation that this information
		/// must be available to the mappers and the coordinate calculations.
		/// </summary>
		// Token: 0x06001C41 RID: 7233 RVA: 0x0002CB16 File Offset: 0x0002AD16
		public void SetTileScale(IntPtr _arg)
		{
			vtkWindow.vtkWindow_SetTileScale_59(base.GetCppThis(), _arg);
		}

		// Token: 0x06001C42 RID: 7234
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_SetTileScale_60(HandleRef pThis, int s);

		/// <summary>
		/// These methods are used by vtkWindowToImageFilter to tell a VTK window
		/// to simulate a larger window by tiling. For 3D geometry these methods
		/// have no impact. It is just in handling annotation that this information
		/// must be available to the mappers and the coordinate calculations.
		/// </summary>
		// Token: 0x06001C43 RID: 7235 RVA: 0x0002CB26 File Offset: 0x0002AD26
		public void SetTileScale(int s)
		{
			vtkWindow.vtkWindow_SetTileScale_60(base.GetCppThis(), s);
		}

		// Token: 0x06001C44 RID: 7236
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_SetTileViewport_61(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		/// <summary>
		/// These methods are used by vtkWindowToImageFilter to tell a VTK window
		/// to simulate a larger window by tiling. For 3D geometry these methods
		/// have no impact. It is just in handling annotation that this information
		/// must be available to the mappers and the coordinate calculations.
		/// </summary>
		// Token: 0x06001C45 RID: 7237 RVA: 0x0002CB36 File Offset: 0x0002AD36
		public virtual void SetTileViewport(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkWindow.vtkWindow_SetTileViewport_61(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x06001C46 RID: 7238
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_SetTileViewport_62(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// These methods are used by vtkWindowToImageFilter to tell a VTK window
		/// to simulate a larger window by tiling. For 3D geometry these methods
		/// have no impact. It is just in handling annotation that this information
		/// must be available to the mappers and the coordinate calculations.
		/// </summary>
		// Token: 0x06001C47 RID: 7239 RVA: 0x0002CB4A File Offset: 0x0002AD4A
		public virtual void SetTileViewport(IntPtr _arg)
		{
			vtkWindow.vtkWindow_SetTileViewport_62(base.GetCppThis(), _arg);
		}

		// Token: 0x06001C48 RID: 7240
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_SetUseOffScreenBuffers_63(HandleRef pThis, byte _arg);

		/// <summary>
		/// Render to an offscreen destination such as a framebuffer.
		/// All four combinations of ShowWindow and UseOffScreenBuffers
		/// should work for most rendering backends.
		/// </summary>
		// Token: 0x06001C49 RID: 7241 RVA: 0x0002CB5A File Offset: 0x0002AD5A
		public virtual void SetUseOffScreenBuffers(bool _arg)
		{
			vtkWindow.vtkWindow_SetUseOffScreenBuffers_63(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06001C4A RID: 7242
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_SetWindowId_64(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// These are window system independent methods that are used
		/// to help interface vtkWindow to native windowing systems.
		/// </summary>
		// Token: 0x06001C4B RID: 7243 RVA: 0x0002CB72 File Offset: 0x0002AD72
		public virtual void SetWindowId(IntPtr arg0)
		{
			vtkWindow.vtkWindow_SetWindowId_64(base.GetCppThis(), arg0);
		}

		// Token: 0x06001C4C RID: 7244
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_SetWindowInfo_65(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// These are window system independent methods that are used
		/// to help interface vtkWindow to native windowing systems.
		/// </summary>
		// Token: 0x06001C4D RID: 7245 RVA: 0x0002CB82 File Offset: 0x0002AD82
		public virtual void SetWindowInfo(string arg0)
		{
			vtkWindow.vtkWindow_SetWindowInfo_65(base.GetCppThis(), arg0);
		}

		// Token: 0x06001C4E RID: 7246
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_SetWindowName_66(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get name of rendering window
		/// </summary>
		// Token: 0x06001C4F RID: 7247 RVA: 0x0002CB92 File Offset: 0x0002AD92
		public virtual void SetWindowName(string _arg)
		{
			vtkWindow.vtkWindow_SetWindowName_66(base.GetCppThis(), _arg);
		}

		// Token: 0x06001C50 RID: 7248
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_ShowWindowOff_67(HandleRef pThis);

		/// <summary>
		/// Show or not Show the window
		/// </summary>
		// Token: 0x06001C51 RID: 7249 RVA: 0x0002CBA2 File Offset: 0x0002ADA2
		public virtual void ShowWindowOff()
		{
			vtkWindow.vtkWindow_ShowWindowOff_67(base.GetCppThis());
		}

		// Token: 0x06001C52 RID: 7250
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_ShowWindowOn_68(HandleRef pThis);

		/// <summary>
		/// Show or not Show the window
		/// </summary>
		// Token: 0x06001C53 RID: 7251 RVA: 0x0002CBB1 File Offset: 0x0002ADB1
		public virtual void ShowWindowOn()
		{
			vtkWindow.vtkWindow_ShowWindowOn_68(base.GetCppThis());
		}

		// Token: 0x06001C54 RID: 7252
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_UseOffScreenBuffersOff_69(HandleRef pThis);

		/// <summary>
		/// Render to an offscreen destination such as a framebuffer.
		/// All four combinations of ShowWindow and UseOffScreenBuffers
		/// should work for most rendering backends.
		/// </summary>
		// Token: 0x06001C55 RID: 7253 RVA: 0x0002CBC0 File Offset: 0x0002ADC0
		public virtual void UseOffScreenBuffersOff()
		{
			vtkWindow.vtkWindow_UseOffScreenBuffersOff_69(base.GetCppThis());
		}

		// Token: 0x06001C56 RID: 7254
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindow_UseOffScreenBuffersOn_70(HandleRef pThis);

		/// <summary>
		/// Render to an offscreen destination such as a framebuffer.
		/// All four combinations of ShowWindow and UseOffScreenBuffers
		/// should work for most rendering backends.
		/// </summary>
		// Token: 0x06001C57 RID: 7255 RVA: 0x0002CBCF File Offset: 0x0002ADCF
		public virtual void UseOffScreenBuffersOn()
		{
			vtkWindow.vtkWindow_UseOffScreenBuffersOn_70(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040004FD RID: 1277
		public new const string MRFullTypeName = "Kitware.VTK.vtkWindow";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040004FE RID: 1278
		public new static readonly string MRClassNameKey = "class vtkWindow";
	}
}
