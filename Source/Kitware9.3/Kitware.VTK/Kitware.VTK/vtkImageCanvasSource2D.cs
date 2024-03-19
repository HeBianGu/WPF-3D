using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageCanvasSource2D
	/// </summary>
	/// <remarks>
	///    Paints on a canvas
	///
	/// vtkImageCanvasSource2D is a source that starts as a blank image.
	/// you may add to the image with two-dimensional drawing routines.
	/// It can paint multi-spectral images.
	/// </remarks>
	// Token: 0x02000754 RID: 1876
	public class vtkImageCanvasSource2D : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601370B RID: 79627 RVA: 0x001B81A3 File Offset: 0x001B63A3
		static vtkImageCanvasSource2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageCanvasSource2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageCanvasSource2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601370C RID: 79628 RVA: 0x001B81CB File Offset: 0x001B63CB
		public vtkImageCanvasSource2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601370D RID: 79629
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCanvasSource2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct an instance of vtkImageCanvasSource2D with no data.
		/// </summary>
		// Token: 0x0601370E RID: 79630 RVA: 0x001B81DC File Offset: 0x001B63DC
		public new static vtkImageCanvasSource2D New()
		{
			vtkImageCanvasSource2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageCanvasSource2D.vtkImageCanvasSource2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageCanvasSource2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct an instance of vtkImageCanvasSource2D with no data.
		/// </summary>
		// Token: 0x0601370F RID: 79631 RVA: 0x001B8230 File Offset: 0x001B6430
		public vtkImageCanvasSource2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageCanvasSource2D.vtkImageCanvasSource2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013710 RID: 79632 RVA: 0x001B8274 File Offset: 0x001B6474
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013711 RID: 79633
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_DrawCircle_01(HandleRef pThis, int c0, int c1, double radius);

		/// <summary>
		/// Set the pixels inside the box (min0, max0, min1, max1) to the current
		/// DrawColor
		/// </summary>
		// Token: 0x06013712 RID: 79634 RVA: 0x001B827F File Offset: 0x001B647F
		public void DrawCircle(int c0, int c1, double radius)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_DrawCircle_01(base.GetCppThis(), c0, c1, radius);
		}

		// Token: 0x06013713 RID: 79635
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_DrawImage_02(HandleRef pThis, int x0, int y0, HandleRef i);

		/// <summary>
		/// Draw subimage of the input image in the canvas at position x0 and
		/// y0. The subimage is defined with sx, sy, width, and height.
		/// </summary>
		// Token: 0x06013714 RID: 79636 RVA: 0x001B8294 File Offset: 0x001B6494
		public void DrawImage(int x0, int y0, vtkImageData i)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_DrawImage_02(base.GetCppThis(), x0, y0, (i == null) ? default(HandleRef) : i.GetCppThis());
		}

		// Token: 0x06013715 RID: 79637
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_DrawImage_03(HandleRef pThis, int x0, int y0, HandleRef arg2, int sx, int sy, int width, int height);

		/// <summary>
		/// Draw subimage of the input image in the canvas at position x0 and
		/// y0. The subimage is defined with sx, sy, width, and height.
		/// </summary>
		// Token: 0x06013716 RID: 79638 RVA: 0x001B82C8 File Offset: 0x001B64C8
		public void DrawImage(int x0, int y0, vtkImageData arg2, int sx, int sy, int width, int height)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_DrawImage_03(base.GetCppThis(), x0, y0, (arg2 == null) ? default(HandleRef) : arg2.GetCppThis(), sx, sy, width, height);
		}

		// Token: 0x06013717 RID: 79639
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_DrawPoint_04(HandleRef pThis, int p0, int p1);

		/// <summary>
		/// Set the pixels inside the box (min0, max0, min1, max1) to the current
		/// DrawColor
		/// </summary>
		// Token: 0x06013718 RID: 79640 RVA: 0x001B8301 File Offset: 0x001B6501
		public void DrawPoint(int p0, int p1)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_DrawPoint_04(base.GetCppThis(), p0, p1);
		}

		// Token: 0x06013719 RID: 79641
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_DrawSegment_05(HandleRef pThis, int x0, int y0, int x1, int y1);

		/// <summary>
		/// Set the pixels inside the box (min0, max0, min1, max1) to the current
		/// DrawColor
		/// </summary>
		// Token: 0x0601371A RID: 79642 RVA: 0x001B8312 File Offset: 0x001B6512
		public void DrawSegment(int x0, int y0, int x1, int y1)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_DrawSegment_05(base.GetCppThis(), x0, y0, x1, y1);
		}

		// Token: 0x0601371B RID: 79643
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_DrawSegment3D_06(HandleRef pThis, IntPtr p0, IntPtr p1);

		/// <summary>
		/// Set the pixels inside the box (min0, max0, min1, max1) to the current
		/// DrawColor
		/// </summary>
		// Token: 0x0601371C RID: 79644 RVA: 0x001B8326 File Offset: 0x001B6526
		public void DrawSegment3D(IntPtr p0, IntPtr p1)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_DrawSegment3D_06(base.GetCppThis(), p0, p1);
		}

		// Token: 0x0601371D RID: 79645
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_DrawSegment3D_07(HandleRef pThis, double x1, double y1, double z1, double x2, double y2, double z2);

		/// <summary>
		/// Set the pixels inside the box (min0, max0, min1, max1) to the current
		/// DrawColor
		/// </summary>
		// Token: 0x0601371E RID: 79646 RVA: 0x001B8337 File Offset: 0x001B6537
		public void DrawSegment3D(double x1, double y1, double z1, double x2, double y2, double z2)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_DrawSegment3D_07(base.GetCppThis(), x1, y1, z1, x2, y2, z2);
		}

		// Token: 0x0601371F RID: 79647
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_FillBox_08(HandleRef pThis, int min0, int max0, int min1, int max1);

		/// <summary>
		/// Set the pixels inside the box (min0, max0, min1, max1) to the current
		/// DrawColor
		/// </summary>
		// Token: 0x06013720 RID: 79648 RVA: 0x001B834F File Offset: 0x001B654F
		public void FillBox(int min0, int max0, int min1, int max1)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_FillBox_08(base.GetCppThis(), min0, max0, min1, max1);
		}

		// Token: 0x06013721 RID: 79649
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_FillPixel_09(HandleRef pThis, int x, int y);

		/// <summary>
		/// Fill a colored area with another color. (like connectivity)
		/// All pixels connected (and with the same value) to pixel (x, y)
		/// get replaced by the current "DrawColor".
		/// </summary>
		// Token: 0x06013722 RID: 79650 RVA: 0x001B8363 File Offset: 0x001B6563
		public void FillPixel(int x, int y)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_FillPixel_09(base.GetCppThis(), x, y);
		}

		// Token: 0x06013723 RID: 79651
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_FillTriangle_10(HandleRef pThis, int x0, int y0, int x1, int y1, int x2, int y2);

		/// <summary>
		/// Set the pixels inside the box (min0, max0, min1, max1) to the current
		/// DrawColor
		/// </summary>
		// Token: 0x06013724 RID: 79652 RVA: 0x001B8374 File Offset: 0x001B6574
		public void FillTriangle(int x0, int y0, int x1, int y1, int x2, int y2)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_FillTriangle_10(base.GetCppThis(), x0, y0, x1, y1, x2, y2);
		}

		// Token: 0x06013725 RID: 79653
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_FillTube_11(HandleRef pThis, int x0, int y0, int x1, int y1, double radius);

		/// <summary>
		/// Set the pixels inside the box (min0, max0, min1, max1) to the current
		/// DrawColor
		/// </summary>
		// Token: 0x06013726 RID: 79654 RVA: 0x001B838C File Offset: 0x001B658C
		public void FillTube(int x0, int y0, int x1, int y1, double radius)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_FillTube_11(base.GetCppThis(), x0, y0, x1, y1, radius);
		}

		// Token: 0x06013727 RID: 79655
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageCanvasSource2D_GetDefaultZ_12(HandleRef pThis);

		/// <summary>
		/// The drawing operations can only draw into one 2D XY plane at a time.
		/// If the canvas is a 3D volume, then this z value is used
		/// as the default for 2D operations. The default is 0.
		/// </summary>
		// Token: 0x06013728 RID: 79656 RVA: 0x001B83A4 File Offset: 0x001B65A4
		public virtual int GetDefaultZ()
		{
			return vtkImageCanvasSource2D.vtkImageCanvasSource2D_GetDefaultZ_12(base.GetCppThis());
		}

		// Token: 0x06013729 RID: 79657
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCanvasSource2D_GetDrawColor_13(HandleRef pThis);

		/// <summary>
		/// Set/Get DrawColor.  This is the value that is used when filling data
		/// or drawing lines. Default is (0,0,0,0)
		/// </summary>
		// Token: 0x0601372A RID: 79658 RVA: 0x001B83C4 File Offset: 0x001B65C4
		public virtual double[] GetDrawColor()
		{
			IntPtr intPtr = vtkImageCanvasSource2D.vtkImageCanvasSource2D_GetDrawColor_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601372B RID: 79659
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_GetDrawColor_14(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		/// <summary>
		/// Set/Get DrawColor.  This is the value that is used when filling data
		/// or drawing lines. Default is (0,0,0,0)
		/// </summary>
		// Token: 0x0601372C RID: 79660 RVA: 0x001B840C File Offset: 0x001B660C
		public virtual void GetDrawColor(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_GetDrawColor_14(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x0601372D RID: 79661
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_GetDrawColor_15(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get DrawColor.  This is the value that is used when filling data
		/// or drawing lines. Default is (0,0,0,0)
		/// </summary>
		// Token: 0x0601372E RID: 79662 RVA: 0x001B8420 File Offset: 0x001B6620
		public virtual void GetDrawColor(IntPtr _arg)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_GetDrawColor_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0601372F RID: 79663
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageCanvasSource2D_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct an instance of vtkImageCanvasSource2D with no data.
		/// </summary>
		// Token: 0x06013730 RID: 79664 RVA: 0x001B8430 File Offset: 0x001B6630
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageCanvasSource2D.vtkImageCanvasSource2D_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x06013731 RID: 79665
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageCanvasSource2D_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct an instance of vtkImageCanvasSource2D with no data.
		/// </summary>
		// Token: 0x06013732 RID: 79666 RVA: 0x001B8450 File Offset: 0x001B6650
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageCanvasSource2D.vtkImageCanvasSource2D_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x06013733 RID: 79667
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageCanvasSource2D_GetNumberOfScalarComponents_18(HandleRef pThis);

		/// <summary>
		/// Set the number of scalar components
		/// </summary>
		// Token: 0x06013734 RID: 79668 RVA: 0x001B846C File Offset: 0x001B666C
		public virtual int GetNumberOfScalarComponents()
		{
			return vtkImageCanvasSource2D.vtkImageCanvasSource2D_GetNumberOfScalarComponents_18(base.GetCppThis());
		}

		// Token: 0x06013735 RID: 79669
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCanvasSource2D_GetRatio_19(HandleRef pThis);

		/// <summary>
		/// Set/Get Ratio. This is the value that is used to pre-multiply each
		/// (x, y, z) drawing coordinates (including DefaultZ). The default
		/// is (1, 1, 1)
		/// </summary>
		// Token: 0x06013736 RID: 79670 RVA: 0x001B848C File Offset: 0x001B668C
		public virtual double[] GetRatio()
		{
			IntPtr intPtr = vtkImageCanvasSource2D.vtkImageCanvasSource2D_GetRatio_19(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06013737 RID: 79671
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_GetRatio_20(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get Ratio. This is the value that is used to pre-multiply each
		/// (x, y, z) drawing coordinates (including DefaultZ). The default
		/// is (1, 1, 1)
		/// </summary>
		// Token: 0x06013738 RID: 79672 RVA: 0x001B84D4 File Offset: 0x001B66D4
		public virtual void GetRatio(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_GetRatio_20(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06013739 RID: 79673
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_GetRatio_21(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get Ratio. This is the value that is used to pre-multiply each
		/// (x, y, z) drawing coordinates (including DefaultZ). The default
		/// is (1, 1, 1)
		/// </summary>
		// Token: 0x0601373A RID: 79674 RVA: 0x001B84E6 File Offset: 0x001B66E6
		public virtual void GetRatio(IntPtr _arg)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_GetRatio_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0601373B RID: 79675
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageCanvasSource2D_GetScalarType_22(HandleRef pThis);

		/// <summary>
		/// Set/Get the data scalar type (i.e VTK_DOUBLE). Note that these methods
		/// are setting and getting the pipeline scalar type. i.e. they are setting
		/// the type that the image data will be once it has executed. Until the
		/// REQUEST_DATA pass the actual scalars may be of some other type. This is
		/// for backwards compatibility
		/// </summary>
		// Token: 0x0601373C RID: 79676 RVA: 0x001B84F8 File Offset: 0x001B66F8
		public int GetScalarType()
		{
			return vtkImageCanvasSource2D.vtkImageCanvasSource2D_GetScalarType_22(base.GetCppThis());
		}

		// Token: 0x0601373D RID: 79677
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_InitializeCanvasVolume_23(HandleRef pThis, HandleRef volume);

		/// <summary>
		/// Initialize the canvas with a given volume
		/// </summary>
		// Token: 0x0601373E RID: 79678 RVA: 0x001B8518 File Offset: 0x001B6718
		public void InitializeCanvasVolume(vtkImageData volume)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_InitializeCanvasVolume_23(base.GetCppThis(), (volume == null) ? default(HandleRef) : volume.GetCppThis());
		}

		// Token: 0x0601373F RID: 79679
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageCanvasSource2D_IsA_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct an instance of vtkImageCanvasSource2D with no data.
		/// </summary>
		// Token: 0x06013740 RID: 79680 RVA: 0x001B8548 File Offset: 0x001B6748
		public override int IsA(string type)
		{
			return vtkImageCanvasSource2D.vtkImageCanvasSource2D_IsA_24(base.GetCppThis(), type);
		}

		// Token: 0x06013741 RID: 79681
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageCanvasSource2D_IsTypeOf_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct an instance of vtkImageCanvasSource2D with no data.
		/// </summary>
		// Token: 0x06013742 RID: 79682 RVA: 0x001B8568 File Offset: 0x001B6768
		public new static int IsTypeOf(string type)
		{
			return vtkImageCanvasSource2D.vtkImageCanvasSource2D_IsTypeOf_25(type);
		}

		// Token: 0x06013743 RID: 79683
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCanvasSource2D_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct an instance of vtkImageCanvasSource2D with no data.
		/// </summary>
		// Token: 0x06013744 RID: 79684 RVA: 0x001B8584 File Offset: 0x001B6784
		public new vtkImageCanvasSource2D NewInstance()
		{
			vtkImageCanvasSource2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageCanvasSource2D.vtkImageCanvasSource2D_NewInstance_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageCanvasSource2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013745 RID: 79685
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCanvasSource2D_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct an instance of vtkImageCanvasSource2D with no data.
		/// </summary>
		// Token: 0x06013746 RID: 79686 RVA: 0x001B85E0 File Offset: 0x001B67E0
		public new static vtkImageCanvasSource2D SafeDownCast(vtkObjectBase o)
		{
			vtkImageCanvasSource2D vtkImageCanvasSource2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageCanvasSource2D.vtkImageCanvasSource2D_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageCanvasSource2D = (vtkImageCanvasSource2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageCanvasSource2D.Register(null);
				}
			}
			return vtkImageCanvasSource2D;
		}

		// Token: 0x06013747 RID: 79687
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_SetDefaultZ_29(HandleRef pThis, int _arg);

		/// <summary>
		/// The drawing operations can only draw into one 2D XY plane at a time.
		/// If the canvas is a 3D volume, then this z value is used
		/// as the default for 2D operations. The default is 0.
		/// </summary>
		// Token: 0x06013748 RID: 79688 RVA: 0x001B865F File Offset: 0x001B685F
		public virtual void SetDefaultZ(int _arg)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetDefaultZ_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06013749 RID: 79689
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_SetDrawColor_30(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		/// <summary>
		/// Set/Get DrawColor.  This is the value that is used when filling data
		/// or drawing lines. Default is (0,0,0,0)
		/// </summary>
		// Token: 0x0601374A RID: 79690 RVA: 0x001B866F File Offset: 0x001B686F
		public virtual void SetDrawColor(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetDrawColor_30(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x0601374B RID: 79691
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_SetDrawColor_31(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get DrawColor.  This is the value that is used when filling data
		/// or drawing lines. Default is (0,0,0,0)
		/// </summary>
		// Token: 0x0601374C RID: 79692 RVA: 0x001B8683 File Offset: 0x001B6883
		public virtual void SetDrawColor(IntPtr _arg)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetDrawColor_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0601374D RID: 79693
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_SetDrawColor_32(HandleRef pThis, double a);

		/// <summary>
		/// Set DrawColor to (a, 0, 0, 0)
		/// </summary>
		// Token: 0x0601374E RID: 79694 RVA: 0x001B8693 File Offset: 0x001B6893
		public void SetDrawColor(double a)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetDrawColor_32(base.GetCppThis(), a);
		}

		// Token: 0x0601374F RID: 79695
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_SetDrawColor_33(HandleRef pThis, double a, double b);

		/// <summary>
		/// Set DrawColor to (a, b, 0, 0)
		/// </summary>
		// Token: 0x06013750 RID: 79696 RVA: 0x001B86A3 File Offset: 0x001B68A3
		public void SetDrawColor(double a, double b)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetDrawColor_33(base.GetCppThis(), a, b);
		}

		// Token: 0x06013751 RID: 79697
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_SetDrawColor_34(HandleRef pThis, double a, double b, double c);

		/// <summary>
		/// Set DrawColor to (a, b, c, 0)
		/// </summary>
		// Token: 0x06013752 RID: 79698 RVA: 0x001B86B4 File Offset: 0x001B68B4
		public void SetDrawColor(double a, double b, double c)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetDrawColor_34(base.GetCppThis(), a, b, c);
		}

		// Token: 0x06013753 RID: 79699
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_SetExtent_35(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// These methods set the WholeExtent of the output
		/// It sets the size of the canvas.
		/// Extent is a min max 3D box.  Minimums and maximums are inclusive.
		/// </summary>
		// Token: 0x06013754 RID: 79700 RVA: 0x001B86C6 File Offset: 0x001B68C6
		public void SetExtent(IntPtr extent)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetExtent_35(base.GetCppThis(), extent);
		}

		// Token: 0x06013755 RID: 79701
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_SetExtent_36(HandleRef pThis, int x1, int x2, int y1, int y2, int z1, int z2);

		/// <summary>
		/// These methods set the WholeExtent of the output
		/// It sets the size of the canvas.
		/// Extent is a min max 3D box.  Minimums and maximums are inclusive.
		/// </summary>
		// Token: 0x06013756 RID: 79702 RVA: 0x001B86D6 File Offset: 0x001B68D6
		public void SetExtent(int x1, int x2, int y1, int y2, int z1, int z2)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetExtent_36(base.GetCppThis(), x1, x2, y1, y2, z1, z2);
		}

		// Token: 0x06013757 RID: 79703
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_SetNumberOfScalarComponents_37(HandleRef pThis, int i);

		/// <summary>
		/// Set the number of scalar components
		/// </summary>
		// Token: 0x06013758 RID: 79704 RVA: 0x001B86EE File Offset: 0x001B68EE
		public virtual void SetNumberOfScalarComponents(int i)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetNumberOfScalarComponents_37(base.GetCppThis(), i);
		}

		// Token: 0x06013759 RID: 79705
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_SetRatio_38(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get Ratio. This is the value that is used to pre-multiply each
		/// (x, y, z) drawing coordinates (including DefaultZ). The default
		/// is (1, 1, 1)
		/// </summary>
		// Token: 0x0601375A RID: 79706 RVA: 0x001B86FE File Offset: 0x001B68FE
		public virtual void SetRatio(double _arg1, double _arg2, double _arg3)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetRatio_38(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601375B RID: 79707
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_SetRatio_39(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get Ratio. This is the value that is used to pre-multiply each
		/// (x, y, z) drawing coordinates (including DefaultZ). The default
		/// is (1, 1, 1)
		/// </summary>
		// Token: 0x0601375C RID: 79708 RVA: 0x001B8710 File Offset: 0x001B6910
		public virtual void SetRatio(IntPtr _arg)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetRatio_39(base.GetCppThis(), _arg);
		}

		// Token: 0x0601375D RID: 79709
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_SetScalarType_40(HandleRef pThis, int arg0);

		/// <summary>
		/// Set/Get the data scalar type (i.e VTK_DOUBLE). Note that these methods
		/// are setting and getting the pipeline scalar type. i.e. they are setting
		/// the type that the image data will be once it has executed. Until the
		/// REQUEST_DATA pass the actual scalars may be of some other type. This is
		/// for backwards compatibility
		/// </summary>
		// Token: 0x0601375E RID: 79710 RVA: 0x001B8720 File Offset: 0x001B6920
		public void SetScalarType(int arg0)
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetScalarType_40(base.GetCppThis(), arg0);
		}

		// Token: 0x0601375F RID: 79711
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_SetScalarTypeToChar_41(HandleRef pThis);

		/// <summary>
		/// Set/Get the data scalar type (i.e VTK_DOUBLE). Note that these methods
		/// are setting and getting the pipeline scalar type. i.e. they are setting
		/// the type that the image data will be once it has executed. Until the
		/// REQUEST_DATA pass the actual scalars may be of some other type. This is
		/// for backwards compatibility
		/// </summary>
		// Token: 0x06013760 RID: 79712 RVA: 0x001B8730 File Offset: 0x001B6930
		public void SetScalarTypeToChar()
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetScalarTypeToChar_41(base.GetCppThis());
		}

		// Token: 0x06013761 RID: 79713
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_SetScalarTypeToDouble_42(HandleRef pThis);

		/// <summary>
		/// Set/Get the data scalar type (i.e VTK_DOUBLE). Note that these methods
		/// are setting and getting the pipeline scalar type. i.e. they are setting
		/// the type that the image data will be once it has executed. Until the
		/// REQUEST_DATA pass the actual scalars may be of some other type. This is
		/// for backwards compatibility
		/// </summary>
		// Token: 0x06013762 RID: 79714 RVA: 0x001B873F File Offset: 0x001B693F
		public void SetScalarTypeToDouble()
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetScalarTypeToDouble_42(base.GetCppThis());
		}

		// Token: 0x06013763 RID: 79715
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_SetScalarTypeToFloat_43(HandleRef pThis);

		/// <summary>
		/// Set/Get the data scalar type (i.e VTK_DOUBLE). Note that these methods
		/// are setting and getting the pipeline scalar type. i.e. they are setting
		/// the type that the image data will be once it has executed. Until the
		/// REQUEST_DATA pass the actual scalars may be of some other type. This is
		/// for backwards compatibility
		/// </summary>
		// Token: 0x06013764 RID: 79716 RVA: 0x001B874E File Offset: 0x001B694E
		public void SetScalarTypeToFloat()
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetScalarTypeToFloat_43(base.GetCppThis());
		}

		// Token: 0x06013765 RID: 79717
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_SetScalarTypeToInt_44(HandleRef pThis);

		/// <summary>
		/// Set/Get the data scalar type (i.e VTK_DOUBLE). Note that these methods
		/// are setting and getting the pipeline scalar type. i.e. they are setting
		/// the type that the image data will be once it has executed. Until the
		/// REQUEST_DATA pass the actual scalars may be of some other type. This is
		/// for backwards compatibility
		/// </summary>
		// Token: 0x06013766 RID: 79718 RVA: 0x001B875D File Offset: 0x001B695D
		public void SetScalarTypeToInt()
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetScalarTypeToInt_44(base.GetCppThis());
		}

		// Token: 0x06013767 RID: 79719
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_SetScalarTypeToLong_45(HandleRef pThis);

		/// <summary>
		/// Set/Get the data scalar type (i.e VTK_DOUBLE). Note that these methods
		/// are setting and getting the pipeline scalar type. i.e. they are setting
		/// the type that the image data will be once it has executed. Until the
		/// REQUEST_DATA pass the actual scalars may be of some other type. This is
		/// for backwards compatibility
		/// </summary>
		// Token: 0x06013768 RID: 79720 RVA: 0x001B876C File Offset: 0x001B696C
		public void SetScalarTypeToLong()
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetScalarTypeToLong_45(base.GetCppThis());
		}

		// Token: 0x06013769 RID: 79721
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_SetScalarTypeToShort_46(HandleRef pThis);

		/// <summary>
		/// Set/Get the data scalar type (i.e VTK_DOUBLE). Note that these methods
		/// are setting and getting the pipeline scalar type. i.e. they are setting
		/// the type that the image data will be once it has executed. Until the
		/// REQUEST_DATA pass the actual scalars may be of some other type. This is
		/// for backwards compatibility
		/// </summary>
		// Token: 0x0601376A RID: 79722 RVA: 0x001B877B File Offset: 0x001B697B
		public void SetScalarTypeToShort()
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetScalarTypeToShort_46(base.GetCppThis());
		}

		// Token: 0x0601376B RID: 79723
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_SetScalarTypeToUnsignedChar_47(HandleRef pThis);

		/// <summary>
		/// Set/Get the data scalar type (i.e VTK_DOUBLE). Note that these methods
		/// are setting and getting the pipeline scalar type. i.e. they are setting
		/// the type that the image data will be once it has executed. Until the
		/// REQUEST_DATA pass the actual scalars may be of some other type. This is
		/// for backwards compatibility
		/// </summary>
		// Token: 0x0601376C RID: 79724 RVA: 0x001B878A File Offset: 0x001B698A
		public void SetScalarTypeToUnsignedChar()
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetScalarTypeToUnsignedChar_47(base.GetCppThis());
		}

		// Token: 0x0601376D RID: 79725
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_SetScalarTypeToUnsignedInt_48(HandleRef pThis);

		/// <summary>
		/// Set/Get the data scalar type (i.e VTK_DOUBLE). Note that these methods
		/// are setting and getting the pipeline scalar type. i.e. they are setting
		/// the type that the image data will be once it has executed. Until the
		/// REQUEST_DATA pass the actual scalars may be of some other type. This is
		/// for backwards compatibility
		/// </summary>
		// Token: 0x0601376E RID: 79726 RVA: 0x001B8799 File Offset: 0x001B6999
		public void SetScalarTypeToUnsignedInt()
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetScalarTypeToUnsignedInt_48(base.GetCppThis());
		}

		// Token: 0x0601376F RID: 79727
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_SetScalarTypeToUnsignedLong_49(HandleRef pThis);

		/// <summary>
		/// Set/Get the data scalar type (i.e VTK_DOUBLE). Note that these methods
		/// are setting and getting the pipeline scalar type. i.e. they are setting
		/// the type that the image data will be once it has executed. Until the
		/// REQUEST_DATA pass the actual scalars may be of some other type. This is
		/// for backwards compatibility
		/// </summary>
		// Token: 0x06013770 RID: 79728 RVA: 0x001B87A8 File Offset: 0x001B69A8
		public void SetScalarTypeToUnsignedLong()
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetScalarTypeToUnsignedLong_49(base.GetCppThis());
		}

		// Token: 0x06013771 RID: 79729
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCanvasSource2D_SetScalarTypeToUnsignedShort_50(HandleRef pThis);

		/// <summary>
		/// Set/Get the data scalar type (i.e VTK_DOUBLE). Note that these methods
		/// are setting and getting the pipeline scalar type. i.e. they are setting
		/// the type that the image data will be once it has executed. Until the
		/// REQUEST_DATA pass the actual scalars may be of some other type. This is
		/// for backwards compatibility
		/// </summary>
		// Token: 0x06013772 RID: 79730 RVA: 0x001B87B7 File Offset: 0x001B69B7
		public void SetScalarTypeToUnsignedShort()
		{
			vtkImageCanvasSource2D.vtkImageCanvasSource2D_SetScalarTypeToUnsignedShort_50(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001685 RID: 5765
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageCanvasSource2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001686 RID: 5766
		public new static readonly string MRClassNameKey = "class vtkImageCanvasSource2D";
	}
}
