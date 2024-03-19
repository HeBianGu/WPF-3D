using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVideoSource
	/// </summary>
	/// <remarks>
	///    Superclass of video input devices for VTK
	///
	/// vtkVideoSource is a superclass for video input interfaces for VTK.
	/// The goal is to provide an interface which is very similar to the
	/// interface of a VCR, where the 'tape' is an internal frame buffer
	/// capable of holding a preset number of video frames.  Specialized
	/// versions of this class record input from various video input sources.
	/// This base class records input from a noise source.
	/// @warning
	/// You must call the ReleaseSystemResources() method before the application
	/// exits.  Otherwise the application might hang while trying to exit.
	/// </remarks>
	/// <seealso>
	///
	/// vtkWin32VideoSource vtkMILVideoSource
	/// </seealso>
	// Token: 0x0200018D RID: 397
	public class vtkVideoSource : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004D51 RID: 19793 RVA: 0x00070AE0 File Offset: 0x0006ECE0
		static vtkVideoSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVideoSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVideoSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004D52 RID: 19794 RVA: 0x00070B08 File Offset: 0x0006ED08
		public vtkVideoSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004D53 RID: 19795
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVideoSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004D54 RID: 19796 RVA: 0x00070B18 File Offset: 0x0006ED18
		public new static vtkVideoSource New()
		{
			vtkVideoSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVideoSource.vtkVideoSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVideoSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004D55 RID: 19797 RVA: 0x00070B6C File Offset: 0x0006ED6C
		public vtkVideoSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVideoSource.vtkVideoSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004D56 RID: 19798 RVA: 0x00070BB0 File Offset: 0x0006EDB0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004D57 RID: 19799
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_AutoAdvanceOff_01(HandleRef pThis);

		/// <summary>
		/// Set whether to automatically advance the buffer before each grab.
		/// Default: on
		/// </summary>
		// Token: 0x06004D58 RID: 19800 RVA: 0x00070BBB File Offset: 0x0006EDBB
		public virtual void AutoAdvanceOff()
		{
			vtkVideoSource.vtkVideoSource_AutoAdvanceOff_01(base.GetCppThis());
		}

		// Token: 0x06004D59 RID: 19801
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_AutoAdvanceOn_02(HandleRef pThis);

		/// <summary>
		/// Set whether to automatically advance the buffer before each grab.
		/// Default: on
		/// </summary>
		// Token: 0x06004D5A RID: 19802 RVA: 0x00070BCA File Offset: 0x0006EDCA
		public virtual void AutoAdvanceOn()
		{
			vtkVideoSource.vtkVideoSource_AutoAdvanceOn_02(base.GetCppThis());
		}

		// Token: 0x06004D5B RID: 19803
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_FastForward_03(HandleRef pThis);

		/// <summary>
		/// FastForward to the last frame that was recorded (i.e. to the frame
		/// that has the most recent timestamp).
		/// </summary>
		// Token: 0x06004D5C RID: 19804 RVA: 0x00070BD9 File Offset: 0x0006EDD9
		public virtual void FastForward()
		{
			vtkVideoSource.vtkVideoSource_FastForward_03(base.GetCppThis());
		}

		// Token: 0x06004D5D RID: 19805
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVideoSource_GetAutoAdvance_04(HandleRef pThis);

		/// <summary>
		/// Set whether to automatically advance the buffer before each grab.
		/// Default: on
		/// </summary>
		// Token: 0x06004D5E RID: 19806 RVA: 0x00070BE8 File Offset: 0x0006EDE8
		public virtual int GetAutoAdvance()
		{
			return vtkVideoSource.vtkVideoSource_GetAutoAdvance_04(base.GetCppThis());
		}

		// Token: 0x06004D5F RID: 19807
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVideoSource_GetClipRegion_05(HandleRef pThis);

		/// <summary>
		/// Set the clip rectangle for the frames.  The video will be clipped
		/// before it is copied into the framebuffer.  Changing the ClipRegion
		/// will destroy the current contents of the framebuffer.
		/// The default ClipRegion is (0,VTK_INT_MAX,0,VTK_INT_MAX,0,VTK_INT_MAX).
		/// </summary>
		// Token: 0x06004D60 RID: 19808 RVA: 0x00070C08 File Offset: 0x0006EE08
		public virtual int[] GetClipRegion()
		{
			IntPtr intPtr = vtkVideoSource.vtkVideoSource_GetClipRegion_05(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06004D61 RID: 19809
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_GetClipRegion_06(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		/// Set the clip rectangle for the frames.  The video will be clipped
		/// before it is copied into the framebuffer.  Changing the ClipRegion
		/// will destroy the current contents of the framebuffer.
		/// The default ClipRegion is (0,VTK_INT_MAX,0,VTK_INT_MAX,0,VTK_INT_MAX).
		/// </summary>
		// Token: 0x06004D62 RID: 19810 RVA: 0x00070C50 File Offset: 0x0006EE50
		public virtual void GetClipRegion(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkVideoSource.vtkVideoSource_GetClipRegion_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x06004D63 RID: 19811
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_GetClipRegion_07(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the clip rectangle for the frames.  The video will be clipped
		/// before it is copied into the framebuffer.  Changing the ClipRegion
		/// will destroy the current contents of the framebuffer.
		/// The default ClipRegion is (0,VTK_INT_MAX,0,VTK_INT_MAX,0,VTK_INT_MAX).
		/// </summary>
		// Token: 0x06004D64 RID: 19812 RVA: 0x00070C68 File Offset: 0x0006EE68
		public virtual void GetClipRegion(IntPtr _arg)
		{
			vtkVideoSource.vtkVideoSource_GetClipRegion_07(base.GetCppThis(), _arg);
		}

		// Token: 0x06004D65 RID: 19813
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVideoSource_GetDataOrigin_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the coordinates of the lower, left corner of the frame.
		/// Default: (0.0,0.0,0.0)
		/// </summary>
		// Token: 0x06004D66 RID: 19814 RVA: 0x00070C78 File Offset: 0x0006EE78
		public virtual double[] GetDataOrigin()
		{
			IntPtr intPtr = vtkVideoSource.vtkVideoSource_GetDataOrigin_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06004D67 RID: 19815
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_GetDataOrigin_09(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the coordinates of the lower, left corner of the frame.
		/// Default: (0.0,0.0,0.0)
		/// </summary>
		// Token: 0x06004D68 RID: 19816 RVA: 0x00070CC0 File Offset: 0x0006EEC0
		public virtual void GetDataOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkVideoSource.vtkVideoSource_GetDataOrigin_09(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06004D69 RID: 19817
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_GetDataOrigin_10(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the coordinates of the lower, left corner of the frame.
		/// Default: (0.0,0.0,0.0)
		/// </summary>
		// Token: 0x06004D6A RID: 19818 RVA: 0x00070CD2 File Offset: 0x0006EED2
		public virtual void GetDataOrigin(IntPtr _arg)
		{
			vtkVideoSource.vtkVideoSource_GetDataOrigin_10(base.GetCppThis(), _arg);
		}

		// Token: 0x06004D6B RID: 19819
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVideoSource_GetDataSpacing_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the pixel spacing.
		/// Default: (1.0,1.0,1.0)
		/// </summary>
		// Token: 0x06004D6C RID: 19820 RVA: 0x00070CE4 File Offset: 0x0006EEE4
		public virtual double[] GetDataSpacing()
		{
			IntPtr intPtr = vtkVideoSource.vtkVideoSource_GetDataSpacing_11(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06004D6D RID: 19821
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_GetDataSpacing_12(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the pixel spacing.
		/// Default: (1.0,1.0,1.0)
		/// </summary>
		// Token: 0x06004D6E RID: 19822 RVA: 0x00070D2C File Offset: 0x0006EF2C
		public virtual void GetDataSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkVideoSource.vtkVideoSource_GetDataSpacing_12(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06004D6F RID: 19823
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_GetDataSpacing_13(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the pixel spacing.
		/// Default: (1.0,1.0,1.0)
		/// </summary>
		// Token: 0x06004D70 RID: 19824 RVA: 0x00070D3E File Offset: 0x0006EF3E
		public virtual void GetDataSpacing(IntPtr _arg)
		{
			vtkVideoSource.vtkVideoSource_GetDataSpacing_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06004D71 RID: 19825
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVideoSource_GetFrameBufferSize_14(HandleRef pThis);

		/// <summary>
		/// Set size of the frame buffer, i.e. the number of frames that
		/// the 'tape' can store.
		/// </summary>
		// Token: 0x06004D72 RID: 19826 RVA: 0x00070D50 File Offset: 0x0006EF50
		public virtual int GetFrameBufferSize()
		{
			return vtkVideoSource.vtkVideoSource_GetFrameBufferSize_14(base.GetCppThis());
		}

		// Token: 0x06004D73 RID: 19827
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVideoSource_GetFrameCount_15(HandleRef pThis);

		/// <summary>
		/// This value is incremented each time a frame is grabbed.
		/// reset it to zero (or any other value) at any time.
		/// </summary>
		// Token: 0x06004D74 RID: 19828 RVA: 0x00070D70 File Offset: 0x0006EF70
		public virtual int GetFrameCount()
		{
			return vtkVideoSource.vtkVideoSource_GetFrameCount_15(base.GetCppThis());
		}

		// Token: 0x06004D75 RID: 19829
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVideoSource_GetFrameIndex_16(HandleRef pThis);

		/// <summary>
		/// Get the frame index relative to the 'beginning of the tape'.  This
		/// value wraps back to zero if it increases past the FrameBufferSize.
		/// </summary>
		// Token: 0x06004D76 RID: 19830 RVA: 0x00070D90 File Offset: 0x0006EF90
		public virtual int GetFrameIndex()
		{
			return vtkVideoSource.vtkVideoSource_GetFrameIndex_16(base.GetCppThis());
		}

		// Token: 0x06004D77 RID: 19831
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkVideoSource_GetFrameRate_17(HandleRef pThis);

		/// <summary>
		/// Request a particular frame rate (default 30 frames per second).
		/// </summary>
		// Token: 0x06004D78 RID: 19832 RVA: 0x00070DB0 File Offset: 0x0006EFB0
		public virtual float GetFrameRate()
		{
			return vtkVideoSource.vtkVideoSource_GetFrameRate_17(base.GetCppThis());
		}

		// Token: 0x06004D79 RID: 19833
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVideoSource_GetFrameSize_18(HandleRef pThis);

		/// <summary>
		/// Set the full-frame size.  This must be an allowed size for the device,
		/// the device may either refuse a request for an illegal frame size or
		/// automatically choose a new frame size.
		/// The default is usually 320x240x1, but can be device specific.
		/// The 'depth' should always be 1 (unless you have a device that
		/// can handle 3D acquisition).
		/// </summary>
		// Token: 0x06004D7A RID: 19834 RVA: 0x00070DD0 File Offset: 0x0006EFD0
		public virtual int[] GetFrameSize()
		{
			IntPtr intPtr = vtkVideoSource.vtkVideoSource_GetFrameSize_18(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06004D7B RID: 19835
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_GetFrameSize_19(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		/// <summary>
		/// Set the full-frame size.  This must be an allowed size for the device,
		/// the device may either refuse a request for an illegal frame size or
		/// automatically choose a new frame size.
		/// The default is usually 320x240x1, but can be device specific.
		/// The 'depth' should always be 1 (unless you have a device that
		/// can handle 3D acquisition).
		/// </summary>
		// Token: 0x06004D7C RID: 19836 RVA: 0x00070E18 File Offset: 0x0006F018
		public virtual void GetFrameSize(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkVideoSource.vtkVideoSource_GetFrameSize_19(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06004D7D RID: 19837
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_GetFrameSize_20(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the full-frame size.  This must be an allowed size for the device,
		/// the device may either refuse a request for an illegal frame size or
		/// automatically choose a new frame size.
		/// The default is usually 320x240x1, but can be device specific.
		/// The 'depth' should always be 1 (unless you have a device that
		/// can handle 3D acquisition).
		/// </summary>
		// Token: 0x06004D7E RID: 19838 RVA: 0x00070E2A File Offset: 0x0006F02A
		public virtual void GetFrameSize(IntPtr _arg)
		{
			vtkVideoSource.vtkVideoSource_GetFrameSize_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06004D7F RID: 19839
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVideoSource_GetFrameTimeStamp_21(HandleRef pThis, int frame);

		/// <summary>
		/// Get a time stamp in seconds (resolution of milliseconds) for
		/// a video frame.   Time began on Jan 1, 1970.  You can specify
		/// a number (negative or positive) to specify the position of the
		/// video frame relative to the current frame.
		/// </summary>
		// Token: 0x06004D80 RID: 19840 RVA: 0x00070E3C File Offset: 0x0006F03C
		public virtual double GetFrameTimeStamp(int frame)
		{
			return vtkVideoSource.vtkVideoSource_GetFrameTimeStamp_21(base.GetCppThis(), frame);
		}

		// Token: 0x06004D81 RID: 19841
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVideoSource_GetFrameTimeStamp_22(HandleRef pThis);

		/// <summary>
		/// Get a time stamp in seconds (resolution of milliseconds) for
		/// the Output.  Time began on Jan 1, 1970.  This timestamp is only
		/// valid after the Output has been Updated.
		/// </summary>
		// Token: 0x06004D82 RID: 19842 RVA: 0x00070E5C File Offset: 0x0006F05C
		public double GetFrameTimeStamp()
		{
			return vtkVideoSource.vtkVideoSource_GetFrameTimeStamp_22(base.GetCppThis());
		}

		// Token: 0x06004D83 RID: 19843
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVideoSource_GetInitialized_23(HandleRef pThis);

		/// <summary>
		/// Initialize the hardware.  This is called automatically
		/// on the first Update or Grab.
		/// </summary>
		// Token: 0x06004D84 RID: 19844 RVA: 0x00070E7C File Offset: 0x0006F07C
		public virtual int GetInitialized()
		{
			return vtkVideoSource.vtkVideoSource_GetInitialized_23(base.GetCppThis());
		}

		// Token: 0x06004D85 RID: 19845
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVideoSource_GetNumberOfGenerationsFromBase_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004D86 RID: 19846 RVA: 0x00070E9C File Offset: 0x0006F09C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVideoSource.vtkVideoSource_GetNumberOfGenerationsFromBase_24(base.GetCppThis(), type);
		}

		// Token: 0x06004D87 RID: 19847
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVideoSource_GetNumberOfGenerationsFromBaseType_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004D88 RID: 19848 RVA: 0x00070EBC File Offset: 0x0006F0BC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVideoSource.vtkVideoSource_GetNumberOfGenerationsFromBaseType_25(type);
		}

		// Token: 0x06004D89 RID: 19849
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVideoSource_GetNumberOfOutputFrames_26(HandleRef pThis);

		/// <summary>
		/// Set the number of frames to copy to the output on each execute.
		/// The frames will be concatenated along the Z dimension, with the
		/// most recent frame first.
		/// Default: 1
		/// </summary>
		// Token: 0x06004D8A RID: 19850 RVA: 0x00070ED8 File Offset: 0x0006F0D8
		public virtual int GetNumberOfOutputFrames()
		{
			return vtkVideoSource.vtkVideoSource_GetNumberOfOutputFrames_26(base.GetCppThis());
		}

		// Token: 0x06004D8B RID: 19851
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkVideoSource_GetOpacity_27(HandleRef pThis);

		/// <summary>
		/// For RGBA output only (4 scalar components), set the opacity.  This
		/// will not modify the existing contents of the framebuffer, only
		/// subsequently grabbed frames.
		/// </summary>
		// Token: 0x06004D8C RID: 19852 RVA: 0x00070EF8 File Offset: 0x0006F0F8
		public virtual float GetOpacity()
		{
			return vtkVideoSource.vtkVideoSource_GetOpacity_27(base.GetCppThis());
		}

		// Token: 0x06004D8D RID: 19853
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVideoSource_GetOutputFormat_28(HandleRef pThis);

		/// <summary>
		/// Set the output format.  This must be appropriate for device,
		/// usually only VTK_LUMINANCE, VTK_RGB, and VTK_RGBA are supported.
		/// </summary>
		// Token: 0x06004D8E RID: 19854 RVA: 0x00070F18 File Offset: 0x0006F118
		public virtual int GetOutputFormat()
		{
			return vtkVideoSource.vtkVideoSource_GetOutputFormat_28(base.GetCppThis());
		}

		// Token: 0x06004D8F RID: 19855
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVideoSource_GetOutputWholeExtent_29(HandleRef pThis);

		/// <summary>
		/// Get/Set the WholeExtent of the output.  This can be used to either
		/// clip or pad the video frame.  This clipping/padding is done when
		/// the frame is copied to the output, and does not change the contents
		/// of the framebuffer.  This is useful e.g. for expanding
		/// the output size to a power of two for texture mapping.  The
		/// default is (0,-1,0,-1,0,-1) which causes the entire frame to be
		/// copied to the output.
		/// </summary>
		// Token: 0x06004D90 RID: 19856 RVA: 0x00070F38 File Offset: 0x0006F138
		public virtual int[] GetOutputWholeExtent()
		{
			IntPtr intPtr = vtkVideoSource.vtkVideoSource_GetOutputWholeExtent_29(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06004D91 RID: 19857
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_GetOutputWholeExtent_30(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		/// Get/Set the WholeExtent of the output.  This can be used to either
		/// clip or pad the video frame.  This clipping/padding is done when
		/// the frame is copied to the output, and does not change the contents
		/// of the framebuffer.  This is useful e.g. for expanding
		/// the output size to a power of two for texture mapping.  The
		/// default is (0,-1,0,-1,0,-1) which causes the entire frame to be
		/// copied to the output.
		/// </summary>
		// Token: 0x06004D92 RID: 19858 RVA: 0x00070F80 File Offset: 0x0006F180
		public virtual void GetOutputWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkVideoSource.vtkVideoSource_GetOutputWholeExtent_30(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x06004D93 RID: 19859
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_GetOutputWholeExtent_31(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the WholeExtent of the output.  This can be used to either
		/// clip or pad the video frame.  This clipping/padding is done when
		/// the frame is copied to the output, and does not change the contents
		/// of the framebuffer.  This is useful e.g. for expanding
		/// the output size to a power of two for texture mapping.  The
		/// default is (0,-1,0,-1,0,-1) which causes the entire frame to be
		/// copied to the output.
		/// </summary>
		// Token: 0x06004D94 RID: 19860 RVA: 0x00070F98 File Offset: 0x0006F198
		public virtual void GetOutputWholeExtent(IntPtr _arg)
		{
			vtkVideoSource.vtkVideoSource_GetOutputWholeExtent_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06004D95 RID: 19861
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVideoSource_GetPlaying_32(HandleRef pThis);

		/// <summary>
		/// Are we in play mode? (record mode and play mode are mutually
		/// exclusive).
		/// </summary>
		// Token: 0x06004D96 RID: 19862 RVA: 0x00070FA8 File Offset: 0x0006F1A8
		public virtual int GetPlaying()
		{
			return vtkVideoSource.vtkVideoSource_GetPlaying_32(base.GetCppThis());
		}

		// Token: 0x06004D97 RID: 19863
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVideoSource_GetRecording_33(HandleRef pThis);

		/// <summary>
		/// Are we in record mode? (record mode and play mode are mutually
		/// exclusive).
		/// </summary>
		// Token: 0x06004D98 RID: 19864 RVA: 0x00070FC8 File Offset: 0x0006F1C8
		public virtual int GetRecording()
		{
			return vtkVideoSource.vtkVideoSource_GetRecording_33(base.GetCppThis());
		}

		// Token: 0x06004D99 RID: 19865
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkVideoSource_GetStartTimeStamp_34(HandleRef pThis);

		/// <summary>
		/// And internal variable which marks the beginning of a Record session.
		/// These methods are for internal use only.
		/// </summary>
		// Token: 0x06004D9A RID: 19866 RVA: 0x00070FE8 File Offset: 0x0006F1E8
		public double GetStartTimeStamp()
		{
			return vtkVideoSource.vtkVideoSource_GetStartTimeStamp_34(base.GetCppThis());
		}

		// Token: 0x06004D9B RID: 19867
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_Grab_35(HandleRef pThis);

		/// <summary>
		/// Grab a single video frame.
		/// </summary>
		// Token: 0x06004D9C RID: 19868 RVA: 0x00071007 File Offset: 0x0006F207
		public virtual void Grab()
		{
			vtkVideoSource.vtkVideoSource_Grab_35(base.GetCppThis());
		}

		// Token: 0x06004D9D RID: 19869
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_Initialize_36(HandleRef pThis);

		/// <summary>
		/// Initialize the hardware.  This is called automatically
		/// on the first Update or Grab.
		/// </summary>
		// Token: 0x06004D9E RID: 19870 RVA: 0x00071016 File Offset: 0x0006F216
		public virtual void Initialize()
		{
			vtkVideoSource.vtkVideoSource_Initialize_36(base.GetCppThis());
		}

		// Token: 0x06004D9F RID: 19871
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_InternalGrab_37(HandleRef pThis);

		/// <summary>
		/// The internal function which actually does the grab.  You will
		/// definitely want to override this if you develop a vtkVideoSource
		/// subclass.
		/// </summary>
		// Token: 0x06004DA0 RID: 19872 RVA: 0x00071025 File Offset: 0x0006F225
		public virtual void InternalGrab()
		{
			vtkVideoSource.vtkVideoSource_InternalGrab_37(base.GetCppThis());
		}

		// Token: 0x06004DA1 RID: 19873
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVideoSource_IsA_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004DA2 RID: 19874 RVA: 0x00071034 File Offset: 0x0006F234
		public override int IsA(string type)
		{
			return vtkVideoSource.vtkVideoSource_IsA_38(base.GetCppThis(), type);
		}

		// Token: 0x06004DA3 RID: 19875
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVideoSource_IsTypeOf_39([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004DA4 RID: 19876 RVA: 0x00071054 File Offset: 0x0006F254
		public new static int IsTypeOf(string type)
		{
			return vtkVideoSource.vtkVideoSource_IsTypeOf_39(type);
		}

		// Token: 0x06004DA5 RID: 19877
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVideoSource_NewInstance_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004DA6 RID: 19878 RVA: 0x00071070 File Offset: 0x0006F270
		public new vtkVideoSource NewInstance()
		{
			vtkVideoSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVideoSource.vtkVideoSource_NewInstance_41(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVideoSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004DA7 RID: 19879
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_Play_42(HandleRef pThis);

		/// <summary>
		/// Play through the 'tape' sequentially at the specified frame rate.
		/// If you have just finished Recoding, you should call Rewind() first.
		/// </summary>
		// Token: 0x06004DA8 RID: 19880 RVA: 0x000710CA File Offset: 0x0006F2CA
		public virtual void Play()
		{
			vtkVideoSource.vtkVideoSource_Play_42(base.GetCppThis());
		}

		// Token: 0x06004DA9 RID: 19881
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_Record_43(HandleRef pThis);

		/// <summary>
		/// Record incoming video at the specified FrameRate.  The recording
		/// continues indefinitely until Stop() is called.
		/// </summary>
		// Token: 0x06004DAA RID: 19882 RVA: 0x000710D9 File Offset: 0x0006F2D9
		public virtual void Record()
		{
			vtkVideoSource.vtkVideoSource_Record_43(base.GetCppThis());
		}

		// Token: 0x06004DAB RID: 19883
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_ReleaseSystemResources_44(HandleRef pThis);

		/// <summary>
		/// Release the video driver.  This method must be called before
		/// application exit, or else the application might hang during
		/// exit.
		/// </summary>
		// Token: 0x06004DAC RID: 19884 RVA: 0x000710E8 File Offset: 0x0006F2E8
		public virtual void ReleaseSystemResources()
		{
			vtkVideoSource.vtkVideoSource_ReleaseSystemResources_44(base.GetCppThis());
		}

		// Token: 0x06004DAD RID: 19885
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_Rewind_45(HandleRef pThis);

		/// <summary>
		/// Rewind to the frame with the earliest timestamp.  Record operations
		/// will start on the following frame, therefore if you want to re-record
		/// over this frame you must call Seek(-1) before calling Grab() or Record().
		/// </summary>
		// Token: 0x06004DAE RID: 19886 RVA: 0x000710F7 File Offset: 0x0006F2F7
		public virtual void Rewind()
		{
			vtkVideoSource.vtkVideoSource_Rewind_45(base.GetCppThis());
		}

		// Token: 0x06004DAF RID: 19887
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVideoSource_SafeDownCast_46(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004DB0 RID: 19888 RVA: 0x00071108 File Offset: 0x0006F308
		public new static vtkVideoSource SafeDownCast(vtkObjectBase o)
		{
			vtkVideoSource vtkVideoSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVideoSource.vtkVideoSource_SafeDownCast_46((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVideoSource = (vtkVideoSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVideoSource.Register(null);
				}
			}
			return vtkVideoSource;
		}

		// Token: 0x06004DB1 RID: 19889
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_Seek_47(HandleRef pThis, int n);

		/// <summary>
		/// Seek forwards or backwards by the specified number of frames
		/// (positive is forward, negative is backward).
		/// </summary>
		// Token: 0x06004DB2 RID: 19890 RVA: 0x00071187 File Offset: 0x0006F387
		public virtual void Seek(int n)
		{
			vtkVideoSource.vtkVideoSource_Seek_47(base.GetCppThis(), n);
		}

		// Token: 0x06004DB3 RID: 19891
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_SetAutoAdvance_48(HandleRef pThis, int _arg);

		/// <summary>
		/// Set whether to automatically advance the buffer before each grab.
		/// Default: on
		/// </summary>
		// Token: 0x06004DB4 RID: 19892 RVA: 0x00071197 File Offset: 0x0006F397
		public virtual void SetAutoAdvance(int _arg)
		{
			vtkVideoSource.vtkVideoSource_SetAutoAdvance_48(base.GetCppThis(), _arg);
		}

		// Token: 0x06004DB5 RID: 19893
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_SetClipRegion_49(HandleRef pThis, IntPtr r);

		/// <summary>
		/// Set the clip rectangle for the frames.  The video will be clipped
		/// before it is copied into the framebuffer.  Changing the ClipRegion
		/// will destroy the current contents of the framebuffer.
		/// The default ClipRegion is (0,VTK_INT_MAX,0,VTK_INT_MAX,0,VTK_INT_MAX).
		/// </summary>
		// Token: 0x06004DB6 RID: 19894 RVA: 0x000711A7 File Offset: 0x0006F3A7
		public virtual void SetClipRegion(IntPtr r)
		{
			vtkVideoSource.vtkVideoSource_SetClipRegion_49(base.GetCppThis(), r);
		}

		// Token: 0x06004DB7 RID: 19895
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_SetClipRegion_50(HandleRef pThis, int x0, int x1, int y0, int y1, int z0, int z1);

		/// <summary>
		/// Set the clip rectangle for the frames.  The video will be clipped
		/// before it is copied into the framebuffer.  Changing the ClipRegion
		/// will destroy the current contents of the framebuffer.
		/// The default ClipRegion is (0,VTK_INT_MAX,0,VTK_INT_MAX,0,VTK_INT_MAX).
		/// </summary>
		// Token: 0x06004DB8 RID: 19896 RVA: 0x000711B7 File Offset: 0x0006F3B7
		public virtual void SetClipRegion(int x0, int x1, int y0, int y1, int z0, int z1)
		{
			vtkVideoSource.vtkVideoSource_SetClipRegion_50(base.GetCppThis(), x0, x1, y0, y1, z0, z1);
		}

		// Token: 0x06004DB9 RID: 19897
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_SetDataOrigin_51(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the coordinates of the lower, left corner of the frame.
		/// Default: (0.0,0.0,0.0)
		/// </summary>
		// Token: 0x06004DBA RID: 19898 RVA: 0x000711CF File Offset: 0x0006F3CF
		public virtual void SetDataOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkVideoSource.vtkVideoSource_SetDataOrigin_51(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06004DBB RID: 19899
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_SetDataOrigin_52(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the coordinates of the lower, left corner of the frame.
		/// Default: (0.0,0.0,0.0)
		/// </summary>
		// Token: 0x06004DBC RID: 19900 RVA: 0x000711E1 File Offset: 0x0006F3E1
		public virtual void SetDataOrigin(IntPtr _arg)
		{
			vtkVideoSource.vtkVideoSource_SetDataOrigin_52(base.GetCppThis(), _arg);
		}

		// Token: 0x06004DBD RID: 19901
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_SetDataSpacing_53(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the pixel spacing.
		/// Default: (1.0,1.0,1.0)
		/// </summary>
		// Token: 0x06004DBE RID: 19902 RVA: 0x000711F1 File Offset: 0x0006F3F1
		public virtual void SetDataSpacing(double _arg1, double _arg2, double _arg3)
		{
			vtkVideoSource.vtkVideoSource_SetDataSpacing_53(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06004DBF RID: 19903
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_SetDataSpacing_54(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the pixel spacing.
		/// Default: (1.0,1.0,1.0)
		/// </summary>
		// Token: 0x06004DC0 RID: 19904 RVA: 0x00071203 File Offset: 0x0006F403
		public virtual void SetDataSpacing(IntPtr _arg)
		{
			vtkVideoSource.vtkVideoSource_SetDataSpacing_54(base.GetCppThis(), _arg);
		}

		// Token: 0x06004DC1 RID: 19905
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_SetFrameBufferSize_55(HandleRef pThis, int FrameBufferSize);

		/// <summary>
		/// Set size of the frame buffer, i.e. the number of frames that
		/// the 'tape' can store.
		/// </summary>
		// Token: 0x06004DC2 RID: 19906 RVA: 0x00071213 File Offset: 0x0006F413
		public virtual void SetFrameBufferSize(int FrameBufferSize)
		{
			vtkVideoSource.vtkVideoSource_SetFrameBufferSize_55(base.GetCppThis(), FrameBufferSize);
		}

		// Token: 0x06004DC3 RID: 19907
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_SetFrameCount_56(HandleRef pThis, int _arg);

		/// <summary>
		/// This value is incremented each time a frame is grabbed.
		/// reset it to zero (or any other value) at any time.
		/// </summary>
		// Token: 0x06004DC4 RID: 19908 RVA: 0x00071223 File Offset: 0x0006F423
		public virtual void SetFrameCount(int _arg)
		{
			vtkVideoSource.vtkVideoSource_SetFrameCount_56(base.GetCppThis(), _arg);
		}

		// Token: 0x06004DC5 RID: 19909
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_SetFrameRate_57(HandleRef pThis, float rate);

		/// <summary>
		/// Request a particular frame rate (default 30 frames per second).
		/// </summary>
		// Token: 0x06004DC6 RID: 19910 RVA: 0x00071233 File Offset: 0x0006F433
		public virtual void SetFrameRate(float rate)
		{
			vtkVideoSource.vtkVideoSource_SetFrameRate_57(base.GetCppThis(), rate);
		}

		// Token: 0x06004DC7 RID: 19911
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_SetFrameSize_58(HandleRef pThis, int x, int y, int z);

		/// <summary>
		/// Set the full-frame size.  This must be an allowed size for the device,
		/// the device may either refuse a request for an illegal frame size or
		/// automatically choose a new frame size.
		/// The default is usually 320x240x1, but can be device specific.
		/// The 'depth' should always be 1 (unless you have a device that
		/// can handle 3D acquisition).
		/// </summary>
		// Token: 0x06004DC8 RID: 19912 RVA: 0x00071243 File Offset: 0x0006F443
		public virtual void SetFrameSize(int x, int y, int z)
		{
			vtkVideoSource.vtkVideoSource_SetFrameSize_58(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06004DC9 RID: 19913
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_SetFrameSize_59(HandleRef pThis, IntPtr dim);

		/// <summary>
		/// Set the full-frame size.  This must be an allowed size for the device,
		/// the device may either refuse a request for an illegal frame size or
		/// automatically choose a new frame size.
		/// The default is usually 320x240x1, but can be device specific.
		/// The 'depth' should always be 1 (unless you have a device that
		/// can handle 3D acquisition).
		/// </summary>
		// Token: 0x06004DCA RID: 19914 RVA: 0x00071255 File Offset: 0x0006F455
		public virtual void SetFrameSize(IntPtr dim)
		{
			vtkVideoSource.vtkVideoSource_SetFrameSize_59(base.GetCppThis(), dim);
		}

		// Token: 0x06004DCB RID: 19915
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_SetNumberOfOutputFrames_60(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the number of frames to copy to the output on each execute.
		/// The frames will be concatenated along the Z dimension, with the
		/// most recent frame first.
		/// Default: 1
		/// </summary>
		// Token: 0x06004DCC RID: 19916 RVA: 0x00071265 File Offset: 0x0006F465
		public virtual void SetNumberOfOutputFrames(int _arg)
		{
			vtkVideoSource.vtkVideoSource_SetNumberOfOutputFrames_60(base.GetCppThis(), _arg);
		}

		// Token: 0x06004DCD RID: 19917
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_SetOpacity_61(HandleRef pThis, float _arg);

		/// <summary>
		/// For RGBA output only (4 scalar components), set the opacity.  This
		/// will not modify the existing contents of the framebuffer, only
		/// subsequently grabbed frames.
		/// </summary>
		// Token: 0x06004DCE RID: 19918 RVA: 0x00071275 File Offset: 0x0006F475
		public virtual void SetOpacity(float _arg)
		{
			vtkVideoSource.vtkVideoSource_SetOpacity_61(base.GetCppThis(), _arg);
		}

		// Token: 0x06004DCF RID: 19919
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_SetOutputFormat_62(HandleRef pThis, int format);

		/// <summary>
		/// Set the output format.  This must be appropriate for device,
		/// usually only VTK_LUMINANCE, VTK_RGB, and VTK_RGBA are supported.
		/// </summary>
		// Token: 0x06004DD0 RID: 19920 RVA: 0x00071285 File Offset: 0x0006F485
		public virtual void SetOutputFormat(int format)
		{
			vtkVideoSource.vtkVideoSource_SetOutputFormat_62(base.GetCppThis(), format);
		}

		// Token: 0x06004DD1 RID: 19921
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_SetOutputFormatToLuminance_63(HandleRef pThis);

		/// <summary>
		/// Set the output format.  This must be appropriate for device,
		/// usually only VTK_LUMINANCE, VTK_RGB, and VTK_RGBA are supported.
		/// </summary>
		// Token: 0x06004DD2 RID: 19922 RVA: 0x00071295 File Offset: 0x0006F495
		public void SetOutputFormatToLuminance()
		{
			vtkVideoSource.vtkVideoSource_SetOutputFormatToLuminance_63(base.GetCppThis());
		}

		// Token: 0x06004DD3 RID: 19923
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_SetOutputFormatToRGB_64(HandleRef pThis);

		/// <summary>
		/// Set the output format.  This must be appropriate for device,
		/// usually only VTK_LUMINANCE, VTK_RGB, and VTK_RGBA are supported.
		/// </summary>
		// Token: 0x06004DD4 RID: 19924 RVA: 0x000712A4 File Offset: 0x0006F4A4
		public void SetOutputFormatToRGB()
		{
			vtkVideoSource.vtkVideoSource_SetOutputFormatToRGB_64(base.GetCppThis());
		}

		// Token: 0x06004DD5 RID: 19925
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_SetOutputFormatToRGBA_65(HandleRef pThis);

		/// <summary>
		/// Set the output format.  This must be appropriate for device,
		/// usually only VTK_LUMINANCE, VTK_RGB, and VTK_RGBA are supported.
		/// </summary>
		// Token: 0x06004DD6 RID: 19926 RVA: 0x000712B3 File Offset: 0x0006F4B3
		public void SetOutputFormatToRGBA()
		{
			vtkVideoSource.vtkVideoSource_SetOutputFormatToRGBA_65(base.GetCppThis());
		}

		// Token: 0x06004DD7 RID: 19927
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_SetOutputWholeExtent_66(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		/// <summary>
		/// Get/Set the WholeExtent of the output.  This can be used to either
		/// clip or pad the video frame.  This clipping/padding is done when
		/// the frame is copied to the output, and does not change the contents
		/// of the framebuffer.  This is useful e.g. for expanding
		/// the output size to a power of two for texture mapping.  The
		/// default is (0,-1,0,-1,0,-1) which causes the entire frame to be
		/// copied to the output.
		/// </summary>
		// Token: 0x06004DD8 RID: 19928 RVA: 0x000712C2 File Offset: 0x0006F4C2
		public virtual void SetOutputWholeExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkVideoSource.vtkVideoSource_SetOutputWholeExtent_66(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x06004DD9 RID: 19929
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_SetOutputWholeExtent_67(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get/Set the WholeExtent of the output.  This can be used to either
		/// clip or pad the video frame.  This clipping/padding is done when
		/// the frame is copied to the output, and does not change the contents
		/// of the framebuffer.  This is useful e.g. for expanding
		/// the output size to a power of two for texture mapping.  The
		/// default is (0,-1,0,-1,0,-1) which causes the entire frame to be
		/// copied to the output.
		/// </summary>
		// Token: 0x06004DDA RID: 19930 RVA: 0x000712DA File Offset: 0x0006F4DA
		public virtual void SetOutputWholeExtent(IntPtr _arg)
		{
			vtkVideoSource.vtkVideoSource_SetOutputWholeExtent_67(base.GetCppThis(), _arg);
		}

		// Token: 0x06004DDB RID: 19931
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_SetStartTimeStamp_68(HandleRef pThis, double t);

		/// <summary>
		/// And internal variable which marks the beginning of a Record session.
		/// These methods are for internal use only.
		/// </summary>
		// Token: 0x06004DDC RID: 19932 RVA: 0x000712EA File Offset: 0x0006F4EA
		public void SetStartTimeStamp(double t)
		{
			vtkVideoSource.vtkVideoSource_SetStartTimeStamp_68(base.GetCppThis(), t);
		}

		// Token: 0x06004DDD RID: 19933
		[DllImport("Kitware.VTK.IOVideo.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVideoSource_Stop_69(HandleRef pThis);

		/// <summary>
		/// Stop recording or playing.
		/// </summary>
		// Token: 0x06004DDE RID: 19934 RVA: 0x000712FA File Offset: 0x0006F4FA
		public virtual void Stop()
		{
			vtkVideoSource.vtkVideoSource_Stop_69(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400077B RID: 1915
		public new const string MRFullTypeName = "Kitware.VTK.vtkVideoSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400077C RID: 1916
		public new static readonly string MRClassNameKey = "class vtkVideoSource";
	}
}
