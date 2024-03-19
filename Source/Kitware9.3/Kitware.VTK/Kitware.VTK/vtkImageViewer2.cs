using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageViewer2
	/// </summary>
	/// <remarks>
	///    Display a 2D image.
	///
	/// vtkImageViewer2 is a convenience class for displaying a 2D image.  It
	/// packages up the functionality found in vtkRenderWindow, vtkRenderer,
	/// vtkImageActor and vtkImageMapToWindowLevelColors into a single easy to use
	/// class.  This class also creates an image interactor style
	/// (vtkInteractorStyleImage) that allows zooming and panning of images, and
	/// supports interactive window/level operations on the image. Note that
	/// vtkImageViewer2 is simply a wrapper around these classes.
	///
	/// vtkImageViewer2 uses the 3D rendering and texture mapping engine
	/// to draw an image on a plane.  This allows for rapid rendering,
	/// zooming, and panning. The image is placed in the 3D scene at a
	/// depth based on the z-coordinate of the particular image slice. Each
	/// call to SetSlice() changes the image data (slice) displayed AND
	/// changes the depth of the displayed slice in the 3D scene. This can
	/// be controlled by the AutoAdjustCameraClippingRange ivar of the
	/// InteractorStyle member.
	///
	/// It is possible to mix images and geometry, using the methods:
	///
	/// viewer-&gt;SetInputConnection( imageSource-&gt;GetOutputPort() );
	/// // or viewer-&gt;SetInputData ( image );
	/// viewer-&gt;GetRenderer()-&gt;AddActor( myActor );
	///
	/// This can be used to annotate an image with a PolyData of "edges" or
	/// or highlight sections of an image or display a 3D isosurface
	/// with a slice from the volume, etc. Any portions of your geometry
	/// that are in front of the displayed slice will be visible; any
	/// portions of your geometry that are behind the displayed slice will
	/// be obscured. A more general framework (with respect to viewing
	/// direction) for achieving this effect is provided by the
	/// vtkImagePlaneWidget .
	///
	/// Note that pressing 'r' will reset the window/level and pressing
	/// shift+'r' or control+'r' will reset the camera.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRenderWindow vtkRenderer vtkImageActor vtkImageMapToWindowLevelColors
	/// </seealso>
	// Token: 0x0200022E RID: 558
	public class vtkImageViewer2 : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600688F RID: 26767 RVA: 0x00097267 File Offset: 0x00095467
		static vtkImageViewer2()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageViewer2.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageViewer2"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006890 RID: 26768 RVA: 0x0009728F File Offset: 0x0009548F
		public vtkImageViewer2(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006891 RID: 26769
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageViewer2_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006892 RID: 26770 RVA: 0x000972A0 File Offset: 0x000954A0
		public new static vtkImageViewer2 New()
		{
			vtkImageViewer2 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageViewer2.vtkImageViewer2_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageViewer2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006893 RID: 26771 RVA: 0x000972F4 File Offset: 0x000954F4
		public vtkImageViewer2() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageViewer2.vtkImageViewer2_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006894 RID: 26772 RVA: 0x00097338 File Offset: 0x00095538
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006895 RID: 26773
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageViewer2_GetColorLevel_01(HandleRef pThis);

		/// <summary>
		/// Set window and level for mapping pixels to colors.
		/// </summary>
		// Token: 0x06006896 RID: 26774 RVA: 0x00097344 File Offset: 0x00095544
		public virtual double GetColorLevel()
		{
			return vtkImageViewer2.vtkImageViewer2_GetColorLevel_01(base.GetCppThis());
		}

		// Token: 0x06006897 RID: 26775
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageViewer2_GetColorWindow_02(HandleRef pThis);

		/// <summary>
		/// Set window and level for mapping pixels to colors.
		/// </summary>
		// Token: 0x06006898 RID: 26776 RVA: 0x00097364 File Offset: 0x00095564
		public virtual double GetColorWindow()
		{
			return vtkImageViewer2.vtkImageViewer2_GetColorWindow_02(base.GetCppThis());
		}

		// Token: 0x06006899 RID: 26777
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageViewer2_GetImageActor_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the internal render window, renderer, image actor, and
		/// image map instances.
		/// </summary>
		// Token: 0x0600689A RID: 26778 RVA: 0x00097384 File Offset: 0x00095584
		public virtual vtkImageActor GetImageActor()
		{
			vtkImageActor vtkImageActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageViewer2.vtkImageViewer2_GetImageActor_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageActor = (vtkImageActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageActor.Register(null);
				}
			}
			return vtkImageActor;
		}

		// Token: 0x0600689B RID: 26779
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageViewer2_GetInput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the input image to the viewer.
		/// </summary>
		// Token: 0x0600689C RID: 26780 RVA: 0x000973F4 File Offset: 0x000955F4
		public virtual vtkImageData GetInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageViewer2.vtkImageViewer2_GetInput_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600689D RID: 26781
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageViewer2_GetInteractorStyle_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the internal render window, renderer, image actor, and
		/// image map instances.
		/// </summary>
		// Token: 0x0600689E RID: 26782 RVA: 0x00097464 File Offset: 0x00095664
		public virtual vtkInteractorStyleImage GetInteractorStyle()
		{
			vtkInteractorStyleImage vtkInteractorStyleImage = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageViewer2.vtkImageViewer2_GetInteractorStyle_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleImage = (vtkInteractorStyleImage)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleImage.Register(null);
				}
			}
			return vtkInteractorStyleImage;
		}

		// Token: 0x0600689F RID: 26783
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageViewer2_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060068A0 RID: 26784 RVA: 0x000974D4 File Offset: 0x000956D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageViewer2.vtkImageViewer2_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x060068A1 RID: 26785
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageViewer2_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060068A2 RID: 26786 RVA: 0x000974F4 File Offset: 0x000956F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageViewer2.vtkImageViewer2_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x060068A3 RID: 26787
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageViewer2_GetOffScreenRendering_08(HandleRef pThis);

		/// <summary>
		/// Create a window in memory instead of on the screen. This may not
		/// be supported for every type of window and on some windows you may
		/// need to invoke this prior to the first render.
		/// </summary>
		// Token: 0x060068A4 RID: 26788 RVA: 0x00097510 File Offset: 0x00095710
		public virtual int GetOffScreenRendering()
		{
			return vtkImageViewer2.vtkImageViewer2_GetOffScreenRendering_08(base.GetCppThis());
		}

		// Token: 0x060068A5 RID: 26789
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageViewer2_GetPosition_09(HandleRef pThis);

		/// <summary>
		/// Get the position (x and y) of the rendering window in
		/// screen coordinates (in pixels).
		/// </summary>
		// Token: 0x060068A6 RID: 26790 RVA: 0x00097530 File Offset: 0x00095730
		public virtual IntPtr GetPosition()
		{
			return vtkImageViewer2.vtkImageViewer2_GetPosition_09(base.GetCppThis());
		}

		// Token: 0x060068A7 RID: 26791
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageViewer2_GetRenderWindow_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the internal render window, renderer, image actor, and
		/// image map instances.
		/// </summary>
		// Token: 0x060068A8 RID: 26792 RVA: 0x00097550 File Offset: 0x00095750
		public virtual vtkRenderWindow GetRenderWindow()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageViewer2.vtkImageViewer2_GetRenderWindow_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindow = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindow.Register(null);
				}
			}
			return vtkRenderWindow;
		}

		// Token: 0x060068A9 RID: 26793
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageViewer2_GetRenderer_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the internal render window, renderer, image actor, and
		/// image map instances.
		/// </summary>
		// Token: 0x060068AA RID: 26794 RVA: 0x000975C0 File Offset: 0x000957C0
		public virtual vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageViewer2.vtkImageViewer2_GetRenderer_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		// Token: 0x060068AB RID: 26795
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageViewer2_GetSize_12(HandleRef pThis);

		/// <summary>
		/// Get the size (width and height) of the rendering window in
		/// screen coordinates (in pixels).
		/// </summary>
		// Token: 0x060068AC RID: 26796 RVA: 0x00097630 File Offset: 0x00095830
		public virtual IntPtr GetSize()
		{
			return vtkImageViewer2.vtkImageViewer2_GetSize_12(base.GetCppThis());
		}

		// Token: 0x060068AD RID: 26797
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageViewer2_GetSlice_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the current slice to display (depending on the orientation
		/// this can be in X, Y or Z).
		/// </summary>
		// Token: 0x060068AE RID: 26798 RVA: 0x00097650 File Offset: 0x00095850
		public virtual int GetSlice()
		{
			return vtkImageViewer2.vtkImageViewer2_GetSlice_13(base.GetCppThis());
		}

		// Token: 0x060068AF RID: 26799
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageViewer2_GetSliceMax_14(HandleRef pThis);

		/// <summary>
		/// Return the minimum and maximum slice values (depending on the orientation
		/// this can be in X, Y or Z).
		/// </summary>
		// Token: 0x060068B0 RID: 26800 RVA: 0x00097670 File Offset: 0x00095870
		public virtual int GetSliceMax()
		{
			return vtkImageViewer2.vtkImageViewer2_GetSliceMax_14(base.GetCppThis());
		}

		// Token: 0x060068B1 RID: 26801
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageViewer2_GetSliceMin_15(HandleRef pThis);

		/// <summary>
		/// Return the minimum and maximum slice values (depending on the orientation
		/// this can be in X, Y or Z).
		/// </summary>
		// Token: 0x060068B2 RID: 26802 RVA: 0x00097690 File Offset: 0x00095890
		public virtual int GetSliceMin()
		{
			return vtkImageViewer2.vtkImageViewer2_GetSliceMin_15(base.GetCppThis());
		}

		// Token: 0x060068B3 RID: 26803
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageViewer2_GetSliceOrientation_16(HandleRef pThis);

		/// <summary>
		/// Set/get the slice orientation
		/// </summary>
		// Token: 0x060068B4 RID: 26804 RVA: 0x000976B0 File Offset: 0x000958B0
		public virtual int GetSliceOrientation()
		{
			return vtkImageViewer2.vtkImageViewer2_GetSliceOrientation_16(base.GetCppThis());
		}

		// Token: 0x060068B5 RID: 26805
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer2_GetSliceRange_17(HandleRef pThis, IntPtr range);

		/// <summary>
		/// Return the minimum and maximum slice values (depending on the orientation
		/// this can be in X, Y or Z).
		/// </summary>
		// Token: 0x060068B6 RID: 26806 RVA: 0x000976CF File Offset: 0x000958CF
		public virtual void GetSliceRange(IntPtr range)
		{
			vtkImageViewer2.vtkImageViewer2_GetSliceRange_17(base.GetCppThis(), range);
		}

		// Token: 0x060068B7 RID: 26807
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer2_GetSliceRange_18(HandleRef pThis, ref int min, ref int max);

		/// <summary>
		/// Return the minimum and maximum slice values (depending on the orientation
		/// this can be in X, Y or Z).
		/// </summary>
		// Token: 0x060068B8 RID: 26808 RVA: 0x000976DF File Offset: 0x000958DF
		public virtual void GetSliceRange(ref int min, ref int max)
		{
			vtkImageViewer2.vtkImageViewer2_GetSliceRange_18(base.GetCppThis(), ref min, ref max);
		}

		// Token: 0x060068B9 RID: 26809
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageViewer2_GetSliceRange_19(HandleRef pThis);

		/// <summary>
		/// Return the minimum and maximum slice values (depending on the orientation
		/// this can be in X, Y or Z).
		/// </summary>
		// Token: 0x060068BA RID: 26810 RVA: 0x000976F0 File Offset: 0x000958F0
		public virtual IntPtr GetSliceRange()
		{
			return vtkImageViewer2.vtkImageViewer2_GetSliceRange_19(base.GetCppThis());
		}

		// Token: 0x060068BB RID: 26811
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageViewer2_GetWindowLevel_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the internal render window, renderer, image actor, and
		/// image map instances.
		/// </summary>
		// Token: 0x060068BC RID: 26812 RVA: 0x00097710 File Offset: 0x00095910
		public virtual vtkImageMapToWindowLevelColors GetWindowLevel()
		{
			vtkImageMapToWindowLevelColors vtkImageMapToWindowLevelColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageViewer2.vtkImageViewer2_GetWindowLevel_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMapToWindowLevelColors = (vtkImageMapToWindowLevelColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMapToWindowLevelColors.Register(null);
				}
			}
			return vtkImageMapToWindowLevelColors;
		}

		// Token: 0x060068BD RID: 26813
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageViewer2_GetWindowName_21(HandleRef pThis);

		/// <summary>
		/// Get the name of rendering window.
		/// </summary>
		// Token: 0x060068BE RID: 26814 RVA: 0x00097780 File Offset: 0x00095980
		public virtual string GetWindowName()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageViewer2.vtkImageViewer2_GetWindowName_21(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060068BF RID: 26815
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageViewer2_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060068C0 RID: 26816 RVA: 0x000977BC File Offset: 0x000959BC
		public override int IsA(string type)
		{
			return vtkImageViewer2.vtkImageViewer2_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x060068C1 RID: 26817
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageViewer2_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060068C2 RID: 26818 RVA: 0x000977DC File Offset: 0x000959DC
		public new static int IsTypeOf(string type)
		{
			return vtkImageViewer2.vtkImageViewer2_IsTypeOf_23(type);
		}

		// Token: 0x060068C3 RID: 26819
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageViewer2_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060068C4 RID: 26820 RVA: 0x000977F8 File Offset: 0x000959F8
		public new vtkImageViewer2 NewInstance()
		{
			vtkImageViewer2 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageViewer2.vtkImageViewer2_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageViewer2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060068C5 RID: 26821
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer2_OffScreenRenderingOff_26(HandleRef pThis);

		/// <summary>
		/// Create a window in memory instead of on the screen. This may not
		/// be supported for every type of window and on some windows you may
		/// need to invoke this prior to the first render.
		/// </summary>
		// Token: 0x060068C6 RID: 26822 RVA: 0x00097852 File Offset: 0x00095A52
		public virtual void OffScreenRenderingOff()
		{
			vtkImageViewer2.vtkImageViewer2_OffScreenRenderingOff_26(base.GetCppThis());
		}

		// Token: 0x060068C7 RID: 26823
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer2_OffScreenRenderingOn_27(HandleRef pThis);

		/// <summary>
		/// Create a window in memory instead of on the screen. This may not
		/// be supported for every type of window and on some windows you may
		/// need to invoke this prior to the first render.
		/// </summary>
		// Token: 0x060068C8 RID: 26824 RVA: 0x00097861 File Offset: 0x00095A61
		public virtual void OffScreenRenderingOn()
		{
			vtkImageViewer2.vtkImageViewer2_OffScreenRenderingOn_27(base.GetCppThis());
		}

		// Token: 0x060068C9 RID: 26825
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer2_Render_28(HandleRef pThis);

		/// <summary>
		/// Render the resulting image.
		/// </summary>
		// Token: 0x060068CA RID: 26826 RVA: 0x00097870 File Offset: 0x00095A70
		public virtual void Render()
		{
			vtkImageViewer2.vtkImageViewer2_Render_28(base.GetCppThis());
		}

		// Token: 0x060068CB RID: 26827
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageViewer2_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060068CC RID: 26828 RVA: 0x00097880 File Offset: 0x00095A80
		public new static vtkImageViewer2 SafeDownCast(vtkObjectBase o)
		{
			vtkImageViewer2 vtkImageViewer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageViewer2.vtkImageViewer2_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageViewer = (vtkImageViewer2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageViewer.Register(null);
				}
			}
			return vtkImageViewer;
		}

		// Token: 0x060068CD RID: 26829
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer2_SetColorLevel_30(HandleRef pThis, double s);

		/// <summary>
		/// Set window and level for mapping pixels to colors.
		/// </summary>
		// Token: 0x060068CE RID: 26830 RVA: 0x000978FF File Offset: 0x00095AFF
		public virtual void SetColorLevel(double s)
		{
			vtkImageViewer2.vtkImageViewer2_SetColorLevel_30(base.GetCppThis(), s);
		}

		// Token: 0x060068CF RID: 26831
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer2_SetColorWindow_31(HandleRef pThis, double s);

		/// <summary>
		/// Set window and level for mapping pixels to colors.
		/// </summary>
		// Token: 0x060068D0 RID: 26832 RVA: 0x0009790F File Offset: 0x00095B0F
		public virtual void SetColorWindow(double s)
		{
			vtkImageViewer2.vtkImageViewer2_SetColorWindow_31(base.GetCppThis(), s);
		}

		// Token: 0x060068D1 RID: 26833
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer2_SetDisplayId_32(HandleRef pThis, IntPtr a);

		/// <summary>
		/// These are here when using a Tk window.
		/// </summary>
		// Token: 0x060068D2 RID: 26834 RVA: 0x0009791F File Offset: 0x00095B1F
		public virtual void SetDisplayId(IntPtr a)
		{
			vtkImageViewer2.vtkImageViewer2_SetDisplayId_32(base.GetCppThis(), a);
		}

		// Token: 0x060068D3 RID: 26835
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer2_SetInputConnection_33(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Set/Get the input image to the viewer.
		/// </summary>
		// Token: 0x060068D4 RID: 26836 RVA: 0x00097930 File Offset: 0x00095B30
		public virtual void SetInputConnection(vtkAlgorithmOutput input)
		{
			vtkImageViewer2.vtkImageViewer2_SetInputConnection_33(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x060068D5 RID: 26837
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer2_SetInputData_34(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the input image to the viewer.
		/// </summary>
		// Token: 0x060068D6 RID: 26838 RVA: 0x00097960 File Offset: 0x00095B60
		public virtual void SetInputData(vtkImageData arg0)
		{
			vtkImageViewer2.vtkImageViewer2_SetInputData_34(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060068D7 RID: 26839
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer2_SetOffScreenRendering_35(HandleRef pThis, int arg0);

		/// <summary>
		/// Create a window in memory instead of on the screen. This may not
		/// be supported for every type of window and on some windows you may
		/// need to invoke this prior to the first render.
		/// </summary>
		// Token: 0x060068D8 RID: 26840 RVA: 0x0009798F File Offset: 0x00095B8F
		public virtual void SetOffScreenRendering(int arg0)
		{
			vtkImageViewer2.vtkImageViewer2_SetOffScreenRendering_35(base.GetCppThis(), arg0);
		}

		// Token: 0x060068D9 RID: 26841
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer2_SetParentId_36(HandleRef pThis, IntPtr a);

		/// <summary>
		/// These are here when using a Tk window.
		/// </summary>
		// Token: 0x060068DA RID: 26842 RVA: 0x0009799F File Offset: 0x00095B9F
		public virtual void SetParentId(IntPtr a)
		{
			vtkImageViewer2.vtkImageViewer2_SetParentId_36(base.GetCppThis(), a);
		}

		// Token: 0x060068DB RID: 26843
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer2_SetPosition_37(HandleRef pThis, int x, int y);

		/// <summary>
		/// Set the position (x and y) of the rendering window in
		/// screen coordinates (in pixels). This resizes the operating
		/// system's view/window and redraws it.
		/// </summary>
		// Token: 0x060068DC RID: 26844 RVA: 0x000979AF File Offset: 0x00095BAF
		public virtual void SetPosition(int x, int y)
		{
			vtkImageViewer2.vtkImageViewer2_SetPosition_37(base.GetCppThis(), x, y);
		}

		// Token: 0x060068DD RID: 26845
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer2_SetPosition_38(HandleRef pThis, IntPtr a);

		/// <summary>
		/// Set the position (x and y) of the rendering window in
		/// screen coordinates (in pixels). This resizes the operating
		/// system's view/window and redraws it.
		/// </summary>
		// Token: 0x060068DE RID: 26846 RVA: 0x000979C0 File Offset: 0x00095BC0
		public virtual void SetPosition(IntPtr a)
		{
			vtkImageViewer2.vtkImageViewer2_SetPosition_38(base.GetCppThis(), a);
		}

		// Token: 0x060068DF RID: 26847
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer2_SetRenderWindow_39(HandleRef pThis, HandleRef arg);

		/// <summary>
		/// Set your own renderwindow and renderer
		/// </summary>
		// Token: 0x060068E0 RID: 26848 RVA: 0x000979D0 File Offset: 0x00095BD0
		public virtual void SetRenderWindow(vtkRenderWindow arg)
		{
			vtkImageViewer2.vtkImageViewer2_SetRenderWindow_39(base.GetCppThis(), (arg == null) ? default(HandleRef) : arg.GetCppThis());
		}

		// Token: 0x060068E1 RID: 26849
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer2_SetRenderer_40(HandleRef pThis, HandleRef arg);

		/// <summary>
		/// Set your own renderwindow and renderer
		/// </summary>
		// Token: 0x060068E2 RID: 26850 RVA: 0x00097A00 File Offset: 0x00095C00
		public virtual void SetRenderer(vtkRenderer arg)
		{
			vtkImageViewer2.vtkImageViewer2_SetRenderer_40(base.GetCppThis(), (arg == null) ? default(HandleRef) : arg.GetCppThis());
		}

		// Token: 0x060068E3 RID: 26851
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer2_SetSize_41(HandleRef pThis, int width, int height);

		/// <summary>
		/// Set the size (width and height) of the rendering window in
		/// screen coordinates (in pixels). This resizes the operating
		/// system's view/window and redraws it.
		///
		/// If the size has changed, this method will fire
		/// vtkCommand::WindowResizeEvent.
		/// </summary>
		// Token: 0x060068E4 RID: 26852 RVA: 0x00097A2F File Offset: 0x00095C2F
		public virtual void SetSize(int width, int height)
		{
			vtkImageViewer2.vtkImageViewer2_SetSize_41(base.GetCppThis(), width, height);
		}

		// Token: 0x060068E5 RID: 26853
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer2_SetSize_42(HandleRef pThis, IntPtr a);

		/// <summary>
		/// Set the size (width and height) of the rendering window in
		/// screen coordinates (in pixels). This resizes the operating
		/// system's view/window and redraws it.
		///
		/// If the size has changed, this method will fire
		/// vtkCommand::WindowResizeEvent.
		/// </summary>
		// Token: 0x060068E6 RID: 26854 RVA: 0x00097A40 File Offset: 0x00095C40
		public virtual void SetSize(IntPtr a)
		{
			vtkImageViewer2.vtkImageViewer2_SetSize_42(base.GetCppThis(), a);
		}

		// Token: 0x060068E7 RID: 26855
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer2_SetSlice_43(HandleRef pThis, int s);

		/// <summary>
		/// Set/Get the current slice to display (depending on the orientation
		/// this can be in X, Y or Z).
		/// </summary>
		// Token: 0x060068E8 RID: 26856 RVA: 0x00097A50 File Offset: 0x00095C50
		public virtual void SetSlice(int s)
		{
			vtkImageViewer2.vtkImageViewer2_SetSlice_43(base.GetCppThis(), s);
		}

		// Token: 0x060068E9 RID: 26857
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer2_SetSliceOrientation_44(HandleRef pThis, int orientation);

		/// <summary>
		/// Set/get the slice orientation
		/// </summary>
		// Token: 0x060068EA RID: 26858 RVA: 0x00097A60 File Offset: 0x00095C60
		public virtual void SetSliceOrientation(int orientation)
		{
			vtkImageViewer2.vtkImageViewer2_SetSliceOrientation_44(base.GetCppThis(), orientation);
		}

		// Token: 0x060068EB RID: 26859
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer2_SetSliceOrientationToXY_45(HandleRef pThis);

		/// <summary>
		/// Set/get the slice orientation
		/// </summary>
		// Token: 0x060068EC RID: 26860 RVA: 0x00097A70 File Offset: 0x00095C70
		public virtual void SetSliceOrientationToXY()
		{
			vtkImageViewer2.vtkImageViewer2_SetSliceOrientationToXY_45(base.GetCppThis());
		}

		// Token: 0x060068ED RID: 26861
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer2_SetSliceOrientationToXZ_46(HandleRef pThis);

		/// <summary>
		/// Set/get the slice orientation
		/// </summary>
		// Token: 0x060068EE RID: 26862 RVA: 0x00097A7F File Offset: 0x00095C7F
		public virtual void SetSliceOrientationToXZ()
		{
			vtkImageViewer2.vtkImageViewer2_SetSliceOrientationToXZ_46(base.GetCppThis());
		}

		// Token: 0x060068EF RID: 26863
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer2_SetSliceOrientationToYZ_47(HandleRef pThis);

		/// <summary>
		/// Set/get the slice orientation
		/// </summary>
		// Token: 0x060068F0 RID: 26864 RVA: 0x00097A8E File Offset: 0x00095C8E
		public virtual void SetSliceOrientationToYZ()
		{
			vtkImageViewer2.vtkImageViewer2_SetSliceOrientationToYZ_47(base.GetCppThis());
		}

		// Token: 0x060068F1 RID: 26865
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer2_SetWindowId_48(HandleRef pThis, IntPtr a);

		/// <summary>
		/// These are here when using a Tk window.
		/// </summary>
		// Token: 0x060068F2 RID: 26866 RVA: 0x00097A9D File Offset: 0x00095C9D
		public virtual void SetWindowId(IntPtr a)
		{
			vtkImageViewer2.vtkImageViewer2_SetWindowId_48(base.GetCppThis(), a);
		}

		// Token: 0x060068F3 RID: 26867
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer2_SetupInteractor_49(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Attach an interactor for the internal render window.
		/// </summary>
		// Token: 0x060068F4 RID: 26868 RVA: 0x00097AB0 File Offset: 0x00095CB0
		public virtual void SetupInteractor(vtkRenderWindowInteractor arg0)
		{
			vtkImageViewer2.vtkImageViewer2_SetupInteractor_49(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060068F5 RID: 26869
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageViewer2_UpdateDisplayExtent_50(HandleRef pThis);

		/// <summary>
		/// Update the display extent manually so that the proper slice for the
		/// given orientation is displayed. It will also try to set a
		/// reasonable camera clipping range.
		/// This method is called automatically when the Input is changed, but
		/// most of the time the input of this class is likely to remain the same,
		/// i.e. connected to the output of a filter, or an image reader. When the
		/// input of this filter or reader itself is changed, an error message might
		/// be displayed since the current display extent is probably outside
		/// the new whole extent. Calling this method will ensure that the display
		/// extent is reset properly.
		/// </summary>
		// Token: 0x060068F6 RID: 26870 RVA: 0x00097ADF File Offset: 0x00095CDF
		public virtual void UpdateDisplayExtent()
		{
			vtkImageViewer2.vtkImageViewer2_UpdateDisplayExtent_50(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000943 RID: 2371
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageViewer2";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000944 RID: 2372
		public new static readonly string MRClassNameKey = "class vtkImageViewer2";

		/// <summary>
		/// Set/get the slice orientation
		/// </summary>
		// Token: 0x0200022F RID: 559
		public enum SLICE_ORIENTATION_XY_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000946 RID: 2374
			SLICE_ORIENTATION_XY = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000947 RID: 2375
			SLICE_ORIENTATION_XZ = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000948 RID: 2376
			SLICE_ORIENTATION_YZ = 0
		}
	}
}
